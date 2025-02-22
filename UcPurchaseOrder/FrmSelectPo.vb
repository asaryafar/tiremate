Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmSelectPo
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents DaPoHead As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmPurchaseOrder1 As UcPurchaseOrder.DSFrmPurchaseOrder
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    'Public WithEvents Vendor_Cod1 As UCVendor.Vendor_Cod
    Public WithEvents Vendor_Cod1 As UCVendor.Vendor_Cod
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Vendor_Cod1 = New UCVendor.Vendor_Cod
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Label6 = New System.Windows.Forms.Label
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DsFrmPurchaseOrder1 = New UcPurchaseOrder.DSFrmPurchaseOrder
        Me.DaPoHead = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.Panel1.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmPurchaseOrder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Vendor_Cod1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(0, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(616, 38)
        Me.Panel1.TabIndex = 0
        '
        'Vendor_Cod1
        '
        Me.Vendor_Cod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Vendor_Cod1.Connection = Me.Cnn
        Me.Vendor_Cod1.Location = New System.Drawing.Point(80, 8)
        Me.Vendor_Cod1.Name = "Vendor_Cod1"
        Me.Vendor_Cod1.NotExitIfNotFound = False
        Me.Vendor_Cod1.ReleaseIfNotFoundVendorCod = False
        Me.Vendor_Cod1.Size = New System.Drawing.Size(128, 21)
        Me.Vendor_Cod1.TabIndex = 3
        Me.Vendor_Cod1.VendorCod = ""
        Me.Vendor_Cod1.VendorCodLen = 6
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEHSERVER;packet size=4096;user id=sa;data source=""."";persist" & _
        " security info=True;initial catalog=TireMate_01"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 22)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Vendor"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "Inv_purchase_order_headSearch"
        Me.GrdDetail.DataSource = Me.DsFrmPurchaseOrder1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>Inv_purchase_order_head</Caption><Columns C" & _
        "ollection=""true""><Column0 ID=""po_no""><Caption>Po Number</Caption><TypeNameEmptyS" & _
        "tringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMemb" & _
        "er>po_no</DataMember><Key>po_no</Key><Position>0</Position><Width>94</Width></Co" & _
        "lumn0><Column1 ID=""date_po""><Caption>Po Date</Caption><DataMember>date_po</DataM" & _
        "ember><Key>date_po</Key><Position>1</Position><Width>101</Width></Column1><Colum" & _
        "n2 ID=""TotalAmount""><Caption>Total Amount</Caption><DataMember>TotalAmount</Data" & _
        "Member><FormatString>c2</FormatString><Key>TotalAmount</Key><Position>2</Positio" & _
        "n></Column2><Column3 ID=""Reminder""><Caption>Remainder</Caption><DataMember>Remin" & _
        "der</DataMember><EditType>NoEdit</EditType><FormatString>c2</FormatString><Key>R" & _
        "eminder</Key><Position>3</Position></Column3><Column4 ID=""Buyer""><Caption>Buyer<" & _
        "/Caption><DataMember>Buyer</DataMember><Key>Buyer</Key><Position>4</Position></C" & _
        "olumn4><Column5 ID=""house_comments""><Caption>House Comments</Caption><DataMember" & _
        ">house_comments</DataMember><Key>house_comments</Key><Position>5</Position><Widt" & _
        "h>175</Width></Column5><Column6 ID=""vend_comments""><Caption>Vendor Comments</Cap" & _
        "tion><DataMember>vend_comments</DataMember><Key>vend_comments</Key><Position>6</" & _
        "Position><Width>211</Width></Column6><Column7 ID=""Po_NoReceive""><Caption>Po_NoRe" & _
        "ceive</Caption><DataMember>Po_NoReceive</DataMember><Key>Po_NoReceive</Key><Posi" & _
        "tion>7</Position><Visible>False</Visible></Column7><Column8 ID=""TotalAmountRecei" & _
        "ve""><Caption>TotalAmountReceive</Caption><DataMember>TotalAmountReceive</DataMem" & _
        "ber><Key>TotalAmountReceive</Key><Position>8</Position><Visible>False</Visible><" & _
        "/Column8></Columns><GroupCondition ID="""" /><Key>Inv_purchase_order_head</Key></R" & _
        "ootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GrdDetail.Location = New System.Drawing.Point(0, 43)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.RecordNavigator = True
        Me.GrdDetail.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdDetail.Size = New System.Drawing.Size(926, 272)
        Me.GrdDetail.TabIndex = 3
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'DsFrmPurchaseOrder1
        '
        Me.DsFrmPurchaseOrder1.DataSetName = "DSFrmPurchaseOrder"
        Me.DsFrmPurchaseOrder1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'DaPoHead
        '
        Me.DaPoHead.SelectCommand = Me.SqlSelectCommand2
        Me.DaPoHead.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_Receive_Products_headSearch", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("date_po", "date_po"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("shipto_store_no", "shipto_store_no"), New System.Data.Common.DataColumnMapping("shipto_cod_customer", "shipto_cod_customer"), New System.Data.Common.DataColumnMapping("buyer_id", "buyer_id"), New System.Data.Common.DataColumnMapping("house_comments", "house_comments"), New System.Data.Common.DataColumnMapping("vend_comments", "vend_comments"), New System.Data.Common.DataColumnMapping("buyer", "buyer"), New System.Data.Common.DataColumnMapping("TotalAmount", "TotalAmount"), New System.Data.Common.DataColumnMapping("Po_NoReceive", "Po_NoReceive"), New System.Data.Common.DataColumnMapping("TotalAmountReceive", "TotalAmountReceive")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Inv_purchase_order_head.po_no, Inv_purchase_order_head.date_po, Inv_purcha" & _
        "se_order_head.cod_vendor, Inv_purchase_order_head.shipto_store_no, Inv_purchase_" & _
        "order_head.shipto_cod_customer, Inv_purchase_order_head.buyer_id, Inv_purchase_o" & _
        "rder_head.house_comments, Inv_purchase_order_head.vend_comments, inv_buyer.desc_" & _
        "buyer AS buyer, SUM(Inv_purchase_order_dtl.qty * Inv_purchase_order_dtl.cost) AS" & _
        " TotalAmount, View_receive_po.po_no AS Po_NoReceive, View_receive_po.totalreceiv" & _
        "e AS TotalAmountReceive FROM Inv_purchase_order_dtl LEFT OUTER JOIN View_receive" & _
        "_po ON Inv_purchase_order_dtl.po_no = View_receive_po.po_no RIGHT OUTER JOIN inv" & _
        "_buyer RIGHT OUTER JOIN Inv_purchase_order_head ON inv_buyer.buyer_id = Inv_purc" & _
        "hase_order_head.buyer_id ON Inv_purchase_order_dtl.po_no = Inv_purchase_order_he" & _
        "ad.po_no WHERE (Inv_purchase_order_head.cod_vendor = @Cod_Vendor) GROUP BY Inv_p" & _
        "urchase_order_head.po_no, Inv_purchase_order_head.date_po, Inv_purchase_order_he" & _
        "ad.cod_vendor, Inv_purchase_order_head.shipto_store_no, Inv_purchase_order_head." & _
        "shipto_cod_customer, Inv_purchase_order_head.buyer_id, Inv_purchase_order_head.h" & _
        "ouse_comments, Inv_purchase_order_head.vend_comments, inv_buyer.desc_buyer, View" & _
        "_receive_po.po_no, View_receive_po.totalreceive"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CmdOk)
        Me.Panel2.Controls.Add(Me.CmdExit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 315)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(926, 33)
        Me.Panel2.TabIndex = 22
        '
        'CmdOk
        '
        Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmdOk.ForeColor = System.Drawing.Color.Black
        Me.CmdOk.Location = New System.Drawing.Point(744, 5)
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
        Me.CmdExit.Location = New System.Drawing.Point(840, 5)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 24)
        Me.CmdExit.TabIndex = 21
        Me.CmdExit.Text = "Exit"
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'FrmSelectPo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(926, 348)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmSelectPo"
        Me.Text = "Select Purchase order"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmPurchaseOrder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Event LoadThisPo(ByVal ThisPo As String)
    Property vendore() As String
        Get
            Return Vendor_Cod1.VendorCod
        End Get
        Set(ByVal Value As String)
            Vendor_Cod1.VendorCod = Value
        End Set
    End Property
    Private Sub FrmSelectPo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        DsFrmPurchaseOrder1.Clear()
        Call FixthisDatabase()
    End Sub
    Private Sub Vendor_Cod1_FindVendorCod() Handles Vendor_Cod1.FindVendorCod
        Call FixthisDatabase()
        DsFrmPurchaseOrder1.Clear()
        DaPoHead.SelectCommand.Parameters(0).Value = Vendor_Cod1.cod_vendor
        DaPoHead.Fill(DsFrmPurchaseOrder1.Inv_purchase_order_headSearch)
        Call AddConditionalFormatting()
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        If GrdDetail.RecordCount > 0 Then
            RaiseEvent LoadThisPo(GrdDetail.GetRow.Cells(0).Value & "")
            Me.Close()
        Else
            MsgFar("There Is No Row To Select")
        End If
    End Sub
    Private Sub AddConditionalFormatting()
        Dim fc As Janus.Windows.GridEX.GridEXFormatCondition
        fc = New Janus.Windows.GridEX.GridEXFormatCondition(GrdDetail.RootTable.Columns("Po_NoReceive"), ConditionOperator.NotEqual, System.DBNull.Value)
        fc.FormatStyle.BackColor = System.Drawing.Color.Yellow
        GrdDetail.RootTable.FormatConditions.Add(fc)
    End Sub
    Sub FixthisDatabase()
        Dim text1 As String = " CREATE VIEW dbo.View_receive_po "
        text1 = text1 + "AS "
        text1 = text1 + " SELECT     dbo.Inv_Receive_Products_head.po_no, SUM(dbo.Inv_Receive_product_dtl.qty * dbo.Inv_Receive_product_dtl.cost) AS totalreceive"
        text1 = text1 + " FROM         dbo.Inv_Receive_Products_head INNER JOIN"
        text1 = text1 + " dbo.Inv_Receive_product_dtl ON dbo.Inv_Receive_Products_head.id_receive_ref = dbo.Inv_Receive_product_dtl.id_receive_ref"
        text1 = text1 + " GROUP BY dbo.Inv_Receive_Products_head.po_no "
        CmdGeneral.CommandText = text1
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            CmdGeneral.Connection.Close()
        End Try

    End Sub
End Class
