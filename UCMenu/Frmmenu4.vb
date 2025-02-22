Public Class Frmmenu4
    Inherits FrmBaseMenu
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
    Friend WithEvents UiButton2 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton3 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton7 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton8 As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnVehicle As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnExit As Janus.Windows.EditControls.UIButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frmmenu4))
        Me.BtnVehicle = New Janus.Windows.EditControls.UIButton
        Me.UiButton2 = New Janus.Windows.EditControls.UIButton
        Me.UiButton3 = New Janus.Windows.EditControls.UIButton
        Me.UiButton7 = New Janus.Windows.EditControls.UIButton
        Me.UiButton8 = New Janus.Windows.EditControls.UIButton
        Me.BtnExit = New Janus.Windows.EditControls.UIButton
        Me.SuspendLayout()
        '
        'BtnVehicle
        '
        Me.BtnVehicle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVehicle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnVehicle.Image = CType(resources.GetObject("BtnVehicle.Image"), System.Drawing.Image)
        Me.BtnVehicle.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.BtnVehicle.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnVehicle.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.BtnVehicle.Location = New System.Drawing.Point(49, 88)
        Me.BtnVehicle.Name = "BtnVehicle"
        Me.BtnVehicle.Size = New System.Drawing.Size(97, 76)
        Me.BtnVehicle.TabIndex = 2
        Me.BtnVehicle.Text = "Vehicle"
        '
        'UiButton2
        '
        Me.UiButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UiButton2.Image = CType(resources.GetObject("UiButton2.Image"), System.Drawing.Image)
        Me.UiButton2.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.UiButton2.ImageSize = New System.Drawing.Size(32, 32)
        Me.UiButton2.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.UiButton2.Location = New System.Drawing.Point(45, 209)
        Me.UiButton2.Name = "UiButton2"
        Me.UiButton2.Size = New System.Drawing.Size(97, 77)
        Me.UiButton2.TabIndex = 3
        Me.UiButton2.Text = "Inspection Cards"
        '
        'UiButton3
        '
        Me.UiButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UiButton3.Image = CType(resources.GetObject("UiButton3.Image"), System.Drawing.Image)
        Me.UiButton3.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.UiButton3.ImageSize = New System.Drawing.Size(32, 32)
        Me.UiButton3.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.UiButton3.Location = New System.Drawing.Point(334, 90)
        Me.UiButton3.Name = "UiButton3"
        Me.UiButton3.Size = New System.Drawing.Size(96, 104)
        Me.UiButton3.TabIndex = 4
        Me.UiButton3.Text = "Service Reminders"
        '
        'UiButton7
        '
        Me.UiButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UiButton7.Image = CType(resources.GetObject("UiButton7.Image"), System.Drawing.Image)
        Me.UiButton7.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.UiButton7.ImageSize = New System.Drawing.Size(32, 32)
        Me.UiButton7.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.UiButton7.Location = New System.Drawing.Point(172, 87)
        Me.UiButton7.Name = "UiButton7"
        Me.UiButton7.Size = New System.Drawing.Size(137, 78)
        Me.UiButton7.TabIndex = 8
        Me.UiButton7.Text = "Thank You Cards"
        '
        'UiButton8
        '
        Me.UiButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UiButton8.Image = CType(resources.GetObject("UiButton8.Image"), System.Drawing.Image)
        Me.UiButton8.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.UiButton8.ImageSize = New System.Drawing.Size(32, 32)
        Me.UiButton8.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.UiButton8.Location = New System.Drawing.Point(173, 207)
        Me.UiButton8.Name = "UiButton8"
        Me.UiButton8.Size = New System.Drawing.Size(137, 78)
        Me.UiButton8.TabIndex = 9
        Me.UiButton8.Text = "Inactive Vehicle  Cards"
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit.BackColor = System.Drawing.Color.Transparent
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnExit.Location = New System.Drawing.Point(352, 234)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(64, 43)
        Me.BtnExit.TabIndex = 10
        Me.BtnExit.Text = "Exit"
        '
        'Frmmenu4
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(469, 391)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.UiButton8)
        Me.Controls.Add(Me.UiButton7)
        Me.Controls.Add(Me.UiButton3)
        Me.Controls.Add(Me.UiButton2)
        Me.Controls.Add(Me.BtnVehicle)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmmenu4"
        Me.Text = "Vehicle Menu"
        Me.Controls.SetChildIndex(Me.BtnVehicle, 0)
        Me.Controls.SetChildIndex(Me.UiButton2, 0)
        Me.Controls.SetChildIndex(Me.UiButton3, 0)
        Me.Controls.SetChildIndex(Me.UiButton7, 0)
        Me.Controls.SetChildIndex(Me.UiButton8, 0)
        Me.Controls.SetChildIndex(Me.BtnExit, 0)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
    Private Sub BtnVehicle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVehicle.Click
        Dim ThisFrmName As New UCVehicle.FrmVehicle
        SHOWMYFORM(ThisFrmName)
    End Sub
    Private Sub UiButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton3.Click
        Dim ThisFrmName As New ReportBank.FrmReminder
        SHOWMYFORM(ThisFrmName)
    End Sub

    Private Sub UiButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton7.Click
        Dim ThisFrmName As New ReportBank.FrmThankCard
        SHOWMYFORM(ThisFrmName)
    End Sub

    Private Sub UiButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton2.Click
        Dim ThisFrmName As New ReportBank.FrmInspectCard
        SHOWMYFORM(ThisFrmName)
    End Sub

    Private Sub UiButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton8.Click
        Dim ThisFrmName As New ReportBank.FrmInactiveCus
        SHOWMYFORM(ThisFrmName)
    End Sub
End Class
