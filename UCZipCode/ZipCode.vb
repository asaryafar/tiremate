Imports CommonClass
Public Class ZipCode
    Inherits System.Windows.Forms.UserControl
    Private MCnn As System.Data.SqlClient.SqlConnection
    Shadows Event TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    Private MCity As String = ""
    Private MState As String = ""
    Private MZipCodeLen As Integer = LenZipCode
    Private MNotExitIfNotFound As Boolean
    Private MReleaseIfNotFoundZipCode As Boolean
    Public Event FindZipCode()
    Public Event NotFindZipCode()
    Dim ClsZipCode1 As New ClsZipCode
    Public ZipCodeNo As String = ""
    'Property BorderStyle() As BorderStyle
    '    Get
    '        Return TxtZipCode.BorderStyle
    '    End Get
    '    Set(ByVal Value As BorderStyle)
    '        TxtZipCode.BorderStyle = Value
    '    End Set
    'End Property
    Public Property NotExitIfNotFound() As Boolean
        Get
            Return MNotExitIfNotFound
        End Get
        Set(ByVal Value As Boolean)
            MNotExitIfNotFound = Value
        End Set
    End Property
    Public Property ReleaseIfNotFoundZipCode() As Boolean
        Get
            Return MReleaseIfNotFoundZipCode
        End Get
        Set(ByVal Value As Boolean)
            MReleaseIfNotFoundZipCode = Value
        End Set
    End Property
    ReadOnly Property City() As String
        Get
            Return MCity
        End Get
    End Property
    ReadOnly Property State() As String
        Get
            Return MState
        End Get
    End Property
    Public Property ZipCodeLen() As Integer
        Get
            Return MZipCodeLen
        End Get
        Set(ByVal Value As Integer)
            MZipCodeLen = LenZipCode
            TxtZipCode.MaxLength = LenZipCode
        End Set
    End Property
    Public Property Connection() As System.Data.SqlClient.SqlConnection
        Get
            Return MCnn
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            MCnn = Value
            ClsZipCode1.Connection = MCnn
        End Set
    End Property
    Public Property ZipCode() As String
        Get
            Return TxtZipCode.Text()
        End Get
        Set(ByVal Value As String)
            TxtZipCode.Text = Value
            Call FindThisZipCode()
        End Set
    End Property
    Shadows Property Text() As String
        Get
            Return TxtZipCode.Text
        End Get
        Set(ByVal Value As String)
            TxtZipCode.Text = Value
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
    'Friend WithEvents TxtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents TxtZipCode As Janus.Windows.GridEX.EditControls.EditBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TxtZipCode = New Janus.Windows.GridEX.EditControls.EditBox
        Me.SuspendLayout()
        '
        'TxtZipCode
        '
        Me.TxtZipCode.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtZipCode.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtZipCode.BackColor = System.Drawing.Color.White
        Me.TxtZipCode.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.TxtZipCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtZipCode.Location = New System.Drawing.Point(0, 0)
        Me.TxtZipCode.MaxLength = 5
        Me.TxtZipCode.Name = "TxtZipCode"
        Me.TxtZipCode.Size = New System.Drawing.Size(59, 20)
        Me.TxtZipCode.TabIndex = 0
        Me.TxtZipCode.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'ZipCode
        '
        Me.Controls.Add(Me.TxtZipCode)
        Me.Name = "ZipCode"
        Me.Size = New System.Drawing.Size(59, 21)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub TxtZipCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.TextChanged, TxtZipCode.TextChanged
        RaiseEvent TextChanged(sender, e)
        Call FindThisZipCode()
    End Sub
    Private Sub TxtZipCode_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus, TxtZipCode.LostFocus
        TxtZipCode.Text = TxtZipCode.Text.Trim
        Call FindThisZipCode()
        If MCity.Trim.Length = 0 Then
            TxtZipCode.Text = ""
        End If
        RaiseEvent LostFocus(sender, e)
    End Sub
    Private Function FindThisZipCode() As Boolean
        If ClsZipCode1.FindDesc(TxtZipCode.Text.Trim) Then
            FindThisZipCode = True
            MCity = ClsZipCode1.City.Trim
            MState = ClsZipCode1.State.Trim
            RaiseEvent FindZipCode()
        Else
            FindThisZipCode = False
            MCity = ""
            MState = ""
            If MReleaseIfNotFoundZipCode = True Then TxtZipCode.Text = ""
            RaiseEvent NotFindZipCode()
        End If
    End Function
    Private Sub TxtZipCode_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Validating, TxtZipCode.Validating
        TxtZipCode.Text = TxtZipCode.Text.Trim
        Call FindThisZipCode()
        If MNotExitIfNotFound = True And MCity = "" Then
            e.Cancel = True
        End If
    End Sub
    Private Sub CodKolUC_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.BackColorChanged
        TxtZipCode.BackColor = Me.BackColor
    End Sub
End Class
