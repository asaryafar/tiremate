Imports CommonClass
Public Class FrmRepVendor
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
    Friend WithEvents RdoSelectedType As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllType As System.Windows.Forms.RadioButton
    Friend WithEvents PanelTypeCus As System.Windows.Forms.GroupBox
    Friend WithEvents PanelDetail As System.Windows.Forms.Panel
    Friend WithEvents RdoSummery As System.Windows.Forms.RadioButton
    Friend WithEvents RdoDetail As System.Windows.Forms.RadioButton
    Friend WithEvents PanelCus As System.Windows.Forms.Panel
    Friend WithEvents RdoSelectedVen As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllVen As System.Windows.Forms.RadioButton
    Friend WithEvents PanelDate As System.Windows.Forms.GroupBox
    Friend WithEvents PanelInnerDate As System.Windows.Forms.Panel
    Friend WithEvents CalendarCombo1 As CalendarCombo.CalendarCombo
    Friend WithEvents CalendarCombo2 As CalendarCombo.CalendarCombo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChkDate As System.Windows.Forms.CheckBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Rdo1099 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RdoSelectedClass As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllClass As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RdoSelectedBuy As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllBuy As System.Windows.Forms.RadioButton
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents BtnBuy As System.Windows.Forms.Button
    Friend WithEvents BtnClass As System.Windows.Forms.Button
    Friend WithEvents BtnType As System.Windows.Forms.Button
    Friend WithEvents BtnVen As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DABuy As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DAClass As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DAType As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DAVendor As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmRepVendor1 As ReportEmployee.DSFrmRepVendor
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents PnlCreditType As System.Windows.Forms.Panel
    Friend WithEvents RdoAllCredit As System.Windows.Forms.RadioButton
    Friend WithEvents RdoUnApplied As System.Windows.Forms.RadioButton
    Friend WithEvents RdoApplid As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmRepVendor))
        Me.PanelSale = New System.Windows.Forms.GroupBox
        Me.PnlCreditType = New System.Windows.Forms.Panel
        Me.RdoAllCredit = New System.Windows.Forms.RadioButton
        Me.RdoUnApplied = New System.Windows.Forms.RadioButton
        Me.RdoApplid = New System.Windows.Forms.RadioButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.BtnBuy = New System.Windows.Forms.Button
        Me.RdoSelectedBuy = New System.Windows.Forms.RadioButton
        Me.RdoAllBuy = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnClass = New System.Windows.Forms.Button
        Me.RdoSelectedClass = New System.Windows.Forms.RadioButton
        Me.RdoAllClass = New System.Windows.Forms.RadioButton
        Me.PanelSaler = New System.Windows.Forms.Panel
        Me.BtnType = New System.Windows.Forms.Button
        Me.RdoSelectedType = New System.Windows.Forms.RadioButton
        Me.RdoAllType = New System.Windows.Forms.RadioButton
        Me.PanelTypeCus = New System.Windows.Forms.GroupBox
        Me.PanelDetail = New System.Windows.Forms.Panel
        Me.RdoSummery = New System.Windows.Forms.RadioButton
        Me.RdoDetail = New System.Windows.Forms.RadioButton
        Me.PanelCus = New System.Windows.Forms.Panel
        Me.Rdo1099 = New System.Windows.Forms.RadioButton
        Me.BtnVen = New System.Windows.Forms.Button
        Me.RdoSelectedVen = New System.Windows.Forms.RadioButton
        Me.RdoAllVen = New System.Windows.Forms.RadioButton
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
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnOk = New System.Windows.Forms.Button
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DABuy = New System.Data.SqlClient.SqlDataAdapter
        Me.DAClass = New System.Data.SqlClient.SqlDataAdapter
        Me.DAType = New System.Data.SqlClient.SqlDataAdapter
        Me.DAVendor = New System.Data.SqlClient.SqlDataAdapter
        Me.DsFrmRepVendor1 = New ReportEmployee.DSFrmRepVendor
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.PanelSale.SuspendLayout()
        Me.PnlCreditType.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelSaler.SuspendLayout()
        Me.PanelTypeCus.SuspendLayout()
        Me.PanelDetail.SuspendLayout()
        Me.PanelCus.SuspendLayout()
        Me.PanelDate.SuspendLayout()
        Me.PanelInnerDate.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DsFrmRepVendor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSale
        '
        Me.PanelSale.Controls.Add(Me.PnlCreditType)
        Me.PanelSale.Controls.Add(Me.Panel2)
        Me.PanelSale.Controls.Add(Me.Panel1)
        Me.PanelSale.Controls.Add(Me.PanelSaler)
        Me.PanelSale.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSale.Location = New System.Drawing.Point(0, 184)
        Me.PanelSale.Name = "PanelSale"
        Me.PanelSale.Size = New System.Drawing.Size(502, 168)
        Me.PanelSale.TabIndex = 20
        Me.PanelSale.TabStop = False
        '
        'PnlCreditType
        '
        Me.PnlCreditType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlCreditType.Controls.Add(Me.RdoAllCredit)
        Me.PnlCreditType.Controls.Add(Me.RdoUnApplied)
        Me.PnlCreditType.Controls.Add(Me.RdoApplid)
        Me.PnlCreditType.Location = New System.Drawing.Point(360, 32)
        Me.PnlCreditType.Name = "PnlCreditType"
        Me.PnlCreditType.Size = New System.Drawing.Size(128, 104)
        Me.PnlCreditType.TabIndex = 9
        '
        'RdoAllCredit
        '
        Me.RdoAllCredit.Checked = True
        Me.RdoAllCredit.Location = New System.Drawing.Point(3, 68)
        Me.RdoAllCredit.Name = "RdoAllCredit"
        Me.RdoAllCredit.Size = New System.Drawing.Size(116, 24)
        Me.RdoAllCredit.TabIndex = 2
        Me.RdoAllCredit.TabStop = True
        Me.RdoAllCredit.Text = "All Credits"
        '
        'RdoUnApplied
        '
        Me.RdoUnApplied.Location = New System.Drawing.Point(3, 38)
        Me.RdoUnApplied.Name = "RdoUnApplied"
        Me.RdoUnApplied.Size = New System.Drawing.Size(116, 24)
        Me.RdoUnApplied.TabIndex = 1
        Me.RdoUnApplied.Text = "Un-Applied Only"
        '
        'RdoApplid
        '
        Me.RdoApplid.Location = New System.Drawing.Point(3, 8)
        Me.RdoApplid.Name = "RdoApplid"
        Me.RdoApplid.Size = New System.Drawing.Size(116, 24)
        Me.RdoApplid.TabIndex = 0
        Me.RdoApplid.Text = "Applied Only"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnBuy)
        Me.Panel2.Controls.Add(Me.RdoSelectedBuy)
        Me.Panel2.Controls.Add(Me.RdoAllBuy)
        Me.Panel2.Location = New System.Drawing.Point(24, 112)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(328, 40)
        Me.Panel2.TabIndex = 8
        '
        'BtnBuy
        '
        Me.BtnBuy.Enabled = False
        Me.BtnBuy.Location = New System.Drawing.Point(240, 8)
        Me.BtnBuy.Name = "BtnBuy"
        Me.BtnBuy.TabIndex = 3
        Me.BtnBuy.Text = "Choose..."
        '
        'RdoSelectedBuy
        '
        Me.RdoSelectedBuy.Location = New System.Drawing.Point(104, 8)
        Me.RdoSelectedBuy.Name = "RdoSelectedBuy"
        Me.RdoSelectedBuy.Size = New System.Drawing.Size(112, 24)
        Me.RdoSelectedBuy.TabIndex = 1
        Me.RdoSelectedBuy.Text = "Selected Buyers"
        '
        'RdoAllBuy
        '
        Me.RdoAllBuy.Checked = True
        Me.RdoAllBuy.Location = New System.Drawing.Point(0, 8)
        Me.RdoAllBuy.Name = "RdoAllBuy"
        Me.RdoAllBuy.Size = New System.Drawing.Size(88, 24)
        Me.RdoAllBuy.TabIndex = 0
        Me.RdoAllBuy.TabStop = True
        Me.RdoAllBuy.Text = "All Buyers"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnClass)
        Me.Panel1.Controls.Add(Me.RdoSelectedClass)
        Me.Panel1.Controls.Add(Me.RdoAllClass)
        Me.Panel1.Location = New System.Drawing.Point(24, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 40)
        Me.Panel1.TabIndex = 7
        '
        'BtnClass
        '
        Me.BtnClass.Enabled = False
        Me.BtnClass.Location = New System.Drawing.Point(240, 8)
        Me.BtnClass.Name = "BtnClass"
        Me.BtnClass.TabIndex = 3
        Me.BtnClass.Text = "Choose..."
        '
        'RdoSelectedClass
        '
        Me.RdoSelectedClass.Location = New System.Drawing.Point(104, 8)
        Me.RdoSelectedClass.Name = "RdoSelectedClass"
        Me.RdoSelectedClass.Size = New System.Drawing.Size(112, 24)
        Me.RdoSelectedClass.TabIndex = 1
        Me.RdoSelectedClass.Text = "Selected Classes"
        '
        'RdoAllClass
        '
        Me.RdoAllClass.Checked = True
        Me.RdoAllClass.Location = New System.Drawing.Point(0, 8)
        Me.RdoAllClass.Name = "RdoAllClass"
        Me.RdoAllClass.Size = New System.Drawing.Size(80, 24)
        Me.RdoAllClass.TabIndex = 0
        Me.RdoAllClass.TabStop = True
        Me.RdoAllClass.Text = "All Classes"
        '
        'PanelSaler
        '
        Me.PanelSaler.Controls.Add(Me.BtnType)
        Me.PanelSaler.Controls.Add(Me.RdoSelectedType)
        Me.PanelSaler.Controls.Add(Me.RdoAllType)
        Me.PanelSaler.Location = New System.Drawing.Point(24, 16)
        Me.PanelSaler.Name = "PanelSaler"
        Me.PanelSaler.Size = New System.Drawing.Size(328, 40)
        Me.PanelSaler.TabIndex = 6
        '
        'BtnType
        '
        Me.BtnType.Enabled = False
        Me.BtnType.Location = New System.Drawing.Point(240, 8)
        Me.BtnType.Name = "BtnType"
        Me.BtnType.TabIndex = 3
        Me.BtnType.Text = "Choose..."
        '
        'RdoSelectedType
        '
        Me.RdoSelectedType.Location = New System.Drawing.Point(106, 8)
        Me.RdoSelectedType.Name = "RdoSelectedType"
        Me.RdoSelectedType.Size = New System.Drawing.Size(114, 24)
        Me.RdoSelectedType.TabIndex = 1
        Me.RdoSelectedType.Text = "Selected Types"
        '
        'RdoAllType
        '
        Me.RdoAllType.Checked = True
        Me.RdoAllType.Location = New System.Drawing.Point(0, 8)
        Me.RdoAllType.Name = "RdoAllType"
        Me.RdoAllType.Size = New System.Drawing.Size(79, 24)
        Me.RdoAllType.TabIndex = 0
        Me.RdoAllType.TabStop = True
        Me.RdoAllType.Text = "All Types"
        '
        'PanelTypeCus
        '
        Me.PanelTypeCus.Controls.Add(Me.PanelDetail)
        Me.PanelTypeCus.Controls.Add(Me.PanelCus)
        Me.PanelTypeCus.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTypeCus.Location = New System.Drawing.Point(0, 96)
        Me.PanelTypeCus.Name = "PanelTypeCus"
        Me.PanelTypeCus.Size = New System.Drawing.Size(502, 88)
        Me.PanelTypeCus.TabIndex = 19
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
        Me.PanelCus.Controls.Add(Me.Rdo1099)
        Me.PanelCus.Controls.Add(Me.BtnVen)
        Me.PanelCus.Controls.Add(Me.RdoSelectedVen)
        Me.PanelCus.Controls.Add(Me.RdoAllVen)
        Me.PanelCus.Location = New System.Drawing.Point(22, 16)
        Me.PanelCus.Name = "PanelCus"
        Me.PanelCus.Size = New System.Drawing.Size(376, 64)
        Me.PanelCus.TabIndex = 6
        '
        'Rdo1099
        '
        Me.Rdo1099.Location = New System.Drawing.Point(0, 32)
        Me.Rdo1099.Name = "Rdo1099"
        Me.Rdo1099.Size = New System.Drawing.Size(120, 24)
        Me.Rdo1099.TabIndex = 4
        Me.Rdo1099.Text = "Only 1099 Vendors"
        '
        'BtnVen
        '
        Me.BtnVen.Enabled = False
        Me.BtnVen.Location = New System.Drawing.Point(264, 16)
        Me.BtnVen.Name = "BtnVen"
        Me.BtnVen.TabIndex = 3
        Me.BtnVen.Text = "Choose..."
        '
        'RdoSelectedVen
        '
        Me.RdoSelectedVen.Location = New System.Drawing.Point(128, 8)
        Me.RdoSelectedVen.Name = "RdoSelectedVen"
        Me.RdoSelectedVen.Size = New System.Drawing.Size(120, 24)
        Me.RdoSelectedVen.TabIndex = 1
        Me.RdoSelectedVen.Text = "Selected Vendors"
        '
        'RdoAllVen
        '
        Me.RdoAllVen.Checked = True
        Me.RdoAllVen.Location = New System.Drawing.Point(0, 8)
        Me.RdoAllVen.Name = "RdoAllVen"
        Me.RdoAllVen.TabIndex = 0
        Me.RdoAllVen.TabStop = True
        Me.RdoAllVen.Text = "All Vendors"
        '
        'PanelDate
        '
        Me.PanelDate.Controls.Add(Me.PanelInnerDate)
        Me.PanelDate.Controls.Add(Me.ChkDate)
        Me.PanelDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDate.Location = New System.Drawing.Point(0, 48)
        Me.PanelDate.Name = "PanelDate"
        Me.PanelDate.Size = New System.Drawing.Size(502, 48)
        Me.PanelDate.TabIndex = 18
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
        Me.Panel4.Size = New System.Drawing.Size(502, 48)
        Me.Panel4.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Location = New System.Drawing.Point(64, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(248, 46)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Select the Vendors That you want to print"
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
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(294, 368)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.TabIndex = 22
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(142, 368)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.TabIndex = 21
        Me.BtnOk.Text = "OK"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT buyer_id AS cod, desc_buyer AS name FROM inv_buyer"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=MILAD;packet size=4096;integrated security=SSPI;data source=milad;" & _
        "persist security info=False;initial catalog=Tiremate_01"
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT class_vendor AS cod, desc_class AS name FROM inv_tab_vendor_class"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT vendor_type AS cod, desc_vendor_type AS name FROM inv_tab_vendor_type"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT cod_vendor AS cod, desc_vendor AS name FROM inv_vendor"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'DABuy
        '
        Me.DABuy.SelectCommand = Me.SqlSelectCommand1
        Me.DABuy.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_buyer", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("buyer_id", "buyer_id"), New System.Data.Common.DataColumnMapping("desc_buyer", "desc_buyer")})})
        '
        'DAClass
        '
        Me.DAClass.SelectCommand = Me.SqlSelectCommand2
        Me.DAClass.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_vendor_class", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("class_vendor", "class_vendor"), New System.Data.Common.DataColumnMapping("desc_class", "desc_class")})})
        '
        'DAType
        '
        Me.DAType.SelectCommand = Me.SqlSelectCommand3
        Me.DAType.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_vendor_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("vendor_type", "vendor_type"), New System.Data.Common.DataColumnMapping("desc_vendor_type", "desc_vendor_type"), New System.Data.Common.DataColumnMapping("GL_expense_account", "GL_expense_account")})})
        '
        'DAVendor
        '
        Me.DAVendor.SelectCommand = Me.SqlSelectCommand4
        Me.DAVendor.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_vendor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("desc_vendor", "desc_vendor"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("www", "www"), New System.Data.Common.DataColumnMapping("contact1", "contact1"), New System.Data.Common.DataColumnMapping("contact2", "contact2"), New System.Data.Common.DataColumnMapping("federal_tax_id", "federal_tax_id"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("ap_terms", "ap_terms"), New System.Data.Common.DataColumnMapping("vendor_type", "vendor_type"), New System.Data.Common.DataColumnMapping("class_vendor", "class_vendor"), New System.Data.Common.DataColumnMapping("buyer_id", "buyer_id"), New System.Data.Common.DataColumnMapping("vendor_since", "vendor_since"), New System.Data.Common.DataColumnMapping("f_1099", "f_1099"), New System.Data.Common.DataColumnMapping("on_hold", "on_hold"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("credit_limited", "credit_limited"), New System.Data.Common.DataColumnMapping("remit_to_company", "remit_to_company"), New System.Data.Common.DataColumnMapping("remit_to_address", "remit_to_address"), New System.Data.Common.DataColumnMapping("remit_to_zipcode", "remit_to_zipcode")})})
        '
        'DsFrmRepVendor1
        '
        Me.DsFrmRepVendor1.DataSetName = "DSFrmRepVendor"
        Me.DsFrmRepVendor1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'FrmRepVendor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(502, 412)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.PanelSale)
        Me.Controls.Add(Me.PanelTypeCus)
        Me.Controls.Add(Me.PanelDate)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmRepVendor"
        Me.PanelSale.ResumeLayout(False)
        Me.PnlCreditType.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.PanelSaler.ResumeLayout(False)
        Me.PanelTypeCus.ResumeLayout(False)
        Me.PanelDetail.ResumeLayout(False)
        Me.PanelCus.ResumeLayout(False)
        Me.PanelDate.ResumeLayout(False)
        Me.PanelInnerDate.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DsFrmRepVendor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim StrVen As String
    Dim StrType As String
    Dim StrClass As String
    Dim StrBuy As String
    Dim StrDate As String
    Dim ComName As String = SystemInformation.ComputerName
    Dim MKindOfReport As KindReport
    Public Enum KindReport As Integer
        Unpaid = 1
        Cash = 2
        Credit = 3
        InventoryPurchases = 4
        OutsidePurchases = 5
        Payment = 6
        VendorList = 7
        VendorBill = 8
        OutSidePurcahseCore = 9
    End Enum
    Public Property KindOfReport() As String
        Get
            Return MKindOfReport
        End Get
        Set(ByVal Value As String)
            MKindOfReport = Value
        End Set
    End Property

    Private Sub FrmRepVendor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cnn.ConnectionString = PConnectionString
        CalendarCombo1.Text = "01/01/" & PSalMali
        CalendarCombo2.Text = "12/28/" & PSalMali
        FillFormText()

    End Sub
    Private Sub FillFormText()
        PnlCreditType.Visible = False
        Select Case MKindOfReport
            Case KindReport.Unpaid
                Me.Text = " Vendor Unpaid Bills Report"
            Case KindReport.Cash
                Me.Text = " Cash Requirement Report"
            Case KindReport.Credit
                Me.Text = " Vendor Credit Report"
                PnlCreditType.Visible = True
            Case KindReport.InventoryPurchases
                Me.Text = " Vendor Inventory Purchases Report"
            Case KindReport.OutsidePurchases
                Me.Text = " Vendor Outside Purchases Report"
            Case KindReport.Payment
                Me.Text = " Vendor Payment Report"
                PnlCreditType.Visible = False
                PanelDetail.Visible = False
            Case KindReport.VendorList
                Me.Text = " Vendor Listing Report"
                PnlCreditType.Visible = False
                PanelDetail.Visible = False
            Case KindReport.VendorBill
                Me.Text = " Vendor Bills Report "
                PnlCreditType.Visible = False
            Case KindReport.OutSidePurcahseCore
                Me.Text = " Outside Purchase Cores Report"
                PanelDetail.Visible = False
                PnlCreditType.Visible = False
                Panel2.Visible = False
        End Select
    End Sub
    Private Sub ChkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDate.CheckedChanged
        If ChkDate.Checked Then
            PanelInnerDate.Enabled = False
        Else
            PanelInnerDate.Enabled = True
        End If
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub RdoAllVen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllVen.CheckedChanged, Rdo1099.CheckedChanged, RdoSelectedVen.CheckedChanged
        If RdoSelectedVen.Checked Then
            BtnVen.Enabled = True
        Else
            BtnVen.Enabled = False
        End If
    End Sub

    Private Sub RdoAllType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllType.CheckedChanged
        If RdoAllType.Checked Then
            BtnType.Enabled = False
        Else
            BtnType.Enabled = True
        End If
    End Sub

    Private Sub RdoAllClass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllClass.CheckedChanged
        If RdoAllClass.Checked Then
            BtnClass.Enabled = False
        Else
            BtnClass.Enabled = True
        End If
    End Sub
    Private Sub RdoAllBuy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllBuy.CheckedChanged
        If RdoAllBuy.Checked Then
            BtnBuy.Enabled = False
        Else
            BtnBuy.Enabled = True
        End If
    End Sub

    Private Sub BtnVen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVen.Click
        BtnVen.Enabled = False
        Dim f As New FrmSelectVendor
        If DsFrmRepVendor1.vendor.Count = 0 Then
            DAVendor.Fill(DsFrmRepVendor1.vendor)
        End If
        f.Text = "  Select Vendor"
        f.TypeOfForm = FrmSelectVendor.KindForm.Vendor
        f.DSMAIN = DsFrmRepVendor1
        f.ShowDialog()
        BtnVen.Enabled = True

    End Sub

    Private Sub BtnType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnType.Click
        BtnType.Enabled = False
        Dim f As New FrmSelectVendor
        If DsFrmRepVendor1.type.Count = 0 Then
            DAType.Fill(DsFrmRepVendor1.type)
        End If
        f.Text = "  Select Type"
        f.TypeOfForm = FrmSelectVendor.KindForm.Type
        f.DSMAIN = DsFrmRepVendor1
        f.ShowDialog()
        BtnType.Enabled = True
    End Sub

    Private Sub BtnClass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClass.Click
        BtnClass.Enabled = False
        Dim f As New FrmSelectVendor
        If DsFrmRepVendor1.clas.Count = 0 Then
            DAClass.Fill(DsFrmRepVendor1.clas)
        End If
        f.Text = "  Select Class"
        f.TypeOfForm = FrmSelectVendor.KindForm.Clas
        f.DSMAIN = DsFrmRepVendor1
        f.ShowDialog()
        BtnClass.Enabled = True
    End Sub

    Private Sub BtnBuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuy.Click
        BtnBuy.Enabled = False
        Dim f As New FrmSelectVendor
        If DsFrmRepVendor1.buyer.Count = 0 Then
            DABuy.Fill(DsFrmRepVendor1.buyer)
        End If
        f.Text = "  Select Buyers "
        f.TypeOfForm = FrmSelectVendor.KindForm.Buy
        f.DSMAIN = DsFrmRepVendor1
        f.ShowDialog()
        BtnBuy.Enabled = True

    End Sub

    Private Function ControlSelect() As Boolean
        ControlSelect = True


        Dim i As Integer


        If RdoSelectedVen.Checked Then


            If DsFrmRepVendor1.vendor.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select Vendor that you want")
                Exit Function

            Else
                Try
                    CmdGeneral.CommandText = " create table Ven_" & ComName & "(cod_vendor char(6))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Ven_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DsFrmRepVendor1.vendor.Count - 1
                    If DsFrmRepVendor1.vendor(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO Ven_" & ComName & " (cod_vendor ) VALUES (" & Qt(DsFrmRepVendor1.vendor(i).cod) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrVen = " inv_vendor.cod_vendor in (select cod_vendor  from Ven_" & ComName & ") "
            End If
        ElseIf Rdo1099.Checked Then
            StrVen = " inv_vendor.f_1099 = 1 "
        End If




        If RdoSelectedType.Checked Then


            If DsFrmRepVendor1.type.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select Type that you want")
                Exit Function

            Else
                Try
                    CmdGeneral.CommandText = " create table VenType_" & ComName & "(vendor_type char(3))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM VenType_" & ComName
                    CmdGeneral.ExecuteNonQuery()

                End Try


                For i = 0 To DsFrmRepVendor1.type.Count - 1
                    If DsFrmRepVendor1.type(i).flag Then
                        CmdGeneral.CommandText = " INSERT INTO VenType_" & ComName & " (vendor_type ) VALUES (" & Qt(DsFrmRepVendor1.type(i).cod) & ") "
                        CmdGeneral.ExecuteNonQuery()
                    End If
                Next
                StrType = "  inv_vendor.vendor_type in (select vendor_type from VenType_" & ComName & ") "
            End If
        End If




        If RdoSelectedClass.Checked Then

            If DsFrmRepVendor1.clas.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select Class that you want")
                Exit Function
            Else
                Try
                    CmdGeneral.CommandText = " create table VenClass_" & ComName & "(class_vendor char(3))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM VenClass_" & ComName
                    CmdGeneral.ExecuteNonQuery()


                End Try


                For i = 0 To DsFrmRepVendor1.clas.Count - 1
                    If DsFrmRepVendor1.clas(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO VenClass_" & ComName & " (class_vendor ) VALUES (" & Qt(DsFrmRepVendor1.clas(i).cod) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrClass = " inv_vendor.class_vendor in (select class_vendor from VenClass_" & ComName & ") "
            End If
        End If


        'If RdoSelectedPo.Checked Then
        '    If DsFrmRepTechnicians1.employee_position.Select(" flag = 1 ").Length = 0 Then
        '        ControlSelect = False
        '        MsgBox("First Select Position that you want")
        '        Exit Function
        '    End If
        'End If

        If RdoSelectedBuy.Checked Then


            If DsFrmRepVendor1.buyer.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select Buyers that you want")
                Exit Function

            Else
                Try
                    CmdGeneral.CommandText = " create table VanBuy_" & ComName & "(buyer_id char(10))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM VanBuy_" & ComName
                    CmdGeneral.ExecuteNonQuery()

                End Try


                For i = 0 To DsFrmRepVendor1.buyer.Count - 1
                    If DsFrmRepVendor1.buyer(i).flag Then
                        CmdGeneral.CommandText = " INSERT INTO VanBuy_" & ComName & " (buyer_id ) VALUES (" & Qt(DsFrmRepVendor1.buyer(i).cod) & ") "
                        CmdGeneral.ExecuteNonQuery()
                    End If
                Next
                StrBuy = " inv_vendor.buyer_id in (select buyer_id from VanBuy_" & ComName & ") "
            End If
        End If



        If Not (ChkDate.Checked) Then
            If ChangeDateToYYYYMMDD(CalendarCombo1.Text) > ChangeDateToYYYYMMDD(CalendarCombo2.Text) Then
                ControlSelect = False
                MsgBox("First Date Must Be Leaster Than Second Time")
                Exit Function
            End If

        End If


    End Function

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click

        If ControlSelect() Then
            Dim f As New FrmPrintVendor
            f.StrWhere = ""
            f.StrFilter = ""
            If Not (ChkDate.Checked) Then
                f.StrFilter = f.StrFilter & "Date, "
                f.Date1 = CalendarCombo1.Text
                f.Date2 = CalendarCombo2.Text
            Else
                f.Date1 = ""
                f.Date2 = ""
            End If
            If RdoSelectedVen.Checked Or Rdo1099.Checked Then
                f.StrFilter = f.StrFilter & "Vendor, "
                f.StrWhere = f.StrWhere & " (" & StrVen & ") and "
            End If

            If RdoSelectedType.Checked Then
                f.StrFilter = f.StrFilter & "Type, "
                f.StrWhere = f.StrWhere & " (" & StrType & ") and "
            End If

            If RdoSelectedClass.Checked Then
                f.StrFilter = f.StrFilter & "Class, "
                f.StrWhere = f.StrWhere & " (" & StrClass & ") and "
            End If

            If RdoSelectedBuy.Checked Then
                f.StrFilter = f.StrFilter & "Buyer, "
                f.StrWhere = f.StrWhere & " (" & StrBuy & ") and "
            End If

            If f.StrWhere.Trim.Length > 0 Then f.StrWhere = Mid(f.StrWhere, 1, f.StrWhere.Length - 4)
            If f.StrFilter.Trim.Length > 0 Then f.StrFilter = Mid(f.StrFilter, 1, f.StrFilter.Length - 2)
            Select Case MKindOfReport
                Case KindReport.Unpaid
                    If RdoDetail.Checked Then
                        f.KindOfReport = FrmPrintVendor.KindReport.UnpaidDetail
                    Else
                        f.KindOfReport = FrmPrintVendor.KindReport.UnpaidSummery
                    End If
                Case KindReport.Cash
                    If RdoDetail.Checked Then
                        f.KindOfReport = FrmPrintVendor.KindReport.CashDetail
                    Else
                        f.KindOfReport = FrmPrintVendor.KindReport.CashSummery
                    End If
                Case KindReport.Credit
                    If RdoApplid.Checked Then
                        f.StrWhere = f.StrWhere & IIf(f.StrWhere.Trim.Length > 0, " AND ", "")
                        f.StrWhere = f.StrWhere & " GL_vendor_credit.id_vendor_credit_head is not null "
                    ElseIf RdoUnApplied.Checked Then
                        f.StrWhere = f.StrWhere & IIf(f.StrWhere.Trim.Length > 0, " AND ", "")
                        f.StrWhere = f.StrWhere & " GL_vendor_credit.id_vendor_credit_head is null "
                    End If
                    If RdoDetail.Checked Then
                        f.KindOfReport = FrmPrintVendor.KindReport.CreditDetail
                    Else
                        f.KindOfReport = FrmPrintVendor.KindReport.CreditSummary
                    End If
                Case KindReport.InventoryPurchases
                        If RdoDetail.Checked Then
                            f.KindOfReport = FrmPrintVendor.KindReport.InventoryPurchasesDetail
                        Else
                            f.KindOfReport = FrmPrintVendor.KindReport.InventoryPurchasesSummary
                        End If
                Case KindReport.OutsidePurchases
                        If RdoDetail.Checked Then
                            f.KindOfReport = FrmPrintVendor.KindReport.OutsidePurchasesDetail
                        Else
                            f.KindOfReport = FrmPrintVendor.KindReport.OutsidePurchasesSummary
                    End If
                Case KindReport.Payment
                    f.KindOfReport = FrmPrintVendor.KindReport.Payment
                Case KindReport.VendorList
                    f.KindOfReport = FrmPrintVendor.KindReport.VendorList
                Case KindReport.VendorBill
                    If RdoDetail.Checked Then
                        f.KindOfReport = FrmPrintVendor.KindReport.vendorBillDtl
                    Else
                        f.KindOfReport = FrmPrintVendor.KindReport.VendorBillSum
                    End If
                Case KindReport.OutSidePurcahseCore
                    f.KindOfReport = FrmPrintVendor.KindReport.OutsidePurchaseCore
            End Select
            If MKindOfReport = KindReport.Payment Or MKindOfReport = KindReport.VendorList Or MKindOfReport = KindReport.OutSidePurcahseCore Then
                f.Text = Me.Text
            Else
                If RdoDetail.Checked Then
                    f.Text = Me.Text & " In Detail"
                Else
                    f.Text = Me.Text & " In Summary"
                End If
            End If
            f.ShowDialog()
            If RdoSelectedVen.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Ven_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If
            If RdoSelectedType.Checked Then
                CmdGeneral.CommandText = " DROP TABLE VenType_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If
            If RdoSelectedClass.Checked Then
                CmdGeneral.CommandText = " DROP TABLE VenClass_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If
            If RdoSelectedBuy.Checked Then
                CmdGeneral.CommandText = " DROP TABLE VanBuy_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If
        End If
    End Sub

    Private Sub PanelDate_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelDate.Enter

    End Sub
End Class
