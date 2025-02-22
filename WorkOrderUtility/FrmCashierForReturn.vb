Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmCashierForReturn
    Inherits FrmBase
    Public TxtRefvar As String
    Public Datevar As String
    Public CustomerCodvar As String
    Public InvoiceNoForReturnVar As String = ""
    Public TotalAmountOfReturnVar As Double
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
    Friend WithEvents BtnCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents DAGL_account As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmCashierForReturn1 As DSFrmCashierForReturn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbGL_account As System.Windows.Forms.ComboBox
    Friend WithEvents CnnForReader As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdGeneralForReader As System.Data.SqlClient.SqlCommand
    Friend WithEvents NumChargeAmount As CalcUtils.UcCalcText
    Friend WithEvents TXTCardNo As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents CmbCCType As System.Windows.Forms.ComboBox
    Friend WithEvents LblCardNo As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NumCashAmount As CalcUtils.UcCalcText
    Friend WithEvents DAbas_cc_type As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_payment_deposit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents NumAmountPaid As CalcUtils.UcCalcText
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents NumBalance As CalcUtils.UcCalcText
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents NumAmountReminder As CalcUtils.UcCalcText
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCashierForReturn))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.BtnCancel = New Janus.Windows.EditControls.UIButton
        Me.BtnSave = New Janus.Windows.EditControls.UIButton
        Me.DAGL_account = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DsFrmCashierForReturn1 = New WorkOrderUtility.DSFrmCashierForReturn
        Me.NumCashAmount = New CalcUtils.UcCalcText
        Me.Label6 = New System.Windows.Forms.Label
        Me.CmbGL_account = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CnnForReader = New System.Data.SqlClient.SqlConnection
        Me.CmdGeneralForReader = New System.Data.SqlClient.SqlCommand
        Me.NumChargeAmount = New CalcUtils.UcCalcText
        Me.TXTCardNo = New Janus.Windows.GridEX.EditControls.EditBox
        Me.CmbCCType = New System.Windows.Forms.ComboBox
        Me.LblCardNo = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DAbas_cc_type = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_payment_deposit = New System.Data.SqlClient.SqlDataAdapter
        Me.NumAmountPaid = New CalcUtils.UcCalcText
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.NumBalance = New CalcUtils.UcCalcText
        Me.Label16 = New System.Windows.Forms.Label
        Me.NumAmountReminder = New CalcUtils.UcCalcText
        Me.Label7 = New System.Windows.Forms.Label
        CType(Me.DsFrmCashierForReturn1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=KETABIE;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=TireMate_02;password=sa"
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(20, 443)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(99, 24)
        Me.BtnCancel.TabIndex = 6
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Enabled = False
        Me.BtnSave.Location = New System.Drawing.Point(218, 443)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(99, 24)
        Me.BtnSave.TabIndex = 5
        Me.BtnSave.Text = "Save"
        '
        'DAGL_account
        '
        Me.DAGL_account.DeleteCommand = Me.SqlDeleteCommand3
        Me.DAGL_account.InsertCommand = Me.SqlInsertCommand3
        Me.DAGL_account.SelectCommand = Me.SqlSelectCommand2
        Me.DAGL_account.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("desc_GL_account", "desc_GL_account"), New System.Data.Common.DataColumnMapping("GL_account_master", "GL_account_master"), New System.Data.Common.DataColumnMapping("group_GL_account", "group_GL_account"), New System.Data.Common.DataColumnMapping("remark", "remark")})})
        Me.DAGL_account.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM GL_account WHERE (GL_account = @Original_GL_account) AND (GL_account_" & _
        "master = @Original_GL_account_master OR @Original_GL_account_master IS NULL AND " & _
        "GL_account_master IS NULL) AND (desc_GL_account = @Original_desc_GL_account OR @" & _
        "Original_desc_GL_account IS NULL AND desc_GL_account IS NULL) AND (group_GL_acco" & _
        "unt = @Original_group_GL_account OR @Original_group_GL_account IS NULL AND group" & _
        "_GL_account IS NULL) AND (remark = @Original_remark OR @Original_remark IS NULL " & _
        "AND remark IS NULL)"
        Me.SqlDeleteCommand3.Connection = Me.Cnn
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account_master", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account_master", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_GL_account", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_group_GL_account", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "group_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO GL_account(GL_account, desc_GL_account, GL_account_master, group_GL_a" & _
        "ccount, remark) VALUES (@GL_account, @desc_GL_account, @GL_account_master, @grou" & _
        "p_GL_account, @remark); SELECT GL_account, desc_GL_account, GL_account_master, g" & _
        "roup_GL_account, remark FROM GL_account WHERE (GL_account = @GL_account)"
        Me.SqlInsertCommand3.Connection = Me.Cnn
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_GL_account", System.Data.SqlDbType.VarChar, 50, "desc_GL_account"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account_master", System.Data.SqlDbType.VarChar, 10, "GL_account_master"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@group_GL_account", System.Data.SqlDbType.VarChar, 2, "group_GL_account"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT GL_account, desc_GL_account, GL_account_master, group_GL_account, remark F" & _
        "ROM GL_account"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE GL_account SET GL_account = @GL_account, desc_GL_account = @desc_GL_accoun" & _
        "t, GL_account_master = @GL_account_master, group_GL_account = @group_GL_account," & _
        " remark = @remark WHERE (GL_account = @Original_GL_account) AND (GL_account_mast" & _
        "er = @Original_GL_account_master OR @Original_GL_account_master IS NULL AND GL_a" & _
        "ccount_master IS NULL) AND (desc_GL_account = @Original_desc_GL_account OR @Orig" & _
        "inal_desc_GL_account IS NULL AND desc_GL_account IS NULL) AND (group_GL_account " & _
        "= @Original_group_GL_account OR @Original_group_GL_account IS NULL AND group_GL_" & _
        "account IS NULL) AND (remark = @Original_remark OR @Original_remark IS NULL AND " & _
        "remark IS NULL); SELECT GL_account, desc_GL_account, GL_account_master, group_GL" & _
        "_account, remark FROM GL_account WHERE (GL_account = @GL_account)"
        Me.SqlUpdateCommand3.Connection = Me.Cnn
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_GL_account", System.Data.SqlDbType.VarChar, 50, "desc_GL_account"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account_master", System.Data.SqlDbType.VarChar, 10, "GL_account_master"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@group_GL_account", System.Data.SqlDbType.VarChar, 2, "group_GL_account"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account_master", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account_master", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_GL_account", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_group_GL_account", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "group_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        '
        'DsFrmCashierForReturn1
        '
        Me.DsFrmCashierForReturn1.DataSetName = "DSFrmCashierForReturn"
        Me.DsFrmCashierForReturn1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'NumCashAmount
        '
        Me.NumCashAmount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumCashAmount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumCashAmount.DecimalDigits = 2
        Me.NumCashAmount.DefaultSendValue = False
        Me.NumCashAmount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumCashAmount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumCashAmount.Image = CType(resources.GetObject("NumCashAmount.Image"), System.Drawing.Image)
        Me.NumCashAmount.Location = New System.Drawing.Point(111, 25)
        Me.NumCashAmount.Maxlength = 10
        Me.NumCashAmount.MinusColor = System.Drawing.Color.Empty
        Me.NumCashAmount.Name = "NumCashAmount"
        Me.NumCashAmount.Size = New System.Drawing.Size(114, 21)
        Me.NumCashAmount.TabIndex = 0
        Me.NumCashAmount.TabStop = False
        Me.NumCashAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumCashAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(6, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 21)
        Me.Label6.TabIndex = 360
        Me.Label6.Text = "GL Account"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbGL_account
        '
        Me.CmbGL_account.DataSource = Me.DsFrmCashierForReturn1.GL_account
        Me.CmbGL_account.DisplayMember = "desc_GL_account"
        Me.CmbGL_account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbGL_account.Location = New System.Drawing.Point(109, 52)
        Me.CmbGL_account.Name = "CmbGL_account"
        Me.CmbGL_account.Size = New System.Drawing.Size(189, 21)
        Me.CmbGL_account.TabIndex = 1
        Me.CmbGL_account.ValueMember = "GL_account"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 21)
        Me.Label1.TabIndex = 362
        Me.Label1.Text = "Cash Amount"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CnnForReader
        '
        Me.CnnForReader.ConnectionString = "workstation id=KETABI;packet size=4096;user id=sa;data source=""."";persist securit" & _
        "y info=False;initial catalog=TireMate_01"
        '
        'CmdGeneralForReader
        '
        Me.CmdGeneralForReader.Connection = Me.CnnForReader
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
        Me.NumChargeAmount.Location = New System.Drawing.Point(109, 107)
        Me.NumChargeAmount.Maxlength = 10
        Me.NumChargeAmount.MinusColor = System.Drawing.Color.Empty
        Me.NumChargeAmount.Name = "NumChargeAmount"
        Me.NumChargeAmount.Size = New System.Drawing.Size(120, 22)
        Me.NumChargeAmount.TabIndex = 2
        Me.NumChargeAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumChargeAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TXTCardNo
        '
        Me.TXTCardNo.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TXTCardNo.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TXTCardNo.Enabled = False
        Me.TXTCardNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TXTCardNo.Location = New System.Drawing.Point(109, 164)
        Me.TXTCardNo.MaxLength = 20
        Me.TXTCardNo.Name = "TXTCardNo"
        Me.TXTCardNo.Size = New System.Drawing.Size(140, 20)
        Me.TXTCardNo.TabIndex = 4
        Me.TXTCardNo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'CmbCCType
        '
        Me.CmbCCType.DataSource = Me.DsFrmCashierForReturn1.bas_cc_type
        Me.CmbCCType.DisplayMember = "cc_type_desc"
        Me.CmbCCType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCCType.Enabled = False
        Me.CmbCCType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmbCCType.ItemHeight = 13
        Me.CmbCCType.Location = New System.Drawing.Point(109, 136)
        Me.CmbCCType.Name = "CmbCCType"
        Me.CmbCCType.Size = New System.Drawing.Size(100, 21)
        Me.CmbCCType.TabIndex = 3
        Me.CmbCCType.ValueMember = "cc_type"
        '
        'LblCardNo
        '
        Me.LblCardNo.BackColor = System.Drawing.Color.Transparent
        Me.LblCardNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblCardNo.Location = New System.Drawing.Point(5, 164)
        Me.LblCardNo.Name = "LblCardNo"
        Me.LblCardNo.Size = New System.Drawing.Size(100, 19)
        Me.LblCardNo.TabIndex = 368
        Me.LblCardNo.Text = "Card No"
        Me.LblCardNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(5, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 19)
        Me.Label10.TabIndex = 366
        Me.Label10.Text = "C.C. Amount"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(4, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 19)
        Me.Label9.TabIndex = 367
        Me.Label9.Text = "C.C. Type"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox4.Location = New System.Drawing.Point(-34, 78)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(398, 3)
        Me.GroupBox4.TabIndex = 369
        Me.GroupBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(119, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 370
        Me.Label2.Text = "Cash"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(115, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 21)
        Me.Label3.TabIndex = 371
        Me.Label3.Text = "Credit Card"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(-29, 188)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 3)
        Me.GroupBox1.TabIndex = 372
        Me.GroupBox1.TabStop = False
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
        'GridEX1
        '
        Me.GridEX1.DataMember = "GL_payment_deposit"
        Me.GridEX1.DataSource = Me.DsFrmCashierForReturn1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>GL_payment_deposit</Caption><Columns Collec" & _
        "tion=""true""><Column0 ID=""payment_amount""><Caption>Amount</Caption><DataMember>pa" & _
        "yment_amount</DataMember><EditType>NoEdit</EditType><FormatString>c2</FormatStri" & _
        "ng><Key>payment_amount</Key><Position>0</Position><TextAlignment>Far</TextAlignm" & _
        "ent><Width>97</Width></Column0><Column1 ID=""AR_due_date""><Caption>Due Date</Capt" & _
        "ion><DataMember>AR_due_date</DataMember><EditType>NoEdit</EditType><Key>AR_due_d" & _
        "ate</Key><Position>1</Position></Column1><Column2 ID=""amount_Paid""><Caption>Amou" & _
        "nt Paid</Caption><DataMember>amount_Paid</DataMember><EditType>NoEdit</EditType>" & _
        "<FormatString>c2</FormatString><Key>amount_Paid</Key><Position>2</Position><Widt" & _
        "h>96</Width></Column2></Columns><GroupCondition ID="""" /><Key>GL_payment_deposit<" & _
        "/Key></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(6, 218)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(326, 125)
        Me.GridEX1.TabIndex = 373
        Me.GridEX1.TabStop = False
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT GL_payment_deposit.payment_amount, GL_payment_AR.AR_due_date, 0 AS amount_" & _
        "Paid, GL_payment_AR.ID_payment FROM GL_payment_AR LEFT OUTER JOIN GL_payment_dep" & _
        "osit ON GL_payment_AR.ID_payment = GL_payment_deposit.ID_payment WHERE (GL_payme" & _
        "nt_deposit.refer_type = '1') AND (GL_payment_deposit.payment_type = '4') AND (GL" & _
        "_payment_deposit.id_service_center = @id_service_center)"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        '
        'DAGL_payment_deposit
        '
        Me.DAGL_payment_deposit.SelectCommand = Me.SqlSelectCommand4
        Me.DAGL_payment_deposit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("refer_type", "refer_type"), New System.Data.Common.DataColumnMapping("payment_type", "payment_type"), New System.Data.Common.DataColumnMapping("payment_amount", "payment_amount"), New System.Data.Common.DataColumnMapping("flag_deposit_bank", "flag_deposit_bank"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'NumAmountPaid
        '
        Me.NumAmountPaid.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.NumAmountPaid.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumAmountPaid.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumAmountPaid.DecimalDigits = 2
        Me.NumAmountPaid.DefaultSendValue = False
        Me.NumAmountPaid.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumAmountPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumAmountPaid.Image = CType(resources.GetObject("NumAmountPaid.Image"), System.Drawing.Image)
        Me.NumAmountPaid.Location = New System.Drawing.Point(159, 346)
        Me.NumAmountPaid.Maxlength = 10
        Me.NumAmountPaid.MinusColor = System.Drawing.Color.Empty
        Me.NumAmountPaid.Name = "NumAmountPaid"
        Me.NumAmountPaid.ReadOnly = True
        Me.NumAmountPaid.Size = New System.Drawing.Size(98, 21)
        Me.NumAmountPaid.TabIndex = 374
        Me.NumAmountPaid.TabStop = False
        Me.NumAmountPaid.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumAmountPaid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(20, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 19)
        Me.Label4.TabIndex = 375
        Me.Label4.Text = "Amount Paid (A/R)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(119, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 21)
        Me.Label5.TabIndex = 376
        Me.Label5.Text = "A/R Credit"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(-20, 405)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(398, 3)
        Me.GroupBox2.TabIndex = 377
        Me.GroupBox2.TabStop = False
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
        Me.NumBalance.Location = New System.Drawing.Point(120, 414)
        Me.NumBalance.Maxlength = 10
        Me.NumBalance.MinusColor = System.Drawing.Color.Empty
        Me.NumBalance.Name = "NumBalance"
        Me.NumBalance.ReadOnly = True
        Me.NumBalance.Size = New System.Drawing.Size(130, 22)
        Me.NumBalance.TabIndex = 379
        Me.NumBalance.TabStop = False
        Me.NumBalance.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.NumBalance.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(72, 415)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 22)
        Me.Label16.TabIndex = 378
        Me.Label16.Text = "Balance"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumAmountReminder
        '
        Me.NumAmountReminder.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.NumAmountReminder.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumAmountReminder.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumAmountReminder.DecimalDigits = 2
        Me.NumAmountReminder.DefaultSendValue = False
        Me.NumAmountReminder.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumAmountReminder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.NumAmountReminder.Image = CType(resources.GetObject("NumAmountReminder.Image"), System.Drawing.Image)
        Me.NumAmountReminder.Location = New System.Drawing.Point(159, 374)
        Me.NumAmountReminder.Maxlength = 10
        Me.NumAmountReminder.MinusColor = System.Drawing.Color.Empty
        Me.NumAmountReminder.Name = "NumAmountReminder"
        Me.NumAmountReminder.ReadOnly = True
        Me.NumAmountReminder.Size = New System.Drawing.Size(98, 21)
        Me.NumAmountReminder.TabIndex = 380
        Me.NumAmountReminder.TabStop = False
        Me.NumAmountReminder.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumAmountReminder.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(20, 374)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 19)
        Me.Label7.TabIndex = 381
        Me.Label7.Text = "Amount Remainder (A/R)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCashierForReturn
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(338, 471)
        Me.Controls.Add(Me.NumAmountReminder)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NumBalance)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumAmountPaid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.NumChargeAmount)
        Me.Controls.Add(Me.TXTCardNo)
        Me.Controls.Add(Me.CmbCCType)
        Me.Controls.Add(Me.LblCardNo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumCashAmount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CmbGL_account)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnCancel)
        Me.Location = New System.Drawing.Point(200, 200)
        Me.Name = "FrmCashierForReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cashier For Return"
        CType(Me.DsFrmCashierForReturn1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmWorkOrders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        CnnForReader.ConnectionString = PConnectionString

        ThisFormStatus = MainModule.WorkStates._ReadOnly

        DsFrmCashierForReturn1.Clear()
        DAGL_account.Fill(DsFrmCashierForReturn1, "GL_account")
        DAbas_cc_type.Fill(DsFrmCashierForReturn1, "bas_cc_type")
        Call LoadCashierInformation()
        Call EnableDisableBtn()
        Call SetBalanceValue()

        NumCashAmount.Focus()
    End Sub
    Private Sub EnableDisableBtn()
        NumCashAmount.Enabled = False
        NumChargeAmount.Enabled = False
        CmbGL_account.Enabled = False
        CmbCCType.Enabled = False
        TXTCardNo.Enabled = False
        BtnSave.Enabled = False
    End Sub
    Private Sub LoadCashierInformation()
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        If CmdGeneralForReader.Connection.State <> ConnectionState.Open Then
            CmdGeneralForReader.Connection.Open()
        End If
        CmdGeneralForReader.CommandText = "Select amount,GL_account From GL_Paid_received where tran_type='3' AND id_service_center=" & Qt(TxtRefvar)
        SQLReader = CmdGeneralForReader.ExecuteReader
        If SQLReader.HasRows Then
            SQLReader.Read()
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            NumCashAmount.Text = SQLReader.Item("amount")
            CmbGL_account.SelectedValue = SQLReader.Item("GL_account") & ""
        End If
        SQLReader.Close()

        Dim ID_paymentVar As Double
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "Select ID_payment From GL_payment_deposit WHERE id_service_center=" & Qt(TxtRefvar) & " AND refer_type='3' AND payment_type='3' "
        Try
            ID_paymentVar = CmdGeneral.ExecuteScalar()
        Catch ex As Exception
            ID_paymentVar = 0
        End Try
        CmdGeneral.CommandText = "Select payment_amount From GL_payment_deposit WHERE ID_payment=" & Qt(ID_paymentVar)
        Try
            NumChargeAmount.Text = CmdGeneral.ExecuteScalar()
        Catch ex As Exception
            NumChargeAmount.Text = 0
        End Try
        CmdGeneral.CommandText = "Select cc_type From GL_payment_credit WHERE ID_payment=" & Qt(ID_paymentVar)
        Try
            CmbCCType.SelectedValue = CmdGeneral.ExecuteScalar()
        Catch ex As Exception
            CmbCCType.SelectedValue = 0
        End Try
        CmdGeneral.CommandText = "Select cc_card_no From GL_payment_credit WHERE ID_payment=" & Qt(ID_paymentVar)
        Try
            TXTCardNo.Text = CmdGeneral.ExecuteScalar()
        Catch ex As Exception
            TXTCardNo.Clear()
        End Try


        DsFrmCashierForReturn1.GL_payment_deposit.Clear()
        DAGL_payment_deposit.SelectCommand.Parameters("@id_service_center").Value = InvoiceNoForReturnVar
        DAGL_payment_deposit.Fill(DsFrmCashierForReturn1.GL_payment_deposit)

        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If

        CmdGeneral.CommandText = "SELECT sum(payment_amount) FROM GL_payment_deposit WHERE refer_type = '2' AND id_service_center = " & Qt(InvoiceNoForReturnVar)
        Try
            NumAmountPaid.Text = CmdGeneral.ExecuteScalar()
        Catch ex As Exception
            NumAmountPaid.Text = 0
        End Try

        If DsFrmCashierForReturn1.GL_payment_deposit.Rows.Count And NumAmountPaid.Numbervalue > 0 Then
            Dim i As Integer
            Dim PaymentAmountvar As Decimal = NumAmountPaid.Numbervalue
            For i = 0 To DsFrmCashierForReturn1.GL_payment_deposit.Rows.Count - 1
                If PaymentAmountvar > DsFrmCashierForReturn1.GL_payment_deposit.Rows(i).Item("payment_amount") Then
                    DsFrmCashierForReturn1.GL_payment_deposit.Rows(i).Item("amount_Paid") = DsFrmCashierForReturn1.GL_payment_deposit.Rows(i).Item("payment_amount")
                Else
                    DsFrmCashierForReturn1.GL_payment_deposit.Rows(i).Item("amount_Paid") = PaymentAmountvar
                End If
                PaymentAmountvar = PaymentAmountvar - DsFrmCashierForReturn1.GL_payment_deposit.Rows(i).Item("amount_Paid")
            Next
        End If
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Private Sub NumCashAmount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumCashAmount.TextChanged, NumAmountPaid.TextChanged, NumChargeAmount.TextChanged
        Call SetBalanceValue()
    End Sub
    Private Sub SetBalanceValue()
        Dim AmountRemain As Decimal = 0
        Try
            AmountRemain = Math.Round(DsFrmCashierForReturn1.GL_payment_deposit.Compute("Sum(payment_amount)", ""), 2) - NumAmountPaid.Numbervalue
        Catch ex As Exception
            AmountRemain = 0
        End Try
        NumAmountReminder.Text = AmountRemain

        NumBalance.Text = Math.Abs(TotalAmountOfReturnVar) - (NumCashAmount.Numbervalue + NumChargeAmount.Numbervalue + AmountRemain)
    End Sub
End Class
