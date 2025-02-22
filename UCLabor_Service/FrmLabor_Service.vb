Imports CommonClass
Imports System.IO
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports Janus.Windows.GridEX
Public Class FrmLabor_Service
    Inherits FrmBase
    Dim Status As WorkStates = MainModule.WorkStates._ReadOnly
    Dim ServiceOrderFieldName As String = "Cod_Service"
    Dim ServiceOrderVar1 As String = "Cod_Service"
    Dim ServiceOrderVar2 As String = ""
    Friend ServiceCodTempVar As String = ""
    Dim PnlSearchHeight As Integer
    Public ServiceNoteVar As String
    Dim Service_typeOldVar As String = "0"
    Dim WithEvents MyFrm1 As UCLabor_Service.FrmSearchLabor_ServiceCod
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
    Friend WithEvents CmdDelete As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
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
    Friend WithEvents Labor_Service_Cod1 As UCLabor_Service.Labor_Service_Cod
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnHistory As System.Windows.Forms.Button
    Friend WithEvents ChkBay_noUse As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAvg_timeUse As System.Windows.Forms.CheckBox
    Friend WithEvents CmbService_category As System.Windows.Forms.ComboBox
    Friend WithEvents ChkCostUse As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSchedule As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCharge_shop_supply As System.Windows.Forms.CheckBox
    Friend WithEvents ChkRequire_technician As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTaxable As System.Windows.Forms.CheckBox
    Friend WithEvents CmbService_type As System.Windows.Forms.ComboBox
    Friend WithEvents TXTExt_desc As System.Windows.Forms.TextBox
    Friend WithEvents ChkReminder As System.Windows.Forms.CheckBox
    Friend WithEvents TxtDesc_Service As System.Windows.Forms.TextBox
    Friend WithEvents TxtServiceCod As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_tab_service_type As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_tab_service_category As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmService1 As UCLabor_Service.DSFrmService
    Friend WithEvents CmGeneral As System.Windows.Forms.ContextMenu
    Friend WithEvents MAddNew As System.Windows.Forms.MenuItem
    Friend WithEvents MEdit As System.Windows.Forms.MenuItem
    Friend WithEvents MDelete As System.Windows.Forms.MenuItem
    Friend WithEvents MSave As System.Windows.Forms.MenuItem
    Friend WithEvents MCancel As System.Windows.Forms.MenuItem
    Friend WithEvents MFirstRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MPreviousRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MNextRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MLastRecord As System.Windows.Forms.MenuItem
    Friend WithEvents CmdInsertPrice As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdUpdatePrice As System.Data.SqlClient.SqlCommand
    Friend WithEvents UiCommandManager1 As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents UiContextMenu1 As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents Sort1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort3 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort11 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort21 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort31 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LblPriceLevel6 As System.Windows.Forms.Label
    Friend WithEvents LblPriceLevel5 As System.Windows.Forms.Label
    Friend WithEvents LblPriceLevel4 As System.Windows.Forms.Label
    Friend WithEvents LblPriceLevel3 As System.Windows.Forms.Label
    Friend WithEvents LblPriceLevel2 As System.Windows.Forms.Label
    Friend WithEvents LblPriceLevel1 As System.Windows.Forms.Label
    Friend WithEvents NumMiles As CalcUtils.UcCalcText
    Friend WithEvents NumDays As CalcUtils.UcCalcText
    Friend WithEvents NumCost As CalcUtils.UcCalcText
    Friend WithEvents Numavg_time As CalcUtils.UcCalcText
    Friend WithEvents Numbay_no As CalcUtils.UcCalcText
    Friend WithEvents TxtPrice_Rate As CalcUtils.UcCalcText
    Friend WithEvents TxtAmount_price1 As CalcUtils.UcCalcText
    Friend WithEvents TxtAmount_price2 As CalcUtils.UcCalcText
    Friend WithEvents TxtAmount_price3 As CalcUtils.UcCalcText
    Friend WithEvents TxtAmount_price4 As CalcUtils.UcCalcText
    Friend WithEvents TxtAmount_price5 As CalcUtils.UcCalcText
    Friend WithEvents TxtAmount_price6 As CalcUtils.UcCalcText
    Friend WithEvents Cmbtype_b_t_d_v_r As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_tab_style As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmbStyle As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CmbStyleForShow As System.Windows.Forms.ComboBox
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_tab_styleForShow As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents BtnCopyForAllStyles As Janus.Windows.EditControls.UIButton
    Friend WithEvents CnnReader As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdGeneralForReader As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdDeletePrice As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmLabor_Service))
        Me.CmdDelete = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.BtnCopyForAllStyles = New Janus.Windows.EditControls.UIButton
        Me.CmbStyleForShow = New System.Windows.Forms.ComboBox
        Me.DsFrmService1 = New UCLabor_Service.DSFrmService
        Me.Labor_Service_Cod1 = New UCLabor_Service.Labor_Service_Cod
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.CnnTemp = New System.Data.SqlClient.SqlConnection
        Me.PnlKartAmvalField = New System.Windows.Forms.Panel
        Me.CmbStyle = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Cmbtype_b_t_d_v_r = New System.Windows.Forms.ComboBox
        Me.TxtAmount_price6 = New CalcUtils.UcCalcText
        Me.TxtAmount_price5 = New CalcUtils.UcCalcText
        Me.TxtAmount_price4 = New CalcUtils.UcCalcText
        Me.TxtAmount_price3 = New CalcUtils.UcCalcText
        Me.TxtAmount_price2 = New CalcUtils.UcCalcText
        Me.TxtAmount_price1 = New CalcUtils.UcCalcText
        Me.TxtPrice_Rate = New CalcUtils.UcCalcText
        Me.Numbay_no = New CalcUtils.UcCalcText
        Me.Numavg_time = New CalcUtils.UcCalcText
        Me.NumCost = New CalcUtils.UcCalcText
        Me.NumDays = New CalcUtils.UcCalcText
        Me.NumMiles = New CalcUtils.UcCalcText
        Me.BtnHistory = New System.Windows.Forms.Button
        Me.LblPriceLevel6 = New System.Windows.Forms.Label
        Me.LblPriceLevel5 = New System.Windows.Forms.Label
        Me.LblPriceLevel4 = New System.Windows.Forms.Label
        Me.LblPriceLevel3 = New System.Windows.Forms.Label
        Me.LblPriceLevel2 = New System.Windows.Forms.Label
        Me.LblPriceLevel1 = New System.Windows.Forms.Label
        Me.ChkBay_noUse = New System.Windows.Forms.CheckBox
        Me.ChkAvg_timeUse = New System.Windows.Forms.CheckBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.CmbService_category = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ChkCostUse = New System.Windows.Forms.CheckBox
        Me.ChkSchedule = New System.Windows.Forms.CheckBox
        Me.ChkCharge_shop_supply = New System.Windows.Forms.CheckBox
        Me.ChkRequire_technician = New System.Windows.Forms.CheckBox
        Me.ChkTaxable = New System.Windows.Forms.CheckBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.CmbService_type = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TXTExt_desc = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.ChkReminder = New System.Windows.Forms.CheckBox
        Me.TxtDesc_Service = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtServiceCod = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
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
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_service_type = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_service_category = New System.Data.SqlClient.SqlDataAdapter
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
        Me.CmdInsertPrice = New System.Data.SqlClient.SqlCommand
        Me.CmdUpdatePrice = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_style = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_styleForShow = New System.Data.SqlClient.SqlDataAdapter
        Me.CnnReader = New System.Data.SqlClient.SqlConnection
        Me.CmdGeneralForReader = New System.Data.SqlClient.SqlCommand
        Me.CmdDeletePrice = New System.Data.SqlClient.SqlCommand
        Me.PnlSearch.SuspendLayout()
        CType(Me.DsFrmService1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlKartAmvalField.SuspendLayout()
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
        'CmdDelete
        '
        Me.CmdDelete.CommandText = "DELETE FROM inv_tab_labor_service WHERE (cod_service = @cod_Service)"
        Me.CmdDelete.Connection = Me.Cnn
        Me.CmdDelete.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_Service", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_service", System.Data.DataRowVersion.Original, Nothing))
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=BEH1;persist security" & _
        " info=True;initial catalog=TireMate_02;password=2191110"
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.BtnCopyForAllStyles)
        Me.PnlSearch.Controls.Add(Me.CmbStyleForShow)
        Me.PnlSearch.Controls.Add(Me.Labor_Service_Cod1)
        Me.PnlSearch.Controls.Add(Me.Label4)
        Me.PnlSearch.Controls.Add(Me.Label15)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 49)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(608, 29)
        Me.PnlSearch.TabIndex = 0
        '
        'BtnCopyForAllStyles
        '
        Me.BtnCopyForAllStyles.Location = New System.Drawing.Point(425, 1)
        Me.BtnCopyForAllStyles.Name = "BtnCopyForAllStyles"
        Me.BtnCopyForAllStyles.Size = New System.Drawing.Size(159, 23)
        Me.BtnCopyForAllStyles.TabIndex = 431
        Me.BtnCopyForAllStyles.Text = "Copy For All Styles"
        '
        'CmbStyleForShow
        '
        Me.CmbStyleForShow.DataSource = Me.DsFrmService1.inv_tab_styleForShow
        Me.CmbStyleForShow.DisplayMember = "desc_style"
        Me.CmbStyleForShow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStyleForShow.Location = New System.Drawing.Point(234, 2)
        Me.CmbStyleForShow.Name = "CmbStyleForShow"
        Me.CmbStyleForShow.Size = New System.Drawing.Size(149, 21)
        Me.CmbStyleForShow.TabIndex = 429
        Me.CmbStyleForShow.ValueMember = "style"
        '
        'DsFrmService1
        '
        Me.DsFrmService1.DataSetName = "DSFrmService"
        Me.DsFrmService1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Labor_Service_Cod1
        '
        Me.Labor_Service_Cod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Labor_Service_Cod1.Connection = Me.Cnn
        Me.Labor_Service_Cod1.Labor_serviceCod = ""
        Me.Labor_Service_Cod1.Labor_serviceCodLen = 6
        Me.Labor_Service_Cod1.Location = New System.Drawing.Point(51, 2)
        Me.Labor_Service_Cod1.Name = "Labor_Service_Cod1"
        Me.Labor_Service_Cod1.NotExitIfNotFound = False
        Me.Labor_Service_Cod1.ReleaseIfNotFoundLabor_serviceCod = False
        Me.Labor_Service_Cod1.Size = New System.Drawing.Size(101, 20)
        Me.Labor_Service_Cod1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(2, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 188
        Me.Label4.Text = "Service"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(192, 1)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 22)
        Me.Label15.TabIndex = 430
        Me.Label15.Text = "Style"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CnnTemp
        '
        Me.CnnTemp.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;" & _
        "persist security info=True;password=sa"
        '
        'PnlKartAmvalField
        '
        Me.PnlKartAmvalField.Controls.Add(Me.CmbStyle)
        Me.PnlKartAmvalField.Controls.Add(Me.Label14)
        Me.PnlKartAmvalField.Controls.Add(Me.Cmbtype_b_t_d_v_r)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtAmount_price6)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtAmount_price5)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtAmount_price4)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtAmount_price3)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtAmount_price2)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtAmount_price1)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtPrice_Rate)
        Me.PnlKartAmvalField.Controls.Add(Me.Numbay_no)
        Me.PnlKartAmvalField.Controls.Add(Me.Numavg_time)
        Me.PnlKartAmvalField.Controls.Add(Me.NumCost)
        Me.PnlKartAmvalField.Controls.Add(Me.NumDays)
        Me.PnlKartAmvalField.Controls.Add(Me.NumMiles)
        Me.PnlKartAmvalField.Controls.Add(Me.BtnHistory)
        Me.PnlKartAmvalField.Controls.Add(Me.LblPriceLevel6)
        Me.PnlKartAmvalField.Controls.Add(Me.LblPriceLevel5)
        Me.PnlKartAmvalField.Controls.Add(Me.LblPriceLevel4)
        Me.PnlKartAmvalField.Controls.Add(Me.LblPriceLevel3)
        Me.PnlKartAmvalField.Controls.Add(Me.LblPriceLevel2)
        Me.PnlKartAmvalField.Controls.Add(Me.LblPriceLevel1)
        Me.PnlKartAmvalField.Controls.Add(Me.ChkBay_noUse)
        Me.PnlKartAmvalField.Controls.Add(Me.ChkAvg_timeUse)
        Me.PnlKartAmvalField.Controls.Add(Me.Label13)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbService_category)
        Me.PnlKartAmvalField.Controls.Add(Me.Label8)
        Me.PnlKartAmvalField.Controls.Add(Me.Label1)
        Me.PnlKartAmvalField.Controls.Add(Me.Label3)
        Me.PnlKartAmvalField.Controls.Add(Me.Label2)
        Me.PnlKartAmvalField.Controls.Add(Me.ChkCostUse)
        Me.PnlKartAmvalField.Controls.Add(Me.ChkSchedule)
        Me.PnlKartAmvalField.Controls.Add(Me.ChkCharge_shop_supply)
        Me.PnlKartAmvalField.Controls.Add(Me.ChkRequire_technician)
        Me.PnlKartAmvalField.Controls.Add(Me.ChkTaxable)
        Me.PnlKartAmvalField.Controls.Add(Me.Label12)
        Me.PnlKartAmvalField.Controls.Add(Me.Label11)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbService_type)
        Me.PnlKartAmvalField.Controls.Add(Me.Label7)
        Me.PnlKartAmvalField.Controls.Add(Me.TXTExt_desc)
        Me.PnlKartAmvalField.Controls.Add(Me.Label10)
        Me.PnlKartAmvalField.Controls.Add(Me.ChkReminder)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtDesc_Service)
        Me.PnlKartAmvalField.Controls.Add(Me.Label9)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtServiceCod)
        Me.PnlKartAmvalField.Controls.Add(Me.Label5)
        Me.PnlKartAmvalField.Controls.Add(Me.Label6)
        Me.PnlKartAmvalField.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlKartAmvalField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PnlKartAmvalField.Location = New System.Drawing.Point(0, 78)
        Me.PnlKartAmvalField.Name = "PnlKartAmvalField"
        Me.PnlKartAmvalField.Size = New System.Drawing.Size(608, 234)
        Me.PnlKartAmvalField.TabIndex = 1
        '
        'CmbStyle
        '
        Me.CmbStyle.DataSource = Me.DsFrmService1.inv_tab_style
        Me.CmbStyle.DisplayMember = "desc_style"
        Me.CmbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStyle.Location = New System.Drawing.Point(452, 34)
        Me.CmbStyle.Name = "CmbStyle"
        Me.CmbStyle.Size = New System.Drawing.Size(149, 21)
        Me.CmbStyle.TabIndex = 427
        Me.CmbStyle.ValueMember = "style"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(409, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 22)
        Me.Label14.TabIndex = 428
        Me.Label14.Text = "Style"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cmbtype_b_t_d_v_r
        '
        Me.Cmbtype_b_t_d_v_r.DataSource = Me.DsFrmService1.LabarFixKind
        Me.Cmbtype_b_t_d_v_r.DisplayMember = "Name"
        Me.Cmbtype_b_t_d_v_r.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbtype_b_t_d_v_r.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Cmbtype_b_t_d_v_r.ItemHeight = 13
        Me.Cmbtype_b_t_d_v_r.Location = New System.Drawing.Point(452, 9)
        Me.Cmbtype_b_t_d_v_r.Name = "Cmbtype_b_t_d_v_r"
        Me.Cmbtype_b_t_d_v_r.Size = New System.Drawing.Size(149, 21)
        Me.Cmbtype_b_t_d_v_r.TabIndex = 1
        Me.Cmbtype_b_t_d_v_r.ValueMember = "Cod"
        '
        'TxtAmount_price6
        '
        Me.TxtAmount_price6.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtAmount_price6.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtAmount_price6.DecimalDigits = 2
        Me.TxtAmount_price6.DefaultSendValue = False
        Me.TxtAmount_price6.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtAmount_price6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtAmount_price6.Image = CType(resources.GetObject("TxtAmount_price6.Image"), System.Drawing.Image)
        Me.TxtAmount_price6.Location = New System.Drawing.Point(508, 208)
        Me.TxtAmount_price6.Maxlength = 10
        Me.TxtAmount_price6.MinusColor = System.Drawing.Color.Empty
        Me.TxtAmount_price6.Name = "TxtAmount_price6"
        Me.TxtAmount_price6.Size = New System.Drawing.Size(97, 22)
        Me.TxtAmount_price6.TabIndex = 17
        Me.TxtAmount_price6.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtAmount_price6.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtAmount_price5
        '
        Me.TxtAmount_price5.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtAmount_price5.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtAmount_price5.DecimalDigits = 2
        Me.TxtAmount_price5.DefaultSendValue = False
        Me.TxtAmount_price5.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtAmount_price5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtAmount_price5.Image = CType(resources.GetObject("TxtAmount_price5.Image"), System.Drawing.Image)
        Me.TxtAmount_price5.Location = New System.Drawing.Point(508, 180)
        Me.TxtAmount_price5.Maxlength = 10
        Me.TxtAmount_price5.MinusColor = System.Drawing.Color.Empty
        Me.TxtAmount_price5.Name = "TxtAmount_price5"
        Me.TxtAmount_price5.Size = New System.Drawing.Size(97, 22)
        Me.TxtAmount_price5.TabIndex = 16
        Me.TxtAmount_price5.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtAmount_price5.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtAmount_price4
        '
        Me.TxtAmount_price4.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtAmount_price4.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtAmount_price4.DecimalDigits = 2
        Me.TxtAmount_price4.DefaultSendValue = False
        Me.TxtAmount_price4.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtAmount_price4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtAmount_price4.Image = CType(resources.GetObject("TxtAmount_price4.Image"), System.Drawing.Image)
        Me.TxtAmount_price4.Location = New System.Drawing.Point(508, 152)
        Me.TxtAmount_price4.Maxlength = 10
        Me.TxtAmount_price4.MinusColor = System.Drawing.Color.Empty
        Me.TxtAmount_price4.Name = "TxtAmount_price4"
        Me.TxtAmount_price4.Size = New System.Drawing.Size(97, 22)
        Me.TxtAmount_price4.TabIndex = 15
        Me.TxtAmount_price4.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtAmount_price4.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtAmount_price3
        '
        Me.TxtAmount_price3.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtAmount_price3.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtAmount_price3.DecimalDigits = 2
        Me.TxtAmount_price3.DefaultSendValue = False
        Me.TxtAmount_price3.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtAmount_price3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtAmount_price3.Image = CType(resources.GetObject("TxtAmount_price3.Image"), System.Drawing.Image)
        Me.TxtAmount_price3.Location = New System.Drawing.Point(508, 124)
        Me.TxtAmount_price3.Maxlength = 10
        Me.TxtAmount_price3.MinusColor = System.Drawing.Color.Empty
        Me.TxtAmount_price3.Name = "TxtAmount_price3"
        Me.TxtAmount_price3.Size = New System.Drawing.Size(97, 22)
        Me.TxtAmount_price3.TabIndex = 14
        Me.TxtAmount_price3.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtAmount_price3.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtAmount_price2
        '
        Me.TxtAmount_price2.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtAmount_price2.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtAmount_price2.DecimalDigits = 2
        Me.TxtAmount_price2.DefaultSendValue = False
        Me.TxtAmount_price2.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtAmount_price2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtAmount_price2.Image = CType(resources.GetObject("TxtAmount_price2.Image"), System.Drawing.Image)
        Me.TxtAmount_price2.Location = New System.Drawing.Point(508, 96)
        Me.TxtAmount_price2.Maxlength = 10
        Me.TxtAmount_price2.MinusColor = System.Drawing.Color.Empty
        Me.TxtAmount_price2.Name = "TxtAmount_price2"
        Me.TxtAmount_price2.Size = New System.Drawing.Size(97, 22)
        Me.TxtAmount_price2.TabIndex = 13
        Me.TxtAmount_price2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtAmount_price2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtAmount_price1
        '
        Me.TxtAmount_price1.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtAmount_price1.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtAmount_price1.DecimalDigits = 2
        Me.TxtAmount_price1.DefaultSendValue = False
        Me.TxtAmount_price1.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtAmount_price1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtAmount_price1.Image = CType(resources.GetObject("TxtAmount_price1.Image"), System.Drawing.Image)
        Me.TxtAmount_price1.Location = New System.Drawing.Point(508, 68)
        Me.TxtAmount_price1.Maxlength = 10
        Me.TxtAmount_price1.MinusColor = System.Drawing.Color.Empty
        Me.TxtAmount_price1.Name = "TxtAmount_price1"
        Me.TxtAmount_price1.Size = New System.Drawing.Size(97, 22)
        Me.TxtAmount_price1.TabIndex = 12
        Me.TxtAmount_price1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtAmount_price1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtPrice_Rate
        '
        Me.TxtPrice_Rate.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtPrice_Rate.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtPrice_Rate.DecimalDigits = 2
        Me.TxtPrice_Rate.DefaultSendValue = False
        Me.TxtPrice_Rate.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtPrice_Rate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtPrice_Rate.Image = CType(resources.GetObject("TxtPrice_Rate.Image"), System.Drawing.Image)
        Me.TxtPrice_Rate.Location = New System.Drawing.Point(64, 93)
        Me.TxtPrice_Rate.Maxlength = 10
        Me.TxtPrice_Rate.MinusColor = System.Drawing.Color.Empty
        Me.TxtPrice_Rate.Name = "TxtPrice_Rate"
        Me.TxtPrice_Rate.Size = New System.Drawing.Size(95, 22)
        Me.TxtPrice_Rate.TabIndex = 4
        Me.TxtPrice_Rate.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtPrice_Rate.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Numbay_no
        '
        Me.Numbay_no.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Numbay_no.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Numbay_no.DecimalDigits = 2
        Me.Numbay_no.DefaultSendValue = False
        Me.Numbay_no.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Numbay_no.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Numbay_no.Image = CType(resources.GetObject("Numbay_no.Image"), System.Drawing.Image)
        Me.Numbay_no.Location = New System.Drawing.Point(206, 210)
        Me.Numbay_no.Maxlength = 10
        Me.Numbay_no.MinusColor = System.Drawing.Color.Empty
        Me.Numbay_no.Name = "Numbay_no"
        Me.Numbay_no.Size = New System.Drawing.Size(95, 22)
        Me.Numbay_no.TabIndex = 9
        Me.Numbay_no.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Numbay_no.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Numavg_time
        '
        Me.Numavg_time.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Numavg_time.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Numavg_time.DecimalDigits = 2
        Me.Numavg_time.DefaultSendValue = False
        Me.Numavg_time.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Numavg_time.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Numavg_time.Image = CType(resources.GetObject("Numavg_time.Image"), System.Drawing.Image)
        Me.Numavg_time.Location = New System.Drawing.Point(206, 181)
        Me.Numavg_time.Maxlength = 10
        Me.Numavg_time.MinusColor = System.Drawing.Color.Empty
        Me.Numavg_time.Name = "Numavg_time"
        Me.Numavg_time.Size = New System.Drawing.Size(95, 22)
        Me.Numavg_time.TabIndex = 8
        Me.Numavg_time.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Numavg_time.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumCost
        '
        Me.NumCost.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumCost.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumCost.DecimalDigits = 2
        Me.NumCost.DefaultSendValue = False
        Me.NumCost.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumCost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumCost.Image = CType(resources.GetObject("NumCost.Image"), System.Drawing.Image)
        Me.NumCost.Location = New System.Drawing.Point(206, 152)
        Me.NumCost.Maxlength = 10
        Me.NumCost.MinusColor = System.Drawing.Color.Empty
        Me.NumCost.Name = "NumCost"
        Me.NumCost.Size = New System.Drawing.Size(95, 22)
        Me.NumCost.TabIndex = 7
        Me.NumCost.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumCost.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumDays
        '
        Me.NumDays.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDays.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumDays.DecimalDigits = 0
        Me.NumDays.DefaultSendValue = False
        Me.NumDays.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDays.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumDays.Image = CType(resources.GetObject("NumDays.Image"), System.Drawing.Image)
        Me.NumDays.Location = New System.Drawing.Point(358, 124)
        Me.NumDays.Maxlength = 5
        Me.NumDays.MinusColor = System.Drawing.Color.Empty
        Me.NumDays.Name = "NumDays"
        Me.NumDays.Size = New System.Drawing.Size(76, 22)
        Me.NumDays.TabIndex = 11
        Me.NumDays.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDays.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumMiles
        '
        Me.NumMiles.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumMiles.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumMiles.DecimalDigits = 0
        Me.NumMiles.DefaultSendValue = False
        Me.NumMiles.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumMiles.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumMiles.Image = CType(resources.GetObject("NumMiles.Image"), System.Drawing.Image)
        Me.NumMiles.Location = New System.Drawing.Point(358, 94)
        Me.NumMiles.Maxlength = 7
        Me.NumMiles.MinusColor = System.Drawing.Color.Empty
        Me.NumMiles.Name = "NumMiles"
        Me.NumMiles.Size = New System.Drawing.Size(76, 22)
        Me.NumMiles.TabIndex = 10
        Me.NumMiles.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumMiles.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'BtnHistory
        '
        Me.BtnHistory.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnHistory.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnHistory.Location = New System.Drawing.Point(191, 7)
        Me.BtnHistory.Name = "BtnHistory"
        Me.BtnHistory.Size = New System.Drawing.Size(80, 22)
        Me.BtnHistory.TabIndex = 25
        Me.BtnHistory.Text = "History"
        '
        'LblPriceLevel6
        '
        Me.LblPriceLevel6.BackColor = System.Drawing.Color.Salmon
        Me.LblPriceLevel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblPriceLevel6.ForeColor = System.Drawing.Color.Yellow
        Me.LblPriceLevel6.Location = New System.Drawing.Point(437, 208)
        Me.LblPriceLevel6.Name = "LblPriceLevel6"
        Me.LblPriceLevel6.Size = New System.Drawing.Size(70, 22)
        Me.LblPriceLevel6.TabIndex = 424
        Me.LblPriceLevel6.Text = "Price Level 6"
        Me.LblPriceLevel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPriceLevel5
        '
        Me.LblPriceLevel5.BackColor = System.Drawing.Color.Salmon
        Me.LblPriceLevel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblPriceLevel5.ForeColor = System.Drawing.Color.Yellow
        Me.LblPriceLevel5.Location = New System.Drawing.Point(437, 180)
        Me.LblPriceLevel5.Name = "LblPriceLevel5"
        Me.LblPriceLevel5.Size = New System.Drawing.Size(70, 22)
        Me.LblPriceLevel5.TabIndex = 423
        Me.LblPriceLevel5.Text = "Price Level 5"
        Me.LblPriceLevel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPriceLevel4
        '
        Me.LblPriceLevel4.BackColor = System.Drawing.Color.Salmon
        Me.LblPriceLevel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblPriceLevel4.ForeColor = System.Drawing.Color.Yellow
        Me.LblPriceLevel4.Location = New System.Drawing.Point(437, 152)
        Me.LblPriceLevel4.Name = "LblPriceLevel4"
        Me.LblPriceLevel4.Size = New System.Drawing.Size(70, 22)
        Me.LblPriceLevel4.TabIndex = 422
        Me.LblPriceLevel4.Text = "Price Level 4"
        Me.LblPriceLevel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPriceLevel3
        '
        Me.LblPriceLevel3.BackColor = System.Drawing.Color.Salmon
        Me.LblPriceLevel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblPriceLevel3.ForeColor = System.Drawing.Color.Yellow
        Me.LblPriceLevel3.Location = New System.Drawing.Point(437, 124)
        Me.LblPriceLevel3.Name = "LblPriceLevel3"
        Me.LblPriceLevel3.Size = New System.Drawing.Size(70, 22)
        Me.LblPriceLevel3.TabIndex = 421
        Me.LblPriceLevel3.Text = "Price Level 3"
        Me.LblPriceLevel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPriceLevel2
        '
        Me.LblPriceLevel2.BackColor = System.Drawing.Color.Salmon
        Me.LblPriceLevel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblPriceLevel2.ForeColor = System.Drawing.Color.Yellow
        Me.LblPriceLevel2.Location = New System.Drawing.Point(437, 96)
        Me.LblPriceLevel2.Name = "LblPriceLevel2"
        Me.LblPriceLevel2.Size = New System.Drawing.Size(70, 22)
        Me.LblPriceLevel2.TabIndex = 420
        Me.LblPriceLevel2.Text = "Price Level 2"
        Me.LblPriceLevel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPriceLevel1
        '
        Me.LblPriceLevel1.BackColor = System.Drawing.Color.Salmon
        Me.LblPriceLevel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblPriceLevel1.ForeColor = System.Drawing.Color.Yellow
        Me.LblPriceLevel1.Location = New System.Drawing.Point(437, 68)
        Me.LblPriceLevel1.Name = "LblPriceLevel1"
        Me.LblPriceLevel1.Size = New System.Drawing.Size(70, 22)
        Me.LblPriceLevel1.TabIndex = 418
        Me.LblPriceLevel1.Text = "Price Level 1"
        Me.LblPriceLevel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChkBay_noUse
        '
        Me.ChkBay_noUse.BackColor = System.Drawing.SystemColors.Control
        Me.ChkBay_noUse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBay_noUse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkBay_noUse.Location = New System.Drawing.Point(303, 213)
        Me.ChkBay_noUse.Name = "ChkBay_noUse"
        Me.ChkBay_noUse.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkBay_noUse.Size = New System.Drawing.Size(56, 15)
        Me.ChkBay_noUse.TabIndex = 23
        Me.ChkBay_noUse.Text = "Use"
        '
        'ChkAvg_timeUse
        '
        Me.ChkAvg_timeUse.BackColor = System.Drawing.SystemColors.Control
        Me.ChkAvg_timeUse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAvg_timeUse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkAvg_timeUse.Location = New System.Drawing.Point(303, 183)
        Me.ChkAvg_timeUse.Name = "ChkAvg_timeUse"
        Me.ChkAvg_timeUse.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkAvg_timeUse.Size = New System.Drawing.Size(56, 17)
        Me.ChkAvg_timeUse.TabIndex = 22
        Me.ChkAvg_timeUse.Text = "Use"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(317, 122)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 21)
        Me.Label13.TabIndex = 412
        Me.Label13.Text = "Days"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbService_category
        '
        Me.CmbService_category.DataSource = Me.DsFrmService1.inv_tab_service_category
        Me.CmbService_category.DisplayMember = "desc_srvice_category"
        Me.CmbService_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbService_category.Location = New System.Drawing.Point(206, 124)
        Me.CmbService_category.Name = "CmbService_category"
        Me.CmbService_category.Size = New System.Drawing.Size(112, 21)
        Me.CmbService_category.TabIndex = 6
        Me.CmbService_category.ValueMember = "service_category"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(148, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 22)
        Me.Label8.TabIndex = 411
        Me.Label8.Tag = ""
        Me.Label8.Text = "Category"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(141, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 22)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Bay No"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(141, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 21)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Avg. Time"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(141, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 22)
        Me.Label2.TabIndex = 408
        Me.Label2.Text = "Cost"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChkCostUse
        '
        Me.ChkCostUse.BackColor = System.Drawing.SystemColors.Control
        Me.ChkCostUse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkCostUse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkCostUse.Location = New System.Drawing.Point(303, 154)
        Me.ChkCostUse.Name = "ChkCostUse"
        Me.ChkCostUse.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkCostUse.Size = New System.Drawing.Size(56, 18)
        Me.ChkCostUse.TabIndex = 21
        Me.ChkCostUse.Text = "Use"
        '
        'ChkSchedule
        '
        Me.ChkSchedule.BackColor = System.Drawing.SystemColors.Control
        Me.ChkSchedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSchedule.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkSchedule.Location = New System.Drawing.Point(11, 210)
        Me.ChkSchedule.Name = "ChkSchedule"
        Me.ChkSchedule.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkSchedule.Size = New System.Drawing.Size(127, 17)
        Me.ChkSchedule.TabIndex = 20
        Me.ChkSchedule.Text = "Schedule"
        '
        'ChkCharge_shop_supply
        '
        Me.ChkCharge_shop_supply.BackColor = System.Drawing.SystemColors.Control
        Me.ChkCharge_shop_supply.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkCharge_shop_supply.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkCharge_shop_supply.Location = New System.Drawing.Point(11, 182)
        Me.ChkCharge_shop_supply.Name = "ChkCharge_shop_supply"
        Me.ChkCharge_shop_supply.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkCharge_shop_supply.Size = New System.Drawing.Size(127, 17)
        Me.ChkCharge_shop_supply.TabIndex = 19
        Me.ChkCharge_shop_supply.Text = "Charge Shop Supply"
        '
        'ChkRequire_technician
        '
        Me.ChkRequire_technician.BackColor = System.Drawing.SystemColors.Control
        Me.ChkRequire_technician.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRequire_technician.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkRequire_technician.Location = New System.Drawing.Point(11, 153)
        Me.ChkRequire_technician.Name = "ChkRequire_technician"
        Me.ChkRequire_technician.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkRequire_technician.Size = New System.Drawing.Size(127, 18)
        Me.ChkRequire_technician.TabIndex = 18
        Me.ChkRequire_technician.Text = "Require Technician"
        '
        'ChkTaxable
        '
        Me.ChkTaxable.BackColor = System.Drawing.SystemColors.Control
        Me.ChkTaxable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkTaxable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkTaxable.Location = New System.Drawing.Point(11, 126)
        Me.ChkTaxable.Name = "ChkTaxable"
        Me.ChkTaxable.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkTaxable.Size = New System.Drawing.Size(127, 17)
        Me.ChkTaxable.TabIndex = 17
        Me.ChkTaxable.Text = "Taxable"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(317, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 22)
        Me.Label12.TabIndex = 395
        Me.Label12.Text = "Miles"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(-2, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 22)
        Me.Label11.TabIndex = 394
        Me.Label11.Text = "Price/Rate"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbService_type
        '
        Me.CmbService_type.DataSource = Me.DsFrmService1.inv_tab_service_type
        Me.CmbService_type.DisplayMember = "service_type_desc"
        Me.CmbService_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbService_type.Location = New System.Drawing.Point(206, 96)
        Me.CmbService_type.Name = "CmbService_type"
        Me.CmbService_type.Size = New System.Drawing.Size(112, 21)
        Me.CmbService_type.TabIndex = 5
        Me.CmbService_type.ValueMember = "service_type"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(166, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 23)
        Me.Label7.TabIndex = 393
        Me.Label7.Tag = ""
        Me.Label7.Text = "Type"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXTExt_desc
        '
        Me.TXTExt_desc.Location = New System.Drawing.Point(62, 64)
        Me.TXTExt_desc.MaxLength = 100
        Me.TXTExt_desc.Name = "TXTExt_desc"
        Me.TXTExt_desc.Size = New System.Drawing.Size(290, 20)
        Me.TXTExt_desc.TabIndex = 3
        Me.TXTExt_desc.Text = ""
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(-26, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 22)
        Me.Label10.TabIndex = 389
        Me.Label10.Text = "Ext Desc."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChkReminder
        '
        Me.ChkReminder.BackColor = System.Drawing.SystemColors.Control
        Me.ChkReminder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkReminder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkReminder.Location = New System.Drawing.Point(359, 65)
        Me.ChkReminder.Name = "ChkReminder"
        Me.ChkReminder.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkReminder.Size = New System.Drawing.Size(72, 22)
        Me.ChkReminder.TabIndex = 24
        Me.ChkReminder.Text = "Reminder"
        '
        'TxtDesc_Service
        '
        Me.TxtDesc_Service.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtDesc_Service.Location = New System.Drawing.Point(62, 35)
        Me.TxtDesc_Service.MaxLength = 50
        Me.TxtDesc_Service.Name = "TxtDesc_Service"
        Me.TxtDesc_Service.Size = New System.Drawing.Size(290, 21)
        Me.TxtDesc_Service.TabIndex = 2
        Me.TxtDesc_Service.Text = ""
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(-26, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 21)
        Me.Label9.TabIndex = 385
        Me.Label9.Text = "Description"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtServiceCod
        '
        Me.TxtServiceCod.Location = New System.Drawing.Point(62, 7)
        Me.TxtServiceCod.MaxLength = 6
        Me.TxtServiceCod.Name = "TxtServiceCod"
        Me.TxtServiceCod.Size = New System.Drawing.Size(97, 20)
        Me.TxtServiceCod.TabIndex = 0
        Me.TxtServiceCod.Text = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(6, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 22)
        Me.Label5.TabIndex = 328
        Me.Label5.Text = "Service"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(344, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 22)
        Me.Label6.TabIndex = 426
        Me.Label6.Text = "Attachment Service "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'CmdInsert
        '
        Me.CmdInsert.CommandText = "INSERT INTO inv_tab_labor_service (cod_service, desc_service, ext_desc, service_t" & _
        "ype, service_category, cost, taxable, require_technician, charge_shop_supply, sc" & _
        "hedule, avg_time, bay_no, reminder, miles, days, use_cost, use_avg_time, use_bay" & _
        "_no, type_b_t_d_v_r) VALUES (@cod_service, @desc_service, @ext_desc, @service_ty" & _
        "pe, @service_category, @cost, @taxable, @require_technician, @charge_shop_supply" & _
        ", @schedule, @avg_time, @bay_no, @reminder, @miles, @days, @use_cost, @use_avg_t" & _
        "ime, @use_bay_no, @type_b_t_d_v_r)"
        Me.CmdInsert.Connection = Me.Cnn
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_service", System.Data.SqlDbType.VarChar, 6, "cod_service"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_service", System.Data.SqlDbType.VarChar, 50, "desc_service"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ext_desc", System.Data.SqlDbType.VarChar, 100, "ext_desc"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@service_type", System.Data.SqlDbType.VarChar, 2, "service_type"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@service_category", System.Data.SqlDbType.VarChar, 2, "service_category"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cost", System.Data.SqlDbType.Real, 4, "cost"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@taxable", System.Data.SqlDbType.Bit, 1, "taxable"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@require_technician", System.Data.SqlDbType.Bit, 1, "require_technician"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@charge_shop_supply", System.Data.SqlDbType.Bit, 1, "charge_shop_supply"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@schedule", System.Data.SqlDbType.Bit, 1, "schedule"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@avg_time", System.Data.SqlDbType.Real, 4, "avg_time"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@bay_no", System.Data.SqlDbType.SmallInt, 2, "bay_no"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@reminder", System.Data.SqlDbType.Bit, 1, "reminder"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@miles", System.Data.SqlDbType.Real, 4, "miles"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@days", System.Data.SqlDbType.Real, 4, "days"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@use_cost", System.Data.SqlDbType.Bit, 1, "use_cost"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@use_avg_time", System.Data.SqlDbType.Bit, 1, "use_avg_time"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@use_bay_no", System.Data.SqlDbType.Bit, 1, "use_bay_no"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_b_t_d_v_r", System.Data.SqlDbType.VarChar, 1, "type_b_t_d_v_r"))
        '
        'CmdUpdate
        '
        Me.CmdUpdate.CommandText = "UPDATE inv_tab_labor_service SET desc_service = @desc_service, ext_desc = @ext_de" & _
        "sc, service_type = @service_type, service_category = @service_category, cost = @" & _
        "cost, taxable = @taxable, require_technician = @require_technician, charge_shop_" & _
        "supply = @charge_shop_supply, schedule = @schedule, avg_time = @avg_time, bay_no" & _
        " = @bay_no, reminder = @reminder, miles = @miles, days = @days, use_cost = @use_" & _
        "cost, use_avg_time = @use_avg_time, use_bay_no = @use_bay_no, type_b_t_d_v_r = @" & _
        "type_b_t_d_v_r WHERE (cod_service = @cod_Service)"
        Me.CmdUpdate.Connection = Me.Cnn
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_service", System.Data.SqlDbType.VarChar, 50, "desc_service"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ext_desc", System.Data.SqlDbType.VarChar, 100, "ext_desc"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@service_type", System.Data.SqlDbType.VarChar, 2, "service_type"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@service_category", System.Data.SqlDbType.VarChar, 2, "service_category"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cost", System.Data.SqlDbType.Real, 4, "cost"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@taxable", System.Data.SqlDbType.Bit, 1, "taxable"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@require_technician", System.Data.SqlDbType.Bit, 1, "require_technician"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@charge_shop_supply", System.Data.SqlDbType.Bit, 1, "charge_shop_supply"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@schedule", System.Data.SqlDbType.Bit, 1, "schedule"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@avg_time", System.Data.SqlDbType.Real, 4, "avg_time"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@bay_no", System.Data.SqlDbType.SmallInt, 2, "bay_no"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@reminder", System.Data.SqlDbType.Bit, 1, "reminder"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@miles", System.Data.SqlDbType.Real, 4, "miles"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@days", System.Data.SqlDbType.Real, 4, "days"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@use_cost", System.Data.SqlDbType.Bit, 1, "use_cost"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@use_avg_time", System.Data.SqlDbType.Bit, 1, "use_avg_time"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@use_bay_no", System.Data.SqlDbType.Bit, 1, "use_bay_no"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_b_t_d_v_r", System.Data.SqlDbType.VarChar, 1, "type_b_t_d_v_r"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_Service", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_service", System.Data.DataRowVersion.Original, Nothing))
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
        Me.Panel9.Size = New System.Drawing.Size(608, 49)
        Me.Panel9.TabIndex = 2
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label44.Location = New System.Drawing.Point(499, 33)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(43, 11)
        Me.Label44.TabIndex = 196
        Me.Label44.Text = "Order"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSortOrder
        '
        Me.BtnSortOrder.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.DropDownButton
        Me.BtnSortOrder.DropDownContextMenu = Me.UiContextMenu1
        Me.BtnSortOrder.Image = CType(resources.GetObject("BtnSortOrder.Image"), System.Drawing.Image)
        Me.BtnSortOrder.ImageSize = New System.Drawing.Size(24, 24)
        Me.BtnSortOrder.Location = New System.Drawing.Point(497, 2)
        Me.BtnSortOrder.Name = "BtnSortOrder"
        Me.BtnSortOrder.Size = New System.Drawing.Size(49, 29)
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
        Me.UiCommandManager1.Id = New System.Guid("c7d59a9c-3988-4b59-bfa8-7fc9b73a842e")
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
        Me.Sort1.Text = "Order By Service Code"
        '
        'Sort2
        '
        Me.Sort2.Key = "Sort2"
        Me.Sort2.Name = "Sort2"
        Me.Sort2.Text = "Order By Service Name"
        '
        'Sort3
        '
        Me.Sort3.Key = "Sort3"
        Me.Sort3.Name = "Sort3"
        Me.Sort3.Text = "Order By Service Type"
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
        Me.Label40.Location = New System.Drawing.Point(6, 33)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(33, 11)
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
        Me.BtnFirst.Size = New System.Drawing.Size(33, 29)
        Me.BtnFirst.TabIndex = 191
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Location = New System.Drawing.Point(133, 33)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(33, 11)
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
        Me.BtnLast.Size = New System.Drawing.Size(33, 29)
        Me.BtnLast.TabIndex = 188
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Location = New System.Drawing.Point(425, 33)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(39, 11)
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
        Me.BtnCancel.Size = New System.Drawing.Size(33, 29)
        Me.BtnCancel.TabIndex = 7
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Location = New System.Drawing.Point(303, 33)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(33, 11)
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
        Me.BtnEdit.Size = New System.Drawing.Size(33, 29)
        Me.BtnEdit.TabIndex = 4
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Location = New System.Drawing.Point(384, 33)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(33, 11)
        Me.Label50.TabIndex = 176
        Me.Label50.Text = "Save"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Location = New System.Drawing.Point(342, 33)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(37, 11)
        Me.Label51.TabIndex = 175
        Me.Label51.Text = "Delete"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Location = New System.Drawing.Point(259, 33)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(33, 11)
        Me.Label52.TabIndex = 174
        Me.Label52.Text = "New"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Location = New System.Drawing.Point(197, 33)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(33, 11)
        Me.Label53.TabIndex = 173
        Me.Label53.Text = "Find"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Location = New System.Drawing.Point(46, 33)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(33, 11)
        Me.Label54.TabIndex = 172
        Me.Label54.Text = "Prev"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Location = New System.Drawing.Point(91, 33)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(33, 11)
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
        Me.BtnDelete.Size = New System.Drawing.Size(33, 29)
        Me.BtnDelete.TabIndex = 5
        '
        'BtnNew
        '
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Location = New System.Drawing.Point(260, 2)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(33, 29)
        Me.BtnNew.TabIndex = 3
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(196, 2)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 29)
        Me.BtnFind.TabIndex = 2
        '
        'BtnNext
        '
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNext.Image = CType(resources.GetObject("BtnNext.Image"), System.Drawing.Image)
        Me.BtnNext.Location = New System.Drawing.Point(89, 2)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(33, 29)
        Me.BtnNext.TabIndex = 1
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.SystemColors.Window
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrev.Image = CType(resources.GetObject("BtnPrev.Image"), System.Drawing.Image)
        Me.BtnPrev.Location = New System.Drawing.Point(46, 2)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(33, 29)
        Me.BtnPrev.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(384, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 29)
        Me.BtnSave.TabIndex = 6
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT service_type, service_type_desc, asset_GL_account, cost_goods_GL_account, " & _
        "income_GL_account, return_GL_account FROM inv_tab_service_type"
        Me.SqlSelectCommand1.Connection = Me.CnnTemp
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO inv_tab_service_type(service_type, service_type_desc, asset_GL_accoun" & _
        "t, cost_goods_GL_account, income_GL_account, return_GL_account) VALUES (@service" & _
        "_type, @service_type_desc, @asset_GL_account, @cost_goods_GL_account, @income_GL" & _
        "_account, @return_GL_account); SELECT service_type, service_type_desc, asset_GL_" & _
        "account, cost_goods_GL_account, income_GL_account, return_GL_account FROM inv_ta" & _
        "b_service_type WHERE (service_type = @service_type)"
        Me.SqlInsertCommand1.Connection = Me.CnnTemp
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@service_type", System.Data.SqlDbType.VarChar, 2, "service_type"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@service_type_desc", System.Data.SqlDbType.VarChar, 50, "service_type_desc"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@asset_GL_account", System.Data.SqlDbType.VarChar, 10, "asset_GL_account"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cost_goods_GL_account", System.Data.SqlDbType.VarChar, 10, "cost_goods_GL_account"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@income_GL_account", System.Data.SqlDbType.VarChar, 10, "income_GL_account"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@return_GL_account", System.Data.SqlDbType.VarChar, 10, "return_GL_account"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE inv_tab_service_type SET service_type = @service_type, service_type_desc =" & _
        " @service_type_desc, asset_GL_account = @asset_GL_account, cost_goods_GL_account" & _
        " = @cost_goods_GL_account, income_GL_account = @income_GL_account, return_GL_acc" & _
        "ount = @return_GL_account WHERE (service_type = @Original_service_type) AND (ass" & _
        "et_GL_account = @Original_asset_GL_account OR @Original_asset_GL_account IS NULL" & _
        " AND asset_GL_account IS NULL) AND (cost_goods_GL_account = @Original_cost_goods" & _
        "_GL_account OR @Original_cost_goods_GL_account IS NULL AND cost_goods_GL_account" & _
        " IS NULL) AND (income_GL_account = @Original_income_GL_account OR @Original_inco" & _
        "me_GL_account IS NULL AND income_GL_account IS NULL) AND (return_GL_account = @O" & _
        "riginal_return_GL_account OR @Original_return_GL_account IS NULL AND return_GL_a" & _
        "ccount IS NULL) AND (service_type_desc = @Original_service_type_desc OR @Origina" & _
        "l_service_type_desc IS NULL AND service_type_desc IS NULL); SELECT service_type," & _
        " service_type_desc, asset_GL_account, cost_goods_GL_account, income_GL_account, " & _
        "return_GL_account FROM inv_tab_service_type WHERE (service_type = @service_type)" & _
        ""
        Me.SqlUpdateCommand1.Connection = Me.CnnTemp
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@service_type", System.Data.SqlDbType.VarChar, 2, "service_type"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@service_type_desc", System.Data.SqlDbType.VarChar, 50, "service_type_desc"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@asset_GL_account", System.Data.SqlDbType.VarChar, 10, "asset_GL_account"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cost_goods_GL_account", System.Data.SqlDbType.VarChar, 10, "cost_goods_GL_account"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@income_GL_account", System.Data.SqlDbType.VarChar, 10, "income_GL_account"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@return_GL_account", System.Data.SqlDbType.VarChar, 10, "return_GL_account"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_service_type", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "service_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_asset_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "asset_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cost_goods_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cost_goods_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_income_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "income_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_return_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "return_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_service_type_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "service_type_desc", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM inv_tab_service_type WHERE (service_type = @Original_service_type) AN" & _
        "D (asset_GL_account = @Original_asset_GL_account OR @Original_asset_GL_account I" & _
        "S NULL AND asset_GL_account IS NULL) AND (cost_goods_GL_account = @Original_cost" & _
        "_goods_GL_account OR @Original_cost_goods_GL_account IS NULL AND cost_goods_GL_a" & _
        "ccount IS NULL) AND (income_GL_account = @Original_income_GL_account OR @Origina" & _
        "l_income_GL_account IS NULL AND income_GL_account IS NULL) AND (return_GL_accoun" & _
        "t = @Original_return_GL_account OR @Original_return_GL_account IS NULL AND retur" & _
        "n_GL_account IS NULL) AND (service_type_desc = @Original_service_type_desc OR @O" & _
        "riginal_service_type_desc IS NULL AND service_type_desc IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.CnnTemp
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_service_type", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "service_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_asset_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "asset_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cost_goods_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cost_goods_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_income_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "income_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_return_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "return_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_service_type_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "service_type_desc", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAinv_tab_service_type
        '
        Me.DAinv_tab_service_type.DeleteCommand = Me.SqlDeleteCommand1
        Me.DAinv_tab_service_type.InsertCommand = Me.SqlInsertCommand1
        Me.DAinv_tab_service_type.SelectCommand = Me.SqlSelectCommand1
        Me.DAinv_tab_service_type.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_service_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("service_type", "service_type"), New System.Data.Common.DataColumnMapping("service_type_desc", "service_type_desc"), New System.Data.Common.DataColumnMapping("asset_GL_account", "asset_GL_account"), New System.Data.Common.DataColumnMapping("cost_goods_GL_account", "cost_goods_GL_account"), New System.Data.Common.DataColumnMapping("income_GL_account", "income_GL_account"), New System.Data.Common.DataColumnMapping("return_GL_account", "return_GL_account")})})
        Me.DAinv_tab_service_type.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT service_category, desc_srvice_category FROM inv_tab_service_category"
        Me.SqlSelectCommand2.Connection = Me.CnnTemp
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO inv_tab_service_category(service_category, desc_srvice_category) VALU" & _
        "ES (@service_category, @desc_srvice_category); SELECT service_category, desc_srv" & _
        "ice_category FROM inv_tab_service_category WHERE (service_category = @service_ca" & _
        "tegory)"
        Me.SqlInsertCommand2.Connection = Me.CnnTemp
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@service_category", System.Data.SqlDbType.VarChar, 2, "service_category"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_srvice_category", System.Data.SqlDbType.VarChar, 50, "desc_srvice_category"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE inv_tab_service_category SET service_category = @service_category, desc_sr" & _
        "vice_category = @desc_srvice_category WHERE (service_category = @Original_servic" & _
        "e_category) AND (desc_srvice_category = @Original_desc_srvice_category OR @Origi" & _
        "nal_desc_srvice_category IS NULL AND desc_srvice_category IS NULL); SELECT servi" & _
        "ce_category, desc_srvice_category FROM inv_tab_service_category WHERE (service_c" & _
        "ategory = @service_category)"
        Me.SqlUpdateCommand2.Connection = Me.CnnTemp
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@service_category", System.Data.SqlDbType.VarChar, 2, "service_category"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_srvice_category", System.Data.SqlDbType.VarChar, 50, "desc_srvice_category"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_service_category", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "service_category", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_srvice_category", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_srvice_category", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM inv_tab_service_category WHERE (service_category = @Original_service_" & _
        "category) AND (desc_srvice_category = @Original_desc_srvice_category OR @Origina" & _
        "l_desc_srvice_category IS NULL AND desc_srvice_category IS NULL)"
        Me.SqlDeleteCommand2.Connection = Me.CnnTemp
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_service_category", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "service_category", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_srvice_category", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_srvice_category", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAinv_tab_service_category
        '
        Me.DAinv_tab_service_category.DeleteCommand = Me.SqlDeleteCommand2
        Me.DAinv_tab_service_category.InsertCommand = Me.SqlInsertCommand2
        Me.DAinv_tab_service_category.SelectCommand = Me.SqlSelectCommand2
        Me.DAinv_tab_service_category.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_service_category", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("service_category", "service_category"), New System.Data.Common.DataColumnMapping("desc_srvice_category", "desc_srvice_category")})})
        Me.DAinv_tab_service_category.UpdateCommand = Me.SqlUpdateCommand2
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
        'CmdInsertPrice
        '
        Me.CmdInsertPrice.CommandText = "INSERT INTO inv_tab_labor_service_price (cod_service, price_rate, price_level1, p" & _
        "rice_level2, price_level3, price_level4, price_level5, price_level6, style) VALU" & _
        "ES (@cod_service, @price_rate, @price_level1, @price_level2, @price_level3, @pri" & _
        "ce_level4, @price_level5, @price_level6, @style)"
        Me.CmdInsertPrice.Connection = Me.Cnn
        Me.CmdInsertPrice.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_service", System.Data.SqlDbType.VarChar, 6, "cod_service"))
        Me.CmdInsertPrice.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_rate", System.Data.SqlDbType.Money, 8, "price_rate"))
        Me.CmdInsertPrice.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_level1", System.Data.SqlDbType.Money, 8, "price_level1"))
        Me.CmdInsertPrice.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_level2", System.Data.SqlDbType.Money, 8, "price_level2"))
        Me.CmdInsertPrice.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_level3", System.Data.SqlDbType.Money, 8, "price_level3"))
        Me.CmdInsertPrice.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_level4", System.Data.SqlDbType.Money, 8, "price_level4"))
        Me.CmdInsertPrice.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_level5", System.Data.SqlDbType.Money, 8, "price_level5"))
        Me.CmdInsertPrice.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_level6", System.Data.SqlDbType.Money, 8, "price_level6"))
        Me.CmdInsertPrice.Parameters.Add(New System.Data.SqlClient.SqlParameter("@style", System.Data.SqlDbType.VarChar, 3, "style"))
        '
        'CmdUpdatePrice
        '
        Me.CmdUpdatePrice.CommandText = "UPDATE inv_tab_labor_service_price SET price_rate = @price_rate, price_level1 = @" & _
        "price_level1, price_level2 = @price_level2, price_level3 = @price_level3, price_" & _
        "level4 = @price_level4, price_level5 = @price_level5, price_level6 = @price_leve" & _
        "l6, style = @style WHERE (cod_service = @cod_service) AND (style = @OldStyle)"
        Me.CmdUpdatePrice.Connection = Me.Cnn
        Me.CmdUpdatePrice.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_rate", System.Data.SqlDbType.Money, 8, "price_rate"))
        Me.CmdUpdatePrice.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_level1", System.Data.SqlDbType.Money, 8, "price_level1"))
        Me.CmdUpdatePrice.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_level2", System.Data.SqlDbType.Money, 8, "price_level2"))
        Me.CmdUpdatePrice.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_level3", System.Data.SqlDbType.Money, 8, "price_level3"))
        Me.CmdUpdatePrice.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_level4", System.Data.SqlDbType.Money, 8, "price_level4"))
        Me.CmdUpdatePrice.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_level5", System.Data.SqlDbType.Money, 8, "price_level5"))
        Me.CmdUpdatePrice.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_level6", System.Data.SqlDbType.Money, 8, "price_level6"))
        Me.CmdUpdatePrice.Parameters.Add(New System.Data.SqlClient.SqlParameter("@style", System.Data.SqlDbType.VarChar, 3, "style"))
        Me.CmdUpdatePrice.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_service", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_service", System.Data.DataRowVersion.Original, Nothing))
        Me.CmdUpdatePrice.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OldStyle", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "style", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT style, desc_style, remark, image_remark FROM inv_tab_style"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DAinv_tab_style
        '
        Me.DAinv_tab_style.SelectCommand = Me.SqlSelectCommand3
        Me.DAinv_tab_style.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_style", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("desc_style", "desc_style"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("image_remark", "image_remark")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT DISTINCT inv_tab_labor_service_price.style, inv_tab_style.desc_style FROM " & _
        "inv_tab_labor_service_price INNER JOIN inv_tab_style ON inv_tab_labor_service_pr" & _
        "ice.style = inv_tab_style.style WHERE (inv_tab_labor_service_price.cod_service =" & _
        " @cod_service)"
        Me.SqlSelectCommand4.Connection = Me.CnnTemp
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_service", System.Data.SqlDbType.VarChar, 6, "cod_service"))
        '
        'DAinv_tab_styleForShow
        '
        Me.DAinv_tab_styleForShow.SelectCommand = Me.SqlSelectCommand4
        Me.DAinv_tab_styleForShow.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_labor_service_price", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_price_labor_service", "id_price_labor_service"), New System.Data.Common.DataColumnMapping("cod_service", "cod_service"), New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("price_rate", "price_rate"), New System.Data.Common.DataColumnMapping("price_level1", "price_level1"), New System.Data.Common.DataColumnMapping("price_level2", "price_level2"), New System.Data.Common.DataColumnMapping("price_level3", "price_level3"), New System.Data.Common.DataColumnMapping("price_level4", "price_level4"), New System.Data.Common.DataColumnMapping("price_level5", "price_level5"), New System.Data.Common.DataColumnMapping("price_level6", "price_level6")})})
        '
        'CmdGeneralForReader
        '
        Me.CmdGeneralForReader.Connection = Me.CnnReader
        '
        'CmdDeletePrice
        '
        Me.CmdDeletePrice.CommandText = "DELETE FROM inv_tab_labor_service_price WHERE (cod_service = @cod_Service) AND (s" & _
        "tyle = @Style)"
        Me.CmdDeletePrice.Connection = Me.Cnn
        Me.CmdDeletePrice.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_Service", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_service", System.Data.DataRowVersion.Original, Nothing))
        Me.CmdDeletePrice.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Style", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "style", System.Data.DataRowVersion.Original, Nothing))
        '
        'FrmLabor_Service
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(608, 312)
        Me.Controls.Add(Me.PnlKartAmvalField)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel9)
        Me.Name = "FrmLabor_Service"
        Me.Text = "Labor And Service"
        Me.PnlSearch.ResumeLayout(False)
        CType(Me.DsFrmService1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlKartAmvalField.ResumeLayout(False)
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
    Private Sub FrmService_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        Me.CnnTemp.ConnectionString = PConnectionString
        Me.CnnReader.ConnectionString = PConnectionString
        PnlSearchHeight = PnlSearch.Height

        UiContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.True

        LblPriceLevel1.Text = PriceLevelsLabels(1)
        LblPriceLevel2.Text = PriceLevelsLabels(2)
        LblPriceLevel3.Text = PriceLevelsLabels(3)
        LblPriceLevel4.Text = PriceLevelsLabels(4)
        LblPriceLevel5.Text = PriceLevelsLabels(5)
        LblPriceLevel6.Text = PriceLevelsLabels(6)

        Cmbtype_b_t_d_v_r.Enabled = False

        Call FillDataSets()
        TxtServiceCod.MaxLength = LenLabor_ServiceCod

        If ServiceCodTempVar.Trim.Length = 0 Then
            Call PFirstRecord(False)
        Else
            Labor_Service_Cod1.Text = ServiceCodTempVar
        End If
        Call AfterSaveOrCancel()
        Labor_Service_Cod1.Focus()
    End Sub
    Private Sub FillDataSets()
        DsFrmService1.inv_tab_service_category.Clear()
        DAinv_tab_service_category.Fill(DsFrmService1, "inv_tab_service_category")
        If DsFrmService1.inv_tab_service_category.Rows.Count < 1 Then
            MsgFar("Please Fill The Service Category Table")
            Call DisableAllComponet(Me)
            Exit Sub
        End If

        DsFrmService1.inv_tab_service_type.Clear()
        DAinv_tab_service_type.Fill(DsFrmService1, "inv_tab_service_type")
        If DsFrmService1.inv_tab_service_type.Rows.Count < 1 Then
            MsgFar("Please Fill The Service Type Table")
            Call DisableAllComponet(Me)
            Exit Sub
        End If

        DsFrmService1.LabarFixKind.AddLabarFixKindRow(" ", " ")
        DsFrmService1.LabarFixKind.AddLabarFixKindRow("b", "Balance")
        DsFrmService1.LabarFixKind.AddLabarFixKindRow("t", "Tire Fee")
        DsFrmService1.LabarFixKind.AddLabarFixKindRow("d", "Disposal Fee")
        DsFrmService1.LabarFixKind.AddLabarFixKindRow("v", "Value Stem")
        DsFrmService1.LabarFixKind.AddLabarFixKindRow("r", "Road Hazard")

        DsFrmService1.inv_tab_style.Clear()
        DAinv_tab_style.Fill(DsFrmService1, "inv_tab_style")

    End Sub
    Sub PAddNew()
        Status = MainModule.WorkStates.AddNew

        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        Call EnableField(True)
        ServiceCodTempVar = Labor_Service_Cod1.Text
        Labor_Service_Cod1.Text = ""
        Call ClearField()
        TxtServiceCod.Text = MakeNewServiceCod()

        TxtServiceCod.Focus()

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
        ServiceCodTempVar = Labor_Service_Cod1.Text

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

        If Cmbtype_b_t_d_v_r.Text.Trim.Length > 0 Then
            Call DisableFieldsForType_b_t_d_v_r()
            'Try
            '    CmbStyle.SelectedValue = CmbStyleForShow.SelectedValue
            'Catch ex As Exception
            'End Try
            ''''CmbStyle.Focus()
            CmbStyle.Enabled = False
            TxtPrice_Rate.Focus()
        Else
            'Cmbtype_b_t_d_v_r.Enabled = False
            CmbStyle.Enabled = False
            TxtPrice_Rate.Focus()
        End If

    End Sub
    Sub PDelete()
        Dim c1 As New FrmWhatDoForMenu
        c1.BtnLeftText = "Cancel"
        c1.BtnRightText = "Delete"
        c1.ShowFarMsg("Are you sure?")
        If c1.DialogResult = DialogResult.OK Then
            Try
                Dim TempTypeVar As String
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "Select Count(*) From service_center_dtl Where (type_select='L' OR type_select='F' OR type_select='S') AND cod_select=" & Qt(TxtServiceCod.Text)
                If CmdGeneral.ExecuteScalar > 0 Then
                    MsgBox("This Service is used in Service center and system cannot delete it.")
                    Exit Sub
                End If

                CmdGeneral.CommandText = "Select type_b_t_d_v_r From inv_tab_labor_service Where cod_service=" & Qt(TxtServiceCod.Text)
                TempTypeVar = CmdGeneral.ExecuteScalar & ""
                If TempTypeVar.Trim.ToUpper = "B" Or TempTypeVar.Trim.ToUpper = "T" Or TempTypeVar.Trim.ToUpper = "D" Or TempTypeVar.Trim.ToUpper = "V" Or TempTypeVar.Trim.ToUpper = "R" Then
                    If CmdDeletePrice.Connection.State <> ConnectionState.Open Then
                        CmdDeletePrice.Connection.Open()
                    End If
                    CmdDeletePrice.Parameters("@Cod_Service").Value = Labor_Service_Cod1.Labor_serviceCod
                    CmdDeletePrice.Parameters("@Style").Value = CmbStyleForShow.SelectedValue
                    CmdDeletePrice.ExecuteNonQuery()
                Else
                    If CmdDelete.Connection.State <> ConnectionState.Open Then
                        CmdDelete.Connection.Open()
                    End If
                    CmdDelete.Parameters("@Cod_Service").Value = Labor_Service_Cod1.Labor_serviceCod
                    CmdDelete.ExecuteNonQuery()
                End If
                'If Labor_Service_Cod1.Text.Trim = "1" Or Labor_Service_Cod1.Text.Trim = "2" Or Labor_Service_Cod1.Text.Trim = "3" Or Labor_Service_Cod1.Text.Trim = "4" Or Labor_Service_Cod1.Text.Trim = "5" Then
                '    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                '        CmdGeneral.Connection.Open()
                '    End If
                '    CmdGeneral.CommandText = "Select Count(*) From inv_tab_labor_service_price Where cod_service=" & Qt(TxtServiceCod.Text)
                '    If CmdGeneral.ExecuteScalar = 1 Then
                '        MsgBox("System Can't delete this Rocord.This is the last Record Of " & CmbStyleForShow.Text & ".")
                '        Exit Sub
                '    End If
                'End If

                ServiceCodTempVar = ""
                Call PNextRecord(False)
                If ServiceCodTempVar.Trim.Length = 0 Then
                    Call PPreviousRecord(False)
                    If ServiceCodTempVar.Trim.Length = 0 Then
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
            Labor_Service_Cod1.Focus()
        End If
        Status = MainModule.WorkStates.Delete
    End Sub
    Sub PSave()
        Dim ChangeOK As Boolean = False
        Dim CheckIsOkType_b_t_d_v_rVar As String = CheckIsOkType_b_t_d_v_r()
        If CheckIsOkType_b_t_d_v_rVar <> TxtServiceCod.Text And CheckIsOkType_b_t_d_v_rVar.Trim.Length > 0 Then
            MsgBox("Code " & CheckIsOkType_b_t_d_v_rVar & " Is Declare as " & Cmbtype_b_t_d_v_r.Text.Trim & ".You cannot have duplicate Code for " & Cmbtype_b_t_d_v_r.Text.Trim)
            Exit Sub
        End If
        Select Case Status
            Case MainModule.WorkStates.AddNew
                ServiceCodTempVar = PInsert()
                ChangeOK = IIf(ServiceCodTempVar.Trim.Length = 0, False, True)
            Case MainModule.WorkStates.Edit
                Dim thisrow As DataRow, ThisPosition As Integer
                ChangeOK = PUpdate(ServiceCodTempVar)
        End Select
        If ChangeOK Then
            Call AfterSaveOrCancel()
            'If Status = mainmodule.WorkStates.AddNew Then
            '    Call PAddNew()
            'Else
            Status = MainModule.WorkStates.Save
            'PnlSearch.Visible = True
            Call ShowFilterProcPanel()

            'Labor_Service_Cod1.Text = ServiceCodTempVar
            Labor_Service_Cod1.Focus()
        End If
    End Sub
    Sub PCancel()
        Status = MainModule.WorkStates.Cancel
        'PnlSearch.Visible = True
        Call ShowFilterProcPanel()

        Labor_Service_Cod1.Text = ServiceCodTempVar
        Call AfterSaveOrCancel()
        Labor_Service_Cod1.Focus()
    End Sub
    Sub AfterSaveOrCancel()
        MSave.Enabled = False
        BtnSave.Enabled = False
        MCancel.Enabled = False
        BtnCancel.Enabled = False
        BtnNew.Enabled = True
        MAddNew.Enabled = True
        If TxtServiceCod.Text.Trim.Length = 0 Then
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
    Private Sub TXTServiceCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtServiceCod.TextChanged, TXTExt_desc.TextChanged, TxtAmount_price1.TextChanged, TxtAmount_price2.TextChanged, TxtAmount_price3.TextChanged, TxtAmount_price4.TextChanged, TxtAmount_price5.TextChanged, TxtAmount_price6.TextChanged, Numavg_time.TextChanged, Numbay_no.TextChanged, NumCost.TextChanged, NumDays.TextChanged, TxtDesc_Service.TextChanged, NumMiles.TextChanged, TxtPrice_Rate.TextChanged, CmbService_category.SelectedIndexChanged, CmbService_type.SelectedIndexChanged, ChkAvg_timeUse.CheckedChanged, ChkBay_noUse.CheckedChanged, ChkCharge_shop_supply.CheckedChanged, ChkCostUse.CheckedChanged, ChkReminder.CheckedChanged, ChkRequire_technician.CheckedChanged, ChkSchedule.CheckedChanged, ChkTaxable.CheckedChanged, Cmbtype_b_t_d_v_r.SelectedIndexChanged, CmbStyle.SelectedIndexChanged
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
            If TxtServiceCod.Text.Trim.Length > 0 And TxtDesc_Service.Text.Trim.Length > 0 And (Trim(Cmbtype_b_t_d_v_r.SelectedValue).Length = 0 Or CmbStyle.Text.Trim.Length > 0) Then
                BtnSave.Enabled = True
                MSave.Enabled = True
            Else
                BtnSave.Enabled = False
                MSave.Enabled = False
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
        Try
            Dim TXTSearchServiceCodTemp As String
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            Select Case ServiceOrderFieldName.ToUpper.Trim
                Case "Cod_Service".ToUpper
                    CmdGeneral.CommandText = "SELECT Top 1 Cod_Service from inv_tab_labor_service Order BY " & ServiceOrderVar1 & " ASC"
                Case "desc_Service".ToUpper
                    CmdGeneral.CommandText = "SELECT Top 1 Cod_Service from inv_tab_labor_service Order BY " & ServiceOrderVar1 & " ASC , " & ServiceOrderVar2 & " ASC "
                Case "service_type".ToUpper
                    CmdGeneral.CommandText = "SELECT Top 1 Cod_Service from inv_tab_labor_service Order BY " & ServiceOrderVar1 & " ASC , " & ServiceOrderVar2 & " ASC "
            End Select
            TXTSearchServiceCodTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.Connection.Close()
            If IsNothing(TXTSearchServiceCodTemp) Then
                TXTSearchServiceCodTemp = ""
            End If
            If TXTSearchServiceCodTemp = Labor_Service_Cod1.Text Or TXTSearchServiceCodTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the First record of this table.")
            Else
                Labor_Service_Cod1.Text = TXTSearchServiceCodTemp
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PPreviousRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchServiceCodTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Select Case ServiceOrderFieldName.ToUpper.Trim
            Case "Cod_Service".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Cod_Service from inv_tab_labor_service where Cod_Service<" & Qt(TxtServiceCod.Text) & " Order BY " & ServiceOrderVar1 & " DESC"
            Case "desc_Service".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Cod_Service from inv_tab_labor_service where (CAST(desc_service AS char(" & TxtDesc_Service.MaxLength & ")))+Cod_Service<" & Qt(InsertSpaceAfter(TxtDesc_Service.Text, TxtDesc_Service.MaxLength) & InsertSpaceAfter(TxtServiceCod.Text, TxtServiceCod.MaxLength)) & " Order BY " & ServiceOrderVar1 & " DESC , " & ServiceOrderVar2 & " DESC"
            Case "service_type".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Cod_Service from inv_tab_labor_service where (CAST(service_type as char(2)))+Cod_Service<" & Qt(InsertSpaceAfter(CmbService_type.SelectedValue, 2) & InsertSpaceAfter(TxtServiceCod.Text, TxtServiceCod.MaxLength)) & " Order BY " & ServiceOrderVar1 & " DESC , " & ServiceOrderVar2 & " DESC"
        End Select
        TXTSearchServiceCodTemp = CmdGeneral.ExecuteScalar()
        CmdGeneral.Connection.Close()
        If IsNothing(TXTSearchServiceCodTemp) Then
            TXTSearchServiceCodTemp = ""
        End If
        If TXTSearchServiceCodTemp = Labor_Service_Cod1.Text Or TXTSearchServiceCodTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the First record of this table.")
        Else
            Labor_Service_Cod1.Text = TXTSearchServiceCodTemp
            ServiceCodTempVar = TXTSearchServiceCodTemp
        End If
    End Sub
    Private Sub PNextRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchServiceCodTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Select Case ServiceOrderFieldName.ToUpper.Trim
            Case "Cod_Service".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Cod_Service from inv_tab_labor_service where Cod_Service>" & Qt(TxtServiceCod.Text) & " Order BY " & ServiceOrderVar1 & " ASC"
            Case "desc_Service".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Cod_Service from inv_tab_labor_service where (CAST(desc_service AS char(" & TxtDesc_Service.MaxLength & ")))+Cod_Service>" & Qt(InsertSpaceAfter(TxtDesc_Service.Text, TxtDesc_Service.MaxLength) & InsertSpaceAfter(TxtServiceCod.Text, TxtServiceCod.MaxLength)) & " Order BY " & ServiceOrderVar1 & " ASC , " & ServiceOrderVar2 & " ASC"
            Case "service_type".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Cod_Service from inv_tab_labor_service where (CAST(service_type as char(2)))+Cod_Service>" & Qt(InsertSpaceAfter(CmbService_type.SelectedValue, 2) & InsertSpaceAfter(TxtServiceCod.Text, TxtServiceCod.MaxLength)) & " Order BY " & ServiceOrderVar1 & " ASC , " & ServiceOrderVar2 & " ASC"
        End Select
        TXTSearchServiceCodTemp = CmdGeneral.ExecuteScalar()
        CmdGeneral.Connection.Close()
        If IsNothing(TXTSearchServiceCodTemp) Then
            TXTSearchServiceCodTemp = ""
        End If
        If TXTSearchServiceCodTemp = Labor_Service_Cod1.Text Or TXTSearchServiceCodTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            Labor_Service_Cod1.Text = TXTSearchServiceCodTemp
            ServiceCodTempVar = TXTSearchServiceCodTemp
        End If
    End Sub
    Private Sub PLastRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Try
            Dim TXTSearchServiceCodTemp As String
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            Select Case ServiceOrderFieldName.ToUpper.Trim
                Case "Cod_Service".ToUpper
                    CmdGeneral.CommandText = "SELECT Top 1 Cod_Service from inv_tab_labor_service Order BY " & ServiceOrderVar1 & " DESC"
                Case "desc_Service".ToUpper
                    CmdGeneral.CommandText = "SELECT Top 1 Cod_Service from inv_tab_labor_service Order BY " & ServiceOrderVar1 & " DESC , " & ServiceOrderVar2 & " DESC "
                Case "service_type".ToUpper
                    CmdGeneral.CommandText = "SELECT Top 1 Cod_Service from inv_tab_labor_service Order BY " & ServiceOrderVar1 & " DESC , " & ServiceOrderVar2 & " DESC "
            End Select
            TXTSearchServiceCodTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.Connection.Close()
            If IsNothing(TXTSearchServiceCodTemp) Then
                TXTSearchServiceCodTemp = ""
            End If
            If TXTSearchServiceCodTemp = Labor_Service_Cod1.Text Or TXTSearchServiceCodTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the Last record of this table.")
            Else
                Labor_Service_Cod1.Text = TXTSearchServiceCodTemp
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Labor_Service_Cod1_FindServiceCod() Handles Labor_Service_Cod1.FindLabor_serviceCod
        'Call FillFields(Labor_Service_Cod1.Text, True)
        Call FillFields(Labor_Service_Cod1.Text, IIf(Labor_Service_Cod1.Text.Trim = "1" Or Labor_Service_Cod1.Text.Trim = "2" Or Labor_Service_Cod1.Text.Trim = "3" Or Labor_Service_Cod1.Text.Trim = "4" Or Labor_Service_Cod1.Text.Trim = "5", False, True))
        DsFrmService1.inv_tab_styleForShow.Clear()
        If Cmbtype_b_t_d_v_r.Text.Trim.Length > 0 Then
            CmbStyleForShow.Enabled = True
            BtnCopyForAllStyles.Enabled = True
            DAinv_tab_styleForShow.SelectCommand.Parameters("@Cod_Service").Value = TxtServiceCod.Text
            DAinv_tab_styleForShow.Fill(DsFrmService1, "inv_tab_styleForShow")
            CmbStyleForShow.SelectedValue = CmbStyle.SelectedValue
        Else
            CmbStyleForShow.Enabled = False
            BtnCopyForAllStyles.Enabled = False
        End If
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
            Labor_Service_Cod1.Focus()
        Else
            'GRDFWG.Height = GRDFWG.Height + PnlSearchHeight
        End If
    End Sub
    Private Sub FrmService_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Labor_Service_Cod1.Text = ""
    End Sub
    Private Sub PPrintMasterInformation()
        'If Labor_Service_Cod1.text > 0 Then
        '    Dim Orpt As New RptInspectionMasterInformation
        '    DsFrmInspectionMaster1.Clear()
        '    DAInspectionMaster.SelectCommand.Parameters("@Cod_Service").Value = Labor_Service_Cod1.text
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
            TxtServiceCod.Enabled = instatus
        Else
            TxtServiceCod.Enabled = False
        End If
        TxtAmount_price1.Enabled = instatus
        TxtAmount_price2.Enabled = instatus
        TxtAmount_price3.Enabled = instatus
        TxtAmount_price4.Enabled = instatus
        TxtAmount_price5.Enabled = instatus
        TxtAmount_price6.Enabled = instatus
        Numavg_time.Enabled = instatus
        Numbay_no.Enabled = instatus
        NumCost.Enabled = instatus
        NumDays.Enabled = instatus
        TxtDesc_Service.Enabled = instatus
        TXTExt_desc.Enabled = instatus
        NumMiles.Enabled = instatus
        TxtPrice_Rate.Enabled = instatus
        CmbService_category.Enabled = instatus
        CmbService_type.Enabled = instatus
        'Cmbtype_b_t_d_v_r.Enabled = instatus
        CmbStyle.Enabled = instatus And Trim(Cmbtype_b_t_d_v_r.SelectedValue).Length > 0
        ChkAvg_timeUse.Enabled = instatus
        ChkBay_noUse.Enabled = instatus
        ChkCharge_shop_supply.Enabled = instatus
        ChkCostUse.Enabled = instatus
        ChkReminder.Enabled = instatus
        ChkRequire_technician.Enabled = instatus
        ChkSchedule.Enabled = instatus
        ChkTaxable.Enabled = instatus
    End Sub
    Friend Sub ClearField()
        Cmbtype_b_t_d_v_r.SelectedValue = " "
        CmbStyle.SelectedValue = "0"
        TxtAmount_price1.Text = 0
        TxtAmount_price2.Text = 0
        TxtAmount_price3.Text = 0
        TxtAmount_price4.Text = 0
        TxtAmount_price5.Text = 0
        TxtAmount_price6.Text = 0
        Numavg_time.Text = 0
        Numbay_no.Text = 0
        NumCost.Text = 0
        NumDays.Text = 0
        TxtDesc_Service.Text = ""
        TXTExt_desc.Text = ""
        NumMiles.Text = 0
        TxtPrice_Rate.Text = ""
        TxtServiceCod.Text = ""
        CmbService_category.SelectedValue = "0"
        CmbService_type.SelectedValue = "0"
        ChkTaxable.Checked = False
        ChkRequire_technician.Checked = False
        ChkCharge_shop_supply.Checked = False
        ChkSchedule.Checked = False
        ChkAvg_timeUse.Checked = False
        ChkBay_noUse.Checked = False
        ChkReminder.Checked = False
        ChkCostUse.Checked = False
        Service_typeOldVar = "0"
    End Sub
    Friend Function PInsert() As String
        Dim thisrow As DataRow
        PInsert = ""
        Try
            If CheckForInsert(False) Then
                With CmdInsert
                    If .Connection.State <> ConnectionState.Open Then
                        .Connection.Open()
                    End If
                    .Parameters("@avg_time").Value = Numavg_time.Text
                    .Parameters("@bay_no").Value = Numbay_no.Text
                    .Parameters("@cost").Value = NumCost.Text
                    .Parameters("@days").Value = NumDays.Text
                    .Parameters("@desc_service").Value = TxtDesc_Service.Text
                    .Parameters("@ext_desc").Value = TXTExt_desc.Text
                    .Parameters("@miles").Value = NumMiles.Text
                    .Parameters("@cod_service").Value = TxtServiceCod.Text
                    .Parameters("@service_category").Value = ChkCombo(CmbService_category.SelectedValue)
                    .Parameters("@service_type").Value = ChkCombo(CmbService_type.SelectedValue)
                    .Parameters("@use_avg_time").Value = DecodeCheckBox(ChkAvg_timeUse.Checked)
                    .Parameters("@use_bay_no").Value = DecodeCheckBox(ChkBay_noUse.Checked)
                    .Parameters("@use_cost").Value = DecodeCheckBox(ChkCostUse.Checked)
                    .Parameters("@charge_shop_supply").Value = DecodeCheckBox(ChkCharge_shop_supply.Checked)
                    .Parameters("@reminder").Value = DecodeCheckBox(ChkReminder.Checked)
                    .Parameters("@require_technician").Value = DecodeCheckBox(ChkRequire_technician.Checked)
                    .Parameters("@schedule").Value = DecodeCheckBox(ChkSchedule.Checked)
                    .Parameters("@taxable").Value = DecodeCheckBox(ChkTaxable.Checked)
                    .Parameters("@type_b_t_d_v_r").Value = Cmbtype_b_t_d_v_r.SelectedValue
                    .ExecuteNonQuery()
                    PInsert = TxtServiceCod.Text
                    .Connection.Close()
                End With
            Else
                PInsert = TxtServiceCod.Text
            End If
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select Count(*) From inv_tab_labor_service_price Where cod_service=" & Qt(TxtServiceCod.Text) & " AND style=" & Qt(CmbStyle.SelectedValue)
            If CmdGeneral.ExecuteScalar() > 0 Then
                MsgBox("This Service Code has the same style in information.")
                Exit Function
            End If
            If CmdInsertPrice.Connection.State <> ConnectionState.Open Then
                CmdInsertPrice.Connection.Open()
            End If
            CmdInsertPrice.Parameters("@cod_service").Value = TxtServiceCod.Text
            CmdInsertPrice.Parameters("@Style").Value = IIf(Trim(Cmbtype_b_t_d_v_r.SelectedValue).Length > 0, CmbStyle.SelectedValue, "0")
            CmdInsertPrice.Parameters("@price_level1").Value = TxtAmount_price1.Text
            CmdInsertPrice.Parameters("@price_level2").Value = TxtAmount_price2.Text
            CmdInsertPrice.Parameters("@price_level3").Value = TxtAmount_price3.Text
            CmdInsertPrice.Parameters("@price_level4").Value = TxtAmount_price4.Text
            CmdInsertPrice.Parameters("@price_level5").Value = TxtAmount_price5.Text
            CmdInsertPrice.Parameters("@price_level6").Value = TxtAmount_price6.Text
            CmdInsertPrice.Parameters("@price_rate").Value = TxtPrice_Rate.Text
            CmdInsertPrice.ExecuteNonQuery()
            CmdInsertPrice.Connection.Close()
        Catch ex As Exception
            MsgBox("Error In Save")
            PInsert = ""
        End Try
    End Function
    Friend Function PUpdate(ByVal ThisCod_Service As String) As Boolean
        PUpdate = True
        Try
            With CmdUpdate
                If .Connection.State <> ConnectionState.Open Then
                    .Connection.Open()
                End If
                .Parameters("@avg_time").Value = Numavg_time.Text
                .Parameters("@bay_no").Value = Numbay_no.Text
                .Parameters("@cost").Value = NumCost.Text
                .Parameters("@days").Value = NumDays.Text
                .Parameters("@desc_service").Value = TxtDesc_Service.Text
                .Parameters("@ext_desc").Value = TXTExt_desc.Text
                .Parameters("@miles").Value = NumMiles.Text
                .Parameters("@cod_service").Value = TxtServiceCod.Text
                .Parameters("@service_category").Value = ChkCombo(CmbService_category.SelectedValue)
                .Parameters("@service_type").Value = ChkCombo(CmbService_type.SelectedValue)
                .Parameters("@use_avg_time").Value = DecodeCheckBox(ChkAvg_timeUse.Checked)
                .Parameters("@use_bay_no").Value = DecodeCheckBox(ChkBay_noUse.Checked)
                .Parameters("@use_cost").Value = DecodeCheckBox(ChkCostUse.Checked)
                .Parameters("@charge_shop_supply").Value = DecodeCheckBox(ChkCharge_shop_supply.Checked)
                .Parameters("@reminder").Value = DecodeCheckBox(ChkReminder.Checked)
                .Parameters("@require_technician").Value = DecodeCheckBox(ChkRequire_technician.Checked)
                .Parameters("@schedule").Value = DecodeCheckBox(ChkSchedule.Checked)
                .Parameters("@taxable").Value = DecodeCheckBox(ChkTaxable.Checked)
                .Parameters("@type_b_t_d_v_r").Value = Cmbtype_b_t_d_v_r.SelectedValue
                .ExecuteNonQuery()
                .Connection.Close()
            End With
            If CmdUpdatePrice.Connection.State <> ConnectionState.Open Then
                CmdUpdatePrice.Connection.Open()
            End If
            CmdUpdatePrice.Parameters("@cod_service").Value = TxtServiceCod.Text
            CmdUpdatePrice.Parameters("@OldStyle").Value = Service_typeOldVar
            CmdUpdatePrice.Parameters("@Style").Value = IIf(Trim(Cmbtype_b_t_d_v_r.SelectedValue).Length > 0, CmbStyle.SelectedValue, "0")
            CmdUpdatePrice.Parameters("@price_level1").Value = TxtAmount_price1.Text
            CmdUpdatePrice.Parameters("@price_level2").Value = TxtAmount_price2.Text
            CmdUpdatePrice.Parameters("@price_level3").Value = TxtAmount_price3.Text
            CmdUpdatePrice.Parameters("@price_level4").Value = TxtAmount_price4.Text
            CmdUpdatePrice.Parameters("@price_level5").Value = TxtAmount_price5.Text
            CmdUpdatePrice.Parameters("@price_level6").Value = TxtAmount_price6.Text
            CmdUpdatePrice.Parameters("@price_rate").Value = TxtPrice_Rate.Text
            CmdUpdatePrice.ExecuteNonQuery()
            CmdUpdatePrice.Connection.Close()
        Catch ex As Exception
            MsgBox("Error In Save")
            PUpdate = False
        End Try
    End Function
    Friend Function FillFields(ByVal ThisCod_Service As String, Optional ByVal Flagfor_b_t_d_v_r As Boolean = False) As Boolean
        FillFields = False
        If ThisCod_Service.Trim.Length = 0 Or Status = MainModule.WorkStates.Edit Then
            Exit Function
        End If
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT inv_tab_labor_service.cod_service, inv_tab_labor_service.desc_service, inv_tab_labor_service.ext_desc, " _
                      & " inv_tab_labor_service.service_type, inv_tab_labor_service.service_category, inv_tab_labor_service.cost, inv_tab_labor_service.use_cost,  " _
                      & " inv_tab_labor_service.taxable, inv_tab_labor_service.require_technician, inv_tab_labor_service.charge_shop_supply,  " _
                      & " inv_tab_labor_service.schedule, inv_tab_labor_service.avg_time, inv_tab_labor_service.use_avg_time, inv_tab_labor_service.bay_no,  " _
                      & " inv_tab_labor_service.use_bay_no, inv_tab_labor_service.reminder, inv_tab_labor_service.miles, inv_tab_labor_service.days,inv_tab_labor_service.type_b_t_d_v_r  " _
                      & " FROM inv_tab_labor_service " _
                      & " where inv_tab_labor_service.Cod_Service = " & Qt(ThisCod_Service)
        SQLReader = CmdGeneral.ExecuteReader
        If SQLReader.HasRows Then
            SQLReader.Read()
            Numavg_time.Text = SQLReader.Item("avg_time")
            Numbay_no.Text = SQLReader.Item("bay_no")
            NumCost.Text = SQLReader.Item("cost")
            NumDays.Text = SQLReader.Item("days")
            TxtDesc_Service.Text = Trim(SQLReader.Item("desc_service") & "")
            TXTExt_desc.Text = Trim(SQLReader.Item("ext_desc") & "")
            NumMiles.Text = SQLReader.Item("miles")
            TxtServiceCod.Text = Trim(SQLReader.Item("cod_service") & "")
            CmbService_category.SelectedValue = Trim(SQLReader.Item("Service_category") & "")
            CmbService_type.SelectedValue = Trim(SQLReader.Item("Service_type") & "")
            Cmbtype_b_t_d_v_r.SelectedValue = Trim(SQLReader.Item("type_b_t_d_v_r") & "")
            ChkAvg_timeUse.Checked = Trim(SQLReader.Item("use_avg_time"))
            ChkBay_noUse.Checked = Trim(SQLReader.Item("use_bay_no"))
            ChkCostUse.Checked = Trim(SQLReader.Item("use_cost"))
            ChkCharge_shop_supply.Checked = Trim(SQLReader.Item("charge_shop_supply"))
            ChkReminder.Checked = Trim(SQLReader.Item("reminder"))
            ChkRequire_technician.Checked = Trim(SQLReader.Item("require_technician"))
            ChkSchedule.Checked = Trim(SQLReader.Item("schedule"))
            ChkTaxable.Checked = Trim(SQLReader.Item("taxable"))
            '''''''''''''''''''''''''''''''''''''''
            SQLReader.Close()

            'If Flagfor_b_t_d_v_r = False Then
            Call FillOtherFields(IIf(CmbStyleForShow.Text.Trim.Length > 0, CmbStyleForShow.SelectedValue, "-1"))
            'FillFields = True
            'End If
        Else
            Call ClearField()
        End If
        SQLReader.Close()
        CmdGeneral.Connection.Close()
    End Function
    Private Sub FillOtherFields(Optional ByVal ThisStyle As String = "-1")
        If TxtServiceCod.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        If ThisStyle = "-1" Then
            CmdGeneral.CommandText = "SELECT TOP 1 * from inv_tab_labor_service_price where Cod_Service=" & Qt(TxtServiceCod.Text)
        Else
            CmdGeneral.CommandText = "SELECT * from inv_tab_labor_service_price where Cod_Service=" & Qt(TxtServiceCod.Text) & " AND Style=" & Qt(ThisStyle)
        End If
        SQLReader = CmdGeneral.ExecuteReader
        If SQLReader.HasRows Then
            SQLReader.Read()
            Service_typeOldVar = SQLReader.Item("Style") & ""
            If Status = MainModule.WorkStates.Edit Then
                CmbStyle.SelectedValue = CmbStyleForShow.SelectedValue
            Else
                CmbStyle.SelectedValue = SQLReader.Item("Style") & ""
            End If

            TxtPrice_Rate.Text = SQLReader.Item("Price_Rate")
            TxtAmount_price1.Text = SQLReader.Item("price_level1")
            TxtAmount_price2.Text = SQLReader.Item("price_level2")
            TxtAmount_price3.Text = SQLReader.Item("price_level3")
            TxtAmount_price4.Text = SQLReader.Item("price_level4")
            TxtAmount_price5.Text = SQLReader.Item("price_level5")
            TxtAmount_price6.Text = SQLReader.Item("price_level6")
        Else
            Service_typeOldVar = "0"
            CmbStyle.SelectedValue = "0"
            TxtPrice_Rate.Text = 0
            TxtAmount_price1.Text = 0
            TxtAmount_price2.Text = 0
            TxtAmount_price3.Text = 0
            TxtAmount_price4.Text = 0
            TxtAmount_price5.Text = 0
            TxtAmount_price6.Text = 0
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
    Private Sub BtnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHistory.Click
        MsgBox("Service History Screen ")
    End Sub
    Private Sub BtnBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Service Balance Screen ")
    End Sub
    Private Sub TxtPrice_Rate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtPrice_Rate.Validating
        If Val(TxtAmount_price1.Text) = 0 Then
            TxtAmount_price1.Text = TxtPrice_Rate.Text
            TxtAmount_price2.Text = TxtPrice_Rate.Text
            TxtAmount_price3.Text = TxtPrice_Rate.Text
            TxtAmount_price4.Text = TxtPrice_Rate.Text
            TxtAmount_price5.Text = TxtPrice_Rate.Text
            TxtAmount_price6.Text = TxtPrice_Rate.Text
        End If
    End Sub
    Private Sub UiContextMenu1_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles UiContextMenu1.CommandClick
        UiContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UiContextMenu1.Commands(1).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UiContextMenu1.Commands(2).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UiContextMenu1.Commands(e.Command.Key).Checked() = Janus.Windows.UI.InheritableBoolean.True
        Select Case e.Command.Key.ToUpper
            Case "SORT1"
                ServiceOrderFieldName = "Cod_Service"
                ServiceOrderVar1 = "Cod_Service"
                ServiceOrderVar2 = ""
            Case "SORT2"
                ServiceOrderFieldName = "desc_Service"
                ServiceOrderVar1 = "desc_Service"
                ServiceOrderVar2 = "Cod_Service"
            Case "SORT3"
                ServiceOrderFieldName = "service_type"
                ServiceOrderVar1 = "service_type"
                ServiceOrderVar2 = "Cod_Service"
        End Select
    End Sub
    Private Sub Cmbtype_b_t_d_v_r_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbtype_b_t_d_v_r.SelectedIndexChanged
        'CmbStyle.Enabled = Cmbtype_b_t_d_v_r.Enabled And Trim(Cmbtype_b_t_d_v_r.SelectedValue).Length > 0
        If Not CmbStyle.Enabled And Cmbtype_b_t_d_v_r.Enabled Then
            CmbStyle.SelectedValue = "0"
        End If
    End Sub
    Private Function CheckIsOkType_b_t_d_v_r() As String
        If Cmbtype_b_t_d_v_r.Text.Trim.Length = 0 Then
            CheckIsOkType_b_t_d_v_r = ""
        Else
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select cod_service from inv_tab_labor_service Where type_b_t_d_v_r=" & Qt(Cmbtype_b_t_d_v_r.SelectedValue) & " AND cod_service<>" & Qt(TxtServiceCod.Text)
            CheckIsOkType_b_t_d_v_r = CmdGeneral.ExecuteScalar & ""
        End If
    End Function
    Private Sub CmbStyleForShow_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbStyleForShow.SelectionChangeCommitted
        If BtnNew.Enabled = True Then
            Call FillOtherFields(CmbStyleForShow.SelectedValue)
        End If
    End Sub
    Private Function MakeNewServiceCod() As String
        Dim i As Integer
        Dim ValMakeNewcod As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select Max(cod_service) as Max_cod from inv_tab_labor_service where substring(cod_service,1,1)='L'"
            MakeNewServiceCod = Trim(CmdGeneral.ExecuteScalar)
            ValMakeNewcod = GetVal(MakeNewServiceCod, LenLabor_ServiceCod)
            If ValMakeNewcod > 0 Then
                i = Len(ValMakeNewcod)
            Else
                i = 0
            End If
            If MakeNewServiceCod.Length >= i Then
                MakeNewServiceCod = Mid(MakeNewServiceCod, 1, Len(MakeNewServiceCod) - i) + Getcod(Str((Int(Val(ValMakeNewcod)) + 1)).Trim, Len(ValMakeNewcod))
            End If
            If MakeNewServiceCod.Trim.Length > LenVendorCod Then
                MakeNewServiceCod = "L00001"
            End If
        Catch ex As Exception
            MakeNewServiceCod = "L00001"
        Finally
            CmdGeneral.Connection.Close()
        End Try
    End Function
    Private Function CheckForInsert(ByVal KindParam As Boolean) As Boolean
        CheckForInsert = True
        If KindParam Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select Count(*) From inv_tab_labor_service Where cod_service=" & Qt(TxtServiceCod.Text)
            If CmdGeneral.ExecuteScalar() > 0 Then
                CmdGeneral.CommandText = "Select type_b_t_d_v_r From inv_tab_labor_service Where cod_service=" & Qt(TxtServiceCod.Text)
                If Trim(CmdGeneral.ExecuteScalar() & "").Length = 0 Then
                    CheckForInsert = False
                Else
                    Call FillFields(TxtServiceCod.Text, True)
                    Call DisableFieldsForType_b_t_d_v_r()
                End If
            End If
        Else
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select Count(*) From inv_tab_labor_service Where cod_service=" & Qt(TxtServiceCod.Text)
            If CmdGeneral.ExecuteScalar() > 0 Then
                CheckForInsert = False
            End If
        End If
    End Function
    Private Sub TxtServiceCod_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtServiceCod.LostFocus
        If Not CheckForInsert(True) Then
            MsgBox("This Service Code already axist.Try a new Code")
            TxtServiceCod.Clear()
            TxtServiceCod.Focus()
        End If
        If Cmbtype_b_t_d_v_r.Text.Trim.Length = 0 Then
            'Cmbtype_b_t_d_v_r.Enabled = False
            CmbStyle.Enabled = False
        End If
    End Sub
    Private Sub DisableFieldsForType_b_t_d_v_r()
        Numavg_time.Enabled = False
        Numbay_no.Enabled = False
        NumCost.Enabled = False
        NumDays.Enabled = False
        TxtDesc_Service.Enabled = False
        TXTExt_desc.Enabled = False
        NumMiles.Enabled = False
        TxtServiceCod.Enabled = False
        CmbService_category.Enabled = False
        CmbService_type.Enabled = False
        'Cmbtype_b_t_d_v_r.Enabled = False
        ChkAvg_timeUse.Enabled = False
        ChkBay_noUse.Enabled = False
        ChkCostUse.Enabled = False
        ChkCharge_shop_supply.Enabled = False
        ChkReminder.Enabled = False
        ChkRequire_technician.Enabled = False
        ChkSchedule.Enabled = False
        ChkTaxable.Enabled = False
        If Status = MainModule.WorkStates.Edit Then
            CmbStyle.Enabled = True
        ElseIf Status = MainModule.WorkStates.AddNew Then
            CmbStyle.Enabled = True
        End If
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        MyFrm1 = New UCLabor_Service.FrmSearchLabor_ServiceCod
        MyFrm1.ShowDialog()
    End Sub
    Private Sub MyFrm1_Labor_ServiceFind(ByVal ThisLabor_ServiceCod As String, ByVal Thisdesc_Service As String) Handles MyFrm1.Labor_ServiceFind
        If Thisdesc_Service.Trim.Length > 0 Then
            Labor_Service_Cod1.Text = ThisLabor_ServiceCod
        End If
    End Sub
    Private Sub BtnCopyForAllStyles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopyForAllStyles.Click
        If CmbStyleForShow.Enabled = False Then
            Exit Sub
        End If
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        If CmdGeneralForReader.Connection.State <> ConnectionState.Open Then
            CmdGeneralForReader.Connection.Open()
        End If
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneralForReader.CommandText = "SELECT style FROM inv_tab_style "
        SQLReader = CmdGeneralForReader.ExecuteReader
        If SQLReader.HasRows Then
            If CmdInsertPrice.Connection.State <> ConnectionState.Open Then
                CmdInsertPrice.Connection.Open()
            End If
            Do While SQLReader.Read()
                Try
                    CmdGeneral.CommandText = "SELECT count(*) FROM inv_tab_labor_service_price Where cod_service=" & Qt(TxtServiceCod.Text) & " AND style=" & Qt(SQLReader.Item("style"))
                    If CmdGeneral.ExecuteScalar = 0 Then
                        CmdInsertPrice.Parameters("@cod_service").Value = TxtServiceCod.Text
                        CmdInsertPrice.Parameters("@Style").Value = SQLReader.Item("style")
                        CmdInsertPrice.Parameters("@price_level1").Value = TxtAmount_price1.Text
                        CmdInsertPrice.Parameters("@price_level2").Value = TxtAmount_price2.Text
                        CmdInsertPrice.Parameters("@price_level3").Value = TxtAmount_price3.Text
                        CmdInsertPrice.Parameters("@price_level4").Value = TxtAmount_price4.Text
                        CmdInsertPrice.Parameters("@price_level5").Value = TxtAmount_price5.Text
                        CmdInsertPrice.Parameters("@price_level6").Value = TxtAmount_price6.Text
                        CmdInsertPrice.Parameters("@price_rate").Value = TxtPrice_Rate.Text
                        CmdInsertPrice.ExecuteNonQuery()
                    Else
                        If CmdUpdatePrice.Connection.State <> ConnectionState.Open Then
                            CmdUpdatePrice.Connection.Open()
                        End If
                        CmdUpdatePrice.Parameters("@cod_service").Value = TxtServiceCod.Text
                        CmdUpdatePrice.Parameters("@OldStyle").Value = SQLReader.Item("style")
                        CmdUpdatePrice.Parameters("@Style").Value = SQLReader.Item("style")
                        CmdUpdatePrice.Parameters("@price_level1").Value = TxtAmount_price1.Text
                        CmdUpdatePrice.Parameters("@price_level2").Value = TxtAmount_price2.Text
                        CmdUpdatePrice.Parameters("@price_level3").Value = TxtAmount_price3.Text
                        CmdUpdatePrice.Parameters("@price_level4").Value = TxtAmount_price4.Text
                        CmdUpdatePrice.Parameters("@price_level5").Value = TxtAmount_price5.Text
                        CmdUpdatePrice.Parameters("@price_level6").Value = TxtAmount_price6.Text
                        CmdUpdatePrice.Parameters("@price_rate").Value = TxtPrice_Rate.Text
                        CmdUpdatePrice.ExecuteNonQuery()
                    End If
                Catch ex As Exception
                End Try
            Loop
        End If
        SQLReader.Close()
        Try
            Dim StyleForShowTempVar As String = CmbStyleForShow.SelectedValue & ""
            DsFrmService1.inv_tab_styleForShow.Clear()
            DAinv_tab_styleForShow.SelectCommand.Parameters("@Cod_Service").Value = TxtServiceCod.Text
            DAinv_tab_styleForShow.Fill(DsFrmService1, "inv_tab_styleForShow")
            CmbStyleForShow.SelectedValue = StyleForShowTempVar
        Catch ex As Exception
        End Try
        MsgBox("Copy Completed")
    End Sub
End Class
