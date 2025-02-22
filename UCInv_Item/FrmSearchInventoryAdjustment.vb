Public Class FrmSearchInventoryAdjustment
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
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents DAinv_adjustment_head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmSearchInvAdjustment1 As UCInv_Item.DSFrmSearchInvAdjustment
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DsFrmSearchInvAdjustment1 = New UCInv_Item.DSFrmSearchInvAdjustment
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.DAinv_adjustment_head = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmSearchInvAdjustment1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=TireMate_01"
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
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "inv_adjustment_head"
        Me.GrdDetail.DataSource = Me.DsFrmSearchInvAdjustment1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>inv_adjustment_head</Caption><Columns Colle" & _
        "ction=""true""><Column0 ID=""referID_adjustment""><Caption>Ref No</Caption><TypeName" & _
        "EmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><Da" & _
        "taMember>referID_adjustment</DataMember><EditType>NoEdit</EditType><FilterEditTy" & _
        "pe>TextBox</FilterEditType><Key>referID_adjustment</Key><Position>0</Position></" & _
        "Column0><Column1 ID=""EmployeName""><Caption>By</Caption><DataMember>EmployeName</" & _
        "DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><K" & _
        "ey>EmployeName</Key><Position>1</Position><Width>109</Width></Column1><Column2 I" & _
        "D=""DeliveryReciept""><Caption>DR #</Caption><DataMember>DeliveryReciept</DataMemb" & _
        "er><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>Deliv" & _
        "eryReciept</Key><Position>2</Position></Column2><Column3 ID=""NationalAccount""><C" & _
        "aption>NA #</Caption><DataMember>NationalAccount</DataMember><EditType>NoEdit</E" & _
        "ditType><FilterEditType>TextBox</FilterEditType><Key>NationalAccount</Key><Posit" & _
        "ion>3</Position></Column3><Column4 ID=""cod_vendor""><Caption>Vendor</Caption><Dat" & _
        "aMember>cod_vendor</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBo" & _
        "x</FilterEditType><Key>cod_vendor</Key><Position>4</Position><Width>64</Width></" & _
        "Column4><Column5 ID=""Amount""><Caption>Amount</Caption><DataMember>Amount</DataMe" & _
        "mber><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatS" & _
        "tring>c</FormatString><Key>Amount</Key><Position>5</Position><TextAlignment>Far<" & _
        "/TextAlignment><Width>85</Width></Column5><Column6 ID=""qty""><Caption>qty</Captio" & _
        "n><DataMember>Qty</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox" & _
        "</FilterEditType><Key>qty</Key><Position>6</Position><Width>65</Width></Column6>" & _
        "<Column7 ID=""date_adjustment""><Caption>Date</Caption><DataMember>date_adjustment" & _
        "</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType>" & _
        "<Key>date_adjustment</Key><Position>7</Position><Width>82</Width></Column7><Colu" & _
        "mn8 ID=""explanation""><Caption>Explanation</Caption><DataMember>explanation</Data" & _
        "Member><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>e" & _
        "xplanation</Key><Position>8</Position><Width>151</Width></Column8></Columns><Gro" & _
        "upCondition ID="""" /><Key>inv_adjustment_head</Key></RootTable></GridEXLayoutData" & _
        ">"
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
        Me.GrdDetail.Size = New System.Drawing.Size(694, 400)
        Me.GrdDetail.TabIndex = 28
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'DsFrmSearchInvAdjustment1
        '
        Me.DsFrmSearchInvAdjustment1.DataSetName = "DSFrmSearchInvAdjustment"
        Me.DsFrmSearchInvAdjustment1.Locale = New System.Globalization.CultureInfo("en-US")
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
        Me.Panel2.Location = New System.Drawing.Point(0, 403)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(694, 33)
        Me.Panel2.TabIndex = 29
        '
        'CmdOk
        '
        Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmdOk.ForeColor = System.Drawing.Color.Black
        Me.CmdOk.Location = New System.Drawing.Point(512, 5)
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
        Me.CmdExit.Location = New System.Drawing.Point(608, 5)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 24)
        Me.CmdExit.TabIndex = 21
        Me.CmdExit.Text = "Exit"
        '
        'DAinv_adjustment_head
        '
        Me.DAinv_adjustment_head.SelectCommand = Me.SqlCommand2
        Me.DAinv_adjustment_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_adjustment_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("referID_adjustment", "referID_adjustment"), New System.Data.Common.DataColumnMapping("date_adjustment", "date_adjustment"), New System.Data.Common.DataColumnMapping("adjustment_by", "adjustment_by"), New System.Data.Common.DataColumnMapping("authorized_by", "authorized_by"), New System.Data.Common.DataColumnMapping("explanation", "explanation"), New System.Data.Common.DataColumnMapping("GL_account_adjustment", "GL_account_adjustment"), New System.Data.Common.DataColumnMapping("comment", "comment")})})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "SELECT inv_adjustment_head.referID_adjustment, inv_adjustment_head.date_adjustmen" & _
        "t, inv_adjustment_head.adjustment_by, SUM(inv_adjustment_dtl.QTY) AS qty, SUM(in" & _
        "v_adjustment_dtl.QTY * (inv_adjustment_dtl.Cost + inv_adjustment_dtl.fet)) AS Am" & _
        "ount, LTRIM(RTRIM(employee.f_name)) + ' ' + LTRIM(RTRIM(employee.l_name)) AS Emp" & _
        "loyeName, inv_adjustment_head.explanation, inv_adjustment_head.DeliveryReciept, " & _
        "inv_adjustment_head.NationalAccount, inv_adjustment_head.cod_vendor FROM inv_adj" & _
        "ustment_head LEFT OUTER JOIN employee ON inv_adjustment_head.adjustment_by = emp" & _
        "loyee.employee_code LEFT OUTER JOIN inv_adjustment_dtl ON inv_adjustment_head.re" & _
        "ferID_adjustment = inv_adjustment_dtl.referID_adjustment GROUP BY inv_adjustment" & _
        "_head.referID_adjustment, inv_adjustment_head.date_adjustment, inv_adjustment_he" & _
        "ad.adjustment_by, employee.f_name, LTRIM(RTRIM(employee.f_name)) + ' ' + LTRIM(R" & _
        "TRIM(employee.l_name)), inv_adjustment_head.explanation, inv_adjustment_head.Del" & _
        "iveryReciept, inv_adjustment_head.NationalAccount, inv_adjustment_head.cod_vendo" & _
        "r"
        Me.SqlCommand2.Connection = Me.Cnn
        '
        'FrmSearchInventoryAdjustment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(694, 436)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmSearchInventoryAdjustment"
        Me.Text = "Find Inventory Adustment"
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmSearchInvAdjustment1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Event InvAdjFind(ByVal ThisId As String)
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Try
            If GrdDetail.RowCount > 0 Then
                RaiseEvent InvAdjFind(GrdDetail.GetRow.Cells(0).Value & "")
                Me.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        Try
            If GrdDetail.RowCount > 0 Then
                RaiseEvent InvAdjFind(GrdDetail.GetRow.Cells(0).Value & "")
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
        DAinv_adjustment_head.Fill(DsFrmSearchInvAdjustment1)
    End Sub
End Class
