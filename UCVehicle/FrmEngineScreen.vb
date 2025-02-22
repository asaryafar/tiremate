Imports CommonClass
Public Class FrmEngineScreen
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
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents TxtEngineType As Janus.Windows.GridEX.EditControls.EditBox
    Public WithEvents TxtSizeLiters As Janus.Windows.GridEX.EditControls.EditBox
    Public WithEvents TxtSizeCubicCM As Janus.Windows.GridEX.EditControls.EditBox
    Public WithEvents TxtCubInDisplaceMent As Janus.Windows.GridEX.EditControls.EditBox
    Public WithEvents TxtEngDesignationCode As Janus.Windows.GridEX.EditControls.EditBox
    Public WithEvents TxtAAAID As Janus.Windows.GridEX.EditControls.EditBox
    Public WithEvents TxtAspiration As Janus.Windows.GridEX.EditControls.EditBox
    Public WithEvents TxtFuelDelivery As Janus.Windows.GridEX.EditControls.EditBox
    Public WithEvents TxtFuelType As Janus.Windows.GridEX.EditControls.EditBox
    Public WithEvents TxtEngineVin As Janus.Windows.GridEX.EditControls.EditBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEngineScreen))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.TxtName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtEngineType = New Janus.Windows.GridEX.EditControls.EditBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtSizeLiters = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TxtSizeCubicCM = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TxtCubInDisplaceMent = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TxtEngDesignationCode = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TxtAAAID = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TxtEngineVin = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TxtAspiration = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TxtFuelDelivery = New Janus.Windows.GridEX.EditControls.EditBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtFuelType = New Janus.Windows.GridEX.EditControls.EditBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Panel9.SuspendLayout()
        Me.PnlSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(-2, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 15)
        Me.Label1.TabIndex = 329
        Me.Label1.Text = "Engine Type"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Window
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Controls.Add(Me.PictureBox2)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(366, 49)
        Me.Panel9.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 47)
        Me.Label5.TabIndex = 198
        Me.Label5.Text = "Engine Inùformation"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(290, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 47)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 197
        Me.PictureBox2.TabStop = False
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.YellowGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.TxtName)
        Me.PnlSearch.Controls.Add(Me.Label3)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 49)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(366, 29)
        Me.PnlSearch.TabIndex = 337
        '
        'TxtName
        '
        Me.TxtName.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.TxtName.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtName.Location = New System.Drawing.Point(45, 2)
        Me.TxtName.MaxLength = 50
        Me.TxtName.Name = "TxtName"
        Me.TxtName.ReadOnly = True
        Me.TxtName.Size = New System.Drawing.Size(314, 21)
        Me.TxtName.TabIndex = 331
        Me.TxtName.TabStop = False
        Me.TxtName.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(2, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 330
        Me.Label3.Text = "Vehicle"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtEngineType
        '
        Me.TxtEngineType.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtEngineType.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtEngineType.Location = New System.Drawing.Point(115, 84)
        Me.TxtEngineType.MaxLength = 10
        Me.TxtEngineType.Name = "TxtEngineType"
        Me.TxtEngineType.ReadOnly = True
        Me.TxtEngineType.Size = New System.Drawing.Size(87, 20)
        Me.TxtEngineType.TabIndex = 0
        Me.TxtEngineType.TabStop = False
        Me.TxtEngineType.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(-3, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 15)
        Me.Label2.TabIndex = 339
        Me.Label2.Text = "Size Liters"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(-3, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 15)
        Me.Label4.TabIndex = 341
        Me.Label4.Text = "Size - Cubic CM"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(-2, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 15)
        Me.Label6.TabIndex = 342
        Me.Label6.Text = "Cub.InDisplaceMent"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(-2, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 15)
        Me.Label7.TabIndex = 343
        Me.Label7.Text = "Eng Designation Code"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtSizeLiters
        '
        Me.TxtSizeLiters.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtSizeLiters.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtSizeLiters.Location = New System.Drawing.Point(115, 108)
        Me.TxtSizeLiters.MaxLength = 10
        Me.TxtSizeLiters.Name = "TxtSizeLiters"
        Me.TxtSizeLiters.ReadOnly = True
        Me.TxtSizeLiters.Size = New System.Drawing.Size(87, 20)
        Me.TxtSizeLiters.TabIndex = 1
        Me.TxtSizeLiters.TabStop = False
        Me.TxtSizeLiters.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtSizeCubicCM
        '
        Me.TxtSizeCubicCM.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtSizeCubicCM.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtSizeCubicCM.Location = New System.Drawing.Point(115, 132)
        Me.TxtSizeCubicCM.MaxLength = 10
        Me.TxtSizeCubicCM.Name = "TxtSizeCubicCM"
        Me.TxtSizeCubicCM.ReadOnly = True
        Me.TxtSizeCubicCM.Size = New System.Drawing.Size(87, 20)
        Me.TxtSizeCubicCM.TabIndex = 2
        Me.TxtSizeCubicCM.TabStop = False
        Me.TxtSizeCubicCM.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtCubInDisplaceMent
        '
        Me.TxtCubInDisplaceMent.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtCubInDisplaceMent.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtCubInDisplaceMent.Location = New System.Drawing.Point(115, 156)
        Me.TxtCubInDisplaceMent.MaxLength = 10
        Me.TxtCubInDisplaceMent.Name = "TxtCubInDisplaceMent"
        Me.TxtCubInDisplaceMent.ReadOnly = True
        Me.TxtCubInDisplaceMent.Size = New System.Drawing.Size(87, 20)
        Me.TxtCubInDisplaceMent.TabIndex = 3
        Me.TxtCubInDisplaceMent.TabStop = False
        Me.TxtCubInDisplaceMent.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtEngDesignationCode
        '
        Me.TxtEngDesignationCode.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtEngDesignationCode.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtEngDesignationCode.Location = New System.Drawing.Point(115, 180)
        Me.TxtEngDesignationCode.MaxLength = 10
        Me.TxtEngDesignationCode.Name = "TxtEngDesignationCode"
        Me.TxtEngDesignationCode.Size = New System.Drawing.Size(87, 20)
        Me.TxtEngDesignationCode.TabIndex = 4
        Me.TxtEngDesignationCode.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtAAAID
        '
        Me.TxtAAAID.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtAAAID.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtAAAID.Location = New System.Drawing.Point(276, 180)
        Me.TxtAAAID.MaxLength = 10
        Me.TxtAAAID.Name = "TxtAAAID"
        Me.TxtAAAID.Size = New System.Drawing.Size(87, 20)
        Me.TxtAAAID.TabIndex = 9
        Me.TxtAAAID.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtEngineVin
        '
        Me.TxtEngineVin.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtEngineVin.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtEngineVin.Location = New System.Drawing.Point(276, 156)
        Me.TxtEngineVin.MaxLength = 10
        Me.TxtEngineVin.Name = "TxtEngineVin"
        Me.TxtEngineVin.Size = New System.Drawing.Size(87, 20)
        Me.TxtEngineVin.TabIndex = 8
        Me.TxtEngineVin.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtAspiration
        '
        Me.TxtAspiration.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtAspiration.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtAspiration.Location = New System.Drawing.Point(276, 132)
        Me.TxtAspiration.MaxLength = 10
        Me.TxtAspiration.Name = "TxtAspiration"
        Me.TxtAspiration.ReadOnly = True
        Me.TxtAspiration.Size = New System.Drawing.Size(87, 20)
        Me.TxtAspiration.TabIndex = 7
        Me.TxtAspiration.TabStop = False
        Me.TxtAspiration.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtFuelDelivery
        '
        Me.TxtFuelDelivery.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtFuelDelivery.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtFuelDelivery.Location = New System.Drawing.Point(276, 108)
        Me.TxtFuelDelivery.MaxLength = 10
        Me.TxtFuelDelivery.Name = "TxtFuelDelivery"
        Me.TxtFuelDelivery.ReadOnly = True
        Me.TxtFuelDelivery.Size = New System.Drawing.Size(87, 20)
        Me.TxtFuelDelivery.TabIndex = 6
        Me.TxtFuelDelivery.TabStop = False
        Me.TxtFuelDelivery.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(204, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 15)
        Me.Label8.TabIndex = 353
        Me.Label8.Text = "AAA ID"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(203, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 15)
        Me.Label9.TabIndex = 352
        Me.Label9.Text = "Engine Vin"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(203, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 15)
        Me.Label10.TabIndex = 351
        Me.Label10.Text = "Aspiration"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(204, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 15)
        Me.Label11.TabIndex = 350
        Me.Label11.Text = "Fuel Delivery"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtFuelType
        '
        Me.TxtFuelType.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtFuelType.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtFuelType.Location = New System.Drawing.Point(276, 84)
        Me.TxtFuelType.MaxLength = 10
        Me.TxtFuelType.Name = "TxtFuelType"
        Me.TxtFuelType.ReadOnly = True
        Me.TxtFuelType.Size = New System.Drawing.Size(87, 20)
        Me.TxtFuelType.TabIndex = 5
        Me.TxtFuelType.TabStop = False
        Me.TxtFuelType.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(204, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 15)
        Me.Label12.TabIndex = 348
        Me.Label12.Text = "Fuel Type"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmEngineScreen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(366, 201)
        Me.Controls.Add(Me.TxtAAAID)
        Me.Controls.Add(Me.TxtEngineVin)
        Me.Controls.Add(Me.TxtAspiration)
        Me.Controls.Add(Me.TxtFuelDelivery)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtFuelType)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtEngDesignationCode)
        Me.Controls.Add(Me.TxtCubInDisplaceMent)
        Me.Controls.Add(Me.TxtSizeCubicCM)
        Me.Controls.Add(Me.TxtSizeLiters)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtEngineType)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.MinimizeBox = False
        Me.Name = "FrmEngineScreen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Engine Detail Screen"
        Me.Panel9.ResumeLayout(False)
        Me.PnlSearch.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmEngineScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ThisFormStatus = MainModule.WorkStates._ReadOnly Then
            Call DisableEnableAll(False)
        Else
            Call DisableEnableAll(True)
        End If
    End Sub
    Private Sub DisableEnableAll(ByVal InStatus As Boolean)
        TxtAAAID.Enabled = InStatus
        TxtAspiration.Enabled = InStatus
        TxtCubInDisplaceMent.Enabled = InStatus
        TxtEngDesignationCode.Enabled = InStatus
        TxtEngineType.Enabled = InStatus
        TxtEngineVin.Enabled = InStatus
        TxtFuelDelivery.Enabled = InStatus
        TxtFuelType.Enabled = InStatus
        TxtSizeCubicCM.Enabled = InStatus
        TxtSizeLiters.Enabled = InStatus
    End Sub
End Class
