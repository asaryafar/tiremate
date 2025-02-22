Imports CommonClass
Public Class FrmUsers
    Inherits FrmBase
    Dim Status As WorkStates = mainmodule.WorkStates.Cancel
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
    Friend WithEvents ImgWork As System.Windows.Forms.ImageList
    Friend WithEvents CmGeneral As System.Windows.Forms.ContextMenu
    Friend WithEvents MAddNew As System.Windows.Forms.MenuItem
    Friend WithEvents MEdit As System.Windows.Forms.MenuItem
    Friend WithEvents MDelete As System.Windows.Forms.MenuItem
    Friend WithEvents MSave As System.Windows.Forms.MenuItem
    Friend WithEvents MCancel As System.Windows.Forms.MenuItem
    Friend WithEvents GRDMain As System.Windows.Forms.DataGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents AddNew As System.Windows.Forms.ToolBarButton
    Friend WithEvents Edit As System.Windows.Forms.ToolBarButton
    Friend WithEvents Delete As System.Windows.Forms.ToolBarButton
    Friend WithEvents Save As System.Windows.Forms.ToolBarButton
    Friend WithEvents Cancel As System.Windows.Forms.ToolBarButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbGroup As System.Windows.Forms.ComboBox
    Friend WithEvents TxtUserPassWord As System.Windows.Forms.TextBox
    Friend WithEvents TxtUserFamily As System.Windows.Forms.TextBox
    Friend WithEvents TxtUserName As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DsFrmUsers1 As UserAccess.DSFrmUsers
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DAUserGroup As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DAUsers As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn2 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TxtUserLogin As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ChkUserActivity As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CnnUserMDB As System.Data.OleDb.OleDbConnection
    Friend WithEvents CmdGeneralUserMDB As System.Data.OleDb.OleDbCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmUsers))
        Me.ImgWork = New System.Windows.Forms.ImageList(Me.components)
        Me.CmGeneral = New System.Windows.Forms.ContextMenu
        Me.MAddNew = New System.Windows.Forms.MenuItem
        Me.MEdit = New System.Windows.Forms.MenuItem
        Me.MDelete = New System.Windows.Forms.MenuItem
        Me.MSave = New System.Windows.Forms.MenuItem
        Me.MCancel = New System.Windows.Forms.MenuItem
        Me.GRDMain = New System.Windows.Forms.DataGrid
        Me.DsFrmUsers1 = New UserAccess.DSFrmUsers
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridBoolColumn2 = New System.Windows.Forms.DataGridBoolColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.AddNew = New System.Windows.Forms.ToolBarButton
        Me.Edit = New System.Windows.Forms.ToolBarButton
        Me.Delete = New System.Windows.Forms.ToolBarButton
        Me.Save = New System.Windows.Forms.ToolBarButton
        Me.Cancel = New System.Windows.Forms.ToolBarButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbGroup = New System.Windows.Forms.ComboBox
        Me.TxtUserPassWord = New System.Windows.Forms.TextBox
        Me.TxtUserLogin = New System.Windows.Forms.TextBox
        Me.TxtUserFamily = New System.Windows.Forms.TextBox
        Me.TxtUserName = New System.Windows.Forms.TextBox
        Me.CnnUserMDB = New System.Data.OleDb.OleDbConnection
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.DAUserGroup = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.DAUsers = New System.Data.OleDb.OleDbDataAdapter
        Me.CmdGeneralUserMDB = New System.Data.OleDb.OleDbCommand
        Me.ChkUserActivity = New Janus.Windows.EditControls.UICheckBox
        CType(Me.GRDMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmUsers1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImgWork
        '
        Me.ImgWork.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImgWork.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImgWork.ImageStream = CType(resources.GetObject("ImgWork.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgWork.TransparentColor = System.Drawing.Color.Transparent
        '
        'CmGeneral
        '
        Me.CmGeneral.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MAddNew, Me.MEdit, Me.MDelete, Me.MSave, Me.MCancel})
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
        'GRDMain
        '
        Me.GRDMain.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.GRDMain.AllowNavigation = False
        Me.GRDMain.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.GRDMain.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GRDMain.CaptionText = "˜ÇÑåÇí ÌÇÑí"
        Me.GRDMain.CaptionVisible = False
        Me.GRDMain.ContextMenu = Me.CmGeneral
        Me.GRDMain.DataMember = "Users"
        Me.GRDMain.DataSource = Me.DsFrmUsers1
        Me.GRDMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.GRDMain.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GRDMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GRDMain.Location = New System.Drawing.Point(0, 84)
        Me.GRDMain.Name = "GRDMain"
        Me.GRDMain.ReadOnly = True
        Me.GRDMain.RowHeadersVisible = False
        Me.GRDMain.RowHeaderWidth = 30
        Me.GRDMain.Size = New System.Drawing.Size(527, 171)
        Me.GRDMain.TabIndex = 130
        Me.GRDMain.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DsFrmUsers1
        '
        Me.DsFrmUsers1.DataSetName = "DSFrmUsers"
        Me.DsFrmUsers1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.GRDMain
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridBoolColumn1, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn4, Me.DataGridBoolColumn2, Me.DataGridTextBoxColumn7})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Users"
        Me.DataGridTableStyle1.RowHeadersVisible = False
        Me.DataGridTableStyle1.RowHeaderWidth = 30
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.MappingName = "UserId"
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "User Login"
        Me.DataGridTextBoxColumn1.MappingName = "UserLogin"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Name"
        Me.DataGridTextBoxColumn2.MappingName = "UserName"
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Family"
        Me.DataGridTextBoxColumn3.MappingName = "UserFamily"
        Me.DataGridTextBoxColumn3.Width = 140
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.FalseValue = False
        Me.DataGridBoolColumn1.HeaderText = "Active"
        Me.DataGridBoolColumn1.MappingName = "UserActiveFalg"
        Me.DataGridBoolColumn1.NullValue = CType(resources.GetObject("DataGridBoolColumn1.NullValue"), Object)
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 40
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.MappingName = "UserGroupId"
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "User Group"
        Me.DataGridTextBoxColumn4.MappingName = "UserGroupName"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridBoolColumn2
        '
        Me.DataGridBoolColumn2.FalseValue = False
        Me.DataGridBoolColumn2.HeaderText = "Group Active"
        Me.DataGridBoolColumn2.MappingName = "GroupActiveFlag"
        Me.DataGridBoolColumn2.NullValue = CType(resources.GetObject("DataGridBoolColumn2.NullValue"), Object)
        Me.DataGridBoolColumn2.TrueValue = True
        Me.DataGridBoolColumn2.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.MappingName = "UserPassword"
        Me.DataGridTextBoxColumn7.Width = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(527, 56)
        Me.Panel1.TabIndex = 129
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(260, 52)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Users Information"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(443, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 52)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.AddNew, Me.Edit, Me.Delete, Me.Save, Me.Cancel})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(65, 20)
        Me.ToolBar1.ContextMenu = Me.CmGeneral
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImgWork
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(527, 28)
        Me.ToolBar1.TabIndex = 128
        Me.ToolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
        '
        'AddNew
        '
        Me.AddNew.ImageIndex = 0
        Me.AddNew.Tag = "1"
        Me.AddNew.Text = "New"
        Me.AddNew.ToolTipText = "New (Ctrl+N)"
        '
        'Edit
        '
        Me.Edit.ImageIndex = 1
        Me.Edit.Tag = "2"
        Me.Edit.Text = "Edit"
        Me.Edit.ToolTipText = "Edit (Ctrl+E)"
        '
        'Delete
        '
        Me.Delete.ImageIndex = 2
        Me.Delete.Tag = "3"
        Me.Delete.Text = "Delete"
        Me.Delete.ToolTipText = "Delete (Ctrl+D)"
        '
        'Save
        '
        Me.Save.Enabled = False
        Me.Save.ImageIndex = 3
        Me.Save.Tag = "4"
        Me.Save.Text = "Save"
        Me.Save.ToolTipText = "Save (Ctrl+S)"
        '
        'Cancel
        '
        Me.Cancel.Enabled = False
        Me.Cancel.ImageIndex = 4
        Me.Cancel.Tag = "5"
        Me.Cancel.Text = "Cancel"
        Me.Cancel.ToolTipText = "Cancel (Ctrl+Z)"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 131
        Me.Button1.Text = "Button1"
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Location = New System.Drawing.Point(257, 287)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 21)
        Me.Label10.TabIndex = 143
        Me.Label10.Text = "Password :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Location = New System.Drawing.Point(9, 287)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 21)
        Me.Label9.TabIndex = 142
        Me.Label9.Text = "User Name :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(10, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 21)
        Me.Label3.TabIndex = 141
        Me.Label3.Text = "User Group :"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(252, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 21)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "Last Name :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(12, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 21)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "First Name :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbGroup
        '
        Me.CmbGroup.BackColor = System.Drawing.SystemColors.Info
        Me.CmbGroup.DataSource = Me.DsFrmUsers1.UserGroup
        Me.CmbGroup.DisplayMember = "UserGroupName"
        Me.CmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbGroup.Enabled = False
        Me.CmbGroup.Location = New System.Drawing.Point(77, 315)
        Me.CmbGroup.Name = "CmbGroup"
        Me.CmbGroup.Size = New System.Drawing.Size(167, 21)
        Me.CmbGroup.TabIndex = 4
        Me.CmbGroup.ValueMember = "UserGroupId"
        '
        'TxtUserPassWord
        '
        Me.TxtUserPassWord.BackColor = System.Drawing.SystemColors.Window
        Me.TxtUserPassWord.Enabled = False
        Me.TxtUserPassWord.Location = New System.Drawing.Point(318, 289)
        Me.TxtUserPassWord.MaxLength = 10
        Me.TxtUserPassWord.Name = "TxtUserPassWord"
        Me.TxtUserPassWord.PasswordChar = Microsoft.VisualBasic.ChrW(35)
        Me.TxtUserPassWord.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtUserPassWord.Size = New System.Drawing.Size(142, 20)
        Me.TxtUserPassWord.TabIndex = 3
        Me.TxtUserPassWord.Text = ""
        '
        'TxtUserLogin
        '
        Me.TxtUserLogin.BackColor = System.Drawing.SystemColors.Info
        Me.TxtUserLogin.Enabled = False
        Me.TxtUserLogin.Location = New System.Drawing.Point(77, 289)
        Me.TxtUserLogin.MaxLength = 10
        Me.TxtUserLogin.Name = "TxtUserLogin"
        Me.TxtUserLogin.Size = New System.Drawing.Size(167, 20)
        Me.TxtUserLogin.TabIndex = 2
        Me.TxtUserLogin.Text = ""
        '
        'TxtUserFamily
        '
        Me.TxtUserFamily.BackColor = System.Drawing.SystemColors.Window
        Me.TxtUserFamily.Enabled = False
        Me.TxtUserFamily.Location = New System.Drawing.Point(318, 264)
        Me.TxtUserFamily.MaxLength = 30
        Me.TxtUserFamily.Name = "TxtUserFamily"
        Me.TxtUserFamily.Size = New System.Drawing.Size(189, 20)
        Me.TxtUserFamily.TabIndex = 1
        Me.TxtUserFamily.Text = ""
        '
        'TxtUserName
        '
        Me.TxtUserName.BackColor = System.Drawing.SystemColors.Info
        Me.TxtUserName.Enabled = False
        Me.TxtUserName.Location = New System.Drawing.Point(77, 263)
        Me.TxtUserName.MaxLength = 20
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(165, 20)
        Me.TxtUserName.TabIndex = 0
        Me.TxtUserName.Text = ""
        '
        'CnnUserMDB
        '
        Me.CnnUserMDB.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Jet OLEDB:Database Password=;Data Source=""D:\TireMate\TireMate.mdb" & _
        """;Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provide" & _
        "r=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Exten" & _
        "ded Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:" & _
        "Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OL" & _
        "EDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Databas" & _
        "e=False"
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT GroupActiveFlag, UserGroupId, UserGroupName FROM UserGroup"
        Me.OleDbSelectCommand2.Connection = Me.CnnUserMDB
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO UserGroup(GroupActiveFlag, UserGroupName) VALUES (?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.CnnUserMDB
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("GroupActiveFlag", System.Data.OleDb.OleDbType.Boolean, 2, "GroupActiveFlag"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserGroupName", System.Data.OleDb.OleDbType.VarWChar, 30, "UserGroupName"))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE UserGroup SET GroupActiveFlag = ?, UserGroupName = ? WHERE (UserGroupId = " & _
        "?) AND (GroupActiveFlag = ?) AND (UserGroupName = ? OR ? IS NULL AND UserGroupNa" & _
        "me IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.CnnUserMDB
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("GroupActiveFlag", System.Data.OleDb.OleDbType.Boolean, 2, "GroupActiveFlag"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserGroupName", System.Data.OleDb.OleDbType.VarWChar, 30, "UserGroupName"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserGroupId", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserGroupId", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_GroupActiveFlag", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GroupActiveFlag", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserGroupName", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserGroupName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserGroupName1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserGroupName", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM UserGroup WHERE (UserGroupId = ?) AND (GroupActiveFlag = ?) AND (User" & _
        "GroupName = ? OR ? IS NULL AND UserGroupName IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.CnnUserMDB
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserGroupId", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserGroupId", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_GroupActiveFlag", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GroupActiveFlag", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserGroupName", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserGroupName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserGroupName1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserGroupName", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAUserGroup
        '
        Me.DAUserGroup.DeleteCommand = Me.OleDbDeleteCommand1
        Me.DAUserGroup.InsertCommand = Me.OleDbInsertCommand2
        Me.DAUserGroup.SelectCommand = Me.OleDbSelectCommand2
        Me.DAUserGroup.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "UserGroup", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GroupActiveFlag", "GroupActiveFlag"), New System.Data.Common.DataColumnMapping("UserGroupId", "UserGroupId"), New System.Data.Common.DataColumnMapping("UserGroupName", "UserGroupName")})})
        Me.DAUserGroup.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Users.DefaultStoreNo, Users.DefaultYear, Users.UserActiveFalg, Users.UserF" & _
        "amily, Users.UserGroupId, Users.UserId, Users.UserLogin, Users.UserName, Users.U" & _
        "serPassword, UserGroup.UserGroupName, UserGroup.GroupActiveFlag FROM (Users INNE" & _
        "R JOIN UserGroup ON Users.UserGroupId = UserGroup.UserGroupId)"
        Me.OleDbSelectCommand1.Connection = Me.CnnUserMDB
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Users(DefaultStoreNo, DefaultYear, UserActiveFalg, UserFamily, UserGr" & _
        "oupId, UserLogin, UserName, UserPassword) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.CnnUserMDB
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DefaultStoreNo", System.Data.OleDb.OleDbType.VarWChar, 2, "DefaultStoreNo"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DefaultYear", System.Data.OleDb.OleDbType.Integer, 0, "DefaultYear"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserActiveFalg", System.Data.OleDb.OleDbType.Boolean, 2, "UserActiveFalg"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserFamily", System.Data.OleDb.OleDbType.VarWChar, 30, "UserFamily"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserGroupId", System.Data.OleDb.OleDbType.Integer, 0, "UserGroupId"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserLogin", System.Data.OleDb.OleDbType.VarWChar, 10, "UserLogin"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserName", System.Data.OleDb.OleDbType.VarWChar, 20, "UserName"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserPassword", System.Data.OleDb.OleDbType.VarWChar, 10, "UserPassword"))
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE Users SET DefaultStoreNo = ?, DefaultYear = ?, UserActiveFalg = ?, UserFam" & _
        "ily = ?, UserGroupId = ?, UserLogin = ?, UserName = ?, UserPassword = ? WHERE (U" & _
        "serId = ?) AND (DefaultStoreNo = ? OR ? IS NULL AND DefaultStoreNo IS NULL) AND " & _
        "(DefaultYear = ? OR ? IS NULL AND DefaultYear IS NULL) AND (UserActiveFalg = ?) " & _
        "AND (UserFamily = ? OR ? IS NULL AND UserFamily IS NULL) AND (UserGroupId = ? OR" & _
        " ? IS NULL AND UserGroupId IS NULL) AND (UserLogin = ? OR ? IS NULL AND UserLogi" & _
        "n IS NULL) AND (UserName = ? OR ? IS NULL AND UserName IS NULL) AND (UserPasswor" & _
        "d = ? OR ? IS NULL AND UserPassword IS NULL)"
        Me.OleDbUpdateCommand2.Connection = Me.CnnUserMDB
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DefaultStoreNo", System.Data.OleDb.OleDbType.VarWChar, 2, "DefaultStoreNo"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DefaultYear", System.Data.OleDb.OleDbType.Integer, 0, "DefaultYear"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserActiveFalg", System.Data.OleDb.OleDbType.Boolean, 2, "UserActiveFalg"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserFamily", System.Data.OleDb.OleDbType.VarWChar, 30, "UserFamily"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserGroupId", System.Data.OleDb.OleDbType.Integer, 0, "UserGroupId"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserLogin", System.Data.OleDb.OleDbType.VarWChar, 10, "UserLogin"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserName", System.Data.OleDb.OleDbType.VarWChar, 20, "UserName"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserPassword", System.Data.OleDb.OleDbType.VarWChar, 10, "UserPassword"))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserId", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserId", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DefaultStoreNo", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DefaultStoreNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DefaultStoreNo1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DefaultStoreNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DefaultYear", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DefaultYear", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DefaultYear1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DefaultYear", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserActiveFalg", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserActiveFalg", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserFamily", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserFamily", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserFamily1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserFamily", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserGroupId", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserGroupId", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserGroupId1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserGroupId", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserLogin", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserLogin", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserLogin1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserLogin", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserName", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserName1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserPassword", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserPassword", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserPassword1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserPassword", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM Users WHERE (UserId = ?) AND (DefaultStoreNo = ? OR ? IS NULL AND Def" & _
        "aultStoreNo IS NULL) AND (DefaultYear = ? OR ? IS NULL AND DefaultYear IS NULL) " & _
        "AND (UserActiveFalg = ?) AND (UserFamily = ? OR ? IS NULL AND UserFamily IS NULL" & _
        ") AND (UserGroupId = ? OR ? IS NULL AND UserGroupId IS NULL) AND (UserLogin = ? " & _
        "OR ? IS NULL AND UserLogin IS NULL) AND (UserName = ? OR ? IS NULL AND UserName " & _
        "IS NULL) AND (UserPassword = ? OR ? IS NULL AND UserPassword IS NULL)"
        Me.OleDbDeleteCommand2.Connection = Me.CnnUserMDB
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserId", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserId", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DefaultStoreNo", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DefaultStoreNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DefaultStoreNo1", System.Data.OleDb.OleDbType.VarWChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DefaultStoreNo", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DefaultYear", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DefaultYear", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DefaultYear1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DefaultYear", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserActiveFalg", System.Data.OleDb.OleDbType.Boolean, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserActiveFalg", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserFamily", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserFamily", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserFamily1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserFamily", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserGroupId", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserGroupId", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserGroupId1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserGroupId", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserLogin", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserLogin", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserLogin1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserLogin", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserName", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserName1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserPassword", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserPassword", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_UserPassword1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UserPassword", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAUsers
        '
        Me.DAUsers.DeleteCommand = Me.OleDbDeleteCommand2
        Me.DAUsers.InsertCommand = Me.OleDbInsertCommand1
        Me.DAUsers.SelectCommand = Me.OleDbSelectCommand1
        Me.DAUsers.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Users", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("DefaultStoreNo", "DefaultStoreNo"), New System.Data.Common.DataColumnMapping("DefaultYear", "DefaultYear"), New System.Data.Common.DataColumnMapping("UserActiveFalg", "UserActiveFalg"), New System.Data.Common.DataColumnMapping("UserFamily", "UserFamily"), New System.Data.Common.DataColumnMapping("UserGroupId", "UserGroupId"), New System.Data.Common.DataColumnMapping("UserId", "UserId"), New System.Data.Common.DataColumnMapping("UserLogin", "UserLogin"), New System.Data.Common.DataColumnMapping("UserName", "UserName"), New System.Data.Common.DataColumnMapping("UserPassword", "UserPassword")})})
        Me.DAUsers.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'CmdGeneralUserMDB
        '
        Me.CmdGeneralUserMDB.CommandText = "INSERT INTO Users (DefaultStoreNo, DefaultYear, UserActiveFalg, UserFamily, UserG" & _
        "roupId, UserLogin, UserName, UserPassword) VALUES (PDefaultStoreNo, PDefaultYear" & _
        ", PUserActiveFalg, PUserFamily, PUserGroupId, PUserLogin, PUserName, PUserPasswo" & _
        "rd)"
        Me.CmdGeneralUserMDB.Connection = Me.CnnUserMDB
        '
        'ChkUserActivity
        '
        Me.ChkUserActivity.Location = New System.Drawing.Point(317, 320)
        Me.ChkUserActivity.Name = "ChkUserActivity"
        Me.ChkUserActivity.Size = New System.Drawing.Size(117, 17)
        Me.ChkUserActivity.TabIndex = 5
        Me.ChkUserActivity.Text = "Is this user Active ?"
        '
        'FrmUsers
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(527, 348)
        Me.ContextMenu = Me.CmGeneral
        Me.Controls.Add(Me.CmbGroup)
        Me.Controls.Add(Me.ChkUserActivity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtUserPassWord)
        Me.Controls.Add(Me.TxtUserLogin)
        Me.Controls.Add(Me.TxtUserFamily)
        Me.Controls.Add(Me.TxtUserName)
        Me.Controls.Add(Me.GRDMain)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmUsers"
        Me.Text = "Users"
        CType(Me.GRDMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmUsers1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CnnUserMDB.ConnectionString = PConnectionStringForUserMdb
        Call FillDataSets()
        AddHandler Me.BindingContext(DsFrmUsers1, "Users").PositionChanged, AddressOf Position_Changed
        Me.BindingContext(DsFrmUsers1, "Users").Position = Me.BindingContext(DsFrmUsers1, "Users").Count - 1
        Call AfterSaveOrCancel()
    End Sub
    Private Sub GRDMain_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRDMain.CurrentCellChanged
        Button1.Focus()
        GRDMain.Select(GRDMain.CurrentCell.RowNumber)
        GRDMain.Focus()
    End Sub
    Private Sub GRDMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRDMain.Click
        If GRDMain.CurrentCell.RowNumber > 0 Then
            GRDMain.Select(GRDMain.CurrentCell.RowNumber)
        End If
    End Sub
    Private Sub Position_Changed(ByVal sender As Object, ByVal e As EventArgs)
        Call FillField()
    End Sub
    Private Sub EnableField(ByVal instatus As Boolean)
        TxtUserFamily.Enabled = instatus
        TxtUserName.Enabled = instatus
        TxtUserPassWord.Enabled = instatus
        TxtUserLogin.Enabled = instatus
        ChkUserActivity.Enabled = instatus
        CmbGroup.Enabled = instatus
    End Sub
    Sub AfterSaveOrCancel()
        Call FillField()
        MSave.Enabled = False
        Save.Enabled = False
        MCancel.Enabled = False
        Cancel.Enabled = False
        AddNew.Enabled = True
        MAddNew.Enabled = True
        If GRDMain.VisibleRowCount > 0 Then
            Delete.Enabled = True
            MDelete.Enabled = True
            Edit.Enabled = True
            MEdit.Enabled = True
        Else
            Delete.Enabled = False
            MDelete.Enabled = False
            Edit.Enabled = False
            MEdit.Enabled = False
        End If
        Call EnableField(False)
        GRDMain.Enabled = True
        GRDMain.Focus()
    End Sub
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0
                Call PAddNew()
            Case 1
                Call PEdit()
            Case 2
                Call PDelete()
            Case 3
                Call PSave()
            Case 4
                Call PCancel()
        End Select
    End Sub
    Sub PAddNew()
        Status = MainModule.WorkStates.AddNew
        Call EnableField(True)
        TxtUserFamily.Clear()
        TxtUserName.Clear()
        TxtUserPassWord.Clear()
        TxtUserLogin.Clear()
        ChkUserActivity.Checked = True
        TxtUserName.Focus()
        AddNew.Enabled = False
        Delete.Enabled = False
        Edit.Enabled = False
        Cancel.Enabled = True
        MAddNew.Enabled = False
        MDelete.Enabled = False
        MEdit.Enabled = False
        MCancel.Enabled = True
        GRDMain.Enabled = False
    End Sub
    Sub PEdit()
        Status = MainModule.WorkStates.Edit
        Call EnableField(True)
        TxtUserName.Focus()
        AddNew.Enabled = False
        Delete.Enabled = False
        Edit.Enabled = False
        Cancel.Enabled = True
        MAddNew.Enabled = False
        MDelete.Enabled = False
        MEdit.Enabled = False
        MCancel.Enabled = True
        GRDMain.Enabled = False
    End Sub
    Sub PSave()
        Dim ChangeOK As Boolean = False
        Select Case Status
            Case MainModule.WorkStates.AddNew
                ChangeOK = PInsert()
            Case MainModule.WorkStates.Edit
                ChangeOK = PUpdate()
        End Select
        If ChangeOK Then
            Call AfterSaveOrCancel()
            If Status = MainModule.WorkStates.AddNew Then
                Call PAddNew()
            Else
                Status = MainModule.WorkStates.Save
            End If
        End If
    End Sub
    Private Function PInsert() As Boolean
        Dim thisrow As DataRow
        PInsert = True
        Try
            If CmdGeneralUserMDB.Connection.State <> ConnectionState.Open Then
                CmdGeneralUserMDB.Connection.Open()
            End If
            CmdGeneralUserMDB.CommandText = " INSERT INTO Users (DefaultStoreNo, DefaultYear, UserActiveFalg, UserFamily, UserGroupId, UserLogin, UserName, UserPassword) VALUES ('',0," & IIf(ChkUserActivity.Checked, 1, 0) & "," & Qt(TxtUserFamily.Text) & "," & CmbGroup.SelectedValue & "," & Qt(TxtUserLogin.Text) & "," & Qt(TxtUserName.Text) & "," & Qt(TxtUserPassWord.Text) & ")"
            CmdGeneralUserMDB.ExecuteNonQuery()
            CmdGeneralUserMDB.Connection.Close()
            Call FillDataSets()
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PInsert = False
        End Try
    End Function
    Private Function PUpdate() As Boolean
        Dim thisrow As DataRow, ThisPosition As Integer
        PUpdate = True
        Try
            ThisPosition = GRDMain.CurrentCell.RowNumber
            If CmdGeneralUserMDB.Connection.State <> ConnectionState.Open Then
                CmdGeneralUserMDB.Connection.Open()
            End If
            CmdGeneralUserMDB.CommandText = " Update Users SET UserActiveFalg = " & IIf(ChkUserActivity.Checked, 1, 0) & ", UserFamily = " & Qt(TxtUserFamily.Text) & ",UserGroupId = " & CmbGroup.SelectedValue & ", UserLogin = " & Qt(TxtUserLogin.Text) & " , UserName =" & Qt(TxtUserName.Text) & " , UserPassword = " & Qt(TxtUserPassWord.Text) & " WHERE UserId =" & GRDMain.Item(GRDMain.CurrentRowIndex, 0)
            CmdGeneralUserMDB.ExecuteNonQuery()
            CmdGeneralUserMDB.Connection.Close()
            Call FillDataSets()
            GRDMain.CurrentRowIndex = ThisPosition
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PUpdate = False
        End Try
    End Function
    Sub PDelete()
        Dim thisrow As DataRow, ThisPosition As Integer
        Dim c1 As New ClassWhatDo
        c1.ShowMsg("Are You Sure ?")
        If c1.Result = DialogResult.OK Then
            Try
                ThisPosition = GRDMain.CurrentCell.RowNumber
                If CmdGeneralUserMDB.Connection.State <> ConnectionState.Open Then
                    CmdGeneralUserMDB.Connection.Open()
                End If
                CmdGeneralUserMDB.CommandText = " Delete From Users WHERE UserId =" & GRDMain.Item(GRDMain.CurrentRowIndex, 0)
                CmdGeneralUserMDB.ExecuteNonQuery()
            Catch ex As System.Data.SqlClient.SqlException
                Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
                Call PubErrHandle(myErrors.Item(0).Number)
            Finally
                CmdGeneralUserMDB.Connection.Close()
                Call FillDataSets()
                Try
                    If ThisPosition < GRDMain.VisibleRowCount - 1 Then
                        GRDMain.CurrentRowIndex = ThisPosition
                        GRDMain.Select(ThisPosition)
                    Else
                        If GRDMain.VisibleRowCount > 0 Then
                            GRDMain.CurrentRowIndex = GRDMain.VisibleRowCount - 1
                            Call FillField()
                        End If
                    End If
                Catch ex As Exception
                End Try
            End Try
            Call AfterSaveOrCancel()
        End If
        Status = MainModule.WorkStates.Delete
    End Sub
    Sub PCancel()
        Call AfterSaveOrCancel()
        Status = MainModule.WorkStates.Cancel
        'Call FillField()
    End Sub
    Sub FillField()
        If GRDMain.VisibleRowCount > 0 Then
            Dim cr As Integer = GRDMain.CurrentCell.RowNumber
            With GRDMain
                TxtUserLogin.Text = Trim(.Item(cr, 1))
                TxtUserName.Text = Trim(.Item(cr, 2))
                TxtUserFamily.Text = Trim(.Item(cr, 3))
                ChkUserActivity.Checked = .Item(cr, 4)
                CmbGroup.SelectedValue = .Item(cr, 5)
                TxtUserPassWord.Text = Trim(.Item(cr, 8))
            End With
        End If
    End Sub
    Private Sub FillDataSets()
        DsFrmUsers1.Clear()
        DAUsers.Fill(DsFrmUsers1, "Users")
        DAUserGroup.Fill(DsFrmUsers1, "UserGroup")
    End Sub
    Private Sub TxtUserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUserName.TextChanged, TxtUserFamily.TextChanged, TxtUserPassWord.TextChanged, CmbGroup.SelectedIndexChanged, TxtUserLogin.TextChanged, ChkUserActivity.CheckedChanged, TxtUserLogin.TextChanged
        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
            If TxtUserName.Text.Trim.Length > 0 And TxtUserLogin.Text.Trim.Length > 0 And CmbGroup.SelectedValue > 0 Then
                Save.Enabled = True
                MSave.Enabled = True
            Else
                Save.Enabled = False
                MSave.Enabled = False
            End If
        End If
    End Sub
    Private Sub TxtUserLogin_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtUserLogin.Leave
        If TxtUserName.Text.Trim.Length = 0 Then
            TxtUserName.Text = TxtUserLogin.Text
        End If
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
End Class
