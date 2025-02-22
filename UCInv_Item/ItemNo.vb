Imports CommonClass
Public Class ItemNo
    Inherits System.Windows.Forms.UserControl
    Private MCnn As System.Data.SqlClient.SqlConnection
    Shadows Event TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Private Mdesc_item As String = ""
    Private Mitem_no As String = ""
    Private MItem_CodLen As Integer = LenItem_No
    Private MNotExitIfNotFound As Boolean
    Private MReleaseIfNotFoundItemNo As Boolean
    Public Event FindItemNo()
    Public Event NotFindItemNo()
    Dim WithEvents MyFrmSearchItemCode As New FrmSearchItemCode
    Public ClsItem_No1 As New Clsitem_no
    '<Description("ÇÑ ˜Ï ˜á ãæÑÏ äÙÑ íÏÇ äÔÏ ÓíÓÊã ÂäÑÇ ÍÐÝ ˜äÏ"), Category("Behavior")> _
    Property BorderStyle() As BorderStyle
        Get
            Return TxtItemNo.BorderStyle
        End Get
        Set(ByVal Value As BorderStyle)
            TxtItemNo.BorderStyle = Value
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
    Public Property ReleaseIfNotFoundItemNo() As Boolean
        Get
            Return MReleaseIfNotFoundItemNo
        End Get
        Set(ByVal Value As Boolean)
            MReleaseIfNotFoundItemNo = Value
        End Set
    End Property
    ReadOnly Property item_no() As String
        Get
            Return Mitem_no
        End Get
    End Property
    ReadOnly Property desc_item() As String
        Get
            Return Mdesc_item
        End Get
    End Property
    Public Property ItemNoLen() As Integer
        Get
            Return MItem_CodLen
        End Get
        Set(ByVal Value As Integer)
            MItem_CodLen = LenItem_No
            TxtItemNo.MaxLength = LenItem_No
        End Set
    End Property
    Public Property Connection() As System.Data.SqlClient.SqlConnection
        Get
            Return MCnn
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            MCnn = Value
            ClsItem_No1.Connection = MCnn
        End Set
    End Property

    Public Property ItemNo() As String
        Get
            Return TxtItemNo.Text()
        End Get
        Set(ByVal Value As String)
            TxtItemNo.Text = Value
            Call FindThisItemNo()
        End Set
    End Property
    Shadows Property Text() As String
        Get
            Return TxtItemNo.Text
        End Get
        Set(ByVal Value As String)
            TxtItemNo.Text = Value
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
    Friend WithEvents TxtItemNo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ItemNo))
        Me.TxtItemNo = New System.Windows.Forms.TextBox
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TxtItemNo
        '
        Me.TxtItemNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtItemNo.BackColor = System.Drawing.Color.YellowGreen
        Me.TxtItemNo.Location = New System.Drawing.Point(0, 0)
        Me.TxtItemNo.Name = "TxtItemNo"
        Me.TxtItemNo.Size = New System.Drawing.Size(76, 20)
        Me.TxtItemNo.TabIndex = 0
        Me.TxtItemNo.Text = ""
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
        'ItemNo
        '
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxtItemNo)
        Me.Name = "ItemNo"
        Me.Size = New System.Drawing.Size(101, 20)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub TxtItemNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.TextChanged, TxtItemNo.TextChanged
        RaiseEvent TextChanged(sender, e)
        Call FindThisItemNo()
    End Sub
    Private Sub TxtItemNo_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus, TxtItemNo.LostFocus
        TxtItemNo.Text = TxtItemNo.Text.Trim
        'Call FindThisItemNo()
    End Sub
    Private Function FindThisItemNo() As Boolean
        If ClsItem_No1.FindDesc(TxtItemNo.Text.Trim) Then
            FindThisItemNo = True
            Mitem_no = ClsItem_No1.item_no.Trim
            Mdesc_item = ClsItem_No1.desc_item.Trim
            RaiseEvent FindItemNo()
        Else
            FindThisItemNo = False
            Mitem_no = ""
            Mdesc_item = ""
            If MReleaseIfNotFoundItemNo = True Then TxtItemNo.Text = ""
            RaiseEvent NotFindItemNo()
        End If
    End Function
    Private Sub TxtItemNo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Validating, TxtItemNo.Validating
        'TxtItemNo.Text = Getcod(TxtItemNo.Text, MItemNoLen)
        TxtItemNo.Text = TxtItemNo.Text.Trim
        'Call FindThisItemNo()
        If MNotExitIfNotFound = True And Mdesc_item = "" Then
            e.Cancel = True
        End If
    End Sub
    Private Sub TxtItemNo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, TxtItemNo.KeyUp
        Select Case e.KeyCode
            Case Keys.F4
                If e.Shift = False And e.Alt = False And e.Control = False Then
                    MyFrmSearchItemCode.ShowDialog()
                End If
                'Case Keys.Enter
                '    TxtItemNo.Text = "CASH"
                '    SendKeys.Send("{TAB}")
                '    SendKeys.Send("{TAB}")
        End Select
    End Sub
    Private Sub MyFrmSearchItemCode_ItemNoFind(ByVal ThisItemNo As String, ByVal Thisdesc_item As String) Handles MyFrmSearchItemCode.Item_noFind
        TxtItemNo.Text = ThisItemNo
        Mitem_no = ThisItemNo
        Mdesc_item = Thisdesc_item
        RaiseEvent FindItemNo()
    End Sub
    Private Sub CodKolUC_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.BackColorChanged
        TxtItemNo.BackColor = Me.BackColor
    End Sub
    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        MyFrmSearchItemCode.ShowDialog()
    End Sub
End Class
