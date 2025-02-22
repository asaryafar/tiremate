Public Class FrmMsg
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UiButton1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents TxtMsg As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtMsg = New System.Windows.Forms.Label
        Me.UiButton1 = New Janus.Windows.EditControls.UIButton
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtMsg)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 88)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'TxtMsg
        '
        Me.TxtMsg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TxtMsg.Location = New System.Drawing.Point(3, 17)
        Me.TxtMsg.Name = "TxtMsg"
        Me.TxtMsg.Size = New System.Drawing.Size(276, 68)
        Me.TxtMsg.TabIndex = 0
        Me.TxtMsg.Text = "Label1"
        Me.TxtMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UiButton1
        '
        Me.UiButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.UiButton1.Location = New System.Drawing.Point(200, 92)
        Me.UiButton1.Name = "UiButton1"
        Me.UiButton1.Size = New System.Drawing.Size(75, 23)
        Me.UiButton1.TabIndex = 6
        Me.UiButton1.Text = "OK"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=REZAEEXP;packet size=4096;user id=sa;data source=REZAEEXP;persist " & _
        "security info=True;initial catalog=maskan_01_83"
        '
        'FrmMsg
        '
        Me.AcceptButton = Me.UiButton1
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.UiButton1
        Me.ClientSize = New System.Drawing.Size(282, 120)
        Me.Controls.Add(Me.UiButton1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMsg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton1.Click
        Me.Close()
    End Sub
End Class
