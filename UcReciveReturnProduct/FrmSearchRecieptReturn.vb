Public Class FrmSearchRecieptReturn
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
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents DaInv_Receive_Products_head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmSearchReceiveReturn1 As UcReceiveReturnProduct.DSFrmSearchReceiveReturn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DsFrmSearchReceiveReturn1 = New UcReceiveReturnProduct.DSFrmSearchReceiveReturn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.DaInv_Receive_Products_head = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmSearchReceiveReturn1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=armandehxp;persi" & _
        "st security info=True;initial catalog=TireMate_01"
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "Inv_Receive_Products_head"
        Me.GrdDetail.DataSource = Me.DsFrmSearchReceiveReturn1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>Inv_Receive_Products_head</Caption><Columns" & _
        " Collection=""true""><Column0 ID=""id_receive_ref""><Caption>Ref No</Caption><TypeNa" & _
        "meEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><" & _
        "DataMember>id_receive_ref</DataMember><EditType>NoEdit</EditType><FilterEditType" & _
        ">TextBox</FilterEditType><Key>id_receive_ref</Key><Position>0</Position><Width>8" & _
        "1</Width></Column0><Column1 ID=""cod_vendor""><Caption>Vendor No</Caption><TypeNam" & _
        "eEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><D" & _
        "ataMember>cod_vendor</DataMember><EditType>NoEdit</EditType><FilterEditType>Text" & _
        "Box</FilterEditType><Key>cod_vendor</Key><Position>1</Position><Width>76</Width>" & _
        "</Column1><Column2 ID=""desc_vendor""><Caption>Vendor Name</Caption><DataMember>de" & _
        "sc_vendor</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filter" & _
        "EditType><Key>desc_vendor</Key><Position>2</Position><Width>199</Width></Column2" & _
        "><Column3 ID=""Amount""><Caption>Amount</Caption><DataMember>Amount</DataMember><E" & _
        "ditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c" & _
        "2</FormatString><Key>Amount</Key><Position>3</Position><Width>88</Width></Column" & _
        "3><Column4 ID=""qty""><Caption>QTY</Caption><DataMember>qty</DataMember><EditType>" & _
        "NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>qty</Key><Position" & _
        ">4</Position><Width>64</Width></Column4><Column5 ID=""date_receive""><Caption>Date" & _
        "</Caption><DataMember>date_receive</DataMember><EditType>NoEdit</EditType><Filte" & _
        "rEditType>TextBox</FilterEditType><Key>date_receive</Key><Position>5</Position><" & _
        "Width>76</Width></Column5><Column6 ID=""vendor_ref_no""><Caption>Vendor Ref</Capti" & _
        "on><DataMember>vendor_ref_no</DataMember><EditType>NoEdit</EditType><FilterEditT" & _
        "ype>TextBox</FilterEditType><Key>vendor_ref_no</Key><Position>6</Position><Width" & _
        ">79</Width></Column6><Column7 ID=""due_date""><Caption>Due Date</Caption><DataMemb" & _
        "er>due_date</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filt" & _
        "erEditType><Key>due_date</Key><Position>7</Position><Width>79</Width></Column7><" & _
        "Column8 ID=""po_no""><Caption>Purchase Order</Caption><DataMember>po_no</DataMembe" & _
        "r><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>po_no<" & _
        "/Key><Position>8</Position></Column8></Columns><GroupCondition ID="""" /><Key>Inv_" & _
        "Receive_Products_head</Key></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GrdDetail.Location = New System.Drawing.Point(0, 3)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.RecordNavigator = True
        Me.GrdDetail.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdDetail.Size = New System.Drawing.Size(750, 368)
        Me.GrdDetail.TabIndex = 24
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'DsFrmSearchReceiveReturn1
        '
        Me.DsFrmSearchReceiveReturn1.DataSetName = "DSFrmSearchReceiveReturn"
        Me.DsFrmSearchReceiveReturn1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CmdOk)
        Me.Panel2.Controls.Add(Me.CmdExit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 371)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(750, 33)
        Me.Panel2.TabIndex = 25
        '
        'CmdOk
        '
        Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmdOk.ForeColor = System.Drawing.Color.Black
        Me.CmdOk.Location = New System.Drawing.Point(568, 5)
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
        Me.CmdExit.Location = New System.Drawing.Point(664, 5)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 24)
        Me.CmdExit.TabIndex = 21
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
        'FrmSearchRecieptReturn
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(750, 404)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmSearchRecieptReturn"
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmSearchReceiveReturn1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private MBillCredit As String = "1"
    Public Event ReceiveReterunFind(ByVal ThisId As String)
    Public Property BillCredit() As String
        Get
            Return MBillCredit
        End Get
        Set(ByVal Value As String)
            MBillCredit = Value
        End Set
    End Property
    Private Sub FrmSearchInterStoreSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = CommonClass.PConnectionString
        DaInv_Receive_Products_head.SelectCommand.Parameters(0).Value = MBillCredit
        DaInv_Receive_Products_head.Fill(DsFrmSearchReceiveReturn1)
        Call SetBillCredit()
    End Sub
    Sub SetBillCredit()
        Select Case BillCredit
            Case "1"
                Me.Text = "Find Inventory Receipt "
            Case "2"
                Me.Text = "Find Inventory Return "
                GrdDetail.RootTable.Columns(7).Visible = False
                GrdDetail.RootTable.Columns(8).Visible = False
        End Select
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Try
            If GrdDetail.RowCount > 0 Then
                RaiseEvent ReceiveReterunFind(GrdDetail.GetRow.Cells(0).Value & "")
                Me.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        Try
            If GrdDetail.RowCount > 0 Then
                RaiseEvent ReceiveReterunFind(GrdDetail.GetRow.Cells(0).Value & "")
                Me.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
End Class
