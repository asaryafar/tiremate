Public Class FrmSearchPo
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
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents DaPoHead As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmSearchPo1 As UcPurchaseOrder.DSFrmSearchPo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DsFrmSearchPo1 = New UcPurchaseOrder.DSFrmSearchPo
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.DaPoHead = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmSearchPo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "Inv_purchase_order_head"
        Me.GrdDetail.DataSource = Me.DsFrmSearchPo1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>Inv_Receive_Products_head</Caption><Columns" & _
        " Collection=""true""><Column0 ID=""po_no""><Caption>Po No</Caption><TypeNameEmptyStr" & _
        "ingValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember" & _
        ">po_no</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEdi" & _
        "tType><Key>po_no</Key><Position>0</Position></Column0><Column1 ID=""cod_vendor""><" & _
        "Caption>Vendor No</Caption><DataMember>cod_vendor</DataMember><EditType>NoEdit</" & _
        "EditType><FilterEditType>TextBox</FilterEditType><Key>cod_vendor</Key><Position>" & _
        "1</Position><Width>96</Width></Column1><Column2 ID=""desc_vendor""><Caption>Vendor" & _
        " Name</Caption><DataMember>desc_vendor</DataMember><EditType>NoEdit</EditType><F" & _
        "ilterEditType>TextBox</FilterEditType><Key>desc_vendor</Key><Position>2</Positio" & _
        "n><Width>172</Width></Column2><Column3 ID=""Amount""><Caption>Amount</Caption><Dat" & _
        "aMember>Amount</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</F" & _
        "ilterEditType><FormatString>c2</FormatString><Key>Amount</Key><Position>3</Posit" & _
        "ion><Width>101</Width></Column3><Column4 ID=""qty""><Caption>qty</Caption><DataMem" & _
        "ber>qty</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEd" & _
        "itType><Key>qty</Key><Position>4</Position><Width>88</Width></Column4><Column5 I" & _
        "D=""date_po""><Caption>Date</Caption><DataMember>date_po</DataMember><EditType>NoE" & _
        "dit</EditType><FilterEditType>TextBox</FilterEditType><Key>date_po</Key><Positio" & _
        "n>5</Position></Column5></Columns><GroupCondition ID="""" /><Key>Inv_Receive_Produ" & _
        "cts_head</Key></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GrdDetail.Location = New System.Drawing.Point(0, 11)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.RecordNavigator = True
        Me.GrdDetail.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdDetail.Size = New System.Drawing.Size(702, 384)
        Me.GrdDetail.TabIndex = 26
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'DsFrmSearchPo1
        '
        Me.DsFrmSearchPo1.DataSetName = "DSFrmSearchPo"
        Me.DsFrmSearchPo1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT inv_salse_transfer_head.ID_sales_transfer, inv_salse_transfer_head.type_sa" & _
        "les_transfer, inv_salse_transfer_head.by_action, inv_salse_transfer_head.authori" & _
        "z_action, inv_salse_transfer_head.store_from, inv_salse_transfer_head.store_to, " & _
        "inv_salse_transfer_head.date_action, inv_salse_transfer_head.note, inv_salse_tra" & _
        "nsfer_head.comment, SUM(inv_sales_transfer_dtl.qty) AS qty, SUM(inv_sales_transf" & _
        "er_dtl.qty * (inv_sales_transfer_dtl.fet + inv_sales_transfer_dtl.price)) AS exc" & _
        "ost FROM inv_salse_transfer_head INNER JOIN inv_sales_transfer_dtl ON inv_salse_" & _
        "transfer_head.ID_sales_transfer = inv_sales_transfer_dtl.ID_sales_transfer WHERE" & _
        " (inv_salse_transfer_head.type_sales_transfer = @type_sales_transfer) GROUP BY i" & _
        "nv_salse_transfer_head.ID_sales_transfer, inv_salse_transfer_head.type_sales_tra" & _
        "nsfer, inv_salse_transfer_head.by_action, inv_salse_transfer_head.authoriz_actio" & _
        "n, inv_salse_transfer_head.store_from, inv_salse_transfer_head.store_to, inv_sal" & _
        "se_transfer_head.date_action, inv_salse_transfer_head.note, inv_salse_transfer_h" & _
        "ead.comment"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_sales_transfer", System.Data.SqlDbType.VarChar, 1, "type_sales_transfer"))
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=FARAJI;packet size=4096;user id=sa;data source=""."";persist securit" & _
        "y info=True;initial catalog=TireMate_05;password=5332"
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Inv_Receive_Products_head.id_receive_ref, Inv_Receive_Products_head.date_r" & _
        "eceive, Inv_Receive_Products_head.cod_vendor, Inv_Receive_Products_head.vendor_r" & _
        "ef_no, Inv_Receive_Products_head.due_date, Inv_Receive_Products_head.po_no, Inv_" & _
        "Receive_Products_head.Discount, SUM((Inv_Receive_product_dtl.cost + Inv_Receive_" & _
        "product_dtl.fet) * Inv_Receive_product_dtl.qty) AS Amount, inv_vendor.desc_vendo" & _
        "r, SUM(Inv_Receive_product_dtl.qty) AS qty FROM Inv_Receive_Products_head LEFT O" & _
        "UTER JOIN Inv_Receive_product_dtl ON Inv_Receive_Products_head.id_receive_ref = " & _
        "Inv_Receive_product_dtl.id_receive_ref LEFT OUTER JOIN inv_vendor ON Inv_Receive" & _
        "_Products_head.cod_vendor = inv_vendor.cod_vendor WHERE (Inv_Receive_Products_he" & _
        "ad.bill_credit = @bill_credit) GROUP BY Inv_Receive_Products_head.date_receive, " & _
        "Inv_Receive_Products_head.cod_vendor, Inv_Receive_Products_head.vendor_ref_no, I" & _
        "nv_Receive_Products_head.due_date, Inv_Receive_Products_head.po_no, Inv_Receive_" & _
        "Products_head.Discount, Inv_Receive_Products_head.id_receive_ref, inv_vendor.des" & _
        "c_vendor"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@bill_credit", System.Data.SqlDbType.VarChar, 1, "bill_credit"))
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CmdOk)
        Me.Panel2.Controls.Add(Me.CmdExit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 395)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(702, 33)
        Me.Panel2.TabIndex = 27
        '
        'CmdOk
        '
        Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmdOk.ForeColor = System.Drawing.Color.Black
        Me.CmdOk.Location = New System.Drawing.Point(520, 5)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 24)
        Me.CmdOk.TabIndex = 22
        Me.CmdOk.Text = "Ok"
        '
        'CmdExit
        '
        Me.CmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmdExit.ForeColor = System.Drawing.Color.Black
        Me.CmdExit.Location = New System.Drawing.Point(616, 5)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 24)
        Me.CmdExit.TabIndex = 21
        Me.CmdExit.Text = "Exit"
        '
        'DaPoHead
        '
        Me.DaPoHead.SelectCommand = Me.SqlCommand1
        Me.DaPoHead.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_purchase_order_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("date_po", "date_po"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("shipto_store_no", "shipto_store_no"), New System.Data.Common.DataColumnMapping("shipto_cod_customer", "shipto_cod_customer"), New System.Data.Common.DataColumnMapping("buyer_id", "buyer_id"), New System.Data.Common.DataColumnMapping("house_comments", "house_comments"), New System.Data.Common.DataColumnMapping("vend_comments", "vend_comments")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT Inv_purchase_order_head.po_no, Inv_purchase_order_head.date_po, Inv_purcha" & _
        "se_order_head.cod_vendor, SUM((Inv_purchase_order_dtl.cost + Inv_purchase_order_" & _
        "dtl.fet) * Inv_purchase_order_dtl.qty) AS Amount, inv_vendor.desc_vendor, SUM(In" & _
        "v_purchase_order_dtl.qty) AS qty FROM Inv_purchase_order_head INNER JOIN Inv_pur" & _
        "chase_order_dtl ON Inv_purchase_order_head.po_no = Inv_purchase_order_dtl.po_no " & _
        "INNER JOIN inv_vendor ON Inv_purchase_order_head.cod_vendor = inv_vendor.cod_ven" & _
        "dor GROUP BY Inv_purchase_order_head.po_no, Inv_purchase_order_head.date_po, Inv" & _
        "_purchase_order_head.cod_vendor, inv_vendor.desc_vendor"
        Me.SqlCommand1.Connection = Me.Cnn
        '
        'FrmSearchPo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(702, 428)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmSearchPo"
        Me.Text = "Find Purchase Order"
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmSearchPo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Event PoFind(ByVal ThisId As String)
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Try
            If GrdDetail.RowCount > 0 Then
                RaiseEvent PoFind(GrdDetail.GetRow.Cells(0).Value & "")
                Me.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        Try
            If GrdDetail.RowCount > 0 Then
                RaiseEvent PoFind(GrdDetail.GetRow.Cells(0).Value & "")
                Me.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
    Private Sub FrmSearchPo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = CommonClass.PConnectionString
        DaPoHead.Fill(DsFrmSearchPo1)
    End Sub

    Private Sub GrdDetail_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GrdDetail.FormattingRow

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Cnn_InfoMessage(ByVal sender As System.Object, ByVal e As System.Data.SqlClient.SqlInfoMessageEventArgs) Handles Cnn.InfoMessage

    End Sub
End Class
