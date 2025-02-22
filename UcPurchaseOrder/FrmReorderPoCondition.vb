
Public Class FrmReorderPoCondition
    Inherits CommonClass.FrmBase
    Public Event AddThis(ByVal ItemNo As String, ByVal ThisQty As Decimal)
    Public Event ClearDataSet()
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbItemType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rdosold As System.Windows.Forms.RadioButton
    Friend WithEvents rdoshortage As System.Windows.Forms.RadioButton
    Friend WithEvents CmdOk As System.Windows.Forms.Button
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DaSold As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmPurchaseOrderItems1 As UcPurchaseOrder.DSFrmPurchaseOrderItems
    Friend WithEvents TxtFrom As CalendarCombo.CalendarCombo
    Friend WithEvents TxtTo As CalendarCombo.CalendarCombo
    Friend WithEvents DaItemType As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents PnlDate As System.Windows.Forms.Panel
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaItem As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents ChkExclude As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmReorderPoCondition))
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdoshortage = New System.Windows.Forms.RadioButton
        Me.rdosold = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ChkExclude = New System.Windows.Forms.CheckBox
        Me.CmbItemType = New System.Windows.Forms.ComboBox
        Me.DsFrmPurchaseOrderItems1 = New UcPurchaseOrder.DSFrmPurchaseOrderItems
        Me.Label2 = New System.Windows.Forms.Label
        Me.PnlDate = New System.Windows.Forms.Panel
        Me.TxtFrom = New CalendarCombo.CalendarCombo
        Me.TxtTo = New CalendarCombo.CalendarCombo
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmdOk = New System.Windows.Forms.Button
        Me.CmdCancel = New System.Windows.Forms.Button
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DaSold = New System.Data.SqlClient.SqlDataAdapter
        Me.DaItemType = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaItem = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DsFrmPurchaseOrderItems1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(526, 48)
        Me.Panel4.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(96, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select The Following Option to Create  Your Purchase Order"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoshortage)
        Me.GroupBox1.Controls.Add(Me.rdosold)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Create your Purchase order For"
        '
        'rdoshortage
        '
        Me.rdoshortage.Location = New System.Drawing.Point(276, 20)
        Me.rdoshortage.Name = "rdoshortage"
        Me.rdoshortage.Size = New System.Drawing.Size(237, 24)
        Me.rdoshortage.TabIndex = 1
        Me.rdoshortage.Text = "Create your Purchase order For Shortages"
        '
        'rdosold
        '
        Me.rdosold.Checked = True
        Me.rdosold.Location = New System.Drawing.Point(7, 20)
        Me.rdosold.Name = "rdosold"
        Me.rdosold.Size = New System.Drawing.Size(264, 24)
        Me.rdosold.TabIndex = 0
        Me.rdosold.TabStop = True
        Me.rdosold.Text = "Create your Purchase order For What You Sold"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ChkExclude)
        Me.Panel1.Controls.Add(Me.CmbItemType)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(4, 127)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(516, 41)
        Me.Panel1.TabIndex = 1
        '
        'ChkExclude
        '
        Me.ChkExclude.Location = New System.Drawing.Point(280, 8)
        Me.ChkExclude.Name = "ChkExclude"
        Me.ChkExclude.Size = New System.Drawing.Size(216, 24)
        Me.ChkExclude.TabIndex = 1
        Me.ChkExclude.Text = "Exclude items with Negative QTY"
        '
        'CmbItemType
        '
        Me.CmbItemType.DataSource = Me.DsFrmPurchaseOrderItems1.inv_tab_type_item
        Me.CmbItemType.DisplayMember = "desc_item_type"
        Me.CmbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbItemType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbItemType.ItemHeight = 13
        Me.CmbItemType.Location = New System.Drawing.Point(95, 13)
        Me.CmbItemType.Name = "CmbItemType"
        Me.CmbItemType.Size = New System.Drawing.Size(128, 21)
        Me.CmbItemType.TabIndex = 0
        Me.CmbItemType.ValueMember = "cod_item_type"
        '
        'DsFrmPurchaseOrderItems1
        '
        Me.DsFrmPurchaseOrderItems1.DataSetName = "DSFrmPurchaseOrderItems"
        Me.DsFrmPurchaseOrderItems1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "For Item Type"
        '
        'PnlDate
        '
        Me.PnlDate.Controls.Add(Me.TxtFrom)
        Me.PnlDate.Controls.Add(Me.TxtTo)
        Me.PnlDate.Controls.Add(Me.Label4)
        Me.PnlDate.Controls.Add(Me.Label3)
        Me.PnlDate.Location = New System.Drawing.Point(4, 176)
        Me.PnlDate.Name = "PnlDate"
        Me.PnlDate.Size = New System.Drawing.Size(516, 40)
        Me.PnlDate.TabIndex = 2
        '
        'TxtFrom
        '
        Me.TxtFrom.BackColor = System.Drawing.SystemColors.Info
        Me.TxtFrom.BorderColor = System.Drawing.Color.Empty
        Me.TxtFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFrom.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtFrom.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtFrom.EditableSal = True
        Me.TxtFrom.Image = CType(resources.GetObject("TxtFrom.Image"), System.Drawing.Image)
        Me.TxtFrom.Location = New System.Drawing.Point(88, 8)
        Me.TxtFrom.MaxValue = CType(2500, Short)
        Me.TxtFrom.MinValue = CType(1800, Short)
        Me.TxtFrom.Name = "TxtFrom"
        Me.TxtFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtFrom.Sal_Mali = Nothing
        Me.TxtFrom.ShowButton = True
        Me.TxtFrom.Size = New System.Drawing.Size(120, 23)
        Me.TxtFrom.TabIndex = 0
        Me.TxtFrom.VisualStyle = False
        '
        'TxtTo
        '
        Me.TxtTo.BackColor = System.Drawing.SystemColors.Info
        Me.TxtTo.BorderColor = System.Drawing.Color.Empty
        Me.TxtTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTo.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtTo.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtTo.EditableSal = True
        Me.TxtTo.Image = CType(resources.GetObject("TxtTo.Image"), System.Drawing.Image)
        Me.TxtTo.Location = New System.Drawing.Point(328, 8)
        Me.TxtTo.MaxValue = CType(2500, Short)
        Me.TxtTo.MinValue = CType(1800, Short)
        Me.TxtTo.Name = "TxtTo"
        Me.TxtTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtTo.Sal_Mali = Nothing
        Me.TxtTo.ShowButton = True
        Me.TxtTo.Size = New System.Drawing.Size(120, 23)
        Me.TxtTo.TabIndex = 1
        Me.TxtTo.VisualStyle = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(237, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Sold To"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Sold From"
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(24, 224)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.TabIndex = 10
        Me.CmdOk.Text = "Find"
        '
        'CmdCancel
        '
        Me.CmdCancel.Location = New System.Drawing.Point(440, 224)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.TabIndex = 11
        Me.CmdCancel.Text = "Quit"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT 1 AS selected, service_center_dtl.cod_select, SUM(service_center_dtl.qty) " & _
        "AS qtySold, SUM(service_center_dtl.qty) AS qtyOrder, inv_item.desc_item, inv_ite" & _
        "m_cost_transaction.cost, inv_item_cost_transaction.fet, inv_tab_brand.cod_brand," & _
        " inv_tab_brand.complete_desc_brand, inv_tab_line.line, inv_tab_item_warehouse.on" & _
        "_hand FROM service_center_head INNER JOIN service_center_dtl ON service_center_h" & _
        "ead.id_service_center = service_center_dtl.id_service_center INNER JOIN inv_item" & _
        " ON service_center_dtl.cod_select = inv_item.item_no INNER JOIN inv_item_cost_tr" & _
        "ansaction ON inv_item.item_no = inv_item_cost_transaction.item_no INNER JOIN inv" & _
        "_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN inv_tab_brand ON inv_t" & _
        "ab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN inv_tab_item_warehouse ON" & _
        " inv_item.item_no = inv_tab_item_warehouse.item_no WHERE (service_center_dtl.typ" & _
        "e_select = 'I') AND (service_center_head.type_of_form = 'IN') AND (inv_item_cost" & _
        "_transaction.last_flag = 1) AND (dbo.ChangeDate(service_center_head.date_refer) " & _
        ">= @FromDate) AND (dbo.ChangeDate(service_center_head.date_refer) <= @ToDate) AN" & _
        "D (inv_item.cod_item_type = @Cod_Item_type) GROUP BY service_center_dtl.cod_sele" & _
        "ct, inv_item.desc_item, inv_item_cost_transaction.cost, inv_item_cost_transactio" & _
        "n.fet, inv_tab_brand.cod_brand, inv_tab_brand.complete_desc_brand, inv_tab_line." & _
        "line, inv_tab_item_warehouse.on_hand"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FromDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ToDate", System.Data.SqlDbType.VarChar))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Item_type", System.Data.SqlDbType.VarChar, 2, "cod_item_type"))
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH;packet size=4096;user id=sa;data source=""."";persist secur" & _
        "ity info=False;initial catalog=Tiremate_01"
        '
        'DaSold
        '
        Me.DaSold.SelectCommand = Me.SqlSelectCommand1
        Me.DaSold.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Total", "Total")})})
        '
        'DaItemType
        '
        Me.DaItemType.SelectCommand = Me.SqlCommand1
        Me.DaItemType.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_type_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_item_type", "cod_item_type"), New System.Data.Common.DataColumnMapping("desc_item_type", "desc_item_type"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT cod_item_type, desc_item_type, GL_account FROM inv_tab_type_item WHERE (co" & _
        "d_item_type <> '00')"
        Me.SqlCommand1.Connection = Me.Cnn
        '
        'DaItem
        '
        Me.DaItem.SelectCommand = Me.SqlCommand2
        Me.DaItem.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("selected", "selected"), New System.Data.Common.DataColumnMapping("desc_item", "desc_item"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("cod_select", "cod_select"), New System.Data.Common.DataColumnMapping("qtyReOrder", "qtyReOrder"), New System.Data.Common.DataColumnMapping("qtyOrder", "qtyOrder"), New System.Data.Common.DataColumnMapping("complete_desc_brand", "complete_desc_brand"), New System.Data.Common.DataColumnMapping("line", "line"), New System.Data.Common.DataColumnMapping("min_stock", "min_stock"), New System.Data.Common.DataColumnMapping("on_order", "on_order")})})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "SELECT 1 AS selected, inv_item.desc_item, inv_item_cost_transaction.cost, inv_ite" & _
        "m_cost_transaction.fet, inv_tab_brand.cod_brand, inv_item_cost_transaction.item_" & _
        "no AS cod_select, inv_tab_item_warehouse.reorde AS qtyReOrder, CASE WHEN inv_tab" & _
        "_item_warehouse.reorde > 0 THEN inv_tab_item_warehouse.reorde ELSE inv_tab_item_" & _
        "warehouse.min_stock - inv_tab_item_warehouse.on_hand END AS qtyOrder, inv_tab_br" & _
        "and.complete_desc_brand, inv_tab_line.line, inv_tab_item_warehouse.min_stock, in" & _
        "v_tab_item_warehouse.on_order, inv_tab_item_warehouse.on_hand FROM inv_item INNE" & _
        "R JOIN inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction" & _
        ".item_no INNER JOIN inv_tab_line ON inv_item.line = inv_tab_line.line INNER JOIN" & _
        " inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN in" & _
        "v_tab_item_warehouse ON inv_item.item_no = inv_tab_item_warehouse.item_no WHERE " & _
        "(inv_item_cost_transaction.last_flag = 1) AND (inv_item.cod_item_type = @Cod_Ite" & _
        "m_type) AND (inv_tab_item_warehouse.on_hand < inv_tab_item_warehouse.min_stock)"
        Me.SqlCommand2.Connection = Me.Cnn
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Item_type", System.Data.SqlDbType.VarChar, 2, "cod_item_type"))
        '
        'FrmReorderPoCondition
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(526, 252)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.PnlDate)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmReorderPoCondition"
        Me.Text = "Automatic Reordering"
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DsFrmPurchaseOrderItems1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlDate.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim WithEvents my1 As FrmShowItemsForPo
    Dim WithEvents my2 As FrmShowItemsForPo2
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        my1 = New FrmShowItemsForPo
        my2 = New FrmShowItemsForPo2
        DsFrmPurchaseOrderItems1.service_center_head.Clear()
        If rdosold.Checked = True Then
            Try
                DaSold.SelectCommand.Parameters("@FromDate").Value = Mid(TxtFrom.Text, 7, 4) + "/" + Mid(TxtFrom.Text, 1, 2) + "/" + Mid(TxtFrom.Text, 4, 2)
                DaSold.SelectCommand.Parameters("@ToDate").Value = Mid(TxtTo.Text, 7, 4) + "/" + Mid(TxtTo.Text, 1, 2) + "/" + Mid(TxtTo.Text, 4, 2)
                DaSold.SelectCommand.Parameters("@Cod_Item_type").Value = CmbItemType.SelectedValue
                DaSold.Fill(my1.DsFrmPurchaseOrderItems1.service_center_head)
                If my1.DsFrmPurchaseOrderItems1.service_center_head.Rows.Count > 0 Then
                    my1.ShowDialog()
                    Me.Close()
                Else
                    CommonClass.MsgFar("No items found to match your selection")
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            Dim backupstring As String = DaItem.SelectCommand.CommandText
            Try
                'inv_tab_item_warehouse.on_hand 
                If ChkExclude.Checked = True Then
                    DaItem.SelectCommand.CommandText = backupstring + " and inv_tab_item_warehouse.on_hand >=0"
                End If
                DaItem.SelectCommand.Parameters("@Cod_Item_type").Value = CmbItemType.SelectedValue
                DaItem.Fill(my2.DsFrmPurchaseOrderItems1.inv_item)

                If my2.DsFrmPurchaseOrderItems1.inv_item.Rows.Count > 0 Then
                    my2.ShowDialog()
                    Me.Close()
                Else
                    CommonClass.MsgFar("No items found to match your selection")
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                DaItem.SelectCommand.CommandText = backupstring
            End Try
        End If
    End Sub
    Private Sub FrmReorderPoCondition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = CommonClass.PConnectionString
        DaItemType.Fill(DsFrmPurchaseOrderItems1.inv_tab_type_item)
        TxtFrom.Text = Format(Now, CommonClass.PubDateFormat)
        TxtTo.Text = Format(Now, CommonClass.PubDateFormat)
        Try
            CmbItemType.SelectedValue = "01"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub
    Private Sub rdoshortage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoshortage.CheckedChanged
        If rdoshortage.Checked = True Then
            PnlDate.Enabled = False
            ChkExclude.Enabled = True
        Else
            PnlDate.Enabled = True
            ChkExclude.Enabled = False
        End If
    End Sub
    Private Sub my2_AddThis(ByVal ItemNo As String, ByVal ThisQty As Decimal) Handles my2.AddThis
        RaiseEvent AddThis(ItemNo, ThisQty)
    End Sub

    Private Sub my1_AddThis(ByVal ItemNo As String, ByVal ThisQty As Decimal) Handles my1.AddThis
        RaiseEvent AddThis(ItemNo, ThisQty)
    End Sub
    Private Sub my1_ClearDataSet() Handles my1.ClearDataSet
        RaiseEvent ClearDataSet()
    End Sub
    Private Sub my2_ClearDataSet() Handles my2.ClearDataSet
        RaiseEvent ClearDataSet()
    End Sub
    Private Sub DaItemType_RowUpdated(ByVal sender As System.Object, ByVal e As System.Data.SqlClient.SqlRowUpdatedEventArgs) Handles DaItemType.RowUpdated

    End Sub
End Class
