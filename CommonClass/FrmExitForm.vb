Public Class FrmExitForm
    Inherits System.Windows.Forms.Form
    Private WhatDoClick As Integer = 2
    Public ReadOnly Property WhatDo() As Integer
        Get
            If WhatDoClick <= 0 And WhatDoClick > 3 Then
                WhatDoClick = 2
            End If
            Return WhatDoClick
        End Get
    End Property

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
    Friend WithEvents CmdClose As System.Windows.Forms.Button
    Friend WithEvents CmdContinue As System.Windows.Forms.Button
    Friend WithEvents CmdSaveExit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CmdClose = New System.Windows.Forms.Button
        Me.CmdContinue = New System.Windows.Forms.Button
        Me.CmdSaveExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'CmdClose
        '
        Me.CmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClose.Location = New System.Drawing.Point(0, 8)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(88, 23)
        Me.CmdClose.TabIndex = 18
        Me.CmdClose.Text = "Œ—ÊÃ »œÊ‰ À» "
        '
        'CmdContinue
        '
        Me.CmdContinue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdContinue.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdContinue.Location = New System.Drawing.Point(96, 8)
        Me.CmdContinue.Name = "CmdContinue"
        Me.CmdContinue.Size = New System.Drawing.Size(80, 23)
        Me.CmdContinue.TabIndex = 17
        Me.CmdContinue.Text = "«œ«„Â "
        '
        'CmdSaveExit
        '
        Me.CmdSaveExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdSaveExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdSaveExit.Location = New System.Drawing.Point(184, 8)
        Me.CmdSaveExit.Name = "CmdSaveExit"
        Me.CmdSaveExit.Size = New System.Drawing.Size(79, 23)
        Me.CmdSaveExit.TabIndex = 16
        Me.CmdSaveExit.Text = "À»  Ê Œ—ÊÃ"
        '
        'FrmExitForm
        '
        Me.AcceptButton = Me.CmdContinue
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.CmdContinue
        Me.ClientSize = New System.Drawing.Size(266, 34)
        Me.Controls.Add(Me.CmdClose)
        Me.Controls.Add(Me.CmdContinue)
        Me.Controls.Add(Me.CmdSaveExit)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmExitForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " «ÌÌœ Œ—ÊÃ «“ ›—„"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Event CloseForm()
    Event SaveAndClose()
    Event Continue()
    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        WhatDoClick = 1
        RaiseEvent CloseForm()
        Me.Close()
    End Sub
    Private Sub CmdContinue_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdContinue.Click
        WhatDoClick = 2
        RaiseEvent CloseForm()
        Me.Close()
    End Sub
    Private Sub CmdSaveExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdSaveExit.Click
        WhatDoClick = 3
        RaiseEvent SaveAndClose()
        Me.Close()
    End Sub
End Class
