Imports CommonClass
Public Class FrmShowChangedNo
    Inherits FrmBase
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
    Public WithEvents LblLabel As System.Windows.Forms.Label
    Friend WithEvents BtnOK As Janus.Windows.EditControls.UIButton
    Public WithEvents LblOldNo As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents LblNewNo As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.LblLabel = New System.Windows.Forms.Label
        Me.LblOldNo = New System.Windows.Forms.Label
        Me.BtnOK = New Janus.Windows.EditControls.UIButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.LblNewNo = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'LblLabel
        '
        Me.LblLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLabel.Location = New System.Drawing.Point(8, 8)
        Me.LblLabel.Name = "LblLabel"
        Me.LblLabel.Size = New System.Drawing.Size(443, 25)
        Me.LblLabel.TabIndex = 0
        Me.LblLabel.Text = "Transaction Numbers are assigned on ""First Come First Serve"" basis."
        Me.LblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblOldNo
        '
        Me.LblOldNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOldNo.ForeColor = System.Drawing.Color.Red
        Me.LblOldNo.Location = New System.Drawing.Point(149, 41)
        Me.LblOldNo.Name = "LblOldNo"
        Me.LblOldNo.Size = New System.Drawing.Size(153, 31)
        Me.LblOldNo.TabIndex = 1
        Me.LblOldNo.Text = "LblOldNo"
        Me.LblOldNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(195, 142)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(97, 32)
        Me.BtnOK.TabIndex = 2
        Me.BtnOK.Text = "OK"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Transaction Number"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(407, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "has just been utilized by another user due to an earlier SAVE."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(292, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Your transaction is therefore being saved as"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(302, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "previously assigned to you,"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(453, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNewNo
        '
        Me.LblNewNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNewNo.ForeColor = System.Drawing.Color.Red
        Me.LblNewNo.Location = New System.Drawing.Point(300, 107)
        Me.LblNewNo.Name = "LblNewNo"
        Me.LblNewNo.Size = New System.Drawing.Size(159, 31)
        Me.LblNewNo.TabIndex = 8
        Me.LblNewNo.Text = "LblNewNo"
        Me.LblNewNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmShowChangedNo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(486, 178)
        Me.Controls.Add(Me.LblNewNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.LblOldNo)
        Me.Controls.Add(Me.LblLabel)
        Me.MinimizeBox = False
        Me.Name = "FrmShowChangedNo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        Me.Close()
    End Sub
End Class
