Imports System.ComponentModel
Imports System.Resources
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class UcCalendar
    Inherits System.Windows.Forms.UserControl
    Dim mResources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(UcCalendar))
    Private myW, myH, mmW, mmH, mdW, mdH, mlW1, mlH1, mlW2, mlH2, mbW, mbH As Short
    Private mFont As System.Drawing.Font
    Private mZarib As Single = 1
    Private mHeight = 23
    Private mText() As String
    Shadows Event KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    Shadows Event TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Private mFlag As Boolean = True
    Friend WithEvents frmDate As frmDatePicker

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        mFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        myW = Me.txtYear.Width
        myH = Me.txtYear.Height
        mmW = Me.txtMonth.Width
        mmH = Me.txtMonth.Height
        mdW = Me.txtDay.Width
        mdH = Me.txtDay.Height
        mlW1 = Me.Label1.Width
        mlH1 = Me.Label1.Height
        mlW2 = Me.Label2.Width
        mlH2 = Me.Label2.Height
        mbW = Me.btnCalendar.Width
        mbH = Me.btnCalendar.Height

    End Sub

    'UserControl overrides dispose to clean up the component list.
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
    Friend WithEvents pnlDate As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCalendar As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtYear As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtMonth As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtDay As Janus.Windows.GridEX.EditControls.MaskedEditBox

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(UcCalendar))
        Me.pnlDate = New System.Windows.Forms.Panel
        Me.btnCalendar = New Janus.Windows.EditControls.UIButton
        Me.txtDay = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.txtMonth = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.txtYear = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDate
        '
        Me.pnlDate.BackColor = System.Drawing.SystemColors.HighlightText
        Me.pnlDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlDate.Controls.Add(Me.btnCalendar)
        Me.pnlDate.Controls.Add(Me.txtDay)
        Me.pnlDate.Controls.Add(Me.txtMonth)
        Me.pnlDate.Controls.Add(Me.txtYear)
        Me.pnlDate.Controls.Add(Me.Label2)
        Me.pnlDate.Controls.Add(Me.Label1)
        Me.pnlDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pnlDate.Location = New System.Drawing.Point(0, 0)
        Me.pnlDate.Name = "pnlDate"
        Me.pnlDate.Size = New System.Drawing.Size(110, 23)
        Me.pnlDate.TabIndex = 7
        '
        'btnCalendar
        '
        Me.btnCalendar.Appearance = Janus.Windows.UI.Appearance.Normal
        Me.btnCalendar.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button
        Me.btnCalendar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCalendar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnCalendar.Image = CType(resources.GetObject("btnCalendar.Image"), System.Drawing.Image)
        Me.btnCalendar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.btnCalendar.ImageSize = New System.Drawing.Size(20, 24)
        Me.btnCalendar.Location = New System.Drawing.Point(87, 0)
        Me.btnCalendar.Name = "btnCalendar"
        Me.btnCalendar.Size = New System.Drawing.Size(19, 19)
        Me.btnCalendar.TabIndex = 6
        Me.btnCalendar.TabStop = False
        Me.btnCalendar.Text = "..."
        '
        'txtDay
        '
        Me.txtDay.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.txtDay.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.txtDay.AutoSize = False
        Me.txtDay.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtDay.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtDay.Location = New System.Drawing.Point(65, 1)
        Me.txtDay.MaxLength = 2
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Numeric = True
        Me.txtDay.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.txtDay.Size = New System.Drawing.Size(16, 18)
        Me.txtDay.TabIndex = 5
        Me.txtDay.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtMonth
        '
        Me.txtMonth.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.txtMonth.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.txtMonth.AutoSize = False
        Me.txtMonth.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtMonth.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtMonth.Location = New System.Drawing.Point(40, 1)
        Me.txtMonth.MaxLength = 2
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Numeric = True
        Me.txtMonth.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.txtMonth.Size = New System.Drawing.Size(19, 18)
        Me.txtMonth.TabIndex = 3
        Me.txtMonth.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'txtYear
        '
        Me.txtYear.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.txtYear.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.txtYear.AutoSize = False
        Me.txtYear.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtYear.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.txtYear.Location = New System.Drawing.Point(1, 1)
        Me.txtYear.MaxLength = 4
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Numeric = True
        Me.txtYear.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.txtYear.Size = New System.Drawing.Size(31, 18)
        Me.txtYear.TabIndex = 1
        Me.txtYear.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(8, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "/"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(8, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "/"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UcCalendar
        '
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Controls.Add(Me.pnlDate)
        Me.Name = "UcCalendar"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Size = New System.Drawing.Size(110, 23)
        Me.pnlDate.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Property"
    Private mBorderStyle As System.Windows.Forms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Public Property BorderStyle() As System.Windows.Forms.BorderStyle
        Get
            Return mBorderStyle
        End Get
        Set(ByVal Value As System.Windows.Forms.BorderStyle)
            mBorderStyle = Value
            ReDraw()
        End Set
    End Property

    Private mShowButton As Boolean = True
    Public Property ShowButton() As Boolean
        Get
            Return mShowButton
        End Get
        Set(ByVal Value As Boolean)
            If mShowButton <> Value Then
                btnCalendar.Visible = Value
                mShowButton = Value
                If mShowButton = False Then
                    Me.Width -= Me.btnCalendar.Width
                Else
                    Me.Width += Me.btnCalendar.Width
                End If
            End If
        End Set
    End Property

    Private mMinValue As Short = 1200
    Public Property MinValue() As Short
        Get
            Return mMinValue
        End Get
        Set(ByVal Value As Short)
            If Value = 0 And Value < 1200 And Value > 1500 And Value > MaxValue Then
                mMinValue = 1200
            Else
                mMinValue = Value
            End If
        End Set
    End Property

    Private mMaxValue As Short = 1500
    Public Property MaxValue() As Short
        Get
            Return mMaxValue
        End Get
        Set(ByVal Value As Short)
            If Value = 0 And Value < 1200 And Value > 1500 And Value < MinValue Then
                mMaxValue = 1500
            Else
                mMaxValue = Value
            End If
        End Set
    End Property

    Private mEditableSal As Boolean = True
    Public Property EditableSal() As Boolean
        Get
            Return mEditableSal
        End Get
        Set(ByVal Value As Boolean)
            mEditableSal = Value
            Me.txtYear.ReadOnly = Not Value
            Me.txtYear.Enabled = Value
        End Set
    End Property

    Public Overrides Property BackColor() As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(ByVal Value As Color)
            Me.txtYear.BackColor = Value
            Me.txtMonth.BackColor = Value
            Me.txtDay.BackColor = Value
            Me.Label1.BackColor = Value
            Me.Label2.BackColor = Value
            Me.pnlDate.BackColor = Value
            MyBase.BackColor = Value
        End Set
    End Property

    Public Overrides Property ForeColor() As Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(ByVal Value As Color)
            Me.txtYear.ForeColor = Value
            Me.txtMonth.ForeColor = Value
            Me.txtDay.ForeColor = Value
            Me.Label2.ForeColor = Value
            Me.Label1.ForeColor = Value
            MyBase.ForeColor = Value
        End Set
    End Property

    Public Overrides Property Font() As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal Value As Font)
            Me.txtYear.Font = Value
            Me.txtMonth.Font = Value
            Me.txtDay.Font = Value
            Me.Label1.Font = Value
            Me.Label2.Font = Value
            Me.pnlDate.Font = Value
            Me.btnCalendar.StateStyles.FormatStyle.Font = Value
            MyBase.Font = Value
            ReDraw()
        End Set
    End Property

    Private mBorderColor As Color
    Public Property BorderColor() As Color
        Get
            Return mBorderColor
        End Get
        Set(ByVal Value As Color)
            mBorderColor = Value
            ReDraw()
        End Set
    End Property

    Private mVisualStyle As Boolean = False
    Public Property VisualStyle() As Boolean
        Get
            Return mVisualStyle
        End Get
        Set(ByVal Value As Boolean)
            mVisualStyle = Value
            ReDraw()
        End Set
    End Property

    Private mButtonBackColor As Color
    Public Property ButtonBackColor() As Color
        Get
            Return mButtonBackColor
        End Get
        Set(ByVal Value As Color)
            mButtonBackColor = Value
            Me.btnCalendar.StateStyles.FormatStyle.BackColor = mButtonBackColor
        End Set
    End Property

    Private mButtonForeColor As Color
    Public Property ButtonForeColor() As Color
        Get
            Return mButtonForeColor
        End Get
        Set(ByVal Value As Color)
            mButtonForeColor = Value
            Me.btnCalendar.StateStyles.FormatStyle.ForeColor = mButtonForeColor
        End Set
    End Property

    Private mSal_Mali
    Public Property Sal_Mali() As String
        Get
            Return mSal_Mali
        End Get
        Set(ByVal Value As String)
            Dim BeforeReadOnly As Boolean = txtYear.ReadOnly
            txtYear.ReadOnly = False
            mSal_Mali = Value
            txtYear.Text = mSal_Mali
            txtYear.ReadOnly = BeforeReadOnly
        End Set
    End Property

    <Browsable(False)> _
      Public ReadOnly Property DateAlphabetic() As String
        Get
            If DateUtils.validDate(Me.Text, 1) Then
                Return DateUtils.FarDateAlphabetic(Me.Text)
            End If
        End Get
    End Property

    Private _Text As String
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Browsable(True)> _
    Public Overrides Property Text() As String
        Get
            If txtYear.Text.Trim <> "" And txtMonth.Text.Trim <> "" And txtDay.Text.Trim <> "" Then
                _Text = txtYear.Text & "/" & txtMonth.Text & "/" & txtDay.Text
            Else
                _Text = ""
            End If
            Return _Text
        End Get
        Set(ByVal Value As String)
            _Text = Value & ""
            If DateUtils.validDate(_Text, 1) = True Then
                If _Text.Trim.Length = 8 Then
                    _Text = Mid(_Text, 1, 4).Trim & "/" & Mid(_Text, 5, 2).Trim & "/" & Mid(_Text, 7, 2).Trim
                End If
                mText = _Text.Split("/")
                txtYear.Text = mText(0).Trim
                If CType(mText(1), Short) < 10 And mText(1).Trim.Length = 1 Then
                    mText(1) = "0" & mText(1)
                End If
                txtMonth.Text = mText(1).Trim
                If CType(mText(2), Short) < 10 And mText(2).Trim.Length = 1 Then
                    mText(2) = "0" & mText(2)
                End If
                txtDay.Text = mText(2).Trim
            Else
                If Me.EditableSal = True Then
                    txtYear.Clear()
                End If
                txtMonth.Clear()
                txtDay.Clear()
            End If
        End Set
    End Property

    Private mImage As Image = CType(mResources.GetObject("btnCalendar.Image"), System.Drawing.Image)
    <DefaultValue(GetType(Image), "")> _
    Public Property Image() As Image
        Get
            Return mImage
        End Get
        Set(ByVal Value As Image)
            mImage = Value
            btnCalendar.Text = ""
            btnCalendar.Image = mImage
            If mImage Is Nothing Then
                btnCalendar.Text = "..."
            End If
            Me.Refresh()
        End Set
    End Property

#End Region


#Region "Method"

    Private Sub ReDraw()
        mZarib = (Me.Font.Size / mFont.Size)

        Me.Height = mHeight * mZarib

        Me.txtYear.Height = myH * mZarib
        Me.txtYear.Width = myW * mZarib

        Me.Label1.Left = Me.txtYear.Width
        Me.Label1.Height = mlH1 * mZarib
        Me.Label1.Width = mlW1 * mZarib

        Me.txtMonth.Left = Me.txtYear.Width + Me.Label1.Width
        Me.txtMonth.Height = mmH * mZarib
        Me.txtMonth.Width = mmW * mZarib

        Me.Label2.Left = Me.txtMonth.Left + Me.txtMonth.Width
        Me.Label2.Height = mlH2 * mZarib
        Me.Label2.Width = mlW2 * mZarib

        Me.txtDay.Left = Me.Label2.Left + Me.Label2.Width
        Me.txtDay.Height = mdH * mZarib
        Me.txtDay.Width = mdW * mZarib

        Me.btnCalendar.Height = mbH * mZarib
        Me.btnCalendar.Width = mbW * mZarib

        Select Case Me.BorderStyle
            Case BorderStyle.Fixed3D
                Me.pnlDate.BorderStyle = BorderStyle.Fixed3D
                Me.btnCalendar.Appearance = Janus.Windows.UI.Appearance.Normal

            Case BorderStyle.FixedSingle
                Me.pnlDate.BorderStyle = BorderStyle.FixedSingle
                Me.btnCalendar.Appearance = Janus.Windows.UI.Appearance.FlatBorderless
            Case BorderStyle.None
                Me.pnlDate.BorderStyle = BorderStyle.None
                Me.btnCalendar.Appearance = Janus.Windows.UI.Appearance.Flat
        End Select

        If Me.VisualStyle = False Then
            Me.btnCalendar.VisualStyle = Janus.Windows.UI.VisualStyle.Standard
            Select Case Me.BorderStyle
                Case BorderStyle.Fixed3D
                    Me.btnCalendar.Appearance = Janus.Windows.UI.Appearance.Normal
                Case BorderStyle.FixedSingle
                    Me.btnCalendar.Appearance = Janus.Windows.UI.Appearance.FlatBorderless
                Case BorderStyle.None
                    Me.btnCalendar.Appearance = Janus.Windows.UI.Appearance.Flat
            End Select
        Else
            Me.btnCalendar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        End If

        If Me.BorderStyle = BorderStyle.None Then
            btnCalendar.FlatBorderColor = BorderColor
        Else
            btnCalendar.FlatBorderColor = Me.ButtonBackColor
        End If

        Me.Refresh()


    End Sub

    Private Sub clearDate()
        Text = ""
    End Sub

    Private Sub closeForm(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmDate.Close()
    End Sub

#End Region


#Region "Events"

    Private Sub pnlDate_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlDate.Paint
        If Me.BorderStyle = BorderStyle.None Then
            ControlPaint.DrawBorder(System.Drawing.Graphics.FromHwnd(Me.pnlDate.Handle), Me.pnlDate.ClientRectangle, BorderColor, 1, ButtonBorderStyle.Solid, BorderColor, 1, ButtonBorderStyle.Solid, BorderColor, 1, ButtonBorderStyle.Solid, BorderColor, 1, ButtonBorderStyle.Solid)
        End If
    End Sub

    Private Sub FarDate_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If sender.Height <> mHeight * mZarib Then
            sender.Height = mHeight * mZarib
        End If
    End Sub

    Private Sub txtYear_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtYear.SelectAll()
    End Sub

    Private Sub txtMonth_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtMonth.SelectAll()
    End Sub

    Private Sub txtDay_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtDay.SelectAll()
    End Sub

    Private Sub txtYear_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtYear.TextChanged
        RaiseEvent TextChanged(sender, e)
        If txtYear.Text.Trim <> "" And txtYear.Text.Trim.Length = 4 Then
            If CShort(txtYear.Text.Trim) > MaxValue Then
                txtYear.Text = DateUtils.FarYear(DateUtils.FarToDay()).ToString
            ElseIf CShort(txtYear.Text.Trim) < MinValue Then
                txtYear.Text = DateUtils.FarYear(DateUtils.FarToDay()).ToString
            End If
            If EditableSal = True And mFlag = True Then
                If Me.Enabled Then txtMonth.Focus()
            End If
        End If
    End Sub

    Private Sub txtMonth_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMonth.TextChanged
        RaiseEvent TextChanged(sender, e)
        If txtMonth.Text.Trim <> "" And txtYear.Text.Trim <> "" Then
            If CShort(txtMonth.Text.Trim) < 0 Then
                txtMonth.Text = "01"
            ElseIf CShort(txtMonth.Text.Trim) > 12 Then
                txtMonth.Text = "12"
            End If
            If CShort(txtMonth.Text.Trim) < 10 And CShort(txtMonth.Text.Trim) >= 2 And txtMonth.Text.Trim.Length = 1 Then
                txtMonth.Text = "0" & txtMonth.Text.Trim
            End If
        End If
        If txtMonth.Text.Trim.Length = 2 And mFlag = True Then
            If Me.Enabled Then txtDay.Focus()
        End If
    End Sub

    Private Sub txtDay_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDay.TextChanged
        RaiseEvent TextChanged(sender, e)
        If txtDay.Text.Trim <> "" And txtMonth.Text.Trim <> "" And txtYear.Text.Trim <> "" Then
            If CShort(txtDay.Text.Trim) < 0 Then
                txtDay.Text = "01"
            End If
            If CShort(txtMonth.Text.Trim) >= 1 And CShort(txtMonth.Text.Trim) <= 6 Then
                If CShort(txtDay.Text.Trim) > 31 Then
                    txtDay.Text = "31"
                    Exit Sub
                End If
            End If
            If CShort(txtMonth.Text.Trim) >= 7 And CShort(txtMonth.Text.Trim) <= 11 Then
                If CShort(txtDay.Text.Trim) > 30 Then
                    txtDay.Text = "30"
                    Exit Sub
                End If
            End If
            If CShort(txtMonth.Text.Trim) = 12 Then
                If DateUtils.Leap_Far(CShort(txtYear.Text.Trim)) Then
                    If CShort(txtDay.Text.Trim) > 30 Then
                        txtDay.Text = "30"
                        Exit Sub
                    End If
                Else
                    If CShort(txtDay.Text.Trim) > 29 Then
                        txtDay.Text = "29"
                        Exit Sub
                    End If
                End If
            End If

            If CShort(txtDay.Text.Trim) < 10 And CShort(txtDay.Text.Trim) >= 4 And txtDay.Text.Trim.Length = 1 Then
                txtDay.Text = "0" & txtDay.Text.Trim
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtDay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDay.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
        If e.Shift = False And e.Control = False And e.Alt = False Then
            If e.KeyCode = Keys.F4 Then
                btnCalendar_Click(btnCalendar, e)
            End If
        End If
    End Sub

    Private Sub txtYear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtYear.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDay.Focus()
            SendKeys.Send("{Tab}")
        End If
        If e.Shift = False And e.Control = False And e.Alt = False Then
            If e.KeyCode = Keys.F4 Then
                btnCalendar_Click(btnCalendar, e)
            End If
        End If
    End Sub

    Private Sub txtMonth_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMonth.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDay.Focus()
            SendKeys.Send("{Tab}")
        End If
        If e.Shift = False And e.Control = False And e.Alt = False Then
            If e.KeyCode = Keys.F4 Then
                btnCalendar_Click(btnCalendar, e)
            End If
        End If

    End Sub

    Private Sub txtDay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDay.Click
        txtDay.SelectAll()
    End Sub

    Private Sub txtMonth_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMonth.Click
        txtMonth.SelectAll()
    End Sub

    Private Sub txtYear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtYear.Click
        txtYear.SelectAll()
    End Sub

    Private Sub pnlDate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlDate.Click
        txtDay.Focus()
    End Sub

    Private Sub txtYear_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtYear.Validating
        If txtYear.Text.Trim <> "" Then
            If CShort(txtYear.Text.Trim) > MaxValue Then
                txtYear.Text = DateUtils.FarYear(DateUtils.FarToDay()).ToString
            ElseIf CShort(txtYear.Text.Trim) < MinValue Then
                txtYear.Text = DateUtils.FarYear(DateUtils.FarToDay()).ToString
            End If
        End If
    End Sub

    Private Sub txtMonth_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMonth.Validating
        If txtMonth.Text.Trim <> "" Then
            If CShort(txtMonth.Text.Trim) < 1 Then
                txtMonth.Text = "01"
            ElseIf CShort(txtMonth.Text.Trim) > 12 Then
                txtMonth.Text = "12"
            End If
            If CShort(txtMonth.Text.Trim) < 10 And txtMonth.Text.Trim.Length = 1 Then
                txtMonth.Text = "0" & txtMonth.Text.Trim
            End If

        End If
    End Sub

    Private Sub txtDay_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDay.Validating
        If txtDay.Text.Trim <> "" And txtMonth.Text.Trim <> "" And txtYear.Text.Trim <> "" Then
            If CShort(txtDay.Text.Trim) < 1 Then
                txtDay.Text = "01"
            End If
            If CShort(txtMonth.Text.Trim) >= 1 And CShort(txtMonth.Text.Trim) <= 6 Then
                If CShort(txtDay.Text.Trim) > 31 Then
                    txtDay.Text = "31"
                End If
            End If
            If CShort(txtMonth.Text.Trim) >= 7 And CShort(txtMonth.Text.Trim) <= 11 Then
                If CShort(txtDay.Text.Trim) > 30 Then
                    txtDay.Text = "30"
                End If
            End If
            If CShort(txtMonth.Text.Trim) = 12 Then
                If DateUtils.Leap_Far(CShort(txtYear.Text.Trim)) Then
                    If CShort(txtDay.Text.Trim) > 30 Then
                        txtDay.Text = "30"
                    End If
                Else
                    If CShort(txtDay.Text.Trim) > 29 Then
                        txtDay.Text = "29"
                    End If
                End If
            End If
            If CShort(txtDay.Text.Trim) < 10 And txtDay.Text.Trim.Length = 1 Then
                txtDay.Text = "0" & txtDay.Text.Trim
            End If
        End If
    End Sub

    Private Sub txtYear_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtYear.KeyUp
        mFlag = True
        If e.KeyCode = Keys.Right Then
            txtMonth.Focus()
        End If
        If e.KeyCode = Keys.Left Then
            txtDay.Focus()
        End If
        If e.KeyCode = Keys.Up Then
            mFlag = False
            If txtYear.Text.Trim = "" Then
                txtYear.Text = DateUtils.FarToDay().Substring(0, 4)
            End If
            txtYear.Text = IIf(CType(txtYear.Text.Trim, Short) >= MaxValue, MaxValue.ToString, CType(txtYear.Text.Trim, Short) + 1)
            txtYear.SelectAll()
            RaiseEvent KeyUp(sender, e)
        End If
        If e.KeyCode = Keys.Down Then
            mFlag = False
            If txtYear.Text.Trim = "" Then
                txtYear.Text = DateUtils.FarToDay().Substring(0, 4)
            End If
            txtYear.Text = IIf(CType(txtYear.Text.Trim, Short) <= MinValue, MinValue.ToString, CType(txtYear.Text.Trim, Short) - 1)
            txtYear.SelectAll()
            RaiseEvent KeyUp(sender, e)
        End If
    End Sub

    Private Sub txtMonth_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMonth.KeyUp
        mFlag = True
        If e.KeyCode = Keys.Right Then
            txtDay.Focus()
        End If
        If e.KeyCode = Keys.Left Then
            If Me.EditableSal = True Then
                txtYear.Focus()
            Else
                txtDay.Focus()
            End If
        End If
        If e.KeyCode = Keys.Up Then
            mFlag = False
            If txtMonth.Text.Trim = "" Then
                txtMonth.Text = DateUtils.FarToDay().Substring(5, 2)
            End If
            If txtMonth.Text = "12" Then
                txtMonth.Text = "01"
            Else
                txtMonth.Text = IIf(CShort(txtMonth.Text.Trim) + 1 >= 10, (CShort(txtMonth.Text.Trim) + 1).ToString, "0" & (CShort(txtMonth.Text.Trim) + 1).ToString)
            End If
            txtMonth.SelectAll()
            RaiseEvent KeyUp(sender, e)
        End If
        If e.KeyCode = Keys.Down Then
            mFlag = False
            If txtMonth.Text.Trim = "" Then
                txtMonth.Text = DateUtils.FarToDay().Substring(5, 2)
            End If
            If txtMonth.Text = "01" Then
                txtMonth.Text = "12"
            Else
                txtMonth.Text = IIf(CShort(txtMonth.Text.Trim) - 1 >= 10, (CShort(txtMonth.Text.Trim) - 1).ToString, "0" & (CShort(txtMonth.Text.Trim) - 1).ToString)
            End If
            txtMonth.SelectAll()
            RaiseEvent KeyUp(sender, e)
        End If
    End Sub

    Private Sub txtDay_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDay.KeyUp
        mFlag = True
        If e.KeyCode = Keys.Right Then
            If Me.EditableSal = True Then
                txtYear.Focus()
            Else
                txtMonth.Focus()
            End If
        End If
        If e.KeyCode = Keys.Left Then
            txtMonth.Focus()
        End If
        If e.KeyCode = Keys.Up And txtMonth.Text.Trim <> "" Then
            mFlag = False
            If txtDay.Text.Trim = "" Then
                txtDay.Text = DateUtils.FarToDay().Substring(8, 2)
            End If
            If CShort(txtMonth.Text.Trim) >= 1 And CShort(txtMonth.Text.Trim) <= 6 Then
                If txtDay.Text = "31" Then
                    txtDay.Text = "01"
                Else
                    txtDay.Text = IIf(CShort(txtDay.Text.Trim) + 1 >= 10, (CShort(txtDay.Text.Trim) + 1).ToString, "0" & (CShort(txtDay.Text.Trim) + 1).ToString)
                End If
            ElseIf CShort(txtMonth.Text.Trim) >= 7 And CShort(txtMonth.Text.Trim) <= 11 Then
                If txtDay.Text = "30" Then
                    txtDay.Text = "01"
                Else
                    txtDay.Text = IIf(CShort(txtDay.Text.Trim) + 1 >= 10, (CShort(txtDay.Text.Trim) + 1).ToString, "0" & (CShort(txtDay.Text.Trim) + 1).ToString)
                End If
            ElseIf CShort(txtMonth.Text.Trim) = 12 Then
                If DateUtils.Leap_Far(CShort(txtYear.Text.Trim)) Then
                    If txtDay.Text = "30" Then
                        txtDay.Text = "01"
                    Else
                        txtDay.Text = IIf(CShort(txtDay.Text.Trim) + 1 >= 10, (CShort(txtDay.Text.Trim) + 1).ToString, "0" & (CShort(txtDay.Text.Trim) + 1).ToString)
                    End If
                Else
                    If txtDay.Text = "29" Then
                        txtDay.Text = "01"
                    Else
                        txtDay.Text = IIf(CShort(txtDay.Text.Trim) + 1 >= 10, (CShort(txtDay.Text.Trim) + 1).ToString, "0" & (CShort(txtDay.Text.Trim) + 1).ToString)
                    End If
                End If
            End If
            txtDay.SelectAll()
            RaiseEvent KeyUp(sender, e)
        End If
        If e.KeyCode = Keys.Down And txtMonth.Text.Trim <> "" Then
            mFlag = False
            If txtDay.Text.Trim = "" Then
                txtDay.Text = DateUtils.FarToDay().Substring(8, 2)
            End If
            If CShort(txtMonth.Text.Trim) >= 1 And CShort(txtMonth.Text.Trim) <= 6 Then
                If txtDay.Text = "01" Then
                    txtDay.Text = "31"
                Else
                    txtDay.Text = IIf(CShort(txtDay.Text.Trim) - 1 >= 10, (CShort(txtDay.Text.Trim) - 1).ToString, "0" & (CShort(txtDay.Text.Trim) - 1).ToString)
                End If
            ElseIf CShort(txtMonth.Text.Trim) >= 7 And CShort(txtMonth.Text.Trim) <= 11 Then
                If txtDay.Text = "01" Then
                    txtDay.Text = "30"
                Else
                    txtDay.Text = IIf(CShort(txtDay.Text.Trim) - 1 >= 10, (CShort(txtDay.Text.Trim) - 1).ToString, "0" & (CShort(txtDay.Text.Trim) - 1).ToString)
                End If
            ElseIf CShort(txtMonth.Text.Trim) = 12 Then
                If DateUtils.Leap_Far(CShort(txtYear.Text.Trim)) Then
                    If txtDay.Text = "01" Then
                        txtDay.Text = "30"
                    Else
                        txtDay.Text = IIf(CShort(txtDay.Text.Trim) - 1 >= 10, (CShort(txtDay.Text.Trim) - 1).ToString, "0" & (CShort(txtDay.Text.Trim) - 1).ToString)
                    End If
                Else
                    If txtDay.Text = "01" Then
                        txtDay.Text = "29"
                    Else
                        txtDay.Text = IIf(CShort(txtDay.Text.Trim) - 1 >= 10, (CShort(txtDay.Text.Trim) - 1).ToString, "0" & (CShort(txtDay.Text.Trim) - 1).ToString)
                    End If
                End If
            End If
            txtDay.SelectAll()
            RaiseEvent KeyUp(sender, e)
        End If
        If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
            txtDay.Clear()
        End If
    End Sub

    Private Sub btnCalendar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalendar.Click
        If ShowButton = True Then
            Dim pntForm As Point
            Dim pntLocation As Point
            Dim sizeForm As Size

            sizeForm.Width = 205
            sizeForm.Height = 178
            pntLocation.X = Me.Location.X + Me.Size.Width - sizeForm.Width
            pntLocation.Y = Me.Location.Y + Me.Size.Height + 1
            pntForm = Me.Parent.PointToScreen(pntLocation)
            If pntForm.Y + sizeForm.Height > Screen.PrimaryScreen.Bounds.Height - 40 Then
                pntForm.Y = pntForm.Y - sizeForm.Height - Me.Size.Height - 1
            End If
            If (pntForm.X < 0) Then pntForm.X = 0

            If DateUtils.Forms.Contains("frmDatePicker") Then
                frmDate = DateUtils.Forms("frmDatePicker")
            Else
                frmDate = New frmDatePicker
            End If
            'AddHandler ParentForm.Click, AddressOf closeForm
            'AddHandler ParentForm.Resize, AddressOf closeForm
            'AddHandler ParentForm.Move, AddressOf closeForm
            'AddHandler ParentForm.Activated, AddressOf closeForm

            frmDate.SetDesktopLocation(pntForm.X, pntForm.Y)
            frmDate.oDate = Me
            frmDate.ValueDate = Me.Text
            frmDate.YearConstant = True
            If EditableSal = False Then
                frmDate.ValueDate = Me.txtYear.Text & "/" & IIf(txtMonth.Text.Trim <> "", txtMonth.Text, "01") & "/" & IIf(txtDay.Text.Trim <> "", txtDay.Text, "01")
                frmDate.YearConstant = False
            End If
            frmDate.Show()
        End If
    End Sub

    Private Sub FarDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        If Not DateUtils.validDate(Me.Text, 1) Then
            Me.Text = ""
        End If
    End Sub

    'Private Sub FarDate_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Enter
    '    If EditableSal = False Then
    '        txtYear.Text = Sal_Mali
    '    End If
    'End Sub

#End Region

    Private Sub txtDay_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDay.Leave
        If txtDay.Text.Trim <> "" Then
            If CShort(txtDay.Text.Trim) < 10 And txtDay.Text.Trim.Length = 1 Then
                txtDay.Text = "0" & txtDay.Text.Trim
            End If
        End If
    End Sub
End Class
