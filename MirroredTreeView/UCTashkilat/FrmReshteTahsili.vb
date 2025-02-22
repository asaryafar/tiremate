Imports CommonClass
Imports Janus.Windows.GridEX
Public Class FrmReshteTahsili
    Inherits CommonClass.FrmBase

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
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TreeReshteh As System.Windows.Forms.TreeView
    Friend WithEvents TxtDescGroup As System.Windows.Forms.TextBox
    Friend WithEvents LblCodGroup As System.Windows.Forms.TextBox
    Friend WithEvents Comment As UCCommentButton.CommentButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAtas_bas_group_reshteh_tahsili As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAtas_tr_groupreshtehtahsili_reshtehtahsili As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmReshteTahsili1 As UCTashkilat.DSFrmReshteTahsili
    Friend WithEvents MnuGeneral As System.Windows.Forms.ContextMenu
    Friend WithEvents MnAddNew As System.Windows.Forms.MenuItem
    Friend WithEvents MnEdit As System.Windows.Forms.MenuItem
    Friend WithEvents MnDelet As System.Windows.Forms.MenuItem
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAtas_bas_rasteh As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmbRasteh As System.Windows.Forms.ComboBox
    Friend WithEvents PnlText As System.Windows.Forms.GroupBox
    Friend WithEvents PnlButton As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmdCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAtas_bas_reshteh_tahsili As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmdFind As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmReshteTahsili))
        Me.TreeReshteh = New System.Windows.Forms.TreeView
        Me.MnuGeneral = New System.Windows.Forms.ContextMenu
        Me.MnAddNew = New System.Windows.Forms.MenuItem
        Me.MnEdit = New System.Windows.Forms.MenuItem
        Me.MnDelet = New System.Windows.Forms.MenuItem
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmReshteTahsili1 = New UCTashkilat.DSFrmReshteTahsili
        Me.TxtDescGroup = New System.Windows.Forms.TextBox
        Me.LblCodGroup = New System.Windows.Forms.TextBox
        Me.CmbRasteh = New System.Windows.Forms.ComboBox
        Me.Comment = New UCCommentButton.CommentButton
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PnlText = New System.Windows.Forms.GroupBox
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAtas_bas_group_reshteh_tahsili = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAtas_tr_groupreshtehtahsili_reshtehtahsili = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAtas_bas_rasteh = New System.Data.SqlClient.SqlDataAdapter
        Me.PnlButton = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmdCancel = New Janus.Windows.EditControls.UIButton
        Me.CmdSave = New Janus.Windows.EditControls.UIButton
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAtas_bas_reshteh_tahsili = New System.Data.SqlClient.SqlDataAdapter
        Me.Label5 = New System.Windows.Forms.Label
        Me.CmdFind = New System.Windows.Forms.Button
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmReshteTahsili1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlText.SuspendLayout()
        Me.PnlButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeReshteh
        '
        Me.TreeReshteh.BackColor = System.Drawing.SystemColors.Control
        Me.TreeReshteh.ContextMenu = Me.MnuGeneral
        Me.TreeReshteh.Cursor = System.Windows.Forms.Cursors.Default
        Me.TreeReshteh.Dock = System.Windows.Forms.DockStyle.Left
        Me.TreeReshteh.ImageIndex = -1
        Me.TreeReshteh.Location = New System.Drawing.Point(0, 0)
        Me.TreeReshteh.Name = "TreeReshteh"
        Me.TreeReshteh.SelectedImageIndex = -1
        Me.TreeReshteh.Size = New System.Drawing.Size(360, 452)
        Me.TreeReshteh.TabIndex = 8
        '
        'MnuGeneral
        '
        Me.MnuGeneral.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnAddNew, Me.MnEdit, Me.MnDelet})
        '
        'MnAddNew
        '
        Me.MnAddNew.Index = 0
        Me.MnAddNew.Text = "«ÌÃ«œ"
        '
        'MnEdit
        '
        Me.MnEdit.Index = 1
        Me.MnEdit.Text = "«’·«Õ"
        '
        'MnDelet
        '
        Me.MnDelet.Index = 2
        Me.MnDelet.Text = "Õ–›"
        '
        'GridEX1
        '
        Me.GridEX1.DataSource = Me.DsFrmReshteTahsili1.tas_bas_reshteh_tahsili
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""code_reshteh" & _
        "_tahsili""><Caption>òœ —‘ Â  Õ’Ì·Ì</Caption><DataMember>code_reshteh_tahsili</Dat" & _
        "aMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>" & _
        "code_reshteh_tahsili</Key><Position>0</Position><Width>101</Width></Column0><Col" & _
        "umn1 ID=""desc_reshteh_tahsili""><Caption>‘—Õ —‘ Â</Caption><DataMember>desc_resht" & _
        "eh_tahsili</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filte" & _
        "rEditType><Key>desc_reshteh_tahsili</Key><Position>1</Position><Width>201</Width" & _
        "></Column1></Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Location = New System.Drawing.Point(360, 0)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(344, 241)
        Me.GridEX1.TabIndex = 9
        '
        'DsFrmReshteTahsili1
        '
        Me.DsFrmReshteTahsili1.DataSetName = "DSFrmReshteTahsili"
        Me.DsFrmReshteTahsili1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'TxtDescGroup
        '
        Me.TxtDescGroup.Location = New System.Drawing.Point(40, 60)
        Me.TxtDescGroup.Name = "TxtDescGroup"
        Me.TxtDescGroup.Size = New System.Drawing.Size(144, 21)
        Me.TxtDescGroup.TabIndex = 427
        Me.TxtDescGroup.Text = ""
        '
        'LblCodGroup
        '
        Me.LblCodGroup.BackColor = System.Drawing.Color.Gold
        Me.LblCodGroup.Location = New System.Drawing.Point(64, 26)
        Me.LblCodGroup.Name = "LblCodGroup"
        Me.LblCodGroup.ReadOnly = True
        Me.LblCodGroup.Size = New System.Drawing.Size(120, 21)
        Me.LblCodGroup.TabIndex = 431
        Me.LblCodGroup.Text = ""
        '
        'CmbRasteh
        '
        Me.CmbRasteh.DataSource = Me.DsFrmReshteTahsili1.tas_bas_rasteh
        Me.CmbRasteh.DisplayMember = "desc_rasteh"
        Me.CmbRasteh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRasteh.Location = New System.Drawing.Point(16, 95)
        Me.CmbRasteh.Name = "CmbRasteh"
        Me.CmbRasteh.Size = New System.Drawing.Size(96, 21)
        Me.CmbRasteh.TabIndex = 425
        Me.CmbRasteh.ValueMember = "code_rasteh"
        '
        'Comment
        '
        Me.Comment.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.Comment.Location = New System.Drawing.Point(208, 93)
        Me.Comment.Name = "Comment"
        Me.Comment.Size = New System.Drawing.Size(90, 24)
        Me.Comment.TabIndex = 428
        Me.Comment.TabStop = False
        Me.Comment.Text = Nothing
        Me.Comment.ZButtonText = " Ê÷ÌÕ« "
        Me.Comment.ZCommentFormheight = 0
        Me.Comment.ZCommentFormWidth = 0
        Me.Comment.ZEnabled = True
        Me.Comment.ZLanguage = UCCommentButton.Language.Persian
        Me.Comment.ZMaxCommentLength = 0
        Me.Comment.ZShowInLeft = False
        Me.Comment.ZShowInTop = False
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(208, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 16)
        Me.Label17.TabIndex = 439
        Me.Label17.Text = "òœ ê—ÊÂ —‘ Â  Õ’Ì·Ì"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 440
        Me.Label1.Text = "‘—Õ ê—ÊÂ —‘ Â  Õ’Ì·Ì"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 441
        Me.Label2.Text = "—” Â"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PnlText
        '
        Me.PnlText.Controls.Add(Me.LblCodGroup)
        Me.PnlText.Controls.Add(Me.TxtDescGroup)
        Me.PnlText.Controls.Add(Me.CmbRasteh)
        Me.PnlText.Controls.Add(Me.Label2)
        Me.PnlText.Controls.Add(Me.Label1)
        Me.PnlText.Controls.Add(Me.Label17)
        Me.PnlText.Controls.Add(Me.Comment)
        Me.PnlText.Location = New System.Drawing.Point(360, 241)
        Me.PnlText.Name = "PnlText"
        Me.PnlText.Size = New System.Drawing.Size(344, 138)
        Me.PnlText.TabIndex = 442
        Me.PnlText.TabStop = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT code_group_reshteh_tahsili, desc_group_reshteh_tahsili, code_rasteh, remar" & _
        "k, code_bandar, code_markaz FROM tas_bas_group_reshteh_tahsili"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=MILAD;packet size=4096;integrated security=SSPI;data source=milad;" & _
        "persist security info=False;initial catalog=banader_01"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO tas_bas_group_reshteh_tahsili (desc_group_reshteh_tahsili, code_raste" & _
        "h, remark, code_bandar, code_markaz) VALUES (@desc_group_reshteh_tahsili, @code_" & _
        "rasteh, @remark, @code_bandar, @code_markaz)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_group_reshteh_tahsili", System.Data.SqlDbType.VarChar, 50, "desc_group_reshteh_tahsili"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_rasteh", System.Data.SqlDbType.SmallInt, 2, "code_rasteh"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_bandar", System.Data.SqlDbType.VarChar, 2, "code_bandar"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_markaz", System.Data.SqlDbType.SmallInt, 2, "code_markaz"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE tas_bas_group_reshteh_tahsili SET desc_group_reshteh_tahsili = @desc_group" & _
        "_reshteh_tahsili, code_rasteh = @code_rasteh, remark = @remark, code_bandar = @c" & _
        "ode_bandar, code_markaz = @code_markaz WHERE (code_group_reshteh_tahsili = @code" & _
        "_group_reshteh_tahsili)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_group_reshteh_tahsili", System.Data.SqlDbType.VarChar, 50, "desc_group_reshteh_tahsili"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_rasteh", System.Data.SqlDbType.SmallInt, 2, "code_rasteh"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_bandar", System.Data.SqlDbType.VarChar, 2, "code_bandar"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_markaz", System.Data.SqlDbType.SmallInt, 2, "code_markaz"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_group_reshteh_tahsili", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_group_reshteh_tahsili", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM tas_bas_group_reshteh_tahsili WHERE (code_group_reshteh_tahsili = @co" & _
        "de_group_reshteh_tahsili)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_group_reshteh_tahsili", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_group_reshteh_tahsili", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAtas_bas_group_reshteh_tahsili
        '
        Me.DAtas_bas_group_reshteh_tahsili.DeleteCommand = Me.SqlDeleteCommand1
        Me.DAtas_bas_group_reshteh_tahsili.InsertCommand = Me.SqlInsertCommand1
        Me.DAtas_bas_group_reshteh_tahsili.SelectCommand = Me.SqlSelectCommand1
        Me.DAtas_bas_group_reshteh_tahsili.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tas_bas_group_reshteh_tahsili", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("code_group_reshteh_tahsili", "code_group_reshteh_tahsili"), New System.Data.Common.DataColumnMapping("desc_group_reshteh_tahsili", "desc_group_reshteh_tahsili"), New System.Data.Common.DataColumnMapping("code_rasteh", "code_rasteh"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("code_bandar", "code_bandar"), New System.Data.Common.DataColumnMapping("code_markaz", "code_markaz")})})
        Me.DAtas_bas_group_reshteh_tahsili.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT tas_tr_groupreshtehtahsili_reshtehtahsili.code_group_reshteh_tahsili, tas_" & _
        "tr_groupreshtehtahsili_reshtehtahsili.code_reshteh_tahsili, tas_tr_groupreshteht" & _
        "ahsili_reshtehtahsili.code_bandar, tas_tr_groupreshtehtahsili_reshtehtahsili.cod" & _
        "e_markaz, tas_bas_reshteh_tahsili.desc_reshteh_tahsili FROM tas_tr_groupreshteht" & _
        "ahsili_reshtehtahsili INNER JOIN tas_bas_reshteh_tahsili ON tas_tr_groupreshteht" & _
        "ahsili_reshtehtahsili.code_reshteh_tahsili = tas_bas_reshteh_tahsili.code_reshte" & _
        "h_tahsili"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO tas_tr_groupreshtehtahsili_reshtehtahsili(code_group_reshteh_tahsili," & _
        " code_reshteh_tahsili, code_bandar, code_markaz) VALUES (@code_group_reshteh_tah" & _
        "sili, @code_reshteh_tahsili, @code_bandar, @code_markaz); SELECT code_group_resh" & _
        "teh_tahsili, code_reshteh_tahsili, code_bandar, code_markaz FROM tas_tr_groupres" & _
        "htehtahsili_reshtehtahsili WHERE (code_group_reshteh_tahsili = @code_group_resht" & _
        "eh_tahsili) AND (code_reshteh_tahsili = @code_reshteh_tahsili)"
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_group_reshteh_tahsili", System.Data.SqlDbType.SmallInt, 2, "code_group_reshteh_tahsili"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_reshteh_tahsili", System.Data.SqlDbType.SmallInt, 2, "code_reshteh_tahsili"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_bandar", System.Data.SqlDbType.VarChar, 2, "code_bandar"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_markaz", System.Data.SqlDbType.SmallInt, 2, "code_markaz"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE tas_tr_groupreshtehtahsili_reshtehtahsili SET code_group_reshteh_tahsili =" & _
        " @code_group_reshteh_tahsili, code_reshteh_tahsili = @code_reshteh_tahsili, code" & _
        "_bandar = @code_bandar, code_markaz = @code_markaz WHERE (code_group_reshteh_tah" & _
        "sili = @Original_code_group_reshteh_tahsili) AND (code_reshteh_tahsili = @Origin" & _
        "al_code_reshteh_tahsili) AND (code_bandar = @Original_code_bandar) AND (code_mar" & _
        "kaz = @Original_code_markaz OR @Original_code_markaz IS NULL AND code_markaz IS " & _
        "NULL); SELECT code_group_reshteh_tahsili, code_reshteh_tahsili, code_bandar, cod" & _
        "e_markaz FROM tas_tr_groupreshtehtahsili_reshtehtahsili WHERE (code_group_reshte" & _
        "h_tahsili = @code_group_reshteh_tahsili) AND (code_reshteh_tahsili = @code_resht" & _
        "eh_tahsili)"
        Me.SqlUpdateCommand2.Connection = Me.Cnn
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_group_reshteh_tahsili", System.Data.SqlDbType.SmallInt, 2, "code_group_reshteh_tahsili"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_reshteh_tahsili", System.Data.SqlDbType.SmallInt, 2, "code_reshteh_tahsili"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_bandar", System.Data.SqlDbType.VarChar, 2, "code_bandar"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_markaz", System.Data.SqlDbType.SmallInt, 2, "code_markaz"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_group_reshteh_tahsili", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_group_reshteh_tahsili", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_reshteh_tahsili", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_reshteh_tahsili", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_bandar", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_bandar", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_markaz", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_markaz", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM tas_tr_groupreshtehtahsili_reshtehtahsili WHERE (code_group_reshteh_t" & _
        "ahsili = @code_group_reshteh_tahsili) AND (code_reshteh_tahsili = @code_reshteh_" & _
        "tahsili)"
        Me.SqlDeleteCommand2.Connection = Me.Cnn
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_group_reshteh_tahsili", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_group_reshteh_tahsili", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_reshteh_tahsili", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_reshteh_tahsili", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAtas_tr_groupreshtehtahsili_reshtehtahsili
        '
        Me.DAtas_tr_groupreshtehtahsili_reshtehtahsili.DeleteCommand = Me.SqlDeleteCommand2
        Me.DAtas_tr_groupreshtehtahsili_reshtehtahsili.InsertCommand = Me.SqlInsertCommand2
        Me.DAtas_tr_groupreshtehtahsili_reshtehtahsili.SelectCommand = Me.SqlSelectCommand2
        Me.DAtas_tr_groupreshtehtahsili_reshtehtahsili.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tas_tr_groupreshtehtahsili_reshtehtahsili", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("code_group_reshteh_tahsili", "code_group_reshteh_tahsili"), New System.Data.Common.DataColumnMapping("code_reshteh_tahsili", "code_reshteh_tahsili"), New System.Data.Common.DataColumnMapping("code_bandar", "code_bandar"), New System.Data.Common.DataColumnMapping("code_markaz", "code_markaz")})})
        Me.DAtas_tr_groupreshtehtahsili_reshtehtahsili.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT code_rasteh, desc_rasteh FROM tas_bas_rasteh"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO tas_bas_rasteh(desc_rasteh) VALUES (@desc_rasteh); SELECT code_rasteh" & _
        ", desc_rasteh FROM tas_bas_rasteh WHERE (code_rasteh = @@IDENTITY)"
        Me.SqlInsertCommand3.Connection = Me.Cnn
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_rasteh", System.Data.SqlDbType.VarChar, 50, "desc_rasteh"))
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE tas_bas_rasteh SET desc_rasteh = @desc_rasteh WHERE (code_rasteh = @Origin" & _
        "al_code_rasteh) AND (desc_rasteh = @Original_desc_rasteh); SELECT code_rasteh, d" & _
        "esc_rasteh FROM tas_bas_rasteh WHERE (code_rasteh = @code_rasteh)"
        Me.SqlUpdateCommand3.Connection = Me.Cnn
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_rasteh", System.Data.SqlDbType.VarChar, 50, "desc_rasteh"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_rasteh", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_rasteh", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_rasteh", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_rasteh", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@code_rasteh", System.Data.SqlDbType.SmallInt, 2, "code_rasteh"))
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM tas_bas_rasteh WHERE (code_rasteh = @Original_code_rasteh) AND (desc_" & _
        "rasteh = @Original_desc_rasteh)"
        Me.SqlDeleteCommand3.Connection = Me.Cnn
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_code_rasteh", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "code_rasteh", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_rasteh", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_rasteh", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAtas_bas_rasteh
        '
        Me.DAtas_bas_rasteh.DeleteCommand = Me.SqlDeleteCommand3
        Me.DAtas_bas_rasteh.InsertCommand = Me.SqlInsertCommand3
        Me.DAtas_bas_rasteh.SelectCommand = Me.SqlSelectCommand3
        Me.DAtas_bas_rasteh.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tas_bas_rasteh", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("code_rasteh", "code_rasteh"), New System.Data.Common.DataColumnMapping("desc_rasteh", "desc_rasteh")})})
        Me.DAtas_bas_rasteh.UpdateCommand = Me.SqlUpdateCommand3
        '
        'PnlButton
        '
        Me.PnlButton.Controls.Add(Me.Label4)
        Me.PnlButton.Controls.Add(Me.Label3)
        Me.PnlButton.Controls.Add(Me.CmdCancel)
        Me.PnlButton.Controls.Add(Me.CmdSave)
        Me.PnlButton.Location = New System.Drawing.Point(368, 388)
        Me.PnlButton.Name = "PnlButton"
        Me.PnlButton.Size = New System.Drawing.Size(96, 51)
        Me.PnlButton.TabIndex = 446
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 16)
        Me.Label4.TabIndex = 450
        Me.Label4.Text = "·€Ê"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 449
        Me.Label3.Text = "À» "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdCancel
        '
        Me.CmdCancel.Image = CType(resources.GetObject("CmdCancel.Image"), System.Drawing.Image)
        Me.CmdCancel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.CmdCancel.Location = New System.Drawing.Point(64, 1)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(32, 26)
        Me.CmdCancel.TabIndex = 447
        '
        'CmdSave
        '
        Me.CmdSave.BackgroundImage = CType(resources.GetObject("CmdSave.BackgroundImage"), System.Drawing.Image)
        Me.CmdSave.Image = CType(resources.GetObject("CmdSave.Image"), System.Drawing.Image)
        Me.CmdSave.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center
        Me.CmdSave.Location = New System.Drawing.Point(24, 1)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.Size = New System.Drawing.Size(32, 26)
        Me.CmdSave.TabIndex = 448
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT code_reshteh_tahsili, desc_reshteh_tahsili FROM tas_bas_reshteh_tahsili"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'DAtas_bas_reshteh_tahsili
        '
        Me.DAtas_bas_reshteh_tahsili.SelectCommand = Me.SqlSelectCommand4
        Me.DAtas_bas_reshteh_tahsili.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tas_bas_reshteh_tahsili", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("code_reshteh_tahsili", "code_reshteh_tahsili"), New System.Data.Common.DataColumnMapping("desc_reshteh_tahsili", "desc_reshteh_tahsili")})})
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(472, 422)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 453
        Me.Label5.Text = "Ã” ÃÊ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdFind
        '
        Me.CmdFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdFind.Image = CType(resources.GetObject("CmdFind.Image"), System.Drawing.Image)
        Me.CmdFind.Location = New System.Drawing.Point(472, 388)
        Me.CmdFind.Name = "CmdFind"
        Me.CmdFind.Size = New System.Drawing.Size(32, 26)
        Me.CmdFind.TabIndex = 452
        '
        'FrmReshteTahsili
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(702, 452)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CmdFind)
        Me.Controls.Add(Me.PnlButton)
        Me.Controls.Add(Me.PnlText)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.TreeReshteh)
        Me.Name = "FrmReshteTahsili"
        Me.Text = "ê—ÊÂÂ«Ì —‘ Â Â«Ì  Õ’Ì·Ì"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmReshteTahsili1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlText.ResumeLayout(False)
        Me.PnlButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim IdReshte As String
    Dim IdGroupReshte As String
    Dim FormStatus As status
    Dim ThisSelectdedNode As TreeNode
    Enum status
        AddGroupReshte = 1
        EditGroupReshte = 2
        AddReshte = 3
        cancel = 4
    End Enum
    Private Sub FrmReshteTahsili_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString


        DAtas_bas_rasteh.Fill(DsFrmReshteTahsili1.tas_bas_rasteh)
        DAtas_bas_reshteh_tahsili.Fill(DsFrmReshteTahsili1.tas_bas_reshteh_tahsili)
        FormStatus = status.cancel

        Call MakeTree1()
        Call MakeTree2()
        Call EnableDisable(1)

    End Sub
    Private Sub FillGroupReshte()

        DsFrmReshteTahsili1.tas_bas_group_reshteh_tahsili.Clear()

        DAtas_bas_group_reshteh_tahsili.Fill(DsFrmReshteTahsili1.tas_bas_group_reshteh_tahsili)

    End Sub
    Private Sub FillReshte()
        DsFrmReshteTahsili1.tas_tr_groupreshtehtahsili_reshtehtahsili.Clear()
        DAtas_tr_groupreshtehtahsili_reshtehtahsili.Fill(DsFrmReshteTahsili1.tas_tr_groupreshtehtahsili_reshtehtahsili)
    End Sub
    Private Sub MakeTree1()
        TreeReshteh.Nodes.Clear()
        Dim NewNodeva As TreeNode
        NewNodeva = TreeReshteh.Nodes.Add("ê—ÊÂÂ«Ì —‘ Â Â«Ì  Õ’Ì·Ì")
        NewNodeva.Tag = 0

        Call FillGroupReshte()
        For i As Integer = 0 To DsFrmReshteTahsili1.tas_bas_group_reshteh_tahsili.Count - 1
            Dim NewNodevar As TreeNode
            NewNodevar = TreeReshteh.Nodes(0).Nodes.Add(DsFrmReshteTahsili1.tas_bas_group_reshteh_tahsili(i).desc_group_reshteh_tahsili)
            NewNodevar.Tag = DsFrmReshteTahsili1.tas_bas_group_reshteh_tahsili(i).code_group_reshteh_tahsili  'DsFrmNermoodarSazmani1.tas_bas_vahed(i).id_vahed

        Next

    End Sub
    Private Sub MakeTree2()
        Call FillReshte()

        'Dim ONODES As TreeNode
        For i As Integer = 0 To DsFrmReshteTahsili1.tas_tr_groupreshtehtahsili_reshtehtahsili.Count - 1
            'For j As Integer = 1 To DsFrmReshteTahsili1.tas_tr_groupreshtehtahsili_reshtehtahsili.Count - 1

            '    NodTag = TreeReshteh.Nodes(j).Tag
            '    If (NodTag = DsFrmReshteTahsili1.tas_tr_groupreshtehtahsili_reshtehtahsili(i).code_group_reshteh_tahsili) Then
            '        NodIndex = j
            '        Exit For
            '    End If
            'Next
            Dim NewNodevar As TreeNode
            NewNodevar = RecursiveFind(TreeReshteh.Nodes(0), DsFrmReshteTahsili1.tas_tr_groupreshtehtahsili_reshtehtahsili(i).code_group_reshteh_tahsili).Nodes.Add(DsFrmReshteTahsili1.tas_tr_groupreshtehtahsili_reshtehtahsili(i).desc_reshteh_tahsili)
            NewNodevar.Tag = DsFrmReshteTahsili1.tas_tr_groupreshtehtahsili_reshtehtahsili(i).code_reshteh_tahsili   'DsFrmNermoodarSazmani1.tas_bas_vahed(i).id_vahed

        Next
    End Sub

    Private Sub SelectThisNodeId(ByVal ThisId As Decimal)
        If Not ThisSelectdedNode Is Nothing Then
            ThisSelectdedNode.BackColor = TreeReshteh.BackColor
        End If
        ThisSelectdedNode = RecursiveFind(TreeReshteh.Nodes(0), ThisId)
        If Not ThisSelectdedNode Is Nothing Then
            ThisSelectdedNode.BackColor = Color.LightBlue
            TreeReshteh.SelectedNode = ThisSelectdedNode
        End If
    End Sub

    Private Function RecursiveFind(ByVal ThisNode As TreeNode, ByVal ThisId As Decimal) As TreeNode
        Dim i As Decimal
        ' RecursiveFind = AttachmentTreeView.Nodes(0)
        For i = 0 To ThisNode.GetNodeCount(False) - 1 '   Travels all childs
            'MsgBox(ThisNode.Nodes.Item(i).Text)
            If ThisNode.Nodes.Item(i).Tag = ThisId Then
                RecursiveFind = ThisNode.Nodes.Item(i)
                Exit For
            Else
                'RecursiveFind = RecursiveFind(ThisNode.Nodes.Item(i), ThisId)
                'If Not IsNothing(RecursiveFind) Then
                '    Exit For
                'End If
            End If
        Next
    End Function

    Private Sub TreeReshteh_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeReshteh.AfterSelect
        If TreeReshteh.SelectedNode.Parent Is Nothing Then
            MnEdit.Visible = False
            MnAddNew.Visible = True
            MnDelet.Visible = False
        Else
            If TreeReshteh.SelectedNode.Parent.Tag = 0 Then
                MnDelet.Visible = True
                MnEdit.Visible = True
                MnAddNew.Visible = True
                IdGroupReshte = TreeReshteh.SelectedNode.Tag
                IdReshte = ""
                Call FillField()
            Else
                MnDelet.Visible = True
                MnEdit.Visible = False
                MnAddNew.Visible = False
                IdGroupReshte = TreeReshteh.SelectedNode.Parent.Tag
                IdReshte = TreeReshteh.SelectedNode.Tag
                Call FillField()
            End If
        End If

    End Sub
    Private Sub FillField()
        Dim dr() As DataRow
        dr = DsFrmReshteTahsili1.tas_bas_group_reshteh_tahsili.Select(" code_group_reshteh_tahsili = " & IdGroupReshte)
        LblCodGroup.Text = dr(0).Item("code_group_reshteh_tahsili") & ""
        TxtDescGroup.Text = dr(0).Item("desc_group_reshteh_tahsili") & ""
        Comment.Text = dr(0).Item("remark") & ""
        CmbRasteh.SelectedValue = dr(0).Item("code_rasteh")

    End Sub
    Private Sub ClearField()
        LblCodGroup.Text = ""
        TxtDescGroup.Text = ""
        Comment.Text = ""
    End Sub
    Private Sub EnableDisable(ByVal kind As Byte)
        Select Case kind
            Case 1 ''formload
                TreeReshteh.Enabled = True
                GridEX1.Enabled = False
                PnlText.Enabled = False
                PnlButton.Enabled = False
            Case 2 ''add/update Groupreshte
                TreeReshteh.Enabled = False
                PnlText.Enabled = True
                PnlButton.Enabled = True
            Case 3 ''cancel GroupReshte
                TreeReshteh.Enabled = True
                PnlText.Enabled = False
                PnlButton.Enabled = False

            Case 4 '' add reshte
                TreeReshteh.Enabled = False
                GridEX1.Enabled = True
            Case 5   ''cancel reshte
                TreeReshteh.Enabled = True
                GridEX1.Enabled = False



        End Select
    End Sub
    Private Function ControlEmptyField()

        ControlEmptyField = True
        If TxtDescGroup.Text.Trim.Length = 0 And CmbRasteh.Text = "" Then
            MsgFar("«» œ« «ÿ·«⁄«  ·«“„ —« Ê«—œ ò‰Ìœ")
            ControlEmptyField = False
            Exit Function
        End If
    End Function

    Private Sub AddGroupReshte()
        Call ClearField()
        Call EnableDisable(2)
        FormStatus = status.AddGroupReshte
    End Sub
    Private Sub EditGroupReshteh()

        Call EnableDisable(2)
        FormStatus = status.EditGroupReshte
    End Sub
    Private Sub DeletGroupReshteh()


        Dim c1 As New FrmWhatDoForMenu
        c1.ShowFarMsg("¬Ì« «Ì‰ —òÊ—œ Õ–› ‘Êœø")
        If c1.DialogResult = DialogResult.OK Then
            If DAtas_bas_group_reshteh_tahsili.DeleteCommand.Connection.State <> ConnectionState.Open Then
                DAtas_bas_group_reshteh_tahsili.DeleteCommand.Connection.Open()
            End If
            With DAtas_bas_group_reshteh_tahsili.DeleteCommand
                .Parameters("@code_group_reshteh_tahsili").Value = IdGroupReshte

                Try
                    .ExecuteNonQuery()
                    RecursiveFind(TreeReshteh.Nodes(0), IdGroupReshte).Remove()
                    DAtas_bas_group_reshteh_tahsili.DeleteCommand.Connection.Close()
                Catch ex As Exception
                    MsgFar("«„ò«‰ Õ–› «Ì‰ ‘«ŒÂ ÊÃÊœ ‰œ«—œ")
                End Try
                DAtas_bas_group_reshteh_tahsili.DeleteCommand.Connection.Close()
            End With
        End If
    End Sub
    Private Sub AddReshte()

        Call EnableDisable(4)

    End Sub
    Private Sub DeletReshte()
        Dim c1 As New FrmWhatDoForMenu
        c1.ShowFarMsg("¬Ì« «Ì‰ —òÊ—œ Õ–› ‘Êœø")
        If c1.DialogResult = DialogResult.OK Then
            If DAtas_tr_groupreshtehtahsili_reshtehtahsili.DeleteCommand.Connection.State <> ConnectionState.Open Then
                DAtas_tr_groupreshtehtahsili_reshtehtahsili.DeleteCommand.Connection.Open()
            End If
            With DAtas_tr_groupreshtehtahsili_reshtehtahsili.DeleteCommand
                .Parameters("@code_group_reshteh_tahsili").Value = IdGroupReshte
                .Parameters("@code_reshteh_tahsili").Value = IdReshte

                Try
                    .ExecuteNonQuery()
                    RecursiveFind(RecursiveFind(TreeReshteh.Nodes(0), IdGroupReshte), IdReshte).Remove()
                    DAtas_bas_group_reshteh_tahsili.DeleteCommand.Connection.Close()
                Catch ex As Exception
                    MsgFar("«„ò«‰ Õ–› «Ì‰ ‘«ŒÂ ÊÃÊœ ‰œ«—œ")
                End Try
            End With
        End If
    End Sub
    Private Sub PSave()
        Select Case FormStatus
            Case status.AddGroupReshte
                If Not ControlEmptyField() Then
                    Exit Sub
                End If
                If DAtas_bas_group_reshteh_tahsili.InsertCommand.Connection.State <> ConnectionState.Open Then
                    DAtas_bas_group_reshteh_tahsili.InsertCommand.Connection.Open()
                End If
                With DAtas_bas_group_reshteh_tahsili.InsertCommand

                    .Parameters("@desc_group_reshteh_tahsili").Value = TxtDescGroup.Text
                    .Parameters("@code_rasteh").Value = CmbRasteh.SelectedValue
                    .Parameters("@remark").Value = Comment.Text
                    .Parameters("@code_bandar").Value = PubBandarNO
                    .Parameters("@code_markaz").Value = System.DBNull.Value

                    Try
                        .ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    .Connection.Close()
                End With
                FormStatus = status.cancel
                Call MakeTree1()
                Call MakeTree2()
                TreeReshteh.ExpandAll()
            Case status.EditGroupReshte
                If Not ControlEmptyField() Then
                    Exit Sub
                End If
                If DAtas_bas_group_reshteh_tahsili.UpdateCommand.Connection.State <> ConnectionState.Open Then
                    DAtas_bas_group_reshteh_tahsili.UpdateCommand.Connection.Open()
                End If
                With DAtas_bas_group_reshteh_tahsili.UpdateCommand
                    .Parameters("@code_group_reshteh_tahsili").Value = IdGroupReshte
                    .Parameters("@desc_group_reshteh_tahsili").Value = TxtDescGroup.Text
                    .Parameters("@code_rasteh").Value = CmbRasteh.SelectedValue
                    .Parameters("@remark").Value = Comment.Text
                    .Parameters("@code_bandar").Value = PubBandarNO
                    .Parameters("@code_markaz").Value = System.DBNull.Value

                    Try
                        .ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    .Connection.Close()
                End With
                FormStatus = status.cancel
                Call MakeTree1()
                Call MakeTree2()
                Call SelectThisNodeId(IdGroupReshte)
        End Select
    End Sub

    Private Sub MnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnAddNew.Click
        If TreeReshteh.SelectedNode.Parent Is Nothing Then
            Call AddGroupReshte()
        Else
            If TreeReshteh.SelectedNode.Parent.Tag = 0 Then
                Call AddReshte()
            Else

            End If
        End If

    End Sub

    Private Sub MnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnEdit.Click
        Call EditGroupReshteh()
    End Sub

    Private Sub MnDelet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnDelet.Click
        If TreeReshteh.SelectedNode.Parent Is Nothing Then

        Else
            If TreeReshteh.SelectedNode.Parent.Tag = 0 Then
                Call DeletGroupReshteh()
            Else
                Call DeletReshte()
            End If
        End If

    End Sub


    Private Sub GridEX1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEX1.DoubleClick
        Dim Currentrow As GridEXRow = GridEX1.GetRow
        If Currentrow.RowIndex < 0 Then
        Else

            If DAtas_tr_groupreshtehtahsili_reshtehtahsili.InsertCommand.Connection.State <> ConnectionState.Open Then
                DAtas_tr_groupreshtehtahsili_reshtehtahsili.InsertCommand.Connection.Open()
            End If
            With DAtas_tr_groupreshtehtahsili_reshtehtahsili.InsertCommand
                .Parameters("@code_group_reshteh_tahsili").Value = IdGroupReshte
                .Parameters("@code_reshteh_tahsili").Value = Currentrow.Cells("code_reshteh_tahsili").Value
                .Parameters("@code_bandar").Value = "66"
                .Parameters("@code_markaz").Value = System.DBNull.Value
                Try
                    .ExecuteNonQuery()
                    Dim NewNodevar As TreeNode
                    NewNodevar = RecursiveFind(TreeReshteh.Nodes(0), IdGroupReshte).Nodes.Add(Currentrow.Cells("desc_reshteh_tahsili").Value)
                    NewNodevar.Tag = Currentrow.Cells("code_reshteh_tahsili").Value
                    .Connection.Close()
                Catch ex As Exception
                    'If ex.Message = "Violation of PRIMARY KEY constraint 'PK_tas_tr_groupshoghli_reshtehshoghli'. Cannot insert duplicate key in object 'tas_tr_groupreshtehtahsili_reshtehtahsili'.The statement has been terminated." Then
                    MsgFar("«Ì‰ —‘ Â ﬁ»·« «‰ Œ«» ‘œÂ «” ")

                    .Connection.Close()
                End Try
                Call EnableDisable(5)


            End With


        End If

    End Sub

    Private Sub CmdSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSave.Click
        Call PSave()
        Call EnableDisable(3)

    End Sub

    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        Call EnableDisable(3)
        FormStatus = status.cancel

    End Sub


    Private Sub CmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdFind.Click
        Dim f As New FrmFind
        Dim dr() As DataRow
        f.KindForm = FrmFind.KindFind.FindGroupReshte
        f.ShowDialog()
        If f.Id <> "x" Then
            dr = DsFrmReshteTahsili1.tas_bas_group_reshteh_tahsili.Select("code_group_reshteh_tahsili = " & f.Id)
            If dr.Length > 0 Then
                LblCodGroup.Text = dr(0).Item("code_group_reshteh_tahsili") & ""
                TxtDescGroup.Text = dr(0).Item("desc_group_reshteh_tahsili") & ""
                CmbRasteh.SelectedValue = dr(0).Item("code_rasteh") & ""
                Comment.Text = dr(0).Item("remark") & ""
                FormStatus = status.cancel
                Call SelectThisNodeId(f.Id)
                Call EnableDisable(3)
            End If
        End If

    End Sub
End Class
