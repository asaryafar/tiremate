Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmCustomerBalance
    Inherits FrmBase
    Dim PanelGridHeightVar As Integer
    Dim PanelColorHeightVar As Integer
    Dim FormHeightVar As Integer
    Public Cod_customerParameter As String
    Dim FlagMultiStore As Boolean = False
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
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnDetail As System.Windows.Forms.Button
    Friend WithEvents PanelGrid As System.Windows.Forms.Panel
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Public WithEvents LblCustomer As System.Windows.Forms.TextBox
    Public WithEvents LblCompany As System.Windows.Forms.TextBox
    Public WithEvents LblName As System.Windows.Forms.TextBox
    Friend WithEvents DAService_center_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmCustomerBalance1 As UCCustomer.DSFrmCustomerBalance
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents LblNotDueYet As CalcUtils.UcCalcText
    Friend WithEvents LblUpto60Days As CalcUtils.UcCalcText
    Friend WithEvents LblOver90Days As CalcUtils.UcCalcText
    Friend WithEvents LblUpto90Days As CalcUtils.UcCalcText
    Friend WithEvents LblUpto30Days As CalcUtils.UcCalcText
    Friend WithEvents LblBalance As CalcUtils.UcCalcText
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_payment_deposit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_account_adjustment_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LblPayment As CalcUtils.UcCalcText
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LblOriginalAmount As CalcUtils.UcCalcText
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LblTotalAmountDue As System.Windows.Forms.Label
    Friend WithEvents LblTotalOriginalAmount As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PanelColors As System.Windows.Forms.Panel
    Friend WithEvents BtnMultiStore As System.Windows.Forms.Button
    Friend WithEvents DASTORE_SETUP As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents CnnMdbSetup As System.Data.OleDb.OleDbConnection
    Friend WithEvents CmdSP_CustomerAging1to30 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdSP_CustomerAging31to60 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdSP_CustomerAging61to90 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdSP_CustomerAgingOver90 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAReturnWithoutPayment As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_payment_depositFromOtherStore As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents LblReturns As CalcUtils.UcCalcText
    Friend WithEvents LblOPBalance As CalcUtils.UcCalcText
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents DAService_center_dtlOld As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdSP_CustomerAgingNotDueYetOld As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdSP_CustomerAgingNotDueYet As System.Data.SqlClient.SqlCommand
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LblDPBalance As CalcUtils.UcCalcText
    Friend WithEvents Label29 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCustomerBalance))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.LblCustomer = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.LblDPBalance = New CalcUtils.UcCalcText
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.LblReturns = New CalcUtils.UcCalcText
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.LblOPBalance = New CalcUtils.UcCalcText
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.LblPayment = New CalcUtils.UcCalcText
        Me.Label11 = New System.Windows.Forms.Label
        Me.LblOriginalAmount = New CalcUtils.UcCalcText
        Me.Label10 = New System.Windows.Forms.Label
        Me.LblBalance = New CalcUtils.UcCalcText
        Me.LblCompany = New System.Windows.Forms.TextBox
        Me.LblName = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.BtnDetail = New System.Windows.Forms.Button
        Me.Label33 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.LblUpto30Days = New CalcUtils.UcCalcText
        Me.LblUpto90Days = New CalcUtils.UcCalcText
        Me.LblOver90Days = New CalcUtils.UcCalcText
        Me.LblUpto60Days = New CalcUtils.UcCalcText
        Me.LblNotDueYet = New CalcUtils.UcCalcText
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.PanelGrid = New System.Windows.Forms.Panel
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DsFrmCustomerBalance1 = New UCCustomer.DSFrmCustomerBalance
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LblTotalAmountDue = New System.Windows.Forms.Label
        Me.LblTotalOriginalAmount = New System.Windows.Forms.Label
        Me.DAService_center_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.DAGL_payment_deposit = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_account_adjustment_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.PanelColors = New System.Windows.Forms.Panel
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.BtnMultiStore = New System.Windows.Forms.Button
        Me.DASTORE_SETUP = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand
        Me.CnnMdbSetup = New System.Data.OleDb.OleDbConnection
        Me.CmdSP_CustomerAgingNotDueYetOld = New System.Data.SqlClient.SqlCommand
        Me.CmdSP_CustomerAging1to30 = New System.Data.SqlClient.SqlCommand
        Me.CmdSP_CustomerAging31to60 = New System.Data.SqlClient.SqlCommand
        Me.CmdSP_CustomerAging61to90 = New System.Data.SqlClient.SqlCommand
        Me.CmdSP_CustomerAgingOver90 = New System.Data.SqlClient.SqlCommand
        Me.DAReturnWithoutPayment = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_payment_depositFromOtherStore = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAService_center_dtlOld = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand
        Me.CmdSP_CustomerAgingNotDueYet = New System.Data.SqlClient.SqlCommand
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelGrid.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmCustomerBalance1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.PanelColors.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=Tiremate_01"
        '
        'LblCustomer
        '
        Me.LblCustomer.BackColor = System.Drawing.Color.Gold
        Me.LblCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblCustomer.Location = New System.Drawing.Point(71, 3)
        Me.LblCustomer.Name = "LblCustomer"
        Me.LblCustomer.ReadOnly = True
        Me.LblCustomer.Size = New System.Drawing.Size(89, 20)
        Me.LblCustomer.TabIndex = 420
        Me.LblCustomer.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(170, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 22)
        Me.Label3.TabIndex = 338
        Me.Label3.Text = "Company"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(167, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 22)
        Me.Label2.TabIndex = 336
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(-4, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 22)
        Me.Label1.TabIndex = 334
        Me.Label1.Text = "Balance"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(5, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 22)
        Me.Label5.TabIndex = 332
        Me.Label5.Text = "Customer"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.LblReturns)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.LblOPBalance)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.LblPayment)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.LblOriginalAmount)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.LblBalance)
        Me.Panel1.Controls.Add(Me.LblCompany)
        Me.Panel1.Controls.Add(Me.LblName)
        Me.Panel1.Controls.Add(Me.LblCustomer)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(3, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(529, 96)
        Me.Panel1.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.LblDPBalance)
        Me.Panel4.Controls.Add(Me.Label29)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel4.ForeColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(344, 69)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(184, 29)
        Me.Panel4.TabIndex = 472
        '
        'LblDPBalance
        '
        Me.LblDPBalance.BackColor = System.Drawing.Color.Gold
        Me.LblDPBalance.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblDPBalance.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblDPBalance.DecimalDigits = 2
        Me.LblDPBalance.DefaultSendValue = False
        Me.LblDPBalance.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblDPBalance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblDPBalance.Image = CType(resources.GetObject("LblDPBalance.Image"), System.Drawing.Image)
        Me.LblDPBalance.Location = New System.Drawing.Point(75, 1)
        Me.LblDPBalance.Maxlength = 12
        Me.LblDPBalance.MinusColor = System.Drawing.Color.Empty
        Me.LblDPBalance.Name = "LblDPBalance"
        Me.LblDPBalance.ReadOnly = True
        Me.LblDPBalance.Size = New System.Drawing.Size(89, 21)
        Me.LblDPBalance.TabIndex = 468
        Me.LblDPBalance.TabStop = False
        Me.LblDPBalance.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblDPBalance.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(3, 1)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(69, 22)
        Me.Label29.TabIndex = 467
        Me.Label29.Text = "DP Balance"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(504, 43)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(14, 22)
        Me.Label24.TabIndex = 471
        Me.Label24.Text = "-"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblReturns
        '
        Me.LblReturns.BackColor = System.Drawing.Color.Gold
        Me.LblReturns.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblReturns.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblReturns.DecimalDigits = 2
        Me.LblReturns.DefaultSendValue = False
        Me.LblReturns.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblReturns.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblReturns.Image = CType(resources.GetObject("LblReturns.Image"), System.Drawing.Image)
        Me.LblReturns.Location = New System.Drawing.Point(56, 71)
        Me.LblReturns.Maxlength = 12
        Me.LblReturns.MinusColor = System.Drawing.Color.Empty
        Me.LblReturns.Name = "LblReturns"
        Me.LblReturns.ReadOnly = True
        Me.LblReturns.Size = New System.Drawing.Size(89, 21)
        Me.LblReturns.TabIndex = 470
        Me.LblReturns.TabStop = False
        Me.LblReturns.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblReturns.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(6, 69)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(47, 22)
        Me.Label23.TabIndex = 469
        Me.Label23.Text = "Returns"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(152, 71)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(14, 22)
        Me.Label22.TabIndex = 468
        Me.Label22.Text = "-"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblOPBalance
        '
        Me.LblOPBalance.BackColor = System.Drawing.Color.Gold
        Me.LblOPBalance.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblOPBalance.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblOPBalance.DecimalDigits = 2
        Me.LblOPBalance.DefaultSendValue = False
        Me.LblOPBalance.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblOPBalance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblOPBalance.Image = CType(resources.GetObject("LblOPBalance.Image"), System.Drawing.Image)
        Me.LblOPBalance.Location = New System.Drawing.Point(242, 71)
        Me.LblOPBalance.Maxlength = 12
        Me.LblOPBalance.MinusColor = System.Drawing.Color.Empty
        Me.LblOPBalance.Name = "LblOPBalance"
        Me.LblOPBalance.ReadOnly = True
        Me.LblOPBalance.Size = New System.Drawing.Size(89, 21)
        Me.LblOPBalance.TabIndex = 464
        Me.LblOPBalance.TabStop = False
        Me.LblOPBalance.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblOPBalance.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(171, 69)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(68, 22)
        Me.Label27.TabIndex = 463
        Me.Label27.Text = "OP Balance"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(164, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 22)
        Me.Label12.TabIndex = 461
        Me.Label12.Text = "="
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPayment
        '
        Me.LblPayment.BackColor = System.Drawing.Color.Gold
        Me.LblPayment.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblPayment.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblPayment.DecimalDigits = 2
        Me.LblPayment.DefaultSendValue = False
        Me.LblPayment.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblPayment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblPayment.Image = CType(resources.GetObject("LblPayment.Image"), System.Drawing.Image)
        Me.LblPayment.Location = New System.Drawing.Point(404, 47)
        Me.LblPayment.Maxlength = 12
        Me.LblPayment.MinusColor = System.Drawing.Color.Empty
        Me.LblPayment.Name = "LblPayment"
        Me.LblPayment.ReadOnly = True
        Me.LblPayment.Size = New System.Drawing.Size(89, 21)
        Me.LblPayment.TabIndex = 460
        Me.LblPayment.TabStop = False
        Me.LblPayment.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblPayment.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(360, 45)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 22)
        Me.Label11.TabIndex = 459
        Me.Label11.Text = "Credits"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblOriginalAmount
        '
        Me.LblOriginalAmount.BackColor = System.Drawing.Color.Gold
        Me.LblOriginalAmount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblOriginalAmount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblOriginalAmount.DecimalDigits = 2
        Me.LblOriginalAmount.DefaultSendValue = False
        Me.LblOriginalAmount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblOriginalAmount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblOriginalAmount.Image = CType(resources.GetObject("LblOriginalAmount.Image"), System.Drawing.Image)
        Me.LblOriginalAmount.Location = New System.Drawing.Point(239, 47)
        Me.LblOriginalAmount.Maxlength = 12
        Me.LblOriginalAmount.MinusColor = System.Drawing.Color.Empty
        Me.LblOriginalAmount.Name = "LblOriginalAmount"
        Me.LblOriginalAmount.ReadOnly = True
        Me.LblOriginalAmount.Size = New System.Drawing.Size(89, 21)
        Me.LblOriginalAmount.TabIndex = 458
        Me.LblOriginalAmount.TabStop = False
        Me.LblOriginalAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblOriginalAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(170, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 22)
        Me.Label10.TabIndex = 457
        Me.Label10.Text = "Charges"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblBalance
        '
        Me.LblBalance.BackColor = System.Drawing.Color.Gold
        Me.LblBalance.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblBalance.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblBalance.DecimalDigits = 2
        Me.LblBalance.DefaultSendValue = False
        Me.LblBalance.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblBalance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblBalance.Image = CType(resources.GetObject("LblBalance.Image"), System.Drawing.Image)
        Me.LblBalance.Location = New System.Drawing.Point(65, 46)
        Me.LblBalance.Maxlength = 12
        Me.LblBalance.MinusColor = System.Drawing.Color.Empty
        Me.LblBalance.Name = "LblBalance"
        Me.LblBalance.ReadOnly = True
        Me.LblBalance.Size = New System.Drawing.Size(89, 21)
        Me.LblBalance.TabIndex = 456
        Me.LblBalance.TabStop = False
        Me.LblBalance.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblBalance.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblCompany
        '
        Me.LblCompany.BackColor = System.Drawing.Color.Gold
        Me.LblCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblCompany.Location = New System.Drawing.Point(230, 23)
        Me.LblCompany.Name = "LblCompany"
        Me.LblCompany.ReadOnly = True
        Me.LblCompany.Size = New System.Drawing.Size(291, 20)
        Me.LblCompany.TabIndex = 423
        Me.LblCompany.Text = ""
        '
        'LblName
        '
        Me.LblName.BackColor = System.Drawing.Color.Gold
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblName.Location = New System.Drawing.Point(230, 3)
        Me.LblName.Name = "LblName"
        Me.LblName.ReadOnly = True
        Me.LblName.Size = New System.Drawing.Size(291, 20)
        Me.LblName.TabIndex = 422
        Me.LblName.Text = ""
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(335, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 22)
        Me.Label13.TabIndex = 462
        Me.Label13.Text = "-"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnDetail
        '
        Me.BtnDetail.BackColor = System.Drawing.SystemColors.Control
        Me.BtnDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDetail.Image = CType(resources.GetObject("BtnDetail.Image"), System.Drawing.Image)
        Me.BtnDetail.Location = New System.Drawing.Point(575, 100)
        Me.BtnDetail.Name = "BtnDetail"
        Me.BtnDetail.Size = New System.Drawing.Size(23, 23)
        Me.BtnDetail.TabIndex = 444
        Me.BtnDetail.TabStop = False
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Location = New System.Drawing.Point(568, 127)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(38, 12)
        Me.Label33.TabIndex = 445
        Me.Label33.Text = "Detail"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.LblUpto30Days)
        Me.Panel2.Controls.Add(Me.LblUpto90Days)
        Me.Panel2.Controls.Add(Me.LblOver90Days)
        Me.Panel2.Controls.Add(Me.LblUpto60Days)
        Me.Panel2.Controls.Add(Me.LblNotDueYet)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(3, 102)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(529, 47)
        Me.Panel2.TabIndex = 446
        '
        'LblUpto30Days
        '
        Me.LblUpto30Days.BackColor = System.Drawing.Color.Gold
        Me.LblUpto30Days.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblUpto30Days.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblUpto30Days.DecimalDigits = 2
        Me.LblUpto30Days.DefaultSendValue = False
        Me.LblUpto30Days.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblUpto30Days.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblUpto30Days.Image = CType(resources.GetObject("LblUpto30Days.Image"), System.Drawing.Image)
        Me.LblUpto30Days.Location = New System.Drawing.Point(119, 22)
        Me.LblUpto30Days.Maxlength = 12
        Me.LblUpto30Days.MinusColor = System.Drawing.Color.Empty
        Me.LblUpto30Days.Name = "LblUpto30Days"
        Me.LblUpto30Days.ReadOnly = True
        Me.LblUpto30Days.Size = New System.Drawing.Size(89, 21)
        Me.LblUpto30Days.TabIndex = 455
        Me.LblUpto30Days.TabStop = False
        Me.LblUpto30Days.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblUpto30Days.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblUpto90Days
        '
        Me.LblUpto90Days.BackColor = System.Drawing.Color.Gold
        Me.LblUpto90Days.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblUpto90Days.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblUpto90Days.DecimalDigits = 2
        Me.LblUpto90Days.DefaultSendValue = False
        Me.LblUpto90Days.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblUpto90Days.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblUpto90Days.Image = CType(resources.GetObject("LblUpto90Days.Image"), System.Drawing.Image)
        Me.LblUpto90Days.Location = New System.Drawing.Point(325, 22)
        Me.LblUpto90Days.Maxlength = 12
        Me.LblUpto90Days.MinusColor = System.Drawing.Color.Empty
        Me.LblUpto90Days.Name = "LblUpto90Days"
        Me.LblUpto90Days.ReadOnly = True
        Me.LblUpto90Days.Size = New System.Drawing.Size(89, 21)
        Me.LblUpto90Days.TabIndex = 454
        Me.LblUpto90Days.TabStop = False
        Me.LblUpto90Days.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblUpto90Days.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblOver90Days
        '
        Me.LblOver90Days.BackColor = System.Drawing.Color.Gold
        Me.LblOver90Days.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblOver90Days.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblOver90Days.DecimalDigits = 2
        Me.LblOver90Days.DefaultSendValue = False
        Me.LblOver90Days.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblOver90Days.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblOver90Days.Image = CType(resources.GetObject("LblOver90Days.Image"), System.Drawing.Image)
        Me.LblOver90Days.Location = New System.Drawing.Point(428, 22)
        Me.LblOver90Days.Maxlength = 12
        Me.LblOver90Days.MinusColor = System.Drawing.Color.Empty
        Me.LblOver90Days.Name = "LblOver90Days"
        Me.LblOver90Days.ReadOnly = True
        Me.LblOver90Days.Size = New System.Drawing.Size(89, 21)
        Me.LblOver90Days.TabIndex = 453
        Me.LblOver90Days.TabStop = False
        Me.LblOver90Days.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblOver90Days.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblUpto60Days
        '
        Me.LblUpto60Days.BackColor = System.Drawing.Color.Gold
        Me.LblUpto60Days.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblUpto60Days.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblUpto60Days.DecimalDigits = 2
        Me.LblUpto60Days.DefaultSendValue = False
        Me.LblUpto60Days.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblUpto60Days.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblUpto60Days.Image = CType(resources.GetObject("LblUpto60Days.Image"), System.Drawing.Image)
        Me.LblUpto60Days.Location = New System.Drawing.Point(222, 22)
        Me.LblUpto60Days.Maxlength = 12
        Me.LblUpto60Days.MinusColor = System.Drawing.Color.Empty
        Me.LblUpto60Days.Name = "LblUpto60Days"
        Me.LblUpto60Days.ReadOnly = True
        Me.LblUpto60Days.Size = New System.Drawing.Size(89, 21)
        Me.LblUpto60Days.TabIndex = 452
        Me.LblUpto60Days.TabStop = False
        Me.LblUpto60Days.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblUpto60Days.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblNotDueYet
        '
        Me.LblNotDueYet.BackColor = System.Drawing.Color.Gold
        Me.LblNotDueYet.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblNotDueYet.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblNotDueYet.DecimalDigits = 2
        Me.LblNotDueYet.DefaultSendValue = False
        Me.LblNotDueYet.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblNotDueYet.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblNotDueYet.Image = CType(resources.GetObject("LblNotDueYet.Image"), System.Drawing.Image)
        Me.LblNotDueYet.Location = New System.Drawing.Point(16, 22)
        Me.LblNotDueYet.Maxlength = 12
        Me.LblNotDueYet.MinusColor = System.Drawing.Color.Empty
        Me.LblNotDueYet.Name = "LblNotDueYet"
        Me.LblNotDueYet.ReadOnly = True
        Me.LblNotDueYet.Size = New System.Drawing.Size(89, 21)
        Me.LblNotDueYet.TabIndex = 451
        Me.LblNotDueYet.TabStop = False
        Me.LblNotDueYet.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblNotDueYet.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(425, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 22)
        Me.Label9.TabIndex = 427
        Me.Label9.Text = "Over 90 Days"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(322, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 22)
        Me.Label7.TabIndex = 425
        Me.Label7.Text = "61 - 90 Days"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(219, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 22)
        Me.Label6.TabIndex = 423
        Me.Label6.Text = "31 - 60 Days"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(116, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 22)
        Me.Label4.TabIndex = 421
        Me.Label4.Text = "1 - 30 Days"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(13, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 22)
        Me.Label8.TabIndex = 332
        Me.Label8.Text = "Not Due Yet"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelGrid
        '
        Me.PanelGrid.Controls.Add(Me.GrdDetail)
        Me.PanelGrid.Controls.Add(Me.Panel3)
        Me.PanelGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelGrid.Location = New System.Drawing.Point(0, 150)
        Me.PanelGrid.Name = "PanelGrid"
        Me.PanelGrid.Size = New System.Drawing.Size(642, 263)
        Me.PanelGrid.TabIndex = 449
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowColumnDrag = False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BackColor = System.Drawing.SystemColors.Control
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "service_center_dtl"
        Me.GrdDetail.DataSource = Me.DsFrmCustomerBalance1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>Invoices</Caption><Columns Collection=""true" & _
        """><Column0 ID=""Date""><Caption>Date</Caption><DataMember>InvoiceDate</DataMember>" & _
        "<EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>Date</Ke" & _
        "y><Position>0</Position><Width>84</Width></Column0><Column1 ID=""InvoiceNo""><Capt" & _
        "ion>Invoice No</Caption><DataMember>InvoiceNo</DataMember><EditType>NoEdit</Edit" & _
        "Type><FilterEditType>TextBox</FilterEditType><Key>InvoiceNo</Key><Position>1</Po" & _
        "sition><Width>84</Width></Column1><Column2 ID=""OriginalAmount""><Caption>Original" & _
        " Amount</Caption><DataMember>OriginalAmount</DataMember><EditType>NoEdit</EditTy" & _
        "pe><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Input" & _
        "Mask>Currency2</InputMask><Key>OriginalAmount</Key><MaskPrompt>&#x0;</MaskPrompt" & _
        "><Position>2</Position><Width>99</Width></Column2><Column3 ID=""AmountDue""><Capti" & _
        "on>Amount Due</Caption><DataMember>AmountDue</DataMember><EditType>NoEdit</EditT" & _
        "ype><FilterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Inpu" & _
        "tMask>Currency2</InputMask><Key>AmountDue</Key><MaskPrompt>&#x0;</MaskPrompt><Po" & _
        "sition>3</Position><Width>97</Width></Column3><Column4 ID=""DueDate""><Caption>Due" & _
        " Date</Caption><DataMember>DueDate</DataMember><EditType>NoEdit</EditType><Filte" & _
        "rEditType>TextBox</FilterEditType><Key>DueDate</Key><Position>4</Position><Width" & _
        ">84</Width></Column4><Column5 ID=""PastDue""><Caption>Past Due</Caption><DataMembe" & _
        "r>PastDue</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filter" & _
        "EditType><Key>PastDue</Key><Position>5</Position><Width>59</Width></Column5><Col" & _
        "umn6 ID=""InvoiceNoForOrder""><Caption>InvoiceNoForOrder</Caption><DataMember>Invo" & _
        "iceNoForOrder</DataMember><Key>InvoiceNoForOrder</Key><Position>6</Position><Vis" & _
        "ible>False</Visible></Column6><Column7 ID=""InvoiceDateYYYYMMDD""><Caption>Invoice" & _
        "DateYYYYMMDD</Caption><DataMember>InvoiceDateYYYYMMDD</DataMember><Key>InvoiceDa" & _
        "teYYYYMMDD</Key><Position>7</Position><Visible>False</Visible></Column7><Column8" & _
        " ID=""DueDateYYYYMMDD""><Caption>DueDateYYYYMMDD</Caption><DataMember>DueDateYYYYM" & _
        "MDD</DataMember><Key>DueDateYYYYMMDD</Key><Position>8</Position><Visible>False</" & _
        "Visible></Column8><Column9 ID=""TypeOfRecord""><Caption>TypeOfRecord</Caption><Dat" & _
        "aMember>TypeOfRecord</DataMember><Key>TypeOfRecord</Key><Position>9</Position><V" & _
        "isible>False</Visible></Column9><Column10 ID=""StoreNo""><Caption>StoreNo</Caption" & _
        "><DataMember>StoreNo</DataMember><EditType>NoEdit</EditType><Key>StoreNo</Key><P" & _
        "osition>10</Position><Visible>False</Visible><Width>108</Width></Column10><Colum" & _
        "n11 ID=""SHORTNAME""><Caption>Store Name</Caption><DataMember>SHORTNAME</DataMembe" & _
        "r><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>SHORTN" & _
        "AME</Key><Position>11</Position><Width>110</Width></Column11></Columns><GroupCon" & _
        "dition ID="""" /><Key>Invoices</Key><SortKeys Collection=""true""><SortKey0 ID=""Sort" & _
        "Key0""><ColIndex>7</ColIndex></SortKey0><SortKey1 ID=""SortKey1""><ColIndex>6</ColI" & _
        "ndex></SortKey1><SortKey2 ID=""SortKey2""><ColIndex>8</ColIndex></SortKey2></SortK" & _
        "eys></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(0, 1)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(642, 262)
        Me.GrdDetail.TabIndex = 449
        '
        'DsFrmCustomerBalance1
        '
        Me.DsFrmCustomerBalance1.DataSetName = "DSFrmCustomerBalance"
        Me.DsFrmCustomerBalance1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.LblTotalAmountDue)
        Me.Panel3.Controls.Add(Me.LblTotalOriginalAmount)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(0, 208)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(581, 58)
        Me.Panel3.TabIndex = 450
        Me.Panel3.Visible = False
        '
        'LblTotalAmountDue
        '
        Me.LblTotalAmountDue.BackColor = System.Drawing.SystemColors.Window
        Me.LblTotalAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotalAmountDue.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblTotalAmountDue.ForeColor = System.Drawing.Color.Black
        Me.LblTotalAmountDue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTotalAmountDue.Location = New System.Drawing.Point(292, -1)
        Me.LblTotalAmountDue.Name = "LblTotalAmountDue"
        Me.LblTotalAmountDue.Size = New System.Drawing.Size(104, 20)
        Me.LblTotalAmountDue.TabIndex = 348
        Me.LblTotalAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTotalOriginalAmount
        '
        Me.LblTotalOriginalAmount.BackColor = System.Drawing.SystemColors.Window
        Me.LblTotalOriginalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotalOriginalAmount.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblTotalOriginalAmount.ForeColor = System.Drawing.Color.Black
        Me.LblTotalOriginalAmount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTotalOriginalAmount.Location = New System.Drawing.Point(188, -1)
        Me.LblTotalOriginalAmount.Name = "LblTotalOriginalAmount"
        Me.LblTotalOriginalAmount.Size = New System.Drawing.Size(106, 20)
        Me.LblTotalOriginalAmount.TabIndex = 347
        Me.LblTotalOriginalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DAService_center_dtl
        '
        Me.DAService_center_dtl.SelectCommand = Me.SqlSelectCommand3
        Me.DAService_center_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("type_select", "type_select"), New System.Data.Common.DataColumnMapping("cod_select", "cod_select"), New System.Data.Common.DataColumnMapping("desc_radif", "desc_radif"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("cod_technician", "cod_technician"), New System.Data.Common.DataColumnMapping("COMMENT_ARTICLE", "COMMENT_ARTICLE")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT DISTINCT service_center_head.id_service_center AS InvoiceNo, service_cente" & _
        "r_head.date_refer AS InvoiceDate, ROUND(GL_payment_deposit.payment_amount, 2) AS" & _
        " OriginalAmount, 0 AS Payment, ISNULL(View_Invoice_Balance_ForEach_ARDue.Balance" & _
        "Amount, 0) AS AmountDue, ROUND(service_center_head.Total, 2) - View_Invoice_Bala" & _
        "nce_ForEach_ARDue.BalanceAmount AS OldPayment, GL_payment_deposit_Due_Date_For_A" & _
        "R.AR_due_date AS DueDate, 0 AS PastDue, ROUND(service_center_head.discount, 2) A" & _
        "S discount, ROUND(service_center_head.tax, 2) AS tax, dbo.ChangeDate(service_cen" & _
        "ter_head.date_refer) AS INVOICEDATEYYYYMMDD, 1 AS type, '1' + service_center_hea" & _
        "d.id_service_center AS InvoiceNoForOrder, ISNULL(GL_payment_deposit_Due_Date_For" & _
        "_AR.ID_payment, 0) AS ID_payment, GL_payment_deposit_Due_Date_For_AR.Cancel_flag" & _
        ", CASE type_of_form WHEN 'IN' THEN 1 WHEN 'RT' THEN 2 ELSE 0 END AS TypeOfRecord" & _
        ", ROUND(GL_payment_deposit.Paid_amount, 2) AS Paid_amount, @StoreNo AS StoreNo, " & _
        "@StoreName AS Shortname FROM service_center_head LEFT OUTER JOIN View_Invoice_Ba" & _
        "lance_ForEach_ARDue RIGHT OUTER JOIN GL_payment_deposit_Due_Date_For_AR INNER JO" & _
        "IN GL_payment_deposit ON GL_payment_deposit_Due_Date_For_AR.ID_payment = GL_paym" & _
        "ent_deposit.ID_payment ON View_Invoice_Balance_ForEach_ARDue.ID_payment = GL_pay" & _
        "ment_deposit.ID_payment ON service_center_head.id_service_center = GL_payment_de" & _
        "posit.id_service_center WHERE (service_center_head.type_of_form = 'IN') AND (ser" & _
        "vice_center_head.cod_customer = @Cod_customer) AND (GL_payment_deposit.refer_typ" & _
        "e = '1')"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreNo", System.Data.SqlDbType.Variant))
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreName", System.Data.SqlDbType.Variant))
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'DAGL_payment_deposit
        '
        Me.DAGL_payment_deposit.SelectCommand = Me.SqlCommand3
        Me.DAGL_payment_deposit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("type_select", "type_select"), New System.Data.Common.DataColumnMapping("cod_select", "cod_select"), New System.Data.Common.DataColumnMapping("desc_radif", "desc_radif"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("cod_technician", "cod_technician"), New System.Data.Common.DataColumnMapping("COMMENT_ARTICLE", "COMMENT_ARTICLE")})})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT GL_payment_deposit.refrence_no AS InvoiceNo, Gl_receive_payment.date_recei" & _
        "ve_payment AS InvoiceDate, 0 AS Payment, 0 AS AmountDue, 0 AS OldPayment, Gl_rec" & _
        "eive_payment.date_receive_payment AS DueDate, 0 AS PastDue, dbo.ChangeDate(Gl_re" & _
        "ceive_payment.date_receive_payment) AS INVOICEDATEYYYYMMDD, 2 AS type, '2' + GL_" & _
        "payment_deposit.id_service_center AS InvoiceNoForOrder, - ROUND(GL_payment_depos" & _
        "it.payment_amount, 2) AS OriginalAmount, 0 AS Cancel_flag, 3 AS TypeOfRecord, 0 " & _
        "AS Paid_amount, @StoreNo AS StoreNo, @StoreName AS Shortname FROM GL_payment_dep" & _
        "osit INNER JOIN Gl_receive_payment ON GL_payment_deposit.refrence_no = Gl_receiv" & _
        "e_payment.refrence_no WHERE (GL_payment_deposit.refer_type = '2') AND (Gl_receiv" & _
        "e_payment.cod_customer = @Cod_customer)"
        Me.SqlCommand3.Connection = Me.Cnn
        Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreNo", System.Data.SqlDbType.Variant))
        Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreName", System.Data.SqlDbType.Variant))
        Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT GL_account_adjustment_dtl.refrence_no AS InvoiceNo, GL_account_adjustment_" & _
        "head.date_adjustment AS InvoiceDate, ROUND(GL_account_adjustment_dtl.amount_adju" & _
        "stment, 2) AS OriginalAmount, 0 AS Payment, 0 AS AmountDue, ROUND(GL_account_adj" & _
        "ustment_dtl.amount_adjustment, 2) AS OldPayment, GL_account_adjustment_head.date" & _
        "_adjustment AS DueDate, 0 AS PastDue, dbo.ChangeDate(GL_account_adjustment_head." & _
        "date_adjustment) AS INVOICEDATEYYYYMMDD, 3 AS type, '3' + GL_account_adjustment_" & _
        "dtl.refrence_no AS InvoiceNoForOrder, 0 AS Cancel_flag, 4 AS TypeOfRecord, 0 AS " & _
        "Paid_amount, @StoreNo AS StoreNo, @StoreName AS Shortname FROM GL_account_adjust" & _
        "ment_dtl INNER JOIN GL_account_adjustment_head ON GL_account_adjustment_dtl.refr" & _
        "ence_no = GL_account_adjustment_head.refrence_no WHERE (GL_account_adjustment_he" & _
        "ad.cod_customer = @Cod_customer)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreNo", System.Data.SqlDbType.Variant))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreName", System.Data.SqlDbType.Variant))
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        '
        'DAGL_account_adjustment_dtl
        '
        Me.DAGL_account_adjustment_dtl.SelectCommand = Me.SqlSelectCommand1
        Me.DAGL_account_adjustment_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account_adjustment_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("amount_adjustment", "amount_adjustment"), New System.Data.Common.DataColumnMapping("date_adjustment", "date_adjustment"), New System.Data.Common.DataColumnMapping("Remark", "Remark"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'PanelColors
        '
        Me.PanelColors.Controls.Add(Me.Label18)
        Me.PanelColors.Controls.Add(Me.Label17)
        Me.PanelColors.Controls.Add(Me.Label16)
        Me.PanelColors.Controls.Add(Me.Label15)
        Me.PanelColors.Controls.Add(Me.Label14)
        Me.PanelColors.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelColors.Location = New System.Drawing.Point(0, 413)
        Me.PanelColors.Name = "PanelColors"
        Me.PanelColors.Size = New System.Drawing.Size(642, 28)
        Me.PanelColors.TabIndex = 450
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.DarkKhaki
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(267, 3)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(108, 22)
        Me.Label18.TabIndex = 347
        Me.Label18.Text = "Paid by Other Store"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.LightBlue
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(509, 3)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 22)
        Me.Label17.TabIndex = 346
        Me.Label17.Text = "Adjustments"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.LightGreen
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(388, 3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(108, 22)
        Me.Label16.TabIndex = 345
        Me.Label16.Text = "Payments"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Pink
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(146, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 22)
        Me.Label15.TabIndex = 344
        Me.Label15.Text = "Returns"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Khaki
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(25, 3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 22)
        Me.Label14.TabIndex = 343
        Me.Label14.Text = "Invoices"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnMultiStore
        '
        Me.BtnMultiStore.BackColor = System.Drawing.Color.Gold
        Me.BtnMultiStore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMultiStore.Location = New System.Drawing.Point(555, 23)
        Me.BtnMultiStore.Name = "BtnMultiStore"
        Me.BtnMultiStore.Size = New System.Drawing.Size(67, 58)
        Me.BtnMultiStore.TabIndex = 451
        Me.BtnMultiStore.TabStop = False
        Me.BtnMultiStore.Text = "Multi Store Balance"
        '
        'DASTORE_SETUP
        '
        Me.DASTORE_SETUP.SelectCommand = Me.OleDbCommand1
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = "SELECT STORENO, STORENAME, SHORTNAME FROM STORE_SETUP ORDER BY STORENO"
        Me.OleDbCommand1.Connection = Me.CnnMdbSetup
        '
        'CnnMdbSetup
        '
        Me.CnnMdbSetup.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\TireMate\TireMatesetup.mdb;Persis" & _
        "t Security Info=True;Jet OLEDB:Database Password=5332"
        '
        'CmdSP_CustomerAgingNotDueYetOld
        '
        Me.CmdSP_CustomerAgingNotDueYetOld.CommandText = "dbo.[SP_CustomerAgingNotDueYet]"
        Me.CmdSP_CustomerAgingNotDueYetOld.CommandType = System.Data.CommandType.StoredProcedure
        Me.CmdSP_CustomerAgingNotDueYetOld.Connection = Me.Cnn
        Me.CmdSP_CustomerAgingNotDueYetOld.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.CmdSP_CustomerAgingNotDueYetOld.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        Me.CmdSP_CustomerAgingNotDueYetOld.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisCustomer", System.Data.SqlDbType.VarChar, 10))
        '
        'CmdSP_CustomerAging1to30
        '
        Me.CmdSP_CustomerAging1to30.CommandText = "dbo.[SP_CustomerAging1to30]"
        Me.CmdSP_CustomerAging1to30.CommandType = System.Data.CommandType.StoredProcedure
        Me.CmdSP_CustomerAging1to30.Connection = Me.Cnn
        Me.CmdSP_CustomerAging1to30.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.CmdSP_CustomerAging1to30.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        Me.CmdSP_CustomerAging1to30.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisCustomer", System.Data.SqlDbType.VarChar, 10))
        '
        'CmdSP_CustomerAging31to60
        '
        Me.CmdSP_CustomerAging31to60.CommandText = "dbo.[SP_CustomerAging31to60]"
        Me.CmdSP_CustomerAging31to60.CommandType = System.Data.CommandType.StoredProcedure
        Me.CmdSP_CustomerAging31to60.Connection = Me.Cnn
        Me.CmdSP_CustomerAging31to60.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.CmdSP_CustomerAging31to60.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        Me.CmdSP_CustomerAging31to60.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisCustomer", System.Data.SqlDbType.VarChar, 10))
        '
        'CmdSP_CustomerAging61to90
        '
        Me.CmdSP_CustomerAging61to90.CommandText = "dbo.[SP_CustomerAging61to90]"
        Me.CmdSP_CustomerAging61to90.CommandType = System.Data.CommandType.StoredProcedure
        Me.CmdSP_CustomerAging61to90.Connection = Me.Cnn
        Me.CmdSP_CustomerAging61to90.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.CmdSP_CustomerAging61to90.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        Me.CmdSP_CustomerAging61to90.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisCustomer", System.Data.SqlDbType.VarChar, 10))
        '
        'CmdSP_CustomerAgingOver90
        '
        Me.CmdSP_CustomerAgingOver90.CommandText = "dbo.[SP_CustomerAgingOver90]"
        Me.CmdSP_CustomerAgingOver90.CommandType = System.Data.CommandType.StoredProcedure
        Me.CmdSP_CustomerAgingOver90.Connection = Me.Cnn
        Me.CmdSP_CustomerAgingOver90.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.CmdSP_CustomerAgingOver90.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        Me.CmdSP_CustomerAgingOver90.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisCustomer", System.Data.SqlDbType.VarChar, 10))
        '
        'DAReturnWithoutPayment
        '
        Me.DAReturnWithoutPayment.SelectCommand = Me.SqlCommand1
        Me.DAReturnWithoutPayment.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("type_select", "type_select"), New System.Data.Common.DataColumnMapping("cod_select", "cod_select"), New System.Data.Common.DataColumnMapping("desc_radif", "desc_radif"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("cod_technician", "cod_technician"), New System.Data.Common.DataColumnMapping("COMMENT_ARTICLE", "COMMENT_ARTICLE")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT DISTINCT service_center_head.id_service_center AS InvoiceNo, service_cente" & _
        "r_head.date_refer AS InvoiceDate, ROUND(service_center_head.Total, 2) AS Origina" & _
        "lAmount, 0 AS Payment, 0 AS AmountDue, 0 AS OldPayment, '' AS DueDate, 0 AS Past" & _
        "Due, ROUND(service_center_head.discount, 2) AS discount, ROUND(service_center_he" & _
        "ad.tax, 2) AS tax, dbo.ChangeDate(service_center_head.date_refer) AS INVOICEDATE" & _
        "YYYYMMDD, 1 AS type, '1' + service_center_head.id_service_center AS InvoiceNoFor" & _
        "Order, 0 AS ID_payment, 0 AS Expr1, CASE type_of_form WHEN 'IN' THEN 1 WHEN 'RT'" & _
        " THEN 2 ELSE 0 END AS TypeOfRecord, 0 AS Paid_amount, @StoreNo AS StoreNo, @Stor" & _
        "eName AS Shortname FROM service_center_head LEFT OUTER JOIN View_Invoice_Balance" & _
        "_ForEach_ARDue RIGHT OUTER JOIN GL_payment_deposit_Due_Date_For_AR INNER JOIN GL" & _
        "_payment_deposit ON GL_payment_deposit_Due_Date_For_AR.ID_payment = GL_payment_d" & _
        "eposit.ID_payment ON View_Invoice_Balance_ForEach_ARDue.ID_payment = GL_payment_" & _
        "deposit.ID_payment ON service_center_head.id_service_center = GL_payment_deposit" & _
        ".id_service_center WHERE (service_center_head.type_of_form = 'RT') AND (service_" & _
        "center_head.cod_customer = @Cod_customer)"
        Me.SqlCommand1.Connection = Me.Cnn
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreNo", System.Data.SqlDbType.Variant))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreName", System.Data.SqlDbType.Variant))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        '
        'DAGL_payment_depositFromOtherStore
        '
        Me.DAGL_payment_depositFromOtherStore.SelectCommand = Me.SqlCommand2
        Me.DAGL_payment_depositFromOtherStore.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("type_select", "type_select"), New System.Data.Common.DataColumnMapping("cod_select", "cod_select"), New System.Data.Common.DataColumnMapping("desc_radif", "desc_radif"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("cod_technician", "cod_technician"), New System.Data.Common.DataColumnMapping("COMMENT_ARTICLE", "COMMENT_ARTICLE")})})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "SELECT GL_payment_deposit.refrence_no AS InvoiceNo, Gl_receive_payment.date_recei" & _
        "ve_payment AS InvoiceDate, 0 AS Payment, 0 AS AmountDue, 0 AS OldPayment, Gl_rec" & _
        "eive_payment.date_receive_payment AS DueDate, 0 AS PastDue, dbo.ChangeDate(Gl_re" & _
        "ceive_payment.date_receive_payment) AS INVOICEDATEYYYYMMDD, 2 AS type, '2' + GL_" & _
        "payment_deposit.id_service_center AS InvoiceNoForOrder, - ROUND(GL_payment_depos" & _
        "it.payment_amount, 2) AS OriginalAmount, 0 AS Cancel_flag, 5 AS TypeOfRecord, 0 " & _
        "AS Paid_amount, @StoreNo AS StoreNo, @StoreName AS Shortname FROM GL_payment_dep" & _
        "osit INNER JOIN Gl_receive_payment ON GL_payment_deposit.refrence_no = Gl_receiv" & _
        "e_payment.refrence_no WHERE (GL_payment_deposit.refer_type = '3') AND (Gl_receiv" & _
        "e_payment.cod_customer = @Cod_customer)"
        Me.SqlCommand2.Connection = Me.Cnn
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreNo", System.Data.SqlDbType.Variant))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreName", System.Data.SqlDbType.Variant))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        '
        'DAService_center_dtlOld
        '
        Me.DAService_center_dtlOld.SelectCommand = Me.SqlCommand4
        Me.DAService_center_dtlOld.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("type_select", "type_select"), New System.Data.Common.DataColumnMapping("cod_select", "cod_select"), New System.Data.Common.DataColumnMapping("desc_radif", "desc_radif"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("cod_technician", "cod_technician"), New System.Data.Common.DataColumnMapping("COMMENT_ARTICLE", "COMMENT_ARTICLE")})})
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "SELECT DISTINCT service_center_head.id_service_center AS InvoiceNo, service_cente" & _
        "r_head.date_refer AS InvoiceDate, ROUND(service_center_head.Total, 2) AS Origina" & _
        "lAmount, 0 AS Payment, ISNULL(View_Invoice_Balance_ForEach_ARDue.BalanceAmount, " & _
        "0) AS AmountDue, ROUND(service_center_head.Total, 2) - View_Invoice_Balance_ForE" & _
        "ach_ARDue.BalanceAmount AS OldPayment, GL_payment_deposit_Due_Date_For_AR.AR_due" & _
        "_date AS DueDate, 0 AS PastDue, ROUND(service_center_head.discount, 2) AS discou" & _
        "nt, ROUND(service_center_head.tax, 2) AS tax, dbo.ChangeDate(service_center_head" & _
        ".date_refer) AS INVOICEDATEYYYYMMDD, 1 AS type, '1' + service_center_head.id_ser" & _
        "vice_center AS InvoiceNoForOrder, ISNULL(GL_payment_deposit_Due_Date_For_AR.ID_p" & _
        "ayment, 0) AS ID_payment, GL_payment_deposit_Due_Date_For_AR.Cancel_flag, CASE t" & _
        "ype_of_form WHEN 'IN' THEN 1 WHEN 'RT' THEN 2 ELSE 0 END AS TypeOfRecord, ROUND(" & _
        "GL_payment_deposit.Paid_amount, 2) AS Paid_amount, @StoreNo AS StoreNo, @StoreNa" & _
        "me AS Shortname FROM service_center_head LEFT OUTER JOIN View_Invoice_Balance_Fo" & _
        "rEach_ARDue RIGHT OUTER JOIN GL_payment_deposit_Due_Date_For_AR INNER JOIN GL_pa" & _
        "yment_deposit ON GL_payment_deposit_Due_Date_For_AR.ID_payment = GL_payment_depo" & _
        "sit.ID_payment ON View_Invoice_Balance_ForEach_ARDue.ID_payment = GL_payment_dep" & _
        "osit.ID_payment ON service_center_head.id_service_center = GL_payment_deposit.id" & _
        "_service_center WHERE (service_center_head.type_of_form = 'IN') AND (service_cen" & _
        "ter_head.cod_customer = @Cod_customer) AND (GL_payment_deposit.refer_type = '1')" & _
        ""
        Me.SqlCommand4.Connection = Me.Cnn
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreNo", System.Data.SqlDbType.Variant))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@StoreName", System.Data.SqlDbType.Variant))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        '
        'CmdSP_CustomerAgingNotDueYet
        '
        Me.CmdSP_CustomerAgingNotDueYet.CommandText = "dbo.[SP_CustomerAgingNotDueYet]"
        Me.CmdSP_CustomerAgingNotDueYet.CommandType = System.Data.CommandType.StoredProcedure
        Me.CmdSP_CustomerAgingNotDueYet.Connection = Me.Cnn
        Me.CmdSP_CustomerAgingNotDueYet.Parameters.Add(New System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, False, CType(0, Byte), CType(0, Byte), "", System.Data.DataRowVersion.Current, Nothing))
        Me.CmdSP_CustomerAgingNotDueYet.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10))
        Me.CmdSP_CustomerAgingNotDueYet.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisCustomer", System.Data.SqlDbType.VarChar, 10))
        '
        'FrmCustomerBalance
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(642, 441)
        Me.Controls.Add(Me.BtnMultiStore)
        Me.Controls.Add(Me.PanelGrid)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.BtnDetail)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelColors)
        Me.Name = "FrmCustomerBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Customer Balance"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PanelGrid.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmCustomerBalance1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.PanelColors.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCustomerBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PanelGridHeightVar = PanelGrid.Height
        PanelColorHeightVar = PanelColors.Height
        FormHeightVar = Me.Height
        PanelGrid.Height = 0
        PanelColors.Height = 0
        Me.Height = FormHeightVar - PanelGridHeightVar - PanelColorHeightVar
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        CnnMdbSetup.ConnectionString = PConnectionStringForSetupTables

        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        Dim KIND_AR As Integer = 0
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If

        Call AddConditionalFormatting()

        CmdGeneral.CommandText = "SELECT GL_TAB_AR_TERM.KIND_AR, GL_TAB_AR_TERM.ST_NET_DUE_IN, GL_TAB_AR_TERM.ST_DISCOUNT_PERCENTAGE " _
                               & " FROM cust_trtab_main INNER JOIN " _
                               & " GL_TAB_AR_TERM ON cust_trtab_main.AR_term = GL_TAB_AR_TERM.AR_terms Where cust_trtab_main.cod_customer=" & Qt(LblCustomer.Text)
        SQLReader = CmdGeneral.ExecuteReader
        If SQLReader.HasRows Then
            SQLReader.Read()
            Try
                KIND_AR = SQLReader.Item("KIND_AR")
            Catch ex As Exception
                KIND_AR = 0
            End Try
        End If
        SQLReader.Close()

        Call FillDataSet()

    End Sub
    Private Sub FillDataSet()

        Dim ThisConnectionStringVar As String
        DsFrmCustomerBalance1.Clear()
        DASTORE_SETUP.Fill(DsFrmCustomerBalance1, "Store_Setup")
        Dim StoreCounterVar As Integer
        If FlagMultiStore Then
            For StoreCounterVar = 0 To DsFrmCustomerBalance1.Store_Setup.Rows.Count - 1
                ThisConnectionStringVar = MakeConnectionSqlForThisStore(DsFrmCustomerBalance1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo"))
                Try
                    If Cnn.State = ConnectionState.Open Then
                        Cnn.Close()
                    End If
                    Cnn.ConnectionString = ThisConnectionStringVar
                    DAService_center_dtl.SelectCommand.Parameters("@Cod_customer").Value = Cod_customerParameter
                    DAService_center_dtl.SelectCommand.Parameters("@STORENO").Value = DsFrmCustomerBalance1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo")
                    DAService_center_dtl.SelectCommand.Parameters("@STORENAME").Value = DsFrmCustomerBalance1.Store_Setup.Rows(StoreCounterVar).Item("ShortName")
                    DAService_center_dtl.Fill(DsFrmCustomerBalance1, "service_center_dtl")

                    DAReturnWithoutPayment.SelectCommand.Parameters("@Cod_customer").Value = Cod_customerParameter
                    DAReturnWithoutPayment.SelectCommand.Parameters("@STORENO").Value = PubStoreNO
                    DAReturnWithoutPayment.SelectCommand.Parameters("@STORENAME").Value = PubStoreName
                    DAReturnWithoutPayment.Fill(DsFrmCustomerBalance1, "service_center_dtl")

                    DAGL_payment_deposit.SelectCommand.Parameters("@Cod_customer").Value = Cod_customerParameter
                    DAGL_payment_deposit.SelectCommand.Parameters("@STORENO").Value = DsFrmCustomerBalance1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo")
                    DAGL_payment_deposit.SelectCommand.Parameters("@STORENAME").Value = DsFrmCustomerBalance1.Store_Setup.Rows(StoreCounterVar).Item("ShortName")
                    DAGL_payment_deposit.Fill(DsFrmCustomerBalance1, "service_center_dtl")

                    DAGL_payment_depositFromOtherStore.SelectCommand.Parameters("@Cod_customer").Value = Cod_customerParameter
                    DAGL_payment_depositFromOtherStore.SelectCommand.Parameters("@STORENO").Value = DsFrmCustomerBalance1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo")
                    DAGL_payment_depositFromOtherStore.SelectCommand.Parameters("@STORENAME").Value = DsFrmCustomerBalance1.Store_Setup.Rows(StoreCounterVar).Item("ShortName")
                    DAGL_payment_depositFromOtherStore.Fill(DsFrmCustomerBalance1, "service_center_dtl")

                    DAGL_account_adjustment_dtl.SelectCommand.Parameters("@Cod_customer").Value = Cod_customerParameter
                    DAGL_account_adjustment_dtl.SelectCommand.Parameters("@STORENO").Value = DsFrmCustomerBalance1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo")
                    DAGL_account_adjustment_dtl.SelectCommand.Parameters("@STORENAME").Value = DsFrmCustomerBalance1.Store_Setup.Rows(StoreCounterVar).Item("ShortName")
                    DAGL_account_adjustment_dtl.Fill(DsFrmCustomerBalance1, "service_center_dtl")
                Catch ex As Exception
                    MsgBox("Please Call to Your Vendor.Error In Setup Files")
                End Try
            Next
            If Cnn.State = ConnectionState.Open Then
                Cnn.Close()
            End If
            Cnn.ConnectionString = PConnectionString
        Else
            DAService_center_dtl.SelectCommand.Parameters("@Cod_customer").Value = Cod_customerParameter
            DAService_center_dtl.SelectCommand.Parameters("@STORENO").Value = PubStoreNO
            DAService_center_dtl.SelectCommand.Parameters("@STORENAME").Value = PubStoreName
            DAService_center_dtl.Fill(DsFrmCustomerBalance1, "service_center_dtl")

            DAReturnWithoutPayment.SelectCommand.Parameters("@Cod_customer").Value = Cod_customerParameter
            DAReturnWithoutPayment.SelectCommand.Parameters("@STORENO").Value = PubStoreNO
            DAReturnWithoutPayment.SelectCommand.Parameters("@STORENAME").Value = PubStoreName
            DAReturnWithoutPayment.Fill(DsFrmCustomerBalance1, "service_center_dtl")

            DAGL_payment_deposit.SelectCommand.Parameters("@Cod_customer").Value = Cod_customerParameter
            DAGL_payment_deposit.SelectCommand.Parameters("@STORENO").Value = PubStoreNO
            DAGL_payment_deposit.SelectCommand.Parameters("@STORENAME").Value = PubStoreName
            DAGL_payment_deposit.Fill(DsFrmCustomerBalance1, "service_center_dtl")

            DAGL_payment_depositFromOtherStore.SelectCommand.Parameters("@Cod_customer").Value = Cod_customerParameter
            DAGL_payment_depositFromOtherStore.SelectCommand.Parameters("@STORENO").Value = PubStoreNO
            DAGL_payment_depositFromOtherStore.SelectCommand.Parameters("@STORENAME").Value = PubStoreName
            DAGL_payment_depositFromOtherStore.Fill(DsFrmCustomerBalance1, "service_center_dtl")

            DAGL_account_adjustment_dtl.SelectCommand.Parameters("@Cod_customer").Value = Cod_customerParameter
            DAGL_account_adjustment_dtl.SelectCommand.Parameters("@STORENO").Value = PubStoreNO
            DAGL_account_adjustment_dtl.SelectCommand.Parameters("@STORENAME").Value = PubStoreName
            DAGL_account_adjustment_dtl.Fill(DsFrmCustomerBalance1, "service_center_dtl")
        End If

        DsFrmCustomerBalance1.service_center_dtl.DefaultView.Sort = "InvoiceNoForOrder,INVOICEDATEYYYYMMDD"
        Dim OldInvoice As String = ""
        Try
            If DsFrmCustomerBalance1.service_center_dtl.DefaultView.Count > 0 Then
                Dim i As Integer
                Dim payment_amountVar As Double
                For i = 0 To DsFrmCustomerBalance1.service_center_dtl.DefaultView.Count - 1

                    'ThisConnectionStringVar = MakeConnectionSqlForThisStore(DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("StoreNo"))
                    '''''Try
                    '''''    If Cnn.State = ConnectionState.Open Then
                    '''''        Cnn.Close()
                    '''''    End If
                    '''''    Cnn.ConnectionString = ThisConnectionStringVar
                    '''''    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    '''''        CmdGeneral.Connection.Open()
                    '''''    End If
                    '''''    CmdGeneral.CommandText = "SELECT isnull(payment_amount,0) as payment_amount FROM GL_payment_deposit Where ID_payment=" & DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("ID_payment")
                    '''''    payment_amountVar = CmdGeneral.ExecuteScalar
                    '''''Catch ex As Exception
                    '''''    payment_amountVar = 0
                    '''''End Try

                    '''''DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("AmountDue") = payment_amountVar - DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("Paid_amount")

                    'If OldInvoice = DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("InvoiceNoForOrder") Then
                    '    DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("AmountDue") = DsFrmCustomerBalance1.service_center_dtl.DefaultView(i - 1).Item("AmountDue") ' - (IIf(IsDBNull(DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("OldPayment")), 0, DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("OldPayment")) * IIf(DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("Type") = 3, -1, 1))
                    'Else
                    '    DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("AmountDue") = DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("OriginalAmount") - (IIf(IsDBNull(DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("OldPayment")), 0, DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("OldPayment")) * IIf(DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("Type") = 3, -1, 1))
                    'End If
                    DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("FlagForBalance") = 0

                    'If DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("type") = 1 Then
                    '    If Trim(DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("DueDate") & "").Length = 0 Then
                    '        DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("DueDate") = DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("InvoiceDate")
                    '    End If
                    '    DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("DueDateYYYYMMDD") = ChangeDateToYYYYMMDD(DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("DueDate"))
                    '    DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("PastDue") = Now.Date.Subtract(CType(DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("DueDate"), Date)).Days
                    '    If DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("PastDue") < 0 Or DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("AmountDue") = 0 Then
                    '        DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("PastDue") = 0
                    '    End If
                    'End If
                    If Trim(DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("DueDate") & "").Length = 0 Then
                        DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("DueDate") = DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("InvoiceDate")
                    End If
                    DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("DueDateYYYYMMDD") = ChangeDateToYYYYMMDD(DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("DueDate"))
                    DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("PastDue") = Now.Date.Subtract(CType(DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("DueDate"), Date)).Days
                    If DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("type") = 1 Then
                        If DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("PastDue") < 0 Or DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("AmountDue") = 0 Then
                            DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("PastDue") = 0
                        End If
                    Else
                        If DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("PastDue") < 0 Then
                            DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("PastDue") = 0
                        End If
                    End If


                    If OldInvoice <> DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("InvoiceNoForOrder") Then
                        If OldInvoice.Trim.Length > 0 Then
                            DsFrmCustomerBalance1.service_center_dtl.DefaultView(i - 1).Item("FlagForBalance") = 1
                        End If
                        OldInvoice = DsFrmCustomerBalance1.service_center_dtl.DefaultView(i).Item("InvoiceNoForOrder")
                    End If
                Next
                DsFrmCustomerBalance1.service_center_dtl.DefaultView(i - 1).Item("FlagForBalance") = 1
            End If
        Catch ex As Exception
            'If Cnn.State = ConnectionState.Open Then
            '    Cnn.Close()
            'End If
            'Cnn.ConnectionString = PConnectionString
            MsgBox("Error In loading data.Please call to your vendor.")
            Exit Sub
            'Finally
            'If Cnn.State = ConnectionState.Open Then
            '    Cnn.Close()
            'End If
            'Cnn.ConnectionString = PConnectionString
        End Try


        LblBalance.Text = 0
        LblOriginalAmount.Text = 0
        LblOPBalance.Text = 0
        LblDPBalance.Text = 0
        LblReturns.Text = 0
        LblPayment.Text = 0
        LblNotDueYet.Text = 0
        LblUpto30Days.Text = 0
        LblUpto60Days.Text = 0
        LblUpto90Days.Text = 0
        LblOver90Days.Text = 0

        If FlagMultiStore Then

            For StoreCounterVar = 0 To DsFrmCustomerBalance1.Store_Setup.Rows.Count - 1
                ThisConnectionStringVar = MakeConnectionSqlForThisStore(DsFrmCustomerBalance1.Store_Setup.Rows(StoreCounterVar).Item("StoreNo"))
                If Cnn.State = ConnectionState.Open Then
                    Cnn.Close()
                End If
                Cnn.ConnectionString = ThisConnectionStringVar
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If

                Try
                    CmdGeneral.CommandText = "SELECT isnull(BalanceAmount,0) FROM View_Customer_Balance WHERE cod_customer= " & Qt(LblCustomer.Text)
                    LblBalance.Text = LblBalance.Numbervalue + CmdGeneral.ExecuteScalar
                Catch ex As Exception
                End Try
                Try
                    CmdGeneral.CommandText = "SELECT  SUM(round(GL_payment_deposit.payment_amount,2)) FROM GL_payment_deposit INNER JOIN " & _
                              " service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center " & _
                              " WHERE GL_payment_deposit.refer_type = '1' AND  cod_customer= " & Qt(LblCustomer.Text)
                    LblOriginalAmount.Text = LblOriginalAmount.Numbervalue + CmdGeneral.ExecuteScalar
                Catch ex As Exception
                End Try
                Try
                    CmdGeneral.CommandText = "SELECT sum(round(amount_adjustment,2)) FROM  GL_account_adjustment_head " & _
                              " WHERE amount_adjustment>0 AND cod_customer= " & Qt(LblCustomer.Text)
                    LblOriginalAmount.Text = LblOriginalAmount.Numbervalue + CmdGeneral.ExecuteScalar
                Catch ex As Exception
                End Try
                Try
                    CmdGeneral.CommandText = "SELECT BalanceOverPaymentAmount FROM View_Balance_OverPayment_Amount Where cod_customer= " & Qt(LblCustomer.Text)
                    LblOPBalance.Text = LblOPBalance.Numbervalue + CmdGeneral.ExecuteScalar
                Catch ex As Exception
                End Try
                Try
                    CmdGeneral.CommandText = "SELECT BalanceDownPaymentAmount FROM View_Balance_DownPayment_Amount Where cod_customer= " & Qt(LblCustomer.Text)
                    LblDPBalance.Text = LblDPBalance.Numbervalue + CmdGeneral.ExecuteScalar
                Catch ex As Exception
                End Try
                Try
                    CmdGeneral.CommandText = "SELECT     ISNULL(SUM(ROUND(GL_payment_deposit.payment_amount, 2)), 0) AS Expr1, service_center_head.cod_customer FROM " & _
                                           " GL_payment_deposit INNER JOIN service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center INNER JOIN GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment " & _
                                           " WHERE  (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.payment_type = '4') AND (GL_payment_AR.Cancel_flag = 1) AND cod_customer= " & Qt(LblCustomer.Text) & _
                                           " GROUP BY service_center_head.cod_customer "
                    LblReturns.Text = LblReturns.Numbervalue + CmdGeneral.ExecuteScalar
                Catch ex As Exception
                End Try
                Try
                    CmdGeneral.CommandText = "SELECT isnull(Sum(round(amount,2)),0) FROM GL_Paid_received WHERE tran_type = '3' AND customer_code= " & Qt(LblCustomer.Text)
                    LblReturns.Text = LblReturns.Numbervalue + CmdGeneral.ExecuteScalar
                Catch ex As Exception
                End Try


                Try
                    LblPayment.Text = LblPayment.Numbervalue + LblOriginalAmount.Numbervalue - LblBalance.Numbervalue - LblReturns.Numbervalue + LblOPBalance.Numbervalue + LblDPBalance.Numbervalue
                Catch ex As Exception
                    LblPayment.Text = 0
                End Try

                If LblBalance.Numbervalue = 0 Then
                    LblNotDueYet.Text = 0
                    LblUpto30Days.Text = 0
                    LblUpto60Days.Text = 0
                    LblUpto90Days.Text = 0
                    LblOver90Days.Text = 0
                Else
                    Dim TempVal As Decimal
                    Try
                        CmdSP_CustomerAgingNotDueYet.Parameters("@ThisDate").Value = Format(Now.Date, PubDateFormat)
                        CmdSP_CustomerAgingNotDueYet.Parameters("@ThisCustomer").Value = LblCustomer.Text
                        TempVal = CmdSP_CustomerAgingNotDueYet.ExecuteScalar
                    Catch ex As Exception
                        TempVal = 0
                    End Try
                    LblNotDueYet.Text = LblNotDueYet.Numbervalue + TempVal
                    Try
                        CmdSP_CustomerAging1to30.Parameters("@ThisDate").Value = Format(Now.Date, PubDateFormat)
                        CmdSP_CustomerAging1to30.Parameters("@ThisCustomer").Value = LblCustomer.Text
                        TempVal = CmdSP_CustomerAging1to30.ExecuteScalar
                    Catch ex As Exception
                        TempVal = 0
                    End Try
                    LblUpto30Days.Text = LblUpto30Days.Numbervalue + TempVal
                    Try
                        CmdSP_CustomerAging31to60.Parameters("@ThisDate").Value = Format(Now.Date, PubDateFormat)
                        CmdSP_CustomerAging31to60.Parameters("@ThisCustomer").Value = LblCustomer.Text
                        TempVal = CmdSP_CustomerAging31to60.ExecuteScalar
                    Catch ex As Exception
                        TempVal = 0
                    End Try
                    LblUpto60Days.Text = LblUpto60Days.Numbervalue + TempVal
                    Try
                        CmdSP_CustomerAging61to90.Parameters("@ThisDate").Value = Format(Now.Date, PubDateFormat)
                        CmdSP_CustomerAging61to90.Parameters("@ThisCustomer").Value = LblCustomer.Text
                        TempVal = CmdSP_CustomerAging61to90.ExecuteScalar
                    Catch ex As Exception
                        TempVal = 0
                    End Try
                    LblUpto90Days.Text = LblUpto90Days.Numbervalue + TempVal
                    Try
                        CmdSP_CustomerAgingOver90.Parameters("@ThisDate").Value = Format(Now.Date, PubDateFormat)
                        CmdSP_CustomerAgingOver90.Parameters("@ThisCustomer").Value = LblCustomer.Text
                        TempVal = CmdSP_CustomerAgingOver90.ExecuteScalar
                    Catch ex As Exception
                        TempVal = 0
                    End Try
                    LblOver90Days.Text = LblOver90Days.Numbervalue + TempVal
                End If

            Next

            If Cnn.State = ConnectionState.Open Then
                Cnn.Close()
            End If
            Cnn.ConnectionString = PConnectionString

        Else
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If

            Try
                CmdGeneral.CommandText = "SELECT isnull(BalanceAmount,0) FROM View_Customer_Balance WHERE cod_customer= " & Qt(LblCustomer.Text)
                LblBalance.Text = LblBalance.Numbervalue + CmdGeneral.ExecuteScalar
            Catch ex As Exception
            End Try
            Try
                CmdGeneral.CommandText = "SELECT  SUM(round(GL_payment_deposit.payment_amount,2)) FROM GL_payment_deposit INNER JOIN " & _
                          " service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center " & _
                          " WHERE GL_payment_deposit.refer_type = '1' AND  cod_customer= " & Qt(LblCustomer.Text)
                LblOriginalAmount.Text = LblOriginalAmount.Numbervalue + CmdGeneral.ExecuteScalar
            Catch ex As Exception
            End Try
            Try
                CmdGeneral.CommandText = "SELECT sum(round(amount_adjustment,2)) FROM  GL_account_adjustment_head " & _
                          " WHERE amount_adjustment>0 AND cod_customer= " & Qt(LblCustomer.Text)
                LblOriginalAmount.Text = LblOriginalAmount.Numbervalue + CmdGeneral.ExecuteScalar
            Catch ex As Exception
            End Try
            Try
                CmdGeneral.CommandText = "SELECT BalanceOverPaymentAmount FROM View_Balance_OverPayment_Amount Where cod_customer= " & Qt(LblCustomer.Text)
                LblOPBalance.Text = LblOPBalance.Numbervalue + CmdGeneral.ExecuteScalar
            Catch ex As Exception
            End Try
            Try
                CmdGeneral.CommandText = "SELECT BalanceDownPaymentAmount FROM View_Balance_DownPayment_Amount Where cod_customer= " & Qt(LblCustomer.Text)
                LblDPBalance.Text = LblDPBalance.Numbervalue + CmdGeneral.ExecuteScalar
            Catch ex As Exception
            End Try
            Try
                CmdGeneral.CommandText = "SELECT     ISNULL(SUM(ROUND(GL_payment_deposit.payment_amount, 2)), 0) AS Expr1, service_center_head.cod_customer FROM " & _
                                       " GL_payment_deposit INNER JOIN service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center INNER JOIN GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment " & _
                                       " WHERE  (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.payment_type = '4') AND (GL_payment_AR.Cancel_flag = 1) AND cod_customer= " & Qt(LblCustomer.Text) & _
                                       " GROUP BY service_center_head.cod_customer "
                LblReturns.Text = CmdGeneral.ExecuteScalar
            Catch ex As Exception
            End Try
            Try
                CmdGeneral.CommandText = "SELECT isnull(Sum(round(amount,2)),0) FROM GL_Paid_received WHERE tran_type = '3' AND customer_code= " & Qt(LblCustomer.Text)
                LblReturns.Text = LblReturns.Numbervalue + CmdGeneral.ExecuteScalar
            Catch ex As Exception
            End Try

            Try
                CmdSP_CustomerAgingNotDueYet.Parameters("@ThisDate").Value = Format(Now.Date, PubDateFormat)
                CmdSP_CustomerAgingNotDueYet.Parameters("@ThisCustomer").Value = LblCustomer.Text
                LblNotDueYet.Text = CmdSP_CustomerAgingNotDueYet.ExecuteScalar
            Catch ex As Exception

            End Try
            Try
                CmdSP_CustomerAging1to30.Parameters("@ThisDate").Value = Format(Now.Date, PubDateFormat)
                CmdSP_CustomerAging1to30.Parameters("@ThisCustomer").Value = LblCustomer.Text
                LblUpto30Days.Text = CmdSP_CustomerAging1to30.ExecuteScalar
            Catch ex As Exception

            End Try
            Try
                CmdSP_CustomerAging31to60.Parameters("@ThisDate").Value = Format(Now.Date, PubDateFormat)
                CmdSP_CustomerAging31to60.Parameters("@ThisCustomer").Value = LblCustomer.Text
                LblUpto60Days.Text = CmdSP_CustomerAging31to60.ExecuteScalar
            Catch ex As Exception

            End Try
            Try
                CmdSP_CustomerAging61to90.Parameters("@ThisDate").Value = Format(Now.Date, PubDateFormat)
                CmdSP_CustomerAging61to90.Parameters("@ThisCustomer").Value = LblCustomer.Text
                LblUpto90Days.Text = CmdSP_CustomerAging61to90.ExecuteScalar
            Catch ex As Exception

            End Try
            Try
                CmdSP_CustomerAgingOver90.Parameters("@ThisDate").Value = Format(Now.Date, PubDateFormat)
                CmdSP_CustomerAgingOver90.Parameters("@ThisCustomer").Value = LblCustomer.Text
                LblOver90Days.Text = CmdSP_CustomerAgingOver90.ExecuteScalar
            Catch ex As Exception
            End Try
        End If

        Try
            LblPayment.Text = LblOriginalAmount.Numbervalue - LblBalance.Numbervalue - LblReturns.Numbervalue + LblOPBalance.Numbervalue + LblDPBalance.Numbervalue
        Catch ex As Exception
            LblPayment.Text = 0
        End Try

        If LblBalance.Numbervalue = 0 Then
            LblNotDueYet.Text = 0
            LblUpto30Days.Text = 0
            LblUpto60Days.Text = 0
            LblUpto90Days.Text = 0
            LblOver90Days.Text = 0
        End If

    End Sub
    Private Sub BtnDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDetail.Click
        Me.Height = FormHeightVar
        PanelGrid.Height = PanelGridHeightVar
        PanelColors.Height = PanelColorHeightVar
    End Sub
    Private Sub AddConditionalFormatting()
        Dim fc As GridEXFormatCondition
        fc = New Janus.Windows.GridEX.GridEXFormatCondition(GrdDetail.RootTable.Columns("TypeOfRecord"), ConditionOperator.Equal, 1)
        fc.FormatStyle.BackColor = Color.Khaki
        GrdDetail.RootTable.FormatConditions.Add(fc)
        fc = New Janus.Windows.GridEX.GridEXFormatCondition(GrdDetail.RootTable.Columns("TypeOfRecord"), ConditionOperator.Equal, 2)
        fc.FormatStyle.BackColor = Color.Pink
        GrdDetail.RootTable.FormatConditions.Add(fc)
        fc = New Janus.Windows.GridEX.GridEXFormatCondition(GrdDetail.RootTable.Columns("TypeOfRecord"), ConditionOperator.Equal, 3)
        fc.FormatStyle.BackColor = Color.LightGreen
        GrdDetail.RootTable.FormatConditions.Add(fc)
        fc = New Janus.Windows.GridEX.GridEXFormatCondition(GrdDetail.RootTable.Columns("TypeOfRecord"), ConditionOperator.Equal, 4)
        fc.FormatStyle.BackColor = Color.LightBlue
        GrdDetail.RootTable.FormatConditions.Add(fc)
        fc = New Janus.Windows.GridEX.GridEXFormatCondition(GrdDetail.RootTable.Columns("TypeOfRecord"), ConditionOperator.Equal, 5)
        fc.FormatStyle.BackColor = Color.DarkKhaki
        GrdDetail.RootTable.FormatConditions.Add(fc)
    End Sub
    Private Sub BtnMultiStore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMultiStore.Click
        FlagMultiStore = Not FlagMultiStore
        Me.Text = "Loading ..................."
        If FlagMultiStore Then
            BtnMultiStore.Text = "This Store Balance"
        Else
            BtnMultiStore.Text = "Multi Store Balance"
        End If
        Call FillDataSet()
        If FlagMultiStore Then
            Me.Text = "Customer Balance - Multi Store"
        Else
            Me.Text = "Customer Balance"
        End If
    End Sub
    Private Function CalcTotalRA_AA(ByVal FilterParam As String) As Double
        'Try
        '    CalcTotalRA_AA = -Math.Round(DsFrmCustomerBalance1.service_center_dtl.Compute("Sum(originalamount)", FilterParam & " AND type=2"), 2)
        'Catch ex As Exception
        CalcTotalRA_AA = 0
        'End Try
        Try
            CalcTotalRA_AA = Math.Round(CalcTotalRA_AA - Math.Round(DsFrmCustomerBalance1.service_center_dtl.Compute("Sum(originalamount)", FilterParam & " AND type=3"), 2), 2)
        Catch ex As Exception
        End Try
    End Function
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        If GrdDetail.RowCount > 0 Then
            Dim Currentrow As GridEXRow = GrdDetail.GetRow
            Select Case Currentrow.Cells("TypeOfRecord").Value & ""
                Case 1
                    Dim MyFrmShowWorkOrder As New WorkOrderUtility.FrmShowWorkOrder
                    MyFrmShowWorkOrder.TypeOfForm = "IN"
                    MyFrmShowWorkOrder.TxtRef.Text = Currentrow.Cells("InvoiceNo").Value & ""
                    MyFrmShowWorkOrder.StartPosition = FormStartPosition.CenterScreen
                    MyFrmShowWorkOrder.ShowDialog()
                Case 2
                    Dim MyFrmShowWorkOrder As New WorkOrderUtility.FrmShowWorkOrder
                    MyFrmShowWorkOrder.TypeOfForm = "RT"
                    MyFrmShowWorkOrder.TxtRef.Text = Currentrow.Cells("InvoiceNo").Value & ""
                    MyFrmShowWorkOrder.StartPosition = FormStartPosition.CenterScreen
                    MyFrmShowWorkOrder.ShowDialog()
                Case 3
                    Dim MyFrmReceivePayment As New FrmReceivePayment
                    MyFrmReceivePayment.Refrence_NoForShowReadOnly = Currentrow.Cells("InvoiceNo").Value & ""
                    MyFrmReceivePayment.StartPosition = FormStartPosition.CenterScreen
                    MyFrmReceivePayment.ShowDialog()
                Case 4
                    Dim MyFrmShowAccountAdjustment As New WorkOrderUtility.FrmShowAccountAdjustment
                    MyFrmShowAccountAdjustment.Refrence_NoVar = Currentrow.Cells("InvoiceNo").Value & ""
                    MyFrmShowAccountAdjustment.StartPosition = FormStartPosition.CenterScreen
                    MyFrmShowAccountAdjustment.ShowDialog()
                Case 5
                    Dim MyFrmReceivePayment As New FrmReceivePayment
                    MyFrmReceivePayment.Refrence_NoForShowReadOnly = Currentrow.Cells("InvoiceNo").Value & ""
                    MyFrmReceivePayment.StartPosition = FormStartPosition.CenterScreen
                    MyFrmReceivePayment.ShowDialog()
            End Select
        End If
    End Sub
End Class
