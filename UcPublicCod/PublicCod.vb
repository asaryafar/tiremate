
Public Class PublicCod
    Inherits System.Windows.Forms.UserControl
    Private MCod_Main As String = "00"
    Private MCnn As System.Data.SqlClient.SqlConnection
    Private MFieldCodValue As String
    Private ThisDs As New DataSet
    Private WithEvents MyFrmSearchShow As FrmSearchvendorCod
    Public Event ExecuteFrmSizeAddNew()
    Private Flg As Boolean = True
    Shadows Event KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl1 overrides dispose to clean up the component list.
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
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents TxtPublic As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DaInvPublicTab As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DaInvPublicTabCod As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PublicCod))
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.TxtPublic = New System.Windows.Forms.TextBox
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.DaInvPublicTab = New System.Data.SqlClient.SqlDataAdapter
        Me.DaInvPublicTabCod = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SuspendLayout()
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.Location = New System.Drawing.Point(98, 0)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(21, 20)
        Me.BtnSearch.TabIndex = 3
        Me.BtnSearch.TabStop = False
        '
        'TxtPublic
        '
        Me.TxtPublic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPublic.BackColor = System.Drawing.Color.YellowGreen
        Me.TxtPublic.Location = New System.Drawing.Point(1, 0)
        Me.TxtPublic.Name = "TxtPublic"
        Me.TxtPublic.Size = New System.Drawing.Size(98, 20)
        Me.TxtPublic.TabIndex = 2
        Me.TxtPublic.Text = ""
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cod_main, cod_table_public, desc_table FROM inv_tab_public WHERE (cod_main" & _
        " = @Cod_Main) AND (desc_table = @Desc_Table)"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Main", System.Data.SqlDbType.VarChar, 2, "cod_main"))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Desc_Table", System.Data.SqlDbType.VarChar, 50, "desc_table"))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=FARAJI;packet size=4096;user id=sa;initial catalog=TireMate_01;per" & _
        "sist security info=True;password=5332"
        '
        'DaInvPublicTab
        '
        Me.DaInvPublicTab.SelectCommand = Me.SqlSelectCommand1
        Me.DaInvPublicTab.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_public", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_main", "cod_main"), New System.Data.Common.DataColumnMapping("cod_table_public", "cod_table_public"), New System.Data.Common.DataColumnMapping("desc_table", "desc_table")})})
        '
        'DaInvPublicTabCod
        '
        Me.DaInvPublicTabCod.SelectCommand = Me.SqlCommand1
        Me.DaInvPublicTabCod.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_public", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_main", "cod_main"), New System.Data.Common.DataColumnMapping("cod_table_public", "cod_table_public"), New System.Data.Common.DataColumnMapping("desc_table", "desc_table")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT cod_main, cod_table_public, desc_table FROM inv_tab_public WHERE (cod_main" & _
        " = @Cod_Main) AND (cod_table_public = @Cod_Table_Public)"
        Me.SqlCommand1.Connection = Me.SqlConnection1
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Main", System.Data.SqlDbType.VarChar, 2, "cod_main"))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Table_Public", System.Data.SqlDbType.VarChar, 3, "cod_table_public"))
        '
        'PublicCod
        '
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxtPublic)
        Me.Name = "PublicCod"
        Me.Size = New System.Drawing.Size(120, 21)
        Me.ResumeLayout(False)

    End Sub

#End Region
    'kamran faraji
#Region "All Properties"

    Public Property Cnn() As System.Data.SqlClient.SqlConnection
        Get
            Return MCnn
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            MCnn = Value
            Call OkConnection()
            
        End Set
    End Property
    Public Property Cod_main() As String
        Get
            Return MCod_Main
        End Get
        Set(ByVal Value As String)
            MCod_Main = Value
        End Set
    End Property
    Shadows Event TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Public Event AfterFieldCodValueFind(ByVal ThisRow As DataRow)
    Public Event NotFind()
    Public Overrides Property Text() As String
        Get
            Return TxtPublic.Text
        End Get
        Set(ByVal Value As String)
            TxtPublic.Text = Value
        End Set
    End Property
    '---------------------------------------------
    Public Property TxtBackColor() As System.Drawing.Color
        Get
            Return TxtPublic.BackColor
        End Get
        Set(ByVal Value As System.Drawing.Color)
            TxtPublic.BackColor = Value
        End Set
    End Property
    Public Property TxtForeColor() As System.Drawing.Color
        Get
            Return TxtPublic.ForeColor
        End Get
        Set(ByVal Value As System.Drawing.Color)
            TxtPublic.ForeColor = Value
        End Set
    End Property
    Public Property TxtRightToLeft() As System.Windows.Forms.RightToLeft
        Get
            Return TxtPublic.RightToLeft
        End Get
        Set(ByVal Value As System.Windows.Forms.RightToLeft)
            TxtPublic.RightToLeft = Value
        End Set
    End Property
    Public Property FieldCodValue() As String
        Get
            Return MFieldCodValue
        End Get
        Set(ByVal Value As String)
            MFieldCodValue = Value
            Call FindValue_WithCod()
        End Set
    End Property
