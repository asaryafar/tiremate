Imports CommonClass
Public Class FrmSearchApPayment
    Inherits FrmBase
    Public Event FindPaymentCodDate(ByVal ThiDate As String, ByVal ThidVendorCod As String)
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
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DaSelect As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmSearchVendorPayment1 As UcAccount.DSFrmSearchVendorPayment
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdEXit As Janus.Windows.EditControls.UIButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DaSelect = New System.Data.SqlClient.SqlDataAdapter
        Me.DsFrmSearchVendorPayment1 = New UcAccount.DSFrmSearchVendorPayment
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdEXit = New Janus.Windows.EditControls.UIButton
        CType(Me.DsFrmSearchVendorPayment1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT DISTINCT * FROM (SELECT GL_AP_payment.date_prepare, service_out_purchases." & _
        "cod_vendor, inv_vendor.desc_vendor, inv_vendor.address FROM inv_vendor INNER JOI" & _
        "N service_out_purchases ON inv_vendor.cod_vendor = service_out_purchases.cod_ven" & _
        "dor INNER JOIN GL_AP_payment ON service_out_purchases.id_service_center = GL_AP_" & _
        "payment.id_service_center AND service_out_purchases.radif = GL_AP_payment.radif " & _
        "UNION ALL SELECT GL_AP_payment.date_prepare, GL_AP_Bill_Head.cod_vendor, inv_ven" & _
        "dor.desc_vendor, inv_vendor.address FROM GL_AP_bill_Dtl_Dtl INNER JOIN GL_AP_pay" & _
        "ment ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl = GL_AP_payment.Id_AP_bill_dtl_dtl" & _
        " INNER JOIN GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl" & _
        ".Id_AP_bill_dtl INNER JOIN GL_AP_Bill_Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = G" & _
        "L_AP_Bill_Head.Id_AP_bill_Head INNER JOIN inv_vendor ON GL_AP_Bill_Head.cod_vend" & _
        "or = inv_vendor.cod_vendor UNION ALL SELECT GL_AP_payment.date_prepare, inv_vend" & _
        "or.cod_vendor, inv_vendor.desc_vendor, inv_vendor.address FROM Inv_Receive_produ" & _
        "ct_Ap_Dtl INNER JOIN GL_AP_payment ON Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_" & _
        "product_Ap_Dtl = GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl INNER JOIN Inv_Rece" & _
        "ive_Products_head ON Inv_Receive_product_Ap_Dtl.id_receive_ref = Inv_Receive_Pro" & _
        "ducts_head.id_receive_ref INNER JOIN inv_vendor ON Inv_Receive_Products_head.cod" & _
        "_vendor = inv_vendor.cod_vendor) deliv"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=FARAJI1;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=Tiremate_01;password=sa"
        '
        'DaSelect
        '
        Me.DaSelect.SelectCommand = Me.SqlSelectCommand1
        Me.DaSelect.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_AP_payment", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_AP_payment", "ID_AP_payment"), New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl_dtl", "Id_AP_bill_dtl_dtl"), New System.Data.Common.DataColumnMapping("ID_Inv_Receive_product_Ap_Dtl", "ID_Inv_Receive_product_Ap_Dtl"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("amount_pay", "amount_pay"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("date_prepare", "date_prepare"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("radif1", "radif1")})})
        '
        'DsFrmSearchVendorPayment1
        '
        Me.DsFrmSearchVendorPayment1.DataSetName = "DSFrmSearchVendorPayment"
        Me.DsFrmSearchVendorPayment1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'GridEX1
        '
        Me.GridEX1.DataSource = Me.DsFrmSearchVendorPayment1.GL_AP_payment
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_AP_payment</Caption><Columns Collection=" & _
        """true""><Column0 ID=""date_prepare""><Caption>Payment Date</Caption><TypeNameEmptyS" & _
        "tringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMemb" & _
        "er>date_prepare</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</" & _
        "FilterEditType><Key>date_prepare</Key><Position>0</Position></Column0><Column1 I" & _
        "D=""cod_vendor""><Caption>Vendor Cod</Caption><DataMember>cod_vendor</DataMember><" & _
        "EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>cod_vendo" & _
        "r</Key><Position>1</Position></Column1><Column2 ID=""desc_vendor""><Caption>Descri" & _
        "ption</Caption><DataMember>desc_vendor</DataMember><EditType>NoEdit</EditType><F" & _
        "ilterEditType>TextBox</FilterEditType><Key>desc_vendor</Key><Position>2</Positio" & _
        "n><Width>173</Width></Column2><Column3 ID=""address""><Caption>Address</Caption><D" & _
        "ataMember>address</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox" & _
        "</FilterEditType><Key>address</Key><Position>3</Position><Width>186</Width></Col" & _
        "umn3></Columns><GroupCondition ID="""" /><Key>GL_AP_payment</Key></RootTable></Gri" & _
        "dEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(8, 24)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GridEX1.Size = New System.Drawing.Size(592, 304)
        Me.GridEX1.TabIndex = 0
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(523, 336)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 1
        Me.CmdOk.Text = "Ok"
        '
        'CmdEXit
        '
        Me.CmdEXit.Location = New System.Drawing.Point(8, 336)
        Me.CmdEXit.Name = "CmdEXit"
        Me.CmdEXit.Size = New System.Drawing.Size(75, 23)
        Me.CmdEXit.TabIndex = 2
        Me.CmdEXit.Text = "Exit"
        '
        'FrmSearchApPayment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(616, 366)
        Me.Controls.Add(Me.CmdEXit)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmSearchApPayment"
        Me.Text = "Vendor Search"
        CType(Me.DsFrmSearchVendorPayment1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmSearchApPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        DaSelect.Fill(DsFrmSearchVendorPayment1)
        ' if DsFrmSearchVendorPayment1.
    End Sub

    Private Sub CmdEXit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEXit.Click
        Me.Close()
    End Sub

    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        If GridEX1.RowCount > 0 Then
            RaiseEvent FindPaymentCodDate(GridEX1.GetRow.Cells(0).Value & "", GridEX1.GetRow.Cells(1).Value & "")
            Me.Close()
        End If
    End Sub
End Class
