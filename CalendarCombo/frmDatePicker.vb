Imports System.Windows.Forms
Imports System.Drawing

Public Class frmDatePicker
    Inherits System.Windows.Forms.Form

    Private lbl(42) As Label
    Private oColor As Color
    Private oEnDate As CalendarCombo
    Private bUpDown As Boolean = False
    Private m_DateValue As String
    Public myFormat As String
    Public mySlash As String

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        lbl(0) = lbl1
        lbl(1) = lbl2
        lbl(2) = lbl3
        lbl(3) = lbl4
        lbl(4) = lbl5
        lbl(5) = lbl6
        lbl(6) = lbl7
        lbl(7) = lbl8
        lbl(8) = lbl9
        lbl(9) = lbl10
        lbl(10) = lbl11
        lbl(11) = lbl12
        lbl(12) = lbl13
        lbl(13) = lbl14
        lbl(14) = lbl15
        lbl(15) = lbl16
        lbl(16) = lbl17
        lbl(17) = lbl18
        lbl(18) = lbl19
        lbl(19) = lbl20
        lbl(20) = lbl21
        lbl(21) = lbl22
        lbl(22) = lbl23
        lbl(23) = lbl24
        lbl(24) = lbl25
        lbl(25) = lbl26
        lbl(26) = lbl27
        lbl(27) = lbl28
        lbl(28) = lbl29
        lbl(29) = lbl30
        lbl(30) = lbl31
        lbl(31) = lbl32
        lbl(32) = lbl33
        lbl(33) = lbl34
        lbl(34) = lbl35
        lbl(35) = lbl36
        lbl(36) = lbl37
        lbl(37) = lbl38
        lbl(38) = lbl39
        lbl(39) = lbl40
        lbl(40) = lbl41
        lbl(41) = lbl42
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
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnNext As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnLast As Janus.Windows.EditControls.UIButton
    Friend WithEvents lblShanbeh As System.Windows.Forms.Label
    Friend WithEvents lblYekshanbeh As System.Windows.Forms.Label
    Friend WithEvents lblDoshanbeh As System.Windows.Forms.Label
    Friend WithEvents lblSeshanbeh As System.Windows.Forms.Label
    Friend WithEvents lblCharshanbeh As System.Windows.Forms.Label
    Friend WithEvents lblPanjshanbeh As System.Windows.Forms.Label
    Friend WithEvents lblJomeh As System.Windows.Forms.Label
    Friend WithEvents lblBottom As System.Windows.Forms.Label
    Friend WithEvents btnToday As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblNow As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lblSlash As System.Windows.Forms.Label
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents udYear As Janus.Windows.GridEX.EditControls.IntegerUpDown
    Friend WithEvents mnuMonth As System.Windows.Forms.ContextMenu
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents lbl7 As System.Windows.Forms.Label
    Friend WithEvents lbl8 As System.Windows.Forms.Label
    Friend WithEvents lbl9 As System.Windows.Forms.Label
    Friend WithEvents lbl10 As System.Windows.Forms.Label
    Friend WithEvents lbl11 As System.Windows.Forms.Label
    Friend WithEvents lbl12 As System.Windows.Forms.Label
    Friend WithEvents lbl13 As System.Windows.Forms.Label
    Friend WithEvents lbl14 As System.Windows.Forms.Label
    Friend WithEvents lbl15 As System.Windows.Forms.Label
    Friend WithEvents lbl16 As System.Windows.Forms.Label
    Friend WithEvents lbl17 As System.Windows.Forms.Label
    Friend WithEvents lbl18 As System.Windows.Forms.Label
    Friend WithEvents lbl19 As System.Windows.Forms.Label
    Friend WithEvents lbl20 As System.Windows.Forms.Label
    Friend WithEvents lbl21 As System.Windows.Forms.Label
    Friend WithEvents lbl36 As System.Windows.Forms.Label
    Friend WithEvents lbl37 As System.Windows.Forms.Label
    Friend WithEvents lbl38 As System.Windows.Forms.Label
    Friend WithEvents lbl39 As System.Windows.Forms.Label
    Friend WithEvents lbl40 As System.Windows.Forms.Label
    Friend WithEvents lbl41 As System.Windows.Forms.Label
    Friend WithEvents lbl42 As System.Windows.Forms.Label
    Friend WithEvents lbl29 As System.Windows.Forms.Label
    Friend WithEvents lbl30 As System.Windows.Forms.Label
    Friend WithEvents lbl31 As System.Windows.Forms.Label
    Friend WithEvents lbl32 As System.Windows.Forms.Label
    Friend WithEvents lbl33 As System.Windows.Forms.Label
    Friend WithEvents lbl34 As System.Windows.Forms.Label
    Friend WithEvents lbl35 As System.Windows.Forms.Label
    Friend WithEvents lbl22 As System.Windows.Forms.Label
    Friend WithEvents lbl23 As System.Windows.Forms.Label
    Friend WithEvents lbl24 As System.Windows.Forms.Label
    Friend WithEvents lbl25 As System.Windows.Forms.Label
    Friend WithEvents lbl26 As System.Windows.Forms.Label
    Friend WithEvents lbl27 As System.Windows.Forms.Label
    Friend WithEvents lbl28 As System.Windows.Forms.Label
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDatePicker))
        Me.lblTitle = New System.Windows.Forms.Label
        Me.btnNext = New Janus.Windows.EditControls.UIButton
        Me.btnLast = New Janus.Windows.EditControls.UIButton
        Me.lblShanbeh = New System.Windows.Forms.Label
        Me.lblYekshanbeh = New System.Windows.Forms.Label
        Me.lblDoshanbeh = New System.Windows.Forms.Label
        Me.lblSeshanbeh = New System.Windows.Forms.Label
        Me.lblCharshanbeh = New System.Windows.Forms.Label
        Me.lblPanjshanbeh = New System.Windows.Forms.Label
        Me.lblJomeh = New System.Windows.Forms.Label
        Me.lbl1 = New System.Windows.Forms.Label
        Me.lbl2 = New System.Windows.Forms.Label
        Me.lbl3 = New System.Windows.Forms.Label
        Me.lbl4 = New System.Windows.Forms.Label
        Me.lbl5 = New System.Windows.Forms.Label
        Me.lbl6 = New System.Windows.Forms.Label
        Me.lbl7 = New System.Windows.Forms.Label
        Me.lbl8 = New System.Windows.Forms.Label
        Me.lbl9 = New System.Windows.Forms.Label
        Me.lbl10 = New System.Windows.Forms.Label
        Me.lbl11 = New System.Windows.Forms.Label
        Me.lbl12 = New System.Windows.Forms.Label
        Me.lbl13 = New System.Windows.Forms.Label
        Me.lbl14 = New System.Windows.Forms.Label
        Me.lbl15 = New System.Windows.Forms.Label
        Me.lbl16 = New System.Windows.Forms.Label
        Me.lbl17 = New System.Windows.Forms.Label
        Me.lbl18 = New System.Windows.Forms.Label
        Me.lbl19 = New System.Windows.Forms.Label
        Me.lbl20 = New System.Windows.Forms.Label
        Me.lbl21 = New System.Windows.Forms.Label
        Me.lbl36 = New System.Windows.Forms.Label
        Me.lbl37 = New System.Windows.Forms.Label
        Me.lbl38 = New System.Windows.Forms.Label
        Me.lbl39 = New System.Windows.Forms.Label
        Me.lbl40 = New System.Windows.Forms.Label
        Me.lbl41 = New System.Windows.Forms.Label
        Me.lbl42 = New System.Windows.Forms.Label
        Me.lbl29 = New System.Windows.Forms.Label
        Me.lbl30 = New System.Windows.Forms.Label
        Me.lbl31 = New System.Windows.Forms.Label
        Me.lbl32 = New System.Windows.Forms.Label
        Me.lbl33 = New System.Windows.Forms.Label
        Me.lbl34 = New System.Windows.Forms.Label
        Me.lbl35 = New System.Windows.Forms.Label
        Me.lbl22 = New System.Windows.Forms.Label
        Me.lbl23 = New System.Windows.Forms.Label
        Me.lbl24 = New System.Windows.Forms.Label
        Me.lbl25 = New System.Windows.Forms.Label
        Me.lbl26 = New System.Windows.Forms.Label
        Me.lbl27 = New System.Windows.Forms.Label
        Me.lbl28 = New System.Windows.Forms.Label
        Me.lblBottom = New System.Windows.Forms.Label
        Me.btnToday = New Janus.Windows.EditControls.UIButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblNow = New System.Windows.Forms.Label
        Me.lblYear = New System.Windows.Forms.Label
        Me.lblSlash = New System.Windows.Forms.Label
        Me.lblMonth = New System.Windows.Forms.Label
        Me.udYear = New Janus.Windows.GridEX.EditControls.IntegerUpDown
        Me.mnuMonth = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(203, 26)
        Me.lblTitle.TabIndex = 0
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.Appearance = Janus.Windows.UI.Appearance.Flat
        Me.btnNext.FlatBorderColor = System.Drawing.SystemColors.Desktop
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.Location = New System.Drawing.Point(179, 5)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(20, 18)
        Me.btnNext.TabIndex = 1
        Me.btnNext.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnLast
        '
        Me.btnLast.Appearance = Janus.Windows.UI.Appearance.Flat
        Me.btnLast.FlatBorderColor = System.Drawing.SystemColors.Desktop
        Me.btnLast.Image = CType(resources.GetObject("btnLast.Image"), System.Drawing.Image)
        Me.btnLast.Location = New System.Drawing.Point(4, 5)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(20, 18)
        Me.btnLast.TabIndex = 2
        Me.btnLast.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'lblShanbeh
        '
        Me.lblShanbeh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblShanbeh.BackColor = System.Drawing.Color.Bisque
        Me.lblShanbeh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblShanbeh.Location = New System.Drawing.Point(175, 27)
        Me.lblShanbeh.Name = "lblShanbeh"
        Me.lblShanbeh.Size = New System.Drawing.Size(28, 17)
        Me.lblShanbeh.TabIndex = 3
        Me.lblShanbeh.Text = "S"
        Me.lblShanbeh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYekshanbeh
        '
        Me.lblYekshanbeh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblYekshanbeh.BackColor = System.Drawing.Color.Bisque
        Me.lblYekshanbeh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblYekshanbeh.Location = New System.Drawing.Point(146, 27)
        Me.lblYekshanbeh.Name = "lblYekshanbeh"
        Me.lblYekshanbeh.Size = New System.Drawing.Size(28, 17)
        Me.lblYekshanbeh.TabIndex = 4
        Me.lblYekshanbeh.Text = "F"
        Me.lblYekshanbeh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDoshanbeh
        '
        Me.lblDoshanbeh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDoshanbeh.BackColor = System.Drawing.Color.Bisque
        Me.lblDoshanbeh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblDoshanbeh.Location = New System.Drawing.Point(117, 27)
        Me.lblDoshanbeh.Name = "lblDoshanbeh"
        Me.lblDoshanbeh.Size = New System.Drawing.Size(28, 17)
        Me.lblDoshanbeh.TabIndex = 5
        Me.lblDoshanbeh.Text = "T"
        Me.lblDoshanbeh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSeshanbeh
        '
        Me.lblSeshanbeh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSeshanbeh.BackColor = System.Drawing.Color.Bisque
        Me.lblSeshanbeh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblSeshanbeh.Location = New System.Drawing.Point(88, 27)
        Me.lblSeshanbeh.Name = "lblSeshanbeh"
        Me.lblSeshanbeh.Size = New System.Drawing.Size(28, 17)
        Me.lblSeshanbeh.TabIndex = 6
        Me.lblSeshanbeh.Text = "W"
        Me.lblSeshanbeh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCharshanbeh
        '
        Me.lblCharshanbeh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCharshanbeh.BackColor = System.Drawing.Color.Bisque
        Me.lblCharshanbeh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblCharshanbeh.Location = New System.Drawing.Point(59, 27)
        Me.lblCharshanbeh.Name = "lblCharshanbeh"
        Me.lblCharshanbeh.Size = New System.Drawing.Size(28, 17)
        Me.lblCharshanbeh.TabIndex = 7
        Me.lblCharshanbeh.Text = "T"
        Me.lblCharshanbeh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPanjshanbeh
        '
        Me.lblPanjshanbeh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPanjshanbeh.BackColor = System.Drawing.Color.Bisque
        Me.lblPanjshanbeh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblPanjshanbeh.Location = New System.Drawing.Point(30, 27)
        Me.lblPanjshanbeh.Name = "lblPanjshanbeh"
        Me.lblPanjshanbeh.Size = New System.Drawing.Size(28, 17)
        Me.lblPanjshanbeh.TabIndex = 8
        Me.lblPanjshanbeh.Text = "M"
        Me.lblPanjshanbeh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJomeh
        '
        Me.lblJomeh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblJomeh.BackColor = System.Drawing.Color.Bisque
        Me.lblJomeh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblJomeh.ForeColor = System.Drawing.Color.Black
        Me.lblJomeh.Location = New System.Drawing.Point(0, 27)
        Me.lblJomeh.Name = "lblJomeh"
        Me.lblJomeh.Size = New System.Drawing.Size(29, 17)
        Me.lblJomeh.TabIndex = 9
        Me.lblJomeh.Text = "S"
        Me.lblJomeh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl1
        '
        Me.lbl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl1.BackColor = System.Drawing.Color.Snow
        Me.lbl1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(0, 45)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(29, 17)
        Me.lbl1.TabIndex = 16
        Me.lbl1.Text = "31"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2
        '
        Me.lbl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl2.BackColor = System.Drawing.Color.Snow
        Me.lbl2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl2.Location = New System.Drawing.Point(30, 45)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(28, 17)
        Me.lbl2.TabIndex = 15
        Me.lbl2.Text = "31"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl3
        '
        Me.lbl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl3.BackColor = System.Drawing.Color.Snow
        Me.lbl3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl3.Location = New System.Drawing.Point(59, 45)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(28, 17)
        Me.lbl3.TabIndex = 14
        Me.lbl3.Text = "31"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl4
        '
        Me.lbl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl4.BackColor = System.Drawing.Color.Snow
        Me.lbl4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl4.Location = New System.Drawing.Point(88, 45)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(28, 17)
        Me.lbl4.TabIndex = 13
        Me.lbl4.Text = "31"
        Me.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl5
        '
        Me.lbl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl5.BackColor = System.Drawing.Color.Snow
        Me.lbl5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl5.Location = New System.Drawing.Point(117, 45)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(28, 17)
        Me.lbl5.TabIndex = 12
        Me.lbl5.Text = "31"
        Me.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl6
        '
        Me.lbl6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl6.BackColor = System.Drawing.Color.Snow
        Me.lbl6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl6.Location = New System.Drawing.Point(146, 45)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(28, 17)
        Me.lbl6.TabIndex = 11
        Me.lbl6.Text = "31"
        Me.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl7
        '
        Me.lbl7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl7.BackColor = System.Drawing.Color.Snow
        Me.lbl7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl7.Location = New System.Drawing.Point(175, 45)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(28, 17)
        Me.lbl7.TabIndex = 10
        Me.lbl7.Text = "31"
        Me.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl8
        '
        Me.lbl8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl8.BackColor = System.Drawing.Color.Snow
        Me.lbl8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl8.ForeColor = System.Drawing.Color.Black
        Me.lbl8.Location = New System.Drawing.Point(0, 63)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(29, 17)
        Me.lbl8.TabIndex = 23
        Me.lbl8.Text = "31"
        Me.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl9
        '
        Me.lbl9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl9.BackColor = System.Drawing.Color.Snow
        Me.lbl9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl9.Location = New System.Drawing.Point(30, 63)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(28, 17)
        Me.lbl9.TabIndex = 22
        Me.lbl9.Text = "31"
        Me.lbl9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl10
        '
        Me.lbl10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl10.BackColor = System.Drawing.Color.Snow
        Me.lbl10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl10.Location = New System.Drawing.Point(59, 63)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(28, 17)
        Me.lbl10.TabIndex = 21
        Me.lbl10.Text = "31"
        Me.lbl10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl11
        '
        Me.lbl11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl11.BackColor = System.Drawing.Color.Snow
        Me.lbl11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl11.Location = New System.Drawing.Point(88, 63)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(28, 17)
        Me.lbl11.TabIndex = 20
        Me.lbl11.Text = "31"
        Me.lbl11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl12
        '
        Me.lbl12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl12.BackColor = System.Drawing.Color.Snow
        Me.lbl12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl12.Location = New System.Drawing.Point(117, 63)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(28, 17)
        Me.lbl12.TabIndex = 19
        Me.lbl12.Text = "31"
        Me.lbl12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl13
        '
        Me.lbl13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl13.BackColor = System.Drawing.Color.Snow
        Me.lbl13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl13.Location = New System.Drawing.Point(146, 63)
        Me.lbl13.Name = "lbl13"
        Me.lbl13.Size = New System.Drawing.Size(28, 17)
        Me.lbl13.TabIndex = 18
        Me.lbl13.Text = "31"
        Me.lbl13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl14
        '
        Me.lbl14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl14.BackColor = System.Drawing.Color.Snow
        Me.lbl14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl14.Location = New System.Drawing.Point(175, 63)
        Me.lbl14.Name = "lbl14"
        Me.lbl14.Size = New System.Drawing.Size(28, 17)
        Me.lbl14.TabIndex = 17
        Me.lbl14.Text = "31"
        Me.lbl14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl15
        '
        Me.lbl15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl15.BackColor = System.Drawing.Color.Snow
        Me.lbl15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl15.ForeColor = System.Drawing.Color.Black
        Me.lbl15.Location = New System.Drawing.Point(0, 81)
        Me.lbl15.Name = "lbl15"
        Me.lbl15.Size = New System.Drawing.Size(29, 17)
        Me.lbl15.TabIndex = 30
        Me.lbl15.Text = "31"
        Me.lbl15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl16
        '
        Me.lbl16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl16.BackColor = System.Drawing.Color.Snow
        Me.lbl16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl16.Location = New System.Drawing.Point(30, 81)
        Me.lbl16.Name = "lbl16"
        Me.lbl16.Size = New System.Drawing.Size(28, 17)
        Me.lbl16.TabIndex = 29
        Me.lbl16.Text = "31"
        Me.lbl16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl17
        '
        Me.lbl17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl17.BackColor = System.Drawing.Color.Snow
        Me.lbl17.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl17.Location = New System.Drawing.Point(59, 81)
        Me.lbl17.Name = "lbl17"
        Me.lbl17.Size = New System.Drawing.Size(28, 17)
        Me.lbl17.TabIndex = 28
        Me.lbl17.Text = "31"
        Me.lbl17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl18
        '
        Me.lbl18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl18.BackColor = System.Drawing.Color.Snow
        Me.lbl18.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl18.Location = New System.Drawing.Point(88, 81)
        Me.lbl18.Name = "lbl18"
        Me.lbl18.Size = New System.Drawing.Size(28, 17)
        Me.lbl18.TabIndex = 27
        Me.lbl18.Text = "31"
        Me.lbl18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl19
        '
        Me.lbl19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl19.BackColor = System.Drawing.Color.Snow
        Me.lbl19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl19.Location = New System.Drawing.Point(117, 81)
        Me.lbl19.Name = "lbl19"
        Me.lbl19.Size = New System.Drawing.Size(28, 17)
        Me.lbl19.TabIndex = 26
        Me.lbl19.Text = "31"
        Me.lbl19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl20
        '
        Me.lbl20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl20.BackColor = System.Drawing.Color.Snow
        Me.lbl20.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl20.Location = New System.Drawing.Point(146, 81)
        Me.lbl20.Name = "lbl20"
        Me.lbl20.Size = New System.Drawing.Size(28, 17)
        Me.lbl20.TabIndex = 25
        Me.lbl20.Text = "31"
        Me.lbl20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl21
        '
        Me.lbl21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl21.BackColor = System.Drawing.Color.Snow
        Me.lbl21.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl21.Location = New System.Drawing.Point(175, 81)
        Me.lbl21.Name = "lbl21"
        Me.lbl21.Size = New System.Drawing.Size(28, 17)
        Me.lbl21.TabIndex = 24
        Me.lbl21.Text = "31"
        Me.lbl21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl36
        '
        Me.lbl36.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl36.BackColor = System.Drawing.Color.Snow
        Me.lbl36.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl36.ForeColor = System.Drawing.Color.Black
        Me.lbl36.Location = New System.Drawing.Point(0, 135)
        Me.lbl36.Name = "lbl36"
        Me.lbl36.Size = New System.Drawing.Size(29, 17)
        Me.lbl36.TabIndex = 51
        Me.lbl36.Text = "31"
        Me.lbl36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl37
        '
        Me.lbl37.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl37.BackColor = System.Drawing.Color.Snow
        Me.lbl37.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl37.Location = New System.Drawing.Point(30, 135)
        Me.lbl37.Name = "lbl37"
        Me.lbl37.Size = New System.Drawing.Size(28, 17)
        Me.lbl37.TabIndex = 50
        Me.lbl37.Text = "31"
        Me.lbl37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl38
        '
        Me.lbl38.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl38.BackColor = System.Drawing.Color.Snow
        Me.lbl38.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl38.Location = New System.Drawing.Point(59, 135)
        Me.lbl38.Name = "lbl38"
        Me.lbl38.Size = New System.Drawing.Size(28, 17)
        Me.lbl38.TabIndex = 49
        Me.lbl38.Text = "31"
        Me.lbl38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl39
        '
        Me.lbl39.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl39.BackColor = System.Drawing.Color.Snow
        Me.lbl39.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl39.Location = New System.Drawing.Point(88, 135)
        Me.lbl39.Name = "lbl39"
        Me.lbl39.Size = New System.Drawing.Size(28, 17)
        Me.lbl39.TabIndex = 48
        Me.lbl39.Text = "31"
        Me.lbl39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl40
        '
        Me.lbl40.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl40.BackColor = System.Drawing.Color.Snow
        Me.lbl40.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl40.Location = New System.Drawing.Point(117, 135)
        Me.lbl40.Name = "lbl40"
        Me.lbl40.Size = New System.Drawing.Size(28, 17)
        Me.lbl40.TabIndex = 47
        Me.lbl40.Text = "31"
        Me.lbl40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl41
        '
        Me.lbl41.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl41.BackColor = System.Drawing.Color.Snow
        Me.lbl41.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl41.Location = New System.Drawing.Point(146, 135)
        Me.lbl41.Name = "lbl41"
        Me.lbl41.Size = New System.Drawing.Size(28, 17)
        Me.lbl41.TabIndex = 46
        Me.lbl41.Text = "31"
        Me.lbl41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl42
        '
        Me.lbl42.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl42.BackColor = System.Drawing.Color.Snow
        Me.lbl42.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl42.Location = New System.Drawing.Point(175, 135)
        Me.lbl42.Name = "lbl42"
        Me.lbl42.Size = New System.Drawing.Size(28, 17)
        Me.lbl42.TabIndex = 45
        Me.lbl42.Text = "31"
        Me.lbl42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl29
        '
        Me.lbl29.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl29.BackColor = System.Drawing.Color.Snow
        Me.lbl29.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl29.ForeColor = System.Drawing.Color.Black
        Me.lbl29.Location = New System.Drawing.Point(0, 117)
        Me.lbl29.Name = "lbl29"
        Me.lbl29.Size = New System.Drawing.Size(29, 17)
        Me.lbl29.TabIndex = 44
        Me.lbl29.Text = "31"
        Me.lbl29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl30
        '
        Me.lbl30.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl30.BackColor = System.Drawing.Color.Snow
        Me.lbl30.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl30.Location = New System.Drawing.Point(30, 117)
        Me.lbl30.Name = "lbl30"
        Me.lbl30.Size = New System.Drawing.Size(28, 17)
        Me.lbl30.TabIndex = 43
        Me.lbl30.Text = "31"
        Me.lbl30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl31
        '
        Me.lbl31.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl31.BackColor = System.Drawing.Color.Snow
        Me.lbl31.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl31.Location = New System.Drawing.Point(59, 117)
        Me.lbl31.Name = "lbl31"
        Me.lbl31.Size = New System.Drawing.Size(28, 17)
        Me.lbl31.TabIndex = 42
        Me.lbl31.Text = "31"
        Me.lbl31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl32
        '
        Me.lbl32.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl32.BackColor = System.Drawing.Color.Snow
        Me.lbl32.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl32.Location = New System.Drawing.Point(88, 117)
        Me.lbl32.Name = "lbl32"
        Me.lbl32.Size = New System.Drawing.Size(28, 17)
        Me.lbl32.TabIndex = 41
        Me.lbl32.Text = "31"
        Me.lbl32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl33
        '
        Me.lbl33.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl33.BackColor = System.Drawing.Color.Snow
        Me.lbl33.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl33.Location = New System.Drawing.Point(117, 117)
        Me.lbl33.Name = "lbl33"
        Me.lbl33.Size = New System.Drawing.Size(28, 17)
        Me.lbl33.TabIndex = 40
        Me.lbl33.Text = "31"
        Me.lbl33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl34
        '
        Me.lbl34.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl34.BackColor = System.Drawing.Color.Snow
        Me.lbl34.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl34.Location = New System.Drawing.Point(146, 117)
        Me.lbl34.Name = "lbl34"
        Me.lbl34.Size = New System.Drawing.Size(28, 17)
        Me.lbl34.TabIndex = 39
        Me.lbl34.Text = "31"
        Me.lbl34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl35
        '
        Me.lbl35.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl35.BackColor = System.Drawing.Color.Snow
        Me.lbl35.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl35.Location = New System.Drawing.Point(175, 117)
        Me.lbl35.Name = "lbl35"
        Me.lbl35.Size = New System.Drawing.Size(28, 17)
        Me.lbl35.TabIndex = 38
        Me.lbl35.Text = "31"
        Me.lbl35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl22
        '
        Me.lbl22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl22.BackColor = System.Drawing.Color.Snow
        Me.lbl22.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl22.ForeColor = System.Drawing.Color.Black
        Me.lbl22.Location = New System.Drawing.Point(0, 99)
        Me.lbl22.Name = "lbl22"
        Me.lbl22.Size = New System.Drawing.Size(29, 17)
        Me.lbl22.TabIndex = 37
        Me.lbl22.Text = "31"
        Me.lbl22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl23
        '
        Me.lbl23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl23.BackColor = System.Drawing.Color.Snow
        Me.lbl23.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl23.Location = New System.Drawing.Point(30, 99)
        Me.lbl23.Name = "lbl23"
        Me.lbl23.Size = New System.Drawing.Size(28, 17)
        Me.lbl23.TabIndex = 36
        Me.lbl23.Text = "31"
        Me.lbl23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl24
        '
        Me.lbl24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl24.BackColor = System.Drawing.Color.Snow
        Me.lbl24.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl24.Location = New System.Drawing.Point(59, 99)
        Me.lbl24.Name = "lbl24"
        Me.lbl24.Size = New System.Drawing.Size(28, 17)
        Me.lbl24.TabIndex = 35
        Me.lbl24.Text = "31"
        Me.lbl24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl25
        '
        Me.lbl25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl25.BackColor = System.Drawing.Color.Snow
        Me.lbl25.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl25.Location = New System.Drawing.Point(88, 99)
        Me.lbl25.Name = "lbl25"
        Me.lbl25.Size = New System.Drawing.Size(28, 17)
        Me.lbl25.TabIndex = 34
        Me.lbl25.Text = "31"
        Me.lbl25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl26
        '
        Me.lbl26.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl26.BackColor = System.Drawing.Color.Snow
        Me.lbl26.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl26.Location = New System.Drawing.Point(117, 99)
        Me.lbl26.Name = "lbl26"
        Me.lbl26.Size = New System.Drawing.Size(28, 17)
        Me.lbl26.TabIndex = 33
        Me.lbl26.Text = "31"
        Me.lbl26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl27
        '
        Me.lbl27.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl27.BackColor = System.Drawing.Color.Snow
        Me.lbl27.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl27.Location = New System.Drawing.Point(146, 99)
        Me.lbl27.Name = "lbl27"
        Me.lbl27.Size = New System.Drawing.Size(28, 17)
        Me.lbl27.TabIndex = 32
        Me.lbl27.Text = "31"
        Me.lbl27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl28
        '
        Me.lbl28.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl28.BackColor = System.Drawing.Color.Snow
        Me.lbl28.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl28.Location = New System.Drawing.Point(175, 99)
        Me.lbl28.Name = "lbl28"
        Me.lbl28.Size = New System.Drawing.Size(28, 17)
        Me.lbl28.TabIndex = 31
        Me.lbl28.Text = "31"
        Me.lbl28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBottom
        '
        Me.lblBottom.Location = New System.Drawing.Point(0, 156)
        Me.lblBottom.Name = "lblBottom"
        Me.lblBottom.Size = New System.Drawing.Size(203, 28)
        Me.lblBottom.TabIndex = 52
        '
        'btnToday
        '
        Me.btnToday.Appearance = Janus.Windows.UI.Appearance.Flat
        Me.btnToday.FlatBorderColor = System.Drawing.Color.SaddleBrown
        Me.btnToday.Location = New System.Drawing.Point(148, 156)
        Me.btnToday.Name = "btnToday"
        Me.btnToday.Size = New System.Drawing.Size(55, 20)
        Me.btnToday.TabIndex = 53
        Me.btnToday.Text = "Today"
        Me.btnToday.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RosyBrown
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(203, 176)
        Me.Panel1.TabIndex = 54
        '
        'lblNow
        '
        Me.lblNow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblNow.Location = New System.Drawing.Point(0, 156)
        Me.lblNow.Name = "lblNow"
        Me.lblNow.Size = New System.Drawing.Size(70, 20)
        Me.lblNow.TabIndex = 55
        Me.lblNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYear
        '
        Me.lblYear.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblYear.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblYear.Location = New System.Drawing.Point(73, 4)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(33, 19)
        Me.lblYear.TabIndex = 56
        Me.lblYear.Text = "1384"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSlash
        '
        Me.lblSlash.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblSlash.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblSlash.Location = New System.Drawing.Point(105, 6)
        Me.lblSlash.Name = "lblSlash"
        Me.lblSlash.Size = New System.Drawing.Size(7, 15)
        Me.lblSlash.TabIndex = 57
        Me.lblSlash.Text = "/"
        Me.lblSlash.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblMonth
        '
        Me.lblMonth.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblMonth.ContextMenu = Me.mnuMonth
        Me.lblMonth.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(111, 4)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(19, 19)
        Me.lblMonth.TabIndex = 58
        Me.lblMonth.Text = "12"
        Me.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'udYear
        '
        Me.udYear.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.udYear.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.udYear.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.udYear.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.udYear.Location = New System.Drawing.Point(56, 2)
        Me.udYear.Maximum = 2500
        Me.udYear.MaxLength = 4
        Me.udYear.Minimum = 1800
        Me.udYear.Name = "udYear"
        Me.udYear.Size = New System.Drawing.Size(48, 22)
        Me.udYear.TabIndex = 59
        Me.udYear.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.udYear.Value = 2005
        Me.udYear.Visible = False
        Me.udYear.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'mnuMonth
        '
        Me.mnuMonth.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7, Me.MenuItem8, Me.MenuItem9, Me.MenuItem10, Me.MenuItem11, Me.MenuItem12})
        '
        'MenuItem1
        '
        Me.MenuItem1.Checked = True
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MergeOrder = 1
        Me.MenuItem1.ShowShortcut = False
        Me.MenuItem1.Text = "January"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MergeOrder = 2
        Me.MenuItem2.ShowShortcut = False
        Me.MenuItem2.Text = "February"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.MergeOrder = 3
        Me.MenuItem3.ShowShortcut = False
        Me.MenuItem3.Text = "March"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.MergeOrder = 4
        Me.MenuItem4.ShowShortcut = False
        Me.MenuItem4.Text = "April"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.MergeOrder = 5
        Me.MenuItem5.ShowShortcut = False
        Me.MenuItem5.Text = "May"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 5
        Me.MenuItem6.MergeOrder = 6
        Me.MenuItem6.ShowShortcut = False
        Me.MenuItem6.Text = "June"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 6
        Me.MenuItem7.MergeOrder = 7
        Me.MenuItem7.ShowShortcut = False
        Me.MenuItem7.Text = "July"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 7
        Me.MenuItem8.MergeOrder = 8
        Me.MenuItem8.ShowShortcut = False
        Me.MenuItem8.Text = "August"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 8
        Me.MenuItem9.MergeOrder = 9
        Me.MenuItem9.ShowShortcut = False
        Me.MenuItem9.Text = "September"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 9
        Me.MenuItem10.MergeOrder = 10
        Me.MenuItem10.ShowShortcut = False
        Me.MenuItem10.Text = "October"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 10
        Me.MenuItem11.MergeOrder = 11
        Me.MenuItem11.ShowShortcut = False
        Me.MenuItem11.Text = "November"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 11
        Me.MenuItem12.MergeOrder = 12
        Me.MenuItem12.ShowShortcut = False
        Me.MenuItem12.Text = "December"
        '
        'frmDatePicker
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(203, 176)
        Me.ControlBox = False
        Me.Controls.Add(Me.udYear)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblSlash)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblNow)
        Me.Controls.Add(Me.btnToday)
        Me.Controls.Add(Me.lblBottom)
        Me.Controls.Add(Me.lbl36)
        Me.Controls.Add(Me.lbl37)
        Me.Controls.Add(Me.lbl38)
        Me.Controls.Add(Me.lbl39)
        Me.Controls.Add(Me.lbl40)
        Me.Controls.Add(Me.lbl41)
        Me.Controls.Add(Me.lbl42)
        Me.Controls.Add(Me.lbl29)
        Me.Controls.Add(Me.lbl30)
        Me.Controls.Add(Me.lbl31)
        Me.Controls.Add(Me.lbl32)
        Me.Controls.Add(Me.lbl33)
        Me.Controls.Add(Me.lbl34)
        Me.Controls.Add(Me.lbl35)
        Me.Controls.Add(Me.lbl22)
        Me.Controls.Add(Me.lbl23)
        Me.Controls.Add(Me.lbl24)
        Me.Controls.Add(Me.lbl25)
        Me.Controls.Add(Me.lbl26)
        Me.Controls.Add(Me.lbl27)
        Me.Controls.Add(Me.lbl28)
        Me.Controls.Add(Me.lbl15)
        Me.Controls.Add(Me.lbl16)
        Me.Controls.Add(Me.lbl17)
        Me.Controls.Add(Me.lbl18)
        Me.Controls.Add(Me.lbl19)
        Me.Controls.Add(Me.lbl20)
        Me.Controls.Add(Me.lbl21)
        Me.Controls.Add(Me.lbl8)
        Me.Controls.Add(Me.lbl9)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.lbl11)
        Me.Controls.Add(Me.lbl12)
        Me.Controls.Add(Me.lbl13)
        Me.Controls.Add(Me.lbl14)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.lbl7)
        Me.Controls.Add(Me.lblJomeh)
        Me.Controls.Add(Me.lblPanjshanbeh)
        Me.Controls.Add(Me.lblCharshanbeh)
        Me.Controls.Add(Me.lblSeshanbeh)
        Me.Controls.Add(Me.lblDoshanbeh)
        Me.Controls.Add(Me.lblYekshanbeh)
        Me.Controls.Add(Me.lblShanbeh)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmDatePicker"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        If Me.ValueDate.Trim = "" Then
            Me.ValueDate = DateTime.Now.ToString(myFormat)
        End If
        lblYear.Text = DateTime.ParseExact(Me.ValueDate, myFormat, System.Globalization.DateTimeFormatInfo.CurrentInfo).Year.ToString
        lblMonth.Text = DateTime.ParseExact(Me.ValueDate, myFormat, System.Globalization.DateTimeFormatInfo.CurrentInfo).Month.ToString
        'lblYear.Text = CType(Me.ValueDate, Date).Year
        'lblMonth.Text = CType(Me.ValueDate, Date).Month
        mnuItemMonth(mnuMonth.MenuItems(CType(lblMonth.Text, Short) - 1), e)
    End Sub

    Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = System.Windows.Forms.Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub FillDate(ByVal iYear As Short, ByVal iMonth As Short)
        Dim n, i, j, m, k1 As Short
        Dim tDate, mDate As Date
        For i = 0 To 41
            RemoveHandler lbl(i).MouseEnter, AddressOf lblMouseEnter
            RemoveHandler lbl(i).MouseLeave, AddressOf lblMouseLeave
            RemoveHandler lbl(i).Click, AddressOf lblClick
            lbl(i).ForeColor = Color.Black
        Next
        lbl(6).ForeColor = Color.Firebrick
        lbl(13).ForeColor = Color.Firebrick
        lbl(20).ForeColor = Color.Firebrick
        lbl(27).ForeColor = Color.Firebrick
        lbl(34).ForeColor = Color.Firebrick
        lbl(41).ForeColor = Color.Firebrick
        tDate = CType(iYear & "/" & iMonth & "/" & 1, Date)
        mDate = DateTime.ParseExact(Me.ValueDate, myFormat, System.Globalization.DateTimeFormatInfo.CurrentInfo)
        j = 1
        n = tDate.DayOfWeek + 1
        If iMonth = 1 Then
            m = DateTime.DaysInMonth(iYear - 1, 12)
        Else
            m = DateTime.DaysInMonth(iYear, iMonth - 1)
        End If
        For i = n - 1 To 1 Step -1
            lbl(i - 1).ForeColor = Color.Gainsboro
            lbl(i - 1).BackColor = Color.Snow
            lbl(i - 1).Text = m
            m -= 1
        Next
        j = 1
        For i = n To DateTime.DaysInMonth(iYear, iMonth) + n - 1
            lbl(i - 1).BackColor = Color.Snow
            lbl(i - 1).Text = j
            If mDate.Year.ToString = lblYear.Text And mDate.Month.ToString = lblMonth.Text Then
                If j = mDate.Day Then
                    lbl(i - 1).BackColor = Color.DarkSeaGreen
                    k1 = i - 1
                End If
            End If
            AddHandler lbl(i - 1).MouseEnter, AddressOf lblMouseEnter
            AddHandler lbl(i - 1).MouseLeave, AddressOf lblMouseLeave
            AddHandler lbl(i - 1).Click, AddressOf lblClick
            j += 1
        Next
        j = 1
        For i = DateTime.DaysInMonth(iYear, iMonth) + n To 42
            lbl(i - 1).ForeColor = Color.Gainsboro
            lbl(i - 1).BackColor = Color.Snow
            lbl(i - 1).Text = j
            j += 1
        Next
        Dim k As Integer = n + DateTime.Now.Day - 2
        If DateTime.Now.Year.ToString = lblYear.Text And DateTime.Now.Month.ToString = lblMonth.Text Then
            lbl(k).BackColor = Color.LightSteelBlue
            If k = k1 Then
                lbl(k).BackColor = Color.DarkSeaGreen
            End If
        End If
    End Sub

    Private Sub lblMouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim l As Label = CType(sender, Label)
        oColor = l.ForeColor
        Dim font1 As New Font(Font.FontFamily, 12.0!, FontStyle.Underline)
        l.Font = font1
        l.ForeColor = Color.Red
        'lblNow.Text = datetime.DateUtils.FarToEn(CShort(lblYear.Text), CShort(lblMonth.Text), CShort(l.Text))

    End Sub

    Private Sub lblMouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim l As Label = CType(sender, Label)
        Dim font1 As New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        l.Font = font1
        l.ForeColor = oColor
        lblNow.Text = ""
    End Sub

    Private Sub lblClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim l As Label = CType(sender, Label)
        Select Case myFormat
            Case "yyyy/MM/dd"
                Me.ValueDate = lblYear.Text & mySlash & IIf(lblMonth.Text.Trim.Length = 1, "0" & lblMonth.Text.Trim, lblMonth.Text) & mySlash & IIf(l.Text.Trim.Length = 1, "0" & l.Text.Trim, l.Text)
            Case "yyyy/dd/MM"
                Me.ValueDate = lblYear.Text & mySlash & IIf(l.Text.Trim.Length = 1, "0" & l.Text.Trim, l.Text) & mySlash & IIf(lblMonth.Text.Trim.Length = 1, "0" & lblMonth.Text.Trim, lblMonth.Text)
            Case "MM/dd/yyyy"
                Me.ValueDate = IIf(lblMonth.Text.Trim.Length = 1, "0" & lblMonth.Text.Trim, lblMonth.Text) & mySlash & IIf(l.Text.Trim.Length = 1, "0" & l.Text.Trim, l.Text) & mySlash & lblYear.Text
            Case "dd/MM/yyyy"
                Me.ValueDate = IIf(l.Text.Trim.Length = 1, "0" & l.Text.Trim, l.Text) & mySlash & IIf(lblMonth.Text.Trim.Length = 1, "0" & lblMonth.Text.Trim, lblMonth.Text) & mySlash & lblYear.Text
        End Select
        oDate.Text = Me.ValueDate
        Me.Close()
    End Sub

    Private Sub lblMonth_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblMonth.Click
        mnuMonth.Show(sender, New Point(sender.Width, sender.top))
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        mnuItemMonth(sender, e)
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        mnuItemMonth(sender, e)
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        mnuItemMonth(sender, e)
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        mnuItemMonth(sender, e)
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        mnuItemMonth(sender, e)
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        mnuItemMonth(sender, e)
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        mnuItemMonth(sender, e)
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        mnuItemMonth(sender, e)
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        mnuItemMonth(sender, e)
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        mnuItemMonth(sender, e)
    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        mnuItemMonth(sender, e)
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        mnuItemMonth(sender, e)
    End Sub

    Private Sub mnuItemMonth(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim i As Integer
        For i = 1 To 12
            If sender Is mnuMonth.MenuItems(i - 1) Then
                mnuMonth.MenuItems(i - 1).Checked = True
            Else
                mnuMonth.MenuItems(i - 1).Checked = False
            End If
        Next
        lblMonth.Text = sender.index + 1
        FillDate(CShort(lblYear.Text), CShort(lblMonth.Text))
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click, btnNext.DoubleClick
        If CShort(lblMonth.Text) = 12 Then
            lblMonth.Text = "1"
            If YearConstant = True Then
                lblYear.Text = (CShort(lblYear.Text) + 1).ToString
            End If
        Else
            lblMonth.Text = (CShort(lblMonth.Text) + 1).ToString
        End If
        mnuItemMonth(mnuMonth.MenuItems(CShort(lblMonth.Text) - 1), e)
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click, btnLast.DoubleClick
        If CShort(lblMonth.Text) = 1 Then
            lblMonth.Text = "12"
            If YearConstant = True Then
                lblYear.Text = (CShort(lblYear.Text) - 1).ToString
            End If
        Else
            lblMonth.Text = (CShort(lblMonth.Text) - 1).ToString
        End If
        mnuItemMonth(mnuMonth.MenuItems(CShort(lblMonth.Text) - 1), e)
    End Sub

    Private Sub lblYear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblYear.Click
        If YearConstant = False Then
            lblYear.Text = oDate.txtYear.Text
        Else
            udYear.Value = CShort(lblYear.Text)
            udYear.Visible = True
            bUpDown = True
        End If
    End Sub

    Private Sub udYear_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles udYear.Leave
        lblYear.Text = udYear.Value.ToString
        udYear.Visible = False
        bUpDown = False
        FillDate(udYear.Value, CShort(lblMonth.Text))
    End Sub

    Private Sub udYear_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles udYear.MouseLeave
        lblYear.Text = udYear.Value.ToString
        udYear.Visible = False
        bUpDown = False
        FillDate(udYear.Value, CShort(lblMonth.Text))
    End Sub

    Private Sub udYear_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles udYear.ValueChanged
        If bUpDown = True Then
            FillDate(udYear.Value, CShort(lblMonth.Text))
        End If
    End Sub

    Private Sub btnToday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToday.Click
        If YearConstant = False And oDate.txtYear.Text.Trim <> DateTime.Now.Year.ToString Then
            Exit Sub
        End If
        Dim iYear, iMonth As Integer
        iYear = DateTime.Now.Year
        iMonth = DateTime.Now.Month
        lblYear.Text = iYear.ToString
        lblMonth.Text = iMonth.ToString
        mnuItemMonth(mnuMonth.MenuItems(CType(lblMonth.Text, Short) - 1), e)
    End Sub

    Public Property ValueDate() As String
        Get
            Return m_DateValue
        End Get
        Set(ByVal Value As String)
            m_DateValue = Value
        End Set
    End Property

    Public Property oDate() As CalendarCombo
        Get
            Return oEnDate
        End Get
        Set(ByVal Value As CalendarCombo)
            oEnDate = Value
        End Set
    End Property

    Private mYearConstant As Boolean
    Public Property YearConstant() As Boolean
        Get
            Return mYearConstant
        End Get
        Set(ByVal Value As Boolean)
            mYearConstant = Value
        End Set
    End Property

    Private Sub frmDatePicker_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        Me.Close()
    End Sub
End Class
