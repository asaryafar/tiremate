Imports CommonClass
Public Class FrmChangeCustomerSaleTax
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
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAcust_sales_tax As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmChangeCustomerSaleTax1 As UCCustomer.DSFrmChangeCustomerSaleTax
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents cmbOldSales_tax As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNewSales_tax As System.Windows.Forms.ComboBox
    Friend WithEvents CnnMDB As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAcust_sales_tax = New System.Data.SqlClient.SqlDataAdapter
        Me.DsFrmChangeCustomerSaleTax1 = New UCCustomer.DSFrmChangeCustomerSaleTax
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.cmbOldSales_tax = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmbNewSales_tax = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnExit = New Janus.Windows.EditControls.UIButton
        Me.BtnSave = New Janus.Windows.EditControls.UIButton
        Me.CnnMDB = New System.Data.OleDb.OleDbConnection
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand
        CType(Me.DsFrmChangeCustomerSaleTax1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cod_sales_tax, desc_sales_tax, Amount FROM cust_sales_tax"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=ARMANDEHserver;p" & _
        "ersist security info=True;initial catalog=TireMate_01"
        '
        'DAcust_sales_tax
        '
        Me.DAcust_sales_tax.SelectCommand = Me.SqlSelectCommand1
        Me.DAcust_sales_tax.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_sales_tax", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_sales_tax", "cod_sales_tax"), New System.Data.Common.DataColumnMapping("desc_sales_tax", "desc_sales_tax"), New System.Data.Common.DataColumnMapping("Amount", "Amount")})})
        '
        'DsFrmChangeCustomerSaleTax1
        '
        Me.DsFrmChangeCustomerSaleTax1.DataSetName = "DSFrmChangeCustomerSaleTax"
        Me.DsFrmChangeCustomerSaleTax1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'cmbOldSales_tax
        '
        Me.cmbOldSales_tax.DataSource = Me.DsFrmChangeCustomerSaleTax1.Oldcust_sales_tax
        Me.cmbOldSales_tax.DisplayMember = "desc_sales_tax"
        Me.cmbOldSales_tax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOldSales_tax.Location = New System.Drawing.Point(96, 11)
        Me.cmbOldSales_tax.Name = "cmbOldSales_tax"
        Me.cmbOldSales_tax.Size = New System.Drawing.Size(195, 21)
        Me.cmbOldSales_tax.TabIndex = 0
        Me.cmbOldSales_tax.ValueMember = "cod_sales_tax"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(8, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 19)
        Me.Label13.TabIndex = 357
        Me.Label13.Text = "Old Sales Tax"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNewSales_tax
        '
        Me.cmbNewSales_tax.DataSource = Me.DsFrmChangeCustomerSaleTax1.Newcust_sales_tax
        Me.cmbNewSales_tax.DisplayMember = "desc_sales_tax"
        Me.cmbNewSales_tax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNewSales_tax.Location = New System.Drawing.Point(97, 48)
        Me.cmbNewSales_tax.Name = "cmbNewSales_tax"
        Me.cmbNewSales_tax.Size = New System.Drawing.Size(195, 21)
        Me.cmbNewSales_tax.TabIndex = 1
        Me.cmbNewSales_tax.ValueMember = "cod_sales_tax"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(9, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 19)
        Me.Label1.TabIndex = 359
        Me.Label1.Text = "New Sales Tax"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(222, 87)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "Exit"
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(8, 87)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "Save"
        '
        'CnnMDB
        '
        Me.CnnMDB.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\TireMate\TireMatesetup.mdb;Persis" & _
        "t Security Info=True;Jet OLEDB:Database Password=5332"
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.Connection = Me.CnnMDB
        '
        'FrmChangeCustomerSaleTax
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(305, 123)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.cmbNewSales_tax)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbOldSales_tax)
        Me.Controls.Add(Me.Label13)
        Me.Name = "FrmChangeCustomerSaleTax"
        Me.Text = "Change Sale Tax"
        CType(Me.DsFrmChangeCustomerSaleTax1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmChangeCustomerSaleTax_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        Me.CnnMDB.ConnectionString = PConnectionStringForSetupTables

        BtnExit.Enabled = True
        BtnSave.Enabled = False
        DsFrmChangeCustomerSaleTax1.Clear()
        DAcust_sales_tax.Fill(DsFrmChangeCustomerSaleTax1, "Oldcust_sales_tax")
        DAcust_sales_tax.Fill(DsFrmChangeCustomerSaleTax1, "NewCust_sales_tax")
        If DsFrmChangeCustomerSaleTax1.Oldcust_sales_tax.Rows.Count < 1 Then
            MsgFar("Please Fill The Sales Tax Table")
            cmbOldSales_tax.Enabled = False
            cmbNewSales_tax.Enabled = False
            Exit Sub
        End If
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If cmbOldSales_tax.Text.Trim.Length > 0 And cmbNewSales_tax.Text.Trim.Length > 0 Then
            Dim OldMeTextVar As String = Me.Text
            Me.Text = "Waiting ..........."
            BtnSave.Enabled = False
            Try
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "UPDATE    cust_trtab_main SET   cod_sales_tax =" & Qt(cmbNewSales_tax.SelectedValue) & " Where cod_sales_tax =" & Qt(cmbOldSales_tax.SelectedValue)
                CmdGeneral.ExecuteNonQuery()
            Catch ex As Exception
                MsgFar("Error In Customer Update.")
            End Try
            Try
                If OleDbCommand1.Connection.State = ConnectionState.Closed Then
                    OleDbCommand1.Connection.Open()
                End If
                OleDbCommand1.CommandText = "UPDATE STORE_SETUP SET SALES_TAX =" & Qt(cmbNewSales_tax.SelectedValue) & " Where storeno= " & Qt(PubStoreNO)
                OleDbCommand1.ExecuteNonQuery()
                MsgFar("Tax Changes Successfully Completed.")
            Catch ex As Exception
                MsgFar("Error In Setup Table Update.")
            End Try
            Me.Text = OldMeTextVar
        Else
            MsgFar("Please Select Old and New Sales Tax")
        End If
    End Sub
    Private Sub cmbNewSales_tax_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNewSales_tax.SelectedIndexChanged, cmbOldSales_tax.SelectedIndexChanged
        BtnSave.Enabled = True
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class
