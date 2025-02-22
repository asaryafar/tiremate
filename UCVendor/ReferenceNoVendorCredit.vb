Imports CommonClass
Public Class Reference_NoVendorCredit
    Inherits System.Windows.Forms.UserControl
    Private MCnn As System.Data.SqlClient.SqlConnection
    Shadows Event TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Private Mcod_Vendor As String = ""
    Private MReferenc_No As String = ""
    Private MLenReceivePaymentReferenceNo As Integer = LenReceivePaymentReferenceNo
    Private MNotExitIfNotFound As Boolean
    Private MReleaseIfNotFoundReferenceNo As Boolean
    Public Event FindReferenceNo()
    Public Event NotFindReferenceNo()
    Dim WithEvents MyFrmSearchReferenceNo As New FrmSearchReferenceNoVendorCredit
    Dim WithEvents ClsVendorReferenceNo1 As New ClsVendorReferenceNoVendorCredit
    Public CanAddNewCod As Boolean = True
    Public Event FindReferenceNoRow(ByVal ThisRow As DataRow)

    '<Description("ÇÑ ˜Ï ˜á ãæÑÏ äÙÑ íÏÇ äÔÏ ÓíÓÊã ÂäÑÇ ÍÐÝ ˜äÏ"), Category("Behavior")> _
    Property BorderStyle() As BorderStyle
        Get
            Return TxtReferencNo.BorderStyle
        End Get
        Set(ByVal Value As BorderStyle)
            TxtReferencNo.BorderStyle = Value
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
    Public Property ReleaseIfNotFoundReferenceNo() As Boolean
        Get
            Return MReleaseIfNotFoundReferenceNo
        End Get
        Set(ByVal Value As Boolean)
            MReleaseIfNotFoundReferenceNo = Value
        End Set
    End Property
    'ReadOnly Property Referenc_No() As String
    '    Get
    '        Return MReferenc_No
    '    End Get
    'End Property
    ReadOnly Property Cod_Vendor() As String
        Get
            Return Mcod_Vendor
        End Get
    End Property
    Public Property ReferenceNoLen() As Integer
        Get
            Return MLenReceivePaymentReferenceNo
        End Get
        Set(ByVal Value As Integer)
            MLenReceivePaymentReferenceNo = LenReceivePaymentReferenceNo
            TxtReferencNo.MaxLength = LenReceivePaymentReferenceNo
        End Set
    End Property
    Public Property Connection() As System.Data.SqlClient.SqlConnection
        Get
            Return MCnn
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            MCnn = Value
            ClsVendorReferenceNo1.Connection = MCnn
        End Set
    End Property
    Public Property ReferencNo() As String
        Get
            Return TxtReferencNo.Text()
        End Get
        Set(ByVal Value As String)
            TxtReferencNo.Text = Value
            Call FindThisReferencNo()
        End Set
    End Property
    Shadows Property Text() As String
        Get
            Return TxtReferencNo.Text
        End Get
        Set(ByVal Value As String)
            TxtReferencNo.Text = Value
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
    Friend WithEvents TxtReferencNo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Reference_NoVendorCredit))
        Me.TxtReferencNo = New System.Windows.Forms.TextBox
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TxtReferencNo
        '
        Me.TxtReferencNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtReferencNo.BackColor = System.Drawing.Color.YellowGreen
        Me.TxtReferencNo.Location = New System.Drawing.Point(0, 0)
        Me.TxtReferencNo.MaxLength = 10
        Me.TxtReferencNo.Name = "TxtReferencNo"
        Me.TxtReferencNo.Size = New System.Drawing.Size(69, 20)
        Me.TxtReferencNo.TabIndex = 0
        Me.TxtReferencNo.Text = ""
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.Location = New System.Drawing.Point(69, 0)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(24, 20)
        Me.BtnSearch.TabIndex = 1
        Me.BtnSearch.TabStop = False
        '
        'Reference_NoVendorCredit
        '
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxtReferencNo)
        Me.Name = "Reference_NoVendorCredit"
        Me.Size = New System.Drawing.Size(94, 20)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub TxtReferencNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.TextChanged, TxtReferencNo.TextChanged
        RaiseEvent TextChanged(sender, e)
        Call FindThisReferencNo()
    End Sub
    'Private Sub TxtReferencNo_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus, TxtReferencNo.LostFocus
    '    TxtReferencNo.Text = TxtReferencNo.Text.Trim
    '    Call FindThisReferencNo()
    'End Sub
    Private Function FindThisReferencNo() As Boolean
        'If TxtReferencNo.Text = "" Then Exit Function
        'If ClsVendorReferenceNo1.FindDesc(Getcod(TxtReferencNo.Text, MVendorCodLen)) Then
        If ClsVendorReferenceNo1.FindDesc(TxtReferencNo.Text.Trim) Then
            FindThisReferencNo = True
            MReferenc_No = ClsVendorReferenceNo1.Refrence_No.Trim
            Mcod_Vendor = ClsVendorReferenceNo1.Cod_Vendor.Trim
            RaiseEvent FindReferenceNo()
        Else
            FindThisReferencNo = False
            MReferenc_No = ""
            Mcod_Vendor = ""
            If MReleaseIfNotFoundReferenceNo = True Then TxtReferencNo.Text = ""
            RaiseEvent NotFindReferenceNo()
        End If
    End Function
    Private Sub TxtReferencNo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Validating, TxtReferencNo.Validating
        'TxtReferencNo.Text = Getcod(TxtReferencNo.Text, MVendorCodLen)
        TxtReferencNo.Text = TxtReferencNo.Text.Trim
        Call FindThisReferencNo()
        If MNotExitIfNotFound = True And Mcod_Vendor = "" Then
            e.Cancel = True
        End If
    End Sub
    Private Sub TxtReferencNo_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, TxtReferencNo.KeyUp
        Select Case e.KeyCode
            Case Keys.F4
                If e.Shift = False And e.Alt = False And e.Control = False Then
                    MyFrmSearchReferenceNo.ShowDialog()
                End If
            Case Keys.Enter
                FindThisReferencNo()
        End Select
    End Sub
    Private Sub MyFrmSearchReferenceNo_ReferenceNoVendorCreditFind(ByVal ThisReferencNo As String, ByVal ThisCod_Vendor As String) Handles MyFrmSearchReferenceNo.VendorCreditFind
        TxtReferencNo.Text = ThisReferencNo
        MReferenc_No = ThisReferencNo
        Mcod_Vendor = ThisCod_Vendor
        RaiseEvent FindReferenceNo()
    End Sub
    Private Sub MyFrmSearchReferenceNo_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.BackColorChanged
        TxtReferencNo.BackColor = Me.BackColor
    End Sub
    Public Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        MyFrmSearchReferenceNo.ShowDialog()
    End Sub
    Private Sub ClsVendorReferenceNo1_FindReferenceNoRow(ByVal ThisRow As System.Data.DataRow) Handles ClsVendorReferenceNo1.FindReferenceNoRow
        RaiseEvent FindReferenceNoRow(ThisRow)
    End Sub
    Private Sub Reference_No_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        Call FindThisReferencNo()
    End Sub
End Class
