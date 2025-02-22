Imports CommonClass
Imports Janus.Windows.GridEX

Public Class FrmNermoodarSazmani
    Inherits CommonClass.FrmBase


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
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UiPanelManager1 As Janus.Windows.UI.Dock.UIPanelManager
    Friend WithEvents uiPanel0 As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents uiPanel0Container As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents uiPanel1 As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents uiPanel1Container As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents CmbTashkilat As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureButton1 As UCPicture.PictureButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DATas_Bas_Vahed As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmNermoodarSazmani1 As UCTashkilat.DSFrmNermoodarSazmani
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DATas_bas_tashkilat As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents PnlTashkilat As System.Windows.Forms.Panel
    Friend WithEvents PnlLeft As Janus.Windows.UI.Dock.UIPanelGroup
    Friend WithEvents PnlTree As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents PnlTreeContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents PnlPostTakhsisy As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents PnlPostTakhsisyContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents PnlRight As Janus.Windows.UI.Dock.UIPanelGroup
    Friend WithEvents PnlVahed As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents PnlVahedContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents PnlPostSazman As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents PnlPostSazmanContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents TreeVahed As System.Windows.Forms.TreeView
    Friend WithEvents CmbTashkilatOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents MnuGeneral As System.Windows.Forms.ContextMenu
    Friend WithEvents MnAdd As System.Windows.Forms.MenuItem
    Friend WithEvents MnUpdate As System.Windows.Forms.MenuItem
    Friend WithEvents MnDelet As System.Windows.Forms.MenuItem
    Friend WithEvents MnPost As System.Windows.Forms.MenuItem
    Friend WithEvents TxtTel As System.Windows.Forms.TextBox
    Friend WithEvents TxtMahalVahed As System.Windows.Forms.TextBox
    Friend WithEvents TxtOnvanVahed As System.Windows.Forms.TextBox
    Friend WithEvents CommentVahed As UCCommentButton.CommentButton
    Friend WithEvents CmbRadeSazmani As System.Windows.Forms.ComboBox
    Friend WithEvents CmdCancelVahed As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdSaveVahed As Janus.Windows.EditControls.UIButton
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAtas_bas_radeh_sazemani As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAtas_tr_vahedha_mashaghel As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmdSavePost As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdCancelPost As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdInsertPost As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents UcCalEblagh As Calendar.UcCalendar
    Friend WithEvents UcCalTakhsis As Calendar.UcCalendar
    Friend WithEvents LblOnvanPost As System.Windows.Forms.TextBox
    Friend WithEvents LblVahedShoghl As System.Windows.Forms.TextBox
    Friend WithEvents LblVahedPost As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtOnvanPost As System.Windows.Forms.TextBox
    Friend WithEvents TxtShomarePost As System.Windows.Forms.TextBox
    Friend WithEvents CommentVazaef As UCCommentButton.CommentButton
    Friend WithEvents CommentPost As UCCommentButton.CommentButton
    Friend WithEvents BtnSabeghe As System.Windows.Forms.Button
    Friend WithEvents CommentShoghl As UCCommentButton.CommentButton
    Friend WithEvents Pnlpost As System.Windows.Forms.GroupBox
    Friend WithEvents GrdPost As Janus.Windows.GridEX.GridEX
    Friend WithEvents ChkActivePost As System.Windows.Forms.CheckBox
    Friend WithEvents LblCodPost As System.Windows.Forms.Label
    Friend WithEvents MnuPost As System.Windows.Forms.ContextMenu
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAtas_tr_takhsis_postsazemani As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents MnAddPost As System.Windows.Forms.MenuItem
    Friend WithEvents MnUpdatePost As System.Windows.Forms.MenuItem
    Friend WithEvents MnDeletPost As System.Windows.Forms.MenuItem
    Friend WithEvents MnTakhsis As System.Windows.Forms.MenuItem
    Friend WithEvents LblCodShoghl As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents MnuBtnVahed As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents BtnFindPerson As System.Windows.Forms.Button
    Friend WithEvents BtnFindVahed As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGeneral As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents BtnFindPost As System.Windows.Forms.Button
    Friend WithEvents CmdMahdoodeRade As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdMahdoodeVahed As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdEblaghInsert As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdEblaghCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdEblaghSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdTakhsisInsert As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdTakhsisCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdTakhsisSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents ShoghlName1 As UCshoghl.ShoghlName
    Friend WithEvents Employee_CodTakhsis As UCEmployee.Employee_Cod
    Friend WithEvents Employee_CodEblagh As UCEmployee.Employee_Cod
    Friend WithEvents PnlTakhsis As System.Windows.Forms.Panel
    Friend WithEvents PnlEblagh As System.Windows.Forms.Panel
    Friend WithEvents MnEblagh As System.Windows.Forms.MenuItem
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdDeletShoghl As Janus.Windows.EditControls.UIButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmNermoodarSazmani))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmdMahdoodeRade = New Janus.Windows.EditControls.UIButton
        Me.BtnFindPerson = New System.Windows.Forms.Button
        Me.BtnFindPost = New System.Windows.Forms.Button
        Me.CmdMahdoodeVahed = New Janus.Windows.EditControls.UIButton
        Me.Label53 = New System.Windows.Forms.Label
        Me.BtnFindVahed = New System.Windows.Forms.Button
        Me.PnlTashkilat = New System.Windows.Forms.Panel
        Me.CmbTashkilatOk = New Janus.Windows.EditControls.UIButton
        Me.CmbTashkilat = New System.Windows.Forms.ComboBox
        Me.DsFrmNermoodarSazmani1 = New UCTashkilat.DSFrmNermoodarSazmani
        Me.Label4 = New System.Windows.Forms.Label
        Me.UiPanelManager1 = New Janus.Windows.UI.Dock.UIPanelManager(Me.components)
        Me.PnlLeft = New Janus.Windows.UI.Dock.UIPanelGroup
        Me.PnlTree = New Janus.Windows.UI.Dock.UIPanel
        Me.PnlTreeContainer = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.TreeVahed = New System.Windows.Forms.TreeView
        Me.MnuGeneral = New System.Windows.Forms.ContextMenu
        Me.MnAdd = New System.Windows.Forms.MenuItem
        Me.MnUpdate = New System.Windows.Forms.MenuItem
        Me.MnDelet = New System.Windows.Forms.MenuItem
        Me.MnPost = New System.Windows.Forms.MenuItem
        Me.PnlPostTakhsisy = New Janus.Windows.UI.Dock.UIPanel
        Me.PnlPostTakhsisyContainer = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.PnlTakhsis = New System.Windows.Forms.Panel
        Me.Employee_CodTakhsis = New UCEmployee.Employee_Cod
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Label7 = New System.Windows.Forms.Label
        Me.CmdTakhsisInsert = New Janus.Windows.EditControls.UIButton
        Me.CmdTakhsisCancel = New Janus.Windows.EditControls.UIButton
        Me.CmdTakhsisSave = New Janus.Windows.EditControls.UIButton
        Me.UcCalTakhsis = New Calendar.UcCalendar
        Me.Label11 = New System.Windows.Forms.Label
        Me.PnlEblagh = New System.Windows.Forms.Panel
        Me.Employee_CodEblagh = New UCEmployee.Employee_Cod
        Me.CmdEblaghInsert = New Janus.Windows.EditControls.UIButton
        Me.CmdEblaghCancel = New Janus.Windows.EditControls.UIButton
        Me.CmdEblaghSave = New Janus.Windows.EditControls.UIButton
        Me.UcCalEblagh = New Calendar.UcCalendar
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.LblCodShoghl = New System.Windows.Forms.Label
        Me.BtnSabeghe = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.CommentShoghl = New UCCommentButton.CommentButton
        Me.LblOnvanPost = New System.Windows.Forms.TextBox
        Me.LblVahedShoghl = New System.Windows.Forms.TextBox
        Me.PnlRight = New Janus.Windows.UI.Dock.UIPanelGroup
        Me.PnlVahed = New Janus.Windows.UI.Dock.UIPanel
        Me.PnlVahedContainer = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.CmdSaveVahed = New Janus.Windows.EditControls.UIButton
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.CmbRadeSazmani = New System.Windows.Forms.ComboBox
        Me.TxtTel = New System.Windows.Forms.TextBox
        Me.TxtMahalVahed = New System.Windows.Forms.TextBox
        Me.TxtOnvanVahed = New System.Windows.Forms.TextBox
        Me.CommentVahed = New UCCommentButton.CommentButton
        Me.PictureButton1 = New UCPicture.PictureButton
        Me.CmdCancelVahed = New Janus.Windows.EditControls.UIButton
        Me.PnlPostSazman = New Janus.Windows.UI.Dock.UIPanel
        Me.PnlPostSazmanContainer = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.Pnlpost = New System.Windows.Forms.GroupBox
        Me.ShoghlName1 = New UCShoghl.ShoghlName
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.LblCodPost = New System.Windows.Forms.Label
        Me.ChkActivePost = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtOnvanPost = New System.Windows.Forms.TextBox
        Me.TxtShomarePost = New System.Windows.Forms.TextBox
        Me.CommentVazaef = New UCCommentButton.CommentButton
        Me.CommentPost = New UCCommentButton.CommentButton
        Me.CmdInsertPost = New Janus.Windows.EditControls.UIButton
        Me.CmdCancelPost = New Janus.Windows.EditControls.UIButton
        Me.CmdSavePost = New Janus.Windows.EditControls.UIButton
        Me.Label13 = New System.Windows.Forms.Label
        Me.GrdPost = New Janus.Windows.GridEX.GridEX
        Me.MnuPost = New System.Windows.Forms.ContextMenu
        Me.MnAddPost = New System.Windows.Forms.MenuItem
        Me.MnUpdatePost = New System.Windows.Forms.MenuItem
        Me.MnDeletPost = New System.Windows.Forms.MenuItem
        Me.MnTakhsis = New System.Windows.Forms.MenuItem
        Me.MnEblagh = New System.Windows.Forms.MenuItem
        Me.LblVahedPost = New System.Windows.Forms.TextBox
        Me.uiPanel0 = New Janus.Windows.UI.Dock.UIPanel
        Me.uiPanel0Container = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.uiPanel1 = New Janus.Windows.UI.Dock.UIPanel
        Me.uiPanel1Container = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DATas_Bas_Vahed = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DATas_bas_tashkilat = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAtas_bas_radeh_sazemani = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAtas_tr_vahedha_mashaghel = New System.Data.SqlClient.SqlDataAdapter
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAtas_tr_takhsis_postsazemani = New System.Data.SqlClient.SqlDataAdapter
        Me.MnuBtnVahed = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DAGeneral = New System.Data.SqlClient.SqlDataAdapter
        Me.CmdDeletShoghl = New Janus.Windows.EditControls.UIButton
        Me.Panel9.SuspendLayout()
        Me.PnlTashkilat.SuspendLayout()
        CType(Me.DsFrmNermoodarSazmani1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiPanelManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PnlLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlLeft.SuspendLayout()
        CType(Me.PnlTree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTree.SuspendLayout()
        Me.PnlTreeContainer.SuspendLayout()
        CType(Me.PnlPostTakhsisy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlPostTakhsisy.SuspendLayout()
        Me.PnlPostTakhsisyContainer.SuspendLayout()
        Me.PnlTakhsis.SuspendLayout()
        Me.PnlEblagh.SuspendLayout()
        CType(Me.PnlRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlRight.SuspendLayout()
        CType(Me.PnlVahed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlVahed.SuspendLayout()
        Me.PnlVahedContainer.SuspendLayout()
        CType(Me.PnlPostSazman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlPostSazman.SuspendLayout()
        Me.PnlPostSazmanContainer.SuspendLayout()
        Me.Pnlpost.SuspendLayout()
        CType(Me.GrdPost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uiPanel0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uiPanel0.SuspendLayout()
        CType(Me.uiPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uiPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Window
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label19)
        Me.Panel9.Controls.Add(Me.Label18)
        Me.Panel9.Controls.Add(Me.Label2)
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Controls.Add(Me.CmdMahdoodeRade)
        Me.Panel9.Controls.Add(Me.BtnFindPerson)
        Me.Panel9.Controls.Add(Me.BtnFindPost)
        Me.Panel9.Controls.Add(Me.CmdMahdoodeVahed)
        Me.Panel9.Controls.Add(Me.Label53)
        Me.Panel9.Controls.Add(Me.BtnFindVahed)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(758, 64)
        Me.Panel9.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(483, 39)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(123, 15)
        Me.Label19.TabIndex = 206
        Me.Label19.Text = "«‰ Œ«» „ÕœÊœ —œÂ ”«“„«‰Ì"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(608, 39)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(132, 15)
        Me.Label18.TabIndex = 205
        Me.Label18.Text = "«‰ Œ«» „ÕœÊœ Ê«Õœ ”«“„«‰Ì"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(123, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 15)
        Me.Label2.TabIndex = 204
        Me.Label2.Text = "Ã” ÃÊÌ Ê«Õœ ”«“„«‰Ì"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(238, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 14)
        Me.Label1.TabIndex = 203
        Me.Label1.Text = "Ã” ÃÊÌ Å” Â«Ì ”«“„«‰Ì"
        '
        'CmdMahdoodeRade
        '
        Me.CmdMahdoodeRade.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.DropDownButton
        Me.CmdMahdoodeRade.Image = CType(resources.GetObject("CmdMahdoodeRade.Image"), System.Drawing.Image)
        Me.CmdMahdoodeRade.ImageSize = New System.Drawing.Size(24, 24)
        Me.CmdMahdoodeRade.Location = New System.Drawing.Point(526, 9)
        Me.CmdMahdoodeRade.Name = "CmdMahdoodeRade"
        Me.CmdMahdoodeRade.Size = New System.Drawing.Size(49, 27)
        Me.CmdMahdoodeRade.TabIndex = 202
        '
        'BtnFindPerson
        '
        Me.BtnFindPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFindPerson.Image = CType(resources.GetObject("BtnFindPerson.Image"), System.Drawing.Image)
        Me.BtnFindPerson.Location = New System.Drawing.Point(385, 9)
        Me.BtnFindPerson.Name = "BtnFindPerson"
        Me.BtnFindPerson.Size = New System.Drawing.Size(33, 27)
        Me.BtnFindPerson.TabIndex = 201
        '
        'BtnFindPost
        '
        Me.BtnFindPost.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFindPost.Image = CType(resources.GetObject("BtnFindPost.Image"), System.Drawing.Image)
        Me.BtnFindPost.Location = New System.Drawing.Point(285, 9)
        Me.BtnFindPost.Name = "BtnFindPost"
        Me.BtnFindPost.Size = New System.Drawing.Size(33, 27)
        Me.BtnFindPost.TabIndex = 200
        '
        'CmdMahdoodeVahed
        '
        Me.CmdMahdoodeVahed.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.DropDownButton
        Me.CmdMahdoodeVahed.Image = CType(resources.GetObject("CmdMahdoodeVahed.Image"), System.Drawing.Image)
        Me.CmdMahdoodeVahed.ImageSize = New System.Drawing.Size(24, 24)
        Me.CmdMahdoodeVahed.Location = New System.Drawing.Point(658, 9)
        Me.CmdMahdoodeVahed.Name = "CmdMahdoodeVahed"
        Me.CmdMahdoodeVahed.Size = New System.Drawing.Size(49, 27)
        Me.CmdMahdoodeVahed.TabIndex = 198
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(365, 39)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(78, 15)
        Me.Label53.TabIndex = 173
        Me.Label53.Text = "Ã” ÃÊÌ ›—œÌ"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnFindVahed
        '
        Me.BtnFindVahed.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFindVahed.Image = CType(resources.GetObject("BtnFindVahed.Image"), System.Drawing.Image)
        Me.BtnFindVahed.Location = New System.Drawing.Point(171, 8)
        Me.BtnFindVahed.Name = "BtnFindVahed"
        Me.BtnFindVahed.Size = New System.Drawing.Size(33, 27)
        Me.BtnFindVahed.TabIndex = 2
        '
        'PnlTashkilat
        '
        Me.PnlTashkilat.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlTashkilat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlTashkilat.Controls.Add(Me.CmbTashkilatOk)
        Me.PnlTashkilat.Controls.Add(Me.CmbTashkilat)
        Me.PnlTashkilat.Controls.Add(Me.Label4)
        Me.PnlTashkilat.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTashkilat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlTashkilat.Location = New System.Drawing.Point(0, 64)
        Me.PnlTashkilat.Name = "PnlTashkilat"
        Me.PnlTashkilat.Size = New System.Drawing.Size(758, 40)
        Me.PnlTashkilat.TabIndex = 4
        '
        'CmbTashkilatOk
        '
        Me.CmbTashkilatOk.Location = New System.Drawing.Point(232, 8)
        Me.CmbTashkilatOk.Name = "CmbTashkilatOk"
        Me.CmbTashkilatOk.Size = New System.Drawing.Size(40, 23)
        Me.CmbTashkilatOk.TabIndex = 1
        Me.CmbTashkilatOk.Text = " «ÌÌœ"
        '
        'CmbTashkilat
        '
        Me.CmbTashkilat.DataSource = Me.DsFrmNermoodarSazmani1.tas_bas_tashkilat
        Me.CmbTashkilat.DisplayMember = "desc_tashkilat"
        Me.CmbTashkilat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTashkilat.Location = New System.Drawing.Point(384, 8)
        Me.CmbTashkilat.Name = "CmbTashkilat"
        Me.CmbTashkilat.Size = New System.Drawing.Size(159, 21)
        Me.CmbTashkilat.TabIndex = 0
        Me.CmbTashkilat.ValueMember = "code_tashkilat"
        '
        'DsFrmNermoodarSazmani1
        '
        Me.DsFrmNermoodarSazmani1.DataSetName = "DSFrmNermoodarSazmani"
        Me.DsFrmNermoodarSazmani1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(560, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 12)
        Me.Label4.TabIndex = 188
        Me.Label4.Text = "⁄‰Ê«‰  ‘òÌ·« "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UiPanelManager1
        '
        Me.UiPanelManager1.ContainerControl = Me
        Me.PnlLeft.Id = New System.Guid("64f7ed22-8cbd-4540-af87-397d63a18c67")
        Me.PnlTree.Id = New System.Guid("ea08614c-8a5d-475a-b2ec-fcd5eb18fd00")
        Me.PnlLeft.Panels.Add(Me.PnlTree)
        Me.PnlPostTakhsisy.Id = New System.Guid("cf484e2b-c706-406e-bc3f-258f61fdca2a")
        Me.PnlLeft.Panels.Add(Me.PnlPostTakhsisy)
        Me.UiPanelManager1.Panels.Add(Me.PnlLeft)
        Me.PnlRight.Id = New System.Guid("b08d72ab-91ed-4125-979a-b02caa7c91b1")
        Me.PnlVahed.Id = New System.Guid("2a00fd93-ad3a-49dd-8c7c-53e5fe5d7eee")
        Me.PnlRight.Panels.Add(Me.PnlVahed)
        Me.PnlPostSazman.Id = New System.Guid("6d209d6e-a161-48d2-8b98-dde253bc3c5e")
        Me.PnlRight.Panels.Add(Me.PnlPostSazman)
        Me.UiPanelManager1.Panels.Add(Me.PnlRight)
        '
        'Design Time Panel Info:
        '
        Me.UiPanelManager1.BeginPanelInfo()
        Me.UiPanelManager1.AddDockPanelInfo(New System.Guid("64f7ed22-8cbd-4540-af87-397d63a18c67"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, Janus.Windows.UI.Dock.PanelDockStyle.Left, True, New System.Drawing.Size(445, 534), True)
        Me.UiPanelManager1.AddDockPanelInfo(New System.Guid("ea08614c-8a5d-475a-b2ec-fcd5eb18fd00"), New System.Guid("64f7ed22-8cbd-4540-af87-397d63a18c67"), 316, True)
        Me.UiPanelManager1.AddDockPanelInfo(New System.Guid("cf484e2b-c706-406e-bc3f-258f61fdca2a"), New System.Guid("64f7ed22-8cbd-4540-af87-397d63a18c67"), 214, True)
        Me.UiPanelManager1.AddDockPanelInfo(New System.Guid("b08d72ab-91ed-4125-979a-b02caa7c91b1"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, Janus.Windows.UI.Dock.PanelDockStyle.Right, True, New System.Drawing.Size(310, 534), True)
        Me.UiPanelManager1.AddDockPanelInfo(New System.Guid("2a00fd93-ad3a-49dd-8c7c-53e5fe5d7eee"), New System.Guid("b08d72ab-91ed-4125-979a-b02caa7c91b1"), 186, True)
        Me.UiPanelManager1.AddDockPanelInfo(New System.Guid("6d209d6e-a161-48d2-8b98-dde253bc3c5e"), New System.Guid("b08d72ab-91ed-4125-979a-b02caa7c91b1"), 360, True)
        Me.UiPanelManager1.EndPanelInfo()
        '
        'PnlLeft
        '
        Me.PnlLeft.CaptionVisible = Janus.Windows.UI.InheritableBoolean.False
        Me.PnlLeft.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PnlLeft.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlLeft.Location = New System.Drawing.Point(3, 107)
        Me.PnlLeft.Name = "PnlLeft"
        Me.PnlLeft.Size = New System.Drawing.Size(445, 534)
        Me.PnlLeft.StaticGroup = True
        Me.PnlLeft.TabIndex = 4
        '
        'PnlTree
        '
        Me.PnlTree.CaptionVisible = Janus.Windows.UI.InheritableBoolean.False
        Me.PnlTree.InnerContainer = Me.PnlTreeContainer
        Me.PnlTree.Location = New System.Drawing.Point(0, 0)
        Me.PnlTree.Name = "PnlTree"
        Me.PnlTree.Size = New System.Drawing.Size(441, 316)
        Me.PnlTree.TabIndex = 4
        Me.PnlTree.Text = "Panel 4"
        '
        'PnlTreeContainer
        '
        Me.PnlTreeContainer.Controls.Add(Me.TreeVahed)
        Me.PnlTreeContainer.Location = New System.Drawing.Point(1, 1)
        Me.PnlTreeContainer.Name = "PnlTreeContainer"
        Me.PnlTreeContainer.Size = New System.Drawing.Size(439, 314)
        Me.PnlTreeContainer.TabIndex = 0
        '
        'TreeVahed
        '
        Me.TreeVahed.BackColor = System.Drawing.SystemColors.Control
        Me.TreeVahed.ContextMenu = Me.MnuGeneral
        Me.TreeVahed.Cursor = System.Windows.Forms.Cursors.Default
        Me.TreeVahed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeVahed.ImageIndex = -1
        Me.TreeVahed.Location = New System.Drawing.Point(0, 0)
        Me.TreeVahed.Name = "TreeVahed"
        Me.TreeVahed.SelectedImageIndex = -1
        Me.TreeVahed.Size = New System.Drawing.Size(439, 314)
        Me.TreeVahed.TabIndex = 7
        '
        'MnuGeneral
        '
        Me.MnuGeneral.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnAdd, Me.MnUpdate, Me.MnDelet, Me.MnPost})
        Me.MnuGeneral.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'MnAdd
        '
        Me.MnAdd.Index = 0
        Me.MnAdd.Text = "«ÌÃ«œ"
        '
        'MnUpdate
        '
        Me.MnUpdate.Index = 1
        Me.MnUpdate.Text = "«’·«Õ"
        '
        'MnDelet
        '
        Me.MnDelet.Index = 2
        Me.MnDelet.Text = "Õ–›"
        '
        'MnPost
        '
        Me.MnPost.Index = 3
        Me.MnPost.Text = "Å” Â«"
        '
        'PnlPostTakhsisy
        '
        Me.PnlPostTakhsisy.InnerContainer = Me.PnlPostTakhsisyContainer
        Me.PnlPostTakhsisy.Location = New System.Drawing.Point(0, 320)
        Me.PnlPostTakhsisy.Name = "PnlPostTakhsisy"
        Me.PnlPostTakhsisy.Size = New System.Drawing.Size(441, 214)
        Me.PnlPostTakhsisy.TabIndex = 4
        Me.PnlPostTakhsisy.Text = "Å” Â«Ì  Œ’Ì’Ì"
        Me.PnlPostTakhsisy.TextAlignment = Janus.Windows.UI.Dock.PanelTextAlignment.Center
        '
        'PnlPostTakhsisyContainer
        '
        Me.PnlPostTakhsisyContainer.Controls.Add(Me.PnlTakhsis)
        Me.PnlPostTakhsisyContainer.Controls.Add(Me.PnlEblagh)
        Me.PnlPostTakhsisyContainer.Controls.Add(Me.BtnSabeghe)
        Me.PnlPostTakhsisyContainer.Controls.Add(Me.Label10)
        Me.PnlPostTakhsisyContainer.Controls.Add(Me.Label9)
        Me.PnlPostTakhsisyContainer.Controls.Add(Me.CommentShoghl)
        Me.PnlPostTakhsisyContainer.Controls.Add(Me.LblOnvanPost)
        Me.PnlPostTakhsisyContainer.Controls.Add(Me.LblVahedShoghl)
        Me.PnlPostTakhsisyContainer.Controls.Add(Me.CmdDeletShoghl)
        Me.PnlPostTakhsisyContainer.Controls.Add(Me.LblCodShoghl)
        Me.PnlPostTakhsisyContainer.Location = New System.Drawing.Point(1, 23)
        Me.PnlPostTakhsisyContainer.Name = "PnlPostTakhsisyContainer"
        Me.PnlPostTakhsisyContainer.Size = New System.Drawing.Size(439, 190)
        Me.PnlPostTakhsisyContainer.TabIndex = 0
        '
        'PnlTakhsis
        '
        Me.PnlTakhsis.Controls.Add(Me.Employee_CodTakhsis)
        Me.PnlTakhsis.Controls.Add(Me.Label7)
        Me.PnlTakhsis.Controls.Add(Me.CmdTakhsisInsert)
        Me.PnlTakhsis.Controls.Add(Me.CmdTakhsisCancel)
        Me.PnlTakhsis.Controls.Add(Me.CmdTakhsisSave)
        Me.PnlTakhsis.Controls.Add(Me.UcCalTakhsis)
        Me.PnlTakhsis.Controls.Add(Me.Label11)
        Me.PnlTakhsis.Enabled = False
        Me.PnlTakhsis.Location = New System.Drawing.Point(8, 8)
        Me.PnlTakhsis.Name = "PnlTakhsis"
        Me.PnlTakhsis.Size = New System.Drawing.Size(424, 56)
        Me.PnlTakhsis.TabIndex = 456
        '
        'Employee_CodTakhsis
        '
        Me.Employee_CodTakhsis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Employee_CodTakhsis.Code_Personal = CType(0, Short)
        Me.Employee_CodTakhsis.Connection = Me.Cnn
        Me.Employee_CodTakhsis.EmployeeCodLen = 10
        Me.Employee_CodTakhsis.Location = New System.Drawing.Point(0, 0)
        Me.Employee_CodTakhsis.Name = "Employee_CodTakhsis"
        Me.Employee_CodTakhsis.NotExitIfNotFound = False
        Me.Employee_CodTakhsis.ReleaseIfNotFoundEmployeeCod = False
        Me.Employee_CodTakhsis.ShowEmployeeName = False
        Me.Employee_CodTakhsis.Size = New System.Drawing.Size(344, 20)
        Me.Employee_CodTakhsis.TabIndex = 453
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=MILAD;packet size=4096;integrated security=SSPI;data source=milad;" & _
        "persist security info=False;initial catalog=banader_02"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(352, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 15)
        Me.Label7.TabIndex = 434
        Me.Label7.Text = "Å”   Œ’Ì’Ì"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdTakhsisInsert
        '
        Me.CmdTakhsisInsert.Image = CType(resources.GetObject("CmdTakhsisInsert.Image"), System.Drawing.Image)
        Me.CmdTakhsisInsert.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.CmdTakhsisInsert.Location = New System.Drawing.Point(200, 24)
        Me.CmdTakhsisInsert.Name = "CmdTakhsisInsert"
        Me.CmdTakhsisInsert.Size = New System.Drawing.Size(24, 23)
        Me.CmdTakhsisInsert.TabIndex = 449
        '
        'CmdTakhsisCancel
        '
        Me.CmdTakhsisCancel.Image = CType(resources.GetObject("CmdTakhsisCancel.Image"), System.Drawing.Image)
        Me.CmdTakhsisCancel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.CmdTakhsisCancel.Location = New System.Drawing.Point(168, 24)
        Me.CmdTakhsisCancel.Name = "CmdTakhsisCancel"
        Me.CmdTakhsisCancel.Size = New System.Drawing.Size(24, 23)
        Me.CmdTakhsisCancel.TabIndex = 10
        '
        'CmdTakhsisSave
        '
        Me.CmdTakhsisSave.Enabled = False
        Me.CmdTakhsisSave.Image = CType(resources.GetObject("CmdTakhsisSave.Image"), System.Drawing.Image)
        Me.CmdTakhsisSave.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.CmdTakhsisSave.Location = New System.Drawing.Point(136, 24)
        Me.CmdTakhsisSave.Name = "CmdTakhsisSave"
        Me.CmdTakhsisSave.Size = New System.Drawing.Size(24, 24)
        Me.CmdTakhsisSave.TabIndex = 8
        '
        'UcCalTakhsis
        '
        Me.UcCalTakhsis.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UcCalTakhsis.BorderColor = System.Drawing.Color.Empty
        Me.UcCalTakhsis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcCalTakhsis.ButtonBackColor = System.Drawing.Color.Empty
        Me.UcCalTakhsis.ButtonForeColor = System.Drawing.Color.Empty
        Me.UcCalTakhsis.EditableSal = True
        Me.UcCalTakhsis.Enabled = False
        Me.UcCalTakhsis.Image = CType(resources.GetObject("UcCalTakhsis.Image"), System.Drawing.Image)
        Me.UcCalTakhsis.Location = New System.Drawing.Point(234, 24)
        Me.UcCalTakhsis.MaxValue = CType(1500, Short)
        Me.UcCalTakhsis.MinValue = CType(1200, Short)
        Me.UcCalTakhsis.Name = "UcCalTakhsis"
        Me.UcCalTakhsis.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UcCalTakhsis.Sal_Mali = Nothing
        Me.UcCalTakhsis.ShowButton = True
        Me.UcCalTakhsis.Size = New System.Drawing.Size(110, 23)
        Me.UcCalTakhsis.TabIndex = 1
        Me.UcCalTakhsis.VisualStyle = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(352, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 15)
        Me.Label11.TabIndex = 439
        Me.Label11.Text = " «—ÌŒ  Œ’Ì’"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PnlEblagh
        '
        Me.PnlEblagh.Controls.Add(Me.Employee_CodEblagh)
        Me.PnlEblagh.Controls.Add(Me.CmdEblaghInsert)
        Me.PnlEblagh.Controls.Add(Me.CmdEblaghCancel)
        Me.PnlEblagh.Controls.Add(Me.CmdEblaghSave)
        Me.PnlEblagh.Controls.Add(Me.UcCalEblagh)
        Me.PnlEblagh.Controls.Add(Me.Label12)
        Me.PnlEblagh.Controls.Add(Me.Label8)
        Me.PnlEblagh.Enabled = False
        Me.PnlEblagh.Location = New System.Drawing.Point(8, 64)
        Me.PnlEblagh.Name = "PnlEblagh"
        Me.PnlEblagh.Size = New System.Drawing.Size(424, 56)
        Me.PnlEblagh.TabIndex = 455
        '
        'Employee_CodEblagh
        '
        Me.Employee_CodEblagh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Employee_CodEblagh.Code_Personal = CType(0, Short)
        Me.Employee_CodEblagh.Connection = Me.Cnn
        Me.Employee_CodEblagh.EmployeeCodLen = 10
        Me.Employee_CodEblagh.Location = New System.Drawing.Point(-2, 0)
        Me.Employee_CodEblagh.Name = "Employee_CodEblagh"
        Me.Employee_CodEblagh.NotExitIfNotFound = False
        Me.Employee_CodEblagh.ReleaseIfNotFoundEmployeeCod = False
        Me.Employee_CodEblagh.ShowEmployeeName = False
        Me.Employee_CodEblagh.Size = New System.Drawing.Size(344, 20)
        Me.Employee_CodEblagh.TabIndex = 454
        '
        'CmdEblaghInsert
        '
        Me.CmdEblaghInsert.Image = CType(resources.GetObject("CmdEblaghInsert.Image"), System.Drawing.Image)
        Me.CmdEblaghInsert.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.CmdEblaghInsert.Location = New System.Drawing.Point(200, 24)
        Me.CmdEblaghInsert.Name = "CmdEblaghInsert"
        Me.CmdEblaghInsert.Size = New System.Drawing.Size(24, 23)
        Me.CmdEblaghInsert.TabIndex = 452
        '
        'CmdEblaghCancel
        '
        Me.CmdEblaghCancel.Image = CType(resources.GetObject("CmdEblaghCancel.Image"), System.Drawing.Image)
        Me.CmdEblaghCancel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.CmdEblaghCancel.Location = New System.Drawing.Point(168, 24)
        Me.CmdEblaghCancel.Name = "CmdEblaghCancel"
        Me.CmdEblaghCancel.Size = New System.Drawing.Size(24, 23)
        Me.CmdEblaghCancel.TabIndex = 451
        '
        'CmdEblaghSave
        '
        Me.CmdEblaghSave.Enabled = False
        Me.CmdEblaghSave.Image = CType(resources.GetObject("CmdEblaghSave.Image"), System.Drawing.Image)
        Me.CmdEblaghSave.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.CmdEblaghSave.Location = New System.Drawing.Point(136, 24)
        Me.CmdEblaghSave.Name = "CmdEblaghSave"
        Me.CmdEblaghSave.Size = New System.Drawing.Size(24, 23)
        Me.CmdEblaghSave.TabIndex = 450
        '
        'UcCalEblagh
        '
        Me.UcCalEblagh.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UcCalEblagh.BorderColor = System.Drawing.Color.Empty
        Me.UcCalEblagh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UcCalEblagh.ButtonBackColor = System.Drawing.Color.Empty
        Me.UcCalEblagh.ButtonForeColor = System.Drawing.Color.Empty
        Me.UcCalEblagh.EditableSal = True
        Me.UcCalEblagh.Enabled = False
        Me.UcCalEblagh.Image = CType(resources.GetObject("UcCalEblagh.Image"), System.Drawing.Image)
        Me.UcCalEblagh.Location = New System.Drawing.Point(232, 24)
        Me.UcCalEblagh.MaxValue = CType(1500, Short)
        Me.UcCalEblagh.MinValue = CType(1200, Short)
        Me.UcCalEblagh.Name = "UcCalEblagh"
        Me.UcCalEblagh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UcCalEblagh.Sal_Mali = Nothing
        Me.UcCalEblagh.ShowButton = True
        Me.UcCalEblagh.Size = New System.Drawing.Size(110, 23)
        Me.UcCalEblagh.TabIndex = 3
        Me.UcCalEblagh.VisualStyle = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(352, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 15)
        Me.Label12.TabIndex = 440
        Me.Label12.Text = " «—ÌŒ «»·«€"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(352, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 15)
        Me.Label8.TabIndex = 435
        Me.Label8.Text = "Å”  «»·«€Ì"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCodShoghl
        '
        Me.LblCodShoghl.Location = New System.Drawing.Point(24, 144)
        Me.LblCodShoghl.Name = "LblCodShoghl"
        Me.LblCodShoghl.Size = New System.Drawing.Size(24, 24)
        Me.LblCodShoghl.TabIndex = 448
        Me.LblCodShoghl.Visible = False
        '
        'BtnSabeghe
        '
        Me.BtnSabeghe.Location = New System.Drawing.Point(80, 160)
        Me.BtnSabeghe.Name = "BtnSabeghe"
        Me.BtnSabeghe.Size = New System.Drawing.Size(90, 23)
        Me.BtnSabeghe.TabIndex = 7
        Me.BtnSabeghe.Text = "”«»ﬁÂ Å” "
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(360, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 15)
        Me.Label10.TabIndex = 437
        Me.Label10.Text = "⁄‰Ê«‰ Å” "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(360, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 15)
        Me.Label9.TabIndex = 436
        Me.Label9.Text = "Ê«Õœ ”«“„«‰Ì"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CommentShoghl
        '
        Me.CommentShoghl.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.CommentShoghl.Location = New System.Drawing.Point(80, 136)
        Me.CommentShoghl.Name = "CommentShoghl"
        Me.CommentShoghl.Size = New System.Drawing.Size(90, 23)
        Me.CommentShoghl.TabIndex = 5
        Me.CommentShoghl.TabStop = False
        Me.CommentShoghl.Text = Nothing
        Me.CommentShoghl.ZButtonText = " Ê÷ÌÕ« "
        Me.CommentShoghl.ZCommentFormheight = 0
        Me.CommentShoghl.ZCommentFormWidth = 0
        Me.CommentShoghl.ZEnabled = True
        Me.CommentShoghl.ZLanguage = UCCommentButton.Language.Persian
        Me.CommentShoghl.ZMaxCommentLength = 0
        Me.CommentShoghl.ZShowInLeft = False
        Me.CommentShoghl.ZShowInTop = False
        '
        'LblOnvanPost
        '
        Me.LblOnvanPost.BackColor = System.Drawing.Color.Gold
        Me.LblOnvanPost.Location = New System.Drawing.Point(192, 160)
        Me.LblOnvanPost.Name = "LblOnvanPost"
        Me.LblOnvanPost.ReadOnly = True
        Me.LblOnvanPost.Size = New System.Drawing.Size(160, 21)
        Me.LblOnvanPost.TabIndex = 6
        Me.LblOnvanPost.Text = ""
        '
        'LblVahedShoghl
        '
        Me.LblVahedShoghl.BackColor = System.Drawing.Color.Gold
        Me.LblVahedShoghl.Location = New System.Drawing.Point(192, 136)
        Me.LblVahedShoghl.Name = "LblVahedShoghl"
        Me.LblVahedShoghl.ReadOnly = True
        Me.LblVahedShoghl.Size = New System.Drawing.Size(160, 21)
        Me.LblVahedShoghl.TabIndex = 4
        Me.LblVahedShoghl.Text = ""
        '
        'PnlRight
        '
        Me.PnlRight.CaptionVisible = Janus.Windows.UI.InheritableBoolean.False
        Me.PnlRight.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlRight.Location = New System.Drawing.Point(445, 107)
        Me.PnlRight.Name = "PnlRight"
        Me.PnlRight.Size = New System.Drawing.Size(310, 534)
        Me.PnlRight.StaticGroup = True
        Me.PnlRight.TabIndex = 4
        Me.PnlRight.Text = "Panel 3"
        '
        'PnlVahed
        '
        Me.PnlVahed.InnerContainer = Me.PnlVahedContainer
        Me.PnlVahed.Location = New System.Drawing.Point(4, 0)
        Me.PnlVahed.Name = "PnlVahed"
        Me.PnlVahed.Size = New System.Drawing.Size(306, 181)
        Me.PnlVahed.TabIndex = 4
        Me.PnlVahed.Text = "Ê«Õœ Â«Ì ”«“„«‰Ì"
        Me.PnlVahed.TextAlignment = Janus.Windows.UI.Dock.PanelTextAlignment.Center
        '
        'PnlVahedContainer
        '
        Me.PnlVahedContainer.Controls.Add(Me.CmdSaveVahed)
        Me.PnlVahedContainer.Controls.Add(Me.Label17)
        Me.PnlVahedContainer.Controls.Add(Me.Label16)
        Me.PnlVahedContainer.Controls.Add(Me.Label15)
        Me.PnlVahedContainer.Controls.Add(Me.Label14)
        Me.PnlVahedContainer.Controls.Add(Me.CmbRadeSazmani)
        Me.PnlVahedContainer.Controls.Add(Me.TxtTel)
        Me.PnlVahedContainer.Controls.Add(Me.TxtMahalVahed)
        Me.PnlVahedContainer.Controls.Add(Me.TxtOnvanVahed)
        Me.PnlVahedContainer.Controls.Add(Me.CommentVahed)
        Me.PnlVahedContainer.Controls.Add(Me.PictureButton1)
        Me.PnlVahedContainer.Controls.Add(Me.CmdCancelVahed)
        Me.PnlVahedContainer.Location = New System.Drawing.Point(1, 23)
        Me.PnlVahedContainer.Name = "PnlVahedContainer"
        Me.PnlVahedContainer.Size = New System.Drawing.Size(304, 157)
        Me.PnlVahedContainer.TabIndex = 0
        '
        'CmdSaveVahed
        '
        Me.CmdSaveVahed.BackgroundImage = CType(resources.GetObject("CmdSaveVahed.BackgroundImage"), System.Drawing.Image)
        Me.CmdSaveVahed.Image = CType(resources.GetObject("CmdSaveVahed.Image"), System.Drawing.Image)
        Me.CmdSaveVahed.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.CmdSaveVahed.Location = New System.Drawing.Point(16, 128)
        Me.CmdSaveVahed.Name = "CmdSaveVahed"
        Me.CmdSaveVahed.Size = New System.Drawing.Size(24, 23)
        Me.CmdSaveVahed.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(192, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 15)
        Me.Label17.TabIndex = 438
        Me.Label17.Text = "⁄‰Ê«‰ Ê«Õœ ”«“„«‰Ì"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(192, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 15)
        Me.Label16.TabIndex = 437
        Me.Label16.Text = "òœ —œÂ ”«“„«‰Ì"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(304, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 15)
        Me.Label15.TabIndex = 436
        Me.Label15.Text = " ·›‰"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(112, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 15)
        Me.Label14.TabIndex = 435
        Me.Label14.Text = "„Õ· Ê«Õœ"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbRadeSazmani
        '
        Me.CmbRadeSazmani.DataSource = Me.DsFrmNermoodarSazmani1.tas_bas_radeh_sazemani
        Me.CmbRadeSazmani.DisplayMember = "desc_radeh_sazemani"
        Me.CmbRadeSazmani.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRadeSazmani.Location = New System.Drawing.Point(24, 32)
        Me.CmbRadeSazmani.Name = "CmbRadeSazmani"
        Me.CmbRadeSazmani.Size = New System.Drawing.Size(152, 21)
        Me.CmbRadeSazmani.TabIndex = 1
        Me.CmbRadeSazmani.ValueMember = "code_radeh_sazemani"
        '
        'TxtTel
        '
        Me.TxtTel.Location = New System.Drawing.Point(160, 64)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.TabIndex = 2
        Me.TxtTel.Text = ""
        '
        'TxtMahalVahed
        '
        Me.TxtMahalVahed.Location = New System.Drawing.Point(8, 64)
        Me.TxtMahalVahed.Name = "TxtMahalVahed"
        Me.TxtMahalVahed.TabIndex = 3
        Me.TxtMahalVahed.Text = ""
        '
        'TxtOnvanVahed
        '
        Me.TxtOnvanVahed.Location = New System.Drawing.Point(24, 8)
        Me.TxtOnvanVahed.Name = "TxtOnvanVahed"
        Me.TxtOnvanVahed.Size = New System.Drawing.Size(152, 21)
        Me.TxtOnvanVahed.TabIndex = 0
        Me.TxtOnvanVahed.Text = ""
        '
        'CommentVahed
        '
        Me.CommentVahed.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.CommentVahed.Location = New System.Drawing.Point(192, 96)
        Me.CommentVahed.Name = "CommentVahed"
        Me.CommentVahed.Size = New System.Drawing.Size(90, 23)
        Me.CommentVahed.TabIndex = 4
        Me.CommentVahed.TabStop = False
        Me.CommentVahed.Text = Nothing
        Me.CommentVahed.ZButtonText = " Ê÷ÌÕ« "
        Me.CommentVahed.ZCommentFormheight = 0
        Me.CommentVahed.ZCommentFormWidth = 0
        Me.CommentVahed.ZEnabled = True
        Me.CommentVahed.ZLanguage = UCCommentButton.Language.Persian
        Me.CommentVahed.ZMaxCommentLength = 0
        Me.CommentVahed.ZShowInLeft = False
        Me.CommentVahed.ZShowInTop = False
        '
        'PictureButton1
        '
        Me.PictureButton1.ButtonText = "Picture"
        Me.PictureButton1.Location = New System.Drawing.Point(64, 96)
        Me.PictureButton1.MyPicture = Nothing
        Me.PictureButton1.Name = "PictureButton1"
        Me.PictureButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PictureButton1.Size = New System.Drawing.Size(79, 23)
        Me.PictureButton1.TabIndex = 5
        '
        'CmdCancelVahed
        '
        Me.CmdCancelVahed.Image = CType(resources.GetObject("CmdCancelVahed.Image"), System.Drawing.Image)
        Me.CmdCancelVahed.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.CmdCancelVahed.Location = New System.Drawing.Point(48, 128)
        Me.CmdCancelVahed.Name = "CmdCancelVahed"
        Me.CmdCancelVahed.Size = New System.Drawing.Size(24, 23)
        Me.CmdCancelVahed.TabIndex = 6
        '
        'PnlPostSazman
        '
        Me.PnlPostSazman.InnerContainer = Me.PnlPostSazmanContainer
        Me.PnlPostSazman.Location = New System.Drawing.Point(4, 185)
        Me.PnlPostSazman.Name = "PnlPostSazman"
        Me.PnlPostSazman.Size = New System.Drawing.Size(306, 349)
        Me.PnlPostSazman.TabIndex = 4
        Me.PnlPostSazman.Text = "Å” Â«Ì ”«“„«‰Ì"
        Me.PnlPostSazman.TextAlignment = Janus.Windows.UI.Dock.PanelTextAlignment.Center
        '
        'PnlPostSazmanContainer
        '
        Me.PnlPostSazmanContainer.Controls.Add(Me.Pnlpost)
        Me.PnlPostSazmanContainer.Controls.Add(Me.CmdInsertPost)
        Me.PnlPostSazmanContainer.Controls.Add(Me.CmdCancelPost)
        Me.PnlPostSazmanContainer.Controls.Add(Me.CmdSavePost)
        Me.PnlPostSazmanContainer.Controls.Add(Me.Label13)
        Me.PnlPostSazmanContainer.Controls.Add(Me.GrdPost)
        Me.PnlPostSazmanContainer.Controls.Add(Me.LblVahedPost)
        Me.PnlPostSazmanContainer.Location = New System.Drawing.Point(1, 23)
        Me.PnlPostSazmanContainer.Name = "PnlPostSazmanContainer"
        Me.PnlPostSazmanContainer.Size = New System.Drawing.Size(304, 325)
        Me.PnlPostSazmanContainer.TabIndex = 0
        '
        'Pnlpost
        '
        Me.Pnlpost.Controls.Add(Me.ShoghlName1)
        Me.Pnlpost.Controls.Add(Me.LblCodPost)
        Me.Pnlpost.Controls.Add(Me.ChkActivePost)
        Me.Pnlpost.Controls.Add(Me.Label6)
        Me.Pnlpost.Controls.Add(Me.Label5)
        Me.Pnlpost.Controls.Add(Me.Label3)
        Me.Pnlpost.Controls.Add(Me.TxtOnvanPost)
        Me.Pnlpost.Controls.Add(Me.TxtShomarePost)
        Me.Pnlpost.Controls.Add(Me.CommentVazaef)
        Me.Pnlpost.Controls.Add(Me.CommentPost)
        Me.Pnlpost.Location = New System.Drawing.Point(0, 144)
        Me.Pnlpost.Name = "Pnlpost"
        Me.Pnlpost.Size = New System.Drawing.Size(360, 112)
        Me.Pnlpost.TabIndex = 445
        Me.Pnlpost.TabStop = False
        '
        'ShoghlName1
        '
        Me.ShoghlName1.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D
        Me.ShoghlName1.ColmpleteAfterLeave = True
        Me.ShoghlName1.Connection = Me.SqlConnection1
        Me.ShoghlName1.Location = New System.Drawing.Point(16, 48)
        Me.ShoghlName1.Name = "ShoghlName1"
        Me.ShoghlName1.NotExitIfNotFound = False
        Me.ShoghlName1.ReleaseIfNotFoundShoghlName = False
        Me.ShoghlName1.Shoghl_Name = ""
        Me.ShoghlName1.ShoghlCode = 0
        Me.ShoghlName1.Size = New System.Drawing.Size(232, 22)
        Me.ShoghlName1.TabIndex = 446
        '
        'LblCodPost
        '
        Me.LblCodPost.Location = New System.Drawing.Point(0, 80)
        Me.LblCodPost.Name = "LblCodPost"
        Me.LblCodPost.Size = New System.Drawing.Size(16, 24)
        Me.LblCodPost.TabIndex = 445
        Me.LblCodPost.Visible = False
        '
        'ChkActivePost
        '
        Me.ChkActivePost.Location = New System.Drawing.Point(216, 80)
        Me.ChkActivePost.Name = "ChkActivePost"
        Me.ChkActivePost.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkActivePost.Size = New System.Drawing.Size(72, 24)
        Me.ChkActivePost.TabIndex = 444
        Me.ChkActivePost.Text = "  ›⁄«·"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(256, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 24)
        Me.Label6.TabIndex = 443
        Me.Label6.Text = "‘€·"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(128, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 24)
        Me.Label5.TabIndex = 442
        Me.Label5.Text = "⁄‰Ê«‰"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(256, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 24)
        Me.Label3.TabIndex = 441
        Me.Label3.Text = "‘„«—Â"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtOnvanPost
        '
        Me.TxtOnvanPost.Location = New System.Drawing.Point(8, 16)
        Me.TxtOnvanPost.Name = "TxtOnvanPost"
        Me.TxtOnvanPost.Size = New System.Drawing.Size(112, 21)
        Me.TxtOnvanPost.TabIndex = 1
        Me.TxtOnvanPost.Text = ""
        '
        'TxtShomarePost
        '
        Me.TxtShomarePost.Location = New System.Drawing.Point(168, 16)
        Me.TxtShomarePost.Name = "TxtShomarePost"
        Me.TxtShomarePost.Size = New System.Drawing.Size(80, 21)
        Me.TxtShomarePost.TabIndex = 0
        Me.TxtShomarePost.Text = ""
        '
        'CommentVazaef
        '
        Me.CommentVazaef.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.CommentVazaef.Location = New System.Drawing.Point(16, 80)
        Me.CommentVazaef.Name = "CommentVazaef"
        Me.CommentVazaef.Size = New System.Drawing.Size(96, 24)
        Me.CommentVazaef.TabIndex = 4
        Me.CommentVazaef.TabStop = False
        Me.CommentVazaef.Text = Nothing
        Me.CommentVazaef.ZButtonText = "‘—Õ ÊŸ«Ì›"
        Me.CommentVazaef.ZCommentFormheight = 0
        Me.CommentVazaef.ZCommentFormWidth = 0
        Me.CommentVazaef.ZEnabled = True
        Me.CommentVazaef.ZLanguage = UCCommentButton.Language.Persian
        Me.CommentVazaef.ZMaxCommentLength = 0
        Me.CommentVazaef.ZShowInLeft = False
        Me.CommentVazaef.ZShowInTop = False
        '
        'CommentPost
        '
        Me.CommentPost.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.CommentPost.Location = New System.Drawing.Point(128, 80)
        Me.CommentPost.Name = "CommentPost"
        Me.CommentPost.Size = New System.Drawing.Size(88, 24)
        Me.CommentPost.TabIndex = 3
        Me.CommentPost.TabStop = False
        Me.CommentPost.Text = Nothing
        Me.CommentPost.ZButtonText = " Ê÷ÌÕ« "
        Me.CommentPost.ZCommentFormheight = 0
        Me.CommentPost.ZCommentFormWidth = 0
        Me.CommentPost.ZEnabled = True
        Me.CommentPost.ZLanguage = UCCommentButton.Language.Persian
        Me.CommentPost.ZMaxCommentLength = 0
        Me.CommentPost.ZShowInLeft = False
        Me.CommentPost.ZShowInTop = False
        '
        'CmdInsertPost
        '
        Me.CmdInsertPost.Image = CType(resources.GetObject("CmdInsertPost.Image"), System.Drawing.Image)
        Me.CmdInsertPost.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.CmdInsertPost.Location = New System.Drawing.Point(80, 296)
        Me.CmdInsertPost.Name = "CmdInsertPost"
        Me.CmdInsertPost.Size = New System.Drawing.Size(24, 23)
        Me.CmdInsertPost.TabIndex = 5
        '
        'CmdCancelPost
        '
        Me.CmdCancelPost.Image = CType(resources.GetObject("CmdCancelPost.Image"), System.Drawing.Image)
        Me.CmdCancelPost.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.CmdCancelPost.Location = New System.Drawing.Point(48, 296)
        Me.CmdCancelPost.Name = "CmdCancelPost"
        Me.CmdCancelPost.Size = New System.Drawing.Size(24, 23)
        Me.CmdCancelPost.TabIndex = 1
        '
        'CmdSavePost
        '
        Me.CmdSavePost.Enabled = False
        Me.CmdSavePost.Image = CType(resources.GetObject("CmdSavePost.Image"), System.Drawing.Image)
        Me.CmdSavePost.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.CmdSavePost.Location = New System.Drawing.Point(16, 296)
        Me.CmdSavePost.Name = "CmdSavePost"
        Me.CmdSavePost.Size = New System.Drawing.Size(24, 23)
        Me.CmdSavePost.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(224, 264)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 15)
        Me.Label13.TabIndex = 436
        Me.Label13.Text = "Ê«Õœ ”«“„«‰Ì"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrdPost
        '
        Me.GrdPost.ContextMenu = Me.MnuPost
        Me.GrdPost.DataSource = Me.DsFrmNermoodarSazmani1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""somareh_post" & _
        "_sazemani""><BoundImageMaskColor>224, 224, 224</BoundImageMaskColor><Caption>‘„«—" & _
        "Â Å” </Caption><DataMember>somareh_post_sazemani</DataMember><EditType>NoEdit</E" & _
        "ditType><FilterEditType>TextBox</FilterEditType><Key>somareh_post_sazemani</Key>" & _
        "<Position>0</Position><Width>76</Width></Column0><Column1 ID=""code_post_sazemani" & _
        """><BoundImageMaskColor>224, 224, 224</BoundImageMaskColor><Caption>òœ ‘€·</Capti" & _
        "on><DataMember>code_post_sazemani</DataMember><EditType>NoEdit</EditType><Filter" & _
        "EditType>TextBox</FilterEditType><Key>code_post_sazemani</Key><Position>1</Posit" & _
        "ion><Width>55</Width></Column1><Column2 ID=""desc_post_sazemani""><Caption>⁄‰Ê«‰ Å" & _
        "” </Caption><DataMember>desc_post_sazemani</DataMember><EditType>NoEdit</EditTyp" & _
        "e><FilterEditType>TextBox</FilterEditType><Key>desc_post_sazemani</Key><Position" & _
        ">2</Position><Width>146</Width></Column2></Columns><GroupCondition ID="""" /></Roo" & _
        "tTable></GridEXLayoutData>"
        Me.GrdPost.DesignTimeLayout = GridEXLayout1
        Me.GrdPost.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrdPost.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdPost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GrdPost.GroupByBoxVisible = False
        Me.GrdPost.Location = New System.Drawing.Point(0, 0)
        Me.GrdPost.Name = "GrdPost"
        Me.GrdPost.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GrdPost.Size = New System.Drawing.Size(304, 152)
        Me.GrdPost.TabIndex = 432
        '
        'MnuPost
        '
        Me.MnuPost.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnAddPost, Me.MnUpdatePost, Me.MnDeletPost, Me.MnTakhsis, Me.MnEblagh})
        '
        'MnAddPost
        '
        Me.MnAddPost.Index = 0
        Me.MnAddPost.Text = "«ÌÃ«œ"
        '
        'MnUpdatePost
        '
        Me.MnUpdatePost.Index = 1
        Me.MnUpdatePost.Text = "«’·«Õ"
        '
        'MnDeletPost
        '
        Me.MnDeletPost.Index = 2
        Me.MnDeletPost.Text = "Õ–›"
        '
        'MnTakhsis
        '
        Me.MnTakhsis.Index = 3
        Me.MnTakhsis.Text = " Œ’Ì’ Å” "
        '
        'MnEblagh
        '
        Me.MnEblagh.Index = 4
        Me.MnEblagh.Text = "«»·«€ Å” "
        '
        'LblVahedPost
        '
        Me.LblVahedPost.BackColor = System.Drawing.Color.Gold
        Me.LblVahedPost.Location = New System.Drawing.Point(16, 264)
        Me.LblVahedPost.Name = "LblVahedPost"
        Me.LblVahedPost.ReadOnly = True
        Me.LblVahedPost.Size = New System.Drawing.Size(200, 21)
        Me.LblVahedPost.TabIndex = 424
        Me.LblVahedPost.Text = ""
        '
        'uiPanel0
        '
        Me.uiPanel0.InnerContainer = Me.uiPanel0Container
        Me.uiPanel0.Location = New System.Drawing.Point(0, 22)
        Me.uiPanel0.Name = "uiPanel0"
        Me.uiPanel0.Size = New System.Drawing.Size(96, 346)
        Me.uiPanel0.TabIndex = 4
        Me.uiPanel0.Text = "Panel 0"
        '
        'uiPanel0Container
        '
        Me.uiPanel0Container.Location = New System.Drawing.Point(0, 0)
        Me.uiPanel0Container.Name = "uiPanel0Container"
        Me.uiPanel0Container.Size = New System.Drawing.Size(96, 346)
        Me.uiPanel0Container.TabIndex = 0
        '
        'uiPanel1
        '
        Me.uiPanel1.InnerContainer = Me.uiPanel1Container
        Me.uiPanel1.Location = New System.Drawing.Point(100, 22)
        Me.uiPanel1.Name = "uiPanel1"
        Me.uiPanel1.Size = New System.Drawing.Size(96, 346)
        Me.uiPanel1.TabIndex = 4
        Me.uiPanel1.Text = "Panel 1"
        '
        'uiPanel1Container
        '
        Me.uiPanel1Container.Location = New System.Drawing.Point(0, 0)
        Me.uiPanel1Container.Name = "uiPanel1Container"
        Me.uiPanel1Container.Size = New System.Drawing.Size(96, 346)
        Me.uiPanel1Container.TabIndex = 0
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_vahed, code_tashkilat, desc_vahed, code_master, code_radeh_sazemani, ma" & _
        "hal_vahed, tel, remark, picture, code_bandar FROM tas_bas_vahed WHERE (code_tash" & _
        "kilat = @CodTashkilat)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodTashkilat", System.Data.SqlDbType.SmallInt, 2, "code_tashkilat"))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO tas_bas_vahed (code_tashkilat, desc_vahed, code_master, code_radeh_sa" & _
        "zemani, mahal_vahed, tel, remark, picture, code_bandar) VALUES (@code_tashkilat," & _
        " @desc_vahed, @code_master, @code_radeh_sazemani, @mahal_vahed, @tel, @remark, @" & _
        "picture, @code_bandar); SELECT @@identity FROM tas_bas_vahed"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_tashkilat", System.Data.SqlDbType.SmallInt, 2, "code_tashkilat"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_vahed", System.Data.SqlDbType.VarChar, 50, "desc_vahed"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_master", System.Data.SqlDbType.SmallInt, 2, "code_master"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_radeh_sazemani", System.Data.SqlDbType.SmallInt, 2, "code_radeh_sazemani"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@mahal_vahed", System.Data.SqlDbType.VarChar, 100, "mahal_vahed"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tel", System.Data.SqlDbType.VarChar, 50, "tel"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@picture", System.Data.SqlDbType.VarBinary, 2147483647, "picture"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_bandar", System.Data.SqlDbType.VarChar, 2, "code_bandar"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE tas_bas_vahed SET code_tashkilat = @code_tashkilat, desc_vahed = @desc_vah" & _
        "ed, code_radeh_sazemani = @code_radeh_sazemani, mahal_vahed = @mahal_vahed, tel " & _
        "= @tel, remark = @remark, picture = @picture, code_bandar = @code_bandar WHERE (" & _
        "id_vahed = @IdVahed)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_tashkilat", System.Data.SqlDbType.SmallInt, 2, "code_tashkilat"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_vahed", System.Data.SqlDbType.VarChar, 50, "desc_vahed"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_radeh_sazemani", System.Data.SqlDbType.SmallInt, 2, "code_radeh_sazemani"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@mahal_vahed", System.Data.SqlDbType.VarChar, 100, "mahal_vahed"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tel", System.Data.SqlDbType.VarChar, 50, "tel"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@picture", System.Data.SqlDbType.VarBinary, 16, "picture"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_bandar", System.Data.SqlDbType.VarChar, 2, "code_bandar"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdVahed", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_vahed", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM tas_bas_vahed WHERE (id_vahed = @IdVahed)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdVahed", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_vahed", System.Data.DataRowVersion.Original, Nothing))
        '
        'DATas_Bas_Vahed
        '
        Me.DATas_Bas_Vahed.DeleteCommand = Me.SqlDeleteCommand1
        Me.DATas_Bas_Vahed.InsertCommand = Me.SqlInsertCommand1
        Me.DATas_Bas_Vahed.SelectCommand = Me.SqlSelectCommand1
        Me.DATas_Bas_Vahed.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tas_bas_vahed", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_vahed", "id_vahed"), New System.Data.Common.DataColumnMapping("code_tashkilat", "code_tashkilat"), New System.Data.Common.DataColumnMapping("desc_vahed", "desc_vahed"), New System.Data.Common.DataColumnMapping("code_master", "code_master"), New System.Data.Common.DataColumnMapping("code_radeh_sazemani", "code_radeh_sazemani"), New System.Data.Common.DataColumnMapping("mahal_vahed", "mahal_vahed"), New System.Data.Common.DataColumnMapping("tel", "tel"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("picture", "picture"), New System.Data.Common.DataColumnMapping("code_bandar", "code_bandar")})})
        Me.DATas_Bas_Vahed.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT code_tashkilat, desc_tashkilat FROM tas_bas_tashkilat"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO tas_bas_tashkilat(desc_tashkilat, code_bandar) VALUES (@desc_tashkila" & _
        "t, @code_bandar); SELECT code_tashkilat, desc_tashkilat, code_bandar FROM tas_ba" & _
        "s_tashkilat WHERE (code_tashkilat = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_tashkilat", System.Data.SqlDbType.VarChar, 50, "desc_tashkilat"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_bandar", System.Data.SqlDbType.VarChar, 2, "code_bandar"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE tas_bas_tashkilat SET desc_tashkilat = @desc_tashkilat, code_bandar = @cod" & _
        "e_bandar WHERE (code_tashkilat = @Original_code_tashkilat) AND (code_bandar = @O" & _
        "riginal_code_bandar) AND (desc_tashkilat = @Original_desc_tashkilat); SELECT cod" & _
        "e_tashkilat, desc_tashkilat, code_bandar FROM tas_bas_tashkilat WHERE (code_tash" & _
        "kilat = @code_tashkilat)"
        Me.SqlUpdateCommand2.Connection = Me.Cnn
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_tashkilat", System.Data.SqlDbType.VarChar, 50, "desc_tashkilat"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_bandar", System.Data.SqlDbType.VarChar, 2, "code_bandar"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_tashkilat", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_tashkilat", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_bandar", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_bandar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_tashkilat", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_tashkilat", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_tashkilat", System.Data.SqlDbType.SmallInt, 2, "code_tashkilat"))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM tas_bas_tashkilat WHERE (code_tashkilat = @Original_code_tashkilat) A" & _
        "ND (code_bandar = @Original_code_bandar) AND (desc_tashkilat = @Original_desc_ta" & _
        "shkilat)"
        Me.SqlDeleteCommand2.Connection = Me.Cnn
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_tashkilat", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_tashkilat", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_bandar", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_bandar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_tashkilat", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_tashkilat", System.Data.DataRowVersion.Original, Nothing))
        '
        'DATas_bas_tashkilat
        '
        Me.DATas_bas_tashkilat.DeleteCommand = Me.SqlDeleteCommand2
        Me.DATas_bas_tashkilat.InsertCommand = Me.SqlInsertCommand2
        Me.DATas_bas_tashkilat.SelectCommand = Me.SqlSelectCommand2
        Me.DATas_bas_tashkilat.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tas_bas_tashkilat", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("code_tashkilat", "code_tashkilat"), New System.Data.Common.DataColumnMapping("desc_tashkilat", "desc_tashkilat"), New System.Data.Common.DataColumnMapping("code_bandar", "code_bandar")})})
        Me.DATas_bas_tashkilat.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT code_radeh_sazemani, desc_radeh_sazemani FROM tas_bas_radeh_sazemani"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DAtas_bas_radeh_sazemani
        '
        Me.DAtas_bas_radeh_sazemani.SelectCommand = Me.SqlSelectCommand3
        Me.DAtas_bas_radeh_sazemani.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tas_bas_radeh_sazemani", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("code_radeh_sazemani", "code_radeh_sazemani"), New System.Data.Common.DataColumnMapping("desc_radeh_sazemani", "desc_radeh_sazemani")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT code_post_sazemani, somareh_post_sazemani, desc_post_sazemani, id_vahed, c" & _
        "ode_reshteh_shoghli, shrah_vazaef, activate, remark, code_bandar FROM tas_tr_vah" & _
        "edha_mashaghel"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO tas_tr_vahedha_mashaghel (somareh_post_sazemani, desc_post_sazemani, " & _
        "id_vahed, code_reshteh_shoghli, shrah_vazaef, activate, remark, code_bandar) VAL" & _
        "UES (@somareh_post_sazemani, @desc_post_sazemani, @id_vahed, @code_reshteh_shogh" & _
        "li, @shrah_vazaef, @activate, @remark, @code_bandar)"
        Me.SqlInsertCommand3.Connection = Me.Cnn
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@somareh_post_sazemani", System.Data.SqlDbType.VarChar, 6, "somareh_post_sazemani"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_post_sazemani", System.Data.SqlDbType.VarChar, 50, "desc_post_sazemani"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_vahed", System.Data.SqlDbType.SmallInt, 2, "id_vahed"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_reshteh_shoghli", System.Data.SqlDbType.SmallInt, 2, "code_reshteh_shoghli"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@shrah_vazaef", System.Data.SqlDbType.VarChar, 2147483647, "shrah_vazaef"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@activate", System.Data.SqlDbType.Bit, 1, "activate"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_bandar", System.Data.SqlDbType.VarChar, 2, "code_bandar"))
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE tas_tr_vahedha_mashaghel SET somareh_post_sazemani = @somareh_post_sazeman" & _
        "i, desc_post_sazemani = @desc_post_sazemani, id_vahed = @id_vahed, code_reshteh_" & _
        "shoghli = @code_reshteh_shoghli, shrah_vazaef = @shrah_vazaef, activate = @activ" & _
        "ate, remark = @remark, code_bandar = @code_bandar WHERE (code_post_sazemani = @C" & _
        "odPost)"
        Me.SqlUpdateCommand3.Connection = Me.Cnn
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@somareh_post_sazemani", System.Data.SqlDbType.VarChar, 6, "somareh_post_sazemani"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_post_sazemani", System.Data.SqlDbType.VarChar, 50, "desc_post_sazemani"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_vahed", System.Data.SqlDbType.SmallInt, 2, "id_vahed"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_reshteh_shoghli", System.Data.SqlDbType.SmallInt, 2, "code_reshteh_shoghli"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@shrah_vazaef", System.Data.SqlDbType.VarChar, 2147483647, "shrah_vazaef"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@activate", System.Data.SqlDbType.Bit, 1, "activate"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_bandar", System.Data.SqlDbType.VarChar, 2, "code_bandar"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodPost", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_post_sazemani", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM tas_tr_vahedha_mashaghel WHERE (code_post_sazemani = @CodPost)"
        Me.SqlDeleteCommand3.Connection = Me.Cnn
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodPost", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_post_sazemani", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAtas_tr_vahedha_mashaghel
        '
        Me.DAtas_tr_vahedha_mashaghel.DeleteCommand = Me.SqlDeleteCommand3
        Me.DAtas_tr_vahedha_mashaghel.InsertCommand = Me.SqlInsertCommand3
        Me.DAtas_tr_vahedha_mashaghel.SelectCommand = Me.SqlSelectCommand4
        Me.DAtas_tr_vahedha_mashaghel.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tas_tr_vahedha_mashaghel", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("code_post_sazemani", "code_post_sazemani"), New System.Data.Common.DataColumnMapping("somareh_post_sazemani", "somareh_post_sazemani"), New System.Data.Common.DataColumnMapping("desc_post_sazemani", "desc_post_sazemani"), New System.Data.Common.DataColumnMapping("id_vahed", "id_vahed"), New System.Data.Common.DataColumnMapping("code_reshteh_shoghli", "code_reshteh_shoghli"), New System.Data.Common.DataColumnMapping("shrah_vazaef", "shrah_vazaef"), New System.Data.Common.DataColumnMapping("activate", "activate"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("code_bandar", "code_bandar")})})
        Me.DAtas_tr_vahedha_mashaghel.UpdateCommand = Me.SqlUpdateCommand3
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT id_post, code_post_sazemani, code_personal_takhsis, code_personal_eblagh, " & _
        "activate, date_takhsis, date_eblagh, remark, code_bandar FROM tas_tr_takhsis_pos" & _
        "tsazemani WHERE (code_post_sazemani = @codpost) AND (activate = 1)"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@codpost", System.Data.SqlDbType.SmallInt, 2, "code_post_sazemani"))
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO tas_tr_takhsis_postsazemani (code_post_sazemani, code_personal_takhsi" & _
        "s, code_personal_eblagh, activate, date_takhsis, date_eblagh, remark, code_banda" & _
        "r) VALUES (@code_post_sazemani, @code_personal_takhsis, @code_personal_eblagh, @" & _
        "activate, @date_takhsis, @date_eblagh, @remark, @code_bandar)"
        Me.SqlInsertCommand4.Connection = Me.Cnn
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_post_sazemani", System.Data.SqlDbType.SmallInt, 2, "code_post_sazemani"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_personal_takhsis", System.Data.SqlDbType.Int, 4, "code_personal_takhsis"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_personal_eblagh", System.Data.SqlDbType.Int, 4, "code_personal_eblagh"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@activate", System.Data.SqlDbType.Bit, 1, "activate"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_takhsis", System.Data.SqlDbType.VarChar, 10, "date_takhsis"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_eblagh", System.Data.SqlDbType.VarChar, 10, "date_eblagh"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_bandar", System.Data.SqlDbType.VarChar, 2, "code_bandar"))
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE tas_tr_takhsis_postsazemani SET code_personal_eblagh = @code_personal_ebla" & _
        "gh, date_eblagh = @date_eblagh, remark = @remark WHERE (id_post = @IdPost)"
        Me.SqlUpdateCommand4.Connection = Me.Cnn
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_personal_eblagh", System.Data.SqlDbType.Int, 4, "code_personal_eblagh"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_eblagh", System.Data.SqlDbType.VarChar, 10, "date_eblagh"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdPost", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_post", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM tas_tr_takhsis_postsazemani WHERE (id_post = @IdPost)"
        Me.SqlDeleteCommand4.Connection = Me.Cnn
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdPost", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_post", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAtas_tr_takhsis_postsazemani
        '
        Me.DAtas_tr_takhsis_postsazemani.DeleteCommand = Me.SqlDeleteCommand4
        Me.DAtas_tr_takhsis_postsazemani.InsertCommand = Me.SqlInsertCommand4
        Me.DAtas_tr_takhsis_postsazemani.SelectCommand = Me.SqlSelectCommand5
        Me.DAtas_tr_takhsis_postsazemani.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tas_tr_takhsis_postsazemani", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_post", "id_post"), New System.Data.Common.DataColumnMapping("code_post_sazemani", "code_post_sazemani"), New System.Data.Common.DataColumnMapping("cod_personal_takhsis", "cod_personal_takhsis"), New System.Data.Common.DataColumnMapping("cod_personal_eblagh", "cod_personal_eblagh"), New System.Data.Common.DataColumnMapping("activate", "activate"), New System.Data.Common.DataColumnMapping("date_takhsis", "date_takhsis"), New System.Data.Common.DataColumnMapping("date_eblagh", "date_eblagh"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("code_bandar", "code_bandar")})})
        Me.DAtas_tr_takhsis_postsazemani.UpdateCommand = Me.SqlUpdateCommand4
        '
        'MnuBtnVahed
        '
        Me.MnuBtnVahed.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = ""
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.Connection = Me.Cnn
        '
        'DAGeneral
        '
        Me.DAGeneral.SelectCommand = Me.SqlSelectCommand6
        '
        'CmdDeletShoghl
        '
        Me.CmdDeletShoghl.Location = New System.Drawing.Point(24, 144)
        Me.CmdDeletShoghl.Name = "CmdDeletShoghl"
        Me.CmdDeletShoghl.Size = New System.Drawing.Size(24, 24)
        Me.CmdDeletShoghl.TabIndex = 455
        '
        'FrmNermoodarSazmani
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(758, 644)
        Me.Controls.Add(Me.PnlRight)
        Me.Controls.Add(Me.PnlLeft)
        Me.Controls.Add(Me.PnlTashkilat)
        Me.Controls.Add(Me.Panel9)
        Me.Name = "FrmNermoodarSazmani"
        Me.Text = "‰„Êœ«— ”«“„«‰Ì"
        Me.Panel9.ResumeLayout(False)
        Me.PnlTashkilat.ResumeLayout(False)
        CType(Me.DsFrmNermoodarSazmani1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiPanelManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PnlLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlLeft.ResumeLayout(False)
        CType(Me.PnlTree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTree.ResumeLayout(False)
        Me.PnlTreeContainer.ResumeLayout(False)
        CType(Me.PnlPostTakhsisy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlPostTakhsisy.ResumeLayout(False)
        Me.PnlPostTakhsisyContainer.ResumeLayout(False)
        Me.PnlTakhsis.ResumeLayout(False)
        Me.PnlEblagh.ResumeLayout(False)
        CType(Me.PnlRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlRight.ResumeLayout(False)
        CType(Me.PnlVahed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlVahed.ResumeLayout(False)
        Me.PnlVahedContainer.ResumeLayout(False)
        CType(Me.PnlPostSazman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlPostSazman.ResumeLayout(False)
        Me.PnlPostSazmanContainer.ResumeLayout(False)
        Me.Pnlpost.ResumeLayout(False)
        CType(Me.GrdPost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uiPanel0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uiPanel0.ResumeLayout(False)
        CType(Me.uiPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uiPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim IdVahed As Int16
    Dim DescVahed As String
    Dim FormStatus As status
    Public PathTree As String
    Dim StrWhereVahed As String
    Dim StrWhereRade As String
    Dim ThisSelectdedNode As TreeNode

    Enum status
        AddVahed = 1
        UpdateVahed = 2
        'DeletVahed = 3
        AddPost = 3
        UpdatePost = 4
        'DeletPost = 3
        AddShoghlTakhsis = 5
        AddShoghlEblagh = 6
        UpdateShoghl = 7
        'DeletShoghl = 3
        Cancel = 8
    End Enum


    Private Sub FrmNermoodarSazmani_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        SqlConnection1.ConnectionString = PConnectionString
        FormStatus = status.Cancel
        DATas_bas_tashkilat.Fill(DsFrmNermoodarSazmani1.tas_bas_tashkilat)
        DAtas_bas_radeh_sazemani.Fill(DsFrmNermoodarSazmani1.tas_bas_radeh_sazemani)
        Call EnableDisable(1)


    End Sub
    Private Sub FillDataSetVahed()
        If CmbTashkilat.Text = "" Then
            MsgFar("«» œ«  ‘òÌ·«  „Ê—œ ‰Ÿ— —« Ê«—œ ò‰Ìœ")
        Else
            Call FillDatasetPost()
            TreeVahed.Nodes.Clear()
            DsFrmNermoodarSazmani1.tas_bas_vahed.Clear()
            DATas_Bas_Vahed.SelectCommand.CommandText = "SELECT id_vahed, code_tashkilat, desc_vahed, code_master, code_radeh_sazemani, mahal_vahed, tel, remark, picture, code_bandar FROM tas_bas_vahed WHERE (code_tashkilat = @CodTashkilat) " & StrWhereRade & StrWhereVahed

            DATas_Bas_Vahed.SelectCommand.Parameters("@codtashkilat").Value = CmbTashkilat.SelectedValue
            DATas_Bas_Vahed.Fill(DsFrmNermoodarSazmani1.tas_bas_vahed)
        End If

    End Sub
    Private Sub FillDatasetPost()
            DsFrmNermoodarSazmani1.tas_tr_vahedha_mashaghel.Clear()
            DAtas_tr_vahedha_mashaghel.Fill(DsFrmNermoodarSazmani1.tas_tr_vahedha_mashaghel)
    End Sub
    Private Sub FillDatasetShoghl()
        If LblCodPost.Text.Trim.Length = 0 Then
            MsgFar("«» œ« Å”  „Ê—œ ‰Ÿ— —« «‰ Œ«» ò‰Ìœ")
        Else
            Try
                DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani.Clear()
                DAtas_tr_takhsis_postsazemani.SelectCommand.Parameters("@codpost").Value = LblCodPost.Text
                DAtas_tr_takhsis_postsazemani.Fill(DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani)

            Catch ex As Exception
                MsgBox(ex.Message)


            End Try
             End If


    End Sub
    Private Sub MakeTree()
        Call FillDataSetVahed()


        Dim NewNodevar As TreeNode
        NewNodevar = TreeVahed.Nodes.Add(CmbTashkilat.Text)
        NewNodevar.Tag = 0

        If DsFrmNermoodarSazmani1.tas_bas_vahed.Count > 0 Then
            Call MakeNode(0, TreeVahed.Nodes(0))
        End If



    End Sub
    Private Sub MakeNode(ByVal ParentIdParam As Integer, ByVal ParentNodeParam As TreeNode)
        Dim i As Integer = 0

        Dim dr() As DataRow
        dr = DsFrmNermoodarSazmani1.tas_bas_vahed.Select("code_master " & IIf(ParentIdParam = 0, " Is Null ", "=" & ParentIdParam))


        For i = 0 To dr.Length - 1
            Dim NewNodevar As TreeNode
            NewNodevar = ParentNodeParam.Nodes.Add(dr(i).Item("desc_vahed"))
            NewNodevar.Tag = dr(i).Item("id_vahed") 'DsFrmNermoodarSazmani1.tas_bas_vahed(i).id_vahed
            'NewNodevar.ImageIndex = 14
            Call MakeNode(dr(i).Item("id_vahed"), ParentNodeParam.Nodes(i))

        Next
        TreeVahed.ExpandAll()
    End Sub
    'Private Sub FindNodeInTree(ByVal NodeTagSearch As String)
    '    Dim NodIndex As String
    '    Dim NodTag As String
    '    Dim ONODES As TreeNode

    '    NodIndex = "x"
    '    For i As Integer = 1 To TreeVahed.Nodes.Count
    '        NodTag = TreeVahed.Nodes.Item(i).Tag
    '        If (NodTag = NodeTagSearch) Then
    '            NodIndex = i
    '            Exit For
    '        End If
    '    Next
    '    If NodIndex <> "x" Then
    '        ''TreeVahed.Nodes(NodIndex).selected = True
    '        'ONODES = TreeVahed.Nodes.Item(NodIndex)
    '        'TreeView.NOdeClick(ONODES)
    '        TreeVahed.Focus()
    '    End If
    'End Sub
    Private Sub SelectThisNodeId(ByVal ThisId As Decimal)
        If Not ThisSelectdedNode Is Nothing Then
            ThisSelectdedNode.BackColor = TreeVahed.BackColor
        End If
        ThisSelectdedNode = RecursiveFind(TreeVahed.Nodes(0), ThisId)
        If Not ThisSelectdedNode Is Nothing Then
            ThisSelectdedNode.BackColor = Color.LightBlue
            TreeVahed.SelectedNode = ThisSelectdedNode
        End If
    End Sub

    Private Function RecursiveFind(ByVal ThisNode As TreeNode, ByVal ThisId As Decimal) As TreeNode
        Dim i As Decimal
        ' RecursiveFind = AttachmentTreeView.Nodes(0)
        For i = 0 To ThisNode.GetNodeCount(False) - 1 '   Travels all childs
            'MsgBox(ThisNode.Nodes.Item(i).Text)
            If ThisNode.Nodes.Item(i).Tag = ThisId Then
                RecursiveFind = ThisNode.Nodes.Item(i)
                Exit For
            Else
                RecursiveFind = RecursiveFind(ThisNode.Nodes.Item(i), ThisId)
                If Not IsNothing(RecursiveFind) Then
                    Exit For
                End If
            End If
        Next
    End Function
    Private Sub EnablePnlVahed(ByVal status As Boolean)
        TxtOnvanVahed.Enabled = status
        CmbRadeSazmani.Enabled = status
        TxtTel.Enabled = status
        TxtMahalVahed.Enabled = status
        CommentVahed.ZEnabled = status
        PictureButton1.Enabled = status
        CmdCancelVahed.Enabled = status
        CmdSaveVahed.Enabled = status
    End Sub
    Private Sub EnablePnlpostSazmani(ByVal status As Boolean)
        TxtShomarePost.Enabled = status
        TxtOnvanPost.Enabled = status
        ShoghlName1.Enabled = status
        CommentPost.ZEnabled = status
        CommentVazaef.ZEnabled = status
        ChkActivePost.Enabled = status
        CmdCancelPost.Enabled = status
        CmdSavePost.Enabled = status
        CmdInsertPost.Enabled = status
        GrdPost.Enabled = status
    End Sub
    Private Sub EnableDisable(ByVal state As Byte)
        Select Case state
            Case 1 '''form load
                PnlTree.Enabled = False
                EnablePnlVahed(False)
                EnablePnlpostSazmani(False)
                PnlPostTakhsisy.Enabled = False
            Case 2 '''''cmbtashkilat submit   
                PnlTashkilat.Enabled = False
                PnlTree.Enabled = True
                EnablePnlVahed(False)
                EnablePnlpostSazmani(False)
                PnlPostTakhsisy.Enabled = False
            Case 3 ''''add/edit vahed
                PnlTree.Enabled = False
                EnablePnlVahed(True)
            Case 4 '''cancel vahed
                PnlTree.Enabled = True
                EnablePnlVahed(False)
            Case 5 '''Menu post
                PnlTree.Enabled = False
                EnablePnlpostSazmani(True)
                Pnlpost.Enabled = False
            Case 6  ''' save post
                Pnlpost.Enabled = False
                GrdPost.Enabled = True
            Case 7 '' cancel post
                PnlTree.Enabled = True
                EnablePnlpostSazmani(False)
                GrdPost.Enabled = True
            Case 8  '''add/update post
                Pnlpost.Enabled = True
                GrdPost.Enabled = False
            Case 9 '''Mnu shoghl takhsisi
                Call EnablePnlpostSazmani(False)
                PnlPostTakhsisy.Enabled = True
                PnlTakhsis.Enabled = True
            Case 10 '''Cancel Shoghl takhsisi
                EnablePnlpostSazmani(True)
                PnlPostTakhsisy.Enabled = False
                PnlTakhsis.Enabled = False
            Case 11 '''''Mnu shoghl eblaghi
                EnablePnlpostSazmani(False)
                PnlPostTakhsisy.Enabled = True
                PnlEblagh.Enabled = True
            Case 12  '''Cancel Shoghl eblaghi
                EnablePnlpostSazmani(True)
                PnlPostTakhsisy.Enabled = False
                PnlEblagh.Enabled = False
        End Select

    End Sub

    Private Sub CmbTashkilatOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbTashkilatOk.Click
        If CmbTashkilat.Text = "" Then
            MsgFar("«» œ«  ‘òÌ·«  „Ê—œ ‰Ÿ— —« Ê«—œ ò‰Ìœ")
        Else
            Call EnableDisable(2)
            Call MakeTree()
        End If

    End Sub

    Private Sub MnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnAdd.Click
        Call PAddNew(1)
    End Sub

    Private Sub MnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnUpdate.Click
        If TreeVahed.SelectedNode.Tag <> 0 Then
            Call PUpdate(1)
        Else
            MsgFar("—Ì‘Â ﬁ«»·  €ÌÌ— ‰Ì” ")
        End If


    End Sub

    Private Sub MnDelet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnDelet.Click
        If TreeVahed.SelectedNode.Tag <> 0 Then
            Call PDelet(1)
        Else
            MsgFar("—Ì‘Â ﬁ«»· Õ–› ‰Ì” ")

        End If
    End Sub

    Private Sub MnPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnPost.Click
        If IdVahed > 0 Then
            Call Filtertas_tr_vahedha_mashaghel()
            Call EnableDisable(5)
            LblVahedPost.Text = DescVahed
        Else
            MsgFar("«» œ« òœ Ê«Õœ „Ê—œ ‰Ÿ— —« «‰ Œ«» ò‰Ìœ")
        End If


    End Sub

    Private Sub TreeVahed_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeVahed.AfterSelect
        IdVahed = TreeVahed.SelectedNode.Tag
        DescVahed = TreeVahed.SelectedNode.Text
        'MsgBox(TreeVahed.SelectedNode.FullPath)
        If TreeVahed.SelectedNode.Tag <> 0 Then
            Call FillField(1)
            Call Filtertas_tr_vahedha_mashaghel()
        Else
            Call ClearFeild(1)

        End If
    End Sub
    Private Sub AddNewRowInTas_bas_vahed(ByVal NewCodVahed As String)
        Dim dr As DataRow
        dr = DsFrmNermoodarSazmani1.tas_bas_vahed.Newtas_bas_vahedRow
        dr("desc_vahed") = TxtOnvanVahed.Text & ""
        dr("code_radeh_sazemani") = CmbRadeSazmani.SelectedValue
        dr("tel") = TxtTel.Text & ""
        dr("mahal_vahed") = TxtMahalVahed.Text & ""
        dr("remark") = CommentVahed.Text & ""
        dr("picture") = PictureButton1.MyPicture
        dr("code_tashkilat") = CmbTashkilat.SelectedValue
        dr("code_bandar") = PubBandarNO
        DsFrmNermoodarSazmani1.tas_bas_vahed.Addtas_bas_vahedRow(dr)

        Dim NewNodevar As TreeNode
        NewNodevar = TreeVahed.Nodes.Add(TxtOnvanVahed.Text)
        NewNodevar.Tag = NewCodVahed

    End Sub
    Private Sub AddNewRowInTas_tr_vahedha_mashaghel()
        Dim dr As DataRow
        dr = DsFrmNermoodarSazmani1.tas_tr_vahedha_mashaghel.Newtas_tr_vahedha_mashaghelRow
        dr("somareh_post_sazemani") = TxtShomarePost.Text
        dr("desc_post_sazemani") = TxtOnvanPost.Text
        dr("id_vahed") = IdVahed
        dr("code_reshteh_shoghli") = ShoghlName1.ShoghlCode
        dr("shrah_vazaef") = CommentVazaef.Text
        dr("activate") = IIf(ChkActivePost.Checked, 1, 0)
        dr("remark") = CommentPost.Text
        dr("code_bandar") = PubBandarNO
        DsFrmNermoodarSazmani1.tas_tr_vahedha_mashaghel.Addtas_tr_vahedha_mashaghelRow(dr)

    End Sub
    Public Sub Filtertas_tr_vahedha_mashaghel()
        Dim DrGrdPost() As DataRow
        DrGrdPost = DsFrmNermoodarSazmani1.tas_tr_vahedha_mashaghel.Select("id_vahed = " & Qt(IdVahed))
        GrdPost.DataSource = DrGrdPost

    End Sub
    Private Sub FillField(ByVal kind As Byte)
        Select Case kind
            Case 1 '''vahed
                Dim dr() As DataRow
                dr = DsFrmNermoodarSazmani1.tas_bas_vahed.Select(" id_vahed = " & TreeVahed.SelectedNode.Tag)
                TxtOnvanVahed.Text = dr(0).Item("desc_vahed") & ""
                CmbRadeSazmani.SelectedValue = dr(0).Item("code_radeh_sazemani") & ""
                TxtTel.Text = dr(0).Item("tel") & ""
                TxtMahalVahed.Text = dr(0).Item("mahal_vahed") & ""
                CommentVahed.Text = dr(0).Item("remark") & ""
                PictureButton1.MyPicture = dr(0).Item("picture") ''IIf(IsNothing(dr(0).Item("picture")), System.DBNull.Value, dr(0).Item("picture"))
            Case 2 '''post
                Try
                    Dim Currentrow As GridEXRow = GrdPost.GetRow
                    If Currentrow.RowIndex < 0 Then
                        Call ClearFeild(2)
                    Else
                        Dim foundRow As DataRow = DsFrmNermoodarSazmani1.tas_tr_vahedha_mashaghel.FindBycode_post_sazemani(Currentrow.Cells("code_post_sazemani").Value)
                        LblCodPost.Text = foundRow.Item("code_post_sazemani") & ""
                        TxtShomarePost.Text = foundRow.Item("somareh_post_sazemani") & ""
                        TxtOnvanPost.Text = foundRow.Item("desc_post_sazemani") & ""
                        ShoghlName1.ShoghlCode = foundRow.Item("code_reshteh_shoghli") & ""
                        If foundRow.Item("activate") = 1 Then
                            ChkActivePost.Checked = True
                        Else
                            ChkActivePost.Checked = False
                        End If
                        CommentPost.Text = foundRow.Item("remark") & ""
                        CommentVazaef.Text = foundRow.Item("shrah_vazaef") & ""

                    End If

                Catch ex As Exception

                End Try

            Case 3 '''shoghltakhsisi
                If DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani.Count > 1 Then
                    MsgBox("")
                End If
                If DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani(0).code_personal_takhsis Is DBNull.Value Then
                    DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani(0).code_personal_takhsis = ""
                End If
                If DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani(0).date_takhsis Is DBNull.Value Then
                    DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani(0).date_takhsis = ""
                End If
                If DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani(0).code_personal_eblagh Is DBNull.Value Then
                    DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani(0).code_personal_eblagh = ""
                End If
                If DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani(0).date_eblagh Is DBNull.Value Then
                    DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani(0).date_eblagh = ""
                End If
                LblCodShoghl.Text = DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani(0).id_post & ""
                If DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani(0).code_personal_takhsis.Trim.Length > 0 Then
                    Employee_CodTakhsis.Code_Personal = DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani(0).code_personal_takhsis
                Else
                    Employee_CodTakhsis.Text = ""
                End If


                UcCalTakhsis.Text = DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani(0).date_takhsis & ""
                CommentShoghl.Text = DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani(0).remark & ""
                If DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani(0).code_personal_eblagh.Trim.Length > 0 Then
                    Employee_CodEblagh.Code_Personal = DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani(0).code_personal_eblagh
                Else
                    Employee_CodEblagh.Text = ""
                End If


                UcCalEblagh.Text = DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani(0).date_eblagh & ""

        End Select

    End Sub
    Private Sub ClearFeild(ByVal kind As Byte)
        Select Case kind
            Case 1 '''vahed
                TxtOnvanVahed.Text = ""
                'CmbRadeSazmani.SelectedValue = ""
                TxtTel.Text = ""
                TxtMahalVahed.Text = ""
                CommentVahed.Text = ""
                PictureButton1.MyPicture = Nothing
            Case 2 '''post
                TxtShomarePost.Text = ""
                TxtOnvanPost.Text = ""
                ShoghlName1.Text = ""
                CommentPost.Text = ""
                CommentVazaef.Text = ""
                ChkActivePost.Checked = True


            Case 3 '''shoghltakhsisi
                Employee_CodTakhsis.Code_Personal = 0
                UcCalTakhsis.Text = Format(Now(), "yyyy/mm/dd")
                CommentShoghl.Text = ""
            Case 4 ''shoghleblaghi
                Employee_CodEblagh.Code_Personal = 0
                UcCalEblagh.Text = Format(Now(), "yyyy/mm/dd")
                CommentShoghl.Text = ""
        End Select

    End Sub
    Private Function ControlEmptyField(ByVal kind As Byte) As Boolean
        ControlEmptyField = True
        Select Case kind
            Case 1 '''vahed
                If (TxtOnvanVahed.Text = "" Or CmbRadeSazmani.Text = "") Then
                    MsgFar("«» œ« «ÿ·«⁄«  ·«“„ —« Ê«—œ ò‰Ìœ")
                    ControlEmptyField = False
                    Exit Function
                End If
            Case 2 '''post
                If TxtShomarePost.Text = "" Or TxtOnvanPost.Text = "" Or ShoghlName1.Text = "" Then
                    MsgFar("«» œ« «ÿ·«⁄«  ·«“„ —« Ê«—œ ò‰Ìœ")
                    ControlEmptyField = False
                    Exit Function
                End If

            Case 3 '''shoghl
                ''If FormStatus = status.UpdateShoghl Then
                ''    CmdGeneral.CommandText = "select count(id_post) from tas_tr_takhsis_postsazemani where activate='1' and cod_personal_takhsis = " & Qt(Employee_CodTakhsis.Code_Personal)
                ''    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                ''        CmdGeneral.Connection.Open()
                ''    End If
                ''    If CmdGeneral.ExecuteScalar > 0 Then
                ''        MsgFar("»—«Ì Â— Å—”‰·  ‰Â« Ìò ‘€· „Ì  Ê«‰  Œ’Ì’ œ«œ ")
                ''        ControlEmptyField = False
                ''        Exit Function
                ''    End If
                ''    CmdGeneral.Connection.Close()
                ''End If




                ''If (Employee_CodTakhsis.Code_Personal.Trim.Length = 0 And UcCalTakhsis.Text = "") Then
                ''    If (Employee_CodEblagh.Code_Personal.Trim.Length = 0 And UcCalEblagh.Text = "") Then
                ''        MsgFar("«» œ« «ÿ·«⁄«  ·«“„ —« Ê«—œ ò‰Ìœ")
                ''        ControlEmptyField = False
                ''        Exit Function
                ''    End If
                ''End If
                If FormStatus = status.AddShoghlEblagh Then
                    If Employee_CodEblagh.Text.Trim.Length = 0 Or UcCalEblagh.Text = "" Then
                        MsgFar("«» œ« «ÿ·«⁄«  ·«“„ —« Ê«—œ ò‰Ìœ")
                        ControlEmptyField = False
                        Exit Function
                    End If
                Else
                    If Employee_CodTakhsis.Text.Trim.Length = 0 Or UcCalTakhsis.Text = "" Then
                        MsgFar("«» œ« «ÿ·«⁄«  ·«“„ —« Ê«—œ ò‰Ìœ")
                        ControlEmptyField = False
                        Exit Function
                    End If
                End If
        End Select

    End Function
    Private Sub PAddNew(ByVal kind As Byte)
        Select Case kind
            Case 1 '''vahed
                Call EnableDisable(3)
                Call ClearFeild(1)
                FormStatus = status.AddVahed
                PictureButton1.status = MainModule.WorkStates.AddNew
            Case 2 '''post
                Call EnableDisable(8)
                Call ClearFeild(2)
                FormStatus = status.AddPost

            Case 3 '''shoghlTakhsisi
                Call ClearFeild(3)
                FormStatus = status.AddShoghlTakhsis
            Case 4  '''shoghlEblaghi
                Call ClearFeild(4)
                FormStatus = status.AddShoghlEblagh
        End Select

    End Sub
    Private Sub PUpdate(ByVal kind As Byte)
        Select Case kind
            Case 1 '''vahed
                FormStatus = status.UpdateVahed
                Call EnableDisable(3)
                PictureButton1.status = MainModule.WorkStates.AddNew
            Case 2 '''post
                Call EnableDisable(8)
                FormStatus = status.UpdatePost

            Case 3 '''shoghl


                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = " UPDATE    tas_tr_takhsis_postsazemani" & _
                  " set  Activate = 0 " & _
                  " WHERE     code_post_sazemani = " & LblCodPost.Text

                Try
                    CmdGeneral.ExecuteNonQuery()

                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try



            Case 4

                If Not ControlEmptyField(3) Then
                    Exit Sub
                End If
                If DAtas_tr_takhsis_postsazemani.UpdateCommand.Connection.State <> ConnectionState.Open Then
                    DAtas_tr_takhsis_postsazemani.UpdateCommand.Connection.Open()
                End If
                With DAtas_tr_takhsis_postsazemani.UpdateCommand
                    .Parameters("@id_post").Value = LblCodShoghl.Text
                    '.Parameters("@codpost").Value = LblCodPost.Text
                    '.Parameters("@cod_personal_takhsis").Value = TxtShomarePost.Text
                    .Parameters("@cod_personal_eblagh").Value = Employee_CodEblagh.Text
                    '.Parameters("@activate").Value = IdVahed
                    '.Parameters("@date_takhsis").Value = ShoghlName1.ShoghlCode
                    .Parameters("@date_eblagh").Value = UcCalEblagh.Text
                    .Parameters("@remark").Value = CommentPost.Text
                    '.Parameters("@code_bandar").Value = Bandar
                    Try
                        .ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    .Connection.Close()
                End With
                'Call FillDatasetShoghl()
                'Call EnableDisable(10)

        End Select

    End Sub
    Private Sub PDelet(ByVal kind As Byte)


        Select Case kind
            Case 1 '''vahed
                Dim c1 As New FrmWhatDoForMenu
                c1.ShowFarMsg("¬Ì« «Ì‰ —òÊ—œ Õ–› ‘Êœø")
                If c1.DialogResult = DialogResult.OK Then
                    If DATas_Bas_Vahed.DeleteCommand.Connection.State <> ConnectionState.Open Then
                        DATas_Bas_Vahed.DeleteCommand.Connection.Open()
                    End If
                    With DATas_Bas_Vahed.DeleteCommand
                        .Parameters("@idvahed").Value = IdVahed

                        Try
                            .ExecuteNonQuery()
                        Catch ex As Exception
                            MsgFar("«„ò«‰ Õ–› «Ì‰ ‘«ŒÂ ÊÃÊœ ‰œ«—œ")
                        End Try
                    End With
                    Call MakeTree()
                End If
            Case 2 '''post
                Dim c1 As New FrmWhatDoForMenu
                c1.ShowFarMsg("¬Ì« «Ì‰ —òÊ—œ Õ–› ‘Êœø")
                If c1.DialogResult = DialogResult.OK Then
                    If DAtas_tr_vahedha_mashaghel.DeleteCommand.Connection.State <> ConnectionState.Open Then
                        DAtas_tr_vahedha_mashaghel.DeleteCommand.Connection.Open()
                    End If
                    With DAtas_tr_vahedha_mashaghel.DeleteCommand
                        .Parameters("@codpost").Value = LblCodPost.Text

                        Try
                            .ExecuteNonQuery()
                        Catch ex As Exception
                            MsgFar("«„ò«‰ Õ–› «Ì‰ ‘«ŒÂ ÊÃÊœ ‰œ«—œ")
                        End Try
                    End With
                    Call Filtertas_tr_vahedha_mashaghel()
                End If

            Case 3 '''shoghl
                If DAtas_tr_takhsis_postsazemani.DeleteCommand.Connection.State <> ConnectionState.Open Then
                    DAtas_tr_takhsis_postsazemani.DeleteCommand.Connection.Open()
                End If
                With DAtas_tr_takhsis_postsazemani.DeleteCommand
                    .Parameters("@idpost").Value = LblCodShoghl.Text

                    Try
                        .ExecuteNonQuery()
                    Catch ex As Exception
                        MsgFar("«„ò«‰ Õ–› «Ì‰ Å”  ÊÃÊœ ‰œ«—œ")
                    End Try
                End With

        End Select

    End Sub
    Private Sub PSave()
        Dim CodPrs As String
        Dim DatePrs As String
        Dim CodNewVahed As String
        Select Case FormStatus
            Case status.AddVahed
                If Not ControlEmptyField(1) Then
                    Exit Sub
                End If
                If DATas_Bas_Vahed.InsertCommand.Connection.State <> ConnectionState.Open Then
                    DATas_Bas_Vahed.InsertCommand.Connection.Open()
                End If
                With DATas_Bas_Vahed.InsertCommand
                    .Parameters("@code_tashkilat").Value = CmbTashkilat.SelectedValue
                    .Parameters("@desc_vahed").Value = TxtOnvanVahed.Text
                    .Parameters("@code_master").Value = IIf(IdVahed = 0, System.DBNull.Value, IdVahed)
                    .Parameters("@code_radeh_sazemani").Value = CmbRadeSazmani.SelectedValue
                    .Parameters("@mahal_vahed").Value = TxtMahalVahed.Text
                    .Parameters("@tel").Value = TxtTel.Text
                    .Parameters("@remark").Value = CommentVahed.Text
                    .Parameters("@picture").Value = IIf(IsNothing(PictureButton1.MyPicture), System.DBNull.Value, PictureButton1.MyPicture)
                    .Parameters("@code_bandar").Value = PubBandarNO
                    Try
                        CodNewVahed = .ExecuteScalar()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    .Connection.Close()
                End With

                FormStatus = status.Cancel

                Call AddNewRowInTas_bas_vahed(CodNewVahed)

                Call EnableDisable(4)


            Case status.UpdateVahed
                If Not ControlEmptyField(1) Then
                    Exit Sub
                End If
                If DATas_Bas_Vahed.UpdateCommand.Connection.State <> ConnectionState.Open Then
                    DATas_Bas_Vahed.UpdateCommand.Connection.Open()
                End If
                With DATas_Bas_Vahed.UpdateCommand
                    .Parameters("@idvahed").Value = IdVahed
                    .Parameters("@code_tashkilat").Value = CmbTashkilat.SelectedValue
                    .Parameters("@desc_vahed").Value = TxtOnvanVahed.Text
                    '.Parameters("@code_master").Value = IIf(CodMaster = 0, System.DBNull.Value, CodMaster)
                    .Parameters("@code_radeh_sazemani").Value = CmbRadeSazmani.SelectedValue
                    .Parameters("@mahal_vahed").Value = TxtMahalVahed.Text
                    .Parameters("@tel").Value = TxtTel.Text
                    .Parameters("@remark").Value = CommentVahed.Text
                    .Parameters("@picture").Value = IIf(IsNothing(PictureButton1.MyPicture), System.DBNull.Value, PictureButton1.MyPicture)
                    .Parameters("@code_bandar").Value = PubBandarNO
                    Try
                        '.ExecuteNonQuery()
                        PictureButton1.SavePicture(Cnn, "tas_bas_vahed", "picture", " where id_vahed = " & IdVahed)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    .Connection.Close()
                End With

                Call SelectThisNodeId(IdVahed)
                FormStatus = status.Cancel
                'Call MakeTree()
                Call EnableDisable(4)
            Case status.AddPost
                If Not ControlEmptyField(2) Then
                    Exit Sub
                End If
                CmdGeneral.CommandText = " SELECT     count(tas_tr_vahedha_mashaghel.code_post_sazemani) " & _
                      " FROM         tas_tr_vahedha_mashaghel INNER JOIN " & _
                      " tas_bas_vahed ON tas_tr_vahedha_mashaghel.id_vahed = tas_bas_vahed.id_vahed " & _
                      "where tas_tr_vahedha_mashaghel.somareh_post_sazemani = " & Qt(TxtShomarePost.Text) & " and   tas_bas_vahed.code_tashkilat = " & Qt(CmbTashkilat.SelectedValue)

                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                If CmdGeneral.ExecuteScalar > 0 Then
                    MsgFar("«Ì‰ ‘„«—Â Å”   ò—«—Ì «” ")
                    Exit Sub
                    CmdGeneral.Connection.Close()
                End If
                CmdGeneral.Connection.Close()
                If DAtas_tr_vahedha_mashaghel.InsertCommand.Connection.State <> ConnectionState.Open Then
                    DAtas_tr_vahedha_mashaghel.InsertCommand.Connection.Open()
                End If
                With DAtas_tr_vahedha_mashaghel.InsertCommand
                    .Parameters("@somareh_post_sazemani").Value = TxtShomarePost.Text
                    .Parameters("@desc_post_sazemani").Value = TxtOnvanPost.Text
                    .Parameters("@id_vahed").Value = IdVahed
                    .Parameters("@code_reshteh_shoghli").Value = ShoghlName1.ShoghlCode
                    .Parameters("@shrah_vazaef").Value = CommentVazaef.Text
                    .Parameters("@activate").Value = IIf(ChkActivePost.Checked, 1, 0)
                    .Parameters("@remark").Value = CommentPost.Text
                    .Parameters("@code_bandar").Value = PubBandarNO
                    Try
                        .ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    .Connection.Close()
                End With

                'Call Filtertas_tr_vahedha_mashaghel()
                Call AddNewRowInTas_tr_vahedha_mashaghel()
                Call EnableDisable(6)
                FormStatus = status.Cancel
            Case status.UpdatePost
                If Not ControlEmptyField(2) Then
                    Exit Sub
                End If
                CmdGeneral.CommandText = " SELECT     count(tas_tr_vahedha_mashaghel.code_post_sazemani) " & _
                     " FROM         tas_tr_vahedha_mashaghel INNER JOIN " & _
                     " tas_bas_vahed ON tas_tr_vahedha_mashaghel.id_vahed = tas_bas_vahed.id_vahed " & _
                     " where tas_tr_vahedha_mashaghel.somareh_post_sazemani = " & Qt(TxtShomarePost.Text) & " and   tas_bas_vahed.code_tashkilat = " & Qt(CmbTashkilat.SelectedValue) & _
                     " and tas_tr_vahedha_mashaghel.code_post_sazemani <> " & LblCodPost.Text

                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                If CmdGeneral.ExecuteScalar > 0 Then
                    MsgFar("«Ì‰ ‘„«—Â Å”   ò—«—Ì «” ")
                    Exit Sub
                    CmdGeneral.Connection.Close()
                End If
                CmdGeneral.Connection.Close()
                If DAtas_tr_vahedha_mashaghel.UpdateCommand.Connection.State <> ConnectionState.Open Then
                    DAtas_tr_vahedha_mashaghel.UpdateCommand.Connection.Open()
                End If
                With DAtas_tr_vahedha_mashaghel.UpdateCommand
                    .Parameters("@codpost").Value = LblCodPost.Text
                    .Parameters("@somareh_post_sazemani").Value = TxtShomarePost.Text
                    .Parameters("@desc_post_sazemani").Value = TxtOnvanPost.Text
                    .Parameters("@id_vahed").Value = IdVahed
                    .Parameters("@code_reshteh_shoghli").Value = ShoghlName1.ShoghlCode
                    .Parameters("@shrah_vazaef").Value = CommentVazaef.Text
                    .Parameters("@activate").Value = IIf(ChkActivePost.Checked, 1, 0)
                    .Parameters("@remark").Value = CommentPost.Text
                    .Parameters("@code_bandar").Value = PubBandarNO
                    Try
                        .ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    .Connection.Close()
                End With

                Call Filtertas_tr_vahedha_mashaghel()

                Call EnableDisable(6)
                FormStatus = status.Cancel
            Case status.AddShoghlTakhsis
                If Not ControlEmptyField(3) Then
                    Exit Sub
                End If
                If DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani.Count > 0 Then
                    CodPrs = DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani(0).code_personal_eblagh & ""
                    DatePrs = DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani(0).date_eblagh & ""
                End If
                If DAtas_tr_takhsis_postsazemani.InsertCommand.Connection.State <> ConnectionState.Open Then
                    DAtas_tr_takhsis_postsazemani.InsertCommand.Connection.Open()
                End If
                With DAtas_tr_takhsis_postsazemani.InsertCommand
                    .Parameters("@code_post_sazemani").Value = LblCodPost.Text
                    .Parameters("@code_personal_takhsis").Value = Employee_CodTakhsis.Code_Personal 'IIf(Employee_CodTakhsis.Code_Personal.Trim = "", System.DBNull.Value, Employee_CodTakhsis.Code_Personal)
                    .Parameters("@code_personal_eblagh").Value = IIf(CodPrs = "", System.DBNull.Value, CodPrs) ''IIf(Employee_CodEblagh.Code_Personal = "", System.DBNull.Value, Employee_CodEblagh.Code_Personal)
                    .Parameters("@activate").Value = IdVahed
                    .Parameters("@date_takhsis").Value = UcCalTakhsis.Text '' (Employee_CodTakhsis.Code_Personal.Trim = "", System.DBNull.Value, UcCalTakhsis.Text)
                    .Parameters("@date_eblagh").Value = IIf(DatePrs = "", System.DBNull.Value, DatePrs) ''IIf(Employee_CodEblagh.Code_Personal.Trim = "", System.DBNull.Value, UcCalEblagh.Text)
                    .Parameters("@remark").Value = CommentShoghl.Text
                    .Parameters("@code_bandar").Value = PubBandarNO
                    Try
                        .ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    .Connection.Close()
                End With
                Call FillDatasetShoghl()
                Call EnableDisable(10)
                FormStatus = status.Cancel
            Case status.AddShoghlEblagh
                If Not ControlEmptyField(3) Then
                    Exit Sub
                End If
                If DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani.Count > 0 Then
                    CodPrs = DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani(0).code_personal_takhsis & ""
                    DatePrs = DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani(0).date_takhsis & ""
                End If
                If DAtas_tr_takhsis_postsazemani.InsertCommand.Connection.State <> ConnectionState.Open Then
                    DAtas_tr_takhsis_postsazemani.InsertCommand.Connection.Open()
                End If
                With DAtas_tr_takhsis_postsazemani.InsertCommand
                    .Parameters("@code_post_sazemani").Value = LblCodPost.Text
                    .Parameters("@code_personal_takhsis").Value = IIf(CodPrs = "", System.DBNull.Value, CodPrs)  '' IIf(Employee_CodTakhsis.Code_Personal.Trim = "", System.DBNull.Value, Employee_CodTakhsis.Code_Personal)
                    .Parameters("@code_personal_eblagh").Value = Employee_CodEblagh.Code_Personal  ''IIf(Employee_CodEblagh.Code_Personal = "", System.DBNull.Value, Employee_CodEblagh.Code_Personal)
                    .Parameters("@activate").Value = IdVahed
                    .Parameters("@date_takhsis").Value = IIf(DatePrs = "", System.DBNull.Value, DatePrs) '' IIf(Employee_CodTakhsis.Code_Personal.Trim = "", System.DBNull.Value, UcCalTakhsis.Text)
                    .Parameters("@date_eblagh").Value = UcCalEblagh.Text '' IIf(Employee_CodEblagh.Code_Personal.Trim = "", System.DBNull.Value, UcCalEblagh.Text)
                    .Parameters("@remark").Value = CommentShoghl.Text
                    .Parameters("@code_bandar").Value = PubBandarNO
                    Try
                        .ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    .Connection.Close()
                End With
                Call FillDatasetShoghl()
                Call EnableDisable(10)
                FormStatus = status.Cancel
            Case status.UpdateShoghl

        End Select
    End Sub
    Private Sub CmdSaveVahed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSaveVahed.Click
        Call PSave()

    End Sub
    Private Sub CmdCancelVahed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancelVahed.Click
        FormStatus = status.Cancel
        Call EnableDisable(4)
    End Sub


    Private Sub CmdCancelPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancelPost.Click
        'DsFrmNermoodarSazmani1.tas_tr_vahedha_mashaghel.Clear()
        Call EnableDisable(7)
        Call ClearFeild(2)
        FormStatus = status.Cancel

    End Sub

    Private Sub CmdSavePost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSavePost.Click
        Call PSave()


    End Sub
    Private Sub CmdDeletPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If LblCodPost.Text = "" Then
            MsgFar("«» œ« Å”  „Ê—œ ‰Ÿ— —« «‰ Œ«» ò‰Ìœ")
        Else
            Call PDelet(2)
        End If
    End Sub

    Private Sub CmdUpdatePost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If LblCodPost.Text = "" Then
            MsgFar("«» œ« Å”  „Ê—œ ‰Ÿ— —« «‰ Œ«» ò‰Ìœ")
        Else
            Call PUpdate(2)
        End If


    End Sub

    Private Sub CmdInsertPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdInsertPost.Click
        Call PAddNew(2)
        CmdSavePost.Enabled = True
    End Sub
    Private Sub GrdPost_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdPost.SelectionChanged
        If DsFrmNermoodarSazmani1.tas_tr_vahedha_mashaghel.Count = 0 Then
            Exit Sub
        End If
        Call FillField(2)
    End Sub

    Private Sub MnAddPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnAddPost.Click
        Call PAddNew(2)
        CmdSavePost.Enabled = True
    End Sub

    Private Sub MnUpdatePost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnUpdatePost.Click
        If LblCodPost.Text = "" Then
            MsgFar("«» œ« Å”  „Ê—œ ‰Ÿ— —« «‰ Œ«» ò‰Ìœ")
        Else
            Call PUpdate(2)
        End If
        CmdSavePost.Enabled = True
    End Sub

    Private Sub MnDeletPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnDeletPost.Click
        If LblCodPost.Text = "" Then
            MsgFar("«» œ« Å”  „Ê—œ ‰Ÿ— —« «‰ Œ«» ò‰Ìœ")
        Else
            Call PDelet(2)
        End If
    End Sub

    Private Sub MnTakhsis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnTakhsis.Click
        LblVahedShoghl.Text = DescVahed
        LblOnvanPost.Text = TxtOnvanPost.Text
        Call FillDatasetShoghl()
        If DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani.Count > 0 Then
            Call FillField(3)

        Else
            Call ClearFeild(3)
            Call ClearFeild(4)
        End If
        Call EnableDisable(9)

    End Sub




    Private Sub BtnSabeghe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSabeghe.Click
        Dim f As New FrmShow
        Dim j As Integer
        f.IdPost = LblCodPost.Text
        f.Text = "Å”  " & LblOnvanPost.Text & " Ê«Õœ " & LblVahedShoghl.Text
        f.ShowDialog()

        'If f.f = 1 Then
        '    MsgBox("")

        'End If

    End Sub

    Private Sub BtnFindVahed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindVahed.Click
        Dim f As New FrmFind
        Dim dr() As DataRow
        f.KindForm = FrmFind.KindFind.FindVahed
        f.ShowDialog()

        If f.Id <> "x" Then
            If DsFrmNermoodarSazmani1.tas_bas_vahed.Count = 0 Then
                Call MakeTree()

            End If
            'dr.Clear(dr, 0, dr.Length)
            dr = DsFrmNermoodarSazmani1.tas_bas_vahed.Select("id_vahed = " & f.Id)
            If dr.Length > 0 Then
                TxtOnvanVahed.Text = dr(0).Item("desc_vahed") & ""
                CmbRadeSazmani.SelectedValue = dr(0).Item("code_radeh_sazemani")
                TxtTel.Text = dr(0).Item("tel") & ""
                TxtMahalVahed.Text = dr(0).Item("mahal_vahed") & ""
                CommentVahed.Text = dr(0).Item("remark") & ""
                PictureButton1.MyPicture = dr(0).Item("picture")
                IdVahed = dr(0).Item("id_vahed") & ""
                DescVahed = dr(0).Item("desc_vahed") & ""
                Call SelectThisNodeId(dr(0).Item("id_vahed"))
                Call EnableDisable(2)

            End If
        End If

    End Sub

    Private Sub BtnFindPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindPost.Click
        Dim f As New FrmFind
        Dim dr() As DataRow
        f.KindForm = FrmFind.KindFind.FindPost
        f.ShowDialog()

        If f.IdPost <> "x" Then
            If f.Id <> "x" Then
                If DsFrmNermoodarSazmani1.tas_bas_vahed.Count = 0 Then
                    Call MakeTree()

                End If
                'dr.Clear(dr, 0, dr.Length)
                dr = DsFrmNermoodarSazmani1.tas_bas_vahed.Select("id_vahed = " & f.Id)
                If dr.Length > 0 Then
                    TxtOnvanVahed.Text = dr(0).Item("desc_vahed") & ""
                    CmbRadeSazmani.SelectedValue = dr(0).Item("code_radeh_sazemani") & ""
                    TxtTel.Text = dr(0).Item("tel") & ""
                    TxtMahalVahed.Text = dr(0).Item("mahal_vahed") & ""
                    CommentVahed.Text = dr(0).Item("remark") & ""
                    PictureButton1.MyPicture = dr(0).Item("picture")
                    IdVahed = dr(0).Item("id_vahed") & ""
                    DescVahed = dr(0).Item("desc_vahed") & ""
                    Call SelectThisNodeId(dr(0).Item("id_vahed"))
                End If
                Call Filtertas_tr_vahedha_mashaghel()
                dr.Clear(dr, 0, dr.Length)
                dr = DsFrmNermoodarSazmani1.tas_tr_vahedha_mashaghel.Select("code_post_sazemani = " & f.IdPost)
                If dr.Length > 0 Then


                    LblCodPost.Text = dr(0).Item("code_post_sazemani") & ""
                    TxtShomarePost.Text = dr(0).Item("somareh_post_sazemani") & ""
                    TxtOnvanPost.Text = dr(0).Item("desc_post_sazemani") & ""
                    ShoghlName1.ShoghlCode = dr(0).Item("code_reshteh_shoghli") & ""
                    If dr(0).Item("activate") = 1 Then
                        ChkActivePost.Checked = True
                    Else
                        ChkActivePost.Checked = False
                    End If
                    CommentPost.Text = dr(0).Item("remark") & ""
                    CommentVazaef.Text = dr(0).Item("shrah_vazaef") & ""
                    Call EnableDisable(5)
                End If
            End If


        End If

    End Sub

    Private Sub BtnFindPerson_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFindPerson.Click
        Dim f As New FrmFind
        Dim dr() As DataRow

        f.KindForm = FrmFind.KindFind.FindPerson
        f.ShowDialog()
        If f.IdPerson <> "x" Then
            If f.IdPost <> "x" Then
                If f.Id <> "x" Then
                    If DsFrmNermoodarSazmani1.tas_bas_vahed.Count = 0 Then
                        Call MakeTree()
                    End If
                    'dr.Clear(dr, 0, dr.Length)
                    dr = DsFrmNermoodarSazmani1.tas_bas_vahed.Select("id_vahed = " & f.Id)
                    If dr.Length > 0 Then
                        TxtOnvanVahed.Text = dr(0).Item("desc_vahed") & ""
                        CmbRadeSazmani.SelectedValue = dr(0).Item("code_radeh_sazemani") & ""
                        TxtTel.Text = dr(0).Item("tel") & ""
                        TxtMahalVahed.Text = dr(0).Item("mahal_vahed") & ""
                        CommentVahed.Text = dr(0).Item("remark") & ""
                        PictureButton1.MyPicture = dr(0).Item("picture")
                        IdVahed = dr(0).Item("id_vahed") & ""
                        DescVahed = dr(0).Item("desc_vahed") & ""
                        Call SelectThisNodeId(dr(0).Item("id_vahed"))
                    End If
                    Call Filtertas_tr_vahedha_mashaghel()
                    dr.Clear(dr, 0, dr.Length)
                    dr = DsFrmNermoodarSazmani1.tas_tr_vahedha_mashaghel.Select("code_post_sazemani = " & f.IdPost)
                    If dr.Length > 0 Then


                        LblCodPost.Text = dr(0).Item("code_post_sazemani") & ""
                        TxtShomarePost.Text = dr(0).Item("somareh_post_sazemani") & ""
                        TxtOnvanPost.Text = dr(0).Item("desc_post_sazemani") & ""
                        ShoghlName1.ShoghlCode = dr(0).Item("code_reshteh_shoghli") & ""
                        If dr(0).Item("activate") = 1 Then
                            ChkActivePost.Checked = True
                        Else
                            ChkActivePost.Checked = False
                        End If
                        CommentPost.Text = dr(0).Item("remark") & ""
                        CommentVazaef.Text = dr(0).Item("shrah_vazaef") & ""

                    End If
                End If
            End If
            Call FillDatasetShoghl()
            dr.Clear(dr, 0, dr.Length)
            dr = DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani.Select("code_personal_takhsis = " & f.IdPerson)
            If dr.Length > 0 Then

                LblCodShoghl.Text = dr(0).Item("id_post") & ""
                Employee_CodTakhsis.Code_Personal = dr(0).Item("code_personal_takhsis") & ""
                If Not (dr(0).Item("code_personal_eblagh") Is DBNull.Value) Then
                    Employee_CodEblagh.Code_Personal = dr(0).Item("code_personal_eblagh") & ""
                    UcCalEblagh.Text = dr(0).Item("date_eblagh") & ""
                End If

                UcCalTakhsis.Text = dr(0).Item("date_takhsis") & ""
                CommentShoghl.Text = dr(0).Item("remark") & ""
                Call EnableDisable(9)
            End If
        End If
    End Sub


    Private Sub CmdMahdoodeVahed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdMahdoodeVahed.Click
        Dim f As New FrmMahdoodeh
        Dim dr() As DataRow
        f.KindForm = FrmMahdoodeh.KindMahdooeh.Vahed
        f.ShowDialog()

        If f.StrWhere.Trim.Length = 0 Then
            StrWhereVahed = ""
        Else
            StrWhereVahed = f.StrWhere
            dr = DsFrmNermoodarSazmani1.tas_bas_vahed.Select("id_vahed = " & StrWhereVahed)
            If dr.Length > 0 Then
                TxtOnvanVahed.Text = dr(0).Item("desc_vahed") & ""
                CmbRadeSazmani.SelectedValue = dr(0).Item("code_radeh_sazemani")
                TxtTel.Text = dr(0).Item("tel") & ""
                TxtMahalVahed.Text = dr(0).Item("mahal_vahed") & ""
                CommentVahed.Text = dr(0).Item("remark") & ""
                PictureButton1.MyPicture = dr(0).Item("picture")
                IdVahed = dr(0).Item("id_vahed") & ""
                DescVahed = dr(0).Item("desc_vahed") & ""
                Call SelectThisNodeId(dr(0).Item("id_vahed"))
            End If

        End If

    End Sub

    Private Sub CmdMahdoodeRade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdMahdoodeRade.Click
        Dim f As New FrmMahdoodeh

        f.KindForm = FrmMahdoodeh.KindMahdooeh.Radeh
        f.ShowDialog()

        If f.StrWhere.Trim.Length = 0 Then
            StrWhereRade = ""
        Else
            StrWhereRade = f.StrWhere
        End If
        'Call MakeTree()

    End Sub

    Private Sub CmdEblaghInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEblaghInsert.Click
        Call PAddNew(4)
        CmdEblaghCancel.Enabled = True
        CmdEblaghSave.Enabled = True
        Employee_CodEblagh.Enabled = True
        UcCalEblagh.Enabled = True
    End Sub

    Private Sub CmdEblaghCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEblaghCancel.Click
        If FormStatus = status.Cancel Then
            Call EnableDisable(12)
        Else
            FormStatus = status.Cancel
            If DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani.Count > 0 Then
                Call FillField(3)
            End If
            CmdEblaghCancel.Enabled = False
            CmdEblaghSave.Enabled = False
            Employee_CodEblagh.Enabled = False
            UcCalEblagh.Enabled = False
        End If

    End Sub

    Private Sub CmdEblaghSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEblaghSave.Click
        'Call PUpdate(3)

        'Call PAddNew(4)
        'Call ClearFeild(3)
        Call PSave()
        Call EnableDisable(12)
    End Sub
    Private Sub CmdTakhsisInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdTakhsisInsert.Click
        Call PAddNew(3)
        CmdTakhsisCancel.Enabled = True
        CmdTakhsisSave.Enabled = True
        Employee_CodTakhsis.Enabled = True
        UcCalTakhsis.Enabled = True
        FormStatus = status.AddShoghlTakhsis

    End Sub

    Private Sub CmdCancelShoghl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdTakhsisCancel.Click
        If FormStatus = status.Cancel Then
            Call EnableDisable(10)
        Else
            FormStatus = status.Cancel
            If DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani.Count > 0 Then
                Call FillField(3)
            End If

            'Call EnableDisable(10)
            CmdTakhsisCancel.Enabled = False
            CmdTakhsisSave.Enabled = False
            Employee_CodTakhsis.Enabled = False
            UcCalTakhsis.Enabled = False
        End If

    End Sub
    Private Sub CmdSaveShoghl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdTakhsisSave.Click
        If FormStatus = status.AddShoghlTakhsis Then
            Call PUpdate(3)
            Call PSave()
            Call PAddNew(3)
            'Call ClearFeild(3)
            'Call PSave()
            Call EnableDisable(10)
            FormStatus = status.Cancel
        End If

    End Sub

    'Private Sub ShoghlName1_NotFindCompanyName() Handles ShoghlName1.NotFindCompanyName
    '    ShoghlName1.ShoghlCode = 0

    'End Sub



    Private Sub MnEblagh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnEblagh.Click



        LblVahedShoghl.Text = DescVahed
        LblOnvanPost.Text = TxtOnvanPost.Text
        Call FillDatasetShoghl()
        If DsFrmNermoodarSazmani1.tas_tr_takhsis_postsazemani.Count > 0 Then
            Call FillField(3)

            Call EnableDisable(11)
        Else
            MsgFar("«» œ« Å”  «»·«€Ì —« Ê«—œ ò‰Ìœ")
        End If


    End Sub
    Private Sub LocationOfForm()
        'Dim PntForm As Point
        'Dim PntLocation As Point
        'Dim OControl As Control
        'Dim SizeForm As Size
        'OControl = GrdDetail

        'SizeForm.Width = MyFrmItemComments.Width
        'SizeForm.Height = MyFrmItemComments.Height
        'PntLocation.X = OControl.Location.X '+ oControl.Size.Width - sizeForm.Width
        'PntLocation.Y = OControl.Location.Y + OControl.Size.Height + 2 + ((e.Column.GridEX.Row() + 2) * GrdDetail.RootTable.RowHeight) - OControl.Size.Height - 1


        'PntForm = OControl.Parent.PointToScreen(PntLocation)
        'If PntForm.Y + SizeForm.Height > Screen.PrimaryScreen.Bounds.Height - 40 Then
        '    PntForm.Y = PntForm.Y - SizeForm.Height - GrdDetail.RootTable.RowHeight
        'End If
        'If (PntForm.X < 0) Then PntForm.X = 0
        'MyFrmItemComments.SetDesktopLocation(PntForm.X, PntForm.Y)
        'MyFrmItemComments.Left = PntForm.X
        'MyFrmItemComments.Top = PntForm.Y
    End Sub
    Private Sub CmdDeletEblagh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDeletShoghl.Click
        Call PUpdate(3)

    End Sub
End Class
