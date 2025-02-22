Imports CommonClass
Public Class FrmEndOfDay
    Inherits FrmBase
    Public WhereClause As String = ""
    Public WhereCaluseCC1 As String = ""
    Public WhereCaluseCC2 As String = ""
    Public WhereCaluseCC3 As String = ""
    Public WhereCaluseCC4 As String = ""
    Public WhereCaluseCC5 As String = ""
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LblStoreNo As System.Windows.Forms.Label
    Friend WithEvents LblCompanyName As System.Windows.Forms.Label
    Friend WithEvents UiTab1 As Janus.Windows.UI.Tab.UITab
    Friend WithEvents UiTabPage1 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage2 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage3 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage4 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage5 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage6 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPage7 As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Num113 As CalcUtils.UcCalcText
    Friend WithEvents Num112 As CalcUtils.UcCalcText
    Friend WithEvents Num121 As CalcUtils.UcCalcText
    Friend WithEvents Num111 As CalcUtils.UcCalcText
    Friend WithEvents Num116 As CalcUtils.UcCalcText
    Friend WithEvents Num114 As CalcUtils.UcCalcText
    Friend WithEvents Num122 As CalcUtils.UcCalcText
    Friend WithEvents Num196 As CalcUtils.UcCalcText
    Friend WithEvents Num186 As CalcUtils.UcCalcText
    Friend WithEvents Num176 As CalcUtils.UcCalcText
    Friend WithEvents Num194 As CalcUtils.UcCalcText
    Friend WithEvents Num184 As CalcUtils.UcCalcText
    Friend WithEvents Num174 As CalcUtils.UcCalcText
    Friend WithEvents Num193 As CalcUtils.UcCalcText
    Friend WithEvents Num183 As CalcUtils.UcCalcText
    Friend WithEvents Num173 As CalcUtils.UcCalcText
    Friend WithEvents Num192 As CalcUtils.UcCalcText
    Friend WithEvents Num182 As CalcUtils.UcCalcText
    Friend WithEvents Num172 As CalcUtils.UcCalcText
    Friend WithEvents Num181 As CalcUtils.UcCalcText
    Friend WithEvents Num171 As CalcUtils.UcCalcText
    Friend WithEvents Num166 As CalcUtils.UcCalcText
    Friend WithEvents Num156 As CalcUtils.UcCalcText
    Friend WithEvents Num146 As CalcUtils.UcCalcText
    Friend WithEvents Num136 As CalcUtils.UcCalcText
    Friend WithEvents Num126 As CalcUtils.UcCalcText
    Friend WithEvents Num164 As CalcUtils.UcCalcText
    Friend WithEvents Num154 As CalcUtils.UcCalcText
    Friend WithEvents Num144 As CalcUtils.UcCalcText
    Friend WithEvents Num134 As CalcUtils.UcCalcText
    Friend WithEvents Num124 As CalcUtils.UcCalcText
    Friend WithEvents Num163 As CalcUtils.UcCalcText
    Friend WithEvents Num153 As CalcUtils.UcCalcText
    Friend WithEvents Num143 As CalcUtils.UcCalcText
    Friend WithEvents Num133 As CalcUtils.UcCalcText
    Friend WithEvents Num123 As CalcUtils.UcCalcText
    Friend WithEvents Num162 As CalcUtils.UcCalcText
    Friend WithEvents Num152 As CalcUtils.UcCalcText
    Friend WithEvents Num142 As CalcUtils.UcCalcText
    Friend WithEvents Num132 As CalcUtils.UcCalcText
    Friend WithEvents Num161 As CalcUtils.UcCalcText
    Friend WithEvents Num151 As CalcUtils.UcCalcText
    Friend WithEvents Num141 As CalcUtils.UcCalcText
    Friend WithEvents Num131 As CalcUtils.UcCalcText
    Friend WithEvents Num191 As CalcUtils.UcCalcText
    Friend WithEvents NumSalesTax6 As CalcUtils.UcCalcText
    Friend WithEvents NumSalesTax1 As CalcUtils.UcCalcText
    Friend WithEvents NumSalesTax5 As CalcUtils.UcCalcText
    Friend WithEvents NumSalesTax4 As CalcUtils.UcCalcText
    Friend WithEvents NumSalesTax3 As CalcUtils.UcCalcText
    Friend WithEvents NumSalesTax2 As CalcUtils.UcCalcText
    Friend WithEvents Num275 As CalcUtils.UcCalcText
    Friend WithEvents Num274 As CalcUtils.UcCalcText
    Friend WithEvents Num273 As CalcUtils.UcCalcText
    Friend WithEvents Num272 As CalcUtils.UcCalcText
    Friend WithEvents Num245 As CalcUtils.UcCalcText
    Friend WithEvents Num235 As CalcUtils.UcCalcText
    Friend WithEvents Num225 As CalcUtils.UcCalcText
    Friend WithEvents Num215 As CalcUtils.UcCalcText
    Friend WithEvents Num264 As CalcUtils.UcCalcText
    Friend WithEvents Num254 As CalcUtils.UcCalcText
    Friend WithEvents Num244 As CalcUtils.UcCalcText
    Friend WithEvents Num234 As CalcUtils.UcCalcText
    Friend WithEvents Num224 As CalcUtils.UcCalcText
    Friend WithEvents Num214 As CalcUtils.UcCalcText
    Friend WithEvents Num263 As CalcUtils.UcCalcText
    Friend WithEvents Num253 As CalcUtils.UcCalcText
    Friend WithEvents Num243 As CalcUtils.UcCalcText
    Friend WithEvents Num233 As CalcUtils.UcCalcText
    Friend WithEvents Num223 As CalcUtils.UcCalcText
    Friend WithEvents Num213 As CalcUtils.UcCalcText
    Friend WithEvents Num262 As CalcUtils.UcCalcText
    Friend WithEvents Num252 As CalcUtils.UcCalcText
    Friend WithEvents Num242 As CalcUtils.UcCalcText
    Friend WithEvents Num232 As CalcUtils.UcCalcText
    Friend WithEvents Num222 As CalcUtils.UcCalcText
    Friend WithEvents Num212 As CalcUtils.UcCalcText
    Friend WithEvents Num291 As CalcUtils.UcCalcText
    Friend WithEvents Num281 As CalcUtils.UcCalcText
    Friend WithEvents Num271 As CalcUtils.UcCalcText
    Friend WithEvents Num261 As CalcUtils.UcCalcText
    Friend WithEvents Num251 As CalcUtils.UcCalcText
    Friend WithEvents Num241 As CalcUtils.UcCalcText
    Friend WithEvents Num231 As CalcUtils.UcCalcText
    Friend WithEvents Num221 As CalcUtils.UcCalcText
    Friend WithEvents Num211 As CalcUtils.UcCalcText
    Friend WithEvents NumNetChangeToAR As CalcUtils.UcCalcText
    Friend WithEvents NumTotalDebits As CalcUtils.UcCalcText
    Friend WithEvents NumEndingBalance As CalcUtils.UcCalcText
    Friend WithEvents NumReturnsCredits As CalcUtils.UcCalcText
    Friend WithEvents NumNewCharges As CalcUtils.UcCalcText
    Friend WithEvents NumNetAdjustment As CalcUtils.UcCalcText
    Friend WithEvents Num473 As CalcUtils.UcCalcText
    Friend WithEvents Num472 As CalcUtils.UcCalcText
    Friend WithEvents Num471 As CalcUtils.UcCalcText
    Friend WithEvents Num484 As CalcUtils.UcCalcText
    Friend WithEvents Num474 As CalcUtils.UcCalcText
    Friend WithEvents Num464 As CalcUtils.UcCalcText
    Friend WithEvents Num483 As CalcUtils.UcCalcText
    Friend WithEvents Num482 As CalcUtils.UcCalcText
    Friend WithEvents Num463 As CalcUtils.UcCalcText
    Friend WithEvents Num453 As CalcUtils.UcCalcText
    Friend WithEvents Num433 As CalcUtils.UcCalcText
    Friend WithEvents Num423 As CalcUtils.UcCalcText
    Friend WithEvents Num413 As CalcUtils.UcCalcText
    Friend WithEvents Num462 As CalcUtils.UcCalcText
    Friend WithEvents Num452 As CalcUtils.UcCalcText
    Friend WithEvents Num442 As CalcUtils.UcCalcText
    Friend WithEvents Num432 As CalcUtils.UcCalcText
    Friend WithEvents Num422 As CalcUtils.UcCalcText
    Friend WithEvents Num412 As CalcUtils.UcCalcText
    Friend WithEvents Num481 As CalcUtils.UcCalcText
    Friend WithEvents Num461 As CalcUtils.UcCalcText
    Friend WithEvents Num451 As CalcUtils.UcCalcText
    Friend WithEvents Num441 As CalcUtils.UcCalcText
    Friend WithEvents Num431 As CalcUtils.UcCalcText
    Friend WithEvents Num421 As CalcUtils.UcCalcText
    Friend WithEvents Num411 As CalcUtils.UcCalcText
    Friend WithEvents Num542 As CalcUtils.UcCalcText
    Friend WithEvents Num532 As CalcUtils.UcCalcText
    Friend WithEvents Num522 As CalcUtils.UcCalcText
    Friend WithEvents Num512 As CalcUtils.UcCalcText
    Friend WithEvents Num541 As CalcUtils.UcCalcText
    Friend WithEvents Num531 As CalcUtils.UcCalcText
    Friend WithEvents Num521 As CalcUtils.UcCalcText
    Friend WithEvents Num511 As CalcUtils.UcCalcText
    Friend WithEvents Num671 As CalcUtils.UcCalcText
    Friend WithEvents Num661 As CalcUtils.UcCalcText
    Friend WithEvents Num651 As CalcUtils.UcCalcText
    Friend WithEvents Num672 As CalcUtils.UcCalcText
    Friend WithEvents Num662 As CalcUtils.UcCalcText
    Friend WithEvents Num652 As CalcUtils.UcCalcText
    Friend WithEvents Num642 As CalcUtils.UcCalcText
    Friend WithEvents Num632 As CalcUtils.UcCalcText
    Friend WithEvents Num622 As CalcUtils.UcCalcText
    Friend WithEvents Num612 As CalcUtils.UcCalcText
    Friend WithEvents Num641 As CalcUtils.UcCalcText
    Friend WithEvents Num631 As CalcUtils.UcCalcText
    Friend WithEvents Num621 As CalcUtils.UcCalcText
    Friend WithEvents Num611 As CalcUtils.UcCalcText
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Num295 As CalcUtils.UcCalcText
    Friend WithEvents Num285 As CalcUtils.UcCalcText
    Friend WithEvents Num443 As CalcUtils.UcCalcText
    Friend WithEvents NumBeginingBalance As CalcUtils.UcCalcText
    Friend WithEvents NumReceivedOnAccounts As CalcUtils.UcCalcText
    Friend WithEvents NumTotalCredits As CalcUtils.UcCalcText
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents BtnFill As Janus.Windows.EditControls.UIButton
    Friend WithEvents LblCC5 As System.Windows.Forms.Label
    Friend WithEvents LblCC4 As System.Windows.Forms.Label
    Friend WithEvents LblCC3 As System.Windows.Forms.Label
    Friend WithEvents LblCC2 As System.Windows.Forms.Label
    Friend WithEvents CmdGeneralForReader As System.Data.SqlClient.SqlCommand
    Friend WithEvents CnnForReader As System.Data.SqlClient.SqlConnection
    Friend WithEvents DteFromDate As CalendarCombo.CalendarCombo
    Friend WithEvents DteToDate As CalendarCombo.CalendarCombo
    Friend WithEvents LblCC1 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAbas_cc_type As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmEndOfDay1 As UCBankAccount.DSFrmEndOfDay
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnSortOrder As Janus.Windows.EditControls.UIButton
    Friend WithEvents c11 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents UiCommandManager1 As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents TabPrint1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents TabPrint2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents UiContextMenu1 As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents TabPrint3 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents TabPrint4 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents TabPrint5 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents TabPrint6 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents TabPrint7 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents TabPrint8 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents TabPrint11 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents TabPrint21 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents TabPrint31 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents TabPrint41 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents TabPrint51 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents TabPrint61 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents TabPrint71 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents TabPrint81 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents BtnPaymentOnHold As Janus.Windows.EditControls.UIButton
    Friend WithEvents Lbl106 As System.Windows.Forms.Label
    Friend WithEvents Lbl104 As System.Windows.Forms.Label
    Friend WithEvents Lbl103 As System.Windows.Forms.Label
    Friend WithEvents Lbl102 As System.Windows.Forms.Label
    Friend WithEvents Lbl101 As System.Windows.Forms.Label
    Friend WithEvents Lbl114 As System.Windows.Forms.Label
    Friend WithEvents Lbl113 As System.Windows.Forms.Label
    Friend WithEvents Lbl112 As System.Windows.Forms.Label
    Friend WithEvents Lbl111 As System.Windows.Forms.Label
    Friend WithEvents Lbl205 As System.Windows.Forms.Label
    Friend WithEvents Lbl204 As System.Windows.Forms.Label
    Friend WithEvents Lbl203 As System.Windows.Forms.Label
    Friend WithEvents Lbl202 As System.Windows.Forms.Label
    Friend WithEvents Lbl201 As System.Windows.Forms.Label
    Friend WithEvents Lbl219 As System.Windows.Forms.Label
    Friend WithEvents Lbl218 As System.Windows.Forms.Label
    Friend WithEvents Lbl217 As System.Windows.Forms.Label
    Friend WithEvents Lbl216 As System.Windows.Forms.Label
    Friend WithEvents Lbl215 As System.Windows.Forms.Label
    Friend WithEvents Lbl214 As System.Windows.Forms.Label
    Friend WithEvents Lbl213 As System.Windows.Forms.Label
    Friend WithEvents Lbl212 As System.Windows.Forms.Label
    Friend WithEvents Lbl211 As System.Windows.Forms.Label
    Friend WithEvents LblSalesTax6 As System.Windows.Forms.Label
    Friend WithEvents LblSalesTax5 As System.Windows.Forms.Label
    Friend WithEvents LblSalesTax4 As System.Windows.Forms.Label
    Friend WithEvents LblSalesTax3 As System.Windows.Forms.Label
    Friend WithEvents LblSalesTax2 As System.Windows.Forms.Label
    Friend WithEvents LblSalesTax1 As System.Windows.Forms.Label
    Friend WithEvents Lbl165 As System.Windows.Forms.Label
    Friend WithEvents Lbl194 As System.Windows.Forms.Label
    Friend WithEvents Lbl184 As System.Windows.Forms.Label
    Friend WithEvents LblReturnsCredits As System.Windows.Forms.Label
    Friend WithEvents LblReceivedOnAccounts As System.Windows.Forms.Label
    Friend WithEvents LblNetAdjustment As System.Windows.Forms.Label
    Friend WithEvents LblNewCharges As System.Windows.Forms.Label
    Friend WithEvents LblTotalCredits As System.Windows.Forms.Label
    Friend WithEvents LblTotalDebits As System.Windows.Forms.Label
    Friend WithEvents LblEndingBalance As System.Windows.Forms.Label
    Friend WithEvents LblNetChangeToAR As System.Windows.Forms.Label
    Friend WithEvents LblBeginingBalance As System.Windows.Forms.Label
    Friend WithEvents Lbl464 As System.Windows.Forms.Label
    Friend WithEvents Lbl484 As System.Windows.Forms.Label
    Friend WithEvents Lbl474 As System.Windows.Forms.Label
    Friend WithEvents LblInventoryTurnOver As System.Windows.Forms.Label
    Friend WithEvents Lbl403 As System.Windows.Forms.Label
    Friend WithEvents Lbl402 As System.Windows.Forms.Label
    Friend WithEvents Lbl401 As System.Windows.Forms.Label
    Friend WithEvents Lbl418 As System.Windows.Forms.Label
    Friend WithEvents Lbl417 As System.Windows.Forms.Label
    Friend WithEvents Lbl416 As System.Windows.Forms.Label
    Friend WithEvents Lbl415 As System.Windows.Forms.Label
    Friend WithEvents Lbl414 As System.Windows.Forms.Label
    Friend WithEvents Lbl413 As System.Windows.Forms.Label
    Friend WithEvents Lbl412 As System.Windows.Forms.Label
    Friend WithEvents Lbl411 As System.Windows.Forms.Label
    Friend WithEvents Lbl501 As System.Windows.Forms.Label
    Friend WithEvents Lbl502 As System.Windows.Forms.Label
    Friend WithEvents Lbl511 As System.Windows.Forms.Label
    Friend WithEvents Lbl514 As System.Windows.Forms.Label
    Friend WithEvents Lbl513 As System.Windows.Forms.Label
    Friend WithEvents Lbl512 As System.Windows.Forms.Label
    Friend WithEvents Lbl671 As System.Windows.Forms.Label
    Friend WithEvents Lbl661 As System.Windows.Forms.Label
    Friend WithEvents Lbl651 As System.Windows.Forms.Label
    Friend WithEvents Lbl672 As System.Windows.Forms.Label
    Friend WithEvents Lbl662 As System.Windows.Forms.Label
    Friend WithEvents Lbl652 As System.Windows.Forms.Label
    Friend WithEvents Lbl642 As System.Windows.Forms.Label
    Friend WithEvents Lbl632 As System.Windows.Forms.Label
    Friend WithEvents Lbl622 As System.Windows.Forms.Label
    Friend WithEvents Lbl612 As System.Windows.Forms.Label
    Friend WithEvents Lbl602 As System.Windows.Forms.Label
    Friend WithEvents Lbl601 As System.Windows.Forms.Label
    Friend WithEvents Lbl621 As System.Windows.Forms.Label
    Friend WithEvents Lbl611 As System.Windows.Forms.Label
    Friend WithEvents BtnSummaryPrint As Janus.Windows.EditControls.UIButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumBeginingBalances As CalcUtils.UcCalcText
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NumOverPayment As CalcUtils.UcCalcText
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents NumPaidOutCP As CalcUtils.UcCalcText
    Friend WithEvents NumPaidFromOtherStore9 As CalcUtils.UcCalcText
    Friend WithEvents NumPaidFromOtherStore8 As CalcUtils.UcCalcText
    Friend WithEvents NumPaidFromOtherStore7 As CalcUtils.UcCalcText
    Friend WithEvents NumPaidFromOtherStore6 As CalcUtils.UcCalcText
    Friend WithEvents NumPaidFromOtherStore5 As CalcUtils.UcCalcText
    Friend WithEvents NumPaidFromOtherStore4 As CalcUtils.UcCalcText
    Friend WithEvents NumPaidFromOtherStore3 As CalcUtils.UcCalcText
    Friend WithEvents NumPaidFromOtherStore2 As CalcUtils.UcCalcText
    Friend WithEvents NumPaidFromOtherStore1 As CalcUtils.UcCalcText
    Friend WithEvents NumPaidForOtherStore9 As CalcUtils.UcCalcText
    Friend WithEvents NumPaidForOtherStore8 As CalcUtils.UcCalcText
    Friend WithEvents NumPaidForOtherStore7 As CalcUtils.UcCalcText
    Friend WithEvents NumPaidForOtherStore6 As CalcUtils.UcCalcText
    Friend WithEvents NumPaidForOtherStore5 As CalcUtils.UcCalcText
    Friend WithEvents NumPaidForOtherStore4 As CalcUtils.UcCalcText
    Friend WithEvents NumPaidForOtherStore3 As CalcUtils.UcCalcText
    Friend WithEvents NumPaidForOtherStore2 As CalcUtils.UcCalcText
    Friend WithEvents label233 As System.Windows.Forms.Label
    Friend WithEvents NumDownPayment9 As CalcUtils.UcCalcText
    Friend WithEvents NumDownPayment8 As CalcUtils.UcCalcText
    Friend WithEvents NumDownPayment7 As CalcUtils.UcCalcText
    Friend WithEvents NumDownPayment6 As CalcUtils.UcCalcText
    Friend WithEvents NumDownPayment5 As CalcUtils.UcCalcText
    Friend WithEvents NumDownPayment4 As CalcUtils.UcCalcText
    Friend WithEvents NumDownPayment3 As CalcUtils.UcCalcText
    Friend WithEvents NumDownPayment2 As CalcUtils.UcCalcText
    Friend WithEvents NumDownPayment1 As CalcUtils.UcCalcText
    Friend WithEvents NumPaidForOtherStore1 As CalcUtils.UcCalcText
    Friend WithEvents LblPaidOutsCp As System.Windows.Forms.Label
    Friend WithEvents BtnNoChargeInvoice As Janus.Windows.EditControls.UIButton
    Friend WithEvents NumOtherExemptions As CalcUtils.UcCalcText
    Friend WithEvents LblOtherExemptions As System.Windows.Forms.Label
    Friend WithEvents NumDiscounts As CalcUtils.UcCalcText
    Friend WithEvents NumDiscountReturns As CalcUtils.UcCalcText
    Friend WithEvents LblDiscount As System.Windows.Forms.Label
    Friend WithEvents LblReturnDiscount As System.Windows.Forms.Label
    Friend WithEvents LabelDownPayment As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEndOfDay))
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.BtnNoChargeInvoice = New Janus.Windows.EditControls.UIButton
        Me.UiContextMenu1 = New Janus.Windows.UI.CommandBars.UIContextMenu
        Me.UiCommandManager1 = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.TabPrint1 = New Janus.Windows.UI.CommandBars.UICommand("TabPrint1")
        Me.TabPrint2 = New Janus.Windows.UI.CommandBars.UICommand("TabPrint2")
        Me.TabPrint3 = New Janus.Windows.UI.CommandBars.UICommand("TabPrint3")
        Me.TabPrint4 = New Janus.Windows.UI.CommandBars.UICommand("TabPrint4")
        Me.TabPrint5 = New Janus.Windows.UI.CommandBars.UICommand("TabPrint5")
        Me.TabPrint6 = New Janus.Windows.UI.CommandBars.UICommand("TabPrint6")
        Me.TabPrint7 = New Janus.Windows.UI.CommandBars.UICommand("TabPrint7")
        Me.TabPrint8 = New Janus.Windows.UI.CommandBars.UICommand("TabPrint8")
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.BtnSummaryPrint = New Janus.Windows.EditControls.UIButton
        Me.BtnPaymentOnHold = New Janus.Windows.EditControls.UIButton
        Me.BtnSortOrder = New Janus.Windows.EditControls.UIButton
        Me.TabPrint11 = New Janus.Windows.UI.CommandBars.UICommand("TabPrint1")
        Me.TabPrint21 = New Janus.Windows.UI.CommandBars.UICommand("TabPrint2")
        Me.TabPrint31 = New Janus.Windows.UI.CommandBars.UICommand("TabPrint3")
        Me.TabPrint41 = New Janus.Windows.UI.CommandBars.UICommand("TabPrint4")
        Me.TabPrint51 = New Janus.Windows.UI.CommandBars.UICommand("TabPrint5")
        Me.TabPrint61 = New Janus.Windows.UI.CommandBars.UICommand("TabPrint6")
        Me.TabPrint71 = New Janus.Windows.UI.CommandBars.UICommand("TabPrint7")
        Me.TabPrint81 = New Janus.Windows.UI.CommandBars.UICommand("TabPrint8")
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.LblStoreNo = New System.Windows.Forms.Label
        Me.LblCompanyName = New System.Windows.Forms.Label
        Me.UiTab1 = New Janus.Windows.UI.Tab.UITab
        Me.UiTabPage1 = New Janus.Windows.UI.Tab.UITabPage
        Me.NumDownPayment9 = New CalcUtils.UcCalcText
        Me.NumDownPayment8 = New CalcUtils.UcCalcText
        Me.NumDownPayment7 = New CalcUtils.UcCalcText
        Me.NumDownPayment6 = New CalcUtils.UcCalcText
        Me.NumDownPayment5 = New CalcUtils.UcCalcText
        Me.NumDownPayment4 = New CalcUtils.UcCalcText
        Me.NumDownPayment3 = New CalcUtils.UcCalcText
        Me.NumDownPayment2 = New CalcUtils.UcCalcText
        Me.NumDownPayment1 = New CalcUtils.UcCalcText
        Me.LabelDownPayment = New System.Windows.Forms.Label
        Me.NumPaidOutCP = New CalcUtils.UcCalcText
        Me.LblPaidOutsCp = New System.Windows.Forms.Label
        Me.NumPaidFromOtherStore9 = New CalcUtils.UcCalcText
        Me.NumPaidFromOtherStore8 = New CalcUtils.UcCalcText
        Me.NumPaidFromOtherStore7 = New CalcUtils.UcCalcText
        Me.NumPaidFromOtherStore6 = New CalcUtils.UcCalcText
        Me.NumPaidFromOtherStore5 = New CalcUtils.UcCalcText
        Me.NumPaidFromOtherStore4 = New CalcUtils.UcCalcText
        Me.NumPaidFromOtherStore3 = New CalcUtils.UcCalcText
        Me.NumPaidFromOtherStore2 = New CalcUtils.UcCalcText
        Me.NumPaidFromOtherStore1 = New CalcUtils.UcCalcText
        Me.Label6 = New System.Windows.Forms.Label
        Me.Num196 = New CalcUtils.UcCalcText
        Me.Num186 = New CalcUtils.UcCalcText
        Me.Num176 = New CalcUtils.UcCalcText
        Me.NumPaidForOtherStore9 = New CalcUtils.UcCalcText
        Me.NumPaidForOtherStore8 = New CalcUtils.UcCalcText
        Me.NumPaidForOtherStore7 = New CalcUtils.UcCalcText
        Me.Num194 = New CalcUtils.UcCalcText
        Me.Num184 = New CalcUtils.UcCalcText
        Me.Num174 = New CalcUtils.UcCalcText
        Me.Num193 = New CalcUtils.UcCalcText
        Me.Num183 = New CalcUtils.UcCalcText
        Me.Num173 = New CalcUtils.UcCalcText
        Me.Num192 = New CalcUtils.UcCalcText
        Me.Num182 = New CalcUtils.UcCalcText
        Me.Num172 = New CalcUtils.UcCalcText
        Me.Num191 = New CalcUtils.UcCalcText
        Me.Num181 = New CalcUtils.UcCalcText
        Me.Num171 = New CalcUtils.UcCalcText
        Me.LblCC5 = New System.Windows.Forms.Label
        Me.LblCC4 = New System.Windows.Forms.Label
        Me.LblCC3 = New System.Windows.Forms.Label
        Me.Num166 = New CalcUtils.UcCalcText
        Me.Num156 = New CalcUtils.UcCalcText
        Me.Num146 = New CalcUtils.UcCalcText
        Me.Num136 = New CalcUtils.UcCalcText
        Me.Num126 = New CalcUtils.UcCalcText
        Me.Num116 = New CalcUtils.UcCalcText
        Me.NumPaidForOtherStore6 = New CalcUtils.UcCalcText
        Me.NumPaidForOtherStore5 = New CalcUtils.UcCalcText
        Me.NumPaidForOtherStore4 = New CalcUtils.UcCalcText
        Me.NumPaidForOtherStore3 = New CalcUtils.UcCalcText
        Me.NumPaidForOtherStore2 = New CalcUtils.UcCalcText
        Me.NumPaidForOtherStore1 = New CalcUtils.UcCalcText
        Me.Num164 = New CalcUtils.UcCalcText
        Me.Num154 = New CalcUtils.UcCalcText
        Me.Num144 = New CalcUtils.UcCalcText
        Me.Num134 = New CalcUtils.UcCalcText
        Me.Num124 = New CalcUtils.UcCalcText
        Me.Num114 = New CalcUtils.UcCalcText
        Me.Lbl106 = New System.Windows.Forms.Label
        Me.label233 = New System.Windows.Forms.Label
        Me.Lbl104 = New System.Windows.Forms.Label
        Me.Num163 = New CalcUtils.UcCalcText
        Me.Num153 = New CalcUtils.UcCalcText
        Me.Num143 = New CalcUtils.UcCalcText
        Me.Num133 = New CalcUtils.UcCalcText
        Me.Num123 = New CalcUtils.UcCalcText
        Me.Num113 = New CalcUtils.UcCalcText
        Me.Num162 = New CalcUtils.UcCalcText
        Me.Num152 = New CalcUtils.UcCalcText
        Me.Num142 = New CalcUtils.UcCalcText
        Me.Num132 = New CalcUtils.UcCalcText
        Me.Num122 = New CalcUtils.UcCalcText
        Me.Num112 = New CalcUtils.UcCalcText
        Me.Num161 = New CalcUtils.UcCalcText
        Me.Num151 = New CalcUtils.UcCalcText
        Me.Num141 = New CalcUtils.UcCalcText
        Me.Num131 = New CalcUtils.UcCalcText
        Me.Num121 = New CalcUtils.UcCalcText
        Me.Num111 = New CalcUtils.UcCalcText
        Me.Lbl103 = New System.Windows.Forms.Label
        Me.Lbl102 = New System.Windows.Forms.Label
        Me.Lbl101 = New System.Windows.Forms.Label
        Me.LblCC2 = New System.Windows.Forms.Label
        Me.LblCC1 = New System.Windows.Forms.Label
        Me.Lbl114 = New System.Windows.Forms.Label
        Me.Lbl113 = New System.Windows.Forms.Label
        Me.Lbl112 = New System.Windows.Forms.Label
        Me.Lbl111 = New System.Windows.Forms.Label
        Me.UiTabPage2 = New Janus.Windows.UI.Tab.UITabPage
        Me.NumDiscountReturns = New CalcUtils.UcCalcText
        Me.NumDiscounts = New CalcUtils.UcCalcText
        Me.LblDiscount = New System.Windows.Forms.Label
        Me.NumOtherExemptions = New CalcUtils.UcCalcText
        Me.LblOtherExemptions = New System.Windows.Forms.Label
        Me.NumSalesTax6 = New CalcUtils.UcCalcText
        Me.NumSalesTax1 = New CalcUtils.UcCalcText
        Me.NumSalesTax5 = New CalcUtils.UcCalcText
        Me.NumSalesTax4 = New CalcUtils.UcCalcText
        Me.NumSalesTax3 = New CalcUtils.UcCalcText
        Me.NumSalesTax2 = New CalcUtils.UcCalcText
        Me.Num295 = New CalcUtils.UcCalcText
        Me.Num285 = New CalcUtils.UcCalcText
        Me.Num275 = New CalcUtils.UcCalcText
        Me.Num274 = New CalcUtils.UcCalcText
        Me.Num273 = New CalcUtils.UcCalcText
        Me.Num272 = New CalcUtils.UcCalcText
        Me.Num245 = New CalcUtils.UcCalcText
        Me.Num235 = New CalcUtils.UcCalcText
        Me.Num225 = New CalcUtils.UcCalcText
        Me.Num215 = New CalcUtils.UcCalcText
        Me.Num264 = New CalcUtils.UcCalcText
        Me.Num254 = New CalcUtils.UcCalcText
        Me.Num244 = New CalcUtils.UcCalcText
        Me.Num234 = New CalcUtils.UcCalcText
        Me.Num224 = New CalcUtils.UcCalcText
        Me.Num214 = New CalcUtils.UcCalcText
        Me.Num263 = New CalcUtils.UcCalcText
        Me.Num253 = New CalcUtils.UcCalcText
        Me.Num243 = New CalcUtils.UcCalcText
        Me.Num233 = New CalcUtils.UcCalcText
        Me.Num223 = New CalcUtils.UcCalcText
        Me.Num213 = New CalcUtils.UcCalcText
        Me.Num262 = New CalcUtils.UcCalcText
        Me.Num252 = New CalcUtils.UcCalcText
        Me.Num242 = New CalcUtils.UcCalcText
        Me.Num232 = New CalcUtils.UcCalcText
        Me.Num222 = New CalcUtils.UcCalcText
        Me.Num212 = New CalcUtils.UcCalcText
        Me.Num291 = New CalcUtils.UcCalcText
        Me.Num281 = New CalcUtils.UcCalcText
        Me.Num271 = New CalcUtils.UcCalcText
        Me.Num261 = New CalcUtils.UcCalcText
        Me.Num251 = New CalcUtils.UcCalcText
        Me.Num241 = New CalcUtils.UcCalcText
        Me.Num231 = New CalcUtils.UcCalcText
        Me.Num221 = New CalcUtils.UcCalcText
        Me.Num211 = New CalcUtils.UcCalcText
        Me.Lbl194 = New System.Windows.Forms.Label
        Me.Lbl184 = New System.Windows.Forms.Label
        Me.Lbl165 = New System.Windows.Forms.Label
        Me.Lbl205 = New System.Windows.Forms.Label
        Me.Lbl204 = New System.Windows.Forms.Label
        Me.Lbl203 = New System.Windows.Forms.Label
        Me.Lbl202 = New System.Windows.Forms.Label
        Me.Lbl201 = New System.Windows.Forms.Label
        Me.LblSalesTax6 = New System.Windows.Forms.Label
        Me.LblSalesTax5 = New System.Windows.Forms.Label
        Me.LblSalesTax4 = New System.Windows.Forms.Label
        Me.LblSalesTax3 = New System.Windows.Forms.Label
        Me.LblSalesTax2 = New System.Windows.Forms.Label
        Me.LblSalesTax1 = New System.Windows.Forms.Label
        Me.Lbl219 = New System.Windows.Forms.Label
        Me.Lbl218 = New System.Windows.Forms.Label
        Me.Lbl217 = New System.Windows.Forms.Label
        Me.Lbl216 = New System.Windows.Forms.Label
        Me.Lbl215 = New System.Windows.Forms.Label
        Me.Lbl214 = New System.Windows.Forms.Label
        Me.Lbl213 = New System.Windows.Forms.Label
        Me.Lbl212 = New System.Windows.Forms.Label
        Me.Lbl211 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.LblReturnDiscount = New System.Windows.Forms.Label
        Me.UiTabPage3 = New Janus.Windows.UI.Tab.UITabPage
        Me.NumOverPayment = New CalcUtils.UcCalcText
        Me.Label7 = New System.Windows.Forms.Label
        Me.NumBeginingBalances = New CalcUtils.UcCalcText
        Me.Label5 = New System.Windows.Forms.Label
        Me.NumBeginingBalance = New CalcUtils.UcCalcText
        Me.NumNetChangeToAR = New CalcUtils.UcCalcText
        Me.NumTotalDebits = New CalcUtils.UcCalcText
        Me.NumEndingBalance = New CalcUtils.UcCalcText
        Me.NumReceivedOnAccounts = New CalcUtils.UcCalcText
        Me.NumReturnsCredits = New CalcUtils.UcCalcText
        Me.NumNewCharges = New CalcUtils.UcCalcText
        Me.NumTotalCredits = New CalcUtils.UcCalcText
        Me.NumNetAdjustment = New CalcUtils.UcCalcText
        Me.LblReturnsCredits = New System.Windows.Forms.Label
        Me.LblReceivedOnAccounts = New System.Windows.Forms.Label
        Me.LblNetAdjustment = New System.Windows.Forms.Label
        Me.LblNewCharges = New System.Windows.Forms.Label
        Me.LblTotalCredits = New System.Windows.Forms.Label
        Me.LblTotalDebits = New System.Windows.Forms.Label
        Me.LblEndingBalance = New System.Windows.Forms.Label
        Me.LblNetChangeToAR = New System.Windows.Forms.Label
        Me.LblBeginingBalance = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.UiTabPage4 = New Janus.Windows.UI.Tab.UITabPage
        Me.Lbl464 = New System.Windows.Forms.Label
        Me.Num473 = New CalcUtils.UcCalcText
        Me.Num472 = New CalcUtils.UcCalcText
        Me.Num471 = New CalcUtils.UcCalcText
        Me.Num484 = New CalcUtils.UcCalcText
        Me.Num474 = New CalcUtils.UcCalcText
        Me.Num464 = New CalcUtils.UcCalcText
        Me.Num483 = New CalcUtils.UcCalcText
        Me.Num482 = New CalcUtils.UcCalcText
        Me.Num463 = New CalcUtils.UcCalcText
        Me.Num453 = New CalcUtils.UcCalcText
        Me.Num443 = New CalcUtils.UcCalcText
        Me.Num433 = New CalcUtils.UcCalcText
        Me.Num423 = New CalcUtils.UcCalcText
        Me.Num413 = New CalcUtils.UcCalcText
        Me.Num462 = New CalcUtils.UcCalcText
        Me.Num452 = New CalcUtils.UcCalcText
        Me.Num442 = New CalcUtils.UcCalcText
        Me.Num432 = New CalcUtils.UcCalcText
        Me.Num422 = New CalcUtils.UcCalcText
        Me.Num412 = New CalcUtils.UcCalcText
        Me.Num481 = New CalcUtils.UcCalcText
        Me.Num461 = New CalcUtils.UcCalcText
        Me.Num451 = New CalcUtils.UcCalcText
        Me.Num441 = New CalcUtils.UcCalcText
        Me.Num431 = New CalcUtils.UcCalcText
        Me.Num421 = New CalcUtils.UcCalcText
        Me.Num411 = New CalcUtils.UcCalcText
        Me.Lbl484 = New System.Windows.Forms.Label
        Me.Lbl474 = New System.Windows.Forms.Label
        Me.LblInventoryTurnOver = New System.Windows.Forms.Label
        Me.Lbl403 = New System.Windows.Forms.Label
        Me.Lbl402 = New System.Windows.Forms.Label
        Me.Lbl401 = New System.Windows.Forms.Label
        Me.Lbl418 = New System.Windows.Forms.Label
        Me.Lbl417 = New System.Windows.Forms.Label
        Me.Lbl416 = New System.Windows.Forms.Label
        Me.Lbl415 = New System.Windows.Forms.Label
        Me.Lbl414 = New System.Windows.Forms.Label
        Me.Lbl413 = New System.Windows.Forms.Label
        Me.Lbl412 = New System.Windows.Forms.Label
        Me.Lbl411 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.UiTabPage5 = New Janus.Windows.UI.Tab.UITabPage
        Me.Num542 = New CalcUtils.UcCalcText
        Me.Num532 = New CalcUtils.UcCalcText
        Me.Num522 = New CalcUtils.UcCalcText
        Me.Num512 = New CalcUtils.UcCalcText
        Me.Num541 = New CalcUtils.UcCalcText
        Me.Num531 = New CalcUtils.UcCalcText
        Me.Num521 = New CalcUtils.UcCalcText
        Me.Num511 = New CalcUtils.UcCalcText
        Me.Lbl502 = New System.Windows.Forms.Label
        Me.Lbl501 = New System.Windows.Forms.Label
        Me.Lbl514 = New System.Windows.Forms.Label
        Me.Lbl513 = New System.Windows.Forms.Label
        Me.Lbl512 = New System.Windows.Forms.Label
        Me.Lbl511 = New System.Windows.Forms.Label
        Me.UiTabPage6 = New Janus.Windows.UI.Tab.UITabPage
        Me.Lbl671 = New System.Windows.Forms.Label
        Me.Num671 = New CalcUtils.UcCalcText
        Me.Lbl661 = New System.Windows.Forms.Label
        Me.Lbl651 = New System.Windows.Forms.Label
        Me.Num661 = New CalcUtils.UcCalcText
        Me.Num651 = New CalcUtils.UcCalcText
        Me.Lbl672 = New System.Windows.Forms.Label
        Me.Num672 = New CalcUtils.UcCalcText
        Me.Lbl662 = New System.Windows.Forms.Label
        Me.Lbl652 = New System.Windows.Forms.Label
        Me.Num662 = New CalcUtils.UcCalcText
        Me.Num652 = New CalcUtils.UcCalcText
        Me.Lbl642 = New System.Windows.Forms.Label
        Me.Lbl632 = New System.Windows.Forms.Label
        Me.Lbl622 = New System.Windows.Forms.Label
        Me.Lbl612 = New System.Windows.Forms.Label
        Me.Lbl602 = New System.Windows.Forms.Label
        Me.Lbl601 = New System.Windows.Forms.Label
        Me.Num642 = New CalcUtils.UcCalcText
        Me.Num632 = New CalcUtils.UcCalcText
        Me.Num622 = New CalcUtils.UcCalcText
        Me.Num612 = New CalcUtils.UcCalcText
        Me.Num641 = New CalcUtils.UcCalcText
        Me.Num631 = New CalcUtils.UcCalcText
        Me.Num621 = New CalcUtils.UcCalcText
        Me.Num611 = New CalcUtils.UcCalcText
        Me.Lbl621 = New System.Windows.Forms.Label
        Me.Lbl611 = New System.Windows.Forms.Label
        Me.UiTabPage7 = New Janus.Windows.UI.Tab.UITabPage
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.BtnFill = New Janus.Windows.EditControls.UIButton
        Me.CmdGeneralForReader = New System.Data.SqlClient.SqlCommand
        Me.CnnForReader = New System.Data.SqlClient.SqlConnection
        Me.DteFromDate = New CalendarCombo.CalendarCombo
        Me.DteToDate = New CalendarCombo.CalendarCombo
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAbas_cc_type = New System.Data.SqlClient.SqlDataAdapter
        Me.DsFrmEndOfDay1 = New UCBankAccount.DSFrmEndOfDay
        Me.c11 = New Janus.Windows.UI.CommandBars.UICommand("c1")
        Me.Panel4.SuspendLayout()
        CType(Me.UiContextMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1.EditContextMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTab1.SuspendLayout()
        Me.UiTabPage1.SuspendLayout()
        Me.UiTabPage2.SuspendLayout()
        Me.UiTabPage3.SuspendLayout()
        Me.UiTabPage4.SuspendLayout()
        Me.UiTabPage5.SuspendLayout()
        Me.UiTabPage6.SuspendLayout()
        CType(Me.DsFrmEndOfDay1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.BtnNoChargeInvoice)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.BtnSummaryPrint)
        Me.Panel4.Controls.Add(Me.BtnPaymentOnHold)
        Me.Panel4.Controls.Add(Me.BtnSortOrder)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(686, 45)
        Me.Panel4.TabIndex = 3
        '
        'BtnNoChargeInvoice
        '
        Me.BtnNoChargeInvoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNoChargeInvoice.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button
        Me.UiCommandManager1.SetContextMenu(Me.BtnNoChargeInvoice, Me.UiContextMenu1)
        Me.BtnNoChargeInvoice.DropDownContextMenu = Me.UiContextMenu1
        Me.BtnNoChargeInvoice.ImageSize = New System.Drawing.Size(24, 24)
        Me.BtnNoChargeInvoice.Location = New System.Drawing.Point(246, 1)
        Me.BtnNoChargeInvoice.Name = "BtnNoChargeInvoice"
        Me.BtnNoChargeInvoice.Size = New System.Drawing.Size(103, 27)
        Me.BtnNoChargeInvoice.TabIndex = 221
        Me.BtnNoChargeInvoice.Text = "No Charge Invoice"
        '
        'UiContextMenu1
        '
        Me.UiContextMenu1.CommandManager = Me.UiCommandManager1
        Me.UiContextMenu1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.TabPrint11, Me.TabPrint21, Me.TabPrint31, Me.TabPrint41, Me.TabPrint51, Me.TabPrint61, Me.TabPrint71, Me.TabPrint81})
        Me.UiContextMenu1.Key = "ContextMenu1"
        Me.UiContextMenu1.UseThemes = Janus.Windows.UI.InheritableBoolean.True
        Me.UiContextMenu1.VisualStyle = Janus.Windows.UI.VisualStyle.Standard
        '
        'UiCommandManager1
        '
        Me.UiCommandManager1.BottomRebar = Me.BottomRebar1
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.TabPrint1, Me.TabPrint2, Me.TabPrint3, Me.TabPrint4, Me.TabPrint5, Me.TabPrint6, Me.TabPrint7, Me.TabPrint8})
        Me.UiCommandManager1.ContainerControl = Me
        Me.UiCommandManager1.ContextMenus.AddRange(New Janus.Windows.UI.CommandBars.UIContextMenu() {Me.UiContextMenu1})
        Me.UiCommandManager1.Id = New System.Guid("dc09c95d-e242-4d33-b424-f8f128f3cd65")
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
        'TabPrint1
        '
        Me.TabPrint1.Key = "TabPrint1"
        Me.TabPrint1.Name = "TabPrint1"
        Me.TabPrint1.Text = "Cash Report"
        '
        'TabPrint2
        '
        Me.TabPrint2.Key = "TabPrint2"
        Me.TabPrint2.Name = "TabPrint2"
        Me.TabPrint2.Text = "Sales Report"
        '
        'TabPrint3
        '
        Me.TabPrint3.Key = "TabPrint3"
        Me.TabPrint3.Name = "TabPrint3"
        Me.TabPrint3.Text = "AR Report"
        '
        'TabPrint4
        '
        Me.TabPrint4.Key = "TabPrint4"
        Me.TabPrint4.Name = "TabPrint4"
        Me.TabPrint4.Text = "Products Report"
        '
        'TabPrint5
        '
        Me.TabPrint5.Key = "TabPrint5"
        Me.TabPrint5.Name = "TabPrint5"
        Me.TabPrint5.Text = "Outside Purchases Report"
        '
        'TabPrint6
        '
        Me.TabPrint6.Key = "TabPrint6"
        Me.TabPrint6.Name = "TabPrint6"
        Me.TabPrint6.Text = "Services Report"
        '
        'TabPrint7
        '
        Me.TabPrint7.Key = "TabPrint7"
        Me.TabPrint7.Name = "TabPrint7"
        Me.TabPrint7.Text = "Banking Report"
        '
        'TabPrint8
        '
        Me.TabPrint8.Key = "TabPrint8"
        Me.TabPrint8.Name = "TabPrint8"
        Me.TabPrint8.Text = "GL Report"
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
        'BtnSummaryPrint
        '
        Me.BtnSummaryPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSummaryPrint.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button
        Me.UiCommandManager1.SetContextMenu(Me.BtnSummaryPrint, Me.UiContextMenu1)
        Me.BtnSummaryPrint.DropDownContextMenu = Me.UiContextMenu1
        Me.BtnSummaryPrint.Image = CType(resources.GetObject("BtnSummaryPrint.Image"), System.Drawing.Image)
        Me.BtnSummaryPrint.ImageSize = New System.Drawing.Size(24, 24)
        Me.BtnSummaryPrint.Location = New System.Drawing.Point(510, 1)
        Me.BtnSummaryPrint.Name = "BtnSummaryPrint"
        Me.BtnSummaryPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnSummaryPrint.TabIndex = 219
        '
        'BtnPaymentOnHold
        '
        Me.BtnPaymentOnHold.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPaymentOnHold.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button
        Me.UiCommandManager1.SetContextMenu(Me.BtnPaymentOnHold, Me.UiContextMenu1)
        Me.BtnPaymentOnHold.DropDownContextMenu = Me.UiContextMenu1
        Me.BtnPaymentOnHold.ImageSize = New System.Drawing.Size(24, 24)
        Me.BtnPaymentOnHold.Location = New System.Drawing.Point(360, 1)
        Me.BtnPaymentOnHold.Name = "BtnPaymentOnHold"
        Me.BtnPaymentOnHold.Size = New System.Drawing.Size(103, 27)
        Me.BtnPaymentOnHold.TabIndex = 218
        Me.BtnPaymentOnHold.Text = "Payment On Hold"
        '
        'BtnSortOrder
        '
        Me.BtnSortOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSortOrder.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.DropDownButton
        Me.UiCommandManager1.SetContextMenu(Me.BtnSortOrder, Me.UiContextMenu1)
        Me.BtnSortOrder.DropDownContextMenu = Me.UiContextMenu1
        Me.BtnSortOrder.Image = CType(resources.GetObject("BtnSortOrder.Image"), System.Drawing.Image)
        Me.BtnSortOrder.ImageSize = New System.Drawing.Size(24, 24)
        Me.BtnSortOrder.Location = New System.Drawing.Point(601, 1)
        Me.BtnSortOrder.Name = "BtnSortOrder"
        Me.BtnSortOrder.Size = New System.Drawing.Size(49, 27)
        Me.BtnSortOrder.TabIndex = 217
        '
        'TabPrint11
        '
        Me.TabPrint11.Key = "TabPrint1"
        Me.TabPrint11.Name = "TabPrint11"
        '
        'TabPrint21
        '
        Me.TabPrint21.Key = "TabPrint2"
        Me.TabPrint21.Name = "TabPrint21"
        '
        'TabPrint31
        '
        Me.TabPrint31.Key = "TabPrint3"
        Me.TabPrint31.Name = "TabPrint31"
        '
        'TabPrint41
        '
        Me.TabPrint41.Key = "TabPrint4"
        Me.TabPrint41.Name = "TabPrint41"
        '
        'TabPrint51
        '
        Me.TabPrint51.Key = "TabPrint5"
        Me.TabPrint51.Name = "TabPrint51"
        '
        'TabPrint61
        '
        Me.TabPrint61.Key = "TabPrint6"
        Me.TabPrint61.Name = "TabPrint61"
        '
        'TabPrint71
        '
        Me.TabPrint71.Key = "TabPrint7"
        Me.TabPrint71.Name = "TabPrint71"
        '
        'TabPrint81
        '
        Me.TabPrint81.Key = "TabPrint8"
        Me.TabPrint81.Name = "TabPrint81"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(484, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 220
        Me.Label4.Text = "Summary Print"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(591, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 10)
        Me.Label3.TabIndex = 216
        Me.Label3.Text = "Detail Print"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(64, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 43)
        Me.Label1.TabIndex = 207
        Me.Label1.Text = "Store Sales Audit Summary"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 208
        Me.PictureBox2.TabStop = False
        '
        'LblStoreNo
        '
        Me.LblStoreNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblStoreNo.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblStoreNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblStoreNo.Location = New System.Drawing.Point(581, 46)
        Me.LblStoreNo.Name = "LblStoreNo"
        Me.LblStoreNo.Size = New System.Drawing.Size(101, 25)
        Me.LblStoreNo.TabIndex = 127
        Me.LblStoreNo.Text = "LblStoreNo"
        Me.LblStoreNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCompanyName
        '
        Me.LblCompanyName.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCompanyName.Location = New System.Drawing.Point(4, 46)
        Me.LblCompanyName.Name = "LblCompanyName"
        Me.LblCompanyName.Size = New System.Drawing.Size(147, 25)
        Me.LblCompanyName.TabIndex = 126
        Me.LblCompanyName.Text = "LblCompanyName"
        Me.LblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UiTab1
        '
        Me.UiTab1.Controls.Add(Me.UiTabPage1)
        Me.UiTab1.Controls.Add(Me.UiTabPage2)
        Me.UiTab1.Controls.Add(Me.UiTabPage3)
        Me.UiTab1.Controls.Add(Me.UiTabPage4)
        Me.UiTab1.Controls.Add(Me.UiTabPage5)
        Me.UiTab1.Controls.Add(Me.UiTabPage6)
        Me.UiTab1.Controls.Add(Me.UiTabPage7)
        Me.UiTab1.Location = New System.Drawing.Point(0, 75)
        Me.UiTab1.Name = "UiTab1"
        Me.UiTab1.SelectedIndex = 0
        Me.UiTab1.Size = New System.Drawing.Size(688, 322)
        Me.UiTab1.TabIndex = 3
        Me.UiTab1.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPage1, Me.UiTabPage2, Me.UiTabPage3, Me.UiTabPage4, Me.UiTabPage5, Me.UiTabPage6, Me.UiTabPage7})
        Me.UiTab1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Normal
        '
        'UiTabPage1
        '
        Me.UiTabPage1.Controls.Add(Me.NumDownPayment9)
        Me.UiTabPage1.Controls.Add(Me.NumDownPayment8)
        Me.UiTabPage1.Controls.Add(Me.NumDownPayment7)
        Me.UiTabPage1.Controls.Add(Me.NumDownPayment6)
        Me.UiTabPage1.Controls.Add(Me.NumDownPayment5)
        Me.UiTabPage1.Controls.Add(Me.NumDownPayment4)
        Me.UiTabPage1.Controls.Add(Me.NumDownPayment3)
        Me.UiTabPage1.Controls.Add(Me.NumDownPayment2)
        Me.UiTabPage1.Controls.Add(Me.NumDownPayment1)
        Me.UiTabPage1.Controls.Add(Me.LabelDownPayment)
        Me.UiTabPage1.Controls.Add(Me.NumPaidOutCP)
        Me.UiTabPage1.Controls.Add(Me.LblPaidOutsCp)
        Me.UiTabPage1.Controls.Add(Me.NumPaidFromOtherStore9)
        Me.UiTabPage1.Controls.Add(Me.NumPaidFromOtherStore8)
        Me.UiTabPage1.Controls.Add(Me.NumPaidFromOtherStore7)
        Me.UiTabPage1.Controls.Add(Me.NumPaidFromOtherStore6)
        Me.UiTabPage1.Controls.Add(Me.NumPaidFromOtherStore5)
        Me.UiTabPage1.Controls.Add(Me.NumPaidFromOtherStore4)
        Me.UiTabPage1.Controls.Add(Me.NumPaidFromOtherStore3)
        Me.UiTabPage1.Controls.Add(Me.NumPaidFromOtherStore2)
        Me.UiTabPage1.Controls.Add(Me.NumPaidFromOtherStore1)
        Me.UiTabPage1.Controls.Add(Me.Label6)
        Me.UiTabPage1.Controls.Add(Me.Num196)
        Me.UiTabPage1.Controls.Add(Me.Num186)
        Me.UiTabPage1.Controls.Add(Me.Num176)
        Me.UiTabPage1.Controls.Add(Me.NumPaidForOtherStore9)
        Me.UiTabPage1.Controls.Add(Me.NumPaidForOtherStore8)
        Me.UiTabPage1.Controls.Add(Me.NumPaidForOtherStore7)
        Me.UiTabPage1.Controls.Add(Me.Num194)
        Me.UiTabPage1.Controls.Add(Me.Num184)
        Me.UiTabPage1.Controls.Add(Me.Num174)
        Me.UiTabPage1.Controls.Add(Me.Num193)
        Me.UiTabPage1.Controls.Add(Me.Num183)
        Me.UiTabPage1.Controls.Add(Me.Num173)
        Me.UiTabPage1.Controls.Add(Me.Num192)
        Me.UiTabPage1.Controls.Add(Me.Num182)
        Me.UiTabPage1.Controls.Add(Me.Num172)
        Me.UiTabPage1.Controls.Add(Me.Num191)
        Me.UiTabPage1.Controls.Add(Me.Num181)
        Me.UiTabPage1.Controls.Add(Me.Num171)
        Me.UiTabPage1.Controls.Add(Me.LblCC5)
        Me.UiTabPage1.Controls.Add(Me.LblCC4)
        Me.UiTabPage1.Controls.Add(Me.LblCC3)
        Me.UiTabPage1.Controls.Add(Me.Num166)
        Me.UiTabPage1.Controls.Add(Me.Num156)
        Me.UiTabPage1.Controls.Add(Me.Num146)
        Me.UiTabPage1.Controls.Add(Me.Num136)
        Me.UiTabPage1.Controls.Add(Me.Num126)
        Me.UiTabPage1.Controls.Add(Me.Num116)
        Me.UiTabPage1.Controls.Add(Me.NumPaidForOtherStore6)
        Me.UiTabPage1.Controls.Add(Me.NumPaidForOtherStore5)
        Me.UiTabPage1.Controls.Add(Me.NumPaidForOtherStore4)
        Me.UiTabPage1.Controls.Add(Me.NumPaidForOtherStore3)
        Me.UiTabPage1.Controls.Add(Me.NumPaidForOtherStore2)
        Me.UiTabPage1.Controls.Add(Me.NumPaidForOtherStore1)
        Me.UiTabPage1.Controls.Add(Me.Num164)
        Me.UiTabPage1.Controls.Add(Me.Num154)
        Me.UiTabPage1.Controls.Add(Me.Num144)
        Me.UiTabPage1.Controls.Add(Me.Num134)
        Me.UiTabPage1.Controls.Add(Me.Num124)
        Me.UiTabPage1.Controls.Add(Me.Num114)
        Me.UiTabPage1.Controls.Add(Me.Lbl106)
        Me.UiTabPage1.Controls.Add(Me.label233)
        Me.UiTabPage1.Controls.Add(Me.Lbl104)
        Me.UiTabPage1.Controls.Add(Me.Num163)
        Me.UiTabPage1.Controls.Add(Me.Num153)
        Me.UiTabPage1.Controls.Add(Me.Num143)
        Me.UiTabPage1.Controls.Add(Me.Num133)
        Me.UiTabPage1.Controls.Add(Me.Num123)
        Me.UiTabPage1.Controls.Add(Me.Num113)
        Me.UiTabPage1.Controls.Add(Me.Num162)
        Me.UiTabPage1.Controls.Add(Me.Num152)
        Me.UiTabPage1.Controls.Add(Me.Num142)
        Me.UiTabPage1.Controls.Add(Me.Num132)
        Me.UiTabPage1.Controls.Add(Me.Num122)
        Me.UiTabPage1.Controls.Add(Me.Num112)
        Me.UiTabPage1.Controls.Add(Me.Num161)
        Me.UiTabPage1.Controls.Add(Me.Num151)
        Me.UiTabPage1.Controls.Add(Me.Num141)
        Me.UiTabPage1.Controls.Add(Me.Num131)
        Me.UiTabPage1.Controls.Add(Me.Num121)
        Me.UiTabPage1.Controls.Add(Me.Num111)
        Me.UiTabPage1.Controls.Add(Me.Lbl103)
        Me.UiTabPage1.Controls.Add(Me.Lbl102)
        Me.UiTabPage1.Controls.Add(Me.Lbl101)
        Me.UiTabPage1.Controls.Add(Me.LblCC2)
        Me.UiTabPage1.Controls.Add(Me.LblCC1)
        Me.UiTabPage1.Controls.Add(Me.Lbl114)
        Me.UiTabPage1.Controls.Add(Me.Lbl113)
        Me.UiTabPage1.Controls.Add(Me.Lbl112)
        Me.UiTabPage1.Controls.Add(Me.Lbl111)
        Me.UiTabPage1.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage1.Name = "UiTabPage1"
        Me.UiTabPage1.Size = New System.Drawing.Size(684, 298)
        Me.UiTabPage1.TabIndex = 0
        Me.UiTabPage1.Text = "Cash"
        '
        'NumDownPayment9
        '
        Me.NumDownPayment9.BackColor = System.Drawing.SystemColors.Control
        Me.NumDownPayment9.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDownPayment9.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumDownPayment9.DecimalDigits = 2
        Me.NumDownPayment9.DefaultSendValue = False
        Me.NumDownPayment9.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDownPayment9.FireTabAfterEnter = True
        Me.NumDownPayment9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumDownPayment9.Image = CType(resources.GetObject("NumDownPayment9.Image"), System.Drawing.Image)
        Me.NumDownPayment9.Location = New System.Drawing.Point(533, 238)
        Me.NumDownPayment9.Maxlength = 10
        Me.NumDownPayment9.MinusColor = System.Drawing.Color.Empty
        Me.NumDownPayment9.Name = "NumDownPayment9"
        Me.NumDownPayment9.ReadOnly = True
        Me.NumDownPayment9.Size = New System.Drawing.Size(74, 21)
        Me.NumDownPayment9.TabIndex = 137
        Me.NumDownPayment9.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDownPayment9.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumDownPayment8
        '
        Me.NumDownPayment8.BackColor = System.Drawing.SystemColors.Control
        Me.NumDownPayment8.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDownPayment8.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumDownPayment8.DecimalDigits = 2
        Me.NumDownPayment8.DefaultSendValue = False
        Me.NumDownPayment8.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDownPayment8.FireTabAfterEnter = True
        Me.NumDownPayment8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumDownPayment8.Image = CType(resources.GetObject("NumDownPayment8.Image"), System.Drawing.Image)
        Me.NumDownPayment8.Location = New System.Drawing.Point(533, 213)
        Me.NumDownPayment8.Maxlength = 10
        Me.NumDownPayment8.MinusColor = System.Drawing.Color.Empty
        Me.NumDownPayment8.Name = "NumDownPayment8"
        Me.NumDownPayment8.ReadOnly = True
        Me.NumDownPayment8.Size = New System.Drawing.Size(74, 21)
        Me.NumDownPayment8.TabIndex = 136
        Me.NumDownPayment8.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDownPayment8.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumDownPayment7
        '
        Me.NumDownPayment7.BackColor = System.Drawing.SystemColors.Control
        Me.NumDownPayment7.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDownPayment7.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumDownPayment7.DecimalDigits = 2
        Me.NumDownPayment7.DefaultSendValue = False
        Me.NumDownPayment7.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDownPayment7.FireTabAfterEnter = True
        Me.NumDownPayment7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumDownPayment7.Image = CType(resources.GetObject("NumDownPayment7.Image"), System.Drawing.Image)
        Me.NumDownPayment7.Location = New System.Drawing.Point(533, 188)
        Me.NumDownPayment7.Maxlength = 10
        Me.NumDownPayment7.MinusColor = System.Drawing.Color.Empty
        Me.NumDownPayment7.Name = "NumDownPayment7"
        Me.NumDownPayment7.ReadOnly = True
        Me.NumDownPayment7.Size = New System.Drawing.Size(74, 21)
        Me.NumDownPayment7.TabIndex = 135
        Me.NumDownPayment7.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDownPayment7.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumDownPayment6
        '
        Me.NumDownPayment6.BackColor = System.Drawing.SystemColors.Control
        Me.NumDownPayment6.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDownPayment6.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumDownPayment6.DecimalDigits = 2
        Me.NumDownPayment6.DefaultSendValue = False
        Me.NumDownPayment6.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDownPayment6.FireTabAfterEnter = True
        Me.NumDownPayment6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumDownPayment6.Image = CType(resources.GetObject("NumDownPayment6.Image"), System.Drawing.Image)
        Me.NumDownPayment6.Location = New System.Drawing.Point(533, 163)
        Me.NumDownPayment6.Maxlength = 10
        Me.NumDownPayment6.MinusColor = System.Drawing.Color.Empty
        Me.NumDownPayment6.Name = "NumDownPayment6"
        Me.NumDownPayment6.ReadOnly = True
        Me.NumDownPayment6.Size = New System.Drawing.Size(74, 21)
        Me.NumDownPayment6.TabIndex = 134
        Me.NumDownPayment6.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDownPayment6.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumDownPayment5
        '
        Me.NumDownPayment5.BackColor = System.Drawing.SystemColors.Control
        Me.NumDownPayment5.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDownPayment5.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumDownPayment5.DecimalDigits = 2
        Me.NumDownPayment5.DefaultSendValue = False
        Me.NumDownPayment5.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDownPayment5.FireTabAfterEnter = True
        Me.NumDownPayment5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumDownPayment5.Image = CType(resources.GetObject("NumDownPayment5.Image"), System.Drawing.Image)
        Me.NumDownPayment5.Location = New System.Drawing.Point(533, 138)
        Me.NumDownPayment5.Maxlength = 10
        Me.NumDownPayment5.MinusColor = System.Drawing.Color.Empty
        Me.NumDownPayment5.Name = "NumDownPayment5"
        Me.NumDownPayment5.ReadOnly = True
        Me.NumDownPayment5.Size = New System.Drawing.Size(74, 21)
        Me.NumDownPayment5.TabIndex = 133
        Me.NumDownPayment5.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDownPayment5.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumDownPayment4
        '
        Me.NumDownPayment4.BackColor = System.Drawing.Color.Gold
        Me.NumDownPayment4.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDownPayment4.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumDownPayment4.DecimalDigits = 2
        Me.NumDownPayment4.DefaultSendValue = False
        Me.NumDownPayment4.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDownPayment4.FireTabAfterEnter = True
        Me.NumDownPayment4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumDownPayment4.Image = CType(resources.GetObject("NumDownPayment4.Image"), System.Drawing.Image)
        Me.NumDownPayment4.Location = New System.Drawing.Point(533, 113)
        Me.NumDownPayment4.Maxlength = 10
        Me.NumDownPayment4.MinusColor = System.Drawing.Color.Empty
        Me.NumDownPayment4.Name = "NumDownPayment4"
        Me.NumDownPayment4.ReadOnly = True
        Me.NumDownPayment4.Size = New System.Drawing.Size(74, 21)
        Me.NumDownPayment4.TabIndex = 132
        Me.NumDownPayment4.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDownPayment4.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumDownPayment3
        '
        Me.NumDownPayment3.BackColor = System.Drawing.SystemColors.Control
        Me.NumDownPayment3.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDownPayment3.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumDownPayment3.DecimalDigits = 2
        Me.NumDownPayment3.DefaultSendValue = False
        Me.NumDownPayment3.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDownPayment3.FireTabAfterEnter = True
        Me.NumDownPayment3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumDownPayment3.Image = CType(resources.GetObject("NumDownPayment3.Image"), System.Drawing.Image)
        Me.NumDownPayment3.Location = New System.Drawing.Point(533, 88)
        Me.NumDownPayment3.Maxlength = 10
        Me.NumDownPayment3.MinusColor = System.Drawing.Color.Empty
        Me.NumDownPayment3.Name = "NumDownPayment3"
        Me.NumDownPayment3.ReadOnly = True
        Me.NumDownPayment3.Size = New System.Drawing.Size(74, 21)
        Me.NumDownPayment3.TabIndex = 131
        Me.NumDownPayment3.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDownPayment3.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumDownPayment2
        '
        Me.NumDownPayment2.BackColor = System.Drawing.SystemColors.Control
        Me.NumDownPayment2.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDownPayment2.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumDownPayment2.DecimalDigits = 2
        Me.NumDownPayment2.DefaultSendValue = False
        Me.NumDownPayment2.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDownPayment2.FireTabAfterEnter = True
        Me.NumDownPayment2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumDownPayment2.Image = CType(resources.GetObject("NumDownPayment2.Image"), System.Drawing.Image)
        Me.NumDownPayment2.Location = New System.Drawing.Point(533, 63)
        Me.NumDownPayment2.Maxlength = 10
        Me.NumDownPayment2.MinusColor = System.Drawing.Color.Empty
        Me.NumDownPayment2.Name = "NumDownPayment2"
        Me.NumDownPayment2.ReadOnly = True
        Me.NumDownPayment2.Size = New System.Drawing.Size(74, 21)
        Me.NumDownPayment2.TabIndex = 130
        Me.NumDownPayment2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDownPayment2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumDownPayment1
        '
        Me.NumDownPayment1.BackColor = System.Drawing.SystemColors.Control
        Me.NumDownPayment1.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDownPayment1.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumDownPayment1.DecimalDigits = 2
        Me.NumDownPayment1.DefaultSendValue = False
        Me.NumDownPayment1.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDownPayment1.FireTabAfterEnter = True
        Me.NumDownPayment1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumDownPayment1.Image = CType(resources.GetObject("NumDownPayment1.Image"), System.Drawing.Image)
        Me.NumDownPayment1.Location = New System.Drawing.Point(533, 38)
        Me.NumDownPayment1.Maxlength = 10
        Me.NumDownPayment1.MinusColor = System.Drawing.Color.Empty
        Me.NumDownPayment1.Name = "NumDownPayment1"
        Me.NumDownPayment1.ReadOnly = True
        Me.NumDownPayment1.Size = New System.Drawing.Size(74, 21)
        Me.NumDownPayment1.TabIndex = 129
        Me.NumDownPayment1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDownPayment1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LabelDownPayment
        '
        Me.LabelDownPayment.BackColor = System.Drawing.SystemColors.Control
        Me.LabelDownPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelDownPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDownPayment.Location = New System.Drawing.Point(533, 8)
        Me.LabelDownPayment.Name = "LabelDownPayment"
        Me.LabelDownPayment.Size = New System.Drawing.Size(74, 29)
        Me.LabelDownPayment.TabIndex = 128
        Me.LabelDownPayment.Text = "Down Payment"
        Me.LabelDownPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumPaidOutCP
        '
        Me.NumPaidOutCP.BackColor = System.Drawing.SystemColors.Control
        Me.NumPaidOutCP.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPaidOutCP.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumPaidOutCP.DecimalDigits = 2
        Me.NumPaidOutCP.DefaultSendValue = False
        Me.NumPaidOutCP.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPaidOutCP.FireTabAfterEnter = True
        Me.NumPaidOutCP.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPaidOutCP.ForeColor = System.Drawing.Color.Red
        Me.NumPaidOutCP.Image = CType(resources.GetObject("NumPaidOutCP.Image"), System.Drawing.Image)
        Me.NumPaidOutCP.Location = New System.Drawing.Point(308, 269)
        Me.NumPaidOutCP.Maxlength = 10
        Me.NumPaidOutCP.MinusColor = System.Drawing.Color.Empty
        Me.NumPaidOutCP.Name = "NumPaidOutCP"
        Me.NumPaidOutCP.ReadOnly = True
        Me.NumPaidOutCP.Size = New System.Drawing.Size(74, 21)
        Me.NumPaidOutCP.TabIndex = 127
        Me.NumPaidOutCP.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPaidOutCP.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblPaidOutsCp
        '
        Me.LblPaidOutsCp.BackColor = System.Drawing.SystemColors.Control
        Me.LblPaidOutsCp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPaidOutsCp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaidOutsCp.ForeColor = System.Drawing.Color.Red
        Me.LblPaidOutsCp.Location = New System.Drawing.Point(232, 266)
        Me.LblPaidOutsCp.Name = "LblPaidOutsCp"
        Me.LblPaidOutsCp.Size = New System.Drawing.Size(74, 29)
        Me.LblPaidOutsCp.TabIndex = 126
        Me.LblPaidOutsCp.Text = "Paid Outs CP"
        Me.LblPaidOutsCp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumPaidFromOtherStore9
        '
        Me.NumPaidFromOtherStore9.BackColor = System.Drawing.SystemColors.Control
        Me.NumPaidFromOtherStore9.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPaidFromOtherStore9.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumPaidFromOtherStore9.DecimalDigits = 2
        Me.NumPaidFromOtherStore9.DefaultSendValue = False
        Me.NumPaidFromOtherStore9.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPaidFromOtherStore9.FireTabAfterEnter = True
        Me.NumPaidFromOtherStore9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPaidFromOtherStore9.Image = CType(resources.GetObject("NumPaidFromOtherStore9.Image"), System.Drawing.Image)
        Me.NumPaidFromOtherStore9.Location = New System.Drawing.Point(458, 238)
        Me.NumPaidFromOtherStore9.Maxlength = 10
        Me.NumPaidFromOtherStore9.MinusColor = System.Drawing.Color.Empty
        Me.NumPaidFromOtherStore9.Name = "NumPaidFromOtherStore9"
        Me.NumPaidFromOtherStore9.ReadOnly = True
        Me.NumPaidFromOtherStore9.Size = New System.Drawing.Size(74, 21)
        Me.NumPaidFromOtherStore9.TabIndex = 125
        Me.NumPaidFromOtherStore9.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPaidFromOtherStore9.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPaidFromOtherStore8
        '
        Me.NumPaidFromOtherStore8.BackColor = System.Drawing.SystemColors.Control
        Me.NumPaidFromOtherStore8.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPaidFromOtherStore8.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumPaidFromOtherStore8.DecimalDigits = 2
        Me.NumPaidFromOtherStore8.DefaultSendValue = False
        Me.NumPaidFromOtherStore8.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPaidFromOtherStore8.FireTabAfterEnter = True
        Me.NumPaidFromOtherStore8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPaidFromOtherStore8.Image = CType(resources.GetObject("NumPaidFromOtherStore8.Image"), System.Drawing.Image)
        Me.NumPaidFromOtherStore8.Location = New System.Drawing.Point(458, 213)
        Me.NumPaidFromOtherStore8.Maxlength = 10
        Me.NumPaidFromOtherStore8.MinusColor = System.Drawing.Color.Empty
        Me.NumPaidFromOtherStore8.Name = "NumPaidFromOtherStore8"
        Me.NumPaidFromOtherStore8.ReadOnly = True
        Me.NumPaidFromOtherStore8.Size = New System.Drawing.Size(74, 21)
        Me.NumPaidFromOtherStore8.TabIndex = 124
        Me.NumPaidFromOtherStore8.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPaidFromOtherStore8.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPaidFromOtherStore7
        '
        Me.NumPaidFromOtherStore7.BackColor = System.Drawing.SystemColors.Control
        Me.NumPaidFromOtherStore7.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPaidFromOtherStore7.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumPaidFromOtherStore7.DecimalDigits = 2
        Me.NumPaidFromOtherStore7.DefaultSendValue = False
        Me.NumPaidFromOtherStore7.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPaidFromOtherStore7.FireTabAfterEnter = True
        Me.NumPaidFromOtherStore7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPaidFromOtherStore7.Image = CType(resources.GetObject("NumPaidFromOtherStore7.Image"), System.Drawing.Image)
        Me.NumPaidFromOtherStore7.Location = New System.Drawing.Point(458, 188)
        Me.NumPaidFromOtherStore7.Maxlength = 10
        Me.NumPaidFromOtherStore7.MinusColor = System.Drawing.Color.Empty
        Me.NumPaidFromOtherStore7.Name = "NumPaidFromOtherStore7"
        Me.NumPaidFromOtherStore7.ReadOnly = True
        Me.NumPaidFromOtherStore7.Size = New System.Drawing.Size(74, 21)
        Me.NumPaidFromOtherStore7.TabIndex = 123
        Me.NumPaidFromOtherStore7.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPaidFromOtherStore7.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPaidFromOtherStore6
        '
        Me.NumPaidFromOtherStore6.BackColor = System.Drawing.SystemColors.Control
        Me.NumPaidFromOtherStore6.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPaidFromOtherStore6.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumPaidFromOtherStore6.DecimalDigits = 2
        Me.NumPaidFromOtherStore6.DefaultSendValue = False
        Me.NumPaidFromOtherStore6.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPaidFromOtherStore6.FireTabAfterEnter = True
        Me.NumPaidFromOtherStore6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPaidFromOtherStore6.Image = CType(resources.GetObject("NumPaidFromOtherStore6.Image"), System.Drawing.Image)
        Me.NumPaidFromOtherStore6.Location = New System.Drawing.Point(458, 163)
        Me.NumPaidFromOtherStore6.Maxlength = 10
        Me.NumPaidFromOtherStore6.MinusColor = System.Drawing.Color.Empty
        Me.NumPaidFromOtherStore6.Name = "NumPaidFromOtherStore6"
        Me.NumPaidFromOtherStore6.ReadOnly = True
        Me.NumPaidFromOtherStore6.Size = New System.Drawing.Size(74, 21)
        Me.NumPaidFromOtherStore6.TabIndex = 122
        Me.NumPaidFromOtherStore6.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPaidFromOtherStore6.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPaidFromOtherStore5
        '
        Me.NumPaidFromOtherStore5.BackColor = System.Drawing.SystemColors.Control
        Me.NumPaidFromOtherStore5.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPaidFromOtherStore5.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumPaidFromOtherStore5.DecimalDigits = 2
        Me.NumPaidFromOtherStore5.DefaultSendValue = False
        Me.NumPaidFromOtherStore5.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPaidFromOtherStore5.FireTabAfterEnter = True
        Me.NumPaidFromOtherStore5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPaidFromOtherStore5.Image = CType(resources.GetObject("NumPaidFromOtherStore5.Image"), System.Drawing.Image)
        Me.NumPaidFromOtherStore5.Location = New System.Drawing.Point(458, 138)
        Me.NumPaidFromOtherStore5.Maxlength = 10
        Me.NumPaidFromOtherStore5.MinusColor = System.Drawing.Color.Empty
        Me.NumPaidFromOtherStore5.Name = "NumPaidFromOtherStore5"
        Me.NumPaidFromOtherStore5.ReadOnly = True
        Me.NumPaidFromOtherStore5.Size = New System.Drawing.Size(74, 21)
        Me.NumPaidFromOtherStore5.TabIndex = 121
        Me.NumPaidFromOtherStore5.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPaidFromOtherStore5.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPaidFromOtherStore4
        '
        Me.NumPaidFromOtherStore4.BackColor = System.Drawing.Color.Gold
        Me.NumPaidFromOtherStore4.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPaidFromOtherStore4.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumPaidFromOtherStore4.DecimalDigits = 2
        Me.NumPaidFromOtherStore4.DefaultSendValue = False
        Me.NumPaidFromOtherStore4.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPaidFromOtherStore4.FireTabAfterEnter = True
        Me.NumPaidFromOtherStore4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPaidFromOtherStore4.Image = CType(resources.GetObject("NumPaidFromOtherStore4.Image"), System.Drawing.Image)
        Me.NumPaidFromOtherStore4.Location = New System.Drawing.Point(458, 113)
        Me.NumPaidFromOtherStore4.Maxlength = 10
        Me.NumPaidFromOtherStore4.MinusColor = System.Drawing.Color.Empty
        Me.NumPaidFromOtherStore4.Name = "NumPaidFromOtherStore4"
        Me.NumPaidFromOtherStore4.ReadOnly = True
        Me.NumPaidFromOtherStore4.Size = New System.Drawing.Size(74, 21)
        Me.NumPaidFromOtherStore4.TabIndex = 120
        Me.NumPaidFromOtherStore4.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPaidFromOtherStore4.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPaidFromOtherStore3
        '
        Me.NumPaidFromOtherStore3.BackColor = System.Drawing.SystemColors.Control
        Me.NumPaidFromOtherStore3.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPaidFromOtherStore3.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumPaidFromOtherStore3.DecimalDigits = 2
        Me.NumPaidFromOtherStore3.DefaultSendValue = False
        Me.NumPaidFromOtherStore3.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPaidFromOtherStore3.FireTabAfterEnter = True
        Me.NumPaidFromOtherStore3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPaidFromOtherStore3.Image = CType(resources.GetObject("NumPaidFromOtherStore3.Image"), System.Drawing.Image)
        Me.NumPaidFromOtherStore3.Location = New System.Drawing.Point(458, 88)
        Me.NumPaidFromOtherStore3.Maxlength = 10
        Me.NumPaidFromOtherStore3.MinusColor = System.Drawing.Color.Empty
        Me.NumPaidFromOtherStore3.Name = "NumPaidFromOtherStore3"
        Me.NumPaidFromOtherStore3.ReadOnly = True
        Me.NumPaidFromOtherStore3.Size = New System.Drawing.Size(74, 21)
        Me.NumPaidFromOtherStore3.TabIndex = 119
        Me.NumPaidFromOtherStore3.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPaidFromOtherStore3.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPaidFromOtherStore2
        '
        Me.NumPaidFromOtherStore2.BackColor = System.Drawing.SystemColors.Control
        Me.NumPaidFromOtherStore2.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPaidFromOtherStore2.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumPaidFromOtherStore2.DecimalDigits = 2
        Me.NumPaidFromOtherStore2.DefaultSendValue = False
        Me.NumPaidFromOtherStore2.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPaidFromOtherStore2.FireTabAfterEnter = True
        Me.NumPaidFromOtherStore2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPaidFromOtherStore2.Image = CType(resources.GetObject("NumPaidFromOtherStore2.Image"), System.Drawing.Image)
        Me.NumPaidFromOtherStore2.Location = New System.Drawing.Point(458, 63)
        Me.NumPaidFromOtherStore2.Maxlength = 10
        Me.NumPaidFromOtherStore2.MinusColor = System.Drawing.Color.Empty
        Me.NumPaidFromOtherStore2.Name = "NumPaidFromOtherStore2"
        Me.NumPaidFromOtherStore2.ReadOnly = True
        Me.NumPaidFromOtherStore2.Size = New System.Drawing.Size(74, 21)
        Me.NumPaidFromOtherStore2.TabIndex = 118
        Me.NumPaidFromOtherStore2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPaidFromOtherStore2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPaidFromOtherStore1
        '
        Me.NumPaidFromOtherStore1.BackColor = System.Drawing.SystemColors.Control
        Me.NumPaidFromOtherStore1.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPaidFromOtherStore1.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumPaidFromOtherStore1.DecimalDigits = 2
        Me.NumPaidFromOtherStore1.DefaultSendValue = False
        Me.NumPaidFromOtherStore1.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPaidFromOtherStore1.FireTabAfterEnter = True
        Me.NumPaidFromOtherStore1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPaidFromOtherStore1.Image = CType(resources.GetObject("NumPaidFromOtherStore1.Image"), System.Drawing.Image)
        Me.NumPaidFromOtherStore1.Location = New System.Drawing.Point(458, 38)
        Me.NumPaidFromOtherStore1.Maxlength = 10
        Me.NumPaidFromOtherStore1.MinusColor = System.Drawing.Color.Empty
        Me.NumPaidFromOtherStore1.Name = "NumPaidFromOtherStore1"
        Me.NumPaidFromOtherStore1.ReadOnly = True
        Me.NumPaidFromOtherStore1.Size = New System.Drawing.Size(74, 21)
        Me.NumPaidFromOtherStore1.TabIndex = 117
        Me.NumPaidFromOtherStore1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPaidFromOtherStore1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(458, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 29)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "RA From"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Num196
        '
        Me.Num196.BackColor = System.Drawing.SystemColors.Control
        Me.Num196.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num196.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num196.DecimalDigits = 2
        Me.Num196.DefaultSendValue = False
        Me.Num196.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num196.FireTabAfterEnter = True
        Me.Num196.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num196.Image = CType(resources.GetObject("Num196.Image"), System.Drawing.Image)
        Me.Num196.Location = New System.Drawing.Point(608, 238)
        Me.Num196.Maxlength = 10
        Me.Num196.MinusColor = System.Drawing.Color.Empty
        Me.Num196.Name = "Num196"
        Me.Num196.ReadOnly = True
        Me.Num196.Size = New System.Drawing.Size(74, 21)
        Me.Num196.TabIndex = 115
        Me.Num196.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num196.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num186
        '
        Me.Num186.BackColor = System.Drawing.SystemColors.Control
        Me.Num186.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num186.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num186.DecimalDigits = 2
        Me.Num186.DefaultSendValue = False
        Me.Num186.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num186.FireTabAfterEnter = True
        Me.Num186.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num186.Image = CType(resources.GetObject("Num186.Image"), System.Drawing.Image)
        Me.Num186.Location = New System.Drawing.Point(608, 213)
        Me.Num186.Maxlength = 10
        Me.Num186.MinusColor = System.Drawing.Color.Empty
        Me.Num186.Name = "Num186"
        Me.Num186.ReadOnly = True
        Me.Num186.Size = New System.Drawing.Size(74, 21)
        Me.Num186.TabIndex = 114
        Me.Num186.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num186.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num176
        '
        Me.Num176.BackColor = System.Drawing.SystemColors.Control
        Me.Num176.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num176.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num176.DecimalDigits = 2
        Me.Num176.DefaultSendValue = False
        Me.Num176.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num176.FireTabAfterEnter = True
        Me.Num176.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num176.Image = CType(resources.GetObject("Num176.Image"), System.Drawing.Image)
        Me.Num176.Location = New System.Drawing.Point(608, 188)
        Me.Num176.Maxlength = 10
        Me.Num176.MinusColor = System.Drawing.Color.Empty
        Me.Num176.Name = "Num176"
        Me.Num176.ReadOnly = True
        Me.Num176.Size = New System.Drawing.Size(74, 21)
        Me.Num176.TabIndex = 113
        Me.Num176.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num176.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPaidForOtherStore9
        '
        Me.NumPaidForOtherStore9.BackColor = System.Drawing.SystemColors.Control
        Me.NumPaidForOtherStore9.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPaidForOtherStore9.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumPaidForOtherStore9.DecimalDigits = 2
        Me.NumPaidForOtherStore9.DefaultSendValue = False
        Me.NumPaidForOtherStore9.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPaidForOtherStore9.FireTabAfterEnter = True
        Me.NumPaidForOtherStore9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPaidForOtherStore9.Image = CType(resources.GetObject("NumPaidForOtherStore9.Image"), System.Drawing.Image)
        Me.NumPaidForOtherStore9.Location = New System.Drawing.Point(383, 238)
        Me.NumPaidForOtherStore9.Maxlength = 10
        Me.NumPaidForOtherStore9.MinusColor = System.Drawing.Color.Empty
        Me.NumPaidForOtherStore9.Name = "NumPaidForOtherStore9"
        Me.NumPaidForOtherStore9.ReadOnly = True
        Me.NumPaidForOtherStore9.Size = New System.Drawing.Size(74, 21)
        Me.NumPaidForOtherStore9.TabIndex = 112
        Me.NumPaidForOtherStore9.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPaidForOtherStore9.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPaidForOtherStore8
        '
        Me.NumPaidForOtherStore8.BackColor = System.Drawing.SystemColors.Control
        Me.NumPaidForOtherStore8.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPaidForOtherStore8.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumPaidForOtherStore8.DecimalDigits = 2
        Me.NumPaidForOtherStore8.DefaultSendValue = False
        Me.NumPaidForOtherStore8.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPaidForOtherStore8.FireTabAfterEnter = True
        Me.NumPaidForOtherStore8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPaidForOtherStore8.Image = CType(resources.GetObject("NumPaidForOtherStore8.Image"), System.Drawing.Image)
        Me.NumPaidForOtherStore8.Location = New System.Drawing.Point(383, 213)
        Me.NumPaidForOtherStore8.Maxlength = 10
        Me.NumPaidForOtherStore8.MinusColor = System.Drawing.Color.Empty
        Me.NumPaidForOtherStore8.Name = "NumPaidForOtherStore8"
        Me.NumPaidForOtherStore8.ReadOnly = True
        Me.NumPaidForOtherStore8.Size = New System.Drawing.Size(74, 21)
        Me.NumPaidForOtherStore8.TabIndex = 111
        Me.NumPaidForOtherStore8.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPaidForOtherStore8.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPaidForOtherStore7
        '
        Me.NumPaidForOtherStore7.BackColor = System.Drawing.SystemColors.Control
        Me.NumPaidForOtherStore7.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPaidForOtherStore7.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumPaidForOtherStore7.DecimalDigits = 2
        Me.NumPaidForOtherStore7.DefaultSendValue = False
        Me.NumPaidForOtherStore7.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPaidForOtherStore7.FireTabAfterEnter = True
        Me.NumPaidForOtherStore7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPaidForOtherStore7.Image = CType(resources.GetObject("NumPaidForOtherStore7.Image"), System.Drawing.Image)
        Me.NumPaidForOtherStore7.Location = New System.Drawing.Point(383, 188)
        Me.NumPaidForOtherStore7.Maxlength = 10
        Me.NumPaidForOtherStore7.MinusColor = System.Drawing.Color.Empty
        Me.NumPaidForOtherStore7.Name = "NumPaidForOtherStore7"
        Me.NumPaidForOtherStore7.ReadOnly = True
        Me.NumPaidForOtherStore7.Size = New System.Drawing.Size(74, 21)
        Me.NumPaidForOtherStore7.TabIndex = 110
        Me.NumPaidForOtherStore7.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPaidForOtherStore7.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num194
        '
        Me.Num194.BackColor = System.Drawing.SystemColors.Control
        Me.Num194.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num194.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num194.DecimalDigits = 2
        Me.Num194.DefaultSendValue = False
        Me.Num194.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num194.FireTabAfterEnter = True
        Me.Num194.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num194.ForeColor = System.Drawing.Color.Red
        Me.Num194.Image = CType(resources.GetObject("Num194.Image"), System.Drawing.Image)
        Me.Num194.Location = New System.Drawing.Point(308, 238)
        Me.Num194.Maxlength = 10
        Me.Num194.MinusColor = System.Drawing.Color.Empty
        Me.Num194.Name = "Num194"
        Me.Num194.ReadOnly = True
        Me.Num194.Size = New System.Drawing.Size(74, 21)
        Me.Num194.TabIndex = 109
        Me.Num194.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num194.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num184
        '
        Me.Num184.BackColor = System.Drawing.SystemColors.Control
        Me.Num184.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num184.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num184.DecimalDigits = 2
        Me.Num184.DefaultSendValue = False
        Me.Num184.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num184.FireTabAfterEnter = True
        Me.Num184.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num184.ForeColor = System.Drawing.Color.Red
        Me.Num184.Image = CType(resources.GetObject("Num184.Image"), System.Drawing.Image)
        Me.Num184.Location = New System.Drawing.Point(308, 213)
        Me.Num184.Maxlength = 10
        Me.Num184.MinusColor = System.Drawing.Color.Empty
        Me.Num184.Name = "Num184"
        Me.Num184.ReadOnly = True
        Me.Num184.Size = New System.Drawing.Size(74, 21)
        Me.Num184.TabIndex = 108
        Me.Num184.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num184.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num174
        '
        Me.Num174.BackColor = System.Drawing.SystemColors.Control
        Me.Num174.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num174.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num174.DecimalDigits = 2
        Me.Num174.DefaultSendValue = False
        Me.Num174.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num174.FireTabAfterEnter = True
        Me.Num174.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num174.ForeColor = System.Drawing.Color.Red
        Me.Num174.Image = CType(resources.GetObject("Num174.Image"), System.Drawing.Image)
        Me.Num174.Location = New System.Drawing.Point(308, 188)
        Me.Num174.Maxlength = 10
        Me.Num174.MinusColor = System.Drawing.Color.Empty
        Me.Num174.Name = "Num174"
        Me.Num174.ReadOnly = True
        Me.Num174.Size = New System.Drawing.Size(74, 21)
        Me.Num174.TabIndex = 107
        Me.Num174.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num174.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num193
        '
        Me.Num193.BackColor = System.Drawing.SystemColors.Control
        Me.Num193.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num193.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num193.DecimalDigits = 2
        Me.Num193.DefaultSendValue = False
        Me.Num193.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num193.FireTabAfterEnter = True
        Me.Num193.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num193.Image = CType(resources.GetObject("Num193.Image"), System.Drawing.Image)
        Me.Num193.Location = New System.Drawing.Point(233, 238)
        Me.Num193.Maxlength = 10
        Me.Num193.MinusColor = System.Drawing.Color.Empty
        Me.Num193.Name = "Num193"
        Me.Num193.ReadOnly = True
        Me.Num193.Size = New System.Drawing.Size(74, 21)
        Me.Num193.TabIndex = 106
        Me.Num193.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num193.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num183
        '
        Me.Num183.BackColor = System.Drawing.SystemColors.Control
        Me.Num183.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num183.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num183.DecimalDigits = 2
        Me.Num183.DefaultSendValue = False
        Me.Num183.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num183.FireTabAfterEnter = True
        Me.Num183.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num183.Image = CType(resources.GetObject("Num183.Image"), System.Drawing.Image)
        Me.Num183.Location = New System.Drawing.Point(233, 213)
        Me.Num183.Maxlength = 10
        Me.Num183.MinusColor = System.Drawing.Color.Empty
        Me.Num183.Name = "Num183"
        Me.Num183.ReadOnly = True
        Me.Num183.Size = New System.Drawing.Size(74, 21)
        Me.Num183.TabIndex = 105
        Me.Num183.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num183.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num173
        '
        Me.Num173.BackColor = System.Drawing.SystemColors.Control
        Me.Num173.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num173.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num173.DecimalDigits = 2
        Me.Num173.DefaultSendValue = False
        Me.Num173.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num173.FireTabAfterEnter = True
        Me.Num173.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num173.Image = CType(resources.GetObject("Num173.Image"), System.Drawing.Image)
        Me.Num173.Location = New System.Drawing.Point(233, 188)
        Me.Num173.Maxlength = 10
        Me.Num173.MinusColor = System.Drawing.Color.Empty
        Me.Num173.Name = "Num173"
        Me.Num173.ReadOnly = True
        Me.Num173.Size = New System.Drawing.Size(74, 21)
        Me.Num173.TabIndex = 104
        Me.Num173.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num173.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num192
        '
        Me.Num192.BackColor = System.Drawing.SystemColors.Control
        Me.Num192.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num192.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num192.DecimalDigits = 2
        Me.Num192.DefaultSendValue = False
        Me.Num192.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num192.FireTabAfterEnter = True
        Me.Num192.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num192.Image = CType(resources.GetObject("Num192.Image"), System.Drawing.Image)
        Me.Num192.Location = New System.Drawing.Point(158, 238)
        Me.Num192.Maxlength = 10
        Me.Num192.MinusColor = System.Drawing.Color.Empty
        Me.Num192.Name = "Num192"
        Me.Num192.ReadOnly = True
        Me.Num192.Size = New System.Drawing.Size(74, 21)
        Me.Num192.TabIndex = 103
        Me.Num192.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num192.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num182
        '
        Me.Num182.BackColor = System.Drawing.SystemColors.Control
        Me.Num182.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num182.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num182.DecimalDigits = 2
        Me.Num182.DefaultSendValue = False
        Me.Num182.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num182.FireTabAfterEnter = True
        Me.Num182.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num182.Image = CType(resources.GetObject("Num182.Image"), System.Drawing.Image)
        Me.Num182.Location = New System.Drawing.Point(158, 213)
        Me.Num182.Maxlength = 10
        Me.Num182.MinusColor = System.Drawing.Color.Empty
        Me.Num182.Name = "Num182"
        Me.Num182.ReadOnly = True
        Me.Num182.Size = New System.Drawing.Size(74, 21)
        Me.Num182.TabIndex = 102
        Me.Num182.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num182.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num172
        '
        Me.Num172.BackColor = System.Drawing.SystemColors.Control
        Me.Num172.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num172.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num172.DecimalDigits = 2
        Me.Num172.DefaultSendValue = False
        Me.Num172.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num172.FireTabAfterEnter = True
        Me.Num172.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num172.Image = CType(resources.GetObject("Num172.Image"), System.Drawing.Image)
        Me.Num172.Location = New System.Drawing.Point(158, 188)
        Me.Num172.Maxlength = 10
        Me.Num172.MinusColor = System.Drawing.Color.Empty
        Me.Num172.Name = "Num172"
        Me.Num172.ReadOnly = True
        Me.Num172.Size = New System.Drawing.Size(74, 21)
        Me.Num172.TabIndex = 101
        Me.Num172.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num172.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num191
        '
        Me.Num191.BackColor = System.Drawing.SystemColors.Control
        Me.Num191.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num191.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num191.DecimalDigits = 2
        Me.Num191.DefaultSendValue = False
        Me.Num191.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num191.FireTabAfterEnter = True
        Me.Num191.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num191.Image = CType(resources.GetObject("Num191.Image"), System.Drawing.Image)
        Me.Num191.Location = New System.Drawing.Point(83, 238)
        Me.Num191.Maxlength = 10
        Me.Num191.MinusColor = System.Drawing.Color.Empty
        Me.Num191.Name = "Num191"
        Me.Num191.ReadOnly = True
        Me.Num191.Size = New System.Drawing.Size(74, 21)
        Me.Num191.TabIndex = 100
        Me.Num191.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num191.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num181
        '
        Me.Num181.BackColor = System.Drawing.SystemColors.Control
        Me.Num181.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num181.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num181.DecimalDigits = 2
        Me.Num181.DefaultSendValue = False
        Me.Num181.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num181.FireTabAfterEnter = True
        Me.Num181.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num181.Image = CType(resources.GetObject("Num181.Image"), System.Drawing.Image)
        Me.Num181.Location = New System.Drawing.Point(83, 213)
        Me.Num181.Maxlength = 10
        Me.Num181.MinusColor = System.Drawing.Color.Empty
        Me.Num181.Name = "Num181"
        Me.Num181.ReadOnly = True
        Me.Num181.Size = New System.Drawing.Size(74, 21)
        Me.Num181.TabIndex = 99
        Me.Num181.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num181.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num171
        '
        Me.Num171.BackColor = System.Drawing.SystemColors.Control
        Me.Num171.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num171.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num171.DecimalDigits = 2
        Me.Num171.DefaultSendValue = False
        Me.Num171.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num171.FireTabAfterEnter = True
        Me.Num171.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num171.Image = CType(resources.GetObject("Num171.Image"), System.Drawing.Image)
        Me.Num171.Location = New System.Drawing.Point(83, 188)
        Me.Num171.Maxlength = 10
        Me.Num171.MinusColor = System.Drawing.Color.Empty
        Me.Num171.Name = "Num171"
        Me.Num171.ReadOnly = True
        Me.Num171.Size = New System.Drawing.Size(74, 21)
        Me.Num171.TabIndex = 98
        Me.Num171.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num171.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblCC5
        '
        Me.LblCC5.BackColor = System.Drawing.SystemColors.Control
        Me.LblCC5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCC5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCC5.Location = New System.Drawing.Point(1, 237)
        Me.LblCC5.Name = "LblCC5"
        Me.LblCC5.Size = New System.Drawing.Size(80, 24)
        Me.LblCC5.TabIndex = 97
        Me.LblCC5.Text = "Group 5"
        Me.LblCC5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCC4
        '
        Me.LblCC4.BackColor = System.Drawing.SystemColors.Control
        Me.LblCC4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCC4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCC4.Location = New System.Drawing.Point(1, 212)
        Me.LblCC4.Name = "LblCC4"
        Me.LblCC4.Size = New System.Drawing.Size(80, 24)
        Me.LblCC4.TabIndex = 96
        Me.LblCC4.Text = "Group 4"
        Me.LblCC4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCC3
        '
        Me.LblCC3.BackColor = System.Drawing.SystemColors.Control
        Me.LblCC3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCC3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCC3.Location = New System.Drawing.Point(1, 187)
        Me.LblCC3.Name = "LblCC3"
        Me.LblCC3.Size = New System.Drawing.Size(80, 24)
        Me.LblCC3.TabIndex = 95
        Me.LblCC3.Text = "Discover"
        Me.LblCC3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Num166
        '
        Me.Num166.BackColor = System.Drawing.SystemColors.Control
        Me.Num166.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num166.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num166.DecimalDigits = 2
        Me.Num166.DefaultSendValue = False
        Me.Num166.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num166.FireTabAfterEnter = True
        Me.Num166.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num166.Image = CType(resources.GetObject("Num166.Image"), System.Drawing.Image)
        Me.Num166.Location = New System.Drawing.Point(608, 163)
        Me.Num166.Maxlength = 10
        Me.Num166.MinusColor = System.Drawing.Color.Empty
        Me.Num166.Name = "Num166"
        Me.Num166.ReadOnly = True
        Me.Num166.Size = New System.Drawing.Size(74, 21)
        Me.Num166.TabIndex = 94
        Me.Num166.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num166.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num156
        '
        Me.Num156.BackColor = System.Drawing.SystemColors.Control
        Me.Num156.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num156.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num156.DecimalDigits = 2
        Me.Num156.DefaultSendValue = False
        Me.Num156.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num156.FireTabAfterEnter = True
        Me.Num156.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num156.Image = CType(resources.GetObject("Num156.Image"), System.Drawing.Image)
        Me.Num156.Location = New System.Drawing.Point(608, 138)
        Me.Num156.Maxlength = 10
        Me.Num156.MinusColor = System.Drawing.Color.Empty
        Me.Num156.Name = "Num156"
        Me.Num156.ReadOnly = True
        Me.Num156.Size = New System.Drawing.Size(74, 21)
        Me.Num156.TabIndex = 93
        Me.Num156.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num156.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num146
        '
        Me.Num146.BackColor = System.Drawing.Color.Gold
        Me.Num146.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num146.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num146.DecimalDigits = 2
        Me.Num146.DefaultSendValue = False
        Me.Num146.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num146.FireTabAfterEnter = True
        Me.Num146.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num146.Image = CType(resources.GetObject("Num146.Image"), System.Drawing.Image)
        Me.Num146.Location = New System.Drawing.Point(608, 113)
        Me.Num146.Maxlength = 10
        Me.Num146.MinusColor = System.Drawing.Color.Empty
        Me.Num146.Name = "Num146"
        Me.Num146.ReadOnly = True
        Me.Num146.Size = New System.Drawing.Size(74, 21)
        Me.Num146.TabIndex = 92
        Me.Num146.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num146.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num136
        '
        Me.Num136.BackColor = System.Drawing.SystemColors.Control
        Me.Num136.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num136.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num136.DecimalDigits = 2
        Me.Num136.DefaultSendValue = False
        Me.Num136.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num136.FireTabAfterEnter = True
        Me.Num136.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num136.Image = CType(resources.GetObject("Num136.Image"), System.Drawing.Image)
        Me.Num136.Location = New System.Drawing.Point(608, 88)
        Me.Num136.Maxlength = 10
        Me.Num136.MinusColor = System.Drawing.Color.Empty
        Me.Num136.Name = "Num136"
        Me.Num136.ReadOnly = True
        Me.Num136.Size = New System.Drawing.Size(74, 21)
        Me.Num136.TabIndex = 91
        Me.Num136.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num136.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num126
        '
        Me.Num126.BackColor = System.Drawing.SystemColors.Control
        Me.Num126.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num126.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num126.DecimalDigits = 2
        Me.Num126.DefaultSendValue = False
        Me.Num126.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num126.FireTabAfterEnter = True
        Me.Num126.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num126.Image = CType(resources.GetObject("Num126.Image"), System.Drawing.Image)
        Me.Num126.Location = New System.Drawing.Point(608, 63)
        Me.Num126.Maxlength = 10
        Me.Num126.MinusColor = System.Drawing.Color.Empty
        Me.Num126.Name = "Num126"
        Me.Num126.ReadOnly = True
        Me.Num126.Size = New System.Drawing.Size(74, 21)
        Me.Num126.TabIndex = 90
        Me.Num126.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num126.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num116
        '
        Me.Num116.BackColor = System.Drawing.SystemColors.Control
        Me.Num116.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num116.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num116.DecimalDigits = 2
        Me.Num116.DefaultSendValue = False
        Me.Num116.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num116.FireTabAfterEnter = True
        Me.Num116.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num116.Image = CType(resources.GetObject("Num116.Image"), System.Drawing.Image)
        Me.Num116.Location = New System.Drawing.Point(608, 38)
        Me.Num116.Maxlength = 10
        Me.Num116.MinusColor = System.Drawing.Color.Empty
        Me.Num116.Name = "Num116"
        Me.Num116.ReadOnly = True
        Me.Num116.Size = New System.Drawing.Size(74, 21)
        Me.Num116.TabIndex = 89
        Me.Num116.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num116.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPaidForOtherStore6
        '
        Me.NumPaidForOtherStore6.BackColor = System.Drawing.SystemColors.Control
        Me.NumPaidForOtherStore6.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPaidForOtherStore6.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumPaidForOtherStore6.DecimalDigits = 2
        Me.NumPaidForOtherStore6.DefaultSendValue = False
        Me.NumPaidForOtherStore6.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPaidForOtherStore6.FireTabAfterEnter = True
        Me.NumPaidForOtherStore6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPaidForOtherStore6.Image = CType(resources.GetObject("NumPaidForOtherStore6.Image"), System.Drawing.Image)
        Me.NumPaidForOtherStore6.Location = New System.Drawing.Point(383, 163)
        Me.NumPaidForOtherStore6.Maxlength = 10
        Me.NumPaidForOtherStore6.MinusColor = System.Drawing.Color.Empty
        Me.NumPaidForOtherStore6.Name = "NumPaidForOtherStore6"
        Me.NumPaidForOtherStore6.ReadOnly = True
        Me.NumPaidForOtherStore6.Size = New System.Drawing.Size(74, 21)
        Me.NumPaidForOtherStore6.TabIndex = 88
        Me.NumPaidForOtherStore6.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPaidForOtherStore6.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPaidForOtherStore5
        '
        Me.NumPaidForOtherStore5.BackColor = System.Drawing.SystemColors.Control
        Me.NumPaidForOtherStore5.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPaidForOtherStore5.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumPaidForOtherStore5.DecimalDigits = 2
        Me.NumPaidForOtherStore5.DefaultSendValue = False
        Me.NumPaidForOtherStore5.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPaidForOtherStore5.FireTabAfterEnter = True
        Me.NumPaidForOtherStore5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPaidForOtherStore5.Image = CType(resources.GetObject("NumPaidForOtherStore5.Image"), System.Drawing.Image)
        Me.NumPaidForOtherStore5.Location = New System.Drawing.Point(383, 138)
        Me.NumPaidForOtherStore5.Maxlength = 10
        Me.NumPaidForOtherStore5.MinusColor = System.Drawing.Color.Empty
        Me.NumPaidForOtherStore5.Name = "NumPaidForOtherStore5"
        Me.NumPaidForOtherStore5.ReadOnly = True
        Me.NumPaidForOtherStore5.Size = New System.Drawing.Size(74, 21)
        Me.NumPaidForOtherStore5.TabIndex = 87
        Me.NumPaidForOtherStore5.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPaidForOtherStore5.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPaidForOtherStore4
        '
        Me.NumPaidForOtherStore4.BackColor = System.Drawing.Color.Gold
        Me.NumPaidForOtherStore4.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPaidForOtherStore4.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumPaidForOtherStore4.DecimalDigits = 2
        Me.NumPaidForOtherStore4.DefaultSendValue = False
        Me.NumPaidForOtherStore4.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPaidForOtherStore4.FireTabAfterEnter = True
        Me.NumPaidForOtherStore4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPaidForOtherStore4.ForeColor = System.Drawing.Color.Black
        Me.NumPaidForOtherStore4.Image = CType(resources.GetObject("NumPaidForOtherStore4.Image"), System.Drawing.Image)
        Me.NumPaidForOtherStore4.Location = New System.Drawing.Point(383, 113)
        Me.NumPaidForOtherStore4.Maxlength = 10
        Me.NumPaidForOtherStore4.MinusColor = System.Drawing.Color.Empty
        Me.NumPaidForOtherStore4.Name = "NumPaidForOtherStore4"
        Me.NumPaidForOtherStore4.ReadOnly = True
        Me.NumPaidForOtherStore4.Size = New System.Drawing.Size(74, 21)
        Me.NumPaidForOtherStore4.TabIndex = 86
        Me.NumPaidForOtherStore4.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPaidForOtherStore4.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPaidForOtherStore3
        '
        Me.NumPaidForOtherStore3.BackColor = System.Drawing.SystemColors.Control
        Me.NumPaidForOtherStore3.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPaidForOtherStore3.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumPaidForOtherStore3.DecimalDigits = 2
        Me.NumPaidForOtherStore3.DefaultSendValue = False
        Me.NumPaidForOtherStore3.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPaidForOtherStore3.FireTabAfterEnter = True
        Me.NumPaidForOtherStore3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPaidForOtherStore3.Image = CType(resources.GetObject("NumPaidForOtherStore3.Image"), System.Drawing.Image)
        Me.NumPaidForOtherStore3.Location = New System.Drawing.Point(383, 88)
        Me.NumPaidForOtherStore3.Maxlength = 10
        Me.NumPaidForOtherStore3.MinusColor = System.Drawing.Color.Empty
        Me.NumPaidForOtherStore3.Name = "NumPaidForOtherStore3"
        Me.NumPaidForOtherStore3.ReadOnly = True
        Me.NumPaidForOtherStore3.Size = New System.Drawing.Size(74, 21)
        Me.NumPaidForOtherStore3.TabIndex = 85
        Me.NumPaidForOtherStore3.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPaidForOtherStore3.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPaidForOtherStore2
        '
        Me.NumPaidForOtherStore2.BackColor = System.Drawing.SystemColors.Control
        Me.NumPaidForOtherStore2.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPaidForOtherStore2.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumPaidForOtherStore2.DecimalDigits = 2
        Me.NumPaidForOtherStore2.DefaultSendValue = False
        Me.NumPaidForOtherStore2.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPaidForOtherStore2.FireTabAfterEnter = True
        Me.NumPaidForOtherStore2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPaidForOtherStore2.Image = CType(resources.GetObject("NumPaidForOtherStore2.Image"), System.Drawing.Image)
        Me.NumPaidForOtherStore2.Location = New System.Drawing.Point(383, 63)
        Me.NumPaidForOtherStore2.Maxlength = 10
        Me.NumPaidForOtherStore2.MinusColor = System.Drawing.Color.Empty
        Me.NumPaidForOtherStore2.Name = "NumPaidForOtherStore2"
        Me.NumPaidForOtherStore2.ReadOnly = True
        Me.NumPaidForOtherStore2.Size = New System.Drawing.Size(74, 21)
        Me.NumPaidForOtherStore2.TabIndex = 84
        Me.NumPaidForOtherStore2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPaidForOtherStore2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPaidForOtherStore1
        '
        Me.NumPaidForOtherStore1.BackColor = System.Drawing.SystemColors.Control
        Me.NumPaidForOtherStore1.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPaidForOtherStore1.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumPaidForOtherStore1.DecimalDigits = 2
        Me.NumPaidForOtherStore1.DefaultSendValue = False
        Me.NumPaidForOtherStore1.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPaidForOtherStore1.FireTabAfterEnter = True
        Me.NumPaidForOtherStore1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPaidForOtherStore1.ForeColor = System.Drawing.Color.Black
        Me.NumPaidForOtherStore1.Image = CType(resources.GetObject("NumPaidForOtherStore1.Image"), System.Drawing.Image)
        Me.NumPaidForOtherStore1.Location = New System.Drawing.Point(383, 38)
        Me.NumPaidForOtherStore1.Maxlength = 10
        Me.NumPaidForOtherStore1.MinusColor = System.Drawing.Color.Empty
        Me.NumPaidForOtherStore1.Name = "NumPaidForOtherStore1"
        Me.NumPaidForOtherStore1.ReadOnly = True
        Me.NumPaidForOtherStore1.Size = New System.Drawing.Size(74, 21)
        Me.NumPaidForOtherStore1.TabIndex = 83
        Me.NumPaidForOtherStore1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPaidForOtherStore1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num164
        '
        Me.Num164.BackColor = System.Drawing.SystemColors.Control
        Me.Num164.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num164.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num164.DecimalDigits = 2
        Me.Num164.DefaultSendValue = False
        Me.Num164.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num164.FireTabAfterEnter = True
        Me.Num164.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num164.ForeColor = System.Drawing.Color.Red
        Me.Num164.Image = CType(resources.GetObject("Num164.Image"), System.Drawing.Image)
        Me.Num164.Location = New System.Drawing.Point(308, 163)
        Me.Num164.Maxlength = 10
        Me.Num164.MinusColor = System.Drawing.Color.Empty
        Me.Num164.Name = "Num164"
        Me.Num164.ReadOnly = True
        Me.Num164.Size = New System.Drawing.Size(74, 21)
        Me.Num164.TabIndex = 82
        Me.Num164.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num164.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num154
        '
        Me.Num154.BackColor = System.Drawing.SystemColors.Control
        Me.Num154.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num154.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num154.DecimalDigits = 2
        Me.Num154.DefaultSendValue = False
        Me.Num154.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num154.FireTabAfterEnter = True
        Me.Num154.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num154.ForeColor = System.Drawing.Color.Red
        Me.Num154.Image = CType(resources.GetObject("Num154.Image"), System.Drawing.Image)
        Me.Num154.Location = New System.Drawing.Point(308, 138)
        Me.Num154.Maxlength = 10
        Me.Num154.MinusColor = System.Drawing.Color.Empty
        Me.Num154.Name = "Num154"
        Me.Num154.ReadOnly = True
        Me.Num154.Size = New System.Drawing.Size(74, 21)
        Me.Num154.TabIndex = 81
        Me.Num154.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num154.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num144
        '
        Me.Num144.BackColor = System.Drawing.Color.Gold
        Me.Num144.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num144.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num144.DecimalDigits = 2
        Me.Num144.DefaultSendValue = False
        Me.Num144.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num144.FireTabAfterEnter = True
        Me.Num144.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num144.ForeColor = System.Drawing.Color.Red
        Me.Num144.Image = CType(resources.GetObject("Num144.Image"), System.Drawing.Image)
        Me.Num144.Location = New System.Drawing.Point(308, 113)
        Me.Num144.Maxlength = 10
        Me.Num144.MinusColor = System.Drawing.Color.Empty
        Me.Num144.Name = "Num144"
        Me.Num144.ReadOnly = True
        Me.Num144.Size = New System.Drawing.Size(74, 21)
        Me.Num144.TabIndex = 80
        Me.Num144.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num144.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num134
        '
        Me.Num134.BackColor = System.Drawing.SystemColors.Control
        Me.Num134.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num134.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num134.DecimalDigits = 2
        Me.Num134.DefaultSendValue = False
        Me.Num134.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num134.FireTabAfterEnter = True
        Me.Num134.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num134.ForeColor = System.Drawing.Color.Red
        Me.Num134.Image = CType(resources.GetObject("Num134.Image"), System.Drawing.Image)
        Me.Num134.Location = New System.Drawing.Point(308, 88)
        Me.Num134.Maxlength = 10
        Me.Num134.MinusColor = System.Drawing.Color.Empty
        Me.Num134.Name = "Num134"
        Me.Num134.ReadOnly = True
        Me.Num134.Size = New System.Drawing.Size(74, 21)
        Me.Num134.TabIndex = 79
        Me.Num134.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num134.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num124
        '
        Me.Num124.BackColor = System.Drawing.SystemColors.Control
        Me.Num124.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num124.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num124.DecimalDigits = 2
        Me.Num124.DefaultSendValue = False
        Me.Num124.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num124.FireTabAfterEnter = True
        Me.Num124.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num124.ForeColor = System.Drawing.Color.Red
        Me.Num124.Image = CType(resources.GetObject("Num124.Image"), System.Drawing.Image)
        Me.Num124.Location = New System.Drawing.Point(308, 63)
        Me.Num124.Maxlength = 10
        Me.Num124.MinusColor = System.Drawing.Color.Empty
        Me.Num124.Name = "Num124"
        Me.Num124.ReadOnly = True
        Me.Num124.Size = New System.Drawing.Size(74, 21)
        Me.Num124.TabIndex = 78
        Me.Num124.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num124.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num114
        '
        Me.Num114.BackColor = System.Drawing.SystemColors.Control
        Me.Num114.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num114.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num114.DecimalDigits = 2
        Me.Num114.DefaultSendValue = False
        Me.Num114.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num114.FireTabAfterEnter = True
        Me.Num114.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num114.ForeColor = System.Drawing.Color.Red
        Me.Num114.Image = CType(resources.GetObject("Num114.Image"), System.Drawing.Image)
        Me.Num114.Location = New System.Drawing.Point(308, 38)
        Me.Num114.Maxlength = 10
        Me.Num114.MinusColor = System.Drawing.Color.Empty
        Me.Num114.Name = "Num114"
        Me.Num114.ReadOnly = True
        Me.Num114.Size = New System.Drawing.Size(74, 21)
        Me.Num114.TabIndex = 77
        Me.Num114.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num114.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Lbl106
        '
        Me.Lbl106.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl106.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl106.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl106.Location = New System.Drawing.Point(608, 8)
        Me.Lbl106.Name = "Lbl106"
        Me.Lbl106.Size = New System.Drawing.Size(74, 29)
        Me.Lbl106.TabIndex = 76
        Me.Lbl106.Text = "Net"
        Me.Lbl106.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label233
        '
        Me.label233.BackColor = System.Drawing.SystemColors.Control
        Me.label233.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label233.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label233.ForeColor = System.Drawing.Color.Black
        Me.label233.Location = New System.Drawing.Point(383, 8)
        Me.label233.Name = "label233"
        Me.label233.Size = New System.Drawing.Size(74, 29)
        Me.label233.TabIndex = 75
        Me.label233.Text = "RA For"
        Me.label233.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl104
        '
        Me.Lbl104.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl104.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl104.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl104.ForeColor = System.Drawing.Color.Red
        Me.Lbl104.Location = New System.Drawing.Point(308, 8)
        Me.Lbl104.Name = "Lbl104"
        Me.Lbl104.Size = New System.Drawing.Size(74, 29)
        Me.Lbl104.TabIndex = 74
        Me.Lbl104.Text = "Returns RT"
        Me.Lbl104.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Num163
        '
        Me.Num163.BackColor = System.Drawing.SystemColors.Control
        Me.Num163.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num163.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num163.DecimalDigits = 2
        Me.Num163.DefaultSendValue = False
        Me.Num163.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num163.FireTabAfterEnter = True
        Me.Num163.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num163.Image = CType(resources.GetObject("Num163.Image"), System.Drawing.Image)
        Me.Num163.Location = New System.Drawing.Point(233, 163)
        Me.Num163.Maxlength = 10
        Me.Num163.MinusColor = System.Drawing.Color.Empty
        Me.Num163.Name = "Num163"
        Me.Num163.ReadOnly = True
        Me.Num163.Size = New System.Drawing.Size(74, 21)
        Me.Num163.TabIndex = 73
        Me.Num163.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num163.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num153
        '
        Me.Num153.BackColor = System.Drawing.SystemColors.Control
        Me.Num153.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num153.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num153.DecimalDigits = 2
        Me.Num153.DefaultSendValue = False
        Me.Num153.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num153.FireTabAfterEnter = True
        Me.Num153.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num153.Image = CType(resources.GetObject("Num153.Image"), System.Drawing.Image)
        Me.Num153.Location = New System.Drawing.Point(233, 138)
        Me.Num153.Maxlength = 10
        Me.Num153.MinusColor = System.Drawing.Color.Empty
        Me.Num153.Name = "Num153"
        Me.Num153.ReadOnly = True
        Me.Num153.Size = New System.Drawing.Size(74, 21)
        Me.Num153.TabIndex = 72
        Me.Num153.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num153.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num143
        '
        Me.Num143.BackColor = System.Drawing.Color.Gold
        Me.Num143.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num143.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num143.DecimalDigits = 2
        Me.Num143.DefaultSendValue = False
        Me.Num143.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num143.FireTabAfterEnter = True
        Me.Num143.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num143.Image = CType(resources.GetObject("Num143.Image"), System.Drawing.Image)
        Me.Num143.Location = New System.Drawing.Point(233, 113)
        Me.Num143.Maxlength = 10
        Me.Num143.MinusColor = System.Drawing.Color.Empty
        Me.Num143.Name = "Num143"
        Me.Num143.ReadOnly = True
        Me.Num143.Size = New System.Drawing.Size(74, 21)
        Me.Num143.TabIndex = 71
        Me.Num143.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num143.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num133
        '
        Me.Num133.BackColor = System.Drawing.Color.Black
        Me.Num133.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num133.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num133.DecimalDigits = 2
        Me.Num133.DefaultSendValue = False
        Me.Num133.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num133.FireTabAfterEnter = True
        Me.Num133.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num133.Image = CType(resources.GetObject("Num133.Image"), System.Drawing.Image)
        Me.Num133.Location = New System.Drawing.Point(233, 88)
        Me.Num133.Maxlength = 10
        Me.Num133.MinusColor = System.Drawing.Color.Empty
        Me.Num133.Name = "Num133"
        Me.Num133.ReadOnly = True
        Me.Num133.Size = New System.Drawing.Size(74, 21)
        Me.Num133.TabIndex = 70
        Me.Num133.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num133.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num123
        '
        Me.Num123.BackColor = System.Drawing.SystemColors.Control
        Me.Num123.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num123.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num123.DecimalDigits = 2
        Me.Num123.DefaultSendValue = False
        Me.Num123.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num123.FireTabAfterEnter = True
        Me.Num123.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num123.Image = CType(resources.GetObject("Num123.Image"), System.Drawing.Image)
        Me.Num123.Location = New System.Drawing.Point(233, 63)
        Me.Num123.Maxlength = 10
        Me.Num123.MinusColor = System.Drawing.Color.Empty
        Me.Num123.Name = "Num123"
        Me.Num123.ReadOnly = True
        Me.Num123.Size = New System.Drawing.Size(74, 21)
        Me.Num123.TabIndex = 69
        Me.Num123.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num123.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num113
        '
        Me.Num113.BackColor = System.Drawing.SystemColors.Control
        Me.Num113.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num113.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num113.DecimalDigits = 2
        Me.Num113.DefaultSendValue = False
        Me.Num113.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num113.FireTabAfterEnter = True
        Me.Num113.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num113.Image = CType(resources.GetObject("Num113.Image"), System.Drawing.Image)
        Me.Num113.Location = New System.Drawing.Point(233, 38)
        Me.Num113.Maxlength = 10
        Me.Num113.MinusColor = System.Drawing.Color.Empty
        Me.Num113.Name = "Num113"
        Me.Num113.ReadOnly = True
        Me.Num113.Size = New System.Drawing.Size(74, 21)
        Me.Num113.TabIndex = 68
        Me.Num113.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num113.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num162
        '
        Me.Num162.BackColor = System.Drawing.SystemColors.Control
        Me.Num162.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num162.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num162.DecimalDigits = 2
        Me.Num162.DefaultSendValue = False
        Me.Num162.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num162.FireTabAfterEnter = True
        Me.Num162.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num162.Image = CType(resources.GetObject("Num162.Image"), System.Drawing.Image)
        Me.Num162.Location = New System.Drawing.Point(158, 163)
        Me.Num162.Maxlength = 10
        Me.Num162.MinusColor = System.Drawing.Color.Empty
        Me.Num162.Name = "Num162"
        Me.Num162.ReadOnly = True
        Me.Num162.Size = New System.Drawing.Size(74, 21)
        Me.Num162.TabIndex = 67
        Me.Num162.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num162.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num152
        '
        Me.Num152.BackColor = System.Drawing.SystemColors.Control
        Me.Num152.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num152.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num152.DecimalDigits = 2
        Me.Num152.DefaultSendValue = False
        Me.Num152.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num152.FireTabAfterEnter = True
        Me.Num152.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num152.Image = CType(resources.GetObject("Num152.Image"), System.Drawing.Image)
        Me.Num152.Location = New System.Drawing.Point(158, 138)
        Me.Num152.Maxlength = 10
        Me.Num152.MinusColor = System.Drawing.Color.Empty
        Me.Num152.Name = "Num152"
        Me.Num152.ReadOnly = True
        Me.Num152.Size = New System.Drawing.Size(74, 21)
        Me.Num152.TabIndex = 66
        Me.Num152.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num152.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num142
        '
        Me.Num142.BackColor = System.Drawing.Color.Gold
        Me.Num142.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num142.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num142.DecimalDigits = 2
        Me.Num142.DefaultSendValue = False
        Me.Num142.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num142.FireTabAfterEnter = True
        Me.Num142.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num142.Image = CType(resources.GetObject("Num142.Image"), System.Drawing.Image)
        Me.Num142.Location = New System.Drawing.Point(158, 113)
        Me.Num142.Maxlength = 10
        Me.Num142.MinusColor = System.Drawing.Color.Empty
        Me.Num142.Name = "Num142"
        Me.Num142.ReadOnly = True
        Me.Num142.Size = New System.Drawing.Size(74, 21)
        Me.Num142.TabIndex = 65
        Me.Num142.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num142.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num132
        '
        Me.Num132.BackColor = System.Drawing.SystemColors.Control
        Me.Num132.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num132.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num132.DecimalDigits = 2
        Me.Num132.DefaultSendValue = False
        Me.Num132.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num132.FireTabAfterEnter = True
        Me.Num132.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num132.Image = CType(resources.GetObject("Num132.Image"), System.Drawing.Image)
        Me.Num132.Location = New System.Drawing.Point(158, 88)
        Me.Num132.Maxlength = 10
        Me.Num132.MinusColor = System.Drawing.Color.Empty
        Me.Num132.Name = "Num132"
        Me.Num132.ReadOnly = True
        Me.Num132.Size = New System.Drawing.Size(74, 21)
        Me.Num132.TabIndex = 64
        Me.Num132.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num132.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num122
        '
        Me.Num122.BackColor = System.Drawing.SystemColors.Control
        Me.Num122.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num122.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num122.DecimalDigits = 2
        Me.Num122.DefaultSendValue = False
        Me.Num122.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num122.FireTabAfterEnter = True
        Me.Num122.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num122.Image = CType(resources.GetObject("Num122.Image"), System.Drawing.Image)
        Me.Num122.Location = New System.Drawing.Point(158, 63)
        Me.Num122.Maxlength = 10
        Me.Num122.MinusColor = System.Drawing.Color.Empty
        Me.Num122.Name = "Num122"
        Me.Num122.ReadOnly = True
        Me.Num122.Size = New System.Drawing.Size(74, 21)
        Me.Num122.TabIndex = 63
        Me.Num122.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num122.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num112
        '
        Me.Num112.BackColor = System.Drawing.SystemColors.Control
        Me.Num112.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num112.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num112.DecimalDigits = 2
        Me.Num112.DefaultSendValue = False
        Me.Num112.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num112.FireTabAfterEnter = True
        Me.Num112.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num112.Image = CType(resources.GetObject("Num112.Image"), System.Drawing.Image)
        Me.Num112.Location = New System.Drawing.Point(158, 38)
        Me.Num112.Maxlength = 10
        Me.Num112.MinusColor = System.Drawing.Color.Empty
        Me.Num112.Name = "Num112"
        Me.Num112.ReadOnly = True
        Me.Num112.Size = New System.Drawing.Size(74, 21)
        Me.Num112.TabIndex = 62
        Me.Num112.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num112.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num161
        '
        Me.Num161.BackColor = System.Drawing.SystemColors.Control
        Me.Num161.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num161.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num161.DecimalDigits = 2
        Me.Num161.DefaultSendValue = False
        Me.Num161.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num161.FireTabAfterEnter = True
        Me.Num161.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num161.Image = CType(resources.GetObject("Num161.Image"), System.Drawing.Image)
        Me.Num161.Location = New System.Drawing.Point(83, 163)
        Me.Num161.Maxlength = 10
        Me.Num161.MinusColor = System.Drawing.Color.Empty
        Me.Num161.Name = "Num161"
        Me.Num161.ReadOnly = True
        Me.Num161.Size = New System.Drawing.Size(74, 21)
        Me.Num161.TabIndex = 61
        Me.Num161.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num161.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num151
        '
        Me.Num151.BackColor = System.Drawing.SystemColors.Control
        Me.Num151.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num151.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num151.DecimalDigits = 2
        Me.Num151.DefaultSendValue = False
        Me.Num151.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num151.FireTabAfterEnter = True
        Me.Num151.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num151.Image = CType(resources.GetObject("Num151.Image"), System.Drawing.Image)
        Me.Num151.Location = New System.Drawing.Point(83, 138)
        Me.Num151.Maxlength = 10
        Me.Num151.MinusColor = System.Drawing.Color.Empty
        Me.Num151.Name = "Num151"
        Me.Num151.ReadOnly = True
        Me.Num151.Size = New System.Drawing.Size(74, 21)
        Me.Num151.TabIndex = 60
        Me.Num151.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num151.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num141
        '
        Me.Num141.BackColor = System.Drawing.Color.Gold
        Me.Num141.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num141.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num141.DecimalDigits = 2
        Me.Num141.DefaultSendValue = False
        Me.Num141.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num141.FireTabAfterEnter = True
        Me.Num141.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num141.Image = CType(resources.GetObject("Num141.Image"), System.Drawing.Image)
        Me.Num141.Location = New System.Drawing.Point(83, 113)
        Me.Num141.Maxlength = 10
        Me.Num141.MinusColor = System.Drawing.Color.Empty
        Me.Num141.Name = "Num141"
        Me.Num141.ReadOnly = True
        Me.Num141.Size = New System.Drawing.Size(74, 21)
        Me.Num141.TabIndex = 59
        Me.Num141.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num141.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num131
        '
        Me.Num131.BackColor = System.Drawing.SystemColors.Control
        Me.Num131.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num131.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num131.DecimalDigits = 2
        Me.Num131.DefaultSendValue = False
        Me.Num131.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num131.FireTabAfterEnter = True
        Me.Num131.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num131.Image = CType(resources.GetObject("Num131.Image"), System.Drawing.Image)
        Me.Num131.Location = New System.Drawing.Point(83, 88)
        Me.Num131.Maxlength = 10
        Me.Num131.MinusColor = System.Drawing.Color.Empty
        Me.Num131.Name = "Num131"
        Me.Num131.ReadOnly = True
        Me.Num131.Size = New System.Drawing.Size(74, 21)
        Me.Num131.TabIndex = 58
        Me.Num131.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num131.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num121
        '
        Me.Num121.BackColor = System.Drawing.SystemColors.Control
        Me.Num121.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num121.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num121.DecimalDigits = 2
        Me.Num121.DefaultSendValue = False
        Me.Num121.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num121.FireTabAfterEnter = True
        Me.Num121.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num121.Image = CType(resources.GetObject("Num121.Image"), System.Drawing.Image)
        Me.Num121.Location = New System.Drawing.Point(83, 63)
        Me.Num121.Maxlength = 10
        Me.Num121.MinusColor = System.Drawing.Color.Empty
        Me.Num121.Name = "Num121"
        Me.Num121.ReadOnly = True
        Me.Num121.Size = New System.Drawing.Size(74, 21)
        Me.Num121.TabIndex = 57
        Me.Num121.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num121.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num111
        '
        Me.Num111.BackColor = System.Drawing.SystemColors.Control
        Me.Num111.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num111.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num111.DecimalDigits = 2
        Me.Num111.DefaultSendValue = False
        Me.Num111.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num111.FireTabAfterEnter = True
        Me.Num111.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num111.Image = CType(resources.GetObject("Num111.Image"), System.Drawing.Image)
        Me.Num111.Location = New System.Drawing.Point(83, 38)
        Me.Num111.Maxlength = 10
        Me.Num111.MinusColor = System.Drawing.Color.Empty
        Me.Num111.Name = "Num111"
        Me.Num111.ReadOnly = True
        Me.Num111.Size = New System.Drawing.Size(74, 21)
        Me.Num111.TabIndex = 56
        Me.Num111.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num111.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Lbl103
        '
        Me.Lbl103.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl103.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl103.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl103.Location = New System.Drawing.Point(233, 8)
        Me.Lbl103.Name = "Lbl103"
        Me.Lbl103.Size = New System.Drawing.Size(74, 29)
        Me.Lbl103.TabIndex = 55
        Me.Lbl103.Text = "Others OR"
        Me.Lbl103.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl102
        '
        Me.Lbl102.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl102.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl102.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl102.Location = New System.Drawing.Point(158, 8)
        Me.Lbl102.Name = "Lbl102"
        Me.Lbl102.Size = New System.Drawing.Size(74, 29)
        Me.Lbl102.TabIndex = 54
        Me.Lbl102.Text = "Receipts RA"
        Me.Lbl102.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl101
        '
        Me.Lbl101.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl101.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl101.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl101.Location = New System.Drawing.Point(83, 8)
        Me.Lbl101.Name = "Lbl101"
        Me.Lbl101.Size = New System.Drawing.Size(74, 29)
        Me.Lbl101.TabIndex = 53
        Me.Lbl101.Text = "Invoices IN"
        Me.Lbl101.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCC2
        '
        Me.LblCC2.BackColor = System.Drawing.SystemColors.Control
        Me.LblCC2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCC2.Location = New System.Drawing.Point(1, 162)
        Me.LblCC2.Name = "LblCC2"
        Me.LblCC2.Size = New System.Drawing.Size(80, 24)
        Me.LblCC2.TabIndex = 52
        Me.LblCC2.Text = "AMEX"
        Me.LblCC2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCC1
        '
        Me.LblCC1.BackColor = System.Drawing.SystemColors.Control
        Me.LblCC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCC1.Location = New System.Drawing.Point(1, 137)
        Me.LblCC1.Name = "LblCC1"
        Me.LblCC1.Size = New System.Drawing.Size(80, 24)
        Me.LblCC1.TabIndex = 51
        Me.LblCC1.Text = "Visa/MC"
        Me.LblCC1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl114
        '
        Me.Lbl114.BackColor = System.Drawing.Color.YellowGreen
        Me.Lbl114.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl114.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl114.Location = New System.Drawing.Point(1, 113)
        Me.Lbl114.Name = "Lbl114"
        Me.Lbl114.Size = New System.Drawing.Size(80, 23)
        Me.Lbl114.TabIndex = 50
        Me.Lbl114.Text = "Total"
        Me.Lbl114.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl113
        '
        Me.Lbl113.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl113.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl113.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl113.Location = New System.Drawing.Point(1, 87)
        Me.Lbl113.Name = "Lbl113"
        Me.Lbl113.Size = New System.Drawing.Size(80, 24)
        Me.Lbl113.TabIndex = 49
        Me.Lbl113.Text = "Credit Cards"
        Me.Lbl113.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl112
        '
        Me.Lbl112.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl112.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl112.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl112.ForeColor = System.Drawing.Color.Black
        Me.Lbl112.Location = New System.Drawing.Point(1, 62)
        Me.Lbl112.Name = "Lbl112"
        Me.Lbl112.Size = New System.Drawing.Size(80, 24)
        Me.Lbl112.TabIndex = 48
        Me.Lbl112.Text = "Checks"
        Me.Lbl112.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl111
        '
        Me.Lbl111.BackColor = System.Drawing.SystemColors.Control
        Me.Lbl111.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl111.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl111.ForeColor = System.Drawing.Color.Black
        Me.Lbl111.Location = New System.Drawing.Point(1, 36)
        Me.Lbl111.Name = "Lbl111"
        Me.Lbl111.Size = New System.Drawing.Size(80, 24)
        Me.Lbl111.TabIndex = 47
        Me.Lbl111.Text = "Cash"
        Me.Lbl111.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UiTabPage2
        '
        Me.UiTabPage2.Controls.Add(Me.NumDiscountReturns)
        Me.UiTabPage2.Controls.Add(Me.NumDiscounts)
        Me.UiTabPage2.Controls.Add(Me.LblDiscount)
        Me.UiTabPage2.Controls.Add(Me.NumOtherExemptions)
        Me.UiTabPage2.Controls.Add(Me.LblOtherExemptions)
        Me.UiTabPage2.Controls.Add(Me.NumSalesTax6)
        Me.UiTabPage2.Controls.Add(Me.NumSalesTax1)
        Me.UiTabPage2.Controls.Add(Me.NumSalesTax5)
        Me.UiTabPage2.Controls.Add(Me.NumSalesTax4)
        Me.UiTabPage2.Controls.Add(Me.NumSalesTax3)
        Me.UiTabPage2.Controls.Add(Me.NumSalesTax2)
        Me.UiTabPage2.Controls.Add(Me.Num295)
        Me.UiTabPage2.Controls.Add(Me.Num285)
        Me.UiTabPage2.Controls.Add(Me.Num275)
        Me.UiTabPage2.Controls.Add(Me.Num274)
        Me.UiTabPage2.Controls.Add(Me.Num273)
        Me.UiTabPage2.Controls.Add(Me.Num272)
        Me.UiTabPage2.Controls.Add(Me.Num245)
        Me.UiTabPage2.Controls.Add(Me.Num235)
        Me.UiTabPage2.Controls.Add(Me.Num225)
        Me.UiTabPage2.Controls.Add(Me.Num215)
        Me.UiTabPage2.Controls.Add(Me.Num264)
        Me.UiTabPage2.Controls.Add(Me.Num254)
        Me.UiTabPage2.Controls.Add(Me.Num244)
        Me.UiTabPage2.Controls.Add(Me.Num234)
        Me.UiTabPage2.Controls.Add(Me.Num224)
        Me.UiTabPage2.Controls.Add(Me.Num214)
        Me.UiTabPage2.Controls.Add(Me.Num263)
        Me.UiTabPage2.Controls.Add(Me.Num253)
        Me.UiTabPage2.Controls.Add(Me.Num243)
        Me.UiTabPage2.Controls.Add(Me.Num233)
        Me.UiTabPage2.Controls.Add(Me.Num223)
        Me.UiTabPage2.Controls.Add(Me.Num213)
        Me.UiTabPage2.Controls.Add(Me.Num262)
        Me.UiTabPage2.Controls.Add(Me.Num252)
        Me.UiTabPage2.Controls.Add(Me.Num242)
        Me.UiTabPage2.Controls.Add(Me.Num232)
        Me.UiTabPage2.Controls.Add(Me.Num222)
        Me.UiTabPage2.Controls.Add(Me.Num212)
        Me.UiTabPage2.Controls.Add(Me.Num291)
        Me.UiTabPage2.Controls.Add(Me.Num281)
        Me.UiTabPage2.Controls.Add(Me.Num271)
        Me.UiTabPage2.Controls.Add(Me.Num261)
        Me.UiTabPage2.Controls.Add(Me.Num251)
        Me.UiTabPage2.Controls.Add(Me.Num241)
        Me.UiTabPage2.Controls.Add(Me.Num231)
        Me.UiTabPage2.Controls.Add(Me.Num221)
        Me.UiTabPage2.Controls.Add(Me.Num211)
        Me.UiTabPage2.Controls.Add(Me.Lbl194)
        Me.UiTabPage2.Controls.Add(Me.Lbl184)
        Me.UiTabPage2.Controls.Add(Me.Lbl165)
        Me.UiTabPage2.Controls.Add(Me.Lbl205)
        Me.UiTabPage2.Controls.Add(Me.Lbl204)
        Me.UiTabPage2.Controls.Add(Me.Lbl203)
        Me.UiTabPage2.Controls.Add(Me.Lbl202)
        Me.UiTabPage2.Controls.Add(Me.Lbl201)
        Me.UiTabPage2.Controls.Add(Me.LblSalesTax6)
        Me.UiTabPage2.Controls.Add(Me.LblSalesTax5)
        Me.UiTabPage2.Controls.Add(Me.LblSalesTax4)
        Me.UiTabPage2.Controls.Add(Me.LblSalesTax3)
        Me.UiTabPage2.Controls.Add(Me.LblSalesTax2)
        Me.UiTabPage2.Controls.Add(Me.LblSalesTax1)
        Me.UiTabPage2.Controls.Add(Me.Lbl219)
        Me.UiTabPage2.Controls.Add(Me.Lbl218)
        Me.UiTabPage2.Controls.Add(Me.Lbl217)
        Me.UiTabPage2.Controls.Add(Me.Lbl216)
        Me.UiTabPage2.Controls.Add(Me.Lbl215)
        Me.UiTabPage2.Controls.Add(Me.Lbl214)
        Me.UiTabPage2.Controls.Add(Me.Lbl213)
        Me.UiTabPage2.Controls.Add(Me.Lbl212)
        Me.UiTabPage2.Controls.Add(Me.Lbl211)
        Me.UiTabPage2.Controls.Add(Me.Label2)
        Me.UiTabPage2.Controls.Add(Me.Label16)
        Me.UiTabPage2.Controls.Add(Me.LblReturnDiscount)
        Me.UiTabPage2.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage2.Name = "UiTabPage2"
        Me.UiTabPage2.Size = New System.Drawing.Size(684, 298)
        Me.UiTabPage2.TabIndex = 1
        Me.UiTabPage2.Text = "Sales"
        '
        'NumDiscountReturns
        '
        Me.NumDiscountReturns.BackColor = System.Drawing.Color.Gold
        Me.NumDiscountReturns.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDiscountReturns.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumDiscountReturns.DecimalDigits = 2
        Me.NumDiscountReturns.DefaultSendValue = False
        Me.NumDiscountReturns.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDiscountReturns.FireTabAfterEnter = True
        Me.NumDiscountReturns.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumDiscountReturns.ForeColor = System.Drawing.Color.Red
        Me.NumDiscountReturns.Image = CType(resources.GetObject("NumDiscountReturns.Image"), System.Drawing.Image)
        Me.NumDiscountReturns.Location = New System.Drawing.Point(526, 184)
        Me.NumDiscountReturns.Maxlength = 10
        Me.NumDiscountReturns.MinusColor = System.Drawing.Color.Empty
        Me.NumDiscountReturns.Name = "NumDiscountReturns"
        Me.NumDiscountReturns.ReadOnly = True
        Me.NumDiscountReturns.Size = New System.Drawing.Size(89, 21)
        Me.NumDiscountReturns.TabIndex = 75
        Me.NumDiscountReturns.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDiscountReturns.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumDiscounts
        '
        Me.NumDiscounts.BackColor = System.Drawing.Color.Gold
        Me.NumDiscounts.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumDiscounts.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumDiscounts.DecimalDigits = 2
        Me.NumDiscounts.DefaultSendValue = False
        Me.NumDiscounts.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDiscounts.FireTabAfterEnter = True
        Me.NumDiscounts.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumDiscounts.ForeColor = System.Drawing.Color.Red
        Me.NumDiscounts.Image = CType(resources.GetObject("NumDiscounts.Image"), System.Drawing.Image)
        Me.NumDiscounts.Location = New System.Drawing.Point(127, 184)
        Me.NumDiscounts.Maxlength = 10
        Me.NumDiscounts.MinusColor = System.Drawing.Color.Empty
        Me.NumDiscounts.Name = "NumDiscounts"
        Me.NumDiscounts.ReadOnly = True
        Me.NumDiscounts.Size = New System.Drawing.Size(89, 21)
        Me.NumDiscounts.TabIndex = 74
        Me.NumDiscounts.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDiscounts.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblDiscount
        '
        Me.LblDiscount.BackColor = System.Drawing.Color.Transparent
        Me.LblDiscount.Location = New System.Drawing.Point(52, 183)
        Me.LblDiscount.Name = "LblDiscount"
        Me.LblDiscount.Size = New System.Drawing.Size(72, 23)
        Me.LblDiscount.TabIndex = 72
        Me.LblDiscount.Text = "Discounts"
        Me.LblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumOtherExemptions
        '
        Me.NumOtherExemptions.BackColor = System.Drawing.Color.Gold
        Me.NumOtherExemptions.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumOtherExemptions.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumOtherExemptions.DecimalDigits = 2
        Me.NumOtherExemptions.DefaultSendValue = False
        Me.NumOtherExemptions.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumOtherExemptions.FireTabAfterEnter = True
        Me.NumOtherExemptions.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumOtherExemptions.Image = CType(resources.GetObject("NumOtherExemptions.Image"), System.Drawing.Image)
        Me.NumOtherExemptions.Location = New System.Drawing.Point(310, 274)
        Me.NumOtherExemptions.Maxlength = 10
        Me.NumOtherExemptions.MinusColor = System.Drawing.Color.Empty
        Me.NumOtherExemptions.Name = "NumOtherExemptions"
        Me.NumOtherExemptions.ReadOnly = True
        Me.NumOtherExemptions.Size = New System.Drawing.Size(89, 21)
        Me.NumOtherExemptions.TabIndex = 69
        Me.NumOtherExemptions.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumOtherExemptions.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblOtherExemptions
        '
        Me.LblOtherExemptions.BackColor = System.Drawing.Color.Transparent
        Me.LblOtherExemptions.Location = New System.Drawing.Point(306, 252)
        Me.LblOtherExemptions.Name = "LblOtherExemptions"
        Me.LblOtherExemptions.Size = New System.Drawing.Size(95, 23)
        Me.LblOtherExemptions.TabIndex = 68
        Me.LblOtherExemptions.Text = "Other Exemptions"
        Me.LblOtherExemptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumSalesTax6
        '
        Me.NumSalesTax6.BackColor = System.Drawing.Color.YellowGreen
        Me.NumSalesTax6.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumSalesTax6.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumSalesTax6.DecimalDigits = 2
        Me.NumSalesTax6.DefaultSendValue = False
        Me.NumSalesTax6.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumSalesTax6.FireTabAfterEnter = True
        Me.NumSalesTax6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumSalesTax6.Image = CType(resources.GetObject("NumSalesTax6.Image"), System.Drawing.Image)
        Me.NumSalesTax6.Location = New System.Drawing.Point(586, 275)
        Me.NumSalesTax6.Maxlength = 10
        Me.NumSalesTax6.MinusColor = System.Drawing.Color.Empty
        Me.NumSalesTax6.Name = "NumSalesTax6"
        Me.NumSalesTax6.ReadOnly = True
        Me.NumSalesTax6.Size = New System.Drawing.Size(89, 21)
        Me.NumSalesTax6.TabIndex = 67
        Me.NumSalesTax6.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumSalesTax6.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumSalesTax1
        '
        Me.NumSalesTax1.BackColor = System.Drawing.Color.YellowGreen
        Me.NumSalesTax1.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumSalesTax1.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumSalesTax1.DecimalDigits = 2
        Me.NumSalesTax1.DefaultSendValue = False
        Me.NumSalesTax1.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumSalesTax1.FireTabAfterEnter = True
        Me.NumSalesTax1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumSalesTax1.Image = CType(resources.GetObject("NumSalesTax1.Image"), System.Drawing.Image)
        Me.NumSalesTax1.Location = New System.Drawing.Point(34, 274)
        Me.NumSalesTax1.Maxlength = 10
        Me.NumSalesTax1.MinusColor = System.Drawing.Color.Empty
        Me.NumSalesTax1.Name = "NumSalesTax1"
        Me.NumSalesTax1.ReadOnly = True
        Me.NumSalesTax1.Size = New System.Drawing.Size(89, 21)
        Me.NumSalesTax1.TabIndex = 66
        Me.NumSalesTax1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumSalesTax1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumSalesTax5
        '
        Me.NumSalesTax5.BackColor = System.Drawing.Color.Gold
        Me.NumSalesTax5.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumSalesTax5.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumSalesTax5.DecimalDigits = 2
        Me.NumSalesTax5.DefaultSendValue = False
        Me.NumSalesTax5.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumSalesTax5.FireTabAfterEnter = True
        Me.NumSalesTax5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumSalesTax5.Image = CType(resources.GetObject("NumSalesTax5.Image"), System.Drawing.Image)
        Me.NumSalesTax5.Location = New System.Drawing.Point(494, 275)
        Me.NumSalesTax5.Maxlength = 10
        Me.NumSalesTax5.MinusColor = System.Drawing.Color.Empty
        Me.NumSalesTax5.Name = "NumSalesTax5"
        Me.NumSalesTax5.ReadOnly = True
        Me.NumSalesTax5.Size = New System.Drawing.Size(89, 21)
        Me.NumSalesTax5.TabIndex = 65
        Me.NumSalesTax5.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumSalesTax5.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumSalesTax4
        '
        Me.NumSalesTax4.BackColor = System.Drawing.Color.Gold
        Me.NumSalesTax4.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumSalesTax4.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumSalesTax4.DecimalDigits = 2
        Me.NumSalesTax4.DefaultSendValue = False
        Me.NumSalesTax4.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumSalesTax4.FireTabAfterEnter = True
        Me.NumSalesTax4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumSalesTax4.Image = CType(resources.GetObject("NumSalesTax4.Image"), System.Drawing.Image)
        Me.NumSalesTax4.Location = New System.Drawing.Point(402, 274)
        Me.NumSalesTax4.Maxlength = 10
        Me.NumSalesTax4.MinusColor = System.Drawing.Color.Empty
        Me.NumSalesTax4.Name = "NumSalesTax4"
        Me.NumSalesTax4.ReadOnly = True
        Me.NumSalesTax4.Size = New System.Drawing.Size(89, 21)
        Me.NumSalesTax4.TabIndex = 64
        Me.NumSalesTax4.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumSalesTax4.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumSalesTax3
        '
        Me.NumSalesTax3.BackColor = System.Drawing.Color.Gold
        Me.NumSalesTax3.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumSalesTax3.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumSalesTax3.DecimalDigits = 2
        Me.NumSalesTax3.DefaultSendValue = False
        Me.NumSalesTax3.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumSalesTax3.FireTabAfterEnter = True
        Me.NumSalesTax3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumSalesTax3.Image = CType(resources.GetObject("NumSalesTax3.Image"), System.Drawing.Image)
        Me.NumSalesTax3.Location = New System.Drawing.Point(218, 274)
        Me.NumSalesTax3.Maxlength = 10
        Me.NumSalesTax3.MinusColor = System.Drawing.Color.Empty
        Me.NumSalesTax3.Name = "NumSalesTax3"
        Me.NumSalesTax3.ReadOnly = True
        Me.NumSalesTax3.Size = New System.Drawing.Size(89, 21)
        Me.NumSalesTax3.TabIndex = 63
        Me.NumSalesTax3.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumSalesTax3.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumSalesTax2
        '
        Me.NumSalesTax2.BackColor = System.Drawing.Color.Gold
        Me.NumSalesTax2.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumSalesTax2.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumSalesTax2.DecimalDigits = 2
        Me.NumSalesTax2.DefaultSendValue = False
        Me.NumSalesTax2.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumSalesTax2.FireTabAfterEnter = True
        Me.NumSalesTax2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumSalesTax2.Image = CType(resources.GetObject("NumSalesTax2.Image"), System.Drawing.Image)
        Me.NumSalesTax2.Location = New System.Drawing.Point(126, 274)
        Me.NumSalesTax2.Maxlength = 10
        Me.NumSalesTax2.MinusColor = System.Drawing.Color.Empty
        Me.NumSalesTax2.Name = "NumSalesTax2"
        Me.NumSalesTax2.ReadOnly = True
        Me.NumSalesTax2.Size = New System.Drawing.Size(89, 21)
        Me.NumSalesTax2.TabIndex = 62
        Me.NumSalesTax2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumSalesTax2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num295
        '
        Me.Num295.BackColor = System.Drawing.Color.YellowGreen
        Me.Num295.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num295.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num295.DecimalDigits = 2
        Me.Num295.DefaultSendValue = False
        Me.Num295.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num295.FireTabAfterEnter = True
        Me.Num295.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num295.ForeColor = System.Drawing.Color.Red
        Me.Num295.Image = CType(resources.GetObject("Num295.Image"), System.Drawing.Image)
        Me.Num295.Location = New System.Drawing.Point(526, 230)
        Me.Num295.Maxlength = 10
        Me.Num295.MinusColor = System.Drawing.Color.Empty
        Me.Num295.Name = "Num295"
        Me.Num295.ReadOnly = True
        Me.Num295.Size = New System.Drawing.Size(89, 21)
        Me.Num295.TabIndex = 61
        Me.Num295.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num295.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num285
        '
        Me.Num285.BackColor = System.Drawing.Color.Gold
        Me.Num285.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num285.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num285.DecimalDigits = 2
        Me.Num285.DefaultSendValue = False
        Me.Num285.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num285.FireTabAfterEnter = True
        Me.Num285.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num285.ForeColor = System.Drawing.Color.Red
        Me.Num285.Image = CType(resources.GetObject("Num285.Image"), System.Drawing.Image)
        Me.Num285.Location = New System.Drawing.Point(526, 207)
        Me.Num285.Maxlength = 10
        Me.Num285.MinusColor = System.Drawing.Color.Empty
        Me.Num285.Name = "Num285"
        Me.Num285.ReadOnly = True
        Me.Num285.Size = New System.Drawing.Size(89, 21)
        Me.Num285.TabIndex = 60
        Me.Num285.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num285.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num275
        '
        Me.Num275.BackColor = System.Drawing.Color.YellowGreen
        Me.Num275.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num275.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num275.DecimalDigits = 2
        Me.Num275.DefaultSendValue = False
        Me.Num275.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num275.FireTabAfterEnter = True
        Me.Num275.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num275.ForeColor = System.Drawing.Color.Red
        Me.Num275.Image = CType(resources.GetObject("Num275.Image"), System.Drawing.Image)
        Me.Num275.Location = New System.Drawing.Point(526, 161)
        Me.Num275.Maxlength = 10
        Me.Num275.MinusColor = System.Drawing.Color.Empty
        Me.Num275.Name = "Num275"
        Me.Num275.ReadOnly = True
        Me.Num275.Size = New System.Drawing.Size(89, 21)
        Me.Num275.TabIndex = 59
        Me.Num275.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num275.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num274
        '
        Me.Num274.BackColor = System.Drawing.Color.YellowGreen
        Me.Num274.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num274.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num274.DecimalDigits = 2
        Me.Num274.DefaultSendValue = False
        Me.Num274.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num274.FireTabAfterEnter = True
        Me.Num274.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num274.Image = CType(resources.GetObject("Num274.Image"), System.Drawing.Image)
        Me.Num274.Location = New System.Drawing.Point(406, 161)
        Me.Num274.Maxlength = 10
        Me.Num274.MinusColor = System.Drawing.Color.Empty
        Me.Num274.Name = "Num274"
        Me.Num274.ReadOnly = True
        Me.Num274.Size = New System.Drawing.Size(89, 21)
        Me.Num274.TabIndex = 58
        Me.Num274.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num274.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num273
        '
        Me.Num273.BackColor = System.Drawing.Color.YellowGreen
        Me.Num273.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num273.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num273.DecimalDigits = 2
        Me.Num273.DefaultSendValue = False
        Me.Num273.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num273.FireTabAfterEnter = True
        Me.Num273.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num273.Image = CType(resources.GetObject("Num273.Image"), System.Drawing.Image)
        Me.Num273.Location = New System.Drawing.Point(313, 161)
        Me.Num273.Maxlength = 10
        Me.Num273.MinusColor = System.Drawing.Color.Empty
        Me.Num273.Name = "Num273"
        Me.Num273.ReadOnly = True
        Me.Num273.Size = New System.Drawing.Size(89, 21)
        Me.Num273.TabIndex = 57
        Me.Num273.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num273.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num272
        '
        Me.Num272.BackColor = System.Drawing.Color.YellowGreen
        Me.Num272.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num272.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num272.DecimalDigits = 2
        Me.Num272.DefaultSendValue = False
        Me.Num272.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num272.FireTabAfterEnter = True
        Me.Num272.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num272.Image = CType(resources.GetObject("Num272.Image"), System.Drawing.Image)
        Me.Num272.Location = New System.Drawing.Point(220, 161)
        Me.Num272.Maxlength = 10
        Me.Num272.MinusColor = System.Drawing.Color.Empty
        Me.Num272.Name = "Num272"
        Me.Num272.ReadOnly = True
        Me.Num272.Size = New System.Drawing.Size(89, 21)
        Me.Num272.TabIndex = 56
        Me.Num272.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num272.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num245
        '
        Me.Num245.BackColor = System.Drawing.Color.Gold
        Me.Num245.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num245.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num245.DecimalDigits = 2
        Me.Num245.DefaultSendValue = False
        Me.Num245.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num245.FireTabAfterEnter = True
        Me.Num245.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num245.ForeColor = System.Drawing.Color.Red
        Me.Num245.Image = CType(resources.GetObject("Num245.Image"), System.Drawing.Image)
        Me.Num245.Location = New System.Drawing.Point(525, 93)
        Me.Num245.Maxlength = 10
        Me.Num245.MinusColor = System.Drawing.Color.Empty
        Me.Num245.Name = "Num245"
        Me.Num245.ReadOnly = True
        Me.Num245.Size = New System.Drawing.Size(89, 21)
        Me.Num245.TabIndex = 55
        Me.Num245.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num245.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num235
        '
        Me.Num235.BackColor = System.Drawing.Color.Gold
        Me.Num235.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num235.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num235.DecimalDigits = 2
        Me.Num235.DefaultSendValue = False
        Me.Num235.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num235.FireTabAfterEnter = True
        Me.Num235.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num235.ForeColor = System.Drawing.Color.Red
        Me.Num235.Image = CType(resources.GetObject("Num235.Image"), System.Drawing.Image)
        Me.Num235.Location = New System.Drawing.Point(525, 70)
        Me.Num235.Maxlength = 10
        Me.Num235.MinusColor = System.Drawing.Color.Empty
        Me.Num235.Name = "Num235"
        Me.Num235.ReadOnly = True
        Me.Num235.Size = New System.Drawing.Size(89, 21)
        Me.Num235.TabIndex = 54
        Me.Num235.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num235.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num225
        '
        Me.Num225.BackColor = System.Drawing.Color.Gold
        Me.Num225.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num225.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num225.DecimalDigits = 2
        Me.Num225.DefaultSendValue = False
        Me.Num225.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num225.FireTabAfterEnter = True
        Me.Num225.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num225.ForeColor = System.Drawing.Color.Red
        Me.Num225.Image = CType(resources.GetObject("Num225.Image"), System.Drawing.Image)
        Me.Num225.Location = New System.Drawing.Point(525, 47)
        Me.Num225.Maxlength = 10
        Me.Num225.MinusColor = System.Drawing.Color.Empty
        Me.Num225.Name = "Num225"
        Me.Num225.ReadOnly = True
        Me.Num225.Size = New System.Drawing.Size(89, 21)
        Me.Num225.TabIndex = 53
        Me.Num225.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num225.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num215
        '
        Me.Num215.BackColor = System.Drawing.Color.Gold
        Me.Num215.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num215.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num215.DecimalDigits = 2
        Me.Num215.DefaultSendValue = False
        Me.Num215.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num215.FireTabAfterEnter = True
        Me.Num215.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num215.ForeColor = System.Drawing.Color.Red
        Me.Num215.Image = CType(resources.GetObject("Num215.Image"), System.Drawing.Image)
        Me.Num215.Location = New System.Drawing.Point(525, 24)
        Me.Num215.Maxlength = 10
        Me.Num215.MinusColor = System.Drawing.Color.Empty
        Me.Num215.Name = "Num215"
        Me.Num215.ReadOnly = True
        Me.Num215.Size = New System.Drawing.Size(89, 21)
        Me.Num215.TabIndex = 52
        Me.Num215.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num215.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num264
        '
        Me.Num264.BackColor = System.Drawing.Color.Gold
        Me.Num264.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num264.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num264.DecimalDigits = 2
        Me.Num264.DefaultSendValue = False
        Me.Num264.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num264.FireTabAfterEnter = True
        Me.Num264.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num264.Image = CType(resources.GetObject("Num264.Image"), System.Drawing.Image)
        Me.Num264.Location = New System.Drawing.Point(406, 138)
        Me.Num264.Maxlength = 10
        Me.Num264.MinusColor = System.Drawing.Color.Empty
        Me.Num264.Name = "Num264"
        Me.Num264.ReadOnly = True
        Me.Num264.Size = New System.Drawing.Size(89, 21)
        Me.Num264.TabIndex = 51
        Me.Num264.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num264.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num254
        '
        Me.Num254.BackColor = System.Drawing.Color.Gold
        Me.Num254.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num254.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num254.DecimalDigits = 2
        Me.Num254.DefaultSendValue = False
        Me.Num254.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num254.FireTabAfterEnter = True
        Me.Num254.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num254.Image = CType(resources.GetObject("Num254.Image"), System.Drawing.Image)
        Me.Num254.Location = New System.Drawing.Point(406, 115)
        Me.Num254.Maxlength = 10
        Me.Num254.MinusColor = System.Drawing.Color.Empty
        Me.Num254.Name = "Num254"
        Me.Num254.ReadOnly = True
        Me.Num254.Size = New System.Drawing.Size(89, 21)
        Me.Num254.TabIndex = 50
        Me.Num254.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num254.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num244
        '
        Me.Num244.BackColor = System.Drawing.Color.Gold
        Me.Num244.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num244.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num244.DecimalDigits = 2
        Me.Num244.DefaultSendValue = False
        Me.Num244.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num244.FireTabAfterEnter = True
        Me.Num244.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num244.Image = CType(resources.GetObject("Num244.Image"), System.Drawing.Image)
        Me.Num244.Location = New System.Drawing.Point(406, 92)
        Me.Num244.Maxlength = 10
        Me.Num244.MinusColor = System.Drawing.Color.Empty
        Me.Num244.Name = "Num244"
        Me.Num244.ReadOnly = True
        Me.Num244.Size = New System.Drawing.Size(89, 21)
        Me.Num244.TabIndex = 49
        Me.Num244.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num244.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num234
        '
        Me.Num234.BackColor = System.Drawing.Color.Gold
        Me.Num234.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num234.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num234.DecimalDigits = 2
        Me.Num234.DefaultSendValue = False
        Me.Num234.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num234.FireTabAfterEnter = True
        Me.Num234.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num234.Image = CType(resources.GetObject("Num234.Image"), System.Drawing.Image)
        Me.Num234.Location = New System.Drawing.Point(406, 69)
        Me.Num234.Maxlength = 10
        Me.Num234.MinusColor = System.Drawing.Color.Empty
        Me.Num234.Name = "Num234"
        Me.Num234.ReadOnly = True
        Me.Num234.Size = New System.Drawing.Size(89, 21)
        Me.Num234.TabIndex = 48
        Me.Num234.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num234.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num224
        '
        Me.Num224.BackColor = System.Drawing.Color.Gold
        Me.Num224.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num224.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num224.DecimalDigits = 2
        Me.Num224.DefaultSendValue = False
        Me.Num224.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num224.FireTabAfterEnter = True
        Me.Num224.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num224.Image = CType(resources.GetObject("Num224.Image"), System.Drawing.Image)
        Me.Num224.Location = New System.Drawing.Point(406, 46)
        Me.Num224.Maxlength = 10
        Me.Num224.MinusColor = System.Drawing.Color.Empty
        Me.Num224.Name = "Num224"
        Me.Num224.ReadOnly = True
        Me.Num224.Size = New System.Drawing.Size(89, 21)
        Me.Num224.TabIndex = 47
        Me.Num224.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num224.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num214
        '
        Me.Num214.BackColor = System.Drawing.Color.Gold
        Me.Num214.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num214.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num214.DecimalDigits = 2
        Me.Num214.DefaultSendValue = False
        Me.Num214.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num214.FireTabAfterEnter = True
        Me.Num214.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num214.Image = CType(resources.GetObject("Num214.Image"), System.Drawing.Image)
        Me.Num214.Location = New System.Drawing.Point(406, 23)
        Me.Num214.Maxlength = 10
        Me.Num214.MinusColor = System.Drawing.Color.Empty
        Me.Num214.Name = "Num214"
        Me.Num214.ReadOnly = True
        Me.Num214.Size = New System.Drawing.Size(89, 21)
        Me.Num214.TabIndex = 46
        Me.Num214.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num214.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num263
        '
        Me.Num263.BackColor = System.Drawing.Color.Gold
        Me.Num263.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num263.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num263.DecimalDigits = 2
        Me.Num263.DefaultSendValue = False
        Me.Num263.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num263.FireTabAfterEnter = True
        Me.Num263.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num263.Image = CType(resources.GetObject("Num263.Image"), System.Drawing.Image)
        Me.Num263.Location = New System.Drawing.Point(313, 138)
        Me.Num263.Maxlength = 10
        Me.Num263.MinusColor = System.Drawing.Color.Empty
        Me.Num263.Name = "Num263"
        Me.Num263.ReadOnly = True
        Me.Num263.Size = New System.Drawing.Size(89, 21)
        Me.Num263.TabIndex = 45
        Me.Num263.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num263.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num253
        '
        Me.Num253.BackColor = System.Drawing.Color.Gold
        Me.Num253.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num253.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num253.DecimalDigits = 2
        Me.Num253.DefaultSendValue = False
        Me.Num253.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num253.FireTabAfterEnter = True
        Me.Num253.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num253.Image = CType(resources.GetObject("Num253.Image"), System.Drawing.Image)
        Me.Num253.Location = New System.Drawing.Point(313, 115)
        Me.Num253.Maxlength = 10
        Me.Num253.MinusColor = System.Drawing.Color.Empty
        Me.Num253.Name = "Num253"
        Me.Num253.ReadOnly = True
        Me.Num253.Size = New System.Drawing.Size(89, 21)
        Me.Num253.TabIndex = 44
        Me.Num253.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num253.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num243
        '
        Me.Num243.BackColor = System.Drawing.Color.Gold
        Me.Num243.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num243.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num243.DecimalDigits = 2
        Me.Num243.DefaultSendValue = False
        Me.Num243.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num243.FireTabAfterEnter = True
        Me.Num243.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num243.Image = CType(resources.GetObject("Num243.Image"), System.Drawing.Image)
        Me.Num243.Location = New System.Drawing.Point(313, 92)
        Me.Num243.Maxlength = 10
        Me.Num243.MinusColor = System.Drawing.Color.Empty
        Me.Num243.Name = "Num243"
        Me.Num243.ReadOnly = True
        Me.Num243.Size = New System.Drawing.Size(89, 21)
        Me.Num243.TabIndex = 43
        Me.Num243.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num243.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num233
        '
        Me.Num233.BackColor = System.Drawing.Color.Gold
        Me.Num233.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num233.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num233.DecimalDigits = 2
        Me.Num233.DefaultSendValue = False
        Me.Num233.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num233.FireTabAfterEnter = True
        Me.Num233.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num233.Image = CType(resources.GetObject("Num233.Image"), System.Drawing.Image)
        Me.Num233.Location = New System.Drawing.Point(313, 69)
        Me.Num233.Maxlength = 10
        Me.Num233.MinusColor = System.Drawing.Color.Empty
        Me.Num233.Name = "Num233"
        Me.Num233.ReadOnly = True
        Me.Num233.Size = New System.Drawing.Size(89, 21)
        Me.Num233.TabIndex = 42
        Me.Num233.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num233.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num223
        '
        Me.Num223.BackColor = System.Drawing.Color.Gold
        Me.Num223.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num223.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num223.DecimalDigits = 2
        Me.Num223.DefaultSendValue = False
        Me.Num223.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num223.FireTabAfterEnter = True
        Me.Num223.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num223.Image = CType(resources.GetObject("Num223.Image"), System.Drawing.Image)
        Me.Num223.Location = New System.Drawing.Point(313, 46)
        Me.Num223.Maxlength = 10
        Me.Num223.MinusColor = System.Drawing.Color.Empty
        Me.Num223.Name = "Num223"
        Me.Num223.ReadOnly = True
        Me.Num223.Size = New System.Drawing.Size(89, 21)
        Me.Num223.TabIndex = 41
        Me.Num223.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num223.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num213
        '
        Me.Num213.BackColor = System.Drawing.Color.Gold
        Me.Num213.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num213.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num213.DecimalDigits = 2
        Me.Num213.DefaultSendValue = False
        Me.Num213.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num213.FireTabAfterEnter = True
        Me.Num213.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num213.Image = CType(resources.GetObject("Num213.Image"), System.Drawing.Image)
        Me.Num213.Location = New System.Drawing.Point(313, 23)
        Me.Num213.Maxlength = 10
        Me.Num213.MinusColor = System.Drawing.Color.Empty
        Me.Num213.Name = "Num213"
        Me.Num213.ReadOnly = True
        Me.Num213.Size = New System.Drawing.Size(89, 21)
        Me.Num213.TabIndex = 40
        Me.Num213.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num213.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num262
        '
        Me.Num262.BackColor = System.Drawing.Color.Gold
        Me.Num262.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num262.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num262.DecimalDigits = 2
        Me.Num262.DefaultSendValue = False
        Me.Num262.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num262.FireTabAfterEnter = True
        Me.Num262.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num262.Image = CType(resources.GetObject("Num262.Image"), System.Drawing.Image)
        Me.Num262.Location = New System.Drawing.Point(220, 138)
        Me.Num262.Maxlength = 10
        Me.Num262.MinusColor = System.Drawing.Color.Empty
        Me.Num262.Name = "Num262"
        Me.Num262.ReadOnly = True
        Me.Num262.Size = New System.Drawing.Size(89, 21)
        Me.Num262.TabIndex = 39
        Me.Num262.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num262.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num252
        '
        Me.Num252.BackColor = System.Drawing.Color.Gold
        Me.Num252.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num252.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num252.DecimalDigits = 2
        Me.Num252.DefaultSendValue = False
        Me.Num252.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num252.FireTabAfterEnter = True
        Me.Num252.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num252.Image = CType(resources.GetObject("Num252.Image"), System.Drawing.Image)
        Me.Num252.Location = New System.Drawing.Point(220, 115)
        Me.Num252.Maxlength = 10
        Me.Num252.MinusColor = System.Drawing.Color.Empty
        Me.Num252.Name = "Num252"
        Me.Num252.ReadOnly = True
        Me.Num252.Size = New System.Drawing.Size(89, 21)
        Me.Num252.TabIndex = 38
        Me.Num252.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num252.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num242
        '
        Me.Num242.BackColor = System.Drawing.Color.Gold
        Me.Num242.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num242.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num242.DecimalDigits = 2
        Me.Num242.DefaultSendValue = False
        Me.Num242.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num242.FireTabAfterEnter = True
        Me.Num242.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num242.Image = CType(resources.GetObject("Num242.Image"), System.Drawing.Image)
        Me.Num242.Location = New System.Drawing.Point(220, 92)
        Me.Num242.Maxlength = 10
        Me.Num242.MinusColor = System.Drawing.Color.Empty
        Me.Num242.Name = "Num242"
        Me.Num242.ReadOnly = True
        Me.Num242.Size = New System.Drawing.Size(89, 21)
        Me.Num242.TabIndex = 37
        Me.Num242.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num242.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num232
        '
        Me.Num232.BackColor = System.Drawing.Color.Gold
        Me.Num232.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num232.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num232.DecimalDigits = 2
        Me.Num232.DefaultSendValue = False
        Me.Num232.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num232.FireTabAfterEnter = True
        Me.Num232.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num232.Image = CType(resources.GetObject("Num232.Image"), System.Drawing.Image)
        Me.Num232.Location = New System.Drawing.Point(220, 69)
        Me.Num232.Maxlength = 10
        Me.Num232.MinusColor = System.Drawing.Color.Empty
        Me.Num232.Name = "Num232"
        Me.Num232.ReadOnly = True
        Me.Num232.Size = New System.Drawing.Size(89, 21)
        Me.Num232.TabIndex = 36
        Me.Num232.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num232.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num222
        '
        Me.Num222.BackColor = System.Drawing.Color.Gold
        Me.Num222.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num222.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num222.DecimalDigits = 2
        Me.Num222.DefaultSendValue = False
        Me.Num222.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num222.FireTabAfterEnter = True
        Me.Num222.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num222.Image = CType(resources.GetObject("Num222.Image"), System.Drawing.Image)
        Me.Num222.Location = New System.Drawing.Point(220, 46)
        Me.Num222.Maxlength = 10
        Me.Num222.MinusColor = System.Drawing.Color.Empty
        Me.Num222.Name = "Num222"
        Me.Num222.ReadOnly = True
        Me.Num222.Size = New System.Drawing.Size(89, 21)
        Me.Num222.TabIndex = 35
        Me.Num222.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num222.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num212
        '
        Me.Num212.BackColor = System.Drawing.Color.Gold
        Me.Num212.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num212.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num212.DecimalDigits = 2
        Me.Num212.DefaultSendValue = False
        Me.Num212.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num212.FireTabAfterEnter = True
        Me.Num212.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num212.Image = CType(resources.GetObject("Num212.Image"), System.Drawing.Image)
        Me.Num212.Location = New System.Drawing.Point(220, 23)
        Me.Num212.Maxlength = 10
        Me.Num212.MinusColor = System.Drawing.Color.Empty
        Me.Num212.Name = "Num212"
        Me.Num212.ReadOnly = True
        Me.Num212.Size = New System.Drawing.Size(89, 21)
        Me.Num212.TabIndex = 34
        Me.Num212.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num212.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num291
        '
        Me.Num291.BackColor = System.Drawing.Color.YellowGreen
        Me.Num291.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num291.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num291.DecimalDigits = 2
        Me.Num291.DefaultSendValue = False
        Me.Num291.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num291.FireTabAfterEnter = True
        Me.Num291.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num291.Image = CType(resources.GetObject("Num291.Image"), System.Drawing.Image)
        Me.Num291.Location = New System.Drawing.Point(127, 230)
        Me.Num291.Maxlength = 10
        Me.Num291.MinusColor = System.Drawing.Color.Empty
        Me.Num291.Name = "Num291"
        Me.Num291.ReadOnly = True
        Me.Num291.Size = New System.Drawing.Size(89, 21)
        Me.Num291.TabIndex = 33
        Me.Num291.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num291.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num281
        '
        Me.Num281.BackColor = System.Drawing.Color.Gold
        Me.Num281.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num281.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num281.DecimalDigits = 2
        Me.Num281.DefaultSendValue = False
        Me.Num281.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num281.FireTabAfterEnter = True
        Me.Num281.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num281.Image = CType(resources.GetObject("Num281.Image"), System.Drawing.Image)
        Me.Num281.Location = New System.Drawing.Point(127, 207)
        Me.Num281.Maxlength = 10
        Me.Num281.MinusColor = System.Drawing.Color.Empty
        Me.Num281.Name = "Num281"
        Me.Num281.ReadOnly = True
        Me.Num281.Size = New System.Drawing.Size(89, 21)
        Me.Num281.TabIndex = 32
        Me.Num281.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num281.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num271
        '
        Me.Num271.BackColor = System.Drawing.Color.YellowGreen
        Me.Num271.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num271.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num271.DecimalDigits = 2
        Me.Num271.DefaultSendValue = False
        Me.Num271.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num271.FireTabAfterEnter = True
        Me.Num271.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num271.Image = CType(resources.GetObject("Num271.Image"), System.Drawing.Image)
        Me.Num271.Location = New System.Drawing.Point(127, 161)
        Me.Num271.Maxlength = 10
        Me.Num271.MinusColor = System.Drawing.Color.Empty
        Me.Num271.Name = "Num271"
        Me.Num271.ReadOnly = True
        Me.Num271.Size = New System.Drawing.Size(89, 21)
        Me.Num271.TabIndex = 31
        Me.Num271.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num271.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num261
        '
        Me.Num261.BackColor = System.Drawing.Color.Gold
        Me.Num261.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num261.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num261.DecimalDigits = 2
        Me.Num261.DefaultSendValue = False
        Me.Num261.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num261.FireTabAfterEnter = True
        Me.Num261.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num261.ForeColor = System.Drawing.Color.Red
        Me.Num261.Image = CType(resources.GetObject("Num261.Image"), System.Drawing.Image)
        Me.Num261.Location = New System.Drawing.Point(127, 138)
        Me.Num261.Maxlength = 10
        Me.Num261.MinusColor = System.Drawing.Color.Empty
        Me.Num261.Name = "Num261"
        Me.Num261.ReadOnly = True
        Me.Num261.Size = New System.Drawing.Size(89, 21)
        Me.Num261.TabIndex = 30
        Me.Num261.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num261.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num251
        '
        Me.Num251.BackColor = System.Drawing.Color.Gold
        Me.Num251.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num251.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num251.DecimalDigits = 2
        Me.Num251.DefaultSendValue = False
        Me.Num251.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num251.FireTabAfterEnter = True
        Me.Num251.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num251.Image = CType(resources.GetObject("Num251.Image"), System.Drawing.Image)
        Me.Num251.Location = New System.Drawing.Point(127, 115)
        Me.Num251.Maxlength = 10
        Me.Num251.MinusColor = System.Drawing.Color.Empty
        Me.Num251.Name = "Num251"
        Me.Num251.ReadOnly = True
        Me.Num251.Size = New System.Drawing.Size(89, 21)
        Me.Num251.TabIndex = 29
        Me.Num251.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num251.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num241
        '
        Me.Num241.BackColor = System.Drawing.Color.Gold
        Me.Num241.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num241.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num241.DecimalDigits = 2
        Me.Num241.DefaultSendValue = False
        Me.Num241.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num241.FireTabAfterEnter = True
        Me.Num241.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num241.Image = CType(resources.GetObject("Num241.Image"), System.Drawing.Image)
        Me.Num241.Location = New System.Drawing.Point(127, 93)
        Me.Num241.Maxlength = 10
        Me.Num241.MinusColor = System.Drawing.Color.Empty
        Me.Num241.Name = "Num241"
        Me.Num241.ReadOnly = True
        Me.Num241.Size = New System.Drawing.Size(89, 21)
        Me.Num241.TabIndex = 28
        Me.Num241.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num241.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num231
        '
        Me.Num231.BackColor = System.Drawing.Color.Gold
        Me.Num231.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num231.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num231.DecimalDigits = 2
        Me.Num231.DefaultSendValue = False
        Me.Num231.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num231.FireTabAfterEnter = True
        Me.Num231.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num231.Image = CType(resources.GetObject("Num231.Image"), System.Drawing.Image)
        Me.Num231.Location = New System.Drawing.Point(127, 69)
        Me.Num231.Maxlength = 10
        Me.Num231.MinusColor = System.Drawing.Color.Empty
        Me.Num231.Name = "Num231"
        Me.Num231.ReadOnly = True
        Me.Num231.Size = New System.Drawing.Size(89, 21)
        Me.Num231.TabIndex = 27
        Me.Num231.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num231.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num221
        '
        Me.Num221.BackColor = System.Drawing.Color.Gold
        Me.Num221.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num221.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num221.DecimalDigits = 2
        Me.Num221.DefaultSendValue = False
        Me.Num221.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num221.FireTabAfterEnter = True
        Me.Num221.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num221.Image = CType(resources.GetObject("Num221.Image"), System.Drawing.Image)
        Me.Num221.Location = New System.Drawing.Point(127, 46)
        Me.Num221.Maxlength = 10
        Me.Num221.MinusColor = System.Drawing.Color.Empty
        Me.Num221.Name = "Num221"
        Me.Num221.ReadOnly = True
        Me.Num221.Size = New System.Drawing.Size(89, 21)
        Me.Num221.TabIndex = 26
        Me.Num221.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num221.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num211
        '
        Me.Num211.BackColor = System.Drawing.Color.Gold
        Me.Num211.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num211.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num211.DecimalDigits = 2
        Me.Num211.DefaultSendValue = False
        Me.Num211.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num211.FireTabAfterEnter = True
        Me.Num211.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num211.Image = CType(resources.GetObject("Num211.Image"), System.Drawing.Image)
        Me.Num211.Location = New System.Drawing.Point(127, 23)
        Me.Num211.Maxlength = 10
        Me.Num211.MinusColor = System.Drawing.Color.Empty
        Me.Num211.Name = "Num211"
        Me.Num211.ReadOnly = True
        Me.Num211.Size = New System.Drawing.Size(89, 21)
        Me.Num211.TabIndex = 25
        Me.Num211.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num211.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Lbl194
        '
        Me.Lbl194.BackColor = System.Drawing.Color.Transparent
        Me.Lbl194.ForeColor = System.Drawing.Color.Red
        Me.Lbl194.Location = New System.Drawing.Point(420, 229)
        Me.Lbl194.Name = "Lbl194"
        Me.Lbl194.Size = New System.Drawing.Size(101, 23)
        Me.Lbl194.TabIndex = 24
        Me.Lbl194.Text = "Total Returns"
        Me.Lbl194.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl184
        '
        Me.Lbl184.BackColor = System.Drawing.Color.Transparent
        Me.Lbl184.ForeColor = System.Drawing.Color.Red
        Me.Lbl184.Location = New System.Drawing.Point(420, 205)
        Me.Lbl184.Name = "Lbl184"
        Me.Lbl184.Size = New System.Drawing.Size(101, 23)
        Me.Lbl184.TabIndex = 23
        Me.Lbl184.Text = "Sales Tax Returns"
        Me.Lbl184.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl165
        '
        Me.Lbl165.BackColor = System.Drawing.Color.Transparent
        Me.Lbl165.ForeColor = System.Drawing.Color.Red
        Me.Lbl165.Location = New System.Drawing.Point(522, 137)
        Me.Lbl165.Name = "Lbl165"
        Me.Lbl165.Size = New System.Drawing.Size(101, 23)
        Me.Lbl165.TabIndex = 22
        Me.Lbl165.Text = "Subtotal Returns"
        Me.Lbl165.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl205
        '
        Me.Lbl205.BackColor = System.Drawing.Color.Transparent
        Me.Lbl205.ForeColor = System.Drawing.Color.Red
        Me.Lbl205.Location = New System.Drawing.Point(520, 0)
        Me.Lbl205.Name = "Lbl205"
        Me.Lbl205.Size = New System.Drawing.Size(101, 23)
        Me.Lbl205.TabIndex = 21
        Me.Lbl205.Text = "Customer Returns"
        Me.Lbl205.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl204
        '
        Me.Lbl204.BackColor = System.Drawing.Color.Transparent
        Me.Lbl204.Location = New System.Drawing.Point(419, -1)
        Me.Lbl204.Name = "Lbl204"
        Me.Lbl204.Size = New System.Drawing.Size(72, 23)
        Me.Lbl204.TabIndex = 20
        Me.Lbl204.Text = "G/P %"
        Me.Lbl204.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl203
        '
        Me.Lbl203.BackColor = System.Drawing.Color.Transparent
        Me.Lbl203.Location = New System.Drawing.Point(324, -1)
        Me.Lbl203.Name = "Lbl203"
        Me.Lbl203.Size = New System.Drawing.Size(72, 23)
        Me.Lbl203.TabIndex = 19
        Me.Lbl203.Text = "Gr Profit"
        Me.Lbl203.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl202
        '
        Me.Lbl202.BackColor = System.Drawing.Color.Transparent
        Me.Lbl202.Location = New System.Drawing.Point(229, -1)
        Me.Lbl202.Name = "Lbl202"
        Me.Lbl202.Size = New System.Drawing.Size(72, 23)
        Me.Lbl202.TabIndex = 18
        Me.Lbl202.Text = "Cost"
        Me.Lbl202.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl201
        '
        Me.Lbl201.BackColor = System.Drawing.Color.Transparent
        Me.Lbl201.Location = New System.Drawing.Point(134, -1)
        Me.Lbl201.Name = "Lbl201"
        Me.Lbl201.Size = New System.Drawing.Size(72, 23)
        Me.Lbl201.TabIndex = 17
        Me.Lbl201.Text = "Sales"
        Me.Lbl201.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSalesTax6
        '
        Me.LblSalesTax6.BackColor = System.Drawing.Color.Transparent
        Me.LblSalesTax6.Location = New System.Drawing.Point(596, 253)
        Me.LblSalesTax6.Name = "LblSalesTax6"
        Me.LblSalesTax6.Size = New System.Drawing.Size(72, 23)
        Me.LblSalesTax6.TabIndex = 16
        Me.LblSalesTax6.Text = "Sales Tax"
        Me.LblSalesTax6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSalesTax5
        '
        Me.LblSalesTax5.BackColor = System.Drawing.Color.Transparent
        Me.LblSalesTax5.Location = New System.Drawing.Point(505, 253)
        Me.LblSalesTax5.Name = "LblSalesTax5"
        Me.LblSalesTax5.Size = New System.Drawing.Size(72, 23)
        Me.LblSalesTax5.TabIndex = 15
        Me.LblSalesTax5.Text = "FET"
        Me.LblSalesTax5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSalesTax4
        '
        Me.LblSalesTax4.BackColor = System.Drawing.Color.Transparent
        Me.LblSalesTax4.Location = New System.Drawing.Point(413, 252)
        Me.LblSalesTax4.Name = "LblSalesTax4"
        Me.LblSalesTax4.Size = New System.Drawing.Size(72, 23)
        Me.LblSalesTax4.TabIndex = 14
        Me.LblSalesTax4.Text = "Non Taxable"
        Me.LblSalesTax4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSalesTax3
        '
        Me.LblSalesTax3.BackColor = System.Drawing.Color.Transparent
        Me.LblSalesTax3.Location = New System.Drawing.Point(231, 252)
        Me.LblSalesTax3.Name = "LblSalesTax3"
        Me.LblSalesTax3.Size = New System.Drawing.Size(72, 23)
        Me.LblSalesTax3.TabIndex = 13
        Me.LblSalesTax3.Text = "Tax Exempt"
        Me.LblSalesTax3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSalesTax2
        '
        Me.LblSalesTax2.BackColor = System.Drawing.Color.Transparent
        Me.LblSalesTax2.Location = New System.Drawing.Point(136, 252)
        Me.LblSalesTax2.Name = "LblSalesTax2"
        Me.LblSalesTax2.Size = New System.Drawing.Size(72, 23)
        Me.LblSalesTax2.TabIndex = 12
        Me.LblSalesTax2.Text = "Taxable"
        Me.LblSalesTax2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSalesTax1
        '
        Me.LblSalesTax1.BackColor = System.Drawing.Color.Transparent
        Me.LblSalesTax1.Location = New System.Drawing.Point(44, 252)
        Me.LblSalesTax1.Name = "LblSalesTax1"
        Me.LblSalesTax1.Size = New System.Drawing.Size(72, 23)
        Me.LblSalesTax1.TabIndex = 10
        Me.LblSalesTax1.Text = "Gross Sales"
        Me.LblSalesTax1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl219
        '
        Me.Lbl219.BackColor = System.Drawing.Color.Transparent
        Me.Lbl219.Location = New System.Drawing.Point(52, 230)
        Me.Lbl219.Name = "Lbl219"
        Me.Lbl219.Size = New System.Drawing.Size(72, 23)
        Me.Lbl219.TabIndex = 9
        Me.Lbl219.Text = "Total Sales"
        Me.Lbl219.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl218
        '
        Me.Lbl218.BackColor = System.Drawing.Color.Transparent
        Me.Lbl218.Location = New System.Drawing.Point(52, 207)
        Me.Lbl218.Name = "Lbl218"
        Me.Lbl218.Size = New System.Drawing.Size(72, 23)
        Me.Lbl218.TabIndex = 8
        Me.Lbl218.Text = "Sales Tax"
        Me.Lbl218.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl217
        '
        Me.Lbl217.BackColor = System.Drawing.Color.Transparent
        Me.Lbl217.Location = New System.Drawing.Point(76, 161)
        Me.Lbl217.Name = "Lbl217"
        Me.Lbl217.Size = New System.Drawing.Size(48, 23)
        Me.Lbl217.TabIndex = 7
        Me.Lbl217.Text = "Subtotal"
        Me.Lbl217.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl216
        '
        Me.Lbl216.BackColor = System.Drawing.Color.Transparent
        Me.Lbl216.Location = New System.Drawing.Point(4, 138)
        Me.Lbl216.Name = "Lbl216"
        Me.Lbl216.Size = New System.Drawing.Size(120, 23)
        Me.Lbl216.TabIndex = 6
        Me.Lbl216.Text = "Trades"
        Me.Lbl216.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl215
        '
        Me.Lbl215.BackColor = System.Drawing.Color.Transparent
        Me.Lbl215.Location = New System.Drawing.Point(29, 115)
        Me.Lbl215.Name = "Lbl215"
        Me.Lbl215.Size = New System.Drawing.Size(95, 23)
        Me.Lbl215.TabIndex = 5
        Me.Lbl215.Text = "Adjustments"
        Me.Lbl215.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl214
        '
        Me.Lbl214.BackColor = System.Drawing.Color.Transparent
        Me.Lbl214.Location = New System.Drawing.Point(22, 92)
        Me.Lbl214.Name = "Lbl214"
        Me.Lbl214.Size = New System.Drawing.Size(102, 23)
        Me.Lbl214.TabIndex = 4
        Me.Lbl214.Text = "Outside Purchases"
        Me.Lbl214.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl213
        '
        Me.Lbl213.BackColor = System.Drawing.Color.Transparent
        Me.Lbl213.Location = New System.Drawing.Point(76, 69)
        Me.Lbl213.Name = "Lbl213"
        Me.Lbl213.Size = New System.Drawing.Size(48, 23)
        Me.Lbl213.TabIndex = 3
        Me.Lbl213.Text = "Fees"
        Me.Lbl213.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl212
        '
        Me.Lbl212.BackColor = System.Drawing.Color.Transparent
        Me.Lbl212.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Lbl212.ForeColor = System.Drawing.Color.Black
        Me.Lbl212.Location = New System.Drawing.Point(20, 46)
        Me.Lbl212.Name = "Lbl212"
        Me.Lbl212.Size = New System.Drawing.Size(104, 23)
        Me.Lbl212.TabIndex = 2
        Me.Lbl212.Text = "Labor And Supplies"
        Me.Lbl212.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl211
        '
        Me.Lbl211.BackColor = System.Drawing.Color.Transparent
        Me.Lbl211.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Lbl211.ForeColor = System.Drawing.Color.Black
        Me.Lbl211.Location = New System.Drawing.Point(40, 23)
        Me.Lbl211.Name = "Lbl211"
        Me.Lbl211.Size = New System.Drawing.Size(84, 23)
        Me.Lbl211.TabIndex = 1
        Me.Lbl211.Text = "Tires And Parts"
        Me.Lbl211.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-3, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sales Summary"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(4, 239)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 32)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Sales Tax"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblReturnDiscount
        '
        Me.LblReturnDiscount.BackColor = System.Drawing.Color.Transparent
        Me.LblReturnDiscount.ForeColor = System.Drawing.Color.Red
        Me.LblReturnDiscount.Location = New System.Drawing.Point(420, 181)
        Me.LblReturnDiscount.Name = "LblReturnDiscount"
        Me.LblReturnDiscount.Size = New System.Drawing.Size(101, 23)
        Me.LblReturnDiscount.TabIndex = 73
        Me.LblReturnDiscount.Text = "Discount Returns"
        Me.LblReturnDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UiTabPage3
        '
        Me.UiTabPage3.Controls.Add(Me.NumOverPayment)
        Me.UiTabPage3.Controls.Add(Me.Label7)
        Me.UiTabPage3.Controls.Add(Me.NumBeginingBalances)
        Me.UiTabPage3.Controls.Add(Me.Label5)
        Me.UiTabPage3.Controls.Add(Me.NumBeginingBalance)
        Me.UiTabPage3.Controls.Add(Me.NumNetChangeToAR)
        Me.UiTabPage3.Controls.Add(Me.NumTotalDebits)
        Me.UiTabPage3.Controls.Add(Me.NumEndingBalance)
        Me.UiTabPage3.Controls.Add(Me.NumReceivedOnAccounts)
        Me.UiTabPage3.Controls.Add(Me.NumReturnsCredits)
        Me.UiTabPage3.Controls.Add(Me.NumNewCharges)
        Me.UiTabPage3.Controls.Add(Me.NumTotalCredits)
        Me.UiTabPage3.Controls.Add(Me.NumNetAdjustment)
        Me.UiTabPage3.Controls.Add(Me.LblReturnsCredits)
        Me.UiTabPage3.Controls.Add(Me.LblReceivedOnAccounts)
        Me.UiTabPage3.Controls.Add(Me.LblNetAdjustment)
        Me.UiTabPage3.Controls.Add(Me.LblNewCharges)
        Me.UiTabPage3.Controls.Add(Me.LblTotalCredits)
        Me.UiTabPage3.Controls.Add(Me.LblTotalDebits)
        Me.UiTabPage3.Controls.Add(Me.LblEndingBalance)
        Me.UiTabPage3.Controls.Add(Me.LblNetChangeToAR)
        Me.UiTabPage3.Controls.Add(Me.LblBeginingBalance)
        Me.UiTabPage3.Controls.Add(Me.Label40)
        Me.UiTabPage3.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage3.Name = "UiTabPage3"
        Me.UiTabPage3.Size = New System.Drawing.Size(635, 298)
        Me.UiTabPage3.TabIndex = 2
        Me.UiTabPage3.Text = "A/R"
        '
        'NumOverPayment
        '
        Me.NumOverPayment.BackColor = System.Drawing.Color.YellowGreen
        Me.NumOverPayment.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumOverPayment.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumOverPayment.DecimalDigits = 2
        Me.NumOverPayment.DefaultSendValue = False
        Me.NumOverPayment.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumOverPayment.FireTabAfterEnter = True
        Me.NumOverPayment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumOverPayment.Image = CType(resources.GetObject("NumOverPayment.Image"), System.Drawing.Image)
        Me.NumOverPayment.Location = New System.Drawing.Point(180, 168)
        Me.NumOverPayment.Maxlength = 10
        Me.NumOverPayment.MinusColor = System.Drawing.Color.Empty
        Me.NumOverPayment.Name = "NumOverPayment"
        Me.NumOverPayment.ReadOnly = True
        Me.NumOverPayment.Size = New System.Drawing.Size(89, 21)
        Me.NumOverPayment.TabIndex = 73
        Me.NumOverPayment.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumOverPayment.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(72, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 23)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Over Payment"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumBeginingBalances
        '
        Me.NumBeginingBalances.BackColor = System.Drawing.Color.YellowGreen
        Me.NumBeginingBalances.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumBeginingBalances.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumBeginingBalances.DecimalDigits = 2
        Me.NumBeginingBalances.DefaultSendValue = False
        Me.NumBeginingBalances.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumBeginingBalances.FireTabAfterEnter = True
        Me.NumBeginingBalances.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumBeginingBalances.Image = CType(resources.GetObject("NumBeginingBalances.Image"), System.Drawing.Image)
        Me.NumBeginingBalances.Location = New System.Drawing.Point(180, 139)
        Me.NumBeginingBalances.Maxlength = 10
        Me.NumBeginingBalances.MinusColor = System.Drawing.Color.Empty
        Me.NumBeginingBalances.Name = "NumBeginingBalances"
        Me.NumBeginingBalances.ReadOnly = True
        Me.NumBeginingBalances.Size = New System.Drawing.Size(89, 21)
        Me.NumBeginingBalances.TabIndex = 71
        Me.NumBeginingBalances.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumBeginingBalances.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(72, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 23)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Begining Balances"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NumBeginingBalance
        '
        Me.NumBeginingBalance.BackColor = System.Drawing.Color.Gold
        Me.NumBeginingBalance.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumBeginingBalance.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumBeginingBalance.DecimalDigits = 2
        Me.NumBeginingBalance.DefaultSendValue = False
        Me.NumBeginingBalance.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumBeginingBalance.FireTabAfterEnter = True
        Me.NumBeginingBalance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumBeginingBalance.Image = CType(resources.GetObject("NumBeginingBalance.Image"), System.Drawing.Image)
        Me.NumBeginingBalance.Location = New System.Drawing.Point(496, 36)
        Me.NumBeginingBalance.Maxlength = 10
        Me.NumBeginingBalance.MinusColor = System.Drawing.Color.Empty
        Me.NumBeginingBalance.Name = "NumBeginingBalance"
        Me.NumBeginingBalance.ReadOnly = True
        Me.NumBeginingBalance.Size = New System.Drawing.Size(89, 21)
        Me.NumBeginingBalance.TabIndex = 69
        Me.NumBeginingBalance.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumBeginingBalance.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumNetChangeToAR
        '
        Me.NumNetChangeToAR.BackColor = System.Drawing.Color.Gold
        Me.NumNetChangeToAR.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumNetChangeToAR.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumNetChangeToAR.DecimalDigits = 2
        Me.NumNetChangeToAR.DefaultSendValue = False
        Me.NumNetChangeToAR.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumNetChangeToAR.FireTabAfterEnter = True
        Me.NumNetChangeToAR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumNetChangeToAR.Image = CType(resources.GetObject("NumNetChangeToAR.Image"), System.Drawing.Image)
        Me.NumNetChangeToAR.Location = New System.Drawing.Point(180, 248)
        Me.NumNetChangeToAR.Maxlength = 10
        Me.NumNetChangeToAR.MinusColor = System.Drawing.Color.Empty
        Me.NumNetChangeToAR.Name = "NumNetChangeToAR"
        Me.NumNetChangeToAR.ReadOnly = True
        Me.NumNetChangeToAR.Size = New System.Drawing.Size(89, 21)
        Me.NumNetChangeToAR.TabIndex = 68
        Me.NumNetChangeToAR.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumNetChangeToAR.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumTotalDebits
        '
        Me.NumTotalDebits.BackColor = System.Drawing.Color.Gold
        Me.NumTotalDebits.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumTotalDebits.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumTotalDebits.DecimalDigits = 2
        Me.NumTotalDebits.DefaultSendValue = False
        Me.NumTotalDebits.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumTotalDebits.FireTabAfterEnter = True
        Me.NumTotalDebits.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumTotalDebits.Image = CType(resources.GetObject("NumTotalDebits.Image"), System.Drawing.Image)
        Me.NumTotalDebits.Location = New System.Drawing.Point(180, 211)
        Me.NumTotalDebits.Maxlength = 10
        Me.NumTotalDebits.MinusColor = System.Drawing.Color.Empty
        Me.NumTotalDebits.Name = "NumTotalDebits"
        Me.NumTotalDebits.ReadOnly = True
        Me.NumTotalDebits.Size = New System.Drawing.Size(89, 21)
        Me.NumTotalDebits.TabIndex = 67
        Me.NumTotalDebits.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumTotalDebits.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumEndingBalance
        '
        Me.NumEndingBalance.BackColor = System.Drawing.Color.Gold
        Me.NumEndingBalance.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumEndingBalance.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumEndingBalance.DecimalDigits = 2
        Me.NumEndingBalance.DefaultSendValue = False
        Me.NumEndingBalance.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumEndingBalance.FireTabAfterEnter = True
        Me.NumEndingBalance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumEndingBalance.Image = CType(resources.GetObject("NumEndingBalance.Image"), System.Drawing.Image)
        Me.NumEndingBalance.Location = New System.Drawing.Point(496, 248)
        Me.NumEndingBalance.Maxlength = 10
        Me.NumEndingBalance.MinusColor = System.Drawing.Color.Empty
        Me.NumEndingBalance.Name = "NumEndingBalance"
        Me.NumEndingBalance.ReadOnly = True
        Me.NumEndingBalance.Size = New System.Drawing.Size(89, 21)
        Me.NumEndingBalance.TabIndex = 66
        Me.NumEndingBalance.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumEndingBalance.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumReceivedOnAccounts
        '
        Me.NumReceivedOnAccounts.BackColor = System.Drawing.Color.YellowGreen
        Me.NumReceivedOnAccounts.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumReceivedOnAccounts.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumReceivedOnAccounts.DecimalDigits = 2
        Me.NumReceivedOnAccounts.DefaultSendValue = False
        Me.NumReceivedOnAccounts.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumReceivedOnAccounts.FireTabAfterEnter = True
        Me.NumReceivedOnAccounts.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumReceivedOnAccounts.ForeColor = System.Drawing.Color.Red
        Me.NumReceivedOnAccounts.Image = CType(resources.GetObject("NumReceivedOnAccounts.Image"), System.Drawing.Image)
        Me.NumReceivedOnAccounts.Location = New System.Drawing.Point(496, 81)
        Me.NumReceivedOnAccounts.Maxlength = 10
        Me.NumReceivedOnAccounts.MinusColor = System.Drawing.Color.Empty
        Me.NumReceivedOnAccounts.Name = "NumReceivedOnAccounts"
        Me.NumReceivedOnAccounts.ReadOnly = True
        Me.NumReceivedOnAccounts.Size = New System.Drawing.Size(89, 21)
        Me.NumReceivedOnAccounts.TabIndex = 65
        Me.NumReceivedOnAccounts.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumReceivedOnAccounts.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumReturnsCredits
        '
        Me.NumReturnsCredits.BackColor = System.Drawing.Color.YellowGreen
        Me.NumReturnsCredits.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumReturnsCredits.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumReturnsCredits.DecimalDigits = 2
        Me.NumReturnsCredits.DefaultSendValue = False
        Me.NumReturnsCredits.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumReturnsCredits.FireTabAfterEnter = True
        Me.NumReturnsCredits.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumReturnsCredits.ForeColor = System.Drawing.Color.Red
        Me.NumReturnsCredits.Image = CType(resources.GetObject("NumReturnsCredits.Image"), System.Drawing.Image)
        Me.NumReturnsCredits.Location = New System.Drawing.Point(496, 110)
        Me.NumReturnsCredits.Maxlength = 10
        Me.NumReturnsCredits.MinusColor = System.Drawing.Color.Empty
        Me.NumReturnsCredits.Name = "NumReturnsCredits"
        Me.NumReturnsCredits.ReadOnly = True
        Me.NumReturnsCredits.Size = New System.Drawing.Size(89, 21)
        Me.NumReturnsCredits.TabIndex = 64
        Me.NumReturnsCredits.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumReturnsCredits.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumNewCharges
        '
        Me.NumNewCharges.BackColor = System.Drawing.Color.YellowGreen
        Me.NumNewCharges.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumNewCharges.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumNewCharges.DecimalDigits = 2
        Me.NumNewCharges.DefaultSendValue = False
        Me.NumNewCharges.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumNewCharges.FireTabAfterEnter = True
        Me.NumNewCharges.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumNewCharges.Image = CType(resources.GetObject("NumNewCharges.Image"), System.Drawing.Image)
        Me.NumNewCharges.Location = New System.Drawing.Point(180, 81)
        Me.NumNewCharges.Maxlength = 10
        Me.NumNewCharges.MinusColor = System.Drawing.Color.Empty
        Me.NumNewCharges.Name = "NumNewCharges"
        Me.NumNewCharges.ReadOnly = True
        Me.NumNewCharges.Size = New System.Drawing.Size(89, 21)
        Me.NumNewCharges.TabIndex = 63
        Me.NumNewCharges.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumNewCharges.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumTotalCredits
        '
        Me.NumTotalCredits.BackColor = System.Drawing.Color.Gold
        Me.NumTotalCredits.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumTotalCredits.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumTotalCredits.DecimalDigits = 2
        Me.NumTotalCredits.DefaultSendValue = False
        Me.NumTotalCredits.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumTotalCredits.FireTabAfterEnter = True
        Me.NumTotalCredits.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumTotalCredits.ForeColor = System.Drawing.Color.Red
        Me.NumTotalCredits.Image = CType(resources.GetObject("NumTotalCredits.Image"), System.Drawing.Image)
        Me.NumTotalCredits.Location = New System.Drawing.Point(496, 211)
        Me.NumTotalCredits.Maxlength = 10
        Me.NumTotalCredits.MinusColor = System.Drawing.Color.Empty
        Me.NumTotalCredits.Name = "NumTotalCredits"
        Me.NumTotalCredits.ReadOnly = True
        Me.NumTotalCredits.Size = New System.Drawing.Size(89, 21)
        Me.NumTotalCredits.TabIndex = 62
        Me.NumTotalCredits.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumTotalCredits.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumNetAdjustment
        '
        Me.NumNetAdjustment.BackColor = System.Drawing.Color.YellowGreen
        Me.NumNetAdjustment.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumNetAdjustment.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumNetAdjustment.DecimalDigits = 2
        Me.NumNetAdjustment.DefaultSendValue = False
        Me.NumNetAdjustment.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumNetAdjustment.FireTabAfterEnter = True
        Me.NumNetAdjustment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumNetAdjustment.Image = CType(resources.GetObject("NumNetAdjustment.Image"), System.Drawing.Image)
        Me.NumNetAdjustment.Location = New System.Drawing.Point(180, 110)
        Me.NumNetAdjustment.Maxlength = 10
        Me.NumNetAdjustment.MinusColor = System.Drawing.Color.Empty
        Me.NumNetAdjustment.Name = "NumNetAdjustment"
        Me.NumNetAdjustment.ReadOnly = True
        Me.NumNetAdjustment.Size = New System.Drawing.Size(89, 21)
        Me.NumNetAdjustment.TabIndex = 61
        Me.NumNetAdjustment.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumNetAdjustment.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblReturnsCredits
        '
        Me.LblReturnsCredits.BackColor = System.Drawing.Color.Transparent
        Me.LblReturnsCredits.ForeColor = System.Drawing.Color.Red
        Me.LblReturnsCredits.Location = New System.Drawing.Point(348, 108)
        Me.LblReturnsCredits.Name = "LblReturnsCredits"
        Me.LblReturnsCredits.Size = New System.Drawing.Size(140, 23)
        Me.LblReturnsCredits.TabIndex = 10
        Me.LblReturnsCredits.Text = "Returns / Credits"
        Me.LblReturnsCredits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblReceivedOnAccounts
        '
        Me.LblReceivedOnAccounts.BackColor = System.Drawing.Color.Transparent
        Me.LblReceivedOnAccounts.ForeColor = System.Drawing.Color.Red
        Me.LblReceivedOnAccounts.Location = New System.Drawing.Point(350, 78)
        Me.LblReceivedOnAccounts.Name = "LblReceivedOnAccounts"
        Me.LblReceivedOnAccounts.Size = New System.Drawing.Size(138, 23)
        Me.LblReceivedOnAccounts.TabIndex = 9
        Me.LblReceivedOnAccounts.Text = "Received On Accounts"
        Me.LblReceivedOnAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblNetAdjustment
        '
        Me.LblNetAdjustment.BackColor = System.Drawing.Color.Transparent
        Me.LblNetAdjustment.Location = New System.Drawing.Point(72, 108)
        Me.LblNetAdjustment.Name = "LblNetAdjustment"
        Me.LblNetAdjustment.Size = New System.Drawing.Size(104, 23)
        Me.LblNetAdjustment.TabIndex = 8
        Me.LblNetAdjustment.Text = "Net Adjustment"
        Me.LblNetAdjustment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblNewCharges
        '
        Me.LblNewCharges.BackColor = System.Drawing.Color.Transparent
        Me.LblNewCharges.Location = New System.Drawing.Point(92, 78)
        Me.LblNewCharges.Name = "LblNewCharges"
        Me.LblNewCharges.Size = New System.Drawing.Size(84, 23)
        Me.LblNewCharges.TabIndex = 7
        Me.LblNewCharges.Text = "New Charges"
        Me.LblNewCharges.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotalCredits
        '
        Me.LblTotalCredits.BackColor = System.Drawing.Color.Transparent
        Me.LblTotalCredits.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalCredits.ForeColor = System.Drawing.Color.Red
        Me.LblTotalCredits.Location = New System.Drawing.Point(370, 210)
        Me.LblTotalCredits.Name = "LblTotalCredits"
        Me.LblTotalCredits.Size = New System.Drawing.Size(118, 23)
        Me.LblTotalCredits.TabIndex = 6
        Me.LblTotalCredits.Text = "Total Credits"
        Me.LblTotalCredits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotalDebits
        '
        Me.LblTotalDebits.BackColor = System.Drawing.Color.Transparent
        Me.LblTotalDebits.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalDebits.Location = New System.Drawing.Point(37, 210)
        Me.LblTotalDebits.Name = "LblTotalDebits"
        Me.LblTotalDebits.Size = New System.Drawing.Size(138, 23)
        Me.LblTotalDebits.TabIndex = 5
        Me.LblTotalDebits.Text = "Total Debits"
        Me.LblTotalDebits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblEndingBalance
        '
        Me.LblEndingBalance.BackColor = System.Drawing.Color.Transparent
        Me.LblEndingBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEndingBalance.Location = New System.Drawing.Point(371, 247)
        Me.LblEndingBalance.Name = "LblEndingBalance"
        Me.LblEndingBalance.Size = New System.Drawing.Size(118, 23)
        Me.LblEndingBalance.TabIndex = 4
        Me.LblEndingBalance.Text = "Ending Balance"
        Me.LblEndingBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblNetChangeToAR
        '
        Me.LblNetChangeToAR.BackColor = System.Drawing.Color.Transparent
        Me.LblNetChangeToAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNetChangeToAR.Location = New System.Drawing.Point(37, 247)
        Me.LblNetChangeToAR.Name = "LblNetChangeToAR"
        Me.LblNetChangeToAR.Size = New System.Drawing.Size(138, 23)
        Me.LblNetChangeToAR.TabIndex = 3
        Me.LblNetChangeToAR.Text = "Net Charge To A/R"
        Me.LblNetChangeToAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblBeginingBalance
        '
        Me.LblBeginingBalance.BackColor = System.Drawing.Color.Transparent
        Me.LblBeginingBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBeginingBalance.Location = New System.Drawing.Point(293, 36)
        Me.LblBeginingBalance.Name = "LblBeginingBalance"
        Me.LblBeginingBalance.Size = New System.Drawing.Size(199, 23)
        Me.LblBeginingBalance.TabIndex = 2
        Me.LblBeginingBalance.Text = "Begining Balance (Total A/R)"
        Me.LblBeginingBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(21, 14)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(195, 23)
        Me.Label40.TabIndex = 1
        Me.Label40.Text = "Account Receivable Summary "
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UiTabPage4
        '
        Me.UiTabPage4.Controls.Add(Me.Lbl464)
        Me.UiTabPage4.Controls.Add(Me.Num473)
        Me.UiTabPage4.Controls.Add(Me.Num472)
        Me.UiTabPage4.Controls.Add(Me.Num471)
        Me.UiTabPage4.Controls.Add(Me.Num484)
        Me.UiTabPage4.Controls.Add(Me.Num474)
        Me.UiTabPage4.Controls.Add(Me.Num464)
        Me.UiTabPage4.Controls.Add(Me.Num483)
        Me.UiTabPage4.Controls.Add(Me.Num482)
        Me.UiTabPage4.Controls.Add(Me.Num463)
        Me.UiTabPage4.Controls.Add(Me.Num453)
        Me.UiTabPage4.Controls.Add(Me.Num443)
        Me.UiTabPage4.Controls.Add(Me.Num433)
        Me.UiTabPage4.Controls.Add(Me.Num423)
        Me.UiTabPage4.Controls.Add(Me.Num413)
        Me.UiTabPage4.Controls.Add(Me.Num462)
        Me.UiTabPage4.Controls.Add(Me.Num452)
        Me.UiTabPage4.Controls.Add(Me.Num442)
        Me.UiTabPage4.Controls.Add(Me.Num432)
        Me.UiTabPage4.Controls.Add(Me.Num422)
        Me.UiTabPage4.Controls.Add(Me.Num412)
        Me.UiTabPage4.Controls.Add(Me.Num481)
        Me.UiTabPage4.Controls.Add(Me.Num461)
        Me.UiTabPage4.Controls.Add(Me.Num451)
        Me.UiTabPage4.Controls.Add(Me.Num441)
        Me.UiTabPage4.Controls.Add(Me.Num431)
        Me.UiTabPage4.Controls.Add(Me.Num421)
        Me.UiTabPage4.Controls.Add(Me.Num411)
        Me.UiTabPage4.Controls.Add(Me.Lbl484)
        Me.UiTabPage4.Controls.Add(Me.Lbl474)
        Me.UiTabPage4.Controls.Add(Me.LblInventoryTurnOver)
        Me.UiTabPage4.Controls.Add(Me.Lbl403)
        Me.UiTabPage4.Controls.Add(Me.Lbl402)
        Me.UiTabPage4.Controls.Add(Me.Lbl401)
        Me.UiTabPage4.Controls.Add(Me.Lbl418)
        Me.UiTabPage4.Controls.Add(Me.Lbl417)
        Me.UiTabPage4.Controls.Add(Me.Lbl416)
        Me.UiTabPage4.Controls.Add(Me.Lbl415)
        Me.UiTabPage4.Controls.Add(Me.Lbl414)
        Me.UiTabPage4.Controls.Add(Me.Lbl413)
        Me.UiTabPage4.Controls.Add(Me.Lbl412)
        Me.UiTabPage4.Controls.Add(Me.Lbl411)
        Me.UiTabPage4.Controls.Add(Me.Label50)
        Me.UiTabPage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UiTabPage4.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage4.Name = "UiTabPage4"
        Me.UiTabPage4.Size = New System.Drawing.Size(635, 298)
        Me.UiTabPage4.TabIndex = 3
        Me.UiTabPage4.Text = "Products"
        '
        'Lbl464
        '
        Me.Lbl464.BackColor = System.Drawing.Color.Transparent
        Me.Lbl464.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl464.ForeColor = System.Drawing.Color.Red
        Me.Lbl464.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Lbl464.Location = New System.Drawing.Point(427, 217)
        Me.Lbl464.Name = "Lbl464"
        Me.Lbl464.Size = New System.Drawing.Size(101, 23)
        Me.Lbl464.TabIndex = 112
        Me.Lbl464.Text = "Total Credits"
        Me.Lbl464.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Num473
        '
        Me.Num473.BackColor = System.Drawing.Color.Gold
        Me.Num473.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num473.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num473.DecimalDigits = 0
        Me.Num473.DefaultSendValue = False
        Me.Num473.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num473.FireTabAfterEnter = True
        Me.Num473.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num473.ForeColor = System.Drawing.Color.Red
        Me.Num473.Image = CType(resources.GetObject("Num473.Image"), System.Drawing.Image)
        Me.Num473.Location = New System.Drawing.Point(310, 241)
        Me.Num473.Maxlength = 10
        Me.Num473.MinusColor = System.Drawing.Color.Empty
        Me.Num473.Name = "Num473"
        Me.Num473.ReadOnly = True
        Me.Num473.Size = New System.Drawing.Size(89, 21)
        Me.Num473.TabIndex = 111
        Me.Num473.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num473.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num472
        '
        Me.Num472.BackColor = System.Drawing.Color.Gold
        Me.Num472.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num472.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num472.DecimalDigits = 2
        Me.Num472.DefaultSendValue = False
        Me.Num472.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num472.FireTabAfterEnter = True
        Me.Num472.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num472.ForeColor = System.Drawing.Color.Red
        Me.Num472.Image = CType(resources.GetObject("Num472.Image"), System.Drawing.Image)
        Me.Num472.Location = New System.Drawing.Point(217, 241)
        Me.Num472.Maxlength = 10
        Me.Num472.MinusColor = System.Drawing.Color.Empty
        Me.Num472.Name = "Num472"
        Me.Num472.ReadOnly = True
        Me.Num472.Size = New System.Drawing.Size(89, 21)
        Me.Num472.TabIndex = 110
        Me.Num472.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num472.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num471
        '
        Me.Num471.BackColor = System.Drawing.Color.Gold
        Me.Num471.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num471.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num471.DecimalDigits = 2
        Me.Num471.DefaultSendValue = False
        Me.Num471.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num471.FireTabAfterEnter = True
        Me.Num471.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num471.ForeColor = System.Drawing.Color.Red
        Me.Num471.Image = CType(resources.GetObject("Num471.Image"), System.Drawing.Image)
        Me.Num471.Location = New System.Drawing.Point(124, 241)
        Me.Num471.Maxlength = 10
        Me.Num471.MinusColor = System.Drawing.Color.Empty
        Me.Num471.Name = "Num471"
        Me.Num471.ReadOnly = True
        Me.Num471.Size = New System.Drawing.Size(89, 21)
        Me.Num471.TabIndex = 109
        Me.Num471.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num471.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num484
        '
        Me.Num484.BackColor = System.Drawing.Color.YellowGreen
        Me.Num484.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num484.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num484.DecimalDigits = 2
        Me.Num484.DefaultSendValue = False
        Me.Num484.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num484.FireTabAfterEnter = True
        Me.Num484.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num484.Image = CType(resources.GetObject("Num484.Image"), System.Drawing.Image)
        Me.Num484.Location = New System.Drawing.Point(535, 267)
        Me.Num484.Maxlength = 10
        Me.Num484.MinusColor = System.Drawing.Color.Empty
        Me.Num484.Name = "Num484"
        Me.Num484.ReadOnly = True
        Me.Num484.Size = New System.Drawing.Size(89, 21)
        Me.Num484.TabIndex = 108
        Me.Num484.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num484.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num474
        '
        Me.Num474.BackColor = System.Drawing.Color.Gold
        Me.Num474.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num474.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num474.DecimalDigits = 2
        Me.Num474.DefaultSendValue = False
        Me.Num474.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num474.FireTabAfterEnter = True
        Me.Num474.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num474.Image = CType(resources.GetObject("Num474.Image"), System.Drawing.Image)
        Me.Num474.Location = New System.Drawing.Point(535, 244)
        Me.Num474.Maxlength = 10
        Me.Num474.MinusColor = System.Drawing.Color.Empty
        Me.Num474.Name = "Num474"
        Me.Num474.ReadOnly = True
        Me.Num474.Size = New System.Drawing.Size(89, 21)
        Me.Num474.TabIndex = 107
        Me.Num474.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num474.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num464
        '
        Me.Num464.BackColor = System.Drawing.Color.Gold
        Me.Num464.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num464.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num464.DecimalDigits = 2
        Me.Num464.DefaultSendValue = False
        Me.Num464.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num464.FireTabAfterEnter = True
        Me.Num464.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num464.ForeColor = System.Drawing.Color.Red
        Me.Num464.Image = CType(resources.GetObject("Num464.Image"), System.Drawing.Image)
        Me.Num464.Location = New System.Drawing.Point(535, 221)
        Me.Num464.Maxlength = 10
        Me.Num464.MinusColor = System.Drawing.Color.Empty
        Me.Num464.Name = "Num464"
        Me.Num464.ReadOnly = True
        Me.Num464.Size = New System.Drawing.Size(89, 21)
        Me.Num464.TabIndex = 106
        Me.Num464.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num464.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num483
        '
        Me.Num483.BackColor = System.Drawing.Color.YellowGreen
        Me.Num483.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num483.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num483.DecimalDigits = 0
        Me.Num483.DefaultSendValue = False
        Me.Num483.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num483.FireTabAfterEnter = True
        Me.Num483.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num483.Image = CType(resources.GetObject("Num483.Image"), System.Drawing.Image)
        Me.Num483.Location = New System.Drawing.Point(310, 272)
        Me.Num483.Maxlength = 10
        Me.Num483.MinusColor = System.Drawing.Color.Empty
        Me.Num483.Name = "Num483"
        Me.Num483.ReadOnly = True
        Me.Num483.Size = New System.Drawing.Size(89, 21)
        Me.Num483.TabIndex = 104
        Me.Num483.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num483.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num482
        '
        Me.Num482.BackColor = System.Drawing.Color.YellowGreen
        Me.Num482.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num482.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num482.DecimalDigits = 2
        Me.Num482.DefaultSendValue = False
        Me.Num482.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num482.FireTabAfterEnter = True
        Me.Num482.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num482.Image = CType(resources.GetObject("Num482.Image"), System.Drawing.Image)
        Me.Num482.Location = New System.Drawing.Point(217, 272)
        Me.Num482.Maxlength = 10
        Me.Num482.MinusColor = System.Drawing.Color.Empty
        Me.Num482.Name = "Num482"
        Me.Num482.ReadOnly = True
        Me.Num482.Size = New System.Drawing.Size(89, 21)
        Me.Num482.TabIndex = 103
        Me.Num482.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num482.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num463
        '
        Me.Num463.BackColor = System.Drawing.Color.Gold
        Me.Num463.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num463.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num463.DecimalDigits = 0
        Me.Num463.DefaultSendValue = False
        Me.Num463.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num463.FireTabAfterEnter = True
        Me.Num463.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num463.ForeColor = System.Drawing.Color.Red
        Me.Num463.Image = CType(resources.GetObject("Num463.Image"), System.Drawing.Image)
        Me.Num463.Location = New System.Drawing.Point(310, 210)
        Me.Num463.Maxlength = 10
        Me.Num463.MinusColor = System.Drawing.Color.Empty
        Me.Num463.Name = "Num463"
        Me.Num463.ReadOnly = True
        Me.Num463.Size = New System.Drawing.Size(89, 21)
        Me.Num463.TabIndex = 96
        Me.Num463.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num463.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num453
        '
        Me.Num453.BackColor = System.Drawing.Color.Gold
        Me.Num453.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num453.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num453.DecimalDigits = 0
        Me.Num453.DefaultSendValue = False
        Me.Num453.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num453.FireTabAfterEnter = True
        Me.Num453.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num453.Image = CType(resources.GetObject("Num453.Image"), System.Drawing.Image)
        Me.Num453.Location = New System.Drawing.Point(310, 179)
        Me.Num453.Maxlength = 10
        Me.Num453.MinusColor = System.Drawing.Color.Empty
        Me.Num453.Name = "Num453"
        Me.Num453.ReadOnly = True
        Me.Num453.Size = New System.Drawing.Size(89, 21)
        Me.Num453.TabIndex = 95
        Me.Num453.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num453.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num443
        '
        Me.Num443.BackColor = System.Drawing.Color.Gold
        Me.Num443.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num443.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num443.DecimalDigits = 0
        Me.Num443.DefaultSendValue = False
        Me.Num443.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num443.FireTabAfterEnter = True
        Me.Num443.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num443.ForeColor = System.Drawing.Color.Red
        Me.Num443.Image = CType(resources.GetObject("Num443.Image"), System.Drawing.Image)
        Me.Num443.Location = New System.Drawing.Point(310, 148)
        Me.Num443.Maxlength = 10
        Me.Num443.MinusColor = System.Drawing.Color.Empty
        Me.Num443.Name = "Num443"
        Me.Num443.ReadOnly = True
        Me.Num443.Size = New System.Drawing.Size(89, 21)
        Me.Num443.TabIndex = 94
        Me.Num443.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num443.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num433
        '
        Me.Num433.BackColor = System.Drawing.Color.Gold
        Me.Num433.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num433.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num433.DecimalDigits = 0
        Me.Num433.DefaultSendValue = False
        Me.Num433.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num433.FireTabAfterEnter = True
        Me.Num433.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num433.Image = CType(resources.GetObject("Num433.Image"), System.Drawing.Image)
        Me.Num433.Location = New System.Drawing.Point(310, 117)
        Me.Num433.Maxlength = 10
        Me.Num433.MinusColor = System.Drawing.Color.Empty
        Me.Num433.Name = "Num433"
        Me.Num433.ReadOnly = True
        Me.Num433.Size = New System.Drawing.Size(89, 21)
        Me.Num433.TabIndex = 93
        Me.Num433.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num433.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num423
        '
        Me.Num423.BackColor = System.Drawing.Color.Gold
        Me.Num423.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num423.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num423.DecimalDigits = 0
        Me.Num423.DefaultSendValue = False
        Me.Num423.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num423.FireTabAfterEnter = True
        Me.Num423.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num423.Image = CType(resources.GetObject("Num423.Image"), System.Drawing.Image)
        Me.Num423.Location = New System.Drawing.Point(310, 86)
        Me.Num423.Maxlength = 10
        Me.Num423.MinusColor = System.Drawing.Color.Empty
        Me.Num423.Name = "Num423"
        Me.Num423.ReadOnly = True
        Me.Num423.Size = New System.Drawing.Size(89, 21)
        Me.Num423.TabIndex = 92
        Me.Num423.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num423.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num413
        '
        Me.Num413.BackColor = System.Drawing.Color.Gold
        Me.Num413.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num413.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num413.DecimalDigits = 0
        Me.Num413.DefaultSendValue = False
        Me.Num413.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num413.FireTabAfterEnter = True
        Me.Num413.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num413.ForeColor = System.Drawing.Color.Red
        Me.Num413.Image = CType(resources.GetObject("Num413.Image"), System.Drawing.Image)
        Me.Num413.Location = New System.Drawing.Point(310, 55)
        Me.Num413.Maxlength = 10
        Me.Num413.MinusColor = System.Drawing.Color.Empty
        Me.Num413.Name = "Num413"
        Me.Num413.ReadOnly = True
        Me.Num413.Size = New System.Drawing.Size(89, 21)
        Me.Num413.TabIndex = 91
        Me.Num413.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num413.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num462
        '
        Me.Num462.BackColor = System.Drawing.Color.Gold
        Me.Num462.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num462.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num462.DecimalDigits = 2
        Me.Num462.DefaultSendValue = False
        Me.Num462.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num462.FireTabAfterEnter = True
        Me.Num462.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num462.ForeColor = System.Drawing.Color.Red
        Me.Num462.Image = CType(resources.GetObject("Num462.Image"), System.Drawing.Image)
        Me.Num462.Location = New System.Drawing.Point(217, 210)
        Me.Num462.Maxlength = 10
        Me.Num462.MinusColor = System.Drawing.Color.Empty
        Me.Num462.Name = "Num462"
        Me.Num462.ReadOnly = True
        Me.Num462.Size = New System.Drawing.Size(89, 21)
        Me.Num462.TabIndex = 90
        Me.Num462.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num462.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num452
        '
        Me.Num452.BackColor = System.Drawing.Color.Gold
        Me.Num452.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num452.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num452.DecimalDigits = 2
        Me.Num452.DefaultSendValue = False
        Me.Num452.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num452.FireTabAfterEnter = True
        Me.Num452.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num452.Image = CType(resources.GetObject("Num452.Image"), System.Drawing.Image)
        Me.Num452.Location = New System.Drawing.Point(217, 179)
        Me.Num452.Maxlength = 10
        Me.Num452.MinusColor = System.Drawing.Color.Empty
        Me.Num452.Name = "Num452"
        Me.Num452.ReadOnly = True
        Me.Num452.Size = New System.Drawing.Size(89, 21)
        Me.Num452.TabIndex = 89
        Me.Num452.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num452.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num442
        '
        Me.Num442.BackColor = System.Drawing.Color.Gold
        Me.Num442.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num442.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num442.DecimalDigits = 2
        Me.Num442.DefaultSendValue = False
        Me.Num442.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num442.FireTabAfterEnter = True
        Me.Num442.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num442.ForeColor = System.Drawing.Color.Red
        Me.Num442.Image = CType(resources.GetObject("Num442.Image"), System.Drawing.Image)
        Me.Num442.Location = New System.Drawing.Point(217, 148)
        Me.Num442.Maxlength = 10
        Me.Num442.MinusColor = System.Drawing.Color.Empty
        Me.Num442.Name = "Num442"
        Me.Num442.ReadOnly = True
        Me.Num442.Size = New System.Drawing.Size(89, 21)
        Me.Num442.TabIndex = 88
        Me.Num442.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num442.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num432
        '
        Me.Num432.BackColor = System.Drawing.Color.Gold
        Me.Num432.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num432.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num432.DecimalDigits = 2
        Me.Num432.DefaultSendValue = False
        Me.Num432.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num432.FireTabAfterEnter = True
        Me.Num432.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num432.Image = CType(resources.GetObject("Num432.Image"), System.Drawing.Image)
        Me.Num432.Location = New System.Drawing.Point(217, 117)
        Me.Num432.Maxlength = 10
        Me.Num432.MinusColor = System.Drawing.Color.Empty
        Me.Num432.Name = "Num432"
        Me.Num432.ReadOnly = True
        Me.Num432.Size = New System.Drawing.Size(89, 21)
        Me.Num432.TabIndex = 87
        Me.Num432.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num432.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num422
        '
        Me.Num422.BackColor = System.Drawing.Color.Gold
        Me.Num422.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num422.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num422.DecimalDigits = 2
        Me.Num422.DefaultSendValue = False
        Me.Num422.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num422.FireTabAfterEnter = True
        Me.Num422.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num422.Image = CType(resources.GetObject("Num422.Image"), System.Drawing.Image)
        Me.Num422.Location = New System.Drawing.Point(217, 86)
        Me.Num422.Maxlength = 10
        Me.Num422.MinusColor = System.Drawing.Color.Empty
        Me.Num422.Name = "Num422"
        Me.Num422.ReadOnly = True
        Me.Num422.Size = New System.Drawing.Size(89, 21)
        Me.Num422.TabIndex = 86
        Me.Num422.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num422.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num412
        '
        Me.Num412.BackColor = System.Drawing.Color.Gold
        Me.Num412.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num412.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num412.DecimalDigits = 2
        Me.Num412.DefaultSendValue = False
        Me.Num412.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num412.FireTabAfterEnter = True
        Me.Num412.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num412.ForeColor = System.Drawing.Color.Red
        Me.Num412.Image = CType(resources.GetObject("Num412.Image"), System.Drawing.Image)
        Me.Num412.Location = New System.Drawing.Point(217, 55)
        Me.Num412.Maxlength = 10
        Me.Num412.MinusColor = System.Drawing.Color.Empty
        Me.Num412.Name = "Num412"
        Me.Num412.ReadOnly = True
        Me.Num412.Size = New System.Drawing.Size(89, 21)
        Me.Num412.TabIndex = 85
        Me.Num412.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num412.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num481
        '
        Me.Num481.BackColor = System.Drawing.Color.YellowGreen
        Me.Num481.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num481.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num481.DecimalDigits = 2
        Me.Num481.DefaultSendValue = False
        Me.Num481.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num481.FireTabAfterEnter = True
        Me.Num481.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num481.Image = CType(resources.GetObject("Num481.Image"), System.Drawing.Image)
        Me.Num481.Location = New System.Drawing.Point(124, 272)
        Me.Num481.Maxlength = 10
        Me.Num481.MinusColor = System.Drawing.Color.Empty
        Me.Num481.Name = "Num481"
        Me.Num481.ReadOnly = True
        Me.Num481.Size = New System.Drawing.Size(89, 21)
        Me.Num481.TabIndex = 83
        Me.Num481.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num481.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num461
        '
        Me.Num461.BackColor = System.Drawing.Color.Gold
        Me.Num461.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num461.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num461.DecimalDigits = 2
        Me.Num461.DefaultSendValue = False
        Me.Num461.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num461.FireTabAfterEnter = True
        Me.Num461.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num461.ForeColor = System.Drawing.Color.Red
        Me.Num461.Image = CType(resources.GetObject("Num461.Image"), System.Drawing.Image)
        Me.Num461.Location = New System.Drawing.Point(124, 210)
        Me.Num461.Maxlength = 10
        Me.Num461.MinusColor = System.Drawing.Color.Empty
        Me.Num461.Name = "Num461"
        Me.Num461.ReadOnly = True
        Me.Num461.Size = New System.Drawing.Size(89, 21)
        Me.Num461.TabIndex = 82
        Me.Num461.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num461.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num451
        '
        Me.Num451.BackColor = System.Drawing.Color.Gold
        Me.Num451.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num451.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num451.DecimalDigits = 2
        Me.Num451.DefaultSendValue = False
        Me.Num451.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num451.FireTabAfterEnter = True
        Me.Num451.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num451.Image = CType(resources.GetObject("Num451.Image"), System.Drawing.Image)
        Me.Num451.Location = New System.Drawing.Point(124, 179)
        Me.Num451.Maxlength = 10
        Me.Num451.MinusColor = System.Drawing.Color.Empty
        Me.Num451.Name = "Num451"
        Me.Num451.ReadOnly = True
        Me.Num451.Size = New System.Drawing.Size(89, 21)
        Me.Num451.TabIndex = 81
        Me.Num451.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num451.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num441
        '
        Me.Num441.BackColor = System.Drawing.Color.Gold
        Me.Num441.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num441.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num441.DecimalDigits = 2
        Me.Num441.DefaultSendValue = False
        Me.Num441.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num441.FireTabAfterEnter = True
        Me.Num441.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num441.ForeColor = System.Drawing.Color.Red
        Me.Num441.Image = CType(resources.GetObject("Num441.Image"), System.Drawing.Image)
        Me.Num441.Location = New System.Drawing.Point(124, 148)
        Me.Num441.Maxlength = 10
        Me.Num441.MinusColor = System.Drawing.Color.Empty
        Me.Num441.Name = "Num441"
        Me.Num441.ReadOnly = True
        Me.Num441.Size = New System.Drawing.Size(89, 21)
        Me.Num441.TabIndex = 80
        Me.Num441.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num441.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num431
        '
        Me.Num431.BackColor = System.Drawing.Color.Gold
        Me.Num431.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num431.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num431.DecimalDigits = 2
        Me.Num431.DefaultSendValue = False
        Me.Num431.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num431.FireTabAfterEnter = True
        Me.Num431.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num431.Image = CType(resources.GetObject("Num431.Image"), System.Drawing.Image)
        Me.Num431.Location = New System.Drawing.Point(124, 117)
        Me.Num431.Maxlength = 10
        Me.Num431.MinusColor = System.Drawing.Color.Empty
        Me.Num431.Name = "Num431"
        Me.Num431.ReadOnly = True
        Me.Num431.Size = New System.Drawing.Size(89, 21)
        Me.Num431.TabIndex = 79
        Me.Num431.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num431.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num421
        '
        Me.Num421.BackColor = System.Drawing.Color.Gold
        Me.Num421.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num421.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num421.DecimalDigits = 2
        Me.Num421.DefaultSendValue = False
        Me.Num421.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num421.FireTabAfterEnter = True
        Me.Num421.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num421.Image = CType(resources.GetObject("Num421.Image"), System.Drawing.Image)
        Me.Num421.Location = New System.Drawing.Point(124, 86)
        Me.Num421.Maxlength = 10
        Me.Num421.MinusColor = System.Drawing.Color.Empty
        Me.Num421.Name = "Num421"
        Me.Num421.ReadOnly = True
        Me.Num421.Size = New System.Drawing.Size(89, 21)
        Me.Num421.TabIndex = 78
        Me.Num421.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num421.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num411
        '
        Me.Num411.BackColor = System.Drawing.Color.Gold
        Me.Num411.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num411.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num411.DecimalDigits = 2
        Me.Num411.DefaultSendValue = False
        Me.Num411.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num411.FireTabAfterEnter = True
        Me.Num411.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num411.ForeColor = System.Drawing.Color.Red
        Me.Num411.Image = CType(resources.GetObject("Num411.Image"), System.Drawing.Image)
        Me.Num411.Location = New System.Drawing.Point(124, 55)
        Me.Num411.Maxlength = 10
        Me.Num411.MinusColor = System.Drawing.Color.Empty
        Me.Num411.Name = "Num411"
        Me.Num411.ReadOnly = True
        Me.Num411.Size = New System.Drawing.Size(89, 21)
        Me.Num411.TabIndex = 77
        Me.Num411.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num411.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Lbl484
        '
        Me.Lbl484.BackColor = System.Drawing.Color.Transparent
        Me.Lbl484.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl484.ForeColor = System.Drawing.Color.Black
        Me.Lbl484.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Lbl484.Location = New System.Drawing.Point(429, 265)
        Me.Lbl484.Name = "Lbl484"
        Me.Lbl484.Size = New System.Drawing.Size(101, 23)
        Me.Lbl484.TabIndex = 76
        Me.Lbl484.Text = "Net Changes"
        Me.Lbl484.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl474
        '
        Me.Lbl474.BackColor = System.Drawing.Color.Transparent
        Me.Lbl474.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl474.ForeColor = System.Drawing.Color.Black
        Me.Lbl474.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Lbl474.Location = New System.Drawing.Point(429, 241)
        Me.Lbl474.Name = "Lbl474"
        Me.Lbl474.Size = New System.Drawing.Size(101, 23)
        Me.Lbl474.TabIndex = 75
        Me.Lbl474.Text = "Total Debits"
        Me.Lbl474.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblInventoryTurnOver
        '
        Me.LblInventoryTurnOver.BackColor = System.Drawing.Color.Transparent
        Me.LblInventoryTurnOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInventoryTurnOver.ForeColor = System.Drawing.Color.Black
        Me.LblInventoryTurnOver.Location = New System.Drawing.Point(539, 194)
        Me.LblInventoryTurnOver.Name = "LblInventoryTurnOver"
        Me.LblInventoryTurnOver.Size = New System.Drawing.Size(78, 23)
        Me.LblInventoryTurnOver.TabIndex = 74
        Me.LblInventoryTurnOver.Text = "Inventory Turn Over"
        Me.LblInventoryTurnOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl403
        '
        Me.Lbl403.BackColor = System.Drawing.Color.Transparent
        Me.Lbl403.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl403.Location = New System.Drawing.Point(310, 24)
        Me.Lbl403.Name = "Lbl403"
        Me.Lbl403.Size = New System.Drawing.Size(89, 34)
        Me.Lbl403.TabIndex = 72
        Me.Lbl403.Text = "No Of Transactions"
        Me.Lbl403.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl402
        '
        Me.Lbl402.BackColor = System.Drawing.Color.Transparent
        Me.Lbl402.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl402.Location = New System.Drawing.Point(217, 24)
        Me.Lbl402.Name = "Lbl402"
        Me.Lbl402.Size = New System.Drawing.Size(89, 34)
        Me.Lbl402.TabIndex = 71
        Me.Lbl402.Text = "Quantities"
        Me.Lbl402.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl401
        '
        Me.Lbl401.BackColor = System.Drawing.Color.Transparent
        Me.Lbl401.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl401.Location = New System.Drawing.Point(124, 24)
        Me.Lbl401.Name = "Lbl401"
        Me.Lbl401.Size = New System.Drawing.Size(89, 34)
        Me.Lbl401.TabIndex = 70
        Me.Lbl401.Text = "Dollar Amount"
        Me.Lbl401.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl418
        '
        Me.Lbl418.BackColor = System.Drawing.Color.Transparent
        Me.Lbl418.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl418.Location = New System.Drawing.Point(12, 272)
        Me.Lbl418.Name = "Lbl418"
        Me.Lbl418.Size = New System.Drawing.Size(104, 23)
        Me.Lbl418.TabIndex = 69
        Me.Lbl418.Text = "Purchase Orders"
        Me.Lbl418.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl417
        '
        Me.Lbl417.BackColor = System.Drawing.Color.Transparent
        Me.Lbl417.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl417.ForeColor = System.Drawing.Color.Red
        Me.Lbl417.Location = New System.Drawing.Point(12, 241)
        Me.Lbl417.Name = "Lbl417"
        Me.Lbl417.Size = New System.Drawing.Size(104, 23)
        Me.Lbl417.TabIndex = 68
        Me.Lbl417.Text = "Inter-Store Sales"
        Me.Lbl417.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl416
        '
        Me.Lbl416.BackColor = System.Drawing.Color.Transparent
        Me.Lbl416.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl416.ForeColor = System.Drawing.Color.Red
        Me.Lbl416.Location = New System.Drawing.Point(12, 210)
        Me.Lbl416.Name = "Lbl416"
        Me.Lbl416.Size = New System.Drawing.Size(104, 23)
        Me.Lbl416.TabIndex = 67
        Me.Lbl416.Text = "Transfers"
        Me.Lbl416.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl415
        '
        Me.Lbl415.BackColor = System.Drawing.Color.Transparent
        Me.Lbl415.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl415.Location = New System.Drawing.Point(12, 179)
        Me.Lbl415.Name = "Lbl415"
        Me.Lbl415.Size = New System.Drawing.Size(104, 23)
        Me.Lbl415.TabIndex = 66
        Me.Lbl415.Text = "Adjustments"
        Me.Lbl415.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl414
        '
        Me.Lbl414.BackColor = System.Drawing.Color.Transparent
        Me.Lbl414.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl414.ForeColor = System.Drawing.Color.Red
        Me.Lbl414.Location = New System.Drawing.Point(12, 148)
        Me.Lbl414.Name = "Lbl414"
        Me.Lbl414.Size = New System.Drawing.Size(104, 23)
        Me.Lbl414.TabIndex = 65
        Me.Lbl414.Text = "Returns"
        Me.Lbl414.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl413
        '
        Me.Lbl413.BackColor = System.Drawing.Color.Transparent
        Me.Lbl413.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl413.Location = New System.Drawing.Point(12, 117)
        Me.Lbl413.Name = "Lbl413"
        Me.Lbl413.Size = New System.Drawing.Size(104, 23)
        Me.Lbl413.TabIndex = 64
        Me.Lbl413.Text = "Inventory Receipts"
        Me.Lbl413.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl412
        '
        Me.Lbl412.BackColor = System.Drawing.Color.Transparent
        Me.Lbl412.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl412.ForeColor = System.Drawing.Color.Black
        Me.Lbl412.Location = New System.Drawing.Point(12, 86)
        Me.Lbl412.Name = "Lbl412"
        Me.Lbl412.Size = New System.Drawing.Size(104, 23)
        Me.Lbl412.TabIndex = 63
        Me.Lbl412.Text = "Customer Returns"
        Me.Lbl412.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl411
        '
        Me.Lbl411.BackColor = System.Drawing.Color.Transparent
        Me.Lbl411.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl411.ForeColor = System.Drawing.Color.Red
        Me.Lbl411.Location = New System.Drawing.Point(12, 55)
        Me.Lbl411.Name = "Lbl411"
        Me.Lbl411.Size = New System.Drawing.Size(104, 23)
        Me.Lbl411.TabIndex = 62
        Me.Lbl411.Text = "Inventory Sales"
        Me.Lbl411.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(-4, 3)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(152, 23)
        Me.Label50.TabIndex = 2
        Me.Label50.Text = "Products Summary"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UiTabPage5
        '
        Me.UiTabPage5.Controls.Add(Me.Num542)
        Me.UiTabPage5.Controls.Add(Me.Num532)
        Me.UiTabPage5.Controls.Add(Me.Num522)
        Me.UiTabPage5.Controls.Add(Me.Num512)
        Me.UiTabPage5.Controls.Add(Me.Num541)
        Me.UiTabPage5.Controls.Add(Me.Num531)
        Me.UiTabPage5.Controls.Add(Me.Num521)
        Me.UiTabPage5.Controls.Add(Me.Num511)
        Me.UiTabPage5.Controls.Add(Me.Lbl502)
        Me.UiTabPage5.Controls.Add(Me.Lbl501)
        Me.UiTabPage5.Controls.Add(Me.Lbl514)
        Me.UiTabPage5.Controls.Add(Me.Lbl513)
        Me.UiTabPage5.Controls.Add(Me.Lbl512)
        Me.UiTabPage5.Controls.Add(Me.Lbl511)
        Me.UiTabPage5.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage5.Name = "UiTabPage5"
        Me.UiTabPage5.Size = New System.Drawing.Size(635, 298)
        Me.UiTabPage5.TabIndex = 4
        Me.UiTabPage5.Text = "Services"
        '
        'Num542
        '
        Me.Num542.BackColor = System.Drawing.Color.YellowGreen
        Me.Num542.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num542.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num542.DecimalDigits = 2
        Me.Num542.DefaultSendValue = False
        Me.Num542.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num542.FireTabAfterEnter = True
        Me.Num542.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num542.ForeColor = System.Drawing.Color.Red
        Me.Num542.Image = CType(resources.GetObject("Num542.Image"), System.Drawing.Image)
        Me.Num542.Location = New System.Drawing.Point(257, 134)
        Me.Num542.Maxlength = 10
        Me.Num542.MinusColor = System.Drawing.Color.Empty
        Me.Num542.Name = "Num542"
        Me.Num542.ReadOnly = True
        Me.Num542.Size = New System.Drawing.Size(89, 21)
        Me.Num542.TabIndex = 51
        Me.Num542.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num542.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num532
        '
        Me.Num532.BackColor = System.Drawing.Color.Gold
        Me.Num532.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num532.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num532.DecimalDigits = 2
        Me.Num532.DefaultSendValue = False
        Me.Num532.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num532.FireTabAfterEnter = True
        Me.Num532.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num532.ForeColor = System.Drawing.Color.Red
        Me.Num532.Image = CType(resources.GetObject("Num532.Image"), System.Drawing.Image)
        Me.Num532.Location = New System.Drawing.Point(257, 105)
        Me.Num532.Maxlength = 10
        Me.Num532.MinusColor = System.Drawing.Color.Empty
        Me.Num532.Name = "Num532"
        Me.Num532.ReadOnly = True
        Me.Num532.Size = New System.Drawing.Size(89, 21)
        Me.Num532.TabIndex = 50
        Me.Num532.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num532.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num522
        '
        Me.Num522.BackColor = System.Drawing.Color.Gold
        Me.Num522.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num522.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num522.DecimalDigits = 2
        Me.Num522.DefaultSendValue = False
        Me.Num522.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num522.FireTabAfterEnter = True
        Me.Num522.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num522.ForeColor = System.Drawing.Color.Red
        Me.Num522.Image = CType(resources.GetObject("Num522.Image"), System.Drawing.Image)
        Me.Num522.Location = New System.Drawing.Point(257, 76)
        Me.Num522.Maxlength = 10
        Me.Num522.MinusColor = System.Drawing.Color.Empty
        Me.Num522.Name = "Num522"
        Me.Num522.ReadOnly = True
        Me.Num522.Size = New System.Drawing.Size(89, 21)
        Me.Num522.TabIndex = 49
        Me.Num522.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num522.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num512
        '
        Me.Num512.BackColor = System.Drawing.Color.Gold
        Me.Num512.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num512.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num512.DecimalDigits = 2
        Me.Num512.DefaultSendValue = False
        Me.Num512.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num512.FireTabAfterEnter = True
        Me.Num512.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num512.ForeColor = System.Drawing.Color.Red
        Me.Num512.Image = CType(resources.GetObject("Num512.Image"), System.Drawing.Image)
        Me.Num512.Location = New System.Drawing.Point(257, 47)
        Me.Num512.Maxlength = 10
        Me.Num512.MinusColor = System.Drawing.Color.Empty
        Me.Num512.Name = "Num512"
        Me.Num512.ReadOnly = True
        Me.Num512.Size = New System.Drawing.Size(89, 21)
        Me.Num512.TabIndex = 48
        Me.Num512.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num512.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num541
        '
        Me.Num541.BackColor = System.Drawing.Color.YellowGreen
        Me.Num541.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num541.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num541.DecimalDigits = 2
        Me.Num541.DefaultSendValue = False
        Me.Num541.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num541.FireTabAfterEnter = True
        Me.Num541.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num541.Image = CType(resources.GetObject("Num541.Image"), System.Drawing.Image)
        Me.Num541.Location = New System.Drawing.Point(148, 134)
        Me.Num541.Maxlength = 10
        Me.Num541.MinusColor = System.Drawing.Color.Empty
        Me.Num541.Name = "Num541"
        Me.Num541.ReadOnly = True
        Me.Num541.Size = New System.Drawing.Size(89, 21)
        Me.Num541.TabIndex = 47
        Me.Num541.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num541.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num531
        '
        Me.Num531.BackColor = System.Drawing.Color.Gold
        Me.Num531.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num531.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num531.DecimalDigits = 2
        Me.Num531.DefaultSendValue = False
        Me.Num531.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num531.FireTabAfterEnter = True
        Me.Num531.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num531.Image = CType(resources.GetObject("Num531.Image"), System.Drawing.Image)
        Me.Num531.Location = New System.Drawing.Point(148, 105)
        Me.Num531.Maxlength = 10
        Me.Num531.MinusColor = System.Drawing.Color.Empty
        Me.Num531.Name = "Num531"
        Me.Num531.ReadOnly = True
        Me.Num531.Size = New System.Drawing.Size(89, 21)
        Me.Num531.TabIndex = 46
        Me.Num531.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num531.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num521
        '
        Me.Num521.BackColor = System.Drawing.Color.Gold
        Me.Num521.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num521.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num521.DecimalDigits = 2
        Me.Num521.DefaultSendValue = False
        Me.Num521.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num521.FireTabAfterEnter = True
        Me.Num521.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num521.Image = CType(resources.GetObject("Num521.Image"), System.Drawing.Image)
        Me.Num521.Location = New System.Drawing.Point(148, 76)
        Me.Num521.Maxlength = 10
        Me.Num521.MinusColor = System.Drawing.Color.Empty
        Me.Num521.Name = "Num521"
        Me.Num521.ReadOnly = True
        Me.Num521.Size = New System.Drawing.Size(89, 21)
        Me.Num521.TabIndex = 45
        Me.Num521.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num521.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num511
        '
        Me.Num511.BackColor = System.Drawing.Color.Gold
        Me.Num511.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num511.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num511.DecimalDigits = 2
        Me.Num511.DefaultSendValue = False
        Me.Num511.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num511.FireTabAfterEnter = True
        Me.Num511.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num511.Image = CType(resources.GetObject("Num511.Image"), System.Drawing.Image)
        Me.Num511.Location = New System.Drawing.Point(148, 47)
        Me.Num511.Maxlength = 10
        Me.Num511.MinusColor = System.Drawing.Color.Empty
        Me.Num511.Name = "Num511"
        Me.Num511.ReadOnly = True
        Me.Num511.Size = New System.Drawing.Size(89, 21)
        Me.Num511.TabIndex = 44
        Me.Num511.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num511.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Lbl502
        '
        Me.Lbl502.BackColor = System.Drawing.Color.Transparent
        Me.Lbl502.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl502.ForeColor = System.Drawing.Color.Red
        Me.Lbl502.Location = New System.Drawing.Point(266, 23)
        Me.Lbl502.Name = "Lbl502"
        Me.Lbl502.Size = New System.Drawing.Size(72, 23)
        Me.Lbl502.TabIndex = 43
        Me.Lbl502.Text = "Returns"
        Me.Lbl502.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl501
        '
        Me.Lbl501.BackColor = System.Drawing.Color.Transparent
        Me.Lbl501.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl501.Location = New System.Drawing.Point(155, 23)
        Me.Lbl501.Name = "Lbl501"
        Me.Lbl501.Size = New System.Drawing.Size(72, 23)
        Me.Lbl501.TabIndex = 42
        Me.Lbl501.Text = "Sales"
        Me.Lbl501.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl514
        '
        Me.Lbl514.BackColor = System.Drawing.Color.Transparent
        Me.Lbl514.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl514.Location = New System.Drawing.Point(32, 134)
        Me.Lbl514.Name = "Lbl514"
        Me.Lbl514.Size = New System.Drawing.Size(102, 23)
        Me.Lbl514.TabIndex = 41
        Me.Lbl514.Text = "Total Services"
        Me.Lbl514.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl513
        '
        Me.Lbl513.BackColor = System.Drawing.Color.Transparent
        Me.Lbl513.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl513.Location = New System.Drawing.Point(32, 105)
        Me.Lbl513.Name = "Lbl513"
        Me.Lbl513.Size = New System.Drawing.Size(102, 23)
        Me.Lbl513.TabIndex = 40
        Me.Lbl513.Text = "Shop Supplies"
        Me.Lbl513.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl512
        '
        Me.Lbl512.BackColor = System.Drawing.Color.Transparent
        Me.Lbl512.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl512.ForeColor = System.Drawing.Color.Black
        Me.Lbl512.Location = New System.Drawing.Point(32, 76)
        Me.Lbl512.Name = "Lbl512"
        Me.Lbl512.Size = New System.Drawing.Size(102, 23)
        Me.Lbl512.TabIndex = 39
        Me.Lbl512.Text = "Fees"
        Me.Lbl512.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl511
        '
        Me.Lbl511.BackColor = System.Drawing.Color.Transparent
        Me.Lbl511.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl511.ForeColor = System.Drawing.Color.Black
        Me.Lbl511.Location = New System.Drawing.Point(32, 47)
        Me.Lbl511.Name = "Lbl511"
        Me.Lbl511.Size = New System.Drawing.Size(102, 23)
        Me.Lbl511.TabIndex = 38
        Me.Lbl511.Text = "Labor"
        Me.Lbl511.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UiTabPage6
        '
        Me.UiTabPage6.Controls.Add(Me.Lbl671)
        Me.UiTabPage6.Controls.Add(Me.Num671)
        Me.UiTabPage6.Controls.Add(Me.Lbl661)
        Me.UiTabPage6.Controls.Add(Me.Lbl651)
        Me.UiTabPage6.Controls.Add(Me.Num661)
        Me.UiTabPage6.Controls.Add(Me.Num651)
        Me.UiTabPage6.Controls.Add(Me.Lbl672)
        Me.UiTabPage6.Controls.Add(Me.Num672)
        Me.UiTabPage6.Controls.Add(Me.Lbl662)
        Me.UiTabPage6.Controls.Add(Me.Lbl652)
        Me.UiTabPage6.Controls.Add(Me.Num662)
        Me.UiTabPage6.Controls.Add(Me.Num652)
        Me.UiTabPage6.Controls.Add(Me.Lbl642)
        Me.UiTabPage6.Controls.Add(Me.Lbl632)
        Me.UiTabPage6.Controls.Add(Me.Lbl622)
        Me.UiTabPage6.Controls.Add(Me.Lbl612)
        Me.UiTabPage6.Controls.Add(Me.Lbl602)
        Me.UiTabPage6.Controls.Add(Me.Lbl601)
        Me.UiTabPage6.Controls.Add(Me.Num642)
        Me.UiTabPage6.Controls.Add(Me.Num632)
        Me.UiTabPage6.Controls.Add(Me.Num622)
        Me.UiTabPage6.Controls.Add(Me.Num612)
        Me.UiTabPage6.Controls.Add(Me.Num641)
        Me.UiTabPage6.Controls.Add(Me.Num631)
        Me.UiTabPage6.Controls.Add(Me.Num621)
        Me.UiTabPage6.Controls.Add(Me.Num611)
        Me.UiTabPage6.Controls.Add(Me.Lbl621)
        Me.UiTabPage6.Controls.Add(Me.Lbl611)
        Me.UiTabPage6.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage6.Name = "UiTabPage6"
        Me.UiTabPage6.Size = New System.Drawing.Size(635, 298)
        Me.UiTabPage6.TabIndex = 5
        Me.UiTabPage6.Text = "Banking"
        '
        'Lbl671
        '
        Me.Lbl671.BackColor = System.Drawing.Color.Transparent
        Me.Lbl671.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl671.ForeColor = System.Drawing.Color.Black
        Me.Lbl671.Location = New System.Drawing.Point(54, 242)
        Me.Lbl671.Name = "Lbl671"
        Me.Lbl671.Size = New System.Drawing.Size(109, 23)
        Me.Lbl671.TabIndex = 83
        Me.Lbl671.Text = "Total Bank Credits"
        Me.Lbl671.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Num671
        '
        Me.Num671.BackColor = System.Drawing.Color.YellowGreen
        Me.Num671.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num671.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num671.DecimalDigits = 2
        Me.Num671.DefaultSendValue = False
        Me.Num671.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num671.FireTabAfterEnter = True
        Me.Num671.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num671.Image = CType(resources.GetObject("Num671.Image"), System.Drawing.Image)
        Me.Num671.Location = New System.Drawing.Point(177, 241)
        Me.Num671.Maxlength = 10
        Me.Num671.MinusColor = System.Drawing.Color.Empty
        Me.Num671.Name = "Num671"
        Me.Num671.ReadOnly = True
        Me.Num671.Size = New System.Drawing.Size(89, 21)
        Me.Num671.TabIndex = 82
        Me.Num671.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num671.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Lbl661
        '
        Me.Lbl661.BackColor = System.Drawing.Color.Transparent
        Me.Lbl661.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl661.ForeColor = System.Drawing.Color.Black
        Me.Lbl661.Location = New System.Drawing.Point(54, 211)
        Me.Lbl661.Name = "Lbl661"
        Me.Lbl661.Size = New System.Drawing.Size(109, 23)
        Me.Lbl661.TabIndex = 81
        Me.Lbl661.Text = "Minus Adjustment"
        Me.Lbl661.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl651
        '
        Me.Lbl651.BackColor = System.Drawing.Color.Transparent
        Me.Lbl651.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl651.ForeColor = System.Drawing.Color.Black
        Me.Lbl651.Location = New System.Drawing.Point(54, 182)
        Me.Lbl651.Name = "Lbl651"
        Me.Lbl651.Size = New System.Drawing.Size(109, 23)
        Me.Lbl651.TabIndex = 80
        Me.Lbl651.Text = "Transfers From"
        Me.Lbl651.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Num661
        '
        Me.Num661.BackColor = System.Drawing.Color.Gold
        Me.Num661.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num661.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num661.DecimalDigits = 2
        Me.Num661.DefaultSendValue = False
        Me.Num661.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num661.FireTabAfterEnter = True
        Me.Num661.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num661.Image = CType(resources.GetObject("Num661.Image"), System.Drawing.Image)
        Me.Num661.Location = New System.Drawing.Point(177, 210)
        Me.Num661.Maxlength = 10
        Me.Num661.MinusColor = System.Drawing.Color.Empty
        Me.Num661.Name = "Num661"
        Me.Num661.ReadOnly = True
        Me.Num661.Size = New System.Drawing.Size(89, 21)
        Me.Num661.TabIndex = 79
        Me.Num661.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num661.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num651
        '
        Me.Num651.BackColor = System.Drawing.Color.Gold
        Me.Num651.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num651.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num651.DecimalDigits = 2
        Me.Num651.DefaultSendValue = False
        Me.Num651.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num651.FireTabAfterEnter = True
        Me.Num651.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num651.Image = CType(resources.GetObject("Num651.Image"), System.Drawing.Image)
        Me.Num651.Location = New System.Drawing.Point(177, 181)
        Me.Num651.Maxlength = 10
        Me.Num651.MinusColor = System.Drawing.Color.Empty
        Me.Num651.Name = "Num651"
        Me.Num651.ReadOnly = True
        Me.Num651.Size = New System.Drawing.Size(89, 21)
        Me.Num651.TabIndex = 78
        Me.Num651.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num651.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Lbl672
        '
        Me.Lbl672.BackColor = System.Drawing.Color.Transparent
        Me.Lbl672.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl672.ForeColor = System.Drawing.Color.Black
        Me.Lbl672.Location = New System.Drawing.Point(351, 244)
        Me.Lbl672.Name = "Lbl672"
        Me.Lbl672.Size = New System.Drawing.Size(124, 23)
        Me.Lbl672.TabIndex = 77
        Me.Lbl672.Text = "Total Bank Debits"
        Me.Lbl672.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Num672
        '
        Me.Num672.BackColor = System.Drawing.Color.YellowGreen
        Me.Num672.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num672.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num672.DecimalDigits = 2
        Me.Num672.DefaultSendValue = False
        Me.Num672.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num672.FireTabAfterEnter = True
        Me.Num672.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num672.Image = CType(resources.GetObject("Num672.Image"), System.Drawing.Image)
        Me.Num672.Location = New System.Drawing.Point(490, 243)
        Me.Num672.Maxlength = 10
        Me.Num672.MinusColor = System.Drawing.Color.Empty
        Me.Num672.Name = "Num672"
        Me.Num672.ReadOnly = True
        Me.Num672.Size = New System.Drawing.Size(89, 21)
        Me.Num672.TabIndex = 76
        Me.Num672.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num672.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Lbl662
        '
        Me.Lbl662.BackColor = System.Drawing.Color.Transparent
        Me.Lbl662.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl662.ForeColor = System.Drawing.Color.Black
        Me.Lbl662.Location = New System.Drawing.Point(351, 213)
        Me.Lbl662.Name = "Lbl662"
        Me.Lbl662.Size = New System.Drawing.Size(124, 23)
        Me.Lbl662.TabIndex = 75
        Me.Lbl662.Text = "Plus Adjustment"
        Me.Lbl662.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl652
        '
        Me.Lbl652.BackColor = System.Drawing.Color.Transparent
        Me.Lbl652.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl652.ForeColor = System.Drawing.Color.Black
        Me.Lbl652.Location = New System.Drawing.Point(351, 184)
        Me.Lbl652.Name = "Lbl652"
        Me.Lbl652.Size = New System.Drawing.Size(124, 23)
        Me.Lbl652.TabIndex = 74
        Me.Lbl652.Text = "Transfers To"
        Me.Lbl652.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Num662
        '
        Me.Num662.BackColor = System.Drawing.Color.Gold
        Me.Num662.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num662.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num662.DecimalDigits = 2
        Me.Num662.DefaultSendValue = False
        Me.Num662.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num662.FireTabAfterEnter = True
        Me.Num662.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num662.Image = CType(resources.GetObject("Num662.Image"), System.Drawing.Image)
        Me.Num662.Location = New System.Drawing.Point(490, 212)
        Me.Num662.Maxlength = 10
        Me.Num662.MinusColor = System.Drawing.Color.Empty
        Me.Num662.Name = "Num662"
        Me.Num662.ReadOnly = True
        Me.Num662.Size = New System.Drawing.Size(89, 21)
        Me.Num662.TabIndex = 73
        Me.Num662.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num662.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num652
        '
        Me.Num652.BackColor = System.Drawing.Color.Gold
        Me.Num652.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num652.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num652.DecimalDigits = 2
        Me.Num652.DefaultSendValue = False
        Me.Num652.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num652.FireTabAfterEnter = True
        Me.Num652.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num652.Image = CType(resources.GetObject("Num652.Image"), System.Drawing.Image)
        Me.Num652.Location = New System.Drawing.Point(490, 183)
        Me.Num652.Maxlength = 10
        Me.Num652.MinusColor = System.Drawing.Color.Empty
        Me.Num652.Name = "Num652"
        Me.Num652.ReadOnly = True
        Me.Num652.Size = New System.Drawing.Size(89, 21)
        Me.Num652.TabIndex = 72
        Me.Num652.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num652.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Lbl642
        '
        Me.Lbl642.BackColor = System.Drawing.Color.Transparent
        Me.Lbl642.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl642.ForeColor = System.Drawing.Color.Black
        Me.Lbl642.Location = New System.Drawing.Point(351, 151)
        Me.Lbl642.Name = "Lbl642"
        Me.Lbl642.Size = New System.Drawing.Size(124, 23)
        Me.Lbl642.TabIndex = 71
        Me.Lbl642.Text = "ATM Credits"
        Me.Lbl642.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl632
        '
        Me.Lbl632.BackColor = System.Drawing.Color.Transparent
        Me.Lbl632.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl632.ForeColor = System.Drawing.Color.Black
        Me.Lbl632.Location = New System.Drawing.Point(351, 122)
        Me.Lbl632.Name = "Lbl632"
        Me.Lbl632.Size = New System.Drawing.Size(124, 23)
        Me.Lbl632.TabIndex = 70
        Me.Lbl632.Text = "Credit Cards Deposit"
        Me.Lbl632.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl622
        '
        Me.Lbl622.BackColor = System.Drawing.Color.Transparent
        Me.Lbl622.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl622.ForeColor = System.Drawing.Color.Black
        Me.Lbl622.Location = New System.Drawing.Point(351, 92)
        Me.Lbl622.Name = "Lbl622"
        Me.Lbl622.Size = New System.Drawing.Size(124, 23)
        Me.Lbl622.TabIndex = 69
        Me.Lbl622.Text = "Check Deposit"
        Me.Lbl622.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl612
        '
        Me.Lbl612.BackColor = System.Drawing.Color.Transparent
        Me.Lbl612.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl612.ForeColor = System.Drawing.Color.Black
        Me.Lbl612.Location = New System.Drawing.Point(351, 63)
        Me.Lbl612.Name = "Lbl612"
        Me.Lbl612.Size = New System.Drawing.Size(124, 23)
        Me.Lbl612.TabIndex = 68
        Me.Lbl612.Text = "Cash Deposit"
        Me.Lbl612.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl602
        '
        Me.Lbl602.BackColor = System.Drawing.Color.Transparent
        Me.Lbl602.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl602.Location = New System.Drawing.Point(347, 9)
        Me.Lbl602.Name = "Lbl602"
        Me.Lbl602.Size = New System.Drawing.Size(266, 23)
        Me.Lbl602.TabIndex = 67
        Me.Lbl602.Text = "Deposits, Credits, Transfer In"
        Me.Lbl602.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl601
        '
        Me.Lbl601.BackColor = System.Drawing.Color.Transparent
        Me.Lbl601.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl601.Location = New System.Drawing.Point(13, 9)
        Me.Lbl601.Name = "Lbl601"
        Me.Lbl601.Size = New System.Drawing.Size(266, 23)
        Me.Lbl601.TabIndex = 66
        Me.Lbl601.Text = "Checks, Withdrawals, Transfer Outs"
        Me.Lbl601.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Num642
        '
        Me.Num642.BackColor = System.Drawing.Color.Gold
        Me.Num642.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num642.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num642.DecimalDigits = 2
        Me.Num642.DefaultSendValue = False
        Me.Num642.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num642.FireTabAfterEnter = True
        Me.Num642.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num642.Image = CType(resources.GetObject("Num642.Image"), System.Drawing.Image)
        Me.Num642.Location = New System.Drawing.Point(490, 150)
        Me.Num642.Maxlength = 10
        Me.Num642.MinusColor = System.Drawing.Color.Empty
        Me.Num642.Name = "Num642"
        Me.Num642.ReadOnly = True
        Me.Num642.Size = New System.Drawing.Size(89, 21)
        Me.Num642.TabIndex = 65
        Me.Num642.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num642.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num632
        '
        Me.Num632.BackColor = System.Drawing.Color.Gold
        Me.Num632.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num632.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num632.DecimalDigits = 2
        Me.Num632.DefaultSendValue = False
        Me.Num632.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num632.FireTabAfterEnter = True
        Me.Num632.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num632.Image = CType(resources.GetObject("Num632.Image"), System.Drawing.Image)
        Me.Num632.Location = New System.Drawing.Point(490, 121)
        Me.Num632.Maxlength = 10
        Me.Num632.MinusColor = System.Drawing.Color.Empty
        Me.Num632.Name = "Num632"
        Me.Num632.ReadOnly = True
        Me.Num632.Size = New System.Drawing.Size(89, 21)
        Me.Num632.TabIndex = 64
        Me.Num632.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num632.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num622
        '
        Me.Num622.BackColor = System.Drawing.Color.Gold
        Me.Num622.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num622.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num622.DecimalDigits = 2
        Me.Num622.DefaultSendValue = False
        Me.Num622.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num622.FireTabAfterEnter = True
        Me.Num622.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num622.Image = CType(resources.GetObject("Num622.Image"), System.Drawing.Image)
        Me.Num622.Location = New System.Drawing.Point(490, 92)
        Me.Num622.Maxlength = 10
        Me.Num622.MinusColor = System.Drawing.Color.Empty
        Me.Num622.Name = "Num622"
        Me.Num622.ReadOnly = True
        Me.Num622.Size = New System.Drawing.Size(89, 21)
        Me.Num622.TabIndex = 63
        Me.Num622.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num622.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num612
        '
        Me.Num612.BackColor = System.Drawing.Color.Gold
        Me.Num612.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num612.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num612.DecimalDigits = 2
        Me.Num612.DefaultSendValue = False
        Me.Num612.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num612.FireTabAfterEnter = True
        Me.Num612.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num612.Image = CType(resources.GetObject("Num612.Image"), System.Drawing.Image)
        Me.Num612.Location = New System.Drawing.Point(490, 63)
        Me.Num612.Maxlength = 10
        Me.Num612.MinusColor = System.Drawing.Color.Empty
        Me.Num612.Name = "Num612"
        Me.Num612.ReadOnly = True
        Me.Num612.Size = New System.Drawing.Size(89, 21)
        Me.Num612.TabIndex = 62
        Me.Num612.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num612.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num641
        '
        Me.Num641.BackColor = System.Drawing.Color.Black
        Me.Num641.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num641.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num641.DecimalDigits = 2
        Me.Num641.DefaultSendValue = False
        Me.Num641.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num641.FireTabAfterEnter = True
        Me.Num641.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num641.Image = CType(resources.GetObject("Num641.Image"), System.Drawing.Image)
        Me.Num641.Location = New System.Drawing.Point(177, 150)
        Me.Num641.Maxlength = 10
        Me.Num641.MinusColor = System.Drawing.Color.Empty
        Me.Num641.Name = "Num641"
        Me.Num641.ReadOnly = True
        Me.Num641.Size = New System.Drawing.Size(89, 21)
        Me.Num641.TabIndex = 61
        Me.Num641.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num641.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num631
        '
        Me.Num631.BackColor = System.Drawing.Color.Black
        Me.Num631.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num631.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num631.DecimalDigits = 2
        Me.Num631.DefaultSendValue = False
        Me.Num631.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num631.FireTabAfterEnter = True
        Me.Num631.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num631.Image = CType(resources.GetObject("Num631.Image"), System.Drawing.Image)
        Me.Num631.Location = New System.Drawing.Point(177, 121)
        Me.Num631.Maxlength = 10
        Me.Num631.MinusColor = System.Drawing.Color.Empty
        Me.Num631.Name = "Num631"
        Me.Num631.ReadOnly = True
        Me.Num631.Size = New System.Drawing.Size(89, 21)
        Me.Num631.TabIndex = 60
        Me.Num631.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num631.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num621
        '
        Me.Num621.BackColor = System.Drawing.Color.Gold
        Me.Num621.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num621.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num621.DecimalDigits = 2
        Me.Num621.DefaultSendValue = False
        Me.Num621.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num621.FireTabAfterEnter = True
        Me.Num621.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num621.Image = CType(resources.GetObject("Num621.Image"), System.Drawing.Image)
        Me.Num621.Location = New System.Drawing.Point(177, 92)
        Me.Num621.Maxlength = 10
        Me.Num621.MinusColor = System.Drawing.Color.Empty
        Me.Num621.Name = "Num621"
        Me.Num621.ReadOnly = True
        Me.Num621.Size = New System.Drawing.Size(89, 21)
        Me.Num621.TabIndex = 59
        Me.Num621.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num621.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Num611
        '
        Me.Num611.BackColor = System.Drawing.Color.Gold
        Me.Num611.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Num611.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.Num611.DecimalDigits = 2
        Me.Num611.DefaultSendValue = False
        Me.Num611.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Num611.FireTabAfterEnter = True
        Me.Num611.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Num611.Image = CType(resources.GetObject("Num611.Image"), System.Drawing.Image)
        Me.Num611.Location = New System.Drawing.Point(177, 63)
        Me.Num611.Maxlength = 10
        Me.Num611.MinusColor = System.Drawing.Color.Empty
        Me.Num611.Name = "Num611"
        Me.Num611.ReadOnly = True
        Me.Num611.Size = New System.Drawing.Size(89, 21)
        Me.Num611.TabIndex = 58
        Me.Num611.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Num611.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Lbl621
        '
        Me.Lbl621.BackColor = System.Drawing.Color.Transparent
        Me.Lbl621.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl621.ForeColor = System.Drawing.Color.Black
        Me.Lbl621.Location = New System.Drawing.Point(54, 92)
        Me.Lbl621.Name = "Lbl621"
        Me.Lbl621.Size = New System.Drawing.Size(109, 23)
        Me.Lbl621.TabIndex = 53
        Me.Lbl621.Text = "ATM Withdrawals"
        Me.Lbl621.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lbl611
        '
        Me.Lbl611.BackColor = System.Drawing.Color.Transparent
        Me.Lbl611.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl611.ForeColor = System.Drawing.Color.Black
        Me.Lbl611.Location = New System.Drawing.Point(54, 63)
        Me.Lbl611.Name = "Lbl611"
        Me.Lbl611.Size = New System.Drawing.Size(109, 23)
        Me.Lbl611.TabIndex = 52
        Me.Lbl611.Text = "Checks Written"
        Me.Lbl611.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UiTabPage7
        '
        Me.UiTabPage7.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPage7.Name = "UiTabPage7"
        Me.UiTabPage7.Size = New System.Drawing.Size(635, 298)
        Me.UiTabPage7.TabIndex = 6
        Me.UiTabPage7.Text = "G/L"
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=KETABIE;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=TireMate_02;password=sa"
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT GL_payment_deposit.payment_amount FROM GL_payment_deposit INNER JOIN servi" & _
        "ce_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_" & _
        "service_center INNER JOIN service_center_dtl ON service_center_head.id_service_c" & _
        "enter = service_center_dtl.id_service_center"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO service_center_dtl(id_service_center, radif, type_select, cod_select," & _
        " desc_radif, qty, price, fet, taxable, cod_technician, COMMENT_ARTICLE, AVERAGE_" & _
        "COST) VALUES (@id_service_center, @radif, @type_select, @cod_select, @desc_radif" & _
        ", @qty, @price, @fet, @taxable, @cod_technician, @COMMENT_ARTICLE, @AVERAGE_COST" & _
        "); SELECT id_service_center, radif, type_select, cod_select, desc_radif, qty, pr" & _
        "ice, fet, taxable, cod_technician, COMMENT_ARTICLE, AVERAGE_COST FROM service_ce" & _
        "nter_dtl WHERE (id_service_center = @id_service_center) AND (radif = @radif)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_select", System.Data.SqlDbType.VarChar, 1, "type_select"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_select", System.Data.SqlDbType.VarChar, 20, "cod_select"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_radif", System.Data.SqlDbType.VarChar, 100, "desc_radif"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@qty", System.Data.SqlDbType.Money, 8, "qty"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Money, 8, "price"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fet", System.Data.SqlDbType.Money, 8, "fet"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@taxable", System.Data.SqlDbType.Bit, 1, "taxable"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_technician", System.Data.SqlDbType.VarChar, 5, "cod_technician"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@COMMENT_ARTICLE", System.Data.SqlDbType.VarChar, 300, "COMMENT_ARTICLE"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AVERAGE_COST", System.Data.SqlDbType.Money, 8, "AVERAGE_COST"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE service_center_dtl SET id_service_center = @id_service_center, radif = @ra" & _
        "dif, type_select = @type_select, cod_select = @cod_select, desc_radif = @desc_ra" & _
        "dif, qty = @qty, price = @price, fet = @fet, taxable = @taxable, cod_technician " & _
        "= @cod_technician, COMMENT_ARTICLE = @COMMENT_ARTICLE, AVERAGE_COST = @AVERAGE_C" & _
        "OST WHERE (id_service_center = @Original_id_service_center) AND (radif = @Origin" & _
        "al_radif) AND (AVERAGE_COST = @Original_AVERAGE_COST OR @Original_AVERAGE_COST I" & _
        "S NULL AND AVERAGE_COST IS NULL) AND (COMMENT_ARTICLE = @Original_COMMENT_ARTICL" & _
        "E OR @Original_COMMENT_ARTICLE IS NULL AND COMMENT_ARTICLE IS NULL) AND (cod_sel" & _
        "ect = @Original_cod_select OR @Original_cod_select IS NULL AND cod_select IS NUL" & _
        "L) AND (cod_technician = @Original_cod_technician OR @Original_cod_technician IS" & _
        " NULL AND cod_technician IS NULL) AND (desc_radif = @Original_desc_radif OR @Ori" & _
        "ginal_desc_radif IS NULL AND desc_radif IS NULL) AND (fet = @Original_fet) AND (" & _
        "price = @Original_price) AND (qty = @Original_qty) AND (taxable = @Original_taxa" & _
        "ble OR @Original_taxable IS NULL AND taxable IS NULL) AND (type_select = @Origin" & _
        "al_type_select OR @Original_type_select IS NULL AND type_select IS NULL); SELECT" & _
        " id_service_center, radif, type_select, cod_select, desc_radif, qty, price, fet," & _
        " taxable, cod_technician, COMMENT_ARTICLE, AVERAGE_COST FROM service_center_dtl " & _
        "WHERE (id_service_center = @id_service_center) AND (radif = @radif)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_select", System.Data.SqlDbType.VarChar, 1, "type_select"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_select", System.Data.SqlDbType.VarChar, 20, "cod_select"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_radif", System.Data.SqlDbType.VarChar, 100, "desc_radif"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@qty", System.Data.SqlDbType.Money, 8, "qty"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Money, 8, "price"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fet", System.Data.SqlDbType.Money, 8, "fet"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@taxable", System.Data.SqlDbType.Bit, 1, "taxable"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_technician", System.Data.SqlDbType.VarChar, 5, "cod_technician"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@COMMENT_ARTICLE", System.Data.SqlDbType.VarChar, 300, "COMMENT_ARTICLE"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AVERAGE_COST", System.Data.SqlDbType.Money, 8, "AVERAGE_COST"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AVERAGE_COST", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AVERAGE_COST", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_COMMENT_ARTICLE", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMMENT_ARTICLE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_select", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_select", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_technician", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_technician", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_radif", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fet", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_qty", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "qty", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_taxable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "taxable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_select", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_select", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM service_center_dtl WHERE (id_service_center = @Original_id_service_ce" & _
        "nter) AND (radif = @Original_radif) AND (AVERAGE_COST = @Original_AVERAGE_COST O" & _
        "R @Original_AVERAGE_COST IS NULL AND AVERAGE_COST IS NULL) AND (COMMENT_ARTICLE " & _
        "= @Original_COMMENT_ARTICLE OR @Original_COMMENT_ARTICLE IS NULL AND COMMENT_ART" & _
        "ICLE IS NULL) AND (cod_select = @Original_cod_select OR @Original_cod_select IS " & _
        "NULL AND cod_select IS NULL) AND (cod_technician = @Original_cod_technician OR @" & _
        "Original_cod_technician IS NULL AND cod_technician IS NULL) AND (desc_radif = @O" & _
        "riginal_desc_radif OR @Original_desc_radif IS NULL AND desc_radif IS NULL) AND (" & _
        "fet = @Original_fet) AND (price = @Original_price) AND (qty = @Original_qty) AND" & _
        " (taxable = @Original_taxable OR @Original_taxable IS NULL AND taxable IS NULL) " & _
        "AND (type_select = @Original_type_select OR @Original_type_select IS NULL AND ty" & _
        "pe_select IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AVERAGE_COST", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AVERAGE_COST", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_COMMENT_ARTICLE", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMMENT_ARTICLE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_select", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_select", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_technician", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_technician", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_radif", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fet", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_qty", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "qty", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_taxable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "taxable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_select", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_select", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("type_select", "type_select"), New System.Data.Common.DataColumnMapping("cod_select", "cod_select"), New System.Data.Common.DataColumnMapping("desc_radif", "desc_radif"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("cod_technician", "cod_technician"), New System.Data.Common.DataColumnMapping("COMMENT_ARTICLE", "COMMENT_ARTICLE"), New System.Data.Common.DataColumnMapping("AVERAGE_COST", "AVERAGE_COST")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(153, 47)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(58, 23)
        Me.Label28.TabIndex = 131
        Me.Label28.Text = "From Date"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(324, 46)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(48, 23)
        Me.Label29.TabIndex = 132
        Me.Label29.Text = "To Date"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnFill
        '
        Me.BtnFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFill.Location = New System.Drawing.Point(488, 48)
        Me.BtnFill.Name = "BtnFill"
        Me.BtnFill.Size = New System.Drawing.Size(80, 23)
        Me.BtnFill.TabIndex = 2
        Me.BtnFill.Text = "Fill"
        '
        'CmdGeneralForReader
        '
        Me.CmdGeneralForReader.Connection = Me.CnnForReader
        '
        'CnnForReader
        '
        Me.CnnForReader.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;" & _
        "persist security info=True;password=sa"
        '
        'DteFromDate
        '
        Me.DteFromDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DteFromDate.BorderColor = System.Drawing.Color.Empty
        Me.DteFromDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteFromDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteFromDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteFromDate.EditableSal = True
        Me.DteFromDate.Image = CType(resources.GetObject("DteFromDate.Image"), System.Drawing.Image)
        Me.DteFromDate.Location = New System.Drawing.Point(215, 47)
        Me.DteFromDate.MaxValue = CType(2500, Short)
        Me.DteFromDate.MinValue = CType(1800, Short)
        Me.DteFromDate.Name = "DteFromDate"
        Me.DteFromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteFromDate.Sal_Mali = Nothing
        Me.DteFromDate.ShowButton = True
        Me.DteFromDate.Size = New System.Drawing.Size(104, 23)
        Me.DteFromDate.TabIndex = 0
        Me.DteFromDate.VisualStyle = False
        '
        'DteToDate
        '
        Me.DteToDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DteToDate.BorderColor = System.Drawing.Color.Empty
        Me.DteToDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DteToDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.DteToDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.DteToDate.EditableSal = True
        Me.DteToDate.Image = CType(resources.GetObject("DteToDate.Image"), System.Drawing.Image)
        Me.DteToDate.Location = New System.Drawing.Point(372, 47)
        Me.DteToDate.MaxValue = CType(2500, Short)
        Me.DteToDate.MinValue = CType(1800, Short)
        Me.DteToDate.Name = "DteToDate"
        Me.DteToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DteToDate.Sal_Mali = Nothing
        Me.DteToDate.ShowButton = True
        Me.DteToDate.Size = New System.Drawing.Size(106, 23)
        Me.DteToDate.TabIndex = 1
        Me.DteToDate.VisualStyle = False
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cc_type, cc_type_desc FROM bas_cc_type WHERE (bank_deposit_group = @bank_d" & _
        "eposit_group)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@bank_deposit_group", System.Data.SqlDbType.VarChar, 1, "bank_deposit_group"))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO bas_cc_type(cc_type, cc_type_desc, bank_deposit_group) VALUES (@cc_ty" & _
        "pe, @cc_type_desc, @bank_deposit_group); SELECT cc_type, cc_type_desc, bank_depo" & _
        "sit_group FROM bas_cc_type WHERE (cc_type = @cc_type)"
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cc_type", System.Data.SqlDbType.VarChar, 2, "cc_type"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cc_type_desc", System.Data.SqlDbType.VarChar, 50, "cc_type_desc"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@bank_deposit_group", System.Data.SqlDbType.VarChar, 1, "bank_deposit_group"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE bas_cc_type SET cc_type = @cc_type, cc_type_desc = @cc_type_desc, bank_dep" & _
        "osit_group = @bank_deposit_group WHERE (cc_type = @Original_cc_type) AND (bank_d" & _
        "eposit_group = @Original_bank_deposit_group OR @Original_bank_deposit_group IS N" & _
        "ULL AND bank_deposit_group IS NULL) AND (cc_type_desc = @Original_cc_type_desc O" & _
        "R @Original_cc_type_desc IS NULL AND cc_type_desc IS NULL); SELECT cc_type, cc_t" & _
        "ype_desc, bank_deposit_group FROM bas_cc_type WHERE (cc_type = @cc_type)"
        Me.SqlUpdateCommand2.Connection = Me.Cnn
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cc_type", System.Data.SqlDbType.VarChar, 2, "cc_type"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cc_type_desc", System.Data.SqlDbType.VarChar, 50, "cc_type_desc"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@bank_deposit_group", System.Data.SqlDbType.VarChar, 1, "bank_deposit_group"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cc_type", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cc_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_bank_deposit_group", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bank_deposit_group", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cc_type_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cc_type_desc", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM bas_cc_type WHERE (cc_type = @Original_cc_type) AND (bank_deposit_gro" & _
        "up = @Original_bank_deposit_group OR @Original_bank_deposit_group IS NULL AND ba" & _
        "nk_deposit_group IS NULL) AND (cc_type_desc = @Original_cc_type_desc OR @Origina" & _
        "l_cc_type_desc IS NULL AND cc_type_desc IS NULL)"
        Me.SqlDeleteCommand2.Connection = Me.Cnn
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cc_type", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cc_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_bank_deposit_group", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "bank_deposit_group", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cc_type_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cc_type_desc", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAbas_cc_type
        '
        Me.DAbas_cc_type.DeleteCommand = Me.SqlDeleteCommand2
        Me.DAbas_cc_type.InsertCommand = Me.SqlInsertCommand2
        Me.DAbas_cc_type.SelectCommand = Me.SqlSelectCommand2
        Me.DAbas_cc_type.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_cc_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cc_type", "cc_type"), New System.Data.Common.DataColumnMapping("cc_type_desc", "cc_type_desc"), New System.Data.Common.DataColumnMapping("bank_deposit_group", "bank_deposit_group")})})
        Me.DAbas_cc_type.UpdateCommand = Me.SqlUpdateCommand2
        '
        'DsFrmEndOfDay1
        '
        Me.DsFrmEndOfDay1.DataSetName = "DSFrmEndOfDay"
        Me.DsFrmEndOfDay1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'c11
        '
        Me.c11.Key = "c1"
        Me.c11.Name = "c11"
        Me.c11.Text = "c1"
        '
        'FrmEndOfDay
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(686, 397)
        Me.Controls.Add(Me.DteToDate)
        Me.Controls.Add(Me.DteFromDate)
        Me.Controls.Add(Me.BtnFill)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.UiTab1)
        Me.Controls.Add(Me.LblStoreNo)
        Me.Controls.Add(Me.LblCompanyName)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmEndOfDay"
        Me.Text = "Store Sales Audit Summary"
        Me.Panel4.ResumeLayout(False)
        CType(Me.UiContextMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1.EditContextMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTab1.ResumeLayout(False)
        Me.UiTabPage1.ResumeLayout(False)
        Me.UiTabPage2.ResumeLayout(False)
        Me.UiTabPage3.ResumeLayout(False)
        Me.UiTabPage4.ResumeLayout(False)
        Me.UiTabPage5.ResumeLayout(False)
        Me.UiTabPage6.ResumeLayout(False)
        CType(Me.DsFrmEndOfDay1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmEndOfDay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        CnnForReader.ConnectionString = PConnectionString
        LblCompanyName.Text = PubCompanyName
        LblStoreNo.Text = PubStoreName
        DteFromDate.Text = Format(Now.Date, PubDateFormat)
        DteToDate.Text = Format(Now.Date, PubDateFormat)
        Call FillCCLabels()
    End Sub
    Private Sub FillCCLabels()
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        If CmdGeneralForReader.Connection.State <> ConnectionState.Open Then
            CmdGeneralForReader.Connection.Open()
        End If
        CmdGeneralForReader.CommandText = "SELECT Bank_Deposit_Group,bank_deposit_group_desc FROM bas_cc_type_group Order By Bank_Deposit_Group"
        SQLReader = CmdGeneralForReader.ExecuteReader
        If SQLReader.HasRows Then
            Dim i As Integer = 1
            Do While SQLReader.Read()
                Select Case SQLReader.Item("Bank_Deposit_Group")
                    Case "1"
                        LblCC1.Text = SQLReader.Item("bank_deposit_group_desc")
                        DsFrmEndOfDay1.bas_cc_type.Clear()
                        DAbas_cc_type.SelectCommand.Parameters("@bank_deposit_group").Value = "1"
                        DAbas_cc_type.Fill(DsFrmEndOfDay1.bas_cc_type)
                        If DsFrmEndOfDay1.bas_cc_type.Rows.Count > 0 Then
                            For i = 0 To DsFrmEndOfDay1.bas_cc_type.Rows.Count - 1
                                If WhereCaluseCC1.Trim.Length = 0 Then
                                    WhereCaluseCC1 = WhereCaluseCC1 & " AND (cc_type=" & Qt(DsFrmEndOfDay1.bas_cc_type.Rows(i).Item("cc_type"))
                                Else
                                    WhereCaluseCC1 = WhereCaluseCC1 & " OR cc_type=" & Qt(DsFrmEndOfDay1.bas_cc_type.Rows(i).Item("cc_type"))
                                End If
                            Next
                            If WhereCaluseCC1.Trim.Length > 0 Then
                                WhereCaluseCC1 = WhereCaluseCC1 & ") "
                            End If
                        End If
                    Case "2"
                        LblCC2.Text = SQLReader.Item("bank_deposit_group_desc")
                        DsFrmEndOfDay1.bas_cc_type.Clear()
                        DAbas_cc_type.SelectCommand.Parameters("@bank_deposit_group").Value = "2"
                        DAbas_cc_type.Fill(DsFrmEndOfDay1.bas_cc_type)
                        If DsFrmEndOfDay1.bas_cc_type.Rows.Count > 0 Then
                            For i = 0 To DsFrmEndOfDay1.bas_cc_type.Rows.Count - 1
                                If WhereCaluseCC2.Trim.Length = 0 Then
                                    WhereCaluseCC2 = WhereCaluseCC2 & " AND (cc_type=" & Qt(DsFrmEndOfDay1.bas_cc_type.Rows(i).Item("cc_type"))
                                Else
                                    WhereCaluseCC2 = WhereCaluseCC2 & " OR cc_type=" & Qt(DsFrmEndOfDay1.bas_cc_type.Rows(i).Item("cc_type"))
                                End If
                            Next
                            If WhereCaluseCC2.Trim.Length > 0 Then
                                WhereCaluseCC2 = WhereCaluseCC2 & ") "
                            End If
                        End If
                    Case "3"
                        LblCC3.Text = SQLReader.Item("bank_deposit_group_desc")
                        DsFrmEndOfDay1.bas_cc_type.Clear()
                        DAbas_cc_type.SelectCommand.Parameters("@bank_deposit_group").Value = "3"
                        DAbas_cc_type.Fill(DsFrmEndOfDay1.bas_cc_type)
                        If DsFrmEndOfDay1.bas_cc_type.Rows.Count > 0 Then
                            For i = 0 To DsFrmEndOfDay1.bas_cc_type.Rows.Count - 1
                                If WhereCaluseCC3.Trim.Length = 0 Then
                                    WhereCaluseCC3 = WhereCaluseCC3 & " AND (cc_type=" & Qt(DsFrmEndOfDay1.bas_cc_type.Rows(i).Item("cc_type"))
                                Else
                                    WhereCaluseCC3 = WhereCaluseCC3 & " OR cc_type=" & Qt(DsFrmEndOfDay1.bas_cc_type.Rows(i).Item("cc_type"))
                                End If
                            Next
                            If WhereCaluseCC3.Trim.Length > 0 Then
                                WhereCaluseCC3 = WhereCaluseCC3 & ") "
                            End If
                        End If
                    Case "4"
                        LblCC4.Text = SQLReader.Item("bank_deposit_group_desc")
                        DsFrmEndOfDay1.bas_cc_type.Clear()
                        DAbas_cc_type.SelectCommand.Parameters("@bank_deposit_group").Value = "4"
                        DAbas_cc_type.Fill(DsFrmEndOfDay1.bas_cc_type)
                        If DsFrmEndOfDay1.bas_cc_type.Rows.Count > 0 Then
                            For i = 0 To DsFrmEndOfDay1.bas_cc_type.Rows.Count - 1
                                If WhereCaluseCC4.Trim.Length = 0 Then
                                    WhereCaluseCC4 = WhereCaluseCC4 & " AND (cc_type=" & Qt(DsFrmEndOfDay1.bas_cc_type.Rows(i).Item("cc_type"))
                                Else
                                    WhereCaluseCC4 = WhereCaluseCC4 & " OR cc_type=" & Qt(DsFrmEndOfDay1.bas_cc_type.Rows(i).Item("cc_type"))
                                End If
                            Next
                            If WhereCaluseCC4.Trim.Length > 0 Then
                                WhereCaluseCC4 = WhereCaluseCC4 & ") "
                            End If
                        End If
                    Case "5"
                        LblCC5.Text = SQLReader.Item("bank_deposit_group_desc")
                        DsFrmEndOfDay1.bas_cc_type.Clear()
                        DAbas_cc_type.SelectCommand.Parameters("@bank_deposit_group").Value = "5"
                        DAbas_cc_type.Fill(DsFrmEndOfDay1.bas_cc_type)
                        If DsFrmEndOfDay1.bas_cc_type.Rows.Count > 0 Then
                            For i = 0 To DsFrmEndOfDay1.bas_cc_type.Rows.Count - 1
                                If WhereCaluseCC5.Trim.Length = 0 Then
                                    WhereCaluseCC5 = WhereCaluseCC5 & " AND (cc_type=" & Qt(DsFrmEndOfDay1.bas_cc_type.Rows(i).Item("cc_type"))
                                Else
                                    WhereCaluseCC5 = WhereCaluseCC5 & " OR cc_type=" & Qt(DsFrmEndOfDay1.bas_cc_type.Rows(i).Item("cc_type"))
                                End If
                            Next
                            If WhereCaluseCC5.Trim.Length > 0 Then
                                WhereCaluseCC5 = WhereCaluseCC5 & ") "
                            End If
                        End If
                End Select
            Loop
        Else
            MsgBox("CC type Table is Empty.Please call to your vendor.")
        End If
        If WhereCaluseCC1.Trim.Length = 0 Then
            WhereCaluseCC1 = " AND 1=2 "
        End If
        If WhereCaluseCC2.Trim.Length = 0 Then
            WhereCaluseCC2 = " AND 1=2 "
        End If
        If WhereCaluseCC3.Trim.Length = 0 Then
            WhereCaluseCC3 = " AND 1=2 "
        End If
        If WhereCaluseCC4.Trim.Length = 0 Then
            WhereCaluseCC4 = " AND 1=2 "
        End If
        If WhereCaluseCC5.Trim.Length = 0 Then
            WhereCaluseCC5 = " AND 1=2 "
        End If
    End Sub
    Private Sub BtnFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFill.Click
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then





        End If
        Call MyCalculate()
    End Sub
    Private Function MyCalculate() As Decimal
        Dim TempVal As Decimal

        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If

        '**********************************************************************************
        '**********************************************************************************
        '***************************************   1   ************************************
        '**********************************************************************************
        '**********************************************************************************
        '***************** Paid Out *************************
        '############################################################################################################
        WhereClause = " AND dbo.changedate(action_date)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(action_date)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "SELECT Sum(GL_Paid_received.amount) FROM GL_Paid_received LEFT OUTER JOIN " & _
                      " cust_trtab_main ON GL_Paid_received.customer_code = cust_trtab_main.cod_customer LEFT OUTER JOIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
                      " Where GL_Paid_received.tran_type='1' " & WhereClause
        Try
            NumPaidOutCP.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumPaidOutCP.Text = 0
        End Try

        '***************** 11 *************************
        '############################################################################################################
        WhereClause = " AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "SELECT  SUM(GL_payment_cash.cash_rendered - GL_payment_cash.change_due) AS Expr1 " & _
                      " FROM GL_payment_cash INNER JOIN " & _
                      " GL_payment_deposit ON GL_payment_cash.ID_payment = GL_payment_deposit.ID_payment INNER JOIN " & _
                      " service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center " & _
                      " Where GL_payment_deposit.refer_type = '1' AND service_center_Head.type_of_form='IN' AND GL_payment_deposit.payment_type='1' " & WhereClause
        Try
            Num111.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num111.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(GL_payment_deposit.payment_amount) FROM GL_payment_deposit INNER JOIN " & _
                      " service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center " & _
                      " Where GL_payment_deposit.refer_type = '1' AND service_center_head.type_of_form='IN' AND GL_payment_deposit.payment_type='2' " & WhereClause
        Try
            Num121.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num121.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(GL_payment_deposit.payment_amount) FROM GL_payment_deposit INNER JOIN " & _
                      " service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center " & _
                      " Where GL_payment_deposit.refer_type = '1' AND service_center_head.type_of_form='IN' AND GL_payment_deposit.payment_type='3' " & WhereClause
        Try
            Num131.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num131.Text = 0
        End Try

        Num141.Text = Num111.Numbervalue + Num121.Numbervalue + Num131.Numbervalue

        CmdGeneral.CommandText = "SELECT sum(GL_payment_deposit.payment_amount) FROM GL_payment_deposit INNER JOIN " & _
                      " service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center INNER JOIN " & _
                      " GL_payment_credit ON GL_payment_deposit.ID_payment = GL_payment_credit.ID_payment " & _
                      " Where GL_payment_deposit.refer_type = '1' AND service_center_head.type_of_form='IN' AND GL_payment_deposit.payment_type='3' " & WhereCaluseCC1 & WhereClause
        Try
            Num151.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num151.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(GL_payment_deposit.payment_amount) FROM GL_payment_deposit INNER JOIN " & _
                      " service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center INNER JOIN " & _
                      " GL_payment_credit ON GL_payment_deposit.ID_payment = GL_payment_credit.ID_payment " & _
                      " Where GL_payment_deposit.refer_type = '1' AND service_center_head.type_of_form='IN' AND GL_payment_deposit.payment_type='3' " & WhereCaluseCC2 & WhereClause
        Try
            Num161.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num161.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(GL_payment_deposit.payment_amount) FROM GL_payment_deposit INNER JOIN " & _
                      " service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center INNER JOIN " & _
                      " GL_payment_credit ON GL_payment_deposit.ID_payment = GL_payment_credit.ID_payment " & _
                      " Where GL_payment_deposit.refer_type = '1' AND service_center_head.type_of_form='IN' AND GL_payment_deposit.payment_type='3' " & WhereCaluseCC3 & WhereClause
        Try
            Num171.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num171.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(GL_payment_deposit.payment_amount) FROM GL_payment_deposit INNER JOIN " & _
                      " service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center INNER JOIN " & _
                      " GL_payment_credit ON GL_payment_deposit.ID_payment = GL_payment_credit.ID_payment " & _
                      " Where GL_payment_deposit.refer_type = '1' AND service_center_head.type_of_form='IN' AND GL_payment_deposit.payment_type='3' " & WhereCaluseCC4 & WhereClause
        Try
            Num181.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num181.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(GL_payment_deposit.payment_amount) FROM GL_payment_deposit INNER JOIN " & _
                      " service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center INNER JOIN " & _
                      " GL_payment_credit ON GL_payment_deposit.ID_payment = GL_payment_credit.ID_payment " & _
                      " Where GL_payment_deposit.refer_type = '1' AND service_center_head.type_of_form='IN' AND GL_payment_deposit.payment_type='3' " & WhereCaluseCC5 & WhereClause
        Try
            Num191.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num191.Text = 0
        End Try

        '***************** 12 *************************
        '############################################################################################################
        WhereClause = " AND dbo.changedate(date_receive_payment)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_receive_payment)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "SELECT sum(round(Gl_receive_payment.amount_receive,2)) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN " & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.pmt_method = '1' AND refrence_no not in (SELECT DISTINCT isnull(refrence_no, '') FROM GL_payment_deposit WHERE (refer_type = '3')) " & WhereClause
        '" Where GL_payment_deposit.refer_type = '2' AND GL_payment_deposit.payment_type='1' " & WhereClause
        '" Where GL_payment_deposit.refer_type = '2' AND service_center_Head.type_of_form='IN' AND GL_payment_deposit.payment_type='1' " & WhereClause
        Try
            Num112.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num112.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(round(Gl_receive_payment.amount_receive,2)) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN " & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.pmt_method = '2' AND refrence_no not in (SELECT DISTINCT isnull(refrence_no, '') FROM GL_payment_deposit WHERE (refer_type = '3')) " & WhereClause
        '" Where GL_payment_deposit.refer_type = '2' AND GL_payment_deposit.payment_type='2' " & WhereClause
        '" Where GL_payment_deposit.refer_type = '2' AND service_center_Head.type_of_form='IN' AND GL_payment_deposit.payment_type='1' " & WhereClause
        Try
            Num122.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num122.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(round(Gl_receive_payment.amount_receive,2)) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN " & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.pmt_method = '3' AND refrence_no not in (SELECT DISTINCT isnull(refrence_no, '') FROM GL_payment_deposit WHERE (refer_type = '3')) " & WhereClause
        '" Where GL_payment_deposit.refer_type = '2' AND GL_payment_deposit.payment_type='3' " & WhereClause
        '" Where GL_payment_deposit.refer_type = '2' AND service_center_Head.type_of_form='IN' AND GL_payment_deposit.payment_type='1' " & WhereClause
        Try
            Num132.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num132.Text = 0
        End Try

        Num142.Text = Num112.Numbervalue + Num122.Numbervalue + Num132.Numbervalue


        CmdGeneral.CommandText = "SELECT sum(round(Gl_receive_payment.amount_receive,2)) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN" & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.pmt_method = '3' AND refrence_no not in (SELECT DISTINCT isnull(refrence_no, '') FROM GL_payment_deposit WHERE (refer_type = '3')) " & WhereCaluseCC1 & WhereClause
        '" Where GL_payment_deposit.refer_type = '2' AND GL_payment_deposit.payment_type='3' " & WhereCaluseCC1 & WhereClause
        Try
            Num152.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num152.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(round(Gl_receive_payment.amount_receive,2)) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN" & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.pmt_method = '3' AND refrence_no not in (SELECT DISTINCT isnull(refrence_no, '') FROM GL_payment_deposit WHERE (refer_type = '3')) " & WhereCaluseCC2 & WhereClause
        '" Where GL_payment_deposit.refer_type = '2' AND GL_payment_deposit.payment_type='3' " & WhereCaluseCC2 & WhereClause
        Try
            Num162.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num162.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(round(Gl_receive_payment.amount_receive,2)) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN" & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.pmt_method = '3' AND refrence_no not in (SELECT DISTINCT isnull(refrence_no, '') FROM GL_payment_deposit WHERE (refer_type = '3')) " & WhereCaluseCC3 & WhereClause
        '" Where GL_payment_deposit.refer_type = '2' AND GL_payment_deposit.payment_type='3' " & WhereCaluseCC3 & WhereClause
        Try
            Num172.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num172.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(round(Gl_receive_payment.amount_receive,2)) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN" & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.pmt_method = '3' AND refrence_no not in (SELECT DISTINCT isnull(refrence_no, '') FROM GL_payment_deposit WHERE (refer_type = '3')) " & WhereCaluseCC4 & WhereClause
        '" Where GL_payment_deposit.refer_type = '2' AND GL_payment_deposit.payment_type='3' " & WhereCaluseCC4 & WhereClause
        Try
            Num182.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num182.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(round(Gl_receive_payment.amount_receive,2)) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN" & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.pmt_method = '3' AND refrence_no not in (SELECT DISTINCT isnull(refrence_no, '') FROM GL_payment_deposit WHERE (refer_type = '3')) " & WhereCaluseCC5 & WhereClause
        '" Where GL_payment_deposit.refer_type = '2' AND GL_payment_deposit.payment_type='3' " & WhereCaluseCC5 & WhereClause
        Try
            Num192.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num192.Text = 0
        End Try
        '***************** 13 *************************
        '############################################################################################################
        WhereClause = " AND dbo.changedate(action_date)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(action_date)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "SELECT sum(amount) FROM GL_Paid_received where tran_type='2' AND OtherReceipType='1' " & WhereClause
        Try
            Num113.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num113.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(amount) FROM GL_Paid_received where tran_type='2' AND OtherReceipType='2' " & WhereClause
        Try
            Num123.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num123.Text = 0
        End Try

        Num143.Text = Num113.Numbervalue + Num123.Numbervalue + Num133.Numbervalue

        '***************** 14 *************************
        '############################################################################################################
        WhereClause = " AND dbo.changedate(action_date)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(action_date)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "SELECT sum(amount) FROM GL_Paid_received " & _
                      " Where tran_type = '3' " & WhereClause
        Try
            Num114.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num114.Text = 0
        End Try

        WhereClause = " AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        CmdGeneral.CommandText = "SELECT sum(GL_payment_deposit.payment_amount) FROM GL_payment_deposit INNER JOIN " & _
                      " service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center " & _
                      " Where service_center_head.type_of_form='RT' AND GL_payment_deposit.payment_type='2' AND Refer_type='3' " & WhereClause
        Try
            Num124.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num124.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(GL_payment_deposit.payment_amount) FROM GL_payment_deposit INNER JOIN " & _
                      " service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center " & _
                      " Where service_center_head.type_of_form='RT' AND GL_payment_deposit.payment_type='3' AND Refer_type='3' " & WhereClause
        Try
            Num134.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num134.Text = 0
        End Try

        Num144.Text = Num114.Numbervalue + Num124.Numbervalue + Num134.Numbervalue

        CmdGeneral.CommandText = "SELECT sum(GL_payment_deposit.payment_amount) FROM GL_payment_deposit INNER JOIN " & _
                      " service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center INNER JOIN " & _
                      " GL_payment_credit ON GL_payment_deposit.ID_payment = GL_payment_credit.ID_payment " & _
                      " Where GL_payment_deposit.refer_type = '3' AND service_center_head.type_of_form='RT' AND GL_payment_deposit.payment_type='3' " & WhereCaluseCC1 & WhereClause
        Try
            Num154.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num154.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(GL_payment_deposit.payment_amount) FROM GL_payment_deposit INNER JOIN " & _
              " service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center INNER JOIN " & _
              " GL_payment_credit ON GL_payment_deposit.ID_payment = GL_payment_credit.ID_payment " & _
              " Where GL_payment_deposit.refer_type = '3' AND service_center_head.type_of_form='RT' AND GL_payment_deposit.payment_type='3' " & WhereCaluseCC2 & WhereClause
        Try
            Num164.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num164.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(GL_payment_deposit.payment_amount) FROM GL_payment_deposit INNER JOIN " & _
              " service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center INNER JOIN " & _
              " GL_payment_credit ON GL_payment_deposit.ID_payment = GL_payment_credit.ID_payment " & _
              " Where GL_payment_deposit.refer_type = '3' AND service_center_head.type_of_form='RT' AND GL_payment_deposit.payment_type='3' " & WhereCaluseCC3 & WhereClause
        Try
            Num174.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num174.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(GL_payment_deposit.payment_amount) FROM GL_payment_deposit INNER JOIN " & _
              " service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center INNER JOIN " & _
              " GL_payment_credit ON GL_payment_deposit.ID_payment = GL_payment_credit.ID_payment " & _
              " Where GL_payment_deposit.refer_type = '3' AND service_center_head.type_of_form='RT' AND GL_payment_deposit.payment_type='3' " & WhereCaluseCC4 & WhereClause
        Try
            Num184.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num184.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(GL_payment_deposit.payment_amount) FROM GL_payment_deposit INNER JOIN " & _
              " service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center INNER JOIN " & _
              " GL_payment_credit ON GL_payment_deposit.ID_payment = GL_payment_credit.ID_payment " & _
              " Where GL_payment_deposit.refer_type = '3' AND service_center_head.type_of_form='RT' AND GL_payment_deposit.payment_type='3' " & WhereCaluseCC5 & WhereClause
        Try
            Num194.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num194.Text = 0
        End Try

        '***************** Paid For Other Store*************************
        '############################################################################################################
        WhereClause = " AND dbo.changedate(date_receive_payment)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_receive_payment)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "SELECT sum(round(isnull(Gl_receive_payment.OtherStoreAmount,0),2)) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN " & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.pmt_method = '1' " & WhereClause
        Try
            NumPaidForOtherStore1.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumPaidForOtherStore1.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(round(isnull(Gl_receive_payment.OtherStoreAmount,0),2)) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN " & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.pmt_method = '2' " & WhereClause
        Try
            NumPaidForOtherStore2.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumPaidForOtherStore2.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(round(isnull(Gl_receive_payment.OtherStoreAmount,0),2)) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN " & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.pmt_method = '3' " & WhereClause
        Try
            NumPaidForOtherStore3.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumPaidForOtherStore3.Text = 0
        End Try

        NumPaidForOtherStore4.Text = NumPaidForOtherStore1.Numbervalue + NumPaidForOtherStore2.Numbervalue + NumPaidForOtherStore3.Numbervalue

        CmdGeneral.CommandText = "SELECT sum(Gl_receive_payment.OtherStoreAmount) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN" & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.pmt_method = '3' " & WhereCaluseCC1 & WhereClause
        Try
            NumPaidForOtherStore5.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumPaidForOtherStore5.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(Gl_receive_payment.OtherStoreAmount) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN" & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.pmt_method = '3' " & WhereCaluseCC2 & WhereClause
        Try
            NumPaidForOtherStore6.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumPaidForOtherStore6.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(Gl_receive_payment.OtherStoreAmount) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN" & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.pmt_method = '3' " & WhereCaluseCC3 & WhereClause
        Try
            NumPaidForOtherStore7.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumPaidForOtherStore7.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(Gl_receive_payment.OtherStoreAmount) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN" & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.pmt_method = '3' " & WhereCaluseCC4 & WhereClause
        Try
            NumPaidForOtherStore8.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumPaidForOtherStore8.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(Gl_receive_payment.OtherStoreAmount) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN" & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.pmt_method = '3' " & WhereCaluseCC5 & WhereClause
        Try
            NumPaidForOtherStore9.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumPaidForOtherStore9.Text = 0
        End Try

        '***************** Paid From Other Store*************************
        '############################################################################################################
        WhereClause = " AND dbo.changedate(date_receive_payment)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_receive_payment)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "SELECT sum(round(isnull(Gl_receive_payment.amount_receive,0),2)) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN " & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.pmt_method = '1' AND rtrim(ltrim(FromStoreNo + ''))<>'' AND FromStoreNo<>" & PubStoreNO & " " & WhereClause
        Try
            NumPaidFromOtherStore1.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumPaidFromOtherStore1.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(round(isnull(Gl_receive_payment.amount_receive,0),2)) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN " & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.pmt_method = '2' AND rtrim(ltrim(FromStoreNo + ''))<>'' AND FromStoreNo<>" & PubStoreNO & " " & WhereClause
        Try
            NumPaidFromOtherStore2.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumPaidFromOtherStore2.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(round(isnull(Gl_receive_payment.amount_receive,0),2)) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN " & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.pmt_method = '3' AND rtrim(ltrim(FromStoreNo + ''))<>'' AND FromStoreNo<>" & PubStoreNO & " " & WhereClause
        Try
            NumPaidFromOtherStore3.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumPaidFromOtherStore3.Text = 0
        End Try

        NumPaidFromOtherStore4.Text = NumPaidFromOtherStore1.Numbervalue + NumPaidFromOtherStore2.Numbervalue + NumPaidFromOtherStore3.Numbervalue

        CmdGeneral.CommandText = "SELECT sum(Gl_receive_payment.amount_receive) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN" & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.pmt_method = '3' AND rtrim(ltrim(FromStoreNo + ''))<>'' AND FromStoreNo<>" & PubStoreNO & " " & WhereCaluseCC1 & WhereClause
        Try
            NumPaidFromOtherStore5.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumPaidFromOtherStore5.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(Gl_receive_payment.amount_receive) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN" & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.pmt_method = '3' AND rtrim(ltrim(FromStoreNo + ''))<>'' AND FromStoreNo<>" & PubStoreNO & " " & WhereCaluseCC2 & WhereClause
        Try
            NumPaidFromOtherStore6.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumPaidFromOtherStore6.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(Gl_receive_payment.amount_receive) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN" & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.pmt_method = '3' AND rtrim(ltrim(FromStoreNo + ''))<>'' AND FromStoreNo<>" & PubStoreNO & " " & WhereCaluseCC3 & WhereClause
        Try
            NumPaidFromOtherStore7.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumPaidFromOtherStore7.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(Gl_receive_payment.amount_receive) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN" & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.pmt_method = '3' AND rtrim(ltrim(FromStoreNo + ''))<>'' AND FromStoreNo<>" & PubStoreNO & " " & WhereCaluseCC4 & WhereClause
        Try
            NumPaidFromOtherStore8.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumPaidFromOtherStore8.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(Gl_receive_payment.amount_receive) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN" & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.pmt_method = '3' AND rtrim(ltrim(FromStoreNo + ''))<>'' AND FromStoreNo<>" & PubStoreNO & " " & WhereCaluseCC5 & WhereClause
        Try
            NumPaidFromOtherStore9.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumPaidFromOtherStore9.Text = 0
        End Try

        '***************** Down Payment *************************
        '############################################################################################################
        WhereClause = " AND dbo.changedate(action_date)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(action_date)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "SELECT Sum(GL_Paid_received.amount) FROM GL_Paid_received " & _
                      " Where GL_Paid_received.tran_type='4' AND OtherReceipType='1' " & WhereClause
        Try
            NumDownPayment1.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumDownPayment1.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT Sum(GL_Paid_received.amount) FROM GL_Paid_received " & _
                      " Where GL_Paid_received.tran_type='4' AND OtherReceipType='2' " & WhereClause
        Try
            NumDownPayment2.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumDownPayment2.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT Sum(GL_Paid_received.amount) FROM GL_Paid_received " & _
                      " Where GL_Paid_received.tran_type='4' AND OtherReceipType='3' " & WhereClause
        Try
            NumDownPayment3.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumDownPayment3.Text = 0
        End Try

        NumDownPayment4.Text = NumDownPayment1.Numbervalue + NumDownPayment2.Numbervalue + NumDownPayment3.Numbervalue

        CmdGeneral.CommandText = "SELECT Sum(GL_Paid_received.amount) FROM GL_Paid_received " & _
                      " Where GL_Paid_received.tran_type='4' AND OtherReceipType='3' " & WhereCaluseCC1 & WhereClause
        Try
            NumDownPayment5.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumDownPayment5.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT Sum(GL_Paid_received.amount) FROM GL_Paid_received " & _
                      " Where GL_Paid_received.tran_type='4' AND OtherReceipType='3' " & WhereCaluseCC2 & WhereClause
        Try
            NumDownPayment6.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumDownPayment6.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT Sum(GL_Paid_received.amount) FROM GL_Paid_received " & _
                      " Where GL_Paid_received.tran_type='4' AND OtherReceipType='3' " & WhereCaluseCC3 & WhereClause
        Try
            NumDownPayment7.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumDownPayment7.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT Sum(GL_Paid_received.amount) FROM GL_Paid_received " & _
                      " Where GL_Paid_received.tran_type='4' AND OtherReceipType='3' " & WhereCaluseCC4 & WhereClause
        Try
            NumDownPayment8.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumDownPayment8.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT Sum(GL_Paid_received.amount) FROM GL_Paid_received " & _
                      " Where GL_Paid_received.tran_type='4' AND OtherReceipType='3' " & WhereCaluseCC5 & WhereClause
        Try
            NumDownPayment9.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumDownPayment9.Text = 0
        End Try

        '***************** 16 *************************
        Num116.Text = Num111.Numbervalue + Num112.Numbervalue + Num113.Numbervalue - Num114.Numbervalue + NumDownPayment1.Numbervalue - NumPaidOutCP.Numbervalue
        Num126.Text = Num121.Numbervalue + Num122.Numbervalue + Num123.Numbervalue - Num124.Numbervalue + NumDownPayment2.Numbervalue
        Num136.Text = Num131.Numbervalue + Num132.Numbervalue + Num133.Numbervalue - Num134.Numbervalue + NumDownPayment3.Numbervalue
        Num146.Text = Num141.Numbervalue + Num142.Numbervalue + Num143.Numbervalue - Num144.Numbervalue + NumDownPayment4.Numbervalue - NumPaidOutCP.Numbervalue
        Num156.Text = Num151.Numbervalue + Num152.Numbervalue + Num153.Numbervalue - Num154.Numbervalue + NumDownPayment5.Numbervalue
        Num166.Text = Num161.Numbervalue + Num162.Numbervalue + Num163.Numbervalue - Num164.Numbervalue + NumDownPayment6.Numbervalue
        Num176.Text = Num171.Numbervalue + Num172.Numbervalue + Num173.Numbervalue - Num174.Numbervalue + NumDownPayment7.Numbervalue
        Num186.Text = Num181.Numbervalue + Num182.Numbervalue + Num183.Numbervalue - Num184.Numbervalue + NumDownPayment8.Numbervalue
        Num196.Text = Num191.Numbervalue + Num192.Numbervalue + Num193.Numbervalue - Num194.Numbervalue + NumDownPayment9.Numbervalue

        '**********************************************************************************
        '**********************************************************************************
        '***************************************   2   ************************************
        '**********************************************************************************
        '**********************************************************************************
        '***************** 21 *************************
        '############################################################################################################
        WhereClause = " AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "Select isnull(sum(round(qty*(round(price,2)+round(Fet,2)),2)),0) from service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center Where type_select='I' AND type_of_form='IN' " & WhereClause
        Try
            Num211.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num211.Text = 0
        End Try

        '???????????????????????????
        CmdGeneral.CommandText = "SELECT isnull(round(sum(round(service_center_dtl.qty * (round(inv_item_cost_transaction.cost,2) + round(inv_item_cost_transaction.delivery,2) + round(inv_item_cost_transaction.frieght,2) + round(service_center_dtl.fet,2)),2)),2),0)  FROM  service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN inv_item_cost_transaction ON service_center_dtl.cod_select = inv_item_cost_transaction.item_no Where type_select='I' AND type_of_form='IN' " & WhereClause
        Try
            Num212.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num212.Text = 0
        End Try

        Num213.Text = Num211.Numbervalue - Num212.Numbervalue
        If Num211.Text > 0 Then
            Num214.Text = Math.Round((Num213.Text / Num211.Text) * 100, 2)
        Else
            Num214.Text = 0
        End If

        CmdGeneral.CommandText = "Select isnull(sum(round(qty*(round(price,2)+round(fet,2)),2)),0) from service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center Where type_select='I' AND type_of_form='RT' " & WhereClause
        Try
            Num215.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num215.Text = 0
        End Try
        '***************** 22 *************************
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "Select isnull(sum(round(qty*(round(price,2)+round(Fet,2)),2)),0) from service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center Where (type_select='L' OR type_select='S') AND type_of_form='IN' " & WhereClause
        Try
            Num221.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num221.Text = 0
        End Try

        '????????????????????????????????????????
        CmdGeneral.CommandText = "SELECT isnull(sum(round(round(inv_tab_labor_service.cost,2)*service_center_dtl.qty,2)),0) " & _
                                 " FROM service_center_dtl INNER JOIN " & _
                                 " service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center LEFT OUTER JOIN " & _
                                 " inv_tab_labor_service ON service_center_dtl.cod_select = inv_tab_labor_service.cod_service " & _
                                 " Where (type_select='L' OR type_select='S') AND type_of_form='IN' " & WhereClause
        Try
            Num222.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num222.Text = 0
        End Try

        Num223.Text = Num221.Text - Num222.Text
        If Num221.Text > 0 Then
            Num224.Text = Math.Round((Num223.Text / Num221.Text) * 100, 2)
        Else
            Num224.Text = 0
        End If

        CmdGeneral.CommandText = "Select isnull(sum(round(qty*round(price,2),2)),0) from service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center Where (type_select='L' OR type_select='S') AND type_of_form='RT' " & WhereClause
        Try
            Num225.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num225.Text = 0
        End Try
        '***************** 23 *************************
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "Select isnull(sum(round(qty*round(price,2),2)),0) from service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center Where type_select='F' AND type_of_form='IN' " & WhereClause
        Try
            Num231.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num231.Text = 0
        End Try

        '????????????????????????????????????????
        CmdGeneral.CommandText = "SELECT isnull(sum(round(inv_tab_labor_service.cost,2)),0) " & _
                                 " FROM service_center_dtl INNER JOIN " & _
                                 " service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN " & _
                                 " inv_tab_labor_service ON service_center_dtl.cod_select = inv_tab_labor_service.cod_service " & _
                                 " Where type_select='F' AND type_of_form='IN' " & WhereClause
        Try
            Num232.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num232.Text = 0
        End Try

        Num233.Text = Num231.Text - Num232.Text
        If Num231.Text > 0 Then
            Num234.Text = Math.Round((Num233.Text / Num231.Text) * 100, 2)
        Else
            Num234.Text = 0
        End If


        CmdGeneral.CommandText = "Select isnull(sum(round(qty*round(price,2),2)),0) from service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center Where type_select='F' AND type_of_form='RT' " & WhereClause
        Try
            Num235.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num235.Text = 0
        End Try
        '***************** 24 *************************
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "Select isnull(sum(round(qty*(round(price,2)+round(Fet,2)),2)),0) from service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center Where type_select='O' AND type_of_form='IN' " & WhereClause
        Try
            Num241.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num241.Text = 0
        End Try

        '????????????????????????????????????????
        CmdGeneral.CommandText = "SELECT isnull(sum(round((round(service_out_purchases.cost,2)+round(service_out_purchases.fet,2))*service_center_dtl.qty,2)),0) " & _
                                 " FROM service_center_dtl INNER JOIN " & _
                                 " service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN " & _
                                 " service_out_purchases ON service_center_dtl.id_service_center = service_out_purchases.id_service_center AND  " & _
                                 " service_center_dtl.radif = service_out_purchases.radif" & _
                                 " Where type_select='O' AND type_of_form='IN' " & WhereClause
        Try
            Num242.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num242.Text = 0
        End Try

        Num243.Text = Num241.Text - Num242.Text
        If Num241.Text > 0 Then
            Num244.Text = Math.Round((Num243.Text / Num241.Text) * 100, 2)
        Else
            Num244.Text = 0
        End If

        CmdGeneral.CommandText = "Select isnull(round(sum(qty*(round(price,2)+round(Fet,2))),2),0) from service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center Where type_select='O' AND type_of_form='RT' " & WhereClause
        Try
            Num245.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num245.Text = 0
        End Try
        '***************** 25 ************************* OK
        CmdGeneral.CommandText = "Select isnull(sum(round(qty*(round(price,2)+round(Fet,2)),2)),0) from service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center Where type_select='A' AND type_of_form='IN' " & WhereClause
        Try
            Num251.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num251.Text = 0
        End Try

        CmdGeneral.CommandText = "Select ISNULL(SUM(ROUND(ROUND(inv_item_cost_transaction.cost, 2) + ROUND(inv_item_cost_transaction.fet, 2), 2) * service_center_dtl.qty), 0) FROM service_center_dtl LEFT OUTER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center LEFT OUTER JOIN inv_item ON service_center_dtl.cod_select = inv_item.item_no LEFT OUTER JOIN inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no Where inv_item_cost_transaction.last_flag=1 AND type_select='A' AND type_of_form='IN' " & WhereClause
        Try
            Num252.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num252.Text = 0
        End Try

        Num253.Text = Num251.Text - Num252.Text
        If Num251.Text > 0 Then
            Num254.Text = Math.Round((Num253.Text / Num251.Text) * 100, 2)
        Else
            Num254.Text = 0
        End If
        If Num254.Numbervalue < 0 Then
            Num254.Text = 0
        End If
        '***************** 26 ************************* OK
        CmdGeneral.CommandText = "Select isnull(round(sum(qty*(round(price,2)+round(Fet,2))),2),0) from service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center Where type_select='T' AND type_of_form='IN' " & WhereClause
        Try
            Num261.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num261.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(round((service_center_head.discount * View_Invoice_SubTotal.Subtotal)/100,2)) AS discount FROM  service_center_head INNER JOIN View_Invoice_SubTotal ON service_center_head.id_service_center = View_Invoice_SubTotal.id_service_center Where type_of_form='IN' " & WhereClause
        Try
            NumDiscounts.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumDiscounts.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(round((service_center_head.discount * View_Invoice_SubTotal.Subtotal)/100,2)) AS discount FROM  service_center_head INNER JOIN View_Invoice_SubTotal ON service_center_head.id_service_center = View_Invoice_SubTotal.id_service_center Where type_of_form='RT' " & WhereClause
        Try
            NumDiscountReturns.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumDiscountReturns.Text = 0
        End Try

        Num262.Text = Math.Abs(Num261.Numbervalue)

        Num263.Text = Num261.Numbervalue + Num262.Numbervalue
        If Num261.Text > 0 Then
            Num264.Text = Math.Round((Num263.Text / Num261.Text) * 100, 2)
        Else
            Num264.Text = 0
        End If

        '***************** 27 ************************* OK
        Num271.Text = Num211.Numbervalue + Num221.Numbervalue + Num231.Numbervalue + Num241.Numbervalue + Num251.Numbervalue + Num261.Numbervalue
        Num272.Text = Num212.Numbervalue + Num222.Numbervalue + Num232.Numbervalue + Num242.Numbervalue + Num252.Numbervalue + Num262.Numbervalue
        Num273.Text = Num213.Numbervalue + Num223.Numbervalue + Num233.Numbervalue + Num243.Numbervalue + Num253.Numbervalue + Num263.Numbervalue
        If Num271.Text > 0 Then
            Num274.Text = Math.Round((Num273.Text / Num271.Text) * 100, 2)
        Else
            Num274.Text = 0
        End If
        Num275.Text = Num215.Numbervalue + Num225.Numbervalue + Num235.Numbervalue + Num245.Numbervalue
        '***************** 28 ************************* OK
        CmdGeneral.CommandText = "SELECT isnull(sum(round(tax,2)),0) FROM service_center_head Where type_of_form='IN' " & WhereClause
        Try
            Num281.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num281.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT isnull(sum(round(tax,2)),0) FROM service_center_head Where type_of_form='RT' " & WhereClause
        Try
            Num285.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num285.Text = 0
        End Try
        '***************** 29 ************************* OK
        Num291.Text = Num271.Numbervalue + Math.Abs(Num281.Numbervalue) - Math.Abs(NumDiscounts.Numbervalue)

        Num295.Text = Num275.Numbervalue + Num285.Numbervalue - NumDiscountReturns.Numbervalue
        '***************** 29 Others ******************
        NumSalesTax1.Text = Num271.Numbervalue - Math.Abs(NumDiscounts.Numbervalue) - Math.Abs(Num275.Numbervalue) - Math.Abs(NumDiscountReturns.Numbervalue)

        CmdGeneral.CommandText = "SELECT isnull(round(sum(qty*(round(price,2)+round(Fet,2))),2),0) FROM service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer WHERE  cust_trtab_main.Taxable = 1 AND service_center_head.type_of_form='IN'  And service_center_dtl.type_select<>'B' AND service_center_head.Tax<>0 " & WhereClause
        Try
            TempVal = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            TempVal = 0
        End Try
        CmdGeneral.CommandText = "SELECT isnull(round((sum(service_center_head.discount * qty*(round(price,2)+round(Fet,2)))/100),2),0) FROM service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer WHERE  cust_trtab_main.Taxable = 1 AND service_center_head.type_of_form='IN'  And service_center_dtl.type_select<>'B' AND service_center_head.Tax<>0 " & WhereClause
        Try
            TempVal = TempVal - CmdGeneral.ExecuteScalar
        Catch ex As Exception
        End Try
        CmdGeneral.CommandText = "SELECT isnull(round(sum(qty*(round(price,2)+round(Fet,2))),2),0) FROM service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer WHERE  cust_trtab_main.Taxable = 1 AND service_center_head.type_of_form='RT'  And service_center_dtl.type_select<>'B' AND service_center_head.Tax<>0 " & WhereClause
        Try
            NumSalesTax2.Text = TempVal - Math.Abs(CmdGeneral.ExecuteScalar)
        Catch ex As Exception
            NumSalesTax2.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT isnull(round(sum(qty*(round(price,2)+round(Fet,2))),2),0) FROM service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer WHERE  cust_trtab_main.Taxable = 0 AND service_center_head.type_of_form='IN'  And service_center_dtl.type_select<>'B' " & WhereClause
        Try
            TempVal = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            TempVal = 0
        End Try
        CmdGeneral.CommandText = "SELECT isnull(round((sum(service_center_head.discount * qty*(round(price,2)+round(Fet,2)))/100),2),0) FROM service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer WHERE  cust_trtab_main.Taxable = 0 AND service_center_head.type_of_form='IN'  And service_center_dtl.type_select<>'B' " & WhereClause
        Try
            TempVal = TempVal - CmdGeneral.ExecuteScalar
        Catch ex As Exception
        End Try
        CmdGeneral.CommandText = "SELECT isnull(round(sum(qty*(round(price,2)+round(Fet,2))),2),0) FROM service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer WHERE  cust_trtab_main.Taxable = 0 AND service_center_head.type_of_form='RT'  And service_center_dtl.type_select<>'B' " & WhereClause
        Try
            NumSalesTax3.Text = TempVal - Math.Abs(CmdGeneral.ExecuteScalar)
        Catch ex As Exception
            NumSalesTax3.Text = 0
        End Try


        '''''CmdGeneral.CommandText = "SELECT isnull(round(sum(qty*(round(price,2)+round(Fet,2))),2),0) FROM service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer WHERE     (cust_trtab_main.Taxable <> 1) AND (service_center_dtl.taxable = 1) AND (service_center_head.type_of_form = 'IN') AND (service_center_dtl.type_select <> 'B') " & WhereClause
        '''''Try
        '''''    TempVal = CmdGeneral.ExecuteScalar
        '''''Catch ex As Exception
        '''''    TempVal = 0
        '''''End Try
        '''''CmdGeneral.CommandText = "SELECT isnull(round((sum(service_center_head.discount * qty*(round(price,2)+round(Fet,2)))/100),2),0) FROM service_center_Dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center WHERE     (cust_trtab_main.Taxable <> 1) AND (service_center_dtl.taxable = 1) AND (service_center_head.type_of_form = 'IN') AND (service_center_dtl.type_select <> 'B') " & WhereClause
        '''''Try
        '''''    TempVal = TempVal - CmdGeneral.ExecuteScalar
        '''''Catch ex As Exception
        '''''End Try
        '''''CmdGeneral.CommandText = "SELECT isnull(round(sum(qty*(round(price,2)+round(Fet,2))),2),0) FROM service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer WHERE     (cust_trtab_main.Taxable <> 1) AND (service_center_dtl.taxable = 1) AND (service_center_head.type_of_form = 'RT') AND (service_center_dtl.type_select <> 'B') " & WhereClause
        '''''Try
        '''''    NumSalesTax3.Text = TempVal - Math.Abs(CmdGeneral.ExecuteScalar)
        '''''Catch ex As Exception
        '''''    NumSalesTax3.Text = 0
        '''''End Try


        CmdGeneral.CommandText = "SELECT isnull(round(sum(qty*(round(price,2)+round(Fet,2))),2),0) FROM service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer WHERE  (cust_trtab_main.Taxable = 1) AND (service_center_head.tax = 0) AND (service_center_head.type_of_form = 'IN') AND (service_center_dtl.type_select <> 'B') " & WhereClause
        Try
            TempVal = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            TempVal = 0
        End Try
        CmdGeneral.CommandText = "SELECT isnull(round((sum(service_center_head.discount * qty*(round(price,2)+round(Fet,2)))/100),2),0) FROM service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer WHERE  (cust_trtab_main.Taxable = 1) AND (service_center_head.tax = 0) AND (service_center_head.type_of_form = 'IN') AND (service_center_dtl.type_select <> 'B') " & WhereClause
        Try
            TempVal = TempVal - CmdGeneral.ExecuteScalar
        Catch ex As Exception
        End Try
        CmdGeneral.CommandText = "SELECT isnull(round(sum(qty*(round(price,2)+round(Fet,2))),2),0) FROM service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer WHERE     (cust_trtab_main.Taxable = 1) AND (service_center_head.tax = 0) AND (service_center_head.type_of_form = 'RT') AND (service_center_dtl.type_select <> 'B') " & WhereClause
        Try
            NumOtherExemptions.Text = TempVal - Math.Abs(CmdGeneral.ExecuteScalar)
        Catch ex As Exception
            NumOtherExemptions.Text = 0
        End Try


        CmdGeneral.CommandText = "SELECT isnull(round(sum(qty*(round(price,2)+round(Fet,2))),2),0) FROM service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer WHERE  cust_trtab_main.Taxable = 1 AND service_center_dtl.Taxable=0 AND service_center_head.type_of_form='IN' And service_center_dtl.type_select<>'B' AND service_center_head.Tax<>0 " & WhereClause
        Try
            TempVal = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            TempVal = 0
        End Try
        CmdGeneral.CommandText = "SELECT isnull(round((sum(service_center_head.discount * qty*(round(price,2)+round(Fet,2)))/100),2),0) FROM service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer WHERE  cust_trtab_main.Taxable = 1 AND service_center_dtl.Taxable=0 AND service_center_head.type_of_form='IN' And service_center_dtl.type_select<>'B' AND service_center_head.Tax<>0 " & WhereClause
        Try
            TempVal = TempVal - CmdGeneral.ExecuteScalar
        Catch ex As Exception
        End Try
        CmdGeneral.CommandText = "SELECT isnull(round(sum(qty*(round(price,2)+round(Fet,2))),2),0) FROM service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center INNER JOIN cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer WHERE  cust_trtab_main.Taxable = 1 AND service_center_dtl.Taxable=0 AND service_center_head.type_of_form='RT' And service_center_dtl.type_select<>'B' AND service_center_head.Tax<>0 " & WhereClause
        Try
            NumSalesTax4.Text = TempVal - Math.Abs(CmdGeneral.ExecuteScalar)
        Catch ex As Exception
            NumSalesTax4.Text = 0
        End Try


        CmdGeneral.CommandText = "SELECT isnull(sum(round(Fet,2)*round(Qty,2)),0) FROM service_center_Dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center Where type_of_form='IN' " & WhereClause
        Try
            TempVal = CmdGeneral.ExecuteScalar
        Catch ex As Exception
        End Try
        CmdGeneral.CommandText = "SELECT isnull(sum(round(Fet,2)*round(Qty,2)),0) FROM service_center_Dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center Where type_of_form='RT' " & WhereClause
        Try
            NumSalesTax5.Text = TempVal - Math.Abs(CmdGeneral.ExecuteScalar)
        Catch ex As Exception
            NumSalesTax5.Text = 0
        End Try


        NumSalesTax6.Text = Num281.Numbervalue + Num285.Numbervalue

        '**********************************************************************************
        '**********************************************************************************
        '***************************************  3   ************************************
        '**********************************************************************************
        '**********************************************************************************
        '???????????????????
        '############################################################################################################
        WhereClause = " AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        NumBeginingBalance.Text = 0
        CmdGeneral.CommandText = "SELECT     round(isnull(SUM(dbo.GL_payment_deposit.payment_amount), 0), 2) AS Customer_AR_Bedehy1 FROM  dbo.service_center_head INNER JOIN dbo.GL_payment_deposit ON dbo.service_center_head.id_service_center = dbo.GL_payment_deposit.id_service_center WHERE  dbo.changedate(date_refer)<" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND (dbo.GL_payment_deposit.refer_type = '1') AND (dbo.GL_payment_deposit.payment_type = '4') AND (dbo.service_center_head.type_of_form = 'IN') AND (dbo.GL_payment_deposit.id_service_center NOT IN (SELECT     dbo.service_center_head.id_service_center_before FROM service_center_head WHERE  dbo.service_center_head.id_service_center_before IS NOT NULL)) "
        Try
            TempVal = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            TempVal = 0
        End Try
        NumBeginingBalance.Text = NumBeginingBalance.Text + TempVal

        CmdGeneral.CommandText = "SELECT     ROUND(ISNULL(SUM(amount), 0), 2) AS Customer_AR_Bedehy2 FROM GL_Paid_received WHERE  dbo.changedate(action_date)<" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND (tran_type = '1')"
        Try
            TempVal = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            TempVal = 0
        End Try
        NumBeginingBalance.Text = NumBeginingBalance.Text + TempVal

        CmdGeneral.CommandText = "SELECT     round(isnull(SUM(amount_receive), 0), 2) AS Customer_AR_Pardakht1 FROM         dbo.Gl_receive_payment WHERE   dbo.changedate(date_receive_payment)<" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text))
        Try
            TempVal = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            TempVal = 0
        End Try
        NumBeginingBalance.Text = NumBeginingBalance.Text - TempVal

        CmdGeneral.CommandText = "SELECT     round(isnull(SUM(amount_adjustment), 0), 2) AS Customer_AR_Pardakht2 FROM         dbo.GL_account_adjustment_head WHERE     dbo.changedate(date_adjustment)<" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text))
        Try
            TempVal = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            TempVal = 0
        End Try
        NumBeginingBalance.Text = NumBeginingBalance.Text - TempVal

        CmdGeneral.CommandText = "SELECT     round(isnull(SUM(amount), 0), 2) AS Customer_AR_Pardakht3 FROM  dbo.GL_Paid_received WHERE dbo.changedate(action_date)<" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND (tran_type = '2')"
        Try
            TempVal = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            TempVal = 0
        End Try
        NumBeginingBalance.Text = NumBeginingBalance.Text - TempVal

        CmdGeneral.CommandText = "SELECT sum(GL_payment_deposit.payment_amount) FROM GL_payment_deposit INNER JOIN service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center Where GL_payment_deposit.refer_type='1' AND GL_payment_deposit.payment_type='4' AND type_of_form='IN' AND (GL_payment_deposit.id_service_center NOT IN (SELECT  id_service_center FROM  service_center_dtl WHERE     type_select = 'B')) " & WhereClause
        Try
            NumNewCharges.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumNewCharges.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(GL_payment_deposit.payment_amount) FROM GL_payment_deposit INNER JOIN service_center_head ON GL_payment_deposit.id_service_center = service_center_head.id_service_center Where GL_payment_deposit.refer_type='1' AND GL_payment_deposit.payment_type='4' AND type_of_form='IN' AND (GL_payment_deposit.id_service_center IN (SELECT  id_service_center FROM  service_center_dtl WHERE     type_select = 'B')) " & WhereClause
        Try
            NumBeginingBalances.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumBeginingBalances.Text = 0
        End Try

        '############################################################################################################
        WhereClause = " AND dbo.changedate(date_receive_payment)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_receive_payment)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "SELECT sum(round(isnull(Gl_receive_payment.amount_over,0),2)) " & _
              " FROM Gl_receive_payment LEFT OUTER JOIN " & _
              " cust_trtab_main ON Gl_receive_payment.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
              " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
              " Where Gl_receive_payment.amount_over>0 " & WhereClause
        Try
            NumOverPayment.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumOverPayment.Text = 0
        End Try

        '???????????????????
        '############################################################################################################
        WhereClause = " AND dbo.changedate(date_adjustment)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_adjustment)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "SELECT sum(amount_adjustment) FROM GL_account_adjustment_head Where 1=1 " & WhereClause
        Try
            NumNetAdjustment.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumNetAdjustment.Text = 0
        End Try

        '############################################################################################################
        WhereClause = " AND dbo.changedate(date_receive_payment)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_receive_payment)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        'CmdGeneral.CommandText = "SELECT  SUM(round(isnull(Gl_receive_payment.amount_receive,0),2)-round(isnull(Gl_receive_payment.OtherStoreAmount,0),2)) AS Expr1 FROM  Gl_receive_payment Where 1=1 " & WhereClause
        ' ÂÞÇí ãÌíÏ ÂÑãäÏå ÝÊ Èå Çíä Ô˜á ÊÛííÑ ˜äÏ
        CmdGeneral.CommandText = "SELECT  SUM(round(isnull(Gl_receive_payment.amount_receive,0),2)) AS Expr1 FROM  Gl_receive_payment Where 1=1 " & WhereClause
        Try
            NumReceivedOnAccounts.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            NumReceivedOnAccounts.Text = 0
        End Try

        NumTotalDebits.Text = NumNewCharges.Numbervalue + NumNetAdjustment.Numbervalue + NumBeginingBalances.Numbervalue

        NumTotalCredits.Text = NumReceivedOnAccounts.Numbervalue + NumReturnsCredits.Numbervalue
        NumNetChangeToAR.Text = NumTotalDebits.Numbervalue - NumTotalCredits.Numbervalue
        NumEndingBalance.Text = NumBeginingBalance.Numbervalue + NumNetChangeToAR.Numbervalue
        '**********************************************************************************
        '**********************************************************************************
        '***************************************  4   ************************************
        '**********************************************************************************
        '**********************************************************************************
        '*****************  41 ************************* OK
        '############################################################################################################
        WhereClause = " AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "SELECT  SUM(service_center_dtl.qty * (inv_item_cost_transaction.cost + inv_item_cost_transaction.delivery + inv_item_cost_transaction.frieght))  AS Expr1 FROM         service_center_dtl LEFT OUTER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center LEFT OUTER JOIN inv_item ON service_center_dtl.cod_select = inv_item.item_no LEFT OUTER JOIN inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no Where inv_item_cost_transaction.last_flag=1 AND (service_center_dtl.type_select='I' OR service_center_dtl.type_select='A' OR service_center_dtl.type_select='T') AND type_of_form='IN' " & WhereClause
        Try
            Num411.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num411.Text = 0
        End Try

        CmdGeneral.CommandText = "Select Sum(qty) from service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center Where (service_center_dtl.type_select='I' OR service_center_dtl.type_select='A' OR service_center_dtl.type_select='T') AND type_of_form='IN' " & WhereClause
        Try
            Num412.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num412.Text = 0
        End Try

        'CmdGeneral.CommandText = "SELECT COUNT(*) FROM  service_center_head INNER JOIN service_center_dtl ON service_center_head.id_service_center = service_center_dtl.id_service_center WHERE     (service_center_dtl.type_select = 'B') AND (service_center_head.type_of_form = 'IN') " & WhereClause
        'Try
        '    TempVal = CmdGeneral.ExecuteScalar
        'Catch ex As Exception
        '    TempVal = 0
        'End Try
        CmdGeneral.CommandText = "Select Count(*) from service_center_head INNER JOIN service_center_dtl ON service_center_head.id_service_center = service_center_dtl.id_service_center Where (service_center_dtl.type_select='I' OR service_center_dtl.type_select='A' OR service_center_dtl.type_select='T') AND type_of_form='IN' " & WhereClause
        Try
            Num413.Text = CmdGeneral.ExecuteScalar '- TempVal
        Catch ex As Exception
            Num413.Text = 0
        End Try


        '*****************  42 ************************* 
        CmdGeneral.CommandText = "SELECT  SUM(service_center_dtl.qty * (inv_item_cost_transaction.cost + inv_item_cost_transaction.delivery + inv_item_cost_transaction.frieght))  AS Expr1 FROM         service_center_dtl LEFT OUTER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center LEFT OUTER JOIN inv_item ON service_center_dtl.cod_select = inv_item.item_no LEFT OUTER JOIN inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no Where inv_item_cost_transaction.last_flag=1 AND type_select='I' AND type_of_form='RT' " & WhereClause
        Try
            Num421.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num421.Text = 0
        End Try

        CmdGeneral.CommandText = "Select Sum(qty) from service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center Where type_select='I' AND type_of_form='RT' " & WhereClause
        Try
            Num422.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num422.Text = 0
        End Try

        CmdGeneral.CommandText = "Select Count(*) from service_center_head Where type_of_form='RT' " & WhereClause
        Try
            Num423.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num423.Text = 0
        End Try

        '*****************  43 ************************* OK
        '############################################################################################################
        WhereClause = " AND dbo.changedate(date_receive)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_receive)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "SELECT sum(Inv_Receive_product_dtl.qty*(Inv_Receive_product_dtl.Cost+Inv_Receive_product_dtl.Fet)) FROM Inv_Receive_product_dtl INNER JOIN Inv_Receive_Products_head ON Inv_Receive_product_dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref Where bill_credit='1' " & WhereClause
        Try
            Num431.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num431.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(Inv_Receive_product_dtl.qty) FROM Inv_Receive_product_dtl INNER JOIN Inv_Receive_Products_head ON Inv_Receive_product_dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref Where bill_credit='1' " & WhereClause
        Try
            Num432.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num432.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT count(*) FROM Inv_Receive_Products_head Where bill_credit='1' " & WhereClause
        Try
            Num433.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num433.Text = 0
        End Try

        '*****************  44 ************************* OK
        CmdGeneral.CommandText = "SELECT sum(Inv_Receive_product_dtl.qty*(Inv_Receive_product_dtl.Cost+Inv_Receive_product_dtl.Fet)) FROM Inv_Receive_product_dtl INNER JOIN Inv_Receive_Products_head ON Inv_Receive_product_dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref Where bill_credit='2' " & WhereClause
        Try
            Num441.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num441.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(Inv_Receive_product_dtl.qty) FROM Inv_Receive_product_dtl INNER JOIN Inv_Receive_Products_head ON Inv_Receive_product_dtl.id_receive_ref = Inv_Receive_Products_head.id_receive_ref Where bill_credit='2' " & WhereClause
        Try
            Num442.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num442.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT count(*) FROM Inv_Receive_Products_head Where bill_credit='2' " & WhereClause
        Try
            Num443.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num443.Text = 0
        End Try

        '*****************  45 ************************* 
        '???????????????????
        '############################################################################################################
        WhereClause = " AND dbo.changedate(date_adjustment)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_adjustment)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "SELECT sum(inv_adjustment_dtl.QTY*(inv_adjustment_dtl.Cost+inv_adjustment_dtl.Fet)) FROM inv_adjustment_dtl INNER JOIN inv_adjustment_head ON inv_adjustment_dtl.referID_adjustment = inv_adjustment_head.referID_adjustment Where 1=1 " & WhereClause
        Try
            Num451.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num451.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(inv_adjustment_dtl.QTY) FROM inv_adjustment_dtl INNER JOIN inv_adjustment_head ON inv_adjustment_dtl.referID_adjustment = inv_adjustment_head.referID_adjustment Where 1=1 " & WhereClause
        Try
            Num452.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num452.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT Count(*) FROM inv_adjustment_head Where 1=1 " & WhereClause
        Try
            Num453.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num453.Text = 0
        End Try

        '*****************  46 ************************* 
        '############################################################################################################
        WhereClause = " AND inv_salse_transfer_head.type_sales_transfer='2' AND dbo.changedate(date_action)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_action)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "SELECT SUM(inv_sales_transfer_dtl.qty * (inv_sales_transfer_dtl.price + inv_sales_transfer_dtl.fet)) FROM  inv_sales_transfer_dtl LEFT OUTER JOIN inv_salse_transfer_head ON inv_sales_transfer_dtl.ID_sales_transfer = inv_salse_transfer_head.ID_sales_transfer Where 1=1 " & WhereClause
        Try
            Num461.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num461.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(inv_sales_transfer_dtl.QTY) FROM inv_sales_transfer_dtl LEFT OUTER JOIN inv_salse_transfer_head ON inv_sales_transfer_dtl.ID_sales_transfer = inv_salse_transfer_head.ID_sales_transfer Where 1=1 " & WhereClause
        Try
            Num462.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num462.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT Count(*) FROM inv_salse_transfer_head Where 1=1 " & WhereClause
        Try
            Num463.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num463.Text = 0
        End Try
        '*****************  47 ************************* 
        '############################################################################################################
        WhereClause = " AND inv_salse_transfer_head.type_sales_transfer='1' AND dbo.changedate(date_action)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_action)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "SELECT SUM(inv_sales_transfer_dtl.qty * (inv_sales_transfer_dtl.price + inv_sales_transfer_dtl.fet)) FROM  inv_sales_transfer_dtl LEFT OUTER JOIN inv_salse_transfer_head ON inv_sales_transfer_dtl.ID_sales_transfer = inv_salse_transfer_head.ID_sales_transfer Where 1=1 " & WhereClause
        Try
            Num471.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num471.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT sum(inv_sales_transfer_dtl.QTY) FROM inv_sales_transfer_dtl LEFT OUTER JOIN inv_salse_transfer_head ON inv_sales_transfer_dtl.ID_sales_transfer = inv_salse_transfer_head.ID_sales_transfer Where 1=1 " & WhereClause
        Try
            Num472.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num472.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT Count(*) FROM inv_salse_transfer_head Where 1=1 " & WhereClause
        Try
            Num473.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num473.Text = 0
        End Try
        '*****************  48 ************************* 
        '############################################################################################################
        WhereClause = " AND dbo.changedate(date_po)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_po)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "SELECT SUM((Inv_purchase_order_dtl.fet + Inv_purchase_order_dtl.cost) * Inv_purchase_order_dtl.qty) FROM  Inv_purchase_order_dtl LEFT OUTER JOIN Inv_purchase_order_head ON Inv_purchase_order_dtl.po_no = Inv_purchase_order_head.po_no Where 1=1 " & WhereClause
        Try
            Num481.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num481.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT Sum(Inv_purchase_order_dtl.qty) FROM Inv_purchase_order_dtl INNER JOIN Inv_purchase_order_head ON Inv_purchase_order_dtl.po_no = Inv_purchase_order_head.po_no Where 1=1 " & WhereClause
        Try
            Num482.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num482.Text = 0
        End Try

        CmdGeneral.CommandText = "SELECT Count(*) FROM Inv_purchase_order_head Where 1=1 " & WhereClause
        Try
            Num483.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num483.Text = 0
        End Try

        '*****************  Sum ************************* 
        Num464.Text = Num411.Numbervalue + Num441.Numbervalue + Num461.Numbervalue + Num471.Numbervalue
        Num474.Text = Num421.Numbervalue + Num431.Numbervalue + Num451.Numbervalue
        Num484.Text = Num474.Text - Num464.Text


        '**********************************************************************************
        '**********************************************************************************
        '***************************************  5 OK  ************************************
        '**********************************************************************************
        '**********************************************************************************
        '*****************  51 ************************* 
        '############################################################################################################
        WhereClause = " AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "Select sum(qty*price) from service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center Where type_select='L' AND type_of_form='IN' " & WhereClause
        Try
            Num511.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num511.Text = 0
        End Try

        CmdGeneral.CommandText = "Select sum(qty*price) from service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center Where type_select='L' AND type_of_form='RT' " & WhereClause
        Try
            Num512.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num512.Text = 0
        End Try

        '*****************  52 ************************* 
        CmdGeneral.CommandText = "Select sum(qty*price) from service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center Where type_select='F' AND type_of_form='IN' " & WhereClause
        Try
            Num521.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num521.Text = 0
        End Try

        CmdGeneral.CommandText = "Select sum(qty*price) from service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center Where type_select='F' AND type_of_form='RT' " & WhereClause
        Try
            Num522.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num522.Text = 0
        End Try
        '*****************  53 *************************
        CmdGeneral.CommandText = "Select sum(qty*price) from service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center Where type_select='S' AND type_of_form='IN' " & WhereClause
        Try
            Num531.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num531.Text = 0
        End Try

        CmdGeneral.CommandText = "Select sum(qty*price) from service_center_dtl INNER JOIN service_center_head ON service_center_dtl.id_service_center = service_center_head.id_service_center Where type_select='S' AND type_of_form='RT' " & WhereClause
        Try
            Num532.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num532.Text = 0
        End Try
        '*****************  54 *************************
        Num541.Text = Num511.Numbervalue + Num521.Numbervalue + Num531.Numbervalue
        Num542.Text = Num512.Numbervalue + Num522.Numbervalue + Num532.Numbervalue
        '**********************************************************************************
        '**********************************************************************************
        '***************************************   6    ***********************************
        '**********************************************************************************
        '**********************************************************************************
        '*****************  61 ************************* 
        '############################################################################################################
        WhereClause = " AND dbo.changedate(date_of_check)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_of_check)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "Select sum(Amount) from bank_check_dtl INNER JOIN bank_check ON bank_check_dtl.id_check = bank_check.id_check Where 1=1 " & WhereClause
        Try
            Num611.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num611.Text = 0
        End Try

        '############################################################################################################
        WhereClause = " AND dbo.changedate(date_transaction)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_transaction)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "Select sum(Amount) from bank_ATM_dtl INNER JOIN bank_ATM ON bank_ATM_dtl.id_ATM = bank_ATM.id_ATM Where ChargeCredit='1' " & WhereClause
        Try
            Num621.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num621.Text = 0
        End Try

        Num631.Text = 0
        Num641.Text = 0
        ' ???????????????????????????
        '############################################################################################################
        WhereClause = " AND dbo.changedate(date_transfer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_transfer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "SELECT sum(amount_transfer) FROM GL_transfer_amount Where 1=1 " & WhereClause
        Try
            Num651.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num651.Text = 0
        End Try

        '############################################################################################################
        WhereClause = " AND dbo.changedate(adjustment_date)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(adjustment_date)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "SELECT sum(Bank_Adjustment_dtl.debit_amount) FROM Bank_Adjustment_dtl INNER JOIN bank_adjustment_head ON Bank_Adjustment_dtl.Id_Adjustment_no = bank_adjustment_head.Id_Adjustment_no Where Bank_Adjustment_dtl.debit_amount<0 " & WhereClause
        Try
            Num661.Text = Math.Abs(CmdGeneral.ExecuteScalar)
        Catch ex As Exception
            Num661.Text = 0
        End Try

        Num671.Text = Num611.Numbervalue + Num621.Numbervalue + Num631.Numbervalue + Num641.Numbervalue + Num651.Numbervalue + Num661.Numbervalue

        '*****************  62 ************************* 
        '############################################################################################################
        WhereClause = " AND dbo.changedate(date_doc)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_doc)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        'Num612.Text = Num116.Numbervalue
        'Num622.Text = Num126.Numbervalue
        'Num632.Text = Num136.Numbervalue
        ' majid goft in kar o nekonam
        CmdGeneral.CommandText = "SELECT isnull(sum(round(isnull(GL_debit_deposit.deposit_amount,0),2)),0) FROM GL_debit_deposit INNER JOIN GL_payment_deposit ON GL_debit_deposit.ID_payment = GL_payment_deposit.ID_payment INNER JOIN GL_debit_deposit_head ON GL_debit_deposit.id_debit_deposit_head = GL_debit_deposit_head.id_debit_deposit_head WHERE     (GL_debit_deposit.type_transaction = '1') AND (GL_payment_deposit.payment_type = '1') " & WhereClause
        Try
            Num612.Text = Math.Abs(CmdGeneral.ExecuteScalar)
        Catch ex As Exception
            Num612.Text = 0
        End Try
        CmdGeneral.CommandText = "SELECT isnull(sum(round(isnull(GL_debit_deposit.debit_amount,0),2)),0) FROM GL_debit_deposit INNER JOIN GL_debit_deposit_head ON GL_debit_deposit.id_debit_deposit_head = GL_debit_deposit_head.id_debit_deposit_head WHERE (GL_debit_deposit.type_transaction = '3') " & WhereClause
        Try
            Num612.Text = Num612.Text - Math.Abs(CmdGeneral.ExecuteScalar)
        Catch ex As Exception
        End Try
        CmdGeneral.CommandText = "SELECT isnull(sum(round(isnull(GL_debit_deposit.debit_amount,0),2)),0) FROM GL_debit_deposit INNER JOIN GL_debit_deposit_head ON GL_debit_deposit.id_debit_deposit_head = GL_debit_deposit_head.id_debit_deposit_head WHERE (GL_debit_deposit.type_transaction = '8') " & WhereClause
        Try
            Num612.Text = Num612.Text - Math.Abs(CmdGeneral.ExecuteScalar)
        Catch ex As Exception
        End Try
        CmdGeneral.CommandText = "SELECT isnull(sum(round(isnull(GL_debit_deposit.deposit_amount,0),2)),0) FROM GL_debit_deposit INNER JOIN GL_debit_deposit_head ON GL_debit_deposit.id_debit_deposit_head = GL_debit_deposit_head.id_debit_deposit_head WHERE (GL_debit_deposit.type_transaction = '9') " & WhereClause
        Try
            Num612.Text = Num612.Text + Math.Abs(CmdGeneral.ExecuteScalar)
        Catch ex As Exception
        End Try

        CmdGeneral.CommandText = "SELECT isnull(sum(round(isnull(GL_debit_deposit.deposit_amount,0),2)),0) FROM GL_debit_deposit INNER JOIN GL_payment_deposit ON GL_debit_deposit.ID_payment = GL_payment_deposit.ID_payment INNER JOIN GL_debit_deposit_head ON GL_debit_deposit.id_debit_deposit_head = GL_debit_deposit_head.id_debit_deposit_head WHERE     (GL_debit_deposit.type_transaction = '1') AND (GL_payment_deposit.payment_type = '2') " & WhereClause
        Try
            Num622.Text = Math.Abs(CmdGeneral.ExecuteScalar)
        Catch ex As Exception
            Num622.Text = 0
        End Try
        CmdGeneral.CommandText = "SELECT isnull(sum(round(isnull(GL_debit_deposit.deposit_amount,0),2)),0) FROM GL_debit_deposit INNER JOIN GL_debit_deposit_head ON GL_debit_deposit.id_debit_deposit_head = GL_debit_deposit_head.id_debit_deposit_head WHERE (GL_debit_deposit.type_transaction = 'A') " & WhereClause
        Try
            Num622.Text = Num622.Text + Math.Abs(CmdGeneral.ExecuteScalar)
        Catch ex As Exception
        End Try

        CmdGeneral.CommandText = "SELECT isnull(sum(round(isnull(GL_debit_deposit.deposit_amount,0),2)),0) FROM GL_debit_deposit INNER JOIN GL_payment_deposit ON GL_debit_deposit.ID_payment = GL_payment_deposit.ID_payment INNER JOIN GL_debit_deposit_head ON GL_debit_deposit.id_debit_deposit_head = GL_debit_deposit_head.id_debit_deposit_head WHERE     (GL_debit_deposit.type_transaction = '1') AND (GL_payment_deposit.payment_type = '3') " & WhereClause
        Try
            Num632.Text = Math.Abs(CmdGeneral.ExecuteScalar)
        Catch ex As Exception
            Num632.Text = 0
        End Try

        '############################################################################################################
        WhereClause = " AND dbo.changedate(date_transaction)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_transaction)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "Select Amount from bank_ATM_dtl INNER JOIN bank_ATM ON bank_ATM_dtl.id_ATM = bank_ATM.id_ATM Where ChargeCredit='2' " & WhereClause
        Try
            Num642.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num642.Text = 0
        End Try

        ' ???????????????????????????
        '############################################################################################################
        WhereClause = " AND dbo.changedate(date_transfer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_transfer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "SELECT amount_transfer FROM GL_transfer_amount Where 1=1 " & WhereClause
        Try
            Num652.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num652.Text = 0
        End Try

        '############################################################################################################
        WhereClause = " AND dbo.changedate(adjustment_date)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(adjustment_date)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        '############################################################################################################
        CmdGeneral.CommandText = "SELECT Bank_Adjustment_dtl.deposit_amount FROM Bank_Adjustment_dtl INNER JOIN bank_adjustment_head ON Bank_Adjustment_dtl.Id_Adjustment_no = bank_adjustment_head.Id_Adjustment_no Where 1=1 " & WhereClause
        Try
            Num662.Text = CmdGeneral.ExecuteScalar
        Catch ex As Exception
            Num662.Text = 0
        End Try

        Num672.Text = Num612.Numbervalue + Num622.Numbervalue + Num632.Numbervalue + Num642.Numbervalue + Num652.Numbervalue + Num662.Numbervalue





        CmdGeneral.Connection.Close()
    End Function
    Private Sub Num111_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num111.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayCashInvoices
            MyFrmEndOfDayDetail.WhereClauseVar = " Where GL_payment_deposit.refer_type='1' AND service_center_Head.type_of_form='IN' AND GL_payment_deposit.payment_type='1' AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            '' change by aryafar because of fetal error

            '' MyFrmEndOfDayDetail.WhereClauseVar = " Where   service_center_Head.type_of_form='IN' AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num121_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num121.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayCheckInvoices
            MyFrmEndOfDayDetail.WhereClauseVar = " Where GL_payment_deposit.refer_type='1' AND service_center_Head.type_of_form='IN' AND GL_payment_deposit.payment_type='2' AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            '' change by aryafar because of fetal error

            ''MyFrmEndOfDayDetail.WhereClauseVar = " Where service_center_Head.type_of_form='IN' AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num131_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num131.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayCreditCardInvoices
            MyFrmEndOfDayDetail.WhereClauseVar = " Where GL_payment_deposit.refer_type='1' AND service_center_Head.type_of_form='IN' AND GL_payment_deposit.payment_type='3' AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num112_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num112.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayCashReceipts
            MyFrmEndOfDayDetail.WhereClauseVar = " Where Gl_receive_payment.pmt_method = '1' AND dbo.changedate(date_receive_payment)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_receive_payment)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            'MyFrmEndOfDayDetail.WhereClauseVar = " Where GL_payment_deposit.refer_type='2' AND GL_payment_deposit.payment_type='1' AND dbo.changedate(date_receive_payment)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_receive_payment)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num122_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num122.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayCheckReceipts
            'MyFrmEndOfDayDetail.WhereClauseVar = " Where GL_payment_deposit.refer_type='2' AND GL_payment_deposit.payment_type='2' AND dbo.changedate(date_receive_payment)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_receive_payment)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.WhereClauseVar = " Where Gl_receive_payment.pmt_method = '2' AND dbo.changedate(date_receive_payment)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_receive_payment)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num132_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num132.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayCreditCardReceipts
            MyFrmEndOfDayDetail.WhereClauseVar = " Where Gl_receive_payment.pmt_method = '3' AND dbo.changedate(date_receive_payment)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_receive_payment)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            'MyFrmEndOfDayDetail.WhereClauseVar = " Where GL_payment_deposit.refer_type='2' AND GL_payment_deposit.payment_type='3' AND dbo.changedate(date_receive_payment)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_receive_payment)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num113_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num113.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayCashOtherReceipts
            MyFrmEndOfDayDetail.WhereClauseVar = " Where GL_Paid_received.tran_type='2' AND GL_Paid_received.OtherReceipType='1' AND dbo.changedate(action_date)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(action_date)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num123_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num123.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayCheckOtherReceipts
            MyFrmEndOfDayDetail.WhereClauseVar = " Where GL_Paid_received.tran_type='2' AND GL_Paid_received.OtherReceipType='2' AND dbo.changedate(action_date)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(action_date)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num114_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num114.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayCashReturns
            MyFrmEndOfDayDetail.WhereClauseVar = " Where GL_Paid_received.tran_type='3' AND dbo.changedate(action_date)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(action_date)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num124_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num124.DoubleClick
    End Sub
    Private Sub Num134_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num134.DoubleClick
    End Sub
    Private Sub NumPaidOutCP_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumPaidOutCP.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayCashPaidOut
            MyFrmEndOfDayDetail.WhereClauseVar = " Where GL_Paid_received.tran_type='1' AND dbo.changedate(action_date)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(action_date)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub NumNewCharges_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumNewCharges.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayAccountReceivableCharges
            MyFrmEndOfDayDetail.WhereClauseVar = " Where GL_payment_deposit.refer_type='1' AND GL_payment_deposit.payment_type='4' AND (GL_payment_deposit.id_service_center NOT IN (SELECT  id_service_center FROM  service_center_dtl WHERE     type_select = 'B')) AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.FormHeaderVar = "Account Receivable Charges Without Beginning Balances"
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub NumBeginingBalances_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumBeginingBalances.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayAccountReceivableCharges
            MyFrmEndOfDayDetail.WhereClauseVar = " Where GL_payment_deposit.refer_type='1' AND GL_payment_deposit.payment_type='4' AND (GL_payment_deposit.id_service_center IN (SELECT  id_service_center FROM  service_center_dtl WHERE     type_select = 'B')) AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.FormHeaderVar = "Account Receivable Charges ( Beginning Balances )"
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub NumNetAdjustment_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumNetAdjustment.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayAccountReceivableAdjustments
            MyFrmEndOfDayDetail.WhereClauseVar = " Where dbo.changedate(GL_account_adjustment_head.date_adjustment)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(GL_account_adjustment_head.date_adjustment)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub NumReceivedOnAccounts_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumReceivedOnAccounts.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayAccountReceivableReceipts
            MyFrmEndOfDayDetail.WhereClauseVar = " Where dbo.changedate(Gl_receive_payment.date_receive_payment)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(Gl_receive_payment.date_receive_payment)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub NumReturnsCredits_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumReturnsCredits.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayAccountReceivableCredits
            MyFrmEndOfDayDetail.WhereClauseVar = " Where GL_payment_deposit.refer_type='3' AND GL_payment_deposit.payment_type='3' AND dbo.changedate(service_center_head.date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(service_center_head.date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub

    Private Sub Num211_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num211.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayTirePartsSales
            MyFrmEndOfDayDetail.WhereClauseVar = " Where service_center_Head.type_of_form='IN' AND service_center_dtl.type_select='I' AND inv_item_cost_transaction.last_flag=1 AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num221_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num221.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayLaborSuppliesSales
            MyFrmEndOfDayDetail.WhereClauseVar = " Where service_center_Head.type_of_form='IN' AND (service_center_dtl.type_select='L' OR service_center_dtl.type_select='S') AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num231_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num231.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayLaborSuppliesSales
            MyFrmEndOfDayDetail.WhereClauseVar = " Where service_center_Head.type_of_form='IN' AND service_center_dtl.type_select='F' AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num241_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num241.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayOutsidePurchasesSales
            MyFrmEndOfDayDetail.WhereClauseVar = " Where service_center_Head.type_of_form='IN' AND service_center_dtl.type_select='O' AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num251_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num251.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayAdjustmentsSales
            MyFrmEndOfDayDetail.WhereClauseVar = " Where service_center_Head.type_of_form='IN' AND service_center_dtl.type_select='A' AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num215_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num215.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayTirePartsReturns
            MyFrmEndOfDayDetail.WhereClauseVar = " Where service_center_Head.type_of_form='RT' AND service_center_dtl.type_select='I' AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num225_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num225.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayLaborSuppliesReturns
            MyFrmEndOfDayDetail.WhereClauseVar = " Where service_center_Head.type_of_form='RT' AND (service_center_dtl.type_select='L' OR service_center_dtl.type_select='S') AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num235_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num235.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayFeesReturns
            MyFrmEndOfDayDetail.WhereClauseVar = " Where service_center_Head.type_of_form='RT' AND service_center_dtl.type_select='F' AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num245_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num245.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayOutsidePurchasesReturns
            MyFrmEndOfDayDetail.WhereClauseVar = " Where service_center_Head.type_of_form='RT' AND service_center_dtl.type_select='O' AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num291_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num291.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayTotalSales
            MyFrmEndOfDayDetail.WhereClauseVar = " Where service_center_Head.type_of_form='IN' AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num295_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num295.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayTotalReturns
            MyFrmEndOfDayDetail.WhereClauseVar = " Where service_center_Head.type_of_form='RT' AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub


    Private Sub Num411_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num411.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayInventorySales
            MyFrmEndOfDayDetail.KindOfForm = 1
            MyFrmEndOfDayDetail.WhereClauseVar = " Where service_center_dtl.type_select='I' AND service_center_Head.type_of_form='IN' AND inv_item_cost_transaction.last_flag=1 AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num421_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num421.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayInventorySales
            MyFrmEndOfDayDetail.KindOfForm = 2
            MyFrmEndOfDayDetail.WhereClauseVar = " Where service_center_dtl.type_select='I' AND service_center_Head.type_of_form='RT' AND inv_item_cost_transaction.last_flag=1 AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num431_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num431.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayInventoryReceipts
            MyFrmEndOfDayDetail.KindOfForm = 1
            MyFrmEndOfDayDetail.WhereClauseVar = " Where Inv_Receive_Products_head.bill_credit='1' AND inv_item_cost_transaction.last_flag=1 AND dbo.changedate(date_receive)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_receive)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num441_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num441.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayInventoryReceipts
            MyFrmEndOfDayDetail.KindOfForm = 2
            MyFrmEndOfDayDetail.WhereClauseVar = " Where Inv_Receive_Products_head.bill_credit='2' AND inv_item_cost_transaction.last_flag=1 AND dbo.changedate(date_receive)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_receive)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num451_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num451.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayInventoryAdjustment
            MyFrmEndOfDayDetail.WhereClauseVar = " Where inv_item_cost_transaction.last_flag=1 AND dbo.changedate(date_adjustment)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_adjustment)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num461_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num461.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayInventoryTransfers
            MyFrmEndOfDayDetail.WhereClauseVar = " Where inv_salse_transfer_head.type_sales_transfer='2' AND inv_item_cost_transaction.last_flag=1 AND dbo.changedate(date_action)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_action)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num471_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num471.DoubleClick

        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayInventoryInterStoreSales
            MyFrmEndOfDayDetail.WhereClauseVar = " Where inv_salse_transfer_head.type_sales_transfer='1' AND inv_item_cost_transaction.last_flag=1 AND dbo.changedate(date_action)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_action)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num481_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num481.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayInventoryPurchaseOrders
            MyFrmEndOfDayDetail.WhereClauseVar = " Where inv_item_cost_transaction.last_flag=1 AND dbo.changedate(date_po)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_po)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub


    Private Sub Num611_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num611.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayChecksWritten
            MyFrmEndOfDayDetail.WhereClauseVar = " Where dbo.changedate(date_of_check)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_of_check)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num621_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num621.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayATMWithdrawals
            MyFrmEndOfDayDetail.WhereClauseVar = " Where bank_ATM.ChargeCredit='1' AND dbo.changedate(date_transaction)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_transaction)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num651_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num651.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayBankTransfers
            MyFrmEndOfDayDetail.WhereClauseVar = " Where dbo.changedate(date_transfer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_transfer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num661_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num661.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayOtherDebits
            MyFrmEndOfDayDetail.WhereClauseVar = " Where GL_account_adjustment_head.amount_adjustment<0 AND dbo.changedate(date_adjustment)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_adjustment)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num642_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num642.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayATMCredits
            MyFrmEndOfDayDetail.WhereClauseVar = " Where bank_ATM.ChargeCredit='2' AND dbo.changedate(date_transaction)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_transaction)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub Num662_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Num662.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayDetail As New FrmEndOfDayOtherCredits
            MyFrmEndOfDayDetail.WhereClauseVar = " Where GL_account_adjustment_head.amount_adjustment>=0 AND dbo.changedate(date_adjustment)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_adjustment)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
            MyFrmEndOfDayDetail.ShowDialog()
        End If
    End Sub
    Private Sub UiContextMenu1_CommandClick(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles UiContextMenu1.CommandClick
        Select Case e.Command.Key.ToUpper
            Case "TabPrint1".ToUpper
                If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
                    Dim MyFrmEndOfDayCashReport As New FrmEndOfDayCashReport
                    MyFrmEndOfDayCashReport.FromDateVar = DteFromDate.Text
                    MyFrmEndOfDayCashReport.ToDateVar = DteToDate.Text
                    MyFrmEndOfDayCashReport.ShowDialog()
                End If
            Case "TabPrint2".ToUpper
                If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
                    Dim MyFrmEndOfDaySalesReport As New FrmEndOfDaySalesReport
                    MyFrmEndOfDaySalesReport.FromDateVar = DteFromDate.Text
                    MyFrmEndOfDaySalesReport.ToDateVar = DteToDate.Text
                    MyFrmEndOfDaySalesReport.ShowDialog()
                End If
            Case "TabPrint3".ToUpper
                If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
                    Dim MyFrmEndOfDayARReport As New FrmEndOfDayARReport
                    MyFrmEndOfDayARReport.FromDateVar = DteFromDate.Text
                    MyFrmEndOfDayARReport.ToDateVar = DteToDate.Text
                    MyFrmEndOfDayARReport.ShowDialog()
                End If
            Case "TabPrint4".ToUpper
                If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
                    Dim MyFrmEndOfDayProductsReport As New FrmEndOfDayProductsReport
                    MyFrmEndOfDayProductsReport.FromDateVar = DteFromDate.Text
                    MyFrmEndOfDayProductsReport.ToDateVar = DteToDate.Text
                    MyFrmEndOfDayProductsReport.ShowDialog()
                End If
            Case "TabPrint5".ToUpper
                If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
                    Dim MyFrmEndOfDayOutsidePurchasesReport As New FrmEndOfDayOutsidePurchasesReport
                    MyFrmEndOfDayOutsidePurchasesReport.FromDateVar = DteFromDate.Text
                    MyFrmEndOfDayOutsidePurchasesReport.ToDateVar = DteToDate.Text
                    MyFrmEndOfDayOutsidePurchasesReport.ShowDialog()
                End If
            Case "TabPrint6".ToUpper
                If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
                    Dim MyFrmEndOfDayServicesReport As New FrmEndOfDayServicesReport
                    MyFrmEndOfDayServicesReport.FromDateVar = DteFromDate.Text
                    MyFrmEndOfDayServicesReport.ToDateVar = DteToDate.Text
                    MyFrmEndOfDayServicesReport.ShowDialog()
                End If
                'Case "TabPrint7".ToUpper
                '    If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
                '        Dim MyFrmEndOfDayBankingReport As New FrmEndOfDayBankingReport
                '        MyFrmEndOfDayBankingReport.FromDateVar = DteFromDate.Text
                '        MyFrmEndOfDayBankingReport.ToDateVar = DteToDate.Text
                '        MyFrmEndOfDayBankingReport.ShowDialog()
                '    End If
                'Case "TabPrint8".ToUpper
                '    If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
                '        Dim MyFrmEndOfDayGLReport As New FrmEndOfDayGLReport
                '        MyFrmEndOfDayGLReport.FromDateVar = DteFromDate.Text
                '        MyFrmEndOfDayGLReport.ToDateVar = DteToDate.Text
                '        MyFrmEndOfDayGLReport.ShowDialog()
                '    End If
        End Select
    End Sub
    Private Sub BtnPaymentOnHold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPaymentOnHold.Click
        Dim MyFrmPaymentOnHold As New WorkOrderUtility.FrmPaymentOnHold
        MyFrmPaymentOnHold.WhereClauseVar = " Where Total<>0 AND service_center_Head.type_of_form='IN' AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        MyFrmPaymentOnHold.Text = "Payment On Hold"
        MyFrmPaymentOnHold.ShowDialog()
    End Sub
    Private Sub BtnSummaryPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSummaryPrint.Click
        Dim TitleVar As String = "Store Sales Audit From " & DteFromDate.Text & " To " & DteToDate.Text

        Dim rpt1 As New RepEndOfDay1
        Dim rpt2 As New RepEndOfDay2
        Dim rpt3 As New RepEndOfDay3
        Dim rpt4 As New RepEndOfDay4
        Dim rpt5 As New RepEndOfDay5
        Dim rpt6 As New RepEndOfDay6
        Dim prn As New FrmRepView

        ' **************************************************************
        rpt1.SetParameterValue("RepTitle", TitleVar)
        rpt1.SetParameterValue("ParStoreShortName", PubStoreName & "")
        rpt1.SetParameterValue("HeadTitle", "Cash")
        rpt1.SetParameterValue("param1-01", Lbl101.Text)
        rpt1.SetParameterValue("param1-02", Lbl102.Text)
        rpt1.SetParameterValue("param1-03", Lbl103.Text)
        rpt1.SetParameterValue("param1-04", Lbl104.Text)
        rpt1.SetParameterValue("param1-05", LabelDownPayment.Text)
        rpt1.SetParameterValue("param1-06", Lbl106.Text)
        rpt1.SetParameterValue("param1-10", Lbl111.Text)
        rpt1.SetParameterValue("param1-20", Lbl112.Text)
        rpt1.SetParameterValue("param1-30", Lbl113.Text)
        rpt1.SetParameterValue("param1-40", Lbl114.Text)
        rpt1.SetParameterValue("param1-50", LblCC1.Text)
        rpt1.SetParameterValue("param1-60", LblCC2.Text)
        rpt1.SetParameterValue("param1-70", LblCC3.Text)
        rpt1.SetParameterValue("param1-80", LblCC4.Text)
        rpt1.SetParameterValue("param1-90", LblCC5.Text)

        rpt1.SetParameterValue("param1-11", Num111.Text)
        rpt1.SetParameterValue("param1-12", Num112.Text)
        rpt1.SetParameterValue("param1-13", Num113.Text)
        rpt1.SetParameterValue("param1-14", Num114.Text)
        rpt1.SetParameterValue("param1-15", NumDownPayment1.Text)
        rpt1.SetParameterValue("param1-16", Num116.Text)

        rpt1.SetParameterValue("param1-21", Num121.Text)
        rpt1.SetParameterValue("param1-22", Num122.Text)
        rpt1.SetParameterValue("param1-23", Num123.Text)
        rpt1.SetParameterValue("param1-24", Num124.Text)
        rpt1.SetParameterValue("param1-25", NumDownPayment2.Text)
        rpt1.SetParameterValue("param1-26", Num126.Text)

        rpt1.SetParameterValue("param1-31", Num131.Text)
        rpt1.SetParameterValue("param1-32", Num132.Text)
        'rpt1.SetParameterValue("param1-33", Num133.Text)
        rpt1.SetParameterValue("param1-34", Num134.Text)
        rpt1.SetParameterValue("param1-35", NumDownPayment3.Text)
        rpt1.SetParameterValue("param1-36", Num136.Text)

        rpt1.SetParameterValue("param1-41", Num141.Text)
        rpt1.SetParameterValue("param1-42", Num142.Text)
        rpt1.SetParameterValue("param1-43", Num143.Text)
        rpt1.SetParameterValue("param1-44", Num144.Text)
        rpt1.SetParameterValue("param1-45", NumDownPayment4.Text)
        rpt1.SetParameterValue("param1-46", Num146.Text)

        rpt1.SetParameterValue("param1-51", Num151.Text)
        rpt1.SetParameterValue("param1-52", Num152.Text)
        rpt1.SetParameterValue("param1-53", Num153.Text)
        rpt1.SetParameterValue("param1-54", Num154.Text)
        rpt1.SetParameterValue("param1-55", NumDownPayment5.Text)
        rpt1.SetParameterValue("param1-56", Num156.Text)

        rpt1.SetParameterValue("param1-61", Num161.Text)
        rpt1.SetParameterValue("param1-62", Num162.Text)
        rpt1.SetParameterValue("param1-63", Num163.Text)
        rpt1.SetParameterValue("param1-64", Num164.Text)
        rpt1.SetParameterValue("param1-65", NumDownPayment6.Text)
        rpt1.SetParameterValue("param1-66", Num166.Text)

        rpt1.SetParameterValue("param1-71", Num171.Text)
        rpt1.SetParameterValue("param1-72", Num172.Text)
        rpt1.SetParameterValue("param1-73", Num173.Text)
        rpt1.SetParameterValue("param1-74", Num174.Text)
        rpt1.SetParameterValue("param1-75", NumDownPayment7.Text)
        rpt1.SetParameterValue("param1-76", Num176.Text)

        rpt1.SetParameterValue("param1-81", Num181.Text)
        rpt1.SetParameterValue("param1-82", Num182.Text)
        rpt1.SetParameterValue("param1-83", Num183.Text)
        rpt1.SetParameterValue("param1-84", Num184.Text)
        rpt1.SetParameterValue("param1-85", NumDownPayment8.Text)
        rpt1.SetParameterValue("param1-86", Num186.Text)

        rpt1.SetParameterValue("param1-91", Num191.Text)
        rpt1.SetParameterValue("param1-92", Num192.Text)
        rpt1.SetParameterValue("param1-93", Num193.Text)
        rpt1.SetParameterValue("param1-94", Num194.Text)
        rpt1.SetParameterValue("param1-95", NumDownPayment9.Text)
        rpt1.SetParameterValue("param1-96", Num196.Text)

        rpt1.SetParameterValue("ParamPaidOutCP", NumPaidOutCP.Text)

        rpt1.PrintToPrinter(1, True, 0, 0)

        ' **************************************************************
        rpt2.SetParameterValue("RepTitle", TitleVar)
        rpt2.SetParameterValue("ParStoreShortName", PubStoreName & "")
        rpt2.SetParameterValue("HeadTitle", "Sales Summary")
        rpt2.SetParameterValue("param1-01", Lbl201.Text)
        rpt2.SetParameterValue("param1-02", Lbl202.Text)
        rpt2.SetParameterValue("param1-03", Lbl203.Text)
        rpt2.SetParameterValue("param1-04", Lbl204.Text)
        rpt2.SetParameterValue("param1-05", Lbl205.Text)
        rpt2.SetParameterValue("param1-10", Lbl211.Text)
        rpt2.SetParameterValue("param1-20", Lbl212.Text)
        rpt2.SetParameterValue("param1-30", Lbl213.Text)
        rpt2.SetParameterValue("param1-40", Lbl214.Text)
        rpt2.SetParameterValue("param1-50", Lbl215.Text)
        rpt2.SetParameterValue("param1-60", Lbl216.Text)
        rpt2.SetParameterValue("param1-70", Lbl217.Text)
        rpt2.SetParameterValue("param1-80", Lbl218.Text)
        rpt2.SetParameterValue("param1-90", Lbl219.Text)

        rpt2.SetParameterValue("param1-11", Num211.Text)
        rpt2.SetParameterValue("param1-12", Num212.Text)
        rpt2.SetParameterValue("param1-13", Num213.Text)
        rpt2.SetParameterValue("param1-14", Num214.Text)
        rpt2.SetParameterValue("param1-15", Num215.Text)

        rpt2.SetParameterValue("param1-21", Num221.Text)
        rpt2.SetParameterValue("param1-22", Num222.Text)
        rpt2.SetParameterValue("param1-23", Num223.Text)
        rpt2.SetParameterValue("param1-24", Num224.Text)
        rpt2.SetParameterValue("param1-25", Num225.Text)

        rpt2.SetParameterValue("param1-31", Num231.Text)
        rpt2.SetParameterValue("param1-32", Num232.Text)
        rpt2.SetParameterValue("param1-33", Num233.Text)
        rpt2.SetParameterValue("param1-34", Num234.Text)
        rpt2.SetParameterValue("param1-35", Num235.Text)

        rpt2.SetParameterValue("param1-41", Num241.Text)
        rpt2.SetParameterValue("param1-42", Num242.Text)
        rpt2.SetParameterValue("param1-43", Num243.Text)
        rpt2.SetParameterValue("param1-44", Num244.Text)
        rpt2.SetParameterValue("param1-45", Num245.Text)

        rpt2.SetParameterValue("param1-51", Num251.Text)
        rpt2.SetParameterValue("param1-52", Num252.Text)
        rpt2.SetParameterValue("param1-53", Num253.Text)
        rpt2.SetParameterValue("param1-54", Num254.Text)

        rpt2.SetParameterValue("param1-61", Num261.Text)
        rpt2.SetParameterValue("param1-62", Num262.Text)
        rpt2.SetParameterValue("param1-63", Num263.Text)
        rpt2.SetParameterValue("param1-64", Num264.Text)
        rpt2.SetParameterValue("param1-65", Lbl165.Text)

        rpt2.SetParameterValue("param1-71", Num271.Text)
        rpt2.SetParameterValue("param1-72", Num272.Text)
        rpt2.SetParameterValue("param1-73", Num273.Text)
        rpt2.SetParameterValue("param1-74", Num274.Text)
        rpt2.SetParameterValue("param1-75", Num275.Text)

        rpt2.SetParameterValue("param1-81", Num281.Text)
        rpt2.SetParameterValue("param1-84", Lbl184.Text)
        rpt2.SetParameterValue("param1-85", Num285.Text)

        rpt2.SetParameterValue("param1-91", Num291.Text)
        rpt2.SetParameterValue("param1-94", Lbl194.Text)
        rpt2.SetParameterValue("param1-95", Num295.Text)

        rpt2.SetParameterValue("ParamDiscountLabel", LblDiscount.Text)
        rpt2.SetParameterValue("ParamDiscount", NumDiscounts.Text)
        rpt2.SetParameterValue("ParamReturnDiscountLabel", LblReturnDiscount.Text)
        rpt2.SetParameterValue("ParamReturnDiscount", NumDiscountReturns.Text)

        rpt2.SetParameterValue("paramSalesTax1", NumSalesTax1.Text)
        rpt2.SetParameterValue("paramSalesTax2", NumSalesTax2.Text)
        rpt2.SetParameterValue("paramSalesTax3", NumSalesTax3.Text)
        rpt2.SetParameterValue("paramSalesTax4", NumSalesTax4.Text)
        rpt2.SetParameterValue("paramSalesTax5", NumSalesTax5.Text)
        rpt2.SetParameterValue("paramSalesTax6", NumSalesTax6.Text)
        rpt2.SetParameterValue("ParamSaleTaxOtherExemptions", NumOtherExemptions.Text)
        rpt2.SetParameterValue("paramSalesTaxLabel1", LblSalesTax1.Text)
        rpt2.SetParameterValue("paramSalesTaxLabel2", LblSalesTax2.Text)
        rpt2.SetParameterValue("paramSalesTaxLabel3", LblSalesTax3.Text)
        rpt2.SetParameterValue("paramSalesTaxLabel4", LblSalesTax4.Text)
        rpt2.SetParameterValue("paramSalesTaxLabel5", LblSalesTax5.Text)
        rpt2.SetParameterValue("paramSalesTaxLabel6", LblSalesTax6.Text)
        rpt2.SetParameterValue("ParamSaleTaxLabelOtherExemptions", LblOtherExemptions.Text)

        rpt2.PrintToPrinter(1, True, 0, 0)

        ' **************************************************************
        rpt3.SetParameterValue("RepTitle", TitleVar)
        rpt3.SetParameterValue("ParStoreShortName", PubStoreName & "")
        rpt3.SetParameterValue("HeadTitle", "Account Receivable Summary ")
        rpt3.SetParameterValue("ParamBeginingBalance", NumBeginingBalance.Text)
        rpt3.SetParameterValue("ParamReceivedOnAccounts", NumReceivedOnAccounts.Text)
        rpt3.SetParameterValue("ParamReturnsCredits", NumReturnsCredits.Text)
        rpt3.SetParameterValue("ParamTotalCredits", NumTotalCredits.Text)
        rpt3.SetParameterValue("ParamEndingBalance", NumEndingBalance.Text)
        rpt3.SetParameterValue("ParamNewCharges", NumNewCharges.Text)
        rpt3.SetParameterValue("ParamTotalDebits", NumTotalDebits.Text)
        rpt3.SetParameterValue("ParamNewCharges", NumNewCharges.Text)
        rpt3.SetParameterValue("ParamNetAdjustment", NumNetAdjustment.Text)

        rpt3.SetParameterValue("ParamBeginingBalanceLabel", LblBeginingBalance.Text)
        rpt3.SetParameterValue("ParamReceivedOnAccountsLabel", LblReceivedOnAccounts.Text)
        rpt3.SetParameterValue("ParamReturnsCreditsLabel", LblReturnsCredits.Text)
        rpt3.SetParameterValue("ParamTotalCreditsLabel", LblTotalCredits.Text)
        rpt3.SetParameterValue("ParamEndingBalanceLabel", LblEndingBalance.Text)
        rpt3.SetParameterValue("ParamNewChargesLabel", LblNewCharges.Text)
        rpt3.SetParameterValue("ParamTotalDebitsLabel", LblTotalDebits.Text)
        rpt3.SetParameterValue("ParamNewChargesLabel", LblNewCharges.Text)
        rpt3.SetParameterValue("ParamNetAdjustmentLabel", LblNetAdjustment.Text)

        rpt3.PrintToPrinter(1, True, 0, 0)

        ' **************************************************************
        rpt4.SetParameterValue("RepTitle", TitleVar)
        rpt4.SetParameterValue("ParStoreShortName", PubStoreName & "")
        rpt4.SetParameterValue("HeadTitle", "Products")
        rpt4.SetParameterValue("param1-01", Lbl401.Text)
        rpt4.SetParameterValue("param1-02", Lbl402.Text)
        rpt4.SetParameterValue("param1-03", Lbl403.Text)
        rpt4.SetParameterValue("param1-10", Lbl411.Text)
        rpt4.SetParameterValue("param1-20", Lbl412.Text)
        rpt4.SetParameterValue("param1-30", Lbl413.Text)
        rpt4.SetParameterValue("param1-40", Lbl414.Text)
        rpt4.SetParameterValue("param1-50", Lbl415.Text)
        rpt4.SetParameterValue("param1-60", Lbl416.Text)
        rpt4.SetParameterValue("param1-70", Lbl417.Text)
        rpt4.SetParameterValue("param1-80", Lbl418.Text)

        rpt4.SetParameterValue("param1-11", Num411.Text)
        rpt4.SetParameterValue("param1-12", Num412.Text)
        rpt4.SetParameterValue("param1-13", Num413.Text)

        rpt4.SetParameterValue("param1-21", Num421.Text)
        rpt4.SetParameterValue("param1-22", Num422.Text)
        rpt4.SetParameterValue("param1-23", Num423.Text)

        rpt4.SetParameterValue("param1-31", Num431.Text)
        rpt4.SetParameterValue("param1-32", Num432.Text)
        rpt4.SetParameterValue("param1-33", Num433.Text)

        rpt4.SetParameterValue("param1-41", Num441.Text)
        rpt4.SetParameterValue("param1-42", Num442.Text)
        rpt4.SetParameterValue("param1-43", Num443.Text)

        rpt4.SetParameterValue("param1-51", Num451.Text)
        rpt4.SetParameterValue("param1-52", Num452.Text)
        rpt4.SetParameterValue("param1-53", Num453.Text)

        rpt4.SetParameterValue("param1-61", Num461.Text)
        rpt4.SetParameterValue("param1-62", Num462.Text)
        rpt4.SetParameterValue("param1-63", Num463.Text)

        rpt4.SetParameterValue("param1-71", Num471.Text)
        rpt4.SetParameterValue("param1-72", Num472.Text)
        rpt4.SetParameterValue("param1-73", Num473.Text)

        rpt4.SetParameterValue("param1-81", Num481.Text)
        rpt4.SetParameterValue("param1-82", Num482.Text)
        rpt4.SetParameterValue("param1-83", Num483.Text)

        rpt4.SetParameterValue("ParamInventoryTurnOver", LblInventoryTurnOver.Text)
        rpt4.SetParameterValue("ParamLbl464", Lbl464.Text)
        rpt4.SetParameterValue("ParamLbl474", Lbl474.Text)
        rpt4.SetParameterValue("ParamLbl484", Lbl484.Text)
        rpt4.SetParameterValue("Param464", Num464.Text)
        rpt4.SetParameterValue("Param474", Num474.Text)
        rpt4.SetParameterValue("Param484", Num484.Text)

        rpt4.PrintToPrinter(1, True, 0, 0)

        ' **************************************************************
        rpt5.SetParameterValue("RepTitle", TitleVar)
        rpt5.SetParameterValue("ParStoreShortName", PubStoreName & "")
        rpt5.SetParameterValue("HeadTitle", "Services")
        rpt5.SetParameterValue("param1-01", Lbl501.Text)
        rpt5.SetParameterValue("param1-02", Lbl502.Text)

        rpt5.SetParameterValue("param1-10", Lbl511.Text)
        rpt5.SetParameterValue("param1-20", Lbl512.Text)
        rpt5.SetParameterValue("param1-30", Lbl513.Text)
        rpt5.SetParameterValue("param1-40", Lbl514.Text)

        rpt5.SetParameterValue("param1-11", Num511.Text)
        rpt5.SetParameterValue("param1-12", Num512.Text)

        rpt5.SetParameterValue("param1-21", Num521.Text)
        rpt5.SetParameterValue("param1-22", Num522.Text)

        rpt5.SetParameterValue("param1-31", Num531.Text)
        rpt5.SetParameterValue("param1-32", Num532.Text)

        rpt5.SetParameterValue("param1-41", Num541.Text)
        rpt5.SetParameterValue("param1-42", Num542.Text)

        rpt5.PrintToPrinter(1, True, 0, 0)
        ' **************************************************************
        rpt6.SetParameterValue("RepTitle", TitleVar)
        rpt6.SetParameterValue("ParStoreShortName", PubStoreName & "")
        rpt6.SetParameterValue("HeadTitle", "Banking")
        rpt6.SetParameterValue("param1-01", Lbl601.Text)
        rpt6.SetParameterValue("param1-02", Lbl602.Text)

        rpt6.SetParameterValue("param1-10", Lbl611.Text)
        rpt6.SetParameterValue("param1-20", Lbl621.Text)
        rpt6.SetParameterValue("param1-50", Lbl651.Text)
        rpt6.SetParameterValue("param1-60", Lbl661.Text)
        rpt6.SetParameterValue("param1-70", Lbl671.Text)

        rpt6.SetParameterValue("param1-11", Num611.Text)
        rpt6.SetParameterValue("param1-12", Lbl612.Text)
        rpt6.SetParameterValue("param1-13", Num612.Text)

        rpt6.SetParameterValue("param1-21", Num621.Text)
        rpt6.SetParameterValue("param1-22", Lbl622.Text)
        rpt6.SetParameterValue("param1-23", Num622.Text)

        rpt6.SetParameterValue("param1-32", Lbl632.Text)
        rpt6.SetParameterValue("param1-33", Num632.Text)

        rpt6.SetParameterValue("param1-42", Lbl642.Text)
        rpt6.SetParameterValue("param1-43", Num642.Text)

        rpt6.SetParameterValue("param1-51", Num651.Text)
        rpt6.SetParameterValue("param1-52", Lbl652.Text)
        rpt6.SetParameterValue("param1-53", Num652.Text)

        rpt6.SetParameterValue("param1-61", Num661.Text)
        rpt6.SetParameterValue("param1-62", Lbl662.Text)
        rpt6.SetParameterValue("param1-63", Num662.Text)

        rpt6.SetParameterValue("param1-71", Num671.Text)
        rpt6.SetParameterValue("param1-72", Lbl672.Text)
        rpt6.SetParameterValue("param1-73", Num672.Text)

        rpt6.PrintToPrinter(1, True, 0, 0)
        ' **************************************************************
        'prn.CrViewer.ReportSource = rpt2
        'prn.Show()

    End Sub
    Private Sub BtnNoChargeInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNoChargeInvoice.Click
        Dim MyFrmPaymentOnHold As New WorkOrderUtility.FrmPaymentOnHold
        MyFrmPaymentOnHold.WhereClauseVar = " Where Total=0 AND service_center_Head.type_of_form='IN' AND dbo.changedate(date_refer)>=" & Qt(ChangeDateToYYYYMMDD(DteFromDate.Text)) & " AND dbo.changedate(date_refer)<=" & Qt(ChangeDateToYYYYMMDD(DteToDate.Text))
        MyFrmPaymentOnHold.Text = "No Charge Invoice"
        MyFrmPaymentOnHold.ShowDialog()
    End Sub
    Private Sub NumOtherExemptions_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumOtherExemptions.DoubleClick
        If Mid(DteFromDate.Text, 1, 2).Trim.Length > 0 And Mid(DteToDate.Text, 1, 2).Trim.Length > 0 Then
            Dim MyFrmEndOfDayOtherExemptions As New FrmEndOfDayOtherExemptions
            MyFrmEndOfDayOtherExemptions.FromDateVar = DteFromDate.Text
            MyFrmEndOfDayOtherExemptions.ToDateVar = DteToDate.Text
            MyFrmEndOfDayOtherExemptions.ShowDialog()
        End If
    End Sub

End Class

