Imports CommonClass
Public Class FrmItemComments
    Inherits FrmBase
    Public TxtCommentvar As String
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
    Public WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Public WithEvents TxtComments As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TxtComments = New System.Windows.Forms.TextBox
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.SuspendLayout()
        '
        'TxtComments
        '
        Me.TxtComments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtComments.Location = New System.Drawing.Point(0, 0)
        Me.TxtComments.Multiline = True
        Me.TxtComments.Name = "TxtComments"
        Me.TxtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtComments.Size = New System.Drawing.Size(313, 102)
        Me.TxtComments.TabIndex = 0
        Me.TxtComments.Text = ""
        '
        'CmdOk
        '
        Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOk.Enabled = False
        Me.CmdOk.Location = New System.Drawing.Point(229, 108)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 18
        Me.CmdOk.Text = "Ok"
        '
        'CmdExit
        '
        Me.CmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdExit.Location = New System.Drawing.Point(7, 108)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 23)
        Me.CmdExit.TabIndex = 17
        Me.CmdExit.Text = "Exit"
        '
        'FrmItemComments
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(312, 135)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.TxtComments)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmItemComments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Comments"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmComments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtCommentvar = TxtComments.Text
        If ThisFormStatus = MainModule.WorkStates._ReadOnly Then
            TxtComments.Enabled = False
            CmdOk.Enabled = False
        Else
            TxtComments.Enabled = True
            CmdOk.Enabled = True
        End If
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        TxtCommentvar = TxtComments.Text
        Me.Close()
    End Sub
    Private Sub TxtComments_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtComments.TextChanged
        If TxtComments.Enabled Then CmdOk.Enabled = True
    End Sub
End Class
