Imports CommonClass
Public Class FrmATMTransaction
    Inherits FrmBase
    Dim ClsAtm1 As ClsAtm
    Dim WithEvents ClsGlAccount1 As ClsGlAccount
    Dim RowNoToAdd As Integer = 8
    Dim BeforeCel As Integer = -1
    Dim BeforeRow As Integer = -1
    Dim BeforeRowEx As Janus.Windows.GridEX.GridEXRow = Nothing
    Dim WithEvents MyFrm1 As UCGl_Account.FrmSearchGlAccount
    Dim id_Atm As Decimal = 0
    Public LoadThis As Decimal = 0
    Dim clscheck1 As ClsCheck

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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents BtnFirst As System.Windows.Forms.Button
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Txtcod_vendor As UCVendor.Vendor_Cod
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txtaddress_payee As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ZipCode1 As UCZipCode.ZipCode
    Friend WithEvents RbCharge As System.Windows.Forms.RadioButton
    Friend WithEvents RbCredit As System.Windows.Forms.RadioButton
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel
    Friend WithEvents CmbBankAccount As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtRef As System.Windows.Forms.TextBox
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmAtmTransaction1 As UcAccount.DsFrmAtmTransaction
    Friend WithEvents TxtStorNo As System.Windows.Forms.TextBox
    Friend WithEvents ChkShared As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DaBas_Banks As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaBankAtmDtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Txtamount_ATm As CalcUtils.UcCalcText
    Friend WithEvents Txtdate_transaction As CalendarCombo.CalendarCombo
    Friend WithEvents CharegCredit As System.Windows.Forms.GroupBox
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaBankAtm As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Dainv_tab_vendor_type As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmATMTransaction))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label33 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.Label36 = New System.Windows.Forms.Label
        Me.BtnFirst = New System.Windows.Forms.Button
        Me.Label37 = New System.Windows.Forms.Label
        Me.BtnLast = New System.Windows.Forms.Button
        Me.Label32 = New System.Windows.Forms.Label
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnNew = New System.Windows.Forms.Button
        Me.BtnFind = New System.Windows.Forms.Button
        Me.BtnNext = New System.Windows.Forms.Button
        Me.BtnPrev = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CharegCredit = New System.Windows.Forms.GroupBox
        Me.RbCredit = New System.Windows.Forms.RadioButton
        Me.RbCharge = New System.Windows.Forms.RadioButton
        Me.Txtaddress_payee = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.ZipCode1 = New UCZipCode.ZipCode
        Me.Txtamount_ATm = New CalcUtils.UcCalcText
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Txtdate_transaction = New CalendarCombo.CalendarCombo
        Me.TxtRef = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Txtcod_vendor = New UCVendor.Vendor_Cod
        Me.Label8 = New System.Windows.Forms.Label
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.TxtStorNo = New System.Windows.Forms.TextBox
        Me.ChkShared = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CmbBankAccount = New System.Windows.Forms.ComboBox
        Me.DsFrmAtmTransaction1 = New UcAccount.DsFrmAtmTransaction
        Me.Label2 = New System.Windows.Forms.Label
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DaBas_Banks = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DaBankAtmDtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaBankAtm = New System.Data.SqlClient.SqlDataAdapter
        Me.Dainv_tab_vendor_type = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.CharegCredit.SuspendLayout()
        Me.PnlSearch.SuspendLayout()
        CType(Me.DsFrmAtmTransaction1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=FARAJI;packet size=4096;user id=sa;data source=faraji;persist secu" & _
        "rity info=True;initial catalog=TireMate_01;password=5332"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label33)
        Me.Panel4.Controls.Add(Me.BtnCancel)
        Me.Panel4.Controls.Add(Me.Label36)
        Me.Panel4.Controls.Add(Me.BtnFirst)
        Me.Panel4.Controls.Add(Me.Label37)
        Me.Panel4.Controls.Add(Me.BtnLast)
        Me.Panel4.Controls.Add(Me.Label32)
        Me.Panel4.Controls.Add(Me.BtnEdit)
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Controls.Add(Me.Label24)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.BtnDelete)
        Me.Panel4.Controls.Add(Me.BtnNew)
        Me.Panel4.Controls.Add(Me.BtnFind)
        Me.Panel4.Controls.Add(Me.BtnNext)
        Me.Panel4.Controls.Add(Me.BtnPrev)
        Me.Panel4.Controls.Add(Me.BtnSave)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(662, 45)
        Me.Panel4.TabIndex = 6
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Location = New System.Drawing.Point(376, 31)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(39, 10)
        Me.Label33.TabIndex = 194
        Me.Label33.Text = "Cancel"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.Enabled = False
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(376, 0)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 27)
        Me.BtnCancel.TabIndex = 193
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Location = New System.Drawing.Point(4, 31)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(33, 10)
        Me.Label36.TabIndex = 192
        Me.Label36.Text = "First"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnFirst
        '
        Me.BtnFirst.BackColor = System.Drawing.SystemColors.Window
        Me.BtnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFirst.Image = CType(resources.GetObject("BtnFirst.Image"), System.Drawing.Image)
        Me.BtnFirst.Location = New System.Drawing.Point(8, 1)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(33, 27)
        Me.BtnFirst.TabIndex = 191
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Location = New System.Drawing.Point(128, 31)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(33, 10)
        Me.Label37.TabIndex = 189
        Me.Label37.Text = "Last"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnLast
        '
        Me.BtnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLast.Image = CType(resources.GetObject("BtnLast.Image"), System.Drawing.Image)
        Me.BtnLast.Location = New System.Drawing.Point(128, 1)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(33, 27)
        Me.BtnLast.TabIndex = 188
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Location = New System.Drawing.Point(256, 31)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(33, 10)
        Me.Label32.TabIndex = 184
        Me.Label32.Text = "Edit"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEdit
        '
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.Location = New System.Drawing.Point(256, 1)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(33, 27)
        Me.BtnEdit.TabIndex = 4
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(336, 31)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(33, 10)
        Me.Label25.TabIndex = 176
        Me.Label25.Text = "Save"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(296, 31)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(37, 10)
        Me.Label24.TabIndex = 175
        Me.Label24.Text = "Delete"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(216, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 10)
        Me.Label15.TabIndex = 174
        Me.Label15.Text = "New"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(176, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 10)
        Me.Label14.TabIndex = 173
        Me.Label14.Text = "Find"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(48, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 10)
        Me.Label3.TabIndex = 172
        Me.Label3.Text = "Prev"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(88, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 10)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "Next"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnDelete
        '
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(296, 1)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(33, 27)
        Me.BtnDelete.TabIndex = 5
        '
        'BtnNew
        '
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Location = New System.Drawing.Point(216, 1)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(33, 27)
        Me.BtnNew.TabIndex = 3
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(176, 1)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 27)
        Me.BtnFind.TabIndex = 2
        '
        'BtnNext
        '
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNext.Image = CType(resources.GetObject("BtnNext.Image"), System.Drawing.Image)
        Me.BtnNext.Location = New System.Drawing.Point(88, 1)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(33, 27)
        Me.BtnNext.TabIndex = 1
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.SystemColors.Window
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrev.Image = CType(resources.GetObject("BtnPrev.Image"), System.Drawing.Image)
        Me.BtnPrev.Location = New System.Drawing.Point(48, 1)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrev.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(336, 1)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 6
        '
        'CmdGeneral
        '
        Me.CmdGeneral.CommandTimeout = 10
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'imageList1
        '
        Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.CharegCredit)
        Me.Panel1.Controls.Add(Me.Txtaddress_payee)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.ZipCode1)
        Me.Panel1.Controls.Add(Me.Txtamount_ATm)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Txtdate_transaction)
        Me.Panel1.Controls.Add(Me.TxtRef)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Txtcod_vendor)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(1, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(655, 148)
        Me.Panel1.TabIndex = 7
        '
        'CharegCredit
        '
        Me.CharegCredit.Controls.Add(Me.RbCredit)
        Me.CharegCredit.Controls.Add(Me.RbCharge)
        Me.CharegCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CharegCredit.Location = New System.Drawing.Point(116, 104)
        Me.CharegCredit.Name = "CharegCredit"
        Me.CharegCredit.Size = New System.Drawing.Size(236, 33)
        Me.CharegCredit.TabIndex = 20
        Me.CharegCredit.TabStop = False
        '
        'RbCredit
        '
        Me.RbCredit.Location = New System.Drawing.Point(114, 8)
        Me.RbCredit.Name = "RbCredit"
        Me.RbCredit.TabIndex = 1
        Me.RbCredit.Text = "Credit"
        '
        'RbCharge
        '
        Me.RbCharge.Checked = True
        Me.RbCharge.Location = New System.Drawing.Point(8, 4)
        Me.RbCharge.Name = "RbCharge"
        Me.RbCharge.TabIndex = 0
        Me.RbCharge.TabStop = True
        Me.RbCharge.Text = "Charge"
        '
        'Txtaddress_payee
        '
        Me.Txtaddress_payee.BackColor = System.Drawing.SystemColors.Info
        Me.Txtaddress_payee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtaddress_payee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtaddress_payee.Location = New System.Drawing.Point(112, 48)
        Me.Txtaddress_payee.MaxLength = 150
        Me.Txtaddress_payee.Multiline = True
        Me.Txtaddress_payee.Name = "Txtaddress_payee"
        Me.Txtaddress_payee.ReadOnly = True
        Me.Txtaddress_payee.Size = New System.Drawing.Size(312, 50)
        Me.Txtaddress_payee.TabIndex = 19
        Me.Txtaddress_payee.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(24, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Name Address"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ZipCode1
        '
        Me.ZipCode1.Connection = Me.Cnn
        Me.ZipCode1.Enabled = False
        Me.ZipCode1.Location = New System.Drawing.Point(32, 40)
        Me.ZipCode1.Name = "ZipCode1"
        Me.ZipCode1.NotExitIfNotFound = False
        Me.ZipCode1.ReleaseIfNotFoundZipCode = False
        Me.ZipCode1.Size = New System.Drawing.Size(12, 21)
        Me.ZipCode1.TabIndex = 17
        Me.ZipCode1.Visible = False
        Me.ZipCode1.ZipCode = ""
        Me.ZipCode1.ZipCodeLen = 5
        '
        'Txtamount_ATm
        '
        Me.Txtamount_ATm.BackColor = System.Drawing.SystemColors.Info
        Me.Txtamount_ATm.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Txtamount_ATm.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Txtamount_ATm.DecimalDigits = 2
        Me.Txtamount_ATm.DefaultSendValue = False
        Me.Txtamount_ATm.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Txtamount_ATm.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Txtamount_ATm.Image = CType(resources.GetObject("Txtamount_ATm.Image"), System.Drawing.Image)
        Me.Txtamount_ATm.Location = New System.Drawing.Point(504, 67)
        Me.Txtamount_ATm.Maxlength = 10
        Me.Txtamount_ATm.MinusColor = System.Drawing.Color.Empty
        Me.Txtamount_ATm.Name = "Txtamount_ATm"
        Me.Txtamount_ATm.Size = New System.Drawing.Size(120, 22)
        Me.Txtamount_ATm.TabIndex = 16
        Me.Txtamount_ATm.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Txtamount_ATm.VisualStyle = Janus.Windows.GridEX.VisualStyle.Standard
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(448, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Amount"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(456, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 23)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Txtdate_transaction
        '
        Me.Txtdate_transaction.BackColor = System.Drawing.SystemColors.Info
        Me.Txtdate_transaction.BorderColor = System.Drawing.Color.Empty
        Me.Txtdate_transaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtdate_transaction.ButtonBackColor = System.Drawing.Color.Empty
        Me.Txtdate_transaction.ButtonForeColor = System.Drawing.Color.Empty
        Me.Txtdate_transaction.EditableSal = True
        Me.Txtdate_transaction.Image = CType(resources.GetObject("Txtdate_transaction.Image"), System.Drawing.Image)
        Me.Txtdate_transaction.Location = New System.Drawing.Point(504, 41)
        Me.Txtdate_transaction.MaxValue = CType(2500, Short)
        Me.Txtdate_transaction.MinValue = CType(1800, Short)
        Me.Txtdate_transaction.Name = "Txtdate_transaction"
        Me.Txtdate_transaction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txtdate_transaction.Sal_Mali = Nothing
        Me.Txtdate_transaction.ShowButton = True
        Me.Txtdate_transaction.Size = New System.Drawing.Size(120, 23)
        Me.Txtdate_transaction.TabIndex = 13
        Me.Txtdate_transaction.VisualStyle = False
        '
        'TxtRef
        '
        Me.TxtRef.BackColor = System.Drawing.SystemColors.Info
        Me.TxtRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRef.Location = New System.Drawing.Point(504, 16)
        Me.TxtRef.MaxLength = 20
        Me.TxtRef.Name = "TxtRef"
        Me.TxtRef.Size = New System.Drawing.Size(120, 20)
        Me.TxtRef.TabIndex = 12
        Me.TxtRef.Text = "0"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(454, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Ref No ."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Txtcod_vendor
        '
        Me.Txtcod_vendor.BackColor = System.Drawing.SystemColors.Info
        Me.Txtcod_vendor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Txtcod_vendor.Connection = Me.Cnn
        Me.Txtcod_vendor.Location = New System.Drawing.Point(108, 16)
        Me.Txtcod_vendor.Name = "Txtcod_vendor"
        Me.Txtcod_vendor.NotExitIfNotFound = False
        Me.Txtcod_vendor.ReleaseIfNotFoundVendorCod = False
        Me.Txtcod_vendor.Size = New System.Drawing.Size(312, 20)
        Me.Txtcod_vendor.TabIndex = 10
        Me.Txtcod_vendor.VendorCod = ""
        Me.Txtcod_vendor.VendorCodLen = 6
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(13, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Purchased Form"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.TxtStorNo)
        Me.PnlSearch.Controls.Add(Me.ChkShared)
        Me.PnlSearch.Controls.Add(Me.Label4)
        Me.PnlSearch.Controls.Add(Me.CmbBankAccount)
        Me.PnlSearch.Controls.Add(Me.Label2)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 45)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(662, 30)
        Me.PnlSearch.TabIndex = 8
        '
        'TxtStorNo
        '
        Me.TxtStorNo.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.TxtStorNo.Location = New System.Drawing.Point(560, 0)
        Me.TxtStorNo.Name = "TxtStorNo"
        Me.TxtStorNo.ReadOnly = True
        Me.TxtStorNo.Size = New System.Drawing.Size(72, 21)
        Me.TxtStorNo.TabIndex = 12
        Me.TxtStorNo.Text = ""
        '
        'ChkShared
        '
        Me.ChkShared.Enabled = False
        Me.ChkShared.Location = New System.Drawing.Point(297, -5)
        Me.ChkShared.Name = "ChkShared"
        Me.ChkShared.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkShared.Size = New System.Drawing.Size(117, 30)
        Me.ChkShared.TabIndex = 11
        Me.ChkShared.Text = "Share By All Store"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(448, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Only for this store no"
        '
        'CmbBankAccount
        '
        Me.CmbBankAccount.DataSource = Me.DsFrmAtmTransaction1.bas_banks
        Me.CmbBankAccount.DisplayMember = "name_bank"
        Me.CmbBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBankAccount.Location = New System.Drawing.Point(90, 1)
        Me.CmbBankAccount.Name = "CmbBankAccount"
        Me.CmbBankAccount.Size = New System.Drawing.Size(192, 21)
        Me.CmbBankAccount.TabIndex = 3
        Me.CmbBankAccount.ValueMember = "id_bank"
        '
        'DsFrmAtmTransaction1
        '
        Me.DsFrmAtmTransaction1.DataSetName = "DsFrmAtmTransaction"
        Me.DsFrmAtmTransaction1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Bank Account"
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowColumnDrag = False
        Me.GrdDetail.AutomaticSort = False
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "bank_ATM_dtl"
        Me.GrdDetail.DataSource = Me.DsFrmAtmTransaction1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>bank_check_dtl</Caption><Columns Collection" & _
        "=""true""><Column0 ID=""SelectGl""><ButtonDisplayMode>Always</ButtonDisplayMode><All" & _
        "owSort>False</AllowSort><Bound>False</Bound><ButtonStyle>ButtonCell</ButtonStyle" & _
        "><EditType>NoEdit</EditType><Key>SelectGl</Key><Position>0</Position><Selectable" & _
        ">False</Selectable><Width>24</Width></Column0><Column1 ID=""GL_Account""><Caption>" & _
        "GL Account No.</Caption><DataMember>GL_Account</DataMember><Key>GL_Account</Key>" & _
        "<Position>1</Position><Width>97</Width></Column1><Column2 ID=""desc_GL_account""><" & _
        "Caption>Accunt Name</Caption><DataMember>desc_GL_account</DataMember><Key>desc_G" & _
        "L_account</Key><Position>2</Position><Selectable>False</Selectable><Width>170</W" & _
        "idth></Column2><Column3 ID=""amount""><Caption>Amount</Caption><DataMember>amount<" & _
        "/DataMember><FormatString>c</FormatString><Key>amount</Key><Position>3</Position" & _
        "><TextAlignment>Far</TextAlignment><Width>114</Width><UpDownMaximum>180</UpDownM" & _
        "aximum></Column3><Column4 ID=""memo_dtl""><Caption>Memo</Caption><DataMember>memo_" & _
        "dtl</DataMember><Key>memo_dtl</Key><Position>4</Position><Width>235</Width><UpDo" & _
        "wnMaximum>200</UpDownMaximum></Column4></Columns><GroupCondition ID="""" /><Key>ba" & _
        "nk_check_dtl</Key></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.ExternalImageList = Me.imageList1
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(0, 227)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(662, 200)
        Me.GrdDetail.TabIndex = 10
        '
        'DaBas_Banks
        '
        Me.DaBas_Banks.SelectCommand = Me.SqlSelectCommand1
        Me.DaBas_Banks.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_banks", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("name_bank", "name_bank"), New System.Data.Common.DataColumnMapping("share_all_store", "share_all_store"), New System.Data.Common.DataColumnMapping("store_no", "store_no"), New System.Data.Common.DataColumnMapping("account_no", "account_no"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zip", "zip"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("contact_name", "contact_name"), New System.Data.Common.DataColumnMapping("GL_Account", "GL_Account"), New System.Data.Common.DataColumnMapping("start_check_no", "start_check_no"), New System.Data.Common.DataColumnMapping("next_check_no", "next_check_no"), New System.Data.Common.DataColumnMapping("default_bank", "default_bank"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("cod_account_type", "cod_account_type"), New System.Data.Common.DataColumnMapping("routing_numbers", "routing_numbers"), New System.Data.Common.DataColumnMapping("Bank_ID", "Bank_ID"), New System.Data.Common.DataColumnMapping("Web_Page", "Web_Page"), New System.Data.Common.DataColumnMapping("User_ID", "User_ID"), New System.Data.Common.DataColumnMapping("Password", "Password"), New System.Data.Common.DataColumnMapping("Security_code", "Security_code"), New System.Data.Common.DataColumnMapping("online_banking", "online_banking")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_bank, name_bank, share_all_store, store_no, account_no, address, zip, p" & _
        "hone_1, extension_1, phone_type_1, phone_main_1, phone_2, extension_2, phone_typ" & _
        "e_2, phone_main_2, phone_3, extension_3, phone_type_3, phone_main_3, phone_4, ex" & _
        "tension_4, phone_type_4, phone_main_4, phone_5, extension_5, phone_type_5, phone" & _
        "_main_5, email, contact_name, GL_Account, start_check_no, next_check_no, default" & _
        "_bank, inactive, cod_account_type, routing_numbers, Bank_ID, Web_Page, User_ID, " & _
        "Password, Security_code, online_banking FROM bas_banks"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT bank_ATM_dtl.id_ATM, bank_ATM_dtl.radif, bank_ATM_dtl.GL_account, bank_ATM" & _
        "_dtl.amount, bank_ATM_dtl.memo_dtl, GL_account.desc_GL_account FROM bank_ATM_dtl" & _
        " INNER JOIN GL_account ON bank_ATM_dtl.GL_account = GL_account.GL_account WHERE " & _
        "(bank_ATM_dtl.id_ATM = @Id_atm)"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_atm", System.Data.SqlDbType.Int, 4, "id_ATM"))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO bank_ATM_dtl(id_ATM, radif, GL_account, amount, memo_dtl) VALUES (@id" & _
        "_ATM, @radif, @GL_account, @amount, @memo_dtl); SELECT id_ATM, radif, GL_account" & _
        ", amount, memo_dtl FROM bank_ATM_dtl WHERE (id_ATM = @id_ATM) AND (radif = @radi" & _
        "f)"
        Me.SqlInsertCommand2.CommandTimeout = 10
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_ATM", System.Data.SqlDbType.Int, 4, "id_ATM"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount", System.Data.SqlDbType.Money, 8, "amount"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@memo_dtl", System.Data.SqlDbType.VarChar, 50, "memo_dtl"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE bank_ATM_dtl SET id_ATM = @id_ATM, radif = @radif, GL_account = @GL_accoun" & _
        "t, amount = @amount, memo_dtl = @memo_dtl WHERE (id_ATM = @Original_id_ATM) AND " & _
        "(radif = @Original_radif) AND (GL_account = @Original_GL_account OR @Original_GL" & _
        "_account IS NULL AND GL_account IS NULL) AND (amount = @Original_amount OR @Orig" & _
        "inal_amount IS NULL AND amount IS NULL) AND (memo_dtl = @Original_memo_dtl OR @O" & _
        "riginal_memo_dtl IS NULL AND memo_dtl IS NULL); SELECT id_ATM, radif, GL_account" & _
        ", amount, memo_dtl FROM bank_ATM_dtl WHERE (id_ATM = @id_ATM) AND (radif = @radi" & _
        "f)"
        Me.SqlUpdateCommand2.CommandTimeout = 10
        Me.SqlUpdateCommand2.Connection = Me.Cnn
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_ATM", System.Data.SqlDbType.Int, 4, "id_ATM"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount", System.Data.SqlDbType.Money, 8, "amount"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@memo_dtl", System.Data.SqlDbType.VarChar, 50, "memo_dtl"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_ATM", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_ATM", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_memo_dtl", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "memo_dtl", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM bank_ATM_dtl WHERE (id_ATM = @Original_id_ATM) AND (radif = @Original" & _
        "_radif) AND (GL_account = @Original_GL_account OR @Original_GL_account IS NULL A" & _
        "ND GL_account IS NULL) AND (amount = @Original_amount OR @Original_amount IS NUL" & _
        "L AND amount IS NULL) AND (memo_dtl = @Original_memo_dtl OR @Original_memo_dtl I" & _
        "S NULL AND memo_dtl IS NULL)"
        Me.SqlDeleteCommand2.CommandTimeout = 10
        Me.SqlDeleteCommand2.Connection = Me.Cnn
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_ATM", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_ATM", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_memo_dtl", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "memo_dtl", System.Data.DataRowVersion.Original, Nothing))
        '
        'DaBankAtmDtl
        '
        Me.DaBankAtmDtl.DeleteCommand = Me.SqlDeleteCommand2
        Me.DaBankAtmDtl.InsertCommand = Me.SqlInsertCommand2
        Me.DaBankAtmDtl.SelectCommand = Me.SqlSelectCommand3
        Me.DaBankAtmDtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bank_ATM_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_ATM", "id_ATM"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("memo_dtl", "memo_dtl")})})
        Me.DaBankAtmDtl.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT id_ATM, id_bank, date_transaction, amount_ATM, cod_vendor, memo_address, i" & _
        "d_debit_deposit_head, ChargeCredit FROM bank_ATM WHERE (id_ATM = @id_Atm)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_Atm", System.Data.SqlDbType.Int, 4, "id_ATM"))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO bank_ATM(id_bank, date_transaction, amount_ATM, cod_vendor, memo_addr" & _
        "ess, id_debit_deposit_head, ChargeCredit) VALUES (@id_bank, @date_transaction, @" & _
        "amount_ATM, @cod_vendor, @memo_address, @id_debit_deposit_head, @ChargeCredit); " & _
        "SELECT id_ATM, id_bank, date_transaction, amount_ATM, cod_vendor, memo_address, " & _
        "id_debit_deposit_head, ChargeCredit FROM bank_ATM WHERE (id_ATM = @@IDENTITY)"
        Me.SqlInsertCommand1.CommandTimeout = 10
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank", System.Data.SqlDbType.SmallInt, 2, "id_bank"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_transaction", System.Data.SqlDbType.VarChar, 10, "date_transaction"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_ATM", System.Data.SqlDbType.Money, 8, "amount_ATM"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@memo_address", System.Data.SqlDbType.VarChar, 300, "memo_address"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_debit_deposit_head", System.Data.SqlDbType.Int, 4, "id_debit_deposit_head"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ChargeCredit", System.Data.SqlDbType.VarChar, 1, "ChargeCredit"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE bank_ATM SET id_bank = @id_bank, date_transaction = @date_transaction, amo" & _
        "unt_ATM = @amount_ATM, cod_vendor = @cod_vendor, memo_address = @memo_address, i" & _
        "d_debit_deposit_head = @id_debit_deposit_head, ChargeCredit = @ChargeCredit WHER" & _
        "E (id_ATM = @Original_id_ATM) AND (ChargeCredit = @Original_ChargeCredit OR @Ori" & _
        "ginal_ChargeCredit IS NULL AND ChargeCredit IS NULL) AND (amount_ATM = @Original" & _
        "_amount_ATM OR @Original_amount_ATM IS NULL AND amount_ATM IS NULL) AND (cod_ven" & _
        "dor = @Original_cod_vendor OR @Original_cod_vendor IS NULL AND cod_vendor IS NUL" & _
        "L) AND (date_transaction = @Original_date_transaction OR @Original_date_transact" & _
        "ion IS NULL AND date_transaction IS NULL) AND (id_bank = @Original_id_bank OR @O" & _
        "riginal_id_bank IS NULL AND id_bank IS NULL) AND (id_debit_deposit_head = @Origi" & _
        "nal_id_debit_deposit_head OR @Original_id_debit_deposit_head IS NULL AND id_debi" & _
        "t_deposit_head IS NULL) AND (memo_address = @Original_memo_address OR @Original_" & _
        "memo_address IS NULL AND memo_address IS NULL); SELECT id_ATM, id_bank, date_tra" & _
        "nsaction, amount_ATM, cod_vendor, memo_address, id_debit_deposit_head, ChargeCre" & _
        "dit FROM bank_ATM WHERE (id_ATM = @id_ATM)"
        Me.SqlUpdateCommand1.CommandTimeout = 10
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank", System.Data.SqlDbType.SmallInt, 2, "id_bank"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_transaction", System.Data.SqlDbType.VarChar, 10, "date_transaction"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_ATM", System.Data.SqlDbType.Money, 8, "amount_ATM"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@memo_address", System.Data.SqlDbType.VarChar, 300, "memo_address"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_debit_deposit_head", System.Data.SqlDbType.Int, 4, "id_debit_deposit_head"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ChargeCredit", System.Data.SqlDbType.VarChar, 1, "ChargeCredit"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_ATM", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_ATM", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ChargeCredit", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ChargeCredit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_ATM", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_ATM", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_transaction", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_transaction", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_bank", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_debit_deposit_head", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_debit_deposit_head", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_memo_address", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "memo_address", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_ATM", System.Data.SqlDbType.Int, 4, "id_ATM"))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM bank_ATM WHERE (id_ATM = @Original_id_ATM) AND (ChargeCredit = @Origi" & _
        "nal_ChargeCredit OR @Original_ChargeCredit IS NULL AND ChargeCredit IS NULL) AND" & _
        " (amount_ATM = @Original_amount_ATM OR @Original_amount_ATM IS NULL AND amount_A" & _
        "TM IS NULL) AND (cod_vendor = @Original_cod_vendor OR @Original_cod_vendor IS NU" & _
        "LL AND cod_vendor IS NULL) AND (date_transaction = @Original_date_transaction OR" & _
        " @Original_date_transaction IS NULL AND date_transaction IS NULL) AND (id_bank =" & _
        " @Original_id_bank OR @Original_id_bank IS NULL AND id_bank IS NULL) AND (id_deb" & _
        "it_deposit_head = @Original_id_debit_deposit_head OR @Original_id_debit_deposit_" & _
        "head IS NULL AND id_debit_deposit_head IS NULL) AND (memo_address = @Original_me" & _
        "mo_address OR @Original_memo_address IS NULL AND memo_address IS NULL)"
        Me.SqlDeleteCommand1.CommandTimeout = 10
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_ATM", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_ATM", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ChargeCredit", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ChargeCredit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_ATM", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_ATM", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_transaction", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_transaction", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_bank", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_debit_deposit_head", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_debit_deposit_head", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_memo_address", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "memo_address", System.Data.DataRowVersion.Original, Nothing))
        '
        'DaBankAtm
        '
        Me.DaBankAtm.DeleteCommand = Me.SqlDeleteCommand1
        Me.DaBankAtm.InsertCommand = Me.SqlInsertCommand1
        Me.DaBankAtm.SelectCommand = Me.SqlSelectCommand2
        Me.DaBankAtm.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bank_ATM", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_ATM", "id_ATM"), New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("date_transaction", "date_transaction"), New System.Data.Common.DataColumnMapping("amount_ATM", "amount_ATM"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("memo_address", "memo_address"), New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("ChargeCredit", "ChargeCredit")})})
        Me.DaBankAtm.UpdateCommand = Me.SqlUpdateCommand1
        '
        'Dainv_tab_vendor_type
        '
        Me.Dainv_tab_vendor_type.SelectCommand = Me.SqlSelectCommand4
        Me.Dainv_tab_vendor_type.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_vendor_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("vendor_type", "vendor_type"), New System.Data.Common.DataColumnMapping("desc_vendor_type", "desc_vendor_type"), New System.Data.Common.DataColumnMapping("GL_expense_account", "GL_expense_account")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT vendor_type, desc_vendor_type, GL_expense_account FROM inv_tab_vendor_type" & _
        " WHERE (vendor_type = @Vendore_type)"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Vendore_type", System.Data.SqlDbType.VarChar, 3, "vendor_type"))
        '
        'FrmATMTransaction
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(662, 427)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmATMTransaction"
        Me.Text = "ATM Transaction"
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.CharegCredit.ResumeLayout(False)
        Me.PnlSearch.ResumeLayout(False)
        CType(Me.DsFrmAtmTransaction1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmATMTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        CmdGeneral.Connection = Cnn
        ClsAtm1 = New ClsAtm
        ClsGlAccount1 = New ClsGlAccount
        ClsAtm1.Connection = Cnn
        clscheck1 = New ClsCheck
        clscheck1.Connection = Cnn
        ClsGlAccount1.Connection = Cnn
        ThisFormStatus = MainModule.WorkStates.Cancel
        DaBas_Banks.Fill(DsFrmAtmTransaction1.bas_banks)
        TxtStorNo.Text = PubStoreName
        If DsFrmAtmTransaction1.bas_banks.Rows.Count <= 0 Then
            MsgFar("There is No Bank Row In Database File")
        End If
        'If Not CmbBankAccount.SelectedValue Is Nothing Then
        '    TxtNo_Of_Check.Text = ClsCheck1.LastNoCheck(CmbBankAccount.SelectedValue)
        'End If
        Call EnableDisableField(False)
        If LoadThis = 0 Then
            Call PFirstRecord(False)
        Else
            Call LoadIt(LoadThis)
        End If
    End Sub
    Private Sub LoadIt(ByVal ThisRefNo As String)
        'DsFrmReceiveReturnProduct1.Clear()
        Call ClearAllField()
        If ThisRefNo <> "" Then
            DaBankAtm.SelectCommand.Parameters("@id_Atm").Value = ThisRefNo
            DaBankAtm.Fill(DsFrmAtmTransaction1.bank_ATM)
            Try
                DaBankAtmDtl.SelectCommand.Parameters("@id_Atm").Value = ThisRefNo
                DaBankAtmDtl.Fill(DsFrmAtmTransaction1.bank_ATM_dtl)
            Catch ex As Exception
            End Try
            Call FillDataInScreen()
        End If
    End Sub
    Private Sub FillDataInScreen()
        With DsFrmAtmTransaction1.bank_ATM
            Try

                If .Rows.Count > 0 Then
                    TxtRef.Text = .Rows(0).Item("id_Atm") & ""
                    Txtaddress_payee.Text = .Rows(0).Item("memo_address") & ""
                    Txtamount_ATm.Text = .Rows(0).Item("amount_ATM")
                    Txtcod_vendor.VendorCod = .Rows(0).Item("Cod_Vendor") & ""
                    Txtdate_transaction.Text = .Rows(0).Item("date_transaction") & ""
                    id_Atm = .Rows(0).Item("id_ATm")
                    If .Rows(0).Item("ChargeCredit") = "1" Then
                        RbCharge.Checked = True
                        ' RbCredit.Checked = False
                    Else
                        '   RbCharge.Checked = False
                        RbCredit.Checked = True
                    End If
                    Try
                        CmbBankAccount.SelectedValue = .Rows(0).Item("id_bank") & ""
                    Catch ex As Exception
                    End Try
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End With
    End Sub
    Private Sub CmbBankAccount_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbBankAccount.SelectedValueChanged
        Try
            Dim dr As DsFrmAtmTransaction.bas_banksRow = DsFrmAtmTransaction1.bas_banks.FindByid_bank(CmbBankAccount.SelectedValue)
            If Not dr Is Nothing Then
                ChkShared.Checked = dr.share_all_store
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#Region "Clear Fields"
    Private Sub ClearAllField()
        Txtaddress_payee.Clear()
        Txtamount_ATm.Text = ""
        Txtcod_vendor.VendorCod = ""
        Txtdate_transaction.Text = ""
        'TxtNo_Of_Check.Text = ""
        RbCharge.Checked = True
        DsFrmAtmTransaction1.Clear()
        DaBas_Banks.Fill(DsFrmAtmTransaction1)
        TxtRef.Clear()
    End Sub

#End Region
#Region "EnableDisable"
    Private Sub EnableDisableSave()

        Dim RowDetails As DataRow() = DsFrmAtmTransaction1.bank_ATM_dtl.Select("trim(gl_account) <> ''")

        If Not CmbBankAccount.SelectedValue Is Nothing And BtnNew.Enabled = False And RowDetails.Length > 0 Then
            If SumGrdDetail() = Txtamount_ATm.Text Then
                BtnSave.Enabled = True
            Else
                BtnSave.Enabled = False
            End If
        Else
            BtnSave.Enabled = False
        End If
    End Sub

    Private Sub EnableDisableField(ByVal InStatus As Boolean)
        CmbBankAccount.Enabled = InStatus
        GrdDetail.Enabled = InStatus
        Txtaddress_payee.Enabled = InStatus
        Txtamount_ATm.Enabled = InStatus
        Txtcod_vendor.Enabled = InStatus
        Txtdate_transaction.Enabled = InStatus
        TxtRef.Enabled = InStatus
        CharegCredit.Enabled = InStatus
    End Sub
    Private Sub EnableDisableBtn()
        Select Case ThisFormStatus
            Case MainModule.WorkStates.AddNew, MainModule.WorkStates.Edit
                BtnFirst.Enabled = False
                BtnPrev.Enabled = False
                BtnNext.Enabled = False
                BtnLast.Enabled = False
                BtnEdit.Enabled = False
                BtnDelete.Enabled = False
                BtnFind.Enabled = False
                BtnNew.Enabled = False
                BtnCancel.Enabled = True
                BtnSave.Enabled = False
            Case MainModule.WorkStates._ReadOnly
                If TxtRef.Text.Trim.Length > 0 Then
                    BtnFirst.Enabled = True
                    BtnPrev.Enabled = True
                    BtnNext.Enabled = True
                    BtnLast.Enabled = True
                    BtnEdit.Enabled = True
                    BtnDelete.Enabled = True
                    BtnFind.Enabled = True
                Else
                    BtnFirst.Enabled = False
                    BtnPrev.Enabled = False
                    BtnNext.Enabled = False
                    BtnLast.Enabled = False
                    BtnEdit.Enabled = False
                    BtnDelete.Enabled = False
                    BtnFind.Enabled = False
                End If
                BtnNew.Enabled = True
                BtnCancel.Enabled = False
                BtnSave.Enabled = False
        End Select
    End Sub
#End Region
#Region "Buttomns Toolbar click"
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Call Psave()
    End Sub
    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Call Paddnew()
    End Sub
    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Call PEdit()
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
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Call PDelete()
    End Sub

#End Region
#Region "AdNewEditSave"
    Sub Paddnew()
        If Not CmbBankAccount.SelectedValue Is Nothing Then
            ThisFormStatus = MainModule.WorkStates.AddNew
            Call EnableDisableField(True)
            Call EnableDisableBtn()
            Call ClearAllField()
            TxtRef.Text = ClsAtm1.MakeNewRefCod()
            'TxtNo_Of_Check.Text = ClsCheck1.LastNoCheck(CmbBankAccount.SelectedValue)
            Txtdate_transaction.Text = Format(Now.Date, PubDateFormat)

            Call AddEmptyRecordInDetail()
            CmbBankAccount.Focus()
            Dim d As Integer = clscheck1.FindDefaultBank
            If d <> 0 Then
                CmbBankAccount.SelectedValue = d
            End If
        End If
    End Sub
    Sub Psave()
        Dim Dr As DataRow
        Dim flg As Boolean = False
        Try
            If DsFrmAtmTransaction1.bank_ATM.Rows.Count <= 0 Then
                Dr = DsFrmAtmTransaction1.bank_ATM.NewRow()
                Dr("id_Atm") = TxtRef.Text.Trim
                flg = True
            Else
                Dr = DsFrmAtmTransaction1.bank_ATM.Rows(0)

            End If
            Dr("id_bank") = CmbBankAccount.SelectedValue
            Dr("date_transaction") = Txtdate_transaction.Text.Trim
            Dr("amount_Atm") = Txtamount_ATm.Text
            Dr("cod_vendor") = IIf(Txtcod_vendor.VendorCod.Trim <> "", Txtcod_vendor.VendorCod.Trim, System.DBNull.Value)
            'Dr("Employee_code") = System.DBNull.Value
            Dr("memo_address") = Txtaddress_payee.Text.Trim
            ' Dr("memo_check") = TxtRef.Text.Trim
            'Dr("invoice_no") = IIf(Txtcod_vendor.VendorCod.Trim <> "", TxtnvoiceNo.Text, System.DBNull.Value)
            'Dr("invoice_date") = TxtInvoiceDate.Text & ""
            Dr("ChargeCredit") = IIf(RbCharge.Checked, "1", "2")  'ChkManualCheck.Checked
            If flg Then
                DsFrmAtmTransaction1.bank_ATM.Addbank_ATMRow(Dr)
            End If
            '            #region "delete empty row"
            Dim i As Long
            Dim dr1 As DataRow()
            dr1 = DsFrmAtmTransaction1.bank_ATM_dtl.Select("trim( gl_account) ='' or amount=0 ")
            For i = 0 To dr1.Length - 1
                dr1(i).Delete()
            Next
            Try

                DaBankAtm.Update(DsFrmAtmTransaction1.bank_ATM)
                id_Atm = DsFrmAtmTransaction1.bank_ATM.Rows(0).Item("id_Atm")
                For i = 0 To DsFrmAtmTransaction1.bank_ATM_dtl.Rows.Count - 1
                    DsFrmAtmTransaction1.bank_ATM_dtl.Rows(i).Item("id_Atm") = id_Atm
                Next
                DaBankAtmDtl.Update(DsFrmAtmTransaction1.bank_ATM_dtl)
                '                If RbBill.Checked = True Then
                If flg Then
                    Call InsertIntoGlDebitdiposit()
                Else
                    Call UpdateGlDebitDiposit()
                End If
                If CDec("0" & TxtRef.Text) <> id_Atm Then
                    MsgFar("ATM Transaction saved as number " & id_Atm)
                End If

            Catch ex As Exception
                Try
                    Dim Exerror As String = ex.ToString.ToUpper
                    If Exerror.IndexOf("Timeout expired".ToUpper) > 0 Then
                        MsgFar("This Transaction is Going to Close And You Can not edit it")
                        LoadIt(TxtRef.Text)
                    Else
                        MsgBox(ex.ToString)
                    End If
                Catch ex1 As Exception
                    MsgBox(ex1.ToString)
                End Try
            End Try
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        ThisFormStatus = MainModule.WorkStates._ReadOnly
        Call EnableDisableField(False)
        Call EnableDisableBtn()
    End Sub
    Sub PCancel()
        ThisFormStatus = MainModule.WorkStates._ReadOnly
        Call EnableDisableField(False)
        Call EnableDisableBtn()
        TxtRef.Text = ClsAtm1.LastRecord()
        Call LoadIt(TxtRef.Text)
    End Sub
    Sub PEdit()
        ' Get A Copy Of Dataset
        Dim AddEmptyRecordToDetailCount As Integer
        Dim IFirstCount As Integer   'Dsfrm..Rows.Count()
        If TxtRef.Text.Trim.Length > 0 Then
            ThisFormStatus = MainModule.WorkStates.Edit
            Call EnableDisableField(True)
            Call EnableDisableBtn()
            IFirstCount = DsFrmAtmTransaction1.bank_ATM_dtl.Rows.Count()
            For AddEmptyRecordToDetailCount = 1 + IFirstCount To RowNoToAdd + IFirstCount
                Call AddEmptyRecordToDetail(TxtRef.Text, AddEmptyRecordToDetailCount)
            Next
        End If
        CmbBankAccount.Focus()
    End Sub
    Sub PDelete()
        Dim c1 As New FrmWhatDoForMenu
        c1.BtnLeftText = "Cancel"
        c1.BtnRightText = "Delete"
        c1.ShowFarMsg("Are you sure To Delete  This Adjustment ?")
        If c1.DialogResult = DialogResult.OK Then
            Try
                CmdGeneral.CommandText = " Delete  from  Bank_Atm Where id_ATM= " & Qt(TxtRef.Text)
                CmdGeneral.CommandTimeout = 10
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
                CmdGeneral.CommandText = " Delete From  GL_debit_deposit  Where Id_Atm  =" & Qt(TxtRef.Text)
                CmdGeneral.ExecuteNonQuery()
                PLastRecord(False)
            Catch ex As Exception
                Try
                    Dim Exerror As String = ex.ToString.ToUpper
                    If Exerror.IndexOf("Timeout expired".ToUpper) > 0 Then
                        MsgFar("This Transaction is Going to Close And You Can not Delete it")
                        LoadIt(TxtRef.Text)
                    Else
                        MsgFar("Error in delete please check delete cascade integrity mr armandeh! ")
                        MsgBox(ex.ToString)
                    End If

                Catch ex1 As Exception
                    MsgBox(ex1.ToString)
                End Try

            End Try
        End If
    End Sub
#End Region
#Region "GrdDetail"
    Sub AddEmptyRecordInDetail()
        Dim IFirstCount As Integer = DsFrmAtmTransaction1.bank_ATM_dtl.Rows.Count()
        Dim AddEmptyRecordToDetailCount As Integer
        For AddEmptyRecordToDetailCount = 1 + IFirstCount To RowNoToAdd + IFirstCount
            Call AddEmptyRecordToDetail(TxtRef.Text, AddEmptyRecordToDetailCount)
        Next
    End Sub
    Private Sub GrdDetail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.GotFocus
        SelectRow(GrdDetail.Row, 0)
    End Sub
    Sub SelectRow(ByVal ThisRow As Integer, Optional ByVal ThisItemCodeFocus As Integer = 1)
        GrdDetail.Row = ThisRow
        GrdDetail.Col = ThisItemCodeFocus
        GrdDetail.SelectCurrentCellText()
    End Sub


    Private Sub GrdDetail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdDetail.KeyDown
        If ThisFormStatus <> MainModule.WorkStates._ReadOnly Then
            Dim CurrentRow As Janus.Windows.GridEX.GridEXRow = GrdDetail.GetRow()
            Dim CurrentRowGrid As Long = 2
            Dim flg2 As Boolean = False

            Dim row As Integer = GrdDetail.Row
            Dim col As Integer = GrdDetail.Col
            '-------------------------------------------------------------
            Select Case e.Control
                Case True
                Case False
                    If e.Shift = False And e.Control = False And e.Alt = False Then
                        Select Case e.KeyCode
                            Case Windows.Forms.Keys.F2
                                Select Case GrdDetail.Col
                                    Case 1 ' ItemCode
                                        Call ShowSearch()
                                        Call SelectRow(row, 0)
                                        System.Windows.Forms.SendKeys.Send(vbTab)
                                End Select
                        End Select
                    End If
            End Select
        End If
    End Sub
    Private Sub GrdDetail_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.CurrentCellChanged
        Dim ValueString As String = ""
        Dim CurrentRowGrid As Long = GrdDetail.Row
        If BeforeRowEx Is Nothing Or BeforeCel = -1 Or BeforeRow = -1 Then
            Exit Sub
        End If
        Try
            ValueString = BeforeRowEx.Cells(BeforeCel).Value & ""
            Select Case BeforeCel
                Case 1
                    If ValueString.Trim & "" <> "" Then
                        If ClsGlAccount1.FindDesc(ValueString) = False Then
                            MsgFar("Cod is invalid")
                            Call SelectRow(CurrentRowGrid, 1)
                        Else

                        End If
                    End If
                Case 4
                Case 6, 7 'QTY  ,  Price
                Case 8, 9
            End Select
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Try
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GrdDetail_CurrentCellChanging(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.CurrentCellChangingEventArgs) Handles GrdDetail.CurrentCellChanging
        Call EnableDisableSave()
        Call InitBeforeRow()
    End Sub
    Private Sub GrdDetail_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.ColumnButtonClick
        Call ShowSearch()
    End Sub
    Sub ShowSearch()
        MyFrm1 = New UCGl_Account.FrmSearchGlAccount
        MyFrm1.ShowDialog()
    End Sub
    Sub InitBeforeRow()
        BeforeCel = GrdDetail.Col
        BeforeRow = GrdDetail.Row
        BeforeRowEx = GrdDetail.GetRow
    End Sub
#End Region
#Region "Previos-Last-Frist"
    Private Sub PFirstRecord(Optional ByVal ShowMsgFlag As Boolean = True)
        Try
            ' If TxtRef.Text.Trim.Length > 0 Then
            Dim TXTRef_NoTmp As String = ClsAtm1.PFirstRecord()
            If TXTRef_NoTmp = TxtRef.Text Then
                If ShowMsgFlag Then MsgFar("First Record")
            Else
                Call LoadIt(TXTRef_NoTmp)
            End If
            ' Else
            ' MsgFar("There is no Row in Database")
            ' End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PLastRecord(Optional ByVal ShowMsgFlag As Boolean = True)
        Try
            If TxtRef.Text.Trim.Length > 0 Then
                Dim TXTRef_NoTmp As String = ClsAtm1.LastRecord()
                If TXTRef_NoTmp = TxtRef.Text Then
                    If ShowMsgFlag Then MsgFar("Last Record")
                Else
                    Call LoadIt(TXTRef_NoTmp)
                End If
            Else
                MsgFar("There is no Row in Database")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PPreviousRecord(Optional ByVal ShowMsgFlag As Boolean = True)
        Try
            If TxtRef.Text.Trim.Length > 0 Then
                Dim TXTRef_NoTmp As String = ClsAtm1.Pprevious(TxtRef.Text.Trim)
                If TXTRef_NoTmp.Trim = TxtRef.Text.Trim Or TXTRef_NoTmp.Trim.Length = 0 Then
                    If ShowMsgFlag Then MsgFar("First Record")
                Else
                    Call LoadIt(TXTRef_NoTmp)
                End If
            Else
                MsgFar("There is no Row in Database")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PNextRecord(Optional ByVal ShowMsgFlag As Boolean = True)
        Try
            If TxtRef.Text.Trim.Length > 0 Then
                Dim TXTRef_NoTmp As String = ClsAtm1.PNext(TxtRef.Text)
                If TXTRef_NoTmp.Trim = TxtRef.Text.Trim Or TXTRef_NoTmp.Trim.Length = 0 Then
                    If ShowMsgFlag Then MsgFar("Last Record")
                Else
                    Call LoadIt(TXTRef_NoTmp)
                End If
            Else
                MsgFar("There is no Row in Database")
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region
#Region "All Text Changed"
    Private Sub AllTxt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtaddress_payee.TextChanged, Txtamount_ATm.TextChanged, Txtcod_vendor.TextChanged, Txtdate_transaction.TextChanged, TxtRef.TextChanged
        '  TxtNumberString.Text = NumToString_Dollar(Txtamount_check.Text)
        EnableDisableSave()
    End Sub
#End Region
    Private Sub AddEmptyRecordToDetail(ByVal ThisId As Decimal, ByVal ThisRadif As Integer)
        Dim dr As DataRow
        dr = DsFrmAtmTransaction1.bank_ATM_dtl.NewRow
        dr("id_Atm") = ThisId
        dr("radif") = ThisRadif
        dr("gl_account") = ""
        dr("amount") = 0
        dr("memo_dtl") = ""
        DsFrmAtmTransaction1.bank_ATM_dtl.Rows.Add(dr)
    End Sub
    'Private Sub VendoreOfInvoice1_FindThisRefNoForThisVendore(ByVal ThisRow As System.Data.DataRow) Handles TxtnvoiceNo.FindThisRefNoForThisVendore
    '    'TxtInvoiceDate.Text = ThisRow("receipt_bill_date")
    'End Sub

    Private Sub MyFrm1_GlAccountFind(ByVal ThisRow As System.Data.DataRow) Handles MyFrm1.GlAccountFind
        GrdDetail.GetRow.Cells(1).Value = ThisRow("Gl_Account")
        GrdDetail.GetRow.Cells(2).Value = ThisRow("Desc_Gl_Account")
        Dim mand As Decimal = CalculateMandeh()
        If mand > 0 Then
            GrdDetail.GetRow.Cells(3).Value = CalculateMandeh()
        End If
        GrdDetail.UpdateData()
        EnableDisableSave()
    End Sub

    Private Sub ClsGlAccount1_FindGlAccuntRow(ByVal ThisRow As System.Data.DataRow) Handles ClsGlAccount1.FindGlAccuntRow
        If Trim(GrdDetail.GetRow.Cells(1).Value) & "" <> "" Then
            GrdDetail.GetRow.Cells(2).Value = ThisRow("Desc_Gl_Account")
        End If
        Dim mand As Decimal = CalculateMandeh()
        If mand > 0 Then
            GrdDetail.GetRow.Cells(3).Value = CalculateMandeh()
        End If
        GrdDetail.UpdateData()
        EnableDisableSave()
    End Sub

    Private Function CalculateMandeh() As Decimal
        CalculateMandeh = 0
        Dim i As Integer
        For i = 0 To DsFrmAtmTransaction1.bank_ATM_dtl.Rows.Count - 1
            CalculateMandeh = CDec("0" & DsFrmAtmTransaction1.bank_ATM_dtl.Rows(i).Item("amount")) + CalculateMandeh
        Next
        CalculateMandeh = CDec("0" & Txtamount_ATm.Text) - CalculateMandeh
        If CalculateMandeh < 0 Then
            CalculateMandeh = 0
        End If
    End Function

    Private Sub ClsGlAccount1_NotFindGlaAccount() Handles ClsGlAccount1.NotFindGlaAccount
        GrdDetail.GetRow.Cells(2).Value = ""
        GrdDetail.GetRow.Cells(1).Value = ""
        EnableDisableSave()
        ' GrdDetail.selero()
    End Sub
#Region "Gl Debit Deposit"
    Private Sub InsertIntoGlDebitdiposit()
        CmdGeneral.Connection = Cnn
        Dim Mid_debit_deposit_head As Decimal = 0
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            CmdGeneral.CommandText = " Insert into Gl_debit_deposit_head(id_bank,date_doc)  values( " & Qt(CmbBankAccount.SelectedValue) & " , " & Qt(Txtdate_transaction.Text.Trim) & " ) ;Select id_debit_deposit_head from GL_debit_deposit_head where id_debit_deposit_head=@@IDENTITY"
            Mid_debit_deposit_head = CmdGeneral.ExecuteScalar()
            If RbCredit.Checked = True Then
                CmdGeneral.CommandText = " Insert into GL_debit_deposit(type_transaction,deposit_amount,id_Atm,id_debit_deposit_head)  values( '7'," & Txtamount_ATm.Text & " , " & id_Atm & " , " & Mid_debit_deposit_head & " ) "
            Else
                CmdGeneral.CommandText = " Insert into GL_debit_deposit(type_transaction,debit_amount,id_Atm,id_debit_deposit_head)  values( '7'," & Txtamount_ATm.Text & " , " & id_Atm & " , " & Mid_debit_deposit_head & " ) "
            End If
            '--------------------------------------
            CmdGeneral.ExecuteNonQuery()

            CmdGeneral.CommandText = " Update bank_Atm set id_debit_deposit_head =  " & Mid_debit_deposit_head & " Where id_Atm = " & id_Atm
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
            MsgFar("Error: Not inserted into Debit diposit Table ")
            MsgBox(ex.ToString)
        Finally
            CmdGeneral.Connection.Close()
        End Try
    End Sub
    Private Sub UpdateGlDebitDiposit()
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim Mid_debit_deposit_head As Decimal = 0
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            Mid_debit_deposit_head = CDec("0" & DsFrmAtmTransaction1.bank_ATM.Rows(0).Item("id_debit_deposit_head"))
            If Mid_debit_deposit_head <> 0 Then
                CmdGeneral.CommandText = " Update Gl_debit_deposit_head set id_Bank  =" & Qt(CmbBankAccount.SelectedValue) & " ,  date_doc = " & Qt(Txtdate_transaction.Text.Trim) & "  Where  id_debit_deposit_head= " & Mid_debit_deposit_head
                CmdGeneral.ExecuteNonQuery()
                If RbCharge.Checked = True Then
                    CmdGeneral.CommandText = " update GL_debit_deposit set deposit_amount  = " & Txtamount_ATm.Text & " , debit_amount =0   Where  id_Atm= " & id_Atm
                Else
                    CmdGeneral.CommandText = " update GL_debit_deposit set debit_amount =  " & Txtamount_ATm.Text & " ,deposit_amount =0  Where  id_Atm= " & id_Atm
                End If
                CmdGeneral.ExecuteNonQuery()
                Call DleteGlDebitDeposit()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            CmdGeneral.Connection.Close()
        End Try
    End Sub
    Private Sub DleteGlDebitDeposit()
        'CmdGeneral.Connection = Cnn
        'If Cmbcheckstatus.SelectedIndex = 2 Then
        '    If CmdGeneral.Connection.State <> ConnectionState.Open Then
        '        CmdGeneral.Connection.Open()
        '    End If
        '    Dim Mid_debit_deposit_head As Decimal = 0
        '    Try
        '        Mid_debit_deposit_head = DsFrmCheckScreen1.bank_check.Rows(0).Item("id_debit_deposit_head")
        '        CmdGeneral.CommandText = " update bank_check set id_debit_deposit_head = NULL "
        '        CmdGeneral.ExecuteNonQuery()
        '        CmdGeneral.CommandText = " delete From GL_debit_deposit_head Where  id_debit_deposit_head= " & Mid_debit_deposit_head
        '        'CmdGeneral.CommandText = " delete From GL_debit_deposit_head Where  id_debit_deposit_head= " & Mid_debit_deposit_head
        '        CmdGeneral.ExecuteNonQuery()
        '    Catch ex As Exception
        '        MsgBox(ex.ToString)
        '    Finally
        '        CmdGeneral.Connection.Close()
        '    End Try
        '    'CmdGeneral.ExecuteNonQuery()
        'End If
    End Sub
#End Region
    Function SumGrdDetail() As Decimal
        SumGrdDetail = CDec("0" & DsFrmAtmTransaction1.bank_ATM_dtl.Compute("sum(amount)", "trim(GL_Account) <> ''"))
    End Function
#Region "Find Address"

    Private Sub cod_vendo_FindVendorNoRow(ByVal ThisRow As System.Data.DataRow) Handles Txtcod_vendor.FindVendorNoRow
        Txtaddress_payee.Clear()
        Txtaddress_payee.Text = ThisRow("desc_vendor") & "" + vbCrLf + ThisRow("address") & ""
        ZipCode1.ZipCode = ThisRow("zipcode") & ""
        'TxtnvoiceNo.Cod_Vendor = ThisRow("cod_vendor")
        Call InsertVendoreRow(ThisRow("vendor_type"))
        Txtaddress_payee.Refresh()
    End Sub
    Private Sub ZipCode1_FindZipCode() Handles ZipCode1.FindZipCode
        Txtaddress_payee.Text = Txtaddress_payee.Text + vbCrLf + ZipCode1.City & "   " + ZipCode1.State & "   " + ZipCode1.ZipCode
    End Sub
    Private Sub InsertVendoreRow(ByVal ThisVendoreType As String)
        Dim ds1 As New DataSet
        Try
            If ThisVendoreType.Trim & "" <> "" Then
                Dainv_tab_vendor_type.SelectCommand.Parameters(0).Value = ThisVendoreType
                Dainv_tab_vendor_type.Fill(ds1, "t1")
                If ds1.Tables("t1").Rows.Count > 0 Then
                    If ds1.Tables("t1").Rows(0).Item("GL_expense_account") & "" <> "" Then
                        If DsFrmAtmTransaction1.bank_ATM_dtl.Rows(0).Item("GL_Account") = "" Then
                            DsFrmAtmTransaction1.bank_ATM_dtl.Rows(0).Item("GL_Account") = ds1.Tables("t1").Rows(0).Item("GL_expense_account")
                            ClsGlAccount1.FindDesc(ds1.Tables("t1").Rows(0).Item("GL_expense_account"))
                            DsFrmAtmTransaction1.bank_ATM_dtl.Rows(0).Item("amount") = Txtamount_ATm.Text
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgFar(ex.ToString)
        End Try
    End Sub
#End Region

End Class
