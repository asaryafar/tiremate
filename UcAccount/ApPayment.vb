Public Class ApPayment
    Inherits System.Windows.Forms.UserControl
    Private MCnn As System.Data.SqlClient.SqlConnection
    Private MNotExitIfNotFound As Boolean
    Private MReleaseIfNotFoundCustomerCod As Boolean
    Dim WithEvents MyFrmSearchApPayment As New FrmSearchApPayment
    Shadows Event TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event FindApPaymentCod(ByVal ThisApCod As String)
    Public Event NotFindApPayment()
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
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents TxtSearchAp As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ApPayment))
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.TxtSearchAp = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01_" & _
        "2006;persist security info=True;password=sa"
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.Location = New System.Drawing.Point(104, 2)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(24, 20)
        Me.BtnSearch.TabIndex = 3
        Me.BtnSearch.TabStop = False
        '
        'TxtSearchAp
        '
        Me.TxtSearchAp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearchAp.BackColor = System.Drawing.Color.YellowGreen
        Me.TxtSearchAp.Location = New System.Drawing.Point(1, 2)
        Me.TxtSearchAp.Name = "TxtSearchAp"
        Me.TxtSearchAp.Size = New System.Drawing.Size(103, 20)
        Me.TxtSearchAp.TabIndex = 2
        Me.TxtSearchAp.Text = ""
        '
        'ApPayment
        '
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxtSearchAp)
        Me.Name = "ApPayment"
        Me.Size = New System.Drawing.Size(128, 24)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Property Connection() As System.Data.SqlClient.SqlConnection
        Get
            Return MCnn
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            MCnn = Value
        End Set
    End Property

    Public Property ApPaymentCod() As String
        Get
            Return TxtSearchAp.Text()
        End Get
        Set(ByVal Value As String)
            TxtSearchAp.Text = Value
            Call FindThis()
        End Set
    End Property
    Shadows Property Text() As String
        Get
            Return TxtSearchAp.Text
        End Get
        Set(ByVal Value As String)
            TxtSearchAp.Text = Value
        End Set
    End Property

    Property BorderStyle() As BorderStyle
        Get
            Return TxtSearchAp.BorderStyle
        End Get
        Set(ByVal Value As BorderStyle)
            TxtSearchAp.BorderStyle = Value
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
    Public Property ReleaseIfNotFoundCustomerCod() As Boolean
        Get
            Return MReleaseIfNotFoundCustomerCod
        End Get
        Set(ByVal Value As Boolean)
            MReleaseIfNotFoundCustomerCod = Value
        End Set
    End Property

    Private Sub TxtCustomerCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchAp.TextChanged, MyBase.TextChanged
        RaiseEvent TextChanged(sender, e)
        Call FindThis()
    End Sub
    Private Sub TxtCustomerCod_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearchAp.LostFocus, MyBase.LostFocus
        TxtSearchAp.Text = TxtSearchAp.Text.Trim
        If Not FindThis() Then

        End If
    End Sub


    Private Sub TxtCustomerCod_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtSearchAp.Validating, MyBase.Validating
        'TxtCustomerCod.Text = Getcod(TxtCustomerCod.Text, MCustomerCodLen)
        TxtSearchAp.Text = TxtSearchAp.Text.Trim
        Call FindThis()
        If MNotExitIfNotFound = True Then
            e.Cancel = True
        End If
    End Sub
    Private Sub TxtCustomerCod_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSearchAp.KeyUp, MyBase.KeyUp
        Select Case e.KeyCode
            Case Keys.F4
                If e.Shift = False And e.Alt = False And e.Control = False Then
                    MyFrmSearchApPayment.ShowDialog()
                End If
            Case Keys.Enter
                If TxtSearchAp.Text.Length = 0 Then
                    SendKeys.Send("{TAB}")
                End If
        End Select
    End Sub
   
    Private Sub CustomerCod_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.BackColorChanged
        Try
            TxtSearchAp.BackColor = Me.BackColor
        Catch ex As Exception
        End Try
    End Sub
    Public Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        MyFrmSearchApPayment.ShowDialog()
    End Sub
    Private Sub TxtCustomerCod_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtSearchAp.DoubleClick
        'TxtCustomerCod.Text = "CASH"
        'SendKeys.Send("{TAB}")
    End Sub
    Function FindThis() As Boolean
        FindThis = False
        CmdGeneral.Connection.ConnectionString = CommonClass.PConnectionString
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = " select ID_AP_payment from GL_AP_payment where ID_AP_payment=" & TxtSearchAp.Text
        Try
            Dim t As String = CmdGeneral.ExecuteScalar() & ""
            If t <> "" Then
                FindThis = True
                TxtSearchAp.Text = t
            Else
                If MReleaseIfNotFoundCustomerCod = True Then TxtSearchAp.Text = ""
                RaiseEvent NotFindApPayment()
            End If
        Catch ex As Exception
            If MReleaseIfNotFoundCustomerCod = True Then TxtSearchAp.Text = ""
            RaiseEvent NotFindApPayment()
            FindThis = True
        Finally
            FindThis = False
            CmdGeneral.Connection.Close()
        End Try
    End Function
End Class
