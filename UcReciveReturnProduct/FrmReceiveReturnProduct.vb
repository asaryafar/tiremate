'BillCredit=1 is —”Ìœ
Imports CommonClass
Imports Janus.Windows.GridEX
Public Class FrmReceiveReturnProduct
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
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents BtnFirst As System.Windows.Forms.Button
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnEmail As System.Windows.Forms.Button
    Friend WithEvents BtnFax As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtRef As System.Windows.Forms.TextBox
    Friend WithEvents LblCompanyName As System.Windows.Forms.Label
    Friend WithEvents LblStoreNo As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Vendor_Cod1 As UCVendor.Vendor_Cod
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CommentButton_House As UCCommentButton.CommentButton
    Friend WithEvents BtnCustomerBalance As System.Windows.Forms.Button
    Friend WithEvents BtnCustomerHistory As System.Windows.Forms.Button
    Friend WithEvents BtnCustomerDetail As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LblTax As System.Windows.Forms.Label
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents LblSubtotal As System.Windows.Forms.Label
    Friend WithEvents LblFET As System.Windows.Forms.Label
    Friend WithEvents LblTotalQty As System.Windows.Forms.Label
    Friend WithEvents LblParts As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents DsFrmReceiveReturnProduct1 As UcReceiveReturnProduct.DSFrmReceiveReturnProduct
    Friend WithEvents Txtcontact1 As System.Windows.Forms.TextBox
    Friend WithEvents Txtdesc_vendor As System.Windows.Forms.TextBox
    Friend WithEvents Txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents TxtVendorRefNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtRBDate As CalendarCombo.CalendarCombo
    Friend WithEvents RbBill As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents LblwEIGHT As System.Windows.Forms.Label
    Friend WithEvents ChkBillReceive As System.Windows.Forms.CheckBox
    Friend WithEvents TxtDueDate As CalendarCombo.CalendarCombo
    Friend WithEvents CommentButton_Vendor As UCCommentButton.CommentButton
    Friend WithEvents CmbApTerm As System.Windows.Forms.ComboBox
    Friend WithEvents RbCredit As System.Windows.Forms.RadioButton
    Friend WithEvents DaInv_Receive_Products_head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents PhoneNo1 As UCPhone.PhoneNo
    Friend WithEvents PhoneButton1 As UCPhone.PhoneButton
    Friend WithEvents SelectPo As Janus.Windows.EditControls.UIButton
    Friend WithEvents DaPoDetail As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents LblName As System.Windows.Forms.Label
    Friend WithEvents TxtDiscount As CalcUtils.UcCalcText
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaInv_Receive_Products_Dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Cm1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaPo As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DAGL_TAB_AR_TERM As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents PnlHead As System.Windows.Forms.Panel
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaInv_Receive_product_Ap_Dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaCheckForEdit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DaCheckForEditReturn As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaGl_vendor_credit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents ChkBefPaied As System.Windows.Forms.CheckBox
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents TxtTax As CalcUtils.UcCalcText
    Friend WithEvents CmdItemPrice As Janus.Windows.EditControls.UIButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmReceiveReturnProduct))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PnlHead = New System.Windows.Forms.Panel
        Me.CmdItemPrice = New Janus.Windows.EditControls.UIButton
        Me.Label36 = New System.Windows.Forms.Label
        Me.BtnFirst = New System.Windows.Forms.Button
        Me.Label37 = New System.Windows.Forms.Label
        Me.BtnLast = New System.Windows.Forms.Button
        Me.Label33 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.Label32 = New System.Windows.Forms.Label
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnEmail = New System.Windows.Forms.Button
        Me.BtnFax = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnPreview = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnNew = New System.Windows.Forms.Button
        Me.BtnFind = New System.Windows.Forms.Button
        Me.BtnNext = New System.Windows.Forms.Button
        Me.BtnPrev = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxtDate = New System.Windows.Forms.TextBox
        Me.TxtRef = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LblName = New System.Windows.Forms.Label
        Me.LblCompanyName = New System.Windows.Forms.Label
        Me.LblStoreNo = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.SelectPo = New Janus.Windows.EditControls.UIButton
        Me.PhoneNo1 = New UCPhone.PhoneNo
        Me.BtnCustomerHistory = New System.Windows.Forms.Button
        Me.BtnCustomerDetail = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtZipCode = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Txtaddress = New System.Windows.Forms.TextBox
        Me.Txtcontact1 = New System.Windows.Forms.TextBox
        Me.Txtdesc_vendor = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.LblTotal = New System.Windows.Forms.Label
        Me.LblSubtotal = New System.Windows.Forms.Label
        Me.LblFET = New System.Windows.Forms.Label
        Me.LblTotalQty = New System.Windows.Forms.Label
        Me.LblwEIGHT = New System.Windows.Forms.Label
        Me.LblParts = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtDiscount = New CalcUtils.UcCalcText
        Me.TxtTax = New CalcUtils.UcCalcText
        Me.LblTax = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.ChkBefPaied = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RbBill = New System.Windows.Forms.RadioButton
        Me.RbCredit = New System.Windows.Forms.RadioButton
        Me.TxtDueDate = New CalendarCombo.CalendarCombo
        Me.Label26 = New System.Windows.Forms.Label
        Me.TxtVendorRefNo = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TxtRBDate = New CalendarCombo.CalendarCombo
        Me.Label12 = New System.Windows.Forms.Label
        Me.CmbApTerm = New System.Windows.Forms.ComboBox
        Me.DsFrmReceiveReturnProduct1 = New UcReceiveReturnProduct.DSFrmReceiveReturnProduct
        Me.Label11 = New System.Windows.Forms.Label
        Me.ChkBillReceive = New System.Windows.Forms.CheckBox
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.Cm1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DaInv_Receive_Products_head = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.DaPoDetail = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaInv_Receive_Products_Dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.DaPo = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_TAB_AR_TERM = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DaInv_Receive_product_Ap_Dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DaCheckForEdit = New System.Data.SqlClient.SqlDataAdapter
        Me.DaCheckForEditReturn = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DaGl_vendor_credit = New System.Data.SqlClient.SqlDataAdapter
        Me.PnlHead.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DsFrmReceiveReturnProduct1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=FARAJIXP;packet size=4096;user id=sa;data source=""."";persist secur" & _
        "ity info=True;initial catalog=Tiremate_01;password=sa"
        '
        'imageList1
        '
        Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'PnlHead
        '
        Me.PnlHead.BackColor = System.Drawing.SystemColors.Window
        Me.PnlHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlHead.Controls.Add(Me.CmdItemPrice)
        Me.PnlHead.Controls.Add(Me.Label36)
        Me.PnlHead.Controls.Add(Me.BtnFirst)
        Me.PnlHead.Controls.Add(Me.Label37)
        Me.PnlHead.Controls.Add(Me.BtnLast)
        Me.PnlHead.Controls.Add(Me.Label33)
        Me.PnlHead.Controls.Add(Me.BtnCancel)
        Me.PnlHead.Controls.Add(Me.Label32)
        Me.PnlHead.Controls.Add(Me.BtnEdit)
        Me.PnlHead.Controls.Add(Me.Label31)
        Me.PnlHead.Controls.Add(Me.Label30)
        Me.PnlHead.Controls.Add(Me.Label29)
        Me.PnlHead.Controls.Add(Me.Label28)
        Me.PnlHead.Controls.Add(Me.Label25)
        Me.PnlHead.Controls.Add(Me.Label24)
        Me.PnlHead.Controls.Add(Me.Label15)
        Me.PnlHead.Controls.Add(Me.Label14)
        Me.PnlHead.Controls.Add(Me.Label3)
        Me.PnlHead.Controls.Add(Me.Label1)
        Me.PnlHead.Controls.Add(Me.BtnEmail)
        Me.PnlHead.Controls.Add(Me.BtnFax)
        Me.PnlHead.Controls.Add(Me.BtnPrint)
        Me.PnlHead.Controls.Add(Me.BtnPreview)
        Me.PnlHead.Controls.Add(Me.BtnDelete)
        Me.PnlHead.Controls.Add(Me.BtnNew)
        Me.PnlHead.Controls.Add(Me.BtnFind)
        Me.PnlHead.Controls.Add(Me.BtnNext)
        Me.PnlHead.Controls.Add(Me.BtnPrev)
        Me.PnlHead.Controls.Add(Me.BtnSave)
        Me.PnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHead.Location = New System.Drawing.Point(0, 0)
        Me.PnlHead.Name = "PnlHead"
        Me.PnlHead.Size = New System.Drawing.Size(751, 58)
        Me.PnlHead.TabIndex = 4
        '
        'CmdItemPrice
        '
        Me.CmdItemPrice.Location = New System.Drawing.Point(584, 8)
        Me.CmdItemPrice.Name = "CmdItemPrice"
        Me.CmdItemPrice.Size = New System.Drawing.Size(117, 27)
        Me.CmdItemPrice.TabIndex = 193
        Me.CmdItemPrice.Text = "Calculate Item Price"
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Location = New System.Drawing.Point(4, 40)
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
        Me.BtnFirst.Location = New System.Drawing.Point(8, 5)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(33, 27)
        Me.BtnFirst.TabIndex = 191
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Location = New System.Drawing.Point(128, 40)
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
        Me.BtnLast.Location = New System.Drawing.Point(128, 5)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(33, 27)
        Me.BtnLast.TabIndex = 188
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Location = New System.Drawing.Point(376, 40)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(39, 10)
        Me.Label33.TabIndex = 186
        Me.Label33.Text = "Cancel"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.Enabled = False
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(376, 5)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 27)
        Me.BtnCancel.TabIndex = 7
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Location = New System.Drawing.Point(256, 40)
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
        Me.BtnEdit.Location = New System.Drawing.Point(256, 5)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(33, 27)
        Me.BtnEdit.TabIndex = 4
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Location = New System.Drawing.Point(544, 40)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(35, 9)
        Me.Label31.TabIndex = 182
        Me.Label31.Text = "Email"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(504, 40)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(33, 10)
        Me.Label30.TabIndex = 181
        Me.Label30.Text = "Fax"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(456, 40)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 180
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(414, 40)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(47, 10)
        Me.Label28.TabIndex = 179
        Me.Label28.Text = "Preview"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(336, 40)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(33, 10)
        Me.Label25.TabIndex = 176
        Me.Label25.Text = "Save"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(296, 40)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(37, 10)
        Me.Label24.TabIndex = 175
        Me.Label24.Text = "Delete"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(216, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 10)
        Me.Label15.TabIndex = 174
        Me.Label15.Text = "New"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(176, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 10)
        Me.Label14.TabIndex = 173
        Me.Label14.Text = "Find"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(48, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 10)
        Me.Label3.TabIndex = 172
        Me.Label3.Text = "Prev"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(88, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 10)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "Next"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEmail
        '
        Me.BtnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEmail.Image = CType(resources.GetObject("BtnEmail.Image"), System.Drawing.Image)
        Me.BtnEmail.Location = New System.Drawing.Point(544, 5)
        Me.BtnEmail.Name = "BtnEmail"
        Me.BtnEmail.Size = New System.Drawing.Size(33, 27)
        Me.BtnEmail.TabIndex = 13
        '
        'BtnFax
        '
        Me.BtnFax.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFax.Image = CType(resources.GetObject("BtnFax.Image"), System.Drawing.Image)
        Me.BtnFax.Location = New System.Drawing.Point(504, 5)
        Me.BtnFax.Name = "BtnFax"
        Me.BtnFax.Size = New System.Drawing.Size(33, 27)
        Me.BtnFax.TabIndex = 12
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(456, 5)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 11
        '
        'BtnPreview
        '
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Image = CType(resources.GetObject("BtnPreview.Image"), System.Drawing.Image)
        Me.BtnPreview.Location = New System.Drawing.Point(416, 5)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(33, 27)
        Me.BtnPreview.TabIndex = 10
        '
        'BtnDelete
        '
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(296, 5)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(33, 27)
        Me.BtnDelete.TabIndex = 5
        '
        'BtnNew
        '
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Location = New System.Drawing.Point(216, 5)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(33, 27)
        Me.BtnNew.TabIndex = 3
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(176, 5)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 27)
        Me.BtnFind.TabIndex = 2
        '
        'BtnNext
        '
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNext.Image = CType(resources.GetObject("BtnNext.Image"), System.Drawing.Image)
        Me.BtnNext.Location = New System.Drawing.Point(88, 5)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(33, 27)
        Me.BtnNext.TabIndex = 1
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.SystemColors.Window
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrev.Image = CType(resources.GetObject("BtnPrev.Image"), System.Drawing.Image)
        Me.BtnPrev.Location = New System.Drawing.Point(48, 5)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrev.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(336, 5)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TxtDate)
        Me.Panel1.Controls.Add(Me.TxtRef)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.LblName)
        Me.Panel1.Location = New System.Drawing.Point(160, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(456, 25)
        Me.Panel1.TabIndex = 5
        '
        'TxtDate
        '
        Me.TxtDate.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDate.Enabled = False
        Me.TxtDate.Location = New System.Drawing.Point(232, 1)
        Me.TxtDate.Name = "TxtDate"
        Me.TxtDate.ReadOnly = True
        Me.TxtDate.Size = New System.Drawing.Size(80, 20)
        Me.TxtDate.TabIndex = 142
        Me.TxtDate.Text = ""
        Me.TxtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtRef
        '
        Me.TxtRef.BackColor = System.Drawing.SystemColors.Window
        Me.TxtRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRef.Enabled = False
        Me.TxtRef.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtRef.Location = New System.Drawing.Point(352, 1)
        Me.TxtRef.Name = "TxtRef"
        Me.TxtRef.ReadOnly = True
        Me.TxtRef.Size = New System.Drawing.Size(96, 21)
        Me.TxtRef.TabIndex = 141
        Me.TxtRef.Text = ""
        Me.TxtRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(320, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 21)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "Ref"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(192, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 21)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Date"
        '
        'LblName
        '
        Me.LblName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblName.Location = New System.Drawing.Point(8, 2)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(190, 21)
        Me.LblName.TabIndex = 127
        Me.LblName.Text = "Inventory Receipt /Return"
        '
        'LblCompanyName
        '
        Me.LblCompanyName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblCompanyName.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblCompanyName.Location = New System.Drawing.Point(0, 64)
        Me.LblCompanyName.Name = "LblCompanyName"
        Me.LblCompanyName.Size = New System.Drawing.Size(162, 25)
        Me.LblCompanyName.TabIndex = 124
        Me.LblCompanyName.Text = "LblCompanyName"
        Me.LblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblStoreNo
        '
        Me.LblStoreNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblStoreNo.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblStoreNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblStoreNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblStoreNo.Location = New System.Drawing.Point(617, 64)
        Me.LblStoreNo.Name = "LblStoreNo"
        Me.LblStoreNo.Size = New System.Drawing.Size(86, 25)
        Me.LblStoreNo.TabIndex = 126
        Me.LblStoreNo.Text = "LblStoreNo"
        Me.LblStoreNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.SelectPo)
        Me.Panel2.Controls.Add(Me.PhoneNo1)
        Me.Panel2.Controls.Add(Me.BtnCustomerHistory)
        Me.Panel2.Controls.Add(Me.BtnCustomerDetail)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.TxtZipCode)
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Me.Txtaddress)
        Me.Panel2.Controls.Add(Me.Txtcontact1)
        Me.Panel2.Controls.Add(Me.Txtdesc_vendor)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(2, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(348, 121)
        Me.Panel2.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Location = New System.Drawing.Point(276, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(41, 1)
        Me.Panel4.TabIndex = 16
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Location = New System.Drawing.Point(-1, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(41, 1)
        Me.Panel6.TabIndex = 17
        '
        'SelectPo
        '
        Me.SelectPo.Location = New System.Drawing.Point(238, 96)
        Me.SelectPo.Name = "SelectPo"
        Me.SelectPo.Size = New System.Drawing.Size(101, 23)
        Me.SelectPo.TabIndex = 15
        Me.SelectPo.Text = "Select Po"
        '
        'PhoneNo1
        '
        Me.PhoneNo1.BackColor = System.Drawing.SystemColors.Window
        Me.PhoneNo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PhoneNo1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.PhoneNo1.Location = New System.Drawing.Point(216, 51)
        Me.PhoneNo1.Name = "PhoneNo1"
        Me.PhoneNo1.Size = New System.Drawing.Size(93, 20)
        Me.PhoneNo1.TabIndex = 7
        Me.PhoneNo1.TabStop = False
        '
        'BtnCustomerHistory
        '
        Me.BtnCustomerHistory.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnCustomerHistory.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnCustomerHistory.Location = New System.Drawing.Point(207, 0)
        Me.BtnCustomerHistory.Name = "BtnCustomerHistory"
        Me.BtnCustomerHistory.Size = New System.Drawing.Size(53, 21)
        Me.BtnCustomerHistory.TabIndex = 2
        Me.BtnCustomerHistory.TabStop = False
        Me.BtnCustomerHistory.Text = "History"
        '
        'BtnCustomerDetail
        '
        Me.BtnCustomerDetail.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnCustomerDetail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnCustomerDetail.Location = New System.Drawing.Point(161, 0)
        Me.BtnCustomerDetail.Name = "BtnCustomerDetail"
        Me.BtnCustomerDetail.Size = New System.Drawing.Size(46, 21)
        Me.BtnCustomerDetail.TabIndex = 1
        Me.BtnCustomerDetail.TabStop = False
        Me.BtnCustomerDetail.Text = "Detail"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.Location = New System.Drawing.Point(248, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 21)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Phone"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtZipCode
        '
        Me.TxtZipCode.BackColor = System.Drawing.SystemColors.Window
        Me.TxtZipCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtZipCode.Location = New System.Drawing.Point(264, 74)
        Me.TxtZipCode.Multiline = True
        Me.TxtZipCode.Name = "TxtZipCode"
        Me.TxtZipCode.ReadOnly = True
        Me.TxtZipCode.Size = New System.Drawing.Size(78, 20)
        Me.TxtZipCode.TabIndex = 9
        Me.TxtZipCode.TabStop = False
        Me.TxtZipCode.Text = ""
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Location = New System.Drawing.Point(216, 74)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(41, 20)
        Me.TextBox4.TabIndex = 8
        Me.TextBox4.TabStop = False
        Me.TextBox4.Text = ""
        '
        'Txtaddress
        '
        Me.Txtaddress.BackColor = System.Drawing.SystemColors.Window
        Me.Txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtaddress.Location = New System.Drawing.Point(56, 74)
        Me.Txtaddress.Multiline = True
        Me.Txtaddress.Name = "Txtaddress"
        Me.Txtaddress.ReadOnly = True
        Me.Txtaddress.Size = New System.Drawing.Size(157, 20)
        Me.Txtaddress.TabIndex = 6
        Me.Txtaddress.TabStop = False
        Me.Txtaddress.Text = ""
        '
        'Txtcontact1
        '
        Me.Txtcontact1.BackColor = System.Drawing.SystemColors.Window
        Me.Txtcontact1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtcontact1.Location = New System.Drawing.Point(56, 52)
        Me.Txtcontact1.Multiline = True
        Me.Txtcontact1.Name = "Txtcontact1"
        Me.Txtcontact1.ReadOnly = True
        Me.Txtcontact1.Size = New System.Drawing.Size(157, 19)
        Me.Txtcontact1.TabIndex = 5
        Me.Txtcontact1.TabStop = False
        Me.Txtcontact1.Text = ""
        '
        'Txtdesc_vendor
        '
        Me.Txtdesc_vendor.BackColor = System.Drawing.SystemColors.Window
        Me.Txtdesc_vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtdesc_vendor.Location = New System.Drawing.Point(56, 30)
        Me.Txtdesc_vendor.Multiline = True
        Me.Txtdesc_vendor.Name = "Txtdesc_vendor"
        Me.Txtdesc_vendor.ReadOnly = True
        Me.Txtdesc_vendor.Size = New System.Drawing.Size(157, 19)
        Me.Txtdesc_vendor.TabIndex = 4
        Me.Txtdesc_vendor.TabStop = False
        Me.Txtdesc_vendor.Text = ""
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.Location = New System.Drawing.Point(0, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 22)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Address"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 21)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Contact"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 21)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Company"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 21)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Vendor"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.LblTotal)
        Me.Panel3.Controls.Add(Me.LblSubtotal)
        Me.Panel3.Controls.Add(Me.LblFET)
        Me.Panel3.Controls.Add(Me.LblTotalQty)
        Me.Panel3.Controls.Add(Me.LblwEIGHT)
        Me.Panel3.Controls.Add(Me.LblParts)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.TxtDiscount)
        Me.Panel3.Controls.Add(Me.TxtTax)
        Me.Panel3.Controls.Add(Me.LblTax)
        Me.Panel3.Location = New System.Drawing.Point(352, 96)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(125, 119)
        Me.Panel3.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Location = New System.Drawing.Point(56, 58)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(66, 1)
        Me.Panel7.TabIndex = 166
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Location = New System.Drawing.Point(-1, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(41, 1)
        Me.Panel8.TabIndex = 17
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(56, 73)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(67, 16)
        Me.LblTotal.TabIndex = 5
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblSubtotal
        '
        Me.LblSubtotal.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSubtotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblSubtotal.Location = New System.Drawing.Point(56, 29)
        Me.LblSubtotal.Name = "LblSubtotal"
        Me.LblSubtotal.Size = New System.Drawing.Size(67, 16)
        Me.LblSubtotal.TabIndex = 2
        Me.LblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblFET
        '
        Me.LblFET.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblFET.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFET.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblFET.Location = New System.Drawing.Point(56, 14)
        Me.LblFET.Name = "LblFET"
        Me.LblFET.Size = New System.Drawing.Size(67, 16)
        Me.LblFET.TabIndex = 1
        Me.LblFET.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTotalQty
        '
        Me.LblTotalQty.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblTotalQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotalQty.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblTotalQty.Location = New System.Drawing.Point(56, 87)
        Me.LblTotalQty.Name = "LblTotalQty"
        Me.LblTotalQty.Size = New System.Drawing.Size(67, 16)
        Me.LblTotalQty.TabIndex = 6
        Me.LblTotalQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblwEIGHT
        '
        Me.LblwEIGHT.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblwEIGHT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblwEIGHT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblwEIGHT.Location = New System.Drawing.Point(56, 102)
        Me.LblwEIGHT.Name = "LblwEIGHT"
        Me.LblwEIGHT.Size = New System.Drawing.Size(67, 16)
        Me.LblwEIGHT.TabIndex = 7
        Me.LblwEIGHT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblParts
        '
        Me.LblParts.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblParts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblParts.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblParts.Location = New System.Drawing.Point(56, -1)
        Me.LblParts.Name = "LblParts"
        Me.LblParts.Size = New System.Drawing.Size(67, 16)
        Me.LblParts.TabIndex = 0
        Me.LblParts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label23.Location = New System.Drawing.Point(-1, 73)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(58, 16)
        Me.Label23.TabIndex = 144
        Me.Label23.Text = "Total $"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Location = New System.Drawing.Point(-1, 58)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(58, 16)
        Me.Label22.TabIndex = 143
        Me.Label22.Text = "Discount"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Location = New System.Drawing.Point(-1, 44)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 15)
        Me.Label21.TabIndex = 142
        Me.Label21.Text = "Tax"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label20.Location = New System.Drawing.Point(-1, 29)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 16)
        Me.Label20.TabIndex = 141
        Me.Label20.Text = "Subtotal"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Location = New System.Drawing.Point(-1, 14)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 16)
        Me.Label19.TabIndex = 140
        Me.Label19.Text = "FET"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label18.Location = New System.Drawing.Point(-1, 87)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 16)
        Me.Label18.TabIndex = 139
        Me.Label18.Text = "Total Qty"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label17.Location = New System.Drawing.Point(-5, 102)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 16)
        Me.Label17.TabIndex = 138
        Me.Label17.Text = "Tot Weight"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(-1, -1)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 16)
        Me.Label16.TabIndex = 137
        Me.Label16.Text = "Parts"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDiscount
        '
        Me.TxtDiscount.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.TxtDiscount.BorderStyle = Janus.Windows.UI.BorderStyle.None
        Me.TxtDiscount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.TxtDiscount.DecimalDigits = 2
        Me.TxtDiscount.DefaultSendValue = False
        Me.TxtDiscount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtDiscount.FireTabAfterEnter = True
        Me.TxtDiscount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiscount.Image = CType(resources.GetObject("TxtDiscount.Image"), System.Drawing.Image)
        Me.TxtDiscount.Location = New System.Drawing.Point(58, 56)
        Me.TxtDiscount.Maxlength = 10
        Me.TxtDiscount.MinusColor = System.Drawing.Color.Empty
        Me.TxtDiscount.Name = "TxtDiscount"
        Me.TxtDiscount.Size = New System.Drawing.Size(64, 21)
        Me.TxtDiscount.TabIndex = 164
        Me.TxtDiscount.TabStop = False
        Me.TxtDiscount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtDiscount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtTax
        '
        Me.TxtTax.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.TxtTax.BorderStyle = Janus.Windows.UI.BorderStyle.None
        Me.TxtTax.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.TxtTax.DecimalDigits = 2
        Me.TxtTax.DefaultSendValue = False
        Me.TxtTax.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtTax.FireTabAfterEnter = True
        Me.TxtTax.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTax.Image = CType(resources.GetObject("TxtTax.Image"), System.Drawing.Image)
        Me.TxtTax.Location = New System.Drawing.Point(59, 42)
        Me.TxtTax.Maxlength = 10
        Me.TxtTax.MinusColor = System.Drawing.Color.Empty
        Me.TxtTax.Name = "TxtTax"
        Me.TxtTax.Size = New System.Drawing.Size(64, 21)
        Me.TxtTax.TabIndex = 165
        Me.TxtTax.TabStop = False
        Me.TxtTax.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtTax.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblTax
        '
        Me.LblTax.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTax.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblTax.Location = New System.Drawing.Point(56, 44)
        Me.LblTax.Name = "LblTax"
        Me.LblTax.Size = New System.Drawing.Size(67, 15)
        Me.LblTax.TabIndex = 3
        Me.LblTax.Text = "0"
        Me.LblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.ChkBefPaied)
        Me.Panel5.Controls.Add(Me.GroupBox1)
        Me.Panel5.Controls.Add(Me.TxtDueDate)
        Me.Panel5.Controls.Add(Me.Label26)
        Me.Panel5.Controls.Add(Me.TxtVendorRefNo)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.TxtRBDate)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.CmbApTerm)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.ChkBillReceive)
        Me.Panel5.Location = New System.Drawing.Point(481, 96)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(266, 119)
        Me.Panel5.TabIndex = 137
        '
        'ChkBefPaied
        '
        Me.ChkBefPaied.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkBefPaied.Location = New System.Drawing.Point(144, 6)
        Me.ChkBefPaied.Name = "ChkBefPaied"
        Me.ChkBefPaied.Size = New System.Drawing.Size(72, 13)
        Me.ChkBefPaied.TabIndex = 14
        Me.ChkBefPaied.Text = "PrePaid"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbBill)
        Me.GroupBox1.Controls.Add(Me.RbCredit)
        Me.GroupBox1.Location = New System.Drawing.Point(0, -7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(56, 53)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'RbBill
        '
        Me.RbBill.Checked = True
        Me.RbBill.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RbBill.Location = New System.Drawing.Point(6, 9)
        Me.RbBill.Name = "RbBill"
        Me.RbBill.Size = New System.Drawing.Size(43, 23)
        Me.RbBill.TabIndex = 0
        Me.RbBill.TabStop = True
        Me.RbBill.Text = "Bill"
        Me.ToolTip1.SetToolTip(Me.RbBill, "Returning Products ")
        '
        'RbCredit
        '
        Me.RbCredit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RbCredit.Location = New System.Drawing.Point(6, 30)
        Me.RbCredit.Name = "RbCredit"
        Me.RbCredit.Size = New System.Drawing.Size(55, 22)
        Me.RbCredit.TabIndex = 1
        Me.RbCredit.Text = "Credit"
        '
        'TxtDueDate
        '
        Me.TxtDueDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtDueDate.BorderColor = System.Drawing.Color.Empty
        Me.TxtDueDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtDueDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtDueDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtDueDate.EditableSal = True
        Me.TxtDueDate.Image = CType(resources.GetObject("TxtDueDate.Image"), System.Drawing.Image)
        Me.TxtDueDate.Location = New System.Drawing.Point(144, 93)
        Me.TxtDueDate.MaxValue = CType(2500, Short)
        Me.TxtDueDate.MinValue = CType(1800, Short)
        Me.TxtDueDate.Name = "TxtDueDate"
        Me.TxtDueDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDueDate.Sal_Mali = Nothing
        Me.TxtDueDate.ShowButton = True
        Me.TxtDueDate.Size = New System.Drawing.Size(117, 23)
        Me.TxtDueDate.TabIndex = 9
        Me.TxtDueDate.VisualStyle = False
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label26.Location = New System.Drawing.Point(56, 93)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(71, 21)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "Due Date"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtVendorRefNo
        '
        Me.TxtVendorRefNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVendorRefNo.Location = New System.Drawing.Point(144, 72)
        Me.TxtVendorRefNo.MaxLength = 20
        Me.TxtVendorRefNo.Name = "TxtVendorRefNo"
        Me.TxtVendorRefNo.Size = New System.Drawing.Size(117, 20)
        Me.TxtVendorRefNo.TabIndex = 7
        Me.TxtVendorRefNo.Text = ""
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label13.Location = New System.Drawing.Point(48, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 21)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Vendor Ref. No."
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtRBDate
        '
        Me.TxtRBDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtRBDate.BorderColor = System.Drawing.Color.Empty
        Me.TxtRBDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtRBDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtRBDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtRBDate.EditableSal = True
        Me.TxtRBDate.Image = CType(resources.GetObject("TxtRBDate.Image"), System.Drawing.Image)
        Me.TxtRBDate.Location = New System.Drawing.Point(144, 46)
        Me.TxtRBDate.MaxValue = CType(2500, Short)
        Me.TxtRBDate.MinValue = CType(1800, Short)
        Me.TxtRBDate.Name = "TxtRBDate"
        Me.TxtRBDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtRBDate.Sal_Mali = Nothing
        Me.TxtRBDate.ShowButton = True
        Me.TxtRBDate.Size = New System.Drawing.Size(117, 23)
        Me.TxtRBDate.TabIndex = 5
        Me.TxtRBDate.VisualStyle = False
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label12.Location = New System.Drawing.Point(48, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 22)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Receipt/Bill Date"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbApTerm
        '
        Me.CmbApTerm.DataSource = Me.DsFrmReceiveReturnProduct1.GL_TAB_AR_TERM
        Me.CmbApTerm.DisplayMember = "AR_terms"
        Me.CmbApTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbApTerm.Location = New System.Drawing.Point(143, 22)
        Me.CmbApTerm.MaxLength = 10
        Me.CmbApTerm.Name = "CmbApTerm"
        Me.CmbApTerm.Size = New System.Drawing.Size(118, 21)
        Me.CmbApTerm.TabIndex = 12
        Me.CmbApTerm.ValueMember = "AR_terms"
        '
        'DsFrmReceiveReturnProduct1
        '
        Me.DsFrmReceiveReturnProduct1.DataSetName = "DSFrmReceiveReturnProduct"
        Me.DsFrmReceiveReturnProduct1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.Location = New System.Drawing.Point(72, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 22)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Ap Terms"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChkBillReceive
        '
        Me.ChkBillReceive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkBillReceive.Location = New System.Drawing.Point(56, 7)
        Me.ChkBillReceive.Name = "ChkBillReceive"
        Me.ChkBillReceive.Size = New System.Drawing.Size(87, 13)
        Me.ChkBillReceive.TabIndex = 3
        Me.ChkBillReceive.Text = "Bill Received"
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowColumnDrag = False
        Me.GrdDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrdDetail.AutomaticSort = False
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.ContextMenu = Me.Cm1
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "Inv_Receive_product_dtl"
        Me.GrdDetail.DataSource = Me.DsFrmReceiveReturnProduct1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>service_center_dtl</Caption><Columns Collec" & _
        "tion=""true""><Column0 ID=""Det""><Bound>False</Bound><ButtonStyle>ButtonCell</Butto" & _
        "nStyle><Caption>Find</Caption><EditType>NoEdit</EditType><Key>Det</Key><Position" & _
        ">0</Position><Selectable>False</Selectable><Width>31</Width></Column0><Column1 I" & _
        "D=""item_no""><Caption>Item No</Caption><DataMember>item_no</DataMember><Key>item_" & _
        "no</Key><Position>1</Position><Width>87</Width><CellStyle><BackColor>Silver</Bac" & _
        "kColor></CellStyle></Column1><Column2 ID=""desc_item""><Caption>Description</Capti" & _
        "on><DataMember>desc_item</DataMember><Key>desc_item</Key><Position>2</Position><" & _
        "Selectable>False</Selectable><Width>272</Width></Column2><Column3 ID=""qty""><Capt" & _
        "ion>Qty</Caption><DataMember>qty</DataMember><Key>qty</Key><Position>3</Position" & _
        "><Width>48</Width><DefaultValue>0</DefaultValue><CellStyle><BackColor>Silver</Ba" & _
        "ckColor></CellStyle></Column3><Column4 ID=""cost""><Caption>Cost</Caption><DataMem" & _
        "ber>cost</DataMember><FormatString>c2</FormatString><Key>cost</Key><Position>4</" & _
        "Position><Width>77</Width><DefaultValue>0</DefaultValue><CellStyle><BackColor>Si" & _
        "lver</BackColor></CellStyle></Column4><Column5 ID=""fet""><Caption>FET</Caption><D" & _
        "ataMember>fet</DataMember><Key>fet</Key><Position>5</Position><Selectable>False<" & _
        "/Selectable><Width>49</Width><DefaultValue>0</DefaultValue><CellStyle><BackColor" & _
        ">White</BackColor></CellStyle></Column5><Column6 ID=""taxable""><Caption>T</Captio" & _
        "n><ColumnType>CheckBox</ColumnType><DataMember>taxable</DataMember><EditType>Che" & _
        "ckBox</EditType><Key>taxable</Key><Position>6</Position><Width>32</Width><Defaul" & _
        "tValue>False</DefaultValue></Column6><Column7 ID=""ExtCost""><Caption>Ext Cost</Ca" & _
        "ption><DataMember>ExCost</DataMember><DefaultGroupPrefix>ExtCost:</DefaultGroupP" & _
        "refix><FormatString>c</FormatString><Key>ExtCost</Key><Position>7</Position><Sel" & _
        "ectable>False</Selectable><Width>83</Width><DefaultValue>0</DefaultValue></Colum" & _
        "n7><Column8 ID=""wieght_lbs""><Caption>wieght_lbs</Caption><DataMember>wieght_lbs<" & _
        "/DataMember><Key>wieght_lbs</Key><Position>8</Position><Visible>False</Visible><" & _
        "/Column8><Column9 ID=""Column1""><Bound>False</Bound><ButtonStyle>ButtonCell</Butt" & _
        "onStyle><Caption>Det</Caption><Key>Column1</Key><Position>9</Position><Width>29<" & _
        "/Width></Column9></Columns><GroupCondition ID="""" /><Key>service_center_dtl</Key>" & _
        "<RowHeight>19</RowHeight></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.ExternalImageList = Me.imageList1
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(0, 219)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(750, 259)
        Me.GrdDetail.TabIndex = 0
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
        'DaInv_Receive_Products_head
        '
        Me.DaInv_Receive_Products_head.DeleteCommand = Me.SqlDeleteCommand4
        Me.DaInv_Receive_Products_head.InsertCommand = Me.SqlInsertCommand4
        Me.DaInv_Receive_Products_head.SelectCommand = Me.SqlSelectCommand4
        Me.DaInv_Receive_Products_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_Receive_Products_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_receive_ref", "id_receive_ref"), New System.Data.Common.DataColumnMapping("date_receive", "date_receive"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("bill_credit", "bill_credit"), New System.Data.Common.DataColumnMapping("bill_receive", "bill_receive"), New System.Data.Common.DataColumnMapping("ap_term", "ap_term"), New System.Data.Common.DataColumnMapping("receipt_bill_date", "receipt_bill_date"), New System.Data.Common.DataColumnMapping("vendor_ref_no", "vendor_ref_no"), New System.Data.Common.DataColumnMapping("due_date", "due_date"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("house_comments", "house_comments"), New System.Data.Common.DataColumnMapping("vend_comments", "vend_comments"), New System.Data.Common.DataColumnMapping("Discount", "Discount"), New System.Data.Common.DataColumnMapping("Prepaid", "Prepaid"), New System.Data.Common.DataColumnMapping("Tax", "Tax")})})
        Me.DaInv_Receive_Products_head.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM Inv_Receive_Products_head WHERE (id_receive_ref = @Original_id_receiv" & _
        "e_ref) AND (Discount = @Original_Discount) AND (Prepaid = @Original_Prepaid OR @" & _
        "Original_Prepaid IS NULL AND Prepaid IS NULL) AND (Tax = @Original_Tax OR @Origi" & _
        "nal_Tax IS NULL AND Tax IS NULL) AND (ap_term = @Original_ap_term OR @Original_a" & _
        "p_term IS NULL AND ap_term IS NULL) AND (bill_credit = @Original_bill_credit OR " & _
        "@Original_bill_credit IS NULL AND bill_credit IS NULL) AND (bill_receive = @Orig" & _
        "inal_bill_receive) AND (cod_vendor = @Original_cod_vendor) AND (date_receive = @" & _
        "Original_date_receive OR @Original_date_receive IS NULL AND date_receive IS NULL" & _
        ") AND (due_date = @Original_due_date OR @Original_due_date IS NULL AND due_date " & _
        "IS NULL) AND (house_comments = @Original_house_comments OR @Original_house_comme" & _
        "nts IS NULL AND house_comments IS NULL) AND (po_no = @Original_po_no OR @Origina" & _
        "l_po_no IS NULL AND po_no IS NULL) AND (receipt_bill_date = @Original_receipt_bi" & _
        "ll_date OR @Original_receipt_bill_date IS NULL AND receipt_bill_date IS NULL) AN" & _
        "D (vend_comments = @Original_vend_comments OR @Original_vend_comments IS NULL AN" & _
        "D vend_comments IS NULL) AND (vendor_ref_no = @Original_vendor_ref_no OR @Origin" & _
        "al_vendor_ref_no IS NULL AND vendor_ref_no IS NULL)"
        Me.SqlDeleteCommand4.Connection = Me.Cnn
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_receive_ref", System.Data.SqlDbType.VarChar, 7, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_receive_ref", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Discount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Prepaid", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Prepaid", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ap_term", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ap_term", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_bill_credit", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bill_credit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_bill_receive", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bill_receive", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_receive", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_receive", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_due_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "due_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_house_comments", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "house_comments", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_po_no", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "po_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_receipt_bill_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "receipt_bill_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vend_comments", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vend_comments", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vendor_ref_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vendor_ref_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO Inv_Receive_Products_head(id_receive_ref, date_receive, cod_vendor, b" & _
        "ill_credit, bill_receive, ap_term, receipt_bill_date, vendor_ref_no, due_date, p" & _
        "o_no, house_comments, vend_comments, Discount, Prepaid, Tax) VALUES (@id_receive" & _
        "_ref, @date_receive, @cod_vendor, @bill_credit, @bill_receive, @ap_term, @receip" & _
        "t_bill_date, @vendor_ref_no, @due_date, @po_no, @house_comments, @vend_comments," & _
        " @Discount, @Prepaid, @Tax); SELECT id_receive_ref, date_receive, cod_vendor, bi" & _
        "ll_credit, bill_receive, ap_term, receipt_bill_date, vendor_ref_no, due_date, po" & _
        "_no, house_comments, vend_comments, Discount, Prepaid, Tax FROM Inv_Receive_Prod" & _
        "ucts_head WHERE (id_receive_ref = @id_receive_ref)"
        Me.SqlInsertCommand4.Connection = Me.Cnn
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_receive_ref", System.Data.SqlDbType.VarChar, 7, "id_receive_ref"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_receive", System.Data.SqlDbType.VarChar, 10, "date_receive"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@bill_credit", System.Data.SqlDbType.VarChar, 1, "bill_credit"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@bill_receive", System.Data.SqlDbType.Bit, 1, "bill_receive"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ap_term", System.Data.SqlDbType.VarChar, 10, "ap_term"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@receipt_bill_date", System.Data.SqlDbType.VarChar, 10, "receipt_bill_date"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vendor_ref_no", System.Data.SqlDbType.VarChar, 20, "vendor_ref_no"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@due_date", System.Data.SqlDbType.VarChar, 10, "due_date"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@po_no", System.Data.SqlDbType.VarChar, 6, "po_no"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@house_comments", System.Data.SqlDbType.VarChar, 300, "house_comments"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vend_comments", System.Data.SqlDbType.VarChar, 300, "vend_comments"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Discount", System.Data.SqlDbType.Real, 4, "Discount"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Prepaid", System.Data.SqlDbType.Bit, 1, "Prepaid"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Tax", System.Data.DataRowVersion.Current, Nothing))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT id_receive_ref, date_receive, cod_vendor, bill_credit, bill_receive, ap_te" & _
        "rm, receipt_bill_date, vendor_ref_no, due_date, po_no, house_comments, vend_comm" & _
        "ents, Discount, Prepaid, Tax FROM Inv_Receive_Products_head WHERE (id_receive_re" & _
        "f = @id_receive_ref)"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_receive_ref", System.Data.SqlDbType.VarChar, 7, "id_receive_ref"))
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE Inv_Receive_Products_head SET id_receive_ref = @id_receive_ref, date_recei" & _
        "ve = @date_receive, cod_vendor = @cod_vendor, bill_credit = @bill_credit, bill_r" & _
        "eceive = @bill_receive, ap_term = @ap_term, receipt_bill_date = @receipt_bill_da" & _
        "te, vendor_ref_no = @vendor_ref_no, due_date = @due_date, po_no = @po_no, house_" & _
        "comments = @house_comments, vend_comments = @vend_comments, Discount = @Discount" & _
        ", Prepaid = @Prepaid, Tax = @Tax WHERE (id_receive_ref = @Original_id_receive_re" & _
        "f) AND (Discount = @Original_Discount) AND (Prepaid = @Original_Prepaid OR @Orig" & _
        "inal_Prepaid IS NULL AND Prepaid IS NULL) AND (Tax = @Original_Tax OR @Original_" & _
        "Tax IS NULL AND Tax IS NULL) AND (ap_term = @Original_ap_term OR @Original_ap_te" & _
        "rm IS NULL AND ap_term IS NULL) AND (bill_credit = @Original_bill_credit OR @Ori" & _
        "ginal_bill_credit IS NULL AND bill_credit IS NULL) AND (bill_receive = @Original" & _
        "_bill_receive) AND (cod_vendor = @Original_cod_vendor) AND (date_receive = @Orig" & _
        "inal_date_receive OR @Original_date_receive IS NULL AND date_receive IS NULL) AN" & _
        "D (due_date = @Original_due_date OR @Original_due_date IS NULL AND due_date IS N" & _
        "ULL) AND (house_comments = @Original_house_comments OR @Original_house_comments " & _
        "IS NULL AND house_comments IS NULL) AND (po_no = @Original_po_no OR @Original_po" & _
        "_no IS NULL AND po_no IS NULL) AND (receipt_bill_date = @Original_receipt_bill_d" & _
        "ate OR @Original_receipt_bill_date IS NULL AND receipt_bill_date IS NULL) AND (v" & _
        "end_comments = @Original_vend_comments OR @Original_vend_comments IS NULL AND ve" & _
        "nd_comments IS NULL) AND (vendor_ref_no = @Original_vendor_ref_no OR @Original_v" & _
        "endor_ref_no IS NULL AND vendor_ref_no IS NULL); SELECT id_receive_ref, date_rec" & _
        "eive, cod_vendor, bill_credit, bill_receive, ap_term, receipt_bill_date, vendor_" & _
        "ref_no, due_date, po_no, house_comments, vend_comments, Discount, Prepaid, Tax F" & _
        "ROM Inv_Receive_Products_head WHERE (id_receive_ref = @id_receive_ref)"
        Me.SqlUpdateCommand4.Connection = Me.Cnn
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_receive_ref", System.Data.SqlDbType.VarChar, 7, "id_receive_ref"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_receive", System.Data.SqlDbType.VarChar, 10, "date_receive"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@bill_credit", System.Data.SqlDbType.VarChar, 1, "bill_credit"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@bill_receive", System.Data.SqlDbType.Bit, 1, "bill_receive"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ap_term", System.Data.SqlDbType.VarChar, 10, "ap_term"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@receipt_bill_date", System.Data.SqlDbType.VarChar, 10, "receipt_bill_date"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vendor_ref_no", System.Data.SqlDbType.VarChar, 20, "vendor_ref_no"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@due_date", System.Data.SqlDbType.VarChar, 10, "due_date"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@po_no", System.Data.SqlDbType.VarChar, 6, "po_no"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@house_comments", System.Data.SqlDbType.VarChar, 300, "house_comments"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vend_comments", System.Data.SqlDbType.VarChar, 300, "vend_comments"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Discount", System.Data.SqlDbType.Real, 4, "Discount"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Prepaid", System.Data.SqlDbType.Bit, 1, "Prepaid"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Tax", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_receive_ref", System.Data.SqlDbType.VarChar, 7, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_receive_ref", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Discount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Prepaid", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Prepaid", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tax", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "Tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ap_term", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ap_term", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_bill_credit", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bill_credit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_bill_receive", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bill_receive", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_receive", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_receive", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_due_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "due_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_house_comments", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "house_comments", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_po_no", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "po_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_receipt_bill_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "receipt_bill_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vend_comments", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vend_comments", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vendor_ref_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vendor_ref_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'DaPoDetail
        '
        Me.DaPoDetail.SelectCommand = Me.SqlCommand3
        Me.DaPoDetail.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_purchase_order_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("taxable", "taxable")})})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT Inv_purchase_order_dtl.po_no, Inv_purchase_order_dtl.item_no, Inv_purchase" & _
        "_order_dtl.qty, Inv_purchase_order_dtl.taxable, inv_item_cost_transaction.fet, i" & _
        "nv_item_cost_transaction.frieght, inv_item.desc_item, inv_item_cost_transaction." & _
        "cost AS InvItemCost, Inv_purchase_order_dtl.cost, Inv_purchase_order_head.cod_ve" & _
        "ndor FROM Inv_purchase_order_dtl INNER JOIN inv_item_cost_transaction ON Inv_pur" & _
        "chase_order_dtl.item_no = inv_item_cost_transaction.item_no INNER JOIN Inv_purch" & _
        "ase_order_head ON Inv_purchase_order_dtl.po_no = Inv_purchase_order_head.po_no L" & _
        "EFT OUTER JOIN inv_item ON Inv_purchase_order_dtl.item_no = inv_item.item_no AND" & _
        " inv_item_cost_transaction.item_no = inv_item.item_no WHERE (inv_item_cost_trans" & _
        "action.last_flag = 1) AND (Inv_purchase_order_dtl.po_no = @po_no)"
        Me.SqlCommand3.Connection = Me.Cnn
        Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@po_no", System.Data.SqlDbType.VarChar, 6, "po_no"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Inv_Receive_product_dtl.id_receive_ref, Inv_Receive_product_dtl.item_no, I" & _
        "nv_Receive_product_dtl.qty, Inv_Receive_product_dtl.cost, Inv_Receive_product_dt" & _
        "l.taxable, inv_item.desc_item, inv_item_cost_transaction.cost AS InvItemCost, (I" & _
        "nv_Receive_product_dtl.cost + inv_item_cost_transaction.fet) * Inv_Receive_produ" & _
        "ct_dtl.qty AS ExCost, inv_tab_tire_specification.wieght_lbs, Inv_Receive_product" & _
        "_dtl.fet FROM inv_item LEFT OUTER JOIN inv_tab_tire_specification ON inv_item.it" & _
        "em_no = inv_tab_tire_specification.item_no LEFT OUTER JOIN inv_item_cost_transac" & _
        "tion ON inv_item.item_no = inv_item_cost_transaction.item_no RIGHT OUTER JOIN In" & _
        "v_Receive_product_dtl ON inv_item.item_no = Inv_Receive_product_dtl.item_no WHER" & _
        "E (inv_item_cost_transaction.last_flag = 1) AND (Inv_Receive_product_dtl.id_rece" & _
        "ive_ref = @Id_receive_ref)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_receive_ref", System.Data.SqlDbType.VarChar, 7, "id_receive_ref"))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Inv_Receive_product_dtl(id_receive_ref, item_no, qty, cost, Fet, taxa" & _
        "ble) VALUES (@id_receive_ref, @item_no, @qty, @cost, @Fet, @taxable); SELECT id_" & _
        "receive_ref, item_no, qty, cost, Fet, taxable FROM Inv_Receive_product_dtl WHERE" & _
        " (id_receive_ref = @id_receive_ref) AND (item_no = @item_no)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_receive_ref", System.Data.SqlDbType.VarChar, 7, "id_receive_ref"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@qty", System.Data.SqlDbType.Real, 4, "qty"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cost", System.Data.SqlDbType.Money, 8, "cost"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fet", System.Data.SqlDbType.Money, 8, "Fet"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@taxable", System.Data.SqlDbType.Bit, 1, "taxable"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Inv_Receive_product_dtl SET id_receive_ref = @id_receive_ref, item_no = @i" & _
        "tem_no, qty = @qty, cost = @cost, Fet = @Fet, taxable = @taxable WHERE (id_recei" & _
        "ve_ref = @Original_id_receive_ref) AND (item_no = @Original_item_no) AND (Fet = " & _
        "@Original_Fet OR @Original_Fet IS NULL AND Fet IS NULL) AND (cost = @Original_co" & _
        "st OR @Original_cost IS NULL AND cost IS NULL) AND (qty = @Original_qty OR @Orig" & _
        "inal_qty IS NULL AND qty IS NULL) AND (taxable = @Original_taxable OR @Original_" & _
        "taxable IS NULL AND taxable IS NULL); SELECT id_receive_ref, item_no, qty, cost," & _
        " Fet, taxable FROM Inv_Receive_product_dtl WHERE (id_receive_ref = @id_receive_r" & _
        "ef) AND (item_no = @item_no)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_receive_ref", System.Data.SqlDbType.VarChar, 7, "id_receive_ref"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@qty", System.Data.SqlDbType.Real, 4, "qty"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cost", System.Data.SqlDbType.Money, 8, "cost"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fet", System.Data.SqlDbType.Money, 8, "Fet"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@taxable", System.Data.SqlDbType.Bit, 1, "taxable"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_receive_ref", System.Data.SqlDbType.VarChar, 7, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_receive_ref", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fet", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cost", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cost", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_qty", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "qty", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_taxable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "taxable", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Inv_Receive_product_dtl WHERE (id_receive_ref = @Original_id_receive_" & _
        "ref) AND (item_no = @Original_item_no) AND (Fet = @Original_Fet OR @Original_Fet" & _
        " IS NULL AND Fet IS NULL) AND (cost = @Original_cost OR @Original_cost IS NULL A" & _
        "ND cost IS NULL) AND (qty = @Original_qty OR @Original_qty IS NULL AND qty IS NU" & _
        "LL) AND (taxable = @Original_taxable OR @Original_taxable IS NULL AND taxable IS" & _
        " NULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_receive_ref", System.Data.SqlDbType.VarChar, 7, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_receive_ref", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fet", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cost", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cost", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_qty", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "qty", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_taxable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "taxable", System.Data.DataRowVersion.Original, Nothing))
        '
        'DaInv_Receive_Products_Dtl
        '
        Me.DaInv_Receive_Products_Dtl.DeleteCommand = Me.SqlDeleteCommand1
        Me.DaInv_Receive_Products_Dtl.InsertCommand = Me.SqlInsertCommand1
        Me.DaInv_Receive_Products_Dtl.SelectCommand = Me.SqlSelectCommand1
        Me.DaInv_Receive_Products_Dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_Receive_product_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_receive_ref", "id_receive_ref"), New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("Fet", "Fet"), New System.Data.Common.DataColumnMapping("taxable", "taxable")})})
        Me.DaInv_Receive_Products_Dtl.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DaPo
        '
        Me.DaPo.SelectCommand = Me.SqlCommand4
        Me.DaPo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_purchase_order_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("Fet", "Fet"), New System.Data.Common.DataColumnMapping("taxable", "taxable")})})
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "SELECT po_no, item_no, qty, taxable, cost, fet FROM Inv_purchase_order_dtl WHERE " & _
        "(po_no = @po_no)"
        Me.SqlCommand4.Connection = Me.Cnn
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@po_no", System.Data.SqlDbType.VarChar, 6, "po_no"))
        '
        'DAGL_TAB_AR_TERM
        '
        Me.DAGL_TAB_AR_TERM.DeleteCommand = Me.SqlCommand1
        Me.DAGL_TAB_AR_TERM.InsertCommand = Me.SqlCommand2
        Me.DAGL_TAB_AR_TERM.SelectCommand = Me.SqlCommand5
        Me.DAGL_TAB_AR_TERM.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_TAB_AR_TERM", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("AR_terms", "AR_terms"), New System.Data.Common.DataColumnMapping("KIND_AR", "KIND_AR"), New System.Data.Common.DataColumnMapping("ST_NET_DUE_IN", "ST_NET_DUE_IN"), New System.Data.Common.DataColumnMapping("ST_DISCOUNT_PERCENTAGE", "ST_DISCOUNT_PERCENTAGE"), New System.Data.Common.DataColumnMapping("ST_IF_PAY_WITHIN_DAYS", "ST_IF_PAY_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("DD_NET_DUE_BEFORE", "DD_NET_DUE_BEFORE"), New System.Data.Common.DataColumnMapping("DD_IF_ISSUED_WITHIN_DAYS", "DD_IF_ISSUED_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("DD_DISCOUNT_PERCENTAGE", "DD_DISCOUNT_PERCENTAGE"), New System.Data.Common.DataColumnMapping("DD_IF_PAY_WITHIN_DAYS", "DD_IF_PAY_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("MP_NO_OF_PAYMENT", "MP_NO_OF_PAYMENT"), New System.Data.Common.DataColumnMapping("MP_BEFORE_DAY", "MP_BEFORE_DAY")})})
        Me.DAGL_TAB_AR_TERM.UpdateCommand = Me.SqlCommand6
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "DELETE FROM GL_TAB_AR_TERM WHERE (AR_terms = @Original_AR_terms) AND (DD_DISCOUNT" & _
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
        Me.SqlCommand1.Connection = Me.Cnn
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_terms", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_terms", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DD_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_IF_ISSUED_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_IF_ISSUED_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_IF_PAY_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_NET_DUE_BEFORE", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_NET_DUE_BEFORE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_KIND_AR", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "KIND_AR", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MP_BEFORE_DAY", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MP_BEFORE_DAY", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MP_NO_OF_PAYMENT", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MP_NO_OF_PAYMENT", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ST_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ST_IF_PAY_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_NET_DUE_IN", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ST_NET_DUE_IN", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "INSERT INTO GL_TAB_AR_TERM(AR_terms, KIND_AR, ST_NET_DUE_IN, ST_DISCOUNT_PERCENTA" & _
        "GE, ST_IF_PAY_WITHIN_DAYS, DD_NET_DUE_BEFORE, DD_IF_ISSUED_WITHIN_DAYS, DD_DISCO" & _
        "UNT_PERCENTAGE, DD_IF_PAY_WITHIN_DAYS, MP_NO_OF_PAYMENT, MP_BEFORE_DAY) VALUES (" & _
        "@AR_terms, @KIND_AR, @ST_NET_DUE_IN, @ST_DISCOUNT_PERCENTAGE, @ST_IF_PAY_WITHIN_" & _
        "DAYS, @DD_NET_DUE_BEFORE, @DD_IF_ISSUED_WITHIN_DAYS, @DD_DISCOUNT_PERCENTAGE, @D" & _
        "D_IF_PAY_WITHIN_DAYS, @MP_NO_OF_PAYMENT, @MP_BEFORE_DAY); SELECT AR_terms, KIND_" & _
        "AR, ST_NET_DUE_IN, ST_DISCOUNT_PERCENTAGE, ST_IF_PAY_WITHIN_DAYS, DD_NET_DUE_BEF" & _
        "ORE, DD_IF_ISSUED_WITHIN_DAYS, DD_DISCOUNT_PERCENTAGE, DD_IF_PAY_WITHIN_DAYS, MP" & _
        "_NO_OF_PAYMENT, MP_BEFORE_DAY FROM GL_TAB_AR_TERM WHERE (AR_terms = @AR_terms)"
        Me.SqlCommand2.Connection = Me.Cnn
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_terms", System.Data.SqlDbType.VarChar, 10, "AR_terms"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@KIND_AR", System.Data.SqlDbType.SmallInt, 2, "KIND_AR"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_NET_DUE_IN", System.Data.SqlDbType.SmallInt, 2, "ST_NET_DUE_IN"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ST_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "ST_IF_PAY_WITHIN_DAYS"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_NET_DUE_BEFORE", System.Data.SqlDbType.SmallInt, 2, "DD_NET_DUE_BEFORE"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_IF_ISSUED_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "DD_IF_ISSUED_WITHIN_DAYS"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DD_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "DD_IF_PAY_WITHIN_DAYS"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_NO_OF_PAYMENT", System.Data.SqlDbType.SmallInt, 2, "MP_NO_OF_PAYMENT"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_BEFORE_DAY", System.Data.SqlDbType.SmallInt, 2, "MP_BEFORE_DAY"))
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "SELECT AR_terms, KIND_AR, ST_NET_DUE_IN, ST_DISCOUNT_PERCENTAGE, ST_IF_PAY_WITHIN" & _
        "_DAYS, DD_NET_DUE_BEFORE, DD_IF_ISSUED_WITHIN_DAYS, DD_DISCOUNT_PERCENTAGE, DD_I" & _
        "F_PAY_WITHIN_DAYS, MP_NO_OF_PAYMENT, MP_BEFORE_DAY FROM GL_TAB_AR_TERM"
        Me.SqlCommand5.Connection = Me.Cnn
        '
        'SqlCommand6
        '
        Me.SqlCommand6.CommandText = "UPDATE GL_TAB_AR_TERM SET AR_terms = @AR_terms, KIND_AR = @KIND_AR, ST_NET_DUE_IN" & _
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
        Me.SqlCommand6.Connection = Me.Cnn
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_terms", System.Data.SqlDbType.VarChar, 10, "AR_terms"))
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@KIND_AR", System.Data.SqlDbType.SmallInt, 2, "KIND_AR"))
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_NET_DUE_IN", System.Data.SqlDbType.SmallInt, 2, "ST_NET_DUE_IN"))
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ST_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ST_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "ST_IF_PAY_WITHIN_DAYS"))
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_NET_DUE_BEFORE", System.Data.SqlDbType.SmallInt, 2, "DD_NET_DUE_BEFORE"))
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_IF_ISSUED_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "DD_IF_ISSUED_WITHIN_DAYS"))
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DD_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DD_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, "DD_IF_PAY_WITHIN_DAYS"))
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_NO_OF_PAYMENT", System.Data.SqlDbType.SmallInt, 2, "MP_NO_OF_PAYMENT"))
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MP_BEFORE_DAY", System.Data.SqlDbType.SmallInt, 2, "MP_BEFORE_DAY"))
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_terms", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_terms", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "DD_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_IF_ISSUED_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_IF_ISSUED_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_IF_PAY_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DD_NET_DUE_BEFORE", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DD_NET_DUE_BEFORE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_KIND_AR", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "KIND_AR", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MP_BEFORE_DAY", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MP_BEFORE_DAY", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MP_NO_OF_PAYMENT", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MP_NO_OF_PAYMENT", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_DISCOUNT_PERCENTAGE", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "ST_DISCOUNT_PERCENTAGE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_IF_PAY_WITHIN_DAYS", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ST_IF_PAY_WITHIN_DAYS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ST_NET_DUE_IN", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ST_NET_DUE_IN", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT ID_Inv_Receive_product_Ap_Dtl, id_receive_ref, amount, due_date FROM Inv_R" & _
        "eceive_product_Ap_Dtl WHERE (id_receive_ref = @ID_Inv_Receive_product_Ap_Dtl)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_Inv_Receive_product_Ap_Dtl", System.Data.SqlDbType.VarChar, 6, "id_receive_ref"))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Inv_Receive_product_Ap_Dtl(id_receive_ref, amount, due_date) VALUES (" & _
        "@id_receive_ref, @amount, @due_date); SELECT ID_Inv_Receive_product_Ap_Dtl, id_r" & _
        "eceive_ref, amount, due_date FROM Inv_Receive_product_Ap_Dtl WHERE (ID_Inv_Recei" & _
        "ve_product_Ap_Dtl = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_receive_ref", System.Data.SqlDbType.VarChar, 7, "id_receive_ref"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount", System.Data.SqlDbType.Money, 8, "amount"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@due_date", System.Data.SqlDbType.VarChar, 10, "due_date"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE Inv_Receive_product_Ap_Dtl SET id_receive_ref = @id_receive_ref, amount = " & _
        "@amount, due_date = @due_date WHERE (ID_Inv_Receive_product_Ap_Dtl = @Original_I" & _
        "D_Inv_Receive_product_Ap_Dtl) AND (amount = @Original_amount) AND (due_date = @O" & _
        "riginal_due_date) AND (id_receive_ref = @Original_id_receive_ref); SELECT ID_Inv" & _
        "_Receive_product_Ap_Dtl, id_receive_ref, amount, due_date FROM Inv_Receive_produ" & _
        "ct_Ap_Dtl WHERE (ID_Inv_Receive_product_Ap_Dtl = @ID_Inv_Receive_product_Ap_Dtl)" & _
        ""
        Me.SqlUpdateCommand2.Connection = Me.Cnn
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_receive_ref", System.Data.SqlDbType.VarChar, 7, "id_receive_ref"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount", System.Data.SqlDbType.Money, 8, "amount"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@due_date", System.Data.SqlDbType.VarChar, 10, "due_date"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_Inv_Receive_product_Ap_Dtl", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Inv_Receive_product_Ap_Dtl", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_due_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "due_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_receive_ref", System.Data.SqlDbType.VarChar, 7, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_receive_ref", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_Inv_Receive_product_Ap_Dtl", System.Data.SqlDbType.Int, 4, "ID_Inv_Receive_product_Ap_Dtl"))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM Inv_Receive_product_Ap_Dtl WHERE (ID_Inv_Receive_product_Ap_Dtl = @Or" & _
        "iginal_ID_Inv_Receive_product_Ap_Dtl) AND (amount = @Original_amount) AND (due_d" & _
        "ate = @Original_due_date) AND (id_receive_ref = @Original_id_receive_ref)"
        Me.SqlDeleteCommand2.Connection = Me.Cnn
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_Inv_Receive_product_Ap_Dtl", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Inv_Receive_product_Ap_Dtl", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_due_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "due_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_receive_ref", System.Data.SqlDbType.VarChar, 7, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_receive_ref", System.Data.DataRowVersion.Original, Nothing))
        '
        'DaInv_Receive_product_Ap_Dtl
        '
        Me.DaInv_Receive_product_Ap_Dtl.DeleteCommand = Me.SqlDeleteCommand2
        Me.DaInv_Receive_product_Ap_Dtl.InsertCommand = Me.SqlInsertCommand2
        Me.DaInv_Receive_product_Ap_Dtl.SelectCommand = Me.SqlSelectCommand2
        Me.DaInv_Receive_product_Ap_Dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_Receive_product_Ap_Dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Inv_Receive_product_Ap_Dtl", "ID_Inv_Receive_product_Ap_Dtl"), New System.Data.Common.DataColumnMapping("id_receive_ref", "id_receive_ref"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("due_date", "due_date")})})
        Me.DaInv_Receive_product_Ap_Dtl.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl FROM GL_AP_payment INNER JOIN " & _
        "Inv_Receive_product_Ap_Dtl ON GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl = Inv_" & _
        "Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl WHERE (Inv_Receive_product_" & _
        "Ap_Dtl.id_receive_ref = @Id_receive_ref)"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_receive_ref", System.Data.SqlDbType.VarChar, 7, "id_receive_ref"))
        '
        'DaCheckForEdit
        '
        Me.DaCheckForEdit.SelectCommand = Me.SqlSelectCommand3
        Me.DaCheckForEdit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_AP_payment", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_AP_payment", "ID_AP_payment"), New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl_dtl", "Id_AP_bill_dtl_dtl"), New System.Data.Common.DataColumnMapping("ID_Inv_Receive_product_Ap_Dtl", "ID_Inv_Receive_product_Ap_Dtl"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("amount_pay", "amount_pay"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("date_prepare", "date_prepare"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("radif1", "radif1"), New System.Data.Common.DataColumnMapping("id_vendor_credit_head", "id_vendor_credit_head")})})
        '
        'DaCheckForEditReturn
        '
        Me.DaCheckForEditReturn.SelectCommand = Me.SqlCommand7
        Me.DaCheckForEditReturn.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_AP_payment", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_AP_payment", "ID_AP_payment"), New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl_dtl", "Id_AP_bill_dtl_dtl"), New System.Data.Common.DataColumnMapping("ID_Inv_Receive_product_Ap_Dtl", "ID_Inv_Receive_product_Ap_Dtl"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("amount_pay", "amount_pay"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("date_prepare", "date_prepare"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("radif1", "radif1"), New System.Data.Common.DataColumnMapping("id_vendor_credit_head", "id_vendor_credit_head")})})
        '
        'SqlCommand7
        '
        Me.SqlCommand7.CommandText = "SELECT id_receive_ref FROM GL_vendor_credit WHERE (id_receive_ref = @id_receive_r" & _
        "ef) AND (NOT (id_vendor_credit_head IS NULL))"
        Me.SqlCommand7.Connection = Me.Cnn
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_receive_ref", System.Data.SqlDbType.VarChar, 7, "id_receive_ref"))
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT id_vendor_credit, cod_vendor, date_credit, amount_credit, Remark, ref_no, " & _
        "due_date, id_vendor_credit_head, id_receive_ref FROM GL_vendor_credit WHERE (id_" & _
        "receive_ref = @id1)"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id1", System.Data.SqlDbType.VarChar, 6, "id_receive_ref"))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO GL_vendor_credit(cod_vendor, date_credit, amount_credit, Remark, ref_" & _
        "no, due_date, id_vendor_credit_head, id_receive_ref) VALUES (@cod_vendor, @date_" & _
        "credit, @amount_credit, @Remark, @ref_no, @due_date, @id_vendor_credit_head, @id" & _
        "_receive_ref); SELECT id_vendor_credit, cod_vendor, date_credit, amount_credit, " & _
        "Remark, ref_no, due_date, id_vendor_credit_head, id_receive_ref FROM GL_vendor_c" & _
        "redit WHERE (id_vendor_credit = @@IDENTITY)"
        Me.SqlInsertCommand3.Connection = Me.Cnn
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_credit", System.Data.SqlDbType.VarChar, 10, "date_credit"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_credit", System.Data.SqlDbType.Money, 8, "amount_credit"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Remark", System.Data.SqlDbType.VarChar, 100, "Remark"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ref_no", System.Data.SqlDbType.VarChar, 20, "ref_no"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@due_date", System.Data.SqlDbType.VarChar, 10, "due_date"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_vendor_credit_head", System.Data.SqlDbType.Int, 4, "id_vendor_credit_head"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_receive_ref", System.Data.SqlDbType.VarChar, 7, "id_receive_ref"))
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE GL_vendor_credit SET cod_vendor = @cod_vendor, date_credit = @date_credit," & _
        " amount_credit = @amount_credit, Remark = @Remark, ref_no = @ref_no, due_date = " & _
        "@due_date, id_vendor_credit_head = @id_vendor_credit_head, id_receive_ref = @id_" & _
        "receive_ref WHERE (id_vendor_credit = @Original_id_vendor_credit) AND (Remark = " & _
        "@Original_Remark OR @Original_Remark IS NULL AND Remark IS NULL) AND (amount_cre" & _
        "dit = @Original_amount_credit) AND (cod_vendor = @Original_cod_vendor) AND (date" & _
        "_credit = @Original_date_credit OR @Original_date_credit IS NULL AND date_credit" & _
        " IS NULL) AND (due_date = @Original_due_date OR @Original_due_date IS NULL AND d" & _
        "ue_date IS NULL) AND (id_receive_ref = @Original_id_receive_ref OR @Original_id_" & _
        "receive_ref IS NULL AND id_receive_ref IS NULL) AND (id_vendor_credit_head = @Or" & _
        "iginal_id_vendor_credit_head OR @Original_id_vendor_credit_head IS NULL AND id_v" & _
        "endor_credit_head IS NULL) AND (ref_no = @Original_ref_no OR @Original_ref_no IS" & _
        " NULL AND ref_no IS NULL); SELECT id_vendor_credit, cod_vendor, date_credit, amo" & _
        "unt_credit, Remark, ref_no, due_date, id_vendor_credit_head, id_receive_ref FROM" & _
        " GL_vendor_credit WHERE (id_vendor_credit = @id_vendor_credit)"
        Me.SqlUpdateCommand3.Connection = Me.Cnn
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_credit", System.Data.SqlDbType.VarChar, 10, "date_credit"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_credit", System.Data.SqlDbType.Money, 8, "amount_credit"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Remark", System.Data.SqlDbType.VarChar, 100, "Remark"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ref_no", System.Data.SqlDbType.VarChar, 20, "ref_no"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@due_date", System.Data.SqlDbType.VarChar, 10, "due_date"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_vendor_credit_head", System.Data.SqlDbType.Int, 4, "id_vendor_credit_head"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_receive_ref", System.Data.SqlDbType.VarChar, 7, "id_receive_ref"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_vendor_credit", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_vendor_credit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Remark", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Remark", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_credit", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_credit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_credit", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_credit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_due_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "due_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_receive_ref", System.Data.SqlDbType.VarChar, 7, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_receive_ref", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_vendor_credit_head", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_vendor_credit_head", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ref_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ref_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_vendor_credit", System.Data.SqlDbType.Int, 4, "id_vendor_credit"))
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM GL_vendor_credit WHERE (id_vendor_credit = @Original_id_vendor_credit" & _
        ") AND (Remark = @Original_Remark OR @Original_Remark IS NULL AND Remark IS NULL)" & _
        " AND (amount_credit = @Original_amount_credit) AND (cod_vendor = @Original_cod_v" & _
        "endor) AND (date_credit = @Original_date_credit OR @Original_date_credit IS NULL" & _
        " AND date_credit IS NULL) AND (due_date = @Original_due_date OR @Original_due_da" & _
        "te IS NULL AND due_date IS NULL) AND (id_receive_ref = @Original_id_receive_ref " & _
        "OR @Original_id_receive_ref IS NULL AND id_receive_ref IS NULL) AND (id_vendor_c" & _
        "redit_head = @Original_id_vendor_credit_head OR @Original_id_vendor_credit_head " & _
        "IS NULL AND id_vendor_credit_head IS NULL) AND (ref_no = @Original_ref_no OR @Or" & _
        "iginal_ref_no IS NULL AND ref_no IS NULL)"
        Me.SqlDeleteCommand3.Connection = Me.Cnn
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_vendor_credit", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_vendor_credit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Remark", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Remark", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_credit", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_credit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_credit", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_credit", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_due_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "due_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_receive_ref", System.Data.SqlDbType.VarChar, 7, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_receive_ref", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_vendor_credit_head", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_vendor_credit_head", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ref_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ref_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'DaGl_vendor_credit
        '
        Me.DaGl_vendor_credit.DeleteCommand = Me.SqlDeleteCommand3
        Me.DaGl_vendor_credit.InsertCommand = Me.SqlInsertCommand3
        Me.DaGl_vendor_credit.SelectCommand = Me.SqlSelectCommand5
        Me.DaGl_vendor_credit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_vendor_credit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_vendor_credit", "id_vendor_credit"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("date_credit", "date_credit"), New System.Data.Common.DataColumnMapping("amount_credit", "amount_credit"), New System.Data.Common.DataColumnMapping("Remark", "Remark"), New System.Data.Common.DataColumnMapping("ref_no", "ref_no"), New System.Data.Common.DataColumnMapping("due_date", "due_date"), New System.Data.Common.DataColumnMapping("id_vendor_credit_head", "id_vendor_credit_head"), New System.Data.Common.DataColumnMapping("id_receive_ref", "id_receive_ref")})})
        Me.DaGl_vendor_credit.UpdateCommand = Me.SqlUpdateCommand3
        '
        'FrmReceiveReturnProduct
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(751, 478)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PnlHead)
        Me.Controls.Add(Me.LblStoreNo)
        Me.Controls.Add(Me.LblCompanyName)
        Me.Name = "FrmReceiveReturnProduct"
        Me.Text = "Inventory Receipt /Return"
        Me.PnlHead.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DsFrmReceiveReturnProduct1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Global Variables"
    Dim WithEvents ClsRRP As ClsReceiveReturnProduct
    Dim RowNoToAdd As Integer = 50
    Dim BeforeCel As Integer = -1
    Dim BeforeRow As Integer = -1
    Dim BeforeRowEx As GridEXRow = Nothing
    Dim WithEvents ClsItem1 As UCInv_Item.Clsitem_no
    Dim WithEvents MyFrm1 As UCInv_Item.FrmSearchItemCode
    Dim J As Int64
    Dim i As Int64
    Dim CurrentCost As Decimal = 0
    Dim BeforeEditedDataset As New DSFrmReceiveReturnProduct
    Dim SALES_TAX As String
    Dim Sales_Tax_Amount As Decimal = 0
    Dim WithEvents FrmSelectPo As UcPurchaseOrder.FrmSelectPo
    Dim PoSelected As String = ""
    Dim WithEvents MyZipCode As UCZipCode.ClsZipCode
    Private MBillCredit As String = "1"
    Public CodReceiveReturnProduct As String = ""
    Public ShowPnlHead As Boolean = True
    Dim WithEvents MyFrmSearch1 As FrmSearchRecieptReturn
    Dim OldReferenceNo As String = ""
    Dim frmitem As New UCInv_Item.FrmItemProduct

    Public Property BillCredit() As String
        Get
            Return MBillCredit
        End Get
        Set(ByVal Value As String)
            MBillCredit = Value
        End Set
    End Property
#End Region
    Private Sub FrmReciveReturnProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        LblCompanyName.Text = PubCompanyName
        ClsRRP = New ClsReceiveReturnProduct
        ClsItem1 = New UCInv_Item.Clsitem_no
        ClsRRP.Connection = Cnn
        ClsItem1.Connection = Cnn
        ClsRRP.BillCredit = BillCredit
        LblStoreNo.Text = PubStoreName
        TxtDate.Text = Format(Now.Date, PubDateFormat)
        If CodReceiveReturnProduct <> "" Then
            TxtRef.Text = CodReceiveReturnProduct
            If Not ShowPnlHead Then
                PnlHead.Visible = False
                PnlHead.Enabled = False
                Me.Height = Me.Height - PnlHead.Height
            End If
        Else
            TxtRef.Text = ClsRRP.LastRecord
        End If
        MyZipCode = New UCZipCode.ClsZipCode
        MyZipCode.Connection = Me.Cnn
        Call LoadReciveReturnProduct(TxtRef.Text)
        Call EnableDisableField(False)
        DAGL_TAB_AR_TERM.Fill(DsFrmReceiveReturnProduct1)
        ThisFormStatus = MainModule.WorkStates._ReadOnly
        '    If TxtRef.Text.Trim & "" = "" Then
        'Call Paddnew()
        '   End If
        '-------------------------------
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        Dim SqlReader As System.Data.SqlClient.SqlDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable()
        SALES_TAX = OleDbReaderForStore.Item("Sales_tax") & ""
        CmdGeneral.CommandText = " Select * from cust_sales_tax where cod_sales_tax=" & Qt(SALES_TAX)
        CmdGeneral.Connection = Cnn
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        SqlReader = CmdGeneral.ExecuteReader
        If SqlReader.HasRows Then
            SqlReader.Read()
            Sales_Tax_Amount = SqlReader.Item("amount")
        Else
            Sales_Tax_Amount = 0
            MsgFar("Error There is No Sales Tax  for this store no " & SALES_TAX)
        End If
        SqlReader.Close()
        CmdGeneral.Connection.Close()
        OleDbReaderForStore.Close()
        Call SetBillCredit()
    End Sub
    Private Sub LoadReciveReturnProduct(ByVal ThisRefNo As String)
        'DsFrmReceiveReturnProduct1.Clear()
        Call ClearAllField()
        DaInv_Receive_Products_head.SelectCommand.Parameters("@id_receive_ref").Value = ThisRefNo
        DaInv_Receive_Products_head.Fill(DsFrmReceiveReturnProduct1.Inv_Receive_Products_head)
        DaGl_vendor_credit.SelectCommand.Parameters(0).Value = ThisRefNo
        Try
            DaInv_Receive_Products_Dtl.SelectCommand.Parameters("@id_receive_ref").Value = ThisRefNo
            DaInv_Receive_Products_Dtl.Fill(DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl)
            DaInv_Receive_product_Ap_Dtl.SelectCommand.Parameters("@ID_Inv_Receive_product_Ap_Dtl").Value = ThisRefNo
            DaInv_Receive_product_Ap_Dtl.Fill(DsFrmReceiveReturnProduct1.Inv_Receive_product_Ap_Dtl)
            DaGl_vendor_credit.Fill(DsFrmReceiveReturnProduct1.GL_vendor_credit)
        Catch ex As Exception
        End Try
        Call FillDataInScreen()
        Call CalculateTotal()
        Call CalcSumOfExt_price()
        For i = 0 To GrdDetail.RowCount
            Try
                With GrdDetail.GetRow
                    .Cells(7).Value = (Val(.Cells(4).Value & "") + Val(.Cells(5).Value & "")) * Val(.Cells(3).Value & "")
                End With
            Catch ex As Exception

            End Try
        Next
    End Sub
    Private Sub FillDataInScreen()
        With DsFrmReceiveReturnProduct1.Inv_Receive_Products_head
            If .Rows.Count > 0 Then
                TxtRef.Text = .Rows(0).Item("id_receive_ref") & ""
                'Vendor_Cod1.Text = ""
                TxtDate.Text = .Rows(0).Item("date_receive") & ""
                Vendor_Cod1.Text = .Rows(0).Item("cod_vendor")
                RbBill.Checked = IIf(.Rows(0).Item("bill_credit") & "" = "1", True, False)
                RbCredit.Checked = IIf(.Rows(0).Item("bill_credit") & "" = "2", True, False)
                ChkBillReceive.Checked = .Rows(0).Item("bill_receive")
                CmbApTerm.SelectedValue = .Rows(0).Item("ap_term")
                TxtRBDate.Text = .Rows(0).Item("receipt_bill_date")
                TxtVendorRefNo.Text = .Rows(0).Item("vendor_ref_no")
                TxtDueDate.Text = .Rows(0).Item("due_date")
                TxtDiscount.Text = .Rows(0).Item("Discount")
                PoSelected = .Rows(0).Item("po_no") & ""
                TxtTax.Text = Val(.Rows(0).Item("TAX") & "")
                If .Rows(0).Item("Prepaid") & "" = "" Then
                    .Rows(0).Item("Prepaid") = False
                End If
                ChkBefPaied.Checked = .Rows(0).Item("Prepaid")
                Me.ToolTip1.SetToolTip(SelectPo, PoSelected)
                CommentButton_House.ZCommentText = .Rows(0).Item("house_comments")
                CommentButton_Vendor.ZCommentText = .Rows(0).Item("vend_comments")
            End If
        End With
    End Sub
#Region "Clear Fields"
    Private Sub ClearAllField()
        Vendor_Cod1.Text = ""
        DsFrmReceiveReturnProduct1.Clear()
        DAGL_TAB_AR_TERM.Fill(DsFrmReceiveReturnProduct1)
        TxtRef.Clear()
        Txtaddress.Clear()
        Txtcontact1.Clear()
        Txtdesc_vendor.Clear()
        TxtDiscount.Text = "0.00"
        PhoneNo1.Text = ""
        TxtRBDate.Text = ""
        TxtVendorRefNo.Clear()
        TxtZipCode.Clear()
        TxtDate.Text = Format(Now.Date, PubDateFormat)
        TxtDiscount.Text = ""
        TxtRef.Clear()
        ClearTotals()
        CommentButton_Vendor.ZCommentText = ""
        CommentButton_House.ZCommentText = ""
        PoSelected = ""
        Me.ToolTip1.SetToolTip(SelectPo, "")
        Try
            CmbApTerm.SelectedValue = System.DBNull.Value
        Catch ex As Exception

        End Try
        TxtRBDate.Text = Format(Now.Date, PubDateFormat)
        TxtDueDate.Text = ""
        Select Case BillCredit
            Case "1"
                ChkBillReceive.Checked = True
            Case "2"
                ChkBillReceive.Checked = False
        End Select

    End Sub

    Sub ClearTotals()
        LblFET.Text = ""
        LblParts.Text = ""
        LblSubtotal.Text = ""
        LblTax.Text = ""
        LblTotal.Text = ""
        LblTotalQty.Text = ""
        LblwEIGHT.Text = ""
    End Sub
#End Region
    Private Sub CalcSumOfExt_price()
        LblParts.Text = "0.00" 'DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Compute("sum( Cost*Qty)", "Cost >=0")
        Dim TaxablePrice As Double = 0 'DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Compute("sum( Fet*Qty)", "Cost >=0")
        Dim TaxPercent As Double = 0
        ' ClearTotals()
    End Sub
    Private Sub AddEmptyRecordToDetail(ByVal ThisId As String, ByVal ThisRadif As Integer)
        Dim dr As DataRow
        dr = DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.NewRow
        dr("id_receive_ref") = ThisId
        dr("item_no") = ""
        dr("Taxable") = 0
        dr("cost") = 0
        dr("qty") = 0
        dr("FET") = 0
        DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Rows.Add(dr)
    End Sub
#Region "EnableDisable"

    Private Sub EnableDisableSave()

        Dim RowDetails As DataRow() = DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Select("trim(item_no) <> ''")

        If Vendor_Cod1.Text.Trim.Length > 0 And BtnNew.Enabled = False And RowDetails.Length > 0 Then
            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If
    End Sub
    Private Sub EnableDisableField(ByVal InStatus As Boolean)
        TxtDiscount.Enabled = InStatus
        TxtTax.Enabled = InStatus
        Vendor_Cod1.Enabled = InStatus
        GrdDetail.Enabled = InStatus
        CommentButton_House.ZEnabled = InStatus
        CommentButton_Vendor.ZEnabled = InStatus
        ChkBillReceive.Enabled = InStatus
        BtnCustomerDetail.Enabled = InStatus
        '        RbBill.Enabled = InStatus
        '       RbCredit.Enabled = InStatus
        CmbApTerm.Enabled = InStatus
        TxtDueDate.Enabled = False
        TxtVendorRefNo.Enabled = InStatus
        TxtRBDate.Enabled = InStatus
        SelectPo.Enabled = InStatus
        ChkBefPaied.Enabled = InStatus
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
#Region "GrdDetail"
    Sub AddEmptyRecordInDetail()
        Dim IFirstCount As Integer = DsFrmReceiveReturnProduct1.Inv_Receive_Products_head.Rows.Count()
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
                        If ClsItem1.FindDesc(ValueString) = False Then
                            MsgFar("Code is invalid")
                            GrdDetail.GetRow.Cells(1).Value = ""
                            Call SelectRow(CurrentRowGrid, 1)
                        Else

                            If CheckItemNoRepeat() = False Then
                                ClsItem1.FindItemCost(ValueString)
                            Else
                                GrdDetail.GetRow.Cells(1).Value = ""
                                MsgFar("Code is Repeated")
                            End If
                            'BeforeRowEx.Cells(2).Value = ClsItem1.desc_Item
                        End If
                    End If
                Case 3
                    If GrdDetail.GetRow.Cells(1).Value <> "" Then
                        If GrdDetail.RowCount > 0 Then
                            If Val(GrdDetail.GetRow.Cells(3).Value & "") <= 0 Then
                                MsgFar("Minus QTY is not Allowed in " & Me.Text.Trim & "s ." & vbCrLf & "Please Use " & IIf(BillCredit = "1", "IR-Inventory Return", "IR-Inventory Receipt") & " or Inventory Adjustment" & vbCrLf & "Or change minus QTY to Plus.")
                                GrdDetail.GetRow.Cells(3).Value = 0
                                Call SelectRow(CurrentRowGrid, 3)
                            End If
                        End If
                    End If
                Case 4
                    If CDec("0" & ValueString) <> CurrentCost Then
                        Dim c1 As New FrmWhatDoForMenu
                        c1.BtnLeftText = "yes"
                        c1.BtnRightText = "No"
                        c1.ShowFarMsg("Cost of  This Item is changed Do you want to Make This Change permanent?")
                        Select Case c1.DialogResult
                            Case DialogResult.OK ' Detail Add

                            Case Else 'Re enter
                                ClsItem1.ChangeCostThisItemNo(BeforeRowEx.Cells(1).Value & "", CurrentCost)
                        End Select
                    End If
                Case 6, 7 'QTY  ,  Price
                Case 8, 9
            End Select
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Try
            With GrdDetail.GetRow
                .Cells(7).Value = (Val(.Cells(4).Value & "") + Val(.Cells(5).Value & "")) * Val(.Cells(3).Value & "")
            End With
        Catch ex As Exception

        End Try
        Call CalculateTotal()
    End Sub
    Private Sub GrdDetail_CurrentCellChanging(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.CurrentCellChangingEventArgs) Handles GrdDetail.CurrentCellChanging
        Try
            CurrentCost = CDec("0" & GrdDetail.GetRow.Cells(4).Value)
        Catch ex As Exception
            CurrentCost = 0
        End Try

        Call EnableDisableSave()
        Call InitBeforeRow()
        Try
            With GrdDetail.GetRow
                .Cells(7).Value = (Val(.Cells(4).Value & "") + Val(.Cells(5).Value & "")) * Val(.Cells(3).Value & "")
            End With
        Catch ex As Exception

        End Try
        CalculateTotal()
    End Sub
    Private Sub GrdDetail_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.ColumnButtonClick
        Select Case e.Column.Index
            Case 0
                Call ShowSearch()
            Case 9
                frmitem.Item_noTempVar = GrdDetail.GetRow.Cells(1).Value & ""
                frmitem.ShowDialog()
        End Select

    End Sub
    Sub ShowSearch()
        MyFrm1 = New UCInv_Item.FrmSearchItemCode
        MyFrm1.ShowDialog()
        If GrdDetail.GetRow.Cells(1).Value & "" <> "" Then
            SelectRow(GrdDetail.Row, 3)
        End If
        'SelectRow(
    End Sub
    Sub InitBeforeRow()
        BeforeCel = GrdDetail.Col
        BeforeRow = GrdDetail.Row
        BeforeRowEx = GrdDetail.GetRow
    End Sub
#End Region
    Private Sub Vendor_Cod1_NotFindVendorCod() Handles Vendor_Cod1.NotFindVendorCod
        Txtaddress.Text = ""
        Txtcontact1.Text = ""
        Txtdesc_vendor.Text = ""
        TxtZipCode.Text = ""
        PhoneNo1.Text = ""
        Call PhoneButton1.ClearPhoneScreen()
        EnableDisableSave()
    End Sub
    Private Sub Vendor_Cod1_FindVendorNoRow(ByVal ThisRow As System.Data.DataRow) Handles Vendor_Cod1.FindVendorNoRow
        Txtaddress.Text = ThisRow.Item("address") & ""
        Txtcontact1.Text = ThisRow.Item("Contact1") & ""
        Txtdesc_vendor.Text = ThisRow.Item("Desc_vendor") & ""
        TxtZipCode.Text = ThisRow.Item("ZipCode") & ""
        PhoneButton1.FillDataSet("inv_vendor", "cod_vendor=" & Qt(Vendor_Cod1.Text))
        PhoneNo1.Text = PhoneButton1.FillPhoneNoMain()
        CmbApTerm.SelectedValue = ThisRow.Item("ap_terms") & ""
        Call ApplyDate()
        EnableDisableSave()
    End Sub
    Private Sub PhoneButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PhoneButton1.Click
        PhoneButton1.HeaderName = Vendor_Cod1.Desc_Vendor.Trim
    End Sub
    Private Sub ClsItem1_FindItemCostRow(ByVal ThisRow As System.Data.DataRow) Handles ClsItem1.FindItemCostRow
        If Trim(GrdDetail.GetRow.Cells(1).Value & "") <> "" Then
            If Val(GrdDetail.GetRow.Cells(5).Value & "") = 0 Then
                GrdDetail.GetRow.Cells(5).Value = Val(ThisRow.Item("Fet") & "")
            End If
            'GrdDetail.GetRow.Cells(5).Value = Val(ThisRow.Item("Fet") & "")
            If Val(GrdDetail.GetRow.Cells(4).Value & "") = 0 Then
                GrdDetail.GetRow.Cells(4).Value = ThisRow.Item("Cost") & ""
            End If
        End If
    End Sub
    Private Sub ClsItem1_FindItemNoRow(ByVal ThisRow As System.Data.DataRow) Handles ClsItem1.FindItemNoRow
        If Trim(GrdDetail.GetRow.Cells(1).Value & "") <> "" Then
            GrdDetail.GetRow.Cells(2).Value = ClsItem1.desc_Item & ""
            GrdDetail.GetRow.Cells(8).Value = CDec("0" & ThisRow("wieght_lbs"))
            GrdDetail.GetRow.Cells(5).Value = Val(ThisRow.Item("Fet") & "")
        End If
        EnableDisableSave()
    End Sub
    Private Sub ClsItem1_NotFindItemNo() Handles ClsItem1.NotFindItemNo
        GrdDetail.GetRow.Cells(2).Value = ""
        GrdDetail.GetRow.Cells(5).Value = 0
        GrdDetail.GetRow.Cells(4).Value = 0
    End Sub
    Private Sub MyFrm1_Item_noFind(ByVal ThisItemCode As String, ByVal ThisItemDesc As String) Handles MyFrm1.Item_noFind
        GrdDetail.GetRow.Cells(1).Value = ThisItemCode
        GrdDetail.GetRow.Cells(2).Value = ThisItemDesc
        EnableDisableSave()
        ' GrdDetail.Col = 4
    End Sub
    Function CheckItemNoRepeat() As Boolean
        CheckItemNoRepeat = False
        Dim i As Long
        Dim dr1 As DataRow()
        If GrdDetail.GetRow.Cells(1).Value & "" <> "" Then
            GrdDetail.UpdateData()
            dr1 = DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Select("trim( item_no) =" & Qt(GrdDetail.GetRow.Cells(1).Value))
            If dr1.Length >= 2 Then
                CheckItemNoRepeat = True
            End If
        End If
    End Function
    Public Sub CalculateTotal()

        'Dim SQty As Decimal = 0
        'Dim SCost As Decimal = 0
        'Dim SFet As Decimal = 0
        'Try
        '    Try
        '        SQty = CDec("0" & ThisDataset.Inv_Receive_product_dtl.Compute("sum(Qty)", " trim(Item_no) <> ''"))
        '    Catch ex As Exception

        '    End Try

        '    Dim Sum1 As Decimal = 0
        '    Dim SumFet1 As Decimal = 0
        '    Dim SumTax As Decimal = 0
        '    Dim rowsBackup As Integer = 0
        '    Try

        '        With ThisDataset.Inv_Receive_product_dtl
        '            For i = 0 To ThisDataset.Inv_Receive_product_dtl.Rows.Count - 1
        '                If ThisDataset.Inv_Receive_product_dtl.Rows(i).RowState <> DataRowState.Deleted Then

        '                    Sum1 = .Rows(i).Item("Cost") * .Rows(i).Item("qty") + Sum1
        '                    SumFet1 = .Rows(i).Item("fet") * .Rows(i).Item("qty") + SumFet1
        '                    If .Rows(i).Item("taxable") = True Then
        '                        SumTax = Math.Round((.Rows(i).Item("Cost") * .Rows(i).Item("qty")) * Sales_Tax_Amount / 100, 2) + SumTax
        '                    End If
        '                End If
        '            Next
        '        End With
        '    Catch ex As Exception

        '    End Try
        Try
            ClsItem1.CalculateSumReceive(DsFrmReceiveReturnProduct1, Sales_Tax_Amount)
        Catch ex As Exception

        End Try


        '            LblTax.Text = CDec("0" & DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Compute("Max(Tax)", " trim(Item_no) <> ''"))
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
    End Sub
    Private Sub ClsItem1_AfterCalculateSumReceived(ByVal SumParts As Decimal, ByVal Sumfet1 As Decimal, ByVal SumTax As Decimal, ByVal SumTotal As Decimal, ByVal SumTotalQty As Decimal, ByVal SumW As Decimal) Handles ClsItem1.AfterCalculateSumReceived
        LblParts.Text = Format(CType(SumParts, Decimal), "C").Replace("$", "").Replace("—Ì«·", "") 'CDec("0" & DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Compute("sum(Cost*qty)", " trim(Item_no) <> ''"))  '   SQty * SCost
        LblFET.Text = Format(CType(Sumfet1, Decimal), "C").Replace("$", "").Replace("—Ì«·", "")
        LblSubtotal.Text = Format(CType(SumParts + Sumfet1, Decimal), "C").Replace("$", "").Replace("—Ì«·", "")
        LblTax.Text = Format(CType(SumTax, Decimal), "C").Replace("$", "").Replace("—Ì«·", "")
        '        LblTotal.Text = Format(CDec(Val(LblSubtotal.Text & "") + SumTax - Val(TxtDiscount.Text & "")), "C").Replace("$", "").Replace("—Ì«·", "")    'Format(CType(SumTotal, Decimal), "C").Replace("$", "").Replace("—Ì«·", "")
        Call CalculateTotal1()
        LblTotalQty.Text = Format(CType(SumTotalQty, Decimal), "C").Replace("$", "").Replace("—Ì«·", "")
        LblwEIGHT.Text = Format(CType(SumW, Decimal), "C").Replace("$", "").Replace("—Ì«·", "")


        LblParts.Text = LblParts.Text.Replace("—Ì«·", "") 'CDec("0" & DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Compute("sum(Cost*qty)", " trim(Item_no) <> ''"))  '   SQty * SCost
        LblFET.Text = LblFET.Text.Replace("—Ì«·", "")
        LblSubtotal.Text = LblSubtotal.Text.Replace("—Ì«·", "")
        LblTax.Text = LblTax.Text.Replace("—Ì«·", "")
        LblTotal.Text = LblTotal.Text.Replace("—Ì«·", "")
        LblTotalQty.Text = LblTotalQty.Text.Replace("—Ì«·", "")
        LblwEIGHT.Text = LblwEIGHT.Text.Replace("—Ì«·", "")
    End Sub


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
        BeforeEditedDataset.Clear()
        ThisFormStatus = MainModule.WorkStates.AddNew
        Call EnableDisableField(True)
        Call EnableDisableBtn()
        Call ClearAllField()
        TxtRef.Text = ClsRRP.MakeNewReceiveCod()
        TxtDate.Text = Format(Now.Date, PubDateFormat)
        OldReferenceNo = TxtRef.Text
        Call AddEmptyRecordInDetail()
        Call ApplyDate()
        Vendor_Cod1.Focus()
    End Sub
    Sub Psave()
        Dim Dr As DataRow
        Dim flg As Boolean = False
        Dim flgchangedid As Boolean = False

        Try
            If DsFrmReceiveReturnProduct1.Inv_Receive_Products_head.Rows.Count <= 0 Then
                Dr = DsFrmReceiveReturnProduct1.Inv_Receive_Products_head.NewRow()
                flg = True
            Else
                Dr = DsFrmReceiveReturnProduct1.Inv_Receive_Products_head.Rows(0)
            End If

            Dr("id_receive_ref") = TxtRef.Text.Trim
            Dr("cod_vendor") = Vendor_Cod1.Text
            Dr("date_receive") = TxtDate.Text
            Dr("bill_credit") = IIf(RbBill.Checked, "1", "2")
            Dr("bill_receive") = ChkBillReceive.Checked
            Dr("ap_term") = CmbApTerm.SelectedValue
            Dr("receipt_bill_date") = TxtRBDate.Text
            Dr("vendor_ref_no") = TxtVendorRefNo.Text.Trim
            Dr("due_date") = TxtDueDate.Text
            Dr("po_no") = PoSelected
            Dr("Prepaid") = ChkBefPaied.Checked
            Me.ToolTip1.SetToolTip(SelectPo, PoSelected)
            Dr("Discount") = CDec("0" & TxtDiscount.Text)
            Dr("house_comments") = CommentButton_House.ZCommentText
            Dr("vend_comments") = CommentButton_Vendor.ZCommentText
            Dr("TAX") = Math.Round(Val(TxtTax.Text & ""), 2)
            If flg Then
                DsFrmReceiveReturnProduct1.Inv_Receive_Products_head.AddInv_Receive_Products_headRow(Dr)
            End If
            '            #region "delete empty row"
            If Not ChkBefPaied.Checked Then
                Select Case BillCredit
                    Case "1"
                        Call MakeApDtl()
                    Case "2" 'return
                        Call MakeCredit()
                End Select
            Else ' If Checked and edited then credit should delete
                Select Case BillCredit
                    Case "1"
                    Case "2" 'return
                        Call DeleteCredit()
                End Select
            End If
            Try
                SelectRow(0, 1)
            Catch ex As Exception
            End Try
            Dim i As Long
            Dim dr1 As DataRow()
            dr1 = DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Select("trim( item_no) =''")
            For i = 0 To dr1.Length - 1
                dr1(i).Delete()
            Next

            dr1 = DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Select("item_no is null")
            For i = 0 To dr1.Length - 1
                dr1(i).Delete()
            Next
            '------------------------------------------------------
            Try
                For i = 0 To 10
                    Try
                        DaInv_Receive_Products_head.Update(DsFrmReceiveReturnProduct1)
                        Exit For
                    Catch ex As Exception
                        If flg Then
                            TxtRef.Text = Trim(ClsRRP.MakeNewReceiveCod & "")

                            DsFrmReceiveReturnProduct1.Inv_Receive_Products_head.Rows(0).Item("id_receive_ref") = TxtRef.Text.Trim
                            flgchangedid = True
                        Else
                            MsgBox(EX.ToString)
                        End If
                    End Try
                Next
                For i = 0 To DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Count - 1
                    With DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl
                        If .Rows(i).RowState <> DataRowState.Deleted Then
                            .Rows(i).Item("id_receive_ref") = TxtRef.Text
                        End If
                    End With
                Next
                DaInv_Receive_Products_Dtl.Update(DsFrmReceiveReturnProduct1)
                DaInv_Receive_product_Ap_Dtl.Update(DsFrmReceiveReturnProduct1)
                'If ChkBefPaied.Checked Then
                '    ClsRRP.DeleteGlVendorReceiveRef(TxtRef.Text.Trim)
                'Else
                DaGl_vendor_credit.Update(DsFrmReceiveReturnProduct1)
                'End If

                Call UpdateQtyInItems(True)
                '               End If
                If flgchangedid = True Then
                    Dim MyFrmShowChangedNo As New FrmShowChangedNo
                    MyFrmShowChangedNo.LblNewNo.Text = TxtRef.Text
                    MyFrmShowChangedNo.LblOldNo.Text = OldReferenceNo
                    MyFrmShowChangedNo.ShowDialog()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
                'MsgFar("Error In Update ")
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
        TxtRef.Text = ClsRRP.LastRecord
        Call LoadReciveReturnProduct(TxtRef.Text)
    End Sub
    Sub PEdit()
        If CanEdit() Then
            BeforeEditedDataset.Clear()
            BeforeEditedDataset = DsFrmReceiveReturnProduct1.Copy()
            ' Get A Copy Of Dataset
            Dim AddEmptyRecordToDetailCount As Integer
            Dim IFirstCount As Integer   'Dsfrm..Rows.Count()
            If TxtRef.Text.Trim.Length > 0 Then
                ThisFormStatus = MainModule.WorkStates.Edit
                Call EnableDisableField(True)
                Call EnableDisableBtn()
                IFirstCount = DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Rows.Count()
                For AddEmptyRecordToDetailCount = 1 + IFirstCount To RowNoToAdd + IFirstCount
                    Call AddEmptyRecordToDetail(TxtRef.Text, AddEmptyRecordToDetailCount)
                Next
            End If
            Vendor_Cod1.Focus()
            Call ApplyDate()
        Else
        End If
    End Sub
    Sub PDelete()
        BeforeEditedDataset.Clear()
        BeforeEditedDataset = DsFrmReceiveReturnProduct1.Copy()
        If TxtRef.Text.Trim.Length > 0 Then
            ThisFormStatus = MainModule.WorkStates.Delete
            Dim c1 As New FrmWhatDoForMenu
            c1.BtnLeftText = "Cancel"
            c1.BtnRightText = "Delete"
            c1.ShowFarMsg("Are you sure?")
            If c1.DialogResult = DialogResult.OK Then
                Dim TxtRefTemp As String = TxtRef.Text
                If ClsRRP.DeleteThis(TxtRef.Text) Then
                    Call UpdateQtyInItems(False)
                    Call PPreviousRecord(False)
                    If TxtRefTemp = TxtRef.Text Then
                        Call PNextRecord(False)
                        If TxtRefTemp = TxtRef.Text Then
                            Call ClearAllField()
                        End If
                    End If
                End If
            Else
                Vendor_Cod1.Focus()
            End If
            ThisFormStatus = MainModule.WorkStates._ReadOnly
        End If
    End Sub
#End Region
#Region "Previos-Last-Frist"
    Private Sub PFirstRecord(Optional ByVal ShowMsgFlag As Boolean = True)
        Try
            If TxtRef.Text.Trim.Length > 0 Then
                Dim TXTRef_NoTmp As String = ClsRRP.PFirstRecord()
                If TXTRef_NoTmp = TxtRef.Text Then
                    If ShowMsgFlag Then MsgFar("First Record")
                Else
                    Call LoadReciveReturnProduct(TXTRef_NoTmp)
                End If
            Else
                MsgFar("There is no Row in Database")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PLastRecord(Optional ByVal ShowMsgFlag As Boolean = True)
        Try
            If TxtRef.Text.Trim.Length > 0 Then
                Dim TXTRef_NoTmp As String = ClsRRP.LastRecord()
                If TXTRef_NoTmp = TxtRef.Text Then
                    If ShowMsgFlag Then MsgFar("Last Record")
                Else
                    Call LoadReciveReturnProduct(TXTRef_NoTmp)
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
                Dim TXTRef_NoTmp As String = ClsRRP.Pprevious(TxtRef.Text.Trim)
                If TXTRef_NoTmp.Trim = TxtRef.Text.Trim Or TXTRef_NoTmp.Trim.Length = 0 Then
                    If ShowMsgFlag Then MsgFar("First Record")
                Else
                    Call LoadReciveReturnProduct(TXTRef_NoTmp)
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
                Dim TXTRef_NoTmp As String = ClsRRP.PNext(TxtRef.Text)
                If TXTRef_NoTmp.Trim = TxtRef.Text.Trim Or TXTRef_NoTmp.Trim.Length = 0 Then
                    If ShowMsgFlag Then MsgFar("Last Record")
                Else
                    Call LoadReciveReturnProduct(TXTRef_NoTmp)
                End If
            Else
                MsgFar("There is no Row in Database")
            End If
        Catch ex As Exception
        End Try
    End Sub

#End Region
    Sub UpdateQtyInItems(ByVal flag1 As Boolean)
        Dim ItmNo As String = ""
        Dim qty As Decimal = 0
        '-----------------------------------
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            If PoSelected <> "" Then
                DsFrmReceiveReturnProduct1.Inv_purchase_order_dtl2.Clear()
                DaPo.SelectCommand.Parameters(0).Value = PoSelected
                DaPo.Fill(DsFrmReceiveReturnProduct1.Inv_purchase_order_dtl2)
            End If
            If RbBill.Checked = True Then ' receive
                With BeforeEditedDataset
                    For i = 0 To .Inv_Receive_product_dtl.Rows.Count - 1
                        If .Inv_Receive_product_dtl.Rows(i).RowState <> DataRowState.Deleted Then
                            ItmNo = .Inv_Receive_product_dtl.Rows(i).Item("item_no") & ""
                            qty = .Inv_Receive_product_dtl.Rows(i).Item("QTY")
                            If ItmNo.Trim <> "" Then
                                CmdGeneral.CommandText = "update inv_Tab_item_Warehouse  set  on_hand = on_hand -  " & qty & " where Item_No= " & Qt(ItmNo.Trim) & " And cod_warehouse = " & Qt(PWareHouse)
                                CmdGeneral.ExecuteNonQuery()
                            End If
                        End If
                    Next
                    'œ— Ìò „” ‰œ Õ„Ìœ ê›  òÂ on_order  €ÌÌ—Ì ‰„Ìò‰œ 
                    'For i = 0 To DsFrmReceiveReturnProduct1.Inv_purchase_order_dtl2.Count - 1
                    '    Dim dr12() As DataRow = BeforeEditedDataset.Inv_Receive_product_dtl.Select("Item_no = " & Qt(DsFrmReceiveReturnProduct1.Inv_purchase_order_dtl2.Rows(i).Item("Item_no")))
                    '    If dr12.LongLength > 0 Then
                    '        ItmNo = dr12(0).Item("item_no") & ""
                    '        qty = dr12(0).Item("qty")
                    '        CmdGeneral.CommandText = "update inv_Tab_item_Warehouse  set  on_order = on_order +  " & qty & " where Item_No= " & Qt(ItmNo.Trim) & " And cod_warehouse = " & Qt(PWareHouse)
                    '        CmdGeneral.ExecuteNonQuery()
                    '    End If
                    'Next
                End With

                With DsFrmReceiveReturnProduct1
                    For i = 0 To .Inv_Receive_product_dtl.Rows.Count - 1
                        If .Inv_Receive_product_dtl.Rows(i).RowState <> DataRowState.Deleted Then
                            ItmNo = .Inv_Receive_product_dtl.Rows(i).Item("item_no") & ""
                            If ItmNo.Trim & "" <> "" Then
                                Try
                                    CmdGeneral.CommandText = "insert into  inv_item_vendor (item_no,cod_vendor,ven_part_no,remark) values( " & Qt(.Inv_Receive_product_dtl.Rows(i).Item("item_no")) & " , " & Qt(Vendor_Cod1.Text) & ",'','' )"
                                    CmdGeneral.ExecuteNonQuery()
                                Catch ex As Exception
                                End Try
                            End If
                        End If
                    Next
                End With


                If flag1 Then
                    With DsFrmReceiveReturnProduct1
                        For i = 0 To .Inv_Receive_product_dtl.Rows.Count - 1
                            If .Inv_Receive_product_dtl.Rows(i).RowState <> DataRowState.Deleted Then
                                ItmNo = .Inv_Receive_product_dtl.Rows(i).Item("item_no") & ""
                                qty = .Inv_Receive_product_dtl.Rows(i).Item("QTY")
                                If ItmNo.Trim <> "" Then
                                    CmdGeneral.CommandText = "update inv_Tab_item_Warehouse  set  on_hand = on_hand +  " & qty & " where Item_No= " & Qt(ItmNo.Trim) & " And cod_warehouse = " & Qt(PWareHouse)
                                    CmdGeneral.ExecuteNonQuery()
                                End If
                            End If
                        Next
                        'œ— Ìò „” ‰œ Õ„Ìœ ê›  òÂ on_order  €ÌÌ—Ì ‰„Ìò‰œ 
                        'For i = 0 To DsFrmReceiveReturnProduct1.Inv_purchase_order_dtl2.Count - 1
                        '    Dim dr12() As DataRow = DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Select("Item_no = " & Qt(DsFrmReceiveReturnProduct1.Inv_purchase_order_dtl2.Rows(i).Item("Item_no")))
                        '    If dr12.LongLength > 0 Then
                        '        ItmNo = dr12(0).Item("item_no") & ""
                        '        qty = dr12(0).Item("qty")
                        '        CmdGeneral.CommandText = "update inv_Tab_item_Warehouse  set  on_order = on_order -  " & qty & " where Item_No= " & Qt(ItmNo.Trim) & " And cod_warehouse = " & Qt(PWareHouse)
                        '        CmdGeneral.ExecuteNonQuery()
                        '    End If
                        'Next
                    End With

                End If
            End If
            '-----------------------------------------
            If RbCredit.Checked = True Then
                With BeforeEditedDataset
                    For i = 0 To .Inv_Receive_product_dtl.Rows.Count - 1
                        If .Inv_Receive_product_dtl.Rows(i).RowState <> DataRowState.Deleted Then
                            ItmNo = .Inv_Receive_product_dtl.Rows(i).Item("item_no") & ""
                            qty = .Inv_Receive_product_dtl.Rows(i).Item("Qty")
                            If ItmNo.Trim <> "" Then
                                CmdGeneral.CommandText = "update inv_Tab_item_Warehouse  set  on_hand = on_hand +  " & qty & " where Item_No= " & Qt(ItmNo.Trim) & " And cod_warehouse = " & Qt(PWareHouse)
                                CmdGeneral.ExecuteNonQuery()
                            End If

                        End If
                    Next
                End With
                If flag1 Then
                    With DsFrmReceiveReturnProduct1
                        For i = 0 To .Inv_Receive_product_dtl.Rows.Count - 1
                            If .Inv_Receive_product_dtl.Rows(i).RowState <> DataRowState.Deleted Then
                                ItmNo = .Inv_Receive_product_dtl.Rows(i).Item("item_no") & ""
                                qty = .Inv_Receive_product_dtl.Rows(i).Item("Qty")
                                If ItmNo.Trim <> "" Then
                                    CmdGeneral.CommandText = "update inv_Tab_item_Warehouse  set  on_hand = on_hand -  " & ChangeNumber(qty) & " where Item_No= " & Qt(ItmNo.Trim) & " And cod_warehouse = " & Qt(PWareHouse)
                                    CmdGeneral.ExecuteNonQuery()
                                End If
                            End If
                        Next
                    End With
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#Region "All Text Changed"
    Private Sub RbBill_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbBill.CheckedChanged
        EnableDisableSave()
    End Sub

    Private Sub ChkBillReceive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkBillReceive.CheckedChanged
        EnableDisableSave()
    End Sub

    Private Sub CmbApTerm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbApTerm.SelectedIndexChanged
        EnableDisableSave()
    End Sub

    Private Sub CmbApTerm_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbApTerm.SelectedValueChanged
        EnableDisableSave()
        Call ApplyDate()
    End Sub
    Private Sub TxtRBDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtRBDate.TextChanged, TxtVendorRefNo.TextChanged, TxtDueDate.TextChanged
        EnableDisableSave()
        ApplyDate()
    End Sub
#End Region
    Private Sub SelectPo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectPo.Click
        FrmSelectPo = New UcPurchaseOrder.FrmSelectPo
        FrmSelectPo.vendore = Vendor_Cod1.cod_vendor
        SendKeys.Send("{tab}")
        FrmSelectPo.ShowDialog()
    End Sub
    Private Sub LoadThisPo(ByVal ThisPo As String) Handles FrmSelectPo.LoadThisPo
        Dim i As Int64
        PoSelected = ThisPo
        Me.ToolTip1.SetToolTip(SelectPo, PoSelected)
        DsFrmReceiveReturnProduct1.Inv_purchase_order_dtl.Clear()
        DaPoDetail.SelectCommand.Parameters(0).Value = ThisPo
        DaPoDetail.Fill(DsFrmReceiveReturnProduct1.Inv_purchase_order_dtl)
        '  DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Clear()

        Try
            Dim dr1 As DataRow()
            dr1 = DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Select("trim( item_no) =''")
            For i = 0 To dr1.Length - 1
                dr1(i).Delete()
            Next
            dr1 = DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Select("trim( item_no) <>''")
            For i = 0 To dr1.Length - 1
                dr1(i).Delete()
            Next
            For i = 0 To DsFrmReceiveReturnProduct1.Inv_purchase_order_dtl.Rows.Count - 1
                Dim Dr As DSFrmReceiveReturnProduct.Inv_Receive_product_dtlRow
                Dim Dr2 As DSFrmReceiveReturnProduct.Inv_purchase_order_dtlRow = DsFrmReceiveReturnProduct1.Inv_purchase_order_dtl.Rows(i)
                Dr = DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.NewInv_Receive_product_dtlRow
                Dr.item_no = Dr2.item_no
                Dr.desc_item = Dr2.desc_item
                Dr.qty = Dr2.qty
                Dr.fet = Dr2.fet
                Dr.cost = Dr2.cost
                Dr.taxable = Dr2.taxable
                Dr.id_receive_ref = TxtRef.Text.Trim
                Vendor_Cod1.Text = Dr2.cod_vendor & ""
                Try
                    DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.AddInv_Receive_product_dtlRow(Dr)
                Catch ex As Exception
                End Try
            Next
            Call AddEmptyRecordInDetail()
            For i = 0 To GrdDetail.RowCount
                Try
                    With GrdDetail.GetRow(i)
                        .Cells(7).Value = (Val(.Cells(4).Value & "") + Val(.Cells(5).Value & "")) * Val(.Cells(3).Value & "")
                    End With
                Catch ex As Exception

                End Try
            Next
            GrdDetail.Refetch()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub BtnFax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFax.Click
        Call pprint("fax")
    End Sub
    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Call pprint("print")
    End Sub

    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        Call pprint("priv")
    End Sub
    Private Sub pprint(ByVal PrintType As String)

        If ThisFormStatus = MainModule.WorkStates.AddNew Or ThisFormStatus = MainModule.WorkStates.Edit Then
            MsgFar("Please Save Before Printing")
            Exit Sub
        End If

        If DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Rows.Count > 0 Then
            Dim rpt As New RepRecieptReturnProduct
            Dim prn As New FrmRepView

            rpt.SetParameterValue("ParStoreShortName", PubStoreName & "")

            Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
            OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)

            If BillCredit = "1" Then
                rpt.SetParameterValue("ParLblDate", "Recieve Date")
                rpt.SetParameterValue("ParLblNo", "Receipt No.")
                Try
                    If OleDbReaderForStore.Item("InventoryReceiptsShading") = 0 Then
                        rpt.SetParameterValue("ShadingParam", True)
                    Else
                        rpt.SetParameterValue("ShadingParam", False)
                    End If
                Catch ex As Exception
                    rpt.SetParameterValue("ShadingParam", False)
                End Try
            Else
                rpt.SetParameterValue("ParLblDate", "Return Date")
                rpt.SetParameterValue("ParLblNo", "Return No.")
                Try
                    If OleDbReaderForStore.Item("InventoryReturnsShading") = 0 Then
                        rpt.SetParameterValue("ShadingParam", True)
                    Else
                        rpt.SetParameterValue("ShadingParam", False)
                    End If
                Catch ex As Exception
                    rpt.SetParameterValue("ShadingParam", False)
                End Try
            End If

            rpt.SetParameterValue("Parconame", OleDbReaderForStore.Item("STORENAME") & "")
            rpt.SetParameterValue("Parcoaddress", OleDbReaderForStore.Item("ADDRESS") & "")

            MyZipCode.ZipCode = OleDbReaderForStore.Item("ZipCode")
            MyZipCode.FindDesc(OleDbReaderForStore.Item("ZipCode"))
            rpt.SetParameterValue("Parcoaddress2", MyZipCode.City & " " & MyZipCode.State & " " & MyZipCode.ZipCode & "")

            rpt.SetParameterValue("Parcophone", OleDbReaderForStore.Item("PHONE") & "")
            rpt.SetParameterValue("Parcofax", OleDbReaderForStore.Item("FAX") & "")
            rpt.SetParameterValue("Parcoemail", OleDbReaderForStore.Item("EMAIL") & "")

            DsFrmReceiveReturnProduct1.LOGO.Clear()
            Dim OleDbReaderForCompany As System.Data.OleDb.OleDbDataReader
            OleDbReaderForCompany = RetrieveCompanySetupTable()
            Try
                DsFrmReceiveReturnProduct1.LOGO.AddLOGORow(OleDbReaderForCompany.Item("LOGO"), "l")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            rpt.SetParameterValue("Parcowebsite", OleDbReaderForCompany.Item("WEBPAGE"))
            rpt.SetParameterValue("parveno", Vendor_Cod1.Text)
            rpt.SetParameterValue("pardate", TxtDate.Text)
            rpt.SetParameterValue("partime", Format(TimeOfDay, "Short Time"))
            rpt.SetParameterValue("parno", TxtRef.Text)

            MyZipCode.ZipCode = TxtZipCode.Text
            MyZipCode.FindDesc(TxtZipCode.Text)
            rpt.SetParameterValue("parname", Txtdesc_vendor.Text)
            rpt.SetParameterValue("paraddress", Txtaddress.Text)
            rpt.SetParameterValue("paraddress2", MyZipCode.City & " " & MyZipCode.State & " " & MyZipCode.ZipCode & "")
            rpt.SetParameterValue("parphone", PhoneNo1.Text)

            rpt.SetParameterValue("parveinno", TxtVendorRefNo.Text)
            rpt.SetParameterValue("parveindate", TxtRBDate.Text)
            rpt.SetParameterValue("parinduedate", TxtDueDate.Text)
            rpt.SetParameterValue("parveterm", CmbApTerm.Text)
            rpt.SetParameterValue("parponumber", PoSelected & "")
            rpt.SetParameterValue("parhousecomment", CommentButton_House.ZCommentText)
            rpt.SetParameterValue("parvendorcomment", CommentButton_Vendor.ZCommentText)

            rpt.SetParameterValue("parpart", LblParts.Text)
            rpt.SetParameterValue("partotalqty", LblTotalQty.Text)
            rpt.SetParameterValue("parfet", LblFET.Text)
            rpt.SetParameterValue("partotalw", LblwEIGHT.Text)
            rpt.SetParameterValue("parsubtotal", LblSubtotal.Text)
            rpt.SetParameterValue("partax", LblTax.Text)
            rpt.SetParameterValue("partotal", LblTotal.Text)

            Select Case BillCredit
                Case "1"
                    rpt.SetParameterValue("parkindrep", "Inventory Receipt")
                Case "2"
                    rpt.SetParameterValue("parkindrep", "Inventory Return")
                Case Else
                    rpt.SetParameterValue("parkindrep", "Unknown")
            End Select

            rpt.SetDataSource(DsFrmReceiveReturnProduct1)
            Select Case PrintType
                Case "print"
                    rpt.PrintToPrinter(1, True, 0, 0)
                Case "priv"
                    prn.CrViewer.ReportSource = rpt
                    prn.ShowDialog()
                Case "fax"
                    Try
                        rpt.PrintOptions.PrinterName = "Fax"
                        rpt.PrintToPrinter(1, True, 0, 0)
                    Catch ex As Exception
                        MsgBox("Add The FAX in (Printers and Faxes)")
                    End Try
            End Select
        End If
    End Sub
    Sub SetBillCredit()
        RbBill.Enabled = False
        RbCredit.Enabled = False
        Select Case BillCredit
            Case "1"
                RbCredit.Checked = False
                RbBill.Checked = True
                LblName.Text = "IR-Inventory Receipt"
                Me.Text = "IR-Inventory Receipt"
            Case "2"
                RbBill.Checked = False
                RbCredit.Checked = True
                LblName.Text = "IR-Inventory Return"
                Me.Text = "IR-Inventory Return"
        End Select
    End Sub
    Function ChangeNumber(ByVal ThisNumber As Decimal) As String
        If ThisNumber < 0 Then
            ChangeNumber = "(" & ThisNumber & ")"
        Else
            ChangeNumber = ThisNumber & ""
        End If
    End Function
    Private Sub BtnCustomerDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCustomerDetail.Click
        Dim MyFrmVendore As New UCVendor.FrmVendor
        MyFrmVendore.VendorCodTempVar = Vendor_Cod1.Text
        MyFrmVendore.ShowDialog()
        'Vendor_Cod1.Text = MyFrmVendore.Cod_VendorVar
    End Sub
    Private Sub TxtDiscount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDiscount.TextChanged
        Call CalculateTotal1()
    End Sub
    Sub CalculateTotal1()
        Try
            LblTotal.Text = Format(CType(CDec(LblSubtotal.Text) + CDec(LblTax.Text) - CDec(TxtDiscount.Text), Decimal), "C").Replace("$", "").Replace("—Ì«·", "")       'Format(CType(SumTotal, Decimal), "C").Replace("$", "").Replace("—Ì«·", "")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GrdDetail_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles GrdDetail.UpdatingCell

        Try
            With GrdDetail.GetRow
                .Cells(7).Value = (Val(.Cells(4).Value & "") + Val(.Cells(5).Value & "")) * Val(.Cells(3).Value & "")
            End With
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GrdDetail_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GrdDetail.UpdatingRecord

        Try
            With GrdDetail.GetRow
                .Cells(7).Value = (Val(.Cells(4).Value & "") + Val(.Cells(5).Value & "")) * Val(.Cells(3).Value & "")
            End With
        Catch ex As Exception
        End Try
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Call InsertThisRow(GrdDetail.Row)
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Call DeleteThisRow()
    End Sub
    Sub DeleteThisRow()
        Dim i As Integer, j As Integer
        Dim Currentrow As Int64 = GrdDetail.Row
        Dim drow As DataRow() = DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Select("id_receive_ref =" & Qt(TxtRef.Text.Trim) & " and item_no = " & Qt(GrdDetail.GetRow.Cells(1).Value & ""))
        If drow.LongLength > 0 Then
            drow(0).Delete()
        End If
        GrdDetail.UpdateData()
        Call AddEmptyRecordToDetail(TxtRef.Text, 1)
        GrdDetail.Refetch()
        GrdDetail.Row = Currentrow
        EnableDisableSave()
    End Sub
    Sub InsertThisRow(ByVal InTHisPosition As Integer)
        Dim Currentrow As Int64 = InTHisPosition 'GrdDetail.Row
        Dim Item_no As String = ""
        Call AddEmptyRecordToDetail(TxtRef.Text, 1)
        Dim i As Integer = 0
        Dim j As Integer = 0
        For i = DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Rows.Count - 1 To Currentrow Step -1
            With DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl
                For j = 0 To 7
                    Try
                        .Rows(i).Item(j) = .Rows(i - 1).Item(j)
                    Catch ex As Exception
                    End Try

                Next
            End With
        Next

        Dim dr1 As DataRow() = DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Select("item_no = " & Qt(GrdDetail.GetRow.Cells(1).Value))
        If dr1.Length > 0 Then
            With dr1(0)
                .Item("id_receive_ref") = TxtRef.Text
                .Item("item_no") = ""
                .Item("desc_item") = ""
                .Item("Taxable") = 0
                .Item("cost") = 0
                .Item("qty") = 0
                .Item("fet") = 0
                .Item("wieght_lbs") = 0

            End With
        End If

        'If DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Rows(Currentrow).RowState <> DataRowState.Deleted Then
        '    With DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Rows(Currentrow)
        '        .Item("id_receive_ref") = TxtRef.Text
        '        .Item("item_no") = ""
        '        .Item("desc_item") = ""
        '        .Item("Taxable") = 0
        '        .Item("cost") = 0
        '        .Item("qty") = 0
        '        .Item("fet") = 0
        '        .Item("wieght_lbs") = 0
        '    End With
        'End If
        GrdDetail.UpdateData()
        GrdDetail.Refetch()
        GrdDetail.Row = Currentrow
        EnableDisableSave()
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        MyFrmSearch1 = New FrmSearchRecieptReturn
        MyFrmSearch1.BillCredit = BillCredit
        MyFrmSearch1.ShowDialog()
    End Sub
    Private Sub MyFrmSearch1_ReceiveReterunFind(ByVal ThisId As String) Handles MyFrmSearch1.ReceiveReterunFind
        LoadReciveReturnProduct(ThisId)
    End Sub
    Sub MakeApDtl()
        Try
            Dim a1 As New DSFrmReceiveReturnProduct
            Dim i As Integer = 0
            Dim j As Integer = DsFrmReceiveReturnProduct1.Inv_Receive_product_Ap_Dtl.Rows.Count
            Dim K As Integer = DsFrmReceiveReturnProduct1.Inv_Receive_product_Ap_Dtl.Rows.Count
            If BillCredit = "1" Then
                For i = 0 To DsFrmReceiveReturnProduct1.Inv_Receive_product_Ap_Dtl.Rows.Count - 1
                    DsFrmReceiveReturnProduct1.Inv_Receive_product_Ap_Dtl.Rows(i).Delete()
                Next
                If CalcDueDetail(CmbApTerm.SelectedValue, CDec(LblTotal.Text), TxtRBDate.Text, a1.Ap_dtl) Then
                    For i = 0 To a1.Ap_dtl.Rows.Count - 1
                        '    If j = 0 Then
                        Dim newdr1 As DataRow = DsFrmReceiveReturnProduct1.Inv_Receive_product_Ap_Dtl.NewInv_Receive_product_Ap_DtlRow
                        newdr1("id_receive_ref") = TxtRef.Text
                        newdr1("amount") = a1.Ap_dtl.Rows(i).Item(1)
                        newdr1("due_date") = a1.Ap_dtl.Rows(i).Item(0)
                        DsFrmReceiveReturnProduct1.Inv_Receive_product_Ap_Dtl.AddInv_Receive_product_Ap_DtlRow(newdr1)
                        'Else
                        '    DsFrmReceiveReturnProduct1.Inv_Receive_product_Ap_Dtl.Rows(i).Item("id_receive_ref") = TxtRef.Text
                        '    DsFrmReceiveReturnProduct1.Inv_Receive_product_Ap_Dtl.Rows(i).Item("amount") = a1.Ap_dtl.Rows(i).Item(1)
                        '    DsFrmReceiveReturnProduct1.Inv_Receive_product_Ap_Dtl.Rows(i).Item("due_date") = a1.Ap_dtl.Rows(i).Item(0)
                        '    j = j - 1
                        'End If
                    Next
                    If a1.Ap_dtl.Rows.Count - 1 > 0 Then
                        TxtDueDate.Text = a1.Ap_dtl.Rows(0).Item("due_date")
                    End If

                    'If j >= 1 Then ' there is row to delete
                    '    For i = j - 1 To K - 1
                    '        DsFrmReceiveReturnProduct1.Inv_Receive_product_Ap_Dtl.Rows(j).Delete()
                    '    Next
                    'End If
                End If
            Else
                ' DsFrmReceiveReturnProduct1.Inv_Receive_product_Ap_Dtl.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Function CanEdit() As Boolean
        Dim i As Int64 = 0
        Dim Id As Decimal = 0
        CanEdit = True
        Dim TmpDs As New DataSet
        If BillCredit = "1" Then
            DaCheckForEdit.SelectCommand.Parameters(0).Value = TxtRef.Text.Trim
            DaCheckForEdit.Fill(TmpDs, "t")
            If TmpDs.Tables("t").Rows.Count > 0 Then
                CanEdit = False
                MsgFar("This Receipt prepared for payment record can not edit")
            End If
        Else
            DaCheckForEditReturn.SelectCommand.Parameters(0).Value = TxtRef.Text
            DaCheckForEditReturn.Fill(TmpDs, "s")
            If TmpDs.Tables("s").Rows.Count > 0 Then
                MsgFar("This Return  prepared for payment . record can not edit")
                CanEdit = False
            End If
        End If
    End Function
    Sub ApplyDate()
        ' If BillCredit = "1" Then
        Dim a1 As New DSFrmReceiveReturnProduct
        Try
            If ThisFormStatus = MainModule.WorkStates.AddNew Or ThisFormStatus = MainModule.WorkStates.Edit Then
                If CalcDueDetail(CmbApTerm.SelectedValue, CDec(LblTotal.Text), TxtRBDate.Text, a1.Ap_dtl) Then
                    If a1.Ap_dtl.Rows.Count > 0 Then
                        TxtDueDate.Text = a1.Ap_dtl.Rows(0).Item("due_date")
                    Else
                        TxtDueDate.Text = ""
                    End If
                End If
            End If

        Catch ex As Exception

        End Try
        'End If
    End Sub
    Sub DeleteCredit()
        Dim i As Integer = 0
        For i = 0 To DsFrmReceiveReturnProduct1.GL_vendor_credit.Rows.Count - 1
            DsFrmReceiveReturnProduct1.GL_vendor_credit.Rows(i).Delete()
        Next
    End Sub
    Sub MakeCredit()
        Dim a1 As New DSFrmReceiveReturnProduct
        Dim i As Integer = 0
        Dim j As Integer = DsFrmReceiveReturnProduct1.GL_vendor_credit.Rows.Count
        Dim K As Integer = DsFrmReceiveReturnProduct1.GL_vendor_credit.Rows.Count

        For i = 0 To DsFrmReceiveReturnProduct1.GL_vendor_credit.Rows.Count - 1
            DsFrmReceiveReturnProduct1.GL_vendor_credit.Rows(i).Delete()
        Next
        If CalcDueDetail(CmbApTerm.SelectedValue, CDec(LblTotal.Text), TxtRBDate.Text, a1.Ap_dtl) Then
            For i = 0 To a1.Ap_dtl.Rows.Count - 1
                '    If j = 0 Then
                Dim newdr1 As DataRow = DsFrmReceiveReturnProduct1.GL_vendor_credit.NewGL_vendor_creditRow
                newdr1("cod_vendor") = Vendor_Cod1.Text
                newdr1("date_credit") = TxtDate.Text
                newdr1("amount_credit") = a1.Ap_dtl.Rows(i).Item(1)
                newdr1("Remark") = "Automatic From Return product"
                newdr1("ref_no") = TxtVendorRefNo.Text
                newdr1("due_date") = a1.Ap_dtl.Rows(i).Item(0)
                newdr1("id_receive_ref") = TxtRef.Text

                DsFrmReceiveReturnProduct1.GL_vendor_credit.AddGL_vendor_creditRow(newdr1)
            Next
            If a1.Ap_dtl.Rows.Count - 1 > 0 Then
                TxtDueDate.Text = a1.Ap_dtl.Rows(0).Item("due_date")
            End If

        End If
        'If CmdGeneral.Connection.State <> ConnectionState.Open Then
        '    CmdGeneral.Connection.Open()
        'End If
        'Try
        '    CmdGeneral.CommandText = " Select top 1 id_receive_ref from GL_vendor_credit where id_receive_ref =" & Qt(TxtRef.Text.Trim)
        '    Dim id_vendor_credit As Int64 = Val(CmdGeneral.ExecuteScalar & "")
        '    If id_vendor_credit = 0 Then
        '        CmdGeneral.CommandText = "insert into GL_vendor_credit(cod_vendor,date_credit,amount_credit,Remark,ref_no,due_date,id_receive_ref) values ( " & Qt(Vendor_Cod1.Text) & "," & Qt(TxtDate.Text) & "," & Val(LblTotal.Text) & ", 'Automatic' ," & Qt(TxtVendorRefNo.Text) & "," & Qt(TxtDate.Text) & ", " & Qt(TxtRef.Text) & " )"
        '        CmdGeneral.ExecuteNonQuery()
        '    Else
        '        CmdGeneral.CommandText = "update  GL_vendor_credit set cod_vendor =" & Qt(Vendor_Cod1.Text) & " date_credit = " & Qt(TxtDate.Text) & ", amount_credit = " & Val(LblTotal.Text) & ",ref_no = " & Qt(TxtVendorRefNo.Text) & " ,due_date =" & Qt(TxtDate.Text) & " ,id_receive_ref= " & Qt(TxtRef.Text) & " Where id_vendor_credit=" & id_vendor_credit
        '        CmdGeneral.ExecuteNonQuery()
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'Finally
        '    CmdGeneral.Connection.Close()
        'End Try
    End Sub

    Private Sub TxtRBDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtRBDate.Leave
        ApplyDate()
    End Sub
    Private Sub CmdItemPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdItemPrice.Click
        Dim frmcalitemprice As New UCInv_Item.FrmCalculateItemPrice
        frmcalitemprice.ShowDialog()
    End Sub

    Private Sub GrdDetail_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GrdDetail.FormattingRow

    End Sub

    Private Sub BtnCustomerHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCustomerHistory.Click
        Dim MyFrmVendorHistory As New UCVendor.FrmVendorHistory
        MyFrmVendorHistory.cod_vendorParameter = Vendor_Cod1.VendorCod
        MyFrmVendorHistory.LblCompany.Text = Vendor_Cod1.Desc_Vendor
        MyFrmVendorHistory.ShowDialog()
    End Sub
End Class
