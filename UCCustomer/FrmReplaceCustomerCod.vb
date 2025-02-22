Public Class FrmReplaceCustomerCod
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CustomerCodFrom As UCCustomer.CustomerCod
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CustomerCodTo As UCCustomer.CustomerCod
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents TxtCompanyto As System.Windows.Forms.TextBox
    Friend WithEvents txtMNameto As System.Windows.Forms.TextBox
    Friend WithEvents txtLNameto As System.Windows.Forms.TextBox
    Friend WithEvents txtFNameto As System.Windows.Forms.TextBox
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdClose As Janus.Windows.EditControls.UIButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtCompany = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtMName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtFName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CustomerCodFrom = New UCCustomer.CustomerCod
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtCompanyto = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtMNameto = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtLNameto = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtFNameto = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.CustomerCodTo = New UCCustomer.CustomerCod
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdClose = New Janus.Windows.EditControls.UIButton
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxtCompany)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtMName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtLName)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtFName)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.CustomerCodFrom)
        Me.Panel1.Location = New System.Drawing.Point(7, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(457, 128)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(240, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 22)
        Me.Label4.TabIndex = 367
        Me.Label4.Text = "System keeps this Customer."
        '
        'TxtCompany
        '
        Me.TxtCompany.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TxtCompany.Location = New System.Drawing.Point(80, 88)
        Me.TxtCompany.MaxLength = 20
        Me.TxtCompany.Name = "TxtCompany"
        Me.TxtCompany.ReadOnly = True
        Me.TxtCompany.Size = New System.Drawing.Size(336, 20)
        Me.TxtCompany.TabIndex = 366
        Me.TxtCompany.Text = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(8, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 21)
        Me.Label5.TabIndex = 365
        Me.Label5.Text = "Company"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMName
        '
        Me.txtMName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtMName.Location = New System.Drawing.Point(208, 48)
        Me.txtMName.MaxLength = 15
        Me.txtMName.Name = "txtMName"
        Me.txtMName.ReadOnly = True
        Me.txtMName.Size = New System.Drawing.Size(48, 20)
        Me.txtMName.TabIndex = 360
        Me.txtMName.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(184, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 21)
        Me.Label1.TabIndex = 364
        Me.Label1.Text = "M.I."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLName
        '
        Me.txtLName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtLName.Location = New System.Drawing.Point(288, 48)
        Me.txtLName.MaxLength = 50
        Me.txtLName.Name = "txtLName"
        Me.txtLName.ReadOnly = True
        Me.txtLName.Size = New System.Drawing.Size(128, 20)
        Me.txtLName.TabIndex = 361
        Me.txtLName.Text = ""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(256, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 21)
        Me.Label6.TabIndex = 362
        Me.Label6.Text = "Last"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFName
        '
        Me.txtFName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtFName.Location = New System.Drawing.Point(80, 48)
        Me.txtFName.MaxLength = 20
        Me.txtFName.Name = "txtFName"
        Me.txtFName.ReadOnly = True
        Me.txtFName.Size = New System.Drawing.Size(104, 20)
        Me.txtFName.TabIndex = 359
        Me.txtFName.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 21)
        Me.Label3.TabIndex = 363
        Me.Label3.Text = "FirstName"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 22)
        Me.Label2.TabIndex = 358
        Me.Label2.Text = "Main Customer"
        '
        'CustomerCodFrom
        '
        Me.CustomerCodFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CustomerCodFrom.Connection = Me.Cnn
        Me.CustomerCodFrom.CustomerCod = ""
        Me.CustomerCodFrom.CustomerCodLen = 10
        Me.CustomerCodFrom.Location = New System.Drawing.Point(110, 8)
        Me.CustomerCodFrom.Name = "CustomerCodFrom"
        Me.CustomerCodFrom.NotExitIfNotFound = False
        Me.CustomerCodFrom.ReleaseIfNotFoundCustomerCod = False
        Me.CustomerCodFrom.Size = New System.Drawing.Size(128, 21)
        Me.CustomerCodFrom.TabIndex = 357
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Location = New System.Drawing.Point(9, 149)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(455, 4)
        Me.Panel2.TabIndex = 358
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.TxtCompanyto)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtMNameto)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtLNameto)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.txtFNameto)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.CustomerCodTo)
        Me.Panel3.Location = New System.Drawing.Point(7, 168)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(457, 128)
        Me.Panel3.TabIndex = 359
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(247, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 32)
        Me.Label7.TabIndex = 367
        Me.Label7.Text = "System combines this customer's records  into  above Customer's"
        '
        'TxtCompanyto
        '
        Me.TxtCompanyto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TxtCompanyto.Location = New System.Drawing.Point(80, 88)
        Me.TxtCompanyto.MaxLength = 20
        Me.TxtCompanyto.Name = "TxtCompanyto"
        Me.TxtCompanyto.ReadOnly = True
        Me.TxtCompanyto.Size = New System.Drawing.Size(336, 20)
        Me.TxtCompanyto.TabIndex = 366
        Me.TxtCompanyto.Text = ""
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(8, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 21)
        Me.Label8.TabIndex = 365
        Me.Label8.Text = "Company"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMNameto
        '
        Me.txtMNameto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtMNameto.Location = New System.Drawing.Point(208, 51)
        Me.txtMNameto.MaxLength = 15
        Me.txtMNameto.Name = "txtMNameto"
        Me.txtMNameto.ReadOnly = True
        Me.txtMNameto.Size = New System.Drawing.Size(48, 20)
        Me.txtMNameto.TabIndex = 360
        Me.txtMNameto.Text = ""
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(184, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 21)
        Me.Label9.TabIndex = 364
        Me.Label9.Text = "M.I."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLNameto
        '
        Me.txtLNameto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtLNameto.Location = New System.Drawing.Point(288, 51)
        Me.txtLNameto.MaxLength = 50
        Me.txtLNameto.Name = "txtLNameto"
        Me.txtLNameto.ReadOnly = True
        Me.txtLNameto.Size = New System.Drawing.Size(128, 20)
        Me.txtLNameto.TabIndex = 361
        Me.txtLNameto.Text = ""
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(256, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 21)
        Me.Label10.TabIndex = 362
        Me.Label10.Text = "Last"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFNameto
        '
        Me.txtFNameto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtFNameto.Location = New System.Drawing.Point(80, 51)
        Me.txtFNameto.MaxLength = 20
        Me.txtFNameto.Name = "txtFNameto"
        Me.txtFNameto.ReadOnly = True
        Me.txtFNameto.Size = New System.Drawing.Size(104, 20)
        Me.txtFNameto.TabIndex = 359
        Me.txtFNameto.Text = ""
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(8, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 21)
        Me.Label11.TabIndex = 363
        Me.Label11.Text = "FirstName"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 22)
        Me.Label12.TabIndex = 358
        Me.Label12.Text = "Merging Customer"
        '
        'CustomerCodTo
        '
        Me.CustomerCodTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CustomerCodTo.Connection = Me.Cnn
        Me.CustomerCodTo.CustomerCod = ""
        Me.CustomerCodTo.CustomerCodLen = 10
        Me.CustomerCodTo.Location = New System.Drawing.Point(112, 8)
        Me.CustomerCodTo.Name = "CustomerCodTo"
        Me.CustomerCodTo.NotExitIfNotFound = False
        Me.CustomerCodTo.ReleaseIfNotFoundCustomerCod = False
        Me.CustomerCodTo.Size = New System.Drawing.Size(128, 21)
        Me.CustomerCodTo.TabIndex = 357
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Location = New System.Drawing.Point(11, 308)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(453, 4)
        Me.Panel4.TabIndex = 362
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(7, 320)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(73, 23)
        Me.CmdOk.TabIndex = 360
        Me.CmdOk.Text = "Save"
        '
        'CmdClose
        '
        Me.CmdClose.Location = New System.Drawing.Point(391, 320)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(73, 23)
        Me.CmdClose.TabIndex = 361
        Me.CmdClose.Text = "Exit"
        '
        'FrmReplaceCustomerCod
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(470, 348)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.CmdClose)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmReplaceCustomerCod"
        Me.Text = "Merge Customers"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub CustomerCodFrom_FindCustomerCod() Handles CustomerCodFrom.FindCustomerCod
        txtMName.Text = CustomerCodFrom.M_Name.Trim & ""
        txtFName.Text = CustomerCodFrom.F_Name.Trim & ""
        txtLName.Text = CustomerCodFrom.L_Name.Trim & ""
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "select abbreviation_name as companyname from cust_company where cod_company=" & CommonClass.Qt(CustomerCodFrom.cod_company)
        Try
            TxtCompany.Text = CmdGeneral.ExecuteScalar & ""  'CustomerCodFrom.CompanyName & ""
        Catch ex As Exception
        Finally
            CmdGeneral.Connection.Close()
        End Try


    End Sub
    Private Sub CustomerCodFrom_NotFindCustomerCod() Handles CustomerCodFrom.NotFindCustomerCod
        txtMName.Text = ""
        txtFName.Text = ""
        txtLName.Text = ""
        TxtCompany.Text = ""
        '    CustomerCodFrom.CustomerCod = ""
    End Sub

    Private Sub CustomerCodFrom2_FindCustomerCod() Handles CustomerCodTo.FindCustomerCod
        txtMNameto.Text = CustomerCodTo.M_Name.Trim & ""
        txtFNameto.Text = CustomerCodTo.F_Name.Trim & ""
        txtLNameto.Text = CustomerCodTo.L_Name.Trim & ""
        
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If

        CmdGeneral.CommandText = "select abbreviation_name as companyname from cust_company where cod_company=" & CommonClass.Qt(CustomerCodTo.cod_company)
        Try
            TxtCompanyto.Text = CmdGeneral.ExecuteScalar & ""
        Catch ex As Exception
        Finally
            CmdGeneral.Connection.Close()
        End Try


    End Sub
    Private Sub CustomerCodto2_NotFindCustomerCod() Handles CustomerCodTo.NotFindCustomerCod
        txtMNameto.Text = ""
        txtFNameto.Text = ""
        txtLNameto.Text = ""
        TxtCompanyto.Text = ""
        'CustomerCodTo.CustomerCod = ""
    End Sub
    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub

    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        If CustomerCodFrom.Text <> "" Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select cod_customer from cust_trtab_main where cod_customer= " & CommonClass.Qt(CustomerCodFrom.Text)
            If (CmdGeneral.ExecuteScalar & "") = "" Then
                CustomerCodFrom.Text = ""
                CustomerCodFrom.Focus()
                CommonClass.MsgFar("Main Customer Code Is Not Exist")
                Exit Sub
            End If
        Else
            CommonClass.MsgFar("Please Enter Customer Code For Change ")
            CustomerCodFrom.Focus()
            Exit Sub
        End If

        If CustomerCodTo.Text <> "" Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select cod_customer from cust_trtab_main where cod_customer= " & CommonClass.Qt(CustomerCodTo.Text)
            If (CmdGeneral.ExecuteScalar & "") = "" Then
                CustomerCodTo.Text = ""
                CustomerCodTo.Focus()
                CommonClass.MsgFar("Merge Customer Code Is Not Exist")
                Exit Sub
            End If
        Else
            CommonClass.MsgFar("Please Enter Merge Customer Code  ")
            CustomerCodTo.Focus()
            Exit Sub
        End If

        Dim tran1 As SqlClient.SqlTransaction
        'CmdGeneral.CommandText = " select count(*) from inv_item where line= " & CommonClass.Qt(CustomerCodFrom.Text)
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        tran1 = Cnn.BeginTransaction()
        CmdGeneral.Transaction = tran1
        Try
            changecustomer("GL_account_adjustment_head", "cod_customer", CustomerCodFrom.Text.Trim, CustomerCodTo.Text)
            changecustomer("Gl_receive_payment", "cod_customer", CustomerCodFrom.Text.Trim, CustomerCodTo.Text)
            changecustomer("GL_Paid_received", "customer_code", CustomerCodFrom.Text.Trim, CustomerCodTo.Text)
            changecustomer("GL_External_Cash", "cod_customer", CustomerCodFrom.Text.Trim, CustomerCodTo.Text)
            changecustomer("service_center_head", "cod_customer", CustomerCodFrom.Text.Trim, CustomerCodTo.Text)
            changecustomer("ser_tr_vehicle", "cod_customer", CustomerCodFrom.Text.Trim, CustomerCodTo.Text)
            changecustomer("Inv_purchase_order_head", "shipto_cod_customer", CustomerCodFrom.Text.Trim, CustomerCodTo.Text)
            '            changecustomer("service_center_head", "cod_customer", CustomerCodFrom.Text.Trim, CustomerCodTo.Text)

            'changecustomer("GL_account_adjustment_head", "cod_customer", CustomerCodFrom.Text.Trim, CustomerCodTo.Text)
            CmdGeneral.CommandText = "delete from cust_trtab_main where cod_customer = " & CommonClass.Qt(CustomerCodTo.Text)
            CmdGeneral.ExecuteNonQuery()
            tran1.Commit()
            CommonClass.MsgFar("All the Merging Customer's Records were successfully combined into Main Customer's Records. ")
        Catch ex As Exception
            MsgBox(ex.ToString)
            tran1.Rollback()
        End Try
        CustomerCodFrom.Text = ""
        CustomerCodFrom.CustomerCod = ""
        CustomerCodTo.Text = ""
        CustomerCodTo.CustomerCod = ""
        CustomerCodFrom.Focus()

    End Sub

    Private Sub FrmChangeCustomerCod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = CommonClass.PConnectionString
        Call FixThisDatabase()
    End Sub
    Sub FixThisDatabase()
        Call AlterTable("service_center_head", "FK_wo_work_order_head_cust_trtab_main", False, "cod_customer")
        Call AlterTable("ser_tr_vehicle", "FK_ser_tr_vehicle_cust_trtab_main", False, "cod_customer")
        Call AlterTable("Gl_receive_payment", "FK_Gl_receive_payment_cust_trtab_main", False, "cod_customer")
        Call AlterTable("Inv_purchase_order_head", "FK_Inv_purchase_order_cust_trtab_main", False, "shipto_cod_customer")
        Call AlterTable("GL_account_adjustment_head", "FK_GL_account_adjustment_head_cust_trtab_main", False, "cod_customer")
        Call AlterTable("GL_External_Cash", "FK_GL_External_Cash_cust_trtab_mainS", False, "cod_customer")
        Call AlterTable("GL_Paid_received", "FK_GL_payment_debit_cust_trtab_main", False, "customer_code")
    End Sub
    Sub AlterTable(ByVal ThisTableName As String, ByVal ThisConstrantName As String, ByVal OnDeleteCasCade As Boolean, ByVal ForeinFieldName As String)
        Dim Str1 As String = " ALTER TABLE [dbo].[" & ThisTableName.Trim & "] Drop CONSTRAINT [" & ThisConstrantName.Trim & "]"
        Dim Str2 As String = "ALTER TABLE [dbo].[" & ThisTableName.Trim & "] ADD CONSTRAINT [" & ThisConstrantName.Trim & "] FOREIGN KEY ([" & ForeinFieldName & "]) REFERENCES [dbo].[cust_trtab_main] ([cod_customer]) " & IIf(OnDeleteCasCade, " ON DELETE CASCADE ", " ") & " ON UPDATE CASCADE "
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            Try
                CmdGeneral.CommandText = Str1
                CmdGeneral.ExecuteNonQuery()
            Catch ex As Exception
            End Try
            '-------------------------
            CmdGeneral.CommandText = Str2
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Function changecustomer(ByVal ThisTable As String, ByVal thisfield As String, ByVal from As String, ByVal delete As String) As Boolean
        '        Try
        CmdGeneral.CommandText = "update " & ThisTable & " set " & thisfield & " = " & CommonClass.Qt(from) & " where " & thisfield & " = " & CommonClass.Qt(delete)
        CmdGeneral.ExecuteNonQuery()
        '    changecustomer = True
        '       Catch ex As Exception
        '      changecustomer = False
        '     End Try
    End Function

    Private Sub CustomerCodFrom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerCodFrom.Load

    End Sub
End Class
