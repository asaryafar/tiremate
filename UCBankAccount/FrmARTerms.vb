Imports System.Data.SqlClient
Imports CommonClass
Public Class FrmARTerms
    Inherits FrmBase
    Dim Status As WorkStates = MainModule.WorkStates._ReadOnly
    Dim ARTermOrderFieldName As String = "AR_terms"
    Friend ARTermTempVar As String = ""
    Dim PnlSearchHeight As Integer
    Public ARTermVar As String = ""
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
    Friend WithEvents CmGeneral As System.Windows.Forms.ContextMenu
    Friend WithEvents MAddNew As System.Windows.Forms.MenuItem
    Friend WithEvents MEdit As System.Windows.Forms.MenuItem
    Friend WithEvents MDelete As System.Windows.Forms.MenuItem
    Friend WithEvents MSave As System.Windows.Forms.MenuItem
    Friend WithEvents MCancel As System.Windows.Forms.MenuItem
    Friend WithEvents CmdDelete As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents MFirstRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MPreviousRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MNextRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MLastRecord As System.Windows.Forms.MenuItem
    Friend WithEvents CnnTemp As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdInsert As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdUpdate As System.Data.SqlClient.SqlCommand
    Friend WithEvents PnlKartAmvalField As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents BtnFirst As System.Windows.Forms.Button
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel
    Friend WithEvents License_No1 As UCVehicle.License_No
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Command2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Command21 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort3 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents SortByType1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort21 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents RdoStandard As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents RdoDateDriven As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents RdoMultiplePayments As Janus.Windows.EditControls.UIRadioButton
    Friend WithEvents CmbAR_terms As System.Windows.Forms.ComboBox
    Friend WithEvents TxtAR_terms As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_TAB_AR_TERM As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmARTerms1 As UCBankAccount.DSFrmARTerms
    Friend WithEvents NumST_DISCOUNT_PERCENTAGE As CalcUtils.UcCalcText
    Friend WithEvents NumST_NET_DUE_IN As CalcUtils.UcCalcText
    Friend WithEvents NumMP_BEFORE_DAY As CalcUtils.UcCalcText
    Friend WithEvents NumMP_NO_OF_PAYMENT As CalcUtils.UcCalcText
    Friend WithEvents NumDD_IF_ISSUED_WITHIN_DAYS As CalcUtils.UcCalcText
    Friend WithEvents NumDD_IF_PAY_WITHIN_DAYS As CalcUtils.UcCalcText
    Friend WithEvents NumDD_DISCOUNT_PERCENTAGE As CalcUtils.UcCalcText
    Friend WithEvents NumDD_NET_DUE_BEFORE As CalcUtils.UcCalcText
    Friend WithEvents NumST_IF_PAY_WITHIN_DAYS As CalcUtils.UcCalcText
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents NumMP_First_PAYMENT As CalcUtils.UcCalcText
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmARTerms))
        Me.CmGeneral = New System.Windows.Forms.ContextMenu
        Me.MAddNew = New System.Windows.Forms.MenuItem
        Me.MEdit = New System.Windows.Forms.MenuItem
        Me.MDelete = New System.Windows.Forms.MenuItem
        Me.MSave = New System.Windows.Forms.MenuItem
        Me.MCancel = New System.Windows.Forms.MenuItem
        Me.MFirstRecord = New System.Windows.Forms.MenuItem
        Me.MPreviousRecord = New System.Windows.Forms.MenuItem
        Me.MNextRecord = New System.Windows.Forms.MenuItem
        Me.MLastRecord = New System.Windows.Forms.MenuItem
        Me.CmdDelete = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.CmbAR_terms = New System.Windows.Forms.ComboBox
        Me.DsFrmARTerms1 = New UCBankAccount.DSFrmARTerms
        Me.Label4 = New System.Windows.Forms.Label
        Me.CnnTemp = New System.Data.SqlClient.SqlConnection
        Me.PnlKartAmvalField = New System.Windows.Forms.Panel
        Me.Label15 = New System.Windows.Forms.Label
        Me.NumMP_First_PAYMENT = New CalcUtils.UcCalcText
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.NumMP_BEFORE_DAY = New CalcUtils.UcCalcText
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.NumMP_NO_OF_PAYMENT = New CalcUtils.UcCalcText
        Me.RdoMultiplePayments = New Janus.Windows.EditControls.UIRadioButton
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.NumDD_IF_ISSUED_WITHIN_DAYS = New CalcUtils.UcCalcText
        Me.Label13 = New System.Windows.Forms.Label
        Me.NumDD_IF_PAY_WITHIN_DAYS = New CalcUtils.UcCalcText
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.NumDD_DISCOUNT_PERCENTAGE = New CalcUtils.UcCalcText
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.NumDD_NET_DUE_BEFORE = New CalcUtils.UcCalcText
        Me.RdoDateDriven = New Janus.Windows.EditControls.UIRadioButton
        Me.Label11 = New System.Windows.Forms.Label
        Me.NumST_IF_PAY_WITHIN_DAYS = New CalcUtils.UcCalcText
        Me.Label2 = New System.Windows.Forms.Label
        Me.NumST_DISCOUNT_PERCENTAGE = New CalcUtils.UcCalcText
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.NumST_NET_DUE_IN = New CalcUtils.UcCalcText
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RdoStandard = New Janus.Windows.EditControls.UIRadioButton
        Me.Label38 = New System.Windows.Forms.Label
        Me.TxtAR_terms = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.CmdInsert = New System.Data.SqlClient.SqlCommand
        Me.CmdUpdate = New System.Data.SqlClient.SqlCommand
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label40 = New System.Windows.Forms.Label
        Me.BtnFirst = New System.Windows.Forms.Button
        Me.Label41 = New System.Windows.Forms.Label
        Me.BtnLast = New System.Windows.Forms.Button
        Me.Label42 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.Label43 = New System.Windows.Forms.Label
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnNew = New System.Windows.Forms.Button
        Me.BtnNext = New System.Windows.Forms.Button
        Me.BtnPrev = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Sort2 = New Janus.Windows.UI.CommandBars.UICommand("Sort2")
        Me.Sort21 = New Janus.Windows.UI.CommandBars.UICommand("Sort2")
        Me.Sort3 = New Janus.Windows.UI.CommandBars.UICommand("SortByType")
        Me.SortByType1 = New Janus.Windows.UI.CommandBars.UICommand("SortByType")
        Me.Command2 = New Janus.Windows.UI.CommandBars.UICommand("Command2")
        Me.Command21 = New Janus.Windows.UI.CommandBars.UICommand("Command2")
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_TAB_AR_TERM = New System.Data.SqlClient.SqlDataAdapter
        Me.PnlSearch.SuspendLayout()
        CType(Me.DsFrmARTerms1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlKartAmvalField.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmGeneral
        '
        Me.CmGeneral.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MAddNew, Me.MEdit, Me.MDelete, Me.MSave, Me.MCancel, Me.MFirstRecord, Me.MPreviousRecord, Me.MNextRecord, Me.MLastRecord})
        Me.CmGeneral.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'MAddNew
        '
        Me.MAddNew.Index = 0
        Me.MAddNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.MAddNew.Text = "ÇíÌÇÏ"
        '
        'MEdit
        '
        Me.MEdit.Index = 1
        Me.MEdit.Shortcut = System.Windows.Forms.Shortcut.CtrlE
        Me.MEdit.Text = "ÇÕáÇÍ"
        '
        'MDelete
        '
        Me.MDelete.Index = 2
        Me.MDelete.Shortcut = System.Windows.Forms.Shortcut.CtrlD
        Me.MDelete.Text = "ÍÐÝ"
        '
        'MSave
        '
        Me.MSave.Enabled = False
        Me.MSave.Index = 3
        Me.MSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.MSave.Text = "ËÈÊ"
        '
        'MCancel
        '
        Me.MCancel.Enabled = False
        Me.MCancel.Index = 4
        Me.MCancel.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MCancel.Text = "áÛæ"
        '
        'MFirstRecord
        '
        Me.MFirstRecord.Index = 5
        Me.MFirstRecord.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftV
        Me.MFirstRecord.Text = "ÇÈÊÏÇ"
        '
        'MPreviousRecord
        '
        Me.MPreviousRecord.Index = 6
        Me.MPreviousRecord.Text = "ÞÈáí"
        '
        'MNextRecord
        '
        Me.MNextRecord.Index = 7
        Me.MNextRecord.Text = "ÈÚÏí"
        '
        'MLastRecord
        '
        Me.MLastRecord.Index = 8
        Me.MLastRecord.Text = "ÇäÊåÇ"
        '
        'CmdDelete
        '
        Me.CmdDelete.CommandText = "DELETE FROM GL_TAB_AR_TERM WHERE (AR_terms = @AR_terms)"
        Me.CmdDelete.Connection = Me.Cnn
        Me.CmdDelete.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_terms", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_terms", System.Data.DataRowVersion.Original, Nothing))
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEHXP;packet size=4096;user id=sa;data source=""."";persist sec" & _
        "urity info=True;initial catalog=TireMate_07"
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.CmbAR_terms)
        Me.PnlSearch.Controls.Add(Me.Label4)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 45)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(369, 27)
        Me.PnlSearch.TabIndex = 0
        '
        'CmbAR_terms
        '
        Me.CmbAR_terms.DataSource = Me.DsFrmARTerms1.GL_TAB_AR_TERM
        Me.CmbAR_terms.DisplayMember = "AR_terms"
        Me.CmbAR_terms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAR_terms.Location = New System.Drawing.Point(67, 1)
        Me.CmbAR_terms.MaxLength = 1
        Me.CmbAR_terms.Name = "CmbAR_terms"
        Me.CmbAR_terms.Size = New System.Drawing.Size(133, 21)
        Me.CmbAR_terms.TabIndex = 0
        Me.CmbAR_terms.ValueMember = "AR_terms"
        '
        'DsFrmARTerms1
        '
        Me.DsFrmARTerms1.DataSetName = "DSFrmARTerms"
        Me.DsFrmARTerms1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(5, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 12)
        Me.Label4.TabIndex = 188
        Me.Label4.Text = "A/R Terms"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CnnTemp
        '
        Me.CnnTemp.ConnectionString = "workstation id=ARMANDEHXP;packet size=4096;user id=sa;data source=""."";persist sec" & _
        "urity info=True;initial catalog=TireMate_07"
        '
        'PnlKartAmvalField
        '
        Me.PnlKartAmvalField.Controls.Add(Me.Label15)
        Me.PnlKartAmvalField.Controls.Add(Me.NumMP_First_PAYMENT)
        Me.PnlKartAmvalField.Controls.Add(Me.Label19)
        Me.PnlKartAmvalField.Controls.Add(Me.Label14)
        Me.PnlKartAmvalField.Controls.Add(Me.NumMP_BEFORE_DAY)
        Me.PnlKartAmvalField.Controls.Add(Me.Label16)
        Me.PnlKartAmvalField.Controls.Add(Me.Label17)
        Me.PnlKartAmvalField.Controls.Add(Me.NumMP_NO_OF_PAYMENT)
        Me.PnlKartAmvalField.Controls.Add(Me.RdoMultiplePayments)
        Me.PnlKartAmvalField.Controls.Add(Me.Label18)
        Me.PnlKartAmvalField.Controls.Add(Me.Label12)
        Me.PnlKartAmvalField.Controls.Add(Me.NumDD_IF_ISSUED_WITHIN_DAYS)
        Me.PnlKartAmvalField.Controls.Add(Me.Label13)
        Me.PnlKartAmvalField.Controls.Add(Me.NumDD_IF_PAY_WITHIN_DAYS)
        Me.PnlKartAmvalField.Controls.Add(Me.Label7)
        Me.PnlKartAmvalField.Controls.Add(Me.Label8)
        Me.PnlKartAmvalField.Controls.Add(Me.NumDD_DISCOUNT_PERCENTAGE)
        Me.PnlKartAmvalField.Controls.Add(Me.Label9)
        Me.PnlKartAmvalField.Controls.Add(Me.Label10)
        Me.PnlKartAmvalField.Controls.Add(Me.NumDD_NET_DUE_BEFORE)
        Me.PnlKartAmvalField.Controls.Add(Me.RdoDateDriven)
        Me.PnlKartAmvalField.Controls.Add(Me.Label11)
        Me.PnlKartAmvalField.Controls.Add(Me.NumST_IF_PAY_WITHIN_DAYS)
        Me.PnlKartAmvalField.Controls.Add(Me.Label2)
        Me.PnlKartAmvalField.Controls.Add(Me.NumST_DISCOUNT_PERCENTAGE)
        Me.PnlKartAmvalField.Controls.Add(Me.Label3)
        Me.PnlKartAmvalField.Controls.Add(Me.Label1)
        Me.PnlKartAmvalField.Controls.Add(Me.NumST_NET_DUE_IN)
        Me.PnlKartAmvalField.Controls.Add(Me.Panel3)
        Me.PnlKartAmvalField.Controls.Add(Me.Panel2)
        Me.PnlKartAmvalField.Controls.Add(Me.Panel1)
        Me.PnlKartAmvalField.Controls.Add(Me.RdoStandard)
        Me.PnlKartAmvalField.Controls.Add(Me.Label38)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtAR_terms)
        Me.PnlKartAmvalField.Controls.Add(Me.Label5)
        Me.PnlKartAmvalField.Controls.Add(Me.Label6)
        Me.PnlKartAmvalField.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlKartAmvalField.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlKartAmvalField.Location = New System.Drawing.Point(0, 72)
        Me.PnlKartAmvalField.Name = "PnlKartAmvalField"
        Me.PnlKartAmvalField.Size = New System.Drawing.Size(369, 342)
        Me.PnlKartAmvalField.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(210, 288)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 19)
        Me.Label15.TabIndex = 410
        Me.Label15.Text = "days."
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumMP_First_PAYMENT
        '
        Me.NumMP_First_PAYMENT.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumMP_First_PAYMENT.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumMP_First_PAYMENT.DecimalDigits = 0
        Me.NumMP_First_PAYMENT.DefaultSendValue = False
        Me.NumMP_First_PAYMENT.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumMP_First_PAYMENT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumMP_First_PAYMENT.Image = CType(resources.GetObject("NumMP_First_PAYMENT.Image"), System.Drawing.Image)
        Me.NumMP_First_PAYMENT.Location = New System.Drawing.Point(145, 288)
        Me.NumMP_First_PAYMENT.Maxlength = 3
        Me.NumMP_First_PAYMENT.MinusColor = System.Drawing.Color.Empty
        Me.NumMP_First_PAYMENT.Name = "NumMP_First_PAYMENT"
        Me.NumMP_First_PAYMENT.Size = New System.Drawing.Size(61, 21)
        Me.NumMP_First_PAYMENT.TabIndex = 12
        Me.NumMP_First_PAYMENT.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumMP_First_PAYMENT.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(41, 289)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(110, 19)
        Me.Label19.TabIndex = 409
        Me.Label19.Text = "First payment due in"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(249, 316)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 19)
        Me.Label14.TabIndex = 407
        Me.Label14.Text = "th day of the month."
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumMP_BEFORE_DAY
        '
        Me.NumMP_BEFORE_DAY.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumMP_BEFORE_DAY.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumMP_BEFORE_DAY.DecimalDigits = 0
        Me.NumMP_BEFORE_DAY.DefaultSendValue = False
        Me.NumMP_BEFORE_DAY.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumMP_BEFORE_DAY.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumMP_BEFORE_DAY.Image = CType(resources.GetObject("NumMP_BEFORE_DAY.Image"), System.Drawing.Image)
        Me.NumMP_BEFORE_DAY.Location = New System.Drawing.Point(184, 315)
        Me.NumMP_BEFORE_DAY.Maxlength = 3
        Me.NumMP_BEFORE_DAY.MinusColor = System.Drawing.Color.Empty
        Me.NumMP_BEFORE_DAY.Name = "NumMP_BEFORE_DAY"
        Me.NumMP_BEFORE_DAY.Size = New System.Drawing.Size(61, 21)
        Me.NumMP_BEFORE_DAY.TabIndex = 13
        Me.NumMP_BEFORE_DAY.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumMP_BEFORE_DAY.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(37, 316)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(155, 19)
        Me.Label16.TabIndex = 405
        Me.Label16.Text = "Each payment due before the"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(186, 260)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 19)
        Me.Label17.TabIndex = 404
        Me.Label17.Text = "days."
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumMP_NO_OF_PAYMENT
        '
        Me.NumMP_NO_OF_PAYMENT.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumMP_NO_OF_PAYMENT.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumMP_NO_OF_PAYMENT.DecimalDigits = 0
        Me.NumMP_NO_OF_PAYMENT.DefaultSendValue = False
        Me.NumMP_NO_OF_PAYMENT.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumMP_NO_OF_PAYMENT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumMP_NO_OF_PAYMENT.Image = CType(resources.GetObject("NumMP_NO_OF_PAYMENT.Image"), System.Drawing.Image)
        Me.NumMP_NO_OF_PAYMENT.Location = New System.Drawing.Point(121, 261)
        Me.NumMP_NO_OF_PAYMENT.Maxlength = 3
        Me.NumMP_NO_OF_PAYMENT.MinusColor = System.Drawing.Color.Empty
        Me.NumMP_NO_OF_PAYMENT.Name = "NumMP_NO_OF_PAYMENT"
        Me.NumMP_NO_OF_PAYMENT.Size = New System.Drawing.Size(61, 21)
        Me.NumMP_NO_OF_PAYMENT.TabIndex = 11
        Me.NumMP_NO_OF_PAYMENT.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumMP_NO_OF_PAYMENT.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'RdoMultiplePayments
        '
        Me.RdoMultiplePayments.Location = New System.Drawing.Point(5, 233)
        Me.RdoMultiplePayments.Name = "RdoMultiplePayments"
        Me.RdoMultiplePayments.Size = New System.Drawing.Size(117, 23)
        Me.RdoMultiplePayments.TabIndex = 10
        Me.RdoMultiplePayments.Text = "Multiple Payments"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(39, 262)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 19)
        Me.Label18.TabIndex = 401
        Me.Label18.Text = "No of payments"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(279, 176)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 19)
        Me.Label12.TabIndex = 400
        Me.Label12.Text = "days of due date."
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumDD_IF_ISSUED_WITHIN_DAYS
        '
        Me.NumDD_IF_ISSUED_WITHIN_DAYS.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDD_IF_ISSUED_WITHIN_DAYS.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumDD_IF_ISSUED_WITHIN_DAYS.DecimalDigits = 0
        Me.NumDD_IF_ISSUED_WITHIN_DAYS.DefaultSendValue = False
        Me.NumDD_IF_ISSUED_WITHIN_DAYS.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDD_IF_ISSUED_WITHIN_DAYS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumDD_IF_ISSUED_WITHIN_DAYS.Image = CType(resources.GetObject("NumDD_IF_ISSUED_WITHIN_DAYS.Image"), System.Drawing.Image)
        Me.NumDD_IF_ISSUED_WITHIN_DAYS.Location = New System.Drawing.Point(214, 175)
        Me.NumDD_IF_ISSUED_WITHIN_DAYS.Maxlength = 3
        Me.NumDD_IF_ISSUED_WITHIN_DAYS.MinusColor = System.Drawing.Color.Empty
        Me.NumDD_IF_ISSUED_WITHIN_DAYS.Name = "NumDD_IF_ISSUED_WITHIN_DAYS"
        Me.NumDD_IF_ISSUED_WITHIN_DAYS.Size = New System.Drawing.Size(61, 21)
        Me.NumDD_IF_ISSUED_WITHIN_DAYS.TabIndex = 7
        Me.NumDD_IF_ISSUED_WITHIN_DAYS.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDD_IF_ISSUED_WITHIN_DAYS.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(38, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(183, 19)
        Me.Label13.TabIndex = 398
        Me.Label13.Text = "Due the next month if issued within"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumDD_IF_PAY_WITHIN_DAYS
        '
        Me.NumDD_IF_PAY_WITHIN_DAYS.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDD_IF_PAY_WITHIN_DAYS.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumDD_IF_PAY_WITHIN_DAYS.DecimalDigits = 0
        Me.NumDD_IF_PAY_WITHIN_DAYS.DefaultSendValue = False
        Me.NumDD_IF_PAY_WITHIN_DAYS.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDD_IF_PAY_WITHIN_DAYS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumDD_IF_PAY_WITHIN_DAYS.Image = CType(resources.GetObject("NumDD_IF_PAY_WITHIN_DAYS.Image"), System.Drawing.Image)
        Me.NumDD_IF_PAY_WITHIN_DAYS.Location = New System.Drawing.Point(273, 203)
        Me.NumDD_IF_PAY_WITHIN_DAYS.Maxlength = 3
        Me.NumDD_IF_PAY_WITHIN_DAYS.MinusColor = System.Drawing.Color.Empty
        Me.NumDD_IF_PAY_WITHIN_DAYS.Name = "NumDD_IF_PAY_WITHIN_DAYS"
        Me.NumDD_IF_PAY_WITHIN_DAYS.Size = New System.Drawing.Size(61, 21)
        Me.NumDD_IF_PAY_WITHIN_DAYS.TabIndex = 9
        Me.NumDD_IF_PAY_WITHIN_DAYS.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDD_IF_PAY_WITHIN_DAYS.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(335, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 19)
        Me.Label7.TabIndex = 396
        Me.Label7.Text = "days."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(220, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 19)
        Me.Label8.TabIndex = 395
        Me.Label8.Text = ". If paid in"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumDD_DISCOUNT_PERCENTAGE
        '
        Me.NumDD_DISCOUNT_PERCENTAGE.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDD_DISCOUNT_PERCENTAGE.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumDD_DISCOUNT_PERCENTAGE.DecimalDigits = 1
        Me.NumDD_DISCOUNT_PERCENTAGE.DefaultSendValue = False
        Me.NumDD_DISCOUNT_PERCENTAGE.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDD_DISCOUNT_PERCENTAGE.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumDD_DISCOUNT_PERCENTAGE.Image = CType(resources.GetObject("NumDD_DISCOUNT_PERCENTAGE.Image"), System.Drawing.Image)
        Me.NumDD_DISCOUNT_PERCENTAGE.Location = New System.Drawing.Point(155, 201)
        Me.NumDD_DISCOUNT_PERCENTAGE.Maxlength = 4
        Me.NumDD_DISCOUNT_PERCENTAGE.MinusColor = System.Drawing.Color.Empty
        Me.NumDD_DISCOUNT_PERCENTAGE.Name = "NumDD_DISCOUNT_PERCENTAGE"
        Me.NumDD_DISCOUNT_PERCENTAGE.Size = New System.Drawing.Size(61, 21)
        Me.NumDD_DISCOUNT_PERCENTAGE.TabIndex = 8
        Me.NumDD_DISCOUNT_PERCENTAGE.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDD_DISCOUNT_PERCENTAGE.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(38, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 19)
        Me.Label9.TabIndex = 393
        Me.Label9.Text = "Discount Percentage is"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(201, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 19)
        Me.Label10.TabIndex = 392
        Me.Label10.Text = "th day of the month."
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumDD_NET_DUE_BEFORE
        '
        Me.NumDD_NET_DUE_BEFORE.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDD_NET_DUE_BEFORE.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumDD_NET_DUE_BEFORE.DecimalDigits = 0
        Me.NumDD_NET_DUE_BEFORE.DefaultSendValue = False
        Me.NumDD_NET_DUE_BEFORE.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDD_NET_DUE_BEFORE.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumDD_NET_DUE_BEFORE.Image = CType(resources.GetObject("NumDD_NET_DUE_BEFORE.Image"), System.Drawing.Image)
        Me.NumDD_NET_DUE_BEFORE.Location = New System.Drawing.Point(136, 150)
        Me.NumDD_NET_DUE_BEFORE.Maxlength = 3
        Me.NumDD_NET_DUE_BEFORE.MinusColor = System.Drawing.Color.Empty
        Me.NumDD_NET_DUE_BEFORE.Name = "NumDD_NET_DUE_BEFORE"
        Me.NumDD_NET_DUE_BEFORE.Size = New System.Drawing.Size(61, 21)
        Me.NumDD_NET_DUE_BEFORE.TabIndex = 6
        Me.NumDD_NET_DUE_BEFORE.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDD_NET_DUE_BEFORE.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'RdoDateDriven
        '
        Me.RdoDateDriven.Location = New System.Drawing.Point(7, 122)
        Me.RdoDateDriven.Name = "RdoDateDriven"
        Me.RdoDateDriven.Size = New System.Drawing.Size(104, 23)
        Me.RdoDateDriven.TabIndex = 5
        Me.RdoDateDriven.Text = "Date Driven"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(40, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 19)
        Me.Label11.TabIndex = 389
        Me.Label11.Text = "Net due before the"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumST_IF_PAY_WITHIN_DAYS
        '
        Me.NumST_IF_PAY_WITHIN_DAYS.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumST_IF_PAY_WITHIN_DAYS.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumST_IF_PAY_WITHIN_DAYS.DecimalDigits = 0
        Me.NumST_IF_PAY_WITHIN_DAYS.DefaultSendValue = False
        Me.NumST_IF_PAY_WITHIN_DAYS.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumST_IF_PAY_WITHIN_DAYS.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumST_IF_PAY_WITHIN_DAYS.Image = CType(resources.GetObject("NumST_IF_PAY_WITHIN_DAYS.Image"), System.Drawing.Image)
        Me.NumST_IF_PAY_WITHIN_DAYS.Location = New System.Drawing.Point(273, 90)
        Me.NumST_IF_PAY_WITHIN_DAYS.Maxlength = 3
        Me.NumST_IF_PAY_WITHIN_DAYS.MinusColor = System.Drawing.Color.Empty
        Me.NumST_IF_PAY_WITHIN_DAYS.Name = "NumST_IF_PAY_WITHIN_DAYS"
        Me.NumST_IF_PAY_WITHIN_DAYS.Size = New System.Drawing.Size(61, 21)
        Me.NumST_IF_PAY_WITHIN_DAYS.TabIndex = 4
        Me.NumST_IF_PAY_WITHIN_DAYS.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumST_IF_PAY_WITHIN_DAYS.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(220, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 19)
        Me.Label2.TabIndex = 386
        Me.Label2.Text = ". If paid in"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumST_DISCOUNT_PERCENTAGE
        '
        Me.NumST_DISCOUNT_PERCENTAGE.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumST_DISCOUNT_PERCENTAGE.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumST_DISCOUNT_PERCENTAGE.DecimalDigits = 1
        Me.NumST_DISCOUNT_PERCENTAGE.DefaultSendValue = False
        Me.NumST_DISCOUNT_PERCENTAGE.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumST_DISCOUNT_PERCENTAGE.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumST_DISCOUNT_PERCENTAGE.Image = CType(resources.GetObject("NumST_DISCOUNT_PERCENTAGE.Image"), System.Drawing.Image)
        Me.NumST_DISCOUNT_PERCENTAGE.Location = New System.Drawing.Point(155, 88)
        Me.NumST_DISCOUNT_PERCENTAGE.Maxlength = 4
        Me.NumST_DISCOUNT_PERCENTAGE.MinusColor = System.Drawing.Color.Empty
        Me.NumST_DISCOUNT_PERCENTAGE.Name = "NumST_DISCOUNT_PERCENTAGE"
        Me.NumST_DISCOUNT_PERCENTAGE.Size = New System.Drawing.Size(61, 21)
        Me.NumST_DISCOUNT_PERCENTAGE.TabIndex = 3
        Me.NumST_DISCOUNT_PERCENTAGE.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumST_DISCOUNT_PERCENTAGE.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(38, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 19)
        Me.Label3.TabIndex = 384
        Me.Label3.Text = "Discount Percentage is"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(161, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 19)
        Me.Label1.TabIndex = 383
        Me.Label1.Text = "days."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumST_NET_DUE_IN
        '
        Me.NumST_NET_DUE_IN.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumST_NET_DUE_IN.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumST_NET_DUE_IN.DecimalDigits = 0
        Me.NumST_NET_DUE_IN.DefaultSendValue = False
        Me.NumST_NET_DUE_IN.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumST_NET_DUE_IN.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumST_NET_DUE_IN.Image = CType(resources.GetObject("NumST_NET_DUE_IN.Image"), System.Drawing.Image)
        Me.NumST_NET_DUE_IN.Location = New System.Drawing.Point(96, 63)
        Me.NumST_NET_DUE_IN.Maxlength = 3
        Me.NumST_NET_DUE_IN.MinusColor = System.Drawing.Color.Empty
        Me.NumST_NET_DUE_IN.Name = "NumST_NET_DUE_IN"
        Me.NumST_NET_DUE_IN.Size = New System.Drawing.Size(61, 21)
        Me.NumST_NET_DUE_IN.TabIndex = 2
        Me.NumST_NET_DUE_IN.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumST_NET_DUE_IN.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(-35, 228)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(546, 1)
        Me.Panel3.TabIndex = 381
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(-35, 116)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(546, 1)
        Me.Panel2.TabIndex = 380
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(-9, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(546, 1)
        Me.Panel1.TabIndex = 1
        '
        'RdoStandard
        '
        Me.RdoStandard.Checked = True
        Me.RdoStandard.Location = New System.Drawing.Point(8, 35)
        Me.RdoStandard.Name = "RdoStandard"
        Me.RdoStandard.Size = New System.Drawing.Size(104, 23)
        Me.RdoStandard.TabIndex = 1
        Me.RdoStandard.Text = "Standard"
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.SystemColors.Control
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label38.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label38.Location = New System.Drawing.Point(40, 64)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(60, 19)
        Me.Label38.TabIndex = 374
        Me.Label38.Text = "Net due in"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtAR_terms
        '
        Me.TxtAR_terms.Location = New System.Drawing.Point(74, 5)
        Me.TxtAR_terms.MaxLength = 50
        Me.TxtAR_terms.Name = "TxtAR_terms"
        Me.TxtAR_terms.Size = New System.Drawing.Size(129, 21)
        Me.TxtAR_terms.TabIndex = 0
        Me.TxtAR_terms.Text = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(2, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 328
        Me.Label5.Text = "A/R Terms"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(335, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 19)
        Me.Label6.TabIndex = 387
        Me.Label6.Text = "days."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'CmdInsert
        '
        Me.CmdInsert.CommandText = "INSERT INTO GL_TAB_AR_TERM (AR_terms, KIND_AR, ST_NET_DUE_IN, ST_DISCOUNT_PERCENT" & _
        "AGE, ST_IF_PAY_WITHIN_DAYS, DD_NET_DUE_BEFORE, DD_IF_ISSUED_WITHIN_DAYS, DD_DISC" & _
        "OUNT_PERCENTAGE, DD_IF_PAY_WITHIN_DAYS, MP_NO_OF_PAYMENT, MP_BEFORE_DAY, MP_Firs" & _
        "t_PAYMENT) VALUES (@AR_terms, @KIND_AR, @ST_NET_DUE_IN, @ST_DISCOUNT_PERCENTAGE," & _
        " @ST_IF_PAY_WITHIN_DAYS, @DD_NET_DUE_BEFORE, @DD_IF_ISSUED_WITHIN_DAYS, @DD_DISC" & _
        "OUNT_PERCENTAGE, @DD_IF_PAY_WITHIN_DAYS, @MP_NO_OF_PAYMENT, @MP_BEFORE_DAY, @MP_" & _
        "First_PAYMENT)"
        Me.CmdInsert.Connection = Me.CnnTemp
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_terms", System.Data.SqlDbType.VarChar, 10, "AR_terms"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@KIND_AR", System.Data.SqlDbType.SmallInt, 2, "KIND_AR"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_NET_DUE_IN", System.Data.SqlDbType.SmallInt, 2, "ST_NET_DUE_IN"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "ST_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Current, Nothing))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "ST_IF_PAY_WITHIN_DAYS"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_NET_DUE_BEFORE", System.Data.SqlDbType.SmallInt, 2, "DD_NET_DUE_BEFORE"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_IF_ISSUED_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "DD_IF_ISSUED_WITHIN_DAYS"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "DD_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Current, Nothing))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "DD_IF_PAY_WITHIN_DAYS"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_NO_OF_PAYMENT", System.Data.SqlDbType.SmallInt, 2, "MP_NO_OF_PAYMENT"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_BEFORE_DAY", System.Data.SqlDbType.SmallInt, 2, "MP_BEFORE_DAY"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_First_PAYMENT", System.Data.SqlDbType.SmallInt, 2, "MP_First_PAYMENT"))
        '
        'CmdUpdate
        '
        Me.CmdUpdate.CommandText = "UPDATE GL_TAB_AR_TERM SET KIND_AR = @KIND_AR, ST_NET_DUE_IN = @ST_NET_DUE_IN, ST_" & _
        "DISCOUNT_PERCENTAGE = @ST_DISCOUNT_PERCENTAGE, ST_IF_PAY_WITHIN_DAYS = @ST_IF_PA" & _
        "Y_WITHIN_DAYS, DD_NET_DUE_BEFORE = @DD_NET_DUE_BEFORE, DD_IF_ISSUED_WITHIN_DAYS " & _
        "= @DD_IF_ISSUED_WITHIN_DAYS, DD_DISCOUNT_PERCENTAGE = @DD_DISCOUNT_PERCENTAGE, D" & _
        "D_IF_PAY_WITHIN_DAYS = @DD_IF_PAY_WITHIN_DAYS, MP_NO_OF_PAYMENT = @MP_NO_OF_PAYM" & _
        "ENT, MP_BEFORE_DAY = @MP_BEFORE_DAY, MP_First_PAYMENT = @MP_First_PAYMENT WHERE " & _
        "(AR_terms = @AR_terms)"
        Me.CmdUpdate.Connection = Me.Cnn
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@KIND_AR", System.Data.SqlDbType.SmallInt, 2, "KIND_AR"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_NET_DUE_IN", System.Data.SqlDbType.SmallInt, 2, "ST_NET_DUE_IN"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "ST_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Current, Nothing))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "ST_IF_PAY_WITHIN_DAYS"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_NET_DUE_BEFORE", System.Data.SqlDbType.SmallInt, 2, "DD_NET_DUE_BEFORE"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_IF_ISSUED_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "DD_IF_ISSUED_WITHIN_DAYS"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "DD_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Current, Nothing))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "DD_IF_PAY_WITHIN_DAYS"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_NO_OF_PAYMENT", System.Data.SqlDbType.SmallInt, 2, "MP_NO_OF_PAYMENT"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_BEFORE_DAY", System.Data.SqlDbType.SmallInt, 2, "MP_BEFORE_DAY"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_First_PAYMENT", System.Data.SqlDbType.SmallInt, 2, "MP_First_PAYMENT"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_terms", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_terms", System.Data.DataRowVersion.Original, Nothing))
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Window
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label40)
        Me.Panel9.Controls.Add(Me.BtnFirst)
        Me.Panel9.Controls.Add(Me.Label41)
        Me.Panel9.Controls.Add(Me.BtnLast)
        Me.Panel9.Controls.Add(Me.Label42)
        Me.Panel9.Controls.Add(Me.BtnCancel)
        Me.Panel9.Controls.Add(Me.Label43)
        Me.Panel9.Controls.Add(Me.BtnEdit)
        Me.Panel9.Controls.Add(Me.Label50)
        Me.Panel9.Controls.Add(Me.Label51)
        Me.Panel9.Controls.Add(Me.Label52)
        Me.Panel9.Controls.Add(Me.Label54)
        Me.Panel9.Controls.Add(Me.Label55)
        Me.Panel9.Controls.Add(Me.BtnDelete)
        Me.Panel9.Controls.Add(Me.BtnNew)
        Me.Panel9.Controls.Add(Me.BtnNext)
        Me.Panel9.Controls.Add(Me.BtnPrev)
        Me.Panel9.Controls.Add(Me.BtnSave)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(369, 45)
        Me.Panel9.TabIndex = 2
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Location = New System.Drawing.Point(6, 31)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(33, 10)
        Me.Label40.TabIndex = 192
        Me.Label40.Text = "First"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnFirst
        '
        Me.BtnFirst.BackColor = System.Drawing.SystemColors.Window
        Me.BtnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFirst.Image = CType(resources.GetObject("BtnFirst.Image"), System.Drawing.Image)
        Me.BtnFirst.Location = New System.Drawing.Point(3, 2)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(33, 27)
        Me.BtnFirst.TabIndex = 191
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Location = New System.Drawing.Point(117, 31)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(33, 10)
        Me.Label41.TabIndex = 189
        Me.Label41.Text = "Last"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnLast
        '
        Me.BtnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLast.Image = CType(resources.GetObject("BtnLast.Image"), System.Drawing.Image)
        Me.BtnLast.Location = New System.Drawing.Point(117, 2)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(33, 27)
        Me.BtnLast.TabIndex = 188
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Location = New System.Drawing.Point(324, 31)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(39, 10)
        Me.Label42.TabIndex = 186
        Me.Label42.Text = "Cancel"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.Enabled = False
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(327, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 27)
        Me.BtnCancel.TabIndex = 7
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Location = New System.Drawing.Point(212, 31)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(33, 10)
        Me.Label43.TabIndex = 184
        Me.Label43.Text = "Edit"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEdit
        '
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.Location = New System.Drawing.Point(213, 2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(33, 27)
        Me.BtnEdit.TabIndex = 4
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Location = New System.Drawing.Point(286, 31)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(33, 10)
        Me.Label50.TabIndex = 176
        Me.Label50.Text = "Save"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Location = New System.Drawing.Point(247, 31)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(37, 10)
        Me.Label51.TabIndex = 175
        Me.Label51.Text = "Delete"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Location = New System.Drawing.Point(174, 31)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(33, 10)
        Me.Label52.TabIndex = 174
        Me.Label52.Text = "New"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Location = New System.Drawing.Point(41, 31)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(33, 10)
        Me.Label54.TabIndex = 172
        Me.Label54.Text = "Prev"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Location = New System.Drawing.Point(81, 31)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(33, 10)
        Me.Label55.TabIndex = 171
        Me.Label55.Text = "Next"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnDelete
        '
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(251, 2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(33, 27)
        Me.BtnDelete.TabIndex = 5
        '
        'BtnNew
        '
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Location = New System.Drawing.Point(175, 2)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(33, 27)
        Me.BtnNew.TabIndex = 3
        '
        'BtnNext
        '
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNext.Image = CType(resources.GetObject("BtnNext.Image"), System.Drawing.Image)
        Me.BtnNext.Location = New System.Drawing.Point(79, 2)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(33, 27)
        Me.BtnNext.TabIndex = 1
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.SystemColors.Window
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrev.Image = CType(resources.GetObject("BtnPrev.Image"), System.Drawing.Image)
        Me.BtnPrev.Location = New System.Drawing.Point(41, 2)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrev.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(289, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 6
        '
        'Sort2
        '
        Me.Sort2.Key = "Sort2"
        Me.Sort2.Name = "Sort2"
        Me.Sort2.Text = "Order By Account No"
        '
        'Sort21
        '
        Me.Sort21.Key = "Sort2"
        Me.Sort21.Name = "Sort21"
        '
        'Sort3
        '
        Me.Sort3.Key = "SortByType"
        Me.Sort3.Name = "Sort3"
        Me.Sort3.Text = "Sort By Type"
        '
        'SortByType1
        '
        Me.SortByType1.Key = "SortByType"
        Me.SortByType1.Name = "SortByType1"
        '
        'Command2
        '
        Me.Command2.Key = "Command2"
        Me.Command2.Name = "Command2"
        Me.Command2.Text = "2222222"
        '
        'Command21
        '
        Me.Command21.Key = "Command2"
        Me.Command21.Name = "Command21"
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT AR_terms, KIND_AR, ST_NET_DUE_IN, ST_DISCOUNT_PERCENTAGE, ST_IF_PAY_WITHIN" & _
        "_DAYS, DD_NET_DUE_BEFORE, DD_IF_ISSUED_WITHIN_DAYS, DD_DISCOUNT_PERCENTAGE, DD_I" & _
        "F_PAY_WITHIN_DAYS, MP_NO_OF_PAYMENT, MP_BEFORE_DAY FROM GL_TAB_AR_TERM"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'DAGL_TAB_AR_TERM
        '
        Me.DAGL_TAB_AR_TERM.SelectCommand = Me.SqlSelectCommand4
        Me.DAGL_TAB_AR_TERM.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_TAB_AR_TERM", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("AR_terms", "AR_terms"), New System.Data.Common.DataColumnMapping("KIND_AR", "KIND_AR"), New System.Data.Common.DataColumnMapping("NET_DUE_DAY", "NET_DUE_DAY"), New System.Data.Common.DataColumnMapping("NET_DUE_BEFORE", "NET_DUE_BEFORE"), New System.Data.Common.DataColumnMapping("DUE_NEXT_MONTH", "DUE_NEXT_MONTH"), New System.Data.Common.DataColumnMapping("NO_PAYMENT", "NO_PAYMENT"), New System.Data.Common.DataColumnMapping("PAYMENT_BEFORE", "PAYMENT_BEFORE"), New System.Data.Common.DataColumnMapping("DISCOUNT_PERCENTAGE", "DISCOUNT_PERCENTAGE"), New System.Data.Common.DataColumnMapping("IF_PAY_WITHIN", "IF_PAY_WITHIN")})})
        '
        'FrmARTerms
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(369, 414)
        Me.Controls.Add(Me.PnlKartAmvalField)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel9)
        Me.Name = "FrmARTerms"
        Me.Text = "AR and AP Terms"
        Me.PnlSearch.ResumeLayout(False)
        CType(Me.DsFrmARTerms1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlKartAmvalField.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmARTerms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        Me.CnnTemp.ConnectionString = PConnectionString
        PnlSearchHeight = PnlSearch.Height

        Call FillDataSets()
        Call FillFields(CmbAR_terms.Text)

        If ARTermVar.Trim.Length > 0 Then
            Call PAddNew()
            TxtAR_terms.Text = ARTermVar
            TxtAR_terms.Focus()
        Else
            If ARTermTempVar.Trim.Length = 0 Then
                Call PFirstRecord(False)
            Else
                CmbAR_terms.SelectedValue = ARTermTempVar
                Call FillFields(CmbAR_terms.Text)
            End If
            Call AfterSaveOrCancel()
            CmbAR_terms.Focus()
        End If
    End Sub
    Private Sub FillDataSets()
        DsFrmARTerms1.GL_TAB_AR_TERM.Clear()
        DAGL_TAB_AR_TERM.Fill(DsFrmARTerms1, "GL_TAB_AR_TERM")
    End Sub
    Sub PAddNew()
        Status = MainModule.WorkStates.AddNew

        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        Call EnableField(True)
        ARTermTempVar = CmbAR_terms.Text
        'CmbAR_terms.SelectedValue = ""

        Call ClearField()

        TxtAR_terms.Focus()

        BtnNew.Enabled = False
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False
        BtnCancel.Enabled = True
        MAddNew.Enabled = False
        MDelete.Enabled = False
        MEdit.Enabled = False
        MCancel.Enabled = True
        BtnPrev.Enabled = False
        BtnNext.Enabled = False
        BtnFirst.Enabled = False
        BtnLast.Enabled = False
        MPreviousRecord.Enabled = False
        MNextRecord.Enabled = False
        MFirstRecord.Enabled = False
        MLastRecord.Enabled = False
    End Sub
    Sub PEdit()
        Status = MainModule.WorkStates.Edit

        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        EnableField(True)
        ARTermTempVar = CmbAR_terms.Text
        TxtAR_terms.Focus()

        BtnNew.Enabled = False
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False
        BtnCancel.Enabled = True
        MAddNew.Enabled = False
        MDelete.Enabled = False
        MEdit.Enabled = False
        MCancel.Enabled = True
        BtnPrev.Enabled = False
        BtnNext.Enabled = False
        BtnFirst.Enabled = False
        BtnLast.Enabled = False
        MPreviousRecord.Enabled = False
        MNextRecord.Enabled = False
        MFirstRecord.Enabled = False
        MLastRecord.Enabled = False
    End Sub
    Sub PDelete()
        Dim c1 As New FrmWhatDoForMenu
        c1.BtnLeftText = "Cancel"
        c1.BtnRightText = "Delete"
        c1.ShowFarMsg("Are you sure?")
        If c1.DialogResult = DialogResult.OK Then
            Try
                If CmdDelete.Connection.State <> ConnectionState.Open Then
                    CmdDelete.Connection.Open()
                End If
                CmdDelete.Parameters("@AR_terms").Value = CmbAR_terms.Text
                CmdDelete.ExecuteNonQuery()
                Call FillDataSets()
                ARTermTempVar = ""
                Call PNextRecord(False)
                If ARTermTempVar.Trim.Length = 0 Then
                    Call PPreviousRecord(False)
                    If ARTermTempVar.Trim.Length = 0 Then
                        Call ClearField()
                    End If
                End If
            Catch ex As System.Data.SqlClient.SqlException
                Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
                Call PubErrHandle(myErrors.Item(0).Number)
            Finally
                CmdDelete.Connection.Close()
            End Try
            Call AfterSaveOrCancel()
        Else
            CmbAR_terms.Focus()
        End If
        Status = MainModule.WorkStates._ReadOnly
    End Sub
    Sub PSave()
        Dim ChangeOK As Boolean = False
        If NumDD_NET_DUE_BEFORE.Numbervalue < 0 Or NumDD_NET_DUE_BEFORE.Numbervalue > 28 Then
            MsgBox("NET DUE BEFORE should be between 0 to 28 ")
            Exit Sub
        End If
        If NumDD_IF_ISSUED_WITHIN_DAYS.Numbervalue < 0 Or NumDD_IF_ISSUED_WITHIN_DAYS.Numbervalue > 30 Then
            MsgBox("ISSUED WITHIN DAYS should be between 0 to 30 ")
            Exit Sub
        End If
        Select Case Status
            Case MainModule.WorkStates.AddNew
                ARTermTempVar = PInsert()
                ChangeOK = IIf(ARTermTempVar.Trim.Length = 0, False, True)
                If ARTermVar.Trim.Length > 0 Then
                    ARTermVar = TxtAR_terms.Text
                    Me.Close()
                End If
            Case MainModule.WorkStates.Edit
                Dim thisrow As DataRow, ThisPosition As Integer
                ChangeOK = PUpdate(ARTermTempVar)
        End Select
        If ChangeOK Then
            Call AfterSaveOrCancel()
            'If Status = mainmodule.WorkStates.AddNew Then
            '    Call PAddNew()
            'Else
            Status = MainModule.WorkStates._ReadOnly
            'PnlSearch.Visible = True
            Call ShowFilterProcPanel()

            Call FillDataSets()
            CmbAR_terms.SelectedValue = ARTermTempVar
            Call FillFields(CmbAR_terms.Text)
            CmbAR_terms.Focus()
        End If
    End Sub
    Sub PCancel()
        Status = MainModule.WorkStates._ReadOnly
        'PnlSearch.Visible = True
        Call ShowFilterProcPanel()

        CmbAR_terms.SelectedValue = ARTermTempVar
        Call FillFields(CmbAR_terms.Text)
        Call AfterSaveOrCancel()
        CmbAR_terms.Focus()
    End Sub
    Sub AfterSaveOrCancel()
        MSave.Enabled = False
        BtnSave.Enabled = False
        MCancel.Enabled = False
        BtnCancel.Enabled = False
        BtnNew.Enabled = True
        MAddNew.Enabled = True
        If TxtAR_terms.Text.Trim.Length = 0 Then
            BtnDelete.Enabled = False
            MDelete.Enabled = False
            BtnEdit.Enabled = False
            MEdit.Enabled = False
            BtnPrev.Enabled = False
            BtnNext.Enabled = False
            BtnFirst.Enabled = False
            BtnLast.Enabled = False
            MPreviousRecord.Enabled = False
            MNextRecord.Enabled = False
            MFirstRecord.Enabled = False
            MLastRecord.Enabled = False
        Else
            BtnDelete.Enabled = True
            MDelete.Enabled = True
            BtnEdit.Enabled = True
            MEdit.Enabled = True
            BtnPrev.Enabled = True
            BtnNext.Enabled = True
            BtnFirst.Enabled = True
            BtnLast.Enabled = True
            MPreviousRecord.Enabled = True
            MNextRecord.Enabled = True
            MFirstRecord.Enabled = True
            MLastRecord.Enabled = True
        End If
        Call EnableField(False)
    End Sub
    Private Sub MAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MAddNew.Click
        Call PAddNew()
    End Sub
    Private Sub MEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEdit.Click
        Call PEdit()
    End Sub
    Private Sub MDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MDelete.Click
        Call PDelete()
    End Sub
    Private Sub MSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSave.Click
        Call PSave()
    End Sub
    Private Sub MCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MCancel.Click
        Call PCancel()
    End Sub
    Private Sub TxtAR_terms_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAR_terms.TextChanged
        Call SaveButtonControl()
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
            If TxtAR_terms.Text.Trim.Length > 0 And (RdoDateDriven.Checked Or RdoMultiplePayments.Checked Or RdoStandard.Checked) And (Not RdoMultiplePayments.Checked Or (NumMP_NO_OF_PAYMENT.Numbervalue > 0 And NumMP_BEFORE_DAY.Numbervalue > 0)) Then
                BtnSave.Enabled = True
                MSave.Enabled = True
            Else
                BtnSave.Enabled = False
                MSave.Enabled = False
            End If
        End If
    End Sub
    Private Sub MFirstRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MFirstRecord.Click
        Call PFirstRecord()
    End Sub
    Private Sub MPreviousRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPreviousRecord.Click
        Call PPreviousRecord()
    End Sub
    Private Sub MNextRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MNextRecord.Click
        Call PNextRecord()
    End Sub
    Private Sub MLastRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MLastRecord.Click
        Call PLastRecord()
    End Sub
    Private Sub PFirstRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchAR_termsTemp As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT Top 1 AR_terms from GL_TAB_AR_TERM Order BY " & ARTermOrderFieldName & " ASC"
            TXTSearchAR_termsTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.Connection.Close()
            If IsNothing(TXTSearchAR_termsTemp) Then
                TXTSearchAR_termsTemp = ""
            End If
            If TXTSearchAR_termsTemp = CmbAR_terms.Text Or TXTSearchAR_termsTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the First record of this table.")
            Else
                CmbAR_terms.SelectedValue = TXTSearchAR_termsTemp
                Call FillFields(CmbAR_terms.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PPreviousRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchAR_termsTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Select Case ARTermOrderFieldName.ToUpper.Trim
            Case "AR_terms".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 AR_terms from GL_TAB_AR_TERM where AR_terms<" & Qt(TxtAR_terms.Text) & " Order BY " & ARTermOrderFieldName & " DESC"
        End Select
        TXTSearchAR_termsTemp = CmdGeneral.ExecuteScalar()
        CmdGeneral.Connection.Close()
        If IsNothing(TXTSearchAR_termsTemp) Then
            TXTSearchAR_termsTemp = ""
        End If
        If TXTSearchAR_termsTemp = CmbAR_terms.Text Or TXTSearchAR_termsTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the First record of this table.")
        Else
            CmbAR_terms.SelectedValue = TXTSearchAR_termsTemp
            ARTermTempVar = TXTSearchAR_termsTemp
            Call FillFields(CmbAR_terms.Text)
        End If
    End Sub
    Private Sub PNextRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchAR_termsTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Select Case ARTermOrderFieldName.ToUpper.Trim
            Case "AR_terms".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 AR_terms from GL_TAB_AR_TERM where AR_terms>" & Qt(TxtAR_terms.Text) & " Order BY " & ARTermOrderFieldName & " ASC"
        End Select
        TXTSearchAR_termsTemp = CmdGeneral.ExecuteScalar()
        CmdGeneral.Connection.Close()
        If IsNothing(TXTSearchAR_termsTemp) Then
            TXTSearchAR_termsTemp = ""
        End If
        If TXTSearchAR_termsTemp = CmbAR_terms.Text Or TXTSearchAR_termsTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            CmbAR_terms.SelectedValue = TXTSearchAR_termsTemp
            ARTermTempVar = TXTSearchAR_termsTemp
            Call FillFields(CmbAR_terms.Text)
        End If
    End Sub
    Private Sub PLastRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchAR_termsTemp As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT Top 1 AR_terms from GL_TAB_AR_TERM Order BY " & ARTermOrderFieldName & " DESC"
            TXTSearchAR_termsTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.Connection.Close()
            If IsNothing(TXTSearchAR_termsTemp) Then
                TXTSearchAR_termsTemp = ""
            End If
            If TXTSearchAR_termsTemp = CmbAR_terms.Text Or TXTSearchAR_termsTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the Last record of this table.")
            Else
                CmbAR_terms.SelectedValue = TXTSearchAR_termsTemp
                Call FillFields(CmbAR_terms.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CmbAR_terms_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbAR_terms.SelectionChangeCommitted
        Call FillFields(CmbAR_terms.Text)
        'Call AfterSaveOrCancel()
    End Sub
    Private Sub SetNoRecordFind()
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False
        BtnCancel.Enabled = True
        MDelete.Enabled = False
        MEdit.Enabled = False
        MCancel.Enabled = True
        BtnPrev.Enabled = False
        BtnNext.Enabled = False
        BtnFirst.Enabled = False
        BtnLast.Enabled = False
        MPreviousRecord.Enabled = False
        MNextRecord.Enabled = False
        MFirstRecord.Enabled = False
        MLastRecord.Enabled = False
    End Sub
    Private Sub ShowFilterProcPanel()
        Dim I As Integer, k As Integer
        If PnlSearch.Height = 0 Then
            k = -1
        Else
            k = 1
        End If
        Try
            For I = 1 To PnlSearchHeight
                PnlSearch.Height = PnlSearch.Height - k
                Me.Height = Me.Height - k
            Next I
        Catch
            ' PanelSearch.Visible = Not PanelSearch.Visible
        End Try
        'Me.Height = Me.Height - (k * PnlSearchHeight)
        If PnlSearch.Height <> 0 Then
            'GRDFWG.Height = PanelKartabl.Height - SBKartabl.Height
            CmbAR_terms.Focus()
        Else
            'GRDFWG.Height = GRDFWG.Height + PnlSearchHeight
        End If
    End Sub
    Friend Sub EnableField(ByVal instatus As Boolean)
        If Status = MainModule.WorkStates.AddNew Then
            TxtAR_terms.Enabled = instatus
        Else
            TxtAR_terms.Enabled = False
        End If
        NumST_DISCOUNT_PERCENTAGE.Enabled = instatus And RdoStandard.Checked
        NumST_IF_PAY_WITHIN_DAYS.Enabled = instatus And RdoStandard.Checked
        NumST_NET_DUE_IN.Enabled = instatus And RdoStandard.Checked
        NumDD_DISCOUNT_PERCENTAGE.Enabled = instatus And RdoDateDriven.Checked
        NumDD_IF_ISSUED_WITHIN_DAYS.Enabled = instatus And RdoDateDriven.Checked
        NumDD_IF_PAY_WITHIN_DAYS.Enabled = instatus And RdoDateDriven.Checked
        NumDD_NET_DUE_BEFORE.Enabled = instatus And RdoDateDriven.Checked
        NumMP_BEFORE_DAY.Enabled = instatus And RdoMultiplePayments.Checked
        NumMP_NO_OF_PAYMENT.Enabled = instatus And RdoMultiplePayments.Checked
        NumMP_First_PAYMENT.Enabled = instatus And RdoMultiplePayments.Checked
    End Sub
    Friend Sub ClearField()
        TxtAR_terms.Text = ""
        RdoStandard.Checked = True
        NumST_DISCOUNT_PERCENTAGE.Text = 0
        NumST_IF_PAY_WITHIN_DAYS.Text = 0
        NumST_NET_DUE_IN.Text = 0
        NumDD_DISCOUNT_PERCENTAGE.Text = 0
        NumDD_IF_ISSUED_WITHIN_DAYS.Text = 0
        NumDD_IF_PAY_WITHIN_DAYS.Text = 0
        NumDD_NET_DUE_BEFORE.Text = 0
        NumMP_BEFORE_DAY.Text = 0
        NumMP_NO_OF_PAYMENT.Text = 0
        NumMP_First_PAYMENT.Text = 0
    End Sub
    Friend Function PInsert() As String
        Dim thisrow As DataRow
        PInsert = ""
        Try
            With CmdInsert
                Call SetParametersForInsertAndUpdate(CmdInsert)
            End With
            PInsert = TxtAR_terms.Text
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PInsert = ""
        End Try
    End Function
    Friend Function PUpdate(ByVal ThisAR_terms As String) As Boolean
        PUpdate = True
        Try
            With CmdUpdate
                Call SetParametersForInsertAndUpdate(CmdUpdate)
            End With
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PUpdate = False
        End Try
    End Function
    Private Sub SetParametersForInsertAndUpdate(ByRef CmdParameter As SqlCommand)
        With CmdParameter
            If .Connection.State <> ConnectionState.Open Then
                .Connection.Open()
            End If
            If .Connection.State <> ConnectionState.Open Then
                .Connection.Open()
            End If
            .Parameters("@AR_terms").Value = TxtAR_terms.Text
            If RdoStandard.Checked = True Then
                .Parameters("@KIND_AR").Value = 1
            ElseIf RdoDateDriven.Checked = True Then
                .Parameters("@KIND_AR").Value = 2
            ElseIf RdoMultiplePayments.Checked = True Then
                .Parameters("@KIND_AR").Value = 3
            End If
            .Parameters("@DD_DISCOUNT_PERCENTAGE").Value = NumDD_DISCOUNT_PERCENTAGE.Text
            .Parameters("@DD_IF_ISSUED_WITHIN_DAYS").Value = NumDD_IF_ISSUED_WITHIN_DAYS.Text
            .Parameters("@DD_IF_PAY_WITHIN_DAYS").Value = NumDD_IF_PAY_WITHIN_DAYS.Text
            .Parameters("@DD_NET_DUE_BEFORE").Value = NumDD_NET_DUE_BEFORE.Text
            .Parameters("@ST_DISCOUNT_PERCENTAGE").Value = NumST_DISCOUNT_PERCENTAGE.Text
            .Parameters("@ST_IF_PAY_WITHIN_DAYS").Value = NumST_IF_PAY_WITHIN_DAYS.Text
            .Parameters("@ST_NET_DUE_IN").Value = NumST_NET_DUE_IN.Text
            .Parameters("@MP_BEFORE_DAY").Value = NumMP_BEFORE_DAY.Text
            .Parameters("@MP_NO_OF_PAYMENT").Value = NumMP_NO_OF_PAYMENT.Text
            .Parameters("@MP_First_PAYMENT").Value = NumMP_First_PAYMENT.Text
            .ExecuteNonQuery()
        End With
    End Sub
    Friend Function FillFields(ByVal ThisAR_terms As String) As Boolean
        FillFields = False
        If ThisAR_terms.Trim.Length = 0 Then
            Exit Function
        End If
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT * from GL_TAB_AR_TERM where AR_terms=" & Qt(ThisAR_terms)
            SQLReader = CmdGeneral.ExecuteReader
            If SQLReader.HasRows Then
                SQLReader.Read()
                Select Case SQLReader.Item("KIND_AR")
                    Case 1
                        RdoStandard.Checked = True
                    Case 2
                        RdoDateDriven.Checked = True
                    Case 3
                        RdoMultiplePayments.Checked = True
                    Case Else
                        RdoStandard.Checked = True
                End Select
                TxtAR_terms.Text = Trim(SQLReader.Item("AR_terms") & "")
                NumST_DISCOUNT_PERCENTAGE.Text = SQLReader.Item("ST_DISCOUNT_PERCENTAGE")
                NumST_IF_PAY_WITHIN_DAYS.Text = SQLReader.Item("ST_IF_PAY_WITHIN_DAYS")
                NumST_NET_DUE_IN.Text = SQLReader.Item("ST_NET_DUE_IN")
                NumDD_DISCOUNT_PERCENTAGE.Text = SQLReader.Item("DD_DISCOUNT_PERCENTAGE")
                NumDD_IF_ISSUED_WITHIN_DAYS.Text = SQLReader.Item("DD_IF_ISSUED_WITHIN_DAYS")
                NumDD_IF_PAY_WITHIN_DAYS.Text = SQLReader.Item("DD_IF_PAY_WITHIN_DAYS")
                NumDD_NET_DUE_BEFORE.Text = SQLReader.Item("DD_NET_DUE_BEFORE")
                NumMP_BEFORE_DAY.Text = SQLReader.Item("MP_BEFORE_DAY")
                NumMP_NO_OF_PAYMENT.Text = SQLReader.Item("MP_NO_OF_PAYMENT")
                NumMP_First_PAYMENT.Text = SQLReader.Item("MP_First_PAYMENT")
                FillFields = True
            Else
                Call ClearField()
            End If
        Catch ex As Exception
        End Try
        Try
            SQLReader.Close()
            CmdGeneral.Connection.Close()
        Catch ex As Exception
        End Try
    End Function
    Friend Sub DisableAllComponet(ByVal MyForm As Form, Optional ByVal MyStat As Boolean = False)
        Dim i As Integer
        For i = 0 To MyForm.Controls.Count - 1
            MyForm.Controls(i).Enabled = MyStat
        Next i
    End Sub
    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Call PAddNew()
    End Sub
    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Call PEdit()
    End Sub
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Call PDelete()
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Call PSave()
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Call PCancel()
    End Sub
    Private Sub BtnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click
        Call PFirstRecord()
    End Sub
    Private Sub BtnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrev.Click
        Call PPreviousRecord()
    End Sub
    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        Call PNextRecord()
    End Sub
    Private Sub BtnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLast.Click
        Call PLastRecord()
    End Sub
    Private Sub TxtCompany_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAR_terms.TextChanged, NumDD_DISCOUNT_PERCENTAGE.TextChanged, NumDD_IF_ISSUED_WITHIN_DAYS.TextChanged, NumDD_IF_PAY_WITHIN_DAYS.TextChanged, NumDD_NET_DUE_BEFORE.TextChanged, NumMP_BEFORE_DAY.TextChanged, NumMP_NO_OF_PAYMENT.TextChanged, NumMP_First_PAYMENT.TextChanged, NumST_DISCOUNT_PERCENTAGE.TextChanged, NumST_IF_PAY_WITHIN_DAYS.TextChanged, NumST_NET_DUE_IN.TextChanged, RdoDateDriven.CheckedChanged, RdoMultiplePayments.CheckedChanged, RdoStandard.CheckedChanged
        Call SaveButtonControl()
    End Sub
    Private Sub TxtAR_terms_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAR_terms.LostFocus
        'If MyClsVendorCod.FindDesc(TxtAR_terms.Text) Then
        '    MsgBox("This Code Is Exist.Please Try With a New Code")
        '    TxtAR_terms.Clear()
        '    TxtAR_terms.Focus()
        'End If
    End Sub
    Private Sub RdoStandard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoStandard.CheckedChanged, RdoMultiplePayments.CheckedChanged, RdoDateDriven.CheckedChanged
        If Status = MainModule.WorkStates.AddNew Or Status = MainModule.WorkStates.Edit Then
            Call EnableField(True)
            If RdoStandard.Checked = False Then
                NumST_DISCOUNT_PERCENTAGE.Text = 0
                NumST_IF_PAY_WITHIN_DAYS.Text = 0
                NumST_NET_DUE_IN.Text = 0
            End If
            If RdoDateDriven.Checked = False Then
                NumDD_DISCOUNT_PERCENTAGE.Text = 0
                NumDD_IF_ISSUED_WITHIN_DAYS.Text = 0
                NumDD_IF_PAY_WITHIN_DAYS.Text = 0
                NumDD_NET_DUE_BEFORE.Text = 0
            End If
            If RdoMultiplePayments.Checked = False Then
                NumMP_BEFORE_DAY.Text = 0
                NumMP_NO_OF_PAYMENT.Text = 0
                NumMP_First_PAYMENT.Text = 0
            End If
            'Else
            '    Call EnableField(False)
        End If
    End Sub
End Class
