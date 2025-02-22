Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmSearchvendorCod
    Inherits FrmBase
    Event vendorFind(ByVal ThisvendorCod As String, ByVal Thisdesc_vendor As String)
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PhoneNo1 As UCPhone.PhoneNo
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtCompany As System.Windows.Forms.TextBox
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents BtnViewRowdetail As System.Windows.Forms.Button
    Friend WithEvents BtnAddNewCustomer As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents DSFrmSearchvendorCod1 As UCVendor.DSInv_Vendor
    Friend WithEvents DAinv_vendor As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TxtCode As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmSearchvendorCod))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnFind = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.PhoneNo1 = New UCPhone.PhoneNo
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtCompany = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtCode = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DataView1 = New System.Data.DataView
        Me.DSFrmSearchvendorCod1 = New UCVendor.DSInv_Vendor
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.BtnViewRowdetail = New System.Windows.Forms.Button
        Me.BtnAddNewCustomer = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.DAinv_vendor = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Panel1.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSFrmSearchvendorCod1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnFind)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.PhoneNo1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtCompany)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtCode)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(4, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(623, 62)
        Me.Panel1.TabIndex = 1
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(574, 11)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 27)
        Me.BtnFind.TabIndex = 346
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(574, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 10)
        Me.Label14.TabIndex = 345
        Me.Label14.Text = "Find"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PhoneNo1
        '
        Me.PhoneNo1.BackColor = System.Drawing.SystemColors.Window
        Me.PhoneNo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PhoneNo1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.PhoneNo1.Location = New System.Drawing.Point(438, 34)
        Me.PhoneNo1.Name = "PhoneNo1"
        Me.PhoneNo1.Size = New System.Drawing.Size(94, 22)
        Me.PhoneNo1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.YellowGreen
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(363, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 22)
        Me.Label2.TabIndex = 336
        Me.Label2.Text = "Phone"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCompany
        '
        Me.TxtCompany.Location = New System.Drawing.Point(81, 36)
        Me.TxtCompany.MaxLength = 20
        Me.TxtCompany.Name = "TxtCompany"
        Me.TxtCompany.Size = New System.Drawing.Size(245, 20)
        Me.TxtCompany.TabIndex = 3
        Me.TxtCompany.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.YellowGreen
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(5, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 22)
        Me.Label1.TabIndex = 334
        Me.Label1.Text = "Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCode
        '
        Me.TxtCode.Location = New System.Drawing.Point(81, 7)
        Me.TxtCode.MaxLength = 20
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(95, 20)
        Me.TxtCode.TabIndex = 0
        Me.TxtCode.Text = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.YellowGreen
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(5, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 22)
        Me.Label5.TabIndex = 332
        Me.Label5.Text = "Vendor Code"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataSource = Me.DataView1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>inv_vendor</Caption><Columns Collection=""tr" & _
        "ue""><Column0 ID=""cod_vendor""><Caption>Code</Caption><TypeNameEmptyStringValue>Sy" & _
        "stem.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>cod_vendor" & _
        "</DataMember><Key>cod_vendor</Key><Position>0</Position></Column0><Column1 ID=""d" & _
        "esc_vendor""><Caption>Name</Caption><DataMember>desc_vendor</DataMember><Key>desc" & _
        "_vendor</Key><Position>1</Position><Width>165</Width></Column1><Column2 ID=""addr" & _
        "ess""><Caption>Address</Caption><DataMember>address</DataMember><Key>address</Key" & _
        "><Position>2</Position><Width>299</Width></Column2></Columns><GroupCondition ID=" & _
        """"" /><Key>inv_vendor</Key></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GrdDetail.Location = New System.Drawing.Point(0, 95)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.RecordNavigator = True
        Me.GrdDetail.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdDetail.Size = New System.Drawing.Size(629, 260)
        Me.GrdDetail.TabIndex = 2
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'DataView1
        '
        Me.DataView1.Table = Me.DSFrmSearchvendorCod1.inv_vendor
        '
        'DSFrmSearchvendorCod1
        '
        Me.DSFrmSearchvendorCod1.DataSetName = "DSInv_Vendor"
        Me.DSFrmSearchvendorCod1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=""."";persist security " & _
        "info=True;initial catalog=TireMate_02;password=2191110"
        '
        'BtnViewRowdetail
        '
        Me.BtnViewRowdetail.Image = CType(resources.GetObject("BtnViewRowdetail.Image"), System.Drawing.Image)
        Me.BtnViewRowdetail.Location = New System.Drawing.Point(155, 4)
        Me.BtnViewRowdetail.Name = "BtnViewRowdetail"
        Me.BtnViewRowdetail.Size = New System.Drawing.Size(24, 24)
        Me.BtnViewRowdetail.TabIndex = 6
        '
        'BtnAddNewCustomer
        '
        Me.BtnAddNewCustomer.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAddNewCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnAddNewCustomer.ForeColor = System.Drawing.Color.Black
        Me.BtnAddNewCustomer.Location = New System.Drawing.Point(6, 4)
        Me.BtnAddNewCustomer.Name = "BtnAddNewCustomer"
        Me.BtnAddNewCustomer.Size = New System.Drawing.Size(134, 23)
        Me.BtnAddNewCustomer.TabIndex = 3
        Me.BtnAddNewCustomer.Text = "Add New Vendor"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CmdOk)
        Me.Panel2.Controls.Add(Me.CmdExit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 355)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(629, 33)
        Me.Panel2.TabIndex = 21
        '
        'CmdOk
        '
        Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmdOk.ForeColor = System.Drawing.Color.Black
        Me.CmdOk.Location = New System.Drawing.Point(447, 5)
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
        Me.CmdExit.Location = New System.Drawing.Point(543, 5)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 24)
        Me.CmdExit.TabIndex = 21
        Me.CmdExit.Text = "Exit"
        '
        'DAinv_vendor
        '
        Me.DAinv_vendor.SelectCommand = Me.SqlSelectCommand2
        Me.DAinv_vendor.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_vendor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("desc_vendor", "desc_vendor"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("cod_city", "cod_city"), New System.Data.Common.DataColumnMapping("cod_state", "cod_state"), New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("phone_main", "phone_main"), New System.Data.Common.DataColumnMapping("phone_cell", "phone_cell"), New System.Data.Common.DataColumnMapping("phone_work", "phone_work"), New System.Data.Common.DataColumnMapping("phone_ext1", "phone_ext1"), New System.Data.Common.DataColumnMapping("phone_ext2", "phone_ext2"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("www", "www"), New System.Data.Common.DataColumnMapping("federal_tax_id", "federal_tax_id"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("ap_terms", "ap_terms"), New System.Data.Common.DataColumnMapping("vendor_type", "vendor_type"), New System.Data.Common.DataColumnMapping("class_vendor", "class_vendor"), New System.Data.Common.DataColumnMapping("buyer_id", "buyer_id"), New System.Data.Common.DataColumnMapping("vendor_since", "vendor_since"), New System.Data.Common.DataColumnMapping("f_1099", "f_1099"), New System.Data.Common.DataColumnMapping("on_hold", "on_hold"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("credit_limited", "credit_limited"), New System.Data.Common.DataColumnMapping("remit_to_company", "remit_to_company"), New System.Data.Common.DataColumnMapping("remit_to_address", "remit_to_address"), New System.Data.Common.DataColumnMapping("remit_to_city", "remit_to_city"), New System.Data.Common.DataColumnMapping("remit_to_state", "remit_to_state")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cod_vendor, desc_vendor, address, phone_1 FROM inv_vendor"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'FrmSearchvendorCod
        '
        Me.AcceptButton = Me.BtnFind
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(629, 388)
        Me.Controls.Add(Me.BtnViewRowdetail)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnAddNewCustomer)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmSearchvendorCod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Find Vendor"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSFrmSearchvendorCod1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmFindServiceRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Try
            If Cnn.ConnectionString <> PConnectionString Then
                If Cnn.State <> ConnectionState.Closed Then
                    Cnn.Close()
                End If
                Cnn.ConnectionString = PConnectionString
            End If
        Catch ex As Exception
        End Try
        PhoneNo1.Text = ""
        TxtCompany.Text = ""
        TxtCode.Text = ""
        Call FillDataSet()
    End Sub
    Private Sub ActFilter()
        Dim WhereClauseVar As String = ""
        Dim OPerand As String = " "
        If TxtCode.Text.Trim.Length > 0 Then
            WhereClauseVar = WhereClauseVar & OPerand & " cod_vendor like '%" & TxtCode.Text.Trim & "%' "
            OPerand = " AND "
        End If
        If PhoneNo1.Text.Trim.Length > 2 Then
            WhereClauseVar = WhereClauseVar & OPerand & " phone_1 like '%" & PhoneNo1.Text.Trim & "%' "
            OPerand = " AND "
        End If
        If TxtCompany.Text.Trim.Length > 0 Then
            WhereClauseVar = WhereClauseVar & OPerand & " desc_vendor like '%" & TxtCompany.Text.Trim & "%' "
            OPerand = " AND "
        End If
        DataView1.RowFilter = WhereClauseVar
    End Sub
    Private Sub FillDataSet()
        DSFrmSearchvendorCod1.inv_vendor.Clear()
        DAinv_vendor.Fill(DSFrmSearchvendorCod1, "inv_vendor")
        DataView1.RowFilter = ""
    End Sub
    Private Sub BtnAddNewCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddNewCustomer.Click
        Dim MyFrmVendor As New UCVendor.FrmVendor
        MyFrmVendor.StartPosition = FormStartPosition.CenterParent
        MyFrmVendor.Cod_VendorVar = MyFrmVendor.MakeNewVendorCod()
        MyFrmVendor.IsCancelForExitFlag = True
        MyFrmVendor.ShowDialog()
        Call FillDataSet()
        If MyFrmVendor.TxtVendorCod.Text.Trim.Length > 0 Then
            RaiseEvent vendorFind(MyFrmVendor.TxtVendorCod.Text & "", MyFrmVendor.TxtCompany.Text & " ")
            Me.Close()
        Else
            Call FillDataSet()
        End If

    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        Call ActFilter()
    End Sub
    Private Sub BtnViewRowdetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewRowdetail.Click
        Try
            Dim MyFrmVendor As New UCVendor.FrmVendor
            MyFrmVendor.VendorCodTempVar = GrdDetail.GetRow.Cells(0).Value
            MyFrmVendor.StartPosition = FormStartPosition.CenterParent
            MyFrmVendor.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        Try
            If GrdDetail.RowCount > 0 Then
                RaiseEvent vendorFind(GrdDetail.GetRow.Cells(0).Value & "", GrdDetail.GetRow.Cells(1).Value & " ")
                Me.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Call GrdDetail_DoubleClick(sender, e)
        Me.Close()
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
End Class
