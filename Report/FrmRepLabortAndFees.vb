Imports CommonClass
Public Class FrmRepLabortAndFees
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
    Friend WithEvents PanelLBSS As System.Windows.Forms.GroupBox
    Friend WithEvents PanelBrand As System.Windows.Forms.Panel
    Friend WithEvents PanelLine As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents PanelDate As System.Windows.Forms.GroupBox
    Friend WithEvents PanelDetail As System.Windows.Forms.Panel
    Friend WithEvents RdoSummery As System.Windows.Forms.RadioButton
    Friend WithEvents RdoDetail As System.Windows.Forms.RadioButton
    Friend WithEvents PanelInnerDate As System.Windows.Forms.Panel
    Friend WithEvents CalendarCombo1 As CalendarCombo.CalendarCombo
    Friend WithEvents CalendarCombo2 As CalendarCombo.CalendarCombo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChkDate As System.Windows.Forms.CheckBox
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_tab_service_type As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_tab_service_category As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DAinv_tab_labor_service As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmbServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents RdoSelectedServices As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllServices As System.Windows.Forms.RadioButton
    Friend WithEvents RdoSelectedCategories As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllCategories As System.Windows.Forms.RadioButton
    Friend WithEvents BtnCategories As System.Windows.Forms.Button
    Friend WithEvents BtnServices As System.Windows.Forms.Button
    Friend WithEvents DsFrmRepLabortAndFees1 As Report.DSFrmRepLabortAndFees
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmRepLabortAndFees))
        Me.PanelLBSS = New System.Windows.Forms.GroupBox
        Me.CmbServiceType = New System.Windows.Forms.ComboBox
        Me.DsFrmRepLabortAndFees1 = New Report.DSFrmRepLabortAndFees
        Me.PanelDetail = New System.Windows.Forms.Panel
        Me.RdoSummery = New System.Windows.Forms.RadioButton
        Me.RdoDetail = New System.Windows.Forms.RadioButton
        Me.PanelBrand = New System.Windows.Forms.Panel
        Me.BtnCategories = New System.Windows.Forms.Button
        Me.RdoSelectedCategories = New System.Windows.Forms.RadioButton
        Me.RdoAllCategories = New System.Windows.Forms.RadioButton
        Me.PanelLine = New System.Windows.Forms.Panel
        Me.BtnServices = New System.Windows.Forms.Button
        Me.RdoSelectedServices = New System.Windows.Forms.RadioButton
        Me.RdoAllServices = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnOk = New System.Windows.Forms.Button
        Me.PanelDate = New System.Windows.Forms.GroupBox
        Me.PanelInnerDate = New System.Windows.Forms.Panel
        Me.CalendarCombo1 = New CalendarCombo.CalendarCombo
        Me.CalendarCombo2 = New CalendarCombo.CalendarCombo
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ChkDate = New System.Windows.Forms.CheckBox
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_service_type = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_service_category = New System.Data.SqlClient.SqlDataAdapter
        Me.DAinv_tab_labor_service = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.PanelLBSS.SuspendLayout()
        CType(Me.DsFrmRepLabortAndFees1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDetail.SuspendLayout()
        Me.PanelBrand.SuspendLayout()
        Me.PanelLine.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelDate.SuspendLayout()
        Me.PanelInnerDate.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLBSS
        '
        Me.PanelLBSS.Controls.Add(Me.CmbServiceType)
        Me.PanelLBSS.Controls.Add(Me.PanelDetail)
        Me.PanelLBSS.Controls.Add(Me.PanelBrand)
        Me.PanelLBSS.Controls.Add(Me.PanelLine)
        Me.PanelLBSS.Controls.Add(Me.Label4)
        Me.PanelLBSS.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLBSS.Location = New System.Drawing.Point(0, 88)
        Me.PanelLBSS.Name = "PanelLBSS"
        Me.PanelLBSS.Size = New System.Drawing.Size(510, 160)
        Me.PanelLBSS.TabIndex = 7
        Me.PanelLBSS.TabStop = False
        '
        'CmbServiceType
        '
        Me.CmbServiceType.DataSource = Me.DsFrmRepLabortAndFees1.inv_tab_service_type
        Me.CmbServiceType.DisplayMember = "Name"
        Me.CmbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbServiceType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbServiceType.ItemHeight = 13
        Me.CmbServiceType.Location = New System.Drawing.Point(85, 18)
        Me.CmbServiceType.Name = "CmbServiceType"
        Me.CmbServiceType.Size = New System.Drawing.Size(199, 21)
        Me.CmbServiceType.TabIndex = 1
        Me.CmbServiceType.ValueMember = "code"
        '
        'DsFrmRepLabortAndFees1
        '
        Me.DsFrmRepLabortAndFees1.DataSetName = "DSFrmRepLabortAndFees"
        Me.DsFrmRepLabortAndFees1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'PanelDetail
        '
        Me.PanelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDetail.Controls.Add(Me.RdoSummery)
        Me.PanelDetail.Controls.Add(Me.RdoDetail)
        Me.PanelDetail.Location = New System.Drawing.Point(416, 16)
        Me.PanelDetail.Name = "PanelDetail"
        Me.PanelDetail.Size = New System.Drawing.Size(80, 64)
        Me.PanelDetail.TabIndex = 9
        '
        'RdoSummery
        '
        Me.RdoSummery.Location = New System.Drawing.Point(8, 32)
        Me.RdoSummery.Name = "RdoSummery"
        Me.RdoSummery.Size = New System.Drawing.Size(72, 24)
        Me.RdoSummery.TabIndex = 1
        Me.RdoSummery.Text = "Summary"
        '
        'RdoDetail
        '
        Me.RdoDetail.Checked = True
        Me.RdoDetail.Location = New System.Drawing.Point(8, 8)
        Me.RdoDetail.Name = "RdoDetail"
        Me.RdoDetail.Size = New System.Drawing.Size(72, 24)
        Me.RdoDetail.TabIndex = 0
        Me.RdoDetail.TabStop = True
        Me.RdoDetail.Text = "Detail"
        '
        'PanelBrand
        '
        Me.PanelBrand.Controls.Add(Me.BtnCategories)
        Me.PanelBrand.Controls.Add(Me.RdoSelectedCategories)
        Me.PanelBrand.Controls.Add(Me.RdoAllCategories)
        Me.PanelBrand.Location = New System.Drawing.Point(16, 114)
        Me.PanelBrand.Name = "PanelBrand"
        Me.PanelBrand.Size = New System.Drawing.Size(392, 24)
        Me.PanelBrand.TabIndex = 6
        '
        'BtnCategories
        '
        Me.BtnCategories.Enabled = False
        Me.BtnCategories.Location = New System.Drawing.Point(304, 0)
        Me.BtnCategories.Name = "BtnCategories"
        Me.BtnCategories.TabIndex = 3
        Me.BtnCategories.Text = "Choose..."
        '
        'RdoSelectedCategories
        '
        Me.RdoSelectedCategories.Location = New System.Drawing.Point(136, 0)
        Me.RdoSelectedCategories.Name = "RdoSelectedCategories"
        Me.RdoSelectedCategories.Size = New System.Drawing.Size(153, 24)
        Me.RdoSelectedCategories.TabIndex = 1
        Me.RdoSelectedCategories.Text = "Selected Categories"
        '
        'RdoAllCategories
        '
        Me.RdoAllCategories.Checked = True
        Me.RdoAllCategories.Location = New System.Drawing.Point(0, 0)
        Me.RdoAllCategories.Name = "RdoAllCategories"
        Me.RdoAllCategories.Size = New System.Drawing.Size(145, 24)
        Me.RdoAllCategories.TabIndex = 0
        Me.RdoAllCategories.TabStop = True
        Me.RdoAllCategories.Text = "All Categories"
        '
        'PanelLine
        '
        Me.PanelLine.Controls.Add(Me.BtnServices)
        Me.PanelLine.Controls.Add(Me.RdoSelectedServices)
        Me.PanelLine.Controls.Add(Me.RdoAllServices)
        Me.PanelLine.Location = New System.Drawing.Point(16, 63)
        Me.PanelLine.Name = "PanelLine"
        Me.PanelLine.Size = New System.Drawing.Size(392, 24)
        Me.PanelLine.TabIndex = 5
        '
        'BtnServices
        '
        Me.BtnServices.Enabled = False
        Me.BtnServices.Location = New System.Drawing.Point(304, 0)
        Me.BtnServices.Name = "BtnServices"
        Me.BtnServices.TabIndex = 2
        Me.BtnServices.Text = "Choose..."
        '
        'RdoSelectedServices
        '
        Me.RdoSelectedServices.Location = New System.Drawing.Point(136, 0)
        Me.RdoSelectedServices.Name = "RdoSelectedServices"
        Me.RdoSelectedServices.Size = New System.Drawing.Size(144, 24)
        Me.RdoSelectedServices.TabIndex = 1
        Me.RdoSelectedServices.Text = "Selected Services/Fees"
        '
        'RdoAllServices
        '
        Me.RdoAllServices.Checked = True
        Me.RdoAllServices.Location = New System.Drawing.Point(0, 0)
        Me.RdoAllServices.Name = "RdoAllServices"
        Me.RdoAllServices.Size = New System.Drawing.Size(123, 24)
        Me.RdoAllServices.TabIndex = 0
        Me.RdoAllServices.TabStop = True
        Me.RdoAllServices.Text = "All Services/Fees"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "For Type"
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
        Me.Panel4.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Location = New System.Drawing.Point(64, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(240, 46)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Select a date range and any desired options followed by OK  to print the report"
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
        Me.PictureBox2.Size = New System.Drawing.Size(64, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 190
        Me.PictureBox2.TabStop = False
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARYAFAR;packet size=4096;user id=sa;data source=aryafar;persist se" & _
        "curity info=False;initial catalog=TireMate_04"
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Location = New System.Drawing.Point(280, 256)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.TabIndex = 10
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnOk
        '
        Me.BtnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnOk.Location = New System.Drawing.Point(136, 256)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.TabIndex = 9
        Me.BtnOk.Text = "OK"
        '
        'PanelDate
        '
        Me.PanelDate.Controls.Add(Me.PanelInnerDate)
        Me.PanelDate.Controls.Add(Me.ChkDate)
        Me.PanelDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDate.Location = New System.Drawing.Point(0, 48)
        Me.PanelDate.Name = "PanelDate"
        Me.PanelDate.Size = New System.Drawing.Size(510, 40)
        Me.PanelDate.TabIndex = 11
        Me.PanelDate.TabStop = False
        '
        'PanelInnerDate
        '
        Me.PanelInnerDate.Controls.Add(Me.CalendarCombo1)
        Me.PanelInnerDate.Controls.Add(Me.CalendarCombo2)
        Me.PanelInnerDate.Controls.Add(Me.Label2)
        Me.PanelInnerDate.Controls.Add(Me.Label3)
        Me.PanelInnerDate.Location = New System.Drawing.Point(112, 8)
        Me.PanelInnerDate.Name = "PanelInnerDate"
        Me.PanelInnerDate.Size = New System.Drawing.Size(320, 24)
        Me.PanelInnerDate.TabIndex = 8
        '
        'CalendarCombo1
        '
        Me.CalendarCombo1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CalendarCombo1.BorderColor = System.Drawing.Color.Empty
        Me.CalendarCombo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CalendarCombo1.ButtonBackColor = System.Drawing.Color.Empty
        Me.CalendarCombo1.ButtonForeColor = System.Drawing.Color.Empty
        Me.CalendarCombo1.EditableSal = True
        Me.CalendarCombo1.Image = CType(resources.GetObject("CalendarCombo1.Image"), System.Drawing.Image)
        Me.CalendarCombo1.Location = New System.Drawing.Point(48, 0)
        Me.CalendarCombo1.MaxValue = CType(2500, Short)
        Me.CalendarCombo1.MinValue = CType(1800, Short)
        Me.CalendarCombo1.Name = "CalendarCombo1"
        Me.CalendarCombo1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CalendarCombo1.Sal_Mali = Nothing
        Me.CalendarCombo1.ShowButton = True
        Me.CalendarCombo1.Size = New System.Drawing.Size(110, 23)
        Me.CalendarCombo1.TabIndex = 3
        Me.CalendarCombo1.VisualStyle = False
        '
        'CalendarCombo2
        '
        Me.CalendarCombo2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CalendarCombo2.BorderColor = System.Drawing.Color.Empty
        Me.CalendarCombo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CalendarCombo2.ButtonBackColor = System.Drawing.Color.Empty
        Me.CalendarCombo2.ButtonForeColor = System.Drawing.Color.Empty
        Me.CalendarCombo2.EditableSal = True
        Me.CalendarCombo2.Image = CType(resources.GetObject("CalendarCombo2.Image"), System.Drawing.Image)
        Me.CalendarCombo2.Location = New System.Drawing.Point(192, 0)
        Me.CalendarCombo2.MaxValue = CType(2500, Short)
        Me.CalendarCombo2.MinValue = CType(1800, Short)
        Me.CalendarCombo2.Name = "CalendarCombo2"
        Me.CalendarCombo2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CalendarCombo2.Sal_Mali = Nothing
        Me.CalendarCombo2.ShowButton = True
        Me.CalendarCombo2.Size = New System.Drawing.Size(110, 23)
        Me.CalendarCombo2.TabIndex = 4
        Me.CalendarCombo2.VisualStyle = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "From"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(170, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "To"
        '
        'ChkDate
        '
        Me.ChkDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkDate.ForeColor = System.Drawing.Color.Black
        Me.ChkDate.Location = New System.Drawing.Point(16, 8)
        Me.ChkDate.Name = "ChkDate"
        Me.ChkDate.Size = New System.Drawing.Size(72, 24)
        Me.ChkDate.TabIndex = 7
        Me.ChkDate.Text = "All Dates"
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT service_type AS Code, service_type_desc AS Name, 0 AS Flag FROM inv_tab_se" & _
        "rvice_type"
        Me.SqlSelectCommand7.Connection = Me.Cnn
        '
        'DAinv_tab_service_type
        '
        Me.DAinv_tab_service_type.SelectCommand = Me.SqlSelectCommand7
        Me.DAinv_tab_service_type.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_service_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("service_type", "service_type"), New System.Data.Common.DataColumnMapping("service_type_desc", "service_type_desc"), New System.Data.Common.DataColumnMapping("asset_GL_account", "asset_GL_account"), New System.Data.Common.DataColumnMapping("cost_goods_GL_account", "cost_goods_GL_account"), New System.Data.Common.DataColumnMapping("income_GL_account", "income_GL_account"), New System.Data.Common.DataColumnMapping("return_GL_account", "return_GL_account")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT service_category AS Code, desc_srvice_category AS Name, 0 AS Flag FROM inv" & _
        "_tab_service_category"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAinv_tab_service_category
        '
        Me.DAinv_tab_service_category.SelectCommand = Me.SqlSelectCommand1
        Me.DAinv_tab_service_category.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_service_category", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("service_category", "service_category"), New System.Data.Common.DataColumnMapping("desc_srvice_category", "desc_srvice_category")})})
        '
        'DAinv_tab_labor_service
        '
        Me.DAinv_tab_labor_service.SelectCommand = Me.SqlSelectCommand2
        Me.DAinv_tab_labor_service.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_labor_service", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_service", "cod_service"), New System.Data.Common.DataColumnMapping("desc_service", "desc_service"), New System.Data.Common.DataColumnMapping("ext_desc", "ext_desc"), New System.Data.Common.DataColumnMapping("service_type", "service_type"), New System.Data.Common.DataColumnMapping("service_category", "service_category"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("use_cost", "use_cost"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("require_technician", "require_technician"), New System.Data.Common.DataColumnMapping("charge_shop_supply", "charge_shop_supply"), New System.Data.Common.DataColumnMapping("schedule", "schedule"), New System.Data.Common.DataColumnMapping("avg_time", "avg_time"), New System.Data.Common.DataColumnMapping("use_avg_time", "use_avg_time"), New System.Data.Common.DataColumnMapping("bay_no", "bay_no"), New System.Data.Common.DataColumnMapping("use_bay_no", "use_bay_no"), New System.Data.Common.DataColumnMapping("reminder", "reminder"), New System.Data.Common.DataColumnMapping("miles", "miles"), New System.Data.Common.DataColumnMapping("days", "days"), New System.Data.Common.DataColumnMapping("type_b_t_d_v_r", "type_b_t_d_v_r")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cod_service AS Code, desc_service AS Name, 0 AS Flag FROM inv_tab_labor_se" & _
        "rvice"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'FrmRepLabortAndFees
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(510, 284)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.PanelLBSS)
        Me.Controls.Add(Me.PanelDate)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmRepLabortAndFees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelLBSS.ResumeLayout(False)
        CType(Me.DsFrmRepLabortAndFees1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDetail.ResumeLayout(False)
        Me.PanelBrand.ResumeLayout(False)
        Me.PanelLine.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.PanelDate.ResumeLayout(False)
        Me.PanelInnerDate.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim StrType As String
    Dim StrServicesAndFees As String
    Dim StrCategories As String
    Dim MTypeOfForm As KindForm
    Dim ComName As String = SystemInformation.ComputerName
    Dim FromToDate As String = ""
    Public Enum KindForm As Integer
        Sales = 1
        'Recieve = 2
        List = 2
    End Enum
    Public Property TypeOfForm() As String
        Get
            Return MTypeOfForm
        End Get
        Set(ByVal Value As String)
            MTypeOfForm = Value
        End Set
    End Property

    Private Sub FrmRepInvItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString

        DAinv_tab_service_type.Fill(DsFrmRepLabortAndFees1.inv_tab_service_type)
        CmbServiceType.SelectedValue = "0"
        CalendarCombo1.Text = "01/01/" & PSalMali
        CalendarCombo2.Text = "12/28/" & PSalMali

        Call FillFormText()
    End Sub
    Private Sub ChkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDate.CheckedChanged
        If ChkDate.Checked Then
            PanelInnerDate.Enabled = False
        Else
            PanelInnerDate.Enabled = True
        End If
    End Sub
    Private Sub RdoAllServices_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllServices.CheckedChanged
        If RdoAllServices.Checked Then
            BtnServices.Enabled = False
        Else
            BtnServices.Enabled = True
        End If
    End Sub
    Private Sub RdoAllCategories_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllCategories.CheckedChanged
        If RdoAllCategories.Checked Then
            BtnCategories.Enabled = False
        Else
            BtnCategories.Enabled = True
        End If
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    'Private Sub CmbServiceType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbServiceType.SelectedIndexChanged
    '    DsFrmRepLabortAndFees1.Services.Clear()
    'End Sub
    Private Sub BtnServices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnServices.Click
        BtnServices.Enabled = False
        Dim f As New FrmSelectServices
        If DsFrmRepLabortAndFees1.Services.Count = 0 Then
            DsFrmRepLabortAndFees1.Services.Clear()
            DAinv_tab_labor_service.Fill(DsFrmRepLabortAndFees1.Services)
        End If
        f.Text = "  Select Services/Fees"
        f.DSITEM = DsFrmRepLabortAndFees1
        f.TypeOfForm = f.KindForm.Services
        f.ShowDialog()
        BtnServices.Enabled = True
    End Sub
    Private Sub BtnCategories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCategories.Click
        BtnCategories.Enabled = False
        Dim f As New FrmSelectServices
        If DsFrmRepLabortAndFees1.Categories.Count = 0 Then
            DsFrmRepLabortAndFees1.Categories.Clear()
            DAinv_tab_service_category.Fill(DsFrmRepLabortAndFees1.Categories)
        End If
        f.TypeOfForm = f.KindForm.Categories
        f.Text = "  Select Categories"
        f.DSITEM = DsFrmRepLabortAndFees1
        f.ShowDialog()

        BtnCategories.Enabled = True
    End Sub
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        FromToDate = "From : " & CalendarCombo1.Text & " To : " & CalendarCombo2.Text

        If ControlSelect() Then
            Dim f As New FrmPrintLaborAndFees
            f.StrWhere = ""
            f.StrFilter = ""
            If CmbServiceType.Text.Trim.Length > 0 Then
                f.StrWhere = f.StrWhere & " (" & StrType & ") and "
                f.StrFilter = f.StrFilter & "Type, "
            End If
            If Not (RdoAllServices.Checked) Then
                f.StrWhere = f.StrWhere & " (" & StrServicesAndFees & ") and "
                f.StrFilter = f.StrFilter & "Item, "
            End If
            If RdoSelectedCategories.Checked Then
                f.StrWhere = f.StrWhere & " (" & StrCategories & ") and "
                f.StrFilter = f.StrFilter & "Line,"
            End If
            If f.StrWhere.Trim.Length > 0 Then f.StrWhere = Mid(f.StrWhere, 1, f.StrWhere.Length - 4)
            If f.StrFilter.Trim.Length > 0 Then f.StrFilter = Mid(f.StrFilter, 1, f.StrFilter.Length - 2)
            If ChkDate.Checked Then
                f.Date1 = ""
                f.Date2 = ""
                f.FlagDate = False
            Else
                f.Date1 = ChangeDateToYYYYMMDD(CalendarCombo1.Text)
                f.Date2 = ChangeDateToYYYYMMDD(CalendarCombo2.Text)
                f.FlagDate = True
            End If
            Select Case MTypeOfForm
                Case KindForm.Sales
                    If RdoDetail.Checked Then
                        f.TypeForm = FrmPrintLaborAndFees.KindForm.SalesDetail
                        f.Text = Me.Text & " In Detail "
                    Else
                        f.TypeForm = FrmPrintLaborAndFees.KindForm.Salesummery
                        f.Text = Me.Text & " In Summary "
                    End If
                Case KindForm.List

                    f.TypeForm = FrmPrintLaborAndFees.KindForm.List
                    f.Text = Me.Text & " In Detail "
                    f.Text = Me.Text
            End Select
            f.ServiceType = CmbServiceType.SelectedValue
            f.ServiceTypeName = CmbServiceType.Text
            f.fromtodate = FromToDate
            f.ShowDialog()

            If RdoSelectedCategories.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Categories_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If

            If RdoSelectedServices.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Services_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If
        End If

    End Sub
    Private Function ControlSelect() As Boolean
        ControlSelect = True
        StrCategories = ""
        StrType = ""
        StrServicesAndFees = ""

        If CmbServiceType.Text.Trim.Length = 0 Then
            StrType = ""
        Else
            StrType = " inv_tab_labor_service.service_type = " & Qt(CmbServiceType.SelectedValue)
        End If
        Dim i As Integer
        ''''' Services And Fees
        If RdoSelectedServices.Checked Then
            If DsFrmRepLabortAndFees1.Services.Select(" flag = 1 ").Length > 0 Then
                Try
                    CmdGeneral.CommandText = " create table Services_" & ComName & "(cod_service char(6))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Services_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try

                For i = 0 To DsFrmRepLabortAndFees1.Services.Count - 1
                    If DsFrmRepLabortAndFees1.Services(i).flag Then
                        CmdGeneral.CommandText = " INSERT INTO Services_" & ComName & " (cod_service) VALUES (" & Qt(DsFrmRepLabortAndFees1.Services(i).code) & ") "
                        CmdGeneral.ExecuteNonQuery()
                    End If
                Next
                StrServicesAndFees = " inv_tab_labor_service.cod_service  in (select cod_service from Services_" & ComName & ") "
            Else
                ControlSelect = False
                MsgFar("First Select Services/Fees that you want")
                Exit Function
            End If
        End If
        '''''''Categories
        If RdoSelectedCategories.Checked Then
            StrCategories = ""
            If DsFrmRepLabortAndFees1.Categories.Select(" flag = 1 ").Length > 0 Then
                Try
                    CmdGeneral.CommandText = " create table Categories_" & ComName & "(service_category char(2))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Categories_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DsFrmRepLabortAndFees1.Categories.Count - 1
                    If DsFrmRepLabortAndFees1.Categories(i).flag Then
                        CmdGeneral.CommandText = " INSERT INTO Categories_" & ComName & " (service_category ) VALUES (" & Qt(DsFrmRepLabortAndFees1.Categories(i).code) & ") "
                        CmdGeneral.ExecuteNonQuery()
                    End If
                Next
                StrCategories = " inv_tab_labor_service.service_category in (select service_category from Categories_" & ComName & ") "
            Else
                ControlSelect = False
                MsgFar("First Select Categories that you want")
                Exit Function
            End If
        End If
        '''''''''date
        If Not ChkDate.Checked Then
            If ChangeDateToYYYYMMDD(CalendarCombo1.Text) > ChangeDateToYYYYMMDD(CalendarCombo2.Text) Then
                ControlSelect = False
                MsgBox("First Date Must Be Leaster Than Second Time")
                Exit Function
            End If
            If CalendarCombo1.Text = "" Or CalendarCombo2.Text = "" Then
                ControlSelect = False
                MsgBox("First select Date")
                Exit Function
            End If
        End If

    End Function
    Private Sub FillFormText()
        Select Case MTypeOfForm
            Case KindForm.Sales
                Me.Text = "    Services And Fees Sales Report "
            Case KindForm.List
                Me.Text = "    Services And Fees Listing Report "
                ChkDate.Checked = True
                PanelDate.Visible = False
                PanelDetail.Visible = False
        End Select

    End Sub

End Class
