Imports CommonClass
Public Class FrmRepInvItem
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
    Friend WithEvents PanelLBSS As System.Windows.Forms.GroupBox
    Friend WithEvents PanelStyle As System.Windows.Forms.Panel
    Friend WithEvents BtnStyle As System.Windows.Forms.Button
    Friend WithEvents RdoSelectedStyle As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllStyle As System.Windows.Forms.RadioButton
    Friend WithEvents PanelBrand As System.Windows.Forms.Panel
    Friend WithEvents BtnBrand As System.Windows.Forms.Button
    Friend WithEvents RdoSelectedBrand As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllBrand As System.Windows.Forms.RadioButton
    Friend WithEvents PanelLine As System.Windows.Forms.Panel
    Friend WithEvents BtnLine As System.Windows.Forms.Button
    Friend WithEvents RdoSelectedLine As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllLine As System.Windows.Forms.RadioButton
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents BtnItem As System.Windows.Forms.Button
    Friend WithEvents RdoSelectedItem As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllItem As System.Windows.Forms.RadioButton
    Friend WithEvents CmbItemType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAItem As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DATypeItem As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAStyle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DABrand As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DALine As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmRepInvItem1 As Report.DSFrmRepInvItem
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents PanelDate As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RdoSelectedStore As System.Windows.Forms.RadioButton
    Friend WithEvents PanelDetail As System.Windows.Forms.Panel
    Friend WithEvents RdoSummery As System.Windows.Forms.RadioButton
    Friend WithEvents RdoDetail As System.Windows.Forms.RadioButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents BtnStore As System.Windows.Forms.Button
    Friend WithEvents BtnVendor As System.Windows.Forms.Button
    Friend WithEvents RdoSelectedVendor As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllVendor As System.Windows.Forms.RadioButton
    Friend WithEvents PanelInnerDate As System.Windows.Forms.Panel
    Friend WithEvents CalendarCombo1 As CalendarCombo.CalendarCombo
    Friend WithEvents CalendarCombo2 As CalendarCombo.CalendarCombo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RdoAllStore As System.Windows.Forms.RadioButton
    Friend WithEvents ChkDate As System.Windows.Forms.CheckBox
    Friend WithEvents DAInv_Vendor As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DACons As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DASTORE_SETUP As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents CnnMdbSetup As System.Data.OleDb.OleDbConnection
    Friend WithEvents PanelVendor As System.Windows.Forms.GroupBox
    Friend WithEvents RdoSelectedCons As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllCons As System.Windows.Forms.RadioButton
    Friend WithEvents PanelStor As System.Windows.Forms.GroupBox
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmRepInvItem))
        Me.PanelLBSS = New System.Windows.Forms.GroupBox
        Me.CmbItemType = New System.Windows.Forms.ComboBox
        Me.DsFrmRepInvItem1 = New Report.DSFrmRepInvItem
        Me.PanelDetail = New System.Windows.Forms.Panel
        Me.RdoSummery = New System.Windows.Forms.RadioButton
        Me.RdoDetail = New System.Windows.Forms.RadioButton
        Me.PanelStyle = New System.Windows.Forms.Panel
        Me.BtnStyle = New System.Windows.Forms.Button
        Me.RdoSelectedStyle = New System.Windows.Forms.RadioButton
        Me.RdoAllStyle = New System.Windows.Forms.RadioButton
        Me.PanelBrand = New System.Windows.Forms.Panel
        Me.BtnBrand = New System.Windows.Forms.Button
        Me.RdoSelectedBrand = New System.Windows.Forms.RadioButton
        Me.RdoAllBrand = New System.Windows.Forms.RadioButton
        Me.PanelLine = New System.Windows.Forms.Panel
        Me.BtnLine = New System.Windows.Forms.Button
        Me.RdoSelectedLine = New System.Windows.Forms.RadioButton
        Me.RdoAllLine = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.RdoSelectedCons = New System.Windows.Forms.RadioButton
        Me.RdoAllCons = New System.Windows.Forms.RadioButton
        Me.BtnItem = New System.Windows.Forms.Button
        Me.RdoSelectedItem = New System.Windows.Forms.RadioButton
        Me.RdoAllItem = New System.Windows.Forms.RadioButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAItem = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DATypeItem = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DAStyle = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DABrand = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DALine = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnOk = New System.Windows.Forms.Button
        Me.PanelDate = New System.Windows.Forms.GroupBox
        Me.PanelInnerDate = New System.Windows.Forms.Panel
        Me.CalendarCombo1 = New CalendarCombo.CalendarCombo
        Me.CalendarCombo2 = New CalendarCombo.CalendarCombo
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ChkDate = New System.Windows.Forms.CheckBox
        Me.PanelStor = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnStore = New System.Windows.Forms.Button
        Me.RdoSelectedStore = New System.Windows.Forms.RadioButton
        Me.RdoAllStore = New System.Windows.Forms.RadioButton
        Me.PanelVendor = New System.Windows.Forms.GroupBox
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.BtnVendor = New System.Windows.Forms.Button
        Me.RdoSelectedVendor = New System.Windows.Forms.RadioButton
        Me.RdoAllVendor = New System.Windows.Forms.RadioButton
        Me.DAInv_Vendor = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DACons = New System.Data.SqlClient.SqlDataAdapter
        Me.DASTORE_SETUP = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand
        Me.CnnMdbSetup = New System.Data.OleDb.OleDbConnection
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.PanelLBSS.SuspendLayout()
        CType(Me.DsFrmRepInvItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDetail.SuspendLayout()
        Me.PanelStyle.SuspendLayout()
        Me.PanelBrand.SuspendLayout()
        Me.PanelLine.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelDate.SuspendLayout()
        Me.PanelInnerDate.SuspendLayout()
        Me.PanelStor.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelVendor.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLBSS
        '
        Me.PanelLBSS.Controls.Add(Me.CmbItemType)
        Me.PanelLBSS.Controls.Add(Me.PanelDetail)
        Me.PanelLBSS.Controls.Add(Me.PanelStyle)
        Me.PanelLBSS.Controls.Add(Me.PanelBrand)
        Me.PanelLBSS.Controls.Add(Me.PanelLine)
        Me.PanelLBSS.Controls.Add(Me.Label4)
        Me.PanelLBSS.Controls.Add(Me.Panel5)
        Me.PanelLBSS.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLBSS.Location = New System.Drawing.Point(0, 136)
        Me.PanelLBSS.Name = "PanelLBSS"
        Me.PanelLBSS.Size = New System.Drawing.Size(510, 240)
        Me.PanelLBSS.TabIndex = 7
        Me.PanelLBSS.TabStop = False
        '
        'CmbItemType
        '
        Me.CmbItemType.DataSource = Me.DsFrmRepInvItem1
        Me.CmbItemType.DisplayMember = "inv_tab_type_item.desc_item_type"
        Me.CmbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbItemType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbItemType.ItemHeight = 13
        Me.CmbItemType.Location = New System.Drawing.Point(120, 16)
        Me.CmbItemType.Name = "CmbItemType"
        Me.CmbItemType.Size = New System.Drawing.Size(120, 21)
        Me.CmbItemType.TabIndex = 1
        Me.CmbItemType.ValueMember = "inv_tab_type_item.cod_item_type"
        '
        'DsFrmRepInvItem1
        '
        Me.DsFrmRepInvItem1.DataSetName = "DSFrmRepInvItem"
        Me.DsFrmRepInvItem1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'PanelDetail
        '
        Me.PanelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDetail.Controls.Add(Me.RdoSummery)
        Me.PanelDetail.Controls.Add(Me.RdoDetail)
        Me.PanelDetail.Location = New System.Drawing.Point(416, 16)
        Me.PanelDetail.Name = "PanelDetail"
        Me.PanelDetail.Size = New System.Drawing.Size(80, 64)
        Me.PanelDetail.TabIndex = 9
        '
        'RdoSummery
        '
        Me.RdoSummery.Location = New System.Drawing.Point(8, 32)
        Me.RdoSummery.Name = "RdoSummery"
        Me.RdoSummery.Size = New System.Drawing.Size(72, 24)
        Me.RdoSummery.TabIndex = 1
        Me.RdoSummery.Text = "Summary"
        '
        'RdoDetail
        '
        Me.RdoDetail.Checked = True
        Me.RdoDetail.Location = New System.Drawing.Point(8, 8)
        Me.RdoDetail.Name = "RdoDetail"
        Me.RdoDetail.Size = New System.Drawing.Size(72, 24)
        Me.RdoDetail.TabIndex = 0
        Me.RdoDetail.TabStop = True
        Me.RdoDetail.Text = "Detail"
        '
        'PanelStyle
        '
        Me.PanelStyle.Controls.Add(Me.BtnStyle)
        Me.PanelStyle.Controls.Add(Me.RdoSelectedStyle)
        Me.PanelStyle.Controls.Add(Me.RdoAllStyle)
        Me.PanelStyle.Location = New System.Drawing.Point(16, 208)
        Me.PanelStyle.Name = "PanelStyle"
        Me.PanelStyle.Size = New System.Drawing.Size(392, 24)
        Me.PanelStyle.TabIndex = 7
        '
        'BtnStyle
        '
        Me.BtnStyle.Enabled = False
        Me.BtnStyle.Location = New System.Drawing.Point(304, 0)
        Me.BtnStyle.Name = "BtnStyle"
        Me.BtnStyle.TabIndex = 3
        Me.BtnStyle.Text = "Choose..."
        '
        'RdoSelectedStyle
        '
        Me.RdoSelectedStyle.Location = New System.Drawing.Point(136, 0)
        Me.RdoSelectedStyle.Name = "RdoSelectedStyle"
        Me.RdoSelectedStyle.TabIndex = 1
        Me.RdoSelectedStyle.Text = "Selected Styles"
        '
        'RdoAllStyle
        '
        Me.RdoAllStyle.Checked = True
        Me.RdoAllStyle.Location = New System.Drawing.Point(0, 0)
        Me.RdoAllStyle.Name = "RdoAllStyle"
        Me.RdoAllStyle.TabIndex = 0
        Me.RdoAllStyle.TabStop = True
        Me.RdoAllStyle.Text = "All Styles"
        '
        'PanelBrand
        '
        Me.PanelBrand.Controls.Add(Me.BtnBrand)
        Me.PanelBrand.Controls.Add(Me.RdoSelectedBrand)
        Me.PanelBrand.Controls.Add(Me.RdoAllBrand)
        Me.PanelBrand.Location = New System.Drawing.Point(16, 168)
        Me.PanelBrand.Name = "PanelBrand"
        Me.PanelBrand.Size = New System.Drawing.Size(392, 24)
        Me.PanelBrand.TabIndex = 6
        '
        'BtnBrand
        '
        Me.BtnBrand.Enabled = False
        Me.BtnBrand.Location = New System.Drawing.Point(304, 0)
        Me.BtnBrand.Name = "BtnBrand"
        Me.BtnBrand.TabIndex = 3
        Me.BtnBrand.Text = "Choose..."
        '
        'RdoSelectedBrand
        '
        Me.RdoSelectedBrand.Location = New System.Drawing.Point(136, 0)
        Me.RdoSelectedBrand.Name = "RdoSelectedBrand"
        Me.RdoSelectedBrand.Size = New System.Drawing.Size(112, 24)
        Me.RdoSelectedBrand.TabIndex = 1
        Me.RdoSelectedBrand.Text = "Selected Brands"
        '
        'RdoAllBrand
        '
        Me.RdoAllBrand.Checked = True
        Me.RdoAllBrand.Location = New System.Drawing.Point(0, 0)
        Me.RdoAllBrand.Name = "RdoAllBrand"
        Me.RdoAllBrand.TabIndex = 0
        Me.RdoAllBrand.TabStop = True
        Me.RdoAllBrand.Text = "All Brands"
        '
        'PanelLine
        '
        Me.PanelLine.Controls.Add(Me.BtnLine)
        Me.PanelLine.Controls.Add(Me.RdoSelectedLine)
        Me.PanelLine.Controls.Add(Me.RdoAllLine)
        Me.PanelLine.Location = New System.Drawing.Point(16, 128)
        Me.PanelLine.Name = "PanelLine"
        Me.PanelLine.Size = New System.Drawing.Size(392, 24)
        Me.PanelLine.TabIndex = 5
        '
        'BtnLine
        '
        Me.BtnLine.Enabled = False
        Me.BtnLine.Location = New System.Drawing.Point(304, 0)
        Me.BtnLine.Name = "BtnLine"
        Me.BtnLine.TabIndex = 2
        Me.BtnLine.Text = "Choose..."
        '
        'RdoSelectedLine
        '
        Me.RdoSelectedLine.Location = New System.Drawing.Point(136, 0)
        Me.RdoSelectedLine.Name = "RdoSelectedLine"
        Me.RdoSelectedLine.TabIndex = 1
        Me.RdoSelectedLine.Text = "Selected Lines"
        '
        'RdoAllLine
        '
        Me.RdoAllLine.Checked = True
        Me.RdoAllLine.Location = New System.Drawing.Point(0, 0)
        Me.RdoAllLine.Name = "RdoAllLine"
        Me.RdoAllLine.TabIndex = 0
        Me.RdoAllLine.TabStop = True
        Me.RdoAllLine.Text = "All Lines"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "For Item Type"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.RdoSelectedCons)
        Me.Panel5.Controls.Add(Me.RdoAllCons)
        Me.Panel5.Controls.Add(Me.BtnItem)
        Me.Panel5.Controls.Add(Me.RdoSelectedItem)
        Me.Panel5.Controls.Add(Me.RdoAllItem)
        Me.Panel5.Location = New System.Drawing.Point(16, 56)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(392, 64)
        Me.Panel5.TabIndex = 6
        '
        'RdoSelectedCons
        '
        Me.RdoSelectedCons.Location = New System.Drawing.Point(136, 32)
        Me.RdoSelectedCons.Name = "RdoSelectedCons"
        Me.RdoSelectedCons.Size = New System.Drawing.Size(168, 24)
        Me.RdoSelectedCons.TabIndex = 5
        Me.RdoSelectedCons.Text = "Selected Consignment Items"
        '
        'RdoAllCons
        '
        Me.RdoAllCons.Location = New System.Drawing.Point(0, 32)
        Me.RdoAllCons.Name = "RdoAllCons"
        Me.RdoAllCons.Size = New System.Drawing.Size(136, 24)
        Me.RdoAllCons.TabIndex = 4
        Me.RdoAllCons.Text = "All Consignment Item"
        '
        'BtnItem
        '
        Me.BtnItem.Enabled = False
        Me.BtnItem.Location = New System.Drawing.Point(304, 16)
        Me.BtnItem.Name = "BtnItem"
        Me.BtnItem.TabIndex = 3
        Me.BtnItem.Text = "Choose..."
        '
        'RdoSelectedItem
        '
        Me.RdoSelectedItem.Location = New System.Drawing.Point(136, 8)
        Me.RdoSelectedItem.Name = "RdoSelectedItem"
        Me.RdoSelectedItem.TabIndex = 1
        Me.RdoSelectedItem.Text = "Selected Items"
        '
        'RdoAllItem
        '
        Me.RdoAllItem.Checked = True
        Me.RdoAllItem.Location = New System.Drawing.Point(0, 8)
        Me.RdoAllItem.Name = "RdoAllItem"
        Me.RdoAllItem.TabIndex = 0
        Me.RdoAllItem.TabStop = True
        Me.RdoAllItem.Text = "All Items"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(510, 48)
        Me.Panel4.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Location = New System.Drawing.Point(64, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(192, 46)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Select the Item That you want to print"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 190
        Me.PictureBox2.TabStop = False
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=MILAD;packet size=4096;integrated security=SSPI;data source=milad;" & _
        "persist security info=False;initial catalog=TireMate_01_db"
        '
        'DAItem
        '
        Me.DAItem.SelectCommand = Me.SqlSelectCommand1
        Me.DAItem.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("desc_item", "desc_item")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT 0 AS flag, item_no AS code, desc_item AS name FROM inv_item WHERE (cod_ite" & _
        "m_type = @type)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type", System.Data.SqlDbType.VarChar, 2, "cod_item_type"))
        '
        'DATypeItem
        '
        Me.DATypeItem.SelectCommand = Me.SqlSelectCommand5
        Me.DATypeItem.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_type_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_item_type", "cod_item_type"), New System.Data.Common.DataColumnMapping("desc_item_type", "desc_item_type")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT cod_item_type, desc_item_type FROM inv_tab_type_item"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        '
        'DAStyle
        '
        Me.DAStyle.SelectCommand = Me.SqlSelectCommand3
        Me.DAStyle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_style", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("desc_style", "desc_style")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT 0 AS flag, style AS code, desc_style AS name FROM inv_tab_style"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DABrand
        '
        Me.DABrand.SelectCommand = Me.SqlSelectCommand4
        Me.DABrand.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_brand", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("complete_desc_brand", "complete_desc_brand")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT 0 AS flag, cod_brand AS code, complete_desc_brand AS name FROM inv_tab_bra" & _
        "nd"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'DALine
        '
        Me.DALine.SelectCommand = Me.SqlSelectCommand2
        Me.DALine.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_line", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("line", "line")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT 0 AS flag, line AS name FROM inv_tab_line"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(280, 440)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.TabIndex = 10
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(136, 440)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.TabIndex = 9
        Me.BtnOk.Text = "OK"
        '
        'PanelDate
        '
        Me.PanelDate.Controls.Add(Me.PanelInnerDate)
        Me.PanelDate.Controls.Add(Me.ChkDate)
        Me.PanelDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDate.Location = New System.Drawing.Point(0, 96)
        Me.PanelDate.Name = "PanelDate"
        Me.PanelDate.Size = New System.Drawing.Size(510, 40)
        Me.PanelDate.TabIndex = 11
        Me.PanelDate.TabStop = False
        '
        'PanelInnerDate
        '
        Me.PanelInnerDate.Controls.Add(Me.CalendarCombo1)
        Me.PanelInnerDate.Controls.Add(Me.CalendarCombo2)
        Me.PanelInnerDate.Controls.Add(Me.Label2)
        Me.PanelInnerDate.Controls.Add(Me.Label3)
        Me.PanelInnerDate.Location = New System.Drawing.Point(112, 8)
        Me.PanelInnerDate.Name = "PanelInnerDate"
        Me.PanelInnerDate.Size = New System.Drawing.Size(320, 24)
        Me.PanelInnerDate.TabIndex = 8
        '
        'CalendarCombo1
        '
        Me.CalendarCombo1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CalendarCombo1.BorderColor = System.Drawing.Color.Empty
        Me.CalendarCombo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CalendarCombo1.ButtonBackColor = System.Drawing.Color.Empty
        Me.CalendarCombo1.ButtonForeColor = System.Drawing.Color.Empty
        Me.CalendarCombo1.EditableSal = True
        Me.CalendarCombo1.Image = CType(resources.GetObject("CalendarCombo1.Image"), System.Drawing.Image)
        Me.CalendarCombo1.Location = New System.Drawing.Point(48, 0)
        Me.CalendarCombo1.MaxValue = CType(2500, Short)
        Me.CalendarCombo1.MinValue = CType(1800, Short)
        Me.CalendarCombo1.Name = "CalendarCombo1"
        Me.CalendarCombo1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CalendarCombo1.Sal_Mali = Nothing
        Me.CalendarCombo1.ShowButton = True
        Me.CalendarCombo1.Size = New System.Drawing.Size(110, 23)
        Me.CalendarCombo1.TabIndex = 3
        Me.CalendarCombo1.VisualStyle = False
        '
        'CalendarCombo2
        '
        Me.CalendarCombo2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CalendarCombo2.BorderColor = System.Drawing.Color.Empty
        Me.CalendarCombo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CalendarCombo2.ButtonBackColor = System.Drawing.Color.Empty
        Me.CalendarCombo2.ButtonForeColor = System.Drawing.Color.Empty
        Me.CalendarCombo2.EditableSal = True
        Me.CalendarCombo2.Image = CType(resources.GetObject("CalendarCombo2.Image"), System.Drawing.Image)
        Me.CalendarCombo2.Location = New System.Drawing.Point(192, 0)
        Me.CalendarCombo2.MaxValue = CType(2500, Short)
        Me.CalendarCombo2.MinValue = CType(1800, Short)
        Me.CalendarCombo2.Name = "CalendarCombo2"
        Me.CalendarCombo2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CalendarCombo2.Sal_Mali = Nothing
        Me.CalendarCombo2.ShowButton = True
        Me.CalendarCombo2.Size = New System.Drawing.Size(110, 23)
        Me.CalendarCombo2.TabIndex = 4
        Me.CalendarCombo2.VisualStyle = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "From"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(160, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "To"
        '
        'ChkDate
        '
        Me.ChkDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkDate.ForeColor = System.Drawing.Color.Black
        Me.ChkDate.Location = New System.Drawing.Point(16, 8)
        Me.ChkDate.Name = "ChkDate"
        Me.ChkDate.Size = New System.Drawing.Size(72, 24)
        Me.ChkDate.TabIndex = 7
        Me.ChkDate.Text = "All Dates"
        '
        'PanelStor
        '
        Me.PanelStor.Controls.Add(Me.Panel1)
        Me.PanelStor.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelStor.Location = New System.Drawing.Point(0, 48)
        Me.PanelStor.Name = "PanelStor"
        Me.PanelStor.Size = New System.Drawing.Size(510, 48)
        Me.PanelStor.TabIndex = 12
        Me.PanelStor.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnStore)
        Me.Panel1.Controls.Add(Me.RdoSelectedStore)
        Me.Panel1.Controls.Add(Me.RdoAllStore)
        Me.Panel1.Location = New System.Drawing.Point(16, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 24)
        Me.Panel1.TabIndex = 6
        '
        'BtnStore
        '
        Me.BtnStore.Enabled = False
        Me.BtnStore.Location = New System.Drawing.Point(304, 1)
        Me.BtnStore.Name = "BtnStore"
        Me.BtnStore.TabIndex = 3
        Me.BtnStore.Text = "Choose..."
        '
        'RdoSelectedStore
        '
        Me.RdoSelectedStore.Location = New System.Drawing.Point(136, 0)
        Me.RdoSelectedStore.Name = "RdoSelectedStore"
        Me.RdoSelectedStore.TabIndex = 1
        Me.RdoSelectedStore.Text = "Selected Store"
        '
        'RdoAllStore
        '
        Me.RdoAllStore.Checked = True
        Me.RdoAllStore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.RdoAllStore.ForeColor = System.Drawing.Color.Black
        Me.RdoAllStore.Location = New System.Drawing.Point(0, 0)
        Me.RdoAllStore.Name = "RdoAllStore"
        Me.RdoAllStore.TabIndex = 0
        Me.RdoAllStore.TabStop = True
        Me.RdoAllStore.Text = "All Store"
        '
        'PanelVendor
        '
        Me.PanelVendor.Controls.Add(Me.Panel6)
        Me.PanelVendor.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelVendor.Location = New System.Drawing.Point(0, 376)
        Me.PanelVendor.Name = "PanelVendor"
        Me.PanelVendor.Size = New System.Drawing.Size(510, 48)
        Me.PanelVendor.TabIndex = 14
        Me.PanelVendor.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.BtnVendor)
        Me.Panel6.Controls.Add(Me.RdoSelectedVendor)
        Me.Panel6.Controls.Add(Me.RdoAllVendor)
        Me.Panel6.Location = New System.Drawing.Point(16, 16)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(392, 24)
        Me.Panel6.TabIndex = 7
        '
        'BtnVendor
        '
        Me.BtnVendor.Enabled = False
        Me.BtnVendor.Location = New System.Drawing.Point(304, 0)
        Me.BtnVendor.Name = "BtnVendor"
        Me.BtnVendor.TabIndex = 6
        Me.BtnVendor.Text = "Choose..."
        '
        'RdoSelectedVendor
        '
        Me.RdoSelectedVendor.Location = New System.Drawing.Point(136, 0)
        Me.RdoSelectedVendor.Name = "RdoSelectedVendor"
        Me.RdoSelectedVendor.Size = New System.Drawing.Size(120, 24)
        Me.RdoSelectedVendor.TabIndex = 5
        Me.RdoSelectedVendor.Text = "Selected Vendor"
        '
        'RdoAllVendor
        '
        Me.RdoAllVendor.Checked = True
        Me.RdoAllVendor.Location = New System.Drawing.Point(0, 0)
        Me.RdoAllVendor.Name = "RdoAllVendor"
        Me.RdoAllVendor.TabIndex = 4
        Me.RdoAllVendor.TabStop = True
        Me.RdoAllVendor.Text = "All Vendor"
        '
        'DAInv_Vendor
        '
        Me.DAInv_Vendor.SelectCommand = Me.SqlCommand3
        Me.DAInv_Vendor.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_vendor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("desc_vendor", "desc_vendor")})})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT cod_vendor AS code, desc_vendor AS name, 0 AS flag FROM inv_vendor"
        Me.SqlCommand3.Connection = Me.Cnn
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT 0 AS flag, item_no AS code, desc_item AS name FROM inv_item WHERE (cod_ite" & _
        "m_type = @type) AND (consignment = '1')"
        Me.SqlSelectCommand6.Connection = Me.Cnn
        Me.SqlSelectCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type", System.Data.SqlDbType.VarChar, 2, "cod_item_type"))
        '
        'DACons
        '
        Me.DACons.SelectCommand = Me.SqlSelectCommand6
        Me.DACons.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no")})})
        '
        'DASTORE_SETUP
        '
        Me.DASTORE_SETUP.SelectCommand = Me.OleDbCommand1
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = "SELECT STORENO AS code, STORENAME AS name, 0 AS flag FROM STORE_SETUP ORDER BY ST" & _
        "ORENO"
        Me.OleDbCommand1.Connection = Me.CnnMdbSetup
        '
        'CnnMdbSetup
        '
        Me.CnnMdbSetup.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Data Source=""F:\TireMatesetup.mdb"";Mode=Share Deny None;Jet OLEDB:" & _
        "Engine Type=5;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet " & _
        "OLEDB:SFP=False;persist security info=False;Extended Properties=;Jet OLEDB:Compa" & _
        "ct Without Replica Repair=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Creat" & _
        "e System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;User ID=Adm" & _
        "in;Jet OLEDB:Global Bulk Transactions=1"
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'FrmRepInvItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(510, 492)
        Me.Controls.Add(Me.PanelVendor)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.PanelLBSS)
        Me.Controls.Add(Me.PanelDate)
        Me.Controls.Add(Me.PanelStor)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmRepInvItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelLBSS.ResumeLayout(False)
        CType(Me.DsFrmRepInvItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDetail.ResumeLayout(False)
        Me.PanelStyle.ResumeLayout(False)
        Me.PanelBrand.ResumeLayout(False)
        Me.PanelLine.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.PanelDate.ResumeLayout(False)
        Me.PanelInnerDate.ResumeLayout(False)
        Me.PanelStor.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.PanelVendor.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim StrType As String
    Dim StrBrand As String
    Dim StrLine As String
    Dim Stritem As String
    Dim StrStyle As String
    Dim StrVendor As String
    Dim MTypeOfForm As KindForm
    Dim ComName As String = SystemInformation.ComputerName
    Dim FromToDate As String = ""
    Public Enum KindForm As Integer
        Sold = 1
        Recieve = 2
        ReturnReport = 3
        Order = 4
        Adjustment = 5
        Ledger = 6
        InterStore = 9
        Transfer = 8

    End Enum
    Public Property TypeOfForm() As String
        Get
            Return MTypeOfForm
        End Get
        Set(ByVal Value As String)
            MTypeOfForm = Value
        End Set
    End Property

    Private Sub FrmRepInvItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        CnnMdbSetup.ConnectionString = PConnectionStringForSetupTables

        DATypeItem.Fill(DsFrmRepInvItem1.inv_tab_type_item)
        CmbItemType.SelectedValue = "01"
        CalendarCombo1.Text = "01/01/" & PSalMali
        CalendarCombo2.Text = "12/28/" & PSalMali

        Call VisibleControl()
        Call FillFormText()

    End Sub
    Private Sub ChkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDate.CheckedChanged
        If ChkDate.Checked Then
            PanelInnerDate.Enabled = False
        Else
            PanelInnerDate.Enabled = True
        End If
    End Sub
    Private Sub RdoAllLine_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllLine.CheckedChanged
        If RdoAllLine.Checked Then
            BtnLine.Enabled = False
        Else
            BtnLine.Enabled = True
        End If
    End Sub

    Private Sub RdoAllBrand_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllBrand.CheckedChanged
        If RdoAllBrand.Checked Then
            BtnBrand.Enabled = False
        Else
            BtnBrand.Enabled = True
        End If
    End Sub

    Private Sub RdoAllStyle_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllStyle.CheckedChanged
        If RdoAllStyle.Checked Then
            BtnStyle.Enabled = False
        Else
            BtnStyle.Enabled = True
        End If
    End Sub


    Private Sub RdoAllItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllItem.CheckedChanged, RdoSelectedItem.CheckedChanged, RdoSelectedCons.CheckedChanged, RdoAllCons.CheckedChanged
        DsFrmRepInvItem1.item.Clear()
        If RdoAllItem.Checked Or RdoAllCons.Checked Then
            BtnItem.Enabled = False
        Else
            BtnItem.Enabled = True
        End If
    End Sub


    Private Sub RdoAllVendor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllVendor.CheckedChanged
        If RdoAllVendor.Checked Then
            BtnVendor.Enabled = False
        Else
            BtnVendor.Enabled = True
        End If

    End Sub

    Private Sub RdoAllStore_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllStore.CheckedChanged
        If RdoAllStore.Checked Then
            BtnStore.Enabled = False
        Else
            BtnStore.Enabled = True
        End If
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Private Sub CmbItemType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbItemType.SelectedIndexChanged
        DsFrmRepInvItem1.item.Clear()
    End Sub
    Private Sub BtnItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnItem.Click
        If CmbItemType.Text.Trim.Length = 0 Then
            MsgBox("First Select Item Type")
            Exit Sub
        End If
        Dim f As New FrmSelect


        If RdoSelectedItem.Checked Then
            If DsFrmRepInvItem1.item.Count = 0 Then
                DsFrmRepInvItem1.item.Clear()
                DAItem.SelectCommand.Parameters("@type").Value = CmbItemType.SelectedValue
                DAItem.Fill(DsFrmRepInvItem1.item)
            End If
            f.Text = "  Select Item"
            f.DSITEM = DsFrmRepInvItem1
            f.TypeOfForm = FrmSelect.KindForm.Item
        Else
            If DsFrmRepInvItem1.cons.Count = 0 Then
                DsFrmRepInvItem1.cons.Clear()
                DACons.SelectCommand.Parameters("@type").Value = CmbItemType.SelectedValue
                DACons.Fill(DsFrmRepInvItem1.cons)
            End If
            f.TypeOfForm = FrmSelect.KindForm.Cons
            f.Text = "  Select Consignment"
            f.DSITEM = DsFrmRepInvItem1
            ''''''''''f.ShowDialog()             Comment by ketabi

        End If

        ''''''''''''''''''''''
        f.ShowDialog()
        BtnItem.Enabled = True
    End Sub
    Private Sub BtnLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLine.Click
        BtnLine.Enabled = False
        Dim f As New FrmSelect
        If DsFrmRepInvItem1.Line.Count = 0 Then
            DsFrmRepInvItem1.Line.Clear()
            DALine.Fill(DsFrmRepInvItem1.Line)
        End If
        f.Text = "  Select Line"
        f.DSITEM = DsFrmRepInvItem1
        f.TypeOfForm = FrmSelect.KindForm.Line
        f.ShowDialog()

        BtnLine.Enabled = True
    End Sub

    Private Sub BtnStyle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStyle.Click
        BtnStyle.Enabled = False
        If DsFrmRepInvItem1.Style.Count = 0 Then
            DsFrmRepInvItem1.Style.Clear()
            DAStyle.Fill(DsFrmRepInvItem1.Style)
        End If
        Dim f As New FrmSelect
        f.Text = "  Select Style"
        f.DSITEM = DsFrmRepInvItem1
        f.TypeOfForm = FrmSelect.KindForm.Style
        f.ShowDialog()



        BtnStyle.Enabled = True
    End Sub

    Private Sub BtnBrand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrand.Click
        BtnBrand.Enabled = False
        Dim f As New FrmSelect
        If DsFrmRepInvItem1.Brand.Count = 0 Then
            DsFrmRepInvItem1.Brand.Clear()
            DABrand.Fill(DsFrmRepInvItem1.Brand)
        End If
        f.TypeOfForm = FrmSelect.KindForm.Brand
        f.Text = "  Select Brand"
        f.DSITEM = DsFrmRepInvItem1
        f.ShowDialog()


        BtnBrand.Enabled = True

    End Sub

    Private Sub BtnStore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStore.Click
        BtnStore.Enabled = False
        Dim f As New FrmSelect
        If DsFrmRepInvItem1.store.Count = 0 Then
            DsFrmRepInvItem1.store.Clear()
            DASTORE_SETUP.Fill(DsFrmRepInvItem1.store)
        End If
        f.TypeOfForm = FrmSelect.KindForm.Store
        f.Text = "  Select Store"
        f.DSITEM = DsFrmRepInvItem1
        f.ShowDialog()

        BtnStore.Enabled = True
    End Sub



    Private Sub BtnVendor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVendor.Click
        BtnVendor.Enabled = False
        Dim f As New FrmSelect
        If DsFrmRepInvItem1.vendor.Count = 0 Then
            DsFrmRepInvItem1.vendor.Clear()
            DAInv_Vendor.Fill(DsFrmRepInvItem1.vendor)
        End If
        f.TypeOfForm = FrmSelect.KindForm.Vendor
        f.Text = "  Select Vendors"
        f.DSITEM = DsFrmRepInvItem1
        f.ShowDialog()
        BtnVendor.Enabled = True
    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        FromToDate = "From : " & CalendarCombo1.Text & " To : " & CalendarCombo2.Text

        If ControlSelect() Then
            Dim f As New FrmPrintInvItem
            f.StrWhere = ""
            f.StrFilter = ""
            If CmbItemType.Text.Trim.Length > 0 Then
                f.StrWhere = f.StrWhere & " (" & StrType & ") and "
                f.StrFilter = f.StrFilter & "Type, "
            End If
            If Not (RdoAllItem.Checked) Then
                f.StrWhere = f.StrWhere & " (" & Stritem & ") and "
                f.StrFilter = f.StrFilter & "Item, "
            End If
            If RdoSelectedLine.Checked Then
                f.StrWhere = f.StrWhere & " (" & StrLine & ") and "
                f.StrFilter = f.StrFilter & "Line,"
            End If
            If RdoSelectedBrand.Checked Then
                f.StrWhere = f.StrWhere & " (" & StrBrand & ") and "
                f.StrFilter = f.StrFilter & "Brand, "
            End If
            If RdoSelectedStyle.Checked Then
                f.StrWhere = f.StrWhere & "(" & StrStyle & ") and "
                f.StrFilter = f.StrFilter & "Style, "
            End If
            If RdoSelectedVendor.Checked And StrVendor.Trim.Length > 0 Then
                f.StrWhere = f.StrWhere & "(" & StrVendor & ") and "
                f.StrFilter = f.StrFilter & "Vendor, "
            End If
            If f.StrWhere.Trim.Length > 0 Then f.StrWhere = Mid(f.StrWhere, 1, f.StrWhere.Length - 4)
            If f.StrFilter.Trim.Length > 0 Then f.StrFilter = Mid(f.StrFilter, 1, f.StrFilter.Length - 2)
            If ChkDate.Checked Then
                f.Date1 = ""
                f.Date2 = ""
                f.FlagDate = False
            Else
                f.Date1 = ChangeDateToYYYYMMDD(CalendarCombo1.Text)
                f.Date2 = ChangeDateToYYYYMMDD(CalendarCombo2.Text)
                f.FlagDate = True
            End If
            Select Case MTypeOfForm
                Case KindForm.Sold
                    If RdoDetail.Checked Then
                        f.TypeForm = FrmPrintInvItem.KindForm.SoldDetail
                        f.Text = Me.Text & " In Detail "
                    Else
                        f.TypeForm = FrmPrintInvItem.KindForm.SoldSummery
                        f.Text = Me.Text & " In Summary "
                    End If
                Case KindForm.Recieve
                    If RdoDetail.Checked Then
                        f.TypeForm = FrmPrintInvItem.KindForm.RecieveDetail
                        f.Text = Me.Text & " In Detail "
                    Else
                        f.TypeForm = FrmPrintInvItem.KindForm.RecieveSummery
                        f.Text = Me.Text & " In Summary "
                    End If
                Case KindForm.ReturnReport
                    If RdoDetail.Checked Then
                        f.TypeForm = FrmPrintInvItem.KindForm.ReturnDetail
                        f.Text = Me.Text & " In Detail "
                    Else
                        f.TypeForm = FrmPrintInvItem.KindForm.ReturnSummery
                        f.Text = Me.Text & " In Summary "
                    End If
                Case KindForm.Order
                    If RdoDetail.Checked Then
                        f.TypeForm = FrmPrintInvItem.KindForm.OrderDetail
                        f.Text = Me.Text & " In Detail "
                    Else
                        f.TypeForm = FrmPrintInvItem.KindForm.OrderSummery
                        f.Text = Me.Text & " In Summary "
                    End If
                Case KindForm.Adjustment
                    If RdoDetail.Checked Then
                        f.TypeForm = FrmPrintInvItem.KindForm.AdjDetail
                        f.Text = Me.Text & " In Detail "
                    Else
                        f.TypeForm = FrmPrintInvItem.KindForm.AdjSummery
                        f.Text = Me.Text & " In Summary "
                    End If
                Case KindForm.Ledger
                    f.TypeForm = FrmPrintInvItem.KindForm.Ledger
                    f.Text = Me.Text
                Case KindForm.Transfer
                    If RdoDetail.Checked Then
                        f.TypeForm = FrmPrintInvItem.KindForm.TransferDetail
                        f.Text = Me.Text & " In Detail "
                    Else
                        f.TypeForm = FrmPrintInvItem.KindForm.TransferSummery
                        f.Text = Me.Text & " In Summary "
                    End If
                Case KindForm.InterStore
                    If RdoDetail.Checked Then
                        f.TypeForm = FrmPrintInvItem.KindForm.InterSaleDetail
                        f.Text = Me.Text & " In Detail "
                    Else
                        f.TypeForm = FrmPrintInvItem.KindForm.InterSaleSummery
                        f.Text = Me.Text & " In Summary "
                    End If

            End Select
            f.ItemType = CmbItemType.SelectedValue
            f.ItemTypeName = CmbItemType.Text
            f.fromtodate = FromToDate
            f.ShowDialog()



            If RdoSelectedItem.Checked Or RdoSelectedCons.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Item_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If

            If RdoSelectedLine.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Line_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If
            If RdoSelectedBrand.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Brand_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If
            If RdoSelectedStyle.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Style_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If
            If RdoSelectedVendor.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Vend_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If


        End If


    End Sub
    Private Function ControlSelect() As Boolean
        ControlSelect = True
        StrBrand = ""
        StrLine = ""
        Stritem = ""
        StrStyle = ""
        StrVendor = ""


        If CmbItemType.Text.Trim.Length = 0 Then
            StrType = ""
        Else
            StrType = " inv_item.cod_item_type = " & CmbItemType.SelectedValue
        End If
        Dim i As Integer
        If RdoSelectedItem.Checked Then




            'For i = 0 To DsFrmRepInvItem1.item.Count - 1
            '    If DsFrmRepInvItem1.item(i).flag Then
            '        Stritem = Stritem & " inv_item.item_no = " & Qt(DsFrmRepInvItem1.item(i).code) & " or "
            '    End If
            'Next
            'If Stritem.Trim.Length > 0 Then
            '    Stritem = Mid(Stritem, 1, Stritem.Length - 3)
            'Else
            '    ControlSelect = False
            '    MsgBox("First Select Item that you want")
            '    Exit Function
            'End If
            'If DsFrmRepInvItem1.item.Select(" flag = 1 ").Length > 150 Then
            '    ControlSelect = False
            '    MsgFar("You Can Select At List 150 Item")
            '    Exit Function
            'End If
            If DsFrmRepInvItem1.item.Select(" flag = 1 ").Length > 0 Then
                Try
                    CmdGeneral.CommandText = " create table Item_" & ComName & "(item_no char(20))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Item_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DsFrmRepInvItem1.item.Count - 1
                    If DsFrmRepInvItem1.item(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO Item_" & ComName & " (item_no ) VALUES (" & Qt(DsFrmRepInvItem1.item(i).code) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                Stritem = " inv_item.item_no  in (select item_no from Item_" & ComName & ") "

            Else
                ControlSelect = False
                MsgFar("First Select item that you want")
                Exit Function
            End If
            'Stritem = Mid(Stritem, 1, Stritem.Length - 3)
            'Stritem = Stritem & " ) "
        Else
            If RdoSelectedCons.Checked Then
                'For i = 0 To DsFrmRepInvItem1.cons.Count - 1
                '    If DsFrmRepInvItem1.cons(i).flag Then
                '        Stritem = Stritem & " inv_item.item_no = " & Qt(DsFrmRepInvItem1.cons(i).code) & " or "
                '    End If
                'Next
                'If Stritem.Trim.Length > 0 Then
                '    Stritem = Mid(Stritem, 1, Stritem.Length - 3)
                'Else
                '    ControlSelect = False
                '    MsgBox("First Select Item that you want")
                '    Exit Function
                'End If
                'If DsFrmRepInvItem1.cons.Select(" flag = 1 ").Length > 150 Then
                '    ControlSelect = False
                '    MsgFar("You Can Select At List 150 Item")
                '    Exit Function
                'End If
                If DsFrmRepInvItem1.cons.Select(" flag = 1 ").Length > 0 Then
                    Try
                        CmdGeneral.CommandText = " create table Item_" & ComName & "(item_no char(20))"
                        If CmdGeneral.Connection.State = ConnectionState.Closed Then
                            CmdGeneral.Connection.Open()
                        End If
                        CmdGeneral.ExecuteNonQuery()
                    Catch ex As Exception
                        CmdGeneral.CommandText = " DELETE FROM Item_" & ComName
                        CmdGeneral.ExecuteNonQuery()
                    End Try


                    For i = 0 To DsFrmRepInvItem1.item.Count - 1
                        If DsFrmRepInvItem1.item(i).flag Then

                            CmdGeneral.CommandText = " INSERT INTO Item_" & ComName & " (item_no ) VALUES (" & Qt(DsFrmRepInvItem1.item(i).code) & ") "
                            CmdGeneral.ExecuteNonQuery()

                        End If
                    Next
                    Stritem = " inv_item.item_no  in (select item_no from Item_" & ComName & ") "

                Else
                    ControlSelect = False
                    MsgFar("First Select item that you want")
                    Exit Function
                End If
                'Stritem = Mid(Stritem, 1, Stritem.Length - 3)
                'Stritem = Stritem & " ) "
            Else
                If RdoAllCons.Checked Then
                    Stritem = " inv_item.consignment = '1'"
                End If
            End If
        End If
        '''''''line
        If RdoSelectedLine.Checked Then
            StrLine = ""
            'For i = 0 To DsFrmRepInvItem1.Line.Count - 1
            '    If DsFrmRepInvItem1.Line(i).flag Then
            '        StrLine = StrLine & " inv_item.line = " & Qt(DsFrmRepInvItem1.Line(i).name) & " or "
            '    End If
            'Next
            'If StrLine.Trim.Length > 0 Then
            '    StrLine = Mid(StrLine, 1, StrLine.Length - 3)
            'Else
            '    ControlSelect = False
            '    MsgBox("First Select Line that you want")
            '    Exit Function
            'End If
            'If DsFrmRepInvItem1.Line.Select(" flag = 1 ").Length > 50 Then
            '    ControlSelect = False
            '    MsgFar("You Can Select At List 50 Line")
            '    Exit Function
            'End If
            If DsFrmRepInvItem1.Line.Select(" flag = 1 ").Length > 0 Then
                'StrLine = " inv_item.line IN ("
                'For i = 0 To DsFrmRepInvItem1.Line.Count - 1
                '    If DsFrmRepInvItem1.Line(i).flag Then
                '        StrLine = StrLine & Qt(DsFrmRepInvItem1.Line(i).name) & " , "
                '    End If
                'Next
                Try
                    CmdGeneral.CommandText = " create table Line_" & ComName & "(line char(30))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Line_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DsFrmRepInvItem1.Line.Count - 1
                    If DsFrmRepInvItem1.Line(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO Line_" & ComName & " (line ) VALUES (" & Qt(DsFrmRepInvItem1.Line(i).name) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrLine = " inv_item.line in (select line from Line_" & ComName & ") "




            Else
                ControlSelect = False
                MsgFar("First Select Line that you want")
                Exit Function
            End If
            'StrLine = Mid(StrLine, 1, StrLine.Length - 3)
            'StrLine = StrLine & " ) "
        End If
        '''''''''''brand
        If RdoSelectedBrand.Checked Then
            StrBrand = ""
            'For i = 0 To DsFrmRepInvItem1.Brand.Count - 1
            '    If DsFrmRepInvItem1.Brand(i).flag Then
            '        StrBrand = StrBrand & " inv_tab_line.cod_brand = " & Qt(DsFrmRepInvItem1.Brand(i).code) & " or "
            '    End If
            'Next
            'If StrBrand.Trim.Length > 0 Then
            '    StrBrand = Mid(StrBrand, 1, StrBrand.Length - 3)
            'Else
            '    ControlSelect = False
            '    MsgBox("First Select Brand that you want")
            '    Exit Function
            'End If
            'If DsFrmRepInvItem1.Brand.Select(" flag = 1 ").Length > 50 Then
            '    ControlSelect = False
            '    MsgFar("You Can Select At List 50 Brand")
            '    Exit Function
            'End If
            If DsFrmRepInvItem1.Brand.Select(" flag = 1 ").Length > 0 Then
                'StrBrand = " inv_tab_line.cod_brand IN ("
                'For i = 0 To DsFrmRepInvItem1.Brand.Count - 1
                '    If DsFrmRepInvItem1.Brand(i).flag Then
                '        StrBrand = StrBrand & Qt(DsFrmRepInvItem1.Brand(i).code) & " , "
                '    End If
                'Next
                Try
                    CmdGeneral.CommandText = " create table Brand_" & ComName & "(cod_brand char(3))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Brand_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DsFrmRepInvItem1.Brand.Count - 1
                    If DsFrmRepInvItem1.Brand(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO Brand_" & ComName & " (cod_brand ) VALUES (" & Qt(DsFrmRepInvItem1.Brand(i).code) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrBrand = " inv_tab_line.cod_brand in (select cod_brand from Brand_" & ComName & ") "




            Else
                ControlSelect = False
                MsgFar("First Select Brand that you want")
                Exit Function
            End If
            'StrBrand = Mid(StrBrand, 1, StrBrand.Length - 3)
            'StrBrand = StrBrand & " ) "
        End If
        '''''''''''''''style
        If RdoSelectedStyle.Checked Then
            StrStyle = ""
            'For i = 0 To DsFrmRepInvItem1.Style.Count - 1
            '    If DsFrmRepInvItem1.Style(i).flag Then
            '        StrStyle = StrStyle & " inv_tab_line.style = " & Qt(DsFrmRepInvItem1.Style(i).code) & " or "
            '    End If
            'Next
            'If StrStyle.Trim.Length > 0 Then
            '    StrStyle = Mid(StrStyle, 1, StrStyle.Length - 3)
            'Else
            '    ControlSelect = False
            '    MsgBox("First Select Style that you want")
            '    Exit Function
            'End If
            'If DsFrmRepInvItem1.Style.Select(" flag = 1 ").Length > 50 Then
            '    ControlSelect = False
            '    MsgFar("You Can Select At List 50 Style")
            '    Exit Function
            'End If
            If DsFrmRepInvItem1.Style.Select(" flag = 1 ").Length > 0 Then
                'StrStyle = " inv_tab_line.style IN ("
                'For i = 0 To DsFrmRepInvItem1.Style.Count - 1
                '    If DsFrmRepInvItem1.Style(i).flag Then
                '        StrStyle = StrStyle & Qt(DsFrmRepInvItem1.Style(i).code) & " , "
                '    End If
                'Next

                Try
                    CmdGeneral.CommandText = " create table Style_" & ComName & "(style char(3))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Style_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DsFrmRepInvItem1.Style.Count - 1
                    If DsFrmRepInvItem1.Style(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO Style_" & ComName & " (style ) VALUES (" & Qt(DsFrmRepInvItem1.Style(i).code) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrStyle = " inv_tab_line.style in (select style from Style_" & ComName & ") "



            Else
                ControlSelect = False
                MsgFar("First Select Style that you want")
                Exit Function
            End If
            ''StrStyle = Mid(StrStyle, 1, StrStyle.Length - 3)
            ''StrStyle = StrStyle & " ) "
        End If
        ''''''''''''vendor
        If RdoSelectedVendor.Checked And (MTypeOfForm = KindForm.Recieve Or MTypeOfForm = KindForm.Order) Then
            StrVendor = ""
            If DsFrmRepInvItem1.vendor.Select(" flag = 1 ").Length > 0 Then


                Try
                    CmdGeneral.CommandText = " create table Vend_" & ComName & "(cod_vendor char(6))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Vend_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DsFrmRepInvItem1.vendor.Count - 1
                    If DsFrmRepInvItem1.vendor(i).flag Then
                        CmdGeneral.CommandText = " INSERT INTO Vend_" & ComName & " (cod_vendor ) VALUES (" & Qt(DsFrmRepInvItem1.vendor(i).code) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                Select Case MTypeOfForm
                    Case KindForm.Order
                        StrVendor = StrVendor & " Inv_purchase_order_head.cod_vendor in (select cod_vendor from Vend_" & ComName & ") "
                    Case KindForm.Recieve
                        StrVendor = StrVendor & " Inv_Receive_Products_head.cod_vendor in (select cod_vendor from Vend_" & ComName & ") "
                End Select
            Else
                ControlSelect = False
                MsgBox("First Select Vendor that you want")
                Exit Function
            End If



            'If DsFrmRepInvItem1.vendor.Select(" flag = 1 ").Length > 50 Then
            '    ControlSelect = False
            '    MsgFar("You Can Select At List 50 vendor")
            '    Exit Function
            'End If
            '    If DsFrmRepInvItem1.vendor.Select(" flag = 1 ").Length > 0 Then
            '        Select Case MTypeOfForm
            '            Case KindForm.Order
            '                StrVendor = StrVendor & " Inv_purchase_order_head.cod_vendor IN ("
            '            Case KindForm.Recieve
            '                StrVendor = StrVendor & " Inv_Receive_Products_head.cod_vendor IN ("
            '        End Select
            '        For i = 0 To DsFrmRepInvItem1.vendor.Count - 1
            '            Select Case MTypeOfForm
            '                Case KindForm.Order
            '                    StrVendor = StrVendor & Qt(DsFrmRepInvItem1.vendor(i).code) & " , "
            '                Case KindForm.Recieve
            '                    StrVendor = StrVendor & Qt(DsFrmRepInvItem1.vendor(i).code) & " , "
            '            End Select
            '        Next
            '    Else
            '        ControlSelect = False
            '        MsgFar("First Select vendor that you want")
            '        Exit Function
            '    End If
            '    StrVendor = Mid(StrVendor, 1, StrVendor.Length - 3)
            '    StrVendor = StrVendor & " ) "
        End If
        '''''''''date
        If Not ChkDate.Checked Then
            If ChangeDateToYYYYMMDD(CalendarCombo1.Text) > ChangeDateToYYYYMMDD(CalendarCombo2.Text) Then
                ControlSelect = False
                MsgBox("First Date Must Be Leaster Than Second Time")
                Exit Function
            End If
            If CalendarCombo1.Text = "" Or CalendarCombo2.Text = "" Then
                ControlSelect = False
                MsgBox("First select Date")
                Exit Function
            End If
        End If

    End Function
    Private Sub VisibleControl()
        Select Case MTypeOfForm
            Case KindForm.Ledger
                PanelDetail.Visible = False
        End Select
        If MTypeOfForm = KindForm.Adjustment Or MTypeOfForm = KindForm.Ledger Or MTypeOfForm = KindForm.ReturnReport Or MTypeOfForm = KindForm.Sold Or MTypeOfForm = KindForm.InterStore Or MTypeOfForm = KindForm.Transfer Then
            PanelVendor.Visible = False
        End If
        PanelStor.Visible = False
    End Sub
    Private Sub FillFormText()
        Select Case MTypeOfForm
            Case KindForm.Sold
                Me.Text = "    Inventory Sales Report "
            Case KindForm.Recieve
                Me.Text = "    Inventory Received Report "
            Case KindForm.ReturnReport
                Me.Text = "    Inventory Returned Report "
            Case KindForm.Order
                Me.Text = "    Inventory Ordered Report "
            Case KindForm.Adjustment
                Me.Text = "    Inventory Adjusted Report "
            Case KindForm.Ledger
                Me.Text = "    Inventory Ledger Report "
            Case KindForm.Transfer
                Me.Text = "    Inventory Transfer Report "
            Case KindForm.InterStore
                Me.Text = "    Inter-Store Sales Report "
        End Select

    End Sub



End Class
