Imports CommonClass
Public Class FrmUserGroup
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DAUserGroup As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DsFrmUserGroup1 As UserAccess.DSFrmUserGroup
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents TxtUserGroupName As System.Windows.Forms.TextBox
    Friend WithEvents ChkGroupActivity As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CnnUserMDB As System.Data.OleDb.OleDbConnection
    Friend WithEvents CmdGeneralUserMDB As System.Data.OleDb.OleDbCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmUserGroup))
        Me.ImgWork = New System.Windows.Forms.ImageList(Me.components)
        Me.CmGeneral = New System.Windows.Forms.ContextMenu
        Me.MAddNew = New System.Windows.Forms.MenuItem
        Me.MEdit = New System.Windows.Forms.MenuItem
        Me.MDelete = New System.Windows.Forms.MenuItem
        Me.MSave = New System.Windows.Forms.MenuItem
        Me.MCancel = New System.Windows.Forms.MenuItem
        Me.GRDMain = New System.Windows.Forms.DataGrid
        Me.DsFrmUserGroup1 = New UserAccess.DSFrmUserGroup
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtUserGroupName = New System.Windows.Forms.TextBox
        Me.CnnUserMDB = New System.Data.OleDb.OleDbConnection
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.DAUserGroup = New System.Data.OleDb.OleDbDataAdapter
        Me.CmdGeneralUserMDB = New System.Data.OleDb.OleDbCommand
        Me.ChkGroupActivity = New Janus.Windows.EditControls.UICheckBox
        CType(Me.GRDMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmUserGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GRDMain.DataMember = "UserGroup"
        Me.GRDMain.DataSource = Me.DsFrmUserGroup1
        Me.GRDMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.GRDMain.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GRDMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GRDMain.Location = New System.Drawing.Point(0, 84)
        Me.GRDMain.Name = "GRDMain"
        Me.GRDMain.ReadOnly = True
        Me.GRDMain.RowHeadersVisible = False
        Me.GRDMain.RowHeaderWidth = 30
        Me.GRDMain.Size = New System.Drawing.Size(351, 171)
        Me.GRDMain.TabIndex = 130
        Me.GRDMain.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DsFrmUserGroup1
        '
        Me.DsFrmUserGroup1.DataSetName = "DSFrmUserGroup"
        Me.DsFrmUserGroup1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.GRDMain
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridBoolColumn1})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "UserGroup"
        Me.DataGridTableStyle1.RowHeadersVisible = False
        Me.DataGridTableStyle1.RowHeaderWidth = 30
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "UserGroupId"
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Group Name"
        Me.DataGridTextBoxColumn2.MappingName = "UserGroupName"
        Me.DataGridTextBoxColumn2.Width = 280
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.FalseValue = False
        Me.DataGridBoolColumn1.HeaderText = "Active"
        Me.DataGridBoolColumn1.MappingName = "GroupActiveFlag"
        Me.DataGridBoolColumn1.NullValue = CType(resources.GetObject("DataGridBoolColumn1.NullValue"), Object)
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 50
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
        Me.Panel1.Size = New System.Drawing.Size(351, 56)
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
        Me.Label6.Size = New System.Drawing.Size(230, 52)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "User Group Information"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(267, 0)
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
        Me.ToolBar1.Size = New System.Drawing.Size(351, 28)
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(4, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 21)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Group Name :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtUserGroupName
        '
        Me.TxtUserGroupName.BackColor = System.Drawing.SystemColors.Info
        Me.TxtUserGroupName.Enabled = False
        Me.TxtUserGroupName.Location = New System.Drawing.Point(75, 263)
        Me.TxtUserGroupName.MaxLength = 30
        Me.TxtUserGroupName.Name = "TxtUserGroupName"
        Me.TxtUserGroupName.Size = New System.Drawing.Size(248, 20)
        Me.TxtUserGroupName.TabIndex = 134
        Me.TxtUserGroupName.Text = ""
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
        'CmdGeneralUserMDB
        '
        Me.CmdGeneralUserMDB.CommandText = "INSERT INTO Users (DefaultStoreNo, DefaultYear, UserActiveFalg, UserFamily, UserG" & _
        "roupId, UserLogin, UserGroupName, UserPassword) VALUES (PDefaultStoreNo, PDefaul" & _
        "tYear, PUserActiveFalg, PUserFamily, PUserGroupId, PUserLogin, PUserGroupName, P" & _
        "UserPassword)"
        Me.CmdGeneralUserMDB.Connection = Me.CnnUserMDB
        '
        'ChkGroupActivity
        '
        Me.ChkGroupActivity.Location = New System.Drawing.Point(9, 289)
        Me.ChkGroupActivity.Name = "ChkGroupActivity"
        Me.ChkGroupActivity.Size = New System.Drawing.Size(142, 16)
        Me.ChkGroupActivity.TabIndex = 145
        Me.ChkGroupActivity.Text = "Is this group Active ?"
        '
        'FrmUserGroup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(351, 311)
        Me.ContextMenu = Me.CmGeneral
        Me.Controls.Add(Me.ChkGroupActivity)
        Me.Controls.Add(Me.TxtUserGroupName)
        Me.Controls.Add(Me.GRDMain)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmUserGroup"
        Me.Text = "User Group"
        CType(Me.GRDMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmUserGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmUserGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CnnUserMDB.ConnectionString = PConnectionStringForUserMdb
        Call FillDataSets()
        AddHandler Me.BindingContext(DsFrmUserGroup1, "UserGroup").PositionChanged, AddressOf Position_Changed
        Me.BindingContext(DsFrmUserGroup1, "UserGroup").Position = Me.BindingContext(DsFrmUserGroup1, "UserGroup").Count - 1
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
        TxtUserGroupName.Enabled = instatus
        ChkGroupActivity.Enabled = instatus
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
        TxtUserGroupName.Clear()
        ChkGroupActivity.Checked = True
        TxtUserGroupName.Focus()
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
        TxtUserGroupName.Focus()
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
            CmdGeneralUserMDB.CommandText = " INSERT INTO UserGroup (UserGroupName, GroupActiveFlag) VALUES (" & Qt(TxtUserGroupName.Text) & "," & IIf(ChkGroupActivity.Checked, 1, 0) & ")"
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
            CmdGeneralUserMDB.CommandText = "Update UserGroup SET GroupActiveFlag = " & IIf(ChkGroupActivity.Checked, 1, 0) & ", UserGroupName =" & Qt(TxtUserGroupName.Text) & " WHERE UserGroupId =" & GRDMain.Item(GRDMain.CurrentRowIndex, 0)
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
                CmdGeneralUserMDB.CommandText = " Delete From UserGroup WHERE UserGroupId =" & GRDMain.Item(GRDMain.CurrentRowIndex, 0)
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
                TxtUserGroupName.Text = Trim(.Item(cr, 1))
                ChkGroupActivity.Checked = .Item(cr, 2)
            End With
        End If
    End Sub
    Private Sub FillDataSets()
        DsFrmUserGroup1.Clear()
        DAUserGroup.Fill(DsFrmUserGroup1, "UserGroup")
    End Sub
    Private Sub TxtUserGroupName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUserGroupName.TextChanged, ChkGroupActivity.CheckedChanged
        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
            If TxtUserGroupName.Text.Trim.Length > 0 Then
                Save.Enabled = True
                MSave.Enabled = True
            Else
                Save.Enabled = False
                MSave.Enabled = False
            End If
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
