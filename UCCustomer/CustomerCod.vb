Imports CommonClass
Public Class CustomerCod
    Inherits System.Windows.Forms.UserControl
    Private MCnn As System.Data.SqlClient.SqlConnection
    Shadows Event TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Private MCustomerDesc As String = ""
    Private MF_NAME As String = ""
    Private MM_NAME As String = ""
    Private ML_NAME As String = ""
    Private MPrice_Level As String = "1"
    Private MTax_Amount As Double = 0
    Private MKIND_AR As Decimal = 0
    Private MST_DISCOUNT_PERCENTAGE As Decimal = 0
    Private MST_NET_DUE_IN As Decimal = 0
    Private MST_IF_PAY_WITHIN_DAYS As Decimal = 0
    Private MDD_NET_DUE_BEFORE As Decimal = 0
    Private MDD_IF_ISSUED_WITHIN_DAYS As Decimal = 0
    Private MDD_DISCOUNT_PERCENTAGE As Decimal = 0
    Private MDD_IF_PAY_WITHIN_DAYS As Decimal = 0
    Private MMP_NO_OF_PAYMENT As Decimal = 0
    Private MMP_BEFORE_DAY As Decimal = 0
    Private MCreditLimit As Decimal = 0
    Private mcod_company As String = ""
    Private MCustomerPhone As String = ""
    Private MAR_term As String = ""
    Private MZipCode As String = ""
    Private Mabbreviation_name As String = ""
    Private MAddress As String = ""
    Private MEmAilAddress As String = ""
    Private MPoIsRequired As Boolean = False
    Private MARCharge As Boolean = False
    Private MCreditHold As Boolean = False
    Private MAcceptCheck As Boolean = False
    Private MARCreditHold As Boolean = False
    Private MCustomerCodLen As Integer = LenCustomerCod
    Private MNotExitIfNotFound As Boolean
    Private MReleaseIfNotFoundCustomerCod As Boolean
    Public Event FindCustomerCod()
    Public Event NotFindCustomerCod()
    Dim WithEvents MyFrmSearchCustomerCode As New FrmSearchCustomerCode
    Dim ClsCustomerCod1 As New ClsCustomerCod
    Public CanAddNewCod As Boolean = True
    '<Description("ÇÑ ˜Ï ˜á ãæÑÏ äÙÑ íÏÇ äÔÏ ÓíÓÊã ÂäÑÇ ÍÐÝ ˜äÏ"), Category("Behavior")> _
    Property BorderStyle() As BorderStyle
        Get
            Return TxtCustomerCod.BorderStyle
        End Get
        Set(ByVal Value As BorderStyle)
            TxtCustomerCod.BorderStyle = Value
        End Set
    End Property
    'Public Property ActiveSearchBottun() As Boolean
    '    Get
    '        If TxtCustomerCod.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    End Get
    '    Set(ByVal Value As Boolean)
    '        If Value Then
    '            TxtCustomerCod.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis
    '        Else
    '            TxtCustomerCod.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
    '        End If

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
    Public Property ReleaseIfNotFoundCustomerCod() As Boolean
        Get
            Return MReleaseIfNotFoundCustomerCod
        End Get
        Set(ByVal Value As Boolean)
            MReleaseIfNotFoundCustomerCod = Value
        End Set
    End Property
    ReadOnly Property cod_company() As String
        Get
            Return mcod_company
        End Get
    End Property
    ReadOnly Property PoIsRequired() As Boolean
        Get
            Return MPoIsRequired
        End Get
    End Property
    ReadOnly Property CreditHold() As Boolean
        Get
            Return MCreditHold
        End Get
    End Property
    ReadOnly Property ARCharge() As Boolean
        Get
            Return MARCharge
        End Get
    End Property
    ReadOnly Property AcceptCheck() As Boolean
        Get
            Return MAcceptCheck
        End Get
    End Property
    ReadOnly Property ARCreditHold() As Boolean
        Get
            Return MARCreditHold
        End Get
    End Property
    ReadOnly Property KIND_AR() As Integer
        Get
            Return MKIND_AR
        End Get
    End Property
    ReadOnly Property ST_DISCOUNT_PERCENTAGE() As Decimal
        Get
            Return MST_DISCOUNT_PERCENTAGE
        End Get
    End Property
    ReadOnly Property ST_NET_DUE_IN() As Decimal
        Get
            Return MST_NET_DUE_IN
        End Get
    End Property
    ReadOnly Property ST_IF_PAY_WITHIN_DAYS() As Decimal
        Get
            Return MST_IF_PAY_WITHIN_DAYS
        End Get
    End Property
    ReadOnly Property DD_NET_DUE_BEFORE() As Decimal
        Get
            Return MDD_NET_DUE_BEFORE
        End Get
    End Property
    ReadOnly Property DD_IF_ISSUED_WITHIN_DAYS() As Decimal
        Get
            Return MDD_IF_ISSUED_WITHIN_DAYS
        End Get
    End Property
    ReadOnly Property DD_DISCOUNT_PERCENTAGE() As Decimal
        Get
            Return MDD_DISCOUNT_PERCENTAGE
        End Get
    End Property
    ReadOnly Property DD_IF_PAY_WITHIN_DAYS() As Decimal
        Get
            Return MDD_IF_PAY_WITHIN_DAYS
        End Get
    End Property
    ReadOnly Property MP_NO_OF_PAYMENT() As Decimal
        Get
            Return MMP_NO_OF_PAYMENT
        End Get
    End Property
    ReadOnly Property CreditLimit() As Decimal
        Get
            Return MCreditLimit
        End Get
    End Property
    ReadOnly Property MP_BEFORE_DAY() As Decimal
        Get
            Return MMP_BEFORE_DAY
        End Get
    End Property
    ReadOnly Property CustomerDesc() As String
        Get
            Return MCustomerDesc
        End Get
    End Property
    ReadOnly Property F_Name() As String
        Get
            Return MF_NAME
        End Get
    End Property
    ReadOnly Property M_Name() As String
        Get
            Return MM_NAME
        End Get
    End Property
    ReadOnly Property L_Name() As String
        Get
            Return ML_NAME
        End Get
    End Property
    ReadOnly Property Price_Level() As String
        Get
            Return MPrice_Level
        End Get
    End Property
    ReadOnly Property Tax_Amount() As Double
        Get
            Return MTax_Amount
        End Get
    End Property
    ReadOnly Property CustomerPhone() As String
        Get
            Return MCustomerPhone
        End Get
    End Property
    ReadOnly Property ZipCode() As String
        Get
            Return MZipCode
        End Get
    End Property
    ReadOnly Property AR_term() As String
        Get
            Return MAR_term & ""
        End Get
    End Property
    ReadOnly Property Address() As String
        Get
            Return MAddress
        End Get
    End Property
    ReadOnly Property EmAilAddress() As String
        Get
            Return MEmAilAddress
        End Get
    End Property
    ReadOnly Property abbreviation_name() As String
        Get
            Return Mabbreviation_name
        End Get
    End Property
    Public Property CustomerCodLen() As Integer
        Get
            Return MCustomerCodLen
        End Get
        Set(ByVal Value As Integer)
            MCustomerCodLen = LenCustomerCod
            TxtCustomerCod.MaxLength = LenCustomerCod
        End Set
    End Property
    Public Property Connection() As System.Data.SqlClient.SqlConnection
        Get
            Return MCnn
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            MCnn = Value
            ClsCustomerCod1.Connection = MCnn
        End Set
    End Property

    Public Property CustomerCod() As String
        Get
            Return TxtCustomerCod.Text.ToUpper
        End Get
        Set(ByVal Value As String)
            TxtCustomerCod.Text = Value.ToUpper
            Call FindThisCustomerCod()
        End Set
    End Property
    Shadows Property Text() As String
        Get
            Return TxtCustomerCod.Text.ToUpper
        End Get
        Set(ByVal Value As String)
            TxtCustomerCod.Text = Value.ToUpper
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
    Friend WithEvents TxtCustomerCod As System.Windows.Forms.TextBox
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CustomerCod))
        Me.TxtCustomerCod = New System.Windows.Forms.TextBox
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SuspendLayout()
        '
        'TxtCustomerCod
        '
        Me.TxtCustomerCod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCustomerCod.BackColor = System.Drawing.Color.YellowGreen
        Me.TxtCustomerCod.Location = New System.Drawing.Point(0, 0)
        Me.TxtCustomerCod.Name = "TxtCustomerCod"
        Me.TxtCustomerCod.Size = New System.Drawing.Size(103, 20)
        Me.TxtCustomerCod.TabIndex = 0
        Me.TxtCustomerCod.Text = ""
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.Location = New System.Drawing.Point(103, 0)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(24, 20)
        Me.BtnSearch.TabIndex = 1
        Me.BtnSearch.TabStop = False
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01_" & _
        "2006;persist security info=True;password=sa"
        '
        'CustomerCod
        '
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxtCustomerCod)
        Me.Name = "CustomerCod"
        Me.Size = New System.Drawing.Size(128, 21)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub TxtCustomerCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCustomerCod.TextChanged, MyBase.TextChanged
        RaiseEvent TextChanged(sender, e)
        Call FindThisCustomerCod()
    End Sub
    Private Sub TxtCustomerCod_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCustomerCod.LostFocus, MyBase.LostFocus
        TxtCustomerCod.Text = TxtCustomerCod.Text.Trim
        If TxtCustomerCod.Text.ToUpper = "CASH" Then
            TxtCustomerCod.Text = "CASH"
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select count(*) as CountOfCashRecord from cust_trtab_main Where cod_customer='CASH'"
            If CmdGeneral.ExecuteScalar < 1 Then
                CmdGeneral.CommandText = "Insert Into cust_trtab_main (cod_customer,cod_sales_tax,cod_price) Values('CASH','01',1)"
                CmdGeneral.ExecuteNonQuery()
            End If
            'CmdGeneral.Connection.Close()
        End If
        If Not FindThisCustomerCod(False) Then
            If CanAddNewCod And TxtCustomerCod.Text.Length > 0 Then
                Dim c1 As New FrmWhatDoForMenu
                c1.BtnLeftText = "Re-enter"
                c1.BtnCenterText = "Quick Add"
                c1.BtnRightText = "Detail Add"
                c1.ShowFarMsg(TxtCustomerCod.Text & " is not in the customer table")
                Select Case c1.DialogResult
                    Case DialogResult.Yes ' Quick Add
                        Dim MyFrmCustomer_Quick_Add As New FrmCustomer_Quick_Add
                        MyFrmCustomer_Quick_Add.Cod_customerVar = TxtCustomerCod.Text
                        MyFrmCustomer_Quick_Add.IsCancelForExitFlag = True
                        MyFrmCustomer_Quick_Add.ShowDialog()
                        If MyFrmCustomer_Quick_Add.Cod_customerVar.Trim.Length > 0 Then
                            Me.CustomerCod = MyFrmCustomer_Quick_Add.Cod_customerVar
                        End If
                    Case DialogResult.OK ' Detail Add
                        Dim MyFrmCustomer As New FrmCustomer
                        MyFrmCustomer.Cod_customerVar = TxtCustomerCod.Text
                        MyFrmCustomer.ShowDialog()
                        If MyFrmCustomer.Cod_customerVar.Trim.Length > 0 Then
                            Me.CustomerCod = MyFrmCustomer.Cod_customerVar
                        End If
                    Case Else 'Re enter
                        TxtCustomerCod.Clear()
                End Select
                TxtCustomerCod.Focus()
            End If
        End If
    End Sub
    'Private Sub TxtCustomerCod_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCustomerCod.LostFocus, MyBase.LostFocus
    '    'TxtCustomerCod.Text = Getcod(TxtCustomerCod.Text, MCustomerCodLen)
    '    TxtCustomerCod.Text = TxtCustomerCod.Text.Trim
    '    If TxtCustomerCod.Text.ToUpper = "CASH" Then
    '        TxtCustomerCod.Text = "CASH"
    '        If CmdGeneral.Connection.State <> ConnectionState.Open Then
    '            CmdGeneral.Connection.Open()
    '        End If
    '        CmdGeneral.CommandText = "Select count(*) as CountOfCashRecord from cust_trtab_main Where cod_customer='CASH'"
    '        If CmdGeneral.ExecuteScalar < 1 Then
    '            CmdGeneral.CommandText = "Insert Into cust_trtab_main (cod_customer,cod_sales_tax,cod_price) Values('CASH','01',1)"
    '            CmdGeneral.ExecuteNonQuery()
    '        End If
    '        CmdGeneral.Connection.Close()
    '    End If
    '    If Not FindThisCustomerCod() And TxtCustomerCod.Text.Length > 0 Then
    '        Dim c1 As New FrmWhatDoForMenu
    '        c1.BtnLeftText = "Re-enter"
    '        c1.BtnCenterText = "Quick Add"
    '        c1.BtnRightText = "Detail Add"
    '        c1.ShowFarMsg(TxtCustomerCod.Text & " is not in the customer table")
    '        Select Case c1.DialogResult
    '            Case DialogResult.Yes ' Quick Add
    '                MyFrmCustomer_Quick_Add.ShowDialog()
    '                If MyFrmCustomer_Quick_Add.Cod_customerVar.Trim.Length > 0 Then
    '                    Me.CustomerCod = MyFrmCustomer_Quick_Add.Cod_customerVar
    '                End If
    '            Case DialogResult.OK ' Detail Add
    '                MsgBox("Detail Add")
    '            Case Else 'Re enter
    '                TxtCustomerCod.Clear()
    '        End Select
    '        TxtCustomerCod.Focus()
    '    End If
    'End Sub
    Private Function FindThisCustomerCod(Optional ByVal raiseeventit As Boolean = True) As Boolean
        'If TxtCustomerCod.Text = "" Then Exit Function
        'If ClsCustomerCod1.FindDesc(Getcod(TxtCustomerCod.Text, MCustomerCodLen)) Then
        If ClsCustomerCod1.FindDesc(TxtCustomerCod.Text.Trim) Then
            FindThisCustomerCod = True
            MCustomerDesc = ClsCustomerCod1.Customer_Name & ""
            MF_NAME = ClsCustomerCod1.F_Name & ""
            MM_NAME = ClsCustomerCod1.M_Name & ""
            ML_NAME = ClsCustomerCod1.L_Name & ""
            mcod_company = ClsCustomerCod1.cod_company & ""
            MPrice_Level = ClsCustomerCod1.Price_Level
            MTax_Amount = ClsCustomerCod1.Tax_Amount
            MPoIsRequired = ClsCustomerCod1.require_PO
            MARCharge = ClsCustomerCod1.ARCharge
            MCreditHold = ClsCustomerCod1.CreditHold
            MAcceptCheck = ClsCustomerCod1.AcceptCheck
            MARCreditHold = ClsCustomerCod1.ARCreditHold
            MCustomerPhone = ClsCustomerCod1.CustomerPhone & ""
            Mabbreviation_name = ClsCustomerCod1.Abbreviation_name & ""
            MAddress = ClsCustomerCod1.Address & ""
            MEmAilAddress = ClsCustomerCod1.EmailAddress & ""

            MAR_term = ClsCustomerCod1.AR_Term
            MKIND_AR = ClsCustomerCod1.KIND_AR
            MST_DISCOUNT_PERCENTAGE = ClsCustomerCod1.ST_DISCOUNT_PERCENTAGE
            MST_DISCOUNT_PERCENTAGE = ClsCustomerCod1.ST_DISCOUNT_PERCENTAGE
            MST_DISCOUNT_PERCENTAGE = ClsCustomerCod1.ST_DISCOUNT_PERCENTAGE
            MDD_NET_DUE_BEFORE = ClsCustomerCod1.DD_NET_DUE_BEFORE
            MDD_IF_ISSUED_WITHIN_DAYS = ClsCustomerCod1.DD_IF_ISSUED_WITHIN_DAYS
            MDD_DISCOUNT_PERCENTAGE = ClsCustomerCod1.DD_DISCOUNT_PERCENTAGE
            MDD_IF_PAY_WITHIN_DAYS = ClsCustomerCod1.DD_IF_PAY_WITHIN_DAYS
            MMP_NO_OF_PAYMENT = ClsCustomerCod1.MP_NO_OF_PAYMENT
            MMP_BEFORE_DAY = ClsCustomerCod1.MP_BEFORE_DAY
            MCreditLimit = ClsCustomerCod1.CreditLimit
            MZipCode = ClsCustomerCod1.ZipCode
            If raiseeventit = True Then
                RaiseEvent FindCustomerCod()
            End If
        Else
            FindThisCustomerCod = False
            MCustomerDesc = ""
            MF_NAME = ""
            MM_NAME = ""
            ML_NAME = ""
            MPrice_Level = "1"
            MTax_Amount = 0
            MPoIsRequired = False
            MARCharge = False
            MCreditHold = False
            MAcceptCheck = False
            MARCreditHold = False
            MCustomerPhone = ""
            Mabbreviation_name = ""
            MAddress = ""
            MEmAilAddress = ""

            MAR_term = ""
            MKIND_AR = 0
            MST_DISCOUNT_PERCENTAGE = 0
            MST_DISCOUNT_PERCENTAGE = 0
            MST_DISCOUNT_PERCENTAGE = 0
            MDD_NET_DUE_BEFORE = 0
            MDD_IF_ISSUED_WITHIN_DAYS = 0
            MDD_DISCOUNT_PERCENTAGE = 0
            MDD_IF_PAY_WITHIN_DAYS = 0
            MMP_NO_OF_PAYMENT = 0
            MMP_BEFORE_DAY = 0
            MCreditLimit = 0
            MZipCode = ""
            If MReleaseIfNotFoundCustomerCod = True Then TxtCustomerCod.Text = ""
            RaiseEvent NotFindCustomerCod()
        End If
    End Function
    Private Sub TxtCustomerCod_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtCustomerCod.Validating, MyBase.Validating
        'TxtCustomerCod.Text = Getcod(TxtCustomerCod.Text, MCustomerCodLen)
        TxtCustomerCod.Text = TxtCustomerCod.Text.Trim
        Call FindThisCustomerCod()
        If MNotExitIfNotFound = True And MCustomerDesc = "" Then
            e.Cancel = True
        End If
    End Sub
    Private Sub TxtCustomerCod_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCustomerCod.KeyUp, MyBase.KeyUp
        Select Case e.KeyCode
            Case Keys.F4
                If e.Shift = False And e.Alt = False And e.Control = False Then
                    MyFrmSearchCustomerCode.ShowDialog()
                End If
            Case Keys.Enter
                If TxtCustomerCod.Text.Length = 0 Then
                    TxtCustomerCod.Text = "CASH"
                    SendKeys.Send("{TAB}")
                    'SendKeys.Send("{TAB}")
                End If
        End Select
    End Sub
    Private Sub MyFrmSearchCustomerCode_CustomerCodFind(ByVal ThisCustomerCod As String, ByVal ThisCustomerDesc As String) Handles MyFrmSearchCustomerCode.CustomerFind
        TxtCustomerCod.Text = ThisCustomerCod
        MCustomerDesc = ThisCustomerDesc
        RaiseEvent FindCustomerCod()
    End Sub
    Private Sub CustomerCod_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.BackColorChanged
        Try
            TxtCustomerCod.BackColor = Me.BackColor
        Catch ex As Exception
        End Try
    End Sub
    Public Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        MyFrmSearchCustomerCode.ShowDialog()
    End Sub
    Private Sub TxtCustomerCod_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCustomerCod.DoubleClick
        'TxtCustomerCod.Text = "CASH"
        'SendKeys.Send("{TAB}")
    End Sub
    Private Sub CustomerCod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
    End Sub
End Class
