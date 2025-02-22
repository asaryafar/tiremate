Imports CommonClass
Public Class FrmUserFavoriteMenu
    Inherits FrmBase
    Private temp As Integer = 0
    Private Check_NodesFlag As Boolean = True
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
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DaMainMenu As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbInsertCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbSelectCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DaUsers As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents LblUserName As System.Windows.Forms.Label
    Friend WithEvents CmbUser As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DAUserAccess As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents BtnCollapseAll As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnExpandAll As Janus.Windows.EditControls.UIButton
    Friend WithEvents CnnUserMDB As System.Data.OleDb.OleDbConnection
    Friend WithEvents CnnMenuMDB As System.Data.OleDb.OleDbConnection
    Friend WithEvents CmdGeneralForUserMDB As System.Data.OleDb.OleDbCommand
    Friend WithEvents CmdGeneralForMenuMDB As System.Data.OleDb.OleDbCommand
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents DsFrmUserFavoriteMenu1 As UserAccess.DSFrmUserFavoriteMenu
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmUserFavoriteMenu))
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.BtnCollapseAll = New Janus.Windows.EditControls.UIButton
        Me.BtnExpandAll = New Janus.Windows.EditControls.UIButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.CmdGeneralForUserMDB = New System.Data.OleDb.OleDbCommand
        Me.CnnUserMDB = New System.Data.OleDb.OleDbConnection
        Me.DaMainMenu = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbInsertCommand3 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand
        Me.CnnMenuMDB = New System.Data.OleDb.OleDbConnection
        Me.OleDbUpdateCommand3 = New System.Data.OleDb.OleDbCommand
        Me.DaUsers = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand
        Me.LblUserName = New System.Windows.Forms.Label
        Me.CmbUser = New System.Windows.Forms.ComboBox
        Me.DsFrmUserFavoriteMenu1 = New UserAccess.DSFrmUserFavoriteMenu
        Me.Label1 = New System.Windows.Forms.Label
        Me.DAUserAccess = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand
        Me.CmdGeneralForMenuMDB = New System.Data.OleDb.OleDbCommand
        Me.Panel2.SuspendLayout()
        CType(Me.DsFrmUserFavoriteMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TreeView1.ImageIndex = -1
        Me.TreeView1.Location = New System.Drawing.Point(0, 84)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = -1
        Me.TreeView1.Size = New System.Drawing.Size(510, 353)
        Me.TreeView1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BtnCollapseAll)
        Me.Panel2.Controls.Add(Me.BtnExpandAll)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(510, 48)
        Me.Panel2.TabIndex = 196
        '
        'BtnCollapseAll
        '
        Me.BtnCollapseAll.Location = New System.Drawing.Point(331, 13)
        Me.BtnCollapseAll.Name = "BtnCollapseAll"
        Me.BtnCollapseAll.Size = New System.Drawing.Size(77, 21)
        Me.BtnCollapseAll.TabIndex = 36
        Me.BtnCollapseAll.Text = "Collapse All"
        '
        'BtnExpandAll
        '
        Me.BtnExpandAll.Location = New System.Drawing.Point(424, 13)
        Me.BtnExpandAll.Name = "BtnExpandAll"
        Me.BtnExpandAll.Size = New System.Drawing.Size(77, 21)
        Me.BtnExpandAll.TabIndex = 35
        Me.BtnExpandAll.Text = "Expand All"
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(88, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(229, 46)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "This Changes will affect next time you enter the system "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(88, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'CmdGeneralForUserMDB
        '
        Me.CmdGeneralForUserMDB.CommandText = "SELECT FormName, Item_large_icon, Item_small_icon, Itemdesc, ItemKey, ItemKind, I" & _
        "temToolTip, MasterGroup, MasterItem, UserId FROM UserFavorite"
        Me.CmdGeneralForUserMDB.Connection = Me.CnnUserMDB
        '
        'CnnUserMDB
        '
        Me.CnnUserMDB.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Jet OLEDB:Database Password=;Data Source=""D:\Toosab.net\Toosab.mdb" & _
        """;Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provide" & _
        "r=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Exten" & _
        "ded Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:" & _
        "Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OL" & _
        "EDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Databas" & _
        "e=False"
        '
        'DaMainMenu
        '
        Me.DaMainMenu.InsertCommand = Me.OleDbInsertCommand3
        Me.DaMainMenu.SelectCommand = Me.OleDbSelectCommand3
        Me.DaMainMenu.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Items", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("FormName", "FormName"), New System.Data.Common.DataColumnMapping("Item_large_icon", "Item_large_icon"), New System.Data.Common.DataColumnMapping("Item_small_icon", "Item_small_icon"), New System.Data.Common.DataColumnMapping("Itemdesc", "Itemdesc"), New System.Data.Common.DataColumnMapping("ItemKey", "ItemKey"), New System.Data.Common.DataColumnMapping("ItemKind", "ItemKind"), New System.Data.Common.DataColumnMapping("ItemToolTip", "ItemToolTip"), New System.Data.Common.DataColumnMapping("MasterGroup", "MasterGroup"), New System.Data.Common.DataColumnMapping("MasterItem", "MasterItem")})})
        Me.DaMainMenu.UpdateCommand = Me.OleDbUpdateCommand3
        '
        'OleDbInsertCommand3
        '
        Me.OleDbInsertCommand3.CommandText = "INSERT INTO Items(FormName, Item_large_icon, Item_small_icon, Itemdesc, ItemKey, " & _
        "ItemKind, ItemToolTip, MasterGroup, MasterItem) VALUES (?, ?, ?, ?, ?, ?, ?, ?, " & _
        "?)"
        Me.OleDbInsertCommand3.Connection = Me.CnnUserMDB
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("FormName", System.Data.OleDb.OleDbType.VarWChar, 50, "FormName"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Item_large_icon", System.Data.OleDb.OleDbType.Integer, 0, "Item_large_icon"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Item_small_icon", System.Data.OleDb.OleDbType.Integer, 0, "Item_small_icon"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Itemdesc", System.Data.OleDb.OleDbType.VarWChar, 50, "Itemdesc"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ItemKey", System.Data.OleDb.OleDbType.Integer, 0, "ItemKey"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ItemKind", System.Data.OleDb.OleDbType.Integer, 0, "ItemKind"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ItemToolTip", System.Data.OleDb.OleDbType.VarWChar, 50, "ItemToolTip"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("MasterGroup", System.Data.OleDb.OleDbType.VarWChar, 50, "MasterGroup"))
        Me.OleDbInsertCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("MasterItem", System.Data.OleDb.OleDbType.Integer, 0, "MasterItem"))
        '
        'OleDbSelectCommand3
        '
        Me.OleDbSelectCommand3.CommandText = "SELECT FormName, Item_large_icon, Item_small_icon, Itemdesc, ItemKey, ItemKind, I" & _
        "temToolTip, MasterGroup, MasterItem FROM Items"
        Me.OleDbSelectCommand3.Connection = Me.CnnMenuMDB
        '
        'CnnMenuMDB
        '
        Me.CnnMenuMDB.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Jet OLEDB:Database Password=;Data Source=""D:\Toosab.net\Toosab.mdb" & _
        """;Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provide" & _
        "r=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Exten" & _
        "ded Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:" & _
        "Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OL" & _
        "EDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Databas" & _
        "e=False"
        '
        'OleDbUpdateCommand3
        '
        Me.OleDbUpdateCommand3.CommandText = "UPDATE Items SET FormName = ?, Item_large_icon = ?, Item_small_icon = ?, Itemdesc" & _
        " = ?, ItemKey = ?, ItemKind = ?, ItemToolTip = ?, MasterGroup = ?, MasterItem = " & _
        "? WHERE (ItemKey = ?) AND (FormName = ? OR ? IS NULL AND FormName IS NULL) AND (" & _
        "ItemKind = ? OR ? IS NULL AND ItemKind IS NULL) AND (ItemToolTip = ? OR ? IS NUL" & _
        "L AND ItemToolTip IS NULL) AND (Item_large_icon = ? OR ? IS NULL AND Item_large_" & _
        "icon IS NULL) AND (Item_small_icon = ? OR ? IS NULL AND Item_small_icon IS NULL)" & _
        " AND (Itemdesc = ? OR ? IS NULL AND Itemdesc IS NULL) AND (MasterGroup = ? OR ? " & _
        "IS NULL AND MasterGroup IS NULL) AND (MasterItem = ? OR ? IS NULL AND MasterItem" & _
        " IS NULL)"
        Me.OleDbUpdateCommand3.Connection = Me.CnnUserMDB
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("FormName", System.Data.OleDb.OleDbType.VarWChar, 50, "FormName"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Item_large_icon", System.Data.OleDb.OleDbType.Integer, 0, "Item_large_icon"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Item_small_icon", System.Data.OleDb.OleDbType.Integer, 0, "Item_small_icon"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Itemdesc", System.Data.OleDb.OleDbType.VarWChar, 50, "Itemdesc"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ItemKey", System.Data.OleDb.OleDbType.Integer, 0, "ItemKey"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ItemKind", System.Data.OleDb.OleDbType.Integer, 0, "ItemKind"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("ItemToolTip", System.Data.OleDb.OleDbType.VarWChar, 50, "ItemToolTip"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("MasterGroup", System.Data.OleDb.OleDbType.VarWChar, 50, "MasterGroup"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("MasterItem", System.Data.OleDb.OleDbType.Integer, 0, "MasterItem"))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ItemKey", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ItemKey", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FormName", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_FormName1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FormName", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ItemKind", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ItemKind", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ItemKind1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ItemKind", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ItemToolTip", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ItemToolTip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ItemToolTip1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ItemToolTip", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Item_large_icon", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Item_large_icon", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Item_large_icon1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Item_large_icon", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Item_small_icon", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Item_small_icon", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Item_small_icon1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Item_small_icon", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Itemdesc", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Itemdesc", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Itemdesc1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Itemdesc", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MasterGroup", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MasterGroup", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MasterGroup1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MasterGroup", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MasterItem", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MasterItem", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand3.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MasterItem1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MasterItem", System.Data.DataRowVersion.Original, Nothing))
        '
        'DaUsers
        '
        Me.DaUsers.DeleteCommand = Me.OleDbDeleteCommand2
        Me.DaUsers.InsertCommand = Me.OleDbInsertCommand2
        Me.DaUsers.SelectCommand = Me.OleDbSelectCommand2
        Me.DaUsers.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Users", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("DefaultStoreNo", "DefaultStoreNo"), New System.Data.Common.DataColumnMapping("DefaultYear", "DefaultYear"), New System.Data.Common.DataColumnMapping("UserActiveFalg", "UserActiveFalg"), New System.Data.Common.DataColumnMapping("UserFamily", "UserFamily"), New System.Data.Common.DataColumnMapping("UserGroupId", "UserGroupId"), New System.Data.Common.DataColumnMapping("UserId", "UserId"), New System.Data.Common.DataColumnMapping("UserLogin", "UserLogin"), New System.Data.Common.DataColumnMapping("UserName", "UserName"), New System.Data.Common.DataColumnMapping("UserPassword", "UserPassword")})})
        Me.DaUsers.UpdateCommand = Me.OleDbUpdateCommand2
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
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO Users(DefaultStoreNo, DefaultYear, UserActiveFalg, UserFamily, UserGr" & _
        "oupId, UserLogin, UserName, UserPassword) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.CnnUserMDB
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DefaultStoreNo", System.Data.OleDb.OleDbType.VarWChar, 2, "DefaultStoreNo"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("DefaultYear", System.Data.OleDb.OleDbType.Integer, 0, "DefaultYear"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserActiveFalg", System.Data.OleDb.OleDbType.Boolean, 2, "UserActiveFalg"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserFamily", System.Data.OleDb.OleDbType.VarWChar, 30, "UserFamily"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserGroupId", System.Data.OleDb.OleDbType.Integer, 0, "UserGroupId"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserLogin", System.Data.OleDb.OleDbType.VarWChar, 10, "UserLogin"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserName", System.Data.OleDb.OleDbType.VarWChar, 20, "UserName"))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("UserPassword", System.Data.OleDb.OleDbType.VarWChar, 10, "UserPassword"))
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT UserId, UserLogin FROM Users Order by UserLogin"
        Me.OleDbSelectCommand2.Connection = Me.CnnUserMDB
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
        'LblUserName
        '
        Me.LblUserName.BackColor = System.Drawing.SystemColors.Control
        Me.LblUserName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblUserName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblUserName.Location = New System.Drawing.Point(184, 58)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(309, 18)
        Me.LblUserName.TabIndex = 199
        Me.LblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmbUser
        '
        Me.CmbUser.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.CmbUser.DataSource = Me.DsFrmUserFavoriteMenu1.Users
        Me.CmbUser.DisplayMember = "UserLogin"
        Me.CmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbUser.Location = New System.Drawing.Point(38, 57)
        Me.CmbUser.Name = "CmbUser"
        Me.CmbUser.Size = New System.Drawing.Size(143, 21)
        Me.CmbUser.TabIndex = 197
        Me.CmbUser.ValueMember = "UserId"
        '
        'DsFrmUserFavoriteMenu1
        '
        Me.DsFrmUserFavoriteMenu1.DataSetName = "DSFrmUserFavoriteMenu"
        Me.DsFrmUserFavoriteMenu1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 198
        Me.Label1.Text = "User :"
        '
        'DAUserAccess
        '
        Me.DAUserAccess.SelectCommand = Me.OleDbCommand1
        Me.DAUserAccess.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "UserAccress", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ItemKey", "ItemKey"), New System.Data.Common.DataColumnMapping("UserId", "UserId")})})
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = "SELECT COUNT(*) AS aa FROM UserAccess"
        Me.OleDbCommand1.Connection = Me.CnnUserMDB
        '
        'CmdGeneralForMenuMDB
        '
        Me.CmdGeneralForMenuMDB.CommandText = "SELECT FormName, Item_large_icon, Item_small_icon, Itemdesc, ItemKey, ItemKind, I" & _
        "temToolTip, MasterGroup, MasterItem, UserId FROM UserFavorite"
        Me.CmdGeneralForMenuMDB.Connection = Me.CnnMenuMDB
        '
        'FrmUserFavoriteMenu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(510, 437)
        Me.Controls.Add(Me.LblUserName)
        Me.Controls.Add(Me.CmbUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TreeView1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmUserFavoriteMenu"
        Me.Text = "User Favorite"
        Me.Panel2.ResumeLayout(False)
        CType(Me.DsFrmUserFavoriteMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmGroupMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CnnUserMDB.ConnectionString = PConnectionStringForUserMdb
            CnnUserMDB.Open()
        Catch ex As Exception
        End Try
        Try
            CnnMenuMDB.ConnectionString = PConnectionStringForMenuMdb
            CnnMenuMDB.Open()
        Catch ex As Exception
        End Try
        Dim Dr As DataRow
        DsFrmUserFavoriteMenu1.Clear()
        DaUsers.Fill(DsFrmUserFavoriteMenu1, "users")
        DaMainMenu.Fill(DsFrmUserFavoriteMenu1, "Items")
        TreeView1.CheckBoxes = True

        CmbUser.SelectedValue = PUserCod
        CmbUser.Enabled = False
        'CmbUser_SelectedIndexChanged(sender, e)

        If CmbUser.Text.Trim.Length > 0 Then
            Call StartMakeNode()
        End If
    End Sub
    Private Sub MakeTree(ByVal ThisTree As TreeNode, ByVal ThisDataTable As DataTable, ByVal ThisIdParent As Integer)
        Dim i As Integer
        Dim DV As New DataView
        With DV
            .Table = DsFrmUserFavoriteMenu1.Items
            .RowFilter = "MasterItem = '" & ThisIdParent & "'" '& "'"
        End With
        If DV.Count >= 0 Then
            For i = 0 To DV.Count - 1
                Dim MyTreeNode As New TreeNode(DV.Item(i).Item("Itemdesc"))
                ThisTree.Nodes.Add(MyTreeNode)
                MyTreeNode.Tag = DV.Item(i).Item("ItemKey")
                If IsFavoriteForThisUser(CmbUser.SelectedValue, DV.Item(i).Item("ItemKey")) Then
                    MyTreeNode.Checked = True
                    Call CheckParents(MyTreeNode.Parent, True)
                Else
                    MyTreeNode.Checked = False
                End If
                Call MakeTree(MyTreeNode, DsFrmUserFavoriteMenu1.Items, DV.Item(i).Item("ItemKey"))
            Next
        End If
    End Sub
    Private Sub TreeView1_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterCheck
        Me.Cursor = Cursors.WaitCursor
        If temp <> 0 Then
            If e.Node.Checked Then
                Call Check_Nodes(e.Node, True)
            Else
                Call Check_Nodes(e.Node, False)
            End If
        End If
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Check_Nodes(ByVal Node As TreeNode, ByVal checked As Boolean)
        If Check_NodesFlag Then
            Dim i As Integer
            If checked Then
                Call AddNode(CmbUser.SelectedValue, Node.Tag)
            Else
                Call DelNode(CmbUser.SelectedValue, Node.Tag)
            End If
            For i = 0 To Node.GetNodeCount(False) - 1
                Check_NodesFlag = False
                Node.Nodes(i).Checked = checked
                Check_NodesFlag = True
                If checked Then
                    Call AddNode(CmbUser.SelectedValue, Node.Nodes(i).Tag)
                Else
                    Call DelNode(CmbUser.SelectedValue, Node.Nodes(i).Tag)
                End If
                If Node.Nodes(i).GetNodeCount(False) > 0 Then
                    Check_Nodes(Node.Nodes(i), checked)
                End If
            Next

            Check_NodesFlag = False
            If Node.Tag > 0 Then
                Call CheckParents(Node.Parent, checked)
            End If
            Check_NodesFlag = True

        End If
    End Sub
    Private Sub CheckParents(ByVal Node As TreeNode, ByVal checked As Boolean)
        If checked Then
            Call AddNode(CmbUser.SelectedValue, Node.Tag)
            Node.Checked = checked
        Else
            Dim i As Integer
            For i = 0 To Node.GetNodeCount(False) - 1
                If Node.Nodes(i).Checked = True Then
                    Exit For
                End If
            Next
            If i = Node.GetNodeCount(False) Then
                Call DelNode(CmbUser.SelectedValue, Node.Tag)
                Node.Checked = checked
            End If
        End If
        If Node.Tag > 0 Then
            Call CheckParents(Node.Parent, checked)
        End If
    End Sub
    Private Sub TreeView1_RightToLeftChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView1.RightToLeftChanged
        e = e.Empty
    End Sub
    Private Sub AddNode(ByVal ThisUserId As Integer, ByVal ThisMenuId As Integer)
        If CmdGeneralForMenuMDB.Connection.State <> ConnectionState.Open Then
            CmdGeneralForMenuMDB.Connection.Open()
        End If
        If CmdGeneralForUserMDB.Connection.State <> ConnectionState.Open Then
            CmdGeneralForUserMDB.Connection.Open()
        End If
        Try
            CmdGeneralForMenuMDB.CommandText = "select Count(*) from Items Where MasterItem = " & ThisMenuId
            If CmdGeneralForMenuMDB.ExecuteScalar = 0 Then
                CmdGeneralForUserMDB.CommandText = "insert into UserFavorite (UserId,ItemKey) values(" & ThisUserId & "," & ThisMenuId & ")"
                CmdGeneralForUserMDB.ExecuteNonQuery()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DelNode(ByVal ThisUserId As Integer, ByVal ThisMenuId As Integer)
        If CmdGeneralForUserMDB.Connection.State <> ConnectionState.Open Then
            CmdGeneralForUserMDB.Connection.Open()
        End If
        CmdGeneralForUserMDB.CommandText = "Delete From UserFavorite Where UserId=" & ThisUserId & " AND ItemKey=" & ThisMenuId
        Try
            CmdGeneralForUserMDB.ExecuteNonQuery()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CmbUser_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbUser.SelectionChangeCommitted
        If CmbUser.Text.Trim.Length > 0 Then
            Call StartMakeNode()
        End If
    End Sub
    Private Sub StartMakeNode()
        Me.Cursor = Cursors.WaitCursor

        If CmdGeneralForUserMDB.Connection.State <> ConnectionState.Open Then
            CmdGeneralForUserMDB.Connection.Open()
        End If
        'CmdGeneralForUserMDB.CommandText = "Select UserName+' '+UserFamily as UserFullName From Users Where UserId=" & CmbUser.SelectedValue
        CmdGeneralForUserMDB.CommandText = "Select UserFamily as UserFullName From Users Where UserId=" & CmbUser.SelectedValue
        Try
            LblUserName.Text = CmdGeneralForUserMDB.ExecuteScalar
        Catch ex As Exception
            LblUserName.Text = ""
        End Try

        temp = 0
        TreeView1.Nodes.Clear()
        TreeView1.Nodes.Add("")
        TreeView1.TopNode.Text = " TireMate "
        TreeView1.TopNode.Tag = 0
        Call MakeTree(TreeView1.TopNode, DsFrmUserFavoriteMenu1.Items, 0)
        TreeView1.Nodes(0).Checked = True
        TreeView1.Nodes(0).Expand()
        temp = 1
        Me.Cursor = Cursors.Default
    End Sub
    Function IsFavoriteForThisUser(ByVal ThisUserId As Integer, ByVal ThisMenuId As Integer) As Boolean
        IsFavoriteForThisUser = False
        DAUserAccess.SelectCommand.CommandText = "SELECT COUNT(*) AS aa FROM UserFavorite Where UserId=" & ThisUserId & " AND ItemKey=" & ThisMenuId
        Dim UserAcc As Decimal = DAUserAccess.SelectCommand.ExecuteScalar()
        If (UserAcc <> 0) Or (CmbUser.Text.Trim.ToUpper = "Administrator".ToUpper) Then
            IsFavoriteForThisUser = True
        End If
    End Function
    Private Sub BtnExpandAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExpandAll.Click
        TreeView1.ExpandAll()
    End Sub
    Private Sub BtnCollapseAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCollapseAll.Click
        TreeView1.CollapseAll()
    End Sub
    Private Sub FrmUserFavoriteMenu_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        PubFavoriteMenuRefreshFlag = True
    End Sub
End Class
