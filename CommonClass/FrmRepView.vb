Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmRepView
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
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    '    Friend WithEvents CrViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Public WithEvents CrViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.CrViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=KETABI;packet size=4096;user id=sa;data source=DEVELOPERSERVER;per" & _
        "sist security info=True;initial catalog=HamkarMachine;password=110"
        '
        'CrViewer
        '
        Me.CrViewer.ActiveViewIndex = -1
        Me.CrViewer.DisplayGroupTree = False
        Me.CrViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrViewer.Location = New System.Drawing.Point(0, 0)
        Me.CrViewer.Name = "CrViewer"
        Me.CrViewer.ReportSource = Nothing
        Me.CrViewer.ShowCloseButton = False
        Me.CrViewer.ShowGroupTreeButton = False
        Me.CrViewer.Size = New System.Drawing.Size(712, 443)
        Me.CrViewer.TabIndex = 2
        '
        'FrmRepView
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(712, 443)
        Me.Controls.Add(Me.CrViewer)
        Me.MaximizeBox = True
        Me.Name = "FrmRepView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Preview"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub btnSelectReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub
    Private Sub FrmRepView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 1
        Me.Left = 0
        'Me.Width = PubMFrmMain.Width - PubMFrmMain.MainActiveMenu.Width - 9
        'Me.Height = PubMFrmMain.Height - PubMFrmMain.Sb1.Height - 58
        Me.CrViewer.Zoom(1)
        Me.KeyPreview = True
    End Sub

    Private Sub FrmRepView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
