Public Class FrmShowErrorAllStoreInsert
    Inherits CommonClass.FrmBase

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
    Public WithEvents LstNote As System.Windows.Forms.ListBox
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel
    Friend WithEvents LblTop As System.Windows.Forms.Label
    Friend WithEvents CmdOk As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.LstNote = New System.Windows.Forms.ListBox
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.LblTop = New System.Windows.Forms.Label
        Me.CmdOk = New System.Windows.Forms.Button
        Me.PnlSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'LstNote
        '
        Me.LstNote.BackColor = System.Drawing.SystemColors.Control
        Me.LstNote.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstNote.ItemHeight = 16
        Me.LstNote.Location = New System.Drawing.Point(6, 54)
        Me.LstNote.Name = "LstNote"
        Me.LstNote.Size = New System.Drawing.Size(314, 144)
        Me.LstNote.TabIndex = 66
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.LblTop)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 0)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(318, 48)
        Me.PnlSearch.TabIndex = 67
        '
        'LblTop
        '
        Me.LblTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTop.Location = New System.Drawing.Point(7, 5)
        Me.LblTop.Name = "LblTop"
        Me.LblTop.Size = New System.Drawing.Size(361, 22)
        Me.LblTop.TabIndex = 12
        Me.LblTop.Text = "Multi Store Insert Operation Note"
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(96, 200)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.TabIndex = 68
        Me.CmdOk.Text = "Ok"
        '
        'FrmShowErrorAllStoreInsert
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(318, 236)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.LstNote)
        Me.Name = "FrmShowErrorAllStoreInsert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PnlSearch.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Me.Close()
    End Sub
End Class
