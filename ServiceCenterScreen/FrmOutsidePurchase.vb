Imports CommonClass
Public Class FrmOutsidePurchase
    Inherits FrmBase
    Public IsOK As Boolean = False
    Public LineVar As String
    Public ApTermVar As String
    Private IsInvoiceNoMandatory As Boolean
    Private IsCostMandatory As Boolean
    Public TypeOfForm As String = ""
    Dim OldVandorCod As String = ""
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
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents BtnCancel As Janus.Windows.EditControls.UIButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
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
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Vendor_Cod1 As UCVendor.Vendor_Cod
    Friend WithEvents LblStyle As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents LblBrand As Janus.Windows.GridEX.EditControls.MaskedEditBox
    Friend WithEvents CmbLine As System.Windows.Forms.ComboBox
    Friend WithEvents DAinv_tab_line As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents BtnSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents DsFrmOutsidePurchase1 As ServiceCenterScreen.DSFrmOutsidePurchase
    Friend WithEvents LblVendorName As System.Windows.Forms.Label
    Friend WithEvents NumCost As CalcUtils.UcCalcText
    Friend WithEvents NumFet As CalcUtils.UcCalcText
    Friend WithEvents NumPrice As CalcUtils.UcCalcText
    Friend WithEvents NumPriceANDFet As CalcUtils.UcCalcText
    Friend WithEvents NumMarkup As CalcUtils.UcCalcText
    Friend WithEvents Txtpart_no As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Txtinvoice_no As System.Windows.Forms.TextBox
    Friend WithEvents Txtpo_no As System.Windows.Forms.TextBox
    Friend WithEvents Chktracking_warranty As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents Chktracking_core As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents Numin_day As CalcUtils.UcCalcText
    Friend WithEvents Numin_mile As CalcUtils.UcCalcText
    Friend WithEvents Numcore_value As CalcUtils.UcCalcText
    Friend WithEvents Dteinvoice_date As CalendarCombo.CalendarCombo
    Friend WithEvents Dtedue_date As CalendarCombo.CalendarCombo
    Friend WithEvents ChkPrepaid As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents DAGL_TAB_AR_TERM As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents cmbAR_term As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmOutsidePurchase))
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.BtnCancel = New Janus.Windows.EditControls.UIButton
        Me.BtnSave = New Janus.Windows.EditControls.UIButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Chktracking_warranty = New Janus.Windows.EditControls.UICheckBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Chktracking_core = New Janus.Windows.EditControls.UICheckBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Numin_day = New CalcUtils.UcCalcText
        Me.Numin_mile = New CalcUtils.UcCalcText
        Me.Numcore_value = New CalcUtils.UcCalcText
        Me.NumCost = New CalcUtils.UcCalcText
        Me.NumFet = New CalcUtils.UcCalcText
        Me.NumPrice = New CalcUtils.UcCalcText
        Me.NumPriceANDFet = New CalcUtils.UcCalcText
        Me.NumMarkup = New CalcUtils.UcCalcText
        Me.Dteinvoice_date = New CalendarCombo.CalendarCombo
        Me.Txtinvoice_no = New System.Windows.Forms.TextBox
        Me.Vendor_Cod1 = New UCVendor.Vendor_Cod
        Me.Dtedue_date = New CalendarCombo.CalendarCombo
        Me.LblStyle = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.LblBrand = New Janus.Windows.GridEX.EditControls.MaskedEditBox
        Me.CmbLine = New System.Windows.Forms.ComboBox
        Me.DsFrmOutsidePurchase1 = New ServiceCenterScreen.DSFrmOutsidePurchase
        Me.DAinv_tab_line = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Txtpo_no = New System.Windows.Forms.TextBox
        Me.Txtpart_no = New System.Windows.Forms.TextBox
        Me.TxtDescription = New System.Windows.Forms.TextBox
        Me.LblVendorName = New System.Windows.Forms.Label
        Me.ChkPrepaid = New Janus.Windows.EditControls.UICheckBox
        Me.DAGL_TAB_AR_TERM = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.cmbAR_term = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        CType(Me.DsFrmOutsidePurchase1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(27, 327)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(99, 24)
        Me.BtnCancel.TabIndex = 19
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Location = New System.Drawing.Point(373, 327)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(99, 24)
        Me.BtnSave.TabIndex = 20
        Me.BtnSave.Text = "Save"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Item No"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Description"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cost"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(219, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fet"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(359, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Price"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Markup %"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(319, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 23)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Price + FET"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Vendor"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(300, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 23)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Store PO No"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(6, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Vendor Invoice No"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(232, 237)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 23)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Brand"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(6, 214)
        Me.Label12.Name = "Label12"
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Invoice Date"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(239, 214)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 23)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Style"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(6, 237)
        Me.Label14.Name = "Label14"
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Due Date"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(237, 187)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 23)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Line"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Chktracking_warranty
        '
        Me.Chktracking_warranty.Location = New System.Drawing.Point(22, 268)
        Me.Chktracking_warranty.Name = "Chktracking_warranty"
        Me.Chktracking_warranty.Size = New System.Drawing.Size(104, 23)
        Me.Chktracking_warranty.TabIndex = 14
        Me.Chktracking_warranty.Text = "Track Warranty"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(164, 268)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 23)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "In Days"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(338, 268)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 23)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "In Miles"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Chktracking_core
        '
        Me.Chktracking_core.Location = New System.Drawing.Point(22, 297)
        Me.Chktracking_core.Name = "Chktracking_core"
        Me.Chktracking_core.Size = New System.Drawing.Size(104, 23)
        Me.Chktracking_core.TabIndex = 17
        Me.Chktracking_core.Text = "Track Core"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(164, 297)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 23)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Core Value"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Numin_day
        '
        Me.Numin_day.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Numin_day.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Numin_day.DecimalDigits = 0
        Me.Numin_day.DefaultSendValue = False
        Me.Numin_day.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Numin_day.FireTabAfterEnter = False
        Me.Numin_day.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Numin_day.Image = CType(resources.GetObject("Numin_day.Image"), System.Drawing.Image)
        Me.Numin_day.Location = New System.Drawing.Point(230, 269)
        Me.Numin_day.Maxlength = 4
        Me.Numin_day.MinusColor = System.Drawing.Color.Empty
        Me.Numin_day.Name = "Numin_day"
        Me.Numin_day.Size = New System.Drawing.Size(63, 22)
        Me.Numin_day.TabIndex = 15
        Me.Numin_day.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Numin_day.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Numin_mile
        '
        Me.Numin_mile.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Numin_mile.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Numin_mile.DecimalDigits = 0
        Me.Numin_mile.DefaultSendValue = False
        Me.Numin_mile.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Numin_mile.FireTabAfterEnter = False
        Me.Numin_mile.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Numin_mile.Image = CType(resources.GetObject("Numin_mile.Image"), System.Drawing.Image)
        Me.Numin_mile.Location = New System.Drawing.Point(395, 269)
        Me.Numin_mile.Maxlength = 4
        Me.Numin_mile.MinusColor = System.Drawing.Color.Empty
        Me.Numin_mile.Name = "Numin_mile"
        Me.Numin_mile.Size = New System.Drawing.Size(64, 22)
        Me.Numin_mile.TabIndex = 16
        Me.Numin_mile.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Numin_mile.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Numcore_value
        '
        Me.Numcore_value.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.Numcore_value.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.Numcore_value.DecimalDigits = 2
        Me.Numcore_value.DefaultSendValue = False
        Me.Numcore_value.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.Numcore_value.FireTabAfterEnter = False
        Me.Numcore_value.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Numcore_value.Image = CType(resources.GetObject("Numcore_value.Image"), System.Drawing.Image)
        Me.Numcore_value.Location = New System.Drawing.Point(230, 299)
        Me.Numcore_value.Maxlength = 10
        Me.Numcore_value.MinusColor = System.Drawing.Color.Empty
        Me.Numcore_value.Name = "Numcore_value"
        Me.Numcore_value.Size = New System.Drawing.Size(102, 22)
        Me.Numcore_value.TabIndex = 18
        Me.Numcore_value.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.Numcore_value.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumCost
        '
        Me.NumCost.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumCost.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumCost.DecimalDigits = 2
        Me.NumCost.DefaultSendValue = False
        Me.NumCost.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumCost.FireTabAfterEnter = False
        Me.NumCost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumCost.Image = CType(resources.GetObject("NumCost.Image"), System.Drawing.Image)
        Me.NumCost.Location = New System.Drawing.Point(110, 75)
        Me.NumCost.Maxlength = 10
        Me.NumCost.MinusColor = System.Drawing.Color.Empty
        Me.NumCost.Name = "NumCost"
        Me.NumCost.Size = New System.Drawing.Size(98, 22)
        Me.NumCost.TabIndex = 2
        Me.NumCost.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumCost.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumFet
        '
        Me.NumFet.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumFet.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumFet.DecimalDigits = 2
        Me.NumFet.DefaultSendValue = False
        Me.NumFet.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumFet.FireTabAfterEnter = False
        Me.NumFet.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumFet.Image = CType(resources.GetObject("NumFet.Image"), System.Drawing.Image)
        Me.NumFet.Location = New System.Drawing.Point(248, 75)
        Me.NumFet.Maxlength = 10
        Me.NumFet.MinusColor = System.Drawing.Color.Empty
        Me.NumFet.Name = "NumFet"
        Me.NumFet.Size = New System.Drawing.Size(77, 22)
        Me.NumFet.TabIndex = 3
        Me.NumFet.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumFet.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPrice
        '
        Me.NumPrice.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPrice.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumPrice.DecimalDigits = 2
        Me.NumPrice.DefaultSendValue = False
        Me.NumPrice.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPrice.FireTabAfterEnter = False
        Me.NumPrice.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPrice.Image = CType(resources.GetObject("NumPrice.Image"), System.Drawing.Image)
        Me.NumPrice.Location = New System.Drawing.Point(398, 76)
        Me.NumPrice.Maxlength = 10
        Me.NumPrice.MinusColor = System.Drawing.Color.Empty
        Me.NumPrice.Name = "NumPrice"
        Me.NumPrice.Size = New System.Drawing.Size(94, 22)
        Me.NumPrice.TabIndex = 4
        Me.NumPrice.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPrice.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumPriceANDFet
        '
        Me.NumPriceANDFet.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.NumPriceANDFet.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumPriceANDFet.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumPriceANDFet.DecimalDigits = 2
        Me.NumPriceANDFet.DefaultSendValue = False
        Me.NumPriceANDFet.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumPriceANDFet.FireTabAfterEnter = False
        Me.NumPriceANDFet.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumPriceANDFet.Image = CType(resources.GetObject("NumPriceANDFet.Image"), System.Drawing.Image)
        Me.NumPriceANDFet.Location = New System.Drawing.Point(398, 108)
        Me.NumPriceANDFet.Maxlength = 10
        Me.NumPriceANDFet.MinusColor = System.Drawing.Color.Empty
        Me.NumPriceANDFet.Name = "NumPriceANDFet"
        Me.NumPriceANDFet.ReadOnly = True
        Me.NumPriceANDFet.Size = New System.Drawing.Size(98, 22)
        Me.NumPriceANDFet.TabIndex = 6
        Me.NumPriceANDFet.TabStop = False
        Me.NumPriceANDFet.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumPriceANDFet.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumMarkup
        '
        Me.NumMarkup.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumMarkup.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.NumMarkup.DecimalDigits = 2
        Me.NumMarkup.DefaultSendValue = False
        Me.NumMarkup.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumMarkup.FireTabAfterEnter = False
        Me.NumMarkup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumMarkup.Image = CType(resources.GetObject("NumMarkup.Image"), System.Drawing.Image)
        Me.NumMarkup.Location = New System.Drawing.Point(110, 108)
        Me.NumMarkup.Maxlength = 6
        Me.NumMarkup.MinusColor = System.Drawing.Color.Empty
        Me.NumMarkup.Name = "NumMarkup"
        Me.NumMarkup.Size = New System.Drawing.Size(98, 22)
        Me.NumMarkup.TabIndex = 5
        Me.NumMarkup.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumMarkup.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Dteinvoice_date
        '
        Me.Dteinvoice_date.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dteinvoice_date.BorderColor = System.Drawing.Color.Empty
        Me.Dteinvoice_date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dteinvoice_date.ButtonBackColor = System.Drawing.Color.Empty
        Me.Dteinvoice_date.ButtonForeColor = System.Drawing.Color.Empty
        Me.Dteinvoice_date.EditableSal = True
        Me.Dteinvoice_date.Image = CType(resources.GetObject("Dteinvoice_date.Image"), System.Drawing.Image)
        Me.Dteinvoice_date.Location = New System.Drawing.Point(110, 216)
        Me.Dteinvoice_date.MaxValue = CType(2500, Short)
        Me.Dteinvoice_date.MinValue = CType(1800, Short)
        Me.Dteinvoice_date.Name = "Dteinvoice_date"
        Me.Dteinvoice_date.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dteinvoice_date.Sal_Mali = Nothing
        Me.Dteinvoice_date.ShowButton = True
        Me.Dteinvoice_date.Size = New System.Drawing.Size(110, 23)
        Me.Dteinvoice_date.TabIndex = 11
        Me.Dteinvoice_date.VisualStyle = False
        '
        'Txtinvoice_no
        '
        Me.Txtinvoice_no.Location = New System.Drawing.Point(110, 164)
        Me.Txtinvoice_no.MaxLength = 20
        Me.Txtinvoice_no.Name = "Txtinvoice_no"
        Me.Txtinvoice_no.Size = New System.Drawing.Size(174, 20)
        Me.Txtinvoice_no.TabIndex = 8
        Me.Txtinvoice_no.Text = ""
        '
        'Vendor_Cod1
        '
        Me.Vendor_Cod1.BackColor = System.Drawing.Color.YellowGreen
        Me.Vendor_Cod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Vendor_Cod1.Connection = Me.Cnn
        Me.Vendor_Cod1.Location = New System.Drawing.Point(110, 138)
        Me.Vendor_Cod1.Name = "Vendor_Cod1"
        Me.Vendor_Cod1.NotExitIfNotFound = False
        Me.Vendor_Cod1.ReleaseIfNotFoundVendorCod = False
        Me.Vendor_Cod1.Size = New System.Drawing.Size(101, 20)
        Me.Vendor_Cod1.TabIndex = 7
        Me.Vendor_Cod1.VendorCod = ""
        Me.Vendor_Cod1.VendorCodLen = 6
        '
        'Dtedue_date
        '
        Me.Dtedue_date.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dtedue_date.BorderColor = System.Drawing.Color.Empty
        Me.Dtedue_date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dtedue_date.ButtonBackColor = System.Drawing.Color.Empty
        Me.Dtedue_date.ButtonForeColor = System.Drawing.Color.Empty
        Me.Dtedue_date.EditableSal = True
        Me.Dtedue_date.Image = CType(resources.GetObject("Dtedue_date.Image"), System.Drawing.Image)
        Me.Dtedue_date.Location = New System.Drawing.Point(110, 239)
        Me.Dtedue_date.MaxValue = CType(2500, Short)
        Me.Dtedue_date.MinValue = CType(1800, Short)
        Me.Dtedue_date.Name = "Dtedue_date"
        Me.Dtedue_date.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dtedue_date.Sal_Mali = Nothing
        Me.Dtedue_date.ShowButton = True
        Me.Dtedue_date.Size = New System.Drawing.Size(110, 23)
        Me.Dtedue_date.TabIndex = 13
        Me.Dtedue_date.VisualStyle = False
        '
        'LblStyle
        '
        Me.LblStyle.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.LblStyle.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.LblStyle.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblStyle.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblStyle.Enabled = False
        Me.LblStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblStyle.IncludeLiterals = False
        Me.LblStyle.Location = New System.Drawing.Point(289, 216)
        Me.LblStyle.MaxLength = 15
        Me.LblStyle.Name = "LblStyle"
        Me.LblStyle.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.LblStyle.ReadOnly = True
        Me.LblStyle.Size = New System.Drawing.Size(157, 22)
        Me.LblStyle.TabIndex = 205
        Me.LblStyle.TabStop = False
        Me.LblStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'LblBrand
        '
        Me.LblBrand.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.LblBrand.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.LblBrand.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblBrand.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblBrand.Enabled = False
        Me.LblBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblBrand.IncludeLiterals = False
        Me.LblBrand.Location = New System.Drawing.Point(289, 239)
        Me.LblBrand.MaxLength = 15
        Me.LblBrand.Name = "LblBrand"
        Me.LblBrand.PromptChar = Microsoft.VisualBasic.ChrW(0)
        Me.LblBrand.ReadOnly = True
        Me.LblBrand.Size = New System.Drawing.Size(158, 22)
        Me.LblBrand.TabIndex = 204
        Me.LblBrand.TabStop = False
        Me.LblBrand.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'CmbLine
        '
        Me.CmbLine.DataSource = Me.DsFrmOutsidePurchase1.inv_tab_line
        Me.CmbLine.DisplayMember = "line"
        Me.CmbLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbLine.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbLine.ItemHeight = 13
        Me.CmbLine.Location = New System.Drawing.Point(289, 191)
        Me.CmbLine.Name = "CmbLine"
        Me.CmbLine.Size = New System.Drawing.Size(208, 21)
        Me.CmbLine.TabIndex = 12
        Me.CmbLine.ValueMember = "line"
        '
        'DsFrmOutsidePurchase1
        '
        Me.DsFrmOutsidePurchase1.DataSetName = "DSFrmOutsidePurchase"
        Me.DsFrmOutsidePurchase1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'DAinv_tab_line
        '
        Me.DAinv_tab_line.SelectCommand = Me.SqlSelectCommand2
        Me.DAinv_tab_line.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_line", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("line", "line"), New System.Data.Common.DataColumnMapping("features", "features"), New System.Data.Common.DataColumnMapping("benefits", "benefits"), New System.Data.Common.DataColumnMapping("treadwear", "treadwear"), New System.Data.Common.DataColumnMapping("traction", "traction"), New System.Data.Common.DataColumnMapping("temperature", "temperature"), New System.Data.Common.DataColumnMapping("limit_warranty", "limit_warranty"), New System.Data.Common.DataColumnMapping("construction", "construction"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("image_remark", "image_remark"), New System.Data.Common.DataColumnMapping("tread_life", "tread_life"), New System.Data.Common.DataColumnMapping("wet_traction", "wet_traction"), New System.Data.Common.DataColumnMapping("quiet_ride", "quiet_ride"), New System.Data.Common.DataColumnMapping("handling", "handling"), New System.Data.Common.DataColumnMapping("winter_traction", "winter_traction"), New System.Data.Common.DataColumnMapping("nud_traction", "nud_traction"), New System.Data.Common.DataColumnMapping("overall_score", "overall_score"), New System.Data.Common.DataColumnMapping("dry_traction", "dry_traction"), New System.Data.Common.DataColumnMapping("ride_comfort", "ride_comfort")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT inv_tab_line.cod_brand, inv_tab_line.style, inv_tab_line.line, inv_tab_sty" & _
        "le.desc_style, inv_tab_brand.complete_desc_brand FROM inv_tab_line INNER JOIN in" & _
        "v_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN inv_t" & _
        "ab_style ON inv_tab_line.style = inv_tab_style.style"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'Txtpo_no
        '
        Me.Txtpo_no.Location = New System.Drawing.Point(377, 165)
        Me.Txtpo_no.MaxLength = 10
        Me.Txtpo_no.Name = "Txtpo_no"
        Me.Txtpo_no.TabIndex = 9
        Me.Txtpo_no.Text = ""
        '
        'Txtpart_no
        '
        Me.Txtpart_no.Location = New System.Drawing.Point(110, 11)
        Me.Txtpart_no.MaxLength = 20
        Me.Txtpart_no.Name = "Txtpart_no"
        Me.Txtpart_no.Size = New System.Drawing.Size(179, 20)
        Me.Txtpart_no.TabIndex = 0
        Me.Txtpart_no.Text = ""
        '
        'TxtDescription
        '
        Me.TxtDescription.Location = New System.Drawing.Point(110, 42)
        Me.TxtDescription.MaxLength = 100
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(381, 20)
        Me.TxtDescription.TabIndex = 1
        Me.TxtDescription.Text = ""
        '
        'LblVendorName
        '
        Me.LblVendorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblVendorName.Location = New System.Drawing.Point(213, 137)
        Me.LblVendorName.Name = "LblVendorName"
        Me.LblVendorName.Size = New System.Drawing.Size(279, 23)
        Me.LblVendorName.TabIndex = 209
        Me.LblVendorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ChkPrepaid
        '
        Me.ChkPrepaid.Location = New System.Drawing.Point(398, 10)
        Me.ChkPrepaid.Name = "ChkPrepaid"
        Me.ChkPrepaid.Size = New System.Drawing.Size(73, 23)
        Me.ChkPrepaid.TabIndex = 210
        Me.ChkPrepaid.Text = "Prepaid"
        '
        'DAGL_TAB_AR_TERM
        '
        Me.DAGL_TAB_AR_TERM.SelectCommand = Me.SqlSelectCommand4
        Me.DAGL_TAB_AR_TERM.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_TAB_AR_TERM", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("AR_terms", "AR_terms"), New System.Data.Common.DataColumnMapping("KIND_AR", "KIND_AR"), New System.Data.Common.DataColumnMapping("ST_NET_DUE_IN", "ST_NET_DUE_IN"), New System.Data.Common.DataColumnMapping("ST_DISCOUNT_PERCENTAGE", "ST_DISCOUNT_PERCENTAGE"), New System.Data.Common.DataColumnMapping("ST_IF_PAY_WITHIN_DAYS", "ST_IF_PAY_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("DD_NET_DUE_BEFORE", "DD_NET_DUE_BEFORE"), New System.Data.Common.DataColumnMapping("DD_IF_ISSUED_WITHIN_DAYS", "DD_IF_ISSUED_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("DD_DISCOUNT_PERCENTAGE", "DD_DISCOUNT_PERCENTAGE"), New System.Data.Common.DataColumnMapping("DD_IF_PAY_WITHIN_DAYS", "DD_IF_PAY_WITHIN_DAYS"), New System.Data.Common.DataColumnMapping("MP_NO_OF_PAYMENT", "MP_NO_OF_PAYMENT"), New System.Data.Common.DataColumnMapping("MP_BEFORE_DAY", "MP_BEFORE_DAY")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT AR_terms FROM GL_TAB_AR_TERM"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'cmbAR_term
        '
        Me.cmbAR_term.DataSource = Me.DsFrmOutsidePurchase1.GL_TAB_AR_TERM
        Me.cmbAR_term.DisplayMember = "AR_terms"
        Me.cmbAR_term.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAR_term.Location = New System.Drawing.Point(110, 190)
        Me.cmbAR_term.Name = "cmbAR_term"
        Me.cmbAR_term.Size = New System.Drawing.Size(125, 21)
        Me.cmbAR_term.TabIndex = 10
        Me.cmbAR_term.ValueMember = "AR_terms"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(51, 190)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 21)
        Me.Label19.TabIndex = 356
        Me.Label19.Text = "AP Terms"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmOutsidePurchase
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(498, 357)
        Me.Controls.Add(Me.cmbAR_term)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.ChkPrepaid)
        Me.Controls.Add(Me.LblVendorName)
        Me.Controls.Add(Me.TxtDescription)
        Me.Controls.Add(Me.Txtpart_no)
        Me.Controls.Add(Me.Txtpo_no)
        Me.Controls.Add(Me.Txtinvoice_no)
        Me.Controls.Add(Me.LblStyle)
        Me.Controls.Add(Me.LblBrand)
        Me.Controls.Add(Me.CmbLine)
        Me.Controls.Add(Me.Dtedue_date)
        Me.Controls.Add(Me.Vendor_Cod1)
        Me.Controls.Add(Me.Dteinvoice_date)
        Me.Controls.Add(Me.NumMarkup)
        Me.Controls.Add(Me.NumPriceANDFet)
        Me.Controls.Add(Me.NumPrice)
        Me.Controls.Add(Me.NumFet)
        Me.Controls.Add(Me.NumCost)
        Me.Controls.Add(Me.Numcore_value)
        Me.Controls.Add(Me.Numin_mile)
        Me.Controls.Add(Me.Numin_day)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Chktracking_core)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Chktracking_warranty)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnCancel)
        Me.Location = New System.Drawing.Point(200, 200)
        Me.Name = "FrmOutsidePurchase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Outside Purchase"
        CType(Me.DsFrmOutsidePurchase1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmOutsidePurchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        DsFrmOutsidePurchase1.Clear()
        DAinv_tab_line.Fill(DsFrmOutsidePurchase1.inv_tab_line)
        Try
            CmbLine.SelectedValue = LineVar
        Catch ex As Exception
        End Try
        DAGL_TAB_AR_TERM.Fill(DsFrmOutsidePurchase1.GL_TAB_AR_TERM)
        Try
            If Trim(ApTermVar & "").Length = 0 Then
                Dim OleDbReaderForServiceSetup As System.Data.OleDb.OleDbDataReader
                OleDbReaderForServiceSetup = RetrieveServiceSetupTable(PubStoreNO)
                ApTermVar = OleDbReaderForServiceSetup.Item("VENDOR_AP_TERM") & ""
                OleDbReaderForServiceSetup.Close()
            End If
            cmbAR_term.SelectedValue = ApTermVar & ""
        Catch ex As Exception
        End Try
        Call EnableDisableField()
        Call EnableDisableBtn()
        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)
        IsCostMandatory = OleDbReaderForStore.Item("RULES11")
        IsInvoiceNoMandatory = OleDbReaderForStore.Item("RULES12")
        OleDbReaderForStore.Close()

        If LblVendorName.Text.Trim.Length = 0 Then
            Vendor_Cod1.Text = ""
        End If
        'If Mid(Dtedue_date.Text, 1, 2).Trim.Length > 0 Then
        '    OleDbReaderForStore = RetrieveAccountsPayableSetupTable()
        '    Dtedue_date.Text = CDate(Dteinvoice_date.Text).Add(OleDbReaderForStore.Item("????"))
        '    OleDbReaderForStore.Close()
        'End If
    End Sub
    Private Sub EnableDisableBtn()
        Select Case ThisFormStatus
            Case MainModule.WorkStates.AddNew, MainModule.WorkStates.Edit
                BtnCancel.Enabled = True
                BtnSave.Enabled = True
            Case MainModule.WorkStates._ReadOnly
                Call DisableAllComponet(Me, False)
                BtnCancel.Enabled = True
        End Select
    End Sub
    Friend Sub DisableAllComponet(ByVal MyForm As Form, Optional ByVal MyStat As Boolean = False)
        Dim i As Integer
        For i = 0 To MyForm.Controls.Count - 1
            MyForm.Controls(i).Enabled = MyStat
        Next i
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        IsOK = False
        Me.Close()
    End Sub
    Private Sub EnableDisableField()
        Numin_day.Enabled = Chktracking_warranty.Checked And TxtDescription.Enabled
        Numin_mile.Enabled = Chktracking_warranty.Checked And TxtDescription.Enabled

        Numcore_value.Enabled = Chktracking_core.Checked And TxtDescription.Enabled
    End Sub
    Private Sub Chktracking_core_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chktracking_core.CheckedChanged, Chktracking_warranty.CheckedChanged
        Call EnableDisableField()
        Call EnableDisableSave()
    End Sub
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If LblVendorName.Text.Trim.Length = 0 Then
            MsgBox("Please enter the Vendor Code. It is required. ")
            Exit Sub
        End If
        If cmbAR_term.Text.Trim.Length = 0 Then
            MsgBox("Please enter the Ap Terms. It is required. ")
            Exit Sub
        End If
        If IsInvoiceNoMandatory And Txtinvoice_no.Text.Trim.Length = 0 And TypeOfForm = "IN" Then
            MsgBox("Please enter the Vendor Invoice for this item. It is required. ")
            Exit Sub
        End If
        'If Mid(Dtedue_date.Text.Trim, 1, 2).Length = 0 Then
        '    MsgBox("Please enter the Due Date. It is required.")
        '    Exit Sub
        'End If
        If IsCostMandatory And NumCost.Numbervalue = 0 And TypeOfForm = "IN" Then
            MsgBox("Please enter the cost of this item. It is required.")
            Exit Sub
        End If
        IsOK = True
        Me.Close()
    End Sub
    Private Sub Txtpart_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtpart_no.TextChanged, TxtDescription.TextChanged, Txtinvoice_no.TextChanged, Txtpo_no.TextChanged, Vendor_Cod1.TextChanged, Numcore_value.TextChanged, Numin_day.TextChanged, Numin_mile.TextChanged, Dtedue_date.TextChanged, ChkPrepaid.CheckedChanged
        Call EnableDisableSave()
    End Sub
    Private Sub cmbAR_term_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAR_term.SelectedIndexChanged, Dteinvoice_date.TextChanged
        Call EnableDisableSave()
        If ThisFormStatus <> MainModule.WorkStates._ReadOnly Then
            Dim Dtedue_dateTempVar As String
            CalcDueDetail(cmbAR_term.SelectedValue, NumCost.Text, Dteinvoice_date.Text, DsFrmOutsidePurchase1.Service_out_purchases_Dtl, True, Dtedue_dateTempVar)
            Dtedue_date.Text = Dtedue_dateTempVar
        End If
    End Sub
    Private Sub numPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumPrice.TextChanged, NumFet.TextChanged
        Call EnableDisableSave()
        Try
            NumPriceANDFet.Text = CDec(NumPrice.Text) + CDec(NumFet.Text)
        Catch ex As Exception
            NumPriceANDFet.Text = 0
        End Try
    End Sub
    Private Sub NumMarkup_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumMarkup.TextChanged, NumCost.TextChanged
        Call EnableDisableSave()
        Try
            NumPrice.Text = Math.Round((CDec(NumCost.Text) * (100 + CDec(NumMarkup.Text))) / 100, 2)
            NumPriceANDFet.Text = CDec(NumPrice.Text) + CDec(NumFet.Text)
        Catch ex As Exception
            NumPriceANDFet.Text = 0
        End Try
    End Sub
    Private Sub EnableDisableSave()
        If Txtpart_no.Text.Trim.Length > 0 And TxtDescription.Text.Trim.Length > 0 And TxtDescription.Enabled = True Then
            BtnSave.Enabled = True
        Else
            BtnSave.Enabled = False
        End If
    End Sub
    Private Sub Vendor_Cod1_FindVendorCod() Handles Vendor_Cod1.FindVendorCod
        LblVendorName.Text = Vendor_Cod1.Desc_Vendor
        If cmbAR_term.Text.Trim.Length = 0 Or OldVandorCod <> Vendor_Cod1.cod_vendor Then
            OldVandorCod = Vendor_Cod1.cod_vendor
            cmbAR_term.SelectedValue = Vendor_Cod1.Ap_terms & ""
        End If
    End Sub
    Private Sub Vendor_Cod1_NotFindVendorCod() Handles Vendor_Cod1.NotFindVendorCod
        LblVendorName.Text = ""
    End Sub
    Private Sub CmbLine_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbLine.SelectedIndexChanged
        Call EnableDisableSave()
        FndBrandAndStyle()
    End Sub
    Sub FndBrandAndStyle()
        Dim dr As DataRow
        Try
            dr = DsFrmOutsidePurchase1.inv_tab_line.FindByline(CmbLine.SelectedValue)
            LblBrand.Text = dr("complete_desc_brand") & ""
            LblStyle.Text = dr("desc_style") & ""
        Catch ex As Exception
            LblBrand.Text = ""
            LblStyle.Text = ""
        End Try
    End Sub
    Private Sub ChkPrepaid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDescription.KeyUp, Txtinvoice_no.KeyUp, Txtpart_no.KeyUp, Txtpo_no.KeyUp, NumMarkup.KeyUp, ChkPrepaid.KeyUp, Vendor_Cod1.KeyUp, cmbAR_term.KeyUp, cmbAR_term.KeyUp, CmbLine.KeyUp, Chktracking_core.KeyUp, Chktracking_warranty.KeyUp, Numcore_value.KeyUp, NumCost.KeyUp, NumFet.KeyUp, Numin_day.KeyUp, Numin_mile.KeyUp, NumMarkup.KeyUp, NumPrice.KeyUp, NumPriceANDFet.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
End Class
