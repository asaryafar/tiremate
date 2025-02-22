Imports CommonClass
Public Class FrmSearchGlAccount
    Inherits System.Windows.Forms.Form
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
    Friend WithEvents PanelSearch As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents CmbFind As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GRDMain As System.Windows.Forms.DataGrid
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents Connection As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ts11 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DaGlAccount As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmGlAccount1 As UcAccount.DSFrmGlAccount
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.PanelSearch = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.CmbFind = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GRDMain = New System.Windows.Forms.DataGrid
        Me.ts11 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.Connection = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaGlAccount = New System.Data.SqlClient.SqlDataAdapter
        Me.DsFrmGlAccount1 = New UcAccount.DSFrmGlAccount
        Me.PanelSearch.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GRDMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmGlAccount1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSearch
        '
        Me.PanelSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelSearch.Controls.Add(Me.Label3)
        Me.PanelSearch.Controls.Add(Me.Label4)
        Me.PanelSearch.Controls.Add(Me.TxtSearch)
        Me.PanelSearch.Controls.Add(Me.CmbFind)
        Me.PanelSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSearch.Location = New System.Drawing.Point(0, 0)
        Me.PanelSearch.Name = "PanelSearch"
        Me.PanelSearch.Size = New System.Drawing.Size(496, 37)
        Me.PanelSearch.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(196, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Filtering Field :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Filter :"
        '
        'TxtSearch
        '
        Me.TxtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearch.BackColor = System.Drawing.SystemColors.Info
        Me.TxtSearch.Location = New System.Drawing.Point(56, 8)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(132, 20)
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
        Me.CmbFind.Items.AddRange(New Object() {"ê—ÊÂ „Õ’Ê·«  ", "„Õ’Ê·«  „Ì“", "‰«„ „Õ’Ê·", "„œ· œ” ê«Â", " Ê÷ÌÕ«  "})
        Me.CmbFind.Location = New System.Drawing.Point(280, 8)
        Me.CmbFind.Name = "CmbFind"
        Me.CmbFind.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbFind.Size = New System.Drawing.Size(208, 21)
        Me.CmbFind.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GRDMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(496, 299)
        Me.Panel1.TabIndex = 27
        '
        'GRDMain
        '
        Me.GRDMain.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.GRDMain.AllowNavigation = False
        Me.GRDMain.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.GRDMain.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GRDMain.CaptionText = "ò«—Â«Ì Ã«—Ì"
        Me.GRDMain.CaptionVisible = False
        Me.GRDMain.DataMember = ""
        Me.GRDMain.DataSource = Me.DsFrmGlAccount1.GL_account
        Me.GRDMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.GRDMain.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GRDMain.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GRDMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GRDMain.Location = New System.Drawing.Point(0, 0)
        Me.GRDMain.Name = "GRDMain"
        Me.GRDMain.ReadOnly = True
        Me.GRDMain.RowHeadersVisible = False
        Me.GRDMain.RowHeaderWidth = 30
        Me.GRDMain.Size = New System.Drawing.Size(496, 296)
        Me.GRDMain.TabIndex = 14
        Me.GRDMain.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.ts11})
        '
        'ts11
        '
        Me.ts11.DataGrid = Me.GRDMain
        Me.ts11.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2})
        Me.ts11.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.ts11.MappingName = "GL_account"
        Me.ts11.PreferredColumnWidth = 101
        Me.ts11.ReadOnly = True
        Me.ts11.RowHeadersVisible = False
        Me.ts11.RowHeaderWidth = 30
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Gl Account"
        Me.DataGridTextBoxColumn1.MappingName = "GL_account"
        Me.DataGridTextBoxColumn1.Width = 130
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Account Name"
        Me.DataGridTextBoxColumn2.MappingName = "desc_GL_account"
        Me.DataGridTextBoxColumn2.Width = 250
        '
        'CmdExit
        '
        Me.CmdExit.Location = New System.Drawing.Point(322, 343)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 23)
        Me.CmdExit.TabIndex = 28
        Me.CmdExit.Text = "Exit"
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(410, 343)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 29
        Me.CmdOk.Text = "Ok"
        '
        'Connection
        '
        Me.Connection.ConnectionString = "workstation id=ARMANDEH;packet size=4096;user id=sa;data source=ARMANDEH;persist " & _
        "security info=True;initial catalog=TireMate_01;password="
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT GL_account, desc_GL_account, GL_account_master, group_GL_account, remark F" & _
        "ROM GL_account ORDER BY GL_account"
        Me.SqlSelectCommand1.Connection = Me.Connection
        '
        'DaGlAccount
        '
        Me.DaGlAccount.SelectCommand = Me.SqlSelectCommand1
        Me.DaGlAccount.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("desc_GL_account", "desc_GL_account"), New System.Data.Common.DataColumnMapping("GL_account_master", "GL_account_master"), New System.Data.Common.DataColumnMapping("group_GL_account", "group_GL_account"), New System.Data.Common.DataColumnMapping("remark", "remark")})})
        '
        'DsFrmGlAccount1
        '
        Me.DsFrmGlAccount1.DataSetName = "DSFrmGlAccount"
        Me.DsFrmGlAccount1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'FrmSearchGlAccount
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(496, 373)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelSearch)
        Me.Name = "FrmSearchGlAccount"
        Me.Text = "Search On Gl Account"
        Me.PanelSearch.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.GRDMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmGlAccount1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmSearchGlAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connection.ConnectionString = PConnectionString
        ' If MCod_Vendor.Trim <> "" Then
        DaGlAccount.Fill(DsFrmGlAccount1)
        TxtSearch.Focus()
        CmbFind.Items.Clear()
        Dim fld As System.Windows.Forms.DataGridTextBoxColumn
        For Each fld In ts11.GridColumnStyles
            If fld.Width > 0 Then
                CmbFind.Items.Add(fld.HeaderText)
            End If
        Next
        Dim i As Integer = 0
        CmbFind.SelectedIndex = 1
    End Sub

    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearch.TextChanged
        Dim FilterField As String
        Select Case CmbFind.SelectedIndex
            Case 0
                FilterField = "GL_account"
            Case 1
                FilterField = "desc_GL_account"
            Case Else
                FilterField = "desc_GL_account"
        End Select
        TxtSearch.Text = TxtSearch.Text.Replace("'", "")
        DsFrmGlAccount1.Tables(0).DefaultView.RowFilter = "Convert( " & FilterField & ", 'System.String')  like '*" & TxtSearch.Text.Trim & "*'"
        GRDMain.DataSource = DsFrmGlAccount1.GL_account
        If GRDMain.VisibleRowCount > 0 Then
            CmdOk.Enabled = True
        Else
            CmdOk.Enabled = False
        End If
        CmbFind.SelectedIndex = 1
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
            Call AfterFindIt()
            ' RaiseEvent VandorInvoiceFind(GRDMain.Item(GRDMain.CurrentRowIndex, 0), GRDMain.Item(GRDMain.CurrentRowIndex, 1))
            Me.Close()
        End If
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        If GRDMain.VisibleRowCount > 0 Then
            'ClsCod_Pakage1.FillDs(GRDMain.Item(GRDMain.CurrentRowIndex, 0))
            Call AfterFindIt()
            'RaiseEvent VandorInvoiceFind(GRDMain.Item(GRDMain.CurrentRowIndex, 0) & "", GRDMain.Item(GRDMain.CurrentRowIndex, 1) & "")
        End If
        Me.Close()
    End Sub
    Sub AfterFindit()
        Dim dr1 As DataRow = DsFrmGlAccount1.GL_account.FindByGL_account(GRDMain.Item(GRDMain.CurrentRowIndex, 0))
        RaiseEvent GlAccountFind(dr1)
    End Sub
End Class
