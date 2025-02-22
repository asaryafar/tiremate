Imports CommonClass
Imports Janus.Windows.GridEX
Public Class FrmInterStoreSale
    Inherits CommonClass.FrmBase
    Dim MyFrmComments As CommonClass.FrmItemComments
    Dim Cls1 As New ClsInterStoreSale
    Dim CommentVar As String = ""
    Private MTypeOfForm As String = ""
    Dim BeforeEditedDataset As New DSFrmInterStoreSale
    Dim WithEvents MyFrm1 As UCInv_Item.FrmSearchItemCode
    Dim BeforeRowEx As GridEXRow = Nothing
    Dim RowNoToAdd As Integer = 50
    Dim BeforeCel As Integer = -1
    Dim BeforeRow As Integer = -1
    Dim WithEvents ClsItem1 As UCInv_Item.Clsitem_no
    Dim CurrentCost As Decimal = 0
    Dim WithEvents MyZipCode As UCZipCode.ClsZipCode
    Public CodInterStoreSale As String = ""
    Public ShowPnlHead As Boolean = True
    Dim WithEvents FrmSearchInterStoreSale1 As FrmSearchInterStoreSale
    Dim OldReferenceNo As String = ""
    Public Property TypeOfForm() As String
        Get
            Return MTypeOfForm
        End Get
        Set(ByVal Value As String)
            MTypeOfForm = Value
        End Set
    End Property
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
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LblCompanyName As System.Windows.Forms.Label
    Friend WithEvents TxtRef As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents LblFET As System.Windows.Forms.Label
    Friend WithEvents LblTotalQty As System.Windows.Forms.Label
    Friend WithEvents LblwEIGHT As System.Windows.Forms.Label
    Friend WithEvents LblParts As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Lblby_action As System.Windows.Forms.Label
    Friend WithEvents Lblauthoriz_action As System.Windows.Forms.Label
    Friend WithEvents Cmbby_action As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbauthoriz_action As System.Windows.Forms.ComboBox
    Friend WithEvents LblStoreNo As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmInterStoreSale1 As UcInterStoreSale.DSFrmInterStoreSale
    Friend WithEvents DaEmploye As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CnnMdbSetup As System.Data.OleDb.OleDbConnection
    Friend WithEvents DASTORE_SETUP As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents CmbSoldTo As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSoldBy As System.Windows.Forms.ComboBox
    Friend WithEvents TxtNote As System.Windows.Forms.TextBox
    Friend WithEvents BtnComment As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Dainv_salse_transfer_head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Lblstore_from As System.Windows.Forms.Label
    Friend WithEvents LabelNote As System.Windows.Forms.Label
    Friend WithEvents LabelSoldTo As System.Windows.Forms.Label
    Friend WithEvents Labname As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Dainv_sales_transfer_dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Txtdate_action As CalendarCombo.CalendarCombo
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Cm1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents PnlHead As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmInterStoreSale))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.PnlHead = New System.Windows.Forms.Panel
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
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Txtdate_action = New CalendarCombo.CalendarCombo
        Me.Labname = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtRef = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.LblCompanyName = New System.Windows.Forms.Label
        Me.LblStoreNo = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.BtnComment = New System.Windows.Forms.Button
        Me.TxtNote = New System.Windows.Forms.TextBox
        Me.CmbSoldTo = New System.Windows.Forms.ComboBox
        Me.DsFrmInterStoreSale1 = New UcInterStoreSale.DSFrmInterStoreSale
        Me.CmbSoldBy = New System.Windows.Forms.ComboBox
        Me.Cmbauthoriz_action = New System.Windows.Forms.ComboBox
        Me.Cmbby_action = New System.Windows.Forms.ComboBox
        Me.LabelSoldTo = New System.Windows.Forms.Label
        Me.Lblauthoriz_action = New System.Windows.Forms.Label
        Me.LabelNote = New System.Windows.Forms.Label
        Me.Lblstore_from = New System.Windows.Forms.Label
        Me.Lblby_action = New System.Windows.Forms.Label
        Me.LblTotal = New System.Windows.Forms.Label
        Me.LblFET = New System.Windows.Forms.Label
        Me.LblTotalQty = New System.Windows.Forms.Label
        Me.LblwEIGHT = New System.Windows.Forms.Label
        Me.LblParts = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaEmploye = New System.Data.SqlClient.SqlDataAdapter
        Me.CnnMdbSetup = New System.Data.OleDb.OleDbConnection
        Me.DASTORE_SETUP = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Dainv_salse_transfer_head = New System.Data.SqlClient.SqlDataAdapter
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.Cm1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Dainv_sales_transfer_dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.PnlHead.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DsFrmInterStoreSale1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlHead
        '
        Me.PnlHead.BackColor = System.Drawing.SystemColors.Window
        Me.PnlHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlHead.Controls.Add(Me.Label29)
        Me.PnlHead.Controls.Add(Me.Label28)
        Me.PnlHead.Controls.Add(Me.BtnPrint)
        Me.PnlHead.Controls.Add(Me.BtnPreview)
        Me.PnlHead.Controls.Add(Me.Label33)
        Me.PnlHead.Controls.Add(Me.BtnCancel)
        Me.PnlHead.Controls.Add(Me.Label36)
        Me.PnlHead.Controls.Add(Me.BtnFirst)
        Me.PnlHead.Controls.Add(Me.Label37)
        Me.PnlHead.Controls.Add(Me.BtnLast)
        Me.PnlHead.Controls.Add(Me.Label32)
        Me.PnlHead.Controls.Add(Me.BtnEdit)
        Me.PnlHead.Controls.Add(Me.Label25)
        Me.PnlHead.Controls.Add(Me.Label24)
        Me.PnlHead.Controls.Add(Me.Label15)
        Me.PnlHead.Controls.Add(Me.Label14)
        Me.PnlHead.Controls.Add(Me.Label3)
        Me.PnlHead.Controls.Add(Me.Label1)
        Me.PnlHead.Controls.Add(Me.BtnDelete)
        Me.PnlHead.Controls.Add(Me.BtnNew)
        Me.PnlHead.Controls.Add(Me.BtnFind)
        Me.PnlHead.Controls.Add(Me.BtnNext)
        Me.PnlHead.Controls.Add(Me.BtnPrev)
        Me.PnlHead.Controls.Add(Me.BtnSave)
        Me.PnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHead.Location = New System.Drawing.Point(0, 0)
        Me.PnlHead.Name = "PnlHead"
        Me.PnlHead.Size = New System.Drawing.Size(702, 45)
        Me.PnlHead.TabIndex = 6
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(488, 32)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 200
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(440, 32)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(45, 10)
        Me.Label28.TabIndex = 199
        Me.Label28.Text = "Preview"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(485, 1)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 198
        '
        'BtnPreview
        '
        Me.BtnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPreview.Image = CType(resources.GetObject("BtnPreview.Image"), System.Drawing.Image)
        Me.BtnPreview.Location = New System.Drawing.Point(445, 1)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(33, 27)
        Me.BtnPreview.TabIndex = 197
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
        Me.BtnCancel.Location = New System.Drawing.Point(376, 1)
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
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEHSERVER;packet size=4096;user id=sa;data source=armandehser" & _
        "ver;persist security info=False;initial catalog=TireMate_02"
        '
        'CmdGeneral
        '
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
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Txtdate_action)
        Me.Panel1.Controls.Add(Me.Labname)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtRef)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.LblCompanyName)
        Me.Panel1.Controls.Add(Me.LblStoreNo)
        Me.Panel1.Location = New System.Drawing.Point(0, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 44)
        Me.Panel1.TabIndex = 7
        '
        'Txtdate_action
        '
        Me.Txtdate_action.BackColor = System.Drawing.SystemColors.Info
        Me.Txtdate_action.BorderColor = System.Drawing.Color.Empty
        Me.Txtdate_action.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtdate_action.ButtonBackColor = System.Drawing.Color.Empty
        Me.Txtdate_action.ButtonForeColor = System.Drawing.Color.Empty
        Me.Txtdate_action.EditableSal = True
        Me.Txtdate_action.Image = CType(resources.GetObject("Txtdate_action.Image"), System.Drawing.Image)
        Me.Txtdate_action.Location = New System.Drawing.Point(353, 11)
        Me.Txtdate_action.MaxValue = CType(2500, Short)
        Me.Txtdate_action.MinValue = CType(1800, Short)
        Me.Txtdate_action.Name = "Txtdate_action"
        Me.Txtdate_action.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txtdate_action.Sal_Mali = Nothing
        Me.Txtdate_action.ShowButton = True
        Me.Txtdate_action.Size = New System.Drawing.Size(108, 23)
        Me.Txtdate_action.TabIndex = 0
        Me.Txtdate_action.VisualStyle = False
        '
        'Labname
        '
        Me.Labname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labname.ForeColor = System.Drawing.Color.Black
        Me.Labname.Location = New System.Drawing.Point(190, 9)
        Me.Labname.Name = "Labname"
        Me.Labname.Size = New System.Drawing.Size(115, 29)
        Me.Labname.TabIndex = 148
        Me.Labname.Text = "Inter-Store Sale"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(312, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 21)
        Me.Label2.TabIndex = 146
        Me.Label2.Text = "Date"
        '
        'TxtRef
        '
        Me.TxtRef.BackColor = System.Drawing.SystemColors.Window
        Me.TxtRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRef.Enabled = False
        Me.TxtRef.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtRef.Location = New System.Drawing.Point(503, 13)
        Me.TxtRef.Name = "TxtRef"
        Me.TxtRef.ReadOnly = True
        Me.TxtRef.Size = New System.Drawing.Size(96, 21)
        Me.TxtRef.TabIndex = 145
        Me.TxtRef.Text = ""
        Me.TxtRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label16.Location = New System.Drawing.Point(470, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 21)
        Me.Label16.TabIndex = 144
        Me.Label16.Text = "Ref"
        '
        'LblCompanyName
        '
        Me.LblCompanyName.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblCompanyName.Location = New System.Drawing.Point(2, 2)
        Me.LblCompanyName.Name = "LblCompanyName"
        Me.LblCompanyName.Size = New System.Drawing.Size(182, 38)
        Me.LblCompanyName.TabIndex = 5
        Me.LblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblStoreNo
        '
        Me.LblStoreNo.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblStoreNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblStoreNo.Location = New System.Drawing.Point(602, 6)
        Me.LblStoreNo.Name = "LblStoreNo"
        Me.LblStoreNo.Size = New System.Drawing.Size(90, 31)
        Me.LblStoreNo.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.BtnComment)
        Me.Panel2.Controls.Add(Me.TxtNote)
        Me.Panel2.Controls.Add(Me.CmbSoldTo)
        Me.Panel2.Controls.Add(Me.CmbSoldBy)
        Me.Panel2.Controls.Add(Me.Cmbauthoriz_action)
        Me.Panel2.Controls.Add(Me.Cmbby_action)
        Me.Panel2.Controls.Add(Me.LabelSoldTo)
        Me.Panel2.Controls.Add(Me.Lblauthoriz_action)
        Me.Panel2.Controls.Add(Me.LabelNote)
        Me.Panel2.Controls.Add(Me.Lblstore_from)
        Me.Panel2.Controls.Add(Me.Lblby_action)
        Me.Panel2.Location = New System.Drawing.Point(1, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(695, 104)
        Me.Panel2.TabIndex = 1
        '
        'BtnComment
        '
        Me.BtnComment.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnComment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnComment.Location = New System.Drawing.Point(565, 9)
        Me.BtnComment.Name = "BtnComment"
        Me.BtnComment.Size = New System.Drawing.Size(116, 21)
        Me.BtnComment.TabIndex = 56
        Me.BtnComment.TabStop = False
        Me.BtnComment.Text = "Comment"
        '
        'TxtNote
        '
        Me.TxtNote.Location = New System.Drawing.Point(90, 71)
        Me.TxtNote.MaxLength = 50
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.Size = New System.Drawing.Size(310, 20)
        Me.TxtNote.TabIndex = 4
        Me.TxtNote.Text = ""
        '
        'CmbSoldTo
        '
        Me.CmbSoldTo.DataSource = Me.DsFrmInterStoreSale1.STORE_SETUP1
        Me.CmbSoldTo.DisplayMember = "STORENO"
        Me.CmbSoldTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSoldTo.Location = New System.Drawing.Point(292, 40)
        Me.CmbSoldTo.Name = "CmbSoldTo"
        Me.CmbSoldTo.Size = New System.Drawing.Size(108, 21)
        Me.CmbSoldTo.TabIndex = 3
        Me.CmbSoldTo.ValueMember = "STORENO"
        '
        'DsFrmInterStoreSale1
        '
        Me.DsFrmInterStoreSale1.DataSetName = "DSFrmInterStoreSale"
        Me.DsFrmInterStoreSale1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'CmbSoldBy
        '
        Me.CmbSoldBy.DataSource = Me.DsFrmInterStoreSale1.STORE_SETUP
        Me.CmbSoldBy.DisplayMember = "STORENO"
        Me.CmbSoldBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSoldBy.Location = New System.Drawing.Point(91, 40)
        Me.CmbSoldBy.Name = "CmbSoldBy"
        Me.CmbSoldBy.Size = New System.Drawing.Size(104, 21)
        Me.CmbSoldBy.TabIndex = 2
        Me.CmbSoldBy.ValueMember = "STORENO"
        '
        'Cmbauthoriz_action
        '
        Me.Cmbauthoriz_action.DataSource = Me.DsFrmInterStoreSale1.employee1
        Me.Cmbauthoriz_action.DisplayMember = "l_name"
        Me.Cmbauthoriz_action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbauthoriz_action.Location = New System.Drawing.Point(292, 8)
        Me.Cmbauthoriz_action.Name = "Cmbauthoriz_action"
        Me.Cmbauthoriz_action.Size = New System.Drawing.Size(108, 21)
        Me.Cmbauthoriz_action.TabIndex = 1
        Me.Cmbauthoriz_action.ValueMember = "employee_code"
        '
        'Cmbby_action
        '
        Me.Cmbby_action.DataSource = Me.DsFrmInterStoreSale1.employee
        Me.Cmbby_action.DisplayMember = "l_name"
        Me.Cmbby_action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbby_action.Location = New System.Drawing.Point(91, 8)
        Me.Cmbby_action.Name = "Cmbby_action"
        Me.Cmbby_action.Size = New System.Drawing.Size(104, 21)
        Me.Cmbby_action.TabIndex = 0
        Me.Cmbby_action.ValueMember = "employee_code"
        '
        'LabelSoldTo
        '
        Me.LabelSoldTo.Location = New System.Drawing.Point(202, 38)
        Me.LabelSoldTo.Name = "LabelSoldTo"
        Me.LabelSoldTo.Size = New System.Drawing.Size(86, 23)
        Me.LabelSoldTo.TabIndex = 4
        Me.LabelSoldTo.Text = "Sold To"
        Me.LabelSoldTo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Lblauthoriz_action
        '
        Me.Lblauthoriz_action.Location = New System.Drawing.Point(202, 8)
        Me.Lblauthoriz_action.Name = "Lblauthoriz_action"
        Me.Lblauthoriz_action.Size = New System.Drawing.Size(86, 23)
        Me.Lblauthoriz_action.TabIndex = 3
        Me.Lblauthoriz_action.Text = "Autorized By"
        Me.Lblauthoriz_action.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelNote
        '
        Me.LabelNote.Location = New System.Drawing.Point(8, 69)
        Me.LabelNote.Name = "LabelNote"
        Me.LabelNote.Size = New System.Drawing.Size(80, 23)
        Me.LabelNote.TabIndex = 2
        Me.LabelNote.Text = "Note"
        Me.LabelNote.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Lblstore_from
        '
        Me.Lblstore_from.Location = New System.Drawing.Point(8, 38)
        Me.Lblstore_from.Name = "Lblstore_from"
        Me.Lblstore_from.Size = New System.Drawing.Size(80, 23)
        Me.Lblstore_from.TabIndex = 1
        Me.Lblstore_from.Text = "Sold By"
        Me.Lblstore_from.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Lblby_action
        '
        Me.Lblby_action.Location = New System.Drawing.Point(8, 8)
        Me.Lblby_action.Name = "Lblby_action"
        Me.Lblby_action.Size = New System.Drawing.Size(80, 23)
        Me.Lblby_action.TabIndex = 0
        Me.Lblby_action.Text = "Writen By"
        Me.Lblby_action.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotal.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblTotal.ForeColor = System.Drawing.Color.Black
        Me.LblTotal.Location = New System.Drawing.Point(52, 30)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(71, 16)
        Me.LblTotal.TabIndex = 5
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblFET
        '
        Me.LblFET.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblFET.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFET.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblFET.ForeColor = System.Drawing.Color.Black
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
        Me.LblTotalQty.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblTotalQty.ForeColor = System.Drawing.Color.Black
        Me.LblTotalQty.Location = New System.Drawing.Point(52, 46)
        Me.LblTotalQty.Name = "LblTotalQty"
        Me.LblTotalQty.Size = New System.Drawing.Size(71, 16)
        Me.LblTotalQty.TabIndex = 6
        Me.LblTotalQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblwEIGHT
        '
        Me.LblwEIGHT.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblwEIGHT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblwEIGHT.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblwEIGHT.ForeColor = System.Drawing.Color.Black
        Me.LblwEIGHT.Location = New System.Drawing.Point(52, 60)
        Me.LblwEIGHT.Name = "LblwEIGHT"
        Me.LblwEIGHT.Size = New System.Drawing.Size(71, 16)
        Me.LblwEIGHT.TabIndex = 7
        Me.LblwEIGHT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblParts
        '
        Me.LblParts.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblParts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblParts.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblParts.ForeColor = System.Drawing.Color.Black
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
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(-1, 30)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(54, 16)
        Me.Label23.TabIndex = 144
        Me.Label23.Text = "Total $"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label19.ForeColor = System.Drawing.Color.Black
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
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(-1, 45)
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
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(-1, 60)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 16)
        Me.Label17.TabIndex = 138
        Me.Label17.Text = "TotWeight"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(-1, -1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 16)
        Me.Label11.TabIndex = 137
        Me.Label11.Text = "Parts"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.LblTotal)
        Me.Panel3.Controls.Add(Me.LblFET)
        Me.Panel3.Controls.Add(Me.LblTotalQty)
        Me.Panel3.Controls.Add(Me.LblwEIGHT)
        Me.Panel3.Controls.Add(Me.LblParts)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(412, 103)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(125, 77)
        Me.Panel3.TabIndex = 9
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT employee_code, l_name, m_name, f_name FROM employee WHERE (Terminated = 0)" & _
        " ORDER BY l_name"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DaEmploye
        '
        Me.DaEmploye.SelectCommand = Me.SqlSelectCommand1
        Me.DaEmploye.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "employee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("technecian", "technecian"), New System.Data.Common.DataColumnMapping("SalesPerson", "SalesPerson"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cod_position", "cod_position"), New System.Data.Common.DataColumnMapping("cod_deparment", "cod_deparment"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("pic", "pic"), New System.Data.Common.DataColumnMapping("birthday_date", "birthday_date"), New System.Data.Common.DataColumnMapping("hired_date", "hired_date"), New System.Data.Common.DataColumnMapping("last_reiew_date", "last_reiew_date"), New System.Data.Common.DataColumnMapping("terminate_date", "terminate_date"), New System.Data.Common.DataColumnMapping("temporary_inactive", "temporary_inactive"), New System.Data.Common.DataColumnMapping("last_basis", "last_basis"), New System.Data.Common.DataColumnMapping("last_period", "last_period"), New System.Data.Common.DataColumnMapping("last_status", "last_status"), New System.Data.Common.DataColumnMapping("last_salary", "last_salary"), New System.Data.Common.DataColumnMapping("last_hourly", "last_hourly"), New System.Data.Common.DataColumnMapping("last_overtime", "last_overtime"), New System.Data.Common.DataColumnMapping("Last_raise_date", "Last_raise_date"), New System.Data.Common.DataColumnMapping("Allowance_Federal", "Allowance_Federal"), New System.Data.Common.DataColumnMapping("Allowance_state", "Allowance_state"), New System.Data.Common.DataColumnMapping("Allowance_depndnts", "Allowance_depndnts"), New System.Data.Common.DataColumnMapping("Terminated", "Terminated")})})
        '
        'CnnMdbSetup
        '
        Me.CnnMdbSetup.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\TireMate\TireMatesetup.mdb;Persis" & _
        "t Security Info=True;Jet OLEDB:Database Password=5332"
        '
        'DASTORE_SETUP
        '
        Me.DASTORE_SETUP.SelectCommand = Me.OleDbCommand1
        Me.DASTORE_SETUP.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "STORE_SETUP", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("STORENO", "STORENO"), New System.Data.Common.DataColumnMapping("STORENAME", "STORENAME"), New System.Data.Common.DataColumnMapping("SHORTNAME", "SHORTNAME")})})
        '
        'OleDbCommand1
        '
        Me.OleDbCommand1.CommandText = "SELECT STORENO, STORENAME, SHORTNAME FROM STORE_SETUP ORDER BY STORENO"
        Me.OleDbCommand1.Connection = Me.CnnMdbSetup
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT ID_sales_transfer, type_sales_transfer, by_action, authoriz_action, store_" & _
        "from, store_to, date_action, note, comment FROM inv_salse_transfer_head WHERE (I" & _
        "D_sales_transfer = @id_sales_transfer)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_sales_transfer", System.Data.SqlDbType.VarChar, 10, "ID_sales_transfer"))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO inv_salse_transfer_head(ID_sales_transfer, type_sales_transfer, by_ac" & _
        "tion, authoriz_action, store_from, store_to, date_action, note, comment) VALUES " & _
        "(@ID_sales_transfer, @type_sales_transfer, @by_action, @authoriz_action, @store_" & _
        "from, @store_to, @date_action, @note, @comment); SELECT ID_sales_transfer, type_" & _
        "sales_transfer, by_action, authoriz_action, store_from, store_to, date_action, n" & _
        "ote, comment FROM inv_salse_transfer_head WHERE (ID_sales_transfer = @ID_sales_t" & _
        "ransfer)"
        Me.SqlInsertCommand1.CommandTimeout = 10
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_sales_transfer", System.Data.SqlDbType.VarChar, 10, "ID_sales_transfer"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_sales_transfer", System.Data.SqlDbType.Char, 1, "type_sales_transfer"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@by_action", System.Data.SqlDbType.VarChar, 5, "by_action"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@authoriz_action", System.Data.SqlDbType.VarChar, 5, "authoriz_action"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@store_from", System.Data.SqlDbType.VarChar, 2, "store_from"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@store_to", System.Data.SqlDbType.VarChar, 2, "store_to"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_action", System.Data.SqlDbType.VarChar, 10, "date_action"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@note", System.Data.SqlDbType.VarChar, 50, "note"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@comment", System.Data.SqlDbType.VarChar, 200, "comment"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE inv_salse_transfer_head SET ID_sales_transfer = @ID_sales_transfer, type_s" & _
        "ales_transfer = @type_sales_transfer, by_action = @by_action, authoriz_action = " & _
        "@authoriz_action, store_from = @store_from, store_to = @store_to, date_action = " & _
        "@date_action, note = @note, comment = @comment WHERE (ID_sales_transfer = @Origi" & _
        "nal_ID_sales_transfer) AND (authoriz_action = @Original_authoriz_action OR @Orig" & _
        "inal_authoriz_action IS NULL AND authoriz_action IS NULL) AND (by_action = @Orig" & _
        "inal_by_action OR @Original_by_action IS NULL AND by_action IS NULL) AND (commen" & _
        "t = @Original_comment OR @Original_comment IS NULL AND comment IS NULL) AND (dat" & _
        "e_action = @Original_date_action OR @Original_date_action IS NULL AND date_actio" & _
        "n IS NULL) AND (note = @Original_note OR @Original_note IS NULL AND note IS NULL" & _
        ") AND (store_from = @Original_store_from OR @Original_store_from IS NULL AND sto" & _
        "re_from IS NULL) AND (store_to = @Original_store_to OR @Original_store_to IS NUL" & _
        "L AND store_to IS NULL) AND (type_sales_transfer = @Original_type_sales_transfer" & _
        "); SELECT ID_sales_transfer, type_sales_transfer, by_action, authoriz_action, st" & _
        "ore_from, store_to, date_action, note, comment FROM inv_salse_transfer_head WHER" & _
        "E (ID_sales_transfer = @ID_sales_transfer)"
        Me.SqlUpdateCommand1.CommandTimeout = 10
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_sales_transfer", System.Data.SqlDbType.VarChar, 10, "ID_sales_transfer"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_sales_transfer", System.Data.SqlDbType.Char, 1, "type_sales_transfer"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@by_action", System.Data.SqlDbType.VarChar, 5, "by_action"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@authoriz_action", System.Data.SqlDbType.VarChar, 5, "authoriz_action"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@store_from", System.Data.SqlDbType.VarChar, 2, "store_from"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@store_to", System.Data.SqlDbType.VarChar, 2, "store_to"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_action", System.Data.SqlDbType.VarChar, 10, "date_action"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@note", System.Data.SqlDbType.VarChar, 50, "note"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@comment", System.Data.SqlDbType.VarChar, 200, "comment"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_sales_transfer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_sales_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_authoriz_action", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "authoriz_action", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_by_action", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "by_action", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_comment", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "comment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_action", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_action", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_note", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "note", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_store_from", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "store_from", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_store_to", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "store_to", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_sales_transfer", System.Data.SqlDbType.Char, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_sales_transfer", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM inv_salse_transfer_head WHERE (ID_sales_transfer = @Original_ID_sales" & _
        "_transfer) AND (authoriz_action = @Original_authoriz_action OR @Original_authori" & _
        "z_action IS NULL AND authoriz_action IS NULL) AND (by_action = @Original_by_acti" & _
        "on OR @Original_by_action IS NULL AND by_action IS NULL) AND (comment = @Origina" & _
        "l_comment OR @Original_comment IS NULL AND comment IS NULL) AND (date_action = @" & _
        "Original_date_action OR @Original_date_action IS NULL AND date_action IS NULL) A" & _
        "ND (note = @Original_note OR @Original_note IS NULL AND note IS NULL) AND (store" & _
        "_from = @Original_store_from OR @Original_store_from IS NULL AND store_from IS N" & _
        "ULL) AND (store_to = @Original_store_to OR @Original_store_to IS NULL AND store_" & _
        "to IS NULL) AND (type_sales_transfer = @Original_type_sales_transfer)"
        Me.SqlDeleteCommand1.CommandTimeout = 10
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_sales_transfer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_sales_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_authoriz_action", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "authoriz_action", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_by_action", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "by_action", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_comment", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "comment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_action", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_action", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_note", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "note", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_store_from", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "store_from", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_store_to", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "store_to", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_sales_transfer", System.Data.SqlDbType.Char, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_sales_transfer", System.Data.DataRowVersion.Original, Nothing))
        '
        'Dainv_salse_transfer_head
        '
        Me.Dainv_salse_transfer_head.DeleteCommand = Me.SqlDeleteCommand1
        Me.Dainv_salse_transfer_head.InsertCommand = Me.SqlInsertCommand1
        Me.Dainv_salse_transfer_head.SelectCommand = Me.SqlSelectCommand2
        Me.Dainv_salse_transfer_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_salse_transfer_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_sales_transfer", "ID_sales_transfer"), New System.Data.Common.DataColumnMapping("type_sales_transfer", "type_sales_transfer"), New System.Data.Common.DataColumnMapping("by_action", "by_action"), New System.Data.Common.DataColumnMapping("authoriz_action", "authoriz_action"), New System.Data.Common.DataColumnMapping("store_from", "store_from"), New System.Data.Common.DataColumnMapping("store_to", "store_to"), New System.Data.Common.DataColumnMapping("date_action", "date_action"), New System.Data.Common.DataColumnMapping("note", "note"), New System.Data.Common.DataColumnMapping("comment", "comment")})})
        Me.Dainv_salse_transfer_head.UpdateCommand = Me.SqlUpdateCommand1
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowColumnDrag = False
        Me.GrdDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GrdDetail.AutomaticSort = False
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.ContextMenu = Me.Cm1
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "inv_sales_transfer_dtl"
        Me.GrdDetail.DataSource = Me.DsFrmInterStoreSale1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>service_center_dtl</Caption><Columns Collec" & _
        "tion=""true""><Column0 ID=""Det""><Bound>False</Bound><ButtonStyle>ButtonCell</Butto" & _
        "nStyle><EditType>NoEdit</EditType><Key>Det</Key><Position>0</Position><Selectabl" & _
        "e>False</Selectable><Width>27</Width></Column0><Column1 ID=""item_no""><Caption>It" & _
        "em No</Caption><DataMember>item_no</DataMember><Key>item_no</Key><Position>1</Po" & _
        "sition><Width>93</Width><CellStyle><BackColor>Silver</BackColor></CellStyle></Co" & _
        "lumn1><Column2 ID=""desc_item""><Caption>Description</Caption><DataMember>desc_ite" & _
        "m</DataMember><Key>desc_item</Key><Position>2</Position><Selectable>False</Selec" & _
        "table><Width>319</Width></Column2><Column3 ID=""qty""><Caption>Qty</Caption><DataM" & _
        "ember>qty</DataMember><FormatString>####</FormatString><Key>qty</Key><Position>3" & _
        "</Position><Width>48</Width><DefaultValue>0</DefaultValue><CellStyle><BackColor>" & _
        "Silver</BackColor></CellStyle></Column3><Column4 ID=""cost""><Caption>Price</Capti" & _
        "on><DataMember>price</DataMember><FormatString>c2</FormatString><Key>cost</Key><" & _
        "Position>4</Position><Width>77</Width><DefaultValue>0</DefaultValue><CellStyle><" & _
        "BackColor>Silver</BackColor></CellStyle></Column4><Column5 ID=""fet""><Caption>FET" & _
        "</Caption><DataMember>fet</DataMember><FormatString>c2</FormatString><Key>fet</K" & _
        "ey><Position>5</Position><Selectable>False</Selectable><Width>49</Width><Default" & _
        "Value>0</DefaultValue><CellStyle><BackColor>White</BackColor></CellStyle></Colum" & _
        "n5><Column6 ID=""ExtCost""><Caption>Ext Price</Caption><DataMember>ExCost</DataMem" & _
        "ber><DefaultGroupPrefix>ExtCost:</DefaultGroupPrefix><FormatString>c2</FormatStr" & _
        "ing><Key>ExtCost</Key><Position>6</Position><Selectable>False</Selectable><Width" & _
        ">78</Width><DefaultValue>0</DefaultValue></Column6></Columns><GroupCondition ID=" & _
        """"" /><Key>service_center_dtl</Key><RowHeight>19</RowHeight></RootTable></GridEXL" & _
        "ayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.ExternalImageList = Me.imageList1
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(0, 196)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(702, 264)
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
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT inv_sales_transfer_dtl.ID_sales_transfer, inv_sales_transfer_dtl.item_no, " & _
        "inv_sales_transfer_dtl.qty, inv_sales_transfer_dtl.price, inv_sales_transfer_dtl" & _
        ".fet, inv_item.desc_item, inv_sales_transfer_dtl.qty * (inv_sales_transfer_dtl.f" & _
        "et + inv_sales_transfer_dtl.price) AS excost FROM inv_sales_transfer_dtl INNER J" & _
        "OIN inv_item ON inv_sales_transfer_dtl.item_no = inv_item.item_no WHERE (inv_sal" & _
        "es_transfer_dtl.ID_sales_transfer = @id_sales_transfer)"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_sales_transfer", System.Data.SqlDbType.VarChar, 10, "ID_sales_transfer"))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO inv_sales_transfer_dtl(ID_sales_transfer, item_no, qty, price, fet) V" & _
        "ALUES (@ID_sales_transfer, @item_no, @qty, @price, @fet); SELECT ID_sales_transf" & _
        "er, item_no, qty, price, fet FROM inv_sales_transfer_dtl WHERE (ID_sales_transfe" & _
        "r = @ID_sales_transfer) AND (item_no = @item_no)"
        Me.SqlInsertCommand3.Connection = Me.Cnn
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_sales_transfer", System.Data.SqlDbType.VarChar, 10, "ID_sales_transfer"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@qty", System.Data.SqlDbType.Money, 8, "qty"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Money, 8, "price"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fet", System.Data.SqlDbType.Money, 8, "fet"))
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE inv_sales_transfer_dtl SET ID_sales_transfer = @ID_sales_transfer, item_no" & _
        " = @item_no, qty = @qty, price = @price, fet = @fet WHERE (ID_sales_transfer = @" & _
        "Original_ID_sales_transfer) AND (item_no = @Original_item_no) AND (fet = @Origin" & _
        "al_fet OR @Original_fet IS NULL AND fet IS NULL) AND (price = @Original_price OR" & _
        " @Original_price IS NULL AND price IS NULL) AND (qty = @Original_qty OR @Origina" & _
        "l_qty IS NULL AND qty IS NULL); SELECT ID_sales_transfer, item_no, qty, price, f" & _
        "et FROM inv_sales_transfer_dtl WHERE (ID_sales_transfer = @ID_sales_transfer) AN" & _
        "D (item_no = @item_no)"
        Me.SqlUpdateCommand3.Connection = Me.Cnn
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_sales_transfer", System.Data.SqlDbType.VarChar, 10, "ID_sales_transfer"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@qty", System.Data.SqlDbType.Money, 8, "qty"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Money, 8, "price"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fet", System.Data.SqlDbType.Money, 8, "fet"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_sales_transfer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_sales_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fet", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_qty", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "qty", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM inv_sales_transfer_dtl WHERE (ID_sales_transfer = @Original_ID_sales_" & _
        "transfer) AND (item_no = @Original_item_no) AND (fet = @Original_fet OR @Origina" & _
        "l_fet IS NULL AND fet IS NULL) AND (price = @Original_price OR @Original_price I" & _
        "S NULL AND price IS NULL) AND (qty = @Original_qty OR @Original_qty IS NULL AND " & _
        "qty IS NULL)"
        Me.SqlDeleteCommand3.Connection = Me.Cnn
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_sales_transfer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_sales_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fet", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_qty", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "qty", System.Data.DataRowVersion.Original, Nothing))
        '
        'Dainv_sales_transfer_dtl
        '
        Me.Dainv_sales_transfer_dtl.DeleteCommand = Me.SqlDeleteCommand3
        Me.Dainv_sales_transfer_dtl.InsertCommand = Me.SqlInsertCommand3
        Me.Dainv_sales_transfer_dtl.SelectCommand = Me.SqlSelectCommand4
        Me.Dainv_sales_transfer_dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_sales_transfer_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_sales_transfer", "ID_sales_transfer"), New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet")})})
        Me.Dainv_sales_transfer_dtl.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT ID_sales_transfer, type_sales_transfer, by_action, authoriz_action, store_" & _
        "from, store_to, date_action, note, comment FROM inv_salse_transfer_head WHERE (I" & _
        "D_sales_transfer = @id_sales_transfer)"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_sales_transfer", System.Data.SqlDbType.VarChar, 10, "ID_sales_transfer"))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO inv_salse_transfer_head(ID_sales_transfer, type_sales_transfer, by_ac" & _
        "tion, authoriz_action, store_from, store_to, date_action, note, comment) VALUES " & _
        "(@ID_sales_transfer, @type_sales_transfer, @by_action, @authoriz_action, @store_" & _
        "from, @store_to, @date_action, @note, @comment); SELECT ID_sales_transfer, type_" & _
        "sales_transfer, by_action, authoriz_action, store_from, store_to, date_action, n" & _
        "ote, comment FROM inv_salse_transfer_head WHERE (ID_sales_transfer = @ID_sales_t" & _
        "ransfer)"
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_sales_transfer", System.Data.SqlDbType.VarChar, 10, "ID_sales_transfer"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_sales_transfer", System.Data.SqlDbType.VarChar, 1, "type_sales_transfer"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@by_action", System.Data.SqlDbType.VarChar, 5, "by_action"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@authoriz_action", System.Data.SqlDbType.VarChar, 5, "authoriz_action"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@store_from", System.Data.SqlDbType.VarChar, 2, "store_from"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@store_to", System.Data.SqlDbType.VarChar, 2, "store_to"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_action", System.Data.SqlDbType.VarChar, 10, "date_action"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@note", System.Data.SqlDbType.VarChar, 50, "note"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@comment", System.Data.SqlDbType.VarChar, 200, "comment"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE inv_salse_transfer_head SET ID_sales_transfer = @ID_sales_transfer, type_s" & _
        "ales_transfer = @type_sales_transfer, by_action = @by_action, authoriz_action = " & _
        "@authoriz_action, store_from = @store_from, store_to = @store_to, date_action = " & _
        "@date_action, note = @note, comment = @comment WHERE (ID_sales_transfer = @Origi" & _
        "nal_ID_sales_transfer) AND (authoriz_action = @Original_authoriz_action OR @Orig" & _
        "inal_authoriz_action IS NULL AND authoriz_action IS NULL) AND (by_action = @Orig" & _
        "inal_by_action OR @Original_by_action IS NULL AND by_action IS NULL) AND (commen" & _
        "t = @Original_comment OR @Original_comment IS NULL AND comment IS NULL) AND (dat" & _
        "e_action = @Original_date_action OR @Original_date_action IS NULL AND date_actio" & _
        "n IS NULL) AND (note = @Original_note OR @Original_note IS NULL AND note IS NULL" & _
        ") AND (store_from = @Original_store_from OR @Original_store_from IS NULL AND sto" & _
        "re_from IS NULL) AND (store_to = @Original_store_to OR @Original_store_to IS NUL" & _
        "L AND store_to IS NULL) AND (type_sales_transfer = @Original_type_sales_transfer" & _
        "); SELECT ID_sales_transfer, type_sales_transfer, by_action, authoriz_action, st" & _
        "ore_from, store_to, date_action, note, comment FROM inv_salse_transfer_head WHER" & _
        "E (ID_sales_transfer = @ID_sales_transfer)"
        Me.SqlUpdateCommand2.Connection = Me.Cnn
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_sales_transfer", System.Data.SqlDbType.VarChar, 10, "ID_sales_transfer"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_sales_transfer", System.Data.SqlDbType.VarChar, 1, "type_sales_transfer"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@by_action", System.Data.SqlDbType.VarChar, 5, "by_action"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@authoriz_action", System.Data.SqlDbType.VarChar, 5, "authoriz_action"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@store_from", System.Data.SqlDbType.VarChar, 2, "store_from"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@store_to", System.Data.SqlDbType.VarChar, 2, "store_to"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_action", System.Data.SqlDbType.VarChar, 10, "date_action"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@note", System.Data.SqlDbType.VarChar, 50, "note"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@comment", System.Data.SqlDbType.VarChar, 200, "comment"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_sales_transfer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_sales_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_authoriz_action", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "authoriz_action", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_by_action", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "by_action", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_comment", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "comment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_action", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_action", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_note", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "note", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_store_from", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "store_from", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_store_to", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "store_to", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_sales_transfer", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_sales_transfer", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM inv_salse_transfer_head WHERE (ID_sales_transfer = @Original_ID_sales" & _
        "_transfer) AND (authoriz_action = @Original_authoriz_action OR @Original_authori" & _
        "z_action IS NULL AND authoriz_action IS NULL) AND (by_action = @Original_by_acti" & _
        "on OR @Original_by_action IS NULL AND by_action IS NULL) AND (comment = @Origina" & _
        "l_comment OR @Original_comment IS NULL AND comment IS NULL) AND (date_action = @" & _
        "Original_date_action OR @Original_date_action IS NULL AND date_action IS NULL) A" & _
        "ND (note = @Original_note OR @Original_note IS NULL AND note IS NULL) AND (store" & _
        "_from = @Original_store_from OR @Original_store_from IS NULL AND store_from IS N" & _
        "ULL) AND (store_to = @Original_store_to OR @Original_store_to IS NULL AND store_" & _
        "to IS NULL) AND (type_sales_transfer = @Original_type_sales_transfer)"
        Me.SqlDeleteCommand2.Connection = Me.Cnn
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_sales_transfer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_sales_transfer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_authoriz_action", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "authoriz_action", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_by_action", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "by_action", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_comment", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "comment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_action", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_action", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_note", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "note", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_store_from", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "store_from", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_store_to", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "store_to", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_sales_transfer", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_sales_transfer", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand2
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_salse_transfer_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_sales_transfer", "ID_sales_transfer"), New System.Data.Common.DataColumnMapping("type_sales_transfer", "type_sales_transfer"), New System.Data.Common.DataColumnMapping("by_action", "by_action"), New System.Data.Common.DataColumnMapping("authoriz_action", "authoriz_action"), New System.Data.Common.DataColumnMapping("store_from", "store_from"), New System.Data.Common.DataColumnMapping("store_to", "store_to"), New System.Data.Common.DataColumnMapping("date_action", "date_action"), New System.Data.Common.DataColumnMapping("note", "note"), New System.Data.Common.DataColumnMapping("comment", "comment")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand2
        '
        'FrmInterStoreSale
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(702, 460)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PnlHead)
        Me.Name = "FrmInterStoreSale"
        Me.Text = "Inter-Store Sale"
        Me.PnlHead.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DsFrmInterStoreSale1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmInterStoreSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Cnn.ConnectionString = PConnectionString
            If MTypeOfForm = "" Then
                MsgFar("Error in calling form")
                MTypeOfForm = "1" 'inter store sale
            End If
            Call ChangeLabels()
            MyZipCode = New UCZipCode.ClsZipCode
            MyZipCode.Connection = Me.Cnn

            CnnMdbSetup.ConnectionString = PConnectionStringForSetupTables
            DaEmploye.Fill(DsFrmInterStoreSale1.employee)
            DaEmploye.Fill(DsFrmInterStoreSale1.employee1)
            DASTORE_SETUP.Fill(DsFrmInterStoreSale1.STORE_SETUP)
            DASTORE_SETUP.Fill(DsFrmInterStoreSale1.STORE_SETUP1)
            Cls1.Connection = Cnn
            ClsItem1 = New UCInv_Item.Clsitem_no
            ClsItem1.Connection = Cnn
            Cls1.TypeOfForm = TypeOfForm
            LblStoreNo.Text = PubStoreName
            LblCompanyName.Text = PubCompanyName
            Txtdate_action.Text = Format(Now.Date, PubDateFormat)

            If CodInterStoreSale <> "" Then
                TxtRef.Text = CodInterStoreSale
                If Not ShowPnlHead Then
                    PnlHead.Visible = False
                    PnlHead.Enabled = False
                    Me.Height = Me.Height - PnlHead.Height
                End If
            Else
                TxtRef.Text = Cls1.LastRecord
            End If
            Call LoadInterStoreSale(TxtRef.Text)
            Call EnableDisableField(False)
            ThisFormStatus = MainModule.WorkStates._ReadOnly
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub LoadInterStoreSale(ByVal ThisRefNo As String)
        'DsFrmInterStoreSale1.Clear()
        Dim i As Integer = 0
        Call ClearAllField()
        Dainv_salse_transfer_head.SelectCommand.Parameters("@ID_sales_transfer").Value = ThisRefNo
        Dainv_salse_transfer_head.Fill(DsFrmInterStoreSale1.inv_salse_transfer_head)
        Try
            Dainv_sales_transfer_dtl.SelectCommand.Parameters("@ID_sales_transfer").Value = ThisRefNo
            Dainv_sales_transfer_dtl.Fill(DsFrmInterStoreSale1.inv_sales_transfer_dtl)
        Catch ex As Exception
        End Try
        Call FillDataInScreen()
        Call CalculateTotal()
        'Call CalcSumOfExt_price()
        'Call CallAll()
    End Sub
    Sub ClearAllField()
        'Txtdate_action.Enabled = InStatus
        DsFrmInterStoreSale1.inv_salse_transfer_head.Clear()
        DsFrmInterStoreSale1.inv_sales_transfer_dtl.Clear()
        CommentVar = ""
        'GrdDetail.Enabled = InSta
        TxtRef.Text = ""
        TxtNote.Text = ""
        Cmbauthoriz_action.SelectedIndex = 0
        Cmbby_action.SelectedIndex = 0
        CmbSoldBy.SelectedIndex = 0
        CmbSoldTo.SelectedIndex = 0
        Call ClearTotals()
    End Sub
    Sub FillDataInScreen()
        With DsFrmInterStoreSale1.inv_salse_transfer_head
            If .Rows.Count > 0 Then
                TxtRef.Text = .Rows(0).Item("ID_sales_transfer") & ""
                Cmbby_action.SelectedValue = .Rows(0).Item("by_action")
                Cmbauthoriz_action.SelectedValue = .Rows(0).Item("authoriz_action")
                CmbSoldBy.SelectedValue = .Rows(0).Item("store_from")
                CmbSoldTo.SelectedValue = .Rows(0).Item("store_to")
                Txtdate_action.Text = .Rows(0).Item("date_action") & ""
                TxtNote.Text = .Rows(0).Item("Note") & ""
                CommentVar = .Rows(0).Item("comment") & ""
            End If
        End With
    End Sub
    Sub ClearTotals()
        LblFET.Text = ""
        LblParts.Text = ""
        LblTotal.Text = ""
        LblTotalQty.Text = ""
        LblwEIGHT.Text = ""
    End Sub
    Private Sub EnableDisableField(ByVal InStatus As Boolean)
        Txtdate_action.Enabled = InStatus
        GrdDetail.Enabled = InStatus
        TxtRef.Enabled = InStatus
        TxtNote.Enabled = InStatus
        Cmbauthoriz_action.Enabled = InStatus
        Cmbby_action.Enabled = InStatus
        CmbSoldBy.Enabled = InStatus
        CmbSoldTo.Enabled = InStatus
        BtnComment.Enabled = InStatus

    End Sub
    Private Sub EnableDisableBtn()
        If TxtRef.Text.Trim.Length > 0 Then
            BtnPrint.Enabled = True
            BtnPreview.Enabled = True
        Else
            BtnPrint.Enabled = False
            BtnPreview.Enabled = False
        End If
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
                    '  BtnPrint.Enabled = True
                    '                    BtnPreview.Enabled = True

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
    Private Sub EnableDisableSave()
        Dim RowDetails As DataRow() = DsFrmInterStoreSale1.inv_sales_transfer_dtl.Select("trim(item_no) <> ''")
        If BtnNew.Enabled = False And RowDetails.Length > 0 Then
            BtnSave.Enabled = True
            BtnPrint.Enabled = True
            BtnPreview.Enabled = True

        Else
            BtnSave.Enabled = False

            '            BtnPrint.Enabled = False
            '           BtnPreview.Enabled = False

        End If
    End Sub
    Private Sub BtnNotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnComment.Click
        MyFrmComments = New CommonClass.FrmItemComments
        MyFrmComments.TxtComments.Text = CommentVar & ""
        Call FitToScreen(BtnComment, MyFrmComments)
        MyFrmComments.ShowDialog()
        CommentVar = MyFrmComments.TxtCommentvar
        EnableDisableSave()
    End Sub
    Sub CalculateTotal()
        Try
            LblTotalQty.Text = Math.Round(DsFrmInterStoreSale1.inv_sales_transfer_dtl.Compute("sum( Qty)", "Qty >=0"), 2)
            LblParts.Text = Math.Round(DsFrmInterStoreSale1.inv_sales_transfer_dtl.Compute("sum(ExCost)", "ExCost >=0"), 2)  '* CDec(LblTotalQty.Text), 2)
            LblFET.Text = Math.Round(DsFrmInterStoreSale1.inv_sales_transfer_dtl.Compute("sum( Fet)", "Fet >=0"), 2)
            LblTotal.Text = Math.Round(CDec("0" & LblFET.Text) + CDec("0" & LblParts.Text), 2)
            LblwEIGHT.Text = ""
        Catch ex As Exception
            'MsgBox(ex.ToString)
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
        DsFrmInterStoreSale1.employee.Clear()
        DsFrmInterStoreSale1.employee1.Clear()
        Dim before As String = DaEmploye.SelectCommand.CommandText
        DaEmploye.SelectCommand.CommandText = "SELECT     employee_code, l_name, m_name, f_name FROM employee wHERE  Terminated = 0 ORDER BY l_name"
        DaEmploye.Fill(DsFrmInterStoreSale1.employee)
        DaEmploye.Fill(DsFrmInterStoreSale1.employee1)
        DaEmploye.SelectCommand.CommandText = before


        Txtdate_action.Text = Format(Now.Date, PubDateFormat)
        TxtRef.Text = Cls1.MakeNewCod()
        OldReferenceNo = TxtRef.Text
        Try
            CmbSoldBy.SelectedValue = PubStoreNO
        Catch ex As Exception

        End Try

        Call AddEmptyRecordInDetail()
        Cmbby_action.Focus()

    End Sub
    Sub Psave()
        Dim Dr As DataRow
        Dim flg As Boolean = False
        Dim flgchangedid As Boolean = False
        Try
            If DsFrmInterStoreSale1.inv_salse_transfer_head.Rows.Count <= 0 Then
                Dr = DsFrmInterStoreSale1.inv_salse_transfer_head.NewRow()
                flg = True
            Else
                Dr = DsFrmInterStoreSale1.inv_salse_transfer_head.Rows(0)
            End If
            Dr("ID_sales_transfer") = TxtRef.Text.Trim
            Dr("type_sales_transfer") = TypeOfForm
            Dr("date_action") = Txtdate_action.Text
            Dr("by_action") = Cmbby_action.SelectedValue
            Dr("authoriz_action") = Cmbauthoriz_action.SelectedValue
            Dr("store_from") = CmbSoldBy.SelectedValue
            Dr("store_to") = CmbSoldTo.SelectedValue
            Dr("note") = TxtNote.Text.Trim & ""
            Dr("comment") = CommentVar & ""

            If flg Then
                DsFrmInterStoreSale1.inv_salse_transfer_head.Addinv_salse_transfer_headRow(Dr)
            End If
            '            #region "delete empty row"
            Dim i As Long
            Dim dr1 As DataRow()
            dr1 = DsFrmInterStoreSale1.inv_sales_transfer_dtl.Select("trim( item_no) =''")
            For i = 0 To dr1.Length - 1
                dr1(i).Delete()
            Next

            dr1 = DsFrmInterStoreSale1.inv_sales_transfer_dtl.Select("item_no is null ")
            For i = 0 To dr1.Length - 1
                dr1(i).Delete()
            Next
            Try
                For i = 0 To 10
                    Try
                        Dainv_salse_transfer_head.Update(DsFrmInterStoreSale1)
                        Exit For
                    Catch ex As Exception
                        If flg Then
                            TxtRef.Text = Trim(Cls1.MakeNewCod() & "")
                            DsFrmInterStoreSale1.inv_salse_transfer_head.Rows(0).Item("ID_sales_transfer") = TxtRef.Text.Trim
                            flgchangedid = True
                        Else
                            MsgBox(EX.ToString)
                        End If
                    End Try

                Next
                For i = 0 To DsFrmInterStoreSale1.inv_sales_transfer_dtl.Rows.Count - 1
                    Try
                        DsFrmInterStoreSale1.inv_sales_transfer_dtl.Rows(i).Item("ID_sales_transfer") = TxtRef.Text
                    Catch ex As Exception

                    End Try

                Next
                Dainv_sales_transfer_dtl.Update(DsFrmInterStoreSale1)



                'Dim dt As DataTable
                'dt = DsFrmInterStoreSale1.inv_sales_transfer_dtl.GetChanges(DataRowState.Deleted)
                'If Not dt Is Nothing Then
                '    Try
                '        If dt.Rows.Count > 0 Then Dainv_sales_transfer_dtl.Update(dt)
                '    Catch ex As Exception
                '        MsgBox(ex.ToString)
                '    End Try
                'End If


                'dt = DsFrmInterStoreSale1.inv_sales_transfer_dtl.GetChanges(DataRowState.Modified)
                'If Not dt Is Nothing Then
                '    Try
                '        If dt.Rows.Count > 0 Then Dainv_sales_transfer_dtl.Update(dt)
                '    Catch ex As Exception
                '        MsgBox(ex.ToString)
                '    End Try
                'End If


                'dt = DsFrmInterStoreSale1.inv_sales_transfer_dtl.GetChanges(DataRowState.Added)
                'If Not dt Is Nothing Then
                '    Try
                '        If dt.Rows.Count > 0 Then Dainv_sales_transfer_dtl.Update(dt)
                '    Catch ex As Exception
                '        MsgBox(ex.ToString)
                '    End Try
                'End If



                '' DaInv_Receive_Products_Dtl.Update(DsFrmReceiveReturnProduct1)
                ''                If RbBill.Checked = True Then
                Call UpdateQtyInItems(True)

                '               End If
                If flgchangedid = True Then
                    Dim MyFrmShowChangedNo As New FrmShowChangedNo
                    MyFrmShowChangedNo.LblNewNo.Text = TxtRef.Text
                    MyFrmShowChangedNo.LblOldNo.Text = OldReferenceNo
                    MyFrmShowChangedNo.ShowDialog()
                End If
            Catch ex As Exception
                MsgFar("Error In Update ")

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
        TxtRef.Text = Cls1.LastRecord
        Call LoadInterStoreSale(TxtRef.Text)
    End Sub
    Sub PEdit()
        BeforeEditedDataset.Clear()
        BeforeEditedDataset = DsFrmInterStoreSale1.Copy()
        ' Get A Copy Of Dataset
        Dim AddEmptyRecordToDetailCount As Integer
        Dim IFirstCount As Integer   'Dsfrm..Rows.Count()
        If TxtRef.Text.Trim.Length > 0 Then
            ThisFormStatus = MainModule.WorkStates.Edit
            Call EnableDisableField(True)
            Call EnableDisableBtn()
            IFirstCount = DsFrmInterStoreSale1.inv_sales_transfer_dtl.Rows.Count()
            For AddEmptyRecordToDetailCount = 1 + IFirstCount To 20 + IFirstCount
                Call AddEmptyRecordToDetail(TxtRef.Text, AddEmptyRecordToDetailCount)
            Next
        End If
        Cmbby_action.Focus()
    End Sub
    Sub PDelete()
        BeforeEditedDataset.Clear()
        BeforeEditedDataset = DsFrmInterStoreSale1.Copy()
        If TxtRef.Text.Trim.Length > 0 Then
            ThisFormStatus = MainModule.WorkStates.Delete
            Dim c1 As New FrmWhatDoForMenu
            c1.BtnLeftText = "Cancel"
            c1.BtnRightText = "Delete"
            c1.ShowFarMsg("Are you sure?")
            If c1.DialogResult = DialogResult.OK Then
                Dim TxtRefTemp As String = TxtRef.Text
                If Cls1.DeleteThis(TxtRef.Text) Then
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
                Cmbby_action.Focus()
            End If
            ThisFormStatus = MainModule.WorkStates._ReadOnly
        End If
    End Sub
#End Region
#Region "Previos-Last-Frist"
    Private Sub PFirstRecord(Optional ByVal ShowMsgFlag As Boolean = True)
        Try
            If TxtRef.Text.Trim.Length > 0 Then
                Dim TXTRef_NoTmp As String = Cls1.PFirstRecord()
                If TXTRef_NoTmp = TxtRef.Text Then
                    If ShowMsgFlag Then MsgFar("First Record")
                Else
                    Call LoadInterStoreSale(TXTRef_NoTmp)
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
                Dim TXTRef_NoTmp As String = Cls1.LastRecord()
                If TXTRef_NoTmp = TxtRef.Text Then
                    If ShowMsgFlag Then MsgFar("Last Record")
                Else
                    Call LoadInterStoreSale(TXTRef_NoTmp)
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
                Dim TXTRef_NoTmp As String = Cls1.Pprevious(TxtRef.Text.Trim)
                If TXTRef_NoTmp.Trim = TxtRef.Text.Trim Or TXTRef_NoTmp.Trim.Length = 0 Then
                    If ShowMsgFlag Then MsgFar("First Record")
                Else
                    Call LoadInterStoreSale(TXTRef_NoTmp)
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
                Dim TXTRef_NoTmp As String = Cls1.PNext(TxtRef.Text)
                If TXTRef_NoTmp.Trim = TxtRef.Text.Trim Or TXTRef_NoTmp.Trim.Length = 0 Then
                    If ShowMsgFlag Then MsgFar("Last Record")
                Else
                    Call LoadInterStoreSale(TXTRef_NoTmp)
                End If
            Else
                MsgFar("There is no Row in Database")
            End If
        Catch ex As Exception
        End Try
    End Sub

#End Region
#Region "GrdDetail"
    Sub AddEmptyRecordInDetail()
        Dim IFirstCount As Integer = DsFrmInterStoreSale1.inv_salse_transfer_head.Rows.Count()
        Dim AddEmptyRecordToDetailCount As Integer
        For AddEmptyRecordToDetailCount = 1 + IFirstCount To 50 + IFirstCount
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
                                        Call SelectRow(row, 3)
                                        'System.Windows.Forms.SendKeys.Send(vbTab)
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
                            MsgFar("Cod is invalid")
                            Call SelectRow(CurrentRowGrid, 1)
                        Else

                            If CheckItemNoRepeat() = False Then
                                '       If MTypeOfForm = "1" Then
                                ClsItem1.FindItemCost(ValueString)
                                '  Else
                                '     ClsItem1.FindItemCost(ValueString)
                                'End If


                            Else
                                MsgFar("Cod is Repeated")
                                GrdDetail.GetRow.Cells(1).Value = ""
                            End If
                            'BeforeRowEx.Cells(2).Value = ClsItem1.desc_Item
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
                .Cells(6).Value = (Val(.Cells(4).Value & "") + Val(.Cells(5).Value & "")) * Val(.Cells(3).Value & "")
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
                .Cells(6).Value = (Val(.Cells(4).Value & "") + Val(.Cells(5).Value & "")) * Val(.Cells(3).Value & "")
            End With
        Catch ex As Exception

        End Try
        CalculateTotal()
    End Sub
    Private Sub GrdDetail_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.ColumnButtonClick
        Call ShowSearch()
        System.Windows.Forms.SendKeys.Send("{ENTER}")
    End Sub
    Sub ShowSearch()
        MyFrm1 = New UCInv_Item.FrmSearchItemCode
        MyFrm1.ShowDialog()
        GrdDetail.Focus()

    End Sub
    Sub InitBeforeRow()
        BeforeCel = GrdDetail.Col
        BeforeRow = GrdDetail.Row
        BeforeRowEx = GrdDetail.GetRow
    End Sub
#End Region
    Function CheckItemNoRepeat() As Boolean
        CheckItemNoRepeat = False
        Dim i As Long
        Dim dr1 As DataRow()
        If GrdDetail.GetRow.Cells(1).Value & "" <> "" Then
            GrdDetail.UpdateData()
            dr1 = DsFrmInterStoreSale1.inv_sales_transfer_dtl.Select("trim( item_no) =" & Qt(GrdDetail.GetRow.Cells(1).Value))
            If dr1.Length >= 2 Then
                CheckItemNoRepeat = True
            End If
        End If
    End Function
    Private Sub AddEmptyRecordToDetail(ByVal ThisId As String, ByVal ThisRadif As Integer)
        Dim dr As DataRow
        dr = DsFrmInterStoreSale1.inv_sales_transfer_dtl.NewRow
        dr("ID_sales_transfer") = ThisId
        dr("item_no") = ""
        dr("qty") = 0
        dr("price") = 0
        dr("fet") = 0
        DsFrmInterStoreSale1.inv_sales_transfer_dtl.Rows.Add(dr)
    End Sub
    Sub UpdateQtyInItems(ByVal flag1 As Boolean)
        Dim ItmNo As String = ""
        Dim qty As Decimal = 0
        Dim i As Integer = 0
        '-----------------------------------
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            If CmbSoldBy.SelectedValue = PubStoreNO Then
                With BeforeEditedDataset
                    For i = 0 To .inv_sales_transfer_dtl.Rows.Count - 1
                        If .inv_sales_transfer_dtl.Rows(i).RowState <> DataRowState.Deleted Then
                            ItmNo = .inv_sales_transfer_dtl.Rows(i).Item("item_no") & ""
                            qty = .inv_sales_transfer_dtl.Rows(i).Item("QTY")
                            If ItmNo.Trim <> "" Then
                                CmdGeneral.CommandText = "update inv_Tab_item_Warehouse  set  on_hand = on_hand + " & qty & " where Item_No= " & Qt(ItmNo.Trim) & " And cod_warehouse = " & Qt(PWareHouse)
                                CmdGeneral.ExecuteNonQuery()
                            End If
                        End If
                    Next
                End With
                If flag1 Then
                    With DsFrmInterStoreSale1
                        For i = 0 To .inv_sales_transfer_dtl.Rows.Count - 1
                            If .inv_sales_transfer_dtl.Rows(i).RowState <> DataRowState.Deleted Then
                                ItmNo = .inv_sales_transfer_dtl.Rows(i).Item("item_no") & ""
                                qty = .inv_sales_transfer_dtl.Rows(i).Item("QTY")
                                If ItmNo.Trim <> "" Then
                                    CmdGeneral.CommandText = "update inv_Tab_item_Warehouse  set  on_hand = on_hand - " & qty & " where Item_No= " & Qt(ItmNo.Trim) & " And cod_warehouse = " & Qt(PWareHouse)
                                    CmdGeneral.ExecuteNonQuery()
                                End If
                            End If
                        Next
                    End With
                End If

            End If
            '  End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#Region "All Text Changed"
    Private Sub Allchange1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbauthoriz_action.SelectedValueChanged, Cmbby_action.SelectedValueChanged, CmbSoldTo.SelectedValueChanged, TxtNote.TextChanged
        EnableDisableSave()
    End Sub

    Private Sub Allchange2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbauthoriz_action.SelectedValueChanged, Cmbby_action.SelectedValueChanged, CmbSoldTo.SelectedValueChanged, TxtNote.TextChanged, CmbSoldBy.SelectedValueChanged
        EnableDisableSave()
    End Sub
    Private Sub CmbSoldTo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbauthoriz_action.SelectedIndexChanged, Cmbby_action.SelectedIndexChanged, CmbSoldTo.SelectedIndexChanged, CmbSoldBy.SelectedIndexChanged
        EnableDisableSave()
    End Sub
#End Region
    Private Sub ClsItem1_FindItemCostRow(ByVal ThisRow As System.Data.DataRow) Handles ClsItem1.FindItemCostRow
        If Trim(GrdDetail.GetRow.Cells(1).Value & "") <> "" Then
            GrdDetail.GetRow.Cells(5).Value = Val(ThisRow.Item("Fet") & "")
            If Val(GrdDetail.GetRow.Cells(4).Value & "") = 0 Then
                If MTypeOfForm = "1" Then
                    Dim FetOdThisItem As Decimal = 0
                    GrdDetail.GetRow.Cells(4).Value = Val("" & ThisRow.Item("Cost")) & ""   'GrdDetail.GetRow.Cells(4).Value = ClsItem1.CalculatePriceCode(GrdDetail.GetRow.Cells(1).Value, 1, FetOdThisItem)    'ThisRow.Item("Cost") & ""
                    GrdDetail.GetRow.Cells(5).Value = Math.Round(CDec("0" & ThisRow("fet")), 2)
                Else
                    GrdDetail.GetRow.Cells(4).Value = Val("" & ThisRow.Item("Cost"))    'Math.Round(CDec("0" & ThisRow("cost")) + CDec("0" & ThisRow("delivery")) + CDec("0" & ThisRow("frieght")), 2)
                    GrdDetail.GetRow.Cells(5).Value = Math.Round(CDec("0" & ThisRow("fet")), 2)
                End If

            End If
        End If
    End Sub
    Private Sub ClsItem1_FindItemNoRow(ByVal ThisRow As System.Data.DataRow) Handles ClsItem1.FindItemNoRow
        If Trim(GrdDetail.GetRow.Cells(1).Value & "") <> "" Then
            GrdDetail.GetRow.Cells(2).Value = ClsItem1.desc_Item & ""
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
        GrdDetail.UpdateData()
        'GrdDetail.Col = 3
        EnableDisableSave()
    End Sub
    Sub ChangeLabels()
        Select Case TypeOfForm
            Case "2"
                Lblby_action.Text = "Transfer by"
                Lblstore_from.Text = "Transfer From"
                LabelNote.Text = "Transfer Note"
                LabelSoldTo.Text = "Transfer To"
                Labname.Text = "Inventory Transfer "
                Me.Text = "Inventory Transfer "
                GrdDetail.RootTable.Columns.Item(4).Caption = "Cost"
        End Select
    End Sub
    ' Sub CallAll()
    'Dim i As Integer = 0
    'Try
    '    For i = 0 To GrdDetail.RowCount
    '        GrdDetail.Row = i
    '        With GrdDetail.GetRow
    '            .Cells(6).Value = (Val(.Cells(4).Value & "") + Val(.Cells(5).Value & "")) * Val(.Cells(3).Value & "")
    '        End With

    '    Next
    'Catch ex As Exception
    'End Try
    'Call CalculateTotal()
    'GrdDetail.Row = 1
    'End Sub

    Private Sub GrdDetail_UpdatingCell1(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles GrdDetail.UpdatingCell
        With GrdDetail.GetRow
            .Cells(6).Value = (Val(.Cells(4).Value & "") + Val(.Cells(5).Value & "")) * Val(.Cells(3).Value & "")
        End With
        Call CalculateTotal()

    End Sub


    Private Sub GrdDetail_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GrdDetail.UpdatingRecord
        With GrdDetail.GetRow
            .Cells(6).Value = (Val(.Cells(4).Value & "") + Val(.Cells(5).Value & "")) * Val(.Cells(3).Value & "")
        End With
        Call CalculateTotal()
    End Sub
    Private Sub GrdDetail_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.RecordUpdated
        '        Call CallAll()
        With GrdDetail.GetRow
            .Cells(6).Value = (Val(.Cells(4).Value & "") + Val(.Cells(5).Value & "")) * Val(.Cells(3).Value & "")
        End With
        Call CalculateTotal()
    End Sub

    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        Call pprint("preview")
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Call pprint("print")
    End Sub
    Private Sub pprint(ByVal PrintType As String)
        'If BtnSave.Enabled = True Then
        '    Call Psave()
        'End If
        If ThisFormStatus = MainModule.WorkStates.AddNew Or ThisFormStatus = MainModule.WorkStates.Edit Then
            MsgFar("Please Save Before Printing")
            Exit Sub
        End If
        Dim rpt As New RepInterStoreSale
        Dim prn As New FrmRepView

        rpt.SetParameterValue("ParStoreShortName", PubStoreName & "")

        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetDataSource(DsFrmInterStoreSale1)
        rpt.SetParameterValue("Parconame", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parcoaddress", OleDbReaderForStore.Item("ADDRESS") & "")
        MyZipCode.ZipCode = OleDbReaderForStore.Item("ZipCode")
        MyZipCode.FindDesc(OleDbReaderForStore.Item("ZipCode"))
        rpt.SetParameterValue("Parcoaddress2", MyZipCode.City & " " & MyZipCode.State & " " & MyZipCode.ZipCode & "")
        rpt.SetParameterValue("Parcophone", OleDbReaderForStore.Item("PHONE") & "")
        rpt.SetParameterValue("Parcofax", OleDbReaderForStore.Item("FAX") & "")

        rpt.SetParameterValue("Fromstore", CmbSoldBy.Text & "")
        rpt.SetParameterValue("ToStore", CmbSoldTo.Text & "")
        rpt.SetParameterValue("Transferby", Cmbby_action.Text & "")
        rpt.SetParameterValue("Authorizedby", Cmbauthoriz_action.Text & "")
        rpt.SetParameterValue("DateAction", Txtdate_action.Text & "")
        rpt.SetParameterValue("TimeAction", "")
        rpt.SetParameterValue("TransferNo", TxtRef.Text & "")
        rpt.SetParameterValue("TransferNote", TxtNote.Text.Trim & "")
        rpt.SetParameterValue("Comment", CommentVar & "")
        rpt.SetParameterValue("parts", LblParts.Text.ToString & "")
        rpt.SetParameterValue("FET", LblFET.Text.ToString & "")
        rpt.SetParameterValue("TotalQty", LblTotalQty.Text.ToString & "")
        rpt.SetParameterValue("TotalWeight", LblwEIGHT.Text.ToString & "")
        rpt.SetParameterValue("SubTotal", LblTotal.Text & "")
        rpt.SetParameterValue("Tax", "")
        rpt.SetParameterValue("Total", LblTotal.Text & "")
        rpt.SetParameterValue("TopText", Labname.Text.Trim & "")

        Select Case PrintType.ToUpper
            Case "print".ToUpper
                Try
                    rpt.PrintToPrinter(1, True, 0, 0)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            Case "preview".ToUpper
                prn.CrViewer.ReportSource = rpt
                prn.Show()

        End Select
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
        Dim drow As DataRow() = DsFrmInterStoreSale1.inv_sales_transfer_dtl.Select("ID_sales_transfer =" & Qt(TxtRef.Text.Trim) & " and item_no = " & Qt(GrdDetail.GetRow.Cells(1).Value & ""))
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
        Call AddEmptyRecordToDetail(TxtRef.Text, 1)
        Dim i As Integer = 0
        Dim j As Integer = 0
        For i = DsFrmInterStoreSale1.inv_sales_transfer_dtl.Rows.Count - 1 To Currentrow Step -1
            With DsFrmInterStoreSale1.inv_sales_transfer_dtl
                For j = 0 To 7
                    Try
                        .Rows(i).Item(j) = .Rows(i - 1).Item(j)
                    Catch ex As Exception
                    End Try
                Next
            End With
        Next
        With DsFrmInterStoreSale1.inv_sales_transfer_dtl.Rows(Currentrow)
            .Item("ID_sales_transfer") = TxtRef.Text
            .Item("item_no") = ""
            .Item("desc_item") = ""
            .Item("qty") = 0
            .Item("price") = 0
            .Item("fet") = 0

        End With
        GrdDetail.UpdateData()
        GrdDetail.Refetch()
        GrdDetail.Row = Currentrow
        EnableDisableSave()
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        FrmSearchInterStoreSale1 = New FrmSearchInterStoreSale
        FrmSearchInterStoreSale1.TypeOfForm = TypeOfForm
        FrmSearchInterStoreSale1.ShowDialog()
    End Sub

    Private Sub FrmSearchInterStoreSale1_InterStoreSalesFind(ByVal ThisId As String) Handles FrmSearchInterStoreSale1.InterStoreSalesFind
        Call LoadInterStoreSale(ThisId)
    End Sub
End Class
