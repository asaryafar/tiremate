Imports Janus.Windows.GridEX
Imports CommonClass
Public Class CompanyName
    Inherits System.Windows.Forms.UserControl
    Private MCnn As System.Data.SqlClient.SqlConnection
    Shadows Event TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    'Shadows Event LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    Private MCompanyAbbreviation_name As String = ""
    Private MCompanyCod As String = ""
    Private MCompanyCodForFind As String = ""
    Private MCompanyNameLen As Integer = 50
    Private MNotExitIfNotFound As Boolean
    Private MReleaseIfNotFoundCompanyName As Boolean
    Public Event FindCompanyName()
    Public Event NotFindCompanyName()
    Dim WithEvents MyFrmSearchCompanyName As New FrmSearchCompanyName
    Dim ClsCompanyName1 As New ClsCompanyName
    Public CustomerCompleteName As String = ""
    Public Flg As Boolean
    Dim OldTxtCompanyvar As String = ""
    '<Description("ÇÑ ˜Ï ˜á ãæÑÏ äÙÑ íÏÇ äÔÏ ÓíÓÊã ÂäÑÇ ÍÐÝ ˜äÏ"), Category("Behavior")> _
    Property BorderStyle() As BorderStyle
        Get
            Return TxtCompanyComplete_name.BorderStyle
        End Get
        Set(ByVal Value As BorderStyle)
            TxtCompanyComplete_name.BorderStyle = Value
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
    Public Property ReleaseIfNotFoundCompanyName() As Boolean
        Get
            Return MReleaseIfNotFoundCompanyName
        End Get
        Set(ByVal Value As Boolean)
            MReleaseIfNotFoundCompanyName = Value
        End Set
    End Property
    ReadOnly Property CompanyAbbreviation_name() As String
        Get
            Return MCompanyAbbreviation_name
        End Get
    End Property
    Public Property CompanyCod() As String
        Get
            Return MCompanyCod
        End Get
        Set(ByVal Value As String)
            MCompanyCod = Value
        End Set
    End Property
    Public Property CompanyCodForFind() As String
        Get
            Return MCompanyCodForFind
        End Get
        Set(ByVal Value As String)
            MCompanyCodForFind = Value
            Call FindThisCompanyName(2)
        End Set
    End Property
    Public Property Connection() As System.Data.SqlClient.SqlConnection
        Get
            Return MCnn
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            MCnn = Value
            ClsCompanyName1.Connection = MCnn
        End Set
    End Property
    Public Property CompanyComplete_Name() As String
        Get
            Return TxtCompanyComplete_name.Text()
        End Get
        Set(ByVal Value As String)
            TxtCompanyComplete_name.Text = Value
            If flg Then
            Call FindThisCompanyName(1)
            End If
        End Set
    End Property
    Shadows Property Text() As String
        Get
            Return TxtCompanyComplete_name.Text
        End Get
        Set(ByVal Value As String)
            TxtCompanyComplete_name.Text = Value
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
    Friend WithEvents TxtCompanyComplete_name As System.Windows.Forms.TextBox
    Friend WithEvents DSCompanyCod1 As DSCust_Company
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents DataView1 As System.Data.DataView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CompanyName))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.TxtCompanyComplete_name = New System.Windows.Forms.TextBox
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.DSCompanyCod1 = New UCCompany.DSCust_Company
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DataView1 = New System.Data.DataView
        CType(Me.DSCompanyCod1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtCompanyComplete_name
        '
        Me.TxtCompanyComplete_name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCompanyComplete_name.BackColor = System.Drawing.Color.YellowGreen
        Me.TxtCompanyComplete_name.Location = New System.Drawing.Point(0, 0)
        Me.TxtCompanyComplete_name.MaxLength = 50
        Me.TxtCompanyComplete_name.Name = "TxtCompanyComplete_name"
        Me.TxtCompanyComplete_name.Size = New System.Drawing.Size(186, 20)
        Me.TxtCompanyComplete_name.TabIndex = 0
        Me.TxtCompanyComplete_name.Text = ""
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.Location = New System.Drawing.Point(186, 0)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(24, 20)
        Me.BtnSearch.TabIndex = 1
        Me.BtnSearch.TabStop = False
        '
        'DSCompanyCod1
        '
        Me.DSCompanyCod1.DataSetName = "DSCust_Company"
        Me.DSCompanyCod1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'GridEX1
        '
        Me.GridEX1.AllowColumnDrag = False
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.DataSource = Me.DataView1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>cust_company</Caption><Columns Collection=""" & _
        "true""><Column0 ID=""complete_name""><Caption>complete name</Caption><DataMember>co" & _
        "mplete_name</DataMember><Key>complete_name</Key><Position>0</Position><Width>185" & _
        "</Width></Column0><Column1 ID=""cod_company""><Caption>Code</Caption><TypeNameEmpt" & _
        "yStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMe" & _
        "mber>cod_company</DataMember><Key>cod_company</Key><Position>1</Position><Visibl" & _
        "e>False</Visible><Width>60</Width></Column1></Columns><GroupCondition ID="""" /><K" & _
        "ey>cust_company</Key></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 19)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(211, 3)
        Me.GridEX1.TabIndex = 3
        Me.GridEX1.TabStop = False
        '
        'DataView1
        '
        Me.DataView1.Table = Me.DSCompanyCod1.cust_company
        '
        'CompanyCode
        '
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxtCompanyComplete_name)
        Me.Name = "CompanyCode"
        Me.Size = New System.Drawing.Size(211, 22)
        CType(Me.DSCompanyCod1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub CompanyName_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DSCompanyCod1.Clear()
            ClsCompanyName1.DAcod_company.SelectCommand.Connection = Connection
            ClsCompanyName1.DAcod_company.Fill(DSCompanyCod1, "cust_company")
            GridEX1.RootTable.Columns(0).Width = Me.Width - 50
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FilterDataset()
        TxtCompanyComplete_name.Text = TxtCompanyComplete_name.Text.Replace("'", "")
        DataView1.RowFilter = " complete_name like '*" & TxtCompanyComplete_name.Text.Trim & "*'"
        'DSCompanyCod1.Tables("cust_company").DefaultView.RowFilter = "complete_name like '*" & TxtCompanyComplete_name.Text.Trim & "*'"
        'GridEX1.DataMember = ""
        'GridEX1.DataMember = "cust_company"
        'GridEX1.Refetch()
        'DataGrid1.DataSource = DSCompanyCod1.cust_company
    End Sub
    Private Sub TxtCompanyName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.TextChanged, TxtCompanyComplete_name.TextChanged
        If OldTxtCompanyvar.Trim <> TxtCompanyComplete_name.Text.Trim Then
            Call FilterDataset()
            RaiseEvent TextChanged(sender, e)
            Call FindThisCompanyName(1)
        End If
    End Sub
    Private Sub TxtCompanyName_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus, TxtCompanyComplete_name.GotFocus
        OldTxtCompanyvar = TxtCompanyComplete_name.Text
        RaiseEvent GotFocus(sender, e)
        Me.Height = 154
    End Sub
    Private Sub TxtCompanyName_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCompanyComplete_name.LostFocus
        TxtCompanyComplete_name.Text = TxtCompanyComplete_name.Text.Trim
        Call FindThisCompanyName(1)
    End Sub
    Private Sub CompanyName_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        TxtCompanyComplete_name.Text = TxtCompanyComplete_name.Text.Trim
        Call FindThisCompanyName(1)
        Me.Height = 22
    End Sub
    Private Function FindThisCompanyName(ByVal KindOfFind As Integer) As Boolean
        Flg = False
        If KindOfFind = 2 Then
            ClsCompanyName1.cod_company = MCompanyCodForFind
        End If
        If ClsCompanyName1.FindCode(TxtCompanyComplete_name.Text.Trim, KindOfFind) Then
            FindThisCompanyName = True
            CompanyComplete_Name = ClsCompanyName1.complete_name.Trim
            MCompanyAbbreviation_name = ClsCompanyName1.abbreviation_name.Trim
            MCompanyCod = ClsCompanyName1.cod_company.Trim
            RaiseEvent FindCompanyName()
        Else
            FindThisCompanyName = False
            If KindOfFind = 2 Then
                CompanyComplete_Name = ""
            End If
            MCompanyAbbreviation_name = ""
            MCompanyCod = ""
            If MReleaseIfNotFoundCompanyName = True Then TxtCompanyComplete_name.Text = ""
            RaiseEvent NotFindCompanyName()
        End If
        Flg = True
    End Function
    Private Sub TxtCompanyName_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Validating, TxtCompanyComplete_name.Validating
        TxtCompanyComplete_name.Text = TxtCompanyComplete_name.Text.Trim
        Call FindThisCompanyName(1)
        If MNotExitIfNotFound = True And MCompanyAbbreviation_name = "" Then
            e.Cancel = True
        End If
    End Sub
    Private Sub TxtCompanyName_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp, TxtCompanyComplete_name.KeyUp

        Select Case e.KeyCode
            Case Keys.F4
                If e.Shift = False And e.Alt = False And e.Control = False Then
                    MyFrmSearchCompanyName.CustomerCompleteName = CustomerCompleteName
                    MyFrmSearchCompanyName.ShowDialog()
                End If
        End Select
    End Sub
    Private Sub MyFrmSearchCompanyName_CompanyNameFind(ByVal ThisCompanyName As String, ByVal ThisCompanyAbbreviation_name As String, ByVal ThisCompanycomplete_name As String) Handles MyFrmSearchCompanyName.CompanyFind
        TxtCompanyComplete_name.Text = ThisCompanycomplete_name
        MCompanyAbbreviation_name = ThisCompanyAbbreviation_name
        RaiseEvent FindCompanyName()
    End Sub
    Private Sub CodKolUC_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.BackColorChanged
        TxtCompanyComplete_name.BackColor = Me.BackColor
    End Sub
    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        MyFrmSearchCompanyName.CustomerCompleteName = CustomerCompleteName
        MyFrmSearchCompanyName.ShowDialog()
    End Sub
    Private Sub GridEX1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEX1.DoubleClick
        If GridEX1.RowCount > 0 Then
            Dim Currentrow As GridEXRow = GridEX1.GetRow
            TxtCompanyComplete_name.Text = Currentrow.Cells(0).Value
        End If
        TxtCompanyComplete_name.Focus()
        SendKeys.Send("{TAB}")
    End Sub
    Private Sub CompanyName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        Me.Height = 22
    End Sub
End Class
