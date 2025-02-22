Public Class VendoreOfInvoice
    Inherits System.Windows.Forms.UserControl
    Private MCnn As System.Data.SqlClient.SqlConnection
    Shadows Event TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    Private MNotExitIfNotFound As Boolean
    Private MReleaseIfNotFound As Boolean
    Dim WithEvents MyFrm As New FrmSearchVendorInvoice
    Public Event VandorInvoiceFind(ByVal ReferenceNo As String, ByVal ReferenceDate As String)
    Dim MCod_Vendor As String
    ' Dim MVendor_ref_no As String
    Dim Mid_receive_ref As String

    Dim WithEvents Cls1 As New ClsReceiveReturnProduct
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(VendoreOfInvoice))
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TxtSearch
        '
        Me.TxtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearch.BackColor = System.Drawing.Color.YellowGreen
        Me.TxtSearch.Location = New System.Drawing.Point(0, 0)
        Me.TxtSearch.MaxLength = 50
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(128, 20)
        Me.TxtSearch.TabIndex = 2
        Me.TxtSearch.Text = ""
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(128, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 20)
        Me.Button1.TabIndex = 4
        Me.Button1.TabStop = False
        '
        'VendoreOfInvoice
        '
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtSearch)
        Me.Name = "VendoreOfInvoice"
        Me.Size = New System.Drawing.Size(152, 20)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Event FindThisRefNoForThisVendore(ByVal ThisRow As DataRow)
    Public Event NotFindThisRefNoForThisVendore()
    'Property Vendor_ref_no() As String
    '    Get
    '        Return MVendor_ref_no
    '    End Get
    '    Set(ByVal Value As String)
    '        MVendor_ref_no = Value
    '    End Set
    'End Property
    ReadOnly Property id_receive_ref() As String
        Get
            Return Mid_receive_ref
        End Get
    End Property
    Property Cod_Vendor() As String
        Get
            Return MCod_Vendor
        End Get
        Set(ByVal Value As String)
            MCod_Vendor = Value
        End Set
    End Property
    Property BorderStyle() As BorderStyle
        Get
            Return TxtSearch.BorderStyle
        End Get
        Set(ByVal Value As BorderStyle)
            TxtSearch.BorderStyle = Value
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
    Public Property ReleaseIfNotFound() As Boolean
        Get
            Return MReleaseIfNotFound
        End Get
        Set(ByVal Value As Boolean)
            MReleaseIfNotFound = Value
        End Set
    End Property

    Shadows Property Text() As String
        Get
            Return TxtSearch.Text
        End Get
        Set(ByVal Value As String)
            TxtSearch.Text = Value
        End Set
    End Property
    Private Sub TxtCompanyName_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, TxtSearch.KeyUp
        Select Case e.KeyCode
            Case Keys.F4
                If e.Shift = False And e.Alt = False And e.Control = False Then
                    Call showfrm()
                End If
        End Select
    End Sub

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.TextChanged, TxtSearch.TextChanged
        RaiseEvent TextChanged(sender, e)
        Call FindThisItem()
    End Sub
    Private Sub txtsearch_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus, TxtSearch.LostFocus
        TxtSearch.Text = TxtSearch.Text.Trim
        Call FindThisItem()
    End Sub

    Public Property Connection() As System.Data.SqlClient.SqlConnection
        Get
            Return MCnn
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            MCnn = Value
            Cls1.Connection = MCnn
        End Set
    End Property

    Private Function FindThisItem() As Boolean
        If Cls1.ThisRefNoForThisVendore(MCod_Vendor, TxtSearch.Text.Trim) Then
            FindThisItem = True
            ' Mitem_no = Cls1.item_no.Trim
            ' Mdesc_item = Cls1.desc_item.Trim
            '            RaiseEvent FindItemNo()
        Else
            FindThisItem = False
            '    Mitem_no = ""
            '    Mdesc_item = ""
            If MReleaseIfNotFound = True Then TxtSearch.Text = ""
            '         RaiseEvent NotFindThisRefNoForThisVendore()
        End If
    End Function
    Private Sub txtsearch_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Validating, TxtSearch.Validating
        'txtsearch.Text = Getcod(txtsearch.Text, MItemNoLen)
        TxtSearch.Text = TxtSearch.Text.Trim
        Call FindThisItem()
        If MNotExitIfNotFound = True And TxtSearch.Text = "" Then
            e.Cancel = True
        End If
    End Sub
    Private Sub txtsearch_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, TxtSearch.KeyUp
        Select Case e.KeyCode
            Case Keys.F4
                If e.Shift = False And e.Alt = False And e.Control = False Then
                    MyFrm.ShowDialog()
                End If
        End Select
    End Sub
    Private Sub CodKolUC_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.BackColorChanged
        TxtSearch.BackColor = Me.BackColor
    End Sub
    Sub showfrm()
        MyFrm.Cod_Vendor = MCod_Vendor
        MyFrm.ShowDialog()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call showfrm()
    End Sub
    Private Sub Cls1_FindThisRefNoForThisVendore(ByVal ThisRow As System.Data.DataRow) Handles Cls1.FindThisRefNoForThisVendore
        Mid_receive_ref = ThisRow("id_receive_ref")
        RaiseEvent FindThisRefNoForThisVendore(ThisRow)

    End Sub
    Private Sub Cls1_NotFindThisRefNoForThisVendore() Handles Cls1.NotFindThisRefNoForThisVendore
        RaiseEvent NotFindThisRefNoForThisVendore()
    End Sub
    Private Sub MyFrm_VandorInvoiceFind(ByVal ReferenceNo As String, ByVal ReferenceDate As String) Handles MyFrm.VandorInvoiceFind
        TxtSearch.Text = ReferenceNo
    End Sub
End Class
