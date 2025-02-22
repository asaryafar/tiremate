Imports CommonClass
Public Class FrmRepCusSale
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelDate As System.Windows.Forms.GroupBox
    Friend WithEvents CalendarCombo2 As CalendarCombo.CalendarCombo
    Friend WithEvents CalendarCombo1 As CalendarCombo.CalendarCombo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents RdoDetail As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSummery As System.Windows.Forms.RadioButton
    Friend WithEvents ChkDate As System.Windows.Forms.CheckBox
    Friend WithEvents PanelInnerDate As System.Windows.Forms.Panel
    Friend WithEvents RdoChargeCus As System.Windows.Forms.RadioButton
    Friend WithEvents RdoCashCus As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSelectedCus As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllCus As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSelectdTerritori As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllTerritori As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSelectedClass As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllClass As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSelectedSource As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllSource As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSelectedType As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllType As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSelectedSaler As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllSaler As System.Windows.Forms.RadioButton
    Friend WithEvents BtnCus As System.Windows.Forms.Button
    Friend WithEvents BtnTerr As System.Windows.Forms.Button
    Friend WithEvents BtnClass As System.Windows.Forms.Button
    Friend WithEvents BtnSource As System.Windows.Forms.Button
    Friend WithEvents BtnType As System.Windows.Forms.Button
    Friend WithEvents BtnSale As System.Windows.Forms.Button
    Friend WithEvents PanelTypeCus As System.Windows.Forms.GroupBox
    Friend WithEvents PanelDetail As System.Windows.Forms.Panel
    Friend WithEvents PanelCus As System.Windows.Forms.Panel
    Friend WithEvents PanelTSCT As System.Windows.Forms.GroupBox
    Friend WithEvents PanelTerr As System.Windows.Forms.Panel
    Friend WithEvents PanelClass As System.Windows.Forms.Panel
    Friend WithEvents PanelSource As System.Windows.Forms.Panel
    Friend WithEvents PanelType As System.Windows.Forms.Panel
    Friend WithEvents PanelSale As System.Windows.Forms.GroupBox
    Friend WithEvents PanelSaler As System.Windows.Forms.Panel
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DACustomer As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAType As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DASource As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAClass As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DATerr As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAEmployee As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAService_Center_Head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmRepCusSale2 As ReportCustomer.DSFrmRepCusSale
    Friend WithEvents RdoTaxCus As System.Windows.Forms.RadioButton
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmRepCusSale))
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PanelDate = New System.Windows.Forms.GroupBox
        Me.PanelInnerDate = New System.Windows.Forms.Panel
        Me.CalendarCombo1 = New CalendarCombo.CalendarCombo
        Me.CalendarCombo2 = New CalendarCombo.CalendarCombo
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ChkDate = New System.Windows.Forms.CheckBox
        Me.PanelTypeCus = New System.Windows.Forms.GroupBox
        Me.PanelDetail = New System.Windows.Forms.Panel
        Me.RdoSummery = New System.Windows.Forms.RadioButton
        Me.RdoDetail = New System.Windows.Forms.RadioButton
        Me.PanelCus = New System.Windows.Forms.Panel
        Me.RdoTaxCus = New System.Windows.Forms.RadioButton
        Me.BtnCus = New System.Windows.Forms.Button
        Me.RdoSelectedCus = New System.Windows.Forms.RadioButton
        Me.RdoAllCus = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.RdoChargeCus = New System.Windows.Forms.RadioButton
        Me.RdoCashCus = New System.Windows.Forms.RadioButton
        Me.PanelTSCT = New System.Windows.Forms.GroupBox
        Me.PanelTerr = New System.Windows.Forms.Panel
        Me.BtnTerr = New System.Windows.Forms.Button
        Me.RdoSelectdTerritori = New System.Windows.Forms.RadioButton
        Me.RdoAllTerritori = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.PanelClass = New System.Windows.Forms.Panel
        Me.BtnClass = New System.Windows.Forms.Button
        Me.RdoSelectedClass = New System.Windows.Forms.RadioButton
        Me.RdoAllClass = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.PanelSource = New System.Windows.Forms.Panel
        Me.BtnSource = New System.Windows.Forms.Button
        Me.RdoSelectedSource = New System.Windows.Forms.RadioButton
        Me.RdoAllSource = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.PanelType = New System.Windows.Forms.Panel
        Me.BtnType = New System.Windows.Forms.Button
        Me.RdoSelectedType = New System.Windows.Forms.RadioButton
        Me.RdoAllType = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.BtnOk = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.PanelSale = New System.Windows.Forms.GroupBox
        Me.PanelSaler = New System.Windows.Forms.Panel
        Me.BtnSale = New System.Windows.Forms.Button
        Me.RdoSelectedSaler = New System.Windows.Forms.RadioButton
        Me.RdoAllSaler = New System.Windows.Forms.RadioButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DACustomer = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAType = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DASource = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DAClass = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DATerr = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.DAEmployee = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAService_Center_Head = New System.Data.SqlClient.SqlDataAdapter
        Me.DsFrmRepCusSale2 = New ReportCustomer.DSFrmRepCusSale
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.Panel4.SuspendLayout()
        Me.PanelDate.SuspendLayout()
        Me.PanelInnerDate.SuspendLayout()
        Me.PanelTypeCus.SuspendLayout()
        Me.PanelDetail.SuspendLayout()
        Me.PanelCus.SuspendLayout()
        Me.PanelTSCT.SuspendLayout()
        Me.PanelTerr.SuspendLayout()
        Me.PanelClass.SuspendLayout()
        Me.PanelSource.SuspendLayout()
        Me.PanelType.SuspendLayout()
        Me.PanelSale.SuspendLayout()
        Me.PanelSaler.SuspendLayout()
        CType(Me.DsFrmRepCusSale2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel4.Size = New System.Drawing.Size(502, 48)
        Me.Panel4.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Location = New System.Drawing.Point(64, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(262, 46)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Select the Customer That you want to print"
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
        'PanelDate
        '
        Me.PanelDate.Controls.Add(Me.PanelInnerDate)
        Me.PanelDate.Controls.Add(Me.ChkDate)
        Me.PanelDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDate.Location = New System.Drawing.Point(0, 48)
        Me.PanelDate.Name = "PanelDate"
        Me.PanelDate.Size = New System.Drawing.Size(502, 48)
        Me.PanelDate.TabIndex = 7
        Me.PanelDate.TabStop = False
        '
        'PanelInnerDate
        '
        Me.PanelInnerDate.Controls.Add(Me.CalendarCombo1)
        Me.PanelInnerDate.Controls.Add(Me.CalendarCombo2)
        Me.PanelInnerDate.Controls.Add(Me.Label2)
        Me.PanelInnerDate.Controls.Add(Me.Label3)
        Me.PanelInnerDate.Location = New System.Drawing.Point(152, 16)
        Me.PanelInnerDate.Name = "PanelInnerDate"
        Me.PanelInnerDate.Size = New System.Drawing.Size(320, 24)
        Me.PanelInnerDate.TabIndex = 6
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
        Me.ChkDate.Location = New System.Drawing.Point(40, 16)
        Me.ChkDate.Name = "ChkDate"
        Me.ChkDate.TabIndex = 5
        Me.ChkDate.Text = "All Date"
        '
        'PanelTypeCus
        '
        Me.PanelTypeCus.Controls.Add(Me.PanelDetail)
        Me.PanelTypeCus.Controls.Add(Me.PanelCus)
        Me.PanelTypeCus.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTypeCus.Location = New System.Drawing.Point(0, 96)
        Me.PanelTypeCus.Name = "PanelTypeCus"
        Me.PanelTypeCus.Size = New System.Drawing.Size(502, 112)
        Me.PanelTypeCus.TabIndex = 8
        Me.PanelTypeCus.TabStop = False
        '
        'PanelDetail
        '
        Me.PanelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDetail.Controls.Add(Me.RdoSummery)
        Me.PanelDetail.Controls.Add(Me.RdoDetail)
        Me.PanelDetail.Location = New System.Drawing.Point(408, 16)
        Me.PanelDetail.Name = "PanelDetail"
        Me.PanelDetail.Size = New System.Drawing.Size(80, 64)
        Me.PanelDetail.TabIndex = 8
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
        'PanelCus
        '
        Me.PanelCus.Controls.Add(Me.RdoTaxCus)
        Me.PanelCus.Controls.Add(Me.BtnCus)
        Me.PanelCus.Controls.Add(Me.RdoSelectedCus)
        Me.PanelCus.Controls.Add(Me.RdoAllCus)
        Me.PanelCus.Controls.Add(Me.Label4)
        Me.PanelCus.Controls.Add(Me.RdoChargeCus)
        Me.PanelCus.Controls.Add(Me.RdoCashCus)
        Me.PanelCus.Location = New System.Drawing.Point(22, 16)
        Me.PanelCus.Name = "PanelCus"
        Me.PanelCus.Size = New System.Drawing.Size(376, 88)
        Me.PanelCus.TabIndex = 6
        '
        'RdoTaxCus
        '
        Me.RdoTaxCus.Location = New System.Drawing.Point(0, 64)
        Me.RdoTaxCus.Name = "RdoTaxCus"
        Me.RdoTaxCus.Size = New System.Drawing.Size(168, 24)
        Me.RdoTaxCus.TabIndex = 4
        Me.RdoTaxCus.Text = "Non-Taxable Customers"
        '
        'BtnCus
        '
        Me.BtnCus.Enabled = False
        Me.BtnCus.Location = New System.Drawing.Point(264, 24)
        Me.BtnCus.Name = "BtnCus"
        Me.BtnCus.TabIndex = 3
        Me.BtnCus.Text = "Choose..."
        '
        'RdoSelectedCus
        '
        Me.RdoSelectedCus.Location = New System.Drawing.Point(128, 16)
        Me.RdoSelectedCus.Name = "RdoSelectedCus"
        Me.RdoSelectedCus.Size = New System.Drawing.Size(128, 24)
        Me.RdoSelectedCus.TabIndex = 1
        Me.RdoSelectedCus.Text = "Selected Customers"
        '
        'RdoAllCus
        '
        Me.RdoAllCus.Checked = True
        Me.RdoAllCus.Location = New System.Drawing.Point(0, 16)
        Me.RdoAllCus.Name = "RdoAllCus"
        Me.RdoAllCus.TabIndex = 0
        Me.RdoAllCus.TabStop = True
        Me.RdoAllCus.Text = "All Customers"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(16, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "For Customer"
        '
        'RdoChargeCus
        '
        Me.RdoChargeCus.Location = New System.Drawing.Point(128, 40)
        Me.RdoChargeCus.Name = "RdoChargeCus"
        Me.RdoChargeCus.Size = New System.Drawing.Size(120, 24)
        Me.RdoChargeCus.TabIndex = 1
        Me.RdoChargeCus.Text = "Charge Customers"
        '
        'RdoCashCus
        '
        Me.RdoCashCus.Location = New System.Drawing.Point(0, 40)
        Me.RdoCashCus.Name = "RdoCashCus"
        Me.RdoCashCus.Size = New System.Drawing.Size(112, 24)
        Me.RdoCashCus.TabIndex = 0
        Me.RdoCashCus.Text = "Cash Customers"
        '
        'PanelTSCT
        '
        Me.PanelTSCT.Controls.Add(Me.PanelTerr)
        Me.PanelTSCT.Controls.Add(Me.PanelClass)
        Me.PanelTSCT.Controls.Add(Me.PanelSource)
        Me.PanelTSCT.Controls.Add(Me.PanelType)
        Me.PanelTSCT.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTSCT.Location = New System.Drawing.Point(0, 208)
        Me.PanelTSCT.Name = "PanelTSCT"
        Me.PanelTSCT.Size = New System.Drawing.Size(502, 216)
        Me.PanelTSCT.TabIndex = 9
        Me.PanelTSCT.TabStop = False
        '
        'PanelTerr
        '
        Me.PanelTerr.Controls.Add(Me.BtnTerr)
        Me.PanelTerr.Controls.Add(Me.RdoSelectdTerritori)
        Me.PanelTerr.Controls.Add(Me.RdoAllTerritori)
        Me.PanelTerr.Controls.Add(Me.Label7)
        Me.PanelTerr.Location = New System.Drawing.Point(22, 160)
        Me.PanelTerr.Name = "PanelTerr"
        Me.PanelTerr.Size = New System.Drawing.Size(384, 48)
        Me.PanelTerr.TabIndex = 8
        '
        'BtnTerr
        '
        Me.BtnTerr.Enabled = False
        Me.BtnTerr.Location = New System.Drawing.Point(280, 16)
        Me.BtnTerr.Name = "BtnTerr"
        Me.BtnTerr.TabIndex = 3
        Me.BtnTerr.Text = "Choose..."
        '
        'RdoSelectdTerritori
        '
        Me.RdoSelectdTerritori.Location = New System.Drawing.Point(128, 16)
        Me.RdoSelectdTerritori.Name = "RdoSelectdTerritori"
        Me.RdoSelectdTerritori.Size = New System.Drawing.Size(120, 24)
        Me.RdoSelectdTerritori.TabIndex = 1
        Me.RdoSelectdTerritori.Text = "Selected Territories"
        '
        'RdoAllTerritori
        '
        Me.RdoAllTerritori.Checked = True
        Me.RdoAllTerritori.Location = New System.Drawing.Point(0, 16)
        Me.RdoAllTerritori.Name = "RdoAllTerritori"
        Me.RdoAllTerritori.TabIndex = 0
        Me.RdoAllTerritori.TabStop = True
        Me.RdoAllTerritori.Text = "All Territories"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "For Customer Territories"
        '
        'PanelClass
        '
        Me.PanelClass.Controls.Add(Me.BtnClass)
        Me.PanelClass.Controls.Add(Me.RdoSelectedClass)
        Me.PanelClass.Controls.Add(Me.RdoAllClass)
        Me.PanelClass.Controls.Add(Me.Label8)
        Me.PanelClass.Location = New System.Drawing.Point(22, 112)
        Me.PanelClass.Name = "PanelClass"
        Me.PanelClass.Size = New System.Drawing.Size(384, 40)
        Me.PanelClass.TabIndex = 7
        '
        'BtnClass
        '
        Me.BtnClass.Enabled = False
        Me.BtnClass.Location = New System.Drawing.Point(280, 16)
        Me.BtnClass.Name = "BtnClass"
        Me.BtnClass.TabIndex = 3
        Me.BtnClass.Text = "Choose..."
        '
        'RdoSelectedClass
        '
        Me.RdoSelectedClass.Location = New System.Drawing.Point(128, 16)
        Me.RdoSelectedClass.Name = "RdoSelectedClass"
        Me.RdoSelectedClass.Size = New System.Drawing.Size(112, 24)
        Me.RdoSelectedClass.TabIndex = 1
        Me.RdoSelectedClass.Text = "Selected Classes"
        '
        'RdoAllClass
        '
        Me.RdoAllClass.Checked = True
        Me.RdoAllClass.Location = New System.Drawing.Point(0, 16)
        Me.RdoAllClass.Name = "RdoAllClass"
        Me.RdoAllClass.TabIndex = 0
        Me.RdoAllClass.TabStop = True
        Me.RdoAllClass.Text = "All Classes"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "For Customer Classes"
        '
        'PanelSource
        '
        Me.PanelSource.Controls.Add(Me.BtnSource)
        Me.PanelSource.Controls.Add(Me.RdoSelectedSource)
        Me.PanelSource.Controls.Add(Me.RdoAllSource)
        Me.PanelSource.Controls.Add(Me.Label6)
        Me.PanelSource.Location = New System.Drawing.Point(22, 64)
        Me.PanelSource.Name = "PanelSource"
        Me.PanelSource.Size = New System.Drawing.Size(384, 40)
        Me.PanelSource.TabIndex = 6
        '
        'BtnSource
        '
        Me.BtnSource.Enabled = False
        Me.BtnSource.Location = New System.Drawing.Point(280, 16)
        Me.BtnSource.Name = "BtnSource"
        Me.BtnSource.TabIndex = 3
        Me.BtnSource.Text = "Choose..."
        '
        'RdoSelectedSource
        '
        Me.RdoSelectedSource.Location = New System.Drawing.Point(128, 16)
        Me.RdoSelectedSource.Name = "RdoSelectedSource"
        Me.RdoSelectedSource.Size = New System.Drawing.Size(112, 24)
        Me.RdoSelectedSource.TabIndex = 1
        Me.RdoSelectedSource.Text = "Selected Sources"
        '
        'RdoAllSource
        '
        Me.RdoAllSource.Checked = True
        Me.RdoAllSource.Location = New System.Drawing.Point(0, 16)
        Me.RdoAllSource.Name = "RdoAllSource"
        Me.RdoAllSource.TabIndex = 0
        Me.RdoAllSource.TabStop = True
        Me.RdoAllSource.Text = "All Sources"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "For Customer Sources"
        '
        'PanelType
        '
        Me.PanelType.Controls.Add(Me.BtnType)
        Me.PanelType.Controls.Add(Me.RdoSelectedType)
        Me.PanelType.Controls.Add(Me.RdoAllType)
        Me.PanelType.Controls.Add(Me.Label5)
        Me.PanelType.Location = New System.Drawing.Point(22, 16)
        Me.PanelType.Name = "PanelType"
        Me.PanelType.Size = New System.Drawing.Size(384, 40)
        Me.PanelType.TabIndex = 5
        '
        'BtnType
        '
        Me.BtnType.Enabled = False
        Me.BtnType.Location = New System.Drawing.Point(280, 16)
        Me.BtnType.Name = "BtnType"
        Me.BtnType.TabIndex = 2
        Me.BtnType.Text = "Choose..."
        '
        'RdoSelectedType
        '
        Me.RdoSelectedType.Location = New System.Drawing.Point(128, 16)
        Me.RdoSelectedType.Name = "RdoSelectedType"
        Me.RdoSelectedType.TabIndex = 1
        Me.RdoSelectedType.Text = "Selected Types"
        '
        'RdoAllType
        '
        Me.RdoAllType.Checked = True
        Me.RdoAllType.Location = New System.Drawing.Point(0, 16)
        Me.RdoAllType.Name = "RdoAllType"
        Me.RdoAllType.TabIndex = 0
        Me.RdoAllType.TabStop = True
        Me.RdoAllType.Text = "All Types"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "For Customer Types"
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(96, 496)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.TabIndex = 9
        Me.BtnOk.Text = "OK"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(248, 496)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.TabIndex = 10
        Me.BtnCancel.Text = "Cancel"
        '
        'PanelSale
        '
        Me.PanelSale.Controls.Add(Me.PanelSaler)
        Me.PanelSale.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSale.Location = New System.Drawing.Point(0, 424)
        Me.PanelSale.Name = "PanelSale"
        Me.PanelSale.Size = New System.Drawing.Size(502, 72)
        Me.PanelSale.TabIndex = 11
        Me.PanelSale.TabStop = False
        '
        'PanelSaler
        '
        Me.PanelSaler.Controls.Add(Me.BtnSale)
        Me.PanelSaler.Controls.Add(Me.RdoSelectedSaler)
        Me.PanelSaler.Controls.Add(Me.RdoAllSaler)
        Me.PanelSaler.Controls.Add(Me.Label9)
        Me.PanelSaler.Location = New System.Drawing.Point(22, 16)
        Me.PanelSaler.Name = "PanelSaler"
        Me.PanelSaler.Size = New System.Drawing.Size(376, 40)
        Me.PanelSaler.TabIndex = 6
        '
        'BtnSale
        '
        Me.BtnSale.Enabled = False
        Me.BtnSale.Location = New System.Drawing.Point(280, 16)
        Me.BtnSale.Name = "BtnSale"
        Me.BtnSale.TabIndex = 3
        Me.BtnSale.Text = "Choose..."
        '
        'RdoSelectedSaler
        '
        Me.RdoSelectedSaler.Location = New System.Drawing.Point(128, 16)
        Me.RdoSelectedSaler.Name = "RdoSelectedSaler"
        Me.RdoSelectedSaler.Size = New System.Drawing.Size(144, 24)
        Me.RdoSelectedSaler.TabIndex = 1
        Me.RdoSelectedSaler.Text = "Selected Salespersons"
        '
        'RdoAllSaler
        '
        Me.RdoAllSaler.Checked = True
        Me.RdoAllSaler.Location = New System.Drawing.Point(0, 16)
        Me.RdoAllSaler.Name = "RdoAllSaler"
        Me.RdoAllSaler.Size = New System.Drawing.Size(112, 24)
        Me.RdoAllSaler.TabIndex = 0
        Me.RdoAllSaler.TabStop = True
        Me.RdoAllSaler.Text = "All Salespersons"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(16, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "For Salespersons"
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=MILAD;packet size=4096;integrated security=SSPI;data source=milad;" & _
        "persist security info=False;initial catalog=TireMate_01_db"
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cust_trtab_main.cod_customer AS cod, cust_trtab_main.f_name, cust_trtab_ma" & _
        "in.l_name, cust_company.complete_name, 0 AS flag FROM cust_trtab_main LEFT OUTER" & _
        " JOIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_company"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DACustomer
        '
        Me.DACustomer.SelectCommand = Me.SqlSelectCommand2
        Me.DACustomer.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_trtab_main", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("vip_code", "vip_code"), New System.Data.Common.DataColumnMapping("cod_company", "cod_company"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("driver_name1", "driver_name1"), New System.Data.Common.DataColumnMapping("driver_name2", "driver_name2"), New System.Data.Common.DataColumnMapping("driver_name3", "driver_name3"), New System.Data.Common.DataColumnMapping("driver_name4", "driver_name4"), New System.Data.Common.DataColumnMapping("DriverLicense", "DriverLicense"), New System.Data.Common.DataColumnMapping("zip", "zip"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("cod_sales_rep", "cod_sales_rep"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cust_exempt_tax", "cust_exempt_tax"), New System.Data.Common.DataColumnMapping("scrap_check", "scrap_check"), New System.Data.Common.DataColumnMapping("scrap_value", "scrap_value"), New System.Data.Common.DataColumnMapping("credit_card_no", "credit_card_no"), New System.Data.Common.DataColumnMapping("expiration_credit_date", "expiration_credit_date"), New System.Data.Common.DataColumnMapping("credit_limited", "credit_limited"), New System.Data.Common.DataColumnMapping("AR_charge", "AR_charge"), New System.Data.Common.DataColumnMapping("AR_term", "AR_term"), New System.Data.Common.DataColumnMapping("cod_sales_tax", "cod_sales_tax"), New System.Data.Common.DataColumnMapping("cod_price", "cod_price"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("cod_type", "cod_type"), New System.Data.Common.DataColumnMapping("cod_source", "cod_source"), New System.Data.Common.DataColumnMapping("cod_class", "cod_class"), New System.Data.Common.DataColumnMapping("cod_territory", "cod_territory"), New System.Data.Common.DataColumnMapping("desc_sales_report", "desc_sales_report"), New System.Data.Common.DataColumnMapping("user_id", "user_id"), New System.Data.Common.DataColumnMapping("user_password", "user_password"), New System.Data.Common.DataColumnMapping("AR_statement", "AR_statement"), New System.Data.Common.DataColumnMapping("AR_send_copy", "AR_send_copy"), New System.Data.Common.DataColumnMapping("AR_finance_charge", "AR_finance_charge"), New System.Data.Common.DataColumnMapping("AR_require_PO", "AR_require_PO"), New System.Data.Common.DataColumnMapping("AR_credit_hold", "AR_credit_hold"), New System.Data.Common.DataColumnMapping("AR_accept_check", "AR_accept_check"), New System.Data.Common.DataColumnMapping("cust_notes", "cust_notes"), New System.Data.Common.DataColumnMapping("Taxable", "Taxable"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("customer_no", "customer_no")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT cod_type AS cod, desc_type AS description, 0 AS flag FROM cust_tab_type"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DAType
        '
        Me.DAType.SelectCommand = Me.SqlSelectCommand3
        Me.DAType.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_tab_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_type", "cod_type"), New System.Data.Common.DataColumnMapping("desc_type", "desc_type")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT cod_source AS cod, desc_source AS description, 0 AS flag FROM cust_tab_sou" & _
        "rce"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'DASource
        '
        Me.DASource.SelectCommand = Me.SqlSelectCommand4
        Me.DASource.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_tab_source", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_source", "cod_source"), New System.Data.Common.DataColumnMapping("desc_source", "desc_source")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT cod_class AS cod, desc_class AS description, 0 AS flag FROM cust_tab_class" & _
        ""
        Me.SqlSelectCommand5.Connection = Me.Cnn
        '
        'DAClass
        '
        Me.DAClass.SelectCommand = Me.SqlSelectCommand5
        Me.DAClass.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_tab_class", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_class", "cod_class"), New System.Data.Common.DataColumnMapping("desc_class", "desc_class")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT cod_territory AS cod, desc_territory AS description, 0 AS flag FROM cust_t" & _
        "ab_territory"
        Me.SqlSelectCommand6.Connection = Me.Cnn
        '
        'DATerr
        '
        Me.DATerr.SelectCommand = Me.SqlSelectCommand6
        Me.DATerr.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_tab_territory", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_territory", "cod_territory"), New System.Data.Common.DataColumnMapping("desc_territory", "desc_territory")})})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT employee_code AS cod, f_name, l_name, 0 AS flag FROM employee"
        Me.SqlSelectCommand7.Connection = Me.Cnn
        '
        'DAEmployee
        '
        Me.DAEmployee.SelectCommand = Me.SqlSelectCommand7
        Me.DAEmployee.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "employee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("technecian", "technecian"), New System.Data.Common.DataColumnMapping("SalesPerson", "SalesPerson"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cod_position", "cod_position"), New System.Data.Common.DataColumnMapping("cod_deparment", "cod_deparment"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("pic", "pic"), New System.Data.Common.DataColumnMapping("birthday_date", "birthday_date"), New System.Data.Common.DataColumnMapping("hired_date", "hired_date"), New System.Data.Common.DataColumnMapping("last_reiew_date", "last_reiew_date"), New System.Data.Common.DataColumnMapping("terminate_date", "terminate_date"), New System.Data.Common.DataColumnMapping("temporary_inactive", "temporary_inactive"), New System.Data.Common.DataColumnMapping("last_basis", "last_basis"), New System.Data.Common.DataColumnMapping("last_period", "last_period"), New System.Data.Common.DataColumnMapping("last_status", "last_status"), New System.Data.Common.DataColumnMapping("last_salary", "last_salary"), New System.Data.Common.DataColumnMapping("last_hourly", "last_hourly"), New System.Data.Common.DataColumnMapping("last_overtime", "last_overtime"), New System.Data.Common.DataColumnMapping("Last_raise_date", "Last_raise_date"), New System.Data.Common.DataColumnMapping("Allowance_Federal", "Allowance_Federal"), New System.Data.Common.DataColumnMapping("Allowance_state", "Allowance_state"), New System.Data.Common.DataColumnMapping("Allowance_depndnts", "Allowance_depndnts"), New System.Data.Common.DataColumnMapping("Terminated", "Terminated")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cust_trtab_main.cod_customer, cust_trtab_main.cod_type, cust_trtab_main.co" & _
        "d_source, cust_trtab_main.cod_class, cust_trtab_main.cod_territory, cust_trtab_m" & _
        "ain.cod_sales_rep FROM cust_trtab_main INNER JOIN cust_tab_class ON cust_trtab_m" & _
        "ain.cod_class = cust_tab_class.cod_class INNER JOIN cust_tab_source ON cust_trta" & _
        "b_main.cod_source = cust_tab_source.cod_source INNER JOIN cust_tab_territory ON " & _
        "cust_trtab_main.cod_territory = cust_tab_territory.cod_territory INNER JOIN cust" & _
        "_tab_type ON cust_trtab_main.cod_type = cust_tab_type.cod_type LEFT OUTER JOIN e" & _
        "mployee ON cust_trtab_main.cod_sales_rep = employee.employee_code"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAService_Center_Head
        '
        Me.DAService_Center_Head.SelectCommand = Me.SqlSelectCommand1
        Me.DAService_Center_Head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Total", "Total")})})
        '
        'DsFrmRepCusSale2
        '
        Me.DsFrmRepCusSale2.DataSetName = "DSFrmRepCusSale"
        Me.DsFrmRepCusSale2.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'FrmRepCusSale
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(502, 532)
        Me.Controls.Add(Me.PanelSale)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.PanelTSCT)
        Me.Controls.Add(Me.PanelTypeCus)
        Me.Controls.Add(Me.PanelDate)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.BtnOk)
        Me.Name = "FrmRepCusSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Sales Report"
        Me.Panel4.ResumeLayout(False)
        Me.PanelDate.ResumeLayout(False)
        Me.PanelInnerDate.ResumeLayout(False)
        Me.PanelTypeCus.ResumeLayout(False)
        Me.PanelDetail.ResumeLayout(False)
        Me.PanelCus.ResumeLayout(False)
        Me.PanelTSCT.ResumeLayout(False)
        Me.PanelTerr.ResumeLayout(False)
        Me.PanelClass.ResumeLayout(False)
        Me.PanelSource.ResumeLayout(False)
        Me.PanelType.ResumeLayout(False)
        Me.PanelSale.ResumeLayout(False)
        Me.PanelSaler.ResumeLayout(False)
        CType(Me.DsFrmRepCusSale2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Enum KindReport As Integer
        'customerSaleDetail = 1
        customerSale = 1
        CustomerListing = 2
    End Enum
    Dim MKindOfReport As KindReport
    Dim StrCustomer As String = ""
    Dim StrCash As String = ""
    Dim StrType As String = ""
    Dim StrSource As String = ""
    Dim StrClass As String = ""
    Dim StrTerr As String = ""
    Dim StrEmp As String = ""
    Dim StrDate As String = ""
    Dim ComName As String = SystemInformation.ComputerName
    Public Property KindOfReport() As String
        Get
            Return MKindOfReport
        End Get
        Set(ByVal Value As String)
            MKindOfReport = Value
        End Set
    End Property
    Private Sub FrmRepCusSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        CalendarCombo1.Text = "01/01/" & PSalMali
        CalendarCombo2.Text = "12/28/" & PSalMali
        Call FillTextForm()
        Call VisibleControl()
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()

    End Sub

    Private Sub ChkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDate.CheckedChanged
        If ChkDate.Checked Then
            PanelInnerDate.Enabled = False
        Else
            PanelInnerDate.Enabled = True
        End If
    End Sub

    Private Sub RdoAllCus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllCus.CheckedChanged, RdoCashCus.CheckedChanged, RdoChargeCus.CheckedChanged, RdoSelectedCus.CheckedChanged, RdoTaxCus.CheckedChanged
        If RdoAllCus.Checked Then
            BtnCus.Enabled = False
        Else
            BtnCus.Enabled = True
        End If
        DsFrmRepCusSale2.customer.Clear()
        'Call BtnCus_Click(sender, e)
    End Sub


    Private Sub RdoAllType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllType.CheckedChanged
        If RdoAllType.Checked Then
            BtnType.Enabled = False
        Else
            BtnType.Enabled = True
        End If

    End Sub

    Private Sub RdoAllSource_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllSource.CheckedChanged
        If RdoAllSource.Checked Then
            BtnSource.Enabled = False
        Else
            BtnSource.Enabled = True
        End If
    End Sub

    Private Sub RdoAllClass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllClass.CheckedChanged
        If RdoAllClass.Checked Then
            BtnClass.Enabled = False
        Else
            BtnClass.Enabled = True
        End If
    End Sub

    Private Sub RdoAllTerritori_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllTerritori.CheckedChanged
        If RdoAllTerritori.Checked Then
            BtnTerr.Enabled = False
        Else
            BtnTerr.Enabled = True
        End If
    End Sub

    Private Sub RdoAllSaler_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllSaler.CheckedChanged
        If RdoAllSaler.Checked Then
            BtnSale.Enabled = False
        Else
            BtnSale.Enabled = True
        End If
    End Sub


    Private Sub BtnCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCus.Click
        BtnCus.Enabled = False
        Dim f As New FrmSelect
        If DsFrmRepCusSale2.customer.Count = 0 Then
            If RdoCashCus.Checked Then
                DACustomer.SelectCommand.CommandText = " SELECT cust_trtab_main.cod_customer AS cod, cust_trtab_main.f_name, cust_trtab_main.l_name, cust_company.complete_name, 0 AS flag FROM cust_trtab_main LEFT OUTER JOIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_company  where cust_trtab_main.AR_charge ='0'"
            Else
                If RdoChargeCus.Checked Then
                    DACustomer.SelectCommand.CommandText = "SELECT cust_trtab_main.cod_customer AS cod, cust_trtab_main.f_name, cust_trtab_main.l_name, cust_company.complete_name, 0 AS flag FROM cust_trtab_main LEFT OUTER JOIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_company where cust_trtab_main.AR_charge ='1'"
                Else
                    If RdoTaxCus.Checked Then
                        DACustomer.SelectCommand.CommandText = " SELECT cust_trtab_main.cod_customer AS cod, cust_trtab_main.f_name, cust_trtab_main.l_name, cust_company.complete_name, 0 AS flag FROM cust_trtab_main LEFT OUTER JOIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_company  where cust_trtab_main.Taxable ='0'"
                    Else
                        DACustomer.SelectCommand.CommandText = "SELECT cust_trtab_main.cod_customer AS cod, cust_trtab_main.f_name, cust_trtab_main.l_name, cust_company.complete_name, 0 AS flag FROM cust_trtab_main LEFT OUTER JOIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_company "
                    End If
                End If
            End If
            DACustomer.Fill(DsFrmRepCusSale2.customer)
        End If
        f.Text = "  Select Customer"
        f.TypeOfForm = FrmSelect.KindForm.customer
        f.DSMAIN = DsFrmRepCusSale2
        f.ShowDialog()

        BtnCus.Enabled = True
    End Sub

    Private Sub BtnType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnType.Click
        BtnType.Enabled = False
        Dim f As New FrmSelect
        If DsFrmRepCusSale2.type.Count = 0 Then
            DsFrmRepCusSale2.type.Clear()
            DAType.Fill(DsFrmRepCusSale2.type)
        End If
        f.Text = "  Select Type"
        f.TypeOfForm = FrmSelect.KindForm.type
        f.DSMAIN = DsFrmRepCusSale2
        f.ShowDialog()

        BtnType.Enabled = True
    End Sub

    Private Sub BtnSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSource.Click
        BtnSource.Enabled = False
        Dim f As New FrmSelect
        If DsFrmRepCusSale2.source.Count = 0 Then
            DsFrmRepCusSale2.source.Clear()
            DASource.Fill(DsFrmRepCusSale2.source)
        End If
        f.Text = "  Select Source"
        f.TypeOfForm = FrmSelect.KindForm.source
        f.DSMAIN = DsFrmRepCusSale2
        f.ShowDialog()



        BtnSource.Enabled = True
    End Sub

    Private Sub BtnClass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClass.Click
        BtnClass.Enabled = False
        Dim f As New FrmSelect
        If DsFrmRepCusSale2.clas.Count = 0 Then
            DsFrmRepCusSale2.clas.Clear()
            DAClass.Fill(DsFrmRepCusSale2.clas)
        End If
        f.Text = "  Select Class"
        f.TypeOfForm = FrmSelect.KindForm.clas
        f.DSMAIN = DsFrmRepCusSale2
        f.ShowDialog()



        BtnClass.Enabled = True
    End Sub

    Private Sub BtnTerr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTerr.Click
        BtnTerr.Enabled = False
        Dim f As New FrmSelect
        If DsFrmRepCusSale2.territory.Count = 0 Then
            DsFrmRepCusSale2.territory.Clear()
            DATerr.Fill(DsFrmRepCusSale2.territory)
        End If
        f.Text = "  Select Territory"
        f.TypeOfForm = FrmSelect.KindForm.terr
        f.DSMAIN = DsFrmRepCusSale2
        f.ShowDialog()

        BtnTerr.Enabled = True
    End Sub

    Private Sub BtnSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSale.Click
        BtnSale.Enabled = False
        Dim f As New FrmSelect
        If DsFrmRepCusSale2.employee.Count = 0 Then
            DsFrmRepCusSale2.employee.Clear()
            DAEmployee.Fill(DsFrmRepCusSale2.employee)
        End If
        f.Text = "  Select SalesPerson"
        f.TypeOfForm = FrmSelect.KindForm.sale
        f.DSMAIN = DsFrmRepCusSale2
        f.ShowDialog()

        BtnSale.Enabled = True
    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        If ControlSelect() Then
            Dim f As New FrmPrint
            f.StrWhere = ""
            f.StrFilter = ""
            If Not (ChkDate.Checked) And MKindOfReport = KindReport.customerSale Then
                f.StrFilter = f.StrFilter & "Date, "
                f.StrWhere = f.StrWhere & " (" & StrDate & ") and "
                f.Date1 = CalendarCombo1.Text
                f.Date2 = CalendarCombo2.Text
            Else
                f.Date1 = ""
                f.Date2 = ""
            End If
            If RdoSelectedCus.Checked Then
                f.StrFilter = f.StrFilter & "Customer, "
                f.StrWhere = f.StrWhere & " (" & StrCustomer & ") and "
                f.FCus = True
            Else
                If RdoCashCus.Checked Or RdoChargeCus.Checked Or RdoTaxCus.Checked Then
                    f.StrFilter = f.StrFilter & "Customer, "
                    If StrCustomer.Trim.Length > 0 Then
                        f.StrWhere = f.StrWhere & " (" & StrCustomer & ") and "
                    End If
                End If
            End If



            If RdoSelectedType.Checked Then
                f.StrFilter = f.StrFilter & "Type, "
                f.StrWhere = f.StrWhere & " (" & StrType & ") and "

            End If
            If RdoSelectedSource.Checked Then
                f.StrFilter = f.StrFilter & "Source, "
                f.StrWhere = f.StrWhere & " (" & StrSource & ") and "

            End If
            If RdoSelectedClass.Checked Then
                f.StrFilter = f.StrFilter & "Class, "
                f.StrWhere = f.StrWhere & "(" & StrClass & ") and "

            End If
            If RdoSelectdTerritori.Checked Then
                f.StrFilter = f.StrFilter & "Territory, "
                f.StrWhere = f.StrWhere & " (" & StrTerr & ") and "

            End If
            If RdoSelectedSaler.Checked Then
                f.StrFilter = f.StrFilter & "Sales Person, "
                f.StrWhere = f.StrWhere & " (" & StrEmp & ") and "

            End If


            If f.StrWhere.Trim.Length > 0 Then f.StrWhere = Mid(f.StrWhere, 1, f.StrWhere.Length - 4)
            If f.StrFilter.Trim.Length > 0 Then f.StrFilter = Mid(f.StrFilter, 1, f.StrFilter.Length - 2)

            If MKindOfReport = KindReport.customerSale Then
                If RdoDetail.Checked Then
                    f.KindOfReport = FrmPrint.KindReport.customerSaleDetail
                    f.Text = "Customer Sales Report In Detail"
                Else
                    f.KindOfReport = FrmPrint.KindReport.customerSaleSummery
                    f.Text = "Customer Sales Report In Summery"
                End If
            Else
                If RdoDetail.Checked Then
                    f.KindOfReport = FrmPrint.KindReport.CustomerListing
                    f.Text = " Customet Listing Report "
                Else
                    NewCusLabel(f.StrWhere)
                End If
              
            End If
            f.ShowDialog()
            If RdoSelectedCus.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Cust_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                Try
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                End Try
            End If
            If RdoSelectedType.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Type_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If
            If RdoSelectedSource.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Source_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If
            If RdoSelectedClass.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Class_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If
            If RdoSelectdTerritori.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Ter_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If

                CmdGeneral.ExecuteNonQuery()
            End If
            If RdoSelectedSaler.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Employee_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If







        End If

    End Sub
    Private Function ControlSelect() As Boolean
        'Dim flagcontrol As Boolean = False
        ControlSelect = True
        StrCustomer = ""
        Dim i As Integer
        StrCustomer = ""
        If RdoSelectedCus.Checked Or RdoCashCus.Checked Or RdoChargeCus.Checked Or RdoTaxCus.Checked Then
            If DsFrmRepCusSale2.customer.Select(" flag = 1 ").Length = 0 Then
                If RdoChargeCus.Checked Then
                    StrCustomer = " cust_trtab_main.AR_charge ='1' "
                ElseIf RdoCashCus.Checked Then
                    StrCustomer = " cust_trtab_main.AR_charge ='0' "
                ElseIf RdoTaxCus.Checked = True Then
                    StrCustomer = " cust_trtab_main.Taxable ='0' "
                Else
                    ControlSelect = False
                    MsgBox("First Select customer that you want")
                    Exit Function
                End If
            Else
                Try
                    CmdGeneral.CommandText = " create table Cust_" & ComName & "(cod_customer char(10))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Cust_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DsFrmRepCusSale2.customer.Count - 1
                    If DsFrmRepCusSale2.customer(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO cust_" & ComName & " (cod_customer ) VALUES (" & Qt(DsFrmRepCusSale2.customer(i).cod) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrCustomer = " cust_trtab_main.cod_customer in (select cod_customer from cust_" & ComName & ") "
            End If



            'If DsFrmRepCusSale2.customer.Select(" flag = 1 ").Length = 0 Then
            '    If RdoChargeCus.Checked Then
            '        StrCustomer = " cust_trtab_main.AR_charge ='1' "
            '    ElseIf RdoCashCus.Checked Then
            '        StrCustomer = " cust_trtab_main.AR_charge ='0' "
            '    Else
            '        ControlSelect = False
            '        MsgBox("First Select customer that you want")
            '        Exit Function
            '    End If

            'End If
        End If
        '''''''type
        StrType = ""
        'flagcontrol = False
        If RdoSelectedType.Checked Then
            If DsFrmRepCusSale2.type.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select Type that you want")
                Exit Function

            Else
                Try
                    CmdGeneral.CommandText = " create table Type_" & ComName & "(cod_type char(1))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Type_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DsFrmRepCusSale2.type.Count - 1
                    If DsFrmRepCusSale2.type(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO Type_" & ComName & " (cod_type ) VALUES (" & Qt(DsFrmRepCusSale2.type(i).cod) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrType = " cust_trtab_main.cod_type in (select cod_type from Type_" & ComName & ") "
            End If
            'If DsFrmRepCusSale2.type.Select(" flag = 1 ").Length = 0 Then
            '    ControlSelect = False
            '    MsgBox("First Select Type that you want")
            '    Exit Function
            'End If


        End If
        '''''''''''Source
        StrSource = ""
        If RdoSelectedSource.Checked Then

            If DsFrmRepCusSale2.source.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select Source that you want")
                Exit Function

            Else
                Try
                    CmdGeneral.CommandText = " create table source_" & ComName & "(cod_source char(1))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM source_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DsFrmRepCusSale2.source.Count - 1
                    If DsFrmRepCusSale2.source(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO source_" & ComName & " (cod_source ) VALUES (" & Qt(DsFrmRepCusSale2.source(i).cod) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrSource = " cust_trtab_main.cod_source in (select cod_source from source_" & ComName & ") "
            End If
            'If DsFrmRepCusSale2.source.Select(" flag = 1 ").Length = 0 Then
            '    ControlSelect = False
            '    MsgBox("First Select Source that you want")
            '    Exit Function
            'End If

        End If
        '''''''''''''''Class
        StrClass = ""
        If RdoSelectedClass.Checked Then
            If DsFrmRepCusSale2.clas.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select Class that you want")
                Exit Function

            Else
                Try
                    CmdGeneral.CommandText = " create table Class_" & ComName & "(cod_class char(1))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Class_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DsFrmRepCusSale2.clas.Count - 1
                    If DsFrmRepCusSale2.clas(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO Class_" & ComName & " (cod_class ) VALUES (" & Qt(DsFrmRepCusSale2.clas(i).cod) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrClass = " cust_trtab_main.cod_class in (select cod_class from Class_" & ComName & ") "
            End If
            'If DsFrmRepCusSale2.clas.Select(" flag = 1 ").Length = 0 Then
            '    ControlSelect = False
            '    MsgBox("First Select Class that you want")
            '    Exit Function
            'End If

        End If
        '''''''''''''''Territori
        StrTerr = ""
        If RdoSelectdTerritori.Checked Then
            If DsFrmRepCusSale2.territory.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select territory that you want")
                Exit Function

            Else
                Try
                    CmdGeneral.CommandText = " create table Ter_" & ComName & "(cod_territory char(2))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Ter_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DsFrmRepCusSale2.territory.Count - 1
                    If DsFrmRepCusSale2.territory(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO Ter_" & ComName & " (cod_territory ) VALUES (" & Qt(DsFrmRepCusSale2.territory(i).cod) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrTerr = " cust_trtab_main.cod_territory in (select cod_territory from Ter_" & ComName & ") "
            End If
            'If DsFrmRepCusSale2.territory.Select(" flag = 1 ").Length = 0 Then
            '    ControlSelect = False
            '    MsgBox("First Select territory that you want")
            '    Exit Function
            'End If
        End If
        '''''''''''''''Saler
        StrEmp = ""
        If RdoSelectedSaler.Checked Then
            If DsFrmRepCusSale2.employee.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select SalesPersons that you want")
                Exit Function

            Else
                Try
                    CmdGeneral.CommandText = " create table Employee_" & ComName & "(cod_sales_rep char(5))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Employee_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DsFrmRepCusSale2.employee.Count - 1
                    If DsFrmRepCusSale2.employee(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO Employee_" & ComName & " (cod_sales_rep ) VALUES (" & Qt(DsFrmRepCusSale2.employee(i).cod) & ") "
                            CmdGeneral.ExecuteNonQuery()
                    End If
                Next
                StrEmp = " cust_trtab_main.cod_sales_rep in (select cod_sales_rep from Employee_" & ComName & ") "
            End If
            'If DsFrmRepCusSale2.employee.Select(" flag = 1 ").Length = 0 Then
            '    ControlSelect = False
            '    MsgBox("First Select SalesPersons that you want")
            '    Exit Function
            'End If
        End If
        ''''''date
        StrDate = ""
        If Not (ChkDate.Checked) Then
            If ChangeDateToYYYYMMDD(CalendarCombo1.Text) > ChangeDateToYYYYMMDD(CalendarCombo2.Text) Then
                ControlSelect = False
                MsgBox("First Date Must Be Leaster Than Second Time")
                Exit Function
            Else
                StrDate = "dbo.ChangeDate( service_center_head.date_refer)  between " & Qt(ChangeDateToYYYYMMDD(CalendarCombo1.Text)) & " and " & Qt(ChangeDateToYYYYMMDD(CalendarCombo2.Text))
            End If

        End If
    End Function
    Private Sub VisibleControl()
        If MKindOfReport = KindReport.CustomerListing Then
            ' PanelDetail.Visible = False
            PanelDate.Visible = False
        Else
            Label11.Text = "Select a date range and any desired options followed by OK  to print the report"
        End If
    End Sub
    Private Sub FillTextForm()
        Select Case MKindOfReport
            Case KindReport.customerSale
                Me.Text = "  Customer Sales Report"
            Case KindReport.CustomerListing
                Me.Text = "   Customer Reports"
                RdoDetail.Text = "Listing"
                RdoSummery.Text = "Labels"


        End Select
    End Sub
    Private Sub NewCusLabel(ByVal StrWhere As String)
        Dim DAList As New SqlClient.SqlDataAdapter("", Cnn)

        DsFrmRepCusSale2.List.Clear()
        DAList.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer AS customer_no, cust_trtab_main.f_name, cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
"                       cust_company.complete_name, bas_zipcode.city, cust_trtab_main.zip,  " & _
"                       CASE WHEN phone_main_1 = 1 THEN phone_1 WHEN phone_main_2 = 1 THEN phone_2 WHEN phone_main_3 = 1 THEN phone_3 WHEN phone_main_4 " & _
"                        = 1 THEN phone_4 WHEN phone_main_5 = 1 THEN phone_5 END AS phone_1,  cust_tab_type.desc_type,  " & _
"                       cust_tab_source.desc_source, 1 AS flag, cust_trtab_main.address , bas_zipcode.state" & _
" FROM         cust_trtab_main LEFT OUTER JOIN " & _
"                       bas_zipcode ON cust_trtab_main.zip = bas_zipcode.zipcode LEFT OUTER JOIN " & _
"                       cust_tab_source ON cust_trtab_main.cod_source = cust_tab_source.cod_source LEFT OUTER JOIN " & _
"                       cust_tab_type ON cust_trtab_main.cod_type = cust_tab_type.cod_type LEFT OUTER JOIN " & _
"                       cust_company ON cust_trtab_main.cod_company = cust_company.cod_company  " & IIf(StrWhere.Trim.Length > 0, " WHERE " & StrWhere, "")



        'If StrWhere.Length > 0 Then
        '    DAList.SelectCommand.CommandText = DAList.SelectCommand.CommandText & " where " & StrWhere
        'End If
        Try
            DAList.Fill(DsFrmRepCusSale2.List)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        Dim rpt As New RepNewCusLabel
        Dim prn As New FrmRepView

        rpt.SetDataSource(DsFrmRepCusSale2)

        prn.CrViewer.ReportSource = rpt
        prn.ShowDialog()
    End Sub

End Class
