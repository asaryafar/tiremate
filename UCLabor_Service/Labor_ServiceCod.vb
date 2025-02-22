Imports CommonClass
Public Class Labor_Service_Cod
    Inherits System.Windows.Forms.UserControl
    Private MCnn As System.Data.SqlClient.SqlConnection
    Shadows Event TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Private MDesc_Service As String = ""
    Private MCod_Service As String = ""
    Private MLabor_service_CodLen As Integer = LenLabor_serviceCod
    Private MNotExitIfNotFound As Boolean
    Private MReleaseIfNotFoundLabor_serviceCod As Boolean
    Public Event FindLabor_serviceCod()
    Public Event NotFindLabor_serviceCod()
    Dim WithEvents MyFrmSearchLabor_serviceCod As New FrmSearchLabor_ServiceCod
    Dim ClsLabor_serviceCod1 As New ClsLabor_ServiceCod
    '<Description("ÇÑ ˜Ï ˜á ãæÑÏ äÙÑ íÏÇ äÔÏ ÓíÓÊã ÂäÑÇ ÍÐÝ ˜äÏ"), Category("Behavior")> _
    Property BorderStyle() As BorderStyle
        Get
            Return TxtLabor_ServiceCod.BorderStyle
        End Get
        Set(ByVal Value As BorderStyle)
            TxtLabor_ServiceCod.BorderStyle = Value
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
    Public Property ReleaseIfNotFoundLabor_serviceCod() As Boolean
        Get
            Return MReleaseIfNotFoundLabor_serviceCod
        End Get
        Set(ByVal Value As Boolean)
            MReleaseIfNotFoundLabor_serviceCod = Value
        End Set
    End Property
    ReadOnly Property Cod_Service() As String
        Get
            Return MCod_Service
        End Get
    End Property
    ReadOnly Property Desc_Service() As String
        Get
            Return MDesc_Service
        End Get
    End Property
    Public Property Labor_serviceCodLen() As Integer
        Get
            Return MLabor_service_CodLen
        End Get
        Set(ByVal Value As Integer)
            MLabor_service_CodLen = LenLabor_serviceCod
            TxtLabor_ServiceCod.MaxLength = LenLabor_serviceCod
        End Set
    End Property
    Public Property Connection() As System.Data.SqlClient.SqlConnection
        Get
            Return MCnn
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            MCnn = Value
            ClsLabor_serviceCod1.Connection = MCnn
        End Set
    End Property
    Public Property Labor_serviceCod() As String
        Get
            Return TxtLabor_ServiceCod.Text()
        End Get
        Set(ByVal Value As String)
            TxtLabor_ServiceCod.Text = Value
            Call FindThisLabor_serviceCod()
        End Set
    End Property
    Shadows Property Text() As String
        Get
            Return TxtLabor_ServiceCod.Text
        End Get
        Set(ByVal Value As String)
            TxtLabor_ServiceCod.Text = Value
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
    Friend WithEvents TxtLabor_ServiceCod As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Labor_Service_Cod))
        Me.TxtLabor_ServiceCod = New System.Windows.Forms.TextBox
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TxtLabor_ServiceCod
        '
        Me.TxtLabor_ServiceCod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtLabor_ServiceCod.BackColor = System.Drawing.Color.YellowGreen
        Me.TxtLabor_ServiceCod.Location = New System.Drawing.Point(0, 0)
        Me.TxtLabor_ServiceCod.Name = "TxtLabor_ServiceCod"
        Me.TxtLabor_ServiceCod.Size = New System.Drawing.Size(76, 20)
        Me.TxtLabor_ServiceCod.TabIndex = 0
        Me.TxtLabor_ServiceCod.Text = ""
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
        'Labor_Service_Cod
        '
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxtLabor_ServiceCod)
        Me.Name = "Labor_Service_Cod"
        Me.Size = New System.Drawing.Size(101, 20)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub TxtLabor_serviceCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.TextChanged, TxtLabor_ServiceCod.TextChanged
        RaiseEvent TextChanged(sender, e)
        Call FindThisLabor_serviceCod()
    End Sub
    Private Sub TxtLabor_serviceCod_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus, TxtLabor_ServiceCod.LostFocus
        TxtLabor_ServiceCod.Text = TxtLabor_ServiceCod.Text.Trim
        Call FindThisLabor_serviceCod()
    End Sub
    Private Function FindThisLabor_serviceCod() As Boolean
        'If TxtLabor_serviceCod.Text = "" Then Exit Function
        'If ClsLabor_serviceCod1.FindDesc(Getcod(TxtLabor_serviceCod.Text, MLabor_serviceCodLen)) Then
        If ClsLabor_serviceCod1.FindDesc(TxtLabor_ServiceCod.Text.Trim) Then
            FindThisLabor_serviceCod = True
            MCod_Service = ClsLabor_serviceCod1.cod_Service.Trim
            MDesc_Service = ClsLabor_serviceCod1.desc_Service.Trim
            RaiseEvent FindLabor_serviceCod()
        Else
            FindThisLabor_serviceCod = False
            MCod_Service = ""
            MDesc_Service = ""
            If MReleaseIfNotFoundLabor_serviceCod = True Then TxtLabor_ServiceCod.Text = ""
            RaiseEvent NotFindLabor_serviceCod()
        End If
    End Function
    Private Sub TxtLabor_serviceCod_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Validating, TxtLabor_ServiceCod.Validating
        'TxtLabor_serviceCod.Text = Getcod(TxtLabor_serviceCod.Text, MLabor_serviceCodLen)
        TxtLabor_ServiceCod.Text = TxtLabor_ServiceCod.Text.Trim
        Call FindThisLabor_serviceCod()
        If MNotExitIfNotFound = True And MDesc_Service = "" Then
            e.Cancel = True
        End If
    End Sub
    Private Sub TxtLabor_serviceCod_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, TxtLabor_ServiceCod.KeyUp
        Select Case e.KeyCode
            Case Keys.F4
                If e.Shift = False And e.Alt = False And e.Control = False Then
                    MyFrmSearchLabor_serviceCod.ShowDialog()
                End If
                'Case Keys.Enter
                '    TxtLabor_serviceCod.Text = "CASH"
                '    SendKeys.Send("{TAB}")
                '    SendKeys.Send("{TAB}")
        End Select
    End Sub
    Private Sub MyFrmSearchLabor_serviceCod_ServiceCodFind(ByVal ThisLabor_serviceCod As String, ByVal ThisDesc_Service As String) Handles MyFrmSearchLabor_serviceCod.Labor_ServiceFind
        TxtLabor_ServiceCod.Text = ThisLabor_serviceCod
        MCod_Service = ThisLabor_serviceCod
        MDesc_Service = ThisDesc_Service
        RaiseEvent FindLabor_serviceCod()
    End Sub
    Private Sub CodKolUC_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.BackColorChanged
        TxtLabor_ServiceCod.BackColor = Me.BackColor
    End Sub
    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        MyFrmSearchLabor_serviceCod.ShowDialog()
    End Sub
End Class
