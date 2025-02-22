Imports Janus.Windows.ButtonBar
Imports CommonClass
Public Class FrmMain
    Inherits CommonClass.FrmBase
    'Dim WithEvents FrmChUser As FrmLogin
    Dim AutoRefreshFlag As Boolean = True
    Friend BaseRefreshSecond As Integer
    Dim ThisFrmName As New Form
    Dim ThisFrmMenuName As New Form
    Dim OriginalMenuSelect As String = "SELECT FormName, Item_large_icon, Item_small_icon, Itemdesc, ItemKey, ItemKind, ItemToolTip, MasterGroup, MasterItem FROM Items "
    Dim OriginalUserAccessSelect As String = "SELECT COUNT(*) AS aa FROM UserAccess "
    'Dim OriginalUserFavorite As String = "SELECT UserFavorite.ItemKey, UserFavorite.UserId, Items.FormName, Items.Item_large_icon, Items.Item_small_icon, Items.Itemdesc, Items.ItemKind,Items.ItemToolTip, Items.MasterGroup, Items.MasterItem FROM (UserFavorite INNER JOIN Items ON UserFavorite.ItemKey = Items.ItemKey)"
    Dim OriginalUserFavorite As String = "SELECT UserFavorite.ItemKey, UserFavorite.UserId FROM UserFavorite"
    Dim SelectedItem As ButtonBarItem
    Dim SelectedGroup As ButtonBarGroup
    Dim FavoriteGroupKey As Integer = 0
    Dim WithEvents FrmChUser As FrmLogin
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        CnnUserMDB.ConnectionString = PConnectionStringForUserMdb
        CnnMenuMDB.ConnectionString = PConnectionStringForMenuMdb
        CnnMenuMDB.Open()
        CnnUserMDB.Open()
        Call CreateMenu()

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
    Friend WithEvents Sb1 As System.Windows.Forms.StatusBar
    Friend WithEvents PnlUser As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents Dsfrmmain1 As TireMate.Dsfrmmain
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DAUserAccess As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DAMenu As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents largeImageList As System.Windows.Forms.ImageList
    Friend WithEvents smallImageList As System.Windows.Forms.ImageList
    Friend WithEvents PnlStoreNo As System.Windows.Forms.StatusBarPanel
    Friend WithEvents PnlDate As System.Windows.Forms.StatusBarPanel
    Friend WithEvents OleDbSelectCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DAUserFavorite As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand4 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DAFormProperty As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents BackGroundPicture As System.Windows.Forms.PictureBox
    Friend WithEvents CnnMDBForSetup As System.Data.OleDb.OleDbConnection
    Friend WithEvents CmdGeneralForSetupMDB As System.Data.OleDb.OleDbCommand
    Friend WithEvents UiPanelManager1 As Janus.Windows.UI.Dock.UIPanelManager
    Friend WithEvents uiPanel0 As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents uiPanel0Container As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents ButtonBar1 As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents CnnUserMDB As System.Data.OleDb.OleDbConnection
    Friend WithEvents CnnMenuMDB As System.Data.OleDb.OleDbConnection
    Friend WithEvents CmdGeneralForUserMDB As System.Data.OleDb.OleDbCommand
    Friend WithEvents CmdGeneralForMenuMDB As System.Data.OleDb.OleDbCommand
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmMain))
        Me.Sb1 = New System.Windows.Forms.StatusBar
        Me.PnlUser = New System.Windows.Forms.StatusBarPanel
        Me.PnlStoreNo = New System.Windows.Forms.StatusBarPanel
        Me.PnlDate = New System.Windows.Forms.StatusBarPanel
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.Dsfrmmain1 = New TireMate.Dsfrmmain
        Me.CnnUserMDB = New System.Data.OleDb.OleDbConnection
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.CnnMenuMDB = New System.Data.OleDb.OleDbConnection
        Me.DAMenu = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.DAUserAccess = New System.Data.OleDb.OleDbDataAdapter
        Me.CmdGeneralForUserMDB = New System.Data.OleDb.OleDbCommand
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.largeImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.smallImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand
        Me.DAUserFavorite = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand4 = New System.Data.OleDb.OleDbCommand
        Me.DAFormProperty = New System.Data.OleDb.OleDbDataAdapter
        Me.BackGroundPicture = New System.Windows.Forms.PictureBox
        Me.CnnMDBForSetup = New System.Data.OleDb.OleDbConnection
        Me.CmdGeneralForSetupMDB = New System.Data.OleDb.OleDbCommand
        Me.UiPanelManager1 = New Janus.Windows.UI.Dock.UIPanelManager(Me.components)
        Me.uiPanel0 = New Janus.Windows.UI.Dock.UIPanel
        Me.uiPanel0Container = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.ButtonBar1 = New Janus.Windows.ButtonBar.ButtonBar
        Me.CmdGeneralForMenuMDB = New System.Data.OleDb.OleDbCommand
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        CType(Me.PnlUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PnlStoreNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PnlDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfrmmain1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiPanelManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uiPanel0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uiPanel0.SuspendLayout()
        Me.uiPanel0Container.SuspendLayout()
        CType(Me.ButtonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sb1
        '
        Me.Sb1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Sb1.Location = New System.Drawing.Point(0, 387)
        Me.Sb1.Name = "Sb1"
        Me.Sb1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.PnlUser, Me.PnlStoreNo, Me.PnlDate})
        Me.Sb1.ShowPanels = True
        Me.Sb1.Size = New System.Drawing.Size(687, 21)
        Me.Sb1.TabIndex = 2
        '
        'PnlUser
        '
        Me.PnlUser.Icon = CType(resources.GetObject("PnlUser.Icon"), System.Drawing.Icon)
        Me.PnlUser.Text = "---------------------------------------------------------------------------------" & _
        "---"
        Me.PnlUser.Width = 200
        '
        'PnlStoreNo
        '
        Me.PnlStoreNo.Icon = CType(resources.GetObject("PnlStoreNo.Icon"), System.Drawing.Icon)
        Me.PnlStoreNo.Text = "Store No"
        Me.PnlStoreNo.Width = 200
        '
        'PnlDate
        '
        Me.PnlDate.Icon = CType(resources.GetObject("PnlDate.Icon"), System.Drawing.Icon)
        Me.PnlDate.Text = "Date"
        '
        'Dsfrmmain1
        '
        Me.Dsfrmmain1.DataSetName = "Dsfrmmain"
        Me.Dsfrmmain1.Locale = New System.Globalization.CultureInfo("fa-IR")
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
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT FormName, Item_large_icon, Item_small_icon, Itemdesc, ItemKey, ItemKind, I" & _
        "temToolTip, MasterGroup, MasterItem FROM Items"
        Me.OleDbSelectCommand1.Connection = Me.CnnMenuMDB
        '
        'CnnMenuMDB
        '
        Me.CnnMenuMDB.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Jet OLEDB:Database Password=;Data Source=""D:\TireMate\TireMate.mdb" & _
        """;Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provide" & _
        "r=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Exten" & _
        "ded Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:" & _
        "Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OL" & _
        "EDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Databas" & _
        "e=False"
        '
        'DAMenu
        '
        Me.DAMenu.SelectCommand = Me.OleDbSelectCommand1
        Me.DAMenu.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Items", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Item_large_icon", "Item_large_icon"), New System.Data.Common.DataColumnMapping("Item_small_icon", "Item_small_icon"), New System.Data.Common.DataColumnMapping("Itemdesc", "Itemdesc"), New System.Data.Common.DataColumnMapping("ItemKey", "ItemKey"), New System.Data.Common.DataColumnMapping("ItemKind", "ItemKind")})})
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT COUNT(*) AS aa FROM UserAccess"
        Me.OleDbSelectCommand2.Connection = Me.CnnUserMDB
        '
        'DAUserAccess
        '
        Me.DAUserAccess.SelectCommand = Me.OleDbSelectCommand2
        Me.DAUserAccess.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "UserAccress", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ItemKey", "ItemKey"), New System.Data.Common.DataColumnMapping("UserId", "UserId")})})
        '
        'CmdGeneralForUserMDB
        '
        Me.CmdGeneralForUserMDB.Connection = Me.CnnUserMDB
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'largeImageList
        '
        Me.largeImageList.ImageSize = New System.Drawing.Size(32, 32)
        Me.largeImageList.ImageStream = CType(resources.GetObject("largeImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.largeImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'smallImageList
        '
        Me.smallImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.smallImageList.ImageStream = CType(resources.GetObject("smallImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.smallImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'OleDbSelectCommand3
        '
        Me.OleDbSelectCommand3.CommandText = "SELECT UserFavorite.ItemKey, UserFavorite.UserId, Items.FormName, Items.Item_larg" & _
        "e_icon, Items.Item_small_icon, Items.Itemdesc, Items.ItemKind, Items.ItemToolTip" & _
        ", Items.MasterGroup, Items.MasterItem FROM (UserFavorite INNER JOIN Items ON Use" & _
        "rFavorite.ItemKey = Items.ItemKey)"
        Me.OleDbSelectCommand3.Connection = Me.CnnUserMDB
        '
        'DAUserFavorite
        '
        Me.DAUserFavorite.SelectCommand = Me.OleDbSelectCommand3
        Me.DAUserFavorite.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "UserFavorite", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("FormName", "FormName"), New System.Data.Common.DataColumnMapping("Item_large_icon", "Item_large_icon"), New System.Data.Common.DataColumnMapping("Item_small_icon", "Item_small_icon"), New System.Data.Common.DataColumnMapping("Itemdesc", "Itemdesc"), New System.Data.Common.DataColumnMapping("ItemKey", "ItemKey"), New System.Data.Common.DataColumnMapping("ItemKind", "ItemKind"), New System.Data.Common.DataColumnMapping("ItemToolTip", "ItemToolTip"), New System.Data.Common.DataColumnMapping("MasterGroup", "MasterGroup"), New System.Data.Common.DataColumnMapping("MasterItem", "MasterItem"), New System.Data.Common.DataColumnMapping("UserId", "UserId")})})
        '
        'OleDbSelectCommand4
        '
        Me.OleDbSelectCommand4.CommandText = "SELECT ItemKey, PropertyName, PropertyValue FROM FormProperty"
        Me.OleDbSelectCommand4.Connection = Me.CnnMenuMDB
        '
        'DAFormProperty
        '
        Me.DAFormProperty.SelectCommand = Me.OleDbSelectCommand4
        Me.DAFormProperty.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "FormProperty", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ItemKey", "ItemKey"), New System.Data.Common.DataColumnMapping("PropertyName", "PropertyName"), New System.Data.Common.DataColumnMapping("PropertyValue", "PropertyValue")})})
        '
        'BackGroundPicture
        '
        Me.BackGroundPicture.Location = New System.Drawing.Point(212, 215)
        Me.BackGroundPicture.Name = "BackGroundPicture"
        Me.BackGroundPicture.Size = New System.Drawing.Size(135, 83)
        Me.BackGroundPicture.TabIndex = 25
        Me.BackGroundPicture.TabStop = False
        Me.BackGroundPicture.Visible = False
        '
        'CnnMDBForSetup
        '
        Me.CnnMDBForSetup.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Jet OLEDB:Database Password=;Data Source=""D:\TireMate\TireMate.mdb" & _
        """;Password=;Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provide" & _
        "r=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Exten" & _
        "ded Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:" & _
        "Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OL" & _
        "EDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Databas" & _
        "e=False"
        '
        'CmdGeneralForSetupMDB
        '
        Me.CmdGeneralForSetupMDB.Connection = Me.CnnMDBForSetup
        '
        'UiPanelManager1
        '
        Me.UiPanelManager1.ContainerControl = Me
        Me.uiPanel0.Id = New System.Guid("4117c6ba-f85a-4306-858e-672cc40c458e")
        Me.UiPanelManager1.Panels.Add(Me.uiPanel0)
        '
        'Design Time Panel Info:
        '
        Me.UiPanelManager1.BeginPanelInfo()
        Me.UiPanelManager1.AddDockPanelInfo(New System.Guid("4117c6ba-f85a-4306-858e-672cc40c458e"), Janus.Windows.UI.Dock.PanelDockStyle.Left, New System.Drawing.Size(200, 381), True)
        Me.UiPanelManager1.AddDockPanelInfo(New System.Guid("d61f2490-b66b-4180-9211-2763f93d2b4b"), Janus.Windows.UI.Dock.PanelDockStyle.Left, New System.Drawing.Size(193, 411), True)
        Me.UiPanelManager1.EndPanelInfo()
        '
        'uiPanel0
        '
        Me.uiPanel0.InnerContainer = Me.uiPanel0Container
        Me.uiPanel0.Location = New System.Drawing.Point(3, 3)
        Me.uiPanel0.Name = "uiPanel0"
        Me.uiPanel0.Size = New System.Drawing.Size(200, 381)
        Me.uiPanel0.TabIndex = 4
        Me.uiPanel0.Text = "Menu"
        Me.uiPanel0.TextAlignment = Janus.Windows.UI.Dock.PanelTextAlignment.Center
        '
        'uiPanel0Container
        '
        Me.uiPanel0Container.Controls.Add(Me.ButtonBar1)
        Me.uiPanel0Container.Location = New System.Drawing.Point(1, 23)
        Me.uiPanel0Container.Name = "uiPanel0Container"
        Me.uiPanel0Container.Size = New System.Drawing.Size(194, 357)
        Me.uiPanel0Container.TabIndex = 0
        '
        'ButtonBar1
        '
        Me.ButtonBar1.AllowDragGroups = False
        Me.ButtonBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonBar1.DropLineColor = System.Drawing.Color.RosyBrown
        Me.ButtonBar1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ButtonBar1.ForeColor = System.Drawing.Color.Black
        Me.ButtonBar1.LargeImageList = Me.largeImageList
        Me.ButtonBar1.Location = New System.Drawing.Point(0, 0)
        Me.ButtonBar1.Name = "ButtonBar1"
        Me.ButtonBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ButtonBar1.Size = New System.Drawing.Size(194, 357)
        Me.ButtonBar1.SmallImageList = Me.smallImageList
        Me.ButtonBar1.TabIndex = 21
        Me.ButtonBar1.Text = "ButtonBar1"
        Me.ButtonBar1.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2003
        '
        'CmdGeneralForMenuMDB
        '
        Me.CmdGeneralForMenuMDB.Connection = Me.CnnMenuMDB
        '
        'FrmMain
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Application
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(687, 408)
        Me.Controls.Add(Me.BackGroundPicture)
        Me.Controls.Add(Me.uiPanel0)
        Me.Controls.Add(Me.Sb1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MaximizeBox = True
        Me.Menu = Me.MainMenu1
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Housing Investment Company"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PnlUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PnlStoreNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PnlDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfrmmain1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiPanelManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uiPanel0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uiPanel0.ResumeLayout(False)
        Me.uiPanel0Container.ResumeLayout(False)
        CType(Me.ButtonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Myresources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmMain))

        HelpProvider1.HelpNamespace = Application.StartupPath & "\TireMate Help.chm"
        HelpProvider1.SetHelpKeyword(Me, " ")

        PSalMali = ((Format(Now.Date.Year) & "").ToString).Trim
        If PSalMali.Trim.Length <> 4 Then
            PSalMali = "2007"
        End If

        Try
            CnnMenuMDB.ConnectionString = PConnectionStringForMenuMdb
        Catch ex As Exception
        End Try
        Try
            CnnUserMDB.ConnectionString = PConnectionStringForUserMdb
        Catch ex As Exception
        End Try
        Try
            CnnMDBForSetup.ConnectionString = PConnectionStringForSetupTables
        Catch ex As Exception
        End Try

        Call ScreenResolution()

        Call ShowImage()

        PubButtonBarWidth = ButtonBar1.Width
        PnlUser.Text = PUserName
        PnlStoreNo.Text = PubStoreName.Trim
        PnlDate.Text = Now.Date
        Me.Refresh()

        Call FillTypeOfWorkOrderItem()

        'ButtonBar1.Height = Me.Height - MainLogoPicture.Height - Sb1.Height - 55
        ButtonBar1.Height = Me.Height - Sb1.Height - 55

        BaseRefreshSecond = (Format(Now(), "HH") * 3600) + (Format(Now(), "mm") * 60) + (Format(Now(), "ss"))
        If CnnUserMDB.State <> ConnectionState.Open Then
            CnnUserMDB.Open()
        End If
        If CnnMenuMDB.State <> ConnectionState.Open Then
            CnnMenuMDB.Open()
        End If

        'Call CreateMenu()

        Me.Menu = MainMenu1
        MainMenu1.MenuItems(0).Enabled = False
        MainMenu1.MenuItems(0).Enabled = True

    End Sub
    Private Sub ShowImage()
        Dim MyImage As Bitmap
        'Try
        '    MyImage = New Bitmap(PubMainImagePath & "\TireMate.gif")
        '    MainLogoPicture.Image = CType(MyImage, Image)
        'Catch ex As Exception
        'End Try

        Try
            If PubScreenResolutionX = 1024 Then
                MyImage = New Bitmap(PubMainImagePath & "\mainlogo1024.Bmp")
            Else
                MyImage = New Bitmap(PubMainImagePath & "\mainlogo800.Bmp")
            End If
            BackGroundPicture.Image = CType(MyImage, Image)
            Me.BackgroundImage = BackGroundPicture.Image
        Catch ex As Exception
        End Try
    End Sub
    Public Function CheckPrevilage() As Boolean
        CheckPrevilage = True
    End Function
    Private Sub CreateButtonBar()
        ' ItemKind
        ' 0 = ê—ÊÂÂ«Ì „ÊÃÊœ œ— „‰ÊÌ ”„  çÅ ’›ÕÂ
        ' 1 = »—‰«„Â Â«Ì „ÊÃÊœ œ— „‰ÊÌ ”„  çÅ ’›ÕÂ
        ' 3 = „‰ÊÂ«Ì »«·«Ì ’›ÕÂ
        ' 4 = »—‰«„Â Â«ÌÌ ﬂÂ Â„ œ— „‰ÊÌ »«·« Ê Â„ œ— „‰ÊÌ ”„  çÅ ﬁ—«— œ«—‰œ
        ' ‘„«—Â «Ì‰ »—‰«„Â Â« Õœ«ﬁ· »«Ìœ 3 —ﬁ„Ì »«‘œ
        ' 4 , MasterGroup<20 »Â „⁄‰Ì ”—ê—ÊÂ œ— ”„  çÅ „Ì»«‘œ
        ' Â„ç‰Ì‰  — Ì» ﬁ—«— ê—œ‰ ê—ÊÂÂ« —« „‘Œ’ „Ìﬂ‰œ MasterGroup 
        ' Ê Õ „« »«Ìœ 2 —ﬁ„Ì »«‘œ
        'OriginalMenuSelect = DAMenu.SelectCommand.CommandText

        Dsfrmmain1.Clear()
        DAMenu.Fill(Dsfrmmain1, "AllItems")

        DAMenu.SelectCommand.CommandText = OriginalMenuSelect & " Where ItemKind=0 OR (ItemKind=4 AND len(trim(MasterGroup))=2) ORDER BY ItemKey"
        DAMenu.Fill(Dsfrmmain1, "Items")

        ButtonBar1.Groups.Clear()
        ButtonBar1.ShadowOnHover = True
        ButtonBar1.KeepSelection = True
        ButtonBar1.HeaderGroupVisible = True
        ButtonBar1.SelectionArea = SelectionArea.FullItem
        ButtonBar1.GroupAppearance = GroupAppearance.Light3D
        ButtonBar1.ItemAppearance = ItemAppearance.PopUp


        Dim i As Integer, j As Integer, k As Integer
        For i = 0 To Dsfrmmain1.Items.Rows.Count - 1
            Dim Mygrp As New Janus.Windows.ButtonBar.ButtonBarGroup
            Mygrp.Text = Dsfrmmain1.Items.Rows(i).Item("Itemdesc")
            Try
                Mygrp.ToolTipText = Dsfrmmain1.Items.Rows(i).Item("ItemToolTip")
            Catch ex As Exception
                Mygrp.ToolTipText = ""
            End Try

            If Dsfrmmain1.Items.Rows(i).Item("Item_small_icon") < smallImageList.Images.Count Then
                Mygrp.ImageIndex = Dsfrmmain1.Items.Rows(i).Item("Item_small_icon")
            End If
            Mygrp.Key = Dsfrmmain1.Items.Rows(i).Item("ItemKey")
            If Not IsAccessByThisUser(PUserCod, Dsfrmmain1.Items.Rows(i).Item("ItemKey")) Then
                Mygrp.Enabled = False
            Else
                Mygrp.Enabled = True
            End If
            Mygrp.Tag = Dsfrmmain1.Items.Rows(i).Item("FormName")
            Mygrp.View = ButtonBarView.SmallIcons
            ButtonBar1.Groups.Add(Mygrp)
            If SelectedGroup Is Nothing Then
                SelectedGroup = Mygrp
            End If
        Next

        FavoriteGroupKey = i - 1

        Dsfrmmain1.Items1.Clear()
        DAMenu.SelectCommand.CommandText = OriginalMenuSelect & " Where itemkind=1 OR (ItemKind=4 AND len(trim(MasterGroup))>2) ORDER BY ItemKey"
        DAMenu.Fill(Dsfrmmain1, "Items1")
        Dim GroupCountVar As Integer = -1
        Dim GroupMasterGroupVar As Integer = -1
        For j = 0 To Dsfrmmain1.Items1.Rows.Count - 1
            Dim grpItem As New Janus.Windows.ButtonBar.ButtonBarItem
            If GroupMasterGroupVar <> Val(Dsfrmmain1.Items1.Rows(j).Item("MasterGroup")) Then
                GroupMasterGroupVar = Val(Dsfrmmain1.Items1.Rows(j).Item("MasterGroup"))
                GroupCountVar = GroupCountVar + 1
            End If
            grpItem.Text = Dsfrmmain1.Items1.Rows(j).Item("Itemdesc")
            Try
                grpItem.ToolTipText = Dsfrmmain1.Items1.Rows(j).Item("ItemToolTip")
            Catch ex As Exception
                grpItem.ToolTipText = ""
            End Try
            'grpItem.LargeImageIndex = 1
            If Dsfrmmain1.Items1.Rows(j).Item("Item_small_icon") < smallImageList.Images.Count Then
                grpItem.SmallImageIndex = Dsfrmmain1.Items1.Rows(j).Item("Item_small_icon")
            End If
            grpItem.Key = Dsfrmmain1.Items1.Rows(j).Item("ItemKey")
            If Not IsAccessByThisUser(PUserCod, Dsfrmmain1.Items1.Rows(j).Item("ItemKey")) Then
                grpItem.Enabled = False
            Else
                grpItem.Enabled = True
            End If
            grpItem.Tag = Dsfrmmain1.Items1.Rows(j).Item("FormName")
            If CmdGeneralForMenuMDB.Connection.State <> ConnectionState.Open Then
                CmdGeneralForMenuMDB.Connection.Open()
            End If
            CmdGeneralForMenuMDB.CommandText = "SELECT MasterGroup from Items where ItemKey=" & Dsfrmmain1.Items1.Rows(j).Item("MasterGroup")
            k = CmdGeneralForMenuMDB.ExecuteScalar()
            ButtonBar1.Groups(k).Items.Add(grpItem)
        Next

        Call CreateFavoriteMenu()

    End Sub
    Public Sub CreateFavoriteMenu()
        Try
            ButtonBar1.Groups(FavoriteGroupKey).Items.Clear()
            Dim j As Integer
            Dsfrmmain1.UserFavorite.Clear()
            DAUserFavorite.SelectCommand.CommandText = OriginalUserFavorite & " Where UserId=" & PUserCod & " ORDER BY UserFavorite.ItemKey"
            DAUserFavorite.Fill(Dsfrmmain1, "UserFavorite")
            If Dsfrmmain1.UserFavorite.Rows.Count > 0 Then
                For j = 0 To Dsfrmmain1.UserFavorite.Rows.Count - 1
                    Dim grpItem As New Janus.Windows.ButtonBar.ButtonBarItem
                    Dim CreateFavoriteMenuDR As DataRow
                    CreateFavoriteMenuDR = Dsfrmmain1.AllItems.FindByItemKey(Dsfrmmain1.UserFavorite.Rows(j).Item("Itemkey"))
                    grpItem.Text = CreateFavoriteMenuDR.Item("Itemdesc") & ""
                    Try
                        grpItem.ToolTipText = CreateFavoriteMenuDR.Item("ItemToolTip") & ""
                    Catch ex As Exception
                        grpItem.ToolTipText = ""
                    End Try
                    'grpItem.LargeImageIndex = 1
                    Try
                        If CreateFavoriteMenuDR.Item("Item_small_icon") < smallImageList.Images.Count Then
                            grpItem.SmallImageIndex = CreateFavoriteMenuDR.Item("Item_small_icon")
                        End If
                    Catch ex As Exception
                    End Try
                    grpItem.Key = Dsfrmmain1.UserFavorite.Rows(j).Item("ItemKey")
                    If Not IsAccessByThisUser(PUserCod, Dsfrmmain1.UserFavorite.Rows(j).Item("ItemKey")) Then
                        grpItem.Enabled = False
                    Else
                        grpItem.Enabled = True
                    End If
                    grpItem.Tag = CreateFavoriteMenuDR.Item("FormName") & ""
                    ButtonBar1.Groups(FavoriteGroupKey).Items.Add(grpItem)
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CreateMenu()
        Call CreateButtonBar()
        Dsfrmmain1.Items.Clear()
        DAMenu.SelectCommand.CommandText = OriginalMenuSelect & " Where ItemKind=3 OR itemkind=4 ORDER BY ItemKey"
        DAMenu.Fill(Dsfrmmain1, "Items")
        Call MakeMenu(MainMenu1, Dsfrmmain1.Items, 0)
        Try
            Dim MenuItem9888 As System.Windows.Forms.MenuItem
            MenuItem9888 = New System.Windows.Forms.MenuItem
            MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {MenuItem9888})
            MenuItem9888.MdiList = True
            MenuItem9888.Text = "Window"
            Me.Text = PubCompanyName
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FrmChUser_PassWordOk(ByVal Id As Integer, ByVal Name As String, ByVal StoreNo As String, ByVal StoreName As String) Handles FrmChUser.PassWordOk
        Dim OldPubStoreNo As String = PubStoreNO
        Dim OldPubStoreName As String = PubStoreName

        PubStoreNO = StoreNo
        PubStoreName = StoreName

        If FrmChUser.TxtUserLogin.Enabled Then
            PUserCod = Id
            PUserName = Name.Trim
            Sb1.Panels(0).Text = PUserName
            'Sb1.Panels(1).Text = "Store No : " & PubStoreNO

            MainMenu1.MenuItems.Clear()
            Try
                Call CreateMenu()
            Catch ex As Exception
            End Try
        End If

        If Not MakeConnectionStringForSQL(2) Then '⁄œ„ «„ﬂ«‰ »—ﬁ—«—Ì «— »«ÿ »« Å«Ìê«Â œ«œÂ
            PubStoreNO = OldPubStoreNo
            PubStoreName = OldPubStoreName
        End If
        Sb1.Panels(1).Text = PubStoreName

        Call SetPubCompanyName()
    End Sub
    Sub MakeMenu(ByVal ThisMenu As Menu, ByVal ThisDataTable As DataTable, ByVal ThisIdParent As Decimal)
        Dim i As Integer
        Dim DV As New DataView
        With DV
            .Table = Dsfrmmain1.Items
            .RowFilter = "MasterItem = " & ThisIdParent '& "'"
        End With
        If DV.Count >= 0 Then
            For i = 0 To DV.Count - 1
                Dim MyMenuItm As New MenuItem(DV.Item(i).Item("ItemDesc"))
                ThisMenu.MenuItems.Add(MyMenuItm)
                MyMenuItm.MergeOrder = DV.Item(i).Item("ItemKey")
                Call MakeMenu(MyMenuItm, Dsfrmmain1.Items, DV.Item(i).Item("ItemKey"))
                If MyMenuItm.IsParent = False Then
                    AddHandler MyMenuItm.Click, AddressOf AllMenuClick
                End If
                If Not IsAccessByThisUser(PUserCod, DV.Item(i).Item("ItemKey")) Then
                    MyMenuItm.Enabled = False
                End If
            Next
        End If
    End Sub
    Function IsAccessByThisUser(ByVal ThisUserId As Integer, ByVal ThisMenuId As Integer) As Boolean
        IsAccessByThisUser = False
        DAUserAccess.SelectCommand.CommandText = OriginalUserAccessSelect & " Where UserId=" & ThisUserId & " AND ItemKey=" & ThisMenuId
        Dim UserAcc As Decimal = DAUserAccess.SelectCommand.ExecuteScalar()
        If (UserAcc <> 0) Or (PUserName = "Administrator") Then
            IsAccessByThisUser = True
        End If
    End Function
    Private Sub AllMenuClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ThisRow As DataRow = Dsfrmmain1.AllItems.Rows.Find(CType(sender, MenuItem).MergeOrder)
        Dim Frm As String, ItemkeyVar As Double
        Frm = Trim(ThisRow.Item("FormName") & "")
        ItemkeyVar = Trim(ThisRow.Item("Itemkey") & "")
        If Frm <> "" Then
            Try
                Call Show_Form(Frm, ItemkeyVar)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            'Try
            '    ThisFrmName = CType(Activator.CreateInstance(Type.GetType(Application.ProductName & "." & Frm, True, True)), Form)
            'Catch ex As Exception
            '    MsgBox(ex.ToString)
            'End Try
            ''ThisFrmName.TopLevel = False
            ''ThisFrmName.Parent = Me
            ''ThisFrmName.BringToFront()
            'ThisFrmName.MdiParent = Me
            'ThisFrmName.StartPosition = FormStartPosition.CenterScreen
            ''Call CenterMe(ThisFrmName)
            'ThisFrmName.Show()
        Else
            'If Table1 <> "" Then
            '    Dim MyFrmbase As FrmCodDesc = New FrmCodDesc
            '    MyFrmbase.MdiParent = Me
            '    MyFrmbase.StartPosition = FormStartPosition.CenterScreen
            '    ''''Dim MyFrmtripleBase As FrmtripleBase = New FrmtripleBase
            '    Select Case Table1.ToUpper
            '        Case "Agencer".ToUpper
            '            With MyFrmbase
            '                .TableName = "Agencer"
            '                .FieldCodName = "AgencerCod"
            '                .FieldCodHeader = " òœ ‰„«Ì‰œÂ "
            '                .FieldCodLen = 5
            '                .FieldDescName = "AgencerNameFamil"
            '                .FieldDescHeader = " ‰«„ Ê ‰«„ Œ«‰Ê«œêÌ"
            '                .FieldDescLen = 50
            '                .Show()
            '            End With
            '        Case "ManagerChiveReason".ToUpper
            '            With MyFrmbase
            '                .TableName = "ManagerChiveReason"
            '                .FieldCodName = "ManagerChiveReasonCod"
            '                .FieldCodHeader = "òœ œ·Ì·  ⁄ﬁÌ» ﬂ«—›—„«"
            '                .FieldCodLen = 1
            '                .FieldDescName = "ManagerChiveReasonName"
            '                .FieldDescHeader = "⁄‰Ê«‰ œ·Ì·  ⁄ﬁÌ» ﬂ«—›—„«"
            '                .TitleHeader = "œ·«Ì·  ⁄ﬁÌ» ﬂ«—›—„«"
            '                .FieldDescLen = 50
            '                .Show()
            '            End With
            '        Case "UserGroup".ToUpper
            '            Dim MyFrmDesc As FrmDesc = New FrmDesc
            '            MyFrmDesc.MdiParent = Me
            '            MyFrmDesc.StartPosition = FormStartPosition.CenterScreen
            '            With MyFrmDesc
            '                .TableName = "UserGroup"
            '                .FieldIdName = "GroupId"
            '                .FieldDescName = "GroupName"
            '                .FieldDescHeader = "⁄‰Ê«‰ ê—ÊÂ ﬂ«—»—«‰"
            '                .TitleHeader = "ê—ÊÂ ﬂ«—»—«‰"
            '                .FieldDescLen = 40
            '                .Show()
            '            End With
            '            MyFrmDesc = Nothing
            '        Case "FrmLogin".ToUpper
            '            FrmChUser = New FrmLogin
            '            FrmChUser.CmbUsers.SelectedValue = PubUserId
            '            FrmChUser.ShowDialog()
            '            FrmChUser.Dispose()
            '    End Select
            '    MyFrmbase = Nothing
            'End If
        End If
    End Sub
    Private Sub FrmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim MyFrmExit As New FrmExit
        MyFrmExit.ShowDialog()
        If MyFrmExit.DialogResult <> DialogResult.OK Then
            e.Cancel = True
        End If
    End Sub
    Private Sub ButtonBar1_ItemClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar1.ItemClick
        Dim Frm As String = Trim(e.Item.Tag & "")
        If Frm.Length > 0 Then
            Try
                Call Show_Form(Frm, e.Item.Key)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub ButtonBar1_GroupClick(ByVal sender As System.Object, ByVal e As Janus.Windows.ButtonBar.GroupEventArgs) Handles ButtonBar1.GroupClick
        SelectedGroup = e.Group
        Try
            If ThisFrmMenuName.Name.Trim.Length > 0 Then
                ThisFrmMenuName.Close()
                ThisFrmMenuName.Dispose()
                ThisFrmMenuName = New Form
            End If
        Catch ex As Exception
        End Try

        Dim Frm As String = Trim(e.Group.Tag & "")
        If Frm.Length > 0 Then
            Try
                Dim myresource As System.Reflection.Assembly
                myresource = System.Reflection.Assembly.Load(Give_NameSpace(Frm))
                ThisFrmMenuName = DirectCast(myresource.GetType(Frm).InvokeMember(Give_Form(Frm), Reflection.BindingFlags.CreateInstance, Nothing, Nothing, Nothing), FrmBase)
                With ThisFrmMenuName
                    .TopLevel = False
                    .MdiParent = Me
                    '.StartPosition = FormStartPosition.CenterParent
                    '.Top = ButtonBar1.Top
                    '.Left = ButtonBar1.Left + ButtonBar1.Width
                    .Show()
                    .BringToFront()
                End With
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Public Function ScreenResolution() As Integer
        PubScreenResolutionX = Screen.PrimaryScreen.Bounds.Width
        PubScreenResolutionY = Screen.PrimaryScreen.Bounds.Height
    End Function
    Private Sub Show_Form(ByVal formspecification As String, ByVal Show_FormItemkey As Double)
        'Try
        '    Dim myresource As System.Reflection.Assembly
        '    myresource = System.Reflection.Assembly.Load(Give_NameSpace(formspecification))
        '    Dim FormVar As Form = DirectCast(myresource.GetType(formspecification).InvokeMember(Give_Form(formspecification), Reflection.BindingFlags.CreateInstance, Nothing, Nothing, Nothing), FrmBase)
        '    With FormVar
        '        Call SetProperty(FormVar, Show_FormItemkey)

        '        .TopLevel = False
        '        .Parent = Me
        '        .Top = 1
        '        If PubButtonBarWidth + .Width > PubScreenResolutionX Then
        '            .Left = PubScreenResolutionX - .Width
        '        Else
        '            .Left = PubButtonBarWidth
        '        End If
        '        .Show()
        '        .BringToFront()
        '    End With
        'Catch ex As Exception
        '    MsgFar("Error In Form")
        'End Try

        Try
            Dim myresource As System.Reflection.Assembly
            Dim FormVar As Form
            Dim ar(0) As Object
            If formspecification.ToUpper = "FormGenerator.FrmGeneral".ToUpper Then
                ar(0) = Show_FormItemkey.ToString
                myresource = System.Reflection.Assembly.LoadFrom(Application.StartupPath & "\" & "FormGenerator.dll")
                Dim t As Type = myresource.GetType(formspecification)
                FormVar = CType(Activator.CreateInstance(t, ar), FrmBase)
            Else
                myresource = System.Reflection.Assembly.Load(Give_NameSpace(formspecification))
                Dim t As Type = myresource.GetType(formspecification)
                FormVar = CType(Activator.CreateInstance(t), FrmBase)
            End If
            With FormVar
                Call SetProperty(FormVar, Show_FormItemkey)
                .TopLevel = False
                .MdiParent = Me
                .StartPosition = FormStartPosition.Manual
                .Top = 1
                .Left = 0
                .Show()
                .BringToFront()
            End With
        Catch ex As Exception
            MsgFar("Error In Form")
        End Try

    End Sub
    Private Sub SetProperty(ByVal Thisform As Form, ByVal ThisItemkey As Double)
        Dsfrmmain1.FormProperty.Clear()
        DAFormProperty.SelectCommand.CommandText = "SELECT ItemKey,PropertyName,PropertyValue FROM FormProperty Where ItemKey=" & ThisItemkey
        DAFormProperty.Fill(Dsfrmmain1, "FormProperty")
        Dim ThisPropertyName As String
        Dim ThisPropertyValue As String
        Dim i As Integer
        If Dsfrmmain1.FormProperty.Rows.Count > 0 Then
            For i = 0 To Dsfrmmain1.FormProperty.Rows.Count - 1
                Dim ThisPropertyVar As Type
                ThisPropertyVar = Thisform.GetType
                ThisPropertyName = Dsfrmmain1.FormProperty.Rows(i).Item("PropertyName")
                ThisPropertyValue = Dsfrmmain1.FormProperty.Rows(i).Item("PropertyValue")
                Try
                    ThisPropertyVar.GetProperty(ThisPropertyName).SetValue(Thisform, ThisPropertyValue, Nothing)
                Catch ex As Exception

                End Try
            Next
        End If
    End Sub
    Public Function Give_NameSpace(ByVal FormSpecification As String) As String
        Return FormSpecification.Substring(0, FormSpecification.IndexOf("."))
    End Function
    Public Function Give_Form(ByVal FormSpecification As String) As String
        Return FormSpecification.Substring(FormSpecification.IndexOf(".") + 1)
    End Function
    'Private Sub mnuCreateShortcut_App_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If SelectedGroup.Key = 999900000 Then
    '        Try
    '            If CmdGeneralForuserMDB.Connection.State <> ConnectionState.Open Then
    '                CmdGeneralForuserMDB.Connection.Open()
    '            End If
    '            CmdGeneralForuserMDB.CommandText = "Delete From UserFavorite WHERE ItemKey = " & SelectedItem.Key
    '            CmdGeneralForuserMDB.ExecuteNonQuery()
    '            Call CreateFavoriteMenu()
    '        Catch ex As Exception
    '        End Try
    '    Else
    '        Try
    '            If CmdGeneralForuserMDB.Connection.State <> ConnectionState.Open Then
    '                CmdGeneralForuserMDB.Connection.Open()
    '            End If
    '            CmdGeneralForuserMDB.CommandText = "INSERT INTO UserFavorite SELECT * FROM Items WHERE ItemKey = " & SelectedItem.Key
    '            CmdGeneralForuserMDB.ExecuteNonQuery()
    '            CmdGeneralForuserMDB.CommandText = "Update UserFavorite Set UserId= " & PUserCod & " WHERE UserId=0 AND ItemKey = " & SelectedItem.Key
    '            CmdGeneralForuserMDB.ExecuteNonQuery()
    '            Call CreateFavoriteMenu()
    '        Catch ex As Exception
    '        End Try
    '    End If
    'End Sub
    'Private Sub ButtonBar1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ButtonBar1.MouseDown
    '    If e.Button = MouseButtons.Right Then
    '        ButtonBar1.ContextMenu = ItemsMenu
    '        SelectedItem = ButtonBar1.GetItemFromPoint(e.X, e.Y)
    '        If Not (SelectedItem Is Nothing) Then
    '            If SelectedItem.Enabled = False Then
    '                ItemsMenu.MenuItems(0).Enabled = False
    '            Else
    '                ItemsMenu.MenuItems(0).Enabled = True
    '            End If
    '            ButtonBar1.ContextMenu = ItemsMenu 'GroupsMenu
    '        Else
    '            ItemsMenu.MenuItems(0).Enabled = False
    '        End If
    '    End If
    'End Sub
    Private Sub Sb1_PanelClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.StatusBarPanelClickEventArgs) Handles Sb1.PanelClick
        If e.Clicks = 2 And e.X < 200 Then
            If Me.MdiChildren.Length > 0 Then
                If Me.MdiChildren.Length > 1 Or Mid(Me.MdiChildren(0).Name.ToUpper, 1, 7) <> "Frmmenu".ToUpper Then
                    MsgBox("Please close all the forms and then try again.")
                    Exit Sub
                End If
            End If
            Me.Hide()
            FrmChUser = New FrmLogin
            If CmdGeneralForUserMDB.Connection.State <> ConnectionState.Open Then
                CmdGeneralForUserMDB.Connection.Open()
            End If
            CmdGeneralForUserMDB.CommandText = "Select UserId From Users WHERE UserId=" & PUserCod
            Try
                FrmChUser.TxtUserLogin.Text = CmdGeneralForUserMDB.ExecuteScalar
            Catch ex As Exception
                FrmChUser.TxtUserLogin.Text = ""
            End Try
            FrmChUser.CmbStoreNo.SelectedValue = PubStoreNO
            FrmChUser.ShowDialog()
            FrmChUser.Dispose()
            Me.Show()
        End If
        If e.Clicks = 2 And e.X > 200 And e.X < 400 Then
            If Me.MdiChildren.Length > 0 Then
                If Me.MdiChildren.Length > 1 Or Mid(Me.MdiChildren(0).Name.ToUpper, 1, 7) <> "Frmmenu".ToUpper Then
                    MsgBox("Please close all the forms and then try again.")
                    Exit Sub
                End If
            End If
            If CmdGeneralForSetupMDB.Connection.State <> ConnectionState.Open Then
                CmdGeneralForSetupMDB.Connection.Open()
            End If
            CmdGeneralForSetupMDB.CommandText = "Select Count(*) From Store_Setup"
            If CmdGeneralForSetupMDB.ExecuteScalar() = 1 Then
                MsgBox("The Store Table Has One Record")
            Else
                FrmChUser = New FrmLogin
                If CmdGeneralForUserMDB.Connection.State <> ConnectionState.Open Then
                    CmdGeneralForUserMDB.Connection.Open()
                End If
                CmdGeneralForUserMDB.CommandText = "SELECT UserPassWord from Users where UserId=" & PUserCod
                FrmChUser.tTz.Text = CmdGeneralForUserMDB.ExecuteScalar() & ""
                FrmChUser.TxtUserLogin.Enabled = False
                FrmChUser.tTz.Enabled = False
                FrmChUser.CmbStoreNo.SelectedValue = PubStoreNO
                FrmChUser.LblStoreNo.Visible = True
                FrmChUser.CmbStoreNo.Visible = True
                FrmChUser.ShowDialog()
                FrmChUser.Dispose()
                Sb1.Panels(1).Text = PubStoreName
            End If
        End If
    End Sub
    'Private Sub UiPanelManager1_PanelClosedChanged(ByVal sender As Object, ByVal e As Janus.Windows.UI.Dock.PanelActionEventArgs) Handles UiPanelManager1.PanelClosedChanged
    '    Dim c1 As New FrmWhatDoForMenu
    '    c1.BtnLeftText = "Yes"
    '    c1.BtnRightText = "No"
    '    c1.ShowFarMsg("Do you want this menu show next time you start the system?")
    '    If c1.DialogResult = DialogResult.OK Then
    '        Try
    '            If CmdGeneralForuserMDB.Connection.State <> ConnectionState.Open Then
    '                CmdGeneralForuserMDB.Connection.Open()
    '            End If
    '            CmdGeneralForuserMDB.CommandText = "Update Users Set ShowGraphicMenu=0 WHERE UserId=" & PUserCod
    '            CmdGeneralForuserMDB.ExecuteNonQuery()
    '        Catch ex As System.Data.SqlClient.SqlException
    '        End Try
    '    End If
    'End Sub
End Class
