Imports CommonClass
Public Class FrmInv_Price_Code
    Inherits FrmBase
    Dim Status As WorkStates = MainModule.WorkStates._ReadOnly
    Dim InvPrice_CodeOrderFieldName As String = "price_code"
    Friend PriceCodTempVar As String = ""
    Dim PnlSearchHeight As Integer
    Public Inv_Price_NoteVar As String
    Private PriceLevelSeqVar As String
    Dim WithEvents MyItem As UCInv_Item.Clsitem_no
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
    Friend WithEvents CmdDelete As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
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
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnPrev As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents BtnSortOrder As Janus.Windows.EditControls.UIButton
    Friend WithEvents PnlSearch As System.Windows.Forms.Panel
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmGeneral As System.Windows.Forms.ContextMenu
    Friend WithEvents MAddNew As System.Windows.Forms.MenuItem
    Friend WithEvents MEdit As System.Windows.Forms.MenuItem
    Friend WithEvents MDelete As System.Windows.Forms.MenuItem
    Friend WithEvents MSave As System.Windows.Forms.MenuItem
    Friend WithEvents MCancel As System.Windows.Forms.MenuItem
    Friend WithEvents MFirstRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MPreviousRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MNextRecord As System.Windows.Forms.MenuItem
    Friend WithEvents MLastRecord As System.Windows.Forms.MenuItem
    Friend WithEvents UiCommandManager1 As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents TxtPrice_code As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtDesc_price_code As System.Windows.Forms.TextBox
    Friend WithEvents CmbPrice1_price_level As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPrice1_D_persent As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPrice1_operator As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPrice1_c_l_a_p As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPrice2_price_level As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPrice2_D_persent As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPrice2_operator As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPrice2_c_l_a_p As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPrice3_price_level As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPrice3_D_persent As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPrice3_operator As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPrice3_c_l_a_p As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPrice4_price_level As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPrice4_D_persent As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPrice4_operator As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPrice4_c_l_a_p As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPrice5_price_level As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPrice5_D_persent As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPrice5_operator As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPrice5_c_l_a_p As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPrice6_price_level As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPrice6_D_persent As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPrice6_operator As System.Windows.Forms.ComboBox
    Friend WithEvents CmbPrice6_c_l_a_p As System.Windows.Forms.ComboBox
    Friend WithEvents UiContextMenu1 As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents Sort1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort11 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort21 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents BtnNotes As System.Windows.Forms.Button
    Friend WithEvents LblPrice6 As System.Windows.Forms.Label
    Friend WithEvents LblPrice5 As System.Windows.Forms.Label
    Friend WithEvents LblPrice4 As System.Windows.Forms.Label
    Friend WithEvents LblPrice3 As System.Windows.Forms.Label
    Friend WithEvents LblPrice2 As System.Windows.Forms.Label
    Friend WithEvents LblPrice1 As System.Windows.Forms.Label
    Friend WithEvents NumPrice1_odd_price As CalcUtils.UcCalcText
    Friend WithEvents NumPrice2_odd_price As CalcUtils.UcCalcText
    Friend WithEvents NumPrice3_odd_price As CalcUtils.UcCalcText
    Friend WithEvents NumPrice4_odd_price As CalcUtils.UcCalcText
    Friend WithEvents NumPrice5_odd_price As CalcUtils.UcCalcText
    Friend WithEvents NumPrice6_odd_price As CalcUtils.UcCalcText
    Friend WithEvents NumPrice1_Amount As CalcUtils.UcCalcText
    Friend WithEvents Chkodd_priceFlag1 As System.Windows.Forms.CheckBox
    Friend WithEvents Chkodd_priceFlag2 As System.Windows.Forms.CheckBox
    Friend WithEvents Chkodd_priceFlag3 As System.Windows.Forms.CheckBox
    Friend WithEvents Chkodd_priceFlag4 As System.Windows.Forms.CheckBox
    Friend WithEvents Chkodd_priceFlag5 As System.Windows.Forms.CheckBox
    Friend WithEvents Chkodd_priceFlag6 As System.Windows.Forms.CheckBox
    Friend WithEvents NumPrice6_Amount As CalcUtils.UcCalcText
    Friend WithEvents NumPrice5_Amount As CalcUtils.UcCalcText
    Friend WithEvents NumPrice4_Amount As CalcUtils.UcCalcText
    Friend WithEvents NumPrice3_Amount As CalcUtils.UcCalcText
    Friend WithEvents NumPrice2_Amount As CalcUtils.UcCalcText
    Friend WithEvents CnnForReader As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdGeneralForReader As System.Data.SqlClient.SqlCommand
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents CmbPrice_Code As System.Windows.Forms.ComboBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAInv_price_code As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmInv_Price_Code1 As UCInv_Item.DSFrmInv_Price_Code
    Friend WithEvents BtnCalculateAllItemsPrice As Janus.Windows.EditControls.UIButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmInv_Price_Code))
        Me.CmdDelete = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.BtnCalculateAllItemsPrice = New Janus.Windows.EditControls.UIButton
        Me.CmbPrice_Code = New System.Windows.Forms.ComboBox
        Me.DsFrmInv_Price_Code1 = New UCInv_Item.DSFrmInv_Price_Code
        Me.Label4 = New System.Windows.Forms.Label
        Me.CnnTemp = New System.Data.SqlClient.SqlConnection
        Me.PnlKartAmvalField = New System.Windows.Forms.Panel
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.NumPrice6_Amount = New CalcUtils.UcCalcText
        Me.NumPrice5_Amount = New CalcUtils.UcCalcText
        Me.NumPrice4_Amount = New CalcUtils.UcCalcText
        Me.NumPrice3_Amount = New CalcUtils.UcCalcText
        Me.NumPrice2_Amount = New CalcUtils.UcCalcText
        Me.NumPrice1_Amount = New CalcUtils.UcCalcText
        Me.NumPrice6_odd_price = New CalcUtils.UcCalcText
        Me.NumPrice5_odd_price = New CalcUtils.UcCalcText
        Me.NumPrice4_odd_price = New CalcUtils.UcCalcText
        Me.NumPrice3_odd_price = New CalcUtils.UcCalcText
        Me.NumPrice2_odd_price = New CalcUtils.UcCalcText
        Me.NumPrice1_odd_price = New CalcUtils.UcCalcText
        Me.BtnNotes = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LblPrice6 = New System.Windows.Forms.Label
        Me.CmbPrice6_price_level = New System.Windows.Forms.ComboBox
        Me.CmbPrice6_D_persent = New System.Windows.Forms.ComboBox
        Me.CmbPrice6_operator = New System.Windows.Forms.ComboBox
        Me.CmbPrice6_c_l_a_p = New System.Windows.Forms.ComboBox
        Me.LblPrice5 = New System.Windows.Forms.Label
        Me.CmbPrice5_price_level = New System.Windows.Forms.ComboBox
        Me.CmbPrice5_D_persent = New System.Windows.Forms.ComboBox
        Me.CmbPrice5_operator = New System.Windows.Forms.ComboBox
        Me.CmbPrice5_c_l_a_p = New System.Windows.Forms.ComboBox
        Me.LblPrice4 = New System.Windows.Forms.Label
        Me.CmbPrice4_price_level = New System.Windows.Forms.ComboBox
        Me.CmbPrice4_D_persent = New System.Windows.Forms.ComboBox
        Me.CmbPrice4_operator = New System.Windows.Forms.ComboBox
        Me.CmbPrice4_c_l_a_p = New System.Windows.Forms.ComboBox
        Me.LblPrice3 = New System.Windows.Forms.Label
        Me.CmbPrice3_price_level = New System.Windows.Forms.ComboBox
        Me.CmbPrice3_D_persent = New System.Windows.Forms.ComboBox
        Me.CmbPrice3_operator = New System.Windows.Forms.ComboBox
        Me.CmbPrice3_c_l_a_p = New System.Windows.Forms.ComboBox
        Me.LblPrice2 = New System.Windows.Forms.Label
        Me.CmbPrice2_price_level = New System.Windows.Forms.ComboBox
        Me.CmbPrice2_D_persent = New System.Windows.Forms.ComboBox
        Me.CmbPrice2_operator = New System.Windows.Forms.ComboBox
        Me.CmbPrice2_c_l_a_p = New System.Windows.Forms.ComboBox
        Me.LblPrice1 = New System.Windows.Forms.Label
        Me.CmbPrice1_price_level = New System.Windows.Forms.ComboBox
        Me.CmbPrice1_D_persent = New System.Windows.Forms.ComboBox
        Me.CmbPrice1_operator = New System.Windows.Forms.ComboBox
        Me.CmbPrice1_c_l_a_p = New System.Windows.Forms.ComboBox
        Me.TxtDesc_price_code = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtPrice_code = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Chkodd_priceFlag6 = New System.Windows.Forms.CheckBox
        Me.Chkodd_priceFlag5 = New System.Windows.Forms.CheckBox
        Me.Chkodd_priceFlag4 = New System.Windows.Forms.CheckBox
        Me.Chkodd_priceFlag3 = New System.Windows.Forms.CheckBox
        Me.Chkodd_priceFlag2 = New System.Windows.Forms.CheckBox
        Me.Chkodd_priceFlag1 = New System.Windows.Forms.CheckBox
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.CmdInsert = New System.Data.SqlClient.SqlCommand
        Me.CmdUpdate = New System.Data.SqlClient.SqlCommand
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label44 = New System.Windows.Forms.Label
        Me.BtnSortOrder = New Janus.Windows.EditControls.UIButton
        Me.UiContextMenu1 = New Janus.Windows.UI.CommandBars.UIContextMenu
        Me.UiCommandManager1 = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.Sort1 = New Janus.Windows.UI.CommandBars.UICommand("Sort1")
        Me.Sort2 = New Janus.Windows.UI.CommandBars.UICommand("Sort2")
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.Sort11 = New Janus.Windows.UI.CommandBars.UICommand("Sort1")
        Me.Sort21 = New Janus.Windows.UI.CommandBars.UICommand("Sort2")
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
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnNew = New System.Windows.Forms.Button
        Me.BtnFind = New System.Windows.Forms.Button
        Me.BtnNext = New System.Windows.Forms.Button
        Me.BtnPrev = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
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
        Me.CmdGeneralForReader = New System.Data.SqlClient.SqlCommand
        Me.CnnForReader = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAInv_price_code = New System.Data.SqlClient.SqlDataAdapter
        Me.PnlSearch.SuspendLayout()
        CType(Me.DsFrmInv_Price_Code1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlKartAmvalField.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.UiContextMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1.EditContextMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdDelete
        '
        Me.CmdDelete.CommandText = "DELETE FROM inv_price_code WHERE (price_code = @price_code)"
        Me.CmdDelete.Connection = Me.Cnn
        Me.CmdDelete.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_code", System.Data.DataRowVersion.Original, Nothing))
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=Tiremate_01"
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.BtnCalculateAllItemsPrice)
        Me.PnlSearch.Controls.Add(Me.CmbPrice_Code)
        Me.PnlSearch.Controls.Add(Me.Label4)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 49)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(616, 29)
        Me.PnlSearch.TabIndex = 1
        '
        'BtnCalculateAllItemsPrice
        '
        Me.BtnCalculateAllItemsPrice.Location = New System.Drawing.Point(409, 1)
        Me.BtnCalculateAllItemsPrice.Name = "BtnCalculateAllItemsPrice"
        Me.BtnCalculateAllItemsPrice.Size = New System.Drawing.Size(173, 23)
        Me.BtnCalculateAllItemsPrice.TabIndex = 191
        Me.BtnCalculateAllItemsPrice.Text = "Calculate All Items Prices"
        '
        'CmbPrice_Code
        '
        Me.CmbPrice_Code.DataSource = Me.DsFrmInv_Price_Code1.inv_price_code
        Me.CmbPrice_Code.DisplayMember = "desc_price_code"
        Me.CmbPrice_Code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice_Code.Location = New System.Drawing.Point(63, 2)
        Me.CmbPrice_Code.Name = "CmbPrice_Code"
        Me.CmbPrice_Code.Size = New System.Drawing.Size(287, 21)
        Me.CmbPrice_Code.TabIndex = 190
        Me.CmbPrice_Code.ValueMember = "price_code"
        '
        'DsFrmInv_Price_Code1
        '
        Me.DsFrmInv_Price_Code1.DataSetName = "DSFrmInv_Price_Code"
        Me.DsFrmInv_Price_Code1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(2, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 188
        Me.Label4.Text = "Price Code"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CnnTemp
        '
        Me.CnnTemp.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=Tiremate_01"
        '
        'PnlKartAmvalField
        '
        Me.PnlKartAmvalField.Controls.Add(Me.ProgressBar1)
        Me.PnlKartAmvalField.Controls.Add(Me.NumPrice6_Amount)
        Me.PnlKartAmvalField.Controls.Add(Me.NumPrice5_Amount)
        Me.PnlKartAmvalField.Controls.Add(Me.NumPrice4_Amount)
        Me.PnlKartAmvalField.Controls.Add(Me.NumPrice3_Amount)
        Me.PnlKartAmvalField.Controls.Add(Me.NumPrice2_Amount)
        Me.PnlKartAmvalField.Controls.Add(Me.NumPrice1_Amount)
        Me.PnlKartAmvalField.Controls.Add(Me.NumPrice6_odd_price)
        Me.PnlKartAmvalField.Controls.Add(Me.NumPrice5_odd_price)
        Me.PnlKartAmvalField.Controls.Add(Me.NumPrice4_odd_price)
        Me.PnlKartAmvalField.Controls.Add(Me.NumPrice3_odd_price)
        Me.PnlKartAmvalField.Controls.Add(Me.NumPrice2_odd_price)
        Me.PnlKartAmvalField.Controls.Add(Me.NumPrice1_odd_price)
        Me.PnlKartAmvalField.Controls.Add(Me.BtnNotes)
        Me.PnlKartAmvalField.Controls.Add(Me.Panel1)
        Me.PnlKartAmvalField.Controls.Add(Me.LblPrice6)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbPrice6_price_level)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbPrice6_D_persent)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbPrice6_operator)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbPrice6_c_l_a_p)
        Me.PnlKartAmvalField.Controls.Add(Me.LblPrice5)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbPrice5_price_level)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbPrice5_D_persent)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbPrice5_operator)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbPrice5_c_l_a_p)
        Me.PnlKartAmvalField.Controls.Add(Me.LblPrice4)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbPrice4_price_level)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbPrice4_D_persent)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbPrice4_operator)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbPrice4_c_l_a_p)
        Me.PnlKartAmvalField.Controls.Add(Me.LblPrice3)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbPrice3_price_level)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbPrice3_D_persent)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbPrice3_operator)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbPrice3_c_l_a_p)
        Me.PnlKartAmvalField.Controls.Add(Me.LblPrice2)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbPrice2_price_level)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbPrice2_D_persent)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbPrice2_operator)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbPrice2_c_l_a_p)
        Me.PnlKartAmvalField.Controls.Add(Me.LblPrice1)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbPrice1_price_level)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbPrice1_D_persent)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbPrice1_operator)
        Me.PnlKartAmvalField.Controls.Add(Me.CmbPrice1_c_l_a_p)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtDesc_price_code)
        Me.PnlKartAmvalField.Controls.Add(Me.Label8)
        Me.PnlKartAmvalField.Controls.Add(Me.Label7)
        Me.PnlKartAmvalField.Controls.Add(Me.Label1)
        Me.PnlKartAmvalField.Controls.Add(Me.Label3)
        Me.PnlKartAmvalField.Controls.Add(Me.Label6)
        Me.PnlKartAmvalField.Controls.Add(Me.TxtPrice_code)
        Me.PnlKartAmvalField.Controls.Add(Me.Label5)
        Me.PnlKartAmvalField.Controls.Add(Me.Label20)
        Me.PnlKartAmvalField.Controls.Add(Me.Label21)
        Me.PnlKartAmvalField.Controls.Add(Me.Chkodd_priceFlag6)
        Me.PnlKartAmvalField.Controls.Add(Me.Chkodd_priceFlag5)
        Me.PnlKartAmvalField.Controls.Add(Me.Chkodd_priceFlag4)
        Me.PnlKartAmvalField.Controls.Add(Me.Chkodd_priceFlag3)
        Me.PnlKartAmvalField.Controls.Add(Me.Chkodd_priceFlag2)
        Me.PnlKartAmvalField.Controls.Add(Me.Chkodd_priceFlag1)
        Me.PnlKartAmvalField.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlKartAmvalField.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.PnlKartAmvalField.Location = New System.Drawing.Point(0, 78)
        Me.PnlKartAmvalField.Name = "PnlKartAmvalField"
        Me.PnlKartAmvalField.Size = New System.Drawing.Size(616, 256)
        Me.PnlKartAmvalField.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 232)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(605, 19)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 478
        Me.ProgressBar1.Visible = False
        '
        'NumPrice6_Amount
        '
        Me.NumPrice6_Amount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPrice6_Amount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumPrice6_Amount.DecimalDigits = 2
        Me.NumPrice6_Amount.DefaultSendValue = False
        Me.NumPrice6_Amount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPrice6_Amount.FireTabAfterEnter = True
        Me.NumPrice6_Amount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPrice6_Amount.Image = CType(resources.GetObject("NumPrice6_Amount.Image"), System.Drawing.Image)
        Me.NumPrice6_Amount.Location = New System.Drawing.Point(530, 155)
        Me.NumPrice6_Amount.Maxlength = 10
        Me.NumPrice6_Amount.MinusColor = System.Drawing.Color.Empty
        Me.NumPrice6_Amount.Name = "NumPrice6_Amount"
        Me.NumPrice6_Amount.Size = New System.Drawing.Size(82, 22)
        Me.NumPrice6_Amount.TabIndex = 37
        Me.NumPrice6_Amount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPrice6_Amount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPrice5_Amount
        '
        Me.NumPrice5_Amount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPrice5_Amount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumPrice5_Amount.DecimalDigits = 2
        Me.NumPrice5_Amount.DefaultSendValue = False
        Me.NumPrice5_Amount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPrice5_Amount.FireTabAfterEnter = True
        Me.NumPrice5_Amount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPrice5_Amount.Image = CType(resources.GetObject("NumPrice5_Amount.Image"), System.Drawing.Image)
        Me.NumPrice5_Amount.Location = New System.Drawing.Point(442, 155)
        Me.NumPrice5_Amount.Maxlength = 10
        Me.NumPrice5_Amount.MinusColor = System.Drawing.Color.Empty
        Me.NumPrice5_Amount.Name = "NumPrice5_Amount"
        Me.NumPrice5_Amount.Size = New System.Drawing.Size(82, 22)
        Me.NumPrice5_Amount.TabIndex = 31
        Me.NumPrice5_Amount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPrice5_Amount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPrice4_Amount
        '
        Me.NumPrice4_Amount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPrice4_Amount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumPrice4_Amount.DecimalDigits = 2
        Me.NumPrice4_Amount.DefaultSendValue = False
        Me.NumPrice4_Amount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPrice4_Amount.FireTabAfterEnter = True
        Me.NumPrice4_Amount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPrice4_Amount.Image = CType(resources.GetObject("NumPrice4_Amount.Image"), System.Drawing.Image)
        Me.NumPrice4_Amount.Location = New System.Drawing.Point(356, 155)
        Me.NumPrice4_Amount.Maxlength = 10
        Me.NumPrice4_Amount.MinusColor = System.Drawing.Color.Empty
        Me.NumPrice4_Amount.Name = "NumPrice4_Amount"
        Me.NumPrice4_Amount.Size = New System.Drawing.Size(82, 22)
        Me.NumPrice4_Amount.TabIndex = 24
        Me.NumPrice4_Amount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPrice4_Amount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPrice3_Amount
        '
        Me.NumPrice3_Amount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPrice3_Amount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumPrice3_Amount.DecimalDigits = 2
        Me.NumPrice3_Amount.DefaultSendValue = False
        Me.NumPrice3_Amount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPrice3_Amount.FireTabAfterEnter = True
        Me.NumPrice3_Amount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPrice3_Amount.Image = CType(resources.GetObject("NumPrice3_Amount.Image"), System.Drawing.Image)
        Me.NumPrice3_Amount.Location = New System.Drawing.Point(268, 155)
        Me.NumPrice3_Amount.Maxlength = 10
        Me.NumPrice3_Amount.MinusColor = System.Drawing.Color.Empty
        Me.NumPrice3_Amount.Name = "NumPrice3_Amount"
        Me.NumPrice3_Amount.Size = New System.Drawing.Size(82, 22)
        Me.NumPrice3_Amount.TabIndex = 18
        Me.NumPrice3_Amount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPrice3_Amount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPrice2_Amount
        '
        Me.NumPrice2_Amount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPrice2_Amount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumPrice2_Amount.DecimalDigits = 2
        Me.NumPrice2_Amount.DefaultSendValue = False
        Me.NumPrice2_Amount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPrice2_Amount.FireTabAfterEnter = True
        Me.NumPrice2_Amount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPrice2_Amount.Image = CType(resources.GetObject("NumPrice2_Amount.Image"), System.Drawing.Image)
        Me.NumPrice2_Amount.Location = New System.Drawing.Point(183, 155)
        Me.NumPrice2_Amount.Maxlength = 10
        Me.NumPrice2_Amount.MinusColor = System.Drawing.Color.Empty
        Me.NumPrice2_Amount.Name = "NumPrice2_Amount"
        Me.NumPrice2_Amount.Size = New System.Drawing.Size(82, 22)
        Me.NumPrice2_Amount.TabIndex = 12
        Me.NumPrice2_Amount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPrice2_Amount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPrice1_Amount
        '
        Me.NumPrice1_Amount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPrice1_Amount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumPrice1_Amount.DecimalDigits = 2
        Me.NumPrice1_Amount.DefaultSendValue = False
        Me.NumPrice1_Amount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPrice1_Amount.FireTabAfterEnter = True
        Me.NumPrice1_Amount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPrice1_Amount.Image = CType(resources.GetObject("NumPrice1_Amount.Image"), System.Drawing.Image)
        Me.NumPrice1_Amount.Location = New System.Drawing.Point(97, 155)
        Me.NumPrice1_Amount.Maxlength = 10
        Me.NumPrice1_Amount.MinusColor = System.Drawing.Color.Empty
        Me.NumPrice1_Amount.Name = "NumPrice1_Amount"
        Me.NumPrice1_Amount.Size = New System.Drawing.Size(82, 22)
        Me.NumPrice1_Amount.TabIndex = 6
        Me.NumPrice1_Amount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPrice1_Amount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPrice6_odd_price
        '
        Me.NumPrice6_odd_price.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPrice6_odd_price.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumPrice6_odd_price.DecimalDigits = 2
        Me.NumPrice6_odd_price.DefaultSendValue = False
        Me.NumPrice6_odd_price.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPrice6_odd_price.FireTabAfterEnter = True
        Me.NumPrice6_odd_price.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPrice6_odd_price.Image = CType(resources.GetObject("NumPrice6_odd_price.Image"), System.Drawing.Image)
        Me.NumPrice6_odd_price.Location = New System.Drawing.Point(530, 180)
        Me.NumPrice6_odd_price.Maxlength = 3
        Me.NumPrice6_odd_price.MinusColor = System.Drawing.Color.Empty
        Me.NumPrice6_odd_price.Name = "NumPrice6_odd_price"
        Me.NumPrice6_odd_price.Size = New System.Drawing.Size(50, 22)
        Me.NumPrice6_odd_price.TabIndex = 38
        Me.NumPrice6_odd_price.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPrice6_odd_price.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPrice5_odd_price
        '
        Me.NumPrice5_odd_price.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPrice5_odd_price.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumPrice5_odd_price.DecimalDigits = 2
        Me.NumPrice5_odd_price.DefaultSendValue = False
        Me.NumPrice5_odd_price.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPrice5_odd_price.FireTabAfterEnter = True
        Me.NumPrice5_odd_price.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPrice5_odd_price.Image = CType(resources.GetObject("NumPrice5_odd_price.Image"), System.Drawing.Image)
        Me.NumPrice5_odd_price.Location = New System.Drawing.Point(442, 180)
        Me.NumPrice5_odd_price.Maxlength = 3
        Me.NumPrice5_odd_price.MinusColor = System.Drawing.Color.Empty
        Me.NumPrice5_odd_price.Name = "NumPrice5_odd_price"
        Me.NumPrice5_odd_price.Size = New System.Drawing.Size(50, 22)
        Me.NumPrice5_odd_price.TabIndex = 32
        Me.NumPrice5_odd_price.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPrice5_odd_price.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPrice4_odd_price
        '
        Me.NumPrice4_odd_price.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPrice4_odd_price.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumPrice4_odd_price.DecimalDigits = 2
        Me.NumPrice4_odd_price.DefaultSendValue = False
        Me.NumPrice4_odd_price.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPrice4_odd_price.FireTabAfterEnter = True
        Me.NumPrice4_odd_price.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPrice4_odd_price.Image = CType(resources.GetObject("NumPrice4_odd_price.Image"), System.Drawing.Image)
        Me.NumPrice4_odd_price.Location = New System.Drawing.Point(356, 180)
        Me.NumPrice4_odd_price.Maxlength = 3
        Me.NumPrice4_odd_price.MinusColor = System.Drawing.Color.Empty
        Me.NumPrice4_odd_price.Name = "NumPrice4_odd_price"
        Me.NumPrice4_odd_price.Size = New System.Drawing.Size(50, 22)
        Me.NumPrice4_odd_price.TabIndex = 25
        Me.NumPrice4_odd_price.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPrice4_odd_price.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPrice3_odd_price
        '
        Me.NumPrice3_odd_price.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPrice3_odd_price.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumPrice3_odd_price.DecimalDigits = 2
        Me.NumPrice3_odd_price.DefaultSendValue = False
        Me.NumPrice3_odd_price.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPrice3_odd_price.FireTabAfterEnter = True
        Me.NumPrice3_odd_price.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPrice3_odd_price.Image = CType(resources.GetObject("NumPrice3_odd_price.Image"), System.Drawing.Image)
        Me.NumPrice3_odd_price.Location = New System.Drawing.Point(268, 180)
        Me.NumPrice3_odd_price.Maxlength = 3
        Me.NumPrice3_odd_price.MinusColor = System.Drawing.Color.Empty
        Me.NumPrice3_odd_price.Name = "NumPrice3_odd_price"
        Me.NumPrice3_odd_price.Size = New System.Drawing.Size(50, 22)
        Me.NumPrice3_odd_price.TabIndex = 19
        Me.NumPrice3_odd_price.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPrice3_odd_price.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPrice2_odd_price
        '
        Me.NumPrice2_odd_price.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPrice2_odd_price.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumPrice2_odd_price.DecimalDigits = 2
        Me.NumPrice2_odd_price.DefaultSendValue = False
        Me.NumPrice2_odd_price.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPrice2_odd_price.FireTabAfterEnter = True
        Me.NumPrice2_odd_price.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPrice2_odd_price.Image = CType(resources.GetObject("NumPrice2_odd_price.Image"), System.Drawing.Image)
        Me.NumPrice2_odd_price.Location = New System.Drawing.Point(183, 180)
        Me.NumPrice2_odd_price.Maxlength = 3
        Me.NumPrice2_odd_price.MinusColor = System.Drawing.Color.Empty
        Me.NumPrice2_odd_price.Name = "NumPrice2_odd_price"
        Me.NumPrice2_odd_price.Size = New System.Drawing.Size(50, 22)
        Me.NumPrice2_odd_price.TabIndex = 13
        Me.NumPrice2_odd_price.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPrice2_odd_price.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPrice1_odd_price
        '
        Me.NumPrice1_odd_price.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPrice1_odd_price.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumPrice1_odd_price.DecimalDigits = 2
        Me.NumPrice1_odd_price.DefaultSendValue = False
        Me.NumPrice1_odd_price.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPrice1_odd_price.FireTabAfterEnter = True
        Me.NumPrice1_odd_price.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPrice1_odd_price.Image = CType(resources.GetObject("NumPrice1_odd_price.Image"), System.Drawing.Image)
        Me.NumPrice1_odd_price.Location = New System.Drawing.Point(97, 180)
        Me.NumPrice1_odd_price.Maxlength = 3
        Me.NumPrice1_odd_price.MinusColor = System.Drawing.Color.Empty
        Me.NumPrice1_odd_price.Name = "NumPrice1_odd_price"
        Me.NumPrice1_odd_price.Size = New System.Drawing.Size(50, 22)
        Me.NumPrice1_odd_price.TabIndex = 7
        Me.NumPrice1_odd_price.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPrice1_odd_price.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'BtnNotes
        '
        Me.BtnNotes.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnNotes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnNotes.Location = New System.Drawing.Point(516, 5)
        Me.BtnNotes.Name = "BtnNotes"
        Me.BtnNotes.Size = New System.Drawing.Size(80, 22)
        Me.BtnNotes.TabIndex = 471
        Me.BtnNotes.TabStop = False
        Me.BtnNotes.Text = "Notes"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(-26, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 1)
        Me.Panel1.TabIndex = 470
        '
        'LblPrice6
        '
        Me.LblPrice6.BackColor = System.Drawing.SystemColors.Control
        Me.LblPrice6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrice6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblPrice6.Location = New System.Drawing.Point(510, 64)
        Me.LblPrice6.Name = "LblPrice6"
        Me.LblPrice6.Size = New System.Drawing.Size(83, 17)
        Me.LblPrice6.TabIndex = 469
        Me.LblPrice6.Text = "Price 6"
        Me.LblPrice6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbPrice6_price_level
        '
        Me.CmbPrice6_price_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice6_price_level.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5"})
        Me.CmbPrice6_price_level.Location = New System.Drawing.Point(530, 204)
        Me.CmbPrice6_price_level.Name = "CmbPrice6_price_level"
        Me.CmbPrice6_price_level.Size = New System.Drawing.Size(44, 21)
        Me.CmbPrice6_price_level.TabIndex = 39
        '
        'CmbPrice6_D_persent
        '
        Me.CmbPrice6_D_persent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice6_D_persent.Items.AddRange(New Object() {"", "%", "$"})
        Me.CmbPrice6_D_persent.Location = New System.Drawing.Point(530, 131)
        Me.CmbPrice6_D_persent.Name = "CmbPrice6_D_persent"
        Me.CmbPrice6_D_persent.Size = New System.Drawing.Size(54, 21)
        Me.CmbPrice6_D_persent.TabIndex = 36
        '
        'CmbPrice6_operator
        '
        Me.CmbPrice6_operator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice6_operator.Items.AddRange(New Object() {"", "+", "-", "/", "*"})
        Me.CmbPrice6_operator.Location = New System.Drawing.Point(530, 106)
        Me.CmbPrice6_operator.Name = "CmbPrice6_operator"
        Me.CmbPrice6_operator.Size = New System.Drawing.Size(54, 21)
        Me.CmbPrice6_operator.TabIndex = 35
        '
        'CmbPrice6_c_l_a_p
        '
        Me.CmbPrice6_c_l_a_p.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice6_c_l_a_p.Items.AddRange(New Object() {"", "C", "L", "A", "P"})
        Me.CmbPrice6_c_l_a_p.Location = New System.Drawing.Point(530, 81)
        Me.CmbPrice6_c_l_a_p.Name = "CmbPrice6_c_l_a_p"
        Me.CmbPrice6_c_l_a_p.Size = New System.Drawing.Size(54, 21)
        Me.CmbPrice6_c_l_a_p.TabIndex = 34
        '
        'LblPrice5
        '
        Me.LblPrice5.BackColor = System.Drawing.SystemColors.Control
        Me.LblPrice5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrice5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblPrice5.Location = New System.Drawing.Point(422, 64)
        Me.LblPrice5.Name = "LblPrice5"
        Me.LblPrice5.Size = New System.Drawing.Size(83, 17)
        Me.LblPrice5.TabIndex = 27
        Me.LblPrice5.Text = "Price 5"
        Me.LblPrice5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbPrice5_price_level
        '
        Me.CmbPrice5_price_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice5_price_level.Items.AddRange(New Object() {"", "1", "2", "3", "4", "6"})
        Me.CmbPrice5_price_level.Location = New System.Drawing.Point(442, 204)
        Me.CmbPrice5_price_level.Name = "CmbPrice5_price_level"
        Me.CmbPrice5_price_level.Size = New System.Drawing.Size(45, 21)
        Me.CmbPrice5_price_level.TabIndex = 33
        '
        'CmbPrice5_D_persent
        '
        Me.CmbPrice5_D_persent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice5_D_persent.Items.AddRange(New Object() {"", "%", "$"})
        Me.CmbPrice5_D_persent.Location = New System.Drawing.Point(442, 131)
        Me.CmbPrice5_D_persent.Name = "CmbPrice5_D_persent"
        Me.CmbPrice5_D_persent.Size = New System.Drawing.Size(55, 21)
        Me.CmbPrice5_D_persent.TabIndex = 30
        '
        'CmbPrice5_operator
        '
        Me.CmbPrice5_operator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice5_operator.Items.AddRange(New Object() {"", "+", "-", "/", "*"})
        Me.CmbPrice5_operator.Location = New System.Drawing.Point(442, 106)
        Me.CmbPrice5_operator.Name = "CmbPrice5_operator"
        Me.CmbPrice5_operator.Size = New System.Drawing.Size(55, 21)
        Me.CmbPrice5_operator.TabIndex = 29
        '
        'CmbPrice5_c_l_a_p
        '
        Me.CmbPrice5_c_l_a_p.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice5_c_l_a_p.Items.AddRange(New Object() {"", "C", "L", "A", "P"})
        Me.CmbPrice5_c_l_a_p.Location = New System.Drawing.Point(442, 81)
        Me.CmbPrice5_c_l_a_p.Name = "CmbPrice5_c_l_a_p"
        Me.CmbPrice5_c_l_a_p.Size = New System.Drawing.Size(55, 21)
        Me.CmbPrice5_c_l_a_p.TabIndex = 28
        '
        'LblPrice4
        '
        Me.LblPrice4.BackColor = System.Drawing.SystemColors.Control
        Me.LblPrice4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrice4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblPrice4.Location = New System.Drawing.Point(338, 64)
        Me.LblPrice4.Name = "LblPrice4"
        Me.LblPrice4.Size = New System.Drawing.Size(83, 17)
        Me.LblPrice4.TabIndex = 455
        Me.LblPrice4.Text = "Price 4"
        Me.LblPrice4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbPrice4_price_level
        '
        Me.CmbPrice4_price_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice4_price_level.Items.AddRange(New Object() {"", "1", "2", "3", "5", "6"})
        Me.CmbPrice4_price_level.Location = New System.Drawing.Point(356, 204)
        Me.CmbPrice4_price_level.Name = "CmbPrice4_price_level"
        Me.CmbPrice4_price_level.Size = New System.Drawing.Size(43, 21)
        Me.CmbPrice4_price_level.TabIndex = 26
        '
        'CmbPrice4_D_persent
        '
        Me.CmbPrice4_D_persent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice4_D_persent.Items.AddRange(New Object() {"", "%", "$"})
        Me.CmbPrice4_D_persent.Location = New System.Drawing.Point(356, 131)
        Me.CmbPrice4_D_persent.Name = "CmbPrice4_D_persent"
        Me.CmbPrice4_D_persent.Size = New System.Drawing.Size(53, 21)
        Me.CmbPrice4_D_persent.TabIndex = 23
        '
        'CmbPrice4_operator
        '
        Me.CmbPrice4_operator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice4_operator.Items.AddRange(New Object() {"", "+", "-", "/", "*"})
        Me.CmbPrice4_operator.Location = New System.Drawing.Point(356, 106)
        Me.CmbPrice4_operator.Name = "CmbPrice4_operator"
        Me.CmbPrice4_operator.Size = New System.Drawing.Size(53, 21)
        Me.CmbPrice4_operator.TabIndex = 22
        '
        'CmbPrice4_c_l_a_p
        '
        Me.CmbPrice4_c_l_a_p.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice4_c_l_a_p.Items.AddRange(New Object() {"", "C", "L", "A", "P"})
        Me.CmbPrice4_c_l_a_p.Location = New System.Drawing.Point(356, 81)
        Me.CmbPrice4_c_l_a_p.Name = "CmbPrice4_c_l_a_p"
        Me.CmbPrice4_c_l_a_p.Size = New System.Drawing.Size(53, 21)
        Me.CmbPrice4_c_l_a_p.TabIndex = 21
        '
        'LblPrice3
        '
        Me.LblPrice3.BackColor = System.Drawing.SystemColors.Control
        Me.LblPrice3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrice3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblPrice3.Location = New System.Drawing.Point(251, 64)
        Me.LblPrice3.Name = "LblPrice3"
        Me.LblPrice3.Size = New System.Drawing.Size(83, 17)
        Me.LblPrice3.TabIndex = 448
        Me.LblPrice3.Text = "Price 3"
        Me.LblPrice3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbPrice3_price_level
        '
        Me.CmbPrice3_price_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice3_price_level.Items.AddRange(New Object() {"", "1", "2", "4", "5", "6"})
        Me.CmbPrice3_price_level.Location = New System.Drawing.Point(268, 204)
        Me.CmbPrice3_price_level.Name = "CmbPrice3_price_level"
        Me.CmbPrice3_price_level.Size = New System.Drawing.Size(45, 21)
        Me.CmbPrice3_price_level.TabIndex = 20
        '
        'CmbPrice3_D_persent
        '
        Me.CmbPrice3_D_persent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice3_D_persent.Items.AddRange(New Object() {"", "%", "$"})
        Me.CmbPrice3_D_persent.Location = New System.Drawing.Point(268, 131)
        Me.CmbPrice3_D_persent.Name = "CmbPrice3_D_persent"
        Me.CmbPrice3_D_persent.Size = New System.Drawing.Size(55, 21)
        Me.CmbPrice3_D_persent.TabIndex = 17
        '
        'CmbPrice3_operator
        '
        Me.CmbPrice3_operator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice3_operator.Items.AddRange(New Object() {"", "+", "-", "/", "*"})
        Me.CmbPrice3_operator.Location = New System.Drawing.Point(268, 106)
        Me.CmbPrice3_operator.Name = "CmbPrice3_operator"
        Me.CmbPrice3_operator.Size = New System.Drawing.Size(55, 21)
        Me.CmbPrice3_operator.TabIndex = 16
        '
        'CmbPrice3_c_l_a_p
        '
        Me.CmbPrice3_c_l_a_p.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice3_c_l_a_p.Items.AddRange(New Object() {"", "C", "L", "A", "P"})
        Me.CmbPrice3_c_l_a_p.Location = New System.Drawing.Point(268, 81)
        Me.CmbPrice3_c_l_a_p.Name = "CmbPrice3_c_l_a_p"
        Me.CmbPrice3_c_l_a_p.Size = New System.Drawing.Size(55, 21)
        Me.CmbPrice3_c_l_a_p.TabIndex = 15
        '
        'LblPrice2
        '
        Me.LblPrice2.BackColor = System.Drawing.SystemColors.Control
        Me.LblPrice2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrice2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblPrice2.Location = New System.Drawing.Point(166, 64)
        Me.LblPrice2.Name = "LblPrice2"
        Me.LblPrice2.Size = New System.Drawing.Size(83, 17)
        Me.LblPrice2.TabIndex = 441
        Me.LblPrice2.Text = "Price 2"
        Me.LblPrice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbPrice2_price_level
        '
        Me.CmbPrice2_price_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice2_price_level.Items.AddRange(New Object() {"", "1", "3", "4", "5", "6"})
        Me.CmbPrice2_price_level.Location = New System.Drawing.Point(183, 204)
        Me.CmbPrice2_price_level.Name = "CmbPrice2_price_level"
        Me.CmbPrice2_price_level.Size = New System.Drawing.Size(42, 21)
        Me.CmbPrice2_price_level.TabIndex = 14
        '
        'CmbPrice2_D_persent
        '
        Me.CmbPrice2_D_persent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice2_D_persent.Items.AddRange(New Object() {"", "%", "$"})
        Me.CmbPrice2_D_persent.Location = New System.Drawing.Point(183, 131)
        Me.CmbPrice2_D_persent.Name = "CmbPrice2_D_persent"
        Me.CmbPrice2_D_persent.Size = New System.Drawing.Size(52, 21)
        Me.CmbPrice2_D_persent.TabIndex = 11
        '
        'CmbPrice2_operator
        '
        Me.CmbPrice2_operator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice2_operator.Items.AddRange(New Object() {"", "+", "-", "/", "*"})
        Me.CmbPrice2_operator.Location = New System.Drawing.Point(183, 106)
        Me.CmbPrice2_operator.Name = "CmbPrice2_operator"
        Me.CmbPrice2_operator.Size = New System.Drawing.Size(52, 21)
        Me.CmbPrice2_operator.TabIndex = 10
        '
        'CmbPrice2_c_l_a_p
        '
        Me.CmbPrice2_c_l_a_p.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice2_c_l_a_p.Items.AddRange(New Object() {"", "C", "L", "A", "P"})
        Me.CmbPrice2_c_l_a_p.Location = New System.Drawing.Point(183, 81)
        Me.CmbPrice2_c_l_a_p.Name = "CmbPrice2_c_l_a_p"
        Me.CmbPrice2_c_l_a_p.Size = New System.Drawing.Size(52, 21)
        Me.CmbPrice2_c_l_a_p.TabIndex = 9
        '
        'LblPrice1
        '
        Me.LblPrice1.BackColor = System.Drawing.SystemColors.Control
        Me.LblPrice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrice1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblPrice1.Location = New System.Drawing.Point(83, 64)
        Me.LblPrice1.Name = "LblPrice1"
        Me.LblPrice1.Size = New System.Drawing.Size(83, 17)
        Me.LblPrice1.TabIndex = 2
        Me.LblPrice1.Text = "Price 1"
        Me.LblPrice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbPrice1_price_level
        '
        Me.CmbPrice1_price_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice1_price_level.Items.AddRange(New Object() {"", "2", "3", "4", "5", "6"})
        Me.CmbPrice1_price_level.Location = New System.Drawing.Point(97, 204)
        Me.CmbPrice1_price_level.Name = "CmbPrice1_price_level"
        Me.CmbPrice1_price_level.Size = New System.Drawing.Size(43, 21)
        Me.CmbPrice1_price_level.TabIndex = 8
        '
        'CmbPrice1_D_persent
        '
        Me.CmbPrice1_D_persent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice1_D_persent.Items.AddRange(New Object() {"", "%", "$"})
        Me.CmbPrice1_D_persent.Location = New System.Drawing.Point(97, 131)
        Me.CmbPrice1_D_persent.Name = "CmbPrice1_D_persent"
        Me.CmbPrice1_D_persent.Size = New System.Drawing.Size(53, 21)
        Me.CmbPrice1_D_persent.TabIndex = 5
        '
        'CmbPrice1_operator
        '
        Me.CmbPrice1_operator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice1_operator.Items.AddRange(New Object() {"", "+", "-", "/", "*"})
        Me.CmbPrice1_operator.Location = New System.Drawing.Point(97, 106)
        Me.CmbPrice1_operator.Name = "CmbPrice1_operator"
        Me.CmbPrice1_operator.Size = New System.Drawing.Size(53, 21)
        Me.CmbPrice1_operator.TabIndex = 4
        '
        'CmbPrice1_c_l_a_p
        '
        Me.CmbPrice1_c_l_a_p.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice1_c_l_a_p.Items.AddRange(New Object() {"", "C", "L", "A", "P"})
        Me.CmbPrice1_c_l_a_p.Location = New System.Drawing.Point(97, 81)
        Me.CmbPrice1_c_l_a_p.Name = "CmbPrice1_c_l_a_p"
        Me.CmbPrice1_c_l_a_p.Size = New System.Drawing.Size(53, 21)
        Me.CmbPrice1_c_l_a_p.TabIndex = 3
        '
        'TxtDesc_price_code
        '
        Me.TxtDesc_price_code.Location = New System.Drawing.Point(75, 31)
        Me.TxtDesc_price_code.MaxLength = 50
        Me.TxtDesc_price_code.Name = "TxtDesc_price_code"
        Me.TxtDesc_price_code.Size = New System.Drawing.Size(521, 20)
        Me.TxtDesc_price_code.TabIndex = 1
        Me.TxtDesc_price_code.Text = ""
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(7, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 20)
        Me.Label8.TabIndex = 359
        Me.Label8.Tag = ""
        Me.Label8.Text = "Price Level"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(7, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 21)
        Me.Label7.TabIndex = 355
        Me.Label7.Text = "Odd Price"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(7, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 351
        Me.Label1.Text = "Amount"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(5, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 21)
        Me.Label3.TabIndex = 346
        Me.Label3.Tag = ""
        Me.Label3.Text = "$/%"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(7, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 21)
        Me.Label6.TabIndex = 340
        Me.Label6.Tag = ""
        Me.Label6.Text = "Cst/Lst/Avg/PL"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtPrice_code
        '
        Me.TxtPrice_code.Location = New System.Drawing.Point(75, 6)
        Me.TxtPrice_code.MaxLength = 6
        Me.TxtPrice_code.Name = "TxtPrice_code"
        Me.TxtPrice_code.Size = New System.Drawing.Size(97, 20)
        Me.TxtPrice_code.TabIndex = 0
        Me.TxtPrice_code.Text = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(10, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 22)
        Me.Label5.TabIndex = 328
        Me.Label5.Text = "Price Code"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(7, 104)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 20)
        Me.Label20.TabIndex = 343
        Me.Label20.Tag = ""
        Me.Label20.Text = "Operator"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(6, 28)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(66, 22)
        Me.Label21.TabIndex = 427
        Me.Label21.Text = "Description"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Chkodd_priceFlag6
        '
        Me.Chkodd_priceFlag6.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Chkodd_priceFlag6.Location = New System.Drawing.Point(574, 182)
        Me.Chkodd_priceFlag6.Name = "Chkodd_priceFlag6"
        Me.Chkodd_priceFlag6.Size = New System.Drawing.Size(35, 46)
        Me.Chkodd_priceFlag6.TabIndex = 477
        Me.Chkodd_priceFlag6.TabStop = False
        Me.Chkodd_priceFlag6.Text = "No Odd"
        Me.Chkodd_priceFlag6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Chkodd_priceFlag5
        '
        Me.Chkodd_priceFlag5.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Chkodd_priceFlag5.Location = New System.Drawing.Point(486, 182)
        Me.Chkodd_priceFlag5.Name = "Chkodd_priceFlag5"
        Me.Chkodd_priceFlag5.Size = New System.Drawing.Size(35, 46)
        Me.Chkodd_priceFlag5.TabIndex = 476
        Me.Chkodd_priceFlag5.TabStop = False
        Me.Chkodd_priceFlag5.Text = "No Odd"
        Me.Chkodd_priceFlag5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Chkodd_priceFlag4
        '
        Me.Chkodd_priceFlag4.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Chkodd_priceFlag4.Location = New System.Drawing.Point(399, 182)
        Me.Chkodd_priceFlag4.Name = "Chkodd_priceFlag4"
        Me.Chkodd_priceFlag4.Size = New System.Drawing.Size(35, 46)
        Me.Chkodd_priceFlag4.TabIndex = 475
        Me.Chkodd_priceFlag4.TabStop = False
        Me.Chkodd_priceFlag4.Text = "No Odd"
        Me.Chkodd_priceFlag4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Chkodd_priceFlag3
        '
        Me.Chkodd_priceFlag3.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Chkodd_priceFlag3.Location = New System.Drawing.Point(312, 182)
        Me.Chkodd_priceFlag3.Name = "Chkodd_priceFlag3"
        Me.Chkodd_priceFlag3.Size = New System.Drawing.Size(35, 46)
        Me.Chkodd_priceFlag3.TabIndex = 474
        Me.Chkodd_priceFlag3.TabStop = False
        Me.Chkodd_priceFlag3.Text = "No Odd"
        Me.Chkodd_priceFlag3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Chkodd_priceFlag2
        '
        Me.Chkodd_priceFlag2.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Chkodd_priceFlag2.Location = New System.Drawing.Point(227, 182)
        Me.Chkodd_priceFlag2.Name = "Chkodd_priceFlag2"
        Me.Chkodd_priceFlag2.Size = New System.Drawing.Size(35, 46)
        Me.Chkodd_priceFlag2.TabIndex = 473
        Me.Chkodd_priceFlag2.TabStop = False
        Me.Chkodd_priceFlag2.Text = "No Odd"
        Me.Chkodd_priceFlag2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Chkodd_priceFlag1
        '
        Me.Chkodd_priceFlag1.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Chkodd_priceFlag1.Location = New System.Drawing.Point(140, 182)
        Me.Chkodd_priceFlag1.Name = "Chkodd_priceFlag1"
        Me.Chkodd_priceFlag1.Size = New System.Drawing.Size(35, 46)
        Me.Chkodd_priceFlag1.TabIndex = 472
        Me.Chkodd_priceFlag1.TabStop = False
        Me.Chkodd_priceFlag1.Text = "No Odd"
        Me.Chkodd_priceFlag1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.CnnTemp
        '
        'CmdInsert
        '
        Me.CmdInsert.CommandText = "INSERT INTO inv_price_code (price_code, desc_price_code, price1_c_l_a_p, price1_o" & _
        "perator, price1_d_persent, price1_amount, price1_odd_price, price1_price_level, " & _
        "price2_c_l_a_p, price2_operator, price2_d_persent, price2_amount, price2_odd_pri" & _
        "ce, price2_price_level, price3_c_l_a_p, price3_operator, price3_d_persent, price" & _
        "3_amount, price3_odd_price, price3_price_level, price4_c_l_a_p, price4_operator," & _
        " price4_d_persent, price4_amount, price4_odd_price, price4_price_level, price5_c" & _
        "_l_a_p, price5_operator, price5_d_persent, price5_amount, price5_odd_price, pric" & _
        "e5_price_level, price6_c_l_a_p, price6_operator, price6_d_persent, price6_amount" & _
        ", price6_odd_price, price6_price_level, special_notice) VALUES (@price_code, @de" & _
        "sc_price_code, @price1_c_l_a_p, @price1_operator, @price1_d_persent, @price1_amo" & _
        "unt, @price1_odd_price, @price1_price_level, @price2_c_l_a_p, @price2_operator, " & _
        "@price2_d_persent, @price2_amount, @price2_odd_price, @price2_price_level, @pric" & _
        "e3_c_l_a_p, @price3_operator, @price3_d_persent, @price3_amount, @price3_odd_pri" & _
        "ce, @price3_price_level, @price4_c_l_a_p, @price4_operator, @price4_d_persent, @" & _
        "price4_amount, @price4_odd_price, @price4_price_level, @price5_c_l_a_p, @price5_" & _
        "operator, @price5_d_persent, @price5_amount, @price5_odd_price, @price5_price_le" & _
        "vel, @price6_c_l_a_p, @price6_operator, @price6_d_persent, @price6_amount, @pric" & _
        "e6_odd_price, @price6_price_level, @special_notice)"
        Me.CmdInsert.Connection = Me.Cnn
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_code", System.Data.SqlDbType.VarChar, 5, "price_code"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_price_code", System.Data.SqlDbType.VarChar, 50, "desc_price_code"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price1_c_l_a_p"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_operator", System.Data.SqlDbType.VarChar, 1, "price1_operator"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_d_persent", System.Data.SqlDbType.VarChar, 1, "price1_d_persent"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_amount", System.Data.SqlDbType.Real, 4, "price1_amount"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_odd_price", System.Data.SqlDbType.Real, 4, "price1_odd_price"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_price_level", System.Data.SqlDbType.VarChar, 1, "price1_price_level"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price2_c_l_a_p"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_operator", System.Data.SqlDbType.VarChar, 1, "price2_operator"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_d_persent", System.Data.SqlDbType.VarChar, 1, "price2_d_persent"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_amount", System.Data.SqlDbType.Real, 4, "price2_amount"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_odd_price", System.Data.SqlDbType.Real, 4, "price2_odd_price"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_price_level", System.Data.SqlDbType.VarChar, 1, "price2_price_level"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price3_c_l_a_p"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_operator", System.Data.SqlDbType.VarChar, 1, "price3_operator"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_d_persent", System.Data.SqlDbType.VarChar, 1, "price3_d_persent"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_amount", System.Data.SqlDbType.Real, 4, "price3_amount"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_odd_price", System.Data.SqlDbType.Real, 4, "price3_odd_price"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_price_level", System.Data.SqlDbType.VarChar, 1, "price3_price_level"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price4_c_l_a_p"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_operator", System.Data.SqlDbType.VarChar, 1, "price4_operator"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_d_persent", System.Data.SqlDbType.VarChar, 1, "price4_d_persent"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_amount", System.Data.SqlDbType.Real, 4, "price4_amount"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_odd_price", System.Data.SqlDbType.Real, 4, "price4_odd_price"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_price_level", System.Data.SqlDbType.VarChar, 1, "price4_price_level"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price5_c_l_a_p"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_operator", System.Data.SqlDbType.VarChar, 1, "price5_operator"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_d_persent", System.Data.SqlDbType.VarChar, 1, "price5_d_persent"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_amount", System.Data.SqlDbType.Real, 4, "price5_amount"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_odd_price", System.Data.SqlDbType.Real, 4, "price5_odd_price"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_price_level", System.Data.SqlDbType.VarChar, 1, "price5_price_level"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price6_c_l_a_p"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_operator", System.Data.SqlDbType.VarChar, 1, "price6_operator"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_d_persent", System.Data.SqlDbType.VarChar, 1, "price6_d_persent"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_amount", System.Data.SqlDbType.Real, 4, "price6_amount"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_odd_price", System.Data.SqlDbType.Real, 4, "price6_odd_price"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_price_level", System.Data.SqlDbType.VarChar, 1, "price6_price_level"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@special_notice", System.Data.SqlDbType.VarChar, 300, "special_notice"))
        '
        'CmdUpdate
        '
        Me.CmdUpdate.CommandText = "UPDATE inv_price_code SET desc_price_code = @desc_price_code, price1_c_l_a_p = @p" & _
        "rice1_c_l_a_p, price1_operator = @price1_operator, price1_d_persent = @price1_d_" & _
        "persent, price1_amount = @price1_amount, price1_odd_price = @price1_odd_price, p" & _
        "rice1_price_level = @price1_price_level, price2_c_l_a_p = @price2_c_l_a_p, price" & _
        "2_operator = @price2_operator, price2_d_persent = @price2_d_persent, price2_amou" & _
        "nt = @price2_amount, price2_odd_price = @price2_odd_price, price2_price_level = " & _
        "@price2_price_level, price3_c_l_a_p = @price3_c_l_a_p, price3_operator = @price3" & _
        "_operator, price3_d_persent = @price3_d_persent, price3_amount = @price3_amount," & _
        " price3_odd_price = @price3_odd_price, price3_price_level = @price3_price_level," & _
        " price4_c_l_a_p = @price4_c_l_a_p, price4_operator = @price4_operator, price4_d_" & _
        "persent = @price4_d_persent, price4_amount = @price4_amount, price4_odd_price = " & _
        "@price4_odd_price, price4_price_level = @price4_price_level, price5_c_l_a_p = @p" & _
        "rice5_c_l_a_p, price5_operator = @price5_operator, price5_d_persent = @price5_d_" & _
        "persent, price5_amount = @price5_amount, price5_odd_price = @price5_odd_price, p" & _
        "rice5_price_level = @price5_price_level, price6_c_l_a_p = @price6_c_l_a_p, price" & _
        "6_operator = @price6_operator, price6_d_persent = @price6_d_persent, price6_amou" & _
        "nt = @price6_amount, price6_odd_price = @price6_odd_price, price6_price_level = " & _
        "@price6_price_level, special_notice = @special_notice WHERE (price_code = @price" & _
        "_code)"
        Me.CmdUpdate.Connection = Me.Cnn
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_price_code", System.Data.SqlDbType.VarChar, 50, "desc_price_code"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price1_c_l_a_p"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_operator", System.Data.SqlDbType.VarChar, 1, "price1_operator"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_d_persent", System.Data.SqlDbType.VarChar, 1, "price1_d_persent"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_amount", System.Data.SqlDbType.Real, 4, "price1_amount"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_odd_price", System.Data.SqlDbType.Real, 4, "price1_odd_price"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_price_level", System.Data.SqlDbType.VarChar, 1, "price1_price_level"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price2_c_l_a_p"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_operator", System.Data.SqlDbType.VarChar, 1, "price2_operator"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_d_persent", System.Data.SqlDbType.VarChar, 1, "price2_d_persent"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_amount", System.Data.SqlDbType.Real, 4, "price2_amount"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_odd_price", System.Data.SqlDbType.Real, 4, "price2_odd_price"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_price_level", System.Data.SqlDbType.VarChar, 1, "price2_price_level"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price3_c_l_a_p"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_operator", System.Data.SqlDbType.VarChar, 1, "price3_operator"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_d_persent", System.Data.SqlDbType.VarChar, 1, "price3_d_persent"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_amount", System.Data.SqlDbType.Real, 4, "price3_amount"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_odd_price", System.Data.SqlDbType.Real, 4, "price3_odd_price"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_price_level", System.Data.SqlDbType.VarChar, 1, "price3_price_level"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price4_c_l_a_p"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_operator", System.Data.SqlDbType.VarChar, 1, "price4_operator"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_d_persent", System.Data.SqlDbType.VarChar, 1, "price4_d_persent"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_amount", System.Data.SqlDbType.Real, 4, "price4_amount"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_odd_price", System.Data.SqlDbType.Real, 4, "price4_odd_price"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_price_level", System.Data.SqlDbType.VarChar, 1, "price4_price_level"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price5_c_l_a_p"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_operator", System.Data.SqlDbType.VarChar, 1, "price5_operator"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_d_persent", System.Data.SqlDbType.VarChar, 1, "price5_d_persent"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_amount", System.Data.SqlDbType.Real, 4, "price5_amount"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_odd_price", System.Data.SqlDbType.Real, 4, "price5_odd_price"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_price_level", System.Data.SqlDbType.VarChar, 1, "price5_price_level"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price6_c_l_a_p"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_operator", System.Data.SqlDbType.VarChar, 1, "price6_operator"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_d_persent", System.Data.SqlDbType.VarChar, 1, "price6_d_persent"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_amount", System.Data.SqlDbType.Real, 4, "price6_amount"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_odd_price", System.Data.SqlDbType.Real, 4, "price6_odd_price"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_price_level", System.Data.SqlDbType.VarChar, 1, "price6_price_level"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@special_notice", System.Data.SqlDbType.VarChar, 300, "special_notice"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_code", System.Data.DataRowVersion.Original, Nothing))
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Window
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label44)
        Me.Panel9.Controls.Add(Me.BtnSortOrder)
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
        Me.Panel9.Controls.Add(Me.Label53)
        Me.Panel9.Controls.Add(Me.Label54)
        Me.Panel9.Controls.Add(Me.Label55)
        Me.Panel9.Controls.Add(Me.BtnDelete)
        Me.Panel9.Controls.Add(Me.BtnNew)
        Me.Panel9.Controls.Add(Me.BtnFind)
        Me.Panel9.Controls.Add(Me.BtnNext)
        Me.Panel9.Controls.Add(Me.BtnPrev)
        Me.Panel9.Controls.Add(Me.BtnSave)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(616, 49)
        Me.Panel9.TabIndex = 2
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label44.Location = New System.Drawing.Point(499, 33)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(43, 11)
        Me.Label44.TabIndex = 196
        Me.Label44.Text = "Order"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSortOrder
        '
        Me.BtnSortOrder.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.DropDownButton
        Me.BtnSortOrder.DropDownContextMenu = Me.UiContextMenu1
        Me.BtnSortOrder.Image = CType(resources.GetObject("BtnSortOrder.Image"), System.Drawing.Image)
        Me.BtnSortOrder.ImageSize = New System.Drawing.Size(24, 24)
        Me.BtnSortOrder.Location = New System.Drawing.Point(497, 2)
        Me.BtnSortOrder.Name = "BtnSortOrder"
        Me.BtnSortOrder.Size = New System.Drawing.Size(49, 29)
        Me.BtnSortOrder.TabIndex = 195
        '
        'UiContextMenu1
        '
        Me.UiContextMenu1.CommandManager = Me.UiCommandManager1
        Me.UiContextMenu1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Sort11, Me.Sort21})
        Me.UiContextMenu1.Key = "ContextMenu1"
        Me.UiContextMenu1.UseThemes = Janus.Windows.UI.InheritableBoolean.True
        Me.UiContextMenu1.VisualStyle = Janus.Windows.UI.VisualStyle.Standard
        '
        'UiCommandManager1
        '
        Me.UiCommandManager1.BottomRebar = Me.BottomRebar1
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Sort1, Me.Sort2})
        Me.UiCommandManager1.ContainerControl = Me
        Me.UiCommandManager1.ContextMenus.AddRange(New Janus.Windows.UI.CommandBars.UIContextMenu() {Me.UiContextMenu1})
        Me.UiCommandManager1.Id = New System.Guid("c7d59a9c-3988-4b59-bfa8-7fc9b73a842e")
        Me.UiCommandManager1.LeftRebar = Me.LeftRebar1
        Me.UiCommandManager1.RightRebar = Me.RightRebar1
        Me.UiCommandManager1.TopRebar = Me.TopRebar1
        '
        'BottomRebar1
        '
        Me.BottomRebar1.CommandManager = Me.UiCommandManager1
        Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomRebar1.Location = New System.Drawing.Point(0, 0)
        Me.BottomRebar1.Name = "BottomRebar1"
        Me.BottomRebar1.TabIndex = 0
        '
        'Sort1
        '
        Me.Sort1.Key = "Sort1"
        Me.Sort1.Name = "Sort1"
        Me.Sort1.Text = "Order By Price Code"
        '
        'Sort2
        '
        Me.Sort2.Key = "Sort2"
        Me.Sort2.Name = "Sort2"
        Me.Sort2.Text = "Order By Price Description"
        '
        'LeftRebar1
        '
        Me.LeftRebar1.CommandManager = Me.UiCommandManager1
        Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftRebar1.Location = New System.Drawing.Point(0, 0)
        Me.LeftRebar1.Name = "LeftRebar1"
        Me.LeftRebar1.TabIndex = 0
        '
        'RightRebar1
        '
        Me.RightRebar1.CommandManager = Me.UiCommandManager1
        Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightRebar1.Location = New System.Drawing.Point(0, 0)
        Me.RightRebar1.Name = "RightRebar1"
        Me.RightRebar1.TabIndex = 0
        '
        'TopRebar1
        '
        Me.TopRebar1.CommandManager = Me.UiCommandManager1
        Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
        Me.TopRebar1.Name = "TopRebar1"
        Me.TopRebar1.TabIndex = 0
        '
        'Sort11
        '
        Me.Sort11.Key = "Sort1"
        Me.Sort11.Name = "Sort11"
        '
        'Sort21
        '
        Me.Sort21.Key = "Sort2"
        Me.Sort21.Name = "Sort21"
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Location = New System.Drawing.Point(6, 33)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(33, 11)
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
        Me.BtnFirst.Size = New System.Drawing.Size(33, 29)
        Me.BtnFirst.TabIndex = 191
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Location = New System.Drawing.Point(133, 33)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(33, 11)
        Me.Label41.TabIndex = 189
        Me.Label41.Text = "Last"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnLast
        '
        Me.BtnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLast.Image = CType(resources.GetObject("BtnLast.Image"), System.Drawing.Image)
        Me.BtnLast.Location = New System.Drawing.Point(132, 2)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(33, 29)
        Me.BtnLast.TabIndex = 188
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Location = New System.Drawing.Point(425, 33)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(40, 11)
        Me.Label42.TabIndex = 186
        Me.Label42.Text = "Cancel"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCancel
        '
        Me.BtnCancel.Enabled = False
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.Location = New System.Drawing.Point(428, 2)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(33, 29)
        Me.BtnCancel.TabIndex = 7
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Location = New System.Drawing.Point(303, 33)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(33, 11)
        Me.Label43.TabIndex = 184
        Me.Label43.Text = "Edit"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEdit
        '
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.Location = New System.Drawing.Point(300, 2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(33, 29)
        Me.BtnEdit.TabIndex = 4
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Location = New System.Drawing.Point(384, 33)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(33, 11)
        Me.Label50.TabIndex = 176
        Me.Label50.Text = "Save"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Location = New System.Drawing.Point(339, 33)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(38, 11)
        Me.Label51.TabIndex = 175
        Me.Label51.Text = "Delete"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Location = New System.Drawing.Point(259, 33)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(33, 11)
        Me.Label52.TabIndex = 174
        Me.Label52.Text = "New"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Location = New System.Drawing.Point(197, 33)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(33, 11)
        Me.Label53.TabIndex = 173
        Me.Label53.Text = "Find"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Location = New System.Drawing.Point(46, 33)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(33, 11)
        Me.Label54.TabIndex = 172
        Me.Label54.Text = "Prev"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Location = New System.Drawing.Point(91, 33)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(33, 11)
        Me.Label55.TabIndex = 171
        Me.Label55.Text = "Next"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnDelete
        '
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.Location = New System.Drawing.Point(342, 2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(33, 29)
        Me.BtnDelete.TabIndex = 5
        '
        'BtnNew
        '
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Location = New System.Drawing.Point(260, 2)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(33, 29)
        Me.BtnNew.TabIndex = 3
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(196, 2)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 29)
        Me.BtnFind.TabIndex = 2
        '
        'BtnNext
        '
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNext.Image = CType(resources.GetObject("BtnNext.Image"), System.Drawing.Image)
        Me.BtnNext.Location = New System.Drawing.Point(89, 2)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(33, 29)
        Me.BtnNext.TabIndex = 1
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.SystemColors.Window
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrev.Image = CType(resources.GetObject("BtnPrev.Image"), System.Drawing.Image)
        Me.BtnPrev.Location = New System.Drawing.Point(46, 2)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(33, 29)
        Me.BtnPrev.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(384, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 29)
        Me.BtnSave.TabIndex = 6
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
        Me.MAddNew.Text = "«ÌÃ«œ"
        '
        'MEdit
        '
        Me.MEdit.Index = 1
        Me.MEdit.Shortcut = System.Windows.Forms.Shortcut.CtrlE
        Me.MEdit.Text = "«’·«Õ"
        '
        'MDelete
        '
        Me.MDelete.Index = 2
        Me.MDelete.Shortcut = System.Windows.Forms.Shortcut.CtrlD
        Me.MDelete.Text = "Õ–›"
        '
        'MSave
        '
        Me.MSave.Enabled = False
        Me.MSave.Index = 3
        Me.MSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.MSave.Text = "À» "
        '
        'MCancel
        '
        Me.MCancel.Enabled = False
        Me.MCancel.Index = 4
        Me.MCancel.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MCancel.Text = "·€Ê"
        '
        'MFirstRecord
        '
        Me.MFirstRecord.Index = 5
        Me.MFirstRecord.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftV
        Me.MFirstRecord.Text = "«» œ«"
        '
        'MPreviousRecord
        '
        Me.MPreviousRecord.Index = 6
        Me.MPreviousRecord.Text = "ﬁ»·Ì"
        '
        'MNextRecord
        '
        Me.MNextRecord.Index = 7
        Me.MNextRecord.Text = "»⁄œÌ"
        '
        'MLastRecord
        '
        Me.MLastRecord.Index = 8
        Me.MLastRecord.Text = "«‰ Â«"
        '
        'CmdGeneralForReader
        '
        Me.CmdGeneralForReader.Connection = Me.CnnForReader
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT price_code, desc_price_code + ' - ' + price_code AS desc_price_code FROM i" & _
        "nv_price_code"
        Me.SqlSelectCommand1.Connection = Me.CnnTemp
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO inv_price_code(price_code, desc_price_code, price1_c_l_a_p, price1_op" & _
        "erator, price1_d_persent, price1_amount, price1_odd_price, price1_price_level, p" & _
        "rice2_c_l_a_p, price2_operator, price2_d_persent, price2_amount, price2_odd_pric" & _
        "e, price2_price_level, price3_c_l_a_p, price3_operator, price3_d_persent, price3" & _
        "_amount, price3_odd_price, price3_price_level, price4_c_l_a_p, price4_operator, " & _
        "price4_d_persent, price4_amount, price4_odd_price, price4_price_level, price5_c_" & _
        "l_a_p, price5_operator, price5_d_persent, price5_amount, price5_odd_price, price" & _
        "5_price_level, price6_c_l_a_p, price6_operator, price6_d_persent, price6_amount," & _
        " price6_odd_price, price6_price_level, special_notice) VALUES (@price_code, @des" & _
        "c_price_code, @price1_c_l_a_p, @price1_operator, @price1_d_persent, @price1_amou" & _
        "nt, @price1_odd_price, @price1_price_level, @price2_c_l_a_p, @price2_operator, @" & _
        "price2_d_persent, @price2_amount, @price2_odd_price, @price2_price_level, @price" & _
        "3_c_l_a_p, @price3_operator, @price3_d_persent, @price3_amount, @price3_odd_pric" & _
        "e, @price3_price_level, @price4_c_l_a_p, @price4_operator, @price4_d_persent, @p" & _
        "rice4_amount, @price4_odd_price, @price4_price_level, @price5_c_l_a_p, @price5_o" & _
        "perator, @price5_d_persent, @price5_amount, @price5_odd_price, @price5_price_lev" & _
        "el, @price6_c_l_a_p, @price6_operator, @price6_d_persent, @price6_amount, @price" & _
        "6_odd_price, @price6_price_level, @special_notice); SELECT price_code, desc_pric" & _
        "e_code, price1_c_l_a_p, price1_operator, price1_d_persent, price1_amount, price1" & _
        "_odd_price, price1_price_level, price2_c_l_a_p, price2_operator, price2_d_persen" & _
        "t, price2_amount, price2_odd_price, price2_price_level, price3_c_l_a_p, price3_o" & _
        "perator, price3_d_persent, price3_amount, price3_odd_price, price3_price_level, " & _
        "price4_c_l_a_p, price4_operator, price4_d_persent, price4_amount, price4_odd_pri" & _
        "ce, price4_price_level, price5_c_l_a_p, price5_operator, price5_d_persent, price" & _
        "5_amount, price5_odd_price, price5_price_level, price6_c_l_a_p, price6_operator," & _
        " price6_d_persent, price6_amount, price6_odd_price, price6_price_level, special_" & _
        "notice FROM inv_price_code WHERE (price_code = @price_code)"
        Me.SqlInsertCommand1.Connection = Me.CnnTemp
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_code", System.Data.SqlDbType.VarChar, 5, "price_code"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_price_code", System.Data.SqlDbType.VarChar, 50, "desc_price_code"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price1_c_l_a_p"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_operator", System.Data.SqlDbType.VarChar, 1, "price1_operator"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_d_persent", System.Data.SqlDbType.VarChar, 1, "price1_d_persent"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_amount", System.Data.SqlDbType.Real, 4, "price1_amount"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_odd_price", System.Data.SqlDbType.Real, 4, "price1_odd_price"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_price_level", System.Data.SqlDbType.VarChar, 1, "price1_price_level"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price2_c_l_a_p"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_operator", System.Data.SqlDbType.VarChar, 1, "price2_operator"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_d_persent", System.Data.SqlDbType.VarChar, 1, "price2_d_persent"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_amount", System.Data.SqlDbType.Real, 4, "price2_amount"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_odd_price", System.Data.SqlDbType.Real, 4, "price2_odd_price"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_price_level", System.Data.SqlDbType.VarChar, 1, "price2_price_level"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price3_c_l_a_p"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_operator", System.Data.SqlDbType.VarChar, 1, "price3_operator"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_d_persent", System.Data.SqlDbType.VarChar, 1, "price3_d_persent"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_amount", System.Data.SqlDbType.Real, 4, "price3_amount"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_odd_price", System.Data.SqlDbType.Real, 4, "price3_odd_price"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_price_level", System.Data.SqlDbType.VarChar, 1, "price3_price_level"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price4_c_l_a_p"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_operator", System.Data.SqlDbType.VarChar, 1, "price4_operator"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_d_persent", System.Data.SqlDbType.VarChar, 1, "price4_d_persent"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_amount", System.Data.SqlDbType.Real, 4, "price4_amount"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_odd_price", System.Data.SqlDbType.Real, 4, "price4_odd_price"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_price_level", System.Data.SqlDbType.VarChar, 1, "price4_price_level"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price5_c_l_a_p"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_operator", System.Data.SqlDbType.VarChar, 1, "price5_operator"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_d_persent", System.Data.SqlDbType.VarChar, 1, "price5_d_persent"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_amount", System.Data.SqlDbType.Real, 4, "price5_amount"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_odd_price", System.Data.SqlDbType.Real, 4, "price5_odd_price"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_price_level", System.Data.SqlDbType.VarChar, 1, "price5_price_level"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price6_c_l_a_p"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_operator", System.Data.SqlDbType.VarChar, 1, "price6_operator"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_d_persent", System.Data.SqlDbType.VarChar, 1, "price6_d_persent"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_amount", System.Data.SqlDbType.Real, 4, "price6_amount"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_odd_price", System.Data.SqlDbType.Real, 4, "price6_odd_price"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_price_level", System.Data.SqlDbType.VarChar, 1, "price6_price_level"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@special_notice", System.Data.SqlDbType.VarChar, 300, "special_notice"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE inv_price_code SET price_code = @price_code, desc_price_code = @desc_price" & _
        "_code, price1_c_l_a_p = @price1_c_l_a_p, price1_operator = @price1_operator, pri" & _
        "ce1_d_persent = @price1_d_persent, price1_amount = @price1_amount, price1_odd_pr" & _
        "ice = @price1_odd_price, price1_price_level = @price1_price_level, price2_c_l_a_" & _
        "p = @price2_c_l_a_p, price2_operator = @price2_operator, price2_d_persent = @pri" & _
        "ce2_d_persent, price2_amount = @price2_amount, price2_odd_price = @price2_odd_pr" & _
        "ice, price2_price_level = @price2_price_level, price3_c_l_a_p = @price3_c_l_a_p," & _
        " price3_operator = @price3_operator, price3_d_persent = @price3_d_persent, price" & _
        "3_amount = @price3_amount, price3_odd_price = @price3_odd_price, price3_price_le" & _
        "vel = @price3_price_level, price4_c_l_a_p = @price4_c_l_a_p, price4_operator = @" & _
        "price4_operator, price4_d_persent = @price4_d_persent, price4_amount = @price4_a" & _
        "mount, price4_odd_price = @price4_odd_price, price4_price_level = @price4_price_" & _
        "level, price5_c_l_a_p = @price5_c_l_a_p, price5_operator = @price5_operator, pri" & _
        "ce5_d_persent = @price5_d_persent, price5_amount = @price5_amount, price5_odd_pr" & _
        "ice = @price5_odd_price, price5_price_level = @price5_price_level, price6_c_l_a_" & _
        "p = @price6_c_l_a_p, price6_operator = @price6_operator, price6_d_persent = @pri" & _
        "ce6_d_persent, price6_amount = @price6_amount, price6_odd_price = @price6_odd_pr" & _
        "ice, price6_price_level = @price6_price_level, special_notice = @special_notice " & _
        "WHERE (price_code = @Original_price_code) AND (desc_price_code = @Original_desc_" & _
        "price_code OR @Original_desc_price_code IS NULL AND desc_price_code IS NULL) AND" & _
        " (price1_amount = @Original_price1_amount OR @Original_price1_amount IS NULL AND" & _
        " price1_amount IS NULL) AND (price1_c_l_a_p = @Original_price1_c_l_a_p OR @Origi" & _
        "nal_price1_c_l_a_p IS NULL AND price1_c_l_a_p IS NULL) AND (price1_d_persent = @" & _
        "Original_price1_d_persent OR @Original_price1_d_persent IS NULL AND price1_d_per" & _
        "sent IS NULL) AND (price1_odd_price = @Original_price1_odd_price OR @Original_pr" & _
        "ice1_odd_price IS NULL AND price1_odd_price IS NULL) AND (price1_operator = @Ori" & _
        "ginal_price1_operator OR @Original_price1_operator IS NULL AND price1_operator I" & _
        "S NULL) AND (price1_price_level = @Original_price1_price_level OR @Original_pric" & _
        "e1_price_level IS NULL AND price1_price_level IS NULL) AND (price2_amount = @Ori" & _
        "ginal_price2_amount OR @Original_price2_amount IS NULL AND price2_amount IS NULL" & _
        ") AND (price2_c_l_a_p = @Original_price2_c_l_a_p OR @Original_price2_c_l_a_p IS " & _
        "NULL AND price2_c_l_a_p IS NULL) AND (price2_d_persent = @Original_price2_d_pers" & _
        "ent OR @Original_price2_d_persent IS NULL AND price2_d_persent IS NULL) AND (pri" & _
        "ce2_odd_price = @Original_price2_odd_price OR @Original_price2_odd_price IS NULL" & _
        " AND price2_odd_price IS NULL) AND (price2_operator = @Original_price2_operator " & _
        "OR @Original_price2_operator IS NULL AND price2_operator IS NULL) AND (price2_pr" & _
        "ice_level = @Original_price2_price_level OR @Original_price2_price_level IS NULL" & _
        " AND price2_price_level IS NULL) AND (price3_amount = @Original_price3_amount OR" & _
        " @Original_price3_amount IS NULL AND price3_amount IS NULL) AND (price3_c_l_a_p " & _
        "= @Original_price3_c_l_a_p OR @Original_price3_c_l_a_p IS NULL AND price3_c_l_a_" & _
        "p IS NULL) AND (price3_d_persent = @Original_price3_d_persent OR @Original_price" & _
        "3_d_persent IS NULL AND price3_d_persent IS NULL) AND (price3_odd_price = @Origi" & _
        "nal_price3_odd_price OR @Original_price3_odd_price IS NULL AND price3_odd_price " & _
        "IS NULL) AND (price3_operator = @Original_price3_operator OR @Original_price3_op" & _
        "erator IS NULL AND price3_operator IS NULL) AND (price3_price_level = @Original_" & _
        "price3_price_level OR @Original_price3_price_level IS NULL AND price3_price_leve" & _
        "l IS NULL) AND (price4_amount = @Original_price4_amount OR @Original_price4_amou" & _
        "nt IS NULL AND price4_amount IS NULL) AND (price4_c_l_a_p = @Original_price4_c_l" & _
        "_a_p OR @Original_price4_c_l_a_p IS NULL AND price4_c_l_a_p IS NULL) AND (price4" & _
        "_d_persent = @Original_price4_d_persent OR @Original_price4_d_persent IS NULL AN" & _
        "D price4_d_persent IS NULL) AND (price4_odd_price = @Original_price4_odd_price O" & _
        "R @Original_price4_odd_price IS NULL AND price4_odd_price IS NULL) AND (price4_o" & _
        "perator = @Original_price4_operator OR @Original_price4_operator IS NULL AND pri" & _
        "ce4_operator IS NULL) AND (price4_price_level = @Original_price4_price_level OR " & _
        "@Original_price4_price_level IS NULL AND price4_price_level IS NULL) AND (price5" & _
        "_amount = @Original_price5_amount OR @Original_price5_amount IS NULL AND price5_" & _
        "amount IS NULL) AND (price5_c_l_a_p = @Original_price5_c_l_a_p OR @Original_pric" & _
        "e5_c_l_a_p IS NULL AND price5_c_l_a_p IS NULL) AND (price5_d_persent = @Original" & _
        "_price5_d_persent OR @Original_price5_d_persent IS NULL AND price5_d_persent IS " & _
        "NULL) AND (price5_odd_price = @Original_price5_odd_price OR @Original_price5_odd" & _
        "_price IS NULL AND price5_odd_price IS NULL) AND (price5_operator = @Original_pr" & _
        "ice5_operator OR @Original_price5_operator IS NULL AND price5_operator IS NULL) " & _
        "AND (price5_price_level = @Original_price5_price_level OR @Original_price5_price" & _
        "_level IS NULL AND price5_price_level IS NULL) AND (price6_amount = @Original_pr" & _
        "ice6_amount OR @Original_price6_amount IS NULL AND price6_amount IS NULL) AND (p" & _
        "rice6_c_l_a_p = @Original_price6_c_l_a_p OR @Original_price6_c_l_a_p IS NULL AND" & _
        " price6_c_l_a_p IS NULL) AND (price6_d_persent = @Original_price6_d_persent OR @" & _
        "Original_price6_d_persent IS NULL AND price6_d_persent IS NULL) AND (price6_odd_" & _
        "price = @Original_price6_odd_price OR @Original_price6_odd_price IS NULL AND pri" & _
        "ce6_odd_price IS NULL) AND (price6_operator = @Original_price6_operator OR @Orig" & _
        "inal_price6_operator IS NULL AND price6_operator IS NULL) AND (price6_price_leve" & _
        "l = @Original_price6_price_level OR @Original_price6_price_level IS NULL AND pri" & _
        "ce6_price_level IS NULL) AND (special_notice = @Original_special_notice OR @Orig" & _
        "inal_special_notice IS NULL AND special_notice IS NULL); SELECT price_code, desc" & _
        "_price_code, price1_c_l_a_p, price1_operator, price1_d_persent, price1_amount, p" & _
        "rice1_odd_price, price1_price_level, price2_c_l_a_p, price2_operator, price2_d_p" & _
        "ersent, price2_amount, price2_odd_price, price2_price_level, price3_c_l_a_p, pri" & _
        "ce3_operator, price3_d_persent, price3_amount, price3_odd_price, price3_price_le" & _
        "vel, price4_c_l_a_p, price4_operator, price4_d_persent, price4_amount, price4_od" & _
        "d_price, price4_price_level, price5_c_l_a_p, price5_operator, price5_d_persent, " & _
        "price5_amount, price5_odd_price, price5_price_level, price6_c_l_a_p, price6_oper" & _
        "ator, price6_d_persent, price6_amount, price6_odd_price, price6_price_level, spe" & _
        "cial_notice FROM inv_price_code WHERE (price_code = @price_code)"
        Me.SqlUpdateCommand1.Connection = Me.CnnTemp
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_code", System.Data.SqlDbType.VarChar, 5, "price_code"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_price_code", System.Data.SqlDbType.VarChar, 50, "desc_price_code"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price1_c_l_a_p"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_operator", System.Data.SqlDbType.VarChar, 1, "price1_operator"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_d_persent", System.Data.SqlDbType.VarChar, 1, "price1_d_persent"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_amount", System.Data.SqlDbType.Real, 4, "price1_amount"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_odd_price", System.Data.SqlDbType.Real, 4, "price1_odd_price"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price1_price_level", System.Data.SqlDbType.VarChar, 1, "price1_price_level"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price2_c_l_a_p"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_operator", System.Data.SqlDbType.VarChar, 1, "price2_operator"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_d_persent", System.Data.SqlDbType.VarChar, 1, "price2_d_persent"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_amount", System.Data.SqlDbType.Real, 4, "price2_amount"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_odd_price", System.Data.SqlDbType.Real, 4, "price2_odd_price"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price2_price_level", System.Data.SqlDbType.VarChar, 1, "price2_price_level"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price3_c_l_a_p"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_operator", System.Data.SqlDbType.VarChar, 1, "price3_operator"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_d_persent", System.Data.SqlDbType.VarChar, 1, "price3_d_persent"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_amount", System.Data.SqlDbType.Real, 4, "price3_amount"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_odd_price", System.Data.SqlDbType.Real, 4, "price3_odd_price"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price3_price_level", System.Data.SqlDbType.VarChar, 1, "price3_price_level"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price4_c_l_a_p"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_operator", System.Data.SqlDbType.VarChar, 1, "price4_operator"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_d_persent", System.Data.SqlDbType.VarChar, 1, "price4_d_persent"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_amount", System.Data.SqlDbType.Real, 4, "price4_amount"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_odd_price", System.Data.SqlDbType.Real, 4, "price4_odd_price"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price4_price_level", System.Data.SqlDbType.VarChar, 1, "price4_price_level"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price5_c_l_a_p"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_operator", System.Data.SqlDbType.VarChar, 1, "price5_operator"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_d_persent", System.Data.SqlDbType.VarChar, 1, "price5_d_persent"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_amount", System.Data.SqlDbType.Real, 4, "price5_amount"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_odd_price", System.Data.SqlDbType.Real, 4, "price5_odd_price"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price5_price_level", System.Data.SqlDbType.VarChar, 1, "price5_price_level"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_c_l_a_p", System.Data.SqlDbType.VarChar, 1, "price6_c_l_a_p"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_operator", System.Data.SqlDbType.VarChar, 1, "price6_operator"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_d_persent", System.Data.SqlDbType.VarChar, 1, "price6_d_persent"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_amount", System.Data.SqlDbType.Real, 4, "price6_amount"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_odd_price", System.Data.SqlDbType.Real, 4, "price6_odd_price"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price6_price_level", System.Data.SqlDbType.VarChar, 1, "price6_price_level"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@special_notice", System.Data.SqlDbType.VarChar, 300, "special_notice"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_price_code", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_price_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_special_notice", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "special_notice", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM inv_price_code WHERE (price_code = @Original_price_code) AND (desc_pr" & _
        "ice_code = @Original_desc_price_code OR @Original_desc_price_code IS NULL AND de" & _
        "sc_price_code IS NULL) AND (price1_amount = @Original_price1_amount OR @Original" & _
        "_price1_amount IS NULL AND price1_amount IS NULL) AND (price1_c_l_a_p = @Origina" & _
        "l_price1_c_l_a_p OR @Original_price1_c_l_a_p IS NULL AND price1_c_l_a_p IS NULL)" & _
        " AND (price1_d_persent = @Original_price1_d_persent OR @Original_price1_d_persen" & _
        "t IS NULL AND price1_d_persent IS NULL) AND (price1_odd_price = @Original_price1" & _
        "_odd_price OR @Original_price1_odd_price IS NULL AND price1_odd_price IS NULL) A" & _
        "ND (price1_operator = @Original_price1_operator OR @Original_price1_operator IS " & _
        "NULL AND price1_operator IS NULL) AND (price1_price_level = @Original_price1_pri" & _
        "ce_level OR @Original_price1_price_level IS NULL AND price1_price_level IS NULL)" & _
        " AND (price2_amount = @Original_price2_amount OR @Original_price2_amount IS NULL" & _
        " AND price2_amount IS NULL) AND (price2_c_l_a_p = @Original_price2_c_l_a_p OR @O" & _
        "riginal_price2_c_l_a_p IS NULL AND price2_c_l_a_p IS NULL) AND (price2_d_persent" & _
        " = @Original_price2_d_persent OR @Original_price2_d_persent IS NULL AND price2_d" & _
        "_persent IS NULL) AND (price2_odd_price = @Original_price2_odd_price OR @Origina" & _
        "l_price2_odd_price IS NULL AND price2_odd_price IS NULL) AND (price2_operator = " & _
        "@Original_price2_operator OR @Original_price2_operator IS NULL AND price2_operat" & _
        "or IS NULL) AND (price2_price_level = @Original_price2_price_level OR @Original_" & _
        "price2_price_level IS NULL AND price2_price_level IS NULL) AND (price3_amount = " & _
        "@Original_price3_amount OR @Original_price3_amount IS NULL AND price3_amount IS " & _
        "NULL) AND (price3_c_l_a_p = @Original_price3_c_l_a_p OR @Original_price3_c_l_a_p" & _
        " IS NULL AND price3_c_l_a_p IS NULL) AND (price3_d_persent = @Original_price3_d_" & _
        "persent OR @Original_price3_d_persent IS NULL AND price3_d_persent IS NULL) AND " & _
        "(price3_odd_price = @Original_price3_odd_price OR @Original_price3_odd_price IS " & _
        "NULL AND price3_odd_price IS NULL) AND (price3_operator = @Original_price3_opera" & _
        "tor OR @Original_price3_operator IS NULL AND price3_operator IS NULL) AND (price" & _
        "3_price_level = @Original_price3_price_level OR @Original_price3_price_level IS " & _
        "NULL AND price3_price_level IS NULL) AND (price4_amount = @Original_price4_amoun" & _
        "t OR @Original_price4_amount IS NULL AND price4_amount IS NULL) AND (price4_c_l_" & _
        "a_p = @Original_price4_c_l_a_p OR @Original_price4_c_l_a_p IS NULL AND price4_c_" & _
        "l_a_p IS NULL) AND (price4_d_persent = @Original_price4_d_persent OR @Original_p" & _
        "rice4_d_persent IS NULL AND price4_d_persent IS NULL) AND (price4_odd_price = @O" & _
        "riginal_price4_odd_price OR @Original_price4_odd_price IS NULL AND price4_odd_pr" & _
        "ice IS NULL) AND (price4_operator = @Original_price4_operator OR @Original_price" & _
        "4_operator IS NULL AND price4_operator IS NULL) AND (price4_price_level = @Origi" & _
        "nal_price4_price_level OR @Original_price4_price_level IS NULL AND price4_price_" & _
        "level IS NULL) AND (price5_amount = @Original_price5_amount OR @Original_price5_" & _
        "amount IS NULL AND price5_amount IS NULL) AND (price5_c_l_a_p = @Original_price5" & _
        "_c_l_a_p OR @Original_price5_c_l_a_p IS NULL AND price5_c_l_a_p IS NULL) AND (pr" & _
        "ice5_d_persent = @Original_price5_d_persent OR @Original_price5_d_persent IS NUL" & _
        "L AND price5_d_persent IS NULL) AND (price5_odd_price = @Original_price5_odd_pri" & _
        "ce OR @Original_price5_odd_price IS NULL AND price5_odd_price IS NULL) AND (pric" & _
        "e5_operator = @Original_price5_operator OR @Original_price5_operator IS NULL AND" & _
        " price5_operator IS NULL) AND (price5_price_level = @Original_price5_price_level" & _
        " OR @Original_price5_price_level IS NULL AND price5_price_level IS NULL) AND (pr" & _
        "ice6_amount = @Original_price6_amount OR @Original_price6_amount IS NULL AND pri" & _
        "ce6_amount IS NULL) AND (price6_c_l_a_p = @Original_price6_c_l_a_p OR @Original_" & _
        "price6_c_l_a_p IS NULL AND price6_c_l_a_p IS NULL) AND (price6_d_persent = @Orig" & _
        "inal_price6_d_persent OR @Original_price6_d_persent IS NULL AND price6_d_persent" & _
        " IS NULL) AND (price6_odd_price = @Original_price6_odd_price OR @Original_price6" & _
        "_odd_price IS NULL AND price6_odd_price IS NULL) AND (price6_operator = @Origina" & _
        "l_price6_operator OR @Original_price6_operator IS NULL AND price6_operator IS NU" & _
        "LL) AND (price6_price_level = @Original_price6_price_level OR @Original_price6_p" & _
        "rice_level IS NULL AND price6_price_level IS NULL) AND (special_notice = @Origin" & _
        "al_special_notice OR @Original_special_notice IS NULL AND special_notice IS NULL" & _
        ")"
        Me.SqlDeleteCommand1.Connection = Me.CnnTemp
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_price_code", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_price_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price1_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price1_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price2_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price2_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price3_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price3_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price4_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price4_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price5_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price5_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_amount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_c_l_a_p", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_c_l_a_p", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_d_persent", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_d_persent", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_odd_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_odd_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_operator", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_operator", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price6_price_level", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price6_price_level", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_special_notice", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "special_notice", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAInv_price_code
        '
        Me.DAInv_price_code.DeleteCommand = Me.SqlDeleteCommand1
        Me.DAInv_price_code.InsertCommand = Me.SqlInsertCommand1
        Me.DAInv_price_code.SelectCommand = Me.SqlSelectCommand1
        Me.DAInv_price_code.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_price_code", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("price_code", "price_code"), New System.Data.Common.DataColumnMapping("desc_price_code", "desc_price_code"), New System.Data.Common.DataColumnMapping("price1_c_l_a_p", "price1_c_l_a_p"), New System.Data.Common.DataColumnMapping("price1_operator", "price1_operator"), New System.Data.Common.DataColumnMapping("price1_d_persent", "price1_d_persent"), New System.Data.Common.DataColumnMapping("price1_amount", "price1_amount"), New System.Data.Common.DataColumnMapping("price1_odd_price", "price1_odd_price"), New System.Data.Common.DataColumnMapping("price1_price_level", "price1_price_level"), New System.Data.Common.DataColumnMapping("price2_c_l_a_p", "price2_c_l_a_p"), New System.Data.Common.DataColumnMapping("price2_operator", "price2_operator"), New System.Data.Common.DataColumnMapping("price2_d_persent", "price2_d_persent"), New System.Data.Common.DataColumnMapping("price2_amount", "price2_amount"), New System.Data.Common.DataColumnMapping("price2_odd_price", "price2_odd_price"), New System.Data.Common.DataColumnMapping("price2_price_level", "price2_price_level"), New System.Data.Common.DataColumnMapping("price3_c_l_a_p", "price3_c_l_a_p"), New System.Data.Common.DataColumnMapping("price3_operator", "price3_operator"), New System.Data.Common.DataColumnMapping("price3_d_persent", "price3_d_persent"), New System.Data.Common.DataColumnMapping("price3_amount", "price3_amount"), New System.Data.Common.DataColumnMapping("price3_odd_price", "price3_odd_price"), New System.Data.Common.DataColumnMapping("price3_price_level", "price3_price_level"), New System.Data.Common.DataColumnMapping("price4_c_l_a_p", "price4_c_l_a_p"), New System.Data.Common.DataColumnMapping("price4_operator", "price4_operator"), New System.Data.Common.DataColumnMapping("price4_d_persent", "price4_d_persent"), New System.Data.Common.DataColumnMapping("price4_amount", "price4_amount"), New System.Data.Common.DataColumnMapping("price4_odd_price", "price4_odd_price"), New System.Data.Common.DataColumnMapping("price4_price_level", "price4_price_level"), New System.Data.Common.DataColumnMapping("price5_c_l_a_p", "price5_c_l_a_p"), New System.Data.Common.DataColumnMapping("price5_operator", "price5_operator"), New System.Data.Common.DataColumnMapping("price5_d_persent", "price5_d_persent"), New System.Data.Common.DataColumnMapping("price5_amount", "price5_amount"), New System.Data.Common.DataColumnMapping("price5_odd_price", "price5_odd_price"), New System.Data.Common.DataColumnMapping("price5_price_level", "price5_price_level"), New System.Data.Common.DataColumnMapping("price6_c_l_a_p", "price6_c_l_a_p"), New System.Data.Common.DataColumnMapping("price6_operator", "price6_operator"), New System.Data.Common.DataColumnMapping("price6_d_persent", "price6_d_persent"), New System.Data.Common.DataColumnMapping("price6_amount", "price6_amount"), New System.Data.Common.DataColumnMapping("price6_odd_price", "price6_odd_price"), New System.Data.Common.DataColumnMapping("price6_price_level", "price6_price_level"), New System.Data.Common.DataColumnMapping("special_notice", "special_notice")})})
        Me.DAInv_price_code.UpdateCommand = Me.SqlUpdateCommand1
        '
        'FrmInv_Price_Code
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(616, 334)
        Me.Controls.Add(Me.PnlKartAmvalField)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel9)
        Me.Name = "FrmInv_Price_Code"
        Me.Text = "Inv Price Code Information"
        Me.PnlSearch.ResumeLayout(False)
        CType(Me.DsFrmInv_Price_Code1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlKartAmvalField.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(Me.UiContextMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1.EditContextMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmInv_Price_Code_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        Me.CnnTemp.ConnectionString = PConnectionString
        Me.CnnForReader.ConnectionString = PConnectionString

        PnlSearchHeight = PnlSearch.Height

        UiContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.True

        LblPrice1.Text = PriceLevelsLabels(1)
        LblPrice2.Text = PriceLevelsLabels(2)
        LblPrice3.Text = PriceLevelsLabels(3)
        LblPrice4.Text = PriceLevelsLabels(4)
        LblPrice5.Text = PriceLevelsLabels(5)
        LblPrice6.Text = PriceLevelsLabels(6)

        Call FillDataSets()
        TxtPrice_code.MaxLength = LenInv_Price_Code

        If PriceCodTempVar.Trim.Length = 0 Then
            Call PFirstRecord(False)
        Else
            CmbPrice_Code.SelectedValue = PriceCodTempVar
            Call FillFields(CmbPrice_Code.SelectedValue)
        End If
        Call AfterSaveOrCancel()
        CmbPrice_Code.Focus()
    End Sub
    Private Sub FillDataSets()
        DsFrmInv_Price_Code1.Clear()
        DAInv_price_code.Fill(DsFrmInv_Price_Code1.inv_price_code)
        DAInv_price_code.Fill(DsFrmInv_Price_Code1.inv_price_code1)
        DAInv_price_code.Fill(DsFrmInv_Price_Code1.inv_price_code2)
        CmbPrice_Code.Text = vbNullString
    End Sub
    Sub PAddNew()
        Status = MainModule.WorkStates.AddNew

        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()

        Call EnableField(True)
        PriceCodTempVar = CmbPrice_Code.SelectedValue
        CmbPrice_Code.Text = ""
        Call ClearField()

        TxtPrice_code.Focus()

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
        BtnSortOrder.Enabled = False
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
        PriceCodTempVar = CmbPrice_Code.SelectedValue
        TxtPrice_code.Focus()

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
        BtnSortOrder.Enabled = False
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
                CmdDelete.Parameters("@price_code").Value = CmbPrice_Code.SelectedValue
                CmdDelete.ExecuteNonQuery()
                Call FillDataSets()
                PriceCodTempVar = ""
                Call PNextRecord(False)
                If PriceCodTempVar.Trim.Length = 0 Then
                    Call PPreviousRecord(False)
                    If PriceCodTempVar.Trim.Length = 0 Then
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
            CmbPrice_Code.Focus()
        End If
        Status = MainModule.WorkStates._ReadOnly
    End Sub
    Private Function CheckSeqOfPrice_level() As Boolean
        CheckSeqOfPrice_level = True
        If CmbPrice1_c_l_a_p.Text.Trim.ToUpper = "P" Then
            PriceLevelSeqVar = CmbPrice1_price_level.Text.Trim
            Call PriceLevelValue(CmbPrice1_price_level.Text.Trim)
            If InStr(PriceLevelSeqVar, "1") Or PriceLevelSeqVar.Trim.Length > 6 Then
                CheckSeqOfPrice_level = False
                Exit Function
            End If
        End If
        If CmbPrice2_c_l_a_p.Text.Trim.ToUpper = "P" Then
            PriceLevelSeqVar = CmbPrice2_price_level.Text.Trim
            Call PriceLevelValue(CmbPrice2_price_level.Text.Trim)
            If InStr(PriceLevelSeqVar, "2") Or PriceLevelSeqVar.Trim.Length > 6 Then
                CheckSeqOfPrice_level = False
                Exit Function
            End If
        End If
        If CmbPrice3_c_l_a_p.Text.Trim.ToUpper = "P" Then
            PriceLevelSeqVar = CmbPrice3_price_level.Text.Trim
            Call PriceLevelValue(CmbPrice3_price_level.Text.Trim)
            If InStr(PriceLevelSeqVar, "3") Or PriceLevelSeqVar.Trim.Length > 6 Then
                CheckSeqOfPrice_level = False
                Exit Function
            End If
        End If
        If CmbPrice4_c_l_a_p.Text.Trim.ToUpper = "P" Then
            PriceLevelSeqVar = CmbPrice4_price_level.Text.Trim
            Call PriceLevelValue(CmbPrice4_price_level.Text.Trim)
            If InStr(PriceLevelSeqVar, "4") Or PriceLevelSeqVar.Trim.Length > 6 Then
                CheckSeqOfPrice_level = False
                Exit Function
            End If
        End If
        If CmbPrice5_c_l_a_p.Text.Trim.ToUpper = "P" Then
            PriceLevelSeqVar = CmbPrice5_price_level.Text.Trim
            Call PriceLevelValue(CmbPrice5_price_level.Text.Trim)
            If InStr(PriceLevelSeqVar, "5") Or PriceLevelSeqVar.Trim.Length > 6 Then
                CheckSeqOfPrice_level = False
                Exit Function
            End If
        End If
        If CmbPrice6_c_l_a_p.Text.Trim.ToUpper = "P" Then
            PriceLevelSeqVar = CmbPrice6_price_level.Text.Trim
            Call PriceLevelValue(CmbPrice6_price_level.Text.Trim)
            If InStr(PriceLevelSeqVar, "6") Or PriceLevelSeqVar.Trim.Length > 6 Then
                CheckSeqOfPrice_level = False
                Exit Function
            End If
        End If
        'Dim SeqVar(6) As String
        'Dim i As Integer
        'For i = 1 To 6
        '    SeqVar(i) = ""
        'Next
        'CheckSeqOfPrice_level = True
        'If CmbPrice1_c_l_a_p.Text.Trim.ToUpper = "P" Then
        '    PriceLevelSeqVar = CmbPrice1_price_level.Text.Trim
        '    Call PriceLevelValue(CmbPrice1_price_level.Text.Trim)
        '    SeqVar(1) = PriceLevelSeqVar

        'End If
        'If CmbPrice2_c_l_a_p.Text.Trim.ToUpper = "P" Then
        '    PriceLevelSeqVar = CmbPrice2_price_level.Text.Trim
        '    Call PriceLevelValue(CmbPrice2_price_level.Text.Trim)
        '    SeqVar(2) = PriceLevelSeqVar
        'End If
        'If CmbPrice3_c_l_a_p.Text.Trim.ToUpper = "P" Then
        '    PriceLevelSeqVar = CmbPrice3_price_level.Text.Trim
        '    Call PriceLevelValue(CmbPrice3_price_level.Text.Trim)
        '    SeqVar(3) = PriceLevelSeqVar
        'End If
        'If CmbPrice4_c_l_a_p.Text.Trim.ToUpper = "P" Then
        '    PriceLevelSeqVar = CmbPrice4_price_level.Text.Trim
        '    Call PriceLevelValue(CmbPrice4_price_level.Text.Trim)
        '    SeqVar(4) = PriceLevelSeqVar
        'End If
        'If CmbPrice5_c_l_a_p.Text.Trim.ToUpper = "P" Then
        '    PriceLevelSeqVar = CmbPrice5_price_level.Text.Trim
        '    Call PriceLevelValue(CmbPrice5_price_level.Text.Trim)
        '    SeqVar(5) = PriceLevelSeqVar
        'End If
        'If CmbPrice6_c_l_a_p.Text.Trim.ToUpper = "P" Then
        '    PriceLevelSeqVar = CmbPrice6_price_level.Text.Trim
        '    Call PriceLevelValue(CmbPrice6_price_level.Text.Trim)
        '    SeqVar(6) = PriceLevelSeqVar
        'End If
    End Function
    Private Sub PriceLevelValue(ByVal InStr As String)
        If PriceLevelSeqVar.Trim.Length > 6 Then
            Exit Sub
        End If
        Select Case InStr
            Case "1"
                If CmbPrice1_c_l_a_p.Text.Trim.ToUpper = "P" Then
                    PriceLevelSeqVar = PriceLevelSeqVar & CmbPrice1_price_level.Text.Trim
                    Call PriceLevelValue(CmbPrice1_price_level.Text.Trim)
                End If
            Case "2"
                If CmbPrice2_c_l_a_p.Text.Trim.ToUpper = "P" Then
                    PriceLevelSeqVar = PriceLevelSeqVar & CmbPrice2_price_level.Text.Trim
                    Call PriceLevelValue(CmbPrice2_price_level.Text.Trim)
                End If
            Case "3"
                If CmbPrice3_c_l_a_p.Text.Trim.ToUpper = "P" Then
                    PriceLevelSeqVar = PriceLevelSeqVar & CmbPrice3_price_level.Text.Trim
                    Call PriceLevelValue(CmbPrice3_price_level.Text.Trim)
                End If
            Case "4"
                If CmbPrice4_c_l_a_p.Text.Trim.ToUpper = "P" Then
                    PriceLevelSeqVar = PriceLevelSeqVar & CmbPrice4_price_level.Text.Trim
                    Call PriceLevelValue(CmbPrice4_price_level.Text.Trim)
                End If
            Case "5"
                If CmbPrice5_c_l_a_p.Text.Trim.ToUpper = "P" Then
                    PriceLevelSeqVar = PriceLevelSeqVar & CmbPrice5_price_level.Text.Trim
                    Call PriceLevelValue(CmbPrice5_price_level.Text.Trim)
                End If
            Case "6"
                If CmbPrice6_c_l_a_p.Text.Trim.ToUpper = "P" Then
                    PriceLevelSeqVar = PriceLevelSeqVar & CmbPrice6_price_level.Text.Trim
                    Call PriceLevelValue(CmbPrice6_price_level.Text.Trim)
                End If
        End Select
    End Sub
    Sub PSave()
        Dim ChangeOK As Boolean = False
        If CheckSeqOfPrice_level() = False Then
            MsgBox("Please Verify the sequence of Price Level.Circular Reference")
            Exit Sub
        End If
        Select Case Status
            Case MainModule.WorkStates.AddNew
                PriceCodTempVar = PInsert()
                ChangeOK = IIf(PriceCodTempVar.Trim.Length = 0, False, True)
            Case MainModule.WorkStates.Edit
                Dim thisrow As DataRow, ThisPosition As Integer
                ChangeOK = PUpdate(PriceCodTempVar)
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

            CmbPrice_Code.SelectedValue = PriceCodTempVar
            CmbPrice_Code.Focus()
        End If
    End Sub
    Sub PCancel()
        Status = MainModule.WorkStates._ReadOnly
        'PnlSearch.Visible = True
        Call ShowFilterProcPanel()

        CmbPrice_Code.SelectedValue = PriceCodTempVar
        Call FillFields(CmbPrice_Code.SelectedValue)
        Call AfterSaveOrCancel()
        CmbPrice_Code.Focus()
    End Sub
    Sub AfterSaveOrCancel()
        MSave.Enabled = False
        BtnSave.Enabled = False
        MCancel.Enabled = False
        BtnCancel.Enabled = False
        BtnNew.Enabled = True
        MAddNew.Enabled = True
        If TxtPrice_code.Text.Trim.Length = 0 Then
            BtnDelete.Enabled = False
            MDelete.Enabled = False
            BtnEdit.Enabled = False
            MEdit.Enabled = False
            BtnPrev.Enabled = False
            BtnNext.Enabled = False
            BtnFirst.Enabled = False
            BtnLast.Enabled = False
            BtnSortOrder.Enabled = False
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
            BtnSortOrder.Enabled = True
            MPreviousRecord.Enabled = True
            MNextRecord.Enabled = True
            MFirstRecord.Enabled = True
            MLastRecord.Enabled = True
        End If
        Call EnableField(False)
    End Sub
    Private Sub MAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call PAddNew()
    End Sub
    Private Sub MEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call PEdit()
    End Sub
    Private Sub MDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call PDelete()
    End Sub
    Private Sub MSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call PSave()
    End Sub
    Private Sub MCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call PCancel()
    End Sub
    Private Sub TxtPrice_code_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPrice_code.TextChanged, TxtDesc_price_code.TextChanged, CmbPrice1_D_persent.SelectedIndexChanged, CmbPrice1_operator.SelectedIndexChanged, CmbPrice1_price_level.SelectedIndexChanged, NumPrice1_Amount.TextChanged, NumPrice1_odd_price.TextChanged, CmbPrice2_D_persent.SelectedIndexChanged, CmbPrice2_operator.SelectedIndexChanged, CmbPrice2_price_level.SelectedIndexChanged, NumPrice2_Amount.TextChanged, NumPrice2_odd_price.TextChanged, CmbPrice3_D_persent.SelectedIndexChanged, CmbPrice3_operator.SelectedIndexChanged, CmbPrice3_price_level.SelectedIndexChanged, NumPrice3_Amount.TextChanged, NumPrice3_odd_price.TextChanged, CmbPrice4_D_persent.SelectedIndexChanged, CmbPrice4_operator.SelectedIndexChanged, CmbPrice4_price_level.SelectedIndexChanged, NumPrice4_Amount.TextChanged, NumPrice4_odd_price.TextChanged, CmbPrice5_D_persent.SelectedIndexChanged, CmbPrice5_operator.SelectedIndexChanged, CmbPrice5_price_level.SelectedIndexChanged, NumPrice5_Amount.TextChanged, NumPrice5_odd_price.TextChanged, CmbPrice6_D_persent.SelectedIndexChanged, CmbPrice6_operator.SelectedIndexChanged, CmbPrice6_price_level.SelectedIndexChanged, NumPrice6_Amount.TextChanged, NumPrice6_odd_price.TextChanged
        Call SaveButtonControl()
    End Sub
    Private Function CheckValidityOfInformation() As Boolean
        CheckValidityOfInformation = True
        If CmbPrice1_c_l_a_p.Text = "P" Then
            If Trim(CmbPrice1_price_level.Text).Length = 0 Then
                CheckValidityOfInformation = False
                Exit Function
            End If
        Else
            'If Trim(CmbPrice1_D_persent.Text).Length = 0 Or Trim(CmbPrice1_operator.Text).Length = 0 Or Val(NumPrice1_Amount.Text) = 0 Or Val(NumPrice1_odd_price.Text) = 0 Then
            If Trim(CmbPrice1_D_persent.Text).Length = 0 Or Trim(CmbPrice1_operator.Text).Length = 0 Then
                CheckValidityOfInformation = False
                Exit Function
            End If
        End If
        If CmbPrice2_c_l_a_p.Text = "P" Then
            If Trim(CmbPrice2_price_level.Text).Length = 0 Then
                CheckValidityOfInformation = False
                Exit Function
            End If
        Else
            'If Trim(CmbPrice2_D_persent.Text).Length = 0 Or Trim(CmbPrice2_operator.Text).Length = 0 Or Val(NumPrice2_Amount.Text) = 0 Or Val(NumPrice2_odd_price.Text) = 0 Then
            If Trim(CmbPrice2_D_persent.Text).Length = 0 Or Trim(CmbPrice2_operator.Text).Length = 0 Then
                CheckValidityOfInformation = False
                Exit Function
            End If
        End If
        If CmbPrice3_c_l_a_p.Text = "P" Then
            If Trim(CmbPrice3_price_level.Text).Length = 0 Then
                CheckValidityOfInformation = False
                Exit Function
            End If
        Else
            'If Trim(CmbPrice3_D_persent.Text).Length = 0 Or Trim(CmbPrice3_operator.Text).Length = 0 Or Val(NumPrice3_Amount.Text) = 0 Or Val(NumPrice3_odd_price.Text) = 0 Then
            If Trim(CmbPrice3_D_persent.Text).Length = 0 Or Trim(CmbPrice3_operator.Text).Length = 0 Then
                CheckValidityOfInformation = False
                Exit Function
            End If
        End If
        If CmbPrice4_c_l_a_p.Text = "P" Then
            If Trim(CmbPrice4_price_level.Text).Length = 0 Then
                CheckValidityOfInformation = False
                Exit Function
            End If
        Else
            'If Trim(CmbPrice4_D_persent.Text).Length = 0 Or Trim(CmbPrice4_operator.Text).Length = 0 Or Val(NumPrice4_Amount.Text) = 0 Or Val(NumPrice4_odd_price.Text) = 0 Then
            If Trim(CmbPrice4_D_persent.Text).Length = 0 Or Trim(CmbPrice4_operator.Text).Length = 0 Then
                CheckValidityOfInformation = False
                Exit Function
            End If
        End If
        If CmbPrice5_c_l_a_p.Text = "P" Then
            If Trim(CmbPrice5_price_level.Text).Length = 0 Then
                CheckValidityOfInformation = False
                Exit Function
            End If
        Else
            'If Trim(CmbPrice5_D_persent.Text).Length = 0 Or Trim(CmbPrice5_operator.Text).Length = 0 Or Val(NumPrice5_Amount.Text) = 0 Or Val(NumPrice5_odd_price.Text) = 0 Then
            If Trim(CmbPrice5_D_persent.Text).Length = 0 Or Trim(CmbPrice5_operator.Text).Length = 0 Then
                CheckValidityOfInformation = False
                Exit Function
            End If
        End If
        If CmbPrice6_c_l_a_p.Text = "P" Then
            If Trim(CmbPrice6_price_level.Text).Length = 0 Then
                CheckValidityOfInformation = False
                Exit Function
            End If
        Else
            'If Trim(CmbPrice6_D_persent.Text).Length = 0 Or Trim(CmbPrice6_operator.Text).Length = 0 Or Val(NumPrice6_Amount.Text) = 0 Or Val(NumPrice6_odd_price.Text) = 0 Then
            If Trim(CmbPrice6_D_persent.Text).Length = 0 Or Trim(CmbPrice6_operator.Text).Length = 0 Then
                CheckValidityOfInformation = False
                Exit Function
            End If
        End If
    End Function
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
            If TxtPrice_code.Text.Trim.Length > 0 And TxtDesc_price_code.Text.Trim.Length > 0 And CheckValidityOfInformation() Then
                BtnSave.Enabled = True
                MSave.Enabled = True
            Else
                BtnSave.Enabled = False
                MSave.Enabled = False
            End If
        End If
    End Sub
    Private Sub MFirstRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call PFirstRecord()
    End Sub
    Private Sub MPreviousRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call PPreviousRecord()
    End Sub
    Private Sub MNextRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call PNextRecord()
    End Sub
    Private Sub MLastRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call PLastRecord()
    End Sub
    Private Sub PFirstRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Try
            Dim TXTSearchPriceCodTemp As String
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT Top 1 price_code from inv_price_code Order BY " & InvPrice_CodeOrderFieldName & " ASC"
            TXTSearchPriceCodTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.Connection.Close()
            If IsNothing(TXTSearchPriceCodTemp) Then
                TXTSearchPriceCodTemp = ""
            End If
            If TXTSearchPriceCodTemp = CmbPrice_Code.SelectedValue Or TXTSearchPriceCodTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the First record of this table.")
            Else
                CmbPrice_Code.SelectedValue = TXTSearchPriceCodTemp
                Call FillFields(CmbPrice_Code.SelectedValue)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PPreviousRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchPriceCodTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Select Case InvPrice_CodeOrderFieldName.ToUpper.Trim
            Case "price_code".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 price_code from inv_price_code where price_code<" & Qt(TxtPrice_code.Text) & " Order BY " & InvPrice_CodeOrderFieldName & " DESC"
            Case "desc_price_code".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 price_code from inv_price_code where desc_price_code<" & Qt(TxtDesc_price_code.Text) & " Order BY " & InvPrice_CodeOrderFieldName & " DESC"
        End Select
        TXTSearchPriceCodTemp = CmdGeneral.ExecuteScalar()
        CmdGeneral.Connection.Close()
        If IsNothing(TXTSearchPriceCodTemp) Then
            TXTSearchPriceCodTemp = ""
        End If
        If TXTSearchPriceCodTemp = CmbPrice_Code.SelectedValue Or TXTSearchPriceCodTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the First record of this table.")
        Else
            CmbPrice_Code.SelectedValue = TXTSearchPriceCodTemp
            PriceCodTempVar = TXTSearchPriceCodTemp
            Call FillFields(CmbPrice_Code.SelectedValue)
        End If
    End Sub
    Private Sub PNextRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchPriceCodTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Select Case InvPrice_CodeOrderFieldName.ToUpper.Trim
            Case "price_code".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 price_code from inv_price_code where price_code>" & Qt(TxtPrice_code.Text) & " Order BY " & InvPrice_CodeOrderFieldName & " ASC"
            Case "desc_price_code".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 price_code from inv_price_code where desc_price_code>" & Qt(TxtDesc_price_code.Text) & " Order BY " & InvPrice_CodeOrderFieldName & " ASC"
        End Select
        TXTSearchPriceCodTemp = CmdGeneral.ExecuteScalar()
        CmdGeneral.Connection.Close()
        If IsNothing(TXTSearchPriceCodTemp) Then
            TXTSearchPriceCodTemp = ""
        End If
        If TXTSearchPriceCodTemp = CmbPrice_Code.SelectedValue Or TXTSearchPriceCodTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            CmbPrice_Code.SelectedValue = TXTSearchPriceCodTemp
            PriceCodTempVar = TXTSearchPriceCodTemp
            Call FillFields(CmbPrice_Code.SelectedValue)
        End If
    End Sub
    Private Sub PLastRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Try
            Dim TXTSearchPriceCodTemp As String
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT Top 1 price_code from inv_price_code Order BY " & InvPrice_CodeOrderFieldName & " DESC"
            TXTSearchPriceCodTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.Connection.Close()
            If IsNothing(TXTSearchPriceCodTemp) Then
                TXTSearchPriceCodTemp = ""
            End If
            If TXTSearchPriceCodTemp = CmbPrice_Code.SelectedValue Or TXTSearchPriceCodTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the Last record of this table.")
            Else
                CmbPrice_Code.SelectedValue = TXTSearchPriceCodTemp
                Call FillFields(CmbPrice_Code.SelectedValue)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CmbPrice_Code_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbPrice_Code.SelectionChangeCommitted
        Call FillFields(CmbPrice_Code.SelectedValue)
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
        BtnSortOrder.Enabled = False
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
            '                    PanelSearch.Visible = Not PanelSearch.Visible
        End Try
        'Me.Height = Me.Height - (k * PnlSearchHeight)
        If PnlSearch.Height <> 0 Then
            'GRDFWG.Height = PanelKartabl.Height - SBKartabl.Height
            CmbPrice_Code.Focus()
        Else
            'GRDFWG.Height = GRDFWG.Height + PnlSearchHeight
        End If
    End Sub
    Private Sub PPrintMasterInformation()
        'If CmbPrice_Code.SelectedValue > 0 Then
        '    Dim Orpt As New RptInspectionMasterInformation
        '    DsFrmInspectionMaster1.Clear()
        '    DAInspectionMaster.SelectCommand.Parameters("@price_code").Value = CmbPrice_Code.SelectedValue
        '    DAInspectionMaster.Fill(DsFrmInspectionMaster1, "InspectionMaster")
        '    Prn = New FrmRepView
        '    Prn.MdiParent = PubMFrmMain
        '    Orpt.SetParameterValue("CompanyName", PubCompanyName)
        '    Orpt.SetDataSource(DsFrmInspectionMaster1)
        '    Prn.CrViewer.ReportSource = Orpt
        '    Prn.Show()
        'End If
    End Sub
    Friend Sub EnableField(ByVal instatus As Boolean)
        'For Each Ctl As Control In Me.Controls
        '    If TypeOf (Ctl) Is TextBox Then
        '        Ctl.Enabled = instatus
        '    ElseIf TypeOf (Ctl) Is ComboBox Then
        '        Ctl.Enabled = instatus
        '    End If
        'Next
        If Status = MainModule.WorkStates.AddNew Then
            TxtPrice_code.Enabled = instatus
        Else
            TxtPrice_code.Enabled = False
        End If

        Chkodd_priceFlag1.Enabled = instatus
        Chkodd_priceFlag2.Enabled = instatus
        Chkodd_priceFlag3.Enabled = instatus
        Chkodd_priceFlag4.Enabled = instatus
        Chkodd_priceFlag5.Enabled = instatus
        Chkodd_priceFlag6.Enabled = instatus

        TxtDesc_price_code.Enabled = instatus
        CmbPrice1_c_l_a_p.Enabled = instatus
        CmbPrice1_operator.Enabled = instatus
        CmbPrice1_D_persent.Enabled = instatus
        NumPrice1_Amount.Enabled = instatus
        NumPrice1_odd_price.Enabled = (Not Chkodd_priceFlag1.Checked) And Chkodd_priceFlag1.Enabled
        CmbPrice1_price_level.Enabled = instatus
        CmbPrice2_c_l_a_p.Enabled = instatus
        CmbPrice2_operator.Enabled = instatus
        CmbPrice2_D_persent.Enabled = instatus
        NumPrice2_Amount.Enabled = instatus
        NumPrice2_odd_price.Enabled = (Not Chkodd_priceFlag2.Checked) And Chkodd_priceFlag2.Enabled
        CmbPrice2_price_level.Enabled = instatus
        CmbPrice3_c_l_a_p.Enabled = instatus
        CmbPrice3_operator.Enabled = instatus
        CmbPrice3_D_persent.Enabled = instatus
        NumPrice3_Amount.Enabled = instatus
        NumPrice3_odd_price.Enabled = (Not Chkodd_priceFlag3.Checked) And Chkodd_priceFlag3.Enabled
        CmbPrice3_price_level.Enabled = instatus
        CmbPrice4_c_l_a_p.Enabled = instatus
        CmbPrice4_operator.Enabled = instatus
        CmbPrice4_D_persent.Enabled = instatus
        NumPrice4_Amount.Enabled = instatus
        NumPrice4_odd_price.Enabled = (Not Chkodd_priceFlag4.Checked) And Chkodd_priceFlag4.Enabled
        CmbPrice4_price_level.Enabled = instatus
        CmbPrice5_c_l_a_p.Enabled = instatus
        CmbPrice5_operator.Enabled = instatus
        CmbPrice5_D_persent.Enabled = instatus
        NumPrice5_Amount.Enabled = instatus
        NumPrice5_odd_price.Enabled = (Not Chkodd_priceFlag5.Checked) And Chkodd_priceFlag5.Enabled
        CmbPrice5_price_level.Enabled = instatus
        CmbPrice6_c_l_a_p.Enabled = instatus
        CmbPrice6_operator.Enabled = instatus
        CmbPrice6_D_persent.Enabled = instatus
        NumPrice6_Amount.Enabled = instatus
        NumPrice6_odd_price.Enabled = (Not Chkodd_priceFlag6.Checked) And Chkodd_priceFlag6.Enabled
        CmbPrice6_price_level.Enabled = instatus

        Call CmbPrice_c_l_a_pDisableEnable()
    End Sub
    Friend Sub ClearField()
        'For Each Ctl As Control In Me.Controls
        '    If TypeOf (Ctl) Is TextBox Then
        '        Ctl.Text = ""
        '    ElseIf TypeOf (Ctl) Is ComboBox Then
        '        CType(Ctl, ComboBox).text = 0
        '    End If
        'Next
        TxtPrice_code.Text = ""
        TxtDesc_price_code.Text = ""
        CmbPrice1_c_l_a_p.Text = ""
        CmbPrice1_operator.Text = ""
        CmbPrice1_D_persent.Text = ""
        NumPrice1_Amount.Text = 0
        NumPrice1_odd_price.Text = 0
        CmbPrice1_price_level.Text = ""
        CmbPrice2_c_l_a_p.Text = ""
        CmbPrice2_operator.Text = ""
        CmbPrice2_D_persent.Text = ""
        NumPrice2_Amount.Text = 0
        NumPrice2_odd_price.Text = 0
        CmbPrice2_price_level.Text = ""
        CmbPrice3_c_l_a_p.Text = ""
        CmbPrice3_operator.Text = ""
        CmbPrice3_D_persent.Text = ""
        NumPrice3_Amount.Text = 0
        NumPrice3_odd_price.Text = 0
        CmbPrice3_price_level.Text = ""
        CmbPrice4_c_l_a_p.Text = ""
        CmbPrice4_operator.Text = ""
        CmbPrice4_D_persent.Text = ""
        NumPrice4_Amount.Text = 0
        NumPrice4_odd_price.Text = 0
        CmbPrice4_price_level.Text = ""
        CmbPrice5_c_l_a_p.Text = ""
        CmbPrice5_operator.Text = ""
        CmbPrice5_D_persent.Text = ""
        NumPrice5_Amount.Text = 0
        NumPrice5_odd_price.Text = 0
        CmbPrice5_price_level.Text = ""
        CmbPrice6_c_l_a_p.Text = ""
        CmbPrice6_operator.Text = ""
        CmbPrice6_D_persent.Text = ""
        NumPrice6_Amount.Text = 0
        NumPrice6_odd_price.Text = 0
        CmbPrice6_price_level.Text = ""
        Inv_Price_NoteVar = ""

        Chkodd_priceFlag1.Checked = False
        Chkodd_priceFlag2.Checked = False
        Chkodd_priceFlag3.Checked = False
        Chkodd_priceFlag4.Checked = False
        Chkodd_priceFlag5.Checked = False
        Chkodd_priceFlag6.Checked = False

    End Sub
    Friend Function PInsert() As String
        Dim thisrow As DataRow
        PInsert = ""
        Try
            With CmdInsert
                If .Connection.State <> ConnectionState.Open Then
                    .Connection.Open()
                End If
                .Parameters("@price_code").Value = TxtPrice_code.Text
                .Parameters("@Desc_price_code").Value = TxtDesc_price_code.Text
                .Parameters("@price1_c_l_a_p").Value = CmbPrice1_c_l_a_p.Text
                .Parameters("@price1_operator").Value = CmbPrice1_operator.Text
                .Parameters("@price1_d_persent").Value = CmbPrice1_D_persent.Text
                .Parameters("@price1_amount").Value = NumPrice1_Amount.Text
                .Parameters("@price1_odd_price").Value = IIf(Chkodd_priceFlag1.Checked, -1, NumPrice1_odd_price.Text)
                .Parameters("@price1_price_level").Value = CmbPrice1_price_level.Text
                .Parameters("@price2_c_l_a_p").Value = CmbPrice2_c_l_a_p.Text
                .Parameters("@price2_operator").Value = CmbPrice2_operator.Text
                .Parameters("@price2_d_persent").Value = CmbPrice2_D_persent.Text
                .Parameters("@price2_amount").Value = NumPrice2_Amount.Text
                .Parameters("@price2_odd_price").Value = IIf(Chkodd_priceFlag2.Checked, -1, NumPrice2_odd_price.Text)
                .Parameters("@price2_price_level").Value = CmbPrice2_price_level.Text
                .Parameters("@price3_c_l_a_p").Value = CmbPrice3_c_l_a_p.Text
                .Parameters("@price3_operator").Value = CmbPrice3_operator.Text
                .Parameters("@price3_d_persent").Value = CmbPrice3_D_persent.Text
                .Parameters("@price3_amount").Value = NumPrice3_Amount.Text
                .Parameters("@price3_odd_price").Value = IIf(Chkodd_priceFlag3.Checked, -1, NumPrice3_odd_price.Text)
                .Parameters("@price3_price_level").Value = CmbPrice3_price_level.Text
                .Parameters("@price4_c_l_a_p").Value = CmbPrice4_c_l_a_p.Text
                .Parameters("@price4_operator").Value = CmbPrice4_operator.Text
                .Parameters("@price4_d_persent").Value = CmbPrice4_D_persent.Text
                .Parameters("@price4_amount").Value = NumPrice4_Amount.Text
                .Parameters("@price4_odd_price").Value = IIf(Chkodd_priceFlag4.Checked, -1, NumPrice4_odd_price.Text)
                .Parameters("@price4_price_level").Value = CmbPrice4_price_level.Text
                .Parameters("@price5_c_l_a_p").Value = CmbPrice5_c_l_a_p.Text
                .Parameters("@price5_operator").Value = CmbPrice5_operator.Text
                .Parameters("@price5_d_persent").Value = CmbPrice5_D_persent.Text
                .Parameters("@price5_amount").Value = NumPrice5_Amount.Text
                .Parameters("@price5_odd_price").Value = IIf(Chkodd_priceFlag5.Checked, -1, NumPrice5_odd_price.Text)
                .Parameters("@price5_price_level").Value = CmbPrice5_price_level.Text
                .Parameters("@price6_c_l_a_p").Value = CmbPrice6_c_l_a_p.Text
                .Parameters("@price6_operator").Value = CmbPrice6_operator.Text
                .Parameters("@price6_d_persent").Value = CmbPrice6_D_persent.Text
                .Parameters("@price6_amount").Value = NumPrice6_Amount.Text
                .Parameters("@price6_odd_price").Value = IIf(Chkodd_priceFlag6.Checked, -1, NumPrice6_odd_price.Text)
                .Parameters("@price6_price_level").Value = CmbPrice6_price_level.Text
                .Parameters("@special_notice").Value = Inv_Price_NoteVar
                .ExecuteNonQuery()
                PInsert = TxtPrice_code.Text
                .Connection.Close()
            End With
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PInsert = ""
        End Try
    End Function
    Friend Function PUpdate(ByVal Thisprice_code As String) As Boolean
        PUpdate = True
        Try
            With CmdUpdate
                If .Connection.State <> ConnectionState.Open Then
                    .Connection.Open()
                End If
                .Parameters("@price_code").Value = TxtPrice_code.Text
                .Parameters("@Desc_price_code").Value = TxtDesc_price_code.Text
                .Parameters("@price1_c_l_a_p").Value = CmbPrice1_c_l_a_p.Text
                .Parameters("@price1_operator").Value = CmbPrice1_operator.Text
                .Parameters("@price1_d_persent").Value = CmbPrice1_D_persent.Text
                .Parameters("@price1_amount").Value = NumPrice1_Amount.Text
                .Parameters("@price1_odd_price").Value = IIf(Chkodd_priceFlag1.Checked, -1, NumPrice1_odd_price.Text)
                .Parameters("@price1_price_level").Value = CmbPrice1_price_level.Text
                .Parameters("@price2_c_l_a_p").Value = CmbPrice2_c_l_a_p.Text
                .Parameters("@price2_operator").Value = CmbPrice2_operator.Text
                .Parameters("@price2_d_persent").Value = CmbPrice2_D_persent.Text
                .Parameters("@price2_amount").Value = NumPrice2_Amount.Text
                .Parameters("@price2_odd_price").Value = IIf(Chkodd_priceFlag2.Checked, -1, NumPrice2_odd_price.Text)
                .Parameters("@price2_price_level").Value = CmbPrice2_price_level.Text
                .Parameters("@price3_c_l_a_p").Value = CmbPrice3_c_l_a_p.Text
                .Parameters("@price3_operator").Value = CmbPrice3_operator.Text
                .Parameters("@price3_d_persent").Value = CmbPrice3_D_persent.Text
                .Parameters("@price3_amount").Value = NumPrice3_Amount.Text
                .Parameters("@price3_odd_price").Value = IIf(Chkodd_priceFlag3.Checked, -1, NumPrice3_odd_price.Text)
                .Parameters("@price3_price_level").Value = CmbPrice3_price_level.Text
                .Parameters("@price4_c_l_a_p").Value = CmbPrice4_c_l_a_p.Text
                .Parameters("@price4_operator").Value = CmbPrice4_operator.Text
                .Parameters("@price4_d_persent").Value = CmbPrice4_D_persent.Text
                .Parameters("@price4_amount").Value = NumPrice4_Amount.Text
                .Parameters("@price4_odd_price").Value = IIf(Chkodd_priceFlag4.Checked, -1, NumPrice4_odd_price.Text)
                .Parameters("@price4_price_level").Value = CmbPrice4_price_level.Text
                .Parameters("@price5_c_l_a_p").Value = CmbPrice5_c_l_a_p.Text
                .Parameters("@price5_operator").Value = CmbPrice5_operator.Text
                .Parameters("@price5_d_persent").Value = CmbPrice5_D_persent.Text
                .Parameters("@price5_amount").Value = NumPrice5_Amount.Text
                .Parameters("@price5_odd_price").Value = IIf(Chkodd_priceFlag5.Checked, -1, NumPrice5_odd_price.Text)
                .Parameters("@price5_price_level").Value = CmbPrice5_price_level.Text
                .Parameters("@price6_c_l_a_p").Value = CmbPrice6_c_l_a_p.Text
                .Parameters("@price6_operator").Value = CmbPrice6_operator.Text
                .Parameters("@price6_d_persent").Value = CmbPrice6_D_persent.Text
                .Parameters("@price6_amount").Value = NumPrice6_Amount.Text
                .Parameters("@price6_odd_price").Value = IIf(Chkodd_priceFlag6.Checked, -1, NumPrice6_odd_price.Text)
                .Parameters("@price6_price_level").Value = CmbPrice6_price_level.Text
                .Parameters("@special_notice").Value = Inv_Price_NoteVar
                .ExecuteNonQuery()
                .Connection.Close()
            End With

            Call UpdateItemPrice(TxtPrice_code.Text)

        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PUpdate = False
        End Try
    End Function
    Friend Function FillFields(ByVal Thisprice_code As String) As Boolean
        FillFields = False
        If Thisprice_code.Trim.Length = 0 Then
            Exit Function
        End If
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT * " _
                      & " FROM inv_price_code " _
                      & " where inv_price_code.price_code = " & Qt(Thisprice_code)
        SQLReader = CmdGeneral.ExecuteReader
        If SQLReader.HasRows Then
            SQLReader.Read()
            TxtPrice_code.Text = Trim(SQLReader.Item("price_code") & "")
            TxtDesc_price_code.Text = Trim(SQLReader.Item("desc_price_code") & "")
            CmbPrice1_c_l_a_p.Text = Trim(SQLReader.Item("price1_c_l_a_p") & "")
            CmbPrice1_operator.Text = Trim(SQLReader.Item("price1_operator") & "")
            CmbPrice1_D_persent.Text = Trim(SQLReader.Item("price1_d_persent") & "")
            NumPrice1_Amount.Text = SQLReader.Item("price1_amount")
            If SQLReader.Item("price1_odd_price") = -1 Then
                Chkodd_priceFlag1.Checked = True
                NumPrice1_odd_price.Text = 0
            Else
                Chkodd_priceFlag1.Checked = False
                NumPrice1_odd_price.Text = SQLReader.Item("price1_odd_price")
            End If
            CmbPrice1_price_level.Text = Trim(SQLReader.Item("price1_price_level") & "")
            CmbPrice2_c_l_a_p.Text = Trim(SQLReader.Item("price2_c_l_a_p") & "")
            CmbPrice2_operator.Text = Trim(SQLReader.Item("price2_operator") & "")
            CmbPrice2_D_persent.Text = Trim(SQLReader.Item("price2_d_persent") & "")
            NumPrice2_Amount.Text = SQLReader.Item("price2_amount")
            If SQLReader.Item("price2_odd_price") = -1 Then
                Chkodd_priceFlag2.Checked = True
                NumPrice2_odd_price.Text = 0
            Else
                Chkodd_priceFlag2.Checked = False
                NumPrice2_odd_price.Text = SQLReader.Item("price2_odd_price")
            End If
            CmbPrice2_price_level.Text = Trim(SQLReader.Item("price2_price_level") & "")
            CmbPrice3_c_l_a_p.Text = Trim(SQLReader.Item("price3_c_l_a_p") & "")
            CmbPrice3_operator.Text = Trim(SQLReader.Item("price3_operator") & "")
            CmbPrice3_D_persent.Text = Trim(SQLReader.Item("price3_d_persent") & "")
            NumPrice3_Amount.Text = SQLReader.Item("price3_amount")
            If SQLReader.Item("price3_odd_price") = -1 Then
                Chkodd_priceFlag3.Checked = True
                NumPrice3_odd_price.Text = 0
            Else
                Chkodd_priceFlag3.Checked = False
                NumPrice3_odd_price.Text = SQLReader.Item("price3_odd_price")
            End If
            CmbPrice3_price_level.Text = Trim(SQLReader.Item("price3_price_level") & "")
            CmbPrice4_c_l_a_p.Text = Trim(SQLReader.Item("price4_c_l_a_p") & "")
            CmbPrice4_operator.Text = Trim(SQLReader.Item("price4_operator") & "")
            CmbPrice4_D_persent.Text = Trim(SQLReader.Item("price4_d_persent") & "")
            NumPrice4_Amount.Text = SQLReader.Item("price4_amount")
            If SQLReader.Item("price4_odd_price") = -1 Then
                Chkodd_priceFlag4.Checked = True
                NumPrice4_odd_price.Text = 0
            Else
                Chkodd_priceFlag4.Checked = False
                NumPrice4_odd_price.Text = SQLReader.Item("price4_odd_price")
            End If
            CmbPrice4_price_level.Text = Trim(SQLReader.Item("price4_price_level") & "")
            CmbPrice5_c_l_a_p.Text = Trim(SQLReader.Item("price5_c_l_a_p") & "")
            CmbPrice5_operator.Text = Trim(SQLReader.Item("price5_operator") & "")
            CmbPrice5_D_persent.Text = Trim(SQLReader.Item("price5_d_persent") & "")
            NumPrice5_Amount.Text = SQLReader.Item("price5_amount")
            If SQLReader.Item("price5_odd_price") = -1 Then
                Chkodd_priceFlag5.Checked = True
                NumPrice5_odd_price.Text = 0
            Else
                Chkodd_priceFlag5.Checked = False
                NumPrice5_odd_price.Text = SQLReader.Item("price5_odd_price")
            End If
            CmbPrice5_price_level.Text = Trim(SQLReader.Item("price5_price_level") & "")
            CmbPrice6_c_l_a_p.Text = Trim(SQLReader.Item("price6_c_l_a_p") & "")
            CmbPrice6_operator.Text = Trim(SQLReader.Item("price6_operator") & "")
            CmbPrice6_D_persent.Text = Trim(SQLReader.Item("price6_d_persent") & "")
            NumPrice6_Amount.Text = SQLReader.Item("price6_amount")
            If SQLReader.Item("price6_odd_price") = -1 Then
                Chkodd_priceFlag6.Checked = True
                NumPrice6_odd_price.Text = 0
            Else
                Chkodd_priceFlag6.Checked = False
                NumPrice6_odd_price.Text = SQLReader.Item("price6_odd_price")
            End If
            CmbPrice6_price_level.Text = Trim(SQLReader.Item("price6_price_level") & "")
            Inv_Price_NoteVar = Trim(SQLReader.Item("special_notice") & "")
            '''''''''''''''''''''''''''''''''''''''
            FillFields = True
        Else
            Call ClearField()
        End If
        SQLReader.Close()
        CmdGeneral.Connection.Close()
    End Function
    Private Sub FillOtherFields()
        'If TxtPrice_code.Text.Trim.Length = 0 Then
        '    Exit Sub
        'End If
        'Dim SQLReader As System.Data.SqlClient.SqlDataReader
        'If CmdGeneral.Connection.State <> ConnectionState.Open Then
        '    CmdGeneral.Connection.Open()
        'End If
        'CmdGeneral.CommandText = "SELECT * from inv_price_code where price_code=" & TxtPrice_code.Text '& " Order by "
        'SQLReader = CmdGeneral.ExecuteReader
        'If SQLReader.HasRows Then
        '    SQLReader.Read()
        '    TxtAmount_price1.Text = Trim(SQLReader.Item("") & "")
        'Else
        '    TxtAmount_price1.Text = ""
        'End If
        'SQLReader.Close()
        'CmdGeneral.Connection.Close()
    End Sub
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
    Private Sub UiContextMenu1_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs)
        UiContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UiContextMenu1.Commands(1).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UiContextMenu1.Commands(e.Command.Key).Checked() = Janus.Windows.UI.InheritableBoolean.True
        Select Case e.Command.Key.ToUpper
            Case "SORT1"
                InvPrice_CodeOrderFieldName = "price_code"
            Case "SORT2"
                InvPrice_CodeOrderFieldName = "desc_price_code"
        End Select
    End Sub
    Private Sub CmbPrice1_c_l_a_p_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPrice1_c_l_a_p.SelectedIndexChanged, CmbPrice2_c_l_a_p.SelectedIndexChanged, CmbPrice3_c_l_a_p.SelectedIndexChanged, CmbPrice4_c_l_a_p.SelectedIndexChanged, CmbPrice5_c_l_a_p.SelectedIndexChanged, CmbPrice6_c_l_a_p.SelectedIndexChanged
        Call CmbPrice_c_l_a_pDisableEnable()
        Call SaveButtonControl()
    End Sub
    Private Sub CmbPrice_c_l_a_pDisableEnable()
        If Trim(CmbPrice1_c_l_a_p.Text).ToUpper = "P" Then
            CmbPrice1_price_level.Enabled = CmbPrice1_c_l_a_p.Enabled
        Else
            CmbPrice1_price_level.Enabled = False
        End If
        If Trim(CmbPrice2_c_l_a_p.Text).ToUpper = "P" Then
            CmbPrice2_price_level.Enabled = CmbPrice2_c_l_a_p.Enabled
        Else
            CmbPrice2_price_level.Enabled = False
        End If
        If Trim(CmbPrice3_c_l_a_p.Text).ToUpper = "P" Then
            CmbPrice3_price_level.Enabled = CmbPrice3_c_l_a_p.Enabled
        Else
            CmbPrice3_price_level.Enabled = False
        End If
        If Trim(CmbPrice4_c_l_a_p.Text).ToUpper = "P" Then
            CmbPrice4_price_level.Enabled = CmbPrice4_c_l_a_p.Enabled
        Else
            CmbPrice4_price_level.Enabled = False
        End If
        If Trim(CmbPrice5_c_l_a_p.Text).ToUpper = "P" Then
            CmbPrice5_price_level.Enabled = CmbPrice5_c_l_a_p.Enabled
        Else
            CmbPrice5_price_level.Enabled = False
        End If
        If Trim(CmbPrice6_c_l_a_p.Text).ToUpper = "P" Then
            CmbPrice6_price_level.Enabled = CmbPrice6_c_l_a_p.Enabled
        Else
            CmbPrice6_price_level.Enabled = False
        End If
    End Sub
    Private Sub BtnNotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNotes.Click
        Dim MyFrmItemComments As New CommonClass.FrmItemComments
        MyFrmItemComments.TxtComments.Text = Inv_Price_NoteVar & ""
        Call FitToScreen(BtnNotes, MyFrmItemComments)
        MyFrmItemComments.ThisFormStatus = Status
        MyFrmItemComments.TxtComments.MaxLength = 300
        MyFrmItemComments.ShowDialog()
        Inv_Price_NoteVar = MyFrmItemComments.TxtCommentvar
        Call SaveButtonControl()
    End Sub
    Private Sub NumPrice1_odd_price_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles NumPrice1_odd_price.Validating, NumPrice2_odd_price.Validating, NumPrice3_odd_price.Validating, NumPrice4_odd_price.Validating, NumPrice5_odd_price.Validating, NumPrice6_odd_price.Validating
        If NumPrice1_odd_price.Text >= 1 Or NumPrice2_odd_price.Text >= 1 Or NumPrice3_odd_price.Text >= 1 Or NumPrice4_odd_price.Text >= 1 Or NumPrice5_odd_price.Text >= 1 Or NumPrice6_odd_price.Text >= 1 Then
            MsgBox("Odd Price value must be less than 1")
            e.Cancel = True
        End If
    End Sub
    Private Sub Chkodd_priceFlag1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chkodd_priceFlag1.CheckedChanged
        NumPrice1_odd_price.Enabled = (Not Chkodd_priceFlag1.Checked) And Chkodd_priceFlag1.Enabled
    End Sub
    Private Sub Chkodd_priceFlag2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chkodd_priceFlag2.CheckedChanged
        NumPrice2_odd_price.Enabled = (Not Chkodd_priceFlag2.Checked) And Chkodd_priceFlag2.Enabled
    End Sub
    Private Sub Chkodd_priceFlag3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chkodd_priceFlag3.CheckedChanged
        NumPrice3_odd_price.Enabled = (Not Chkodd_priceFlag3.Checked) And Chkodd_priceFlag3.Enabled
    End Sub
    Private Sub Chkodd_priceFlag4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chkodd_priceFlag4.CheckedChanged
        NumPrice4_odd_price.Enabled = (Not Chkodd_priceFlag4.Checked) And Chkodd_priceFlag4.Enabled
    End Sub
    Private Sub Chkodd_priceFlag5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chkodd_priceFlag5.CheckedChanged
        NumPrice5_odd_price.Enabled = (Not Chkodd_priceFlag5.Checked) And Chkodd_priceFlag5.Enabled
    End Sub
    Private Sub Chkodd_priceFlag6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chkodd_priceFlag6.CheckedChanged
        NumPrice6_odd_price.Enabled = (Not Chkodd_priceFlag6.Checked) And Chkodd_priceFlag6.Enabled
    End Sub
    Private Sub UpdateItemPrice(ByVal ThisPriceCose As String)
        MyItem = New UCInv_Item.Clsitem_no
        MyItem.Connection = Me.Cnn
        Dim Pl1 As Double
        Dim Pl2 As Double
        Dim Pl3 As Double
        Dim Pl4 As Double
        Dim Pl5 As Double
        Dim Pl6 As Double
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        If CmdGeneralForReader.Connection.State <> ConnectionState.Open Then
            CmdGeneralForReader.Connection.Open()
        End If
        ProgressBar1.Visible = True
        ProgressBar1.Value = 0
        ProgressBar1.Minimum = 0
        If ThisPriceCose.Trim.Length = 0 Then
            CmdGeneralForReader.CommandText = "SELECT count(*) from inv_item_cost_transaction Where last_flag=1"
            ProgressBar1.Maximum = CmdGeneralForReader.ExecuteScalar
            CmdGeneralForReader.CommandText = "SELECT * from inv_item_cost_transaction Where last_flag=1"
        Else
            CmdGeneralForReader.CommandText = "SELECT count(*) from inv_item_cost_transaction Where price_code=" & Qt(ThisPriceCose) & " AND last_flag=1"
            ProgressBar1.Maximum = CmdGeneralForReader.ExecuteScalar
            CmdGeneralForReader.CommandText = "SELECT * from inv_item_cost_transaction Where price_code=" & Qt(ThisPriceCose) & " AND last_flag=1"
        End If
        SQLReader = CmdGeneralForReader.ExecuteReader
        If SQLReader.HasRows Then
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            Do While SQLReader.Read()
                Pl1 = 0
                Pl2 = 0
                Pl3 = 0
                Pl4 = 0
                Pl5 = 0
                Pl6 = 0
                Pl1 = MyItem.CalculatePriceCode(SQLReader.Item("Item_No"), 1)
                Pl2 = MyItem.CalculatePriceCode(SQLReader.Item("Item_No"), 2)
                Pl3 = MyItem.CalculatePriceCode(SQLReader.Item("Item_No"), 3)
                Pl4 = MyItem.CalculatePriceCode(SQLReader.Item("Item_No"), 4)
                Pl5 = MyItem.CalculatePriceCode(SQLReader.Item("Item_No"), 5)
                Pl6 = MyItem.CalculatePriceCode(SQLReader.Item("Item_No"), 6)
                CmdGeneral.CommandText = "Update inv_item_cost_transaction SET amount_price1=" & Pl1 & ",amount_price2=" & Pl2 & ",amount_price3=" & Pl3 & ",amount_price4=" & Pl4 & ",amount_price5=" & Pl5 & ",amount_price6=" & Pl6 & " WHERE item_no=" & Qt(SQLReader.Item("Item_No")) & " AND last_flag=1"
                CmdGeneral.ExecuteNonQuery()
                ProgressBar1.Value = ProgressBar1.Value + 1
                'System.Windows.Forms.Application.DoEvents()
                Me.Refresh()
            Loop
        End If
        SQLReader.Close()
        ProgressBar1.Visible = False
    End Sub
    Private Sub BtnCalculateAllItemsPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalculateAllItemsPrice.Click
        Call UpdateItemPrice("") ' this means all Price Codes
    End Sub
End Class
