Imports CommonClass
Imports System.ComponentModel
Public Class CommentButton
    Inherits System.Windows.Forms.UserControl
    Dim WithEvents MyFrmComments As FrmComments
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
    Friend WithEvents BtNComments As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CommentButton))
        Me.BtNComments = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'BtNComments
        '
        Me.BtNComments.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtNComments.Image = CType(resources.GetObject("BtNComments.Image"), System.Drawing.Image)
        Me.BtNComments.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.BtNComments.Location = New System.Drawing.Point(0, 0)
        Me.BtNComments.Name = "BtNComments"
        Me.BtNComments.Size = New System.Drawing.Size(102, 23)
        Me.BtNComments.TabIndex = 0
        Me.BtNComments.Text = "BtNComments"
        Me.BtNComments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CommentButton
        '
        Me.Controls.Add(Me.BtNComments)
        Me.Name = "CommentButton"
        Me.Size = New System.Drawing.Size(102, 23)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim _ZMaxCommentLength As Integer = 32767
    Dim _ZCommentFormheight As Integer = 0
    Dim _ZCommentFormWidth As Integer = 0
    Dim _ZShowInTop As Boolean = False
    Dim _ZShowInLeft As Boolean = False
    Dim _ZEnabled As Boolean = True
    Dim _ZButtonText As String
    Dim _ZCommentText As String
    <Description("The lnegth Of Comment in Table"), Category("Behavior")> _
        Property ZMaxCommentLength() As Integer
        Get
            ZMaxCommentLength = _ZMaxCommentLength
        End Get
        Set(ByVal Value As Integer)
            _ZMaxCommentLength = Value
        End Set
    End Property
    <Description("Indicates whether the control is enabled"), Category("Behavior")> _
    Public Property ZEnabled() As Boolean
        Get
            ZEnabled = _ZEnabled
        End Get
        Set(ByVal Value As Boolean)
            _ZEnabled = Value
        End Set
    End Property
    <Description("The Comment text Property "), Category("Behavior")> _
    Public Property ZCommentText() As String
        Get
            ZCommentText = _ZCommentText
        End Get
        Set(ByVal Value As String)
            _ZCommentText = Value
        End Set
    End Property
    <Description("The name of control"), Category("Behavior")> _
    Public Property ZButtonText() As String
        Get
            ZButtonText = _ZButtonText
        End Get
        Set(ByVal Value As String)
            _ZButtonText = Value
            BtNComments.Text = _ZButtonText
        End Set
    End Property
    <Description("Form Height.If it is 0 , program will automatically Set the form height"), Category("Behavior")> _
    Public Property ZCommentFormheight() As Integer
        Get
            ZCommentFormheight = _ZCommentFormheight
        End Get
        Set(ByVal Value As Integer)
            _ZCommentFormheight = Value
        End Set
    End Property
    <Description("Form Width.If it is 0 , program will automatically Set the form Width"), Category("Behavior")> _
    Public Property ZCommentFormWidth() As Integer
        Get
            ZCommentFormWidth = _ZCommentFormWidth
        End Get
        Set(ByVal Value As Integer)
            _ZCommentFormWidth = Value
        End Set
    End Property
    <Description("If this property is true,than form will be show in the Left side of Control"), Category("Behavior")> _
    Public Property ZShowInLeft() As Boolean
        Get
            ZShowInLeft = _ZShowInLeft
        End Get
        Set(ByVal Value As Boolean)
            _ZShowInLeft = Value
        End Set
    End Property
    <Description("If this property is true,than form will be show in the Top of Control"), Category("Behavior")> _
    Public Property ZShowInTop() As Boolean
        Get
            ZShowInTop = _ZShowInTop
        End Get
        Set(ByVal Value As Boolean)
            _ZShowInTop = Value
        End Set
    End Property
    Private Sub BtNComments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNComments.Click
        MyFrmComments = New FrmComments
        If _ZCommentFormheight > 0 Then
            MyFrmComments.Height = _ZCommentFormheight
        End If
        If _ZCommentFormWidth > 0 Then
            MyFrmComments.Width = _ZCommentFormWidth
        End If
        If _ZMaxCommentLength > 0 Then
            MyFrmComments.TxtComments.MaxLength = _ZMaxCommentLength
        End If
        MyFrmComments.TxtComments.Text = ZCommentText
        MyFrmComments.TxtComments.Enabled = ZEnabled

        Call FitToScreen(Me, MyFrmComments)
        MyFrmComments.MyLeft = MyFrmComments.Left
        MyFrmComments.MyTop = MyFrmComments.Top

        MyFrmComments.ShowDialog()
        ZCommentText = MyFrmComments.TxtCommentvar
    End Sub
    'Private Sub CommentButton_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    BtNComments.Text = ZButtonText
    'End Sub
    'Private Sub MyFrmComments_CloseMe() Handles MyFrmComments.CloseMe
    '    MyFrmComments.Close()
    '    MyFrmComments = Nothing
    'End Sub
End Class
