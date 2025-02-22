Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmSearchItemCode
    Inherits FrmBase
    Public Event Item_noFind(ByVal ThisItemCode As String, ByVal ThisItemDesc As String)
    Dim FlgGroupBy As Boolean = True
    Dim So As New Janus.Windows.GridEX.SortOrder
    Dim MyFrmItemDetailShow As FrmItemDetailShow
    Dim Mcondition As String = ""
    Dim APubStoreNO As String = ""
    Public OnHandCondition As Boolean = False
    Private _FlagDoubleClkick As String = "1"
    Public Pricelevel As Integer = 1

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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CmdRowDetail As System.Windows.Forms.Button
    Friend WithEvents CmbGroupBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DaInv_Item As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsInv_Item1 As UCInv_Item.DSInv_Item
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaQuickReference As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupByChk As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents QuickAddItem As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GrdItem As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaIn_ItemWheel As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaInv_ItemAutoPart As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GridWheel As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridAutopart As Janus.Windows.GridEX.GridEX
    Friend WithEvents CmbStoreNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DASTORE_SETUP As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents CnnMdbSetup As System.Data.OleDb.OleDbConnection
    Friend WithEvents ChkLowestPrice As System.Windows.Forms.CheckBox
    Friend WithEvents CmdReload As Janus.Windows.EditControls.UIButton
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents backupautopart As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents backupwel As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmSearchItemCode))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout3 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CmdReload = New Janus.Windows.EditControls.UIButton
        Me.CmbStoreNo = New System.Windows.Forms.ComboBox
        Me.DsInv_Item1 = New UCInv_Item.DSInv_Item
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.GroupByChk = New System.Windows.Forms.CheckBox
        Me.CmbGroupBy = New System.Windows.Forms.ComboBox
        Me.CmdRowDetail = New System.Windows.Forms.Button
        Me.QuickAddItem = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ChkLowestPrice = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DaInv_Item = New System.Data.SqlClient.SqlDataAdapter
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DaQuickReference = New System.Data.SqlClient.SqlDataAdapter
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GrdItem = New Janus.Windows.GridEX.GridEX
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GridWheel = New Janus.Windows.GridEX.GridEX
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GridAutopart = New Janus.Windows.GridEX.GridEX
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DaIn_ItemWheel = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DaInv_ItemAutoPart = New System.Data.SqlClient.SqlDataAdapter
        Me.DASTORE_SETUP = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand
        Me.CnnMdbSetup = New System.Data.OleDb.OleDbConnection
        Me.backupautopart = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.backupwel = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Panel1.SuspendLayout()
        CType(Me.DsInv_Item1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.GrdItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.GridWheel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.GridAutopart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.CmdReload)
        Me.Panel1.Controls.Add(Me.CmbStoreNo)
        Me.Panel1.Controls.Add(Me.CheckBox4)
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Controls.Add(Me.GroupByChk)
        Me.Panel1.Controls.Add(Me.CmbGroupBy)
        Me.Panel1.Controls.Add(Me.CmdRowDetail)
        Me.Panel1.Controls.Add(Me.QuickAddItem)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(798, 40)
        Me.Panel1.TabIndex = 0
        '
        'CmdReload
        '
        Me.CmdReload.Location = New System.Drawing.Point(672, 8)
        Me.CmdReload.Name = "CmdReload"
        Me.CmdReload.Size = New System.Drawing.Size(102, 23)
        Me.CmdReload.TabIndex = 12
        Me.CmdReload.Text = "New Search"
        '
        'CmbStoreNo
        '
        Me.CmbStoreNo.DataSource = Me.DsInv_Item1.Store_Setup
        Me.CmbStoreNo.DisplayMember = "STORENO"
        Me.CmbStoreNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStoreNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbStoreNo.Location = New System.Drawing.Point(600, 8)
        Me.CmbStoreNo.Name = "CmbStoreNo"
        Me.CmbStoreNo.Size = New System.Drawing.Size(56, 21)
        Me.CmbStoreNo.TabIndex = 10
        Me.CmbStoreNo.ValueMember = "STORENO"
        '
        'DsInv_Item1
        '
        Me.DsInv_Item1.DataSetName = "DSInv_Item"
        Me.DsInv_Item1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'CheckBox4
        '
        Me.CheckBox4.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox4.Checked = True
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.Image = CType(resources.GetObject("CheckBox4.Image"), System.Drawing.Image)
        Me.CheckBox4.Location = New System.Drawing.Point(176, 8)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(24, 24)
        Me.CheckBox4.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.CheckBox4, "and Show Group By Box at top ")
        '
        'CheckBox3
        '
        Me.CheckBox3.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Image = CType(resources.GetObject("CheckBox3.Image"), System.Drawing.Image)
        Me.CheckBox3.Location = New System.Drawing.Point(152, 8)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(24, 24)
        Me.CheckBox3.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.CheckBox3, "Sort Order")
        '
        'GroupByChk
        '
        Me.GroupByChk.Appearance = System.Windows.Forms.Appearance.Button
        Me.GroupByChk.BackColor = System.Drawing.SystemColors.Control
        Me.GroupByChk.Checked = True
        Me.GroupByChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.GroupByChk.Image = CType(resources.GetObject("GroupByChk.Image"), System.Drawing.Image)
        Me.GroupByChk.Location = New System.Drawing.Point(128, 8)
        Me.GroupByChk.Name = "GroupByChk"
        Me.GroupByChk.Size = New System.Drawing.Size(24, 24)
        Me.GroupByChk.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.GroupByChk, "Group by or not")
        '
        'CmbGroupBy
        '
        Me.CmbGroupBy.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CmbGroupBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbGroupBy.Items.AddRange(New Object() {"Quick Ref.", "Size", "Description", "Line"})
        Me.CmbGroupBy.Location = New System.Drawing.Point(224, 8)
        Me.CmbGroupBy.Name = "CmbGroupBy"
        Me.CmbGroupBy.Size = New System.Drawing.Size(280, 21)
        Me.CmbGroupBy.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.CmbGroupBy, "Group by items with sort")
        '
        'CmdRowDetail
        '
        Me.CmdRowDetail.Image = CType(resources.GetObject("CmdRowDetail.Image"), System.Drawing.Image)
        Me.CmdRowDetail.Location = New System.Drawing.Point(104, 8)
        Me.CmdRowDetail.Name = "CmdRowDetail"
        Me.CmdRowDetail.Size = New System.Drawing.Size(24, 24)
        Me.CmdRowDetail.TabIndex = 1
        '
        'QuickAddItem
        '
        Me.QuickAddItem.BackColor = System.Drawing.SystemColors.Control
        Me.QuickAddItem.Location = New System.Drawing.Point(8, 8)
        Me.QuickAddItem.Name = "QuickAddItem"
        Me.QuickAddItem.Size = New System.Drawing.Size(88, 23)
        Me.QuickAddItem.TabIndex = 0
        Me.QuickAddItem.Text = "Add New Item"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(544, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Store No"
        '
        'CheckBox2
        '
        Me.CheckBox2.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(625, 44)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(152, 17)
        Me.CheckBox2.TabIndex = 6
        Me.CheckBox2.Text = "Show Out Of Stock Items"
        Me.CheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(604, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 19)
        Me.Label2.TabIndex = 5
        '
        'ChkLowestPrice
        '
        Me.ChkLowestPrice.BackColor = System.Drawing.SystemColors.Control
        Me.ChkLowestPrice.Location = New System.Drawing.Point(501, 44)
        Me.ChkLowestPrice.Name = "ChkLowestPrice"
        Me.ChkLowestPrice.Size = New System.Drawing.Size(88, 14)
        Me.ChkLowestPrice.TabIndex = 4
        Me.ChkLowestPrice.Text = "Lowest Price"
        Me.ChkLowestPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(481, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 21)
        Me.Label1.TabIndex = 3
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT inv_item.item_no, inv_item.cod_item_type, inv_item.desc_item, inv_tab_bran" & _
        "d.cod_brand, inv_item.cod_quick_refrence, inv_item.taxable, inv_tab_style.style," & _
        " inv_item.note, inv_item.picture, inv_item.upc, inv_item.special_notice, inv_ite" & _
        "m_quick_refrence.desc_quick_refrence, inv_tab_brand.complete_desc_brand AS abbre" & _
        "viation_desc_brand, inv_tab_line.line AS desc_line, inv_tab_item_warehouse.on_ha" & _
        "nd - inv_tab_item_warehouse.comitted AS on_hand, inv_item_cost_transaction.amoun" & _
        "t_price1 AS amount_price1, inv_item_cost_transaction.fet, inv_tab_line.treadwear" & _
        ", inv_tab_line.traction, inv_tab_line.temperature, inv_discount_item.onsale_chec" & _
        "k AS amount_onsale, inv_discount_item.spiff_check AS amount_spiff, inv_tab_tire_" & _
        "specification.service_description, inv_tab_tire_specification.tire_size, inv_tab" & _
        "_public.desc_table, inv_item_cost_transaction.cost, inv_item_cost_transaction.li" & _
        "st_price, inv_tab_item_warehouse.cod_warehouse, inv_tab_location_warehouse.desc_" & _
        "location, inv_item_cost_transaction.cost + inv_item_cost_transaction.delivery + " & _
        "inv_item_cost_transaction.frieght AS ReplcamentCost FROM inv_item_quick_refrence" & _
        " RIGHT OUTER JOIN inv_tab_location_warehouse RIGHT OUTER JOIN inv_tab_item_wareh" & _
        "ouse ON inv_tab_location_warehouse.cod_location = inv_tab_item_warehouse.cod_loc" & _
        "ation AND inv_tab_location_warehouse.cod_warehouse = inv_tab_item_warehouse.cod_" & _
        "warehouse RIGHT OUTER JOIN inv_tab_public RIGHT OUTER JOIN inv_tab_tire_specific" & _
        "ation ON inv_tab_public.cod_table_public = inv_tab_tire_specification.tire_size " & _
        "RIGHT OUTER JOIN inv_item ON inv_tab_tire_specification.item_no = inv_item.item_" & _
        "no LEFT OUTER JOIN inv_discount_item ON inv_item.item_no = inv_discount_item.ite" & _
        "m_no LEFT OUTER JOIN inv_item_cost_transaction ON inv_item.item_no = inv_item_co" & _
        "st_transaction.item_no ON inv_tab_item_warehouse.item_no = inv_item.item_no ON i" & _
        "nv_item_quick_refrence.cod_quick_refrence = inv_item.cod_quick_refrence LEFT OUT" & _
        "ER JOIN inv_tab_style RIGHT OUTER JOIN inv_tab_line ON inv_tab_style.style = inv" & _
        "_tab_line.style ON inv_item.line = inv_tab_line.line RIGHT OUTER JOIN inv_tab_br" & _
        "and ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand WHERE (inv_item_cost_tra" & _
        "nsaction.last_flag = 1) AND (inv_discount_item.last_flag = 1) AND (inv_item.cod_" & _
        "item_type = '01') AND (inv_tab_public.cod_main = '01') AND (inv_item.discontinue" & _
        "d = 0)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=FARAJIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;p" & _
        "ersist security info=True;password=sa"
        '
        'DaInv_Item
        '
        Me.DaInv_Item.SelectCommand = Me.SqlSelectCommand1
        Me.DaInv_Item.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("cod_item_type", "cod_item_type"), New System.Data.Common.DataColumnMapping("desc_item", "desc_item"), New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("cod_quick_refrence", "cod_quick_refrence"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("note", "note"), New System.Data.Common.DataColumnMapping("picture", "picture"), New System.Data.Common.DataColumnMapping("upc", "upc"), New System.Data.Common.DataColumnMapping("special_notice", "special_notice"), New System.Data.Common.DataColumnMapping("desc_quick_refrence", "desc_quick_refrence"), New System.Data.Common.DataColumnMapping("abbreviation_desc_brand", "abbreviation_desc_brand"), New System.Data.Common.DataColumnMapping("desc_line", "desc_line"), New System.Data.Common.DataColumnMapping("on_hand", "on_hand"), New System.Data.Common.DataColumnMapping("amount_price1", "amount_price1"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("treadwear", "treadwear"), New System.Data.Common.DataColumnMapping("traction", "traction"), New System.Data.Common.DataColumnMapping("temperature", "temperature"), New System.Data.Common.DataColumnMapping("amount_onsale", "amount_onsale"), New System.Data.Common.DataColumnMapping("amount_spiff", "amount_spiff"), New System.Data.Common.DataColumnMapping("service_description", "service_description"), New System.Data.Common.DataColumnMapping("tire_size", "tire_size"), New System.Data.Common.DataColumnMapping("desc_table", "desc_table"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("list_price", "list_price"), New System.Data.Common.DataColumnMapping("cod_warehouse", "cod_warehouse"), New System.Data.Common.DataColumnMapping("desc_location", "desc_location"), New System.Data.Common.DataColumnMapping("ReplcamentCost", "ReplcamentCost")})})
        '
        'ImageList2
        '
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Magenta
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cod_quick_refrence, desc_quick_refrence FROM inv_item_quick_refrence"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DaQuickReference
        '
        Me.DaQuickReference.SelectCommand = Me.SqlSelectCommand2
        Me.DaQuickReference.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item_quick_refrence", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_quick_refrence", "cod_quick_refrence"), New System.Data.Common.DataColumnMapping("desc_quick_refrence", "desc_quick_refrence")})})
        '
        'CmdOk
        '
        Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOk.Location = New System.Drawing.Point(616, 7)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 24)
        Me.CmdOk.TabIndex = 18
        Me.CmdOk.Text = "Ok"
        '
        'CmdExit
        '
        Me.CmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdExit.Location = New System.Drawing.Point(712, 7)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 24)
        Me.CmdExit.TabIndex = 17
        Me.CmdExit.Text = "Exit"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CmdOk)
        Me.Panel2.Controls.Add(Me.CmdExit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 415)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(798, 37)
        Me.Panel2.TabIndex = 19
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(8, 64)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 352)
        Me.TabControl1.TabIndex = 20
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GrdItem)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(768, 326)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tire"
        '
        'GrdItem
        '
        Me.GrdItem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdItem.AlternatingColors = True
        Me.GrdItem.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.White
        Me.GrdItem.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.GrdItem.DataMember = "inv_item"
        Me.GrdItem.DataSource = Me.DsInv_Item1
        GridEXLayout1.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage", CType(resources.GetObject("resource"), System.Drawing.Bitmap))})
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>inv_item</Caption><Columns Collection=""true" & _
        """><Column0 ID=""Icon""><ButtonDisplayMode>CurrentRow</ButtonDisplayMode><AllowSize" & _
        ">False</AllowSize><AllowSort>False</AllowSort><Bound>False</Bound><ButtonImage R" & _
        "eference=""GridEXLayoutData.RootTable.Columns.Column0.ButtonImage"" /><ButtonStyle" & _
        ">Ellipsis</ButtonStyle><EditType>NoEdit</EditType><ImageIndex>0</ImageIndex><Key" & _
        ">Icon</Key><Position>0</Position><Selectable>False</Selectable><Width>20</Width>" & _
        "</Column0><Column1 ID=""desc_quick_refrence""><Caption>Quick Ref.</Caption><DataMe" & _
        "mber>desc_quick_refrence</DataMember><DefaultGroupInterval>Text</DefaultGroupInt" & _
        "erval><Key>desc_quick_refrence</Key><Position>1</Position><CompareTarget>Text</C" & _
        "ompareTarget><Width>105</Width></Column1><Column2 ID=""item_no""><Caption>Item No<" & _
        "/Caption><TypeNameEmptyStringValue>System.String</TypeNameEmptyStringValue><Empt" & _
        "yStringValue /><DataMember>item_no</DataMember><Key>item_no</Key><Position>2</Po" & _
        "sition><Width>62</Width></Column2><Column3 ID=""on_hand""><Caption>QTY</Caption><D" & _
        "ataMember>on_hand</DataMember><Key>on_hand</Key><Position>3</Position><Width>41<" & _
        "/Width></Column3><Column4 ID=""desc_item""><Caption>Description</Caption><DataMemb" & _
        "er>desc_item</DataMember><Key>desc_item</Key><Position>4</Position><Width>307</W" & _
        "idth></Column4><Column5 ID=""amount_price1""><Caption>Price</Caption><DataMember>a" & _
        "mount_price1</DataMember><FormatString>c2</FormatString><Key>amount_price1</Key>" & _
        "<Position>5</Position><Width>86</Width></Column5><Column6 ID=""fet""><Caption>FET<" & _
        "/Caption><DataMember>fet</DataMember><FormatString>c2</FormatString><Key>fet</Ke" & _
        "y><Position>6</Position><Width>47</Width></Column6><Column7 ID=""ReplcamentCost"">" & _
        "<Caption>RC</Caption><DataMember>ReplcamentCost</DataMember><EditType>NoEdit</Ed" & _
        "itType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><K" & _
        "ey>ReplcamentCost</Key><Position>7</Position><Width>72</Width></Column7><Column8" & _
        " ID=""abbreviation_desc_brand""><Caption>Brand</Caption><DataMember>abbreviation_d" & _
        "esc_brand</DataMember><Key>abbreviation_desc_brand</Key><Position>8</Position><W" & _
        "idth>99</Width></Column8><Column9 ID=""desc_line""><Caption>Line</Caption><DataMem" & _
        "ber>desc_line</DataMember><Key>desc_line</Key><Position>9</Position><Width>107</" & _
        "Width><HeaderStyle><ForeColor>Navy</ForeColor><Font>Microsoft Sans Serif, 8.25pt" & _
        ", style=Bold</Font></HeaderStyle></Column9><Column10 ID=""service_description""><C" & _
        "aption>Service</Caption><DataMember>service_description</DataMember><Key>service" & _
        "_description</Key><Position>10</Position><Width>83</Width></Column10><Column11 I" & _
        "D=""UQGT""><Bound>False</Bound><Caption>UQTG</Caption><Key>UQGT</Key><Position>11<" & _
        "/Position><Width>86</Width><HeaderStyle><ForeColor>Navy</ForeColor><Font>Microso" & _
        "ft Sans Serif, 8.25pt, style=Bold</Font></HeaderStyle></Column11><Column12 ID=""d" & _
        "esc_table""><Caption>Size</Caption><DataMember>desc_table</DataMember><Key>desc_t" & _
        "able</Key><Position>12</Position><Width>91</Width></Column12><Column13 ID=""tread" & _
        "wear""><Caption>treadwear</Caption><DataMember>treadwear</DataMember><Key>treadwe" & _
        "ar</Key><Position>13</Position><Visible>False</Visible></Column13><Column14 ID=""" & _
        "traction""><Caption>traction</Caption><DataMember>traction</DataMember><Key>tract" & _
        "ion</Key><Position>14</Position><Visible>False</Visible></Column14><Column15 ID=" & _
        """temperature""><Caption>temperature</Caption><DataMember>temperature</DataMember>" & _
        "<Key>temperature</Key><Position>15</Position><Visible>False</Visible></Column15>" & _
        "<Column16 ID=""desc_location""><Caption>Bin Location</Caption><DataMember>desc_loc" & _
        "ation</DataMember><Key>desc_location</Key><Position>16</Position></Column16><Col" & _
        "umn17 ID=""amount_spiff""><Caption>SPiff</Caption><ColumnType>CheckBox</ColumnType" & _
        "><DataMember>amount_spiff</DataMember><EditType>CheckBox</EditType><FormatString" & _
        ">c2</FormatString><Key>amount_spiff</Key><Position>17</Position><Width>35</Width" & _
        "></Column17><Column18 ID=""amount_onsale""><Caption>OnSale</Caption><ColumnType>Ch" & _
        "eckBox</ColumnType><DataMember>amount_onsale</DataMember><EditType>CheckBox</Edi" & _
        "tType><FormatString>c2</FormatString><Key>amount_onsale</Key><Position>18</Posit" & _
        "ion><Width>47</Width></Column18></Columns><FormatConditions Collection=""true""><C" & _
        "ondition0 ID=""FormatCondition1""><ColIndex>3</ColIndex><ConditionOperator>LessTha" & _
        "nOrEqualTo</ConditionOperator><FormatStyle><BackColor>255, 128, 128</BackColor><" & _
        "/FormatStyle><Value1>0</Value1><Key>FormatCondition1</Key></Condition0><Conditio" & _
        "n1 ID=""FormatCondition2""><ColIndex>17</ColIndex><FormatStyle><BackColor>249, 232" & _
        ", 15</BackColor></FormatStyle><Value1>False</Value1><Key>FormatCondition2</Key><" & _
        "/Condition1><Condition2 ID=""FormatCondition3""><ColIndex>18</ColIndex><FormatStyl" & _
        "e><BackColor>192, 208, 159</BackColor></FormatStyle><Value1>False</Value1><Key>F" & _
        "ormatCondition3</Key></Condition2></FormatConditions><GroupCondition ID="""" /><Ke" & _
        "y>inv_item</Key></RootTable><DropDowns Collection=""true""><DropDown0><RootTable><" & _
        "Columns Collection=""true""><Column0 ID=""cod_quick_refrence""><Caption>Cod</Caption" & _
        "><DataMember>cod_quick_refrence</DataMember><Key>cod_quick_refrence</Key><Positi" & _
        "on>0</Position></Column0><Column1 ID=""desc_quick_refrence""><Caption>Quick Ref</C" & _
        "aption><DataMember>desc_quick_refrence</DataMember><Key>desc_quick_refrence</Key" & _
        "><Position>1</Position></Column1></Columns><GroupCondition ID="""" /></RootTable><" & _
        "WatermarkImage /><Font>Microsoft Sans Serif, 8.25pt</Font><ControlStyle /><Allow" & _
        "Edit>False</AllowEdit><ExpandableGroups>False</ExpandableGroups><GroupByBoxVisib" & _
        "le>False</GroupByBoxVisible><HideSelection>Highlight</HideSelection><Key>QuickRe" & _
        "f</Key><DisplayMember>desc_quick_refrence</DisplayMember><ValueMember>desc_quick" & _
        "_refrence</ValueMember></DropDown0></DropDowns></GridEXLayoutData>"
        Me.GrdItem.DesignTimeLayout = GridEXLayout1
        Me.GrdItem.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrdItem.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdItem.ExternalImageList = Me.ImageList1
        Me.GrdItem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdItem.FilterRowFormatStyle.BackColor = System.Drawing.Color.Navy
        Me.GrdItem.FilterRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.GrdItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdItem.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GrdItem.Location = New System.Drawing.Point(0, 0)
        Me.GrdItem.Name = "GrdItem"
        Me.GrdItem.PreviewRowFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat
        Me.GrdItem.RecordNavigator = True
        Me.GrdItem.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdItem.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdItem.Size = New System.Drawing.Size(768, 320)
        Me.GrdItem.TabIndex = 0
        Me.GrdItem.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        Me.GrdItem.TableHeaderFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GridWheel)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(768, 326)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Wheel"
        '
        'GridWheel
        '
        Me.GridWheel.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridWheel.AlternatingColors = True
        Me.GridWheel.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.White
        Me.GridWheel.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.GridWheel.DataMember = "Inv_ItemWheel"
        Me.GridWheel.DataSource = Me.DsInv_Item1
        GridEXLayout2.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage", CType(resources.GetObject("resource1"), System.Drawing.Bitmap))})
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Caption>inv_item</Caption><Columns Collection=""true" & _
        """><Column0 ID=""Icon""><ButtonDisplayMode>CurrentRow</ButtonDisplayMode><AllowSize" & _
        ">False</AllowSize><AllowSort>False</AllowSort><Bound>False</Bound><ButtonImage R" & _
        "eference=""GridEXLayoutData.RootTable.Columns.Column0.ButtonImage"" /><ButtonStyle" & _
        ">Ellipsis</ButtonStyle><EditType>NoEdit</EditType><ImageIndex>0</ImageIndex><Key" & _
        ">Icon</Key><Position>0</Position><Selectable>False</Selectable><Width>20</Width>" & _
        "</Column0><Column1 ID=""desc_quick_refrence""><Caption>Quick Ref.</Caption><DataMe" & _
        "mber>desc_quick_refrence</DataMember><DefaultGroupInterval>Text</DefaultGroupInt" & _
        "erval><EditType>MultiColumnCombo</EditType><Key>desc_quick_refrence</Key><Positi" & _
        "on>1</Position><CompareTarget>Text</CompareTarget><Width>105</Width></Column1><C" & _
        "olumn2 ID=""item_no""><Caption>Item No</Caption><TypeNameEmptyStringValue>System.S" & _
        "tring</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>item_no</DataMem" & _
        "ber><Key>item_no</Key><Position>2</Position><Width>62</Width></Column2><Column3 " & _
        "ID=""on_hand""><Caption>QTY</Caption><DataMember>on_hand</DataMember><Key>on_hand<" & _
        "/Key><Position>3</Position><Width>41</Width></Column3><Column4 ID=""desc_item""><C" & _
        "aption>Description</Caption><DataMember>desc_item</DataMember><Key>desc_item</Ke" & _
        "y><Position>4</Position><Width>307</Width></Column4><Column5 ID=""amount_price1"">" & _
        "<Caption>Price</Caption><DataMember>amount_price1</DataMember><Key>amount_price1" & _
        "</Key><Position>5</Position><Width>86</Width></Column5><Column6 ID=""ReplcamentCo" & _
        "st""><Caption>RC</Caption><DataMember>ReplcamentCost</DataMember><EditType>NoEdit" & _
        "</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatStrin" & _
        "g><Key>ReplcamentCost</Key><Position>6</Position><Width>81</Width></Column6><Col" & _
        "umn7 ID=""abbreviation_desc_brand""><Caption>Brand</Caption><DataMember>abbreviati" & _
        "on_desc_brand</DataMember><Key>abbreviation_desc_brand</Key><Position>7</Positio" & _
        "n><Width>99</Width></Column7><Column8 ID=""desc_line""><Caption>Line</Caption><Dat" & _
        "aMember>desc_line</DataMember><Key>desc_line</Key><Position>8</Position><Width>1" & _
        "07</Width><HeaderStyle><ForeColor>Navy</ForeColor><Font>Microsoft Sans Serif, 8." & _
        "25pt, style=Bold</Font></HeaderStyle></Column8><Column9 ID=""treadwear""><Caption>" & _
        "treadwear</Caption><DataMember>treadwear</DataMember><Key>treadwear</Key><Positi" & _
        "on>9</Position><Visible>False</Visible></Column9><Column10 ID=""traction""><Captio" & _
        "n>traction</Caption><DataMember>traction</DataMember><Key>traction</Key><Positio" & _
        "n>10</Position><Visible>False</Visible></Column10><Column11 ID=""temperature""><Ca" & _
        "ption>temperature</Caption><DataMember>temperature</DataMember><Key>temperature<" & _
        "/Key><Position>11</Position><Visible>False</Visible></Column11><Column12 ID=""ofs" & _
        "et""><Caption>Offset</Caption><DataMember>ofset</DataMember><Key>ofset</Key><Posi" & _
        "tion>12</Position><Width>83</Width></Column12><Column13 ID=""bolt_pattern""><Capti" & _
        "on>Bolt Pattern</Caption><DataMember>bolt_pattern</DataMember><Key>bolt_pattern<" & _
        "/Key><Position>13</Position><Width>92</Width></Column13><Column14 ID=""max_diamet" & _
        "er""><Caption>Max Diameter</Caption><DataMember>max_diameter</DataMember><Key>max" & _
        "_diameter</Key><Position>14</Position><Width>94</Width></Column14><Column15 ID=""" & _
        "desc_table""><Caption>Wheel Size</Caption><DataMember>desc_table</DataMember><Key" & _
        ">desc_table</Key><Position>15</Position><Width>91</Width></Column15><Column16 ID" & _
        "=""amount_spiff""><Caption>SPiff</Caption><ColumnType>CheckBox</ColumnType><DataMe" & _
        "mber>amount_spiff</DataMember><EditType>CheckBox</EditType><Key>amount_spiff</Ke" & _
        "y><Position>16</Position><Width>35</Width></Column16><Column17 ID=""amount_onsale" & _
        """><Caption>OnSale</Caption><ColumnType>CheckBox</ColumnType><DataMember>amount_o" & _
        "nsale</DataMember><EditType>CheckBox</EditType><Key>amount_onsale</Key><Position" & _
        ">17</Position><Width>47</Width></Column17></Columns><FormatConditions Collection" & _
        "=""true""><Condition0 ID=""FormatCondition1""><ColIndex>3</ColIndex><ConditionOperat" & _
        "or>LessThanOrEqualTo</ConditionOperator><FormatStyle><BackColor>255, 128, 128</B" & _
        "ackColor></FormatStyle><Value1>0</Value1><Key>FormatCondition1</Key></Condition0" & _
        "><Condition1 ID=""FormatCondition2""><ColIndex>16</ColIndex><FormatStyle><BackColo" & _
        "r>249, 232, 15</BackColor></FormatStyle><Value1>False</Value1><Key>FormatConditi" & _
        "on2</Key></Condition1><Condition2 ID=""FormatCondition3""><ColIndex>17</ColIndex><" & _
        "FormatStyle><BackColor>192, 208, 159</BackColor></FormatStyle><Value1>False</Val" & _
        "ue1><Key>FormatCondition3</Key></Condition2></FormatConditions><GroupCondition I" & _
        "D="""" /><Key>inv_item</Key></RootTable><DropDowns Collection=""true""><DropDown0><R" & _
        "ootTable><Columns Collection=""true""><Column0 ID=""cod_quick_refrence""><Caption>Co" & _
        "d</Caption><DataMember>cod_quick_refrence</DataMember><Key>cod_quick_refrence</K" & _
        "ey><Position>0</Position></Column0><Column1 ID=""desc_quick_refrence""><Caption>Qu" & _
        "ick Ref</Caption><DataMember>desc_quick_refrence</DataMember><Key>desc_quick_ref" & _
        "rence</Key><Position>1</Position></Column1></Columns><GroupCondition ID="""" /></R" & _
        "ootTable><WatermarkImage /><Font>Microsoft Sans Serif, 8.25pt</Font><ControlStyl" & _
        "e /><AllowEdit>False</AllowEdit><ExpandableGroups>False</ExpandableGroups><Group" & _
        "ByBoxVisible>False</GroupByBoxVisible><HideSelection>Highlight</HideSelection><K" & _
        "ey>QuickRef</Key><DisplayMember>desc_quick_refrence</DisplayMember><ValueMember>" & _
        "desc_quick_refrence</ValueMember></DropDown0></DropDowns></GridEXLayoutData>"
        Me.GridWheel.DesignTimeLayout = GridEXLayout2
        Me.GridWheel.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridWheel.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridWheel.ExternalImageList = Me.ImageList1
        Me.GridWheel.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridWheel.FilterRowFormatStyle.BackColor = System.Drawing.Color.Navy
        Me.GridWheel.FilterRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.GridWheel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridWheel.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridWheel.Location = New System.Drawing.Point(0, 0)
        Me.GridWheel.Name = "GridWheel"
        Me.GridWheel.PreviewRowFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat
        Me.GridWheel.RecordNavigator = True
        Me.GridWheel.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridWheel.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GridWheel.Size = New System.Drawing.Size(768, 317)
        Me.GridWheel.TabIndex = 4
        Me.GridWheel.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        Me.GridWheel.TableHeaderFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GridAutopart)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(768, 326)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "AutoPart"
        '
        'GridAutopart
        '
        Me.GridAutopart.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridAutopart.AlternatingColors = True
        Me.GridAutopart.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.White
        Me.GridAutopart.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.GridAutopart.DataMember = "inv_ItemAutoPart"
        Me.GridAutopart.DataSource = Me.DsInv_Item1
        GridEXLayout3.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage", CType(resources.GetObject("resource2"), System.Drawing.Bitmap))})
        GridEXLayout3.LayoutString = "<GridEXLayoutData><RootTable><Caption>inv_item</Caption><Columns Collection=""true" & _
        """><Column0 ID=""Icon""><ButtonDisplayMode>CurrentRow</ButtonDisplayMode><AllowSize" & _
        ">False</AllowSize><AllowSort>False</AllowSort><Bound>False</Bound><ButtonImage R" & _
        "eference=""GridEXLayoutData.RootTable.Columns.Column0.ButtonImage"" /><ButtonStyle" & _
        ">Ellipsis</ButtonStyle><EditType>NoEdit</EditType><ImageIndex>0</ImageIndex><Key" & _
        ">Icon</Key><Position>0</Position><Selectable>False</Selectable><Width>20</Width>" & _
        "</Column0><Column1 ID=""desc_quick_refrence""><Caption>Quick Ref.</Caption><DataMe" & _
        "mber>desc_quick_refrence</DataMember><DefaultGroupInterval>Text</DefaultGroupInt" & _
        "erval><EditType>MultiColumnCombo</EditType><Key>desc_quick_refrence</Key><Positi" & _
        "on>1</Position><CompareTarget>Text</CompareTarget><Width>105</Width></Column1><C" & _
        "olumn2 ID=""item_no""><Caption>Item No</Caption><TypeNameEmptyStringValue>System.S" & _
        "tring</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>item_no</DataMem" & _
        "ber><Key>item_no</Key><Position>2</Position><Width>62</Width></Column2><Column3 " & _
        "ID=""on_hand""><Caption>QTY</Caption><DataMember>on_hand</DataMember><Key>on_hand<" & _
        "/Key><Position>3</Position><Width>41</Width></Column3><Column4 ID=""desc_item""><C" & _
        "aption>Description</Caption><DataMember>desc_item</DataMember><Key>desc_item</Ke" & _
        "y><Position>4</Position><Width>307</Width></Column4><Column5 ID=""amount_price1"">" & _
        "<Caption>Price</Caption><DataMember>amount_price1</DataMember><Key>amount_price1" & _
        "</Key><Position>5</Position><Width>86</Width></Column5><Column6 ID=""ReplcamentCo" & _
        "st""><Caption>Rc</Caption><DataMember>ReplcamentCost</DataMember><EditType>NoEdit" & _
        "</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatStrin" & _
        "g><Key>ReplcamentCost</Key><Position>6</Position></Column6><Column7 ID=""abbrevia" & _
        "tion_desc_brand""><Caption>Brand</Caption><DataMember>abbreviation_desc_brand</Da" & _
        "taMember><Key>abbreviation_desc_brand</Key><Position>7</Position><Width>99</Widt" & _
        "h></Column7><Column8 ID=""desc_line""><Caption>Line</Caption><DataMember>desc_line" & _
        "</DataMember><Key>desc_line</Key><Position>8</Position><Width>107</Width><Header" & _
        "Style><ForeColor>Navy</ForeColor><Font>Microsoft Sans Serif, 8.25pt, style=Bold<" & _
        "/Font></HeaderStyle></Column8><Column9 ID=""treadwear""><Caption>treadwear</Captio" & _
        "n><DataMember>treadwear</DataMember><Key>treadwear</Key><Position>9</Position><V" & _
        "isible>False</Visible></Column9><Column10 ID=""traction""><Caption>traction</Capti" & _
        "on><DataMember>traction</DataMember><Key>traction</Key><Position>10</Position><V" & _
        "isible>False</Visible></Column10><Column11 ID=""temperature""><Caption>temperature" & _
        "</Caption><DataMember>temperature</DataMember><Key>temperature</Key><Position>11" & _
        "</Position><Visible>False</Visible></Column11><Column12 ID=""core_cost""><Caption>" & _
        "Core Value</Caption><DataMember>core_cost</DataMember><Key>core_cost</Key><Posit" & _
        "ion>12</Position></Column12><Column13 ID=""amount_spiff""><Caption>SPiff</Caption>" & _
        "<ColumnType>CheckBox</ColumnType><DataMember>amount_spiff</DataMember><EditType>" & _
        "CheckBox</EditType><Key>amount_spiff</Key><Position>13</Position><Width>35</Widt" & _
        "h></Column13><Column14 ID=""amount_onsale""><Caption>OnSale</Caption><ColumnType>C" & _
        "heckBox</ColumnType><DataMember>amount_onsale</DataMember><EditType>CheckBox</Ed" & _
        "itType><Key>amount_onsale</Key><Position>14</Position><Width>47</Width></Column1" & _
        "4></Columns><FormatConditions Collection=""true""><Condition0 ID=""FormatCondition1" & _
        """><ColIndex>3</ColIndex><ConditionOperator>LessThanOrEqualTo</ConditionOperator>" & _
        "<FormatStyle><BackColor>255, 128, 128</BackColor></FormatStyle><Value1>0</Value1" & _
        "><Key>FormatCondition1</Key></Condition0><Condition1 ID=""FormatCondition2""><ColI" & _
        "ndex>13</ColIndex><FormatStyle><BackColor>249, 232, 15</BackColor></FormatStyle>" & _
        "<Value1>False</Value1><Key>FormatCondition2</Key></Condition1><Condition2 ID=""Fo" & _
        "rmatCondition3""><ColIndex>14</ColIndex><FormatStyle><BackColor>192, 208, 159</Ba" & _
        "ckColor></FormatStyle><Value1>False</Value1><Key>FormatCondition3</Key></Conditi" & _
        "on2></FormatConditions><GroupCondition ID="""" /><Key>inv_item</Key></RootTable><D" & _
        "ropDowns Collection=""true""><DropDown0><RootTable><Columns Collection=""true""><Col" & _
        "umn0 ID=""cod_quick_refrence""><Caption>Cod</Caption><DataMember>cod_quick_refrenc" & _
        "e</DataMember><Key>cod_quick_refrence</Key><Position>0</Position></Column0><Colu" & _
        "mn1 ID=""desc_quick_refrence""><Caption>Quick Ref</Caption><DataMember>desc_quick_" & _
        "refrence</DataMember><Key>desc_quick_refrence</Key><Position>1</Position></Colum" & _
        "n1></Columns><GroupCondition ID="""" /></RootTable><WatermarkImage /><Font>Microso" & _
        "ft Sans Serif, 8.25pt</Font><ControlStyle /><AllowEdit>False</AllowEdit><Expanda" & _
        "bleGroups>False</ExpandableGroups><GroupByBoxVisible>False</GroupByBoxVisible><H" & _
        "ideSelection>Highlight</HideSelection><Key>QuickRef</Key><DisplayMember>desc_qui" & _
        "ck_refrence</DisplayMember><ValueMember>desc_quick_refrence</ValueMember></DropD" & _
        "own0></DropDowns></GridEXLayoutData>"
        Me.GridAutopart.DesignTimeLayout = GridEXLayout3
        Me.GridAutopart.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridAutopart.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridAutopart.ExternalImageList = Me.ImageList1
        Me.GridAutopart.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridAutopart.FilterRowFormatStyle.BackColor = System.Drawing.Color.Navy
        Me.GridAutopart.FilterRowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.GridAutopart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridAutopart.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridAutopart.Location = New System.Drawing.Point(0, 0)
        Me.GridAutopart.Name = "GridAutopart"
        Me.GridAutopart.PreviewRowFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat
        Me.GridAutopart.RecordNavigator = True
        Me.GridAutopart.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridAutopart.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GridAutopart.Size = New System.Drawing.Size(768, 317)
        Me.GridAutopart.TabIndex = 5
        Me.GridAutopart.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        Me.GridAutopart.TableHeaderFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT inv_item.item_no, inv_item.cod_item_type, inv_item.desc_item, inv_tab_bran" & _
        "d.cod_brand, inv_item.cod_quick_refrence, inv_item.taxable, inv_tab_style.style," & _
        " inv_item.note, inv_item.picture, inv_item.upc, inv_item.special_notice, inv_ite" & _
        "m_quick_refrence.desc_quick_refrence, inv_tab_brand.complete_desc_brand AS abbre" & _
        "viation_desc_brand, inv_tab_line.line AS desc_line, inv_tab_item_warehouse.on_ha" & _
        "nd - inv_tab_item_warehouse.comitted AS on_hand, inv_item_cost_transaction.amoun" & _
        "t_price1 AS amount_price1, inv_item_cost_transaction.fet, inv_tab_line.treadwear" & _
        ", inv_tab_line.traction, inv_tab_line.temperature, inv_discount_item.onsale_chec" & _
        "k AS amount_onsale, inv_discount_item.spiff_check AS amount_spiff, inv_tab_publi" & _
        "c.desc_table, inv_item_cost_transaction.cost, inv_item_cost_transaction.list_pri" & _
        "ce, inv_tab_item_warehouse.cod_warehouse, inv_tab_location_warehouse.desc_locati" & _
        "on, inv_item_cost_transaction.cost + inv_item_cost_transaction.delivery + inv_it" & _
        "em_cost_transaction.frieght AS ReplcamentCost, inv_tab_wheels_specification.ofse" & _
        "t, inv_tab_wheels_specification.bolt_pattern, inv_tab_wheels_specification.max_d" & _
        "iameter, inv_tab_wheels_specification.lug_size, inv_tab_wheels_specification.bac" & _
        "kside FROM inv_tab_public RIGHT OUTER JOIN inv_tab_brand LEFT OUTER JOIN inv_tab" & _
        "_location_warehouse RIGHT OUTER JOIN inv_tab_item_warehouse ON inv_tab_location_" & _
        "warehouse.cod_location = inv_tab_item_warehouse.cod_location AND inv_tab_locatio" & _
        "n_warehouse.cod_warehouse = inv_tab_item_warehouse.cod_warehouse RIGHT OUTER JOI" & _
        "N inv_item_cost_transaction RIGHT OUTER JOIN inv_tab_wheels_specification RIGHT " & _
        "OUTER JOIN inv_item ON inv_tab_wheels_specification.item_no = inv_item.item_no L" & _
        "EFT OUTER JOIN inv_discount_item ON inv_item.item_no = inv_discount_item.item_no" & _
        " ON inv_item_cost_transaction.item_no = inv_item.item_no ON inv_tab_item_warehou" & _
        "se.item_no = inv_item.item_no LEFT OUTER JOIN inv_item_quick_refrence ON inv_ite" & _
        "m.cod_quick_refrence = inv_item_quick_refrence.cod_quick_refrence LEFT OUTER JOI" & _
        "N inv_tab_style RIGHT OUTER JOIN inv_tab_line ON inv_tab_style.style = inv_tab_l" & _
        "ine.style ON inv_item.line = inv_tab_line.line ON inv_tab_brand.cod_brand = inv_" & _
        "tab_line.cod_brand ON inv_tab_public.cod_table_public = inv_tab_wheels_specifica" & _
        "tion.wheel_size WHERE (inv_item_cost_transaction.last_flag = 1) AND (inv_discoun" & _
        "t_item.last_flag = 1) AND (inv_item.cod_item_type = '04') AND (inv_tab_public.co" & _
        "d_main = '09')"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DaIn_ItemWheel
        '
        Me.DaIn_ItemWheel.SelectCommand = Me.SqlSelectCommand3
        Me.DaIn_ItemWheel.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_ItemWheel", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("cod_item_type", "cod_item_type"), New System.Data.Common.DataColumnMapping("desc_item", "desc_item"), New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("cod_quick_refrence", "cod_quick_refrence"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("note", "note"), New System.Data.Common.DataColumnMapping("picture", "picture"), New System.Data.Common.DataColumnMapping("upc", "upc"), New System.Data.Common.DataColumnMapping("special_notice", "special_notice"), New System.Data.Common.DataColumnMapping("desc_quick_refrence", "desc_quick_refrence"), New System.Data.Common.DataColumnMapping("abbreviation_desc_brand", "abbreviation_desc_brand"), New System.Data.Common.DataColumnMapping("desc_line", "desc_line"), New System.Data.Common.DataColumnMapping("on_hand", "on_hand"), New System.Data.Common.DataColumnMapping("amount_price1", "amount_price1"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("treadwear", "treadwear"), New System.Data.Common.DataColumnMapping("traction", "traction"), New System.Data.Common.DataColumnMapping("temperature", "temperature"), New System.Data.Common.DataColumnMapping("amount_onsale", "amount_onsale"), New System.Data.Common.DataColumnMapping("amount_spiff", "amount_spiff"), New System.Data.Common.DataColumnMapping("service_description", "service_description"), New System.Data.Common.DataColumnMapping("tire_size", "tire_size"), New System.Data.Common.DataColumnMapping("desc_table", "desc_table"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("list_price", "list_price"), New System.Data.Common.DataColumnMapping("cod_warehouse", "cod_warehouse"), New System.Data.Common.DataColumnMapping("desc_location", "desc_location"), New System.Data.Common.DataColumnMapping("ReplcamentCost", "ReplcamentCost")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT inv_item.item_no, inv_item.cod_item_type, inv_item.desc_item, inv_tab_bran" & _
        "d.cod_brand, inv_item.cod_quick_refrence, inv_item.taxable, inv_tab_style.style," & _
        " inv_item.note, inv_item.picture, inv_item.upc, inv_item.special_notice, inv_ite" & _
        "m_quick_refrence.desc_quick_refrence, inv_tab_brand.complete_desc_brand AS abbre" & _
        "viation_desc_brand, inv_tab_line.line AS desc_line, inv_tab_item_warehouse.on_ha" & _
        "nd - inv_tab_item_warehouse.comitted AS on_hand, inv_item_cost_transaction.amoun" & _
        "t_price1 AS amount_price1, inv_item_cost_transaction.fet, inv_tab_line.treadwear" & _
        ", inv_tab_line.traction, inv_tab_line.temperature, inv_discount_item.onsale_chec" & _
        "k AS amount_onsale, inv_discount_item.spiff_check AS amount_spiff, inv_item_cost" & _
        "_transaction.cost, inv_item_cost_transaction.list_price, inv_tab_item_warehouse." & _
        "cod_warehouse, inv_tab_location_warehouse.desc_location, inv_item_cost_transacti" & _
        "on.cost + inv_item_cost_transaction.delivery + inv_item_cost_transaction.frieght" & _
        " AS ReplcamentCost, inv_tab_autopart_specification.core_cost FROM inv_item_quick" & _
        "_refrence RIGHT OUTER JOIN inv_tab_location_warehouse RIGHT OUTER JOIN inv_tab_i" & _
        "tem_warehouse ON inv_tab_location_warehouse.cod_location = inv_tab_item_warehous" & _
        "e.cod_location AND inv_tab_location_warehouse.cod_warehouse = inv_tab_item_wareh" & _
        "ouse.cod_warehouse RIGHT OUTER JOIN inv_tab_autopart_specification RIGHT OUTER J" & _
        "OIN inv_item ON inv_tab_autopart_specification.item_no = inv_item.item_no LEFT O" & _
        "UTER JOIN inv_discount_item ON inv_item.item_no = inv_discount_item.item_no LEFT" & _
        " OUTER JOIN inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transa" & _
        "ction.item_no ON inv_tab_item_warehouse.item_no = inv_item.item_no ON inv_item_q" & _
        "uick_refrence.cod_quick_refrence = inv_item.cod_quick_refrence LEFT OUTER JOIN i" & _
        "nv_tab_style RIGHT OUTER JOIN inv_tab_line ON inv_tab_style.style = inv_tab_line" & _
        ".style ON inv_item.line = inv_tab_line.line RIGHT OUTER JOIN inv_tab_brand ON in" & _
        "v_tab_line.cod_brand = inv_tab_brand.cod_brand WHERE (inv_item_cost_transaction." & _
        "last_flag = 1) AND (inv_discount_item.last_flag = 1) AND (inv_item.cod_item_type" & _
        " NOT IN ('01', '04'))"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'DaInv_ItemAutoPart
        '
        Me.DaInv_ItemAutoPart.SelectCommand = Me.SqlSelectCommand4
        Me.DaInv_ItemAutoPart.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_ItemAutoPart", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("cod_item_type", "cod_item_type"), New System.Data.Common.DataColumnMapping("desc_item", "desc_item"), New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("cod_quick_refrence", "cod_quick_refrence"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("note", "note"), New System.Data.Common.DataColumnMapping("picture", "picture"), New System.Data.Common.DataColumnMapping("upc", "upc"), New System.Data.Common.DataColumnMapping("special_notice", "special_notice"), New System.Data.Common.DataColumnMapping("desc_quick_refrence", "desc_quick_refrence"), New System.Data.Common.DataColumnMapping("abbreviation_desc_brand", "abbreviation_desc_brand"), New System.Data.Common.DataColumnMapping("desc_line", "desc_line"), New System.Data.Common.DataColumnMapping("on_hand", "on_hand"), New System.Data.Common.DataColumnMapping("amount_price1", "amount_price1"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("treadwear", "treadwear"), New System.Data.Common.DataColumnMapping("traction", "traction"), New System.Data.Common.DataColumnMapping("temperature", "temperature"), New System.Data.Common.DataColumnMapping("amount_onsale", "amount_onsale"), New System.Data.Common.DataColumnMapping("amount_spiff", "amount_spiff"), New System.Data.Common.DataColumnMapping("service_description", "service_description"), New System.Data.Common.DataColumnMapping("tire_size", "tire_size"), New System.Data.Common.DataColumnMapping("desc_table", "desc_table"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("list_price", "list_price"), New System.Data.Common.DataColumnMapping("cod_warehouse", "cod_warehouse"), New System.Data.Common.DataColumnMapping("desc_location", "desc_location"), New System.Data.Common.DataColumnMapping("ReplcamentCost", "ReplcamentCost")})})
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
        'CnnMdbSetup
        '
        Me.CnnMdbSetup.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\TireMate\TireMatesetup.mdb;Persis" & _
        "t Security Info=True;Jet OLEDB:Database Password=5332"
        '
        'backupautopart
        '
        Me.backupautopart.SelectCommand = Me.SqlCommand1
        Me.backupautopart.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_ItemAutoPart", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("cod_item_type", "cod_item_type"), New System.Data.Common.DataColumnMapping("desc_item", "desc_item"), New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("cod_quick_refrence", "cod_quick_refrence"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("note", "note"), New System.Data.Common.DataColumnMapping("picture", "picture"), New System.Data.Common.DataColumnMapping("upc", "upc"), New System.Data.Common.DataColumnMapping("special_notice", "special_notice"), New System.Data.Common.DataColumnMapping("desc_quick_refrence", "desc_quick_refrence"), New System.Data.Common.DataColumnMapping("abbreviation_desc_brand", "abbreviation_desc_brand"), New System.Data.Common.DataColumnMapping("desc_line", "desc_line"), New System.Data.Common.DataColumnMapping("on_hand", "on_hand"), New System.Data.Common.DataColumnMapping("amount_price1", "amount_price1"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("treadwear", "treadwear"), New System.Data.Common.DataColumnMapping("traction", "traction"), New System.Data.Common.DataColumnMapping("temperature", "temperature"), New System.Data.Common.DataColumnMapping("amount_onsale", "amount_onsale"), New System.Data.Common.DataColumnMapping("amount_spiff", "amount_spiff"), New System.Data.Common.DataColumnMapping("service_description", "service_description"), New System.Data.Common.DataColumnMapping("tire_size", "tire_size"), New System.Data.Common.DataColumnMapping("desc_table", "desc_table"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("list_price", "list_price"), New System.Data.Common.DataColumnMapping("cod_warehouse", "cod_warehouse"), New System.Data.Common.DataColumnMapping("desc_location", "desc_location"), New System.Data.Common.DataColumnMapping("ReplcamentCost", "ReplcamentCost")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT inv_item.item_no, inv_item.cod_item_type, inv_item.desc_item, inv_tab_bran" & _
        "d.cod_brand, inv_item.cod_quick_refrence, inv_item.taxable, inv_tab_style.style," & _
        " inv_item.note, inv_item.picture, inv_item.upc, inv_item.special_notice, inv_ite" & _
        "m_quick_refrence.desc_quick_refrence, inv_tab_brand.complete_desc_brand AS abbre" & _
        "viation_desc_brand, inv_tab_line.line AS desc_line, inv_tab_item_warehouse.on_ha" & _
        "nd - inv_tab_item_warehouse.comitted AS on_hand, inv_item_cost_transaction.amoun" & _
        "t_price1 AS amount_price1, inv_item_cost_transaction.fet, inv_tab_line.treadwear" & _
        ", inv_tab_line.traction, inv_tab_line.temperature, inv_discount_item.onsale_chec" & _
        "k AS amount_onsale, inv_discount_item.spiff_check AS amount_spiff, inv_tab_tire_" & _
        "specification.service_description, inv_tab_tire_specification.tire_size, inv_tab" & _
        "_public.desc_table, inv_item_cost_transaction.cost, inv_item_cost_transaction.li" & _
        "st_price, inv_tab_item_warehouse.cod_warehouse, inv_tab_location_warehouse.desc_" & _
        "location, inv_item_cost_transaction.cost + inv_item_cost_transaction.delivery + " & _
        "inv_item_cost_transaction.frieght AS ReplcamentCost FROM inv_item_quick_refrence" & _
        " RIGHT OUTER JOIN inv_tab_location_warehouse RIGHT OUTER JOIN inv_tab_item_wareh" & _
        "ouse ON inv_tab_location_warehouse.cod_location = inv_tab_item_warehouse.cod_loc" & _
        "ation AND inv_tab_location_warehouse.cod_warehouse = inv_tab_item_warehouse.cod_" & _
        "warehouse RIGHT OUTER JOIN inv_tab_public RIGHT OUTER JOIN inv_tab_tire_specific" & _
        "ation ON inv_tab_public.cod_table_public = inv_tab_tire_specification.tire_size " & _
        "RIGHT OUTER JOIN inv_item ON inv_tab_tire_specification.item_no = inv_item.item_" & _
        "no LEFT OUTER JOIN inv_discount_item ON inv_item.item_no = inv_discount_item.ite" & _
        "m_no LEFT OUTER JOIN inv_item_cost_transaction ON inv_item.item_no = inv_item_co" & _
        "st_transaction.item_no ON inv_tab_item_warehouse.item_no = inv_item.item_no ON i" & _
        "nv_item_quick_refrence.cod_quick_refrence = inv_item.cod_quick_refrence LEFT OUT" & _
        "ER JOIN inv_tab_style RIGHT OUTER JOIN inv_tab_line ON inv_tab_style.style = inv" & _
        "_tab_line.style ON inv_item.line = inv_tab_line.line RIGHT OUTER JOIN inv_tab_br" & _
        "and ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand WHERE (inv_item_cost_tra" & _
        "nsaction.last_flag = 1) AND (inv_discount_item.last_flag = 1) AND (inv_item.cod_" & _
        "item_type NOT IN ('01', '04'))"
        Me.SqlCommand1.Connection = Me.Cnn
        '
        'backupwel
        '
        Me.backupwel.SelectCommand = Me.SqlCommand2
        Me.backupwel.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_ItemWheel", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("cod_item_type", "cod_item_type"), New System.Data.Common.DataColumnMapping("desc_item", "desc_item"), New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("cod_quick_refrence", "cod_quick_refrence"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("note", "note"), New System.Data.Common.DataColumnMapping("picture", "picture"), New System.Data.Common.DataColumnMapping("upc", "upc"), New System.Data.Common.DataColumnMapping("special_notice", "special_notice"), New System.Data.Common.DataColumnMapping("desc_quick_refrence", "desc_quick_refrence"), New System.Data.Common.DataColumnMapping("abbreviation_desc_brand", "abbreviation_desc_brand"), New System.Data.Common.DataColumnMapping("desc_line", "desc_line"), New System.Data.Common.DataColumnMapping("on_hand", "on_hand"), New System.Data.Common.DataColumnMapping("amount_price1", "amount_price1"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("treadwear", "treadwear"), New System.Data.Common.DataColumnMapping("traction", "traction"), New System.Data.Common.DataColumnMapping("temperature", "temperature"), New System.Data.Common.DataColumnMapping("amount_onsale", "amount_onsale"), New System.Data.Common.DataColumnMapping("amount_spiff", "amount_spiff"), New System.Data.Common.DataColumnMapping("service_description", "service_description"), New System.Data.Common.DataColumnMapping("tire_size", "tire_size"), New System.Data.Common.DataColumnMapping("desc_table", "desc_table"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("list_price", "list_price"), New System.Data.Common.DataColumnMapping("cod_warehouse", "cod_warehouse"), New System.Data.Common.DataColumnMapping("desc_location", "desc_location"), New System.Data.Common.DataColumnMapping("ReplcamentCost", "ReplcamentCost")})})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "SELECT inv_item.item_no, inv_item.cod_item_type, inv_item.desc_item, inv_tab_bran" & _
        "d.cod_brand, inv_item.cod_quick_refrence, inv_item.taxable, inv_tab_style.style," & _
        " inv_item.note, inv_item.picture, inv_item.upc, inv_item.special_notice, inv_ite" & _
        "m_quick_refrence.desc_quick_refrence, inv_tab_brand.complete_desc_brand AS abbre" & _
        "viation_desc_brand, inv_tab_line.line AS desc_line, inv_tab_item_warehouse.on_ha" & _
        "nd - inv_tab_item_warehouse.comitted AS on_hand, inv_item_cost_transaction.amoun" & _
        "t_price1 AS amount_price1, inv_item_cost_transaction.fet, inv_tab_line.treadwear" & _
        ", inv_tab_line.traction, inv_tab_line.temperature, inv_discount_item.onsale_chec" & _
        "k AS amount_onsale, inv_discount_item.spiff_check AS amount_spiff, inv_tab_tire_" & _
        "specification.service_description, inv_tab_tire_specification.tire_size, inv_tab" & _
        "_public.desc_table, inv_item_cost_transaction.cost, inv_item_cost_transaction.li" & _
        "st_price, inv_tab_item_warehouse.cod_warehouse, inv_tab_location_warehouse.desc_" & _
        "location, inv_item_cost_transaction.cost + inv_item_cost_transaction.delivery + " & _
        "inv_item_cost_transaction.frieght AS ReplcamentCost FROM inv_item_quick_refrence" & _
        " RIGHT OUTER JOIN inv_tab_location_warehouse RIGHT OUTER JOIN inv_tab_item_wareh" & _
        "ouse ON inv_tab_location_warehouse.cod_location = inv_tab_item_warehouse.cod_loc" & _
        "ation AND inv_tab_location_warehouse.cod_warehouse = inv_tab_item_warehouse.cod_" & _
        "warehouse RIGHT OUTER JOIN inv_tab_public RIGHT OUTER JOIN inv_tab_tire_specific" & _
        "ation ON inv_tab_public.cod_table_public = inv_tab_tire_specification.tire_size " & _
        "RIGHT OUTER JOIN inv_item ON inv_tab_tire_specification.item_no = inv_item.item_" & _
        "no LEFT OUTER JOIN inv_discount_item ON inv_item.item_no = inv_discount_item.ite" & _
        "m_no LEFT OUTER JOIN inv_item_cost_transaction ON inv_item.item_no = inv_item_co" & _
        "st_transaction.item_no ON inv_tab_item_warehouse.item_no = inv_item.item_no ON i" & _
        "nv_item_quick_refrence.cod_quick_refrence = inv_item.cod_quick_refrence LEFT OUT" & _
        "ER JOIN inv_tab_style RIGHT OUTER JOIN inv_tab_line ON inv_tab_style.style = inv" & _
        "_tab_line.style ON inv_item.line = inv_tab_line.line RIGHT OUTER JOIN inv_tab_br" & _
        "and ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand WHERE (inv_item_cost_tra" & _
        "nsaction.last_flag = 1) AND (inv_discount_item.last_flag = 1) AND (inv_item.cod_" & _
        "item_type = '04') AND (inv_tab_public.cod_main = '09')"
        Me.SqlCommand2.Connection = Me.Cnn
        '
        'FrmSearchItemCode
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(798, 452)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ChkLowestPrice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = True
        Me.Name = "FrmSearchItemCode"
        Me.Text = "Find Item"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DsInv_Item1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.GrdItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.GridWheel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.GridAutopart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Property Condition() As String
        Get
            Return Mcondition
        End Get
        Set(ByVal Value As String)
            Mcondition = Value
        End Set
    End Property
    Public Property FlagDoubleClkic() As String
        Get
            Return _FlagDoubleClkick
        End Get
        Set(ByVal Value As String)
            _FlagDoubleClkick = Value
        End Set
    End Property

    Private Sub FrmFindItemGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Left = 0
            CnnMdbSetup.ConnectionString = PConnectionStringForSetupTables
            CmbStoreNo.Text = vbNullString
            'If CmdGeneralForMDBSetup.Connection.State <> ConnectionState.Open Then
            '    CmdGeneralForMDBSetup.Connection.Open()
            'End If
            'CmdGeneralForMDBSetup.CommandText = "Select Count(*) From Store_Setup"
            'If CmdGeneralForMDBSetup.ExecuteScalar() = 1 Then
            '    CmbStoreNo.Visible = False
            '    CmdGeneralForMDBSetup.CommandText = "Select top 1 StoreNo From Store_Setup"
            '    APubStoreNO = CmdGeneralForMDBSetup.ExecuteScalar()
            '    CmbStoreNo.Text = APubStoreNO
            'Else
            'End If
            '------------------------------------
            If Mcondition = "" Then
                CmdReload.Visible = False
            Else
                CmdReload.Visible = True
            End If
            ChkLowestPrice.Checked = True
            DsInv_Item1.Store_Setup.Clear()
            DASTORE_SETUP.Fill(DsInv_Item1.Store_Setup)
            CmbStoreNo.SelectedValue = PubStoreNO
            '---------------------------------------
            Try
                'DaItemType.Fill(DsInv_Item1.inv_tab_type_item)
                'CmbItemType.SelectedValue = "01"
                Call FillData()
                GrdItem.RootTable.FilterCondition = Nothing
                GridWheel.RootTable.FilterCondition = Nothing
                GridAutopart.RootTable.FilterCondition = Nothing
                GrdItem.Refresh()
                GridWheel.Refresh()
                GridAutopart.Refresh()
                TabControl1.Focus()
                TabControl1.TabIndex = 0
                GrdItem.Focus()
                GrdItem.Row = GrdItem.FilterRow.Position
                GrdItem.Col = 1
                System.Windows.Forms.SendKeys.Send("{Tab}")
                Call enable2()
            Catch ex As Exception
            End Try
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub gridEX1_LoadingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs)
        e.Row.Cells("UQGT").Value = CType(e.Row.Cells("treadwear").Value, String) + " " + CType(e.Row.Cells("Traction").Value, String) + " " + CType(e.Row.Cells("Temperature").Value, String)
    End Sub
    Private Sub ChkLowestPrice_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkLowestPrice.CheckedChanged
        Dim s As New Janus.Windows.GridEX.GridEXSortKey
        If ChkLowestPrice.Checked = True Then
            s.Column = GrdItem.RootTable.Columns(5)
            s.SortOrder = Janus.Windows.GridEX.SortOrder.Ascending
            GrdItem.RootTable.SortKeys.Add(s)
        Else
            GrdItem.RootTable.SortKeys.RemoveAt(0)
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged


        'Try
        Dim filter As GridEXFilterCondition
        ' filter.Column = GrdItem.RootTable.Columns("on_hand")


        ' filter.Value1 = 0

        OnHandCondition = Not CheckBox2.Checked
        Call FillData()

        '    If CheckBox2.Checked = False Then
        '        DsInv_Item1.inv_item.DefaultView.RowFilter = "on_hand > 0 "
        '        DsInv_Item1.inv_ItemAutoPart.DefaultView.RowFilter = "on_hand > 0 "
        '        DsInv_Item1.Inv_ItemWheel.DefaultView.RowFilter = "on_hand > 0 "

        '    Else
        '        'GrdItem.RemoveFilters()
        '        DsInv_Item1.inv_item.DefaultView.RowFilter = ""
        '        DsInv_Item1.inv_ItemAutoPart.DefaultView.RowFilter = ""
        '        DsInv_Item1.Inv_ItemWheel.DefaultView.RowFilter = ""

        '        'GrdItem.DataSource = DsInv_Item1.Tables(0)
        '    End If


        '    GrdItem.DataSource = DsInv_Item1
        '    GrdItem.DataMember = ""
        '    GrdItem.Refresh()
        '    GrdItem.DataMember = "inv_item"
        '    GrdItem.Refresh()
        '    GridWheel.DataSource = DsInv_Item1
        '    GridWheel.DataMember = "Inv_ItemWheel"
        '    GridWheel.Refresh()
        '    GridAutopart.DataSource = DsInv_Item1
        '    GridAutopart.DataMember = "inv_ItemAutoPart"
        '    GridAutopart.Refresh()
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
    End Sub
    '-------------------------------------------------------------------'
    Private Sub CmbGroupBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbGroupBy.SelectedIndexChanged
        Call GroupBy1()
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Try
            Select Case TabControl1.SelectedIndex
                Case 0
                    RaiseEvent Item_noFind(GrdItem.GetRow.Cells("Item_no").Value, GrdItem.GetRow.Cells("Desc_item").Value)
                Case 1
                    RaiseEvent Item_noFind(GridWheel.GetRow.Cells("Item_no").Value, GridWheel.GetRow.Cells("Desc_item").Value)
                Case 2
                    RaiseEvent Item_noFind(GridAutopart.GetRow.Cells("Item_no").Value, GridAutopart.GetRow.Cells("Desc_item").Value)
            End Select
        Catch ex As Exception
        End Try
        Me.Close()
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub

    Private Sub CmdRowDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRowDetail.Click
        '        Dim AA As New FrmItemDetailShow
        Call ShowDetail()
    End Sub
    Private Sub GroupByDialog_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'GroupByDialog.Checked()
        Call GroupBy1()
    End Sub
    Sub GroupBy1()
        Try
            If GroupByChk.Checked Then
                Dim Grp As New GridEXGroup
                Dim Grp2 As New GridEXGroup
                Dim Grp3 As New GridEXGroup


                Select Case CmbGroupBy.SelectedIndex
                    Case 0
                        Grp.Column = GrdItem.RootTable.Columns("desc_quick_refrence")
                        Grp2.Column = GridWheel.RootTable.Columns("desc_quick_refrence")
                        Grp3.Column = GrdItem.RootTable.Columns("desc_quick_refrence")
                    Case 1
                        Grp.Column = GrdItem.RootTable.Columns("desc_Table")
                        Grp2.Column = GridWheel.RootTable.Columns("desc_Table")
                        Grp3.Column = GridAutopart.RootTable.Columns("desc_Table")

                    Case 2
                        Grp.Column = GrdItem.RootTable.Columns("desc_item")
                        Grp2.Column = GridWheel.RootTable.Columns("desc_item")
                        Grp3.Column = GridAutopart.RootTable.Columns("desc_item")
                    Case 3
                        Grp.Column = GrdItem.RootTable.Columns("desc_Line")
                        Grp2.Column = GridWheel.RootTable.Columns("desc_item")
                        Grp3.Column = GridAutopart.RootTable.Columns("desc_item")
                End Select
                Grp.SortOrder = So
                Grp2.SortOrder = So
                Grp3.SortOrder = So

                GrdItem.RootTable.Groups.Clear()
                GrdItem.RootTable.Groups.Add(Grp)

                GridWheel.RootTable.Groups.Clear()
                GridWheel.RootTable.Groups.Add(Grp2)

                GridAutopart.RootTable.Groups.Clear()
                GridAutopart.RootTable.Groups.Add(Grp3)

            Else
                GrdItem.RootTable.Groups.Clear()
                GridWheel.RootTable.Groups.Clear()
                GridAutopart.RootTable.Groups.Clear()
            End If
            GrdItem.Refresh()
            GridWheel.Refresh()
            GridAutopart.Refresh()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupByChk.CheckedChanged
        Call GroupBy1()
        CmbGroupBy.Enabled = GroupByChk.Checked
    End Sub
    Private Sub CheckBox3_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            So = SortOrder.Ascending
        Else
            So = SortOrder.Descending
        End If
        Call GroupBy1()
    End Sub
    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        GrdItem.GroupByBoxVisible = CheckBox4.Checked
    End Sub
    Private Sub GrdItem_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdItem.ColumnButtonClick
        Select Case e.Column.Index
            Case 0
                Call ShowDetail()
        End Select
    End Sub
    Sub ShowDetail()
        Try
            Dim IdItem As String = ""
            Select Case TabControl1.SelectedIndex
                Case 0
                    IdItem = GrdItem.GetRow.Cells(2).Value & ""
                Case 1
                    IdItem = GridWheel.GetRow.Cells(2).Value & ""
                Case 2
                    IdItem = GridAutopart.GetRow.Cells(2).Value & ""
            End Select
            If IdItem <> "" Then
                MyFrmItemDetailShow = New FrmItemDetailShow
                MyFrmItemDetailShow.Item_No = IdItem
                MyFrmItemDetailShow.ShowDialog()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub QuickAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuickAddItem.Click
        Dim FrmAddnew As New FrmItem_Quick_Add
        FrmAddnew.Cnn.ConnectionString = PConnectionString
        FrmAddnew.IsCancelForExitFlag = True
        FrmAddnew.ShowDialog()
        Call FillData()
    End Sub
    Sub FillData()
        Try
            If Pricelevel < 1 Or Pricelevel > 6 Then
                Pricelevel = 1
            End If
            DaInv_Item.SelectCommand.CommandText = DaInv_Item.SelectCommand.CommandText.Replace("inv_item_cost_transaction.amount_price1", "inv_item_cost_transaction.amount_price" & Pricelevel.ToString.Trim)
            '
            DsInv_Item1.inv_item.Clear()
            DsInv_Item1.inv_item_quick_refrence.Clear()
            So = SortOrder.Ascending
            Dim cns As String = MakeConnectionSqlForThisStore(CmbStoreNo.Text)
            Cnn.ConnectionString = IIf(cns & "" = "", CommonClass.PConnectionString, cns)
            Dim backString As String = DaInv_Item.SelectCommand.CommandText
            DaInv_Item.SelectCommand.CommandText = backString + IIf(Mcondition.Trim & "" <> "", " And " & Mcondition.Trim, "") + IIf(OnHandCondition, " And inv_tab_item_warehouse.on_Hand > 0", "")
            ' DaInv_Item.SelectCommand.Parameters("@Cod_Main").Value = CmbItemType.SelectedValue
            DaInv_Item.SelectCommand.Connection = Cnn
            DaInv_Item.Fill(DsInv_Item1.inv_item)
            DaInv_Item.SelectCommand.CommandText = backString
            DaQuickReference.Fill(DsInv_Item1.inv_item_quick_refrence)
            GrdItem.DropDowns("QuickRef").SetDataBinding(DsInv_Item1, "inv_item_quick_refrence")
            CmbGroupBy.SelectedIndex = 0
            GrdItem.Focus()

            DsInv_Item1.Inv_ItemWheel.Clear()
            DaIn_ItemWheel.Fill(DsInv_Item1.Inv_ItemWheel)

            DsInv_Item1.inv_ItemAutoPart.Clear()
            DaInv_ItemAutoPart.Fill(DsInv_Item1.inv_ItemAutoPart)
        Catch ex As Exception
            ' MsgBox(ex.ToString)
        Finally
            Try
                DaInv_Item.SelectCommand.CommandText = DaInv_Item.SelectCommand.CommandText.Replace("inv_item_cost_transaction.amount_price" & Pricelevel.ToString.Trim, "inv_item_cost_transaction.amount_price1")
            Catch ex As Exception
            End Try
        End Try
    End Sub
    Private Sub GrdItem_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdItem.DoubleClick, GridAutopart.DoubleClick, GridWheel.DoubleClick
        Try
            If _FlagDoubleClkick = "1" Then
                If CmbStoreNo.Text = PubStoreNO Then
                    If Trim(CType(sender, Janus.Windows.GridEX.GridEX).GetRow.Cells("Item_no").Value & "" <> "") Then
                        Dim itemno As String
                        Dim itemdesc As String

                        Select Case TabControl1.SelectedIndex
                            Case 0

                                itemno = GrdItem.GetRow.Cells("Item_no").Value
                                itemdesc = GrdItem.GetRow.Cells("Desc_item").Value
                                RaiseEvent Item_noFind(itemno, itemdesc)
                            Case 1
                                itemno = GridWheel.GetRow.Cells("Item_no").Value
                                itemdesc = GridWheel.GetRow.Cells("Desc_item").Value
                                RaiseEvent Item_noFind(itemno, itemdesc)
                            Case 2
                                itemno = GridAutopart.GetRow.Cells("Item_no").Value
                                itemdesc = GridAutopart.GetRow.Cells("Desc_item").Value
                                RaiseEvent Item_noFind(itemno, itemdesc)
                                'RaiseEvent Item_noFind(GridAutopart.GetRow.Cells("Item_no").Value, GridAutopart.GetRow.Cells("Desc_item").Value)
                        End Select
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    'Private Sub CmbStoreNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbStoreNo.SelectedIndexChanged
    Private Sub CmbStoreNo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbStoreNo.SelectionChangeCommitted
        FillData()
        Call enable2()
    End Sub
    Sub enable2()
        QuickAddItem.Enabled = CmbStoreNo.Text = PubStoreNO
        CmdRowDetail.Enabled = CmbStoreNo.Text = PubStoreNO
        CmdOk.Enabled = CmbStoreNo.Text = PubStoreNO
    End Sub

    Private Sub CmdReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdReload.Click
        Mcondition = ""
        CmdReload.Visible = False
        Call FillData()
    End Sub
End Class
