Public Class FrmInv_line_DetailShow
    Inherits System.Windows.Forms.Form
    Public MyTop As Integer
    Public MyLeft As Integer

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
    Friend WithEvents Utqg1 As UCInv_Item.UTQG
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtoverall_score As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtRide_Comfort As System.Windows.Forms.TextBox
    Friend WithEvents txtDry_Traction As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtnud_traction As System.Windows.Forms.TextBox
    Friend WithEvents txtwinter_traction As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txthandling As System.Windows.Forms.TextBox
    Friend WithEvents txtquiet_ride As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtwet_traction As System.Windows.Forms.TextBox
    Friend WithEvents txttread_life As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DaInv_line As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents image_remark As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents Panel23 As System.Windows.Forms.Panel
    Friend WithEvents Panel24 As System.Windows.Forms.Panel
    Friend WithEvents Panel25 As System.Windows.Forms.Panel
    Friend WithEvents Panel26 As System.Windows.Forms.Panel
    Friend WithEvents Panel27 As System.Windows.Forms.Panel
    Friend WithEvents Panel28 As System.Windows.Forms.Panel
    Friend WithEvents Panel29 As System.Windows.Forms.Panel
    Friend WithEvents Panel30 As System.Windows.Forms.Panel
    Friend WithEvents Panel31 As System.Windows.Forms.Panel
    Friend WithEvents Panel32 As System.Windows.Forms.Panel
    Friend WithEvents Panel33 As System.Windows.Forms.Panel
    Friend WithEvents Panel34 As System.Windows.Forms.Panel
    Friend WithEvents Panel35 As System.Windows.Forms.Panel
    Friend WithEvents Panel36 As System.Windows.Forms.Panel
    Friend WithEvents Panel37 As System.Windows.Forms.Panel
    Friend WithEvents Panel38 As System.Windows.Forms.Panel
    Friend WithEvents Panel39 As System.Windows.Forms.Panel
    Friend WithEvents Panel40 As System.Windows.Forms.Panel
    Friend WithEvents TxtRemak As System.Windows.Forms.Label
    Friend WithEvents Txtlimit_warranty As System.Windows.Forms.Label
    Friend WithEvents CmdOk As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CmdOk = New System.Windows.Forms.Button
        Me.TxtRemak = New System.Windows.Forms.Label
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.Panel37 = New System.Windows.Forms.Panel
        Me.Panel38 = New System.Windows.Forms.Panel
        Me.Panel39 = New System.Windows.Forms.Panel
        Me.Panel40 = New System.Windows.Forms.Panel
        Me.Panel33 = New System.Windows.Forms.Panel
        Me.Panel34 = New System.Windows.Forms.Panel
        Me.Panel35 = New System.Windows.Forms.Panel
        Me.Panel36 = New System.Windows.Forms.Panel
        Me.Panel25 = New System.Windows.Forms.Panel
        Me.Panel29 = New System.Windows.Forms.Panel
        Me.Panel30 = New System.Windows.Forms.Panel
        Me.Panel31 = New System.Windows.Forms.Panel
        Me.Panel32 = New System.Windows.Forms.Panel
        Me.Panel27 = New System.Windows.Forms.Panel
        Me.Panel28 = New System.Windows.Forms.Panel
        Me.Panel26 = New System.Windows.Forms.Panel
        Me.Panel23 = New System.Windows.Forms.Panel
        Me.Panel24 = New System.Windows.Forms.Panel
        Me.Panel21 = New System.Windows.Forms.Panel
        Me.Panel22 = New System.Windows.Forms.Panel
        Me.Panel19 = New System.Windows.Forms.Panel
        Me.Panel20 = New System.Windows.Forms.Panel
        Me.Panel17 = New System.Windows.Forms.Panel
        Me.Panel18 = New System.Windows.Forms.Panel
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.txttread_life = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtwet_traction = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtquiet_ride = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txthandling = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtwinter_traction = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtnud_traction = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtDry_Traction = New System.Windows.Forms.TextBox
        Me.txtRide_Comfort = New System.Windows.Forms.TextBox
        Me.txtoverall_score = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.Txtlimit_warranty = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Utqg1 = New UCInv_Item.UTQG
        Me.image_remark = New System.Windows.Forms.PictureBox
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DaInv_line = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Panel1.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel37.SuspendLayout()
        Me.Panel38.SuspendLayout()
        Me.Panel33.SuspendLayout()
        Me.Panel34.SuspendLayout()
        Me.Panel25.SuspendLayout()
        Me.Panel29.SuspendLayout()
        Me.Panel30.SuspendLayout()
        Me.Panel27.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CmdOk)
        Me.Panel1.Controls.Add(Me.TxtRemak)
        Me.Panel1.Controls.Add(Me.Panel13)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel12)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Utqg1)
        Me.Panel1.Controls.Add(Me.image_remark)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(496, 368)
        Me.Panel1.TabIndex = 0
        '
        'CmdOk
        '
        Me.CmdOk.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdOk.Location = New System.Drawing.Point(409, 314)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.TabIndex = 381
        Me.CmdOk.Text = "Ok"
        '
        'TxtRemak
        '
        Me.TxtRemak.Location = New System.Drawing.Point(178, 6)
        Me.TxtRemak.Name = "TxtRemak"
        Me.TxtRemak.Size = New System.Drawing.Size(310, 205)
        Me.TxtRemak.TabIndex = 380
        '
        'Panel13
        '
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.Panel37)
        Me.Panel13.Controls.Add(Me.Panel33)
        Me.Panel13.Controls.Add(Me.Panel25)
        Me.Panel13.Controls.Add(Me.Panel23)
        Me.Panel13.Controls.Add(Me.Panel21)
        Me.Panel13.Controls.Add(Me.Panel19)
        Me.Panel13.Controls.Add(Me.Panel17)
        Me.Panel13.Controls.Add(Me.Panel15)
        Me.Panel13.Controls.Add(Me.txttread_life)
        Me.Panel13.Controls.Add(Me.Label38)
        Me.Panel13.Controls.Add(Me.Label31)
        Me.Panel13.Controls.Add(Me.txtwet_traction)
        Me.Panel13.Controls.Add(Me.Label12)
        Me.Panel13.Controls.Add(Me.txtquiet_ride)
        Me.Panel13.Controls.Add(Me.Label13)
        Me.Panel13.Controls.Add(Me.txthandling)
        Me.Panel13.Controls.Add(Me.Label14)
        Me.Panel13.Controls.Add(Me.txtwinter_traction)
        Me.Panel13.Controls.Add(Me.Label15)
        Me.Panel13.Controls.Add(Me.txtnud_traction)
        Me.Panel13.Controls.Add(Me.Label17)
        Me.Panel13.Controls.Add(Me.Label16)
        Me.Panel13.Controls.Add(Me.Label18)
        Me.Panel13.Controls.Add(Me.txtDry_Traction)
        Me.Panel13.Controls.Add(Me.txtRide_Comfort)
        Me.Panel13.Controls.Add(Me.txtoverall_score)
        Me.Panel13.Location = New System.Drawing.Point(16, 272)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(388, 61)
        Me.Panel13.TabIndex = 379
        '
        'Panel37
        '
        Me.Panel37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel37.Controls.Add(Me.Panel38)
        Me.Panel37.Controls.Add(Me.Panel40)
        Me.Panel37.Location = New System.Drawing.Point(343, -53)
        Me.Panel37.Name = "Panel37"
        Me.Panel37.Size = New System.Drawing.Size(1, 165)
        Me.Panel37.TabIndex = 399
        '
        'Panel38
        '
        Me.Panel38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel38.Controls.Add(Me.Panel39)
        Me.Panel38.Location = New System.Drawing.Point(8, 0)
        Me.Panel38.Name = "Panel38"
        Me.Panel38.Size = New System.Drawing.Size(1, 165)
        Me.Panel38.TabIndex = 398
        '
        'Panel39
        '
        Me.Panel39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel39.Location = New System.Drawing.Point(0, -1)
        Me.Panel39.Name = "Panel39"
        Me.Panel39.Size = New System.Drawing.Size(1, 165)
        Me.Panel39.TabIndex = 391
        '
        'Panel40
        '
        Me.Panel40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel40.Location = New System.Drawing.Point(0, -1)
        Me.Panel40.Name = "Panel40"
        Me.Panel40.Size = New System.Drawing.Size(1, 165)
        Me.Panel40.TabIndex = 391
        '
        'Panel33
        '
        Me.Panel33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel33.Controls.Add(Me.Panel34)
        Me.Panel33.Controls.Add(Me.Panel36)
        Me.Panel33.Location = New System.Drawing.Point(304, -53)
        Me.Panel33.Name = "Panel33"
        Me.Panel33.Size = New System.Drawing.Size(1, 165)
        Me.Panel33.TabIndex = 398
        '
        'Panel34
        '
        Me.Panel34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel34.Controls.Add(Me.Panel35)
        Me.Panel34.Location = New System.Drawing.Point(8, 0)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(1, 165)
        Me.Panel34.TabIndex = 398
        '
        'Panel35
        '
        Me.Panel35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel35.Location = New System.Drawing.Point(0, -1)
        Me.Panel35.Name = "Panel35"
        Me.Panel35.Size = New System.Drawing.Size(1, 165)
        Me.Panel35.TabIndex = 391
        '
        'Panel36
        '
        Me.Panel36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel36.Location = New System.Drawing.Point(0, -1)
        Me.Panel36.Name = "Panel36"
        Me.Panel36.Size = New System.Drawing.Size(1, 165)
        Me.Panel36.TabIndex = 391
        '
        'Panel25
        '
        Me.Panel25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel25.Controls.Add(Me.Panel29)
        Me.Panel25.Controls.Add(Me.Panel27)
        Me.Panel25.Controls.Add(Me.Panel26)
        Me.Panel25.Location = New System.Drawing.Point(260, -53)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(1, 165)
        Me.Panel25.TabIndex = 397
        '
        'Panel29
        '
        Me.Panel29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel29.Controls.Add(Me.Panel30)
        Me.Panel29.Controls.Add(Me.Panel32)
        Me.Panel29.Location = New System.Drawing.Point(0, 0)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(1, 165)
        Me.Panel29.TabIndex = 399
        '
        'Panel30
        '
        Me.Panel30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel30.Controls.Add(Me.Panel31)
        Me.Panel30.Location = New System.Drawing.Point(8, 0)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(1, 165)
        Me.Panel30.TabIndex = 398
        '
        'Panel31
        '
        Me.Panel31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel31.Location = New System.Drawing.Point(0, -1)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(1, 165)
        Me.Panel31.TabIndex = 391
        '
        'Panel32
        '
        Me.Panel32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel32.Location = New System.Drawing.Point(0, -1)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(1, 165)
        Me.Panel32.TabIndex = 391
        '
        'Panel27
        '
        Me.Panel27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel27.Controls.Add(Me.Panel28)
        Me.Panel27.Location = New System.Drawing.Point(8, 0)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(1, 165)
        Me.Panel27.TabIndex = 398
        '
        'Panel28
        '
        Me.Panel28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel28.Location = New System.Drawing.Point(0, -1)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(1, 165)
        Me.Panel28.TabIndex = 391
        '
        'Panel26
        '
        Me.Panel26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel26.Location = New System.Drawing.Point(0, -1)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(1, 165)
        Me.Panel26.TabIndex = 391
        '
        'Panel23
        '
        Me.Panel23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel23.Controls.Add(Me.Panel24)
        Me.Panel23.Location = New System.Drawing.Point(173, -53)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(1, 165)
        Me.Panel23.TabIndex = 396
        '
        'Panel24
        '
        Me.Panel24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel24.Location = New System.Drawing.Point(0, -1)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(1, 165)
        Me.Panel24.TabIndex = 391
        '
        'Panel21
        '
        Me.Panel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel21.Controls.Add(Me.Panel22)
        Me.Panel21.Location = New System.Drawing.Point(131, -53)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(1, 165)
        Me.Panel21.TabIndex = 395
        '
        'Panel22
        '
        Me.Panel22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel22.Location = New System.Drawing.Point(0, -1)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(1, 165)
        Me.Panel22.TabIndex = 391
        '
        'Panel19
        '
        Me.Panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel19.Controls.Add(Me.Panel20)
        Me.Panel19.Location = New System.Drawing.Point(89, -53)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(1, 165)
        Me.Panel19.TabIndex = 394
        '
        'Panel20
        '
        Me.Panel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel20.Location = New System.Drawing.Point(0, -1)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(1, 165)
        Me.Panel20.TabIndex = 391
        '
        'Panel17
        '
        Me.Panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel17.Controls.Add(Me.Panel18)
        Me.Panel17.Location = New System.Drawing.Point(44, -53)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(1, 165)
        Me.Panel17.TabIndex = 393
        '
        'Panel18
        '
        Me.Panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel18.Location = New System.Drawing.Point(0, -1)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(1, 165)
        Me.Panel18.TabIndex = 391
        '
        'Panel15
        '
        Me.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel15.Controls.Add(Me.Panel16)
        Me.Panel15.Location = New System.Drawing.Point(215, -53)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1, 165)
        Me.Panel15.TabIndex = 392
        '
        'Panel16
        '
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel16.Location = New System.Drawing.Point(0, -1)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(1, 165)
        Me.Panel16.TabIndex = 391
        '
        'txttread_life
        '
        Me.txttread_life.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttread_life.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txttread_life.Location = New System.Drawing.Point(6, 40)
        Me.txttread_life.MaxLength = 3
        Me.txttread_life.Name = "txttread_life"
        Me.txttread_life.Size = New System.Drawing.Size(33, 13)
        Me.txttread_life.TabIndex = 0
        Me.txttread_life.TabStop = False
        Me.txttread_life.Text = ""
        Me.txttread_life.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Yellow
        Me.Label38.Location = New System.Drawing.Point(2, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(46, 35)
        Me.Label38.TabIndex = 375
        Me.Label38.Text = "Tread Life"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Yellow
        Me.Label31.Location = New System.Drawing.Point(44, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(45, 35)
        Me.Label31.TabIndex = 374
        Me.Label31.Text = "Wet Traction"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtwet_traction
        '
        Me.txtwet_traction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtwet_traction.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtwet_traction.Location = New System.Drawing.Point(51, 40)
        Me.txtwet_traction.MaxLength = 3
        Me.txtwet_traction.Name = "txtwet_traction"
        Me.txtwet_traction.Size = New System.Drawing.Size(33, 13)
        Me.txtwet_traction.TabIndex = 1
        Me.txtwet_traction.TabStop = False
        Me.txtwet_traction.Text = ""
        Me.txtwet_traction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(90, -6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 41)
        Me.Label12.TabIndex = 377
        Me.Label12.Text = "Quiet Ride"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtquiet_ride
        '
        Me.txtquiet_ride.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtquiet_ride.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtquiet_ride.Location = New System.Drawing.Point(100, 40)
        Me.txtquiet_ride.MaxLength = 3
        Me.txtquiet_ride.Name = "txtquiet_ride"
        Me.txtquiet_ride.Size = New System.Drawing.Size(33, 13)
        Me.txtquiet_ride.TabIndex = 2
        Me.txtquiet_ride.TabStop = False
        Me.txtquiet_ride.Text = ""
        Me.txtquiet_ride.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(130, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 35)
        Me.Label13.TabIndex = 376
        Me.Label13.Text = "Handling"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txthandling
        '
        Me.txthandling.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txthandling.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txthandling.Location = New System.Drawing.Point(135, 40)
        Me.txthandling.MaxLength = 3
        Me.txthandling.Name = "txthandling"
        Me.txthandling.Size = New System.Drawing.Size(33, 13)
        Me.txthandling.TabIndex = 3
        Me.txthandling.TabStop = False
        Me.txthandling.Text = ""
        Me.txthandling.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(172, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 35)
        Me.Label14.TabIndex = 391
        Me.Label14.Text = "Snow Traction"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtwinter_traction
        '
        Me.txtwinter_traction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtwinter_traction.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtwinter_traction.Location = New System.Drawing.Point(173, 40)
        Me.txtwinter_traction.MaxLength = 3
        Me.txtwinter_traction.Name = "txtwinter_traction"
        Me.txtwinter_traction.Size = New System.Drawing.Size(33, 13)
        Me.txtwinter_traction.TabIndex = 4
        Me.txtwinter_traction.TabStop = False
        Me.txtwinter_traction.Text = ""
        Me.txtwinter_traction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Yellow
        Me.Label15.Location = New System.Drawing.Point(216, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 35)
        Me.Label15.TabIndex = 378
        Me.Label15.Text = "Mud Traction"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtnud_traction
        '
        Me.txtnud_traction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnud_traction.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtnud_traction.Location = New System.Drawing.Point(224, 40)
        Me.txtnud_traction.MaxLength = 3
        Me.txtnud_traction.Name = "txtnud_traction"
        Me.txtnud_traction.Size = New System.Drawing.Size(33, 13)
        Me.txtnud_traction.TabIndex = 5
        Me.txtnud_traction.TabStop = False
        Me.txtnud_traction.Text = ""
        Me.txtnud_traction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Yellow
        Me.Label17.Location = New System.Drawing.Point(302, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 35)
        Me.Label17.TabIndex = 380
        Me.Label17.Text = "Ride Comfort"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(260, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 35)
        Me.Label16.TabIndex = 381
        Me.Label16.Text = "Dry Traction"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Yellow
        Me.Label18.Location = New System.Drawing.Point(344, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 35)
        Me.Label18.TabIndex = 382
        Me.Label18.Text = "Overal Score"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDry_Traction
        '
        Me.txtDry_Traction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDry_Traction.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtDry_Traction.Location = New System.Drawing.Point(267, 40)
        Me.txtDry_Traction.MaxLength = 3
        Me.txtDry_Traction.Name = "txtDry_Traction"
        Me.txtDry_Traction.Size = New System.Drawing.Size(33, 13)
        Me.txtDry_Traction.TabIndex = 6
        Me.txtDry_Traction.TabStop = False
        Me.txtDry_Traction.Text = ""
        Me.txtDry_Traction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRide_Comfort
        '
        Me.txtRide_Comfort.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRide_Comfort.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtRide_Comfort.Location = New System.Drawing.Point(310, 40)
        Me.txtRide_Comfort.MaxLength = 3
        Me.txtRide_Comfort.Name = "txtRide_Comfort"
        Me.txtRide_Comfort.Size = New System.Drawing.Size(33, 13)
        Me.txtRide_Comfort.TabIndex = 7
        Me.txtRide_Comfort.TabStop = False
        Me.txtRide_Comfort.Text = ""
        Me.txtRide_Comfort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtoverall_score
        '
        Me.txtoverall_score.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtoverall_score.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtoverall_score.Location = New System.Drawing.Point(346, 40)
        Me.txtoverall_score.MaxLength = 3
        Me.txtoverall_score.Name = "txtoverall_score"
        Me.txtoverall_score.Size = New System.Drawing.Size(33, 13)
        Me.txtoverall_score.TabIndex = 8
        Me.txtoverall_score.TabStop = False
        Me.txtoverall_score.Text = ""
        Me.txtoverall_score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(173, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 22)
        Me.Label3.TabIndex = 378
        Me.Label3.Text = "1=Lower Performance 10= Best Performance"
        '
        'Panel12
        '
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.Txtlimit_warranty)
        Me.Panel12.Controls.Add(Me.Label2)
        Me.Panel12.Location = New System.Drawing.Point(176, 224)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(205, 28)
        Me.Panel12.TabIndex = 377
        '
        'Txtlimit_warranty
        '
        Me.Txtlimit_warranty.Location = New System.Drawing.Point(83, 5)
        Me.Txtlimit_warranty.Name = "Txtlimit_warranty"
        Me.Txtlimit_warranty.Size = New System.Drawing.Size(112, 18)
        Me.Txtlimit_warranty.TabIndex = 379
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 26)
        Me.Label2.TabIndex = 377
        Me.Label2.Text = "Limited Warranty"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(16, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Performance Raition"
        '
        'Utqg1
        '
        Me.Utqg1.Connection = Nothing
        Me.Utqg1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Utqg1.Line = ""
        Me.Utqg1.Location = New System.Drawing.Point(33, 171)
        Me.Utqg1.Name = "Utqg1"
        Me.Utqg1.Size = New System.Drawing.Size(80, 24)
        Me.Utqg1.TabIndex = 1
        '
        'image_remark
        '
        Me.image_remark.Location = New System.Drawing.Point(8, 8)
        Me.image_remark.Name = "image_remark"
        Me.image_remark.Size = New System.Drawing.Size(168, 160)
        Me.image_remark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.image_remark.TabIndex = 0
        Me.image_remark.TabStop = False
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH;packet size=4096;user id=sa;data source=""."";persist secur" & _
        "ity info=False;initial catalog=TireMate_01"
        '
        'DaInv_line
        '
        Me.DaInv_line.SelectCommand = Me.SqlSelectCommand1
        Me.DaInv_line.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_line", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("line", "line"), New System.Data.Common.DataColumnMapping("features", "features"), New System.Data.Common.DataColumnMapping("benefits", "benefits"), New System.Data.Common.DataColumnMapping("treadwear", "treadwear"), New System.Data.Common.DataColumnMapping("traction", "traction"), New System.Data.Common.DataColumnMapping("temperature", "temperature"), New System.Data.Common.DataColumnMapping("limit_warranty", "limit_warranty"), New System.Data.Common.DataColumnMapping("construction", "construction"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("image_remark", "image_remark"), New System.Data.Common.DataColumnMapping("tread_life", "tread_life"), New System.Data.Common.DataColumnMapping("wet_traction", "wet_traction"), New System.Data.Common.DataColumnMapping("quiet_ride", "quiet_ride"), New System.Data.Common.DataColumnMapping("handling", "handling"), New System.Data.Common.DataColumnMapping("winter_traction", "winter_traction"), New System.Data.Common.DataColumnMapping("nud_traction", "nud_traction"), New System.Data.Common.DataColumnMapping("overall_score", "overall_score"), New System.Data.Common.DataColumnMapping("dry_traction", "dry_traction"), New System.Data.Common.DataColumnMapping("ride_comfort", "ride_comfort")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cod_brand, style, line, features, benefits, treadwear, traction, temperatu" & _
        "re, limit_warranty, construction, remark, image_remark, tread_life, wet_traction" & _
        ", quiet_ride, handling, winter_traction, nud_traction, overall_score, dry_tracti" & _
        "on, ride_comfort FROM inv_tab_line WHERE (line = @Line)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Line", System.Data.SqlDbType.VarChar, 30, "line"))
        '
        'FrmInv_line_DetailShow
        '
        Me.AcceptButton = Me.CmdOk
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CancelButton = Me.CmdOk
        Me.ClientSize = New System.Drawing.Size(496, 368)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmInv_line_DetailShow"
        Me.Text = "FrmInv_DetailShow"
        Me.Panel1.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel37.ResumeLayout(False)
        Me.Panel38.ResumeLayout(False)
        Me.Panel33.ResumeLayout(False)
        Me.Panel34.ResumeLayout(False)
        Me.Panel25.ResumeLayout(False)
        Me.Panel29.ResumeLayout(False)
        Me.Panel30.ResumeLayout(False)
        Me.Panel27.ResumeLayout(False)
        Me.Panel23.ResumeLayout(False)
        Me.Panel21.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Event CloseMe()
    Private Sub FrmUTQGShow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = MyTop
        Me.Left = MyLeft
    End Sub
    Private Sub FrmUTQGShow_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            RaiseEvent CloseMe()
        End If
    End Sub
    Private Sub FrmUTQGShow_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        RaiseEvent CloseMe()
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Me.Close()
    End Sub
End Class
