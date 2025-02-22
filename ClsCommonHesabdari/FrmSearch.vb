Imports CommonClass
Public Class FrmSearch
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents CmbSearch As System.Windows.Forms.ComboBox
    Public WithEvents TxtSearch As System.Windows.Forms.TextBox
    Public WithEvents CmdFind As System.Windows.Forms.Button
    Public WithEvents CmdExit As System.Windows.Forms.Button
    Public WithEvents ChkPlace As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CmbSearch = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmdFind = New System.Windows.Forms.Button
        Me.CmdExit = New System.Windows.Forms.Button
        Me.ChkPlace = New System.Windows.Forms.CheckBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CmbSearch)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(334, 56)
        Me.Panel1.TabIndex = 0
        '
        'CmbSearch
        '
        Me.CmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSearch.Location = New System.Drawing.Point(0, 16)
        Me.CmbSearch.Name = "CmbSearch"
        Me.CmbSearch.Size = New System.Drawing.Size(232, 21)
        Me.CmbSearch.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(232, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ÌÓÊÌæ ÈÑ ÇÓÇÓ"
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(8, 88)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(312, 21)
        Me.TxtSearch.TabIndex = 1
        Me.TxtSearch.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(232, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ãÊä ãæÑÏ ÌÓÊÌæ"
        '
        'CmdFind
        '
        Me.CmdFind.Enabled = False
        Me.CmdFind.Location = New System.Drawing.Point(8, 128)
        Me.CmdFind.Name = "CmdFind"
        Me.CmdFind.TabIndex = 3
        Me.CmdFind.Text = "ÌÓÊÌæ"
        '
        'CmdExit
        '
        Me.CmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdExit.Location = New System.Drawing.Point(248, 128)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.TabIndex = 4
        Me.CmdExit.Text = "ÎÑæÌ"
        '
        'ChkPlace
        '
        Me.ChkPlace.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkPlace.Location = New System.Drawing.Point(16, 61)
        Me.ChkPlace.Name = "ChkPlace"
        Me.ChkPlace.Size = New System.Drawing.Size(208, 24)
        Me.ChkPlace.TabIndex = 5
        Me.ChkPlace.Text = "ãÍá ÔÑæÚ ÌÓÊÌæ ÇÒ ÇÈÊÏÇ"
        '
        'FrmSearch
        '
        Me.AcceptButton = Me.CmdFind
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.CmdExit
        Me.ClientSize = New System.Drawing.Size(334, 164)
        Me.Controls.Add(Me.ChkPlace)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.CmdFind)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmSearch"
        Me.Text = "ÌÓÊÌæ"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Event FndTHis(ByVal ThisSelectedItem As Integer, ByVal ThisText As String)
    Private Sub FrmSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChkPlace.Checked = True
        TxtSearch.Focus()
    End Sub
    Private Sub CmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdFind.Click
        RaiseEvent FndTHis(CmbSearch.SelectedIndex, TxtSearch.Text.Trim)
    End Sub
    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearch.TextChanged
        CmdFind.Enabled = TxtSearch.Text.Trim.Length > 0
    End Sub

    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
End Class
