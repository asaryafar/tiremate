Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmSearchGlAccount
    Inherits FrmBase
    Public Event GlAccountFind(ByVal ThisRow As DataRow)
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
    Friend WithEvents DsFrmGlAccount1 As DSFrmGlAccount
    Friend WithEvents DaGlAccount As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents UcPrintGrid1 As CommonClass.UCPrintGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmSearchGlAccount))
        Me.DsFrmGlAccount1 = New UCGl_Account.DSFrmGlAccount
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.Connection = New System.Data.SqlClient.SqlConnection
        Me.DaGlAccount = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.UcPrintGrid1 = New CommonClass.UCPrintGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.DsFrmGlAccount1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'DsFrmGlAccount1
        '
        Me.DsFrmGlAccount1.DataSetName = "DSFrmGlAccount"
        Me.DsFrmGlAccount1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'CmdExit
        '
        Me.CmdExit.Location = New System.Drawing.Point(473, 343)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 23)
        Me.CmdExit.TabIndex = 28
        Me.CmdExit.Text = "Exit"
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(561, 343)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 29
        Me.CmdOk.Text = "Ok"
        '
        'Connection
        '
        Me.Connection.ConnectionString = "workstation id=ARMANDEH3;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=TireMate_01"
        '
        'DaGlAccount
        '
        Me.DaGlAccount.SelectCommand = Me.SqlCommand1
        Me.DaGlAccount.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("desc_GL_account", "desc_GL_account"), New System.Data.Common.DataColumnMapping("GL_account_master", "GL_account_master"), New System.Data.Common.DataColumnMapping("group_GL_account", "group_GL_account"), New System.Data.Common.DataColumnMapping("remark", "remark")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT GL_account, desc_GL_account, GL_account_master, group_GL_account, remark, " & _
        "Gl_account_group_subgroup1_code, Gl_account_group_subgroup2_code FROM GL_account" & _
        " ORDER BY GL_account"
        Me.SqlCommand1.Connection = Me.Connection
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "GL_account"
        Me.GrdDetail.DataSource = Me.DsFrmGlAccount1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_account</Caption><Columns Collection=""tr" & _
        "ue""><Column0 ID=""GL_account""><Caption>GL Account</Caption><TypeNameEmptyStringVa" & _
        "lue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>GL_a" & _
        "ccount</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEdi" & _
        "tType><Key>GL_account</Key><Position>0</Position><Width>73</Width></Column0><Col" & _
        "umn1 ID=""desc_GL_account""><Caption>Description</Caption><DataMember>desc_GL_acco" & _
        "unt</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditTy" & _
        "pe><Key>desc_GL_account</Key><Position>1</Position><Width>308</Width></Column1><" & _
        "Column2 ID=""GL_account_master""><Caption>GL_account_master</Caption><DataMember>G" & _
        "L_account_master</DataMember><Key>GL_account_master</Key><Position>2</Position><" & _
        "Visible>False</Visible></Column2><Column3 ID=""group_GL_account""><Caption>group_G" & _
        "L_account</Caption><DataMember>group_GL_account</DataMember><Key>group_GL_accoun" & _
        "t</Key><Position>3</Position><Visible>False</Visible></Column3><Column4 ID=""rema" & _
        "rk""><Caption>remark</Caption><DataMember>remark</DataMember><Key>remark</Key><Po" & _
        "sition>4</Position><Visible>False</Visible></Column4><Column5 ID=""group_GL_accou" & _
        "nt""><Caption>Group</Caption><DataMember>group_GL_account</DataMember><EditType>N" & _
        "oEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>group_GL_account</K" & _
        "ey><Position>5</Position><Width>71</Width></Column5><Column6 ID=""Gl_account_grou" & _
        "p_subgroup1_code""><Caption>Subgroup1</Caption><DataMember>Gl_account_group_subgr" & _
        "oup1_code</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filter" & _
        "EditType><Key>Gl_account_group_subgroup1_code</Key><Position>6</Position><Width>" & _
        "77</Width></Column6><Column7 ID=""Gl_account_group_subgroup2_code""><Caption>Subgr" & _
        "oup2</Caption><DataMember>Gl_account_group_subgroup2_code</DataMember><EditType>" & _
        "NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>Gl_account_group_s" & _
        "ubgroup2_code</Key><Position>7</Position><Width>73</Width></Column7></Columns><G" & _
        "roupCondition ID="""" /><Key>GL_account</Key></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GrdDetail.Location = New System.Drawing.Point(0, 45)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.RecordNavigator = True
        Me.GrdDetail.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdDetail.Size = New System.Drawing.Size(646, 292)
        Me.GrdDetail.TabIndex = 30
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.UcPrintGrid1)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(646, 45)
        Me.Panel4.TabIndex = 31
        '
        'UcPrintGrid1
        '
        Me.UcPrintGrid1.GridEx = Me.GrdDetail
        Me.UcPrintGrid1.Location = New System.Drawing.Point(464, 8)
        Me.UcPrintGrid1.Name = "UcPrintGrid1"
        Me.UcPrintGrid1.Size = New System.Drawing.Size(176, 24)
        Me.UcPrintGrid1.TabIndex = 209
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(64, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 43)
        Me.Label1.TabIndex = 207
        Me.Label1.Text = "Find GL Account"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 208
        Me.PictureBox2.TabStop = False
        '
        'FrmSearchGlAccount
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(646, 371)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmSearchGlAccount"
        Me.Text = "Find GL Account"
        CType(Me.DsFrmGlAccount1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmSearchGlAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connection.ConnectionString = PConnectionString
        DaGlAccount.Fill(DsFrmGlAccount1)
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        Try
            If GrdDetail.RowCount > 0 Then
                Call AfterFindit()
                Me.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        If GrdDetail.RowCount > 0 Then
            Call AfterFindit()
        End If
        Me.Close()
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
    Sub AfterFindit()
        Try
            Dim ThisRowEx As GridEXRow
            ThisRowEx = GrdDetail.GetRow
            Dim dr1 As DataRow = DsFrmGlAccount1.GL_account.FindByGL_account(ThisRowEx.Cells(0).Value)
            If Not IsNothing(dr1) Then
                RaiseEvent GlAccountFind(dr1)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub UcPrintGrid1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UcPrintGrid1.Load

    End Sub
End Class
