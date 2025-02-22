Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmSearchBankDeposit
    Inherits FrmBase
    Event BankDepositFind(ByVal ThisId_debit_deposit_head As Int64)
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
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_debit_deposit_head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmSearchBankDeposit1 As UCBankAccount.DSFrmSearchBankDeposit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DataView1 = New System.Data.DataView
        Me.DsFrmSearchBankDeposit1 = New UCBankAccount.DSFrmSearchBankDeposit
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_debit_deposit_head = New System.Data.SqlClient.SqlDataAdapter
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmSearchBankDeposit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataSource = Me.DataView1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_debit_deposit_head</Caption><Columns Col" & _
        "lection=""true""><Column0 ID=""name_bank""><Caption>Bank</Caption><DataMember>name_b" & _
        "ank</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditTy" & _
        "pe><Key>name_bank</Key><Position>0</Position><Width>197</Width></Column0><Column" & _
        "1 ID=""id_debit_deposit_head""><Caption>Deposit No</Caption><DataMember>id_debit_d" & _
        "eposit_head</DataMember><EditType>NoEdit</EditType><Key>id_debit_deposit_head</K" & _
        "ey><Position>1</Position><Width>69</Width></Column1><Column2 ID=""date_doc""><Capt" & _
        "ion>Date</Caption><DataMember>date_doc</DataMember><EditType>NoEdit</EditType><F" & _
        "ilterEditType>TextBox</FilterEditType><Key>date_doc</Key><Position>2</Position><" & _
        "Width>87</Width></Column2><Column3 ID=""Totaldeposit_amount""><Caption>Net Deposit" & _
        "</Caption><DataMember>Totaldeposit_amount</DataMember><EditType>NoEdit</EditType" & _
        "><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>Tot" & _
        "aldeposit_amount</Key><Position>3</Position><TextAlignment>Far</TextAlignment></" & _
        "Column3><Column4 ID=""memo""><Caption>Memo</Caption><DataMember>memo</DataMember><" & _
        "EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>memo</Key" & _
        "><Position>4</Position><Width>133</Width></Column4></Columns><GroupCondition ID=" & _
        """"" /><Key>GL_debit_deposit_head</Key><SortKeys Collection=""true""><SortKey0 ID=""S" & _
        "ortKey0""><ColIndex>2</ColIndex></SortKey0></SortKeys></RootTable></GridEXLayoutD" & _
        "ata>"
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
        'DataView1
        '
        Me.DataView1.Table = Me.DsFrmSearchBankDeposit1.GL_debit_deposit_head
        '
        'DsFrmSearchBankDeposit1
        '
        Me.DsFrmSearchBankDeposit1.DataSetName = "DSFrmSearchBankDeposit"
        Me.DsFrmSearchBankDeposit1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=Tiremate_02"
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
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT GL_debit_deposit_head.date_doc, GL_debit_deposit_head.memo, bas_banks.name" & _
        "_bank, View_BankNetDeposit.NetDeposit AS Totaldeposit_amount, GL_debit_deposit_h" & _
        "ead.id_debit_deposit_head FROM GL_debit_deposit_head INNER JOIN bas_banks ON GL_" & _
        "debit_deposit_head.id_bank = bas_banks.id_bank INNER JOIN View_BankNetDeposit ON" & _
        " GL_debit_deposit_head.id_debit_deposit_head = View_BankNetDeposit.id_debit_depo" & _
        "sit_head"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAGL_debit_deposit_head
        '
        Me.DAGL_debit_deposit_head.SelectCommand = Me.SqlSelectCommand1
        Me.DAGL_debit_deposit_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_debit_deposit_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("date_doc", "date_doc"), New System.Data.Common.DataColumnMapping("memo", "memo"), New System.Data.Common.DataColumnMapping("cash_back_memo", "cash_back_memo"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'FrmSearchBankDeposit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(629, 388)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmSearchBankDeposit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Find Bank Deposit "
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmSearchBankDeposit1, System.ComponentModel.ISupportInitialize).EndInit()
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
        Call FillDataSet()
    End Sub
    Private Sub FillDataSet()
        DsFrmSearchBankDeposit1.GL_debit_deposit_head.Clear()
        DAGL_debit_deposit_head.Fill(DsFrmSearchBankDeposit1, "GL_debit_deposit_head")
        DataView1.RowFilter = ""
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        Try
            If GrdDetail.RowCount > 0 Then
                RaiseEvent BankDepositFind(GrdDetail.GetRow.Cells(1).Value)
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
