Imports CommonClass
Public Class FrmQtyFromTransactions
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmdOk As System.Windows.Forms.Button
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DaInvAdjustment As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsCorrectItemQty1 As Convert.DSCorrectItemQty
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaReceipt As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DaReturn As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Pb1 As System.Windows.Forms.ProgressBar
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaInvSaleTransfer As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaServiceCenter As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaInvItemWareHouse As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DaCommitedQty As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents cmdgeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GL_account_adjustment_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Gl_account_adjustmentHead As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmdOk = New System.Windows.Forms.Button
        Me.CmdCancel = New System.Windows.Forms.Button
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DaInvAdjustment = New System.Data.SqlClient.SqlDataAdapter
        Me.DsCorrectItemQty1 = New Convert.DSCorrectItemQty
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DaReceipt = New System.Data.SqlClient.SqlDataAdapter
        Me.DaReturn = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Pb1 = New System.Windows.Forms.ProgressBar
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DaInvSaleTransfer = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DaServiceCenter = New System.Data.SqlClient.SqlDataAdapter
        Me.Label2 = New System.Windows.Forms.Label
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaInvItemWareHouse = New System.Data.SqlClient.SqlDataAdapter
        Me.DaCommitedQty = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.cmdgeneral = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.GL_account_adjustment_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.Gl_account_adjustmentHead = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Panel4.SuspendLayout()
        CType(Me.DsCorrectItemQty1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(422, 40)
        Me.Panel4.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Correct of On Hand Items and Commited From All Transaction"
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(8, 122)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.TabIndex = 8
        Me.CmdOk.Text = "Ok"
        '
        'CmdCancel
        '
        Me.CmdCancel.Location = New System.Drawing.Point(344, 122)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.TabIndex = 9
        Me.CmdCancel.Text = "Cancel"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT item_no, SUM(QTY) AS Qty FROM inv_adjustment_dtl GROUP BY item_no"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEHXP;packet size=4096;user id=SA;data source=""."";persist sec" & _
        "urity info=True;initial catalog=TireMate_01"
        '
        'DaInvAdjustment
        '
        Me.DaInvAdjustment.SelectCommand = Me.SqlSelectCommand1
        Me.DaInvAdjustment.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_adjustment_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("referID_adjustment", "referID_adjustment"), New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("QTY", "QTY"), New System.Data.Common.DataColumnMapping("Cost", "Cost"), New System.Data.Common.DataColumnMapping("fet", "fet")})})
        '
        'DsCorrectItemQty1
        '
        Me.DsCorrectItemQty1.DataSetName = "DSCorrectItemQty"
        Me.DsCorrectItemQty1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Inv_Receive_product_dtl.item_no, SUM(Inv_Receive_product_dtl.qty) AS qty F" & _
        "ROM Inv_Receive_product_dtl INNER JOIN Inv_Receive_Products_head ON Inv_Receive_" & _
        "product_dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref WHERE (Inv" & _
        "_Receive_Products_head.bill_credit = '1') GROUP BY Inv_Receive_product_dtl.item_" & _
        "no"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DaReceipt
        '
        Me.DaReceipt.SelectCommand = Me.SqlSelectCommand2
        Me.DaReceipt.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Receipt", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("qty", "qty")})})
        '
        'DaReturn
        '
        Me.DaReturn.SelectCommand = Me.SqlCommand1
        Me.DaReturn.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Return", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("qty", "qty")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT Inv_Receive_product_dtl.item_no, SUM(Inv_Receive_product_dtl.qty) AS qty F" & _
        "ROM Inv_Receive_product_dtl INNER JOIN Inv_Receive_Products_head ON Inv_Receive_" & _
        "product_dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref WHERE (Inv" & _
        "_Receive_Products_head.bill_credit = '2') GROUP BY Inv_Receive_product_dtl.item_" & _
        "no"
        Me.SqlCommand1.Connection = Me.Cnn
        '
        'Pb1
        '
        Me.Pb1.Location = New System.Drawing.Point(6, 90)
        Me.Pb1.Name = "Pb1"
        Me.Pb1.Size = New System.Drawing.Size(410, 16)
        Me.Pb1.TabIndex = 10
        Me.Pb1.Visible = False
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT inv_sales_transfer_dtl.item_no, SUM(inv_sales_transfer_dtl.qty) AS Qty FRO" & _
        "M inv_sales_transfer_dtl INNER JOIN inv_salse_transfer_head ON inv_sales_transfe" & _
        "r_dtl.ID_sales_transfer = inv_salse_transfer_head.ID_sales_transfer GROUP BY inv" & _
        "_sales_transfer_dtl.item_no"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DaInvSaleTransfer
        '
        Me.DaInvSaleTransfer.SelectCommand = Me.SqlSelectCommand3
        Me.DaInvSaleTransfer.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_sales_transfer_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_sales_transfer", "ID_sales_transfer"), New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT ISNULL(service_center_dtl.cod_select, '') AS cod_select, SUM(ISNULL(servic" & _
        "e_center_dtl.qty, 0)) AS qty FROM service_center_dtl INNER JOIN service_center_h" & _
        "ead ON service_center_dtl.id_service_center = service_center_head.id_service_cen" & _
        "ter WHERE (service_center_head.type_of_form IN ('IN', 'RT')) AND (NOT (service_c" & _
        "enter_dtl.cod_select IS NULL)) AND (service_center_dtl.type_select <> 'O') GROUP" & _
        " BY service_center_dtl.cod_select"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'DaServiceCenter
        '
        Me.DaServiceCenter.SelectCommand = Me.SqlSelectCommand4
        Me.DaServiceCenter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("type_select", "type_select"), New System.Data.Common.DataColumnMapping("cod_select", "cod_select"), New System.Data.Common.DataColumnMapping("desc_radif", "desc_radif"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("cod_technician", "cod_technician"), New System.Data.Common.DataColumnMapping("COMMENT_ARTICLE", "COMMENT_ARTICLE"), New System.Data.Common.DataColumnMapping("AVERAGE_COST", "AVERAGE_COST")})})
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(408, 32)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Attention : at running time of this program please exit all user from syste"
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT item_no, cod_warehouse, on_hand, Begining_Balance_Qty, cod_location, comit" & _
        "ted, on_order, min_stock, max_stock, reorde FROM inv_tab_item_warehouse"
        Me.SqlSelectCommand6.Connection = Me.Cnn
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO inv_tab_item_warehouse(item_no, cod_warehouse, cod_location, on_hand," & _
        " comitted, on_order, min_stock, max_stock, reorde, Begining_Balance_Qty) VALUES " & _
        "(@item_no, @cod_warehouse, @cod_location, @on_hand, @comitted, @on_order, @min_s" & _
        "tock, @max_stock, @reorde, @Begining_Balance_Qty); SELECT item_no, cod_warehouse" & _
        ", cod_location, on_hand, comitted, on_order, min_stock, max_stock, reorde, Begin" & _
        "ing_Balance_Qty FROM inv_tab_item_warehouse WHERE (cod_warehouse = @cod_warehous" & _
        "e) AND (item_no = @item_no)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_warehouse", System.Data.SqlDbType.VarChar, 1, "cod_warehouse"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_location", System.Data.SqlDbType.VarChar, 6, "cod_location"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@on_hand", System.Data.SqlDbType.Real, 4, "on_hand"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@comitted", System.Data.SqlDbType.Real, 4, "comitted"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@on_order", System.Data.SqlDbType.Real, 4, "on_order"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@min_stock", System.Data.SqlDbType.Real, 4, "min_stock"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@max_stock", System.Data.SqlDbType.Real, 4, "max_stock"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@reorde", System.Data.SqlDbType.Real, 4, "reorde"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Begining_Balance_Qty", System.Data.SqlDbType.Real, 4, "Begining_Balance_Qty"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE inv_tab_item_warehouse SET item_no = @item_no, cod_warehouse = @cod_wareho" & _
        "use, cod_location = @cod_location, on_hand = @on_hand, comitted = @comitted, on_" & _
        "order = @on_order, min_stock = @min_stock, max_stock = @max_stock, reorde = @reo" & _
        "rde, Begining_Balance_Qty = @Begining_Balance_Qty WHERE (cod_warehouse = @Origin" & _
        "al_cod_warehouse) AND (item_no = @Original_item_no) AND (Begining_Balance_Qty = " & _
        "@Original_Begining_Balance_Qty OR @Original_Begining_Balance_Qty IS NULL AND Beg" & _
        "ining_Balance_Qty IS NULL) AND (cod_location = @Original_cod_location OR @Origin" & _
        "al_cod_location IS NULL AND cod_location IS NULL) AND (comitted = @Original_comi" & _
        "tted OR @Original_comitted IS NULL AND comitted IS NULL) AND (max_stock = @Origi" & _
        "nal_max_stock OR @Original_max_stock IS NULL AND max_stock IS NULL) AND (min_sto" & _
        "ck = @Original_min_stock OR @Original_min_stock IS NULL AND min_stock IS NULL) A" & _
        "ND (on_hand = @Original_on_hand OR @Original_on_hand IS NULL AND on_hand IS NULL" & _
        ") AND (on_order = @Original_on_order OR @Original_on_order IS NULL AND on_order " & _
        "IS NULL) AND (reorde = @Original_reorde OR @Original_reorde IS NULL AND reorde I" & _
        "S NULL); SELECT item_no, cod_warehouse, cod_location, on_hand, comitted, on_orde" & _
        "r, min_stock, max_stock, reorde, Begining_Balance_Qty FROM inv_tab_item_warehous" & _
        "e WHERE (cod_warehouse = @cod_warehouse) AND (item_no = @item_no)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_warehouse", System.Data.SqlDbType.VarChar, 1, "cod_warehouse"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_location", System.Data.SqlDbType.VarChar, 6, "cod_location"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@on_hand", System.Data.SqlDbType.Real, 4, "on_hand"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@comitted", System.Data.SqlDbType.Real, 4, "comitted"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@on_order", System.Data.SqlDbType.Real, 4, "on_order"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@min_stock", System.Data.SqlDbType.Real, 4, "min_stock"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@max_stock", System.Data.SqlDbType.Real, 4, "max_stock"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@reorde", System.Data.SqlDbType.Real, 4, "reorde"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Begining_Balance_Qty", System.Data.SqlDbType.Real, 4, "Begining_Balance_Qty"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_warehouse", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_warehouse", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Begining_Balance_Qty", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Begining_Balance_Qty", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_location", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_location", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_comitted", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "comitted", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_max_stock", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "max_stock", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_min_stock", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "min_stock", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_on_hand", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "on_hand", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_on_order", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "on_order", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_reorde", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "reorde", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM inv_tab_item_warehouse WHERE (cod_warehouse = @Original_cod_warehouse" & _
        ") AND (item_no = @Original_item_no) AND (Begining_Balance_Qty = @Original_Begini" & _
        "ng_Balance_Qty OR @Original_Begining_Balance_Qty IS NULL AND Begining_Balance_Qt" & _
        "y IS NULL) AND (cod_location = @Original_cod_location OR @Original_cod_location " & _
        "IS NULL AND cod_location IS NULL) AND (comitted = @Original_comitted OR @Origina" & _
        "l_comitted IS NULL AND comitted IS NULL) AND (max_stock = @Original_max_stock OR" & _
        " @Original_max_stock IS NULL AND max_stock IS NULL) AND (min_stock = @Original_m" & _
        "in_stock OR @Original_min_stock IS NULL AND min_stock IS NULL) AND (on_hand = @O" & _
        "riginal_on_hand OR @Original_on_hand IS NULL AND on_hand IS NULL) AND (on_order " & _
        "= @Original_on_order OR @Original_on_order IS NULL AND on_order IS NULL) AND (re" & _
        "orde = @Original_reorde OR @Original_reorde IS NULL AND reorde IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_warehouse", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_warehouse", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Begining_Balance_Qty", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Begining_Balance_Qty", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_location", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_location", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_comitted", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "comitted", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_max_stock", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "max_stock", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_min_stock", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "min_stock", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_on_hand", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "on_hand", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_on_order", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "on_order", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_reorde", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "reorde", System.Data.DataRowVersion.Original, Nothing))
        '
        'DaInvItemWareHouse
        '
        Me.DaInvItemWareHouse.DeleteCommand = Me.SqlDeleteCommand1
        Me.DaInvItemWareHouse.InsertCommand = Me.SqlInsertCommand1
        Me.DaInvItemWareHouse.SelectCommand = Me.SqlSelectCommand6
        Me.DaInvItemWareHouse.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_item_warehouse", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("cod_warehouse", "cod_warehouse"), New System.Data.Common.DataColumnMapping("cod_location", "cod_location"), New System.Data.Common.DataColumnMapping("on_hand", "on_hand"), New System.Data.Common.DataColumnMapping("comitted", "comitted"), New System.Data.Common.DataColumnMapping("on_order", "on_order"), New System.Data.Common.DataColumnMapping("min_stock", "min_stock"), New System.Data.Common.DataColumnMapping("max_stock", "max_stock"), New System.Data.Common.DataColumnMapping("reorde", "reorde"), New System.Data.Common.DataColumnMapping("Begining_Balance_Qty", "Begining_Balance_Qty")})})
        Me.DaInvItemWareHouse.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DaCommitedQty
        '
        Me.DaCommitedQty.SelectCommand = Me.SqlCommand2
        Me.DaCommitedQty.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Receipt", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("qty", "qty")})})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "SELECT SUM(service_center_dtl.qty) AS qty, service_center_dtl.cod_select FROM ser" & _
        "vice_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_" & _
        "center = service_center_head.id_service_center WHERE (service_center_dtl.type_se" & _
        "lect = 'I') AND (service_center_dtl.id_service_center NOT IN (SELECT id_service_" & _
        "center_before FROM service_center_head WHERE id_service_center_before IS NOT NUL" & _
        "L)) AND (service_center_head.type_of_form = 'WO') GROUP BY service_center_dtl.co" & _
        "d_select"
        Me.SqlCommand2.Connection = Me.Cnn
        '
        'cmdgeneral
        '
        Me.cmdgeneral.Connection = Me.Cnn
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT GL_account_adjustment_dtl.refrence_no, SUM(ROUND(GL_account_adjustment_dtl" & _
        ".amount_adjustment, 2)) AS sum1 FROM GL_account_adjustment_dtl INNER JOIN GL_acc" & _
        "ount_adjustment_head ON GL_account_adjustment_dtl.refrence_no = GL_account_adjus" & _
        "tment_head.refrence_no WHERE (GL_account_adjustment_head.finance_charge_flag = 1" & _
        ") GROUP BY GL_account_adjustment_dtl.refrence_no"
        Me.SqlSelectCommand7.Connection = Me.Cnn
        '
        'GL_account_adjustment_dtl
        '
        Me.GL_account_adjustment_dtl.SelectCommand = Me.SqlSelectCommand7
        Me.GL_account_adjustment_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_adjustment_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("amount_adjustment", "amount_adjustment")})})
        '
        'Gl_account_adjustmentHead
        '
        Me.Gl_account_adjustmentHead.SelectCommand = Me.SqlCommand3
        Me.Gl_account_adjustmentHead.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_adjustment_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("amount_adjustment", "amount_adjustment")})})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT refrence_no FROM GL_account_adjustment_head WHERE (finance_charge_flag = 1" & _
        ")"
        Me.SqlCommand3.Connection = Me.Cnn
        '
        'FrmQtyFromTransactions
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(422, 148)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Pb1)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmQtyFromTransactions"
        Me.Panel4.ResumeLayout(False)
        CType(Me.DsCorrectItemQty1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim CancelProcess As Boolean = False
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click

        Dim i As Decimal
        Dim p As DSCorrectItemQty
        Dim item As String
        Dim qty As Decimal
        Dim Commit As Double
        p = DsCorrectItemQty1
        Try
            DsCorrectItemQty1.Clear()
            DaInvItemWareHouse.Fill(DsCorrectItemQty1)
            Pb1.Maximum = DsCorrectItemQty1.inv_tab_item_warehouse.Rows.Count + 2
            Pb1.Minimum = 0
            Pb1.Value = 1
            Pb1.Visible = True
            DaInvAdjustment.Fill(DsCorrectItemQty1)
            '  DaInvSaleTransfer.SelectCommand.Parameters(0).Value = PubStoreNO
            DaInvSaleTransfer.Fill(DsCorrectItemQty1)
            DaReceipt.Fill(DsCorrectItemQty1)
            DaReturn.Fill(DsCorrectItemQty1)
            DaServiceCenter.Fill(DsCorrectItemQty1)
            DaCommitedQty.Fill(DsCorrectItemQty1.CommitedQty)
            With DsCorrectItemQty1
                For i = 0 To .inv_tab_item_warehouse.Rows.Count - 1
                    If CancelProcess Then Exit For
                    Pb1.Value = i
                    item = .inv_tab_item_warehouse.Rows(i).Item("Item_no")
                    'If Trim(item).ToUpper = "n9-29".ToUpper Then
                    '    ' MsgBox("1")
                    'End If
                    qty = Val(.inv_tab_item_warehouse.Rows(i).Item("Begining_Balance_Qty") & "")

                    Pb1.Text = item
                    Dim dr1 As DSCorrectItemQty.inv_adjustment_dtlRow = .inv_adjustment_dtl.FindByitem_no(item)
                    If Not dr1 Is Nothing Then
                        qty = Val(dr1.Qty & "") + qty
                    End If

                    Dim dr2 As DSCorrectItemQty.inv_sales_transfer_dtlRow = p.inv_sales_transfer_dtl.FindByitem_no(item)
                    If Not dr2 Is Nothing Then
                        qty = qty - Val("0" & dr2.Qty)
                    End If

                    Dim dr3 As DSCorrectItemQty.ReceiptRow = p.Receipt.FindByitem_no(item)
                    If Not dr3 Is Nothing Then
                        qty = Val("0" & dr3.qty) + qty
                    End If

                    Dim dr4 As DSCorrectItemQty._ReturnRow = p._Return.FindByitem_no(item)
                    If Not dr4 Is Nothing Then
                        qty = qty - Val("0" & dr4.qty)
                    End If

                    Dim dr5 As DSCorrectItemQty.service_center_dtlRow = p.service_center_dtl.FindBycod_select(item)
                    If Not dr5 Is Nothing Then
                        qty = qty - Val("0" & dr5.qty)
                    End If
                    .inv_tab_item_warehouse.Rows(i).Item("on_hand") = qty

                    Dim dr6 As DSCorrectItemQty.CommitedQtyRow = p.CommitedQty.FindBycod_select(item)
                    If Not dr6 Is Nothing Then
                        Commit = Val("0" & dr6.qty)
                    Else
                        Commit = 0
                    End If
                    .inv_tab_item_warehouse.Rows(i).Item("comitted") = Commit
                Next
                DaInvItemWareHouse.Update(.inv_tab_item_warehouse)
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Pb1.Visible = False
        CancelProcess = False
        '------------------------------------

        '------------------------------------'

        '------------------------------------'
        MsgFar("Update Completed")

    End Sub
    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        CancelProcess = True
        Me.Close()
    End Sub
    Private Sub FrmQtyFromTransactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        If cmdgeneral.Connection.State <> ConnectionState.Open Then
            cmdgeneral.Connection.Open()
        End If



        Try
            cmdgeneral.CommandText = " alter table inv_tab_item_warehouse add Begining_Balance_Qty Real "
            cmdgeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        cmdgeneral.CommandText = "INSERT INTO inv_tab_item_warehouse " & _
                             "(item_no, cod_warehouse, cod_location, Begining_Balance_Qty) " & _
                              " SELECT     item_no, 1 AS cod_warehouse, 0 AS cod_location, 0 AS begining_balance_qty" & _
                              " FROM         inv_item " & _
                              " WHERE     (item_no NOT IN" & _
                              " (SELECT     item_no " & _
                              " FROM         inv_tab_item_warehouse)) "
        Try
            cmdgeneral.ExecuteNonQuery()
            cmdgeneral.CommandText = " UPDATE  inv_tab_item_warehouse set Begining_Balance_Qty = 0 WHERE (Begining_Balance_Qty IS NULL)"
            cmdgeneral.ExecuteNonQuery()
            Try
                cmdgeneral.CommandText = " ALTER TABLE [dbo].[inv_tab_item_warehouse] ADD CONSTRAINT [DF_inv_tab_item_warehouse_Begining_Balance_Qty] DEFAULT (0) FOR [Begining_Balance_Qty]"
                cmdgeneral.ExecuteNonQuery()
            Catch ex As Exception
            End Try
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmdgeneral.Connection.Close()
        End Try

        DaInvItemWareHouse.Fill(DsCorrectItemQty1)
    End Sub
    Sub FixZipCode() 'Cascade update
        'Call AlterTable("cust_company", "FK_cust_company_bas_zipcode", "zip_code", False)
        'Call AlterTable("cust_trtab_main", "FK_cust_trtab_main_bas_zipcode", "zip", False)
        'Call AlterTable("employee", "FK_employee_bas_zipcode", "zipcode", False)
        'Call AlterTable("inv_vendor", "FK_inv_vendor_bas_zipcode", "zipcode", False)
        'cmdgeneral.CommandText = "UPDATE    bas_zipcode   SET    zipcode = '0' + zipcode    WHERE     (LEN(zipcode) = 4)"

        'If cmdgeneral.Connection.State <> ConnectionState.Open Then
        '    cmdgeneral.Connection.Open()
        'End If

        'Try
        '    cmdgeneral.ExecuteNonQuery()
        'Catch ex As Exception
        'End Try

        'cmdgeneral.CommandText = "UPDATE    bas_zipcode   SET    zipcode = '00' + zipcode    WHERE     (LEN(zipcode) = 3)"
        'Try
        '    cmdgeneral.ExecuteNonQuery()
        'Catch ex As Exception
        'End Try
    End Sub
    Sub AlterTable(ByVal ThisTableName As String, ByVal ThisConstrantName As String, ByVal fieldname As String, ByVal OnDeleteCasCade As Boolean)
        'Dim Str1 As String = " ALTER TABLE [dbo].[" & ThisTableName.Trim & "] Drop CONSTRAINT [" & ThisConstrantName.Trim & "]"
        'Dim Str2 As String = "ALTER TABLE [dbo].[" & ThisTableName.Trim & "] ADD CONSTRAINT [" & ThisConstrantName.Trim & "] FOREIGN KEY ([" & fieldname & "]) REFERENCES [dbo].[bas_zipcode] ([zipcode]) " & IIf(OnDeleteCasCade, " ON DELETE CASCADE ", " ") & " ON UPDATE CASCADE "
        'If cmdgeneral.Connection.State <> ConnectionState.Open Then
        '    cmdgeneral.Connection.Open()
        'End If
        'Try
        '    Try
        '        cmdgeneral.CommandText = Str1
        '        cmdgeneral.ExecuteNonQuery()
        '    Catch ex As Exception
        '    End Try
        '    '-------------------------
        '    cmdgeneral.CommandText = Str2
        '    cmdgeneral.ExecuteNonQuery()
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
    End Sub

End Class
