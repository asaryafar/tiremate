Imports CommonClass
Imports Janus.Windows.GridEX
Public Class FrmPurchaseOrder
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
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
    Friend WithEvents TxtDiscount As System.Windows.Forms.TextBox
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
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Txtcontact1 As System.Windows.Forms.TextBox
    Friend WithEvents Txtdesc_vendor As System.Windows.Forms.TextBox
    Friend WithEvents Txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents LblwEIGHT As System.Windows.Forms.Label
    Friend WithEvents CommentButton_Vendor As UCCommentButton.CommentButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ToStoreNo As System.Windows.Forms.RadioButton
    Friend WithEvents CustomerCod1 As UCCustomer.CustomerCod
    Friend WithEvents CusTomerDetail As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmbBuyer As System.Windows.Forms.ComboBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents DsFrmPurchaseOrder1 As UcPurchaseOrder.DSFrmPurchaseOrder
    Friend WithEvents DaInv_Buyer As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents PhoneButton1 As UCPhone.PhoneButton
    Friend WithEvents PhoneNo1 As UCPhone.PhoneNo
    Friend WithEvents ToCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaPoHead As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents state1 As System.Windows.Forms.TextBox
    Friend WithEvents Address1 As System.Windows.Forms.TextBox
    Friend WithEvents Contact1 As System.Windows.Forms.TextBox
    Friend WithEvents Company1 As System.Windows.Forms.TextBox
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaPoDetail As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Cm1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents PnlHead As System.Windows.Forms.Panel
    Friend WithEvents CmdReordering As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaFndCustomer As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents zip1 As UCZipCode.ZipCode
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPurchaseOrder))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PnlHead = New System.Windows.Forms.Panel
        Me.CmdReordering = New System.Windows.Forms.Button
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblCompanyName = New System.Windows.Forms.Label
        Me.LblStoreNo = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PhoneButton1 = New UCPhone.PhoneButton
        Me.Label35 = New System.Windows.Forms.Label
        Me.CmbBuyer = New System.Windows.Forms.ComboBox
        Me.DsFrmPurchaseOrder1 = New UcPurchaseOrder.DSFrmPurchaseOrder
        Me.PhoneNo1 = New UCPhone.PhoneNo
        Me.BtnCustomerBalance = New System.Windows.Forms.Button
        Me.BtnCustomerHistory = New System.Windows.Forms.Button
        Me.BtnCustomerDetail = New System.Windows.Forms.Button
        Me.CommentButton_Vendor = New UCCommentButton.CommentButton
        Me.CommentButton_House = New UCCommentButton.CommentButton
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtZipCode = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Txtaddress = New System.Windows.Forms.TextBox
        Me.Txtcontact1 = New System.Windows.Forms.TextBox
        Me.Txtdesc_vendor = New System.Windows.Forms.TextBox
        Me.Vendor_Cod1 = New UCVendor.Vendor_Cod
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LblTotal = New System.Windows.Forms.Label
        Me.TxtDiscount = New System.Windows.Forms.TextBox
        Me.LblTax = New System.Windows.Forms.Label
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
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.zip1 = New UCZipCode.ZipCode
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.state1 = New System.Windows.Forms.TextBox
        Me.Address1 = New System.Windows.Forms.TextBox
        Me.Contact1 = New System.Windows.Forms.TextBox
        Me.Company1 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.CusTomerDetail = New System.Windows.Forms.Button
        Me.CustomerCod1 = New UCCustomer.CustomerCod
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ToCustomer = New System.Windows.Forms.RadioButton
        Me.ToStoreNo = New System.Windows.Forms.RadioButton
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.Cm1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaInv_Buyer = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaPoHead = New System.Data.SqlClient.SqlDataAdapter
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DaPoDetail = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DaFndCustomer = New System.Data.SqlClient.SqlDataAdapter
        Me.PnlHead.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DsFrmPurchaseOrder1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PnlHead.Controls.Add(Me.CmdReordering)
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
        Me.PnlHead.Size = New System.Drawing.Size(704, 51)
        Me.PnlHead.TabIndex = 4
        '
        'CmdReordering
        '
        Me.CmdReordering.BackColor = System.Drawing.SystemColors.Control
        Me.CmdReordering.Enabled = False
        Me.CmdReordering.Location = New System.Drawing.Point(585, 8)
        Me.CmdReordering.Name = "CmdReordering"
        Me.CmdReordering.Size = New System.Drawing.Size(111, 33)
        Me.CmdReordering.TabIndex = 193
        Me.CmdReordering.Text = "Automatic Reordering"
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Location = New System.Drawing.Point(8, 35)
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
        Me.BtnFirst.Location = New System.Drawing.Point(8, 4)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(33, 27)
        Me.BtnFirst.TabIndex = 191
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Location = New System.Drawing.Point(128, 35)
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
        Me.BtnLast.Location = New System.Drawing.Point(128, 4)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(33, 27)
        Me.BtnLast.TabIndex = 188
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Location = New System.Drawing.Point(376, 35)
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
        Me.BtnCancel.Location = New System.Drawing.Point(376, 4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 27)
        Me.BtnCancel.TabIndex = 7
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Location = New System.Drawing.Point(256, 35)
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
        Me.BtnEdit.Location = New System.Drawing.Point(256, 4)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(33, 27)
        Me.BtnEdit.TabIndex = 4
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Location = New System.Drawing.Point(544, 35)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(37, 10)
        Me.Label31.TabIndex = 182
        Me.Label31.Text = "Email"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(504, 35)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(33, 10)
        Me.Label30.TabIndex = 181
        Me.Label30.Text = "Fax"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(456, 35)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 180
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(414, 35)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(47, 10)
        Me.Label28.TabIndex = 179
        Me.Label28.Text = "Preview"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(336, 35)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(33, 10)
        Me.Label25.TabIndex = 176
        Me.Label25.Text = "Save"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(296, 35)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(37, 10)
        Me.Label24.TabIndex = 175
        Me.Label24.Text = "Delete"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(216, 35)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 10)
        Me.Label15.TabIndex = 174
        Me.Label15.Text = "New"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(176, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 10)
        Me.Label14.TabIndex = 173
        Me.Label14.Text = "Find"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(48, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 10)
        Me.Label3.TabIndex = 172
        Me.Label3.Text = "Prev"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(88, 35)
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
        Me.BtnEmail.Location = New System.Drawing.Point(544, 4)
        Me.BtnEmail.Name = "BtnEmail"
        Me.BtnEmail.Size = New System.Drawing.Size(33, 27)
        Me.BtnEmail.TabIndex = 13
        '
        'BtnFax
        '
        Me.BtnFax.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFax.Image = CType(resources.GetObject("BtnFax.Image"), System.Drawing.Image)
        Me.BtnFax.Location = New System.Drawing.Point(504, 4)
        Me.BtnFax.Name = "BtnFax"
        Me.BtnFax.Size = New System.Drawing.Size(33, 27)
        Me.BtnFax.TabIndex = 12
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(456, 4)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 11
        '
        'BtnPreview
        '
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Image = CType(resources.GetObject("BtnPreview.Image"), System.Drawing.Image)
        Me.BtnPreview.Location = New System.Drawing.Point(416, 4)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(33, 27)
        Me.BtnPreview.TabIndex = 10
        '
        'BtnDelete
        '
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(296, 4)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(33, 27)
        Me.BtnDelete.TabIndex = 5
        '
        'BtnNew
        '
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Location = New System.Drawing.Point(216, 4)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(33, 27)
        Me.BtnNew.TabIndex = 3
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(176, 4)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 27)
        Me.BtnFind.TabIndex = 2
        '
        'BtnNext
        '
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNext.Image = CType(resources.GetObject("BtnNext.Image"), System.Drawing.Image)
        Me.BtnNext.Location = New System.Drawing.Point(88, 4)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(33, 27)
        Me.BtnNext.TabIndex = 1
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.SystemColors.Window
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrev.Image = CType(resources.GetObject("BtnPrev.Image"), System.Drawing.Image)
        Me.BtnPrev.Location = New System.Drawing.Point(48, 4)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrev.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(336, 4)
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
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(167, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(449, 25)
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
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 21)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "Purchase Order"
        '
        'LblCompanyName
        '
        Me.LblCompanyName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblCompanyName.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblCompanyName.Location = New System.Drawing.Point(0, 56)
        Me.LblCompanyName.Name = "LblCompanyName"
        Me.LblCompanyName.Size = New System.Drawing.Size(163, 25)
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
        Me.LblStoreNo.Location = New System.Drawing.Point(618, 56)
        Me.LblStoreNo.Name = "LblStoreNo"
        Me.LblStoreNo.Size = New System.Drawing.Size(84, 25)
        Me.LblStoreNo.TabIndex = 126
        Me.LblStoreNo.Text = "LblStoreNo"
        Me.LblStoreNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PhoneButton1)
        Me.Panel2.Controls.Add(Me.Label35)
        Me.Panel2.Controls.Add(Me.CmbBuyer)
        Me.Panel2.Controls.Add(Me.PhoneNo1)
        Me.Panel2.Controls.Add(Me.BtnCustomerBalance)
        Me.Panel2.Controls.Add(Me.BtnCustomerHistory)
        Me.Panel2.Controls.Add(Me.BtnCustomerDetail)
        Me.Panel2.Controls.Add(Me.CommentButton_Vendor)
        Me.Panel2.Controls.Add(Me.CommentButton_House)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.TxtZipCode)
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Me.Txtaddress)
        Me.Panel2.Controls.Add(Me.Txtcontact1)
        Me.Panel2.Controls.Add(Me.Txtdesc_vendor)
        Me.Panel2.Controls.Add(Me.Vendor_Cod1)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(2, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(348, 132)
        Me.Panel2.TabIndex = 0
        '
        'PhoneButton1
        '
        Me.PhoneButton1.Location = New System.Drawing.Point(309, 50)
        Me.PhoneButton1.Name = "PhoneButton1"
        Me.PhoneButton1.Size = New System.Drawing.Size(23, 23)
        Me.PhoneButton1.TabIndex = 15
        Me.PhoneButton1.ZEnabled = True
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label35.Location = New System.Drawing.Point(218, 105)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(35, 21)
        Me.Label35.TabIndex = 14
        Me.Label35.Text = "buyer"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbBuyer
        '
        Me.CmbBuyer.DataSource = Me.DsFrmPurchaseOrder1.inv_buyer
        Me.CmbBuyer.DisplayMember = "desc_buyer"
        Me.CmbBuyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBuyer.Location = New System.Drawing.Point(254, 103)
        Me.CmbBuyer.Name = "CmbBuyer"
        Me.CmbBuyer.Size = New System.Drawing.Size(89, 21)
        Me.CmbBuyer.TabIndex = 13
        Me.CmbBuyer.ValueMember = "buyer_id"
        '
        'DsFrmPurchaseOrder1
        '
        Me.DsFrmPurchaseOrder1.DataSetName = "DSFrmPurchaseOrder"
        Me.DsFrmPurchaseOrder1.Locale = New System.Globalization.CultureInfo("fa-IR")
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
        'BtnCustomerBalance
        '
        Me.BtnCustomerBalance.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnCustomerBalance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnCustomerBalance.Location = New System.Drawing.Point(260, 0)
        Me.BtnCustomerBalance.Name = "BtnCustomerBalance"
        Me.BtnCustomerBalance.Size = New System.Drawing.Size(57, 21)
        Me.BtnCustomerBalance.TabIndex = 3
        Me.BtnCustomerBalance.TabStop = False
        Me.BtnCustomerBalance.Text = "Balance"
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
        'CommentButton_Vendor
        '
        Me.CommentButton_Vendor.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.CommentButton_Vendor.Location = New System.Drawing.Point(112, 104)
        Me.CommentButton_Vendor.Name = "CommentButton_Vendor"
        Me.CommentButton_Vendor.Size = New System.Drawing.Size(101, 23)
        Me.CommentButton_Vendor.TabIndex = 12
        Me.CommentButton_Vendor.TabStop = False
        Me.CommentButton_Vendor.ZButtonText = "Ven. Comments"
        Me.CommentButton_Vendor.ZCommentFormheight = 0
        Me.CommentButton_Vendor.ZCommentFormWidth = 0
        Me.CommentButton_Vendor.ZCommentText = ""
        Me.CommentButton_Vendor.ZEnabled = True
        Me.CommentButton_Vendor.ZMaxCommentLength = 0
        Me.CommentButton_Vendor.ZShowInLeft = False
        Me.CommentButton_Vendor.ZShowInTop = False
        '
        'CommentButton_House
        '
        Me.CommentButton_House.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.CommentButton_House.Location = New System.Drawing.Point(0, 104)
        Me.CommentButton_House.Name = "CommentButton_House"
        Me.CommentButton_House.Size = New System.Drawing.Size(106, 23)
        Me.CommentButton_House.TabIndex = 11
        Me.CommentButton_House.TabStop = False
        Me.CommentButton_House.ZButtonText = "House Comments"
        Me.CommentButton_House.ZCommentFormheight = 0
        Me.CommentButton_House.ZCommentFormWidth = 0
        Me.CommentButton_House.ZCommentText = Nothing
        Me.CommentButton_House.ZEnabled = True
        Me.CommentButton_House.ZMaxCommentLength = 0
        Me.CommentButton_House.ZShowInLeft = False
        Me.CommentButton_House.ZShowInTop = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.Location = New System.Drawing.Point(224, 28)
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
        'Vendor_Cod1
        '
        Me.Vendor_Cod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Vendor_Cod1.Connection = Me.Cnn
        Me.Vendor_Cod1.Location = New System.Drawing.Point(56, 0)
        Me.Vendor_Cod1.Name = "Vendor_Cod1"
        Me.Vendor_Cod1.NotExitIfNotFound = False
        Me.Vendor_Cod1.ReleaseIfNotFoundVendorCod = False
        Me.Vendor_Cod1.Size = New System.Drawing.Size(101, 21)
        Me.Vendor_Cod1.TabIndex = 0
        Me.Vendor_Cod1.VendorCod = ""
        Me.Vendor_Cod1.VendorCodLen = 6
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
        Me.Panel3.Controls.Add(Me.LblTotal)
        Me.Panel3.Controls.Add(Me.TxtDiscount)
        Me.Panel3.Controls.Add(Me.LblTax)
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
        Me.Panel3.Location = New System.Drawing.Point(352, 96)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(125, 122)
        Me.Panel3.TabIndex = 1
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotal.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblTotal.Location = New System.Drawing.Point(52, 73)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(71, 16)
        Me.LblTotal.TabIndex = 5
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtDiscount
        '
        Me.TxtDiscount.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.TxtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDiscount.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtDiscount.Location = New System.Drawing.Point(52, 58)
        Me.TxtDiscount.Name = "TxtDiscount"
        Me.TxtDiscount.Size = New System.Drawing.Size(71, 21)
        Me.TxtDiscount.TabIndex = 4
        Me.TxtDiscount.Text = ""
        '
        'LblTax
        '
        Me.LblTax.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTax.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblTax.Location = New System.Drawing.Point(52, 44)
        Me.LblTax.Name = "LblTax"
        Me.LblTax.Size = New System.Drawing.Size(71, 15)
        Me.LblTax.TabIndex = 3
        Me.LblTax.Text = "0"
        Me.LblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblSubtotal
        '
        Me.LblSubtotal.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSubtotal.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblSubtotal.Location = New System.Drawing.Point(52, 29)
        Me.LblSubtotal.Name = "LblSubtotal"
        Me.LblSubtotal.Size = New System.Drawing.Size(71, 16)
        Me.LblSubtotal.TabIndex = 2
        Me.LblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblFET
        '
        Me.LblFET.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblFET.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFET.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblFET.Location = New System.Drawing.Point(52, 14)
        Me.LblFET.Name = "LblFET"
        Me.LblFET.Size = New System.Drawing.Size(71, 16)
        Me.LblFET.TabIndex = 1
        Me.LblFET.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTotalQty
        '
        Me.LblTotalQty.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblTotalQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotalQty.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblTotalQty.Location = New System.Drawing.Point(52, 87)
        Me.LblTotalQty.Name = "LblTotalQty"
        Me.LblTotalQty.Size = New System.Drawing.Size(71, 16)
        Me.LblTotalQty.TabIndex = 6
        Me.LblTotalQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblwEIGHT
        '
        Me.LblwEIGHT.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblwEIGHT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblwEIGHT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblwEIGHT.Location = New System.Drawing.Point(52, 102)
        Me.LblwEIGHT.Name = "LblwEIGHT"
        Me.LblwEIGHT.Size = New System.Drawing.Size(71, 16)
        Me.LblwEIGHT.TabIndex = 7
        Me.LblwEIGHT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblParts
        '
        Me.LblParts.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblParts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblParts.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblParts.Location = New System.Drawing.Point(52, -1)
        Me.LblParts.Name = "LblParts"
        Me.LblParts.Size = New System.Drawing.Size(71, 16)
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
        Me.Label23.Size = New System.Drawing.Size(54, 16)
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
        Me.Label22.Size = New System.Drawing.Size(54, 16)
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
        Me.Label21.Size = New System.Drawing.Size(54, 15)
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
        Me.Label20.Size = New System.Drawing.Size(54, 16)
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
        Me.Label19.Size = New System.Drawing.Size(54, 16)
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
        Me.Label18.Size = New System.Drawing.Size(54, 16)
        Me.Label18.TabIndex = 139
        Me.Label18.Text = "Total Qty"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label17.Location = New System.Drawing.Point(-1, 102)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 16)
        Me.Label17.TabIndex = 138
        Me.Label17.Text = "TotWeight"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(-1, -1)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 16)
        Me.Label16.TabIndex = 137
        Me.Label16.Text = "Parts"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.zip1)
        Me.Panel5.Controls.Add(Me.Label34)
        Me.Panel5.Controls.Add(Me.Label27)
        Me.Panel5.Controls.Add(Me.state1)
        Me.Panel5.Controls.Add(Me.Address1)
        Me.Panel5.Controls.Add(Me.Contact1)
        Me.Panel5.Controls.Add(Me.Company1)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.Label26)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.CusTomerDetail)
        Me.Panel5.Controls.Add(Me.CustomerCod1)
        Me.Panel5.Controls.Add(Me.GroupBox1)
        Me.Panel5.Location = New System.Drawing.Point(481, 88)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(220, 131)
        Me.Panel5.TabIndex = 137
        '
        'zip1
        '
        Me.zip1.Connection = Me.Cnn
        Me.zip1.Enabled = False
        Me.zip1.Location = New System.Drawing.Point(144, 107)
        Me.zip1.Name = "zip1"
        Me.zip1.NotExitIfNotFound = False
        Me.zip1.ReleaseIfNotFoundZipCode = False
        Me.zip1.Size = New System.Drawing.Size(59, 19)
        Me.zip1.TabIndex = 14
        Me.zip1.ZipCode = ""
        Me.zip1.ZipCodeLen = 5
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label34.Location = New System.Drawing.Point(104, 105)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(24, 21)
        Me.Label34.TabIndex = 13
        Me.Label34.Text = "Zip"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label27.Location = New System.Drawing.Point(-2, 105)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(52, 21)
        Me.Label27.TabIndex = 12
        Me.Label27.Text = "State"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'state1
        '
        Me.state1.BackColor = System.Drawing.SystemColors.Window
        Me.state1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.state1.Location = New System.Drawing.Point(51, 107)
        Me.state1.Multiline = True
        Me.state1.Name = "state1"
        Me.state1.ReadOnly = True
        Me.state1.Size = New System.Drawing.Size(41, 19)
        Me.state1.TabIndex = 10
        Me.state1.TabStop = False
        Me.state1.Text = ""
        '
        'Address1
        '
        Me.Address1.BackColor = System.Drawing.SystemColors.Window
        Me.Address1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Address1.Location = New System.Drawing.Point(50, 85)
        Me.Address1.Multiline = True
        Me.Address1.Name = "Address1"
        Me.Address1.ReadOnly = True
        Me.Address1.Size = New System.Drawing.Size(160, 20)
        Me.Address1.TabIndex = 9
        Me.Address1.TabStop = False
        Me.Address1.Text = ""
        '
        'Contact1
        '
        Me.Contact1.BackColor = System.Drawing.SystemColors.Window
        Me.Contact1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Contact1.Location = New System.Drawing.Point(50, 65)
        Me.Contact1.Multiline = True
        Me.Contact1.Name = "Contact1"
        Me.Contact1.ReadOnly = True
        Me.Contact1.Size = New System.Drawing.Size(160, 19)
        Me.Contact1.TabIndex = 8
        Me.Contact1.TabStop = False
        Me.Contact1.Text = ""
        '
        'Company1
        '
        Me.Company1.BackColor = System.Drawing.SystemColors.Window
        Me.Company1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Company1.Location = New System.Drawing.Point(50, 44)
        Me.Company1.Multiline = True
        Me.Company1.Name = "Company1"
        Me.Company1.ReadOnly = True
        Me.Company1.Size = New System.Drawing.Size(160, 19)
        Me.Company1.TabIndex = 7
        Me.Company1.TabStop = False
        Me.Company1.Text = ""
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label12.Location = New System.Drawing.Point(-2, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 21)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Address"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label13.Location = New System.Drawing.Point(-2, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 22)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Contact"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label26.Location = New System.Drawing.Point(-5, 42)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(55, 21)
        Me.Label26.TabIndex = 4
        Me.Label26.Text = "Company"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.Location = New System.Drawing.Point(0, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 22)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Ship To"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CusTomerDetail
        '
        Me.CusTomerDetail.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.CusTomerDetail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CusTomerDetail.Location = New System.Drawing.Point(168, 20)
        Me.CusTomerDetail.Name = "CusTomerDetail"
        Me.CusTomerDetail.Size = New System.Drawing.Size(46, 22)
        Me.CusTomerDetail.TabIndex = 2
        Me.CusTomerDetail.TabStop = False
        Me.CusTomerDetail.Text = "Detail"
        Me.ToolTip1.SetToolTip(Me.CusTomerDetail, "Customer detail")
        '
        'CustomerCod1
        '
        Me.CustomerCod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CustomerCod1.Connection = Me.Cnn
        Me.CustomerCod1.CustomerCod = ""
        Me.CustomerCod1.CustomerCodLen = 10
        Me.CustomerCod1.Location = New System.Drawing.Point(50, 21)
        Me.CustomerCod1.Name = "CustomerCod1"
        Me.CustomerCod1.NotExitIfNotFound = False
        Me.CustomerCod1.ReleaseIfNotFoundCustomerCod = False
        Me.CustomerCod1.Size = New System.Drawing.Size(112, 19)
        Me.CustomerCod1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ToCustomer)
        Me.GroupBox1.Controls.Add(Me.ToStoreNo)
        Me.GroupBox1.Location = New System.Drawing.Point(0, -7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(211, 26)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ToCustomer
        '
        Me.ToCustomer.Location = New System.Drawing.Point(112, 7)
        Me.ToCustomer.Name = "ToCustomer"
        Me.ToCustomer.Size = New System.Drawing.Size(91, 14)
        Me.ToCustomer.TabIndex = 1
        Me.ToCustomer.Text = "To Customer"
        '
        'ToStoreNo
        '
        Me.ToStoreNo.Checked = True
        Me.ToStoreNo.Location = New System.Drawing.Point(8, 7)
        Me.ToStoreNo.Name = "ToStoreNo"
        Me.ToStoreNo.Size = New System.Drawing.Size(75, 15)
        Me.ToStoreNo.TabIndex = 0
        Me.ToStoreNo.TabStop = True
        Me.ToStoreNo.Text = "To Store"
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowColumnDrag = False
        Me.GrdDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrdDetail.AutomaticSort = False
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.ContextMenu = Me.Cm1
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "Inv_purchase_order_dtl"
        Me.GrdDetail.DataSource = Me.DsFrmPurchaseOrder1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>service_center_dtl</Caption><Columns Collec" & _
        "tion=""true""><Column0 ID=""Det""><Bound>False</Bound><ButtonStyle>ButtonCell</Butto" & _
        "nStyle><EditType>NoEdit</EditType><Key>Det</Key><Position>0</Position><Selectabl" & _
        "e>False</Selectable><Width>27</Width></Column0><Column1 ID=""item_no""><Caption>It" & _
        "em No</Caption><DataMember>item_no</DataMember><Key>item_no</Key><Position>1</Po" & _
        "sition><Width>87</Width><CellStyle><BackColor>Silver</BackColor></CellStyle></Co" & _
        "lumn1><Column2 ID=""desc_item""><Caption>Description</Caption><DataMember>desc_ite" & _
        "m</DataMember><Key>desc_item</Key><Position>2</Position><Selectable>False</Selec" & _
        "table><Width>272</Width></Column2><Column3 ID=""qty""><Caption>Qty</Caption><DataM" & _
        "ember>qty</DataMember><Key>qty</Key><Position>3</Position><Width>48</Width><Defa" & _
        "ultValue>0</DefaultValue><CellStyle><BackColor>Silver</BackColor></CellStyle></C" & _
        "olumn3><Column4 ID=""cost""><Caption>Cost</Caption><DataMember>cost</DataMember><F" & _
        "ormatString>c2</FormatString><Key>cost</Key><Position>4</Position><Width>77</Wid" & _
        "th><DefaultValue>0</DefaultValue><CellStyle><BackColor>Silver</BackColor></CellS" & _
        "tyle></Column4><Column5 ID=""fet""><Caption>FET</Caption><DataMember>fet</DataMemb" & _
        "er><Key>fet</Key><Position>5</Position><Selectable>False</Selectable><Width>49</" & _
        "Width><DefaultValue>0</DefaultValue><CellStyle><BackColor>White</BackColor></Cel" & _
        "lStyle></Column5><Column6 ID=""taxable""><Caption>T</Caption><ColumnType>CheckBox<" & _
        "/ColumnType><DataMember>taxable</DataMember><EditType>CheckBox</EditType><Key>ta" & _
        "xable</Key><Position>6</Position><Width>32</Width><DefaultValue>False</DefaultVa" & _
        "lue></Column6><Column7 ID=""ExtCost""><Caption>Ext Cost</Caption><DataMember>excos" & _
        "t</DataMember><DefaultGroupPrefix>ExtCost:</DefaultGroupPrefix><FormatString>c</" & _
        "FormatString><Key>ExtCost</Key><Position>7</Position><Selectable>False</Selectab" & _
        "le><Width>92</Width><DefaultValue>0</DefaultValue></Column7><Column8 ID=""wieght_" & _
        "lbs""><Caption>wieght_lbs</Caption><DataMember>wieght_lbs</DataMember><Key>wieght" & _
        "_lbs</Key><Position>8</Position><Visible>False</Visible></Column8></Columns><Gro" & _
        "upCondition ID="""" /><Key>service_center_dtl</Key><RowHeight>19</RowHeight></Root" & _
        "Table></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.ExternalImageList = Me.imageList1
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(0, 226)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(704, 254)
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
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT buyer_id, desc_buyer FROM inv_buyer"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DaInv_Buyer
        '
        Me.DaInv_Buyer.SelectCommand = Me.SqlSelectCommand1
        Me.DaInv_Buyer.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_buyer", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("buyer_id", "buyer_id"), New System.Data.Common.DataColumnMapping("desc_buyer", "desc_buyer")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT po_no, date_po, cod_vendor, shipto_store_no, shipto_cod_customer, buyer_id" & _
        ", house_comments, vend_comments FROM Inv_purchase_order_head WHERE (po_no = @Po_" & _
        "no)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Po_no", System.Data.SqlDbType.VarChar, 6, "po_no"))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Inv_purchase_order_head(po_no, date_po, cod_vendor, shipto_store_no, " & _
        "shipto_cod_customer, buyer_id, house_comments, vend_comments) VALUES (@po_no, @d" & _
        "ate_po, @cod_vendor, @shipto_store_no, @shipto_cod_customer, @buyer_id, @house_c" & _
        "omments, @vend_comments); SELECT po_no, date_po, cod_vendor, shipto_store_no, sh" & _
        "ipto_cod_customer, buyer_id, house_comments, vend_comments FROM Inv_purchase_ord" & _
        "er_head WHERE (po_no = @po_no)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@po_no", System.Data.SqlDbType.VarChar, 6, "po_no"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_po", System.Data.SqlDbType.VarChar, 10, "date_po"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@shipto_store_no", System.Data.SqlDbType.VarChar, 3, "shipto_store_no"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@shipto_cod_customer", System.Data.SqlDbType.VarChar, 10, "shipto_cod_customer"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@buyer_id", System.Data.SqlDbType.VarChar, 4, "buyer_id"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@house_comments", System.Data.SqlDbType.VarChar, 300, "house_comments"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vend_comments", System.Data.SqlDbType.VarChar, 300, "vend_comments"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Inv_purchase_order_head SET po_no = @po_no, date_po = @date_po, cod_vendor" & _
        " = @cod_vendor, shipto_store_no = @shipto_store_no, shipto_cod_customer = @shipt" & _
        "o_cod_customer, buyer_id = @buyer_id, house_comments = @house_comments, vend_com" & _
        "ments = @vend_comments WHERE (po_no = @Original_po_no) AND (buyer_id = @Original" & _
        "_buyer_id OR @Original_buyer_id IS NULL AND buyer_id IS NULL) AND (cod_vendor = " & _
        "@Original_cod_vendor OR @Original_cod_vendor IS NULL AND cod_vendor IS NULL) AND" & _
        " (date_po = @Original_date_po OR @Original_date_po IS NULL AND date_po IS NULL) " & _
        "AND (house_comments = @Original_house_comments OR @Original_house_comments IS NU" & _
        "LL AND house_comments IS NULL) AND (shipto_cod_customer = @Original_shipto_cod_c" & _
        "ustomer OR @Original_shipto_cod_customer IS NULL AND shipto_cod_customer IS NULL" & _
        ") AND (shipto_store_no = @Original_shipto_store_no OR @Original_shipto_store_no " & _
        "IS NULL AND shipto_store_no IS NULL) AND (vend_comments = @Original_vend_comment" & _
        "s OR @Original_vend_comments IS NULL AND vend_comments IS NULL); SELECT po_no, d" & _
        "ate_po, cod_vendor, shipto_store_no, shipto_cod_customer, buyer_id, house_commen" & _
        "ts, vend_comments FROM Inv_purchase_order_head WHERE (po_no = @po_no)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@po_no", System.Data.SqlDbType.VarChar, 6, "po_no"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_po", System.Data.SqlDbType.VarChar, 10, "date_po"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@shipto_store_no", System.Data.SqlDbType.VarChar, 3, "shipto_store_no"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@shipto_cod_customer", System.Data.SqlDbType.VarChar, 10, "shipto_cod_customer"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@buyer_id", System.Data.SqlDbType.VarChar, 4, "buyer_id"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@house_comments", System.Data.SqlDbType.VarChar, 300, "house_comments"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vend_comments", System.Data.SqlDbType.VarChar, 300, "vend_comments"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_po_no", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "po_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_buyer_id", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "buyer_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_po", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_po", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_house_comments", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "house_comments", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_shipto_cod_customer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "shipto_cod_customer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_shipto_store_no", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "shipto_store_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vend_comments", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vend_comments", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Inv_purchase_order_head WHERE (po_no = @Original_po_no) AND (buyer_id" & _
        " = @Original_buyer_id OR @Original_buyer_id IS NULL AND buyer_id IS NULL) AND (c" & _
        "od_vendor = @Original_cod_vendor OR @Original_cod_vendor IS NULL AND cod_vendor " & _
        "IS NULL) AND (date_po = @Original_date_po OR @Original_date_po IS NULL AND date_" & _
        "po IS NULL) AND (house_comments = @Original_house_comments OR @Original_house_co" & _
        "mments IS NULL AND house_comments IS NULL) AND (shipto_cod_customer = @Original_" & _
        "shipto_cod_customer OR @Original_shipto_cod_customer IS NULL AND shipto_cod_cust" & _
        "omer IS NULL) AND (shipto_store_no = @Original_shipto_store_no OR @Original_ship" & _
        "to_store_no IS NULL AND shipto_store_no IS NULL) AND (vend_comments = @Original_" & _
        "vend_comments OR @Original_vend_comments IS NULL AND vend_comments IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_po_no", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "po_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_buyer_id", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "buyer_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_po", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_po", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_house_comments", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "house_comments", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_shipto_cod_customer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "shipto_cod_customer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_shipto_store_no", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "shipto_store_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vend_comments", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vend_comments", System.Data.DataRowVersion.Original, Nothing))
        '
        'DaPoHead
        '
        Me.DaPoHead.DeleteCommand = Me.SqlDeleteCommand1
        Me.DaPoHead.InsertCommand = Me.SqlInsertCommand1
        Me.DaPoHead.SelectCommand = Me.SqlSelectCommand2
        Me.DaPoHead.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_purchase_order_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("date_po", "date_po"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("shipto_store_no", "shipto_store_no"), New System.Data.Common.DataColumnMapping("shipto_cod_customer", "shipto_cod_customer"), New System.Data.Common.DataColumnMapping("buyer_id", "buyer_id"), New System.Data.Common.DataColumnMapping("house_comments", "house_comments"), New System.Data.Common.DataColumnMapping("vend_comments", "vend_comments")})})
        Me.DaPoHead.UpdateCommand = Me.SqlUpdateCommand1
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Inv_purchase_order_dtl.po_no, Inv_purchase_order_dtl.item_no, Inv_purchase" & _
        "_order_dtl.qty, Inv_purchase_order_dtl.taxable, inv_item_cost_transaction.friegh" & _
        "t, inv_item.desc_item, inv_item_cost_transaction.cost AS InvItemCost, Inv_purcha" & _
        "se_order_dtl.cost, inv_tab_tire_specification.wieght_lbs, Inv_purchase_order_dtl" & _
        ".Fet FROM inv_tab_tire_specification INNER JOIN inv_item ON inv_tab_tire_specifi" & _
        "cation.item_no = inv_item.item_no RIGHT OUTER JOIN Inv_purchase_order_dtl INNER " & _
        "JOIN inv_item_cost_transaction ON Inv_purchase_order_dtl.item_no = inv_item_cost" & _
        "_transaction.item_no ON inv_item.item_no = Inv_purchase_order_dtl.item_no AND in" & _
        "v_item.item_no = inv_item_cost_transaction.item_no WHERE (inv_item_cost_transact" & _
        "ion.last_flag = 1) AND (Inv_purchase_order_dtl.po_no = @po_no)"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@po_no", System.Data.SqlDbType.VarChar, 6, "po_no"))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO Inv_purchase_order_dtl(po_no, item_no, qty, cost, Fet, taxable) VALUE" & _
        "S (@po_no, @item_no, @qty, @cost, @Fet, @taxable); SELECT po_no, item_no, qty, c" & _
        "ost, Fet, taxable FROM Inv_purchase_order_dtl WHERE (item_no = @item_no) AND (po" & _
        "_no = @po_no)"
        Me.SqlInsertCommand3.Connection = Me.Cnn
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@po_no", System.Data.SqlDbType.VarChar, 6, "po_no"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@qty", System.Data.SqlDbType.Real, 4, "qty"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cost", System.Data.SqlDbType.Money, 8, "cost"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fet", System.Data.SqlDbType.Money, 8, "Fet"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@taxable", System.Data.SqlDbType.Bit, 1, "taxable"))
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE Inv_purchase_order_dtl SET po_no = @po_no, item_no = @item_no, qty = @qty," & _
        " cost = @cost, Fet = @Fet, taxable = @taxable WHERE (item_no = @Original_item_no" & _
        ") AND (po_no = @Original_po_no) AND (Fet = @Original_Fet) AND (cost = @Original_" & _
        "cost OR @Original_cost IS NULL AND cost IS NULL) AND (qty = @Original_qty OR @Or" & _
        "iginal_qty IS NULL AND qty IS NULL) AND (taxable = @Original_taxable OR @Origina" & _
        "l_taxable IS NULL AND taxable IS NULL); SELECT po_no, item_no, qty, cost, Fet, t" & _
        "axable FROM Inv_purchase_order_dtl WHERE (item_no = @item_no) AND (po_no = @po_n" & _
        "o)"
        Me.SqlUpdateCommand3.Connection = Me.Cnn
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@po_no", System.Data.SqlDbType.VarChar, 6, "po_no"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@qty", System.Data.SqlDbType.Real, 4, "qty"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cost", System.Data.SqlDbType.Money, 8, "cost"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fet", System.Data.SqlDbType.Money, 8, "Fet"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@taxable", System.Data.SqlDbType.Bit, 1, "taxable"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_po_no", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "po_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fet", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cost", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cost", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_qty", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "qty", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_taxable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "taxable", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM Inv_purchase_order_dtl WHERE (item_no = @Original_item_no) AND (po_no" & _
        " = @Original_po_no) AND (Fet = @Original_Fet) AND (cost = @Original_cost OR @Ori" & _
        "ginal_cost IS NULL AND cost IS NULL) AND (qty = @Original_qty OR @Original_qty I" & _
        "S NULL AND qty IS NULL) AND (taxable = @Original_taxable OR @Original_taxable IS" & _
        " NULL AND taxable IS NULL)"
        Me.SqlDeleteCommand3.Connection = Me.Cnn
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_po_no", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "po_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fet", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cost", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cost", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_qty", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "qty", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_taxable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "taxable", System.Data.DataRowVersion.Original, Nothing))
        '
        'DaPoDetail
        '
        Me.DaPoDetail.DeleteCommand = Me.SqlDeleteCommand3
        Me.DaPoDetail.InsertCommand = Me.SqlInsertCommand3
        Me.DaPoDetail.SelectCommand = Me.SqlSelectCommand4
        Me.DaPoDetail.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_purchase_order_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("Fet", "Fet"), New System.Data.Common.DataColumnMapping("taxable", "taxable")})})
        Me.DaPoDetail.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT cust_trtab_main.cod_customer AS cod, cust_trtab_main.f_name, cust_trtab_ma" & _
        "in.l_name, cust_company.complete_name, 0 AS flag FROM cust_trtab_main LEFT OUTER" & _
        " JOIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_company WHE" & _
        "RE (cust_trtab_main.AR_statement = 1) AND (cust_trtab_main.AR_charge = 1)"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DaFndCustomer
        '
        Me.DaFndCustomer.SelectCommand = Me.SqlSelectCommand3
        Me.DaFndCustomer.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_trtab_main", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("vip_code", "vip_code"), New System.Data.Common.DataColumnMapping("cod_company", "cod_company"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("driver_name1", "driver_name1"), New System.Data.Common.DataColumnMapping("driver_name2", "driver_name2"), New System.Data.Common.DataColumnMapping("driver_name3", "driver_name3"), New System.Data.Common.DataColumnMapping("driver_name4", "driver_name4"), New System.Data.Common.DataColumnMapping("DriverLicense", "DriverLicense"), New System.Data.Common.DataColumnMapping("zip", "zip"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("cod_sales_rep", "cod_sales_rep"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cust_exempt_tax", "cust_exempt_tax"), New System.Data.Common.DataColumnMapping("scrap_check", "scrap_check"), New System.Data.Common.DataColumnMapping("scrap_value", "scrap_value"), New System.Data.Common.DataColumnMapping("credit_card_no", "credit_card_no"), New System.Data.Common.DataColumnMapping("expiration_credit_date", "expiration_credit_date"), New System.Data.Common.DataColumnMapping("credit_limited", "credit_limited"), New System.Data.Common.DataColumnMapping("AR_charge", "AR_charge"), New System.Data.Common.DataColumnMapping("AR_term", "AR_term"), New System.Data.Common.DataColumnMapping("cod_sales_tax", "cod_sales_tax"), New System.Data.Common.DataColumnMapping("cod_price", "cod_price"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("cod_type", "cod_type"), New System.Data.Common.DataColumnMapping("cod_source", "cod_source"), New System.Data.Common.DataColumnMapping("cod_class", "cod_class"), New System.Data.Common.DataColumnMapping("cod_territory", "cod_territory"), New System.Data.Common.DataColumnMapping("desc_sales_report", "desc_sales_report"), New System.Data.Common.DataColumnMapping("user_id", "user_id"), New System.Data.Common.DataColumnMapping("user_password", "user_password"), New System.Data.Common.DataColumnMapping("AR_statement", "AR_statement"), New System.Data.Common.DataColumnMapping("AR_send_copy", "AR_send_copy"), New System.Data.Common.DataColumnMapping("AR_finance_charge", "AR_finance_charge"), New System.Data.Common.DataColumnMapping("AR_require_PO", "AR_require_PO"), New System.Data.Common.DataColumnMapping("AR_credit_hold", "AR_credit_hold"), New System.Data.Common.DataColumnMapping("AR_accept_check", "AR_accept_check"), New System.Data.Common.DataColumnMapping("cust_notes", "cust_notes"), New System.Data.Common.DataColumnMapping("Taxable", "Taxable"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("customer_no", "customer_no"), New System.Data.Common.DataColumnMapping("PrintStatementDetailFlag", "PrintStatementDetailFlag"), New System.Data.Common.DataColumnMapping("Customer_Birth_Date", "Customer_Birth_Date")})})
        '
        'FrmPurchaseOrder
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(704, 480)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PnlHead)
        Me.Controls.Add(Me.LblStoreNo)
        Me.Controls.Add(Me.LblCompanyName)
        Me.Name = "FrmPurchaseOrder"
        Me.Text = "Purchase Order"
        Me.PnlHead.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DsFrmPurchaseOrder1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim WithEvents MyFrmReorderPoCondition As FrmReorderPoCondition
    Dim itemff As New itemF
    Dim WithEvents MyFrmsearch1 As FrmSearchPo
    Dim OldReferenceNo As String = ""
#Region "Global Variables"
    Dim ClsRRP As ClsPo
    Dim RowNoToAdd As Integer = 50
    Dim BeforeCel As Integer = -1
    Dim BeforeRow As Integer = -1
    Dim BeforeRowEx As GridEXRow = Nothing
    Dim WithEvents ClsItem1 As UCInv_Item.Clsitem_no
    Dim WithEvents ClsItem2 As UCInv_Item.Clsitem_no

    Dim WithEvents MyFrm1 As UCInv_Item.FrmSearchItemCode
    Dim J As Int64
    Dim i As Int64
    Dim CurrentCost As Decimal = 0
    'Dim BeforeEditedDataset As New DSFrmReceiveReturnProduct
    Dim SALES_TAX As String
    Dim Sales_Tax_Amount As Decimal = 0
    Dim WithEvents MyZipCode As UCZipCode.ClsZipCode
    Dim BeforeEditedDataset As New DSFrmPurchaseOrder
    Public CodPurchaseOrder As String = ""
    Public ShowPnlHead As Boolean = True

#End Region
    Private Sub FrmReciveReturnProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        LblCompanyName.Text = PubCompanyName
        ClsRRP = New ClsPo
        ClsItem1 = New UCInv_Item.Clsitem_no
        ClsItem2 = New UCInv_Item.Clsitem_no
        ClsRRP.Connection = Cnn
        ClsItem1.Connection = Cnn
        ClsItem2.Connection = Cnn
        LblStoreNo.Text = PubStoreName
        TxtDate.Text = Format(Now.Date, PubDateFormat)
        '    Call FixthisDatabase()
        If CodPurchaseOrder <> "" Then
            TxtRef.Text = CodPurchaseOrder
            If Not ShowPnlHead Then
                PnlHead.Visible = False
                PnlHead.Enabled = False
                Me.Height = Me.Height - PnlHead.Height
            End If
        Else
            TxtRef.Text = ClsRRP.LastRecord
        End If
        Call LoadPo(TxtRef.Text)
        Call EnableDisableField(False)
        DaInv_Buyer.Fill(DsFrmPurchaseOrder1.inv_buyer)
        ThisFormStatus = MainModule.WorkStates._ReadOnly
        '        If TxtRef.Text.Trim & "" = "" Then
        '        Call Paddnew()
        '       End If

        MyZipCode = New UCZipCode.ClsZipCode
        MyZipCode.Connection = Me.Cnn

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


        Call InitBeforeRow()

        SqlReader.Close()
        CmdGeneral.Connection.Close()
        OleDbReaderForStore.Close()
        Call RetriveStore()
        CalculateTotal()
        'Call calculateexprice()
    End Sub
    Private Sub LoadPo(ByVal ThisRefNo As String)
        'DsFrmReceiveReturnProduct1.Clear()
        Call ClearAllField()
        DaPoHead.SelectCommand.Parameters("@po_no").Value = ThisRefNo
        DaPoHead.Fill(DsFrmPurchaseOrder1.Inv_purchase_order_head)
        Try
            DaPoDetail.SelectCommand.Parameters("@po_no").Value = ThisRefNo
            DaPoDetail.Fill(DsFrmPurchaseOrder1.Inv_purchase_order_dtl)
        Catch ex As Exception
        End Try
        Call FillDataInScreen()
        Call CalcSumOfExt_price()
        'Call Calculateexprice()
        CalculateTotal()
    End Sub
    Sub calculateexprice()
        'Dim BEFOREROW As Integer = GrdDetail.Row
        'Try
        '    For i = 0 To GrdDetail.RowCount
        '        With GrdDetail.GetRow
        '            If .Cells(1).Value & "" <> "" Then
        '                .Cells(7).Value = (Val(.Cells(4).Value & "") + Val(.Cells(5).Value & "")) * Val(.Cells(3).Value & "")
        '            End If

        '        End With

        '    Next

        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
        'GrdDetail.Row = BEFOREROW
    End Sub
    Private Sub FillDataInScreen()
        With DsFrmPurchaseOrder1.Inv_purchase_order_head
            If .Rows.Count > 0 Then
                TxtRef.Text = .Rows(0).Item("Po_no") & ""
                Vendor_Cod1.Text = ""
                Vendor_Cod1.Text = .Rows(0).Item("cod_vendor")
                'TxtDiscount.Text = .Rows(0).Item("Discount")
                CommentButton_House.ZCommentText = .Rows(0).Item("house_comments")
                CommentButton_Vendor.ZCommentText = .Rows(0).Item("vend_comments")
                CmbBuyer.SelectedValue = .Rows(0).Item("buyer_id")
                TxtDate.Text = .Rows(0).Item("Date_po") & ""
                '------------
                If Trim(.Rows(0).Item("shipto_store_no") & "") <> "" Then
                    ToStoreNo.Checked = True
                Else
                    ToCustomer.Checked = True
                    CustomerCod1.Text = .Rows(0).Item("shipto_cod_customer") & ""
                End If
            End If
        End With
    End Sub
#Region "Clear Fields"
    Private Sub ClearAllField()
        Vendor_Cod1.Text = ""
        DsFrmPurchaseOrder1.Clear()
        DaInv_Buyer.Fill(DsFrmPurchaseOrder1.inv_buyer)
        TxtRef.Clear()
        Txtaddress.Clear()
        Txtcontact1.Clear()
        Txtdesc_vendor.Clear()
        TxtDiscount.Clear()
        PhoneNo1.Text = ""
        TxtZipCode.Clear()
        TxtDate.Text = Format(Now.Date, PubDateFormat)
        TxtDiscount.Text = ""
        TxtRef.Clear()
        ClearTotals()
        CommentButton_Vendor.ZCommentText = ""
        CommentButton_House.ZCommentText = ""
        CustomerCod1.Text = ""
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
        LblParts.Text = 0 'DsFrmPurchaseOrder1.Inv_purchase_order_dtl.Compute("sum( Cost*Qty)", "Cost >=0")
        Dim TaxablePrice As Double = 0 'DsFrmPurchaseOrder1.Inv_purchase_order_dtl.Compute("sum( Fet*Qty)", "Cost >=0")
        Dim TaxPercent As Double = 0
        ClearTotals()
    End Sub
    Private Sub AddEmptyRecordToDetail(ByVal ThisId As String, ByVal ThisRadif As Integer)
        Dim dr As DataRow
        dr = DsFrmPurchaseOrder1.Inv_purchase_order_dtl.NewRow
        dr("po_no") = ThisId
        dr("item_no") = ""
        dr("Taxable") = 0
        dr("cost") = 0
        dr("qty") = 0
        dr("fet") = 0
        dr("wieght_lbs") = 0
        dr("invitemcost") = 0
        DsFrmPurchaseOrder1.Inv_purchase_order_dtl.Rows.Add(dr)
    End Sub
#Region "EnableDisable"

    Private Sub EnableDisableSave()

        Dim RowDetails As DataRow() = DsFrmPurchaseOrder1.Inv_purchase_order_dtl.Select("trim(item_no) <> ''")
        If Vendor_Cod1.Text.Trim.Length > 0 And BtnNew.Enabled = False And RowDetails.Length > 0 Then
            If ToStoreNo.Checked = True Then
                BtnSave.Enabled = True
            ElseIf CustomerCod1.Text.Trim <> "" Then
                BtnSave.Enabled = True
            Else
                BtnSave.Enabled = False
            End If

        Else
            BtnSave.Enabled = False
        End If
    End Sub

    Private Sub EnableDisableField(ByVal InStatus As Boolean)
        Vendor_Cod1.Enabled = InStatus
        GrdDetail.Enabled = InStatus
        CommentButton_House.ZEnabled = InStatus
        CommentButton_Vendor.ZEnabled = InStatus
        CustomerCod1.Enabled = InStatus
        CmbBuyer.Enabled = InStatus
        PhoneButton1.ZEnabled = InStatus
        GroupBox1.Enabled = InStatus
        BtnCustomerDetail.Enabled = InStatus
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
                CmdReordering.Enabled = True
            Case MainModule.WorkStates._ReadOnly
                If TxtRef.Text.Trim.Length > 0 Then
                    CmdReordering.Enabled = False
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
                    CmdReordering.Enabled = False
                End If
                CmdReordering.Enabled = False
                BtnNew.Enabled = True
                BtnCancel.Enabled = False
                BtnSave.Enabled = False
        End Select
    End Sub
#End Region
#Region "GrdDetail"
    Sub AddEmptyRecordInDetail()
        Dim IFirstCount As Integer = DsFrmPurchaseOrder1.Inv_purchase_order_head.Rows.Count()
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
        Dim itemno As String = ""
        Dim CurrentRowGrid As Long = GrdDetail.Row
        If BeforeRowEx Is Nothing Or BeforeCel = -1 Or BeforeRow = -1 Then
            Exit Sub
        End If
        Try
            ValueString = BeforeRowEx.Cells(BeforeCel).Value & ""
            itemno = BeforeRowEx.Cells(1).Value & ""
            Select Case BeforeCel
                Case 1
                    If ValueString.Trim & "" <> "" Then
                        If ClsItem1.FindDesc(ValueString) = False Then
                            MsgFar("Cod is invalid")
                            Call SelectRow(CurrentRowGrid, 1)
                        Else

                            If CheckItemNoRepeat() = False Then
                                ClsItem1.FindItemCost(ValueString)
                            Else
                                MsgFar("Cod is Repeated")
                                GrdDetail.GetRow.Cells(1).Value = ""
                            End If
                            'BeforeRowEx.Cells(2).Value = ClsItem1.desc_Item
                        End If
                    Else
                        Call EmptyThisRow()
                    End If
                Case 4
                    If Val("" & ValueString) <> CurrentCost Then
                        Dim c1 As New FrmWhatDoForMenu
                        c1.BtnLeftText = "yes"
                        c1.BtnRightText = "No"
                        c1.ShowFarMsg("Cost of  This Item is changed Do you want to Make This Change permanent?")
                        Select Case c1.DialogResult
                            Case DialogResult.OK ' Detail Add

                            Case Else 'Re enter
                                ClsItem1.ChangeCostThisItemNo(itemno & "", CurrentCost)
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
            CurrentCost = Val("" & GrdDetail.GetRow.Cells(4).Value)
        Catch ex As Exception
            'If GrdDetail.RowCount > 0 Then
            '    '  SelectRow(1, 4)
            'Else
            '    ' CurrentCost = 0
            'End If
            'CurrentCost = 0
        End Try

        Call EnableDisableSave()
        Call InitBeforeRow()
        Try
            With GrdDetail.GetRow
                .Cells(7).Value = (Val(.Cells(4).Value & "") + Val(.Cells(5).Value & "")) * Val(.Cells(3).Value & "")
            End With
        Catch ex As Exception
        End Try
        ' Call CalculateTotal()
        'GrdDetail.Col = BeforeCel
        '  GrdDetail.Row = BeforeRow
        'Call InitBeforeRow()
    End Sub
    Private Sub GrdDetail_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.ColumnButtonClick
        Call ShowSearch()
    End Sub
    Sub ShowSearch()
        MyFrm1 = New UCInv_Item.FrmSearchItemCode
        MyFrm1.ShowDialog()
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
        Call EnableDisableSave()
    End Sub
    Private Sub Vendor_Cod1_FindVendorNoRow(ByVal ThisRow As System.Data.DataRow) Handles Vendor_Cod1.FindVendorNoRow
        Txtaddress.Text = ThisRow.Item("address") & ""
        Txtcontact1.Text = ThisRow.Item("Contact1") & ""
        Txtdesc_vendor.Text = ThisRow.Item("Desc_vendor") & ""
        ' TxtPhone_1.Text = ThisRow.Item("Phone_1") & ""
        TxtZipCode.Text = ThisRow.Item("ZipCode") & ""
        PhoneButton1.FillDataSet("inv_vendor", "cod_vendor=" & Qt(Vendor_Cod1.Text))
        PhoneNo1.Text = PhoneButton1.FillPhoneNoMain()
        Call EnableDisableSave()
    End Sub
    Private Sub PhoneButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PhoneButton1.Click
        PhoneButton1.HeaderName = Vendor_Cod1.Desc_Vendor.Trim
    End Sub
    Private Sub ClsItem1_FindItemCostRow(ByVal ThisRow As System.Data.DataRow) Handles ClsItem1.FindItemCostRow
        If Trim(GrdDetail.GetRow.Cells(1).Value & "") <> "" Then
            If Val(GrdDetail.GetRow.Cells(5).Value & "") = 0 Then
                GrdDetail.GetRow.Cells(5).Value = Val(ThisRow.Item("Fet") & "")
            End If
            If Val(GrdDetail.GetRow.Cells(4).Value & "") = 0 Then
                GrdDetail.GetRow.Cells(4).Value = ThisRow.Item("Cost") & ""
            End If
        End If
    End Sub
    Private Sub ClsItem1_FindItemNoRow(ByVal ThisRow As System.Data.DataRow) Handles ClsItem1.FindItemNoRow
        If Trim(GrdDetail.GetRow.Cells(1).Value & "") <> "" Then
            GrdDetail.GetRow.Cells(2).Value = ClsItem1.desc_Item & ""
            GrdDetail.GetRow.Cells(8).Value = Val(ThisRow("wieght_lbs") & "")
            GrdDetail.GetRow.Cells(5).Value = Val(ThisRow.Item("Fet") & "")
            Try
                GrdDetail.GetRow.Cells(6).Value = False ' ThisRow.Item("taxable")
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub ClsItem1_NotFindItemNo() Handles ClsItem1.NotFindItemNo
        GrdDetail.GetRow.Cells(2).Value = ""
        GrdDetail.GetRow.Cells(5).Value = 0
        GrdDetail.GetRow.Cells(4).Value = 0
        GrdDetail.GetRow.Cells(8).Value = 0
    End Sub
    Private Sub MyFrm1_Item_noFind(ByVal ThisItemCode As String, ByVal ThisItemDesc As String) Handles MyFrm1.Item_noFind
        GrdDetail.GetRow.Cells(1).Value = ThisItemCode
        GrdDetail.GetRow.Cells(2).Value = ThisItemDesc
        EnableDisableSave()
    End Sub
    Function CheckItemNoRepeat() As Boolean
        CheckItemNoRepeat = False
        Dim i As Long
        Dim dr1 As DataRow()
        If GrdDetail.GetRow.Cells(1).Value & "" <> "" Then
            GrdDetail.UpdateData()
            dr1 = DsFrmPurchaseOrder1.Inv_purchase_order_dtl.Select("trim( item_no) =" & Qt(GrdDetail.GetRow.Cells(1).Value))
            If dr1.Length >= 2 Then
                CheckItemNoRepeat = True
            End If
        End If
    End Function
    Sub CalculateTotal()
        Dim SQty As Decimal = 0
        Dim SCost As Decimal = 0
        Dim SFet As Decimal = 0
        Try
            GrdDetail.UpdateData()
            'SQty = Val("" & DsFrmPurchaseOrder1.Inv_purchase_order_dtl.Compute("sum(Qty)", " trim(Item_no) <> ''"))
            Dim Sum1 As Decimal = 0
            Dim SumFet1 As Decimal = 0
            Dim SumTax As Decimal = 0
            Dim rowsBackup As Integer = 0
            Dim SumW As Decimal = 0
            With DsFrmPurchaseOrder1.Inv_purchase_order_dtl
                For i = 0 To DsFrmPurchaseOrder1.Inv_purchase_order_dtl.Rows.Count - 1
                    If DsFrmPurchaseOrder1.Inv_purchase_order_dtl.Rows(i).RowState <> DataRowState.Deleted Then
                        SQty = SQty + Val(.Rows(i).Item("qty") & "")
                        Sum1 = .Rows(i).Item("Cost") * .Rows(i).Item("qty") + Sum1
                        SumFet1 = Val(.Rows(i).Item("fet") & "") * Val(.Rows(i).Item("qty") & "") + SumFet1
                        If .Rows(i).Item("taxable") = True Then
                            SumTax = Math.Round((Val(.Rows(i).Item("Cost") & "") * Val(.Rows(i).Item("qty") & "")) * Sales_Tax_Amount / 100, 2) + SumTax
                        End If
                        If Trim(.Rows(i).Item("wieght_lbs") & "") <> "" Then
                            SumW = SumW + Val(Trim("" & .Rows(i).Item("wieght_lbs"))) * Val("" & .Rows(i).Item("qty"))
                        End If
                        .Rows(i).Item("excost") = (Val("" & .Rows(i).Item("COST")) + Val(.Rows(i).Item("FET") & "")) * Val(.Rows(i).Item("QTY") & "")
                    End If
                Next
            End With
            LblwEIGHT.Text = Math.Round(SumW, 2)
            LblParts.Text = Format(CType(Sum1, Decimal), "C").Replace("$", "").Replace("—Ì«·", "")   'CDec("0" & DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Compute("sum(Cost*qty)", " trim(Item_no) <> ''"))  '   SQty * SCost
            'SFet = CDec("0" & DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Compute("sum(Fet)", " trim(Item_no) <> ''"))
            LblFET.Text = Format(CType(SumFet1, Decimal), "C").Replace("$", "").Replace("—Ì«·", "")
            LblSubtotal.Text = Format(CType(Sum1 + SumFet1, Decimal), "C").Replace("$", "").Replace("—Ì«·", "") 'Sum1 + SumFet1
            'Format(CType(Sum1 + SumFet1, Decimal), "C").Replace("$", "").Replace("—Ì«·", "")
            LblTax.Text = Format(CType(SumTax, Decimal), "C").Replace("$", "").Replace("—Ì«·", "")  'Sum1 + SumFet1
            LblTotal.Text = Format(CType(Sum1 + SumFet1 + SumTax - Val("" & TxtDiscount.Text), Decimal), "C").Replace("$", "").Replace("—Ì«·", "")  'Sum1 + SumFet1
            LblTotalQty.Text = SQty
            '            LblTax.Text = CDec("0" & DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Compute("Max(Tax)", " trim(Item_no) <> ''"))
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
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
        TxtRef.Text = ClsRRP.MakeNewPoCod()
        OldReferenceNo = TxtRef.Text

        Try
            Dim OleDbReaderForVendor As System.Data.OleDb.OleDbDataReader
            Dim SqlReadervendor As System.Data.SqlClient.SqlDataReader
            OleDbReaderForVendor = RetrieveServiceSetupTable()
            CmbBuyer.SelectedValue = OleDbReaderForVendor.Item("VENDOR_BUYER") & ""
        Catch ex As Exception

        End Try

        Call AddEmptyRecordInDetail()
        Vendor_Cod1.Focus()
    End Sub
    Sub Psave()
        Dim Dr As DataRow
        Dim flg As Boolean = False
        Dim flgchangedid As Boolean = False
        Try
            If DsFrmPurchaseOrder1.Inv_purchase_order_head.Rows.Count <= 0 Then
                Dr = DsFrmPurchaseOrder1.Inv_purchase_order_head.NewRow()
                flg = True
            Else
                Dr = DsFrmPurchaseOrder1.Inv_purchase_order_head.Rows(0)
            End If
            Dr("Po_no") = TxtRef.Text.Trim
            Dr("date_po") = TxtDate.Text
            Dr("cod_vendor") = Vendor_Cod1.Text
            If ToStoreNo.Checked Then
                Dr("shipto_store_no") = LblStoreNo
                Dr("shipto_cod_customer") = System.DBNull.Value
            Else
                Dr("shipto_store_no") = ""
                Dr("shipto_cod_customer") = CustomerCod1.Text
            End If
            'Dr("Discount") = CDec("0" & TxtDiscount.Text)
            Dr("house_comments") = CommentButton_House.ZCommentText
            Dr("vend_comments") = CommentButton_Vendor.ZCommentText
            Dr("buyer_id") = CmbBuyer.SelectedValue
            If flg Then
                DsFrmPurchaseOrder1.Inv_purchase_order_head.AddInv_purchase_order_headRow(Dr)
            End If
            '            #region "delete empty row"
            Dim i As Long
            Dim dr1 As DataRow()
            GrdDetail.UpdateData()
            Try
                SelectRow(0, 1)
            Catch ex As Exception

            End Try

            dr1 = DsFrmPurchaseOrder1.Inv_purchase_order_dtl.Select("trim(item_no) =''   ")
            For i = 0 To dr1.Length - 1
                If dr1(i).RowState <> DataRowState.Deleted Then
                    dr1(i).Delete()
                End If

            Next
            dr1 = DsFrmPurchaseOrder1.Inv_purchase_order_dtl.Select("item_no is null")
            For i = 0 To dr1.Length - 1
                If dr1(i).RowState <> DataRowState.Deleted Then
                    dr1(i).Delete()
                End If

            Next

            Try
                For i = 0 To 10
                    Try
                        DaPoHead.Update(DsFrmPurchaseOrder1)
                        Exit For
                    Catch ex As Exception
                        If flg Then

                            TxtRef.Text = Trim(ClsRRP.MakeNewPoCod() & "")
                            DsFrmPurchaseOrder1.Inv_purchase_order_head.Rows(0).Item("Po_no") = TxtRef.Text.Trim
                            flgchangedid = True
                        Else
                            MsgBox(EX.ToString)
                        End If
                    End Try
                Next

                For i = 0 To DsFrmPurchaseOrder1.Inv_purchase_order_dtl.Count - 1
                    With DsFrmPurchaseOrder1.Inv_purchase_order_dtl
                        If .Rows(i).RowState <> DataRowState.Deleted Then
                            .Rows(i).Item("Po_no") = TxtRef.Text
                        End If
                    End With
                Next


                DaPoDetail.Update(DsFrmPurchaseOrder1)
                '                If RbBill.Checked = True Then
                'Call UpdateQtyInItems()

                '               End If
                Call UpdateQtyInItems()
                If flgchangedid = True Then
                    Dim MyFrmShowChangedNo As New FrmShowChangedNo
                    MyFrmShowChangedNo.LblNewNo.Text = TxtRef.Text
                    MyFrmShowChangedNo.LblOldNo.Text = OldReferenceNo
                    MyFrmShowChangedNo.ShowDialog()
                End If
            Catch ex As Exception
                MsgFar("Error In Update ")
                MsgBox(ex.ToString)
            End Try
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        ThisFormStatus = MainModule.WorkStates._ReadOnly
        Call EnableDisableField(False)
        Call EnableDisableBtn()
    End Sub
    Sub PCancel()
        BeforeEditedDataset.Clear()
        ThisFormStatus = MainModule.WorkStates._ReadOnly
        Call EnableDisableField(False)
        Call EnableDisableBtn()
        TxtRef.Text = ClsRRP.LastRecord
        Call LoadPo(TxtRef.Text)
    End Sub
    Sub PEdit()
        BeforeEditedDataset.Clear()
        BeforeEditedDataset = DsFrmPurchaseOrder1.Copy()
        ' Get A Copy Of Dataset
        Dim AddEmptyRecordToDetailCount As Integer
        Dim IFirstCount As Integer   'Dsfrm..Rows.Count()
        If TxtRef.Text.Trim.Length > 0 Then
            ThisFormStatus = MainModule.WorkStates.Edit
            Call EnableDisableField(True)
            Call EnableDisableBtn()
            IFirstCount = DsFrmPurchaseOrder1.Inv_purchase_order_dtl.Rows.Count()
            For AddEmptyRecordToDetailCount = 1 + IFirstCount To RowNoToAdd + IFirstCount
                Call AddEmptyRecordToDetail(TxtRef.Text, AddEmptyRecordToDetailCount)
            Next
        End If
        Vendor_Cod1.Focus()
    End Sub
    Sub PDelete()
        BeforeEditedDataset.Clear()
        BeforeEditedDataset = DsFrmPurchaseOrder1.Copy()
        If TxtRef.Text.Trim.Length > 0 Then
            ThisFormStatus = MainModule.WorkStates.Delete
            Dim c1 As New FrmWhatDoForMenu
            c1.BtnLeftText = "Cancel"
            c1.BtnRightText = "Delete"
            c1.ShowFarMsg("Are you sure?")
            If c1.DialogResult = DialogResult.OK Then
                Dim TxtRefTemp As String = TxtRef.Text
                If ClsRRP.DeleteThis(TxtRef.Text) Then
                    Call DecreaseMojodi()
                    Call PLastRecord(False)
                    'Call PPreviousRecord(False)
                    'If TxtRefTemp = TxtRef.Text Then
                    '    Call PNextRecord(False)
                    'End If
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
                    Call LoadPo(TXTRef_NoTmp)
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
                    Call LoadPo(TXTRef_NoTmp)
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
                    Call LoadPo(TXTRef_NoTmp)
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
                    Call LoadPo(TXTRef_NoTmp)
                End If
            Else
                MsgFar("There is no Row in Database")
            End If
        Catch ex As Exception
        End Try
    End Sub

#End Region
#Region "All Text Changed"
    Private Sub ToStoreNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToStoreNo.CheckedChanged, ToCustomer.CheckedChanged
        Call EnableDisableSave()
        If ToStoreNo.Checked Then
            CustomerCod1.Text = ""
            CustomerCod1.Enabled = False
            Call RetriveStore()
        ElseIf ToCustomer.Checked = True Then
            CustomerCod1.Enabled = True
            state1.Text = ""
            Call findcustomerspecific()
        End If
    End Sub
    Private Sub CustomerCod1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerCod1.TextChanged
        Call EnableDisableSave()
    End Sub
#End Region
    Sub RetriveStore()
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable()
        Company1.Text = OleDbReaderForStore.Item("STORENAME") & ""
        Contact1.Text = OleDbReaderForStore.Item("PHONE") & ""
        Address1.Text = OleDbReaderForStore.Item("ADDRESS") & ""
        state1.Text = OleDbReaderForStore.Item("STATE") & ""
        zip1.Text = OleDbReaderForStore.Item("ZIPCODE") & ""
        OleDbReaderForStore.Close()
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
        If DsFrmPurchaseOrder1.Inv_purchase_order_dtl.Rows.Count > 0 Then
            Dim rpt As New RepPurchaseOrder
            Dim prn As New FrmRepView

            rpt.SetParameterValue("ParStoreShortName", PubStoreName & "")

            Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
            OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)

            Try
                If OleDbReaderForStore.Item("PurchasesOrdersShading") = 0 Then
                    rpt.SetParameterValue("ShadingParam", True)
                Else
                    rpt.SetParameterValue("ShadingParam", False)
                End If
            Catch ex As Exception
                rpt.SetParameterValue("ShadingParam", False)
            End Try

            rpt.SetParameterValue("Parconame", OleDbReaderForStore.Item("STORENAME") & "")
            rpt.SetParameterValue("Parcoaddress", OleDbReaderForStore.Item("ADDRESS") & "")

            MyZipCode.ZipCode = OleDbReaderForStore.Item("ZipCode")
            MyZipCode.FindDesc(OleDbReaderForStore.Item("ZipCode"))
            rpt.SetParameterValue("Parcoaddress2", MyZipCode.City & " " & MyZipCode.State & " " & MyZipCode.ZipCode & "")

            rpt.SetParameterValue("Parcophone", OleDbReaderForStore.Item("PHONE") & "")
            rpt.SetParameterValue("Parcofax", OleDbReaderForStore.Item("FAX") & "")
            rpt.SetParameterValue("Parcoemail", OleDbReaderForStore.Item("EMAIL") & "")

            Dim OleDbReaderForCompany As System.Data.OleDb.OleDbDataReader
            OleDbReaderForCompany = RetrieveCompanySetupTable()

            rpt.SetParameterValue("Parcowebsite", OleDbReaderForCompany.Item("WEBPAGE"))

            rpt.SetParameterValue("parveno", Vendor_Cod1.Text)
            rpt.SetParameterValue("parpodate", TxtDate.Text)
            rpt.SetParameterValue("partime", Format(TimeOfDay, "Short Time"))
            rpt.SetParameterValue("parponumber", TxtRef.Text)

            MyZipCode.ZipCode = TxtZipCode.Text
            MyZipCode.FindDesc(TxtZipCode.Text)
            rpt.SetParameterValue("parname", Txtdesc_vendor.Text)
            rpt.SetParameterValue("paraddress", Txtaddress.Text)
            rpt.SetParameterValue("paraddress2", MyZipCode.City & " " & MyZipCode.State & " " & MyZipCode.ZipCode & "")
            rpt.SetParameterValue("parphone", PhoneNo1.Text)

            MyZipCode.ZipCode = CustomerCod1.ZipCode
            MyZipCode.FindDesc(CustomerCod1.ZipCode)

            rpt.SetParameterValue("parshipname", Company1.Text)
            rpt.SetParameterValue("parshipaddress", Address1.Text)
            rpt.SetParameterValue("parshipaddress2", MyZipCode.City & " " & MyZipCode.State & " " & MyZipCode.ZipCode & "")
            rpt.SetParameterValue("parshipphone", PhoneNo1.Text)
            rpt.SetParameterValue("parshipphone", PhoneNo1.Text)
            rpt.SetParameterValue("parbuyer", CmbBuyer.Text)

            rpt.SetParameterValue("parpart", LblParts.Text)
            rpt.SetParameterValue("partotalqty", LblTotalQty.Text)
            rpt.SetParameterValue("parfet", LblFET.Text)
            rpt.SetParameterValue("partotalw", LblwEIGHT.Text)
            rpt.SetParameterValue("parsubtotal", LblSubtotal.Text)
            rpt.SetParameterValue("partax", LblTax.Text)
            rpt.SetParameterValue("partotal", LblTotal.Text)
            rpt.SetParameterValue("parkindrep", "Purchase Order")

            rpt.SetDataSource(DsFrmPurchaseOrder1)
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
    Sub EmptyThisRow()
        GrdDetail.GetRow.Cells(1).Value = ""
        GrdDetail.GetRow.Cells(2).Value = ""
        GrdDetail.GetRow.Cells(3).Value = 0
        GrdDetail.GetRow.Cells(4).Value = 0
        GrdDetail.GetRow.Cells(5).Value = 0
        GrdDetail.GetRow.Cells(6).Value = 0
        GrdDetail.GetRow.Cells(7).Value = 0
    End Sub
    Sub UpdateQtyInItems()
        Dim ItmNo As String = ""
        Dim qty As Decimal = 0
        Dim i As Integer = 0
        '-----------------------------------
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            Call DecreaseMojodi()
            'With BeforeEditedDataset
            '    For i = 0 To .Inv_purchase_order_dtl.Rows.Count - 1
            '        If .Inv_purchase_order_dtl.Rows(i).RowState <> DataRowState.Deleted Then
            '            ItmNo = .Inv_purchase_order_dtl.Rows(i).Item("item_no") & ""
            '            qty = .Inv_purchase_order_dtl.Rows(i).Item("QTY")
            '            If ItmNo.Trim <> "" Then
            '                CmdGeneral.CommandText = "update inv_Tab_item_Warehouse  set  on_order = on_order -  " & qty & " where Item_No= " & Qt(ItmNo.Trim) & " And cod_warehouse = " & Qt(PWareHouse)
            '                CmdGeneral.ExecuteNonQuery()
            '            End If
            '        End If
            '    Next
            'End With

            With DsFrmPurchaseOrder1
                For i = 0 To .Inv_purchase_order_dtl.Rows.Count - 1
                    If .Inv_purchase_order_dtl.Rows(i).RowState <> DataRowState.Deleted Then
                        ItmNo = .Inv_purchase_order_dtl.Rows(i).Item("item_no") & ""
                        qty = .Inv_purchase_order_dtl.Rows(i).Item("QTY")
                        If ItmNo.Trim <> "" Then
                            CmdGeneral.CommandText = "update inv_Tab_item_Warehouse  set  on_order = on_order +  " & qty & " where Item_No= " & Qt(ItmNo.Trim) & " And cod_warehouse = " & Qt(PWareHouse)
                            CmdGeneral.ExecuteNonQuery()
                        End If
                    End If
                Next
            End With


            '  End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnCustomerDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCustomerDetail.Click
        Dim MyFrmVendore As New UCVendor.FrmVendor
        MyFrmVendore.VendorCodTempVar = Vendor_Cod1.Text
        MyFrmVendore.ShowDialog()
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
        Dim drow As DataRow() = DsFrmPurchaseOrder1.Inv_purchase_order_dtl.Select("Po_no =" & Qt(TxtRef.Text.Trim) & " and item_no = " & Qt(GrdDetail.GetRow.Cells(1).Value & ""))
        If drow.LongLength > 0 Then
            drow(0).Delete()
        End If
        GrdDetail.UpdateData()
        Call AddEmptyRecordToDetail(TxtRef.Text, 1)
        GrdDetail.Refetch()
        GrdDetail.Row = Currentrow
        EnableDisableSave()
        Call CalculateTotal()
    End Sub
    Sub InsertThisRow(ByVal InTHisPosition As Integer)
        Dim Currentrow As Int64 = InTHisPosition 'GrdDetail.Row
        Call AddEmptyRecordToDetail(TxtRef.Text, 1)
        Dim i As Integer = 0
        Dim j As Integer = 0
        For i = DsFrmPurchaseOrder1.Inv_purchase_order_dtl.Rows.Count - 1 To Currentrow Step -1
            With DsFrmPurchaseOrder1.Inv_purchase_order_dtl
                For j = 0 To 7
                    Try
                        .Rows(i).Item(j) = .Rows(i - 1).Item(j)
                    Catch ex As Exception
                    End Try

                Next
            End With
        Next
        With DsFrmPurchaseOrder1.Inv_purchase_order_dtl.Rows(Currentrow)
            .Item("po_no") = TxtRef.Text
            .Item("item_no") = ""
            .Item("desc_item") = ""
            .Item("Taxable") = 0
            .Item("cost") = 0
            .Item("qty") = 0
            .Item("fet") = 0
            .Item("wieght_lbs") = 0
            .Item("invitemcost") = 0
        End With
        GrdDetail.UpdateData()
        GrdDetail.Refetch()
        GrdDetail.Row = Currentrow
        EnableDisableSave()
    End Sub
    Private Sub CmdReordering_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdReordering.Click
        If ThisFormStatus = MainModule.WorkStates.Edit Then
            MsgFar("This command can use only in new purchase order. you are in edit mode")
            Exit Sub
        End If
        MyFrmReorderPoCondition = New FrmReorderPoCondition
        MyFrmReorderPoCondition.ShowDialog()
        Call CalculateTotal()
        Call AddEmptyRecordInDetail()

    End Sub
    Private Sub MyFrmReorderPoCondition_AddThis(ByVal ItemNo As String, ByVal ThisQty As Decimal) Handles MyFrmReorderPoCondition.AddThis
        itemff.Cost = 0
        itemff.fet = 0
        itemff.desc_Item = ""
        itemff.wieght_lbs = "0"
        If ThisQty > 0 Then
            Dim dr As DataRow
            dr = DsFrmPurchaseOrder1.Inv_purchase_order_dtl.NewRow
            dr("po_no") = TxtRef.Text
            dr("item_no") = ItemNo & ""
            ClsItem2.FindDesc(ItemNo & "")
            ClsItem2.FindItemCost(ItemNo & "")
            dr("desc_Item") = ClsItem2.desc_Item
            dr("Taxable") = 0 ' ClsItem2.Taxable
            dr("cost") = itemff.Cost
            dr("qty") = ThisQty
            dr("fet") = itemff.fet
            dr("wieght_lbs") = Val(itemff.wieght_lbs & "")
            dr("invitemcost") = 0
            dr("excost") = (itemff.Cost + itemff.fet) * ThisQty
            '.Cells(7).Value = (Val(.Cells(4).Value & "") + Val(.Cells(5).Value & "")) * Val(.Cells(3).Value & "")
            DsFrmPurchaseOrder1.Inv_purchase_order_dtl.Rows.Add(dr)
        End If
    End Sub
    Private Sub ClsItem2_FindItemCostRow(ByVal ThisRow As System.Data.DataRow) Handles ClsItem2.FindItemCostRow
        itemff.Cost = Val(ThisRow.Item("Cost") & "")
        itemff.fet = Val(ThisRow.Item("fet") & "")
    End Sub
    Private Sub ClsItem2_FindItemNoRow(ByVal ThisRow As System.Data.DataRow) Handles ClsItem2.FindItemNoRow
        itemff.desc_Item = ClsItem2.desc_Item & ""
        itemff.wieght_lbs = Val(ThisRow("wieght_lbs") & "")
        itemff.fet = Val(GrdDetail.GetRow.Cells(4).Value = ThisRow.Item("fet"))
        Try
            'itemff.Taxable = ThisRow.Item("taxable")
            itemff.Taxable = 0
        Catch ex As Exception
        End Try
    End Sub
    Friend Class itemF
        Friend Cost As Decimal
        Friend fet As Decimal
        Friend Desc As String
        Friend desc_Item As String
        Friend wieght_lbs As String
        Friend Taxable As Boolean
    End Class
    Private Sub MyFrmReorderPoCondition_ClearDataSet() Handles MyFrmReorderPoCondition.ClearDataSet
        DsFrmPurchaseOrder1.Inv_purchase_order_dtl.Clear()
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        MyFrmsearch1 = New FrmSearchPo
        MyFrmsearch1.ShowDialog()
    End Sub
    Private Sub MyFrmsearch1_PoFind(ByVal ThisId As String) Handles MyFrmsearch1.PoFind
        If ThisId.Trim & "" <> "" Then
            LoadPo(ThisId)
        End If
    End Sub

    Sub DecreaseMojodi()
        Dim i As Integer
        Dim ItmNo As String = ""
        Dim qty As Integer = 0
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If

        Try
            With BeforeEditedDataset
                For i = 0 To .Inv_purchase_order_dtl.Rows.Count - 1
                    If .Inv_purchase_order_dtl.Rows(i).RowState <> DataRowState.Deleted Then
                        ItmNo = .Inv_purchase_order_dtl.Rows(i).Item("item_no") & ""
                        qty = .Inv_purchase_order_dtl.Rows(i).Item("QTY")
                        If ItmNo.Trim <> "" Then
                            CmdGeneral.CommandText = "update inv_Tab_item_Warehouse  set  on_order = on_order -  " & qty & " where Item_No= " & Qt(ItmNo.Trim) & " And cod_warehouse = " & Qt(PWareHouse)
                            CmdGeneral.ExecuteNonQuery()
                        End If
                    End If
                Next
            End With
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CustomerCod1_FindCustomerCod() Handles CustomerCod1.FindCustomerCod
        Call findcustomerspecific()
    End Sub
    Private Sub zip1_FindZipCode() Handles zip1.FindZipCode
        state1.Text = zip1.State
    End Sub
    Sub findcustomerspecific()
        Company1.Text = CustomerCod1.abbreviation_name
        Contact1.Text = CustomerCod1.F_Name.Trim & " " & CustomerCod1.M_Name.Trim & " " & CustomerCod1.L_Name.Trim
        Address1.Text = CustomerCod1.Address
        zip1.Text = CustomerCod1.ZipCode
    End Sub
End Class
