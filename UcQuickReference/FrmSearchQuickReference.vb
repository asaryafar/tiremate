Imports CommonClass
Public Class FrmSearchQuickReference
    Inherits FrmBase

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
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents CmbFind As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GRDMain As System.Windows.Forms.DataGrid
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Connection As System.Data.SqlClient.SqlConnection
    Friend WithEvents DaReference As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmSearchQuickReference1 As UcQuickReference.DSFrmSearchQuickReference
    Friend WithEvents ts11 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CmdQuickAdd As Janus.Windows.EditControls.UIButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.PanelSearch = New System.Windows.Forms.Panel
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.CmbFind = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GRDMain = New System.Windows.Forms.DataGrid
        Me.DsFrmSearchQuickReference1 = New UcQuickReference.DSFrmSearchQuickReference
        Me.ts11 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Connection = New System.Data.SqlClient.SqlConnection
        Me.DaReference = New System.Data.SqlClient.SqlDataAdapter
        Me.CmdQuickAdd = New Janus.Windows.EditControls.UIButton
        Me.PanelSearch.SuspendLayout()
        CType(Me.GRDMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmSearchQuickReference1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSearch
        '
        Me.PanelSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelSearch.Controls.Add(Me.TxtSearch)
        Me.PanelSearch.Controls.Add(Me.CmbFind)
        Me.PanelSearch.Controls.Add(Me.Label3)
        Me.PanelSearch.Controls.Add(Me.Label4)
        Me.PanelSearch.Location = New System.Drawing.Point(0, 40)
        Me.PanelSearch.Name = "PanelSearch"
        Me.PanelSearch.Size = New System.Drawing.Size(446, 56)
        Me.PanelSearch.TabIndex = 18
        '
        'TxtSearch
        '
        Me.TxtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearch.BackColor = System.Drawing.SystemColors.Info
        Me.TxtSearch.Location = New System.Drawing.Point(50, 8)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(120, 20)
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
        Me.CmbFind.Location = New System.Drawing.Point(263, 8)
        Me.CmbFind.Name = "CmbFind"
        Me.CmbFind.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbFind.Size = New System.Drawing.Size(171, 21)
        Me.CmbFind.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(178, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Filtering Field :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Filter :"
        '
        'GRDMain
        '
        Me.GRDMain.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.GRDMain.AllowNavigation = False
        Me.GRDMain.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.GRDMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GRDMain.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GRDMain.CaptionText = "ò«—Â«Ì Ã«—Ì"
        Me.GRDMain.CaptionVisible = False
        Me.GRDMain.DataMember = "inv_item_quick_refrence"
        Me.GRDMain.DataSource = Me.DsFrmSearchQuickReference1
        Me.GRDMain.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GRDMain.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GRDMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GRDMain.Location = New System.Drawing.Point(0, 80)
        Me.GRDMain.Name = "GRDMain"
        Me.GRDMain.ReadOnly = True
        Me.GRDMain.RowHeadersVisible = False
        Me.GRDMain.RowHeaderWidth = 30
        Me.GRDMain.Size = New System.Drawing.Size(446, 200)
        Me.GRDMain.TabIndex = 19
        Me.GRDMain.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.ts11})
        '
        'DsFrmSearchQuickReference1
        '
        Me.DsFrmSearchQuickReference1.DataSetName = "DSFrmSearchQuickReference"
        Me.DsFrmSearchQuickReference1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'ts11
        '
        Me.ts11.DataGrid = Me.GRDMain
        Me.ts11.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2})
        Me.ts11.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.ts11.MappingName = "inv_item_quick_refrence"
        Me.ts11.RowHeaderWidth = 30
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Cod"
        Me.DataGridTextBoxColumn1.MappingName = "cod_quick_refrence"
        Me.DataGridTextBoxColumn1.Width = 150
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Quick reference Number"
        Me.DataGridTextBoxColumn2.MappingName = "desc_quick_refrence"
        Me.DataGridTextBoxColumn2.Width = 200
        '
        'CmdOk
        '
        Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdOk.Location = New System.Drawing.Point(104, 291)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 21)
        Me.CmdOk.TabIndex = 22
        Me.CmdOk.Text = "Ok"
        '
        'CmdExit
        '
        Me.CmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdExit.Location = New System.Drawing.Point(8, 291)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 21)
        Me.CmdExit.TabIndex = 21
        Me.CmdExit.Text = "Exit"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cod_quick_refrence, desc_quick_refrence FROM inv_item_quick_refrence ORDER" & _
        " BY desc_quick_refrence"
        Me.SqlSelectCommand1.Connection = Me.Connection
        '
        'Connection
        '
        Me.Connection.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=BEH1;persist security" & _
        " info=True;initial catalog=TireMate_01;password=2191110"
        '
        'DaReference
        '
        Me.DaReference.SelectCommand = Me.SqlSelectCommand1
        Me.DaReference.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item_quick_refrence", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_quick_refrence", "cod_quick_refrence"), New System.Data.Common.DataColumnMapping("desc_quick_refrence", "desc_quick_refrence")})})
        '
        'CmdQuickAdd
        '
        Me.CmdQuickAdd.Location = New System.Drawing.Point(8, 8)
        Me.CmdQuickAdd.Name = "CmdQuickAdd"
        Me.CmdQuickAdd.Size = New System.Drawing.Size(112, 24)
        Me.CmdQuickAdd.TabIndex = 23
        Me.CmdQuickAdd.Text = "Quick Add"
        '
        'FrmSearchQuickReference
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(446, 316)
        Me.Controls.Add(Me.CmdQuickAdd)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.GRDMain)
        Me.Controls.Add(Me.PanelSearch)
        Me.Name = "FrmSearchQuickReference"
        Me.Text = "Search Quick Reference"
        Me.PanelSearch.ResumeLayout(False)
        CType(Me.GRDMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmSearchQuickReference1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Event QuickReferenceFind(ByVal ThisCod As String, ByVal ThisDesc As String)
    Private Sub FrmSearchQuickReference_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Connection.ConnectionString <> PConnectionString Then
                If Connection.State <> ConnectionState.Open Then
                    Connection.ConnectionString = PConnectionString
                End If
            End If
        Catch ex As Exception
        End Try
        Call find1()
    End Sub
    Private Sub TxtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearch.TextChanged
        Dim FilterField As String
        Select Case CmbFind.SelectedIndex
            Case 0
                FilterField = "cod_quick_refrence"
            Case 1
                FilterField = "desc_quick_refrence"
            Case Else
                FilterField = "desc_quick_refrence"
        End Select
        TxtSearch.Text = TxtSearch.Text.Replace("'", "")
        DsFrmSearchQuickReference1.Tables(0).DefaultView.RowFilter = "Convert( " & FilterField & ", 'System.String')  like '*" & TxtSearch.Text.Trim & "*'"
        GRDMain.DataSource = DsFrmSearchQuickReference1.Tables(0)
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
            RaiseEvent QuickReferenceFind(GRDMain.Item(GRDMain.CurrentRowIndex, 0), GRDMain.Item(GRDMain.CurrentRowIndex, 1))
            Me.Close()
        End If
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        If GRDMain.VisibleRowCount > 0 Then
            RaiseEvent QuickReferenceFind(GRDMain.Item(GRDMain.CurrentRowIndex, 0), GRDMain.Item(GRDMain.CurrentRowIndex, 1))
        End If
        Me.Close()
    End Sub
    Private Sub CmdQuickAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdQuickAdd.Click
        Dim ar(0) As Object
        ar(0) = "401100400" 'Load Range
        Dim tempAssembly As System.Reflection.Assembly
        tempAssembly = System.Reflection.Assembly.LoadFrom(Application.StartupPath & "\" & "FormGenerator.dll")
        Dim t As Type = tempAssembly.GetType("FormGenerator.FrmGeneral")
        Dim c As Form = CType(Activator.CreateInstance(t, ar), Form)
        c.ShowDialog()
        Call find1()
    End Sub
    Sub find1()
        DaReference.SelectCommand.Connection = Connection
        Try
            DsFrmSearchQuickReference1.inv_item_quick_refrence.Clear()
            DaReference.Fill(DsFrmSearchQuickReference1.inv_item_quick_refrence)
        Catch ex As Exception
            ' MsgBox(ex.ToString)
        End Try
        CmbFind.Items.Clear()
        Dim fld As System.Windows.Forms.DataGridTextBoxColumn
        For Each fld In ts11.GridColumnStyles
            If fld.Width > 0 Then
                CmbFind.Items.Add(fld.HeaderText)
            End If
        Next
        CmbFind.SelectedIndex = 1
        TxtSearch.Focus()
    End Sub

End Class
