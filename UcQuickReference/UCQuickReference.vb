Imports CommonClass
Public Class QuickReference
    Inherits System.Windows.Forms.UserControl

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
    Friend WithEvents FndWithCod As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Connection As System.Data.SqlClient.SqlConnection
    Friend WithEvents FndWithdesc As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(QuickReference))
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.TxtPublic = New System.Windows.Forms.TextBox
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Connection = New System.Data.SqlClient.SqlConnection
        Me.FndWithCod = New System.Data.SqlClient.SqlDataAdapter
        Me.FndWithdesc = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SuspendLayout()
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.Location = New System.Drawing.Point(120, 0)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(21, 20)
        Me.BtnSearch.TabIndex = 5
        Me.BtnSearch.TabStop = False
        '
        'TxtPublic
        '
        Me.TxtPublic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPublic.BackColor = System.Drawing.Color.YellowGreen
        Me.TxtPublic.Location = New System.Drawing.Point(2, 0)
        Me.TxtPublic.Name = "TxtPublic"
        Me.TxtPublic.Size = New System.Drawing.Size(118, 20)
        Me.TxtPublic.TabIndex = 4
        Me.TxtPublic.Text = ""
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cod_quick_refrence, desc_quick_refrence FROM inv_item_quick_refrence"
        Me.SqlSelectCommand1.Connection = Me.Connection
        '
        'Connection
        '
        Me.Connection.ConnectionString = "workstation id=FARAJIXP;packet size=4096;user id=sa;data source=""."";persist secur" & _
        "ity info=True;initial catalog=Tiremate_01;password=sa"
        '
        'FndWithCod
        '
        Me.FndWithCod.SelectCommand = Me.SqlSelectCommand1
        Me.FndWithCod.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item_quick_refrence", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_quick_refrence", "cod_quick_refrence"), New System.Data.Common.DataColumnMapping("desc_quick_refrence", "desc_quick_refrence")})})
        '
        'FndWithdesc
        '
        Me.FndWithdesc.SelectCommand = Me.SqlCommand1
        Me.FndWithdesc.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item_quick_refrence", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_quick_refrence", "cod_quick_refrence"), New System.Data.Common.DataColumnMapping("desc_quick_refrence", "desc_quick_refrence")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT cod_quick_refrence, desc_quick_refrence FROM inv_item_quick_refrence WHERE" & _
        " (desc_quick_refrence = @desc_quick_refrence)"
        Me.SqlCommand1.Connection = Me.Connection
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_quick_refrence", System.Data.SqlDbType.VarChar, 50, "desc_quick_refrence"))
        '
        'QuickReference
        '
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxtPublic)
        Me.Name = "QuickReference"
        Me.Size = New System.Drawing.Size(144, 21)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private MCod_Main As String = "00"
    Private MCnn As System.Data.SqlClient.SqlConnection
    Private MFieldCodValue As String
    Private ThisDs As New DataSet
    Private WithEvents MyFrmSearchShow As FrmSearchQuickReference
    Private Flg As Boolean = True
    Private flag As Boolean = True
    Shadows Event KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)


#Region "All Properties"

    Public Property ReadOnlyText() As Boolean
        Get
            Return TxtPublic.ReadOnly
        End Get
        Set(ByVal Value As Boolean)
            TxtPublic.ReadOnly = Value
        End Set
    End Property
    Public Property Cnn() As System.Data.SqlClient.SqlConnection
        Get
            Return MCnn
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            MCnn = Value
            Call OkConnection()
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
            flag = False
            TxtPublic.Text = Value
            flag = True
            Call FindValue_WithCod()
        End Set
    End Property
#End Region
#Region "All 1"
    Private Sub TxtPublic_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPublic.TextChanged
        '        MCod_Main = TxtPublic.Text
        If flag Then
            Call FindValue_WithCod()
        End If
        RaiseEvent TextChanged(sender, e)
    End Sub
    Private Sub CustomerName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        TxtPublic.Focus()
    End Sub
    Private Sub TxtBublic_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPublic.KeyDown
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
    Sub ShowSearch()
        MyFrmSearchShow = New FrmSearchQuickReference
        MyFrmSearchShow.Connection = Cnn
        MyFrmSearchShow.ShowDialog()
        MyFrmSearchShow = Nothing
    End Sub
    Function FindValue_WithCod() As Boolean
        If Not MCnn Is Nothing Then
            If MCnn.State <> ConnectionState.Open Then
                MCnn.ConnectionString = PConnectionString
            End If
            Try
                ThisDs.Clear()
                OkConnection()
                MFieldCodValue = TxtPublic.Text
                FndWithCod.SelectCommand.CommandText = "SELECT     cod_quick_refrence, desc_quick_refrence FROM         inv_item_quick_refrence WHERE cod_quick_refrence = " & Qt(MFieldCodValue & "")
                'FndWithCod.SelectCommand.Parameters("@cod_quick_refrence").Value = MFieldCodValue & ""
                'FndWithCod.SelectCommand.Parameters("@cod_quick_refrence").Value = MFieldCodValue & ""
                FndWithCod.Fill(ThisDs, "T1")
                If ThisDs.Tables("T1").Rows.Count > 0 Then
                    RaiseEvent AfterFieldCodValueFind(ThisDs.Tables("T1").Rows(0))
                    MFieldCodValue = ThisDs.Tables("T1").Rows(0).Item("cod_quick_refrence")
                    'flag = False
                    'TxtPublic.Text = MFieldCodValue 'ThisDs.Tables("T1").Rows(0).Item("desc_quick_refrence") & ""
                    'flag = True
                    FindValue_WithCod = True
                Else
                    RaiseEvent NotFind()
                    FindValue_WithCod = False
                    MFieldCodValue = ""
                    'TxtPublic.Clear()
                End If
            Catch ex As Exception
                '        MsgBox(ex.ToString)
            End Try
        End If
    End Function
    Sub FindValue(ByVal RaiseEventIt As Boolean)

        Call FindValue_WithCod()

        'ThisDs.Clear()
        'OkConnection()
        'FndWithdesc.SelectCommand.Parameters("@desc_quick_refrence").Value = TxtPublic.Text.Trim
        'FndWithdesc.Fill(ThisDs, "T1")
        'If ThisDs.Tables("T1").Rows.Count > 0 Then
        '    If RaiseEventIt Then RaiseEvent AfterFieldCodValueFind(ThisDs.Tables("T1").Rows(0))
        '    MFieldCodValue = ThisDs.Tables("T1").Rows(0).Item("cod_quick_refrence")
        'Else
        '    If RaiseEventIt Then RaiseEvent NotFind()
        '    FieldCodValue = "0"
        'End If
    End Sub
    Sub OkConnection()
        FndWithCod.SelectCommand.Connection = MCnn
        FndWithdesc.SelectCommand.Connection = MCnn
    End Sub
    Private Sub MyFrmSearchShow_QuickReferenceFind(ByVal ThisCod As String, ByVal ThisDesc As String) Handles MyFrmSearchShow.QuickReferenceFind
        TxtPublic.Text = ThisCod
        FieldCodValue = ThisCod
    End Sub
    Private Sub TxtPublic_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPublic.LostFocus
        If FindValue_WithCod() = False Then
            flag = False
            TxtPublic.Text = ""
            flag = True
            MFieldCodValue = ""
        End If
    End Sub

    Private Sub TxtPublic_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPublic.KeyUp
        RaiseEvent KeyUp(sender, e)
    End Sub
End Class
