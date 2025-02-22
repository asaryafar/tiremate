Imports CommonClass
Public Class FrmBase
    Inherits System.Windows.Forms.Form
    Dim MySetLocation As Boolean = False
    Dim MyCenterMe As Boolean = False
    Public ThisFormStatus As WorkStates
    Property SetLocation() As Boolean
        Get
            Return MySetLocation
        End Get
        Set(ByVal Value As Boolean)
            MySetLocation = Value
        End Set
    End Property
    Property CenterMe() As Boolean
        Get
            Return MyCenterMe
        End Get
        Set(ByVal Value As Boolean)
            MyCenterMe = Value
        End Set
    End Property
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmBase))
        '
        'FrmBase
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(376, 310)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmBase"

    End Sub

#End Region
    Private Sub FrmBase_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call MakeDbNameAndConnection()
        'If Cpro.FindSerialNumber() <> "y34fw6ye".ToUpper Then
        '    MsgFar("Bad Copy Protection")
        'End If
        If SetLocation Then
            Me.Left = 145
            Me.Top = 47
        End If
        If CenterMe Then
            Me.Left = 220
            Me.Top = 47
        End If
    End Sub
End Class
