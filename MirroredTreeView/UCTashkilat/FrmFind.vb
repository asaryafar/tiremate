Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmFind
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents UiButton1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAGeneral As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmFind1 As UCTashkilat.DSFrmFind
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.UiButton1 = New Janus.Windows.EditControls.UIButton
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmFind1 = New UCTashkilat.DSFrmFind
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAGeneral = New System.Data.SqlClient.SqlDataAdapter
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmFind1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiButton1
        '
        Me.UiButton1.Location = New System.Drawing.Point(64, 280)
        Me.UiButton1.Name = "UiButton1"
        Me.UiButton1.Size = New System.Drawing.Size(88, 23)
        Me.UiButton1.TabIndex = 0
        Me.UiButton1.Text = "Ã” ÃÊ"
        '
        'GridEX1
        '
        Me.GridEX1.DataMember = "kar_personal"
        Me.GridEX1.DataSource = Me.DsFrmFind1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""code""><Capti" & _
        "on>òœ</Caption><DataMember>code</DataMember><EditType>NoEdit</EditType><Key>code" & _
        "</Key><Position>0</Position><Width>73</Width></Column0><Column1 ID=""descript""><C" & _
        "aption>‘—Õ</Caption><DataMember>descript</DataMember><EditType>NoEdit</EditType>" & _
        "<Key>descript</Key><Position>1</Position><Width>205</Width></Column1><Column2 ID" & _
        "=""one""><Caption>one</Caption><DataMember>one</DataMember><EditType>NoEdit</EditT" & _
        "ype><FilterEditType>TextBox</FilterEditType><Key>one</Key><Position>2</Position>" & _
        "</Column2><Column3 ID=""two""><Caption>two</Caption><DataMember>two</DataMember><E" & _
        "ditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>two</Key><" & _
        "Position>3</Position><Width>86</Width></Column3><Column4 ID=""three""><Caption>thr" & _
        "ee</Caption><DataMember>three</DataMember><EditType>NoEdit</EditType><Key>three<" & _
        "/Key><Position>4</Position></Column4><Column5 ID=""four""><Caption>four</Caption><" & _
        "DataMember>four</DataMember><Key>four</Key><Position>5</Position><Visible>False<" & _
        "/Visible></Column5><Column6 ID=""five""><Caption>five</Caption><DataMember>five</D" & _
        "ataMember><Key>five</Key><Position>6</Position><Visible>False</Visible></Column6" & _
        "></Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GridEX1.Location = New System.Drawing.Point(0, 0)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GridEX1.Size = New System.Drawing.Size(608, 272)
        Me.GridEX1.TabIndex = 1
        '
        'DsFrmFind1
        '
        Me.DsFrmFind1.DataSetName = "DSFrmFind"
        Me.DsFrmFind1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT DISTINCT tas_tr_groupreshtehtahsili_reshtehtahsili.code_group_reshteh_tahs" & _
        "ili AS code, tas_bas_group_reshteh_tahsili.desc_group_reshteh_tahsili AS descrip" & _
        "t, tas_bas_group_reshteh_tahsili.remark AS one FROM tas_tr_groupreshtehtahsili_r" & _
        "eshtehtahsili INNER JOIN tas_bas_group_reshteh_tahsili ON tas_tr_groupreshtehtah" & _
        "sili_reshtehtahsili.code_group_reshteh_tahsili = tas_bas_group_reshteh_tahsili.c" & _
        "ode_group_reshteh_tahsili"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=MILAD;packet size=4096;integrated security=SSPI;data source=milad;" & _
        "persist security info=False;initial catalog=banader_01"
        '
        'DAGeneral
        '
        Me.DAGeneral.SelectCommand = Me.SqlSelectCommand1
        Me.DAGeneral.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "kar_personal", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("code_personal", "code_personal"), New System.Data.Common.DataColumnMapping("codmelli", "codmelli")})})
        '
        'FrmFind
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(608, 310)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.UiButton1)
        Me.Name = "FrmFind"
        Me.Text = "FrmFind"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmFind1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Id As String = "x"
    Public IdPost As String = "x"
    Public IdPerson As String = "x"
    Public KindForm As KindFind
    Enum KindFind
        FindPerson = 1
        FindVahed = 2
        FindPost = 3
        FindGroupReshte = 4
        FindReshteShoghli = 5
        FindReshteTahsili = 6
        FindGroupReshteTahsili = 7
    End Enum


    Private Sub FrmFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        Call FillGrid()


    End Sub

    Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton1.Click
        Dim Currentrow As GridEXRow = GridEX1.GetRow
        If Currentrow.RowIndex < 0 Then
            MsgFar("—œÌ› „Ê—œ ‰Ÿ— —« «‰ Œ«» ò‰Ìœ")
        Else
            'IdShoghlArray(i) = String
            Id = Currentrow.Cells("code").Value
            Me.Close()
        End If
    End Sub
    Private Sub FillGrid()
        Select Case KindForm
            Case KindFind.FindVahed
                Me.Text = "Ã” ÃÊÌ Ê«Õœ"
                DAGeneral.SelectCommand.CommandText = "SELECT     tas_bas_vahed.id_vahed AS code, tas_bas_vahed.desc_vahed AS descript, tas_bas_tashkilat.desc_tashkilat AS one, " & _
                        " tas_bas_radeh_sazemani.desc_radeh_sazemani AS two, tas_bas_vahed.mahal_vahed AS three " & _
                        " FROM         tas_bas_vahed INNER JOIN " & _
                        " tas_bas_tashkilat ON tas_bas_vahed.code_tashkilat = tas_bas_tashkilat.code_tashkilat INNER JOIN " & _
                        " tas_bas_radeh_sazemani ON tas_bas_vahed.code_radeh_sazemani = tas_bas_radeh_sazemani.code_radeh_sazemani "

            Case KindFind.Findpost
                Me.Text = "Ã” ÃÊÌ Å” Â«Ì ”«“„«‰Ì"
                DAGeneral.SelectCommand.CommandText = "SELECT     tas_tr_vahedha_mashaghel.code_post_sazemani as code, tas_tr_vahedha_mashaghel.desc_post_sazemani as descript, tas_bas_vahed.desc_vahed AS one, " & _
                      " tas_bas_reshteh_shoghli.desc_reshteh_shoghli as two , tas_tr_vahedha_mashaghel.somareh_post_sazemani as three, tas_bas_vahed.id_vahed AS four,'0' as five " & _
                      " FROM         tas_bas_vahed INNER JOIN " & _
                      " tas_tr_vahedha_mashaghel ON tas_bas_vahed.id_vahed = tas_tr_vahedha_mashaghel.id_vahed INNER JOIN " & _
                      " tas_bas_reshteh_shoghli ON tas_tr_vahedha_mashaghel.code_reshteh_shoghli = tas_bas_reshteh_shoghli.code_reshteh_shoghli "

            Case KindFind.FindPerson
                Me.Text = "Ã” ÃÊÌ Å—”‰·"
                DAGeneral.SelectCommand.CommandText = "SELECT     kar_personal.code_personal AS code, kar_personal.fname AS descript, kar_personal.lname AS one, kar_personal.father_name AS two, " & _
                      " tas_bas_vahed.desc_vahed AS three, tas_bas_vahed.id_vahed AS four, tas_tr_takhsis_postsazemani.code_post_sazemani AS five " & _
                      " FROM         tas_bas_vahed INNER JOIN " & _
                      " tas_tr_vahedha_mashaghel ON tas_bas_vahed.id_vahed = tas_tr_vahedha_mashaghel.id_vahed INNER JOIN " & _
                      " tas_tr_takhsis_postsazemani ON  " & _
                      " tas_tr_vahedha_mashaghel.code_post_sazemani = tas_tr_takhsis_postsazemani.code_post_sazemani RIGHT OUTER JOIN " & _
                      " kar_personal ON tas_tr_takhsis_postsazemani.code_personal_takhsis = kar_personal.code_personal " & _
                      " WHERE     (tas_tr_takhsis_postsazemani.activate = 1) "
            Case KindFind.FindGroupReshte
                Me.Text = "Ã” ÃÊÌ ê—ÊÂ —‘ Â Â«Ì  Õ’Ì·Ì"
                DAGeneral.SelectCommand.CommandText = "SELECT     tas_bas_group_reshteh_tahsili.code_group_reshteh_tahsili AS code, tas_bas_group_reshteh_tahsili.desc_group_reshteh_tahsili AS descript, " & _
                      " tas_bas_group_reshteh_tahsili.code_rasteh AS one , tas_bas_rasteh.desc_rasteh as two" & _
                      " FROM         tas_bas_group_reshteh_tahsili INNER JOIN " & _
                      " tas_bas_rasteh ON tas_bas_group_reshteh_tahsili.code_rasteh = tas_bas_rasteh.code_rasteh "
            Case KindFind.FindReshteShoghli
                Me.Text = "Ã” ÃÊÌ —‘ Â ‘€·Ì"
                DAGeneral.SelectCommand.CommandText = "SELECT     code_reshteh_shoghli AS code, desc_reshteh_shoghli AS descript, sharh_vazaef AS one " & _
                      " FROM tas_bas_reshteh_shoghli "
            Case KindFind.FindReshteTahsili
                Me.Text = "Ã” ÃÊÌ —‘ Â  Õ’Ì·Ì"
                DAGeneral.SelectCommand.CommandText = "SELECT     code_reshteh_tahsili AS code, desc_reshteh_tahsili AS descript, remark AS one " & _
                      " FROM tas_bas_reshteh_tahsili "
            Case KindFind.FindGroupReshteTahsili
                Me.Text = "Ã” ÃÊÌ ê—ÊÂ —‘ Â  Õ’Ì·Ì"
                DAGeneral.SelectCommand.CommandText = "SELECT  DISTINCT  tas_tr_groupreshtehtahsili_reshtehtahsili.code_group_reshteh_tahsili AS code, " & _
                      " tas_bas_group_reshteh_tahsili.desc_group_reshteh_tahsili AS descript, tas_bas_group_reshteh_tahsili.remark as one " & _
                      " FROM         tas_tr_groupreshtehtahsili_reshtehtahsili LEFT OUTER JOIN " & _
                      " tas_bas_group_reshteh_tahsili ON  " & _
                      " tas_tr_groupreshtehtahsili_reshtehtahsili.code_group_reshteh_tahsili = tas_bas_group_reshteh_tahsili.code_group_reshteh_tahsili "


        End Select

                DAGeneral.Fill(DsFrmFind1.kar_personal)
        Select Case KindForm

            Case KindFind.FindVahed
                GridEX1.RootTable.Columns(0).Caption = "òœ Ê«Õœ"
                GridEX1.RootTable.Columns(1).Caption = "‰«„ Ê«Õœ"
                GridEX1.RootTable.Columns(2).Caption = "⁄‰Ê«‰  ‘òÌ·« "
                GridEX1.RootTable.Columns(3).Caption = "—œÂ"
                GridEX1.RootTable.Columns(4).Caption = "„Õ·"

            Case KindFind.FindPost
                GridEX1.RootTable.Columns(0).Caption = "òœ Å” "
                GridEX1.RootTable.Columns(1).Caption = "‰«„ Å”  "
                GridEX1.RootTable.Columns(2).Caption = "⁄‰Ê«‰ Ê«Õœ"
                GridEX1.RootTable.Columns(3).Caption = "—‘ Â"
                GridEX1.RootTable.Columns(4).Caption = "‘„«—Â Å” "

            Case KindFind.FindPerson
                GridEX1.RootTable.Columns(0).Caption = "‘„«—Â Å—”‰·Ì"
                GridEX1.RootTable.Columns(1).Caption = "‰«„"
                GridEX1.RootTable.Columns(2).Caption = "‰«„ Œ«‰Ê«œêÌ"
                GridEX1.RootTable.Columns(3).Caption = "‰«„ Åœ—"
                GridEX1.RootTable.Columns(4).Caption = "Ê«Õœ"
            Case KindFind.FindGroupReshte

                GridEX1.RootTable.Columns(0).Caption = "òœ ê—ÊÂ"
                GridEX1.RootTable.Columns(1).Caption = "‰«„ ê—ÊÂ"
                GridEX1.RootTable.Columns(2).Caption = "òœ —” Â"
                GridEX1.RootTable.Columns(3).Caption = "—” Â"
                GridEX1.RootTable.Columns(4).Visible = False
            Case KindFind.FindReshteShoghli
                GridEX1.RootTable.Columns(0).Caption = "òœ —‘ Â"
                GridEX1.RootTable.Columns(1).Caption = "‰«„ —‘ Â"
                GridEX1.RootTable.Columns(2).Caption = "‘—Õ ÊŸ«Ì›"
                GridEX1.RootTable.Columns(3).Visible = False
                GridEX1.RootTable.Columns(4).Visible = False
            Case KindFind.FindReshteTahsili
                GridEX1.RootTable.Columns(0).Caption = "òœ —‘ Â"
                GridEX1.RootTable.Columns(1).Caption = "‰«„ —‘ Â"
                GridEX1.RootTable.Columns(2).Caption = " Ê÷ÌÕ«  "
                GridEX1.RootTable.Columns(3).Visible = False
                GridEX1.RootTable.Columns(4).Visible = False
            Case KindFind.FindGroupReshteTahsili
                GridEX1.RootTable.Columns(0).Caption = "òœ ê—ÊÂ"
                GridEX1.RootTable.Columns(1).Caption = "‰«„ ê—ÊÂ"
                GridEX1.RootTable.Columns(2).Caption = " Ê÷ÌÕ«  "
                GridEX1.RootTable.Columns(3).Visible = False
                GridEX1.RootTable.Columns(4).Visible = False

        End Select




    End Sub

    Private Sub GridEX1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEX1.DoubleClick
        Dim Currentrow As GridEXRow = GridEX1.GetRow
        If Currentrow.RowIndex < 0 Then
            MsgFar("—œÌ› „Ê—œ ‰Ÿ— —« «‰ Œ«» ò‰Ìœ")
        Else
            Select Case KindForm
                Case KindFind.FindVahed
                    Id = IIf(Currentrow.Cells("code").Value Is DBNull.Value, "x", Currentrow.Cells("code").Value)

                Case KindFind.FindPost
                    IdPost = IIf(Currentrow.Cells("code").Value Is DBNull.Value, "x", Currentrow.Cells("code").Value)
                    Id = IIf(Currentrow.Cells("four").Value Is DBNull.Value, "x", Currentrow.Cells("four").Value)
                Case KindFind.FindPerson
                    IdPerson = IIf(Currentrow.Cells("code").Value Is DBNull.Value, "x", Currentrow.Cells("code").Value)
                    IdPost = IIf(Currentrow.Cells("five").Value Is DBNull.Value, "x", Currentrow.Cells("five").Value)
                    Id = IIf(Currentrow.Cells("four").Value Is DBNull.Value, "x", Currentrow.Cells("four").Value)
                Case KindFind.FindGroupReshte
                    Id = IIf(Currentrow.Cells("code").Value Is DBNull.Value, "x", Currentrow.Cells("code").Value)
                Case KindFind.FindReshteShoghli
                    Id = IIf(Currentrow.Cells("code").Value Is DBNull.Value, "x", Currentrow.Cells("code").Value)
                Case KindFind.FindReshteTahsili
                    Id = IIf(Currentrow.Cells("code").Value Is DBNull.Value, "x", Currentrow.Cells("code").Value)
                Case KindFind.FindGroupReshteTahsili
                    Id = IIf(Currentrow.Cells("code").Value Is DBNull.Value, "x", Currentrow.Cells("code").Value)
            End Select

            Me.Close()
        End If
    End Sub
End Class
