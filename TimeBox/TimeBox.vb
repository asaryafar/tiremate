Imports System.ComponentModel
Imports CommonClass
Public Class TimeBox
    Inherits System.Windows.Forms.UserControl
    Shadows Event TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Private _Text As String
    <Browsable(True)> _
    Public Shadows Property Text() As String
        Get
            Dim TextTimeReturnValue As String
            TextTimeReturnValue = Getcod(TxtHour.Text, 2) & ":" & Getcod(TxtMinute.Text, 2)
            Return TextTimeReturnValue
        End Get
        Set(ByVal Value As String)
            Try
                Dim ColumnPosition As Integer
                ColumnPosition = InStr(Value, ":")
                If ColumnPosition < 1 Then
                    TxtHour.Text = "00"
                    TxtMinute.Text = "00"
                Else
                    TxtHour.Text = Getcod(Mid(Value, 1, ColumnPosition - 1), 2)
                    TxtMinute.Text = Getcod(Mid(Value, ColumnPosition + 1, 2), 2)
                End If
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
    Public WithEvents TxtMinute As System.Windows.Forms.TextBox
    Public WithEvents TxtHour As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TxtSeperator = New System.Windows.Forms.TextBox
        Me.TxtMinute = New System.Windows.Forms.TextBox
        Me.TxtHour = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'TxtSeperator
        '
        Me.TxtSeperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSeperator.Location = New System.Drawing.Point(25, 0)
        Me.TxtSeperator.MaxLength = 1
        Me.TxtSeperator.Name = "TxtSeperator"
        Me.TxtSeperator.Size = New System.Drawing.Size(12, 20)
        Me.TxtSeperator.TabIndex = 5
        Me.TxtSeperator.TabStop = False
        Me.TxtSeperator.Text = ":"
        Me.TxtSeperator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtMinute
        '
        Me.TxtMinute.Dock = System.Windows.Forms.DockStyle.Right
        Me.TxtMinute.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMinute.Location = New System.Drawing.Point(37, 0)
        Me.TxtMinute.MaxLength = 2
        Me.TxtMinute.Name = "TxtMinute"
        Me.TxtMinute.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtMinute.Size = New System.Drawing.Size(25, 20)
        Me.TxtMinute.TabIndex = 4
        Me.TxtMinute.Text = " 00"
        Me.TxtMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtHour
        '
        Me.TxtHour.Dock = System.Windows.Forms.DockStyle.Left
        Me.TxtHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtHour.Location = New System.Drawing.Point(0, 0)
        Me.TxtHour.MaxLength = 2
        Me.TxtHour.Name = "TxtHour"
        Me.TxtHour.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtHour.Size = New System.Drawing.Size(25, 20)
        Me.TxtHour.TabIndex = 3
        Me.TxtHour.Text = "00"
        Me.TxtHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TimeBox
        '
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.TxtSeperator)
        Me.Controls.Add(Me.TxtMinute)
        Me.Controls.Add(Me.TxtHour)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "TimeBox"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Size = New System.Drawing.Size(62, 20)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub TxtHour_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHour.KeyPress
        Select Case e.KeyChar.ToString
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
            Case ":"
                e.Handled = True
                TxtMinute.Focus()
            Case Keys.Back, Keys.Left, Keys.Right, Keys.Home, Keys.End, Keys.Delete, Keys.Insert, Keys.Tab, Keys.Enter
            Case Chr(8) 'BackSpace
            Case Chr(27) 'Esc
            Case Else
                e.Handled = True
        End Select
        MyBase.OnKeyPress(e)
    End Sub
    Private Sub TxtMinute_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMinute.KeyPress
        Select Case e.KeyChar.ToString
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
            Case ":"
                e.Handled = True
                TxtHour.Focus()
            Case Keys.Back, Keys.Left, Keys.Right, Keys.Home, Keys.End, Keys.Delete, Keys.Insert, Keys.Tab, Keys.Enter
            Case Chr(8) 'BackSpace
            Case Chr(27) 'Esc
            Case Else
                e.Handled = True
        End Select
        MyBase.OnKeyPress(e)
    End Sub
    Private Sub TXTHour_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtHour.GotFocus
        TxtHour.SelectAll()
    End Sub
    Private Sub TxtMinute_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtMinute.GotFocus
        TxtMinute.SelectAll()
    End Sub
    Private Sub TxtMinute_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtMinute.Validating
        TxtMinute.Text = Getcod(TxtMinute.Text, 2)
        If Val(TxtMinute.Text) < 0 Or Val(TxtMinute.Text) > 59 Then
            TxtMinute.SelectAll()
            e.Cancel = True
        End If
    End Sub
    Private Sub TxtHour_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtHour.Validating
        TxtHour.Text = Getcod(TxtHour.Text, 2)
        If Val(TxtHour.Text) < 0 Or Val(TxtHour.Text) > 99 Then
            TxtHour.SelectAll()
            e.Cancel = True
        End If
    End Sub
    Private Sub TimeBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtHour.BackColor = Me.BackColor
        TxtMinute.BackColor = Me.BackColor
        TxtSeperator.BackColor = Me.BackColor
    End Sub
    Private Sub TxtHour_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtHour.KeyUp
        If TxtHour.Text.Trim.Length = TxtHour.MaxLength And TxtHour.SelectedText.Length = 0 Then
            TxtMinute.Focus()
        End If
    End Sub
    Private Sub TxtHour_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtHour.TextChanged
        RaiseEvent TextChanged(sender, e)
    End Sub
    Private Sub TxtMinute_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtMinute.TextChanged
        RaiseEvent TextChanged(sender, e)
    End Sub
End Class
