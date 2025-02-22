Imports CommonClass
Public Class FrmThankCard
    Inherits CommonClass.FrmBase

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
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtSpent2 As CalcUtils.UcCalcText
    Friend WithEvents Rdo2 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtToDate As CalendarCombo.CalendarCombo
    Friend WithEvents TxtFromDate As CalendarCombo.CalendarCombo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtSpent1 As CalcUtils.UcCalcText
    Friend WithEvents Rdo1 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnEmail As System.Windows.Forms.Button
    Friend WithEvents BtnFax As System.Windows.Forms.Button
    Friend WithEvents BtnPriv As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents TxtDateRem As CalendarCombo.CalendarCombo
    Friend WithEvents CmbText As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DATextReport As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsFrmThankCard1 As ReportBank.DSFrmThankCard
    Friend WithEvents DAinv_tab_labor_service As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAPrint As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TxtSinceTo As CalendarCombo.CalendarCombo
    Friend WithEvents TxtSinceFrom As CalendarCombo.CalendarCombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmThankCard))
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.CmbText = New System.Windows.Forms.ComboBox
        Me.DsFrmThankCard1 = New ReportBank.DSFrmThankCard
        Me.TxtDateRem = New CalendarCombo.CalendarCombo
        Me.Label15 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TxtSinceTo = New CalendarCombo.CalendarCombo
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtSinceFrom = New CalendarCombo.CalendarCombo
        Me.TxtSpent2 = New CalcUtils.UcCalcText
        Me.Rdo2 = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtToDate = New CalendarCombo.CalendarCombo
        Me.TxtFromDate = New CalendarCombo.CalendarCombo
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtSpent1 = New CalcUtils.UcCalcText
        Me.Rdo1 = New System.Windows.Forms.RadioButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.BtnEmail = New System.Windows.Forms.Button
        Me.BtnFax = New System.Windows.Forms.Button
        Me.BtnPriv = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.DATextReport = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAinv_tab_labor_service = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAPrint = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Panel3.SuspendLayout()
        CType(Me.DsFrmThankCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.CmbText)
        Me.Panel3.Controls.Add(Me.TxtDateRem)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 264)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(510, 69)
        Me.Panel3.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(236, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Select Note"
        '
        'CmbText
        '
        Me.CmbText.DataSource = Me.DsFrmThankCard1.TextReport
        Me.CmbText.DisplayMember = "Description"
        Me.CmbText.Location = New System.Drawing.Point(305, 18)
        Me.CmbText.Name = "CmbText"
        Me.CmbText.Size = New System.Drawing.Size(121, 21)
        Me.CmbText.TabIndex = 10
        Me.CmbText.ValueMember = "Code"
        '
        'DsFrmThankCard1
        '
        Me.DsFrmThankCard1.DataSetName = "DSFrmThankCard"
        Me.DsFrmThankCard1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'TxtDateRem
        '
        Me.TxtDateRem.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtDateRem.BorderColor = System.Drawing.Color.Empty
        Me.TxtDateRem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtDateRem.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtDateRem.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtDateRem.EditableSal = True
        Me.TxtDateRem.Image = CType(resources.GetObject("TxtDateRem.Image"), System.Drawing.Image)
        Me.TxtDateRem.Location = New System.Drawing.Point(80, 16)
        Me.TxtDateRem.MaxValue = CType(2500, Short)
        Me.TxtDateRem.MinValue = CType(1800, Short)
        Me.TxtDateRem.Name = "TxtDateRem"
        Me.TxtDateRem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtDateRem.Sal_Mali = Nothing
        Me.TxtDateRem.ShowButton = True
        Me.TxtDateRem.Size = New System.Drawing.Size(110, 23)
        Me.TxtDateRem.TabIndex = 8
        Me.TxtDateRem.VisualStyle = False
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(16, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 16)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Card Date"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TxtSinceTo)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.TxtSinceFrom)
        Me.Panel2.Controls.Add(Me.TxtSpent2)
        Me.Panel2.Controls.Add(Me.Rdo2)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 144)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(510, 120)
        Me.Panel2.TabIndex = 18
        '
        'TxtSinceTo
        '
        Me.TxtSinceTo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtSinceTo.BorderColor = System.Drawing.Color.Empty
        Me.TxtSinceTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtSinceTo.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtSinceTo.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtSinceTo.EditableSal = True
        Me.TxtSinceTo.Image = CType(resources.GetObject("TxtSinceTo.Image"), System.Drawing.Image)
        Me.TxtSinceTo.Location = New System.Drawing.Point(224, 32)
        Me.TxtSinceTo.MaxValue = CType(2500, Short)
        Me.TxtSinceTo.MinValue = CType(1800, Short)
        Me.TxtSinceTo.Name = "TxtSinceTo"
        Me.TxtSinceTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtSinceTo.Sal_Mali = Nothing
        Me.TxtSinceTo.ShowButton = True
        Me.TxtSinceTo.Size = New System.Drawing.Size(110, 23)
        Me.TxtSinceTo.TabIndex = 15
        Me.TxtSinceTo.VisualStyle = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(280, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "$"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(88, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Customers Since :"
        '
        'TxtSinceFrom
        '
        Me.TxtSinceFrom.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtSinceFrom.BorderColor = System.Drawing.Color.Empty
        Me.TxtSinceFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtSinceFrom.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtSinceFrom.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtSinceFrom.EditableSal = True
        Me.TxtSinceFrom.Image = CType(resources.GetObject("TxtSinceFrom.Image"), System.Drawing.Image)
        Me.TxtSinceFrom.Location = New System.Drawing.Point(80, 32)
        Me.TxtSinceFrom.MaxValue = CType(2500, Short)
        Me.TxtSinceFrom.MinValue = CType(1800, Short)
        Me.TxtSinceFrom.Name = "TxtSinceFrom"
        Me.TxtSinceFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtSinceFrom.Sal_Mali = Nothing
        Me.TxtSinceFrom.ShowButton = True
        Me.TxtSinceFrom.Size = New System.Drawing.Size(110, 23)
        Me.TxtSinceFrom.TabIndex = 9
        Me.TxtSinceFrom.VisualStyle = False
        '
        'TxtSpent2
        '
        Me.TxtSpent2.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtSpent2.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtSpent2.DecimalDigits = 0
        Me.TxtSpent2.DefaultSendValue = False
        Me.TxtSpent2.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtSpent2.FireTabAfterEnter = True
        Me.TxtSpent2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtSpent2.Image = CType(resources.GetObject("TxtSpent2.Image"), System.Drawing.Image)
        Me.TxtSpent2.Location = New System.Drawing.Point(224, 72)
        Me.TxtSpent2.Maxlength = 30
        Me.TxtSpent2.MinusColor = System.Drawing.Color.Empty
        Me.TxtSpent2.Name = "TxtSpent2"
        Me.TxtSpent2.Size = New System.Drawing.Size(56, 22)
        Me.TxtSpent2.TabIndex = 12
        Me.TxtSpent2.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtSpent2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Rdo2
        '
        Me.Rdo2.Location = New System.Drawing.Point(416, 56)
        Me.Rdo2.Name = "Rdo2"
        Me.Rdo2.Size = New System.Drawing.Size(24, 24)
        Me.Rdo2.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(112, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Who spent more than"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtToDate)
        Me.Panel1.Controls.Add(Me.TxtFromDate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtSpent1)
        Me.Panel1.Controls.Add(Me.Rdo1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(510, 96)
        Me.Panel1.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(280, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "$"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(96, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Who spent more than"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(80, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Customers whose last visit was :"
        '
        'TxtToDate
        '
        Me.TxtToDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtToDate.BorderColor = System.Drawing.Color.Empty
        Me.TxtToDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtToDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtToDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtToDate.EditableSal = True
        Me.TxtToDate.Image = CType(resources.GetObject("TxtToDate.Image"), System.Drawing.Image)
        Me.TxtToDate.Location = New System.Drawing.Point(224, 32)
        Me.TxtToDate.MaxValue = CType(2500, Short)
        Me.TxtToDate.MinValue = CType(1800, Short)
        Me.TxtToDate.Name = "TxtToDate"
        Me.TxtToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtToDate.Sal_Mali = Nothing
        Me.TxtToDate.ShowButton = True
        Me.TxtToDate.Size = New System.Drawing.Size(110, 23)
        Me.TxtToDate.TabIndex = 9
        Me.TxtToDate.VisualStyle = False
        '
        'TxtFromDate
        '
        Me.TxtFromDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtFromDate.BorderColor = System.Drawing.Color.Empty
        Me.TxtFromDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtFromDate.ButtonBackColor = System.Drawing.Color.Empty
        Me.TxtFromDate.ButtonForeColor = System.Drawing.Color.Empty
        Me.TxtFromDate.EditableSal = True
        Me.TxtFromDate.Image = CType(resources.GetObject("TxtFromDate.Image"), System.Drawing.Image)
        Me.TxtFromDate.Location = New System.Drawing.Point(80, 32)
        Me.TxtFromDate.MaxValue = CType(2500, Short)
        Me.TxtFromDate.MinValue = CType(1800, Short)
        Me.TxtFromDate.Name = "TxtFromDate"
        Me.TxtFromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtFromDate.Sal_Mali = Nothing
        Me.TxtFromDate.ShowButton = True
        Me.TxtFromDate.Size = New System.Drawing.Size(110, 23)
        Me.TxtFromDate.TabIndex = 8
        Me.TxtFromDate.VisualStyle = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "From"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(192, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "To"
        '
        'TxtSpent1
        '
        Me.TxtSpent1.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtSpent1.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtSpent1.DecimalDigits = 0
        Me.TxtSpent1.DefaultSendValue = False
        Me.TxtSpent1.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtSpent1.FireTabAfterEnter = True
        Me.TxtSpent1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtSpent1.Image = CType(resources.GetObject("TxtSpent1.Image"), System.Drawing.Image)
        Me.TxtSpent1.Location = New System.Drawing.Point(224, 66)
        Me.TxtSpent1.Maxlength = 30
        Me.TxtSpent1.MinusColor = System.Drawing.Color.Empty
        Me.TxtSpent1.Name = "TxtSpent1"
        Me.TxtSpent1.Size = New System.Drawing.Size(56, 22)
        Me.TxtSpent1.TabIndex = 12
        Me.TxtSpent1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtSpent1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Rdo1
        '
        Me.Rdo1.Checked = True
        Me.Rdo1.Location = New System.Drawing.Point(416, 56)
        Me.Rdo1.Name = "Rdo1"
        Me.Rdo1.Size = New System.Drawing.Size(24, 24)
        Me.Rdo1.TabIndex = 6
        Me.Rdo1.TabStop = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(510, 48)
        Me.Panel4.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Location = New System.Drawing.Point(72, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(264, 46)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Select a date range and any desired options followed by OK  to print thank you ca" & _
        "rd"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 190
        Me.PictureBox2.TabStop = False
        '
        'BtnEmail
        '
        Me.BtnEmail.Location = New System.Drawing.Point(312, 368)
        Me.BtnEmail.Name = "BtnEmail"
        Me.BtnEmail.TabIndex = 29
        Me.BtnEmail.Text = "Email"
        '
        'BtnFax
        '
        Me.BtnFax.Location = New System.Drawing.Point(224, 368)
        Me.BtnFax.Name = "BtnFax"
        Me.BtnFax.TabIndex = 28
        Me.BtnFax.Text = "Fax"
        '
        'BtnPriv
        '
        Me.BtnPriv.Location = New System.Drawing.Point(136, 368)
        Me.BtnPriv.Name = "BtnPriv"
        Me.BtnPriv.TabIndex = 27
        Me.BtnPriv.Text = "Preview"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(400, 368)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.TabIndex = 26
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(48, 368)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.TabIndex = 25
        Me.BtnPrint.Text = "Print"
        '
        'DATextReport
        '
        Me.DATextReport.SelectCommand = Me.SqlSelectCommand3
        Me.DATextReport.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TextReport", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Code", "Code"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("WritingText", "WritingText")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Code, Description, WritingText FROM TextReport"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARYAFAR;packet size=4096;user id=sa;data source=aryafar;persist se" & _
        "curity info=False;initial catalog=TireMate_01"
        '
        'DAinv_tab_labor_service
        '
        Me.DAinv_tab_labor_service.SelectCommand = Me.SqlSelectCommand2
        Me.DAinv_tab_labor_service.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_labor_service", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_service", "cod_service"), New System.Data.Common.DataColumnMapping("desc_service", "desc_service"), New System.Data.Common.DataColumnMapping("ext_desc", "ext_desc"), New System.Data.Common.DataColumnMapping("service_type", "service_type"), New System.Data.Common.DataColumnMapping("service_category", "service_category"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("use_cost", "use_cost"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("require_technician", "require_technician"), New System.Data.Common.DataColumnMapping("charge_shop_supply", "charge_shop_supply"), New System.Data.Common.DataColumnMapping("schedule", "schedule"), New System.Data.Common.DataColumnMapping("avg_time", "avg_time"), New System.Data.Common.DataColumnMapping("use_avg_time", "use_avg_time"), New System.Data.Common.DataColumnMapping("bay_no", "bay_no"), New System.Data.Common.DataColumnMapping("use_bay_no", "use_bay_no"), New System.Data.Common.DataColumnMapping("reminder", "reminder"), New System.Data.Common.DataColumnMapping("miles", "miles"), New System.Data.Common.DataColumnMapping("days", "days"), New System.Data.Common.DataColumnMapping("type_b_t_d_v_r", "type_b_t_d_v_r")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cod_service AS cod, desc_service AS name, days, 0 AS flag FROM inv_tab_lab" & _
        "or_service WHERE (reminder = 1) AND (ISNULL(days, 0) > 0)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAPrint
        '
        Me.DAPrint.SelectCommand = Me.SqlSelectCommand1
        Me.DAPrint.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Total", "Total")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT service_center_head.cod_customer, CASE WHEN ltrim(rtrim(isnull(cust_trtab_" & _
        "main.f_name, ''))) <> '' THEN LTRIM(RTRIM(cust_trtab_main.f_name)) + '  ' + LTRI" & _
        "M(RTRIM(cust_trtab_main.l_name)) ELSE cust_company.complete_name END AS NameCus," & _
        " cust_trtab_main.address, ZipCus.city + '  ' + ZipCus.state + '  ' + ZipCus.zipc" & _
        "ode AS ZipCus, CASE WHEN cust_trtab_main.phone_main_1 = '1' THEN cust_trtab_main" & _
        ".phone_1 WHEN cust_trtab_main.phone_main_2 = '1' THEN cust_trtab_main.phone_2 WH" & _
        "EN cust_trtab_main.phone_main_3 = '1' THEN cust_trtab_main.phone_3 WHEN cust_trt" & _
        "ab_main.phone_main_4 = '1' THEN cust_trtab_main.phone_4 WHEN cust_trtab_main.pho" & _
        "ne_main_5 = '1' THEN cust_trtab_main.phone_5 END AS phone, LTRIM(RTRIM(bas_vehic" & _
        "le_company.desc_make)) + '  ' + LTRIM(RTRIM(bas_vehicle_model.desc_model)) AS Ve" & _
        "hicle, inv_tab_labor_service.desc_service, service_center_head.date_refer, bas_v" & _
        "ehicle.make_year FROM service_center_head INNER JOIN service_center_dtl ON servi" & _
        "ce_center_head.id_service_center = service_center_dtl.id_service_center INNER JO" & _
        "IN inv_tab_labor_service ON service_center_dtl.cod_select = inv_tab_labor_servic" & _
        "e.cod_service AND DATEDIFF(day, CAST(service_center_head.date_refer AS datetime)" & _
        ", CAST('08/20/2009' AS datetime)) > inv_tab_labor_service.days INNER JOIN (SELEC" & _
        "T MAX(dbo.ChangeDate(date_refer)) AS date_refer, cod_customer FROM service_cente" & _
        "r_head GROUP BY cod_customer) Last_Service ON service_center_head.cod_customer =" & _
        " Last_Service.cod_customer AND dbo.ChangeDate(service_center_head.date_refer) = " & _
        "Last_Service.date_refer INNER JOIN cust_trtab_main ON service_center_head.cod_cu" & _
        "stomer = cust_trtab_main.cod_customer INNER JOIN ser_tr_vehicle ON service_cente" & _
        "r_head.id_vehicle = ser_tr_vehicle.id_vehicle AND cust_trtab_main.cod_customer =" & _
        " ser_tr_vehicle.cod_customer INNER JOIN bas_vehicle ON ser_tr_vehicle.cod_vehicl" & _
        "e = bas_vehicle.cod_vehicle INNER JOIN bas_vehicle_company ON bas_vehicle.cod_ma" & _
        "ke = bas_vehicle_company.cod_make INNER JOIN bas_vehicle_model ON bas_vehicle.co" & _
        "d_make = bas_vehicle_model.cod_make AND bas_vehicle.cod_model = bas_vehicle_mode" & _
        "l.cod_model AND bas_vehicle_company.cod_make = bas_vehicle_model.cod_make LEFT O" & _
        "UTER JOIN bas_zipcode ZipCus ON cust_trtab_main.zip = ZipCus.zipcode LEFT OUTER " & _
        "JOIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_company WHER" & _
        "E (dbo.ChangeDate(service_center_head.date_refer) BETWEEN '2006/08/01' AND '2009" & _
        "/08/01') AND (service_center_head.type_of_form = 'IN')"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'FrmThankCard
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(510, 419)
        Me.Controls.Add(Me.BtnEmail)
        Me.Controls.Add(Me.BtnFax)
        Me.Controls.Add(Me.BtnPriv)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmThankCard"
        Me.Text = "Thank You Card"
        Me.Panel3.ResumeLayout(False)
        CType(Me.DsFrmThankCard1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmThankCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        TxtDateRem.Text = Format(Now.Date, PubDateFormat)
        DATextReport.Fill(DsFrmThankCard1.TextReport)

    End Sub

    Private Sub Rdo1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rdo1.CheckedChanged
        If Rdo1.Checked = True Then
            Rdo2.Checked = False
            TxtSinceTo.Enabled = False
            TxtSinceFrom.Enabled = False
            TxtSpent2.Enabled = False
            ''
            TxtFromDate.Enabled = True
            TxtToDate.Enabled = True
            TxtSpent1.Enabled = True
        Else
            Rdo2.Checked = True
            TxtSinceTo.Enabled = True
            TxtSinceFrom.Enabled = True
            TxtSpent2.Enabled = True
            ''
            TxtFromDate.Enabled = False
            TxtToDate.Enabled = False
            TxtSpent1.Enabled = False
        End If
    End Sub

    Private Sub Rdo2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rdo2.CheckedChanged
        If Rdo2.Checked = False Then
            Rdo1.Checked = True
            TxtSinceTo.Enabled = False
            TxtSinceFrom.Enabled = False
            TxtSpent2.Enabled = False
            ''
            TxtFromDate.Enabled = True
            TxtToDate.Enabled = True
            TxtSpent1.Enabled = True
        Else
            Rdo1.Checked = False
            TxtSinceTo.Enabled = True
            TxtSinceFrom.Enabled = True
            TxtSpent2.Enabled = True
            ''
            TxtFromDate.Enabled = False
            TxtToDate.Enabled = False
            TxtSpent1.Enabled = False
        End If
    End Sub
    Private Sub FillDataset()
      

        Dim strSer As String = ""
        Dim i As Integer


        Dim str As String = ""
        If Rdo2.Checked Then
            str = "      (cust_trtab_main.cod_customer IN " & _
"                           (SELECT     service_center_head.cod_customer " & _
"                              FROM         service_center_head INNER JOIN " & _
"                                                        (SELECT     MIN(dbo.ChangeDate(date_refer)) AS date_refer, cod_customer " & _
"                                                           FROM         service_center_head " & _
"                                                           GROUP BY cod_customer) FirstIN ON dbo.ChangeDate(service_center_head.date_refer) = FirstIN.date_refer AND  " & _
"                                                    service_center_head.cod_customer = FirstIN.cod_customer " & _
"                              WHERE     (service_center_head.Total >= " & TxtSpent2.Text & ") AND (FirstIN.date_refer BETWEEN " & Qt(ChangeDateToYYYYMMDD(TxtSinceFrom.Text)) & " AND " & Qt(ChangeDateToYYYYMMDD(TxtSinceTo.Text)) & ") AND  " & _
"                                                    (service_center_head.type_of_form = 'IN'))) "

            'str = " First_Service.date_refer BETWEEN  " & Qt(ChangeDateToYYYYMMDD(TxtSinceFrom.Text)) & " AND " & Qt(ChangeDateToYYYYMMDD(TxtSinceTo.Text)) & " and First_Service.Total >=" & TxtSpent2.Text
        Else
            str = " dbo.ChangeDate(service_center_head.date_refer) BETWEEN  " & Qt(ChangeDateToYYYYMMDD(TxtFromDate.Text)) & " AND " & Qt(ChangeDateToYYYYMMDD(TxtToDate.Text)) & " and service_center_head.Total >=" & TxtSpent1.Text
        End If

        DAPrint.SelectCommand.CommandText = " SELECT     service_center_head.cod_customer, CASE WHEN ltrim(rtrim(isnull(cust_trtab_main.f_name, ''))) <> '' THEN LTRIM(RTRIM(cust_trtab_main.f_name))  " & _
"                       + '  ' + LTRIM(RTRIM(cust_trtab_main.l_name)) ELSE cust_company.complete_name END AS NameCus, isnull(cust_trtab_main.address,'') as address,  " & _
"                       isnull(ZipCus.city,'') + '  ' + isnull(ZipCus.state,'') + '  ' + isnull(ZipCus.zipcode,'') AS ZipCus,  " & _
"                       isnull(CASE WHEN cust_trtab_main.phone_main_1 = '1' THEN cust_trtab_main.phone_1 WHEN cust_trtab_main.phone_main_2 = '1' THEN cust_trtab_main.phone_2 " & _
"                        WHEN cust_trtab_main.phone_main_3 = '1' THEN cust_trtab_main.phone_3 WHEN cust_trtab_main.phone_main_4 = '1' THEN cust_trtab_main.phone_4 " & _
"                        WHEN cust_trtab_main.phone_main_5 = '1' THEN cust_trtab_main.phone_5 END,'') AS phone,  " & _
"                       ltrim(rtrim(isnull(bas_vehicle_company.desc_make,'')))  AS Vehicle, isnull(inv_tab_labor_service.desc_service,'') as desc_service, isnull(service_center_head.date_refer,'') as date_refer, ltrim(rtrim(isnull(bas_vehicle_model.desc_model,''))) as make_year " & _
" FROM         bas_vehicle INNER JOIN " & _
"                       ser_tr_vehicle ON bas_vehicle.cod_vehicle = ser_tr_vehicle.cod_vehicle INNER JOIN " & _
"                       bas_vehicle_company ON bas_vehicle.cod_make = bas_vehicle_company.cod_make INNER JOIN " & _
"                       bas_vehicle_model ON bas_vehicle.cod_make = bas_vehicle_model.cod_make AND bas_vehicle.cod_model = bas_vehicle_model.cod_model AND  " & _
"                       bas_vehicle_company.cod_make = bas_vehicle_model.cod_make RIGHT OUTER JOIN " & _
"                           (SELECT     MAX(dbo.ChangeDate(date_refer)) AS date_refer, cod_customer " & _
"                              FROM         service_center_head " & _
"                              GROUP BY cod_customer) Last_Service INNER JOIN " & _
"                       service_center_head ON Last_Service.cod_customer = service_center_head.cod_customer AND  " & _
"                       Last_Service.date_refer = dbo.ChangeDate(service_center_head.date_refer) LEFT OUTER JOIN " & _
"                       inv_tab_labor_service INNER JOIN " & _
"                       service_center_dtl ON inv_tab_labor_service.cod_service = service_center_dtl.cod_select ON  " & _
"                       service_center_head.id_service_center = service_center_dtl.id_service_center RIGHT OUTER JOIN " & _
"                       cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer ON  " & _
"                       ser_tr_vehicle.id_vehicle = service_center_head.id_vehicle AND ser_tr_vehicle.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " & _
"                       bas_zipcode ZipCus ON cust_trtab_main.zip = ZipCus.zipcode LEFT OUTER JOIN " & _
"                       cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
" WHERE     (" & str & ") AND (service_center_head.type_of_form = 'IN') "


        DsFrmThankCard1.service_center_head.Clear()
        DAPrint.Fill(DsFrmThankCard1.service_center_head)

    End Sub

    Private Sub BtnPriv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPriv.Click
        If ControlBlank() Then
            FillDataset()
            Dim rpt As New RptDynamicRep
            Dim prn As New FrmRepView
            rpt.SetDataSource(DsFrmThankCard1)

            rpt.SetParameterValue("parenter", vbNewLine)
            Dim TxtAsli As String = DsFrmThankCard1.TextReport.FindByCode(CmbText.SelectedValue).WritingText

            TxtAsli = TxtAsli.Replace("!C", """ + {service_center_head.NameCus} + """) 'cus name
            TxtAsli = TxtAsli.Replace("!A", """ + {service_center_head.address} + """) 'address
            TxtAsli = TxtAsli.Replace("!Z", """ + {service_center_head.ZipCus} + """) 'zip code
            TxtAsli = TxtAsli.Replace("!V", """ + {service_center_head.Vehicle} + """) 'vehicle
            TxtAsli = TxtAsli.Replace("!M", """ + {service_center_head.make_year} + """) 'model
            TxtAsli = TxtAsli.Replace("!S", """ + {service_center_head.desc_service} + """)  'service
            TxtAsli = TxtAsli.Replace("!D", """ + {service_center_head.date_refer} + """) 'date service
            TxtAsli = TxtAsli.Replace("!N", """ + """ & FormatDateTime(TxtDateRem.Text, DateFormat.GeneralDate) & """ + """)  'date
            TxtAsli = TxtAsli.Replace(vbNewLine, """ + {?ParEnter} + """)

            TxtAsli = """" & TxtAsli & """"


            rpt.DataDefinition.FormulaFields.Item(0).Text = TxtAsli


            prn.CrViewer.ReportSource = rpt

            prn.ShowDialog()

        End If
       
    End Sub

    Private Sub BtnFax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFax.Click

    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        If ControlBlank() Then
            FillDataset()
            Dim rpt As New RptDynamicRep
            Dim prn As New FrmRepView
            rpt.SetDataSource(DsFrmThankCard1)

            rpt.SetParameterValue("parenter", vbNewLine)
            Dim TxtAsli As String = DsFrmThankCard1.TextReport.FindByCode(CmbText.SelectedValue).WritingText

            TxtAsli = TxtAsli.Replace("!C", """ + {service_center_head.NameCus} + """) 'cus name
            TxtAsli = TxtAsli.Replace("!A", """ + {service_center_head.address} + """) 'address
            TxtAsli = TxtAsli.Replace("!Z", """ + {service_center_head.ZipCus} + """) 'zip code
            TxtAsli = TxtAsli.Replace("!V", """ + {service_center_head.Vehicle} + """) 'vehicle
            TxtAsli = TxtAsli.Replace("!M", """ + {service_center_head.make_year} + """) 'model
            TxtAsli = TxtAsli.Replace("!S", """ + {service_center_head.desc_service} + """)  'service
            TxtAsli = TxtAsli.Replace("!D", """ + {service_center_head.date_refer} + """) 'date service
            TxtAsli = TxtAsli.Replace("!N", """ + """ & FormatDateTime(TxtDateRem.Text, DateFormat.GeneralDate) & """ + """)  'date
            TxtAsli = TxtAsli.Replace(vbNewLine, """ + {?ParEnter} + """)

            TxtAsli = """" & TxtAsli & """"


            rpt.DataDefinition.FormulaFields.Item(0).Text = TxtAsli

            Try
                rpt.PrintToPrinter(1, True, 0, 0)
            Catch ex As Exception

            End Try

        End If
      
    End Sub
    Private Function ControlBlank() As Boolean
        If Rdo1.Checked Then
            If TxtFromDate.Text.Trim.Length = 0 Or TxtToDate.Text.Trim.Length = 0 Or TxtSpent1.Text.Trim.Length = 0 Then
                ControlBlank = False
                Exit Function
            End If
        End If
        If Rdo2.Checked Then
            If TxtSinceFrom.Text.Trim.Length = 0 Or TxtSinceTo.Text.Trim.Length = 0 Or TxtSpent2.Text.Trim.Length = 0 Then
                ControlBlank = False
                Exit Function
            End If
        End If
        If TxtDateRem.Text.Trim.Length = 0 Or CmbText.Text.Trim.Length = 0 Then
            ControlBlank = False
            Exit Function
        End If
        ControlBlank = True
    End Function

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
