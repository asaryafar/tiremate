Public Class FrmUTQGShow
    Inherits System.Windows.Forms.Form
    Public MyTop As Integer
    Public MyLeft As Integer

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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TreadWear As System.Windows.Forms.Label
    Friend WithEvents Traction As System.Windows.Forms.Label
    Friend WithEvents Temp2erature As System.Windows.Forms.Label
    Friend WithEvents Temperature As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Temperature = New System.Windows.Forms.Label
        Me.Traction = New System.Windows.Forms.Label
        Me.TreadWear = New System.Windows.Forms.Label
        Me.Temp2erature = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Temperature)
        Me.Panel1.Controls.Add(Me.Traction)
        Me.Panel1.Controls.Add(Me.TreadWear)
        Me.Panel1.Controls.Add(Me.Temp2erature)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(151, 80)
        Me.Panel1.TabIndex = 357
        '
        'Temperature
        '
        Me.Temperature.Location = New System.Drawing.Point(79, 55)
        Me.Temperature.Name = "Temperature"
        Me.Temperature.Size = New System.Drawing.Size(61, 23)
        Me.Temperature.TabIndex = 363
        '
        'Traction
        '
        Me.Traction.Location = New System.Drawing.Point(79, 32)
        Me.Traction.Name = "Traction"
        Me.Traction.Size = New System.Drawing.Size(61, 23)
        Me.Traction.TabIndex = 362
        '
        'TreadWear
        '
        Me.TreadWear.Location = New System.Drawing.Point(79, 7)
        Me.TreadWear.Name = "TreadWear"
        Me.TreadWear.Size = New System.Drawing.Size(61, 23)
        Me.TreadWear.TabIndex = 361
        '
        'Temp2erature
        '
        Me.Temp2erature.Location = New System.Drawing.Point(11, 55)
        Me.Temp2erature.Name = "Temp2erature"
        Me.Temp2erature.Size = New System.Drawing.Size(69, 24)
        Me.Temp2erature.TabIndex = 360
        Me.Temp2erature.Text = "Temperature"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 23)
        Me.Label2.TabIndex = 358
        Me.Label2.Text = "Traction"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 23)
        Me.Label1.TabIndex = 357
        Me.Label1.Text = "TreadWear"
        '
        'FrmUTQGShow
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(152, 80)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FrmUTQGShow"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Event CloseMe()
    Private Sub FrmUTQGShow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = MyTop
        Me.Left = MyLeft
    End Sub
    Private Sub FrmUTQGShow_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            RaiseEvent CloseMe()
        End If
    End Sub
    Private Sub FrmUTQGShow_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        RaiseEvent CloseMe()
    End Sub
End Class
