Imports System.Drawing
Imports System.ComponentModel
Public Class UcCalcText
    Inherits System.Windows.Forms.UserControl
    Dim mResources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(UcCalcText))
    Shadows Event TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event Click(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    Public Forms As New Collections.Hashtable
    Friend WithEvents frm As frmCalc
    Private _Flg As Boolean = False
    Public MFireTabAfterEnter As Boolean = True
    Public Property FireTabAfterEnter() As Boolean
        Get
            Return MFireTabAfterEnter
        End Get
        Set(ByVal Value As Boolean)
            MFireTabAfterEnter = Value
        End Set
    End Property

    'Private mHeight = 20

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents CalcText As Janus.Windows.GridEX.EditControls.NumericEditBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(UcCalcText))
        Me.CalcText = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.SuspendLayout()
        '
        'CalcText
        '
        Me.CalcText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CalcText.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.CalcText.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.CalcText.ButtonFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CalcText.ButtonImage = CType(resources.GetObject("CalcText.ButtonImage"), System.Drawing.Image)
        Me.CalcText.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.CalcText.ButtonText = "..."
        Me.CalcText.DecimalDigits = 0
        Me.CalcText.Location = New System.Drawing.Point(0, 0)
        Me.CalcText.MaxLength = 30
        Me.CalcText.Name = "CalcText"
        Me.CalcText.Size = New System.Drawing.Size(120, 22)
        Me.CalcText.TabIndex = 0
        Me.CalcText.Text = "0"
        Me.CalcText.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.CalcText.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcCalcText
        '
        Me.Controls.Add(Me.CalcText)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "UcCalcText"
        Me.Maxlength = 30
        Me.Size = New System.Drawing.Size(120, 21)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Property"

    Private mBorderStyle As Janus.Windows.UI.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
    Public Property BorderStyle() As Janus.Windows.UI.BorderStyle
        Get
            Return mBorderStyle
        End Get
        Set(ByVal Value As Janus.Windows.UI.BorderStyle)
            mBorderStyle = Value
            Select Case mBorderStyle
                Case Janus.Windows.UI.BorderStyle.None
                    CalcText.BorderStyle = Janus.Windows.UI.BorderStyle.None
                Case Janus.Windows.UI.BorderStyle.Flat
                    CalcText.BorderStyle = Janus.Windows.UI.BorderStyle.Flat
                Case Janus.Windows.UI.BorderStyle.RaisedLight3D
                    CalcText.BorderStyle = Janus.Windows.UI.BorderStyle.RaisedLight3D
                Case Janus.Windows.UI.BorderStyle.Raised
                    CalcText.BorderStyle = Janus.Windows.UI.BorderStyle.Raised
                Case Janus.Windows.UI.BorderStyle.SunkenLight3D
                    CalcText.BorderStyle = Janus.Windows.UI.BorderStyle.SunkenLight3D
                Case Janus.Windows.UI.BorderStyle.Sunken
                    CalcText.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
            End Select
        End Set
    End Property

    Private mButtonStyle As Janus.Windows.GridEX.EditControls.EditButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
    Public Property ButtonStyle() As Janus.Windows.GridEX.EditControls.EditButtonStyle
        Get
            Return mButtonStyle
        End Get
        Set(ByVal Value As Janus.Windows.GridEX.EditControls.EditButtonStyle)
            mButtonStyle = Value
            Select Case mButtonStyle
                Case Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow
                    CalcText.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow
                Case Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis
                    CalcText.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis
                Case Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
                    CalcText.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
                Case Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
                    CalcText.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
                Case Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton
                    CalcText.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton
            End Select
            SetHeight()
        End Set
    End Property

    Public Overrides Property BackColor() As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(ByVal Value As Color)
            CalcText.BackColor = Value
            MyBase.BackColor = Value
        End Set
    End Property

    Public Overrides Property ForeColor() As Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(ByVal Value As Color)
            CalcText.ForeColor = Value
            MyBase.ForeColor = Value
        End Set
    End Property

    Private _MinusColor As Color
    Public Property MinusColor() As Color
        Get
            Return _MinusColor
        End Get
        Set(ByVal Value As Color)
            _MinusColor = Value
        End Set
    End Property

    Private mDecimalDigit As Integer
    Public Property DecimalDigits() As Integer
        Get
            Return mDecimalDigit
        End Get
        Set(ByVal Value As Integer)
            mDecimalDigit = Value
            CalcText.DecimalDigits = mDecimalDigit
        End Set
    End Property

    Public Overrides Property Font() As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal Value As Font)
            CalcText.Font = Value
            MyBase.Font = Value
            SetHeight()
        End Set
    End Property

    Private mVisualStyle As Janus.Windows.GridEX.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
    Public Property VisualStyle() As Janus.Windows.GridEX.VisualStyle
        Get
            Return mVisualStyle
        End Get
        Set(ByVal Value As Janus.Windows.GridEX.VisualStyle)
            mVisualStyle = Value
            Select Case mVisualStyle
                Case Janus.Windows.GridEX.VisualStyle.Default
                    CalcText.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
                Case Janus.Windows.GridEX.VisualStyle.Office2003
                    CalcText.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
                Case Janus.Windows.GridEX.VisualStyle.Standard
                    CalcText.VisualStyle = Janus.Windows.GridEX.VisualStyle.Standard
            End Select
        End Set
    End Property

    <Browsable(False)> _
        ReadOnly Property NumberAlphabetic() As String
        Get
            Return NumberToString.N2S(Me.Text, False)
        End Get
    End Property

    Public ReadOnly Property Numbervalue() As Decimal
        Get
            Return CType(Me.Text, Decimal)
        End Get
    End Property

    Private _Text As String
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Browsable(True)> _
    Shadows Property Text() As String
        Get
            If _Text.Trim = "-" Or _Text.Trim = "." Then
                Return CType(0, Decimal)
            Else
                Return CType(_Text, Decimal)
            End If
        End Get
        Set(ByVal Value As String)
            If (Value = "" Or Value Is Nothing) Then
                Value = "0"
            End If
            If _Flg = False Then
                Dim txt As String()
                Dim st As String
                If DecimalDigits > 1 Then
                    txt = Value.Split(".")
                    If txt.Length > 1 Then
                        Value = txt(0) + "." + txt(1).PadRight(DecimalDigits, "0")
                        If txt(1).Length > DecimalDigits Then
                            Value = Math.Round(CType(Value, Decimal), DecimalDigits)
                        End If
                    Else
                        st = "0"
                        Value = txt(0) + "." + st.PadRight(DecimalDigits, "0")
                    End If
                End If
            End If
            Dim txtSplit As String()
            Dim noSplit As Integer
            Dim strTxt As String = ""

            txtSplit = Value.Split(".")
            If txtSplit.Length > 1 Then
                If DecimalDigits > 0 Then
                    If txtSplit(1).Length > DecimalDigits Then
                        Value = Math.Round(CType(Value, Decimal), DecimalDigits).ToString
                    End If
                Else
                    Value = txtSplit(0)
                End If
            End If
            _Text = Value
            CalcText.Text = _Text

            If CalcText.Text = "0" Then
                CalcText.SelectAll()
            End If
        End Set
    End Property

    Private mTextAlignment As Janus.Windows.GridEX.TextAlignment
    Public Property TextAlignment() As Janus.Windows.GridEX.TextAlignment
        Get
            Return mTextAlignment
        End Get
        Set(ByVal Value As Janus.Windows.GridEX.TextAlignment)
            mTextAlignment = Value
            Select Case mTextAlignment
                Case Janus.Windows.GridEX.TextAlignment.Center
                    CalcText.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                Case Janus.Windows.GridEX.TextAlignment.Empty
                    CalcText.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
                Case Janus.Windows.GridEX.TextAlignment.Far
                    CalcText.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                Case Janus.Windows.GridEX.TextAlignment.Near
                    CalcText.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            End Select
        End Set
    End Property

    Private mImage As Image = CType(mResources.GetObject("CalcText.ButtonImage"), System.Drawing.Image)
    <DefaultValue(GetType(Image), "")> _
    Public Property Image() As Image
        Get
            Return mImage
        End Get
        Set(ByVal Value As Image)
            mImage = Value
            CalcText.ButtonImage = mImage
            SetHeight()
        End Set
    End Property

    Private mDefaultSendValue As Boolean = False
    Public Property DefaultSendValue() As Boolean
        Get
            Return mDefaultSendValue
        End Get
        Set(ByVal Value As Boolean)
            mDefaultSendValue = Value
        End Set
    End Property

    Private mMaxlength As Integer
    Public Property Maxlength() As Integer
        Get
            Return mMaxlength
        End Get
        Set(ByVal Value As Integer)
            mMaxlength = Value
            CalcText.MaxLength = mMaxlength
        End Set
    End Property

    Private mReadonly As Boolean
    <DefaultValue(False)> _
    Public Property [ReadOnly]() As Boolean
        Get
            Return mReadonly
        End Get
        Set(ByVal Value As Boolean)
            mReadonly = Value
            CalcText.ReadOnly = mReadonly
        End Set
    End Property

    Private mEditMode As Janus.Windows.GridEX.NumericEditMode
    Public Property EditMode() As Janus.Windows.GridEX.NumericEditMode
        Get
            Return Me.mEditMode
        End Get
        Set(ByVal Value As Janus.Windows.GridEX.NumericEditMode)
            mEditMode = Value
            CalcText.EditMode = mEditMode
        End Set
    End Property



