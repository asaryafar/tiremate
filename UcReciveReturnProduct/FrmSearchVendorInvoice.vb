Imports CommonClass
Public Class FrmSearchVendorInvoice
    Inherits System.Windows.Forms.Form
    Dim MCod_Vendor As String = ""
    Public Event VandorInvoiceFind(ByVal ReferenceNo As String, ByVal ReferenceDate As String)
    Property Cod_Vendor() As String
        Get
            Return MCod_Vendor
        End Get
        Set(ByVal Value As String)
            MCod_Vendor = Value
        End Set
    End Property
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
    Friend WithEvents DsFrmVendorInvoiceSearch As DSFrmReceiveReturnProduct
    Friend WithEvents PanelSearch As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents CmbFind As System.Windows.Forms.ComboBox
    Friend WithEvents Connection As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GRDMain As System.Windows.Forms.DataGrid
    Friend WithEvents Ts11 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents DaInv_Receive_Products_head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmSearchVendorInvoice))
        Me.PanelSearch = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtSearch = New System.Windows.Forms.TextBox
        Me.CmbFind = New System.Windows.Forms.ComboBox
        Me.Connection = New System.Data.SqlClient.SqlConnection
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GRDMain = New System.Windows.Forms.DataGrid
        Me.DsFrmVendorInvoiceSearch = New UcReceiveReturnProduct.DSFrmReceiveReturnProduct
        Me.Ts11 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.DaInv_Receive_Products_head = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.PanelSearch.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GRDMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmVendorInvoiceSearch, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelSearch.Size = New System.Drawing.Size(560, 37)
        Me.PanelSearch.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(213, 8)
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
        Me.Label4.Location = New System.Drawing.Point(16, 8)
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
        Me.CmbFind.Location = New System.Drawing.Point(297, 8)
        Me.CmbFind.Name = "CmbFind"
        Me.CmbFind.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CmbFind.Size = New System.Drawing.Size(247, 21)
        Me.CmbFind.TabIndex = 11
        '
        'Connection
        '
        Me.Connection.ConnectionString = "workstation id=KETABIE;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=TireMate_03;password=sa"
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(480, 320)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 26
        Me.CmdOk.Text = "Ok"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GRDMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(560, 275)
        Me.Panel1.TabIndex = 24
        '
        'GRDMain
        '
        Me.GRDMain.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu
        Me.GRDMain.AllowNavigation = False
        Me.GRDMain.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.GRDMain.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GRDMain.CaptionText = "ò«—Â«Ì Ã«—Ì"
        Me.GRDMain.CaptionVisible = False
        Me.GRDMain.DataMember = "Inv_Receive_Products_head"
        Me.GRDMain.DataSource = Me.DsFrmVendorInvoiceSearch
        Me.GRDMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.GRDMain.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GRDMain.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GRDMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GRDMain.Location = New System.Drawing.Point(0, 0)
        Me.GRDMain.Name = "GRDMain"
        Me.GRDMain.ReadOnly = True
        Me.GRDMain.RowHeadersVisible = False
        Me.GRDMain.RowHeaderWidth = 30
        Me.GRDMain.Size = New System.Drawing.Size(560, 272)
        Me.GRDMain.TabIndex = 14
        Me.GRDMain.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.Ts11})
        '
        'DsFrmVendorInvoiceSearch
        '
        Me.DsFrmVendorInvoiceSearch.DataSetName = "DSFrmReceiveReturnProduct"
        Me.DsFrmVendorInvoiceSearch.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Ts11
        '
        Me.Ts11.DataGrid = Me.GRDMain
        Me.Ts11.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn4})
        Me.Ts11.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Ts11.MappingName = "Inv_Receive_Products_head"
        Me.Ts11.RowHeadersVisible = False
        Me.Ts11.RowHeaderWidth = 30
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Reference No"
        Me.DataGridTextBoxColumn1.MappingName = "vendor_ref_no"
        Me.DataGridTextBoxColumn1.Width = 110
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Date Recieve"
        Me.DataGridTextBoxColumn2.MappingName = "receipt_bill_date"
        Me.DataGridTextBoxColumn2.Width = 110
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Receive Reference no"
        Me.DataGridTextBoxColumn3.MappingName = "id_receive_ref"
        Me.DataGridTextBoxColumn3.Width = 120
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Amount"
        Me.DataGridTextBoxColumn5.MappingName = "amount"
        Me.DataGridTextBoxColumn5.Width = 120
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Due Date"
        Me.DataGridTextBoxColumn4.MappingName = "due_date"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'CmdExit
        '
        Me.CmdExit.Location = New System.Drawing.Point(392, 320)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 23)
        Me.CmdExit.TabIndex = 25
        Me.CmdExit.Text = "Exit"
        '
        'DaInv_Receive_Products_head
        '
        Me.DaInv_Receive_Products_head.SelectCommand = Me.SqlSelectCommand4
        Me.DaInv_Receive_Products_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_Receive_Products_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_receive_ref", "id_receive_ref"), New System.Data.Common.DataColumnMapping("date_receive", "date_receive"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("bill_credit", "bill_credit"), New System.Data.Common.DataColumnMapping("bill_receive", "bill_receive"), New System.Data.Common.DataColumnMapping("ap_term", "ap_term"), New System.Data.Common.DataColumnMapping("receipt_bill_date", "receipt_bill_date"), New System.Data.Common.DataColumnMapping("vendor_ref_no", "vendor_ref_no"), New System.Data.Common.DataColumnMapping("due_date", "due_date"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("house_comments", "house_comments"), New System.Data.Common.DataColumnMapping("vend_comments", "vend_comments"), New System.Data.Common.DataColumnMapping("Discount", "Discount")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Inv_Receive_Products_head.id_receive_ref, Inv_Receive_Products_head.date_r" & _
        "eceive, Inv_Receive_Products_head.cod_vendor, Inv_Receive_Products_head.ap_term," & _
        " Inv_Receive_Products_head.receipt_bill_date, Inv_Receive_Products_head.vendor_r" & _
        "ef_no, Inv_Receive_Products_head.due_date, Inv_Receive_Products_head.po_no, Inv_" & _
        "Receive_Products_head.house_comments, Inv_Receive_Products_head.vend_comments, I" & _
        "nv_Receive_Products_head.Discount, CAST(SUM(Inv_Receive_product_dtl.qty * (Inv_R" & _
        "eceive_product_dtl.cost + Inv_Receive_product_dtl.Fet)) AS decimal(8, 2)) AS amo" & _
        "unt FROM Inv_Receive_Products_head INNER JOIN Inv_Receive_product_dtl ON Inv_Rec" & _
        "eive_Products_head.id_receive_ref = Inv_Receive_product_dtl.id_receive_ref GROUP" & _
        " BY Inv_Receive_Products_head.id_receive_ref, Inv_Receive_Products_head.date_rec" & _
        "eive, Inv_Receive_Products_head.cod_vendor, Inv_Receive_Products_head.ap_term, I" & _
        "nv_Receive_Products_head.receipt_bill_date, Inv_Receive_Products_head.vendor_ref" & _
        "_no, Inv_Receive_Products_head.due_date, Inv_Receive_Products_head.po_no, Inv_Re" & _
        "ceive_Products_head.house_comments, Inv_Receive_Products_head.vend_comments, Inv" & _
        "_Receive_Products_head.Discount HAVING (Inv_Receive_Products_head.vendor_ref_no " & _
        "<> '') AND (Inv_Receive_Products_head.cod_vendor = @cod_vendor)"
        Me.SqlSelectCommand4.Connection = Me.Connection
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        '
        'FrmSearchVendorInvoice
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(560, 349)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.PanelSearch)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSearchVendorInvoice"
        Me.Text = "Search Vendor Invoice"
        Me.PanelSearch.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.GRDMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmVendorInvoiceSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmSearchVendorInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connection.ConnectionString = PConnectionString
        ' If MCod_Vendor.Trim <> "" Then
        Try
            DaInv_Receive_Products_head.SelectCommand.Parameters(0).Value = MCod_Vendor & ""
            DaInv_Receive_Products_head.Fill(DsFrmVendorInvoiceSearch)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        '  Else

        '  End If
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
                FilterField = "cod_vendor"
            Case 1
                FilterField = "date_receive"
            Case Else
                FilterField = "cod_vendor"
        End Select
        TxtSearch.Text = TxtSearch.Text.Replace("'", "")
        DsFrmVendorInvoiceSearch.Tables(0).DefaultView.RowFilter = "Convert( " & FilterField & ", 'System.String')  like '*" & TxtSearch.Text.Trim & "*'"
        GRDMain.DataSource = DsFrmVendorInvoiceSearch.Inv_Receive_Products_head
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
            RaiseEvent VandorInvoiceFind(GRDMain.Item(GRDMain.CurrentRowIndex, 0), GRDMain.Item(GRDMain.CurrentRowIndex, 1))
            Me.Close()
        End If
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        If GRDMain.VisibleRowCount > 0 Then
            'ClsCod_Pakage1.FillDs(GRDMain.Item(GRDMain.CurrentRowIndex, 0))
            RaiseEvent VandorInvoiceFind(GRDMain.Item(GRDMain.CurrentRowIndex, 0) & "", GRDMain.Item(GRDMain.CurrentRowIndex, 1) & "")
        End If
        Me.Close()
    End Sub
End Class
