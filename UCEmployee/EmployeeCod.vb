Imports CommonClass
Public Class Employee_Cod
    Inherits System.Windows.Forms.UserControl
    Private MCnn As System.Data.SqlClient.SqlConnection
    Shadows Event TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Private MDesc_Employee As String = ""
    Private Mcod_Employee As String = ""
    Private MKind_Employee As String = ""
    Private MEmployee_CodLen As Integer = LenEmployeeCod
    Private MNotExitIfNotFound As Boolean
    Private MReleaseIfNotFoundEmployeeCod As Boolean
    Public Event FindEmployeeCod()
    Public Event NotFindEmployeeCod()
    Dim WithEvents MyFrmSearchEmployeeCode As New FrmSearchEmployeeCode
    Dim ClsEmployeeCod1 As New ClsEmployeeCod
    '<Description("ÇÑ ˜Ï ˜á ãæÑÏ äÙÑ íÏÇ äÔÏ ÓíÓÊã ÂäÑÇ ÍÐÝ ˜äÏ"), Category("Behavior")> _
    Property BorderStyle() As BorderStyle
        Get
            Return TxtEmployeeCod.BorderStyle
        End Get
        Set(ByVal Value As BorderStyle)
            TxtEmployeeCod.BorderStyle = Value
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
    ReadOnly Property cod_Employee() As String
        Get
            Return Mcod_Employee
        End Get
    End Property
    Public Property Kind_Employee() As String
        Get
            Return MKind_Employee
        End Get
        Set(ByVal Value As String)
            MKind_Employee = Value
        End Set
    End Property
    ReadOnly Property Desc_Employee() As String
        Get
            Return MDesc_Employee
        End Get
    End Property
    Public Property EmployeeCodLen() As Integer
        Get
            Return MEmployee_CodLen
        End Get
        Set(ByVal Value As Integer)
            MEmployee_CodLen = LenEmployeeCod
            TxtEmployeeCod.MaxLength = LenEmployeeCod
        End Set
    End Property
    Public Property Connection() As System.Data.SqlClient.SqlConnection
        Get
            Return MCnn
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            MCnn = Value
            ClsEmployeeCod1.Connection = MCnn
        End Set
    End Property

    Public Property EmployeeCod() As String
        Get
            Return TxtEmployeeCod.Text
        End Get
        Set(ByVal Value As String)
            TxtEmployeeCod.Text = Value
            Call FindThisEmployeeCod()
        End Set
    End Property
    Shadows Property Text() As String
        Get
            Return TxtEmployeeCod.Text
        End Get
        Set(ByVal Value As String)
            TxtEmployeeCod.Text = Value
        End Set
    End Property

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl1 overrides dispose to clean up the component list.
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
    Friend WithEvents TxtEmployeeCod As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Employee_Cod))
        Me.TxtEmployeeCod = New System.Windows.Forms.TextBox
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TxtEmployeeCod
        '
        Me.TxtEmployeeCod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEmployeeCod.BackColor = System.Drawing.Color.YellowGreen
        Me.TxtEmployeeCod.Location = New System.Drawing.Point(0, 0)
        Me.TxtEmployeeCod.Name = "TxtEmployeeCod"
        Me.TxtEmployeeCod.Size = New System.Drawing.Size(76, 20)
        Me.TxtEmployeeCod.TabIndex = 0
        Me.TxtEmployeeCod.Text = ""
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.Location = New System.Drawing.Point(76, 0)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(24, 20)
        Me.BtnSearch.TabIndex = 1
        Me.BtnSearch.TabStop = False
        '
        'Employee_Cod
        '
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxtEmployeeCod)
        Me.Name = "Employee_Cod"
        Me.Size = New System.Drawing.Size(101, 20)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub TxtEmployeeCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.TextChanged, TxtEmployeeCod.TextChanged
        RaiseEvent TextChanged(sender, e)
        Call FindThisEmployeeCod()
    End Sub
    Private Sub TxtEmployeeCod_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus, TxtEmployeeCod.LostFocus
        TxtEmployeeCod.Text = TxtEmployeeCod.Text.Trim
        Call FindThisEmployeeCod()
    End Sub
    Private Function FindThisEmployeeCod() As Boolean
        'If TxtEmployeeCod.Text = "" Then Exit Function
        'If ClsEmployeeCod1.FindDesc(Getcod(TxtEmployeeCod.Text, MEmployeeCodLen)) Then
        If ClsEmployeeCod1.FindDesc(TxtEmployeeCod.Text.Trim) Then
            FindThisEmployeeCod = True
            Mcod_Employee = ClsEmployeeCod1.cod_Employee.Trim
            MDesc_Employee = ClsEmployeeCod1.desc_Employee.Trim
            FindThisEmployeeCod = True
            RaiseEvent FindEmployeeCod()
        Else
            FindThisEmployeeCod = False
            Mcod_Employee = ""
            MDesc_Employee = ""
            'If MReleaseIfNotFoundEmployeeCod = True Then TxtEmployeeCod.Text = ""
            FindThisEmployeeCod = False
            RaiseEvent NotFindEmployeeCod()
        End If
    End Function
    Private Sub TxtEmployeeCod_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Validating, TxtEmployeeCod.Validating
        'TxtEmployeeCod.Text = Getcod(TxtEmployeeCod.Text, MEmployeeCodLen)
        TxtEmployeeCod.Text = TxtEmployeeCod.Text.Trim
        Call FindThisEmployeeCod()
        If MNotExitIfNotFound = True And MDesc_Employee = "" Then
            e.Cancel = True
        End If
    End Sub
    Private Sub TxtEmployeeCod_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, TxtEmployeeCod.KeyUp
        Select Case e.KeyCode
            Case Keys.F4
                If e.Shift = False And e.Alt = False And e.Control = False Then
                    MyFrmSearchEmployeeCode.ShowDialog()
                End If
                'Case Keys.Enter
                '    TxtEmployeeCod.Text = "CASH"
                '    SendKeys.Send("{TAB}")
                '    SendKeys.Send("{TAB}")
        End Select
    End Sub
    Private Sub MyFrmSearchEmployeeCode_EmployeeCodFind(ByVal ThisEmployeeCod As String, ByVal ThisDesc_Employee As String) Handles MyFrmSearchEmployeeCode.EmployeeFind
        TxtEmployeeCod.Text = ThisEmployeeCod
        Mcod_Employee = ThisEmployeeCod
        MDesc_Employee = ThisDesc_Employee
        RaiseEvent FindEmployeeCod()
    End Sub
    Private Sub CodKolUC_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.BackColorChanged
        TxtEmployeeCod.BackColor = Me.BackColor
    End Sub
    Public Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        MyFrmSearchEmployeeCode.KindEmployee = Kind_Employee
        MyFrmSearchEmployeeCode.ShowDialog()
    End Sub

    Private Sub Employee_Cod_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        If Not FindThisEmployeeCod() Then
            If MReleaseIfNotFoundEmployeeCod = True Then
                TxtEmployeeCod.Text = ""
                Mcod_Employee = ""
                MDesc_Employee = ""
            End If
        End If
    End Sub
End Class
