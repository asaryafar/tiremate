Imports Janus.Windows.GridEX
Imports CommonClass
Imports UCCommentButton
Public Class FrmInventoryAdjustment
    Inherits FrmBase
    Dim MyFrmItemComments As CommonClass.FrmItemComments
    Dim BeforeCel As Integer = -1
    Dim BeforeRow As Integer = -1
    Dim BeforeRowEx As GridEXRow = Nothing
    Dim WithEvents MyFrmSearchItemCode As New UCInv_Item.FrmSearchItemCode

    Dim WithEvents MyItem As UCInv_Item.Clsitem_no

    Dim RowNoToAdd As Double = 30
    Dim default_inventory_adjment As String = ""
    Dim WithEvents MyZipCode As UCZipCode.ClsZipCode
    Public CodInventoryAdjustment As String = ""
    Public ShowPnlHead As Boolean = True
    ' Dim WithEvents ClsItem1 As UCInv_Item.Clsitem_no
    Dim BeforeEditedDataset As New DSFrmInventoryAdjustment
    Dim WithEvents MyFrmSearchInventoryAdjustment As FrmSearchInventoryAdjustment
    Dim OldReferenceNo As String = ""
    Dim frmitem As New FrmItemProduct
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents LblCompanyName As System.Windows.Forms.Label
    Friend WithEvents LblStoreNo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents TxtRef As System.Windows.Forms.TextBox
    Friend WithEvents TxtDate As System.Windows.Forms.TextBox
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
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
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents BtnFirst As System.Windows.Forms.Button
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents CnnReader As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdReader As System.Data.SqlClient.SqlCommand
    Friend WithEvents LblFET As CalcUtils.UcCalcText
    Friend WithEvents LblParts As CalcUtils.UcCalcText
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Employee_Cod1 As UCEmployee.Employee_Cod
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Employee_Cod2 As UCEmployee.Employee_Cod
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_account As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmbGL_account As System.Windows.Forms.ComboBox
    Friend WithEvents DsFrmInventoryAdjustment1 As UCInv_Item.DSFrmInventoryAdjustment
    Friend WithEvents TxtExplanation As System.Windows.Forms.TextBox
    Friend WithEvents LblEmpName2 As System.Windows.Forms.Label
    Friend WithEvents LblEmpName1 As System.Windows.Forms.Label
    Friend WithEvents LblTotal As CalcUtils.UcCalcText
    Friend WithEvents LbltotWeight As CalcUtils.UcCalcText
    Friend WithEvents LblTotQty As CalcUtils.UcCalcText
    Friend WithEvents DAinv_adjustment_head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CommentButton As UCCommentButton.CommentButton
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_adjustment_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Cm1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents PnlHead As System.Windows.Forms.Panel
    Friend WithEvents LblVendorName As System.Windows.Forms.Label
    Friend WithEvents Vendor_Cod1 As UCVendor.Vendor_Cod
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtNationalAccount As System.Windows.Forms.TextBox
    Friend WithEvents TxtDeliveryReciept As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmInventoryAdjustment))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DsFrmInventoryAdjustment1 = New UCInv_Item.DSFrmInventoryAdjustment
        Me.LblCompanyName = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblStoreNo = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtRef = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxtNationalAccount = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtDeliveryReciept = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.LblVendorName = New System.Windows.Forms.Label
        Me.Vendor_Cod1 = New UCVendor.Vendor_Cod
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtExplanation = New System.Windows.Forms.TextBox
        Me.LblEmpName2 = New System.Windows.Forms.Label
        Me.LblEmpName1 = New System.Windows.Forms.Label
        Me.CmbGL_account = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Employee_Cod2 = New UCEmployee.Employee_Cod
        Me.Employee_Cod1 = New UCEmployee.Employee_Cod
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CommentButton = New UCCommentButton.CommentButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LbltotWeight = New CalcUtils.UcCalcText
        Me.LblTotQty = New CalcUtils.UcCalcText
        Me.LblTotal = New CalcUtils.UcCalcText
        Me.LblFET = New CalcUtils.UcCalcText
        Me.LblParts = New CalcUtils.UcCalcText
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtDate = New System.Windows.Forms.TextBox
        Me.PnlHead = New System.Windows.Forms.Panel
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
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.CnnReader = New System.Data.SqlClient.SqlConnection
        Me.CmdReader = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand
        Me.Label17 = New System.Windows.Forms.Label
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_account = New System.Data.SqlClient.SqlDataAdapter
        Me.DAinv_adjustment_head = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.Cm1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_adjustment_dtl = New System.Data.SqlClient.SqlDataAdapter
        CType(Me.DsFrmInventoryAdjustment1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PnlHead.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imageList1
        '
        Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'DsFrmInventoryAdjustment1
        '
        Me.DsFrmInventoryAdjustment1.DataSetName = "DSFrmInventoryAdjustment"
        Me.DsFrmInventoryAdjustment1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'LblCompanyName
        '
        Me.LblCompanyName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblCompanyName.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCompanyName.Location = New System.Drawing.Point(0, 45)
        Me.LblCompanyName.Name = "LblCompanyName"
        Me.LblCompanyName.Size = New System.Drawing.Size(147, 26)
        Me.LblCompanyName.TabIndex = 123
        Me.LblCompanyName.Text = "LblCompanyName"
        Me.LblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(148, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(380, 26)
        Me.Label2.TabIndex = 124
        '
        'LblStoreNo
        '
        Me.LblStoreNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblStoreNo.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblStoreNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblStoreNo.Location = New System.Drawing.Point(528, 45)
        Me.LblStoreNo.Name = "LblStoreNo"
        Me.LblStoreNo.Size = New System.Drawing.Size(161, 25)
        Me.LblStoreNo.TabIndex = 125
        Me.LblStoreNo.Text = "LblStoreNo"
        Me.LblStoreNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(193, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 20)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(379, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 22)
        Me.Label5.TabIndex = 127
        Me.Label5.Text = "Ref"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtRef
        '
        Me.TxtRef.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRef.Enabled = False
        Me.TxtRef.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtRef.Location = New System.Drawing.Point(404, 47)
        Me.TxtRef.Name = "TxtRef"
        Me.TxtRef.Size = New System.Drawing.Size(92, 21)
        Me.TxtRef.TabIndex = 129
        Me.TxtRef.Text = ""
        Me.TxtRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TxtNationalAccount)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.TxtDeliveryReciept)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.LblVendorName)
        Me.Panel1.Controls.Add(Me.Vendor_Cod1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.TxtExplanation)
        Me.Panel1.Controls.Add(Me.LblEmpName2)
        Me.Panel1.Controls.Add(Me.LblEmpName1)
        Me.Panel1.Controls.Add(Me.CmbGL_account)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Employee_Cod2)
        Me.Panel1.Controls.Add(Me.Employee_Cod1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Panel1.Location = New System.Drawing.Point(0, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(411, 140)
        Me.Panel1.TabIndex = 0
        '
        'TxtNationalAccount
        '
        Me.TxtNationalAccount.Location = New System.Drawing.Point(265, 91)
        Me.TxtNationalAccount.MaxLength = 10
        Me.TxtNationalAccount.Name = "TxtNationalAccount"
        Me.TxtNationalAccount.Size = New System.Drawing.Size(99, 20)
        Me.TxtNationalAccount.TabIndex = 5
        Me.TxtNationalAccount.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(225, 93)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 20)
        Me.Label12.TabIndex = 216
        Me.Label12.Text = "NA #"
        '
        'TxtDeliveryReciept
        '
        Me.TxtDeliveryReciept.Location = New System.Drawing.Point(79, 89)
        Me.TxtDeliveryReciept.MaxLength = 10
        Me.TxtDeliveryReciept.Name = "TxtDeliveryReciept"
        Me.TxtDeliveryReciept.Size = New System.Drawing.Size(99, 20)
        Me.TxtDeliveryReciept.TabIndex = 4
        Me.TxtDeliveryReciept.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(39, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 20)
        Me.Label11.TabIndex = 214
        Me.Label11.Text = "DR #"
        '
        'LblVendorName
        '
        Me.LblVendorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblVendorName.Location = New System.Drawing.Point(184, 67)
        Me.LblVendorName.Name = "LblVendorName"
        Me.LblVendorName.Size = New System.Drawing.Size(222, 23)
        Me.LblVendorName.TabIndex = 212
        Me.LblVendorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Vendor_Cod1
        '
        Me.Vendor_Cod1.BackColor = System.Drawing.Color.YellowGreen
        Me.Vendor_Cod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Vendor_Cod1.Connection = Me.Cnn
        Me.Vendor_Cod1.Location = New System.Drawing.Point(82, 68)
        Me.Vendor_Cod1.Name = "Vendor_Cod1"
        Me.Vendor_Cod1.NotExitIfNotFound = False
        Me.Vendor_Cod1.ReleaseIfNotFoundVendorCod = False
        Me.Vendor_Cod1.Size = New System.Drawing.Size(101, 20)
        Me.Vendor_Cod1.TabIndex = 3
        Me.Vendor_Cod1.VendorCod = ""
        Me.Vendor_Cod1.VendorCodLen = 6
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(-19, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 23)
        Me.Label10.TabIndex = 211
        Me.Label10.Text = "Vendor"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtExplanation
        '
        Me.TxtExplanation.Location = New System.Drawing.Point(82, 45)
        Me.TxtExplanation.MaxLength = 100
        Me.TxtExplanation.Name = "TxtExplanation"
        Me.TxtExplanation.Size = New System.Drawing.Size(326, 20)
        Me.TxtExplanation.TabIndex = 2
        Me.TxtExplanation.Text = ""
        '
        'LblEmpName2
        '
        Me.LblEmpName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblEmpName2.Location = New System.Drawing.Point(184, 23)
        Me.LblEmpName2.Name = "LblEmpName2"
        Me.LblEmpName2.Size = New System.Drawing.Size(224, 21)
        Me.LblEmpName2.TabIndex = 184
        '
        'LblEmpName1
        '
        Me.LblEmpName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblEmpName1.Location = New System.Drawing.Point(184, 1)
        Me.LblEmpName1.Name = "LblEmpName1"
        Me.LblEmpName1.Size = New System.Drawing.Size(224, 21)
        Me.LblEmpName1.TabIndex = 183
        '
        'CmbGL_account
        '
        Me.CmbGL_account.DataSource = Me.DsFrmInventoryAdjustment1.GL_account
        Me.CmbGL_account.DisplayMember = "desc_GL_account"
        Me.CmbGL_account.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbGL_account.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.CmbGL_account.ItemHeight = 13
        Me.CmbGL_account.Location = New System.Drawing.Point(139, 113)
        Me.CmbGL_account.Name = "CmbGL_account"
        Me.CmbGL_account.Size = New System.Drawing.Size(266, 21)
        Me.CmbGL_account.TabIndex = 6
        Me.CmbGL_account.ValueMember = "GL_account"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(5, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 20)
        Me.Label9.TabIndex = 181
        Me.Label9.Text = "Gl Account For Adjustment"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(16, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 20)
        Me.Label8.TabIndex = 180
        Me.Label8.Text = "Explanation"
        '
        'Employee_Cod2
        '
        Me.Employee_Cod2.BackColor = System.Drawing.Color.YellowGreen
        Me.Employee_Cod2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Employee_Cod2.Connection = Me.Cnn
        Me.Employee_Cod2.EmployeeCod = ""
        Me.Employee_Cod2.EmployeeCodLen = 5
        Me.Employee_Cod2.Kind_Employee = ""
        Me.Employee_Cod2.Location = New System.Drawing.Point(82, 23)
        Me.Employee_Cod2.Name = "Employee_Cod2"
        Me.Employee_Cod2.NotExitIfNotFound = False
        Me.Employee_Cod2.ReleaseIfNotFoundEmployeeCod = True
        Me.Employee_Cod2.Size = New System.Drawing.Size(101, 20)
        Me.Employee_Cod2.TabIndex = 1
        '
        'Employee_Cod1
        '
        Me.Employee_Cod1.BackColor = System.Drawing.Color.YellowGreen
        Me.Employee_Cod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Employee_Cod1.Connection = Me.Cnn
        Me.Employee_Cod1.EmployeeCod = ""
        Me.Employee_Cod1.EmployeeCodLen = 5
        Me.Employee_Cod1.Kind_Employee = ""
        Me.Employee_Cod1.Location = New System.Drawing.Point(82, 1)
        Me.Employee_Cod1.Name = "Employee_Cod1"
        Me.Employee_Cod1.NotExitIfNotFound = False
        Me.Employee_Cod1.ReleaseIfNotFoundEmployeeCod = True
        Me.Employee_Cod1.Size = New System.Drawing.Size(101, 20)
        Me.Employee_Cod1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 178
        Me.Label6.Text = "Adjustment by"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 179
        Me.Label7.Text = "Authorized by"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.CommentButton)
        Me.Panel2.Location = New System.Drawing.Point(528, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(162, 140)
        Me.Panel2.TabIndex = 1
        '
        'CommentButton
        '
        Me.CommentButton.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.CommentButton.Location = New System.Drawing.Point(40, 52)
        Me.CommentButton.Name = "CommentButton"
        Me.CommentButton.Size = New System.Drawing.Size(90, 23)
        Me.CommentButton.TabIndex = 0
        Me.CommentButton.TabStop = False
        Me.CommentButton.ZButtonText = "Comments"
        Me.CommentButton.ZCommentFormheight = 0
        Me.CommentButton.ZCommentFormWidth = 0
        Me.CommentButton.ZCommentText = Nothing
        Me.CommentButton.ZEnabled = True
        Me.CommentButton.ZMaxCommentLength = 0
        Me.CommentButton.ZShowInLeft = False
        Me.CommentButton.ZShowInTop = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.LbltotWeight)
        Me.Panel3.Controls.Add(Me.LblTotQty)
        Me.Panel3.Controls.Add(Me.LblTotal)
        Me.Panel3.Controls.Add(Me.LblFET)
        Me.Panel3.Controls.Add(Me.LblParts)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Location = New System.Drawing.Point(412, 72)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(117, 89)
        Me.Panel3.TabIndex = 135
        '
        'LbltotWeight
        '
        Me.LbltotWeight.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LbltotWeight.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LbltotWeight.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LbltotWeight.DecimalDigits = 2
        Me.LbltotWeight.DefaultSendValue = False
        Me.LbltotWeight.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LbltotWeight.FireTabAfterEnter = True
        Me.LbltotWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbltotWeight.Image = CType(resources.GetObject("LbltotWeight.Image"), System.Drawing.Image)
        Me.LbltotWeight.Location = New System.Drawing.Point(61, 69)
        Me.LbltotWeight.Maxlength = 10
        Me.LbltotWeight.MinusColor = System.Drawing.Color.Empty
        Me.LbltotWeight.Name = "LbltotWeight"
        Me.LbltotWeight.ReadOnly = True
        Me.LbltotWeight.Size = New System.Drawing.Size(52, 21)
        Me.LbltotWeight.TabIndex = 163
        Me.LbltotWeight.TabStop = False
        Me.LbltotWeight.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LbltotWeight.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblTotQty
        '
        Me.LblTotQty.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblTotQty.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblTotQty.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblTotQty.DecimalDigits = 2
        Me.LblTotQty.DefaultSendValue = False
        Me.LblTotQty.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblTotQty.FireTabAfterEnter = True
        Me.LblTotQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotQty.Image = CType(resources.GetObject("LblTotQty.Image"), System.Drawing.Image)
        Me.LblTotQty.Location = New System.Drawing.Point(61, 52)
        Me.LblTotQty.Maxlength = 10
        Me.LblTotQty.MinusColor = System.Drawing.Color.Empty
        Me.LblTotQty.Name = "LblTotQty"
        Me.LblTotQty.ReadOnly = True
        Me.LblTotQty.Size = New System.Drawing.Size(52, 21)
        Me.LblTotQty.TabIndex = 162
        Me.LblTotQty.TabStop = False
        Me.LblTotQty.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblTotQty.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblTotal.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblTotal.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblTotal.DecimalDigits = 2
        Me.LblTotal.DefaultSendValue = False
        Me.LblTotal.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblTotal.FireTabAfterEnter = True
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Image = CType(resources.GetObject("LblTotal.Image"), System.Drawing.Image)
        Me.LblTotal.Location = New System.Drawing.Point(61, 35)
        Me.LblTotal.Maxlength = 10
        Me.LblTotal.MinusColor = System.Drawing.Color.Empty
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.ReadOnly = True
        Me.LblTotal.Size = New System.Drawing.Size(52, 21)
        Me.LblTotal.TabIndex = 167
        Me.LblTotal.TabStop = False
        Me.LblTotal.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblTotal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblFET
        '
        Me.LblFET.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblFET.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblFET.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblFET.DecimalDigits = 2
        Me.LblFET.DefaultSendValue = False
        Me.LblFET.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblFET.FireTabAfterEnter = True
        Me.LblFET.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFET.Image = CType(resources.GetObject("LblFET.Image"), System.Drawing.Image)
        Me.LblFET.Location = New System.Drawing.Point(61, 17)
        Me.LblFET.Maxlength = 10
        Me.LblFET.MinusColor = System.Drawing.Color.Empty
        Me.LblFET.Name = "LblFET"
        Me.LblFET.ReadOnly = True
        Me.LblFET.Size = New System.Drawing.Size(52, 21)
        Me.LblFET.TabIndex = 166
        Me.LblFET.TabStop = False
        Me.LblFET.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblFET.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblParts
        '
        Me.LblParts.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblParts.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblParts.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblParts.DecimalDigits = 2
        Me.LblParts.DefaultSendValue = False
        Me.LblParts.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblParts.FireTabAfterEnter = True
        Me.LblParts.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblParts.Image = CType(resources.GetObject("LblParts.Image"), System.Drawing.Image)
        Me.LblParts.Location = New System.Drawing.Point(61, 0)
        Me.LblParts.Maxlength = 10
        Me.LblParts.MinusColor = System.Drawing.Color.Empty
        Me.LblParts.Name = "LblParts"
        Me.LblParts.ReadOnly = True
        Me.LblParts.Size = New System.Drawing.Size(52, 21)
        Me.LblParts.TabIndex = 168
        Me.LblParts.TabStop = False
        Me.LblParts.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblParts.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Location = New System.Drawing.Point(-1, 69)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(61, 19)
        Me.Label22.TabIndex = 143
        Me.Label22.Text = "Tot Weight"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Location = New System.Drawing.Point(-1, 52)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(61, 18)
        Me.Label21.TabIndex = 142
        Me.Label21.Text = "Total QTY"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label20.Location = New System.Drawing.Point(-1, 35)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(61, 18)
        Me.Label20.TabIndex = 141
        Me.Label20.Text = "Total $"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(-1, 17)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 19)
        Me.Label19.TabIndex = 140
        Me.Label19.Text = "FET"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(-1, -1)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 19)
        Me.Label16.TabIndex = 137
        Me.Label16.Text = "Parts"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDate
        '
        Me.TxtDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDate.Enabled = False
        Me.TxtDate.Location = New System.Drawing.Point(223, 47)
        Me.TxtDate.Name = "TxtDate"
        Me.TxtDate.Size = New System.Drawing.Size(77, 20)
        Me.TxtDate.TabIndex = 138
        Me.TxtDate.Text = ""
        Me.TxtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PnlHead
        '
        Me.PnlHead.BackColor = System.Drawing.SystemColors.Window
        Me.PnlHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.PnlHead.Size = New System.Drawing.Size(690, 45)
        Me.PnlHead.TabIndex = 2
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Location = New System.Drawing.Point(1, 31)
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
        Me.BtnFirst.Location = New System.Drawing.Point(2, 2)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(33, 27)
        Me.BtnFirst.TabIndex = 191
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Location = New System.Drawing.Point(108, 31)
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
        Me.BtnLast.Location = New System.Drawing.Point(107, 2)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(33, 27)
        Me.BtnLast.TabIndex = 188
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Location = New System.Drawing.Point(326, 31)
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
        Me.BtnCancel.Location = New System.Drawing.Point(328, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 27)
        Me.BtnCancel.TabIndex = 7
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Location = New System.Drawing.Point(224, 31)
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
        Me.BtnEdit.Location = New System.Drawing.Point(223, 2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(33, 27)
        Me.BtnEdit.TabIndex = 4
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Location = New System.Drawing.Point(632, 31)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(33, 10)
        Me.Label31.TabIndex = 182
        Me.Label31.Text = "Email"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Location = New System.Drawing.Point(592, 31)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(33, 10)
        Me.Label30.TabIndex = 181
        Me.Label30.Text = "Fax"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(560, 31)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 180
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(516, 31)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 10)
        Me.Label28.TabIndex = 179
        Me.Label28.Text = "Preview"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(293, 31)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(33, 10)
        Me.Label25.TabIndex = 176
        Me.Label25.Text = "Save"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(256, 31)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(37, 10)
        Me.Label24.TabIndex = 175
        Me.Label24.Text = "Delete"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(187, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 10)
        Me.Label15.TabIndex = 174
        Me.Label15.Text = "New"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(148, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 10)
        Me.Label14.TabIndex = 173
        Me.Label14.Text = "Find"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(36, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 10)
        Me.Label3.TabIndex = 172
        Me.Label3.Text = "Prev"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(73, 31)
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
        Me.BtnEmail.Location = New System.Drawing.Point(632, 2)
        Me.BtnEmail.Name = "BtnEmail"
        Me.BtnEmail.Size = New System.Drawing.Size(33, 27)
        Me.BtnEmail.TabIndex = 13
        '
        'BtnFax
        '
        Me.BtnFax.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFax.Image = CType(resources.GetObject("BtnFax.Image"), System.Drawing.Image)
        Me.BtnFax.Location = New System.Drawing.Point(592, 2)
        Me.BtnFax.Name = "BtnFax"
        Me.BtnFax.Size = New System.Drawing.Size(33, 27)
        Me.BtnFax.TabIndex = 12
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(560, 2)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 11
        '
        'BtnPreview
        '
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Image = CType(resources.GetObject("BtnPreview.Image"), System.Drawing.Image)
        Me.BtnPreview.Location = New System.Drawing.Point(520, 2)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(33, 27)
        Me.BtnPreview.TabIndex = 10
        '
        'BtnDelete
        '
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(258, 2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(33, 27)
        Me.BtnDelete.TabIndex = 5
        '
        'BtnNew
        '
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Location = New System.Drawing.Point(188, 2)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(33, 27)
        Me.BtnNew.TabIndex = 3
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(147, 2)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 27)
        Me.BtnFind.TabIndex = 2
        '
        'BtnNext
        '
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNext.Image = CType(resources.GetObject("BtnNext.Image"), System.Drawing.Image)
        Me.BtnNext.Location = New System.Drawing.Point(72, 2)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(33, 27)
        Me.BtnNext.TabIndex = 1
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.SystemColors.Window
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrev.Image = CType(resources.GetObject("BtnPrev.Image"), System.Drawing.Image)
        Me.BtnPrev.Location = New System.Drawing.Point(37, 2)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrev.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(293, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 6
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'CnnReader
        '
        Me.CnnReader.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;" & _
        "persist security info=True;password=sa"
        '
        'CmdReader
        '
        Me.CmdReader.Connection = Me.CnnReader
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
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "INSERT INTO GL_payment_deposit(id_service_center, refrence_no, refer_type, paymen" & _
        "t_type, payment_amount) VALUES (@id_service_center, @refrence_no, @refer_type, @" & _
        "payment_type, @payment_amount); SELECT ID_payment, id_service_center, refrence_n" & _
        "o, refer_type, payment_type, payment_amount FROM GL_payment_deposit WHERE (ID_pa" & _
        "yment = @@IDENTITY)"
        Me.SqlCommand2.Connection = Me.Cnn
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 6, "refrence_no"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT GL_payment_deposit.ID_payment, GL_payment_deposit.id_service_center, GL_pa" & _
        "yment_deposit.refrence_no, GL_payment_deposit.refer_type, GL_payment_deposit.pay" & _
        "ment_type, GL_payment_deposit.payment_amount, GL_payment_cash.cash_rendered, GL_" & _
        "payment_cash.change_due, GL_payment_check.check_no, GL_payment_check.check_date," & _
        " GL_payment_AR.AR_terms, GL_payment_AR.AR_due_date, GL_payment_credit.cc_type, G" & _
        "L_payment_credit.cc_card_no, GL_payment_credit.cc_expire_date_year, GL_payment_c" & _
        "redit.cc_expire_date_month, GL_payment_credit.cc_auth_no, bas_cc_type.cc_type_de" & _
        "sc FROM GL_payment_deposit LEFT OUTER JOIN GL_payment_credit ON GL_payment_depos" & _
        "it.ID_payment = GL_payment_credit.ID_payment LEFT OUTER JOIN bas_cc_type ON GL_p" & _
        "ayment_credit.cc_type = bas_cc_type.cc_type LEFT OUTER JOIN GL_payment_AR ON GL_" & _
        "payment_deposit.ID_payment = GL_payment_AR.ID_payment LEFT OUTER JOIN GL_payment" & _
        "_check ON GL_payment_deposit.ID_payment = GL_payment_check.ID_payment LEFT OUTER" & _
        " JOIN GL_payment_cash ON GL_payment_deposit.ID_payment = GL_payment_cash.ID_paym" & _
        "ent WHERE (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.id_servi" & _
        "ce_center = @id_service_center)"
        Me.SqlCommand3.Connection = Me.Cnn
        Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE GL_payment_deposit SET id_service_center = @id_service_center, refrence_no" & _
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
        Me.SqlCommand4.Connection = Me.Cnn
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 6, "refrence_no"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refer_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refer_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refrence_no", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_payment", System.Data.SqlDbType.Int, 4, "ID_payment"))
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "INSERT INTO GL_payment_deposit(id_service_center, refrence_no, refer_type, paymen" & _
        "t_type, payment_amount) VALUES (@id_service_center, @refrence_no, @refer_type, @" & _
        "payment_type, @payment_amount); SELECT ID_payment, id_service_center, refrence_n" & _
        "o, refer_type, payment_type, payment_amount FROM GL_payment_deposit WHERE (ID_pa" & _
        "yment = @@IDENTITY)"
        Me.SqlCommand5.Connection = Me.Cnn
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 6, "refrence_no"))
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        '
        'SqlCommand6
        '
        Me.SqlCommand6.CommandText = "SELECT GL_payment_deposit.ID_payment, GL_payment_deposit.id_service_center, GL_pa" & _
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
        Me.SqlCommand6.Connection = Me.Cnn
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        '
        'SqlCommand7
        '
        Me.SqlCommand7.CommandText = "UPDATE GL_payment_deposit SET id_service_center = @id_service_center, refrence_no" & _
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
        Me.SqlCommand7.Connection = Me.Cnn
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 6, "refrence_no"))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refer_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refer_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refrence_no", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_payment", System.Data.SqlDbType.Int, 4, "ID_payment"))
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(-1, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 16)
        Me.Label17.TabIndex = 138
        Me.Label17.Text = "Labor"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT GL_account, desc_GL_account FROM GL_account"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO GL_account(GL_account, desc_GL_account, GL_account_master, group_GL_a" & _
        "ccount, remark) VALUES (@GL_account, @desc_GL_account, @GL_account_master, @grou" & _
        "p_GL_account, @remark); SELECT GL_account, desc_GL_account, GL_account_master, g" & _
        "roup_GL_account, remark FROM GL_account WHERE (GL_account = @GL_account)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_GL_account", System.Data.SqlDbType.VarChar, 50, "desc_GL_account"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account_master", System.Data.SqlDbType.VarChar, 10, "GL_account_master"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@group_GL_account", System.Data.SqlDbType.VarChar, 2, "group_GL_account"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE GL_account SET GL_account = @GL_account, desc_GL_account = @desc_GL_accoun" & _
        "t, GL_account_master = @GL_account_master, group_GL_account = @group_GL_account," & _
        " remark = @remark WHERE (GL_account = @Original_GL_account) AND (GL_account_mast" & _
        "er = @Original_GL_account_master OR @Original_GL_account_master IS NULL AND GL_a" & _
        "ccount_master IS NULL) AND (desc_GL_account = @Original_desc_GL_account OR @Orig" & _
        "inal_desc_GL_account IS NULL AND desc_GL_account IS NULL) AND (group_GL_account " & _
        "= @Original_group_GL_account OR @Original_group_GL_account IS NULL AND group_GL_" & _
        "account IS NULL) AND (remark = @Original_remark OR @Original_remark IS NULL AND " & _
        "remark IS NULL); SELECT GL_account, desc_GL_account, GL_account_master, group_GL" & _
        "_account, remark FROM GL_account WHERE (GL_account = @GL_account)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account", System.Data.SqlDbType.VarChar, 10, "GL_account"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_GL_account", System.Data.SqlDbType.VarChar, 50, "desc_GL_account"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account_master", System.Data.SqlDbType.VarChar, 10, "GL_account_master"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@group_GL_account", System.Data.SqlDbType.VarChar, 2, "group_GL_account"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account_master", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account_master", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_GL_account", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_group_GL_account", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "group_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM GL_account WHERE (GL_account = @Original_GL_account) AND (GL_account_" & _
        "master = @Original_GL_account_master OR @Original_GL_account_master IS NULL AND " & _
        "GL_account_master IS NULL) AND (desc_GL_account = @Original_desc_GL_account OR @" & _
        "Original_desc_GL_account IS NULL AND desc_GL_account IS NULL) AND (group_GL_acco" & _
        "unt = @Original_group_GL_account OR @Original_group_GL_account IS NULL AND group" & _
        "_GL_account IS NULL) AND (remark = @Original_remark OR @Original_remark IS NULL " & _
        "AND remark IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account_master", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account_master", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_GL_account", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_group_GL_account", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "group_GL_account", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAGL_account
        '
        Me.DAGL_account.DeleteCommand = Me.SqlDeleteCommand1
        Me.DAGL_account.InsertCommand = Me.SqlInsertCommand1
        Me.DAGL_account.SelectCommand = Me.SqlSelectCommand1
        Me.DAGL_account.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_account", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("GL_account", "GL_account"), New System.Data.Common.DataColumnMapping("desc_GL_account", "desc_GL_account"), New System.Data.Common.DataColumnMapping("GL_account_master", "GL_account_master"), New System.Data.Common.DataColumnMapping("group_GL_account", "group_GL_account"), New System.Data.Common.DataColumnMapping("remark", "remark")})})
        Me.DAGL_account.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DAinv_adjustment_head
        '
        Me.DAinv_adjustment_head.DeleteCommand = Me.SqlDeleteCommand4
        Me.DAinv_adjustment_head.InsertCommand = Me.SqlInsertCommand4
        Me.DAinv_adjustment_head.SelectCommand = Me.SqlSelectCommand3
        Me.DAinv_adjustment_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_adjustment_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("referID_adjustment", "referID_adjustment"), New System.Data.Common.DataColumnMapping("date_adjustment", "date_adjustment"), New System.Data.Common.DataColumnMapping("adjustment_by", "adjustment_by"), New System.Data.Common.DataColumnMapping("authorized_by", "authorized_by"), New System.Data.Common.DataColumnMapping("explanation", "explanation"), New System.Data.Common.DataColumnMapping("GL_account_adjustment", "GL_account_adjustment"), New System.Data.Common.DataColumnMapping("comment", "comment"), New System.Data.Common.DataColumnMapping("DeliveryReciept", "DeliveryReciept"), New System.Data.Common.DataColumnMapping("NationalAccount", "NationalAccount"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor")})})
        Me.DAinv_adjustment_head.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM inv_adjustment_head WHERE (referID_adjustment = @Original_referID_adj" & _
        "ustment) AND (DeliveryReciept = @Original_DeliveryReciept OR @Original_DeliveryR" & _
        "eciept IS NULL AND DeliveryReciept IS NULL) AND (GL_account_adjustment = @Origin" & _
        "al_GL_account_adjustment OR @Original_GL_account_adjustment IS NULL AND GL_accou" & _
        "nt_adjustment IS NULL) AND (NationalAccount = @Original_NationalAccount OR @Orig" & _
        "inal_NationalAccount IS NULL AND NationalAccount IS NULL) AND (adjustment_by = @" & _
        "Original_adjustment_by OR @Original_adjustment_by IS NULL AND adjustment_by IS N" & _
        "ULL) AND (authorized_by = @Original_authorized_by OR @Original_authorized_by IS " & _
        "NULL AND authorized_by IS NULL) AND (cod_vendor = @Original_cod_vendor OR @Origi" & _
        "nal_cod_vendor IS NULL AND cod_vendor IS NULL) AND (comment = @Original_comment " & _
        "OR @Original_comment IS NULL AND comment IS NULL) AND (date_adjustment = @Origin" & _
        "al_date_adjustment OR @Original_date_adjustment IS NULL AND date_adjustment IS N" & _
        "ULL) AND (explanation = @Original_explanation OR @Original_explanation IS NULL A" & _
        "ND explanation IS NULL)"
        Me.SqlDeleteCommand4.Connection = Me.Cnn
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_referID_adjustment", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "referID_adjustment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DeliveryReciept", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeliveryReciept", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account_adjustment", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account_adjustment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NationalAccount", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NationalAccount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_adjustment_by", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "adjustment_by", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_authorized_by", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "authorized_by", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_comment", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "comment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_adjustment", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_adjustment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_explanation", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "explanation", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO inv_adjustment_head(referID_adjustment, date_adjustment, adjustment_b" & _
        "y, authorized_by, explanation, GL_account_adjustment, comment, DeliveryReciept, " & _
        "NationalAccount, cod_vendor) VALUES (@referID_adjustment, @date_adjustment, @adj" & _
        "ustment_by, @authorized_by, @explanation, @GL_account_adjustment, @comment, @Del" & _
        "iveryReciept, @NationalAccount, @cod_vendor); SELECT referID_adjustment, date_ad" & _
        "justment, adjustment_by, authorized_by, explanation, GL_account_adjustment, comm" & _
        "ent, DeliveryReciept, NationalAccount, cod_vendor FROM inv_adjustment_head WHERE" & _
        " (referID_adjustment = @referID_adjustment)"
        Me.SqlInsertCommand4.Connection = Me.Cnn
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@referID_adjustment", System.Data.SqlDbType.VarChar, 8, "referID_adjustment"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_adjustment", System.Data.SqlDbType.VarChar, 10, "date_adjustment"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@adjustment_by", System.Data.SqlDbType.VarChar, 5, "adjustment_by"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@authorized_by", System.Data.SqlDbType.VarChar, 5, "authorized_by"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@explanation", System.Data.SqlDbType.VarChar, 100, "explanation"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account_adjustment", System.Data.SqlDbType.VarChar, 10, "GL_account_adjustment"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@comment", System.Data.SqlDbType.VarChar, 200, "comment"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DeliveryReciept", System.Data.SqlDbType.VarChar, 10, "DeliveryReciept"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NationalAccount", System.Data.SqlDbType.VarChar, 10, "NationalAccount"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT referID_adjustment, date_adjustment, adjustment_by, authorized_by, explana" & _
        "tion, GL_account_adjustment, comment, DeliveryReciept, NationalAccount, cod_vend" & _
        "or FROM inv_adjustment_head WHERE (referID_adjustment = @referID_adjustment)"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@referID_adjustment", System.Data.SqlDbType.VarChar, 8, "referID_adjustment"))
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE inv_adjustment_head SET referID_adjustment = @referID_adjustment, date_adj" & _
        "ustment = @date_adjustment, adjustment_by = @adjustment_by, authorized_by = @aut" & _
        "horized_by, explanation = @explanation, GL_account_adjustment = @GL_account_adju" & _
        "stment, comment = @comment, DeliveryReciept = @DeliveryReciept, NationalAccount " & _
        "= @NationalAccount, cod_vendor = @cod_vendor WHERE (referID_adjustment = @Origin" & _
        "al_referID_adjustment) AND (DeliveryReciept = @Original_DeliveryReciept OR @Orig" & _
        "inal_DeliveryReciept IS NULL AND DeliveryReciept IS NULL) AND (GL_account_adjust" & _
        "ment = @Original_GL_account_adjustment OR @Original_GL_account_adjustment IS NUL" & _
        "L AND GL_account_adjustment IS NULL) AND (NationalAccount = @Original_NationalAc" & _
        "count OR @Original_NationalAccount IS NULL AND NationalAccount IS NULL) AND (adj" & _
        "ustment_by = @Original_adjustment_by OR @Original_adjustment_by IS NULL AND adju" & _
        "stment_by IS NULL) AND (authorized_by = @Original_authorized_by OR @Original_aut" & _
        "horized_by IS NULL AND authorized_by IS NULL) AND (cod_vendor = @Original_cod_ve" & _
        "ndor OR @Original_cod_vendor IS NULL AND cod_vendor IS NULL) AND (comment = @Ori" & _
        "ginal_comment OR @Original_comment IS NULL AND comment IS NULL) AND (date_adjust" & _
        "ment = @Original_date_adjustment OR @Original_date_adjustment IS NULL AND date_a" & _
        "djustment IS NULL) AND (explanation = @Original_explanation OR @Original_explana" & _
        "tion IS NULL AND explanation IS NULL); SELECT referID_adjustment, date_adjustmen" & _
        "t, adjustment_by, authorized_by, explanation, GL_account_adjustment, comment, De" & _
        "liveryReciept, NationalAccount, cod_vendor FROM inv_adjustment_head WHERE (refer" & _
        "ID_adjustment = @referID_adjustment)"
        Me.SqlUpdateCommand4.Connection = Me.Cnn
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@referID_adjustment", System.Data.SqlDbType.VarChar, 8, "referID_adjustment"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_adjustment", System.Data.SqlDbType.VarChar, 10, "date_adjustment"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@adjustment_by", System.Data.SqlDbType.VarChar, 5, "adjustment_by"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@authorized_by", System.Data.SqlDbType.VarChar, 5, "authorized_by"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@explanation", System.Data.SqlDbType.VarChar, 100, "explanation"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account_adjustment", System.Data.SqlDbType.VarChar, 10, "GL_account_adjustment"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@comment", System.Data.SqlDbType.VarChar, 200, "comment"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DeliveryReciept", System.Data.SqlDbType.VarChar, 10, "DeliveryReciept"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NationalAccount", System.Data.SqlDbType.VarChar, 10, "NationalAccount"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_referID_adjustment", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "referID_adjustment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DeliveryReciept", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DeliveryReciept", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account_adjustment", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account_adjustment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NationalAccount", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NationalAccount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_adjustment_by", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "adjustment_by", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_authorized_by", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "authorized_by", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vendor", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vendor", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_comment", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "comment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_adjustment", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_adjustment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_explanation", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "explanation", System.Data.DataRowVersion.Original, Nothing))
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowColumnDrag = False
        Me.GrdDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrdDetail.AutomaticSort = False
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.ContextMenu = Me.Cm1
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "inv_adjustment_dtl"
        Me.GrdDetail.DataSource = Me.DsFrmInventoryAdjustment1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>service_center_dtl</Caption><Columns Collec" & _
        "tion=""true""><Column0 ID=""Det""><Bound>False</Bound><ButtonStyle>ButtonCell</Butto" & _
        "nStyle><Caption>Find</Caption><EditType>NoEdit</EditType><Key>Det</Key><Position" & _
        ">0</Position><Selectable>False</Selectable><Width>31</Width></Column0><Column1 I" & _
        "D=""item_no""><Caption>Item No</Caption><DataMember>item_no</DataMember><Key>item_" & _
        "no</Key><Position>1</Position><Width>87</Width><CellStyle><BackColor>Silver</Bac" & _
        "kColor></CellStyle></Column1><Column2 ID=""desc_item""><Caption>Description</Capti" & _
        "on><DataMember>desc_item</DataMember><Key>desc_item</Key><Position>2</Position><" & _
        "Selectable>False</Selectable><Width>249</Width></Column2><Column3 ID=""qty""><Capt" & _
        "ion>Qty</Caption><DataMember>qty</DataMember><FormatString>####</FormatString><K" & _
        "ey>qty</Key><Position>3</Position><Width>48</Width><DefaultValue>0</DefaultValue" & _
        "><CellStyle><BackColor>Silver</BackColor></CellStyle></Column3><Column4 ID=""cost" & _
        """><Caption>Cost</Caption><DataMember>cost</DataMember><FormatString>c2</FormatSt" & _
        "ring><Key>cost</Key><Position>4</Position><Width>77</Width><DefaultValue>0</Defa" & _
        "ultValue><CellStyle><BackColor>Silver</BackColor></CellStyle></Column4><Column5 " & _
        "ID=""fet""><Caption>FET</Caption><DataMember>fet</DataMember><FormatString>c2</For" & _
        "matString><Key>fet</Key><Position>5</Position><Selectable>False</Selectable><Wid" & _
        "th>49</Width><DefaultValue>0</DefaultValue><CellStyle><BackColor>White</BackColo" & _
        "r></CellStyle></Column5><Column6 ID=""ExtCost""><Caption>Ext Cost</Caption><DataMe" & _
        "mber>Ext_Cost</DataMember><DefaultGroupPrefix>ExtCost:</DefaultGroupPrefix><Form" & _
        "atString>c2</FormatString><Key>ExtCost</Key><Position>6</Position><Selectable>Fa" & _
        "lse</Selectable><Width>94</Width><DefaultValue>0</DefaultValue></Column6><Column" & _
        "7 ID=""wieght_lbs""><Caption>wieght_lbs</Caption><DataMember>wieght_lbs</DataMembe" & _
        "r><Key>wieght_lbs</Key><Position>7</Position><Visible>False</Visible></Column7><" & _
        "Column8 ID=""referID_adjustment""><Caption>referID_adjustment</Caption><DataMember" & _
        ">referID_adjustment</DataMember><Key>referID_adjustment</Key><Position>8</Positi" & _
        "on><Visible>False</Visible></Column8><Column9 ID=""Column1""><Bound>False</Bound><" & _
        "ButtonStyle>ButtonCell</ButtonStyle><Caption>Det</Caption><ColumnType>Link</Colu" & _
        "mnType><EditType>NoEdit</EditType><Key>Column1</Key><Position>9</Position><Width" & _
        ">27</Width></Column9></Columns><GroupCondition ID="""" /><Key>service_center_dtl</" & _
        "Key><RowHeight>19</RowHeight></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.ExternalImageList = Me.imageList1
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(0, 212)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(687, 237)
        Me.GrdDetail.TabIndex = 139
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
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT inv_adjustment_dtl.referID_adjustment, inv_adjustment_dtl.item_no, inv_adj" & _
        "ustment_dtl.QTY, inv_adjustment_dtl.Cost, inv_adjustment_dtl.QTY * (inv_adjustme" & _
        "nt_dtl.Cost + inv_adjustment_dtl.fet) AS Ext_Cost, inv_item.desc_item, inv_tab_t" & _
        "ire_specification.wieght_lbs, inv_adjustment_dtl.fet FROM inv_tab_tire_specifica" & _
        "tion RIGHT OUTER JOIN inv_item ON inv_tab_tire_specification.item_no = inv_item." & _
        "item_no RIGHT OUTER JOIN inv_adjustment_dtl ON inv_item.item_no = inv_adjustment" & _
        "_dtl.item_no WHERE (inv_adjustment_dtl.referID_adjustment = @referID_adjustment)" & _
        ""
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@referID_adjustment", System.Data.SqlDbType.VarChar, 8, "referID_adjustment"))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO inv_adjustment_dtl(referID_adjustment, item_no, QTY, Cost, Fet) VALUE" & _
        "S (@referID_adjustment, @item_no, @QTY, @Cost, @Fet); SELECT referID_adjustment," & _
        " item_no, QTY, Cost, Fet FROM inv_adjustment_dtl WHERE (item_no = @item_no) AND " & _
        "(referID_adjustment = @referID_adjustment)"
        Me.SqlInsertCommand3.Connection = Me.Cnn
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@referID_adjustment", System.Data.SqlDbType.VarChar, 8, "referID_adjustment"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@QTY", System.Data.SqlDbType.SmallInt, 2, "QTY"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cost", System.Data.SqlDbType.Money, 8, "Cost"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fet", System.Data.SqlDbType.Money, 8, "Fet"))
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE inv_adjustment_dtl SET referID_adjustment = @referID_adjustment, item_no =" & _
        " @item_no, QTY = @QTY, Cost = @Cost, Fet = @Fet WHERE (item_no = @Original_item_" & _
        "no) AND (referID_adjustment = @Original_referID_adjustment) AND (Cost = @Origina" & _
        "l_Cost OR @Original_Cost IS NULL AND Cost IS NULL) AND (Fet = @Original_Fet) AND" & _
        " (QTY = @Original_QTY OR @Original_QTY IS NULL AND QTY IS NULL); SELECT referID_" & _
        "adjustment, item_no, QTY, Cost, Fet FROM inv_adjustment_dtl WHERE (item_no = @it" & _
        "em_no) AND (referID_adjustment = @referID_adjustment)"
        Me.SqlUpdateCommand3.Connection = Me.Cnn
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@referID_adjustment", System.Data.SqlDbType.VarChar, 8, "referID_adjustment"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@QTY", System.Data.SqlDbType.SmallInt, 2, "QTY"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cost", System.Data.SqlDbType.Money, 8, "Cost"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fet", System.Data.SqlDbType.Money, 8, "Fet"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_referID_adjustment", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "referID_adjustment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cost", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fet", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_QTY", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QTY", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM inv_adjustment_dtl WHERE (item_no = @Original_item_no) AND (referID_a" & _
        "djustment = @Original_referID_adjustment) AND (Cost = @Original_Cost OR @Origina" & _
        "l_Cost IS NULL AND Cost IS NULL) AND (Fet = @Original_Fet) AND (QTY = @Original_" & _
        "QTY OR @Original_QTY IS NULL AND QTY IS NULL)"
        Me.SqlDeleteCommand3.Connection = Me.Cnn
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_referID_adjustment", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "referID_adjustment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cost", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cost", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fet", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_QTY", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QTY", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAinv_adjustment_dtl
        '
        Me.DAinv_adjustment_dtl.DeleteCommand = Me.SqlDeleteCommand3
        Me.DAinv_adjustment_dtl.InsertCommand = Me.SqlInsertCommand3
        Me.DAinv_adjustment_dtl.SelectCommand = Me.SqlSelectCommand2
        Me.DAinv_adjustment_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_adjustment_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("referID_adjustment", "referID_adjustment"), New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("QTY", "QTY"), New System.Data.Common.DataColumnMapping("Cost", "Cost"), New System.Data.Common.DataColumnMapping("Fet", "Fet")})})
        Me.DAinv_adjustment_dtl.UpdateCommand = Me.SqlUpdateCommand3
        '
        'FrmInventoryAdjustment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(690, 449)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.TxtDate)
        Me.Controls.Add(Me.TxtRef)
        Me.Controls.Add(Me.PnlHead)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblStoreNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblCompanyName)
        Me.Location = New System.Drawing.Point(200, 200)
        Me.Name = "FrmInventoryAdjustment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "IA-Inventory Adjustment"
        CType(Me.DsFrmInventoryAdjustment1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.PnlHead.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmWorkOrders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        CnnReader.ConnectionString = PConnectionString

        MyItem = New UCInv_Item.Clsitem_no
        MyItem.Connection = Me.Cnn

        DsFrmInventoryAdjustment1.Clear()
        DAGL_account.Fill(DsFrmInventoryAdjustment1.GL_account)

        LblCompanyName.Text = PubCompanyName
        LblStoreNo.Text = PubStoreName
        TxtDate.Text = Format(Now.Date, PubDateFormat)

        If CodInventoryAdjustment <> "" Then
            TxtRef.Text = CodInventoryAdjustment
            If Not ShowPnlHead Then
                PnlHead.Visible = False
                PnlHead.Enabled = False
                Me.Height = Me.Height - PnlHead.Height
            End If
        Else
            TxtRef.Text = TakeLastRef()
        End If

        Call LoadData(TxtRef.Text)
        Call EnableDisableField(False)

        ThisFormStatus = MainModule.WorkStates._ReadOnly

        MyZipCode = New UCZipCode.ClsZipCode
        MyZipCode.Connection = Me.Cnn

        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        Dim SqlReader As System.Data.SqlClient.SqlDataReader
        OleDbReaderForStore = RetrieveGeneralLedgerSetupTable()

        default_inventory_adjment = OleDbReaderForStore.Item("default_inventory_adjment") & ""
        If default_inventory_adjment = "" Then
            MsgFar("Error in default inventory adjment")
        Else
            Try
                CmbGL_account.SelectedValue = default_inventory_adjment
            Catch ex As Exception
                MsgFar("Error in default inventory adjment in setup tables")
            End Try

        End If
    End Sub
    Private Sub AddEmptyRecordToDetail(ByVal ThisReferID_adjustment As String)
        Dim dr As DataRow
        dr = DsFrmInventoryAdjustment1.inv_adjustment_dtl.NewRow
        dr("referID_adjustment") = ThisReferID_adjustment
        dr("item_no") = ""
        dr("desc_item") = ""
        dr("qty") = 0
        dr("Cost") = 0
        dr("Fet") = 0
        dr("Ext_Cost") = 0
        DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows.Add(dr)
    End Sub
    Private Function MakeNewRef() As String
        Dim i As Integer
        Dim ValMakeNewcod As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select Max(referID_adjustment)  as Max_cod from inv_adjustment_head "
            MakeNewRef = Trim(CmdGeneral.ExecuteScalar)
            ValMakeNewcod = GetVal(MakeNewRef, 8)
            If ValMakeNewcod > 0 Then
                i = Len(ValMakeNewcod)
            Else
                i = 0
            End If
            If MakeNewRef.Length >= i Then
                MakeNewRef = Mid(MakeNewRef, 1, Len(MakeNewRef) - i) + Getcod(Str((Int(Val(ValMakeNewcod)) + 1)).Trim, Len(ValMakeNewcod))
            End If
            If MakeNewRef.Trim.Length > 8 Then
                MakeNewRef = "IA000001"
            End If
        Catch ex As Exception
            MakeNewRef = "IA000001"
        Finally
            CmdGeneral.Connection.Close()
        End Try
    End Function
    Private Function TakeLastRef() As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "Select top 1 referID_adjustment as Max_referID_adjustment from inv_adjustment_head ORDER BY referID_adjustment DESC"
        Try
            TakeLastRef = Trim(CmdGeneral.ExecuteScalar & "")
        Catch ex As Exception
            TakeLastRef = ""
        End Try

        If IsNothing(TakeLastRef) Then
            TakeLastRef = ""
        End If
        CmdGeneral.Connection.Close()
    End Function
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Call psave()
    End Sub
    Private Sub psave(Optional ByVal ThisChangeStatus As Boolean = True)
        Dim dr As DataRow, flg As Boolean
        Dim flgchangedid As Boolean = False
        If DsFrmInventoryAdjustment1.inv_adjustment_head.Rows.Count > 0 Then
            dr = DsFrmInventoryAdjustment1.inv_adjustment_head.Rows(0)
            flg = False
        Else
            dr = DsFrmInventoryAdjustment1.inv_adjustment_head.NewRow
            flg = True
        End If
        dr("referID_adjustment") = TxtRef.Text
        dr("date_adjustment") = TxtDate.Text
        dr("adjustment_by") = Employee_Cod1.EmployeeCod
        dr("authorized_by") = Employee_Cod2.EmployeeCod
        dr("DeliveryReciept") = TxtDeliveryReciept.Text
        dr("NationalAccount") = TxtNationalAccount.Text
        dr("cod_vendor") = IIf(Trim(Vendor_Cod1.cod_vendor).Length = 0, System.DBNull.Value, Vendor_Cod1.cod_vendor)
        dr("explanation") = TxtExplanation.Text
        dr("GL_account_adjustment") = CmbGL_account.SelectedValue
        dr("comment") = CommentButton.ZCommentText
        If flg Then
            DsFrmInventoryAdjustment1.inv_adjustment_head.Rows.Add(dr)
        End If
        Dim i As Long = 0
        Try
            For i = 0 To 10
                Try
                    DAinv_adjustment_head.Update(DsFrmInventoryAdjustment1.inv_adjustment_head)
                    Exit For
                Catch ex As Exception
                    If flg Then
                        TxtRef.Text = MakeNewRef()   'Trim(ClsRRP.MakeNewPoCod() & "")
                        DsFrmInventoryAdjustment1.inv_adjustment_head.Rows(0).Item("referID_adjustment") = TxtRef.Text.Trim
                        flgchangedid = True
                    Else
                        MsgBox(EX.ToString)
                    End If
                End Try
            Next


        Catch ex As Exception
            MsgBox("System Can't Save Information")
            Exit Sub
        End Try
        Dim RadifCounter As Integer = 1
        '-------------------------------------

        Dim dr1 As DataRow()
        dr1 = DsFrmInventoryAdjustment1.inv_adjustment_dtl.Select("trim( item_no) ='' or item_no is null")
        For i = 0 To dr1.Length - 1
            dr1(i).Delete()
        Next
        '---------------------------------------
        Call BeforeSave()
        If DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows.Count > 0 Then
            Dim CounterForSaving As Integer
            For CounterForSaving = 0 To DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows.Count - 1
                If DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(CounterForSaving).RowState <> DataRowState.Deleted Then
                    If DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(CounterForSaving).RowState <> DataRowState.Deleted Then
                        If Trim(DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(CounterForSaving).Item("item_no")).Trim.Length > 0 Then
                            DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(CounterForSaving).Item("referID_adjustment") = DsFrmInventoryAdjustment1.inv_adjustment_head.Rows(0).Item("referID_adjustment")
                            RadifCounter = RadifCounter + 1
                        Else
                            DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(CounterForSaving).Delete()
                            CounterForSaving = CounterForSaving - 1
                        End If
                    End If
                End If

            Next
        End If
        Try
            Dim dt As DataTable
            dt = DsFrmInventoryAdjustment1.inv_adjustment_dtl.GetChanges(DataRowState.Deleted)
            If Not dt Is Nothing Then
                Try
                    If dt.Rows.Count > 0 Then DAinv_adjustment_dtl.Update(dt)
                Catch ex As Exception
                End Try
            End If

            dt = DsFrmInventoryAdjustment1.inv_adjustment_dtl.GetChanges(DataRowState.Modified)
            If Not dt Is Nothing Then
                Try
                    If dt.Rows.Count > 0 Then DAinv_adjustment_dtl.Update(dt)
                Catch ex As Exception
                End Try
            End If

            dt = DsFrmInventoryAdjustment1.inv_adjustment_dtl.GetChanges(DataRowState.Added)
            If Not dt Is Nothing Then
                Try
                    If dt.Rows.Count > 0 Then DAinv_adjustment_dtl.Update(dt)
                Catch ex As Exception
                End Try
            End If

            Call AfterSave()

            If flgchangedid = True Then
                Dim MyFrmShowChangedNo As New FrmShowChangedNo
                MyFrmShowChangedNo.LblNewNo.Text = TxtRef.Text
                MyFrmShowChangedNo.LblOldNo.Text = OldReferenceNo
                MyFrmShowChangedNo.ShowDialog()
            End If



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        If ThisChangeStatus Then
            ThisFormStatus = MainModule.WorkStates._ReadOnly
            Call EnableDisableField(False)
            Call EnableDisableBtn()
        Else
            Dim IFirstCount As Integer = DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows.Count()
            Dim AddEmptyRecordToDetailCount As Integer
            For AddEmptyRecordToDetailCount = 1 + IFirstCount To RowNoToAdd + IFirstCount
                Call AddEmptyRecordToDetail(TxtRef.Text)
            Next
        End If
        Call CalcSumOfExt_price()
        Call LoadData(TxtRef.Text)
    End Sub

    Sub BeforeSave()
        Dim i As Decimal, qty As Decimal
        Dim itmno As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            With BeforeEditedDataset
                For i = 0 To .inv_adjustment_dtl.Rows.Count - 1
                    If .inv_adjustment_dtl.Rows(i).RowState <> DataRowState.Deleted Then
                        itmno = .inv_adjustment_dtl.Rows(i).Item("item_no") & ""
                        qty = .inv_adjustment_dtl.Rows(i).Item("QTY")
                        If itmno.Trim <> "" Then
                            CmdGeneral.CommandText = "update inv_Tab_item_Warehouse  set  on_hand= on_hand -  " & qty & " where Item_No= " & Qt(itmno.Trim) & "  And cod_warehouse = " & Qt(PWareHouse)
                            CmdGeneral.ExecuteNonQuery()
                        End If
                    End If
                Next
            End With

        Catch ex As Exception
        Finally
            CmdGeneral.Connection.Close()
        End Try
    End Sub

    Sub AfterSave()
        Dim i As Decimal, qty As Decimal
        Dim itmno As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            With DsFrmInventoryAdjustment1
                For i = 0 To .inv_adjustment_dtl.Rows.Count - 1
                    If .inv_adjustment_dtl.Rows(i).RowState <> DataRowState.Deleted Then
                        itmno = .inv_adjustment_dtl.Rows(i).Item("item_no") & ""
                        qty = .inv_adjustment_dtl.Rows(i).Item("QTY")
                        If itmno.Trim <> "" Then
                            CmdGeneral.CommandText = "update inv_Tab_item_Warehouse  set  on_hand = on_hand+  " & qty & " where Item_No= " & Qt(itmno.Trim) & "  And cod_warehouse = " & Qt(PWareHouse)
                            CmdGeneral.ExecuteNonQuery()
                        End If
                    End If
                Next
            End With

        Catch ex As Exception
        Finally
            CmdGeneral.Connection.Close()
        End Try

    End Sub

    'Private Sub SetMojoodiAfterSave(ByVal CounterForSaving As Integer)
    '    Dim i As Double
    '    If CmdGeneral.Connection.State <> ConnectionState.Open Then
    '        CmdGeneral.Connection.Open()
    '    End If
    '    CmdGeneral.CommandText = "Update inv_tab_item_warehouse Set on_hand= on_hand +  " & DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(CounterForSaving).Item("qty") & " Where item_no=" & Qt(DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(CounterForSaving).Item("item_no")) & " AND cod_warehouse=" & Qt(PWareHouse)
    '    CmdGeneral.ExecuteNonQuery()
    'End Sub
    'Private Sub SetPrevMojoodi(ByVal ThisCounter As Double)
    '    Dim SQLReader As System.Data.SqlClient.SqlDataReader
    '    If CmdReader.Connection.State <> ConnectionState.Open Then
    '        CmdReader.Connection.Open()
    '    End If
    '    CmdReader.CommandText = "SELECT * from inv_adjustment_dtl where referID_adjustment=" & Qt(DsFrmInventoryAdjustment1.inv_adjustment_head.Rows(0).Item("referID_adjustment"))
    '    SQLReader = CmdReader.ExecuteReader
    '    If SQLReader.HasRows Then
    '        If CmdGeneral.Connection.State <> ConnectionState.Open Then
    '            CmdGeneral.Connection.Open()
    '        End If
    '        Do While SQLReader.Read()
    '            CmdGeneral.CommandText = "Update inv_tab_item_warehouse Set on_hand=on_hand - " & SQLReader.Item("qty") & " Where item_no=" & Qt(DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(ThisCounter).Item("item_no")) & " AND cod_warehouse=" & Qt(PWareHouse)
    '            CmdGeneral.ExecuteNonQuery()
    '        Loop
    '        CmdGeneral.Connection.Close()
    '    End If
    '    SQLReader.Close()
    '    CmdReader.Connection.Close()
    'End Sub
    Private Sub GrdDetail_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.ColumnButtonClick
        Dim row As Integer = GrdDetail.Row
        Select Case e.Column.Index
            Case 0
                Call FndItemCode()
                SendKeys.Send("{ENTER}")
            Case 9
                frmitem.Item_noTempVar = GrdDetail.GetRow.Cells(1).Value & ""
                frmitem.ShowDialog()
        End Select
        'GrdDetail.Focus()
        'Call SelectRow(row, 3)
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
    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        BeforeEditedDataset.Clear()
        ThisFormStatus = MainModule.WorkStates.AddNew
        Call EnableDisableField(True)
        Call EnableDisableBtn()
        DsFrmInventoryAdjustment1.inv_adjustment_head.Clear()
        DsFrmInventoryAdjustment1.inv_adjustment_dtl.Clear()
        Call ClearAllField()
        TxtRef.Text = MakeNewRef()
        OldReferenceNo = TxtRef.Text
        Dim IFirstCount As Integer = DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows.Count()
        Dim AddEmptyRecordToDetailCount As Integer
        For AddEmptyRecordToDetailCount = 1 + IFirstCount To RowNoToAdd + IFirstCount
            Call AddEmptyRecordToDetail(TxtRef.Text)
        Next
        Employee_Cod1.Focus()
        Try
            CmbGL_account.SelectedValue = default_inventory_adjment
        Catch ex As Exception
            MsgFar("Error in default inventory adjment in setup tables")
        End Try
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
    Private Sub PFirstRecord(Optional ByVal ShowMsgFlag As Boolean = True)
        Try
            If TxtRef.Text.Trim.Length > 0 Then
                Dim TXTRef_NoTmp As String
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "SELECT Top 1 referID_adjustment From inv_adjustment_head Order BY referID_adjustment ASC"
                TXTRef_NoTmp = CmdGeneral.ExecuteScalar() & ""
                CmdGeneral.Connection.Close()
                If TXTRef_NoTmp = TxtRef.Text Then
                    If ShowMsgFlag Then MsgFar("First Record")
                Else
                    Call LoadData(TXTRef_NoTmp)
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
                Dim TXTRef_NoTmp As String
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "SELECT Top 1 referID_adjustment From inv_adjustment_head WHERE referID_adjustment < " & Qt(TxtRef.Text) & " Order BY referID_adjustment Desc"
                TXTRef_NoTmp = CmdGeneral.ExecuteScalar() & ""
                CmdGeneral.Connection.Close()
                If TXTRef_NoTmp.Trim = TxtRef.Text.Trim Or TXTRef_NoTmp.Trim.Length = 0 Then
                    If ShowMsgFlag Then MsgFar("First Record")
                Else
                    Call LoadData(TXTRef_NoTmp)
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
                Dim TXTRef_NoTmp As String
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "SELECT Top 1 referID_adjustment From inv_adjustment_head WHERE referID_adjustment > " & Qt(TxtRef.Text) & " Order BY referID_adjustment Asc"
                TXTRef_NoTmp = CmdGeneral.ExecuteScalar() & ""
                CmdGeneral.Connection.Close()
                If TXTRef_NoTmp.Trim = TxtRef.Text.Trim Or TXTRef_NoTmp.Trim.Length = 0 Then
                    If ShowMsgFlag Then MsgFar("Last Record")
                Else
                    Call LoadData(TXTRef_NoTmp)
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
                Dim TXTRef_NoTmp As String
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "SELECT Top 1 referID_adjustment From inv_adjustment_head Order BY referID_adjustment DESC"
                TXTRef_NoTmp = CmdGeneral.ExecuteScalar() & ""
                CmdGeneral.Connection.Close()
                If TXTRef_NoTmp = TxtRef.Text Then
                    If ShowMsgFlag Then MsgFar("Last Record")
                Else
                    Call LoadData(TXTRef_NoTmp)
                End If
            Else
                MsgFar("There is no Row in Database")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub LoadData(ByVal ThisRefNo As String)
        DsFrmInventoryAdjustment1.inv_adjustment_head.Clear()
        DsFrmInventoryAdjustment1.inv_adjustment_dtl.Clear()
        DAinv_adjustment_head.SelectCommand.Parameters("@referID_adjustment").Value = ThisRefNo
        DAinv_adjustment_head.Fill(DsFrmInventoryAdjustment1.inv_adjustment_head)
        Try
            DAinv_adjustment_dtl.SelectCommand.Parameters("@referID_adjustment").Value = ThisRefNo
            DAinv_adjustment_dtl.Fill(DsFrmInventoryAdjustment1.inv_adjustment_dtl)
        Catch ex As Exception
        End Try
        Call ClearAllField()
        Call FillDataInScreen()
        Call CalcSumOfExt_price()
    End Sub
    Private Sub FillDataInScreen()
        With DsFrmInventoryAdjustment1.inv_adjustment_head
            If .Rows.Count > 0 Then
                Employee_Cod1.EmployeeCod = .Rows(0).Item("adjustment_by") & ""
                Employee_Cod2.EmployeeCod = .Rows(0).Item("authorized_by") & ""
                TxtDate.Text = .Rows(0).Item("date_adjustment") & ""
                TxtRef.Text = .Rows(0).Item("referID_adjustment") & ""
                TxtExplanation.Text = .Rows(0).Item("explanation") & ""
                TxtDeliveryReciept.Text = .Rows(0).Item("DeliveryReciept") & ""
                TxtNationalAccount.Text = .Rows(0).Item("NationalAccount") & ""
                Try
                    Vendor_Cod1.VendorCod = .Rows(0).Item("cod_vendor") & ""
                Catch ex As Exception
                End Try
                Try
                    CmbGL_account.SelectedValue = .Rows(0).Item("GL_account_adjustment") & ""
                Catch ex As Exception
                End Try
                LblFET.Text = 0
                LblParts.Text = 0
                LblTotal.Text = 0
                LblTotQty.Text = 0
                LbltotWeight.Text = 0
                CommentButton.ZCommentText = .Rows(0).Item("comment") & ""
            End If
        End With
    End Sub
    Private Sub ClearAllField()
        TxtRef.Text = TakeLastRef()
        TxtExplanation.Text = ""
        Employee_Cod1.EmployeeCod = ""
        Employee_Cod2.EmployeeCod = ""
        LblEmpName1.Text = ""
        LblEmpName2.Text = ""
        Vendor_Cod1.VendorCod = ""
        LblVendorName.Text = ""
        TxtDeliveryReciept.Text = ""
        TxtNationalAccount.Text = ""
        TxtDate.Text = Format(Now.Date, PubDateFormat)
        TxtRef.Clear()
        LblFET.Text = 0
        LblParts.Text = 0
        LblTotal.Text = 0
        LblTotQty.Text = 0
        LbltotWeight.Text = 0
        CommentButton.ZCommentText = ""
    End Sub
    Private Sub EnableDisableSave()
        If CmbGL_account.Text.Trim.Length > 0 And Employee_Cod1.EmployeeCod.Trim.Length > 0 And Employee_Cod2.EmployeeCod.Trim.Length > 0 And BtnNew.Enabled = False Then
            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If
    End Sub
    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        BeforeEditedDataset.Clear()
        BeforeEditedDataset = DsFrmInventoryAdjustment1.Copy()
        If TxtRef.Text.Trim.Length > 0 Then
            ThisFormStatus = MainModule.WorkStates.Delete

            Dim c1 As New FrmWhatDoForMenu
            c1.BtnLeftText = "Cancel"
            c1.BtnRightText = "Delete"
            c1.ShowFarMsg("Are you sure?")
            If c1.DialogResult = DialogResult.OK Then
                Dim TxtRefTemp As String = TxtRef.Text
                If DeleteThisAdjustment(TxtRef.Text) Then

                    Call BeforeSave()
                    Call PPreviousRecord(False)
                    If TxtRefTemp = TxtRef.Text Then
                        Call PNextRecord(False)
                        If TxtRefTemp = TxtRef.Text Then
                            Call ClearAllField()
                        End If
                    End If
                End If
            Else
                Employee_Cod1.Focus()
            End If
            ThisFormStatus = MainModule.WorkStates._ReadOnly
        End If
    End Sub
    Private Function DeleteThisAdjustment(ByVal ThisRef_no As String) As Boolean
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = " Delete From inv_adjustment_head Where referID_adjustment=" & Qt(ThisRef_no)
        Try
            CmdGeneral.ExecuteNonQuery()

        '    Call SetPrevMojoodiForDelete()

            DeleteThisAdjustment = True
            MsgFar("The selected record was deleted")
        Catch ex As Exception
            DeleteThisAdjustment = False
            MsgFar("Can't Delete This Record")
        Finally
            CmdGeneral.Connection.Close()
        End Try
        Employee_Cod1.Focus()
    End Function
    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        BeforeEditedDataset.Clear()
        BeforeEditedDataset = DsFrmInventoryAdjustment1.Copy()
        If TxtRef.Text.Trim.Length > 0 Then
            ThisFormStatus = MainModule.WorkStates.Edit
            Call EnableDisableField(True)
            Call EnableDisableBtn()
            Dim AddEmptyRecordToDetailCount As Integer
            Dim IFirstCount As Integer = DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows.Count()
            For AddEmptyRecordToDetailCount = 1 + IFirstCount To RowNoToAdd + IFirstCount
                Call AddEmptyRecordToDetail(TxtRef.Text)
            Next
            Employee_Cod1.Focus()
        End If
    End Sub
    Private Sub EnableDisableField(ByVal InStatus As Boolean)
        CmbGL_account.Enabled = InStatus
        Employee_Cod1.Enabled = InStatus
        Employee_Cod2.Enabled = InStatus
        TxtExplanation.Enabled = InStatus
        TxtDeliveryReciept.Enabled = InStatus
        TxtNationalAccount.Enabled = InStatus
        Vendor_Cod1.Enabled = InStatus
        GrdDetail.Enabled = InStatus
        CommentButton.ZEnabled = InStatus
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        BeforeEditedDataset.Clear()
        ThisFormStatus = MainModule.WorkStates._ReadOnly
        Call EnableDisableField(False)
        Call EnableDisableBtn()
        Call LoadData(TakeLastRef())
    End Sub
    Sub InitBeforeRow()
        BeforeCel = GrdDetail.Col
        BeforeRow = GrdDetail.Row
        BeforeRowEx = GrdDetail.GetRow
    End Sub
    Private Sub GrdDetail_CurrentCellChanging(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.CurrentCellChangingEventArgs) Handles GrdDetail.CurrentCellChanging
        Call EnableDisableSave()
        Call InitBeforeRow()
    End Sub
    Private Sub CalcSumOfExt_price()
        'Call CalcExt_Price()
        LblParts.Text = 0
        Dim TaxablePrice As Double = 0
        Dim TaxPercent As Double = 0

        LblParts.Text = 0
        LblFET.Text = 0
        LblTotal.Text = 0
        LblTotQty.Text = 0
        LbltotWeight.Text = 0
        LblTotal.Text = 0
        Dim i As Double
        GrdDetail.UpdateData()

        Try
            For i = 0 To DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows.Count - 1
                If DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(i).RowState <> DataRowState.Deleted Then
                    If Trim(DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(i).Item(0)) & "" <> "" Then
                        'DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(i).Item("Ext_Cost") = DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(i).Item("Qty") * (DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(i).Item("Cost") + DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(i).Item("Fet"))
                        LblParts.Text = Math.Round(Val(LblParts.Text & "") + DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(i).Item("qty") * DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(i).Item("Cost"), 2)
                        LblFET.Text = Math.Round(Val(LblFET.Text & "") + DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(i).Item("Fet"), 2)
                        LblTotal.Text = Math.Round(Val(LblParts.Text & "") + Val(LblFET.Text & ""), 2)    'DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(i).Item("qty") * DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(i).Item("Cost")
                        LblTotQty.Text = Math.Round(Val("" & LblTotQty.Text) + DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(i).Item("qty"), 2)
                        LbltotWeight.Text = Math.Round(Val(DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(i).Item("wieght_lbs") & "") * DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(i).Item("qty"), 2) + Val(LbltotWeight.Text & "")

                    Else
                        Exit For
                    End If

                End If
            Next
        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub GrdDetail_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrdDetail.CurrentCellChanged
        Dim ValueString As String = ""
        Dim CurrentRowGrid As Long = GrdDetail.Row
        Dim crow As GridEXRow = GrdDetail.GetRow
        If BeforeRowEx Is Nothing Or BeforeCel < 0 Or BeforeRow < 0 Then
            Exit Sub
        End If
        Try
            ValueString = BeforeRowEx.Cells(BeforeCel).Value & ""
            Select Case BeforeCel
                Case 1
                    If BeforeRow = CurrentRowGrid Then
                        If Trim(ValueString & "") <> "" Then
                            If MyItem.FindDesc(ValueString) = False Then
                                MsgFar("Cod is invalid")
                                Call SelectRow(CurrentRowGrid, 1)
                            Else
                                If CheckItemNoRepeat() = False Then
                                    MyItem.FindItemCost(ValueString)
                                Else
                                    MsgFar("Cod is Repeated")
                                    GrdDetail.GetRow.Cells(1).Value = ""
                                End If
                            End If
                        End If
                    End If
                Case 6, 7 'QTY  ,  Price
                    'call CalcSumOfExt_price()
                    'Call CalcExt_Price()
                Case 8, 9
                    'Call CalcSumOfExt_price()
            End Select
            Try
                With GrdDetail.GetRow
                    .Cells(6).Value = .Cells(3).Value * (.Cells(4).Value + .Cells(5).Value)
                End With
            Catch ex As Exception
            End Try
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Call CalcSumOfExt_price()
    End Sub
    Private Sub GrdDetail_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdDetail.KeyDown
        If ThisFormStatus <> MainModule.WorkStates._ReadOnly Then
            Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
            Dim CurrentRowGrid As Long = 2
            Dim flg2 As Boolean = False

            Dim row As Integer = GrdDetail.Row
            Dim col As Integer = GrdDetail.Col
            '-------------------------------------------------------------
            Select Case e.Control
                Case True
                    'Select Case e.KeyCode
                    '    Case Keys.Delete
                    '        Call DeleteThisRecord()
                    '    Case Keys.Insert
                    '        Call InsertThisRecord()
                    'End Select
                Case False
                    If e.Shift = False And e.Control = False And e.Alt = False Then
                        Select Case e.KeyCode
                            Case Keys.F2
                                Select Case GrdDetail.Col
                                    Case 1 ' ItemCode
                                        Call FndItemCode()
                                        Call SelectRow(row, 3)
                                End Select
                            Case Keys.Enter, Keys.Tab
                                'If GrdDetail.Col = Sequence.TranQty Then
                                '    SendKeys.Send(vbTab)
                                'End If
                                'IssueFlagSave = True
                            Case Keys.F9
                                'Dim MyFrmKardexKala As New FrmKardexKala
                                'MyFrmKardexKala.TopLevel = False
                                'MyFrmKardexKala.Parent = Me.Parent
                                'MyFrmKardexKala.ThisFormStatus = MainModule.WorkStates._ReadOnly
                                'MyFrmKardexKala.InvCodeParam = InvCode1.Text
                                'MyFrmKardexKala.ItemCodeParam = CurrentRow.Cells(1).Value
                                'MyFrmKardexKala.Show()
                                'MyFrmKardexKala.BringToFront()
                        End Select
                    End If
            End Select
        End If
    End Sub
    Sub SelectRow(ByVal ThisRow As Integer, Optional ByVal ThisItemCodeFocus As Integer = 4)
        GrdDetail.Row = ThisRow
        GrdDetail.Col = ThisItemCodeFocus
        GrdDetail.SelectCurrentCellText()
    End Sub
    Private Function FndItemCode() As String
        'MyFrmSearchItemCode.FrmSearchInv_anbar_kalaCodAnbar = InvCode1.Text
        Call InitBeforeRow()
        Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        MyFrmSearchItemCode.ShowDialog()
        'GrdDetail.UpdateData()
        GrdDetail.Focus()

    End Function
    Private Sub MyFrmSearchItemCode_Item_noFind(ByVal ThisItemCode As String, ByVal ThisItemDesc As String) Handles MyFrmSearchItemCode.Item_noFind
        Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        If ThisFormStatus = MainModule.WorkStates.AddNew Or ThisFormStatus = MainModule.WorkStates.Edit Then
            'GrdDetail.Focus()
            'GrdDetail.Row = CurrentRow.RowIndex
            Try
                'GrdDetail.Focus()
                'GrdDetail.UpdateData()
                'GrdDetail.Row = CurrentRow.RowIndex 'Row = CurrentRow.RowIndex
                'GrdDetail.Col = 1
                GrdDetail.GetRow.Cells(1).Value = ThisItemCode
                GrdDetail.GetRow.Cells(2).Value = ThisItemDesc

                'SendKeys.Send("{ENTER}")
                '    GrdDetail.UpdateData()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            'GrdDetail.UpdateData()
            '    SelectRow(GrdDetail.Row, 1)
        End If
    End Sub
    Private Sub GrdDetail_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrdDetail.GotFocus
        SelectRow(GrdDetail.Row, 1)
    End Sub
    Private Function SayItemName() As Boolean
        SayItemName = True
        Dim ThisRowGrid As GridEXRow = GrdDetail.GetRow
        Try
            MyItem.Item_no = ThisRowGrid.Cells(1).Value & ""
            If ThisRowGrid.Cells(1).Value & "" <> "" Then
                If MyItem.FindDesc(MyItem.Item_no) Then
                    ThisRowGrid.Cells(2).Value = MyItem.desc_Item
                    'Dim FetOdThisItem As Decimal = 0
                    'MyItem.FindItemCost(MyItem.Item_no)
                Else
                    SayItemName = False
                End If
            Else
                'clearthisline(ThisRowGrid)
            End If
        Catch ex As Exception
            SayItemName = False
        End Try

    End Function

    Private Sub FrmWorkOrders_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Employee_Cod1.EmployeeCod = ""
        Employee_Cod2.EmployeeCod = ""
    End Sub
    Private Sub Employee_Cod1_NotFindEmployeeCod() Handles Employee_Cod1.NotFindEmployeeCod
        LblEmpName1.Text = ""
    End Sub
    Private Sub Employee_Cod1_FindEmployeeCod() Handles Employee_Cod1.FindEmployeeCod
        LblEmpName1.Text = Employee_Cod1.Desc_Employee
    End Sub
    Private Sub Employee_Cod2_NotFindEmployeeCod() Handles Employee_Cod2.NotFindEmployeeCod
        LblEmpName2.Text = ""
    End Sub
    Private Sub Employee_Cod2_FindEmployeeCod() Handles Employee_Cod2.FindEmployeeCod
        LblEmpName2.Text = Employee_Cod2.Desc_Employee
    End Sub
    Private Sub TxtExplanation_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtExplanation.TextChanged, CmbGL_account.SelectedIndexChanged, LblEmpName1.TextChanged, LblEmpName2.TextChanged, TxtDeliveryReciept.TextChanged, TxtNationalAccount.TextChanged, LblVendorName.TextChanged
        Call EnableDisableSave()
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
        If DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows.Count > 0 Then
            Dim rpt As New RepInventoryAdj
            Dim prn As New FrmRepView
            Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
            OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)

            Try
                If OleDbReaderForStore.Item("InventoryAdjustmentsShading") = 0 Then
                    rpt.SetParameterValue("ShadingParam", True)
                Else
                    rpt.SetParameterValue("ShadingParam", False)
                End If
            Catch ex As Exception
                rpt.SetParameterValue("ShadingParam", False)
            End Try

            rpt.SetParameterValue("ParStoreShortName", PubStoreName & "")
            rpt.SetParameterValue("Parconame", OleDbReaderForStore.Item("STORENAME") & "")
            rpt.SetParameterValue("Parcoaddress", OleDbReaderForStore.Item("ADDRESS") & "")

            MyZipCode.ZipCode = OleDbReaderForStore.Item("ZipCode")
            MyZipCode.FindDesc(OleDbReaderForStore.Item("ZipCode"))
            rpt.SetParameterValue("Parcoaddress2", MyZipCode.City & " " & MyZipCode.State & " " & MyZipCode.ZipCode & "")

            rpt.SetParameterValue("Parcophone", OleDbReaderForStore.Item("PHONE") & "")
            rpt.SetParameterValue("Parcofax", OleDbReaderForStore.Item("FAX") & "")
            'rpt.SetParameterValue("Parcoemail", OleDbReaderForStore.Item("EMAIL") & "")

            'Dim OleDbReaderForCompany As System.Data.OleDb.OleDbDataReader
            'OleDbReaderForCompany = RetrieveCompanySetupTable()

            'rpt.SetParameterValue("Parcowebsite", OleDbReaderForCompany.Item("WEBPAGE"))
            rpt.SetParameterValue("paradjby", Employee_Cod1.Text)
            rpt.SetParameterValue("parauthby", Employee_Cod2.Text)
            rpt.SetParameterValue("paradjdate", TxtDate.Text)
            rpt.SetParameterValue("partime", Format(TimeOfDay, "Short Time"))
            rpt.SetParameterValue("paradjno", TxtRef.Text)
            rpt.SetParameterValue("parcomment", CommentButton.ZCommentText)
            rpt.SetParameterValue("parpart", LblParts.Text)
            rpt.SetParameterValue("partotalqty", LblTotQty.Text)
            rpt.SetParameterValue("parfet", LblFET.Text)
            rpt.SetParameterValue("partotalw", LbltotWeight.Text)
            rpt.SetParameterValue("parsubtotal", "")
            rpt.SetParameterValue("partax", "")
            rpt.SetParameterValue("partotal", LblTotal.Text)
            rpt.SetParameterValue("parkindrep", "Inventory Adjustment")

            rpt.SetDataSource(DsFrmInventoryAdjustment1)
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
    Private Sub MyItem_FindItemCostRow(ByVal ThisRow As System.Data.DataRow) Handles MyItem.FindItemCostRow
        Dim ThisRowGrid As GridEXRow = GrdDetail.GetRow
        If Trim(GrdDetail.GetRow.Cells(1).Value & "") <> "" Then
            ' If Val(GrdDetail.GetRow.Cells(5).Value) = 0 Then
            GrdDetail.GetRow.Cells(5).Value = Math.Round(Val(ThisRow.Item("Fet") & ""), 2)
            'End If
            If Val(GrdDetail.GetRow.Cells(4).Value & "") = 0 Then
                GrdDetail.GetRow.Cells(4).Value = Math.Round(Val(ThisRow.Item("Cost") & ""), 2)
            End If
        Else
            GrdDetail.GetRow.Cells(4).Value = 0
            GrdDetail.GetRow.Cells(5).Value = 0
            GrdDetail.GetRow.Cells(2).Value = ""
        End If
        'ThisRowGrid.Cells(5).Value = Math.Round(CDec("0" & ThisRow("fet")), 2)
    End Sub
    Private Sub MyItem_FindItemNoRow(ByVal ThisRow As System.Data.DataRow) Handles MyItem.FindItemNoRow
        Try
            GrdDetail.GetRow.Cells(7).Value = CDec("0" & ThisRow("wieght_lbs"))
        Catch ex As Exception
        End Try
        GrdDetail.GetRow.Cells(2).Value = ThisRow("Desc_Item") & ""
    End Sub
    Function CheckItemNoRepeat() As Boolean
        CheckItemNoRepeat = False
        Dim i As Long
        Dim dr1 As DataRow()
        If GrdDetail.GetRow.Cells(1).Value & "" <> "" Then
            GrdDetail.UpdateData()
            dr1 = DsFrmInventoryAdjustment1.inv_adjustment_dtl.Select("trim( item_no) =" & Qt(GrdDetail.GetRow.Cells(1).Value))
            If dr1.Length >= 2 Then
                CheckItemNoRepeat = True
            End If
        End If
    End Function
    Private Sub ClsItem1_NotFindItemNo() Handles MyItem.NotFindItemNo
        GrdDetail.GetRow.Cells(2).Value = ""
        GrdDetail.GetRow.Cells(5).Value = 0
        GrdDetail.GetRow.Cells(4).Value = 0
    End Sub
    Private Sub GrdDetail_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GrdDetail.UpdatingRecord
        Try
            With GrdDetail.GetRow
                .Cells(6).Value = .Cells(3).Value * (.Cells(4).Value + .Cells(5).Value)
            End With
        Catch ex As Exception
        End Try
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Call DeleteThisRow()

    End Sub
    Sub DeleteThisRow()
        Dim i As Integer, j As Integer
        Dim Currentrow As Int64 = GrdDetail.Row
        'DsFrmInventoryAdjustment1.inv_adjustment_dtl.FindByreferID_adjustmentitem_no(GrdDetail.GetRow.Cells(8).Value & "", GrdDetail.GetRow.Cells(2).Value & "").Delete()
        Dim drow As DataRow() = DsFrmInventoryAdjustment1.inv_adjustment_dtl.Select("referID_adjustment =" & Qt(GrdDetail.GetRow.Cells(8).Value & "") & " and item_no = " & Qt(GrdDetail.GetRow.Cells(1).Value & ""))

        If drow.LongLength > 0 Then
            drow(0).Delete()
        End If


        GrdDetail.UpdateData()
        Call AddEmptyRecordToDetail(TxtRef.Text)
        GrdDetail.UpdateData()
        GrdDetail.Refetch()
        GrdDetail.Row = Currentrow
        EnableDisableSave()
        CalcSumOfExt_price()
    End Sub

    Sub InsertThisRow(ByVal InTHisPosition As Integer)

        Dim Currentrow As Int64 = InTHisPosition 'GrdDetail.Row
        Call AddEmptyRecordToDetail(TxtRef.Text)
        Dim i As Integer = 0
        'Dim j As Integer = 0
        'For i = DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows.Count - 1 To Currentrow Step -1
        '    With DsFrmInventoryAdjustment1.inv_adjustment_dtl
        '        For j = 0 To 7
        '            Try
        '                .Rows(i).Item(j) = .Rows(i - 1).Item(j)
        '            Catch ex As Exception
        '            End Try
        '        Next
        '    End With
        'Next
        Currentrow = 1

        For i = 0 To DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows.Count - 1
            With DsFrmInventoryAdjustment1.inv_adjustment_dtl(i)
                If .RowState <> DataRowState.Deleted Then
                    If Trim(.Item("item_no") & "") = "" Then
                        Currentrow = i
                        Exit For
                    End If
                End If
            End With
        Next
        '    With DsFrmInventoryAdjustment1.inv_adjustment_dtl
        '        For j = 0 To 7
        '            Try
        '                .Rows(i).Item(j) = .Rows(i - 1).Item(j)
        '            Catch ex As Exception
        '            End Try
        '        Next
        '    End With
        'Next

        With DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(Currentrow)
            .Item("referID_adjustment") = TxtRef.Text
            .Item("item_no") = ""
            .Item("desc_item") = ""
            .Item("qty") = 0
            .Item("Cost") = 0
            .Item("Fet") = 0
            .Item("Ext_Cost") = 0
            .Item("wieght_lbs") = 0
        End With
        GrdDetail.Refetch()
        GrdDetail.Row = Currentrow
        EnableDisableSave()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Call InsertThisRow(GrdDetail.Row)
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        MyFrmSearchInventoryAdjustment = New FrmSearchInventoryAdjustment
        MyFrmSearchInventoryAdjustment.ShowDialog()
    End Sub
    Private Sub FrmSearchInventoryAdjustment_PoFind(ByVal ThisId As String) Handles MyFrmSearchInventoryAdjustment.InvAdjFind
        If ThisId.Trim & "" <> "" Then
            LoadData(ThisId)
        End If
    End Sub
    Private Sub Vendor_Cod1_FindVendorCod() Handles Vendor_Cod1.FindVendorCod
        LblVendorName.Text = Vendor_Cod1.Desc_Vendor
    End Sub
    Private Sub Vendor_Cod1_NotFindVendorCod() Handles Vendor_Cod1.NotFindVendorCod
        LblVendorName.Text = ""
    End Sub

    Private Sub GrdDetail_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GrdDetail.FormattingRow

    End Sub

    Private Sub PnlHead_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PnlHead.Paint

    End Sub
End Class
