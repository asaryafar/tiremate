Imports CommonClass
Imports Janus.Windows.GridEX

Public Class FrmPrint
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BtnDeselect As System.Windows.Forms.Button
    Friend WithEvents BtnFchooser As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnSelect As System.Windows.Forms.Button
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents BtnEmail As System.Windows.Forms.Button
    Friend WithEvents BtnJPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAGeneral As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmPrint1 As ReportBank.DSFrmPrint
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents GrdCheckDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdCheckSummery As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdDepositListDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdATMDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdTransfer As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdAdj As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdCheckByAcount As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdGLAcountSummery As Janus.Windows.GridEX.GridEX
    Friend WithEvents GrdDepositSummery As Janus.Windows.GridEX.GridEX
    Friend WithEvents DAbas_cc_type As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPrint))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout3 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout4 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout5 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout6 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout7 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout8 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout9 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.BtnFchooser = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.BtnEmail = New System.Windows.Forms.Button
        Me.BtnJPrint = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnPreview = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.BtnDeselect = New System.Windows.Forms.Button
        Me.BtnSelect = New System.Windows.Forms.Button
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAGeneral = New System.Data.SqlClient.SqlDataAdapter
        Me.DsFrmPrint1 = New ReportBank.DSFrmPrint
        Me.GrdCheckDetail = New Janus.Windows.GridEX.GridEX
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument
        Me.GrdCheckSummery = New Janus.Windows.GridEX.GridEX
        Me.GrdDepositListDetail = New Janus.Windows.GridEX.GridEX
        Me.GrdATMDetail = New Janus.Windows.GridEX.GridEX
        Me.GrdTransfer = New Janus.Windows.GridEX.GridEX
        Me.GrdAdj = New Janus.Windows.GridEX.GridEX
        Me.GrdCheckByAcount = New Janus.Windows.GridEX.GridEX
        Me.GrdGLAcountSummery = New Janus.Windows.GridEX.GridEX
        Me.GrdDepositSummery = New Janus.Windows.GridEX.GridEX
        Me.DAbas_cc_type = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand
        Me.Panel4.SuspendLayout()
        CType(Me.DsFrmPrint1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdCheckDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdCheckSummery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdDepositListDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdATMDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdTransfer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdAdj, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdCheckByAcount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdGLAcountSummery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdDepositSummery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.BtnFchooser)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label31)
        Me.Panel4.Controls.Add(Me.Label30)
        Me.Panel4.Controls.Add(Me.Label29)
        Me.Panel4.Controls.Add(Me.Label28)
        Me.Panel4.Controls.Add(Me.BtnEmail)
        Me.Panel4.Controls.Add(Me.BtnJPrint)
        Me.Panel4.Controls.Add(Me.BtnPrint)
        Me.Panel4.Controls.Add(Me.BtnPreview)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.BtnDeselect)
        Me.Panel4.Controls.Add(Me.BtnSelect)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(624, 64)
        Me.Panel4.TabIndex = 6
        '
        'BtnFchooser
        '
        Me.BtnFchooser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFchooser.Image = CType(resources.GetObject("BtnFchooser.Image"), System.Drawing.Image)
        Me.BtnFchooser.Location = New System.Drawing.Point(549, 5)
        Me.BtnFchooser.Name = "BtnFchooser"
        Me.BtnFchooser.Size = New System.Drawing.Size(33, 27)
        Me.BtnFchooser.TabIndex = 192
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(541, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 24)
        Me.Label3.TabIndex = 191
        Me.Label3.Text = "Field  Chooser"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(282, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 23)
        Me.Label2.TabIndex = 189
        Me.Label2.Text = "Deselect All"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Location = New System.Drawing.Point(497, 36)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(43, 25)
        Me.Label31.TabIndex = 182
        Me.Label31.Text = "Send to Excel"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(445, 36)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(37, 24)
        Me.Label30.TabIndex = 181
        Me.Label30.Text = "Grid Print"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(392, 39)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 180
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(335, 39)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 10)
        Me.Label28.TabIndex = 179
        Me.Label28.Text = "Preview"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEmail
        '
        Me.BtnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEmail.Image = CType(resources.GetObject("BtnEmail.Image"), System.Drawing.Image)
        Me.BtnEmail.Location = New System.Drawing.Point(499, 5)
        Me.BtnEmail.Name = "BtnEmail"
        Me.BtnEmail.Size = New System.Drawing.Size(33, 27)
        Me.BtnEmail.TabIndex = 13
        '
        'BtnJPrint
        '
        Me.BtnJPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnJPrint.Image = CType(resources.GetObject("BtnJPrint.Image"), System.Drawing.Image)
        Me.BtnJPrint.Location = New System.Drawing.Point(447, 5)
        Me.BtnJPrint.Name = "BtnJPrint"
        Me.BtnJPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnJPrint.TabIndex = 12
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(394, 5)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 11
        '
        'BtnPreview
        '
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Image = CType(resources.GetObject("BtnPreview.Image"), System.Drawing.Image)
        Me.BtnPreview.Location = New System.Drawing.Point(343, 5)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(33, 27)
        Me.BtnPreview.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(64, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 62)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select your options for printing this report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 190
        Me.PictureBox2.TabStop = False
        '
        'BtnDeselect
        '
        Me.BtnDeselect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDeselect.Image = CType(resources.GetObject("BtnDeselect.Image"), System.Drawing.Image)
        Me.BtnDeselect.Location = New System.Drawing.Point(291, 5)
        Me.BtnDeselect.Name = "BtnDeselect"
        Me.BtnDeselect.Size = New System.Drawing.Size(33, 27)
        Me.BtnDeselect.TabIndex = 193
        '
        'BtnSelect
        '
        Me.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSelect.Image = CType(resources.GetObject("BtnSelect.Image"), System.Drawing.Image)
        Me.BtnSelect.Location = New System.Drawing.Point(291, 5)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(33, 27)
        Me.BtnSelect.TabIndex = 183
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT 1 AS flag, GL_debit_deposit_head.date_doc, GL_account.desc_GL_account, bas" & _
        "_banks.name_bank, GL_debit_deposit.deposit_amount FROM GL_debit_deposit_head INN" & _
        "ER JOIN GL_debit_deposit ON GL_debit_deposit_head.id_debit_deposit_head = GL_deb" & _
        "it_deposit.id_debit_deposit_head INNER JOIN bas_banks ON GL_debit_deposit_head.i" & _
        "d_bank = bas_banks.id_bank INNER JOIN GL_account ON GL_debit_deposit.GL_account " & _
        "= GL_account.GL_account LEFT OUTER JOIN GL_payment_deposit ON GL_debit_deposit.I" & _
        "D_payment = GL_payment_deposit.ID_payment"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=MILAD;packet size=4096;integrated security=SSPI;data source=milad;" & _
        "persist security info=False;initial catalog=TireMate_01_db"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO bank_check(id_bank, no_of_check, date_of_check, amount_check, cod_ven" & _
        "dor, employee_code, address_payee, memo_check, invoice_no, manual_check, print_l" & _
        "ater, cleared_bank, check_status, id_debit_deposit_head, id_GL_journal) VALUES (" & _
        "@id_bank, @no_of_check, @date_of_check, @amount_check, @cod_vendor, @employee_co" & _
        "de, @address_payee, @memo_check, @invoice_no, @manual_check, @print_later, @clea" & _
        "red_bank, @check_status, @id_debit_deposit_head, @id_GL_journal); SELECT id_chec" & _
        "k, id_bank, no_of_check, date_of_check, amount_check, cod_vendor, employee_code," & _
        " address_payee, memo_check, invoice_no, manual_check, print_later, cleared_bank," & _
        " check_status, id_debit_deposit_head, id_GL_journal FROM bank_check WHERE (id_ch" & _
        "eck = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank", System.Data.SqlDbType.SmallInt, 2, "id_bank"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@no_of_check", System.Data.SqlDbType.VarChar, 20, "no_of_check"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_of_check", System.Data.SqlDbType.VarChar, 10, "date_of_check"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_check", System.Data.SqlDbType.Money, 8, "amount_check"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address_payee", System.Data.SqlDbType.VarChar, 150, "address_payee"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@memo_check", System.Data.SqlDbType.VarChar, 200, "memo_check"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@invoice_no", System.Data.SqlDbType.VarChar, 20, "invoice_no"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@manual_check", System.Data.SqlDbType.Bit, 1, "manual_check"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@print_later", System.Data.SqlDbType.Bit, 1, "print_later"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cleared_bank", System.Data.SqlDbType.Bit, 1, "cleared_bank"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@check_status", System.Data.SqlDbType.VarChar, 1, "check_status"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_debit_deposit_head", System.Data.SqlDbType.Int, 4, "id_debit_deposit_head"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_GL_journal", System.Data.SqlDbType.Int, 4, "id_GL_journal"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE bank_check SET id_bank = @id_bank, no_of_check = @no_of_check, date_of_che" & _
        "ck = @date_of_check, amount_check = @amount_check, cod_vendor = @cod_vendor, emp" & _
        "loyee_code = @employee_code, address_payee = @address_payee, memo_check = @memo_" & _
        "check, invoice_no = @invoice_no, manual_check = @manual_check, print_later = @pr" & _
        "int_later, cleared_bank = @cleared_bank, check_status = @check_status, id_debit_" & _
        "deposit_head = @id_debit_deposit_head, id_GL_journal = @id_GL_journal WHERE (id_" & _
        "check = @Original_id_check) AND (address_payee = @Original_address_payee OR @Ori" & _
        "ginal_address_payee IS NULL AND address_payee IS NULL) AND (amount_check = @Orig" & _
        "inal_amount_check OR @Original_amount_check IS NULL AND amount_check IS NULL) AN" & _
        "D (check_status = @Original_check_status OR @Original_check_status IS NULL AND c" & _
        "heck_status IS NULL) AND (cleared_bank = @Original_cleared_bank OR @Original_cle" & _
        "ared_bank IS NULL AND cleared_bank IS NULL) AND (cod_vendor = @Original_cod_vend" & _
        "or OR @Original_cod_vendor IS NULL AND cod_vendor IS NULL) AND (date_of_check = " & _
        "@Original_date_of_check OR @Original_date_of_check IS NULL AND date_of_check IS " & _
        "NULL) AND (employee_code = @Original_employee_code OR @Original_employee_code IS" & _
        " NULL AND employee_code IS NULL) AND (id_GL_journal = @Original_id_GL_journal OR" & _
        " @Original_id_GL_journal IS NULL AND id_GL_journal IS NULL) AND (id_bank = @Orig" & _
        "inal_id_bank OR @Original_id_bank IS NULL AND id_bank IS NULL) AND (id_debit_dep" & _
        "osit_head = @Original_id_debit_deposit_head OR @Original_id_debit_deposit_head I" & _
        "S NULL AND id_debit_deposit_head IS NULL) AND (invoice_no = @Original_invoice_no" & _
        " OR @Original_invoice_no IS NULL AND invoice_no IS NULL) AND (manual_check = @Or" & _
        "iginal_manual_check OR @Original_manual_check IS NULL AND manual_check IS NULL) " & _
        "AND (memo_check = @Original_memo_check OR @Original_memo_check IS NULL AND memo_" & _
        "check IS NULL) AND (no_of_check = @Original_no_of_check OR @Original_no_of_check" & _
        " IS NULL AND no_of_check IS NULL) AND (print_later = @Original_print_later OR @O" & _
        "riginal_print_later IS NULL AND print_later IS NULL); SELECT id_check, id_bank, " & _
        "no_of_check, date_of_check, amount_check, cod_vendor, employee_code, address_pay" & _
        "ee, memo_check, invoice_no, manual_check, print_later, cleared_bank, check_statu" & _
        "s, id_debit_deposit_head, id_GL_journal FROM bank_check WHERE (id_check = @id_ch" & _
        "eck)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank", System.Data.SqlDbType.SmallInt, 2, "id_bank"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@no_of_check", System.Data.SqlDbType.VarChar, 20, "no_of_check"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_of_check", System.Data.SqlDbType.VarChar, 10, "date_of_check"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_check", System.Data.SqlDbType.Money, 8, "amount_check"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address_payee", System.Data.SqlDbType.VarChar, 150, "address_payee"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@memo_check", System.Data.SqlDbType.VarChar, 200, "memo_check"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@invoice_no", System.Data.SqlDbType.VarChar, 20, "invoice_no"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@manual_check", System.Data.SqlDbType.Bit, 1, "manual_check"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@print_later", System.Data.SqlDbType.Bit, 1, "print_later"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cleared_bank", System.Data.SqlDbType.Bit, 1, "cleared_bank"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@check_status", System.Data.SqlDbType.VarChar, 1, "check_status"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_debit_deposit_head", System.Data.SqlDbType.Int, 4, "id_debit_deposit_head"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_GL_journal", System.Data.SqlDbType.Int, 4, "id_GL_journal"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_check", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address_payee", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address_payee", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_check", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_check_status", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "check_status", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cleared_bank", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cleared_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_of_check", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_of_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_employee_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employee_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_GL_journal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_GL_journal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_bank", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_debit_deposit_head", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_debit_deposit_head", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_invoice_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "invoice_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_manual_check", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "manual_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_memo_check", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "memo_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_no_of_check", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "no_of_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_print_later", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "print_later", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_check", System.Data.SqlDbType.Int, 4, "id_check"))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM bank_check WHERE (id_check = @Original_id_check) AND (address_payee =" & _
        " @Original_address_payee OR @Original_address_payee IS NULL AND address_payee IS" & _
        " NULL) AND (amount_check = @Original_amount_check OR @Original_amount_check IS N" & _
        "ULL AND amount_check IS NULL) AND (check_status = @Original_check_status OR @Ori" & _
        "ginal_check_status IS NULL AND check_status IS NULL) AND (cleared_bank = @Origin" & _
        "al_cleared_bank OR @Original_cleared_bank IS NULL AND cleared_bank IS NULL) AND " & _
        "(cod_vendor = @Original_cod_vendor OR @Original_cod_vendor IS NULL AND cod_vendo" & _
        "r IS NULL) AND (date_of_check = @Original_date_of_check OR @Original_date_of_che" & _
        "ck IS NULL AND date_of_check IS NULL) AND (employee_code = @Original_employee_co" & _
        "de OR @Original_employee_code IS NULL AND employee_code IS NULL) AND (id_GL_jour" & _
        "nal = @Original_id_GL_journal OR @Original_id_GL_journal IS NULL AND id_GL_journ" & _
        "al IS NULL) AND (id_bank = @Original_id_bank OR @Original_id_bank IS NULL AND id" & _
        "_bank IS NULL) AND (id_debit_deposit_head = @Original_id_debit_deposit_head OR @" & _
        "Original_id_debit_deposit_head IS NULL AND id_debit_deposit_head IS NULL) AND (i" & _
        "nvoice_no = @Original_invoice_no OR @Original_invoice_no IS NULL AND invoice_no " & _
        "IS NULL) AND (manual_check = @Original_manual_check OR @Original_manual_check IS" & _
        " NULL AND manual_check IS NULL) AND (memo_check = @Original_memo_check OR @Origi" & _
        "nal_memo_check IS NULL AND memo_check IS NULL) AND (no_of_check = @Original_no_o" & _
        "f_check OR @Original_no_of_check IS NULL AND no_of_check IS NULL) AND (print_lat" & _
        "er = @Original_print_later OR @Original_print_later IS NULL AND print_later IS N" & _
        "ULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_check", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address_payee", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address_payee", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_check", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_check_status", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "check_status", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cleared_bank", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cleared_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_of_check", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_of_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_employee_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employee_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_GL_journal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_GL_journal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_bank", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_debit_deposit_head", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_debit_deposit_head", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_invoice_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "invoice_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_manual_check", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "manual_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_memo_check", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "memo_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_no_of_check", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "no_of_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_print_later", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "print_later", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAGeneral
        '
        Me.DAGeneral.DeleteCommand = Me.SqlDeleteCommand1
        Me.DAGeneral.InsertCommand = Me.SqlInsertCommand1
        Me.DAGeneral.SelectCommand = Me.SqlSelectCommand1
        Me.DAGeneral.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bank_check", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("no_of_check", "no_of_check"), New System.Data.Common.DataColumnMapping("date_of_check", "date_of_check"), New System.Data.Common.DataColumnMapping("amount_check", "amount_check"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("address_payee", "address_payee"), New System.Data.Common.DataColumnMapping("memo_check", "memo_check"), New System.Data.Common.DataColumnMapping("invoice_no", "invoice_no"), New System.Data.Common.DataColumnMapping("manual_check", "manual_check"), New System.Data.Common.DataColumnMapping("print_later", "print_later"), New System.Data.Common.DataColumnMapping("cleared_bank", "cleared_bank"), New System.Data.Common.DataColumnMapping("check_status", "check_status"), New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        Me.DAGeneral.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DsFrmPrint1
        '
        Me.DsFrmPrint1.DataSetName = "DSFrmPrint"
        Me.DsFrmPrint1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'GrdCheckDetail
        '
        Me.GrdCheckDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdCheckDetail.DataSource = Me.DsFrmPrint1.CheckDetail
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>18</Width></Column0><Column1 ID" & _
        "=""no_of_check""><AggregateFunction>Count</AggregateFunction><Caption>Check No</Ca" & _
        "ption><DataMember>no_of_check</DataMember><EditType>NoEdit</EditType><FilterEdit" & _
        "Type>TextBox</FilterEditType><Key>no_of_check</Key><Position>1</Position><Width>" & _
        "76</Width><TotalFormatMode>UseStringFormat</TotalFormatMode><TotalFormatString>T" & _
        "otal {0} Checks</TotalFormatString></Column1><Column2 ID=""date_of_check""><Captio" & _
        "n>Date</Caption><DataMember>date_of_check</DataMember><EditType>NoEdit</EditType" & _
        "><FilterEditType>TextBox</FilterEditType><FormatString>MM/dd/yyyy</FormatString>" & _
        "<Key>date_of_check</Key><Position>2</Position><Width>68</Width></Column2><Column" & _
        "3 ID=""address_payee""><Caption>Payee/Vendor</Caption><DataMember>address_payee</D" & _
        "ataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Ke" & _
        "y>address_payee</Key><Position>3</Position><Width>120</Width></Column3><Column4 " & _
        "ID=""amount_check""><AggregateFunction>Sum</AggregateFunction><Caption>Amount</Cap" & _
        "tion><DataMember>amount_check</DataMember><EditType>NoEdit</EditType><FilterEdit" & _
        "Type>TextBox</FilterEditType><FormatString>c2</FormatString><Key>amount_check</K" & _
        "ey><Position>4</Position><TextAlignment>Far</TextAlignment><TotalFormatMode>UseS" & _
        "tringFormat</TotalFormatMode><TotalFormatString>Total Amount{0:c}</TotalFormatSt" & _
        "ring></Column4><Column5 ID=""memo_check""><Caption>Memo</Caption><DataMember>memo_" & _
        "check</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEdit" & _
        "Type><Key>memo_check</Key><Position>5</Position></Column5><Column6 ID=""name_bank" & _
        """><Caption>Bank</Caption><DataMember>name_bank</DataMember><EditType>NoEdit</Edi" & _
        "tType><FilterEditType>TextBox</FilterEditType><Key>name_bank</Key><Position>6</P" & _
        "osition></Column6></Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutDa" & _
        "ta>"
        Me.GrdCheckDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdCheckDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdCheckDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdCheckDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdCheckDetail.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GrdCheckDetail.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdCheckDetail.Location = New System.Drawing.Point(0, 64)
        Me.GrdCheckDetail.Name = "GrdCheckDetail"
        Me.GrdCheckDetail.Size = New System.Drawing.Size(624, 368)
        Me.GrdCheckDetail.TabIndex = 7
        Me.GrdCheckDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.GridEXPrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Location = New System.Drawing.Point(90, 17)
        Me.PrintPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.Visible = False
        '
        'GridEXPrintDocument1
        '
        '
        'GrdCheckSummery
        '
        Me.GrdCheckSummery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdCheckSummery.DataSource = Me.DsFrmPrint1.CheckSummery
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>31</Width></Column0><Column1 ID" & _
        "=""name_bank""><Caption>Bank</Caption><DataMember>name_bank</DataMember><EditType>" & _
        "NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>name_bank</Key><Po" & _
        "sition>1</Position><Width>123</Width></Column1><Column2 ID=""amount""><AggregateFu" & _
        "nction>Sum</AggregateFunction><Caption>amount</Caption><DataMember>amount</DataM" & _
        "ember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Format" & _
        "String>c2</FormatString><Key>amount</Key><Position>2</Position><TextAlignment>Fa" & _
        "r</TextAlignment><Width>119</Width><TotalFormatString>C2</TotalFormatString></Co" & _
        "lumn2><Column3 ID=""GL_Account""><Caption>GL Account</Caption><DataMember>GL_Accou" & _
        "nt</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditTyp" & _
        "e><Key>GL_Account</Key><Position>3</Position><Width>123</Width></Column3><Column" & _
        "4 ID=""desc_GL_account""><Caption>GL Acount Name</Caption><DataMember>desc_GL_acco" & _
        "unt</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditTy" & _
        "pe><Key>desc_GL_account</Key><Position>4</Position><Width>135</Width></Column4><" & _
        "/Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
        Me.GrdCheckSummery.DesignTimeLayout = GridEXLayout2
        Me.GrdCheckSummery.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdCheckSummery.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdCheckSummery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdCheckSummery.Location = New System.Drawing.Point(0, 64)
        Me.GrdCheckSummery.Name = "GrdCheckSummery"
        Me.GrdCheckSummery.Size = New System.Drawing.Size(624, 368)
        Me.GrdCheckSummery.TabIndex = 8
        Me.GrdCheckSummery.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'GrdDepositListDetail
        '
        Me.GrdDepositListDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdDepositListDetail.DataMember = "DepositListDetail"
        Me.GrdDepositListDetail.DataSource = Me.DsFrmPrint1
        GridEXLayout3.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>21</Width></Column0><Column1 ID" & _
        "=""id_debit_deposit_head""><Caption>Deposit No</Caption><DataMember>id_debit_depos" & _
        "it_head</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEd" & _
        "itType><Key>id_debit_deposit_head</Key><Position>1</Position><Width>84</Width></" & _
        "Column1><Column2 ID=""date_doc""><Caption>Date</Caption><DataMember>date_doc</Data" & _
        "Member><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Forma" & _
        "tString>MM/dd/yyyy</FormatString><Key>date_doc</Key><Position>2</Position><Width" & _
        ">79</Width></Column2><Column3 ID=""desc_GL_account""><AggregateFunction>Count</Agg" & _
        "regateFunction><Caption>From Acount</Caption><DataMember>desc_GL_account</DataMe" & _
        "mber><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>des" & _
        "c_GL_account</Key><Position>3</Position><Width>130</Width><TotalFormatMode>UseSt" & _
        "ringFormat</TotalFormatMode><TotalFormatString>Total Of {0} Deposit</TotalFormat" & _
        "String></Column3><Column4 ID=""check_no""><Caption>Check No</Caption><DataMember>c" & _
        "heck_no</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEd" & _
        "itType><Key>check_no</Key><Position>4</Position><Width>84</Width></Column4><Colu" & _
        "mn5 ID=""payment""><Caption>Pmnt. Method</Caption><DataMember>payment</DataMember>" & _
        "<EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>payment<" & _
        "/Key><Position>5</Position><Width>89</Width></Column5><Column6 ID=""cc_type""><Cap" & _
        "tion>CC Type</Caption><DataMember>cc_type</DataMember><DefaultGroupInterval>Text" & _
        "</DefaultGroupInterval><EditType>NoEdit</EditType><FilterEditType>TextBox</Filte" & _
        "rEditType><Key>cc_type</Key><Position>6</Position><CompareTarget>Text</CompareTa" & _
        "rget><Width>90</Width><DropDownIndex>0</DropDownIndex></Column6><Column7 ID=""dep" & _
        "osit_amount""><AggregateFunction>Sum</AggregateFunction><Caption>Amount</Caption>" & _
        "<DataMember>deposit_amount</DataMember><EditType>NoEdit</EditType><FilterEditTyp" & _
        "e>TextBox</FilterEditType><FormatString>c2</FormatString><Key>deposit_amount</Ke" & _
        "y><Position>7</Position><TextAlignment>Far</TextAlignment><Width>77</Width><Tota" & _
        "lFormatMode>UseStringFormat</TotalFormatMode><TotalFormatString>For a Total Of({" & _
        "0:c})</TotalFormatString></Column7><Column8 ID=""name_bank""><Caption>Bank</Captio" & _
        "n><DataMember>name_bank</DataMember><EditType>NoEdit</EditType><FilterEditType>T" & _
        "extBox</FilterEditType><Key>name_bank</Key><Position>8</Position><Width>81</Widt" & _
        "h></Column8></Columns><GroupCondition ID="""" /><Groups Collection=""true""><Group0 " & _
        "ID=""Group0""><ColIndex>1</ColIndex></Group0></Groups></RootTable><DropDowns Colle" & _
        "ction=""true""><DropDown0><RootTable><Columns Collection=""true""><Column0 ID=""cc_ty" & _
        "pe""><Caption>cc_type</Caption><TypeNameEmptyStringValue>System.String</TypeNameE" & _
        "mptyStringValue><EmptyStringValue /><DataMember>cc_type</DataMember><Key>cc_type" & _
        "</Key><Position>0</Position></Column0><Column1 ID=""cc_type_desc""><Caption>cc_typ" & _
        "e_desc</Caption><DataMember>cc_type_desc</DataMember><Key>cc_type_desc</Key><Pos" & _
        "ition>1</Position></Column1></Columns><GroupCondition ID="""" /></RootTable><Water" & _
        "markImage /><Font>Microsoft Sans Serif, 8.25pt</Font><ControlStyle /><AllowEdit>" & _
        "False</AllowEdit><ExpandableGroups>False</ExpandableGroups><GroupByBoxVisible>Fa" & _
        "lse</GroupByBoxVisible><HideSelection>Highlight</HideSelection><Key>cc_type</Key" & _
        "><DisplayMember>cc_type_desc</DisplayMember><ValueMember>cc_type</ValueMember></" & _
        "DropDown0></DropDowns></GridEXLayoutData>"
        Me.GrdDepositListDetail.DesignTimeLayout = GridEXLayout3
        Me.GrdDepositListDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDepositListDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDepositListDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdDepositListDetail.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdDepositListDetail.Location = New System.Drawing.Point(0, 64)
        Me.GrdDepositListDetail.Name = "GrdDepositListDetail"
        Me.GrdDepositListDetail.Size = New System.Drawing.Size(624, 368)
        Me.GrdDepositListDetail.TabIndex = 9
        Me.GrdDepositListDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'GrdATMDetail
        '
        Me.GrdATMDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdATMDetail.DataSource = Me.DsFrmPrint1.ATMDetail
        GridEXLayout4.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>22</Width></Column0><Column1 ID" & _
        "=""id_ATM""><AggregateFunction>Count</AggregateFunction><Caption>Ref No.</Caption>" & _
        "<DataMember>id_ATM</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBo" & _
        "x</FilterEditType><Key>id_ATM</Key><Position>1</Position><Width>87</Width><Total" & _
        "FormatMode>UseStringFormat</TotalFormatMode><TotalFormatString>Total Of({0})ATM<" & _
        "/TotalFormatString></Column1><Column2 ID=""date_transaction""><Caption>Date</Capti" & _
        "on><DataMember>date_transaction</DataMember><EditType>NoEdit</EditType><FilterEd" & _
        "itType>TextBox</FilterEditType><FormatString>MM/dd/yyyy</FormatString><Key>date_" & _
        "transaction</Key><Position>2</Position><Width>83</Width></Column2><Column3 ID=""p" & _
        "ayee""><Caption>Payee/Vendor</Caption><DataMember>payee</DataMember><EditType>NoE" & _
        "dit</EditType><FilterEditType>TextBox</FilterEditType><Key>payee</Key><Position>" & _
        "3</Position><Width>131</Width></Column3><Column4 ID=""amount_ATM""><AggregateFunct" & _
        "ion>Sum</AggregateFunction><Caption>Amount</Caption><DataMember>amount_ATM</Data" & _
        "Member><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Forma" & _
        "tString>c2</FormatString><Key>amount_ATM</Key><Position>4</Position><TextAlignme" & _
        "nt>Far</TextAlignment><TotalFormatMode>UseStringFormat</TotalFormatMode><TotalFo" & _
        "rmatString>For Total Amount Of ({0:c})</TotalFormatString></Column4><Column5 ID=" & _
        """name_bank""><Caption>Bank</Caption><DataMember>name_bank</DataMember><EditType>N" & _
        "oEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>name_bank</Key><Pos" & _
        "ition>5</Position><Width>121</Width></Column5></Columns><GroupCondition ID="""" />" & _
        "</RootTable></GridEXLayoutData>"
        Me.GrdATMDetail.DesignTimeLayout = GridEXLayout4
        Me.GrdATMDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdATMDetail.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GrdATMDetail.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdATMDetail.Location = New System.Drawing.Point(0, 64)
        Me.GrdATMDetail.Name = "GrdATMDetail"
        Me.GrdATMDetail.Size = New System.Drawing.Size(624, 368)
        Me.GrdATMDetail.TabIndex = 10
        Me.GrdATMDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'GrdTransfer
        '
        Me.GrdTransfer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdTransfer.DataSource = Me.DsFrmPrint1.Transfer
        GridEXLayout5.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>18</Width></Column0><Column1 ID" & _
        "=""date_transfer""><Caption>Date</Caption><DataMember>date_transfer</DataMember><E" & _
        "ditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>M" & _
        "M/dd/yyyy</FormatString><Key>date_transfer</Key><Position>1</Position><Width>78<" & _
        "/Width></Column1><Column2 ID=""amount_transfer""><AggregateFunction>Sum</Aggregate" & _
        "Function><Caption>Amount</Caption><DataMember>amount_transfer</DataMember><EditT" & _
        "ype>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</F" & _
        "ormatString><Key>amount_transfer</Key><Position>2</Position><TextAlignment>Far</" & _
        "TextAlignment><TotalFormatString>C2</TotalFormatString></Column2><Column3 ID=""Fr" & _
        "mBank""><Caption>From Bank</Caption><DataMember>FrmBank</DataMember><EditType>NoE" & _
        "dit</EditType><FilterEditType>TextBox</FilterEditType><Key>FrmBank</Key><Positio" & _
        "n>3</Position><Width>110</Width></Column3><Column4 ID=""ToBank""><Caption>To Bank<" & _
        "/Caption><DataMember>ToBank</DataMember><EditType>NoEdit</EditType><FilterEditTy" & _
        "pe>TextBox</FilterEditType><Key>ToBank</Key><Position>4</Position><Width>112</Wi" & _
        "dth></Column4><Column5 ID=""memo""><Caption>Memo</Caption><DataMember>memo</DataMe" & _
        "mber><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>mem" & _
        "o</Key><Position>5</Position><Width>166</Width></Column5></Columns><GroupConditi" & _
        "on ID="""" /></RootTable></GridEXLayoutData>"
        Me.GrdTransfer.DesignTimeLayout = GridEXLayout5
        Me.GrdTransfer.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdTransfer.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GrdTransfer.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdTransfer.Location = New System.Drawing.Point(0, 64)
        Me.GrdTransfer.Name = "GrdTransfer"
        Me.GrdTransfer.Size = New System.Drawing.Size(624, 368)
        Me.GrdTransfer.TabIndex = 11
        Me.GrdTransfer.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'GrdAdj
        '
        Me.GrdAdj.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdAdj.DataSource = Me.DsFrmPrint1.Adjustment
        GridEXLayout6.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>19</Width></Column0><Column1 ID" & _
        "=""adjustment_date""><Caption>Date</Caption><DataMember>adjustment_date</DataMembe" & _
        "r><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatStri" & _
        "ng>MM/dd/yyyy</FormatString><Key>adjustment_date</Key><Position>1</Position><Wid" & _
        "th>70</Width></Column1><Column2 ID=""Id_Adjustment_no""><AggregateFunction>Count</" & _
        "AggregateFunction><Caption>Adjust. No</Caption><DataMember>Id_Adjustment_no</Dat" & _
        "aMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>" & _
        "Id_Adjustment_no</Key><Position>2</Position><Width>80</Width><TotalFormatMode>Us" & _
        "eStringFormat</TotalFormatMode><TotalFormatString>Total Of ({0}) Adjustment</Tot" & _
        "alFormatString></Column2><Column3 ID=""deposit_amount""><AggregateFunction>Sum</Ag" & _
        "gregateFunction><Caption>Amount(-)</Caption><DataMember>deposit_amount</DataMemb" & _
        "er><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatStr" & _
        "ing>c2</FormatString><Key>deposit_amount</Key><Position>3</Position><TextAlignme" & _
        "nt>Far</TextAlignment><Width>76</Width><TotalFormatString>C2</TotalFormatString>" & _
        "</Column3><Column4 ID=""debit_amount""><AggregateFunction>Sum</AggregateFunction><" & _
        "Caption>Amount(+)</Caption><DataMember>debit_amount</DataMember><EditType>NoEdit" & _
        "</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatStrin" & _
        "g><Key>debit_amount</Key><Position>4</Position><TextAlignment>Far</TextAlignment" & _
        "><Width>90</Width><TotalFormatString>C2</TotalFormatString></Column4><Column5 ID" & _
        "=""name_bank""><Caption>Bank</Caption><DataMember>name_bank</DataMember><EditType>" & _
        "NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>name_bank</Key><Po" & _
        "sition>5</Position><Width>74</Width></Column5><Column6 ID=""desc_GL_account""><Cap" & _
        "tion>Gl Acount Name</Caption><DataMember>desc_GL_account</DataMember><EditType>N" & _
        "oEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>desc_GL_account</Ke" & _
        "y><Position>6</Position></Column6></Columns><GroupCondition ID="""" /></RootTable>" & _
        "</GridEXLayoutData>"
        Me.GrdAdj.DesignTimeLayout = GridEXLayout6
        Me.GrdAdj.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdAdj.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GrdAdj.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdAdj.Location = New System.Drawing.Point(0, 64)
        Me.GrdAdj.Name = "GrdAdj"
        Me.GrdAdj.Size = New System.Drawing.Size(624, 368)
        Me.GrdAdj.TabIndex = 12
        Me.GrdAdj.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'GrdCheckByAcount
        '
        Me.GrdCheckByAcount.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdCheckByAcount.DataSource = Me.DsFrmPrint1.CheckByAcountDetail
        GridEXLayout7.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>22</Width></Column0><Column1 ID" & _
        "=""no_of_check""><AggregateFunction>Count</AggregateFunction><Caption>Check No</Ca" & _
        "ption><DataMember>no_of_check</DataMember><EditType>NoEdit</EditType><FilterEdit" & _
        "Type>TextBox</FilterEditType><Key>no_of_check</Key><Position>1</Position><Width>" & _
        "77</Width><TotalFormatMode>UseStringFormat</TotalFormatMode><TotalFormatString>(" & _
        "{0}) Record</TotalFormatString></Column1><Column2 ID=""date_of_check""><Caption>Da" & _
        "te</Caption><DataMember>date_of_check</DataMember><EditType>NoEdit</EditType><Fi" & _
        "lterEditType>TextBox</FilterEditType><FormatString>MM/dd/yyyy</FormatString><Key" & _
        ">date_of_check</Key><Position>2</Position><Width>74</Width></Column2><Column3 ID" & _
        "=""address_payee""><Caption>Payee/Vendor</Caption><DataMember>address_payee</DataM" & _
        "ember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>ad" & _
        "dress_payee</Key><Position>3</Position><Width>90</Width></Column3><Column4 ID=""a" & _
        "mount""><AggregateFunction>Sum</AggregateFunction><Caption>Amount</Caption><DataM" & _
        "ember>amount</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Fil" & _
        "terEditType><FormatString>c2</FormatString><Key>amount</Key><Position>4</Positio" & _
        "n><TextAlignment>Far</TextAlignment><Width>68</Width><TotalFormatString>c2</Tota" & _
        "lFormatString></Column4><Column5 ID=""GL_Account""><Caption>GL Account No</Caption" & _
        "><DataMember>GL_Account</DataMember><EditType>NoEdit</EditType><FilterEditType>T" & _
        "extBox</FilterEditType><Key>GL_Account</Key><Position>5</Position><Visible>False" & _
        "</Visible><Width>89</Width></Column5><Column6 ID=""desc_GL_account""><Caption>GL a" & _
        "ccount Name</Caption><DataMember>desc_GL_account</DataMember><EditType>NoEdit</E" & _
        "ditType><FilterEditType>TextBox</FilterEditType><Key>desc_GL_account</Key><Posit" & _
        "ion>6</Position><Width>137</Width></Column6><Column7 ID=""name_bank""><Caption>Ban" & _
        "k</Caption><DataMember>name_bank</DataMember><EditType>NoEdit</EditType><FilterE" & _
        "ditType>TextBox</FilterEditType><Key>name_bank</Key><Position>7</Position><Width" & _
        ">103</Width></Column7></Columns><GroupCondition ID="""" /><Groups Collection=""true" & _
        """><Group0 ID=""Group0""><ColIndex>5</ColIndex><GroupInterval>Value</GroupInterval>" & _
        "</Group0></Groups><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>" & _
        "1</ColIndex></SortKey0></SortKeys></RootTable></GridEXLayoutData>"
        Me.GrdCheckByAcount.DesignTimeLayout = GridEXLayout7
        Me.GrdCheckByAcount.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdCheckByAcount.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdCheckByAcount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdCheckByAcount.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdCheckByAcount.Location = New System.Drawing.Point(0, 64)
        Me.GrdCheckByAcount.Name = "GrdCheckByAcount"
        Me.GrdCheckByAcount.Size = New System.Drawing.Size(624, 368)
        Me.GrdCheckByAcount.TabIndex = 13
        Me.GrdCheckByAcount.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'GrdGLAcountSummery
        '
        Me.GrdGLAcountSummery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdGLAcountSummery.DataSource = Me.DsFrmPrint1.CheckSummery
        GridEXLayout8.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>31</Width></Column0><Column1 ID" & _
        "=""Gl_account_group_subgroup1_desc""><Caption>GL Subgroup1</Caption><DataMember>Gl" & _
        "_account_group_subgroup1_desc</DataMember><EditType>NoEdit</EditType><Key>Gl_acc" & _
        "ount_group_subgroup1_desc</Key><Position>1</Position><Visible>False</Visible></C" & _
        "olumn1><Column2 ID=""GL_Account""><Caption>GL Account</Caption><DataMember>GL_Acco" & _
        "unt</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditTy" & _
        "pe><Key>GL_Account</Key><Position>2</Position><Width>123</Width></Column2><Colum" & _
        "n3 ID=""desc_GL_account""><Caption>GL Acount Name</Caption><DataMember>desc_GL_acc" & _
        "ount</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditT" & _
        "ype><Key>desc_GL_account</Key><Position>3</Position><Width>135</Width></Column3>" & _
        "<Column4 ID=""amount""><AggregateFunction>Sum</AggregateFunction><Caption>Amount</" & _
        "Caption><DataMember>amount</DataMember><EditType>NoEdit</EditType><FilterEditTyp" & _
        "e>TextBox</FilterEditType><FormatString>c2</FormatString><Key>amount</Key><Posit" & _
        "ion>4</Position><TextAlignment>Far</TextAlignment><Width>119</Width><TotalFormat" & _
        "String>C2</TotalFormatString></Column4><Column5 ID=""name_bank""><Caption>Bank</Ca" & _
        "ption><DataMember>name_bank</DataMember><EditType>NoEdit</EditType><FilterEditTy" & _
        "pe>TextBox</FilterEditType><Key>name_bank</Key><Position>5</Position><Width>123<" & _
        "/Width></Column5></Columns><GroupCondition ID="""" /><Groups Collection=""true""><Gr" & _
        "oup0 ID=""Group0""><ColIndex>1</ColIndex></Group0></Groups></RootTable></GridEXLay" & _
        "outData>"
        Me.GrdGLAcountSummery.DesignTimeLayout = GridEXLayout8
        Me.GrdGLAcountSummery.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdGLAcountSummery.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdGLAcountSummery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdGLAcountSummery.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdGLAcountSummery.Location = New System.Drawing.Point(0, 64)
        Me.GrdGLAcountSummery.Name = "GrdGLAcountSummery"
        Me.GrdGLAcountSummery.Size = New System.Drawing.Size(624, 368)
        Me.GrdGLAcountSummery.TabIndex = 14
        Me.GrdGLAcountSummery.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'GrdDepositSummery
        '
        Me.GrdDepositSummery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrdDepositSummery.DataMember = "DepositListSummery"
        Me.GrdDepositSummery.DataSource = Me.DsFrmPrint1
        GridEXLayout9.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""flag""><Colum" & _
        "nType>CheckBox</ColumnType><DataMember>flag</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>flag</Key><Position>0</Position><Width>21</Width></Column0><Column1 ID" & _
        "=""id_debit_deposit_head""><Caption>Deposit No</Caption><DataMember>id_debit_depos" & _
        "it_head</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEd" & _
        "itType><Key>id_debit_deposit_head</Key><Position>1</Position><Width>81</Width></" & _
        "Column1><Column2 ID=""date_doc""><Caption>Date</Caption><DataMember>date_doc</Data" & _
        "Member><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Forma" & _
        "tString>MM/dd/yyyy</FormatString><Key>date_doc</Key><Position>2</Position><Width" & _
        ">80</Width></Column2><Column3 ID=""amount""><AggregateFunction>Sum</AggregateFunct" & _
        "ion><Caption>Available to Deposit</Caption><DataMember>amount</DataMember><EditT" & _
        "ype>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</F" & _
        "ormatString><Key>amount</Key><Position>3</Position><TextAlignment>Far</TextAlign" & _
        "ment><Width>120</Width><TotalFormatString>c2</TotalFormatString></Column3><Colum" & _
        "n4 ID=""CashBank""><AggregateFunction>Sum</AggregateFunction><Caption>Cash Back</C" & _
        "aption><DataMember>CashBank</DataMember><EditType>NoEdit</EditType><FilterEditTy" & _
        "pe>TextBox</FilterEditType><FormatString>c2</FormatString><Key>CashBank</Key><Po" & _
        "sition>4</Position><TextAlignment>Far</TextAlignment><TotalFormatString>c2</Tota" & _
        "lFormatString></Column4><Column5 ID=""Net""><AggregateFunction>Sum</AggregateFunct" & _
        "ion><Caption>Net Deposit</Caption><DataMember>Net</DataMember><EditType>NoEdit</" & _
        "EditType><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString>" & _
        "<Key>Net</Key><Position>5</Position><TextAlignment>Far</TextAlignment><TotalForm" & _
        "atString>c2</TotalFormatString></Column5><Column6 ID=""name_bank""><Caption>Bank</" & _
        "Caption><DataMember>name_bank</DataMember><EditType>NoEdit</EditType><FilterEdit" & _
        "Type>TextBox</FilterEditType><Key>name_bank</Key><Position>6</Position><Width>92" & _
        "</Width></Column6></Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutDa" & _
        "ta>"
        Me.GrdDepositSummery.DesignTimeLayout = GridEXLayout9
        Me.GrdDepositSummery.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDepositSummery.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDepositSummery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdDepositSummery.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GrdDepositSummery.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdDepositSummery.Location = New System.Drawing.Point(0, 64)
        Me.GrdDepositSummery.Name = "GrdDepositSummery"
        Me.GrdDepositSummery.Size = New System.Drawing.Size(624, 368)
        Me.GrdDepositSummery.TabIndex = 15
        Me.GrdDepositSummery.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'DAbas_cc_type
        '
        Me.DAbas_cc_type.DeleteCommand = Me.SqlDeleteCommand6
        Me.DAbas_cc_type.InsertCommand = Me.SqlInsertCommand6
        Me.DAbas_cc_type.SelectCommand = Me.SqlSelectCommand6
        Me.DAbas_cc_type.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_cc_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cc_type", "cc_type"), New System.Data.Common.DataColumnMapping("cc_type_desc", "cc_type_desc")})})
        Me.DAbas_cc_type.UpdateCommand = Me.SqlUpdateCommand6
        '
        'SqlDeleteCommand6
        '
        Me.SqlDeleteCommand6.CommandText = "DELETE FROM bas_cc_type WHERE (cc_type = @Original_cc_type) AND (cc_type_desc = @" & _
        "Original_cc_type_desc OR @Original_cc_type_desc IS NULL AND cc_type_desc IS NULL" & _
        ")"
        Me.SqlDeleteCommand6.Connection = Me.Cnn
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cc_type", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cc_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cc_type_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cc_type_desc", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = "INSERT INTO bas_cc_type(cc_type, cc_type_desc) VALUES (@cc_type, @cc_type_desc); " & _
        "SELECT cc_type, cc_type_desc FROM bas_cc_type WHERE (cc_type = @cc_type)"
        Me.SqlInsertCommand6.Connection = Me.Cnn
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cc_type", System.Data.SqlDbType.VarChar, 2, "cc_type"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cc_type_desc", System.Data.SqlDbType.VarChar, 50, "cc_type_desc"))
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT cc_type, cc_type_desc FROM bas_cc_type"
        Me.SqlSelectCommand6.Connection = Me.Cnn
        '
        'SqlUpdateCommand6
        '
        Me.SqlUpdateCommand6.CommandText = "UPDATE bas_cc_type SET cc_type = @cc_type, cc_type_desc = @cc_type_desc WHERE (cc" & _
        "_type = @Original_cc_type) AND (cc_type_desc = @Original_cc_type_desc OR @Origin" & _
        "al_cc_type_desc IS NULL AND cc_type_desc IS NULL); SELECT cc_type, cc_type_desc " & _
        "FROM bas_cc_type WHERE (cc_type = @cc_type)"
        Me.SqlUpdateCommand6.Connection = Me.Cnn
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cc_type", System.Data.SqlDbType.VarChar, 2, "cc_type"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cc_type_desc", System.Data.SqlDbType.VarChar, 50, "cc_type_desc"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cc_type", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cc_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cc_type_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cc_type_desc", System.Data.DataRowVersion.Original, Nothing))
        '
        'FrmPrint
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(624, 430)
        Me.Controls.Add(Me.GrdDepositSummery)
        Me.Controls.Add(Me.GrdDepositListDetail)
        Me.Controls.Add(Me.GrdCheckDetail)
        Me.Controls.Add(Me.GrdCheckByAcount)
        Me.Controls.Add(Me.GrdGLAcountSummery)
        Me.Controls.Add(Me.GrdCheckSummery)
        Me.Controls.Add(Me.GrdTransfer)
        Me.Controls.Add(Me.GrdATMDetail)
        Me.Controls.Add(Me.GrdAdj)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.Name = "FrmPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel4.ResumeLayout(False)
        CType(Me.DsFrmPrint1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdCheckDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdCheckSummery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdDepositListDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdATMDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdTransfer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdAdj, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdCheckByAcount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdGLAcountSummery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdDepositSummery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Enum KindReport As Integer
        CheckDetail = 1
        CheckSummery = 2
        DepositDetail = 3
        DepositSummery = 4
        ATMDetail = 5
        ATMSummery = 6
        Transfer = 7
        Adjustment = 8
        CheckByAcountDetail = 9
        CheckByAcountSummery = 10
    End Enum
    Public KindOfReport As KindReport
    Public StrWhere As String
    Public StrFilter As String
    Public StrRdo As String
    Public Date1 As String
    Public Date2 As String
    Public DSMain As New DataSet
    Public FBank As Boolean
   

    Private Sub FrmPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString

        Select Case KindOfReport
            Case KindReport.checkDetail
                Call FillCheck()
            Case KindReport.CheckSummery
                Call FillCheckSummery()
            Case KindReport.DepositDetail
                Call FillDepositListDetail()
            Case KindReport.DepositSummery
                Call FillDepositListSummery()
            Case KindReport.ATMDetail
                Call FillATMListDetail()
            Case KindReport.ATMSummery
                Call FillATMListSummery()
            Case KindReport.Transfer
                Call FillTransferList()
            Case KindReport.Adjustment
                Call FillAdjustment()
            Case KindReport.CheckByAcountDetail
                Call FillCheckByAcount()
            Case KindReport.CheckByAcountSummery
                Call FillCheckByAcountSummery()
        End Select
        If Date1.Trim.Length > 0 Then
            GridEXPrintDocument1.PageHeaderCenter = " From: " & Date1 & "  To: " & Date2 & vbNewLine & Me.Text()
        Else
            GridEXPrintDocument1.PageHeaderCenter = Me.Text
        End If
        GridEXPrintDocument1.PageHeaderRight = "Date : " & Format(Now(), "MM/dd/yyyy")
    End Sub
    Private Sub FillCheck()
        'Dim st As String
        'st = IIf(FBank, ",0 as flagbank ", ",1 as flagbank ")

        
        DAGeneral.SelectCommand.CommandText = "SELECT     bank_check.no_of_check, bank_check.date_of_check, bank_check.address_payee, bank_check.amount_check, bank_check.memo_check, " & _
                      " bas_banks.name_bank, 1 AS flag, bas_banks.id_bank " & _
                      " FROM         bank_check INNER JOIN " & _
                      " bas_banks ON bank_check.id_bank = bas_banks.id_bank " & IIf(StrWhere.Trim.Length > 0, "  where " & StrWhere, "") & _
                      " ORDER BY dbo.ChangeDate( bank_check.date_of_check)"

        DAGeneral.Fill(DsFrmPrint1.CheckDetail)

        'If FBank Then
        '    For i As Integer = 0 To DsFrmPrint1.CheckDetail.Count - 1
        '        If DSMain.Tables("bank").Select("flag=1 and cod = " & Qt(DsFrmPrint1.CheckDetail(i).id_bank)).Length > 0 Then
        '            DsFrmPrint1.CheckDetail(i).FlagBank = 1
        '        End If
        '    Next

        'End If


        'DsFrmPrint1.CheckDetail.DefaultView.RowFilter = "  flagbank = true"
        GrdCheckDetail.SetDataBinding(DsFrmPrint1.CheckDetail, "")

        GrdCheckDetail.BringToFront()
    End Sub
    Private Sub FillCheckSummery()
        'Dim st As String
        'st = IIf(FBank, ",0 as flagbank ", ",1 as flagbank ")


        DAGeneral.SelectCommand.CommandText = "SELECT     bas_banks.name_bank, SUM(bank_check.amount_check) AS amount, 1 AS flag , bas_banks.id_bank " & _
            " FROM         bank_check INNER JOIN" & _
            " bas_banks ON bank_check.id_bank = bas_banks.id_bank" & IIf(StrWhere.Trim.Length > 0, "  where " & StrWhere, "") & _
            " GROUP BY bas_banks.name_bank, bas_banks.id_bank "

        DAGeneral.Fill(DsFrmPrint1.CheckSummery)
        GrdCheckSummery.RootTable.Columns.RemoveAt(4)
        GrdCheckSummery.RootTable.Columns.RemoveAt(3)

        'If FBank Then
        '    For i As Integer = 0 To DsFrmPrint1.CheckSummery.Count - 1
        '        If DSMain.Tables("bank").Select("flag=1 and cod = " & Qt(DsFrmPrint1.CheckSummery(i).id_bank)).Length > 0 Then
        '            DsFrmPrint1.CheckSummery(i).FlagBank = 1
        '        End If
        '    Next

        'End If

        'DsFrmPrint1.CheckSummery.DefaultView.RowFilter = "  flagbank = true"
        GrdCheckSummery.SetDataBinding(DsFrmPrint1.CheckSummery, "")

        GrdCheckSummery.BringToFront()

    End Sub
    Private Sub FillDepositListDetail()
        'Dim st As String
        'st = IIf(FBank, ",0 as flagbank ", ",1 as flagbank ")

        'DAGeneral.SelectCommand.CommandText = "SELECT     1 AS flag, GL_debit_deposit_head.date_doc, GL_account.desc_GL_account, bas_banks.name_bank, GL_debit_deposit.deposit_amount , bas_banks.id_bank " & _
        '              " FROM         GL_debit_deposit_head INNER JOIN " & _
        '              " GL_debit_deposit ON GL_debit_deposit_head.id_debit_deposit_head = GL_debit_deposit.id_debit_deposit_head INNER JOIN " & _
        '              " bas_banks ON GL_debit_deposit_head.id_bank = bas_banks.id_bank INNER JOIN " & _
        '              " GL_account ON GL_debit_deposit.GL_account = GL_account.GL_account LEFT OUTER JOIN " & _
        '              " GL_payment_deposit ON GL_debit_deposit.ID_payment = GL_payment_deposit.ID_payment " & IIf(StrWhere.Trim.Length > 0, "  where " & StrWhere, "") & _
        '              " ORDER BY dbo.ChangeDate( GL_debit_deposit_head.date_doc) "
        DAbas_cc_type.Fill(DsFrmPrint1.bas_cc_type)
        GrdDepositListDetail.DropDowns("cc_type").SetDataBinding(DsFrmPrint1, "bas_cc_type")



        DAGeneral.SelectCommand.CommandText = " SELECT     1 AS flag, GL_debit_deposit_head.date_doc, GL_account.desc_GL_account, bas_banks.name_bank, isnull(GL_debit_deposit.deposit_amount,0) - isnull(GL_debit_deposit.debit_amount,0) as deposit_amount,  " & _
"                       bas_banks.id_bank, GL_debit_deposit.id_debit_deposit_head,  " & _
"                       CASE WHEN GL_payment_deposit.payment_type = 1 THEN 'Cash' WHEN GL_payment_deposit.payment_type = 2 THEN 'CHECK' WHEN GL_payment_deposit.payment_type " & _
"                        = 3 THEN 'Credit' WHEN GL_payment_deposit.payment_type = 4 THEN 'AR' END AS payment,  " & _
"                       CASE WHEN type_transaction = '5' THEN GL_External_Cash.check_no ELSE (CASE WHEN refer_type = '1' THEN GL_payment_check.check_no ELSE Gl_receive_payment.check_no " & _
"                        END) END AS check_no, CASE WHEN type_transaction = '5' THEN GL_External_Cash.cc_type ELSE Gl_receive_payment.cc_type END AS cc_type " & _
" FROM         GL_External_Cash RIGHT OUTER JOIN " & _
"                       GL_payment_check RIGHT OUTER JOIN " & _
"                       Gl_receive_payment RIGHT OUTER JOIN " & _
"                       GL_payment_deposit ON Gl_receive_payment.refrence_no = GL_payment_deposit.refrence_no RIGHT OUTER JOIN " & _
"                       GL_debit_deposit_head INNER JOIN " & _
"                       GL_debit_deposit ON GL_debit_deposit_head.id_debit_deposit_head = GL_debit_deposit.id_debit_deposit_head INNER JOIN " & _
"                       bas_banks ON GL_debit_deposit_head.id_bank = bas_banks.id_bank LEFT OUTER JOIN " & _
"                       GL_account ON GL_debit_deposit.GL_account = GL_account.GL_account ON GL_payment_deposit.ID_payment = GL_debit_deposit.ID_payment ON  " & _
"                       GL_payment_check.ID_payment = GL_payment_deposit.ID_payment ON  " & _
"                       GL_External_Cash.id_external_cash = GL_debit_deposit.id_external_cash " & _
"      Where    GL_debit_deposit_head.id_debit_deposit_head in (SELECT     GL_debit_deposit_head.id_debit_deposit_head " & _
"              FROM         GL_debit_deposit INNER JOIN " & _
"                       GL_debit_deposit_head ON GL_debit_deposit.id_debit_deposit_head = GL_debit_deposit_head.id_debit_deposit_head " & _
"              GROUP BY GL_debit_deposit_head.id_debit_deposit_head " & _
"              HAVING      (SUM(ISNULL(GL_debit_deposit.deposit_amount, 0)) > 0)) and  GL_debit_deposit.type_transaction <> '6' " & IIf(StrWhere.Trim.Length > 0, "  And " & StrWhere, "") & _
 " ORDER BY dbo.ChangeDate(GL_debit_deposit_head.date_doc) "

        DAGeneral.Fill(DsFrmPrint1.DepositListDetail)

        'If FBank Then
        '    For i As Integer = 0 To DsFrmPrint1.DepositListDetail.Count - 1
        '        If DSMain.Tables("bank").Select("flag=1 and cod = " & Qt(DsFrmPrint1.DepositListDetail(i).id_bank)).Length > 0 Then
        '            DsFrmPrint1.DepositListDetail(i).FlagBank = 1
        '        End If
        '    Next
        'End If

        'DsFrmPrint1.DepositListDetail.DefaultView.RowFilter = " flagbank = true"
        GrdDepositListDetail.SetDataBinding(DsFrmPrint1.DepositListDetail, "")

        GrdDepositListDetail.BringToFront()


    End Sub
    Private Sub FillDepositListSummery()
        'Dim st As String
        'st = IIf(FBank, ",0 as flagbank ", ",1 as flagbank ")


        'DAGeneral.SelectCommand.CommandText = " SELECT     bas_banks.name_bank, SUM(GL_debit_deposit.deposit_amount) AS amount, 1 AS flag, bas_banks.id_bank " & _
        '              " FROM         GL_debit_deposit_head INNER JOIN " & _
        '              " GL_debit_deposit ON GL_debit_deposit_head.id_debit_deposit_head = GL_debit_deposit.id_debit_deposit_head INNER JOIN " & _
        '              " bas_banks ON GL_debit_deposit_head.id_bank = bas_banks.id_bank LEFT OUTER JOIN " & _
        '              " GL_payment_deposit ON GL_debit_deposit.ID_payment = GL_payment_deposit.ID_payment " & IIf(StrWhere.Trim.Length > 0, "  where " & StrWhere, "") & _
        '              " GROUP BY bas_banks.name_bank, bas_banks.id_bank  "
        DAGeneral.SelectCommand.CommandText = " SELECT     GL_debit_deposit.id_debit_deposit_head, bas_banks.name_bank, SUM(ISNULL(GL_debit_deposit.deposit_amount, 0) )   AS amount, 1 AS flag,  " & _
"                       bas_banks.id_bank, GL_debit_deposit_head.date_doc, SUM(ISNULL(GL_debit_deposit.debit_amount, 0)) AS CashBank,  " & _
"                       SUM(ISNULL(GL_debit_deposit.deposit_amount, 0)) - SUM(ISNULL(GL_debit_deposit.debit_amount, 0)) AS Net " & _
" FROM         GL_debit_deposit_head INNER JOIN " & _
"                       GL_debit_deposit ON GL_debit_deposit_head.id_debit_deposit_head = GL_debit_deposit.id_debit_deposit_head INNER JOIN " & _
"                       bas_banks ON GL_debit_deposit_head.id_bank = bas_banks.id_bank LEFT OUTER JOIN" & _
"                       GL_payment_deposit ON GL_debit_deposit.ID_payment = GL_payment_deposit.ID_payment " & _
"  where GL_debit_deposit.type_transaction <> '6'   " & IIf(StrWhere.Trim.Length > 0, "  and " & StrWhere, "") & _
" GROUP BY GL_debit_deposit.id_debit_deposit_head, bas_banks.name_bank, bas_banks.id_bank, GL_debit_deposit_head.date_doc  " & _
"  HAVING      (SUM(ISNULL(GL_debit_deposit.deposit_amount, 0)) > 0) "

        DAGeneral.Fill(DsFrmPrint1.DepositListSummery)
        'GrdCheckSummery.RootTable.Columns.RemoveAt(4)
        'GrdCheckSummery.RootTable.Columns.RemoveAt(3)

        'If FBank Then
        '    For i As Integer = 0 To DsFrmPrint1.CheckSummery.Count - 1
        '        If DSMain.Tables("bank").Select("flag=1 and cod = " & Qt(DsFrmPrint1.CheckSummery(i).id_bank)).Length > 0 Then
        '            DsFrmPrint1.CheckSummery(i).FlagBank = 1
        '        End If
        '    Next
        'End If

        'DsFrmPrint1.CheckSummery.DefaultView.RowFilter = " flagbank = true "
        GrdDepositSummery.SetDataBinding(DsFrmPrint1.DepositListSummery, "")

        GrdDepositSummery.BringToFront()

    End Sub
    Private Sub FillATMListDetail()

        'Dim st As String
        'st = IIf(FBank, ",0 as flagbank ", ",1 as flagbank ")


        DAGeneral.SelectCommand.CommandText = "SELECT     bank_ATM.id_ATM, bank_ATM.date_transaction, bank_ATM.memo_address AS payee, bank_ATM.amount_ATM, bas_banks.name_bank," & _
               " 1 as flag,bas_banks.id_bank" & _
               " FROM         bank_ATM INNER JOIN " & _
               " bas_banks ON bank_ATM.id_bank = bas_banks.id_bank " & IIf(StrWhere.Trim.Length > 0, "  where " & StrWhere, "") & _
                      " ORDER BY dbo.ChangeDate( bank_ATM.date_transaction)"

        DAGeneral.Fill(DsFrmPrint1.ATMDetail)
        'If FBank Then
        '    For i As Integer = 0 To DsFrmPrint1.ATMDetail.Count - 1
        '        If DSMain.Tables("bank").Select("flag=1 and cod = " & Qt(DsFrmPrint1.ATMDetail(i).id_bank)).Length > 0 Then
        '            DsFrmPrint1.ATMDetail(i).FlagBank = 1
        '        End If
        '    Next

        'End If


        'DsFrmPrint1.ATMDetail.DefaultView.RowFilter = "  flagbank = true "
        GrdATMDetail.SetDataBinding(DsFrmPrint1.ATMDetail, "")

        GrdATMDetail.BringToFront()
    End Sub
    Private Sub FillATMListSummery()
        'Dim st As String
        'st = IIf(FBank, ",0 as flagbank ", ",1 as flagbank ")


        DAGeneral.SelectCommand.CommandText = " SELECT      bas_banks.name_bank ,SUM(bank_ATM.amount_ATM) AS amount , 1 AS flag ,bas_banks.id_bank " & _
               " FROM         bank_ATM INNER JOIN " & _
               " bas_banks ON bank_ATM.id_bank = bas_banks.id_bank " & IIf(StrWhere.Trim.Length > 0, "  where " & StrWhere, "") & _
               " GROUP BY bas_banks.name_bank,bas_banks.id_bank "

        DAGeneral.Fill(DsFrmPrint1.CheckSummery)

        'If FBank Then
        '    For i As Integer = 0 To DsFrmPrint1.CheckSummery.Count - 1
        '        If DSMain.Tables("bank").Select("flag=1 and cod = " & Qt(DsFrmPrint1.CheckSummery(i).id_bank)).Length > 0 Then
        '            DsFrmPrint1.CheckSummery(i).FlagBank = 1
        '        End If
        '    Next

        'End If

        'DsFrmPrint1.CheckSummery.DefaultView.RowFilter = "   flagbank = true"
        GrdCheckSummery.SetDataBinding(DsFrmPrint1.CheckSummery, "")

        GrdCheckSummery.RootTable.Columns.RemoveAt(4)
        GrdCheckSummery.RootTable.Columns.RemoveAt(3)
        GrdCheckSummery.BringToFront()

    End Sub
    Private Sub FillTransferList()
        'Dim st As String
        'st = IIf(FBank, ",0 as flagbank ", ",1 as flagbank ")


        DAGeneral.SelectCommand.CommandText = "SELECT     GL_transfer_amount.date_transfer, GL_transfer_amount.amount_transfer, bas_banks_1.name_bank AS FrmBank, bas_banks.name_bank AS ToBank, " & _
                 " GL_transfer_amount.memo, 1 AS flag ,bas_banks.id_bank" & _
                 " FROM         bas_banks bas_banks_1 INNER JOIN " & _
                 " GL_transfer_amount ON bas_banks_1.id_bank = GL_transfer_amount.id_bank_from_transfer INNER JOIN " & _
                 " bas_banks ON GL_transfer_amount.id_bank_to_transfer = bas_banks.id_bank " & IIf(StrWhere.Trim.Length > 0, "  where " & StrWhere, "") & _
                      " ORDER BY dbo.ChangeDate(GL_transfer_amount.date_transfer)"

        DAGeneral.Fill(DsFrmPrint1.Transfer)

        'If FBank Then
        '    For i As Integer = 0 To DsFrmPrint1.Transfer.Count - 1
        '        If DSMain.Tables("bank").Select("flag=1 and cod = " & Qt(DsFrmPrint1.Transfer(i).id_bank)).Length > 0 Then
        '            DsFrmPrint1.Transfer(i).FlagBank = 1
        '        End If
        '    Next

        'End If

        'DsFrmPrint1.Transfer.DefaultView.RowFilter = "   flagbank = true"
        GrdTransfer.SetDataBinding(DsFrmPrint1.Transfer, "")


        GrdTransfer.BringToFront()

    End Sub
    Private Sub FillAdjustment()
        'Dim st As String
        'st = IIf(FBank, ",0 as flagbank ", ",1 as flagbank ")

        DAGeneral.SelectCommand.CommandText = "SELECT     bank_adjustment_head.adjustment_date, bank_adjustment_head.Id_Adjustment_no, Bank_Adjustment_dtl.deposit_amount, " & _
             " Bank_Adjustment_dtl.debit_amount, bas_banks.name_bank, GL_account.desc_GL_account,1 as flag,bas_banks.id_bank " & _
             " FROM         bank_adjustment_head INNER JOIN " & _
             " Bank_Adjustment_dtl ON bank_adjustment_head.Id_Adjustment_no = Bank_Adjustment_dtl.Id_Adjustment_no INNER JOIN " & _
             " bas_banks ON bank_adjustment_head.id_Bank = bas_banks.id_bank INNER JOIN " & _
             " GL_account ON Bank_Adjustment_dtl.Gl_Account = GL_account.GL_account " & IIf(StrWhere.Trim.Length > 0, "  where " & StrWhere, "") & _
                      " ORDER BY dbo.ChangeDate( bank_adjustment_head.adjustment_date)"
        DAGeneral.Fill(DsFrmPrint1.Adjustment)


        'If FBank Then
        '    For i As Integer = 0 To DsFrmPrint1.Adjustment.Count - 1
        '        If DSMain.Tables("bank").Select("flag=1 and cod = " & Qt(DsFrmPrint1.Adjustment(i).id_bank)).Length > 0 Then
        '            DsFrmPrint1.Adjustment(i).FlagBank = 1
        '        End If
        '    Next

        'End If

        'DsFrmPrint1.Adjustment.DefaultView.RowFilter = "   flagbank = true"
        GrdAdj.SetDataBinding(DsFrmPrint1.Adjustment, "")

        GrdAdj.BringToFront()

    End Sub
    Private Sub FillCheckByAcount()
        'Dim st As String
        'st = IIf(FBank, ",0 as flagbank ", ",1 as flagbank ")

        DAGeneral.SelectCommand.CommandText = "SELECT     bank_check.no_of_check, bank_check.date_of_check, bank_check.address_payee, bank_check_dtl.amount, bank_check_dtl.GL_Account, " & _
           " GL_account.desc_GL_account, bas_banks.name_bank,1 as flag ,bas_banks.id_bank" & _
           " FROM         bank_check INNER JOIN " & _
           " bank_check_dtl ON bank_check.id_check = bank_check_dtl.id_check INNER JOIN " & _
           " bas_banks ON bank_check.id_bank = bas_banks.id_bank INNER JOIN " & _
           " GL_account ON bank_check_dtl.GL_Account = GL_account.GL_account " & IIf(StrWhere.Trim.Length > 0, "  where " & StrWhere, "") & _
           " ORDER BY bank_check_dtl.GL_Account, bank_check.no_of_check " '  dbo.ChangeDate(bank_check.date_of_check)"

        DAGeneral.Fill(DsFrmPrint1.CheckByAcountDetail)

        'If FBank Then
        '    For i As Integer = 0 To DsFrmPrint1.CheckByAcountDetail.Count - 1
        '        If DSMain.Tables("bank").Select("flag=1 and cod = " & Qt(DsFrmPrint1.CheckByAcountDetail(i).id_bank)).Length > 0 Then
        '            DsFrmPrint1.CheckByAcountDetail(i).FlagBank = 1
        '        End If
        '    Next

        'End If

        'DsFrmPrint1.CheckByAcountDetail.DefaultView.RowFilter = "   flagbank = true"
        GrdCheckByAcount.SetDataBinding(DsFrmPrint1.CheckByAcountDetail, "")

        GrdCheckByAcount.BringToFront()

    End Sub
    Private Sub FillCheckByAcountSummery()
        'Dim st As String
        'st = IIf(FBank, ",0 as flagbank ", ",1 as flagbank ")

        DAGeneral.SelectCommand.CommandText = " SELECT     bas_banks.name_bank, SUM(bank_check_dtl.amount) AS amount, 1 AS flag, bank_check_dtl.GL_Account, GL_account.desc_GL_account,  " & _
                       " bas_banks.id_bank, GL_account_group_subgroup1.Gl_account_group_subgroup1_desc " & _
                       " FROM         bank_check INNER JOIN " & _
                       " bank_check_dtl ON bank_check.id_check = bank_check_dtl.id_check INNER JOIN " & _
                       " bas_banks ON bank_check.id_bank = bas_banks.id_bank INNER JOIN " & _
                       " GL_account ON bank_check_dtl.GL_Account = GL_account.GL_account INNER JOIN " & _
                       " GL_account_group_subgroup1 ON  " & _
                       " GL_account.Gl_account_group_subgroup1_code = GL_account_group_subgroup1.Gl_account_group_subgroup1_code " & _
                       IIf(StrWhere.Trim.Length > 0, "  where " & StrWhere, "") & _
                       " GROUP BY bas_banks.name_bank, bank_check_dtl.GL_Account, GL_account.desc_GL_account, bas_banks.id_bank,  " & _
                       " GL_account_group_subgroup1.Gl_account_group_subgroup1_desc "

        DAGeneral.Fill(DsFrmPrint1.CheckSummery)

        'If FBank Then
        '    For i As Integer = 0 To DsFrmPrint1.CheckSummery.Count - 1
        '        If DSMain.Tables("bank").Select("flag=1 and cod = " & Qt(DsFrmPrint1.CheckSummery(i).id_bank)).Length > 0 Then
        '            DsFrmPrint1.CheckSummery(i).FlagBank = 1
        '        End If
        '    Next

        'End If

        'DsFrmPrint1.CheckSummery.DefaultView.RowFilter = "   flagbank = true"
        GrdCheckSummery.SetDataBinding(DsFrmPrint1.CheckSummery, "")

        GrdGLAcountSummery.BringToFront()

    End Sub

    Private Sub BtnFchooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFchooser.Click
        Select Case KindOfReport
            Case KindReport.CheckDetail
                Me.GrdCheckDetail.ShowFieldChooser(Me)
            Case KindReport.DepositDetail
                Me.GrdDepositListDetail.ShowFieldChooser(Me)
            Case KindReport.ATMDetail
                Me.GrdATMDetail.ShowFieldChooser(Me)
            Case KindReport.Transfer
                Me.GrdTransfer.ShowFieldChooser(Me)
            Case KindReport.Adjustment
                Me.GrdAdj.ShowFieldChooser(Me)
            Case KindReport.CheckByAcountDetail
                Me.GrdCheckByAcount.ShowFieldChooser(Me)
            Case Else
                Me.GrdCheckSummery.ShowFieldChooser(Me)
        End Select

    End Sub

    Private Sub BtnJPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJPrint.Click
        Select Case KindOfReport
            Case KindReport.CheckDetail
                GridEXPrintDocument1.GridEX = GrdCheckDetail
            Case KindReport.DepositDetail
                GridEXPrintDocument1.GridEX = GrdDepositListDetail
            Case KindReport.ATMDetail
                GridEXPrintDocument1.GridEX = GrdATMDetail
            Case KindReport.Transfer
                GridEXPrintDocument1.GridEX = GrdTransfer
            Case KindReport.Adjustment
                GridEXPrintDocument1.GridEX = GrdAdj
            Case KindReport.CheckByAcountDetail
                GridEXPrintDocument1.GridEX = GrdCheckByAcount
            Case Else
                GridEXPrintDocument1.GridEX = GrdCheckSummery
        End Select
        Dim filter As GridEXFilterCondition
        Dim filter1 As GridEXFilterCondition = GridEXPrintDocument1.GridEX.RootTable.FilterCondition
        filter = New GridEXFilterCondition(GridEXPrintDocument1.GridEX.RootTable.Columns("flag"), ConditionOperator.Equal, True)
        'filter1 = GridEXPrintDocument1.GridEX.RootTable.FilterCondition
        If filter1 Is Nothing Then
            filter1 = New GridEXFilterCondition
        End If
        GridEXPrintDocument1.GridEX.RootTable.FilterCondition = Nothing
        filter1.AddCondition(LogicalOperator.And, filter)

        GridEXPrintDocument1.GridEX.RootTable.FilterCondition = filter1
        GridEXPrintDocument1.GridEX.RootTable.Columns("flag").Visible = False

        PrintPreviewDialog1.ShowDialog()
        'Grd1.RemoveFilters()
        GridEXPrintDocument1.GridEX.RootTable.FilterCondition = Nothing
        filter1.RemoveCondition(filter)
        GridEXPrintDocument1.GridEX.RootTable.FilterCondition = filter1
        GridEXPrintDocument1.GridEX.RootTable.Columns("flag").Visible = True
    End Sub

    Private Sub BtnEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmail.Click
        Dim FileName As String
        If FolderBrowserDialog1.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If
        FileName = "report.CSV"
        Select Case KindOfReport
            Case KindReport.CheckDetail
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdCheckDetail)
            Case KindReport.DepositDetail
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdDepositListDetail)
            Case KindReport.ATMDetail
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdATMDetail)
            Case KindReport.Transfer
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdTransfer)
            Case KindReport.Adjustment
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdAdj)
            Case KindReport.CheckByAcountDetail
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdCheckByAcount)
            Case Else
                Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdCheckSummery)
        End Select

    End Sub

    Private Sub BtnDeselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeselect.Click
        Select Case KindOfReport
            Case KindReport.CheckDetail
                For i As Integer = 0 To DsFrmPrint1.CheckDetail.Count - 1
                    DsFrmPrint1.CheckDetail(i).flag = False
                Next
            Case KindReport.DepositDetail
                For i As Integer = 0 To DsFrmPrint1.DepositListDetail.Count - 1
                    DsFrmPrint1.DepositListDetail(i).flag = False
                Next
            Case KindReport.ATMDetail
                For i As Integer = 0 To DsFrmPrint1.ATMDetail.Count - 1
                    DsFrmPrint1.ATMDetail(i).flag = False
                Next
            Case KindReport.Transfer
                For i As Integer = 0 To DsFrmPrint1.Transfer.Count - 1
                    DsFrmPrint1.Transfer(i).flag = False
                Next
            Case KindReport.Adjustment
                For i As Integer = 0 To DsFrmPrint1.Adjustment.Count - 1
                    DsFrmPrint1.Adjustment(i).flag = False
                Next
            Case KindReport.CheckByAcountDetail
                For i As Integer = 0 To DsFrmPrint1.CheckDetail.Count - 1
                    DsFrmPrint1.CheckByAcountDetail(i).flag = False
                Next
            Case Else
                For i As Integer = 0 To DsFrmPrint1.CheckSummery.Count - 1
                    DsFrmPrint1.CheckSummery(i).flag = False
                Next
        End Select

        BtnDeselect.SendToBack()
        Label2.Text = "Select All"
    End Sub
    Private Sub BtnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelect.Click
        Select Case KindOfReport
            Case KindReport.CheckDetail
                For i As Integer = 0 To DsFrmPrint1.CheckDetail.Count - 1
                    DsFrmPrint1.CheckDetail(i).flag = True
                Next
            Case KindReport.DepositDetail
                For i As Integer = 0 To DsFrmPrint1.DepositListDetail.Count - 1
                    DsFrmPrint1.DepositListDetail(i).flag = True
                Next
            Case KindReport.ATMDetail
                For i As Integer = 0 To DsFrmPrint1.ATMDetail.Count - 1
                    DsFrmPrint1.ATMDetail(i).flag = True
                Next
            Case KindReport.Transfer
                For i As Integer = 0 To DsFrmPrint1.Transfer.Count - 1
                    DsFrmPrint1.Transfer(i).flag = True
                Next
            Case KindReport.Adjustment
                For i As Integer = 0 To DsFrmPrint1.Adjustment.Count - 1
                    DsFrmPrint1.Adjustment(i).flag = True
                Next
            Case KindReport.CheckByAcountDetail
                For i As Integer = 0 To DsFrmPrint1.CheckDetail.Count - 1
                    DsFrmPrint1.CheckByAcountDetail(i).flag = True
                Next
            Case Else
                For i As Integer = 0 To DsFrmPrint1.CheckSummery.Count - 1
                    DsFrmPrint1.CheckSummery(i).flag = True
                Next
        End Select
        BtnSelect.SendToBack()
        Label2.Text = "Deselect All"
    End Sub

    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        Select Case KindOfReport
            Case KindReport.CheckDetail
                Call pprint1("priv")
            Case KindReport.DepositDetail
                Call pprint2("priv")
            Case KindReport.ATMDetail
                Call pprint3("priv")
            Case KindReport.Transfer
                Call pprint4("priv")
            Case KindReport.Adjustment
                Call pprint5("priv")
            Case KindReport.CheckByAcountDetail
                Call pprint6("priv")
            Case Else
                Call pprint7("priv")
        End Select
    End Sub
    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

        Select Case KindOfReport
            Case KindReport.CheckDetail
                Call pprint1("print")
            Case KindReport.DepositDetail
                Call pprint2("print")
            Case KindReport.ATMDetail
                Call pprint3("print")
            Case KindReport.Transfer
                Call pprint4("print")
            Case KindReport.Adjustment
                Call pprint5("print")
            Case KindReport.CheckByAcountDetail
                Call pprint6("print")
            Case Else
                Call pprint7("print")
        End Select
    End Sub
    Private Sub pprint1(ByVal type As String)

        Dim rpt As New RepCheckDetail
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")

        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", Me.Text)
        rpt.SetParameterValue("Parfilter", StrFilter)

        rpt.SetDataSource(DsFrmPrint1)
        Select Case type
            Case "print"
                Try
                    rpt.PrintToPrinter(1, True, 0, 0)
                Catch ex As Exception

                End Try
            Case "priv"
                prn.CrViewer.ReportSource = rpt
                prn.ShowDialog()
        End Select
    End Sub
    Private Sub pprint2(ByVal type As String)

        Dim rpt As New RepDepositDetail
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")

        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", Me.Text)
        rpt.SetParameterValue("Parfilter", StrFilter)

        rpt.SetDataSource(DsFrmPrint1)
        Select Case type
            Case "print"
                Try
                    rpt.PrintToPrinter(1, True, 0, 0)
                Catch ex As Exception

                End Try
            Case "priv"
                prn.CrViewer.ReportSource = rpt
                prn.ShowDialog()
        End Select
    End Sub
    Private Sub pprint3(ByVal type As String)

        Dim rpt As New RepATMDetail
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")

        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", Me.Text)
        rpt.SetParameterValue("Parfilter", StrFilter)

        rpt.SetDataSource(DsFrmPrint1)
        Select Case type
            Case "print"
                Try
                    rpt.PrintToPrinter(1, True, 0, 0)
                Catch ex As Exception

                End Try
            Case "priv"
                prn.CrViewer.ReportSource = rpt
                prn.ShowDialog()
        End Select
    End Sub
    Private Sub pprint4(ByVal type As String)

        Dim rpt As New RepTransferDetail
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")

        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", Me.Text)
        rpt.SetParameterValue("Parfilter", StrFilter)

        rpt.SetDataSource(DsFrmPrint1)
        Select Case type
            Case "print"
                Try
                    rpt.PrintToPrinter(1, True, 0, 0)
                Catch ex As Exception

                End Try
            Case "priv"
                prn.CrViewer.ReportSource = rpt
                prn.ShowDialog()
        End Select
    End Sub
    Private Sub pprint5(ByVal type As String)

        Dim rpt As New RepAdjustment
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")

        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", Me.Text)
        rpt.SetParameterValue("Parfilter", StrFilter)

        rpt.SetDataSource(DsFrmPrint1)
        Select Case type
            Case "print"
                Try
                    rpt.PrintToPrinter(1, True, 0, 0)
                Catch ex As Exception

                End Try
            Case "priv"
                prn.CrViewer.ReportSource = rpt
                prn.ShowDialog()
        End Select
    End Sub
    Private Sub pprint6(ByVal type As String)

        Dim rpt As New RepCheckByAcountDetail
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")

        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", Me.Text)
        rpt.SetParameterValue("Parfilter", StrFilter)
        rpt.SetDataSource(DsFrmPrint1)
        Select Case type
            Case "print"
                Try
                    rpt.PrintToPrinter(1, True, 0, 0)
                Catch ex As Exception

                End Try
            Case "priv"
                prn.CrViewer.ReportSource = rpt
                prn.ShowDialog()
        End Select
    End Sub
    Private Sub pprint7(ByVal type As String)

        Dim rpt As New RepSummery
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetParameterValue("Parstorename", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parstorno", OleDbReaderForStore.Item("SHORTNAME") & "")

        rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("Parrepname", Me.Text)
        If KindOfReport = KindReport.CheckByAcountSummery Then
            rpt.SetParameterValue("Par1", "GL Acount No")
            rpt.SetParameterValue("Par2", "GL Acount Name")
        Else
            rpt.SetParameterValue("Par1", "")
            rpt.SetParameterValue("Par2", "")
        End If


        rpt.SetDataSource(DsFrmPrint1)
        Select Case type
            Case "print"
                Try
                    rpt.PrintToPrinter(1, True, 0, 0)
                Catch ex As Exception
                End Try
            Case "priv"
                prn.CrViewer.ReportSource = rpt
                prn.ShowDialog()
        End Select
    End Sub
    Dim x As Integer = 0
    Private Sub GridEXPrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles GridEXPrintDocument1.PrintPage
        x = x + 1
        GridEXPrintDocument1.PageFooterRight = x
    End Sub
    Private Sub GridEXPrintDocument1_EndPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GridEXPrintDocument1.EndPrint
        x = 0
    End Sub


End Class
