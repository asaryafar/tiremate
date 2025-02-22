Imports CommonClass
Public Class FrmShowPriceLevels
    Inherits CommonClass.FrmBase
    Public Item_NoVar As String
    Dim WithEvents MyclsItemno As Clsitem_no
    Public PriceCodevar As String
    Public CostVar As Decimal = 0
    Public ListPriceVar As Decimal = 0
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
    Friend WithEvents TxtAmount_price6 As CalcUtils.UcCalcText
    Friend WithEvents TxtAmount_price5 As CalcUtils.UcCalcText
    Friend WithEvents TxtAmount_price4 As CalcUtils.UcCalcText
    Friend WithEvents TxtAmount_price3 As CalcUtils.UcCalcText
    Friend WithEvents TxtAmount_price2 As CalcUtils.UcCalcText
    Friend WithEvents TxtAmount_price1 As CalcUtils.UcCalcText
    Friend WithEvents LblPriceLevel6 As System.Windows.Forms.Label
    Friend WithEvents LblPriceLevel5 As System.Windows.Forms.Label
    Friend WithEvents LblPriceLevel4 As System.Windows.Forms.Label
    Friend WithEvents LblPriceLevel3 As System.Windows.Forms.Label
    Friend WithEvents LblPriceLevel2 As System.Windows.Forms.Label
    Friend WithEvents LblPriceLevel1 As System.Windows.Forms.Label
    Friend WithEvents BtnExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmShowPriceLevels))
        Me.TxtAmount_price6 = New CalcUtils.UcCalcText
        Me.TxtAmount_price5 = New CalcUtils.UcCalcText
        Me.TxtAmount_price4 = New CalcUtils.UcCalcText
        Me.TxtAmount_price3 = New CalcUtils.UcCalcText
        Me.TxtAmount_price2 = New CalcUtils.UcCalcText
        Me.TxtAmount_price1 = New CalcUtils.UcCalcText
        Me.LblPriceLevel6 = New System.Windows.Forms.Label
        Me.LblPriceLevel5 = New System.Windows.Forms.Label
        Me.LblPriceLevel4 = New System.Windows.Forms.Label
        Me.LblPriceLevel3 = New System.Windows.Forms.Label
        Me.LblPriceLevel2 = New System.Windows.Forms.Label
        Me.LblPriceLevel1 = New System.Windows.Forms.Label
        Me.BtnExit = New Janus.Windows.EditControls.UIButton
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SuspendLayout()
        '
        'TxtAmount_price6
        '
        Me.TxtAmount_price6.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtAmount_price6.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtAmount_price6.DecimalDigits = 2
        Me.TxtAmount_price6.DefaultSendValue = False
        Me.TxtAmount_price6.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtAmount_price6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtAmount_price6.Image = CType(resources.GetObject("TxtAmount_price6.Image"), System.Drawing.Image)
        Me.TxtAmount_price6.Location = New System.Drawing.Point(74, 143)
        Me.TxtAmount_price6.Maxlength = 10
        Me.TxtAmount_price6.MinusColor = System.Drawing.Color.Empty
        Me.TxtAmount_price6.Name = "TxtAmount_price6"
        Me.TxtAmount_price6.Size = New System.Drawing.Size(97, 22)
        Me.TxtAmount_price6.TabIndex = 430
        Me.TxtAmount_price6.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtAmount_price6.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtAmount_price5
        '
        Me.TxtAmount_price5.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtAmount_price5.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtAmount_price5.DecimalDigits = 2
        Me.TxtAmount_price5.DefaultSendValue = False
        Me.TxtAmount_price5.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtAmount_price5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtAmount_price5.Image = CType(resources.GetObject("TxtAmount_price5.Image"), System.Drawing.Image)
        Me.TxtAmount_price5.Location = New System.Drawing.Point(74, 115)
        Me.TxtAmount_price5.Maxlength = 10
        Me.TxtAmount_price5.MinusColor = System.Drawing.Color.Empty
        Me.TxtAmount_price5.Name = "TxtAmount_price5"
        Me.TxtAmount_price5.Size = New System.Drawing.Size(97, 22)
        Me.TxtAmount_price5.TabIndex = 429
        Me.TxtAmount_price5.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtAmount_price5.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtAmount_price4
        '
        Me.TxtAmount_price4.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtAmount_price4.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtAmount_price4.DecimalDigits = 2
        Me.TxtAmount_price4.DefaultSendValue = False
        Me.TxtAmount_price4.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtAmount_price4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtAmount_price4.Image = CType(resources.GetObject("TxtAmount_price4.Image"), System.Drawing.Image)
        Me.TxtAmount_price4.Location = New System.Drawing.Point(74, 87)
        Me.TxtAmount_price4.Maxlength = 10
        Me.TxtAmount_price4.MinusColor = System.Drawing.Color.Empty
        Me.TxtAmount_price4.Name = "TxtAmount_price4"
        Me.TxtAmount_price4.Size = New System.Drawing.Size(97, 22)
        Me.TxtAmount_price4.TabIndex = 428
        Me.TxtAmount_price4.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtAmount_price4.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtAmount_price3
        '
        Me.TxtAmount_price3.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtAmount_price3.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtAmount_price3.DecimalDigits = 2
        Me.TxtAmount_price3.DefaultSendValue = False
        Me.TxtAmount_price3.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtAmount_price3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtAmount_price3.Image = CType(resources.GetObject("TxtAmount_price3.Image"), System.Drawing.Image)
        Me.TxtAmount_price3.Location = New System.Drawing.Point(74, 59)
        Me.TxtAmount_price3.Maxlength = 10
        Me.TxtAmount_price3.MinusColor = System.Drawing.Color.Empty
        Me.TxtAmount_price3.Name = "TxtAmount_price3"
        Me.TxtAmount_price3.Size = New System.Drawing.Size(97, 22)
        Me.TxtAmount_price3.TabIndex = 427
        Me.TxtAmount_price3.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtAmount_price3.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtAmount_price2
        '
        Me.TxtAmount_price2.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtAmount_price2.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtAmount_price2.DecimalDigits = 2
        Me.TxtAmount_price2.DefaultSendValue = False
        Me.TxtAmount_price2.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtAmount_price2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtAmount_price2.Image = CType(resources.GetObject("TxtAmount_price2.Image"), System.Drawing.Image)
        Me.TxtAmount_price2.Location = New System.Drawing.Point(74, 31)
        Me.TxtAmount_price2.Maxlength = 10
        Me.TxtAmount_price2.MinusColor = System.Drawing.Color.Empty
        Me.TxtAmount_price2.Name = "TxtAmount_price2"
        Me.TxtAmount_price2.Size = New System.Drawing.Size(97, 22)
        Me.TxtAmount_price2.TabIndex = 426
        Me.TxtAmount_price2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtAmount_price2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtAmount_price1
        '
        Me.TxtAmount_price1.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtAmount_price1.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtAmount_price1.DecimalDigits = 2
        Me.TxtAmount_price1.DefaultSendValue = False
        Me.TxtAmount_price1.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtAmount_price1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtAmount_price1.Image = CType(resources.GetObject("TxtAmount_price1.Image"), System.Drawing.Image)
        Me.TxtAmount_price1.Location = New System.Drawing.Point(74, 3)
        Me.TxtAmount_price1.Maxlength = 10
        Me.TxtAmount_price1.MinusColor = System.Drawing.Color.Empty
        Me.TxtAmount_price1.Name = "TxtAmount_price1"
        Me.TxtAmount_price1.Size = New System.Drawing.Size(97, 22)
        Me.TxtAmount_price1.TabIndex = 425
        Me.TxtAmount_price1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtAmount_price1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblPriceLevel6
        '
        Me.LblPriceLevel6.BackColor = System.Drawing.Color.Salmon
        Me.LblPriceLevel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblPriceLevel6.ForeColor = System.Drawing.Color.Yellow
        Me.LblPriceLevel6.Location = New System.Drawing.Point(3, 143)
        Me.LblPriceLevel6.Name = "LblPriceLevel6"
        Me.LblPriceLevel6.Size = New System.Drawing.Size(70, 22)
        Me.LblPriceLevel6.TabIndex = 436
        Me.LblPriceLevel6.Text = "Price Level 6"
        Me.LblPriceLevel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPriceLevel5
        '
        Me.LblPriceLevel5.BackColor = System.Drawing.Color.Salmon
        Me.LblPriceLevel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblPriceLevel5.ForeColor = System.Drawing.Color.Yellow
        Me.LblPriceLevel5.Location = New System.Drawing.Point(3, 115)
        Me.LblPriceLevel5.Name = "LblPriceLevel5"
        Me.LblPriceLevel5.Size = New System.Drawing.Size(70, 22)
        Me.LblPriceLevel5.TabIndex = 435
        Me.LblPriceLevel5.Text = "Price Level 5"
        Me.LblPriceLevel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPriceLevel4
        '
        Me.LblPriceLevel4.BackColor = System.Drawing.Color.Salmon
        Me.LblPriceLevel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblPriceLevel4.ForeColor = System.Drawing.Color.Yellow
        Me.LblPriceLevel4.Location = New System.Drawing.Point(3, 87)
        Me.LblPriceLevel4.Name = "LblPriceLevel4"
        Me.LblPriceLevel4.Size = New System.Drawing.Size(70, 22)
        Me.LblPriceLevel4.TabIndex = 434
        Me.LblPriceLevel4.Text = "Price Level 4"
        Me.LblPriceLevel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPriceLevel3
        '
        Me.LblPriceLevel3.BackColor = System.Drawing.Color.Salmon
        Me.LblPriceLevel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblPriceLevel3.ForeColor = System.Drawing.Color.Yellow
        Me.LblPriceLevel3.Location = New System.Drawing.Point(3, 59)
        Me.LblPriceLevel3.Name = "LblPriceLevel3"
        Me.LblPriceLevel3.Size = New System.Drawing.Size(70, 22)
        Me.LblPriceLevel3.TabIndex = 433
        Me.LblPriceLevel3.Text = "Price Level 3"
        Me.LblPriceLevel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPriceLevel2
        '
        Me.LblPriceLevel2.BackColor = System.Drawing.Color.Salmon
        Me.LblPriceLevel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblPriceLevel2.ForeColor = System.Drawing.Color.Yellow
        Me.LblPriceLevel2.Location = New System.Drawing.Point(3, 31)
        Me.LblPriceLevel2.Name = "LblPriceLevel2"
        Me.LblPriceLevel2.Size = New System.Drawing.Size(70, 22)
        Me.LblPriceLevel2.TabIndex = 432
        Me.LblPriceLevel2.Text = "Price Level 2"
        Me.LblPriceLevel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblPriceLevel1
        '
        Me.LblPriceLevel1.BackColor = System.Drawing.Color.Salmon
        Me.LblPriceLevel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblPriceLevel1.ForeColor = System.Drawing.Color.Yellow
        Me.LblPriceLevel1.Location = New System.Drawing.Point(3, 3)
        Me.LblPriceLevel1.Name = "LblPriceLevel1"
        Me.LblPriceLevel1.Size = New System.Drawing.Size(70, 22)
        Me.LblPriceLevel1.TabIndex = 431
        Me.LblPriceLevel1.Text = "Price Level 1"
        Me.LblPriceLevel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(3, 168)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(166, 23)
        Me.BtnExit.TabIndex = 437
        Me.BtnExit.Text = "OK"
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'FrmShowPriceLevels
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(173, 194)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.TxtAmount_price6)
        Me.Controls.Add(Me.TxtAmount_price5)
        Me.Controls.Add(Me.TxtAmount_price4)
        Me.Controls.Add(Me.TxtAmount_price3)
        Me.Controls.Add(Me.TxtAmount_price2)
        Me.Controls.Add(Me.TxtAmount_price1)
        Me.Controls.Add(Me.LblPriceLevel6)
        Me.Controls.Add(Me.LblPriceLevel5)
        Me.Controls.Add(Me.LblPriceLevel4)
        Me.Controls.Add(Me.LblPriceLevel3)
        Me.Controls.Add(Me.LblPriceLevel2)
        Me.Controls.Add(Me.LblPriceLevel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(200, 300)
        Me.Name = "FrmShowPriceLevels"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FrmShowPriceLevels"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmShowPriceLevels_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        MyclsItemno = New Clsitem_no
        MyclsItemno.Connection = Me.Cnn

        LblPriceLevel1.Text = PriceLevelsLabels(1)
        LblPriceLevel2.Text = PriceLevelsLabels(2)
        LblPriceLevel3.Text = PriceLevelsLabels(3)
        LblPriceLevel4.Text = PriceLevelsLabels(4)
        LblPriceLevel5.Text = PriceLevelsLabels(5)
        LblPriceLevel6.Text = PriceLevelsLabels(6)
        Try
            TxtAmount_price1.Text = MyclsItemno.CalculatePriceCode(PriceCodevar, 1, CostVar, ListPriceVar)
            TxtAmount_price2.Text = MyclsItemno.CalculatePriceCode(PriceCodevar, 2, CostVar, ListPriceVar)
            TxtAmount_price3.Text = MyclsItemno.CalculatePriceCode(PriceCodevar, 3, CostVar, ListPriceVar)
            TxtAmount_price4.Text = MyclsItemno.CalculatePriceCode(PriceCodevar, 4, CostVar, ListPriceVar)
            TxtAmount_price5.Text = MyclsItemno.CalculatePriceCode(PriceCodevar, 5, CostVar, ListPriceVar)
            TxtAmount_price6.Text = MyclsItemno.CalculatePriceCode(PriceCodevar, 6, CostVar, ListPriceVar)
        Catch ex As Exception
            TxtAmount_price1.Text = 0
            TxtAmount_price2.Text = 0
            TxtAmount_price3.Text = 0
            TxtAmount_price4.Text = 0
            TxtAmount_price5.Text = 0
            TxtAmount_price6.Text = 0
        End Try
    End Sub
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class
