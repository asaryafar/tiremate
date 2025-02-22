Public Class UCPrintGrid
    Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl overrides dispose to clean up the component list.
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
    Friend WithEvents UiButton1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdFieldChooser As Janus.Windows.EditControls.UIButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.UiButton1 = New Janus.Windows.EditControls.UIButton
        Me.CmdFieldChooser = New Janus.Windows.EditControls.UIButton
        Me.SuspendLayout()
        '
        'UiButton1
        '
        Me.UiButton1.Location = New System.Drawing.Point(1, 1)
        Me.UiButton1.Name = "UiButton1"
        Me.UiButton1.Size = New System.Drawing.Size(87, 23)
        Me.UiButton1.TabIndex = 210
        Me.UiButton1.Text = "Print"
        '
        'CmdFieldChooser
        '
        Me.CmdFieldChooser.Location = New System.Drawing.Point(87, 1)
        Me.CmdFieldChooser.Name = "CmdFieldChooser"
        Me.CmdFieldChooser.Size = New System.Drawing.Size(89, 23)
        Me.CmdFieldChooser.TabIndex = 211
        Me.CmdFieldChooser.Text = "Field  Chooser"
        '
        'UCPrintGrid
        '
        Me.Controls.Add(Me.CmdFieldChooser)
        Me.Controls.Add(Me.UiButton1)
        Me.Name = "UCPrintGrid"
        Me.Size = New System.Drawing.Size(176, 24)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim MGridX As Janus.Windows.GridEX.GridEX
    Dim frmref As System.Windows.Forms.Form
    Property GridEx() As Janus.Windows.GridEX.GridEX
        Get
            Return MGridX
        End Get
        Set(ByVal Value As Janus.Windows.GridEX.GridEX)
            MGridX = Value
        End Set
    End Property

    Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton1.Click
        Dim prn1 As New ClsPrintGrid
        prn1.PrintThisGrid(MGridX)
    End Sub

    Private Sub CmdFieldChooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdFieldChooser.Click

        Try
            Me.GridEx.ShowFieldChooser(Me.ParentForm)
            'RaiseEvent fieldchooser()
        Catch ex As Exception
        End Try
    End Sub

End Class
