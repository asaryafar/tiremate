Public Class FrmMergeVehicle
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
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents CustomerCod1 As UCCustomer.CustomerCod
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents CompanyName1 As UCCompany.CompanyName
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdClose As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents License_No1 As UCVehicle.License_No
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtYear1 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtYear2 As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents License_No2 As UCVehicle.License_No
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtMake1 As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents TxtMake2 As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents TxtModel1 As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents TxtModel2 As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents TxtCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label36 = New System.Windows.Forms.Label
        Me.CustomerCod1 = New UCCustomer.CustomerCod
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.CompanyName1 = New UCCompany.CompanyName
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdClose = New Janus.Windows.EditControls.UIButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.License_No1 = New UCVehicle.License_No
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtYear1 = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtYear2 = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.License_No2 = New UCVehicle.License_No
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtMake1 = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TxtMake2 = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TxtModel1 = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TxtModel2 = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TxtCompany = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtLName = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtFName = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label36.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label36.Location = New System.Drawing.Point(16, 16)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(53, 14)
        Me.Label36.TabIndex = 327
        Me.Label36.Text = "Customer"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CustomerCod1
        '
        Me.CustomerCod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CustomerCod1.Connection = Me.Cnn
        Me.CustomerCod1.CustomerCod = ""
        Me.CustomerCod1.CustomerCodLen = 10
        Me.CustomerCod1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CustomerCod1.Location = New System.Drawing.Point(89, 16)
        Me.CustomerCod1.Name = "CustomerCod1"
        Me.CustomerCod1.NotExitIfNotFound = False
        Me.CustomerCod1.ReleaseIfNotFoundCustomerCod = False
        Me.CustomerCod1.Size = New System.Drawing.Size(128, 21)
        Me.CustomerCod1.TabIndex = 328
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(304, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 14)
        Me.Label1.TabIndex = 329
        Me.Label1.Text = "Select Owner of Vehicles"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'CompanyName1
        '
        Me.CompanyName1.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D
        Me.CompanyName1.CompanyCod = ""
        Me.CompanyName1.CompanyCodForFind = ""
        Me.CompanyName1.CompanyComplete_Name = ""
        Me.CompanyName1.Connection = Me.Cnn
        Me.CompanyName1.Location = New System.Drawing.Point(248, 8)
        Me.CompanyName1.Name = "CompanyName1"
        Me.CompanyName1.NotExitIfNotFound = False
        Me.CompanyName1.ReleaseIfNotFoundCompanyName = False
        Me.CompanyName1.Size = New System.Drawing.Size(32, 22)
        Me.CompanyName1.TabIndex = 349
        Me.CompanyName1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(16, 264)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(544, 4)
        Me.Panel1.TabIndex = 352
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Location = New System.Drawing.Point(-2, -2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(544, 4)
        Me.Panel2.TabIndex = 353
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(16, 280)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 350
        Me.CmdOk.Text = "Save"
        '
        'CmdClose
        '
        Me.CmdClose.Location = New System.Drawing.Point(496, 280)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(75, 23)
        Me.CmdClose.TabIndex = 351
        Me.CmdClose.Text = "Exit"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Location = New System.Drawing.Point(16, 112)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(544, 4)
        Me.Panel3.TabIndex = 354
        '
        'License_No1
        '
        Me.License_No1.Cnn = Me.Cnn
        Me.License_No1.FieldCodValue = CType(0, Long)
        Me.License_No1.LicenseNoLen = 20
        Me.License_No1.Location = New System.Drawing.Point(89, 120)
        Me.License_No1.Name = "License_No1"
        Me.License_No1.Size = New System.Drawing.Size(146, 20)
        Me.License_No1.TabIndex = 355
        Me.License_No1.TxtBackColor = System.Drawing.Color.YellowGreen
        Me.License_No1.TxtForeColor = System.Drawing.SystemColors.WindowText
        Me.License_No1.TxtRightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(24, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 14)
        Me.Label4.TabIndex = 356
        Me.Label4.Text = "Main Vehicle"
        '
        'TxtYear1
        '
        Me.TxtYear1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtYear1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtYear1.DecimalDigits = 0
        Me.TxtYear1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtYear1.FormatString = "####"
        Me.TxtYear1.Location = New System.Drawing.Point(91, 150)
        Me.TxtYear1.MaxLength = 4
        Me.TxtYear1.Name = "TxtYear1"
        Me.TxtYear1.ReadOnly = True
        Me.TxtYear1.Size = New System.Drawing.Size(55, 20)
        Me.TxtYear1.TabIndex = 357
        Me.TxtYear1.TabStop = False
        Me.TxtYear1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TxtYear1.Value = CType(0, Short)
        Me.TxtYear1.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int16
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(16, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 14)
        Me.Label5.TabIndex = 358
        Me.Label5.Text = "Year"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(304, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 14)
        Me.Label6.TabIndex = 360
        Me.Label6.Text = "Make"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(304, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 14)
        Me.Label8.TabIndex = 362
        Me.Label8.Text = "Model"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(15, 185)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(544, 4)
        Me.Panel4.TabIndex = 363
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Location = New System.Drawing.Point(-2, -2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(544, 4)
        Me.Panel5.TabIndex = 353
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(303, 231)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 14)
        Me.Label9.TabIndex = 371
        Me.Label9.Text = "Model"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(303, 200)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 14)
        Me.Label10.TabIndex = 369
        Me.Label10.Text = "Make"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtYear2
        '
        Me.TxtYear2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtYear2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtYear2.DecimalDigits = 0
        Me.TxtYear2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtYear2.FormatString = "####"
        Me.TxtYear2.Location = New System.Drawing.Point(90, 224)
        Me.TxtYear2.MaxLength = 4
        Me.TxtYear2.Name = "TxtYear2"
        Me.TxtYear2.ReadOnly = True
        Me.TxtYear2.Size = New System.Drawing.Size(55, 20)
        Me.TxtYear2.TabIndex = 366
        Me.TxtYear2.TabStop = False
        Me.TxtYear2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TxtYear2.Value = CType(0, Short)
        Me.TxtYear2.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int16
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(15, 224)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 14)
        Me.Label11.TabIndex = 367
        Me.Label11.Text = "Year"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'License_No2
        '
        Me.License_No2.Cnn = Me.Cnn
        Me.License_No2.FieldCodValue = CType(0, Long)
        Me.License_No2.LicenseNoLen = 20
        Me.License_No2.Location = New System.Drawing.Point(88, 192)
        Me.License_No2.Name = "License_No2"
        Me.License_No2.Size = New System.Drawing.Size(146, 20)
        Me.License_No2.TabIndex = 364
        Me.License_No2.TxtBackColor = System.Drawing.Color.YellowGreen
        Me.License_No2.TxtForeColor = System.Drawing.SystemColors.WindowText
        Me.License_No2.TxtRightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(8, 192)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 14)
        Me.Label12.TabIndex = 365
        Me.Label12.Text = "Merge Vehicle"
        '
        'TxtMake1
        '
        Me.TxtMake1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtMake1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtMake1.Location = New System.Drawing.Point(392, 128)
        Me.TxtMake1.Name = "TxtMake1"
        Me.TxtMake1.ReadOnly = True
        Me.TxtMake1.Size = New System.Drawing.Size(176, 20)
        Me.TxtMake1.TabIndex = 372
        Me.TxtMake1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtMake2
        '
        Me.TxtMake2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtMake2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtMake2.Location = New System.Drawing.Point(392, 198)
        Me.TxtMake2.Name = "TxtMake2"
        Me.TxtMake2.ReadOnly = True
        Me.TxtMake2.Size = New System.Drawing.Size(176, 20)
        Me.TxtMake2.TabIndex = 373
        Me.TxtMake2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtModel1
        '
        Me.TxtModel1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtModel1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtModel1.Location = New System.Drawing.Point(392, 156)
        Me.TxtModel1.Name = "TxtModel1"
        Me.TxtModel1.ReadOnly = True
        Me.TxtModel1.Size = New System.Drawing.Size(176, 20)
        Me.TxtModel1.TabIndex = 374
        Me.TxtModel1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtModel2
        '
        Me.TxtModel2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtModel2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtModel2.Location = New System.Drawing.Point(392, 228)
        Me.TxtModel2.Name = "TxtModel2"
        Me.TxtModel2.ReadOnly = True
        Me.TxtModel2.Size = New System.Drawing.Size(176, 20)
        Me.TxtModel2.TabIndex = 375
        Me.TxtModel2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtCompany
        '
        Me.TxtCompany.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TxtCompany.Location = New System.Drawing.Point(88, 84)
        Me.TxtCompany.MaxLength = 20
        Me.TxtCompany.Name = "TxtCompany"
        Me.TxtCompany.ReadOnly = True
        Me.TxtCompany.Size = New System.Drawing.Size(464, 20)
        Me.TxtCompany.TabIndex = 383
        Me.TxtCompany.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(14, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 21)
        Me.Label2.TabIndex = 382
        Me.Label2.Text = "Company"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMName
        '
        Me.txtMName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtMName.Location = New System.Drawing.Point(271, 48)
        Me.txtMName.MaxLength = 15
        Me.txtMName.Name = "txtMName"
        Me.txtMName.ReadOnly = True
        Me.txtMName.Size = New System.Drawing.Size(64, 20)
        Me.txtMName.TabIndex = 377
        Me.txtMName.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(247, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 21)
        Me.Label3.TabIndex = 381
        Me.Label3.Text = "M.I."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLName
        '
        Me.txtLName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtLName.Location = New System.Drawing.Point(394, 48)
        Me.txtLName.MaxLength = 50
        Me.txtLName.Name = "txtLName"
        Me.txtLName.ReadOnly = True
        Me.txtLName.Size = New System.Drawing.Size(158, 20)
        Me.txtLName.TabIndex = 378
        Me.txtLName.Text = ""
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(362, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 21)
        Me.Label7.TabIndex = 379
        Me.Label7.Text = "Last"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFName
        '
        Me.txtFName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtFName.Location = New System.Drawing.Point(88, 48)
        Me.txtFName.MaxLength = 20
        Me.txtFName.Name = "txtFName"
        Me.txtFName.ReadOnly = True
        Me.txtFName.Size = New System.Drawing.Size(144, 20)
        Me.txtFName.TabIndex = 376
        Me.txtFName.Text = ""
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(9, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 21)
        Me.Label13.TabIndex = 380
        Me.Label13.Text = "FirstName"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmMergeVehicle
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(574, 316)
        Me.Controls.Add(Me.TxtCompany)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtModel2)
        Me.Controls.Add(Me.TxtModel1)
        Me.Controls.Add(Me.TxtMake2)
        Me.Controls.Add(Me.TxtMake1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtYear2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.License_No2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtYear1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.License_No1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.CmdClose)
        Me.Controls.Add(Me.CompanyName1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.CustomerCod1)
        Me.Name = "FrmMergeVehicle"
        Me.Text = "Merge Vehicles"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmMergeVehicle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = CommonClass.PConnectionString
    End Sub
    Private Sub CustomerCod1_FindCustomerCod() Handles CustomerCod1.FindCustomerCod
        Call ClearField()
        txtMName.Text = CustomerCod1.M_Name.Trim & ""
        txtFName.Text = CustomerCod1.F_Name.Trim & ""
        txtLName.Text = CustomerCod1.L_Name.Trim & ""
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "select abbreviation_name as companyname from cust_company where cod_company=" & CommonClass.Qt(CustomerCod1.cod_company)
        Try
            TxtCompany.Text = CmdGeneral.ExecuteScalar & ""  'CustomerCodFrom.CompanyName & ""
        Catch ex As Exception
        Finally
            CmdGeneral.Connection.Close()
        End Try
        Call FillFields(CustomerCod1.Text)
    End Sub

    Friend Function FillFields(ByVal ThisCod_Customer As String) As Boolean
        FillFields = False
        If ThisCod_Customer.Trim.Length = 0 Then
            Exit Function
        End If

        '     txtFName.Text = CustomerCod1.F_Name '& Trim(SQLReader.Item("f_name") & "")
        '      txtLName.Text = CustomerCod1.L_Name  'Trim(SQLReader.Item("l_name") & "")
        '       CompanyName1.CompanyCod = CustomerCod1.cod_company
        '        TxtCompanyName.Text = CompanyName1.CompanyAbbreviation_name
        License_No1.CodCustomerForFilter = CustomerCod1.Text
        License_No2.CodCustomerForFilter = CustomerCod1.Text
    End Function
    Sub ClearField()
        TxtMake1.Text = ""
        TxtMake2.Text = ""
        TxtModel1.Text = ""
        TxtModel2.Text = ""
        TxtYear1.Text = ""
        TxtYear2.Text = ""
    End Sub
    Private Sub License_No1_AfterFieldCodValueFind(ByVal ThisRow As System.Data.DataRow) Handles License_No1.AfterFieldCodValueFind
        TxtMake1.Text = License_No1.VehicleMake
        TxtModel1.Text = License_No1.VehicleModel
        TxtYear1.Text = License_No1.VehicleYear
    End Sub
    Private Sub License_No2_AfterFieldCodValueFind(ByVal ThisRow As System.Data.DataRow) Handles License_No2.AfterFieldCodValueFind
        TxtMake2.Text = License_No2.VehicleMake
        TxtModel2.Text = License_No2.VehicleModel
        TxtYear2.Text = License_No2.VehicleYear
    End Sub
    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub

    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        If License_No1.Text.Trim = License_No2.Text.Trim Then
            CommonClass.MsgFar("change main or merge licence no ")
            Exit Sub
        End If
        If License_No1.Text.Trim & "" = "" Or License_No2.Text.Trim & "" = "" Then
            Exit Sub
        End If



        Try
            CmdGeneral.CommandText = " update service_center_head set id_vehicle= " & License_No1.FieldCodValue & " where id_vehicle= " & License_No2.FieldCodValue & " and  cod_customer = " & CommonClass.Qt(CustomerCod1.Text) & ""
            CmdGeneral.Connection.Open()
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " delete from ser_tr_vehicle where  id_vehicle= " & License_No2.FieldCodValue & " and  cod_customer = " & CommonClass.Qt(CustomerCod1.Text) & ""
            ' CmdGeneral.Connection.Open()
            CmdGeneral.ExecuteNonQuery()

            CommonClass.MsgFar("All merging vehicle's records are succsessfully combined into the main vehicle's records")
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            CmdGeneral.Connection.Close()
        End Try

    End Sub
    Private Sub CustomerCod1_NotFindCustomerCod() Handles CustomerCod1.NotFindCustomerCod
        Call ClearField()
    End Sub
End Class
