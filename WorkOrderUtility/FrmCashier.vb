Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmCashier
    Inherits FrmBase
    Public CustomerCodeVar As String
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
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnSaveAndPrint As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnPaymentOnHold As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnSaveNoPrint As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ChkAR As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CmbCCType As System.Windows.Forms.ComboBox
    Friend WithEvents ChkCreditCard As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbARTerms As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtCheckNo As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents TxtAuthNo As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents LblCardNo As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAbas_cc_type As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmCashier1 As DSFrmCashier
    Friend WithEvents TXTCardNo As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents TxtRef As System.Windows.Forms.TextBox
    Friend WithEvents ChkCash As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkCheck As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents NumCashRendered As CalcUtils.UcCalcText
    Friend WithEvents NumChangeDue As CalcUtils.UcCalcText
    Friend WithEvents NumCheckAmount As CalcUtils.UcCalcText
    Friend WithEvents NumBalance As CalcUtils.UcCalcText
    Friend WithEvents NumARAmount As CalcUtils.UcCalcText
    Friend WithEvents NumChargeAmount As CalcUtils.UcCalcText
    Friend WithEvents DteDueDate As CalendarCombo.CalendarCombo
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_payment_deposit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents NumAmount As CalcUtils.UcCalcText
    Friend WithEvents NumMonth As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents NumYear As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CmdGeneralForReader As System.Data.SqlClient.SqlCommand
    Friend WithEvents CnnForReader As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_TAB_AR_TERM As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents BtnDetail As Janus.Windows.EditControls.UIButton
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkOverPayment As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents NumOverPayment As CalcUtils.UcCalcText
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents NumOverPaymentBalance As CalcUtils.UcCalcText
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ChkDownPayment As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents NumDownPaymentBalance As CalcUtils.UcCalcText
    Friend WithEvents NumDownPayment As CalcUtils.UcCalcText
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCashier))
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.NumAmount = New CalcUtils.UcCalcText
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxtDate = New System.Windows.Forms.TextBox
        Me.TxtRef = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.BtnCancel = New Janus.Windows.EditControls.UIButton
        Me.BtnSaveAndPrint = New Janus.Windows.EditControls.UIButton
        Me.BtnPaymentOnHold = New Janus.Windows.EditControls.UIButton
        Me.BtnSaveNoPrint = New Janus.Windows.EditControls.UIButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label20 = New System.Windows.Forms.Label
        Me.NumDownPaymentBalance = New CalcUtils.UcCalcText
        Me.Label19 = New System.Windows.Forms.Label
        Me.NumDownPayment = New CalcUtils.UcCalcText
        Me.ChkDownPayment = New Janus.Windows.EditControls.UICheckBox
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.NumOverPaymentBalance = New CalcUtils.UcCalcText
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.NumOverPayment = New CalcUtils.UcCalcText
        Me.Label17 = New System.Windows.Forms.Label
        Me.ChkOverPayment = New Janus.Windows.EditControls.UICheckBox
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.BtnDetail = New Janus.Windows.EditControls.UIButton
        Me.NumMonth = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.NumYear = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.DteDueDate = New CalendarCombo.CalendarCombo
        Me.NumBalance = New CalcUtils.UcCalcText
        Me.NumARAmount = New CalcUtils.UcCalcText
        Me.NumChargeAmount = New CalcUtils.UcCalcText
        Me.NumCheckAmount = New CalcUtils.UcCalcText
        Me.NumChangeDue = New CalcUtils.UcCalcText
        Me.NumCashRendered = New CalcUtils.UcCalcText
        Me.ChkCheck = New Janus.Windows.EditControls.UICheckBox
        Me.ChkCash = New Janus.Windows.EditControls.UICheckBox
        Me.TXTCardNo = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TxtAuthNo = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TxtCheckNo = New Janus.Windows.GridEX.EditControls.EditBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.CmbCCType = New System.Windows.Forms.ComboBox
        Me.DsFrmCashier1 = New WorkOrderUtility.DSFrmCashier
        Me.ChkCreditCard = New Janus.Windows.EditControls.UICheckBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.LblCardNo = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.CmbARTerms = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.ChkAR = New Janus.Windows.EditControls.UICheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAbas_cc_type = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_payment_deposit = New System.Data.SqlClient.SqlDataAdapter
        Me.CmdGeneralForReader = New System.Data.SqlClient.SqlCommand
        Me.CnnForReader = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_TAB_AR_TERM = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DsFrmCashier1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=TireMate_04"
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel4.Controls.Add(Me.NumAmount)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.TxtDate)
        Me.Panel4.Controls.Add(Me.TxtRef)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(657, 31)
        Me.Panel4.TabIndex = 5
        '
        'NumAmount
        '
        Me.NumAmount.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.NumAmount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumAmount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumAmount.DecimalDigits = 2
        Me.NumAmount.DefaultSendValue = False
        Me.NumAmount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumAmount.Image = CType(resources.GetObject("NumAmount.Image"), System.Drawing.Image)
        Me.NumAmount.Location = New System.Drawing.Point(479, 6)
        Me.NumAmount.Maxlength = 10
        Me.NumAmount.MinusColor = System.Drawing.Color.Empty
        Me.NumAmount.Name = "NumAmount"
        Me.NumAmount.ReadOnly = True
        Me.NumAmount.Size = New System.Drawing.Size(93, 21)
        Me.NumAmount.TabIndex = 233
        Me.NumAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.NumAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label14.Location = New System.Drawing.Point(433, 4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 21)
        Me.Label14.TabIndex = 156
        Me.Label14.Text = "Amount"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDate
        '
        Me.TxtDate.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.TxtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtDate.Location = New System.Drawing.Point(305, 6)
        Me.TxtDate.Name = "TxtDate"
        Me.TxtDate.ReadOnly = True
        Me.TxtDate.Size = New System.Drawing.Size(77, 20)
        Me.TxtDate.TabIndex = 155
        Me.TxtDate.TabStop = False
        Me.TxtDate.Text = ""
        Me.TxtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtRef
        '
        Me.TxtRef.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.TxtRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtRef.Location = New System.Drawing.Point(133, 6)
        Me.TxtRef.Name = "TxtRef"
        Me.TxtRef.ReadOnly = True
        Me.TxtRef.Size = New System.Drawing.Size(92, 20)
        Me.TxtRef.TabIndex = 154
        Me.TxtRef.TabStop = False
        Me.TxtRef.Text = ""
        Me.TxtRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(84, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 21)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "Ref No."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(271, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 21)
        Me.Label3.TabIndex = 152
        Me.Label3.Text = "Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(10, 299)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(128, 24)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnSaveAndPrint
        '
        Me.BtnSaveAndPrint.Location = New System.Drawing.Point(517, 299)
        Me.BtnSaveAndPrint.Name = "BtnSaveAndPrint"
        Me.BtnSaveAndPrint.Size = New System.Drawing.Size(128, 24)
        Me.BtnSaveAndPrint.TabIndex = 1
        Me.BtnSaveAndPrint.Text = "Save And Print"
        '
        'BtnPaymentOnHold
        '
        Me.BtnPaymentOnHold.Location = New System.Drawing.Point(179, 299)
        Me.BtnPaymentOnHold.Name = "BtnPaymentOnHold"
        Me.BtnPaymentOnHold.Size = New System.Drawing.Size(128, 24)
        Me.BtnPaymentOnHold.TabIndex = 3
        Me.BtnPaymentOnHold.Text = "Payment On Hold"
        '
        'BtnSaveNoPrint
        '
        Me.BtnSaveNoPrint.Location = New System.Drawing.Point(348, 299)
        Me.BtnSaveNoPrint.Name = "BtnSaveNoPrint"
        Me.BtnSaveNoPrint.Size = New System.Drawing.Size(128, 24)
        Me.BtnSaveNoPrint.TabIndex = 2
        Me.BtnSaveNoPrint.Text = "Save No Print"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.NumDownPaymentBalance)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.NumDownPayment)
        Me.Panel3.Controls.Add(Me.ChkDownPayment)
        Me.Panel3.Controls.Add(Me.GroupBox12)
        Me.Panel3.Controls.Add(Me.NumOverPaymentBalance)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.GroupBox10)
        Me.Panel3.Controls.Add(Me.NumOverPayment)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.ChkOverPayment)
        Me.Panel3.Controls.Add(Me.GroupBox9)
        Me.Panel3.Controls.Add(Me.BtnDetail)
        Me.Panel3.Controls.Add(Me.NumMonth)
        Me.Panel3.Controls.Add(Me.NumYear)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.DteDueDate)
        Me.Panel3.Controls.Add(Me.NumBalance)
        Me.Panel3.Controls.Add(Me.NumARAmount)
        Me.Panel3.Controls.Add(Me.NumChargeAmount)
        Me.Panel3.Controls.Add(Me.NumCheckAmount)
        Me.Panel3.Controls.Add(Me.NumChangeDue)
        Me.Panel3.Controls.Add(Me.NumCashRendered)
        Me.Panel3.Controls.Add(Me.ChkCheck)
        Me.Panel3.Controls.Add(Me.ChkCash)
        Me.Panel3.Controls.Add(Me.TXTCardNo)
        Me.Panel3.Controls.Add(Me.TxtAuthNo)
        Me.Panel3.Controls.Add(Me.TxtCheckNo)
        Me.Panel3.Controls.Add(Me.GroupBox8)
        Me.Panel3.Controls.Add(Me.GroupBox7)
        Me.Panel3.Controls.Add(Me.GroupBox6)
        Me.Panel3.Controls.Add(Me.GroupBox5)
        Me.Panel3.Controls.Add(Me.GroupBox4)
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.CmbCCType)
        Me.Panel3.Controls.Add(Me.ChkCreditCard)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.LblCardNo)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.CmbARTerms)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.ChkAR)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel3.Location = New System.Drawing.Point(0, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(656, 255)
        Me.Panel3.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label20.Location = New System.Drawing.Point(547, 39)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 19)
        Me.Label20.TabIndex = 367
        Me.Label20.Text = "Amount"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumDownPaymentBalance
        '
        Me.NumDownPaymentBalance.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.NumDownPaymentBalance.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDownPaymentBalance.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumDownPaymentBalance.DecimalDigits = 2
        Me.NumDownPaymentBalance.DefaultSendValue = False
        Me.NumDownPaymentBalance.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDownPaymentBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumDownPaymentBalance.Image = CType(resources.GetObject("NumDownPaymentBalance.Image"), System.Drawing.Image)
        Me.NumDownPaymentBalance.Location = New System.Drawing.Point(544, 129)
        Me.NumDownPaymentBalance.Maxlength = 10
        Me.NumDownPaymentBalance.MinusColor = System.Drawing.Color.Empty
        Me.NumDownPaymentBalance.Name = "NumDownPaymentBalance"
        Me.NumDownPaymentBalance.ReadOnly = True
        Me.NumDownPaymentBalance.Size = New System.Drawing.Size(111, 22)
        Me.NumDownPaymentBalance.TabIndex = 366
        Me.NumDownPaymentBalance.TabStop = False
        Me.NumDownPaymentBalance.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.NumDownPaymentBalance.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(549, 99)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 27)
        Me.Label19.TabIndex = 365
        Me.Label19.Text = "Down Payment Balance"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumDownPayment
        '
        Me.NumDownPayment.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDownPayment.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumDownPayment.DecimalDigits = 2
        Me.NumDownPayment.DefaultSendValue = False
        Me.NumDownPayment.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDownPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumDownPayment.Image = CType(resources.GetObject("NumDownPayment.Image"), System.Drawing.Image)
        Me.NumDownPayment.Location = New System.Drawing.Point(546, 58)
        Me.NumDownPayment.Maxlength = 10
        Me.NumDownPayment.MinusColor = System.Drawing.Color.Empty
        Me.NumDownPayment.Name = "NumDownPayment"
        Me.NumDownPayment.Size = New System.Drawing.Size(106, 22)
        Me.NumDownPayment.TabIndex = 364
        Me.NumDownPayment.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDownPayment.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'ChkDownPayment
        '
        Me.ChkDownPayment.BackColor = System.Drawing.Color.Transparent
        Me.ChkDownPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkDownPayment.Location = New System.Drawing.Point(552, 9)
        Me.ChkDownPayment.Name = "ChkDownPayment"
        Me.ChkDownPayment.Size = New System.Drawing.Size(96, 19)
        Me.ChkDownPayment.TabIndex = 363
        Me.ChkDownPayment.Text = "Down Payment"
        '
        'GroupBox12
        '
        Me.GroupBox12.BackColor = System.Drawing.Color.White
        Me.GroupBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox12.Location = New System.Drawing.Point(538, 1)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(1, 183)
        Me.GroupBox12.TabIndex = 362
        Me.GroupBox12.TabStop = False
        '
        'NumOverPaymentBalance
        '
        Me.NumOverPaymentBalance.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.NumOverPaymentBalance.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumOverPaymentBalance.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumOverPaymentBalance.DecimalDigits = 2
        Me.NumOverPaymentBalance.DefaultSendValue = False
        Me.NumOverPaymentBalance.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumOverPaymentBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumOverPaymentBalance.Image = CType(resources.GetObject("NumOverPaymentBalance.Image"), System.Drawing.Image)
        Me.NumOverPaymentBalance.Location = New System.Drawing.Point(426, 128)
        Me.NumOverPaymentBalance.Maxlength = 10
        Me.NumOverPaymentBalance.MinusColor = System.Drawing.Color.Empty
        Me.NumOverPaymentBalance.Name = "NumOverPaymentBalance"
        Me.NumOverPaymentBalance.ReadOnly = True
        Me.NumOverPaymentBalance.Size = New System.Drawing.Size(111, 22)
        Me.NumOverPaymentBalance.TabIndex = 357
        Me.NumOverPaymentBalance.TabStop = False
        Me.NumOverPaymentBalance.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.NumOverPaymentBalance.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(431, 98)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 27)
        Me.Label18.TabIndex = 356
        Me.Label18.Text = "Over Payment Balance"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.White
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox10.Location = New System.Drawing.Point(424, 184)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(248, 1)
        Me.GroupBox10.TabIndex = 355
        Me.GroupBox10.TabStop = False
        '
        'NumOverPayment
        '
        Me.NumOverPayment.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumOverPayment.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumOverPayment.DecimalDigits = 2
        Me.NumOverPayment.DefaultSendValue = False
        Me.NumOverPayment.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumOverPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumOverPayment.Image = CType(resources.GetObject("NumOverPayment.Image"), System.Drawing.Image)
        Me.NumOverPayment.Location = New System.Drawing.Point(428, 57)
        Me.NumOverPayment.Maxlength = 10
        Me.NumOverPayment.MinusColor = System.Drawing.Color.Empty
        Me.NumOverPayment.Name = "NumOverPayment"
        Me.NumOverPayment.Size = New System.Drawing.Size(106, 22)
        Me.NumOverPayment.TabIndex = 353
        Me.NumOverPayment.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumOverPayment.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.Location = New System.Drawing.Point(426, 39)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 19)
        Me.Label17.TabIndex = 354
        Me.Label17.Text = "Amount"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkOverPayment
        '
        Me.ChkOverPayment.BackColor = System.Drawing.Color.Transparent
        Me.ChkOverPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkOverPayment.Location = New System.Drawing.Point(434, 8)
        Me.ChkOverPayment.Name = "ChkOverPayment"
        Me.ChkOverPayment.Size = New System.Drawing.Size(96, 19)
        Me.ChkOverPayment.TabIndex = 352
        Me.ChkOverPayment.Text = "Over Payment"
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.White
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox9.Location = New System.Drawing.Point(422, 2)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(1, 253)
        Me.GroupBox9.TabIndex = 351
        Me.GroupBox9.TabStop = False
        '
        'BtnDetail
        '
        Me.BtnDetail.Location = New System.Drawing.Point(301, 198)
        Me.BtnDetail.Name = "BtnDetail"
        Me.BtnDetail.Size = New System.Drawing.Size(108, 21)
        Me.BtnDetail.TabIndex = 350
        Me.BtnDetail.Text = "A/R Amount Detail"
        '
        'NumMonth
        '
        Me.NumMonth.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.NumMonth.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.NumMonth.DecimalDigits = 0
        Me.NumMonth.FormatString = "##"
        Me.NumMonth.Location = New System.Drawing.Point(168, 184)
        Me.NumMonth.MaxLength = 2
        Me.NumMonth.Name = "NumMonth"
        Me.NumMonth.Size = New System.Drawing.Size(29, 20)
        Me.NumMonth.TabIndex = 26
        Me.NumMonth.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.NumMonth.Value = CType(0, Short)
        Me.NumMonth.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int16
        '
        'NumYear
        '
        Me.NumYear.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.NumYear.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.NumYear.DecimalDigits = 0
        Me.NumYear.FormatString = "####"
        Me.NumYear.Location = New System.Drawing.Point(207, 184)
        Me.NumYear.MaxLength = 4
        Me.NumYear.Name = "NumYear"
        Me.NumYear.Size = New System.Drawing.Size(55, 20)
        Me.NumYear.TabIndex = 27
        Me.NumYear.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.NumYear.Value = CType(0, Short)
        Me.NumYear.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int16
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(193, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 19)
        Me.Label8.TabIndex = 349
        Me.Label8.Text = "/"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DteDueDate
        '
        Me.DteDueDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DteDueDate.BorderColor = System.Drawing.Color.Empty
        Me.DteDueDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteDueDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteDueDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteDueDate.EditableSal = True
        Me.DteDueDate.Image = CType(resources.GetObject("DteDueDate.Image"), System.Drawing.Image)
        Me.DteDueDate.Location = New System.Drawing.Point(302, 146)
        Me.DteDueDate.MaxValue = CType(2500, Short)
        Me.DteDueDate.MinValue = CType(1800, Short)
        Me.DteDueDate.Name = "DteDueDate"
        Me.DteDueDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteDueDate.Sal_Mali = Nothing
        Me.DteDueDate.ShowButton = True
        Me.DteDueDate.Size = New System.Drawing.Size(102, 23)
        Me.DteDueDate.TabIndex = 31
        Me.DteDueDate.VisualStyle = False
        '
        'NumBalance
        '
        Me.NumBalance.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.NumBalance.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumBalance.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumBalance.DecimalDigits = 2
        Me.NumBalance.DefaultSendValue = False
        Me.NumBalance.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumBalance.Image = CType(resources.GetObject("NumBalance.Image"), System.Drawing.Image)
        Me.NumBalance.Location = New System.Drawing.Point(480, 221)
        Me.NumBalance.Maxlength = 10
        Me.NumBalance.MinusColor = System.Drawing.Color.Empty
        Me.NumBalance.Name = "NumBalance"
        Me.NumBalance.ReadOnly = True
        Me.NumBalance.Size = New System.Drawing.Size(111, 22)
        Me.NumBalance.TabIndex = 234
        Me.NumBalance.TabStop = False
        Me.NumBalance.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.NumBalance.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumARAmount
        '
        Me.NumARAmount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumARAmount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumARAmount.DecimalDigits = 2
        Me.NumARAmount.DefaultSendValue = False
        Me.NumARAmount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumARAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumARAmount.Image = CType(resources.GetObject("NumARAmount.Image"), System.Drawing.Image)
        Me.NumARAmount.Location = New System.Drawing.Point(298, 57)
        Me.NumARAmount.Maxlength = 10
        Me.NumARAmount.MinusColor = System.Drawing.Color.Empty
        Me.NumARAmount.Name = "NumARAmount"
        Me.NumARAmount.Size = New System.Drawing.Size(120, 22)
        Me.NumARAmount.TabIndex = 29
        Me.NumARAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumARAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumChargeAmount
        '
        Me.NumChargeAmount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumChargeAmount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumChargeAmount.DecimalDigits = 2
        Me.NumChargeAmount.DefaultSendValue = False
        Me.NumChargeAmount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumChargeAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumChargeAmount.Image = CType(resources.GetObject("NumChargeAmount.Image"), System.Drawing.Image)
        Me.NumChargeAmount.Location = New System.Drawing.Point(154, 58)
        Me.NumChargeAmount.Maxlength = 10
        Me.NumChargeAmount.MinusColor = System.Drawing.Color.Empty
        Me.NumChargeAmount.Name = "NumChargeAmount"
        Me.NumChargeAmount.Size = New System.Drawing.Size(120, 22)
        Me.NumChargeAmount.TabIndex = 23
        Me.NumChargeAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumChargeAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumCheckAmount
        '
        Me.NumCheckAmount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumCheckAmount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumCheckAmount.DecimalDigits = 2
        Me.NumCheckAmount.DefaultSendValue = False
        Me.NumCheckAmount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumCheckAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumCheckAmount.Image = CType(resources.GetObject("NumCheckAmount.Image"), System.Drawing.Image)
        Me.NumCheckAmount.Location = New System.Drawing.Point(9, 173)
        Me.NumCheckAmount.Maxlength = 10
        Me.NumCheckAmount.MinusColor = System.Drawing.Color.Empty
        Me.NumCheckAmount.Name = "NumCheckAmount"
        Me.NumCheckAmount.Size = New System.Drawing.Size(120, 22)
        Me.NumCheckAmount.TabIndex = 21
        Me.NumCheckAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumCheckAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumChangeDue
        '
        Me.NumChangeDue.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumChangeDue.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumChangeDue.DecimalDigits = 2
        Me.NumChangeDue.DefaultSendValue = False
        Me.NumChangeDue.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumChangeDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumChangeDue.Image = CType(resources.GetObject("NumChangeDue.Image"), System.Drawing.Image)
        Me.NumChangeDue.Location = New System.Drawing.Point(9, 112)
        Me.NumChangeDue.Maxlength = 10
        Me.NumChangeDue.MinusColor = System.Drawing.Color.Empty
        Me.NumChangeDue.Name = "NumChangeDue"
        Me.NumChangeDue.Size = New System.Drawing.Size(120, 22)
        Me.NumChangeDue.TabIndex = 20
        Me.NumChangeDue.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumChangeDue.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumCashRendered
        '
        Me.NumCashRendered.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumCashRendered.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumCashRendered.DecimalDigits = 2
        Me.NumCashRendered.DefaultSendValue = False
        Me.NumCashRendered.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumCashRendered.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumCashRendered.Image = CType(resources.GetObject("NumCashRendered.Image"), System.Drawing.Image)
        Me.NumCashRendered.Location = New System.Drawing.Point(9, 64)
        Me.NumCashRendered.Maxlength = 10
        Me.NumCashRendered.MinusColor = System.Drawing.Color.Empty
        Me.NumCashRendered.Name = "NumCashRendered"
        Me.NumCashRendered.Size = New System.Drawing.Size(120, 22)
        Me.NumCashRendered.TabIndex = 19
        Me.NumCashRendered.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumCashRendered.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'ChkCheck
        '
        Me.ChkCheck.BackColor = System.Drawing.Color.Transparent
        Me.ChkCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkCheck.Location = New System.Drawing.Point(70, 8)
        Me.ChkCheck.Name = "ChkCheck"
        Me.ChkCheck.Size = New System.Drawing.Size(59, 19)
        Me.ChkCheck.TabIndex = 1
        Me.ChkCheck.Text = "Check"
        '
        'ChkCash
        '
        Me.ChkCash.BackColor = System.Drawing.Color.Transparent
        Me.ChkCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkCash.Location = New System.Drawing.Point(9, 8)
        Me.ChkCash.Name = "ChkCash"
        Me.ChkCash.Size = New System.Drawing.Size(49, 19)
        Me.ChkCash.TabIndex = 0
        Me.ChkCash.Text = "Cash"
        '
        'TXTCardNo
        '
        Me.TXTCardNo.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TXTCardNo.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TXTCardNo.Enabled = False
        Me.TXTCardNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TXTCardNo.Location = New System.Drawing.Point(143, 141)
        Me.TXTCardNo.MaxLength = 20
        Me.TXTCardNo.Name = "TXTCardNo"
        Me.TXTCardNo.Size = New System.Drawing.Size(140, 20)
        Me.TXTCardNo.TabIndex = 25
        Me.TXTCardNo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtAuthNo
        '
        Me.TxtAuthNo.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtAuthNo.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtAuthNo.Enabled = False
        Me.TxtAuthNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtAuthNo.Location = New System.Drawing.Point(163, 227)
        Me.TxtAuthNo.MaxLength = 20
        Me.TxtAuthNo.Name = "TxtAuthNo"
        Me.TxtAuthNo.Size = New System.Drawing.Size(100, 20)
        Me.TxtAuthNo.TabIndex = 28
        Me.TxtAuthNo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtCheckNo
        '
        Me.TxtCheckNo.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtCheckNo.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtCheckNo.Enabled = False
        Me.TxtCheckNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtCheckNo.Location = New System.Drawing.Point(10, 224)
        Me.TxtCheckNo.MaxLength = 20
        Me.TxtCheckNo.Name = "TxtCheckNo"
        Me.TxtCheckNo.Size = New System.Drawing.Size(100, 20)
        Me.TxtCheckNo.TabIndex = 22
        Me.TxtCheckNo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.White
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox8.Location = New System.Drawing.Point(655, 2)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(1, 252)
        Me.GroupBox8.TabIndex = 226
        Me.GroupBox8.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox7.Location = New System.Drawing.Point(0, 2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1, 252)
        Me.GroupBox7.TabIndex = 225
        Me.GroupBox7.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox6.Location = New System.Drawing.Point(0, 254)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(656, 1)
        Me.GroupBox6.TabIndex = 18
        Me.GroupBox6.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(656, 2)
        Me.GroupBox5.TabIndex = 223
        Me.GroupBox5.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox4.Location = New System.Drawing.Point(-68, 142)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(205, 1)
        Me.GroupBox4.TabIndex = 222
        Me.GroupBox4.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox3.Location = New System.Drawing.Point(289, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1, 253)
        Me.GroupBox3.TabIndex = 221
        Me.GroupBox3.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(135, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1, 253)
        Me.GroupBox2.TabIndex = 220
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(-13, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(700, 1)
        Me.GroupBox1.TabIndex = 219
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(9, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 213
        Me.Label4.Text = "Change Due"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(9, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 217
        Me.Label5.Text = "Check No"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 19)
        Me.Label2.TabIndex = 211
        Me.Label2.Text = "Cash Rendered"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(10, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.TabIndex = 215
        Me.Label6.Text = "Check Amount"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbCCType
        '
        Me.CmbCCType.DataSource = Me.DsFrmCashier1.bas_cc_type
        Me.CmbCCType.DisplayMember = "cc_type_desc"
        Me.CmbCCType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCCType.Enabled = False
        Me.CmbCCType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmbCCType.ItemHeight = 13
        Me.CmbCCType.Location = New System.Drawing.Point(163, 100)
        Me.CmbCCType.Name = "CmbCCType"
        Me.CmbCCType.Size = New System.Drawing.Size(100, 21)
        Me.CmbCCType.TabIndex = 24
        Me.CmbCCType.ValueMember = "cc_type"
        '
        'DsFrmCashier1
        '
        Me.DsFrmCashier1.DataSetName = "DSFrmCashier"
        Me.DsFrmCashier1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'ChkCreditCard
        '
        Me.ChkCreditCard.BackColor = System.Drawing.Color.Transparent
        Me.ChkCreditCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkCreditCard.Location = New System.Drawing.Point(169, 8)
        Me.ChkCreditCard.Name = "ChkCreditCard"
        Me.ChkCreditCard.Size = New System.Drawing.Size(83, 19)
        Me.ChkCreditCard.TabIndex = 2
        Me.ChkCreditCard.Text = "Credit Card"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(163, 209)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 19)
        Me.Label11.TabIndex = 206
        Me.Label11.Text = "Auth. No."
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(163, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 19)
        Me.Label7.TabIndex = 204
        Me.Label7.Text = "Exp Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCardNo
        '
        Me.LblCardNo.BackColor = System.Drawing.Color.Transparent
        Me.LblCardNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblCardNo.Location = New System.Drawing.Point(163, 123)
        Me.LblCardNo.Name = "LblCardNo"
        Me.LblCardNo.Size = New System.Drawing.Size(100, 19)
        Me.LblCardNo.TabIndex = 202
        Me.LblCardNo.Text = "Card No"
        Me.LblCardNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(163, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 19)
        Me.Label10.TabIndex = 199
        Me.Label10.Text = "Charge Amount"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(485, 201)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 22)
        Me.Label16.TabIndex = 196
        Me.Label16.Text = "Balance"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.Location = New System.Drawing.Point(305, 127)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 19)
        Me.Label15.TabIndex = 195
        Me.Label15.Text = "Due Date"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbARTerms
        '
        Me.CmbARTerms.DataSource = Me.DsFrmCashier1.GL_TAB_AR_TERM
        Me.CmbARTerms.DisplayMember = "AR_terms"
        Me.CmbARTerms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbARTerms.Enabled = False
        Me.CmbARTerms.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmbARTerms.ItemHeight = 13
        Me.CmbARTerms.Location = New System.Drawing.Point(295, 102)
        Me.CmbARTerms.Name = "CmbARTerms"
        Me.CmbARTerms.Size = New System.Drawing.Size(117, 21)
        Me.CmbARTerms.TabIndex = 30
        Me.CmbARTerms.ValueMember = "AR_terms"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label12.Location = New System.Drawing.Point(303, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 19)
        Me.Label12.TabIndex = 192
        Me.Label12.Text = "A/R Terms"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(300, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 19)
        Me.Label13.TabIndex = 190
        Me.Label13.Text = "A/R Amount"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkAR
        '
        Me.ChkAR.BackColor = System.Drawing.Color.Transparent
        Me.ChkAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkAR.Location = New System.Drawing.Point(324, 8)
        Me.ChkAR.Name = "ChkAR"
        Me.ChkAR.Size = New System.Drawing.Size(47, 19)
        Me.ChkAR.TabIndex = 3
        Me.ChkAR.Text = "A/R"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(163, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 19)
        Me.Label9.TabIndex = 201
        Me.Label9.Text = "C.C. Type"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cc_type, cc_type_desc FROM bas_cc_type"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAbas_cc_type
        '
        Me.DAbas_cc_type.SelectCommand = Me.SqlSelectCommand1
        Me.DAbas_cc_type.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_cc_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cc_type", "cc_type"), New System.Data.Common.DataColumnMapping("cc_type_desc", "cc_type_desc")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT GL_payment_deposit.ID_payment, GL_payment_deposit.id_service_center, GL_pa" & _
        "yment_deposit.refrence_no, GL_payment_deposit.refer_type, GL_payment_deposit.pay" & _
        "ment_type, GL_payment_deposit.payment_amount, GL_payment_cash.cash_rendered, GL_" & _
        "payment_cash.change_due, GL_payment_check.check_no, GL_payment_check.check_date," & _
        " GL_payment_AR.AR_terms, GL_payment_AR.AR_due_date, GL_payment_credit.cc_type, G" & _
        "L_payment_credit.cc_card_no, GL_payment_credit.cc_expire_date_year, GL_payment_c" & _
        "redit.cc_expire_date_month, GL_payment_credit.cc_auth_no FROM GL_payment_deposit" & _
        " LEFT OUTER JOIN GL_payment_credit ON GL_payment_deposit.ID_payment = GL_payment" & _
        "_credit.ID_payment LEFT OUTER JOIN GL_payment_AR ON GL_payment_deposit.ID_paymen" & _
        "t = GL_payment_AR.ID_payment LEFT OUTER JOIN GL_payment_check ON GL_payment_depo" & _
        "sit.ID_payment = GL_payment_check.ID_payment LEFT OUTER JOIN GL_payment_cash ON " & _
        "GL_payment_deposit.ID_payment = GL_payment_cash.ID_payment WHERE (GL_payment_dep" & _
        "osit.refer_type = '1') AND (GL_payment_deposit.id_service_center = @id_service_c" & _
        "enter)"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO GL_payment_deposit(id_service_center, refrence_no, refer_type, paymen" & _
        "t_type, payment_amount) VALUES (@id_service_center, @refrence_no, @refer_type, @" & _
        "payment_type, @payment_amount); SELECT ID_payment, id_service_center, refrence_n" & _
        "o, refer_type, payment_type, payment_amount FROM GL_payment_deposit WHERE (ID_pa" & _
        "yment = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 6, "refrence_no"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE GL_payment_deposit SET id_service_center = @id_service_center, refrence_no" & _
        " = @refrence_no, refer_type = @refer_type, payment_type = @payment_type, payment" & _
        "_amount = @payment_amount WHERE (ID_payment = @Original_ID_payment) AND (id_serv" & _
        "ice_center = @Original_id_service_center OR @Original_id_service_center IS NULL " & _
        "AND id_service_center IS NULL) AND (payment_amount = @Original_payment_amount OR" & _
        " @Original_payment_amount IS NULL AND payment_amount IS NULL) AND (payment_type " & _
        "= @Original_payment_type OR @Original_payment_type IS NULL AND payment_type IS N" & _
        "ULL) AND (refer_type = @Original_refer_type OR @Original_refer_type IS NULL AND " & _
        "refer_type IS NULL) AND (refrence_no = @Original_refrence_no OR @Original_refren" & _
        "ce_no IS NULL AND refrence_no IS NULL); SELECT ID_payment, id_service_center, re" & _
        "frence_no, refer_type, payment_type, payment_amount FROM GL_payment_deposit WHER" & _
        "E (ID_payment = @ID_payment)"
        Me.SqlUpdateCommand2.Connection = Me.Cnn
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 6, "refrence_no"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refer_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refer_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refrence_no", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_payment", System.Data.SqlDbType.Int, 4, "ID_payment"))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM GL_payment_deposit WHERE (ID_payment = @Original_ID_payment) AND (id_" & _
        "service_center = @Original_id_service_center OR @Original_id_service_center IS N" & _
        "ULL AND id_service_center IS NULL) AND (payment_amount = @Original_payment_amoun" & _
        "t OR @Original_payment_amount IS NULL AND payment_amount IS NULL) AND (payment_t" & _
        "ype = @Original_payment_type OR @Original_payment_type IS NULL AND payment_type " & _
        "IS NULL) AND (refer_type = @Original_refer_type OR @Original_refer_type IS NULL " & _
        "AND refer_type IS NULL) AND (refrence_no = @Original_refrence_no OR @Original_re" & _
        "frence_no IS NULL AND refrence_no IS NULL)"
        Me.SqlDeleteCommand2.Connection = Me.Cnn
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refer_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refer_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refrence_no", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAGL_payment_deposit
        '
        Me.DAGL_payment_deposit.DeleteCommand = Me.SqlDeleteCommand2
        Me.DAGL_payment_deposit.InsertCommand = Me.SqlInsertCommand2
        Me.DAGL_payment_deposit.SelectCommand = Me.SqlSelectCommand4
        Me.DAGL_payment_deposit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("refer_type", "refer_type"), New System.Data.Common.DataColumnMapping("payment_type", "payment_type"), New System.Data.Common.DataColumnMapping("payment_amount", "payment_amount")})})
        Me.DAGL_payment_deposit.UpdateCommand = Me.SqlUpdateCommand2
        '
        'CmdGeneralForReader
        '
        Me.CmdGeneralForReader.Connection = Me.CnnForReader
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT AR_terms, KIND_AR, ST_NET_DUE_IN, ST_DISCOUNT_PERCENTAGE, ST_IF_PAY_WITHIN" & _
        "_DAYS, DD_NET_DUE_BEFORE, DD_IF_ISSUED_WITHIN_DAYS, DD_DISCOUNT_PERCENTAGE, DD_I" & _
        "F_PAY_WITHIN_DAYS, MP_NO_OF_PAYMENT, MP_BEFORE_DAY FROM GL_TAB_AR_TERM"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO GL_TAB_AR_TERM(AR_terms, KIND_AR, ST_NET_DUE_IN, ST_DISCOUNT_PERCENTA" & _
        "GE, ST_IF_PAY_WITHIN_DAYS, DD_NET_DUE_BEFORE, DD_IF_ISSUED_WITHIN_DAYS, DD_DISCO" & _
        "UNT_PERCENTAGE, DD_IF_PAY_WITHIN_DAYS, MP_NO_OF_PAYMENT, MP_BEFORE_DAY) VALUES (" & _
        "@AR_terms, @KIND_AR, @ST_NET_DUE_IN, @ST_DISCOUNT_PERCENTAGE, @ST_IF_PAY_WITHIN_" & _
        "DAYS, @DD_NET_DUE_BEFORE, @DD_IF_ISSUED_WITHIN_DAYS, @DD_DISCOUNT_PERCENTAGE, @D" & _
        "D_IF_PAY_WITHIN_DAYS, @MP_NO_OF_PAYMENT, @MP_BEFORE_DAY); SELECT AR_terms, KIND_" & _
        "AR, ST_NET_DUE_IN, ST_DISCOUNT_PERCENTAGE, ST_IF_PAY_WITHIN_DAYS, DD_NET_DUE_BEF" & _
        "ORE, DD_IF_ISSUED_WITHIN_DAYS, DD_DISCOUNT_PERCENTAGE, DD_IF_PAY_WITHIN_DAYS, MP" & _
        "_NO_OF_PAYMENT, MP_BEFORE_DAY FROM GL_TAB_AR_TERM WHERE (AR_terms = @AR_terms)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_terms", System.Data.SqlDbType.VarChar, 10, "AR_terms"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@KIND_AR", System.Data.SqlDbType.SmallInt, 2, "KIND_AR"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_NET_DUE_IN", System.Data.SqlDbType.SmallInt, 2, "ST_NET_DUE_IN"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ST_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "ST_IF_PAY_WITHIN_DAYS"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_NET_DUE_BEFORE", System.Data.SqlDbType.SmallInt, 2, "DD_NET_DUE_BEFORE"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_IF_ISSUED_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "DD_IF_ISSUED_WITHIN_DAYS"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DD_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "DD_IF_PAY_WITHIN_DAYS"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_NO_OF_PAYMENT", System.Data.SqlDbType.SmallInt, 2, "MP_NO_OF_PAYMENT"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_BEFORE_DAY", System.Data.SqlDbType.SmallInt, 2, "MP_BEFORE_DAY"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE GL_TAB_AR_TERM SET AR_terms = @AR_terms, KIND_AR = @KIND_AR, ST_NET_DUE_IN" & _
        " = @ST_NET_DUE_IN, ST_DISCOUNT_PERCENTAGE = @ST_DISCOUNT_PERCENTAGE, ST_IF_PAY_W" & _
        "ITHIN_DAYS = @ST_IF_PAY_WITHIN_DAYS, DD_NET_DUE_BEFORE = @DD_NET_DUE_BEFORE, DD_" & _
        "IF_ISSUED_WITHIN_DAYS = @DD_IF_ISSUED_WITHIN_DAYS, DD_DISCOUNT_PERCENTAGE = @DD_" & _
        "DISCOUNT_PERCENTAGE, DD_IF_PAY_WITHIN_DAYS = @DD_IF_PAY_WITHIN_DAYS, MP_NO_OF_PA" & _
        "YMENT = @MP_NO_OF_PAYMENT, MP_BEFORE_DAY = @MP_BEFORE_DAY WHERE (AR_terms = @Ori" & _
        "ginal_AR_terms) AND (DD_DISCOUNT_PERCENTAGE = @Original_DD_DISCOUNT_PERCENTAGE O" & _
        "R @Original_DD_DISCOUNT_PERCENTAGE IS NULL AND DD_DISCOUNT_PERCENTAGE IS NULL) A" & _
        "ND (DD_IF_ISSUED_WITHIN_DAYS = @Original_DD_IF_ISSUED_WITHIN_DAYS OR @Original_D" & _
        "D_IF_ISSUED_WITHIN_DAYS IS NULL AND DD_IF_ISSUED_WITHIN_DAYS IS NULL) AND (DD_IF" & _
        "_PAY_WITHIN_DAYS = @Original_DD_IF_PAY_WITHIN_DAYS OR @Original_DD_IF_PAY_WITHIN" & _
        "_DAYS IS NULL AND DD_IF_PAY_WITHIN_DAYS IS NULL) AND (DD_NET_DUE_BEFORE = @Origi" & _
        "nal_DD_NET_DUE_BEFORE OR @Original_DD_NET_DUE_BEFORE IS NULL AND DD_NET_DUE_BEFO" & _
        "RE IS NULL) AND (KIND_AR = @Original_KIND_AR OR @Original_KIND_AR IS NULL AND KI" & _
        "ND_AR IS NULL) AND (MP_BEFORE_DAY = @Original_MP_BEFORE_DAY OR @Original_MP_BEFO" & _
        "RE_DAY IS NULL AND MP_BEFORE_DAY IS NULL) AND (MP_NO_OF_PAYMENT = @Original_MP_N" & _
        "O_OF_PAYMENT OR @Original_MP_NO_OF_PAYMENT IS NULL AND MP_NO_OF_PAYMENT IS NULL)" & _
        " AND (ST_DISCOUNT_PERCENTAGE = @Original_ST_DISCOUNT_PERCENTAGE OR @Original_ST_" & _
        "DISCOUNT_PERCENTAGE IS NULL AND ST_DISCOUNT_PERCENTAGE IS NULL) AND (ST_IF_PAY_W" & _
        "ITHIN_DAYS = @Original_ST_IF_PAY_WITHIN_DAYS OR @Original_ST_IF_PAY_WITHIN_DAYS " & _
        "IS NULL AND ST_IF_PAY_WITHIN_DAYS IS NULL) AND (ST_NET_DUE_IN = @Original_ST_NET" & _
        "_DUE_IN OR @Original_ST_NET_DUE_IN IS NULL AND ST_NET_DUE_IN IS NULL); SELECT AR" & _
        "_terms, KIND_AR, ST_NET_DUE_IN, ST_DISCOUNT_PERCENTAGE, ST_IF_PAY_WITHIN_DAYS, D" & _
        "D_NET_DUE_BEFORE, DD_IF_ISSUED_WITHIN_DAYS, DD_DISCOUNT_PERCENTAGE, DD_IF_PAY_WI" & _
        "THIN_DAYS, MP_NO_OF_PAYMENT, MP_BEFORE_DAY FROM GL_TAB_AR_TERM WHERE (AR_terms =" & _
        " @AR_terms)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_terms", System.Data.SqlDbType.VarChar, 10, "AR_terms"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@KIND_AR", System.Data.SqlDbType.SmallInt, 2, "KIND_AR"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_NET_DUE_IN", System.Data.SqlDbType.SmallInt, 2, "ST_NET_DUE_IN"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ST_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "ST_IF_PAY_WITHIN_DAYS"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_NET_DUE_BEFORE", System.Data.SqlDbType.SmallInt, 2, "DD_NET_DUE_BEFORE"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_IF_ISSUED_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "DD_IF_ISSUED_WITHIN_DAYS"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DD_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "DD_IF_PAY_WITHIN_DAYS"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_NO_OF_PAYMENT", System.Data.SqlDbType.SmallInt, 2, "MP_NO_OF_PAYMENT"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_BEFORE_DAY", System.Data.SqlDbType.SmallInt, 2, "MP_BEFORE_DAY"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_terms", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_terms", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DD_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_IF_ISSUED_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_IF_ISSUED_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_IF_PAY_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_NET_DUE_BEFORE", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_NET_DUE_BEFORE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_KIND_AR", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "KIND_AR", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MP_BEFORE_DAY", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MP_BEFORE_DAY", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MP_NO_OF_PAYMENT", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MP_NO_OF_PAYMENT", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ST_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ST_IF_PAY_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_NET_DUE_IN", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ST_NET_DUE_IN", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM GL_TAB_AR_TERM WHERE (AR_terms = @Original_AR_terms) AND (DD_DISCOUNT" & _
        "_PERCENTAGE = @Original_DD_DISCOUNT_PERCENTAGE OR @Original_DD_DISCOUNT_PERCENTA" & _
        "GE IS NULL AND DD_DISCOUNT_PERCENTAGE IS NULL) AND (DD_IF_ISSUED_WITHIN_DAYS = @" & _
        "Original_DD_IF_ISSUED_WITHIN_DAYS OR @Original_DD_IF_ISSUED_WITHIN_DAYS IS NULL " & _
        "AND DD_IF_ISSUED_WITHIN_DAYS IS NULL) AND (DD_IF_PAY_WITHIN_DAYS = @Original_DD_" & _
        "IF_PAY_WITHIN_DAYS OR @Original_DD_IF_PAY_WITHIN_DAYS IS NULL AND DD_IF_PAY_WITH" & _
        "IN_DAYS IS NULL) AND (DD_NET_DUE_BEFORE = @Original_DD_NET_DUE_BEFORE OR @Origin" & _
        "al_DD_NET_DUE_BEFORE IS NULL AND DD_NET_DUE_BEFORE IS NULL) AND (KIND_AR = @Orig" & _
        "inal_KIND_AR OR @Original_KIND_AR IS NULL AND KIND_AR IS NULL) AND (MP_BEFORE_DA" & _
        "Y = @Original_MP_BEFORE_DAY OR @Original_MP_BEFORE_DAY IS NULL AND MP_BEFORE_DAY" & _
        " IS NULL) AND (MP_NO_OF_PAYMENT = @Original_MP_NO_OF_PAYMENT OR @Original_MP_NO_" & _
        "OF_PAYMENT IS NULL AND MP_NO_OF_PAYMENT IS NULL) AND (ST_DISCOUNT_PERCENTAGE = @" & _
        "Original_ST_DISCOUNT_PERCENTAGE OR @Original_ST_DISCOUNT_PERCENTAGE IS NULL AND " & _
        "ST_DISCOUNT_PERCENTAGE IS NULL) AND (ST_IF_PAY_WITHIN_DAYS = @Original_ST_IF_PAY" & _
        "_WITHIN_DAYS OR @Original_ST_IF_PAY_WITHIN_DAYS IS NULL AND ST_IF_PAY_WITHIN_DAY" & _
        "S IS NULL) AND (ST_NET_DUE_IN = @Original_ST_NET_DUE_IN OR @Original_ST_NET_DUE_" & _
        "IN IS NULL AND ST_NET_DUE_IN IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_terms", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_terms", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DD_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_IF_ISSUED_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_IF_ISSUED_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_IF_PAY_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_NET_DUE_BEFORE", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_NET_DUE_BEFORE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_KIND_AR", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "KIND_AR", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MP_BEFORE_DAY", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MP_BEFORE_DAY", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MP_NO_OF_PAYMENT", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MP_NO_OF_PAYMENT", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ST_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ST_IF_PAY_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_NET_DUE_IN", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ST_NET_DUE_IN", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAGL_TAB_AR_TERM
        '
        Me.DAGL_TAB_AR_TERM.DeleteCommand = Me.SqlDeleteCommand1
        Me.DAGL_TAB_AR_TERM.InsertCommand = Me.SqlInsertCommand1
        Me.DAGL_TAB_AR_TERM.SelectCommand = Me.SqlSelectCommand3
        Me.DAGL_TAB_AR_TERM.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_TAB_AR_TERM", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("AR_terms", "AR_terms"), New System.Data.Common.DataColumnMapping("KIND_AR", "KIND_AR"), New System.Data.Common.DataColumnMapping("ST_NET_DUE_IN", "ST_NET_DUE_IN"), New System.Data.Common.DataColumnMapping("ST_DISCOUNT_PERCENTAGE", "ST_DISCOUNT_PERCENTAGE"), New System.Data.Common.DataColumnMapping("ST_IF_PAY_WITHIN_DAYS", "ST_IF_PAY_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("DD_NET_DUE_BEFORE", "DD_NET_DUE_BEFORE"), New System.Data.Common.DataColumnMapping("DD_IF_ISSUED_WITHIN_DAYS", "DD_IF_ISSUED_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("DD_DISCOUNT_PERCENTAGE", "DD_DISCOUNT_PERCENTAGE"), New System.Data.Common.DataColumnMapping("DD_IF_PAY_WITHIN_DAYS", "DD_IF_PAY_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("MP_NO_OF_PAYMENT", "MP_NO_OF_PAYMENT"), New System.Data.Common.DataColumnMapping("MP_BEFORE_DAY", "MP_BEFORE_DAY")})})
        Me.DAGL_TAB_AR_TERM.UpdateCommand = Me.SqlUpdateCommand1
        '
        'FrmCashier
        '
        Me.AcceptButton = Me.BtnSaveAndPrint
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(657, 328)
        Me.Controls.Add(Me.BtnSaveNoPrint)
        Me.Controls.Add(Me.BtnPaymentOnHold)
        Me.Controls.Add(Me.BtnSaveAndPrint)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Location = New System.Drawing.Point(200, 200)
        Me.Name = "FrmCashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cashier"
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DsFrmCashier1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmWorkOrders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        CnnForReader.ConnectionString = PConnectionString
        ThisFormStatus = MainModule.WorkStates._ReadOnly

        DsFrmCashier1.Clear()
        DAbas_cc_type.Fill(DsFrmCashier1, "bas_cc_type")
        DAGL_TAB_AR_TERM.Fill(DsFrmCashier1, "GL_TAB_AR_TERM")
        DAGL_payment_deposit.SelectCommand.Parameters("@id_service_center").Value = TxtRef.Text
        DAGL_payment_deposit.Fill(DsFrmCashier1, "GL_payment_deposit")
        Call LoadCashierInformation()
        Call EnableDisableField()
        Call EnableDisableBtn()
        Call CalcBalance()
    End Sub
    Private Sub EnableDisableBtn()
        ChkCash.Enabled = False
        ChkCheck.Enabled = False
        ChkCreditCard.Enabled = False
        ChkAR.Enabled = False
        ChkOverPayment.Enabled = False
        NumOverPayment.Enabled = False
        ChkDownPayment.Enabled = False
        NumDownPayment.Enabled = False
        NumARAmount.Enabled = False
        TXTCardNo.Enabled = False
        NumCashRendered.Enabled = False
        NumChangeDue.Enabled = False
        NumChargeAmount.Enabled = False
        NumCheckAmount.Enabled = False
        TxtAuthNo.Enabled = False
        TxtCheckNo.Enabled = False
        DteDueDate.Enabled = False
        NumYear.Enabled = False
        NumMonth.Enabled = False
        CmbARTerms.Enabled = False
        CmbCCType.Enabled = False
        BtnPaymentOnHold.Enabled = False
        BtnSaveAndPrint.Enabled = False
        BtnSaveNoPrint.Enabled = False
    End Sub
    Private Sub LoadCashierInformation()
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            CmdGeneral.CommandText = "SELECT isnull(BalanceOverPaymentAmount,0) as BalanceOverPaymentAmount FROM View_Balance_OverPayment_Amount where cod_customer=" & Qt(CustomerCodeVar)
            NumOverPaymentBalance.Text = CmdGeneral.ExecuteScalar()
        Catch ex As Exception
            NumOverPaymentBalance.Text = 0
        End Try
        Try
            CmdGeneral.CommandText = "SELECT isnull(BalanceDownPaymentAmount,0) as BalanceDownPaymentAmount FROM View_Balance_DownPayment_Amount where cod_customer=" & Qt(CustomerCodeVar)
            NumDownPaymentBalance.Text = CmdGeneral.ExecuteScalar()
        Catch ex As Exception
            NumDownPaymentBalance.Text = 0
        End Try
        Try
            If DsFrmCashier1.GL_payment_deposit.Rows.Count > 0 Then
                Dim i As Integer
                For i = 0 To DsFrmCashier1.GL_payment_deposit.Rows.Count - 1
                    Select Case DsFrmCashier1.GL_payment_deposit.Rows(i).Item("payment_type") & ""
                        Case "1" 'cash
                            ChkCash.Checked = True
                            NumCashRendered.Text = DsFrmCashier1.GL_payment_deposit.Rows(i).Item("cash_rendered") & ""
                            NumChangeDue.Text = DsFrmCashier1.GL_payment_deposit.Rows(i).Item("change_due") & ""
                        Case "2" 'check
                            ChkCheck.Checked = True
                            NumCheckAmount.Text = DsFrmCashier1.GL_payment_deposit.Rows(i).Item("payment_amount")
                            TxtCheckNo.Text = DsFrmCashier1.GL_payment_deposit.Rows(i).Item("check_no") & ""
                        Case "3" 'credit
                            ChkCreditCard.Checked = True
                            NumChargeAmount.Text = DsFrmCashier1.GL_payment_deposit.Rows(i).Item("payment_amount")
                            TXTCardNo.Text = DsFrmCashier1.GL_payment_deposit.Rows(i).Item("cc_card_no") & ""
                            TxtAuthNo.Text = DsFrmCashier1.GL_payment_deposit.Rows(i).Item("cc_auth_no") & ""
                            NumYear.Text = DsFrmCashier1.GL_payment_deposit.Rows(i).Item("cc_expire_date_year") & ""
                            NumMonth.Text = DsFrmCashier1.GL_payment_deposit.Rows(i).Item("cc_expire_date_month") & ""
                            CmbCCType.SelectedValue = DsFrmCashier1.GL_payment_deposit.Rows(i).Item("cc_type")
                        Case "4" 'AR
                            ChkAR.Checked = True
                            NumARAmount.Text = DsFrmCashier1.GL_payment_deposit.Compute("Sum(payment_amount)", "payment_type='4'")
                            'NumARAmount.Text = DsFrmCashier1.GL_payment_deposit.Rows(i).Item("payment_amount")
                            DteDueDate.Text = DsFrmCashier1.GL_payment_deposit.Rows(i).Item("AR_due_date") & ""
                            CmbARTerms.SelectedValue = DsFrmCashier1.GL_payment_deposit.Rows(i).Item("AR_terms")
                        Case "5" 'Over Payment
                            ChkOverPayment.Checked = True
                            NumOverPayment.Text = DsFrmCashier1.GL_payment_deposit.Compute("Sum(payment_amount)", "payment_type='5'")
                            NumOverPaymentBalance.Text = NumOverPaymentBalance.Numbervalue + NumOverPayment.Numbervalue
                        Case "6" 'Down Payment
                            ChkDownPayment.Checked = True
                            NumDownPayment.Text = DsFrmCashier1.GL_payment_deposit.Compute("Sum(payment_amount)", "payment_type='6'")
                            NumDownPaymentBalance.Text = NumDownPaymentBalance.Numbervalue + NumDownPayment.Numbervalue
                    End Select
                Next
            Else
                ChkCash.Checked = False
                ChkCheck.Checked = False
                ChkCreditCard.Checked = False
                ChkAR.Checked = False
                ChkOverPayment.Checked = False
                ChkDownPayment.Checked = False
            End If
        Catch ex As Exception
            MsgBox("Error In loading Data.")
        End Try
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Private Sub EnableDisableField()
        NumCashRendered.Enabled = ChkCash.Checked
        NumChangeDue.Enabled = ChkCash.Checked

        NumCheckAmount.Enabled = ChkCheck.Checked
        TxtCheckNo.Enabled = ChkCheck.Checked

        TXTCardNo.Enabled = ChkCreditCard.Checked
        CmbCCType.Enabled = ChkCreditCard.Checked
        NumChargeAmount.Enabled = ChkCreditCard.Checked
        NumYear.Enabled = ChkCreditCard.Checked
        NumMonth.Enabled = ChkCreditCard.Checked
        TxtAuthNo.Enabled = ChkCreditCard.Checked

        NumARAmount.Enabled = ChkAR.Checked
        CmbARTerms.Enabled = ChkAR.Checked
        DteDueDate.Enabled = ChkAR.Checked

        NumOverPayment.Enabled = ChkOverPayment.Checked
        NumDownPayment.Enabled = ChkDownPayment.Checked
    End Sub
    Private Sub NumCashRendered_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumCashRendered.TextChanged
        Call CalcBalance()
        Try
            If NumCashRendered.Text = 0 Then
                NumChangeDue.Text = 0
            Else
                If NumCashRendered.Numbervalue > NumAmount.Numbervalue Then
                    NumChangeDue.Text = NumCashRendered.Numbervalue - NumAmount.Numbervalue
                Else
                    NumChangeDue.Text = 0
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CalcBalance()
        NumBalance.Text = (NumCashRendered.Numbervalue - NumChangeDue.Numbervalue + NumCheckAmount.Numbervalue + NumChargeAmount.Numbervalue + NumARAmount.Numbervalue + NumOverPayment.Numbervalue + NumDownPayment.Numbervalue) - NumAmount.Numbervalue
    End Sub
    Private Sub NumChangeDue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumChangeDue.TextChanged, NumCheckAmount.TextChanged, NumChargeAmount.TextChanged, NumARAmount.TextChanged, NumOverPayment.TextChanged, NumDownPayment.TextChanged
        Call CalcBalance()
    End Sub
    Private Sub ClearField()
        NumCashRendered.Text = 0
        NumChangeDue.Text = 0
        ChkCash.Checked = False
        NumCheckAmount.Text = 0
        ChkCheck.Checked = False
        TxtCheckNo.Text = 0
        NumChargeAmount.Text = 0
        ChkCreditCard.Checked = False
        TXTCardNo.Text = 0
        TxtAuthNo.Text = 0
        NumYear.Text = 0
        NumMonth.Text = 0
        CmbCCType.SelectedValue = 0
        NumARAmount.Text = 0
        ChkAR.Checked = False
        DteDueDate.Text = 0
        CmbARTerms.SelectedValue = 0
        ChkOverPayment.Checked = False
        NumOverPayment.Text = 0
        ChkDownPayment.Checked = False
        NumDownPayment.Text = 0
    End Sub
    Private Sub BtnDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDetail.Click
        Dim MyFrmShowPaymentDetail As New FrmShowPaymentDetail
        MyFrmShowPaymentDetail.Id_service_centerVar = TxtRef.Text
        MyFrmShowPaymentDetail.ShowDialog()
    End Sub
End Class