#End Region

    Private Sub CalcText_ButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles CalcText.ButtonClick
        Dim pntForm As Point
        Dim pntLocation As Point
        Dim sizeForm As Size

        sizeForm.Width = 174
        sizeForm.Height = 150
        pntLocation.X = Me.Location.X + Me.Size.Width - sizeForm.Width
        pntLocation.Y = Me.Location.Y + Me.Size.Height + 1
        pntForm = Me.Parent.PointToScreen(pntLocation)
        If pntForm.Y + sizeForm.Height > Screen.PrimaryScreen.Bounds.Height - 40 Then
            pntForm.Y = pntForm.Y - sizeForm.Height - Me.Size.Height - 1
        End If
        If (pntForm.X < 0) Then pntForm.X = 0

        If Forms.Contains("frmCalc") Then
            frm = Forms("Calc")
        Else
            frm = New frmCalc
        End If

        frm.SetDesktopLocation(pntForm.X, pntForm.Y)
        frm.oCalcText = Me
        frm.btnNoAshar.Value = Me.DecimalDigits
        frm.Show()
    End Sub

    Private Sub closeForm(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frm.Close()
    End Sub

    Private Sub CalcText_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CalcText.KeyDown
        If e.KeyCode = Keys.Enter And FireTabAfterEnter Then
            SendKeys.Send("{Tab}")
        End If
        If e.Shift = False And e.Control = False And e.Alt = False Then
            If e.KeyCode = Keys.F4 Then
                CalcText_ButtonClick(sender, e)
            End If
        End If
        If e.KeyValue = 106 Then
            SendKeys.Send("00")
        End If
        If e.KeyValue = 111 Then
            SendKeys.Send("000")
        End If

    End Sub

    Private Sub CalcText_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CalcText.TextChanged
        Me.Text = CalcText.Text
        RaiseEvent TextChanged(sender, e)
    End Sub

    Private Sub UcCalcText_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Me.Height <> CalcText.Height Then
            SetHeight()
        End If
    End Sub

    Private Sub SetHeight()
        If CalcText.Height < 21 Then
            CalcText.Height = 21
            Me.Height = 21

        Else
            Me.Height = CalcText.Height
        End If
    End Sub

    Private Sub CalcText_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CalcText.KeyPress
        If e.KeyChar = "+" Or e.KeyChar = " " Then
            e.Handled = True
        End If
        If Me.DecimalDigits > 0 Then
            If CalcText.Text.IndexOf(".") = -1 Then
                If CalcText.Text.Trim.Length > Me.Maxlength - Me.DecimalDigits - 2 Then
                    If e.KeyChar = "." Or e.KeyChar = Microsoft.VisualBasic.ChrW(8) Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub CalcText_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CalcText.Leave
        CheckData()
        If Me.Numbervalue < 0 Then
            CalcText.ForeColor = MinusColor
        Else
            CalcText.ForeColor = Me.ForeColor
        End If
        _Flg = False
    End Sub

    Private Sub CheckData()
        Dim txtSplit As String()
        Dim noSplit As Integer
        Dim strTxt As String
        If DecimalDigits > 1 Then
            txtSplit = _Text.Split(".")
            If txtSplit.Length > 1 Then
                _Text = txtSplit(0) + "." + txtSplit(1).PadRight(DecimalDigits, "0")
                If txtSplit(1).Length > DecimalDigits Then
                    _Text = Math.Round(CType(_Text, Decimal), DecimalDigits)
                End If
            Else
                strTxt = "0"
                _Text = txtSplit(0) + "." + strTxt.PadRight(DecimalDigits, "0")
            End If
            Me.Text = _Text
        End If
    End Sub

    Private Sub UcCalcText_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        _Flg = True
    End Sub

    Private Sub CalcText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcText.Click
        RaiseEvent Click(sender, e)
    End Sub
    Private Sub CalcText_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcText.DoubleClick
        RaiseEvent DoubleClick(sender, e)
    End Sub

    Private Sub CalcText_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CalcText.KeyUp
        RaiseEvent KeyUp(sender, e)
    End Sub
End Class
