Imports CommonClass
Public Class FrmSearchvendorCod
    Inherits System.Windows.Forms.Form
    Event PublicCodFind(ByVal ThisCod As String, ByVal Thisdesc As String)
    Public Event ExecuteFrmSizeAddNew()
    '  Dim WithEvents ClsvendorCod1 As New ClsVendorCod
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    Friend WithEvents GRDMain As System.Windows.Forms.DataGrid
    Friend WithEvents PanelSearch As System.Windows.Forms.Panel
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents CmbFind As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Ts11 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents Connection As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents DaInvPublicTab As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmSearchPublicCOd1 As UcPublicTable.DSFrmSearchPublicCOd
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnAddNew As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GRDMain = New System.Windows.Forms.DataGrid
        Me.DsFrmSearchPublicCOd1 = New UcPublicTable.DSFrmSearchPublicCOd
        Me.Ts11 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.PanelSearch = New System.Windows.Forms.Panel
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.CmbFind = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Connection = New System.Data.SqlClient.SqlConnection
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.DaInvPublicTab = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.BtnAddNew = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.GRDMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmSearchPublicCOd1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSearch.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GRDMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(649, 238)
        Me.Panel1.TabIndex = 18
        '
        'GRDMain
        '
        Me.GRDMain.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.GRDMain.AllowNavigation = False
        Me.GRDMain.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.GRDMain.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GRDMain.CaptionText = "˜ÇÑåÇí ÌÇÑí"
        Me.GRDMain.CaptionVisible = False
        Me.GRDMain.DataMember = "inv_tab_public"
        Me.GRDMain.DataSource = Me.DsFrmSearchPublicCOd1
        Me.GRDMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.GRDMain.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GRDMain.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GRDMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GRDMain.Location = New System.Drawing.Point(0, 0)
        Me.GRDMain.Name = "GRDMain"
        Me.GRDMain.ReadOnly = True
        Me.GRDMain.RowHeadersVisible = False
        Me.GRDMain.RowHeaderWidth = 30
        Me.GRDMain.Size = New System.Drawing.Size(649, 234)
        Me.GRDMain.TabIndex = 14
        Me.GRDMain.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.Ts11})
        '
        'DsFrmSearchPublicCOd1
        '
        Me.DsFrmSearchPublicCOd1.DataSetName = "DSFrmSearchPublicCOd"
        Me.DsFrmSearchPublicCOd1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Ts11
        '
        Me.Ts11.DataGrid = Me.GRDMain
        Me.Ts11.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
        Me.Ts11.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Ts11.MappingName = "inv_tab_public"
        Me.Ts11.RowHeadersVisible = False
        Me.Ts11.RowHeaderWidth = 30
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Cod"
        Me.DataGridTextBoxColumn2.MappingName = "cod_table_public"
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 150
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Description"
        Me.DataGridTextBoxColumn3.MappingName = "desc_table"
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 400
        '
        'PanelSearch
        '
        Me.PanelSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelSearch.Controls.Add(Me.TxtSearch)
        Me.PanelSearch.Controls.Add(Me.CmbFind)
        Me.PanelSearch.Controls.Add(Me.Label3)
        Me.PanelSearch.Controls.Add(Me.Label4)
        Me.PanelSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSearch.Location = New System.Drawing.Point(0, 36)
        Me.PanelSearch.Name = "PanelSearch"
        Me.PanelSearch.Size = New System.Drawing.Size(649, 37)
        Me.PanelSearch.TabIndex = 17
        '
        'TxtSearch
        '
        Me.TxtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearch.BackColor = System.Drawing.SystemColors.Info
        Me.TxtSearch.Location = New System.Drawing.Point(49, 8)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(224, 21)
        Me.TxtSearch.TabIndex = 9
        Me.TxtSearch.Text = ""
        '
        'CmbFind
        '
        Me.CmbFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbFind.BackColor = System.Drawing.SystemColors.Info
        Me.CmbFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFind.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbFind.ItemHeight = 13
        Me.CmbFind.Items.AddRange(New Object() {"Ñæå ãÍÕæáÇÊ ", "ãÍÕæáÇÊ ãíÒ", "äÇã ãÍÕæá", "ãÏá ÏÓÊÇå", "ÊæÖíÍÇÊ "})
        Me.CmbFind.Location = New System.Drawing.Point(387, 7)
        Me.CmbFind.Name = "CmbFind"
        Me.CmbFind.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbFind.Size = New System.Drawing.Size(250, 21)
        Me.CmbFind.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(305, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Filtering Field :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Filter :"
        '
        'Connection
        '
        Me.Connection.ConnectionString = "workstation id=ARMANDEH;packet size=4096;user id=sa;data source=ARMANDEH;persist " & _
        "security info=True;initial catalog=TireMate_01;password="
        '
        'CmdExit
        '
        Me.CmdExit.Location = New System.Drawing.Point(10, 318)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 23)
        Me.CmdExit.TabIndex = 19
        Me.CmdExit.Text = "Exit"
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(110, 318)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 20
        Me.CmdOk.Text = "Ok"
        '
        'DaInvPublicTab
        '
        Me.DaInvPublicTab.SelectCommand = Me.SqlSelectCommand1
        Me.DaInvPublicTab.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_public", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_main", "cod_main"), New System.Data.Common.DataColumnMapping("cod_table_public", "cod_table_public"), New System.Data.Common.DataColumnMapping("desc_table", "desc_table")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cod_main, cod_table_public, desc_table FROM inv_tab_public WHERE (cod_main" & _
        " = @Cod_Main)"
        Me.SqlSelectCommand1.Connection = Me.Connection
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Main", System.Data.SqlDbType.VarChar, 2, "cod_main"))
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnAddNew)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(649, 36)
        Me.Panel2.TabIndex = 21
        '
        'BtnAddNew
        '
        Me.BtnAddNew.Location = New System.Drawing.Point(7, 7)
        Me.BtnAddNew.Name = "BtnAddNew"
        Me.BtnAddNew.Size = New System.Drawing.Size(101, 23)
        Me.BtnAddNew.TabIndex = 0
        Me.BtnAddNew.Text = "Quick Add"
        '
        'FrmSearchvendorCod
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(649, 355)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelSearch)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmSearchvendorCod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Search"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GRDMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmSearchPublicCOd1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSearch.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private MCod_Main As String
    Public Property Cod_main() As String
        Get
            Return MCod_Main
        End Get
        Set(ByVal Value As String)
            MCod_Main = Value
            DaInvPublicTab.SelectCommand.Parameters(0).Value = MCod_Main
        End Set
    End Property
    Private Sub FrmSearchInvCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillDataInDataSet()
    End Sub
    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearch.TextChanged
        Dim FilterField As String
        Select Case CmbFind.SelectedIndex
            Case 0
                FilterField = "cod_table_public"
            Case 1
                FilterField = "desc_table"
            Case Else
                FilterField = "desc_table"
        End Select
        TxtSearch.Text = TxtSearch.Text.Replace("'", "")
        DsFrmSearchPublicCOd1.Tables(0).DefaultView.RowFilter = "Convert( " & FilterField & ", 'System.String')  like '*" & TxtSearch.Text.Trim & "*'"
        GRDMain.DataSource = DsFrmSearchPublicCOd1.Tables(0)
        If GRDMain.VisibleRowCount > 0 Then
            CmdOk.Enabled = True
        Else
            CmdOk.Enabled = False
        End If

    End Sub
    Private Sub GRDMain_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles GRDMain.Navigate
        If CType(sender, DataGrid).VisibleRowCount > 0 Then
            CmdOk.Focus()
            CType(sender, DataGrid).Select(CType(sender, DataGrid).CurrentCell.RowNumber)
            CType(sender, DataGrid).Focus()
        End If
    End Sub
    Private Sub GRDMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRDMain.Click, GRDMain.CurrentCellChanged
        If CType(sender, DataGrid).VisibleRowCount > 0 Then
            CmdOk.Focus()
            CType(sender, DataGrid).Select(CType(sender, DataGrid).CurrentCell.RowNumber)
            CType(sender, DataGrid).Focus()
        End If
    End Sub
    Private Sub GRDMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRDMain.DoubleClick
        If CType(sender, DataGrid).VisibleRowCount > 0 Then
            CmdOk.Focus()
            CType(sender, DataGrid).Select(CType(sender, DataGrid).CurrentCell.RowNumber)
            CType(sender, DataGrid).Focus()
            RaiseEvent PublicCodFind(GRDMain.Item(GRDMain.CurrentRowIndex, 0), GRDMain.Item(GRDMain.CurrentRowIndex, 1))
            Me.Close()
        End If
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        If GRDMain.VisibleRowCount > 0 Then
            RaiseEvent PublicCodFind(GRDMain.Item(GRDMain.CurrentRowIndex, 0), GRDMain.Item(GRDMain.CurrentRowIndex, 1))
        End If
        Me.Close()
    End Sub
    Private Sub BtnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNew.Click
        RaiseEvent ExecuteFrmSizeAddNew()
        Call FillDataInDataset()
    End Sub
    Sub FillDataInDataset()
        BtnAddNew.Visible = False
        BtnAddNew.Enabled = False
        If Connection.State = ConnectionState.Open Then
            Connection.Close()
        End If
        Connection.ConnectionString = PConnectionString
        DaInvPublicTab.SelectCommand.Connection = Connection
        DaInvPublicTab.SelectCommand.Parameters(0).Value = MCod_Main
        Select Case MCod_Main
            Case "01"
                Me.Text = "Find Size"
                BtnAddNew.Visible = True
                BtnAddNew.Enabled = True
        End Select
        Try
            DaInvPublicTab.Fill(DsFrmSearchPublicCOd1.inv_tab_public)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        CmbFind.Items.Clear()
        Dim fld As System.Windows.Forms.DataGridTextBoxColumn
        For Each fld In Ts11.GridColumnStyles
            If fld.Width > 0 Then
                CmbFind.Items.Add(fld.HeaderText)
            End If
        Next
        CmbFind.SelectedIndex = 1
        TxtSearch.Focus()

    End Sub
End Class
