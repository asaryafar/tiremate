Imports CommonClass
Public Class FrmSendMailInformation
    Inherits FrmBase
    Public IsOkFlag As Boolean = False
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
    Public WithEvents TxtSubject As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents TxtBody As System.Windows.Forms.TextBox
    Friend WithEvents BtnOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnCancle As Janus.Windows.EditControls.UIButton
    Public WithEvents txtTo As EmailAndWebAddress.EmailAddress
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TxtSubject = New System.Windows.Forms.TextBox
        Me.txtTo = New EmailAndWebAddress.EmailAddress
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtBody = New System.Windows.Forms.TextBox
        Me.BtnOk = New Janus.Windows.EditControls.UIButton
        Me.BtnCancle = New Janus.Windows.EditControls.UIButton
        Me.SuspendLayout()
        '
        'TxtSubject
        '
        Me.TxtSubject.Location = New System.Drawing.Point(65, 31)
        Me.TxtSubject.Name = "TxtSubject"
        Me.TxtSubject.Size = New System.Drawing.Size(444, 20)
        Me.TxtSubject.TabIndex = 1
        Me.TxtSubject.Text = ""
        '
        'txtTo
        '
        Me.txtTo.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.txtTo.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.txtTo.ErrorColor = System.Drawing.Color.Red
        Me.txtTo.ErrorMessage = "abc@microsoft.com ¬œ—” Å”  «·ò —Ê‰ÌòÌ »«Ì” Ì »Â «Ì‰ ’Ê—  »«‘œ"
        Me.txtTo.Location = New System.Drawing.Point(65, 6)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(234, 20)
        Me.txtTo.TabIndex = 0
        Me.txtTo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.txtTo.ValidationExpression = "^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0" & _
        "-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-" & _
        "9][0-9]|[1-9][0-9]|[0-9])\])$"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 354
        Me.Label1.Text = "To :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(5, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 19)
        Me.Label2.TabIndex = 355
        Me.Label2.Text = "Subject :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(6, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 19)
        Me.Label3.TabIndex = 356
        Me.Label3.Text = "Body :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtBody
        '
        Me.TxtBody.Location = New System.Drawing.Point(65, 58)
        Me.TxtBody.MaxLength = 1000
        Me.TxtBody.Multiline = True
        Me.TxtBody.Name = "TxtBody"
        Me.TxtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtBody.Size = New System.Drawing.Size(444, 170)
        Me.TxtBody.TabIndex = 2
        Me.TxtBody.Text = ""
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(396, 234)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(106, 23)
        Me.BtnOk.TabIndex = 3
        Me.BtnOk.Text = "OK"
        '
        'BtnCancle
        '
        Me.BtnCancle.Location = New System.Drawing.Point(14, 234)
        Me.BtnCancle.Name = "BtnCancle"
        Me.BtnCancle.Size = New System.Drawing.Size(106, 23)
        Me.BtnCancle.TabIndex = 4
        Me.BtnCancle.Text = "Cancle"
        '
        'FrmSendMailInformation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(517, 257)
        Me.Controls.Add(Me.BtnCancle)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.TxtBody)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSubject)
        Me.Name = "FrmSendMailInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send Mail Information"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmSendMailInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IsOkFlag = False
    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        IsOkFlag = True
        Me.Close()
    End Sub
    Private Sub BtnCancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancle.Click
        IsOkFlag = False
        Me.Close()
    End Sub
End Class
