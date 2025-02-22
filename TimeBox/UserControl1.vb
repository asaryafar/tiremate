Public Class UserControl1
    Inherits System.Windows.Forms.UserControl
    Public Property TextYM() As String
        Get
            Dim TextYMReturnValue As String
            TextYMReturnValue = TxtYear.Text & "/" & TxtMonth.Text
            Return TextYMReturnValue
        End Get
        Set(ByVal Value As String)
            Try
                TxtYear.Text = Mid(Value, 1, 2)
                TxtMonth.Text = Mid(Value, 4, 2)
            Catch ex As Exception
            End Try
        End Set
    End Property
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl1 overrides dispose to clean up the component list.
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
    Friend WithEvents TxtSeperator As System.Windows.Forms.TextBox
    Friend WithEvents TxtMonth As System.Windows.Forms.TextBox
    Friend WithEvents TxtYear As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TxtSeperator = New System.Windows.Forms.TextBox
        Me.TxtMonth = New System.Windows.Forms.TextBox
        Me.TxtYear = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'TxtSeperator
        '
        Me.TxtSeperator.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtSeperator.Location = New System.Drawing.Point(32, 0)
        Me.TxtSeperator.MaxLength = 1
        Me.TxtSeperator.Name = "TxtSeperator"
        Me.TxtSeperator.Size = New System.Drawing.Size(12, 21)
        Me.TxtSeperator.TabIndex = 5
        Me.TxtSeperator.TabStop = False
        Me.TxtSeperator.Text = ":"
        Me.TxtSeperator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtMonth
        '
        Me.TxtMonth.Dock = System.Windows.Forms.DockStyle.Right
        Me.TxtMonth.Location = New System.Drawing.Point(44, 0)
        Me.TxtMonth.MaxLength = 2
        Me.TxtMonth.Name = "TxtMonth"
        Me.TxtMonth.Size = New System.Drawing.Size(20, 21)
        Me.TxtMonth.TabIndex = 4
        Me.TxtMonth.Text = "01"
        '
        'TxtYear
        '
        Me.TxtYear.Dock = System.Windows.Forms.DockStyle.Left
        Me.TxtYear.Location = New System.Drawing.Point(0, 0)
        Me.TxtYear.MaxLength = 2
        Me.TxtYear.Name = "TxtYear"
        Me.TxtYear.Size = New System.Drawing.Size(32, 21)
        Me.TxtYear.TabIndex = 3
        Me.TxtYear.Text = "83"
        '
        'UserControl1
        '
        Me.Controls.Add(Me.TxtSeperator)
        Me.Controls.Add(Me.TxtMonth)
        Me.Controls.Add(Me.TxtYear)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(64, 22)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub TXTYear_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtYear.KeyPress
        Select Case e.KeyChar.ToString
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
            Case "/"
                TxtMonth.Focus()
            Case Keys.Back, Keys.Left, Keys.Right, Keys.Home, Keys.End, Keys.Delete, Keys.Insert, Keys.Tab, Keys.Enter
            Case Chr(8) 'BackSpace
            Case Chr(27) 'Esc
            Case Else
                e.Handled = True
        End Select
        MyBase.OnKeyPress(e)
    End Sub
    Private Sub TXTMonth_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMonth.KeyPress
        Select Case e.KeyChar.ToString
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
            Case "/"
                TxtYear.Focus()
            Case Keys.Back, Keys.Left, Keys.Right, Keys.Home, Keys.End, Keys.Delete, Keys.Insert, Keys.Tab, Keys.Enter
            Case Chr(8) 'BackSpace
            Case Chr(27) 'Esc
            Case Else
                e.Handled = True
        End Select
        MyBase.OnKeyPress(e)
    End Sub
    Private Sub TXTYear_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtYear.GotFocus
        TxtYear.SelectAll()
    End Sub
    Private Sub TXTMonth_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtMonth.GotFocus
        TxtMonth.SelectAll()
    End Sub
    Private Sub TxtMonth_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtMonth.Validating
        If Val(TxtMonth.Text) < 1 Or Val(TxtMonth.Text) > 12 Then
            TxtMonth.SelectAll()
            e.Cancel = True
        Else
            If TxtMonth.Text.Trim.Length = 1 Then
                TxtMonth.Text = "0" & TxtMonth.Text.Trim
            End If
        End If
    End Sub
    Private Sub TxtYear_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtYear.Validating
        If Val(TxtYear.Text) < 80 Or Val(TxtYear.Text) > 99 Then
            TxtYear.SelectAll()
            e.Cancel = True
        End If
    End Sub
    Private Sub YearMonth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtYear.BackColor = Me.BackColor
        TxtMonth.BackColor = Me.BackColor
        TxtSeperator.BackColor = Me.BackColor
    End Sub
End Class
