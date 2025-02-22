Imports CommonClass
Imports System.Data.SqlClient
Public Class FrmItemProduct
    Inherits FrmBase
    Dim i As Integer
    Dim Status As WorkStates = MainModule.WorkStates._ReadOnly
    Dim ItemOrderFieldName As String = "Item_No"
    Public Item_noTempVar As String = ""
    Dim PnlSearchHeight As Integer
    Dim MyFrmItemComments As CommonClass.FrmItemComments
    Public ItemNoteVar As String
    Dim MyFrmPicture As New UCPicture.FrmPicture
    Dim Desc_ItemPublic As String = ""
    Dim WithEvents MyFrm1 As UCInv_Item.FrmSearchItemCode
    Dim BeforeCost As Decimal = 0
    ' Dim WithEvents ClsRrp As ucre
    Dim WithEvents MyclsItemno As Clsitem_no
    Dim WithEvents myClsCommon As CommonClass.AllStore

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
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmSort As System.Windows.Forms.ContextMenu
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
    Friend WithEvents Command1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsInvItemProduct1 As UCInv_Item.DSInvItemProduct
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents MaskedEditBox27 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TxtOnOrder As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents TxtAvailable As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents TxtComitted As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents TxtOnHand As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents PanelAutopart As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents PanelWheels As System.Windows.Forms.Panel
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Paneltire As System.Windows.Forms.Panel
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents TxtStoreNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtSize As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbItemType As System.Windows.Forms.ComboBox
    Friend WithEvents TxtItem_No As System.Windows.Forms.TextBox
    Friend WithEvents DaStyle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaPriceCod As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaPublic As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaLine As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlLine As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaItemType As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaBrand As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaQuickRefrence As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SortItem_No As System.Windows.Forms.MenuItem
    Friend WithEvents SortDesc_Item As System.Windows.Forms.MenuItem
    Friend WithEvents SortItemType As System.Windows.Forms.MenuItem
    Friend WithEvents TxtDesc_Item As System.Windows.Forms.TextBox
    Friend WithEvents BtnNotes As System.Windows.Forms.Button
    Friend WithEvents BtnHistory As System.Windows.Forms.Button
    Friend WithEvents TxtUpc As System.Windows.Forms.TextBox
    Friend WithEvents ChkTaxable As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents l6 As System.Windows.Forms.Label
    Friend WithEvents l5 As System.Windows.Forms.Label
    Friend WithEvents l4 As System.Windows.Forms.Label
    Friend WithEvents l3 As System.Windows.Forms.Label
    Friend WithEvents l2 As System.Windows.Forms.Label
    Friend WithEvents l1 As System.Windows.Forms.Label
    Friend WithEvents ChkDiscontinued As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkConsignment As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents TxtCost As CalcUtils.UcCalcText
    Friend WithEvents TxtFet As CalcUtils.UcCalcText
    Friend WithEvents TxtListPrice As CalcUtils.UcCalcText
    Friend WithEvents TxtAmount_Onsale As CalcUtils.UcCalcText
    Friend WithEvents Txtamount_contract As CalcUtils.UcCalcText
    Friend WithEvents TxtAmount_Spiff As CalcUtils.UcCalcText
    Friend WithEvents ChkSpiff As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkContract As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkOnSale As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents CmbPrice_Code As System.Windows.Forms.ComboBox
    Friend WithEvents TxtMin_stock As CalcUtils.UcCalcText
    Friend WithEvents TxtMax_stock As CalcUtils.UcCalcText
    Friend WithEvents TxtReorder As CalcUtils.UcCalcText
    Friend WithEvents Txtarticle_stock_no As System.Windows.Forms.TextBox
    Friend WithEvents TxtMsPn As System.Windows.Forms.TextBox
    Friend WithEvents CmbLoad_Range As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSidWall As System.Windows.Forms.ComboBox
    Friend WithEvents Txtservice_description As System.Windows.Forms.TextBox
    Friend WithEvents Txtmax_load_lbs As System.Windows.Forms.TextBox
    Friend WithEvents Txtrevs_per_mile As System.Windows.Forms.TextBox
    Friend WithEvents Txttread_depth As System.Windows.Forms.TextBox
    Friend WithEvents Txtoveral_diameter_inch As System.Windows.Forms.TextBox
    Friend WithEvents Cmbload_index As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbspeed_simbol As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbrim_diameter_inch As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbaspect_ratio As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbwidth_mm As System.Windows.Forms.ComboBox
    Friend WithEvents Txtsection_width_inch As System.Windows.Forms.TextBox
    Friend WithEvents Txtply As System.Windows.Forms.TextBox
    Friend WithEvents Txtoriginal_equipment As System.Windows.Forms.TextBox
    Friend WithEvents Txtwieght_lbs As System.Windows.Forms.TextBox
    Friend WithEvents txtmax_air_psl As System.Windows.Forms.TextBox
    Friend WithEvents Txtofset As System.Windows.Forms.TextBox
    Friend WithEvents CmbFinish As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbwheel_size As System.Windows.Forms.ComboBox
    Friend WithEvents Txtmax_diameter As System.Windows.Forms.TextBox
    Friend WithEvents Txtlug_size As System.Windows.Forms.TextBox
    Friend WithEvents Txtbolt_pattern As System.Windows.Forms.TextBox
    Friend WithEvents Txtbackside As System.Windows.Forms.TextBox
    Friend WithEvents Chkcore_track As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents Chkwarranty_track As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents Txtmiles As CalcUtils.UcCalcText
    Friend WithEvents Txtdays As CalcUtils.UcCalcText
    Friend WithEvents Txtcore_cost As CalcUtils.UcCalcText
    Friend WithEvents TxtDesc_Item2 As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaBinLocation As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmbBinLocation As System.Windows.Forms.ComboBox
    Friend WithEvents P5 As System.Windows.Forms.Panel
    Friend WithEvents p4 As System.Windows.Forms.Panel
    Friend WithEvents P3 As System.Windows.Forms.Panel
    Friend WithEvents P2 As System.Windows.Forms.Panel
    Friend WithEvents P1 As System.Windows.Forms.Panel
    Friend WithEvents CmdInsertinv_item_cost_transaction As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdUpdateinv_item_cost_transaction As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdInsertinv_tab_item_warehouse As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdUpdateinv_tab_item_warehouse As System.Data.SqlClient.SqlCommand
    Public WithEvents CmdInsertinv_discount_item As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdUpdateInv_discount_item As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdInsertinv_tab_tire_specification As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdUpdateinv_tab_tire_specification As System.Data.SqlClient.SqlCommand
    Friend WithEvents Txtwidth As System.Windows.Forms.TextBox
    Friend WithEvents CmdInsertinv_tab_wheels_specification As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdUpdateinv_tab_wheels_specification As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdInsertinv_tab_autopart_specification As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdUpdateinv_tab_autopart_specification As System.Data.SqlClient.SqlCommand
    Friend WithEvents TxtDelivery As CalcUtils.UcCalcText
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents CmdDeleteOthers As System.Data.SqlClient.SqlCommand
    Friend WithEvents TxtBrand As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents TxtStyle As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents UiCommandManager1 As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents UiContextMenu1 As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents Sort1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort3 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents Sort11 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort21 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Sort31 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents CmdLoad As System.Windows.Forms.Button
    Friend WithEvents TxtAvgCost As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents txtfrieght As CalcUtils.UcCalcText

    Friend WithEvents PictureButton1 As UCPicture.PictureButton
    Friend WithEvents ItemNo1 As UCInv_Item.ItemNo
    Friend WithEvents TxtStart_date_on_sale As CalendarCombo.CalendarCombo
    Friend WithEvents TxtStart_Date_Contract As CalendarCombo.CalendarCombo
    Friend WithEvents Txtstart_date_spiff As CalendarCombo.CalendarCombo
    Friend WithEvents TxtEnd_date_on_sale As CalendarCombo.CalendarCombo
    Friend WithEvents TxtEnd_Date_Contract As CalendarCombo.CalendarCombo
    Friend WithEvents TxtEnd_date_spiff As CalendarCombo.CalendarCombo
    Friend WithEvents TxtDiscontinued_date As CalendarCombo.CalendarCombo
    'Friend WithEvents WorkOrderOfItem1 As WorkOrderUtility.WorkOrderOfItem
    'Friend WithEvents WorkOrderOfItem2 As WorkOrderUtility.WorkOrderOfItem
    Friend WithEvents WorkOrderOfItem1 As WorkOrderUtility.WorkOrderOfItem
    Friend WithEvents InvLine_Detail1 As UCInv_Item.InvLine_Detail
    Friend WithEvents TxtSizeCod As UcPublicTable.PublicCod
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtrim_width_range_inch As System.Windows.Forms.TextBox
    Friend WithEvents QuickReference1 As UcQuickReference.QuickReference
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Utqg1 As UCInv_Item.UTQG
    Friend WithEvents lastrecevieDate As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents LastAdjustmentDate As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents LblQref As System.Windows.Forms.Label
    Friend WithEvents Pl1 As CalcUtils.UcCalcText
    Friend WithEvents Pl2 As CalcUtils.UcCalcText
    Friend WithEvents Pl3 As CalcUtils.UcCalcText
    Friend WithEvents Pl4 As CalcUtils.UcCalcText
    Friend WithEvents Pl5 As CalcUtils.UcCalcText
    Friend WithEvents Pl6 As CalcUtils.UcCalcText
    Friend WithEvents Plf6 As CalcUtils.UcCalcText
    Friend WithEvents Plf5 As CalcUtils.UcCalcText
    Friend WithEvents Plf4 As CalcUtils.UcCalcText
    Friend WithEvents Plf3 As CalcUtils.UcCalcText
    Friend WithEvents Plf2 As CalcUtils.UcCalcText
    Friend WithEvents Plf1 As CalcUtils.UcCalcText
    Friend WithEvents LastSaleDate As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaLastReceive As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaLastServicecenter As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DALastAdjustment As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TxtReplCost As CalcUtils.UcCalcText
    Friend WithEvents TxtCost2 As CalcUtils.UcCalcText
    Friend WithEvents LastSaleAmount As CalcUtils.UcCalcText
    Friend WithEvents lastreceiveamount As CalcUtils.UcCalcText
    Friend WithEvents UcCalcText1 As CalcUtils.UcCalcText
    Friend WithEvents lastAdjustmentamount As CalcUtils.UcCalcText
    Friend WithEvents TxtAmountCreated As CalcUtils.UcCalcText
    Friend WithEvents tXTDateCreated As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents LastChangeDatePrice As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents LastCostPrice As CalcUtils.UcCalcText
    Friend WithEvents ChkInsertToAllStore As System.Windows.Forms.CheckBox
    Friend WithEvents BtnVendor As Janus.Windows.EditControls.UIButton
    Friend WithEvents Line1 As UCInv_Item.Line


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmItemProduct))
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
        Me.CmSort = New System.Windows.Forms.ContextMenu
        Me.SortItem_No = New System.Windows.Forms.MenuItem
        Me.SortDesc_Item = New System.Windows.Forms.MenuItem
        Me.SortItemType = New System.Windows.Forms.MenuItem
        Me.PnlSearch = New System.Windows.Forms.Panel
        Me.ItemNo1 = New UCInv_Item.ItemNo
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbItemType = New System.Windows.Forms.ComboBox
        Me.DsInvItemProduct1 = New UCInv_Item.DSInvItemProduct
        Me.CnnTemp = New System.Data.SqlClient.SqlConnection
        Me.PnlKartAmvalField = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.P5 = New System.Windows.Forms.Panel
        Me.TxtCost2 = New CalcUtils.UcCalcText
        Me.TxtReplCost = New CalcUtils.UcCalcText
        Me.TxtDiscontinued_date = New CalendarCombo.CalendarCombo
        Me.TxtAvgCost = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.txtfrieght = New CalcUtils.UcCalcText
        Me.TxtDelivery = New CalcUtils.UcCalcText
        Me.Label61 = New System.Windows.Forms.Label
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.ChkDiscontinued = New Janus.Windows.EditControls.UICheckBox
        Me.ChkConsignment = New Janus.Windows.EditControls.UICheckBox
        Me.p4 = New System.Windows.Forms.Panel
        Me.TxtAmountCreated = New CalcUtils.UcCalcText
        Me.LastCostPrice = New CalcUtils.UcCalcText
        Me.lastAdjustmentamount = New CalcUtils.UcCalcText
        Me.UcCalcText1 = New CalcUtils.UcCalcText
        Me.lastreceiveamount = New CalcUtils.UcCalcText
        Me.LastSaleAmount = New CalcUtils.UcCalcText
        Me.tXTDateCreated = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.LastChangeDatePrice = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.LastAdjustmentDate = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.MaskedEditBox27 = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.lastrecevieDate = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.LastSaleDate = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.P3 = New System.Windows.Forms.Panel
        Me.Plf6 = New CalcUtils.UcCalcText
        Me.Plf5 = New CalcUtils.UcCalcText
        Me.Plf4 = New CalcUtils.UcCalcText
        Me.Plf3 = New CalcUtils.UcCalcText
        Me.Plf2 = New CalcUtils.UcCalcText
        Me.Plf1 = New CalcUtils.UcCalcText
        Me.Pl6 = New CalcUtils.UcCalcText
        Me.Pl5 = New CalcUtils.UcCalcText
        Me.Pl4 = New CalcUtils.UcCalcText
        Me.Pl3 = New CalcUtils.UcCalcText
        Me.Pl2 = New CalcUtils.UcCalcText
        Me.Pl1 = New CalcUtils.UcCalcText
        Me.CmbPrice_Code = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.l6 = New System.Windows.Forms.Label
        Me.l5 = New System.Windows.Forms.Label
        Me.l4 = New System.Windows.Forms.Label
        Me.l3 = New System.Windows.Forms.Label
        Me.l2 = New System.Windows.Forms.Label
        Me.l1 = New System.Windows.Forms.Label
        Me.P2 = New System.Windows.Forms.Panel
        Me.WorkOrderOfItem1 = New WorkOrderUtility.WorkOrderOfItem
        Me.TxtReorder = New CalcUtils.UcCalcText
        Me.TxtMax_stock = New CalcUtils.UcCalcText
        Me.TxtMin_stock = New CalcUtils.UcCalcText
        Me.TxtOnOrder = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.TxtAvailable = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.TxtComitted = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.TxtOnHand = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.P1 = New System.Windows.Forms.Panel
        Me.Line1 = New UCInv_Item.Line
        Me.BtnVendor = New Janus.Windows.EditControls.UIButton
        Me.LblQref = New System.Windows.Forms.Label
        Me.QuickReference1 = New UcQuickReference.QuickReference
        Me.InvLine_Detail1 = New UCInv_Item.InvLine_Detail
        Me.TxtEnd_date_spiff = New CalendarCombo.CalendarCombo
        Me.TxtEnd_Date_Contract = New CalendarCombo.CalendarCombo
        Me.TxtEnd_date_on_sale = New CalendarCombo.CalendarCombo
        Me.Txtstart_date_spiff = New CalendarCombo.CalendarCombo
        Me.TxtStart_Date_Contract = New CalendarCombo.CalendarCombo
        Me.TxtStart_date_on_sale = New CalendarCombo.CalendarCombo
        Me.PictureButton1 = New UCPicture.PictureButton
        Me.CmdLoad = New System.Windows.Forms.Button
        Me.TxtStyle = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.TxtBrand = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.CmbBinLocation = New System.Windows.Forms.ComboBox
        Me.TxtListPrice = New CalcUtils.UcCalcText
        Me.TxtFet = New CalcUtils.UcCalcText
        Me.TxtCost = New CalcUtils.UcCalcText
        Me.TxtAmount_Spiff = New CalcUtils.UcCalcText
        Me.Txtamount_contract = New CalcUtils.UcCalcText
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.TxtAmount_Onsale = New CalcUtils.UcCalcText
        Me.ChkSpiff = New Janus.Windows.EditControls.UICheckBox
        Me.ChkContract = New Janus.Windows.EditControls.UICheckBox
        Me.ChkOnSale = New Janus.Windows.EditControls.UICheckBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.TxtUpc = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtDesc_Item = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.BtnNotes = New System.Windows.Forms.Button
        Me.BtnHistory = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.ChkTaxable = New Janus.Windows.EditControls.UICheckBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.PanelAutopart = New System.Windows.Forms.Panel
        Me.Txtcore_cost = New CalcUtils.UcCalcText
        Me.Txtdays = New CalcUtils.UcCalcText
        Me.Txtmiles = New CalcUtils.UcCalcText
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label97 = New System.Windows.Forms.Label
        Me.Chkcore_track = New Janus.Windows.EditControls.UICheckBox
        Me.Label96 = New System.Windows.Forms.Label
        Me.Label95 = New System.Windows.Forms.Label
        Me.Chkwarranty_track = New Janus.Windows.EditControls.UICheckBox
        Me.Label94 = New System.Windows.Forms.Label
        Me.PanelWheels = New System.Windows.Forms.Panel
        Me.Txtmax_diameter = New System.Windows.Forms.TextBox
        Me.Label93 = New System.Windows.Forms.Label
        Me.Txtlug_size = New System.Windows.Forms.TextBox
        Me.Txtbolt_pattern = New System.Windows.Forms.TextBox
        Me.Txtbackside = New System.Windows.Forms.TextBox
        Me.Txtofset = New System.Windows.Forms.TextBox
        Me.CmbFinish = New System.Windows.Forms.ComboBox
        Me.Cmbwheel_size = New System.Windows.Forms.ComboBox
        Me.Label92 = New System.Windows.Forms.Label
        Me.Label91 = New System.Windows.Forms.Label
        Me.Label90 = New System.Windows.Forms.Label
        Me.Label89 = New System.Windows.Forms.Label
        Me.Label88 = New System.Windows.Forms.Label
        Me.Label87 = New System.Windows.Forms.Label
        Me.Label86 = New System.Windows.Forms.Label
        Me.TxtDesc_Item2 = New System.Windows.Forms.TextBox
        Me.Label74 = New System.Windows.Forms.Label
        Me.Paneltire = New System.Windows.Forms.Panel
        Me.Utqg1 = New UCInv_Item.UTQG
        Me.Label11 = New System.Windows.Forms.Label
        Me.Txtrim_width_range_inch = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtSizeCod = New UcPublicTable.PublicCod
        Me.Label98 = New System.Windows.Forms.Label
        Me.Txtply = New System.Windows.Forms.TextBox
        Me.Txtoriginal_equipment = New System.Windows.Forms.TextBox
        Me.Txtwieght_lbs = New System.Windows.Forms.TextBox
        Me.txtmax_air_psl = New System.Windows.Forms.TextBox
        Me.Txtmax_load_lbs = New System.Windows.Forms.TextBox
        Me.Txtrevs_per_mile = New System.Windows.Forms.TextBox
        Me.Txtwidth = New System.Windows.Forms.TextBox
        Me.Txttread_depth = New System.Windows.Forms.TextBox
        Me.Txtoveral_diameter_inch = New System.Windows.Forms.TextBox
        Me.Cmbload_index = New System.Windows.Forms.ComboBox
        Me.Cmbspeed_simbol = New System.Windows.Forms.ComboBox
        Me.Label85 = New System.Windows.Forms.Label
        Me.Label84 = New System.Windows.Forms.Label
        Me.Label82 = New System.Windows.Forms.Label
        Me.Label81 = New System.Windows.Forms.Label
        Me.Label80 = New System.Windows.Forms.Label
        Me.Label79 = New System.Windows.Forms.Label
        Me.Label78 = New System.Windows.Forms.Label
        Me.Label77 = New System.Windows.Forms.Label
        Me.Label76 = New System.Windows.Forms.Label
        Me.Label75 = New System.Windows.Forms.Label
        Me.Cmbrim_diameter_inch = New System.Windows.Forms.ComboBox
        Me.Label73 = New System.Windows.Forms.Label
        Me.Cmbaspect_ratio = New System.Windows.Forms.ComboBox
        Me.Label72 = New System.Windows.Forms.Label
        Me.Cmbwidth_mm = New System.Windows.Forms.ComboBox
        Me.Label71 = New System.Windows.Forms.Label
        Me.Txtsection_width_inch = New System.Windows.Forms.TextBox
        Me.Label70 = New System.Windows.Forms.Label
        Me.Txtarticle_stock_no = New System.Windows.Forms.TextBox
        Me.Label69 = New System.Windows.Forms.Label
        Me.TxtMsPn = New System.Windows.Forms.TextBox
        Me.Label68 = New System.Windows.Forms.Label
        Me.CmbLoad_Range = New System.Windows.Forms.ComboBox
        Me.Label67 = New System.Windows.Forms.Label
        Me.CmbSidWall = New System.Windows.Forms.ComboBox
        Me.Label66 = New System.Windows.Forms.Label
        Me.Txtservice_description = New System.Windows.Forms.TextBox
        Me.Label65 = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me.Label83 = New System.Windows.Forms.Label
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.CmdInsert = New System.Data.SqlClient.SqlCommand
        Me.CmdUpdate = New System.Data.SqlClient.SqlCommand
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.ChkInsertToAllStore = New System.Windows.Forms.CheckBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.BtnSortOrder = New Janus.Windows.EditControls.UIButton
        Me.UiContextMenu1 = New Janus.Windows.UI.CommandBars.UIContextMenu
        Me.UiCommandManager1 = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.Sort1 = New Janus.Windows.UI.CommandBars.UICommand("Sort1")
        Me.Sort2 = New Janus.Windows.UI.CommandBars.UICommand("Sort2")
        Me.Sort3 = New Janus.Windows.UI.CommandBars.UICommand("Sort3")
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.Sort11 = New Janus.Windows.UI.CommandBars.UICommand("Sort1")
        Me.Sort21 = New Janus.Windows.UI.CommandBars.UICommand("Sort2")
        Me.Sort31 = New Janus.Windows.UI.CommandBars.UICommand("Sort3")
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
        Me.Command1 = New Janus.Windows.UI.CommandBars.UICommand("Command1")
        Me.PanelTop = New System.Windows.Forms.Panel
        Me.TxtStoreNo = New System.Windows.Forms.TextBox
        Me.TxtSize = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtItem_No = New System.Windows.Forms.TextBox
        Me.Label101 = New System.Windows.Forms.Label
        Me.Label102 = New System.Windows.Forms.Label
        Me.DaStyle = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DaPriceCod = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DaPublic = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DaLine = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlLine = New System.Data.SqlClient.SqlCommand
        Me.DaItemType = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaBrand = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DaQuickRefrence = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.DaBinLocation = New System.Data.SqlClient.SqlDataAdapter
        Me.CmdInsertinv_item_cost_transaction = New System.Data.SqlClient.SqlCommand
        Me.CmdUpdateinv_item_cost_transaction = New System.Data.SqlClient.SqlCommand
        Me.CmdInsertinv_tab_item_warehouse = New System.Data.SqlClient.SqlCommand
        Me.CmdUpdateinv_tab_item_warehouse = New System.Data.SqlClient.SqlCommand
        Me.CmdInsertinv_discount_item = New System.Data.SqlClient.SqlCommand
        Me.CmdUpdateInv_discount_item = New System.Data.SqlClient.SqlCommand
        Me.CmdInsertinv_tab_tire_specification = New System.Data.SqlClient.SqlCommand
        Me.CmdUpdateinv_tab_tire_specification = New System.Data.SqlClient.SqlCommand
        Me.CmdInsertinv_tab_wheels_specification = New System.Data.SqlClient.SqlCommand
        Me.CmdUpdateinv_tab_wheels_specification = New System.Data.SqlClient.SqlCommand
        Me.CmdInsertinv_tab_autopart_specification = New System.Data.SqlClient.SqlCommand
        Me.CmdUpdateinv_tab_autopart_specification = New System.Data.SqlClient.SqlCommand
        Me.CmdDeleteOthers = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.DaLastReceive = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.DaLastServicecenter = New System.Data.SqlClient.SqlDataAdapter
        Me.DALastAdjustment = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
        Me.PnlSearch.SuspendLayout()
        CType(Me.DsInvItemProduct1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlKartAmvalField.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.P5.SuspendLayout()
        Me.p4.SuspendLayout()
        Me.P3.SuspendLayout()
        Me.P2.SuspendLayout()
        Me.P1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.PanelAutopart.SuspendLayout()
        Me.PanelWheels.SuspendLayout()
        Me.Paneltire.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.UiContextMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1.EditContextMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTop.SuspendLayout()
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
        'CmdDelete
        '
        Me.CmdDelete.CommandText = "DELETE FROM inv_item WHERE (item_no = @item_no)"
        Me.CmdDelete.Connection = Me.Cnn
        Me.CmdDelete.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'CmSort
        '
        Me.CmSort.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.SortItem_No, Me.SortDesc_Item, Me.SortItemType})
        '
        'SortItem_No
        '
        Me.SortItem_No.Index = 0
        Me.SortItem_No.Text = "Order By Item No"
        '
        'SortDesc_Item
        '
        Me.SortDesc_Item.Index = 1
        Me.SortDesc_Item.Text = "Order By Item Name"
        '
        'SortItemType
        '
        Me.SortItemType.Index = 2
        Me.SortItemType.Text = "Order By ItemType"
        '
        'PnlSearch
        '
        Me.PnlSearch.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSearch.Controls.Add(Me.ItemNo1)
        Me.PnlSearch.Controls.Add(Me.Label2)
        Me.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlSearch.Location = New System.Drawing.Point(0, 45)
        Me.PnlSearch.Name = "PnlSearch"
        Me.PnlSearch.Size = New System.Drawing.Size(723, 26)
        Me.PnlSearch.TabIndex = 0
        '
        'ItemNo1
        '
        Me.ItemNo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ItemNo1.Connection = Me.Cnn
        Me.ItemNo1.ItemNo = ""
        Me.ItemNo1.ItemNoLen = 20
        Me.ItemNo1.Location = New System.Drawing.Point(49, 1)
        Me.ItemNo1.Name = "ItemNo1"
        Me.ItemNo1.NotExitIfNotFound = False
        Me.ItemNo1.ReleaseIfNotFoundItemNo = False
        Me.ItemNo1.Size = New System.Drawing.Size(101, 20)
        Me.ItemNo1.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Item No"
        '
        'CmbItemType
        '
        Me.CmbItemType.DataSource = Me.DsInvItemProduct1.inv_tab_type_item
        Me.CmbItemType.DisplayMember = "desc_item_type"
        Me.CmbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbItemType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbItemType.ItemHeight = 13
        Me.CmbItemType.Location = New System.Drawing.Point(70, 4)
        Me.CmbItemType.Name = "CmbItemType"
        Me.CmbItemType.Size = New System.Drawing.Size(120, 21)
        Me.CmbItemType.TabIndex = 0
        Me.CmbItemType.ValueMember = "cod_item_type"
        '
        'DsInvItemProduct1
        '
        Me.DsInvItemProduct1.DataSetName = "DSInvItemProduct"
        Me.DsInvItemProduct1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'CnnTemp
        '
        Me.CnnTemp.ConnectionString = "workstation id=ARMANDEH;packet size=4096;user id=sa;data source=""."";persist secur" & _
        "ity info=False;initial catalog=TireMate_01"
        '
        'PnlKartAmvalField
        '
        Me.PnlKartAmvalField.Controls.Add(Me.TabControl1)
        Me.PnlKartAmvalField.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlKartAmvalField.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PnlKartAmvalField.Location = New System.Drawing.Point(0, 102)
        Me.PnlKartAmvalField.Name = "PnlKartAmvalField"
        Me.PnlKartAmvalField.Size = New System.Drawing.Size(723, 431)
        Me.PnlKartAmvalField.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(723, 600)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.P5)
        Me.TabPage1.Controls.Add(Me.p4)
        Me.TabPage1.Controls.Add(Me.P3)
        Me.TabPage1.Controls.Add(Me.P2)
        Me.TabPage1.Controls.Add(Me.P1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(715, 574)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        '
        'P5
        '
        Me.P5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P5.Controls.Add(Me.TxtCost2)
        Me.P5.Controls.Add(Me.TxtReplCost)
        Me.P5.Controls.Add(Me.TxtDiscontinued_date)
        Me.P5.Controls.Add(Me.TxtAvgCost)
        Me.P5.Controls.Add(Me.txtfrieght)
        Me.P5.Controls.Add(Me.TxtDelivery)
        Me.P5.Controls.Add(Me.Label61)
        Me.P5.Controls.Add(Me.Label60)
        Me.P5.Controls.Add(Me.Label49)
        Me.P5.Controls.Add(Me.Label48)
        Me.P5.Controls.Add(Me.Label47)
        Me.P5.Controls.Add(Me.Label46)
        Me.P5.Controls.Add(Me.ChkDiscontinued)
        Me.P5.Controls.Add(Me.ChkConsignment)
        Me.P5.Location = New System.Drawing.Point(512, 185)
        Me.P5.Name = "P5"
        Me.P5.Size = New System.Drawing.Size(200, 163)
        Me.P5.TabIndex = 60
        '
        'TxtCost2
        '
        Me.TxtCost2.BackColor = System.Drawing.Color.Gold
        Me.TxtCost2.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtCost2.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.TxtCost2.DecimalDigits = 2
        Me.TxtCost2.DefaultSendValue = False
        Me.TxtCost2.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtCost2.FireTabAfterEnter = True
        Me.TxtCost2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtCost2.Image = CType(resources.GetObject("TxtCost2.Image"), System.Drawing.Image)
        Me.TxtCost2.Location = New System.Drawing.Point(61, 53)
        Me.TxtCost2.Maxlength = 12
        Me.TxtCost2.MinusColor = System.Drawing.Color.Empty
        Me.TxtCost2.Name = "TxtCost2"
        Me.TxtCost2.ReadOnly = True
        Me.TxtCost2.Size = New System.Drawing.Size(124, 21)
        Me.TxtCost2.TabIndex = 458
        Me.TxtCost2.TabStop = False
        Me.TxtCost2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtCost2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtReplCost
        '
        Me.TxtReplCost.BackColor = System.Drawing.Color.Gold
        Me.TxtReplCost.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtReplCost.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.TxtReplCost.DecimalDigits = 2
        Me.TxtReplCost.DefaultSendValue = False
        Me.TxtReplCost.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtReplCost.FireTabAfterEnter = True
        Me.TxtReplCost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtReplCost.Image = CType(resources.GetObject("TxtReplCost.Image"), System.Drawing.Image)
        Me.TxtReplCost.Location = New System.Drawing.Point(61, 115)
        Me.TxtReplCost.Maxlength = 12
        Me.TxtReplCost.MinusColor = System.Drawing.Color.Empty
        Me.TxtReplCost.Name = "TxtReplCost"
        Me.TxtReplCost.ReadOnly = True
        Me.TxtReplCost.Size = New System.Drawing.Size(122, 21)
        Me.TxtReplCost.TabIndex = 457
        Me.TxtReplCost.TabStop = False
        Me.TxtReplCost.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtReplCost.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtDiscontinued_date
        '
        Me.TxtDiscontinued_date.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtDiscontinued_date.BorderColor = System.Drawing.Color.Empty
        Me.TxtDiscontinued_date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtDiscontinued_date.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtDiscontinued_date.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtDiscontinued_date.EditableSal = True
        Me.TxtDiscontinued_date.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtDiscontinued_date.Image = CType(resources.GetObject("TxtDiscontinued_date.Image"), System.Drawing.Image)
        Me.TxtDiscontinued_date.Location = New System.Drawing.Point(97, 32)
        Me.TxtDiscontinued_date.MaxValue = CType(2500, Short)
        Me.TxtDiscontinued_date.MinValue = CType(1800, Short)
        Me.TxtDiscontinued_date.Name = "TxtDiscontinued_date"
        Me.TxtDiscontinued_date.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDiscontinued_date.Sal_Mali = Nothing
        Me.TxtDiscontinued_date.ShowButton = True
        Me.TxtDiscontinued_date.Size = New System.Drawing.Size(95, 19)
        Me.TxtDiscontinued_date.TabIndex = 30
        Me.TxtDiscontinued_date.VisualStyle = False
        '
        'TxtAvgCost
        '
        Me.TxtAvgCost.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtAvgCost.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtAvgCost.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.TxtAvgCost.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtAvgCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtAvgCost.IncludeLiterals = False
        Me.TxtAvgCost.Location = New System.Drawing.Point(61, 136)
        Me.TxtAvgCost.MaxLength = 15
        Me.TxtAvgCost.Name = "TxtAvgCost"
        Me.TxtAvgCost.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtAvgCost.ReadOnly = True
        Me.TxtAvgCost.Size = New System.Drawing.Size(123, 22)
        Me.TxtAvgCost.TabIndex = 46
        Me.TxtAvgCost.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'txtfrieght
        '
        Me.txtfrieght.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.txtfrieght.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.txtfrieght.DecimalDigits = 2
        Me.txtfrieght.DefaultSendValue = False
        Me.txtfrieght.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.txtfrieght.FireTabAfterEnter = True
        Me.txtfrieght.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtfrieght.Image = CType(resources.GetObject("txtfrieght.Image"), System.Drawing.Image)
        Me.txtfrieght.Location = New System.Drawing.Point(61, 94)
        Me.txtfrieght.Maxlength = 12
        Me.txtfrieght.MinusColor = System.Drawing.Color.Empty
        Me.txtfrieght.Name = "txtfrieght"
        Me.txtfrieght.Size = New System.Drawing.Size(123, 22)
        Me.txtfrieght.TabIndex = 32
        Me.txtfrieght.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.txtfrieght.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtDelivery
        '
        Me.TxtDelivery.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtDelivery.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtDelivery.DecimalDigits = 2
        Me.TxtDelivery.DefaultSendValue = False
        Me.TxtDelivery.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtDelivery.FireTabAfterEnter = True
        Me.TxtDelivery.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtDelivery.Image = CType(resources.GetObject("TxtDelivery.Image"), System.Drawing.Image)
        Me.TxtDelivery.Location = New System.Drawing.Point(61, 72)
        Me.TxtDelivery.Maxlength = 12
        Me.TxtDelivery.MinusColor = System.Drawing.Color.Empty
        Me.TxtDelivery.Name = "TxtDelivery"
        Me.TxtDelivery.Size = New System.Drawing.Size(123, 22)
        Me.TxtDelivery.TabIndex = 31
        Me.TxtDelivery.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtDelivery.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label61
        '
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label61.Location = New System.Drawing.Point(5, 136)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(51, 18)
        Me.Label61.TabIndex = 41
        Me.Label61.Text = "Avg.Cost"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label60
        '
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label60.Location = New System.Drawing.Point(-3, 115)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(59, 18)
        Me.Label60.TabIndex = 40
        Me.Label60.Text = "Repl.Cost"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label49.Location = New System.Drawing.Point(5, 97)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(51, 17)
        Me.Label49.TabIndex = 39
        Me.Label49.Text = "Freight"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label48.Location = New System.Drawing.Point(5, 76)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(51, 18)
        Me.Label48.TabIndex = 38
        Me.Label48.Text = "Delivery"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label47.Location = New System.Drawing.Point(13, 53)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(43, 18)
        Me.Label47.TabIndex = 37
        Me.Label47.Text = "Cost"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label46.Location = New System.Drawing.Point(104, 7)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(56, 19)
        Me.Label46.TabIndex = 15
        Me.Label46.Text = "Date"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkDiscontinued
        '
        Me.ChkDiscontinued.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkDiscontinued.Location = New System.Drawing.Point(8, 32)
        Me.ChkDiscontinued.Name = "ChkDiscontinued"
        Me.ChkDiscontinued.Size = New System.Drawing.Size(88, 23)
        Me.ChkDiscontinued.TabIndex = 1
        Me.ChkDiscontinued.Text = "Discontinued"
        '
        'ChkConsignment
        '
        Me.ChkConsignment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkConsignment.Location = New System.Drawing.Point(8, 7)
        Me.ChkConsignment.Name = "ChkConsignment"
        Me.ChkConsignment.Size = New System.Drawing.Size(88, 24)
        Me.ChkConsignment.TabIndex = 0
        Me.ChkConsignment.Text = "Consignment"
        '
        'p4
        '
        Me.p4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p4.Controls.Add(Me.TxtAmountCreated)
        Me.p4.Controls.Add(Me.LastCostPrice)
        Me.p4.Controls.Add(Me.lastAdjustmentamount)
        Me.p4.Controls.Add(Me.UcCalcText1)
        Me.p4.Controls.Add(Me.lastreceiveamount)
        Me.p4.Controls.Add(Me.LastSaleAmount)
        Me.p4.Controls.Add(Me.tXTDateCreated)
        Me.p4.Controls.Add(Me.LastChangeDatePrice)
        Me.p4.Controls.Add(Me.LastAdjustmentDate)
        Me.p4.Controls.Add(Me.MaskedEditBox27)
        Me.p4.Controls.Add(Me.lastrecevieDate)
        Me.p4.Controls.Add(Me.LastSaleDate)
        Me.p4.Controls.Add(Me.Label59)
        Me.p4.Controls.Add(Me.Label58)
        Me.p4.Controls.Add(Me.Label57)
        Me.p4.Controls.Add(Me.Label56)
        Me.p4.Controls.Add(Me.Label36)
        Me.p4.Controls.Add(Me.Label37)
        Me.p4.Controls.Add(Me.Label38)
        Me.p4.Controls.Add(Me.Label39)
        Me.p4.Controls.Add(Me.Label5)
        Me.p4.Location = New System.Drawing.Point(282, 185)
        Me.p4.Name = "p4"
        Me.p4.Size = New System.Drawing.Size(227, 163)
        Me.p4.TabIndex = 59
        '
        'TxtAmountCreated
        '
        Me.TxtAmountCreated.BackColor = System.Drawing.Color.Gold
        Me.TxtAmountCreated.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtAmountCreated.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.TxtAmountCreated.DecimalDigits = 2
        Me.TxtAmountCreated.DefaultSendValue = False
        Me.TxtAmountCreated.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtAmountCreated.FireTabAfterEnter = True
        Me.TxtAmountCreated.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtAmountCreated.Image = CType(resources.GetObject("TxtAmountCreated.Image"), System.Drawing.Image)
        Me.TxtAmountCreated.Location = New System.Drawing.Point(145, 127)
        Me.TxtAmountCreated.Maxlength = 12
        Me.TxtAmountCreated.MinusColor = System.Drawing.Color.Empty
        Me.TxtAmountCreated.Name = "TxtAmountCreated"
        Me.TxtAmountCreated.ReadOnly = True
        Me.TxtAmountCreated.Size = New System.Drawing.Size(72, 21)
        Me.TxtAmountCreated.TabIndex = 462
        Me.TxtAmountCreated.TabStop = False
        Me.TxtAmountCreated.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtAmountCreated.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LastCostPrice
        '
        Me.LastCostPrice.BackColor = System.Drawing.Color.Gold
        Me.LastCostPrice.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LastCostPrice.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LastCostPrice.DecimalDigits = 2
        Me.LastCostPrice.DefaultSendValue = False
        Me.LastCostPrice.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LastCostPrice.FireTabAfterEnter = True
        Me.LastCostPrice.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LastCostPrice.Image = CType(resources.GetObject("LastCostPrice.Image"), System.Drawing.Image)
        Me.LastCostPrice.Location = New System.Drawing.Point(145, 105)
        Me.LastCostPrice.Maxlength = 12
        Me.LastCostPrice.MinusColor = System.Drawing.Color.Empty
        Me.LastCostPrice.Name = "LastCostPrice"
        Me.LastCostPrice.ReadOnly = True
        Me.LastCostPrice.Size = New System.Drawing.Size(72, 21)
        Me.LastCostPrice.TabIndex = 461
        Me.LastCostPrice.TabStop = False
        Me.LastCostPrice.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LastCostPrice.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'lastAdjustmentamount
        '
        Me.lastAdjustmentamount.BackColor = System.Drawing.Color.Gold
        Me.lastAdjustmentamount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.lastAdjustmentamount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.lastAdjustmentamount.DecimalDigits = 2
        Me.lastAdjustmentamount.DefaultSendValue = False
        Me.lastAdjustmentamount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.lastAdjustmentamount.FireTabAfterEnter = True
        Me.lastAdjustmentamount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lastAdjustmentamount.Image = CType(resources.GetObject("lastAdjustmentamount.Image"), System.Drawing.Image)
        Me.lastAdjustmentamount.Location = New System.Drawing.Point(145, 86)
        Me.lastAdjustmentamount.Maxlength = 12
        Me.lastAdjustmentamount.MinusColor = System.Drawing.Color.Empty
        Me.lastAdjustmentamount.Name = "lastAdjustmentamount"
        Me.lastAdjustmentamount.ReadOnly = True
        Me.lastAdjustmentamount.Size = New System.Drawing.Size(72, 21)
        Me.lastAdjustmentamount.TabIndex = 460
        Me.lastAdjustmentamount.TabStop = False
        Me.lastAdjustmentamount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.lastAdjustmentamount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'UcCalcText1
        '
        Me.UcCalcText1.BackColor = System.Drawing.Color.Gold
        Me.UcCalcText1.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.UcCalcText1.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.UcCalcText1.DecimalDigits = 2
        Me.UcCalcText1.DefaultSendValue = False
        Me.UcCalcText1.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.UcCalcText1.FireTabAfterEnter = True
        Me.UcCalcText1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcCalcText1.Image = CType(resources.GetObject("UcCalcText1.Image"), System.Drawing.Image)
        Me.UcCalcText1.Location = New System.Drawing.Point(145, 64)
        Me.UcCalcText1.Maxlength = 12
        Me.UcCalcText1.MinusColor = System.Drawing.Color.Empty
        Me.UcCalcText1.Name = "UcCalcText1"
        Me.UcCalcText1.ReadOnly = True
        Me.UcCalcText1.Size = New System.Drawing.Size(72, 21)
        Me.UcCalcText1.TabIndex = 459
        Me.UcCalcText1.TabStop = False
        Me.UcCalcText1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.UcCalcText1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'lastreceiveamount
        '
        Me.lastreceiveamount.BackColor = System.Drawing.Color.Gold
        Me.lastreceiveamount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.lastreceiveamount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.lastreceiveamount.DecimalDigits = 2
        Me.lastreceiveamount.DefaultSendValue = False
        Me.lastreceiveamount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.lastreceiveamount.FireTabAfterEnter = True
        Me.lastreceiveamount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lastreceiveamount.Image = CType(resources.GetObject("lastreceiveamount.Image"), System.Drawing.Image)
        Me.lastreceiveamount.Location = New System.Drawing.Point(145, 44)
        Me.lastreceiveamount.Maxlength = 12
        Me.lastreceiveamount.MinusColor = System.Drawing.Color.Empty
        Me.lastreceiveamount.Name = "lastreceiveamount"
        Me.lastreceiveamount.ReadOnly = True
        Me.lastreceiveamount.Size = New System.Drawing.Size(72, 21)
        Me.lastreceiveamount.TabIndex = 458
        Me.lastreceiveamount.TabStop = False
        Me.lastreceiveamount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.lastreceiveamount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LastSaleAmount
        '
        Me.LastSaleAmount.BackColor = System.Drawing.Color.Gold
        Me.LastSaleAmount.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.LastSaleAmount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LastSaleAmount.DecimalDigits = 2
        Me.LastSaleAmount.DefaultSendValue = False
        Me.LastSaleAmount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LastSaleAmount.FireTabAfterEnter = True
        Me.LastSaleAmount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LastSaleAmount.Image = CType(resources.GetObject("LastSaleAmount.Image"), System.Drawing.Image)
        Me.LastSaleAmount.Location = New System.Drawing.Point(145, 22)
        Me.LastSaleAmount.Maxlength = 12
        Me.LastSaleAmount.MinusColor = System.Drawing.Color.Empty
        Me.LastSaleAmount.Name = "LastSaleAmount"
        Me.LastSaleAmount.ReadOnly = True
        Me.LastSaleAmount.Size = New System.Drawing.Size(72, 21)
        Me.LastSaleAmount.TabIndex = 457
        Me.LastSaleAmount.TabStop = False
        Me.LastSaleAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LastSaleAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'tXTDateCreated
        '
        Me.tXTDateCreated.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.tXTDateCreated.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.tXTDateCreated.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.tXTDateCreated.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.tXTDateCreated.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.tXTDateCreated.IncludeLiterals = False
        Me.tXTDateCreated.Location = New System.Drawing.Point(65, 126)
        Me.tXTDateCreated.MaxLength = 15
        Me.tXTDateCreated.Name = "tXTDateCreated"
        Me.tXTDateCreated.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.tXTDateCreated.ReadOnly = True
        Me.tXTDateCreated.Size = New System.Drawing.Size(72, 22)
        Me.tXTDateCreated.TabIndex = 29
        Me.tXTDateCreated.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'LastChangeDatePrice
        '
        Me.LastChangeDatePrice.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.LastChangeDatePrice.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.LastChangeDatePrice.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LastChangeDatePrice.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LastChangeDatePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LastChangeDatePrice.IncludeLiterals = False
        Me.LastChangeDatePrice.Location = New System.Drawing.Point(65, 106)
        Me.LastChangeDatePrice.MaxLength = 15
        Me.LastChangeDatePrice.Name = "LastChangeDatePrice"
        Me.LastChangeDatePrice.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.LastChangeDatePrice.ReadOnly = True
        Me.LastChangeDatePrice.Size = New System.Drawing.Size(72, 22)
        Me.LastChangeDatePrice.TabIndex = 28
        Me.LastChangeDatePrice.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'LastAdjustmentDate
        '
        Me.LastAdjustmentDate.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.LastAdjustmentDate.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.LastAdjustmentDate.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LastAdjustmentDate.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LastAdjustmentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LastAdjustmentDate.IncludeLiterals = False
        Me.LastAdjustmentDate.Location = New System.Drawing.Point(65, 85)
        Me.LastAdjustmentDate.MaxLength = 15
        Me.LastAdjustmentDate.Name = "LastAdjustmentDate"
        Me.LastAdjustmentDate.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.LastAdjustmentDate.ReadOnly = True
        Me.LastAdjustmentDate.Size = New System.Drawing.Size(72, 22)
        Me.LastAdjustmentDate.TabIndex = 27
        Me.LastAdjustmentDate.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'MaskedEditBox27
        '
        Me.MaskedEditBox27.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox27.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox27.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.MaskedEditBox27.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox27.IncludeLiterals = False
        Me.MaskedEditBox27.Location = New System.Drawing.Point(65, 65)
        Me.MaskedEditBox27.MaxLength = 15
        Me.MaskedEditBox27.Name = "MaskedEditBox27"
        Me.MaskedEditBox27.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.MaskedEditBox27.ReadOnly = True
        Me.MaskedEditBox27.Size = New System.Drawing.Size(72, 22)
        Me.MaskedEditBox27.TabIndex = 26
        Me.MaskedEditBox27.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'lastrecevieDate
        '
        Me.lastrecevieDate.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.lastrecevieDate.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.lastrecevieDate.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.lastrecevieDate.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lastrecevieDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lastrecevieDate.IncludeLiterals = False
        Me.lastrecevieDate.Location = New System.Drawing.Point(65, 45)
        Me.lastrecevieDate.MaxLength = 15
        Me.lastrecevieDate.Name = "lastrecevieDate"
        Me.lastrecevieDate.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.lastrecevieDate.ReadOnly = True
        Me.lastrecevieDate.Size = New System.Drawing.Size(72, 22)
        Me.lastrecevieDate.TabIndex = 25
        Me.lastrecevieDate.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'LastSaleDate
        '
        Me.LastSaleDate.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.LastSaleDate.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.LastSaleDate.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LastSaleDate.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LastSaleDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LastSaleDate.IncludeLiterals = False
        Me.LastSaleDate.Location = New System.Drawing.Point(65, 24)
        Me.LastSaleDate.MaxLength = 15
        Me.LastSaleDate.Name = "LastSaleDate"
        Me.LastSaleDate.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.LastSaleDate.ReadOnly = True
        Me.LastSaleDate.Size = New System.Drawing.Size(72, 22)
        Me.LastSaleDate.TabIndex = 24
        Me.LastSaleDate.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'Label59
        '
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label59.Location = New System.Drawing.Point(7, 131)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(53, 18)
        Me.Label59.TabIndex = 18
        Me.Label59.Text = "Created"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label58
        '
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label58.Location = New System.Drawing.Point(7, 108)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(53, 18)
        Me.Label58.TabIndex = 17
        Me.Label58.Text = "Price chg"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label57
        '
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label57.Location = New System.Drawing.Point(-3, 86)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(63, 19)
        Me.Label57.TabIndex = 16
        Me.Label57.Text = "Adjustment"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label56
        '
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label56.Location = New System.Drawing.Point(7, 66)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(53, 18)
        Me.Label56.TabIndex = 15
        Me.Label56.Text = "Count"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label36.Location = New System.Drawing.Point(7, 46)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(53, 18)
        Me.Label36.TabIndex = 14
        Me.Label36.Text = "Receive"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label37.Location = New System.Drawing.Point(8, 25)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(52, 18)
        Me.Label37.TabIndex = 13
        Me.Label37.Text = "Sale"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label38.Location = New System.Drawing.Point(146, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(72, 18)
        Me.Label38.TabIndex = 12
        Me.Label38.Text = "Amount"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label39.Location = New System.Drawing.Point(71, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(62, 18)
        Me.Label39.TabIndex = 11
        Me.Label39.Text = "Date"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Last"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'P3
        '
        Me.P3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P3.Controls.Add(Me.Plf6)
        Me.P3.Controls.Add(Me.Plf5)
        Me.P3.Controls.Add(Me.Plf4)
        Me.P3.Controls.Add(Me.Plf3)
        Me.P3.Controls.Add(Me.Plf2)
        Me.P3.Controls.Add(Me.Plf1)
        Me.P3.Controls.Add(Me.Pl6)
        Me.P3.Controls.Add(Me.Pl5)
        Me.P3.Controls.Add(Me.Pl4)
        Me.P3.Controls.Add(Me.Pl3)
        Me.P3.Controls.Add(Me.Pl2)
        Me.P3.Controls.Add(Me.Pl1)
        Me.P3.Controls.Add(Me.CmbPrice_Code)
        Me.P3.Controls.Add(Me.Label22)
        Me.P3.Controls.Add(Me.Label23)
        Me.P3.Controls.Add(Me.l6)
        Me.P3.Controls.Add(Me.l5)
        Me.P3.Controls.Add(Me.l4)
        Me.P3.Controls.Add(Me.l3)
        Me.P3.Controls.Add(Me.l2)
        Me.P3.Controls.Add(Me.l1)
        Me.P3.Location = New System.Drawing.Point(0, 180)
        Me.P3.Name = "P3"
        Me.P3.Size = New System.Drawing.Size(280, 169)
        Me.P3.TabIndex = 58
        '
        'Plf6
        '
        Me.Plf6.BackColor = System.Drawing.Color.Gold
        Me.Plf6.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Plf6.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Plf6.DecimalDigits = 2
        Me.Plf6.DefaultSendValue = False
        Me.Plf6.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Plf6.FireTabAfterEnter = True
        Me.Plf6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Plf6.Image = CType(resources.GetObject("Plf6.Image"), System.Drawing.Image)
        Me.Plf6.Location = New System.Drawing.Point(187, 142)
        Me.Plf6.Maxlength = 12
        Me.Plf6.MinusColor = System.Drawing.Color.Empty
        Me.Plf6.Name = "Plf6"
        Me.Plf6.ReadOnly = True
        Me.Plf6.Size = New System.Drawing.Size(88, 21)
        Me.Plf6.TabIndex = 461
        Me.Plf6.TabStop = False
        Me.Plf6.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Plf6.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Plf5
        '
        Me.Plf5.BackColor = System.Drawing.Color.Gold
        Me.Plf5.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Plf5.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Plf5.DecimalDigits = 2
        Me.Plf5.DefaultSendValue = False
        Me.Plf5.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Plf5.FireTabAfterEnter = True
        Me.Plf5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Plf5.Image = CType(resources.GetObject("Plf5.Image"), System.Drawing.Image)
        Me.Plf5.Location = New System.Drawing.Point(187, 120)
        Me.Plf5.Maxlength = 12
        Me.Plf5.MinusColor = System.Drawing.Color.Empty
        Me.Plf5.Name = "Plf5"
        Me.Plf5.ReadOnly = True
        Me.Plf5.Size = New System.Drawing.Size(88, 21)
        Me.Plf5.TabIndex = 460
        Me.Plf5.TabStop = False
        Me.Plf5.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Plf5.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Plf4
        '
        Me.Plf4.BackColor = System.Drawing.Color.Gold
        Me.Plf4.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Plf4.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Plf4.DecimalDigits = 2
        Me.Plf4.DefaultSendValue = False
        Me.Plf4.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Plf4.FireTabAfterEnter = True
        Me.Plf4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Plf4.Image = CType(resources.GetObject("Plf4.Image"), System.Drawing.Image)
        Me.Plf4.Location = New System.Drawing.Point(187, 98)
        Me.Plf4.Maxlength = 12
        Me.Plf4.MinusColor = System.Drawing.Color.Empty
        Me.Plf4.Name = "Plf4"
        Me.Plf4.ReadOnly = True
        Me.Plf4.Size = New System.Drawing.Size(88, 21)
        Me.Plf4.TabIndex = 459
        Me.Plf4.TabStop = False
        Me.Plf4.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Plf4.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Plf3
        '
        Me.Plf3.BackColor = System.Drawing.Color.Gold
        Me.Plf3.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Plf3.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Plf3.DecimalDigits = 2
        Me.Plf3.DefaultSendValue = False
        Me.Plf3.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Plf3.FireTabAfterEnter = True
        Me.Plf3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Plf3.Image = CType(resources.GetObject("Plf3.Image"), System.Drawing.Image)
        Me.Plf3.Location = New System.Drawing.Point(187, 75)
        Me.Plf3.Maxlength = 12
        Me.Plf3.MinusColor = System.Drawing.Color.Empty
        Me.Plf3.Name = "Plf3"
        Me.Plf3.ReadOnly = True
        Me.Plf3.Size = New System.Drawing.Size(88, 21)
        Me.Plf3.TabIndex = 458
        Me.Plf3.TabStop = False
        Me.Plf3.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Plf3.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Plf2
        '
        Me.Plf2.BackColor = System.Drawing.Color.Gold
        Me.Plf2.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Plf2.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Plf2.DecimalDigits = 2
        Me.Plf2.DefaultSendValue = False
        Me.Plf2.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Plf2.FireTabAfterEnter = True
        Me.Plf2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Plf2.Image = CType(resources.GetObject("Plf2.Image"), System.Drawing.Image)
        Me.Plf2.Location = New System.Drawing.Point(187, 53)
        Me.Plf2.Maxlength = 12
        Me.Plf2.MinusColor = System.Drawing.Color.Empty
        Me.Plf2.Name = "Plf2"
        Me.Plf2.ReadOnly = True
        Me.Plf2.Size = New System.Drawing.Size(88, 21)
        Me.Plf2.TabIndex = 457
        Me.Plf2.TabStop = False
        Me.Plf2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Plf2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Plf1
        '
        Me.Plf1.BackColor = System.Drawing.Color.Gold
        Me.Plf1.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Plf1.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Plf1.DecimalDigits = 2
        Me.Plf1.DefaultSendValue = False
        Me.Plf1.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Plf1.FireTabAfterEnter = True
        Me.Plf1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Plf1.Image = CType(resources.GetObject("Plf1.Image"), System.Drawing.Image)
        Me.Plf1.Location = New System.Drawing.Point(187, 31)
        Me.Plf1.Maxlength = 12
        Me.Plf1.MinusColor = System.Drawing.Color.Empty
        Me.Plf1.Name = "Plf1"
        Me.Plf1.ReadOnly = True
        Me.Plf1.Size = New System.Drawing.Size(88, 21)
        Me.Plf1.TabIndex = 456
        Me.Plf1.TabStop = False
        Me.Plf1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Plf1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Pl6
        '
        Me.Pl6.BackColor = System.Drawing.Color.Gold
        Me.Pl6.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Pl6.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Pl6.DecimalDigits = 2
        Me.Pl6.DefaultSendValue = False
        Me.Pl6.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Pl6.FireTabAfterEnter = True
        Me.Pl6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Pl6.Image = CType(resources.GetObject("Pl6.Image"), System.Drawing.Image)
        Me.Pl6.Location = New System.Drawing.Point(96, 142)
        Me.Pl6.Maxlength = 12
        Me.Pl6.MinusColor = System.Drawing.Color.Empty
        Me.Pl6.Name = "Pl6"
        Me.Pl6.ReadOnly = True
        Me.Pl6.Size = New System.Drawing.Size(88, 21)
        Me.Pl6.TabIndex = 455
        Me.Pl6.TabStop = False
        Me.Pl6.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Pl6.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Pl5
        '
        Me.Pl5.BackColor = System.Drawing.Color.Gold
        Me.Pl5.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Pl5.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Pl5.DecimalDigits = 2
        Me.Pl5.DefaultSendValue = False
        Me.Pl5.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Pl5.FireTabAfterEnter = True
        Me.Pl5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Pl5.Image = CType(resources.GetObject("Pl5.Image"), System.Drawing.Image)
        Me.Pl5.Location = New System.Drawing.Point(96, 120)
        Me.Pl5.Maxlength = 12
        Me.Pl5.MinusColor = System.Drawing.Color.Empty
        Me.Pl5.Name = "Pl5"
        Me.Pl5.ReadOnly = True
        Me.Pl5.Size = New System.Drawing.Size(88, 21)
        Me.Pl5.TabIndex = 454
        Me.Pl5.TabStop = False
        Me.Pl5.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Pl5.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Pl4
        '
        Me.Pl4.BackColor = System.Drawing.Color.Gold
        Me.Pl4.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Pl4.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Pl4.DecimalDigits = 2
        Me.Pl4.DefaultSendValue = False
        Me.Pl4.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Pl4.FireTabAfterEnter = True
        Me.Pl4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Pl4.Image = CType(resources.GetObject("Pl4.Image"), System.Drawing.Image)
        Me.Pl4.Location = New System.Drawing.Point(96, 98)
        Me.Pl4.Maxlength = 12
        Me.Pl4.MinusColor = System.Drawing.Color.Empty
        Me.Pl4.Name = "Pl4"
        Me.Pl4.ReadOnly = True
        Me.Pl4.Size = New System.Drawing.Size(88, 21)
        Me.Pl4.TabIndex = 453
        Me.Pl4.TabStop = False
        Me.Pl4.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Pl4.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Pl3
        '
        Me.Pl3.BackColor = System.Drawing.Color.Gold
        Me.Pl3.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Pl3.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Pl3.DecimalDigits = 2
        Me.Pl3.DefaultSendValue = False
        Me.Pl3.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Pl3.FireTabAfterEnter = True
        Me.Pl3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Pl3.Image = CType(resources.GetObject("Pl3.Image"), System.Drawing.Image)
        Me.Pl3.Location = New System.Drawing.Point(96, 75)
        Me.Pl3.Maxlength = 12
        Me.Pl3.MinusColor = System.Drawing.Color.Empty
        Me.Pl3.Name = "Pl3"
        Me.Pl3.ReadOnly = True
        Me.Pl3.Size = New System.Drawing.Size(88, 21)
        Me.Pl3.TabIndex = 452
        Me.Pl3.TabStop = False
        Me.Pl3.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Pl3.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Pl2
        '
        Me.Pl2.BackColor = System.Drawing.Color.Gold
        Me.Pl2.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Pl2.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Pl2.DecimalDigits = 2
        Me.Pl2.DefaultSendValue = False
        Me.Pl2.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Pl2.FireTabAfterEnter = True
        Me.Pl2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Pl2.Image = CType(resources.GetObject("Pl2.Image"), System.Drawing.Image)
        Me.Pl2.Location = New System.Drawing.Point(96, 53)
        Me.Pl2.Maxlength = 12
        Me.Pl2.MinusColor = System.Drawing.Color.Empty
        Me.Pl2.Name = "Pl2"
        Me.Pl2.ReadOnly = True
        Me.Pl2.Size = New System.Drawing.Size(88, 21)
        Me.Pl2.TabIndex = 451
        Me.Pl2.TabStop = False
        Me.Pl2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Pl2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Pl1
        '
        Me.Pl1.BackColor = System.Drawing.Color.Gold
        Me.Pl1.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Pl1.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Pl1.DecimalDigits = 2
        Me.Pl1.DefaultSendValue = False
        Me.Pl1.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Pl1.FireTabAfterEnter = True
        Me.Pl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Pl1.Image = CType(resources.GetObject("Pl1.Image"), System.Drawing.Image)
        Me.Pl1.Location = New System.Drawing.Point(96, 31)
        Me.Pl1.Maxlength = 12
        Me.Pl1.MinusColor = System.Drawing.Color.Empty
        Me.Pl1.Name = "Pl1"
        Me.Pl1.ReadOnly = True
        Me.Pl1.Size = New System.Drawing.Size(88, 21)
        Me.Pl1.TabIndex = 450
        Me.Pl1.TabStop = False
        Me.Pl1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Pl1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'CmbPrice_Code
        '
        Me.CmbPrice_Code.DataSource = Me.DsInvItemProduct1.inv_price_code
        Me.CmbPrice_Code.DisplayMember = "desc_price_code"
        Me.CmbPrice_Code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice_Code.Location = New System.Drawing.Point(77, 1)
        Me.CmbPrice_Code.Name = "CmbPrice_Code"
        Me.CmbPrice_Code.Size = New System.Drawing.Size(120, 21)
        Me.CmbPrice_Code.TabIndex = 26
        Me.CmbPrice_Code.ValueMember = "price_code"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Navy
        Me.Label22.Location = New System.Drawing.Point(5, 1)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 22)
        Me.Label22.TabIndex = 34
        Me.Label22.Text = "Price Code"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(197, 1)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 22)
        Me.Label23.TabIndex = 33
        Me.Label23.Text = "Price+FET"
        '
        'l6
        '
        Me.l6.BackColor = System.Drawing.Color.Salmon
        Me.l6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.l6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.l6.ForeColor = System.Drawing.Color.Gold
        Me.l6.Location = New System.Drawing.Point(2, 141)
        Me.l6.Name = "l6"
        Me.l6.Size = New System.Drawing.Size(91, 23)
        Me.l6.TabIndex = 31
        Me.l6.Text = "Price Level 6"
        Me.l6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'l5
        '
        Me.l5.BackColor = System.Drawing.Color.Salmon
        Me.l5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.l5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.l5.ForeColor = System.Drawing.Color.Gold
        Me.l5.Location = New System.Drawing.Point(2, 119)
        Me.l5.Name = "l5"
        Me.l5.Size = New System.Drawing.Size(91, 23)
        Me.l5.TabIndex = 30
        Me.l5.Text = "Price Level 5"
        Me.l5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'l4
        '
        Me.l4.BackColor = System.Drawing.Color.Salmon
        Me.l4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.l4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.l4.ForeColor = System.Drawing.Color.Gold
        Me.l4.Location = New System.Drawing.Point(2, 97)
        Me.l4.Name = "l4"
        Me.l4.Size = New System.Drawing.Size(91, 23)
        Me.l4.TabIndex = 29
        Me.l4.Text = "Price Level 4"
        Me.l4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'l3
        '
        Me.l3.BackColor = System.Drawing.Color.Salmon
        Me.l3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.l3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.l3.ForeColor = System.Drawing.Color.Gold
        Me.l3.Location = New System.Drawing.Point(2, 74)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(91, 23)
        Me.l3.TabIndex = 28
        Me.l3.Text = "Price Level 3"
        Me.l3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'l2
        '
        Me.l2.BackColor = System.Drawing.Color.Salmon
        Me.l2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.l2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.l2.ForeColor = System.Drawing.Color.Gold
        Me.l2.Location = New System.Drawing.Point(2, 52)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(91, 23)
        Me.l2.TabIndex = 27
        Me.l2.Text = "Price Level 2"
        Me.l2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'l1
        '
        Me.l1.BackColor = System.Drawing.Color.Salmon
        Me.l1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.l1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.l1.ForeColor = System.Drawing.Color.Gold
        Me.l1.Location = New System.Drawing.Point(2, 30)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(91, 23)
        Me.l1.TabIndex = 26
        Me.l1.Text = "Price Level 1"
        Me.l1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'P2
        '
        Me.P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P2.Controls.Add(Me.WorkOrderOfItem1)
        Me.P2.Controls.Add(Me.TxtReorder)
        Me.P2.Controls.Add(Me.TxtMax_stock)
        Me.P2.Controls.Add(Me.TxtMin_stock)
        Me.P2.Controls.Add(Me.TxtOnOrder)
        Me.P2.Controls.Add(Me.TxtAvailable)
        Me.P2.Controls.Add(Me.TxtComitted)
        Me.P2.Controls.Add(Me.TxtOnHand)
        Me.P2.Controls.Add(Me.Label31)
        Me.P2.Controls.Add(Me.Label30)
        Me.P2.Controls.Add(Me.Label29)
        Me.P2.Controls.Add(Me.Label28)
        Me.P2.Controls.Add(Me.Label27)
        Me.P2.Controls.Add(Me.Label26)
        Me.P2.Controls.Add(Me.Label62)
        Me.P2.Controls.Add(Me.Label63)
        Me.P2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.P2.Location = New System.Drawing.Point(549, 1)
        Me.P2.Name = "P2"
        Me.P2.Size = New System.Drawing.Size(160, 177)
        Me.P2.TabIndex = 1
        '
        'WorkOrderOfItem1
        '
        Me.WorkOrderOfItem1.Connection = Me.Cnn
        Me.WorkOrderOfItem1.Item_no = ""
        Me.WorkOrderOfItem1.Location = New System.Drawing.Point(128, 37)
        Me.WorkOrderOfItem1.Name = "WorkOrderOfItem1"
        Me.WorkOrderOfItem1.Size = New System.Drawing.Size(24, 22)
        Me.WorkOrderOfItem1.TabIndex = 19
        '
        'TxtReorder
        '
        Me.TxtReorder.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtReorder.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtReorder.DecimalDigits = 2
        Me.TxtReorder.DefaultSendValue = False
        Me.TxtReorder.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtReorder.FireTabAfterEnter = True
        Me.TxtReorder.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtReorder.Image = CType(resources.GetObject("TxtReorder.Image"), System.Drawing.Image)
        Me.TxtReorder.Location = New System.Drawing.Point(79, 141)
        Me.TxtReorder.Maxlength = 12
        Me.TxtReorder.MinusColor = System.Drawing.Color.Empty
        Me.TxtReorder.Name = "TxtReorder"
        Me.TxtReorder.Size = New System.Drawing.Size(64, 22)
        Me.TxtReorder.TabIndex = 29
        Me.TxtReorder.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtReorder.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtMax_stock
        '
        Me.TxtMax_stock.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtMax_stock.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtMax_stock.DecimalDigits = 2
        Me.TxtMax_stock.DefaultSendValue = False
        Me.TxtMax_stock.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtMax_stock.FireTabAfterEnter = True
        Me.TxtMax_stock.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtMax_stock.Image = CType(resources.GetObject("TxtMax_stock.Image"), System.Drawing.Image)
        Me.TxtMax_stock.Location = New System.Drawing.Point(79, 122)
        Me.TxtMax_stock.Maxlength = 12
        Me.TxtMax_stock.MinusColor = System.Drawing.Color.Empty
        Me.TxtMax_stock.Name = "TxtMax_stock"
        Me.TxtMax_stock.Size = New System.Drawing.Size(64, 22)
        Me.TxtMax_stock.TabIndex = 28
        Me.TxtMax_stock.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtMax_stock.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtMin_stock
        '
        Me.TxtMin_stock.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtMin_stock.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtMin_stock.DecimalDigits = 2
        Me.TxtMin_stock.DefaultSendValue = False
        Me.TxtMin_stock.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtMin_stock.FireTabAfterEnter = True
        Me.TxtMin_stock.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtMin_stock.Image = CType(resources.GetObject("TxtMin_stock.Image"), System.Drawing.Image)
        Me.TxtMin_stock.Location = New System.Drawing.Point(79, 101)
        Me.TxtMin_stock.Maxlength = 12
        Me.TxtMin_stock.MinusColor = System.Drawing.Color.Empty
        Me.TxtMin_stock.Name = "TxtMin_stock"
        Me.TxtMin_stock.Size = New System.Drawing.Size(64, 22)
        Me.TxtMin_stock.TabIndex = 27
        Me.TxtMin_stock.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtMin_stock.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtOnOrder
        '
        Me.TxtOnOrder.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtOnOrder.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtOnOrder.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.TxtOnOrder.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtOnOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtOnOrder.IncludeLiterals = False
        Me.TxtOnOrder.Location = New System.Drawing.Point(78, 81)
        Me.TxtOnOrder.MaxLength = 15
        Me.TxtOnOrder.Name = "TxtOnOrder"
        Me.TxtOnOrder.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtOnOrder.ReadOnly = True
        Me.TxtOnOrder.Size = New System.Drawing.Size(50, 22)
        Me.TxtOnOrder.TabIndex = 18
        Me.TxtOnOrder.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtAvailable
        '
        Me.TxtAvailable.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtAvailable.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtAvailable.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.TxtAvailable.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtAvailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtAvailable.IncludeLiterals = False
        Me.TxtAvailable.Location = New System.Drawing.Point(78, 59)
        Me.TxtAvailable.MaxLength = 15
        Me.TxtAvailable.Name = "TxtAvailable"
        Me.TxtAvailable.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtAvailable.ReadOnly = True
        Me.TxtAvailable.Size = New System.Drawing.Size(50, 22)
        Me.TxtAvailable.TabIndex = 17
        Me.TxtAvailable.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtComitted
        '
        Me.TxtComitted.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtComitted.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtComitted.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.TxtComitted.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtComitted.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtComitted.IncludeLiterals = False
        Me.TxtComitted.Location = New System.Drawing.Point(78, 37)
        Me.TxtComitted.MaxLength = 15
        Me.TxtComitted.Name = "TxtComitted"
        Me.TxtComitted.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtComitted.ReadOnly = True
        Me.TxtComitted.Size = New System.Drawing.Size(50, 22)
        Me.TxtComitted.TabIndex = 16
        Me.TxtComitted.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtOnHand
        '
        Me.TxtOnHand.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtOnHand.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtOnHand.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.TxtOnHand.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtOnHand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtOnHand.IncludeLiterals = False
        Me.TxtOnHand.Location = New System.Drawing.Point(78, 15)
        Me.TxtOnHand.MaxLength = 15
        Me.TxtOnHand.Name = "TxtOnHand"
        Me.TxtOnHand.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtOnHand.ReadOnly = True
        Me.TxtOnHand.Size = New System.Drawing.Size(50, 22)
        Me.TxtOnHand.TabIndex = 15
        Me.TxtOnHand.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label31.Location = New System.Drawing.Point(72, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(64, 18)
        Me.Label31.TabIndex = 7
        Me.Label31.Text = "   QTY   "
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(6, 140)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(64, 23)
        Me.Label30.TabIndex = 6
        Me.Label30.Text = "ReOrder"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(6, 122)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(64, 22)
        Me.Label29.TabIndex = 5
        Me.Label29.Text = "Max Stock"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(6, 101)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(64, 23)
        Me.Label28.TabIndex = 4
        Me.Label28.Text = "Min Stock"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(6, 83)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 23)
        Me.Label27.TabIndex = 3
        Me.Label27.Text = "On Order"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(5, 60)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 24)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Available"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label62
        '
        Me.Label62.Location = New System.Drawing.Point(9, 38)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(61, 23)
        Me.Label62.TabIndex = 1
        Me.Label62.Text = "Committed"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label63
        '
        Me.Label63.Location = New System.Drawing.Point(14, 16)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(56, 23)
        Me.Label63.TabIndex = 0
        Me.Label63.Text = "On Hand"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'P1
        '
        Me.P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P1.Controls.Add(Me.Line1)
        Me.P1.Controls.Add(Me.BtnVendor)
        Me.P1.Controls.Add(Me.LblQref)
        Me.P1.Controls.Add(Me.QuickReference1)
        Me.P1.Controls.Add(Me.InvLine_Detail1)
        Me.P1.Controls.Add(Me.TxtEnd_date_spiff)
        Me.P1.Controls.Add(Me.TxtEnd_Date_Contract)
        Me.P1.Controls.Add(Me.TxtEnd_date_on_sale)
        Me.P1.Controls.Add(Me.Txtstart_date_spiff)
        Me.P1.Controls.Add(Me.TxtStart_Date_Contract)
        Me.P1.Controls.Add(Me.TxtStart_date_on_sale)
        Me.P1.Controls.Add(Me.PictureButton1)
        Me.P1.Controls.Add(Me.CmdLoad)
        Me.P1.Controls.Add(Me.TxtStyle)
        Me.P1.Controls.Add(Me.TxtBrand)
        Me.P1.Controls.Add(Me.CmbBinLocation)
        Me.P1.Controls.Add(Me.TxtListPrice)
        Me.P1.Controls.Add(Me.TxtFet)
        Me.P1.Controls.Add(Me.TxtCost)
        Me.P1.Controls.Add(Me.TxtAmount_Spiff)
        Me.P1.Controls.Add(Me.Txtamount_contract)
        Me.P1.Controls.Add(Me.Label19)
        Me.P1.Controls.Add(Me.Label18)
        Me.P1.Controls.Add(Me.Label17)
        Me.P1.Controls.Add(Me.TxtAmount_Onsale)
        Me.P1.Controls.Add(Me.ChkSpiff)
        Me.P1.Controls.Add(Me.ChkContract)
        Me.P1.Controls.Add(Me.ChkOnSale)
        Me.P1.Controls.Add(Me.Label16)
        Me.P1.Controls.Add(Me.Label15)
        Me.P1.Controls.Add(Me.TxtUpc)
        Me.P1.Controls.Add(Me.Label14)
        Me.P1.Controls.Add(Me.Label13)
        Me.P1.Controls.Add(Me.Label10)
        Me.P1.Controls.Add(Me.Label9)
        Me.P1.Controls.Add(Me.Label7)
        Me.P1.Controls.Add(Me.Label6)
        Me.P1.Controls.Add(Me.TxtDesc_Item)
        Me.P1.Controls.Add(Me.Label24)
        Me.P1.Controls.Add(Me.BtnNotes)
        Me.P1.Controls.Add(Me.BtnHistory)
        Me.P1.Controls.Add(Me.Label8)
        Me.P1.Controls.Add(Me.ChkTaxable)
        Me.P1.Location = New System.Drawing.Point(5, 1)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(539, 177)
        Me.P1.TabIndex = 0
        '
        'Line1
        '
        Me.Line1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Line1.Connection = Me.Cnn
        Me.Line1.LineCod = ""
        Me.Line1.LineCodLen = 30
        Me.Line1.Location = New System.Drawing.Point(281, 67)
        Me.Line1.Name = "Line1"
        Me.Line1.NotExitIfNotFound = False
        Me.Line1.ReleaseIfNotFoundLineCod = False
        Me.Line1.Size = New System.Drawing.Size(167, 20)
        Me.Line1.TabIndex = 65
        '
        'BtnVendor
        '
        Me.BtnVendor.Location = New System.Drawing.Point(474, 65)
        Me.BtnVendor.Name = "BtnVendor"
        Me.BtnVendor.Size = New System.Drawing.Size(60, 22)
        Me.BtnVendor.TabIndex = 64
        Me.BtnVendor.Text = "Vendors"
        '
        'LblQref
        '
        Me.LblQref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblQref.Location = New System.Drawing.Point(385, 45)
        Me.LblQref.Name = "LblQref"
        Me.LblQref.Size = New System.Drawing.Size(147, 19)
        Me.LblQref.TabIndex = 63
        '
        'QuickReference1
        '
        Me.QuickReference1.Cnn = Me.Cnn
        Me.QuickReference1.FieldCodValue = ""
        Me.QuickReference1.Location = New System.Drawing.Point(280, 45)
        Me.QuickReference1.Name = "QuickReference1"
        Me.QuickReference1.ReadOnlyText = True
        Me.QuickReference1.Size = New System.Drawing.Size(105, 19)
        Me.QuickReference1.TabIndex = 10
        Me.QuickReference1.TxtBackColor = System.Drawing.Color.YellowGreen
        Me.QuickReference1.TxtForeColor = System.Drawing.SystemColors.WindowText
        Me.QuickReference1.TxtRightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'InvLine_Detail1
        '
        Me.InvLine_Detail1.Connection = Me.Cnn
        Me.InvLine_Detail1.Line = ""
        Me.InvLine_Detail1.Location = New System.Drawing.Point(451, 65)
        Me.InvLine_Detail1.Name = "InvLine_Detail1"
        Me.InvLine_Detail1.Size = New System.Drawing.Size(24, 22)
        Me.InvLine_Detail1.TabIndex = 12
        '
        'TxtEnd_date_spiff
        '
        Me.TxtEnd_date_spiff.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtEnd_date_spiff.BorderColor = System.Drawing.Color.Empty
        Me.TxtEnd_date_spiff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtEnd_date_spiff.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtEnd_date_spiff.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtEnd_date_spiff.EditableSal = True
        Me.TxtEnd_date_spiff.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtEnd_date_spiff.Image = CType(resources.GetObject("TxtEnd_date_spiff.Image"), System.Drawing.Image)
        Me.TxtEnd_date_spiff.Location = New System.Drawing.Point(359, 153)
        Me.TxtEnd_date_spiff.MaxValue = CType(2500, Short)
        Me.TxtEnd_date_spiff.MinValue = CType(1800, Short)
        Me.TxtEnd_date_spiff.Name = "TxtEnd_date_spiff"
        Me.TxtEnd_date_spiff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtEnd_date_spiff.Sal_Mali = Nothing
        Me.TxtEnd_date_spiff.ShowButton = True
        Me.TxtEnd_date_spiff.Size = New System.Drawing.Size(95, 19)
        Me.TxtEnd_date_spiff.TabIndex = 24
        Me.TxtEnd_date_spiff.VisualStyle = False
        '
        'TxtEnd_Date_Contract
        '
        Me.TxtEnd_Date_Contract.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtEnd_Date_Contract.BorderColor = System.Drawing.Color.Empty
        Me.TxtEnd_Date_Contract.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtEnd_Date_Contract.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtEnd_Date_Contract.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtEnd_Date_Contract.EditableSal = True
        Me.TxtEnd_Date_Contract.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtEnd_Date_Contract.Image = CType(resources.GetObject("TxtEnd_Date_Contract.Image"), System.Drawing.Image)
        Me.TxtEnd_Date_Contract.Location = New System.Drawing.Point(359, 132)
        Me.TxtEnd_Date_Contract.MaxValue = CType(2500, Short)
        Me.TxtEnd_Date_Contract.MinValue = CType(1800, Short)
        Me.TxtEnd_Date_Contract.Name = "TxtEnd_Date_Contract"
        Me.TxtEnd_Date_Contract.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtEnd_Date_Contract.Sal_Mali = Nothing
        Me.TxtEnd_Date_Contract.ShowButton = True
        Me.TxtEnd_Date_Contract.Size = New System.Drawing.Size(95, 19)
        Me.TxtEnd_Date_Contract.TabIndex = 21
        Me.TxtEnd_Date_Contract.VisualStyle = False
        '
        'TxtEnd_date_on_sale
        '
        Me.TxtEnd_date_on_sale.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtEnd_date_on_sale.BorderColor = System.Drawing.Color.Empty
        Me.TxtEnd_date_on_sale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtEnd_date_on_sale.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtEnd_date_on_sale.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtEnd_date_on_sale.EditableSal = True
        Me.TxtEnd_date_on_sale.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtEnd_date_on_sale.Image = CType(resources.GetObject("TxtEnd_date_on_sale.Image"), System.Drawing.Image)
        Me.TxtEnd_date_on_sale.Location = New System.Drawing.Point(359, 110)
        Me.TxtEnd_date_on_sale.MaxValue = CType(2500, Short)
        Me.TxtEnd_date_on_sale.MinValue = CType(1800, Short)
        Me.TxtEnd_date_on_sale.Name = "TxtEnd_date_on_sale"
        Me.TxtEnd_date_on_sale.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtEnd_date_on_sale.Sal_Mali = Nothing
        Me.TxtEnd_date_on_sale.ShowButton = True
        Me.TxtEnd_date_on_sale.Size = New System.Drawing.Size(95, 19)
        Me.TxtEnd_date_on_sale.TabIndex = 17
        Me.TxtEnd_date_on_sale.VisualStyle = False
        '
        'Txtstart_date_spiff
        '
        Me.Txtstart_date_spiff.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txtstart_date_spiff.BorderColor = System.Drawing.Color.Empty
        Me.Txtstart_date_spiff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Txtstart_date_spiff.ButtonBackColor = System.Drawing.Color.Empty
        Me.Txtstart_date_spiff.ButtonForeColor = System.Drawing.Color.Empty
        Me.Txtstart_date_spiff.EditableSal = True
        Me.Txtstart_date_spiff.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Txtstart_date_spiff.Image = CType(resources.GetObject("Txtstart_date_spiff.Image"), System.Drawing.Image)
        Me.Txtstart_date_spiff.Location = New System.Drawing.Point(263, 153)
        Me.Txtstart_date_spiff.MaxValue = CType(2500, Short)
        Me.Txtstart_date_spiff.MinValue = CType(1800, Short)
        Me.Txtstart_date_spiff.Name = "Txtstart_date_spiff"
        Me.Txtstart_date_spiff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txtstart_date_spiff.Sal_Mali = Nothing
        Me.Txtstart_date_spiff.ShowButton = True
        Me.Txtstart_date_spiff.Size = New System.Drawing.Size(95, 19)
        Me.Txtstart_date_spiff.TabIndex = 23
        Me.Txtstart_date_spiff.VisualStyle = False
        '
        'TxtStart_Date_Contract
        '
        Me.TxtStart_Date_Contract.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtStart_Date_Contract.BorderColor = System.Drawing.Color.Empty
        Me.TxtStart_Date_Contract.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtStart_Date_Contract.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtStart_Date_Contract.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtStart_Date_Contract.EditableSal = True
        Me.TxtStart_Date_Contract.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtStart_Date_Contract.Image = CType(resources.GetObject("TxtStart_Date_Contract.Image"), System.Drawing.Image)
        Me.TxtStart_Date_Contract.Location = New System.Drawing.Point(263, 132)
        Me.TxtStart_Date_Contract.MaxValue = CType(2500, Short)
        Me.TxtStart_Date_Contract.MinValue = CType(1800, Short)
        Me.TxtStart_Date_Contract.Name = "TxtStart_Date_Contract"
        Me.TxtStart_Date_Contract.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtStart_Date_Contract.Sal_Mali = Nothing
        Me.TxtStart_Date_Contract.ShowButton = True
        Me.TxtStart_Date_Contract.Size = New System.Drawing.Size(95, 19)
        Me.TxtStart_Date_Contract.TabIndex = 20
        Me.TxtStart_Date_Contract.VisualStyle = False
        '
        'TxtStart_date_on_sale
        '
        Me.TxtStart_date_on_sale.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtStart_date_on_sale.BorderColor = System.Drawing.Color.Empty
        Me.TxtStart_date_on_sale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtStart_date_on_sale.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtStart_date_on_sale.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtStart_date_on_sale.EditableSal = True
        Me.TxtStart_date_on_sale.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtStart_date_on_sale.Image = CType(resources.GetObject("TxtStart_date_on_sale.Image"), System.Drawing.Image)
        Me.TxtStart_date_on_sale.Location = New System.Drawing.Point(263, 110)
        Me.TxtStart_date_on_sale.MaxValue = CType(2500, Short)
        Me.TxtStart_date_on_sale.MinValue = CType(1800, Short)
        Me.TxtStart_date_on_sale.Name = "TxtStart_date_on_sale"
        Me.TxtStart_date_on_sale.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtStart_date_on_sale.Sal_Mali = Nothing
        Me.TxtStart_date_on_sale.ShowButton = True
        Me.TxtStart_date_on_sale.Size = New System.Drawing.Size(95, 19)
        Me.TxtStart_date_on_sale.TabIndex = 14
        Me.TxtStart_date_on_sale.VisualStyle = False
        '
        'PictureButton1
        '
        Me.PictureButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PictureButton1.Location = New System.Drawing.Point(114, 141)
        Me.PictureButton1.MyPicture = Nothing
        Me.PictureButton1.Name = "PictureButton1"
        Me.PictureButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PictureButton1.Size = New System.Drawing.Size(78, 21)
        Me.PictureButton1.TabIndex = 61
        '
        'CmdLoad
        '
        Me.CmdLoad.Location = New System.Drawing.Point(504, 0)
        Me.CmdLoad.Name = "CmdLoad"
        Me.CmdLoad.Size = New System.Drawing.Size(24, 21)
        Me.CmdLoad.TabIndex = 5
        Me.CmdLoad.Text = "<<"
        '
        'TxtStyle
        '
        Me.TxtStyle.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtStyle.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtStyle.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.TxtStyle.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtStyle.Enabled = False
        Me.TxtStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtStyle.IncludeLiterals = False
        Me.TxtStyle.Location = New System.Drawing.Point(72, 67)
        Me.TxtStyle.MaxLength = 15
        Me.TxtStyle.Name = "TxtStyle"
        Me.TxtStyle.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtStyle.ReadOnly = True
        Me.TxtStyle.Size = New System.Drawing.Size(120, 22)
        Me.TxtStyle.TabIndex = 59
        Me.TxtStyle.TabStop = False
        Me.TxtStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtBrand
        '
        Me.TxtBrand.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtBrand.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtBrand.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.TxtBrand.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtBrand.Enabled = False
        Me.TxtBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtBrand.IncludeLiterals = False
        Me.TxtBrand.Location = New System.Drawing.Point(72, 45)
        Me.TxtBrand.MaxLength = 15
        Me.TxtBrand.Name = "TxtBrand"
        Me.TxtBrand.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtBrand.ReadOnly = True
        Me.TxtBrand.Size = New System.Drawing.Size(120, 22)
        Me.TxtBrand.TabIndex = 58
        Me.TxtBrand.TabStop = False
        Me.TxtBrand.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'CmbBinLocation
        '
        Me.CmbBinLocation.DataSource = Me.DsInvItemProduct1.inv_tab_location_warehouse
        Me.CmbBinLocation.DisplayMember = "cod_location"
        Me.CmbBinLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBinLocation.Location = New System.Drawing.Point(72, 111)
        Me.CmbBinLocation.Name = "CmbBinLocation"
        Me.CmbBinLocation.Size = New System.Drawing.Size(120, 21)
        Me.CmbBinLocation.TabIndex = 14
        Me.CmbBinLocation.ValueMember = "cod_location"
        '
        'TxtListPrice
        '
        Me.TxtListPrice.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtListPrice.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtListPrice.DecimalDigits = 2
        Me.TxtListPrice.DefaultSendValue = False
        Me.TxtListPrice.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtListPrice.FireTabAfterEnter = True
        Me.TxtListPrice.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtListPrice.Image = CType(resources.GetObject("TxtListPrice.Image"), System.Drawing.Image)
        Me.TxtListPrice.Location = New System.Drawing.Point(360, 22)
        Me.TxtListPrice.Maxlength = 12
        Me.TxtListPrice.MinusColor = System.Drawing.Color.Empty
        Me.TxtListPrice.Name = "TxtListPrice"
        Me.TxtListPrice.Size = New System.Drawing.Size(112, 22)
        Me.TxtListPrice.TabIndex = 8
        Me.TxtListPrice.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtListPrice.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtFet
        '
        Me.TxtFet.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtFet.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtFet.DecimalDigits = 2
        Me.TxtFet.DefaultSendValue = False
        Me.TxtFet.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtFet.FireTabAfterEnter = True
        Me.TxtFet.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtFet.Image = CType(resources.GetObject("TxtFet.Image"), System.Drawing.Image)
        Me.TxtFet.Location = New System.Drawing.Point(216, 22)
        Me.TxtFet.Maxlength = 12
        Me.TxtFet.MinusColor = System.Drawing.Color.Empty
        Me.TxtFet.Name = "TxtFet"
        Me.TxtFet.Size = New System.Drawing.Size(80, 22)
        Me.TxtFet.TabIndex = 7
        Me.TxtFet.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtFet.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtCost
        '
        Me.TxtCost.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtCost.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtCost.DecimalDigits = 2
        Me.TxtCost.DefaultSendValue = False
        Me.TxtCost.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtCost.FireTabAfterEnter = True
        Me.TxtCost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtCost.Image = CType(resources.GetObject("TxtCost.Image"), System.Drawing.Image)
        Me.TxtCost.Location = New System.Drawing.Point(72, 23)
        Me.TxtCost.Maxlength = 12
        Me.TxtCost.MinusColor = System.Drawing.Color.Empty
        Me.TxtCost.Name = "TxtCost"
        Me.TxtCost.Size = New System.Drawing.Size(120, 22)
        Me.TxtCost.TabIndex = 6
        Me.TxtCost.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtCost.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtAmount_Spiff
        '
        Me.TxtAmount_Spiff.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtAmount_Spiff.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtAmount_Spiff.DecimalDigits = 2
        Me.TxtAmount_Spiff.DefaultSendValue = False
        Me.TxtAmount_Spiff.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtAmount_Spiff.FireTabAfterEnter = True
        Me.TxtAmount_Spiff.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtAmount_Spiff.Image = CType(resources.GetObject("TxtAmount_Spiff.Image"), System.Drawing.Image)
        Me.TxtAmount_Spiff.Location = New System.Drawing.Point(456, 151)
        Me.TxtAmount_Spiff.Maxlength = 12
        Me.TxtAmount_Spiff.MinusColor = System.Drawing.Color.Empty
        Me.TxtAmount_Spiff.Name = "TxtAmount_Spiff"
        Me.TxtAmount_Spiff.Size = New System.Drawing.Size(80, 22)
        Me.TxtAmount_Spiff.TabIndex = 25
        Me.TxtAmount_Spiff.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtAmount_Spiff.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Txtamount_contract
        '
        Me.Txtamount_contract.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Txtamount_contract.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Txtamount_contract.DecimalDigits = 2
        Me.Txtamount_contract.DefaultSendValue = False
        Me.Txtamount_contract.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Txtamount_contract.FireTabAfterEnter = True
        Me.Txtamount_contract.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Txtamount_contract.Image = CType(resources.GetObject("Txtamount_contract.Image"), System.Drawing.Image)
        Me.Txtamount_contract.Location = New System.Drawing.Point(456, 131)
        Me.Txtamount_contract.Maxlength = 12
        Me.Txtamount_contract.MinusColor = System.Drawing.Color.Empty
        Me.Txtamount_contract.Name = "Txtamount_contract"
        Me.Txtamount_contract.Size = New System.Drawing.Size(80, 22)
        Me.Txtamount_contract.TabIndex = 21
        Me.Txtamount_contract.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Txtamount_contract.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(454, 94)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 15)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Amount"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(358, 94)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 15)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Ends"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(278, 94)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(48, 15)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Starts"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtAmount_Onsale
        '
        Me.TxtAmount_Onsale.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtAmount_Onsale.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtAmount_Onsale.DecimalDigits = 2
        Me.TxtAmount_Onsale.DefaultSendValue = False
        Me.TxtAmount_Onsale.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtAmount_Onsale.FireTabAfterEnter = True
        Me.TxtAmount_Onsale.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtAmount_Onsale.Image = CType(resources.GetObject("TxtAmount_Onsale.Image"), System.Drawing.Image)
        Me.TxtAmount_Onsale.Location = New System.Drawing.Point(456, 110)
        Me.TxtAmount_Onsale.Maxlength = 12
        Me.TxtAmount_Onsale.MinusColor = System.Drawing.Color.Empty
        Me.TxtAmount_Onsale.Name = "TxtAmount_Onsale"
        Me.TxtAmount_Onsale.Size = New System.Drawing.Size(80, 22)
        Me.TxtAmount_Onsale.TabIndex = 18
        Me.TxtAmount_Onsale.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtAmount_Onsale.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'ChkSpiff
        '
        Me.ChkSpiff.Location = New System.Drawing.Point(196, 149)
        Me.ChkSpiff.Name = "ChkSpiff"
        Me.ChkSpiff.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkSpiff.Size = New System.Drawing.Size(64, 24)
        Me.ChkSpiff.TabIndex = 22
        Me.ChkSpiff.Text = "Spiff"
        '
        'ChkContract
        '
        Me.ChkContract.Location = New System.Drawing.Point(196, 129)
        Me.ChkContract.Name = "ChkContract"
        Me.ChkContract.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkContract.Size = New System.Drawing.Size(64, 23)
        Me.ChkContract.TabIndex = 19
        Me.ChkContract.Text = "Contract"
        '
        'ChkOnSale
        '
        Me.ChkOnSale.Location = New System.Drawing.Point(196, 108)
        Me.ChkOnSale.Name = "ChkOnSale"
        Me.ChkOnSale.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkOnSale.Size = New System.Drawing.Size(64, 23)
        Me.ChkOnSale.TabIndex = 15
        Me.ChkOnSale.Text = "On Sale"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(230, 66)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 22)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Line"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(195, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 22)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Quick Refrence"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtUpc
        '
        Me.TxtUpc.Location = New System.Drawing.Point(72, 89)
        Me.TxtUpc.MaxLength = 30
        Me.TxtUpc.Name = "TxtUpc"
        Me.TxtUpc.Size = New System.Drawing.Size(120, 21)
        Me.TxtUpc.TabIndex = 13
        Me.TxtUpc.Text = ""
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(-2, 111)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 24)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Bin Location"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 89)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 23)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "UPC"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 23)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Style"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 22)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Brand"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(191, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 23)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Fet"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 23)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Cost"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDesc_Item
        '
        Me.TxtDesc_Item.Location = New System.Drawing.Point(72, 0)
        Me.TxtDesc_Item.MaxLength = 50
        Me.TxtDesc_Item.Name = "TxtDesc_Item"
        Me.TxtDesc_Item.Size = New System.Drawing.Size(424, 21)
        Me.TxtDesc_Item.TabIndex = 0
        Me.TxtDesc_Item.Text = ""
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(0, 4)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(65, 23)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Description"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnNotes
        '
        Me.BtnNotes.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnNotes.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnNotes.Location = New System.Drawing.Point(0, 141)
        Me.BtnNotes.Name = "BtnNotes"
        Me.BtnNotes.Size = New System.Drawing.Size(56, 21)
        Me.BtnNotes.TabIndex = 55
        Me.BtnNotes.TabStop = False
        Me.BtnNotes.Text = "Note"
        '
        'BtnHistory
        '
        Me.BtnHistory.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.BtnHistory.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnHistory.Location = New System.Drawing.Point(56, 141)
        Me.BtnHistory.Name = "BtnHistory"
        Me.BtnHistory.Size = New System.Drawing.Size(58, 21)
        Me.BtnHistory.TabIndex = 56
        Me.BtnHistory.TabStop = False
        Me.BtnHistory.Text = "History"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(300, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 23)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "List Price"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChkTaxable
        '
        Me.ChkTaxable.Location = New System.Drawing.Point(478, 22)
        Me.ChkTaxable.Name = "ChkTaxable"
        Me.ChkTaxable.Size = New System.Drawing.Size(64, 23)
        Me.ChkTaxable.TabIndex = 9
        Me.ChkTaxable.Text = "Taxable"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PanelAutopart)
        Me.TabPage2.Controls.Add(Me.PanelWheels)
        Me.TabPage2.Controls.Add(Me.TxtDesc_Item2)
        Me.TabPage2.Controls.Add(Me.Label74)
        Me.TabPage2.Controls.Add(Me.Paneltire)
        Me.TabPage2.Controls.Add(Me.Label83)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(715, 574)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Specification"
        Me.TabPage2.Visible = False
        '
        'PanelAutopart
        '
        Me.PanelAutopart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAutopart.Controls.Add(Me.Txtcore_cost)
        Me.PanelAutopart.Controls.Add(Me.Txtdays)
        Me.PanelAutopart.Controls.Add(Me.Txtmiles)
        Me.PanelAutopart.Controls.Add(Me.Label25)
        Me.PanelAutopart.Controls.Add(Me.Label97)
        Me.PanelAutopart.Controls.Add(Me.Chkcore_track)
        Me.PanelAutopart.Controls.Add(Me.Label96)
        Me.PanelAutopart.Controls.Add(Me.Label95)
        Me.PanelAutopart.Controls.Add(Me.Chkwarranty_track)
        Me.PanelAutopart.Controls.Add(Me.Label94)
        Me.PanelAutopart.Location = New System.Drawing.Point(474, 208)
        Me.PanelAutopart.Name = "PanelAutopart"
        Me.PanelAutopart.Size = New System.Drawing.Size(259, 145)
        Me.PanelAutopart.TabIndex = 61
        '
        'Txtcore_cost
        '
        Me.Txtcore_cost.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Txtcore_cost.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton
        Me.Txtcore_cost.DecimalDigits = 0
        Me.Txtcore_cost.DefaultSendValue = False
        Me.Txtcore_cost.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Txtcore_cost.FireTabAfterEnter = True
        Me.Txtcore_cost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Txtcore_cost.Image = CType(resources.GetObject("Txtcore_cost.Image"), System.Drawing.Image)
        Me.Txtcore_cost.Location = New System.Drawing.Point(5, 118)
        Me.Txtcore_cost.Maxlength = 30
        Me.Txtcore_cost.MinusColor = System.Drawing.Color.Empty
        Me.Txtcore_cost.Name = "Txtcore_cost"
        Me.Txtcore_cost.Size = New System.Drawing.Size(120, 21)
        Me.Txtcore_cost.TabIndex = 6
        Me.Txtcore_cost.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Txtcore_cost.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Txtdays
        '
        Me.Txtdays.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Txtdays.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton
        Me.Txtdays.DecimalDigits = 0
        Me.Txtdays.DefaultSendValue = False
        Me.Txtdays.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Txtdays.FireTabAfterEnter = True
        Me.Txtdays.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Txtdays.Image = CType(resources.GetObject("Txtdays.Image"), System.Drawing.Image)
        Me.Txtdays.Location = New System.Drawing.Point(7, 72)
        Me.Txtdays.Maxlength = 30
        Me.Txtdays.MinusColor = System.Drawing.Color.Empty
        Me.Txtdays.Name = "Txtdays"
        Me.Txtdays.Size = New System.Drawing.Size(120, 21)
        Me.Txtdays.TabIndex = 3
        Me.Txtdays.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Txtdays.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Txtmiles
        '
        Me.Txtmiles.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Txtmiles.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton
        Me.Txtmiles.DecimalDigits = 0
        Me.Txtmiles.DefaultSendValue = False
        Me.Txtmiles.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Txtmiles.FireTabAfterEnter = True
        Me.Txtmiles.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Txtmiles.Image = CType(resources.GetObject("Txtmiles.Image"), System.Drawing.Image)
        Me.Txtmiles.Location = New System.Drawing.Point(8, 52)
        Me.Txtmiles.Maxlength = 30
        Me.Txtmiles.MinusColor = System.Drawing.Color.Empty
        Me.Txtmiles.Name = "Txtmiles"
        Me.Txtmiles.Size = New System.Drawing.Size(120, 21)
        Me.Txtmiles.TabIndex = 1
        Me.Txtmiles.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Txtmiles.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(136, 114)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(112, 23)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "Core Value"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label97
        '
        Me.Label97.Location = New System.Drawing.Point(176, 192)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(112, 23)
        Me.Label97.TabIndex = 59
        Me.Label97.Text = "Core Value"
        Me.Label97.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Chkcore_track
        '
        Me.Chkcore_track.Location = New System.Drawing.Point(6, 96)
        Me.Chkcore_track.Name = "Chkcore_track"
        Me.Chkcore_track.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Chkcore_track.Size = New System.Drawing.Size(112, 23)
        Me.Chkcore_track.TabIndex = 5
        Me.Chkcore_track.Text = "Track Core"
        '
        'Label96
        '
        Me.Label96.Location = New System.Drawing.Point(136, 71)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(112, 23)
        Me.Label96.TabIndex = 4
        Me.Label96.Text = "Days Warranty"
        Me.Label96.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label95
        '
        Me.Label95.Location = New System.Drawing.Point(136, 47)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(112, 24)
        Me.Label95.TabIndex = 2
        Me.Label95.Text = "Millage Warranty"
        Me.Label95.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Chkwarranty_track
        '
        Me.Chkwarranty_track.Location = New System.Drawing.Point(9, 30)
        Me.Chkwarranty_track.Name = "Chkwarranty_track"
        Me.Chkwarranty_track.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Chkwarranty_track.Size = New System.Drawing.Size(112, 23)
        Me.Chkwarranty_track.TabIndex = 0
        Me.Chkwarranty_track.Text = "Track Warranty"
        '
        'Label94
        '
        Me.Label94.BackColor = System.Drawing.Color.FromArgb(CType(159, Byte), CType(220, Byte), CType(114, Byte))
        Me.Label94.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.Location = New System.Drawing.Point(32, 6)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(184, 22)
        Me.Label94.TabIndex = 50
        Me.Label94.Text = "Auto Part"
        Me.Label94.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelWheels
        '
        Me.PanelWheels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelWheels.Controls.Add(Me.Txtmax_diameter)
        Me.PanelWheels.Controls.Add(Me.Label93)
        Me.PanelWheels.Controls.Add(Me.Txtlug_size)
        Me.PanelWheels.Controls.Add(Me.Txtbolt_pattern)
        Me.PanelWheels.Controls.Add(Me.Txtbackside)
        Me.PanelWheels.Controls.Add(Me.Txtofset)
        Me.PanelWheels.Controls.Add(Me.CmbFinish)
        Me.PanelWheels.Controls.Add(Me.Cmbwheel_size)
        Me.PanelWheels.Controls.Add(Me.Label92)
        Me.PanelWheels.Controls.Add(Me.Label91)
        Me.PanelWheels.Controls.Add(Me.Label90)
        Me.PanelWheels.Controls.Add(Me.Label89)
        Me.PanelWheels.Controls.Add(Me.Label88)
        Me.PanelWheels.Controls.Add(Me.Label87)
        Me.PanelWheels.Controls.Add(Me.Label86)
        Me.PanelWheels.Location = New System.Drawing.Point(474, 22)
        Me.PanelWheels.Name = "PanelWheels"
        Me.PanelWheels.Size = New System.Drawing.Size(258, 188)
        Me.PanelWheels.TabIndex = 60
        '
        'Txtmax_diameter
        '
        Me.Txtmax_diameter.Location = New System.Drawing.Point(104, 156)
        Me.Txtmax_diameter.MaxLength = 15
        Me.Txtmax_diameter.Name = "Txtmax_diameter"
        Me.Txtmax_diameter.Size = New System.Drawing.Size(141, 21)
        Me.Txtmax_diameter.TabIndex = 6
        Me.Txtmax_diameter.Text = ""
        '
        'Label93
        '
        Me.Label93.BackColor = System.Drawing.Color.FromArgb(CType(159, Byte), CType(220, Byte), CType(114, Byte))
        Me.Label93.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.Location = New System.Drawing.Point(24, -1)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(184, 20)
        Me.Label93.TabIndex = 49
        Me.Label93.Text = "Wheels"
        Me.Label93.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txtlug_size
        '
        Me.Txtlug_size.Location = New System.Drawing.Point(104, 134)
        Me.Txtlug_size.MaxLength = 15
        Me.Txtlug_size.Name = "Txtlug_size"
        Me.Txtlug_size.Size = New System.Drawing.Size(141, 21)
        Me.Txtlug_size.TabIndex = 5
        Me.Txtlug_size.Text = ""
        '
        'Txtbolt_pattern
        '
        Me.Txtbolt_pattern.Location = New System.Drawing.Point(104, 111)
        Me.Txtbolt_pattern.MaxLength = 15
        Me.Txtbolt_pattern.Name = "Txtbolt_pattern"
        Me.Txtbolt_pattern.Size = New System.Drawing.Size(141, 21)
        Me.Txtbolt_pattern.TabIndex = 4
        Me.Txtbolt_pattern.Text = ""
        '
        'Txtbackside
        '
        Me.Txtbackside.Location = New System.Drawing.Point(104, 89)
        Me.Txtbackside.MaxLength = 15
        Me.Txtbackside.Name = "Txtbackside"
        Me.Txtbackside.Size = New System.Drawing.Size(141, 21)
        Me.Txtbackside.TabIndex = 3
        Me.Txtbackside.Text = ""
        '
        'Txtofset
        '
        Me.Txtofset.Location = New System.Drawing.Point(104, 67)
        Me.Txtofset.MaxLength = 15
        Me.Txtofset.Name = "Txtofset"
        Me.Txtofset.Size = New System.Drawing.Size(141, 21)
        Me.Txtofset.TabIndex = 2
        Me.Txtofset.Text = ""
        '
        'CmbFinish
        '
        Me.CmbFinish.DataSource = Me.DsInvItemProduct1.finish
        Me.CmbFinish.DisplayMember = "desc_table"
        Me.CmbFinish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFinish.Location = New System.Drawing.Point(104, 45)
        Me.CmbFinish.Name = "CmbFinish"
        Me.CmbFinish.Size = New System.Drawing.Size(141, 21)
        Me.CmbFinish.TabIndex = 1
        Me.CmbFinish.Tag = "10"
        Me.CmbFinish.ValueMember = "cod_table_public"
        '
        'Cmbwheel_size
        '
        Me.Cmbwheel_size.DataSource = Me.DsInvItemProduct1.wheel_size
        Me.Cmbwheel_size.DisplayMember = "desc_table"
        Me.Cmbwheel_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbwheel_size.Location = New System.Drawing.Point(104, 22)
        Me.Cmbwheel_size.Name = "Cmbwheel_size"
        Me.Cmbwheel_size.Size = New System.Drawing.Size(141, 21)
        Me.Cmbwheel_size.TabIndex = 0
        Me.Cmbwheel_size.Tag = "9"
        Me.Cmbwheel_size.ValueMember = "cod_table_public"
        '
        'Label92
        '
        Me.Label92.Location = New System.Drawing.Point(16, 156)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(88, 23)
        Me.Label92.TabIndex = 38
        Me.Label92.Text = "Max.Diameter"
        Me.Label92.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label91
        '
        Me.Label91.Location = New System.Drawing.Point(8, 134)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(88, 23)
        Me.Label91.TabIndex = 37
        Me.Label91.Text = "Lug Size"
        Me.Label91.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label90
        '
        Me.Label90.Location = New System.Drawing.Point(8, 110)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(88, 24)
        Me.Label90.TabIndex = 36
        Me.Label90.Text = "Bolt Pattern"
        Me.Label90.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label89
        '
        Me.Label89.Location = New System.Drawing.Point(8, 89)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(88, 23)
        Me.Label89.TabIndex = 35
        Me.Label89.Text = "BackSide"
        Me.Label89.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label88
        '
        Me.Label88.Location = New System.Drawing.Point(8, 67)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(88, 23)
        Me.Label88.TabIndex = 34
        Me.Label88.Text = "Offset"
        Me.Label88.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label87
        '
        Me.Label87.Location = New System.Drawing.Point(8, 45)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(88, 23)
        Me.Label87.TabIndex = 33
        Me.Label87.Text = "Finish"
        Me.Label87.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label86
        '
        Me.Label86.Location = New System.Drawing.Point(8, 22)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(88, 23)
        Me.Label86.TabIndex = 32
        Me.Label86.Text = "Wheel Size"
        Me.Label86.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDesc_Item2
        '
        Me.TxtDesc_Item2.Location = New System.Drawing.Point(72, 0)
        Me.TxtDesc_Item2.Name = "TxtDesc_Item2"
        Me.TxtDesc_Item2.ReadOnly = True
        Me.TxtDesc_Item2.Size = New System.Drawing.Size(502, 21)
        Me.TxtDesc_Item2.TabIndex = 2
        Me.TxtDesc_Item2.Text = ""
        '
        'Label74
        '
        Me.Label74.Location = New System.Drawing.Point(8, 0)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(65, 22)
        Me.Label74.TabIndex = 1
        Me.Label74.Text = "Description"
        Me.Label74.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Paneltire
        '
        Me.Paneltire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Paneltire.Controls.Add(Me.Utqg1)
        Me.Paneltire.Controls.Add(Me.Label11)
        Me.Paneltire.Controls.Add(Me.Txtrim_width_range_inch)
        Me.Paneltire.Controls.Add(Me.Label1)
        Me.Paneltire.Controls.Add(Me.TxtSizeCod)
        Me.Paneltire.Controls.Add(Me.Label98)
        Me.Paneltire.Controls.Add(Me.Txtply)
        Me.Paneltire.Controls.Add(Me.Txtoriginal_equipment)
        Me.Paneltire.Controls.Add(Me.Txtwieght_lbs)
        Me.Paneltire.Controls.Add(Me.txtmax_air_psl)
        Me.Paneltire.Controls.Add(Me.Txtmax_load_lbs)
        Me.Paneltire.Controls.Add(Me.Txtrevs_per_mile)
        Me.Paneltire.Controls.Add(Me.Txtwidth)
        Me.Paneltire.Controls.Add(Me.Txttread_depth)
        Me.Paneltire.Controls.Add(Me.Txtoveral_diameter_inch)
        Me.Paneltire.Controls.Add(Me.Cmbload_index)
        Me.Paneltire.Controls.Add(Me.Cmbspeed_simbol)
        Me.Paneltire.Controls.Add(Me.Label85)
        Me.Paneltire.Controls.Add(Me.Label84)
        Me.Paneltire.Controls.Add(Me.Label82)
        Me.Paneltire.Controls.Add(Me.Label81)
        Me.Paneltire.Controls.Add(Me.Label80)
        Me.Paneltire.Controls.Add(Me.Label79)
        Me.Paneltire.Controls.Add(Me.Label78)
        Me.Paneltire.Controls.Add(Me.Label77)
        Me.Paneltire.Controls.Add(Me.Label76)
        Me.Paneltire.Controls.Add(Me.Label75)
        Me.Paneltire.Controls.Add(Me.Cmbrim_diameter_inch)
        Me.Paneltire.Controls.Add(Me.Label73)
        Me.Paneltire.Controls.Add(Me.Cmbaspect_ratio)
        Me.Paneltire.Controls.Add(Me.Label72)
        Me.Paneltire.Controls.Add(Me.Cmbwidth_mm)
        Me.Paneltire.Controls.Add(Me.Label71)
        Me.Paneltire.Controls.Add(Me.Txtsection_width_inch)
        Me.Paneltire.Controls.Add(Me.Label70)
        Me.Paneltire.Controls.Add(Me.Txtarticle_stock_no)
        Me.Paneltire.Controls.Add(Me.Label69)
        Me.Paneltire.Controls.Add(Me.TxtMsPn)
        Me.Paneltire.Controls.Add(Me.Label68)
        Me.Paneltire.Controls.Add(Me.CmbLoad_Range)
        Me.Paneltire.Controls.Add(Me.Label67)
        Me.Paneltire.Controls.Add(Me.CmbSidWall)
        Me.Paneltire.Controls.Add(Me.Label66)
        Me.Paneltire.Controls.Add(Me.Txtservice_description)
        Me.Paneltire.Controls.Add(Me.Label65)
        Me.Paneltire.Controls.Add(Me.Label64)
        Me.Paneltire.Location = New System.Drawing.Point(0, 22)
        Me.Paneltire.Name = "Paneltire"
        Me.Paneltire.Size = New System.Drawing.Size(466, 308)
        Me.Paneltire.TabIndex = 0
        '
        'Utqg1
        '
        Me.Utqg1.Connection = Me.Cnn
        Me.Utqg1.Line = ""
        Me.Utqg1.Location = New System.Drawing.Point(360, 277)
        Me.Utqg1.Name = "Utqg1"
        Me.Utqg1.Size = New System.Drawing.Size(80, 24)
        Me.Utqg1.TabIndex = 60
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(256, 198)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 23)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Weight LBS"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txtrim_width_range_inch
        '
        Me.Txtrim_width_range_inch.Location = New System.Drawing.Point(112, 177)
        Me.Txtrim_width_range_inch.MaxLength = 15
        Me.Txtrim_width_range_inch.Name = "Txtrim_width_range_inch"
        Me.Txtrim_width_range_inch.Size = New System.Drawing.Size(96, 21)
        Me.Txtrim_width_range_inch.TabIndex = 58
        Me.Txtrim_width_range_inch.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 22)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Rm Width Range-in"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtSizeCod
        '
        Me.TxtSizeCod.BackColor = System.Drawing.SystemColors.Control
        Me.TxtSizeCod.Cnn = Me.Cnn
        Me.TxtSizeCod.Cod_main = "01"
        Me.TxtSizeCod.FieldCodValue = Nothing
        Me.TxtSizeCod.Location = New System.Drawing.Point(111, 32)
        Me.TxtSizeCod.Name = "TxtSizeCod"
        Me.TxtSizeCod.Size = New System.Drawing.Size(122, 22)
        Me.TxtSizeCod.TabIndex = 0
        Me.TxtSizeCod.TxtBackColor = System.Drawing.Color.White
        Me.TxtSizeCod.TxtForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtSizeCod.TxtRightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'Label98
        '
        Me.Label98.Location = New System.Drawing.Point(63, 32)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(41, 23)
        Me.Label98.TabIndex = 55
        Me.Label98.Text = "Size"
        Me.Label98.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txtply
        '
        Me.Txtply.Location = New System.Drawing.Point(344, 248)
        Me.Txtply.MaxLength = 15
        Me.Txtply.Name = "Txtply"
        Me.Txtply.Size = New System.Drawing.Size(112, 21)
        Me.Txtply.TabIndex = 20
        Me.Txtply.Text = ""
        '
        'Txtoriginal_equipment
        '
        Me.Txtoriginal_equipment.Location = New System.Drawing.Point(344, 224)
        Me.Txtoriginal_equipment.MaxLength = 15
        Me.Txtoriginal_equipment.Name = "Txtoriginal_equipment"
        Me.Txtoriginal_equipment.Size = New System.Drawing.Size(112, 21)
        Me.Txtoriginal_equipment.TabIndex = 19
        Me.Txtoriginal_equipment.Text = ""
        '
        'Txtwieght_lbs
        '
        Me.Txtwieght_lbs.Location = New System.Drawing.Point(344, 200)
        Me.Txtwieght_lbs.MaxLength = 15
        Me.Txtwieght_lbs.Name = "Txtwieght_lbs"
        Me.Txtwieght_lbs.Size = New System.Drawing.Size(112, 21)
        Me.Txtwieght_lbs.TabIndex = 18
        Me.Txtwieght_lbs.Text = ""
        '
        'txtmax_air_psl
        '
        Me.txtmax_air_psl.Location = New System.Drawing.Point(344, 176)
        Me.txtmax_air_psl.MaxLength = 15
        Me.txtmax_air_psl.Name = "txtmax_air_psl"
        Me.txtmax_air_psl.Size = New System.Drawing.Size(112, 21)
        Me.txtmax_air_psl.TabIndex = 17
        Me.txtmax_air_psl.Text = ""
        '
        'Txtmax_load_lbs
        '
        Me.Txtmax_load_lbs.Location = New System.Drawing.Point(344, 152)
        Me.Txtmax_load_lbs.MaxLength = 15
        Me.Txtmax_load_lbs.Name = "Txtmax_load_lbs"
        Me.Txtmax_load_lbs.Size = New System.Drawing.Size(112, 21)
        Me.Txtmax_load_lbs.TabIndex = 16
        Me.Txtmax_load_lbs.Text = ""
        '
        'Txtrevs_per_mile
        '
        Me.Txtrevs_per_mile.Location = New System.Drawing.Point(344, 128)
        Me.Txtrevs_per_mile.MaxLength = 15
        Me.Txtrevs_per_mile.Name = "Txtrevs_per_mile"
        Me.Txtrevs_per_mile.Size = New System.Drawing.Size(112, 21)
        Me.Txtrevs_per_mile.TabIndex = 15
        Me.Txtrevs_per_mile.Text = ""
        '
        'Txtwidth
        '
        Me.Txtwidth.Location = New System.Drawing.Point(344, 104)
        Me.Txtwidth.MaxLength = 15
        Me.Txtwidth.Name = "Txtwidth"
        Me.Txtwidth.Size = New System.Drawing.Size(112, 21)
        Me.Txtwidth.TabIndex = 14
        Me.Txtwidth.Text = ""
        '
        'Txttread_depth
        '
        Me.Txttread_depth.Location = New System.Drawing.Point(344, 80)
        Me.Txttread_depth.MaxLength = 15
        Me.Txttread_depth.Name = "Txttread_depth"
        Me.Txttread_depth.Size = New System.Drawing.Size(112, 21)
        Me.Txttread_depth.TabIndex = 13
        Me.Txttread_depth.Text = ""
        '
        'Txtoveral_diameter_inch
        '
        Me.Txtoveral_diameter_inch.Location = New System.Drawing.Point(344, 56)
        Me.Txtoveral_diameter_inch.MaxLength = 15
        Me.Txtoveral_diameter_inch.Name = "Txtoveral_diameter_inch"
        Me.Txtoveral_diameter_inch.Size = New System.Drawing.Size(112, 21)
        Me.Txtoveral_diameter_inch.TabIndex = 12
        Me.Txtoveral_diameter_inch.Text = ""
        '
        'Cmbload_index
        '
        Me.Cmbload_index.DataSource = Me.DsInvItemProduct1.load_index
        Me.Cmbload_index.DisplayMember = "desc_table"
        Me.Cmbload_index.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbload_index.Location = New System.Drawing.Point(344, 32)
        Me.Cmbload_index.Name = "Cmbload_index"
        Me.Cmbload_index.Size = New System.Drawing.Size(112, 21)
        Me.Cmbload_index.TabIndex = 11
        Me.Cmbload_index.Tag = "8"
        Me.Cmbload_index.ValueMember = "cod_table_public"
        '
        'Cmbspeed_simbol
        '
        Me.Cmbspeed_simbol.DataSource = Me.DsInvItemProduct1.width_mm
        Me.Cmbspeed_simbol.DisplayMember = "desc_table"
        Me.Cmbspeed_simbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbspeed_simbol.Location = New System.Drawing.Point(344, 8)
        Me.Cmbspeed_simbol.Name = "Cmbspeed_simbol"
        Me.Cmbspeed_simbol.Size = New System.Drawing.Size(112, 21)
        Me.Cmbspeed_simbol.TabIndex = 10
        Me.Cmbspeed_simbol.Tag = "7"
        Me.Cmbspeed_simbol.ValueMember = "cod_table_public"
        '
        'Label85
        '
        Me.Label85.Location = New System.Drawing.Point(224, 248)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(112, 23)
        Me.Label85.TabIndex = 41
        Me.Label85.Text = "ply"
        Me.Label85.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label84
        '
        Me.Label84.Location = New System.Drawing.Point(224, 224)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(112, 23)
        Me.Label84.TabIndex = 40
        Me.Label84.Text = "Original Equipment"
        Me.Label84.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label82
        '
        Me.Label82.Location = New System.Drawing.Point(224, 176)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(112, 23)
        Me.Label82.TabIndex = 38
        Me.Label82.Text = "Max Air - psi"
        Me.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label81
        '
        Me.Label81.Location = New System.Drawing.Point(224, 152)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(112, 23)
        Me.Label81.TabIndex = 37
        Me.Label81.Text = "Max Load- lbs"
        Me.Label81.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label80
        '
        Me.Label80.Location = New System.Drawing.Point(224, 128)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(112, 23)
        Me.Label80.TabIndex = 36
        Me.Label80.Text = "Revs Per Mile"
        Me.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label79
        '
        Me.Label79.Location = New System.Drawing.Point(224, 104)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(112, 23)
        Me.Label79.TabIndex = 35
        Me.Label79.Text = "Tread Width"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label78
        '
        Me.Label78.Location = New System.Drawing.Point(224, 80)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(112, 23)
        Me.Label78.TabIndex = 34
        Me.Label78.Text = "Tread Depth"
        Me.Label78.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label77
        '
        Me.Label77.Location = New System.Drawing.Point(224, 54)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(112, 23)
        Me.Label77.TabIndex = 33
        Me.Label77.Text = "Overall Diameter -in"
        Me.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label76
        '
        Me.Label76.Location = New System.Drawing.Point(224, 30)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(112, 23)
        Me.Label76.TabIndex = 32
        Me.Label76.Text = "Load Index"
        Me.Label76.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label75
        '
        Me.Label75.Location = New System.Drawing.Point(224, 6)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(112, 23)
        Me.Label75.TabIndex = 31
        Me.Label75.Text = "Speed Symbol"
        Me.Label75.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cmbrim_diameter_inch
        '
        Me.Cmbrim_diameter_inch.DataSource = Me.DsInvItemProduct1.rim_diameter_inch
        Me.Cmbrim_diameter_inch.DisplayMember = "desc_table"
        Me.Cmbrim_diameter_inch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbrim_diameter_inch.Location = New System.Drawing.Point(112, 267)
        Me.Cmbrim_diameter_inch.Name = "Cmbrim_diameter_inch"
        Me.Cmbrim_diameter_inch.Size = New System.Drawing.Size(96, 21)
        Me.Cmbrim_diameter_inch.TabIndex = 9
        Me.Cmbrim_diameter_inch.Tag = "6"
        Me.Cmbrim_diameter_inch.ValueMember = "cod_table_public"
        '
        'Label73
        '
        Me.Label73.Location = New System.Drawing.Point(8, 267)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(96, 24)
        Me.Label73.TabIndex = 29
        Me.Label73.Text = "Rim Diameter-in"
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cmbaspect_ratio
        '
        Me.Cmbaspect_ratio.DataSource = Me.DsInvItemProduct1.aspect_ratio
        Me.Cmbaspect_ratio.DisplayMember = "desc_table"
        Me.Cmbaspect_ratio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbaspect_ratio.Location = New System.Drawing.Point(112, 245)
        Me.Cmbaspect_ratio.Name = "Cmbaspect_ratio"
        Me.Cmbaspect_ratio.Size = New System.Drawing.Size(96, 21)
        Me.Cmbaspect_ratio.TabIndex = 8
        Me.Cmbaspect_ratio.Tag = "5"
        Me.Cmbaspect_ratio.ValueMember = "cod_table_public"
        '
        'Label72
        '
        Me.Label72.Location = New System.Drawing.Point(13, 245)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(96, 23)
        Me.Label72.TabIndex = 27
        Me.Label72.Text = "Aspect ratio"
        Me.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cmbwidth_mm
        '
        Me.Cmbwidth_mm.DataSource = Me.DsInvItemProduct1.width_mm
        Me.Cmbwidth_mm.DisplayMember = "desc_table"
        Me.Cmbwidth_mm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbwidth_mm.Location = New System.Drawing.Point(112, 223)
        Me.Cmbwidth_mm.Name = "Cmbwidth_mm"
        Me.Cmbwidth_mm.Size = New System.Drawing.Size(96, 21)
        Me.Cmbwidth_mm.TabIndex = 7
        Me.Cmbwidth_mm.Tag = "4"
        Me.Cmbwidth_mm.ValueMember = "cod_table_public"
        '
        'Label71
        '
        Me.Label71.Location = New System.Drawing.Point(13, 223)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(96, 23)
        Me.Label71.TabIndex = 25
        Me.Label71.Text = "Width  mm"
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txtsection_width_inch
        '
        Me.Txtsection_width_inch.Location = New System.Drawing.Point(112, 201)
        Me.Txtsection_width_inch.MaxLength = 15
        Me.Txtsection_width_inch.Name = "Txtsection_width_inch"
        Me.Txtsection_width_inch.Size = New System.Drawing.Size(96, 21)
        Me.Txtsection_width_inch.TabIndex = 6
        Me.Txtsection_width_inch.Text = ""
        '
        'Label70
        '
        Me.Label70.Location = New System.Drawing.Point(13, 201)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(96, 22)
        Me.Label70.TabIndex = 23
        Me.Label70.Text = "Section Width in"
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txtarticle_stock_no
        '
        Me.Txtarticle_stock_no.Location = New System.Drawing.Point(112, 152)
        Me.Txtarticle_stock_no.MaxLength = 15
        Me.Txtarticle_stock_no.Name = "Txtarticle_stock_no"
        Me.Txtarticle_stock_no.Size = New System.Drawing.Size(96, 21)
        Me.Txtarticle_stock_no.TabIndex = 5
        Me.Txtarticle_stock_no.Text = ""
        '
        'Label69
        '
        Me.Label69.Location = New System.Drawing.Point(21, 152)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(88, 23)
        Me.Label69.TabIndex = 21
        Me.Label69.Text = "Artice /Stock No"
        Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtMsPn
        '
        Me.TxtMsPn.Location = New System.Drawing.Point(112, 128)
        Me.TxtMsPn.MaxLength = 15
        Me.TxtMsPn.Name = "TxtMsPn"
        Me.TxtMsPn.Size = New System.Drawing.Size(96, 21)
        Me.TxtMsPn.TabIndex = 4
        Me.TxtMsPn.Text = ""
        '
        'Label68
        '
        Me.Label68.Location = New System.Drawing.Point(29, 128)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(80, 23)
        Me.Label68.TabIndex = 19
        Me.Label68.Text = "MSPN"
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbLoad_Range
        '
        Me.CmbLoad_Range.DataSource = Me.DsInvItemProduct1.load_range
        Me.CmbLoad_Range.DisplayMember = "desc_table"
        Me.CmbLoad_Range.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbLoad_Range.Location = New System.Drawing.Point(112, 104)
        Me.CmbLoad_Range.Name = "CmbLoad_Range"
        Me.CmbLoad_Range.Size = New System.Drawing.Size(96, 21)
        Me.CmbLoad_Range.TabIndex = 3
        Me.CmbLoad_Range.Tag = "3"
        Me.CmbLoad_Range.ValueMember = "cod_table_public"
        '
        'Label67
        '
        Me.Label67.Location = New System.Drawing.Point(29, 104)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(80, 23)
        Me.Label67.TabIndex = 17
        Me.Label67.Text = "Load Range"
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbSidWall
        '
        Me.CmbSidWall.DataSource = Me.DsInvItemProduct1.sidwall
        Me.CmbSidWall.DisplayMember = "desc_table"
        Me.CmbSidWall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSidWall.Location = New System.Drawing.Point(112, 80)
        Me.CmbSidWall.Name = "CmbSidWall"
        Me.CmbSidWall.Size = New System.Drawing.Size(96, 21)
        Me.CmbSidWall.TabIndex = 2
        Me.CmbSidWall.Tag = "2"
        Me.CmbSidWall.ValueMember = "cod_table_public"
        '
        'Label66
        '
        Me.Label66.Location = New System.Drawing.Point(60, 80)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(49, 23)
        Me.Label66.TabIndex = 4
        Me.Label66.Text = "SideWall"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txtservice_description
        '
        Me.Txtservice_description.Location = New System.Drawing.Point(112, 56)
        Me.Txtservice_description.MaxLength = 15
        Me.Txtservice_description.Name = "Txtservice_description"
        Me.Txtservice_description.Size = New System.Drawing.Size(96, 21)
        Me.Txtservice_description.TabIndex = 1
        Me.Txtservice_description.Text = ""
        '
        'Label65
        '
        Me.Label65.Location = New System.Drawing.Point(5, 56)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(104, 23)
        Me.Label65.TabIndex = 2
        Me.Label65.Text = "Service Description"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label64
        '
        Me.Label64.BackColor = System.Drawing.Color.FromArgb(CType(159, Byte), CType(220, Byte), CType(114, Byte))
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(24, 7)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(152, 23)
        Me.Label64.TabIndex = 1
        Me.Label64.Text = "Tire Specification"
        '
        'Label83
        '
        Me.Label83.Location = New System.Drawing.Point(290, 346)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(112, 24)
        Me.Label83.TabIndex = 39
        Me.Label83.Text = "Weight - lbs"
        Me.Label83.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.CnnTemp
        '
        'CmdInsert
        '
        Me.CmdInsert.CommandText = "INSERT INTO inv_item (item_no, cod_item_type, desc_item, cod_quick_refrence, taxa" & _
        "ble, line, note, picture, upc, consignment, discontinued, discontinued_date, spe" & _
        "cial_notice, ITEMCRATEDDATE, ITEMFIRSTCOST) VALUES (@item_no, @cod_item_type, @d" & _
        "esc_item, @cod_quick_refrence, @taxable, @line, @note, @picture, @upc, @consignm" & _
        "ent, @discontinued, @discontinued_date, @special_notice, @itemCreatedDate, @Item" & _
        "FirstCost)"
        Me.CmdInsert.Connection = Me.Cnn
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_item_type", System.Data.SqlDbType.VarChar, 2, "cod_item_type"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_item", System.Data.SqlDbType.VarChar, 50, "desc_item"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_quick_refrence", System.Data.SqlDbType.VarChar, 3, "cod_quick_refrence"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@taxable", System.Data.SqlDbType.Bit, 1, "taxable"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@line", System.Data.SqlDbType.VarChar, 30, "line"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@note", System.Data.SqlDbType.VarChar, 300, "note"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@picture", System.Data.SqlDbType.VarBinary, 2147483647, "picture"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@upc", System.Data.SqlDbType.VarChar, 30, "upc"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@consignment", System.Data.SqlDbType.Bit, 1, "consignment"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discontinued", System.Data.SqlDbType.Bit, 1, "discontinued"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discontinued_date", System.Data.SqlDbType.VarChar, 10, "discontinued_date"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@special_notice", System.Data.SqlDbType.VarChar, 300, "special_notice"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@itemCreatedDate", System.Data.SqlDbType.VarChar, 10, "ITEMCRATEDDATE"))
        Me.CmdInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ItemFirstCost", System.Data.SqlDbType.Money, 8, "ITEMFIRSTCOST"))
        '
        'CmdUpdate
        '
        Me.CmdUpdate.CommandText = "UPDATE inv_item SET cod_item_type = @cod_item_type, desc_item = @desc_item, cod_q" & _
        "uick_refrence = @cod_quick_refrence, taxable = @taxable, line = @line, note = @n" & _
        "ote, picture = @picture, upc = @upc, consignment = @consignment, discontinued = " & _
        "@discontinued, discontinued_date = @discontinued_date, special_notice = @special" & _
        "_notice, ItemChangeDatePrice = @ItemChangeDatePrice, ItemChangeCostPrice = @Item" & _
        "ChangeCostPrice WHERE (item_no = @item_no)"
        Me.CmdUpdate.Connection = Me.Cnn
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_item_type", System.Data.SqlDbType.VarChar, 2, "cod_item_type"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_item", System.Data.SqlDbType.VarChar, 50, "desc_item"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_quick_refrence", System.Data.SqlDbType.VarChar, 3, "cod_quick_refrence"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@taxable", System.Data.SqlDbType.Bit, 1, "taxable"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@line", System.Data.SqlDbType.VarChar, 30, "line"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@note", System.Data.SqlDbType.VarChar, 300, "note"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@picture", System.Data.SqlDbType.VarBinary, 16, "picture"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@upc", System.Data.SqlDbType.VarChar, 30, "upc"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@consignment", System.Data.SqlDbType.Bit, 1, "consignment"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discontinued", System.Data.SqlDbType.Bit, 1, "discontinued"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discontinued_date", System.Data.SqlDbType.VarChar, 10, "discontinued_date"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@special_notice", System.Data.SqlDbType.VarChar, 300, "special_notice"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ItemChangeDatePrice", System.Data.SqlDbType.VarChar, 10, "ItemChangeDatePrice"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ItemChangeCostPrice", System.Data.SqlDbType.Real, 8, "ItemChangeCostPrice"))
        Me.CmdUpdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Window
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.ChkInsertToAllStore)
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
        Me.Panel9.Size = New System.Drawing.Size(723, 45)
        Me.Panel9.TabIndex = 2
        '
        'ChkInsertToAllStore
        '
        Me.ChkInsertToAllStore.Location = New System.Drawing.Point(585, 9)
        Me.ChkInsertToAllStore.Name = "ChkInsertToAllStore"
        Me.ChkInsertToAllStore.Size = New System.Drawing.Size(120, 18)
        Me.ChkInsertToAllStore.TabIndex = 197
        Me.ChkInsertToAllStore.Text = "Insert To All Store"
        Me.ChkInsertToAllStore.Visible = False
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label44.Location = New System.Drawing.Point(499, 31)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(43, 10)
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
        Me.BtnSortOrder.Size = New System.Drawing.Size(49, 27)
        Me.BtnSortOrder.TabIndex = 195
        '
        'UiContextMenu1
        '
        Me.UiContextMenu1.CommandManager = Me.UiCommandManager1
        Me.UiContextMenu1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Sort11, Me.Sort21, Me.Sort31})
        Me.UiContextMenu1.Key = "ContextMenu1"
        Me.UiContextMenu1.UseThemes = Janus.Windows.UI.InheritableBoolean.True
        Me.UiContextMenu1.VisualStyle = Janus.Windows.UI.VisualStyle.Standard
        '
        'UiCommandManager1
        '
        Me.UiCommandManager1.BottomRebar = Me.BottomRebar1
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Sort1, Me.Sort2, Me.Sort3})
        Me.UiCommandManager1.ContainerControl = Me
        Me.UiCommandManager1.ContextMenus.AddRange(New Janus.Windows.UI.CommandBars.UIContextMenu() {Me.UiContextMenu1})
        Me.UiCommandManager1.Id = New System.Guid("e02dc382-85d7-43f3-861f-f29178f8a53b")
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
        Me.Sort1.Text = "Order By Item Code"
        '
        'Sort2
        '
        Me.Sort2.Key = "Sort2"
        Me.Sort2.Name = "Sort2"
        Me.Sort2.Text = "Order By Item Name"
        '
        'Sort3
        '
        Me.Sort3.Key = "Sort3"
        Me.Sort3.Name = "Sort3"
        Me.Sort3.Text = "Order By Item Type"
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
        'Sort31
        '
        Me.Sort31.Key = "Sort3"
        Me.Sort31.Name = "Sort31"
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
        Me.Label41.Location = New System.Drawing.Point(133, 31)
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
        Me.BtnLast.Location = New System.Drawing.Point(132, 2)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(33, 27)
        Me.BtnLast.TabIndex = 188
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Location = New System.Drawing.Point(423, 31)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(40, 10)
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
        Me.BtnCancel.Size = New System.Drawing.Size(33, 27)
        Me.BtnCancel.TabIndex = 7
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Location = New System.Drawing.Point(303, 31)
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
        Me.BtnEdit.Location = New System.Drawing.Point(300, 2)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(33, 27)
        Me.BtnEdit.TabIndex = 4
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Location = New System.Drawing.Point(384, 31)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(33, 10)
        Me.Label50.TabIndex = 176
        Me.Label50.Text = "Save"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Location = New System.Drawing.Point(342, 31)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(37, 10)
        Me.Label51.TabIndex = 175
        Me.Label51.Text = "Delete"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Location = New System.Drawing.Point(259, 31)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(33, 10)
        Me.Label52.TabIndex = 174
        Me.Label52.Text = "New"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Location = New System.Drawing.Point(197, 31)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(33, 10)
        Me.Label53.TabIndex = 173
        Me.Label53.Text = "Find"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Location = New System.Drawing.Point(46, 31)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(33, 10)
        Me.Label54.TabIndex = 172
        Me.Label54.Text = "Prev"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Location = New System.Drawing.Point(91, 31)
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
        Me.BtnDelete.Location = New System.Drawing.Point(342, 2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(33, 27)
        Me.BtnDelete.TabIndex = 5
        '
        'BtnNew
        '
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.Location = New System.Drawing.Point(260, 2)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(33, 27)
        Me.BtnNew.TabIndex = 3
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(196, 2)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 27)
        Me.BtnFind.TabIndex = 2
        '
        'BtnNext
        '
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNext.Image = CType(resources.GetObject("BtnNext.Image"), System.Drawing.Image)
        Me.BtnNext.Location = New System.Drawing.Point(89, 2)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(33, 27)
        Me.BtnNext.TabIndex = 1
        '
        'BtnPrev
        '
        Me.BtnPrev.BackColor = System.Drawing.SystemColors.Window
        Me.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrev.Image = CType(resources.GetObject("BtnPrev.Image"), System.Drawing.Image)
        Me.BtnPrev.Location = New System.Drawing.Point(46, 2)
        Me.BtnPrev.Name = "BtnPrev"
        Me.BtnPrev.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrev.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.Enabled = False
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(384, 2)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(33, 27)
        Me.BtnSave.TabIndex = 6
        '
        'Command1
        '
        Me.Command1.Key = "Command1"
        Me.Command1.Name = "Command1"
        '
        'PanelTop
        '
        Me.PanelTop.Controls.Add(Me.TxtStoreNo)
        Me.PanelTop.Controls.Add(Me.TxtSize)
        Me.PanelTop.Controls.Add(Me.Label4)
        Me.PanelTop.Controls.Add(Me.Label3)
        Me.PanelTop.Controls.Add(Me.TxtItem_No)
        Me.PanelTop.Controls.Add(Me.Label101)
        Me.PanelTop.Controls.Add(Me.Label102)
        Me.PanelTop.Controls.Add(Me.CmbItemType)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 71)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(723, 31)
        Me.PanelTop.TabIndex = 3
        '
        'TxtStoreNo
        '
        Me.TxtStoreNo.Location = New System.Drawing.Point(640, 7)
        Me.TxtStoreNo.Name = "TxtStoreNo"
        Me.TxtStoreNo.ReadOnly = True
        Me.TxtStoreNo.Size = New System.Drawing.Size(44, 20)
        Me.TxtStoreNo.TabIndex = 27
        Me.TxtStoreNo.Text = ""
        '
        'TxtSize
        '
        Me.TxtSize.Location = New System.Drawing.Point(408, 7)
        Me.TxtSize.Name = "TxtSize"
        Me.TxtSize.ReadOnly = True
        Me.TxtSize.Size = New System.Drawing.Size(152, 20)
        Me.TxtSize.TabIndex = 2
        Me.TxtSize.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(568, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 21)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Store No"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(368, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Size"
        '
        'TxtItem_No
        '
        Me.TxtItem_No.Location = New System.Drawing.Point(240, 5)
        Me.TxtItem_No.MaxLength = 20
        Me.TxtItem_No.Name = "TxtItem_No"
        Me.TxtItem_No.Size = New System.Drawing.Size(120, 20)
        Me.TxtItem_No.TabIndex = 1
        Me.TxtItem_No.Text = ""
        '
        'Label101
        '
        Me.Label101.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.Location = New System.Drawing.Point(192, 9)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(47, 21)
        Me.Label101.TabIndex = 20
        Me.Label101.Text = "Item No"
        '
        'Label102
        '
        Me.Label102.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.Location = New System.Drawing.Point(7, 7)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(60, 18)
        Me.Label102.TabIndex = 18
        Me.Label102.Text = "Item Type"
        '
        'DaStyle
        '
        Me.DaStyle.SelectCommand = Me.SqlSelectCommand3
        Me.DaStyle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_style", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("desc_style", "desc_style"), New System.Data.Common.DataColumnMapping("cod_fees_balance", "cod_fees_balance"), New System.Data.Common.DataColumnMapping("cod_fees_tire", "cod_fees_tire"), New System.Data.Common.DataColumnMapping("cod_fees_disposal", "cod_fees_disposal"), New System.Data.Common.DataColumnMapping("cod_valvestem", "cod_valvestem"), New System.Data.Common.DataColumnMapping("cod_roadhazard", "cod_roadhazard"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("image_remark", "image_remark")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT style, desc_style, cod_fees_balance, cod_fees_tire, cod_fees_disposal, cod" & _
        "_valvestem, cod_roadhazard, remark, image_remark FROM inv_tab_style"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DaPriceCod
        '
        Me.DaPriceCod.SelectCommand = Me.SqlSelectCommand6
        Me.DaPriceCod.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_price_code", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("price_code", "price_code"), New System.Data.Common.DataColumnMapping("desc_price_code", "desc_price_code"), New System.Data.Common.DataColumnMapping("price1_c_l_a_p", "price1_c_l_a_p"), New System.Data.Common.DataColumnMapping("price1_operator", "price1_operator"), New System.Data.Common.DataColumnMapping("price1_d_persent", "price1_d_persent"), New System.Data.Common.DataColumnMapping("price1_amount", "price1_amount"), New System.Data.Common.DataColumnMapping("price1_odd_price", "price1_odd_price"), New System.Data.Common.DataColumnMapping("price1_price_level", "price1_price_level"), New System.Data.Common.DataColumnMapping("price2_c_l_a_p", "price2_c_l_a_p"), New System.Data.Common.DataColumnMapping("price2_operator", "price2_operator"), New System.Data.Common.DataColumnMapping("price2_d_persent", "price2_d_persent"), New System.Data.Common.DataColumnMapping("price2_amount", "price2_amount"), New System.Data.Common.DataColumnMapping("price2_odd_price", "price2_odd_price"), New System.Data.Common.DataColumnMapping("price2_price_level", "price2_price_level"), New System.Data.Common.DataColumnMapping("price3_c_l_a_p", "price3_c_l_a_p"), New System.Data.Common.DataColumnMapping("price3_operator", "price3_operator"), New System.Data.Common.DataColumnMapping("price3_d_persent", "price3_d_persent"), New System.Data.Common.DataColumnMapping("price3_amount", "price3_amount"), New System.Data.Common.DataColumnMapping("price3_odd_price", "price3_odd_price"), New System.Data.Common.DataColumnMapping("price3_price_level", "price3_price_level"), New System.Data.Common.DataColumnMapping("price4_c_l_a_p", "price4_c_l_a_p"), New System.Data.Common.DataColumnMapping("price4_operator", "price4_operator"), New System.Data.Common.DataColumnMapping("price4_d_persent", "price4_d_persent"), New System.Data.Common.DataColumnMapping("price4_amount", "price4_amount"), New System.Data.Common.DataColumnMapping("price4_odd_price", "price4_odd_price"), New System.Data.Common.DataColumnMapping("price4_price_level", "price4_price_level"), New System.Data.Common.DataColumnMapping("price5_c_l_a_p", "price5_c_l_a_p"), New System.Data.Common.DataColumnMapping("price5_operator", "price5_operator"), New System.Data.Common.DataColumnMapping("price5_d_persent", "price5_d_persent"), New System.Data.Common.DataColumnMapping("price5_amount", "price5_amount"), New System.Data.Common.DataColumnMapping("price5_odd_price", "price5_odd_price"), New System.Data.Common.DataColumnMapping("price5_price_level", "price5_price_level"), New System.Data.Common.DataColumnMapping("price6_c_l_a_p", "price6_c_l_a_p"), New System.Data.Common.DataColumnMapping("price6_operator", "price6_operator"), New System.Data.Common.DataColumnMapping("price6_d_persent", "price6_d_persent"), New System.Data.Common.DataColumnMapping("price6_amount", "price6_amount"), New System.Data.Common.DataColumnMapping("price6_odd_price", "price6_odd_price"), New System.Data.Common.DataColumnMapping("price6_price_level", "price6_price_level"), New System.Data.Common.DataColumnMapping("special_notice", "special_notice")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT price_code, desc_price_code, price1_c_l_a_p, price1_operator, price1_d_per" & _
        "sent, price1_amount, price1_odd_price, price1_price_level, price2_c_l_a_p, price" & _
        "2_operator, price2_d_persent, price2_amount, price2_odd_price, price2_price_leve" & _
        "l, price3_c_l_a_p, price3_operator, price3_d_persent, price3_amount, price3_odd_" & _
        "price, price3_price_level, price4_c_l_a_p, price4_operator, price4_d_persent, pr" & _
        "ice4_amount, price4_odd_price, price4_price_level, price5_c_l_a_p, price5_operat" & _
        "or, price5_d_persent, price5_amount, price5_odd_price, price5_price_level, price" & _
        "6_c_l_a_p, price6_operator, price6_d_persent, price6_amount, price6_odd_price, p" & _
        "rice6_price_level, special_notice FROM inv_price_code"
        Me.SqlSelectCommand6.Connection = Me.Cnn
        '
        'DaPublic
        '
        Me.DaPublic.SelectCommand = Me.SqlSelectCommand5
        Me.DaPublic.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_public", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_main", "cod_main"), New System.Data.Common.DataColumnMapping("cod_table_public", "cod_table_public"), New System.Data.Common.DataColumnMapping("desc_table", "desc_table")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT cod_main, cod_table_public, desc_table FROM inv_tab_public WHERE (cod_main" & _
        " = @Cod_Main)"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Main", System.Data.SqlDbType.VarChar, 2, "cod_main"))
        '
        'DaLine
        '
        Me.DaLine.SelectCommand = Me.SqlLine
        Me.DaLine.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_line", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("line", "line"), New System.Data.Common.DataColumnMapping("desc_line", "desc_line"), New System.Data.Common.DataColumnMapping("features", "features"), New System.Data.Common.DataColumnMapping("benefits", "benefits"), New System.Data.Common.DataColumnMapping("treadwear", "treadwear"), New System.Data.Common.DataColumnMapping("traction", "traction"), New System.Data.Common.DataColumnMapping("temperature", "temperature"), New System.Data.Common.DataColumnMapping("limit_warranty", "limit_warranty"), New System.Data.Common.DataColumnMapping("construction", "construction"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("image_remark", "image_remark"), New System.Data.Common.DataColumnMapping("tread_life", "tread_life"), New System.Data.Common.DataColumnMapping("wet_traction", "wet_traction"), New System.Data.Common.DataColumnMapping("quiet_ride", "quiet_ride"), New System.Data.Common.DataColumnMapping("handling", "handling"), New System.Data.Common.DataColumnMapping("winter_traction", "winter_traction"), New System.Data.Common.DataColumnMapping("nud_traction", "nud_traction"), New System.Data.Common.DataColumnMapping("overall_score", "overall_score"), New System.Data.Common.DataColumnMapping("dry_traction", "dry_traction"), New System.Data.Common.DataColumnMapping("ride_comfort", "ride_comfort")})})
        '
        'SqlLine
        '
        Me.SqlLine.CommandText = "SELECT inv_tab_line.cod_brand, inv_tab_line.style, inv_tab_line.line, inv_tab_lin" & _
        "e.features, inv_tab_line.benefits, inv_tab_line.treadwear, inv_tab_line.traction" & _
        ", inv_tab_line.temperature, inv_tab_line.limit_warranty, inv_tab_line.constructi" & _
        "on, inv_tab_line.remark, inv_tab_line.image_remark, inv_tab_line.tread_life, inv" & _
        "_tab_line.wet_traction, inv_tab_line.quiet_ride, inv_tab_line.handling, inv_tab_" & _
        "line.winter_traction, inv_tab_line.nud_traction, inv_tab_line.overall_score, inv" & _
        "_tab_line.dry_traction, inv_tab_line.ride_comfort, inv_tab_style.desc_style, inv" & _
        "_tab_brand.complete_desc_brand FROM inv_tab_line INNER JOIN inv_tab_brand ON inv" & _
        "_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN inv_tab_style ON inv_ta" & _
        "b_line.style = inv_tab_style.style"
        Me.SqlLine.Connection = Me.Cnn
        '
        'DaItemType
        '
        Me.DaItemType.SelectCommand = Me.SqlSelectCommand1
        Me.DaItemType.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_type_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_item_type", "cod_item_type"), New System.Data.Common.DataColumnMapping("desc_item_type", "desc_item_type"), New System.Data.Common.DataColumnMapping("GL_account", "GL_account")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cod_item_type, desc_item_type, GL_account FROM inv_tab_type_item WHERE (co" & _
        "d_item_type <> '00')"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DaBrand
        '
        Me.DaBrand.SelectCommand = Me.SqlSelectCommand2
        Me.DaBrand.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_brand", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("complete_desc_brand", "complete_desc_brand"), New System.Data.Common.DataColumnMapping("abbreviation_desc_brand", "abbreviation_desc_brand"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("tel", "tel"), New System.Data.Common.DataColumnMapping("conect_personal", "conect_personal"), New System.Data.Common.DataColumnMapping("icon_brand", "icon_brand")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cod_brand, complete_desc_brand, abbreviation_desc_brand, address, tel, con" & _
        "ect_personal, icon_brand FROM inv_tab_brand"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DaQuickRefrence
        '
        Me.DaQuickRefrence.DeleteCommand = Me.SqlDeleteCommand1
        Me.DaQuickRefrence.InsertCommand = Me.SqlInsertCommand1
        Me.DaQuickRefrence.SelectCommand = Me.SqlSelectCommand4
        Me.DaQuickRefrence.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item_quick_refrence", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_quick_refrence", "cod_quick_refrence"), New System.Data.Common.DataColumnMapping("desc_quick_refrence", "desc_quick_refrence")})})
        Me.DaQuickRefrence.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM inv_item_quick_refrence WHERE (cod_quick_refrence = @Original_cod_qui" & _
        "ck_refrence) AND (desc_quick_refrence = @Original_desc_quick_refrence OR @Origin" & _
        "al_desc_quick_refrence IS NULL AND desc_quick_refrence IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_quick_refrence", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_quick_refrence", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_quick_refrence", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_quick_refrence", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO inv_item_quick_refrence(cod_quick_refrence, desc_quick_refrence) VALU" & _
        "ES (@cod_quick_refrence, @desc_quick_refrence); SELECT cod_quick_refrence, desc_" & _
        "quick_refrence FROM inv_item_quick_refrence WHERE (cod_quick_refrence = @cod_qui" & _
        "ck_refrence)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_quick_refrence", System.Data.SqlDbType.VarChar, 3, "cod_quick_refrence"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_quick_refrence", System.Data.SqlDbType.VarChar, 50, "desc_quick_refrence"))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT cod_quick_refrence, desc_quick_refrence FROM inv_item_quick_refrence"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE inv_item_quick_refrence SET cod_quick_refrence = @cod_quick_refrence, desc" & _
        "_quick_refrence = @desc_quick_refrence WHERE (cod_quick_refrence = @Original_cod" & _
        "_quick_refrence) AND (desc_quick_refrence = @Original_desc_quick_refrence OR @Or" & _
        "iginal_desc_quick_refrence IS NULL AND desc_quick_refrence IS NULL); SELECT cod_" & _
        "quick_refrence, desc_quick_refrence FROM inv_item_quick_refrence WHERE (cod_quic" & _
        "k_refrence = @cod_quick_refrence)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_quick_refrence", System.Data.SqlDbType.VarChar, 3, "cod_quick_refrence"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_quick_refrence", System.Data.SqlDbType.VarChar, 50, "desc_quick_refrence"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_quick_refrence", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_quick_refrence", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_quick_refrence", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_quick_refrence", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT cod_warehouse, cod_location, desc_location, remark FROM inv_tab_location_w" & _
        "arehouse"
        Me.SqlSelectCommand7.Connection = Me.Cnn
        '
        'DaBinLocation
        '
        Me.DaBinLocation.SelectCommand = Me.SqlSelectCommand7
        Me.DaBinLocation.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_location_warehouse", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_warehouse", "cod_warehouse"), New System.Data.Common.DataColumnMapping("cod_location", "cod_location"), New System.Data.Common.DataColumnMapping("desc_location", "desc_location"), New System.Data.Common.DataColumnMapping("remark", "remark")})})
        '
        'CmdInsertinv_item_cost_transaction
        '
        Me.CmdInsertinv_item_cost_transaction.CommandText = "INSERT INTO inv_item_cost_transaction (item_no, date_cost_change, cost, list_pric" & _
        "e, fet, delivery, frieght, price_code, amount_price1, amount_price2, amount_pric" & _
        "e3, amount_price4, amount_price5, amount_price6, last_flag) VALUES (@item_no, @d" & _
        "ate_cost_change, @cost, @list_price, @fet, @delivery, @frieght, @price_code, @am" & _
        "ount_price1, @amount_price2, @amount_price3, @amount_price4, @amount_price5, @am" & _
        "ount_price6, @last_flag)"
        Me.CmdInsertinv_item_cost_transaction.Connection = Me.Cnn
        Me.CmdInsertinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.CmdInsertinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_cost_change", System.Data.SqlDbType.VarChar, 10, "date_cost_change"))
        Me.CmdInsertinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cost", System.Data.SqlDbType.Real, 4, "cost"))
        Me.CmdInsertinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@list_price", System.Data.SqlDbType.Real, 4, "list_price"))
        Me.CmdInsertinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fet", System.Data.SqlDbType.Real, 4, "fet"))
        Me.CmdInsertinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@delivery", System.Data.SqlDbType.Real, 4, "delivery"))
        Me.CmdInsertinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@frieght", System.Data.SqlDbType.Real, 4, "frieght"))
        Me.CmdInsertinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_code", System.Data.SqlDbType.VarChar, 5, "price_code"))
        Me.CmdInsertinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_price1", System.Data.SqlDbType.Real, 4, "amount_price1"))
        Me.CmdInsertinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_price2", System.Data.SqlDbType.Real, 4, "amount_price2"))
        Me.CmdInsertinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_price3", System.Data.SqlDbType.Real, 4, "amount_price3"))
        Me.CmdInsertinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_price4", System.Data.SqlDbType.Real, 4, "amount_price4"))
        Me.CmdInsertinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_price5", System.Data.SqlDbType.Real, 4, "amount_price5"))
        Me.CmdInsertinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_price6", System.Data.SqlDbType.Real, 4, "amount_price6"))
        Me.CmdInsertinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_flag", System.Data.SqlDbType.Bit, 1, "last_flag"))
        '
        'CmdUpdateinv_item_cost_transaction
        '
        Me.CmdUpdateinv_item_cost_transaction.CommandText = "UPDATE inv_item_cost_transaction SET date_cost_change = @date_cost_change, cost =" & _
        " @cost, list_price = @list_price, fet = @fet, price_code = @price_code, amount_p" & _
        "rice1 = @amount_price1, amount_price2 = @amount_price2, amount_price3 = @amount_" & _
        "price3, amount_price4 = @amount_price4, amount_price5 = @amount_price5, amount_p" & _
        "rice6 = @amount_price6, last_flag = 1, delivery = @delivery, frieght = @frieght " & _
        "WHERE (item_no = @item_no)"
        Me.CmdUpdateinv_item_cost_transaction.Connection = Me.Cnn
        Me.CmdUpdateinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_cost_change", System.Data.SqlDbType.VarChar, 10, "date_cost_change"))
        Me.CmdUpdateinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cost", System.Data.SqlDbType.Real, 4, "cost"))
        Me.CmdUpdateinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@list_price", System.Data.SqlDbType.Real, 4, "list_price"))
        Me.CmdUpdateinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fet", System.Data.SqlDbType.Real, 4, "fet"))
        Me.CmdUpdateinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_code", System.Data.SqlDbType.VarChar, 5, "price_code"))
        Me.CmdUpdateinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_price1", System.Data.SqlDbType.Real, 4, "amount_price1"))
        Me.CmdUpdateinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_price2", System.Data.SqlDbType.Real, 4, "amount_price2"))
        Me.CmdUpdateinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_price3", System.Data.SqlDbType.Real, 4, "amount_price3"))
        Me.CmdUpdateinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_price4", System.Data.SqlDbType.Real, 4, "amount_price4"))
        Me.CmdUpdateinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_price5", System.Data.SqlDbType.Real, 4, "amount_price5"))
        Me.CmdUpdateinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_price6", System.Data.SqlDbType.Real, 4, "amount_price6"))
        Me.CmdUpdateinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@delivery", System.Data.SqlDbType.Real, 4, "delivery"))
        Me.CmdUpdateinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@frieght", System.Data.SqlDbType.Real, 4, "frieght"))
        Me.CmdUpdateinv_item_cost_transaction.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'CmdInsertinv_tab_item_warehouse
        '
        Me.CmdInsertinv_tab_item_warehouse.CommandText = "INSERT INTO inv_tab_item_warehouse (cod_location, on_hand, comitted, on_order, mi" & _
        "n_stock, max_stock, reorde, cod_warehouse, item_no) VALUES (@cod_location, @on_h" & _
        "and, @comitted, @on_order, @min_stock, @max_stock, @reorde, @cod_warehouse, @ite" & _
        "m_no)"
        Me.CmdInsertinv_tab_item_warehouse.Connection = Me.Cnn
        Me.CmdInsertinv_tab_item_warehouse.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_location", System.Data.SqlDbType.VarChar, 10, "cod_location"))
        Me.CmdInsertinv_tab_item_warehouse.Parameters.Add(New System.Data.SqlClient.SqlParameter("@on_hand", System.Data.SqlDbType.Real, 4, "on_hand"))
        Me.CmdInsertinv_tab_item_warehouse.Parameters.Add(New System.Data.SqlClient.SqlParameter("@comitted", System.Data.SqlDbType.Real, 4, "comitted"))
        Me.CmdInsertinv_tab_item_warehouse.Parameters.Add(New System.Data.SqlClient.SqlParameter("@on_order", System.Data.SqlDbType.Real, 4, "on_order"))
        Me.CmdInsertinv_tab_item_warehouse.Parameters.Add(New System.Data.SqlClient.SqlParameter("@min_stock", System.Data.SqlDbType.Real, 4, "min_stock"))
        Me.CmdInsertinv_tab_item_warehouse.Parameters.Add(New System.Data.SqlClient.SqlParameter("@max_stock", System.Data.SqlDbType.Real, 4, "max_stock"))
        Me.CmdInsertinv_tab_item_warehouse.Parameters.Add(New System.Data.SqlClient.SqlParameter("@reorde", System.Data.SqlDbType.Real, 4, "reorde"))
        Me.CmdInsertinv_tab_item_warehouse.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_warehouse", System.Data.SqlDbType.VarChar, 1, "cod_warehouse"))
        Me.CmdInsertinv_tab_item_warehouse.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        '
        'CmdUpdateinv_tab_item_warehouse
        '
        Me.CmdUpdateinv_tab_item_warehouse.CommandText = "UPDATE inv_tab_item_warehouse SET min_stock = @min_stock, max_stock = @max_stock," & _
        " reorde = @reorde, cod_location = @cod_location WHERE (item_no = @Item_no) AND (" & _
        "cod_warehouse = @Cod_Warehouse)"
        Me.CmdUpdateinv_tab_item_warehouse.Connection = Me.Cnn
        Me.CmdUpdateinv_tab_item_warehouse.Parameters.Add(New System.Data.SqlClient.SqlParameter("@min_stock", System.Data.SqlDbType.Real, 4, "min_stock"))
        Me.CmdUpdateinv_tab_item_warehouse.Parameters.Add(New System.Data.SqlClient.SqlParameter("@max_stock", System.Data.SqlDbType.Real, 4, "max_stock"))
        Me.CmdUpdateinv_tab_item_warehouse.Parameters.Add(New System.Data.SqlClient.SqlParameter("@reorde", System.Data.SqlDbType.Real, 4, "reorde"))
        Me.CmdUpdateinv_tab_item_warehouse.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_location", System.Data.SqlDbType.VarChar, 6, "cod_location"))
        Me.CmdUpdateinv_tab_item_warehouse.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.CmdUpdateinv_tab_item_warehouse.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cod_Warehouse", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_warehouse", System.Data.DataRowVersion.Original, Nothing))
        '
        'CmdInsertinv_discount_item
        '
        Me.CmdInsertinv_discount_item.CommandText = "INSERT INTO inv_discount_item (item_no, onsale_check, start_date_onsale, end_date" & _
        "_onsale, amount_onsale, contract_check, start_date_contract, end_date_contract, " & _
        "amount_contract, spiff_check, start_date_spiff, end_date_spiff, amount_spiff, la" & _
        "st_flag) VALUES (@item_no, @onsale_check, @start_date_onsale, @end_date_onsale, " & _
        "@amount_onsale, @contract_check, @start_date_contract, @end_date_contract, @amou" & _
        "nt_contract, @spiff_check, @start_date_spiff, @end_date_spiff, @amount_spiff, @l" & _
        "ast_flag)"
        Me.CmdInsertinv_discount_item.Connection = Me.Cnn
        Me.CmdInsertinv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.CmdInsertinv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@onsale_check", System.Data.SqlDbType.Bit, 1, "onsale_check"))
        Me.CmdInsertinv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@start_date_onsale", System.Data.SqlDbType.VarChar, 10, "start_date_onsale"))
        Me.CmdInsertinv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@end_date_onsale", System.Data.SqlDbType.VarChar, 10, "end_date_onsale"))
        Me.CmdInsertinv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_onsale", System.Data.SqlDbType.Real, 4, "amount_onsale"))
        Me.CmdInsertinv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@contract_check", System.Data.SqlDbType.Bit, 1, "contract_check"))
        Me.CmdInsertinv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@start_date_contract", System.Data.SqlDbType.VarChar, 10, "start_date_contract"))
        Me.CmdInsertinv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@end_date_contract", System.Data.SqlDbType.VarChar, 10, "end_date_contract"))
        Me.CmdInsertinv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_contract", System.Data.SqlDbType.Real, 4, "amount_contract"))
        Me.CmdInsertinv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@spiff_check", System.Data.SqlDbType.Bit, 1, "spiff_check"))
        Me.CmdInsertinv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@start_date_spiff", System.Data.SqlDbType.VarChar, 10, "start_date_spiff"))
        Me.CmdInsertinv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@end_date_spiff", System.Data.SqlDbType.VarChar, 10, "end_date_spiff"))
        Me.CmdInsertinv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_spiff", System.Data.SqlDbType.Real, 4, "amount_spiff"))
        Me.CmdInsertinv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_flag", System.Data.SqlDbType.Bit, 1, "last_flag"))
        '
        'CmdUpdateInv_discount_item
        '
        Me.CmdUpdateInv_discount_item.CommandText = "UPDATE inv_discount_item SET onsale_check = @onsale_check, start_date_onsale = @s" & _
        "tart_date_onsale, end_date_onsale = @end_date_onsale, amount_onsale = @amount_on" & _
        "sale, contract_check = @contract_check, start_date_contract = @start_date_contra" & _
        "ct, end_date_contract = @end_date_contract, amount_contract = @amount_contract, " & _
        "spiff_check = @spiff_check, start_date_spiff = @start_date_spiff, end_date_spiff" & _
        " = @end_date_spiff, amount_spiff = @amount_spiff, last_flag = @last_flag WHERE (" & _
        "item_no = @item_no)"
        Me.CmdUpdateInv_discount_item.Connection = Me.Cnn
        Me.CmdUpdateInv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@onsale_check", System.Data.SqlDbType.Bit, 1, "onsale_check"))
        Me.CmdUpdateInv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@start_date_onsale", System.Data.SqlDbType.VarChar, 10, "start_date_onsale"))
        Me.CmdUpdateInv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@end_date_onsale", System.Data.SqlDbType.VarChar, 10, "end_date_onsale"))
        Me.CmdUpdateInv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_onsale", System.Data.SqlDbType.Real, 4, "amount_onsale"))
        Me.CmdUpdateInv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@contract_check", System.Data.SqlDbType.Bit, 1, "contract_check"))
        Me.CmdUpdateInv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@start_date_contract", System.Data.SqlDbType.VarChar, 10, "start_date_contract"))
        Me.CmdUpdateInv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@end_date_contract", System.Data.SqlDbType.VarChar, 10, "end_date_contract"))
        Me.CmdUpdateInv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_contract", System.Data.SqlDbType.Real, 4, "amount_contract"))
        Me.CmdUpdateInv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@spiff_check", System.Data.SqlDbType.Bit, 1, "spiff_check"))
        Me.CmdUpdateInv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@start_date_spiff", System.Data.SqlDbType.VarChar, 10, "start_date_spiff"))
        Me.CmdUpdateInv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@end_date_spiff", System.Data.SqlDbType.VarChar, 10, "end_date_spiff"))
        Me.CmdUpdateInv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_spiff", System.Data.SqlDbType.Real, 4, "amount_spiff"))
        Me.CmdUpdateInv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_flag", System.Data.SqlDbType.Bit, 1, "last_flag"))
        Me.CmdUpdateInv_discount_item.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'CmdInsertinv_tab_tire_specification
        '
        Me.CmdInsertinv_tab_tire_specification.CommandText = "INSERT INTO inv_tab_tire_specification (item_no, tire_size, service_description, " & _
        "sidwall, load_range, mspn, article_stock_no, rim_width_range_inch, section_width" & _
        "_inch, width_mm, aspect_ratio, rim_diameter_inch, speed_simbol, load_index, over" & _
        "al_diameter_inch, tread_depth, tread_width, revs_per_mile, max_load_lbs, max_air" & _
        "_psl, wieght_lbs, original_equipment, ply) VALUES (@item_no, @tire_size, @servic" & _
        "e_description, @sidwall, @load_range, @mspn, @article_stock_no, @rim_width_range" & _
        "_inch, @section_width_inch, @width_mm, @aspect_ratio, @rim_diameter_inch, @speed" & _
        "_simbol, @load_index, @overal_diameter_inch, @tread_depth, @tread_width, @revs_p" & _
        "er_mile, @max_load_lbs, @max_air_psl, @wieght_lbs, @original_equipment, @ply)"
        Me.CmdInsertinv_tab_tire_specification.Connection = Me.Cnn
        Me.CmdInsertinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.CmdInsertinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tire_size", System.Data.SqlDbType.VarChar, 3, "tire_size"))
        Me.CmdInsertinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@service_description", System.Data.SqlDbType.VarChar, 15, "service_description"))
        Me.CmdInsertinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@sidwall", System.Data.SqlDbType.VarChar, 3, "sidwall"))
        Me.CmdInsertinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@load_range", System.Data.SqlDbType.VarChar, 3, "load_range"))
        Me.CmdInsertinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@mspn", System.Data.SqlDbType.VarChar, 15, "mspn"))
        Me.CmdInsertinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@article_stock_no", System.Data.SqlDbType.VarChar, 15, "article_stock_no"))
        Me.CmdInsertinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@rim_width_range_inch", System.Data.SqlDbType.VarChar, 15, "rim_width_range_inch"))
        Me.CmdInsertinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@section_width_inch", System.Data.SqlDbType.VarChar, 15, "section_width_inch"))
        Me.CmdInsertinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@width_mm", System.Data.SqlDbType.VarChar, 3, "width_mm"))
        Me.CmdInsertinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@aspect_ratio", System.Data.SqlDbType.VarChar, 3, "aspect_ratio"))
        Me.CmdInsertinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@rim_diameter_inch", System.Data.SqlDbType.VarChar, 3, "rim_diameter_inch"))
        Me.CmdInsertinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@speed_simbol", System.Data.SqlDbType.VarChar, 3, "speed_simbol"))
        Me.CmdInsertinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@load_index", System.Data.SqlDbType.VarChar, 3, "load_index"))
        Me.CmdInsertinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@overal_diameter_inch", System.Data.SqlDbType.VarChar, 15, "overal_diameter_inch"))
        Me.CmdInsertinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tread_depth", System.Data.SqlDbType.VarChar, 15, "tread_depth"))
        Me.CmdInsertinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tread_width", System.Data.SqlDbType.VarChar, 15, "tread_width"))
        Me.CmdInsertinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@revs_per_mile", System.Data.SqlDbType.VarChar, 15, "revs_per_mile"))
        Me.CmdInsertinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@max_load_lbs", System.Data.SqlDbType.VarChar, 15, "max_load_lbs"))
        Me.CmdInsertinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@max_air_psl", System.Data.SqlDbType.VarChar, 15, "max_air_psl"))
        Me.CmdInsertinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@wieght_lbs", System.Data.SqlDbType.VarChar, 15, "wieght_lbs"))
        Me.CmdInsertinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@original_equipment", System.Data.SqlDbType.VarChar, 15, "original_equipment"))
        Me.CmdInsertinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ply", System.Data.SqlDbType.VarChar, 15, "ply"))
        '
        'CmdUpdateinv_tab_tire_specification
        '
        Me.CmdUpdateinv_tab_tire_specification.CommandText = "UPDATE inv_tab_tire_specification SET tire_size = @tire_size, service_description" & _
        " = @service_description, sidwall = @sidwall, load_range = @load_range, mspn = @m" & _
        "spn, article_stock_no = @article_stock_no, rim_width_range_inch = @rim_width_ran" & _
        "ge_inch, section_width_inch = @section_width_inch, width_mm = @width_mm, aspect_" & _
        "ratio = @aspect_ratio, rim_diameter_inch = @rim_diameter_inch, speed_simbol = @s" & _
        "peed_simbol, load_index = @load_index, overal_diameter_inch = @overal_diameter_i" & _
        "nch, tread_depth = @tread_depth, tread_width = @tread_width, revs_per_mile = @re" & _
        "vs_per_mile, max_load_lbs = @max_load_lbs, max_air_psl = @max_air_psl, wieght_lb" & _
        "s = @wieght_lbs, original_equipment = @original_equipment, ply = @ply WHERE (ite" & _
        "m_no = @item_no)"
        Me.CmdUpdateinv_tab_tire_specification.Connection = Me.Cnn
        Me.CmdUpdateinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tire_size", System.Data.SqlDbType.VarChar, 3, "tire_size"))
        Me.CmdUpdateinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@service_description", System.Data.SqlDbType.VarChar, 15, "service_description"))
        Me.CmdUpdateinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@sidwall", System.Data.SqlDbType.VarChar, 3, "sidwall"))
        Me.CmdUpdateinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@load_range", System.Data.SqlDbType.VarChar, 3, "load_range"))
        Me.CmdUpdateinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@mspn", System.Data.SqlDbType.VarChar, 15, "mspn"))
        Me.CmdUpdateinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@article_stock_no", System.Data.SqlDbType.VarChar, 15, "article_stock_no"))
        Me.CmdUpdateinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@rim_width_range_inch", System.Data.SqlDbType.VarChar, 15, "rim_width_range_inch"))
        Me.CmdUpdateinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@section_width_inch", System.Data.SqlDbType.VarChar, 15, "section_width_inch"))
        Me.CmdUpdateinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@width_mm", System.Data.SqlDbType.VarChar, 3, "width_mm"))
        Me.CmdUpdateinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@aspect_ratio", System.Data.SqlDbType.VarChar, 3, "aspect_ratio"))
        Me.CmdUpdateinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@rim_diameter_inch", System.Data.SqlDbType.VarChar, 3, "rim_diameter_inch"))
        Me.CmdUpdateinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@speed_simbol", System.Data.SqlDbType.VarChar, 3, "speed_simbol"))
        Me.CmdUpdateinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@load_index", System.Data.SqlDbType.VarChar, 3, "load_index"))
        Me.CmdUpdateinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@overal_diameter_inch", System.Data.SqlDbType.VarChar, 15, "overal_diameter_inch"))
        Me.CmdUpdateinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tread_depth", System.Data.SqlDbType.VarChar, 15, "tread_depth"))
        Me.CmdUpdateinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tread_width", System.Data.SqlDbType.VarChar, 15, "tread_width"))
        Me.CmdUpdateinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@revs_per_mile", System.Data.SqlDbType.VarChar, 15, "revs_per_mile"))
        Me.CmdUpdateinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@max_load_lbs", System.Data.SqlDbType.VarChar, 15, "max_load_lbs"))
        Me.CmdUpdateinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@max_air_psl", System.Data.SqlDbType.VarChar, 15, "max_air_psl"))
        Me.CmdUpdateinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@wieght_lbs", System.Data.SqlDbType.VarChar, 15, "wieght_lbs"))
        Me.CmdUpdateinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@original_equipment", System.Data.SqlDbType.VarChar, 15, "original_equipment"))
        Me.CmdUpdateinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ply", System.Data.SqlDbType.VarChar, 15, "ply"))
        Me.CmdUpdateinv_tab_tire_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'CmdInsertinv_tab_wheels_specification
        '
        Me.CmdInsertinv_tab_wheels_specification.CommandText = "INSERT INTO inv_tab_wheels_specification (item_no, wheel_size, finish, ofset, bac" & _
        "kside, bolt_pattern, lug_size, max_diameter) VALUES (@item_no, @wheel_size, @fin" & _
        "ish, @ofset, @backside, @bolt_pattern, @lug_size, @max_diameter)"
        Me.CmdInsertinv_tab_wheels_specification.Connection = Me.Cnn
        Me.CmdInsertinv_tab_wheels_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.CmdInsertinv_tab_wheels_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@wheel_size", System.Data.SqlDbType.VarChar, 3, "wheel_size"))
        Me.CmdInsertinv_tab_wheels_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@finish", System.Data.SqlDbType.VarChar, 3, "finish"))
        Me.CmdInsertinv_tab_wheels_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ofset", System.Data.SqlDbType.VarChar, 15, "ofset"))
        Me.CmdInsertinv_tab_wheels_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@backside", System.Data.SqlDbType.VarChar, 15, "backside"))
        Me.CmdInsertinv_tab_wheels_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@bolt_pattern", System.Data.SqlDbType.VarChar, 15, "bolt_pattern"))
        Me.CmdInsertinv_tab_wheels_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@lug_size", System.Data.SqlDbType.VarChar, 15, "lug_size"))
        Me.CmdInsertinv_tab_wheels_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@max_diameter", System.Data.SqlDbType.VarChar, 15, "max_diameter"))
        '
        'CmdUpdateinv_tab_wheels_specification
        '
        Me.CmdUpdateinv_tab_wheels_specification.CommandText = "UPDATE inv_tab_wheels_specification SET wheel_size = @wheel_size, finish = @finis" & _
        "h, ofset = @ofset, backside = @backside, bolt_pattern = @bolt_pattern, lug_size " & _
        "= @lug_size, max_diameter = @max_diameter WHERE (item_no = @Item_no)"
        Me.CmdUpdateinv_tab_wheels_specification.Connection = Me.Cnn
        Me.CmdUpdateinv_tab_wheels_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@wheel_size", System.Data.SqlDbType.VarChar, 3, "wheel_size"))
        Me.CmdUpdateinv_tab_wheels_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@finish", System.Data.SqlDbType.VarChar, 3, "finish"))
        Me.CmdUpdateinv_tab_wheels_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ofset", System.Data.SqlDbType.VarChar, 15, "ofset"))
        Me.CmdUpdateinv_tab_wheels_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@backside", System.Data.SqlDbType.VarChar, 15, "backside"))
        Me.CmdUpdateinv_tab_wheels_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@bolt_pattern", System.Data.SqlDbType.VarChar, 15, "bolt_pattern"))
        Me.CmdUpdateinv_tab_wheels_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@lug_size", System.Data.SqlDbType.VarChar, 15, "lug_size"))
        Me.CmdUpdateinv_tab_wheels_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@max_diameter", System.Data.SqlDbType.VarChar, 15, "max_diameter"))
        Me.CmdUpdateinv_tab_wheels_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'CmdInsertinv_tab_autopart_specification
        '
        Me.CmdInsertinv_tab_autopart_specification.CommandText = "INSERT INTO inv_tab_autopart_specification (item_no, warranty_track, miles, days," & _
        " core_track, core_cost) VALUES (@item_no, @warranty_track, @miles, @days, @core_" & _
        "track, @core_cost)"
        Me.CmdInsertinv_tab_autopart_specification.Connection = Me.Cnn
        Me.CmdInsertinv_tab_autopart_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.CmdInsertinv_tab_autopart_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@warranty_track", System.Data.SqlDbType.Bit, 1, "warranty_track"))
        Me.CmdInsertinv_tab_autopart_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@miles", System.Data.SqlDbType.Real, 4, "miles"))
        Me.CmdInsertinv_tab_autopart_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@days", System.Data.SqlDbType.Real, 4, "days"))
        Me.CmdInsertinv_tab_autopart_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@core_track", System.Data.SqlDbType.Bit, 1, "core_track"))
        Me.CmdInsertinv_tab_autopart_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@core_cost", System.Data.SqlDbType.Real, 4, "core_cost"))
        '
        'CmdUpdateinv_tab_autopart_specification
        '
        Me.CmdUpdateinv_tab_autopart_specification.CommandText = "UPDATE inv_tab_autopart_specification SET warranty_track = @warranty_track, miles" & _
        " = @miles, days = @days, core_track = @core_track, core_cost = @core_cost WHERE " & _
        "(item_no = @item_no)"
        Me.CmdUpdateinv_tab_autopart_specification.Connection = Me.Cnn
        Me.CmdUpdateinv_tab_autopart_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@warranty_track", System.Data.SqlDbType.Bit, 1, "warranty_track"))
        Me.CmdUpdateinv_tab_autopart_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@miles", System.Data.SqlDbType.Real, 4, "miles"))
        Me.CmdUpdateinv_tab_autopart_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@days", System.Data.SqlDbType.Real, 4, "days"))
        Me.CmdUpdateinv_tab_autopart_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@core_track", System.Data.SqlDbType.Bit, 1, "core_track"))
        Me.CmdUpdateinv_tab_autopart_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@core_cost", System.Data.SqlDbType.Real, 4, "core_cost"))
        Me.CmdUpdateinv_tab_autopart_specification.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'CmdDeleteOthers
        '
        Me.CmdDeleteOthers.Connection = Me.Cnn
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT TOP 1 Inv_Receive_Products_head.date_receive AS date1, CAST(Inv_Receive_pr" & _
        "oduct_dtl.qty * (Inv_Receive_product_dtl.cost + Inv_Receive_product_dtl.Fet) AS " & _
        "decimal(8, 2)) AS lastAmount FROM Inv_Receive_Products_head INNER JOIN Inv_Recei" & _
        "ve_product_dtl ON Inv_Receive_Products_head.id_receive_ref = Inv_Receive_product" & _
        "_dtl.id_receive_ref WHERE (Inv_Receive_product_dtl.item_no = @item_No) ORDER BY " & _
        "Inv_Receive_Products_head.date_receive DESC"
        Me.SqlSelectCommand8.Connection = Me.CnnTemp
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_No", System.Data.SqlDbType.VarChar, 20, "item_no"))
        '
        'DaLastReceive
        '
        Me.DaLastReceive.SelectCommand = Me.SqlSelectCommand8
        Me.DaLastReceive.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_Receive_Products_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_receive_ref", "id_receive_ref"), New System.Data.Common.DataColumnMapping("date_receive", "date_receive"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("bill_credit", "bill_credit"), New System.Data.Common.DataColumnMapping("bill_receive", "bill_receive"), New System.Data.Common.DataColumnMapping("ap_term", "ap_term"), New System.Data.Common.DataColumnMapping("receipt_bill_date", "receipt_bill_date"), New System.Data.Common.DataColumnMapping("vendor_ref_no", "vendor_ref_no"), New System.Data.Common.DataColumnMapping("due_date", "due_date"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("house_comments", "house_comments"), New System.Data.Common.DataColumnMapping("vend_comments", "vend_comments"), New System.Data.Common.DataColumnMapping("Discount", "Discount"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT service_center_head.date_refer AS date1, CAST(service_center_dtl.qty * (se" & _
        "rvice_center_dtl.price + service_center_dtl.fet) AS decimal(8, 2)) AS lastAmount" & _
        " FROM service_center_head INNER JOIN service_center_dtl ON service_center_head.i" & _
        "d_service_center = service_center_dtl.id_service_center WHERE (service_center_dt" & _
        "l.type_select = 'I') AND (service_center_dtl.cod_select = @item_no) ORDER BY ser" & _
        "vice_center_head.date_refer DESC"
        Me.SqlSelectCommand9.Connection = Me.CnnTemp
        Me.SqlSelectCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "cod_select"))
        '
        'DaLastServicecenter
        '
        Me.DaLastServicecenter.SelectCommand = Me.SqlSelectCommand9
        Me.DaLastServicecenter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Total", "Total")})})
        '
        'DALastAdjustment
        '
        Me.DALastAdjustment.DeleteCommand = Me.SqlDeleteCommand5
        Me.DALastAdjustment.InsertCommand = Me.SqlInsertCommand5
        Me.DALastAdjustment.SelectCommand = Me.SqlCommand1
        Me.DALastAdjustment.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_adjustment_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("referID_adjustment", "referID_adjustment"), New System.Data.Common.DataColumnMapping("date_adjustment", "date_adjustment"), New System.Data.Common.DataColumnMapping("adjustment_by", "adjustment_by"), New System.Data.Common.DataColumnMapping("authorized_by", "authorized_by"), New System.Data.Common.DataColumnMapping("explanation", "explanation"), New System.Data.Common.DataColumnMapping("GL_account_adjustment", "GL_account_adjustment"), New System.Data.Common.DataColumnMapping("comment", "comment")})})
        Me.DALastAdjustment.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = "DELETE FROM inv_adjustment_head WHERE (referID_adjustment = @Original_referID_adj" & _
        "ustment) AND (GL_account_adjustment = @Original_GL_account_adjustment OR @Origin" & _
        "al_GL_account_adjustment IS NULL AND GL_account_adjustment IS NULL) AND (adjustm" & _
        "ent_by = @Original_adjustment_by OR @Original_adjustment_by IS NULL AND adjustme" & _
        "nt_by IS NULL) AND (authorized_by = @Original_authorized_by OR @Original_authori" & _
        "zed_by IS NULL AND authorized_by IS NULL) AND (comment = @Original_comment OR @O" & _
        "riginal_comment IS NULL AND comment IS NULL) AND (date_adjustment = @Original_da" & _
        "te_adjustment OR @Original_date_adjustment IS NULL AND date_adjustment IS NULL) " & _
        "AND (explanation = @Original_explanation OR @Original_explanation IS NULL AND ex" & _
        "planation IS NULL)"
        Me.SqlDeleteCommand5.Connection = Me.Cnn
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_referID_adjustment", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "referID_adjustment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account_adjustment", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account_adjustment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_adjustment_by", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "adjustment_by", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_authorized_by", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "authorized_by", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_comment", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "comment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_adjustment", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_adjustment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_explanation", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "explanation", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO inv_adjustment_head(referID_adjustment, date_adjustment, adjustment_b" & _
        "y, authorized_by, explanation, GL_account_adjustment, comment) VALUES (@referID_" & _
        "adjustment, @date_adjustment, @adjustment_by, @authorized_by, @explanation, @GL_" & _
        "account_adjustment, @comment); SELECT referID_adjustment, date_adjustment, adjus" & _
        "tment_by, authorized_by, explanation, GL_account_adjustment, comment FROM inv_ad" & _
        "justment_head WHERE (referID_adjustment = @referID_adjustment)"
        Me.SqlInsertCommand5.Connection = Me.Cnn
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@referID_adjustment", System.Data.SqlDbType.VarChar, 8, "referID_adjustment"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_adjustment", System.Data.SqlDbType.VarChar, 10, "date_adjustment"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@adjustment_by", System.Data.SqlDbType.VarChar, 5, "adjustment_by"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@authorized_by", System.Data.SqlDbType.VarChar, 5, "authorized_by"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@explanation", System.Data.SqlDbType.VarChar, 100, "explanation"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account_adjustment", System.Data.SqlDbType.VarChar, 10, "GL_account_adjustment"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@comment", System.Data.SqlDbType.VarChar, 200, "comment"))
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT inv_adjustment_head.date_adjustment AS date1, CAST(inv_adjustment_dtl.QTY " & _
        "* inv_adjustment_dtl.Cost AS decimal(8, 2)) AS lastamount FROM inv_adjustment_he" & _
        "ad INNER JOIN inv_adjustment_dtl ON inv_adjustment_head.referID_adjustment = inv" & _
        "_adjustment_dtl.referID_adjustment WHERE (inv_adjustment_dtl.item_no = @item_no)" & _
        " ORDER BY inv_adjustment_head.date_adjustment DESC"
        Me.SqlCommand1.Connection = Me.CnnTemp
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = "UPDATE inv_adjustment_head SET referID_adjustment = @referID_adjustment, date_adj" & _
        "ustment = @date_adjustment, adjustment_by = @adjustment_by, authorized_by = @aut" & _
        "horized_by, explanation = @explanation, GL_account_adjustment = @GL_account_adju" & _
        "stment, comment = @comment WHERE (referID_adjustment = @Original_referID_adjustm" & _
        "ent) AND (GL_account_adjustment = @Original_GL_account_adjustment OR @Original_G" & _
        "L_account_adjustment IS NULL AND GL_account_adjustment IS NULL) AND (adjustment_" & _
        "by = @Original_adjustment_by OR @Original_adjustment_by IS NULL AND adjustment_b" & _
        "y IS NULL) AND (authorized_by = @Original_authorized_by OR @Original_authorized_" & _
        "by IS NULL AND authorized_by IS NULL) AND (comment = @Original_comment OR @Origi" & _
        "nal_comment IS NULL AND comment IS NULL) AND (date_adjustment = @Original_date_a" & _
        "djustment OR @Original_date_adjustment IS NULL AND date_adjustment IS NULL) AND " & _
        "(explanation = @Original_explanation OR @Original_explanation IS NULL AND explan" & _
        "ation IS NULL); SELECT referID_adjustment, date_adjustment, adjustment_by, autho" & _
        "rized_by, explanation, GL_account_adjustment, comment FROM inv_adjustment_head W" & _
        "HERE (referID_adjustment = @referID_adjustment)"
        Me.SqlUpdateCommand5.Connection = Me.Cnn
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@referID_adjustment", System.Data.SqlDbType.VarChar, 8, "referID_adjustment"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_adjustment", System.Data.SqlDbType.VarChar, 10, "date_adjustment"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@adjustment_by", System.Data.SqlDbType.VarChar, 5, "adjustment_by"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@authorized_by", System.Data.SqlDbType.VarChar, 5, "authorized_by"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@explanation", System.Data.SqlDbType.VarChar, 100, "explanation"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@GL_account_adjustment", System.Data.SqlDbType.VarChar, 10, "GL_account_adjustment"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@comment", System.Data.SqlDbType.VarChar, 200, "comment"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_referID_adjustment", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "referID_adjustment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_GL_account_adjustment", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GL_account_adjustment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_adjustment_by", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "adjustment_by", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_authorized_by", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "authorized_by", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_comment", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "comment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_adjustment", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_adjustment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_explanation", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "explanation", System.Data.DataRowVersion.Original, Nothing))
        '
        'FrmItemProduct
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(723, 474)
        Me.Controls.Add(Me.PnlKartAmvalField)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.PnlSearch)
        Me.Controls.Add(Me.Panel9)
        Me.Name = "FrmItemProduct"
        Me.Text = "Item And Product"
        Me.PnlSearch.ResumeLayout(False)
        CType(Me.DsInvItemProduct1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlKartAmvalField.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.P5.ResumeLayout(False)
        Me.p4.ResumeLayout(False)
        Me.P3.ResumeLayout(False)
        Me.P2.ResumeLayout(False)
        Me.P1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.PanelAutopart.ResumeLayout(False)
        Me.PanelWheels.ResumeLayout(False)
        Me.Paneltire.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(Me.UiContextMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1.EditContextMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cnn.ConnectionString = PConnectionString
            MyclsItemno = New Clsitem_no
            MyclsItemno.Connection = Me.Cnn
            Me.CnnTemp.ConnectionString = PConnectionString
            QuickReference1.Cnn = Me.Cnn
            myClsCommon = New CommonClass.AllStore
            Call FixthisDatabase()
            Call EnableField(False)
            PnlSearchHeight = PnlSearch.Height
            UiContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.True
            'TxtItem_since.Text = Format(Now.Date, PubDateFormat)
            Call FillDataSets()
            TxtItem_No.MaxLength = LenItem_No

            If Item_noTempVar.Trim.Length = 0 Then
                Call PFirstRecord(False)
            Else
                ItemNo1.Text = Item_noTempVar
                'Call FillFields(ItemNo1.Text)
            End If
            Call AfterSaveOrCancel()
            ItemNo1.Focus()
            '------Mine
            l1.Text = PriceLevelsLabels(1)
            l2.Text = PriceLevelsLabels(2)
            l3.Text = PriceLevelsLabels(3)
            l4.Text = PriceLevelsLabels(4)
            l5.Text = PriceLevelsLabels(5)
            l6.Text = PriceLevelsLabels(6)
            TxtStoreNo.Text = PubStoreNO
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        ' TxtStart_date_on_sale.Value = Now
    End Sub
    Private Sub FillDataSets()
        Try
            DsInvItemProduct1.Clear()
            DaPriceCod.Fill(DsInvItemProduct1.inv_price_code)

            DaItemType.Fill(DsInvItemProduct1.inv_tab_type_item)

            DaBinLocation.Fill(DsInvItemProduct1.inv_tab_location_warehouse)
            DaQuickRefrence.Fill(DsInvItemProduct1.inv_item_quick_refrence)

            'DaLine.SelectCommand.Parameters(0).Value = CmbStyle.SelectedValue
            DaLine.Fill(DsInvItemProduct1.inv_tab_line)


            DaPublic.SelectCommand.Parameters(0).Value = "01"
            DaPublic.Fill(DsInvItemProduct1.Tire_size)

            DaPublic.SelectCommand.Parameters(0).Value = "02"
            DaPublic.Fill(DsInvItemProduct1.sidwall)


            DaPublic.SelectCommand.Parameters(0).Value = "03"
            DaPublic.Fill(DsInvItemProduct1.load_range)

            DaPublic.SelectCommand.Parameters(0).Value = "04"
            DaPublic.Fill(DsInvItemProduct1.width_mm)

            DaPublic.SelectCommand.Parameters(0).Value = "05"
            DaPublic.Fill(DsInvItemProduct1.aspect_ratio)

            DaPublic.SelectCommand.Parameters(0).Value = "06"
            DaPublic.Fill(DsInvItemProduct1.rim_diameter_inch)


            DaPublic.SelectCommand.Parameters(0).Value = "07"
            DaPublic.Fill(DsInvItemProduct1.speed_simbol)
            DaPublic.SelectCommand.Parameters(0).Value = "08"
            DaPublic.Fill(DsInvItemProduct1.load_index)

            DaPublic.SelectCommand.Parameters(0).Value = "09"
            DaPublic.Fill(DsInvItemProduct1.wheel_size)

            DaPublic.SelectCommand.Parameters(0).Value = "10"
            DaPublic.Fill(DsInvItemProduct1.finish)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub PAddNew()
        PanelTop.Enabled = True
        Status = MainModule.WorkStates.AddNew
        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()
        Call EnableField(True)
        Item_noTempVar = ItemNo1.Text
        ItemNo1.Text = ""
        Call ClearField()
        CmbItemType.Focus()
        CmbItemType.SelectedValue = "01"
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
        ChkInsertToAllStore.Visible = True
        ChkInsertToAllStore.Checked = True

        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveInventorySetupTable(PubStoreNO)
        Try
            ChkTaxable.Checked = OleDbReaderForStore.Item("taxable")
        Catch ex As Exception
        End Try
        Try
            CmbItemType.SelectedValue = OleDbReaderForStore.Item("DEFAULT_ITEM_TYPE") & ""
        Catch ex As Exception
        End Try

        Try
            CmbPrice_Code.SelectedValue = OleDbReaderForStore.Item("DEFAULT_PRICE_CODE") & ""
        Catch ex As Exception
        End Try
        OleDbReaderForStore.Close()
    End Sub
    Sub PEdit()
        PanelTop.Enabled = False
        Status = MainModule.WorkStates.Edit
        'PnlSearch.Visible = False
        Call ShowFilterProcPanel()
        EnableField(True)
        Item_noTempVar = ItemNo1.Text
        CmbItemType.Focus()
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
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "Select Count(*) From service_center_dtl Where (type_select='I' OR type_select='A') AND cod_select=" & Qt(TxtItem_No.Text)
                If CmdGeneral.ExecuteScalar > 0 Then
                    MsgBox("This Item is used in Service center and system cannot delete it.")
                    Exit Sub
                End If

                If CmdDelete.Connection.State <> ConnectionState.Open Then
                    CmdDelete.Connection.Open()
                End If
                CmdDeleteOthers.CommandText = "Delete from inv_tab_wheels_specification where item_no=" & Qt(ItemNo1.Text)
                CmdDeleteOthers.ExecuteNonQuery()
                CmdDeleteOthers.CommandText = "Delete from inv_tab_tire_specification where item_no=" & Qt(ItemNo1.Text)
                CmdDeleteOthers.ExecuteNonQuery()
                CmdDeleteOthers.CommandText = "Delete from inv_tab_autopart_specification where item_no=" & Qt(ItemNo1.Text)
                CmdDeleteOthers.ExecuteNonQuery()
                CmdDelete.Parameters("@Item_No").Value = ItemNo1.Text
                CmdDelete.ExecuteNonQuery()
                Item_noTempVar = ""
                Call PNextRecord(False)
                If Item_noTempVar.Trim.Length = 0 Then
                    Call PPreviousRecord(False)
                    If Item_noTempVar.Trim.Length = 0 Then
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
            ItemNo1.Focus()
        End If
        Status = MainModule.WorkStates.Delete
    End Sub
    Sub PSave()
        Dim ChangeOK As Boolean = False
        Select Case Status
            Case MainModule.WorkStates.AddNew
                Item_noTempVar = PInsert()
                ChangeOK = IIf(Item_noTempVar.Trim.Length = 0, False, True)
            Case MainModule.WorkStates.Edit
                Dim thisrow As DataRow, ThisPosition As Integer
                ChangeOK = PUpdate(Item_noTempVar)
        End Select
        If ChangeOK Then
            Call AfterSaveOrCancel()
            'If Status = mainmodule.WorkStates.AddNew Then
            '    Call PAddNew()
            'Else
            Status = MainModule.WorkStates.Save
            'PnlSearch.Visible = True
            Call ShowFilterProcPanel()

            ItemNo1.Text = Item_noTempVar
            Call FillFields(ItemNo1.Text)
            ItemNo1.Focus()
        End If
    End Sub
    Sub PCancel()
        Status = MainModule.WorkStates._ReadOnly
        'PnlSearch.Visible = True
        Call ShowFilterProcPanel()

        ItemNo1.Text = Item_noTempVar
        'Call FillFields(ItemNo1.Text)
        Call AfterSaveOrCancel()
        ItemNo1.Focus()
    End Sub
    Sub AfterSaveOrCancel()
        MSave.Enabled = False
        BtnSave.Enabled = False
        MCancel.Enabled = False
        BtnCancel.Enabled = False
        BtnNew.Enabled = True
        MAddNew.Enabled = True
        If TxtItem_No.Text.Trim.Length = 0 Then
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
        ChkInsertToAllStore.Visible = False
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
    Private Sub TXTItem_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtItem_No.TextChanged
        Call SaveButtonControl()
    End Sub
    Private Sub TxtItem_No_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtItem_No.LostFocus
        TxtItem_No.Text = TxtItem_No.Text.Trim & ""
    End Sub
    Private Sub SaveButtonControl()
        If Status = MainModule.WorkStates.Edit Or Status = MainModule.WorkStates.AddNew Then
            If TxtItem_No.Text.Trim.Length > 0 And CmbItemType.Text.Trim.Length > 0 And Line1.Line_Code & "" <> "" And CmbPrice_Code.Text.Trim.Length > 0 And QuickReference1.FieldCodValue & "" <> "" Then
                BtnSave.Enabled = True
                MSave.Enabled = True
            Else
                BtnSave.Enabled = False
                MSave.Enabled = False
            End If
        End If
        TxtCost2.Text = TxtCost.Text
        'Cmbtire_Size.Text.Trim
        Desc_ItemPublic = TxtSizeCod.Text.Trim + " " + TxtBrand.Text.Trim + " " + Line1.Text.Trim + " " + Txtservice_description.Text.Trim + " " + CmbSidWall.Text.Trim
        TxtReplCost.Text = Val(TxtCost2.Text & "") + Val(TxtDelivery.Text & "") + Val(txtfrieght.Text & "")
        TxtAvgCost.Text = "Not Yet"
    End Sub
    Private Sub UiContextMenu1_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles UiContextMenu1.CommandClick
        UiContextMenu1.Commands(0).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UiContextMenu1.Commands(1).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UiContextMenu1.Commands(2).Checked() = Janus.Windows.UI.InheritableBoolean.False
        UiContextMenu1.Commands(e.Command.Key).Checked() = Janus.Windows.UI.InheritableBoolean.True
        Select Case e.Command.Key.ToUpper
            Case "SORT1"
                ItemOrderFieldName = "Item_No"
            Case "SORT2"
                ItemOrderFieldName = "desc_Item"
            Case "SORT3"
                ItemOrderFieldName = "cod_item_type"
        End Select
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
        Dim TXTSearchItem_noTemp As String = 0

        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT Top 1 Item_No from Inv_Item Order BY " & ItemOrderFieldName & " ASC"
            TXTSearchItem_noTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.Connection.Close()
            If IsNothing(TXTSearchItem_noTemp) Then
                TXTSearchItem_noTemp = ""
            End If
            If TXTSearchItem_noTemp = ItemNo1.Text Or TXTSearchItem_noTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the First record of this table.")
            Else
                ItemNo1.Text = TXTSearchItem_noTemp

                'Call FillFields(ItemNo1.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub PPreviousRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchItem_noTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Select Case ItemOrderFieldName.ToUpper.Trim
            Case "Item_No".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Item_No from Inv_Item where Item_No<" & Qt(TxtItem_No.Text) & " Order BY " & ItemOrderFieldName & " DESC"
            Case "Desc_Item".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Item_No from Inv_Item where desc_Item<" & Qt(TxtDesc_Item.Text) & " Order BY " & ItemOrderFieldName & " DESC"
            Case "Cod_item_type".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Item_No from Inv_Item where cod_item_type<" & Qt(CmbItemType.Text) & " Order BY " & ItemOrderFieldName & " DESC"
        End Select
        TXTSearchItem_noTemp = CmdGeneral.ExecuteScalar()
        CmdGeneral.Connection.Close()
        If IsNothing(TXTSearchItem_noTemp) Then
            TXTSearchItem_noTemp = ""
        End If
        If TXTSearchItem_noTemp = ItemNo1.Text Or TXTSearchItem_noTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the First record of this table.")
        Else
            ItemNo1.Text = TXTSearchItem_noTemp
            Item_noTempVar = TXTSearchItem_noTemp
            'Call FillFields(ItemNo1.Text)
        End If
    End Sub
    Private Sub PNextRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchItem_noTemp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If

        Select Case ItemOrderFieldName.ToUpper.Trim
            Case "Item_No".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Item_No from Inv_Item where Item_No>" & Qt(TxtItem_No.Text) & " Order BY " & ItemOrderFieldName & " ASC"
            Case "Desc_Item".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Item_No from Inv_Item where desc_Item>" & Qt(TxtDesc_Item.Text) & " Order BY " & ItemOrderFieldName & " ASC"
            Case "Cod_item_type".ToUpper
                CmdGeneral.CommandText = "SELECT Top 1 Item_No from Inv_Item where cod_item_type>" & Qt(CmbItemType.Text) & " Order BY " & ItemOrderFieldName & " ASC"
        End Select
        TXTSearchItem_noTemp = CmdGeneral.ExecuteScalar()
        CmdGeneral.Connection.Close()
        If IsNothing(TXTSearchItem_noTemp) Then
            TXTSearchItem_noTemp = ""
        End If
        If TXTSearchItem_noTemp = ItemNo1.Text Or TXTSearchItem_noTemp.Trim.Length = 0 Then
            If MsgShowFlag Then MsgFar("This is the Last record of this table.")
        Else
            ItemNo1.Text = TXTSearchItem_noTemp
            Item_noTempVar = TXTSearchItem_noTemp
            'Call FillFields(ItemNo1.Text)
        End If
    End Sub
    Private Sub PLastRecord(Optional ByVal MsgShowFlag As Boolean = True)
        Dim TXTSearchItem_noTemp As String

        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT Top 1 Item_No from Inv_Item Order BY " & ItemOrderFieldName & " DESC"
            '            ClearField()
            TXTSearchItem_noTemp = CmdGeneral.ExecuteScalar()
            CmdGeneral.Connection.Close()
            If IsNothing(TXTSearchItem_noTemp) Then
                TXTSearchItem_noTemp = ""
            End If
            If TXTSearchItem_noTemp = ItemNo1.Text Or TXTSearchItem_noTemp.Trim.Length = 0 Then
                If MsgShowFlag Then MsgFar("This is the Last record of this table.")
            Else
                ItemNo1.Text = TXTSearchItem_noTemp
                'Call FillFields(ItemNo1.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ItemNo1_FindItem_no() Handles ItemNo1.FindItemNo
        'ClearField()
        Dim back1 As String = Me.Text
        Me.Text = "Wait It is Loading ....."
        Call FillFields(ItemNo1.Text)
        Me.Text = back1
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
            ItemNo1.Focus()
        Else
            'GRDFWG.Height = GRDFWG.Height + PnlSearchHeight
        End If
    End Sub
    Private Sub FrmItem_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ItemNo1.Text = ""
    End Sub
    Private Sub PPrintMasterInformation()
        'If ItemNo1.text > 0 Then
        '    Dim Orpt As New RptInspectionMasterInformation
        '    DsFrmInspectionMaster1.Clear()
        '    DAInspectionMaster.SelectCommand.Parameters("@Item_No").Value = ItemNo1.text
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
        'TxtAvailable.Enabled = instatus
        'P1.Enabled = instatus
        'P2.Enabled = instatus
        'P3.Enabled = instatus
        'p4.Enabled = instatus
        'P5.Enabled = instatus
        'Paneltire.Enabled = instatus
        'PanelWheels.Enabled = instatus
        'PanelAutopart.Enabled = instatus
        '-------------
        TxtBrand.Enabled = instatus
        TxtStyle.Enabled = instatus
        Pl1.Enabled = instatus
        Pl2.Enabled = instatus
        Pl3.Enabled = instatus
        Pl4.Enabled = instatus
        Pl5.Enabled = instatus
        Pl6.Enabled = instatus
        '------------------
        Plf1.Enabled = instatus
        Plf2.Enabled = instatus
        Plf3.Enabled = instatus
        Plf4.Enabled = instatus
        Plf5.Enabled = instatus
        Plf6.Enabled = instatus
        '------------------
        TxtItem_No.Enabled = instatus
        TxtItem_No.Enabled = instatus
        'CmbItemType.SelectedValue = Nothing
        'ClearThisCombo(CmbItemType)
        CmbItemType.Enabled = instatus
        TxtDesc_Item.Enabled = instatus
        TxtBrand.Enabled = instatus
        TxtStyle.Enabled = instatus

        '  Cmbcod_quick_refrence.SelectedValue = ""
        ChkTaxable.Enabled = instatus
        'CmbLine.SelectedValue = Nothing
        'ItemNoteVar = ""
        ChkConsignment.Enabled = instatus
        ChkDiscontinued.Enabled = instatus
        TxtDiscontinued_date.Enabled = instatus
        TxtCost.Enabled = instatus

        'TxtListPrice.Text = "0"
        ' TxtFet.Text = "0"
        '        ClearThisCombo(CmbPrice_Code)
        CmbPrice_Code.Enabled = instatus
        TxtStart_date_on_sale.Enabled = instatus
        TxtEnd_date_on_sale.Enabled = instatus
        TxtAmount_Onsale.Enabled = instatus
        TxtStart_Date_Contract.Enabled = instatus
        TxtEnd_Date_Contract.Enabled = instatus
        Txtamount_contract.Enabled = instatus
        Txtstart_date_spiff.Enabled = instatus
        TxtEnd_date_spiff.Enabled = instatus
        TxtAmount_Spiff.Enabled = instatus
        TxtUpc.Enabled = instatus
        CmbBinLocation.Enabled = instatus
        Txtsection_width_inch.Enabled = instatus
        Cmbwidth_mm.Enabled = instatus
        Cmbaspect_ratio.Enabled = instatus
        TxtOnHand.Enabled = instatus

        TxtComitted.Enabled = instatus
        TxtAvailable.Enabled = instatus
        TxtOnOrder.Enabled = instatus
        TxtMin_stock.Enabled = instatus
        TxtMax_stock.Enabled = instatus
        TxtReorder.Enabled = instatus
        'ClearThisCombo(Cmbtire_Size)
        TxtSizeCod.Enabled = instatus
        Txtservice_description.Enabled = instatus
        'ClearThisCombo(CmbSidWall)
        CmbSidWall.Enabled = instatus
        'ClearThisCombo(CmbLoad_Range)
        CmbLoad_Range.Enabled = instatus
        TxtMsPn.Enabled = instatus
        Txtarticle_stock_no.Enabled = instatus
        Txtrim_width_range_inch.Enabled = instatus
        'ClearThisCombo(Cmbrim_diameter_inch)
        Cmbrim_diameter_inch.Enabled = instatus

        'ClearThisCombo(Cmbspeed_simbol)
        Cmbspeed_simbol.Enabled = instatus
        'ClearThisCombo(Cmbload_index)
        Cmbload_index.Enabled = instatus
        Txtoveral_diameter_inch.Enabled = instatus
        Txttread_depth.Enabled = instatus
        Txtwidth.Enabled = instatus
        Txtrevs_per_mile.Enabled = instatus
        Txtmax_load_lbs.Enabled = instatus
        txtmax_air_psl.Enabled = instatus
        Txtwieght_lbs.Enabled = instatus
        Txtoriginal_equipment.Enabled = instatus
        Txtply.Enabled = instatus
        'ClearThisCombo(Cmbwheel_size)
        Cmbwheel_size.Enabled = instatus
        'ClearThisCombo(CmbFinish)
        CmbFinish.Enabled = instatus

        Txtofset.Enabled = instatus
        Txtbackside.Enabled = instatus
        Txtbolt_pattern.Enabled = instatus
        Txtlug_size.Enabled = instatus
        Txtmax_diameter.Enabled = instatus
        Chkwarranty_track.Enabled = instatus
        Chkcore_track.Enabled = instatus
        Txtmiles.Enabled = instatus
        Txtdays.Enabled = instatus
        Txtcore_cost.Enabled = instatus
        PictureButton1.status = Status
        'clear all field 1
        '----------------------------------------------
        TxtItem_No.Enabled = instatus
        '        ClearThisCombo(CmbItemType)
        CmbItemType.Enabled = instatus
        TxtDesc_Item.Enabled = instatus
        '  ClearThisCombo(CmbCod_Brand)
        'ClearThisCombo(Cmbcod_quick_refrence)
        QuickReference1.Enabled = instatus
        ChkTaxable.Enabled = instatus
        ' ClearThisCombo(CmbStyle)
        'ClearThisCombo(CmbLine)
        Line1.Enabled = instatus
        'ItemNoteVar = ""
        TxtUpc.Enabled = instatus
        ChkConsignment.Enabled = instatus
        TxtDiscontinued_date.Enabled = instatus
        ChkDiscontinued.Enabled = instatus


        TxtListPrice.Enabled = instatus
        TxtFet.Enabled = instatus
        'ClearThisCombo(CmbPrice_Code)
        ' cmb()
        txtfrieght.Enabled = instatus
        TxtDelivery.Enabled = instatus
        'ClearThisCombo(CmbPrice_Code)



        ChkOnSale.Enabled = instatus
        TxtStart_date_on_sale.Enabled = instatus
        TxtEnd_date_on_sale.Enabled = instatus
        TxtAmount_Onsale.Enabled = instatus
        ChkContract.Enabled = instatus
        TxtStart_Date_Contract.Enabled = instatus
        TxtEnd_Date_Contract.Enabled = instatus
        Txtamount_contract.Enabled = instatus
        ChkSpiff.Enabled = instatus
        Txtstart_date_spiff.Enabled = instatus
        TxtEnd_date_spiff.Enabled = instatus
        TxtAmount_Spiff.Enabled = instatus

        TxtOnHand.Enabled = instatus
        TxtComitted.Enabled = instatus
        TxtAvailable.Enabled = instatus
        TxtMin_stock.Enabled = instatus
        TxtMax_stock.Enabled = instatus
        TxtReorder.Enabled = instatus



        'ClearThisCombo(Cmbtire_Size)
        Txtservice_description.Enabled = instatus
        'ClearThisCombo(CmbSidWall)
        CmbSidWall.Enabled = instatus
        CmbLoad_Range.Enabled = instatus
        TxtMsPn.Enabled = instatus
        Txtarticle_stock_no.Enabled = instatus
        Txtrim_width_range_inch.Enabled = instatus
        'ClearThisCombo(Cmbrim_diameter_inch)
        Cmbrim_diameter_inch.Enabled = instatus
        'ClearThisCombo(Cmbspeed_simbol)
        Cmbspeed_simbol.Enabled = instatus
        'ClearThisCombo(Cmbload_index)
        Cmbload_index.Enabled = instatus
        Txtoveral_diameter_inch.Enabled = instatus
        Txttread_depth.Enabled = instatus
        Txtwidth.Enabled = instatus
        Txtrevs_per_mile.Enabled = instatus
        Txtmax_load_lbs.Enabled = instatus
        txtmax_air_psl.Enabled = instatus
        Txtwieght_lbs.Enabled = instatus
        Txtoriginal_equipment.Enabled = instatus
        Txtply.Enabled = instatus

        'ClearThisCombo(Cmbwheel_size)
        Cmbwheel_size.Enabled = instatus
        'ClearThisCombo(CmbFinish)
        CmbFinish.Enabled = instatus
        Txtofset.Enabled = instatus
        Txtbackside.Enabled = instatus
        Txtbolt_pattern.Enabled = instatus
        Txtlug_size.Enabled = instatus
        Txtmax_diameter.Enabled = instatus



        Chkwarranty_track.Enabled = instatus
        Chkcore_track.Enabled = instatus
        Txtmiles.Enabled = instatus
        Txtdays.Enabled = instatus
        Txtcore_cost.Enabled = instatus

        Chkwarranty_track.Enabled = instatus
        Chkcore_track.Enabled = instatus
        Txtmiles.Enabled = instatus
        Txtdays.Enabled = instatus
        Txtdays.Enabled = instatus
        Txtcore_cost.Enabled = instatus

    End Sub
    Friend Sub ClearField()
        Try
            Me.SuspendLayout()
            BeforeCost = 0
            tXTDateCreated.Text = ""
            TxtAmountCreated.Text = ""

            LastChangeDatePrice.Text = ""
            LastCostPrice.Text = 0

            TxtBrand.Clear()
            TxtStyle.Clear()
            Pl1.Text = 0
            Pl2.Text = 0
            Pl3.Text = 0
            Pl4.Text = 0
            Pl5.Text = 0
            Pl6.Text = 0
            '------------------
            Plf1.Text = 0
            Plf2.Text = 0
            Plf3.Text = 0
            Plf4.Text = 0
            Plf5.Text = 0
            Plf6.Text = 0
            '------------------
            LblQref.Text = ""
            TxtItem_No.Text = ""
            TxtItem_No.Text = ""
            'CmbItemType.SelectedValue = Nothing
            ClearThisCombo(CmbItemType)
            ClearThisCombo(CmbBinLocation)
            TxtDesc_Item.Text = ""
            TxtBrand.Text = ""
            TxtStyle.Text = ""

            '  Cmbcod_quick_refrence.SelectedValue = ""
            ChkTaxable.Checked = False
            'CmbLine.SelectedValue = Nothing
            ItemNoteVar = ""
            ChkConsignment.Checked = False
            ChkDiscontinued.Checked = False
            TxtDiscontinued_date.Text = ""
            TxtCost.Text = "0"
            'TxtListPrice.Text = "0"
            ' TxtFet.Text = "0"
            ClearThisCombo(CmbPrice_Code)
            TxtStart_date_on_sale.Text = ""
            TxtEnd_date_on_sale.Text = ""
            TxtAmount_Onsale.Text = ""
            TxtStart_Date_Contract.Text = ""
            TxtEnd_Date_Contract.Text = ""
            Txtamount_contract.Text = ""
            Txtstart_date_spiff.Text = ""
            TxtEnd_date_spiff.Text = ""
            TxtAmount_Spiff.Text = ""
            TxtUpc.Text = ""

            TxtOnHand.Text = ""
            TxtOnOrder.Text = ""
            TxtComitted.Text = ""
            TxtAvailable.Text = 0
            TxtOnOrder.Text = 0
            TxtMin_stock.Text = ""
            TxtMax_stock.Text = ""
            TxtReorder.Text = ""
            'ClearThisCombo(Cmbtire_Size)

            TxtSizeCod.FieldCodValue = "0"
            TxtSize.Clear()
            Txtservice_description.Text = ""
            ClearThisCombo(CmbSidWall)
            ClearThisCombo(CmbLoad_Range)
            TxtMsPn.Text = ""
            Txtarticle_stock_no.Text = ""
            Txtrim_width_range_inch.Text = ""
            ClearThisCombo(Cmbrim_diameter_inch)
            ClearThisCombo(Cmbspeed_simbol)
            ClearThisCombo(Cmbload_index)
            Txtoveral_diameter_inch.Text = ""
            Txttread_depth.Text = ""
            Txtwidth.Text = ""
            Txtrevs_per_mile.Text = ""
            Txtmax_load_lbs.Text = ""
            txtmax_air_psl.Text = ""
            Txtwieght_lbs.Text = "0"
            Txtoriginal_equipment.Text = ""
            Txtply.Text = ""
            ClearThisCombo(Cmbwheel_size)
            ClearThisCombo(CmbFinish)
            Txtofset.Text = ""
            Txtbackside.Text = ""
            Txtbolt_pattern.Text = ""
            Txtlug_size.Text = ""
            Txtmax_diameter.Text = ""
            Chkwarranty_track.Checked = False
            Chkcore_track.Checked = False
            Txtmiles.Text = ""
            Txtdays.Text = ""
            Txtcore_cost.Text = ""
            PictureButton1.MyPicture = Nothing
            ItemNoteVar = ""
            'clear all field 1
            '----------------------------------------------
            TxtItem_No.Text = ""
            ClearThisCombo(CmbItemType)
            TxtDesc_Item.Text = ""
            '  ClearThisCombo(CmbCod_Brand)
            'ClearThisCombo(Cmbcod_quick_refrence)
            QuickReference1.Text = ""
            ChkTaxable.Checked = False
            ' ClearThisCombo(CmbStyle)
            'ClearThisCombo(CmbLine)
            Line1.Text = ""
            ItemNoteVar = ""
            TxtUpc.Text = ""
            ChkConsignment.Checked = False
            TxtDiscontinued_date.Text = ""
            ChkDiscontinued.Checked = False


            TxtListPrice.Text = "0"
            TxtFet.Text = "0"
            ClearThisCombo(CmbPrice_Code)
            txtfrieght.Text = ""
            TxtDelivery.Text = ""
            ClearThisCombo(CmbPrice_Code)



            ChkOnSale.Checked = False
            TxtStart_date_on_sale.Text = ""
            TxtEnd_date_on_sale.Text = ""
            TxtAmount_Onsale.Text = ""
            ChkContract.Checked = False
            TxtStart_Date_Contract.Text = ""
            TxtEnd_Date_Contract.Text = ""
            Txtamount_contract.Text = ""
            ChkSpiff.Checked = False
            Txtstart_date_spiff.Text = ""
            TxtEnd_date_spiff.Text = ""
            TxtAmount_Spiff.Text = ""

            TxtOnHand.Text = ""
            TxtComitted.Text = ""
            TxtAvailable.Text = ""
            TxtOnOrder.Text = ""
            TxtMin_stock.Text = ""
            TxtMax_stock.Text = ""
            TxtReorder.Text = ""



            'ClearThisCombo(Cmbtire_Size)
            Txtservice_description.Text = ""
            ClearThisCombo(CmbSidWall)
            CmbLoad_Range.SelectedValue = ""
            TxtMsPn.Text = ""
            Txtarticle_stock_no.Text = ""
            Txtrim_width_range_inch.Text = ""
            ClearThisCombo(Cmbrim_diameter_inch)
            ClearThisCombo(Cmbspeed_simbol)
            ClearThisCombo(Cmbload_index)
            Txtoveral_diameter_inch.Text = ""
            Txttread_depth.Text = ""
            Txtwidth.Text = ""
            Txtrevs_per_mile.Text = ""
            Txtmax_load_lbs.Text = ""
            txtmax_air_psl.Text = ""
            Txtwieght_lbs.Text = "0"
            Txtoriginal_equipment.Text = ""
            Txtply.Text = ""

            ClearThisCombo(Cmbwheel_size)
            ClearThisCombo(CmbFinish)
            Txtofset.Text = ""
            Txtbackside.Text = ""
            Txtbolt_pattern.Text = ""
            Txtlug_size.Text = ""
            Txtmax_diameter.Text = ""



            Chkwarranty_track.Checked = False
            Chkcore_track.Checked = False
            Txtmiles.Text = ""
            Txtdays.Text = ""
            Txtcore_cost.Text = ""

            Chkwarranty_track.Checked = False
            Chkcore_track.Checked = False
            Txtmiles.Text = ""
            Txtdays.Text = ""
            Txtcore_cost.Text = ""
            Dim Control1 As Control
            For Each Control1 In Paneltire.Controls
                If TypeOf (Control1) Is ComboBox Then
                    Call ClearThisCombo(CType(Control1, ComboBox))
                End If
                If TypeOf (Control1) Is TextBox Then
                    Try
                        CType(Control1, ComboBox).Text = ""
                    Catch ex As Exception
                    End Try
                End If
            Next

            For Each Control1 In PanelWheels.Controls
                If TypeOf (Control1) Is ComboBox Then
                    Call ClearThisCombo(CType(Control1, ComboBox))
                End If
                If TypeOf (Control1) Is TextBox Then
                    Try
                        CType(Control1, ComboBox).Text = ""
                    Catch ex As Exception
                    End Try
                End If

            Next

            For Each Control1 In PanelAutopart.Controls
                If TypeOf (Control1) Is ComboBox Then
                    Call ClearThisCombo(CType(Control1, ComboBox))
                End If
                If TypeOf (Control1) Is TextBox Then
                    Try
                        CType(Control1, ComboBox).Text = ""
                    Catch ex As Exception
                    End Try
                End If

            Next

            LastSaleDate.Text = ""
            LastSaleAmount.Text = ""
            lastrecevieDate.Text = ""
            lastreceiveamount.Text = ""
            LastAdjustmentDate.Text = ""
            lastAdjustmentamount.Text = ""
            LastChangeDatePrice.Text = ""
            LastCostPrice.Text = ""

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.ResumeLayout()
    End Sub
    Friend Function PInsert() As String
        Dim transtatus As Int16 = 0
        Dim CnnMdbSetup As New System.Data.OleDb.OleDbConnection(PConnectionStringForSetupTables)
        Dim MyFrmShowErrorAllStoreInsert As New FrmShowErrorAllStoreInsert
        Dim DASTORE_SETUP As New System.Data.OleDb.OleDbDataAdapter
        Dim OleDbCommand1 As New System.Data.OleDb.OleDbCommand
        Dim ij As Integer = 0
        Dim destconnectionstring As String = ""
        Dim BefAllStoreCommandCnnTmp As System.Data.SqlClient.SqlConnection = Cnn
        If Cnn.State <> ConnectionState.Open Then
            Cnn.Close()
        End If
        DASTORE_SETUP.SelectCommand = OleDbCommand1
        If ChkInsertToAllStore.Checked Then
            OleDbCommand1.CommandText = "SELECT STORENO,SHORTNAME FROM STORE_SETUP ORDER BY STORENO"
        Else
            OleDbCommand1.CommandText = "SELECT STORENO,SHORTNAME FROM STORE_SETUP where STORENO = " & Qt(PubStoreNO)
        End If
        OleDbCommand1.Connection = CnnMdbSetup
        Dim dstmp As New DataSet
        DASTORE_SETUP.Fill(dstmp, "allstore")
        If dstmp.Tables("allstore").Rows.Count > 0 Then
            For ij = 0 To dstmp.Tables("allstore").Rows.Count - 1
                Dim trans1 As SqlClient.SqlTransaction
                destconnectionstring = MakeConnectionSqlForThisStore(dstmp.Tables("allstore").Rows(ij).Item("Storeno"))
                Dim AllStoreCommandCnnTmp As New System.Data.SqlClient.SqlConnection
                If destconnectionstring.Trim & "" <> "" Then
                    AllStoreCommandCnnTmp.ConnectionString = destconnectionstring
                    Cnn = AllStoreCommandCnnTmp
                    CmdInsert.Connection = Cnn
                    Call SetInsertConnectionTo(Cnn)
                    Cnn.Open()
                    Try
                        trans1 = Cnn.BeginTransaction(IsolationLevel.RepeatableRead)
                        transtatus = -1
                        CmdInsert.Transaction = trans1
                        CmdInsertinv_item_cost_transaction.Transaction = trans1
                        CmdInsertinv_discount_item.Transaction = trans1
                        CmdInsertinv_tab_item_warehouse.Transaction = trans1
                        CmdInsertinv_tab_tire_specification.Transaction = trans1
                        CmdInsertinv_tab_wheels_specification.Transaction = trans1
                        CmdInsertinv_tab_autopart_specification.Transaction = trans1
                        If InsertInv_item() Then
                            If Insertinv_item_cost_transaction() Then
                                If Insertinv_discount_item() Then
                                    If Insertinv_tab_item_warehouse() Then
                                        Select Case CmbItemType.Text.ToUpper
                                            Case "tires".ToUpper
                                                If InsertInv_Tab_Tire_Specification() Then
                                                    transtatus = 1
                                                End If
                                            Case "Wheels".ToUpper
                                                If Insertinv_tab_wheels_specification() Then
                                                    transtatus = 1
                                                End If
                                            Case Else
                                                If Insertinv_tab_autopart_specification() Then
                                                    transtatus = 1
                                                End If
                                        End Select
                                    End If
                                End If
                            End If
                        End If
                        Select Case transtatus
                            Case 1
                                Try
                                    trans1.Commit()
                                    MyFrmShowErrorAllStoreInsert.LstNote.Items.Add(" Store no  " & dstmp.Tables("allstore").Rows(ij).Item("Storeno") & "  " & dstmp.Tables("allstore").Rows(ij).Item("Shortname") & "  Insert Complete ")

                                Catch ex As Exception
                                    MsgBox(ex.ToString)
                                End Try
                            Case -1
                                trans1.Rollback()
                                MyFrmShowErrorAllStoreInsert.LstNote.Items.Add(" Store no  " & dstmp.Tables("allstore").Rows(ij).Item("Storeno") & "  " & dstmp.Tables("allstore").Rows(ij).Item("Shortname") & "  Not Inserted ")

                        End Select
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    Finally
                        Cnn.Close()

                    End Try
                End If
            Next
        End If
        Call SetInsertConnectionTo(BefAllStoreCommandCnnTmp)
        If ChkInsertToAllStore.Checked And dstmp.Tables("allstore").Rows.Count > 1 Then
            MyFrmShowErrorAllStoreInsert.ShowDialog()
        Else
            ' nothing
        End If

        'Try
        '    Call InsertInv_item()
        'Catch ex As System.Data.SqlClient.SqlException
        '    Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
        '    Call PubErrHandle(myErrors.Item(0).Number)
        '    PInsert = ""
        '    TxtItem_No.Focus()
        '    Exit Function
        'End Try
        'Call Insertinv_item_cost_transaction()
        'Call Insertinv_discount_item()
        'Call Insertinv_tab_item_warehouse()
        'Select Case CmbItemType.Text.ToUpper
        '    Case "tires".ToUpper
        '        Call InsertInv_Tab_Tire_Specification()
        '    Case "Wheels".ToUpper
        '        Call Insertinv_tab_wheels_specification()
        '    Case Else
        '        Call Insertinv_tab_autopart_specification()
        'End Select
        PInsert = TxtItem_No.Text
    End Function
    Friend Function PUpdate(ByVal ThisItem_No As String) As Boolean
        PUpdate = True
        Try
            UpdateInv_Item()
        Catch ex As System.Data.SqlClient.SqlException
            Dim myErrors As System.Data.SqlClient.SqlErrorCollection = ex.Errors
            Call PubErrHandle(myErrors.Item(0).Number)
            PUpdate = False
        End Try
        Call Updateinv_item_cost_transaction()
        Call Updateinv_discount_item()
        Call Updateinv_tab_item_warehouse()
        Select Case CmbItemType.Text.ToUpper
            Case "tires".ToUpper
                Call UpdateInv_Tab_Tire_Specification()
            Case "Wheels".ToUpper
                Call Updateinv_tab_wheels_specification()
            Case Else
                Call Updateinv_tab_autopart_specification()
        End Select
    End Function
    Friend Function FillFields(ByVal ThisItem_No As String) As Boolean
        '        ClearField()
        Try
            FillFields = False
            If ThisItem_No.Trim.Length = 0 Then
                Exit Function
            End If
            Dim SQLReader As System.Data.SqlClient.SqlDataReader
            Try
                CmdGeneral.Connection.Close()
            Catch ex As Exception
            End Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "SELECT * from Inv_Item where Item_No=" & Qt(ThisItem_No.Trim)
            SQLReader = CmdGeneral.ExecuteReader
            If SQLReader.HasRows Then
                With SQLReader
                    .Read()
                    TxtAmountCreated.Text = Val(.Item("ItemFirstCost") & "")
                    tXTDateCreated.Text = .Item("ITEMCRATEDDATE") & ""

                    LastChangeDatePrice.Text = .Item("ItemChangeDatePrice") & ""
                    LastCostPrice.Text = .Item("ItemChangeCostPrice") & ""


                    TxtItem_No.Text = .Item("item_no")
                    CmbItemType.SelectedValue = .Item("Cod_item_type") & ""

                    TxtDesc_Item.Text = .Item("Desc_item") & ""
                    QuickReference1.FieldCodValue = .Item("cod_quick_refrence") & ""
                    ChkTaxable.Checked = .Item("Taxable") & ""
                    '     CmbStyle.SelectedValue = .Item("style") & ""
                    'CmbLine.SelectedValue = Trim(.Item("line") & "")
                    Line1.Text = Trim(.Item("line") & "")
                    Call FndBrandAndStyle()
                    ItemNoteVar = .Item("note") & ""
                    Try
                        PictureButton1.MyPicture = SQLReader.Item("Picture")
                    Catch ex As Exception
                    End Try
                    TxtUpc.Text = .Item("upc") & ""
                    Try
                        ChkConsignment.Checked = .Item("Consignment")
                    Catch ex As Exception

                    End Try
                    Try
                        TxtDiscontinued_date.Text = .Item("Discontinued_Date") & ""
                    Catch ex As Exception

                    End Try

                    Try
                        ChkDiscontinued.Checked = .Item("Discontinued")
                    Catch ex As Exception
                        ChkDiscontinued.Checked = False
                    End Try

                End With
                SQLReader.Close()
                '---------

                CmdGeneral.CommandText = "SELECT * from inv_item_cost_transaction where Item_No=" & Qt(ThisItem_No.Trim) & " And Last_Flag=1"
                SQLReader = CmdGeneral.ExecuteReader
                If SQLReader.HasRows Then
                    SQLReader.Read()
                    With SQLReader
                        TxtCost.Text = .Item("Cost") & ""
                        BeforeCost = Val(.Item("Cost") & "")
                        TxtListPrice.Text = .Item("List_Price") & ""
                        TxtFet.Text = .Item("Fet") & ""
                        CmbPrice_Code.SelectedValue = .Item("price_code") & ""
                        txtfrieght.Text = .Item("Frieght") & ""
                        TxtDelivery.Text = .Item("Delivery") & ""
                        CmbPrice_Code.SelectedValue = .Item("Price_code") & ""
                        Pl1.Text = .Item("amount_price1")
                        Pl2.Text = .Item("amount_price2")
                        Pl3.Text = .Item("amount_price3")
                        Pl4.Text = .Item("amount_price4")
                        Pl5.Text = .Item("amount_price5")
                        Pl6.Text = .Item("amount_price6")
                    End With
                End If
                SQLReader.Close()

                CmdGeneral.CommandText = "SELECT * from inv_discount_item where Item_No=" & Qt(ThisItem_No.Trim) & " And Last_Flag=1"
                SQLReader = CmdGeneral.ExecuteReader
                If SQLReader.HasRows Then
                    SQLReader.Read()
                    With SQLReader
                        ChkOnSale.Checked = .Item("onsale_check")
                        Try
                            TxtStart_date_on_sale.Text = .Item("Start_date_onsale") & ""
                        Catch ex As Exception
                        End Try
                        Try
                            TxtEnd_date_on_sale.Text = .Item("End_date_onsale") & ""
                        Catch ex As Exception
                        End Try

                        TxtAmount_Onsale.Text = .Item("Amount_Onsale") & ""

                        ChkContract.Checked = .Item("Contract_check")
                        Try
                            TxtStart_Date_Contract.Text = .Item("Start_Date_Contract") & ""
                        Catch ex As Exception

                        End Try

                        Try
                            TxtEnd_Date_Contract.Text = .Item("End_Date_Contract") & ""
                        Catch ex As Exception

                        End Try

                        Txtamount_contract.Text = .Item("amount_contract") & ""

                        ChkSpiff.Checked = .Item("Spiff_check")
                        Try
                            Txtstart_date_spiff.Text = .Item("start_date_spiff") & ""
                        Catch ex As Exception
                        End Try
                        Try
                            TxtEnd_date_spiff.Text = .Item("End_date_spiff") & ""
                        Catch ex As Exception
                        End Try

                        TxtAmount_Spiff.Text = .Item("Amount_Spiff") & ""

                    End With
                End If
                SQLReader.Close()
                CmdGeneral.CommandText = "SELECT * from inv_Tab_item_Warehouse where Item_No=" & Qt(ThisItem_No.Trim) & " And cod_warehouse = " & Qt(PWareHouse)
                SQLReader = CmdGeneral.ExecuteReader
                If SQLReader.HasRows Then
                    SQLReader.Read()
                    With SQLReader
                        TxtOnHand.Text = .Item("On_hand") & ""
                        TxtComitted.Text = .Item("Comitted") & ""
                        CmbBinLocation.SelectedValue = .Item("Cod_location")
                        TxtAvailable.Text = Val(TxtOnHand.Text) - Val(TxtComitted.Text)
                        TxtMin_stock.Text = Val("0" & .Item("Min_Stock"))
                        TxtMax_stock.Text = Val("0" & .Item("Max_stock"))
                        TxtReorder.Text = Val("0" & .Item("Reorde"))
                        TxtOnOrder.Text = Val("0" & .Item("on_order"))
                    End With

                Else
                    TxtOnHand.Text = ""
                    TxtComitted.Text = ""
                    TxtAvailable.Text = ""
                    TxtMin_stock.Text = ""
                    TxtMax_stock.Text = ""
                    TxtReorder.Text = ""
                    TxtOnOrder.Text = ""
                End If
                'Tab Tire 
                SQLReader.Close()
                CmdGeneral.CommandText = "SELECT * from inv_Tab_Tire_Specification where Item_No=" & Qt(ThisItem_No.Trim)
                SQLReader = CmdGeneral.ExecuteReader
                If SQLReader.HasRows Then
                    SQLReader.Read()
                    With SQLReader
                        'Cmbtire_Size.SelectedValue = .Item("tire_size")
                        TxtSizeCod.FieldCodValue = .Item("tire_size") & ""
                        Txtservice_description.Text = .Item("service_description") & ""
                        CmbSidWall.SelectedValue = .Item("SidWall")
                        CmbLoad_Range.SelectedValue = .Item("Load_Range") & ""
                        TxtMsPn.Text = .Item("MsPn") & ""
                        Txtarticle_stock_no.Text = .Item("article_stock_no") & ""
                        Txtrim_width_range_inch.Text = .Item("rim_width_range_inch") & ""
                        Cmbrim_diameter_inch.SelectedValue = .Item("rim_diameter_inch")
                        Cmbspeed_simbol.SelectedValue = .Item("speed_simbol") & ""
                        Cmbload_index.SelectedValue = .Item("load_index") & ""
                        Txtoveral_diameter_inch.Text = .Item("overal_diameter_inch") & ""
                        Txttread_depth.Text = .Item("tread_depth") & ""
                        Txtwidth.Text = .Item("tread_width") & ""
                        Txtrevs_per_mile.Text = .Item("revs_per_mile") & ""
                        Txtmax_load_lbs.Text = .Item("max_load_lbs") & ""
                        txtmax_air_psl.Text = .Item("max_air_psl") & ""
                        Txtwieght_lbs.Text = CDec(Val("" & .Item("wieght_lbs")))
                        Txtoriginal_equipment.Text = .Item("original_equipment") & ""
                        Txtply.Text = .Item("ply") & ""
                    End With
                Else
                    TxtSizeCod.FieldCodValue = ""
                    Txtservice_description.Text = ""
                    CmbSidWall.SelectedValue = ""
                    CmbLoad_Range.SelectedValue = ""
                    TxtMsPn.Text = ""
                    Txtarticle_stock_no.Text = ""
                    Txtrim_width_range_inch.Text = ""
                    Cmbrim_diameter_inch.SelectedValue = ""
                    Cmbspeed_simbol.SelectedValue = ""
                    Cmbload_index.SelectedValue = ""
                    Txtoveral_diameter_inch.Text = ""
                    Txttread_depth.Text = ""
                    Txtwidth.Text = ""
                    Txtrevs_per_mile.Text = ""
                    Txtmax_load_lbs.Text = ""
                    txtmax_air_psl.Text = ""
                    Txtwieght_lbs.Text = "0"
                    Txtoriginal_equipment.Text = ""
                    Txtply.Text = ""
                End If

                '- inv_tab_wheels_specification
                SQLReader.Close()
                CmdGeneral.CommandText = "SELECT * from inv_tab_wheels_specification where Item_No=" & Qt(ThisItem_No.Trim)
                SQLReader = CmdGeneral.ExecuteReader
                If SQLReader.HasRows Then
                    SQLReader.Read()
                    With SQLReader
                        Cmbwheel_size.SelectedValue = .Item("wheel_size") & ""
                        CmbFinish.SelectedValue = .Item("Finish")
                        Txtofset.Text = .Item("ofset") & ""
                        Txtbackside.Text = .Item("backside") & ""
                        Txtbolt_pattern.Text = .Item("bolt_pattern") & ""
                        Txtlug_size.Text = .Item("lug_size") & ""
                        Txtmax_diameter.Text = .Item("max_diameter") & ""
                    End With
                End If
                'inv_tab_autopart_specification
                SQLReader.Close()
                CmdGeneral.CommandText = "SELECT * from inv_tab_autopart_specification where Item_No=" & Qt(ThisItem_No.Trim)
                SQLReader = CmdGeneral.ExecuteReader
                If SQLReader.HasRows Then
                    SQLReader.Read()
                    With SQLReader
                        Chkwarranty_track.Checked = .Item("warranty_track")
                        Chkcore_track.Checked = .Item("core_track")
                        Txtmiles.Text = .Item("Miles") & ""
                        Txtdays.Text = .Item("days") & ""
                        Txtcore_cost.Text = .Item("core_cost") & ""
                    End With
                End If
                SQLReader.Close()
                'Dim newCnn As New System.Data.SqlClient.SqlConnection(PConnectionString)
                'DaLastServicecenter.SelectCommand.Connection = newCnn
                'DaLastReceive.SelectCommand.Connection = newCnn
                'DALastAdjustment.SelectCommand.Connection = newCnn\
                LastSaleDate.Text = ""
                LastSaleAmount.Text = ""
                lastrecevieDate.Text = ""
                lastreceiveamount.Text = ""
                LastAdjustmentDate.Text = ""
                lastAdjustmentamount.Text = ""
                '---------------------------
                Dim ds1 As New DataSet

                DaLastServicecenter.SelectCommand.Parameters(0).Value = ItemNo1.Text & ""
                DaLastServicecenter.Fill(ds1, "t0")
                If ds1.Tables("t0").Rows.Count > 0 Then
                    LastSaleDate.Text = ds1.Tables("t0").Rows(0).Item("date1") & ""
                    LastSaleAmount.Text = Val(ds1.Tables("t0").Rows(0).Item("lastAmount") & "")
                End If

                DaLastReceive.SelectCommand.Parameters(0).Value = ItemNo1.Text & ""
                DaLastReceive.Fill(ds1, "t1")
                If ds1.Tables("t1").Rows.Count > 0 Then
                    lastrecevieDate.Text = ds1.Tables("t1").Rows(0).Item("date1") & ""
                    lastreceiveamount.Text = Val(ds1.Tables("t1").Rows(0).Item("lastAmount") & "")
                End If

                DALastAdjustment.SelectCommand.Parameters(0).Value = ItemNo1.Text & ""
                DALastAdjustment.Fill(ds1, "t2")
                If ds1.Tables("t2").Rows.Count > 0 Then
                    LastAdjustmentDate.Text = ds1.Tables("t2").Rows(0).Item("date1") & ""
                    lastAdjustmentamount.Text = Val(ds1.Tables("t2").Rows(0).Item("lastAmount") & "")
                    'Else
                    '    LastAdjustmentDate.Text = ""
                    '    lastAdjustmentamount.Text = 0
                End If
                ds1.Clear()
                ' NumAmountCreated.Text = Txtcore_cost.Text

                'Val(TxtCost2.Text & "") + Val(TxtDelivery.Text & "") + Val(txtfrieght.Text & "")
                ''==================================================''
                FillFields = True
            Else
                Call ClearField()
            End If
            SQLReader.Close()
            CmdGeneral.Connection.Close()
            CalculatePriceCodePriceLevel()
            TxtSize.Text = TxtSizeCod.Text
        Catch ex As Exception
            MsgBox(ex.ToString)
            CmdGeneral.Connection.Close()
        End Try

    End Function
    Private Sub FillOtherFields()
        '''''''''''If TxtItem_No.Text.Trim.Length = 0 Then
        '''''''''''    Exit Sub
        '''''''''''End If
        '''''''''''Dim SQLReader As System.Data.SqlClient.SqlDataReader
        '''''''''''If CmdGeneral.Connection.State <> ConnectionState.Open Then
        '''''''''''    CmdGeneral.Connection.Open()
        '''''''''''End If
        '''''''''''CmdGeneral.CommandText = "SELECT * from Inv_Item where Item_No=" & TxtItem_No.Text '& " Order by "
        '''''''''''SQLReader = CmdGeneral.ExecuteReader
        '''''''''''If SQLReader.HasRows Then
        '''''''''''    SQLReader.Read()
        '''''''''''    'TXTCredit_Remaining.Text
        '''''''''''    'TXTLastPurchaseAmount.Text = Trim(SQLReader.Item("current_mileage"))
        '''''''''''    'TXTLastPurchaseDate.Text = Trim(SQLReader.Item("current_mileage"))
        '''''''''''    'TXTLastPurchaseInvoiceNo.Text = Trim(SQLReader.Item("current_mileage"))
        '''''''''''    'TXTLastPaymentAmount.Text
        '''''''''''    'TXTLastPaymentCheckNo.Text
        '''''''''''    'TXTLastPaymentDate.Text
        '''''''''''    'TXTNextPaymentAmount.Text
        '''''''''''    'TXTNextPaymentDate.Text
        '''''''''''    'TxtThisMonthPurchases.Text
        '''''''''''    'TxtThisYearDiscountsPurchases.Text
        '''''''''''    'TxtThisYearPurchases.Text
        '''''''''''Else
        '''''''''''    TXTCredit_Remaining.Text = ""
        '''''''''''    TXTLastPurchaseAmount.Text = ""
        '''''''''''    TXTLastPurchaseDate.Text = ""
        '''''''''''    TXTLastPurchaseInvoiceNo.Text = ""
        '''''''''''    TXTLastPaymentAmount.Text = ""
        '''''''''''    TXTLastPaymentCheckNo.Text = ""
        '''''''''''    TXTLastPaymentDate.Text = ""
        '''''''''''    TXTNextPaymentAmount.Text = ""
        '''''''''''    TXTNextPaymentDate.Text = ""
        '''''''''''    TxtThisMonthPurchases.Text = ""
        '''''''''''    TxtThisYearDiscountsPurchases.Text = ""
        '''''''''''    TxtThisYearPurchases.Text = ""
        '''''''''''End If
        '''''''''''SQLReader.Close()
        '''''''''''CmdGeneral.Connection.Close()
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
    Private Sub BtnNotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNotes.Click
        MyFrmItemComments = New CommonClass.FrmItemComments
        MyFrmItemComments.TxtComments.Text = ItemNoteVar & ""
        Call FitToScreen(BtnNotes, MyFrmItemComments)
        MyFrmItemComments.ThisFormStatus = Status
        MyFrmItemComments.ShowDialog()
        ItemNoteVar = MyFrmItemComments.TxtCommentvar
    End Sub
    Private Sub BtnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHistory.Click
        Dim MyForm As New FrmItemHistory
        MyForm.item = ItemNo1.item_no
        MyForm.Desc = ItemNo1.desc_item
        MyForm.ShowDialog()


    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Call showoptionaldata()
    End Sub
    Sub showoptionaldata()
        Select Case CmbItemType.Text.ToUpper
            Case "tires".ToUpper
                PanelAutopart.Visible = False
                PanelWheels.Visible = False
                Paneltire.Visible = True
                Paneltire.Left = 10
                Paneltire.Top = 40
            Case "Wheels".ToUpper
                PanelAutopart.Visible = False
                PanelWheels.Visible = True
                Paneltire.Visible = False
                PanelWheels.Left = 10
                PanelWheels.Top = 40
            Case Else
                PanelAutopart.Visible = True
                PanelWheels.Visible = False
                Paneltire.Visible = False
                PanelAutopart.Left = 10
                PanelAutopart.Top = 40
        End Select

    End Sub
    Function InsertInv_item() As Boolean
        InsertInv_item = True
        Call SetParameterInv_item(CmdInsert)
        If CmdInsert.Connection.State = ConnectionState.Closed Then
            CmdInsert.Connection.Open()
        End If
        Try
            CmdInsert.ExecuteScalar()
        Catch ex As Exception
            InsertInv_item = False
        End Try
    End Function
    Function UpdateInv_Item() As Boolean
        UpdateInv_Item = True
        Call SetParameterInv_item(CmdUpdate)
        If CmdUpdate.Connection.State = ConnectionState.Open Then
            CmdUpdate.Connection.Close()
        End If
        CmdUpdate.Connection.Open()
        Try
            CmdUpdate.ExecuteScalar()
            Call SavePictureInDataBase()
        Catch ex As Exception
            UpdateInv_Item = False
            MsgBox(ex.ToString)
        End Try
        CmdUpdate.Connection.Close()
    End Function
    Sub SetParameterInv_item(ByRef thisCmd As SqlCommand)
        With thisCmd
            .Parameters("@Item_No").Value = TxtItem_No.Text
            .Parameters("@cod_item_type").Value = ChkCombo(CmbItemType.SelectedValue)
            .Parameters("@Desc_item").Value = TxtDesc_Item.Text.Trim
            '    .Parameters("@cod_brand").Value = ChkCombo(CmbCod_Brand.SelectedValue)
            '.Parameters("@cod_quick_refrence").Value = ChkCombo(Cmbcod_quick_refrence.SelectedValue)
            .Parameters("@cod_quick_refrence").Value = QuickReference1.FieldCodValue
            .Parameters("@Taxable").Value = ChkTaxable.Checked
            '   .Parameters("@style").Value = ChkCombo(CmbStyle.SelectedValue)
            '.Parameters("@line").Value = ChkCombo(CmbLine.SelectedValue)
            .Parameters("@line").Value = ChkCombo(Line1.Text)
            .Parameters("@note").Value = ItemNoteVar.Trim
            .Parameters("@Picture").Value = IIf(IsNothing(PictureButton1.MyPicture), System.DBNull.Value, PictureButton1.MyPicture)
            .Parameters("@Upc").Value = TxtUpc.Text
            .Parameters("@Consignment").Value = ChkConsignment.Checked
            .Parameters("@Discontinued").Value = ChkDiscontinued.Checked
            .Parameters("@Discontinued_date").Value = TxtDiscontinued_date.Text
            .Parameters("@special_notice").Value = ""
            If Status = MainModule.WorkStates.AddNew Then
                .Parameters("@itemCreatedDate").Value = Format(Now.Date, PubDateFormat)
                .Parameters("@ItemFirstCost").Value = TxtCost.Text
            End If
            If Status = MainModule.WorkStates.Edit Then
                If Val(TxtCost.Text) <> BeforeCost Then
                    .Parameters("@ItemChangeDatePrice").Value = Format(Now.Date, PubDateFormat)
                    .Parameters("@ItemChangeCostPrice").Value = BeforeCost
                Else
                    .Parameters("@ItemChangeDatePrice").Value = LastChangeDatePrice.Text
                    .Parameters("@ItemChangeCostPrice").Value = CDec(Val("" & LastCostPrice.Text))
                End If

            End If


        End With
    End Sub
    'function FndType as stri
    Function Insertinv_item_cost_transaction() As Boolean
        Insertinv_item_cost_transaction = True
        Call SetParameterinv_item_cost_transaction(CmdInsertinv_item_cost_transaction)
        With CmdInsertinv_item_cost_transaction
            Try
                .ExecuteScalar()
            Catch ex As Exception
                Insertinv_item_cost_transaction = False
            End Try
        End With
        'myClsCommon.AllStoreCommand(CmdInsertinv_item_cost_transaction, Not ChkInsertToAllStore.Checked, False)
    End Function
    Function Updateinv_item_cost_transaction() As Boolean
        Updateinv_item_cost_transaction = True
        Call SetParameterinv_item_cost_transaction(CmdUpdateinv_item_cost_transaction, 2)
        With CmdUpdateinv_item_cost_transaction
            .Connection.Open()
            Try
                .ExecuteScalar()
            Catch ex As Exception
                Updateinv_item_cost_transaction = False
                MsgBox(ex.ToString)
            End Try
            .Connection.Close()
        End With
    End Function

    Sub SetParameterinv_item_cost_transaction(ByRef ThisCmd As SqlCommand, Optional ByVal instupdate As Integer = 1)
        With ThisCmd
            .Parameters("@item_no").Value = TxtItem_No.Text
            .Parameters("@date_cost_change").Value = CType(Format(Now, PubDateFormat), String)
            .Parameters("@cost").Value = Val(TxtCost.Text)
            .Parameters("@list_price").Value = Val(TxtListPrice.Text)
            .Parameters("@fet").Value = Val(TxtFet.Text)
            .Parameters("@delivery").Value = Val(TxtDelivery.Text.Trim)
            .Parameters("@frieght").Value = Val(txtfrieght.Text)

            If instupdate = 1 Then
                .Parameters("@last_flag").Value = True
            End If
            .Parameters("@price_code").Value = ChkCombo(CmbPrice_Code.SelectedValue)
            .Parameters("@amount_price1").Value = Val(Pl1.Text)
            .Parameters("@amount_price2").Value = Val(Pl2.Text)
            .Parameters("@amount_price3").Value = Val(Pl3.Text)
            .Parameters("@amount_price4").Value = Val(Pl4.Text)
            .Parameters("@amount_price5").Value = Val(Pl5.Text)
            .Parameters("@amount_price6").Value = Val(Pl6.Text)

        End With
    End Sub

    Function Insertinv_discount_item() As Boolean
        Insertinv_discount_item = True
        Call SetParameterinv_discount_item(CmdInsertinv_discount_item)
        With CmdInsertinv_discount_item
            Try
                .ExecuteScalar()
            Catch ex As Exception
                Insertinv_discount_item = False
            End Try
        End With
        '        myClsCommon.AllStoreCommand(CmdInsertinv_discount_item, Not ChkInsertToAllStore.Checked, False)
    End Function

    Function Updateinv_discount_item() As Boolean
        Updateinv_discount_item = True
        Call SetParameterinv_discount_item(CmdUpdateInv_discount_item)
        With CmdUpdateInv_discount_item
            .Connection.Open()
            Try
                .ExecuteScalar()
            Catch ex As Exception
                Updateinv_discount_item = False
                MsgBox(ex.ToString)
            End Try
            .Connection.Close()
        End With
    End Function

    Sub SetParameterinv_discount_item(ByRef THisCmd As SqlCommand)
        With THisCmd
            .Parameters("@item_no").Value = TxtItem_No.Text
            .Parameters("@onsale_check").Value = ChkOnSale.Checked
            .Parameters("@start_date_onsale").Value = TxtStart_date_on_sale.Text
            .Parameters("@end_date_onsale").Value = TxtEnd_date_on_sale.Text
            .Parameters("@amount_onsale").Value = Val(TxtAmount_Onsale.Text)
            .Parameters("@contract_check").Value = ChkContract.Checked
            .Parameters("@start_date_contract").Value = TxtStart_Date_Contract.Text
            .Parameters("@end_date_contract").Value = TxtEnd_Date_Contract.Text
            .Parameters("@amount_contract").Value = Val(Txtamount_contract.Text)
            .Parameters("@spiff_check").Value = ChkSpiff.Checked
            .Parameters("@start_date_spiff").Value = Txtstart_date_spiff.Text
            .Parameters("@end_date_spiff").Value = TxtEnd_date_spiff.Text
            .Parameters("@amount_spiff").Value = Val(TxtAmount_Spiff.Text)
            .Parameters("@last_flag").Value = 1
        End With
    End Sub
    Function Insertinv_tab_item_warehouse() As Boolean
        Insertinv_tab_item_warehouse = True
        Call SetParameterinv_tab_item_warehouse(CmdInsertinv_tab_item_warehouse)
        With CmdInsertinv_tab_item_warehouse

            Try
                .ExecuteScalar()
            Catch ex As Exception
                Insertinv_tab_item_warehouse = False
            End Try
        End With
        '        myClsCommon.AllStoreCommand(CmdInsertinv_tab_item_warehouse, Not ChkInsertToAllStore.Checked, False)
    End Function
    Function Updateinv_tab_item_warehouse() As Boolean
        Updateinv_tab_item_warehouse = True
        Call SetParameterinv_tab_item_warehouse(CmdUpdateinv_tab_item_warehouse, 2)
        With CmdUpdateinv_tab_item_warehouse
            .Connection.Open()
            Try
                .ExecuteScalar()
            Catch ex As Exception
                Updateinv_tab_item_warehouse = False
                MsgBox(ex.ToString)
            End Try
            .Connection.Close()
        End With
    End Function
    Sub SetParameterinv_tab_item_warehouse(ByRef THisCmd As SqlCommand, Optional ByVal instupdate As Integer = 1)
        With THisCmd
            .Parameters("@item_no").Value = TxtItem_No.Text
            .Parameters("@cod_warehouse").Value = PWareHouse
            If instupdate = 1 Then
                '.Parameters("@cod_location").Value = ChkCombo(CmbBinLocation.SelectedValue) by armandeh telefoni
                .Parameters("@on_hand").Value = 0
                .Parameters("@comitted").Value = 0
                .Parameters("@on_order").Value = 0
            End If
            .Parameters("@cod_location").Value = ChkCombo(CmbBinLocation.SelectedValue)
            .Parameters("@Min_Stock").Value = Val(TxtMin_stock.Text)
            .Parameters("@Max_stock").Value = Val(TxtMax_stock.Text)
            .Parameters("@Reorde").Value = Val(TxtReorder.Text)
        End With
    End Sub
    Function InsertInv_Tab_Tire_Specification() As Boolean
        InsertInv_Tab_Tire_Specification = True
        Call SetparameterInv_Tab_Tire_Specification(CmdInsertinv_tab_tire_specification)
        With CmdInsertinv_tab_tire_specification
            Try
                .ExecuteScalar()
            Catch ex As Exception
                InsertInv_Tab_Tire_Specification = False
            End Try
        End With
        '  myClsCommon.AllStoreCommand(CmdInsertinv_tab_tire_specification, Not ChkInsertToAllStore.Checked, False)
    End Function
    Function UpdateInv_Tab_Tire_Specification() As Boolean
        UpdateInv_Tab_Tire_Specification = True
        Call SetparameterInv_Tab_Tire_Specification(CmdUpdateinv_tab_tire_specification)
        With CmdUpdateinv_tab_tire_specification
            .Connection.Open()
            Try
                .ExecuteScalar()
            Catch ex As Exception
                UpdateInv_Tab_Tire_Specification = False
                MsgBox(ex.ToString)
            End Try
            .Connection.Close()
        End With
    End Function

    Sub SetparameterInv_Tab_Tire_Specification(ByRef ThisCmd As SqlCommand)
        With ThisCmd
            .Parameters("@item_no").Value = TxtItem_No.Text
            '.Parameters("@tire_size").Value = ChkCombo(Cmbtire_Size.SelectedValue)
            .Parameters("@Tire_size").Value = TxtSizeCod.FieldCodValue
            .Parameters("@service_description").Value = Txtservice_description.Text.Trim & ""
            .Parameters("@sidwall").Value = ChkCombo(CmbSidWall.SelectedValue)
            .Parameters("@load_range").Value = ChkCombo(CmbLoad_Range.SelectedValue)
            .Parameters("@mspn").Value = TxtMsPn.Text.Trim & ""
            .Parameters("@article_stock_no").Value = Txtarticle_stock_no.Text.Trim & ""
            '.Parameters("@rim_width_range_inch").Value=
            .Parameters("@rim_width_range_inch").Value = Txtrim_width_range_inch.Text.Trim ' ChkCombo(Cmbrim_diameter_inch.SelectedValue)
            .Parameters("@section_width_inch").Value = Txtsection_width_inch.Text.Trim & ""
            .Parameters("@width_mm").Value = Txtwidth.Text.Trim & ""
            .Parameters("@aspect_ratio").Value = ChkCombo(Cmbaspect_ratio.SelectedValue)
            .Parameters("@rim_diameter_inch").Value = ChkCombo(Cmbrim_diameter_inch.SelectedValue)
            .Parameters("@speed_simbol").Value = ChkCombo(Cmbspeed_simbol.SelectedValue)
            .Parameters("@load_index").Value = ChkCombo(Cmbload_index.SelectedValue)
            .Parameters("@overal_diameter_inch").Value = Txtoveral_diameter_inch.Text.Trim & ""
            .Parameters("@tread_depth").Value = Txttread_depth.Text.Trim & ""
            .Parameters("@tread_width").Value = Txtwidth.Text.Trim & ""
            .Parameters("@revs_per_mile").Value = Txtrevs_per_mile.Text.Trim & ""
            .Parameters("@max_load_lbs").Value = Txtmax_load_lbs.Text.Trim & ""
            .Parameters("@max_air_psl").Value = txtmax_air_psl.Text.Trim & ""
            .Parameters("@wieght_lbs").Value = CDec("0" & Txtwieght_lbs.Text.Trim)
            .Parameters("@original_equipment").Value = Txtoriginal_equipment.Text.Trim & ""
            .Parameters("@ply").Value = Txtply.Text.Trim & ""
        End With
    End Sub
    Function Insertinv_tab_wheels_specification() As Boolean
        Insertinv_tab_wheels_specification = True
        Call SetParameterinv_tab_wheels_specification(CmdInsertinv_tab_wheels_specification)
        With CmdInsertinv_tab_wheels_specification
            Try
                .ExecuteScalar()
            Catch ex As Exception
                Insertinv_tab_wheels_specification = False
            End Try

        End With
        'myClsCommon.AllStoreCommand(CmdInsertinv_tab_wheels_specification, Not ChkInsertToAllStore.Checked, False)
    End Function
    Function Updateinv_tab_wheels_specification() As Boolean
        Updateinv_tab_wheels_specification = True
        Call SetParameterinv_tab_wheels_specification(CmdUpdateinv_tab_wheels_specification)
        With CmdUpdateinv_tab_wheels_specification
            .Connection.Open()
            Try
                .ExecuteScalar()
            Catch ex As Exception
                Updateinv_tab_wheels_specification = False
                MsgBox(ex.ToString)
            End Try
            .Connection.Close()
        End With
    End Function
    Sub SetParameterinv_tab_wheels_specification(ByRef ThisCmd As SqlCommand)
        With ThisCmd
            .Parameters("@item_no").Value = TxtItem_No.Text.Trim
            .Parameters("@wheel_size").Value = ChkCombo(Cmbwheel_size.SelectedValue)
            .Parameters("@finish").Value = ChkCombo(CmbFinish.SelectedValue)
            .Parameters("@ofset").Value = Txtofset.Text.Trim
            .Parameters("@backside").Value = Txtbackside.Text.Trim
            .Parameters("@bolt_pattern").Value = Txtbolt_pattern.Text.Trim
            .Parameters("@lug_size").Value = Txtlug_size.Text.Trim
            .Parameters("@max_diameter").Value = Txtmax_diameter.Text.Trim
        End With
    End Sub

    Function Insertinv_tab_autopart_specification() As Boolean
        Insertinv_tab_autopart_specification = True
        Call SetParameterinv_tab_autopart_specification(CmdInsertinv_tab_autopart_specification)
        With CmdInsertinv_tab_autopart_specification
            Try
                .ExecuteScalar()
            Catch ex As Exception
                Insertinv_tab_autopart_specification = False
            End Try
        End With
        'myClsCommon.AllStoreCommand(CmdInsertinv_tab_autopart_specification, Not ChkInsertToAllStore.Checked, False)
    End Function
    Function Updateinv_tab_autopart_specification() As Boolean
        Updateinv_tab_autopart_specification = True
        Call SetParameterinv_tab_autopart_specification(CmdUpdateinv_tab_autopart_specification)
        With CmdUpdateinv_tab_autopart_specification

            .Connection.Open()
            Try
                .ExecuteScalar()
            Catch ex As Exception
                Updateinv_tab_autopart_specification = False
                MsgBox(ex.ToString)
            End Try
        End With
    End Function
    Sub SetParameterinv_tab_autopart_specification(ByRef thiscmd As SqlCommand)
        With thiscmd
            .Parameters("@item_no").Value = TxtItem_No.Text.Trim
            .Parameters("@warranty_track").Value = Chkwarranty_track.Checked
            .Parameters("@miles").Value = Val(Txtmiles.Text)
            .Parameters("@Days").Value = Val(Txtdays.Text)
            .Parameters("@core_track").Value = Chkcore_track.Checked
            .Parameters("@core_cost").Value = Val(Txtcore_cost.Text)
        End With
    End Sub
    Private Sub CmbItemType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbItemType.SelectedIndexChanged
        Call showoptionaldata()
    End Sub
    Private Sub CmbPrice_Code_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPrice_Code.SelectedIndexChanged, CmbPrice_Code.SelectedValueChanged
        Call CalculatePriceCodePriceLevel()
    End Sub
    Sub CalculatePriceCodePriceLevel()
        ' -------------changed by ketabi - start - 84-04-14 ----------------------------------------------
        ' -------------changed by ketabi - start - 84-04-14 ----------------------------------------------
        ' -------------changed by ketabi - start - 84-04-14 ----------------------------------------------
        '''' If Pl1.Enabled = True Then
        Pl1.Text = CalculatePriceCode(1)
        Pl2.Text = CalculatePriceCode(2)
        Pl3.Text = CalculatePriceCode(3)
        Pl4.Text = CalculatePriceCode(4)
        Pl5.Text = CalculatePriceCode(5)
        Pl6.Text = CalculatePriceCode(6)
        '''' End If
        ' -------------changed by ketabi - END - 84-04-14 ----------------------------------------------
    End Sub
    Function CalculatePriceCode(ByVal Thislevel As Integer) As Decimal
        CalculatePriceCode = ItemNo1.ClsItem_No1.CalculatePriceCode(CmbPrice_Code.SelectedValue, Thislevel, TxtCost.Text, TxtListPrice.Text)
        'Dim calculate As Decimal = 0
        'Dim Amount1 As Decimal = 0
        'Dim price As String = "price" & Trim(Thislevel) & "_c_l_a_p"
        'Dim price_amount As String = "price" & Trim(Thislevel) & "_Amount"
        'Dim price_persent As String = "price" & Trim(Thislevel) & "_d_persent"
        'Dim price_operator As String = "price" & Trim(Thislevel) & "_operator"
        'Dim price_odd_price As String = "price" & Trim(Thislevel) & "_odd_price"
        'Dim price_price_level As String = "price" & Trim(Thislevel) & "_price_level"
        'Dim drow As DataRow = DsInvItemProduct1.inv_price_code.FindByprice_code(CmbPrice_Code.SelectedValue)
        'Try
        '    Select Case CType(drow.Item(price), String).ToUpper
        '        Case "L".ToUpper
        '            calculate = Val(TxtListPrice.Text)
        '        Case "C".ToUpper
        '            calculate = Val(TxtCost.Text)
        '        Case "a".ToUpper
        '        Case "p".ToUpper
        '            calculate = CalculatePriceCode(drow.Item(price_price_level))
        '    End Select
        '    Amount1 = Val(drow.Item(price_amount))
        '    Select Case drow.Item(price_persent) & ""
        '        Case "%"
        '            Amount1 = (calculate * Amount1) / 100
        '        Case "$"
        '            Amount1 = Amount1
        '    End Select
        '    Select Case drow.Item(price_operator)
        '        Case "-"
        '            calculate = calculate - Amount1
        '        Case "+"
        '            calculate = calculate + Amount1
        '        Case "/"
        '            calculate = calculate / Amount1
        '        Case "*", "x", "X"
        '            calculate = calculate * Amount1
        '    End Select
        '    calculate = Int(calculate) + CDec("0" & drow(price_odd_price))
        'Catch ex As Exception
        'End Try
        'CalculatePriceCode = calculate
    End Function
    Private Sub Pl1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pl1.TextChanged, Pl2.TextChanged, Pl3.TextChanged, Pl4.TextChanged, Pl5.TextChanged, Pl6.TextChanged
        Call SaveButtonControl()
        Call CalculatepricePlusFet()
    End Sub
    Sub CalculatepricePlusFet()
        Try
            Plf1.Text = Val(Pl1.Text) + Val(TxtFet.Text)
            Plf2.Text = Val(Pl2.Text) + Val(TxtFet.Text)
            Plf3.Text = Val(Pl3.Text) + Val(TxtFet.Text)
            Plf4.Text = Val(Pl4.Text) + Val(TxtFet.Text)
            Plf5.Text = Val(Pl5.Text) + Val(TxtFet.Text)
            Plf6.Text = Val(Pl6.Text) + Val(TxtFet.Text)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub TxtDesc_Item_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDesc_Item.TextChanged, TxtItem_No.TextChanged, TxtUpc.TextChanged, ChkDiscontinued.TextChanged, TxtCost.TextChanged, TxtListPrice.TextChanged, TxtFet.TextChanged, TxtDelivery.TextChanged, TxtAmount_Onsale.TextChanged, Txtamount_contract.TextChanged, TxtAmount_Spiff.TextChanged, TxtOnHand.TextChanged, TxtComitted.TextChanged, TxtAvailable.TextChanged, TxtMin_stock.TextChanged, TxtMax_stock.TextChanged, TxtReorder.TextChanged, Txtservice_description.TextChanged, TxtMsPn.TextChanged, Txtarticle_stock_no.TextChanged, Txtrim_width_range_inch.TextChanged, Txtoveral_diameter_inch.TextChanged, Txttread_depth.TextChanged, Txtwidth.TextChanged, Txtrevs_per_mile.TextChanged, Txtmax_load_lbs.TextChanged, txtmax_air_psl.TextChanged, Txtwieght_lbs.TextChanged, Txtoriginal_equipment.TextChanged, Txtply.TextChanged, Txtofset.TextChanged, Txtbackside.TextChanged, Txtbolt_pattern.TextChanged, Txtlug_size.TextChanged, Txtmax_diameter.TextChanged, Txtmiles.TextChanged, Txtdays.TextChanged, Txtcore_cost.TextChanged, Txtmiles.TextChanged, Txtdays.TextChanged, Txtcore_cost.TextChanged, txtfrieght.TextChanged, TxtSizeCod.TextChanged, QuickReference1.TextChanged
        CalculatePriceCodePriceLevel()
        Call CalculatepricePlusFet()
        TxtDesc_Item2.Text = TxtDesc_Item.Text
        SaveButtonControl()
    End Sub
    Private Sub Other_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbItemType.SelectedIndexChanged, CmbPrice_Code.SelectedIndexChanged, CmbPrice_Code.SelectedIndexChanged, Cmbrim_diameter_inch.SelectedIndexChanged, Cmbspeed_simbol.SelectedIndexChanged, Cmbload_index.SelectedIndexChanged, Cmbwheel_size.SelectedIndexChanged, CmbFinish.SelectedIndexChanged, CmbLoad_Range.SelectedIndexChanged, CmbSidWall.SelectedIndexChanged, CmbBinLocation.SelectedIndexChanged
        SaveButtonControl()
    End Sub
    'Private Sub CmbLine_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Call FndBrandAndStyle()
    '    SaveButtonControl()
    'End Sub
    Private Sub ChkOnSale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkOnSale.CheckedChanged, _
       ChkTaxable.CheckedChanged, ChkConsignment.CheckedChanged, ChkDiscontinued.CheckedChanged, _
        ChkOnSale.CheckedChanged, ChkContract.CheckedChanged, ChkSpiff.CheckedChanged, _
        Chkwarranty_track.CheckedChanged, Chkcore_track.CheckedChanged, Chkwarranty_track.CheckedChanged, Chkcore_track.CheckedChanged
        SaveButtonControl()
    End Sub
    Sub FndBrandAndStyle()
        Dim dr As DataRow
        Try
            dr = DsInvItemProduct1.inv_tab_line.FindByline(Line1.Text)
            TxtBrand.Text = dr("complete_desc_brand") & ""
            TxtStyle.Text = dr("desc_style") & ""
        Catch ex As Exception
            TxtBrand.Text = ""
            TxtStyle.Text = ""
        End Try
    End Sub
    Private Sub CmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLoad.Click
        Select Case CmbItemType.Text.ToUpper
            Case "tires".ToUpper
                TxtDesc_Item.Text = Desc_ItemPublic.Trim
            Case "Wheels".ToUpper
            Case Else
        End Select
    End Sub
    Private Sub Utqg1_BeforeClick() Handles Utqg1.BeforeClick
        'Utqg1.Line = CmbLine.SelectedValue
        Utqg1.Line = Line1.Text
    End Sub
    Private Sub InvLine_Detail1_BeforeClick() Handles InvLine_Detail1.BeforeClick
        'InvLine_Detail1.Line = CmbLine.SelectedValue
        InvLine_Detail1.Line = Line1.Text
    End Sub
    Private Sub PictureButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureButton1.Click
        PictureButton1.status = Status
        Call SaveButtonControl()
    End Sub
    Private Sub WorkOrderOfItem1_BeforeClick() Handles WorkOrderOfItem1.BeforeClick
        WorkOrderOfItem1.Item_no = TxtItem_No.Text
    End Sub
    Private Sub SavePictureInDataBase()
        PictureButton1.SavePicture(Cnn, "Inv_Item", "Picture", "WHERE Item_No=" & Qt(TxtItem_No.Text))
    End Sub
    Private Sub TxtSizeCod_AfterFieldCodValueFind(ByVal ThisRow As System.Data.DataRow) Handles TxtSizeCod.AfterFieldCodValueFind
        TxtSize.Text = TxtSizeCod.Text
    End Sub
    Private Sub MyFrm1_Item_noFind(ByVal ThisItemCode As String, ByVal ThisItemDesc As String) Handles MyFrm1.Item_noFind
        If ThisItemCode <> "" Then
            ItemNo1.Text = ThisItemCode
        End If
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        MyFrm1 = New UCInv_Item.FrmSearchItemCode
        MyFrm1.ShowDialog()
    End Sub
    Private Sub MyclsItemno_AfterCalculateSumReceived(ByVal SumParts As Decimal, ByVal Sumfet1 As Decimal, ByVal SumTax As Decimal, ByVal SumTotal As Decimal, ByVal SumTotalQty As Decimal, ByVal SumW As Decimal) Handles MyclsItemno.AfterCalculateSumReceived
        lastreceiveamount.Text = Format(CDec("0" & SumTotal), "C").Replace("$", "")    'SumParts + Sumfet1
    End Sub
    Private Sub MyclsItemno_AfterCalculateSumInventoryAdjustment(ByVal SumParts As Decimal, ByVal SumFET As Decimal, ByVal SumTotal As Decimal, ByVal SumTotQty As Long) Handles MyclsItemno.AfterCalculateSumInventoryAdjustment
        lastAdjustmentamount.Text = Format(CDec("0" & SumTotal), "C").Replace("$", "")
    End Sub
    Private Sub QuickReference1_AfterFieldCodValueFind(ByVal ThisRow As System.Data.DataRow) Handles QuickReference1.AfterFieldCodValueFind
        LblQref.Text = ThisRow(1) & ""
    End Sub
    Private Sub TxtSizeCod_ExecuteFrmSizeAddNew() Handles TxtSizeCod.ExecuteFrmSizeAddNew
        Dim ar(0) As Object
        ar(0) = "401140100" 'Ready comments
        Dim tempAssembly As System.Reflection.Assembly
        tempAssembly = System.Reflection.Assembly.LoadFrom(Application.StartupPath & "\" & "FormGenerator.dll")
        Dim t As Type = tempAssembly.GetType("FormGenerator.FrmGeneral")
        Dim c As Form = CType(Activator.CreateInstance(t, ar), Form)
        c.ShowDialog()
    End Sub
    Sub FixthisDatabase()
        CmdGeneral.CommandText = "alter table inv_item add ItemChangeDatePrice char(10) "

        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try

        CmdGeneral.CommandText = "alter table inv_item add ItemChangeCostPrice money "
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Try
            CmdGeneral.ExecuteNonQuery()
        Catch ex As Exception
        End Try
    End Sub


    'Public Sub AllStoreCommand(ByVal ThisCmd As System.Data.SqlClient.SqlCommand, Optional ByVal OneStoreFlag As Boolean = True, Optional ByVal showErrors As Boolean = True)
    '    Dim CnnMdbSetup As New System.Data.OleDb.OleDbConnection(PConnectionStringForSetupTables)
    '    Dim MyFrmShowErrorAllStoreInsert As New FrmShowErrorAllStoreInsert
    '    Dim DASTORE_SETUP As New System.Data.OleDb.OleDbDataAdapter
    '    Dim OleDbCommand1 As New System.Data.OleDb.OleDbCommand
    '    Dim ij As Integer = 0
    '    Dim destconnectionstring As String = ""
    '    Dim BefAllStoreCommandCnnTmp As System.Data.SqlClient.SqlConnection = ThisCmd.Connection
    '    If ThisCmd.Connection.State = ConnectionState.Open Then
    '        ThisCmd.Connection.Close()
    '    End If

    '    If Not OneStoreFlag Then
    '        DASTORE_SETUP.SelectCommand = OleDbCommand1
    '        OleDbCommand1.CommandText = "SELECT STORENO,SHORTNAME FROM STORE_SETUP ORDER BY STORENO"
    '        OleDbCommand1.Connection = CnnMdbSetup
    '        Dim dstmp As New DataSet
    '        DASTORE_SETUP.Fill(dstmp, "allstore")
    '        If dstmp.Tables("allstore").Rows.Count > 0 Then
    '            For ij = 0 To dstmp.Tables("allstore").Rows.Count - 1
    '                destconnectionstring = MakeConnectionSqlForThisStore(dstmp.Tables("allstore").Rows(ij).Item("Storeno"))
    '                Dim AllStoreCommandCnnTmp As New System.Data.SqlClient.SqlConnection
    '                If destconnectionstring.Trim & "" <> "" Then
    '                    AllStoreCommandCnnTmp.ConnectionString = destconnectionstring
    '                    ThisCmd.Connection = AllStoreCommandCnnTmp
    '                    ThisCmd.Connection.Open()
    '                    Try
    '                        ThisCmd.ExecuteNonQuery()
    '                        MyFrmShowErrorAllStoreInsert.LstNote.Items.Add(" Store no  " & dstmp.Tables("allstore").Rows(ij).Item("Storeno") & "  " & dstmp.Tables("allstore").Rows(ij).Item("StoreName") & "  Insert Complete ")
    '                    Catch ex As Exception
    '                        MyFrmShowErrorAllStoreInsert.LstNote.Items.Add(" Store no  " & dstmp.Tables("allstore").Rows(ij).Item("Storeno") & "  " & dstmp.Tables("allstore").Rows(ij).Item("StoreName") & " Not Inserted ")
    '                        RaiseEvent FindErrorInMultiStoreAdd(ex, ThisCmd, dstmp.Tables("allstore").Rows(ij).Item("Storeno"), dstmp.Tables("allstore").Rows(ij).Item("StoreName"))
    '                    Finally
    '                        ThisCmd.Connection.Close()
    '                    End Try
    '                End If
    '            Next
    '        End If
    '        ThisCmd.Connection = BefAllStoreCommandCnnTmp
    '    Else

    '        ThisCmd.Connection = BefAllStoreCommandCnnTmp
    '        ThisCmd.Connection.Open()
    '        Try
    '            ThisCmd.ExecuteNonQuery()
    '        Catch ex As Exception
    '            RaiseEvent FindErrorInMultiStoreAdd(ex, ThisCmd, PubStoreNO, PubStoreName)
    '        Finally
    '            ThisCmd.Connection.Close()
    '        End Try
    '    End If
    '    If showErrors = True And OneStoreFlag = False Then
    '        MyFrmShowErrorAllStoreInsert.ShowDialog()
    '    End If
    'End Sub
    Sub SetInsertConnectionTo(ByVal ThisCnn)
        CmdInsertinv_item_cost_transaction.Connection = ThisCnn
        CmdInsertinv_discount_item.Connection = ThisCnn
        CmdInsertinv_tab_item_warehouse.Connection = ThisCnn
        CmdInsertinv_tab_tire_specification.Connection = ThisCnn
        CmdInsertinv_tab_wheels_specification.Connection = ThisCnn
        CmdInsertinv_tab_autopart_specification.Connection = ThisCnn
    End Sub
    Private Sub BtnVendor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVendor.Click
        Dim MyFrmItemVendors As New FrmItemVendors
        MyFrmItemVendors.Item_no = ItemNo1.Text.Trim & ""
        MyFrmItemVendors.ShowDialog()
    End Sub
    Private Sub Line1_FindLineRow(ByVal ThisRow As System.Data.DataRow) Handles Line1.FindLineRow
        TxtBrand.Text = ThisRow("complete_desc_brand") & ""
        TxtStyle.Text = ThisRow("desc_style") & ""
        SaveButtonControl()
    End Sub
    Private Sub Line1_NotFindLineCode() Handles Line1.NotFindLineCode
        TxtBrand.Text = ""
        TxtStyle.Text = ""
        SaveButtonControl()
    End Sub
    Private Sub QuickReference1_NotFind() Handles QuickReference1.NotFind
        LblQref.Text = ""
    End Sub

    Private Sub ItemNo1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemNo1.Load

    End Sub
End Class
