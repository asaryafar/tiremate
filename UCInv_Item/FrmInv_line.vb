Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Imports CommonClass
Public Class FrmInv_line
    Inherits FrmBase
    Dim Status As WorkStates = MainModule.WorkStates._ReadOnly
    Dim LineOrderFieldName As String = "Line"
    Dim LineOrderVar1 As String = "Line"
    Dim LineOrderVar2 As String = ""
    Friend LineTempVar As String = ""
    Dim PnlSearchHeight As Integer
    Public LineNoteVar As String
    Dim WithEvents myClsCommon As CommonClass.AllStore
    Public QuickAddFlag As Boolean = False
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
    'Friend WithEvents DsFrmService1 As UCLabor_Service.DSFrmService
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
    Friend WithEvents UiCommandManager1 As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtLine As System.Windows.Forms.TextBox
    Friend WithEvents BtnNotes As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents CmbStyle As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbcod_brand As System.Windows.Forms.ComboBox
    Friend WithEvents TxtFeatures As System.Windows.Forms.TextBox
    Friend WithEvents TxtBenefits As System.Windows.Forms.TextBox
    Friend WithEvents txtoverall_score As System.Windows.Forms.TextBox
    Friend WithEvents txtRide_Comfort As System.Windows.Forms.TextBox
    Friend WithEvents txtDry_Traction As System.Windows.Forms.TextBox
    Friend WithEvents txtnud_traction As System.Windows.Forms.TextBox
    Friend WithEvents txtwinter_traction As System.Windows.Forms.TextBox
    Friend WithEvents txthandling As System.Windows.Forms.TextBox
    Friend WithEvents txtquiet_ride As System.Windows.Forms.TextBox
    Friend WithEvents txtwet_traction As System.Windows.Forms.TextBox
    Friend WithEvents txttread_life As System.Windows.Forms.TextBox
    Friend WithEvents UiContextMenu1 As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents Sort1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort3 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAInv_tab_brand As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAInv_tab_style As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmInv_line1 As UCInv_Item.DSFrmInv_line
    Friend WithEvents Sort11 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort21 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort31 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAInv_Treadwear As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAInv_Traction As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAInv_Temperature As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAInv_LimitedWarranty As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAInv_Construction As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents PictureButton1 As UCPicture.PictureButton
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAPicture As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsPicture1 As UCInv_Item.DSPicture
    Friend WithEvents CmbConstruction As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents CmbTreadwear As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents CmbTraction As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents CmbTemperature As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents CmbLimit_warranty As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Line1 As UCInv_Item.Line
    Friend WithEvents ChkInsertToAllStore As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmInv_line))
        Me.CmdDelete = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.Line1 = New UCInv_Item.Line
        Me.Label4 = New System.Windows.Forms.Label
        Me.CnnTemp = New System.Data.SqlClient.SqlConnection
        Me.PnlKartAmvalField = New System.Windows.Forms.Panel
        Me.CmbTemperature = New Janus.Windows.EditControls.UIComboBox
        Me.DsFrmInv_line1 = New UCInv_Item.DSFrmInv_line
        Me.CmbTraction = New Janus.Windows.EditControls.UIComboBox
        Me.CmbTreadwear = New Janus.Windows.EditControls.UIComboBox
        Me.CmbLimit_warranty = New Janus.Windows.EditControls.UIComboBox
        Me.CmbConstruction = New Janus.Windows.EditControls.UIComboBox
        Me.PictureButton1 = New UCPicture.PictureButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Label14 = New System.Windows.Forms.Label
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtoverall_score = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtRide_Comfort = New System.Windows.Forms.TextBox
        Me.txtDry_Traction = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtnud_traction = New System.Windows.Forms.TextBox
        Me.txtwinter_traction = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txthandling = New System.Windows.Forms.TextBox
        Me.txtquiet_ride = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtwet_traction = New System.Windows.Forms.TextBox
        Me.txttread_life = New System.Windows.Forms.TextBox
        Me.BtnNotes = New System.Windows.Forms.Button
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.CmbStyle = New System.Windows.Forms.ComboBox
        Me.Cmbcod_brand = New System.Windows.Forms.ComboBox
        Me.TxtFeatures = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtBenefits = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtLine = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.CmdInsert = New System.Data.SqlClient.SqlCommand
        Me.CmdUpdate = New System.Data.SqlClient.SqlCommand
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.ChkInsertToAllStore = New System.Windows.Forms.CheckBox
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
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAInv_tab_brand = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAInv_tab_style = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAInv_Treadwear = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAInv_Traction = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DAInv_Temperature = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DAInv_LimitedWarranty = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand7 = New System.Data.SqlClient.SqlCommand
        Me.DAInv_Construction = New System.Data.SqlClient.SqlDataAdapter
        Me.DAPicture = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand8 = New System.Data.SqlClient.SqlCommand
        Me.DsPicture1 = New UCInv_Item.DSPicture
        Me.PnlSearch.SuspendLayout()
        Me.PnlKartAmvalField.SuspendLayout()
        CType(Me.DsFrmInv_line1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.UiContextMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1.EditContextMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPicture1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdDelete
        '
        Me.CmdDelete.CommandText = "DELETE FROM inv_tab_line WHERE (line = @line)"
        Me.CmdDelete.Connection = Me.Cnn
        Me.CmdDelete.Parameters.Add(New System.Data.SqlClient.SqlParameter("@line", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "line", System.Data.DataRowVersion.Original, Nothing))
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.Line1)
        Me.PnlSearch.Controls.Add(Me.Label4)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 49)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(571, 29)
        Me.PnlSearch.TabIndex = 1
        '
        'Line1
        '
        Me.Line1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Line1.Connection = Me.Cnn
        Me.Line1.LineCod = ""
        Me.Line1.LineCodLen = 30
        Me.Line1.Location = New System.Drawing.Point(51, 2)
        Me.Line1.Name = "Line1"
        Me.Line1.NotExitIfNotFound = False
        Me.Line1.ReleaseIfNotFoundLineCod = False
        Me.Line1.Size = New System.Drawing.Size(156, 20)
        Me.Line1.TabIndex = 191
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
        Me.Label4.Text = "Line"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CnnTemp
        '
        Me.CnnTemp.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;" & _
        "persist security info=True;password=sa"
        '
        'PnlKartAmvalField
        '
        Me.PnlKartAmvalField.Controls.Add(Me.CmbTemperature)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbTraction)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbTreadwear)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbLimit_warranty)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbConstruction)
        Me.PnlKartAmvalField.Controls.Add(Me.PictureButton1)
        Me.PnlKartAmvalField.Controls.Add(Me.Panel1)
        Me.PnlKartAmvalField.Controls.Add(Me.BtnNotes)
        Me.PnlKartAmvalField.Controls.Add(Me.Label22)
        Me.PnlKartAmvalField.Controls.Add(Me.Label19)
        Me.PnlKartAmvalField.Controls.Add(Me.Label11)
        Me.PnlKartAmvalField.Controls.Add(Me.Label9)
        Me.PnlKartAmvalField.Controls.Add(Me.Label10)
        Me.PnlKartAmvalField.Controls.Add(Me.Label7)
        Me.PnlKartAmvalField.Controls.Add(Me.Label8)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbStyle)
        Me.PnlKartAmvalField.Controls.Add(Me.Cmbcod_brand)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtFeatures)
        Me.PnlKartAmvalField.Controls.Add(Me.Label2)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtBenefits)
        Me.PnlKartAmvalField.Controls.Add(Me.Label3)
        Me.PnlKartAmvalField.Controls.Add(Me.Label1)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtLine)
        Me.PnlKartAmvalField.Controls.Add(Me.Label5)
        Me.PnlKartAmvalField.Controls.Add(Me.Label6)
        Me.PnlKartAmvalField.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlKartAmvalField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PnlKartAmvalField.Location = New System.Drawing.Point(0, 78)
        Me.PnlKartAmvalField.Name = "PnlKartAmvalField"
        Me.PnlKartAmvalField.Size = New System.Drawing.Size(571, 273)
        Me.PnlKartAmvalField.TabIndex = 2
        '
        'CmbTemperature
        '
        Me.CmbTemperature.DataMember = "Inv_Temperature"
        Me.CmbTemperature.DataSource = Me.DsFrmInv_line1
        Me.CmbTemperature.DisplayMember = "temperature"
        Me.CmbTemperature.Location = New System.Drawing.Point(125, 157)
        Me.CmbTemperature.Name = "CmbTemperature"
        Me.CmbTemperature.Size = New System.Drawing.Size(160, 20)
        Me.CmbTemperature.TabIndex = 377
        Me.CmbTemperature.ValueMember = "temperature"
        '
        'DsFrmInv_line1
        '
        Me.DsFrmInv_line1.DataSetName = "DSFrmInv_line"
        Me.DsFrmInv_line1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'CmbTraction
        '
        Me.CmbTraction.DataMember = "Inv_Traction"
        Me.CmbTraction.DataSource = Me.DsFrmInv_line1
        Me.CmbTraction.DisplayMember = "traction"
        Me.CmbTraction.Location = New System.Drawing.Point(125, 130)
        Me.CmbTraction.Name = "CmbTraction"
        Me.CmbTraction.Size = New System.Drawing.Size(160, 20)
        Me.CmbTraction.TabIndex = 6
        Me.CmbTraction.ValueMember = "traction"
        '
        'CmbTreadwear
        '
        Me.CmbTreadwear.DataMember = "Inv_Treadwear"
        Me.CmbTreadwear.DataSource = Me.DsFrmInv_line1
        Me.CmbTreadwear.DisplayMember = "treadwear"
        Me.CmbTreadwear.Location = New System.Drawing.Point(125, 102)
        Me.CmbTreadwear.Name = "CmbTreadwear"
        Me.CmbTreadwear.Size = New System.Drawing.Size(160, 20)
        Me.CmbTreadwear.TabIndex = 5
        Me.CmbTreadwear.ValueMember = "treadwear"
        '
        'CmbLimit_warranty
        '
        Me.CmbLimit_warranty.DataMember = "Inv_LimitedWarranty"
        Me.CmbLimit_warranty.DataSource = Me.DsFrmInv_line1
        Me.CmbLimit_warranty.DisplayMember = "limit_warranty"
        Me.CmbLimit_warranty.Location = New System.Drawing.Point(396, 101)
        Me.CmbLimit_warranty.Name = "CmbLimit_warranty"
        Me.CmbLimit_warranty.Size = New System.Drawing.Size(160, 20)
        Me.CmbLimit_warranty.TabIndex = 7
        Me.CmbLimit_warranty.ValueMember = "limit_warranty"
        '
        'CmbConstruction
        '
        Me.CmbConstruction.DataMember = "Inv_Construction"
        Me.CmbConstruction.DataSource = Me.DsFrmInv_line1
        Me.CmbConstruction.DisplayMember = "construction"
        Me.CmbConstruction.Location = New System.Drawing.Point(396, 130)
        Me.CmbConstruction.Name = "CmbConstruction"
        Me.CmbConstruction.Size = New System.Drawing.Size(160, 20)
        Me.CmbConstruction.TabIndex = 8
        Me.CmbConstruction.ValueMember = "construction"
        '
        'PictureButton1
        '
        Me.PictureButton1.Location = New System.Drawing.Point(473, 70)
        Me.PictureButton1.MyPicture = Nothing
        Me.PictureButton1.Name = "PictureButton1"
        Me.PictureButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PictureButton1.Size = New System.Drawing.Size(79, 23)
        Me.PictureButton1.TabIndex = 372
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel11)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Panel10)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.txtoverall_score)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.txtRide_Comfort)
        Me.Panel1.Controls.Add(Me.txtDry_Traction)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtnud_traction)
        Me.Panel1.Controls.Add(Me.txtwinter_traction)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txthandling)
        Me.Panel1.Controls.Add(Me.txtquiet_ride)
        Me.Panel1.Controls.Add(Me.Label38)
        Me.Panel1.Controls.Add(Me.Label31)
        Me.Panel1.Controls.Add(Me.txtwet_traction)
        Me.Panel1.Controls.Add(Me.txttread_life)
        Me.Panel1.Location = New System.Drawing.Point(6, 206)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(562, 65)
        Me.Panel1.TabIndex = 10
        '
        'Panel11
        '
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Location = New System.Drawing.Point(-31, 37)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(623, 1)
        Me.Panel11.TabIndex = 392
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(253, 4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 34)
        Me.Label14.TabIndex = 391
        Me.Label14.Text = "Snow Traction"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Location = New System.Drawing.Point(435, -39)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1, 165)
        Me.Panel10.TabIndex = 390
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Location = New System.Drawing.Point(373, -36)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1, 165)
        Me.Panel8.TabIndex = 389
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Location = New System.Drawing.Point(311, -19)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1, 165)
        Me.Panel7.TabIndex = 388
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Location = New System.Drawing.Point(497, -22)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1, 165)
        Me.Panel6.TabIndex = 387
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(187, -37)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1, 165)
        Me.Panel5.TabIndex = 386
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(125, -47)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 165)
        Me.Panel4.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(63, -51)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 165)
        Me.Panel3.TabIndex = 384
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(249, -51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 165)
        Me.Panel2.TabIndex = 383
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(501, 4)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 34)
        Me.Label18.TabIndex = 382
        Me.Label18.Text = "Overal Score"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtoverall_score
        '
        Me.txtoverall_score.Location = New System.Drawing.Point(498, 40)
        Me.txtoverall_score.MaxLength = 3
        Me.txtoverall_score.Name = "txtoverall_score"
        Me.txtoverall_score.Size = New System.Drawing.Size(60, 20)
        Me.txtoverall_score.TabIndex = 8
        Me.txtoverall_score.Text = ""
        Me.txtoverall_score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(377, 4)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 34)
        Me.Label16.TabIndex = 381
        Me.Label16.Text = "Dry Traction"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(439, 4)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 34)
        Me.Label17.TabIndex = 380
        Me.Label17.Text = "Ride Comfort"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRide_Comfort
        '
        Me.txtRide_Comfort.Location = New System.Drawing.Point(436, 40)
        Me.txtRide_Comfort.MaxLength = 3
        Me.txtRide_Comfort.Name = "txtRide_Comfort"
        Me.txtRide_Comfort.Size = New System.Drawing.Size(60, 20)
        Me.txtRide_Comfort.TabIndex = 7
        Me.txtRide_Comfort.Text = ""
        Me.txtRide_Comfort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDry_Traction
        '
        Me.txtDry_Traction.Location = New System.Drawing.Point(374, 40)
        Me.txtDry_Traction.MaxLength = 3
        Me.txtDry_Traction.Name = "txtDry_Traction"
        Me.txtDry_Traction.Size = New System.Drawing.Size(60, 20)
        Me.txtDry_Traction.TabIndex = 6
        Me.txtDry_Traction.Text = ""
        Me.txtDry_Traction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(317, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 34)
        Me.Label15.TabIndex = 378
        Me.Label15.Text = "Mud Traction"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtnud_traction
        '
        Me.txtnud_traction.Location = New System.Drawing.Point(312, 40)
        Me.txtnud_traction.MaxLength = 3
        Me.txtnud_traction.Name = "txtnud_traction"
        Me.txtnud_traction.Size = New System.Drawing.Size(60, 20)
        Me.txtnud_traction.TabIndex = 5
        Me.txtnud_traction.Text = ""
        Me.txtnud_traction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtwinter_traction
        '
        Me.txtwinter_traction.Location = New System.Drawing.Point(250, 40)
        Me.txtwinter_traction.MaxLength = 3
        Me.txtwinter_traction.Name = "txtwinter_traction"
        Me.txtwinter_traction.Size = New System.Drawing.Size(60, 20)
        Me.txtwinter_traction.TabIndex = 4
        Me.txtwinter_traction.Text = ""
        Me.txtwinter_traction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(129, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 34)
        Me.Label12.TabIndex = 377
        Me.Label12.Text = "Quiet Ride"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(191, 4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 34)
        Me.Label13.TabIndex = 376
        Me.Label13.Text = "Handling"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txthandling
        '
        Me.txthandling.Location = New System.Drawing.Point(188, 40)
        Me.txthandling.MaxLength = 3
        Me.txthandling.Name = "txthandling"
        Me.txthandling.Size = New System.Drawing.Size(60, 20)
        Me.txthandling.TabIndex = 3
        Me.txthandling.Text = ""
        Me.txthandling.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtquiet_ride
        '
        Me.txtquiet_ride.Location = New System.Drawing.Point(126, 40)
        Me.txtquiet_ride.MaxLength = 3
        Me.txtquiet_ride.Name = "txtquiet_ride"
        Me.txtquiet_ride.Size = New System.Drawing.Size(60, 20)
        Me.txtquiet_ride.TabIndex = 2
        Me.txtquiet_ride.Text = ""
        Me.txtquiet_ride.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.SystemColors.Control
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label38.Location = New System.Drawing.Point(5, 4)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(55, 34)
        Me.Label38.TabIndex = 375
        Me.Label38.Text = "Tread Life"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.SystemColors.Control
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label31.Location = New System.Drawing.Point(67, 4)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(55, 34)
        Me.Label31.TabIndex = 374
        Me.Label31.Text = "Wet Traction"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtwet_traction
        '
        Me.txtwet_traction.Location = New System.Drawing.Point(64, 40)
        Me.txtwet_traction.MaxLength = 3
        Me.txtwet_traction.Name = "txtwet_traction"
        Me.txtwet_traction.Size = New System.Drawing.Size(60, 20)
        Me.txtwet_traction.TabIndex = 1
        Me.txtwet_traction.Text = ""
        Me.txtwet_traction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttread_life
        '
        Me.txttread_life.Location = New System.Drawing.Point(2, 40)
        Me.txttread_life.MaxLength = 3
        Me.txttread_life.Name = "txttread_life"
        Me.txttread_life.Size = New System.Drawing.Size(60, 20)
        Me.txttread_life.TabIndex = 0
        Me.txttread_life.Text = ""
        Me.txttread_life.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnNotes
        '
        Me.BtnNotes.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnNotes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnNotes.Location = New System.Drawing.Point(473, 37)
        Me.BtnNotes.Name = "BtnNotes"
        Me.BtnNotes.Size = New System.Drawing.Size(80, 23)
        Me.BtnNotes.TabIndex = 370
        Me.BtnNotes.TabStop = False
        Me.BtnNotes.Text = "Notes"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(7, 184)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(124, 23)
        Me.Label22.TabIndex = 366
        Me.Label22.Text = "Performance Ratings"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(2, 127)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 22)
        Me.Label19.TabIndex = 365
        Me.Label19.Text = " UTQG "
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(47, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 22)
        Me.Label11.TabIndex = 355
        Me.Label11.Text = "Temperature"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(292, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 23)
        Me.Label9.TabIndex = 354
        Me.Label9.Text = "Construction"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(44, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 23)
        Me.Label10.TabIndex = 353
        Me.Label10.Text = "Traction"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(292, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 22)
        Me.Label7.TabIndex = 352
        Me.Label7.Text = "Limited Warranty"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(44, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 22)
        Me.Label8.TabIndex = 351
        Me.Label8.Text = "Treadwear"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbStyle
        '
        Me.CmbStyle.DataSource = Me.DsFrmInv_line1.inv_tab_style
        Me.CmbStyle.DisplayMember = "desc_style"
        Me.CmbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStyle.Location = New System.Drawing.Point(445, 8)
        Me.CmbStyle.Name = "CmbStyle"
        Me.CmbStyle.Size = New System.Drawing.Size(122, 21)
        Me.CmbStyle.TabIndex = 2
        Me.CmbStyle.ValueMember = "style"
        '
        'Cmbcod_brand
        '
        Me.Cmbcod_brand.DataSource = Me.DsFrmInv_line1.inv_tab_brand
        Me.Cmbcod_brand.DisplayMember = "complete_desc_brand"
        Me.Cmbcod_brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbcod_brand.Location = New System.Drawing.Point(301, 8)
        Me.Cmbcod_brand.Name = "Cmbcod_brand"
        Me.Cmbcod_brand.Size = New System.Drawing.Size(113, 21)
        Me.Cmbcod_brand.TabIndex = 1
        Me.Cmbcod_brand.ValueMember = "cod_brand"
        '
        'TxtFeatures
        '
        Me.TxtFeatures.Enabled = False
        Me.TxtFeatures.Location = New System.Drawing.Point(62, 37)
        Me.TxtFeatures.MaxLength = 75
        Me.TxtFeatures.Name = "TxtFeatures"
        Me.TxtFeatures.Size = New System.Drawing.Size(402, 20)
        Me.TxtFeatures.TabIndex = 3
        Me.TxtFeatures.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(6, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 21)
        Me.Label2.TabIndex = 331
        Me.Label2.Text = "Features"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtBenefits
        '
        Me.TxtBenefits.Enabled = False
        Me.TxtBenefits.Location = New System.Drawing.Point(62, 71)
        Me.TxtBenefits.MaxLength = 75
        Me.TxtBenefits.Name = "TxtBenefits"
        Me.TxtBenefits.Size = New System.Drawing.Size(402, 20)
        Me.TxtBenefits.TabIndex = 4
        Me.TxtBenefits.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(6, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 22)
        Me.Label3.TabIndex = 330
        Me.Label3.Text = "Benefits"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(258, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 23)
        Me.Label1.TabIndex = 329
        Me.Label1.Text = "Brand"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtLine
        '
        Me.TxtLine.Location = New System.Drawing.Point(62, 7)
        Me.TxtLine.MaxLength = 30
        Me.TxtLine.Name = "TxtLine"
        Me.TxtLine.Size = New System.Drawing.Size(196, 20)
        Me.TxtLine.TabIndex = 0
        Me.TxtLine.Text = ""
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
        Me.Label5.Text = "Line"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(405, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 23)
        Me.Label6.TabIndex = 342
        Me.Label6.Text = "Style"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'CmdInsert
        '
        Me.CmdInsert.CommandText = "INSERT INTO inv_tab_line (cod_brand, style, line, features, benefits, treadwear, " & _
        "traction, temperature, limit_warranty, construction, remark, image_remark, tread" & _
        "_life, wet_traction, quiet_ride, handling, winter_traction, nud_traction, overal" & _
        "l_score, dry_traction, ride_comfort) VALUES (@cod_brand, @style, @line, @feature" & _
        "s, @benefits, @treadwear, @traction, @temperature, @limit_warranty, @constructio" & _
        "n, @remark, @image_remark, @tread_life, @wet_traction, @quiet_ride, @handling, @" & _
        "winter_traction, @nud_traction, @overall_score, @dry_traction, @ride_comfort)"
        Me.CmdInsert.Connection = Me.Cnn
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_brand", System.Data.SqlDbType.VarChar, 3, "cod_brand"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@style", System.Data.SqlDbType.VarChar, 3, "style"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@line", System.Data.SqlDbType.VarChar, 30, "line"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@features", System.Data.SqlDbType.VarChar, 75, "features"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@benefits", System.Data.SqlDbType.VarChar, 75, "benefits"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@treadwear", System.Data.SqlDbType.VarChar, 3, "treadwear"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@traction", System.Data.SqlDbType.VarChar, 3, "traction"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@temperature", System.Data.SqlDbType.VarChar, 3, "temperature"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@limit_warranty", System.Data.SqlDbType.VarChar, 20, "limit_warranty"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@construction", System.Data.SqlDbType.VarChar, 3, "construction"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@image_remark", System.Data.SqlDbType.VarBinary, 2147483647, "image_remark"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tread_life", System.Data.SqlDbType.VarChar, 3, "tread_life"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@wet_traction", System.Data.SqlDbType.VarChar, 3, "wet_traction"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@quiet_ride", System.Data.SqlDbType.VarChar, 3, "quiet_ride"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@handling", System.Data.SqlDbType.VarChar, 3, "handling"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@winter_traction", System.Data.SqlDbType.VarChar, 3, "winter_traction"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nud_traction", System.Data.SqlDbType.VarChar, 3, "nud_traction"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@overall_score", System.Data.SqlDbType.VarChar, 3, "overall_score"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dry_traction", System.Data.SqlDbType.VarChar, 3, "dry_traction"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ride_comfort", System.Data.SqlDbType.VarChar, 3, "ride_comfort"))
        '
        'CmdUpdate
        '
        Me.CmdUpdate.CommandText = "UPDATE inv_tab_line SET style = @style, cod_brand = @cod_brand, features = @featu" & _
        "res, benefits = @benefits, treadwear = @treadwear, traction = @traction, tempera" & _
        "ture = @temperature, limit_warranty = @limit_warranty, construction = @construct" & _
        "ion, remark = @remark, image_remark = @image_remark, tread_life = @tread_life, w" & _
        "et_traction = @wet_traction, quiet_ride = @quiet_ride, handling = @handling, win" & _
        "ter_traction = @winter_traction, nud_traction = @nud_traction, overall_score = @" & _
        "overall_score, dry_traction = @dry_traction, ride_comfort = @ride_comfort WHERE " & _
        "(line = @line)"
        Me.CmdUpdate.Connection = Me.Cnn
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@style", System.Data.SqlDbType.VarChar, 3, "style"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_brand", System.Data.SqlDbType.VarChar, 3, "cod_brand"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@features", System.Data.SqlDbType.VarChar, 75, "features"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@benefits", System.Data.SqlDbType.VarChar, 75, "benefits"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@treadwear", System.Data.SqlDbType.VarChar, 3, "treadwear"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@traction", System.Data.SqlDbType.VarChar, 3, "traction"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@temperature", System.Data.SqlDbType.VarChar, 3, "temperature"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@limit_warranty", System.Data.SqlDbType.VarChar, 20, "limit_warranty"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@construction", System.Data.SqlDbType.VarChar, 3, "construction"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@image_remark", System.Data.SqlDbType.VarBinary, 16, "image_remark"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tread_life", System.Data.SqlDbType.VarChar, 3, "tread_life"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@wet_traction", System.Data.SqlDbType.VarChar, 3, "wet_traction"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@quiet_ride", System.Data.SqlDbType.VarChar, 3, "quiet_ride"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@handling", System.Data.SqlDbType.VarChar, 3, "handling"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@winter_traction", System.Data.SqlDbType.VarChar, 3, "winter_traction"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nud_traction", System.Data.SqlDbType.VarChar, 3, "nud_traction"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@overall_score", System.Data.SqlDbType.VarChar, 3, "overall_score"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@dry_traction", System.Data.SqlDbType.VarChar, 3, "dry_traction"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ride_comfort", System.Data.SqlDbType.VarChar, 3, "ride_comfort"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@line", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "line", System.Data.DataRowVersion.Original, Nothing))
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Window
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.ChkInsertToAllStore)
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
        Me.Panel9.Size = New System.Drawing.Size(571, 49)
        Me.Panel9.TabIndex = 0
        '
        'ChkInsertToAllStore
        '
        Me.ChkInsertToAllStore.Location = New System.Drawing.Point(449, 10)
        Me.ChkInsertToAllStore.Name = "ChkInsertToAllStore"
        Me.ChkInsertToAllStore.Size = New System.Drawing.Size(114, 27)
        Me.ChkInsertToAllStore.TabIndex = 198
        Me.ChkInsertToAllStore.Text = "Insert To All Store"
        Me.ChkInsertToAllStore.Visible = False
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label44.Location = New System.Drawing.Point(392, 33)
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
        Me.BtnSortOrder.Location = New System.Drawing.Point(390, 2)
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
        Me.Sort1.Text = "Order By Line Line"
        '
        'Sort2
        '
        Me.Sort2.Key = "Sort2"
        Me.Sort2.Name = "Sort2"
        Me.Sort2.Text = "Order By Brand"
        '
        'Sort3
        '
        Me.Sort3.Key = "Sort3"
        Me.Sort3.Name = "Sort3"
        Me.Sort3.Text = "Order By Style"
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
        Me.Label41.Location = New System.Drawing.Point(115, 33)
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
        Me.BtnLast.Location = New System.Drawing.Point(114, 2)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(33, 29)
        Me.BtnLast.TabIndex = 188
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Location = New System.Drawing.Point(345, 33)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(41, 11)
        Me.Label42.TabIndex = 186
        Me.Label42.Text = "Cancel"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.Enabled = False
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(349, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 29)
        Me.BtnCancel.TabIndex = 7
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Location = New System.Drawing.Point(241, 33)
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
        Me.BtnEdit.Location = New System.Drawing.Point(238, 2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(33, 29)
        Me.BtnEdit.TabIndex = 4
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Location = New System.Drawing.Point(312, 33)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(33, 11)
        Me.Label50.TabIndex = 176
        Me.Label50.Text = "Save"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Location = New System.Drawing.Point(273, 33)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(39, 11)
        Me.Label51.TabIndex = 175
        Me.Label51.Text = "Delete"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Location = New System.Drawing.Point(199, 33)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(33, 11)
        Me.Label52.TabIndex = 174
        Me.Label52.Text = "New"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Location = New System.Drawing.Point(158, 33)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(33, 11)
        Me.Label53.TabIndex = 173
        Me.Label53.Text = "Find"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Location = New System.Drawing.Point(40, 33)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(33, 11)
        Me.Label54.TabIndex = 172
        Me.Label54.Text = "Prev"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Location = New System.Drawing.Point(79, 33)
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
        Me.BtnDelete.Location = New System.Drawing.Point(275, 2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(33, 29)
        Me.BtnDelete.TabIndex = 5
        '
        'BtnNew
        '
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Location = New System.Drawing.Point(200, 2)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(33, 29)
        Me.BtnNew.TabIndex = 3
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(157, 2)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 29)
        Me.BtnFind.TabIndex = 2
        '
        'BtnNext
        '
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNext.Image = CType(resources.GetObject("BtnNext.Image"), System.Drawing.Image)
        Me.BtnNext.Location = New System.Drawing.Point(77, 2)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(33, 29)
        Me.BtnNext.TabIndex = 1
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.SystemColors.Window
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrev.Image = CType(resources.GetObject("BtnPrev.Image"), System.Drawing.Image)
        Me.BtnPrev.Location = New System.Drawing.Point(40, 2)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(33, 29)
        Me.BtnPrev.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(312, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 29)
        Me.BtnSave.TabIndex = 6
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
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cod_brand, complete_desc_brand, abbreviation_desc_brand, address, tel, con" & _
        "ect_personal, icon_brand FROM inv_tab_brand"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAInv_tab_brand
        '
        Me.DAInv_tab_brand.SelectCommand = Me.SqlSelectCommand1
        Me.DAInv_tab_brand.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_brand", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("complete_desc_brand", "complete_desc_brand"), New System.Data.Common.DataColumnMapping("abbreviation_desc_brand", "abbreviation_desc_brand"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("tel", "tel"), New System.Data.Common.DataColumnMapping("conect_personal", "conect_personal"), New System.Data.Common.DataColumnMapping("icon_brand", "icon_brand")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT style, desc_style, remark, image_remark FROM inv_tab_style"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAInv_tab_style
        '
        Me.DAInv_tab_style.SelectCommand = Me.SqlSelectCommand2
        Me.DAInv_tab_style.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_style", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("desc_style", "desc_style"), New System.Data.Common.DataColumnMapping("cod_fees_balance", "cod_fees_balance"), New System.Data.Common.DataColumnMapping("cod_fees_tire", "cod_fees_tire"), New System.Data.Common.DataColumnMapping("cod_fees_disposal", "cod_fees_disposal"), New System.Data.Common.DataColumnMapping("cod_valvestem", "cod_valvestem"), New System.Data.Common.DataColumnMapping("cod_roadhazard", "cod_roadhazard"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("image_remark", "image_remark")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT DISTINCT treadwear FROM inv_tab_line WHERE (treadwear IS NOT NULL)"
        Me.SqlSelectCommand3.Connection = Me.CnnTemp
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO Inv_Treadwear(TreadwearCod) VALUES (@TreadwearCod); SELECT TreadwearI" & _
        "d, TreadwearCod FROM Inv_Treadwear WHERE (TreadwearId = @@IDENTITY)"
        Me.SqlInsertCommand3.Connection = Me.CnnTemp
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TreadwearCod", System.Data.SqlDbType.VarChar, 10, "TreadwearCod"))
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE Inv_Treadwear SET TreadwearCod = @TreadwearCod WHERE (TreadwearId = @Origi" & _
        "nal_TreadwearId) AND (TreadwearCod = @Original_TreadwearCod); SELECT TreadwearId" & _
        ", TreadwearCod FROM Inv_Treadwear WHERE (TreadwearId = @TreadwearId)"
        Me.SqlUpdateCommand3.Connection = Me.CnnTemp
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TreadwearCod", System.Data.SqlDbType.VarChar, 10, "TreadwearCod"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TreadwearId", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TreadwearId", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TreadwearCod", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TreadwearCod", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TreadwearId", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TreadwearId", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM Inv_Treadwear WHERE (TreadwearId = @Original_TreadwearId) AND (Treadw" & _
        "earCod = @Original_TreadwearCod)"
        Me.SqlDeleteCommand3.Connection = Me.CnnTemp
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TreadwearId", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TreadwearId", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TreadwearCod", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TreadwearCod", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAInv_Treadwear
        '
        Me.DAInv_Treadwear.DeleteCommand = Me.SqlDeleteCommand3
        Me.DAInv_Treadwear.InsertCommand = Me.SqlInsertCommand3
        Me.DAInv_Treadwear.SelectCommand = Me.SqlSelectCommand3
        Me.DAInv_Treadwear.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_Treadwear", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("TreadwearId", "TreadwearId"), New System.Data.Common.DataColumnMapping("TreadwearCod", "TreadwearCod")})})
        Me.DAInv_Treadwear.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT DISTINCT traction FROM inv_tab_line WHERE (traction IS NOT NULL)"
        Me.SqlSelectCommand4.Connection = Me.CnnTemp
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO Inv_Traction(TractionCod) VALUES (@TractionCod); SELECT TractionId, T" & _
        "ractionCod FROM Inv_Traction WHERE (TractionId = @@IDENTITY)"
        Me.SqlInsertCommand4.Connection = Me.CnnTemp
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TractionCod", System.Data.SqlDbType.VarChar, 2, "TractionCod"))
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE Inv_Traction SET TractionCod = @TractionCod WHERE (TractionId = @Original_" & _
        "TractionId) AND (TractionCod = @Original_TractionCod); SELECT TractionId, Tracti" & _
        "onCod FROM Inv_Traction WHERE (TractionId = @TractionId)"
        Me.SqlUpdateCommand4.Connection = Me.CnnTemp
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TractionCod", System.Data.SqlDbType.VarChar, 2, "TractionCod"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TractionId", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TractionId", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TractionCod", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TractionCod", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TractionId", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TractionId", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM Inv_Traction WHERE (TractionId = @Original_TractionId) AND (TractionC" & _
        "od = @Original_TractionCod)"
        Me.SqlDeleteCommand4.Connection = Me.CnnTemp
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TractionId", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TractionId", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TractionCod", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TractionCod", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAInv_Traction
        '
        Me.DAInv_Traction.DeleteCommand = Me.SqlDeleteCommand4
        Me.DAInv_Traction.InsertCommand = Me.SqlInsertCommand4
        Me.DAInv_Traction.SelectCommand = Me.SqlSelectCommand4
        Me.DAInv_Traction.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_Traction", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("TractionId", "TractionId"), New System.Data.Common.DataColumnMapping("TractionCod", "TractionCod")})})
        Me.DAInv_Traction.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT DISTINCT temperature FROM inv_tab_line WHERE (temperature IS NOT NULL)"
        Me.SqlSelectCommand5.Connection = Me.CnnTemp
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO Inv_Temperature(TemperatureCod) VALUES (@TemperatureCod); SELECT Temp" & _
        "eratureId, TemperatureCod FROM Inv_Temperature WHERE (TemperatureId = @@IDENTITY" & _
        ")"
        Me.SqlInsertCommand5.Connection = Me.CnnTemp
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TemperatureCod", System.Data.SqlDbType.VarChar, 1, "TemperatureCod"))
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = "UPDATE Inv_Temperature SET TemperatureCod = @TemperatureCod WHERE (TemperatureId " & _
        "= @Original_TemperatureId) AND (TemperatureCod = @Original_TemperatureCod); SELE" & _
        "CT TemperatureId, TemperatureCod FROM Inv_Temperature WHERE (TemperatureId = @Te" & _
        "mperatureId)"
        Me.SqlUpdateCommand5.Connection = Me.CnnTemp
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TemperatureCod", System.Data.SqlDbType.VarChar, 1, "TemperatureCod"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TemperatureId", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TemperatureId", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TemperatureCod", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TemperatureCod", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TemperatureId", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TemperatureId", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = "DELETE FROM Inv_Temperature WHERE (TemperatureId = @Original_TemperatureId) AND (" & _
        "TemperatureCod = @Original_TemperatureCod)"
        Me.SqlDeleteCommand5.Connection = Me.CnnTemp
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TemperatureId", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "TemperatureId", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TemperatureCod", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TemperatureCod", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAInv_Temperature
        '
        Me.DAInv_Temperature.DeleteCommand = Me.SqlDeleteCommand5
        Me.DAInv_Temperature.InsertCommand = Me.SqlInsertCommand5
        Me.DAInv_Temperature.SelectCommand = Me.SqlSelectCommand5
        Me.DAInv_Temperature.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_Temperature", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("TemperatureId", "TemperatureId"), New System.Data.Common.DataColumnMapping("TemperatureCod", "TemperatureCod")})})
        Me.DAInv_Temperature.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT DISTINCT limit_warranty FROM inv_tab_line WHERE (limit_warranty IS NOT NUL" & _
        "L)"
        Me.SqlSelectCommand6.Connection = Me.CnnTemp
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = "INSERT INTO Inv_LimitedWarranty(LimitedWarrantyCod) VALUES (@LimitedWarrantyCod);" & _
        " SELECT LimitedWarrantyId, LimitedWarrantyCod FROM Inv_LimitedWarranty WHERE (Li" & _
        "mitedWarrantyId = @@IDENTITY)"
        Me.SqlInsertCommand6.Connection = Me.CnnTemp
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@LimitedWarrantyCod", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "LimitedWarrantyCod", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlUpdateCommand6
        '
        Me.SqlUpdateCommand6.CommandText = "UPDATE Inv_LimitedWarranty SET LimitedWarrantyCod = @LimitedWarrantyCod WHERE (Li" & _
        "mitedWarrantyId = @Original_LimitedWarrantyId) AND (LimitedWarrantyCod = @Origin" & _
        "al_LimitedWarrantyCod); SELECT LimitedWarrantyId, LimitedWarrantyCod FROM Inv_Li" & _
        "mitedWarranty WHERE (LimitedWarrantyId = @LimitedWarrantyId)"
        Me.SqlUpdateCommand6.Connection = Me.CnnTemp
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@LimitedWarrantyCod", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "LimitedWarrantyCod", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_LimitedWarrantyId", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "LimitedWarrantyId", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_LimitedWarrantyCod", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "LimitedWarrantyCod", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@LimitedWarrantyId", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "LimitedWarrantyId", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlDeleteCommand6
        '
        Me.SqlDeleteCommand6.CommandText = "DELETE FROM Inv_LimitedWarranty WHERE (LimitedWarrantyId = @Original_LimitedWarra" & _
        "ntyId) AND (LimitedWarrantyCod = @Original_LimitedWarrantyCod)"
        Me.SqlDeleteCommand6.Connection = Me.CnnTemp
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_LimitedWarrantyId", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "LimitedWarrantyId", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_LimitedWarrantyCod", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "LimitedWarrantyCod", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAInv_LimitedWarranty
        '
        Me.DAInv_LimitedWarranty.DeleteCommand = Me.SqlDeleteCommand6
        Me.DAInv_LimitedWarranty.InsertCommand = Me.SqlInsertCommand6
        Me.DAInv_LimitedWarranty.SelectCommand = Me.SqlSelectCommand6
        Me.DAInv_LimitedWarranty.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_LimitedWarranty", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("LimitedWarrantyId", "LimitedWarrantyId"), New System.Data.Common.DataColumnMapping("LimitedWarrantyCod", "LimitedWarrantyCod")})})
        Me.DAInv_LimitedWarranty.UpdateCommand = Me.SqlUpdateCommand6
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT DISTINCT construction FROM inv_tab_line WHERE (construction IS NOT NULL)"
        Me.SqlSelectCommand7.Connection = Me.CnnTemp
        '
        'SqlInsertCommand7
        '
        Me.SqlInsertCommand7.CommandText = "INSERT INTO Inv_Construction(ConstructionDesc) VALUES (@ConstructionDesc); SELECT" & _
        " ConstructionId, ConstructionDesc FROM Inv_Construction WHERE (ConstructionId = " & _
        "@@IDENTITY)"
        Me.SqlInsertCommand7.Connection = Me.CnnTemp
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ConstructionDesc", System.Data.SqlDbType.VarChar, 30, "ConstructionDesc"))
        '
        'SqlUpdateCommand7
        '
        Me.SqlUpdateCommand7.CommandText = "UPDATE Inv_Construction SET ConstructionDesc = @ConstructionDesc WHERE (Construct" & _
        "ionId = @Original_ConstructionId) AND (ConstructionDesc = @Original_Construction" & _
        "Desc); SELECT ConstructionId, ConstructionDesc FROM Inv_Construction WHERE (Cons" & _
        "tructionId = @ConstructionId)"
        Me.SqlUpdateCommand7.Connection = Me.CnnTemp
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ConstructionDesc", System.Data.SqlDbType.VarChar, 30, "ConstructionDesc"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ConstructionId", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ConstructionId", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ConstructionDesc", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConstructionDesc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ConstructionId", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ConstructionId", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlDeleteCommand7
        '
        Me.SqlDeleteCommand7.CommandText = "DELETE FROM Inv_Construction WHERE (ConstructionId = @Original_ConstructionId) AN" & _
        "D (ConstructionDesc = @Original_ConstructionDesc)"
        Me.SqlDeleteCommand7.Connection = Me.CnnTemp
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ConstructionId", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ConstructionId", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ConstructionDesc", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConstructionDesc", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAInv_Construction
        '
        Me.DAInv_Construction.DeleteCommand = Me.SqlDeleteCommand7
        Me.DAInv_Construction.InsertCommand = Me.SqlInsertCommand7
        Me.DAInv_Construction.SelectCommand = Me.SqlSelectCommand7
        Me.DAInv_Construction.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_Construction", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ConstructionId", "ConstructionId"), New System.Data.Common.DataColumnMapping("ConstructionDesc", "ConstructionDesc")})})
        Me.DAInv_Construction.UpdateCommand = Me.SqlUpdateCommand7
        '
        'DAPicture
        '
        Me.DAPicture.DeleteCommand = Me.SqlDeleteCommand8
        Me.DAPicture.InsertCommand = Me.SqlInsertCommand8
        Me.DAPicture.SelectCommand = Me.SqlSelectCommand8
        Me.DAPicture.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_line", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("line", "line"), New System.Data.Common.DataColumnMapping("image_remark", "image_remark")})})
        Me.DAPicture.UpdateCommand = Me.SqlUpdateCommand8
        '
        'SqlDeleteCommand8
        '
        Me.SqlDeleteCommand8.CommandText = "DELETE FROM inv_tab_line WHERE (line = @Original_line)"
        Me.SqlDeleteCommand8.Connection = Me.CnnTemp
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_line", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "line", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand8
        '
        Me.SqlInsertCommand8.CommandText = "INSERT INTO inv_tab_line(line, image_remark) VALUES (@line, @image_remark); SELEC" & _
        "T line, image_remark FROM inv_tab_line WHERE (line = @line)"
        Me.SqlInsertCommand8.Connection = Me.CnnTemp
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@line", System.Data.SqlDbType.VarChar, 30, "line"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@image_remark", System.Data.SqlDbType.VarBinary, 2147483647, "image_remark"))
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT line, image_remark FROM inv_tab_line WHERE (line = @line)"
        Me.SqlSelectCommand8.Connection = Me.CnnTemp
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@line", System.Data.SqlDbType.VarChar, 30, "line"))
        '
        'SqlUpdateCommand8
        '
        Me.SqlUpdateCommand8.CommandText = "UPDATE inv_tab_line SET line = @line, image_remark = @image_remark WHERE (line = " & _
        "@Original_line); SELECT line, image_remark FROM inv_tab_line WHERE (line = @line" & _
        ")"
        Me.SqlUpdateCommand8.Connection = Me.CnnTemp
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@line", System.Data.SqlDbType.VarChar, 30, "line"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@image_remark", System.Data.SqlDbType.VarBinary, 2147483647, "image_remark"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_line", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "line", System.Data.DataRowVersion.Original, Nothing))
        '
        'DsPicture1
        '
        Me.DsPicture1.DataSetName = "DSPicture"
        Me.DsPicture1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'FrmInv_line
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(571, 351)
        Me.Controls.Add(Me.PnlKartAmvalField)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel9)
        Me.Name = "FrmInv_line"
        Me.Text = "Product Line Information"
        Me.PnlSearch.ResumeLayout(False)
        Me.PnlKartAmvalField.ResumeLayout(False)
        CType(Me.DsFrmInv_line1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(Me.UiContextMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1.EditContextMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPicture1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmInv_line_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        Me.CnnTemp.ConnectionString = PConnectionString

        myClsCommon = New CommonClass.AllStore

        PnlSearchHeight = PnlSearch.Height

        UiContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.True

        Call FillDataSets()
        TxtLine.MaxLength = LenLine

        If LineTempVar.Trim.Length = 0 Then
            Call PFirstRecord(False)
        Else
            Line1.Text = LineTempVar
            Call FillFields(Line1.Text)
        End If
        If QuickAddFlag Then
            Call PAddNew()
        Else
            Call AfterSaveOrCancel()
        End If
        Line1.Focus()
    End Sub
    Private Sub FillDataSets(Optional ByVal SaveComboSelectedValueFlag As Boolean = False)
        Dim Cmbcod_brandVar As String
        Dim CmbConstructionVar As String
        Dim CmbLimit_warrantyVar As String
        Dim CmbStyleVar As String
        Dim CmbTemperatureVar As String
        Dim CmbTractionVar As String
        Dim CmbTreadwearVar As String
        If SaveComboSelectedValueFlag Then
            Cmbcod_brandVar = Cmbcod_brand.SelectedValue
            CmbConstructionVar = CmbConstruction.SelectedValue
            CmbLimit_warrantyVar = CmbLimit_warranty.SelectedValue
            CmbStyleVar = CmbStyle.SelectedValue
            CmbTemperatureVar = CmbTemperature.SelectedValue
            CmbTractionVar = CmbTraction.SelectedValue
            CmbTreadwearVar = CmbTreadwear.SelectedValue
        End If
        DsFrmInv_line1.inv_tab_brand.Clear()
        DAInv_tab_brand.Fill(DsFrmInv_line1, "inv_tab_brand")
        If DsFrmInv_line1.inv_tab_brand.Rows.Count < 1 Then
            MsgFar("Please Fill The Brand Table")
            Call DisableAllComponet(Me)
            Exit Sub
        End If

        DsFrmInv_line1.inv_tab_style.Clear()
        DAInv_tab_style.Fill(DsFrmInv_line1, "inv_tab_style")
        If DsFrmInv_line1.inv_tab_style.Rows.Count < 1 Then
            MsgFar("Please Fill The Style Table")
            Call DisableAllComponet(Me)
            Exit Sub
        End If

        DsFrmInv_line1.Inv_Construction.Clear()
        DAInv_Construction.Fill(DsFrmInv_line1, "Inv_Construction")

        DsFrmInv_line1.Inv_LimitedWarranty.Clear()
        DAInv_LimitedWarranty.Fill(DsFrmInv_line1, "Inv_LimitedWarranty")

        DsFrmInv_line1.Inv_Temperature.Clear()
        DAInv_Temperature.Fill(DsFrmInv_line1, "Inv_Temperature")

        DsFrmInv_line1.Inv_Traction.Clear()
        DAInv_Traction.Fill(DsFrmInv_line1, "Inv_Traction")

        DsFrmInv_line1.Inv_Treadwear.Clear()
        DAInv_Treadwear.Fill(DsFrmInv_line1, "Inv_Treadwear")
        If SaveComboSelectedValueFlag Then
            Cmbcod_brand.SelectedValue = Cmbcod_brandVar
            CmbConstruction.SelectedValue = CmbConstructionVar
            CmbLimit_warranty.SelectedValue = CmbLimit_warrantyVar
            CmbStyle.SelectedValue = CmbStyleVar
            CmbTemperature.SelectedValue = CmbTemperatureVar
            CmbTraction.SelectedValue = CmbTractionVar
            CmbTreadwear.SelectedValue = CmbTreadwearVar
        End If
    End Sub
    Sub PAddNew()
        Status = MainModule.WorkStates.AddNew

        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        Call EnableField(True)
        LineTempVar = Line1.Text
        Line1.Text = ""
        Call ClearField()

        TxtLine.Focus()

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

        ChkInsertToAllStore.Visible = True
        ChkInsertToAllStore.Checked = True
    End Sub
    Sub PEdit()
        Status = MainModule.WorkStates.Edit

        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        EnableField(True)
        LineTempVar = Line1.Text
        TxtLine.Focus()

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
                CmdDelete.Parameters("@Line").Value = Line1.Line_Code
                CmdDelete.ExecuteNonQuery()
                LineTempVar = ""
                Call PNextRecord(False)
                If LineTempVar.Trim.Length = 0 Then
                    Call PPreviousRecord(False)
                    If LineTempVar.Trim.Length = 0 Then
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
            Line1.Focus()
        End If
        Status = MainModule.WorkStates._ReadOnly
    End Sub
    Sub PSave()
        Dim ChangeOK As Boolean = False
        Select Case Status
            Case MainModule.WorkStates.AddNew
                LineTempVar = PInsert()
                ChangeOK = IIf(LineTempVar.Trim.Length = 0, False, True)
            Case MainModule.WorkStates.Edit
                Dim thisrow As DataRow, ThisPosition As Integer
                ChangeOK = PUpdate(LineTempVar)
        End Select
        If ChangeOK Then
            Call AfterSaveOrCancel()
            'If Status = mainmodule.WorkStates.AddNew Then
            '    Call PAddNew()
            'Else
            Status = MainModule.WorkStates._ReadOnly
            'PnlSearch.Visible = True
            Call ShowFilterProcPanel()

            Line1.Text = LineTempVar
            Line1.Focus()
        End If
    End Sub
    Sub PCancel()
        Status = MainModule.WorkStates._ReadOnly
        'PnlSearch.Visible = True
        Call ShowFilterProcPanel()

        Line1.Text = LineTempVar
        Call FillFields(Line1.Text)
        Call AfterSaveOrCancel()
        Line1.Focus()
    End Sub
    Sub AfterSaveOrCancel()
        MSave.Enabled = False
        BtnSave.Enabled = False
        MCancel.Enabled = False
        BtnCancel.Enabled = False
        BtnNew.Enabled = True
        MAddNew.Enabled = True
        If TxtLine.Text.Trim.Length = 0 Then
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
        ChkInsertToAllStore.Visible = False
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
    Private Sub TxtLine_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLine.TextChanged, TxtBenefits.TextChanged, txtDry_Traction.TextChanged, TxtFeatures.TextChanged, txthandling.TextChanged, txtnud_traction.TextChanged, txtoverall_score.TextChanged, txtquiet_ride.TextChanged, txtRide_Comfort.TextChanged, txttread_life.TextChanged, txtwet_traction.TextChanged, txtwinter_traction.TextChanged, Cmbcod_brand.SelectedIndexChanged, CmbConstruction.TextChanged, CmbLimit_warranty.TextChanged, CmbStyle.SelectedIndexChanged, CmbTemperature.TextChanged, CmbTraction.TextChanged, CmbTreadwear.TextChanged
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
            If TxtLine.Text.Trim.Length > 0 And Cmbcod_brand.Text.Trim.Length > 0 And CmbStyle.Text.Trim.Length > 0 Then
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
            Dim TXTSearchLineTemp As String
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            Select Case LineOrderFieldName.ToUpper.Trim
                Case "Line".ToUpper
                    CmdGeneral.CommandText = "SELECT Top 1 Line from inv_tab_Line Order BY " & LineOrderVar1 & " ASC"
                Case "cod_brand".ToUpper
                    CmdGeneral.CommandText = "SELECT Top 1 Line from inv_tab_Line Order BY " & LineOrderVar1 & " ASC , " & LineOrderVar2 & " ASC "
                Case "style".ToUpper
                    CmdGeneral.CommandText = "SELECT Top 1 Line from inv_tab_Line Order BY " & LineOrderVar1 & " ASC , " & LineOrderVar2 & " ASC "
            End Select
            TXTSearchLineTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.Connection.Close()
            If IsNothing(TXTSearchLineTemp) Then
                TXTSearchLineTemp = ""
            End If
            If TXTSearchLineTemp = Line1.Text Or TXTSearchLineTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the First record of this table.")
            Else
                Line1.Text = TXTSearchLineTemp
                Call FillFields(Line1.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PPreviousRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchLineTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Select Case LineOrderFieldName.ToUpper.Trim
            Case "Line".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Line from inv_tab_Line where Line<" & Qt(TxtLine.Text) & " Order BY " & LineOrderVar1 & " DESC"
            Case "cod_brand".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Line from inv_tab_Line where (CAST(cod_brand AS char(3)))+Line<" & Qt(InsertSpaceAfter(Cmbcod_brand.SelectedValue, 3) & InsertSpaceAfter(TxtLine.Text, TxtLine.MaxLength)) & " Order BY " & LineOrderVar1 & " DESC , " & LineOrderVar2 & " DESC"
            Case "style".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Line from inv_tab_Line where (CAST(style AS char(3)))+Line<" & Qt(InsertSpaceAfter(CmbStyle.SelectedValue, 3) & InsertSpaceAfter(TxtLine.Text, TxtLine.MaxLength)) & " Order BY " & LineOrderVar1 & " DESC , " & LineOrderVar2 & " DESC"
        End Select
        TXTSearchLineTemp = CmdGeneral.ExecuteScalar()
        CmdGeneral.Connection.Close()
        If IsNothing(TXTSearchLineTemp) Then
            TXTSearchLineTemp = ""
        End If
        If TXTSearchLineTemp = Line1.Text Or TXTSearchLineTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the First record of this table.")
        Else
            Line1.Text = TXTSearchLineTemp
            LineTempVar = TXTSearchLineTemp
            Call FillFields(Line1.Text)
        End If
    End Sub
    Private Sub PNextRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchLineTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Select Case LineOrderFieldName.ToUpper.Trim
            Case "Line".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Line from inv_tab_Line where Line>" & Qt(TxtLine.Text) & " Order BY " & LineOrderVar1 & " ASC"
            Case "cod_brand".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Line from inv_tab_Line where (CAST(cod_brand AS char(3)))+Line>" & Qt(InsertSpaceAfter(Cmbcod_brand.SelectedValue, 3) & InsertSpaceAfter(TxtLine.Text, TxtLine.MaxLength)) & " Order BY " & LineOrderVar1 & " ASC , " & LineOrderVar2 & " ASC"
            Case "style".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Line from inv_tab_Line where (CAST(style AS char(3)))+Line>" & Qt(InsertSpaceAfter(CmbStyle.SelectedValue, 3) & InsertSpaceAfter(TxtLine.Text, TxtLine.MaxLength)) & " Order BY " & LineOrderVar1 & " ASC , " & LineOrderVar2 & " ASC"
        End Select
        TXTSearchLineTemp = CmdGeneral.ExecuteScalar()
        CmdGeneral.Connection.Close()
        If IsNothing(TXTSearchLineTemp) Then
            TXTSearchLineTemp = ""
        End If
        If TXTSearchLineTemp = Line1.Text Or TXTSearchLineTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            Line1.Text = TXTSearchLineTemp
            LineTempVar = TXTSearchLineTemp
            Call FillFields(Line1.Text)
        End If
    End Sub
    Private Sub PLastRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Try
            Dim TXTSearchLineTemp As String
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            Select Case LineOrderFieldName.ToUpper.Trim
                Case "Line".ToUpper
                    CmdGeneral.CommandText = "SELECT Top 1 Line from inv_tab_Line Order BY " & LineOrderVar1 & " DESC"
                Case "cod_brand".ToUpper
                    CmdGeneral.CommandText = "SELECT Top 1 Line from inv_tab_Line Order BY " & LineOrderVar1 & " DESC , " & LineOrderVar2 & " DESC "
                Case "style".ToUpper
                    CmdGeneral.CommandText = "SELECT Top 1 Line from inv_tab_Line Order BY " & LineOrderVar1 & " DESC , " & LineOrderVar2 & " DESC "
            End Select
            TXTSearchLineTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.Connection.Close()
            If IsNothing(TXTSearchLineTemp) Then
                TXTSearchLineTemp = ""
            End If
            If TXTSearchLineTemp = Line1.Text Or TXTSearchLineTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the Last record of this table.")
            Else
                Line1.Text = TXTSearchLineTemp
                Call FillFields(Line1.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Line1_FindItemNo() Handles Line1.FindLineCode
        Call FillFields(Line1.Text)
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
            Line1.Focus()
        Else
            'GRDFWG.Height = GRDFWG.Height + PnlSearchHeight
        End If
    End Sub
    Private Sub FrmInv_line_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Line1.Text = ""
    End Sub
    Private Sub PPrintMasterInformation()
        'If Line1.text > 0 Then
        '    Dim Orpt As New RptInspectionMasterInformation
        '    DsFrmInspectionMaster1.Clear()
        '    DAInspectionMaster.SelectCommand.Parameters("@Line").Value = Line1.text
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
        'For Each Ctl As Control In Me.Controls
        '    If TypeOf (Ctl) Is TextBox Then
        '        Ctl.Enabled = instatus
        '    ElseIf TypeOf (Ctl) Is ComboBox Then
        '        Ctl.Enabled = instatus
        '    End If
        'Next
        If Status = MainModule.WorkStates.AddNew Then
            TxtLine.Enabled = instatus
        Else
            TxtLine.Enabled = False
        End If
        TxtBenefits.Enabled = instatus
        txtDry_Traction.Enabled = instatus
        TxtFeatures.Enabled = instatus
        txthandling.Enabled = instatus
        txtnud_traction.Enabled = instatus
        txtoverall_score.Enabled = instatus
        txtquiet_ride.Enabled = instatus
        txtRide_Comfort.Enabled = instatus
        txttread_life.Enabled = instatus
        txtwet_traction.Enabled = instatus
        txtwinter_traction.Enabled = instatus
        Cmbcod_brand.Enabled = instatus
        CmbConstruction.Enabled = instatus
        CmbLimit_warranty.Enabled = instatus
        CmbStyle.Enabled = instatus
        CmbTemperature.Enabled = instatus
        CmbTraction.Enabled = instatus
        CmbTreadwear.Enabled = instatus
    End Sub
    Friend Sub ClearField()
        'For Each Ctl As Control In Me.Controls
        '    If TypeOf (Ctl) Is TextBox Then
        '        Ctl.Text = ""
        '    ElseIf TypeOf (Ctl) Is ComboBox Then
        '        CType(Ctl, ComboBox).SelectedValue = 0
        '    End If
        'Next
        TxtLine.Text = ""
        TxtBenefits.Text = ""
        txtDry_Traction.Text = ""
        TxtFeatures.Text = ""
        txthandling.Text = ""
        txtnud_traction.Text = ""
        txtoverall_score.Text = ""
        txtquiet_ride.Text = ""
        txtRide_Comfort.Text = ""
        txttread_life.Text = ""
        txtwet_traction.Text = ""
        txtwinter_traction.Text = ""
        Try
            Cmbcod_brand.SelectedValue = "0"
            CmbStyle.SelectedValue = "0"
            CmbConstruction.Text = ""
            CmbLimit_warranty.Text = ""
            CmbTemperature.Text = ""
            CmbTraction.Text = ""
            CmbTreadwear.Text = ""
        Catch ex As Exception
        End Try
        PictureButton1.MyPicture = Nothing
        LineNoteVar = ""
    End Sub
    Friend Function PInsert() As String
        Dim thisrow As DataRow
        PInsert = ""
        Try
            With CmdInsert
                'If .Connection.State <> ConnectionState.Open Then
                '.Connection.Open()
                'End If
                .Parameters("@cod_brand").Value = ChkCombo(Cmbcod_brand.SelectedValue)
                .Parameters("@Style").Value = ChkCombo(CmbStyle.SelectedValue)
                .Parameters("@Line").Value = TxtLine.Text
                .Parameters("@Features").Value = TxtFeatures.Text
                .Parameters("@benefits").Value = TxtBenefits.Text
                .Parameters("@treadwear").Value = CmbTreadwear.Text
                .Parameters("@traction").Value = CmbTraction.Text
                .Parameters("@temperature").Value = CmbTemperature.Text
                .Parameters("@limit_warranty").Value = CmbLimit_warranty.Text
                .Parameters("@construction").Value = CmbConstruction.Text
                .Parameters("@remark").Value = LineNoteVar
                .Parameters("@image_remark").Value = IIf(IsNothing(PictureButton1.MyPicture), System.DBNull.Value, PictureButton1.MyPicture)
                .Parameters("@tread_life").Value = txttread_life.Text
                .Parameters("@wet_traction").Value = txtwet_traction.Text
                .Parameters("@quiet_ride").Value = txtquiet_ride.Text
                .Parameters("@handling").Value = txthandling.Text
                .Parameters("@winter_traction").Value = txtwinter_traction.Text
                .Parameters("@nud_traction").Value = txtnud_traction.Text
                .Parameters("@overall_score").Value = txtoverall_score.Text
                .Parameters("@dry_traction").Value = txtDry_Traction.Text
                .Parameters("@ride_comfort").Value = txtRide_Comfort.Text
                '.ExecuteNonQuery()
                myClsCommon.AllStoreCommand(CmdInsert, Not ChkInsertToAllStore.Checked, True)
                PInsert = TxtLine.Text
                '.Connection.Close()
            End With
        Catch ex As Exception
            MsgBox("Error In Save")
            PInsert = ""
        End Try
    End Function
    Friend Function PUpdate(ByVal ThisLine As String) As Boolean
        PUpdate = True
        Try
            With CmdUpdate
                If .Connection.State <> ConnectionState.Open Then
                    .Connection.Open()
                End If
                .Parameters("@Line").Value = TxtLine.Text
                .Parameters("@cod_brand").Value = ChkCombo(Cmbcod_brand.SelectedValue)
                .Parameters("@Style").Value = ChkCombo(CmbStyle.SelectedValue)
                .Parameters("@Features").Value = TxtFeatures.Text
                .Parameters("@benefits").Value = TxtBenefits.Text
                .Parameters("@treadwear").Value = CmbTreadwear.Text
                .Parameters("@traction").Value = CmbTraction.Text
                .Parameters("@temperature").Value = CmbTemperature.Text
                .Parameters("@limit_warranty").Value = CmbLimit_warranty.Text
                .Parameters("@construction").Value = CmbConstruction.Text
                .Parameters("@remark").Value = LineNoteVar
                .Parameters("@image_remark").Value = IIf(IsNothing(PictureButton1.MyPicture), System.DBNull.Value, PictureButton1.MyPicture)
                .Parameters("@tread_life").Value = txttread_life.Text
                .Parameters("@wet_traction").Value = txtwet_traction.Text
                .Parameters("@quiet_ride").Value = txtquiet_ride.Text
                .Parameters("@handling").Value = txthandling.Text
                .Parameters("@winter_traction").Value = txtwinter_traction.Text
                .Parameters("@nud_traction").Value = txtnud_traction.Text
                .Parameters("@overall_score").Value = txtoverall_score.Text
                .Parameters("@dry_traction").Value = txtDry_Traction.Text
                .Parameters("@ride_comfort").Value = txtRide_Comfort.Text
                .ExecuteNonQuery()
                .Connection.Close()
            End With

            Call SavePictureInDataBase()

        Catch ex As Exception
            MsgBox("Error In Save")
            PUpdate = False
        End Try
    End Function
    Friend Function FillFields(ByVal ThisLine As String) As Boolean
        FillFields = False
        If ThisLine.Trim.Length = 0 Then
            Exit Function
        End If
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT * " _
                      & " FROM inv_tab_Line " _
                      & "  where inv_tab_Line.Line = " & Qt(ThisLine)
        SQLReader = CmdGeneral.ExecuteReader
        If SQLReader.HasRows Then
            SQLReader.Read()
            TxtLine.Text = Trim(SQLReader.Item("Line") & "")
            Cmbcod_brand.SelectedValue = Trim(SQLReader.Item("Cod_Brand") & "")
            CmbStyle.SelectedValue = Trim(SQLReader.Item("Style") & "")
            TxtFeatures.Text = Trim(SQLReader.Item("Features") & "")
            TxtBenefits.Text = Trim(SQLReader.Item("benefits") & "")
            CmbTreadwear.Text = Trim(SQLReader.Item("treadwear") & "")
            CmbTraction.Text = Trim(SQLReader.Item("traction") & "")
            CmbTemperature.Text = Trim(SQLReader.Item("temperature") & "")
            CmbLimit_warranty.Text = Trim(SQLReader.Item("limit_warranty") & "")
            CmbConstruction.Text = Trim(SQLReader.Item("construction") & "")
            CmbLimit_warranty.Text = Trim(SQLReader.Item("limit_warranty") & "")
            txttread_life.Text = Trim(SQLReader.Item("tread_life") & "")
            txtwet_traction.Text = Trim(SQLReader.Item("wet_traction") & "")
            txtquiet_ride.Text = Trim(SQLReader.Item("quiet_ride") & "")
            txthandling.Text = Trim(SQLReader.Item("handling") & "")
            txtwinter_traction.Text = Trim(SQLReader.Item("winter_traction") & "")
            txtnud_traction.Text = Trim(SQLReader.Item("nud_traction") & "")
            txtoverall_score.Text = Trim(SQLReader.Item("overall_score") & "")
            txtDry_Traction.Text = Trim(SQLReader.Item("dry_traction") & "")
            txtRide_Comfort.Text = Trim(SQLReader.Item("ride_comfort") & "")
            LineNoteVar = Trim(SQLReader.Item("remark") & "")
            Try
                PictureButton1.MyPicture = SQLReader.Item("image_remark")
            Catch ex As Exception
            End Try
            '''''''''''''''''''''''''''''''''''''''
            FillFields = True
        Else
            Call ClearField()
        End If
        SQLReader.Close()
        CmdGeneral.Connection.Close()
    End Function
    Private Sub FillOtherFields()
        If TxtLine.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT * from inv_tab_Line where Line=" & TxtLine.Text '& " Order by "
        SQLReader = CmdGeneral.ExecuteReader
        If SQLReader.HasRows Then
            SQLReader.Read()
            'TxtAmount_price1.Text = Trim(SQLReader.Item("") & "")
        Else
            'TxtAmount_price1.Text = ""
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
    Private Sub BtnNotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNotes.Click
        Dim MyFrmItemComments As New CommonClass.FrmItemComments
        MyFrmItemComments.TxtComments.Text = LineNoteVar & ""
        Call FitToScreen(BtnNotes, MyFrmItemComments)
        MyFrmItemComments.TxtComments.MaxLength = 300
        MyFrmItemComments.ThisFormStatus = Status
        MyFrmItemComments.ShowDialog()
        LineNoteVar = MyFrmItemComments.TxtCommentvar
        Call SaveButtonControl()
    End Sub
    Private Sub UiContextMenu1_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles UiContextMenu1.CommandClick
        UiContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UiContextMenu1.Commands(1).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UiContextMenu1.Commands(2).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UiContextMenu1.Commands(e.Command.Key).Checked() = Janus.Windows.UI.InheritableBoolean.True
        Select Case e.Command.Key.ToUpper
            Case "SORT1"
                LineOrderFieldName = "Line"
                LineOrderVar1 = "Line"
                LineOrderVar2 = ""
            Case "SORT2"
                LineOrderFieldName = "Cod_Brand"
                LineOrderVar1 = "Cod_Brand"
                LineOrderVar2 = "Line"
            Case "SORT3"
                LineOrderFieldName = "Style"
                LineOrderVar1 = "Style"
                LineOrderVar2 = "Line"
        End Select
    End Sub
    Private Sub PictureButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureButton1.Click
        PictureButton1.status = Status
        Call SaveButtonControl()
    End Sub
    Private Sub SavePictureInDataBase()
        PictureButton1.SavePicture(Cnn, "inv_tab_line", "image_remark", "WHERE Line=" & Qt(TxtLine.Text))
    End Sub
    Private Sub FrmInv_line_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If Status = MainModule.WorkStates.AddNew Or Status = MainModule.WorkStates.Edit Then
            Call FillDataSets(True)
        End If
    End Sub
    Protected Overrides Sub OnActivated(ByVal e As System.EventArgs)
        If Status = MainModule.WorkStates.AddNew Or Status = MainModule.WorkStates.Edit Then
            Call FillDataSets(True)
        End If
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        Line1.BtnSearch_Click(sender, e)
    End Sub
End Class
