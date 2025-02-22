Imports CommonClass
Imports Janus.Windows.GridEX
Public Class FrmCheckScreen
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
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
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
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DsFrmCheckScreen1 As UcAccount.DSFrmCheckScreen
    Friend WithEvents CmbBankAccount As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtNo_Of_Check As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Txtdate_of_check As CalendarCombo.CalendarCombo
    Friend WithEvents Txtamount_check As CalcUtils.UcCalcText
    Friend WithEvents Txtaddress_payee As System.Windows.Forms.TextBox
    Friend WithEvents Txtmemo_check As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ZipCode1 As UCZipCode.ZipCode
    Friend WithEvents TxtInvoiceDate As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Dabank_check_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents TxtRef As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Txtcod_vendor As UCVendor.Vendor_Cod
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents TxtnvoiceNo As UcReceiveReturnProduct.VendoreOfInvoice
    Friend WithEvents ChkManualCheck As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPrintLater As System.Windows.Forms.CheckBox
    Friend WithEvents ChkClereadBank As System.Windows.Forms.CheckBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaBanks As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TxtNumberString As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Cmbcheckstatus As System.Windows.Forms.ComboBox
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Dabank_check As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Dainv_tab_vendor_type As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents LblError As System.Windows.Forms.Label
    Friend WithEvents Cm1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TxtEndingBalance As CalcUtils.UcCalcText
    Friend WithEvents CmdPrepared As Janus.Windows.EditControls.UIButton
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaPayment As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGl_ap_Bill As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Da_Ap_Bill_Sum As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents InvRecevieReturnCreadit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Daservice_out_purchases As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Da_InvRecSum As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents BtnPrintAtt As System.Windows.Forms.Button
    Friend WithEvents DAPrint As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Employee_Cod1 As UCEmployee.Employee_Cod
    Friend WithEvents RdEmployee As System.Windows.Forms.RadioButton
    Friend WithEvents RdOther As System.Windows.Forms.RadioButton
    Friend WithEvents GbTYpecheck As System.Windows.Forms.GroupBox
    Friend WithEvents LblName As System.Windows.Forms.Label
    Friend WithEvents DaPrintEmplyee2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCheckScreen))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label18 = New System.Windows.Forms.Label
        Me.BtnPrintAtt = New System.Windows.Forms.Button
        Me.CmdPrepared = New Janus.Windows.EditControls.UIButton
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnPreview = New System.Windows.Forms.Button
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
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.TxtEndingBalance = New CalcUtils.UcCalcText
        Me.TxtRef = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.CmbBankAccount = New System.Windows.Forms.ComboBox
        Me.DsFrmCheckScreen1 = New UcAccount.DSFrmCheckScreen
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LblName = New System.Windows.Forms.Label
        Me.Employee_Cod1 = New UCEmployee.Employee_Cod
        Me.GbTYpecheck = New System.Windows.Forms.GroupBox
        Me.RdOther = New System.Windows.Forms.RadioButton
        Me.RdEmployee = New System.Windows.Forms.RadioButton
        Me.LblError = New System.Windows.Forms.Label
        Me.Cmbcheckstatus = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtNumberString = New System.Windows.Forms.TextBox
        Me.Txtmemo_check = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Txtaddress_payee = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Txtcod_vendor = New UCVendor.Vendor_Cod
        Me.Label8 = New System.Windows.Forms.Label
        Me.Txtamount_check = New CalcUtils.UcCalcText
        Me.Label7 = New System.Windows.Forms.Label
        Me.Txtdate_of_check = New CalendarCombo.CalendarCombo
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtNo_Of_Check = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ZipCode1 = New UCZipCode.ZipCode
        Me.Label17 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TxtInvoiceDate = New System.Windows.Forms.TextBox
        Me.TxtnvoiceNo = New UcReceiveReturnProduct.VendoreOfInvoice
        Me.ChkClereadBank = New System.Windows.Forms.CheckBox
        Me.ChkPrintLater = New System.Windows.Forms.CheckBox
        Me.ChkManualCheck = New System.Windows.Forms.CheckBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Dabank_check_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.Cm1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaBanks = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Dabank_check = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.Dainv_tab_vendor_type = New System.Data.SqlClient.SqlDataAdapter
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DaPayment = New System.Data.SqlClient.SqlDataAdapter
        Me.DaGl_ap_Bill = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Da_Ap_Bill_Sum = New System.Data.SqlClient.SqlDataAdapter
        Me.InvRecevieReturnCreadit = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand9 = New System.Data.SqlClient.SqlCommand
        Me.Daservice_out_purchases = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Da_InvRecSum = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAPrint = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DaPrintEmplyee2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand
        Me.Panel4.SuspendLayout()
        Me.PnlSearch.SuspendLayout()
        CType(Me.DsFrmCheckScreen1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GbTYpecheck.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'Cnn
        '
        '
        'imageList1
        '
        Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.BtnPrintAtt)
        Me.Panel4.Controls.Add(Me.CmdPrepared)
        Me.Panel4.Controls.Add(Me.Label29)
        Me.Panel4.Controls.Add(Me.Label28)
        Me.Panel4.Controls.Add(Me.BtnPrint)
        Me.Panel4.Controls.Add(Me.BtnPreview)
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
        Me.Panel4.Size = New System.Drawing.Size(627, 45)
        Me.Panel4.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(504, 32)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 10)
        Me.Label18.TabIndex = 201
        Me.Label18.Text = "Print Attachment"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnPrintAtt
        '
        Me.BtnPrintAtt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrintAtt.Image = CType(resources.GetObject("BtnPrintAtt.Image"), System.Drawing.Image)
        Me.BtnPrintAtt.Location = New System.Drawing.Point(526, 4)
        Me.BtnPrintAtt.Name = "BtnPrintAtt"
        Me.BtnPrintAtt.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrintAtt.TabIndex = 200
        '
        'CmdPrepared
        '
        Me.CmdPrepared.Location = New System.Drawing.Point(563, 4)
        Me.CmdPrepared.Name = "CmdPrepared"
        Me.CmdPrepared.Size = New System.Drawing.Size(57, 27)
        Me.CmdPrepared.TabIndex = 199
        Me.CmdPrepared.Text = "Prepared Payment"
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(461, 31)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 198
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(419, 31)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 10)
        Me.Label28.TabIndex = 197
        Me.Label28.Text = "Preview"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(462, 2)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 196
        '
        'BtnPreview
        '
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Image = CType(resources.GetObject("BtnPreview.Image"), System.Drawing.Image)
        Me.BtnPreview.Location = New System.Drawing.Point(422, 2)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(33, 27)
        Me.BtnPreview.TabIndex = 195
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
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.TxtEndingBalance)
        Me.PnlSearch.Controls.Add(Me.TxtRef)
        Me.PnlSearch.Controls.Add(Me.Label16)
        Me.PnlSearch.Controls.Add(Me.CmbBankAccount)
        Me.PnlSearch.Controls.Add(Me.Label4)
        Me.PnlSearch.Controls.Add(Me.Label2)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 45)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(627, 30)
        Me.PnlSearch.TabIndex = 6
        '
        'TxtEndingBalance
        '
        Me.TxtEndingBalance.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.TxtEndingBalance.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtEndingBalance.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.TxtEndingBalance.DecimalDigits = 2
        Me.TxtEndingBalance.DefaultSendValue = False
        Me.TxtEndingBalance.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtEndingBalance.FireTabAfterEnter = True
        Me.TxtEndingBalance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtEndingBalance.Image = CType(resources.GetObject("TxtEndingBalance.Image"), System.Drawing.Image)
        Me.TxtEndingBalance.Location = New System.Drawing.Point(371, 2)
        Me.TxtEndingBalance.Maxlength = 10
        Me.TxtEndingBalance.MinusColor = System.Drawing.Color.Empty
        Me.TxtEndingBalance.Name = "TxtEndingBalance"
        Me.TxtEndingBalance.ReadOnly = True
        Me.TxtEndingBalance.Size = New System.Drawing.Size(109, 21)
        Me.TxtEndingBalance.TabIndex = 144
        Me.TxtEndingBalance.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtEndingBalance.VisualStyle = Janus.Windows.GridEX.VisualStyle.Standard
        '
        'TxtRef
        '
        Me.TxtRef.BackColor = System.Drawing.SystemColors.Window
        Me.TxtRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRef.Enabled = False
        Me.TxtRef.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtRef.Location = New System.Drawing.Point(520, 2)
        Me.TxtRef.Name = "TxtRef"
        Me.TxtRef.ReadOnly = True
        Me.TxtRef.Size = New System.Drawing.Size(96, 21)
        Me.TxtRef.TabIndex = 143
        Me.TxtRef.Text = ""
        Me.TxtRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label16.Location = New System.Drawing.Point(488, 4)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 21)
        Me.Label16.TabIndex = 142
        Me.Label16.Text = "Ref"
        '
        'CmbBankAccount
        '
        Me.CmbBankAccount.DataSource = Me.DsFrmCheckScreen1.bas_banks
        Me.CmbBankAccount.DisplayMember = "name_bank"
        Me.CmbBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBankAccount.Location = New System.Drawing.Point(90, 1)
        Me.CmbBankAccount.Name = "CmbBankAccount"
        Me.CmbBankAccount.Size = New System.Drawing.Size(192, 21)
        Me.CmbBankAccount.TabIndex = 3
        Me.CmbBankAccount.ValueMember = "id_bank"
        '
        'DsFrmCheckScreen1
        '
        Me.DsFrmCheckScreen1.DataSetName = "DSFrmCheckScreen"
        Me.DsFrmCheckScreen1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(289, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Ending Balance"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Bank Account"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.LblName)
        Me.Panel1.Controls.Add(Me.Employee_Cod1)
        Me.Panel1.Controls.Add(Me.GbTYpecheck)
        Me.Panel1.Controls.Add(Me.LblError)
        Me.Panel1.Controls.Add(Me.Cmbcheckstatus)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.TxtNumberString)
        Me.Panel1.Controls.Add(Me.Txtmemo_check)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Txtaddress_payee)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Txtcod_vendor)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Txtamount_check)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Txtdate_of_check)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtNo_Of_Check)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.ZipCode1)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Location = New System.Drawing.Point(5, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(619, 225)
        Me.Panel1.TabIndex = 7
        '
        'LblName
        '
        Me.LblName.Location = New System.Drawing.Point(190, 84)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(232, 17)
        Me.LblName.TabIndex = 20
        Me.LblName.Visible = False
        '
        'Employee_Cod1
        '
        Me.Employee_Cod1.BackColor = System.Drawing.SystemColors.Info
        Me.Employee_Cod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Employee_Cod1.Connection = Me.Cnn
        Me.Employee_Cod1.EmployeeCod = ""
        Me.Employee_Cod1.EmployeeCodLen = 5
        Me.Employee_Cod1.Enabled = False
        Me.Employee_Cod1.Kind_Employee = ""
        Me.Employee_Cod1.Location = New System.Drawing.Point(95, 80)
        Me.Employee_Cod1.Name = "Employee_Cod1"
        Me.Employee_Cod1.NotExitIfNotFound = False
        Me.Employee_Cod1.ReleaseIfNotFoundEmployeeCod = False
        Me.Employee_Cod1.Size = New System.Drawing.Size(95, 23)
        Me.Employee_Cod1.TabIndex = 19
        Me.Employee_Cod1.Visible = False
        '
        'GbTYpecheck
        '
        Me.GbTYpecheck.BackColor = System.Drawing.Color.Transparent
        Me.GbTYpecheck.Controls.Add(Me.RdOther)
        Me.GbTYpecheck.Controls.Add(Me.RdEmployee)
        Me.GbTYpecheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GbTYpecheck.ForeColor = System.Drawing.Color.Black
        Me.GbTYpecheck.Location = New System.Drawing.Point(0, 5)
        Me.GbTYpecheck.Name = "GbTYpecheck"
        Me.GbTYpecheck.Size = New System.Drawing.Size(194, 25)
        Me.GbTYpecheck.TabIndex = 18
        Me.GbTYpecheck.TabStop = False
        '
        'RdOther
        '
        Me.RdOther.Checked = True
        Me.RdOther.Location = New System.Drawing.Point(141, 0)
        Me.RdOther.Name = "RdOther"
        Me.RdOther.Size = New System.Drawing.Size(140, 24)
        Me.RdOther.TabIndex = 1
        Me.RdOther.TabStop = True
        Me.RdOther.Text = "Other"
        '
        'RdEmployee
        '
        Me.RdEmployee.Location = New System.Drawing.Point(16, 0)
        Me.RdEmployee.Name = "RdEmployee"
        Me.RdEmployee.Size = New System.Drawing.Size(140, 24)
        Me.RdEmployee.TabIndex = 0
        Me.RdEmployee.Text = "Pay To Employee"
        '
        'LblError
        '
        Me.LblError.ForeColor = System.Drawing.Color.Brown
        Me.LblError.Location = New System.Drawing.Point(18, 40)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(385, 22)
        Me.LblError.TabIndex = 17
        '
        'Cmbcheckstatus
        '
        Me.Cmbcheckstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbcheckstatus.Items.AddRange(New Object() {"active", "void ", "delete", "return"})
        Me.Cmbcheckstatus.Location = New System.Drawing.Point(405, 160)
        Me.Cmbcheckstatus.Name = "Cmbcheckstatus"
        Me.Cmbcheckstatus.Size = New System.Drawing.Size(161, 21)
        Me.Cmbcheckstatus.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(536, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 18)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Dollars"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtNumberString
        '
        Me.TxtNumberString.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.TxtNumberString.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNumberString.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumberString.Location = New System.Drawing.Point(8, 112)
        Me.TxtNumberString.MaxLength = 20
        Me.TxtNumberString.Name = "TxtNumberString"
        Me.TxtNumberString.ReadOnly = True
        Me.TxtNumberString.Size = New System.Drawing.Size(528, 13)
        Me.TxtNumberString.TabIndex = 13
        Me.TxtNumberString.Text = ""
        '
        'Txtmemo_check
        '
        Me.Txtmemo_check.BackColor = System.Drawing.SystemColors.Info
        Me.Txtmemo_check.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtmemo_check.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtmemo_check.Location = New System.Drawing.Point(96, 192)
        Me.Txtmemo_check.MaxLength = 200
        Me.Txtmemo_check.Name = "Txtmemo_check"
        Me.Txtmemo_check.Size = New System.Drawing.Size(504, 20)
        Me.Txtmemo_check.TabIndex = 12
        Me.Txtmemo_check.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(41, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Memo"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Txtaddress_payee
        '
        Me.Txtaddress_payee.BackColor = System.Drawing.SystemColors.Info
        Me.Txtaddress_payee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtaddress_payee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtaddress_payee.Location = New System.Drawing.Point(96, 136)
        Me.Txtaddress_payee.MaxLength = 150
        Me.Txtaddress_payee.Multiline = True
        Me.Txtaddress_payee.Name = "Txtaddress_payee"
        Me.Txtaddress_payee.Size = New System.Drawing.Size(296, 50)
        Me.Txtaddress_payee.TabIndex = 10
        Me.Txtaddress_payee.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(32, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Address"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Txtcod_vendor
        '
        Me.Txtcod_vendor.BackColor = System.Drawing.SystemColors.Info
        Me.Txtcod_vendor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Txtcod_vendor.Connection = Me.Cnn
        Me.Txtcod_vendor.Location = New System.Drawing.Point(96, 80)
        Me.Txtcod_vendor.Name = "Txtcod_vendor"
        Me.Txtcod_vendor.NotExitIfNotFound = False
        Me.Txtcod_vendor.ReleaseIfNotFoundVendorCod = False
        Me.Txtcod_vendor.Size = New System.Drawing.Size(208, 20)
        Me.Txtcod_vendor.TabIndex = 8
        Me.Txtcod_vendor.VendorCod = ""
        Me.Txtcod_vendor.VendorCodLen = 6
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(0, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Pay To Order Of"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Txtamount_check
        '
        Me.Txtamount_check.BackColor = System.Drawing.SystemColors.Info
        Me.Txtamount_check.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Txtamount_check.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Txtamount_check.DecimalDigits = 2
        Me.Txtamount_check.DefaultSendValue = False
        Me.Txtamount_check.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Txtamount_check.FireTabAfterEnter = True
        Me.Txtamount_check.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Txtamount_check.Image = CType(resources.GetObject("Txtamount_check.Image"), System.Drawing.Image)
        Me.Txtamount_check.Location = New System.Drawing.Point(465, 80)
        Me.Txtamount_check.Maxlength = 10
        Me.Txtamount_check.MinusColor = System.Drawing.Color.Empty
        Me.Txtamount_check.Name = "Txtamount_check"
        Me.Txtamount_check.Size = New System.Drawing.Size(120, 22)
        Me.Txtamount_check.TabIndex = 6
        Me.Txtamount_check.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Txtamount_check.VisualStyle = Janus.Windows.GridEX.VisualStyle.Standard
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(416, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "$"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Txtdate_of_check
        '
        Me.Txtdate_of_check.BackColor = System.Drawing.SystemColors.Info
        Me.Txtdate_of_check.BorderColor = System.Drawing.Color.Empty
        Me.Txtdate_of_check.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtdate_of_check.ButtonBackColor = System.Drawing.Color.Empty
        Me.Txtdate_of_check.ButtonForeColor = System.Drawing.Color.Empty
        Me.Txtdate_of_check.EditableSal = True
        Me.Txtdate_of_check.Image = CType(resources.GetObject("Txtdate_of_check.Image"), System.Drawing.Image)
        Me.Txtdate_of_check.Location = New System.Drawing.Point(464, 48)
        Me.Txtdate_of_check.MaxValue = CType(2500, Short)
        Me.Txtdate_of_check.MinValue = CType(1800, Short)
        Me.Txtdate_of_check.Name = "Txtdate_of_check"
        Me.Txtdate_of_check.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txtdate_of_check.Sal_Mali = Nothing
        Me.Txtdate_of_check.ShowButton = True
        Me.Txtdate_of_check.Size = New System.Drawing.Size(120, 23)
        Me.Txtdate_of_check.TabIndex = 4
        Me.Txtdate_of_check.VisualStyle = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(416, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 23)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtNo_Of_Check
        '
        Me.TxtNo_Of_Check.BackColor = System.Drawing.SystemColors.Info
        Me.TxtNo_Of_Check.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNo_Of_Check.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNo_Of_Check.Location = New System.Drawing.Point(464, 24)
        Me.TxtNo_Of_Check.MaxLength = 20
        Me.TxtNo_Of_Check.Name = "TxtNo_Of_Check"
        Me.TxtNo_Of_Check.Size = New System.Drawing.Size(120, 20)
        Me.TxtNo_Of_Check.TabIndex = 2
        Me.TxtNo_Of_Check.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(416, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "No ."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ZipCode1
        '
        Me.ZipCode1.Connection = Me.Cnn
        Me.ZipCode1.Enabled = False
        Me.ZipCode1.Location = New System.Drawing.Point(12, 128)
        Me.ZipCode1.Name = "ZipCode1"
        Me.ZipCode1.NotExitIfNotFound = False
        Me.ZipCode1.ReleaseIfNotFoundZipCode = False
        Me.ZipCode1.Size = New System.Drawing.Size(12, 21)
        Me.ZipCode1.TabIndex = 9
        Me.ZipCode1.Visible = False
        Me.ZipCode1.ZipCode = ""
        Me.ZipCode1.ZipCodeLen = 5
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(401, 136)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(134, 23)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Check Status"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TxtInvoiceDate)
        Me.Panel2.Controls.Add(Me.TxtnvoiceNo)
        Me.Panel2.Controls.Add(Me.ChkClereadBank)
        Me.Panel2.Controls.Add(Me.ChkPrintLater)
        Me.Panel2.Controls.Add(Me.ChkManualCheck)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(8, 304)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(616, 56)
        Me.Panel2.TabIndex = 8
        '
        'TxtInvoiceDate
        '
        Me.TxtInvoiceDate.BackColor = System.Drawing.SystemColors.Control
        Me.TxtInvoiceDate.Location = New System.Drawing.Point(504, 8)
        Me.TxtInvoiceDate.Name = "TxtInvoiceDate"
        Me.TxtInvoiceDate.TabIndex = 7
        Me.TxtInvoiceDate.Text = ""
        '
        'TxtnvoiceNo
        '
        Me.TxtnvoiceNo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtnvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtnvoiceNo.Cod_Vendor = Nothing
        Me.TxtnvoiceNo.Connection = Me.Cnn
        Me.TxtnvoiceNo.Location = New System.Drawing.Point(87, 8)
        Me.TxtnvoiceNo.Name = "TxtnvoiceNo"
        Me.TxtnvoiceNo.NotExitIfNotFound = False
        Me.TxtnvoiceNo.ReleaseIfNotFound = False
        Me.TxtnvoiceNo.Size = New System.Drawing.Size(337, 20)
        Me.TxtnvoiceNo.TabIndex = 6
        '
        'ChkClereadBank
        '
        Me.ChkClereadBank.Enabled = False
        Me.ChkClereadBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkClereadBank.ForeColor = System.Drawing.Color.Black
        Me.ChkClereadBank.Location = New System.Drawing.Point(432, 29)
        Me.ChkClereadBank.Name = "ChkClereadBank"
        Me.ChkClereadBank.Size = New System.Drawing.Size(128, 24)
        Me.ChkClereadBank.TabIndex = 5
        Me.ChkClereadBank.Text = "Cleared the Bank"
        '
        'ChkPrintLater
        '
        Me.ChkPrintLater.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPrintLater.ForeColor = System.Drawing.Color.Black
        Me.ChkPrintLater.Location = New System.Drawing.Point(192, 29)
        Me.ChkPrintLater.Name = "ChkPrintLater"
        Me.ChkPrintLater.Size = New System.Drawing.Size(128, 24)
        Me.ChkPrintLater.TabIndex = 4
        Me.ChkPrintLater.Text = "To Be Printed Later"
        '
        'ChkManualCheck
        '
        Me.ChkManualCheck.Location = New System.Drawing.Point(8, 29)
        Me.ChkManualCheck.Name = "ChkManualCheck"
        Me.ChkManualCheck.Size = New System.Drawing.Size(128, 24)
        Me.ChkManualCheck.TabIndex = 3
        Me.ChkManualCheck.Text = "Manual Check"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(432, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 23)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Invoice Date"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(12, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 23)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Invoice No"
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT bank_check_dtl.id_check, bank_check_dtl.radif, bank_check_dtl.GL_Account, " & _
        "bank_check_dtl.amount, bank_check_dtl.memo_dtl, GL_account.desc_GL_account FROM " & _
        "bank_check_dtl INNER JOIN GL_account ON bank_check_dtl.GL_Account = GL_account.G" & _
        "L_account WHERE (bank_check_dtl.id_check = @id_check)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_check", System.Data.SqlDbType.Int, 4, "id_check"))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO bank_check_dtl(id_check, radif, GL_Account, amount, memo_dtl) VALUES " & _
        "(@id_check, @radif, @GL_Account, @amount, @memo_dtl); SELECT id_check, radif, GL" & _
        "_Account, amount, memo_dtl FROM bank_check_dtl WHERE (id_check = @id_check) AND " & _
        "(radif = @radif)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_check", System.Data.SqlDbType.Int, 4, "id_check"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_Account", System.Data.SqlDbType.VarChar, 10, "GL_Account"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount", System.Data.SqlDbType.Money, 8, "amount"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@memo_dtl", System.Data.SqlDbType.VarChar, 50, "memo_dtl"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE bank_check_dtl SET id_check = @id_check, radif = @radif, GL_Account = @GL_" & _
        "Account, amount = @amount, memo_dtl = @memo_dtl WHERE (id_check = @Original_id_c" & _
        "heck) AND (radif = @Original_radif) AND (GL_Account = @Original_GL_Account OR @O" & _
        "riginal_GL_Account IS NULL AND GL_Account IS NULL) AND (amount = @Original_amoun" & _
        "t OR @Original_amount IS NULL AND amount IS NULL) AND (memo_dtl = @Original_memo" & _
        "_dtl OR @Original_memo_dtl IS NULL AND memo_dtl IS NULL); SELECT id_check, radif" & _
        ", GL_Account, amount, memo_dtl FROM bank_check_dtl WHERE (id_check = @id_check) " & _
        "AND (radif = @radif)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_check", System.Data.SqlDbType.Int, 4, "id_check"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_Account", System.Data.SqlDbType.VarChar, 10, "GL_Account"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount", System.Data.SqlDbType.Money, 8, "amount"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@memo_dtl", System.Data.SqlDbType.VarChar, 50, "memo_dtl"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_check", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_Account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_Account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_memo_dtl", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "memo_dtl", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM bank_check_dtl WHERE (id_check = @Original_id_check) AND (radif = @Or" & _
        "iginal_radif) AND (GL_Account = @Original_GL_Account OR @Original_GL_Account IS " & _
        "NULL AND GL_Account IS NULL) AND (amount = @Original_amount OR @Original_amount " & _
        "IS NULL AND amount IS NULL) AND (memo_dtl = @Original_memo_dtl OR @Original_memo" & _
        "_dtl IS NULL AND memo_dtl IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_check", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_Account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_Account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_memo_dtl", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "memo_dtl", System.Data.DataRowVersion.Original, Nothing))
        '
        'Dabank_check_dtl
        '
        Me.Dabank_check_dtl.DeleteCommand = Me.SqlDeleteCommand1
        Me.Dabank_check_dtl.InsertCommand = Me.SqlInsertCommand1
        Me.Dabank_check_dtl.SelectCommand = Me.SqlSelectCommand2
        Me.Dabank_check_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bank_check_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("GL_Account", "GL_Account"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("memo_dtl", "memo_dtl")})})
        Me.Dabank_check_dtl.UpdateCommand = Me.SqlUpdateCommand1
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowColumnDrag = False
        Me.GrdDetail.AutomaticSort = False
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.ContextMenu = Me.Cm1
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "bank_check_dtl"
        Me.GrdDetail.DataSource = Me.DsFrmCheckScreen1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>bank_check_dtl</Caption><Columns Collection" & _
        "=""true""><Column0 ID=""SelectGl""><ButtonDisplayMode>Always</ButtonDisplayMode><All" & _
        "owSort>False</AllowSort><Bound>False</Bound><ButtonStyle>ButtonCell</ButtonStyle" & _
        "><EditType>NoEdit</EditType><Key>SelectGl</Key><Position>0</Position><Selectable" & _
        ">False</Selectable><Width>24</Width></Column0><Column1 ID=""GL_Account""><Caption>" & _
        "GL Account No.</Caption><DataMember>GL_Account</DataMember><Key>GL_Account</Key>" & _
        "<Position>1</Position><Width>91</Width></Column1><Column2 ID=""desc_GL_account""><" & _
        "Caption>Account Name</Caption><DataMember>desc_GL_account</DataMember><Key>desc_" & _
        "GL_account</Key><Position>2</Position><Selectable>False</Selectable><Width>163</" & _
        "Width></Column2><Column3 ID=""amount""><AggregateFunction>Sum</AggregateFunction><" & _
        "Caption>Amount</Caption><DataMember>amount</DataMember><FormatString>c</FormatSt" & _
        "ring><Key>amount</Key><Position>3</Position><TextAlignment>Far</TextAlignment><W" & _
        "idth>104</Width><TotalFormatString>c2</TotalFormatString><UpDownMaximum>180</UpD" & _
        "ownMaximum></Column3><Column4 ID=""memo_dtl""><Caption>Memo</Caption><DataMember>m" & _
        "emo_dtl</DataMember><Key>memo_dtl</Key><Position>4</Position><Width>235</Width><" & _
        "UpDownMaximum>200</UpDownMaximum></Column4><Column5 ID=""radif""><Caption>radif</C" & _
        "aption><DataMember>radif</DataMember><EditType>NoEdit</EditType><Key>radif</Key>" & _
        "<Position>5</Position><Visible>False</Visible></Column5></Columns><GroupConditio" & _
        "n ID="""" /><Key>bank_check_dtl</Key></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.ExternalImageList = Me.imageList1
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(0, 363)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(627, 200)
        Me.GrdDetail.TabIndex = 9
        Me.GrdDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True
        '
        'Cm1
        '
        Me.Cm1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.CtrlD
        Me.MenuItem1.Text = "Delete This Row "
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.MenuItem2.Text = "Insert A Row"
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
        'DaBanks
        '
        Me.DaBanks.SelectCommand = Me.SqlSelectCommand1
        Me.DaBanks.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_banks", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("name_bank", "name_bank"), New System.Data.Common.DataColumnMapping("share_all_store", "share_all_store"), New System.Data.Common.DataColumnMapping("store_no", "store_no"), New System.Data.Common.DataColumnMapping("account_no", "account_no"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zip", "zip"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("contact_name", "contact_name"), New System.Data.Common.DataColumnMapping("GL_Account", "GL_Account"), New System.Data.Common.DataColumnMapping("start_check_no", "start_check_no"), New System.Data.Common.DataColumnMapping("next_check_no", "next_check_no"), New System.Data.Common.DataColumnMapping("default_bank", "default_bank"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("cod_account_type", "cod_account_type"), New System.Data.Common.DataColumnMapping("routing_numbers", "routing_numbers"), New System.Data.Common.DataColumnMapping("Bank_ID", "Bank_ID"), New System.Data.Common.DataColumnMapping("Web_Page", "Web_Page"), New System.Data.Common.DataColumnMapping("User_ID", "User_ID"), New System.Data.Common.DataColumnMapping("Password", "Password"), New System.Data.Common.DataColumnMapping("Security_code", "Security_code"), New System.Data.Common.DataColumnMapping("online_banking", "online_banking")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT id_check, id_bank, no_of_check, date_of_check, amount_check, cod_vendor, e" & _
        "mployee_code, address_payee, memo_check, invoice_no, manual_check, print_later, " & _
        "cleared_bank, check_status, id_debit_deposit_head FROM bank_check WHERE (id_chec" & _
        "k = @id_check)"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_check", System.Data.SqlDbType.Int, 4, "id_check"))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO bank_check(id_bank, no_of_check, date_of_check, amount_check, cod_ven" & _
        "dor, employee_code, address_payee, memo_check, invoice_no, manual_check, print_l" & _
        "ater, cleared_bank, check_status, id_debit_deposit_head) VALUES (@id_bank, @no_o" & _
        "f_check, @date_of_check, @amount_check, @cod_vendor, @employee_code, @address_pa" & _
        "yee, @memo_check, @invoice_no, @manual_check, @print_later, @cleared_bank, @chec" & _
        "k_status, @id_debit_deposit_head); SELECT id_check, id_bank, no_of_check, date_o" & _
        "f_check, amount_check, cod_vendor, employee_code, address_payee, memo_check, inv" & _
        "oice_no, manual_check, print_later, cleared_bank, check_status, id_debit_deposit" & _
        "_head FROM bank_check WHERE (id_check = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank", System.Data.SqlDbType.SmallInt, 2, "id_bank"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@no_of_check", System.Data.SqlDbType.VarChar, 20, "no_of_check"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_of_check", System.Data.SqlDbType.VarChar, 10, "date_of_check"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_check", System.Data.SqlDbType.Money, 8, "amount_check"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address_payee", System.Data.SqlDbType.VarChar, 150, "address_payee"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@memo_check", System.Data.SqlDbType.VarChar, 200, "memo_check"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@invoice_no", System.Data.SqlDbType.VarChar, 20, "invoice_no"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@manual_check", System.Data.SqlDbType.Bit, 1, "manual_check"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@print_later", System.Data.SqlDbType.Bit, 1, "print_later"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cleared_bank", System.Data.SqlDbType.Bit, 1, "cleared_bank"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@check_status", System.Data.SqlDbType.VarChar, 1, "check_status"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_debit_deposit_head", System.Data.SqlDbType.Int, 4, "id_debit_deposit_head"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE bank_check SET id_bank = @id_bank, no_of_check = @no_of_check, date_of_che" & _
        "ck = @date_of_check, amount_check = @amount_check, cod_vendor = @cod_vendor, emp" & _
        "loyee_code = @employee_code, address_payee = @address_payee, memo_check = @memo_" & _
        "check, invoice_no = @invoice_no, manual_check = @manual_check, print_later = @pr" & _
        "int_later, cleared_bank = @cleared_bank, check_status = @check_status, id_debit_" & _
        "deposit_head = @id_debit_deposit_head WHERE (id_check = @Original_id_check) AND " & _
        "(address_payee = @Original_address_payee OR @Original_address_payee IS NULL AND " & _
        "address_payee IS NULL) AND (amount_check = @Original_amount_check OR @Original_a" & _
        "mount_check IS NULL AND amount_check IS NULL) AND (check_status = @Original_chec" & _
        "k_status OR @Original_check_status IS NULL AND check_status IS NULL) AND (cleare" & _
        "d_bank = @Original_cleared_bank OR @Original_cleared_bank IS NULL AND cleared_ba" & _
        "nk IS NULL) AND (cod_vendor = @Original_cod_vendor OR @Original_cod_vendor IS NU" & _
        "LL AND cod_vendor IS NULL) AND (date_of_check = @Original_date_of_check OR @Orig" & _
        "inal_date_of_check IS NULL AND date_of_check IS NULL) AND (employee_code = @Orig" & _
        "inal_employee_code OR @Original_employee_code IS NULL AND employee_code IS NULL)" & _
        " AND (id_bank = @Original_id_bank OR @Original_id_bank IS NULL AND id_bank IS NU" & _
        "LL) AND (id_debit_deposit_head = @Original_id_debit_deposit_head OR @Original_id" & _
        "_debit_deposit_head IS NULL AND id_debit_deposit_head IS NULL) AND (invoice_no =" & _
        " @Original_invoice_no OR @Original_invoice_no IS NULL AND invoice_no IS NULL) AN" & _
        "D (manual_check = @Original_manual_check OR @Original_manual_check IS NULL AND m" & _
        "anual_check IS NULL) AND (memo_check = @Original_memo_check OR @Original_memo_ch" & _
        "eck IS NULL AND memo_check IS NULL) AND (no_of_check = @Original_no_of_check OR " & _
        "@Original_no_of_check IS NULL AND no_of_check IS NULL) AND (print_later = @Origi" & _
        "nal_print_later OR @Original_print_later IS NULL AND print_later IS NULL); SELEC" & _
        "T id_check, id_bank, no_of_check, date_of_check, amount_check, cod_vendor, emplo" & _
        "yee_code, address_payee, memo_check, invoice_no, manual_check, print_later, clea" & _
        "red_bank, check_status, id_debit_deposit_head FROM bank_check WHERE (id_check = " & _
        "@id_check)"
        Me.SqlUpdateCommand2.Connection = Me.Cnn
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_bank", System.Data.SqlDbType.SmallInt, 2, "id_bank"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@no_of_check", System.Data.SqlDbType.VarChar, 20, "no_of_check"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_of_check", System.Data.SqlDbType.VarChar, 10, "date_of_check"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_check", System.Data.SqlDbType.Money, 8, "amount_check"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address_payee", System.Data.SqlDbType.VarChar, 150, "address_payee"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@memo_check", System.Data.SqlDbType.VarChar, 200, "memo_check"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@invoice_no", System.Data.SqlDbType.VarChar, 20, "invoice_no"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@manual_check", System.Data.SqlDbType.Bit, 1, "manual_check"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@print_later", System.Data.SqlDbType.Bit, 1, "print_later"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cleared_bank", System.Data.SqlDbType.Bit, 1, "cleared_bank"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@check_status", System.Data.SqlDbType.VarChar, 1, "check_status"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_debit_deposit_head", System.Data.SqlDbType.Int, 4, "id_debit_deposit_head"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_check", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address_payee", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address_payee", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_check", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_check_status", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "check_status", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cleared_bank", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cleared_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_of_check", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_of_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_employee_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employee_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_bank", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_debit_deposit_head", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_debit_deposit_head", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_invoice_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "invoice_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_manual_check", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "manual_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_memo_check", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "memo_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_no_of_check", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "no_of_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_print_later", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "print_later", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_check", System.Data.SqlDbType.Int, 4, "id_check"))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM bank_check WHERE (id_check = @Original_id_check) AND (address_payee =" & _
        " @Original_address_payee OR @Original_address_payee IS NULL AND address_payee IS" & _
        " NULL) AND (amount_check = @Original_amount_check OR @Original_amount_check IS N" & _
        "ULL AND amount_check IS NULL) AND (check_status = @Original_check_status OR @Ori" & _
        "ginal_check_status IS NULL AND check_status IS NULL) AND (cleared_bank = @Origin" & _
        "al_cleared_bank OR @Original_cleared_bank IS NULL AND cleared_bank IS NULL) AND " & _
        "(cod_vendor = @Original_cod_vendor OR @Original_cod_vendor IS NULL AND cod_vendo" & _
        "r IS NULL) AND (date_of_check = @Original_date_of_check OR @Original_date_of_che" & _
        "ck IS NULL AND date_of_check IS NULL) AND (employee_code = @Original_employee_co" & _
        "de OR @Original_employee_code IS NULL AND employee_code IS NULL) AND (id_bank = " & _
        "@Original_id_bank OR @Original_id_bank IS NULL AND id_bank IS NULL) AND (id_debi" & _
        "t_deposit_head = @Original_id_debit_deposit_head OR @Original_id_debit_deposit_h" & _
        "ead IS NULL AND id_debit_deposit_head IS NULL) AND (invoice_no = @Original_invoi" & _
        "ce_no OR @Original_invoice_no IS NULL AND invoice_no IS NULL) AND (manual_check " & _
        "= @Original_manual_check OR @Original_manual_check IS NULL AND manual_check IS N" & _
        "ULL) AND (memo_check = @Original_memo_check OR @Original_memo_check IS NULL AND " & _
        "memo_check IS NULL) AND (no_of_check = @Original_no_of_check OR @Original_no_of_" & _
        "check IS NULL AND no_of_check IS NULL) AND (print_later = @Original_print_later " & _
        "OR @Original_print_later IS NULL AND print_later IS NULL)"
        Me.SqlDeleteCommand2.Connection = Me.Cnn
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_check", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address_payee", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address_payee", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_check", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_check_status", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "check_status", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cleared_bank", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cleared_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_of_check", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_of_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_employee_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employee_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_bank", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_bank", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_debit_deposit_head", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_debit_deposit_head", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_invoice_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "invoice_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_manual_check", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "manual_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_memo_check", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "memo_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_no_of_check", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "no_of_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_print_later", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "print_later", System.Data.DataRowVersion.Original, Nothing))
        '
        'Dabank_check
        '
        Me.Dabank_check.DeleteCommand = Me.SqlDeleteCommand2
        Me.Dabank_check.InsertCommand = Me.SqlInsertCommand2
        Me.Dabank_check.SelectCommand = Me.SqlSelectCommand3
        Me.Dabank_check.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bank_check", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("no_of_check", "no_of_check"), New System.Data.Common.DataColumnMapping("date_of_check", "date_of_check"), New System.Data.Common.DataColumnMapping("amount_check", "amount_check"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("address_payee", "address_payee"), New System.Data.Common.DataColumnMapping("memo_check", "memo_check"), New System.Data.Common.DataColumnMapping("invoice_no", "invoice_no"), New System.Data.Common.DataColumnMapping("manual_check", "manual_check"), New System.Data.Common.DataColumnMapping("print_later", "print_later"), New System.Data.Common.DataColumnMapping("cleared_bank", "cleared_bank"), New System.Data.Common.DataColumnMapping("check_status", "check_status"), New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head")})})
        Me.Dabank_check.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT vendor_type, desc_vendor_type, GL_expense_account FROM inv_tab_vendor_type" & _
        " WHERE (vendor_type = @Vendore_type)"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Vendore_type", System.Data.SqlDbType.VarChar, 3, "vendor_type"))
        '
        'Dainv_tab_vendor_type
        '
        Me.Dainv_tab_vendor_type.SelectCommand = Me.SqlSelectCommand4
        Me.Dainv_tab_vendor_type.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_vendor_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("vendor_type", "vendor_type"), New System.Data.Common.DataColumnMapping("desc_vendor_type", "desc_vendor_type"), New System.Data.Common.DataColumnMapping("GL_expense_account", "GL_expense_account")})})
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT GL_AP_payment.date_prepare, GL_AP_payment.amount_pay AS Payment, id_ap_pay" & _
        "ment FROM service_out_purchases INNER JOIN GL_AP_payment ON service_out_purchase" & _
        "s.id_service_center = GL_AP_payment.id_service_center AND service_out_purchases." & _
        "radif = GL_AP_payment.radif WHERE  (GL_AP_payment.id_vendor_credit_head IS NULL " & _
        ") AND (GL_AP_payment.id_check IS NULL) AND cod_vendor = @ThisVendor AND date_pre" & _
        "pare = @ThisDate UNION ALL SELECT GL_AP_payment.date_prepare, GL_AP_payment.amou" & _
        "nt_pay AS payment, id_ap_payment FROM GL_AP_bill_Dtl_Dtl INNER JOIN GL_AP_paymen" & _
        "t ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl = GL_AP_payment.Id_AP_bill_dtl_dtl IN" & _
        "NER JOIN GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl.Id" & _
        "_AP_bill_dtl INNER JOIN GL_AP_Bill_Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = GL_A" & _
        "P_Bill_Head.Id_AP_bill_Head WHERE (GL_AP_payment.id_vendor_credit_head IS NULL )" & _
        "AND (GL_AP_payment.id_check IS NULL) AND cod_vendor = @ThisVendor AND date_prepa" & _
        "re = @ThisDate UNION ALL SELECT GL_AP_payment.date_prepare, GL_AP_payment.amount" & _
        "_pay AS payment, id_ap_payment FROM Inv_Receive_product_Ap_Dtl INNER JOIN GL_AP_" & _
        "payment ON Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl = GL_AP_paym" & _
        "ent.ID_Inv_Receive_product_Ap_Dtl INNER JOIN Inv_Receive_Products_head ON Inv_Re" & _
        "ceive_product_Ap_Dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref W" & _
        "HERE  (GL_AP_payment.id_vendor_credit_head IS NULL )AND(GL_AP_payment.id_check I" & _
        "S NULL) AND cod_vendor = @ThisVendor AND date_prepare = @ThisDate"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisVendor", System.Data.SqlDbType.NVarChar))
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.NVarChar))
        '
        'DaPayment
        '
        Me.DaPayment.SelectCommand = Me.SqlSelectCommand5
        Me.DaPayment.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_AP_payment", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_AP_payment", "ID_AP_payment"), New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl_dtl", "Id_AP_bill_dtl_dtl"), New System.Data.Common.DataColumnMapping("ID_Inv_Receive_product_Ap_Dtl", "ID_Inv_Receive_product_Ap_Dtl"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("amount_pay", "amount_pay"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("date_prepare", "date_prepare"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("radif1", "radif1")})})
        '
        'DaGl_ap_Bill
        '
        Me.DaGl_ap_Bill.SelectCommand = Me.SqlCommand1
        Me.DaGl_ap_Bill.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_AP_payment", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_AP_payment", "ID_AP_payment"), New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl_dtl", "Id_AP_bill_dtl_dtl"), New System.Data.Common.DataColumnMapping("ID_Inv_Receive_product_Ap_Dtl", "ID_Inv_Receive_product_Ap_Dtl"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("amount_pay", "amount_pay"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("date_prepare", "date_prepare"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("radif1", "radif1")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT GL_AP_payment.date_prepare, GL_AP_payment.amount_pay AS payment, GL_AP_pay" & _
        "ment.ID_AP_payment, GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl FROM GL_AP_bill_Dtl_Dtl IN" & _
        "NER JOIN GL_AP_payment ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl = GL_AP_payment." & _
        "Id_AP_bill_dtl_dtl INNER JOIN GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dt" & _
        "l = GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN GL_AP_Bill_Head ON GL_AP_bill_Dtl.I" & _
        "d_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head WHERE (GL_AP_payment.id_vendor_" & _
        "credit_head IS NULL) AND (GL_AP_payment.id_check IS NULL) AND (GL_AP_Bill_Head.c" & _
        "od_vendor = @ThisVendor) AND (GL_AP_payment.date_prepare = @ThisDate)"
        Me.SqlCommand1.Connection = Me.Cnn
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisVendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10, "date_prepare"))
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "SELECT GL_payment_bill_COA.GL_account, ISNULL(GL_payment_bill_COA.Amount, 0) AS A" & _
        "mount, a.Id_AP_bill_dtl, ISNULL(a.SUmPayment, 0) AS SUmPayment, ISNULL(GL_AP_bil" & _
        "l_Dtl.amount, 0) - ISNULL(GL_AP_bill_Dtl.Discount, 0) AS sumamount, GL_AP_bill_D" & _
        "tl.Discount FROM GL_payment_bill_COA INNER JOIN (SELECT SUM(GL_AP_payment.amount" & _
        "_pay) AS SUmPayment, GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl FROM GL_AP_bill_Dtl_Dtl I" & _
        "NNER JOIN GL_AP_payment ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl = GL_AP_payment" & _
        ".Id_AP_bill_dtl_dtl INNER JOIN GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_d" & _
        "tl = GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN GL_AP_Bill_Head ON GL_AP_bill_Dtl." & _
        "Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head WHERE (GL_AP_payment.id_vendor" & _
        "_credit_head IS NULL) AND (GL_AP_payment.id_check IS NULL) AND NOT (GL_AP_bill_D" & _
        "tl_Dtl.Id_AP_bill_dtl IS NULL) AND (GL_AP_Bill_Head.cod_vendor = @ThisVendor) AN" & _
        "D (GL_AP_payment.date_prepare = @ThisDate) GROUP BY GL_AP_bill_Dtl_Dtl.Id_AP_bil" & _
        "l_dtl) a ON GL_payment_bill_COA.Id_AP_bill_dtl = a.Id_AP_bill_dtl INNER JOIN GL_" & _
        "AP_bill_Dtl ON GL_payment_bill_COA.Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dt" & _
        "l"
        Me.SqlCommand2.Connection = Me.Cnn
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisVendor", System.Data.SqlDbType.NVarChar))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.NVarChar))
        '
        'Da_Ap_Bill_Sum
        '
        Me.Da_Ap_Bill_Sum.SelectCommand = Me.SqlCommand2
        Me.Da_Ap_Bill_Sum.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_AP_payment", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_AP_payment", "ID_AP_payment"), New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl_dtl", "Id_AP_bill_dtl_dtl"), New System.Data.Common.DataColumnMapping("ID_Inv_Receive_product_Ap_Dtl", "ID_Inv_Receive_product_Ap_Dtl"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("amount_pay", "amount_pay"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("date_prepare", "date_prepare"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("radif1", "radif1")})})
        '
        'InvRecevieReturnCreadit
        '
        Me.InvRecevieReturnCreadit.SelectCommand = Me.SqlCommand9
        Me.InvRecevieReturnCreadit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_Receive_Products_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_receive_ref", "id_receive_ref"), New System.Data.Common.DataColumnMapping("date_receive", "date_receive"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("bill_credit", "bill_credit"), New System.Data.Common.DataColumnMapping("bill_receive", "bill_receive"), New System.Data.Common.DataColumnMapping("ap_term", "ap_term"), New System.Data.Common.DataColumnMapping("receipt_bill_date", "receipt_bill_date"), New System.Data.Common.DataColumnMapping("vendor_ref_no", "vendor_ref_no"), New System.Data.Common.DataColumnMapping("due_date", "due_date"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("house_comments", "house_comments"), New System.Data.Common.DataColumnMapping("vend_comments", "vend_comments"), New System.Data.Common.DataColumnMapping("Discount", "Discount"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlCommand9
        '
        Me.SqlCommand9.CommandText = "SELECT ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2) AS QtyCost, inv_tab_type_ite" & _
        "m.GL_account, inv_tab_type_item.cod_item_type, inv_tab_type_item.desc_item_type," & _
        " ROUND(ISNULL(Inv_Receive_product_dtl.qty, 0) * ISNULL(Inv_Receive_product_dtl.c" & _
        "ost, 0), 2) - ISNULL(Inv_Receive_Products_head.Discount, 0) AS sumrec FROM Inv_R" & _
        "eceive_Products_head INNER JOIN Inv_Receive_product_dtl ON Inv_Receive_Products_" & _
        "head.id_receive_ref = Inv_Receive_product_dtl.id_receive_ref INNER JOIN inv_item" & _
        " ON Inv_Receive_product_dtl.item_no = inv_item.item_no INNER JOIN inv_tab_type_i" & _
        "tem ON inv_item.cod_item_type = inv_tab_type_item.cod_item_type INNER JOIN Inv_R" & _
        "eceive_product_Ap_Dtl ON Inv_Receive_Products_head.id_receive_ref = Inv_Receive_" & _
        "product_Ap_Dtl.id_receive_ref INNER JOIN GL_AP_payment ON Inv_Receive_product_Ap" & _
        "_Dtl.ID_Inv_Receive_product_Ap_Dtl = GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl" & _
        " WHERE (Inv_Receive_Products_head.bill_credit = @BillCredit) AND (Inv_Receive_Pr" & _
        "oducts_head.id_GL_journal IS NULL) AND (NOT (GL_AP_payment.ID_Inv_Receive_produc" & _
        "t_Ap_Dtl IS NULL)) AND (GL_AP_payment.id_check IS NULL) AND (GL_AP_payment.id_ve" & _
        "ndor_credit_head IS NULL) AND (GL_AP_payment.date_prepare = @ThisDate) AND (Inv_" & _
        "Receive_Products_head.cod_vendor = @ThisVendor)"
        Me.SqlCommand9.Connection = Me.Cnn
        Me.SqlCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BillCredit", System.Data.SqlDbType.VarChar, 1, "bill_credit"))
        Me.SqlCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10, "date_prepare"))
        Me.SqlCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisVendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        '
        'Daservice_out_purchases
        '
        Me.Daservice_out_purchases.SelectCommand = Me.SqlCommand3
        Me.Daservice_out_purchases.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_AP_payment", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_AP_payment", "ID_AP_payment"), New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl_dtl", "Id_AP_bill_dtl_dtl"), New System.Data.Common.DataColumnMapping("ID_Inv_Receive_product_Ap_Dtl", "ID_Inv_Receive_product_Ap_Dtl"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("amount_pay", "amount_pay"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("date_prepare", "date_prepare"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("radif1", "radif1")})})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT GL_AP_payment.date_prepare, SUM(ISNULL(GL_AP_payment.amount_pay, 0)) AS Pa" & _
        "yment FROM service_out_purchases INNER JOIN GL_AP_payment ON service_out_purchas" & _
        "es.id_service_center = GL_AP_payment.id_service_center AND service_out_purchases" & _
        ".radif = GL_AP_payment.radif WHERE (GL_AP_payment.id_vendor_credit_head IS NULL)" & _
        " AND (GL_AP_payment.id_check IS NULL) AND (service_out_purchases.cod_vendor = @T" & _
        "hisVendor) AND (service_out_purchases.PaidFlag = 0) GROUP BY GL_AP_payment.date_" & _
        "prepare HAVING (GL_AP_payment.date_prepare = @ThisDate)"
        Me.SqlCommand3.Connection = Me.Cnn
        Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisVendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10, "date_prepare"))
        '
        'Da_InvRecSum
        '
        Me.Da_InvRecSum.SelectCommand = Me.SqlCommand4
        Me.Da_InvRecSum.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_Receive_Products_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_receive_ref", "id_receive_ref"), New System.Data.Common.DataColumnMapping("date_receive", "date_receive"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("bill_credit", "bill_credit"), New System.Data.Common.DataColumnMapping("bill_receive", "bill_receive"), New System.Data.Common.DataColumnMapping("ap_term", "ap_term"), New System.Data.Common.DataColumnMapping("receipt_bill_date", "receipt_bill_date"), New System.Data.Common.DataColumnMapping("vendor_ref_no", "vendor_ref_no"), New System.Data.Common.DataColumnMapping("due_date", "due_date"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("house_comments", "house_comments"), New System.Data.Common.DataColumnMapping("vend_comments", "vend_comments"), New System.Data.Common.DataColumnMapping("Discount", "Discount"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "SELECT SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)) AS SUMAMOUNTPAY FROM In" & _
        "v_Receive_Products_head INNER JOIN Inv_Receive_product_Ap_Dtl ON Inv_Receive_Pro" & _
        "ducts_head.id_receive_ref = Inv_Receive_product_Ap_Dtl.id_receive_ref INNER JOIN" & _
        " GL_AP_payment ON Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl = GL_" & _
        "AP_payment.ID_Inv_Receive_product_Ap_Dtl WHERE (Inv_Receive_Products_head.bill_c" & _
        "redit = @BillCredit) AND (Inv_Receive_Products_head.id_GL_journal IS NULL) AND (" & _
        "NOT (GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl IS NULL)) AND (GL_AP_payment.id" & _
        "_check IS NULL) AND (GL_AP_payment.id_vendor_credit_head IS NULL) AND (GL_AP_pay" & _
        "ment.date_prepare = @ThisDate) AND (Inv_Receive_Products_head.cod_vendor = @This" & _
        "Vendor)"
        Me.SqlCommand4.Connection = Me.Cnn
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@BillCredit", System.Data.SqlDbType.VarChar, 1, "bill_credit"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisDate", System.Data.SqlDbType.VarChar, 10, "date_prepare"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ThisVendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        '
        'DAPrint
        '
        Me.DAPrint.SelectCommand = Me.SqlSelectCommand6
        Me.DAPrint.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_vendor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("desc_vendor", "desc_vendor"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("www", "www"), New System.Data.Common.DataColumnMapping("contact1", "contact1"), New System.Data.Common.DataColumnMapping("contact2", "contact2"), New System.Data.Common.DataColumnMapping("federal_tax_id", "federal_tax_id"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("ap_terms", "ap_terms"), New System.Data.Common.DataColumnMapping("vendor_type", "vendor_type"), New System.Data.Common.DataColumnMapping("class_vendor", "class_vendor"), New System.Data.Common.DataColumnMapping("buyer_id", "buyer_id"), New System.Data.Common.DataColumnMapping("vendor_since", "vendor_since"), New System.Data.Common.DataColumnMapping("f_1099", "f_1099"), New System.Data.Common.DataColumnMapping("on_hold", "on_hold"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("credit_limited", "credit_limited"), New System.Data.Common.DataColumnMapping("remit_to_company", "remit_to_company"), New System.Data.Common.DataColumnMapping("remit_to_address", "remit_to_address"), New System.Data.Common.DataColumnMapping("remit_to_zipcode", "remit_to_zipcode")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT bank_check.id_check, bank_check.no_of_check, bank_check.date_of_check, ban" & _
        "k_check.amount_check, inv_vendor.desc_vendor, GL_AP_payment.amount_pay AS amount" & _
        ", GL_AP_payment.date_prepare AS dte, GL_AP_payment.id_service_center, GL_AP_paym" & _
        "ent.ID_Inv_Receive_product_Ap_Dtl, GL_AP_payment.Id_AP_bill_dtl_dtl FROM GL_AP_p" & _
        "ayment INNER JOIN inv_vendor INNER JOIN bank_check ON inv_vendor.cod_vendor = ba" & _
        "nk_check.cod_vendor ON GL_AP_payment.id_check = bank_check.id_check WHERE (bank_" & _
        "check.id_check = @id_check) GROUP BY bank_check.id_check, bank_check.no_of_check" & _
        ", bank_check.date_of_check, bank_check.amount_check, inv_vendor.desc_vendor, GL_" & _
        "AP_payment.amount_pay, GL_AP_payment.date_prepare, GL_AP_payment.id_service_cent" & _
        "er, GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl, GL_AP_payment.Id_AP_bill_dtl_dt" & _
        "l"
        Me.SqlSelectCommand6.Connection = Me.Cnn
        Me.SqlSelectCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_check", System.Data.SqlDbType.Int, 4, "id_check"))
        '
        'DaPrintEmplyee2
        '
        Me.DaPrintEmplyee2.SelectCommand = Me.SqlCommand5
        Me.DaPrintEmplyee2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_vendor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("desc_vendor", "desc_vendor"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("www", "www"), New System.Data.Common.DataColumnMapping("contact1", "contact1"), New System.Data.Common.DataColumnMapping("contact2", "contact2"), New System.Data.Common.DataColumnMapping("federal_tax_id", "federal_tax_id"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("ap_terms", "ap_terms"), New System.Data.Common.DataColumnMapping("vendor_type", "vendor_type"), New System.Data.Common.DataColumnMapping("class_vendor", "class_vendor"), New System.Data.Common.DataColumnMapping("buyer_id", "buyer_id"), New System.Data.Common.DataColumnMapping("vendor_since", "vendor_since"), New System.Data.Common.DataColumnMapping("f_1099", "f_1099"), New System.Data.Common.DataColumnMapping("on_hold", "on_hold"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("credit_limited", "credit_limited"), New System.Data.Common.DataColumnMapping("remit_to_company", "remit_to_company"), New System.Data.Common.DataColumnMapping("remit_to_address", "remit_to_address"), New System.Data.Common.DataColumnMapping("remit_to_zipcode", "remit_to_zipcode")})})
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "SELECT pay_deductin_main_dtl.amount_deduction_employee, pay_deductin_main_dtl.ded" & _
        "uction_type, CASE pay_deductin_main_dtl.deduction_type WHEN '01' THEN pay_tab_lo" & _
        "an_main.loan_desc WHEN '02' THEN pay_tab_saving_main.saving_desc WHEN '03' THEN " & _
        "'Advance' WHEN '04' THEN 'Garnishment' WHEN '05' THEN employee_deduction.deducti" & _
        "on_desc WHEN '06' THEN 'Federal tax' WHEN '07' THEN 'Social security' WHEN '08' " & _
        "THEN 'Medicare Tax' WHEN '09' THEN 'State Tax' WHEN '10' THEN 'unemployment_tax'" & _
        " ELSE '' END AS DESCription FROM pay_deduction_employee RIGHT OUTER JOIN pay_loa" & _
        "n_dtl RIGHT OUTER JOIN pay_main_employee INNER JOIN pay_deductin_main_dtl ON pay" & _
        "_main_employee.id_pay_period = pay_deductin_main_dtl.id_pay_period ON pay_loan_d" & _
        "tl.id_deduction = pay_deductin_main_dtl.id_deduction LEFT OUTER JOIN pay_tab_loa" & _
        "n_main ON pay_loan_dtl.loan_cod = pay_tab_loan_main.loan_cod LEFT OUTER JOIN pay" & _
        "_tab_saving_main INNER JOIN pay_saving_dtl ON pay_tab_saving_main.saving_cod = p" & _
        "ay_saving_dtl.saving_cod ON pay_deductin_main_dtl.id_deduction = pay_saving_dtl." & _
        "id_deduction ON pay_deduction_employee.id_deduction = pay_deductin_main_dtl.id_d" & _
        "eduction LEFT OUTER JOIN employee_deduction ON pay_deduction_employee.deduction_" & _
        "cod = employee_deduction.deduction_cod WHERE (pay_main_employee.id_check = @id_c" & _
        "heck) AND (pay_deductin_main_dtl.amount_deduction_employee > 0)"
        Me.SqlCommand5.Connection = Me.Cnn
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_check", System.Data.SqlDbType.Int, 4, "id_check"))
        '
        'FrmCheckScreen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(627, 563)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmCheckScreen"
        Me.Text = "Check"
        Me.Panel4.ResumeLayout(False)
        Me.PnlSearch.ResumeLayout(False)
        CType(Me.DsFrmCheckScreen1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GbTYpecheck.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Dim ClsCheck1 As ClsCheck
    Dim WithEvents ClsGlAccount1 As ClsGlAccount

    Dim RowNoToAdd As Integer = 8
    Dim BeforeCel As Integer = -1
    Dim BeforeRow As Integer = -1
    Dim BeforeRowEx As GridEXRow = Nothing
    Dim WithEvents MyFrm1 As UCGl_Account.FrmSearchGlAccount
    Dim id_check As Decimal = 0
    Public LoadThis As Decimal = 0
    Dim MyDsCheckPrint As New DataSet
    Dim ToTwips As Decimal = 56.7
    Dim RptCheque1 As RepCheckPrint
    Dim RptCheque2 As RepCheckPrint2
    Dim WithEvents FrmCheckPreparedVendor1 As FrmCheckPreparedVendor
    Dim WithEvents FrmSearchCheck1 As FrmSearchCheckScreen
    Dim max As Integer = 10
    Public Event AfterSaveAnEmployee(ByVal ThisIdCheck As Int64)
    Enum LevelCheck
        OrdinaryCheck = 0
        PaymentCheck = 1
        EmployeeCheck = 2
    End Enum
    Dim LevelCheck1 As LevelCheck = LevelCheck.OrdinaryCheck
    Private Sub FrmCheck_Screen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cnn.ConnectionString = PConnectionString
            CmdGeneral.Connection = Cnn
            Call FixthisDatabase()
            ThisFormStatus = MainModule.WorkStates.Cancel
            ClsCheck1 = New ClsCheck
            ClsGlAccount1 = New ClsGlAccount
            Cmbcheckstatus.SelectedIndex = 0
            ClsCheck1.Connection = Cnn
            ClsGlAccount1.Connection = Cnn
            DaBanks.Fill(DsFrmCheckScreen1)
            If DsFrmCheckScreen1.bas_banks.Rows.Count <= 0 Then
                MsgFar("There is No Bank Row In Database File")
            End If
            'Try
            '    CmbBankAccount.SelectedIndex = 0
            'Catch ex As Exception
            'End Try

            'Dim d As Integer = ClsCheck1.FindDefaultBank
            'If d <> 0 Then
            '    CmbBankAccount.SelectedValue = d
            'End If
            'If Not CmbBankAccount.SelectedValue Is Nothing Then
            '    TxtNo_Of_Check.Text = ClsCheck1.LastNoCheck(CmbBankAccount.SelectedValue)
            'End If
            Call EnableDisableField(False)
            If LoadThis = 0 Then
                Call PFirstRecord(False)
                CalculateBalance()
            Else
                Call LoadIt(LoadThis)
                CalculateBalance()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub LoadIt(ByVal ThisRefNo As String)
        'DsFrmReceiveReturnProduct1.Clear()
        Call ClearAllField()
        If ThisRefNo <> "" Then
            Dabank_check.SelectCommand.Parameters("@id_check").Value = ThisRefNo
            Dabank_check.Fill(DsFrmCheckScreen1.bank_check)
            Try
                Dabank_check_dtl.SelectCommand.Parameters("@id_check").Value = ThisRefNo
                Dabank_check_dtl.Fill(DsFrmCheckScreen1.bank_check_dtl)
            Catch ex As Exception
            End Try
            ThisFormStatus = MainModule.WorkStates.Cancel
            Call FillDataInScreen()
            CalculateBalance()
        End If
    End Sub
    Private Sub FillDataInScreen()
        With DsFrmCheckScreen1.bank_check
            If .Rows.Count > 0 Then
                TxtRef.Text = .Rows(0).Item("id_check") & ""
                Txtaddress_payee.Text = .Rows(0).Item("address_payee") & ""
                Txtamount_check.Text = .Rows(0).Item("amount_check")
                If (.Rows(0).Item("Cod_Vendor") & "") <> "" Then
                    Employee_Cod1.EmployeeCod = ""
                    Txtcod_vendor.VendorCod = .Rows(0).Item("Cod_Vendor") & ""
                Else
                    Txtcod_vendor.VendorCod = ""
                    Employee_Cod1.EmployeeCod = .Rows(0).Item("employee_code") & ""
                End If

                '   Employee_Cod1.EmployeeCod = .Rows(0).Item("employee_code") & ""
                If .Rows(0).Item("Cod_Vendor") & "" = "" Then
                    RdEmployee.Checked = True
                    LevelCheck1 = LevelCheck.EmployeeCheck
                Else
                    RdOther.Checked = True
                    LevelCheck1 = LevelCheck.OrdinaryCheck
                End If

                Txtdate_of_check.Text = .Rows(0).Item("date_of_check") & ""
                Txtamount_check.Text = .Rows(0).Item("amount_check")
                TxtEndingBalance.Text = "Not yet"
                Txtmemo_check.Text = .Rows(0).Item("memo_check") & ""
                TxtNo_Of_Check.Text = .Rows(0).Item("No_Of_Check") & ""
                ChkClereadBank.Checked = IIf(.Rows(0).Item("cleared_bank") & "" = "", False, True)
                ChkManualCheck.Checked = .Rows(0).Item("manual_check") & ""
                ChkPrintLater.Checked = .Rows(0).Item("print_later") & ""
                Try
                    Cmbcheckstatus.SelectedIndex = .Rows(0).Item("check_status")
                Catch ex As Exception
                    Cmbcheckstatus.SelectedIndex = 0
                End Try
                id_check = .Rows(0).Item("id_check")
                TxtnvoiceNo.Text = .Rows(0).Item("invoice_no") & ""
                '                BeforeCmbcheckstatus = Val(.Rows(0).Item("check_status") & "")
                Try
                    CmbBankAccount.SelectedValue = .Rows(0).Item("id_bank") & ""
                Catch ex As Exception
                End Try
            End If
        End With

    End Sub
    Private Sub CmbBankAccount_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbBankAccount.SelectedValueChanged
        'Call CalculateBalance()
        If Not CmbBankAccount.SelectedValue Is Nothing Then
            Call CalculateBalance()
            If ThisFormStatus = MainModule.WorkStates.Cancel Or ThisFormStatus = MainModule.WorkStates._ReadOnly Then
                PFirstRecord(False)
            End If

        End If
        ' Call PFirstRecord(False)
    End Sub
#Region "Find Address"
    Private Sub cod_vendo_FindVendorNoRow(ByVal ThisRow As System.Data.DataRow) Handles Txtcod_vendor.FindVendorNoRow
        Txtaddress_payee.Clear()
        Txtaddress_payee.Text = ThisRow("desc_vendor") & "" + vbCrLf + ThisRow("address") & ""
        ZipCode1.ZipCode = ThisRow("zipcode") & ""
        Txtaddress_payee.Text = Txtaddress_payee.Text + vbCrLf + ZipCode1.City & "   " + ZipCode1.State & "   " + ZipCode1.ZipCode
        TxtnvoiceNo.Cod_Vendor = ThisRow("cod_vendor")
        Call InsertVendoreRow(ThisRow("vendor_type"))
        Txtaddress_payee.Refresh()
    End Sub
    Private Sub ZipCode1_FindZipCode() Handles ZipCode1.FindZipCode
        'Txtaddress_payee.Text = Txtaddress_payee.Text + vbCrLf + ZipCode1.City & "   " + ZipCode1.State & "   " + ZipCode1.ZipCode
    End Sub
    Private Sub InsertVendoreRow(ByVal ThisVendoreType As String)
        Dim ds1 As New DataSet
        Try
            If ThisVendoreType.Trim & "" <> "" Then
                Dainv_tab_vendor_type.SelectCommand.Parameters(0).Value = ThisVendoreType
                Dainv_tab_vendor_type.Fill(ds1, "t1")
                If ds1.Tables("t1").Rows.Count > 0 Then
                    If ds1.Tables("t1").Rows(0).Item("GL_expense_account") & "" <> "" Then
                        If DsFrmCheckScreen1.bank_check_dtl.Rows(0).Item("GL_Account") = "" Then
                            DsFrmCheckScreen1.bank_check_dtl.Rows(0).Item("GL_Account") = ds1.Tables("t1").Rows(0).Item("GL_expense_account")
                            ClsGlAccount1.FindDesc(ds1.Tables("t1").Rows(0).Item("GL_expense_account"))
                            DsFrmCheckScreen1.bank_check_dtl.Rows(0).Item("amount") = Txtamount_check.Text
                            'GrdDetail.GetRow.Cells(3).Value = Txtamount_check.Text
                            'GrdDetail.GetRow.Cells(2).Value = ThisRow("Desc_Gl_Account")

                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            '            MsgFar(ex.ToString)
        End Try
    End Sub

#End Region
#Region "Clear Fields"
    Private Sub ClearAllField()
        LblName.Text = ""
        RdOther.Checked = True
        Txtaddress_payee.Clear()
        '        BeforeCmbcheckstatus = -1
        Txtamount_check.Text = ""
        Txtcod_vendor.VendorCod = ""
        Txtdate_of_check.Text = ""
        TxtEndingBalance.Text = "Not yet"
        Txtmemo_check.Text = ""
        TxtNo_Of_Check.Text = ""
        LblError.Text = ""
        Cmbcheckstatus.SelectedIndex = 0
        TxtnvoiceNo.Text = ""
        TxtInvoiceDate.Text = ""
        ChkClereadBank.Checked = False
        ChkPrintLater.Checked = False
        ChkManualCheck.Checked = False
        DsFrmCheckScreen1.bank_check_dtl.Clear()
        DsFrmCheckScreen1.Clear()
        DaBanks.Fill(DsFrmCheckScreen1)
        TxtRef.Clear()
    End Sub

#End Region
#Region "EnableDisable"
    Private Sub EnableDisableSave()
        Dim RowDetails As DataRow() = DsFrmCheckScreen1.bank_check_dtl.Select("trim(gl_account) <> ''")
        If Not CmbBankAccount.SelectedValue Is Nothing And BtnNew.Enabled = False And RowDetails.Length > 0 Then
            Dim sumgrd As Decimal = Math.Round(SumGrdDetail(), 2)
            If sumgrd = CDec(Val(Txtamount_check.Text & "")) Or (sumgrd = 0 And Val(Txtamount_check.Text) = 0) Then
                BtnSave.Enabled = True
                BtnPreview.Enabled = True
                BtnPrint.Enabled = True

                LblError.Text = ""
            Else
                BtnSave.Enabled = False
                BtnPreview.Enabled = False
                BtnPrint.Enabled = False
                LblError.Text = "Check amount not equal the distribution amount"
            End If
        Else
            BtnSave.Enabled = False
        End If
    End Sub

    Private Sub EnableDisableField(ByVal InStatus As Boolean)
        CmbBankAccount.Enabled = True
        '        GrdDetail.Enabled = InStatus
        If InStatus Then
            GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True
        Else
            GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        End If
        Txtaddress_payee.Enabled = InStatus
        Txtamount_check.Enabled = InStatus
        'If RdEmployee.Checked = True Then
        '    Employee_Cod1.Visible = True
        '    If ThisFormStatus = MainModule.WorkStates.AddNew Or ThisFormStatus = MainModule.WorkStates.Edit Then
        '        Employee_Cod1.Enabled = True
        '    End If
        '    Txtcod_vendor.Visible = False
        '    Txtcod_vendor.Enabled = False
        '    LblName.Visible = True
        'Else
        '    Employee_Cod1.Visible = False
        '    Employee_Cod1.Enabled = False
        '    Txtcod_vendor.Visible = True
        '    LblName.Visible = False
        '    If ThisFormStatus = MainModule.WorkStates.AddNew Or ThisFormStatus = MainModule.WorkStates.Edit Then
        '        Txtcod_vendor.Enabled = True
        '    End If
        'End If

        If RdEmployee.Checked = True Then
            Employee_Cod1.Visible = True
            Employee_Cod1.Enabled = InStatus
            Txtcod_vendor.Visible = False 'Not InStatus
            Txtcod_vendor.Enabled = False 'Not InStatus
        Else
            Employee_Cod1.Visible = False 'Not InStatus
            Employee_Cod1.Enabled = False 'Not InStatus
            Txtcod_vendor.Visible = True
            Txtcod_vendor.Enabled = InStatus

        End If
        GbTYpecheck.Enabled = InStatus
        'Txtcod_vendor.Enabled = InStatus
        Txtdate_of_check.Enabled = InStatus
        TxtEndingBalance.Enabled = InStatus
        Txtmemo_check.Enabled = InStatus
        TxtNo_Of_Check.Enabled = InStatus
        TxtRef.Enabled = InStatus
        Cmbcheckstatus.Enabled = InStatus
        ChkManualCheck.Enabled = InStatus
        ChkPrintLater.Enabled = InStatus
        TxtnvoiceNo.Enabled = InStatus
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
                'BtnPreview.Enabled = False
                'BtnPrint.Enabled = False
            Case MainModule.WorkStates._ReadOnly
                If TxtRef.Text.Trim.Length > 0 Then
                    BtnFirst.Enabled = True
                    BtnPrev.Enabled = True
                    BtnNext.Enabled = True
                    BtnLast.Enabled = True
                    BtnEdit.Enabled = True
                    BtnDelete.Enabled = True
                    BtnFind.Enabled = True
                    BtnPreview.Enabled = True
                    BtnPrint.Enabled = True
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
            LevelCheck1 = LevelCheck.OrdinaryCheck
            ThisFormStatus = MainModule.WorkStates.AddNew
            Call EnableDisableField(True)
            Call EnableDisableBtn()
            Call ClearAllField()
            TxtRef.Text = ClsCheck1.MakeNewRefCod()
            'TxtNo_Of_Check.Text = ClsCheck1.LastNoCheck(CmbBankAccount.SelectedValue)
            Txtdate_of_check.Text = Format(Now.Date, PubDateFormat)

            Call AddEmptyRecordInDetail()
            CmbBankAccount.Focus()
            Dim d As Integer = ClsCheck1.FindDefaultBank
            If d <> 0 Then
                CmbBankAccount.SelectedValue = d
            End If
            TxtNo_Of_Check.Text = ClsCheck1.LastNoCheck(CmbBankAccount.SelectedValue)
        End If
    End Sub
    Function Psave(Optional ByVal ThisCmbBankAccount As Int64 = 0, Optional ByVal showmassage As Boolean = True) As Boolean
        If ThisCmbBankAccount = 0 Then
            If ChckNoRepeat() = False Then
                Psave = False
                Exit Function
            End If
        End If
        Dim Dr As DataRow
        Dim flg As Boolean = False
        Try
            If DsFrmCheckScreen1.bank_check.Rows.Count <= 0 Then
                Dr = DsFrmCheckScreen1.bank_check.NewRow()
                Dr("id_check") = TxtRef.Text.Trim
                flg = True
            Else
                Dr = DsFrmCheckScreen1.bank_check.Rows(0)
            End If
            Dr("id_bank") = IIf(ThisCmbBankAccount <> 0, ThisCmbBankAccount, CmbBankAccount.SelectedValue)
            Dr("no_of_check") = TxtNo_Of_Check.Text.Trim
            Dr("date_of_check") = Txtdate_of_check.Text.Trim
            Dr("amount_check") = Txtamount_check.Text
            If RdEmployee.Checked = True Then
                Dr("cod_vendor") = System.DBNull.Value
                Dr("Employee_code") = Employee_Cod1.cod_Employee.Trim
            Else
                Dr("cod_vendor") = Txtcod_vendor.VendorCod.Trim
                Dr("Employee_code") = System.DBNull.Value
            End If
            'Dr("cod_vendor") = IIf(Txtcod_vendor.VendorCod.Trim <> "", Txtcod_vendor.VendorCod.Trim, System.DBNull.Value)
            'Dr("Employee_code") = IIf(Employee_Cod1.cod_Employee.Trim <> "", Employee_Cod1.cod_Employee.Trim, System.DBNull.Value)
            Dr("address_payee") = Txtaddress_payee.Text.Trim
            Dr("memo_check") = Txtmemo_check.Text.Trim & "" 'TxtRef.Text.Trim
            Dr("invoice_no") = TxtnvoiceNo.Text  'IIf(Txtcod_vendor.VendorCod.Trim <> "", TxtnvoiceNo.Text, System.DBNull.Value)
            'Dr("invoice_date") = TxtInvoiceDate.Text & ""
            Dr("manual_check") = ChkManualCheck.Checked
            Dr("Print_later") = ChkPrintLater.Checked
            Dr("cleared_bank") = ChkClereadBank.Checked
            Dr("check_status") = Cmbcheckstatus.SelectedIndex
            If flg Then
                DsFrmCheckScreen1.bank_check.Addbank_checkRow(Dr)
            End If
            '            #region "delete empty row"
            Dim i As Long
            Dim dr1 As DataRow()
            dr1 = DsFrmCheckScreen1.bank_check_dtl.Select("trim( gl_account) ='' or amount=0 ")
            For i = 0 To dr1.Length - 1
                dr1(i).Delete()
            Next
            Try
                Dabank_check.Update(DsFrmCheckScreen1.bank_check)
                id_check = DsFrmCheckScreen1.bank_check.Rows(0).Item("id_check")
                For i = 0 To DsFrmCheckScreen1.bank_check_dtl.Rows.Count - 1
                    If DsFrmCheckScreen1.bank_check_dtl.Rows(i).RowState <> DataRowState.Deleted Then
                        DsFrmCheckScreen1.bank_check_dtl.Rows(i).Item("id_check") = id_check
                    End If
                Next
                Dabank_check_dtl.Update(DsFrmCheckScreen1.bank_check_dtl)
                '                If RbBill.Checked = True Then

                If Cmbcheckstatus.SelectedIndex = 2 Or Cmbcheckstatus.SelectedIndex = 1 Or Cmbcheckstatus.SelectedIndex = 3 Then
                    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                        CmdGeneral.Connection.Open()
                    End If
                    If Cmbcheckstatus.SelectedIndex = 2 Then
                        CmdGeneral.CommandText = "update GL_AP_payment set id_check = null  where  id_check=" & id_check
                        Try
                            CmdGeneral.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
                    End If
                    Dim Mid_debit_deposit_head As Decimal = CDec("0" & DsFrmCheckScreen1.bank_check.Rows(0).Item("id_debit_deposit_head"))
                    If Mid_debit_deposit_head <> 0 Then
                        CmdGeneral.CommandText = " delete from  Gl_debit_deposit_head Where  id_debit_deposit_head= " & Mid_debit_deposit_head
                        Try
                            CmdGeneral.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try

                        CmdGeneral.CommandText = " Update gl_ap_payment set id_check= null where id_check= " & TxtRef.Text
                        Try
                            CmdGeneral.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        Finally
                            CmdGeneral.Connection.Close()
                        End Try

                    End If
                End If
                If flg Or Cmbcheckstatus.SelectedIndex = 0 Then
                    Call InsertIntoGlDebitdiposit(ThisCmbBankAccount)
                End If

                If flg Then
                    CmdGeneral.CommandText = "Update bas_Banks set  next_check_no = " & TxtNo_Of_Check.Text & " Where id_bank =" & IIf(ThisCmbBankAccount <> 0, ThisCmbBankAccount, CmbBankAccount.SelectedValue)
                    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                End If


                If CDec("0" & TxtRef.Text) <> id_check And showmassage Then
                    MsgFar("Check Transaction saved as number " & id_check)
                End If
                If LevelCheck1 = LevelCheck.PaymentCheck Then
                    For i = 0 To DsFrmCheckScreen1.GL_AP_payment.Rows.Count - 1
                        CmdGeneral.CommandText = "Update GL_AP_payment set id_check=" & id_check & " , radif1 = 0 " & " Where id_ap_payment=" & DsFrmCheckScreen1.GL_AP_payment.Rows(i).Item("id_ap_payment")
                        CmdGeneral.ExecuteNonQuery()
                    Next
                End If




                '''''If flg Then
                '''''    Call InsertIntoGlDebitdiposit()
                '''''Else
                '''''    If BeforeCmbcheckstatus = 1 Or BeforeCmbcheckstatus = 2 Or BeforeCmbcheckstatus = 3 Then
                '''''        If Cmbcheckstatus.SelectedIndex = 0 Then
                '''''            Call InsertIntoGlDebitdiposit()
                '''''        Else
                '''''            Call UpdateGlDebitDiposit()
                '''''        End If
                '''''    End If
                '''''End If
                '''''CmdGeneral.CommandText = "Update bas_Banks set  next_check_no = " & TxtNo_Of_Check.Text & " Where id_bank =" & CmbBankAccount.SelectedValue
                '''''If CmdGeneral.Connection.State <> ConnectionState.Open Then
                '''''    CmdGeneral.Connection.Open()
                '''''End If
                '''''CmdGeneral.ExecuteNonQuery()
                '''''If CDec("0" & TxtRef.Text) <> id_check Then
                '''''    MsgFar("Check Transaction saved as number " & id_check)
                '''''End If

                '''If Cmbcheckstatus.SelectedIndex = 2 Or Cmbcheckstatus.SelectedIndex = 1 Or Cmbcheckstatus.SelectedIndex = 3 Then
                '''    Dim Mid_debit_deposit_head As Decimal = CDec("0" & DsFrmCheckScreen1.bank_check.Rows(0).Item("id_debit_deposit_head"))
                '''    If Mid_debit_deposit_head <> 0 Then
                '''        CmdGeneral.CommandText = " delete from  Gl_debit_deposit_head Where  id_debit_deposit_head= " & Mid_debit_deposit_head
                '''        CmdGeneral.ExecuteNonQuery()
                '''    End If
                '''End If
                Call DisableForPayment(True)
                Psave = True
                ThisFormStatus = MainModule.WorkStates.Save
                Call CalculateBalance()
                'ThisFormStatus=MainModule.WorkStates.Save
            Catch ex As Exception
                Psave = False
                MsgFar("Error In Update In Check ")
            End Try
        Catch ex As Exception
            Psave = False
            MsgBox(ex.ToString)
        End Try
        ThisFormStatus = MainModule.WorkStates._ReadOnly
        Call EnableDisableField(False)
        Call EnableDisableBtn()
    End Function
    Sub PCancel()
        ThisFormStatus = MainModule.WorkStates._ReadOnly
        If LevelCheck1 = LevelCheck.PaymentCheck Then
            Call DisableForPayment(True)
        End If
        Call EnableDisableField(False)
        Call EnableDisableBtn()
        TxtRef.Text = ClsCheck1.LastRecord(CmbBankAccount.SelectedValue)
        LblError.Text = ""
        LevelCheck1 = LevelCheck.OrdinaryCheck
        Call LoadIt(TxtRef.Text)
    End Sub
    Sub PEdit()
        ' Get A Copy Of Dataset
        If CanEditThis() Then

            LevelCheck1 = LevelCheck.OrdinaryCheck
            Dim AddEmptyRecordToDetailCount As Integer
            Dim IFirstCount As Integer   'Dsfrm..Rows.Count()

            If TxtRef.Text.Trim.Length > 0 Then
                Call LoadIt(TxtRef.Text)
                ThisFormStatus = MainModule.WorkStates.Edit
                Call EnableDisableField(True)
                Call EnableDisableBtn()
                IFirstCount = DsFrmCheckScreen1.bank_check_dtl.Rows.Count()
                For AddEmptyRecordToDetailCount = 1 + IFirstCount To RowNoToAdd + IFirstCount
                    Call AddEmptyRecordToDetail(TxtRef.Text, AddEmptyRecordToDetailCount)
                Next
            End If
            CmbBankAccount.Focus()
        Else
            MsgFar("THis Check is ReadOnly")
        End If

    End Sub
    Sub PDelete()
        'BeforeEditedDataset.Clear()
        ' BeforeEditedDataset = DsFrmReceiveReturnProduct1.Copy()
        If TxtRef.Text.Trim.Length > 0 Then
            MsgFar("You can not delete this check please change check status and save it")
        End If
    End Sub
#End Region
#Region "GrdDetail"
    Sub AddEmptyRecordInDetail()
        Dim IFirstCount As Integer = DsFrmCheckScreen1.bank_check_dtl.Rows.Count()
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
            Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
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
            Dim TXTRef_NoTmp As String = ClsCheck1.PFirstRecord(CmbBankAccount.SelectedValue)
            If TXTRef_NoTmp = TxtRef.Text And TxtRef.Text.Trim & "" <> "" Then
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
                Dim TXTRef_NoTmp As String = ClsCheck1.LastRecord(CmbBankAccount.SelectedValue)
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
                Dim TXTRef_NoTmp As String = ClsCheck1.Pprevious(TxtRef.Text.Trim, CmbBankAccount.SelectedValue)
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
                Dim TXTRef_NoTmp As String = ClsCheck1.PNext(TxtRef.Text, CmbBankAccount.SelectedValue)
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
    Private Sub AllTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtaddress_payee.TextChanged, Txtamount_check.TextChanged, Txtcod_vendor.TextChanged, Txtdate_of_check.TextChanged, TxtInvoiceDate.TextChanged, Txtmemo_check.TextChanged, TxtNo_Of_Check.TextChanged, TxtRef.TextChanged
        TxtNumberString.Text = NumToString_Dollar(Txtamount_check.Text)
        EnableDisableSave()
    End Sub
#End Region
    Private Sub AddEmptyRecordToDetail(ByVal ThisId As String, ByVal ThisRadif As Integer)
        Dim dr As DataRow
        dr = DsFrmCheckScreen1.bank_check_dtl.NewRow
        dr("id_check") = ThisId
        dr("radif") = ThisRadif
        dr("gl_account") = ""
        dr("amount") = 0
        dr("memo_dtl") = ""
        DsFrmCheckScreen1.bank_check_dtl.Rows.Add(dr)
    End Sub
    Private Sub VendoreOfInvoice1_FindThisRefNoForThisVendore(ByVal ThisRow As System.Data.DataRow) Handles TxtnvoiceNo.FindThisRefNoForThisVendore
        TxtInvoiceDate.Text = ThisRow("receipt_bill_date")
    End Sub

    Private Sub MyFrm1_GlAccountFind(ByVal ThisRow As System.Data.DataRow) Handles MyFrm1.GlAccountFind
        If LevelCheck1 <> LevelCheck.PaymentCheck Then
            GrdDetail.GetRow.Cells(1).Value = ThisRow("Gl_Account")
            GrdDetail.GetRow.Cells(2).Value = ThisRow("Desc_Gl_Account")
            Dim mand As Decimal = CalculateMandeh()
            If mand > 0 Then
                GrdDetail.GetRow.Cells(3).Value = CalculateMandeh()
            End If
            GrdDetail.UpdateData()
            EnableDisableSave()
        End If
    End Sub

    Private Sub ClsGlAccount1_FindGlAccuntRow(ByVal ThisRow As System.Data.DataRow) Handles ClsGlAccount1.FindGlAccuntRow
        If LevelCheck1 <> LevelCheck.PaymentCheck Then
            If Trim(GrdDetail.GetRow.Cells(1).Value) & "" <> "" Then
                GrdDetail.GetRow.Cells(2).Value = ThisRow("Desc_Gl_Account")
            End If
            Dim mand As Decimal = CalculateMandeh()
            If mand > 0 Then
                GrdDetail.GetRow.Cells(3).Value = CalculateMandeh()
            End If
            GrdDetail.UpdateData()
            EnableDisableSave()
        End If
    End Sub
    Private Sub ClsGlAccount1_NotFindGlaAccount() Handles ClsGlAccount1.NotFindGlaAccount
        GrdDetail.GetRow.Cells(2).Value = ""
        GrdDetail.GetRow.Cells(1).Value = ""
        EnableDisableSave()
        ' GrdDetail.selero()
    End Sub
#Region "Gl Debit Deposit"
    Private Sub InsertIntoGlDebitdiposit(Optional ByVal ThisCmbBankAccount As Int64 = 0)
        '        CmdGeneral.Connection = Cnn
        Dim Mid_debit_deposit_head As Decimal = 0
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            CmdGeneral.CommandText = "select id_debit_deposit_head from GL_debit_deposit where id_check = " & Qt(TxtRef.Text)
            Dim id_debit_deposit_head As Decimal = CDec("0" & CmdGeneral.ExecuteScalar)
            If id_debit_deposit_head > 0 Then
                CmdGeneral.CommandText = " Delete From Gl_debit_deposit  WHERE id_debit_deposit_head =" & id_debit_deposit_head
                CmdGeneral.ExecuteNonQuery()

                CmdGeneral.CommandText = " Delete From Gl_debit_deposit_head  wHERE id_debit_deposit_head=" & id_debit_deposit_head
                CmdGeneral.ExecuteNonQuery()
            End If
            CmdGeneral.CommandText = " Insert into Gl_debit_deposit_head(id_bank,date_doc,memo)  values( " & Qt(IIf(ThisCmbBankAccount <> 0, ThisCmbBankAccount, CmbBankAccount.SelectedValue)) & " , " & Qt(Txtdate_of_check.Text.Trim) & " ," & Qt(Txtmemo_check.Text.Trim) & " );Select id_debit_deposit_head from GL_debit_deposit_head where id_debit_deposit_head=@@IDENTITY"
            Mid_debit_deposit_head = CmdGeneral.ExecuteScalar()
            CmdGeneral.CommandText = " Insert into GL_debit_deposit(type_transaction,debit_amount,id_check,id_debit_deposit_head)  values( '2'," & Txtamount_check.Text & " , " & id_check & " , " & Mid_debit_deposit_head & "  ) "
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " Update bank_check set id_debit_deposit_head =  " & Mid_debit_deposit_head & " Where id_check = " & id_check
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = " Update bas_banks set next_check_no= " & TxtNo_Of_Check.Text & " Where id_bank= " & IIf(ThisCmbBankAccount <> 0, ThisCmbBankAccount, CmbBankAccount.SelectedValue)
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
            Mid_debit_deposit_head = CDec("0" & DsFrmCheckScreen1.bank_check.Rows(0).Item("id_debit_deposit_head"))
            If Mid_debit_deposit_head <> 0 Then
                CmdGeneral.CommandText = " Update Gl_debit_deposit_head set id_bank  =" & Qt(CmbBankAccount.SelectedValue) & " ,  date_doc = " & Txtdate_of_check.Text.Trim & "  Where  id_debit_deposit_head= " & Mid_debit_deposit_head
                CmdGeneral.ExecuteNonQuery()
                CmdGeneral.CommandText = " update GL_debit_deposit set debit_amount = " & Txtamount_check.Text & " Where  id_check= " & id_check
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
        If Cmbcheckstatus.SelectedIndex = 2 Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            Dim Mid_debit_deposit_head As Decimal = 0
            Try
                Mid_debit_deposit_head = DsFrmCheckScreen1.bank_check.Rows(0).Item("id_debit_deposit_head")
                CmdGeneral.CommandText = " update bank_check set id_debit_deposit_head = NULL "
                CmdGeneral.ExecuteNonQuery()
                CmdGeneral.CommandText = " delete From GL_debit_deposit_head Where  id_debit_deposit_head= " & Mid_debit_deposit_head
                'CmdGeneral.CommandText = " delete From GL_debit_deposit_head Where  id_debit_deposit_head= " & Mid_debit_deposit_head
                CmdGeneral.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                CmdGeneral.Connection.Close()
            End Try
            'CmdGeneral.ExecuteNonQuery()
        End If
    End Sub
#End Region
    Function SumGrdDetail() As Decimal
        SumGrdDetail = CDec("0" & DsFrmCheckScreen1.bank_check_dtl.Compute("sum(amount)", "trim(GL_Account) <> ''"))
    End Function
    Private Sub Cmbcheckstatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmbcheckstatus.SelectedIndexChanged
        Call EnableDisableSave()
    End Sub
    Private Sub Cmbcheckstatus_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmbcheckstatus.SelectedValueChanged
        Call EnableDisableSave()
    End Sub
    Private Function CalculateMandeh() As Decimal
        CalculateMandeh = 0
        Dim i As Integer
        For i = 0 To DsFrmCheckScreen1.bank_check_dtl.Rows.Count - 1
            CalculateMandeh = CDec("0" & DsFrmCheckScreen1.bank_check_dtl.Rows(i).Item("amount")) + CalculateMandeh
        Next
        CalculateMandeh = CDec("0" & Txtamount_check.Text) - CalculateMandeh
        If CalculateMandeh < 0 Then
            CalculateMandeh = 0
        End If
    End Function
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Call DeleteThisRow()
    End Sub
    Sub DeleteThisRow()
        Dim i As Integer, j As Integer
        Dim Currentrow As Short = CInt("0" & GrdDetail.GetRow.Cells(5).Value)
        For i = Currentrow - 1 To DsFrmCheckScreen1.bank_check_dtl.Rows.Count - 2
            With DsFrmCheckScreen1.bank_check_dtl.Rows(i)
                For j = 2 To 5
                    .Item(j) = DsFrmCheckScreen1.bank_check_dtl.Rows(i + 1).Item(j)
                Next
            End With
        Next
        With DsFrmCheckScreen1.bank_check_dtl.Rows(DsFrmCheckScreen1.bank_check_dtl.Rows.Count - 1)
            .Item(2) = ""
            .Item(3) = 0
            .Item(4) = ""
            .Item(5) = ""
        End With
        GrdDetail.Refetch()
        GrdDetail.Row = Currentrow - 1
        EnableDisableSave()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Call InsertThisRow()
    End Sub
    Sub InsertThisRow()
        Dim i As Integer, j As Integer
        Dim Currentrow As Short = CInt("0" & GrdDetail.GetRow.Cells(5).Value)
        For i = DsFrmCheckScreen1.bank_check_dtl.Rows.Count - 2 To Currentrow - 1 Step -1
            If i - 1 >= 0 Then
                With DsFrmCheckScreen1.bank_check_dtl.Rows(i)
                    For j = 2 To 5
                        .Item(j) = DsFrmCheckScreen1.bank_check_dtl.Rows(i - 1).Item(j)
                    Next
                End With
            End If
        Next
        With DsFrmCheckScreen1.bank_check_dtl.Rows(Currentrow - 1)
            .Item(2) = ""
            .Item(3) = 0
            .Item(4) = ""
            .Item(5) = ""
        End With
        EnableDisableSave()
        GrdDetail.Row = Currentrow - 1

    End Sub
    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        If (ThisFormStatus = MainModule.WorkStates.Cancel Or ThisFormStatus = MainModule.WorkStates._ReadOnly) And BtnSave.Enabled = False Then
            Select Case LevelCheck1
                Case LevelCheck.EmployeeCheck
                    Call PrintItEmployee()
                Case Else
                    Call PrintIt()
            End Select
        End If
    End Sub
    Sub PrintIt(Optional ByVal PreviewOrPrint As Short = 1)
        If ThisFormStatus = MainModule.WorkStates.Edit And BtnSave.Enabled = False Then
            MsgFar(" This Check Is Not Balance ! ")
            Exit Sub
        End If
        If ThisFormStatus = MainModule.WorkStates.Edit And BtnSave.Enabled = True Then
            Call Psave()
        End If
        RptCheque1 = New RepCheckPrint
        If RetrieveCheckInformation() = True Then
            Dim margins As CrystalDecisions.Shared.PageMargins
            margins = RptCheque1.PrintOptions.PageMargins
            margins.bottomMargin = 1400
            margins.leftMargin = 0
            margins.rightMargin = 0
            margins.topMargin = 0
            '--------------------------------------------------
            ' Apply the page margins.
            RptCheque1.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
            RptCheque1.PrintOptions.ApplyPageMargins(margins)
            RptCheque1.SetParameterValue("CheckNo1", " Check No : " & TxtNo_Of_Check.Text.Trim)

            RptCheque1.SetParameterValue("CheckDate1", Txtdate_of_check.Text & "")
            RptCheque1.SetParameterValue("CheckAmount1", Txtamount_check.Text.Trim)
            RptCheque1.SetParameterValue("CheckAmountString1", TxtNumberString.Text.Trim)
            RptCheque1.SetParameterValue("Address1", Txtaddress_payee.Text.Trim)
            '-------------
            RptCheque1.SetParameterValue("Payee2", "Payee" & vbCrLf & Txtaddress_payee.Lines(0).Trim)  ' TxtNumberString.Lines(0).Trim)
            RptCheque1.SetParameterValue("CheckDate2", "Check Date " & vbCrLf & Txtdate_of_check.Text & "")
            RptCheque1.SetParameterValue("CheckNo2", " Check No  " & vbCrLf & TxtNo_Of_Check.Text.Trim)
            RptCheque1.SetParameterValue("CheckAmount2", " Check Amount " & vbCrLf & Txtamount_check.Text.Trim)
            '-------------
            RptCheque1.SetParameterValue("RefNo21", "Ref No" & vbCrLf & TxtRef.Text & "")
            RptCheque1.SetParameterValue("Amount21", "Amount" & vbCrLf & Txtamount_check.Text.Trim & "")

            '-------------------
            RptCheque1.SetParameterValue("Payee3", "Payee" & vbCrLf & Txtaddress_payee.Lines(0).Trim)   ' TxtNumberString.Lines(0).Trim)
            RptCheque1.SetParameterValue("CheckDate3", "Check Date " & vbCrLf & Txtdate_of_check.Text & "")
            RptCheque1.SetParameterValue("CheckNo3", " Check No  " & vbCrLf & TxtNo_Of_Check.Text.Trim)
            RptCheque1.SetParameterValue("CheckAmount3", " Check Amount " & vbCrLf & Txtamount_check.Text.Trim)
            '-------------------------
            RptCheque1.SetParameterValue("RefNo31", "Ref No" & vbCrLf & TxtRef.Text & "")
            RptCheque1.SetParameterValue("Amount31", "Amount" & vbCrLf & Txtamount_check.Text.Trim & "")
            '-------------------------
            Call InitAll("CheckNo1")
            Call InitAll("CheckDate1")
            Call InitAll("CheckAmount1")
            Call InitAll("CheckAmountString1")
            Call InitAll("Address1")
            Call InitAll("Payee2")
            Call InitAll("CheckDate2")
            Call InitAll("CheckNo2")
            Call InitAll("CheckAmount2")
            Call InitAll("RefNo21")
            Call InitAll("Amount21")

            Call InitAll("Payee3")
            Call InitAll("CheckDate3")
            Call InitAll("CheckNo3")
            Call InitAll("CheckAmount3")
            Call InitAll("RefNo31")
            Call InitAll("Amount31")
            'Call InitAll("left11")
            '     RptCheque1.SetParameterValue("CheckNo2", " Check No : " & TxtNo_Of_Check.Text.Trim)
            Call setsubreport()
            Dim max1 As Integer = 10
            Dim max2 As Integer = 10
            max1 = IIf(DsFrmCheckScreen1.PrintDtl.Rows.Count > max, max, DsFrmCheckScreen1.PrintDtl.Rows.Count)

            If DsFrmCheckScreen1.PrintDtl.Rows.Count - max1 > 10 Then
                max2 = 10
            Else
                max2 = 0
                If DsFrmCheckScreen1.PrintDtl.Rows.Count - max1 > 0 Then
                    max2 = DsFrmCheckScreen1.PrintDtl.Rows.Count - max1
                End If
            End If
            Call InitAllAll()
            RptCheque1.SetDataSource(DsFrmCheckScreen1.PrintDtl)
            Dim j As Integer = (DsFrmCheckScreen1.PrintDtl.Rows.Count - 1) / 2
            Dim i As Integer = 0
            Dim k As Integer = 0
            Dim left1(max1) As String
            Dim left2(max)
            DsFrmCheckScreen1.PrintDtl.DefaultView.Sort = "VendorRefno"
            If DsFrmCheckScreen1.PrintDtl.Rows.Count > 0 Then
                'left1(1) = "Vendor Ref     Date     Amount Paid"
                For i = 0 To max1 - 1
                    With DsFrmCheckScreen1.PrintDtl.Rows(i)
                        Dim a As Integer = Len(Trim(.Item("VendorRefno") & ""))
                        ' changed by ketabi
                        If a > 10 Then
                            a = 10
                        End If
                        ''''''''''''''''''''''''''''''
                        If i = 0 Then
                            left1(i + 1) = "Vendor Ref       Date      Amount Paid" & vbCrLf & "" & vbCrLf & Space(10 - a) & Trim(.Item("VendorRefno") & "") & "    " & .Item("dte") & "    " & Math.Round(Val(.Item("amount") & ""), 2)
                        Else
                            left1(i + 1) = Space(10 - a) & Trim(.Item("VendorRefno") & "") & "    " & .Item("dte") & "    " & Math.Round(Val(.Item("amount") & ""), 2)
                        End If

                        RptCheque1.SetParameterValue("Left" & Trim(i + 1 & "") & "1", left1(i + 1) & "")
                    End With
                Next
            End If
            For i = max1 To max - 1
                RptCheque1.SetParameterValue("Left" & Trim(i + 1 & "") & "1", "")
            Next


            If max2 > 0 Then
                'left1(1) = "Vendor Ref     Date     Amount Paid"
                For i = 0 To max2 - 1
                    With DsFrmCheckScreen1.PrintDtl.Rows(i + max1)
                        Dim a As Integer = Len(Trim(.Item("VendorRefno") & ""))
                        ' changed by ketabi
                        If a > 10 Then
                            a = 10
                        End If
                        ''''''''''''''''''''''''''''''
                        If i = 0 Then
                            left2(i + 1) = "Vendor Ref       Date      Amount Paid" & vbCrLf & "" & vbCrLf & Space(10 - a) & Trim(.Item("VendorRefno") & "") & "    " & .Item("dte") & "    " & Math.Round(Val(.Item("amount") & ""), 2)
                        Else
                            left2(i + 1) = Space(10 - a) & Trim(.Item("VendorRefno") & "") & "    " & .Item("dte") & "    " & Math.Round(Val(.Item("amount") & ""), 2)
                        End If

                        RptCheque1.SetParameterValue("Left" & Trim(i + 1 & "") & "2", left2(i + 1) & "")
                    End With
                Next
            End If
            For i = max2 To max - 1
                RptCheque1.SetParameterValue("Left" & Trim(i + 1 & "") & "2", "")
            Next
            If LevelCheck1 = LevelCheck.EmployeeCheck Then
                RptCheque1.SetParameterValue("Employee", 1)
            Else
                RptCheque1.SetParameterValue("Employee", 0)
            End If
            Dim J1 As Integer = 0
            If DsFrmCheckScreen1.PrintDtl.Rows.Count >= 20 Then
                J1 = 20
            Else
                J1 = DsFrmCheckScreen1.PrintDtl.Rows.Count - 1
            End If

            If J1 < DsFrmCheckScreen1.PrintDtl.Rows.Count - 1 Then
                For i = J1 To DsFrmCheckScreen1.PrintDtl.Rows.Count - 1
                    DsFrmCheckScreen1.PrintDtl.Rows(i).Delete()
                Next
            End If
            DsFrmCheckScreen1.PrintDtl.AcceptChanges()



            Dim Prn As New FrmRepView
            If PreviewOrPrint = 2 Then
                Prn.CrViewer.ReportSource = RptCheque1
                Prn.ShowDialog()
            Else
                Prn.CrViewer.ReportSource = RptCheque1
                RptCheque1.PrintToPrinter(1, True, 1, 1)
            End If
        Else
            MsgFar("There is No Definition For This Store For Printing check !")
        End If
    End Sub

    Sub InitAll(ByVal Thisitem As String)
        With MyDsCheckPrint.Tables("t1").Rows(0)

            RptCheque1.Section2.ReportObjects.Item(Thisitem).Left = .Item(Thisitem & "Left") * ToTwips
            RptCheque1.Section2.ReportObjects.Item(Thisitem).Top = .Item(Thisitem & "Top") * ToTwips
            If Thisitem.Trim.ToUpper <> "left11".ToUpper Then
                RptCheque1.Section2.ReportObjects.Item(Thisitem).Height = .Item(Thisitem & "Height") * ToTwips
                RptCheque1.Section2.ReportObjects.Item(Thisitem).Width = .Item(Thisitem & "Width") * ToTwips
            End If
        End With
    End Sub
    Public Function RetrieveCheckInformation() As Boolean
        MyDsCheckPrint.Clear()
        Dim CnnMDB As New System.Data.OleDb.OleDbConnection(PConnectionStringForSetupTables)
        Dim CmdGeneralForMDB As New System.Data.OleDb.OleDbCommand
        Dim DaOle As New System.Data.OleDb.OleDbDataAdapter
        CmdGeneralForMDB.Connection = CnnMDB

        DaOle.SelectCommand = CmdGeneralForMDB
        CmdGeneralForMDB.CommandText = "SELECT * from  CheckSetupTable " 'Where StoreNo = " & Qt(PubStoreNO)
        'DaOle.SelectCommand.Connection = CnnMDB
        Try
            DaOle.Fill(MyDsCheckPrint, "t1")
            If MyDsCheckPrint.Tables("t1").Rows.Count > 0 Then
                RetrieveCheckInformation = True
            Else
                RetrieveCheckInformation = False
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function
    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        If (ThisFormStatus = MainModule.WorkStates.Cancel Or ThisFormStatus = MainModule.WorkStates._ReadOnly) And BtnSave.Enabled = False Then
            Select Case LevelCheck1
                Case LevelCheck.EmployeeCheck
                    Call PrintItEmployee(2)
                Case Else
                    Call PrintIt(2)
            End Select
        Else
            MsgFar("please save before print")
        End If

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Application.DoEvents()
    End Sub

    Private Sub Dabank_check_RowUpdating(ByVal sender As Object, ByVal e As System.Data.SqlClient.SqlRowUpdatingEventArgs) Handles Dabank_check.RowUpdating
        Application.DoEvents()
    End Sub

    Sub CalculateBalance()
        If ThisFormStatus = MainModule.WorkStates.AddNew Then
            TxtNo_Of_Check.Text = ClsCheck1.LastNoCheck(CmbBankAccount.SelectedValue)
        End If
        CmdGeneral.CommandText = "SELECT  SUM(GL_debit_deposit.deposit_amount - GL_debit_deposit.debit_amount) AS Sum1 "
        CmdGeneral.CommandText = CmdGeneral.CommandText + " FROM    GL_debit_deposit_head INNER JOIN "
        CmdGeneral.CommandText = CmdGeneral.CommandText + " GL_debit_deposit ON GL_debit_deposit_head.id_debit_deposit_head = GL_debit_deposit.id_debit_deposit_head "
        CmdGeneral.CommandText = CmdGeneral.CommandText + " WHERE     (GL_debit_deposit_head.id_bank =" & CmbBankAccount.SelectedValue & ")"
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            TxtEndingBalance.Text = Val(CmdGeneral.ExecuteScalar() & "")
        Catch ex As Exception
            TxtEndingBalance.Text = 0
        Finally
            CmdGeneral.Connection.Close()
        End Try

    End Sub
    Sub FixthisDatabase()
        CmdGeneral.CommandText = "alter table bank_check_dtl add StoreNo char(2) "
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        CmdGeneral.CommandText = "update  bank_check_dtl  set StoreNo = " & Qt(PubStoreNO) & " Where  StoreNo is null"
        Try
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception

        Finally
            CmdGeneral.Connection.Close()
        End Try

    End Sub
    Private Sub CmdPrepared_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrepared.Click
        FrmCheckPreparedVendor1 = New FrmCheckPreparedVendor
        FrmCheckPreparedVendor1.ShowDialog()
    End Sub
    Private Sub FrmCheckPreparedVendor1_FindPaymentCodDate(ByVal ThisDate As String, ByVal ThidVendorCod As String, ByVal SumCheck As Decimal) Handles FrmCheckPreparedVendor1.FindPaymentCodDate
        Call LoadChekFor(ThidVendorCod, ThisDate, SumCheck)
    End Sub
    Sub LoadChekFor(ByVal ThidVendorCod As String, ByVal ThisDate As String, ByVal SumCheck As Decimal)
        Call PCancel()
        Call Paddnew()
        LevelCheck1 = LevelCheck.PaymentCheck
        DsFrmCheckScreen1.bank_check_dtl.Clear()
        Dim dstmp As New DataSet
        Txtcod_vendor.Text = ThidVendorCod
        Cmbcheckstatus.SelectedIndex = 0
        Txtamount_check.Text = SumCheck
        DaPayment.SelectCommand.Parameters("@ThisVendor").Value = ThidVendorCod
        DaPayment.SelectCommand.Parameters("@ThisDate").Value = ThisDate
        'DaPayment.Fill(dstmp, "t1")
        Dim jk As Integer = 0
        'For jk = 0 To dstmp.Tables("t1").Rows.Count - 1
        '    Dim dr As DataRow
        '    dr = DsFrmCheckScreen1.bank_check_dtl.NewRow
        '    dr("id_check") = TxtRef.Text
        '    dr("radif") = jk + 1
        '    dr("gl_account") = ""
        '    dr("amount") = dstmp.Tables("t1").Rows(jk).Item("payment")
        '    dr("memo_dtl") = ""
        '    dr("id_ap_payment") = dstmp.Tables("t1").Rows(jk).Item("id_ap_payment")
        '    DsFrmCheckScreen1.bank_check_dtl.Rows.Add(dr)
        'Next
        Dim ClsGlAccount2 As New ClsGlAccount
        ClsGlAccount2.Connection = Cnn

        Da_Ap_Bill_Sum.SelectCommand.Parameters("@ThisVendor").Value = ThidVendorCod
        Da_Ap_Bill_Sum.SelectCommand.Parameters("@ThisDate").Value = ThisDate
        Da_Ap_Bill_Sum.Fill(dstmp, "t1")
        Dim RADIF As Int64 = 0

        For jk = 0 To dstmp.Tables("t1").Rows.Count - 1
            Dim dr As DataRow
            dr = DsFrmCheckScreen1.bank_check_dtl.NewRow
            dr("id_check") = TxtRef.Text
            dr("radif") = jk + 1
            dr("gl_account") = dstmp.Tables("t1").Rows(jk).Item("Gl_account")
            ClsGlAccount2.Cod_Gl = dstmp.Tables("t1").Rows(jk).Item("Gl_account")
            ClsGlAccount2.FindDesc(ClsGlAccount2.Cod_Gl)
            dr("desc_GL_account") = ClsGlAccount2.Desc_Gl
            dr("amount") = ((dstmp.Tables("t1").Rows(jk).Item("amount") * dstmp.Tables("t1").Rows(jk).Item("sumpayment")) / dstmp.Tables("t1").Rows(jk).Item("sumamount")) ' + ((dstmp.Tables("t1").Rows(jk).Item("discount") * dstmp.Tables("t1").Rows(jk).Item("sumpayment")) / dstmp.Tables("t1").Rows(jk).Item("sumamount"))

            dr("memo_dtl") = ""  'dstmp.Tables("t1").Rows(jk).Item("amount") & " * " & dstmp.Tables("t1").Rows(jk).Item("sumpayment") & " / " & dstmp.Tables("t1").Rows(jk).Item("sumamount")
            ' dr("id_ap_payment") = dstmp.Tables("t1").Rows(jk).Item("id_ap_payment")
            DsFrmCheckScreen1.bank_check_dtl.Rows.Add(dr)
            RADIF = jk + 1
        Next

        Try
            InvRecevieReturnCreadit.SelectCommand.Parameters("@ThisVendor").Value = ThidVendorCod
            InvRecevieReturnCreadit.SelectCommand.Parameters("@ThisDate").Value = ThisDate
            InvRecevieReturnCreadit.SelectCommand.Parameters("@BillCredit").Value = "1"
            InvRecevieReturnCreadit.Fill(dstmp, "t2")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Dim sumsumcre As Decimal = 0

        If dstmp.Tables("t2").Rows.Count > 0 Then
            sumsumcre = dstmp.Tables("t2").Compute("sum(sumrec)", "sumrec <> 0")
        End If

        Da_InvRecSum.SelectCommand.Parameters("@ThisVendor").Value = ThidVendorCod
        Da_InvRecSum.SelectCommand.Parameters("@ThisDate").Value = ThisDate
        Da_InvRecSum.SelectCommand.Parameters("@BillCredit").Value = "1"
        Da_InvRecSum.Fill(dstmp, "s1")
        Dim SumQtyCost As Decimal = 0
        If dstmp.Tables("s1").Rows.Count > 0 Then
            SumQtyCost = Val(dstmp.Tables("s1").Rows(0).Item(0) & "")
        End If

        Dim radif2 As Int64 = 0
        For jk = 0 To dstmp.Tables("t2").Rows.Count - 1
            Dim dr As DataRow
            dr = DsFrmCheckScreen1.bank_check_dtl.NewRow
            dr("id_check") = TxtRef.Text
            dr("radif") = RADIF + jk + 1
            dr("gl_account") = dstmp.Tables("t2").Rows(jk).Item("Gl_account")
            ClsGlAccount2.Cod_Gl = dstmp.Tables("t2").Rows(jk).Item("Gl_account")
            ClsGlAccount2.FindDesc(ClsGlAccount2.Cod_Gl)
            dr("desc_GL_account") = ClsGlAccount2.Desc_Gl


            dr("amount") = (dstmp.Tables("t2").Rows(jk).Item("sumrec") * SumQtyCost / sumsumcre)
            'Math.Round((dstmp.Tables("t2").Rows(jk).Item("sumrec") * dstmp.Tables("t2").Rows(jk).Item("QtyCost")) / sumsumcre, 3)
            dr("memo_dtl") = ""
            ' dr("id_ap_payment") = dstmp.Tables("t1").Rows(jk).Item("id_ap_payment")
            DsFrmCheckScreen1.bank_check_dtl.Rows.Add(dr)
            radif2 = jk + 1
        Next


        CmdGeneral.CommandText = "select GL_account_sales_income from inv_tab_type_item where cod_item_type='07'"
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim gl1 As String = ""
        Try
            gl1 = CmdGeneral.ExecuteScalar & ""
        Catch ex As Exception
            gl1 = "Not Find"
        Finally
            CmdGeneral.Connection.Close()
        End Try

        Daservice_out_purchases.SelectCommand.Parameters("@ThisVendor").Value = ThidVendorCod
        Daservice_out_purchases.SelectCommand.Parameters("@ThisDate").Value = ThisDate
        Daservice_out_purchases.Fill(dstmp, "t3")

        For jk = 0 To dstmp.Tables("t3").Rows.Count - 1
            Dim dr As DataRow
            dr = DsFrmCheckScreen1.bank_check_dtl.NewRow
            dr("id_check") = TxtRef.Text
            dr("radif") = RADIF + radif2 + jk + 1
            dr("gl_account") = gl1          'dstmp.Tables("t3").Rows(jk).Item("Gl_account")
            ClsGlAccount2.Cod_Gl = gl1
            ClsGlAccount2.FindDesc(gl1)
            dr("desc_GL_account") = ClsGlAccount2.Desc_Gl & ""
            dr("amount") = Math.Round(Val("" & dstmp.Tables("t3").Rows(jk).Item("Payment")), 2)
            dr("memo_dtl") = ""
            ' dr("id_ap_payment") = dstmp.Tables("t1").Rows(jk).Item("id_ap_payment")
            DsFrmCheckScreen1.bank_check_dtl.Rows.Add(dr)
        Next
        DsFrmCheckScreen1.GL_AP_payment.Clear()
        DaPayment.Fill(DsFrmCheckScreen1.GL_AP_payment)
        Call DisableForPayment(False)
        Dim i As Int64 = 0
        GrdDetail.Focus()
        GrdDetail.Refetch()

        Call EnableDisableSave()
    End Sub
    Sub DisableForPayment(ByVal What As Boolean)
        Txtcod_vendor.Enabled = What
        Txtamount_check.Enabled = What
        Cmbcheckstatus.Enabled = What
        Panel2.Enabled = What
        GrdDetail.RootTable.Columns(3).Selectable = What
    End Sub

    Private Sub Cnn_InfoMessage(ByVal sender As System.Object, ByVal e As System.Data.SqlClient.SqlInfoMessageEventArgs) Handles Cnn.InfoMessage

    End Sub

    Private Sub BtnPrintAtt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintAtt.Click
        Dim Rpt As New RepCheckAttach
        Dim prn As New FrmRepView
        Dim i As Int64 = 0
        DsFrmCheckScreen1.PrintDtl.Clear()
        DAPrint.SelectCommand.Parameters("@id_check").Value = id_check
        ' For i = 0 To 20
        DAPrint.Fill(DsFrmCheckScreen1.PrintDtl)
        'Next i
        '     Next i
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim c As String = ""

        For i = 0 To DsFrmCheckScreen1.PrintDtl.Rows.Count - 1
            With DsFrmCheckScreen1.PrintDtl.Rows(i)
                c = Trim(.Item("id_service_center")).ToUpper & ""
                If c <> "NULL" And c <> "" Then
                    CmdGeneral.CommandText = "Select top 1 VendorRefno from  View_AllPreAndPaidService_out_purchase  where id_service_center=" & Qt(.Item("id_service_center") & "")
                    .Item("VendorRefno") = CmdGeneral.ExecuteScalar & ""
                End If

                c = Trim(.Item("ID_Inv_Receive_product_Ap_Dtl") & "").ToUpper
                If c <> "NULL" And c <> "" Then
                    CmdGeneral.CommandText = "Select top 1 VendorRefno from  View_AllPreAndPaidReceive_product_ap_Dtl  where ID_Inv_Receive_product_Ap_Dtl=" & Qt(.Item("ID_Inv_Receive_product_Ap_Dtl") & "")
                    .Item("VendorRefno") = CmdGeneral.ExecuteScalar & ""
                End If

                c = Trim(.Item("Id_AP_bill_dtl_dtl") & "").ToUpper

                If c <> "NULL" And c <> "" Then
                    CmdGeneral.CommandText = "Select top 1 VendorRefno from  View_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl  where Id_AP_bill_dtl_dtl=" & Qt(.Item("Id_AP_bill_dtl_dtl") & "")
                    .Item("VendorRefno") = CmdGeneral.ExecuteScalar & ""
                End If
            End With
        Next

        Rpt.SetParameterValue("pardate", Format(Now(), "MM/dd/yyyy"))
        Rpt.SetParameterValue("partime", Format(Now(), "Short Time"))

        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        Rpt.SetParameterValue("ParCompany", OleDbReaderForStore.Item("STORENAME") & "")

        Rpt.SetDataSource(DsFrmCheckScreen1.PrintDtl)
        prn.CrViewer.ReportSource = Rpt
        prn.Show()
    End Sub
    Sub setsubreport()
        Dim i As Integer = 0
        DsFrmCheckScreen1.PrintDtl.Clear()
        DAPrint.SelectCommand.Parameters("@id_check").Value = id_check
        DAPrint.Fill(DsFrmCheckScreen1.PrintDtl)
        'DAPrint.Fill(DsFrmCheckScreen1.PrintDtl)
        'DAPrint.Fill(DsFrmCheckScreen1.PrintDtl)
        'DAPrint.Fill(DsFrmCheckScreen1.PrintDtl)
        'DAPrint.Fill(DsFrmCheckScreen1.PrintDtl)
        'DAPrint.Fill(DsFrmCheckScreen1.PrintDtl)


        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim c As String = ""
        Dim j As Integer = 0
        If DsFrmCheckScreen1.PrintDtl.Rows.Count >= 20 Then
            j = 20
        Else
            j = DsFrmCheckScreen1.PrintDtl.Rows.Count - 1
        End If

        For i = 0 To j
            With DsFrmCheckScreen1.PrintDtl.Rows(i)
                c = Trim(.Item("id_service_center")).ToUpper & ""
                If c <> "NULL" And c <> "" Then
                    CmdGeneral.CommandText = "Select top 1 VendorRefno from  View_AllPreAndPaidService_out_purchase  where id_service_center=" & Qt(.Item("id_service_center") & "")
                    .Item("VendorRefno") = CmdGeneral.ExecuteScalar & ""
                End If

                c = Trim(.Item("ID_Inv_Receive_product_Ap_Dtl") & "").ToUpper
                If c <> "NULL" And c <> "" Then
                    CmdGeneral.CommandText = "Select top 1 VendorRefno from  View_AllPreAndPaidReceive_product_ap_Dtl  where ID_Inv_Receive_product_Ap_Dtl=" & Qt(.Item("ID_Inv_Receive_product_Ap_Dtl") & "")
                    .Item("VendorRefno") = CmdGeneral.ExecuteScalar & ""
                End If

                c = Trim(.Item("Id_AP_bill_dtl_dtl") & "").ToUpper

                If c <> "NULL" And c <> "" Then
                    CmdGeneral.CommandText = "Select top 1 VendorRefno from  View_AllPreAndPaidGl_Ap_Bill_Dtl_Dtl  where Id_AP_bill_dtl_dtl=" & Qt(.Item("Id_AP_bill_dtl_dtl") & "")
                    .Item("VendorRefno") = CmdGeneral.ExecuteScalar & ""
                End If
            End With
        Next
        If j < DsFrmCheckScreen1.PrintDtl.Rows.Count - 1 Then
            For i = j To DsFrmCheckScreen1.PrintDtl.Rows.Count - 1
                DsFrmCheckScreen1.PrintDtl.Rows(i).Delete()
            Next
        End If
        DsFrmCheckScreen1.PrintDtl.AcceptChanges()
        'delete
        'Dim i As Integer = 0
        'For i = 0 To 20
        '    DAPrint.SelectCommand.Parameters("@id_check").Value = id_check
        '    DAPrint.Fill(DsFrmCheckScreen1.PrintDtl)
        'Next


    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        FrmSearchCheck1 = New FrmSearchCheckScreen
        FrmSearchCheck1.ShowDialog()
    End Sub
    Private Sub FrmSearchCheck1_FindThisCeck(ByVal idcheck As Decimal) Handles FrmSearchCheck1.FindThisCeck
        Call LoadIt(idcheck)
    End Sub
    Function ChckNoRepeat() As Boolean
        If Not CmbBankAccount.SelectedValue Is Nothing Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            Try
                CmdGeneral.CommandText = "Select top 1 no_of_check from bank_check where no_of_check=" & Qt(TxtNo_Of_Check.Text.Trim) & " and id_bank=" & CmbBankAccount.SelectedValue

                If CmdGeneral.ExecuteScalar() & "" <> "" And ThisFormStatus <> MainModule.WorkStates.Edit Then
                    MsgFar("Check No is already used")
                    ChckNoRepeat = False
                Else
                    ChckNoRepeat = True
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                CmdGeneral.Connection.Close()
            End Try
        Else
            ChckNoRepeat = True
        End If
    End Function
    Private Sub TxtNo_Of_Check_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNo_Of_Check.LostFocus
        ChckNoRepeat()
    End Sub

    Sub InitAllAll()
        Dim i As Integer = 1

        Dim Height1 As Decimal = 0
        Dim wid1 As Decimal = 0
        With MyDsCheckPrint.Tables("t1").Rows(0)
            Dim thisitem As String = "left11"
            For i = 1 To max
                If i <> 1 Then
                    Height1 = Height1 + RptCheque1.Section2.ReportObjects.Item(thisitem).Height
                Else
                    Height1 = 0
                End If
                thisitem = "left" & Trim(i & "") & "1"
                RptCheque1.Section2.ReportObjects.Item(thisitem).Left = .Item("Left1" & "1" & "left") * ToTwips
                RptCheque1.Section2.ReportObjects.Item(thisitem).Top = (.Item("Left1" & "1" & "Top") * ToTwips) + Height1 + 1
            Next

            thisitem = "left11"
            Height1 = 0
            wid1 = RptCheque1.Section2.ReportObjects.Item(thisitem).Width + 1
            For i = 1 To max
                If i <> 1 Then
                    Height1 = Height1 + RptCheque1.Section2.ReportObjects.Item(thisitem).Height
                Else
                    Height1 = 0

                End If
                thisitem = "left" & Trim(i & "") & "2"
                RptCheque1.Section2.ReportObjects.Item(thisitem).Left = (.Item("Left1" & "1" & "left") * ToTwips) + wid1
                RptCheque1.Section2.ReportObjects.Item(thisitem).Top = (.Item("Left1" & "1" & "Top") * ToTwips) + Height1 + 1
            Next
        End With
    End Sub

    Private Sub RbOther_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdOther.CheckedChanged

        If RdEmployee.Checked = True Then
            Employee_Cod1.Visible = True
            If ThisFormStatus = MainModule.WorkStates.AddNew Or ThisFormStatus = MainModule.WorkStates.Edit Then
                Employee_Cod1.Enabled = True
                ChkClereadBank.Checked = False
            End If
            Txtcod_vendor.Visible = False
            Txtcod_vendor.Enabled = False
            LblName.Visible = True
            ChkClereadBank.Checked = True
        Else
            Employee_Cod1.Visible = False
            Employee_Cod1.Enabled = False
            Txtcod_vendor.Visible = True
            LblName.Visible = False
            If ThisFormStatus = MainModule.WorkStates.AddNew Or ThisFormStatus = MainModule.WorkStates.Edit Then
                Txtcod_vendor.Enabled = True
            End If

        End If
    End Sub
    Private Sub Employee_Cod1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Employee_Cod1.TextChanged
        Txtcod_vendor.Text = ""
    End Sub

    Private Sub Txtcod_vendor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcod_vendor.Load
        Employee_Cod1.Text = ""
    End Sub

    Private Sub Employee_Cod1_FindEmployeeCod() Handles Employee_Cod1.FindEmployeeCod
        Call FindNameEmp(Employee_Cod1.Text)
        'Call AfterSaveOrCancel()
    End Sub
    Function FindNameEmp(ByVal ThisEmployee_Code As String) As Boolean
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        Try
            If ThisEmployee_Code.Trim.Length = 0 Then
                Exit Function
            End If
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT * from Employee where Employee_Code=" & Qt(ThisEmployee_Code)
            Try
                SQLReader = CmdGeneral.ExecuteReader
                If SQLReader.HasRows Then
                    SQLReader.Read()
                    LblName.Text = Trim(SQLReader.Item("f_name") & "") + " " + Trim(SQLReader.Item("m_name") & "") + " " + Trim(SQLReader.Item("l_name") & "")
                    Txtaddress_payee.Text = LblName.Text + vbCrLf + Trim(SQLReader.Item("address") & "")
                    ZipCode1.ZipCode = Trim(SQLReader.Item("zipcode") & "") & ""
                    Txtaddress_payee.Text = Txtaddress_payee.Text + vbCrLf + ZipCode1.City & "   " + ZipCode1.State & "   " + ZipCode1.ZipCode
                    'ChkTechnecian.Checked = SQLReader.Item("technecian")
                    'ChkTerminated.Checked = SQLReader.Item("Terminated")
                End If
            Catch ex As Exception
            End Try
        Catch ex As Exception

        End Try
        Try
            SQLReader.Close()
        Catch ex1 As Exception
        End Try
    End Function
    Public Function PrintThis(ByVal Id_Check1 As Int64) As String
        If Cnn.State <> ConnectionState.Open Then
            Cnn.ConnectionString = PConnectionString
        End If
        id_check = Id_Check1
        Dabank_check.SelectCommand.Parameters(0).Value = Id_Check1
        Dim newds2 As New DataSet
        Dabank_check.Fill(newds2, "t1")
        Dim id_bank As Int64 = 0
        Dim date_of_check As String = ""
        Dim employee_code As String = ""
        Dim amount_check As Decimal = 0
        If newds2.Tables("t1").Rows.Count > 0 Then
            id_bank = newds2.Tables("t1").Rows(0).Item("id_bank")
            date_of_check = newds2.Tables("t1").Rows(0).Item("date_of_check")
            employee_code = newds2.Tables("t1").Rows(0).Item("employee_code")
            amount_check = newds2.Tables("t1").Rows(0).Item("amount_check")
            TxtNo_Of_Check.Text = newds2.Tables("t1").Rows(0).Item("no_of_check")
        Else
            PrintThis = "check not found"
            Exit Function
        End If

        PrintThis = ""
        CmdGeneral.Connection = Cnn
        ClsCheck1 = New ClsCheck
        ClsGlAccount1 = New ClsGlAccount
        ClsCheck1.Connection = Cnn
        ClsGlAccount1.Connection = Cnn
        DsFrmCheckScreen1.Clear()
        CmbBankAccount.Enabled = True
        DaBanks.Fill(DsFrmCheckScreen1.bas_banks)
        Call EnableDisableField(False)
        'Call PFirstRecord(False)
        Try
            Dim i As Int64 = 0
            CmbBankAccount.SelectedValue = id_bank
            'Call Paddnew()
            CmbBankAccount.Enabled = True
            CmbBankAccount.Focus()
            CmbBankAccount.SelectedValue = id_bank
            RdEmployee.Checked = True
            'ClsCheck1.LastNoCheck(id_bank)
            Txtdate_of_check.Text = date_of_check
            Employee_Cod1.EmployeeCod = employee_code
            Txtamount_check.Text = amount_check
            Call FindNameEmp(Employee_Cod1.Text)
            DsFrmCheckScreen1.bank_check_dtl.Clear()
            TxtRef.Text = ClsCheck1.MakeNewRefCod()
            TxtRef.Text = id_check 'CInt(Val(TxtNo_Of_Check.Text & ""))
            Dabank_check_dtl.SelectCommand.Parameters("@id_check").Value = Id_Check1
            Dabank_check_dtl.Fill(DsFrmCheckScreen1.bank_check_dtl)
            Try
                'Call Psave(id_bank)
                Call LoadIt(TxtRef.Text)
                Call PrintItEmployee()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Catch ex As Exception
            PrintThis = "Error Data Saving For Check "
            MsgBox(ex.ToString)
        End Try
        ClsCheck1 = Nothing
        ClsGlAccount1 = Nothing
    End Function
    Public Function SaveAndPrint(ByVal id_bank As Int16, ByVal date_of_check As String, ByVal amount_check As Decimal, ByVal employee_code As String, ByVal dt As UcAccount.DSFrmCheckScreen.bank_check_dtlDataTable, ByRef Id_Check As Int64) As String
        If Cnn.State <> ConnectionState.Open Then
            Cnn.ConnectionString = PConnectionString
        End If
        Id_Check = 0
        SaveAndPrint = ""
        '        Dim ClsCheck2 As ClsCheck

        '        Dim ClsGlAccount2 As New ClsGlAccount
        'Cnn.ConnectionString = PConnectionString
        CmdGeneral.Connection = Cnn
        ClsCheck1 = New ClsCheck
        ClsGlAccount1 = New ClsGlAccount
        ClsCheck1.Connection = Cnn
        ClsGlAccount1.Connection = Cnn
        DsFrmCheckScreen1.Clear()
        CmbBankAccount.Enabled = True
        DaBanks.Fill(DsFrmCheckScreen1.bas_banks)
        Call EnableDisableField(False)
        'Call PFirstRecord(False)
        Try
            Dim i As Int64 = 0
            CmbBankAccount.SelectedValue = id_bank
            'Call Paddnew()
            CmbBankAccount.Enabled = True
            CmbBankAccount.Focus()
            CmbBankAccount.SelectedValue = id_bank
            RdEmployee.Checked = True
            TxtNo_Of_Check.Text = ClsCheck1.LastNoCheck(id_bank)
            Txtdate_of_check.Text = date_of_check
            Employee_Cod1.EmployeeCod = employee_code
            Txtamount_check.Text = amount_check
            Call FindNameEmp(Employee_Cod1.Text)
            DsFrmCheckScreen1.bank_check_dtl.Clear()
            TxtRef.Text = ClsCheck1.MakeNewRefCod()
            Id_Check = TxtRef.Text 'CInt(Val(TxtNo_Of_Check.Text & ""))
            For i = 0 To dt.Rows.Count - 1
                Dim dr As DataRow
                If Trim(dt.Rows(i).Item("gl_account") & "") <> "" Then
                    dr = DsFrmCheckScreen1.bank_check_dtl.NewRow
                    dr("id_check") = Id_Check
                    dr("radif") = i + 1
                    dr("gl_account") = dt.Rows(i).Item("gl_account")
                    dr("amount") = dt.Rows(i).Item("amount")
                    dr("memo_dtl") = dt.Rows(i).Item("memo_dtl")
                    DsFrmCheckScreen1.bank_check_dtl.Rows.Add(dr)
                End If
            Next
            'Call EnableDisableSave()
            '            If BtnSave.Enabled = True Then
            Try
                BtnSave.Enabled = True
                ThisFormStatus = MainModule.WorkStates.AddNew
                Call Psave(id_bank, False)
                RaiseEvent AfterSaveAnEmployee(Id_Check)
                Call LoadIt(TxtRef.Text)
                Call PrintItEmployee()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            '           Else
            '              SaveAndPrint = "Error Data Saving For Check "
            '         End If

        Catch ex As Exception
            SaveAndPrint = "Error Data Saving For Check "
            MsgBox(ex.ToString)
        End Try
        ClsCheck1 = Nothing
        ClsGlAccount1 = Nothing

    End Function
    Function CanEditThis() As Boolean
        If LevelCheck1 = LevelCheck.EmployeeCheck Then
            CanEditThis = False
        Else
            CanEditThis = True
        End If
    End Function
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DS1 As DSFrmCheckScreen.bank_check_dtlDataTable
        Dim ReturndIdcheck As Int64 = 0
        DS1 = DsFrmCheckScreen1.bank_check_dtl.Copy()
        MsgBox(SaveAndPrint(CmbBankAccount.SelectedValue, Txtdate_of_check.Text, Txtamount_check.Text, Employee_Cod1.cod_Employee, DS1, ReturndIdcheck))
        MsgBox(PrintThis(ReturndIdcheck))

    End Sub

    Sub PrintItEmployee(Optional ByVal PreviewOrPrint As Short = 1)
        If ThisFormStatus = MainModule.WorkStates.Edit And BtnSave.Enabled = False Then
            MsgFar(" This Check Is Not Balance ! ")
            Exit Sub
        End If
        If ThisFormStatus = MainModule.WorkStates.Edit And BtnSave.Enabled = True Then
            Call Psave()
        End If
        RptCheque2 = New RepCheckPrint2
        If RetrieveCheckInformation() = True Then
            Dim margins As CrystalDecisions.Shared.PageMargins
            margins = RptCheque2.PrintOptions.PageMargins
            margins.bottomMargin = 700
            margins.leftMargin = 0
            margins.rightMargin = 0
            margins.topMargin = 0
            '--------------------------------------------------
            ' Apply the page margins.
            RptCheque2.PrintOptions.PaperSize = CrystalDecisions.[Shared].PaperSize.PaperA4
            RptCheque2.PrintOptions.ApplyPageMargins(margins)
            RptCheque2.SetParameterValue("CheckNo1", " Check No : " & TxtNo_Of_Check.Text.Trim)

            RptCheque2.SetParameterValue("CheckDate1", Txtdate_of_check.Text & "")
            RptCheque2.SetParameterValue("CheckAmount1", Txtamount_check.Text.Trim)
            RptCheque2.SetParameterValue("CheckAmountString1", TxtNumberString.Text.Trim)
            RptCheque2.SetParameterValue("Address1", Txtaddress_payee.Text.Trim)
            '-------------
            RptCheque2.SetParameterValue("Payee2", "Payee" & vbCrLf & Txtaddress_payee.Lines(0).Trim)  ' TxtNumberString.Lines(0).Trim)
            RptCheque2.SetParameterValue("CheckDate2", "Check Date " & vbCrLf & Txtdate_of_check.Text & "")
            RptCheque2.SetParameterValue("CheckNo2", " Check No  " & vbCrLf & TxtNo_Of_Check.Text.Trim)
            RptCheque2.SetParameterValue("CheckAmount2", " Check Amount " & vbCrLf & Txtamount_check.Text.Trim)
            '-------------
            RptCheque2.SetParameterValue("RefNo21", "Ref No" & vbCrLf & TxtRef.Text & "")
            RptCheque2.SetParameterValue("Amount21", "Amount" & vbCrLf & Txtamount_check.Text.Trim & "")

            '-------------------
            RptCheque2.SetParameterValue("Payee3", "Payee" & vbCrLf & Txtaddress_payee.Lines(0).Trim)   ' TxtNumberString.Lines(0).Trim)
            RptCheque2.SetParameterValue("CheckDate3", "Check Date " & vbCrLf & Txtdate_of_check.Text & "")
            RptCheque2.SetParameterValue("CheckNo3", " Check No  " & vbCrLf & TxtNo_Of_Check.Text.Trim)
            RptCheque2.SetParameterValue("CheckAmount3", " Check Amount " & vbCrLf & Txtamount_check.Text.Trim)
            '-------------------------
            RptCheque2.SetParameterValue("RefNo31", "Ref No" & vbCrLf & TxtRef.Text & "")
            RptCheque2.SetParameterValue("Amount31", "Amount" & vbCrLf & Txtamount_check.Text.Trim & "")
            '-------------------------
            Call InitAll2("CheckNo1")
            Call InitAll2("CheckDate1")
            Call InitAll2("CheckAmount1")
            Call InitAll2("CheckAmountString1")
            Call InitAll2("Address1")
            Call InitAll2("Payee2")
            Call InitAll2("CheckDate2")
            Call InitAll2("CheckNo2")
            Call InitAll2("CheckAmount2")
            Call InitAll2("RefNo21")
            Call InitAll2("Amount21")

            Call InitAll2("Payee3")
            Call InitAll2("CheckDate3")
            Call InitAll2("CheckNo3")
            Call InitAll2("CheckAmount3")
            Call InitAll2("RefNo31")
            Call InitAll2("Amount31")
            Dim max1 As Integer = 10
            Dim max2 As Integer = 10
            Dim newds As New DataSet
            Dim gross_pay As Decimal = 0
            Dim HW As String = ""
            DaPrintEmplyee2.SelectCommand.Parameters(0).Value = id_check
            DaPrintEmplyee2.Fill(newds, "t1")
            newds.Clear()
            Try
                CmdGeneral.Connection.Open()
                CmdGeneral.CommandText = "SELECT     gross_pay  FROM         pay_main_employee WHERE     id_check = " & id_check
                gross_pay = Math.Round(Val(CmdGeneral.ExecuteScalar & ""), 2)
                CmdGeneral.CommandText = "SELECT     time_work_Hour+':'+time_work_Minute as t  FROM     pay_main_employee WHERE     id_check = " & id_check
                HW = (CmdGeneral.ExecuteScalar & "")

                If gross_pay > 0 Then
                    Dim dr1 As DataRow
                    dr1 = newds.Tables("t1").NewRow  'FrmCheckScreen1.PrintDtl.NewPrintDtlRow
                    dr1("amount_deduction_employee") = gross_pay
                    dr1("deduction_type") = ""
                    dr1("DESCription") = "Gross Pay "
                    newds.Tables("t1").Rows.Add(dr1)

                    RptCheque2.SetParameterValue("Left11", "Gross Pay ")
                    RptCheque2.SetParameterValue("Left12", Math.Round(gross_pay, 2))

                    RptCheque2.SetParameterValue("Left21", "Hours Worked")
                    RptCheque2.SetParameterValue("Left22", HW)
                Else
                    RptCheque2.SetParameterValue("Left11", "")
                    RptCheque2.SetParameterValue("Left12", "0")
                    RptCheque2.SetParameterValue("Left21", "Hours Worked")
                    RptCheque2.SetParameterValue("Left22", "")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                CmdGeneral.Connection.Close()
            End Try
            If gross_pay > 0 Then

            End If
            DaPrintEmplyee2.SelectCommand.Parameters(0).Value = id_check
            DaPrintEmplyee2.Fill(newds, "t1")
            Dim dt1 As DataTable = newds.Tables("t1")
            Dim i As Integer = 0
            'For i = 0 To 20
            '    Dim dr1 As DataRow
            '    dr1 = newds.Tables("t1").NewRow  'FrmCheckScreen1.PrintDtl.NewPrintDtlRow
            '    dr1("amount_deduction_employee") = i * 10
            '    dr1("deduction_type") = i
            '    dr1("DESCription") = "dfsdfsdsdfsdfsd" & i
            '    newds.Tables("t1").Rows.Add(dr1)   '. AddPrintDtlRow(dr1)
            'Next
            max1 = IIf(dt1.Rows.Count > max, max, dt1.Rows.Count)
            If dt1.Rows.Count - max1 > 10 Then
                max2 = 10
            Else
                max2 = 0
                If dt1.Rows.Count - max1 > 0 Then
                    max2 = dt1.Rows.Count - max1
                End If
            End If
            Call InitAllAll2()
            i = 0
            Dim k As Integer = 0
            Dim left1(max1) As String
            Dim left2(max) As String
            If dt1.Rows.Count > 0 Then
                'left1(1) = "Vendor Ref     Date     Amount Paid"
                For i = 2 To max1
                    'With DsFrmCheckScreen1.PrintDtl.Rows(i)
                    RptCheque2.SetParameterValue("Left" & Trim(i + 1 & "") & "1", dt1.Rows(i - 1).Item("DESCription") & "")
                    RptCheque2.SetParameterValue("Left" & Trim(i + 1 & "") & "2", Math.Round(dt1.Rows(i - 1).Item("amount_deduction_employee"), 2) & "")
                    'End With
                Next
            End If
            For i = max1 + 1 To max - 1
                RptCheque2.SetParameterValue("Left" & Trim(i + 1 & "") & "1", "")
                RptCheque2.SetParameterValue("Left" & Trim(i + 1 & "") & "2", "0")
            Next


            If max2 > 0 Then
                For i = 0 To max2 - 1
                    RptCheque2.SetParameterValue("Left" & Trim(i + 1 & "") & "3", dt1.Rows(i).Item("DESCription") & "")
                    RptCheque2.SetParameterValue("Left" & Trim(i + 1 & "") & "4", Math.Round(dt1.Rows(i).Item("amount_deduction_employee"), 2) & "")
                Next
            End If

            For i = max2 To max - 1
                RptCheque2.SetParameterValue("Left" & Trim(i + 1 & "") & "3", "")
                RptCheque2.SetParameterValue("Left" & Trim(i + 1 & "") & "4", "0")
            Next


            If LevelCheck1 = LevelCheck.EmployeeCheck Then
                RptCheque2.SetParameterValue("Employee", 1)
            Else
                RptCheque2.SetParameterValue("Employee", 0)
            End If

            Dim Prn As New FrmRepView
            If PreviewOrPrint = 2 Then
                Prn.CrViewer.ReportSource = RptCheque2
                Prn.ShowDialog()
            Else
                Prn.CrViewer.ReportSource = RptCheque2
                RptCheque2.PrintToPrinter(1, True, 0, 0)
            End If
        Else
            MsgFar("There is No Definition For This Store For Printing check !")
        End If

    End Sub

    Sub InitAll2(ByVal Thisitem As String)
        With MyDsCheckPrint.Tables("t1").Rows(0)

            RptCheque2.Section2.ReportObjects.Item(Thisitem).Left = .Item(Thisitem & "Left") * ToTwips
            RptCheque2.Section2.ReportObjects.Item(Thisitem).Top = .Item(Thisitem & "Top") * ToTwips
            If Thisitem.Trim.ToUpper <> "left11".ToUpper Then
                RptCheque2.Section2.ReportObjects.Item(Thisitem).Height = .Item(Thisitem & "Height") * ToTwips
                RptCheque2.Section2.ReportObjects.Item(Thisitem).Width = .Item(Thisitem & "Width") * ToTwips
            End If
        End With
    End Sub

    Sub InitAllAll2()
        Dim i As Integer = 1
        Dim Height1 As Decimal = 0
        Dim wid1 As Decimal = 0
        With MyDsCheckPrint.Tables("t1").Rows(0)
            Dim thisitem As String = "left11"
            For i = 1 To max
                '                If i <> 1 Then
                Height1 = Height1 + RptCheque2.Section2.ReportObjects.Item(thisitem).Height
                '               Else
                '                  Height1 = 0
                '             End If
                thisitem = "left" & Trim(i & "") & "1"
                RptCheque2.Section2.ReportObjects.Item(thisitem).Left = .Item("Left1" & "1" & "left") * ToTwips
                RptCheque2.Section2.ReportObjects.Item(thisitem).Top = (.Item("Left1" & "1" & "Top") * ToTwips) + Height1 + 1
            Next

            thisitem = "left11"
            Height1 = 0
            wid1 = RptCheque2.Section2.ReportObjects.Item(thisitem).Width + 1
            For i = 1 To max
                '    If i <> 1 Then
                Height1 = Height1 + RptCheque2.Section2.ReportObjects.Item(thisitem).Height
                '   Else
                '      Height1 = 0

                ' End If
                thisitem = "left" & Trim(i & "") & "2"
                RptCheque2.Section2.ReportObjects.Item(thisitem).Left = (.Item("Left1" & "1" & "left") * ToTwips) + wid1
                RptCheque2.Section2.ReportObjects.Item(thisitem).Top = (.Item("Left1" & "1" & "Top") * ToTwips) + Height1 + 10
            Next



            thisitem = "left11"
            Height1 = 0
            wid1 = RptCheque2.Section2.ReportObjects.Item("left11").Width + RptCheque2.Section2.ReportObjects.Item("left12").Width + 1
            For i = 1 To max
                '    If i <> 1 Then
                Height1 = Height1 + RptCheque2.Section2.ReportObjects.Item(thisitem).Height
                '   Else
                '      Height1 = 0

                ' End If
                thisitem = "left" & Trim(i & "") & "3"
                RptCheque2.Section2.ReportObjects.Item(thisitem).Left = (.Item("Left1" & "1" & "left") * ToTwips) + wid1 + 20 * ToTwips
                RptCheque2.Section2.ReportObjects.Item(thisitem).Top = (.Item("Left1" & "1" & "Top") * ToTwips) + Height1 + 10
            Next




            thisitem = "left11"
            Height1 = 0
            wid1 = RptCheque2.Section2.ReportObjects.Item("left11").Width + RptCheque2.Section2.ReportObjects.Item("left12").Width + RptCheque2.Section2.ReportObjects.Item("left13").Width + 1
            For i = 1 To max
                '    If i <> 1 Then
                Height1 = Height1 + RptCheque2.Section2.ReportObjects.Item(thisitem).Height
                '   Else
                '      Height1 = 0

                ' End If
                thisitem = "left" & Trim(i & "") & "4"
                RptCheque2.Section2.ReportObjects.Item(thisitem).Left = (.Item("Left1" & "1" & "left") * ToTwips) + wid1 + 20 * ToTwips
                RptCheque2.Section2.ReportObjects.Item(thisitem).Top = (.Item("Left1" & "1" & "Top") * ToTwips) + Height1 + 10
            Next

        End With
    End Sub

    Private Sub RdEmployee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdEmployee.CheckedChanged

    End Sub

    Private Sub CmbBankAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbBankAccount.SelectedIndexChanged

    End Sub
End Class
