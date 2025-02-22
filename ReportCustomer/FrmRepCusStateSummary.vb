Imports CommonClass
Public Class FrmRepCusStateSummary
    Inherits CommonClass.FrmBase
    Dim Strwhere As String
    Dim WithEvents MyZipCode As UCZipCode.ClsZipCode
    Dim txtinvoicebalance As String
    Dim st As String
    Dim storename As String = ""
    Dim storeCod As String = ""
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
    Friend WithEvents PanelTypeCus As System.Windows.Forms.GroupBox
    Friend WithEvents PanelCus As System.Windows.Forms.Panel
    Friend WithEvents BtnCus As System.Windows.Forms.Button
    Friend WithEvents RdoSelectedCus As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllCus As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents PanelChk As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents CalendarCombo1 As CalendarCombo.CalendarCombo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DsFrmRepCusState1 As ReportCustomer.DSFrmRepCusState
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BtnShowFinance As System.Windows.Forms.Button
    Friend WithEvents BtnPriv As System.Windows.Forms.Button
    Friend WithEvents BtnComment As UCCommentButton.CommentButton
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
    Friend WithEvents DAGeneral As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAClass As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAType As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DACustomer As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents BtnSelect As System.Windows.Forms.Button
    Friend WithEvents CmdSPFindDueDate As System.Data.SqlClient.SqlCommand
    Friend WithEvents ChkZeroBalance As System.Windows.Forms.CheckBox
    Friend WithEvents ChkUnpaid As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSendCopie As System.Windows.Forms.CheckBox
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAForCommand As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents pb1 As Janus.Windows.EditControls.UIProgressBar
    Friend WithEvents DaSP_CustomerAging1to30 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaSP_CustomerAging31to60 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaSP_CustomerAging61to90 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaSP_CustomerAgingNotDueYet As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaSP_CustomerAgingOver90 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaAllCustomerWithBalance As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmRepCusStateTotal1 As ReportCustomer.DSFrmRepCusStateTotal
    Friend WithEvents TxtFromDate As CalendarCombo.CalendarCombo
    Friend WithEvents TxtToDate As CalendarCombo.CalendarCombo
    Friend WithEvents DaSP_CustomerBalance As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaCustomersName As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmRepCusStateMultyStore1 As ReportCustomer.DSFrmRepCusStateMultyStore
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ChkMultistore As System.Windows.Forms.CheckBox
    Friend WithEvents CmdSTORE_SETUP As System.Data.OleDb.OleDbCommand
    Friend WithEvents CnnForMdb As System.Data.OleDb.OleDbConnection
    Friend WithEvents LblStore As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdSTORE_SETUP1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents CnnForMdb1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents Cnn1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents ChkEmail As System.Windows.Forms.CheckBox
    Friend WithEvents FndCustomerData As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmRepCusStateSummary))
        Me.PanelTypeCus = New System.Windows.Forms.GroupBox
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
        Me.PanelCus = New System.Windows.Forms.Panel
        Me.BtnCus = New System.Windows.Forms.Button
        Me.RdoSelectedCus = New System.Windows.Forms.RadioButton
        Me.RdoAllCus = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.DsFrmRepCusStateTotal1 = New ReportCustomer.DSFrmRepCusStateTotal
        Me.DsFrmRepCusState1 = New ReportCustomer.DSFrmRepCusState
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.PanelChk = New System.Windows.Forms.GroupBox
        Me.ChkEmail = New System.Windows.Forms.CheckBox
        Me.ChkMultistore = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnComment = New UCCommentButton.CommentButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.ChkZeroBalance = New System.Windows.Forms.CheckBox
        Me.ChkUnpaid = New System.Windows.Forms.CheckBox
        Me.ChkSendCopie = New System.Windows.Forms.CheckBox
        Me.CalendarCombo1 = New CalendarCombo.CalendarCombo
        Me.TxtFromDate = New CalendarCombo.CalendarCombo
        Me.TxtToDate = New CalendarCombo.CalendarCombo
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.BtnSelect = New System.Windows.Forms.Button
        Me.BtnShowFinance = New System.Windows.Forms.Button
        Me.BtnPriv = New System.Windows.Forms.Button
        Me.DAGeneral = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAClass = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DAType = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DACustomer = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.CmdSPFindDueDate = New System.Data.SqlClient.SqlCommand
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAForCommand = New System.Data.SqlClient.SqlDataAdapter
        Me.pb1 = New Janus.Windows.EditControls.UIProgressBar
        Me.DaSP_CustomerAging1to30 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DaSP_CustomerAging31to60 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaSP_CustomerAging61to90 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DaSP_CustomerAgingNotDueYet = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DaSP_CustomerAgingOver90 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DaAllCustomerWithBalance = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.DaSP_CustomerBalance = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.DaCustomersName = New System.Data.SqlClient.SqlDataAdapter
        Me.DsFrmRepCusStateMultyStore1 = New ReportCustomer.DSFrmRepCusStateMultyStore
        Me.CmdSTORE_SETUP = New System.Data.OleDb.OleDbCommand
        Me.CnnForMdb = New System.Data.OleDb.OleDbConnection
        Me.LblStore = New System.Windows.Forms.Label
        Me.CmdSTORE_SETUP1 = New System.Data.OleDb.OleDbCommand
        Me.CnnForMdb1 = New System.Data.OleDb.OleDbConnection
        Me.Cnn1 = New System.Data.SqlClient.SqlConnection
        Me.FndCustomerData = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand
        Me.PanelTypeCus.SuspendLayout()
        Me.PanelClass.SuspendLayout()
        Me.PanelType.SuspendLayout()
        Me.PanelCus.SuspendLayout()
        CType(Me.DsFrmRepCusStateTotal1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmRepCusState1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelChk.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DsFrmRepCusStateMultyStore1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTypeCus
        '
        Me.PanelTypeCus.Controls.Add(Me.PanelClass)
        Me.PanelTypeCus.Controls.Add(Me.PanelType)
        Me.PanelTypeCus.Controls.Add(Me.PanelCus)
        Me.PanelTypeCus.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTypeCus.Location = New System.Drawing.Point(0, 48)
        Me.PanelTypeCus.Name = "PanelTypeCus"
        Me.PanelTypeCus.Size = New System.Drawing.Size(414, 160)
        Me.PanelTypeCus.TabIndex = 8
        Me.PanelTypeCus.TabStop = False
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
        Me.BtnClass.Location = New System.Drawing.Point(280, 16)
        Me.BtnClass.Name = "BtnClass"
        Me.BtnClass.TabIndex = 3
        Me.BtnClass.Text = "Choose..."
        '
        'RdoSelectedClass
        '
        Me.RdoSelectedClass.Location = New System.Drawing.Point(128, 16)
        Me.RdoSelectedClass.Name = "RdoSelectedClass"
        Me.RdoSelectedClass.Size = New System.Drawing.Size(112, 24)
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
        Me.BtnType.Location = New System.Drawing.Point(280, 16)
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
        'PanelCus
        '
        Me.PanelCus.Controls.Add(Me.BtnCus)
        Me.PanelCus.Controls.Add(Me.RdoSelectedCus)
        Me.PanelCus.Controls.Add(Me.RdoAllCus)
        Me.PanelCus.Controls.Add(Me.Label4)
        Me.PanelCus.Location = New System.Drawing.Point(16, 16)
        Me.PanelCus.Name = "PanelCus"
        Me.PanelCus.Size = New System.Drawing.Size(376, 40)
        Me.PanelCus.TabIndex = 6
        '
        'BtnCus
        '
        Me.BtnCus.Enabled = False
        Me.BtnCus.Location = New System.Drawing.Point(280, 16)
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
        'DsFrmRepCusStateTotal1
        '
        Me.DsFrmRepCusStateTotal1.DataSetName = "DSFrmRepCusStateTotal"
        Me.DsFrmRepCusStateTotal1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DsFrmRepCusState1
        '
        Me.DsFrmRepCusState1.DataSetName = "DSFrmRepCusState"
        Me.DsFrmRepCusState1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=FARAJI1;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=Tiremate_01;password=sa"
        '
        'PanelChk
        '
        Me.PanelChk.Controls.Add(Me.ChkEmail)
        Me.PanelChk.Controls.Add(Me.ChkMultistore)
        Me.PanelChk.Controls.Add(Me.Label2)
        Me.PanelChk.Controls.Add(Me.Label1)
        Me.PanelChk.Controls.Add(Me.BtnComment)
        Me.PanelChk.Controls.Add(Me.Label3)
        Me.PanelChk.Controls.Add(Me.ChkZeroBalance)
        Me.PanelChk.Controls.Add(Me.ChkUnpaid)
        Me.PanelChk.Controls.Add(Me.ChkSendCopie)
        Me.PanelChk.Controls.Add(Me.CalendarCombo1)
        Me.PanelChk.Controls.Add(Me.TxtFromDate)
        Me.PanelChk.Controls.Add(Me.TxtToDate)
        Me.PanelChk.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelChk.Location = New System.Drawing.Point(0, 208)
        Me.PanelChk.Name = "PanelChk"
        Me.PanelChk.Size = New System.Drawing.Size(414, 192)
        Me.PanelChk.TabIndex = 10
        Me.PanelChk.TabStop = False
        '
        'ChkEmail
        '
        Me.ChkEmail.Enabled = False
        Me.ChkEmail.Location = New System.Drawing.Point(264, 48)
        Me.ChkEmail.Name = "ChkEmail"
        Me.ChkEmail.Size = New System.Drawing.Size(112, 24)
        Me.ChkEmail.TabIndex = 23
        Me.ChkEmail.Text = "Automatic Email"
        '
        'ChkMultistore
        '
        Me.ChkMultistore.Enabled = False
        Me.ChkMultistore.Location = New System.Drawing.Point(264, 88)
        Me.ChkMultistore.Name = "ChkMultistore"
        Me.ChkMultistore.Size = New System.Drawing.Size(80, 24)
        Me.ChkMultistore.TabIndex = 22
        Me.ChkMultistore.Text = "Multi Store"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(232, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "To Date"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "From Date"
        '
        'BtnComment
        '
        Me.BtnComment.Location = New System.Drawing.Point(288, 128)
        Me.BtnComment.Name = "BtnComment"
        Me.BtnComment.Size = New System.Drawing.Size(88, 23)
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
        Me.Label3.Location = New System.Drawing.Point(8, 128)
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
        Me.ChkSendCopie.Enabled = False
        Me.ChkSendCopie.Location = New System.Drawing.Point(8, 16)
        Me.ChkSendCopie.Name = "ChkSendCopie"
        Me.ChkSendCopie.Size = New System.Drawing.Size(312, 24)
        Me.ChkSendCopie.TabIndex = 12
        Me.ChkSendCopie.Text = "Print Statement Only For  Customers Requiring Copies"
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
        Me.CalendarCombo1.Location = New System.Drawing.Point(112, 128)
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
        'TxtFromDate
        '
        Me.TxtFromDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtFromDate.BorderColor = System.Drawing.Color.Empty
        Me.TxtFromDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtFromDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtFromDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtFromDate.EditableSal = True
        Me.TxtFromDate.Image = CType(resources.GetObject("TxtFromDate.Image"), System.Drawing.Image)
        Me.TxtFromDate.Location = New System.Drawing.Point(112, 160)
        Me.TxtFromDate.MaxValue = CType(2500, Short)
        Me.TxtFromDate.MinValue = CType(1800, Short)
        Me.TxtFromDate.Name = "TxtFromDate"
        Me.TxtFromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtFromDate.Sal_Mali = Nothing
        Me.TxtFromDate.ShowButton = True
        Me.TxtFromDate.Size = New System.Drawing.Size(110, 23)
        Me.TxtFromDate.TabIndex = 18
        Me.TxtFromDate.VisualStyle = False
        '
        'TxtToDate
        '
        Me.TxtToDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtToDate.BorderColor = System.Drawing.Color.Empty
        Me.TxtToDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtToDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtToDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtToDate.EditableSal = True
        Me.TxtToDate.Image = CType(resources.GetObject("TxtToDate.Image"), System.Drawing.Image)
        Me.TxtToDate.Location = New System.Drawing.Point(296, 158)
        Me.TxtToDate.MaxValue = CType(2500, Short)
        Me.TxtToDate.MinValue = CType(1800, Short)
        Me.TxtToDate.Name = "TxtToDate"
        Me.TxtToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtToDate.Sal_Mali = Nothing
        Me.TxtToDate.ShowButton = True
        Me.TxtToDate.Size = New System.Drawing.Size(110, 23)
        Me.TxtToDate.TabIndex = 19
        Me.TxtToDate.VisualStyle = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(336, 408)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.TabIndex = 13
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(176, 408)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.TabIndex = 12
        Me.BtnPrint.Text = "Print"
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
        Me.Panel4.Size = New System.Drawing.Size(414, 48)
        Me.Panel4.TabIndex = 9
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
        'BtnShowFinance
        '
        Me.BtnShowFinance.Location = New System.Drawing.Point(16, 408)
        Me.BtnShowFinance.Name = "BtnShowFinance"
        Me.BtnShowFinance.Size = New System.Drawing.Size(120, 23)
        Me.BtnShowFinance.TabIndex = 15
        Me.BtnShowFinance.Text = "Finance Charges"
        '
        'BtnPriv
        '
        Me.BtnPriv.Location = New System.Drawing.Point(256, 408)
        Me.BtnPriv.Name = "BtnPriv"
        Me.BtnPriv.TabIndex = 14
        Me.BtnPriv.Text = "Preview"
        '
        'DAGeneral
        '
        Me.DAGeneral.SelectCommand = Me.SqlSelectCommand1
        Me.DAGeneral.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TblReportSumDtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("RefNo", "RefNo"), New System.Data.Common.DataColumnMapping("date", "date"), New System.Data.Common.DataColumnMapping("descript", "descript"), New System.Data.Common.DataColumnMapping("payment", "payment")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Gl_receive_payment.cod_customer, Gl_receive_payment.refrence_no AS RefNo, " & _
        "Gl_receive_payment.date_receive_payment AS date, CASE WHEN refrence_no_Adjustmen" & _
        "t IS NULL THEN 'PAYMENT/INV NO ' + GL_payment_deposit.id_service_center ELSE 'PA" & _
        "YMENT/Adj No' + GL_payment_deposit.refrence_no_Adjustment END AS descript, GL_pa" & _
        "yment_deposit.payment_amount AS payment FROM GL_payment_AR INNER JOIN GL_payment" & _
        "_deposit_Detail ON GL_payment_AR.ID_payment = GL_payment_deposit_Detail.ID_payme" & _
        "nt_due RIGHT OUTER JOIN Gl_receive_payment INNER JOIN GL_payment_deposit ON Gl_r" & _
        "eceive_payment.refrence_no = GL_payment_deposit.refrence_no ON GL_payment_deposi" & _
        "t_Detail.refrence_no = Gl_receive_payment.refrence_no AND GL_payment_deposit_Det" & _
        "ail.ID_payment_Paid = GL_payment_deposit.ID_payment WHERE (GL_payment_deposit.re" & _
        "fer_type = '2' OR GL_payment_deposit.refer_type = '3') AND (GL_payment_deposit.p" & _
        "ayment_amount > 0)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
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
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'DAForCommand
        '
        Me.DAForCommand.SelectCommand = Me.SqlSelectCommand4
        '
        'pb1
        '
        Me.pb1.Location = New System.Drawing.Point(128, 440)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(288, 14)
        Me.pb1.TabIndex = 16
        Me.pb1.Text = "Wait ..."
        Me.pb1.Visible = False
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
        'DaAllCustomerWithBalance
        '
        Me.DaAllCustomerWithBalance.SelectCommand = Me.SqlSelectCommand7
        Me.DaAllCustomerWithBalance.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CustomerBalance", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")})})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "[SP_CustomerBalance]"
        Me.SqlSelectCommand7.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand7.Connection = Me.Cnn
        Me.SqlSelectCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        Me.SqlSelectCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisCustomer", System.Data.SqlDbType.VarChar, 10))
        '
        'DaSP_CustomerBalance
        '
        Me.DaSP_CustomerBalance.SelectCommand = Me.SqlSelectCommand9
        Me.DaSP_CustomerBalance.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SP_CustomerBalanceForStatement", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cod_customer", "Cod_customer"), New System.Data.Common.DataColumnMapping("StoreCode", "StoreCode"), New System.Data.Common.DataColumnMapping("StoreName", "StoreName"), New System.Data.Common.DataColumnMapping("Descript", "Descript"), New System.Data.Common.DataColumnMapping("Date", "Date"), New System.Data.Common.DataColumnMapping("BalanceAmount", "BalanceAmount")})})
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "[SP_CustomerBalanceForStatement]"
        Me.SqlSelectCommand9.CommandType = System.Data.CommandType.StoredProcedure
        Me.SqlSelectCommand9.Connection = Me.Cnn
        Me.SqlSelectCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlSelectCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.NVarChar, 10))
        Me.SqlSelectCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreCode", System.Data.SqlDbType.NVarChar, 2))
        Me.SqlSelectCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreName", System.Data.SqlDbType.NVarChar, 50))
        Me.SqlSelectCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descript", System.Data.SqlDbType.NVarChar, 50))
        Me.SqlSelectCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Todate", System.Data.SqlDbType.NVarChar, 10))
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_ma" & _
        "in.l_name AS name, cust_trtab_main.address, RTRIM(LTRIM(bas_zipcode.city)) + ' '" & _
        " + RTRIM(LTRIM(bas_zipcode.state)) + ' ' + RTRIM(LTRIM(cust_trtab_main.zip)) AS " & _
        "phone_1, cust_company.complete_name, cust_trtab_main.cod_class, cust_trtab_main." & _
        "cod_type, LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_ma" & _
        "in.m_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) AS OrderName, ISNULL(CA" & _
        "ST(cust_trtab_main.PrintStatementDetailFlag AS int), 0) AS PrintStatementDetailF" & _
        "lag, cust_trtab_main.AR_statement FROM cust_trtab_main LEFT OUTER JOIN cust_comp" & _
        "any ON cust_trtab_main.cod_company = cust_company.cod_company LEFT OUTER JOIN ba" & _
        "s_zipcode ON cust_trtab_main.zip = bas_zipcode.zipcode WHERE (cust_trtab_main.AR" & _
        "_charge = 1)"
        Me.SqlSelectCommand8.Connection = Me.Cnn
        '
        'DaCustomersName
        '
        Me.DaCustomersName.SelectCommand = Me.SqlSelectCommand8
        Me.DaCustomersName.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CustomersName", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("name", "name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("complete_name", "complete_name"), New System.Data.Common.DataColumnMapping("cod_class", "cod_class"), New System.Data.Common.DataColumnMapping("cod_type", "cod_type"), New System.Data.Common.DataColumnMapping("OrderName", "OrderName"), New System.Data.Common.DataColumnMapping("PrintStatementDetailFlag", "PrintStatementDetailFlag")})})
        '
        'DsFrmRepCusStateMultyStore1
        '
        Me.DsFrmRepCusStateMultyStore1.DataSetName = "DSFrmRepCusStateMultyStore"
        Me.DsFrmRepCusStateMultyStore1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'CmdSTORE_SETUP
        '
        Me.CmdSTORE_SETUP.CommandText = "SELECT STORENO, SHORTNAME FROM STORE_SETUP"
        Me.CmdSTORE_SETUP.Connection = Me.CnnForMdb
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
        'LblStore
        '
        Me.LblStore.Location = New System.Drawing.Point(16, 438)
        Me.LblStore.Name = "LblStore"
        Me.LblStore.Size = New System.Drawing.Size(104, 18)
        Me.LblStore.TabIndex = 21
        Me.LblStore.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdSTORE_SETUP1
        '
        Me.CmdSTORE_SETUP1.CommandText = "SELECT STORENO, SHORTNAME FROM STORE_SETUP"
        Me.CmdSTORE_SETUP1.Connection = Me.CnnForMdb1
        '
        'CnnForMdb1
        '
        Me.CnnForMdb1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Data Source=""D:\TireMatesetup.mdb"";Jet OLEDB:Engine Type=5;Provide" & _
        "r=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;persi" & _
        "st security info=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:Encry" & _
        "pt Database=False;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Lo" & _
        "cale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Adm" & _
        "in;Jet OLEDB:Global Bulk Transactions=1"
        '
        'Cnn1
        '
        Me.Cnn1.ConnectionString = "workstation id=FARAJI1;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=Tiremate_02;password=sa"
        '
        'FndCustomerData
        '
        Me.FndCustomerData.SelectCommand = Me.SqlCommand5
        Me.FndCustomerData.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_trtab_main", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("vip_code", "vip_code"), New System.Data.Common.DataColumnMapping("cod_company", "cod_company"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("driver_name1", "driver_name1"), New System.Data.Common.DataColumnMapping("driver_name2", "driver_name2"), New System.Data.Common.DataColumnMapping("driver_name3", "driver_name3"), New System.Data.Common.DataColumnMapping("driver_name4", "driver_name4"), New System.Data.Common.DataColumnMapping("DriverLicense", "DriverLicense"), New System.Data.Common.DataColumnMapping("zip", "zip"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("cod_sales_rep", "cod_sales_rep"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cust_exempt_tax", "cust_exempt_tax"), New System.Data.Common.DataColumnMapping("scrap_check", "scrap_check"), New System.Data.Common.DataColumnMapping("scrap_value", "scrap_value"), New System.Data.Common.DataColumnMapping("credit_card_no", "credit_card_no"), New System.Data.Common.DataColumnMapping("expiration_credit_date", "expiration_credit_date"), New System.Data.Common.DataColumnMapping("credit_limited", "credit_limited"), New System.Data.Common.DataColumnMapping("AR_charge", "AR_charge"), New System.Data.Common.DataColumnMapping("AR_term", "AR_term"), New System.Data.Common.DataColumnMapping("cod_sales_tax", "cod_sales_tax"), New System.Data.Common.DataColumnMapping("cod_price", "cod_price"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("cod_type", "cod_type"), New System.Data.Common.DataColumnMapping("cod_source", "cod_source"), New System.Data.Common.DataColumnMapping("cod_class", "cod_class"), New System.Data.Common.DataColumnMapping("cod_territory", "cod_territory"), New System.Data.Common.DataColumnMapping("desc_sales_report", "desc_sales_report"), New System.Data.Common.DataColumnMapping("user_id", "user_id"), New System.Data.Common.DataColumnMapping("user_password", "user_password"), New System.Data.Common.DataColumnMapping("AR_statement", "AR_statement"), New System.Data.Common.DataColumnMapping("AR_send_copy", "AR_send_copy"), New System.Data.Common.DataColumnMapping("AR_finance_charge", "AR_finance_charge"), New System.Data.Common.DataColumnMapping("AR_require_PO", "AR_require_PO"), New System.Data.Common.DataColumnMapping("AR_credit_hold", "AR_credit_hold"), New System.Data.Common.DataColumnMapping("AR_accept_check", "AR_accept_check"), New System.Data.Common.DataColumnMapping("cust_notes", "cust_notes"), New System.Data.Common.DataColumnMapping("Taxable", "Taxable"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("customer_no", "customer_no")})})
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "SELECT * FROM cust_trtab_main WHERE (cod_customer = @Cod_Customer)"
        Me.SqlCommand5.Connection = Me.Cnn
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        '
        'FrmRepCusStateSummary
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(414, 460)
        Me.Controls.Add(Me.LblStore)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.BtnShowFinance)
        Me.Controls.Add(Me.BtnPriv)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.PanelChk)
        Me.Controls.Add(Me.PanelTypeCus)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmRepCusStateSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Print Customer Statements"
        Me.PanelTypeCus.ResumeLayout(False)
        Me.PanelClass.ResumeLayout(False)
        Me.PanelType.ResumeLayout(False)
        Me.PanelCus.ResumeLayout(False)
        CType(Me.DsFrmRepCusStateTotal1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmRepCusState1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelChk.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DsFrmRepCusStateMultyStore1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmRepCusState_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        txtinvoicebalance = " ( SELECT  id_service_center  FROM View_Invoice_Balance  WHERE   BalanceAmount <> 0  or (BalanceAmount =0 and dbo.changedate(date_refer) <=  " & Qt(Format(Now(), "yyyy/MM/dd")) & " and dbo.changedate(date_refer) >= " & Qt(Format(Now().AddMonths(-1), "yyyy/MM/dd")) & " ) )"
        ''txtinvoicebalance = " ( SELECT  id_service_center  FROM View_Invoice_Balance  WHERE   (BalanceAmount =0 and dbo.changedate(date_refer) <=  " & Qt(Format(Now(), "yyyy/MM/dd")) & " and dbo.changedate(date_refer) >= " & Qt(Format(Now().AddMonths(-1), "yyyy/MM/dd")) & " ) )"
        MyZipCode = New UCZipCode.ClsZipCode
        MyZipCode.Connection = Me.Cnn
        Cnn.ConnectionString = PConnectionString
        CnnForMdb.ConnectionString = PConnectionStringForSetupTables
        CnnForMdb1.ConnectionString = PConnectionStringForSetupTables

        CalendarCombo1.Text = Format(Now(), "MM/dd/yyyy")
        TxtFromDate.Text = Format(Now().AddMonths(-1), "MM/dd/yyyy")
        TxtToDate.Text = Format(Now(), "MM/dd/yyyy")
        TxtToDate.Enabled = True
        storename = PubStoreName
        storeCod = PubStoreNO
        Try
            DaSP_CustomerBalance.SelectCommand.Parameters("@ThisDate").Value = TxtFromDate.Text
            DaSP_CustomerBalance.SelectCommand.Parameters("@TODate").Value = TxtFromDate.Text
            DaSP_CustomerBalance.SelectCommand.Parameters("@storecode").Value = " "
            DaSP_CustomerBalance.SelectCommand.Parameters("@storename").Value = " "
            DaSP_CustomerBalance.SelectCommand.Parameters("@descriptn").Value = " "
            DaSP_CustomerBalance.Fill(DsFrmRepCusStateTotal1.TblReportSum)
        Catch ex As Exception
            DsFrmRepCusStateTotal1.Clear()
        End Try

    End Sub
    Private Sub RdoAllCus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllCus.CheckedChanged, RdoSelectedCus.CheckedChanged
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
        If DsFrmRepCusStateTotal1.customer.Count = 0 Then
            DACustomer.Fill(DsFrmRepCusStateTotal1.customer)
        End If
        f.Text = "  Select Customer"
        f.TypeOfForm = FrmSelect.KindForm.customer
        f.DSMAIN = DsFrmRepCusStateTotal1
        f.ShowDialog()
        BtnCus.Enabled = True
    End Sub

    Private Sub BtnType_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnType.Click
        BtnType.Enabled = False
        Dim f As New FrmSelect
        If DsFrmRepCusStateTotal1.type.Count = 0 Then
            DsFrmRepCusStateTotal1.type.Clear()
            DAType.Fill(DsFrmRepCusStateTotal1.type)
        End If
        f.Text = "  Select Type"
        f.TypeOfForm = FrmSelect.KindForm.type
        f.DSMAIN = DsFrmRepCusStateTotal1
        f.ShowDialog()
        BtnType.Enabled = True
    End Sub

    Private Sub BtnClass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClass.Click
        BtnClass.Enabled = False
        Dim f As New FrmSelect
        If DsFrmRepCusStateTotal1.clas.Count = 0 Then
            DsFrmRepCusStateTotal1.clas.Clear()
            DAClass.Fill(DsFrmRepCusStateTotal1.clas)
        End If
        f.Text = "  Select Class"
        f.TypeOfForm = FrmSelect.KindForm.clas
        f.DSMAIN = DsFrmRepCusStateTotal1
        f.ShowDialog()
        BtnClass.Enabled = True
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Function ControlSelect() As Boolean
        ControlSelect = True
        Dim StrChk3 As String
        Dim FlagControl As Boolean

        Dim i As Integer
        'StrCustomer = ""
        FlagControl = False
        If RdoSelectedCus.Checked Then

            For i = 0 To DsFrmRepCusState1.customer.Count - 1
                If DsFrmRepCusState1.customer(i).flag Then
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

            For i = 0 To DsFrmRepCusState1.type.Count - 1
                If DsFrmRepCusState1.type(i).flag Then
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
            'For i = 0 To DsFrmRepCusState1.clas.Count - 1
            '    If DsFrmRepCusState1.clas(i).flag Then
            '        StrClass = StrClass & " cust_trtab_main.cod_class = " & Qt(DsFrmRepCusState1.clas(i).cod) & " or "
            '    End If
            'Next
            'If StrClass.Trim.Length > 0 Then
            '    StrClass = Mid(StrClass, 1, StrClass.Length - 3)
            'Else
            '    ControlSelect = False
            '    MsgBox("First Select Class that you want")
            '    Exit Function
            'End If
            For i = 0 To DsFrmRepCusState1.clas.Count - 1
                If DsFrmRepCusState1.clas(i).flag Then
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

            'CmdGeneral.CommandText = " SELECT     cod_customer " & _
            '     " FROM         View_Customer_Balance " & _
            '     " WHERE     BalanceAmount <> '0'"

            'If CmdGeneral.Connection.State = ConnectionState.Closed Then
            '    CmdGeneral.Connection.Open()
            'End If
            'Dim SQLReader As System.Data.SqlClient.SqlDataReader
            'SQLReader = CmdGeneral.ExecuteReader
            'If SQLReader.HasRows Then
            '    Do While SQLReader.Read()
            '        StrChk3 = StrChk3 & " cust_trtab_main.cod_customer = " & Qt(SQLReader("cod_customer")) & " or "
            '    Loop
            '    StrChk3 = Mid(StrChk3, 1, StrChk3.Length - 3)
            '    CmdGeneral.Connection.Close()
            'Else
            '    CmdGeneral.Connection.Close()
            '    ControlSelect = False
            '    MsgBox(" No AR Customer Without zero  Balance ")
            '    Exit Function
            'End If
            StrChk3 = " cust_trtab_main.cod_customer  IN  (SELECT     cod_customer " & _
                 " FROM         View_Customer_Balance " & _
                 " WHERE     round(BalanceAmount,2) <> 0 )"
        End If

        Strwhere = ""
        Strwhere = "(cust_trtab_main.AR_statement = 1) AND " '(cust_trtab_main.AR_charge = 1) and  HAZF SHOD ARMANDE GOFT BA KETABI

        ''''''''''''chk1
        If ChkSendCopie.Checked Then
            Strwhere = Strwhere & "(cust_trtab_main.AR_send_copy = 1) AND "
        End If

        'If RdoSelectedCus.Checked Then
        '    Strwhere = Strwhere & " (" & StrCustomer & ") and "
        'End If
        'If RdoSelectedType.Checked Then

        '    Strwhere = Strwhere & " (" & StrType & ") and "
        'End If
        'If RdoSelectedClass.Checked Then
        '    Strwhere = Strwhere & "(" & StrClass & ") and "
        'End If
        If ChkZeroBalance.Checked Then
            Strwhere = Strwhere & " (" & StrChk3 & ") and "
        End If
        If Strwhere.Trim.Length > 0 Then Strwhere = Mid(Strwhere, 1, Strwhere.Length - 4)


    End Function

    Private Sub FillDatasetUnPaid()
        st = IIf(RdoSelectedCus.Checked, ",0 as flagcus ", ",1 as  flagcus ")
        st = st & IIf(RdoSelectedClass.Checked, ", 0 as flagclass ", ", 1 as flagclass")
        st = st & IIf(RdoSelectedType.Checked, ", 0 as flagtype ", ", 1 as flagtype")

        'Dim txtinvoicebalance As String = " ( SELECT  id_service_center  FROM View_Invoice_Balance  WHERE   BalanceAmount <> 0 )"
        Call ClearDataSet()
        ''''''''invoice due
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
                      " WHERE     (service_center_head.type_of_form = 'IN')  and  service_center_head.id_service_center IN " & txtinvoicebalance & " And " & Strwhere

        DAGeneral.Fill(DsFrmRepCusState1.report)
        pb1.Value += 1

        ''''''''''payment

        '''''''''''return

        '''''''''''return

        'DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.l_name AS name, cust_trtab_main.address, " & _
        '              " rtrim(ltrim(bas_zipcode.city))+' '+ rtrim(ltrim(bas_zipcode.state))+' '+ rtrim(ltrim(cust_trtab_main.zip)) AS phone_1, service_center_head.id_service_center AS RefNo,  " & _
        '              " service_center_head.date_refer AS date, 'RETURN FOR CREDIT' + service_center_head.id_service_center_before  AS Descript, GL_payment_deposit.payment_amount AS payment,cust_company.complete_name,cust_trtab_main.cod_class,cust_trtab_main.cod_type " & st & " ,dbo.changedate(service_center_head.date_refer) as OrderDate,ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) AS OrderName , DATEDIFF(day,GL_payment_AR.AR_due_date, GETDATE()) AS days " & _
        '              " FROM     GL_payment_AR INNER JOIN " & _
        '              " GL_payment_deposit ON GL_payment_AR.ID_payment = GL_payment_deposit.ID_payment INNER JOIN " & _
        '              " cust_trtab_main INNER JOIN " & _
        '              " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer ON  " & _
        '              " GL_payment_deposit.id_service_center = service_center_head.id_service_center_before LEFT OUTER JOIN " & _
        '              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        '              " LEFT OUTER JOIN bas_zipcode ON cust_trtab_main.zip = bas_zipcode.zipcode " & _
        '              " WHERE   " & Strwhere & "  and   (service_center_head.type_of_form = 'RT') AND (service_center_head.id_service_center_before IN " & _
        '              " (SELECT     service_center_head.id_service_center " & _
        '              " FROM         cust_trtab_main INNER JOIN " & _
        '              " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
        '              " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        '              " GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment " & _
        '              " WHERE     service_center_head.type_of_form = 'IN')) and service_center_head.id_service_center IN " & txtinvoicebalance & " And " & Strwhere

        '--------------------------------------------------'

        DAGeneral.Fill(DsFrmRepCusState1.report)
        pb1.Value += 1
        ''''''''adj+
        Call AdjPositive()

        DAGeneral.Fill(DsFrmRepCusState1.report)
        '''''''''''adj-
        Call AdjNegative()
        DAGeneral.Fill(DsFrmRepCusState1.report)
        pb1.Value += 1
        Call AllAging()

    End Sub
    Private Sub FillDataSetAll()
        st = IIf(RdoSelectedCus.Checked, ",0 as flagcus ", ",1 as  flagcus ")
        st = st & IIf(RdoSelectedClass.Checked, ", 0 as flagclass ", ", 1 as flagclass")
        st = st & IIf(RdoSelectedType.Checked, ", 0 as flagtype ", ", 1 as flagtype")


        Call ClearDataSet()
        ''''''''invoice Due By faraji add days field
        'datediff(day, GL_payment_AR.AR_due_date,getdate())
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
            DAGeneral.Fill(DsFrmRepCusState1.report)
        Catch ex As Exception

        End Try

        pb1.Value += 1
        ''''''''invoice Payment
        ''''''''''payment Due
        Call PayMent()
        DAGeneral.Fill(DsFrmRepCusState1.report)
        pb1.Value += 1
        '''''''''''return



        DAGeneral.Fill(DsFrmRepCusState1.report)
        pb1.Value += 1
        ''''''''''''''''''GL_paid_receive
        ''''''''adj+
        Call AdjPositive()
        DAGeneral.Fill(DsFrmRepCusState1.report)
        pb1.Value += 1
        '''''''''''adj-
        Call AdjNegative()

        DAGeneral.Fill(DsFrmRepCusState1.report)
        pb1.Value += 1
        Call AllAging()


    End Sub
    Private Sub makeFlagShow()

        Dim i As Integer

        If RdoSelectedCus.Checked Or RdoSelectedType.Checked Or RdoSelectedClass.Checked Then
            For i = 0 To DsFrmRepCusState1.report.Count - 1
                If RdoSelectedCus.Checked Then
                    If DsFrmRepCusState1.customer.Select("flag=1 and cod = " & Qt(DsFrmRepCusState1.report(i).cod_customer)).Length > 0 Then
                        DsFrmRepCusState1.report(i).flagcus = 1
                    End If

                End If
                If RdoSelectedType.Checked Then
                    If DsFrmRepCusState1.type.Select("flag=1 and cod = " & Qt(DsFrmRepCusState1.report(i).cod_type)).Length > 0 Then
                        DsFrmRepCusState1.report(i).flagtype = 1
                    End If
                End If
                If RdoSelectedClass.Checked Then
                    If DsFrmRepCusState1.clas.Select("flag=1 and cod = " & Qt(DsFrmRepCusState1.report(i).cod_class)).Length > 0 Then
                        DsFrmRepCusState1.report(i).flagclass = 1
                    End If
                End If
            Next
        End If

    End Sub
    Private Sub pprint(ByVal type As String)
        pb1.Visible = True
        pb1.Value = 0
        pb1.Maximum = 12
        BtnCancel.Enabled = False
        BtnPriv.Enabled = False
        BtnPrint.Enabled = False
        If ChkUnpaid.Checked Then
            Call FillDatasetUnPaid()
        Else
            Call FillDataSetAll()
        End If

        If DsFrmRepCusState1.report.Count = 0 Then
            MsgBox("No Data For Printing")
            Exit Sub
        End If
        Dim rpt As New RepCusState
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

        DsFrmRepCusState1.LOGO.Clear()
        Dim OleDbReaderForCompany As System.Data.OleDb.OleDbDataReader
        OleDbReaderForCompany = RetrieveCompanySetupTable()

        Try
            DsFrmRepCusState1.LOGO.AddLOGORow(OleDbReaderForCompany.Item("LOGO"), "l")
        Catch ex As Exception
            MsgBox("6-" & ex.Message)
        End Try

        rpt.SetParameterValue("Parcowebsite", OleDbReaderForCompany.Item("WEBPAGE"))

        OleDbReaderForStore = RetrieveAccountsReceivableSetupTable()

        rpt.SetParameterValue("Parannual", OleDbReaderForStore.Item("Default_annual_finance_charge") & "%")

        rpt.SetParameterValue("pardate", CalendarCombo1.Text)
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("parkindrep", "STATEMENT")
        rpt.SetParameterValue("parcomment", BtnComment.ZCommentText)

        rpt.SetDataSource(DsFrmRepCusState1)
        Me.Refresh()
        pb1.Value = pb1.Maximum
        pb1.Visible = False
        BtnCancel.Enabled = True
        BtnPriv.Enabled = True
        BtnPrint.Enabled = True

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
        'If ControlSelect() Then
        '    Call pprint("print")
        'End If

        Call ExecuteReport()
        If ChkUnpaid.Checked Then
            Dim C As New ClsStatementInvoiceAR
            C.DS = DsFrmRepCusStateTotal1
            C.date1 = TxtFromDate.Text
            C.date2 = TxtToDate.Text
            C.Fcus = RdoSelectedCus.Checked
            C.FClass = RdoSelectedClass.Checked
            C.Ftype = RdoSelectedType.Checked
            C.FillDAtaset("print")
        End If
      

    End Sub

    Private Sub BtnPriv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPriv.Click
        Call ExecuteReport()
        If ChkUnpaid.Checked Then
            Dim C As New ClsStatementInvoiceAR
            C.DS = DsFrmRepCusStateTotal1
            C.date1 = TxtFromDate.Text
            C.date2 = TxtToDate.Text
            C.Fcus = RdoSelectedCus.Checked
            C.FClass = RdoSelectedClass.Checked
            C.Ftype = RdoSelectedType.Checked
            C.FillDAtaset("priv")
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

    Private Sub BtnShowFinance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowFinance.Click
        Dim MyFrmAssessFinanceCharge As New UcAccount.FrmAssessFinanceCharge
        MyFrmAssessFinanceCharge.FinanceChargeDate = CalendarCombo1.Text
        MyFrmAssessFinanceCharge.ShowDialog()
    End Sub

    Private Sub pb1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles pb1.ValueChanged
        Application.DoEvents()
    End Sub
    Sub PayMent()
        DAGeneral.SelectCommand.CommandText = " SELECT     cod_customer, refrence_no AS RefNo, date_receive_payment AS date, 'Payment' AS descript, 0.00 AS charge, "
        DAGeneral.SelectCommand.CommandText += "           amount_receive - (amount_over + OtherStoreAmount) AS payment,    " & storename & " AS StoreName," & storeCod & " AS StoreCode "
        DAGeneral.SelectCommand.CommandText += " FROM      Gl_receive_payment "
        DAGeneral.SelectCommand.CommandText += " WHERE     (dbo.ChangeDate(date_receive_payment) BETWEEN  " & Format(TxtFromDate.Text, "yyyy/MM/dd/") & " AND  " & Format(TxtToDate.Text, "yyyy/MM/dd/") & ")"
        DAGeneral.SelectCommand.CommandText += " ORDER BY cod_customer "
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

    End Sub

    'Sub Return1()
    '    DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.l_name AS name, cust_trtab_main.address, " & _
    '          " rtrim(ltrim(bas_zipcode.city))+' '+ rtrim(ltrim(bas_zipcode.state))+' '+ rtrim(ltrim(cust_trtab_main.zip)) AS phone_1, service_center_head.id_service_center AS RefNo,  " & _
    '          " service_center_head.date_refer AS date, 'RETURN FOR CREDIT' + service_center_head.id_service_center_before  AS Descript, GL_payment_deposit.payment_amount AS payment,cust_company.complete_name,cust_trtab_main.cod_class,cust_trtab_main.cod_type " & st & " ,dbo.changedate(service_center_head.date_refer) as OrderDate,ltrim(rtrim(cust_trtab_main.l_name)) + ' ' +ltrim(rtrim(cust_trtab_main.m_name))+' '+ ltrim(rtrim(cust_trtab_main.f_name)) AS OrderName , DATEDIFF(day,GL_payment_AR.AR_due_date, GETDATE()) AS days " & _
    '          " FROM     GL_payment_AR INNER JOIN " & _
    '          " GL_payment_deposit ON GL_payment_AR.ID_payment = GL_payment_deposit.ID_payment INNER JOIN " & _
    '          " cust_trtab_main INNER JOIN " & _
    '          " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer ON  " & _
    '          " GL_payment_deposit.id_service_center = service_center_head.id_service_center_before LEFT OUTER JOIN " & _
    '          " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
    '          " LEFT OUTER JOIN bas_zipcode ON cust_trtab_main.zip = bas_zipcode.zipcode " & _
    '          " WHERE   " & Strwhere & "  and   (service_center_head.type_of_form = 'RT') AND (service_center_head.id_service_center_before IN " & _
    '          " (SELECT     service_center_head.id_service_center " & _
    '          " FROM         cust_trtab_main INNER JOIN " & _
    '          " service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
    '          " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
    '          " GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment " & _
    '          " WHERE     service_center_head.type_of_form = 'IN')) and service_center_head.id_service_center IN " & txtinvoicebalance & " And " & Strwhere

    'End Sub
    Sub AllAging()
        With DaSP_CustomerAging1to30
            .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
            .Fill(DsFrmRepCusState1.SP_CustomerAging1to30)
        End With

        pb1.Value += 1

        With DaSP_CustomerAging31to60
            .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
            .Fill(DsFrmRepCusState1.SP_CustomerAging31to60)
        End With
        pb1.Value += 1


        With DaSP_CustomerAging61to90
            .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
            .Fill(DsFrmRepCusState1.SP_CustomerAging61to90)
        End With

        pb1.Value += 1

        With DaSP_CustomerAgingNotDueYet
            .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
            .Fill(DsFrmRepCusState1.SP_CustomerAgingNotDueYet)
        End With
        pb1.Value += 1


        With DaSP_CustomerAgingOver90
            .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
            .Fill(DsFrmRepCusState1.SP_CustomerAgingOver90)
        End With
        pb1.Value += 1


        For i As Int16 = 0 To DsFrmRepCusState1.report.Count - 1
            Try
                DsFrmRepCusState1.report(i).c1 = DsFrmRepCusState1.SP_CustomerAgingNotDueYet.FindByCOD_CUSTOMER(DsFrmRepCusState1.report(i).cod_customer).BalanceAmount()
                DsFrmRepCusState1.report(i).c2 = DsFrmRepCusState1.SP_CustomerAging1to30.FindByCOD_CUSTOMER(DsFrmRepCusState1.report(i).cod_customer).BalanceAmount()
                DsFrmRepCusState1.report(i).c3 = DsFrmRepCusState1.SP_CustomerAging31to60.FindByCOD_CUSTOMER(DsFrmRepCusState1.report(i).cod_customer).BalanceAmount()
                DsFrmRepCusState1.report(i).c4 = DsFrmRepCusState1.SP_CustomerAging61to90.FindByCOD_CUSTOMER(DsFrmRepCusState1.report(i).cod_customer).BalanceAmount()
                DsFrmRepCusState1.report(i).c5 = DsFrmRepCusState1.SP_CustomerAgingOver90.FindByCOD_CUSTOMER(DsFrmRepCusState1.report(i).cod_customer).BalanceAmount()
            Catch ex As Exception
            End Try
            DsFrmRepCusState1.report(i).OrderName = IIf(DsFrmRepCusState1.report(i).complete_name = "", "zzzzz", DsFrmRepCusState1.report(i).complete_name) & DsFrmRepCusState1.report(i).OrderName & DsFrmRepCusState1.report(i).cod_customer
        Next
        Call makeFlagShow()
        pb1.Value += 1

    End Sub

    Sub ClearDataSet()
        DsFrmRepCusState1.report.Clear()
        DsFrmRepCusState1.report.Clear()
        DsFrmRepCusState1.SP_CustomerAging31to60.Clear()
        DsFrmRepCusState1.SP_CustomerAging61to90.Clear()
        DsFrmRepCusState1.SP_CustomerAgingNotDueYet.Clear()
        DsFrmRepCusState1.SP_CustomerAgingOver90.Clear()
        DsFrmRepCusState1.SP_CustomerAgingNotDueYet.Clear()
        DsFrmRepCusState1.LOGO.Clear()
        DsFrmRepCusState1.customerdue.Clear()

    End Sub

    'Private Sub CalculateAll1(ByVal ThisStoreNo As String, ByVal ThisStoreName As String)
    '    Try
    '        Dim daterange As String = Qt(Format(CDate(TxtFromDate.Text), "yyyy/MM/dd")) & " AND  " & Qt(Format(CDate(TxtToDate.Text), "yyyy/MM/dd")) & ")"
    '        Dim store1 = " ," & Qt(ThisStoreName) & " AS StoreName," & Qt(ThisStoreNo) & " AS StoreCode "
    '        Dim ccustomer As String = " And cod_customer in ( SELECT     cod_customer " & _
    '                                " FROM         View_Customer_Balance " & _
    '                                 " WHERE     BalanceAmount <> 0 )"
    '        pb1.Value = 0
    '        pb1.Maximum = 21
    '        pb1.Visible = True
    '        pb1.Value += 1
    '        Dim TmpDs As New DSFrmRepCusStateTotal
    '        '--------------------------------
    '        DaCustomersName.Fill(TmpDs.CustomersName)
    '        pb1.Value += 1
    '        Call MergeDsCustomerName(DsFrmRepCusStateTotal1, TmpDs)
    '        '--------------------------------------
    '        pb1.Value += 1
    '        DaSP_CustomerBalance.SelectCommand.Parameters("@ThisDate").Value = TxtFromDate.Text
    '        DaSP_CustomerBalance.SelectCommand.Parameters("@ToDate").Value = TxtToDate.Text
    '        DaSP_CustomerBalance.SelectCommand.Parameters("@storecode").Value = ThisStoreNo
    '        DaSP_CustomerBalance.SelectCommand.Parameters("@storename").Value = ThisStoreName
    '        DaSP_CustomerBalance.SelectCommand.Parameters("@descript").Value = "Balance Up To This Date"
    '        DaSP_CustomerBalance.Fill(DsFrmRepCusStateTotal1.TblReportSum)

    '        '-------INVOICE
    '        pb1.Value += 1
    '        DAGeneral.SelectCommand.CommandText = " SELECT     service_center_head.cod_customer, service_center_head.id_service_center AS RefNo, service_center_head.date_refer AS date, 'Invoice' AS descript, "
    '        DAGeneral.SelectCommand.CommandText += "                 SUM(GL_payment_deposit.payment_amount) AS charge, 0.00 AS payment " & store1
    '        DAGeneral.SelectCommand.CommandText += " FROM         service_center_head INNER JOIN"
    '        DAGeneral.SelectCommand.CommandText += " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center"
    '        DAGeneral.SelectCommand.CommandText += " WHERE     (service_center_head.type_of_form = 'IN') AND (GL_payment_deposit.payment_type = '4') AND (GL_payment_deposit.refer_type = '1') and( dbo.changedate(date_refer) BETWEEN  " & daterange & ccustomer
    '        DAGeneral.SelectCommand.CommandText += " GROUP BY service_center_head.cod_customer, service_center_head.id_service_center, service_center_head.date_refer " ', 'Invoice' , " & Qt(storename) & "," & Qt(storeCod)

    '        DAGeneral.Fill(DsFrmRepCusStateTotal1.TblReportSum)
    '        '--------PAYMENT
    '        pb1.Value += 1

    '        DAGeneral.SelectCommand.CommandText = " SELECT     cod_customer, refrence_no AS RefNo, date_receive_payment AS date, 'Payment' AS descript, 0.00 AS charge, "
    '        DAGeneral.SelectCommand.CommandText += "           amount_receive - (amount_over + OtherStoreAmount) AS payment    " & store1
    '        DAGeneral.SelectCommand.CommandText += " FROM      Gl_receive_payment "
    '        DAGeneral.SelectCommand.CommandText += " WHERE      (dbo.ChangeDate(date_receive_payment) BETWEEN  " & daterange & ccustomer
    '        DAGeneral.SelectCommand.CommandText += " ORDER BY cod_customer "
    '        DAGeneral.Fill(DsFrmRepCusStateTotal1.TblReportSum)
    '        pb1.Value += 1

    '        '------------------- payment dtl
    '        DAGeneral.SelectCommand.CommandText = " SELECT     Gl_receive_payment.cod_customer, Gl_receive_payment.refrence_no AS RefNo, Gl_receive_payment.date_receive_payment AS date, "
    '        DAGeneral.SelectCommand.CommandText += " CASE WHEN refrence_no_Adjustment IS NULL "
    '        DAGeneral.SelectCommand.CommandText += "  THEN 'PAYMENT/INV NO ' + GL_payment_deposit.id_service_center ELSE 'PAYMENT/Adj No' + GL_payment_deposit.refrence_no_Adjustment END AS descript,"
    '        DAGeneral.SelectCommand.CommandText += "  0.00 AS charge, GL_payment_deposit.payment_amount AS payment" & store1
    '        DAGeneral.SelectCommand.CommandText += " FROM         GL_payment_AR INNER JOIN"
    '        DAGeneral.SelectCommand.CommandText += "  GL_payment_deposit_Detail ON GL_payment_AR.ID_payment = GL_payment_deposit_Detail.ID_payment_due RIGHT OUTER JOIN"
    '        DAGeneral.SelectCommand.CommandText += " Gl_receive_payment INNER JOIN"
    '        DAGeneral.SelectCommand.CommandText += " GL_payment_deposit ON Gl_receive_payment.refrence_no = GL_payment_deposit.refrence_no ON "
    '        DAGeneral.SelectCommand.CommandText += " GL_payment_deposit_Detail.refrence_no = Gl_receive_payment.refrence_no AND "
    '        DAGeneral.SelectCommand.CommandText += " GL_payment_deposit_Detail.ID_payment_Paid = GL_payment_deposit.ID_payment"
    '        DAGeneral.SelectCommand.CommandText += " WHERE     (GL_payment_deposit.refer_type = '2' OR"
    '        DAGeneral.SelectCommand.CommandText += " GL_payment_deposit.refer_type = '3') AND (GL_payment_deposit.payment_amount > 0) and ( dbo.changedate(Gl_receive_payment.date_receive_payment)  BETWEEN  " & daterange & ccustomer
    '        DAGeneral.Fill(DsFrmRepCusStateTotal1.TblReportSumDtl)
    '        pb1.Value += 1

    '        'adjustment positive
    '        DAGeneral.SelectCommand.CommandText = "SELECT     cod_customer, refrence_no AS RefNo, date_adjustment AS DATE, "
    '        DAGeneral.SelectCommand.CommandText += " CASE WHEN GL_account_adjustment_head.finance_charge_flag = 1 THEN 'Finance Charge' ELSE 'Adjustment' END AS descript, "
    '        DAGeneral.SelectCommand.CommandText += " amount_adjustment AS charge, 0.00 AS PAYMENT   " & store1
    '        DAGeneral.SelectCommand.CommandText += " FROM GL_account_adjustment_head"
    '        DAGeneral.SelectCommand.CommandText += "   WHERE(amount_adjustment > 0) And (dbo.ChangeDate(date_adjustment) BETWEEN  " & daterange & ccustomer
    '        DAGeneral.Fill(DsFrmRepCusStateTotal1.TblReportSum)
    '        pb1.Value += 1

    '        'adjustment positive

    '        'adjustment negativ
    '        DAGeneral.SelectCommand.CommandText = "SELECT     cod_customer, refrence_no AS RefNo, date_adjustment AS DATE, "
    '        DAGeneral.SelectCommand.CommandText += " CASE WHEN GL_account_adjustment_head.finance_charge_flag = 1 THEN 'Finance Charge' ELSE 'Adjustment' END AS descript, "
    '        DAGeneral.SelectCommand.CommandText += " 0.00 AS charge, abs(amount_adjustment) AS PAYMENT   " & store1
    '        DAGeneral.SelectCommand.CommandText += " FROM GL_account_adjustment_head "
    '        DAGeneral.SelectCommand.CommandText += "   WHERE(amount_adjustment < 0) And (dbo.ChangeDate(date_adjustment) BETWEEN  " & daterange & ccustomer
    '        DAGeneral.Fill(DsFrmRepCusStateTotal1.TblReportSum)
    '        pb1.Value += 1


    '        DAGeneral.SelectCommand.CommandText = " SELECT     GL_account_adjustment_head.cod_customer, GL_account_adjustment_head.refrence_no AS RefNo, "
    '        DAGeneral.SelectCommand.CommandText += " GL_account_adjustment_head.date_adjustment AS date, "
    '        DAGeneral.SelectCommand.CommandText += " CASE WHEN GL_account_adjustment_head.finance_charge_flag = 1 THEN 'Finance Charget/INV NO ' + GL_account_adjustment_dtl.id_service_center WHEN"
    '        DAGeneral.SelectCommand.CommandText += " GL_account_adjustment_head.finance_charge_flag = 0 THEN CASE WHEN GL_account_adjustment_head.Gl_receive_payment_Refrence_no IS NOT NULL"
    '        DAGeneral.SelectCommand.CommandText += " THEN 'EARLY PAYMENT DISCOUNT' ELSE 'Adjustment/INV NO ' + GL_account_adjustment_dtl.id_service_center END END AS Descript, "
    '        DAGeneral.SelectCommand.CommandText += " CASE WHEN GL_account_adjustment_dtl.amount_adjustment > 0 THEN GL_account_adjustment_dtl.amount_adjustment END AS Charge, "
    '        DAGeneral.SelectCommand.CommandText += " CASE WHEN GL_account_adjustment_dtl.amount_adjustment < 0 THEN ABS(GL_account_adjustment_dtl.amount_adjustment) END AS PAYMENT " & store1
    '        DAGeneral.SelectCommand.CommandText += " FROM         GL_account_adjustment_head INNER JOIN"
    '        DAGeneral.SelectCommand.CommandText += " GL_account_adjustment_dtl ON GL_account_adjustment_head.refrence_no = GL_account_adjustment_dtl.refrence_no"
    '        DAGeneral.SelectCommand.CommandText += " WHERE(GL_account_adjustment_dtl.amount_adjustment <> 0) And (dbo.ChangeDate(GL_account_adjustment_head.date_adjustment) BETWEEN  " & daterange & ccustomer
    '        DAGeneral.Fill(DsFrmRepCusStateTotal1.TblReportSumDtl)
    '        pb1.Value += 1


    '        With DaSP_CustomerAging1to30
    '            .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
    '            .Fill(TmpDs.SP_CustomerAging1to30)
    '        End With

    '        pb1.Value += 1

    '        With DaSP_CustomerAging31to60
    '            .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
    '            .Fill(TmpDs.SP_CustomerAging31to60)
    '        End With
    '        pb1.Value += 1


    '        With DaSP_CustomerAging61to90
    '            .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
    '            .Fill(TmpDs.SP_CustomerAging61to90)
    '        End With

    '        pb1.Value += 1

    '        With DaSP_CustomerAgingNotDueYet
    '            .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
    '            .Fill(TmpDs.SP_CustomerAgingNotDueYet)
    '        End With

    '        pb1.Value += 1

    '        With DaSP_CustomerAgingOver90
    '            .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
    '            .Fill(TmpDs.SP_CustomerAgingOver90)
    '        End With


    '        pb1.Value += 1

    '        Dim a As Decimal = 0
    '        Dim b As Decimal = 0
    '        Dim c As Decimal = 0
    '        Dim d As Decimal = 0
    '        Dim e As Decimal = 0

    '        For i As Int64 = 0 To DsFrmRepCusStateTotal1.CustomersName.Count - 1
    '            Try
    '                Try
    '                    a = TmpDs.SP_CustomerAgingNotDueYet.FindByCOD_CUSTOMER(DsFrmRepCusStateTotal1.CustomersName(i).cod_customer).BalanceAmount()
    '                Catch ex As Exception
    '                    a = 0
    '                End Try

    '                Try
    '                    b = TmpDs.SP_CustomerAging1to30.FindByCOD_CUSTOMER(DsFrmRepCusStateTotal1.CustomersName(i).cod_customer).BalanceAmount()
    '                Catch ex As Exception
    '                    b = 0
    '                End Try

    '                Try
    '                    c = TmpDs.SP_CustomerAging31to60.FindByCOD_CUSTOMER(DsFrmRepCusStateTotal1.CustomersName(i).cod_customer).BalanceAmount()
    '                Catch ex As Exception
    '                    c = 0
    '                End Try

    '                Try
    '                    d = TmpDs.SP_CustomerAging61to90.FindByCOD_CUSTOMER(DsFrmRepCusStateTotal1.CustomersName(i).cod_customer).BalanceAmount()
    '                Catch ex As Exception
    '                    d = 0
    '                End Try
    '                Try
    '                    e = TmpDs.SP_CustomerAgingOver90.FindByCOD_CUSTOMER(DsFrmRepCusStateTotal1.CustomersName(i).cod_customer).BalanceAmount()
    '                Catch ex As Exception
    '                    e = 0
    '                End Try
    '                DsFrmRepCusStateTotal1.CustomersName(i).c1 = a + Val(DsFrmRepCusStateTotal1.CustomersName(i).c1 & "")
    '                DsFrmRepCusStateTotal1.CustomersName(i).c2 = b + Val(DsFrmRepCusStateTotal1.CustomersName(i).c2 & "")
    '                DsFrmRepCusStateTotal1.CustomersName(i).c3 = c + Val(DsFrmRepCusStateTotal1.CustomersName(i).c3 & "")
    '                DsFrmRepCusStateTotal1.CustomersName(i).c4 = d + Val(DsFrmRepCusStateTotal1.CustomersName(i).c4 & "")
    '                DsFrmRepCusStateTotal1.CustomersName(i).c5 = e + Val(DsFrmRepCusStateTotal1.CustomersName(i).c5 & "")

    '            Catch ex As Exception
    '                '  MsgBox(ex.ToString)
    '            End Try
    '            ' for show 
    '            DsFrmRepCusStateTotal1.CustomersName(i).OrderName = IIf(DsFrmRepCusStateTotal1.CustomersName(i).complete_name & "" = "", "zzzzz", DsFrmRepCusStateTotal1.CustomersName(i).complete_name & "") & DsFrmRepCusStateTotal1.CustomersName(i).OrderName & "" & DsFrmRepCusStateTotal1.CustomersName(i).cod_customer & ""
    '            If RdoSelectedCus.Checked Or RdoSelectedType.Checked Or RdoSelectedClass.Checked Then
    '                DsFrmRepCusStateTotal1.CustomersName(i).flagclass = True
    '                DsFrmRepCusStateTotal1.CustomersName(i).flagcus = True
    '                DsFrmRepCusStateTotal1.CustomersName(i).flagtype = True
    '                '-------------------------------
    '                Dim f As Boolean = False
    '                If RdoSelectedCus.Checked Then
    '                    Dim DR3 As DataRow = DsFrmRepCusStateTotal1.customer.FindBycod(DsFrmRepCusStateTotal1.CustomersName(i).cod_customer)
    '                    If Not DR3 Is Nothing Then
    '                        If DR3("flag") = True Then
    '                            f = True
    '                        Else
    '                            f = False
    '                        End If
    '                    End If

    '                End If

    '                '-------------------------------
    '                If RdoSelectedType.Checked Then
    '                    Dim DR4 As DataRow = DsFrmRepCusStateTotal1.type.FindBycod(DsFrmRepCusStateTotal1.CustomersName(i).cod_type)
    '                    If Not DR4 Is Nothing Then
    '                        If DR4("flag") = True Then
    '                            f = True Or f
    '                        Else
    '                            f = False Or f
    '                        End If
    '                    End If
    '                End If
    '                '-------------------------------
    '                If RdoSelectedClass.Checked Then
    '                    Dim DR5 As DataRow = DsFrmRepCusStateTotal1.clas.FindBycod(DsFrmRepCusStateTotal1.CustomersName(i).cod_class)
    '                    If Not DR5 Is Nothing Then
    '                        If DR5("flag") = True Then
    '                            f = True Or f
    '                        Else
    '                            f = False Or f
    '                        End If
    '                    End If
    '                End If
    '                '-------------------------------
    '                DsFrmRepCusStateTotal1.CustomersName(i).flagcus = f
    '                'End If
    '            Else
    '                DsFrmRepCusStateTotal1.CustomersName(i).flagclass = True
    '                DsFrmRepCusStateTotal1.CustomersName(i).flagcus = True
    '                DsFrmRepCusStateTotal1.CustomersName(i).flagtype = True
    '            End If


    '        Next
    '        pb1.Value += 1
    '        pb1.Visible = False
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try

    'End Sub

    Private Sub CalculateAll(ByVal ThisStoreNo As String, ByVal ThisStoreName As String)
        Dim ttt As Integer
        Try
            Try
                CmdGeneral.CommandText = "UPDATE    cust_trtab_main " & _
                                        "SET              AR_charge = 1 " & _
                                        "WHERE     (cod_customer IN " & _
                                        "                          (SELECT     cod_customer " & _
                                        "                             FROM         (SELECT     service_center_head.cod_customer, service_center_head.id_service_center AS RefNo,  " & _
                                        "                                                                           service_center_head.date_refer AS date, 'Invoice' AS descript, SUM(GL_payment_deposit.payment_amount) AS charge,  " & _
                                        "                                                                           0.00 AS payment, '02' AS StoreName, '02' AS StoreCode " & _
                                        "                                                     FROM         service_center_head INNER JOIN " & _
                                        "                                                                           GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center " & _
                                        "                                                     WHERE     (service_center_head.type_of_form = 'IN') AND (GL_payment_deposit.payment_type IN ('4', '5')) AND  " & _
                                        "                                                                           (GL_payment_deposit.refer_type = '1') AND (dbo.ChangeDate(service_center_head.date_refer) BETWEEN '2008/02/09' AND  " & _
                                        "                                                                           '2008/03/09') AND (service_center_head.cod_customer NOT IN " & _
                                        "                                                                               (SELECT     cod_customer " & _
                                        "                                                                                  FROM         cust_trtab_main " & _
                                        "                                                                                  WHERE     (AR_charge = 1))) " & _
                                        "                                                     GROUP BY service_center_head.cod_customer, service_center_head.id_service_center, service_center_head.date_refer)  " & _
                                        "                                                   DERIVEDTBL)) "
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            Catch ex As Exception
            Finally
                CmdGeneral.Connection.Close()
            End Try
            ''Label6.Text = "71"

            ttt = 0
            Dim daterange As String = Qt(Format(CDate(TxtFromDate.Text), "yyyy/MM/dd")) & " AND  " & Qt(Format(CDate(TxtToDate.Text), "yyyy/MM/dd")) & ")"
            Dim store1 = " ," & Qt(ThisStoreName) & " AS StoreName," & Qt(ThisStoreNo) & " AS StoreCode "
            'Dim ccustomer As String = " And cod_customer in ( SELECT     cod_customer " & _
            '                        " FROM         View_Customer_Balance " & _
            '                         " WHERE     BalanceAmount <> 0 )"
            ''Label6.Text = "72"

            pb1.Value = 0
            pb1.Maximum = 23
            pb1.Visible = True
            '            CreateBalanceForAllStore()
            pb1.Value += 1
            Dim TmpDs As New DSFrmRepCusStateTotal
            '--------------------------------
            DaCustomersName.Fill(TmpDs.CustomersName)
            '' Label6.Text = "73"
            pb1.Value += 1
            Call MergeDsCustomerName(DsFrmRepCusStateTotal1, TmpDs) ' merge customer
            ''Label6.Text = "74"
            '--------------------------------------
            ttt = 1
            pb1.Value += 1
            DaSP_CustomerBalance.SelectCommand.Connection = Cnn
            DaSP_CustomerBalance.SelectCommand.Parameters("@ThisDate").Value = TxtFromDate.Text
            DaSP_CustomerBalance.SelectCommand.Parameters("@ToDate").Value = TxtFromDate.Text
            DaSP_CustomerBalance.SelectCommand.Parameters("@storecode").Value = ThisStoreNo
            DaSP_CustomerBalance.SelectCommand.Parameters("@storename").Value = ThisStoreName
            DaSP_CustomerBalance.SelectCommand.Parameters("@descript").Value = "Balance Up To This Date"
            DaSP_CustomerBalance.Fill(DsFrmRepCusStateTotal1.TblReportSum)
            ''Label6.Text = "75"
            '-------INVOICE
            ttt = 2
            pb1.Value += 1
            DAGeneral.SelectCommand.CommandText = " SELECT     service_center_head.cod_customer, service_center_head.id_service_center AS RefNo, service_center_head.date_refer AS date, 'Invoice' AS descript, "
            DAGeneral.SelectCommand.CommandText += "                 SUM(GL_payment_deposit.payment_amount) AS charge, 0.00 AS payment " & store1
            DAGeneral.SelectCommand.CommandText += " FROM         service_center_head INNER JOIN"
            DAGeneral.SelectCommand.CommandText += " GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center"
            DAGeneral.SelectCommand.CommandText += " WHERE     (service_center_head.type_of_form = 'IN') AND (GL_payment_deposit.payment_type in( '4','5')) AND (GL_payment_deposit.refer_type = '1') and( dbo.changedate(date_refer) BETWEEN  " & daterange
            DAGeneral.SelectCommand.CommandText += " GROUP BY service_center_head.cod_customer, service_center_head.id_service_center, service_center_head.date_refer " ', 'Invoice' , " & Qt(storename) & "," & Qt(storeCod)
            ' 5 is paid for over payment
            DAGeneral.Fill(DsFrmRepCusStateTotal1.TblReportSum)
            ''Label6.Text = "76"
            '--------PAYMENT
            pb1.Value += 1
            ttt = 3
            DAGeneral.SelectCommand.CommandText = " SELECT     cod_customer, refrence_no AS RefNo, date_receive_payment AS date, 'Payment' AS descript, 0.00 AS charge, "
            DAGeneral.SelectCommand.CommandText += "           amount_receive - (amount_over + OtherStoreAmount) AS payment    " & store1
            DAGeneral.SelectCommand.CommandText += " FROM      Gl_receive_payment "
            DAGeneral.SelectCommand.CommandText += " WHERE      (dbo.ChangeDate(date_receive_payment) BETWEEN  " & daterange & " And (amount_receive - (amount_over + OtherStoreAmount)) <> 0"
            DAGeneral.SelectCommand.CommandText += " ORDER BY cod_customer   "
            DAGeneral.Fill(DsFrmRepCusStateTotal1.TblReportSum)
            ''Label6.Text = "77"
            'over payment
            ttt = 4
            DAGeneral.SelectCommand.CommandText = " SELECT     cod_customer, refrence_no AS RefNo, date_receive_payment AS date, 'over Payment' AS descript, 0.00 AS charge, "
            DAGeneral.SelectCommand.CommandText += "           isnull(amount_over,0) AS payment    " & store1
            DAGeneral.SelectCommand.CommandText += " FROM      Gl_receive_payment "
            DAGeneral.SelectCommand.CommandText += " WHERE      (dbo.ChangeDate(date_receive_payment) BETWEEN  " & daterange & " and isnull(amount_over,0) <> 0"
            DAGeneral.SelectCommand.CommandText += " ORDER BY cod_customer "
            DAGeneral.Fill(DsFrmRepCusStateTotal1.TblReportSum)
            pb1.Value += 1
            ttt = 5
            ''Label6.Text = "78"
            '------------------- payment dtl
            DAGeneral.SelectCommand.CommandText = " SELECT     Gl_receive_payment.cod_customer, Gl_receive_payment.refrence_no AS RefNo, Gl_receive_payment.date_receive_payment AS date, "
            DAGeneral.SelectCommand.CommandText += " CASE WHEN refrence_no_Adjustment IS NULL "
            DAGeneral.SelectCommand.CommandText += "  THEN 'PAYMENT/INV NO ' + GL_payment_deposit.id_service_center ELSE 'PAYMENT/Adj No' + GL_payment_deposit.refrence_no_Adjustment END AS descript,"
            DAGeneral.SelectCommand.CommandText += "  0.00 AS charge, GL_payment_deposit.payment_amount AS payment" & store1
            DAGeneral.SelectCommand.CommandText += " FROM         GL_payment_AR INNER JOIN"
            DAGeneral.SelectCommand.CommandText += "  GL_payment_deposit_Detail ON GL_payment_AR.ID_payment = GL_payment_deposit_Detail.ID_payment_due RIGHT OUTER JOIN"
            DAGeneral.SelectCommand.CommandText += " Gl_receive_payment INNER JOIN"
            DAGeneral.SelectCommand.CommandText += " GL_payment_deposit ON Gl_receive_payment.refrence_no = GL_payment_deposit.refrence_no ON "
            DAGeneral.SelectCommand.CommandText += " GL_payment_deposit_Detail.refrence_no = Gl_receive_payment.refrence_no AND "
            DAGeneral.SelectCommand.CommandText += " GL_payment_deposit_Detail.ID_payment_Paid = GL_payment_deposit.ID_payment"
            DAGeneral.SelectCommand.CommandText += " WHERE     (GL_payment_deposit.refer_type = '2' OR"
            DAGeneral.SelectCommand.CommandText += " GL_payment_deposit.refer_type = '3') AND (GL_payment_deposit.payment_amount > 0) and ( dbo.changedate(Gl_receive_payment.date_receive_payment)  BETWEEN  " & daterange
            DAGeneral.Fill(DsFrmRepCusStateTotal1.TblReportSumDtl)
            pb1.Value += 1
            ttt = 6
            ''Label6.Text = "79"
            'adjustment positive
            DAGeneral.SelectCommand.CommandText = "SELECT     cod_customer, refrence_no AS RefNo, date_adjustment AS DATE, "
            DAGeneral.SelectCommand.CommandText += " CASE WHEN GL_account_adjustment_head.finance_charge_flag = 1 THEN 'Finance Charge' ELSE 'Adjustment' END AS descript, "
            DAGeneral.SelectCommand.CommandText += " amount_adjustment AS charge, 0.00 AS PAYMENT   " & store1
            DAGeneral.SelectCommand.CommandText += " FROM GL_account_adjustment_head"
            DAGeneral.SelectCommand.CommandText += "   WHERE(amount_adjustment > 0) And (dbo.ChangeDate(date_adjustment) BETWEEN  " & daterange
            DAGeneral.Fill(DsFrmRepCusStateTotal1.TblReportSum)
            pb1.Value += 1
            ''Label6.Text = "791"
            'adjustment positive
            ttt = 8
            'adjustment negativ
            DAGeneral.SelectCommand.CommandText = "SELECT     cod_customer, refrence_no AS RefNo, date_adjustment AS DATE, "
            DAGeneral.SelectCommand.CommandText += " CASE WHEN GL_account_adjustment_head.finance_charge_flag = 1 THEN 'Finance Charge' ELSE 'Adjustment' END AS descript, "
            DAGeneral.SelectCommand.CommandText += " 0.00 AS charge, abs(amount_adjustment) AS PAYMENT   " & store1
            DAGeneral.SelectCommand.CommandText += " FROM GL_account_adjustment_head "
            DAGeneral.SelectCommand.CommandText += "   WHERE(amount_adjustment < 0) And (dbo.ChangeDate(date_adjustment) BETWEEN  " & daterange
            DAGeneral.Fill(DsFrmRepCusStateTotal1.TblReportSum)
            pb1.Value += 1
            ''Label6.Text = "792"
            ttt = 9
            DAGeneral.SelectCommand.CommandText = " SELECT     GL_account_adjustment_head.cod_customer, GL_account_adjustment_head.refrence_no AS RefNo, "
            DAGeneral.SelectCommand.CommandText += " GL_account_adjustment_head.date_adjustment AS date, "
            DAGeneral.SelectCommand.CommandText += " CASE WHEN GL_account_adjustment_head.finance_charge_flag = 1 THEN 'Finance Charge/INV NO ' + GL_account_adjustment_dtl.id_service_center WHEN"
            DAGeneral.SelectCommand.CommandText += " GL_account_adjustment_head.finance_charge_flag = 0 THEN CASE WHEN GL_account_adjustment_head.Gl_receive_payment_Refrence_no IS NOT NULL"
            DAGeneral.SelectCommand.CommandText += " THEN 'EARLY PAYMENT DISCOUNT' ELSE 'Adjustment/INV NO ' + GL_account_adjustment_dtl.id_service_center END END AS Descript, "
            DAGeneral.SelectCommand.CommandText += " CASE WHEN GL_account_adjustment_dtl.amount_adjustment > 0 THEN GL_account_adjustment_dtl.amount_adjustment END AS Charge, "
            DAGeneral.SelectCommand.CommandText += " CASE WHEN GL_account_adjustment_dtl.amount_adjustment < 0 THEN ABS(GL_account_adjustment_dtl.amount_adjustment) END AS PAYMENT " & store1
            DAGeneral.SelectCommand.CommandText += " FROM         GL_account_adjustment_head INNER JOIN"
            DAGeneral.SelectCommand.CommandText += " GL_account_adjustment_dtl ON GL_account_adjustment_head.refrence_no = GL_account_adjustment_dtl.refrence_no"
            DAGeneral.SelectCommand.CommandText += " WHERE(GL_account_adjustment_dtl.amount_adjustment <> 0) And (dbo.ChangeDate(GL_account_adjustment_head.date_adjustment) BETWEEN  " & daterange
            DAGeneral.Fill(DsFrmRepCusStateTotal1.TblReportSumDtl)
            pb1.Value += 1
            ''Label6.Text = "793"
            ttt = 10
            With DaSP_CustomerAging1to30
                .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
                .Fill(TmpDs.SP_CustomerAging1to30)
            End With
            ''Label6.Text = "794"
            pb1.Value += 1
            ttt = 11
            With DaSP_CustomerAging31to60
                .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
                .Fill(TmpDs.SP_CustomerAging31to60)
            End With
            pb1.Value += 1
            ttt = 12
            ''Label6.Text = "795"
            With DaSP_CustomerAging61to90
                .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
                .Fill(TmpDs.SP_CustomerAging61to90)
            End With
            ''Label6.Text = "796"

            pb1.Value += 1
            ttt = 13
            With DaSP_CustomerAgingNotDueYet
                .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
                .Fill(TmpDs.SP_CustomerAgingNotDueYet)
            End With
            ''Label6.Text = "797"
            pb1.Value += 1

            With DaSP_CustomerAgingOver90
                .SelectCommand.Parameters("@thisdate").Value = Format(Now(), "MM/dd/yyyy")
                .Fill(TmpDs.SP_CustomerAgingOver90)
            End With
            ttt = 14
            ''Label6.Text = "798"
            pb1.Value += 1

            Dim a As Decimal = 0
            Dim b As Decimal = 0
            Dim c As Decimal = 0
            Dim d As Decimal = 0
            Dim e As Decimal = 0

            For i As Int64 = 0 To DsFrmRepCusStateTotal1.CustomersName.Count - 1
                Try
                    Try
                        a = TmpDs.SP_CustomerAgingNotDueYet.FindByCOD_CUSTOMER(DsFrmRepCusStateTotal1.CustomersName(i).cod_customer).BalanceAmount()
                    Catch ex As Exception
                        a = 0
                    End Try

                    Try
                        b = TmpDs.SP_CustomerAging1to30.FindByCOD_CUSTOMER(DsFrmRepCusStateTotal1.CustomersName(i).cod_customer).BalanceAmount()
                    Catch ex As Exception
                        b = 0
                    End Try

                    Try
                        c = TmpDs.SP_CustomerAging31to60.FindByCOD_CUSTOMER(DsFrmRepCusStateTotal1.CustomersName(i).cod_customer).BalanceAmount()
                    Catch ex As Exception
                        c = 0
                    End Try

                    Try
                        d = TmpDs.SP_CustomerAging61to90.FindByCOD_CUSTOMER(DsFrmRepCusStateTotal1.CustomersName(i).cod_customer).BalanceAmount()
                    Catch ex As Exception
                        d = 0
                    End Try
                    Try
                        e = TmpDs.SP_CustomerAgingOver90.FindByCOD_CUSTOMER(DsFrmRepCusStateTotal1.CustomersName(i).cod_customer).BalanceAmount()
                    Catch ex As Exception
                        e = 0
                    End Try
                    ttt = 18
                    '                    If TxtToDate.Text = Format(Now(), "MM/dd/yyyy") Then
                    DsFrmRepCusStateTotal1.CustomersName(i).c1 = a + Val(DsFrmRepCusStateTotal1.CustomersName(i).c1 & "")
                    DsFrmRepCusStateTotal1.CustomersName(i).c2 = b + Val(DsFrmRepCusStateTotal1.CustomersName(i).c2 & "")
                    DsFrmRepCusStateTotal1.CustomersName(i).c3 = c + Val(DsFrmRepCusStateTotal1.CustomersName(i).c3 & "")
                    DsFrmRepCusStateTotal1.CustomersName(i).c4 = d + Val(DsFrmRepCusStateTotal1.CustomersName(i).c4 & "")
                    DsFrmRepCusStateTotal1.CustomersName(i).c5 = e + Val(DsFrmRepCusStateTotal1.CustomersName(i).c5 & "")
                    '                   Else
                    'hamid goft ino bardarim
                    '    DsFrmRepCusStateTotal1.CustomersName(i).c1 = 0
                    '    DsFrmRepCusStateTotal1.CustomersName(i).c2 = 0
                    '    DsFrmRepCusStateTotal1.CustomersName(i).c3 = 0
                    '    DsFrmRepCusStateTotal1.CustomersName(i).c4 = 0
                    '    DsFrmRepCusStateTotal1.CustomersName(i).c5 = 0
                    '                  End If
                Catch ex As Exception
                    '  MsgBox(ex.ToString)
                End Try
                ' for show 
                DsFrmRepCusStateTotal1.CustomersName(i).OrderName = IIf(DsFrmRepCusStateTotal1.CustomersName(i).complete_name & "" = "", "zzzzz", DsFrmRepCusStateTotal1.CustomersName(i).complete_name & "") & DsFrmRepCusStateTotal1.CustomersName(i).OrderName & "" & DsFrmRepCusStateTotal1.CustomersName(i).cod_customer & ""
                DsFrmRepCusStateTotal1.CustomersName(i).flagemail = False
                ttt = 19
                If RdoSelectedCus.Checked Or RdoSelectedType.Checked Or RdoSelectedClass.Checked Then
                    DsFrmRepCusStateTotal1.CustomersName(i).flagclass = True
                    DsFrmRepCusStateTotal1.CustomersName(i).flagcus = True
                    DsFrmRepCusStateTotal1.CustomersName(i).flagtype = True

                    '-------------------------------
                    Dim f As Boolean = False
                    If RdoSelectedCus.Checked Then
                        Dim DR3 As DataRow = DsFrmRepCusStateTotal1.customer.FindBycod(DsFrmRepCusStateTotal1.CustomersName(i).cod_customer)
                        If Not DR3 Is Nothing Then
                            If DR3("flag") = True Then
                                f = True
                            Else
                                f = False
                            End If
                        End If

                    End If

                    '-------------------------------
                    If RdoSelectedType.Checked Then
                        Dim DR4 As DataRow = DsFrmRepCusStateTotal1.type.FindBycod(DsFrmRepCusStateTotal1.CustomersName(i).cod_type)
                        If Not DR4 Is Nothing Then
                            If DR4("flag") = True Then
                                f = True Or f
                            Else
                                f = False Or f
                            End If
                        End If
                    End If
                    ttt = 20
                    '-------------------------------
                    If RdoSelectedClass.Checked Then
                        Dim DR5 As DataRow = DsFrmRepCusStateTotal1.clas.FindBycod(DsFrmRepCusStateTotal1.CustomersName(i).cod_class)
                        If Not DR5 Is Nothing Then
                            If DR5("flag") = True Then
                                f = True Or f
                            Else
                                f = False Or f
                            End If
                        End If
                    End If
                    '-------------------------------
                    DsFrmRepCusStateTotal1.CustomersName(i).flagcus = f
                    'End If
                Else
                    DsFrmRepCusStateTotal1.CustomersName(i).flagclass = True
                    DsFrmRepCusStateTotal1.CustomersName(i).flagcus = True
                    DsFrmRepCusStateTotal1.CustomersName(i).flagtype = True
                End If
                If DsFrmRepCusStateTotal1.CustomersName(i).Item("Ar_statement") = False Then
                    DsFrmRepCusStateTotal1.CustomersName(i).flagcus = False
                End If
            Next
            'Delete all for all store customer balance =0 
            pb1.Value += 1
            pb1.Visible = False
        Catch ex As Exception
            MsgBox("1-" & ttt & "-" & ex.ToString)
        End Try

    End Sub


    Sub preview()
        Dim rpt As New RepCusStateSummary
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

        DsFrmRepCusState1.LOGO.Clear()
        Dim OleDbReaderForCompany As System.Data.OleDb.OleDbDataReader
        OleDbReaderForCompany = RetrieveCompanySetupTable()

        Try
            DsFrmRepCusState1.LOGO.AddLOGORow(OleDbReaderForCompany.Item("LOGO"), "l")
        Catch ex As Exception
            MsgBox("2-" & ex.Message)
        End Try

        rpt.SetParameterValue("Parcowebsite", OleDbReaderForCompany.Item("WEBPAGE"))

        OleDbReaderForStore = RetrieveAccountsReceivableSetupTable()

        rpt.SetParameterValue("Parannual", OleDbReaderForStore.Item("Default_annual_finance_charge") & "%")

        rpt.SetParameterValue("pardate", CalendarCombo1.Text)
        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
        rpt.SetParameterValue("parkindrep", "STATEMENT")
        rpt.SetParameterValue("parcomment", BtnComment.ZCommentText)
        rpt.SetDataSource(DsFrmRepCusStateTotal1)
        prn.CrViewer.ReportSource = rpt
        LblStore.Text = " Wait ..."
        prn.ShowDialog()
        LblStore.Text = ""
    End Sub

    Sub MergeDsCustomerName(ByRef Dest As DSFrmRepCusStateTotal, ByRef Source As DSFrmRepCusStateTotal)
        Dim i As Integer
        For i = 0 To Source.CustomersName.Rows.Count - 1
            With Source.CustomersName.Rows(i)
                Dim dr As DSFrmRepCusStateTotal.CustomersNameRow = Dest.CustomersName.FindBycod_customer(.Item("Cod_customer"))
                If dr Is Nothing Then
                    Dim dr1 As DSFrmRepCusStateTotal.CustomersNameRow = DsFrmRepCusStateTotal1.CustomersName.NewCustomersNameRow
                    dr1.cod_customer = .Item("cod_customer") & ""
                    dr1.name = .Item("name") & ""
                    dr1.address = .Item("address") & ""
                    dr1.phone_1 = .Item("phone_1") & ""
                    dr1.complete_name = .Item("complete_name") & ""
                    dr1.cod_class = .Item("cod_class") & ""
                    dr1.cod_type = .Item("cod_type") & ""
                    dr1.OrderName = .Item("OrderName") & ""
                    dr1.StoreCode = .Item("StoreCode") & ""
                    dr1.StoreName = .Item("StoreName") & ""
                    dr1.AR_statement = .Item("AR_Statement") & ""
                    dr1.PrintStatementDetailFlag = .Item("PrintStatementDetailFlag")
                    dr1.c1 = 0 ' Val(.Item("c1"))
                    dr1.c2 = 0 '.Item("c2")
                    dr1.c3 = 0 '.Item("c3")
                    dr1.c4 = 0 '.Item("c4")
                    dr1.c5 = 0 '.Item("c5")
                    DsFrmRepCusStateTotal1.CustomersName.AddCustomersNameRow(dr1)
                Else
                    'dr.c1 = .Item("c1")
                    'dr.c2 = .Item("c2")
                    'dr.c3 = .Item("c3")
                    'dr.c4 = .Item("c4")
                    'dr.c5 = .Item("c5")
                End If
            End With

        Next
    End Sub
    Sub ExecuteReport()
        BtnCancel.Enabled = False
        BtnPriv.Enabled = False
        BtnPrint.Enabled = False
        'DsFrmRepCusStateTotal1.Clear()
        DsFrmRepCusStateTotal1.TblReportSum.Clear()
        DsFrmRepCusStateTotal1.TblReportSumDtl.Clear()
        DsFrmRepCusStateTotal1.CustomersName.Clear()
        DsFrmRepCusStateTotal1.SP_CustomerBalance.Clear()
        DsFrmRepCusStateTotal1.SP_CustomerAgingNotDueYet.Clear()
        DsFrmRepCusStateTotal1.SP_CustomerAging1to30.Clear()
        DsFrmRepCusStateTotal1.SP_CustomerAging31to60.Clear()
        DsFrmRepCusStateTotal1.SP_CustomerAging61to90.Clear()
        DsFrmRepCusStateTotal1.SP_CustomerAgingOver90.Clear()

        ''Label6.Text = "1"
        Call CreateBalanceForAllStore()

        If ChkMultistore.Checked = True Then
            ''  Label6.Text = "5"
            If CmdSTORE_SETUP.Connection.State = ConnectionState.Closed Then
                CmdSTORE_SETUP.Connection.Open()
            End If
            Dim SQLReader As System.Data.OleDb.OleDbDataReader
            SQLReader = CmdSTORE_SETUP.ExecuteReader
            If SQLReader.HasRows Then
                Do While SQLReader.Read()
                    Cnn.ConnectionString = MakeConnectionSqlForThisStore(SQLReader("STORENO"))
                    If Cnn.ConnectionString.Trim <> "" Then
                        If ChkUnpaid.Checked Then
                            'Call FillDatasetUnPaid(SQLReader("SHORTNAME"))
                            'MsgBox("Not Yet")
                        Else
                            LblStore.Text = SQLReader("SHORTNAME")
                            Call CalculateAll(SQLReader("Storeno"), SQLReader("SHORTNAME"))
                        End If
                    End If
                Loop
                CmdSTORE_SETUP.Connection.Close()
                ''Label6.Text = "6"
                Call DeleteCust()
                ''Label6.Text = "7"
                Call preview()
            End If
        Else
            '  If ChkUnpaid.Checked Then
            'Call FillDatasetUnPaid(SQLReader("SHORTNAME"))
            '    MsgBox("Under Construct")
            ' Else
            storename = PubStoreName
            storeCod = PubStoreNO
            LblStore.Text = storename
            ''Label6.Text = "a61"
            Call CalculateAll(storeCod, storename)
            ''Label6.Text = "62"
            Call DeleteCust()
            ''Label6.Text = "63"
            Call preview()
            'End If
        End If
        If ChkEmail.Checked = True Then
            Dim MyClassWhatDo As New ClassWhatDo
            MyClassWhatDo.ShowMsg("Do you Like to Email statement to All  selected Customer with exsisting email ? ")
            If MyClassWhatDo.Result = DialogResult.OK Then
                ''  Label6.Text = "7"
                Call emailall()
            End If
        End If
        LblStore.Text = ""
        BtnCancel.Enabled = True
        BtnPriv.Enabled = True
        BtnPrint.Enabled = True
    End Sub

    Sub CreateBalanceForAllStore()
        ''Label6.Text = "2"

        DsFrmRepCusStateTotal1.SP_CustomerBalance.Clear()
        Dim dstmp As New DSFrmRepCusStateTotal
        If ChkMultistore.Checked = True Then
            ''  Label6.Text = "21"
            If CmdSTORE_SETUP1.Connection.State = ConnectionState.Closed Then
                CmdSTORE_SETUP1.Connection.Open()
            End If
            Dim SQLReader As System.Data.OleDb.OleDbDataReader
            SQLReader = CmdSTORE_SETUP1.ExecuteReader
            If SQLReader.HasRows Then
                Do While SQLReader.Read()
                    Cnn1.ConnectionString = MakeConnectionSqlForThisStore(SQLReader("STORENO"))
                    If Cnn1.ConnectionString.Trim <> "" Then
                        dstmp.Clear()
                        DaSP_CustomerBalance.SelectCommand.Connection = Cnn1
                        DaSP_CustomerBalance.SelectCommand.Parameters("@ThisDate").Value = TxtToDate.Text
                        DaSP_CustomerBalance.SelectCommand.Parameters("@Todate").Value = TxtToDate.Text
                        DaSP_CustomerBalance.SelectCommand.Parameters("@storecode").Value = SQLReader("STORENO")
                        DaSP_CustomerBalance.SelectCommand.Parameters("@storename").Value = SQLReader("SHORTNAME")
                        DaSP_CustomerBalance.SelectCommand.Parameters("@descript").Value = "Balance Up To This Date"
                        DaSP_CustomerBalance.Fill(dstmp.SP_CustomerBalance)
                        Call mergecustomerbalance(DsFrmRepCusStateTotal1, dstmp)
                    End If
                Loop
                CmdSTORE_SETUP1.Connection.Close()
            End If
        Else
            ''Label6.Text = "22"
            Try
                DaSP_CustomerBalance.SelectCommand.Connection.ConnectionString = PConnectionString
                DaSP_CustomerBalance.SelectCommand.Parameters("@ThisDate").Value = TxtToDate.Text
                DaSP_CustomerBalance.SelectCommand.Parameters("@Todate").Value = TxtToDate.Text
                DaSP_CustomerBalance.SelectCommand.Parameters("@storecode").Value = PubStoreNO
                DaSP_CustomerBalance.SelectCommand.Parameters("@storename").Value = PubStoreName
                DaSP_CustomerBalance.SelectCommand.Parameters("@descript").Value = "Balance Up To This Date"
                DaSP_CustomerBalance.SelectCommand.CommandTimeout = 30
                DaSP_CustomerBalance.Fill(DsFrmRepCusStateTotal1.SP_CustomerBalance)
            Catch ex As Exception
                MsgBox("4-" & ex.ToString)
            End Try
        End If

    End Sub
    Sub mergecustomerbalance(ByVal dsdestination As DSFrmRepCusStateTotal, ByVal dsfrom As DSFrmRepCusStateTotal)
        Dim i As Integer = 0
        For i = 0 To dsfrom.SP_CustomerBalance.Rows.Count - 1
            Dim cust As String = dsfrom.SP_CustomerBalance.Rows(i).Item("cod_customer") & ""
            Dim dr1 As DSFrmRepCusStateTotal.SP_CustomerBalanceRow = dsdestination.SP_CustomerBalance.FindBycod_customer(cust)
            If dr1 Is Nothing Then
                Dim dr2 As DSFrmRepCusStateTotal.SP_CustomerBalanceRow = DsFrmRepCusStateTotal1.SP_CustomerBalance.NewSP_CustomerBalanceRow
                dr2.cod_customer = cust
                dr2.BalanceAmount = Val(dr2.Item("BalanceAmount") & "") + Val(dsfrom.SP_CustomerBalance.Rows(i).Item("BalanceAmount") & "")
                DsFrmRepCusStateTotal1.SP_CustomerBalance.AddSP_CustomerBalanceRow(dr2)
            Else
                dr1("BalanceAmount") = dr1("BalanceAmount") + Val(dsfrom.SP_CustomerBalance.Rows(i).Item("BalanceAmount") & "")
            End If
        Next
    End Sub
    Sub deletecust1()
        Dim j As Int64 = 0
        For j = 0 To DsFrmRepCusStateTotal1.SP_CustomerBalance.Rows.Count - 1
            If DsFrmRepCusStateTotal1.SP_CustomerBalance.Rows(j).Item("BalanceAmount") = 0 Then
                Dim dr1 As DSFrmRepCusStateTotal.CustomersNameRow = DsFrmRepCusStateTotal1.CustomersName.FindBycod_customer(DsFrmRepCusStateTotal1.SP_CustomerBalance.Rows(j).Item("cod_customer") & "")
                If dr1 Is Nothing Then
                    MsgBox("error")
                Else
                    ' If Val(dr1.Item("BalanceAmount")) = 0 Then
                    dr1.Delete()
                    'End If
                End If
            End If
        Next
        DsFrmRepCusStateTotal1.AcceptChanges()
    End Sub
    Sub DeleteCust()
        Dim j As Int64 = 0
        If ChkZeroBalance.Checked Then
            For j = 0 To DsFrmRepCusStateTotal1.CustomersName.Rows.Count - 1
                Try
                    If DsFrmRepCusStateTotal1.CustomersName.Rows(j).RowState <> DataRowState.Deleted Then

                        Dim dr1 As DSFrmRepCusStateTotal.SP_CustomerBalanceRow = DsFrmRepCusStateTotal1.SP_CustomerBalance.FindBycod_customer(DsFrmRepCusStateTotal1.CustomersName.Rows(j).Item("cod_customer") & "")
                        Dim dr2() As DataRow = DsFrmRepCusStateTotal1.TblReportSum.Select("cod_customer =" & Qt(DsFrmRepCusStateTotal1.CustomersName.Rows(j).Item("cod_customer")))
                        'If dr1 Is Nothing And dr2.Length >= 1 Then
                        '    MsgBox("")
                        'End If
                        If Trim(DsFrmRepCusStateTotal1.CustomersName.Rows(j).Item("cod_customer") & "") = "AIRTRA" Then
                            '   MsgBox("")
                        End If
                        If dr1 Is Nothing And dr2.Length = 0 Then
                            DsFrmRepCusStateTotal1.CustomersName(j).flagcus = False
                            'DsFrmRepCusStateTotal1.CustomersName.Rows(j).Delete()
                        Else
                            If dr1 Is Nothing Then
                                DsFrmRepCusStateTotal1.CustomersName(j).flagcus = False
                            Else
                                If Val("0" & dr1.Item("BalanceAmount")) = 0 Then
                                    DsFrmRepCusStateTotal1.CustomersName(j).flagcus = False
                                End If
                            End If
                        End If
                    End If
                Catch ex As Exception
                    ' MsgBox(ex.ToString)
                End Try
            Next
            DsFrmRepCusStateTotal1.AcceptChanges()
        End If
    End Sub
    Sub emailall()
        Dim j As Integer
        Dim CodCustomer As String = ""
        If ChkEmail.Checked = True Then
            For j = 0 To DsFrmRepCusStateTotal1.CustomersName.Rows.Count - 1
                If DsFrmRepCusStateTotal1.CustomersName(j).flagcus = True Then
                    CodCustomer = DsFrmRepCusStateTotal1.CustomersName(j).cod_customer
                    Dim rpt As New RepCusStateSummary
                    Dim prn As New FrmRepView
                    Dim Ds1 As New DataSet
                    FndCustomerData.SelectCommand.Parameters(0).Value = CodCustomer
                    FndCustomerData.Fill(Ds1, "t1")
                    If Ds1.Tables("t1").Rows(0).Item("email") & "" <> "" Then
                        DsFrmRepCusStateTotal1.CustomersName(j).flagemail = True
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

                        DsFrmRepCusState1.LOGO.Clear()
                        Dim OleDbReaderForCompany As System.Data.OleDb.OleDbDataReader
                        OleDbReaderForCompany = RetrieveCompanySetupTable()

                        Try
                            DsFrmRepCusState1.LOGO.AddLOGORow(OleDbReaderForCompany.Item("LOGO"), "l")
                        Catch ex As Exception
                            MsgBox("5-" & ex.Message)
                        End Try

                        rpt.SetParameterValue("Parcowebsite", OleDbReaderForCompany.Item("WEBPAGE"))

                        OleDbReaderForStore = RetrieveAccountsReceivableSetupTable()

                        rpt.SetParameterValue("Parannual", OleDbReaderForStore.Item("Default_annual_finance_charge") & "%")

                        rpt.SetParameterValue("pardate", CalendarCombo1.Text)
                        rpt.SetParameterValue("partime", Format(Now(), "Short Time"))
                        rpt.SetParameterValue("parkindrep", "STATEMENT")
                        rpt.SetParameterValue("parcomment", BtnComment.ZCommentText)
                        rpt.SetDataSource(DsFrmRepCusStateTotal1)
                        rpt.RecordSelectionFormula = "{CustomersName.flagcus} AND {CustomersName.flagemail}"
                        prn.CrViewer.ReportSource = rpt
                        rpt.ExportToDisk(CrystalDecisions.[Shared].ExportFormatType.WordForWindows, "c:\" & CodCustomer.Trim & ".Doc")
                        Call SendMail("c:\" & CodCustomer.Trim & ".Doc", Ds1.Tables("t1").Rows(0).Item("email") & "", " Statement Rport ", " Hi this is  report statment for test by kamran faraji")
                        DsFrmRepCusStateTotal1.CustomersName(j).flagemail = False
                    End If
                End If

            Next
        End If
    End Sub

    Private Sub SendMail(ByVal AttachmentName As String, ByVal CustomrEmail As String, ByVal Subject As String, ByVal body As String)
        Dim OleDbReader As System.Data.OleDb.OleDbDataReader
        OleDbReader = RetrieveCompanySetupTable()
        'OleDbReader = RetrieveStoreSetupTable(PubStoreNO)
        Dim StoreEmailAddressVar As String = OleDbReader.Item("EMAIL") & ""
        OleDbReader.Close()
        If StoreEmailAddressVar.Trim.Length = 0 Then
            Exit Sub
        End If

        Dim mail As System.Web.Mail.MailMessage = New System.Web.Mail.MailMessage
        mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1")
        mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "invoice@tiremate.net")
        mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "invoice")
        mail.To = "behboy1@yahoo.com;ketabie@yahoo.com;kamranfaraji@gmail.com"    'CustomrEmail ' MyFrmSendMailInformation.txtTo.Text '"ketabie@yahoo.com;kamran_faraji@yahoo.com;mhz_home@yahoo.com"
        mail.From = StoreEmailAddressVar
        mail.Subject = Subject
        mail.Body = body
        mail.Attachments.Add(New System.Web.Mail.MailAttachment(AttachmentName))
        System.Web.Mail.SmtpMail.SmtpServer = "smtp.1and1.com"
        'TODO Try-Catch for exception
        Try
            System.Web.Mail.SmtpMail.Send(mail)
            ' MsgBox("Job SuccessFully Performed", MsgBoxStyle.Information)
        Catch ex As Exception
            'MsgBox("Please connect to internet and try again", MsgBoxStyle.Exclamation)

        End Try
    End Sub

    Private Sub RdoSelectedClass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoSelectedClass.CheckedChanged

    End Sub
End Class

