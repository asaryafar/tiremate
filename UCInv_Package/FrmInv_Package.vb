Imports CommonClass
Imports Janus.Windows.GridEX
Public Class FrmInv_Package
    Inherits FrmBase
    Dim WithEvents MyFrmSearchcod_pakage As New UCInv_Package.FrmSearchcod_pakage
    Dim WithEvents MyFrmSearchItemCode As New UCInv_Item.FrmSearchItemCode
    Dim WithEvents MyFrmSearchServiceCode As New UCLabor_Service.FrmSearchLabor_ServiceCod
    Dim WithEvents MyFrmSearchReadyComments As New FrmSearchReadyComments

    Dim Mylabor_service As UCLabor_Service.ClsLabor_ServiceCod
    Dim WithEvents MyItem As UCInv_Item.Clsitem_no

    Dim BeforeCel As Integer = -1
    Dim BeforeRow As Integer = -1
    Dim BeforeRowEx As GridEXRow = Nothing
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
    Friend WithEvents DSFrmInv_pakage1 As DSInv_tab_pakage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents AddNew As System.Windows.Forms.ToolBarButton
    Friend WithEvents Edit As System.Windows.Forms.ToolBarButton
    Friend WithEvents Delete As System.Windows.Forms.ToolBarButton
    Friend WithEvents Save As System.Windows.Forms.ToolBarButton
    Friend WithEvents Cancel As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImgWork As System.Windows.Forms.ImageList
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GrdMain As Janus.Windows.GridEX.GridEX
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents CPrint As System.Windows.Forms.ToolBarButton
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAInv_tab_pakage As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TxtDesc_Pakage As System.Windows.Forms.TextBox
    Friend WithEvents Cod_Pakage1 As UCInv_Package.Cod_Pakage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblTotal As CalcUtils.UcCalcText
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmInv_Package))
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.DSFrmInv_pakage1 = New UCInv_Package.DSInv_tab_pakage
        Me.GrdMain = New Janus.Windows.GridEX.GridEX
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.AddNew = New System.Windows.Forms.ToolBarButton
        Me.Edit = New System.Windows.Forms.ToolBarButton
        Me.Delete = New System.Windows.Forms.ToolBarButton
        Me.Save = New System.Windows.Forms.ToolBarButton
        Me.Cancel = New System.Windows.Forms.ToolBarButton
        Me.CPrint = New System.Windows.Forms.ToolBarButton
        Me.ImgWork = New System.Windows.Forms.ImageList(Me.components)
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.TxtDesc_Pakage = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Cod_Pakage1 = New UCInv_Package.Cod_Pakage
        Me.Label2 = New System.Windows.Forms.Label
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAInv_tab_pakage = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LblTotal = New CalcUtils.UcCalcText
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DSFrmInv_pakage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DSFrmInv_pakage1
        '
        Me.DSFrmInv_pakage1.DataSetName = "DSInv_tab_pakage"
        Me.DSFrmInv_pakage1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'GrdMain
        '
        Me.GrdMain.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdMain.AlternatingColors = True
        Me.GrdMain.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdMain.DataMember = "inv_tab_pakage_head"
        Me.GrdMain.DataSource = Me.DSFrmInv_pakage1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>inv_tab_pakage_head</Caption><Columns Colle" & _
        "ction=""true""><Column0 ID=""cod_pakage""><Caption>cod_pakage</Caption><TypeNameEmpt" & _
        "yStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMe" & _
        "mber>cod_pakage</DataMember><Key>cod_pakage</Key><Position>0</Position><Width>93" & _
        "</Width></Column0><Column1 ID=""desc_pakage""><Caption>desc_pakage</Caption><DataM" & _
        "ember>desc_pakage</DataMember><Key>desc_pakage</Key><Position>1</Position><Width" & _
        ">377</Width></Column1></Columns><GroupCondition ID="""" /><Key>inv_tab_pakage_head" & _
        "</Key></RootTable></GridEXLayoutData>"
        Me.GrdMain.DesignTimeLayout = GridEXLayout1
        Me.GrdMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrdMain.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdMain.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdMain.GroupByBoxVisible = False
        Me.GrdMain.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.AllCharacters
        Me.GrdMain.Location = New System.Drawing.Point(0, 73)
        Me.GrdMain.Name = "GrdMain"
        Me.GrdMain.Size = New System.Drawing.Size(512, 140)
        Me.GrdMain.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(512, 45)
        Me.Panel2.TabIndex = 190
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(445, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(65, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(330, 43)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Package"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.AddNew, Me.Edit, Me.Delete, Me.Save, Me.Cancel, Me.CPrint})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(60, 20)
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImgWork
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(512, 28)
        Me.ToolBar1.TabIndex = 0
        Me.ToolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
        '
        'AddNew
        '
        Me.AddNew.ImageIndex = 0
        Me.AddNew.Tag = "1"
        Me.AddNew.Text = "New"
        Me.AddNew.ToolTipText = "New (Ctrl+N)"
        '
        'Edit
        '
        Me.Edit.ImageIndex = 1
        Me.Edit.Tag = "2"
        Me.Edit.Text = "Edit"
        Me.Edit.ToolTipText = "Edit (Ctrl+E)"
        '
        'Delete
        '
        Me.Delete.ImageIndex = 2
        Me.Delete.Tag = "3"
        Me.Delete.Text = "Delete"
        Me.Delete.ToolTipText = "Delete (Ctrl+D)"
        '
        'Save
        '
        Me.Save.Enabled = False
        Me.Save.ImageIndex = 3
        Me.Save.Tag = "4"
        Me.Save.Text = "Save"
        Me.Save.ToolTipText = "Save (Ctrl+S)"
        '
        'Cancel
        '
        Me.Cancel.Enabled = False
        Me.Cancel.ImageIndex = 4
        Me.Cancel.Tag = "5"
        Me.Cancel.Text = "Cancel"
        Me.Cancel.ToolTipText = "Cancel (Ctrl+Z)"
        '
        'CPrint
        '
        Me.CPrint.ImageIndex = 15
        Me.CPrint.Text = "Print"
        Me.CPrint.ToolTipText = "Print (Ctrl+P)"
        '
        'ImgWork
        '
        Me.ImgWork.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImgWork.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImgWork.ImageStream = CType(resources.GetObject("ImgWork.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgWork.TransparentColor = System.Drawing.Color.Transparent
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01_" & _
        "2006;persist security info=True;password=sa"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GrdDetail)
        Me.Panel1.Controls.Add(Me.TxtDesc_Pakage)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Cod_Pakage1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 217)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(512, 158)
        Me.Panel1.TabIndex = 192
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowColumnDrag = False
        Me.GrdDetail.AutomaticSort = False
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "inv_tab_pakage"
        Me.GrdDetail.DataSource = Me.DSFrmInv_pakage1
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Caption>service_center_dtl</Caption><Columns Collec" & _
        "tion=""true""><Column0 ID=""type_select""><Caption>Type</Caption><DataMember>type_se" & _
        "lect</DataMember><Key>type_select</Key><Position>0</Position><Width>34</Width><C" & _
        "ellStyle><BackColor>Silver</BackColor></CellStyle></Column0><Column1 ID=""radif"">" & _
        "<Caption>radif</Caption><DataMember>radif</DataMember><Key>radif</Key><Position>" & _
        "1</Position><Visible>False</Visible><Width>33</Width></Column1><Column2 ID=""cod_" & _
        "select""><Caption>Item No</Caption><DataMember>cod_select</DataMember><Key>cod_se" & _
        "lect</Key><Position>2</Position><Width>95</Width><CellStyle><BackColor>Silver</B" & _
        "ackColor></CellStyle></Column2><Column3 ID=""desc_radif""><Caption>Description</Ca" & _
        "ption><DataMember>desc_radif</DataMember><Key>desc_radif</Key><Position>3</Posit" & _
        "ion><Width>235</Width></Column3><Column4 ID=""qty""><Caption>Qty</Caption><DataMem" & _
        "ber>qty</DataMember><InputMask>Number2</InputMask><Key>qty</Key><MaskPrompt>&#x0" & _
        ";</MaskPrompt><Position>4</Position><Width>42</Width><CellStyle><BackColor>Silve" & _
        "r</BackColor></CellStyle></Column4><Column5 ID=""price""><Caption>Price</Caption><" & _
        "DataMember>price</DataMember><FormatString>c</FormatString><InputMask>Currency2<" & _
        "/InputMask><Key>price</Key><MaskPrompt>&#x0;</MaskPrompt><Position>5</Position><" & _
        "Width>79</Width></Column5><Column6 ID=""cod_pakage""><Caption>cod_pakage</Caption>" & _
        "<DataMember>cod_pakage</DataMember><Key>cod_pakage</Key><Position>6</Position><V" & _
        "isible>False</Visible></Column6></Columns><GroupCondition ID="""" /><Key>service_c" & _
        "enter_dtl</Key><RowHeight>19</RowHeight></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout2
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.Enabled = False
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(0, 32)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(512, 126)
        Me.GrdDetail.TabIndex = 5
        '
        'TxtDesc_Pakage
        '
        Me.TxtDesc_Pakage.BackColor = System.Drawing.SystemColors.Info
        Me.TxtDesc_Pakage.Enabled = False
        Me.TxtDesc_Pakage.Location = New System.Drawing.Point(230, 6)
        Me.TxtDesc_Pakage.MaxLength = 50
        Me.TxtDesc_Pakage.Name = "TxtDesc_Pakage"
        Me.TxtDesc_Pakage.Size = New System.Drawing.Size(260, 20)
        Me.TxtDesc_Pakage.TabIndex = 3
        Me.TxtDesc_Pakage.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(142, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Package Name :"
        '
        'Cod_Pakage1
        '
        Me.Cod_Pakage1.ActiveSearchBottun = False
        Me.Cod_Pakage1.BackColor = System.Drawing.SystemColors.Info
        Me.Cod_Pakage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cod_Pakage1.Cod_pakage = ""
        Me.Cod_Pakage1.Cod_pakageLen = 5
        Me.Cod_Pakage1.Connection = Me.Cnn
        Me.Cod_Pakage1.Enabled = False
        Me.Cod_Pakage1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Cod_Pakage1.Location = New System.Drawing.Point(81, 6)
        Me.Cod_Pakage1.Name = "Cod_Pakage1"
        Me.Cod_Pakage1.NotExitIfNotFound = False
        Me.Cod_Pakage1.ReleaseIfNotFoundCod_pakage = False
        Me.Cod_Pakage1.Size = New System.Drawing.Size(56, 21)
        Me.Cod_Pakage1.TabIndex = 193
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Package Cod :"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.GridEXPrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Location = New System.Drawing.Point(114, 17)
        Me.PrintPreviewDialog1.MinimumSize = New System.Drawing.Size(375, 250)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty
        Me.PrintPreviewDialog1.UseAntiAlias = True
        Me.PrintPreviewDialog1.Visible = False
        '
        'GridEXPrintDocument1
        '
        Me.GridEXPrintDocument1.DocumentName = "GridEX Printed Document"
        Me.GridEXPrintDocument1.GridEX = Me.GrdMain
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cod_pakage, radif, type_select, cod_select, desc_radif, qty, price FROM in" & _
        "v_tab_pakage WHERE (cod_pakage = @cod_pakage)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_pakage", System.Data.SqlDbType.VarChar, 5, "cod_pakage"))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO inv_tab_pakage(cod_pakage, radif, type_select, cod_select, desc_radif" & _
        ", qty, price) VALUES (@cod_pakage, @radif, @type_select, @cod_select, @desc_radi" & _
        "f, @qty, @price); SELECT cod_pakage, radif, type_select, cod_select, desc_radif," & _
        " qty, price FROM inv_tab_pakage WHERE (cod_pakage = @cod_pakage) AND (radif = @r" & _
        "adif)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_pakage", System.Data.SqlDbType.VarChar, 5, "cod_pakage"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_select", System.Data.SqlDbType.VarChar, 1, "type_select"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_select", System.Data.SqlDbType.VarChar, 20, "cod_select"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_radif", System.Data.SqlDbType.VarChar, 50, "desc_radif"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@qty", System.Data.SqlDbType.Real, 4, "qty"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Real, 4, "price"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE inv_tab_pakage SET cod_pakage = @cod_pakage, radif = @radif, type_select =" & _
        " @type_select, cod_select = @cod_select, desc_radif = @desc_radif, qty = @qty, p" & _
        "rice = @price WHERE (cod_pakage = @Original_cod_pakage) AND (radif = @Original_r" & _
        "adif) AND (cod_select = @Original_cod_select OR @Original_cod_select IS NULL AND" & _
        " cod_select IS NULL) AND (desc_radif = @Original_desc_radif OR @Original_desc_ra" & _
        "dif IS NULL AND desc_radif IS NULL) AND (price = @Original_price OR @Original_pr" & _
        "ice IS NULL AND price IS NULL) AND (qty = @Original_qty OR @Original_qty IS NULL" & _
        " AND qty IS NULL) AND (type_select = @Original_type_select OR @Original_type_sel" & _
        "ect IS NULL AND type_select IS NULL); SELECT cod_pakage, radif, type_select, cod" & _
        "_select, desc_radif, qty, price FROM inv_tab_pakage WHERE (cod_pakage = @cod_pak" & _
        "age) AND (radif = @radif)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_pakage", System.Data.SqlDbType.VarChar, 5, "cod_pakage"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_select", System.Data.SqlDbType.VarChar, 1, "type_select"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_select", System.Data.SqlDbType.VarChar, 20, "cod_select"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_radif", System.Data.SqlDbType.VarChar, 50, "desc_radif"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@qty", System.Data.SqlDbType.Real, 4, "qty"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Real, 4, "price"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_pakage", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_pakage", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_select", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_select", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_radif", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_qty", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "qty", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_select", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_select", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM inv_tab_pakage WHERE (cod_pakage = @Original_cod_pakage) AND (radif =" & _
        " @Original_radif) AND (cod_select = @Original_cod_select OR @Original_cod_select" & _
        " IS NULL AND cod_select IS NULL) AND (desc_radif = @Original_desc_radif OR @Orig" & _
        "inal_desc_radif IS NULL AND desc_radif IS NULL) AND (price = @Original_price OR " & _
        "@Original_price IS NULL AND price IS NULL) AND (qty = @Original_qty OR @Original" & _
        "_qty IS NULL AND qty IS NULL) AND (type_select = @Original_type_select OR @Origi" & _
        "nal_type_select IS NULL AND type_select IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_pakage", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_pakage", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_select", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_select", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_radif", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_qty", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "qty", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_select", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_select", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAInv_tab_pakage
        '
        Me.DAInv_tab_pakage.DeleteCommand = Me.SqlDeleteCommand1
        Me.DAInv_tab_pakage.InsertCommand = Me.SqlInsertCommand1
        Me.DAInv_tab_pakage.SelectCommand = Me.SqlSelectCommand1
        Me.DAInv_tab_pakage.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_pakage", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_pakage", "cod_pakage"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("type_select", "type_select"), New System.Data.Common.DataColumnMapping("cod_select", "cod_select"), New System.Data.Common.DataColumnMapping("desc_radif", "desc_radif"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price")})})
        Me.DAInv_tab_pakage.UpdateCommand = Me.SqlUpdateCommand1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LblTotal)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 375)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(512, 26)
        Me.Panel3.TabIndex = 193
        '
        'LblTotal
        '
        Me.LblTotal.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblTotal.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.LblTotal.DecimalDigits = 2
        Me.LblTotal.DefaultSendValue = False
        Me.LblTotal.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblTotal.FireTabAfterEnter = True
        Me.LblTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblTotal.Image = CType(resources.GetObject("LblTotal.Image"), System.Drawing.Image)
        Me.LblTotal.Location = New System.Drawing.Point(376, 2)
        Me.LblTotal.Maxlength = 10
        Me.LblTotal.MinusColor = System.Drawing.Color.Empty
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.ReadOnly = True
        Me.LblTotal.Size = New System.Drawing.Size(128, 22)
        Me.LblTotal.TabIndex = 4
        Me.LblTotal.TabStop = False
        Me.LblTotal.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblTotal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(314, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total Price :"
        '
        'FrmInv_Package
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(512, 401)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GrdMain)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmInv_Package"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Package"
        CType(Me.DSFrmInv_pakage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim WithEvents ClsCod_pakage1 As New ClsCod_pakage
    Private Sub FrmCodKol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString

        Mylabor_service = New UCLabor_Service.ClsLabor_ServiceCod
        Mylabor_service.Connection = Me.Cnn

        MyItem = New UCInv_Item.Clsitem_no
        MyItem.Connection = Me.Cnn

        ClsCod_pakage1.Connection = Cnn
        ClsCod_pakage1.DApakageHead.Fill(DSFrmInv_pakage1.inv_tab_pakage_head)
        Call FillServiceKindCombo()
        Call EnableDisableToolBar()
        Call FillDataAdabtors()
        GridEXPrintDocument1.PageHeaderLeft = PubCompanyName
        GridEXPrintDocument1.PageHeaderRight = Me.Text
        ThisFormStatus = MainModule.WorkStates.Cancel
    End Sub
    Private Sub GrdDetail_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrdMain.SelectionChanged
        Call FillDown()
        Call FillDataAdabtors()
        Call EnableDisableToolBar()
    End Sub
    Sub FillDown()
        Dim RowEx As GridEXRow
        RowEx = GrdMain.GetRow
        Try
            Cod_Pakage1.Text = RowEx.Cells(0).Value
            TxtDesc_Pakage.Text = RowEx.Cells(1).Value
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0
                Call PAddNew()
            Case 1
                Call PEdit()
            Case 2
                Call PDelete()
            Case 3
                Call Psave()
            Case 4
                Call Pcancel()
            Case 5
                Call PPrint()
        End Select
    End Sub
    Sub PAddNew()
        ThisFormStatus = MainModule.WorkStates.AddNew
        Call Enable(True)
        ClearAllData()
        Call FillEmptyDetailGrid()
        Cod_Pakage1.Focus()
        Cancel.Enabled = True
        AddNew.Enabled = False
        Edit.Enabled = False
        Delete.Enabled = False
    End Sub
    Private Sub FillEmptyDetailGrid()
        Dim IFirstCount As Integer = DSFrmInv_pakage1.inv_tab_pakage.Rows.Count()
        Dim AddEmptyRecordToDetailCount As Integer
        For AddEmptyRecordToDetailCount = 1 + IFirstCount To 20 + IFirstCount
            Call AddEmptyRecordToDetail(AddEmptyRecordToDetailCount)
        Next
    End Sub
    Sub PEdit()
        Call FillDown()
        Call Enable(True)
        Cod_Pakage1.Enabled = False
        Call FillDataAdabtors()
        Call FillEmptyDetailGrid()
        TxtDesc_Pakage.Focus()
        ThisFormStatus = MainModule.WorkStates.Edit
        Cancel.Enabled = True
        AddNew.Enabled = False
        Edit.Enabled = False
        Delete.Enabled = False
    End Sub
    Sub PDelete()
        Dim c1 As New FrmWhatDoForMenu
        c1.ShowFarMsg("Are you sure?")
        If c1.DialogResult = DialogResult.OK Then
            ClsCod_pakage1.Cod_pakage = Cod_Pakage1.Cod_pakage
            Call ClsCod_pakage1.DeleteACod_pakage()
        End If
        Call RefetchGrid()
        Call EnableDisableToolBar()
        ThisFormStatus = MainModule.WorkStates.Delete
    End Sub
    Sub Psave()
        ClsCod_pakage1.Cod_pakage = Cod_Pakage1.Cod_pakage
        ClsCod_pakage1.Desc_pakage = TxtDesc_Pakage.Text
        Call Enable(False)
        Select Case ThisFormStatus
            Case MainModule.WorkStates.AddNew
                ClsCod_pakage1.AddACod_pakage()
            Case MainModule.WorkStates.Edit
                ClsCod_pakage1.EditACod_pakage()
        End Select

        If DSFrmInv_pakage1.inv_tab_pakage.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To DSFrmInv_pakage1.inv_tab_pakage.Rows.Count - 1
                If i >= DSFrmInv_pakage1.inv_tab_pakage.Rows.Count Then
                    Exit For
                End If
                If DSFrmInv_pakage1.inv_tab_pakage.Rows(i).RowState <> DataRowState.Deleted Then
                    If Trim(DSFrmInv_pakage1.inv_tab_pakage.Rows(i).Item("type_select")).Length > 0 Then
                        DSFrmInv_pakage1.inv_tab_pakage.Rows(i).Item("Cod_Pakage") = Cod_Pakage1.Cod_pakage
                    Else
                        DSFrmInv_pakage1.inv_tab_pakage.Rows(i).Delete()
                        i = i - 1
                    End If
                End If
            Next
        End If
        Try
            Dim dt As DataTable
            dt = DSFrmInv_pakage1.inv_tab_pakage.GetChanges(DataRowState.Deleted)
            If Not dt Is Nothing Then
                Try
                    If dt.Rows.Count > 0 Then DAInv_tab_pakage.Update(dt)
                Catch ex As Exception
                End Try
            End If

            dt = DSFrmInv_pakage1.inv_tab_pakage.GetChanges(DataRowState.Modified)
            If Not dt Is Nothing Then
                Try
                    If dt.Rows.Count > 0 Then DAInv_tab_pakage.Update(dt)
                Catch ex As Exception
                End Try
            End If

            dt = DSFrmInv_pakage1.inv_tab_pakage.GetChanges(DataRowState.Added)
            If Not dt Is Nothing Then
                Try
                    If dt.Rows.Count > 0 Then DAInv_tab_pakage.Update(dt)
                Catch ex As Exception
                End Try
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        ThisFormStatus = MainModule.WorkStates.Save
        Call RefetchGrid()
        EnableDisableToolBar()
        If ThisFormStatus = MainModule.WorkStates.AddNew Then
            Call PAddNew()
        End If
    End Sub
    Sub Pcancel()
        Enable(False)
        GrdMain.Focus()
        FillDown()
        Call FillDataAdabtors()
        EnableDisableToolBar()
        ThisFormStatus = MainModule.WorkStates.Cancel
    End Sub
    Private Sub FillDataAdabtors()
        DSFrmInv_pakage1.inv_tab_pakage.Clear()
        DAInv_tab_pakage.SelectCommand.Parameters("@cod_pakage").Value = Cod_Pakage1.Cod_pakage
        DAInv_tab_pakage.Fill(DSFrmInv_pakage1, "Inv_tab_pakage")
        Call CalcSumOfprice()
    End Sub
    Sub PPrint()
        PrintPreviewDialog1.SetBounds(Bounds.Left, Bounds.Top, Bounds.Width, Bounds.Height)
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Sub ClearAllData()
        Cod_Pakage1.Text = ""
        TxtDesc_Pakage.Text = ""
        DSFrmInv_pakage1.inv_tab_pakage.Clear()
        Call FillEmptyDetailGrid()
    End Sub
    Sub Enable(ByVal Stat As Boolean)
        Cod_Pakage1.Enabled = Stat
        TxtDesc_Pakage.Enabled = Stat
        GrdDetail.Enabled = Stat
        GrdMain.Enabled = Not Stat
    End Sub
    '-----------------------`
    Sub EnableDisableToolBar()
        AddNew.Enabled = True
        Save.Enabled = False
        Cancel.Enabled = False
        If DSFrmInv_pakage1.inv_tab_pakage_head.Rows.Count > 0 Then
            CPrint.Enabled = True
            If Cod_Pakage1.Text.Trim <> "" Then
                Edit.Enabled = True
                Delete.Enabled = True
            Else
                Edit.Enabled = False
                Delete.Enabled = False
            End If
        Else
            CPrint.Enabled = False
            Edit.Enabled = False
            Delete.Enabled = False
        End If
    End Sub
    Sub EnableDisableSaveAndCancel()
        If ThisFormStatus = MainModule.WorkStates.AddNew Or ThisFormStatus = MainModule.WorkStates.Edit Then
            If Cod_Pakage1.Text.Trim <> "" And TxtDesc_Pakage.Text.Trim <> "" Then
                Save.Enabled = True
            Else
                Save.Enabled = False
            End If
        End If
    End Sub
    Sub RefetchGrid()
        Try
            Dim row As Long
            row = GrdMain.Row
            DSFrmInv_pakage1.inv_tab_pakage_head.Clear()
            ClsCod_pakage1.DApakageHead.Fill(DSFrmInv_pakage1.inv_tab_pakage_head)
            GrdMain.Refetch()
            GrdMain.Row = row
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ClsCod_pakage1_FindError(ByVal MErrorString As String) Handles ClsCod_pakage1.FindError
        MsgFar(MErrorString)
    End Sub
    Private Sub TxtDesc_Pakage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDesc_Pakage.TextChanged
        Call EnableDisableSaveAndCancel()
    End Sub
    Private Sub Cod_Pakage1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cod_Pakage1.TextChanged
        Call EnableDisableSaveAndCancel()
    End Sub
    Private Sub AddEmptyRecordToDetail(ByVal ThisRadif As Integer)
        Dim dr As DataRow
        dr = DSFrmInv_pakage1.inv_tab_pakage.NewRow
        dr("cod_pakage") = Cod_Pakage1.Cod_pakage
        dr("radif") = ThisRadif
        dr("type_select") = " "
        dr("cod_select") = ""
        dr("desc_radif") = ""
        dr("qty") = 0
        dr("price") = 0
        DSFrmInv_pakage1.inv_tab_pakage.Rows.Add(dr)
    End Sub
    Private Sub FillServiceKindCombo()
        Dim Types As GridEXColumn = GrdDetail.RootTable.Columns("type_select")
        Types.HasValueList = True
        Types.ColumnType = ColumnType.Text
        Types.EditType = EditType.DropDownList
        Dim valueList As GridEXValueListItemCollection = Types.ValueList
        Dim row As DSInv_tab_pakage.inv_tab_pakageRow
        Dim item As GridEXValueListItem
        item = New GridEXValueListItem(" ", " ")
        valueList.Add(item)
        Dim i As Integer
        For i = 0 To TypeOfWorkOrderItemCount - 1
            item = New GridEXValueListItem(TypeOfWorkOrderItem(i), TypeOfWorkOrderItem(i))
            If TypeOfWorkOrderItem(i) <> "P" And TypeOfWorkOrderItem(i) <> "O" And TypeOfWorkOrderItem(i) <> "A" And TypeOfWorkOrderItem(i) <> "S" And TypeOfWorkOrderItem(i) <> "B" Then
                valueList.Add(item)
            End If
        Next
    End Sub
    Private Sub GrdDetail_CurrentCellChanging(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.CurrentCellChangingEventArgs) Handles GrdDetail.CurrentCellChanging
        Call EnableDisableSaveAndCancel()
        Call InitBeforeRow()
        Call CalcSumOfprice()
    End Sub
    Private Sub CalcSumOfprice()
        Try
            LblTotal.Text = 0
            Dim i As Double
            For i = 0 To DSFrmInv_pakage1.inv_tab_pakage.Rows.Count - 1
                LblTotal.Text = CDec(LblTotal.Text + DSFrmInv_pakage1.inv_tab_pakage.Rows(i).Item("qty") * DSFrmInv_pakage1.inv_tab_pakage.Rows(i).Item("Price"))
            Next
        Catch ex As Exception
            LblTotal.Text = 0
        End Try
    End Sub
    Private Sub GrdDetail_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.CurrentCellChanged
        Dim ValueString As String = ""
        Dim CurrentRowGrid As Long = GrdDetail.Row
        If BeforeRowEx Is Nothing Or BeforeCel < 0 Or BeforeRow < 0 Then
            Exit Sub
        End If
        Try
            Call CalcSumOfprice()
            Select Case BeforeCel
                Case 0
                    Call EnableDisableDescription(BeforeRowEx.Cells("type_select").Value)
                Case 2
                    If Not SayItemName() Then
                        MsgFar("Cod is invalid")
                        Call SelectRow(CurrentRowGrid)
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
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
                            Case Keys.F2
                                Select Case GrdDetail.Col
                                    Case 2 ' ItemCode
                                        Select Case CurrentRow.Cells(0).Value
                                            Case "I"
                                                Call FndItemCode()
                                                Call SelectRow(row, 4)
                                            Case "L"
                                                Call FndServiceCode("L")
                                                Call SelectRow(row, 4)
                                            Case "F"
                                                Call FndServiceCode("F")
                                                Call SelectRow(row, 4)
                                            Case "S"
                                                Call FndServiceCode("S")
                                                Call SelectRow(row, 4)
                                            Case "C"
                                                Call FndReadyComment()
                                                Call SelectRow(row, 4)
                                        End Select
                                        'SendKeys.Send(vbTab)
                                End Select
                        End Select
                    End If
            End Select
        End If
    End Sub
    Private Function FndReadyComment() As String
        Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        MyFrmSearchReadyComments.ShowDialog()
        GrdDetail.Focus()
        SelectRow(CurrentRow.RowIndex, 4)
    End Function
    Private Sub MyFrmSearchReadyComments_ReadyCommentFind(ByVal ThisReadyCommentDesc As String, ByVal ThisReadyCommentCode As String) Handles MyFrmSearchReadyComments.ReadyCommentFind
        Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        'Dim flg2 As Boolean = False
        If CurrentRow Is Nothing Then Exit Sub
        'If CurrentRow.RowType <> RowType.NewRecord Then
        '    CurrentRow.BeginEdit()
        '    flg2 = True
        'End If
        CurrentRow.Cells(2).Value = ThisReadyCommentCode
        CurrentRow.Cells(3).Value = ThisReadyCommentDesc
        'If flg2 Then CurrentRow.EndEdit()
        SelectRow(GrdDetail.Row, 4)
    End Sub
    Sub SelectRow(ByVal ThisRow As Integer, Optional ByVal ThisItemCodeFocus As Integer = 4)
        GrdDetail.Row = ThisRow
        GrdDetail.Col = ThisItemCodeFocus
        GrdDetail.SelectCurrentCellText()
    End Sub
    Private Function FndItemCode() As String
        'MyFrmSearchItemCode.FrmSearchInv_anbar_kalaCodAnbar = InvCode1.Text
        Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        MyFrmSearchItemCode.ShowDialog()
        GrdDetail.Focus()
        SelectRow(CurrentRow.RowIndex, 4)
    End Function
    Private Function FndServiceCode(ByVal ServiceKind As String) As String
        Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        MyFrmSearchServiceCode.KindService = ServiceKind
        MyFrmSearchServiceCode.ShowDialog()
        GrdDetail.Focus()
        SelectRow(CurrentRow.RowIndex, 4)
    End Function
    Private Sub MyFrmSearchItemCode_Item_noFind(ByVal ThisItemCode As String, ByVal ThisItemDesc As String) Handles MyFrmSearchItemCode.Item_noFind
        Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        If ThisFormStatus = MainModule.WorkStates.AddNew Or ThisFormStatus = MainModule.WorkStates.Edit Then
            'Dim flg2 As Boolean = False
            If CurrentRow Is Nothing Then Exit Sub
            'If CurrentRow.RowType <> RowType.NewRecord Then
            '    CurrentRow.BeginEdit()
            '    flg2 = True
            'End If
            If CurrentRow.Cells(0).Value = " " Then CurrentRow.Cells(0).Value = "I"
            If CurrentRow.Cells(0).Value = "I" Then
                CurrentRow.Cells(2).Value = ThisItemCode
                CurrentRow.Cells(3).Value = ThisItemDesc
                'If flg2 Then CurrentRow.EndEdit()
                SelectRow(GrdDetail.Row, 4)
            End If
        End If
    End Sub
    Private Sub MyFrmSearchServiceCode_Labor_ServiceFind(ByVal ThisLabor_ServiceCod As String, ByVal Thisdesc_Service As String) Handles MyFrmSearchServiceCode.Labor_ServiceFind
        Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        'Dim flg2 As Boolean = False
        If CurrentRow Is Nothing Then Exit Sub
        'If CurrentRow.RowType <> RowType.NewRecord Then
        '    CurrentRow.BeginEdit()
        '    flg2 = True
        'End If
        CurrentRow.Cells(2).Value = ThisLabor_ServiceCod
        CurrentRow.Cells(3).Value = Thisdesc_Service
        'If flg2 Then CurrentRow.EndEdit()
        SelectRow(GrdDetail.Row, 4)
    End Sub
    Private Function SayItemName() As Boolean
        SayItemName = True
        Dim ThisRowGrid As GridEXRow = GrdDetail.GetRow
        Try
            Select Case ThisRowGrid.Cells(0).Value
                Case "I"
                    MyItem.Item_no = ThisRowGrid.Cells(2).Value
                    MyItem.FindDesc(MyItem.Item_no)
                    ThisRowGrid.Cells(3).Value = MyItem.desc_Item
                    If CDec(ThisRowGrid.Cells(5).Value) = 0 Then
                        ThisRowGrid.Cells(5).Value = MyItem.CalculatePriceCode(MyItem.Item_no, 1)
                    End If
                Case "F", "L"
                    'Mylabor_service.cod_Service = ThisRowGrid.Cells(2).Value
                    'Mylabor_service.FindDesc(Mylabor_service.cod_Service)
                    'ThisRowGrid.Cells(3).Value = Mylabor_service.desc_Service
                    'If CDec(ThisRowGrid.Cells(5).Value) = 0 Then
                    '    ThisRowGrid.Cells(5).Value = Mylabor_service.CalculatePriceCode(Mylabor_service.cod_Service, 1, "01")
                    'End If
                    Mylabor_service.cod_Service = ThisRowGrid.Cells(2).Value
                    If ThisRowGrid.Cells(0).Value = "L" Then
                        Mylabor_service.FindDesc(Mylabor_service.cod_Service, "01")
                    Else
                        Mylabor_service.FindDesc(Mylabor_service.cod_Service, "02")
                    End If
                    ThisRowGrid.Cells(3).Value = Mylabor_service.desc_Service
                    If Trim(ThisRowGrid.Cells(3).Value).Length = 0 Then
                        SayItemName = False
                        Exit Function
                    End If
                    ThisRowGrid.Cells(5).Value = Mylabor_service.CalculatePriceCode(Mylabor_service.cod_Service, 1, -1)
                Case "C"
                    If CmdGeneral.Connection.State <> ConnectionState.Open Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.CommandText = "SELECT CommentDesc FROM  Bas_Ready_Comment WHERE CommentCode =" & Qt(ThisRowGrid.Cells(2).Value & "")
                    MyFrmSearchReadyComments_ReadyCommentFind(CmdGeneral.ExecuteScalar() & "", ThisRowGrid.Cells(2).Value & "")
            End Select
        Catch ex As Exception
            SayItemName = True
        End Try
    End Function
    Sub InitBeforeRow()
        BeforeCel = GrdDetail.Col
        BeforeRow = GrdDetail.Row
        BeforeRowEx = GrdDetail.GetRow
    End Sub
    Private Sub EnableDisableDescription(ByVal ThisValue As String)
        Try
            If InStr("ILSP", ThisValue) > 0 Then
                GrdDetail.RootTable.Columns("desc_radif").Selectable = False
            Else
                GrdDetail.RootTable.Columns("desc_radif").Selectable = True
            End If
            'Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
            'If CurrentRow.Cells(0).Value = "I" Or CurrentRow.Cells(0).Value = "L" Or CurrentRow.Cells(0).Value = "S" Or CurrentRow.Cells(0).Value = "P" Then
            '    GrdDetail.RootTable.Columns("desc_radif").Selectable = False
            'Else
            '    GrdDetail.RootTable.Columns("desc_radif").Selectable = True
            'End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GrdDetail_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GrdDetail.FormattingRow
        If e.Row.RowType = RowType.Record Then
            Select Case e.Row.Cells("type_select").Value
                Case "I"
                    e.Row.Cells("type_select").ToolTipText = "Items (Products)"
                Case "L"
                    e.Row.Cells("type_select").ToolTipText = "Labor (Services)"
                Case "F"
                    e.Row.Cells("type_select").ToolTipText = "Fees"
                Case "P"
                    e.Row.Cells("type_select").ToolTipText = "Package"
                Case "C"
                    e.Row.Cells("type_select").ToolTipText = "Comments"
                Case "A"
                    e.Row.Cells("type_select").ToolTipText = "Adjustment For Tires"
                Case "T"
                    e.Row.Cells("type_select").ToolTipText = "Trade_In"
                Case "S"
                    e.Row.Cells("type_select").ToolTipText = "Shop Supplies"
                Case "O"
                    e.Row.Cells("type_select").ToolTipText = "Outside Purchases"
            End Select

            'If e.Row.Cells("type_select").Value = "I" Then
            '    e.Row.Cells("type_select"). = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
            '    e.Row.Cells("type_select").ToolTipText = "Items"
            'ElseIf CType(e.Row.Cells("OnSale").Value, Boolean) Then
            '    e.Row.Cells("StatusIcon").ImageIndex = imageIndexOnSale
            '    e.Row.Cells("StatusIcon").ToolTipText = "Product is on sale"
            'End If
        End If
    End Sub
End Class

