Imports CommonClass
Public Class FrmGetDownPayment
    Inherits CommonClass.FrmBase
    Public OkFlagVar As Boolean = False
    Public id_service_centerVar As String
    Public CustomerCodVar As String
    Public DateVar As String
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
    Friend WithEvents BtnOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents NumMonth As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents NumYear As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NumChargeAmount As CalcUtils.UcCalcText
    Friend WithEvents NumCheckAmount As CalcUtils.UcCalcText
    Friend WithEvents NumCashRendered As CalcUtils.UcCalcText
    Friend WithEvents TXTCardNo As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents TxtAuthNo As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents TxtCheckNo As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmbCCType As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblCardNo As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DAbas_cc_type As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsFrmGetDownPayment1 As ServiceCenterScreen.DSFrmGetDownPayment
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_Paid_received As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmGetDownPayment))
        Me.BtnOk = New Janus.Windows.EditControls.UIButton
        Me.BtnCancel = New Janus.Windows.EditControls.UIButton
        Me.NumMonth = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.NumYear = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.NumChargeAmount = New CalcUtils.UcCalcText
        Me.NumCheckAmount = New CalcUtils.UcCalcText
        Me.NumCashRendered = New CalcUtils.UcCalcText
        Me.TXTCardNo = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TxtAuthNo = New Janus.Windows.GridEX.EditControls.EditBox
        Me.TxtCheckNo = New Janus.Windows.GridEX.EditControls.EditBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.CmbCCType = New System.Windows.Forms.ComboBox
        Me.DsFrmGetDownPayment1 = New ServiceCenterScreen.DSFrmGetDownPayment
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.LblCardNo = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.DAbas_cc_type = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_Paid_received = New System.Data.SqlClient.SqlDataAdapter
        CType(Me.DsFrmGetDownPayment1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(205, 259)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(75, 23)
        Me.BtnOk.TabIndex = 21
        Me.BtnOk.Text = "OK"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(19, 259)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 22
        Me.BtnCancel.Text = "Cancel"
        '
        'NumMonth
        '
        Me.NumMonth.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.NumMonth.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.NumMonth.DecimalDigits = 0
        Me.NumMonth.FormatString = "##"
        Me.NumMonth.Location = New System.Drawing.Point(169, 160)
        Me.NumMonth.MaxLength = 2
        Me.NumMonth.Name = "NumMonth"
        Me.NumMonth.Size = New System.Drawing.Size(29, 20)
        Me.NumMonth.TabIndex = 15
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
        Me.NumYear.Location = New System.Drawing.Point(208, 160)
        Me.NumYear.MaxLength = 4
        Me.NumYear.Name = "NumYear"
        Me.NumYear.Size = New System.Drawing.Size(55, 20)
        Me.NumYear.TabIndex = 17
        Me.NumYear.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.NumYear.Value = CType(0, Short)
        Me.NumYear.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int16
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(194, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 19)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "/"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.NumChargeAmount.Location = New System.Drawing.Point(155, 34)
        Me.NumChargeAmount.Maxlength = 10
        Me.NumChargeAmount.MinusColor = System.Drawing.Color.Empty
        Me.NumChargeAmount.Name = "NumChargeAmount"
        Me.NumChargeAmount.Size = New System.Drawing.Size(120, 22)
        Me.NumChargeAmount.TabIndex = 9
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
        Me.NumCheckAmount.Location = New System.Drawing.Point(10, 133)
        Me.NumCheckAmount.Maxlength = 10
        Me.NumCheckAmount.MinusColor = System.Drawing.Color.Empty
        Me.NumCheckAmount.Name = "NumCheckAmount"
        Me.NumCheckAmount.Size = New System.Drawing.Size(120, 22)
        Me.NumCheckAmount.TabIndex = 4
        Me.NumCheckAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumCheckAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
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
        Me.NumCashRendered.Location = New System.Drawing.Point(9, 32)
        Me.NumCashRendered.Maxlength = 10
        Me.NumCashRendered.MinusColor = System.Drawing.Color.Empty
        Me.NumCashRendered.Name = "NumCashRendered"
        Me.NumCashRendered.Size = New System.Drawing.Size(120, 22)
        Me.NumCashRendered.TabIndex = 0
        Me.NumCashRendered.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumCashRendered.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TXTCardNo
        '
        Me.TXTCardNo.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TXTCardNo.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TXTCardNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TXTCardNo.Location = New System.Drawing.Point(144, 117)
        Me.TXTCardNo.MaxLength = 20
        Me.TXTCardNo.Name = "TXTCardNo"
        Me.TXTCardNo.Size = New System.Drawing.Size(140, 20)
        Me.TXTCardNo.TabIndex = 13
        Me.TXTCardNo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtAuthNo
        '
        Me.TxtAuthNo.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtAuthNo.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtAuthNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtAuthNo.Location = New System.Drawing.Point(164, 203)
        Me.TxtAuthNo.MaxLength = 20
        Me.TxtAuthNo.Name = "TxtAuthNo"
        Me.TxtAuthNo.Size = New System.Drawing.Size(100, 20)
        Me.TxtAuthNo.TabIndex = 19
        Me.TxtAuthNo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtCheckNo
        '
        Me.TxtCheckNo.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtCheckNo.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtCheckNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtCheckNo.Location = New System.Drawing.Point(18, 193)
        Me.TxtCheckNo.MaxLength = 20
        Me.TxtCheckNo.Name = "TxtCheckNo"
        Me.TxtCheckNo.Size = New System.Drawing.Size(100, 20)
        Me.TxtCheckNo.TabIndex = 6
        Me.TxtCheckNo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(17, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Check No"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(12, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cash Amount"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(11, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Check Amount"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbCCType
        '
        Me.CmbCCType.DataSource = Me.DsFrmGetDownPayment1.bas_cc_type
        Me.CmbCCType.DisplayMember = "cc_type_desc"
        Me.CmbCCType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCCType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmbCCType.ItemHeight = 13
        Me.CmbCCType.Location = New System.Drawing.Point(164, 76)
        Me.CmbCCType.Name = "CmbCCType"
        Me.CmbCCType.Size = New System.Drawing.Size(100, 21)
        Me.CmbCCType.TabIndex = 11
        Me.CmbCCType.ValueMember = "cc_type"
        '
        'DsFrmGetDownPayment1
        '
        Me.DsFrmGetDownPayment1.DataSetName = "DSFrmGetDownPayment"
        Me.DsFrmGetDownPayment1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(164, 185)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 19)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Auth. No."
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(164, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 19)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Exp Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCardNo
        '
        Me.LblCardNo.BackColor = System.Drawing.Color.Transparent
        Me.LblCardNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblCardNo.Location = New System.Drawing.Point(164, 99)
        Me.LblCardNo.Name = "LblCardNo"
        Me.LblCardNo.Size = New System.Drawing.Size(100, 19)
        Me.LblCardNo.TabIndex = 12
        Me.LblCardNo.Text = "Card No"
        Me.LblCardNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(164, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 19)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Charge Amount"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(164, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 19)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "C.C. Type"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Black
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(137, -7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(3, 253)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Black
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox4.Location = New System.Drawing.Point(-67, 79)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(205, 3)
        Me.GroupBox4.TabIndex = 369
        Me.GroupBox4.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(-7, 247)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 3)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Black
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox3.Location = New System.Drawing.Point(295, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(3, 289)
        Me.GroupBox3.TabIndex = 371
        Me.GroupBox3.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Black
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(3, 289)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        '
        'DAbas_cc_type
        '
        Me.DAbas_cc_type.SelectCommand = Me.SqlSelectCommand1
        Me.DAbas_cc_type.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_cc_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cc_type", "cc_type"), New System.Data.Common.DataColumnMapping("cc_type_desc", "cc_type_desc")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cc_type, cc_type_desc FROM bas_cc_type"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEHSERVER;packet size=4096;user id=sa;data source=""."";persist" & _
        " security info=True;initial catalog=TireMate_04"
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT refrence_code, tran_type, action_date, customer_code, vendor_code, amount," & _
        " GL_account, memo, Id_GL_journal, OtherReceipType, Id_debit_deposit_head, id_ser" & _
        "vice_center, cc_type, cc_card_no, cc_expire_date_year, cc_expire_date_month, cc_" & _
        "auth_no, check_no FROM GL_Paid_received WHERE (id_service_center = @id_service_c" & _
        "enter) AND (tran_type = '4')"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        '
        'DAGL_Paid_received
        '
        Me.DAGL_Paid_received.SelectCommand = Me.SqlSelectCommand2
        Me.DAGL_Paid_received.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_Paid_received", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("refrence_code", "refrence_code"), New System.Data.Common.DataColumnMapping("tran_type", "tran_type"), New System.Data.Common.DataColumnMapping("action_date", "action_date"), New System.Data.Common.DataColumnMapping("customer_code", "customer_code"), New System.Data.Common.DataColumnMapping("vendor_code", "vendor_code"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("memo", "memo"), New System.Data.Common.DataColumnMapping("Id_GL_journal", "Id_GL_journal"), New System.Data.Common.DataColumnMapping("OtherReceipType", "OtherReceipType"), New System.Data.Common.DataColumnMapping("Id_debit_deposit_head", "Id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("cc_type", "cc_type"), New System.Data.Common.DataColumnMapping("cc_card_no", "cc_card_no"), New System.Data.Common.DataColumnMapping("cc_expire_date_year", "cc_expire_date_year"), New System.Data.Common.DataColumnMapping("cc_expire_date_month", "cc_expire_date_month"), New System.Data.Common.DataColumnMapping("cc_auth_no", "cc_auth_no"), New System.Data.Common.DataColumnMapping("check_no", "check_no")})})
        '
        'FrmGetDownPayment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(298, 289)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.NumMonth)
        Me.Controls.Add(Me.NumYear)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.NumChargeAmount)
        Me.Controls.Add(Me.NumCheckAmount)
        Me.Controls.Add(Me.NumCashRendered)
        Me.Controls.Add(Me.TXTCardNo)
        Me.Controls.Add(Me.TxtAuthNo)
        Me.Controls.Add(Me.TxtCheckNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CmbCCType)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblCardNo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmGetDownPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Down Payment"
        CType(Me.DsFrmGetDownPayment1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmGetDownPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        If ThisFormStatus <> CommonClass.MainModule.WorkStates.AddNew And ThisFormStatus <> CommonClass.MainModule.WorkStates.Edit Then
            NumCashRendered.Enabled = False
            NumChargeAmount.Enabled = False
            NumCheckAmount.Enabled = False
            NumMonth.Enabled = False
            NumYear.Enabled = False
            TxtAuthNo.Enabled = False
            TXTCardNo.Enabled = False
            TxtCheckNo.Enabled = False
            CmbCCType.Enabled = False
            BtnOk.Enabled = False
        End If
        DsFrmGetDownPayment1.Clear()
        DAbas_cc_type.Fill(DsFrmGetDownPayment1, "bas_cc_type")
        DAGL_Paid_received.SelectCommand.Parameters("@id_service_center").Value = id_service_centerVar
        Try
            DAGL_Paid_received.Fill(DsFrmGetDownPayment1, "GL_Paid_received")
        Catch ex As Exception
        End Try

        NumCashRendered.Text = 0
        NumChargeAmount.Text = 0
        NumCheckAmount.Text = 0
        NumMonth.Text = ""
        NumYear.Text = ""
        TxtAuthNo.Text = ""
        TXTCardNo.Text = ""
        TxtCheckNo.Text = ""
        CmbCCType.SelectedValue = 0
        Try
            If DsFrmGetDownPayment1.GL_Paid_received.Rows.Count > 0 Then
                Dim i As Integer
                For i = 0 To DsFrmGetDownPayment1.GL_Paid_received.Rows.Count - 1
                    Select Case DsFrmGetDownPayment1.GL_Paid_received.Rows(i).Item("OtherReceipType")
                        Case "1"
                            NumCashRendered.Text = DsFrmGetDownPayment1.GL_Paid_received.Rows(i).Item("Amount")
                        Case "2"
                            NumCheckAmount.Text = DsFrmGetDownPayment1.GL_Paid_received.Rows(i).Item("Amount")
                            TxtCheckNo.Text = DsFrmGetDownPayment1.GL_Paid_received.Rows(i).Item("check_no")
                        Case "3"
                            NumChargeAmount.Text = DsFrmGetDownPayment1.GL_Paid_received.Rows(i).Item("Amount")
                            TXTCardNo.Text = DsFrmGetDownPayment1.GL_Paid_received.Rows(i).Item("cc_card_no") & ""
                            TxtAuthNo.Text = DsFrmGetDownPayment1.GL_Paid_received.Rows(i).Item("cc_auth_no") & ""
                            NumYear.Text = DsFrmGetDownPayment1.GL_Paid_received.Rows(i).Item("cc_expire_date_year") & ""
                            NumMonth.Text = DsFrmGetDownPayment1.GL_Paid_received.Rows(i).Item("cc_expire_date_month") & ""
                            CmbCCType.SelectedValue = DsFrmGetDownPayment1.GL_Paid_received.Rows(i).Item("cc_type")
                    End Select
                Next
            End If
        Catch ex As Exception
            MsgBox("Error In loading Data.")
        End Try
    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If

        Dim tran1 As SqlClient.SqlTransaction
        tran1 = Cnn.BeginTransaction()
        CmdGeneral.Transaction = tran1

        Try

            If NumCashRendered.Numbervalue > 0 Then
                Dim GL_Paid_received_refrence_codeVar As String
                CmdGeneral.CommandText = "Select refrence_code From GL_Paid_received Where tran_type='4' AND OtherReceipType='1' AND id_service_center=" & Qt(id_service_centerVar)
                GL_Paid_received_refrence_codeVar = CmdGeneral.ExecuteScalar & ""
                If GL_Paid_received_refrence_codeVar.Trim.Length > 0 Then
                    CmdGeneral.CommandText = "Update GL_Paid_received Set customer_code=" & CustomerCodVar & ",amount=" & NumCashRendered.Text & " Where tran_type='4' AND OtherReceipType='1' AND id_service_center=" & Qt(id_service_centerVar)
                    CmdGeneral.ExecuteNonQuery()
                Else
                    Dim iii As Integer
                    For iii = 0 To 10
                        GL_Paid_received_refrence_codeVar = MakeNewRefForCashPaidOut()
                        CmdGeneral.CommandText = "INSERT INTO GL_Paid_received (refrence_code, tran_type, action_date, customer_code, amount, memo, OtherReceipType,id_service_center) VALUES (" & Qt(GL_Paid_received_refrence_codeVar) & ",'4'," & Qt(DateVar) & "," & Qt(CustomerCodVar) & "," & NumCashRendered.Text & ",'Down Payment For Work Order " & id_service_centerVar & "' ,'1'," & Qt(id_service_centerVar) & ")"
                        Try
                            CmdGeneral.ExecuteNonQuery()
                            Exit For
                        Catch ex As Exception
                            GL_Paid_received_refrence_codeVar = MakeNewRefForCashPaidOut()
                        End Try
                    Next
                    If iii = 11 Then
                        MsgBox("Can't Save Down Payment", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If
            Else
                CmdGeneral.CommandText = "Delete FROM GL_Paid_received where tran_type='4' AND OtherReceipType='1' AND id_service_center=" & Qt(id_service_centerVar)
                CmdGeneral.ExecuteNonQuery()
            End If

            If NumCheckAmount.Numbervalue > 0 Then
                Dim GL_Paid_received_refrence_codeVar As String
                CmdGeneral.CommandText = "Select refrence_code From GL_Paid_received Where tran_type='4' AND OtherReceipType='2' AND id_service_center=" & Qt(id_service_centerVar)
                GL_Paid_received_refrence_codeVar = CmdGeneral.ExecuteScalar & ""
                If GL_Paid_received_refrence_codeVar.Trim.Length > 0 Then
                    CmdGeneral.CommandText = "Update GL_Paid_received Set customer_code=" & CustomerCodVar & ",check_no=" & Qt(TxtCheckNo.Text) & ",amount=" & NumCheckAmount.Text & " Where tran_type='4' AND OtherReceipType='2' AND id_service_center=" & Qt(id_service_centerVar)
                    CmdGeneral.ExecuteNonQuery()
                Else
                    Dim iii As Integer
                    For iii = 0 To 10
                        GL_Paid_received_refrence_codeVar = MakeNewRefForCashPaidOut()
                        CmdGeneral.CommandText = "INSERT INTO GL_Paid_received (refrence_code, tran_type, action_date, customer_code, amount, memo, OtherReceipType,id_service_center,check_no) VALUES (" & Qt(GL_Paid_received_refrence_codeVar) & ",'4'," & Qt(DateVar) & "," & Qt(CustomerCodVar) & "," & NumCheckAmount.Text & ",'Down Payment For Work Order " & id_service_centerVar & "' ,'2'," & Qt(id_service_centerVar) & "," & Qt(TxtCheckNo.Text) & ")"
                        Try
                            CmdGeneral.ExecuteNonQuery()
                            Exit For
                        Catch ex As Exception
                            GL_Paid_received_refrence_codeVar = MakeNewRefForCashPaidOut()
                        End Try
                    Next
                    If iii = 11 Then
                        MsgBox("Can't Save Down Payment", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If
            Else
                CmdGeneral.CommandText = "Delete FROM GL_Paid_received where tran_type='4' AND OtherReceipType='2' AND id_service_center=" & Qt(id_service_centerVar)
                CmdGeneral.ExecuteNonQuery()
            End If

            If NumChargeAmount.Numbervalue > 0 Then
                Dim GL_Paid_received_refrence_codeVar As String
                CmdGeneral.CommandText = "Select refrence_code From GL_Paid_received Where tran_type='4' AND OtherReceipType='3' AND id_service_center=" & Qt(id_service_centerVar)
                GL_Paid_received_refrence_codeVar = CmdGeneral.ExecuteScalar & ""
                If GL_Paid_received_refrence_codeVar.Trim.Length > 0 Then
                    CmdGeneral.CommandText = "Update GL_Paid_received Set customer_code=" & Qt(CustomerCodVar) & ",cc_card_no=" & Qt(TXTCardNo.Text) & ",cc_auth_no=" & Qt(TxtAuthNo.Text) & ",cc_expire_date_year=" & Qt(NumYear.Text) & ",cc_expire_date_month=" & Qt(NumMonth.Text) & ",cc_type=" & Qt(CmbCCType.SelectedValue) & ",amount=" & NumChargeAmount.Text & " Where tran_type='4' AND OtherReceipType='3' AND id_service_center=" & Qt(id_service_centerVar)
                    CmdGeneral.ExecuteNonQuery()
                Else
                    Dim iii As Integer
                    For iii = 0 To 10
                        GL_Paid_received_refrence_codeVar = MakeNewRefForCashPaidOut()
                        CmdGeneral.CommandText = "INSERT INTO GL_Paid_received (refrence_code, tran_type, action_date, customer_code, amount, memo, OtherReceipType,id_service_center,cc_card_no,cc_auth_no,cc_expire_date_year,cc_expire_date_month,cc_type) VALUES (" & Qt(GL_Paid_received_refrence_codeVar) & ",'4'," & Qt(DateVar) & "," & Qt(CustomerCodVar) & "," & NumChargeAmount.Text & ",'Down Payment For Work Order " & id_service_centerVar & "' ,'3'," & Qt(id_service_centerVar) & "," & Qt(TXTCardNo.Text) & "," & Qt(TxtAuthNo.Text) & "," & Qt(NumYear.Text) & "," & Qt(NumMonth.Text) & "," & Qt(CmbCCType.SelectedValue) & ")"
                        Try
                            CmdGeneral.ExecuteNonQuery()
                            Exit For
                        Catch ex As Exception
                            GL_Paid_received_refrence_codeVar = MakeNewRefForCashPaidOut()
                        End Try
                    Next
                    If iii = 11 Then
                        MsgBox("Can't Save Down Payment", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If
            Else
                CmdGeneral.CommandText = "Delete FROM GL_Paid_received where tran_type='4' AND OtherReceipType='3' AND id_service_center=" & Qt(id_service_centerVar)
                CmdGeneral.ExecuteNonQuery()
            End If
            tran1.Commit()
            OkFlagVar = True
        Catch ex As Exception
            tran1.Rollback()
            OkFlagVar = False
            MsgBox("Error in Save.Try again")
        End Try
        Me.Close()
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        OkFlagVar = False
        Me.Close()
    End Sub
    Private Function MakeNewRefForCashPaidOut() As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "Select Max(refrence_code) as Max_refrence_code from GL_Paid_received WHERE tran_type='4' "
        Try
            MakeNewRefForCashPaidOut = Getcod(Str(Val(Mid(CmdGeneral.ExecuteScalar, 3, 6)) + 1).Trim, 6)
        Catch ex As Exception
            MakeNewRefForCashPaidOut = "000001"
        End Try
        MakeNewRefForCashPaidOut = "DP" & MakeNewRefForCashPaidOut
    End Function
End Class
