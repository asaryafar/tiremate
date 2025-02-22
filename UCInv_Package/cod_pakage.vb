Imports CommonClass
Public Class Cod_Pakage
    Inherits System.Windows.Forms.UserControl
    Private MCnn As System.Data.SqlClient.SqlConnection
    Shadows Event TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Private Mdesc_pakage As String = ""
    Private MCod_pakageLen As Integer = LenCod_Package
    Private MNotExitIfNotFound As Boolean
    Private MReleaseIfNotFoundCod_pakage As Boolean
    Public Event FindCod_pakage()
    Public Event NotFindCod_pakage()
    Dim WithEvents MyFrmSearchcod_pakage As New FrmSearchcod_pakage
    Dim ClsCod_pakage1 As New ClsCod_pakage
    '<Description("ÇÑ ˜Ï ˜á ãæÑÏ äÙÑ íÏÇ äÔÏ ÓíÓÊã ÂäÑÇ ÍÐÝ ˜äÏ"), Category("Behavior")> _

    Property BorderStyle() As BorderStyle
        Get
            Return Txtcod_pakage.BorderStyle
        End Get
        Set(ByVal Value As BorderStyle)
            Txtcod_pakage.BorderStyle = Value
        End Set
    End Property

    Public Property ActiveSearchBottun() As Boolean
        Get
            If Txtcod_pakage.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis Then
                Return True
            Else
                Return False
            End If
        End Get
        Set(ByVal Value As Boolean)
            If Value Then
                Txtcod_pakage.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis
            Else
                Txtcod_pakage.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
            End If

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
    Public Property ReleaseIfNotFoundCod_pakage() As Boolean
        Get
            Return MReleaseIfNotFoundCod_pakage
        End Get
        Set(ByVal Value As Boolean)
            MReleaseIfNotFoundCod_pakage = Value
        End Set
    End Property
    ReadOnly Property desc_pakage() As String
        Get
            Return Mdesc_pakage
        End Get
    End Property
    Public Property Cod_pakageLen() As Integer
        Get
            Return MCod_pakageLen
        End Get
        Set(ByVal Value As Integer)
            MCod_pakageLen = LenCod_Package
            Txtcod_pakage.MaxLength = LenCod_Package
        End Set
    End Property
    Public Property Connection() As System.Data.SqlClient.SqlConnection
        Get
            Return MCnn
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            MCnn = Value
            ClsCod_pakage1.Connection = MCnn
        End Set
    End Property

    Public Property Cod_pakage() As String
        Get
            Return Txtcod_pakage.Text()
        End Get
        Set(ByVal Value As String)
            Txtcod_pakage.Text = Value
            Call FindThisCod_pakage()
        End Set
    End Property

    Shadows Property Text() As String
        Get
            Return Txtcod_pakage.Text
        End Get
        Set(ByVal Value As String)
            Txtcod_pakage.Text = Value
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
    Friend WithEvents Txtcod_pakage As Janus.Windows.GridEX.EditControls.MaskedEditBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Txtcod_pakage = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.SuspendLayout()
        '
        'Txtcod_pakage
        '
        Me.Txtcod_pakage.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Txtcod_pakage.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Txtcod_pakage.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.Txtcod_pakage.ButtonFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Txtcod_pakage.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis
        Me.Txtcod_pakage.Dock = System.Windows.Forms.DockStyle.Top
        Me.Txtcod_pakage.Location = New System.Drawing.Point(0, 0)
        Me.Txtcod_pakage.Name = "Txtcod_pakage"
        Me.Txtcod_pakage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txtcod_pakage.Size = New System.Drawing.Size(72, 21)
        Me.Txtcod_pakage.TabIndex = 1
        Me.Txtcod_pakage.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'Cod_Pakage
        '
        Me.Controls.Add(Me.Txtcod_pakage)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Name = "Cod_Pakage"
        Me.Size = New System.Drawing.Size(72, 21)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Txtcod_pakage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.TextChanged, Txtcod_pakage.TextChanged
        RaiseEvent TextChanged(sender, e)
    End Sub
    'Private Sub Txtcod_pakage_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtcod_pakage.Leave
    'End Sub
    Private Sub Txtcod_pakage_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus, Txtcod_pakage.LostFocus
        'Txtcod_pakage.Text = Getcod(Txtcod_pakage.Text, MCod_pakageLen)
        Call FindThisCod_pakage()
    End Sub
    Sub FindThisCod_pakage()
        If Txtcod_pakage.Text = "" Then Exit Sub
        'If ClsCod_pakage1.FindDesc(Getcod(Txtcod_pakage.Text, MCod_pakageLen)) Then
        If ClsCod_pakage1.FindDesc(Txtcod_pakage.Text) Then
            Mdesc_pakage = ClsCod_pakage1.Desc_pakage
            RaiseEvent FindCod_pakage()
        Else
            Mdesc_pakage = ""
            If MReleaseIfNotFoundCod_pakage = True Then Txtcod_pakage.Text = ""
            RaiseEvent NotFindCod_pakage()
        End If
    End Sub
    Private Sub Txtcod_pakage_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Validating, Txtcod_pakage.Validating
        'Txtcod_pakage.Text = Getcod(Txtcod_pakage.Text, MCod_pakageLen)
        Call FindThisCod_pakage()
        If MNotExitIfNotFound = True And Mdesc_pakage = "" Then
            e.Cancel = True
        End If

    End Sub

    Private Sub Txtcod_pakage_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, Txtcod_pakage.KeyUp
        Select Case e.KeyCode
            Case Keys.F4
                If e.Shift = False And e.Alt = False And e.Control = False Then
                    MyFrmSearchcod_pakage.ShowDialog()
                End If
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub
    Private Sub Txtcod_pakage_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcod_pakage.ButtonClick
        MyFrmSearchcod_pakage.ShowDialog()
    End Sub
    Private Sub MyFrmSearchcod_pakage_Cod_pakageFind(ByVal ThisCod_pakage As String, ByVal Thisdesc_pakage As String, ByVal ThisPakageDataTable As DataTable) Handles MyFrmSearchcod_pakage.Cod_PakageFind
        Txtcod_pakage.Text = ThisCod_pakage
        Mdesc_pakage = Thisdesc_pakage
        Call ClsCod_pakage1.FillDs(ThisCod_pakage)
        RaiseEvent FindCod_pakage()
    End Sub
    Private Sub CodKolUC_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.BackColorChanged
        Txtcod_pakage.BackColor = Me.BackColor
    End Sub
End Class
