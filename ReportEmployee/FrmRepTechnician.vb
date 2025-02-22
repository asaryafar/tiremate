Imports CommonClass
Public Class FrmRepTechnician
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
    Friend WithEvents PanelSale As System.Windows.Forms.GroupBox
    Friend WithEvents PanelSaler As System.Windows.Forms.Panel
    Friend WithEvents PanelTypeCus As System.Windows.Forms.GroupBox
    Friend WithEvents PanelDetail As System.Windows.Forms.Panel
    Friend WithEvents RdoSummery As System.Windows.Forms.RadioButton
    Friend WithEvents RdoDetail As System.Windows.Forms.RadioButton
    Friend WithEvents PanelCus As System.Windows.Forms.Panel
    Friend WithEvents PanelDate As System.Windows.Forms.GroupBox
    Friend WithEvents PanelInnerDate As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChkDate As System.Windows.Forms.CheckBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents CalendarCombo1 As CalendarCombo.CalendarCombo
    Friend WithEvents CalendarCombo2 As CalendarCombo.CalendarCombo
    Friend WithEvents RdoSelectedPo As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllPos As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSelectedEmp As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllEmp As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSelectedBasis As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAlBasis As System.Windows.Forms.RadioButton
    Friend WithEvents PnlBasisDtl As System.Windows.Forms.Panel
    Friend WithEvents RdoSelectedPer As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllPer As System.Windows.Forms.RadioButton
    Friend WithEvents PnlPerDtl As System.Windows.Forms.Panel
    Friend WithEvents BtnPos As System.Windows.Forms.Button
    Friend WithEvents BtnEmp As System.Windows.Forms.Button
    Friend WithEvents RdoB4 As System.Windows.Forms.RadioButton
    Friend WithEvents RdoB3 As System.Windows.Forms.RadioButton
    Friend WithEvents RdoB2 As System.Windows.Forms.RadioButton
    Friend WithEvents RdoB1 As System.Windows.Forms.RadioButton
    Friend WithEvents RdoP4 As System.Windows.Forms.RadioButton
    Friend WithEvents RdoP3 As System.Windows.Forms.RadioButton
    Friend WithEvents RdoP2 As System.Windows.Forms.RadioButton
    Friend WithEvents RdoP1 As System.Windows.Forms.RadioButton
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAEmp As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAPsition As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmRepTechnicians1 As ReportEmployee.DSFrmRepTechnicians
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmRepTechnician))
        Me.PanelSale = New System.Windows.Forms.GroupBox
        Me.PanelSaler = New System.Windows.Forms.Panel
        Me.BtnPos = New System.Windows.Forms.Button
        Me.RdoSelectedPo = New System.Windows.Forms.RadioButton
        Me.RdoAllPos = New System.Windows.Forms.RadioButton
        Me.PanelTypeCus = New System.Windows.Forms.GroupBox
        Me.PanelDetail = New System.Windows.Forms.Panel
        Me.RdoSummery = New System.Windows.Forms.RadioButton
        Me.RdoDetail = New System.Windows.Forms.RadioButton
        Me.PanelCus = New System.Windows.Forms.Panel
        Me.BtnEmp = New System.Windows.Forms.Button
        Me.RdoSelectedEmp = New System.Windows.Forms.RadioButton
        Me.RdoAllEmp = New System.Windows.Forms.RadioButton
        Me.PanelDate = New System.Windows.Forms.GroupBox
        Me.PanelInnerDate = New System.Windows.Forms.Panel
        Me.CalendarCombo1 = New CalendarCombo.CalendarCombo
        Me.CalendarCombo2 = New CalendarCombo.CalendarCombo
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ChkDate = New System.Windows.Forms.CheckBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RdoSelectedBasis = New System.Windows.Forms.RadioButton
        Me.RdoAlBasis = New System.Windows.Forms.RadioButton
        Me.PnlBasisDtl = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.RdoB4 = New System.Windows.Forms.RadioButton
        Me.RdoB3 = New System.Windows.Forms.RadioButton
        Me.RdoB2 = New System.Windows.Forms.RadioButton
        Me.RdoB1 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PnlPerDtl = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.RdoP4 = New System.Windows.Forms.RadioButton
        Me.RdoP3 = New System.Windows.Forms.RadioButton
        Me.RdoP2 = New System.Windows.Forms.RadioButton
        Me.RdoP1 = New System.Windows.Forms.RadioButton
        Me.RdoSelectedPer = New System.Windows.Forms.RadioButton
        Me.RdoAllPer = New System.Windows.Forms.RadioButton
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnOk = New System.Windows.Forms.Button
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAEmp = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAPsition = New System.Data.SqlClient.SqlDataAdapter
        Me.DsFrmRepTechnicians1 = New ReportEmployee.DSFrmRepTechnicians
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.PanelSale.SuspendLayout()
        Me.PanelSaler.SuspendLayout()
        Me.PanelTypeCus.SuspendLayout()
        Me.PanelDetail.SuspendLayout()
        Me.PanelCus.SuspendLayout()
        Me.PanelDate.SuspendLayout()
        Me.PanelInnerDate.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PnlBasisDtl.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.PnlPerDtl.SuspendLayout()
        CType(Me.DsFrmRepTechnicians1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelSale
        '
        Me.PanelSale.Controls.Add(Me.PanelSaler)
        Me.PanelSale.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSale.Location = New System.Drawing.Point(0, 176)
        Me.PanelSale.Name = "PanelSale"
        Me.PanelSale.Size = New System.Drawing.Size(499, 68)
        Me.PanelSale.TabIndex = 16
        Me.PanelSale.TabStop = False
        '
        'PanelSaler
        '
        Me.PanelSaler.Controls.Add(Me.BtnPos)
        Me.PanelSaler.Controls.Add(Me.RdoSelectedPo)
        Me.PanelSaler.Controls.Add(Me.RdoAllPos)
        Me.PanelSaler.Location = New System.Drawing.Point(22, 16)
        Me.PanelSaler.Name = "PanelSaler"
        Me.PanelSaler.Size = New System.Drawing.Size(376, 40)
        Me.PanelSaler.TabIndex = 6
        '
        'BtnPos
        '
        Me.BtnPos.Enabled = False
        Me.BtnPos.Location = New System.Drawing.Point(264, 16)
        Me.BtnPos.Name = "BtnPos"
        Me.BtnPos.TabIndex = 3
        Me.BtnPos.Text = "Choose..."
        '
        'RdoSelectedPo
        '
        Me.RdoSelectedPo.Location = New System.Drawing.Point(128, 16)
        Me.RdoSelectedPo.Name = "RdoSelectedPo"
        Me.RdoSelectedPo.Size = New System.Drawing.Size(144, 24)
        Me.RdoSelectedPo.TabIndex = 1
        Me.RdoSelectedPo.Text = "Selected Positions"
        '
        'RdoAllPos
        '
        Me.RdoAllPos.Checked = True
        Me.RdoAllPos.Location = New System.Drawing.Point(0, 16)
        Me.RdoAllPos.Name = "RdoAllPos"
        Me.RdoAllPos.Size = New System.Drawing.Size(112, 24)
        Me.RdoAllPos.TabIndex = 0
        Me.RdoAllPos.TabStop = True
        Me.RdoAllPos.Text = "All Positions"
        '
        'PanelTypeCus
        '
        Me.PanelTypeCus.Controls.Add(Me.PanelDetail)
        Me.PanelTypeCus.Controls.Add(Me.PanelCus)
        Me.PanelTypeCus.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTypeCus.Location = New System.Drawing.Point(0, 96)
        Me.PanelTypeCus.Name = "PanelTypeCus"
        Me.PanelTypeCus.Size = New System.Drawing.Size(499, 80)
        Me.PanelTypeCus.TabIndex = 14
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
        Me.PanelCus.Controls.Add(Me.BtnEmp)
        Me.PanelCus.Controls.Add(Me.RdoSelectedEmp)
        Me.PanelCus.Controls.Add(Me.RdoAllEmp)
        Me.PanelCus.Location = New System.Drawing.Point(22, 16)
        Me.PanelCus.Name = "PanelCus"
        Me.PanelCus.Size = New System.Drawing.Size(376, 48)
        Me.PanelCus.TabIndex = 6
        '
        'BtnEmp
        '
        Me.BtnEmp.Enabled = False
        Me.BtnEmp.Location = New System.Drawing.Point(264, 24)
        Me.BtnEmp.Name = "BtnEmp"
        Me.BtnEmp.TabIndex = 3
        Me.BtnEmp.Text = "Choose..."
        '
        'RdoSelectedEmp
        '
        Me.RdoSelectedEmp.Location = New System.Drawing.Point(128, 16)
        Me.RdoSelectedEmp.Name = "RdoSelectedEmp"
        Me.RdoSelectedEmp.Size = New System.Drawing.Size(120, 24)
        Me.RdoSelectedEmp.TabIndex = 1
        Me.RdoSelectedEmp.Text = "Selected Employee"
        '
        'RdoAllEmp
        '
        Me.RdoAllEmp.Checked = True
        Me.RdoAllEmp.Location = New System.Drawing.Point(0, 16)
        Me.RdoAllEmp.Name = "RdoAllEmp"
        Me.RdoAllEmp.TabIndex = 0
        Me.RdoAllEmp.TabStop = True
        Me.RdoAllEmp.Text = "All Employees"
        '
        'PanelDate
        '
        Me.PanelDate.Controls.Add(Me.PanelInnerDate)
        Me.PanelDate.Controls.Add(Me.ChkDate)
        Me.PanelDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDate.Location = New System.Drawing.Point(0, 48)
        Me.PanelDate.Name = "PanelDate"
        Me.PanelDate.Size = New System.Drawing.Size(499, 48)
        Me.PanelDate.TabIndex = 13
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
        Me.CalendarCombo1.Location = New System.Drawing.Point(36, 1)
        Me.CalendarCombo1.MaxValue = CType(2500, Short)
        Me.CalendarCombo1.MinValue = CType(1800, Short)
        Me.CalendarCombo1.Name = "CalendarCombo1"
        Me.CalendarCombo1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CalendarCombo1.Sal_Mali = Nothing
        Me.CalendarCombo1.ShowButton = True
        Me.CalendarCombo1.Size = New System.Drawing.Size(110, 23)
        Me.CalendarCombo1.TabIndex = 5
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
        Me.CalendarCombo2.Location = New System.Drawing.Point(180, 1)
        Me.CalendarCombo2.MaxValue = CType(2500, Short)
        Me.CalendarCombo2.MinValue = CType(1800, Short)
        Me.CalendarCombo2.Name = "CalendarCombo2"
        Me.CalendarCombo2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CalendarCombo2.Sal_Mali = Nothing
        Me.CalendarCombo2.ShowButton = True
        Me.CalendarCombo2.Size = New System.Drawing.Size(110, 23)
        Me.CalendarCombo2.TabIndex = 6
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
        Me.ChkDate.Text = "All Dates"
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
        Me.Panel4.Size = New System.Drawing.Size(499, 48)
        Me.Panel4.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Location = New System.Drawing.Point(64, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(235, 46)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Select a date range and any desired options followed by OK  to print the report"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdoSelectedBasis)
        Me.GroupBox1.Controls.Add(Me.RdoAlBasis)
        Me.GroupBox1.Controls.Add(Me.PnlBasisDtl)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 244)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(499, 109)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'RdoSelectedBasis
        '
        Me.RdoSelectedBasis.Location = New System.Drawing.Point(136, 32)
        Me.RdoSelectedBasis.Name = "RdoSelectedBasis"
        Me.RdoSelectedBasis.Size = New System.Drawing.Size(144, 24)
        Me.RdoSelectedBasis.TabIndex = 1
        Me.RdoSelectedBasis.Text = "Selected Pay Basis"
        '
        'RdoAlBasis
        '
        Me.RdoAlBasis.Checked = True
        Me.RdoAlBasis.Location = New System.Drawing.Point(24, 32)
        Me.RdoAlBasis.Name = "RdoAlBasis"
        Me.RdoAlBasis.Size = New System.Drawing.Size(112, 24)
        Me.RdoAlBasis.TabIndex = 0
        Me.RdoAlBasis.TabStop = True
        Me.RdoAlBasis.Text = "All Pay Basis"
        '
        'PnlBasisDtl
        '
        Me.PnlBasisDtl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlBasisDtl.Controls.Add(Me.Label6)
        Me.PnlBasisDtl.Controls.Add(Me.RdoB4)
        Me.PnlBasisDtl.Controls.Add(Me.RdoB3)
        Me.PnlBasisDtl.Controls.Add(Me.RdoB2)
        Me.PnlBasisDtl.Controls.Add(Me.RdoB1)
        Me.PnlBasisDtl.Enabled = False
        Me.PnlBasisDtl.Location = New System.Drawing.Point(282, 5)
        Me.PnlBasisDtl.Name = "PnlBasisDtl"
        Me.PnlBasisDtl.Size = New System.Drawing.Size(110, 103)
        Me.PnlBasisDtl.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Basis"
        '
        'RdoB4
        '
        Me.RdoB4.Location = New System.Drawing.Point(8, 78)
        Me.RdoB4.Name = "RdoB4"
        Me.RdoB4.Size = New System.Drawing.Size(88, 24)
        Me.RdoB4.TabIndex = 3
        Me.RdoB4.Text = "Piece Work"
        '
        'RdoB3
        '
        Me.RdoB3.Location = New System.Drawing.Point(8, 58)
        Me.RdoB3.Name = "RdoB3"
        Me.RdoB3.Size = New System.Drawing.Size(88, 24)
        Me.RdoB3.TabIndex = 2
        Me.RdoB3.Text = "Commission"
        '
        'RdoB2
        '
        Me.RdoB2.Location = New System.Drawing.Point(8, 37)
        Me.RdoB2.Name = "RdoB2"
        Me.RdoB2.Size = New System.Drawing.Size(72, 24)
        Me.RdoB2.TabIndex = 1
        Me.RdoB2.Text = "Salary"
        '
        'RdoB1
        '
        Me.RdoB1.Checked = True
        Me.RdoB1.Location = New System.Drawing.Point(8, 19)
        Me.RdoB1.Name = "RdoB1"
        Me.RdoB1.Size = New System.Drawing.Size(72, 24)
        Me.RdoB1.TabIndex = 0
        Me.RdoB1.TabStop = True
        Me.RdoB1.Text = "Hours"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PnlPerDtl)
        Me.GroupBox2.Controls.Add(Me.RdoSelectedPer)
        Me.GroupBox2.Controls.Add(Me.RdoAllPer)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 353)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(499, 118)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'PnlPerDtl
        '
        Me.PnlPerDtl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlPerDtl.Controls.Add(Me.Label8)
        Me.PnlPerDtl.Controls.Add(Me.RdoP4)
        Me.PnlPerDtl.Controls.Add(Me.RdoP3)
        Me.PnlPerDtl.Controls.Add(Me.RdoP2)
        Me.PnlPerDtl.Controls.Add(Me.RdoP1)
        Me.PnlPerDtl.Enabled = False
        Me.PnlPerDtl.Location = New System.Drawing.Point(282, 6)
        Me.PnlPerDtl.Name = "PnlPerDtl"
        Me.PnlPerDtl.Size = New System.Drawing.Size(110, 103)
        Me.PnlPerDtl.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 23)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Period"
        '
        'RdoP4
        '
        Me.RdoP4.Location = New System.Drawing.Point(8, 78)
        Me.RdoP4.Name = "RdoP4"
        Me.RdoP4.Size = New System.Drawing.Size(88, 24)
        Me.RdoP4.TabIndex = 3
        Me.RdoP4.Text = "Monthly"
        '
        'RdoP3
        '
        Me.RdoP3.Location = New System.Drawing.Point(8, 58)
        Me.RdoP3.Name = "RdoP3"
        Me.RdoP3.Size = New System.Drawing.Size(88, 24)
        Me.RdoP3.TabIndex = 2
        Me.RdoP3.Text = "SemiMonthly"
        '
        'RdoP2
        '
        Me.RdoP2.Location = New System.Drawing.Point(8, 37)
        Me.RdoP2.Name = "RdoP2"
        Me.RdoP2.Size = New System.Drawing.Size(72, 24)
        Me.RdoP2.TabIndex = 1
        Me.RdoP2.Text = "BiWeekly"
        '
        'RdoP1
        '
        Me.RdoP1.Checked = True
        Me.RdoP1.Location = New System.Drawing.Point(8, 19)
        Me.RdoP1.Name = "RdoP1"
        Me.RdoP1.Size = New System.Drawing.Size(72, 24)
        Me.RdoP1.TabIndex = 0
        Me.RdoP1.TabStop = True
        Me.RdoP1.Text = "Weekly"
        '
        'RdoSelectedPer
        '
        Me.RdoSelectedPer.Location = New System.Drawing.Point(144, 32)
        Me.RdoSelectedPer.Name = "RdoSelectedPer"
        Me.RdoSelectedPer.Size = New System.Drawing.Size(144, 24)
        Me.RdoSelectedPer.TabIndex = 1
        Me.RdoSelectedPer.Text = "Selected Pay Periods"
        '
        'RdoAllPer
        '
        Me.RdoAllPer.Checked = True
        Me.RdoAllPer.Location = New System.Drawing.Point(16, 32)
        Me.RdoAllPer.Name = "RdoAllPer"
        Me.RdoAllPer.Size = New System.Drawing.Size(112, 24)
        Me.RdoAllPer.TabIndex = 0
        Me.RdoAllPer.TabStop = True
        Me.RdoAllPer.Text = "All Pay Periods"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(288, 16)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.TabIndex = 20
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(104, 16)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.TabIndex = 19
        Me.BtnOk.Text = "OK"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT employee_code AS cod, l_name AS col1, f_name AS col2 FROM employee WHERE (" & _
        "technecian = '1')"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=MILAD;packet size=4096;integrated security=SSPI;data source=milad;" & _
        "persist security info=False;initial catalog=TireMate_01_db"
        '
        'DAEmp
        '
        Me.DAEmp.SelectCommand = Me.SqlSelectCommand1
        Me.DAEmp.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "employee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("employee_code", "employee_code")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cod_position AS cod, desc_position AS col1, service_ok AS col2 FROM employ" & _
        "ee_position"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAPsition
        '
        Me.DAPsition.SelectCommand = Me.SqlSelectCommand2
        Me.DAPsition.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "employee_position", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_position", "cod_position"), New System.Data.Common.DataColumnMapping("desc_position", "desc_position")})})
        '
        'DsFrmRepTechnicians1
        '
        Me.DsFrmRepTechnicians1.DataSetName = "DSFrmRepTechnicians"
        Me.DsFrmRepTechnicians1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnCancel)
        Me.GroupBox3.Controls.Add(Me.BtnOk)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox3.Location = New System.Drawing.Point(0, 471)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(499, 49)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'FrmRepTechnician
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(499, 519)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelSale)
        Me.Controls.Add(Me.PanelTypeCus)
        Me.Controls.Add(Me.PanelDate)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmRepTechnician"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Reports"
        Me.PanelSale.ResumeLayout(False)
        Me.PanelSaler.ResumeLayout(False)
        Me.PanelTypeCus.ResumeLayout(False)
        Me.PanelDetail.ResumeLayout(False)
        Me.PanelCus.ResumeLayout(False)
        Me.PanelDate.ResumeLayout(False)
        Me.PanelInnerDate.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.PnlBasisDtl.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.PnlPerDtl.ResumeLayout(False)
        CType(Me.DsFrmRepTechnicians1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim StrDate As String
    Dim StrBasis As String
    Dim StrPer As String
    Dim StrEmp As String
    Dim StrPo As String
    Dim ComName As String = SystemInformation.ComputerName
    Dim MKindOfReport As KindReport
    Dim FUTAStr As String = 7000
    Public Enum KindReport As Integer
        Technician = 1
        SalesPerson = 2
        Payroll = 3
        FUTA = 4

    End Enum
    Public Property KindOfReport() As String
        Get
            Return MKindOfReport
        End Get
        Set(ByVal Value As String)
            MKindOfReport = Value
        End Set
    End Property

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        CalendarCombo1.Text = "01/01/" & PSalMali
        CalendarCombo2.Text = "12/28/" & PSalMali

        VisibleControl()
    End Sub
    Private Sub VisibleControl()
        If MKindOfReport = KindReport.SalesPerson Then
            GroupBox1.Visible = False
            GroupBox2.Visible = False
            Me.Size = New System.Drawing.Size(509, 350)
            Me.Text = "Salesperson Perfomance "
        End If
        If MKindOfReport = KindReport.FUTA Then
            GroupBox1.Visible = False
            GroupBox2.Visible = False
            Me.Size = New System.Drawing.Size(509, 350)
            Me.Text = "Federal UnEmployment Tax Report "
            PanelDetail.Visible = False
        End If
        If MKindOfReport = KindReport.Payroll Then
            Me.Text = "Employee Payroll"
        End If
    End Sub
    Private Sub ChkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDate.CheckedChanged
        If ChkDate.Checked Then
            PanelInnerDate.Enabled = False
        Else
            PanelInnerDate.Enabled = True
        End If
    End Sub
    Private Sub RdoAllEmp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllEmp.CheckedChanged
        If RdoAllEmp.Checked Then
            BtnEmp.Enabled = False
        Else
            BtnEmp.Enabled = True
        End If
    End Sub

    Private Sub RdoAllPos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllPos.CheckedChanged
        If RdoAllPos.Checked Then
            BtnPos.Enabled = False
        Else
            BtnPos.Enabled = True
        End If
    End Sub

    Private Sub RdoAlBasis_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAlBasis.CheckedChanged
        If RdoAlBasis.Checked Then
            PnlBasisDtl.Enabled = False
        Else
            PnlBasisDtl.Enabled = True
        End If
    End Sub

    Private Sub RdoAllPer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllPer.CheckedChanged
        If RdoAllPer.Checked Then
            PnlPerDtl.Enabled = False
        Else
            PnlPerDtl.Enabled = True
        End If

    End Sub

    Private Sub BtnEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmp.Click
        BtnEmp.Enabled = False
        Dim f As New FrmSelect
        If DsFrmRepTechnicians1.employee.Count = 0 Then
            DAEmp.Fill(DsFrmRepTechnicians1.employee)
        End If
        f.Text = "  Select Employee"
        f.TypeOfForm = FrmSelect.KindForm.Employee
        f.DSMAIN = DsFrmRepTechnicians1
        f.ShowDialog()
        BtnEmp.Enabled = True
    End Sub

    Private Sub BtnPos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPos.Click
        BtnPos.Enabled = False
        Dim f As New FrmSelect
        If DsFrmRepTechnicians1.employee_position.Count = 0 Then
            DAPsition.Fill(DsFrmRepTechnicians1.employee_position)
        End If
        f.Text = "  Select Customer"
        f.TypeOfForm = FrmSelect.KindForm.Position
        f.DSMAIN = DsFrmRepTechnicians1
        f.ShowDialog()
        BtnPos.Enabled = True
    End Sub

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        If MKindOfReport = KindReport.FUTA Then
            PrintFuta()
        Else
            If ControlSelect() Then
                Dim f As New FrmPrint
                f.StrWhere = ""
                f.StrFilter = ""
                If Not (ChkDate.Checked) Then
                    f.StrFilter = f.StrFilter & "Date, "
                    f.StrWhere = f.StrWhere & " (" & StrDate & ") and "
                    f.Date1 = CalendarCombo1.Text
                    f.Date2 = CalendarCombo2.Text
                Else
                    f.Date1 = ""
                    f.Date2 = ""
                End If
                If RdoSelectedEmp.Checked Then
                    f.StrFilter = f.StrFilter & "Employee, "
                    f.StrWhere = f.StrWhere & " (" & StrEmp & ") and "
                    f.FEmp = True
                Else
                    f.FEmp = False
                End If


                If RdoSelectedPo.Checked Then
                    f.StrFilter = f.StrFilter & "Position, "
                    f.StrWhere = f.StrWhere & " (" & StrPo & ") and "
                    f.Fpos = True
                Else
                    f.Fpos = False
                End If
                If RdoSelectedBasis.Checked Then
                    f.StrFilter = f.StrFilter & "Basis, "
                    f.StrWhere = f.StrWhere & " (" & StrBasis & ") and "
                End If
                If RdoSelectedPer.Checked Then
                    f.StrFilter = f.StrFilter & "Period, "
                    f.StrWhere = f.StrWhere & " (" & StrPer & ") and "
                End If
                f.DSMain = DsFrmRepTechnicians1

                If f.StrWhere.Trim.Length > 0 Then f.StrWhere = Mid(f.StrWhere, 1, f.StrWhere.Length - 4)
                If f.StrFilter.Trim.Length > 0 Then f.StrFilter = Mid(f.StrFilter, 1, f.StrFilter.Length - 2)
                Select Case MKindOfReport
                    Case KindReport.Technician
                        If RdoDetail.Checked Then
                            f.KindOfReport = FrmPrint.KindReport.TechnicianDetail
                        Else
                            f.KindOfReport = FrmPrint.KindReport.TechnicianSummery
                        End If
                    Case KindReport.SalesPerson
                        f.Text = "Salesperson Perfomance"
                        If RdoDetail.Checked Then
                            f.KindOfReport = FrmPrint.KindReport.SaleDetail
                        Else
                            f.KindOfReport = FrmPrint.KindReport.SaleSummery
                        End If
                    Case KindReport.Payroll
                        f.Text = "Employee Payroll"
                        If RdoDetail.Checked Then
                            f.KindOfReport = FrmPrint.KindReport.PayrollDetail
                        Else
                            f.KindOfReport = FrmPrint.KindReport.PAyrollSummery
                        End If
                End Select
                If RdoDetail.Checked Then
                    f.Text = f.Text & " In Detail"
                Else
                    f.Text = f.Text & " In Summary"
                End If
                f.ShowDialog()
                If RdoSelectedEmp.Checked Then
                    CmdGeneral.CommandText = " DROP TABLE Emp_" & ComName
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                End If
                If RdoSelectedPo.Checked Then
                    CmdGeneral.CommandText = " DROP TABLE Po_" & ComName
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                End If
            End If
        End If
       
    End Sub
    Private Function ControlSelect() As Boolean
        ControlSelect = True
        StrBasis = ""
        StrPer = ""

        Dim i As Integer
        'If RdoSelectedEmp.Checked Then
        '    If DsFrmRepTechnicians1.employee.Select(" flag = 1 ").Length = 0 Then
        '        ControlSelect = False
        '        MsgBox("First Select Employee that you want")
        '        Exit Function
        '    End If
        'End If




        If RdoSelectedEmp.Checked Then
            If DsFrmRepTechnicians1.employee.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select Employee that you want")
                Exit Function

            Else
                Try
                    CmdGeneral.CommandText = " create table Emp_" & ComName & "(employee_code char(10))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Emp_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try
                For i = 0 To DsFrmRepTechnicians1.employee.Count - 1
                    If DsFrmRepTechnicians1.employee(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO Emp_" & ComName & " (employee_code ) VALUES (" & Qt(DsFrmRepTechnicians1.employee(i).cod) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrEmp = " employee.employee_code in (select employee_code from Emp_" & ComName & ") "
            End If
        End If


        'If RdoSelectedPo.Checked Then
        '    If DsFrmRepTechnicians1.employee_position.Select(" flag = 1 ").Length = 0 Then
        '        ControlSelect = False
        '        MsgBox("First Select Position that you want")
        '        Exit Function
        '    End If
        'End If

        If RdoSelectedPo.Checked Then


            If DsFrmRepTechnicians1.employee_position.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select Position that you want")
                Exit Function

            Else
                Try
                    CmdGeneral.CommandText = " create table Po_" & ComName & "(cod_position char(10))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Po_" & ComName
                    CmdGeneral.ExecuteNonQuery()

                End Try


                For i = 0 To DsFrmRepTechnicians1.employee_position.Count - 1
                    If DsFrmRepTechnicians1.employee_position(i).flag Then
                        CmdGeneral.CommandText = " INSERT INTO Po_" & ComName & " (cod_position ) VALUES (" & Qt(DsFrmRepTechnicians1.employee_position(i).cod) & ") "
                        CmdGeneral.ExecuteNonQuery()
                    End If
                Next
                StrPo = " employee.cod_position in (select cod_position from Po_" & ComName & ") "
            End If
        End If
        If MKindOfReport = KindReport.Technician Then
            If RdoSelectedBasis.Checked Then
                StrBasis = " employee.last_basis = " & IIf(RdoB1.Checked, Qt("1"), IIf(RdoB2.Checked, Qt("2"), IIf(RdoB3.Checked, Qt("3"), Qt("4"))))
            End If
            If RdoSelectedPer.Checked Then
                StrPer = " employee.last_period = " & IIf(RdoP1.Checked, Qt("1"), IIf(RdoP2.Checked, Qt("2"), IIf(RdoP3.Checked, Qt("3"), Qt("4"))))
            End If
        End If
        StrDate = ""
        If Not (ChkDate.Checked) Then
            If ChangeDateToYYYYMMDD(CalendarCombo1.Text) > ChangeDateToYYYYMMDD(CalendarCombo2.Text) Then
                ControlSelect = False
                MsgBox("First Date Must Be Leaster Than Second Time")
                Exit Function
            Else
                Select Case MKindOfReport
                    Case KindReport.SalesPerson
                        StrDate = " dbo.ChangeDate(service_center_head.date_refer)  between " & Qt(ChangeDateToYYYYMMDD(CalendarCombo1.Text)) & " and " & Qt(ChangeDateToYYYYMMDD(CalendarCombo2.Text))
                    Case KindReport.Technician
                        StrDate = " dbo.ChangeDate(service_center_head.date_refer)  between " & Qt(ChangeDateToYYYYMMDD(CalendarCombo1.Text)) & " and " & Qt(ChangeDateToYYYYMMDD(CalendarCombo2.Text))
                    Case KindReport.Payroll
                        StrDate = " dbo.ChangeDate( pay_main_employee.PayrollDate)  between " & Qt(ChangeDateToYYYYMMDD(CalendarCombo1.Text)) & " and " & Qt(ChangeDateToYYYYMMDD(CalendarCombo2.Text))
                End Select

            End If
        End If

    End Function
    Private Sub PrintFuta()
        Dim StrWhere As String

        StrWhere = ""

        If Not (ChkDate.Checked) Then
            StrWhere = StrWhere & " (" & StrDate & ") and "
        End If
        If RdoSelectedEmp.Checked Then
            StrWhere = StrWhere & " (" & StrEmp & ") and "
        End If
        If RdoSelectedPo.Checked Then
            StrWhere = StrWhere & " (" & StrPo & ") and "
        End If
        If StrWhere.Trim.Length > 0 Then StrWhere = Mid(StrWhere, 1, StrWhere.Length - 4)



        Dim DAGeneral As New SqlClient.SqlDataAdapter("", Cnn)

        DAGeneral.SelectCommand.CommandText = " SELECT     employee.employee_code, employee.l_name + ' ' + employee.m_name + ' ' + employee.f_name AS name, employee.social_security_no,  " & _
                          "   SUM(ROUND(ISNULL(pay_main_employee.gross_pay, 0), 2)) AS gross_pay,  " & FUTAStr & "  AS FUTA,  " & _
                          "  CASE WHEN SUM(ROUND(ISNULL(pay_main_employee.gross_pay, 0), 2))  " & _
                          "  -  " & FUTAStr & "  < 0 THEN 0 ELSE SUM(ROUND(ISNULL(pay_main_employee.gross_pay, 0), 2)) -  " & FUTAStr & "  END AS EXCEED,  " & _
                          "   CASE WHEN SUM(ROUND(ISNULL(pay_main_employee.gross_pay, 0), 2)) -  " & FUTAStr & "  < 0 THEN SUM(ROUND(ISNULL(pay_main_employee.gross_pay,  " & _
                          "    0), 2)) ELSE " & FUTAStr & " END AS Taxable ,1 as flag" & _
                          " FROM         pay_main_employee INNER JOIN " & _
                          "  employee ON pay_main_employee.employee_code = employee.employee_code " & _
                          " GROUP BY employee.employee_code, employee.l_name, employee.m_name, employee.f_name, employee.social_security_no "
        DsFrmRepTechnicians1.FUTA.Clear()
        DAGeneral.Fill(DsFrmRepTechnicians1.FUTA)



        Dim rpt As New RepFUTA
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")

        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", Me.Text)
        rpt.SetParameterValue("Parfrom", CalendarCombo1.Text)
        rpt.SetParameterValue("ParTo", CalendarCombo2.Text)
        If ChkDate.Checked Then
            rpt.SetParameterValue("ParShowDate", True)
        Else
            rpt.SetParameterValue("ParShowDate", False)
        End If

        rpt.SetDataSource(DsFrmRepTechnicians1)
        'Select Case Type
        '    Case "print"
        '        Try
        '            rpt.PrintToPrinter(1, True, 0, 0)
        '        Catch ex As Exception

        '        End Try
        '    Case "priv"
        '        prn.CrViewer.ReportSource = rpt
        '        prn.ShowDialog()
        'End Select
        prn.CrViewer.ReportSource = rpt
        prn.ShowDialog()
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class
