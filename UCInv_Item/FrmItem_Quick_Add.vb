Imports CommonClass
Public Class FrmItem_Quick_Add
    Inherits FrmBase
    Dim i As Integer
    Public ItemCodeVar As String = ""
    Dim TaxableVar As Boolean = False
    Dim WithEvents MyItem As UCInv_Item.Clsitem_no
    Public IsCancelForExitFlag As Boolean = False
    Dim WithEvents myClsCommon As CommonClass.AllStore
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
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents CmbLine As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPriceCode As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSideWall As System.Windows.Forms.ComboBox
    Friend WithEvents CmbLoadRange As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDescription As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents TxtService As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_item As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmItem_Quick_Add1 As DSFrmItem_Quick_Add
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_price_code As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_item_quick_refrence As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_tab_type_item As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DAInv_tab_public As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents LblLoadRange As System.Windows.Forms.Label
    Friend WithEvents LblSideWall As System.Windows.Forms.Label
    Friend WithEvents LblService As System.Windows.Forms.Label
    Friend WithEvents LblSize As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LblBrand As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents QuickReference1 As UcQuickReference.QuickReference
    Friend WithEvents LblStyle As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_tab_line As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumListPrice As CalcUtils.UcCalcText
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnSaveAndAddNew As System.Windows.Forms.Button
    Friend WithEvents TxtItemNo As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents CmbItemType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SizeCod1 As UcPublicTable.PublicCod
    Friend WithEvents NumFet As CalcUtils.UcCalcText
    Friend WithEvents ChkInsertToAllStore As System.Windows.Forms.CheckBox
    Friend WithEvents BtnPriceLevel As System.Windows.Forms.Button
    Friend WithEvents LblQref As System.Windows.Forms.Label
    Friend WithEvents NumCost As CalcUtils.UcCalcText
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmItem_Quick_Add))
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.ChkInsertToAllStore = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnSaveAndAddNew = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.Label25 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.DsFrmItem_Quick_Add1 = New UCInv_Item.DSFrmItem_Quick_Add
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.LblSize = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.LblLoadRange = New System.Windows.Forms.Label
        Me.LblSideWall = New System.Windows.Forms.Label
        Me.LblService = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.CmbLine = New System.Windows.Forms.ComboBox
        Me.CmbPriceCode = New System.Windows.Forms.ComboBox
        Me.CmbSideWall = New System.Windows.Forms.ComboBox
        Me.CmbLoadRange = New System.Windows.Forms.ComboBox
        Me.TxtDescription = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TxtService = New Janus.Windows.GridEX.EditControls.EditBox
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_item = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_price_code = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_item_quick_refrence = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.DAInv_tab_public = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand11 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_type_item = New System.Data.SqlClient.SqlDataAdapter
        Me.LblStyle = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.LblBrand = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.QuickReference1 = New UcQuickReference.QuickReference
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_line = New System.Data.SqlClient.SqlDataAdapter
        Me.NumListPrice = New CalcUtils.UcCalcText
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtItemNo = New Janus.Windows.GridEX.EditControls.EditBox
        Me.CmbItemType = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.SizeCod1 = New UcPublicTable.PublicCod
        Me.NumFet = New CalcUtils.UcCalcText
        Me.BtnPriceLevel = New System.Windows.Forms.Button
        Me.LblQref = New System.Windows.Forms.Label
        Me.NumCost = New CalcUtils.UcCalcText
        Me.Panel4.SuspendLayout()
        CType(Me.DsFrmItem_Quick_Add1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.ChkInsertToAllStore)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.BtnSaveAndAddNew)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.Label33)
        Me.Panel4.Controls.Add(Me.BtnCancel)
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Controls.Add(Me.BtnSave)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(479, 45)
        Me.Panel4.TabIndex = 12
        '
        'ChkInsertToAllStore
        '
        Me.ChkInsertToAllStore.Location = New System.Drawing.Point(252, 13)
        Me.ChkInsertToAllStore.Name = "ChkInsertToAllStore"
        Me.ChkInsertToAllStore.Size = New System.Drawing.Size(120, 18)
        Me.ChkInsertToAllStore.TabIndex = 198
        Me.ChkInsertToAllStore.Text = "Insert To All Store"
        Me.ChkInsertToAllStore.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(73, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 10)
        Me.Label3.TabIndex = 189
        Me.Label3.Text = "Save && Add New"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSaveAndAddNew
        '
        Me.BtnSaveAndAddNew.Enabled = False
        Me.BtnSaveAndAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSaveAndAddNew.Image = CType(resources.GetObject("BtnSaveAndAddNew.Image"), System.Drawing.Image)
        Me.BtnSaveAndAddNew.Location = New System.Drawing.Point(101, 3)
        Me.BtnSaveAndAddNew.Name = "BtnSaveAndAddNew"
        Me.BtnSaveAndAddNew.Size = New System.Drawing.Size(33, 27)
        Me.BtnSaveAndAddNew.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(397, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 187
        Me.PictureBox2.TabStop = False
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Location = New System.Drawing.Point(188, 32)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(39, 10)
        Me.Label33.TabIndex = 186
        Me.Label33.Text = "Cancel"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(192, 3)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 27)
        Me.BtnCancel.TabIndex = 1
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(6, 32)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(63, 10)
        Me.Label25.TabIndex = 176
        Me.Label25.Text = "Save && Exit"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(19, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 0
        '
        'DsFrmItem_Quick_Add1
        '
        Me.DsFrmItem_Quick_Add1.DataSetName = "DSFrmItem_Quick_Add"
        Me.DsFrmItem_Quick_Add1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Location = New System.Drawing.Point(3, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 21)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Description"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Location = New System.Drawing.Point(4, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 21)
        Me.Label6.TabIndex = 189
        Me.Label6.Text = "Line"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(231, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 21)
        Me.Label7.TabIndex = 190
        Me.Label7.Text = "Brand"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(3, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 21)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Cost"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Location = New System.Drawing.Point(166, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 21)
        Me.Label10.TabIndex = 193
        Me.Label10.Text = "Fet"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Location = New System.Drawing.Point(4, 213)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 21)
        Me.Label11.TabIndex = 194
        Me.Label11.Text = "Quick Ref."
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSize
        '
        Me.LblSize.BackColor = System.Drawing.Color.Transparent
        Me.LblSize.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblSize.Location = New System.Drawing.Point(289, 216)
        Me.LblSize.Name = "LblSize"
        Me.LblSize.Size = New System.Drawing.Size(36, 21)
        Me.LblSize.TabIndex = 195
        Me.LblSize.Text = "Size"
        Me.LblSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label16.Location = New System.Drawing.Point(5, 178)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 22)
        Me.Label16.TabIndex = 197
        Me.Label16.Text = "Style"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblLoadRange
        '
        Me.LblLoadRange.BackColor = System.Drawing.Color.Transparent
        Me.LblLoadRange.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblLoadRange.Location = New System.Drawing.Point(313, 248)
        Me.LblLoadRange.Name = "LblLoadRange"
        Me.LblLoadRange.Size = New System.Drawing.Size(68, 21)
        Me.LblLoadRange.TabIndex = 198
        Me.LblLoadRange.Text = "Load Range"
        Me.LblLoadRange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSideWall
        '
        Me.LblSideWall.BackColor = System.Drawing.Color.Transparent
        Me.LblSideWall.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblSideWall.Location = New System.Drawing.Point(193, 247)
        Me.LblSideWall.Name = "LblSideWall"
        Me.LblSideWall.Size = New System.Drawing.Size(49, 21)
        Me.LblSideWall.TabIndex = 199
        Me.LblSideWall.Text = "SideWall"
        Me.LblSideWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblService
        '
        Me.LblService.BackColor = System.Drawing.Color.Transparent
        Me.LblService.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblService.Location = New System.Drawing.Point(3, 247)
        Me.LblService.Name = "LblService"
        Me.LblService.Size = New System.Drawing.Size(63, 21)
        Me.LblService.TabIndex = 200
        Me.LblService.Text = "Service"
        Me.LblService.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label20.Location = New System.Drawing.Point(243, 150)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(63, 21)
        Me.Label20.TabIndex = 192
        Me.Label20.Text = "Price Code"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbLine
        '
        Me.CmbLine.DataSource = Me.DsFrmItem_Quick_Add1.inv_tab_line
        Me.CmbLine.DisplayMember = "line"
        Me.CmbLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbLine.Enabled = False
        Me.CmbLine.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbLine.ItemHeight = 13
        Me.CmbLine.Location = New System.Drawing.Point(69, 150)
        Me.CmbLine.Name = "CmbLine"
        Me.CmbLine.Size = New System.Drawing.Size(161, 21)
        Me.CmbLine.TabIndex = 6
        Me.CmbLine.ValueMember = "line"
        '
        'CmbPriceCode
        '
        Me.CmbPriceCode.DataSource = Me.DsFrmItem_Quick_Add1.inv_price_code
        Me.CmbPriceCode.DisplayMember = "desc_price_code"
        Me.CmbPriceCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPriceCode.Enabled = False
        Me.CmbPriceCode.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbPriceCode.ItemHeight = 13
        Me.CmbPriceCode.Location = New System.Drawing.Point(308, 150)
        Me.CmbPriceCode.Name = "CmbPriceCode"
        Me.CmbPriceCode.Size = New System.Drawing.Size(146, 21)
        Me.CmbPriceCode.TabIndex = 7
        Me.CmbPriceCode.ValueMember = "price_code"
        '
        'CmbSideWall
        '
        Me.CmbSideWall.DataSource = Me.DsFrmItem_Quick_Add1.SideWall
        Me.CmbSideWall.DisplayMember = "desc_table"
        Me.CmbSideWall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSideWall.Enabled = False
        Me.CmbSideWall.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbSideWall.ItemHeight = 13
        Me.CmbSideWall.Location = New System.Drawing.Point(242, 249)
        Me.CmbSideWall.Name = "CmbSideWall"
        Me.CmbSideWall.Size = New System.Drawing.Size(73, 21)
        Me.CmbSideWall.TabIndex = 11
        Me.CmbSideWall.ValueMember = "cod_table_public"
        '
        'CmbLoadRange
        '
        Me.CmbLoadRange.DataSource = Me.DsFrmItem_Quick_Add1.LoadRange
        Me.CmbLoadRange.DisplayMember = "desc_table"
        Me.CmbLoadRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbLoadRange.Enabled = False
        Me.CmbLoadRange.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbLoadRange.ItemHeight = 13
        Me.CmbLoadRange.Location = New System.Drawing.Point(382, 249)
        Me.CmbLoadRange.Name = "CmbLoadRange"
        Me.CmbLoadRange.Size = New System.Drawing.Size(73, 21)
        Me.CmbLoadRange.TabIndex = 12
        Me.CmbLoadRange.ValueMember = "cod_table_public"
        '
        'TxtDescription
        '
        Me.TxtDescription.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtDescription.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtDescription.Enabled = False
        Me.TxtDescription.Location = New System.Drawing.Point(68, 95)
        Me.TxtDescription.MaxLength = 50
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(384, 20)
        Me.TxtDescription.TabIndex = 2
        Me.TxtDescription.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtService
        '
        Me.TxtService.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtService.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtService.Enabled = False
        Me.TxtService.Location = New System.Drawing.Point(68, 249)
        Me.TxtService.MaxLength = 15
        Me.TxtService.Name = "TxtService"
        Me.TxtService.Size = New System.Drawing.Size(127, 20)
        Me.TxtService.TabIndex = 10
        Me.TxtService.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT inv_item.item_no, inv_item.cod_item_type, inv_item.desc_item, inv_item.cod" & _
        "_quick_refrence, inv_item.taxable, inv_item.line, inv_item.note, inv_item.pictur" & _
        "e, inv_item.upc, inv_item.special_notice, inv_tab_wheels_specification.wheel_siz" & _
        "e, inv_tab_tire_specification.tire_size, inv_tab_tire_specification.service_desc" & _
        "ription, inv_tab_tire_specification.sidwall, inv_tab_tire_specification.load_ran" & _
        "ge, inv_item_cost_transaction.cost, inv_item_cost_transaction.fet, inv_item_cost" & _
        "_transaction.price_code, inv_item_vendor.cod_vendor FROM inv_item LEFT OUTER JOI" & _
        "N inv_item_vendor ON inv_item.item_no = inv_item_vendor.item_no LEFT OUTER JOIN " & _
        "inv_tab_wheels_specification ON inv_item.item_no = inv_tab_wheels_specification." & _
        "item_no LEFT OUTER JOIN inv_item_cost_transaction ON inv_item.item_no = inv_item" & _
        "_cost_transaction.item_no LEFT OUTER JOIN inv_tab_tire_specification ON inv_item" & _
        ".item_no = inv_tab_tire_specification.item_no WHERE (inv_item.item_no = @item_no" & _
        ") AND (inv_item_cost_transaction.last_flag = 1)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        '
        'DAinv_item
        '
        Me.DAinv_item.SelectCommand = Me.SqlSelectCommand1
        Me.DAinv_item.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("cod_item_type", "cod_item_type"), New System.Data.Common.DataColumnMapping("desc_item", "desc_item"), New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("cod_quick_refrence", "cod_quick_refrence"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("line", "line"), New System.Data.Common.DataColumnMapping("note", "note"), New System.Data.Common.DataColumnMapping("picture", "picture"), New System.Data.Common.DataColumnMapping("upc", "upc"), New System.Data.Common.DataColumnMapping("special_notice", "special_notice")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT price_code, desc_price_code, price1_c_l_a_p, price1_operator, price1_d_per" & _
        "sent, price1_amount, price1_odd_price, price1_price_level, price2_c_l_a_p, price" & _
        "2_operator, price2_d_persent, price2_amount, price2_odd_price, price2_price_leve" & _
        "l, price3_c_l_a_p, price3_operator, price3_d_persent, price3_amount, price3_odd_" & _
        "price, price3_price_level, price4_c_l_a_p, price4_operator, price4_d_persent, pr" & _
        "ice4_amount, price4_odd_price, price4_price_level, price5_c_l_a_p, price5_operat" & _
        "or, price5_d_persent, price5_amount, price5_odd_price, price5_price_level, price" & _
        "6_c_l_a_p, price6_operator, price6_d_persent, price6_amount, price6_odd_price, p" & _
        "rice6_price_level, special_notice FROM inv_price_code"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DAinv_price_code
        '
        Me.DAinv_price_code.SelectCommand = Me.SqlSelectCommand3
        Me.DAinv_price_code.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_price_code", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("price_code", "price_code"), New System.Data.Common.DataColumnMapping("desc_price_code", "desc_price_code"), New System.Data.Common.DataColumnMapping("price1_c_l_a_p", "price1_c_l_a_p"), New System.Data.Common.DataColumnMapping("price1_operator", "price1_operator"), New System.Data.Common.DataColumnMapping("price1_d_persent", "price1_d_persent"), New System.Data.Common.DataColumnMapping("price1_amount", "price1_amount"), New System.Data.Common.DataColumnMapping("price1_odd_price", "price1_odd_price"), New System.Data.Common.DataColumnMapping("price1_price_level", "price1_price_level"), New System.Data.Common.DataColumnMapping("price2_c_l_a_p", "price2_c_l_a_p"), New System.Data.Common.DataColumnMapping("price2_operator", "price2_operator"), New System.Data.Common.DataColumnMapping("price2_d_persent", "price2_d_persent"), New System.Data.Common.DataColumnMapping("price2_amount", "price2_amount"), New System.Data.Common.DataColumnMapping("price2_odd_price", "price2_odd_price"), New System.Data.Common.DataColumnMapping("price2_price_level", "price2_price_level"), New System.Data.Common.DataColumnMapping("price3_c_l_a_p", "price3_c_l_a_p"), New System.Data.Common.DataColumnMapping("price3_operator", "price3_operator"), New System.Data.Common.DataColumnMapping("price3_d_persent", "price3_d_persent"), New System.Data.Common.DataColumnMapping("price3_amount", "price3_amount"), New System.Data.Common.DataColumnMapping("price3_odd_price", "price3_odd_price"), New System.Data.Common.DataColumnMapping("price3_price_level", "price3_price_level"), New System.Data.Common.DataColumnMapping("price4_c_l_a_p", "price4_c_l_a_p"), New System.Data.Common.DataColumnMapping("price4_operator", "price4_operator"), New System.Data.Common.DataColumnMapping("price4_d_persent", "price4_d_persent"), New System.Data.Common.DataColumnMapping("price4_amount", "price4_amount"), New System.Data.Common.DataColumnMapping("price4_odd_price", "price4_odd_price"), New System.Data.Common.DataColumnMapping("price4_price_level", "price4_price_level"), New System.Data.Common.DataColumnMapping("price5_c_l_a_p", "price5_c_l_a_p"), New System.Data.Common.DataColumnMapping("price5_operator", "price5_operator"), New System.Data.Common.DataColumnMapping("price5_d_persent", "price5_d_persent"), New System.Data.Common.DataColumnMapping("price5_amount", "price5_amount"), New System.Data.Common.DataColumnMapping("price5_odd_price", "price5_odd_price"), New System.Data.Common.DataColumnMapping("price5_price_level", "price5_price_level"), New System.Data.Common.DataColumnMapping("price6_c_l_a_p", "price6_c_l_a_p"), New System.Data.Common.DataColumnMapping("price6_operator", "price6_operator"), New System.Data.Common.DataColumnMapping("price6_d_persent", "price6_d_persent"), New System.Data.Common.DataColumnMapping("price6_amount", "price6_amount"), New System.Data.Common.DataColumnMapping("price6_odd_price", "price6_odd_price"), New System.Data.Common.DataColumnMapping("price6_price_level", "price6_price_level"), New System.Data.Common.DataColumnMapping("special_notice", "special_notice")})})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT cod_quick_refrence, desc_quick_refrence FROM inv_item_quick_refrence"
        Me.SqlSelectCommand7.Connection = Me.Cnn
        '
        'DAinv_item_quick_refrence
        '
        Me.DAinv_item_quick_refrence.SelectCommand = Me.SqlSelectCommand7
        Me.DAinv_item_quick_refrence.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item_quick_refrence", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_quick_refrence", "cod_quick_refrence"), New System.Data.Common.DataColumnMapping("desc_quick_refrence", "desc_quick_refrence")})})
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT cod_table_public, desc_table FROM inv_tab_public WHERE (cod_main = @cod_ma" & _
        "in)"
        Me.SqlSelectCommand8.Connection = Me.Cnn
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_main", System.Data.SqlDbType.VarChar, 2, "cod_main"))
        '
        'DAInv_tab_public
        '
        Me.DAInv_tab_public.SelectCommand = Me.SqlSelectCommand8
        Me.DAInv_tab_public.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_public", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_main", "cod_main"), New System.Data.Common.DataColumnMapping("cod_table_public", "cod_table_public"), New System.Data.Common.DataColumnMapping("desc_table", "desc_table")})})
        '
        'SqlSelectCommand11
        '
        Me.SqlSelectCommand11.CommandText = "SELECT cod_item_type, desc_item_type, GL_account FROM inv_tab_type_item"
        Me.SqlSelectCommand11.Connection = Me.Cnn
        '
        'DAinv_tab_type_item
        '
        Me.DAinv_tab_type_item.SelectCommand = Me.SqlSelectCommand11
        Me.DAinv_tab_type_item.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_type_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_item_type", "cod_item_type"), New System.Data.Common.DataColumnMapping("desc_item_type", "desc_item_type"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account")})})
        '
        'LblStyle
        '
        Me.LblStyle.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.LblStyle.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.LblStyle.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblStyle.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblStyle.Enabled = False
        Me.LblStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblStyle.IncludeLiterals = False
        Me.LblStyle.Location = New System.Drawing.Point(70, 180)
        Me.LblStyle.MaxLength = 15
        Me.LblStyle.Name = "LblStyle"
        Me.LblStyle.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.LblStyle.ReadOnly = True
        Me.LblStyle.Size = New System.Drawing.Size(157, 22)
        Me.LblStyle.TabIndex = 14
        Me.LblStyle.TabStop = False
        Me.LblStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'LblBrand
        '
        Me.LblBrand.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.LblBrand.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.LblBrand.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblBrand.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblBrand.Enabled = False
        Me.LblBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblBrand.IncludeLiterals = False
        Me.LblBrand.Location = New System.Drawing.Point(295, 184)
        Me.LblBrand.MaxLength = 15
        Me.LblBrand.Name = "LblBrand"
        Me.LblBrand.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.LblBrand.ReadOnly = True
        Me.LblBrand.Size = New System.Drawing.Size(158, 22)
        Me.LblBrand.TabIndex = 15
        Me.LblBrand.TabStop = False
        Me.LblBrand.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'QuickReference1
        '
        Me.QuickReference1.Cnn = Me.Cnn
        Me.QuickReference1.FieldCodValue = ""
        Me.QuickReference1.Location = New System.Drawing.Point(68, 216)
        Me.QuickReference1.Name = "QuickReference1"
        Me.QuickReference1.ReadOnlyText = True
        Me.QuickReference1.Size = New System.Drawing.Size(77, 19)
        Me.QuickReference1.TabIndex = 8
        Me.QuickReference1.TxtBackColor = System.Drawing.Color.YellowGreen
        Me.QuickReference1.TxtForeColor = System.Drawing.SystemColors.WindowText
        Me.QuickReference1.TxtRightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT inv_tab_line.cod_brand, inv_tab_line.style, inv_tab_line.line, inv_tab_lin" & _
        "e.features, inv_tab_line.benefits, inv_tab_line.treadwear, inv_tab_line.traction" & _
        ", inv_tab_line.temperature, inv_tab_line.limit_warranty, inv_tab_line.constructi" & _
        "on, inv_tab_line.remark, inv_tab_line.image_remark, inv_tab_line.tread_life, inv" & _
        "_tab_line.wet_traction, inv_tab_line.quiet_ride, inv_tab_line.handling, inv_tab_" & _
        "line.winter_traction, inv_tab_line.nud_traction, inv_tab_line.overall_score, inv" & _
        "_tab_line.dry_traction, inv_tab_line.ride_comfort, inv_tab_style.desc_style, inv" & _
        "_tab_brand.complete_desc_brand FROM inv_tab_line INNER JOIN inv_tab_brand ON inv" & _
        "_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN inv_tab_style ON inv_ta" & _
        "b_line.style = inv_tab_style.style"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAinv_tab_line
        '
        Me.DAinv_tab_line.SelectCommand = Me.SqlSelectCommand2
        Me.DAinv_tab_line.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_line", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("line", "line"), New System.Data.Common.DataColumnMapping("features", "features"), New System.Data.Common.DataColumnMapping("benefits", "benefits"), New System.Data.Common.DataColumnMapping("treadwear", "treadwear"), New System.Data.Common.DataColumnMapping("traction", "traction"), New System.Data.Common.DataColumnMapping("temperature", "temperature"), New System.Data.Common.DataColumnMapping("limit_warranty", "limit_warranty"), New System.Data.Common.DataColumnMapping("construction", "construction"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("image_remark", "image_remark"), New System.Data.Common.DataColumnMapping("tread_life", "tread_life"), New System.Data.Common.DataColumnMapping("wet_traction", "wet_traction"), New System.Data.Common.DataColumnMapping("quiet_ride", "quiet_ride"), New System.Data.Common.DataColumnMapping("handling", "handling"), New System.Data.Common.DataColumnMapping("winter_traction", "winter_traction"), New System.Data.Common.DataColumnMapping("nud_traction", "nud_traction"), New System.Data.Common.DataColumnMapping("overall_score", "overall_score"), New System.Data.Common.DataColumnMapping("dry_traction", "dry_traction"), New System.Data.Common.DataColumnMapping("ride_comfort", "ride_comfort")})})
        '
        'NumListPrice
        '
        Me.NumListPrice.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumListPrice.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumListPrice.DecimalDigits = 2
        Me.NumListPrice.DefaultSendValue = False
        Me.NumListPrice.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumListPrice.FireTabAfterEnter = False
        Me.NumListPrice.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumListPrice.Image = CType(resources.GetObject("NumListPrice.Image"), System.Drawing.Image)
        Me.NumListPrice.Location = New System.Drawing.Point(308, 120)
        Me.NumListPrice.Maxlength = 12
        Me.NumListPrice.MinusColor = System.Drawing.Color.Empty
        Me.NumListPrice.Name = "NumListPrice"
        Me.NumListPrice.Size = New System.Drawing.Size(112, 22)
        Me.NumListPrice.TabIndex = 5
        Me.NumListPrice.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumListPrice.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(248, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 204
        Me.Label1.Text = "List Price"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtItemNo
        '
        Me.TxtItemNo.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtItemNo.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtItemNo.Enabled = False
        Me.TxtItemNo.Location = New System.Drawing.Point(55, 57)
        Me.TxtItemNo.MaxLength = 20
        Me.TxtItemNo.Name = "TxtItemNo"
        Me.TxtItemNo.Size = New System.Drawing.Size(189, 20)
        Me.TxtItemNo.TabIndex = 0
        Me.TxtItemNo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'CmbItemType
        '
        Me.CmbItemType.DataSource = Me.DsFrmItem_Quick_Add1.inv_tab_type_item
        Me.CmbItemType.DisplayMember = "desc_item_type"
        Me.CmbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbItemType.Enabled = False
        Me.CmbItemType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbItemType.ItemHeight = 13
        Me.CmbItemType.Location = New System.Drawing.Point(325, 57)
        Me.CmbItemType.Name = "CmbItemType"
        Me.CmbItemType.TabIndex = 1
        Me.CmbItemType.ValueMember = "cod_item_type"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.YellowGreen
        Me.Label4.Location = New System.Drawing.Point(2, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 22)
        Me.Label4.TabIndex = 208
        Me.Label4.Text = "Item No"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.YellowGreen
        Me.Label2.Location = New System.Drawing.Point(269, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 22)
        Me.Label2.TabIndex = 207
        Me.Label2.Text = "Item Type"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.YellowGreen
        Me.Label9.Location = New System.Drawing.Point(-10, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(506, 38)
        Me.Label9.TabIndex = 209
        '
        'SizeCod1
        '
        Me.SizeCod1.BackColor = System.Drawing.SystemColors.Control
        Me.SizeCod1.Cnn = Me.Cnn
        Me.SizeCod1.Cod_main = "01"
        Me.SizeCod1.FieldCodValue = Nothing
        Me.SizeCod1.Location = New System.Drawing.Point(329, 216)
        Me.SizeCod1.Name = "SizeCod1"
        Me.SizeCod1.Size = New System.Drawing.Size(119, 22)
        Me.SizeCod1.TabIndex = 9
        Me.SizeCod1.TxtBackColor = System.Drawing.Color.White
        Me.SizeCod1.TxtForeColor = System.Drawing.SystemColors.WindowText
        Me.SizeCod1.TxtRightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'NumFet
        '
        Me.NumFet.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumFet.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumFet.DecimalDigits = 2
        Me.NumFet.DefaultSendValue = False
        Me.NumFet.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumFet.FireTabAfterEnter = False
        Me.NumFet.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumFet.Image = CType(resources.GetObject("NumFet.Image"), System.Drawing.Image)
        Me.NumFet.Location = New System.Drawing.Point(195, 120)
        Me.NumFet.Maxlength = 8
        Me.NumFet.MinusColor = System.Drawing.Color.Empty
        Me.NumFet.Name = "NumFet"
        Me.NumFet.Size = New System.Drawing.Size(58, 22)
        Me.NumFet.TabIndex = 4
        Me.NumFet.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumFet.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'BtnPriceLevel
        '
        Me.BtnPriceLevel.BackColor = System.Drawing.SystemColors.Control
        Me.BtnPriceLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPriceLevel.Image = CType(resources.GetObject("BtnPriceLevel.Image"), System.Drawing.Image)
        Me.BtnPriceLevel.Location = New System.Drawing.Point(454, 148)
        Me.BtnPriceLevel.Name = "BtnPriceLevel"
        Me.BtnPriceLevel.Size = New System.Drawing.Size(23, 23)
        Me.BtnPriceLevel.TabIndex = 444
        Me.BtnPriceLevel.TabStop = False
        '
        'LblQref
        '
        Me.LblQref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblQref.Location = New System.Drawing.Point(154, 217)
        Me.LblQref.Name = "LblQref"
        Me.LblQref.Size = New System.Drawing.Size(143, 19)
        Me.LblQref.TabIndex = 445
        '
        'NumCost
        '
        Me.NumCost.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumCost.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumCost.DecimalDigits = 2
        Me.NumCost.DefaultSendValue = False
        Me.NumCost.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumCost.FireTabAfterEnter = False
        Me.NumCost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumCost.ForeColor = System.Drawing.Color.Black
        Me.NumCost.Image = CType(resources.GetObject("NumCost.Image"), System.Drawing.Image)
        Me.NumCost.Location = New System.Drawing.Point(68, 120)
        Me.NumCost.Maxlength = 12
        Me.NumCost.MinusColor = System.Drawing.Color.Empty
        Me.NumCost.Name = "NumCost"
        Me.NumCost.Size = New System.Drawing.Size(100, 22)
        Me.NumCost.TabIndex = 3
        Me.NumCost.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumCost.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'FrmItem_Quick_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(479, 281)
        Me.Controls.Add(Me.LblQref)
        Me.Controls.Add(Me.BtnPriceLevel)
        Me.Controls.Add(Me.NumCost)
        Me.Controls.Add(Me.NumFet)
        Me.Controls.Add(Me.SizeCod1)
        Me.Controls.Add(Me.TxtItemNo)
        Me.Controls.Add(Me.CmbItemType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.NumListPrice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.QuickReference1)
        Me.Controls.Add(Me.LblStyle)
        Me.Controls.Add(Me.LblBrand)
        Me.Controls.Add(Me.TxtService)
        Me.Controls.Add(Me.TxtDescription)
        Me.Controls.Add(Me.CmbLoadRange)
        Me.Controls.Add(Me.CmbSideWall)
        Me.Controls.Add(Me.CmbPriceCode)
        Me.Controls.Add(Me.CmbLine)
        Me.Controls.Add(Me.LblService)
        Me.Controls.Add(Me.LblSideWall)
        Me.Controls.Add(Me.LblLoadRange)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.LblSize)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label20)
        Me.Location = New System.Drawing.Point(200, 200)
        Me.Name = "FrmItem_Quick_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Item Quick Add"
        Me.Panel4.ResumeLayout(False)
        CType(Me.DsFrmItem_Quick_Add1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmWorkOrders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        myClsCommon = New CommonClass.AllStore

        Call FillDataAdabtors()
        CmbItemType.SelectedValue = "01"
        Call EnableDisableField(True)
        Call ClearAllField()
        Dim OleDbReaderForInventory As System.Data.OleDb.OleDbDataReader
        OleDbReaderForInventory = RetrieveInventorySetupTable(PubStoreNO)
        CmbPriceCode.SelectedValue = OleDbReaderForInventory.Item("DEFAULT_PRICE_CODE") & ""


        ThisFormStatus = MainModule.WorkStates.AddNew
        TxtItemNo.Focus()
        ChkInsertToAllStore.Visible = True
        ChkInsertToAllStore.Checked = True
    End Sub
    Private Sub FillDataAdabtors()
        DsFrmItem_Quick_Add1.inv_item_quick_refrence.Clear()
        DAinv_item_quick_refrence.Fill(DsFrmItem_Quick_Add1.inv_item_quick_refrence)

        DsFrmItem_Quick_Add1.inv_price_code.Clear()
        DAinv_price_code.Fill(DsFrmItem_Quick_Add1.inv_price_code)

        DsFrmItem_Quick_Add1.LoadRange.Clear()
        DAInv_tab_public.SelectCommand.Parameters("@Cod_Main").Value = "03"
        DAInv_tab_public.Fill(DsFrmItem_Quick_Add1.LoadRange)

        DsFrmItem_Quick_Add1.SideWall.Clear()
        DAInv_tab_public.SelectCommand.Parameters("@Cod_Main").Value = "02"
        DAInv_tab_public.Fill(DsFrmItem_Quick_Add1.SideWall)

        DsFrmItem_Quick_Add1.inv_tab_type_item.Clear()
        DAinv_tab_type_item.Fill(DsFrmItem_Quick_Add1.inv_tab_type_item)

        DsFrmItem_Quick_Add1.inv_tab_line.Clear()
        DAinv_tab_line.Fill(DsFrmItem_Quick_Add1.inv_tab_line)
        Call FndBrandAndStyle()
    End Sub
    Private Sub FillDA_Size()
        Select Case CmbItemType.SelectedValue
            Case "01"
                DsFrmItem_Quick_Add1.Tire_size.Clear()
                DAInv_tab_public.SelectCommand.Parameters("@Cod_Main").Value = "01"
                DAInv_tab_public.Fill(DsFrmItem_Quick_Add1.Tire_size)
            Case "04"
                DsFrmItem_Quick_Add1.Tire_size.Clear()
                DAInv_tab_public.SelectCommand.Parameters("@Cod_Main").Value = "09"
                DAInv_tab_public.Fill(DsFrmItem_Quick_Add1.Tire_size)
        End Select
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Call psave()
    End Sub
    Private Sub BtnSaveAndAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveAndAddNew.Click
        Call psave(False)
    End Sub
    Private Function CheckIsExist() As Boolean
        CheckIsExist = False
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "Select count(*) as countVar from inv_item where Item_no=" & Qt(TxtItemNo.Text)
        If CmdGeneral.ExecuteScalar = 1 Then
            CheckIsExist = True
            MsgFar("This Code is duplicate")
        End If
    End Function
    Private Sub psave(Optional ByVal ThisChangeStatus As Boolean = True)
        If ThisFormStatus = MainModule.WorkStates.AddNew Then
            If CheckIsExist() Then
                Exit Sub
            End If

            Dim transtatus As Int16 = 0
            Dim CnnMdbSetup As New System.Data.OleDb.OleDbConnection(PConnectionStringForSetupTables)
            Dim MyFrmShowErrorAllStoreInsert As New FrmShowErrorAllStoreInsert
            Dim DASTORE_SETUP As New System.Data.OleDb.OleDbDataAdapter
            Dim OleDbCommand1 As New System.Data.OleDb.OleDbCommand
            Dim ij As Integer = 0
            Dim destconnectionstring As String = ""
            Dim BefAllStoreCommandCnnTmp As System.Data.SqlClient.SqlConnection = Cnn
            DASTORE_SETUP.SelectCommand = OleDbCommand1
            If ChkInsertToAllStore.Checked Then
                OleDbCommand1.CommandText = "SELECT STORENO,SHORTNAME FROM STORE_SETUP ORDER BY STORENO"
            Else
                OleDbCommand1.CommandText = "SELECT STORENO,SHORTNAME FROM STORE_SETUP where STORENO = " & Qt(PubStoreNO)
            End If
            OleDbCommand1.Connection = CnnMdbSetup
            Dim dstmp As New DataSet
            DASTORE_SETUP.Fill(dstmp, "allstore")
            If dstmp.Tables("allstore").Rows.Count > 0 Then
                For ij = 0 To dstmp.Tables("allstore").Rows.Count - 1
                    Dim trans1 As SqlClient.SqlTransaction
                    destconnectionstring = MakeConnectionSqlForThisStore(dstmp.Tables("allstore").Rows(ij).Item("Storeno"))
                    Dim AllStoreCommandCnnTmp As New System.Data.SqlClient.SqlConnection
                    If destconnectionstring.Trim & "" <> "" Then
                        AllStoreCommandCnnTmp.ConnectionString = destconnectionstring
                        If Cnn.State = ConnectionState.Open Then
                            Cnn.Close()
                        End If
                        Cnn.ConnectionString = AllStoreCommandCnnTmp.ConnectionString
                        CmdGeneral.Connection = Cnn
                        'Call SetInsertConnectionTo(Cnn)
                        Cnn.Open()
                        Try
                            trans1 = Cnn.BeginTransaction(IsolationLevel.ReadCommitted)
                            transtatus = -1
                            CmdGeneral.Transaction = trans1
                            Try
                                CmdGeneral.CommandText = "Insert Into inv_item (item_no, cod_item_type, desc_item, cod_quick_refrence, line,taxable,ITEMCRATEDDATE,ItemFirstCost) Values(" & Qt(TxtItemNo.Text) & "," & Qt(CmbItemType.SelectedValue) & "," & Qt(TxtDescription.Text) & "," & Qt(QuickReference1.FieldCodValue) & "," & Qt(CmbLine.SelectedValue) & "," & IIf(TaxableVar, 1, 0) & "," & Qt(Format(Now.Date, PubDateFormat)) & "," & NumCost.Numbervalue & ")"
                                CmdGeneral.ExecuteNonQuery()
                                Try
                                    CmdGeneral.CommandText = "Insert Into inv_item_cost_transaction (item_no,Cost,Fet,list_price,Price_code,Date_Cost_change) Values(" & Qt(TxtItemNo.Text) & "," & NumCost.Numbervalue & "," & NumFet.Numbervalue & "," & NumListPrice.Numbervalue & "," & Qt(CmbPriceCode.SelectedValue) & "," & Qt(Format(Now.Today, PubDateFormat)) & ")"
                                    CmdGeneral.ExecuteNonQuery()
                                    Try
                                        CmdGeneral.CommandText = "Insert Into inv_discount_item (item_no, last_flag) Values(" & Qt(TxtItemNo.Text) & ",'1')"
                                        CmdGeneral.ExecuteNonQuery()
                                        Try

                                            CmdGeneral.CommandText = "Insert Into inv_tab_item_warehouse (item_no, cod_warehouse,cod_location,on_hand,comitted,on_order,min_stock,max_stock,reorde) Values(" & Qt(TxtItemNo.Text) & ",'1', Null,0,0,0,0,0,0)"
                                            CmdGeneral.ExecuteNonQuery()
                                            Select Case CmbItemType.SelectedValue
                                                Case "01" 'TIRE
                                                    Try
                                                        CmdGeneral.CommandText = "Insert Into inv_tab_tire_specification (item_no,tire_size,service_description,sidwall,load_range) values(" & Qt(TxtItemNo.Text) & "," & Qt(SizeCod1.FieldCodValue) & "," & Qt(TxtService.Text) & "," & IIf(CmbSideWall.Text.Trim.Trim.Length > 0, Qt(CmbSideWall.SelectedValue), "NULL") & "," & IIf(CmbLoadRange.Text.Trim.Trim.Length > 0, Qt(CmbLoadRange.SelectedValue), "NULL") & ")"
                                                        CmdGeneral.ExecuteNonQuery()
                                                        transtatus = 1
                                                    Catch ex As Exception
                                                    End Try
                                                Case "04" 'WHEEL
                                                    Try
                                                        CmdGeneral.CommandText = "Insert Into inv_tab_wheels_specification (item_no,Wheel_size) values(" & Qt(TxtItemNo.Text) & "," & Qt(SizeCod1.FieldCodValue) & ")"
                                                        CmdGeneral.ExecuteNonQuery()
                                                        transtatus = 1
                                                    Catch ex As Exception
                                                    End Try
                                                Case Else 'Auto Part
                                                    Try
                                                        CmdGeneral.CommandText = "Insert Into inv_tab_autopart_specification (item_no) values(" & Qt(TxtItemNo.Text) & ")"
                                                        CmdGeneral.ExecuteNonQuery()
                                                        transtatus = 1
                                                    Catch ex As Exception

                                                    End Try
                                            End Select
                                        Catch ex As Exception
                                        End Try
                                    Catch ex As Exception
                                    End Try
                                Catch ex As Exception
                                End Try
                            Catch ex As Exception
                            End Try
                        Catch ex As Exception
                        End Try
                    End If
                    Select Case transtatus
                        Case 1
                            Try
                                trans1.Commit()
                                MyFrmShowErrorAllStoreInsert.LstNote.Items.Add(" Store no  " & dstmp.Tables("allstore").Rows(ij).Item("Storeno") & "  " & dstmp.Tables("allstore").Rows(ij).Item("Shortname") & "  Insert Completed ")
                            Catch ex As Exception
                            End Try
                        Case -1
                            Try
                                trans1.Rollback()
                                MyFrmShowErrorAllStoreInsert.LstNote.Items.Add(" Store no  " & dstmp.Tables("allstore").Rows(ij).Item("Storeno") & "  " & dstmp.Tables("allstore").Rows(ij).Item("Shortname") & "  Not Inserted ")
                            Catch ex As Exception
                            End Try
                    End Select

                    Try
                        MyItem = New UCInv_Item.Clsitem_no
                        Dim newcnn As New System.Data.SqlClient.SqlConnection(destconnectionstring)
                        newcnn.Open()
                        MyItem.Connection = newcnn
                        Dim Pl1 As Double = 0
                        Dim Pl2 As Double = 0
                        Dim Pl3 As Double = 0
                        Dim Pl4 As Double = 0
                        Dim Pl5 As Double = 0
                        Dim Pl6 As Double = 0
                        Pl1 = MyItem.CalculatePriceCode(TxtItemNo.Text, 1)
                        Pl2 = MyItem.CalculatePriceCode(TxtItemNo.Text, 2)
                        Pl3 = MyItem.CalculatePriceCode(TxtItemNo.Text, 3)
                        Pl4 = MyItem.CalculatePriceCode(TxtItemNo.Text, 4)
                        Pl5 = MyItem.CalculatePriceCode(TxtItemNo.Text, 5)
                        Pl6 = MyItem.CalculatePriceCode(TxtItemNo.Text, 6)
                        CmdGeneral.CommandText = "Update inv_item_cost_transaction SET amount_price1=" & Pl1 & ",amount_price2=" & Pl2 & ",amount_price3=" & Pl3 & ",amount_price4=" & Pl4 & ",amount_price5=" & Pl5 & ",amount_price6=" & Pl6 & " WHERE item_no=" & Qt(TxtItemNo.Text) & " AND last_flag=1"
                        CmdGeneral.ExecuteNonQuery()
                    Catch ex As Exception
                    End Try

                Next



            End If


            '''''''Try
            '''''''    If CmdGeneral.Connection.State <> ConnectionState.Open Then
            '''''''        CmdGeneral.Connection.Open()
            '''''''    End If
            '''''''    CmdGeneral.CommandText = "Insert Into inv_item (item_no, cod_item_type, desc_item, cod_quick_refrence, line,taxable,ITEMCRATEDDATE,ItemFirstCost) Values(" & Qt(TxtItemNo.Text) & "," & Qt(CmbItemType.SelectedValue) & "," & Qt(TxtDescription.Text) & "," & Qt(QuickReference1.FieldCodValue) & "," & Qt(CmbLine.SelectedValue) & "," & IIf(TaxableVar, 1, 0) & "," & Qt(Format(Now.Date, PubDateFormat)) & "," & NumCost.Numbervalue & ")"
            '''''''    'CmdGeneral.ExecuteNonQuery()
            '''''''    myClsCommon.AllStoreCommand(CmdGeneral, Not ChkInsertToAllStore.Checked, True)

            '''''''    CmdGeneral.CommandText = "Insert Into inv_item_cost_transaction (item_no,Cost,Fet,list_price,Price_code,Date_Cost_change) Values(" & Qt(TxtItemNo.Text) & "," & NumCost.Numbervalue & "," & NumFet.Numbervalue & "," & NumListPrice.Numbervalue & "," & Qt(CmbPriceCode.SelectedValue) & "," & Qt(Format(Now.Today, PubDateFormat)) & ")"
            '''''''    'CmdGeneral.ExecuteNonQuery()
            '''''''    myClsCommon.AllStoreCommand(CmdGeneral, Not ChkInsertToAllStore.Checked, False)

            '''''''    Select Case CmbItemType.SelectedValue
            '''''''        Case "01" 'TIRE
            '''''''            CmdGeneral.CommandText = "Insert Into inv_tab_tire_specification (item_no,tire_size,service_description,sidwall,load_range) values(" & Qt(TxtItemNo.Text) & "," & Qt(SizeCod1.FieldCodValue) & "," & Qt(TxtService.Text) & "," & IIf(CmbSideWall.Text.Trim.Trim.Length > 0, Qt(CmbSideWall.SelectedValue), "NULL") & "," & IIf(CmbLoadRange.Text.Trim.Trim.Length > 0, Qt(CmbLoadRange.SelectedValue), "NULL") & ")"
            '''''''            'CmdGeneral.ExecuteNonQuery()
            '''''''            myClsCommon.AllStoreCommand(CmdGeneral, Not ChkInsertToAllStore.Checked, False)
            '''''''        Case "04" 'WHEEL
            '''''''            CmdGeneral.CommandText = "Insert Into inv_tab_wheels_specification (item_no,Wheel_size) values(" & Qt(TxtItemNo.Text) & "," & Qt(SizeCod1.FieldCodValue) & ")"
            '''''''            'CmdGeneral.ExecuteNonQuery()
            '''''''            myClsCommon.AllStoreCommand(CmdGeneral, Not ChkInsertToAllStore.Checked, False)
            '''''''        Case Else 'Auto Part
            '''''''            CmdGeneral.CommandText = "Insert Into inv_tab_autopart_specification (item_no) values(" & Qt(TxtItemNo.Text) & ")"
            '''''''            'CmdGeneral.ExecuteNonQuery()
            '''''''            myClsCommon.AllStoreCommand(CmdGeneral, Not ChkInsertToAllStore.Checked, False)
            '''''''    End Select
            '''''''    CmdGeneral.CommandText = "Insert Into inv_discount_item (item_no, last_flag) Values(" & Qt(TxtItemNo.Text) & ",'1')"
            '''''''    'CmdGeneral.ExecuteNonQuery()
            '''''''    myClsCommon.AllStoreCommand(CmdGeneral, Not ChkInsertToAllStore.Checked, False)

            '''''''    CmdGeneral.CommandText = "Insert Into inv_tab_item_warehouse (item_no, cod_warehouse,cod_location,on_hand,comitted,on_order,min_stock,max_stock,reorde) Values(" & Qt(TxtItemNo.Text) & ",'1', Null,0,0,0,0,0,0)"
            '''''''    myClsCommon.AllStoreCommand(CmdGeneral, Not ChkInsertToAllStore.Checked, False)


            '''''''    MyItem = New UCInv_Item.Clsitem_no
            '''''''    MyItem.Connection = Me.Cnn
            '''''''    Dim Pl1 As Double = 0
            '''''''    Dim Pl2 As Double = 0
            '''''''    Dim Pl3 As Double = 0
            '''''''    Dim Pl4 As Double = 0
            '''''''    Dim Pl5 As Double = 0
            '''''''    Dim Pl6 As Double = 0
            '''''''    Pl1 = MyItem.CalculatePriceCode(TxtItemNo.Text, 1)
            '''''''    Pl2 = MyItem.CalculatePriceCode(TxtItemNo.Text, 2)
            '''''''    Pl3 = MyItem.CalculatePriceCode(TxtItemNo.Text, 3)
            '''''''    Pl4 = MyItem.CalculatePriceCode(TxtItemNo.Text, 4)
            '''''''    Pl5 = MyItem.CalculatePriceCode(TxtItemNo.Text, 5)
            '''''''    Pl6 = MyItem.CalculatePriceCode(TxtItemNo.Text, 6)

            '''''''    If CmdGeneral.Connection.State <> ConnectionState.Open Then
            '''''''        CmdGeneral.Connection.Open()
            '''''''    End If
            '''''''    CmdGeneral.CommandText = "Update inv_item_cost_transaction SET amount_price1=" & Pl1 & ",amount_price2=" & Pl2 & ",amount_price3=" & Pl3 & ",amount_price4=" & Pl4 & ",amount_price5=" & Pl5 & ",amount_price6=" & Pl6 & " WHERE item_no=" & Qt(TxtItemNo.Text) & " AND last_flag=1"
            '''''''    'CmdGeneral.ExecuteNonQuery()
            '''''''    myClsCommon.AllStoreCommand(CmdGeneral, Not ChkInsertToAllStore.Checked, False)

            BtnSave.Enabled = False
            BtnSaveAndAddNew.Enabled = False
            ItemCodeVar = TxtItemNo.Text

            If ChkInsertToAllStore.Checked Then
                MyFrmShowErrorAllStoreInsert.ShowDialog()
            Else
                ' nothing
            End If

            If ThisChangeStatus Then
                Me.Close()
            Else
                Call ClearAllField()
                TxtItemNo.Focus()
            End If
            '''''Catch ex As Exception
            '''''    MsgFar("Cannot Save This Item Code")
            '''''Finally
            '''''    CmdGeneral.Connection.Close()
            '''''End Try
        End If
    End Sub
    Private Sub FillDataInScreen()
        With DsFrmItem_Quick_Add1.inv_item
            If .Rows.Count > 0 Then
                CmbItemType.SelectedValue = .Rows(0).Item("cod_item_type") & ""
                CmbLine.SelectedValue = .Rows(0).Item("line") & ""
                CmbLoadRange.SelectedValue = .Rows(0).Item("load_range") & ""
                CmbPriceCode.SelectedValue = .Rows(0).Item("price_code") & ""
                QuickReference1.FieldCodValue = .Rows(0).Item("cod_quick_refrence") & ""
                CmbSideWall.SelectedValue = .Rows(0).Item("sidwall") & ""
                Select Case CmbItemType.SelectedValue
                    Case "01"
                        SizeCod1.FieldCodValue = .Rows(0).Item("tire_size") & ""
                    Case "04"
                        SizeCod1.FieldCodValue = .Rows(0).Item("Wheel_size") & ""
                End Select
                NumCost.Text = .Rows(0).Item("Cost") & ""
                NumFet.Text = .Rows(0).Item("Fet") & ""
                NumListPrice.Text = .Rows(0).Item("list_price") & ""
                TxtDescription.Text = .Rows(0).Item("desc_item") & ""
                TxtItemNo.Text = .Rows(0).Item("item_no") & ""
                TxtService.Text = .Rows(0).Item("service_description") & ""
            End If
        End With
    End Sub
    Private Sub ClearAllField()
        Dim OleDbReaderForInventory As System.Data.OleDb.OleDbDataReader
        OleDbReaderForInventory = RetrieveInventorySetupTable(PubStoreNO)
        '  CmbPriceCode.SelectedValue = OleDbReaderForInventory.Item("DEFAULT_PRICE_CODE") & ""
        TaxableVar = OleDbReaderForInventory.Item("Taxable")
        OleDbReaderForInventory.Close()

        LblQref.Text = ""
        CmbItemType.Text = ""
        CmbLine.Text = ""
        CmbLoadRange.Text = ""
        QuickReference1.FieldCodValue = ""
        CmbSideWall.Text = ""
        SizeCod1.FieldCodValue = 0
        NumListPrice.Text = 0
        NumCost.Text = 0
        NumFet.Text = 0
        TxtDescription.Clear()
        TxtItemNo.Clear()
        TxtService.Clear()
    End Sub
    Private Sub EnableDisableSave()
        Try
            If CmbItemType.Text.Trim.Length > 0 _
               And CmbLine.Text.Trim.Length > 0 _
               And CmbPriceCode.Text.Trim.Length > 0 _
               And QuickReference1.FieldCodValue.Trim.Length > 0 _
               And TxtDescription.Text.Trim.Length > 0 _
               And TxtItemNo.Text.Trim.Length > 0 _
               And NumCost.Text > 0 Then
                'And (SizeCod1.Text.Trim.Length > 0 Or SizeCod1.Visible = False) 

                BtnSave.Enabled = True
                BtnSaveAndAddNew.Enabled = True
            Else
                BtnSave.Enabled = False
                BtnSaveAndAddNew.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub EnableDisableField(ByVal InStatus As Boolean)
        If ThisFormStatus = MainModule.WorkStates._ReadOnly Then
            TxtItemNo.Enabled = False
            CmbItemType.Enabled = False
        Else
            TxtItemNo.Enabled = InStatus
            CmbItemType.Enabled = InStatus
        End If
        TxtDescription.Enabled = InStatus
        TxtService.Enabled = InStatus And TxtService.Visible
        CmbLine.Enabled = InStatus
        CmbLoadRange.Enabled = InStatus And CmbLoadRange.Visible
        CmbPriceCode.Enabled = InStatus
        QuickReference1.Enabled = InStatus
        CmbSideWall.Enabled = InStatus And CmbSideWall.Visible
        SizeCod1.Enabled = InStatus And SizeCod1.Visible
        NumListPrice.Enabled = InStatus
        NumCost.Enabled = InStatus
        NumFet.Enabled = InStatus
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        'ThisFormStatus = MainModule.WorkStates._ReadOnly
        If IsCancelForExitFlag Then
            ItemCodeVar = TxtItemNo.Text
            Me.Close()
        End If
        Call ClearAllField()
        BtnSave.Enabled = False
        BtnSaveAndAddNew.Enabled = False
    End Sub
    Private Sub TxtItemNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtItemNo.TextChanged, TxtDescription.TextChanged, TxtService.TextChanged, NumFet.TextChanged, NumListPrice.TextChanged, CmbItemType.SelectedIndexChanged, CmbLine.SelectedIndexChanged, CmbLoadRange.SelectedIndexChanged, CmbPriceCode.SelectedIndexChanged, CmbSideWall.SelectedIndexChanged, QuickReference1.TextChanged, LblBrand.TextChanged, LblStyle.TextChanged, SizeCod1.TextChanged, NumCost.TextChanged
        Call EnableDisableSave()
    End Sub
    Private Sub CmbLine_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbLine.SelectedIndexChanged
        Call EnableDisableSave()
        FndBrandAndStyle()
    End Sub
    Private Sub CmbItemType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbItemType.SelectedIndexChanged
        Call FillDA_Size()
        Call EnableDisableSave()
        Call VisibleItemTypeRelatedField()
    End Sub
    Private Sub VisibleItemTypeRelatedField()
        Select Case CmbItemType.SelectedValue
            Case "01"
                LblLoadRange.Visible = True
                LblService.Visible = True
                LblSideWall.Visible = True
                LblSize.Visible = True
                SizeCod1.Visible = True
                TxtService.Visible = True
                CmbSideWall.Visible = True
                CmbLoadRange.Visible = True
            Case "04" 'WHEEL
                LblLoadRange.Visible = False
                LblService.Visible = False
                LblSideWall.Visible = False
                LblSize.Visible = True
                SizeCod1.Visible = True
                TxtService.Visible = False
                CmbSideWall.Visible = False
                CmbLoadRange.Visible = False
            Case Else
                LblLoadRange.Visible = False
                LblService.Visible = False
                LblSideWall.Visible = False
                LblSize.Visible = False
                SizeCod1.Visible = False
                TxtService.Visible = False
                CmbSideWall.Visible = False
                CmbLoadRange.Visible = False
        End Select
    End Sub
    Private Sub LoadAWotkOrder(ByVal ThisItem_no As String)
        DsFrmItem_Quick_Add1.inv_item.Clear()
        DAinv_item.SelectCommand.Parameters("@Item_No").Value = ThisItem_no
        DAinv_item.Fill(DsFrmItem_Quick_Add1.inv_item)
        Call ClearAllField()
        Call FillDataInScreen()
    End Sub
    Private Sub TxtItemNo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtItemNo.Validating
        If CheckIsExist() Then
            TxtItemNo.Clear()
            e.Cancel = True
        End If
    End Sub
    Private Sub FrmItem_Quick_Add_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If BtnSave.Enabled Then
            MsgFar("Please Save OR Cancel The Information")
            e.Cancel = True
        End If
    End Sub
    Sub FndBrandAndStyle()
        Dim dr As DataRow
        Try
            dr = DsFrmItem_Quick_Add1.inv_tab_line.FindByline(CmbLine.SelectedValue)
            LblBrand.Text = dr("complete_desc_brand") & ""
            LblStyle.Text = dr("desc_style") & ""

        Catch ex As Exception
            LblBrand.Text = ""
            LblStyle.Text = ""
        End Try
    End Sub
    Private Sub QuickReference1_NotFind() Handles QuickReference1.NotFind
        LblQref.Text = ""
        Call EnableDisableSave()
    End Sub
    Private Sub QuickReference1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles QuickReference1.LostFocus
        Call EnableDisableSave()
    End Sub
    Private Sub SizeCod1_AfterFieldCodValueFind(ByVal ThisRow As System.Data.DataRow) Handles SizeCod1.AfterFieldCodValueFind
        Call EnableDisableSave()
    End Sub
    Private Sub SizeCod1_NotFind() Handles SizeCod1.NotFind
        Call EnableDisableSave()
    End Sub
    Private Sub SizeCod1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SizeCod1.LostFocus
        Call EnableDisableSave()
    End Sub

    Private Sub SizeCod1_ExecuteFrmSizeAddNew() Handles SizeCod1.ExecuteFrmSizeAddNew
        Dim ar(0) As Object
        ar(0) = "401140100" ' size
        Dim tempAssembly As System.Reflection.Assembly
        tempAssembly = System.Reflection.Assembly.LoadFrom(Application.StartupPath & "\" & "FormGenerator.dll")
        Dim t As Type = tempAssembly.GetType("FormGenerator.FrmGeneral")
        Dim c As Form = CType(Activator.CreateInstance(t, ar), Form)
        c.ShowDialog()
    End Sub
    Private Sub BtnPriceLevel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPriceLevel.Click
        Dim MyFrmShowPriceLevels As New FrmShowPriceLevels
        Call FitToScreen(BtnPriceLevel, MyFrmShowPriceLevels)
        MyFrmShowPriceLevels.Item_NoVar = TxtItemNo.Text
        MyFrmShowPriceLevels.PriceCodevar = CmbPriceCode.SelectedValue
        MyFrmShowPriceLevels.CostVar = NumCost.Text
        MyFrmShowPriceLevels.ListPriceVar = NumListPrice.Text
        MyFrmShowPriceLevels.ShowDialog()
    End Sub
    Private Sub QuickReference1_AfterFieldCodValueFind(ByVal ThisRow As System.Data.DataRow) Handles QuickReference1.AfterFieldCodValueFind
        LblQref.Text = ThisRow(1) & ""
        Call EnableDisableSave()
    End Sub
    Private Sub TxtItemNo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtItemNo.KeyUp, CmbItemType.KeyUp, TxtDescription.KeyUp, CmbLine.KeyUp, CmbPriceCode.KeyUp, QuickReference1.KeyUp, SizeCod1.KeyUp, TxtService.KeyUp, CmbSideWall.KeyUp, CmbLoadRange.KeyUp, NumCost.KeyUp, NumFet.KeyUp, NumListPrice.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub
    Private Sub TxtItemNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtItemNo.Leave
        TxtItemNo.Text = TxtItemNo.Text.Trim
    End Sub
End Class
