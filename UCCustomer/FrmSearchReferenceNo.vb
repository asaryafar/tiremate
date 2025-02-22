Imports CommonClass
Public Class FrmSearchReferenceNo
    Inherits FrmBase
    Event ReceivePaymentFind(ByVal ThisReferenceNo As String, ByVal ThisCustomerCod As String)
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
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents Connection As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmSearchReferenceNo1 As DSFrmSearchReferenceNo
    Friend WithEvents DAGl_receive_payment As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.Connection = New System.Data.SqlClient.SqlConnection
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DsFrmSearchReferenceNo1 = New UCCustomer.DSFrmSearchReferenceNo
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAGl_receive_payment = New System.Data.SqlClient.SqlDataAdapter
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmSearchReferenceNo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(108, 281)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 16
        Me.CmdOk.Text = "Ok"
        '
        'Connection
        '
        Me.Connection.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=BEH1;persist security" & _
        " info=True;initial catalog=TireMate_01;password=2191110"
        '
        'CmdExit
        '
        Me.CmdExit.Location = New System.Drawing.Point(11, 281)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 23)
        Me.CmdExit.TabIndex = 19
        Me.CmdExit.Text = "Exit"
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "Gl_receive_payment"
        Me.GrdDetail.DataSource = Me.DsFrmSearchReferenceNo1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>Gl_receive_payment</Caption><Columns Collec" & _
        "tion=""true""><Column0 ID=""refrence_no""><Caption>Payment No</Caption><TypeNameEmpt" & _
        "yStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMe" & _
        "mber>refrence_no</DataMember><Key>refrence_no</Key><Position>0</Position><Width>" & _
        "76</Width></Column0><Column1 ID=""cod_customer""><Caption>Customer</Caption><DataM" & _
        "ember>cod_customer</DataMember><Key>cod_customer</Key><Position>1</Position><Wid" & _
        "th>86</Width></Column1><Column2 ID=""FullName""><Caption>Name</Caption><DataMember" & _
        ">FullName</DataMember><Key>FullName</Key><Position>2</Position><Width>133</Width" & _
        "></Column2><Column3 ID=""companyName""><Caption>Company</Caption><DataMember>compa" & _
        "nyName</DataMember><Key>companyName</Key><Position>3</Position><Width>142</Width" & _
        "></Column3><Column4 ID=""amount_receive""><Caption>Amount</Caption><DataMember>amo" & _
        "unt_receive</DataMember><FormatString>c2</FormatString><Key>amount_receive</Key>" & _
        "<Position>4</Position><Width>87</Width></Column4><Column5 ID=""date_receive_payme" & _
        "nt""><Caption>Date</Caption><DataMember>date_receive_payment</DataMember><Key>dat" & _
        "e_receive_payment</Key><Position>5</Position><Width>81</Width></Column5></Column" & _
        "s><GroupCondition ID="""" /><Key>Gl_receive_payment</Key></RootTable></GridEXLayou" & _
        "tData>"
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
        Me.GrdDetail.Size = New System.Drawing.Size(648, 273)
        Me.GrdDetail.TabIndex = 20
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'DsFrmSearchReferenceNo1
        '
        Me.DsFrmSearchReferenceNo1.DataSetName = "DSFrmSearchReferenceNo"
        Me.DsFrmSearchReferenceNo1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Gl_receive_payment.refrence_no, Gl_receive_payment.cod_customer, Gl_receiv" & _
        "e_payment.amount_receive, Gl_receive_payment.date_receive_payment, cust_trtab_ma" & _
        "in.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS FullN" & _
        "ame, cust_company.complete_name AS companyName FROM Gl_receive_payment LEFT OUTE" & _
        "R JOIN cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_" & _
        "customer LEFT OUTER JOIN cust_company ON cust_trtab_main.cod_company = cust_comp" & _
        "any.cod_company"
        Me.SqlSelectCommand1.Connection = Me.Connection
        '
        'DAGl_receive_payment
        '
        Me.DAGl_receive_payment.SelectCommand = Me.SqlSelectCommand1
        Me.DAGl_receive_payment.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Gl_receive_payment", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("amount_receive", "amount_receive"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("pmt_method", "pmt_method"), New System.Data.Common.DataColumnMapping("cc_type", "cc_type"), New System.Data.Common.DataColumnMapping("cc_no", "cc_no"), New System.Data.Common.DataColumnMapping("Gl_account", "Gl_account"), New System.Data.Common.DataColumnMapping("date_receive_payment", "date_receive_payment"), New System.Data.Common.DataColumnMapping("check_no", "check_no"), New System.Data.Common.DataColumnMapping("expir_date_year", "expir_date_year"), New System.Data.Common.DataColumnMapping("expir_date_month", "expir_date_month"), New System.Data.Common.DataColumnMapping("AuthorizationCode", "AuthorizationCode"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'FrmSearchReferenceNo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(648, 310)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.CmdOk)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "FrmSearchReferenceNo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find Customer Payment"
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmSearchReferenceNo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmSearchReferenceNo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connection.ConnectionString = PConnectionString
        DsFrmSearchReferenceNo1.Clear()
        DAGl_receive_payment.Fill(DsFrmSearchReferenceNo1, "Gl_receive_payment")
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        Try
            If GrdDetail.RowCount > 0 Then
                RaiseEvent ReceivePaymentFind(GrdDetail.GetRow.Cells(0).Value & "", GrdDetail.GetRow.Cells(1).Value & "")
                Me.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Call GrdDetail_DoubleClick(sender, e)
        Me.Close()
    End Sub
End Class
