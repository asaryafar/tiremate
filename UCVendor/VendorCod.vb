Imports CommonClass
Public Class Vendor_Cod
    Inherits System.Windows.Forms.UserControl
    Private MCnn As System.Data.SqlClient.SqlConnection
    Shadows Event TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Private MDesc_Vendor As String = ""
    Private Mcod_vendor As String = ""
    Private MAp_terms As String = ""
    Private MVendor_CodLen As Integer = LenVendorCod
    Private MNotExitIfNotFound As Boolean
    Private MReleaseIfNotFoundVendorCod As Boolean
    Public Event FindVendorCod()
    Public Event NotFindVendorCod()
    Dim WithEvents MyFrmSearchVendorCod As New FrmSearchVendorCod
    Dim WithEvents ClsVendorCod1 As New ClsVendorCod
    Public CanAddNewCod As Boolean = True
    Public Event FindVendorNoRow(ByVal ThisRow As DataRow)
    Public MVendor_Address As String
    Public MVendor_Contact As String
    Shadows Event KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    '<Description("ÇÑ ˜Ï ˜á ãæÑÏ äÙÑ íÏÇ äÔÏ ÓíÓÊã ÂäÑÇ ÍÐÝ ˜äÏ"), Category("Behavior")> _
    Property BorderStyle() As BorderStyle
        Get
            Return TxtVendorCod.BorderStyle
        End Get
        Set(ByVal Value As BorderStyle)
            TxtVendorCod.BorderStyle = Value
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
    Public Property ReleaseIfNotFoundVendorCod() As Boolean
        Get
            Return MReleaseIfNotFoundVendorCod
        End Get
        Set(ByVal Value As Boolean)
            MReleaseIfNotFoundVendorCod = Value
        End Set
    End Property
    ReadOnly Property cod_vendor() As String
        Get
            Return Mcod_vendor
        End Get
    End Property
    ReadOnly Property Desc_Vendor() As String
        Get
            Return MDesc_Vendor
        End Get
    End Property
    ReadOnly Property Ap_terms() As String
        Get
            Return MAp_terms
        End Get
    End Property
    ReadOnly Property Vendor_Address() As String
        Get
            Return MVendor_Address
        End Get
    End Property
    ReadOnly Property Vendor_Contact() As String
        Get
            Return MVendor_Contact
        End Get
    End Property
    Public Property VendorCodLen() As Integer
        Get
            Return MVendor_CodLen
        End Get
        Set(ByVal Value As Integer)
            MVendor_CodLen = LenVendorCod
            TxtVendorCod.MaxLength = LenVendorCod
        End Set
    End Property
    Public Property Connection() As System.Data.SqlClient.SqlConnection
        Get
            Return MCnn
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            MCnn = Value
            ClsVendorCod1.Connection = MCnn
        End Set
    End Property

    Public Property VendorCod() As String
        Get
            Return TxtVendorCod.Text()
        End Get
        Set(ByVal Value As String)
            TxtVendorCod.Text = Value
            Call FindThisVendorCod()
        End Set
    End Property
    Shadows Property Text() As String
        Get
            Return TxtVendorCod.Text
        End Get
        Set(ByVal Value As String)
            TxtVendorCod.Text = Value
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
    Friend WithEvents TxtVendorCod As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Vendor_Cod))
        Me.TxtVendorCod = New System.Windows.Forms.TextBox
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'TxtVendorCod
        '
        Me.TxtVendorCod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtVendorCod.BackColor = System.Drawing.Color.YellowGreen
        Me.TxtVendorCod.Location = New System.Drawing.Point(0, 0)
        Me.TxtVendorCod.Name = "TxtVendorCod"
        Me.TxtVendorCod.Size = New System.Drawing.Size(76, 20)
        Me.TxtVendorCod.TabIndex = 0
        Me.TxtVendorCod.Text = ""
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
        'Vendor_Cod
        '
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxtVendorCod)
        Me.Name = "Vendor_Cod"
        Me.Size = New System.Drawing.Size(101, 20)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub TxtVendorCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.TextChanged, TxtVendorCod.TextChanged
        RaiseEvent TextChanged(sender, e)
        Call FindThisVendorCod()
    End Sub
    Private Sub TxtVendorCod_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus, TxtVendorCod.LostFocus
        TxtVendorCod.Text = TxtVendorCod.Text.Trim
        If Not FindThisVendorCod() Then
            If CanAddNewCod And TxtVendorCod.Text.Length > 0 Then
                Dim c1 As New FrmWhatDoForMenu
                c1.BtnLeftText = "Re-enter"
                c1.BtnRightText = "Add"
                c1.ShowFarMsg(TxtVendorCod.Text & " is not in the Vendor table")
                Select Case c1.DialogResult
                    Case DialogResult.OK ' Detail Add
                        Dim MyFrmVendor As New FrmVendor
                        MyFrmVendor.Cod_VendorVar = TxtVendorCod.Text
                        MyFrmVendor.ShowDialog()
                        If MyFrmVendor.Cod_VendorVar.Trim.Length > 0 Then
                            Me.VendorCod = MyFrmVendor.Cod_VendorVar
                        End If
                    Case Else 'Re enter
                        TxtVendorCod.Clear()
                End Select
                TxtVendorCod.Focus()
            End If
        End If
    End Sub
    Private Function FindThisVendorCod() As Boolean
        'If TxtVendorCod.Text = "" Then Exit Function
        'If ClsVendorCod1.FindDesc(Getcod(TxtVendorCod.Text, MVendorCodLen)) Then
        If ClsVendorCod1.FindDesc(TxtVendorCod.Text.Trim) Then
            FindThisVendorCod = True
            Mcod_vendor = ClsVendorCod1.cod_vendor.Trim
            MDesc_Vendor = ClsVendorCod1.desc_vendor.Trim
            MAp_terms = ClsVendorCod1.Ap_terms
            MVendor_Address = ClsVendorCod1.vendorAddress.Trim
            MVendor_Contact = ClsVendorCod1.vendorContact.Trim
            RaiseEvent FindVendorCod()
        Else
            FindThisVendorCod = False
            Mcod_vendor = ""
            MDesc_Vendor = ""
            MAp_terms = ""
            If MReleaseIfNotFoundVendorCod = True Then TxtVendorCod.Text = ""
            RaiseEvent NotFindVendorCod()
        End If
    End Function
    Private Sub TxtVendorCod_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Validating, TxtVendorCod.Validating
        'TxtVendorCod.Text = Getcod(TxtVendorCod.Text, MVendorCodLen)
        TxtVendorCod.Text = TxtVendorCod.Text.Trim
        Call FindThisVendorCod()
        If MNotExitIfNotFound = True And MDesc_Vendor = "" Then
            e.Cancel = True
        End If
    End Sub
    Private Sub Vendor_Cod_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, TxtVendorCod.KeyUp
        Select Case e.KeyCode
            Case Keys.F4
                If e.Shift = False And e.Alt = False And e.Control = False Then
                    MyFrmSearchVendorCod.ShowDialog()
                End If
                'Case Keys.Enter
                '    TxtVendorCod.Text = "CASH"
                '    SendKeys.Send("{TAB}")
                '    SendKeys.Send("{TAB}")
        End Select
    End Sub
    Private Sub MyFrmSearchVendorCod_VendorCodFind(ByVal ThisVendorCod As String, ByVal ThisDesc_Vendor As String) Handles MyFrmSearchVendorCod.vendorFind
        TxtVendorCod.Text = ThisVendorCod
        Mcod_vendor = ThisVendorCod
        MDesc_Vendor = ThisDesc_Vendor
        RaiseEvent FindVendorCod()
    End Sub
    Private Sub CodKolUC_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.BackColorChanged
        TxtVendorCod.BackColor = Me.BackColor
    End Sub
    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        MyFrmSearchVendorCod.ShowDialog()
    End Sub
    Private Sub ClsVendorCod1_FindVendorNoRow(ByVal ThisRow As System.Data.DataRow) Handles ClsVendorCod1.FindVendorNoRow
        RaiseEvent FindVendorNoRow(ThisRow)
    End Sub
    Private Sub TxtVendorCod_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtVendorCod.EnabledChanged
        If TxtVendorCod.Enabled Then
            TxtVendorCod.BackColor = System.Drawing.Color.YellowGreen
        Else
            TxtVendorCod.BackColor = System.Drawing.Color.LightGray
        End If
    End Sub
End Class
