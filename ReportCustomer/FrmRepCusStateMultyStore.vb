Imports CommonClass
Public Class FrmRepCusStateMultyStore
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
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents PanelChk As System.Windows.Forms.GroupBox
    Friend WithEvents BtnComment As UCCommentButton.CommentButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChkZeroBalance As System.Windows.Forms.CheckBox
    Friend WithEvents ChkUnpaid As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSendCopie As System.Windows.Forms.CheckBox
    Friend WithEvents CalendarCombo1 As CalendarCombo.CalendarCombo
    Friend WithEvents PanelTypeCus As System.Windows.Forms.GroupBox
    Friend WithEvents PanelClass As System.Windows.Forms.Panel
    Friend WithEvents BtnClass As System.Windows.Forms.Button
    Friend WithEvents RdoSelectedClass As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllClass As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PanelType As System.Windows.Forms.Panel
    Friend WithEvents BtnType As System.Windows.Forms.Button
    Friend WithEvents RdoSelectedType As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllType As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnSelect As System.Windows.Forms.Button
    Friend WithEvents CmdSPFindDueDate As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAClass As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAType As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DACustomer As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGeneral As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAForCommand As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmRepCusStateMultyStore1 As ReportCustomer.DSFrmRepCusStateMultyStore
    Friend WithEvents BtnPriv As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents CnnForMdb As System.Data.OleDb.OleDbConnection
    Friend WithEvents CmdSTORE_SETUP As System.Data.OleDb.OleDbCommand
    Friend WithEvents PanelCus As System.Windows.Forms.Panel
    Friend WithEvents BtnCus As System.Windows.Forms.Button
    Friend WithEvents RdoSelectedCus As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllCus As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pb1 As Janus.Windows.EditControls.UIProgressBar
    Friend WithEvents DaSP_CustomerAging31to60 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaSP_CustomerAgingOver90 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaSP_CustomerAging61to90 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaSP_CustomerAging1to30 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaSP_CustomerAgingNotDueYet As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmRepCusStateMultyStore))
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.PanelChk = New System.Windows.Forms.GroupBox
        Me.BtnComment = New UCCommentButton.CommentButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.ChkZeroBalance = New System.Windows.Forms.CheckBox
        Me.ChkUnpaid = New System.Windows.Forms.CheckBox
        Me.ChkSendCopie = New System.Windows.Forms.CheckBox
        Me.CalendarCombo1 = New CalendarCombo.CalendarCombo
        Me.PanelTypeCus = New System.Windows.Forms.GroupBox
        Me.PanelCus = New System.Windows.Forms.Panel
        Me.BtnCus = New System.Windows.Forms.Button
        Me.RdoSelectedCus = New System.Windows.Forms.RadioButton
        Me.RdoAllCus = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.PanelClass = New System.Windows.Forms.Panel
        Me.BtnClass = New System.Windows.Forms.Button
        Me.RdoSelectedClass = New System.Windows.Forms.RadioButton
        Me.RdoAllClass = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.PanelType = New System.Windows.Forms.Panel
        Me.BtnType = New System.Windows.Forms.Button
        Me.RdoSelectedType = New System.Windows.Forms.RadioButton
        Me.RdoAllType = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.BtnSelect = New System.Windows.Forms.Button
        Me.BtnPriv = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.CmdSPFindDueDate = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAClass = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DAType = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DACustomer = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAGeneral = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAForCommand = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DsFrmRepCusStateMultyStore1 = New ReportCustomer.DSFrmRepCusStateMultyStore
        Me.CnnForMdb = New System.Data.OleDb.OleDbConnection
        Me.CmdSTORE_SETUP = New System.Data.OleDb.OleDbCommand
        Me.pb1 = New Janus.Windows.EditControls.UIProgressBar
        Me.DaSP_CustomerAging31to60 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaSP_CustomerAgingOver90 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DaSP_CustomerAging61to90 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DaSP_CustomerAging1to30 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DaSP_CustomerAgingNotDueYet = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.PanelChk.SuspendLayout()
        Me.PanelTypeCus.SuspendLayout()
        Me.PanelCus.SuspendLayout()
        Me.PanelClass.SuspendLayout()
        Me.PanelType.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DsFrmRepCusStateMultyStore1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(16, 400)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.TabIndex = 19
        Me.BtnPrint.Text = "Print"
        '
        'PanelChk
        '
        Me.PanelChk.Controls.Add(Me.BtnComment)
        Me.PanelChk.Controls.Add(Me.Label3)
        Me.PanelChk.Controls.Add(Me.ChkZeroBalance)
        Me.PanelChk.Controls.Add(Me.ChkUnpaid)
        Me.PanelChk.Controls.Add(Me.ChkSendCopie)
        Me.PanelChk.Controls.Add(Me.CalendarCombo1)
        Me.PanelChk.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelChk.Location = New System.Drawing.Point(0, 216)
        Me.PanelChk.Name = "PanelChk"
        Me.PanelChk.Size = New System.Drawing.Size(430, 168)
        Me.PanelChk.TabIndex = 18
        Me.PanelChk.TabStop = False
        '
        'BtnComment
        '
        Me.BtnComment.Location = New System.Drawing.Point(327, 128)
        Me.BtnComment.Name = "BtnComment"
        Me.BtnComment.Size = New System.Drawing.Size(78, 23)
        Me.BtnComment.TabIndex = 16
        Me.BtnComment.ZButtonText = "Comments"
        Me.BtnComment.ZCommentFormheight = 0
        Me.BtnComment.ZCommentFormWidth = 0
        Me.BtnComment.ZCommentText = Nothing
        Me.BtnComment.ZEnabled = True
        Me.BtnComment.ZMaxCommentLength = 250
        Me.BtnComment.ZShowInLeft = False
        Me.BtnComment.ZShowInTop = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Statement Date"
        '
        'ChkZeroBalance
        '
        Me.ChkZeroBalance.Checked = True
        Me.ChkZeroBalance.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkZeroBalance.Location = New System.Drawing.Point(8, 88)
        Me.ChkZeroBalance.Name = "ChkZeroBalance"
        Me.ChkZeroBalance.Size = New System.Drawing.Size(248, 24)
        Me.ChkZeroBalance.TabIndex = 14
        Me.ChkZeroBalance.Text = "Don't Print Statement With a Zero Balance"
        '
        'ChkUnpaid
        '
        Me.ChkUnpaid.Location = New System.Drawing.Point(8, 48)
        Me.ChkUnpaid.Name = "ChkUnpaid"
        Me.ChkUnpaid.Size = New System.Drawing.Size(248, 24)
        Me.ChkUnpaid.TabIndex = 13
        Me.ChkUnpaid.Text = "Print Copies Of Invoices With Statement"
        '
        'ChkSendCopie
        '
        Me.ChkSendCopie.Location = New System.Drawing.Point(8, 16)
        Me.ChkSendCopie.Name = "ChkSendCopie"
        Me.ChkSendCopie.Size = New System.Drawing.Size(400, 24)
        Me.ChkSendCopie.TabIndex = 12
        Me.ChkSendCopie.Text = "Print Statement Only For  Customers Requiring Copies Of Unpaid Invoices"
        '
        'CalendarCombo1
        '
        Me.CalendarCombo1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CalendarCombo1.BorderColor = System.Drawing.Color.Empty
        Me.CalendarCombo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CalendarCombo1.ButtonBackColor = System.Drawing.Color.Empty
        Me.CalendarCombo1.ButtonForeColor = System.Drawing.Color.Empty
        Me.CalendarCombo1.EditableSal = True
        Me.CalendarCombo1.Image = CType(resources.GetObject("CalendarCombo1.Image"), System.Drawing.Image)
        Me.CalendarCombo1.Location = New System.Drawing.Point(128, 128)
        Me.CalendarCombo1.MaxValue = CType(2500, Short)
        Me.CalendarCombo1.MinValue = CType(1800, Short)
        Me.CalendarCombo1.Name = "CalendarCombo1"
        Me.CalendarCombo1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CalendarCombo1.Sal_Mali = Nothing
        Me.CalendarCombo1.ShowButton = True
        Me.CalendarCombo1.Size = New System.Drawing.Size(110, 23)
        Me.CalendarCombo1.TabIndex = 11
        Me.CalendarCombo1.VisualStyle = False
        '
        'PanelTypeCus
        '
        Me.PanelTypeCus.Controls.Add(Me.PanelCus)
        Me.PanelTypeCus.Controls.Add(Me.PanelClass)
        Me.PanelTypeCus.Controls.Add(Me.PanelType)
        Me.PanelTypeCus.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTypeCus.Location = New System.Drawing.Point(0, 48)
        Me.PanelTypeCus.Name = "PanelTypeCus"
        Me.PanelTypeCus.Size = New System.Drawing.Size(430, 168)
        Me.PanelTypeCus.TabIndex = 16
        Me.PanelTypeCus.TabStop = False
        '
        'PanelCus
        '
        Me.PanelCus.Controls.Add(Me.BtnCus)
        Me.PanelCus.Controls.Add(Me.RdoSelectedCus)
        Me.PanelCus.Controls.Add(Me.RdoAllCus)
        Me.PanelCus.Controls.Add(Me.Label4)
        Me.PanelCus.Location = New System.Drawing.Point(16, 16)
        Me.PanelCus.Name = "PanelCus"
        Me.PanelCus.Size = New System.Drawing.Size(376, 40)
        Me.PanelCus.TabIndex = 10
        '
        'BtnCus
        '
        Me.BtnCus.Enabled = False
        Me.BtnCus.Location = New System.Drawing.Point(272, 16)
        Me.BtnCus.Name = "BtnCus"
        Me.BtnCus.TabIndex = 2
        Me.BtnCus.Text = "Choose..."
        '
        'RdoSelectedCus
        '
        Me.RdoSelectedCus.Location = New System.Drawing.Point(128, 16)
        Me.RdoSelectedCus.Name = "RdoSelectedCus"
        Me.RdoSelectedCus.Size = New System.Drawing.Size(128, 24)
        Me.RdoSelectedCus.TabIndex = 1
        Me.RdoSelectedCus.Text = "Selected Customers"
        '
        'RdoAllCus
        '
        Me.RdoAllCus.Checked = True
        Me.RdoAllCus.Location = New System.Drawing.Point(0, 16)
        Me.RdoAllCus.Name = "RdoAllCus"
        Me.RdoAllCus.TabIndex = 0
        Me.RdoAllCus.TabStop = True
        Me.RdoAllCus.Text = "All Customers"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(16, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "For Customers"
        '
        'PanelClass
        '
        Me.PanelClass.Controls.Add(Me.BtnClass)
        Me.PanelClass.Controls.Add(Me.RdoSelectedClass)
        Me.PanelClass.Controls.Add(Me.RdoAllClass)
        Me.PanelClass.Controls.Add(Me.Label8)
        Me.PanelClass.Location = New System.Drawing.Point(16, 112)
        Me.PanelClass.Name = "PanelClass"
        Me.PanelClass.Size = New System.Drawing.Size(376, 40)
        Me.PanelClass.TabIndex = 9
        '
        'BtnClass
        '
        Me.BtnClass.Enabled = False
        Me.BtnClass.Location = New System.Drawing.Point(272, 16)
        Me.BtnClass.Name = "BtnClass"
        Me.BtnClass.TabIndex = 3
        Me.BtnClass.Text = "Choose..."
        '
        'RdoSelectedClass
        '
        Me.RdoSelectedClass.Location = New System.Drawing.Point(128, 16)
        Me.RdoSelectedClass.Name = "RdoSelectedClass"
        Me.RdoSelectedClass.TabIndex = 1
        Me.RdoSelectedClass.Text = "Selected Classes"
        '
        'RdoAllClass
        '
        Me.RdoAllClass.Checked = True
        Me.RdoAllClass.Location = New System.Drawing.Point(0, 16)
        Me.RdoAllClass.Name = "RdoAllClass"
        Me.RdoAllClass.TabIndex = 0
        Me.RdoAllClass.TabStop = True
        Me.RdoAllClass.Text = "All Classes"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "For Customer Classes"
        '
        'PanelType
        '
        Me.PanelType.Controls.Add(Me.BtnType)
        Me.PanelType.Controls.Add(Me.RdoSelectedType)
        Me.PanelType.Controls.Add(Me.RdoAllType)
        Me.PanelType.Controls.Add(Me.Label5)
        Me.PanelType.Location = New System.Drawing.Point(16, 64)
        Me.PanelType.Name = "PanelType"
        Me.PanelType.Size = New System.Drawing.Size(376, 40)
        Me.PanelType.TabIndex = 8
        '
        'BtnType
        '
        Me.BtnType.Enabled = False
        Me.BtnType.Location = New System.Drawing.Point(272, 16)
        Me.BtnType.Name = "BtnType"
        Me.BtnType.TabIndex = 2
        Me.BtnType.Text = "Choose..."
        '
        'RdoSelectedType
        '
        Me.RdoSelectedType.Location = New System.Drawing.Point(128, 16)
        Me.RdoSelectedType.Name = "RdoSelectedType"
        Me.RdoSelectedType.TabIndex = 1
        Me.RdoSelectedType.Text = "Selected Types"
        '
        'RdoAllType
        '
        Me.RdoAllType.Checked = True
        Me.RdoAllType.Location = New System.Drawing.Point(0, 16)
        Me.RdoAllType.Name = "RdoAllType"
        Me.RdoAllType.TabIndex = 0
        Me.RdoAllType.TabStop = True
        Me.RdoAllType.Text = "All Types"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "For Customer Types"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.BtnSelect)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel4.ForeColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(430, 48)
        Me.Panel4.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(64, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(224, 46)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Select the Customer That you want to print"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PictureBox2.ForeColor = System.Drawing.Color.Black
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 190
        Me.PictureBox2.TabStop = False
        '
        'BtnSelect
        '
        Me.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSelect.Image = CType(resources.GetObject("BtnSelect.Image"), System.Drawing.Image)
        Me.BtnSelect.Location = New System.Drawing.Point(368, 8)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(33, 27)
        Me.BtnSelect.TabIndex = 184
        Me.BtnSelect.Visible = False
        '
        'BtnPriv
        '
        Me.BtnPriv.Location = New System.Drawing.Point(104, 400)
        Me.BtnPriv.Name = "BtnPriv"
        Me.BtnPriv.TabIndex = 21
        Me.BtnPriv.Text = "Preview"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(330, 400)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.TabIndex = 20
        Me.BtnCancel.Text = "Cancel"
        '
        'CmdSPFindDueDate
        '
        Me.CmdSPFindDueDate.CommandText = "SELECT SUM(CASE WHEN DATEDIFF(day, GETDATE(), DueAllInvoice_1.AR_due_date) > 0 TH" & _
        "EN DueAllInvoice_1.payment_amount ELSE cast('0' AS money) END) AS c1, SUM(CASE W" & _
        "HEN DATEDIFF(day, DueAllInvoice_1.AR_due_date, GETDATE()) BETWEEN 1 AND 30 THEN " & _
        "DueAllInvoice_1.payment_amount ELSE cast('0' AS money) END) AS c2, SUM(CASE WHEN" & _
        " DATEDIFF(day, DueAllInvoice_1.AR_due_date, GETDATE()) BETWEEN 31 AND 60 THEN Du" & _
        "eAllInvoice_1.payment_amount ELSE cast('0' AS money) END) AS c3, SUM(CASE WHEN D" & _
        "ATEDIFF(day, DueAllInvoice_1.AR_due_date, GETDATE()) BETWEEN 61 AND 90 THEN DueA" & _
        "llInvoice_1.payment_amount ELSE cast('0' AS money) END) AS c4, SUM(CASE WHEN DAT" & _
        "EDIFF(day, DueAllInvoice_1.AR_due_date, GETDATE()) > 90 THEN DueAllInvoice_1.pay" & _
        "ment_amount ELSE cast('0' AS money) END) AS c5, DueAllInvoice_1.cod_customer FRO" & _
        "M DueAllInvoice() DueAllInvoice_1 INNER JOIN GL_payment_AR ON DueAllInvoice_1.ID" & _
        "_payment = GL_payment_AR.ID_payment WHERE (DueAllInvoice_1.ID_payment IS NOT NUL" & _
        "L) AND (GL_payment_AR.Cancel_flag IS NULL OR GL_payment_AR.Cancel_flag = 0) GROU" & _
        "P BY DueAllInvoice_1.cod_customer ORDER BY DueAllInvoice_1.cod_customer"
        Me.CmdSPFindDueDate.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=FARAJI1;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=TireMate_01;password=sa"
        '
        'DAClass
        '
        Me.DAClass.SelectCommand = Me.SqlSelectCommand5
        Me.DAClass.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_tab_class", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_class", "cod_class"), New System.Data.Common.DataColumnMapping("desc_class", "desc_class")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT cod_class AS cod, desc_class AS description, 0 AS flag FROM cust_tab_class" & _
        ""
        Me.SqlSelectCommand5.Connection = Me.Cnn
        '
        'DAType
        '
        Me.DAType.SelectCommand = Me.SqlSelectCommand3
        Me.DAType.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_tab_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_type", "cod_type"), New System.Data.Common.DataColumnMapping("desc_type", "desc_type")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT cod_type AS cod, desc_type AS description, 0 AS flag FROM cust_tab_type"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DACustomer
        '
        Me.DACustomer.SelectCommand = Me.SqlSelectCommand2
        Me.DACustomer.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_trtab_main", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("vip_code", "vip_code"), New System.Data.Common.DataColumnMapping("cod_company", "cod_company"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("driver_name1", "driver_name1"), New System.Data.Common.DataColumnMapping("driver_name2", "driver_name2"), New System.Data.Common.DataColumnMapping("driver_name3", "driver_name3"), New System.Data.Common.DataColumnMapping("driver_name4", "driver_name4"), New System.Data.Common.DataColumnMapping("DriverLicense", "DriverLicense"), New System.Data.Common.DataColumnMapping("zip", "zip"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("cod_sales_rep", "cod_sales_rep"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cust_exempt_tax", "cust_exempt_tax"), New System.Data.Common.DataColumnMapping("scrap_check", "scrap_check"), New System.Data.Common.DataColumnMapping("scrap_value", "scrap_value"), New System.Data.Common.DataColumnMapping("credit_card_no", "credit_card_no"), New System.Data.Common.DataColumnMapping("expiration_credit_date", "expiration_credit_date"), New System.Data.Common.DataColumnMapping("credit_limited", "credit_limited"), New System.Data.Common.DataColumnMapping("AR_charge", "AR_charge"), New System.Data.Common.DataColumnMapping("AR_term", "AR_term"), New System.Data.Common.DataColumnMapping("cod_sales_tax", "cod_sales_tax"), New System.Data.Common.DataColumnMapping("cod_price", "cod_price"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("cod_type", "cod_type"), New System.Data.Common.DataColumnMapping("cod_source", "cod_source"), New System.Data.Common.DataColumnMapping("cod_class", "cod_class"), New System.Data.Common.DataColumnMapping("cod_territory", "cod_territory"), New System.Data.Common.DataColumnMapping("desc_sales_report", "desc_sales_report"), New System.Data.Common.DataColumnMapping("user_id", "user_id"), New System.Data.Common.DataColumnMapping("user_password", "user_password"), New System.Data.Common.DataColumnMapping("AR_statement", "AR_statement"), New System.Data.Common.DataColumnMapping("AR_send_copy", "AR_send_copy"), New System.Data.Common.DataColumnMapping("AR_finance_charge", "AR_finance_charge"), New System.Data.Common.DataColumnMapping("AR_require_PO", "AR_require_PO"), New System.Data.Common.DataColumnMapping("AR_credit_hold", "AR_credit_hold"), New System.Data.Common.DataColumnMapping("AR_accept_check", "AR_accept_check"), New System.Data.Common.DataColumnMapping("cust_notes", "cust_notes"), New System.Data.Common.DataColumnMapping("Taxable", "Taxable"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("customer_no", "customer_no")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cust_trtab_main.cod_customer AS cod, cust_trtab_main.f_name, cust_trtab_ma" & _
        "in.l_name, cust_company.complete_name, 0 AS flag FROM cust_trtab_main LEFT OUTER" & _
        " JOIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_company WHE" & _
        "RE (cust_trtab_main.AR_statement = 1) AND (cust_trtab_main.AR_charge = 1)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAGeneral
        '
        Me.DAGeneral.SelectCommand = Me.SqlSelectCommand1
        Me.DAGeneral.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_trtab_main", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("name", "name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_ma" & _
        "in.l_name AS name, cust_trtab_main.address, CASE WHEN phone_main_1 = 1 THEN phon" & _
        "e_1 WHEN phone_main_2 = 1 THEN phone_2 WHEN phone_main_3 = 1 THEN phone_3 WHEN p" & _
        "hone_main_4 = 1 THEN phone_4 WHEN phone_main_5 = 1 THEN phone_5 END AS phone_1, " & _
        "service_center_head.id_service_center AS RefNo, service_center_head.date_refer A" & _
        "S date, GL_payment_AR.AR_due_date AS DueDate, CASE WHEN service_center_head.po_n" & _
        "o = '' THEN '' ELSE 'INVOICE/ PO NO ' + service_center_head.po_no END AS Descrip" & _
        "t, GL_payment_deposit.payment_amount AS charge, 'IN' AS KindPay FROM cust_trtab_" & _
        "main INNER JOIN service_center_head ON cust_trtab_main.cod_customer = service_ce" & _
        "nter_head.cod_customer INNER JOIN GL_payment_deposit ON service_center_head.id_s" & _
        "ervice_center = GL_payment_deposit.id_service_center INNER JOIN GL_payment_AR ON" & _
        " GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAForCommand
        '
        Me.DAForCommand.SelectCommand = Me.SqlSelectCommand4
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'DsFrmRepCusStateMultyStore1
        '
        Me.DsFrmRepCusStateMultyStore1.DataSetName = "DSFrmRepCusStateMultyStore"
        Me.DsFrmRepCusStateMultyStore1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'CnnForMdb
        '
        Me.CnnForMdb.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Data Source=""D:\TireMatesetup.mdb"";Jet OLEDB:Engine Type=5;Provide" & _
        "r=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;persi" & _
        "st security info=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:Encry" & _
        "pt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Lo" & _
        "cale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Adm" & _
        "in;Jet OLEDB:Global Bulk Transactions=1"
        '
        'CmdSTORE_SETUP
        '
        Me.CmdSTORE_SETUP.CommandText = "SELECT STORENO, SHORTNAME FROM STORE_SETUP"
        Me.CmdSTORE_SETUP.Connection = Me.CnnForMdb
        '
        'pb1
        '
        Me.pb1.Location = New System.Drawing.Point(16, 424)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(392, 14)
        Me.pb1.TabIndex = 22
        Me.pb1.Text = "Wait ..."
        Me.pb1.Visible = False
        '
        'DaSP_CustomerAging31to60
        '
        Me.DaSP_CustomerAging31to60.SelectCommand = Me.SqlCommand1
        Me.DaSP_CustomerAging31to60.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CustomerAging31to60", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COD_CUSTOMER", "COD_CUSTOMER"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "[SP_CustomerAging31to60]"
        Me.SqlCommand1.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlCommand1.Connection = Me.Cnn
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        '
        'DaSP_CustomerAgingOver90
        '
        Me.DaSP_CustomerAgingOver90.SelectCommand = Me.SqlCommand4
        Me.DaSP_CustomerAgingOver90.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CustomerAgingOver90", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COD_CUSTOMER", "COD_CUSTOMER"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")})})
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "[SP_CustomerAgingOver90]"
        Me.SqlCommand4.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlCommand4.Connection = Me.Cnn
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        '
        'DaSP_CustomerAging61to90
        '
        Me.DaSP_CustomerAging61to90.SelectCommand = Me.SqlCommand2
        Me.DaSP_CustomerAging61to90.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CustomerAging61to90", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COD_CUSTOMER", "COD_CUSTOMER"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")})})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "[SP_CustomerAging61to90]"
        Me.SqlCommand2.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlCommand2.Connection = Me.Cnn
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        '
        'DaSP_CustomerAging1to30
        '
        Me.DaSP_CustomerAging1to30.SelectCommand = Me.SqlSelectCommand6
        Me.DaSP_CustomerAging1to30.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CustomerAging1to30", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COD_CUSTOMER", "COD_CUSTOMER"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "[SP_CustomerAging1to30]"
        Me.SqlSelectCommand6.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand6.Connection = Me.Cnn
        Me.SqlSelectCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        '
        'DaSP_CustomerAgingNotDueYet
        '
        Me.DaSP_CustomerAgingNotDueYet.SelectCommand = Me.SqlCommand3
        Me.DaSP_CustomerAgingNotDueYet.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CustomerAgingNotDueYet", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COD_CUSTOMER", "COD_CUSTOMER"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")})})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "[SP_CustomerAgingNotDueYet]"
        Me.SqlCommand3.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlCommand3.Connection = Me.Cnn
        Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        '
        'FrmRepCusStateMultyStore
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(430, 444)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.PanelChk)
        Me.Controls.Add(Me.PanelTypeCus)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.BtnPriv)
        Me.Controls.Add(Me.BtnCancel)
        Me.Name = "FrmRepCusStateMultyStore"
        Me.Text = "Customer Statements (Multi Store)"
        Me.PanelChk.ResumeLayout(False)
        Me.PanelTypeCus.ResumeLayout(False)
        Me.PanelCus.ResumeLayout(False)
        Me.PanelClass.ResumeLayout(False)
        Me.PanelType.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DsFrmRepCusStateMultyStore1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Strwhere As String
    Dim WithEvents MyZipCode As UCZipCode.ClsZipCode
    Dim txtinvoicebalance As String '= " ( SELECT  id_service_center  FROM View_Invoice_Balance  WHERE   BalanceAmount <> 0 )"
    Dim st As String
    Private Sub FrmRepCusStateMultyStore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtinvoicebalance = " ( SELECT  id_service_center  FROM View_Invoice_Balance  WHERE   BalanceAmount <> 0  or (BalanceAmount =0 and dbo.changedate(date_refer) <=  " & Qt(Format(Now(), "yyyy/MM/dd")) & " and dbo.changedate(date_refer) >= " & Qt(Format(Now().AddMonths(-1), "yyyy/MM/dd")) & " ) )"
        Call MakeDbNameAndConnection()
        CnnForMdb.ConnectionString = PConnectionStringForSetupTables

        MyZipCode = New UCZipCode.ClsZipCode
        MyZipCode.Connection = Me.Cnn

        Cnn.ConnectionString = PConnectionString
        CalendarCombo1.Text = Format(Now(), "MM/dd/yyyy")
    End Sub
    Private Sub RdoAllCus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllCus.CheckedChanged
        If RdoAllCus.Checked Then
            BtnCus.Enabled = False
        Else
            BtnCus.Enabled = True
        End If

    End Sub

    Private Sub RdoAllType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllType.CheckedChanged
        If RdoAllType.Checked Then
            BtnType.Enabled = False
        Else
            BtnType.Enabled = True
        End If

    End Sub

    Private Sub RdoAllClass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllClass.CheckedChanged
        If RdoAllClass.Checked Then
            BtnClass.Enabled = False
        Else
            BtnClass.Enabled = True
        End If
    End Sub
    Private Sub BtnCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCus.Click
        BtnCus.Enabled = False
        Dim f As New FrmSelect
        If DsFrmRepCusStateMultyStore1.customer.Count = 0 Then
            DACustomer.Fill(DsFrmRepCusStateMultyStore1.customer)
        End If
        f.Text = "  Select Customer"
        f.TypeOfForm = FrmSelect.KindForm.customer
        f.DSMAIN = DsFrmRepCusStateMultyStore1
        f.ShowDialog()
        BtnCus.Enabled = True
    End Sub

    Private Sub BtnType_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnType.Click
        BtnType.Enabled = False
        Dim f As New FrmSelect
        If DsFrmRepCusStateMultyStore1.type.Count = 0 Then
            DsFrmRepCusStateMultyStore1.type.Clear()
            DAType.Fill(DsFrmRepCusStateMultyStore1.type)
        End If
        f.Text = "  Select Type"
        f.TypeOfForm = FrmSelect.KindForm.type
        f.DSMAIN = DsFrmRepCusStateMultyStore1
        f.ShowDialog()
        BtnType.Enabled = True
    End Sub

    Private Sub BtnClass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClass.Click
        BtnClass.Enabled = False
        Dim f As New FrmSelect
        If DsFrmRepCusStateMultyStore1.clas.Count = 0 Then
            DsFrmRepCusStateMultyStore1.clas.Clear()
            DAClass.Fill(DsFrmRepCusStateMultyStore1.clas)
        End If
        f.Text = "  Select Class"
        f.TypeOfForm = FrmSelect.KindForm.clas
        f.DSMAIN = DsFrmRepCusStateMultyStore1
        f.ShowDialog()
        BtnClass.Enabled = True
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Function ControlSelect() As Boolean
        ControlSelect = True
        'Dim StrCustomer As String
        'Dim StrType As String
        'Dim StrClass As String
        Dim StrChk3 As String
        Dim FlagControl As Boolean

        Dim i As Integer
        'StrCustomer = ""
        FlagControl = False
        If RdoSelectedCus.Checked Then

            For i = 0 To DsFrmRepCusStateMultyStore1.customer.Count - 1
                If DsFrmRepCusStateMultyStore1.customer(i).flag Then
                    FlagControl = True
                    Exit For
                End If
            Next
            If FlagControl = False Then
                ControlSelect = False
                MsgBox("First Select customer that you want")
                Exit Function
            End If

        End If

        '''''''type
        FlagControl = False 'StrType = ""
        If RdoSelectedType.Checked Then

            For i = 0 To DsFrmRepCusStateMultyStore1.type.Count - 1
                If DsFrmRepCusStateMultyStore1.type(i).flag Then
                    FlagControl = True
                    Exit For
                End If
            Next
            If FlagControl = False Then
                ControlSelect = False
                MsgBox("First Select Type that you want")
                Exit Function
            End If
        End If
        '''''''''''''''Class
        FlagControl = False ' StrClass = ""
        If RdoSelectedClass.Checked Then

            For i = 0 To DsFrmRepCusStateMultyStore1.clas.Count - 1
                If DsFrmRepCusStateMultyStore1.clas(i).flag Then
                    FlagControl = True
                    Exit For
                End If
            Next
            If FlagControl = False Then
                ControlSelect = False
                MsgBox("First Select Class that you want")
                Exit Function
            End If
        End If

        ''''''''''''''chk3
        If ChkZeroBalance.Checked Then


            StrChk3 = " cust_trtab_main.cod_customer  IN  (SELECT     cod_customer " & _
                 " FROM         View_Customer_Balance " & _
                 " WHERE     round(BalanceAmount,2) <> 0)"
        End If

        Strwhere = ""
        Strwhere = "(cust_trtab_main.AR_statement = 1)  and " '(cust_trtab_main.AR_statement = 1) AND HAZF SHOD CHON ARMANDE GOFT

        ''''''''''''chk1
        If ChkSendCopie.Checked Then
            Strwhere = Strwhere & "(cust_trtab_main.AR_send_copy = 1) AND "
        End If


        If ChkZeroBalance.Checked Then
            Strwhere = Strwhere & " (" & StrChk3 & ") and "
        End If

        If Strwhere.Trim.Length > 0 Then Strwhere = Mid(Strwhere, 1, Strwhere.Length - 4)

    End Function
    Private Sub makeFlagShow()

        Dim i As Integer


        If RdoSelectedCus.Checked Or RdoSelectedType.Checked Or RdoSelectedClass.Checked Then
            For i = 0 To DsFrmRepCusStateMultyStore1.report.Count - 1
                If RdoSelectedCus.Checked Then
                    If DsFrmRepCusStateMultyStore1.customer.Select("flag=1 and cod = " & Qt(DsFrmRepCusStateMultyStore1.report(i).cod_customer)).Length > 0 Then
                        DsFrmRepCusStateMultyStore1.report(i).flagcus = 1
                    End If

                End If
                If RdoSelectedType.Checked Then
                    If DsFrmRepCusStateMultyStore1.type.Select("flag=1 and cod = " & Qt(DsFrmRepCusStateMultyStore1.report(i).cod_type)).Length > 0 Then
                        DsFrmRepCusStateMultyStore1.report(i).flagtype = 1
                    End If
                End If
                If RdoSelectedClass.Checked Then
                    If DsFrmRepCusStateMultyStore1.clas.Select("flag=1 and cod = " & Qt(DsFrmRepCusStateMultyStore1.report(i).cod_class)).Length > 0 Then
                        DsFrmRepCusStateMultyStore1.report(i).flagclass = 1
                    End If
                End If
            Next
        End If


    End Sub
    Private Sub pprint(ByVal type As String)
        Call FillDataset()

        If DsFrmRepCusStateMultyStore1.report.Count = 0 Then
            MsgBox("No Data For Printing")
            Exit Sub
        End If
        Dim rpt As New RepCusStateMultiStore
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)

        rpt.SetParameterValue("Parconame", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parcoaddress", OleDbReaderForStore.Item("ADDRESS") & "")

        MyZipCode.ZipCode = OleDbReaderForStore.Item("ZipCode")
        MyZipCode.FindDesc(OleDbReaderForStore.Item("ZipCode"))
        rpt.SetParameterValue("Parcoaddress2", MyZipCode.City & " " & MyZipCode.State & " " & MyZipCode.ZipCode & "")

        rpt.SetParameterValue("Parcophone", OleDbReaderForStore.Item("PHONE") & "")
        rpt.SetParameterValue("Parcofax", OleDbReaderForStore.Item("FAX") & "")
        rpt.SetParameterValue("Parcoemail", OleDbReaderForStore.Item("EMAIL") & "")

        DsFrmRepCusStateMultyStore1.LOGO.Clear()
        Dim OleDbReaderForCompany As System.Data.OleDb.OleDbDataReader
        OleDbReaderForCompany = RetrieveCompanySetupTable()

        Try
            DsFrmRepCusStateMultyStore1.LOGO.AddLOGORow(OleDbReaderForCompany.Item("LOGO"), "l")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        rpt.SetParameterValue("Parcowebsite", OleDbReaderForCompany.Item("WEBPAGE"))

        OleDbReaderForStore = RetrieveAccountsReceivableSetupTable()

        rpt.SetParameterValue("Parannual", OleDbReaderForStore.Item("Default_annual_finance_charge") & "%")

        rpt.SetParameterValue("pardate", CalendarCombo1.Text)
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("parkindrep", "STATEMENT")
        rpt.SetParameterValue("parcomment", BtnComment.ZCommentText)

        rpt.SetDataSource(DsFrmRepCusStateMultyStore1)
        Select Case type
            Case "print"
                Try
                    rpt.PrintToPrinter(1, True, 0, 0)
                Catch ex As Exception
                End Try
            Case "priv"
                prn.CrViewer.ReportSource = rpt
                prn.ShowDialog()
                'Case "fax"
                '    Try
                '        rpt.PrintOptions.PrinterName = "Fax"
                '        rpt.PrintToPrinter(1, True, 0, 0)
                '    Catch ex As Exception
                '        MsgBox("Add The FAX in (Printers and Faxes)")
                '    End Try
        End Select

    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        If ControlSelect() Then
            Call pprint("print")
        End If

    End Sub

    Private Sub BtnPriv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPriv.Click
        If ControlSelect() Then
            Call pprint("priv")
        End If

    End Sub

    Private Sub ChkSendCopie_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkSendCopie.CheckedChanged
        If ChkSendCopie.Checked Then
            ChkUnpaid.Checked = True
            ChkUnpaid.Enabled = False
        Else
            ChkUnpaid.Checked = False
            ChkUnpaid.Enabled = True
        End If
    End Sub
    Private Sub FillDatasetUnPaid(ByVal StoreName As String)


        st = IIf(RdoSelectedCus.Checked, ",0 as flagcus ", ",1 as  flagcus ")
        st = st & IIf(RdoSelectedClass.Checked, ", 0 as flagclass ", ", 1 as flagclass")
        st = st & IIf(RdoSelectedType.Checked, ", 0 as flagtype ", ", 1 as flagtype")
        st = st & "," & Qt(StoreName) & " as Store"


        ''''''''invoice due
        'DAGeneral.SelectCommand.CommandText = "SELECT     cust_trtab_main.cod_customer, ltrim(rtrim(cust_trtab_main.f_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.l_name)) AS name, cust_trtab_main.address, " & _
        '              " rtrim(ltrim(bas_zipcode.city))+' '+ rtrim(ltrim(bas_zipcode.state))+' '+ rtrim(ltrim(cust_trtab_main.zip)) AS phone_1, service_center_head.id_service_center AS RefNo,  " & _
        '              " service_center_head.date_refer AS date, GL_payment_AR.AR_due_date AS DueDate,  " & _
        '              " CASE WHEN rtrim(ltrim(service_center_head.po_no)) = '' OR service_center_head.po_no IS NULL THEN case when rtrim(ltrim(cust_comment))='Begin Balance' then 'Beginning Balance' ELSE 'INVOICE' END ELSE 'INVOICE/ PO NO ' + service_center_head.po_no END AS Descript,  " & _
        '              " GL_payment_deposit.payment_amount AS charge ,cust_company.complete_name ,cust_trtab_main.cod_class,cust_trtab_main.cod_type" & st & " ,dbo.changedate(service_center_head.date_refer) as OrderDate,ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) AS OrderName " & _
        '              " FROM          cust_trtab_main INNER JOIN " & _
        '              " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
        '              " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        '              " GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment LEFT OUTER JOIN " & _
        '              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        '              " LEFT OUTER JOIN bas_zipcode ON cust_trtab_main.zip = bas_zipcode.zipcode " & _
        '              " WHERE     (service_center_head.type_of_form = 'IN')  and " & Strwhere


        DAGeneral.SelectCommand.CommandText = "SELECT     cust_trtab_main.cod_customer, ltrim(rtrim(cust_trtab_main.f_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.l_name)) AS name, cust_trtab_main.address, " & _
                     " rtrim(ltrim(bas_zipcode.city))+' '+ rtrim(ltrim(bas_zipcode.state))+' '+ rtrim(ltrim(cust_trtab_main.zip)) AS phone_1, service_center_head.id_service_center AS RefNo,  " & _
                     " service_center_head.date_refer AS date, GL_payment_AR.AR_due_date AS DueDate,  " & _
                     " CASE WHEN rtrim(ltrim(service_center_head.po_no)) = '' OR service_center_head.po_no IS NULL THEN case when rtrim(ltrim(cust_comment))='Begin Balance' then 'Beginning Balance' ELSE 'INVOICE' END ELSE 'INVOICE/ PO NO ' + service_center_head.po_no END AS Descript,  " & _
                     " GL_payment_deposit.payment_amount AS charge ,cust_company.complete_name ,cust_trtab_main.cod_class,cust_trtab_main.cod_type" & st & " ,dbo.changedate(service_center_head.date_refer) as OrderDate,ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) AS OrderName , datediff(day, GL_payment_AR.AR_due_date,getdate()) AS days " & _
                     " FROM          cust_trtab_main INNER JOIN " & _
                     " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
                     " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
                     " GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment LEFT OUTER JOIN " & _
                     " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
                     " LEFT OUTER JOIN bas_zipcode ON cust_trtab_main.zip = bas_zipcode.zipcode " & _
                     " WHERE     (service_center_head.type_of_form = 'IN') and  service_center_head.id_service_center IN " & txtinvoicebalance & " And " & Strwhere
        DAGeneral.Fill(DsFrmRepCusStateMultyStore1.report)
        '''''''''''return
        Call Return1()
        DAGeneral.Fill(DsFrmRepCusStateMultyStore1.report)
        ''''''''adj+
        Call AdjPositive()

        DAGeneral.Fill(DsFrmRepCusStateMultyStore1.report)
        Call AdjNegative()
        DAGeneral.Fill(DsFrmRepCusStateMultyStore1.report)
        Call AllAging()
    End Sub
    Private Sub FillDataSetAll(ByVal StoreName As String)

        st = IIf(RdoSelectedCus.Checked, ",0 as flagcus ", ",1 as  flagcus ")
        st = st & IIf(RdoSelectedClass.Checked, ", 0 as flagclass ", ", 1 as flagclass")
        st = st & IIf(RdoSelectedType.Checked, ", 0 as flagtype ", ", 1 as flagtype")
        st = st & "," & Qt(StoreName) & " as Store"

        DAGeneral.SelectCommand.CommandText = "SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.l_name AS name, cust_trtab_main.address, " & _
               " rtrim(ltrim(bas_zipcode.city))+' '+ rtrim(ltrim(bas_zipcode.state))+' '+ rtrim(ltrim(cust_trtab_main.zip)) AS phone_1, service_center_head.id_service_center AS RefNo,  " & _
              " service_center_head.date_refer AS date, GL_payment_AR.AR_due_date AS DueDate,  " & _
              " CASE WHEN rtrim(ltrim(service_center_head.po_no)) = '' OR service_center_head.po_no IS NULL THEN case when rtrim(ltrim(cust_comment))='Begin Balance' then 'Beginning Balance' ELSE 'INVOICE' END ELSE 'INVOICE/ PO NO ' + service_center_head.po_no END AS Descript,  " & _
              " GL_payment_deposit.payment_amount AS charge,cust_company.complete_name,cust_trtab_main.cod_class,cust_trtab_main.cod_type " & st & " ,dbo.changedate(service_center_head.date_refer) as OrderDate,ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) AS OrderName " & _
              " , datediff(day, GL_payment_AR.AR_due_date,getdate()) AS days    FROM            cust_trtab_main INNER JOIN " & _
              " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
              " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
              " GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company" & _
              " LEFT OUTER JOIN bas_zipcode ON cust_trtab_main.zip = bas_zipcode.zipcode " & _
              " WHERE     (service_center_head.type_of_form = 'IN') and  service_center_head.id_service_center IN " & txtinvoicebalance & " And " & Strwhere
        Try
            DAGeneral.Fill(DsFrmRepCusStateMultyStore1.report)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        ''''''''invoice Payment
        Call PayMent()
        DAGeneral.Fill(DsFrmRepCusStateMultyStore1.report)
        Call Return1()
        DAGeneral.Fill(DsFrmRepCusStateMultyStore1.report)

        ''''''''adj+
        Call AdjPositive()
        DAGeneral.Fill(DsFrmRepCusStateMultyStore1.report)
        Call AdjNegative()
        DAGeneral.Fill(DsFrmRepCusStateMultyStore1.report)
        Call AllAging()
    End Sub
    Private Sub FillDataset()
        DsFrmRepCusStateMultyStore1.report.Clear()
        DsFrmRepCusStateMultyStore1.SP_CustomerAgingNotDueYet.Clear()
        DsFrmRepCusStateMultyStore1.SP_CustomerAging1to30.Clear()
        DsFrmRepCusStateMultyStore1.SP_CustomerAging31to60.Clear()
        DsFrmRepCusStateMultyStore1.SP_CustomerAging61to90.Clear()
        DsFrmRepCusStateMultyStore1.SP_CustomerAgingOver90.Clear()
        DsFrmRepCusStateMultyStore1.LOGO.Clear()
        DsFrmRepCusStateMultyStore1.customerdueForOnStore.Clear()

        If CmdSTORE_SETUP.Connection.State = ConnectionState.Closed Then
            CmdSTORE_SETUP.Connection.Open()
        End If
        Dim SQLReader As System.Data.OleDb.OleDbDataReader
        SQLReader = CmdSTORE_SETUP.ExecuteReader
        Dim i As Integer = 0
        pb1.Visible = True
        pb1.Maximum = 10
        pb1.Value = 0
        pb1.Value += 1
        If SQLReader.HasRows Then
            Do While SQLReader.Read()
                Cnn.ConnectionString = MakeConnectionSqlForThisStore(SQLReader("STORENO"))
                If Cnn.ConnectionString.Trim = "" Then
                Else
                    If ChkUnpaid.Checked Then
                        Call FillDatasetUnPaid(SQLReader("SHORTNAME"))
                    Else
                        Call FillDataSetAll(SQLReader("SHORTNAME"))
                    End If
                End If
                If pb1.Value + 1 > pb1.Maximum Then
                    pb1.Maximum = pb1.Maximum + 2
                End If
                pb1.Value += 1
            Loop
            CmdSTORE_SETUP.Connection.Close()
        End If

        Call MakeDueDate()
        pb1.Value += 1
        Call makeFlagShow()
        pb1.Value += 1
        pb1.Visible = False
        Cnn.ConnectionString = PConnectionString
    End Sub
    Private Sub MakeDueDate()
        Dim i As Integer = 0
        For i = 0 To DsFrmRepCusStateMultyStore1.report.Rows.Count - 1
            DsFrmRepCusStateMultyStore1.report(i).c1 = DsFrmRepCusStateMultyStore1.SP_CustomerAgingNotDueYet.Compute("sum (BalanceAmount)", "cod_customer =" & Qt(DsFrmRepCusStateMultyStore1.report(i).cod_customer & ""))
            DsFrmRepCusStateMultyStore1.report(i).c2 = DsFrmRepCusStateMultyStore1.SP_CustomerAging1to30.Compute("sum (BalanceAmount)", "cod_customer =" & Qt(DsFrmRepCusStateMultyStore1.report(i).cod_customer & ""))
            DsFrmRepCusStateMultyStore1.report(i).c3 = DsFrmRepCusStateMultyStore1.SP_CustomerAging31to60.Compute("sum (BalanceAmount)", "cod_customer =" & Qt(DsFrmRepCusStateMultyStore1.report(i).cod_customer & ""))
            DsFrmRepCusStateMultyStore1.report(i).c4 = DsFrmRepCusStateMultyStore1.SP_CustomerAging61to90.Compute("sum (BalanceAmount)", "cod_customer =" & Qt(DsFrmRepCusStateMultyStore1.report(i).cod_customer & ""))
            DsFrmRepCusStateMultyStore1.report(i).c5 = DsFrmRepCusStateMultyStore1.SP_CustomerAgingOver90.Compute("sum (BalanceAmount)", "cod_customer =" & Qt(DsFrmRepCusStateMultyStore1.report(i).cod_customer & ""))
            DsFrmRepCusStateMultyStore1.report(i).OrderName = IIf(DsFrmRepCusStateMultyStore1.report(i).complete_name = "", "zzzzz", DsFrmRepCusStateMultyStore1.report(i).complete_name) & DsFrmRepCusStateMultyStore1.report(i).OrderName & DsFrmRepCusStateMultyStore1.report(i).cod_customer
        Next
        ' Next
    End Sub
    Private Sub pb1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles pb1.ValueChanged
        Application.DoEvents()
    End Sub

    Sub PayMent()
        DAGeneral.SelectCommand.CommandText = "" & _
            " SELECT  cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.l_name AS name, cust_trtab_main.address, " & _
            " RTRIM(LTRIM(bas_zipcode.city)) + ' ' + RTRIM(LTRIM(bas_zipcode.state)) + ' ' + RTRIM(LTRIM(cust_trtab_main.zip)) AS phone_1, Gl_receive_payment.refrence_no  as RefNo ," & _
            "  Gl_receive_payment.date_receive_payment AS [date], " & _
            " CASE WHEN  refrence_no_Adjustment is null then 'PAYMENT/INV NO ' + GL_payment_deposit.id_service_center   ELSE 'PAYMENT/Adj No' + GL_payment_deposit.refrence_no_Adjustment END  AS descript , " & _
            " GL_payment_deposit.payment_amount AS payment, " & _
            " cust_company.complete_name, cust_trtab_main.cod_class, cust_trtab_main.cod_type " & st & _
            " , dbo.ChangeDate(Gl_receive_payment.date_receive_payment) AS OrderDate, LTRIM(RTRIM(cust_trtab_main.l_name))  " & _
            " + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) AS OrderName, DATEDIFF([day], " & _
            " GL_payment_AR.AR_due_date, GETDATE()) AS days " & _
            " FROM         GL_payment_AR INNER JOIN " & _
            "                      GL_payment_deposit_Detail ON GL_payment_AR.ID_payment = GL_payment_deposit_Detail.ID_payment_due RIGHT OUTER JOIN " & _
            "                      cust_trtab_main INNER JOIN " & _
            "                      Gl_receive_payment ON cust_trtab_main.cod_customer = Gl_receive_payment.cod_customer INNER JOIN " & _
            "                      GL_payment_deposit ON Gl_receive_payment.refrence_no = GL_payment_deposit.refrence_no ON  " & _
            "                      GL_payment_deposit_Detail.refrence_no = Gl_receive_payment.refrence_no AND  " & _
            "                      GL_payment_deposit_Detail.ID_payment_Paid = GL_payment_deposit.ID_payment LEFT OUTER JOIN " & _
            "                      cust_company ON cust_trtab_main.cod_company = cust_company.cod_company LEFT OUTER JOIN " & _
            "                      bas_zipcode ON cust_trtab_main.zip = bas_zipcode.zipcode " & _
            " Where  (GL_payment_deposit.refer_type = '2' OR  GL_payment_deposit.refer_type = '3') and GL_payment_deposit.payment_amount > 0  and  GL_payment_deposit.id_service_center In " & txtinvoicebalance & " And " & Strwhere

    End Sub
    Sub AdjPositive()
        DAGeneral.SelectCommand.CommandText = "SELECT   DISTINCT  cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.l_name AS name, cust_trtab_main.address, " & _
            " rtrim(ltrim(bas_zipcode.city))+' '+ rtrim(ltrim(bas_zipcode.state))+' '+ rtrim(ltrim(cust_trtab_main.zip)) AS phone_1, GL_account_adjustment_head.refrence_no AS RefNo," & _
            " GL_account_adjustment_head.date_adjustment AS date,CASE WHEN GL_account_adjustment_head.finance_charge_flag = 1 THEN 'Finance Charge' WHEN GL_account_adjustment_head.finance_charge_flag " & _
            " = 0 THEN CASE WHEN GL_account_adjustment_head.Gl_receive_payment_Refrence_no IS NOT NULL " & _
            " THEN 'EARLY PAYMENT DISCOUNT' ELSE 'Adjustment' END END AS Descript,  GL_account_adjustment_head.amount_adjustment AS Charge , cust_company.complete_name,cust_trtab_main.cod_class,cust_trtab_main.cod_type " & st & " ,dbo.changedate(GL_account_adjustment_head.date_adjustment) as OrderDate,ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) AS OrderName,datediff(day,GL_account_adjustment_head.date_adjustment,getdate()) as days " & _
            " FROM   GL_account_adjustment_head INNER JOIN   cust_trtab_main ON GL_account_adjustment_head.cod_customer = cust_trtab_main.cod_customer INNER JOIN   " & _
            " GL_account_adjustment_dtl ON GL_account_adjustment_head.refrence_no = GL_account_adjustment_dtl.refrence_no LEFT OUTER JOIN   cust_company ON cust_trtab_main.cod_company = cust_company.cod_company  " & _
            " LEFT OUTER JOIN     bas_zipcode ON cust_trtab_main.zip = bas_zipcode.zipcode " & _
            " WHERE(GL_account_adjustment_head.amount_adjustment > 0)  and  GL_account_adjustment_dtl.id_service_center in " & txtinvoicebalance & " AND " & Strwhere
    End Sub
    Sub AdjNegative()

        DAGeneral.SelectCommand.CommandText = "SELECT   DISTINCT  cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.l_name AS name, cust_trtab_main.address, " & _
                    " rtrim(ltrim(bas_zipcode.city))+' '+ rtrim(ltrim(bas_zipcode.state))+' '+ rtrim(ltrim(cust_trtab_main.zip)) AS phone_1, GL_account_adjustment_head.refrence_no AS RefNo," & _
                    " GL_account_adjustment_head.date_adjustment AS date,CASE WHEN GL_account_adjustment_head.finance_charge_flag = 1 THEN 'Finance Charge' WHEN GL_account_adjustment_head.finance_charge_flag " & _
                    " = 0 THEN CASE WHEN GL_account_adjustment_head.Gl_receive_payment_Refrence_no IS NOT NULL " & _
                    " THEN 'EARLY PAYMENT DISCOUNT' ELSE 'Adjustment/INV NO ' + GL_account_adjustment_dtl.id_service_center END END AS Descript,  abs(GL_account_adjustment_Dtl.amount_adjustment) AS payment , cust_company.complete_name,cust_trtab_main.cod_class,cust_trtab_main.cod_type " & st & " ,dbo.changedate(GL_account_adjustment_head.date_adjustment) as OrderDate,ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) AS OrderName,datediff(day,GL_account_adjustment_head.date_adjustment,getdate()) as days " & _
                    " FROM   GL_account_adjustment_head INNER JOIN   cust_trtab_main ON GL_account_adjustment_head.cod_customer = cust_trtab_main.cod_customer INNER JOIN   " & _
                    " GL_account_adjustment_dtl ON GL_account_adjustment_head.refrence_no = GL_account_adjustment_dtl.refrence_no LEFT OUTER JOIN   cust_company ON cust_trtab_main.cod_company = cust_company.cod_company  " & _
                    " LEFT OUTER JOIN     bas_zipcode ON cust_trtab_main.zip = bas_zipcode.zipcode " & _
                    " WHERE(GL_account_adjustment_head.amount_adjustment < 0)  and  GL_account_adjustment_dtl.id_service_center in " & txtinvoicebalance & " AND " & Strwhere

        'DAGeneral.SelectCommand.CommandText = "SELECT   DISTINCT  cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.l_name AS name, cust_trtab_main.address, " & _
        '    " rtrim(ltrim(bas_zipcode.city))+' '+ rtrim(ltrim(bas_zipcode.state))+' '+ rtrim(ltrim(cust_trtab_main.zip)) AS phone_1, GL_account_adjustment_head.refrence_no AS RefNo," & _
        '    " GL_account_adjustment_head.date_adjustment AS date,CASE WHEN GL_account_adjustment_head.finance_charge_flag = 1 THEN 'Finance Charge' WHEN GL_account_adjustment_head.finance_charge_flag " & _
        '    " = 0 THEN CASE WHEN GL_account_adjustment_head.Gl_receive_payment_Refrence_no IS NOT NULL " & _
        '    " THEN 'EARLY PAYMENT DISCOUNT' ELSE 'Adjustment' END END AS Descript,  abs(GL_account_adjustment_dtl.amount_adjustment) AS payment , cust_company.complete_name,cust_trtab_main.cod_class,cust_trtab_main.cod_type " & st & " ,dbo.changedate(GL_account_adjustment_head.date_adjustment) as OrderDate,ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) AS OrderName,datediff(day,GL_account_adjustment_head.date_adjustment,getdate()) as days " & _
        '    " FROM   GL_account_adjustment_head INNER JOIN   cust_trtab_main ON GL_account_adjustment_head.cod_customer = cust_trtab_main.cod_customer INNER JOIN   " & _
        '    " GL_account_adjustment_dtl ON GL_account_adjustment_head.refrence_no = GL_account_adjustment_dtl.refrence_no LEFT OUTER JOIN   cust_company ON cust_trtab_main.cod_company = cust_company.cod_company  " & _
        '    " LEFT OUTER JOIN     bas_zipcode ON cust_trtab_main.zip = bas_zipcode.zipcode " & _
        '    " WHERE(GL_account_adjustment_head.amount_adjustment < 0)  and  GL_account_adjustment_dtl.id_service_center in " & txtinvoicebalance & " AND " & Strwhere
    End Sub

    Sub Return1()
        DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.l_name AS name, cust_trtab_main.address, " & _
              " rtrim(ltrim(bas_zipcode.city))+' '+ rtrim(ltrim(bas_zipcode.state))+' '+ rtrim(ltrim(cust_trtab_main.zip)) AS phone_1, service_center_head.id_service_center AS RefNo,  " & _
              " service_center_head.date_refer AS date, 'RETURN FOR CREDIT' + service_center_head.id_service_center_before  AS Descript, GL_payment_deposit.payment_amount AS payment,cust_company.complete_name,cust_trtab_main.cod_class,cust_trtab_main.cod_type " & st & " ,dbo.changedate(service_center_head.date_refer) as OrderDate,ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) AS OrderName , DATEDIFF(day,GL_payment_AR.AR_due_date, GETDATE()) AS days " & _
              " FROM     GL_payment_AR INNER JOIN " & _
              " GL_payment_deposit ON GL_payment_AR.ID_payment = GL_payment_deposit.ID_payment INNER JOIN " & _
              " cust_trtab_main INNER JOIN " & _
              " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer ON  " & _
              " GL_payment_deposit.id_service_center = service_center_head.id_service_center_before LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " LEFT OUTER JOIN bas_zipcode ON cust_trtab_main.zip = bas_zipcode.zipcode " & _
              " WHERE   " & Strwhere & "  and   (service_center_head.type_of_form = 'RT') AND (service_center_head.id_service_center_before IN " & _
              " (SELECT     service_center_head.id_service_center " & _
              " FROM         cust_trtab_main INNER JOIN " & _
              " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
              " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
              " GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment " & _
              " WHERE     service_center_head.type_of_form = 'IN')) and service_center_head.id_service_center IN " & txtinvoicebalance & " And " & Strwhere

    End Sub
    Sub AllAging()
        Try
            With DaSP_CustomerAging1to30
                .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
                .Fill(DsFrmRepCusStateMultyStore1.SP_CustomerAging1to30)
            End With



            With DaSP_CustomerAging31to60
                .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
                .Fill(DsFrmRepCusStateMultyStore1.SP_CustomerAging31to60)
            End With



            With DaSP_CustomerAging61to90
                .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
                .Fill(DsFrmRepCusStateMultyStore1.SP_CustomerAging61to90)
            End With



            With DaSP_CustomerAgingNotDueYet
                .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
                .Fill(DsFrmRepCusStateMultyStore1.SP_CustomerAgingNotDueYet)
            End With



            With DaSP_CustomerAgingOver90
                .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
                .Fill(DsFrmRepCusStateMultyStore1.SP_CustomerAgingOver90)
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try





    End Sub


End Class
