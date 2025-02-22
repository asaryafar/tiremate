Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmShow
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
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAtas_tr_takhsis_postsazemani As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmShow1 As UCTashkilat.DSFrmShow
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents lable1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.DsFrmShow1 = New UCTashkilat.DSFrmShow
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAtas_tr_takhsis_postsazemani = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.lable1 = New System.Windows.Forms.Label
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmShow1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.ContextMenu = Me.ContextMenu1
        Me.GridEX1.DataMember = "tas_tr_takhsis_postsazemani"
        Me.GridEX1.DataSource = Me.DsFrmShow1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""id_post""><Ca" & _
        "ption>òœ Å” </Caption><DataMember>id_post</DataMember><EditType>NoEdit</EditType" & _
        "><FilterEditType>TextBox</FilterEditType><Key>id_post</Key><Position>0</Position" & _
        "><Width>60</Width></Column0><Column1 ID=""code_personal_takhsis""><Caption>Å”   Œ’" & _
        "Ì’Ì</Caption><DataMember>NameTakhsis</DataMember><EditType>NoEdit</EditType><Fil" & _
        "terEditType>TextBox</FilterEditType><Key>code_personal_takhsis</Key><Position>1<" & _
        "/Position></Column1><Column2 ID=""code_personal_eblagh""><Caption>Å”  «»·«€Ì</Capt" & _
        "ion><DataMember>NameEblagh</DataMember><EditType>NoEdit</EditType><FilterEditTyp" & _
        "e>NoEdit</FilterEditType><Key>code_personal_eblagh</Key><Position>2</Position></" & _
        "Column2><Column3 ID=""date_takhsis""><Caption> «—ÌŒ  Œ’Ì’</Caption><DataMember>dat" & _
        "e_takhsis</DataMember><EditType>NoEdit</EditType><Key>date_takhsis</Key><Positio" & _
        "n>3</Position><Width>94</Width></Column3><Column4 ID=""date_eblagh""><Caption> «—Ì" & _
        "Œ «»·«€</Caption><DataMember>date_eblagh</DataMember><EditType>NoEdit</EditType>" & _
        "<Key>date_eblagh</Key><Position>4</Position><Width>93</Width></Column4></Columns" & _
        "><GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.Location = New System.Drawing.Point(0, 48)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GridEX1.Size = New System.Drawing.Size(558, 216)
        Me.GridEX1.TabIndex = 0
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Õ–›"
        '
        'DsFrmShow1
        '
        Me.DsFrmShow1.DataSetName = "DSFrmShow"
        Me.DsFrmShow1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT tas_tr_takhsis_postsazemani.id_post, tas_tr_takhsis_postsazemani.code_post" & _
        "_sazemani, tas_tr_takhsis_postsazemani.code_personal_takhsis, tas_tr_takhsis_pos" & _
        "tsazemani.code_personal_eblagh, tas_tr_takhsis_postsazemani.activate, tas_tr_tak" & _
        "hsis_postsazemani.date_takhsis, tas_tr_takhsis_postsazemani.date_eblagh, tas_tr_" & _
        "takhsis_postsazemani.remark, tas_tr_takhsis_postsazemani.code_bandar, kar_person" & _
        "al.fname + ' ' + kar_personal.lname AS NameEblagh, kar_personal_1.fname + ' ' + " & _
        "kar_personal_1.lname AS NameTakhsis FROM tas_tr_takhsis_postsazemani LEFT OUTER " & _
        "JOIN kar_personal ON tas_tr_takhsis_postsazemani.code_personal_eblagh = kar_pers" & _
        "onal.code_personal LEFT OUTER JOIN kar_personal kar_personal_1 ON tas_tr_takhsis" & _
        "_postsazemani.code_personal_takhsis = kar_personal_1.code_personal WHERE (tas_tr" & _
        "_takhsis_postsazemani.code_post_sazemani = @codpost) AND (tas_tr_takhsis_postsaz" & _
        "emani.activate = 0)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@codpost", System.Data.SqlDbType.SmallInt, 2, "code_post_sazemani"))
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=MILAD;packet size=4096;integrated security=SSPI;data source=milad;" & _
        "persist security info=False;initial catalog=banader_02"
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM tas_tr_takhsis_postsazemani WHERE (id_post = @IdPost)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdPost", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_post", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAtas_tr_takhsis_postsazemani
        '
        Me.DAtas_tr_takhsis_postsazemani.DeleteCommand = Me.SqlDeleteCommand1
        Me.DAtas_tr_takhsis_postsazemani.SelectCommand = Me.SqlSelectCommand1
        Me.DAtas_tr_takhsis_postsazemani.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tas_tr_takhsis_postsazemani", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_post", "id_post"), New System.Data.Common.DataColumnMapping("code_post_sazemani", "code_post_sazemani")})})
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Window
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.lable1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(558, 48)
        Me.Panel9.TabIndex = 5
        '
        'lable1
        '
        Me.lable1.Location = New System.Drawing.Point(306, 5)
        Me.lable1.Name = "lable1"
        Me.lable1.Size = New System.Drawing.Size(225, 32)
        Me.lable1.TabIndex = 0
        Me.lable1.Text = "»—«Ì Õ–› «ÿ·«⁄«  —ÊÌ Â— —œÌ› ò·Ìò —«”  ò—œÂ Ê ""Õ–›"" —« «‰ Œ«» ‰„«ÌÌœ"
        '
        'FrmShow
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(558, 260)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.Panel9)
        Me.Name = "FrmShow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmShow1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public IdPost As String

    Private Sub FrmShow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString


        DsFrmShow1.tas_tr_takhsis_postsazemani.Clear()
        DAtas_tr_takhsis_postsazemani.SelectCommand.Parameters("@codpost").Value = IdPost
        DAtas_tr_takhsis_postsazemani.Fill(DsFrmShow1.tas_tr_takhsis_postsazemani)

    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim c1 As New FrmWhatDoForMenu
        c1.ShowFarMsg("¬Ì« «Ì‰ —òÊ—œ Õ–› ‘Êœø")
        If c1.DialogResult = DialogResult.OK Then
            Dim Currentrow As GridEXRow = GridEX1.GetRow
            If Currentrow.RowIndex < 0 Then
            Else
                If DAtas_tr_takhsis_postsazemani.DeleteCommand.Connection.State <> ConnectionState.Open Then
                    DAtas_tr_takhsis_postsazemani.DeleteCommand.Connection.Open()
                End If
                With DAtas_tr_takhsis_postsazemani.DeleteCommand
                    .Parameters("@idpost").Value = Currentrow.Cells("id_post").Value

                    Try
                        .ExecuteNonQuery()
                    Catch ex As Exception
                        MsgFar("«„ò«‰ Õ–› «Ì‰ Å”  ÊÃÊœ ‰œ«—œ")
                    End Try
                End With
                ''IdShoghlArray(i) = String
                'IdShoghlArray(i) = Currentrow.Cells("id_post").Value
                'i = i + 1
                DsFrmShow1.tas_tr_takhsis_postsazemani.Clear()
                DAtas_tr_takhsis_postsazemani.SelectCommand.Parameters("@codpost").Value = IdPost
                DAtas_tr_takhsis_postsazemani.Fill(DsFrmShow1.tas_tr_takhsis_postsazemani)
            End If

        End If

    End Sub


End Class