#End Region
    '-----------------------------------------------------------------------
#Region "All 1"
    Private Sub TxtPublic_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPublic.TextChanged
        '  FindValue(False)
        RaiseEvent TextChanged(sender, e)
    End Sub
    Private Sub CustomerName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        TxtPublic.Focus()
    End Sub
    Private Sub TxtLicenseNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPublic.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call FindValue(True)
        End If
        If e.KeyCode = Keys.F4 And Not (e.Modifiers = Keys.Alt) Then
            ShowSearch()
        End If
    End Sub
    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        ShowSearch()
    End Sub
    Private Sub PublicCod_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        Call FindValue(True)
    End Sub
#End Region
    '---------------------------------------
    Sub ShowSearch()
        MyFrmSearchShow = New FrmSearchvendorCod
        MyFrmSearchShow.Connection = Cnn
        MyFrmSearchShow.Cod_main = MCod_Main
        MyFrmSearchShow.ShowDialog()
        MyFrmSearchShow = Nothing
    End Sub
    Private Sub MyFrmSearchShow_PublicCodFind(ByVal ThisCod As String, ByVal Thisdesc As String) Handles MyFrmSearchShow.PublicCodFind
        TxtPublic.Text = Thisdesc
        FieldCodValue = ThisCod
    End Sub
    Sub FindValue_WithCod()
        If Not MCnn Is Nothing Then
            Try
                ThisDs.Clear()
                OkConnection()

                DaInvPublicTabCod.SelectCommand.Parameters("@Cod_Main").Value = MCod_Main
                DaInvPublicTabCod.SelectCommand.Parameters("@Cod_Table_Public").Value = MFieldCodValue & ""
                DaInvPublicTabCod.Fill(ThisDs, "T1")
                If ThisDs.Tables("T1").Rows.Count > 0 Then
                    RaiseEvent AfterFieldCodValueFind(ThisDs.Tables("T1").Rows(0))
                    MFieldCodValue = ThisDs.Tables("T1").Rows(0).Item("cod_table_public")
                    TxtPublic.Text = ThisDs.Tables("T1").Rows(0).Item("desc_table") & ""
                Else
                    RaiseEvent NotFind()
                    MFieldCodValue = ""
                    TxtPublic.Clear()
                End If
            Catch ex As Exception
                '        MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Sub FindValue(ByVal RaiseEventIt As Boolean)
        ThisDs.Clear()
        OkConnection()
        DaInvPublicTab.SelectCommand.Parameters("@Cod_Main").Value = MCod_Main
        DaInvPublicTab.SelectCommand.Parameters("@Desc_Table").Value = TxtPublic.Text.Trim
        DaInvPublicTab.Fill(ThisDs, "T1")
        If ThisDs.Tables("T1").Rows.Count > 0 Then
            If RaiseEventIt Then RaiseEvent AfterFieldCodValueFind(ThisDs.Tables("T1").Rows(0))
            MFieldCodValue = ThisDs.Tables("T1").Rows(0).Item("cod_table_public")
        Else
            If RaiseEventIt Then RaiseEvent NotFind()
            FieldCodValue = "0"
        End If
    End Sub
    Sub OkConnection()
        DaInvPublicTab.SelectCommand.Connection = MCnn
        DaInvPublicTabCod.SelectCommand.Connection = MCnn
    End Sub
    Private Sub MyFrmSearchShow_ExecuteFrmSizeAddNew() Handles MyFrmSearchShow.ExecuteFrmSizeAddNew
        RaiseEvent ExecuteFrmSizeAddNew()
    End Sub
    Private Sub TxtPublic_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPublic.KeyUp
        RaiseEvent KeyUp(sender, e)
    End Sub
End Class
