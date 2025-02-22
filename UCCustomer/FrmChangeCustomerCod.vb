Public Class FrmChangeCustomerCod
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
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdClose As Janus.Windows.EditControls.UIButton
    Friend WithEvents CustomerCodFrom As UCCustomer.CustomerCod
    Friend WithEvents CustomerCodTo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TxtCompany As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.CustomerCodFrom = New UCCustomer.CustomerCod
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtFName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CustomerCodTo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdClose = New Janus.Windows.EditControls.UIButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtCompany = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.SuspendLayout()
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'CustomerCodFrom
        '
        Me.CustomerCodFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CustomerCodFrom.Connection = Me.Cnn
        Me.CustomerCodFrom.CustomerCod = ""
        Me.CustomerCodFrom.CustomerCodLen = 10
        Me.CustomerCodFrom.Location = New System.Drawing.Point(119, 18)
        Me.CustomerCodFrom.Name = "CustomerCodFrom"
        Me.CustomerCodFrom.NotExitIfNotFound = False
        Me.CustomerCodFrom.ReleaseIfNotFoundCustomerCod = False
        Me.CustomerCodFrom.Size = New System.Drawing.Size(128, 21)
        Me.CustomerCodFrom.TabIndex = 190
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 22)
        Me.Label2.TabIndex = 191
        Me.Label2.Text = "Old Customer Code"
        '
        'txtMName
        '
        Me.txtMName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtMName.Location = New System.Drawing.Point(200, 56)
        Me.txtMName.MaxLength = 15
        Me.txtMName.Name = "txtMName"
        Me.txtMName.ReadOnly = True
        Me.txtMName.Size = New System.Drawing.Size(48, 20)
        Me.txtMName.TabIndex = 343
        Me.txtMName.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(176, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 21)
        Me.Label1.TabIndex = 347
        Me.Label1.Text = "M.I."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLName
        '
        Me.txtLName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtLName.Location = New System.Drawing.Point(280, 56)
        Me.txtLName.MaxLength = 50
        Me.txtLName.Name = "txtLName"
        Me.txtLName.ReadOnly = True
        Me.txtLName.Size = New System.Drawing.Size(128, 20)
        Me.txtLName.TabIndex = 344
        Me.txtLName.Text = ""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(248, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 21)
        Me.Label6.TabIndex = 345
        Me.Label6.Text = "Last"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFName
        '
        Me.txtFName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtFName.Location = New System.Drawing.Point(72, 56)
        Me.txtFName.MaxLength = 20
        Me.txtFName.Name = "txtFName"
        Me.txtFName.ReadOnly = True
        Me.txtFName.Size = New System.Drawing.Size(104, 20)
        Me.txtFName.TabIndex = 342
        Me.txtFName.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(0, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 21)
        Me.Label3.TabIndex = 346
        Me.Label3.Text = "FirstName"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CustomerCodTo
        '
        Me.CustomerCodTo.Location = New System.Drawing.Point(119, 144)
        Me.CustomerCodTo.MaxLength = 10
        Me.CustomerCodTo.Name = "CustomerCodTo"
        Me.CustomerCodTo.Size = New System.Drawing.Size(128, 20)
        Me.CustomerCodTo.TabIndex = 350
        Me.CustomerCodTo.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 22)
        Me.Label4.TabIndex = 351
        Me.Label4.Text = "New Customer Code"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(16, 184)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 4)
        Me.Panel1.TabIndex = 354
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(16, 200)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(73, 23)
        Me.CmdOk.TabIndex = 352
        Me.CmdOk.Text = "Save"
        '
        'CmdClose
        '
        Me.CmdClose.Location = New System.Drawing.Point(328, 200)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(73, 23)
        Me.CmdClose.TabIndex = 353
        Me.CmdClose.Text = "Exit"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(0, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 21)
        Me.Label5.TabIndex = 355
        Me.Label5.Text = "Company"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCompany
        '
        Me.TxtCompany.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TxtCompany.Location = New System.Drawing.Point(72, 96)
        Me.TxtCompany.MaxLength = 20
        Me.TxtCompany.Name = "TxtCompany"
        Me.TxtCompany.ReadOnly = True
        Me.TxtCompany.Size = New System.Drawing.Size(336, 20)
        Me.TxtCompany.TabIndex = 356
        Me.TxtCompany.Text = ""
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Location = New System.Drawing.Point(13, 131)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(394, 4)
        Me.Panel2.TabIndex = 357
        '
        'FrmChangeCustomerCod
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(416, 228)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TxtCompany)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.CmdClose)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CustomerCodTo)
        Me.Controls.Add(Me.txtMName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CustomerCodFrom)
        Me.Name = "FrmChangeCustomerCod"
        Me.Text = "Change Customer Code"
        Me.ResumeLayout(False)

    End Sub

#End Region

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



    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        If CustomerCodFrom.Text <> "" Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select cod_customer from cust_trtab_main where cod_customer= " & CommonClass.Qt(CustomerCodFrom.Text)
            If (CmdGeneral.ExecuteScalar & "") = "" Then
                CustomerCodFrom.Text = ""
                CustomerCodFrom.Focus()
                CommonClass.MsgFar("Old Customer Code Is Not Exist")
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
            If (CmdGeneral.ExecuteScalar & "") <> "" Then
                CustomerCodTo.Clear()
                CustomerCodTo.Focus()
                CommonClass.MsgFar("New Customer Code Is Already Exist")
                Exit Sub
            End If
        Else
            CommonClass.MsgFar("Please Enter New Customer Code  ")
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
        CmdGeneral.CommandText = "Update cust_trtab_main set cod_customer = " & CommonClass.Qt(CustomerCodTo.Text.Trim) & " Where cod_customer = " & CommonClass.Qt(CustomerCodFrom.Text)
        Try
            CmdGeneral.ExecuteNonQuery()
            tran1.Commit()
            CommonClass.MsgFar("Change Customer Code Complete ")
        Catch ex As Exception
            tran1.Rollback()
            MsgBox(ex.ToString)
        End Try
        CustomerCodFrom.Text = ""
        CustomerCodFrom.CustomerCod = ""
        CustomerCodTo.Clear()
        CustomerCodFrom.Focus()
        txtMName.Text = ""
        txtFName.Text = ""
        txtLName.Text = ""
        TxtCompany.Text = ""
    End Sub
    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        Me.Close()
    End Sub
    Private Sub CustomerCodFrom_FindCustomerCod() Handles CustomerCodFrom.FindCustomerCod
        txtMName.Text = CustomerCodFrom.M_Name.Trim & ""
        txtFName.Text = CustomerCodFrom.F_Name.Trim & ""
        txtLName.Text = CustomerCodFrom.L_Name.Trim & ""
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "select abbreviation_name as companyname from cust_company where cod_company=" & CommonClass.Qt(CustomerCodFrom.cod_company)
        TxtCompany.Text = CmdGeneral.ExecuteScalar & ""
    End Sub
    Private Sub CustomerCodFrom_NotFindCustomerCod() Handles CustomerCodFrom.NotFindCustomerCod
        txtMName.Text = ""
        txtFName.Text = ""
        txtLName.Text = ""
        TxtCompany.Text = ""
    End Sub

End Class
