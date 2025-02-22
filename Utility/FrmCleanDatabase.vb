Imports CommonClass
Public Class FrmCleanDatabase
    Inherits FrmBase
    Private temp As Integer = 0
    Private Check_NodesFlag As Boolean = True
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmCleanDatabase1 As Utility.DSFrmCleanDatabase
    Friend WithEvents ChkDelTransactions As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkDelCustomerVehicles As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkDelCustomers As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkDelItems As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkDelVendor As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkDelCustomerCompanies As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkDelEmployees As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents ChkDelLAborAndServices As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtSecurityCode As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCleanDatabase))
        Me.BtnCancel = New Janus.Windows.EditControls.UIButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.BtnOk = New Janus.Windows.EditControls.UIButton
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DsFrmCleanDatabase1 = New Utility.DSFrmCleanDatabase
        Me.ChkDelTransactions = New Janus.Windows.EditControls.UICheckBox
        Me.ChkDelCustomerVehicles = New Janus.Windows.EditControls.UICheckBox
        Me.ChkDelCustomers = New Janus.Windows.EditControls.UICheckBox
        Me.ChkDelItems = New Janus.Windows.EditControls.UICheckBox
        Me.ChkDelVendor = New Janus.Windows.EditControls.UICheckBox
        Me.ChkDelCustomerCompanies = New Janus.Windows.EditControls.UICheckBox
        Me.ChkDelEmployees = New Janus.Windows.EditControls.UICheckBox
        Me.ChkDelLAborAndServices = New Janus.Windows.EditControls.UICheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtSecurityCode = New Janus.Windows.GridEX.EditControls.EditBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        CType(Me.DsFrmCleanDatabase1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Location = New System.Drawing.Point(14, 368)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(108, 32)
        Me.BtnCancel.TabIndex = 8
        Me.BtnCancel.Text = "Cancel"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(478, 48)
        Me.Panel2.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(48, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 46)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Initialize Databse"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'BtnOk
        '
        Me.BtnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnOk.Location = New System.Drawing.Point(357, 368)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(108, 32)
        Me.BtnOk.TabIndex = 9
        Me.BtnOk.Text = "Delete Records"
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;" & _
        "persist security info=True;password=sa"
        '
        'DsFrmCleanDatabase1
        '
        Me.DsFrmCleanDatabase1.DataSetName = "DSFrmCleanDatabase"
        Me.DsFrmCleanDatabase1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'ChkDelTransactions
        '
        Me.ChkDelTransactions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDelTransactions.Location = New System.Drawing.Point(13, 58)
        Me.ChkDelTransactions.Name = "ChkDelTransactions"
        Me.ChkDelTransactions.Size = New System.Drawing.Size(448, 48)
        Me.ChkDelTransactions.TabIndex = 0
        Me.ChkDelTransactions.Text = "Delete Transactions (Include  : Estimate , Work Order , Invoice , Return , Cashie" & _
        "r , Receive Payments , Bank Deposit , Check , Adjustment , ...)"
        '
        'ChkDelCustomerVehicles
        '
        Me.ChkDelCustomerVehicles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDelCustomerVehicles.Location = New System.Drawing.Point(13, 110)
        Me.ChkDelCustomerVehicles.Name = "ChkDelCustomerVehicles"
        Me.ChkDelCustomerVehicles.Size = New System.Drawing.Size(448, 32)
        Me.ChkDelCustomerVehicles.TabIndex = 1
        Me.ChkDelCustomerVehicles.Text = "Delete Customer Vehlicles"
        '
        'ChkDelCustomers
        '
        Me.ChkDelCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDelCustomers.Location = New System.Drawing.Point(13, 146)
        Me.ChkDelCustomers.Name = "ChkDelCustomers"
        Me.ChkDelCustomers.Size = New System.Drawing.Size(448, 32)
        Me.ChkDelCustomers.TabIndex = 2
        Me.ChkDelCustomers.Text = "Delete Customers"
        '
        'ChkDelItems
        '
        Me.ChkDelItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDelItems.Location = New System.Drawing.Point(13, 218)
        Me.ChkDelItems.Name = "ChkDelItems"
        Me.ChkDelItems.Size = New System.Drawing.Size(448, 32)
        Me.ChkDelItems.TabIndex = 4
        Me.ChkDelItems.Text = "Delete Items"
        '
        'ChkDelVendor
        '
        Me.ChkDelVendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDelVendor.Location = New System.Drawing.Point(13, 288)
        Me.ChkDelVendor.Name = "ChkDelVendor"
        Me.ChkDelVendor.Size = New System.Drawing.Size(448, 32)
        Me.ChkDelVendor.TabIndex = 6
        Me.ChkDelVendor.Text = "Delete Vendors"
        '
        'ChkDelCustomerCompanies
        '
        Me.ChkDelCustomerCompanies.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDelCustomerCompanies.Location = New System.Drawing.Point(13, 182)
        Me.ChkDelCustomerCompanies.Name = "ChkDelCustomerCompanies"
        Me.ChkDelCustomerCompanies.Size = New System.Drawing.Size(448, 32)
        Me.ChkDelCustomerCompanies.TabIndex = 3
        Me.ChkDelCustomerCompanies.Text = "Delete Customers Companies"
        '
        'ChkDelEmployees
        '
        Me.ChkDelEmployees.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDelEmployees.Location = New System.Drawing.Point(13, 324)
        Me.ChkDelEmployees.Name = "ChkDelEmployees"
        Me.ChkDelEmployees.Size = New System.Drawing.Size(448, 32)
        Me.ChkDelEmployees.TabIndex = 7
        Me.ChkDelEmployees.Text = "Delete Employees"
        '
        'ChkDelLAborAndServices
        '
        Me.ChkDelLAborAndServices.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDelLAborAndServices.Location = New System.Drawing.Point(13, 253)
        Me.ChkDelLAborAndServices.Name = "ChkDelLAborAndServices"
        Me.ChkDelLAborAndServices.Size = New System.Drawing.Size(448, 32)
        Me.ChkDelLAborAndServices.TabIndex = 5
        Me.ChkDelLAborAndServices.Text = "Delete Labor and Services"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(218, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 46)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "This Option Permanently deletes the selected data from your computer.Please make " & _
        "a backup before running."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtSecurityCode
        '
        Me.TxtSecurityCode.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtSecurityCode.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtSecurityCode.Location = New System.Drawing.Point(237, 373)
        Me.TxtSecurityCode.MaxLength = 10
        Me.TxtSecurityCode.Name = "TxtSecurityCode"
        Me.TxtSecurityCode.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TxtSecurityCode.Size = New System.Drawing.Size(92, 20)
        Me.TxtSecurityCode.TabIndex = 11
        Me.TxtSecurityCode.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(151, 371)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 23)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Security Code :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCleanDatabase
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(478, 404)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtSecurityCode)
        Me.Controls.Add(Me.ChkDelLAborAndServices)
        Me.Controls.Add(Me.ChkDelEmployees)
        Me.Controls.Add(Me.ChkDelCustomerCompanies)
        Me.Controls.Add(Me.ChkDelVendor)
        Me.Controls.Add(Me.ChkDelItems)
        Me.Controls.Add(Me.ChkDelCustomers)
        Me.Controls.Add(Me.ChkDelCustomerVehicles)
        Me.Controls.Add(Me.ChkDelTransactions)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtnCancel)
        Me.Name = "FrmCleanDatabase"
        Me.Text = "Database Cleaner"
        Me.Panel2.ResumeLayout(False)
        CType(Me.DsFrmCleanDatabase1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCleanDatabase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        If TxtSecurityCode.Text.Trim = "2231" Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            If ChkDelTransactions.Checked Then

                Call DeleteTableRecords("GL_External_Cash")
                Call DeleteTableRecords("GL_payment_cash")
                Call DeleteTableRecords("GL_payment_check")
                Call DeleteTableRecords("GL_payment_AR")
                Call DeleteTableRecords("GL_payment_credit")
                Call DeleteTableRecords("GL_payment_deposit")
                Call DeleteTableRecords("GL_account_adjustment_head")
                'Call DeleteTableRecords("service_out_purchases_dtl")
                'Call DeleteTableRecords("service_out_purchases")

                Call DeleteTableRecords("service_tire_adjustment")
                ' Call DeleteTableRecords("service_center_dtl")
                Call DeleteTableRecords("service_center_head")
                Call DeleteTableRecords("GL_debit_deposit_head")
                Call DeleteTableRecords("bank_adjustment_head")
                Call DeleteTableRecords("bank_ATM")
                Call DeleteTableRecords("bank_check")
                Call DeleteTableRecords("GL_journal_head")
                Call DeleteTableRecords("GL_Paid_received")
                Call DeleteTableRecords("Gl_receive_payment")
                Call DeleteTableRecords("GL_transfer_amount")
                Call DeleteTableRecords("inv_adjustment_head")
                Call DeleteTableRecords("GL_AP_payment")
                Call DeleteTableRecords("Inv_Receive_product_dtl")
                Call DeleteTableRecords("Inv_Receive_Products_head")
                Call DeleteTableRecords("Inv_purchase_order_dtl")
                Call DeleteTableRecords("Inv_purchase_order_head")
                Call DeleteTableRecords("inv_salse_transfer_head")
                Call DeleteTableRecords("GL_vendor_credit_Head")
                Call DeleteTableRecords("GL_vendor_credit")
                Call DeleteTableRecords("service_out_purchases_dtl")
                Call DeleteTableRecords("service_out_purchases")
                Call DeleteTableRecords("GL_AP_Bill_Head")
                Try
                    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.CommandText = "UPDATE inv_tab_item_warehouse SET  on_hand=0 , comitted =0, on_order =0 "
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox("system Cannot Change Item Qty to zero", MsgBoxStyle.Exclamation)
                End Try
            End If
            If ChkDelCustomerVehicles.Checked Then
                Call DeleteTableRecords("ser_tr_vehicle_change_dtl")
                Call DeleteTableRecords("ser_tr_vehicle")
            End If
            If ChkDelCustomers.Checked Then
                Call DeleteTableRecords("Cust_trtab_main")
            End If
            If ChkDelCustomerCompanies.Checked Then
                Call DeleteTableRecords("cust_company")
            End If
            If ChkDelItems.Checked Then
                Call DeleteTableRecords("inv_tab_autopart_specification")
                Call DeleteTableRecords("inv_tab_tire_specification")
                Call DeleteTableRecords("inv_tab_wheels_specification")
                Call DeleteTableRecords("inv_item_vendor")
                Call DeleteTableRecords("inv_item")
            End If
            If ChkDelLAborAndServices.Checked Then
                Call DeleteTableRecords("inv_tab_autopart_specification")
            End If
            If ChkDelVendor.Checked Then
                Call DeleteTableRecords("inv_vendor")
                Call DeleteTableRecords("inv_item_vendor")
            End If
            If ChkDelEmployees.Checked Then
                Call DeleteTableRecords("pay_main_employee")
                Call DeleteTableRecords("pay_punch_employee_in_out")
                Call DeleteTableRecords("pay_employee_timesheet")
                Call DeleteTableRecords("employee")
            End If
            MsgBox("All Selected Data Was Deleted Successfully", MsgBoxStyle.Information)
        Else
            MsgBox("Please Enter Security Code , then You can Delete information", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub DeleteTableRecords(ByVal ThisTable As String)
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            Dim i As Int64

            'CmdGeneral.CommandText = " select count(*) from " & ThisTable
            'i = CmdGeneral.ExecuteScalar
            If ThisTable = "service_center_head" Then
                'CmdGeneral.CommandText = "DELETE  FROM " & ThisTable & " where id_service_center NOT IN   (SELECT     id_service_center_before FROM         service_center_head)  "
                'CmdGeneral.ExecuteNonQuery()
                For i = 0 To 8

                    CmdGeneral.CommandText = " DELETE service_center_head " & _
    " FROM         (SELECT     TOP 10000 * " & _
    "                         FROM         service_center_head " & _
    "                         WHERE     id_service_center NOT IN " & _
    "                                                   (SELECT     id_service_center " & _
    "                                                      FROM         service_center_head " & _
    "                                                           WHERE     (id_service_center IN " & _
    "                        (SELECT     id_service_center_before " & _
    "                                                                                   FROM         service_center_head)))) AS t " & _
    " WHERE     service_center_head.id_service_center = t .id_service_center "
                    CmdGeneral.ExecuteNonQuery()
                Next




            End If

            CmdGeneral.CommandText = " DELETE FROM " & ThisTable
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("system Cannot Delete (" & ThisTable & ") Records", MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub ChkDelCustomerVehicles_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDelCustomerVehicles.CheckedChanged
        If ChkDelCustomerVehicles.Checked Then
            ChkDelTransactions.Checked = True
        Else
            ChkDelCustomers.Checked = False
            ChkDelCustomerCompanies.Checked = False
        End If
    End Sub
    Private Sub ChkDelCustomers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDelCustomers.CheckedChanged
        If ChkDelCustomers.Checked Then
            ChkDelTransactions.Checked = True
            ChkDelCustomerVehicles.Checked = True
        Else
            ChkDelCustomerVehicles.Checked = False
            ChkDelCustomerCompanies.Checked = False
        End If
    End Sub
    Private Sub ChkDelItems_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDelItems.CheckedChanged
        If ChkDelItems.Checked Then
            ChkDelTransactions.Checked = True
        End If
    End Sub
    Private Sub ChkDelVendor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDelVendor.CheckedChanged
        If ChkDelVendor.Checked Then
            ChkDelTransactions.Checked = True
        End If
    End Sub
    Private Sub ChkDelEmployees_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDelEmployees.CheckedChanged
        If ChkDelEmployees.Checked Then
            ChkDelTransactions.Checked = True
        End If
    End Sub
    Private Sub ChkDelCustomerCompanies_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDelCustomerCompanies.CheckedChanged
        If ChkDelCustomerCompanies.Checked Then
            ChkDelTransactions.Checked = True
            ChkDelCustomers.Checked = True
            ChkDelCustomerVehicles.Checked = True
        End If
    End Sub
    Private Sub ChkDelTransactions_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDelTransactions.CheckedChanged
        If ChkDelTransactions.Checked = False Then
            ChkDelCustomerCompanies.Checked = False
            ChkDelCustomers.Checked = False
            ChkDelCustomerVehicles.Checked = False
            ChkDelEmployees.Checked = False
            ChkDelItems.Checked = False
            ChkDelVendor.Checked = False
            ChkDelLAborAndServices.Checked = False
        End If
    End Sub
    Private Sub ChkDelLAborAndServices_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDelLAborAndServices.CheckedChanged
        If ChkDelLAborAndServices.Checked Then
            ChkDelTransactions.Checked = True
        End If
    End Sub
End Class
