Imports System.Windows.Forms
Public Class FrmWhatDoForMenu
    Inherits FrmBase
    Public BtnLeftText As String = ""
    Public BtnCenterText As String = ""
    Public BtnRightText As String = ""
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
    Friend WithEvents BtnLeft As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnRight As Janus.Windows.EditControls.UIButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCenter As Janus.Windows.EditControls.UIButton
    Friend WithEvents TxtMsg As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmWhatDoForMenu))
        Me.BtnLeft = New Janus.Windows.EditControls.UIButton
        Me.BtnRight = New Janus.Windows.EditControls.UIButton
        Me.BtnCenter = New Janus.Windows.EditControls.UIButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TxtMsg = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'BtnLeft
        '
        Me.BtnLeft.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnLeft.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnLeft.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnLeft.Location = New System.Drawing.Point(17, 92)
        Me.BtnLeft.Name = "BtnLeft"
        Me.BtnLeft.Size = New System.Drawing.Size(89, 23)
        Me.BtnLeft.TabIndex = 0
        Me.BtnLeft.Text = "Cancel"
        '
        'BtnRight
        '
        Me.BtnRight.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnRight.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnRight.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnRight.Location = New System.Drawing.Point(249, 92)
        Me.BtnRight.Name = "BtnRight"
        Me.BtnRight.Size = New System.Drawing.Size(89, 23)
        Me.BtnRight.TabIndex = 2
        Me.BtnRight.Text = "OK"
        '
        'BtnCenter
        '
        Me.BtnCenter.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnCenter.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.BtnCenter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnCenter.Location = New System.Drawing.Point(133, 92)
        Me.BtnCenter.Name = "BtnCenter"
        Me.BtnCenter.Size = New System.Drawing.Size(89, 23)
        Me.BtnCenter.TabIndex = 1
        Me.BtnCenter.Text = "Yes"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 60)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'TxtMsg
        '
        Me.TxtMsg.Location = New System.Drawing.Point(72, 3)
        Me.TxtMsg.Name = "TxtMsg"
        Me.TxtMsg.Size = New System.Drawing.Size(275, 84)
        Me.TxtMsg.TabIndex = 3
        Me.TxtMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmWhatDoForMenu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(354, 120)
        Me.Controls.Add(Me.TxtMsg)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnCenter)
        Me.Controls.Add(Me.BtnRight)
        Me.Controls.Add(Me.BtnLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "FrmWhatDoForMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmWhatDoForMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If BtnLeftText.Trim.Length > 0 Then
            BtnLeft.Text = BtnLeftText
        Else
            BtnLeft.Visible = False
        End If
        If BtnCenterText.Trim.Length > 0 Then
            BtnCenter.Text = BtnCenterText
        Else
            BtnCenter.Visible = False
        End If
        If BtnRightText.Trim.Length > 0 Then
            BtnRight.Text = BtnRightText
        Else
            BtnRight.Visible = False
        End If
        If Not (BtnRight.Visible Or BtnCenter.Visible Or BtnLeft.Visible) Then
            BtnLeft.Visible = True
            BtnLeft.Text = "Cancel"
            BtnRight.Visible = True
            BtnRight.Text = "OK"
        End If
    End Sub
    Public Sub ShowFarMsg(ByVal ThisText As String)
        Me.TxtMsg.Text = ThisText
        Me.ShowDialog()
    End Sub
    'Private Sub FrmWhatDoForMenu_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
    '    SendKeys.Send("{INS}")
    '    SendKeys.Send("{INS}")
    'End Sub
End Class


