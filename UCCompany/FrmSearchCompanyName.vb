Imports CommonClass
Public Class FrmSearchCompanyName
    Inherits System.Windows.Forms.Form
    Event CompanyFind(ByVal ThisCompanyCode As String, ByVal ThisCompanyAbbreviation_name As String, ByVal ThisCompanycomplete_name As String)
    Dim WithEvents ClsCompanyCode1 As New ClsCompanyName
    Public CustomerCompleteName As String
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
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents DSFrmSearchCompanyCode1 As DSCust_Company
    Friend WithEvents Connection As System.Data.SqlClient.SqlConnection
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.DSFrmSearchCompanyCode1 = New UCCompany.DSCust_Company
        Me.Connection = New System.Data.SqlClient.SqlConnection
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        CType(Me.DSFrmSearchCompanyCode1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdExit
        '
        Me.CmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdExit.Location = New System.Drawing.Point(13, 334)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 23)
        Me.CmdExit.TabIndex = 15
        Me.CmdExit.Text = "Exit"
        '
        'CmdOk
        '
        Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdOk.Location = New System.Drawing.Point(105, 335)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 16
        Me.CmdOk.Text = "Ok"
        '
        'DSFrmSearchCompanyCode1
        '
        Me.DSFrmSearchCompanyCode1.DataSetName = "DSCust_Company"
        Me.DSFrmSearchCompanyCode1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Connection
        '
        Me.Connection.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;" & _
        "persist security info=True;password=sa"
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "cust_company"
        Me.GrdDetail.DataSource = Me.DSFrmSearchCompanyCode1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>cust_company</Caption><Columns Collection=""" & _
        "true""><Column0 ID=""cod_company""><Caption>Code</Caption><TypeNameEmptyStringValue" & _
        ">System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>cod_com" & _
        "pany</DataMember><Key>cod_company</Key><Position>0</Position><Width>69</Width></" & _
        "Column0><Column1 ID=""abbreviation_name""><Caption>Abbreviation Name</Caption><Dat" & _
        "aMember>abbreviation_name</DataMember><Key>abbreviation_name</Key><Position>1</P" & _
        "osition><Width>133</Width></Column1><Column2 ID=""complete_name""><Caption>Complet" & _
        "e Name</Caption><DataMember>complete_name</DataMember><Key>complete_name</Key><P" & _
        "osition>2</Position><Width>180</Width></Column2><Column3 ID=""address""><Caption>A" & _
        "ddress</Caption><DataMember>address</DataMember><Key>address</Key><Position>3</P" & _
        "osition><Width>134</Width></Column3><Column4 ID=""zip_code""><Caption>Zipcode</Cap" & _
        "tion><DataMember>zip_code</DataMember><Key>zip_code</Key><Position>4</Position><" & _
        "Width>56</Width></Column4><Column5 ID=""remark""><Caption>Remark</Caption><DataMem" & _
        "ber>remark</DataMember><Key>remark</Key><Position>5</Position><Width>87</Width><" & _
        "/Column5></Columns><GroupCondition ID="""" /><Key>cust_company</Key></RootTable></" & _
        "GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GrdDetail.Location = New System.Drawing.Point(0, 0)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.RecordNavigator = True
        Me.GrdDetail.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdDetail.Size = New System.Drawing.Size(709, 326)
        Me.GrdDetail.TabIndex = 19
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'FrmSearchCompanyName
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(709, 366)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.CmdExit)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmSearchCompanyName"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company Search"
        CType(Me.DSFrmSearchCompanyCode1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmSearchInvCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connection.ConnectionString = PConnectionString
        ClsCompanyCode1.Connection = Connection
        ClsCompanyCode1.complete_name = CustomerCompleteName
        DSFrmSearchCompanyCode1.Clear()
        ClsCompanyCode1.DAcod_company.Fill(DSFrmSearchCompanyCode1, "cust_company")
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        Try
            If GrdDetail.RowCount > 0 Then
                RaiseEvent CompanyFind(GrdDetail.GetRow.Cells(0).Value & "", GrdDetail.GetRow.Cells(1).Value & "", GrdDetail.GetRow.Cells(2).Value & "")
                Me.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Call GrdDetail_DoubleClick(sender, e)
        Me.Close()
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
End Class
