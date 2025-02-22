Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmSearchCashPaidOut
    Inherits FrmBase
    Event CashPaidOutFind(ByVal ThisRefrence_code As String)
    Public MTypeOfForm As String
    Public Property TypeOfForm() As String
        Get
            Return MTypeOfForm
        End Get
        Set(ByVal Value As String)
            MTypeOfForm = Value
        End Set
    End Property
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
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents DAGL_Paid_received As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmSearchCashPaidOut1 As UCBankAccount.DSFrmSearchCashPaidOut
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DsFrmSearchCashPaidOut1 = New UCBankAccount.DSFrmSearchCashPaidOut
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.DAGL_Paid_received = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmSearchCashPaidOut1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "GL_Paid_received"
        Me.GrdDetail.DataSource = Me.DsFrmSearchCashPaidOut1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_Paid_received</Caption><Columns Collecti" & _
        "on=""true""><Column0 ID=""refrence_code""><Caption>Ref. No</Caption><TypeNameEmptySt" & _
        "ringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMembe" & _
        "r>refrence_code</DataMember><Key>refrence_code</Key><Position>0</Position><Width" & _
        ">73</Width></Column0><Column1 ID=""tran_type""><Caption>tran_type</Caption><DataMe" & _
        "mber>tran_type</DataMember><Key>tran_type</Key><Position>1</Position><Visible>Fa" & _
        "lse</Visible></Column1><Column2 ID=""ThisCode""><Caption>Code</Caption><DataMember" & _
        ">ThisCode</DataMember><Key>ThisCode</Key><Position>2</Position><Visible>False</V" & _
        "isible></Column2><Column3 ID=""customer_code""><Caption>customer_code</Caption><Da" & _
        "taMember>customer_code</DataMember><Key>customer_code</Key><Position>3</Position" & _
        "><Visible>False</Visible></Column3><Column4 ID=""vendor_code""><Caption>vendor_cod" & _
        "e</Caption><DataMember>vendor_code</DataMember><Key>vendor_code</Key><Position>4" & _
        "</Position><Visible>False</Visible></Column4><Column5 ID=""FullName""><Caption>Nam" & _
        "e</Caption><DataMember>FullName</DataMember><Key>FullName</Key><Position>5</Posi" & _
        "tion><Width>114</Width></Column5><Column6 ID=""companyName""><Caption>company</Cap" & _
        "tion><DataMember>companyName</DataMember><Key>companyName</Key><Position>6</Posi" & _
        "tion><Width>129</Width></Column6><Column7 ID=""amount""><Caption>Amount</Caption><" & _
        "DataMember>amount</DataMember><FormatString>c2</FormatString><Key>amount</Key><P" & _
        "osition>7</Position><TextAlignment>Far</TextAlignment><Width>80</Width></Column7" & _
        "><Column8 ID=""action_date""><Caption>Date</Caption><DataMember>action_date</DataM" & _
        "ember><Key>action_date</Key><Position>8</Position><Width>77</Width></Column8><Co" & _
        "lumn9 ID=""GL_account""><Caption>GL Account</Caption><DataMember>GL_account</DataM" & _
        "ember><Key>GL_account</Key><Position>9</Position><Width>87</Width></Column9><Col" & _
        "umn10 ID=""memo""><Caption>Memo</Caption><DataMember>memo</DataMember><Key>memo</K" & _
        "ey><Position>10</Position></Column10><Column11 ID=""OtherReceipType""><Caption>Oth" & _
        "erReceipType</Caption><DataMember>OtherReceipType</DataMember><Key>OtherReceipTy" & _
        "pe</Key><Position>11</Position><Visible>False</Visible></Column11></Columns><Gro" & _
        "upCondition ID="""" /><Key>GL_Paid_received</Key></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
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
        Me.GrdDetail.Size = New System.Drawing.Size(629, 355)
        Me.GrdDetail.TabIndex = 2
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'DsFrmSearchCashPaidOut1
        '
        Me.DsFrmSearchCashPaidOut1.DataSetName = "DSFrmSearchCashPaidOut"
        Me.DsFrmSearchCashPaidOut1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BEH;packet size=4096;user id=sa;data source=""."";persist security i" & _
        "nfo=True;initial catalog=TireMate_01;password=2191110"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CmdOk)
        Me.Panel2.Controls.Add(Me.CmdExit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 355)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(629, 33)
        Me.Panel2.TabIndex = 21
        '
        'CmdOk
        '
        Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmdOk.ForeColor = System.Drawing.Color.Black
        Me.CmdOk.Location = New System.Drawing.Point(447, 5)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 24)
        Me.CmdOk.TabIndex = 22
        Me.CmdOk.Text = "Ok"
        '
        'CmdExit
        '
        Me.CmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmdExit.ForeColor = System.Drawing.Color.Black
        Me.CmdExit.Location = New System.Drawing.Point(543, 5)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 24)
        Me.CmdExit.TabIndex = 21
        Me.CmdExit.Text = "Exit"
        '
        'DAGL_Paid_received
        '
        Me.DAGL_Paid_received.SelectCommand = Me.SqlSelectCommand2
        Me.DAGL_Paid_received.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_Paid_received", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_code", "refrence_code"), New System.Data.Common.DataColumnMapping("tran_type", "tran_type"), New System.Data.Common.DataColumnMapping("action_date", "action_date"), New System.Data.Common.DataColumnMapping("customer_code", "customer_code"), New System.Data.Common.DataColumnMapping("vendor_code", "vendor_code"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("memo", "memo")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT GL_Paid_received.refrence_code, GL_Paid_received.tran_type, GL_Paid_receiv" & _
        "ed.action_date, GL_Paid_received.customer_code, GL_Paid_received.vendor_code, GL" & _
        "_Paid_received.amount, GL_Paid_received.GL_account, GL_Paid_received.memo, GL_Pa" & _
        "id_received.OtherReceipType, ISNULL(inv_vendor.desc_vendor, '') + '' + ISNULL(cu" & _
        "st_trtab_main.f_name, '') + ' ' + ISNULL(cust_trtab_main.m_name, '') + ' ' + ISN" & _
        "ULL(cust_trtab_main.l_name, '') AS FullName, cust_company.complete_name AS compa" & _
        "nyName, ISNULL(GL_Paid_received.vendor_code, '') + '' + ISNULL(GL_Paid_received." & _
        "customer_code, '') AS ThisCode FROM GL_Paid_received LEFT OUTER JOIN cust_trtab_" & _
        "main ON GL_Paid_received.customer_code = cust_trtab_main.cod_customer LEFT OUTER" & _
        " JOIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_company LEF" & _
        "T OUTER JOIN inv_vendor ON GL_Paid_received.vendor_code = inv_vendor.cod_vendor " & _
        "WHERE (GL_Paid_received.tran_type = @tran_type)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tran_type", System.Data.SqlDbType.VarChar, 1, "tran_type"))
        '
        'FrmSearchCashPaidOut
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(629, 388)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmSearchCashPaidOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Find Cash Paid Out"
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmSearchCashPaidOut1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmSearchBankDeposit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Try
            Cnn.ConnectionString = PConnectionString
        Catch ex As Exception
        End Try
        If TypeOfForm = "1" Then
            Me.Text = "Find Cash Paid Out"
        Else
            Me.Text = "Find Other Receipts Screen"
        End If
        Call FillDataSet()
    End Sub
    Private Sub FillDataSet()
        DsFrmSearchCashPaidOut1.GL_Paid_received.Clear()
        DAGL_Paid_received.SelectCommand.Parameters("@Tran_Type").Value = TypeOfForm
        DAGL_Paid_received.Fill(DsFrmSearchCashPaidOut1, "GL_Paid_received")
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        Try
            If GrdDetail.RowCount > 0 Then
                RaiseEvent CashPaidOutFind(GrdDetail.GetRow.Cells(0).Value)
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
