Imports CommonClass
Public Class FrmSearchcod_pakage
    Inherits FrmBase
    Event Cod_PakageFind(ByVal ThisCod_Pakage As String, ByVal ThisDesc_Pakage As String, ByVal ThisPakageDataTable As DataTable)
    Dim WithEvents ClsCod_Pakage1 As New ClsCod_pakage
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
    Friend WithEvents DSFrmSearchcod_pakage1 As DSInv_tab_pakage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GRDMain As System.Windows.Forms.DataGrid
    Friend WithEvents PanelSearch As System.Windows.Forms.Panel
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents CmbFind As System.Windows.Forms.ComboBox
    Friend WithEvents Ts11 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Connection As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GRDMain = New System.Windows.Forms.DataGrid
        Me.DSFrmSearchcod_pakage1 = New UCInv_Package.DSInv_tab_pakage
        Me.Ts11 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.PanelSearch = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.CmbFind = New System.Windows.Forms.ComboBox
        Me.Connection = New System.Data.SqlClient.SqlConnection
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.Panel1.SuspendLayout()
        CType(Me.GRDMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSFrmSearchcod_pakage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GRDMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(648, 238)
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
        Me.GRDMain.DataMember = "inv_tab_pakage_head"
        Me.GRDMain.DataSource = Me.DSFrmSearchcod_pakage1
        Me.GRDMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.GRDMain.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GRDMain.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GRDMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GRDMain.Location = New System.Drawing.Point(0, 0)
        Me.GRDMain.Name = "GRDMain"
        Me.GRDMain.ReadOnly = True
        Me.GRDMain.RowHeadersVisible = False
        Me.GRDMain.RowHeaderWidth = 30
        Me.GRDMain.Size = New System.Drawing.Size(648, 234)
        Me.GRDMain.TabIndex = 14
        Me.GRDMain.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.Ts11})
        '
        'DSFrmSearchcod_pakage1
        '
        Me.DSFrmSearchcod_pakage1.DataSetName = "DSInv_tab_pakage"
        Me.DSFrmSearchcod_pakage1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Ts11
        '
        Me.Ts11.DataGrid = Me.GRDMain
        Me.Ts11.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2})
        Me.Ts11.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Ts11.MappingName = "inv_tab_pakage_head"
        Me.Ts11.RowHeadersVisible = False
        Me.Ts11.RowHeaderWidth = 30
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Cod"
        Me.DataGridTextBoxColumn1.MappingName = "cod_pakage"
        Me.DataGridTextBoxColumn1.Width = 120
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Description"
        Me.DataGridTextBoxColumn2.MappingName = "desc_pakage"
        Me.DataGridTextBoxColumn2.Width = 450
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
        Me.PanelSearch.Size = New System.Drawing.Size(648, 37)
        Me.PanelSearch.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(340, 6)
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
        Me.Label4.Location = New System.Drawing.Point(9, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Filter :"
        '
        'TxtSearch
        '
        Me.TxtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearch.BackColor = System.Drawing.SystemColors.Info
        Me.TxtSearch.Location = New System.Drawing.Point(52, 7)
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
        Me.CmbFind.Location = New System.Drawing.Point(423, 6)
        Me.CmbFind.Name = "CmbFind"
        Me.CmbFind.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbFind.Size = New System.Drawing.Size(208, 21)
        Me.CmbFind.TabIndex = 11
        '
        'Connection
        '
        Me.Connection.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01_" & _
        "2006;persist security info=True;password=5332"
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(558, 281)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 22
        Me.CmdOk.Text = "Ok"
        '
        'CmdExit
        '
        Me.CmdExit.Location = New System.Drawing.Point(466, 281)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 23)
        Me.CmdExit.TabIndex = 21
        Me.CmdExit.Text = "Exit"
        '
        'FrmSearchcod_pakage
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(648, 310)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelSearch)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmSearchcod_pakage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find Package"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GRDMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSFrmSearchcod_pakage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSearch.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmSearchInvCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connection.ConnectionString = PConnectionString
        ClsCod_Pakage1.Connection = Connection
        ClsCod_Pakage1.DApakageHead.Fill(DSFrmSearchcod_pakage1, "inv_tab_pakage_head")
        TxtSearch.Focus()
        CmbFind.Items.Clear()

        Dim fld As System.Windows.Forms.DataGridTextBoxColumn
        For Each fld In Ts11.GridColumnStyles
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
                FilterField = "Cod_Pakage"
            Case 1
                FilterField = "Desc_Pakage"
            Case Else
                FilterField = "Desc_Pakage"
        End Select
        TxtSearch.Text = TxtSearch.Text.Replace("'", "")
        DSFrmSearchcod_pakage1.Tables(0).DefaultView.RowFilter = "Convert( " & FilterField & ", 'System.String')  like '*" & TxtSearch.Text.Trim & "*'"
        GRDMain.DataSource = DSFrmSearchcod_pakage1.Tables(0)
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
            ClsCod_Pakage1.FillDs(GRDMain.Item(GRDMain.CurrentRowIndex, 0))
            RaiseEvent Cod_PakageFind(GRDMain.Item(GRDMain.CurrentRowIndex, 0), GRDMain.Item(GRDMain.CurrentRowIndex, 1), ClsCod_Pakage1.MYDSInv_tab_pakage.inv_tab_pakage)
            Me.Close()
        End If
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        If GRDMain.VisibleRowCount > 0 Then
            ClsCod_Pakage1.FillDs(GRDMain.Item(GRDMain.CurrentRowIndex, 0))
            RaiseEvent Cod_PakageFind(GRDMain.Item(GRDMain.CurrentRowIndex, 0), GRDMain.Item(GRDMain.CurrentRowIndex, 1), ClsCod_Pakage1.MYDSInv_tab_pakage.inv_tab_pakage)
        End If
        Me.Close()
    End Sub
End Class
