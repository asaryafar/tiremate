Imports CommonClass
Public Class FrmSearchJournal
    Inherits FrmBase
    Public Event FindThisJournalNo(ByVal ThisId As Decimal)
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DaSearchjournal As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsSearchJournal1 As UcAccount.DsSearchJournal
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DsSearchJournal1 = New UcAccount.DsSearchJournal
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DaSearchjournal = New System.Data.SqlClient.SqlDataAdapter
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSearchJournal1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataSource = Me.DsSearchJournal1.GL_journal_head
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_journal_head</Caption><Columns Collectio" & _
        "n=""true""><Column0 ID=""id_GL_journal""><Caption>Ref No</Caption><TypeNameEmptyStri" & _
        "ngValue>NULL</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>id_GL_jou" & _
        "rnal</DataMember><EditType>NoEdit</EditType><Key>id_GL_journal</Key><Position>0<" & _
        "/Position><Width>73</Width></Column0><Column1 ID=""GL_journal_date""><Caption>Date" & _
        "</Caption><DataMember>GL_journal_date</DataMember><Key>GL_journal_date</Key><Pos" & _
        "ition>1</Position><Width>91</Width></Column1><Column2 ID=""GL_journal_type_desc"">" & _
        "<Caption>Type Journal</Caption><DataMember>GL_journal_type_desc</DataMember><Key" & _
        ">GL_journal_type_desc</Key><Position>2</Position></Column2><Column3 ID=""GL_journ" & _
        "al_reference""><Caption>Reference</Caption><DataMember>GL_journal_reference</Data" & _
        "Member><Key>GL_journal_reference</Key><Position>3</Position></Column3><Column4 I" & _
        "D=""GL_account""><Caption>Account Code</Caption><DataMember>GL_account</DataMember" & _
        "><Key>GL_account</Key><Position>4</Position><Width>94</Width></Column4><Column5 " & _
        "ID=""desc_GL_account""><Caption>Account Name</Caption><DataMember>desc_GL_account<" & _
        "/DataMember><Key>desc_GL_account</Key><Position>5</Position><Width>119</Width></" & _
        "Column5><Column6 ID=""DtlReference""><Caption>Reference Detail</Caption><DataMembe" & _
        "r>DtlReference</DataMember><Key>DtlReference</Key><Position>6</Position></Column" & _
        "6><Column7 ID=""GL_journal_amount_debit""><Caption>Debit</Caption><DataMember>GL_j" & _
        "ournal_amount_debit</DataMember><FormatString>c</FormatString><Key>GL_journal_am" & _
        "ount_debit</Key><Position>7</Position><TextAlignment>Far</TextAlignment></Column" & _
        "7><Column8 ID=""GL_journal_amount_credit""><Caption>Credit</Caption><DataMember>GL" & _
        "_journal_amount_credit</DataMember><FormatString>c</FormatString><Key>GL_journal" & _
        "_amount_credit</Key><Position>8</Position><TextAlignment>Far</TextAlignment></Co" & _
        "lumn8></Columns><GroupCondition ID="""" /><Groups Collection=""true""><Group0 ID=""Gr" & _
        "oup0""><ColIndex>0</ColIndex></Group0></Groups><Key>GL_journal_head</Key></RootTa" & _
        "ble></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GrdDetail.Location = New System.Drawing.Point(0, 44)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.RecordNavigator = True
        Me.GrdDetail.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdDetail.Size = New System.Drawing.Size(656, 368)
        Me.GrdDetail.TabIndex = 23
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'DsSearchJournal1
        '
        Me.DsSearchJournal1.DataSetName = "DsSearchJournal"
        Me.DsSearchJournal1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CmdOk)
        Me.Panel2.Controls.Add(Me.CmdExit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 412)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(656, 33)
        Me.Panel2.TabIndex = 24
        '
        'CmdOk
        '
        Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmdOk.ForeColor = System.Drawing.Color.Black
        Me.CmdOk.Location = New System.Drawing.Point(474, 5)
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
        Me.CmdExit.Location = New System.Drawing.Point(570, 5)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 24)
        Me.CmdExit.TabIndex = 21
        Me.CmdExit.Text = "Exit"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT GL_journal_head.id_GL_journal, GL_journal_head.GL_journal_date, GL_journal" & _
        "_head.GL_journal_reference, GL_journal_head.GL_journal_type_code, GL_journal_hea" & _
        "d.GL_picture, GL_journal_dtl.GL_account, GL_journal_dtl.GL_journal_reference AS " & _
        "DtlReference, GL_journal_dtl.GL_journal_amount_debit, GL_journal_dtl.GL_journal_" & _
        "amount_credit, GL_account.desc_GL_account, GL_type_journal.GL_journal_type_desc " & _
        "FROM GL_type_journal INNER JOIN GL_journal_head ON GL_type_journal.GL_journal_ty" & _
        "pe_code = GL_journal_head.GL_journal_type_code LEFT OUTER JOIN GL_account RIGHT " & _
        "OUTER JOIN GL_journal_dtl ON GL_account.GL_account = GL_journal_dtl.GL_account O" & _
        "N GL_journal_head.id_GL_journal = GL_journal_dtl.id_GL_journal"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH;packet size=4096;user id=sa;data source=ARMANDEH;persist " & _
        "security info=True;initial catalog=TireMate_01;password="
        '
        'DaSearchjournal
        '
        Me.DaSearchjournal.SelectCommand = Me.SqlSelectCommand1
        Me.DaSearchjournal.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_journal_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("GL_journal_date", "GL_journal_date"), New System.Data.Common.DataColumnMapping("GL_journal_reference", "GL_journal_reference"), New System.Data.Common.DataColumnMapping("GL_journal_type_code", "GL_journal_type_code"), New System.Data.Common.DataColumnMapping("GL_picture", "GL_picture")})})
        '
        'FrmSearchJournal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(656, 445)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmSearchJournal"
        Me.Text = "Search Journal"
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSearchJournal1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmSearchJournal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        DaSearchjournal.Fill(DsSearchJournal1)
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        If GrdDetail.GetRow().Cells(0).Value & "" <> "" Then
            RaiseEvent FindThisJournalNo(GrdDetail.GetRow().Cells(0).Value)
            Me.Close()
        End If
    End Sub

    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
End Class
