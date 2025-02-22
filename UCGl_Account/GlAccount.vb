Public Class GlAccount
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
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents TxtGlCod As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(GlAccount))
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.TxtGlCod = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.Location = New System.Drawing.Point(104, 0)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(24, 20)
        Me.BtnSearch.TabIndex = 3
        Me.BtnSearch.TabStop = False
        '
        'TxtGlCod
        '
        Me.TxtGlCod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtGlCod.BackColor = System.Drawing.Color.YellowGreen
        Me.TxtGlCod.Location = New System.Drawing.Point(1, 0)
        Me.TxtGlCod.MaxLength = 10
        Me.TxtGlCod.Name = "TxtGlCod"
        Me.TxtGlCod.Size = New System.Drawing.Size(103, 20)
        Me.TxtGlCod.TabIndex = 2
        Me.TxtGlCod.Text = ""
        '
        'GlAccount
        '
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxtGlCod)
        Me.Name = "GlAccount"
        Me.Size = New System.Drawing.Size(128, 20)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private MCnn As System.Data.SqlClient.SqlConnection
    Shadows Event TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Private MDesc_Gl As String = ""
    Private Mcod_Gl As String = ""
    '  Private MEmployee_CodLen As Integer = LenEmployeeCod
    Private MNotExitIfNotFound As Boolean
    Private MReleaseIfNotFoundEmployeeCod As Boolean
    Public Event FindGlCod()
    Public Event NotFindGlCod()
    Dim WithEvents MyFrmSearchGl As New FrmGlChartOfAccountSearch
    Dim ClsGlAccount1 As New ClsGlAccount
    '<Description("ÇÑ ˜Ï ˜á ãæÑÏ äÙÑ íÏÇ äÔÏ ÓíÓÊã ÂäÑÇ ÍÐÝ ˜äÏ"), Category("Behavior")> _
    Property BorderStyle() As BorderStyle
        Get
            Return TxtGlCod.BorderStyle
        End Get
        Set(ByVal Value As BorderStyle)
            TxtGlCod.BorderStyle = Value
        End Set
    End Property
    Public Property NotExitIfNotFound() As Boolean
        Get
            Return MNotExitIfNotFound
        End Get
        Set(ByVal Value As Boolean)
            MNotExitIfNotFound = Value
        End Set
    End Property
    Public Property ReleaseIfNotFoundEmployeeCod() As Boolean
        Get
            Return MReleaseIfNotFoundEmployeeCod
        End Get
        Set(ByVal Value As Boolean)
            MReleaseIfNotFoundEmployeeCod = Value
        End Set
    End Property
    'ReadOnly Property Cod_Gl() As String
    '    Get
    '        Return Mcod_Gl
    '    End Get
    'End Property
    ReadOnly Property Desc_Gl() As String
        Get
            Return MDesc_Gl
        End Get
    End Property
    Public Property Connection() As System.Data.SqlClient.SqlConnection
        Get
            Return MCnn
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            MCnn = Value
            ClsGlAccount1.Connection = MCnn
        End Set
    End Property

    Public Property Cod_Gl() As String
        Get
            Return TxtGlCod.Text
        End Get
        Set(ByVal Value As String)
            TxtGlCod.Text = Value
            Call FindThisGlCod()
        End Set
    End Property
    Shadows Property Text() As String
        Get
            Return TxtGlCod.Text
        End Get
        Set(ByVal Value As String)
            TxtGlCod.Text = Value
        End Set
    End Property


    Private Sub TxtGlCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.TextChanged, TxtGlCod.TextChanged
        RaiseEvent TextChanged(sender, e)
        Call FindThisGlCod()
    End Sub
    Private Sub TxtGlCod_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus, TxtGlCod.LostFocus
        TxtGlCod.Text = TxtGlCod.Text.Trim
        Call FindThisGlCod()
    End Sub
    Private Function FindThisGlCod() As Boolean
        'If TxtGlCod.Text = "" Then Exit Function
        If ClsGlAccount1.FindDesc(TxtGlCod.Text) Then
            If ClsGlAccount1.FindDesc(TxtGlCod.Text.Trim) Then
                FindThisGlCod = True
                Mcod_Gl = ClsGlAccount1.Cod_Gl.Trim
                MDesc_Gl = ClsGlAccount1.Desc_Gl.Trim
                RaiseEvent FindGlCod()
            Else
                FindThisGlCod = False
                Cod_Gl = ""
                MDesc_Gl = ""
                If MReleaseIfNotFoundEmployeeCod = True Then TxtGlCod.Text = ""
                RaiseEvent NotFindGlCod()
            End If
        End If
    End Function
    Private Sub TxtGlCod_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Validating, TxtGlCod.Validating
        'TxtGlCod.Text = Getcod(TxtGlCod.Text, MEmployeeCodLen)
        TxtGlCod.Text = TxtGlCod.Text.Trim
        Call FindThisGlCod()
        If MNotExitIfNotFound = True And MDesc_Gl = "" Then
            e.Cancel = True
        End If
    End Sub
    Private Sub TxtGlCod_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, TxtGlCod.KeyUp
        Select Case e.KeyCode
            Case Keys.F4
                If e.Shift = False And e.Alt = False And e.Control = False Then
                    MyFrmSearchGl.ShowDialog()
                End If
                'Case Keys.Enter
                '    TxtGlCod.Text = "CASH"
                '    SendKeys.Send("{TAB}")
                '    SendKeys.Send("{TAB}")
        End Select
    End Sub
    Private Sub CodKolUC_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.BackColorChanged
        TxtGlCod.BackColor = Me.BackColor
    End Sub
    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        MyFrmSearchGl.ShowDialog()
    End Sub

    Private Sub MyFrmSearchGl_GlAccountFind(ByVal ThisRow As System.Data.DataRow) Handles MyFrmSearchGl.GlAccountFind
        TxtGlCod.Text = ThisRow.Item("GL_account") & ""
        Mcod_Gl = ThisRow.Item("GL_account") & ""
        MDesc_Gl = ThisRow.Item("desc_GL_account") & ""
        RaiseEvent FindGlCod()
    End Sub
End Class
