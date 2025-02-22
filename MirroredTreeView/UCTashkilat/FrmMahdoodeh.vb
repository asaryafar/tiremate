Imports CommonClass
Public Class FrmMahdoodeh
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
    Friend WithEvents CmbRadeSazmani As System.Windows.Forms.ComboBox
    Friend WithEvents s As System.Windows.Forms.Label
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAtas_bas_radeh_sazemani As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmMahdoodeh1 As UCTashkilat.DSFrmMahdoodeh
    Friend WithEvents CmbVahed As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAtas_bas_vahed As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmbCancel As Janus.Windows.EditControls.UIButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CmbRadeSazmani = New System.Windows.Forms.ComboBox
        Me.DsFrmMahdoodeh1 = New UCTashkilat.DSFrmMahdoodeh
        Me.s = New System.Windows.Forms.Label
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAtas_bas_radeh_sazemani = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmbVahed = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAtas_bas_vahed = New System.Data.SqlClient.SqlDataAdapter
        Me.CmbCancel = New Janus.Windows.EditControls.UIButton
        CType(Me.DsFrmMahdoodeh1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmbRadeSazmani
        '
        Me.CmbRadeSazmani.DataSource = Me.DsFrmMahdoodeh1.tas_bas_radeh_sazemani
        Me.CmbRadeSazmani.DisplayMember = "desc_radeh_sazemani"
        Me.CmbRadeSazmani.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRadeSazmani.Location = New System.Drawing.Point(64, 16)
        Me.CmbRadeSazmani.Name = "CmbRadeSazmani"
        Me.CmbRadeSazmani.Size = New System.Drawing.Size(159, 21)
        Me.CmbRadeSazmani.TabIndex = 2
        Me.CmbRadeSazmani.ValueMember = "code_radeh_sazemani"
        '
        'DsFrmMahdoodeh1
        '
        Me.DsFrmMahdoodeh1.DataSetName = "DSFrmMahdoodeh"
        Me.DsFrmMahdoodeh1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        's
        '
        Me.s.Location = New System.Drawing.Point(240, 16)
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(72, 25)
        Me.s.TabIndex = 3
        Me.s.Text = "—œÂ ”«“„«‰Ì"
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=MILAD;packet size=4096;integrated security=SSPI;data source=milad;" & _
        "persist security info=False;initial catalog=banader_01"
        '
        'DAtas_bas_radeh_sazemani
        '
        Me.DAtas_bas_radeh_sazemani.SelectCommand = Me.SqlSelectCommand3
        Me.DAtas_bas_radeh_sazemani.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tas_bas_radeh_sazemani", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("code_radeh_sazemani", "code_radeh_sazemani"), New System.Data.Common.DataColumnMapping("desc_radeh_sazemani", "desc_radeh_sazemani")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT code_radeh_sazemani, desc_radeh_sazemani FROM tas_bas_radeh_sazemani"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(24, 112)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(40, 25)
        Me.CmdOk.TabIndex = 4
        Me.CmdOk.Text = " «ÌÌœ"
        '
        'CmbVahed
        '
        Me.CmbVahed.DataSource = Me.DsFrmMahdoodeh1.tas_bas_vahed
        Me.CmbVahed.DisplayMember = "desc_vahed"
        Me.CmbVahed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbVahed.Location = New System.Drawing.Point(16, 26)
        Me.CmbVahed.Name = "CmbVahed"
        Me.CmbVahed.Size = New System.Drawing.Size(159, 21)
        Me.CmbVahed.TabIndex = 5
        Me.CmbVahed.ValueMember = "id_vahed"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(184, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ê«Õœ ”«“„«‰Ì"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbVahed)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 61)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_vahed, desc_vahed FROM tas_bas_vahed WHERE (code_radeh_sazemani = @CodR" & _
        "ade)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodRade", System.Data.SqlDbType.SmallInt, 2, "code_radeh_sazemani"))
        '
        'DAtas_bas_vahed
        '
        Me.DAtas_bas_vahed.SelectCommand = Me.SqlSelectCommand1
        Me.DAtas_bas_vahed.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tas_bas_vahed", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_vahed", "id_vahed"), New System.Data.Common.DataColumnMapping("desc_vahed", "desc_vahed")})})
        '
        'CmbCancel
        '
        Me.CmbCancel.Location = New System.Drawing.Point(72, 112)
        Me.CmbCancel.Name = "CmbCancel"
        Me.CmbCancel.Size = New System.Drawing.Size(40, 25)
        Me.CmbCancel.TabIndex = 8
        Me.CmbCancel.Text = "·€Ê"
        '
        'FrmMahdoodeh
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(382, 140)
        Me.Controls.Add(Me.CmbCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.s)
        Me.Controls.Add(Me.CmbRadeSazmani)
        Me.Name = "FrmMahdoodeh"
        CType(Me.DsFrmMahdoodeh1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public StrWhere As String = ""
    Public KindForm As KindMahdooeh
    Enum KindMahdooeh
        Radeh = 1
        Vahed = 2
    End Enum

    Private Sub FrmMahdoodeh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        DAtas_bas_radeh_sazemani.Fill(DsFrmMahdoodeh1.tas_bas_radeh_sazemani)
        Call Visiblecontrol()

    End Sub
    Private Sub Visiblecontrol()
        Select Case KindForm
            Case KindMahdooeh.Radeh
                CmdOk.Enabled = False
                GroupBox1.Visible = False
            Case KindMahdooeh.Vahed
                GroupBox1.Enabled = False
        End Select
    End Sub

    Private Sub CmbRadeSazmani_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbRadeSazmani.SelectedIndexChanged
        Select Case KindForm
            Case KindMahdooeh.Vahed
                DAtas_bas_vahed.SelectCommand.Parameters("@codrade").Value = CmbRadeSazmani.SelectedValue
                DAtas_bas_vahed.Fill(DsFrmMahdoodeh1.tas_bas_vahed)
                GroupBox1.Enabled = True
            Case KindMahdooeh.Radeh
                If CmbRadeSazmani.Text <> "" Then
                    CmdOk.Enabled = True
                End If
        End Select
        If KindForm = KindMahdooeh.Vahed Then

        End If
    End Sub

    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Select Case KindForm
            Case KindMahdooeh.Vahed
                StrWhere = Qt(CmbVahed.SelectedValue)
            Case KindMahdooeh.Radeh
                StrWhere = " and code_radeh_sazemani = " & Qt(CmbRadeSazmani.SelectedValue)

        End Select
        Me.Close()
    End Sub

    Private Sub CmbVahed_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbVahed.SelectedIndexChanged
        If CmbRadeSazmani.Text <> "" Then
            CmdOk.Enabled = True
        End If
    End Sub

    Private Sub CmbCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCancel.Click
        StrWhere = ""
        Me.Close()

    End Sub
End Class
