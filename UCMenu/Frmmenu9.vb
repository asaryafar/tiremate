Public Class Frmmenu9
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
    Friend WithEvents BtnExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton7 As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnEmployees As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton4 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton2 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton3 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton5 As Janus.Windows.EditControls.UIButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frmmenu9))
        Me.BtnExit = New Janus.Windows.EditControls.UIButton
        Me.UiButton7 = New Janus.Windows.EditControls.UIButton
        Me.BtnEmployees = New Janus.Windows.EditControls.UIButton
        Me.UiButton4 = New Janus.Windows.EditControls.UIButton
        Me.UiButton2 = New Janus.Windows.EditControls.UIButton
        Me.UiButton3 = New Janus.Windows.EditControls.UIButton
        Me.UiButton5 = New Janus.Windows.EditControls.UIButton
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit.BackColor = System.Drawing.Color.Transparent
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnExit.Location = New System.Drawing.Point(378, 312)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(64, 43)
        Me.BtnExit.TabIndex = 6
        Me.BtnExit.Text = "Exit"
        '
        'UiButton7
        '
        Me.UiButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UiButton7.Image = CType(resources.GetObject("UiButton7.Image"), System.Drawing.Image)
        Me.UiButton7.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.UiButton7.ImageSize = New System.Drawing.Size(32, 32)
        Me.UiButton7.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.UiButton7.Location = New System.Drawing.Point(304, 39)
        Me.UiButton7.Name = "UiButton7"
        Me.UiButton7.Size = New System.Drawing.Size(112, 113)
        Me.UiButton7.TabIndex = 15
        Me.UiButton7.Text = "In / Out Board"
        '
        'BtnEmployees
        '
        Me.BtnEmployees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEmployees.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnEmployees.Image = CType(resources.GetObject("BtnEmployees.Image"), System.Drawing.Image)
        Me.BtnEmployees.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.BtnEmployees.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnEmployees.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.BtnEmployees.Location = New System.Drawing.Point(177, 174)
        Me.BtnEmployees.Name = "BtnEmployees"
        Me.BtnEmployees.Size = New System.Drawing.Size(112, 113)
        Me.BtnEmployees.TabIndex = 14
        Me.BtnEmployees.Text = "Clock Corrections"
        '
        'UiButton4
        '
        Me.UiButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UiButton4.Image = CType(resources.GetObject("UiButton4.Image"), System.Drawing.Image)
        Me.UiButton4.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.UiButton4.ImageSize = New System.Drawing.Size(32, 32)
        Me.UiButton4.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.UiButton4.Location = New System.Drawing.Point(174, 39)
        Me.UiButton4.Name = "UiButton4"
        Me.UiButton4.Size = New System.Drawing.Size(112, 113)
        Me.UiButton4.TabIndex = 13
        Me.UiButton4.Text = "Punch Clock"
        '
        'UiButton2
        '
        Me.UiButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UiButton2.Image = CType(resources.GetObject("UiButton2.Image"), System.Drawing.Image)
        Me.UiButton2.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.UiButton2.ImageSize = New System.Drawing.Size(32, 32)
        Me.UiButton2.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.UiButton2.Location = New System.Drawing.Point(46, 174)
        Me.UiButton2.Name = "UiButton2"
        Me.UiButton2.Size = New System.Drawing.Size(112, 113)
        Me.UiButton2.TabIndex = 12
        Me.UiButton2.Text = "Enter Employee Hours"
        '
        'UiButton3
        '
        Me.UiButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UiButton3.Image = CType(resources.GetObject("UiButton3.Image"), System.Drawing.Image)
        Me.UiButton3.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.UiButton3.ImageSize = New System.Drawing.Size(32, 32)
        Me.UiButton3.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.UiButton3.Location = New System.Drawing.Point(44, 39)
        Me.UiButton3.Name = "UiButton3"
        Me.UiButton3.Size = New System.Drawing.Size(112, 113)
        Me.UiButton3.TabIndex = 11
        Me.UiButton3.Text = "Employees"
        '
        'UiButton5
        '
        Me.UiButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UiButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UiButton5.Image = CType(resources.GetObject("UiButton5.Image"), System.Drawing.Image)
        Me.UiButton5.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.UiButton5.ImageSize = New System.Drawing.Size(32, 32)
        Me.UiButton5.ImageVerticalAlignment = Janus.Windows.EditControls.ImageVerticalAlignment.BottomOfText
        Me.UiButton5.Location = New System.Drawing.Point(306, 174)
        Me.UiButton5.Name = "UiButton5"
        Me.UiButton5.Size = New System.Drawing.Size(112, 113)
        Me.UiButton5.TabIndex = 17
        Me.UiButton5.Text = "Punch Clock Notes"
        '
        'Frmmenu9
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(468, 376)
        Me.Controls.Add(Me.UiButton5)
        Me.Controls.Add(Me.UiButton7)
        Me.Controls.Add(Me.BtnEmployees)
        Me.Controls.Add(Me.UiButton4)
        Me.Controls.Add(Me.UiButton2)
        Me.Controls.Add(Me.UiButton3)
        Me.Controls.Add(Me.BtnExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frmmenu9"
        Me.Text = "Form3"
        Me.Controls.SetChildIndex(Me.BtnExit, 0)
        Me.Controls.SetChildIndex(Me.UiButton3, 0)
        Me.Controls.SetChildIndex(Me.UiButton2, 0)
        Me.Controls.SetChildIndex(Me.UiButton4, 0)
        Me.Controls.SetChildIndex(Me.BtnEmployees, 0)
        Me.Controls.SetChildIndex(Me.UiButton7, 0)
        Me.Controls.SetChildIndex(Me.UiButton5, 0)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
    Private Sub UiButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton3.Click
        Dim ThisFrmName As New UCEmployee.FrmEmployee
        SHOWMYFORM(ThisFrmName)
    End Sub
    Private Sub UiButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton4.Click
        Dim ThisFrmName As New UCTimeSheet.FrmPunchClock
        SHOWMYFORM(ThisFrmName)
    End Sub
    Private Sub UiButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton7.Click
        Dim ThisFrmName As New UCTimeSheet.FrmEmployeeInOutBoard
        SHOWMYFORM(ThisFrmName)
    End Sub
    Private Sub UiButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton2.Click
        Dim ThisFrmName As New UCTimeSheet.FrmWeeklyTimeSheet
        SHOWMYFORM(ThisFrmName)
    End Sub
    Private Sub BtnEmployees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmployees.Click
        Dim ThisFrmName As New UCTimeSheet.FrmEmployeePunchClockCorrection
        SHOWMYFORM(ThisFrmName)
    End Sub
    Private Sub UiButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton5.Click
        Dim ar(0) As Object
        ar(0) = "308060000" ' Punch Clock In Notes
        Dim tempAssembly As System.Reflection.Assembly
        tempAssembly = System.Reflection.Assembly.LoadFrom(Application.StartupPath & "\" & "FormGenerator.dll")
        Dim t As Type = tempAssembly.GetType("FormGenerator.FrmGeneral")
        Dim c As Form = CType(Activator.CreateInstance(t, ar), Form)
        c.ShowDialog()
    End Sub
End Class
