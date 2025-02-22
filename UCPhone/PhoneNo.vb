Imports System.ComponentModel
Public Class PhoneNo
    Inherits System.Windows.Forms.UserControl
    Shadows Event TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    Private RealValue As String
    Dim Zarib As Double
    Private mText() As String
    '---------------------------------------------'
    Private _Text As String
    <Browsable(True)> _
    Shadows Property Text() As String
        Get
            If TxtNo1.Text.Trim <> "" Or TxtNo2.Text.Trim <> "" Or TxtNo3.Text.Trim <> "" Then
                _Text = TxtNo1.Text & "-" & TxtNo2.Text & "-" & TxtNo3.Text
            Else
                _Text = ""
            End If
            Return _Text
        End Get
        Set(ByVal Value As String)
            _Text = Value.Trim
            If _Text <> "" And Val(Mid(_Text, 1, 3)) > 0 Then
                mText = _Text.Split("-")
                TxtNo1.Text = mText(0).Trim
                Try
                    TxtNo2.Text = mText(1).Trim
                Catch ex As Exception
                    TxtNo2.Clear()
                End Try
                Try
                    TxtNo3.Text = mText(2).Trim
                Catch ex As Exception
                    TxtNo3.Clear()
                End Try
            Else
                TxtNo1.Clear()
                TxtNo2.Clear()
                TxtNo3.Clear()
            End If
        End Set
    End Property
    Shadows Property BorderStyle() As System.Windows.Forms.BorderStyle
        Get
            Return PnlDate.BorderStyle
        End Get
        Set(ByVal Value As System.Windows.Forms.BorderStyle)
            PnlDate.BorderStyle = Value
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PnlDate As System.Windows.Forms.Panel
    Friend WithEvents Slash2 As System.Windows.Forms.Label
    Friend WithEvents Slash1 As System.Windows.Forms.Label
    Friend WithEvents TxtNo3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNo2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNo1 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PhoneNo))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PnlDate = New System.Windows.Forms.Panel
        Me.Slash2 = New System.Windows.Forms.Label
        Me.Slash1 = New System.Windows.Forms.Label
        Me.TxtNo3 = New System.Windows.Forms.TextBox
        Me.TxtNo2 = New System.Windows.Forms.TextBox
        Me.TxtNo1 = New System.Windows.Forms.TextBox
        Me.PnlDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = CType(resources.GetObject("ImageList1.ImageSize"), System.Drawing.Size)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Magenta
        '
        'PnlDate
        '
        Me.PnlDate.AccessibleDescription = resources.GetString("PnlDate.AccessibleDescription")
        Me.PnlDate.AccessibleName = resources.GetString("PnlDate.AccessibleName")
        Me.PnlDate.Anchor = CType(resources.GetObject("PnlDate.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.PnlDate.AutoScroll = CType(resources.GetObject("PnlDate.AutoScroll"), Boolean)
        Me.PnlDate.AutoScrollMargin = CType(resources.GetObject("PnlDate.AutoScrollMargin"), System.Drawing.Size)
        Me.PnlDate.AutoScrollMinSize = CType(resources.GetObject("PnlDate.AutoScrollMinSize"), System.Drawing.Size)
        Me.PnlDate.BackgroundImage = CType(resources.GetObject("PnlDate.BackgroundImage"), System.Drawing.Image)
        Me.PnlDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlDate.Controls.Add(Me.Slash2)
        Me.PnlDate.Controls.Add(Me.Slash1)
        Me.PnlDate.Controls.Add(Me.TxtNo3)
        Me.PnlDate.Controls.Add(Me.TxtNo2)
        Me.PnlDate.Controls.Add(Me.TxtNo1)
        Me.PnlDate.Dock = CType(resources.GetObject("PnlDate.Dock"), System.Windows.Forms.DockStyle)
        Me.PnlDate.Enabled = CType(resources.GetObject("PnlDate.Enabled"), Boolean)
        Me.PnlDate.Font = CType(resources.GetObject("PnlDate.Font"), System.Drawing.Font)
        Me.PnlDate.ImeMode = CType(resources.GetObject("PnlDate.ImeMode"), System.Windows.Forms.ImeMode)
        Me.PnlDate.Location = CType(resources.GetObject("PnlDate.Location"), System.Drawing.Point)
        Me.PnlDate.Name = "PnlDate"
        Me.PnlDate.RightToLeft = CType(resources.GetObject("PnlDate.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.PnlDate.Size = CType(resources.GetObject("PnlDate.Size"), System.Drawing.Size)
        Me.PnlDate.TabIndex = CType(resources.GetObject("PnlDate.TabIndex"), Integer)
        Me.PnlDate.Text = resources.GetString("PnlDate.Text")
        Me.PnlDate.Visible = CType(resources.GetObject("PnlDate.Visible"), Boolean)
        '
        'Slash2
        '
        Me.Slash2.AccessibleDescription = resources.GetString("Slash2.AccessibleDescription")
        Me.Slash2.AccessibleName = resources.GetString("Slash2.AccessibleName")
        Me.Slash2.Anchor = CType(resources.GetObject("Slash2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Slash2.AutoSize = CType(resources.GetObject("Slash2.AutoSize"), Boolean)
        Me.Slash2.BackColor = System.Drawing.Color.White
        Me.Slash2.Dock = CType(resources.GetObject("Slash2.Dock"), System.Windows.Forms.DockStyle)
        Me.Slash2.Enabled = CType(resources.GetObject("Slash2.Enabled"), Boolean)
        Me.Slash2.Font = CType(resources.GetObject("Slash2.Font"), System.Drawing.Font)
        Me.Slash2.Image = CType(resources.GetObject("Slash2.Image"), System.Drawing.Image)
        Me.Slash2.ImageAlign = CType(resources.GetObject("Slash2.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Slash2.ImageIndex = CType(resources.GetObject("Slash2.ImageIndex"), Integer)
        Me.Slash2.ImeMode = CType(resources.GetObject("Slash2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Slash2.Location = CType(resources.GetObject("Slash2.Location"), System.Drawing.Point)
        Me.Slash2.Name = "Slash2"
        Me.Slash2.RightToLeft = CType(resources.GetObject("Slash2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Slash2.Size = CType(resources.GetObject("Slash2.Size"), System.Drawing.Size)
        Me.Slash2.TabIndex = CType(resources.GetObject("Slash2.TabIndex"), Integer)
        Me.Slash2.Text = resources.GetString("Slash2.Text")
        Me.Slash2.TextAlign = CType(resources.GetObject("Slash2.TextAlign"), System.Drawing.ContentAlignment)
        Me.Slash2.Visible = CType(resources.GetObject("Slash2.Visible"), Boolean)
        '
        'Slash1
        '
        Me.Slash1.AccessibleDescription = resources.GetString("Slash1.AccessibleDescription")
        Me.Slash1.AccessibleName = resources.GetString("Slash1.AccessibleName")
        Me.Slash1.Anchor = CType(resources.GetObject("Slash1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Slash1.AutoSize = CType(resources.GetObject("Slash1.AutoSize"), Boolean)
        Me.Slash1.BackColor = System.Drawing.Color.White
        Me.Slash1.Dock = CType(resources.GetObject("Slash1.Dock"), System.Windows.Forms.DockStyle)
        Me.Slash1.Enabled = CType(resources.GetObject("Slash1.Enabled"), Boolean)
        Me.Slash1.Font = CType(resources.GetObject("Slash1.Font"), System.Drawing.Font)
        Me.Slash1.Image = CType(resources.GetObject("Slash1.Image"), System.Drawing.Image)
        Me.Slash1.ImageAlign = CType(resources.GetObject("Slash1.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Slash1.ImageIndex = CType(resources.GetObject("Slash1.ImageIndex"), Integer)
        Me.Slash1.ImeMode = CType(resources.GetObject("Slash1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Slash1.Location = CType(resources.GetObject("Slash1.Location"), System.Drawing.Point)
        Me.Slash1.Name = "Slash1"
        Me.Slash1.RightToLeft = CType(resources.GetObject("Slash1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Slash1.Size = CType(resources.GetObject("Slash1.Size"), System.Drawing.Size)
        Me.Slash1.TabIndex = CType(resources.GetObject("Slash1.TabIndex"), Integer)
        Me.Slash1.Text = resources.GetString("Slash1.Text")
        Me.Slash1.TextAlign = CType(resources.GetObject("Slash1.TextAlign"), System.Drawing.ContentAlignment)
        Me.Slash1.Visible = CType(resources.GetObject("Slash1.Visible"), Boolean)
        '
        'TxtNo3
        '
        Me.TxtNo3.AccessibleDescription = resources.GetString("TxtNo3.AccessibleDescription")
        Me.TxtNo3.AccessibleName = resources.GetString("TxtNo3.AccessibleName")
        Me.TxtNo3.Anchor = CType(resources.GetObject("TxtNo3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TxtNo3.AutoSize = CType(resources.GetObject("TxtNo3.AutoSize"), Boolean)
        Me.TxtNo3.BackgroundImage = CType(resources.GetObject("TxtNo3.BackgroundImage"), System.Drawing.Image)
        Me.TxtNo3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNo3.Dock = CType(resources.GetObject("TxtNo3.Dock"), System.Windows.Forms.DockStyle)
        Me.TxtNo3.Enabled = CType(resources.GetObject("TxtNo3.Enabled"), Boolean)
        Me.TxtNo3.Font = CType(resources.GetObject("TxtNo3.Font"), System.Drawing.Font)
        Me.TxtNo3.ImeMode = CType(resources.GetObject("TxtNo3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TxtNo3.Location = CType(resources.GetObject("TxtNo3.Location"), System.Drawing.Point)
        Me.TxtNo3.MaxLength = CType(resources.GetObject("TxtNo3.MaxLength"), Integer)
        Me.TxtNo3.Multiline = CType(resources.GetObject("TxtNo3.Multiline"), Boolean)
        Me.TxtNo3.Name = "TxtNo3"
        Me.TxtNo3.PasswordChar = CType(resources.GetObject("TxtNo3.PasswordChar"), Char)
        Me.TxtNo3.RightToLeft = CType(resources.GetObject("TxtNo3.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TxtNo3.ScrollBars = CType(resources.GetObject("TxtNo3.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.TxtNo3.Size = CType(resources.GetObject("TxtNo3.Size"), System.Drawing.Size)
        Me.TxtNo3.TabIndex = CType(resources.GetObject("TxtNo3.TabIndex"), Integer)
        Me.TxtNo3.Text = resources.GetString("TxtNo3.Text")
        Me.TxtNo3.TextAlign = CType(resources.GetObject("TxtNo3.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.TxtNo3.Visible = CType(resources.GetObject("TxtNo3.Visible"), Boolean)
        Me.TxtNo3.WordWrap = CType(resources.GetObject("TxtNo3.WordWrap"), Boolean)
        '
        'TxtNo2
        '
        Me.TxtNo2.AccessibleDescription = resources.GetString("TxtNo2.AccessibleDescription")
        Me.TxtNo2.AccessibleName = resources.GetString("TxtNo2.AccessibleName")
        Me.TxtNo2.Anchor = CType(resources.GetObject("TxtNo2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TxtNo2.AutoSize = CType(resources.GetObject("TxtNo2.AutoSize"), Boolean)
        Me.TxtNo2.BackgroundImage = CType(resources.GetObject("TxtNo2.BackgroundImage"), System.Drawing.Image)
        Me.TxtNo2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNo2.Dock = CType(resources.GetObject("TxtNo2.Dock"), System.Windows.Forms.DockStyle)
        Me.TxtNo2.Enabled = CType(resources.GetObject("TxtNo2.Enabled"), Boolean)
        Me.TxtNo2.Font = CType(resources.GetObject("TxtNo2.Font"), System.Drawing.Font)
        Me.TxtNo2.ImeMode = CType(resources.GetObject("TxtNo2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TxtNo2.Location = CType(resources.GetObject("TxtNo2.Location"), System.Drawing.Point)
        Me.TxtNo2.MaxLength = CType(resources.GetObject("TxtNo2.MaxLength"), Integer)
        Me.TxtNo2.Multiline = CType(resources.GetObject("TxtNo2.Multiline"), Boolean)
        Me.TxtNo2.Name = "TxtNo2"
        Me.TxtNo2.PasswordChar = CType(resources.GetObject("TxtNo2.PasswordChar"), Char)
        Me.TxtNo2.RightToLeft = CType(resources.GetObject("TxtNo2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TxtNo2.ScrollBars = CType(resources.GetObject("TxtNo2.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.TxtNo2.Size = CType(resources.GetObject("TxtNo2.Size"), System.Drawing.Size)
        Me.TxtNo2.TabIndex = CType(resources.GetObject("TxtNo2.TabIndex"), Integer)
        Me.TxtNo2.Text = resources.GetString("TxtNo2.Text")
        Me.TxtNo2.TextAlign = CType(resources.GetObject("TxtNo2.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.TxtNo2.Visible = CType(resources.GetObject("TxtNo2.Visible"), Boolean)
        Me.TxtNo2.WordWrap = CType(resources.GetObject("TxtNo2.WordWrap"), Boolean)
        '
        'TxtNo1
        '
        Me.TxtNo1.AccessibleDescription = resources.GetString("TxtNo1.AccessibleDescription")
        Me.TxtNo1.AccessibleName = resources.GetString("TxtNo1.AccessibleName")
        Me.TxtNo1.Anchor = CType(resources.GetObject("TxtNo1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TxtNo1.AutoSize = CType(resources.GetObject("TxtNo1.AutoSize"), Boolean)
        Me.TxtNo1.BackgroundImage = CType(resources.GetObject("TxtNo1.BackgroundImage"), System.Drawing.Image)
        Me.TxtNo1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNo1.Dock = CType(resources.GetObject("TxtNo1.Dock"), System.Windows.Forms.DockStyle)
        Me.TxtNo1.Enabled = CType(resources.GetObject("TxtNo1.Enabled"), Boolean)
        Me.TxtNo1.Font = CType(resources.GetObject("TxtNo1.Font"), System.Drawing.Font)
        Me.TxtNo1.ImeMode = CType(resources.GetObject("TxtNo1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TxtNo1.Location = CType(resources.GetObject("TxtNo1.Location"), System.Drawing.Point)
        Me.TxtNo1.MaxLength = CType(resources.GetObject("TxtNo1.MaxLength"), Integer)
        Me.TxtNo1.Multiline = CType(resources.GetObject("TxtNo1.Multiline"), Boolean)
        Me.TxtNo1.Name = "TxtNo1"
        Me.TxtNo1.PasswordChar = CType(resources.GetObject("TxtNo1.PasswordChar"), Char)
        Me.TxtNo1.RightToLeft = CType(resources.GetObject("TxtNo1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TxtNo1.ScrollBars = CType(resources.GetObject("TxtNo1.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.TxtNo1.Size = CType(resources.GetObject("TxtNo1.Size"), System.Drawing.Size)
        Me.TxtNo1.TabIndex = CType(resources.GetObject("TxtNo1.TabIndex"), Integer)
        Me.TxtNo1.Text = resources.GetString("TxtNo1.Text")
        Me.TxtNo1.TextAlign = CType(resources.GetObject("TxtNo1.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.TxtNo1.Visible = CType(resources.GetObject("TxtNo1.Visible"), Boolean)
        Me.TxtNo1.WordWrap = CType(resources.GetObject("TxtNo1.WordWrap"), Boolean)
        '
        'PhoneNo
        '
        Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
        Me.AccessibleName = resources.GetString("$this.AccessibleName")
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.Controls.Add(Me.PnlDate)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.Name = "PhoneNo"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Size = CType(resources.GetObject("$this.Size"), System.Drawing.Size)
        Me.PnlDate.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    'Sub HandleUpdate(ByVal temp As String)
    '    Me.PhoneNo = temp
    'End Sub
    Private Sub TxtNo1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNo1.KeyPress
        Select Case e.KeyChar.ToString
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
            Case "-"
                e.Handled = True
                TxtNo2.Focus()
            Case Keys.Back, Keys.Left, Keys.Right, Keys.Home, Keys.End, Keys.Delete, Keys.Insert, Keys.Tab, Keys.Enter
            Case Chr(8) 'BackSpace
            Case Chr(27) 'Esc
            Case Else
                e.Handled = True
        End Select
        MyBase.OnKeyPress(e)
    End Sub
    Private Sub TxtNo2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNo2.KeyPress
        Select Case e.KeyChar.ToString
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
            Case "-"
                e.Handled = True
                TxtNo3.Focus()
            Case Keys.Back, Keys.Left, Keys.Right, Keys.Home, Keys.End, Keys.Delete, Keys.Insert, Keys.Tab, Keys.Enter
            Case Chr(8) 'BackSpace
            Case Chr(27) 'Esc
            Case Else
                e.Handled = True
        End Select
        MyBase.OnKeyPress(e)
    End Sub
    Private Sub TxtNo3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNo3.KeyPress
        Select Case e.KeyChar.ToString
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"
            Case "-"
                e.Handled = True
                TxtNo3.Focus()
            Case Keys.Back, Keys.Left, Keys.Right, Keys.Home, Keys.End, Keys.Delete, Keys.Insert, Keys.Tab, Keys.Enter
            Case Chr(8) 'BackSpace
            Case Chr(27) 'Esc
            Case Else
                e.Handled = True
        End Select
        MyBase.OnKeyPress(e)
    End Sub
    Private Sub TxtNo1_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNo1.GotFocus
        TxtNo1.SelectAll()
        RaiseEvent GotFocus(sender, e)
    End Sub
    Private Sub TxtNo2_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNo2.GotFocus
        TxtNo2.SelectAll()
    End Sub
    Private Sub TxtNo3_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNo3.GotFocus
        TxtNo3.SelectAll()
    End Sub
    Private Sub TxtNo1_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtNo1.Validating
        If TxtNo1.Text.Trim.Length = 0 Then
            TxtNo2.Clear()
            TxtNo3.Clear()
        End If
    End Sub
    Private Sub TxtNo2_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtNo2.Validating
        If TxtNo2.Text.Trim.Length = 0 Then
            TxtNo1.Clear()
            TxtNo3.Clear()
        End If
    End Sub
    Private Sub TxtNo3_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtNo3.Validating
        'If TxtNo3.Text.Trim.Length = 0 Then
        '    TxtNo1.Clear()
        '    TxtNo2.Clear()
        'Else
        '    If TxtNo3.Text.Trim.Length = 1 Then
        '        TxtNo3.Text = "0" & TxtNo3.Text.Trim
        '    End If
        'End If
    End Sub
    Private Sub TimeBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtNo1.BackColor = Me.BackColor
        TxtNo2.BackColor = Me.BackColor
        TxtNo3.BackColor = Me.BackColor
        Slash1.BackColor = Me.BackColor
        Slash2.BackColor = Me.BackColor
        PnlDate.BackColor = Me.BackColor
    End Sub
    Private Sub TxtNo1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNo1.KeyUp
        If TxtNo1.Text.Trim.Length = TxtNo1.MaxLength And TxtNo1.SelectedText.Length = 0 Then
            TxtNo2.Focus()
        End If
    End Sub
    Private Sub TxtNo2_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNo2.KeyUp
        If TxtNo2.Text.Trim.Length = TxtNo2.MaxLength And TxtNo2.SelectedText.Length = 0 Then
            TxtNo3.Focus()
        End If
    End Sub
    Private Sub TxtNo1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNo1.TextChanged
        'Me.Text = TxtNo1.Text & "-" & TxtNo2.Text & "-" & TxtNo3.Text
        RaiseEvent TextChanged(sender, e)
    End Sub
    Private Sub TxtNo2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNo2.TextChanged
        'Me.Text = TxtNo1.Text & "-" & TxtNo2.Text & "-" & TxtNo3.Text
        RaiseEvent TextChanged(sender, e)
    End Sub
    Private Sub TxtNo3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNo3.TextChanged
        'Me.Text = TxtNo1.Text & "-" & TxtNo2.Text & "-" & TxtNo3.Text
        RaiseEvent TextChanged(sender, e)
    End Sub
    Private Sub UcPhone_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If sender.width < 88 Then
            sender.Width = 120
        End If
        If sender.height > 23 Then
            sender.height = 23
        End If
        Call Initit()
    End Sub
    Sub Initit()
        PnlDate.Left = 0
        PnlDate.Top = 0
        PnlDate.Height = TxtNo1.Height + 8
        PnlDate.Width = Me.Width
        '--------------------------------------
        'Zarib = (1 * Me.Width) / 12
        '--------------------
        Zarib = 90 / 12
        '----------------------------
        TxtNo1.Left = 0
        TxtNo1.Top = 2
        TxtNo1.Width = Int(3 * Zarib)

        Slash1.Top = 2
        Slash1.Left = TxtNo1.Width
        Slash1.Width = Int(Zarib)

        TxtNo2.Top = 2
        TxtNo2.Left = TxtNo1.Width + Slash1.Width
        TxtNo2.Width = Int(3 * Zarib)

        Slash2.Top = 2
        Slash2.Left = TxtNo1.Width + Slash1.Width + TxtNo2.Width
        Slash2.Width = Int(Zarib)

        TxtNo3.Top = 2

        TxtNo3.Left = TxtNo1.Width + Slash1.Width + TxtNo2.Width + Slash2.Width
        TxtNo3.Width = Int(4 * Zarib)

        Slash2.Height = TxtNo1.Height
        Slash1.Height = TxtNo1.Height
    End Sub
    Private Sub UcPhone_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.BackColorChanged
        PnlDate.BackColor = Me.BackColor
        TxtNo3.BackColor = Me.BackColor
        TxtNo2.BackColor = Me.BackColor
        TxtNo1.BackColor = Me.BackColor
    End Sub
    Private Sub UcPhone_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        TxtNo1.Focus()
    End Sub
    Protected Overrides Sub OnFontChanged(ByVal e As System.EventArgs)
        TxtNo3.Font = Me.Font
        TxtNo2.Font = Me.Font
        TxtNo1.Font = Me.Font
        PnlDate.Font = Me.Font
    End Sub
End Class
