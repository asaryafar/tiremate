Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmVendorBalance
    Inherits FrmBase
    Dim PanelGridHeightVar As Integer
    Dim PanelColorHeightVar As Integer
    Dim FormHeightVar As Integer
    Public cod_vendorParameter As String
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents BtnDetail As System.Windows.Forms.Button
    Friend WithEvents PanelGrid As System.Windows.Forms.Panel
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Public WithEvents LblName As System.Windows.Forms.TextBox
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents LblBalance As CalcUtils.UcCalcText
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LblTotalAmountDue As System.Windows.Forms.Label
    Friend WithEvents LblTotalOriginalAmount As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PanelColors As System.Windows.Forms.Panel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAservice_out_purchases As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmVendorBalance1 As UCVendor.DSFrmVendorBalance
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAInv_Receive_product_Ap_Dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_AP_bill_Dtl_Dtl As System.Data.SqlClient.SqlDataAdapter
    Public WithEvents LblVendor As System.Windows.Forms.TextBox
    Friend WithEvents LblCredit As CalcUtils.UcCalcText
    Friend WithEvents LblCharges As CalcUtils.UcCalcText
    Friend WithEvents LblCheck As CalcUtils.UcCalcText
    Friend WithEvents LblPrepare As CalcUtils.UcCalcText
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAbank_check As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_vendor_credit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmVendorBalance))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.LblVendor = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LblCheck = New CalcUtils.UcCalcText
        Me.Label23 = New System.Windows.Forms.Label
        Me.LblPrepare = New CalcUtils.UcCalcText
        Me.Label27 = New System.Windows.Forms.Label
        Me.LblCredit = New CalcUtils.UcCalcText
        Me.Label11 = New System.Windows.Forms.Label
        Me.LblCharges = New CalcUtils.UcCalcText
        Me.Label10 = New System.Windows.Forms.Label
        Me.LblBalance = New CalcUtils.UcCalcText
        Me.LblName = New System.Windows.Forms.TextBox
        Me.BtnDetail = New System.Windows.Forms.Button
        Me.Label33 = New System.Windows.Forms.Label
        Me.PanelGrid = New System.Windows.Forms.Panel
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DsFrmVendorBalance1 = New UCVendor.DSFrmVendorBalance
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LblTotalAmountDue = New System.Windows.Forms.Label
        Me.LblTotalOriginalAmount = New System.Windows.Forms.Label
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.PanelColors = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAservice_out_purchases = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DAInv_Receive_product_Ap_Dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_AP_bill_Dtl_Dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAbank_check = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_vendor_credit = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel1.SuspendLayout()
        Me.PanelGrid.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmVendorBalance1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.PanelColors.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=Tiremate_02"
        '
        'LblVendor
        '
        Me.LblVendor.BackColor = System.Drawing.Color.Gold
        Me.LblVendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblVendor.Location = New System.Drawing.Point(71, 3)
        Me.LblVendor.Name = "LblVendor"
        Me.LblVendor.ReadOnly = True
        Me.LblVendor.Size = New System.Drawing.Size(89, 20)
        Me.LblVendor.TabIndex = 420
        Me.LblVendor.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(167, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 22)
        Me.Label2.TabIndex = 336
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(6, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 22)
        Me.Label1.TabIndex = 334
        Me.Label1.Text = "Balance"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(5, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 22)
        Me.Label5.TabIndex = 332
        Me.Label5.Text = "Vendor"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LblCheck)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.LblPrepare)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.LblCredit)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.LblCharges)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.LblBalance)
        Me.Panel1.Controls.Add(Me.LblName)
        Me.Panel1.Controls.Add(Me.LblVendor)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(3, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(529, 80)
        Me.Panel1.TabIndex = 2
        '
        'LblCheck
        '
        Me.LblCheck.BackColor = System.Drawing.Color.Gold
        Me.LblCheck.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblCheck.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblCheck.DecimalDigits = 2
        Me.LblCheck.DefaultSendValue = False
        Me.LblCheck.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblCheck.FireTabAfterEnter = True
        Me.LblCheck.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblCheck.Image = CType(resources.GetObject("LblCheck.Image"), System.Drawing.Image)
        Me.LblCheck.Location = New System.Drawing.Point(247, 51)
        Me.LblCheck.Maxlength = 12
        Me.LblCheck.MinusColor = System.Drawing.Color.Empty
        Me.LblCheck.Name = "LblCheck"
        Me.LblCheck.ReadOnly = True
        Me.LblCheck.Size = New System.Drawing.Size(89, 21)
        Me.LblCheck.TabIndex = 470
        Me.LblCheck.TabStop = False
        Me.LblCheck.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblCheck.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(197, 52)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(47, 22)
        Me.Label23.TabIndex = 469
        Me.Label23.Text = "Check"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPrepare
        '
        Me.LblPrepare.BackColor = System.Drawing.Color.Gold
        Me.LblPrepare.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblPrepare.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblPrepare.DecimalDigits = 2
        Me.LblPrepare.DefaultSendValue = False
        Me.LblPrepare.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblPrepare.FireTabAfterEnter = True
        Me.LblPrepare.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblPrepare.Image = CType(resources.GetObject("LblPrepare.Image"), System.Drawing.Image)
        Me.LblPrepare.Location = New System.Drawing.Point(412, 51)
        Me.LblPrepare.Maxlength = 12
        Me.LblPrepare.MinusColor = System.Drawing.Color.Empty
        Me.LblPrepare.Name = "LblPrepare"
        Me.LblPrepare.ReadOnly = True
        Me.LblPrepare.Size = New System.Drawing.Size(89, 21)
        Me.LblPrepare.TabIndex = 464
        Me.LblPrepare.TabStop = False
        Me.LblPrepare.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblPrepare.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(341, 49)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(68, 22)
        Me.Label27.TabIndex = 463
        Me.Label27.Text = "Prepare"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCredit
        '
        Me.LblCredit.BackColor = System.Drawing.Color.Gold
        Me.LblCredit.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblCredit.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblCredit.DecimalDigits = 2
        Me.LblCredit.DefaultSendValue = False
        Me.LblCredit.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblCredit.FireTabAfterEnter = True
        Me.LblCredit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblCredit.Image = CType(resources.GetObject("LblCredit.Image"), System.Drawing.Image)
        Me.LblCredit.Location = New System.Drawing.Point(412, 27)
        Me.LblCredit.Maxlength = 12
        Me.LblCredit.MinusColor = System.Drawing.Color.Empty
        Me.LblCredit.Name = "LblCredit"
        Me.LblCredit.ReadOnly = True
        Me.LblCredit.Size = New System.Drawing.Size(89, 21)
        Me.LblCredit.TabIndex = 460
        Me.LblCredit.TabStop = False
        Me.LblCredit.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblCredit.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(367, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 22)
        Me.Label11.TabIndex = 459
        Me.Label11.Text = "Credits"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCharges
        '
        Me.LblCharges.BackColor = System.Drawing.Color.Gold
        Me.LblCharges.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblCharges.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblCharges.DecimalDigits = 2
        Me.LblCharges.DefaultSendValue = False
        Me.LblCharges.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblCharges.FireTabAfterEnter = True
        Me.LblCharges.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblCharges.Image = CType(resources.GetObject("LblCharges.Image"), System.Drawing.Image)
        Me.LblCharges.Location = New System.Drawing.Point(247, 27)
        Me.LblCharges.Maxlength = 12
        Me.LblCharges.MinusColor = System.Drawing.Color.Empty
        Me.LblCharges.Name = "LblCharges"
        Me.LblCharges.ReadOnly = True
        Me.LblCharges.Size = New System.Drawing.Size(89, 21)
        Me.LblCharges.TabIndex = 458
        Me.LblCharges.TabStop = False
        Me.LblCharges.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblCharges.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(178, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 22)
        Me.Label10.TabIndex = 457
        Me.Label10.Text = "Charges"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblBalance
        '
        Me.LblBalance.BackColor = System.Drawing.Color.Gold
        Me.LblBalance.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LblBalance.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblBalance.DecimalDigits = 2
        Me.LblBalance.DefaultSendValue = False
        Me.LblBalance.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblBalance.FireTabAfterEnter = True
        Me.LblBalance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblBalance.Image = CType(resources.GetObject("LblBalance.Image"), System.Drawing.Image)
        Me.LblBalance.Location = New System.Drawing.Point(75, 41)
        Me.LblBalance.Maxlength = 12
        Me.LblBalance.MinusColor = System.Drawing.Color.Empty
        Me.LblBalance.Name = "LblBalance"
        Me.LblBalance.ReadOnly = True
        Me.LblBalance.Size = New System.Drawing.Size(89, 21)
        Me.LblBalance.TabIndex = 456
        Me.LblBalance.TabStop = False
        Me.LblBalance.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblBalance.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblName
        '
        Me.LblName.BackColor = System.Drawing.Color.Gold
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblName.Location = New System.Drawing.Point(230, 3)
        Me.LblName.Name = "LblName"
        Me.LblName.ReadOnly = True
        Me.LblName.Size = New System.Drawing.Size(291, 20)
        Me.LblName.TabIndex = 422
        Me.LblName.Text = ""
        '
        'BtnDetail
        '
        Me.BtnDetail.BackColor = System.Drawing.SystemColors.Control
        Me.BtnDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDetail.Image = CType(resources.GetObject("BtnDetail.Image"), System.Drawing.Image)
        Me.BtnDetail.Location = New System.Drawing.Point(575, 25)
        Me.BtnDetail.Name = "BtnDetail"
        Me.BtnDetail.Size = New System.Drawing.Size(23, 23)
        Me.BtnDetail.TabIndex = 444
        Me.BtnDetail.TabStop = False
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Location = New System.Drawing.Point(568, 52)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(38, 12)
        Me.Label33.TabIndex = 445
        Me.Label33.Text = "Detail"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelGrid
        '
        Me.PanelGrid.Controls.Add(Me.GrdDetail)
        Me.PanelGrid.Controls.Add(Me.Panel3)
        Me.PanelGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelGrid.Location = New System.Drawing.Point(0, 83)
        Me.PanelGrid.Name = "PanelGrid"
        Me.PanelGrid.Size = New System.Drawing.Size(642, 330)
        Me.PanelGrid.TabIndex = 449
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowColumnDrag = False
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BackColor = System.Drawing.SystemColors.Control
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "VendorBalace"
        Me.GrdDetail.DataSource = Me.DsFrmVendorBalance1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>VendorBalace</Caption><Columns Collection=""" & _
        "true""><Column0 ID=""Ref_No""><Caption>Ref No.</Caption><TypeNameEmptyStringValue>S" & _
        "ystem.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>Ref_No</D" & _
        "ataMember><Key>Ref_No</Key><Position>0</Position></Column0><Column1 ID=""Ref_Desc" & _
        """><Caption>Description</Caption><DataMember>Ref_Desc</DataMember><EditType>NoEdi" & _
        "t</EditType><FilterEditType>TextBox</FilterEditType><Key>Ref_Desc</Key><Position" & _
        ">1</Position><Width>238</Width></Column1><Column2 ID=""Ref_Date""><Caption>Ref Dat" & _
        "e</Caption><DataMember>Ref_Date</DataMember><Key>Ref_Date</Key><Position>2</Posi" & _
        "tion><Width>81</Width></Column2><Column3 ID=""amount""><Caption>Amount</Caption><T" & _
        "ypeNameEmptyStringValue>NULL</TypeNameEmptyStringValue><EmptyStringValue /><Data" & _
        "Member>amount</DataMember><FormatString>c2</FormatString><Key>amount</Key><Posit" & _
        "ion>3</Position><TextAlignment>Far</TextAlignment></Column3><Column4 ID=""due_dat" & _
        "e""><Caption>Due Date</Caption><TypeNameEmptyStringValue>System.String</TypeNameE" & _
        "mptyStringValue><EmptyStringValue /><DataMember>due_date</DataMember><Key>due_da" & _
        "te</Key><Position>4</Position><Width>79</Width></Column4><Column5 ID=""TypeOfReco" & _
        "rd""><Caption>TypeOfRecord</Caption><DataMember>TypeOfRecord</DataMember><Key>Typ" & _
        "eOfRecord</Key><Position>5</Position><Visible>False</Visible></Column5><Column6 " & _
        "ID=""Id_AP_bill_Head""><Caption>Id_AP_bill_Head</Caption><DataMember>Id_AP_bill_He" & _
        "ad</DataMember><Key>Id_AP_bill_Head</Key><Position>6</Position><Visible>False</V" & _
        "isible></Column6><Column7 ID=""SortOrder""><Caption>SortOrder</Caption><DataMember" & _
        ">SortOrder</DataMember><Key>SortOrder</Key><Position>7</Position><Visible>False<" & _
        "/Visible></Column7></Columns><GroupCondition ID="""" /><Key>VendorBalace</Key><Sor" & _
        "tKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>7</ColIndex><SortOrder" & _
        ">Descending</SortOrder></SortKey0></SortKeys></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(0, 2)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(642, 328)
        Me.GrdDetail.TabIndex = 449
        '
        'DsFrmVendorBalance1
        '
        Me.DsFrmVendorBalance1.DataSetName = "DSFrmVendorBalance"
        Me.DsFrmVendorBalance1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.LblTotalAmountDue)
        Me.Panel3.Controls.Add(Me.LblTotalOriginalAmount)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(0, 208)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(581, 58)
        Me.Panel3.TabIndex = 450
        Me.Panel3.Visible = False
        '
        'LblTotalAmountDue
        '
        Me.LblTotalAmountDue.BackColor = System.Drawing.SystemColors.Window
        Me.LblTotalAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotalAmountDue.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblTotalAmountDue.ForeColor = System.Drawing.Color.Black
        Me.LblTotalAmountDue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTotalAmountDue.Location = New System.Drawing.Point(292, -1)
        Me.LblTotalAmountDue.Name = "LblTotalAmountDue"
        Me.LblTotalAmountDue.Size = New System.Drawing.Size(104, 20)
        Me.LblTotalAmountDue.TabIndex = 348
        Me.LblTotalAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTotalOriginalAmount
        '
        Me.LblTotalOriginalAmount.BackColor = System.Drawing.SystemColors.Window
        Me.LblTotalOriginalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotalOriginalAmount.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblTotalOriginalAmount.ForeColor = System.Drawing.Color.Black
        Me.LblTotalOriginalAmount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTotalOriginalAmount.Location = New System.Drawing.Point(188, -1)
        Me.LblTotalOriginalAmount.Name = "LblTotalOriginalAmount"
        Me.LblTotalOriginalAmount.Size = New System.Drawing.Size(106, 20)
        Me.LblTotalOriginalAmount.TabIndex = 347
        Me.LblTotalOriginalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'PanelColors
        '
        Me.PanelColors.Controls.Add(Me.Label3)
        Me.PanelColors.Controls.Add(Me.Label17)
        Me.PanelColors.Controls.Add(Me.Label16)
        Me.PanelColors.Controls.Add(Me.Label15)
        Me.PanelColors.Controls.Add(Me.Label14)
        Me.PanelColors.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelColors.Location = New System.Drawing.Point(0, 413)
        Me.PanelColors.Name = "PanelColors"
        Me.PanelColors.Size = New System.Drawing.Size(642, 28)
        Me.PanelColors.TabIndex = 450
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Tan
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(503, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 22)
        Me.Label3.TabIndex = 348
        Me.Label3.Text = "Vendor Credit"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.LightBlue
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(385, 3)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 22)
        Me.Label17.TabIndex = 347
        Me.Label17.Text = "Checks"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.LightGreen
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(267, 3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(108, 22)
        Me.Label16.TabIndex = 345
        Me.Label16.Text = "Bills"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Pink
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(149, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 22)
        Me.Label15.TabIndex = 344
        Me.Label15.Text = "Receive"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Khaki
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(31, 3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 22)
        Me.Label14.TabIndex = 343
        Me.Label14.Text = "Outside Purchase"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT 1 AS TypeOfRecord, service_out_purchases.id_service_center AS Ref_No, 'Out" & _
        "side Purchase' AS Ref_Desc, service_center_dtl.qty * (service_out_purchases.cost" & _
        " + service_out_purchases.fet) AS Amount, service_out_purchases.invoice_date AS R" & _
        "ef_Date, service_out_purchases.due_date, '' AS Id_AP_bill_Head, SUBSTRING(servic" & _
        "e_out_purchases.invoice_date + '', 7, 4) + SUBSTRING(service_out_purchases.invoi" & _
        "ce_date + '', 1, 2) + SUBSTRING(service_out_purchases.invoice_date + '', 4, 2) +" & _
        " service_out_purchases.id_service_center AS SortOrder FROM service_out_purchases" & _
        " INNER JOIN service_center_head ON service_out_purchases.id_service_center = ser" & _
        "vice_center_head.id_service_center INNER JOIN service_center_dtl ON service_out_" & _
        "purchases.id_service_center = service_center_dtl.id_service_center AND service_o" & _
        "ut_purchases.radif = service_center_dtl.radif WHERE (service_out_purchases.cod_v" & _
        "endor = @cod_vendor) AND (service_center_head.type_of_form = 'IN')"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        '
        'DAservice_out_purchases
        '
        Me.DAservice_out_purchases.SelectCommand = Me.SqlSelectCommand1
        Me.DAservice_out_purchases.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_out_purchases", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("markup", "markup"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("invoice_no", "invoice_no"), New System.Data.Common.DataColumnMapping("invoice_date", "invoice_date"), New System.Data.Common.DataColumnMapping("due_date", "due_date"), New System.Data.Common.DataColumnMapping("tracking_warranty", "tracking_warranty"), New System.Data.Common.DataColumnMapping("in_day", "in_day"), New System.Data.Common.DataColumnMapping("in_mile", "in_mile"), New System.Data.Common.DataColumnMapping("tracking_core", "tracking_core"), New System.Data.Common.DataColumnMapping("core_value", "core_value"), New System.Data.Common.DataColumnMapping("Line", "Line")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT 2 AS TypeOfRecord, Inv_Receive_Products_head.id_receive_ref AS Ref_No, 'Re" & _
        "ceive Product' AS Ref_Desc, Inv_Receive_Products_head.date_receive AS Ref_Date, " & _
        "Inv_Receive_product_Ap_Dtl.amount, Inv_Receive_product_Ap_Dtl.due_date, '' AS Id" & _
        "_AP_bill_Head, SUBSTRING(Inv_Receive_Products_head.date_receive + '', 7, 4) + SU" & _
        "BSTRING(Inv_Receive_Products_head.date_receive + '', 1, 2) + SUBSTRING(Inv_Recei" & _
        "ve_Products_head.date_receive + '', 4, 2) + Inv_Receive_Products_head.id_receive" & _
        "_ref AS SortOrder FROM Inv_Receive_product_Ap_Dtl INNER JOIN Inv_Receive_Product" & _
        "s_head ON Inv_Receive_product_Ap_Dtl.id_receive_ref = Inv_Receive_Products_head." & _
        "id_receive_ref WHERE (Inv_Receive_Products_head.cod_vendor = @cod_vendor) AND (I" & _
        "nv_Receive_Products_head.bill_credit = 1)"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        '
        'DAInv_Receive_product_Ap_Dtl
        '
        Me.DAInv_Receive_product_Ap_Dtl.SelectCommand = Me.SqlSelectCommand4
        Me.DAInv_Receive_product_Ap_Dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_Receive_product_Ap_Dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Inv_Receive_product_Ap_Dtl", "ID_Inv_Receive_product_Ap_Dtl"), New System.Data.Common.DataColumnMapping("id_receive_ref", "id_receive_ref"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("due_date", "due_date")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT 3 AS TypeOfRecord, GL_AP_bill_Dtl.ref_no AS Ref_No, GL_AP_bill_Dtl_Dtl.amo" & _
        "unt, GL_AP_bill_Dtl_Dtl.due_date, GL_AP_Bill_Head.Date_Bill AS Ref_Date, GL_AP_b" & _
        "ill_Dtl.Desc_Bill AS Ref_Desc, GL_AP_Bill_Head.Id_AP_bill_Head, SUBSTRING(GL_AP_" & _
        "Bill_Head.Date_Bill + '', 7, 4) + SUBSTRING(GL_AP_Bill_Head.Date_Bill + '', 1, 2" & _
        ") + SUBSTRING(GL_AP_Bill_Head.Date_Bill + '', 4, 2) + GL_AP_bill_Dtl.ref_no AS S" & _
        "ortOrder FROM GL_AP_bill_Dtl_Dtl INNER JOIN GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl" & _
        ".Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN GL_AP_Bill_Head ON GL" & _
        "_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head WHERE (GL_AP_Bill" & _
        "_Head.cod_vendor = @cod_vendor)"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        '
        'DAGL_AP_bill_Dtl_Dtl
        '
        Me.DAGL_AP_bill_Dtl_Dtl.SelectCommand = Me.SqlSelectCommand3
        Me.DAGL_AP_bill_Dtl_Dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_AP_bill_Dtl_Dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl_dtl", "Id_AP_bill_dtl_dtl"), New System.Data.Common.DataColumnMapping("Id_AP_bill_dtl", "Id_AP_bill_dtl"), New System.Data.Common.DataColumnMapping("amount", "amount"), New System.Data.Common.DataColumnMapping("due_date", "due_date")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT 4 AS TypeOfRecord, no_of_check AS Ref_No, amount_check AS amount, '' AS du" & _
        "e_date, date_of_check AS Ref_Date, address_payee AS Ref_Desc, '' AS Id_AP_bill_H" & _
        "ead, SUBSTRING(date_of_check + '', 7, 4) + SUBSTRING(date_of_check + '', 1, 2) +" & _
        " SUBSTRING(date_of_check + '', 4, 2) + no_of_check AS SortOrder FROM bank_check " & _
        "WHERE (cod_vendor = @cod_vendor)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        '
        'DAbank_check
        '
        Me.DAbank_check.SelectCommand = Me.SqlSelectCommand2
        Me.DAbank_check.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bank_check", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_bank", "id_bank"), New System.Data.Common.DataColumnMapping("no_of_check", "no_of_check"), New System.Data.Common.DataColumnMapping("date_of_check", "date_of_check"), New System.Data.Common.DataColumnMapping("amount_check", "amount_check"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("address_payee", "address_payee"), New System.Data.Common.DataColumnMapping("memo_check", "memo_check"), New System.Data.Common.DataColumnMapping("invoice_no", "invoice_no"), New System.Data.Common.DataColumnMapping("manual_check", "manual_check"), New System.Data.Common.DataColumnMapping("print_later", "print_later"), New System.Data.Common.DataColumnMapping("cleared_bank", "cleared_bank"), New System.Data.Common.DataColumnMapping("check_status", "check_status"), New System.Data.Common.DataColumnMapping("id_debit_deposit_head", "id_debit_deposit_head"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT 5 AS TypeOfRecord, ref_no, 'Vendor Credit' AS Ref_Desc, date_credit AS Ref" & _
        "_Date, amount_credit AS Amount, due_date, '' AS Id_AP_bill_Head, SUBSTRING(date_" & _
        "credit + '', 7, 4) + SUBSTRING(date_credit + '', 1, 2) + SUBSTRING(date_credit +" & _
        " '', 4, 2) + ref_no AS SortOrder FROM GL_vendor_credit WHERE (cod_vendor = @cod_" & _
        "vendor)"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vendor", System.Data.SqlDbType.VarChar, 6, "cod_vendor"))
        '
        'DAGL_vendor_credit
        '
        Me.DAGL_vendor_credit.SelectCommand = Me.SqlSelectCommand5
        Me.DAGL_vendor_credit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_vendor_credit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_vendor_credit", "id_vendor_credit"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("date_credit", "date_credit"), New System.Data.Common.DataColumnMapping("amount_credit", "amount_credit"), New System.Data.Common.DataColumnMapping("Remark", "Remark"), New System.Data.Common.DataColumnMapping("ref_no", "ref_no"), New System.Data.Common.DataColumnMapping("due_date", "due_date"), New System.Data.Common.DataColumnMapping("id_vendor_credit_head", "id_vendor_credit_head"), New System.Data.Common.DataColumnMapping("id_receive_ref", "id_receive_ref")})})
        '
        'FrmVendorBalance
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(642, 441)
        Me.Controls.Add(Me.PanelGrid)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.BtnDetail)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelColors)
        Me.Name = "FrmVendorBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Vendor Balance"
        Me.Panel1.ResumeLayout(False)
        Me.PanelGrid.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmVendorBalance1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.PanelColors.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmCustomerBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PanelGridHeightVar = PanelGrid.Height
        PanelColorHeightVar = PanelColors.Height
        FormHeightVar = Me.Height
        PanelGrid.Height = 0
        PanelColors.Height = 0
        Me.Height = FormHeightVar - PanelGridHeightVar - PanelColorHeightVar
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString

        Call AddConditionalFormatting()

        Call FillDataSet()

    End Sub
    Private Sub FillDataSet()

        Dim ThisConnectionStringVar As String
        DsFrmVendorBalance1.Clear()

        DAGL_AP_bill_Dtl_Dtl.SelectCommand.Parameters("@cod_vendor").Value = cod_vendorParameter
        DAGL_AP_bill_Dtl_Dtl.Fill(DsFrmVendorBalance1, "VendorBalace")

        DAInv_Receive_product_Ap_Dtl.SelectCommand.Parameters("@cod_vendor").Value = cod_vendorParameter
        DAInv_Receive_product_Ap_Dtl.Fill(DsFrmVendorBalance1, "VendorBalace")

        DAservice_out_purchases.SelectCommand.Parameters("@cod_vendor").Value = cod_vendorParameter
        DAservice_out_purchases.Fill(DsFrmVendorBalance1, "VendorBalace")

        DAbank_check.SelectCommand.Parameters("@cod_vendor").Value = cod_vendorParameter
        DAbank_check.Fill(DsFrmVendorBalance1, "VendorBalace")

        DAGL_vendor_credit.SelectCommand.Parameters("@cod_vendor").Value = cod_vendorParameter
        DAGL_vendor_credit.Fill(DsFrmVendorBalance1, "VendorBalace")

        DsFrmVendorBalance1.VendorBalace.DefaultView.Sort = "Ref_Date,Ref_No"

        LblBalance.Text = 0
        LblCharges.Text = 0
        LblCheck.Text = 0
        LblPrepare.Text = 0
        LblCredit.Text = 0

        Try
            LblCharges.Text = Math.Round(DsFrmVendorBalance1.VendorBalace.Compute("Sum(Amount)", True), 2)
        Catch ex As Exception
            LblCharges.Text = 0
        End Try

        If CmdGeneral.Connection.State = ConnectionState.Closed Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Isnull(sum(round(isnull(amount_credit,0),2)),0) FROM GL_vendor_credit WHERE cod_vendor = " & Qt(cod_vendorParameter)
        LblCredit.Text = CmdGeneral.ExecuteScalar()

        CmdGeneral.CommandText = "SELECT Isnull(SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)),0) FROM GL_AP_payment INNER JOIN service_out_purchases ON GL_AP_payment.id_service_center = service_out_purchases.id_service_center AND  GL_AP_payment.radif = service_out_purchases.radif WHERE GL_AP_payment.id_check is not null AND cod_vendor = " & Qt(cod_vendorParameter)
        LblCheck.Text = CmdGeneral.ExecuteScalar()

        CmdGeneral.CommandText = "SELECT Isnull(SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)),0) FROM GL_AP_payment INNER JOIN Inv_Receive_product_Ap_Dtl ON  GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl = Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl INNER JOIN Inv_Receive_Products_head ON Inv_Receive_product_Ap_Dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref WHERE GL_AP_payment.id_check is not null AND cod_vendor = " & Qt(cod_vendorParameter)
        LblCheck.Text = LblCheck.Numbervalue + CmdGeneral.ExecuteScalar()

        CmdGeneral.CommandText = "SELECT Isnull(SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)),0) FROM  GL_AP_payment INNER JOIN GL_AP_bill_Dtl_Dtl ON GL_AP_payment.Id_AP_bill_dtl_dtl = GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl INNER JOIN GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN GL_AP_Bill_Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head WHERE GL_AP_payment.id_check is not null AND cod_vendor = " & Qt(cod_vendorParameter)
        LblCheck.Text = LblCheck.Numbervalue + CmdGeneral.ExecuteScalar()

        CmdGeneral.CommandText = "SELECT Isnull(SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)),0) FROM GL_AP_payment INNER JOIN service_out_purchases ON GL_AP_payment.id_service_center = service_out_purchases.id_service_center AND  GL_AP_payment.radif = service_out_purchases.radif WHERE GL_AP_payment.id_check is null AND GL_AP_payment.id_vendor_credit_head is null AND cod_vendor = " & Qt(cod_vendorParameter)
        LblPrepare.Text = CmdGeneral.ExecuteScalar()

        CmdGeneral.CommandText = "SELECT Isnull(SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)),0) FROM GL_AP_payment INNER JOIN Inv_Receive_product_Ap_Dtl ON  GL_AP_payment.ID_Inv_Receive_product_Ap_Dtl = Inv_Receive_product_Ap_Dtl.ID_Inv_Receive_product_Ap_Dtl INNER JOIN Inv_Receive_Products_head ON Inv_Receive_product_Ap_Dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref WHERE GL_AP_payment.id_check is null AND GL_AP_payment.id_vendor_credit_head is null AND cod_vendor = " & Qt(cod_vendorParameter)
        LblPrepare.Text = LblPrepare.Numbervalue + CmdGeneral.ExecuteScalar()

        CmdGeneral.CommandText = "SELECT Isnull(SUM(ROUND(ISNULL(GL_AP_payment.amount_pay, 0), 2)),0) FROM  GL_AP_payment INNER JOIN GL_AP_bill_Dtl_Dtl ON GL_AP_payment.Id_AP_bill_dtl_dtl = GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl_dtl INNER JOIN GL_AP_bill_Dtl ON GL_AP_bill_Dtl_Dtl.Id_AP_bill_dtl = GL_AP_bill_Dtl.Id_AP_bill_dtl INNER JOIN GL_AP_Bill_Head ON GL_AP_bill_Dtl.Id_AP_bill_Head = GL_AP_Bill_Head.Id_AP_bill_Head WHERE GL_AP_payment.id_check is null AND GL_AP_payment.id_vendor_credit_head is null AND cod_vendor = " & Qt(cod_vendorParameter)
        LblPrepare.Text = LblPrepare.Numbervalue + CmdGeneral.ExecuteScalar()

        LblBalance.Text = LblCharges.Numbervalue - LblCredit.Numbervalue - LblCheck.Numbervalue

        DAbank_check.SelectCommand.Parameters("@cod_vendor").Value = cod_vendorParameter
        DAbank_check.Fill(DsFrmVendorBalance1, "VendorBalace")


    End Sub
    Private Sub BtnDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDetail.Click
        Me.Height = FormHeightVar
        PanelGrid.Height = PanelGridHeightVar
        PanelColors.Height = PanelColorHeightVar
    End Sub
    Private Sub AddConditionalFormatting()
        Dim fc As GridEXFormatCondition
        fc = New Janus.Windows.GridEX.GridEXFormatCondition(GrdDetail.RootTable.Columns("TypeOfRecord"), ConditionOperator.Equal, 1)
        fc.FormatStyle.BackColor = Color.Khaki
        GrdDetail.RootTable.FormatConditions.Add(fc)
        fc = New Janus.Windows.GridEX.GridEXFormatCondition(GrdDetail.RootTable.Columns("TypeOfRecord"), ConditionOperator.Equal, 2)
        fc.FormatStyle.BackColor = Color.Pink
        GrdDetail.RootTable.FormatConditions.Add(fc)
        fc = New Janus.Windows.GridEX.GridEXFormatCondition(GrdDetail.RootTable.Columns("TypeOfRecord"), ConditionOperator.Equal, 3)
        fc.FormatStyle.BackColor = Color.LightGreen
        GrdDetail.RootTable.FormatConditions.Add(fc)
        fc = New Janus.Windows.GridEX.GridEXFormatCondition(GrdDetail.RootTable.Columns("TypeOfRecord"), ConditionOperator.Equal, 4)
        fc.FormatStyle.BackColor = Color.LightBlue
        GrdDetail.RootTable.FormatConditions.Add(fc)
        fc = New Janus.Windows.GridEX.GridEXFormatCondition(GrdDetail.RootTable.Columns("TypeOfRecord"), ConditionOperator.Equal, 5)
        fc.FormatStyle.BackColor = Color.Tan
        GrdDetail.RootTable.FormatConditions.Add(fc)
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        If GrdDetail.RowCount > 0 Then
            Dim Currentrow As GridEXRow = GrdDetail.GetRow
            Select Case Currentrow.Cells("TypeOfRecord").Value
                Case 1 ' Outside Purchase
                    Dim MyFrmShowWorkOrder As New WorkOrderUtility.FrmShowWorkOrder
                    MyFrmShowWorkOrder.TypeOfForm = "IN"
                    MyFrmShowWorkOrder.TxtRef.Text = Currentrow.Cells("Ref_No").Value & ""
                    MyFrmShowWorkOrder.StartPosition = FormStartPosition.CenterScreen
                    MyFrmShowWorkOrder.ShowDialog()
                Case 2 ' Recieve
                    'Dim MyFrmShowWorkOrder As New WorkOrderUtility.FrmShowWorkOrder
                    'MyFrmShowWorkOrder.TypeOfForm = "RT"
                    'MyFrmShowWorkOrder.TxtRef.Text = Currentrow.Cells("Ref_No").Value & ""
                    'MyFrmShowWorkOrder.StartPosition = FormStartPosition.CenterScreen
                    'MyFrmShowWorkOrder.ShowDialog()
                Case 3 ' Ap Bill
                    Dim MyFrmGL_AP_bill As New FrmGL_AP_bill
                    MyFrmGL_AP_bill.Id_AP_bill_HeadForShowReadOnly = Currentrow.Cells("Id_AP_bill_Head").Value & ""
                    MyFrmGL_AP_bill.StartPosition = FormStartPosition.CenterScreen
                    MyFrmGL_AP_bill.ShowDialog()
            End Select
        End If
    End Sub
End Class
