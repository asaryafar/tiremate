Imports CommonClass
Public Class FrmEmployee
    Inherits FrmBase
    Dim Status As WorkStates = MainModule.WorkStates._ReadOnly
    Dim EmployeeOrderFieldName As String = "Employee_Code"
    Friend EmployeeCodTempVar As String = ""
    Dim PnlSearchHeight As Integer
    'Dim MyFrmItemComments As CommonClass.FrmItemComments
    Public EmployeeNoteVar As String
    Dim MyClsEmployeeCod As New ClsEmployeeCod
    Public MTypeOfForm As String ' 2=Sales Persons   -   3=technician Persons    -    1 OR Others =All Persons 
    Public Property TypeOfForm() As String
        Get
            Return MTypeOfForm
        End Get
        Set(ByVal Value As String)
            MTypeOfForm = Value
        End Set
    End Property
    Dim WhereClauseVarWithWhere As String = ""
    Dim WhereClauseVarWithoutWhere As String = ""
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
    Friend WithEvents DSFrmEmployee1 As DSUCEmployee
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
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents TxtEmail As EmailAndWebAddress.EmailAddress
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents _opt_last_status3 As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents BtnHistory As System.Windows.Forms.Button
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BtnNotes As System.Windows.Forms.Button
    Friend WithEvents Txtsocial_security_no1 As UCEmployee.SocialSecurityNoNo
    Friend WithEvents RDOlast_period4 As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents RDOlast_period3 As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents RDOlast_period2 As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents RDOlast_period1 As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents RDOlast_status3 As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents RDOlast_status4 As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents RDOlast_status2 As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents RDOlast_status1 As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents RDOlast_basis4 As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents RDOlast_basis3 As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents RDOlast_basis2 As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents RDOlast_basis1 As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents ChkTerminated As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTechnecian As System.Windows.Forms.CheckBox
    Friend WithEvents Chktemporary_inactive As System.Windows.Forms.CheckBox
    Friend WithEvents TxtEmployeecode As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAEmployee_deduction As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Txtl_name As System.Windows.Forms.TextBox
    Friend WithEvents Txtm_name As System.Windows.Forms.TextBox
    Friend WithEvents Txtf_name As System.Windows.Forms.TextBox
    Friend WithEvents ZipCode1 As UCZipCode.ZipCode
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAEmployee_position As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAEmployee_department As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents PhoneNoMain As UCPhone.PhoneNo
    Friend WithEvents UiCommandManager1 As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents UiContextMenu1 As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents Sort1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort3 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort11 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort21 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort31 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents TxtSt As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents TxtCity As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents Cmbcod_deparment As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbcod_position As System.Windows.Forms.ComboBox
    Friend WithEvents LblNetPay As System.Windows.Forms.TextBox
    Friend WithEvents LblDeductions As System.Windows.Forms.TextBox
    Friend WithEvents LblStateW_H As System.Windows.Forms.TextBox
    Friend WithEvents LblFederalW_H As System.Windows.Forms.TextBox
    Friend WithEvents LblMedicare As System.Windows.Forms.TextBox
    Friend WithEvents LblGrossPay As System.Windows.Forms.TextBox
    Friend WithEvents LblFICA As System.Windows.Forms.TextBox
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents PictureButton1 As UCPicture.PictureButton
    Friend WithEvents Dtebirthday_date As CalendarCombo.CalendarCombo
    Friend WithEvents Dtehired_date As CalendarCombo.CalendarCombo
    Friend WithEvents Dtelast_reiew_date As CalendarCombo.CalendarCombo
    Friend WithEvents DteLast_Raise As CalendarCombo.CalendarCombo
    Friend WithEvents Dteterminate_date As CalendarCombo.CalendarCombo
    Friend WithEvents PhoneButton1 As UCPhone.PhoneButton
    Friend WithEvents Txtlast_salary As CalcUtils.UcCalcText
    Friend WithEvents Txtlast_overtime As CalcUtils.UcCalcText
    Friend WithEvents Txtlast_hourly As CalcUtils.UcCalcText
    Friend WithEvents NumAllowancesState As CalcUtils.UcCalcText
    Friend WithEvents NumAllowancesFederal As CalcUtils.UcCalcText
    Friend WithEvents BtnLoan As Janus.Windows.EditControls.UIButton
    Friend WithEvents Employee_Cod1 As UCEmployee.Employee_Cod
    Friend WithEvents CnnForReader As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdGeneralForReader As System.Data.SqlClient.SqlCommand
    Friend WithEvents BtnSaving As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnGarnishment As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnDeduction As Janus.Windows.EditControls.UIButton
    Friend WithEvents NumAllowancesDepndnts As CalcUtils.UcCalcText
    Friend WithEvents CHKSalesPerson As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CnnMdbSetup As System.Data.OleDb.OleDbConnection
    Friend WithEvents DASTORE_SETUP As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents CmbStoreNo As System.Windows.Forms.ComboBox
    Friend WithEvents ChkUsePunchClock As System.Windows.Forms.CheckBox
    Friend WithEvents BtnBeginningPayroll As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEmployee))
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
        Me.DSFrmEmployee1 = New UCEmployee.DSUCEmployee
        Me.CmdDelete = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.Employee_Cod1 = New UCEmployee.Employee_Cod
        Me.Label4 = New System.Windows.Forms.Label
        Me.CnnTemp = New System.Data.SqlClient.SqlConnection
        Me.PnlKartAmvalField = New System.Windows.Forms.Panel
        Me.CmbStoreNo = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.ChkUsePunchClock = New System.Windows.Forms.CheckBox
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.CHKSalesPerson = New System.Windows.Forms.CheckBox
        Me.Dteterminate_date = New CalendarCombo.CalendarCombo
        Me.DteLast_Raise = New CalendarCombo.CalendarCombo
        Me.Dtelast_reiew_date = New CalendarCombo.CalendarCombo
        Me.Dtehired_date = New CalendarCombo.CalendarCombo
        Me.Dtebirthday_date = New CalendarCombo.CalendarCombo
        Me.PictureButton1 = New UCPicture.PictureButton
        Me.BtnNotes = New System.Windows.Forms.Button
        Me.ChkTerminated = New System.Windows.Forms.CheckBox
        Me.ChkTechnecian = New System.Windows.Forms.CheckBox
        Me.Chktemporary_inactive = New System.Windows.Forms.CheckBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.BtnHistory = New System.Windows.Forms.Button
        Me.LblNetPay = New System.Windows.Forms.TextBox
        Me.Label65 = New System.Windows.Forms.Label
        Me.LblDeductions = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.LblStateW_H = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.LblFederalW_H = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.LblMedicare = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.LblGrossPay = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.LblFICA = New System.Windows.Forms.TextBox
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.BtnDeduction = New Janus.Windows.EditControls.UIButton
        Me.BtnGarnishment = New Janus.Windows.EditControls.UIButton
        Me.BtnSaving = New Janus.Windows.EditControls.UIButton
        Me.BtnLoan = New Janus.Windows.EditControls.UIButton
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.RDOlast_period4 = New Janus.Windows.EditControls.UIRadioButton
        Me.RDOlast_period3 = New Janus.Windows.EditControls.UIRadioButton
        Me.RDOlast_period2 = New Janus.Windows.EditControls.UIRadioButton
        Me.RDOlast_period1 = New Janus.Windows.EditControls.UIRadioButton
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.RDOlast_status3 = New Janus.Windows.EditControls.UIRadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.RDOlast_status4 = New Janus.Windows.EditControls.UIRadioButton
        Me.RDOlast_status2 = New Janus.Windows.EditControls.UIRadioButton
        Me.RDOlast_status1 = New Janus.Windows.EditControls.UIRadioButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.RDOlast_basis4 = New Janus.Windows.EditControls.UIRadioButton
        Me.RDOlast_basis3 = New Janus.Windows.EditControls.UIRadioButton
        Me.RDOlast_basis2 = New Janus.Windows.EditControls.UIRadioButton
        Me.RDOlast_basis1 = New Janus.Windows.EditControls.UIRadioButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Txtlast_hourly = New CalcUtils.UcCalcText
        Me.Txtlast_overtime = New CalcUtils.UcCalcText
        Me.Txtlast_salary = New CalcUtils.UcCalcText
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.NumAllowancesDepndnts = New CalcUtils.UcCalcText
        Me.NumAllowancesState = New CalcUtils.UcCalcText
        Me.NumAllowancesFederal = New CalcUtils.UcCalcText
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PhoneButton1 = New UCPhone.PhoneButton
        Me.Txtsocial_security_no1 = New UCEmployee.SocialSecurityNoNo
        Me.TxtEmail = New EmailAndWebAddress.EmailAddress
        Me.ZipCode1 = New UCZipCode.ZipCode
        Me.TxtSt = New Janus.Windows.GridEX.EditControls.EditBox
        Me.PhoneNoMain = New UCPhone.PhoneNo
        Me.TxtCity = New Janus.Windows.GridEX.EditControls.EditBox
        Me.Label64 = New System.Windows.Forms.Label
        Me.Cmbcod_deparment = New System.Windows.Forms.ComboBox
        Me.Label63 = New System.Windows.Forms.Label
        Me.Cmbcod_position = New System.Windows.Forms.ComboBox
        Me.Label61 = New System.Windows.Forms.Label
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.Txtl_name = New System.Windows.Forms.TextBox
        Me.Label58 = New System.Windows.Forms.Label
        Me.Txtaddress = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Txtm_name = New System.Windows.Forms.TextBox
        Me.Label56 = New System.Windows.Forms.Label
        Me.Txtf_name = New System.Windows.Forms.TextBox
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtEmployeecode = New System.Windows.Forms.TextBox
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.CmdInsert = New System.Data.SqlClient.SqlCommand
        Me.CmdUpdate = New System.Data.SqlClient.SqlCommand
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label44 = New System.Windows.Forms.Label
        Me.BtnSortOrder = New Janus.Windows.EditControls.UIButton
        Me.UiContextMenu1 = New Janus.Windows.UI.CommandBars.UIContextMenu
        Me.UiCommandManager1 = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.Sort1 = New Janus.Windows.UI.CommandBars.UICommand("Sort1")
        Me.Sort2 = New Janus.Windows.UI.CommandBars.UICommand("Sort2")
        Me.Sort3 = New Janus.Windows.UI.CommandBars.UICommand("Sort3")
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
        Me._opt_last_status3 = New Janus.Windows.EditControls.UIRadioButton
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAEmployee_deduction = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAEmployee_position = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAEmployee_department = New System.Data.SqlClient.SqlDataAdapter
        Me.CnnForReader = New System.Data.SqlClient.SqlConnection
        Me.CmdGeneralForReader = New System.Data.SqlClient.SqlCommand
        Me.CnnMdbSetup = New System.Data.OleDb.OleDbConnection
        Me.DASTORE_SETUP = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand
        Me.BtnBeginningPayroll = New System.Windows.Forms.Button
        CType(Me.DSFrmEmployee1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlSearch.SuspendLayout()
        Me.PnlKartAmvalField.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        'DSFrmEmployee1
        '
        Me.DSFrmEmployee1.DataSetName = "DSUCEmployee"
        Me.DSFrmEmployee1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'CmdDelete
        '
        Me.CmdDelete.CommandText = "DELETE FROM employee WHERE (employee_code = @Employee_Code)"
        Me.CmdDelete.Connection = Me.Cnn
        Me.CmdDelete.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Employee_Code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employee_code", System.Data.DataRowVersion.Original, Nothing))
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.Employee_Cod1)
        Me.PnlSearch.Controls.Add(Me.Label4)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 45)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(652, 27)
        Me.PnlSearch.TabIndex = 0
        '
        'Employee_Cod1
        '
        Me.Employee_Cod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Employee_Cod1.Connection = Me.Cnn
        Me.Employee_Cod1.EmployeeCod = ""
        Me.Employee_Cod1.EmployeeCodLen = 5
        Me.Employee_Cod1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Employee_Cod1.Kind_Employee = ""
        Me.Employee_Cod1.Location = New System.Drawing.Point(57, 1)
        Me.Employee_Cod1.Name = "Employee_Cod1"
        Me.Employee_Cod1.NotExitIfNotFound = False
        Me.Employee_Cod1.ReleaseIfNotFoundEmployeeCod = False
        Me.Employee_Cod1.Size = New System.Drawing.Size(101, 20)
        Me.Employee_Cod1.TabIndex = 189
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(-4, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 12)
        Me.Label4.TabIndex = 188
        Me.Label4.Text = "Employee"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CnnTemp
        '
        Me.CnnTemp.ConnectionString = "workstation id=KETABIE;packet size=4096;user id=sa;data source=KETABIE;persist se" & _
        "curity info=True;initial catalog=TireMate_01;password=sa"
        '
        'PnlKartAmvalField
        '
        Me.PnlKartAmvalField.Controls.Add(Me.BtnBeginningPayroll)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbStoreNo)
        Me.PnlKartAmvalField.Controls.Add(Me.Label11)
        Me.PnlKartAmvalField.Controls.Add(Me.ChkUsePunchClock)
        Me.PnlKartAmvalField.Controls.Add(Me.Panel10)
        Me.PnlKartAmvalField.Controls.Add(Me.Panel8)
        Me.PnlKartAmvalField.Controls.Add(Me.Panel7)
        Me.PnlKartAmvalField.Controls.Add(Me.Panel6)
        Me.PnlKartAmvalField.Controls.Add(Me.Panel5)
        Me.PnlKartAmvalField.Controls.Add(Me.Panel4)
        Me.PnlKartAmvalField.Controls.Add(Me.Panel3)
        Me.PnlKartAmvalField.Controls.Add(Me.Panel2)
        Me.PnlKartAmvalField.Controls.Add(Me.Panel1)
        Me.PnlKartAmvalField.Controls.Add(Me.Label5)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtEmployeecode)
        Me.PnlKartAmvalField.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlKartAmvalField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PnlKartAmvalField.Location = New System.Drawing.Point(0, 72)
        Me.PnlKartAmvalField.Name = "PnlKartAmvalField"
        Me.PnlKartAmvalField.Size = New System.Drawing.Size(652, 317)
        Me.PnlKartAmvalField.TabIndex = 1
        '
        'CmbStoreNo
        '
        Me.CmbStoreNo.DataSource = Me.DSFrmEmployee1.Store_Setup
        Me.CmbStoreNo.DisplayMember = "SHORTNAME"
        Me.CmbStoreNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStoreNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbStoreNo.Location = New System.Drawing.Point(516, 4)
        Me.CmbStoreNo.Name = "CmbStoreNo"
        Me.CmbStoreNo.Size = New System.Drawing.Size(131, 21)
        Me.CmbStoreNo.TabIndex = 419
        Me.CmbStoreNo.ValueMember = "STORENO"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(465, 5)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 21)
        Me.Label11.TabIndex = 418
        Me.Label11.Text = "Store"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChkUsePunchClock
        '
        Me.ChkUsePunchClock.BackColor = System.Drawing.SystemColors.Control
        Me.ChkUsePunchClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkUsePunchClock.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkUsePunchClock.Location = New System.Drawing.Point(172, 6)
        Me.ChkUsePunchClock.Name = "ChkUsePunchClock"
        Me.ChkUsePunchClock.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkUsePunchClock.Size = New System.Drawing.Size(116, 16)
        Me.ChkUsePunchClock.TabIndex = 417
        Me.ChkUsePunchClock.Text = "Use Punch Clock"
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.CHKSalesPerson)
        Me.Panel10.Controls.Add(Me.Dteterminate_date)
        Me.Panel10.Controls.Add(Me.DteLast_Raise)
        Me.Panel10.Controls.Add(Me.Dtelast_reiew_date)
        Me.Panel10.Controls.Add(Me.Dtehired_date)
        Me.Panel10.Controls.Add(Me.Dtebirthday_date)
        Me.Panel10.Controls.Add(Me.PictureButton1)
        Me.Panel10.Controls.Add(Me.BtnNotes)
        Me.Panel10.Controls.Add(Me.ChkTerminated)
        Me.Panel10.Controls.Add(Me.ChkTechnecian)
        Me.Panel10.Controls.Add(Me.Chktemporary_inactive)
        Me.Panel10.Controls.Add(Me.Label13)
        Me.Panel10.Controls.Add(Me.Label36)
        Me.Panel10.Controls.Add(Me.Label37)
        Me.Panel10.Controls.Add(Me.Label38)
        Me.Panel10.Controls.Add(Me.Label39)
        Me.Panel10.Controls.Add(Me.Label12)
        Me.Panel10.Location = New System.Drawing.Point(472, 128)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(178, 189)
        Me.Panel10.TabIndex = 9
        '
        'CHKSalesPerson
        '
        Me.CHKSalesPerson.BackColor = System.Drawing.SystemColors.Control
        Me.CHKSalesPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CHKSalesPerson.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CHKSalesPerson.Location = New System.Drawing.Point(88, 170)
        Me.CHKSalesPerson.Name = "CHKSalesPerson"
        Me.CHKSalesPerson.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKSalesPerson.Size = New System.Drawing.Size(82, 16)
        Me.CHKSalesPerson.TabIndex = 417
        Me.CHKSalesPerson.Text = "Sales Man"
        '
        'Dteterminate_date
        '
        Me.Dteterminate_date.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dteterminate_date.BorderColor = System.Drawing.Color.Empty
        Me.Dteterminate_date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dteterminate_date.ButtonBackColor = System.Drawing.Color.Empty
        Me.Dteterminate_date.ButtonForeColor = System.Drawing.Color.Empty
        Me.Dteterminate_date.EditableSal = True
        Me.Dteterminate_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Dteterminate_date.Image = CType(resources.GetObject("Dteterminate_date.Image"), System.Drawing.Image)
        Me.Dteterminate_date.Location = New System.Drawing.Point(71, 123)
        Me.Dteterminate_date.MaxValue = CType(2500, Short)
        Me.Dteterminate_date.MinValue = CType(1800, Short)
        Me.Dteterminate_date.Name = "Dteterminate_date"
        Me.Dteterminate_date.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dteterminate_date.Sal_Mali = Nothing
        Me.Dteterminate_date.ShowButton = True
        Me.Dteterminate_date.Size = New System.Drawing.Size(104, 23)
        Me.Dteterminate_date.TabIndex = 6
        Me.Dteterminate_date.VisualStyle = False
        '
        'DteLast_Raise
        '
        Me.DteLast_Raise.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DteLast_Raise.BorderColor = System.Drawing.Color.Empty
        Me.DteLast_Raise.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteLast_Raise.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteLast_Raise.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteLast_Raise.EditableSal = True
        Me.DteLast_Raise.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DteLast_Raise.Image = CType(resources.GetObject("DteLast_Raise.Image"), System.Drawing.Image)
        Me.DteLast_Raise.Location = New System.Drawing.Point(71, 102)
        Me.DteLast_Raise.MaxValue = CType(2500, Short)
        Me.DteLast_Raise.MinValue = CType(1800, Short)
        Me.DteLast_Raise.Name = "DteLast_Raise"
        Me.DteLast_Raise.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteLast_Raise.Sal_Mali = Nothing
        Me.DteLast_Raise.ShowButton = True
        Me.DteLast_Raise.Size = New System.Drawing.Size(104, 23)
        Me.DteLast_Raise.TabIndex = 5
        Me.DteLast_Raise.VisualStyle = False
        '
        'Dtelast_reiew_date
        '
        Me.Dtelast_reiew_date.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dtelast_reiew_date.BorderColor = System.Drawing.Color.Empty
        Me.Dtelast_reiew_date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dtelast_reiew_date.ButtonBackColor = System.Drawing.Color.Empty
        Me.Dtelast_reiew_date.ButtonForeColor = System.Drawing.Color.Empty
        Me.Dtelast_reiew_date.EditableSal = True
        Me.Dtelast_reiew_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Dtelast_reiew_date.Image = CType(resources.GetObject("Dtelast_reiew_date.Image"), System.Drawing.Image)
        Me.Dtelast_reiew_date.Location = New System.Drawing.Point(71, 81)
        Me.Dtelast_reiew_date.MaxValue = CType(2500, Short)
        Me.Dtelast_reiew_date.MinValue = CType(1800, Short)
        Me.Dtelast_reiew_date.Name = "Dtelast_reiew_date"
        Me.Dtelast_reiew_date.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dtelast_reiew_date.Sal_Mali = Nothing
        Me.Dtelast_reiew_date.ShowButton = True
        Me.Dtelast_reiew_date.Size = New System.Drawing.Size(104, 23)
        Me.Dtelast_reiew_date.TabIndex = 4
        Me.Dtelast_reiew_date.VisualStyle = False
        '
        'Dtehired_date
        '
        Me.Dtehired_date.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dtehired_date.BorderColor = System.Drawing.Color.Empty
        Me.Dtehired_date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dtehired_date.ButtonBackColor = System.Drawing.Color.Empty
        Me.Dtehired_date.ButtonForeColor = System.Drawing.Color.Empty
        Me.Dtehired_date.EditableSal = True
        Me.Dtehired_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Dtehired_date.Image = CType(resources.GetObject("Dtehired_date.Image"), System.Drawing.Image)
        Me.Dtehired_date.Location = New System.Drawing.Point(71, 59)
        Me.Dtehired_date.MaxValue = CType(2500, Short)
        Me.Dtehired_date.MinValue = CType(1800, Short)
        Me.Dtehired_date.Name = "Dtehired_date"
        Me.Dtehired_date.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dtehired_date.Sal_Mali = Nothing
        Me.Dtehired_date.ShowButton = True
        Me.Dtehired_date.Size = New System.Drawing.Size(104, 23)
        Me.Dtehired_date.TabIndex = 3
        Me.Dtehired_date.VisualStyle = False
        '
        'Dtebirthday_date
        '
        Me.Dtebirthday_date.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dtebirthday_date.BorderColor = System.Drawing.Color.Empty
        Me.Dtebirthday_date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dtebirthday_date.ButtonBackColor = System.Drawing.Color.Empty
        Me.Dtebirthday_date.ButtonForeColor = System.Drawing.Color.Empty
        Me.Dtebirthday_date.EditableSal = True
        Me.Dtebirthday_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Dtebirthday_date.Image = CType(resources.GetObject("Dtebirthday_date.Image"), System.Drawing.Image)
        Me.Dtebirthday_date.Location = New System.Drawing.Point(71, 38)
        Me.Dtebirthday_date.MaxValue = CType(2500, Short)
        Me.Dtebirthday_date.MinValue = CType(1800, Short)
        Me.Dtebirthday_date.Name = "Dtebirthday_date"
        Me.Dtebirthday_date.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dtebirthday_date.Sal_Mali = Nothing
        Me.Dtebirthday_date.ShowButton = True
        Me.Dtebirthday_date.Size = New System.Drawing.Size(104, 23)
        Me.Dtebirthday_date.TabIndex = 2
        Me.Dtebirthday_date.VisualStyle = False
        '
        'PictureButton1
        '
        Me.PictureButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PictureButton1.Location = New System.Drawing.Point(94, 2)
        Me.PictureButton1.MyPicture = Nothing
        Me.PictureButton1.Name = "PictureButton1"
        Me.PictureButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PictureButton1.Size = New System.Drawing.Size(79, 21)
        Me.PictureButton1.TabIndex = 163
        '
        'BtnNotes
        '
        Me.BtnNotes.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnNotes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnNotes.Location = New System.Drawing.Point(5, 2)
        Me.BtnNotes.Name = "BtnNotes"
        Me.BtnNotes.Size = New System.Drawing.Size(80, 21)
        Me.BtnNotes.TabIndex = 0
        Me.BtnNotes.TabStop = False
        Me.BtnNotes.Text = "Notes"
        '
        'ChkTerminated
        '
        Me.ChkTerminated.BackColor = System.Drawing.SystemColors.Control
        Me.ChkTerminated.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkTerminated.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkTerminated.Location = New System.Drawing.Point(55, 127)
        Me.ChkTerminated.Name = "ChkTerminated"
        Me.ChkTerminated.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkTerminated.Size = New System.Drawing.Size(15, 16)
        Me.ChkTerminated.TabIndex = 7
        '
        'ChkTechnecian
        '
        Me.ChkTechnecian.BackColor = System.Drawing.SystemColors.Control
        Me.ChkTechnecian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkTechnecian.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkTechnecian.Location = New System.Drawing.Point(3, 170)
        Me.ChkTechnecian.Name = "ChkTechnecian"
        Me.ChkTechnecian.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkTechnecian.Size = New System.Drawing.Size(82, 16)
        Me.ChkTechnecian.TabIndex = 9
        Me.ChkTechnecian.Text = "Technician"
        '
        'Chktemporary_inactive
        '
        Me.Chktemporary_inactive.BackColor = System.Drawing.SystemColors.Control
        Me.Chktemporary_inactive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Chktemporary_inactive.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Chktemporary_inactive.Location = New System.Drawing.Point(14, 149)
        Me.Chktemporary_inactive.Name = "Chktemporary_inactive"
        Me.Chktemporary_inactive.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Chktemporary_inactive.Size = New System.Drawing.Size(123, 16)
        Me.Chktemporary_inactive.TabIndex = 8
        Me.Chktemporary_inactive.Text = "Temporary Inactive"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(79, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 21)
        Me.Label13.TabIndex = 157
        Me.Label13.Text = "Date"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.SystemColors.Control
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label36.Location = New System.Drawing.Point(-7, 123)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(62, 21)
        Me.Label36.TabIndex = 162
        Me.Label36.Text = "Terminated"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.SystemColors.Control
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label37.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label37.Location = New System.Drawing.Point(7, 102)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(64, 20)
        Me.Label37.TabIndex = 161
        Me.Label37.Text = "Last Raise"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.SystemColors.Control
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label38.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label38.Location = New System.Drawing.Point(2, 81)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(67, 20)
        Me.Label38.TabIndex = 160
        Me.Label38.Text = "Last Review"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.SystemColors.Control
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label39.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label39.Location = New System.Drawing.Point(6, 59)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(64, 21)
        Me.Label39.TabIndex = 159
        Me.Label39.Text = "Hired"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(4, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 19)
        Me.Label12.TabIndex = 158
        Me.Label12.Text = "Birthday"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.BtnHistory)
        Me.Panel8.Controls.Add(Me.LblNetPay)
        Me.Panel8.Controls.Add(Me.Label65)
        Me.Panel8.Controls.Add(Me.LblDeductions)
        Me.Panel8.Controls.Add(Me.Label10)
        Me.Panel8.Controls.Add(Me.LblStateW_H)
        Me.Panel8.Controls.Add(Me.Label20)
        Me.Panel8.Controls.Add(Me.LblFederalW_H)
        Me.Panel8.Controls.Add(Me.Label24)
        Me.Panel8.Controls.Add(Me.Label26)
        Me.Panel8.Controls.Add(Me.LblMedicare)
        Me.Panel8.Controls.Add(Me.Label27)
        Me.Panel8.Controls.Add(Me.LblGrossPay)
        Me.Panel8.Controls.Add(Me.Label28)
        Me.Panel8.Controls.Add(Me.LblFICA)
        Me.Panel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel8.Location = New System.Drawing.Point(322, 128)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(152, 189)
        Me.Panel8.TabIndex = 8
        '
        'BtnHistory
        '
        Me.BtnHistory.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnHistory.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnHistory.Location = New System.Drawing.Point(6, 2)
        Me.BtnHistory.Name = "BtnHistory"
        Me.BtnHistory.Size = New System.Drawing.Size(80, 21)
        Me.BtnHistory.TabIndex = 7
        Me.BtnHistory.TabStop = False
        Me.BtnHistory.Text = "History"
        '
        'LblNetPay
        '
        Me.LblNetPay.BackColor = System.Drawing.Color.Gold
        Me.LblNetPay.Enabled = False
        Me.LblNetPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblNetPay.Location = New System.Drawing.Point(71, 162)
        Me.LblNetPay.Name = "LblNetPay"
        Me.LblNetPay.ReadOnly = True
        Me.LblNetPay.Size = New System.Drawing.Size(77, 20)
        Me.LblNetPay.TabIndex = 6
        Me.LblNetPay.TabStop = False
        Me.LblNetPay.Text = ""
        '
        'Label65
        '
        Me.Label65.BackColor = System.Drawing.SystemColors.Control
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label65.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label65.Location = New System.Drawing.Point(1, 162)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(67, 19)
        Me.Label65.TabIndex = 137
        Me.Label65.Text = "Net Pay"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDeductions
        '
        Me.LblDeductions.BackColor = System.Drawing.Color.Gold
        Me.LblDeductions.Enabled = False
        Me.LblDeductions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblDeductions.Location = New System.Drawing.Point(71, 140)
        Me.LblDeductions.Name = "LblDeductions"
        Me.LblDeductions.ReadOnly = True
        Me.LblDeductions.Size = New System.Drawing.Size(77, 20)
        Me.LblDeductions.TabIndex = 5
        Me.LblDeductions.TabStop = False
        Me.LblDeductions.Text = ""
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(1, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 21)
        Me.Label10.TabIndex = 133
        Me.Label10.Text = "Deductions"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblStateW_H
        '
        Me.LblStateW_H.BackColor = System.Drawing.Color.Gold
        Me.LblStateW_H.Enabled = False
        Me.LblStateW_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblStateW_H.Location = New System.Drawing.Point(71, 118)
        Me.LblStateW_H.Name = "LblStateW_H"
        Me.LblStateW_H.ReadOnly = True
        Me.LblStateW_H.Size = New System.Drawing.Size(77, 20)
        Me.LblStateW_H.TabIndex = 4
        Me.LblStateW_H.TabStop = False
        Me.LblStateW_H.Text = ""
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(0, 117)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 20)
        Me.Label20.TabIndex = 132
        Me.Label20.Text = "State W/H"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblFederalW_H
        '
        Me.LblFederalW_H.BackColor = System.Drawing.Color.Gold
        Me.LblFederalW_H.Enabled = False
        Me.LblFederalW_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblFederalW_H.Location = New System.Drawing.Point(71, 97)
        Me.LblFederalW_H.Name = "LblFederalW_H"
        Me.LblFederalW_H.ReadOnly = True
        Me.LblFederalW_H.Size = New System.Drawing.Size(77, 20)
        Me.LblFederalW_H.TabIndex = 3
        Me.LblFederalW_H.TabStop = False
        Me.LblFederalW_H.Text = ""
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(-2, 96)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(69, 19)
        Me.Label24.TabIndex = 131
        Me.Label24.Text = "Federal W/H"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.Control
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(0, 73)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(67, 21)
        Me.Label26.TabIndex = 130
        Me.Label26.Text = "Medicare"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblMedicare
        '
        Me.LblMedicare.BackColor = System.Drawing.Color.Gold
        Me.LblMedicare.Enabled = False
        Me.LblMedicare.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblMedicare.Location = New System.Drawing.Point(71, 74)
        Me.LblMedicare.Name = "LblMedicare"
        Me.LblMedicare.ReadOnly = True
        Me.LblMedicare.Size = New System.Drawing.Size(77, 20)
        Me.LblMedicare.TabIndex = 2
        Me.LblMedicare.TabStop = False
        Me.LblMedicare.Text = ""
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.Control
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(0, 52)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(67, 19)
        Me.Label27.TabIndex = 129
        Me.Label27.Text = "FICA"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblGrossPay
        '
        Me.LblGrossPay.BackColor = System.Drawing.Color.Gold
        Me.LblGrossPay.Enabled = False
        Me.LblGrossPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblGrossPay.Location = New System.Drawing.Point(71, 31)
        Me.LblGrossPay.Name = "LblGrossPay"
        Me.LblGrossPay.ReadOnly = True
        Me.LblGrossPay.Size = New System.Drawing.Size(77, 20)
        Me.LblGrossPay.TabIndex = 0
        Me.LblGrossPay.TabStop = False
        Me.LblGrossPay.Text = ""
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.Control
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(1, 30)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(67, 20)
        Me.Label28.TabIndex = 128
        Me.Label28.Text = "Gross Pay"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblFICA
        '
        Me.LblFICA.BackColor = System.Drawing.Color.Gold
        Me.LblFICA.Enabled = False
        Me.LblFICA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblFICA.Location = New System.Drawing.Point(71, 53)
        Me.LblFICA.Name = "LblFICA"
        Me.LblFICA.ReadOnly = True
        Me.LblFICA.Size = New System.Drawing.Size(77, 20)
        Me.LblFICA.TabIndex = 1
        Me.LblFICA.TabStop = False
        Me.LblFICA.Text = ""
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.BtnDeduction)
        Me.Panel7.Controls.Add(Me.BtnGarnishment)
        Me.Panel7.Controls.Add(Me.BtnSaving)
        Me.Panel7.Controls.Add(Me.BtnLoan)
        Me.Panel7.Location = New System.Drawing.Point(0, 224)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(323, 93)
        Me.Panel7.TabIndex = 7
        '
        'BtnDeduction
        '
        Me.BtnDeduction.Location = New System.Drawing.Point(186, 54)
        Me.BtnDeduction.Name = "BtnDeduction"
        Me.BtnDeduction.Size = New System.Drawing.Size(107, 23)
        Me.BtnDeduction.TabIndex = 3
        Me.BtnDeduction.TabStop = False
        Me.BtnDeduction.Text = "Deduction"
        '
        'BtnGarnishment
        '
        Me.BtnGarnishment.Location = New System.Drawing.Point(26, 54)
        Me.BtnGarnishment.Name = "BtnGarnishment"
        Me.BtnGarnishment.Size = New System.Drawing.Size(107, 23)
        Me.BtnGarnishment.TabIndex = 2
        Me.BtnGarnishment.TabStop = False
        Me.BtnGarnishment.Text = "Garnishment"
        '
        'BtnSaving
        '
        Me.BtnSaving.Location = New System.Drawing.Point(186, 15)
        Me.BtnSaving.Name = "BtnSaving"
        Me.BtnSaving.Size = New System.Drawing.Size(107, 23)
        Me.BtnSaving.TabIndex = 1
        Me.BtnSaving.TabStop = False
        Me.BtnSaving.Text = "Saving"
        '
        'BtnLoan
        '
        Me.BtnLoan.Location = New System.Drawing.Point(26, 15)
        Me.BtnLoan.Name = "BtnLoan"
        Me.BtnLoan.Size = New System.Drawing.Size(107, 23)
        Me.BtnLoan.TabIndex = 0
        Me.BtnLoan.TabStop = False
        Me.BtnLoan.Text = "Loan"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.RDOlast_period4)
        Me.Panel6.Controls.Add(Me.RDOlast_period3)
        Me.Panel6.Controls.Add(Me.RDOlast_period2)
        Me.Panel6.Controls.Add(Me.RDOlast_period1)
        Me.Panel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel6.Location = New System.Drawing.Point(215, 128)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(108, 97)
        Me.Panel6.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(6, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 20)
        Me.Label9.TabIndex = 114
        Me.Label9.Text = "Period"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RDOlast_period4
        '
        Me.RDOlast_period4.BackColor = System.Drawing.SystemColors.Control
        Me.RDOlast_period4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.RDOlast_period4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RDOlast_period4.Location = New System.Drawing.Point(13, 75)
        Me.RDOlast_period4.Name = "RDOlast_period4"
        Me.RDOlast_period4.Size = New System.Drawing.Size(88, 16)
        Me.RDOlast_period4.TabIndex = 3
        Me.RDOlast_period4.Text = "Monthly"
        '
        'RDOlast_period3
        '
        Me.RDOlast_period3.BackColor = System.Drawing.SystemColors.Control
        Me.RDOlast_period3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.RDOlast_period3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RDOlast_period3.Location = New System.Drawing.Point(13, 59)
        Me.RDOlast_period3.Name = "RDOlast_period3"
        Me.RDOlast_period3.Size = New System.Drawing.Size(88, 16)
        Me.RDOlast_period3.TabIndex = 2
        Me.RDOlast_period3.Text = "Semimonthly"
        '
        'RDOlast_period2
        '
        Me.RDOlast_period2.BackColor = System.Drawing.SystemColors.Control
        Me.RDOlast_period2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.RDOlast_period2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RDOlast_period2.Location = New System.Drawing.Point(13, 43)
        Me.RDOlast_period2.Name = "RDOlast_period2"
        Me.RDOlast_period2.Size = New System.Drawing.Size(88, 16)
        Me.RDOlast_period2.TabIndex = 1
        Me.RDOlast_period2.Text = "BiWeekly"
        '
        'RDOlast_period1
        '
        Me.RDOlast_period1.BackColor = System.Drawing.SystemColors.Control
        Me.RDOlast_period1.Checked = True
        Me.RDOlast_period1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.RDOlast_period1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RDOlast_period1.Location = New System.Drawing.Point(13, 27)
        Me.RDOlast_period1.Name = "RDOlast_period1"
        Me.RDOlast_period1.Size = New System.Drawing.Size(88, 16)
        Me.RDOlast_period1.TabIndex = 0
        Me.RDOlast_period1.Text = "Weekly"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.RDOlast_status3)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.RDOlast_status4)
        Me.Panel5.Controls.Add(Me.RDOlast_status2)
        Me.Panel5.Controls.Add(Me.RDOlast_status1)
        Me.Panel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel5.Location = New System.Drawing.Point(1, 128)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(108, 97)
        Me.Panel5.TabIndex = 4
        '
        'RDOlast_status3
        '
        Me.RDOlast_status3.BackColor = System.Drawing.SystemColors.Control
        Me.RDOlast_status3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.RDOlast_status3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RDOlast_status3.Location = New System.Drawing.Point(10, 59)
        Me.RDOlast_status3.Name = "RDOlast_status3"
        Me.RDOlast_status3.Size = New System.Drawing.Size(95, 16)
        Me.RDOlast_status3.TabIndex = 2
        Me.RDOlast_status3.Text = "Married Separ."
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(8, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Status"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RDOlast_status4
        '
        Me.RDOlast_status4.BackColor = System.Drawing.SystemColors.Control
        Me.RDOlast_status4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.RDOlast_status4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RDOlast_status4.Location = New System.Drawing.Point(10, 75)
        Me.RDOlast_status4.Name = "RDOlast_status4"
        Me.RDOlast_status4.Size = New System.Drawing.Size(88, 16)
        Me.RDOlast_status4.TabIndex = 3
        Me.RDOlast_status4.Text = "HouseHold"
        '
        'RDOlast_status2
        '
        Me.RDOlast_status2.BackColor = System.Drawing.SystemColors.Control
        Me.RDOlast_status2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.RDOlast_status2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RDOlast_status2.Location = New System.Drawing.Point(10, 43)
        Me.RDOlast_status2.Name = "RDOlast_status2"
        Me.RDOlast_status2.Size = New System.Drawing.Size(88, 16)
        Me.RDOlast_status2.TabIndex = 1
        Me.RDOlast_status2.Text = "Married Joint"
        '
        'RDOlast_status1
        '
        Me.RDOlast_status1.BackColor = System.Drawing.SystemColors.Control
        Me.RDOlast_status1.Checked = True
        Me.RDOlast_status1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.RDOlast_status1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RDOlast_status1.Location = New System.Drawing.Point(10, 27)
        Me.RDOlast_status1.Name = "RDOlast_status1"
        Me.RDOlast_status1.Size = New System.Drawing.Size(88, 16)
        Me.RDOlast_status1.TabIndex = 0
        Me.RDOlast_status1.Text = "Single"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.RDOlast_basis4)
        Me.Panel4.Controls.Add(Me.RDOlast_basis3)
        Me.Panel4.Controls.Add(Me.RDOlast_basis2)
        Me.Panel4.Controls.Add(Me.RDOlast_basis1)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel4.Location = New System.Drawing.Point(108, 128)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(108, 97)
        Me.Panel4.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(7, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 20)
        Me.Label8.TabIndex = 112
        Me.Label8.Text = "Basis"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RDOlast_basis4
        '
        Me.RDOlast_basis4.BackColor = System.Drawing.SystemColors.Control
        Me.RDOlast_basis4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDOlast_basis4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RDOlast_basis4.Location = New System.Drawing.Point(12, 75)
        Me.RDOlast_basis4.Name = "RDOlast_basis4"
        Me.RDOlast_basis4.Size = New System.Drawing.Size(88, 16)
        Me.RDOlast_basis4.TabIndex = 3
        Me.RDOlast_basis4.Text = "Piece Work"
        '
        'RDOlast_basis3
        '
        Me.RDOlast_basis3.BackColor = System.Drawing.SystemColors.Control
        Me.RDOlast_basis3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDOlast_basis3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RDOlast_basis3.Location = New System.Drawing.Point(12, 59)
        Me.RDOlast_basis3.Name = "RDOlast_basis3"
        Me.RDOlast_basis3.Size = New System.Drawing.Size(88, 16)
        Me.RDOlast_basis3.TabIndex = 2
        Me.RDOlast_basis3.Text = "Commission"
        '
        'RDOlast_basis2
        '
        Me.RDOlast_basis2.BackColor = System.Drawing.SystemColors.Control
        Me.RDOlast_basis2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDOlast_basis2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RDOlast_basis2.Location = New System.Drawing.Point(12, 43)
        Me.RDOlast_basis2.Name = "RDOlast_basis2"
        Me.RDOlast_basis2.Size = New System.Drawing.Size(88, 16)
        Me.RDOlast_basis2.TabIndex = 1
        Me.RDOlast_basis2.Text = "Salary"
        '
        'RDOlast_basis1
        '
        Me.RDOlast_basis1.BackColor = System.Drawing.SystemColors.Control
        Me.RDOlast_basis1.Checked = True
        Me.RDOlast_basis1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDOlast_basis1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RDOlast_basis1.Location = New System.Drawing.Point(12, 27)
        Me.RDOlast_basis1.Name = "RDOlast_basis1"
        Me.RDOlast_basis1.Size = New System.Drawing.Size(88, 16)
        Me.RDOlast_basis1.TabIndex = 0
        Me.RDOlast_basis1.Text = "Hours"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Txtlast_hourly)
        Me.Panel3.Controls.Add(Me.Txtlast_overtime)
        Me.Panel3.Controls.Add(Me.Txtlast_salary)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel3.Location = New System.Drawing.Point(521, 29)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(129, 100)
        Me.Panel3.TabIndex = 3
        '
        'Txtlast_hourly
        '
        Me.Txtlast_hourly.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Txtlast_hourly.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Txtlast_hourly.DecimalDigits = 2
        Me.Txtlast_hourly.DefaultSendValue = False
        Me.Txtlast_hourly.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Txtlast_hourly.FireTabAfterEnter = True
        Me.Txtlast_hourly.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtlast_hourly.Image = CType(resources.GetObject("Txtlast_hourly.Image"), System.Drawing.Image)
        Me.Txtlast_hourly.Location = New System.Drawing.Point(51, 49)
        Me.Txtlast_hourly.Maxlength = 10
        Me.Txtlast_hourly.MinusColor = System.Drawing.Color.Empty
        Me.Txtlast_hourly.Name = "Txtlast_hourly"
        Me.Txtlast_hourly.Size = New System.Drawing.Size(75, 22)
        Me.Txtlast_hourly.TabIndex = 0
        Me.Txtlast_hourly.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Txtlast_hourly.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Txtlast_overtime
        '
        Me.Txtlast_overtime.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Txtlast_overtime.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Txtlast_overtime.DecimalDigits = 2
        Me.Txtlast_overtime.DefaultSendValue = False
        Me.Txtlast_overtime.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Txtlast_overtime.FireTabAfterEnter = True
        Me.Txtlast_overtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtlast_overtime.Image = CType(resources.GetObject("Txtlast_overtime.Image"), System.Drawing.Image)
        Me.Txtlast_overtime.Location = New System.Drawing.Point(51, 74)
        Me.Txtlast_overtime.Maxlength = 10
        Me.Txtlast_overtime.MinusColor = System.Drawing.Color.Empty
        Me.Txtlast_overtime.Name = "Txtlast_overtime"
        Me.Txtlast_overtime.Size = New System.Drawing.Size(75, 22)
        Me.Txtlast_overtime.TabIndex = 2
        Me.Txtlast_overtime.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Txtlast_overtime.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Txtlast_salary
        '
        Me.Txtlast_salary.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Txtlast_salary.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Txtlast_salary.DecimalDigits = 2
        Me.Txtlast_salary.DefaultSendValue = False
        Me.Txtlast_salary.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Txtlast_salary.FireTabAfterEnter = True
        Me.Txtlast_salary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtlast_salary.Image = CType(resources.GetObject("Txtlast_salary.Image"), System.Drawing.Image)
        Me.Txtlast_salary.Location = New System.Drawing.Point(51, 24)
        Me.Txtlast_salary.Maxlength = 10
        Me.Txtlast_salary.MinusColor = System.Drawing.Color.Empty
        Me.Txtlast_salary.Name = "Txtlast_salary"
        Me.Txtlast_salary.Size = New System.Drawing.Size(75, 22)
        Me.Txtlast_salary.TabIndex = 0
        Me.Txtlast_salary.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Txtlast_salary.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(-2, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 21)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Overtime"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(-2, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "Hourly"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(-3, 25)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 20)
        Me.Label19.TabIndex = 98
        Me.Label19.Text = "Salary"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(32, 4)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 19)
        Me.Label23.TabIndex = 97
        Me.Label23.Text = "Pay Rate"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.NumAllowancesDepndnts)
        Me.Panel2.Controls.Add(Me.NumAllowancesState)
        Me.Panel2.Controls.Add(Me.NumAllowancesFederal)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.Label48)
        Me.Panel2.Controls.Add(Me.Label49)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel2.Location = New System.Drawing.Point(429, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(93, 100)
        Me.Panel2.TabIndex = 2
        '
        'NumAllowancesDepndnts
        '
        Me.NumAllowancesDepndnts.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumAllowancesDepndnts.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumAllowancesDepndnts.DecimalDigits = 0
        Me.NumAllowancesDepndnts.DefaultSendValue = False
        Me.NumAllowancesDepndnts.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumAllowancesDepndnts.FireTabAfterEnter = True
        Me.NumAllowancesDepndnts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumAllowancesDepndnts.Image = CType(resources.GetObject("NumAllowancesDepndnts.Image"), System.Drawing.Image)
        Me.NumAllowancesDepndnts.Location = New System.Drawing.Point(52, 75)
        Me.NumAllowancesDepndnts.Maxlength = 10
        Me.NumAllowancesDepndnts.MinusColor = System.Drawing.Color.Empty
        Me.NumAllowancesDepndnts.Name = "NumAllowancesDepndnts"
        Me.NumAllowancesDepndnts.Size = New System.Drawing.Size(38, 21)
        Me.NumAllowancesDepndnts.TabIndex = 96
        Me.NumAllowancesDepndnts.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumAllowancesDepndnts.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumAllowancesState
        '
        Me.NumAllowancesState.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumAllowancesState.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumAllowancesState.DecimalDigits = 0
        Me.NumAllowancesState.DefaultSendValue = False
        Me.NumAllowancesState.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumAllowancesState.FireTabAfterEnter = True
        Me.NumAllowancesState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumAllowancesState.Image = CType(resources.GetObject("NumAllowancesState.Image"), System.Drawing.Image)
        Me.NumAllowancesState.Location = New System.Drawing.Point(52, 50)
        Me.NumAllowancesState.Maxlength = 10
        Me.NumAllowancesState.MinusColor = System.Drawing.Color.Empty
        Me.NumAllowancesState.Name = "NumAllowancesState"
        Me.NumAllowancesState.Size = New System.Drawing.Size(38, 21)
        Me.NumAllowancesState.TabIndex = 95
        Me.NumAllowancesState.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumAllowancesState.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumAllowancesFederal
        '
        Me.NumAllowancesFederal.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumAllowancesFederal.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumAllowancesFederal.DecimalDigits = 0
        Me.NumAllowancesFederal.DefaultSendValue = False
        Me.NumAllowancesFederal.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumAllowancesFederal.FireTabAfterEnter = True
        Me.NumAllowancesFederal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumAllowancesFederal.Image = CType(resources.GetObject("NumAllowancesFederal.Image"), System.Drawing.Image)
        Me.NumAllowancesFederal.Location = New System.Drawing.Point(52, 25)
        Me.NumAllowancesFederal.Maxlength = 10
        Me.NumAllowancesFederal.MinusColor = System.Drawing.Color.Empty
        Me.NumAllowancesFederal.Name = "NumAllowancesFederal"
        Me.NumAllowancesFederal.Size = New System.Drawing.Size(38, 21)
        Me.NumAllowancesFederal.TabIndex = 94
        Me.NumAllowancesFederal.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumAllowancesFederal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(-4, 76)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(57, 16)
        Me.Label25.TabIndex = 93
        Me.Label25.Text = "Depndnts."
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.SystemColors.Control
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label48.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label48.Location = New System.Drawing.Point(-6, 50)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(55, 20)
        Me.Label48.TabIndex = 92
        Me.Label48.Text = "State"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.SystemColors.Control
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label49.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label49.Location = New System.Drawing.Point(-3, 26)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(55, 20)
        Me.Label49.TabIndex = 91
        Me.Label49.Text = "Federal"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(2, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 19)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Allowances"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PhoneButton1)
        Me.Panel1.Controls.Add(Me.Txtsocial_security_no1)
        Me.Panel1.Controls.Add(Me.TxtEmail)
        Me.Panel1.Controls.Add(Me.ZipCode1)
        Me.Panel1.Controls.Add(Me.TxtSt)
        Me.Panel1.Controls.Add(Me.PhoneNoMain)
        Me.Panel1.Controls.Add(Me.TxtCity)
        Me.Panel1.Controls.Add(Me.Label64)
        Me.Panel1.Controls.Add(Me.Cmbcod_deparment)
        Me.Panel1.Controls.Add(Me.Label63)
        Me.Panel1.Controls.Add(Me.Cmbcod_position)
        Me.Panel1.Controls.Add(Me.Label61)
        Me.Panel1.Controls.Add(Me.Label60)
        Me.Panel1.Controls.Add(Me.Label59)
        Me.Panel1.Controls.Add(Me.Txtl_name)
        Me.Panel1.Controls.Add(Me.Label58)
        Me.Panel1.Controls.Add(Me.Txtaddress)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Txtm_name)
        Me.Panel1.Controls.Add(Me.Label56)
        Me.Panel1.Controls.Add(Me.Txtf_name)
        Me.Panel1.Controls.Add(Me.Label57)
        Me.Panel1.Controls.Add(Me.Label62)
        Me.Panel1.Location = New System.Drawing.Point(1, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(429, 100)
        Me.Panel1.TabIndex = 1
        '
        'PhoneButton1
        '
        Me.PhoneButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PhoneButton1.Location = New System.Drawing.Point(397, 26)
        Me.PhoneButton1.Name = "PhoneButton1"
        Me.PhoneButton1.Size = New System.Drawing.Size(23, 23)
        Me.PhoneButton1.TabIndex = 103
        Me.PhoneButton1.ZEnabled = True
        '
        'Txtsocial_security_no1
        '
        Me.Txtsocial_security_no1.BackColor = System.Drawing.SystemColors.Window
        Me.Txtsocial_security_no1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Txtsocial_security_no1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtsocial_security_no1.Location = New System.Drawing.Point(65, 75)
        Me.Txtsocial_security_no1.Name = "Txtsocial_security_no1"
        Me.Txtsocial_security_no1.Size = New System.Drawing.Size(94, 17)
        Me.Txtsocial_security_no1.TabIndex = 5
        '
        'TxtEmail
        '
        Me.TxtEmail.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtEmail.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtEmail.ErrorColor = System.Drawing.Color.Red
        Me.TxtEmail.ErrorMessage = "The Email Address Format is : << abc@microsoft.com  >>"
        Me.TxtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtEmail.Location = New System.Drawing.Point(303, 50)
        Me.TxtEmail.MaxLength = 30
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(122, 20)
        Me.TxtEmail.TabIndex = 9
        Me.TxtEmail.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TxtEmail.ValidationExpression = "^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0" & _
        "-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-" & _
        "9][0-9]|[1-9][0-9]|[0-9])\])$"
        '
        'ZipCode1
        '
        Me.ZipCode1.Connection = Me.Cnn
        Me.ZipCode1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ZipCode1.Location = New System.Drawing.Point(175, 51)
        Me.ZipCode1.Name = "ZipCode1"
        Me.ZipCode1.NotExitIfNotFound = False
        Me.ZipCode1.ReleaseIfNotFoundZipCode = False
        Me.ZipCode1.Size = New System.Drawing.Size(59, 22)
        Me.ZipCode1.TabIndex = 4
        Me.ZipCode1.ZipCode = ""
        Me.ZipCode1.ZipCodeLen = 5
        '
        'TxtSt
        '
        Me.TxtSt.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtSt.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtSt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtSt.Location = New System.Drawing.Point(142, 51)
        Me.TxtSt.MaxLength = 20
        Me.TxtSt.Name = "TxtSt"
        Me.TxtSt.ReadOnly = True
        Me.TxtSt.Size = New System.Drawing.Size(33, 20)
        Me.TxtSt.TabIndex = 7
        Me.TxtSt.TabStop = False
        Me.TxtSt.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'PhoneNoMain
        '
        Me.PhoneNoMain.BackColor = System.Drawing.SystemColors.Window
        Me.PhoneNoMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PhoneNoMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PhoneNoMain.Location = New System.Drawing.Point(303, 26)
        Me.PhoneNoMain.Name = "PhoneNoMain"
        Me.PhoneNoMain.Size = New System.Drawing.Size(94, 21)
        Me.PhoneNoMain.TabIndex = 8
        '
        'TxtCity
        '
        Me.TxtCity.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtCity.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtCity.Location = New System.Drawing.Point(65, 51)
        Me.TxtCity.MaxLength = 50
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.ReadOnly = True
        Me.TxtCity.Size = New System.Drawing.Size(77, 20)
        Me.TxtCity.TabIndex = 6
        Me.TxtCity.TabStop = False
        Me.TxtCity.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'Label64
        '
        Me.Label64.BackColor = System.Drawing.SystemColors.Control
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label64.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label64.Location = New System.Drawing.Point(262, 51)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(40, 20)
        Me.Label64.TabIndex = 102
        Me.Label64.Text = "Email"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cmbcod_deparment
        '
        Me.Cmbcod_deparment.DataSource = Me.DSFrmEmployee1.employee_department
        Me.Cmbcod_deparment.DisplayMember = "desc_department"
        Me.Cmbcod_deparment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbcod_deparment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Cmbcod_deparment.Location = New System.Drawing.Point(326, 75)
        Me.Cmbcod_deparment.Name = "Cmbcod_deparment"
        Me.Cmbcod_deparment.Size = New System.Drawing.Size(100, 21)
        Me.Cmbcod_deparment.TabIndex = 7
        Me.Cmbcod_deparment.ValueMember = "cod_deparment"
        '
        'Label63
        '
        Me.Label63.BackColor = System.Drawing.SystemColors.Control
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label63.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label63.Location = New System.Drawing.Point(294, 75)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(33, 22)
        Me.Label63.TabIndex = 101
        Me.Label63.Tag = ""
        Me.Label63.Text = "Dept."
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cmbcod_position
        '
        Me.Cmbcod_position.DataSource = Me.DSFrmEmployee1.employee_position
        Me.Cmbcod_position.DisplayMember = "desc_position"
        Me.Cmbcod_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbcod_position.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Cmbcod_position.Location = New System.Drawing.Point(208, 75)
        Me.Cmbcod_position.Name = "Cmbcod_position"
        Me.Cmbcod_position.Size = New System.Drawing.Size(86, 21)
        Me.Cmbcod_position.TabIndex = 6
        Me.Cmbcod_position.ValueMember = "cod_position"
        '
        'Label61
        '
        Me.Label61.BackColor = System.Drawing.SystemColors.Control
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label61.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label61.Location = New System.Drawing.Point(0, 73)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(65, 21)
        Me.Label61.TabIndex = 99
        Me.Label61.Text = "Soc.Sec.No"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label60
        '
        Me.Label60.BackColor = System.Drawing.SystemColors.Control
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label60.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label60.Location = New System.Drawing.Point(2, 51)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(63, 20)
        Me.Label60.TabIndex = 98
        Me.Label60.Text = "City, St.ZIP"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label59
        '
        Me.Label59.BackColor = System.Drawing.SystemColors.Control
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label59.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label59.Location = New System.Drawing.Point(259, 27)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(43, 20)
        Me.Label59.TabIndex = 97
        Me.Label59.Text = "Phone"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txtl_name
        '
        Me.Txtl_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtl_name.Location = New System.Drawing.Point(279, 4)
        Me.Txtl_name.MaxLength = 30
        Me.Txtl_name.Name = "Txtl_name"
        Me.Txtl_name.Size = New System.Drawing.Size(140, 20)
        Me.Txtl_name.TabIndex = 2
        Me.Txtl_name.Text = ""
        '
        'Label58
        '
        Me.Label58.BackColor = System.Drawing.SystemColors.Control
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label58.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label58.Location = New System.Drawing.Point(251, 4)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(26, 19)
        Me.Label58.TabIndex = 96
        Me.Label58.Text = "Last"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txtaddress
        '
        Me.Txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtaddress.Location = New System.Drawing.Point(65, 27)
        Me.Txtaddress.MaxLength = 100
        Me.Txtaddress.Name = "Txtaddress"
        Me.Txtaddress.Size = New System.Drawing.Size(196, 20)
        Me.Txtaddress.TabIndex = 3
        Me.Txtaddress.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(2, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Address"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txtm_name
        '
        Me.Txtm_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtm_name.Location = New System.Drawing.Point(189, 4)
        Me.Txtm_name.MaxLength = 15
        Me.Txtm_name.Name = "Txtm_name"
        Me.Txtm_name.Size = New System.Drawing.Size(56, 20)
        Me.Txtm_name.TabIndex = 1
        Me.Txtm_name.Text = ""
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.SystemColors.Control
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label56.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label56.Location = New System.Drawing.Point(162, 4)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(24, 19)
        Me.Label56.TabIndex = 94
        Me.Label56.Text = "M.I."
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txtf_name
        '
        Me.Txtf_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtf_name.Location = New System.Drawing.Point(65, 4)
        Me.Txtf_name.MaxLength = 20
        Me.Txtf_name.Name = "Txtf_name"
        Me.Txtf_name.Size = New System.Drawing.Size(89, 20)
        Me.Txtf_name.TabIndex = 0
        Me.Txtf_name.Text = ""
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.SystemColors.Control
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label57.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label57.Location = New System.Drawing.Point(-1, 4)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(63, 19)
        Me.Label57.TabIndex = 0
        Me.Label57.Text = "First Name"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label62
        '
        Me.Label62.BackColor = System.Drawing.SystemColors.Control
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label62.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label62.Location = New System.Drawing.Point(152, 75)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(56, 22)
        Me.Label62.TabIndex = 100
        Me.Label62.Tag = ""
        Me.Label62.Text = "Position"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(5, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 19)
        Me.Label5.TabIndex = 415
        Me.Label5.Text = "Employee"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtEmployeecode
        '
        Me.TxtEmployeecode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtEmployeecode.Location = New System.Drawing.Point(64, 4)
        Me.TxtEmployeecode.MaxLength = 5
        Me.TxtEmployeecode.Name = "TxtEmployeecode"
        Me.TxtEmployeecode.Size = New System.Drawing.Size(81, 20)
        Me.TxtEmployeecode.TabIndex = 0
        Me.TxtEmployeecode.Text = ""
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.CnnTemp
        '
        'CmdInsert
        '
        Me.CmdInsert.CommandText = "INSERT INTO employee (employee_code, f_name, m_name, l_name, address, zipcode, te" & _
        "chnecian, social_security_no, cod_position, cod_deparment, phone_1, extension_1," & _
        " phone_type_1, phone_main_1, phone_2, extension_2, phone_type_2, phone_main_2, p" & _
        "hone_3, extension_3, phone_type_3, phone_main_3, phone_4, extension_4, phone_typ" & _
        "e_4, phone_main_4, phone_5, extension_5, phone_type_5, phone_main_5, email, note" & _
        "s, pic, birthday_date, hired_date, last_reiew_date, terminate_date, temporary_in" & _
        "active, last_basis, last_period, last_status, last_salary, last_hourly, last_ove" & _
        "rtime, Last_raise_date, Allowance_Federal, Allowance_state, Allowance_depndnts, " & _
        "Terminated, SalesPerson, StoreNo, UsePunchClock) VALUES (@employee_code, @f_name" & _
        ", @m_name, @l_name, @address, @zipcode, @technecian, @social_security_no, @cod_p" & _
        "osition, @cod_deparment, @phone_1, @extension_1, @phone_type_1, @phone_main_1, @" & _
        "phone_2, @extension_2, @phone_type_2, @phone_main_2, @phone_3, @extension_3, @ph" & _
        "one_type_3, @phone_main_3, @phone_4, @extension_4, @phone_type_4, @phone_main_4," & _
        " @phone_5, @extension_5, @phone_type_5, @phone_main_5, @email, @notes, @pic, @bi" & _
        "rthday_date, @hired_date, @last_reiew_date, @terminate_date, @temporary_inactive" & _
        ", @last_basis, @last_period, @last_status, @last_salary, @last_hourly, @last_ove" & _
        "rtime, @Last_raise_date, @Allowance_Federal, @Allowance_state, @Allowance_depndn" & _
        "ts, @Terminated, @SalesPerson, @StoreNo, @UsePunchClock)"
        Me.CmdInsert.Connection = Me.Cnn
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@f_name", System.Data.SqlDbType.VarChar, 20, "f_name"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@m_name", System.Data.SqlDbType.VarChar, 15, "m_name"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@l_name", System.Data.SqlDbType.VarChar, 30, "l_name"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zipcode", System.Data.SqlDbType.VarChar, 5, "zipcode"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@technecian", System.Data.SqlDbType.Bit, 1, "technecian"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@social_security_no", System.Data.SqlDbType.VarChar, 25, "social_security_no"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_position", System.Data.SqlDbType.VarChar, 2, "cod_position"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_deparment", System.Data.SqlDbType.VarChar, 3, "cod_deparment"))
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
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@notes", System.Data.SqlDbType.VarChar, 300, "notes"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pic", System.Data.SqlDbType.VarBinary, 2147483647, "pic"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@birthday_date", System.Data.SqlDbType.VarChar, 10, "birthday_date"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@hired_date", System.Data.SqlDbType.VarChar, 10, "hired_date"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_reiew_date", System.Data.SqlDbType.VarChar, 10, "last_reiew_date"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@terminate_date", System.Data.SqlDbType.VarChar, 10, "terminate_date"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@temporary_inactive", System.Data.SqlDbType.Bit, 1, "temporary_inactive"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_basis", System.Data.SqlDbType.VarChar, 1, "last_basis"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_period", System.Data.SqlDbType.VarChar, 1, "last_period"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_status", System.Data.SqlDbType.VarChar, 1, "last_status"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_salary", System.Data.SqlDbType.Money, 8, "last_salary"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_hourly", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "last_hourly", System.Data.DataRowVersion.Current, Nothing))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_overtime", System.Data.SqlDbType.Decimal, 13, System.Data.ParameterDirection.Input, False, CType(24, Byte), CType(0, Byte), "last_overtime", System.Data.DataRowVersion.Current, Nothing))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Last_raise_date", System.Data.SqlDbType.VarChar, 10, "Last_raise_date"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Allowance_Federal", System.Data.SqlDbType.SmallInt, 2, "Allowance_Federal"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Allowance_state", System.Data.SqlDbType.SmallInt, 2, "Allowance_state"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Allowance_depndnts", System.Data.SqlDbType.SmallInt, 2, "Allowance_depndnts"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Terminated", System.Data.SqlDbType.Bit, 1, "Terminated"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SalesPerson", System.Data.SqlDbType.Bit, 1, "SalesPerson"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreNo", System.Data.SqlDbType.VarChar, 2, "StoreNo"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UsePunchClock", System.Data.SqlDbType.Bit, 1, "UsePunchClock"))
        '
        'CmdUpdate
        '
        Me.CmdUpdate.CommandText = "UPDATE employee SET employee_code = @employee_code, f_name = @f_name, m_name = @m" & _
        "_name, l_name = @l_name, address = @address, zipcode = @zipcode, technecian = @t" & _
        "echnecian, social_security_no = @social_security_no, cod_position = @cod_positio" & _
        "n, cod_deparment = @cod_deparment, phone_1 = @phone_1, extension_1 = @extension_" & _
        "1, phone_type_1 = @phone_type_1, phone_main_1 = @phone_main_1, phone_2 = @phone_" & _
        "2, extension_2 = @extension_2, phone_type_2 = @phone_type_2, phone_main_2 = @pho" & _
        "ne_main_2, phone_3 = @phone_3, extension_3 = @extension_3, phone_type_3 = @phone" & _
        "_type_3, phone_main_3 = @phone_main_3, phone_4 = @phone_4, extension_4 = @extens" & _
        "ion_4, phone_type_4 = @phone_type_4, phone_main_4 = @phone_main_4, phone_5 = @ph" & _
        "one_5, extension_5 = @extension_5, phone_type_5 = @phone_type_5, phone_main_5 = " & _
        "@phone_main_5, email = @email, notes = @notes, pic = @pic, birthday_date = @birt" & _
        "hday_date, hired_date = @hired_date, last_reiew_date = @last_reiew_date, termina" & _
        "te_date = @terminate_date, temporary_inactive = @temporary_inactive, last_basis " & _
        "= @last_basis, last_period = @last_period, last_status = @last_status, last_sala" & _
        "ry = @last_salary, last_hourly = @last_hourly, last_overtime = @last_overtime, L" & _
        "ast_raise_date = @Last_raise_date, Allowance_Federal = @Allowance_Federal, Allow" & _
        "ance_state = @Allowance_state, Allowance_depndnts = @Allowance_depndnts, Termina" & _
        "ted = @Terminated, SalesPerson = @SalesPerson, StoreNo = @StoreNo, UsePunchClock" & _
        " = @UsePunchClock WHERE (employee_code = @employee_code)"
        Me.CmdUpdate.Connection = Me.Cnn
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@f_name", System.Data.SqlDbType.VarChar, 20, "f_name"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@m_name", System.Data.SqlDbType.VarChar, 15, "m_name"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@l_name", System.Data.SqlDbType.VarChar, 30, "l_name"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zipcode", System.Data.SqlDbType.VarChar, 5, "zipcode"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@technecian", System.Data.SqlDbType.Bit, 1, "technecian"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@social_security_no", System.Data.SqlDbType.VarChar, 25, "social_security_no"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_position", System.Data.SqlDbType.VarChar, 2, "cod_position"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_deparment", System.Data.SqlDbType.VarChar, 3, "cod_deparment"))
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
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@notes", System.Data.SqlDbType.VarChar, 300, "notes"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pic", System.Data.SqlDbType.VarBinary, 16, "pic"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@birthday_date", System.Data.SqlDbType.VarChar, 10, "birthday_date"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@hired_date", System.Data.SqlDbType.VarChar, 10, "hired_date"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_reiew_date", System.Data.SqlDbType.VarChar, 10, "last_reiew_date"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@terminate_date", System.Data.SqlDbType.VarChar, 10, "terminate_date"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@temporary_inactive", System.Data.SqlDbType.Bit, 1, "temporary_inactive"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_basis", System.Data.SqlDbType.VarChar, 1, "last_basis"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_period", System.Data.SqlDbType.VarChar, 1, "last_period"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_status", System.Data.SqlDbType.VarChar, 1, "last_status"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_salary", System.Data.SqlDbType.Money, 8, "last_salary"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_hourly", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "last_hourly", System.Data.DataRowVersion.Current, Nothing))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_overtime", System.Data.SqlDbType.Decimal, 13, System.Data.ParameterDirection.Input, False, CType(24, Byte), CType(0, Byte), "last_overtime", System.Data.DataRowVersion.Current, Nothing))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Last_raise_date", System.Data.SqlDbType.VarChar, 10, "Last_raise_date"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Allowance_Federal", System.Data.SqlDbType.SmallInt, 2, "Allowance_Federal"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Allowance_state", System.Data.SqlDbType.SmallInt, 2, "Allowance_state"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Allowance_depndnts", System.Data.SqlDbType.SmallInt, 2, "Allowance_depndnts"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Terminated", System.Data.SqlDbType.Bit, 1, "Terminated"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SalesPerson", System.Data.SqlDbType.Bit, 1, "SalesPerson"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreNo", System.Data.SqlDbType.VarChar, 2, "StoreNo"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UsePunchClock", System.Data.SqlDbType.Bit, 1, "UsePunchClock"))
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
        Me.Panel9.Size = New System.Drawing.Size(652, 45)
        Me.Panel9.TabIndex = 2
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
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
        Me.BtnSortOrder.DropDownContextMenu = Me.UiContextMenu1
        Me.BtnSortOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnSortOrder.Image = CType(resources.GetObject("BtnSortOrder.Image"), System.Drawing.Image)
        Me.BtnSortOrder.ImageSize = New System.Drawing.Size(24, 24)
        Me.BtnSortOrder.Location = New System.Drawing.Point(497, 2)
        Me.BtnSortOrder.Name = "BtnSortOrder"
        Me.BtnSortOrder.Size = New System.Drawing.Size(49, 27)
        Me.BtnSortOrder.TabIndex = 195
        '
        'UiContextMenu1
        '
        Me.UiContextMenu1.CommandManager = Me.UiCommandManager1
        Me.UiContextMenu1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Sort11, Me.Sort21, Me.Sort31})
        Me.UiContextMenu1.Key = "ContextMenu1"
        Me.UiContextMenu1.UseThemes = Janus.Windows.UI.InheritableBoolean.True
        Me.UiContextMenu1.VisualStyle = Janus.Windows.UI.VisualStyle.Standard
        '
        'UiCommandManager1
        '
        Me.UiCommandManager1.BottomRebar = Me.BottomRebar1
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Sort1, Me.Sort2, Me.Sort3})
        Me.UiCommandManager1.ContainerControl = Me
        Me.UiCommandManager1.ContextMenus.AddRange(New Janus.Windows.UI.CommandBars.UIContextMenu() {Me.UiContextMenu1})
        Me.UiCommandManager1.Id = New System.Guid("371e90d2-fd6e-4d36-8312-b5eb5c1fb7a2")
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
        Me.Sort1.Text = "Order By Employee No"
        '
        'Sort2
        '
        Me.Sort2.Key = "Sort2"
        Me.Sort2.Name = "Sort2"
        Me.Sort2.Text = "Order By Employee Name"
        '
        'Sort3
        '
        Me.Sort3.Key = "Sort3"
        Me.Sort3.Name = "Sort3"
        Me.Sort3.Text = "Order By ZipCode"
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
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
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
        Me.BtnFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnFirst.Image = CType(resources.GetObject("BtnFirst.Image"), System.Drawing.Image)
        Me.BtnFirst.Location = New System.Drawing.Point(3, 2)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(33, 27)
        Me.BtnFirst.TabIndex = 191
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
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
        Me.BtnLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnLast.Image = CType(resources.GetObject("BtnLast.Image"), System.Drawing.Image)
        Me.BtnLast.Location = New System.Drawing.Point(132, 2)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(33, 27)
        Me.BtnLast.TabIndex = 188
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
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
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(428, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 27)
        Me.BtnCancel.TabIndex = 7
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
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
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.Location = New System.Drawing.Point(300, 2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(33, 27)
        Me.BtnEdit.TabIndex = 4
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
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
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
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
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
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
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
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
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
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
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
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
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(342, 2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(33, 27)
        Me.BtnDelete.TabIndex = 5
        '
        'BtnNew
        '
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Location = New System.Drawing.Point(260, 2)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(33, 27)
        Me.BtnNew.TabIndex = 3
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(196, 2)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 27)
        Me.BtnFind.TabIndex = 2
        '
        'BtnNext
        '
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
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
        Me.BtnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
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
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(384, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 6
        '
        '_opt_last_status3
        '
        Me._opt_last_status3.BackColor = System.Drawing.SystemColors.Control
        Me._opt_last_status3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._opt_last_status3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._opt_last_status3.Location = New System.Drawing.Point(14, 211)
        Me._opt_last_status3.Name = "_opt_last_status3"
        Me._opt_last_status3.Size = New System.Drawing.Size(88, 17)
        Me._opt_last_status3.TabIndex = 101
        Me._opt_last_status3.Text = "Married Sep."
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT deduction_cod, deduction_desc, defult_deduction_amount, befor_tax, GL_acco" & _
        "unt FROM employee_deduction"
        Me.SqlSelectCommand1.Connection = Me.CnnTemp
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO employee_deduction(deduction_cod, deduction_desc, defult_deduction_am" & _
        "ount, befor_tax, GL_account) VALUES (@deduction_cod, @deduction_desc, @defult_de" & _
        "duction_amount, @befor_tax, @GL_account); SELECT deduction_cod, deduction_desc, " & _
        "defult_deduction_amount, befor_tax, GL_account FROM employee_deduction WHERE (de" & _
        "duction_cod = @deduction_cod)"
        Me.SqlInsertCommand1.Connection = Me.CnnTemp
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_cod", System.Data.SqlDbType.VarChar, 2, "deduction_cod"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_desc", System.Data.SqlDbType.VarChar, 50, "deduction_desc"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@defult_deduction_amount", System.Data.SqlDbType.Real, 4, "defult_deduction_amount"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@befor_tax", System.Data.SqlDbType.Bit, 1, "befor_tax"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE employee_deduction SET deduction_cod = @deduction_cod, deduction_desc = @d" & _
        "eduction_desc, defult_deduction_amount = @defult_deduction_amount, befor_tax = @" & _
        "befor_tax, GL_account = @GL_account WHERE (deduction_cod = @Original_deduction_c" & _
        "od) AND (GL_account = @Original_GL_account OR @Original_GL_account IS NULL AND G" & _
        "L_account IS NULL) AND (befor_tax = @Original_befor_tax OR @Original_befor_tax I" & _
        "S NULL AND befor_tax IS NULL) AND (deduction_desc = @Original_deduction_desc OR " & _
        "@Original_deduction_desc IS NULL AND deduction_desc IS NULL) AND (defult_deducti" & _
        "on_amount = @Original_defult_deduction_amount OR @Original_defult_deduction_amou" & _
        "nt IS NULL AND defult_deduction_amount IS NULL); SELECT deduction_cod, deduction" & _
        "_desc, defult_deduction_amount, befor_tax, GL_account FROM employee_deduction WH" & _
        "ERE (deduction_cod = @deduction_cod)"
        Me.SqlUpdateCommand1.Connection = Me.CnnTemp
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_cod", System.Data.SqlDbType.VarChar, 2, "deduction_cod"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_desc", System.Data.SqlDbType.VarChar, 50, "deduction_desc"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@defult_deduction_amount", System.Data.SqlDbType.Real, 4, "defult_deduction_amount"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@befor_tax", System.Data.SqlDbType.Bit, 1, "befor_tax"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_cod", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_cod", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_befor_tax", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "befor_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_desc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_defult_deduction_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "defult_deduction_amount", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM employee_deduction WHERE (deduction_cod = @Original_deduction_cod) AN" & _
        "D (GL_account = @Original_GL_account OR @Original_GL_account IS NULL AND GL_acco" & _
        "unt IS NULL) AND (befor_tax = @Original_befor_tax OR @Original_befor_tax IS NULL" & _
        " AND befor_tax IS NULL) AND (deduction_desc = @Original_deduction_desc OR @Origi" & _
        "nal_deduction_desc IS NULL AND deduction_desc IS NULL) AND (defult_deduction_amo" & _
        "unt = @Original_defult_deduction_amount OR @Original_defult_deduction_amount IS " & _
        "NULL AND defult_deduction_amount IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.CnnTemp
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_cod", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_cod", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_befor_tax", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "befor_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_desc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_defult_deduction_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "defult_deduction_amount", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAEmployee_deduction
        '
        Me.DAEmployee_deduction.DeleteCommand = Me.SqlDeleteCommand1
        Me.DAEmployee_deduction.InsertCommand = Me.SqlInsertCommand1
        Me.DAEmployee_deduction.SelectCommand = Me.SqlSelectCommand1
        Me.DAEmployee_deduction.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "employee_deduction", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("deduction_cod", "deduction_cod"), New System.Data.Common.DataColumnMapping("deduction_desc", "deduction_desc"), New System.Data.Common.DataColumnMapping("defult_deduction_amount", "defult_deduction_amount"), New System.Data.Common.DataColumnMapping("befor_tax", "befor_tax"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account")})})
        Me.DAEmployee_deduction.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cod_position, desc_position, service_ok FROM employee_position"
        Me.SqlSelectCommand2.Connection = Me.CnnTemp
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO employee_position(cod_position, desc_position, service_ok) VALUES (@c" & _
        "od_position, @desc_position, @service_ok); SELECT cod_position, desc_position, s" & _
        "ervice_ok FROM employee_position WHERE (cod_position = @cod_position)"
        Me.SqlInsertCommand2.Connection = Me.CnnTemp
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_position", System.Data.SqlDbType.VarChar, 2, "cod_position"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_position", System.Data.SqlDbType.VarChar, 50, "desc_position"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@service_ok", System.Data.SqlDbType.Bit, 1, "service_ok"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE employee_position SET cod_position = @cod_position, desc_position = @desc_" & _
        "position, service_ok = @service_ok WHERE (cod_position = @Original_cod_position)" & _
        " AND (desc_position = @Original_desc_position OR @Original_desc_position IS NULL" & _
        " AND desc_position IS NULL) AND (service_ok = @Original_service_ok OR @Original_" & _
        "service_ok IS NULL AND service_ok IS NULL); SELECT cod_position, desc_position, " & _
        "service_ok FROM employee_position WHERE (cod_position = @cod_position)"
        Me.SqlUpdateCommand2.Connection = Me.CnnTemp
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_position", System.Data.SqlDbType.VarChar, 2, "cod_position"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_position", System.Data.SqlDbType.VarChar, 50, "desc_position"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@service_ok", System.Data.SqlDbType.Bit, 1, "service_ok"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_position", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_position", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_position", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_position", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_service_ok", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "service_ok", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM employee_position WHERE (cod_position = @Original_cod_position) AND (" & _
        "desc_position = @Original_desc_position OR @Original_desc_position IS NULL AND d" & _
        "esc_position IS NULL) AND (service_ok = @Original_service_ok OR @Original_servic" & _
        "e_ok IS NULL AND service_ok IS NULL)"
        Me.SqlDeleteCommand2.Connection = Me.CnnTemp
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_position", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_position", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_position", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_position", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_service_ok", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "service_ok", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAEmployee_position
        '
        Me.DAEmployee_position.DeleteCommand = Me.SqlDeleteCommand2
        Me.DAEmployee_position.InsertCommand = Me.SqlInsertCommand2
        Me.DAEmployee_position.SelectCommand = Me.SqlSelectCommand2
        Me.DAEmployee_position.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "employee_position", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_position", "cod_position"), New System.Data.Common.DataColumnMapping("desc_position", "desc_position"), New System.Data.Common.DataColumnMapping("service_ok", "service_ok")})})
        Me.DAEmployee_position.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT cod_deparment, desc_department, GL_expense_account, cod_department_master " & _
        "FROM employee_department"
        Me.SqlSelectCommand3.Connection = Me.CnnTemp
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO employee_department(cod_deparment, desc_department, GL_expense_accoun" & _
        "t, cod_department_master) VALUES (@cod_deparment, @desc_department, @GL_expense_" & _
        "account, @cod_department_master); SELECT cod_deparment, desc_department, GL_expe" & _
        "nse_account, cod_department_master FROM employee_department WHERE (cod_deparment" & _
        " = @cod_deparment)"
        Me.SqlInsertCommand3.Connection = Me.CnnTemp
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_deparment", System.Data.SqlDbType.VarChar, 3, "cod_deparment"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_department", System.Data.SqlDbType.VarChar, 50, "desc_department"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_expense_account", System.Data.SqlDbType.VarChar, 10, "GL_expense_account"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_department_master", System.Data.SqlDbType.VarChar, 3, "cod_department_master"))
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE employee_department SET cod_deparment = @cod_deparment, desc_department = " & _
        "@desc_department, GL_expense_account = @GL_expense_account, cod_department_maste" & _
        "r = @cod_department_master WHERE (cod_deparment = @Original_cod_deparment) AND (" & _
        "GL_expense_account = @Original_GL_expense_account OR @Original_GL_expense_accoun" & _
        "t IS NULL AND GL_expense_account IS NULL) AND (cod_department_master = @Original" & _
        "_cod_department_master OR @Original_cod_department_master IS NULL AND cod_depart" & _
        "ment_master IS NULL) AND (desc_department = @Original_desc_department OR @Origin" & _
        "al_desc_department IS NULL AND desc_department IS NULL); SELECT cod_deparment, d" & _
        "esc_department, GL_expense_account, cod_department_master FROM employee_departme" & _
        "nt WHERE (cod_deparment = @cod_deparment)"
        Me.SqlUpdateCommand3.Connection = Me.CnnTemp
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_deparment", System.Data.SqlDbType.VarChar, 3, "cod_deparment"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_department", System.Data.SqlDbType.VarChar, 50, "desc_department"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_expense_account", System.Data.SqlDbType.VarChar, 10, "GL_expense_account"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_department_master", System.Data.SqlDbType.VarChar, 3, "cod_department_master"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_deparment", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_deparment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_expense_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_expense_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_department_master", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_department_master", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_department", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_department", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM employee_department WHERE (cod_deparment = @Original_cod_deparment) A" & _
        "ND (GL_expense_account = @Original_GL_expense_account OR @Original_GL_expense_ac" & _
        "count IS NULL AND GL_expense_account IS NULL) AND (cod_department_master = @Orig" & _
        "inal_cod_department_master OR @Original_cod_department_master IS NULL AND cod_de" & _
        "partment_master IS NULL) AND (desc_department = @Original_desc_department OR @Or" & _
        "iginal_desc_department IS NULL AND desc_department IS NULL)"
        Me.SqlDeleteCommand3.Connection = Me.CnnTemp
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_deparment", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_deparment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_expense_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_expense_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_department_master", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_department_master", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_department", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_department", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAEmployee_department
        '
        Me.DAEmployee_department.DeleteCommand = Me.SqlDeleteCommand3
        Me.DAEmployee_department.InsertCommand = Me.SqlInsertCommand3
        Me.DAEmployee_department.SelectCommand = Me.SqlSelectCommand3
        Me.DAEmployee_department.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "employee_department", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_deparment", "cod_deparment"), New System.Data.Common.DataColumnMapping("desc_department", "desc_department"), New System.Data.Common.DataColumnMapping("GL_expense_account", "GL_expense_account"), New System.Data.Common.DataColumnMapping("cod_department_master", "cod_department_master")})})
        Me.DAEmployee_department.UpdateCommand = Me.SqlUpdateCommand3
        '
        'CmdGeneralForReader
        '
        Me.CmdGeneralForReader.Connection = Me.Cnn
        '
        'CnnMdbSetup
        '
        Me.CnnMdbSetup.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\TireMate\TireMatesetup.mdb;Persis" & _
        "t Security Info=True;Jet OLEDB:Database Password=5332"
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
        'BtnBeginningPayroll
        '
        Me.BtnBeginningPayroll.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnBeginningPayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnBeginningPayroll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnBeginningPayroll.Location = New System.Drawing.Point(323, 4)
        Me.BtnBeginningPayroll.Name = "BtnBeginningPayroll"
        Me.BtnBeginningPayroll.Size = New System.Drawing.Size(102, 21)
        Me.BtnBeginningPayroll.TabIndex = 420
        Me.BtnBeginningPayroll.TabStop = False
        Me.BtnBeginningPayroll.Text = "Beginning Payroll"
        '
        'FrmEmployee
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(652, 389)
        Me.Controls.Add(Me.PnlKartAmvalField)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel9)
        Me.Name = "FrmEmployee"
        Me.Text = "Employee Information"
        CType(Me.DSFrmEmployee1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlSearch.ResumeLayout(False)
        Me.PnlKartAmvalField.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
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
    Private Sub FrmEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        Me.CnnTemp.ConnectionString = PConnectionString
        Me.CnnForReader.ConnectionString = PConnectionString
        Me.CnnMdbSetup.ConnectionString = PConnectionStringForSetupTables

        Employee_Cod1.Kind_Employee = TypeOfForm
        PnlSearchHeight = PnlSearch.Height

        UiContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.True

        Select Case TypeOfForm
            Case 2
                WhereClauseVarWithWhere = " Where SalesPerson=1 "
                WhereClauseVarWithoutWhere = " AND SalesPerson=1 "
                Me.Text = Me.Text & " - Sales Employees"
            Case 3
                WhereClauseVarWithWhere = " Where technecian=1 "
                WhereClauseVarWithoutWhere = " AND technecian=1 "
                Me.Text = Me.Text & " - Technician Employees"
            Case Else
                WhereClauseVarWithWhere = " "
                WhereClauseVarWithoutWhere = " "
        End Select

        Call FillDataSets()
        TxtEmployeecode.MaxLength = LenEmployeeCod

        If EmployeeCodTempVar.Trim.Length = 0 Then
            Call PFirstRecord(False)
        Else
            Employee_Cod1.EmployeeCod = EmployeeCodTempVar
            'Call FillFields(Employee_Cod1.Text)
        End If
        Call AfterSaveOrCancel()
        Employee_Cod1.Focus()
    End Sub
    Private Sub FillDataSets()
        DSFrmEmployee1.employee_department.Clear()
        DAEmployee_department.Fill(DSFrmEmployee1, "employee_department")
        If DSFrmEmployee1.employee_department.Rows.Count < 1 Then
            MsgFar("Please Fill The Employee Department Table")
            Call DisableAllComponet(Me)
            Exit Sub
        End If
        DSFrmEmployee1.employee_position.Clear()
        DAEmployee_position.Fill(DSFrmEmployee1, "employee_position")
        If DSFrmEmployee1.employee_position.Rows.Count < 1 Then
            MsgFar("Please Fill The Employee Employee Position Table")
            Call DisableAllComponet(Me)
            Exit Sub
        End If

        DSFrmEmployee1.Store_Setup.Clear()
        DASTORE_SETUP.Fill(DSFrmEmployee1, "Store_Setup")
    End Sub
    Sub PAddNew()
        Status = MainModule.WorkStates.AddNew

        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        Call EnableField(True)
        EmployeeCodTempVar = Employee_Cod1.Text
        Employee_Cod1.Text = ""
        Call ClearField()

        TxtEmployeecode.Text = MakeNewEmployeeCod()
        TxtEmployeecode.Focus()

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
        EmployeeCodTempVar = Employee_Cod1.Text
        Txtf_name.Focus()

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
                CmdDelete.Parameters("@Employee_Code").Value = Employee_Cod1.Text
                CmdDelete.ExecuteNonQuery()
                EmployeeCodTempVar = ""
                Call PNextRecord(False)
                If EmployeeCodTempVar.Trim.Length = 0 Then
                    Call PPreviousRecord(False)
                    If EmployeeCodTempVar.Trim.Length = 0 Then
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
            Employee_Cod1.Focus()
        End If
        Status = MainModule.WorkStates._ReadOnly
    End Sub
    Sub PSave(Optional ByVal OnlySave As Boolean = False)
        Dim ChangeOK As Boolean = False
        Select Case Status
            Case MainModule.WorkStates.AddNew
                EmployeeCodTempVar = PInsert()
                ChangeOK = IIf(EmployeeCodTempVar.Trim.Length = 0, False, True)
            Case MainModule.WorkStates.Edit
                Dim thisrow As DataRow, ThisPosition As Integer
                ChangeOK = PUpdate(EmployeeCodTempVar)
        End Select
        If ChangeOK And Not OnlySave Then
            Call AfterSaveOrCancel()
            'If Status = mainmodule.WorkStates.AddNew Then
            '    Call PAddNew()
            'Else
            Status = MainModule.WorkStates._ReadOnly
            'PnlSearch.Visible = True
            Call ShowFilterProcPanel()

            Employee_Cod1.Text = EmployeeCodTempVar
            Employee_Cod1.Focus()
        End If
    End Sub
    Sub PCancel()
        Status = MainModule.WorkStates._ReadOnly
        'PnlSearch.Visible = True
        Call ShowFilterProcPanel()

        Employee_Cod1.EmployeeCod = EmployeeCodTempVar
        'Call FillFields(Employee_Cod1.Text)
        Call AfterSaveOrCancel()
        Employee_Cod1.Focus()
    End Sub
    Sub AfterSaveOrCancel()
        MSave.Enabled = False
        BtnSave.Enabled = False
        MCancel.Enabled = False
        BtnCancel.Enabled = False
        BtnNew.Enabled = True
        MAddNew.Enabled = True
        If TxtEmployeecode.Text.Trim.Length = 0 Then
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
    Private Sub TxtEmployeeCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEmployeecode.TextChanged, Txtaddress.TextChanged, TxtEmail.BackColorChanged, Txtf_name.TextChanged, Txtl_name.TextChanged, Txtlast_hourly.TextChanged, Txtlast_overtime.TextChanged, Txtlast_salary.TextChanged, Txtm_name.TextChanged, Txtsocial_security_no1.BackColorChanged, ZipCode1.TextChanged, Cmbcod_deparment.SelectedIndexChanged, Cmbcod_position.SelectedIndexChanged, ChkTechnecian.CheckedChanged, Chktemporary_inactive.CheckedChanged, ChkTerminated.CheckedChanged, RDOlast_basis1.CheckedChanged, RDOlast_basis2.CheckedChanged, RDOlast_basis3.CheckedChanged, RDOlast_basis4.CheckedChanged, RDOlast_period1.CheckedChanged, RDOlast_period2.CheckedChanged, RDOlast_period3.CheckedChanged, RDOlast_period4.CheckedChanged, RDOlast_status1.CheckedChanged, RDOlast_status2.CheckedChanged, RDOlast_status3.CheckedChanged, RDOlast_status4.CheckedChanged, Dtebirthday_date.TextChanged, Dtehired_date.TextChanged, DteLast_Raise.TextChanged, Dtelast_reiew_date.TextChanged, Dteterminate_date.TextChanged, NumAllowancesState.TextChanged, NumAllowancesFederal.TextChanged, NumAllowancesDepndnts.TextChanged, CHKSalesPerson.CheckedChanged, ChkUsePunchClock.CheckedChanged, CmbStoreNo.SelectedIndexChanged
        Call SaveButtonControl()
        'If RDOlast_basis1.Checked And Not RDOlast_period1.Checked And TxtEmployeecode.Text.Trim.Length > 0 Then
        '    MsgFar("Weekly Employees Should be paid by hours")
        '    BtnSave.Enabled = False
        '    MSave.Enabled = False
        'End If
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
            If CmbStoreNo.Text.Trim.Length > 0 And TxtEmployeecode.Text.Trim.Length > 0 And Txtl_name.Text.Trim.Length > 0 And (TypeOfForm <> 2 Or CHKSalesPerson.Checked) And (TypeOfForm <> 3 Or ChkTechnecian.Checked) Then
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
            Dim TXTSearchEmployeeCodTemp As String
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT Top 1 Employee_Code from Employee " & WhereClauseVarWithWhere & " Order BY " & EmployeeOrderFieldName & " ASC"
            TXTSearchEmployeeCodTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.Connection.Close()
            If IsNothing(TXTSearchEmployeeCodTemp) Then
                TXTSearchEmployeeCodTemp = ""
            End If
            If TXTSearchEmployeeCodTemp = Employee_Cod1.Text Or TXTSearchEmployeeCodTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the First record of this table.")
            Else
                Employee_Cod1.EmployeeCod = TXTSearchEmployeeCodTemp
                'Call FillFields(Employee_Cod1.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PPreviousRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchEmployeeCodTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Select Case EmployeeOrderFieldName.ToUpper.Trim
            Case "Employee_Code".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Employee_Code from Employee where Employee_Code<" & Qt(TxtEmployeecode.Text) & WhereClauseVarWithoutWhere & " Order BY " & EmployeeOrderFieldName & " DESC"
            Case "L_Name".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Employee_Code from Employee where l_name<" & Qt(Txtl_name.Text) & WhereClauseVarWithoutWhere & " Order BY " & EmployeeOrderFieldName & " DESC"
            Case "ZipCode".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Employee_Code from Employee where ZipCode<" & Qt(ZipCode1.Text) & WhereClauseVarWithoutWhere & " Order BY " & EmployeeOrderFieldName & " DESC"
        End Select
        TXTSearchEmployeeCodTemp = CmdGeneral.ExecuteScalar()
        CmdGeneral.Connection.Close()
        If IsNothing(TXTSearchEmployeeCodTemp) Then
            TXTSearchEmployeeCodTemp = ""
        End If
        If TXTSearchEmployeeCodTemp = Employee_Cod1.Text Or TXTSearchEmployeeCodTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the First record of this table.")
        Else
            Employee_Cod1.EmployeeCod = TXTSearchEmployeeCodTemp
            EmployeeCodTempVar = TXTSearchEmployeeCodTemp
            'Call FillFields(Employee_Cod1.Text)
        End If
    End Sub
    Private Sub PNextRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchEmployeeCodTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Select Case EmployeeOrderFieldName.ToUpper.Trim
            Case "Employee_Code".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Employee_Code from Employee where Employee_Code>" & Qt(TxtEmployeecode.Text) & WhereClauseVarWithoutWhere & " Order BY " & EmployeeOrderFieldName & " ASC"
            Case "l_name".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Employee_Code from Employee where l_name>" & Qt(Txtl_name.Text) & WhereClauseVarWithoutWhere & " Order BY " & EmployeeOrderFieldName & " ASC"
            Case "ZipCode".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Employee_Code from Employee where ZipCode>" & Qt(ZipCode1.Text) & WhereClauseVarWithoutWhere & " Order BY " & EmployeeOrderFieldName & " ASC"
        End Select
        TXTSearchEmployeeCodTemp = CmdGeneral.ExecuteScalar()
        CmdGeneral.Connection.Close()
        If IsNothing(TXTSearchEmployeeCodTemp) Then
            TXTSearchEmployeeCodTemp = ""
        End If
        If TXTSearchEmployeeCodTemp = Employee_Cod1.Text Or TXTSearchEmployeeCodTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            Employee_Cod1.EmployeeCod = TXTSearchEmployeeCodTemp
            EmployeeCodTempVar = TXTSearchEmployeeCodTemp
            'Call FillFields(Employee_Cod1.Text)
        End If
    End Sub
    Private Sub PLastRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Try
            Dim TXTSearchEmployeeCodTemp As String
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT Top 1 Employee_Code from Employee " & WhereClauseVarWithWhere & " Order BY " & EmployeeOrderFieldName & " DESC"
            TXTSearchEmployeeCodTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.Connection.Close()
            If IsNothing(TXTSearchEmployeeCodTemp) Then
                TXTSearchEmployeeCodTemp = ""
            End If
            If TXTSearchEmployeeCodTemp = Employee_Cod1.Text Or TXTSearchEmployeeCodTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the Last record of this table.")
            Else
                Employee_Cod1.EmployeeCod = TXTSearchEmployeeCodTemp
                'Call FillFields(Employee_Cod1.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Employee_Cod1_FindEmployeeCod() Handles Employee_Cod1.FindEmployeeCod
        Call FillFields(Employee_Cod1.Text)
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
            Employee_Cod1.Focus()
        Else
            'GRDFWG.Height = GRDFWG.Height + PnlSearchHeight
        End If
    End Sub
    Private Sub FrmEmployee_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Employee_Cod1.Text = ""
    End Sub
    Private Sub PPrintMasterInformation()
        'If Employee_Cod1.text > 0 Then
        '    Dim Orpt As New RptInspectionMasterInformation
        '    DsFrmInspectionMaster1.Clear()
        '    DAInspectionMaster.SelectCommand.Parameters("@Employee_Code").Value = Employee_Cod1.text
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
            TxtEmployeecode.Enabled = instatus
        Else
            TxtEmployeecode.Enabled = False
        End If
        TxtEmail.Enabled = instatus
        Txtf_name.Enabled = instatus
        NumAllowancesFederal.Enabled = instatus
        Txtaddress.Enabled = instatus
        Txtl_name.Enabled = instatus
        Txtlast_hourly.Enabled = instatus
        Txtlast_overtime.Enabled = instatus
        Txtlast_salary.Enabled = instatus
        NumAllowancesDepndnts.Enabled = instatus
        Txtm_name.Enabled = instatus
        TxtCity.Enabled = instatus
        TxtSt.Enabled = instatus
        Txtsocial_security_no1.Enabled = instatus
        NumAllowancesState.Enabled = instatus
        Chktemporary_inactive.Enabled = instatus
        ChkTerminated.Enabled = instatus
        RDOlast_basis1.Enabled = instatus
        RDOlast_basis2.Enabled = instatus
        RDOlast_basis3.Enabled = instatus
        RDOlast_basis4.Enabled = instatus
        RDOlast_period1.Enabled = instatus
        RDOlast_period2.Enabled = instatus
        RDOlast_period3.Enabled = instatus
        RDOlast_period4.Enabled = instatus
        RDOlast_status1.Enabled = instatus
        RDOlast_status2.Enabled = instatus
        RDOlast_status3.Enabled = instatus
        RDOlast_status4.Enabled = instatus
        DteLast_Raise.Enabled = instatus
        Dtebirthday_date.Enabled = instatus
        Dtehired_date.Enabled = instatus
        Dtelast_reiew_date.Enabled = instatus
        Dteterminate_date.Enabled = instatus
        ZipCode1.Enabled = instatus
        Cmbcod_deparment.Enabled = instatus
        Cmbcod_position.Enabled = instatus
        PhoneNoMain.Enabled = instatus
        PhoneButton1.ZEnabled = instatus

        Select Case TypeOfForm
            Case 2 ' sales
                ChkTechnecian.Enabled = False
                CHKSalesPerson.Enabled = instatus
            Case 3 ' techn
                ChkTechnecian.Enabled = instatus
                CHKSalesPerson.Enabled = False
            Case Else
                ChkTechnecian.Enabled = instatus
                CHKSalesPerson.Enabled = instatus
        End Select
        ChkUsePunchClock.Enabled = instatus
        CmbStoreNo.Enabled = instatus
    End Sub
    Friend Sub ClearField()
        TxtEmployeecode.Text = ""
        Txtaddress.Text = ""
        TxtEmail.Text = ""
        Txtf_name.Text = ""
        NumAllowancesFederal.Text = ""
        Txtl_name.Text = ""
        Txtlast_hourly.Text = ""
        Txtlast_overtime.Text = ""
        Txtlast_salary.Text = ""
        NumAllowancesDepndnts.Text = ""
        Txtm_name.Text = ""
        TxtCity.Text = ""
        TxtSt.Text = ""
        Txtsocial_security_no1.Text = ""
        NumAllowancesState.Text = ""
        Chktemporary_inactive.Checked = False
        ChkTerminated.Checked = False
        RDOlast_basis1.Checked = True
        RDOlast_basis2.Checked = False
        RDOlast_basis3.Checked = False
        RDOlast_basis4.Checked = False
        RDOlast_period1.Checked = True
        RDOlast_period2.Checked = False
        RDOlast_period3.Checked = False
        RDOlast_period4.Checked = False
        RDOlast_status1.Checked = True
        RDOlast_status2.Checked = False
        RDOlast_status3.Checked = False
        RDOlast_status4.Checked = False
        DteLast_Raise.Text = ""
        Dtebirthday_date.Text = ""
        Dtehired_date.Text = ""
        Dtelast_reiew_date.Text = ""
        Dteterminate_date.Text = ""
        EmployeeNoteVar = ""
        PictureButton1.MyPicture = Nothing
        PhoneNoMain.Text = ""
        Select Case TypeOfForm
            Case 2
                ChkTechnecian.Checked = False
                CHKSalesPerson.Checked = True
            Case 3
                ChkTechnecian.Checked = True
                CHKSalesPerson.Checked = False
            Case Else
                ChkTechnecian.Checked = False
                CHKSalesPerson.Checked = False
        End Select
        ChkUsePunchClock.Checked = True
        'CmbStoreNo.SelectedValue = PubStoreNO

        Call PhoneButton1.ClearPhoneScreen()
        ZipCode1.Text = ""
        Try
            Cmbcod_position.SelectedValue = 0
        Catch ex As Exception

        End Try
        Try
            Cmbcod_deparment.SelectedValue = 0
        Catch ex As Exception

        End Try
    End Sub
    Friend Function PInsert() As String
        Dim thisrow As DataRow
        PInsert = ""
        'Dim c1 As New FrmWhatDoForMenu
        'c1.BtnLeftText = "Cancel"
        'c1.BtnRightText = "OK"
        'c1.ShowFarMsg("Are you sure?")
        'If c1.DialogResult = DialogResult.OK Then

        'End If
        Try
            With CmdInsert
                If .Connection.State <> ConnectionState.Open Then
                    .Connection.Open()
                End If
                .Parameters("@Employee_Code").Value = TxtEmployeecode.Text
                .Parameters("@f_Name").Value = Txtf_name.Text
                .Parameters("@m_name").Value = Txtm_name.Text
                .Parameters("@l_name").Value = Txtl_name.Text
                .Parameters("@address").Value = Txtaddress.Text
                .Parameters("@ZipCode").Value = IIf(ZipCode1.Text.Trim.Length > 0, ZipCode1.Text, System.DBNull.Value)
                .Parameters("@technecian").Value = DecodeCheckBox(ChkTechnecian.Checked)
                .Parameters("@Terminated").Value = DecodeCheckBox(ChkTerminated.Checked)
                .Parameters("@SalesPerson").Value = DecodeCheckBox(CHKSalesPerson.Checked)
                .Parameters("@social_security_no").Value = Txtsocial_security_no1.Text
                .Parameters("@cod_position").Value = ChkCombo(Cmbcod_position.SelectedValue)
                .Parameters("@cod_deparment").Value = ChkCombo(Cmbcod_deparment.SelectedValue)
                .Parameters("@phone_1").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_1")
                .Parameters("@extension_1").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_1")
                .Parameters("@phone_type_1").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_1"))
                .Parameters("@phone_main_1").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_1"))
                .Parameters("@phone_2").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_2")
                .Parameters("@extension_2").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_2")
                .Parameters("@phone_type_2").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_2"))
                .Parameters("@phone_main_2").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_2"))
                .Parameters("@phone_3").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_3")
                .Parameters("@extension_3").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_3")
                .Parameters("@phone_type_3").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_3"))
                .Parameters("@phone_main_3").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_3"))
                .Parameters("@phone_4").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_4")
                .Parameters("@extension_4").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_4")
                .Parameters("@phone_type_4").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_4"))
                .Parameters("@phone_main_4").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_4"))
                .Parameters("@phone_5").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_5")
                .Parameters("@extension_5").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_5")
                .Parameters("@phone_type_5").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_5"))
                .Parameters("@phone_main_5").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_5"))
                .Parameters("@email").Value = TxtEmail.Text
                .Parameters("@birthday_date").Value = Dtebirthday_date.Text
                .Parameters("@Last_Raise_date").Value = DteLast_Raise.Text
                .Parameters("@hired_date").Value = Dtehired_date.Text
                .Parameters("@last_reiew_date").Value = Dtelast_reiew_date.Text
                .Parameters("@terminate_date").Value = Dteterminate_date.Text
                .Parameters("@temporary_inactive").Value = DecodeCheckBox(Chktemporary_inactive.Checked)
                .Parameters("@last_basis").Value = IIf(RDOlast_basis1.Checked, "1", IIf(RDOlast_basis2.Checked, "2", IIf(RDOlast_basis3.Checked, "3", IIf(RDOlast_basis4.Checked, "4", "1"))))
                .Parameters("@last_period").Value = IIf(RDOlast_period1.Checked, "1", IIf(RDOlast_period2.Checked, "2", IIf(RDOlast_period3.Checked, "3", IIf(RDOlast_period4.Checked, "4", "1"))))
                .Parameters("@last_status").Value = IIf(RDOlast_status1.Checked, "1", IIf(RDOlast_status2.Checked, "2", IIf(RDOlast_status3.Checked, "3", IIf(RDOlast_status4.Checked, "4", "1"))))
                .Parameters("@last_salary").Value = Val(Txtlast_salary.Text)
                .Parameters("@last_hourly").Value = Val(Txtlast_hourly.Text)
                .Parameters("@last_overtime").Value = Val(Txtlast_overtime.Text)
                .Parameters("@Allowance_state").Value = Val(NumAllowancesState.Text)
                .Parameters("@Allowance_Depndnts").Value = Val(NumAllowancesDepndnts.Text)
                .Parameters("@Allowance_Federal").Value = Val(NumAllowancesFederal.Text)
                .Parameters("@notes").Value = EmployeeNoteVar
                .Parameters("@Pic").Value = IIf(IsNothing(PictureButton1.MyPicture), System.DBNull.Value, PictureButton1.MyPicture)
                .Parameters("@UsePunchClock").Value = DecodeCheckBox(ChkUsePunchClock.Checked)
                .Parameters("@StoreNo").Value = ChkCombo(CmbStoreNo.SelectedValue)
                .ExecuteScalar()
                PInsert = TxtEmployeecode.Text
                .Connection.Close()
            End With
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PInsert = ""
        End Try
    End Function
    Friend Function PUpdate(ByVal ThisEmployee_Code As String) As Boolean
        PUpdate = True
        Try
            With CmdUpdate
                If .Connection.State <> ConnectionState.Open Then
                    .Connection.Open()
                End If
                .Parameters("@Employee_Code").Value = TxtEmployeecode.Text
                .Parameters("@f_Name").Value = Txtf_name.Text
                .Parameters("@m_name").Value = Txtm_name.Text
                .Parameters("@l_name").Value = Txtl_name.Text
                .Parameters("@address").Value = Txtaddress.Text
                .Parameters("@ZipCode").Value = IIf(ZipCode1.Text.Trim.Length > 0, ZipCode1.Text, System.DBNull.Value)
                .Parameters("@technecian").Value = DecodeCheckBox(ChkTechnecian.Checked)
                .Parameters("@SalesPerson").Value = DecodeCheckBox(CHKSalesPerson.Checked)
                .Parameters("@Terminated").Value = DecodeCheckBox(ChkTerminated.Checked)
                .Parameters("@social_security_no").Value = Txtsocial_security_no1.Text
                .Parameters("@cod_position").Value = ChkCombo(Cmbcod_position.SelectedValue)
                .Parameters("@cod_deparment").Value = ChkCombo(Cmbcod_deparment.SelectedValue)
                .Parameters("@phone_1").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_1")
                .Parameters("@extension_1").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_1")
                .Parameters("@phone_type_1").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_1"))
                .Parameters("@phone_main_1").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_1"))
                .Parameters("@phone_2").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_2")
                .Parameters("@extension_2").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_2")
                .Parameters("@phone_type_2").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_2"))
                .Parameters("@phone_main_2").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_2"))
                .Parameters("@phone_3").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_3")
                .Parameters("@extension_3").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_3")
                .Parameters("@phone_type_3").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_3"))
                .Parameters("@phone_main_3").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_3"))
                .Parameters("@phone_4").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_4")
                .Parameters("@extension_4").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_4")
                .Parameters("@phone_type_4").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_4"))
                .Parameters("@phone_main_4").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_4"))
                .Parameters("@phone_5").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("Phone_5")
                .Parameters("@extension_5").Value = PhoneButton1.DsPhone1.Phone.Rows(0).Item("extension_5")
                .Parameters("@phone_type_5").Value = ChkCombo(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_type_5"))
                .Parameters("@phone_main_5").Value = DecodeCheckBox(PhoneButton1.DsPhone1.Phone.Rows(0).Item("phone_main_5"))
                .Parameters("@email").Value = TxtEmail.Text
                .Parameters("@birthday_date").Value = Dtebirthday_date.Text
                .Parameters("@Last_Raise_date").Value = DteLast_Raise.Text
                .Parameters("@hired_date").Value = Dtehired_date.Text
                .Parameters("@last_reiew_date").Value = Dtelast_reiew_date.Text
                .Parameters("@terminate_date").Value = Dteterminate_date.Text
                .Parameters("@temporary_inactive").Value = DecodeCheckBox(Chktemporary_inactive.Checked)
                .Parameters("@last_basis").Value = IIf(RDOlast_basis1.Checked, "1", IIf(RDOlast_basis2.Checked, "2", IIf(RDOlast_basis3.Checked, "3", IIf(RDOlast_basis4.Checked, "4", "1"))))
                .Parameters("@last_period").Value = IIf(RDOlast_period1.Checked, "1", IIf(RDOlast_period2.Checked, "2", IIf(RDOlast_period3.Checked, "3", IIf(RDOlast_period4.Checked, "4", "1"))))
                .Parameters("@last_status").Value = IIf(RDOlast_status1.Checked, "1", IIf(RDOlast_status2.Checked, "2", IIf(RDOlast_status3.Checked, "3", IIf(RDOlast_status4.Checked, "4", "1"))))
                .Parameters("@last_salary").Value = Val(Txtlast_salary.Text)
                .Parameters("@last_hourly").Value = Val(Txtlast_hourly.Text)
                .Parameters("@last_overtime").Value = Val(Txtlast_overtime.Text)
                .Parameters("@Allowance_State").Value = Val(NumAllowancesState.Text)
                .Parameters("@Allowance_Depndnts").Value = Val(NumAllowancesDepndnts.Text)
                .Parameters("@Allowance_Federal").Value = Val(NumAllowancesFederal.Text)
                .Parameters("@notes").Value = EmployeeNoteVar
                .Parameters("@Pic").Value = IIf(IsNothing(PictureButton1.MyPicture), System.DBNull.Value, PictureButton1.MyPicture)
                .Parameters("@UsePunchClock").Value = DecodeCheckBox(ChkUsePunchClock.Checked)
                .Parameters("@StoreNo").Value = ChkCombo(CmbStoreNo.SelectedValue)
                .ExecuteScalar()
                .Connection.Close()
            End With
            Call SavePictureInDataBase()
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PUpdate = False
        End Try
    End Function
    Friend Function FillFields(ByVal ThisEmployee_Code As String) As Boolean
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        Try
            FillFields = False
            If ThisEmployee_Code.Trim.Length = 0 Then
                Exit Function
            End If
            If CmdGeneralForReader.Connection.State <> ConnectionState.Open Then
                CmdGeneralForReader.Connection.Open()
            End If
            CmdGeneralForReader.CommandText = "SELECT * from Employee where Employee_Code=" & Qt(ThisEmployee_Code) & WhereClauseVarWithoutWhere
            SQLReader = CmdGeneralForReader.ExecuteReader
            If SQLReader.HasRows Then
                SQLReader.Read()
                TxtEmployeecode.Text = Trim(SQLReader.Item("Employee_Code") & "")
                Txtf_name.Text = Trim(SQLReader.Item("f_name") & "")
                Txtm_name.Text = Trim(SQLReader.Item("m_name") & "")
                Txtl_name.Text = Trim(SQLReader.Item("l_name") & "")
                Txtaddress.Text = Trim(SQLReader.Item("address") & "")
                ChkTechnecian.Checked = SQLReader.Item("technecian")
                ChkTerminated.Checked = SQLReader.Item("Terminated")
                Try
                    ChkUsePunchClock.Checked = SQLReader.Item("UsePunchClock")
                Catch ex As Exception
                    ChkUsePunchClock.Checked = False
                End Try
                Try
                    CHKSalesPerson.Checked = SQLReader.Item("SalesPerson")
                Catch ex As Exception
                    CHKSalesPerson.Checked = False
                End Try
                Try
                    Txtsocial_security_no1.Text = Trim(SQLReader.Item("social_security_no") & "")
                Catch ex As Exception
                End Try
                Cmbcod_position.SelectedValue = Trim(SQLReader.Item("cod_position") & "")
                Cmbcod_deparment.SelectedValue = Trim(SQLReader.Item("cod_deparment") & "")
                CmbStoreNo.SelectedValue = Trim(SQLReader.Item("StoreNo") & "")
                TxtEmail.Text = Trim(SQLReader.Item("Email") & "")
                Try
                    Dtebirthday_date.Text = Trim(SQLReader.Item("birthday_date") & "")
                Catch ex As Exception
                End Try
                Try
                    Dtebirthday_date.Text = Trim(SQLReader.Item("birthday_date") & "")
                Catch ex As Exception
                End Try
                Try
                    DteLast_Raise.Text = Trim(SQLReader.Item("Last_Raise_Date") & "")
                Catch ex As Exception
                End Try
                Try
                    Dtehired_date.Text = Trim(SQLReader.Item("hired_date") & "")
                Catch ex As Exception
                End Try
                Try
                    Dtelast_reiew_date.Text = Trim(SQLReader.Item("last_reiew_date") & "")
                Catch ex As Exception
                End Try
                Try
                    Dteterminate_date.Text = Trim(SQLReader.Item("terminate_date") & "")
                Catch ex As Exception
                End Try
                Chktemporary_inactive.Checked = SQLReader.Item("temporary_inactive")
                Select Case Trim(SQLReader.Item("last_period"))
                    Case "1"
                        RDOlast_period1.Checked = True
                    Case "2"
                        RDOlast_period2.Checked = True
                    Case "3"
                        RDOlast_period3.Checked = True
                    Case "4"
                        RDOlast_period4.Checked = True
                    Case Else
                        RDOlast_period1.Checked = True
                End Select
                Select Case Trim(SQLReader.Item("last_status"))
                    Case "1"
                        RDOlast_status1.Checked = True
                    Case "2"
                        RDOlast_status2.Checked = True
                    Case "3"
                        RDOlast_status3.Checked = True
                    Case "4"
                        RDOlast_status4.Checked = True
                    Case Else
                        RDOlast_status1.Checked = True
                End Select
                Select Case Trim(SQLReader.Item("last_basis"))
                    Case "1"
                        RDOlast_basis1.Checked = True
                    Case "2"
                        RDOlast_basis2.Checked = True
                    Case "3"
                        RDOlast_basis3.Checked = True
                    Case "4"
                        RDOlast_basis4.Checked = True
                    Case Else
                        RDOlast_basis1.Checked = True
                End Select
                Txtlast_salary.Text = SQLReader.Item("last_salary") & ""
                Txtlast_hourly.Text = SQLReader.Item("last_hourly") & ""
                Txtlast_overtime.Text = SQLReader.Item("last_overtime") & ""
                NumAllowancesState.Text = Trim(SQLReader.Item("Allowance_State")) & ""
                NumAllowancesDepndnts.Text = Trim(SQLReader.Item("Allowance_Depndnts")) & ""
                NumAllowancesFederal.Text = Trim(SQLReader.Item("Allowance_Federal")) & ""
                EmployeeNoteVar = Trim(SQLReader.Item("Notes") & "")
                Dim Ziptemp1 As String = Trim(SQLReader.Item("ZipCode") & "")
                PictureButton1.MyPicture = SQLReader.Item("Pic")
                SQLReader.Close()
                CmdGeneralForReader.Connection.Close()
                ZipCode1.Text = Ziptemp1
                '''''''''''''''''''''''''''''''''''''''
                Call FillOtherFields()
                PhoneButton1.FillDataSet("Employee", "Employee_Code=" & Qt(ThisEmployee_Code))
                PhoneNoMain.Text = PhoneButton1.FillPhoneNoMain()
                FillFields = True
            Else
                Call ClearField()
            End If
        Catch ex As Exception
            MsgBox("Error in loading Data")
            Try
                SQLReader.Close()
            Catch ex1 As Exception
            End Try
        End Try
    End Function
    Private Sub FillOtherFields()
        If TxtEmployeecode.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        If CmdGeneralForReader.Connection.State <> ConnectionState.Open Then
            CmdGeneralForReader.Connection.Open()
        End If
        CmdGeneralForReader.CommandText = "SELECT * from Employee where Employee_Code=" & Qt(TxtEmployeecode.Text) '& " Order by "
        SQLReader = CmdGeneralForReader.ExecuteReader
        If SQLReader.HasRows Then
            SQLReader.Read()
            'BehComment

            'LblDeductions.Text = SQLReader.Item("")
            'LblFederalW_H.Text = SQLReader.Item("")
            'LblFICA.Text = SQLReader.Item("")
            'LblGrossPay.Text = SQLReader.Item("")
            'LblMedicare.Text = SQLReader.Item("")
            'LblNetPay.Text = SQLReader.Item("")
            'LblStateW_H.Text = SQLReader.Item("")
        Else
            LblDeductions.Text = ""
            LblFederalW_H.Text = ""
            LblFICA.Text = ""
            LblGrossPay.Text = ""
            LblMedicare.Text = ""
            LblNetPay.Text = ""
            LblStateW_H.Text = ""
        End If
        SQLReader.Close()
        CmdGeneralForReader.Connection.Close()
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
    Private Sub BtnNotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNotes.Click
        Dim MyFrmItemComments As New CommonClass.FrmItemComments
        MyFrmItemComments.TxtComments.Text = EmployeeNoteVar & ""
        Call FitToScreen(BtnNotes, MyFrmItemComments)
        MyFrmItemComments.TxtComments.MaxLength = 300
        MyFrmItemComments.ThisFormStatus = Status
        MyFrmItemComments.ShowDialog()
        EmployeeNoteVar = MyFrmItemComments.TxtCommentvar
        Call SaveButtonControl()
    End Sub
    Private Sub BtnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHistory.Click
        MsgBox("Employee History Screen ")
    End Sub
    Private Sub UiContextMenu1_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles UiContextMenu1.CommandClick
        UiContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UiContextMenu1.Commands(1).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UiContextMenu1.Commands(2).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UiContextMenu1.Commands(e.Command.Key).Checked() = Janus.Windows.UI.InheritableBoolean.True
        Select Case e.Command.Key.ToUpper
            Case "SORT1"
                EmployeeOrderFieldName = "Employee_Code"
            Case "SORT2"
                EmployeeOrderFieldName = "L_Name"
            Case "SORT3"
                EmployeeOrderFieldName = "ZipCode"
        End Select
    End Sub
    Private Sub ZipCode1_FindZipCode() Handles ZipCode1.FindZipCode
        TxtCity.Text = ZipCode1.City
        TxtSt.Text = ZipCode1.State
    End Sub
    Private Sub ZipCode1_NotFindZipCode() Handles ZipCode1.NotFindZipCode
        TxtCity.Text = ""
        TxtSt.Text = ""
    End Sub
    Private Sub PictureButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureButton1.Click
        PictureButton1.status = Status
        Call SaveButtonControl()
    End Sub
    Private Sub SavePictureInDataBase()
        PictureButton1.SavePicture(Cnn, "Employee", "Pic", "WHERE employee_code=" & Qt(TxtEmployeecode.Text))
    End Sub
    Private Sub TxtEmployeecode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtEmployeecode.LostFocus
        If Status = MainModule.WorkStates.AddNew Then
            Try
                MyClsEmployeeCod.Connection = Cnn
            Catch ex As Exception
            End Try
            If MyClsEmployeeCod.FindDesc(TxtEmployeecode.Text) Then
                MsgBox("This Employee Code already axist.Try a new Code")
                TxtEmployeecode.Clear()
                TxtEmployeecode.Focus()
            End If
        End If
    End Sub
    Private Function MakeNewEmployeeCod() As String
        Dim i As Integer
        Dim ValMakeNewcod As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select Max(employee_code) as Max_cod from Employee WHERE substring(employee_code,1,1)='E'"
            MakeNewEmployeeCod = Trim(CmdGeneral.ExecuteScalar)
            ValMakeNewcod = GetVal(MakeNewEmployeeCod, LenEmployeeCod)
            If ValMakeNewcod > 0 Then
                i = Len(ValMakeNewcod)
            Else
                i = 0
            End If
            If MakeNewEmployeeCod.Length >= i Then
                MakeNewEmployeeCod = Mid(MakeNewEmployeeCod, 1, Len(MakeNewEmployeeCod) - i) + Getcod(Str((Int(Val(ValMakeNewcod)) + 1)).Trim, Len(ValMakeNewcod))
            End If
            If MakeNewEmployeeCod.Trim.Length > LenEmployeeCod Then
                MakeNewEmployeeCod = "E0001"
            End If
        Catch ex As Exception
            MakeNewEmployeeCod = "E0001"
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
        PhoneButton1.HeaderName = Txtf_name.Text.Trim & " " & Txtm_name.Text.Trim & " " & Txtl_name.Text.Trim
        Call SaveButtonControl()
    End Sub
    Private Sub BtnLoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoan.Click
        If Status = MainModule.WorkStates.AddNew Then
            If BtnSave.Enabled = True Then
                Call PSave(True)
                BtnSave.Enabled = False
            Else
                MsgBox("Please Complete Employee Information")
                Exit Sub
            End If
            Status = MainModule.WorkStates.Edit
        End If
        Dim MyFrmEmployeeLoan As New FrmEmployeeLoan
        MyFrmEmployeeLoan.EmployeeCodVar = TxtEmployeecode.Text
        MyFrmEmployeeLoan.Status = Status
        MyFrmEmployeeLoan.ShowDialog()
    End Sub
    Private Sub BtnSaving_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaving.Click
        If Status = MainModule.WorkStates.AddNew Then
            If BtnSave.Enabled = True Then
                Call PSave(True)
                BtnSave.Enabled = False
            Else
                MsgBox("Please Complete Employee Information")
                Exit Sub
            End If
            Status = MainModule.WorkStates.Edit
        End If
        Dim MyFrmEmployeeSaving As New FrmEmployeeSaving
        MyFrmEmployeeSaving.EmployeeCodVar = TxtEmployeecode.Text
        MyFrmEmployeeSaving.Status = Status
        MyFrmEmployeeSaving.ShowDialog()
    End Sub
    Private Sub BtnGarnishment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGarnishment.Click
        If Status = MainModule.WorkStates.AddNew Then
            If BtnSave.Enabled = True Then
                Call PSave(True)
                BtnSave.Enabled = False
            Else
                MsgBox("Please Complete Employee Information")
                Exit Sub
            End If
            Status = MainModule.WorkStates.Edit
        End If
        Dim MyFrmEmployeeGarnishment As New FrmEmployeeGarnishment
        MyFrmEmployeeGarnishment.EmployeeCodVar = TxtEmployeecode.Text
        MyFrmEmployeeGarnishment.Status = Status
        MyFrmEmployeeGarnishment.ShowDialog()
    End Sub
    Private Sub BtnDeduction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeduction.Click
        If Status = MainModule.WorkStates.AddNew Then
            If BtnSave.Enabled = True Then
                Call PSave(True)
                BtnSave.Enabled = False
            Else
                MsgBox("Please Complete Employee Information")
                Exit Sub
            End If
            Status = MainModule.WorkStates.Edit
        End If
        Dim MyFrmEmployeeDeduction As New FrmEmployeeDeduction
        MyFrmEmployeeDeduction.EmployeeCodVar = TxtEmployeecode.Text
        MyFrmEmployeeDeduction.Status = Status
        MyFrmEmployeeDeduction.ShowDialog()
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        Employee_Cod1.BtnSearch_Click(sender, e)
    End Sub
    Private Sub Employee_Cod1_NotFindEmployeeCod() Handles Employee_Cod1.NotFindEmployeeCod
        Call ClearField()
    End Sub
    Private Sub BtnBeginningPayroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBeginningPayroll.Click
        Dim MyFrmBeginningPayroll As New FrmBeginningPayroll
        MyFrmBeginningPayroll.EmployeeCodeVar = TxtEmployeecode.Text
        MyFrmBeginningPayroll.Status = Status
        MyFrmBeginningPayroll.ShowDialog()
    End Sub
End Class
