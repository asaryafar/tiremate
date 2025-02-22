Imports CommonClass
Imports System.Drawing.Imaging
Imports System.IO
Public Class FrmItemDetailShow
    Inherits FrmBase
    Private MItem_no As String = ""
    Dim MyDS As New DataSet
    Dim PTax As Decimal = 0.4
    Dim flagcalculate As Boolean = False
    Dim img1 As Image
    Dim img2 As Image
    Dim GlobalCost As Decimal = 0
    Dim GlobalPrice As Decimal = 0
    Dim GlobalPriceCod As String = ""
    Friend WithEvents ItemNo1 As UCInv_Item.ItemNo
    Dim WithEvents MyclsItemno As Clsitem_no
    Dim i As Integer
    Dim TxtBalanceTax As Boolean = False
    Dim TxtTireFeeTax As Boolean = False
    Dim TxtDisposalFeeTax As Boolean = False
    Dim TxtValueStemTax As Boolean = False
    Dim TxtRoadHazardTax As Boolean = False
    Dim WithEvents MyZipCode As UCZipCode.ClsZipCode

    Property Item_No() As String
        Get
            Return MItem_no
        End Get
        Set(ByVal Value As String)
            MItem_no = Value
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DaInvItem As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaInVDiscountItem As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmbPrice As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPrice1 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents TxtPrice2 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents TxtFet2 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents TxtFet1 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents ChkRoadHazard As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkValueSteam As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkDisposalFee As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkTireFee As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkBalance As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaBalance As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents DaTireFee As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaDisposalFee As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaValueStem As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaRoadHazard As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TxtFet As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents TxtOnSale As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Qty2 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Qty1 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Txt_avail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_Desc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtItem_No As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents LineDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Note As System.Windows.Forms.TextBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents IconBrand As System.Windows.Forms.PictureBox
    Friend WithEvents sdfsdf As System.Windows.Forms.Label
    Friend WithEvents TxtTS As System.Windows.Forms.TextBox
    Friend WithEvents TxtSd As System.Windows.Forms.TextBox
    Friend WithEvents TxtSW As System.Windows.Forms.TextBox
    Friend WithEvents txtRW As System.Windows.Forms.TextBox
    Friend WithEvents TxtOd As System.Windows.Forms.TextBox
    Friend WithEvents TxtTd As System.Windows.Forms.TextBox
    Friend WithEvents TxtMl As System.Windows.Forms.TextBox
    Friend WithEvents t1 As System.Windows.Forms.Label
    Friend WithEvents t2 As System.Windows.Forms.Label
    Friend WithEvents t3 As System.Windows.Forms.Label
    Friend WithEvents Image_Remark As System.Windows.Forms.PictureBox
    Friend WithEvents limit_warranty As System.Windows.Forms.Label
    Friend WithEvents Panel23 As System.Windows.Forms.Panel
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents MaskedEditBox17 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Panel24 As System.Windows.Forms.Panel
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Panel25 As System.Windows.Forms.Panel
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents MaskedEditBox22 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents MaskedEditBox25 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents MaskedEditBox27 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents MaskedEditBox28 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents MaskedEditBox29 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents MaskedEditBox30 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents MaskedEditBox32 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents MaskedEditBox34 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents MaskedEditBox35 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents MaskedEditBox36 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents MaskedEditBox37 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents TxtReOrder As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents TxtMaxStock As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents TxtMinStock As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents TxtOnOrder As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents TxtAvailable As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents TxtComitted As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents TxtOnHand As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaSalePerformance As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsInv_Item1 As UCInv_Item.DSInv_Item
    Friend WithEvents ChkSpiff As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkContract As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkOnSale As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents end_date_spiff As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents end_date_contract As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents end_date_onsale As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents start_date_spiff As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents start_date_contract As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents start_date_onsale As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents amount_spiff As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents amount_contract As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents amount_onsale As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents CmdCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents GrdSalePerformance As Janus.Windows.GridEX.GridEX
    Friend WithEvents TxtFriegt As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents TxtDelivery As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents TxtCost As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents CmbVendor As System.Windows.Forms.ComboBox
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaInvItemVendor As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TxtVendorPartno As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents TxtReplCost As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents ChkDiscontinued As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents ChkConsighment As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents l6 As System.Windows.Forms.Label
    Friend WithEvents l5 As System.Windows.Forms.Label
    Friend WithEvents l4 As System.Windows.Forms.Label
    Friend WithEvents l3 As System.Windows.Forms.Label
    Friend WithEvents l2 As System.Windows.Forms.Label
    Friend WithEvents l1 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaInTab_Labor_Service As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents LastReceiveAmount As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents LastReceiveDate As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Pl1 As CalcUtils.UcCalcText
    Friend WithEvents Pl2 As CalcUtils.UcCalcText
    Friend WithEvents pl3 As CalcUtils.UcCalcText
    Friend WithEvents pl4 As CalcUtils.UcCalcText
    Friend WithEvents pl5 As CalcUtils.UcCalcText
    Friend WithEvents pl6 As CalcUtils.UcCalcText
    Friend WithEvents Plf1 As CalcUtils.UcCalcText
    Friend WithEvents plf2 As CalcUtils.UcCalcText
    Friend WithEvents plf3 As CalcUtils.UcCalcText
    Friend WithEvents plf4 As CalcUtils.UcCalcText
    Friend WithEvents plf5 As CalcUtils.UcCalcText
    Friend WithEvents plf6 As CalcUtils.UcCalcText
    Friend WithEvents SubTotal2 As CalcUtils.UcCalcText
    Friend WithEvents Total1 As CalcUtils.UcCalcText
    Friend WithEvents Total2 As CalcUtils.UcCalcText
    Friend WithEvents Subtotal1 As CalcUtils.UcCalcText
    Friend WithEvents Tax1 As CalcUtils.UcCalcText
    Friend WithEvents Tax2 As CalcUtils.UcCalcText
    Friend WithEvents p4 As System.Windows.Forms.Panel
    Friend WithEvents TxtAmountCreated As CalcUtils.UcCalcText
    Friend WithEvents UcCalcText2 As CalcUtils.UcCalcText
    Friend WithEvents lastAdjustmentamount As CalcUtils.UcCalcText
    Friend WithEvents UcCalcText1 As CalcUtils.UcCalcText
    Friend WithEvents UcCalcText3 As CalcUtils.UcCalcText
    Friend WithEvents LastSaleAmount As CalcUtils.UcCalcText
    Friend WithEvents tXTDateCreated As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents MaskedEditBox1 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents LastAdjustmentDate As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents MaskedEditBox2 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents lastrecevieDate As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents LastSaleDate As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents MaskedEditBox31 As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents DaLastReceive As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DALastAdjustment As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaLastServicecenter As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents TxtBalance As CalcUtils.UcCalcText
    Friend WithEvents TxtTireFee As CalcUtils.UcCalcText
    Friend WithEvents TxtDisposalFee As CalcUtils.UcCalcText
    Friend WithEvents TxtValueStem As CalcUtils.UcCalcText
    Friend WithEvents TxtRoadHazard As CalcUtils.UcCalcText
    Friend WithEvents CmdPrint As Janus.Windows.EditControls.UIButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmItemDetailShow))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.plf6 = New CalcUtils.UcCalcText
        Me.plf5 = New CalcUtils.UcCalcText
        Me.plf4 = New CalcUtils.UcCalcText
        Me.plf3 = New CalcUtils.UcCalcText
        Me.plf2 = New CalcUtils.UcCalcText
        Me.Plf1 = New CalcUtils.UcCalcText
        Me.pl6 = New CalcUtils.UcCalcText
        Me.pl5 = New CalcUtils.UcCalcText
        Me.pl4 = New CalcUtils.UcCalcText
        Me.pl3 = New CalcUtils.UcCalcText
        Me.Pl2 = New CalcUtils.UcCalcText
        Me.Pl1 = New CalcUtils.UcCalcText
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.l6 = New System.Windows.Forms.Label
        Me.l5 = New System.Windows.Forms.Label
        Me.l4 = New System.Windows.Forms.Label
        Me.l3 = New System.Windows.Forms.Label
        Me.l2 = New System.Windows.Forms.Label
        Me.l1 = New System.Windows.Forms.Label
        Me.TxtFet = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.TxtOnSale = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.TxtRoadHazard = New CalcUtils.UcCalcText
        Me.TxtValueStem = New CalcUtils.UcCalcText
        Me.TxtDisposalFee = New CalcUtils.UcCalcText
        Me.TxtTireFee = New CalcUtils.UcCalcText
        Me.TxtBalance = New CalcUtils.UcCalcText
        Me.Tax1 = New CalcUtils.UcCalcText
        Me.Tax2 = New CalcUtils.UcCalcText
        Me.Subtotal1 = New CalcUtils.UcCalcText
        Me.Total2 = New CalcUtils.UcCalcText
        Me.Total1 = New CalcUtils.UcCalcText
        Me.SubTotal2 = New CalcUtils.UcCalcText
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Qty2 = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.TxtFet2 = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.TxtPrice2 = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Qty1 = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.TxtFet1 = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.TxtPrice1 = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.CmbPrice = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ChkRoadHazard = New Janus.Windows.EditControls.UICheckBox
        Me.ChkValueSteam = New Janus.Windows.EditControls.UICheckBox
        Me.ChkDisposalFee = New Janus.Windows.EditControls.UICheckBox
        Me.ChkTireFee = New Janus.Windows.EditControls.UICheckBox
        Me.ChkBalance = New Janus.Windows.EditControls.UICheckBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.p4 = New System.Windows.Forms.Panel
        Me.Label69 = New System.Windows.Forms.Label
        Me.MaskedEditBox31 = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.Label60 = New System.Windows.Forms.Label
        Me.TxtAmountCreated = New CalcUtils.UcCalcText
        Me.UcCalcText2 = New CalcUtils.UcCalcText
        Me.lastAdjustmentamount = New CalcUtils.UcCalcText
        Me.UcCalcText1 = New CalcUtils.UcCalcText
        Me.UcCalcText3 = New CalcUtils.UcCalcText
        Me.LastSaleAmount = New CalcUtils.UcCalcText
        Me.tXTDateCreated = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.MaskedEditBox1 = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.LastAdjustmentDate = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.MaskedEditBox2 = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.lastrecevieDate = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.LastSaleDate = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label68 = New System.Windows.Forms.Label
        Me.Label70 = New System.Windows.Forms.Label
        Me.Panel24 = New System.Windows.Forms.Panel
        Me.MaskedEditBox37 = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.MaskedEditBox36 = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.MaskedEditBox35 = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.MaskedEditBox34 = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.LastReceiveAmount = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.MaskedEditBox32 = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.MaskedEditBox30 = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.MaskedEditBox29 = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.MaskedEditBox28 = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.MaskedEditBox27 = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.LastReceiveDate = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.MaskedEditBox25 = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Panel25 = New System.Windows.Forms.Panel
        Me.CmbVendor = New System.Windows.Forms.ComboBox
        Me.DsInv_Item1 = New UCInv_Item.DSInv_Item
        Me.TxtVendorPartno = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.Label67 = New System.Windows.Forms.Label
        Me.Label66 = New System.Windows.Forms.Label
        Me.MaskedEditBox22 = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.TxtReplCost = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.TxtFriegt = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.TxtDelivery = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.TxtCost = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.Label64 = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label61 = New System.Windows.Forms.Label
        Me.Label65 = New System.Windows.Forms.Label
        Me.Panel23 = New System.Windows.Forms.Panel
        Me.MaskedEditBox17 = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.Label46 = New System.Windows.Forms.Label
        Me.ChkDiscontinued = New Janus.Windows.EditControls.UICheckBox
        Me.ChkConsighment = New Janus.Windows.EditControls.UICheckBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.amount_spiff = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.amount_contract = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.amount_onsale = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.end_date_spiff = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.end_date_contract = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.end_date_onsale = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.start_date_spiff = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.start_date_contract = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.start_date_onsale = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.ChkSpiff = New Janus.Windows.EditControls.UICheckBox
        Me.ChkContract = New Janus.Windows.EditControls.UICheckBox
        Me.ChkOnSale = New Janus.Windows.EditControls.UICheckBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.TxtReOrder = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.TxtMaxStock = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.TxtMinStock = New Janus.Windows.GridEX.EditControls.MaskedEditBox
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
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Label47 = New System.Windows.Forms.Label
        Me.Panel22 = New System.Windows.Forms.Panel
        Me.t3 = New System.Windows.Forms.Label
        Me.t2 = New System.Windows.Forms.Label
        Me.t1 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Image_Remark = New System.Windows.Forms.PictureBox
        Me.limit_warranty = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Panel20 = New System.Windows.Forms.Panel
        Me.Panel21 = New System.Windows.Forms.Panel
        Me.Panel18 = New System.Windows.Forms.Panel
        Me.Panel19 = New System.Windows.Forms.Panel
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.Panel17 = New System.Windows.Forms.Panel
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.TxtMl = New System.Windows.Forms.TextBox
        Me.TxtTd = New System.Windows.Forms.TextBox
        Me.TxtOd = New System.Windows.Forms.TextBox
        Me.txtRW = New System.Windows.Forms.TextBox
        Me.TxtSW = New System.Windows.Forms.TextBox
        Me.TxtSd = New System.Windows.Forms.TextBox
        Me.TxtTS = New System.Windows.Forms.TextBox
        Me.sdfsdf = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.IconBrand = New System.Windows.Forms.PictureBox
        Me.Note = New System.Windows.Forms.TextBox
        Me.LineDesc = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.GrdSalePerformance = New Janus.Windows.GridEX.GridEX
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Txt_avail = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Txt_Desc = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtItem_No = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DaInvItem = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DaInVDiscountItem = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DaBalance = New System.Data.SqlClient.SqlDataAdapter
        Me.DaTireFee = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaDisposalFee = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DaValueStem = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DaRoadHazard = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DaSalePerformance = New System.Data.SqlClient.SqlDataAdapter
        Me.CmdCancel = New Janus.Windows.EditControls.UIButton
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DaInvItemVendor = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DaInTab_Labor_Service = New System.Data.SqlClient.SqlDataAdapter
        Me.DaLastReceive = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.DALastAdjustment = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
        Me.DaLastServicecenter = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.CmdPrint = New Janus.Windows.EditControls.UIButton
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.p4.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.Panel25.SuspendLayout()
        CType(Me.DsInv_Item1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel23.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.GrdSalePerformance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(802, 328)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(794, 300)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pricing"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.plf6)
        Me.Panel4.Controls.Add(Me.plf5)
        Me.Panel4.Controls.Add(Me.plf4)
        Me.Panel4.Controls.Add(Me.plf3)
        Me.Panel4.Controls.Add(Me.plf2)
        Me.Panel4.Controls.Add(Me.Plf1)
        Me.Panel4.Controls.Add(Me.pl6)
        Me.Panel4.Controls.Add(Me.pl5)
        Me.Panel4.Controls.Add(Me.pl4)
        Me.Panel4.Controls.Add(Me.pl3)
        Me.Panel4.Controls.Add(Me.Pl2)
        Me.Panel4.Controls.Add(Me.Pl1)
        Me.Panel4.Controls.Add(Me.Label23)
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Controls.Add(Me.l6)
        Me.Panel4.Controls.Add(Me.l5)
        Me.Panel4.Controls.Add(Me.l4)
        Me.Panel4.Controls.Add(Me.l3)
        Me.Panel4.Controls.Add(Me.l2)
        Me.Panel4.Controls.Add(Me.l1)
        Me.Panel4.Controls.Add(Me.TxtFet)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.TxtOnSale)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Location = New System.Drawing.Point(488, 17)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(296, 255)
        Me.Panel4.TabIndex = 2
        '
        'plf6
        '
        Me.plf6.BackColor = System.Drawing.Color.Gold
        Me.plf6.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.plf6.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.plf6.DecimalDigits = 2
        Me.plf6.DefaultSendValue = False
        Me.plf6.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.plf6.FireTabAfterEnter = True
        Me.plf6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.plf6.Image = CType(resources.GetObject("plf6.Image"), System.Drawing.Image)
        Me.plf6.Location = New System.Drawing.Point(200, 201)
        Me.plf6.Maxlength = 12
        Me.plf6.MinusColor = System.Drawing.Color.Empty
        Me.plf6.Name = "plf6"
        Me.plf6.ReadOnly = True
        Me.plf6.Size = New System.Drawing.Size(88, 21)
        Me.plf6.TabIndex = 11
        Me.plf6.TabStop = False
        Me.plf6.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.plf6.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'plf5
        '
        Me.plf5.BackColor = System.Drawing.Color.Gold
        Me.plf5.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.plf5.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.plf5.DecimalDigits = 2
        Me.plf5.DefaultSendValue = False
        Me.plf5.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.plf5.FireTabAfterEnter = True
        Me.plf5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.plf5.Image = CType(resources.GetObject("plf5.Image"), System.Drawing.Image)
        Me.plf5.Location = New System.Drawing.Point(200, 173)
        Me.plf5.Maxlength = 12
        Me.plf5.MinusColor = System.Drawing.Color.Empty
        Me.plf5.Name = "plf5"
        Me.plf5.ReadOnly = True
        Me.plf5.Size = New System.Drawing.Size(88, 21)
        Me.plf5.TabIndex = 10
        Me.plf5.TabStop = False
        Me.plf5.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.plf5.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'plf4
        '
        Me.plf4.BackColor = System.Drawing.Color.Gold
        Me.plf4.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.plf4.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.plf4.DecimalDigits = 2
        Me.plf4.DefaultSendValue = False
        Me.plf4.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.plf4.FireTabAfterEnter = True
        Me.plf4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.plf4.Image = CType(resources.GetObject("plf4.Image"), System.Drawing.Image)
        Me.plf4.Location = New System.Drawing.Point(200, 145)
        Me.plf4.Maxlength = 12
        Me.plf4.MinusColor = System.Drawing.Color.Empty
        Me.plf4.Name = "plf4"
        Me.plf4.ReadOnly = True
        Me.plf4.Size = New System.Drawing.Size(88, 21)
        Me.plf4.TabIndex = 9
        Me.plf4.TabStop = False
        Me.plf4.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.plf4.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'plf3
        '
        Me.plf3.BackColor = System.Drawing.Color.Gold
        Me.plf3.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.plf3.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.plf3.DecimalDigits = 2
        Me.plf3.DefaultSendValue = False
        Me.plf3.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.plf3.FireTabAfterEnter = True
        Me.plf3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.plf3.Image = CType(resources.GetObject("plf3.Image"), System.Drawing.Image)
        Me.plf3.Location = New System.Drawing.Point(200, 117)
        Me.plf3.Maxlength = 12
        Me.plf3.MinusColor = System.Drawing.Color.Empty
        Me.plf3.Name = "plf3"
        Me.plf3.ReadOnly = True
        Me.plf3.Size = New System.Drawing.Size(88, 21)
        Me.plf3.TabIndex = 8
        Me.plf3.TabStop = False
        Me.plf3.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.plf3.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'plf2
        '
        Me.plf2.BackColor = System.Drawing.Color.Gold
        Me.plf2.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.plf2.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.plf2.DecimalDigits = 2
        Me.plf2.DefaultSendValue = False
        Me.plf2.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.plf2.FireTabAfterEnter = True
        Me.plf2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.plf2.Image = CType(resources.GetObject("plf2.Image"), System.Drawing.Image)
        Me.plf2.Location = New System.Drawing.Point(200, 89)
        Me.plf2.Maxlength = 12
        Me.plf2.MinusColor = System.Drawing.Color.Empty
        Me.plf2.Name = "plf2"
        Me.plf2.ReadOnly = True
        Me.plf2.Size = New System.Drawing.Size(88, 21)
        Me.plf2.TabIndex = 7
        Me.plf2.TabStop = False
        Me.plf2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.plf2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
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
        Me.Plf1.Location = New System.Drawing.Point(200, 61)
        Me.Plf1.Maxlength = 12
        Me.Plf1.MinusColor = System.Drawing.Color.Empty
        Me.Plf1.Name = "Plf1"
        Me.Plf1.ReadOnly = True
        Me.Plf1.Size = New System.Drawing.Size(88, 21)
        Me.Plf1.TabIndex = 6
        Me.Plf1.TabStop = False
        Me.Plf1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Plf1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'pl6
        '
        Me.pl6.BackColor = System.Drawing.Color.Gold
        Me.pl6.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.pl6.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.pl6.DecimalDigits = 2
        Me.pl6.DefaultSendValue = False
        Me.pl6.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.pl6.FireTabAfterEnter = True
        Me.pl6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pl6.Image = CType(resources.GetObject("pl6.Image"), System.Drawing.Image)
        Me.pl6.Location = New System.Drawing.Point(96, 201)
        Me.pl6.Maxlength = 12
        Me.pl6.MinusColor = System.Drawing.Color.Empty
        Me.pl6.Name = "pl6"
        Me.pl6.ReadOnly = True
        Me.pl6.Size = New System.Drawing.Size(88, 21)
        Me.pl6.TabIndex = 5
        Me.pl6.TabStop = False
        Me.pl6.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.pl6.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'pl5
        '
        Me.pl5.BackColor = System.Drawing.Color.Gold
        Me.pl5.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.pl5.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.pl5.DecimalDigits = 2
        Me.pl5.DefaultSendValue = False
        Me.pl5.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.pl5.FireTabAfterEnter = True
        Me.pl5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pl5.Image = CType(resources.GetObject("pl5.Image"), System.Drawing.Image)
        Me.pl5.Location = New System.Drawing.Point(96, 173)
        Me.pl5.Maxlength = 12
        Me.pl5.MinusColor = System.Drawing.Color.Empty
        Me.pl5.Name = "pl5"
        Me.pl5.ReadOnly = True
        Me.pl5.Size = New System.Drawing.Size(88, 21)
        Me.pl5.TabIndex = 4
        Me.pl5.TabStop = False
        Me.pl5.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.pl5.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'pl4
        '
        Me.pl4.BackColor = System.Drawing.Color.Gold
        Me.pl4.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.pl4.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.pl4.DecimalDigits = 2
        Me.pl4.DefaultSendValue = False
        Me.pl4.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.pl4.FireTabAfterEnter = True
        Me.pl4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pl4.Image = CType(resources.GetObject("pl4.Image"), System.Drawing.Image)
        Me.pl4.Location = New System.Drawing.Point(96, 145)
        Me.pl4.Maxlength = 12
        Me.pl4.MinusColor = System.Drawing.Color.Empty
        Me.pl4.Name = "pl4"
        Me.pl4.ReadOnly = True
        Me.pl4.Size = New System.Drawing.Size(88, 21)
        Me.pl4.TabIndex = 3
        Me.pl4.TabStop = False
        Me.pl4.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.pl4.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'pl3
        '
        Me.pl3.BackColor = System.Drawing.Color.Gold
        Me.pl3.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.pl3.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.pl3.DecimalDigits = 2
        Me.pl3.DefaultSendValue = False
        Me.pl3.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.pl3.FireTabAfterEnter = True
        Me.pl3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.pl3.Image = CType(resources.GetObject("pl3.Image"), System.Drawing.Image)
        Me.pl3.Location = New System.Drawing.Point(96, 117)
        Me.pl3.Maxlength = 12
        Me.pl3.MinusColor = System.Drawing.Color.Empty
        Me.pl3.Name = "pl3"
        Me.pl3.ReadOnly = True
        Me.pl3.Size = New System.Drawing.Size(88, 21)
        Me.pl3.TabIndex = 2
        Me.pl3.TabStop = False
        Me.pl3.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.pl3.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
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
        Me.Pl2.Location = New System.Drawing.Point(96, 89)
        Me.Pl2.Maxlength = 12
        Me.Pl2.MinusColor = System.Drawing.Color.Empty
        Me.Pl2.Name = "Pl2"
        Me.Pl2.ReadOnly = True
        Me.Pl2.Size = New System.Drawing.Size(88, 21)
        Me.Pl2.TabIndex = 1
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
        Me.Pl1.Location = New System.Drawing.Point(96, 61)
        Me.Pl1.Maxlength = 12
        Me.Pl1.MinusColor = System.Drawing.Color.Empty
        Me.Pl1.Name = "Pl1"
        Me.Pl1.ReadOnly = True
        Me.Pl1.Size = New System.Drawing.Size(88, 21)
        Me.Pl1.TabIndex = 0
        Me.Pl1.TabStop = False
        Me.Pl1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Pl1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(208, 35)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 23)
        Me.Label23.TabIndex = 33
        Me.Label23.Text = "Price+FET"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(120, 35)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 23)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = "Unit Price"
        '
        'l6
        '
        Me.l6.BackColor = System.Drawing.Color.LightSalmon
        Me.l6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.l6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.l6.ForeColor = System.Drawing.Color.LemonChiffon
        Me.l6.Location = New System.Drawing.Point(8, 201)
        Me.l6.Name = "l6"
        Me.l6.Size = New System.Drawing.Size(80, 21)
        Me.l6.TabIndex = 31
        Me.l6.Text = "Price Level 6"
        '
        'l5
        '
        Me.l5.BackColor = System.Drawing.Color.LightSalmon
        Me.l5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.l5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.l5.ForeColor = System.Drawing.Color.LemonChiffon
        Me.l5.Location = New System.Drawing.Point(8, 173)
        Me.l5.Name = "l5"
        Me.l5.Size = New System.Drawing.Size(80, 21)
        Me.l5.TabIndex = 30
        Me.l5.Text = "Price Level 5"
        '
        'l4
        '
        Me.l4.BackColor = System.Drawing.Color.LightSalmon
        Me.l4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.l4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.l4.ForeColor = System.Drawing.Color.LemonChiffon
        Me.l4.Location = New System.Drawing.Point(8, 145)
        Me.l4.Name = "l4"
        Me.l4.Size = New System.Drawing.Size(80, 21)
        Me.l4.TabIndex = 29
        Me.l4.Text = "Price Level 4"
        '
        'l3
        '
        Me.l3.BackColor = System.Drawing.Color.LightSalmon
        Me.l3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.l3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.l3.ForeColor = System.Drawing.Color.LemonChiffon
        Me.l3.Location = New System.Drawing.Point(8, 117)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(80, 21)
        Me.l3.TabIndex = 28
        Me.l3.Text = "Price Level 3"
        '
        'l2
        '
        Me.l2.BackColor = System.Drawing.Color.LightSalmon
        Me.l2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.l2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.l2.ForeColor = System.Drawing.Color.LemonChiffon
        Me.l2.Location = New System.Drawing.Point(8, 89)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(80, 21)
        Me.l2.TabIndex = 27
        Me.l2.Text = "Price Level 2"
        '
        'l1
        '
        Me.l1.BackColor = System.Drawing.Color.LightSalmon
        Me.l1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.l1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.l1.ForeColor = System.Drawing.Color.LemonChiffon
        Me.l1.Location = New System.Drawing.Point(8, 61)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(80, 21)
        Me.l1.TabIndex = 26
        Me.l1.Text = "Price Level 1"
        '
        'TxtFet
        '
        Me.TxtFet.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtFet.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtFet.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.TxtFet.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtFet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtFet.IncludeLiterals = False
        Me.TxtFet.Location = New System.Drawing.Point(200, 6)
        Me.TxtFet.MaxLength = 15
        Me.TxtFet.Name = "TxtFet"
        Me.TxtFet.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtFet.ReadOnly = True
        Me.TxtFet.Size = New System.Drawing.Size(88, 22)
        Me.TxtFet.TabIndex = 13
        Me.TxtFet.TabStop = False
        Me.TxtFet.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TxtFet.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(168, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 23)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Fet"
        '
        'TxtOnSale
        '
        Me.TxtOnSale.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtOnSale.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtOnSale.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.TxtOnSale.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtOnSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtOnSale.IncludeLiterals = False
        Me.TxtOnSale.Location = New System.Drawing.Point(64, 6)
        Me.TxtOnSale.MaxLength = 15
        Me.TxtOnSale.Name = "TxtOnSale"
        Me.TxtOnSale.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtOnSale.ReadOnly = True
        Me.TxtOnSale.Size = New System.Drawing.Size(96, 22)
        Me.TxtOnSale.TabIndex = 12
        Me.TxtOnSale.TabStop = False
        Me.TxtOnSale.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TxtOnSale.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(8, 6)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 23)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "On Sale"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TxtRoadHazard)
        Me.Panel3.Controls.Add(Me.TxtValueStem)
        Me.Panel3.Controls.Add(Me.TxtDisposalFee)
        Me.Panel3.Controls.Add(Me.TxtTireFee)
        Me.Panel3.Controls.Add(Me.TxtBalance)
        Me.Panel3.Controls.Add(Me.Tax1)
        Me.Panel3.Controls.Add(Me.Tax2)
        Me.Panel3.Controls.Add(Me.Subtotal1)
        Me.Panel3.Controls.Add(Me.Total2)
        Me.Panel3.Controls.Add(Me.Total1)
        Me.Panel3.Controls.Add(Me.SubTotal2)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Qty2)
        Me.Panel3.Controls.Add(Me.TxtFet2)
        Me.Panel3.Controls.Add(Me.TxtPrice2)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Qty1)
        Me.Panel3.Controls.Add(Me.TxtFet1)
        Me.Panel3.Controls.Add(Me.TxtPrice1)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.CmbPrice)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.ChkRoadHazard)
        Me.Panel3.Controls.Add(Me.ChkValueSteam)
        Me.Panel3.Controls.Add(Me.ChkDisposalFee)
        Me.Panel3.Controls.Add(Me.ChkTireFee)
        Me.Panel3.Controls.Add(Me.ChkBalance)
        Me.Panel3.Location = New System.Drawing.Point(8, 15)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(472, 257)
        Me.Panel3.TabIndex = 0
        '
        'TxtRoadHazard
        '
        Me.TxtRoadHazard.BackColor = System.Drawing.Color.White
        Me.TxtRoadHazard.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtRoadHazard.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.TxtRoadHazard.DecimalDigits = 2
        Me.TxtRoadHazard.DefaultSendValue = False
        Me.TxtRoadHazard.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtRoadHazard.FireTabAfterEnter = True
        Me.TxtRoadHazard.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtRoadHazard.Image = CType(resources.GetObject("TxtRoadHazard.Image"), System.Drawing.Image)
        Me.TxtRoadHazard.Location = New System.Drawing.Point(112, 202)
        Me.TxtRoadHazard.Maxlength = 12
        Me.TxtRoadHazard.MinusColor = System.Drawing.Color.Empty
        Me.TxtRoadHazard.Name = "TxtRoadHazard"
        Me.TxtRoadHazard.Size = New System.Drawing.Size(72, 21)
        Me.TxtRoadHazard.TabIndex = 471
        Me.TxtRoadHazard.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtRoadHazard.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtValueStem
        '
        Me.TxtValueStem.BackColor = System.Drawing.Color.White
        Me.TxtValueStem.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtValueStem.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.TxtValueStem.DecimalDigits = 2
        Me.TxtValueStem.DefaultSendValue = False
        Me.TxtValueStem.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtValueStem.FireTabAfterEnter = True
        Me.TxtValueStem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtValueStem.Image = CType(resources.GetObject("TxtValueStem.Image"), System.Drawing.Image)
        Me.TxtValueStem.Location = New System.Drawing.Point(112, 171)
        Me.TxtValueStem.Maxlength = 12
        Me.TxtValueStem.MinusColor = System.Drawing.Color.Empty
        Me.TxtValueStem.Name = "TxtValueStem"
        Me.TxtValueStem.Size = New System.Drawing.Size(72, 21)
        Me.TxtValueStem.TabIndex = 470
        Me.TxtValueStem.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtValueStem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtDisposalFee
        '
        Me.TxtDisposalFee.BackColor = System.Drawing.Color.White
        Me.TxtDisposalFee.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtDisposalFee.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.TxtDisposalFee.DecimalDigits = 2
        Me.TxtDisposalFee.DefaultSendValue = False
        Me.TxtDisposalFee.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtDisposalFee.FireTabAfterEnter = True
        Me.TxtDisposalFee.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtDisposalFee.Image = CType(resources.GetObject("TxtDisposalFee.Image"), System.Drawing.Image)
        Me.TxtDisposalFee.Location = New System.Drawing.Point(112, 140)
        Me.TxtDisposalFee.Maxlength = 12
        Me.TxtDisposalFee.MinusColor = System.Drawing.Color.Empty
        Me.TxtDisposalFee.Name = "TxtDisposalFee"
        Me.TxtDisposalFee.Size = New System.Drawing.Size(72, 21)
        Me.TxtDisposalFee.TabIndex = 469
        Me.TxtDisposalFee.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtDisposalFee.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtTireFee
        '
        Me.TxtTireFee.BackColor = System.Drawing.Color.White
        Me.TxtTireFee.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtTireFee.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.TxtTireFee.DecimalDigits = 2
        Me.TxtTireFee.DefaultSendValue = False
        Me.TxtTireFee.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtTireFee.FireTabAfterEnter = True
        Me.TxtTireFee.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtTireFee.Image = CType(resources.GetObject("TxtTireFee.Image"), System.Drawing.Image)
        Me.TxtTireFee.Location = New System.Drawing.Point(112, 107)
        Me.TxtTireFee.Maxlength = 12
        Me.TxtTireFee.MinusColor = System.Drawing.Color.Empty
        Me.TxtTireFee.Name = "TxtTireFee"
        Me.TxtTireFee.Size = New System.Drawing.Size(72, 21)
        Me.TxtTireFee.TabIndex = 468
        Me.TxtTireFee.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtTireFee.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtBalance
        '
        Me.TxtBalance.BackColor = System.Drawing.Color.White
        Me.TxtBalance.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtBalance.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.TxtBalance.DecimalDigits = 2
        Me.TxtBalance.DefaultSendValue = False
        Me.TxtBalance.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtBalance.FireTabAfterEnter = True
        Me.TxtBalance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtBalance.Image = CType(resources.GetObject("TxtBalance.Image"), System.Drawing.Image)
        Me.TxtBalance.Location = New System.Drawing.Point(112, 75)
        Me.TxtBalance.Maxlength = 12
        Me.TxtBalance.MinusColor = System.Drawing.Color.Empty
        Me.TxtBalance.Name = "TxtBalance"
        Me.TxtBalance.Size = New System.Drawing.Size(72, 21)
        Me.TxtBalance.TabIndex = 467
        Me.TxtBalance.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtBalance.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Tax1
        '
        Me.Tax1.BackColor = System.Drawing.Color.White
        Me.Tax1.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Tax1.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Tax1.DecimalDigits = 2
        Me.Tax1.DefaultSendValue = False
        Me.Tax1.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Tax1.FireTabAfterEnter = True
        Me.Tax1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Tax1.Image = CType(resources.GetObject("Tax1.Image"), System.Drawing.Image)
        Me.Tax1.Location = New System.Drawing.Point(304, 176)
        Me.Tax1.Maxlength = 12
        Me.Tax1.MinusColor = System.Drawing.Color.Empty
        Me.Tax1.Name = "Tax1"
        Me.Tax1.ReadOnly = True
        Me.Tax1.Size = New System.Drawing.Size(72, 21)
        Me.Tax1.TabIndex = 465
        Me.Tax1.TabStop = False
        Me.Tax1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Tax1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Tax2
        '
        Me.Tax2.BackColor = System.Drawing.Color.White
        Me.Tax2.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Tax2.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Tax2.DecimalDigits = 2
        Me.Tax2.DefaultSendValue = False
        Me.Tax2.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Tax2.FireTabAfterEnter = True
        Me.Tax2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Tax2.Image = CType(resources.GetObject("Tax2.Image"), System.Drawing.Image)
        Me.Tax2.Location = New System.Drawing.Point(384, 176)
        Me.Tax2.Maxlength = 12
        Me.Tax2.MinusColor = System.Drawing.Color.Empty
        Me.Tax2.Name = "Tax2"
        Me.Tax2.ReadOnly = True
        Me.Tax2.Size = New System.Drawing.Size(77, 21)
        Me.Tax2.TabIndex = 466
        Me.Tax2.TabStop = False
        Me.Tax2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Tax2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Subtotal1
        '
        Me.Subtotal1.BackColor = System.Drawing.Color.Gold
        Me.Subtotal1.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Subtotal1.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Subtotal1.DecimalDigits = 2
        Me.Subtotal1.DefaultSendValue = False
        Me.Subtotal1.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Subtotal1.FireTabAfterEnter = True
        Me.Subtotal1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Subtotal1.Image = CType(resources.GetObject("Subtotal1.Image"), System.Drawing.Image)
        Me.Subtotal1.Location = New System.Drawing.Point(304, 144)
        Me.Subtotal1.Maxlength = 12
        Me.Subtotal1.MinusColor = System.Drawing.Color.Empty
        Me.Subtotal1.Name = "Subtotal1"
        Me.Subtotal1.ReadOnly = True
        Me.Subtotal1.Size = New System.Drawing.Size(72, 21)
        Me.Subtotal1.TabIndex = 7
        Me.Subtotal1.TabStop = False
        Me.Subtotal1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Subtotal1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Total2
        '
        Me.Total2.BackColor = System.Drawing.Color.Gold
        Me.Total2.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Total2.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Total2.DecimalDigits = 2
        Me.Total2.DefaultSendValue = False
        Me.Total2.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Total2.FireTabAfterEnter = True
        Me.Total2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Total2.Image = CType(resources.GetObject("Total2.Image"), System.Drawing.Image)
        Me.Total2.Location = New System.Drawing.Point(384, 208)
        Me.Total2.Maxlength = 12
        Me.Total2.MinusColor = System.Drawing.Color.Empty
        Me.Total2.Name = "Total2"
        Me.Total2.ReadOnly = True
        Me.Total2.Size = New System.Drawing.Size(77, 21)
        Me.Total2.TabIndex = 13
        Me.Total2.TabStop = False
        Me.Total2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Total2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Total1
        '
        Me.Total1.BackColor = System.Drawing.Color.Gold
        Me.Total1.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Total1.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Total1.DecimalDigits = 2
        Me.Total1.DefaultSendValue = False
        Me.Total1.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Total1.FireTabAfterEnter = True
        Me.Total1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Total1.Image = CType(resources.GetObject("Total1.Image"), System.Drawing.Image)
        Me.Total1.Location = New System.Drawing.Point(304, 208)
        Me.Total1.Maxlength = 12
        Me.Total1.MinusColor = System.Drawing.Color.Empty
        Me.Total1.Name = "Total1"
        Me.Total1.ReadOnly = True
        Me.Total1.Size = New System.Drawing.Size(72, 21)
        Me.Total1.TabIndex = 464
        Me.Total1.TabStop = False
        Me.Total1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Total1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'SubTotal2
        '
        Me.SubTotal2.BackColor = System.Drawing.Color.Gold
        Me.SubTotal2.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.SubTotal2.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.SubTotal2.DecimalDigits = 2
        Me.SubTotal2.DefaultSendValue = False
        Me.SubTotal2.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.SubTotal2.FireTabAfterEnter = True
        Me.SubTotal2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.SubTotal2.Image = CType(resources.GetObject("SubTotal2.Image"), System.Drawing.Image)
        Me.SubTotal2.Location = New System.Drawing.Point(384, 144)
        Me.SubTotal2.Maxlength = 12
        Me.SubTotal2.MinusColor = System.Drawing.Color.Empty
        Me.SubTotal2.Name = "SubTotal2"
        Me.SubTotal2.ReadOnly = True
        Me.SubTotal2.Size = New System.Drawing.Size(77, 21)
        Me.SubTotal2.TabIndex = 11
        Me.SubTotal2.TabStop = False
        Me.SubTotal2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.SubTotal2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Location = New System.Drawing.Point(8, 68)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(184, 4)
        Me.Panel5.TabIndex = 33
        '
        'Qty2
        '
        Me.Qty2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Qty2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Qty2.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Qty2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Qty2.Location = New System.Drawing.Point(432, 40)
        Me.Qty2.Name = "Qty2"
        Me.Qty2.Numeric = True
        Me.Qty2.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.Qty2.Size = New System.Drawing.Size(32, 22)
        Me.Qty2.TabIndex = 32
        Me.Qty2.Text = "2"
        Me.Qty2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtFet2
        '
        Me.TxtFet2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtFet2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtFet2.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtFet2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtFet2.IncludeLiterals = False
        Me.TxtFet2.Location = New System.Drawing.Point(384, 112)
        Me.TxtFet2.MaxLength = 15
        Me.TxtFet2.Name = "TxtFet2"
        Me.TxtFet2.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtFet2.Size = New System.Drawing.Size(77, 22)
        Me.TxtFet2.TabIndex = 10
        Me.TxtFet2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TxtFet2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'TxtPrice2
        '
        Me.TxtPrice2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtPrice2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtPrice2.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtPrice2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtPrice2.IncludeLiterals = False
        Me.TxtPrice2.Location = New System.Drawing.Point(384, 80)
        Me.TxtPrice2.MaxLength = 15
        Me.TxtPrice2.Name = "TxtPrice2"
        Me.TxtPrice2.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtPrice2.Size = New System.Drawing.Size(77, 22)
        Me.TxtPrice2.TabIndex = 9
        Me.TxtPrice2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TxtPrice2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(400, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 23)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Qty"
        '
        'Qty1
        '
        Me.Qty1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Qty1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Qty1.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Qty1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Qty1.Location = New System.Drawing.Point(344, 40)
        Me.Qty1.Name = "Qty1"
        Me.Qty1.Numeric = True
        Me.Qty1.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.Qty1.Size = New System.Drawing.Size(32, 22)
        Me.Qty1.TabIndex = 25
        Me.Qty1.Text = "4"
        Me.Qty1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'TxtFet1
        '
        Me.TxtFet1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtFet1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtFet1.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtFet1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtFet1.IncludeLiterals = False
        Me.TxtFet1.Location = New System.Drawing.Point(304, 112)
        Me.TxtFet1.MaxLength = 15
        Me.TxtFet1.Name = "TxtFet1"
        Me.TxtFet1.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtFet1.Size = New System.Drawing.Size(72, 22)
        Me.TxtFet1.TabIndex = 6
        Me.TxtFet1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TxtFet1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'TxtPrice1
        '
        Me.TxtPrice1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtPrice1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtPrice1.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtPrice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtPrice1.IncludeLiterals = False
        Me.TxtPrice1.Location = New System.Drawing.Point(304, 80)
        Me.TxtPrice1.MaxLength = 15
        Me.TxtPrice1.Name = "TxtPrice1"
        Me.TxtPrice1.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtPrice1.Size = New System.Drawing.Size(72, 22)
        Me.TxtPrice1.TabIndex = 5
        Me.TxtPrice1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TxtPrice1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(240, 208)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 23)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Total"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(240, 176)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 23)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Tax"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(240, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 23)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "SubTotal"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(240, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 23)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "FET"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(240, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 23)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Price"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(312, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 23)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Qty"
        '
        'CmbPrice
        '
        Me.CmbPrice.DisplayMember = "0"
        Me.CmbPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrice.Items.AddRange(New Object() {"Price Level 1", "Price Level 2", "Price Level 3", "Price Level 4", "Price Level 5", "Price Level 6"})
        Me.CmbPrice.Location = New System.Drawing.Point(304, 8)
        Me.CmbPrice.Name = "CmbPrice"
        Me.CmbPrice.Size = New System.Drawing.Size(163, 24)
        Me.CmbPrice.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(216, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Price Level"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(128, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Fee"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(16, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Include"
        '
        'ChkRoadHazard
        '
        Me.ChkRoadHazard.Checked = True
        Me.ChkRoadHazard.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkRoadHazard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkRoadHazard.ForeColor = System.Drawing.Color.Navy
        Me.ChkRoadHazard.Location = New System.Drawing.Point(12, 199)
        Me.ChkRoadHazard.Name = "ChkRoadHazard"
        Me.ChkRoadHazard.Size = New System.Drawing.Size(96, 23)
        Me.ChkRoadHazard.TabIndex = 8
        Me.ChkRoadHazard.Text = "Road Hazard"
        '
        'ChkValueSteam
        '
        Me.ChkValueSteam.Checked = True
        Me.ChkValueSteam.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkValueSteam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkValueSteam.ForeColor = System.Drawing.Color.Navy
        Me.ChkValueSteam.Location = New System.Drawing.Point(12, 168)
        Me.ChkValueSteam.Name = "ChkValueSteam"
        Me.ChkValueSteam.Size = New System.Drawing.Size(96, 23)
        Me.ChkValueSteam.TabIndex = 6
        Me.ChkValueSteam.Text = "Valve Stem"
        '
        'ChkDisposalFee
        '
        Me.ChkDisposalFee.Checked = True
        Me.ChkDisposalFee.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkDisposalFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkDisposalFee.ForeColor = System.Drawing.Color.Navy
        Me.ChkDisposalFee.Location = New System.Drawing.Point(12, 137)
        Me.ChkDisposalFee.Name = "ChkDisposalFee"
        Me.ChkDisposalFee.Size = New System.Drawing.Size(96, 23)
        Me.ChkDisposalFee.TabIndex = 4
        Me.ChkDisposalFee.Text = "Disposal Fee"
        '
        'ChkTireFee
        '
        Me.ChkTireFee.Checked = True
        Me.ChkTireFee.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkTireFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkTireFee.ForeColor = System.Drawing.Color.Navy
        Me.ChkTireFee.Location = New System.Drawing.Point(12, 104)
        Me.ChkTireFee.Name = "ChkTireFee"
        Me.ChkTireFee.Size = New System.Drawing.Size(96, 23)
        Me.ChkTireFee.TabIndex = 2
        Me.ChkTireFee.Text = "Tire Fee"
        '
        'ChkBalance
        '
        Me.ChkBalance.Checked = True
        Me.ChkBalance.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkBalance.ForeColor = System.Drawing.Color.Navy
        Me.ChkBalance.Location = New System.Drawing.Point(12, 72)
        Me.ChkBalance.Name = "ChkBalance"
        Me.ChkBalance.Size = New System.Drawing.Size(96, 23)
        Me.ChkBalance.TabIndex = 0
        Me.ChkBalance.Text = "Balance"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.p4)
        Me.TabPage2.Controls.Add(Me.Panel24)
        Me.TabPage2.Controls.Add(Me.Panel25)
        Me.TabPage2.Controls.Add(Me.Panel23)
        Me.TabPage2.Controls.Add(Me.Panel7)
        Me.TabPage2.Controls.Add(Me.Panel6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(794, 300)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Status"
        '
        'p4
        '
        Me.p4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p4.Controls.Add(Me.Label69)
        Me.p4.Controls.Add(Me.MaskedEditBox31)
        Me.p4.Controls.Add(Me.Label60)
        Me.p4.Controls.Add(Me.TxtAmountCreated)
        Me.p4.Controls.Add(Me.UcCalcText2)
        Me.p4.Controls.Add(Me.lastAdjustmentamount)
        Me.p4.Controls.Add(Me.UcCalcText1)
        Me.p4.Controls.Add(Me.UcCalcText3)
        Me.p4.Controls.Add(Me.LastSaleAmount)
        Me.p4.Controls.Add(Me.tXTDateCreated)
        Me.p4.Controls.Add(Me.MaskedEditBox1)
        Me.p4.Controls.Add(Me.LastAdjustmentDate)
        Me.p4.Controls.Add(Me.MaskedEditBox2)
        Me.p4.Controls.Add(Me.lastrecevieDate)
        Me.p4.Controls.Add(Me.LastSaleDate)
        Me.p4.Controls.Add(Me.Label16)
        Me.p4.Controls.Add(Me.Label17)
        Me.p4.Controls.Add(Me.Label18)
        Me.p4.Controls.Add(Me.Label19)
        Me.p4.Controls.Add(Me.Label20)
        Me.p4.Controls.Add(Me.Label21)
        Me.p4.Controls.Add(Me.Label68)
        Me.p4.Controls.Add(Me.Label70)
        Me.p4.Location = New System.Drawing.Point(560, 8)
        Me.p4.Name = "p4"
        Me.p4.Size = New System.Drawing.Size(224, 272)
        Me.p4.TabIndex = 60
        '
        'Label69
        '
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label69.Location = New System.Drawing.Point(62, 0)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(62, 18)
        Me.Label69.TabIndex = 11
        Me.Label69.Text = "Date"
        Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaskedEditBox31
        '
        Me.MaskedEditBox31.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox31.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox31.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox31.IncludeLiterals = False
        Me.MaskedEditBox31.Location = New System.Drawing.Point(83, 240)
        Me.MaskedEditBox31.MaxLength = 15
        Me.MaskedEditBox31.Name = "MaskedEditBox31"
        Me.MaskedEditBox31.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.MaskedEditBox31.ReadOnly = True
        Me.MaskedEditBox31.Size = New System.Drawing.Size(136, 22)
        Me.MaskedEditBox31.TabIndex = 464
        Me.MaskedEditBox31.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.MaskedEditBox31.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Label60
        '
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label60.Location = New System.Drawing.Point(3, 240)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(70, 18)
        Me.Label60.TabIndex = 463
        Me.Label60.Text = "Bin Location"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.TxtAmountCreated.Location = New System.Drawing.Point(136, 183)
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
        'UcCalcText2
        '
        Me.UcCalcText2.BackColor = System.Drawing.Color.Gold
        Me.UcCalcText2.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.UcCalcText2.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.UcCalcText2.DecimalDigits = 2
        Me.UcCalcText2.DefaultSendValue = False
        Me.UcCalcText2.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.UcCalcText2.FireTabAfterEnter = True
        Me.UcCalcText2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcCalcText2.Image = CType(resources.GetObject("UcCalcText2.Image"), System.Drawing.Image)
        Me.UcCalcText2.Location = New System.Drawing.Point(136, 152)
        Me.UcCalcText2.Maxlength = 12
        Me.UcCalcText2.MinusColor = System.Drawing.Color.Empty
        Me.UcCalcText2.Name = "UcCalcText2"
        Me.UcCalcText2.ReadOnly = True
        Me.UcCalcText2.Size = New System.Drawing.Size(72, 21)
        Me.UcCalcText2.TabIndex = 461
        Me.UcCalcText2.TabStop = False
        Me.UcCalcText2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.UcCalcText2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
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
        Me.lastAdjustmentamount.Location = New System.Drawing.Point(136, 121)
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
        Me.UcCalcText1.Location = New System.Drawing.Point(136, 88)
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
        'UcCalcText3
        '
        Me.UcCalcText3.BackColor = System.Drawing.Color.Gold
        Me.UcCalcText3.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.UcCalcText3.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.UcCalcText3.DecimalDigits = 2
        Me.UcCalcText3.DefaultSendValue = False
        Me.UcCalcText3.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.UcCalcText3.FireTabAfterEnter = True
        Me.UcCalcText3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UcCalcText3.Image = CType(resources.GetObject("UcCalcText3.Image"), System.Drawing.Image)
        Me.UcCalcText3.Location = New System.Drawing.Point(136, 55)
        Me.UcCalcText3.Maxlength = 12
        Me.UcCalcText3.MinusColor = System.Drawing.Color.Empty
        Me.UcCalcText3.Name = "UcCalcText3"
        Me.UcCalcText3.ReadOnly = True
        Me.UcCalcText3.Size = New System.Drawing.Size(72, 21)
        Me.UcCalcText3.TabIndex = 458
        Me.UcCalcText3.TabStop = False
        Me.UcCalcText3.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.UcCalcText3.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
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
        Me.LastSaleAmount.Location = New System.Drawing.Point(136, 25)
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
        Me.tXTDateCreated.Location = New System.Drawing.Point(56, 182)
        Me.tXTDateCreated.MaxLength = 15
        Me.tXTDateCreated.Name = "tXTDateCreated"
        Me.tXTDateCreated.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.tXTDateCreated.ReadOnly = True
        Me.tXTDateCreated.Size = New System.Drawing.Size(72, 22)
        Me.tXTDateCreated.TabIndex = 29
        Me.tXTDateCreated.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'MaskedEditBox1
        '
        Me.MaskedEditBox1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox1.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.MaskedEditBox1.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox1.IncludeLiterals = False
        Me.MaskedEditBox1.Location = New System.Drawing.Point(56, 151)
        Me.MaskedEditBox1.MaxLength = 15
        Me.MaskedEditBox1.Name = "MaskedEditBox1"
        Me.MaskedEditBox1.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.MaskedEditBox1.ReadOnly = True
        Me.MaskedEditBox1.Size = New System.Drawing.Size(72, 22)
        Me.MaskedEditBox1.TabIndex = 28
        Me.MaskedEditBox1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'LastAdjustmentDate
        '
        Me.LastAdjustmentDate.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.LastAdjustmentDate.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.LastAdjustmentDate.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LastAdjustmentDate.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LastAdjustmentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LastAdjustmentDate.IncludeLiterals = False
        Me.LastAdjustmentDate.Location = New System.Drawing.Point(56, 120)
        Me.LastAdjustmentDate.MaxLength = 15
        Me.LastAdjustmentDate.Name = "LastAdjustmentDate"
        Me.LastAdjustmentDate.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.LastAdjustmentDate.ReadOnly = True
        Me.LastAdjustmentDate.Size = New System.Drawing.Size(72, 22)
        Me.LastAdjustmentDate.TabIndex = 27
        Me.LastAdjustmentDate.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'MaskedEditBox2
        '
        Me.MaskedEditBox2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox2.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.MaskedEditBox2.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox2.IncludeLiterals = False
        Me.MaskedEditBox2.Location = New System.Drawing.Point(56, 87)
        Me.MaskedEditBox2.MaxLength = 15
        Me.MaskedEditBox2.Name = "MaskedEditBox2"
        Me.MaskedEditBox2.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.MaskedEditBox2.ReadOnly = True
        Me.MaskedEditBox2.Size = New System.Drawing.Size(72, 22)
        Me.MaskedEditBox2.TabIndex = 26
        Me.MaskedEditBox2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'lastrecevieDate
        '
        Me.lastrecevieDate.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.lastrecevieDate.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.lastrecevieDate.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.lastrecevieDate.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lastrecevieDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lastrecevieDate.IncludeLiterals = False
        Me.lastrecevieDate.Location = New System.Drawing.Point(56, 54)
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
        Me.LastSaleDate.Location = New System.Drawing.Point(56, 24)
        Me.LastSaleDate.MaxLength = 15
        Me.LastSaleDate.Name = "LastSaleDate"
        Me.LastSaleDate.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.LastSaleDate.ReadOnly = True
        Me.LastSaleDate.Size = New System.Drawing.Size(72, 22)
        Me.LastSaleDate.TabIndex = 24
        Me.LastSaleDate.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label16.Location = New System.Drawing.Point(-5, 188)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 18)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Created"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label17.Location = New System.Drawing.Point(-4, 157)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 18)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Price chg"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label18.Location = New System.Drawing.Point(-3, 121)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 19)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Adjustment"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label19.Location = New System.Drawing.Point(-5, 90)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 18)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "Count"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label20.Location = New System.Drawing.Point(-5, 55)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 18)
        Me.Label20.TabIndex = 14
        Me.Label20.Text = "Receive"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label21.Location = New System.Drawing.Point(-4, 25)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 18)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "Sale"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label68
        '
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label68.Location = New System.Drawing.Point(137, 0)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(72, 18)
        Me.Label68.TabIndex = 12
        Me.Label68.Text = "Amount"
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label70
        '
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label70.Location = New System.Drawing.Point(11, 0)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(40, 18)
        Me.Label70.TabIndex = 10
        Me.Label70.Text = "Last"
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel24
        '
        Me.Panel24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel24.Controls.Add(Me.MaskedEditBox37)
        Me.Panel24.Controls.Add(Me.MaskedEditBox36)
        Me.Panel24.Controls.Add(Me.MaskedEditBox35)
        Me.Panel24.Controls.Add(Me.MaskedEditBox34)
        Me.Panel24.Controls.Add(Me.LastReceiveAmount)
        Me.Panel24.Controls.Add(Me.MaskedEditBox32)
        Me.Panel24.Controls.Add(Me.MaskedEditBox30)
        Me.Panel24.Controls.Add(Me.MaskedEditBox29)
        Me.Panel24.Controls.Add(Me.MaskedEditBox28)
        Me.Panel24.Controls.Add(Me.MaskedEditBox27)
        Me.Panel24.Controls.Add(Me.LastReceiveDate)
        Me.Panel24.Controls.Add(Me.MaskedEditBox25)
        Me.Panel24.Controls.Add(Me.Label59)
        Me.Panel24.Controls.Add(Me.Label58)
        Me.Panel24.Controls.Add(Me.Label57)
        Me.Panel24.Controls.Add(Me.Label56)
        Me.Panel24.Controls.Add(Me.Label55)
        Me.Panel24.Controls.Add(Me.Label54)
        Me.Panel24.Controls.Add(Me.Label53)
        Me.Panel24.Controls.Add(Me.Label52)
        Me.Panel24.Controls.Add(Me.Label51)
        Me.Panel24.Enabled = False
        Me.Panel24.Location = New System.Drawing.Point(544, 30)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(232, 272)
        Me.Panel24.TabIndex = 3
        Me.Panel24.Visible = False
        '
        'MaskedEditBox37
        '
        Me.MaskedEditBox37.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox37.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox37.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.MaskedEditBox37.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox37.IncludeLiterals = False
        Me.MaskedEditBox37.Location = New System.Drawing.Point(141, 192)
        Me.MaskedEditBox37.MaxLength = 15
        Me.MaskedEditBox37.Name = "MaskedEditBox37"
        Me.MaskedEditBox37.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.MaskedEditBox37.ReadOnly = True
        Me.MaskedEditBox37.Size = New System.Drawing.Size(84, 22)
        Me.MaskedEditBox37.TabIndex = 36
        Me.MaskedEditBox37.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.MaskedEditBox37.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'MaskedEditBox36
        '
        Me.MaskedEditBox36.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox36.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox36.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.MaskedEditBox36.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox36.IncludeLiterals = False
        Me.MaskedEditBox36.Location = New System.Drawing.Point(141, 161)
        Me.MaskedEditBox36.MaxLength = 15
        Me.MaskedEditBox36.Name = "MaskedEditBox36"
        Me.MaskedEditBox36.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.MaskedEditBox36.ReadOnly = True
        Me.MaskedEditBox36.Size = New System.Drawing.Size(84, 22)
        Me.MaskedEditBox36.TabIndex = 35
        Me.MaskedEditBox36.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.MaskedEditBox36.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'MaskedEditBox35
        '
        Me.MaskedEditBox35.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox35.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox35.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.MaskedEditBox35.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox35.IncludeLiterals = False
        Me.MaskedEditBox35.Location = New System.Drawing.Point(141, 130)
        Me.MaskedEditBox35.MaxLength = 15
        Me.MaskedEditBox35.Name = "MaskedEditBox35"
        Me.MaskedEditBox35.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.MaskedEditBox35.ReadOnly = True
        Me.MaskedEditBox35.Size = New System.Drawing.Size(84, 22)
        Me.MaskedEditBox35.TabIndex = 34
        Me.MaskedEditBox35.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.MaskedEditBox35.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'MaskedEditBox34
        '
        Me.MaskedEditBox34.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox34.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox34.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.MaskedEditBox34.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox34.IncludeLiterals = False
        Me.MaskedEditBox34.Location = New System.Drawing.Point(141, 99)
        Me.MaskedEditBox34.MaxLength = 15
        Me.MaskedEditBox34.Name = "MaskedEditBox34"
        Me.MaskedEditBox34.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.MaskedEditBox34.ReadOnly = True
        Me.MaskedEditBox34.Size = New System.Drawing.Size(84, 22)
        Me.MaskedEditBox34.TabIndex = 33
        Me.MaskedEditBox34.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.MaskedEditBox34.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'LastReceiveAmount
        '
        Me.LastReceiveAmount.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.LastReceiveAmount.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.LastReceiveAmount.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.LastReceiveAmount.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LastReceiveAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LastReceiveAmount.IncludeLiterals = False
        Me.LastReceiveAmount.Location = New System.Drawing.Point(141, 67)
        Me.LastReceiveAmount.MaxLength = 15
        Me.LastReceiveAmount.Name = "LastReceiveAmount"
        Me.LastReceiveAmount.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.LastReceiveAmount.ReadOnly = True
        Me.LastReceiveAmount.Size = New System.Drawing.Size(84, 22)
        Me.LastReceiveAmount.TabIndex = 32
        Me.LastReceiveAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.LastReceiveAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'MaskedEditBox32
        '
        Me.MaskedEditBox32.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox32.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox32.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.MaskedEditBox32.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox32.IncludeLiterals = False
        Me.MaskedEditBox32.Location = New System.Drawing.Point(141, 36)
        Me.MaskedEditBox32.MaxLength = 15
        Me.MaskedEditBox32.Name = "MaskedEditBox32"
        Me.MaskedEditBox32.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.MaskedEditBox32.ReadOnly = True
        Me.MaskedEditBox32.Size = New System.Drawing.Size(84, 22)
        Me.MaskedEditBox32.TabIndex = 31
        Me.MaskedEditBox32.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.MaskedEditBox32.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'MaskedEditBox30
        '
        Me.MaskedEditBox30.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox30.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox30.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.MaskedEditBox30.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox30.IncludeLiterals = False
        Me.MaskedEditBox30.Location = New System.Drawing.Point(64, 192)
        Me.MaskedEditBox30.MaxLength = 15
        Me.MaskedEditBox30.Name = "MaskedEditBox30"
        Me.MaskedEditBox30.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.MaskedEditBox30.ReadOnly = True
        Me.MaskedEditBox30.Size = New System.Drawing.Size(72, 22)
        Me.MaskedEditBox30.TabIndex = 29
        Me.MaskedEditBox30.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.MaskedEditBox30.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'MaskedEditBox29
        '
        Me.MaskedEditBox29.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox29.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox29.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.MaskedEditBox29.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox29.IncludeLiterals = False
        Me.MaskedEditBox29.Location = New System.Drawing.Point(64, 161)
        Me.MaskedEditBox29.MaxLength = 15
        Me.MaskedEditBox29.Name = "MaskedEditBox29"
        Me.MaskedEditBox29.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.MaskedEditBox29.ReadOnly = True
        Me.MaskedEditBox29.Size = New System.Drawing.Size(72, 22)
        Me.MaskedEditBox29.TabIndex = 28
        Me.MaskedEditBox29.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.MaskedEditBox29.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'MaskedEditBox28
        '
        Me.MaskedEditBox28.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox28.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox28.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.MaskedEditBox28.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox28.IncludeLiterals = False
        Me.MaskedEditBox28.Location = New System.Drawing.Point(64, 130)
        Me.MaskedEditBox28.MaxLength = 15
        Me.MaskedEditBox28.Name = "MaskedEditBox28"
        Me.MaskedEditBox28.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.MaskedEditBox28.ReadOnly = True
        Me.MaskedEditBox28.Size = New System.Drawing.Size(72, 22)
        Me.MaskedEditBox28.TabIndex = 27
        Me.MaskedEditBox28.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.MaskedEditBox28.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'MaskedEditBox27
        '
        Me.MaskedEditBox27.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox27.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox27.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.MaskedEditBox27.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox27.IncludeLiterals = False
        Me.MaskedEditBox27.Location = New System.Drawing.Point(64, 99)
        Me.MaskedEditBox27.MaxLength = 15
        Me.MaskedEditBox27.Name = "MaskedEditBox27"
        Me.MaskedEditBox27.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.MaskedEditBox27.ReadOnly = True
        Me.MaskedEditBox27.Size = New System.Drawing.Size(72, 22)
        Me.MaskedEditBox27.TabIndex = 26
        Me.MaskedEditBox27.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.MaskedEditBox27.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'LastReceiveDate
        '
        Me.LastReceiveDate.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.LastReceiveDate.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.LastReceiveDate.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.LastReceiveDate.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LastReceiveDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LastReceiveDate.IncludeLiterals = False
        Me.LastReceiveDate.Location = New System.Drawing.Point(64, 67)
        Me.LastReceiveDate.MaxLength = 15
        Me.LastReceiveDate.Name = "LastReceiveDate"
        Me.LastReceiveDate.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.LastReceiveDate.ReadOnly = True
        Me.LastReceiveDate.Size = New System.Drawing.Size(72, 22)
        Me.LastReceiveDate.TabIndex = 25
        Me.LastReceiveDate.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.LastReceiveDate.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'MaskedEditBox25
        '
        Me.MaskedEditBox25.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox25.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox25.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.MaskedEditBox25.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox25.IncludeLiterals = False
        Me.MaskedEditBox25.Location = New System.Drawing.Point(64, 36)
        Me.MaskedEditBox25.MaxLength = 15
        Me.MaskedEditBox25.Name = "MaskedEditBox25"
        Me.MaskedEditBox25.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.MaskedEditBox25.ReadOnly = True
        Me.MaskedEditBox25.Size = New System.Drawing.Size(72, 22)
        Me.MaskedEditBox25.TabIndex = 24
        Me.MaskedEditBox25.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.MaskedEditBox25.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Label59
        '
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label59.Location = New System.Drawing.Point(0, 196)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(64, 18)
        Me.Label59.TabIndex = 18
        Me.Label59.Text = "Created"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label58
        '
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label58.Location = New System.Drawing.Point(0, 164)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(64, 18)
        Me.Label58.TabIndex = 17
        Me.Label58.Text = "Price chg"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label57
        '
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label57.Location = New System.Drawing.Point(-4, 133)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(64, 18)
        Me.Label57.TabIndex = 16
        Me.Label57.Text = "Adjusment"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label56
        '
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label56.Location = New System.Drawing.Point(-4, 99)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(64, 18)
        Me.Label56.TabIndex = 15
        Me.Label56.Text = "Count"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label55
        '
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label55.Location = New System.Drawing.Point(-4, 66)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(64, 18)
        Me.Label55.TabIndex = 14
        Me.Label55.Text = "Receive"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label54
        '
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label54.Location = New System.Drawing.Point(-4, 35)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(63, 18)
        Me.Label54.TabIndex = 13
        Me.Label54.Text = "Sale"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label53
        '
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label53.Location = New System.Drawing.Point(144, 8)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(72, 18)
        Me.Label53.TabIndex = 12
        Me.Label53.Text = "Amount"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label52.Location = New System.Drawing.Point(64, 8)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(72, 18)
        Me.Label52.TabIndex = 11
        Me.Label52.Text = "Date"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label51
        '
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label51.Location = New System.Drawing.Point(16, 8)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(40, 18)
        Me.Label51.TabIndex = 10
        Me.Label51.Text = "Last"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel25
        '
        Me.Panel25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel25.Controls.Add(Me.CmbVendor)
        Me.Panel25.Controls.Add(Me.TxtVendorPartno)
        Me.Panel25.Controls.Add(Me.Label67)
        Me.Panel25.Controls.Add(Me.Label66)
        Me.Panel25.Controls.Add(Me.MaskedEditBox22)
        Me.Panel25.Controls.Add(Me.TxtReplCost)
        Me.Panel25.Controls.Add(Me.TxtFriegt)
        Me.Panel25.Controls.Add(Me.TxtDelivery)
        Me.Panel25.Controls.Add(Me.TxtCost)
        Me.Panel25.Controls.Add(Me.Label64)
        Me.Panel25.Controls.Add(Me.Label63)
        Me.Panel25.Controls.Add(Me.Label62)
        Me.Panel25.Controls.Add(Me.Label61)
        Me.Panel25.Controls.Add(Me.Label65)
        Me.Panel25.Location = New System.Drawing.Point(152, 144)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(400, 136)
        Me.Panel25.TabIndex = 4
        '
        'CmbVendor
        '
        Me.CmbVendor.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.CmbVendor.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DsInv_Item1, "inv_item_vendor.ven_part_no"))
        Me.CmbVendor.DataSource = Me.DsInv_Item1.inv_item_vendor
        Me.CmbVendor.DisplayMember = "desc_vendor"
        Me.CmbVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbVendor.Location = New System.Drawing.Point(8, 104)
        Me.CmbVendor.Name = "CmbVendor"
        Me.CmbVendor.Size = New System.Drawing.Size(208, 23)
        Me.CmbVendor.TabIndex = 29
        Me.CmbVendor.ValueMember = "cod_vendor"
        '
        'DsInv_Item1
        '
        Me.DsInv_Item1.DataSetName = "DSInv_Item"
        Me.DsInv_Item1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'TxtVendorPartno
        '
        Me.TxtVendorPartno.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtVendorPartno.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtVendorPartno.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.TxtVendorPartno.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtVendorPartno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsInv_Item1, "inv_item_vendor.ven_part_no"))
        Me.TxtVendorPartno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtVendorPartno.IncludeLiterals = False
        Me.TxtVendorPartno.Location = New System.Drawing.Point(247, 104)
        Me.TxtVendorPartno.MaxLength = 50
        Me.TxtVendorPartno.Name = "TxtVendorPartno"
        Me.TxtVendorPartno.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtVendorPartno.ReadOnly = True
        Me.TxtVendorPartno.Size = New System.Drawing.Size(145, 22)
        Me.TxtVendorPartno.TabIndex = 28
        Me.TxtVendorPartno.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TxtVendorPartno.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Label67
        '
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label67.Location = New System.Drawing.Point(248, 80)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(88, 18)
        Me.Label67.TabIndex = 26
        Me.Label67.Text = "Vendor Part No"
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label66
        '
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label66.Location = New System.Drawing.Point(8, 80)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(55, 18)
        Me.Label66.TabIndex = 25
        Me.Label66.Text = "Vendor"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaskedEditBox22
        '
        Me.MaskedEditBox22.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox22.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox22.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.MaskedEditBox22.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox22.IncludeLiterals = False
        Me.MaskedEditBox22.Location = New System.Drawing.Point(321, 40)
        Me.MaskedEditBox22.MaxLength = 15
        Me.MaskedEditBox22.Name = "MaskedEditBox22"
        Me.MaskedEditBox22.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.MaskedEditBox22.ReadOnly = True
        Me.MaskedEditBox22.Size = New System.Drawing.Size(72, 22)
        Me.MaskedEditBox22.TabIndex = 24
        Me.MaskedEditBox22.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.MaskedEditBox22.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'TxtReplCost
        '
        Me.TxtReplCost.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtReplCost.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtReplCost.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.TxtReplCost.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtReplCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtReplCost.IncludeLiterals = False
        Me.TxtReplCost.Location = New System.Drawing.Point(245, 40)
        Me.TxtReplCost.MaxLength = 15
        Me.TxtReplCost.Name = "TxtReplCost"
        Me.TxtReplCost.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtReplCost.ReadOnly = True
        Me.TxtReplCost.Size = New System.Drawing.Size(72, 22)
        Me.TxtReplCost.TabIndex = 23
        Me.TxtReplCost.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TxtReplCost.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'TxtFriegt
        '
        Me.TxtFriegt.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtFriegt.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtFriegt.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.TxtFriegt.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtFriegt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtFriegt.IncludeLiterals = False
        Me.TxtFriegt.Location = New System.Drawing.Point(161, 40)
        Me.TxtFriegt.MaxLength = 15
        Me.TxtFriegt.Name = "TxtFriegt"
        Me.TxtFriegt.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtFriegt.ReadOnly = True
        Me.TxtFriegt.Size = New System.Drawing.Size(80, 22)
        Me.TxtFriegt.TabIndex = 22
        Me.TxtFriegt.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TxtFriegt.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'TxtDelivery
        '
        Me.TxtDelivery.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtDelivery.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtDelivery.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.TxtDelivery.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtDelivery.IncludeLiterals = False
        Me.TxtDelivery.Location = New System.Drawing.Point(77, 40)
        Me.TxtDelivery.MaxLength = 15
        Me.TxtDelivery.Name = "TxtDelivery"
        Me.TxtDelivery.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtDelivery.ReadOnly = True
        Me.TxtDelivery.Size = New System.Drawing.Size(80, 22)
        Me.TxtDelivery.TabIndex = 21
        Me.TxtDelivery.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TxtDelivery.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'TxtCost
        '
        Me.TxtCost.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtCost.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtCost.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.TxtCost.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtCost.IncludeLiterals = False
        Me.TxtCost.Location = New System.Drawing.Point(1, 40)
        Me.TxtCost.MaxLength = 15
        Me.TxtCost.Name = "TxtCost"
        Me.TxtCost.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtCost.ReadOnly = True
        Me.TxtCost.Size = New System.Drawing.Size(72, 22)
        Me.TxtCost.TabIndex = 19
        Me.TxtCost.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TxtCost.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Label64
        '
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label64.Location = New System.Drawing.Point(246, 16)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(64, 18)
        Me.Label64.TabIndex = 18
        Me.Label64.Text = "Repl . Cost"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label63
        '
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label63.Location = New System.Drawing.Point(164, 16)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(68, 18)
        Me.Label63.TabIndex = 17
        Me.Label63.Text = "Frieght"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label62
        '
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label62.Location = New System.Drawing.Point(80, 16)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(56, 18)
        Me.Label62.TabIndex = 16
        Me.Label62.Text = "Delivery"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label61
        '
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label61.Location = New System.Drawing.Point(9, 16)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(55, 18)
        Me.Label61.TabIndex = 15
        Me.Label61.Text = "Cost"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label65
        '
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label65.Location = New System.Drawing.Point(323, 16)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(64, 18)
        Me.Label65.TabIndex = 16
        Me.Label65.Text = "Avg.Cost"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel23
        '
        Me.Panel23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel23.Controls.Add(Me.MaskedEditBox17)
        Me.Panel23.Controls.Add(Me.Label46)
        Me.Panel23.Controls.Add(Me.ChkDiscontinued)
        Me.Panel23.Controls.Add(Me.ChkConsighment)
        Me.Panel23.Controls.Add(Me.Label43)
        Me.Panel23.Enabled = False
        Me.Panel23.Location = New System.Drawing.Point(452, 8)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(104, 120)
        Me.Panel23.TabIndex = 2
        '
        'MaskedEditBox17
        '
        Me.MaskedEditBox17.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox17.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.MaskedEditBox17.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaskedEditBox17.IncludeLiterals = False
        Me.MaskedEditBox17.Location = New System.Drawing.Point(40, 88)
        Me.MaskedEditBox17.MaxLength = 15
        Me.MaskedEditBox17.Name = "MaskedEditBox17"
        Me.MaskedEditBox17.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.MaskedEditBox17.ReadOnly = True
        Me.MaskedEditBox17.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MaskedEditBox17.Size = New System.Drawing.Size(56, 22)
        Me.MaskedEditBox17.TabIndex = 21
        Me.MaskedEditBox17.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.MaskedEditBox17.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label46.Location = New System.Drawing.Point(4, 88)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(44, 16)
        Me.Label46.TabIndex = 15
        Me.Label46.Text = "When"
        '
        'ChkDiscontinued
        '
        Me.ChkDiscontinued.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkDiscontinued.Location = New System.Drawing.Point(8, 56)
        Me.ChkDiscontinued.Name = "ChkDiscontinued"
        Me.ChkDiscontinued.Size = New System.Drawing.Size(88, 23)
        Me.ChkDiscontinued.TabIndex = 14
        Me.ChkDiscontinued.Text = "Discontinued"
        '
        'ChkConsighment
        '
        Me.ChkConsighment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkConsighment.Location = New System.Drawing.Point(8, 32)
        Me.ChkConsighment.Name = "ChkConsighment"
        Me.ChkConsighment.Size = New System.Drawing.Size(88, 23)
        Me.ChkConsighment.TabIndex = 13
        Me.ChkConsighment.Text = "ConSignment"
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label43.Location = New System.Drawing.Point(24, 8)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(64, 18)
        Me.Label43.TabIndex = 10
        Me.Label43.Text = "Item is"
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.amount_spiff)
        Me.Panel7.Controls.Add(Me.amount_contract)
        Me.Panel7.Controls.Add(Me.amount_onsale)
        Me.Panel7.Controls.Add(Me.end_date_spiff)
        Me.Panel7.Controls.Add(Me.end_date_contract)
        Me.Panel7.Controls.Add(Me.end_date_onsale)
        Me.Panel7.Controls.Add(Me.start_date_spiff)
        Me.Panel7.Controls.Add(Me.start_date_contract)
        Me.Panel7.Controls.Add(Me.start_date_onsale)
        Me.Panel7.Controls.Add(Me.ChkSpiff)
        Me.Panel7.Controls.Add(Me.ChkContract)
        Me.Panel7.Controls.Add(Me.ChkOnSale)
        Me.Panel7.Controls.Add(Me.Label35)
        Me.Panel7.Controls.Add(Me.Label34)
        Me.Panel7.Controls.Add(Me.Label33)
        Me.Panel7.Controls.Add(Me.Label32)
        Me.Panel7.Enabled = False
        Me.Panel7.Location = New System.Drawing.Point(148, 8)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(300, 120)
        Me.Panel7.TabIndex = 1
        '
        'amount_spiff
        '
        Me.amount_spiff.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.amount_spiff.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.amount_spiff.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.amount_spiff.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.amount_spiff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.amount_spiff.IncludeLiterals = False
        Me.amount_spiff.Location = New System.Drawing.Point(227, 92)
        Me.amount_spiff.MaxLength = 15
        Me.amount_spiff.Name = "amount_spiff"
        Me.amount_spiff.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.amount_spiff.ReadOnly = True
        Me.amount_spiff.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.amount_spiff.Size = New System.Drawing.Size(69, 20)
        Me.amount_spiff.TabIndex = 28
        Me.amount_spiff.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.amount_spiff.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'amount_contract
        '
        Me.amount_contract.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.amount_contract.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.amount_contract.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.amount_contract.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.amount_contract.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.amount_contract.IncludeLiterals = False
        Me.amount_contract.Location = New System.Drawing.Point(226, 63)
        Me.amount_contract.MaxLength = 15
        Me.amount_contract.Name = "amount_contract"
        Me.amount_contract.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.amount_contract.ReadOnly = True
        Me.amount_contract.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.amount_contract.Size = New System.Drawing.Size(70, 20)
        Me.amount_contract.TabIndex = 27
        Me.amount_contract.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.amount_contract.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'amount_onsale
        '
        Me.amount_onsale.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.amount_onsale.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.amount_onsale.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.amount_onsale.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.amount_onsale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.amount_onsale.IncludeLiterals = False
        Me.amount_onsale.Location = New System.Drawing.Point(226, 32)
        Me.amount_onsale.MaxLength = 15
        Me.amount_onsale.Name = "amount_onsale"
        Me.amount_onsale.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.amount_onsale.ReadOnly = True
        Me.amount_onsale.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.amount_onsale.Size = New System.Drawing.Size(70, 20)
        Me.amount_onsale.TabIndex = 26
        Me.amount_onsale.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.amount_onsale.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'end_date_spiff
        '
        Me.end_date_spiff.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.end_date_spiff.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.end_date_spiff.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.end_date_spiff.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.end_date_spiff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.end_date_spiff.IncludeLiterals = False
        Me.end_date_spiff.Location = New System.Drawing.Point(146, 92)
        Me.end_date_spiff.MaxLength = 15
        Me.end_date_spiff.Name = "end_date_spiff"
        Me.end_date_spiff.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.end_date_spiff.ReadOnly = True
        Me.end_date_spiff.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.end_date_spiff.Size = New System.Drawing.Size(70, 20)
        Me.end_date_spiff.TabIndex = 25
        Me.end_date_spiff.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.end_date_spiff.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'end_date_contract
        '
        Me.end_date_contract.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.end_date_contract.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.end_date_contract.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.end_date_contract.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.end_date_contract.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.end_date_contract.IncludeLiterals = False
        Me.end_date_contract.Location = New System.Drawing.Point(146, 63)
        Me.end_date_contract.MaxLength = 15
        Me.end_date_contract.Name = "end_date_contract"
        Me.end_date_contract.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.end_date_contract.ReadOnly = True
        Me.end_date_contract.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.end_date_contract.Size = New System.Drawing.Size(70, 20)
        Me.end_date_contract.TabIndex = 24
        Me.end_date_contract.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.end_date_contract.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'end_date_onsale
        '
        Me.end_date_onsale.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.end_date_onsale.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.end_date_onsale.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.end_date_onsale.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.end_date_onsale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.end_date_onsale.IncludeLiterals = False
        Me.end_date_onsale.Location = New System.Drawing.Point(146, 32)
        Me.end_date_onsale.MaxLength = 15
        Me.end_date_onsale.Name = "end_date_onsale"
        Me.end_date_onsale.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.end_date_onsale.ReadOnly = True
        Me.end_date_onsale.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.end_date_onsale.Size = New System.Drawing.Size(70, 20)
        Me.end_date_onsale.TabIndex = 23
        Me.end_date_onsale.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.end_date_onsale.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'start_date_spiff
        '
        Me.start_date_spiff.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.start_date_spiff.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.start_date_spiff.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.start_date_spiff.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.start_date_spiff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.start_date_spiff.IncludeLiterals = False
        Me.start_date_spiff.Location = New System.Drawing.Point(66, 92)
        Me.start_date_spiff.MaxLength = 15
        Me.start_date_spiff.Name = "start_date_spiff"
        Me.start_date_spiff.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.start_date_spiff.ReadOnly = True
        Me.start_date_spiff.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.start_date_spiff.Size = New System.Drawing.Size(70, 20)
        Me.start_date_spiff.TabIndex = 22
        Me.start_date_spiff.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.start_date_spiff.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'start_date_contract
        '
        Me.start_date_contract.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.start_date_contract.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.start_date_contract.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.start_date_contract.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.start_date_contract.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.start_date_contract.IncludeLiterals = False
        Me.start_date_contract.Location = New System.Drawing.Point(66, 63)
        Me.start_date_contract.MaxLength = 15
        Me.start_date_contract.Name = "start_date_contract"
        Me.start_date_contract.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.start_date_contract.ReadOnly = True
        Me.start_date_contract.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.start_date_contract.Size = New System.Drawing.Size(70, 20)
        Me.start_date_contract.TabIndex = 21
        Me.start_date_contract.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.start_date_contract.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'start_date_onsale
        '
        Me.start_date_onsale.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.start_date_onsale.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.start_date_onsale.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.start_date_onsale.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.start_date_onsale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.start_date_onsale.IncludeLiterals = False
        Me.start_date_onsale.Location = New System.Drawing.Point(66, 32)
        Me.start_date_onsale.MaxLength = 15
        Me.start_date_onsale.Name = "start_date_onsale"
        Me.start_date_onsale.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.start_date_onsale.ReadOnly = True
        Me.start_date_onsale.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.start_date_onsale.Size = New System.Drawing.Size(70, 20)
        Me.start_date_onsale.TabIndex = 20
        Me.start_date_onsale.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.start_date_onsale.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'ChkSpiff
        '
        Me.ChkSpiff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkSpiff.Location = New System.Drawing.Point(3, 93)
        Me.ChkSpiff.Name = "ChkSpiff"
        Me.ChkSpiff.Size = New System.Drawing.Size(64, 23)
        Me.ChkSpiff.TabIndex = 14
        Me.ChkSpiff.Text = "Spiff"
        '
        'ChkContract
        '
        Me.ChkContract.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkContract.Location = New System.Drawing.Point(3, 64)
        Me.ChkContract.Name = "ChkContract"
        Me.ChkContract.Size = New System.Drawing.Size(64, 23)
        Me.ChkContract.TabIndex = 13
        Me.ChkContract.Text = "Contract"
        '
        'ChkOnSale
        '
        Me.ChkOnSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkOnSale.Location = New System.Drawing.Point(3, 32)
        Me.ChkOnSale.Name = "ChkOnSale"
        Me.ChkOnSale.Size = New System.Drawing.Size(64, 23)
        Me.ChkOnSale.TabIndex = 12
        Me.ChkOnSale.Text = "On Sale"
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label35.Location = New System.Drawing.Point(227, 8)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(64, 18)
        Me.Label35.TabIndex = 11
        Me.Label35.Text = "Amount"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label34.Location = New System.Drawing.Point(150, 8)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(58, 18)
        Me.Label34.TabIndex = 10
        Me.Label34.Text = "Ends"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label33.Location = New System.Drawing.Point(70, 8)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(58, 18)
        Me.Label33.TabIndex = 9
        Me.Label33.Text = "Starts"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label32.Location = New System.Drawing.Point(6, 8)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(64, 18)
        Me.Label32.TabIndex = 8
        Me.Label32.Text = "Status"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.TxtReOrder)
        Me.Panel6.Controls.Add(Me.TxtMaxStock)
        Me.Panel6.Controls.Add(Me.TxtMinStock)
        Me.Panel6.Controls.Add(Me.TxtOnOrder)
        Me.Panel6.Controls.Add(Me.TxtAvailable)
        Me.Panel6.Controls.Add(Me.TxtComitted)
        Me.Panel6.Controls.Add(Me.TxtOnHand)
        Me.Panel6.Controls.Add(Me.Label31)
        Me.Panel6.Controls.Add(Me.Label30)
        Me.Panel6.Controls.Add(Me.Label29)
        Me.Panel6.Controls.Add(Me.Label28)
        Me.Panel6.Controls.Add(Me.Label27)
        Me.Panel6.Controls.Add(Me.Label26)
        Me.Panel6.Controls.Add(Me.Label25)
        Me.Panel6.Controls.Add(Me.Label24)
        Me.Panel6.Enabled = False
        Me.Panel6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel6.Location = New System.Drawing.Point(5, 8)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(139, 280)
        Me.Panel6.TabIndex = 0
        '
        'TxtReOrder
        '
        Me.TxtReOrder.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtReOrder.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtReOrder.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.TxtReOrder.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtReOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtReOrder.IncludeLiterals = False
        Me.TxtReOrder.Location = New System.Drawing.Point(69, 235)
        Me.TxtReOrder.MaxLength = 15
        Me.TxtReOrder.Name = "TxtReOrder"
        Me.TxtReOrder.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtReOrder.ReadOnly = True
        Me.TxtReOrder.Size = New System.Drawing.Size(59, 22)
        Me.TxtReOrder.TabIndex = 21
        Me.TxtReOrder.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TxtReOrder.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'TxtMaxStock
        '
        Me.TxtMaxStock.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtMaxStock.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtMaxStock.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.TxtMaxStock.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtMaxStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtMaxStock.IncludeLiterals = False
        Me.TxtMaxStock.Location = New System.Drawing.Point(69, 203)
        Me.TxtMaxStock.MaxLength = 15
        Me.TxtMaxStock.Name = "TxtMaxStock"
        Me.TxtMaxStock.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtMaxStock.ReadOnly = True
        Me.TxtMaxStock.Size = New System.Drawing.Size(59, 22)
        Me.TxtMaxStock.TabIndex = 20
        Me.TxtMaxStock.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TxtMaxStock.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'TxtMinStock
        '
        Me.TxtMinStock.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtMinStock.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtMinStock.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.TxtMinStock.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtMinStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtMinStock.IncludeLiterals = False
        Me.TxtMinStock.Location = New System.Drawing.Point(69, 171)
        Me.TxtMinStock.MaxLength = 15
        Me.TxtMinStock.Name = "TxtMinStock"
        Me.TxtMinStock.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtMinStock.ReadOnly = True
        Me.TxtMinStock.Size = New System.Drawing.Size(59, 22)
        Me.TxtMinStock.TabIndex = 19
        Me.TxtMinStock.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TxtMinStock.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'TxtOnOrder
        '
        Me.TxtOnOrder.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtOnOrder.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtOnOrder.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.TxtOnOrder.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtOnOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtOnOrder.IncludeLiterals = False
        Me.TxtOnOrder.Location = New System.Drawing.Point(69, 139)
        Me.TxtOnOrder.MaxLength = 15
        Me.TxtOnOrder.Name = "TxtOnOrder"
        Me.TxtOnOrder.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtOnOrder.ReadOnly = True
        Me.TxtOnOrder.Size = New System.Drawing.Size(59, 22)
        Me.TxtOnOrder.TabIndex = 18
        Me.TxtOnOrder.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TxtOnOrder.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'TxtAvailable
        '
        Me.TxtAvailable.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtAvailable.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtAvailable.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.TxtAvailable.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtAvailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtAvailable.IncludeLiterals = False
        Me.TxtAvailable.Location = New System.Drawing.Point(69, 107)
        Me.TxtAvailable.MaxLength = 15
        Me.TxtAvailable.Name = "TxtAvailable"
        Me.TxtAvailable.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtAvailable.ReadOnly = True
        Me.TxtAvailable.Size = New System.Drawing.Size(59, 22)
        Me.TxtAvailable.TabIndex = 17
        Me.TxtAvailable.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TxtAvailable.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'TxtComitted
        '
        Me.TxtComitted.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtComitted.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtComitted.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.TxtComitted.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtComitted.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtComitted.IncludeLiterals = False
        Me.TxtComitted.Location = New System.Drawing.Point(69, 74)
        Me.TxtComitted.MaxLength = 15
        Me.TxtComitted.Name = "TxtComitted"
        Me.TxtComitted.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtComitted.ReadOnly = True
        Me.TxtComitted.Size = New System.Drawing.Size(59, 22)
        Me.TxtComitted.TabIndex = 16
        Me.TxtComitted.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TxtComitted.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'TxtOnHand
        '
        Me.TxtOnHand.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtOnHand.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtOnHand.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.TxtOnHand.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtOnHand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtOnHand.IncludeLiterals = False
        Me.TxtOnHand.Location = New System.Drawing.Point(69, 38)
        Me.TxtOnHand.MaxLength = 15
        Me.TxtOnHand.Name = "TxtOnHand"
        Me.TxtOnHand.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.TxtOnHand.ReadOnly = True
        Me.TxtOnHand.Size = New System.Drawing.Size(59, 22)
        Me.TxtOnHand.TabIndex = 15
        Me.TxtOnHand.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TxtOnHand.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label31.Location = New System.Drawing.Point(75, 6)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(64, 18)
        Me.Label31.TabIndex = 7
        Me.Label31.Text = "   QTY   "
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(2, 232)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(64, 23)
        Me.Label30.TabIndex = 6
        Me.Label30.Text = "ReOrder"
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(2, 200)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(64, 23)
        Me.Label29.TabIndex = 5
        Me.Label29.Text = "Max Stock"
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(2, 170)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(64, 23)
        Me.Label28.TabIndex = 4
        Me.Label28.Text = "Min Stock"
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(2, 138)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 23)
        Me.Label27.TabIndex = 3
        Me.Label27.Text = "On Order"
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(2, 103)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 23)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Available"
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(2, 70)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 23)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Comitted"
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(2, 38)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(56, 23)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "On Hand"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label47)
        Me.TabPage3.Controls.Add(Me.Panel22)
        Me.TabPage3.Controls.Add(Me.Image_Remark)
        Me.TabPage3.Controls.Add(Me.limit_warranty)
        Me.TabPage3.Controls.Add(Me.Label45)
        Me.TabPage3.Controls.Add(Me.Label44)
        Me.TabPage3.Controls.Add(Me.Panel8)
        Me.TabPage3.Controls.Add(Me.IconBrand)
        Me.TabPage3.Controls.Add(Me.Note)
        Me.TabPage3.Controls.Add(Me.LineDesc)
        Me.TabPage3.Controls.Add(Me.Label36)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(794, 300)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Specification"
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.SystemColors.Control
        Me.Label47.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label47.Location = New System.Drawing.Point(530, 189)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(101, 19)
        Me.Label47.TabIndex = 11
        Me.Label47.Text = "UTQG  Ratings"
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Panel22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel22.Controls.Add(Me.t3)
        Me.Panel22.Controls.Add(Me.t2)
        Me.Panel22.Controls.Add(Me.t1)
        Me.Panel22.Controls.Add(Me.Label50)
        Me.Panel22.Controls.Add(Me.Label49)
        Me.Panel22.Controls.Add(Me.Label48)
        Me.Panel22.Location = New System.Drawing.Point(528, 208)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(263, 80)
        Me.Panel22.TabIndex = 10
        '
        't3
        '
        Me.t3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.t3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.t3.Location = New System.Drawing.Point(95, 52)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(41, 24)
        Me.t3.TabIndex = 8
        Me.t3.Text = "b"
        Me.t3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        't2
        '
        Me.t2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.t2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.t2.Location = New System.Drawing.Point(95, 27)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(41, 24)
        Me.t2.TabIndex = 7
        Me.t2.Text = "b"
        Me.t2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        't1
        '
        Me.t1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.t1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.t1.Location = New System.Drawing.Point(95, 4)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(41, 24)
        Me.t1.TabIndex = 6
        Me.t1.Text = "a"
        Me.t1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label50.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label50.Location = New System.Drawing.Point(4, 54)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(80, 24)
        Me.Label50.TabIndex = 5
        Me.Label50.Text = "Temperature"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label49.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label49.Location = New System.Drawing.Point(4, 28)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(80, 24)
        Me.Label49.TabIndex = 4
        Me.Label49.Text = "Traction"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label48.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label48.Location = New System.Drawing.Point(4, 4)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(80, 24)
        Me.Label48.TabIndex = 3
        Me.Label48.Text = "TreadWear"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Image_Remark
        '
        Me.Image_Remark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Image_Remark.Location = New System.Drawing.Point(593, 24)
        Me.Image_Remark.Name = "Image_Remark"
        Me.Image_Remark.Size = New System.Drawing.Size(192, 136)
        Me.Image_Remark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image_Remark.TabIndex = 9
        Me.Image_Remark.TabStop = False
        '
        'limit_warranty
        '
        Me.limit_warranty.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.limit_warranty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.limit_warranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.limit_warranty.Location = New System.Drawing.Point(458, 164)
        Me.limit_warranty.Name = "limit_warranty"
        Me.limit_warranty.Size = New System.Drawing.Size(96, 23)
        Me.limit_warranty.TabIndex = 8
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label45.Location = New System.Drawing.Point(304, 16)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(41, 23)
        Me.Label45.TabIndex = 7
        Me.Label45.Text = "Brand"
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label44.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label44.Location = New System.Drawing.Point(354, 164)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(104, 23)
        Me.Label44.TabIndex = 6
        Me.Label44.Text = "Limited Warranty"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Panel20)
        Me.Panel8.Controls.Add(Me.Panel18)
        Me.Panel8.Controls.Add(Me.Panel16)
        Me.Panel8.Controls.Add(Me.Panel14)
        Me.Panel8.Controls.Add(Me.Panel12)
        Me.Panel8.Controls.Add(Me.Panel10)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Controls.Add(Me.sdfsdf)
        Me.Panel8.Controls.Add(Me.Label42)
        Me.Panel8.Controls.Add(Me.Label41)
        Me.Panel8.Controls.Add(Me.Label40)
        Me.Panel8.Controls.Add(Me.Label39)
        Me.Panel8.Controls.Add(Me.Label38)
        Me.Panel8.Controls.Add(Me.Label37)
        Me.Panel8.Location = New System.Drawing.Point(8, 192)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(496, 96)
        Me.Panel8.TabIndex = 5
        '
        'Panel20
        '
        Me.Panel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel20.Controls.Add(Me.Panel21)
        Me.Panel20.Location = New System.Drawing.Point(420, -1)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(1, 96)
        Me.Panel20.TabIndex = 13
        '
        'Panel21
        '
        Me.Panel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel21.Location = New System.Drawing.Point(0, -1)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(1, 96)
        Me.Panel21.TabIndex = 9
        '
        'Panel18
        '
        Me.Panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel18.Controls.Add(Me.Panel19)
        Me.Panel18.Location = New System.Drawing.Point(352, -1)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(1, 96)
        Me.Panel18.TabIndex = 12
        '
        'Panel19
        '
        Me.Panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel19.Location = New System.Drawing.Point(0, -1)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(1, 96)
        Me.Panel19.TabIndex = 9
        '
        'Panel16
        '
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel16.Controls.Add(Me.Panel17)
        Me.Panel16.Location = New System.Drawing.Point(280, -1)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(1, 96)
        Me.Panel16.TabIndex = 11
        '
        'Panel17
        '
        Me.Panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel17.Location = New System.Drawing.Point(0, -1)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(1, 96)
        Me.Panel17.TabIndex = 9
        '
        'Panel14
        '
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Location = New System.Drawing.Point(216, -1)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1, 96)
        Me.Panel14.TabIndex = 10
        '
        'Panel15
        '
        Me.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel15.Location = New System.Drawing.Point(0, -1)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(1, 96)
        Me.Panel15.TabIndex = 9
        '
        'Panel12
        '
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.Panel12.Location = New System.Drawing.Point(144, -1)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1, 96)
        Me.Panel12.TabIndex = 9
        '
        'Panel13
        '
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Location = New System.Drawing.Point(0, -1)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1, 96)
        Me.Panel13.TabIndex = 9
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Location = New System.Drawing.Point(64, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1, 96)
        Me.Panel10.TabIndex = 8
        '
        'Panel11
        '
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Location = New System.Drawing.Point(0, -1)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1, 96)
        Me.Panel11.TabIndex = 9
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel9.Controls.Add(Me.TxtMl)
        Me.Panel9.Controls.Add(Me.TxtTd)
        Me.Panel9.Controls.Add(Me.TxtOd)
        Me.Panel9.Controls.Add(Me.txtRW)
        Me.Panel9.Controls.Add(Me.TxtSW)
        Me.Panel9.Controls.Add(Me.TxtSd)
        Me.Panel9.Controls.Add(Me.TxtTS)
        Me.Panel9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel9.Location = New System.Drawing.Point(0, 56)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(496, 56)
        Me.Panel9.TabIndex = 7
        '
        'TxtMl
        '
        Me.TxtMl.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtMl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtMl.Location = New System.Drawing.Point(427, 8)
        Me.TxtMl.Name = "TxtMl"
        Me.TxtMl.ReadOnly = True
        Me.TxtMl.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TxtMl.Size = New System.Drawing.Size(64, 14)
        Me.TxtMl.TabIndex = 6
        Me.TxtMl.TabStop = False
        Me.TxtMl.Text = "TextBox7"
        Me.TxtMl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTd
        '
        Me.TxtTd.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtTd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtTd.Location = New System.Drawing.Point(355, 8)
        Me.TxtTd.Name = "TxtTd"
        Me.TxtTd.ReadOnly = True
        Me.TxtTd.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TxtTd.Size = New System.Drawing.Size(64, 14)
        Me.TxtTd.TabIndex = 5
        Me.TxtTd.TabStop = False
        Me.TxtTd.Text = "TextBox6"
        Me.TxtTd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtOd
        '
        Me.TxtOd.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtOd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtOd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtOd.Location = New System.Drawing.Point(287, 8)
        Me.TxtOd.Name = "TxtOd"
        Me.TxtOd.ReadOnly = True
        Me.TxtOd.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TxtOd.Size = New System.Drawing.Size(64, 14)
        Me.TxtOd.TabIndex = 4
        Me.TxtOd.TabStop = False
        Me.TxtOd.Text = "TextBox5"
        Me.TxtOd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRW
        '
        Me.txtRW.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtRW.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtRW.Location = New System.Drawing.Point(216, 8)
        Me.txtRW.Name = "txtRW"
        Me.txtRW.ReadOnly = True
        Me.txtRW.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtRW.Size = New System.Drawing.Size(64, 14)
        Me.txtRW.TabIndex = 3
        Me.txtRW.TabStop = False
        Me.txtRW.Text = "TextBox4"
        Me.txtRW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtSW
        '
        Me.TxtSW.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtSW.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtSW.Location = New System.Drawing.Point(148, 8)
        Me.TxtSW.Name = "TxtSW"
        Me.TxtSW.ReadOnly = True
        Me.TxtSW.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TxtSW.Size = New System.Drawing.Size(56, 14)
        Me.TxtSW.TabIndex = 2
        Me.TxtSW.TabStop = False
        Me.TxtSW.Text = "TextBox3"
        Me.TxtSW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtSd
        '
        Me.TxtSd.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtSd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtSd.Location = New System.Drawing.Point(72, 8)
        Me.TxtSd.Name = "TxtSd"
        Me.TxtSd.ReadOnly = True
        Me.TxtSd.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TxtSd.Size = New System.Drawing.Size(64, 14)
        Me.TxtSd.TabIndex = 1
        Me.TxtSd.TabStop = False
        Me.TxtSd.Text = "TextBox2"
        Me.TxtSd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTS
        '
        Me.TxtTS.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtTS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtTS.Location = New System.Drawing.Point(0, 8)
        Me.TxtTS.Name = "TxtTS"
        Me.TxtTS.ReadOnly = True
        Me.TxtTS.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TxtTS.Size = New System.Drawing.Size(64, 14)
        Me.TxtTS.TabIndex = 0
        Me.TxtTS.TabStop = False
        Me.TxtTS.Text = "TextBox1"
        Me.TxtTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'sdfsdf
        '
        Me.sdfsdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.sdfsdf.ForeColor = System.Drawing.SystemColors.Desktop
        Me.sdfsdf.Location = New System.Drawing.Point(416, 9)
        Me.sdfsdf.Name = "sdfsdf"
        Me.sdfsdf.Size = New System.Drawing.Size(64, 32)
        Me.sdfsdf.TabIndex = 6
        Me.sdfsdf.Text = "Max Load (lbs@psi)"
        Me.sdfsdf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label42.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label42.Location = New System.Drawing.Point(360, 9)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(48, 48)
        Me.Label42.TabIndex = 5
        Me.Label42.Text = "Tread Depth in/32nds"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label41.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label41.Location = New System.Drawing.Point(293, 9)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(56, 32)
        Me.Label41.TabIndex = 4
        Me.Label41.Text = " Overall Diameter"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label40.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label40.Location = New System.Drawing.Point(224, 9)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(56, 48)
        Me.Label40.TabIndex = 3
        Me.Label40.Text = "Rim Width Range (Inch)"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label39.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label39.Location = New System.Drawing.Point(153, 9)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(55, 32)
        Me.Label39.TabIndex = 2
        Me.Label39.Text = "SideWall"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label38.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label38.Location = New System.Drawing.Point(77, 9)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(67, 32)
        Me.Label38.TabIndex = 1
        Me.Label38.Text = "Service Description"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label37.Location = New System.Drawing.Point(0, 9)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(56, 32)
        Me.Label37.TabIndex = 0
        Me.Label37.Text = "Tire Size"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IconBrand
        '
        Me.IconBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IconBrand.Location = New System.Drawing.Point(354, 24)
        Me.IconBrand.Name = "IconBrand"
        Me.IconBrand.Size = New System.Drawing.Size(200, 136)
        Me.IconBrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconBrand.TabIndex = 4
        Me.IconBrand.TabStop = False
        '
        'Note
        '
        Me.Note.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Note.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Note.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Note.Location = New System.Drawing.Point(8, 48)
        Me.Note.Multiline = True
        Me.Note.Name = "Note"
        Me.Note.ReadOnly = True
        Me.Note.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Note.Size = New System.Drawing.Size(336, 144)
        Me.Note.TabIndex = 3
        Me.Note.TabStop = False
        Me.Note.Text = ""
        '
        'LineDesc
        '
        Me.LineDesc.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.LineDesc.Location = New System.Drawing.Point(48, 14)
        Me.LineDesc.Name = "LineDesc"
        Me.LineDesc.ReadOnly = True
        Me.LineDesc.Size = New System.Drawing.Size(232, 21)
        Me.LineDesc.TabIndex = 2
        Me.LineDesc.Text = ""
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(8, 14)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(59, 23)
        Me.Label36.TabIndex = 1
        Me.Label36.Text = "Line"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GrdSalePerformance)
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(794, 300)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Sale Performance"
        '
        'GrdSalePerformance
        '
        Me.GrdSalePerformance.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdSalePerformance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GrdSalePerformance.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.GrdSalePerformance.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell
        Me.GrdSalePerformance.DataMember = "Spicification"
        Me.GrdSalePerformance.DataSource = Me.DsInv_Item1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>Spicification</Caption><Columns Collection=" & _
        """true""><Column0 ID=""col1""><Caption>YYYY</Caption><DataMember>col1</DataMember><K" & _
        "ey>col1</Key><MaxLines>2</MaxLines><Position>0</Position><Width>71</Width><CellS" & _
        "tyle><BackColor>GrayText</BackColor><ForeColor>Black</ForeColor></CellStyle><Hea" & _
        "derStyle><Appearance>Flat</Appearance><BackColor>Yellow</BackColor><ForeColor>Bl" & _
        "ack</ForeColor></HeaderStyle></Column0><Column1 ID=""col2""><Caption>Unit Sold</Ca" & _
        "ption><DataMember>col2</DataMember><EditType>NoEdit</EditType><Key>col2</Key><Po" & _
        "sition>1</Position><Width>67</Width></Column1><Column2 ID=""col3""><Caption>$ Sold" & _
        "</Caption><DataMember>col3</DataMember><EditType>NoEdit</EditType><Key>col3</Key" & _
        "><Position>2</Position><Width>71</Width></Column2><Column3 ID=""col4""><Caption>La" & _
        "st Year Unit Sold</Caption><DataMember>col4</DataMember><Key>col4</Key><Position" & _
        ">3</Position><Width>78</Width></Column3><Column4 ID=""col5""><Caption>Last Year $S" & _
        "old</Caption><DataMember>col5</DataMember><Key>col5</Key><Position>4</Position><" & _
        "Width>82</Width></Column4><Column5 ID=""col6""><Caption>YYYY</Caption><DataMember>" & _
        "col6</DataMember><Key>col6</Key><Position>5</Position><Width>79</Width><CellStyl" & _
        "e><BackColor>GrayText</BackColor><ForeColor>Black</ForeColor></CellStyle></Colum" & _
        "n5><Column6 ID=""col7""><Caption>Unit Sold</Caption><DataMember>col7</DataMember><" & _
        "Key>col7</Key><Position>6</Position><Width>63</Width></Column6><Column7 ID=""col8" & _
        """><Caption>$ Sold</Caption><DataMember>col8</DataMember><Key>col8</Key><Position" & _
        ">7</Position><Width>80</Width></Column7><Column8 ID=""col9""><Caption>Last Year Un" & _
        "it Sold</Caption><DataMember>col9</DataMember><Key>col9</Key><Position>8</Positi" & _
        "on><Width>81</Width></Column8><Column9 ID=""col10""><Caption>Last year $Sold</Capt" & _
        "ion><DataMember>col10</DataMember><Key>col10</Key><Position>9</Position><Width>8" & _
        "1</Width></Column9></Columns><ColumnSetRowCount>3</ColumnSetRowCount><GroupCondi" & _
        "tion ID="""" /><HeaderLines>2</HeaderLines><Key>Spicification</Key><RowHeight>30</" & _
        "RowHeight></RootTable></GridEXLayoutData>"
        Me.GrdSalePerformance.DesignTimeLayout = GridEXLayout1
        Me.GrdSalePerformance.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdSalePerformance.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdSalePerformance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GrdSalePerformance.GridLineColor = System.Drawing.Color.Navy
        Me.GrdSalePerformance.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GrdSalePerformance.GroupByBoxVisible = False
        Me.GrdSalePerformance.HeaderFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat
        Me.GrdSalePerformance.Location = New System.Drawing.Point(8, 16)
        Me.GrdSalePerformance.Name = "GrdSalePerformance"
        Me.GrdSalePerformance.Size = New System.Drawing.Size(776, 256)
        Me.GrdSalePerformance.TabIndex = 0
        Me.GrdSalePerformance.TreeLineColor = System.Drawing.SystemColors.Desktop
        Me.GrdSalePerformance.TreeLines = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(802, 48)
        Me.Panel2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel1.Controls.Add(Me.Txt_avail)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Txt_Desc)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtItem_No)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(802, 40)
        Me.Panel1.TabIndex = 1
        '
        'Txt_avail
        '
        Me.Txt_avail.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.Txt_avail.Location = New System.Drawing.Point(688, 8)
        Me.Txt_avail.Name = "Txt_avail"
        Me.Txt_avail.ReadOnly = True
        Me.Txt_avail.Size = New System.Drawing.Size(48, 20)
        Me.Txt_avail.TabIndex = 2
        Me.Txt_avail.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(632, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Available"
        '
        'Txt_Desc
        '
        Me.Txt_Desc.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.Txt_Desc.Location = New System.Drawing.Point(280, 8)
        Me.Txt_Desc.Name = "Txt_Desc"
        Me.Txt_Desc.ReadOnly = True
        Me.Txt_Desc.Size = New System.Drawing.Size(336, 20)
        Me.Txt_Desc.TabIndex = 1
        Me.Txt_Desc.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(196, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Description"
        '
        'TxtItem_No
        '
        Me.TxtItem_No.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(10, Byte))
        Me.TxtItem_No.Location = New System.Drawing.Point(69, 8)
        Me.TxtItem_No.Name = "TxtItem_No"
        Me.TxtItem_No.ReadOnly = True
        Me.TxtItem_No.Size = New System.Drawing.Size(120, 20)
        Me.TxtItem_No.TabIndex = 0
        Me.TxtItem_No.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item No"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT inv_item.item_no, inv_item.cod_item_type, inv_item.desc_item, inv_tab_bran" & _
        "d.cod_brand, inv_item.cod_quick_refrence, inv_item.taxable, inv_tab_style.style," & _
        " inv_item.line, inv_item.note, inv_item.picture, inv_item.upc, inv_item.special_" & _
        "notice, inv_item_cost_transaction.fet, inv_item_cost_transaction.frieght, inv_it" & _
        "em_cost_transaction.amount_price1, inv_item_cost_transaction.price_code, inv_ite" & _
        "m_cost_transaction.amount_price2, inv_item_cost_transaction.amount_price3, inv_i" & _
        "tem_cost_transaction.amount_price4, inv_item_cost_transaction.amount_price5, inv" & _
        "_item_cost_transaction.amount_price6, inv_tab_item_warehouse.on_hand, inv_tab_it" & _
        "em_warehouse.comitted, inv_tab_tire_specification.tire_size, inv_tab_tire_specif" & _
        "ication.service_description, inv_tab_tire_specification.sidwall, inv_tab_tire_sp" & _
        "ecification.load_range, inv_tab_tire_specification.mspn, inv_tab_tire_specificat" & _
        "ion.article_stock_no, inv_tab_tire_specification.rim_width_range_inch, inv_tab_t" & _
        "ire_specification.section_width_inch, inv_tab_tire_specification.width_mm, inv_t" & _
        "ab_tire_specification.aspect_ratio, inv_tab_tire_specification.rim_diameter_inch" & _
        ", inv_tab_tire_specification.speed_simbol, inv_tab_tire_specification.load_index" & _
        ", inv_tab_tire_specification.overal_diameter_inch, inv_tab_tire_specification.tr" & _
        "ead_depth, inv_tab_tire_specification.tread_width, inv_tab_tire_specification.re" & _
        "vs_per_mile, inv_tab_tire_specification.max_load_lbs, inv_tab_tire_specification" & _
        ".max_air_psl, inv_tab_tire_specification.wieght_lbs, inv_tab_tire_specification." & _
        "original_equipment, inv_tab_tire_specification.ply, inv_tab_line.line AS desc_li" & _
        "ne, inv_tab_line.treadwear, inv_tab_line.traction, inv_tab_line.temperature, inv" & _
        "_tab_brand.icon_brand, inv_tab_line.image_remark, inv_tab_line.limit_warranty, i" & _
        "nv_tab_item_warehouse.on_order, inv_tab_item_warehouse.min_stock, inv_tab_item_w" & _
        "arehouse.max_stock, inv_tab_item_warehouse.reorde, inv_discount_item.start_date_" & _
        "onsale, inv_discount_item.end_date_onsale, inv_discount_item.amount_onsale, inv_" & _
        "discount_item.start_date_contract, inv_discount_item.end_date_contract, inv_disc" & _
        "ount_item.amount_contract, inv_discount_item.start_date_spiff, inv_discount_item" & _
        ".end_date_spiff, inv_discount_item.amount_spiff, inv_item_cost_transaction.cost," & _
        " inv_item_cost_transaction.delivery, inv_item_cost_transaction.list_price, inv_i" & _
        "tem.consignment, inv_item.discontinued, inv_item.discontinued_date, inv_discount" & _
        "_item.onsale_check, inv_discount_item.contract_check, inv_discount_item.spiff_ch" & _
        "eck FROM inv_tab_line INNER JOIN inv_tab_style ON inv_tab_line.style = inv_tab_s" & _
        "tyle.style RIGHT OUTER JOIN inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_br" & _
        "and.cod_brand RIGHT OUTER JOIN inv_item LEFT OUTER JOIN inv_discount_item ON inv" & _
        "_item.item_no = inv_discount_item.item_no ON inv_tab_line.line = inv_item.line L" & _
        "EFT OUTER JOIN inv_tab_tire_specification ON inv_item.item_no = inv_tab_tire_spe" & _
        "cification.item_no LEFT OUTER JOIN inv_item_cost_transaction ON inv_item.item_no" & _
        " = inv_item_cost_transaction.item_no LEFT OUTER JOIN inv_tab_item_warehouse ON i" & _
        "nv_item.item_no = inv_tab_item_warehouse.item_no WHERE (inv_item.item_no = @Item" & _
        "_no) AND (inv_item_cost_transaction.last_flag = 1) AND (inv_discount_item.last_f" & _
        "lag = 1)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=ARMANDEHserver;p" & _
        "ersist security info=True;initial catalog=TireMate_01"
        '
        'DaInvItem
        '
        Me.DaInvItem.SelectCommand = Me.SqlSelectCommand1
        Me.DaInvItem.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("cod_item_type", "cod_item_type"), New System.Data.Common.DataColumnMapping("desc_item", "desc_item"), New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("cod_quick_refrence", "cod_quick_refrence"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("line", "line"), New System.Data.Common.DataColumnMapping("note", "note"), New System.Data.Common.DataColumnMapping("picture", "picture"), New System.Data.Common.DataColumnMapping("upc", "upc"), New System.Data.Common.DataColumnMapping("special_notice", "special_notice")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT inv_item.item_no, inv_item.cod_item_type, inv_item.desc_item, inv_item.cod" & _
        "_quick_refrence, inv_item.taxable, inv_item.line, inv_item.note, inv_item.pictur" & _
        "e, inv_item.upc, inv_item.special_notice, inv_discount_item.amount_onsale, inv_d" & _
        "iscount_item.amount_contract, inv_discount_item.amount_spiff FROM inv_item INNER" & _
        " JOIN inv_discount_item ON inv_item.item_no = inv_discount_item.item_no WHERE (i" & _
        "nv_item.item_no = @Item_no) AND (inv_discount_item.last_flag = 1)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        '
        'DaInVDiscountItem
        '
        Me.DaInVDiscountItem.SelectCommand = Me.SqlSelectCommand2
        Me.DaInVDiscountItem.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("cod_item_type", "cod_item_type"), New System.Data.Common.DataColumnMapping("desc_item", "desc_item"), New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("cod_quick_refrence", "cod_quick_refrence"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("line", "line"), New System.Data.Common.DataColumnMapping("note", "note"), New System.Data.Common.DataColumnMapping("picture", "picture"), New System.Data.Common.DataColumnMapping("upc", "upc"), New System.Data.Common.DataColumnMapping("special_notice", "special_notice")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT inv_item.item_no, inv_tab_labor_service_price.price_level1, inv_tab_labor_" & _
        "service_price.price_level2, inv_tab_labor_service_price.price_level3, inv_tab_la" & _
        "bor_service_price.price_level4, inv_tab_labor_service_price.price_level5, inv_ta" & _
        "b_labor_service_price.price_level6, inv_tab_labor_service.taxable, inv_tab_style" & _
        ".style FROM inv_tab_line RIGHT OUTER JOIN inv_item ON inv_tab_line.line = inv_it" & _
        "em.line RIGHT OUTER JOIN inv_tab_style ON inv_tab_line.style = inv_tab_style.sty" & _
        "le LEFT OUTER JOIN inv_tab_labor_service LEFT OUTER JOIN inv_tab_labor_service_p" & _
        "rice ON inv_tab_labor_service.cod_service = inv_tab_labor_service_price.cod_serv" & _
        "ice ON inv_tab_style.cod_fees_balance = inv_tab_labor_service.cod_service WHERE " & _
        "(inv_tab_labor_service_price.last_flag = 1) AND (inv_item.item_no = @item_no)"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        Me.SqlSelectCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        '
        'DaBalance
        '
        Me.DaBalance.SelectCommand = Me.SqlSelectCommand3
        Me.DaBalance.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("cod_item_type", "cod_item_type"), New System.Data.Common.DataColumnMapping("desc_item", "desc_item"), New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("cod_quick_refrence", "cod_quick_refrence"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("line", "line"), New System.Data.Common.DataColumnMapping("note", "note"), New System.Data.Common.DataColumnMapping("picture", "picture"), New System.Data.Common.DataColumnMapping("upc", "upc"), New System.Data.Common.DataColumnMapping("special_notice", "special_notice")})})
        '
        'DaTireFee
        '
        Me.DaTireFee.SelectCommand = Me.SqlCommand1
        Me.DaTireFee.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("cod_item_type", "cod_item_type"), New System.Data.Common.DataColumnMapping("desc_item", "desc_item"), New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("cod_quick_refrence", "cod_quick_refrence"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("line", "line"), New System.Data.Common.DataColumnMapping("note", "note"), New System.Data.Common.DataColumnMapping("picture", "picture"), New System.Data.Common.DataColumnMapping("upc", "upc"), New System.Data.Common.DataColumnMapping("special_notice", "special_notice")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT inv_item.item_no, inv_tab_labor_service_price.price_level1, inv_tab_labor_" & _
        "service_price.price_level2, inv_tab_labor_service_price.price_level3, inv_tab_la" & _
        "bor_service_price.price_level4, inv_tab_labor_service_price.price_level5, inv_ta" & _
        "b_labor_service_price.price_level6, inv_tab_labor_service.taxable FROM inv_tab_l" & _
        "abor_service_price RIGHT OUTER JOIN inv_tab_labor_service LEFT OUTER JOIN inv_ta" & _
        "b_style RIGHT OUTER JOIN inv_tab_line ON inv_tab_style.style = inv_tab_line.styl" & _
        "e RIGHT OUTER JOIN inv_item ON inv_tab_line.line = inv_item.line ON inv_tab_labo" & _
        "r_service.cod_service = inv_tab_style.cod_fees_tire ON inv_tab_labor_service_pri" & _
        "ce.cod_service = inv_tab_labor_service.cod_service WHERE (inv_tab_labor_service_" & _
        "price.last_flag = 1) AND (inv_item.item_no = @item_no)"
        Me.SqlCommand1.Connection = Me.Cnn
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        '
        'DaDisposalFee
        '
        Me.DaDisposalFee.SelectCommand = Me.SqlCommand2
        Me.DaDisposalFee.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("cod_item_type", "cod_item_type"), New System.Data.Common.DataColumnMapping("desc_item", "desc_item"), New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("cod_quick_refrence", "cod_quick_refrence"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("line", "line"), New System.Data.Common.DataColumnMapping("note", "note"), New System.Data.Common.DataColumnMapping("picture", "picture"), New System.Data.Common.DataColumnMapping("upc", "upc"), New System.Data.Common.DataColumnMapping("special_notice", "special_notice")})})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "SELECT inv_item.item_no, inv_tab_labor_service_price.price_level1, inv_tab_labor_" & _
        "service_price.price_level2, inv_tab_labor_service_price.price_level3, inv_tab_la" & _
        "bor_service_price.price_level4, inv_tab_labor_service_price.price_level5, inv_ta" & _
        "b_labor_service_price.price_level6, inv_tab_labor_service.taxable FROM inv_tab_l" & _
        "abor_service_price RIGHT OUTER JOIN inv_tab_labor_service LEFT OUTER JOIN inv_ta" & _
        "b_style RIGHT OUTER JOIN inv_tab_line ON inv_tab_style.style = inv_tab_line.styl" & _
        "e RIGHT OUTER JOIN inv_item ON inv_tab_line.line = inv_item.line ON inv_tab_labo" & _
        "r_service.cod_service = inv_tab_style.cod_fees_disposal ON inv_tab_labor_service" & _
        "_price.cod_service = inv_tab_labor_service.cod_service WHERE (inv_tab_labor_serv" & _
        "ice_price.last_flag = 1) AND (inv_item.item_no = @item_no)"
        Me.SqlCommand2.Connection = Me.Cnn
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        '
        'DaValueStem
        '
        Me.DaValueStem.SelectCommand = Me.SqlCommand3
        Me.DaValueStem.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("cod_item_type", "cod_item_type"), New System.Data.Common.DataColumnMapping("desc_item", "desc_item"), New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("cod_quick_refrence", "cod_quick_refrence"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("line", "line"), New System.Data.Common.DataColumnMapping("note", "note"), New System.Data.Common.DataColumnMapping("picture", "picture"), New System.Data.Common.DataColumnMapping("upc", "upc"), New System.Data.Common.DataColumnMapping("special_notice", "special_notice")})})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT inv_item.item_no, inv_tab_labor_service_price.price_level1, inv_tab_labor_" & _
        "service_price.price_level2, inv_tab_labor_service_price.price_level3, inv_tab_la" & _
        "bor_service_price.price_level4, inv_tab_labor_service_price.price_level5, inv_ta" & _
        "b_labor_service_price.price_level6, inv_tab_labor_service.taxable FROM inv_tab_l" & _
        "abor_service_price RIGHT OUTER JOIN inv_tab_labor_service LEFT OUTER JOIN inv_ta" & _
        "b_style RIGHT OUTER JOIN inv_tab_line ON inv_tab_style.style = inv_tab_line.styl" & _
        "e RIGHT OUTER JOIN inv_item ON inv_tab_line.line = inv_item.line ON inv_tab_labo" & _
        "r_service.cod_service = inv_tab_style.cod_valvestem ON inv_tab_labor_service_pri" & _
        "ce.cod_service = inv_tab_labor_service.cod_service WHERE (inv_tab_labor_service_" & _
        "price.last_flag = 1) AND (inv_item.item_no = @item_no)"
        Me.SqlCommand3.Connection = Me.Cnn
        Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        '
        'DaRoadHazard
        '
        Me.DaRoadHazard.SelectCommand = Me.SqlCommand4
        Me.DaRoadHazard.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("cod_item_type", "cod_item_type"), New System.Data.Common.DataColumnMapping("desc_item", "desc_item"), New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("cod_quick_refrence", "cod_quick_refrence"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("line", "line"), New System.Data.Common.DataColumnMapping("note", "note"), New System.Data.Common.DataColumnMapping("picture", "picture"), New System.Data.Common.DataColumnMapping("upc", "upc"), New System.Data.Common.DataColumnMapping("special_notice", "special_notice")})})
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "SELECT inv_item.item_no, inv_tab_labor_service_price.price_level1, inv_tab_labor_" & _
        "service_price.price_level2, inv_tab_labor_service_price.price_level3, inv_tab_la" & _
        "bor_service_price.price_level4, inv_tab_labor_service_price.price_level5, inv_ta" & _
        "b_labor_service_price.price_level6, inv_tab_labor_service.taxable FROM inv_tab_l" & _
        "abor_service_price RIGHT OUTER JOIN inv_tab_labor_service LEFT OUTER JOIN inv_ta" & _
        "b_style RIGHT OUTER JOIN inv_tab_line ON inv_tab_style.style = inv_tab_line.styl" & _
        "e RIGHT OUTER JOIN inv_item ON inv_tab_line.line = inv_item.line ON inv_tab_labo" & _
        "r_service.cod_service = inv_tab_style.cod_roadhazard ON inv_tab_labor_service_pr" & _
        "ice.cod_service = inv_tab_labor_service.cod_service WHERE (inv_tab_labor_service" & _
        "_price.last_flag = 1) AND (inv_item.item_no = @item_no)"
        Me.SqlCommand4.Connection = Me.Cnn
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT MONTH(CAST(service_center_head.date_refer AS datetime)) AS Month, SUM(serv" & _
        "ice_center_dtl.qty) AS SumQty, SUM(service_center_dtl.price) AS SumPrice FROM se" & _
        "rvice_center_head LEFT OUTER JOIN service_center_dtl ON service_center_head.id_s" & _
        "ervice_center = service_center_dtl.id_service_center LEFT OUTER JOIN inv_item ON" & _
        " service_center_dtl.cod_select = inv_item.item_no WHERE (YEAR(CAST(service_cente" & _
        "r_head.date_refer AS datetime)) = @CurrentYear) AND (service_center_head.type_of" & _
        "_form = 'IN') AND (service_center_dtl.type_select = 'I') GROUP BY MONTH(CAST(ser" & _
        "vice_center_head.date_refer AS datetime))"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CurrentYear", System.Data.SqlDbType.Decimal))
        '
        'DaSalePerformance
        '
        Me.DaSalePerformance.SelectCommand = Me.SqlSelectCommand4
        Me.DaSalePerformance.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("license_no_vehicle", "license_no_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before")})})
        '
        'CmdCancel
        '
        Me.CmdCancel.Location = New System.Drawing.Point(720, 384)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.CmdCancel.TabIndex = 2
        Me.CmdCancel.Text = "Cancel"
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(625, 384)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 23)
        Me.CmdOk.TabIndex = 3
        Me.CmdOk.Text = "Ok"
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT inv_item_vendor.item_no, inv_item_vendor.ven_part_no, inv_vendor.desc_vend" & _
        "or, inv_item_vendor.cod_vendor, inv_item_vendor.remark FROM inv_item_vendor LEFT" & _
        " OUTER JOIN inv_vendor ON inv_item_vendor.cod_vendor = inv_vendor.cod_vendor WHE" & _
        "RE (inv_item_vendor.item_no = @item_no)"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        Me.SqlSelectCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        '
        'DaInvItemVendor
        '
        Me.DaInvItemVendor.SelectCommand = Me.SqlSelectCommand5
        Me.DaInvItemVendor.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item_vendor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("ven_part_no", "ven_part_no"), New System.Data.Common.DataColumnMapping("remark", "remark")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT inv_tab_labor_service_price.price_rate, inv_tab_labor_service.type_b_t_d_v" & _
        "_r, inv_tab_labor_service.taxable FROM inv_tab_labor_service LEFT OUTER JOIN inv" & _
        "_tab_labor_service_price ON inv_tab_labor_service.cod_service = inv_tab_labor_se" & _
        "rvice_price.cod_service RIGHT OUTER JOIN inv_tab_style ON inv_tab_labor_service_" & _
        "price.style = inv_tab_style.style RIGHT OUTER JOIN inv_tab_line ON inv_tab_style" & _
        ".style = inv_tab_line.style RIGHT OUTER JOIN inv_item ON inv_tab_line.line = inv" & _
        "_item.line WHERE (inv_tab_labor_service.type_b_t_d_v_r IN ('b', 't', 'd', 'v', '" & _
        "r')) AND (inv_item.item_no = @Item_no)"
        Me.SqlSelectCommand6.Connection = Me.Cnn
        Me.SqlSelectCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        '
        'DaInTab_Labor_Service
        '
        Me.DaInTab_Labor_Service.SelectCommand = Me.SqlSelectCommand6
        Me.DaInTab_Labor_Service.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_labor_service_price", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_price_labor_service", "id_price_labor_service"), New System.Data.Common.DataColumnMapping("cod_service", "cod_service"), New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("price_rate", "price_rate"), New System.Data.Common.DataColumnMapping("price_level1", "price_level1"), New System.Data.Common.DataColumnMapping("price_level2", "price_level2"), New System.Data.Common.DataColumnMapping("price_level3", "price_level3"), New System.Data.Common.DataColumnMapping("price_level4", "price_level4"), New System.Data.Common.DataColumnMapping("price_level5", "price_level5"), New System.Data.Common.DataColumnMapping("price_level6", "price_level6")})})
        '
        'DaLastReceive
        '
        Me.DaLastReceive.SelectCommand = Me.SqlSelectCommand8
        Me.DaLastReceive.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Inv_Receive_Products_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_receive_ref", "id_receive_ref"), New System.Data.Common.DataColumnMapping("date_receive", "date_receive"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("bill_credit", "bill_credit"), New System.Data.Common.DataColumnMapping("bill_receive", "bill_receive"), New System.Data.Common.DataColumnMapping("ap_term", "ap_term"), New System.Data.Common.DataColumnMapping("receipt_bill_date", "receipt_bill_date"), New System.Data.Common.DataColumnMapping("vendor_ref_no", "vendor_ref_no"), New System.Data.Common.DataColumnMapping("due_date", "due_date"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("house_comments", "house_comments"), New System.Data.Common.DataColumnMapping("vend_comments", "vend_comments"), New System.Data.Common.DataColumnMapping("Discount", "Discount"), New System.Data.Common.DataColumnMapping("id_check", "id_check"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal")})})
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT TOP 1 Inv_Receive_Products_head.date_receive AS date1, CAST(Inv_Receive_pr" & _
        "oduct_dtl.qty * (Inv_Receive_product_dtl.cost + Inv_Receive_product_dtl.Fet) AS " & _
        "decimal(8, 2)) AS lastAmount FROM Inv_Receive_Products_head INNER JOIN Inv_Recei" & _
        "ve_product_dtl ON Inv_Receive_Products_head.id_receive_ref = Inv_Receive_product" & _
        "_dtl.id_receive_ref WHERE (Inv_Receive_product_dtl.item_no = @item_No) ORDER BY " & _
        "Inv_Receive_Products_head.date_receive DESC"
        Me.SqlSelectCommand8.Connection = Me.Cnn
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_No", System.Data.SqlDbType.VarChar, 20, "item_no"))
        '
        'DALastAdjustment
        '
        Me.DALastAdjustment.DeleteCommand = Me.SqlDeleteCommand5
        Me.DALastAdjustment.InsertCommand = Me.SqlInsertCommand5
        Me.DALastAdjustment.SelectCommand = Me.SqlCommand5
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
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "SELECT inv_adjustment_head.date_adjustment AS date1, CAST(inv_adjustment_dtl.QTY " & _
        "* inv_adjustment_dtl.Cost AS decimal(8, 2)) AS lastamount FROM inv_adjustment_he" & _
        "ad INNER JOIN inv_adjustment_dtl ON inv_adjustment_head.referID_adjustment = inv" & _
        "_adjustment_dtl.referID_adjustment WHERE (inv_adjustment_dtl.item_no = @item_no)" & _
        " ORDER BY inv_adjustment_head.date_adjustment DESC"
        Me.SqlCommand5.Connection = Me.Cnn
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
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
        'DaLastServicecenter
        '
        Me.DaLastServicecenter.SelectCommand = Me.SqlSelectCommand9
        Me.DaLastServicecenter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Total", "Total")})})
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT service_center_head.date_refer AS date1, CAST(service_center_dtl.qty * (se" & _
        "rvice_center_dtl.price + service_center_dtl.fet) AS decimal(8, 2)) AS lastAmount" & _
        " FROM service_center_head INNER JOIN service_center_dtl ON service_center_head.i" & _
        "d_service_center = service_center_dtl.id_service_center WHERE (service_center_dt" & _
        "l.type_select = 'I') AND (service_center_dtl.cod_select = @item_no) ORDER BY ser" & _
        "vice_center_head.date_refer DESC"
        Me.SqlSelectCommand9.Connection = Me.Cnn
        Me.SqlSelectCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "cod_select"))
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'CmdPrint
        '
        Me.CmdPrint.Location = New System.Drawing.Point(528, 384)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(75, 23)
        Me.CmdPrint.TabIndex = 4
        Me.CmdPrint.Text = "Print"
        '
        'FrmItemDetailShow
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(802, 416)
        Me.Controls.Add(Me.CmdPrint)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmItemDetailShow"
        Me.Text = "Item Detail"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.p4.ResumeLayout(False)
        Me.Panel24.ResumeLayout(False)
        Me.Panel25.ResumeLayout(False)
        CType(Me.DsInv_Item1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel23.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.GrdSalePerformance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmItemDetailShow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Cnn.ConnectionString = PConnectionString
            ItemNo1 = New UCInv_Item.ItemNo
            ItemNo1.Connection = Cnn
            MyclsItemno = New Clsitem_no
            MyclsItemno.Connection = Me.Cnn

            If MItem_no = "" Then
                MsgBox("Error")
                Me.Close()
            End If
            DaInvItem.SelectCommand.Parameters("@Item_no").Value = MItem_no
            DaInvItem.Fill(MyDS, "inv_item")
            If MyDS.Tables("inv_item").Rows.Count <= 0 Then
                MsgBox("No found for item " & MItem_no)
                Me.Close()
            End If
            DaInVDiscountItem.SelectCommand.Parameters("@Item_no").Value = MItem_no
            DaInVDiscountItem.Fill(MyDS, "inv_discount")

            Dim lastrecive As String = MyclsItemno.PLastRecordReceivereturn(MItem_no)
            Dim ds1 As New DataSet
            If lastrecive <> "" Then
                LastReceiveDate.Text = MyclsItemno.LoadThisReceiveAndReturn(lastrecive, ds1)
                MyclsItemno.CalculateSumReceive(ds1, CDec("0" & ds1.Tables("Inv_Receive_Products_head").Rows(0).Item("Discount")))
            End If


            Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
            OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
            Try
                Dim SALES_TAXTempVar As String
                SALES_TAXTempVar = OleDbReaderForStore.Item("SALES_TAX") & ""
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "SELECT  Amount  FROM  cust_sales_tax Where cod_sales_tax=" & Qt(SALES_TAXTempVar)
                PTax = CmdGeneral.ExecuteScalar
            Catch ex As Exception
                PTax = 0
            End Try


            'Try
            '    PTax = OleDbReaderForStore.Item("SALES_TAX") & ""
            'Catch ex As Exception
            '    PTax = 0
            'End Try
            OleDbReaderForStore.Close()


            '------------
            'DaBalance.SelectCommand.Parameters("@Item_no").Value = MItem_no
            'DaBalance.Fill(MyDS, "balance")
            'DaTireFee.SelectCommand.Parameters("@Item_no").Value = MItem_no
            'DaTireFee.Fill(MyDS, "tirefee")

            'DaDisposalFee.SelectCommand.Parameters("@Item_no").Value = MItem_no
            'DaTireFee.Fill(MyDS, "disposalfee")
            'DaValueStem.SelectCommand.Parameters("@Item_no").Value = MItem_no
            'DaValueStem.Fill(MyDS, "valuesteam")
            'DaRoadHazard.SelectCommand.Parameters("@Item_no").Value = MItem_no
            'DaRoadHazard.Fill(MyDS, "roadhazard")
            '------------
            DaInTab_Labor_Service.SelectCommand.Parameters("@Item_no").Value = MItem_no
            DaInTab_Labor_Service.Fill(MyDS, "BTD")

            DaInvItemVendor.SelectCommand.Parameters("@Item_no").Value = MItem_no
            DaInvItemVendor.Fill(DsInv_Item1.inv_item_vendor)

            Call InitData()
            ' Price level 1
            Call InitGridSalePerformance()
            Call SalePerformance()


            l1.Text = PriceLevelsLabels(1)
            l2.Text = PriceLevelsLabels(2)
            l3.Text = PriceLevelsLabels(3)
            l4.Text = PriceLevelsLabels(4)
            l5.Text = PriceLevelsLabels(5)
            l6.Text = PriceLevelsLabels(6)

            CmbPrice.Items.Clear()
            For i = 1 To 6
                CmbPrice.Items.Add(PriceLevelsLabels(i))
            Next
            CmbPrice.SelectedIndex = 0
            CalculatePriceCodePriceLevel()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub InitData()
        Dim Prc As Integer = CmbPrice.SelectedIndex + 1
        Try
            If MyDS.Tables("inv_item").Rows.Count > 0 Then
                With MyDS.Tables("inv_item").Rows(0)
                    GlobalCost = MyCdec(.Item("Cost") & "")
                    GlobalPrice = MyCdec(.Item("List_price") & "")
                    GlobalPriceCod = .Item("price_Code") & ""
                    TxtItem_No.Text = .Item("Item_no") & ""
                    Txt_Desc.Text = .Item("desc_item") & ""
                    Txt_avail.Text = MyCdec(Val(.Item("on_hand") & "")) - MyCdec(Val(.Item("comitted") & ""))
                    TxtFet.Text = .Item("fet")
                    TxtFet1.Text = .Item("fet")
                    TxtFet2.Text = .Item("fet")
                    plf1.Text = MyCdec(.Item("Amount_Price1")) + MyCdec(.Item("fet"))
                    plf2.Text = MyCdec(.Item("Amount_Price2")) + MyCdec(.Item("fet"))
                    plf3.Text = MyCdec(.Item("Amount_Price3")) + MyCdec(.Item("fet"))
                    plf4.Text = MyCdec(.Item("Amount_Price4")) + MyCdec(.Item("fet"))
                    plf5.Text = MyCdec(.Item("Amount_Price5")) + MyCdec(.Item("fet"))
                    plf6.Text = MyCdec(.Item("Amount_Price6")) + MyCdec(.Item("fet"))
                    ChkConsighment.Checked = .Item("consignment")
                    ChkDiscontinued.Checked = .Item("discontinued")
                End With
                Call InitPriceLevel()
            End If
            '----------------init tab specification
            Dim MyData1() As Byte
            Dim MyData2() As Byte
            IconBrand.Image = Nothing
            Image_Remark.Image = Nothing
            '-------------------
            With MyDS.Tables("inv_item").Rows(0)
                Try
                    MyData1 = .Item("icon_brand")
                Catch ex As Exception
                    MyData1 = Nothing

                End Try
                Try
                    MyData2 = .Item("Image_Remark")
                Catch ex As Exception
                    MyData1 = Nothing
                End Try
                Try
                    Dim MyPicStream1 As New MemoryStream(MyData1)
                    Dim MyPicStream2 As New MemoryStream(MyData2)
                    img1 = Image.FromStream(MyPicStream1)
                    img2 = Image.FromStream(MyPicStream2)
                    IconBrand.Image = img1
                    Image_Remark.Image = img2


                Catch ex As Exception

                End Try
                MyData1 = Nothing
                MyData2 = Nothing
                LineDesc.Text = .Item("Desc_line") & ""
                Note.Text = .Item("note") & ""
                TxtTS.Text = .Item("Tire_size") & ""
                TxtSd.Text = .Item("Service_description") & ""
                TxtSW.Text = .Item("sidwall") & ""
                txtRW.Text = .Item("rim_width_range_inch") & ""
                TxtOd.Text = .Item("overal_diameter_inch") & ""
                TxtTd.Text = .Item("tread_depth") & ""
                TxtMl.Text = .Item("max_load_lbs") & ""
                t1.Text = .Item("treadwear") & ""
                t2.Text = .Item("traction") & ""
                t3.Text = .Item("temperature") & ""
                limit_warranty.Text = .Item("limit_warranty") & ""
                '---- init tab status
                TxtOnHand.Text = .Item("on_hand") & ""
                TxtComitted.Text = .Item("comitted") & ""
                TxtOnOrder.Text = .Item("on_order") & ""
                TxtMinStock.Text = .Item("min_stock") & ""
                TxtMaxStock.Text = .Item("max_stock") & ""
                TxtReOrder.Text = .Item("reorde") & ""
                TxtAvailable.Text = MyCdec(TxtOnHand.Text) - MyCdec(TxtComitted.Text)
                start_date_onsale.Text = .Item("start_date_onsale") & ""
                end_date_onsale.Text = .Item("end_date_onsale") & ""
                amount_onsale.Text = .Item("amount_onsale") & ""

                start_date_contract.Text = .Item("start_date_contract") & ""
                end_date_contract.Text = .Item("end_date_contract") & ""
                amount_contract.Text = .Item("amount_contract") & ""
                start_date_spiff.Text = .Item("start_date_spiff") & ""
                end_date_spiff.Text = .Item("end_date_spiff") & ""
                amount_spiff.Text = .Item("amount_spiff") & ""

                ChkOnSale.Checked = .Item("onsale_check")
                ChkContract.Checked = .Item("contract_check")
                ChkSpiff.Checked = .Item("spiff_check")


                TxtCost.Text = .Item("Cost") & ""
                TxtDelivery.Text = .Item("delivery") & ""
                TxtFriegt.Text = .Item("frieght") & ""
                TxtReplCost.Text = MyCdec(TxtCost.Text) + MyCdec(TxtDelivery.Text) + MyCdec(TxtFriegt.Text)
                Call CalculateAllLast()
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub
    Sub InitPriceLevel()
        If CmbPrice.SelectedIndex < 0 Then CmbPrice.SelectedIndex = 0
        Dim Prc As Integer = CmbPrice.SelectedIndex + 1

        Select Case CmbPrice.SelectedIndex + 1
            Case 1
                TxtPrice1.Text = Pl1.Text
            Case 2
                TxtPrice1.Text = pl2.Text
            Case 3
                TxtPrice1.Text = pl3.Text
            Case 4
                TxtPrice1.Text = pl4.Text
            Case 5
                TxtPrice1.Text = pl5.Text
            Case 6
                TxtPrice1.Text = pl6.Text
        End Select
        'TxtPrice1.Text = MycDec( MyDS.Tables("inv_item").Rows(0).Item("Amount_Price" & Trim(Prc & "")))
        TxtOnSale.Text = TxtPrice1.Text
        If Prc = 1 Then
            If MyDS.Tables("inv_discount").Rows.Count > 0 Then
                '       TxtPrice1.Text = MycDec( MyDS.Tables("inv_discount").Rows(0).Item("amount_onsale"))
                '      TxtOnSale.Text = TxtPrice1.Text
            End If
        End If
        TxtPrice2.Text = TxtPrice1.Text
        Dim Mablag As Decimal = 0
        TxtBalanceTax = False
        TxtTireFeeTax = False
        TxtDisposalFeeTax = False
        TxtValueStemTax = False
        TxtRoadHazardTax = False

        If MyDS.Tables("BTD").Rows.Count - 1 > 0 Then
            With MyDS.Tables("BTD")
                For i = 0 To .Rows.Count - 1
                    Mablag = Math.Round(.Rows(i).Item("price_rate"), 2)
                    Select Case .Rows(i).Item("type_b_t_d_v_r")
                        Case "b"
                            TxtBalance.Text = Mablag
                            TxtBalanceTax = IIf(.Rows(i).Item("taxable") = True, True, False)
                        Case "t"
                            TxtTireFee.Text = Mablag '.Rows(i).Item("price_rate")
                            TxtTireFeeTax = IIf(.Rows(i).Item("taxable") = True, True, False)
                        Case "d"
                            TxtDisposalFee.Text = Mablag '.Rows(i).Item("price_rate")
                            TxtDisposalFeeTax = IIf(.Rows(i).Item("taxable") = True, True, False)
                        Case "v"
                            TxtValueStem.Text = Mablag '.Rows(i).Item("price_rate")
                            TxtValueStemTax = IIf(.Rows(i).Item("taxable") = True, True, False)
                        Case "r"
                            TxtRoadHazard.Text = Mablag '.Rows(i).Item("price_rate")
                            TxtRoadHazardTax = IIf(.Rows(i).Item("taxable") = True, True, False)
                        Case Else
                            MsgFar("type_b_t_d_v_r  Not Correct In inv_tab_labor_service ")
                    End Select

                Next
            End With
        Else
            '  MsgFar("There is no row in inv_tab_labor_service or inv_tab_labor_service_price ")
        End If
        'If MyDS.Tables("balance").Rows.Count > 0 Then
        '    TxtBalance.Text = MyCdec(MyDS.Tables("balance").Rows(0).Item("Price_level" & Trim(Prc & "")))
        'End If
        'If MyDS.Tables("tirefee").Rows.Count > 0 Then
        '    TxtBalance.Text = MyCdec(MyDS.Tables("tirefee").Rows(0).Item("Price_level" & Trim(Prc & "")))
        'End If

        'If MyDS.Tables("disposalfee").Rows.Count > 0 Then
        '    TxtBalance.Text = MyCdec(MyDS.Tables("disposalfee").Rows(0).Item("Price_level" & Trim(Prc & "")))
        'End If

        'If MyDS.Tables("valuesteam").Rows.Count > 0 Then
        '    TxtValueStem.Text = MyCdec(MyDS.Tables("valuesteam").Rows(0).Item("Price_level" & Trim(Prc & "")))
        'End If
        'If MyDS.Tables("roadhazard").Rows.Count > 0 Then
        '    TxtRoadHazard.Text = MyCdec(MyDS.Tables("roadhazard").Rows(0).Item("Price_level" & Trim(Prc & "")))
        'End If
        flagcalculate = True
    End Sub
    Private Sub ChkBalance_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkBalance.CheckedChanged
        TxtBalance.Enabled = ChkBalance.Checked
        calculateall()
    End Sub
    Private Sub ChkTireFee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkTireFee.CheckedChanged
        TxtTireFee.Enabled = ChkTireFee.Checked
        calculateall()
    End Sub
    Private Sub ChkDisposalFee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDisposalFee.CheckedChanged
        TxtDisposalFee.Enabled = ChkDisposalFee.Checked
        calculateall()
    End Sub
    Private Sub ChkValueSteam_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkValueSteam.CheckedChanged
        TxtValueStem.Enabled = ChkValueSteam.Checked
        calculateall()
    End Sub
    Private Sub ChkRoadHazard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkRoadHazard.CheckedChanged
        TxtRoadHazard.Enabled = ChkRoadHazard.Checked
        calculateall()
    End Sub
    Sub calculateall()
        Try
            If flagcalculate Then
                Dim STotal As Decimal = 0
                Dim SAllService = SumAllService()
                Subtotal1.Text = MyCdec(Qty1.Text) * (MyCdec(TxtPrice1.Text) + MyCdec(TxtFet1.Text) + SAllService)
                SubTotal2.Text = MyCdec(Qty2.Text) * (MyCdec(TxtPrice2.Text) + MyCdec(TxtFet2.Text) + SAllService)
                Dim TaxItem_no As Decimal = 0
                Dim TaxItem_no2 As Decimal = 0
                If MyDS.Tables("inv_item").Rows(0).Item("taxable") = True Then
                    TaxItem_no = ((Val(TxtPrice1.Text) + Val(TxtFet1.Text & "")) * PTax) / 100
                    TaxItem_no2 = ((Val(TxtPrice2.Text & "") + Val(TxtFet2.Text & "")) * PTax) / 100
                End If
                Dim othertax As Decimal = 0 '= CalculateTaxForOtherServices()

                If TxtBalanceTax And ChkBalance.Checked Then
                    othertax = othertax + ((Math.Round(Val("0" & TxtBalance.Text), 2) * PTax) / 100)
                End If
                If TxtTireFeeTax And ChkTireFee.Checked Then
                    othertax = othertax + ((Math.Round(Val("0" & TxtTireFee.Text), 2) * PTax) / 100)
                End If
                If TxtDisposalFeeTax And ChkDisposalFee.Checked Then
                    othertax = othertax + ((Math.Round(Val("0" & TxtDisposalFee.Text), 2) * PTax) / 100)
                End If
                If TxtValueStemTax And ChkValueSteam.Checked Then
                    othertax = othertax + ((Math.Round(Val("0" & TxtValueStem.Text), 2) * PTax) / 100)
                End If
                If TxtRoadHazardTax And ChkRoadHazard.Checked Then
                    othertax = othertax + ((Math.Round(Val("0" & TxtRoadHazard.Text), 2) * PTax) / 100)
                End If




                Dim Stax1 As Decimal = Val(Qty1.Text & "") * (othertax + TaxItem_no)
                Dim Stax2 As Decimal = MyCdec(Qty2.Text & "") * (othertax + TaxItem_no2)
                Tax1.Text = Stax1
                Tax2.Text = Stax2
                Total1.Text = MyCdec(Subtotal1.Text + Stax1)
                Total2.Text = MyCdec(SubTotal2.Text + Stax2)
                Plf1.Text = MyCdec(Pl1.Text) + MyCdec(TxtFet1.Text)
                plf2.Text = MyCdec(Pl2.Text) + MyCdec(TxtFet1.Text)
                plf3.Text = MyCdec(pl3.Text) + MyCdec(TxtFet1.Text)
                plf4.Text = MyCdec(pl4.Text) + MyCdec(TxtFet1.Text)
                plf5.Text = MyCdec(pl5.Text) + MyCdec(TxtFet1.Text)
                plf6.Text = MyCdec(pl6.Text) + MyCdec(TxtFet1.Text)


            End If
        Catch ex As Exception
            ' MsgBox(ex.ToString)
        End Try
    End Sub
    Sub CalculatePriceCodePriceLevel()
        Pl1.Text = CalculatePriceCode(1)
        pl2.Text = CalculatePriceCode(2)
        pl3.Text = CalculatePriceCode(3)
        pl4.Text = CalculatePriceCode(4)
        pl5.Text = CalculatePriceCode(5)
        pl6.Text = CalculatePriceCode(6)
    End Sub
    Function CalculatePriceCode(ByVal Thislevel As Integer) As Decimal
        'if CmbPrice.SelectedValue & "" = "" C
        CalculatePriceCode = ItemNo1.ClsItem_No1.CalculatePriceCode(GlobalPriceCod, Thislevel, GlobalCost, GlobalPrice)
    End Function
    Private Sub CmbPrice_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPrice.SelectedIndexChanged
        CalculatePriceCodePriceLevel()
        Call InitPriceLevel()
        Call calculateall()
    End Sub
    Function SumAllService() As Decimal
        SumAllService = 0
        If ChkBalance.Checked Then
            SumAllService = SumAllService + MyCdec(TxtBalance.Text)
        End If
        If ChkTireFee.Checked Then
            SumAllService = SumAllService + MyCdec(TxtTireFee.Text)
        End If

        If ChkDisposalFee.Checked Then
            SumAllService = SumAllService + MyCdec(TxtDisposalFee.Text)
        End If

        If ChkValueSteam.Checked Then
            SumAllService = SumAllService + MyCdec(TxtValueStem.Text)
        End If

        If ChkRoadHazard.Checked Then
            SumAllService = SumAllService + MyCdec(TxtRoadHazard.Text)
        End If
    End Function

    Function CalculateTaxForOtherServices() As Decimal
        CalculateTaxForOtherServices = 0
        If MyDS.Tables("balance").Rows.Count > 0 Then
            If ChkBalance.Checked Then
                If MyDS.Tables("balance").Rows(0).Item("taxable") = True Then
                    CalculateTaxForOtherServices = CalculateTaxForOtherServices + MyCdec(TxtBalance.Text) * PTax
                End If
            End If
        End If

        With MyDS.Tables("tirefee")
            If .Rows.Count > 0 Then
                If ChkTireFee.Checked = True Then
                    CalculateTaxForOtherServices = CalculateTaxForOtherServices + MyCdec(TxtTireFee.Text) * PTax
                End If
            End If
        End With
        With MyDS.Tables("disposalfee")
            If .Rows.Count > 0 Then
                If ChkDisposalFee.Checked = True Then
                    CalculateTaxForOtherServices = CalculateTaxForOtherServices + MyCdec(TxtDisposalFee.Text) * PTax
                End If
            End If
        End With
        With MyDS.Tables("valuesteam")
            If .Rows.Count > 0 Then
                If ChkValueSteam.Checked Then
                    CalculateTaxForOtherServices = CalculateTaxForOtherServices + MyCdec(TxtValueStem.Text) * PTax
                End If
            End If
        End With
        With MyDS.Tables("roadhazard")
            If .Rows.Count > 0 Then
                If ChkRoadHazard.Checked Then
                    CalculateTaxForOtherServices = CalculateTaxForOtherServices + MyCdec(TxtRoadHazard.Text) * PTax
                End If
            End If
        End With
    End Function

    Private Sub TxtBalance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPrice1.TextChanged, TxtPrice2.TextChanged, TxtFet1.TextChanged, TxtFet2.TextChanged, Qty1.TextChanged, Qty2.TextChanged, TxtBalance.TextChanged, TxtTireFee.TextChanged, TxtDisposalFee.TextChanged, TxtValueStem.TextChanged, TxtRoadHazard.TextChanged
        Call calculateall()
    End Sub

    Sub InitGridSalePerformance()
        DsInv_Item1.Spicification.Clear()
        Dim i As Integer = 0

        'For i = 0 To 5
        Dim arow(6) As DSInv_Item.SpicificationRow '
        arow(1) = DsInv_Item1.Spicification.NewRow()
        arow(1).col1 = "January"
        arow(1).col6 = "July"
        DsInv_Item1.Spicification.Rows.Add(arow(1))

        arow(2) = DsInv_Item1.Spicification.NewRow()
        arow(2).col1 = "February"
        arow(2).col6 = "August"
        DsInv_Item1.Spicification.Rows.Add(arow(2))


        arow(3) = DsInv_Item1.Spicification.NewRow()
        arow(3).col1 = "March"
        arow(3).col6 = "September"
        DsInv_Item1.Spicification.Rows.Add(arow(3))

        arow(4) = DsInv_Item1.Spicification.NewRow()
        arow(4).col1 = "April"
        arow(4).col6 = "October"
        DsInv_Item1.Spicification.Rows.Add(arow(4))

        arow(5) = DsInv_Item1.Spicification.NewRow()
        arow(5).col1 = "May"
        arow(5).col6 = "November"
        DsInv_Item1.Spicification.Rows.Add(arow(5))

        arow(6) = DsInv_Item1.Spicification.NewRow()
        arow(6).col1 = "June"
        arow(6).col6 = "December"
        DsInv_Item1.Spicification.Rows.Add(arow(6))

        'Next

    End Sub

    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        Me.Close()
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Me.Close()
    End Sub
    Sub SalePerformance()
        Try
            Dim i As Int16 = 0
            DsInv_Item1.service_center_head.Clear()
            Dim currentyear As String = Year(Now)
            DaSalePerformance.SelectCommand.Parameters("@Currentyear").Value = currentyear
            DaSalePerformance.Fill(DsInv_Item1.service_center_head)
            For i = 0 To DsInv_Item1.service_center_head.Rows.Count - 1
                With DsInv_Item1.service_center_head.Rows(i)
                    Select Case .Item("Month")
                        Case 1, 2, 3, 4, 5, 6
                            DsInv_Item1.Spicification.Rows(.Item("Month")).Item("col2") = .Item("sumqty")
                            DsInv_Item1.Spicification.Rows(.Item("Month")).Item("col3") = .Item("sumprice")
                        Case 7, 8, 9, 109, 11, 12
                            DsInv_Item1.Spicification.Rows(.Item("Month")).Item("col7") = .Item("sumqty")
                            DsInv_Item1.Spicification.Rows(.Item("Month")).Item("col7") = .Item("sumprice")

                    End Select
                End With
            Next
            DsInv_Item1.service_center_head.Clear()
            DaSalePerformance.SelectCommand.Parameters("@Currentyear").Value = CDec(currentyear) - 1
            DaSalePerformance.Fill(DsInv_Item1.service_center_head)
            For i = 0 To DsInv_Item1.service_center_head.Rows.Count - 1
                With DsInv_Item1.service_center_head.Rows(i)
                    Select Case .Item("Month")
                        Case 1, 2, 3, 4, 5, 6
                            DsInv_Item1.Spicification.Rows(.Item("Month")).Item("col4") = .Item("sumqty")
                            DsInv_Item1.Spicification.Rows(.Item("Month")).Item("col5") = .Item("sumprice")
                        Case 7, 8, 9, 109, 11, 12
                            DsInv_Item1.Spicification.Rows(.Item("Month")).Item("col9") = .Item("sumqty")
                            DsInv_Item1.Spicification.Rows(.Item("Month")).Item("col10") = .Item("sumprice")

                    End Select
                End With
            Next
            GrdSalePerformance.RootTable.Columns(0).Caption = currentyear
            GrdSalePerformance.RootTable.Columns(5).Caption = currentyear

        Catch ex As Exception
        End Try
    End Sub
    Function MyCdec(ByVal ThisValue As String) As Decimal
        Dim Val1 = Val(Trim(ThisValue & ""))
        Dim SignVal As Integer = 0
        Try
            If Val1 < 0 Then
                MyCdec = CDec(ThisValue.Remove(0, 1))
                MyCdec = MyCdec * -1
            Else
                MyCdec = CDec(ThisValue)
            End If
        Catch ex As Exception
            MyCdec = Val(ThisValue)
        End Try
    End Function

    Private Sub MyclsItemno_AfterCalculateSumReceived(ByVal SumParts As Decimal, ByVal Sumfet1 As Decimal, ByVal SumTax As Decimal, ByVal SumTotal As Decimal, ByVal SumTotalQty As Decimal, ByVal SumW As Decimal) Handles MyclsItemno.AfterCalculateSumReceived
        ' LastReceiveAmount.Text = SumTotal 'SumParts + Sumfet1
    End Sub
    Sub CalculateAllLast()
        Dim ds1 As New DataSet
        DaLastServicecenter.SelectCommand.Parameters(0).Value = TxtItem_No.Text & ""
        DaLastServicecenter.Fill(ds1, "t0")
        If ds1.Tables("t0").Rows.Count > 0 Then
            LastSaleDate.Text = ds1.Tables("t0").Rows(0).Item("date1") & ""
            LastSaleAmount.Text = Val(ds1.Tables("t0").Rows(0).Item("lastAmount") & "")
        End If

        DaLastReceive.SelectCommand.Parameters(0).Value = TxtItem_No.Text & ""
        DaLastReceive.Fill(ds1, "t1")
        If ds1.Tables("t1").Rows.Count > 0 Then
            lastrecevieDate.Text = ds1.Tables("t1").Rows(0).Item("date1") & ""
            LastReceiveAmount.Text = Val(ds1.Tables("t1").Rows(0).Item("lastAmount") & "")
        End If

        DALastAdjustment.SelectCommand.Parameters(0).Value = TxtItem_No.Text & ""
        DALastAdjustment.Fill(ds1, "t2")
        If ds1.Tables("t2").Rows.Count > 0 Then
            LastAdjustmentDate.Text = ds1.Tables("t2").Rows(0).Item("date1") & ""
            lastAdjustmentamount.Text = Val(ds1.Tables("t2").Rows(0).Item("lastAmount") & "")
        End If
        ds1.Clear()
    End Sub

    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        Dim rpt As New RepItemDetailShow
        Dim prn As New FrmRepView
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader

        MyZipCode = New UCZipCode.ClsZipCode
        MyZipCode.Connection = Cnn
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        rpt.SetParameterValue("Parconame", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parcoaddress", OleDbReaderForStore.Item("ADDRESS") & "")
        MyZipCode.ZipCode = OleDbReaderForStore.Item("ZipCode")
        MyZipCode.FindDesc(OleDbReaderForStore.Item("ZipCode"))
        rpt.SetParameterValue("Parcoaddress2", MyZipCode.City & " " & MyZipCode.State & " " & MyZipCode.ZipCode & "")
        rpt.SetParameterValue("Parcophone", OleDbReaderForStore.Item("PHONE") & "")
        rpt.SetParameterValue("Parcofax", OleDbReaderForStore.Item("FAX") & "")
        rpt.SetParameterValue("Parcoemail", OleDbReaderForStore.Item("EMAIL") & "")
        rpt.SetParameterValue("x1", "X")
        rpt.SetParameterValue("itemno", TxtItem_No.Text.Trim & "")
        rpt.SetParameterValue("Desc1", Txt_Desc.Text.Trim & "")
        Dim subtotal As Decimal = 0
        Try
            rpt.SetParameterValue("Qty1", Qty1.Text)
            rpt.SetParameterValue("price1", TxtPrice1.Text)
            rpt.SetParameterValue("Ex1", f1(MyCdec(Qty1.Text) * MyCdec(TxtPrice1.Text)))
            rpt.SetParameterValue("tax", Tax1.Text)
            subtotal = subtotal + MyCdec(Qty1.Text) * MyCdec(TxtPrice1.Text)
            If ChkBalance.Checked Then
                rpt.SetParameterValue("Qty2", Qty1.Text)
                rpt.SetParameterValue("price2", TxtBalance.Text)
                rpt.SetParameterValue("Ex2", f1(MyCdec(Qty1.Text) * MyCdec(TxtBalance.Text)))
                rpt.SetParameterValue("x2", "X")
                subtotal = MyCdec(Qty1.Text) * MyCdec(TxtBalance.Text) + subtotal
            Else
                rpt.SetParameterValue("Qty2", 0)
                rpt.SetParameterValue("price2", TxtBalance.Text)
                rpt.SetParameterValue("Ex2", "0.00")
                rpt.SetParameterValue("x2", "")
            End If
            If ChkTireFee.Checked Then
                rpt.SetParameterValue("Qty3", Qty1.Text)
                rpt.SetParameterValue("price3", TxtTireFee.Text)
                rpt.SetParameterValue("Ex3", f1(MyCdec(Qty1.Text) * MyCdec(TxtTireFee.Text)))
                rpt.SetParameterValue("x3", "X")
                subtotal = subtotal + MyCdec(Qty1.Text) * MyCdec(TxtTireFee.Text)
            Else
                rpt.SetParameterValue("Qty3", 0)
                rpt.SetParameterValue("price3", TxtTireFee.Text)
                rpt.SetParameterValue("Ex3", "0.00")
                rpt.SetParameterValue("x3", "")
            End If
            If ChkDisposalFee.Checked Then
                rpt.SetParameterValue("Qty4", Qty1.Text)
                rpt.SetParameterValue("price4", TxtDisposalFee.Text)
                rpt.SetParameterValue("Ex4", f1(MyCdec(Qty1.Text) * MyCdec(TxtDisposalFee.Text)))
                rpt.SetParameterValue("x4", "X")
                subtotal = subtotal + MyCdec(Qty1.Text) * MyCdec(TxtDisposalFee.Text)
            Else
                rpt.SetParameterValue("Qty4", 0)
                rpt.SetParameterValue("price4", TxtDisposalFee.Text)
                rpt.SetParameterValue("Ex4", "0.00")
                rpt.SetParameterValue("x4", "")
            End If
            If ChkValueSteam.Checked Then
                rpt.SetParameterValue("Qty5", Qty1.Text)
                rpt.SetParameterValue("price5", TxtValueStem.Text)
                rpt.SetParameterValue("Ex5", f1(MyCdec(Qty1.Text) * MyCdec(TxtValueStem.Text)))
                rpt.SetParameterValue("x5", "X")
                subtotal = subtotal + MyCdec(Qty1.Text) * MyCdec(TxtValueStem.Text)
            Else
                rpt.SetParameterValue("Qty5", 0)
                rpt.SetParameterValue("price5", TxtValueStem.Text)
                rpt.SetParameterValue("Ex5", "0.00")
                rpt.SetParameterValue("x5", "")
            End If
            If ChkRoadHazard.Checked Then
                rpt.SetParameterValue("Qty6", Qty1.Text)
                rpt.SetParameterValue("price6", TxtRoadHazard.Text)
                rpt.SetParameterValue("Ex6", f1(MyCdec(Qty1.Text) * MyCdec(TxtRoadHazard.Text)))
                rpt.SetParameterValue("x6", "X")
                subtotal = subtotal + MyCdec(Qty1.Text) * MyCdec(TxtRoadHazard.Text)
            Else
                rpt.SetParameterValue("Qty6", 0)
                rpt.SetParameterValue("price6", TxtRoadHazard.Text)
                rpt.SetParameterValue("Ex6", "0.00")
                rpt.SetParameterValue("x6", "")
            End If
            rpt.SetParameterValue("subtotal", subtotal.ToString)
            rpt.SetParameterValue("total", subtotal + MyCdec(Tax1.Text))
            rpt.SetParameterValue("fet1", TxtFet1.Text)
            rpt.SetParameterValue("saleperson", PUserName)
            prn.CrViewer.ReportSource = rpt
            prn.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Function f1(ByVal this1 As Decimal)
        Return this1.ToString
    End Function

End Class
