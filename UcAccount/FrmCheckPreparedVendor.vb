Imports CommonClass
Public Class FrmCheckPreparedVendor
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
    Friend WithEvents CmdEXit As Janus.Windows.EditControls.UIButton
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents DaSelect As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmCheckPreparedVendor1 As UcAccount.DsFrmCheckPreparedVendor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.CmdEXit = New Janus.Windows.EditControls.UIButton
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.DsFrmCheckPreparedVendor1 = New UcAccount.DsFrmCheckPreparedVendor
        Me.DaSelect = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmCheckPreparedVendor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdEXit
        '
        Me.CmdEXit.Location = New System.Drawing.Point(15, 328)
        Me.CmdEXit.Name = "CmdEXit"
        Me.CmdEXit.Size = New System.Drawing.Size(75, 23)
        Me.CmdEXit.TabIndex = 5
        Me.CmdEXit.Text = "Exit"
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=FARAJI1;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=Tiremate_02;password=sa"
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(576, 328)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 4
        Me.CmdOk.Text = "Ok"
        '
        'GridEX1
        '
        Me.GridEX1.DataSource = Me.DsFrmCheckPreparedVendor1.GL_AP_payment
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_AP_payment</Caption><Columns Collection=" & _
        """true""><Column0 ID=""date_prepare""><Caption>Prepare  Date</Caption><TypeNameEmpty" & _
        "StringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMem" & _
        "ber>date_prepare</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox<" & _
        "/FilterEditType><Key>date_prepare</Key><Position>0</Position></Column0><Column1 " & _
        "ID=""cod_vendor""><Caption>Vendor</Caption><DataMember>cod_vendor</DataMember><Edi" & _
        "tType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>cod_vendor</" & _
        "Key><Position>1</Position></Column1><Column2 ID=""desc_vendor""><Caption>Name</Cap" & _
        "tion><DataMember>desc_vendor</DataMember><EditType>NoEdit</EditType><FilterEditT" & _
        "ype>TextBox</FilterEditType><Key>desc_vendor</Key><Position>2</Position><Width>1" & _
        "73</Width></Column2><Column3 ID=""address""><Caption>Address</Caption><DataMember>" & _
        "address</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEd" & _
        "itType><Key>address</Key><Position>3</Position><Width>186</Width></Column3><Colu" & _
        "mn4 ID=""sumpay""><Caption>Amount Paid</Caption><DataMember>sumpay</DataMember><Ed" & _
        "itType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2" & _
        "</FormatString><Key>sumpay</Key><Position>4</Position></Column4></Columns><Group" & _
        "Condition ID="""" /><Key>GL_AP_payment</Key></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(15, 16)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.Size = New System.Drawing.Size(665, 304)
        Me.GridEX1.TabIndex = 3
        '
        'DsFrmCheckPreparedVendor1
        '
        Me.DsFrmCheckPreparedVendor1.DataSetName = "DsFrmCheckPreparedVendor"
        Me.DsFrmCheckPreparedVendor1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'DaSelect
        '
        Me.DaSelect.SelectCommand = Me.SqlSelectCommand1
        Me.DaSelect.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_AP_payment", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_AP_payment", "ID_AP_payment"), New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl_dtl", "Id_AP_bill_dtl_dtl"), New System.Data.Common.DataColumnMapping("ID_Inv_Receive_product_Ap_Dtl", "ID_Inv_Receive_product_Ap_Dtl"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("amount_pay", "amount_pay"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("date_prepare", "date_prepare"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("radif1", "radif1")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT date_prepare, cod_vendor, desc_vendor, address, SUM(sumpay) AS sumpay FROM" & _
        " (SELECT GL_AP_payment.date_prepare, service_out_purchases.cod_vendor, inv_vendo" & _
        "r.desc_vendor, inv_vendor.address, SUM(round(GL_AP_payment.amount_pay, 2)) AS su" & _
        "mpay FROM inv_vendor INNER JOIN service_out_purchases ON inv_vendor.cod_vendor =" & _
        " service_out_purchases.cod_vendor INNER JOIN GL_AP_payment ON service_out_purcha" & _
        "ses.id_service_center = GL_AP_payment.id_service_center AND service_out_purchase" & _
        "s.radif = GL_AP_payment.radif WHERE GL_AP_payment.id_check IS NULL AND (GL_AP_pa" & _
        "yment.id_vendor_credit_head IS NULL) GROUP BY GL_AP_payment.date_prepare, servic" & _
        "e_out_purchases.cod_vendor, inv_vendor.desc_vendor, inv_vendor.address UNION ALL" & _
        " SELECT GL_AP_payment.date_prepare, GL_AP_Bill_Head.cod_vendor, inv_vendor.desc_" & _
        "vendor, inv_vendor.address, SUM(round(GL_AP_payment.amount_pay, 2)) AS sumpay FR" & _
        "OM GL_AP_bill_Dtl_Dtl INNER JOIN GL_AP_payment ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_" & _
        "dtl_dtl = GL_AP_payment.Id_AP_bill_dtl_dtl INNER JOIN GL_AP_bill_Dtl ON GL_AP_bi" & _
        "ll_Dtl_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN GL_AP_Bill_" & _
        "Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head INNER J" & _
        "OIN inv_vendor ON GL_AP_Bill_Head.cod_vendor = inv_vendor.cod_vendor WHERE GL_AP" & _
        "_payment.id_check IS NULL AND (GL_AP_payment.id_vendor_credit_head IS NULL) GROU" & _
        "P BY GL_AP_payment.date_prepare, GL_AP_Bill_Head.cod_vendor, inv_vendor.desc_ven" & _
        "dor, inv_vendor.address UNION ALL SELECT GL_AP_payment.date_prepare, inv_vendor." & _
        "cod_vendor, inv_vendor.desc_vendor, inv_vendor.address, SUM(round(GL_AP_payment." & _
        "amount_pay, 2)) AS sumpay FROM Inv_Receive_product_Ap_Dtl INNER JOIN GL_AP_payme" & _
        "nt ON Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl = GL_AP_payment.I" & _
        "D_Inv_Receive_product_Ap_Dtl INNER JOIN Inv_Receive_Products_head ON Inv_Receive" & _
        "_product_Ap_Dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref INNER " & _
        "JOIN inv_vendor ON Inv_Receive_Products_head.cod_vendor = inv_vendor.cod_vendor " & _
        "WHERE GL_AP_payment.id_check IS NULL AND (GL_AP_payment.id_vendor_credit_head IS" & _
        " NULL) GROUP BY GL_AP_payment.date_prepare, inv_vendor.cod_vendor, inv_vendor.de" & _
        "sc_vendor, inv_vendor.address) deliv GROUP BY date_prepare, cod_vendor, desc_ven" & _
        "dor, address"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'FrmCheckPreparedVendor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(686, 356)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.CmdEXit)
        Me.Controls.Add(Me.CmdOk)
        Me.Name = "FrmCheckPreparedVendor"
        Me.Text = "Prepared Checks"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmCheckPreparedVendor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Event FindPaymentCodDate(ByVal ThisDate As String, ByVal ThidVendorCod As String, ByVal SumCheck As Decimal)
    Private Sub FrmCheckPreparedVendor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        DaSelect.Fill(DsFrmCheckPreparedVendor1.GL_AP_payment)
        If DsFrmCheckPreparedVendor1.GL_AP_payment.Rows.Count > 0 Then
            CmdOk.Enabled = True
            GridEX1.Focus()
        Else
            CmdOk.Enabled = False
        End If
    End Sub

    Private Sub CmdEXit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEXit.Click
        Me.Close()
    End Sub

    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        If GridEX1.RowCount > 0 Then
            RaiseEvent FindPaymentCodDate(GridEX1.GetRow.Cells(0).Value & "", GridEX1.GetRow.Cells(1).Value & "", CDec(Val(GridEX1.GetRow.Cells(4).Value & "")))
            Me.Close()
        End If
    End Sub
End Class
