Public Class FrmGlChartOfAccountSearch
    Inherits CommonClass.FrmBase
    Public Event Gl_accountFind(ByVal GL_account As String, ByVal Desc_GL_account As String)
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
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DaGlAccount As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmGlChartOfAccountSearch1 As UcAccount.DsFrmGlChartOfAccountSearch
    Friend WithEvents grd1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents CmdPrint As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmGlChartOfAccountSearch))
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.cnn = New System.Data.SqlClient.SqlConnection
        Me.DaGlAccount = New System.Data.SqlClient.SqlDataAdapter
        Me.DsFrmGlChartOfAccountSearch1 = New UcAccount.DsFrmGlChartOfAccountSearch
        Me.grd1 = New Janus.Windows.GridEX.GridEX
        Me.CmdPrint = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        CType(Me.DsFrmGlChartOfAccountSearch1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT GL_account.GL_account, GL_account.desc_GL_account, GL_account_group.desc_g" & _
        "roup_account, GL_account_group_subgroup1.Gl_account_group_subgroup1_desc, GL_acc" & _
        "ount.remark, GL_account_group_subgroup2.Gl_account_group_subgroup2_desc FROM GL_" & _
        "account LEFT OUTER JOIN GL_account_group_subgroup2 ON GL_account.Gl_account_grou" & _
        "p_subgroup2_code = GL_account_group_subgroup2.Gl_account_group_subgroup2_code LE" & _
        "FT OUTER JOIN GL_account_group_subgroup1 ON GL_account.Gl_account_group_subgroup" & _
        "1_code = GL_account_group_subgroup1.Gl_account_group_subgroup1_code LEFT OUTER J" & _
        "OIN GL_account_group ON GL_account.group_GL_account = GL_account_group.group_GL_" & _
        "account ORDER BY GL_account.GL_account"
        Me.SqlSelectCommand1.Connection = Me.cnn
        '
        'cnn
        '
        Me.cnn.ConnectionString = "workstation id=FARAJI;packet size=4096;user id=sa;initial catalog=Tiremate_02;per" & _
        "sist security info=True;password=sa"
        '
        'DaGlAccount
        '
        Me.DaGlAccount.SelectCommand = Me.SqlSelectCommand1
        Me.DaGlAccount.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("desc_GL_account", "desc_GL_account"), New System.Data.Common.DataColumnMapping("GL_account_master", "GL_account_master"), New System.Data.Common.DataColumnMapping("group_GL_account", "group_GL_account"), New System.Data.Common.DataColumnMapping("Gl_account_group_subgroup1_code", "Gl_account_group_subgroup1_code"), New System.Data.Common.DataColumnMapping("Gl_account_group_subgroup2_code", "Gl_account_group_subgroup2_code"), New System.Data.Common.DataColumnMapping("remark", "remark")})})
        '
        'DsFrmGlChartOfAccountSearch1
        '
        Me.DsFrmGlChartOfAccountSearch1.DataSetName = "DsFrmGlChartOfAccountSearch"
        Me.DsFrmGlChartOfAccountSearch1.Locale = New System.Globalization.CultureInfo("ar-SA")
        '
        'grd1
        '
        Me.grd1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.grd1.AlternatingColors = True
        Me.grd1.BuiltInTextsData = "<LocalizableData ID=""LocalizableStrings"" Collection=""true""><GroupByBoxInfo /></Lo" & _
        "calizableData>"
        Me.grd1.DataMember = "GL_account"
        Me.grd1.DataSource = Me.DsFrmGlChartOfAccountSearch1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_account</Caption><Columns Collection=""tr" & _
        "ue""><Column0 ID=""GL_account""><Caption>Gl Code</Caption><TypeNameEmptyStringValue" & _
        ">System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>GL_acco" & _
        "unt</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditTy" & _
        "pe><Key>GL_account</Key><Position>0</Position><Width>98</Width></Column0><Column" & _
        "1 ID=""desc_GL_account""><Caption>Gl Description</Caption><DataMember>desc_GL_acco" & _
        "unt</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditTy" & _
        "pe><Key>desc_GL_account</Key><Position>1</Position><Width>131</Width></Column1><" & _
        "Column2 ID=""desc_group_account""><Caption>Gl Account Groups</Caption><DataMember>" & _
        "desc_group_account</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBo" & _
        "x</FilterEditType><Key>desc_group_account</Key><Position>2</Position><Width>123<" & _
        "/Width></Column2><Column3 ID=""Gl_account_group_subgroup1_desc""><Caption>Gl Accou" & _
        "nt Subgroup1</Caption><DataMember>Gl_account_group_subgroup1_desc</DataMember><E" & _
        "ditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>Gl_account" & _
        "_group_subgroup1_desc</Key><Position>3</Position><Width>140</Width></Column3><Co" & _
        "lumn4 ID=""Gl_account_group_subgroup2_desc""><Caption>Gl Account Subgroup2</Captio" & _
        "n><DataMember>Gl_account_group_subgroup2_desc</DataMember><EditType>NoEdit</Edit" & _
        "Type><FilterEditType>TextBox</FilterEditType><Key>Gl_account_group_subgroup2_des" & _
        "c</Key><Position>4</Position><Width>157</Width></Column4><Column5 ID=""remark""><C" & _
        "aption>General Description</Caption><DataMember>remark</DataMember><EditType>NoE" & _
        "dit</EditType><FilterEditType>TextBox</FilterEditType><Key>remark</Key><Position" & _
        ">5</Position><Width>116</Width></Column5></Columns><GroupCondition ID="""" /><Key>" & _
        "GL_account</Key></RootTable></GridEXLayoutData>"
        Me.grd1.DesignTimeLayout = GridEXLayout1
        Me.grd1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grd1.Location = New System.Drawing.Point(8, 8)
        Me.grd1.Name = "grd1"
        Me.grd1.RecordNavigator = True
        Me.grd1.Size = New System.Drawing.Size(824, 392)
        Me.grd1.TabIndex = 0
        '
        'CmdPrint
        '
        Me.CmdPrint.Location = New System.Drawing.Point(664, 408)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(75, 23)
        Me.CmdPrint.TabIndex = 1
        Me.CmdPrint.Text = "Print"
        '
        'CmdExit
        '
        Me.CmdExit.Location = New System.Drawing.Point(752, 408)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 23)
        Me.CmdExit.TabIndex = 2
        Me.CmdExit.Text = "Exit"
        '
        'GridEXPrintDocument1
        '
        Me.GridEXPrintDocument1.GridEX = Me.grd1
        Me.GridEXPrintDocument1.PageHeaderCenter = "Gl Chart Of Account"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.GridEXPrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Location = New System.Drawing.Point(576, 16)
        Me.PrintPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.Visible = False
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(576, 408)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 3
        Me.CmdOk.Text = "Ok"
        '
        'FrmGlChartOfAccountSearch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(840, 436)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.CmdPrint)
        Me.Controls.Add(Me.grd1)
        Me.Name = "FrmGlChartOfAccountSearch"
        Me.Text = "Gl Chart Of Account"
        CType(Me.DsFrmGlChartOfAccountSearch1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub

    Private Sub FrmGlChartOfAccountSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnn.ConnectionString = CommonClass.PConnectionString
        DsFrmGlChartOfAccountSearch1.Clear()
        DaGlAccount.Fill(DsFrmGlChartOfAccountSearch1)
    End Sub
    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Grd1_DoubleClick(sender, e)
    End Sub

    Private Sub Grd1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd1.DoubleClick
        Try
            If grd1.RowCount > 0 Then
                RaiseEvent Gl_accountFind(grd1.GetRow.Cells(0).Value & "", grd1.GetRow.Cells(1).Value & " ")
                Me.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
