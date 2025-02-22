
Imports CommonClass
Public Class FrmRepItem
    Inherits FrmBase
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmbItemType As System.Windows.Forms.ComboBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RdoSelectdSize As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllSize As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSelectedStyle As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllStyle As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSelectedBrand As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllBrand As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSelectedLine As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllLine As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSelectedItem As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllItem As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnLine As System.Windows.Forms.Button
    Friend WithEvents BtnBrand As System.Windows.Forms.Button
    Friend WithEvents BtnStyle As System.Windows.Forms.Button
    Friend WithEvents BtnSize As System.Windows.Forms.Button
    Friend WithEvents CalendarCombo1 As CalendarCombo.CalendarCombo
    Friend WithEvents CalendarCombo2 As CalendarCombo.CalendarCombo
    Friend WithEvents PanelSize As System.Windows.Forms.Panel
    Friend WithEvents PanelStyle As System.Windows.Forms.Panel
    Friend WithEvents PanelBrand As System.Windows.Forms.Panel
    Friend WithEvents PanelLine As System.Windows.Forms.Panel
    Friend WithEvents BtnItem As System.Windows.Forms.Button
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAItem As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmRepItem1 As Report.DSFrmRepItem
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DALine As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAStyle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DABrand As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DATypeItem As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DASize As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelDate As System.Windows.Forms.GroupBox
    Friend WithEvents PanelTypeItem As System.Windows.Forms.GroupBox
    Friend WithEvents PanelLBSS As System.Windows.Forms.GroupBox
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents ChkZero As System.Windows.Forms.CheckBox
    Friend WithEvents PanelDetail As System.Windows.Forms.Panel
    Friend WithEvents RdoSummery As System.Windows.Forms.RadioButton
    Friend WithEvents RdoDetail As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmRepItem))
        Me.PanelDate = New System.Windows.Forms.GroupBox
        Me.CalendarCombo2 = New CalendarCombo.CalendarCombo
        Me.CalendarCombo1 = New CalendarCombo.CalendarCombo
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PanelTypeItem = New System.Windows.Forms.GroupBox
        Me.PanelDetail = New System.Windows.Forms.Panel
        Me.RdoSummery = New System.Windows.Forms.RadioButton
        Me.RdoDetail = New System.Windows.Forms.RadioButton
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.BtnItem = New System.Windows.Forms.Button
        Me.RdoSelectedItem = New System.Windows.Forms.RadioButton
        Me.RdoAllItem = New System.Windows.Forms.RadioButton
        Me.CmbItemType = New System.Windows.Forms.ComboBox
        Me.DsFrmRepItem1 = New Report.DSFrmRepItem
        Me.Label4 = New System.Windows.Forms.Label
        Me.PanelLBSS = New System.Windows.Forms.GroupBox
        Me.ChkZero = New System.Windows.Forms.CheckBox
        Me.PanelSize = New System.Windows.Forms.Panel
        Me.BtnSize = New System.Windows.Forms.Button
        Me.RdoSelectdSize = New System.Windows.Forms.RadioButton
        Me.RdoAllSize = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.PanelStyle = New System.Windows.Forms.Panel
        Me.BtnStyle = New System.Windows.Forms.Button
        Me.RdoSelectedStyle = New System.Windows.Forms.RadioButton
        Me.RdoAllStyle = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.PanelBrand = New System.Windows.Forms.Panel
        Me.BtnBrand = New System.Windows.Forms.Button
        Me.RdoSelectedBrand = New System.Windows.Forms.RadioButton
        Me.RdoAllBrand = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.PanelLine = New System.Windows.Forms.Panel
        Me.BtnLine = New System.Windows.Forms.Button
        Me.RdoSelectedLine = New System.Windows.Forms.RadioButton
        Me.RdoAllLine = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.BtnOk = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAItem = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DALine = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAStyle = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DABrand = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DATypeItem = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DASize = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.PanelDate.SuspendLayout()
        Me.PanelTypeItem.SuspendLayout()
        Me.PanelDetail.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DsFrmRepItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLBSS.SuspendLayout()
        Me.PanelSize.SuspendLayout()
        Me.PanelStyle.SuspendLayout()
        Me.PanelBrand.SuspendLayout()
        Me.PanelLine.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelDate
        '
        Me.PanelDate.Controls.Add(Me.CalendarCombo2)
        Me.PanelDate.Controls.Add(Me.CalendarCombo1)
        Me.PanelDate.Controls.Add(Me.Label3)
        Me.PanelDate.Controls.Add(Me.Label2)
        Me.PanelDate.Controls.Add(Me.Label1)
        Me.PanelDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDate.Location = New System.Drawing.Point(0, 48)
        Me.PanelDate.Name = "PanelDate"
        Me.PanelDate.Size = New System.Drawing.Size(425, 40)
        Me.PanelDate.TabIndex = 0
        Me.PanelDate.TabStop = False
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
        Me.CalendarCombo2.Location = New System.Drawing.Point(298, 8)
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
        'CalendarCombo1
        '
        Me.CalendarCombo1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CalendarCombo1.BorderColor = System.Drawing.Color.Empty
        Me.CalendarCombo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CalendarCombo1.ButtonBackColor = System.Drawing.Color.Empty
        Me.CalendarCombo1.ButtonForeColor = System.Drawing.Color.Empty
        Me.CalendarCombo1.EditableSal = True
        Me.CalendarCombo1.Image = CType(resources.GetObject("CalendarCombo1.Image"), System.Drawing.Image)
        Me.CalendarCombo1.Location = New System.Drawing.Point(154, 8)
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
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(266, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(106, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "From"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Report Dates :"
        '
        'PanelTypeItem
        '
        Me.PanelTypeItem.Controls.Add(Me.PanelDetail)
        Me.PanelTypeItem.Controls.Add(Me.Panel5)
        Me.PanelTypeItem.Controls.Add(Me.CmbItemType)
        Me.PanelTypeItem.Controls.Add(Me.Label4)
        Me.PanelTypeItem.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTypeItem.Location = New System.Drawing.Point(0, 88)
        Me.PanelTypeItem.Name = "PanelTypeItem"
        Me.PanelTypeItem.Size = New System.Drawing.Size(425, 72)
        Me.PanelTypeItem.TabIndex = 1
        Me.PanelTypeItem.TabStop = False
        '
        'PanelDetail
        '
        Me.PanelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDetail.Controls.Add(Me.RdoSummery)
        Me.PanelDetail.Controls.Add(Me.RdoDetail)
        Me.PanelDetail.Location = New System.Drawing.Point(334, 14)
        Me.PanelDetail.Name = "PanelDetail"
        Me.PanelDetail.Size = New System.Drawing.Size(76, 49)
        Me.PanelDetail.TabIndex = 10
        Me.PanelDetail.Visible = False
        '
        'RdoSummery
        '
        Me.RdoSummery.Location = New System.Drawing.Point(8, 24)
        Me.RdoSummery.Name = "RdoSummery"
        Me.RdoSummery.Size = New System.Drawing.Size(72, 24)
        Me.RdoSummery.TabIndex = 1
        Me.RdoSummery.Text = "Summary"
        '
        'RdoDetail
        '
        Me.RdoDetail.Checked = True
        Me.RdoDetail.Location = New System.Drawing.Point(8, 0)
        Me.RdoDetail.Name = "RdoDetail"
        Me.RdoDetail.Size = New System.Drawing.Size(72, 24)
        Me.RdoDetail.TabIndex = 0
        Me.RdoDetail.TabStop = True
        Me.RdoDetail.Text = "Detail"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.BtnItem)
        Me.Panel5.Controls.Add(Me.RdoSelectedItem)
        Me.Panel5.Controls.Add(Me.RdoAllItem)
        Me.Panel5.Location = New System.Drawing.Point(16, 40)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(307, 24)
        Me.Panel5.TabIndex = 6
        '
        'BtnItem
        '
        Me.BtnItem.Enabled = False
        Me.BtnItem.Location = New System.Drawing.Point(221, 2)
        Me.BtnItem.Name = "BtnItem"
        Me.BtnItem.TabIndex = 3
        Me.BtnItem.Text = "Choose..."
        '
        'RdoSelectedItem
        '
        Me.RdoSelectedItem.Location = New System.Drawing.Point(91, 0)
        Me.RdoSelectedItem.Name = "RdoSelectedItem"
        Me.RdoSelectedItem.TabIndex = 1
        Me.RdoSelectedItem.Text = "Selected Items"
        '
        'RdoAllItem
        '
        Me.RdoAllItem.Checked = True
        Me.RdoAllItem.Location = New System.Drawing.Point(0, 0)
        Me.RdoAllItem.Name = "RdoAllItem"
        Me.RdoAllItem.TabIndex = 0
        Me.RdoAllItem.TabStop = True
        Me.RdoAllItem.Text = "All Items"
        '
        'CmbItemType
        '
        Me.CmbItemType.DataSource = Me.DsFrmRepItem1
        Me.CmbItemType.DisplayMember = "inv_tab_type_item.desc_item_type"
        Me.CmbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbItemType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbItemType.ItemHeight = 13
        Me.CmbItemType.Location = New System.Drawing.Point(104, 16)
        Me.CmbItemType.Name = "CmbItemType"
        Me.CmbItemType.Size = New System.Drawing.Size(120, 21)
        Me.CmbItemType.TabIndex = 1
        Me.CmbItemType.ValueMember = "inv_tab_type_item.cod_item_type"
        '
        'DsFrmRepItem1
        '
        Me.DsFrmRepItem1.DataSetName = "DSFrmRepItem"
        Me.DsFrmRepItem1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "For Item Type"
        '
        'PanelLBSS
        '
        Me.PanelLBSS.Controls.Add(Me.ChkZero)
        Me.PanelLBSS.Controls.Add(Me.PanelSize)
        Me.PanelLBSS.Controls.Add(Me.PanelStyle)
        Me.PanelLBSS.Controls.Add(Me.PanelBrand)
        Me.PanelLBSS.Controls.Add(Me.PanelLine)
        Me.PanelLBSS.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLBSS.Location = New System.Drawing.Point(0, 160)
        Me.PanelLBSS.Name = "PanelLBSS"
        Me.PanelLBSS.Size = New System.Drawing.Size(425, 250)
        Me.PanelLBSS.TabIndex = 2
        Me.PanelLBSS.TabStop = False
        '
        'ChkZero
        '
        Me.ChkZero.Checked = True
        Me.ChkZero.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkZero.Location = New System.Drawing.Point(22, 218)
        Me.ChkZero.Name = "ChkZero"
        Me.ChkZero.Size = New System.Drawing.Size(329, 24)
        Me.ChkZero.TabIndex = 9
        Me.ChkZero.Text = "Do Not Print Items With Zero  Quantity  On Hand"
        '
        'PanelSize
        '
        Me.PanelSize.Controls.Add(Me.BtnSize)
        Me.PanelSize.Controls.Add(Me.RdoSelectdSize)
        Me.PanelSize.Controls.Add(Me.RdoAllSize)
        Me.PanelSize.Controls.Add(Me.Label7)
        Me.PanelSize.Location = New System.Drawing.Point(22, 160)
        Me.PanelSize.Name = "PanelSize"
        Me.PanelSize.Size = New System.Drawing.Size(384, 48)
        Me.PanelSize.TabIndex = 8
        '
        'BtnSize
        '
        Me.BtnSize.Enabled = False
        Me.BtnSize.Location = New System.Drawing.Point(280, 16)
        Me.BtnSize.Name = "BtnSize"
        Me.BtnSize.TabIndex = 3
        Me.BtnSize.Text = "Choose..."
        '
        'RdoSelectdSize
        '
        Me.RdoSelectdSize.Location = New System.Drawing.Point(136, 16)
        Me.RdoSelectdSize.Name = "RdoSelectdSize"
        Me.RdoSelectdSize.TabIndex = 1
        Me.RdoSelectdSize.Text = "Selected Sizes"
        '
        'RdoAllSize
        '
        Me.RdoAllSize.Checked = True
        Me.RdoAllSize.Location = New System.Drawing.Point(0, 16)
        Me.RdoAllSize.Name = "RdoAllSize"
        Me.RdoAllSize.TabIndex = 0
        Me.RdoAllSize.TabStop = True
        Me.RdoAllSize.Text = "All Sizes"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "For Sizes"
        '
        'PanelStyle
        '
        Me.PanelStyle.Controls.Add(Me.BtnStyle)
        Me.PanelStyle.Controls.Add(Me.RdoSelectedStyle)
        Me.PanelStyle.Controls.Add(Me.RdoAllStyle)
        Me.PanelStyle.Controls.Add(Me.Label8)
        Me.PanelStyle.Location = New System.Drawing.Point(22, 112)
        Me.PanelStyle.Name = "PanelStyle"
        Me.PanelStyle.Size = New System.Drawing.Size(384, 40)
        Me.PanelStyle.TabIndex = 7
        '
        'BtnStyle
        '
        Me.BtnStyle.Enabled = False
        Me.BtnStyle.Location = New System.Drawing.Point(280, 16)
        Me.BtnStyle.Name = "BtnStyle"
        Me.BtnStyle.TabIndex = 3
        Me.BtnStyle.Text = "Choose..."
        '
        'RdoSelectedStyle
        '
        Me.RdoSelectedStyle.Location = New System.Drawing.Point(136, 16)
        Me.RdoSelectedStyle.Name = "RdoSelectedStyle"
        Me.RdoSelectedStyle.TabIndex = 1
        Me.RdoSelectedStyle.Text = "Selected Styles"
        '
        'RdoAllStyle
        '
        Me.RdoAllStyle.Checked = True
        Me.RdoAllStyle.Location = New System.Drawing.Point(0, 16)
        Me.RdoAllStyle.Name = "RdoAllStyle"
        Me.RdoAllStyle.TabIndex = 0
        Me.RdoAllStyle.TabStop = True
        Me.RdoAllStyle.Text = "All Styles"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "For Styles"
        '
        'PanelBrand
        '
        Me.PanelBrand.Controls.Add(Me.BtnBrand)
        Me.PanelBrand.Controls.Add(Me.RdoSelectedBrand)
        Me.PanelBrand.Controls.Add(Me.RdoAllBrand)
        Me.PanelBrand.Controls.Add(Me.Label6)
        Me.PanelBrand.Location = New System.Drawing.Point(22, 64)
        Me.PanelBrand.Name = "PanelBrand"
        Me.PanelBrand.Size = New System.Drawing.Size(384, 40)
        Me.PanelBrand.TabIndex = 6
        '
        'BtnBrand
        '
        Me.BtnBrand.Enabled = False
        Me.BtnBrand.Location = New System.Drawing.Point(280, 16)
        Me.BtnBrand.Name = "BtnBrand"
        Me.BtnBrand.TabIndex = 3
        Me.BtnBrand.Text = "Choose..."
        '
        'RdoSelectedBrand
        '
        Me.RdoSelectedBrand.Location = New System.Drawing.Point(136, 16)
        Me.RdoSelectedBrand.Name = "RdoSelectedBrand"
        Me.RdoSelectedBrand.Size = New System.Drawing.Size(112, 24)
        Me.RdoSelectedBrand.TabIndex = 1
        Me.RdoSelectedBrand.Text = "Selected Brands"
        '
        'RdoAllBrand
        '
        Me.RdoAllBrand.Checked = True
        Me.RdoAllBrand.Location = New System.Drawing.Point(0, 16)
        Me.RdoAllBrand.Name = "RdoAllBrand"
        Me.RdoAllBrand.TabIndex = 0
        Me.RdoAllBrand.TabStop = True
        Me.RdoAllBrand.Text = "All Brands"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "For Brands"
        '
        'PanelLine
        '
        Me.PanelLine.Controls.Add(Me.BtnLine)
        Me.PanelLine.Controls.Add(Me.RdoSelectedLine)
        Me.PanelLine.Controls.Add(Me.RdoAllLine)
        Me.PanelLine.Controls.Add(Me.Label5)
        Me.PanelLine.Location = New System.Drawing.Point(22, 16)
        Me.PanelLine.Name = "PanelLine"
        Me.PanelLine.Size = New System.Drawing.Size(384, 40)
        Me.PanelLine.TabIndex = 5
        '
        'BtnLine
        '
        Me.BtnLine.Enabled = False
        Me.BtnLine.Location = New System.Drawing.Point(280, 16)
        Me.BtnLine.Name = "BtnLine"
        Me.BtnLine.TabIndex = 2
        Me.BtnLine.Text = "Choose..."
        '
        'RdoSelectedLine
        '
        Me.RdoSelectedLine.Location = New System.Drawing.Point(136, 16)
        Me.RdoSelectedLine.Name = "RdoSelectedLine"
        Me.RdoSelectedLine.TabIndex = 1
        Me.RdoSelectedLine.Text = "Selected Lines"
        '
        'RdoAllLine
        '
        Me.RdoAllLine.Checked = True
        Me.RdoAllLine.Location = New System.Drawing.Point(0, 16)
        Me.RdoAllLine.Name = "RdoAllLine"
        Me.RdoAllLine.TabIndex = 0
        Me.RdoAllLine.TabStop = True
        Me.RdoAllLine.Text = "All Lines"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "For Lines"
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(93, 422)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.TabIndex = 3
        Me.BtnOk.Text = "OK"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(237, 422)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Cancel"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT item_no AS code, desc_item AS name FROM inv_item WHERE (cod_item_type = @t" & _
        "ype)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type", System.Data.SqlDbType.VarChar, 2, "cod_item_type"))
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=ARMANDEHserver;persis" & _
        "t security info=False;initial catalog=TireMate_03"
        '
        'DAItem
        '
        Me.DAItem.SelectCommand = Me.SqlSelectCommand1
        Me.DAItem.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("desc_item", "desc_item")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT line AS name FROM inv_tab_line"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DALine
        '
        Me.DALine.SelectCommand = Me.SqlSelectCommand2
        Me.DALine.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_line", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("line", "line")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT style AS code, desc_style AS name FROM inv_tab_style"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DAStyle
        '
        Me.DAStyle.SelectCommand = Me.SqlSelectCommand3
        Me.DAStyle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_style", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("desc_style", "desc_style")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT cod_brand AS code, complete_desc_brand AS name FROM inv_tab_brand"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'DABrand
        '
        Me.DABrand.SelectCommand = Me.SqlSelectCommand4
        Me.DABrand.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_brand", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("complete_desc_brand", "complete_desc_brand")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT cod_item_type, desc_item_type FROM inv_tab_type_item"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        '
        'DATypeItem
        '
        Me.DATypeItem.SelectCommand = Me.SqlSelectCommand5
        Me.DATypeItem.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_type_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_item_type", "cod_item_type"), New System.Data.Common.DataColumnMapping("desc_item_type", "desc_item_type")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT cod_table_public AS code, desc_table AS name FROM inv_tab_public WHERE (co" & _
        "d_main = '01')"
        Me.SqlSelectCommand6.Connection = Me.Cnn
        '
        'DASize
        '
        Me.DASize.SelectCommand = Me.SqlSelectCommand6
        Me.DASize.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_public", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_table_public", "cod_table_public"), New System.Data.Common.DataColumnMapping("desc_table", "desc_table")})})
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
        Me.Panel4.Size = New System.Drawing.Size(425, 48)
        Me.Panel4.TabIndex = 5
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
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'FrmRepItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(425, 457)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.PanelLBSS)
        Me.Controls.Add(Me.PanelTypeItem)
        Me.Controls.Add(Me.PanelDate)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmRepItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelDate.ResumeLayout(False)
        Me.PanelTypeItem.ResumeLayout(False)
        Me.PanelDetail.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.DsFrmRepItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLBSS.ResumeLayout(False)
        Me.PanelSize.ResumeLayout(False)
        Me.PanelStyle.ResumeLayout(False)
        Me.PanelBrand.ResumeLayout(False)
        Me.PanelLine.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim StrType As String = ""
    Dim StrBrand As String = ""
    Dim StrLine As String = ""
    Dim Stritem As String = ""
    Dim StrStyle As String = ""
    Dim StrSize As String = ""
    Dim StrZero As String = ""
    Dim MTypeOfForm As KindForm
    Dim ComName As String = SystemInformation.ComputerName
    Public Enum KindForm As Integer
        ILR = 1
        PPL = 2
        IVR = 3
        ISR = 4
        SMR = 5
        ICS = 6

    End Enum
    Public Property TypeOfForm() As String
        Get
            Return MTypeOfForm
        End Get
        Set(ByVal Value As String)
            MTypeOfForm = Value
        End Set
    End Property
    'Dim FlagBrand As Boolean = False
    'Dim FlagLine As Boolean = False
    'Dim FlagItem As Boolean = False
    'Dim FlagStyle As Boolean = False
    'Dim FlagSize As Boolean = False

    Private Sub FrmRepItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        DsFrmRepItem1.inv_tab_type_item.Addinv_tab_type_itemRow("", "All Types")
        DATypeItem.Fill(DsFrmRepItem1.inv_tab_type_item)
        CmbItemType.SelectedValue = "01"
        Call VisibleControl()
        Call FillFormText()


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

    Private Sub RdoAllSize_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllSize.CheckedChanged
        If RdoAllSize.Checked Then
            BtnSize.Enabled = False
        Else
            BtnSize.Enabled = True
        End If
    End Sub
    Private Sub RdoAllItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllItem.CheckedChanged
        If RdoAllItem.Checked Then
            BtnItem.Enabled = False
        Else
            BtnItem.Enabled = True
        End If
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Private Sub BtnItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnItem.Click
        If CmbItemType.Text = "" Then
            MsgBox(" First Select Item Type ")
            Exit Sub
        End If
        BtnItem.Enabled = False
        Dim f As New FrmSelect
        If DsFrmRepItem1.item.Count = 0 Then
            DsFrmRepItem1.item.Clear()
            DAItem.SelectCommand.Parameters("@type").Value = CmbItemType.SelectedValue
            DAItem.Fill(DsFrmRepItem1.item)
        End If
        f.Text = "  Select Item"
        f.DSITEM = DsFrmRepItem1
        f.TypeOfForm = FrmSelect.KindForm.Item

        f.ShowDialog()

        BtnItem.Enabled = True

    End Sub
    Private Sub BtnLine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLine.Click
        BtnLine.Enabled = False
        Dim f As New FrmSelect
        If DsFrmRepItem1.Line.Count = 0 Then
            DsFrmRepItem1.Line.Clear()
            DALine.Fill(DsFrmRepItem1.Line)
        End If
        f.Text = "  Select Line"
        f.DSITEM = DsFrmRepItem1
        f.TypeOfForm = FrmSelect.KindForm.Line
        f.ShowDialog()

        BtnLine.Enabled = True
    End Sub

    Private Sub BtnStyle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStyle.Click
        BtnStyle.Enabled = False
        If DsFrmRepItem1.Style.Count = 0 Then
            DsFrmRepItem1.Style.Clear()
            DAStyle.Fill(DsFrmRepItem1.Style)
        End If
        Dim f As New FrmSelect
        f.Text = "  Select Style"
        f.DSITEM = DsFrmRepItem1
        f.TypeOfForm = FrmSelect.KindForm.Style
        f.ShowDialog()



        BtnStyle.Enabled = True
    End Sub

    Private Sub BtnBrand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrand.Click
        BtnBrand.Enabled = False
        Dim f As New FrmSelect
        If DsFrmRepItem1.Brand.Count = 0 Then
            DsFrmRepItem1.Brand.Clear()
            DABrand.Fill(DsFrmRepItem1.Brand)
        End If
        f.TypeOfForm = FrmSelect.KindForm.Brand
        f.Text = "  Select Brand"
        f.DSITEM = DsFrmRepItem1
        f.ShowDialog()


        BtnBrand.Enabled = True

    End Sub

    Private Sub BtnSize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSize.Click
        BtnSize.Enabled = False
        Dim f As New FrmSelect
        If DsFrmRepItem1.Size.Count = 0 Then
            DsFrmRepItem1.Size.Clear()
            DASize.Fill(DsFrmRepItem1.Size)
        End If
        f.Text = "  Select Size"
        f.TypeOfForm = FrmSelect.KindForm.Size
        f.DSITEM = DsFrmRepItem1
        f.ShowDialog()



        BtnSize.Enabled = True
    End Sub

    Private Sub CmbItemType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbItemType.SelectedIndexChanged
        If CmbItemType.SelectedValue = "01" Or CmbItemType.SelectedValue = "04" Then
            PanelSize.Visible = True
        Else
            PanelSize.Visible = False
        End If
        DsFrmRepItem1.item.Clear()
    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        If RdoSummery.Checked Then
            CmbItemType.SelectedValue = ""
        End If
        If ControlSelect() Then
            Dim f As New FrmPrint
            f.StrWhere = ""
            f.StrFilter = ""
            'If CmbItemType.Text.Trim.Length > 0 Then
            If Not CmbItemType.Text = "All Types" Then
                f.StrWhere = f.StrWhere & " (" & StrType & ") and "
                f.StrFilter = f.StrFilter & "Type, "
            End If

            'End If
            If RdoSelectedItem.Checked Then
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

            If RdoSelectdSize.Checked And (CmbItemType.SelectedValue = "01" Or CmbItemType.SelectedValue = "04") Then
                f.StrWhere = f.StrWhere & " (" & StrSize & ") and "
                f.StrFilter = f.StrFilter & "size, "
            End If
            If ChkZero.Checked And (MTypeOfForm = KindForm.IVR Or MTypeOfForm = KindForm.ICS Or MTypeOfForm = KindForm.ISR Or MTypeOfForm = KindForm.SMR) Then
                f.StrWhere = f.StrWhere & " ( " & StrZero & " ) and "
            End If
            If f.StrWhere.Trim.Length > 0 Then f.StrWhere = Mid(f.StrWhere, 1, f.StrWhere.Length - 4)
            If f.StrFilter.Trim.Length > 0 Then f.StrFilter = Mid(f.StrFilter, 1, f.StrFilter.Length - 2)
            If MTypeOfForm = KindForm.IVR Then
                If RdoDetail.Checked Then
                    f.TypeForm = FrmPrint.KindForm.IVR
                    f.Text = Me.Text
                Else
                    f.TypeForm = FrmPrint.KindForm.IVRSummery
                    f.Text = Me.Text & " In Summery"
                End If
            Else
                f.TypeForm = TypeOfForm
                f.Text = Me.Text
            End If

            f.ItemType = CmbItemType.SelectedValue
            f.ItemTypeName = CmbItemType.Text

            f.ShowDialog()



            If RdoSelectedItem.Checked Then
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
            If RdoSelectdSize.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Size_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If



        End If


    End Sub
    Private Function ControlSelect() As Boolean
        ControlSelect = True

        If CmbItemType.Text.Trim.Length = 0 Then
            StrType = ""
        Else
            StrType = " inv_item.cod_item_type = " & CmbItemType.SelectedValue
        End If
        Dim i As Integer
        If RdoSelectedItem.Checked Then
            Stritem = ""
            'For i = 0 To DsFrmRepItem1.item.Count - 1
            '    If DsFrmRepItem1.item(i).flag Then
            '        Stritem = Stritem & " inv_item.item_no = " & Qt(DsFrmRepItem1.item(i).code) & " or "
            '    End If
            'Next
            'If Stritem.Trim.Length > 0 Then
            '    Stritem = Mid(Stritem, 1, Stritem.Length - 3)
            'Else
            '    ControlSelect = False
            '    MsgBox("First Select Item that you want")
            '    Exit Function
            'End If
            If DsFrmRepItem1.item.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select Item that you want")
                Exit Function
            Else

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


                For i = 0 To DsFrmRepItem1.item.Count - 1
                    If DsFrmRepItem1.item(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO Item_" & ComName & " (item_no ) VALUES (" & Qt(DsFrmRepItem1.item(i).code) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                Stritem = " inv_item.item_no  in (select item_no from Item_" & ComName & ") "
            End If
        End If
        '''''''line
        If RdoSelectedLine.Checked Then
            StrLine = ""
            'For i = 0 To DsFrmRepItem1.Line.Count - 1
            '    If DsFrmRepItem1.Line(i).flag Then
            '        StrLine = StrLine & " inv_item.line = " & Qt(DsFrmRepItem1.Line(i).name) & " or "
            '    End If
            'Next
            'If StrLine.Trim.Length > 0 Then
            '    StrLine = Mid(StrLine, 1, StrLine.Length - 3)
            'Else
            '    ControlSelect = False
            '    MsgBox("First Select Line that you want")
            '    Exit Function
            'End If
            If DsFrmRepItem1.Line.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select Line that you want")
                Exit Function
            Else

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


                For i = 0 To DsFrmRepItem1.Line.Count - 1
                    If DsFrmRepItem1.Line(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO Line_" & ComName & " (line ) VALUES (" & Qt(DsFrmRepItem1.Line(i).name) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrLine = " inv_item.line in (select line from Line_" & ComName & ") "


            End If
        End If
        '''''''''''brand
        If RdoSelectedBrand.Checked Then
            StrBrand = ""
            'For i = 0 To DsFrmRepItem1.Brand.Count - 1
            '    If DsFrmRepItem1.Brand(i).flag Then
            '        StrBrand = StrBrand & " inv_tab_line.cod_brand = " & Qt(DsFrmRepItem1.Brand(i).code) & " or "
            '    End If
            'Next
            'If StrBrand.Trim.Length > 0 Then
            '    StrBrand = Mid(StrBrand, 1, StrBrand.Length - 3)
            'Else
            '    ControlSelect = False
            '    MsgBox("First Select Brand that you want")
            '    Exit Function
            'End If
            If DsFrmRepItem1.Brand.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select Brand that you want")
                Exit Function
            Else
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


                For i = 0 To DsFrmRepItem1.Brand.Count - 1
                    If DsFrmRepItem1.Brand(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO Brand_" & ComName & " (cod_brand ) VALUES (" & Qt(DsFrmRepItem1.Brand(i).code) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrBrand = " inv_tab_line.cod_brand in (select cod_brand from Brand_" & ComName & ") "

            End If
        End If
        '''''''''''''''style
        If RdoSelectedStyle.Checked Then
            StrStyle = ""
            'For i = 0 To DsFrmRepItem1.Style.Count - 1
            '    If DsFrmRepItem1.Style(i).flag Then
            '        StrStyle = StrStyle & " inv_tab_line.style = " & Qt(DsFrmRepItem1.Style(i).code) & " or "
            '    End If
            'Next
            'If StrStyle.Trim.Length > 0 Then
            '    StrStyle = Mid(StrStyle, 1, StrStyle.Length - 3)
            'Else
            '    ControlSelect = False
            '    MsgBox("First Select Style that you want")
            '    Exit Function
            'End If
            If DsFrmRepItem1.Style.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select Style that you want")
                Exit Function
            Else
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


                For i = 0 To DsFrmRepItem1.Style.Count - 1
                    If DsFrmRepItem1.Style(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO Style_" & ComName & " (style ) VALUES (" & Qt(DsFrmRepItem1.Style(i).code) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrStyle = " inv_tab_line.style in (select style from Style_" & ComName & ") "

            End If
        End If
        If RdoSelectdSize.Checked And (CmbItemType.SelectedValue = "01" Or CmbItemType.SelectedValue = "04") Then
            'StrSize = ""
            'For i = 0 To DsFrmRepItem1.Size.Count - 1
            '    If DsFrmRepItem1.Size(i).flag Then
            '        StrSize = StrSize & " inv_tab_public.cod_table_public = " & Qt(DsFrmRepItem1.Size(i).code) & " or "
            '    End If
            'Next
            'If StrSize.Trim.Length > 0 Then
            '    StrSize = Mid(StrSize, 1, StrSize.Length - 3)
            'Else
            '    ControlSelect = False
            '    MsgBox("First Select Size that you want")
            '    Exit Function
            'End If

            If DsFrmRepItem1.Size.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select Size that you want")
                Exit Function

            Else

                Try
                    CmdGeneral.CommandText = " create table Size_" & ComName & "(cod_table_public char(3))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Size_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DsFrmRepItem1.Size.Count - 1
                    If DsFrmRepItem1.Size(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO Size_" & ComName & " (cod_table_public ) VALUES (" & Qt(DsFrmRepItem1.Size(i).code) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrSize = " inv_tab_public.cod_table_public in (select cod_table_public from Size_" & ComName & ") "

            End If
            'If DsFrmRepItem1.Size.Select(" flag = 1 ").Length > 0 Then
            '    StrSize = " inv_tab_public.cod_table_public IN ("
            '    For i = 0 To DsFrmRepItem1.Size.Count - 1
            '        If DsFrmRepItem1.Size(i).flag Then
            '            StrSize = StrSize & Qt(DsFrmRepItem1.Size(i).code) & " , "
            '        End If
            '    Next
            '    StrSize = Mid(StrSize, 1, StrSize.Length - 2)
            '    StrSize = StrSize & " ) "
            'Else
            '    ControlSelect = False
            '    MsgBox("First Select Size that you want")
            '    Exit Function
            'End If
        End If


        If ChkZero.Checked Then
            StrZero = " V_Location.on_hand > 0 "

        End If
    End Function
    Private Sub VisibleControl()
        PanelDate.Visible = False
        If MTypeOfForm = KindForm.IVR Or MTypeOfForm = KindForm.ICS Or MTypeOfForm = KindForm.ISR Or MTypeOfForm = KindForm.SMR Then
        Else
            ChkZero.Visible = False
        End If
        If MTypeOfForm = KindForm.ICS Then
            ChkZero.Checked = True
        End If
        If MTypeOfForm = KindForm.IVR Then
            PanelDetail.Visible = True
        End If
    End Sub
    Private Sub FillFormText()
        Select Case TypeOfForm
            Case 1
                Me.Text = "Inventory Listing Report"
            Case 2
                Me.Text = "Product Price List"
            Case 3
                Me.Text = "Inventory Valuation Report"
            Case 4
                Me.Text = "Inventory Status Report"
            Case 5
                Me.Text = "Slow Moving Report"
            Case 6
                Me.Text = "Inventory Count Sheet"
        End Select
    End Sub

    Private Sub RdoSummery_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoSummery.CheckedChanged
        If RdoSummery.Checked Then
            CmbItemType.SelectedValue = ""
        Else
            CmbItemType.SelectedValue = "01"
        End If
    End Sub
End Class
