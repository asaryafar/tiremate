Imports CommonClass
Public Class FrmSearchReferenceNo
    Inherits System.Windows.Forms.Form
    Event AccountAdjustmentFind(ByVal ThisReferenceNo As String, ByVal ThisCustomerCod As String)
    Dim WithEvents ClsAccountCode1 As New ClsAccountAdjustment
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
    Friend WithEvents Connection As System.Data.SqlClient.SqlConnection
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmSearchReferenceNo1 As UCAccountAdjustment.DSFrmSearchReferenceNo
    Friend WithEvents DAGL_account_adjustment_head As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.Connection = New System.Data.SqlClient.SqlConnection
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_account_adjustment_head = New System.Data.SqlClient.SqlDataAdapter
        Me.DsFrmSearchReferenceNo1 = New UCAccountAdjustment.DSFrmSearchReferenceNo
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmSearchReferenceNo1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Connection
        '
        Me.Connection.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=""."";persist security " & _
        "info=True;initial catalog=Tiremate_02;password=2191110"
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "GL_account_adjustment_head"
        Me.GrdDetail.DataSource = Me.DsFrmSearchReferenceNo1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_account_adjustment_head</Caption><Column" & _
        "s Collection=""true""><Column0 ID=""refrence_no""><Caption>Adjustment No</Caption><T" & _
        "ypeNameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValu" & _
        "e /><DataMember>refrence_no</DataMember><Key>refrence_no</Key><Position>0</Posit" & _
        "ion><Width>84</Width></Column0><Column1 ID=""cod_customer""><Caption>Customer</Cap" & _
        "tion><DataMember>cod_customer</DataMember><Key>cod_customer</Key><Position>1</Po" & _
        "sition><Width>72</Width></Column1><Column2 ID=""l_name""><Caption>Last Name</Capti" & _
        "on><DataMember>l_name</DataMember><Key>l_name</Key><Position>2</Position><Width>" & _
        "126</Width></Column2><Column3 ID=""abbreviation_name""><Caption>Company</Caption><" & _
        "DataMember>abbreviation_name</DataMember><Key>abbreviation_name</Key><Position>3" & _
        "</Position><Width>155</Width></Column3><Column4 ID=""amount_adjustment""><Caption>" & _
        "Amount</Caption><DataMember>amount_adjustment</DataMember><FormatString>c</Forma" & _
        "tString><Key>amount_adjustment</Key><Position>4</Position><TextAlignment>Far</Te" & _
        "xtAlignment><Width>74</Width></Column4><Column5 ID=""date_adjustment""><Caption>Da" & _
        "te</Caption><DataMember>date_adjustment</DataMember><Key>date_adjustment</Key><P" & _
        "osition>5</Position><Width>76</Width></Column5><Column6 ID=""Remark""><Caption>Mem" & _
        "o</Caption><DataMember>Remark</DataMember><Key>Remark</Key><Position>6</Position" & _
        "><Width>118</Width></Column6><Column7 ID=""GL_account""><Caption>GL Account</Capti" & _
        "on><DataMember>GL_account</DataMember><Key>GL_account</Key><Position>7</Position" & _
        "><Width>75</Width></Column7><Column8 ID=""id_GL_journal""><Caption>id_GL_journal</" & _
        "Caption><DataMember>id_GL_journal</DataMember><Key>id_GL_journal</Key><Position>" & _
        "8</Position><Visible>False</Visible></Column8></Columns><GroupCondition ID="""" />" & _
        "<Key>GL_account_adjustment_head</Key></RootTable></GridEXLayoutData>"
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
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT GL_account_adjustment_head.refrence_no, GL_account_adjustment_head.cod_cus" & _
        "tomer, GL_account_adjustment_head.amount_adjustment, GL_account_adjustment_head." & _
        "date_adjustment, GL_account_adjustment_head.Remark, GL_account_adjustment_head.G" & _
        "L_account, GL_account_adjustment_head.id_GL_journal, GL_account_adjustment_head." & _
        "Gl_receive_payment_Refrence_no, GL_account_adjustment_head.finance_charge_flag, " & _
        "GL_account_adjustment_head.FromStoreNo, cust_trtab_main.l_name, cust_company.abb" & _
        "reviation_name, GL_account_adjustment_head.Old_Amount_adjustment FROM GL_account" & _
        "_adjustment_head LEFT OUTER JOIN cust_trtab_main ON GL_account_adjustment_head.c" & _
        "od_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN cust_company ON cust_" & _
        "trtab_main.cod_company = cust_company.cod_company"
        Me.SqlSelectCommand1.Connection = Me.Connection
        '
        'DAGL_account_adjustment_head
        '
        Me.DAGL_account_adjustment_head.SelectCommand = Me.SqlSelectCommand1
        Me.DAGL_account_adjustment_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_adjustment_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("amount_adjustment", "amount_adjustment"), New System.Data.Common.DataColumnMapping("date_adjustment", "date_adjustment"), New System.Data.Common.DataColumnMapping("Remark", "Remark"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Gl_receive_payment_Refrence_no", "Gl_receive_payment_Refrence_no"), New System.Data.Common.DataColumnMapping("finance_charge_flag", "finance_charge_flag"), New System.Data.Common.DataColumnMapping("Old_Amount_adjustment", "Old_Amount_adjustment"), New System.Data.Common.DataColumnMapping("FromStoreNo", "FromStoreNo")})})
        '
        'DsFrmSearchReferenceNo1
        '
        Me.DsFrmSearchReferenceNo1.DataSetName = "DSFrmSearchReferenceNo"
        Me.DsFrmSearchReferenceNo1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'FrmSearchReferenceNo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(709, 366)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.CmdExit)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmSearchReferenceNo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find Adjustment"
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmSearchReferenceNo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmSearchInvCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connection.ConnectionString = PConnectionString
        ClsAccountCode1.Connection = Connection
        'ClsAccountCode1.cod_customer = CustomerCompleteName
        DsFrmSearchReferenceNo1.Clear()
        DAGL_account_adjustment_head.Fill(DsFrmSearchReferenceNo1, "GL_account_adjustment_head")
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        Try
            If GrdDetail.RowCount > 0 Then
                RaiseEvent AccountAdjustmentFind(GrdDetail.GetRow.Cells(0).Value & "", GrdDetail.GetRow.Cells(1).Value & "")
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
