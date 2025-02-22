Imports CommonClass
Public Class FrmRepTraffic
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
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents PanelTSCT As System.Windows.Forms.GroupBox
    Friend WithEvents PanelSource As System.Windows.Forms.Panel
    Friend WithEvents BtnSource As System.Windows.Forms.Button
    Friend WithEvents RdoSelectedSource As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllSource As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PanelType As System.Windows.Forms.Panel
    Friend WithEvents BtnType As System.Windows.Forms.Button
    Friend WithEvents RdoSelectedType As System.Windows.Forms.RadioButton
    Friend WithEvents RdoAllType As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents DASource As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAType As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmRepTraffic1 As ReportEmployee.DSFrmRepTraffic
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DAList As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents PanelDateNew As System.Windows.Forms.GroupBox
    Friend WithEvents PanelDateInactive As System.Windows.Forms.GroupBox
    Friend WithEvents CalInactive As CalendarCombo.CalendarCombo
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ChkInactive As System.Windows.Forms.CheckBox
    Friend WithEvents PanelDateFreq As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PanelDateStore As System.Windows.Forms.GroupBox
    Friend WithEvents PanelDetail As System.Windows.Forms.Panel
    Friend WithEvents RdoLabel As System.Windows.Forms.RadioButton
    Friend WithEvents RdoList As System.Windows.Forms.RadioButton
    Friend WithEvents CalFromNew As CalendarCombo.CalendarCombo
    Friend WithEvents CalToNew As CalendarCombo.CalendarCombo
    Friend WithEvents CalFromFreq As CalendarCombo.CalendarCombo
    Friend WithEvents CalToFreq As CalendarCombo.CalendarCombo
    Friend WithEvents TxtNumInvoice As Janus.Windows.GridEX.EditControls.NumericEditBox
    Friend WithEvents TxtSpent As CalcUtils.UcCalcText
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CalFromStore As CalendarCombo.CalendarCombo
    Friend WithEvents CalToStore As CalendarCombo.CalendarCombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmRepTraffic))
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.PanelTSCT = New System.Windows.Forms.GroupBox
        Me.PanelDetail = New System.Windows.Forms.Panel
        Me.RdoLabel = New System.Windows.Forms.RadioButton
        Me.RdoList = New System.Windows.Forms.RadioButton
        Me.PanelSource = New System.Windows.Forms.Panel
        Me.BtnSource = New System.Windows.Forms.Button
        Me.RdoSelectedSource = New System.Windows.Forms.RadioButton
        Me.RdoAllSource = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.PanelType = New System.Windows.Forms.Panel
        Me.BtnType = New System.Windows.Forms.Button
        Me.RdoSelectedType = New System.Windows.Forms.RadioButton
        Me.RdoAllType = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.PanelDateNew = New System.Windows.Forms.GroupBox
        Me.CalFromNew = New CalendarCombo.CalendarCombo
        Me.CalToNew = New CalendarCombo.CalendarCombo
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.BtnOk = New System.Windows.Forms.Button
        Me.DASource = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAType = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DsFrmRepTraffic1 = New ReportEmployee.DSFrmRepTraffic
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.DAList = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.PanelDateInactive = New System.Windows.Forms.GroupBox
        Me.ChkInactive = New System.Windows.Forms.CheckBox
        Me.CalInactive = New CalendarCombo.CalendarCombo
        Me.Label8 = New System.Windows.Forms.Label
        Me.PanelDateFreq = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxtSpent = New CalcUtils.UcCalcText
        Me.TxtNumInvoice = New Janus.Windows.GridEX.EditControls.NumericEditBox
        Me.CalFromFreq = New CalendarCombo.CalendarCombo
        Me.CalToFreq = New CalendarCombo.CalendarCombo
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.PanelDateStore = New System.Windows.Forms.GroupBox
        Me.CalFromStore = New CalendarCombo.CalendarCombo
        Me.CalToStore = New CalendarCombo.CalendarCombo
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.PanelTSCT.SuspendLayout()
        Me.PanelDetail.SuspendLayout()
        Me.PanelSource.SuspendLayout()
        Me.PanelType.SuspendLayout()
        Me.PanelDateNew.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DsFrmRepTraffic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDateInactive.SuspendLayout()
        Me.PanelDateFreq.SuspendLayout()
        Me.PanelDateStore.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(280, 312)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.TabIndex = 15
        Me.BtnCancel.Text = "Cancel"
        '
        'PanelTSCT
        '
        Me.PanelTSCT.Controls.Add(Me.PanelDetail)
        Me.PanelTSCT.Controls.Add(Me.PanelSource)
        Me.PanelTSCT.Controls.Add(Me.PanelType)
        Me.PanelTSCT.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTSCT.Location = New System.Drawing.Point(0, 392)
        Me.PanelTSCT.Name = "PanelTSCT"
        Me.PanelTSCT.Size = New System.Drawing.Size(478, 136)
        Me.PanelTSCT.TabIndex = 14
        Me.PanelTSCT.TabStop = False
        '
        'PanelDetail
        '
        Me.PanelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDetail.Controls.Add(Me.RdoLabel)
        Me.PanelDetail.Controls.Add(Me.RdoList)
        Me.PanelDetail.Location = New System.Drawing.Point(384, 24)
        Me.PanelDetail.Name = "PanelDetail"
        Me.PanelDetail.Size = New System.Drawing.Size(80, 64)
        Me.PanelDetail.TabIndex = 10
        '
        'RdoLabel
        '
        Me.RdoLabel.Location = New System.Drawing.Point(8, 32)
        Me.RdoLabel.Name = "RdoLabel"
        Me.RdoLabel.Size = New System.Drawing.Size(72, 24)
        Me.RdoLabel.TabIndex = 1
        Me.RdoLabel.Text = "Labels"
        '
        'RdoList
        '
        Me.RdoList.Checked = True
        Me.RdoList.Location = New System.Drawing.Point(8, 8)
        Me.RdoList.Name = "RdoList"
        Me.RdoList.Size = New System.Drawing.Size(72, 24)
        Me.RdoList.TabIndex = 0
        Me.RdoList.TabStop = True
        Me.RdoList.Text = "Listing"
        '
        'PanelSource
        '
        Me.PanelSource.Controls.Add(Me.BtnSource)
        Me.PanelSource.Controls.Add(Me.RdoSelectedSource)
        Me.PanelSource.Controls.Add(Me.RdoAllSource)
        Me.PanelSource.Controls.Add(Me.Label6)
        Me.PanelSource.Location = New System.Drawing.Point(22, 64)
        Me.PanelSource.Name = "PanelSource"
        Me.PanelSource.Size = New System.Drawing.Size(354, 40)
        Me.PanelSource.TabIndex = 6
        '
        'BtnSource
        '
        Me.BtnSource.Enabled = False
        Me.BtnSource.Location = New System.Drawing.Point(264, 16)
        Me.BtnSource.Name = "BtnSource"
        Me.BtnSource.TabIndex = 3
        Me.BtnSource.Text = "Choose..."
        '
        'RdoSelectedSource
        '
        Me.RdoSelectedSource.Location = New System.Drawing.Point(128, 16)
        Me.RdoSelectedSource.Name = "RdoSelectedSource"
        Me.RdoSelectedSource.Size = New System.Drawing.Size(112, 24)
        Me.RdoSelectedSource.TabIndex = 1
        Me.RdoSelectedSource.Text = "Selected Sources"
        '
        'RdoAllSource
        '
        Me.RdoAllSource.Checked = True
        Me.RdoAllSource.Location = New System.Drawing.Point(0, 16)
        Me.RdoAllSource.Name = "RdoAllSource"
        Me.RdoAllSource.TabIndex = 0
        Me.RdoAllSource.TabStop = True
        Me.RdoAllSource.Text = "All Sources"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "For Customer Sources"
        '
        'PanelType
        '
        Me.PanelType.Controls.Add(Me.BtnType)
        Me.PanelType.Controls.Add(Me.RdoSelectedType)
        Me.PanelType.Controls.Add(Me.RdoAllType)
        Me.PanelType.Controls.Add(Me.Label5)
        Me.PanelType.Location = New System.Drawing.Point(22, 16)
        Me.PanelType.Name = "PanelType"
        Me.PanelType.Size = New System.Drawing.Size(354, 40)
        Me.PanelType.TabIndex = 5
        '
        'BtnType
        '
        Me.BtnType.Enabled = False
        Me.BtnType.Location = New System.Drawing.Point(264, 16)
        Me.BtnType.Name = "BtnType"
        Me.BtnType.TabIndex = 2
        Me.BtnType.Text = "Choose..."
        '
        'RdoSelectedType
        '
        Me.RdoSelectedType.Location = New System.Drawing.Point(128, 16)
        Me.RdoSelectedType.Name = "RdoSelectedType"
        Me.RdoSelectedType.TabIndex = 1
        Me.RdoSelectedType.Text = "Selected Types"
        '
        'RdoAllType
        '
        Me.RdoAllType.Checked = True
        Me.RdoAllType.Location = New System.Drawing.Point(0, 16)
        Me.RdoAllType.Name = "RdoAllType"
        Me.RdoAllType.TabIndex = 0
        Me.RdoAllType.TabStop = True
        Me.RdoAllType.Text = "All Types"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "For Customer Types"
        '
        'PanelDateNew
        '
        Me.PanelDateNew.Controls.Add(Me.CalFromNew)
        Me.PanelDateNew.Controls.Add(Me.CalToNew)
        Me.PanelDateNew.Controls.Add(Me.Label2)
        Me.PanelDateNew.Controls.Add(Me.Label3)
        Me.PanelDateNew.Controls.Add(Me.Label1)
        Me.PanelDateNew.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDateNew.Location = New System.Drawing.Point(0, 320)
        Me.PanelDateNew.Name = "PanelDateNew"
        Me.PanelDateNew.Size = New System.Drawing.Size(478, 72)
        Me.PanelDateNew.TabIndex = 12
        Me.PanelDateNew.TabStop = False
        '
        'CalFromNew
        '
        Me.CalFromNew.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CalFromNew.BorderColor = System.Drawing.Color.Empty
        Me.CalFromNew.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CalFromNew.ButtonBackColor = System.Drawing.Color.Empty
        Me.CalFromNew.ButtonForeColor = System.Drawing.Color.Empty
        Me.CalFromNew.EditableSal = True
        Me.CalFromNew.Image = CType(resources.GetObject("CalFromNew.Image"), System.Drawing.Image)
        Me.CalFromNew.Location = New System.Drawing.Point(96, 40)
        Me.CalFromNew.MaxValue = CType(2500, Short)
        Me.CalFromNew.MinValue = CType(1800, Short)
        Me.CalFromNew.Name = "CalFromNew"
        Me.CalFromNew.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CalFromNew.Sal_Mali = Nothing
        Me.CalFromNew.ShowButton = True
        Me.CalFromNew.Size = New System.Drawing.Size(110, 23)
        Me.CalFromNew.TabIndex = 3
        Me.CalFromNew.VisualStyle = False
        '
        'CalToNew
        '
        Me.CalToNew.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CalToNew.BorderColor = System.Drawing.Color.Empty
        Me.CalToNew.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CalToNew.ButtonBackColor = System.Drawing.Color.Empty
        Me.CalToNew.ButtonForeColor = System.Drawing.Color.Empty
        Me.CalToNew.EditableSal = True
        Me.CalToNew.Image = CType(resources.GetObject("CalToNew.Image"), System.Drawing.Image)
        Me.CalToNew.Location = New System.Drawing.Point(240, 40)
        Me.CalToNew.MaxValue = CType(2500, Short)
        Me.CalToNew.MinValue = CType(1800, Short)
        Me.CalToNew.Name = "CalToNew"
        Me.CalToNew.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CalToNew.Sal_Mali = Nothing
        Me.CalToNew.ShowButton = True
        Me.CalToNew.Size = New System.Drawing.Size(110, 23)
        Me.CalToNew.TabIndex = 4
        Me.CalToNew.VisualStyle = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(64, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "From"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(216, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "To"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(40, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "New Customers"
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
        Me.Panel4.Size = New System.Drawing.Size(478, 48)
        Me.Panel4.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Location = New System.Drawing.Point(64, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(262, 46)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Select the Customer That you want to print"
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
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(128, 312)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.TabIndex = 13
        Me.BtnOk.Text = "OK"
        '
        'DASource
        '
        Me.DASource.SelectCommand = Me.SqlSelectCommand4
        Me.DASource.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_tab_source", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_source", "cod_source"), New System.Data.Common.DataColumnMapping("desc_source", "desc_source")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT cod_source AS cod, desc_source AS name, 0 AS flag FROM cust_tab_source"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARYAFAR;packet size=4096;user id=sa;data source=aryafar;persist se" & _
        "curity info=False;initial catalog=TireMate_01"
        '
        'DAType
        '
        Me.DAType.SelectCommand = Me.SqlSelectCommand3
        Me.DAType.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_tab_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_type", "cod_type"), New System.Data.Common.DataColumnMapping("desc_type", "desc_type")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT cod_type AS cod, desc_type AS name, 0 AS flag FROM cust_tab_type"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DsFrmRepTraffic1
        '
        Me.DsFrmRepTraffic1.DataSetName = "DSFrmRepTraffic"
        Me.DsFrmRepTraffic1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'DAList
        '
        Me.DAList.SelectCommand = Me.SqlCommand1
        Me.DAList.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_trtab_main", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("vip_code", "vip_code"), New System.Data.Common.DataColumnMapping("cod_company", "cod_company"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("driver_name1", "driver_name1"), New System.Data.Common.DataColumnMapping("driver_name2", "driver_name2"), New System.Data.Common.DataColumnMapping("driver_name3", "driver_name3"), New System.Data.Common.DataColumnMapping("driver_name4", "driver_name4"), New System.Data.Common.DataColumnMapping("DriverLicense", "DriverLicense"), New System.Data.Common.DataColumnMapping("zip", "zip"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("cod_sales_rep", "cod_sales_rep"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cust_exempt_tax", "cust_exempt_tax"), New System.Data.Common.DataColumnMapping("scrap_check", "scrap_check"), New System.Data.Common.DataColumnMapping("scrap_value", "scrap_value"), New System.Data.Common.DataColumnMapping("credit_card_no", "credit_card_no"), New System.Data.Common.DataColumnMapping("expiration_credit_date", "expiration_credit_date"), New System.Data.Common.DataColumnMapping("credit_limited", "credit_limited"), New System.Data.Common.DataColumnMapping("AR_charge", "AR_charge"), New System.Data.Common.DataColumnMapping("AR_term", "AR_term"), New System.Data.Common.DataColumnMapping("cod_sales_tax", "cod_sales_tax"), New System.Data.Common.DataColumnMapping("cod_price", "cod_price"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("cod_type", "cod_type"), New System.Data.Common.DataColumnMapping("cod_source", "cod_source"), New System.Data.Common.DataColumnMapping("cod_class", "cod_class"), New System.Data.Common.DataColumnMapping("cod_territory", "cod_territory"), New System.Data.Common.DataColumnMapping("desc_sales_report", "desc_sales_report"), New System.Data.Common.DataColumnMapping("user_id", "user_id"), New System.Data.Common.DataColumnMapping("user_password", "user_password"), New System.Data.Common.DataColumnMapping("AR_statement", "AR_statement"), New System.Data.Common.DataColumnMapping("AR_send_copy", "AR_send_copy"), New System.Data.Common.DataColumnMapping("AR_finance_charge", "AR_finance_charge"), New System.Data.Common.DataColumnMapping("AR_require_PO", "AR_require_PO"), New System.Data.Common.DataColumnMapping("AR_credit_hold", "AR_credit_hold"), New System.Data.Common.DataColumnMapping("AR_accept_check", "AR_accept_check"), New System.Data.Common.DataColumnMapping("cust_notes", "cust_notes"), New System.Data.Common.DataColumnMapping("Taxable", "Taxable"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("customer_no", "customer_no")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT cust_trtab_main.cod_customer AS customer_no, cust_trtab_main.f_name + ' ' " & _
        "+ cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name, cust_company.co" & _
        "mplete_name, bas_zipcode.city, cust_trtab_main.zip, CASE WHEN phone_main_1 = 1 T" & _
        "HEN phone_1 WHEN phone_main_2 = 1 THEN phone_2 WHEN phone_main_3 = 1 THEN phone_" & _
        "3 WHEN phone_main_4 = 1 THEN phone_4 WHEN phone_main_5 = 1 THEN phone_5 END AS p" & _
        "hone_1, Since.CustSince, last.LastVisit, cust_tab_type.desc_type, cust_tab_sourc" & _
        "e.desc_source, cust_tab_class.desc_class, cust_tab_territory.desc_territory, 1 A" & _
        "S flag FROM cust_trtab_main LEFT OUTER JOIN cust_tab_class ON cust_trtab_main.co" & _
        "d_class = cust_tab_class.cod_class LEFT OUTER JOIN bas_zipcode ON cust_trtab_mai" & _
        "n.zip = bas_zipcode.zipcode LEFT OUTER JOIN cust_tab_territory ON cust_trtab_mai" & _
        "n.cod_territory = cust_tab_territory.cod_territory LEFT OUTER JOIN cust_tab_sour" & _
        "ce ON cust_trtab_main.cod_source = cust_tab_source.cod_source LEFT OUTER JOIN cu" & _
        "st_tab_type ON cust_trtab_main.cod_type = cust_tab_type.cod_type LEFT OUTER JOIN" & _
        " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company LEFT OUT" & _
        "ER JOIN (SELECT MAX(Date_Refer) AS LastVisit, service_center_head.cod_customer F" & _
        "ROM service_center_head WHERE type_of_form = 'IN' GROUP BY service_center_head.c" & _
        "od_customer) last ON cust_trtab_main.cod_customer = last.cod_customer LEFT OUTER" & _
        " JOIN (SELECT MAX(Date_Refer) AS CustSince, service_center_head.cod_customer FRO" & _
        "M service_center_head WHERE type_of_form = 'IN' GROUP BY service_center_head.cod" & _
        "_customer) Since ON cust_trtab_main.cod_customer = Since.cod_customer"
        Me.SqlCommand1.Connection = Me.Cnn
        '
        'PanelDateInactive
        '
        Me.PanelDateInactive.Controls.Add(Me.ChkInactive)
        Me.PanelDateInactive.Controls.Add(Me.CalInactive)
        Me.PanelDateInactive.Controls.Add(Me.Label8)
        Me.PanelDateInactive.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDateInactive.Location = New System.Drawing.Point(0, 248)
        Me.PanelDateInactive.Name = "PanelDateInactive"
        Me.PanelDateInactive.Size = New System.Drawing.Size(478, 72)
        Me.PanelDateInactive.TabIndex = 16
        Me.PanelDateInactive.TabStop = False
        '
        'ChkInactive
        '
        Me.ChkInactive.Location = New System.Drawing.Point(40, 40)
        Me.ChkInactive.Name = "ChkInactive"
        Me.ChkInactive.Size = New System.Drawing.Size(296, 24)
        Me.ChkInactive.TabIndex = 8
        Me.ChkInactive.Text = "Include customers with no date of last visit"
        '
        'CalInactive
        '
        Me.CalInactive.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CalInactive.BorderColor = System.Drawing.Color.Empty
        Me.CalInactive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CalInactive.ButtonBackColor = System.Drawing.Color.Empty
        Me.CalInactive.ButtonForeColor = System.Drawing.Color.Empty
        Me.CalInactive.EditableSal = True
        Me.CalInactive.Image = CType(resources.GetObject("CalInactive.Image"), System.Drawing.Image)
        Me.CalInactive.Location = New System.Drawing.Point(224, 16)
        Me.CalInactive.MaxValue = CType(2500, Short)
        Me.CalInactive.MinValue = CType(1800, Short)
        Me.CalInactive.Name = "CalInactive"
        Me.CalInactive.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CalInactive.Sal_Mali = Nothing
        Me.CalInactive.ShowButton = True
        Me.CalInactive.Size = New System.Drawing.Size(110, 23)
        Me.CalInactive.TabIndex = 3
        Me.CalInactive.VisualStyle = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(40, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(240, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Customer who have not been in store since "
        '
        'PanelDateFreq
        '
        Me.PanelDateFreq.Controls.Add(Me.Label15)
        Me.PanelDateFreq.Controls.Add(Me.Label14)
        Me.PanelDateFreq.Controls.Add(Me.TxtSpent)
        Me.PanelDateFreq.Controls.Add(Me.TxtNumInvoice)
        Me.PanelDateFreq.Controls.Add(Me.CalFromFreq)
        Me.PanelDateFreq.Controls.Add(Me.CalToFreq)
        Me.PanelDateFreq.Controls.Add(Me.Label4)
        Me.PanelDateFreq.Controls.Add(Me.Label7)
        Me.PanelDateFreq.Controls.Add(Me.Label13)
        Me.PanelDateFreq.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDateFreq.Location = New System.Drawing.Point(0, 144)
        Me.PanelDateFreq.Name = "PanelDateFreq"
        Me.PanelDateFreq.Size = New System.Drawing.Size(478, 104)
        Me.PanelDateFreq.TabIndex = 17
        Me.PanelDateFreq.TabStop = False
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(40, 72)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(240, 22)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Customers who spent more than This amount"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(40, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(240, 20)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Customers with number of invoices more than "
        '
        'TxtSpent
        '
        Me.TxtSpent.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtSpent.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtSpent.DecimalDigits = 2
        Me.TxtSpent.DefaultSendValue = False
        Me.TxtSpent.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtSpent.FireTabAfterEnter = True
        Me.TxtSpent.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtSpent.ForeColor = System.Drawing.Color.Black
        Me.TxtSpent.Image = CType(resources.GetObject("TxtSpent.Image"), System.Drawing.Image)
        Me.TxtSpent.Location = New System.Drawing.Point(296, 72)
        Me.TxtSpent.Maxlength = 10
        Me.TxtSpent.MinusColor = System.Drawing.Color.Empty
        Me.TxtSpent.Name = "TxtSpent"
        Me.TxtSpent.Size = New System.Drawing.Size(110, 22)
        Me.TxtSpent.TabIndex = 11
        Me.TxtSpent.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtSpent.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtNumInvoice
        '
        Me.TxtNumInvoice.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.TxtNumInvoice.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.TxtNumInvoice.ButtonFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtNumInvoice.DecimalDigits = 0
        Me.TxtNumInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtNumInvoice.Location = New System.Drawing.Point(296, 48)
        Me.TxtNumInvoice.MaxLength = 4
        Me.TxtNumInvoice.Name = "TxtNumInvoice"
        Me.TxtNumInvoice.Size = New System.Drawing.Size(110, 20)
        Me.TxtNumInvoice.TabIndex = 9
        Me.TxtNumInvoice.Text = "0"
        Me.TxtNumInvoice.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        Me.TxtNumInvoice.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'CalFromFreq
        '
        Me.CalFromFreq.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CalFromFreq.BorderColor = System.Drawing.Color.Empty
        Me.CalFromFreq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CalFromFreq.ButtonBackColor = System.Drawing.Color.Empty
        Me.CalFromFreq.ButtonForeColor = System.Drawing.Color.Empty
        Me.CalFromFreq.EditableSal = True
        Me.CalFromFreq.Image = CType(resources.GetObject("CalFromFreq.Image"), System.Drawing.Image)
        Me.CalFromFreq.Location = New System.Drawing.Point(152, 16)
        Me.CalFromFreq.MaxValue = CType(2500, Short)
        Me.CalFromFreq.MinValue = CType(1800, Short)
        Me.CalFromFreq.Name = "CalFromFreq"
        Me.CalFromFreq.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CalFromFreq.Sal_Mali = Nothing
        Me.CalFromFreq.ShowButton = True
        Me.CalFromFreq.Size = New System.Drawing.Size(110, 23)
        Me.CalFromFreq.TabIndex = 3
        Me.CalFromFreq.VisualStyle = False
        '
        'CalToFreq
        '
        Me.CalToFreq.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CalToFreq.BorderColor = System.Drawing.Color.Empty
        Me.CalToFreq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CalToFreq.ButtonBackColor = System.Drawing.Color.Empty
        Me.CalToFreq.ButtonForeColor = System.Drawing.Color.Empty
        Me.CalToFreq.EditableSal = True
        Me.CalToFreq.Image = CType(resources.GetObject("CalToFreq.Image"), System.Drawing.Image)
        Me.CalToFreq.Location = New System.Drawing.Point(296, 16)
        Me.CalToFreq.MaxValue = CType(2500, Short)
        Me.CalToFreq.MinValue = CType(1800, Short)
        Me.CalToFreq.Name = "CalToFreq"
        Me.CalToFreq.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CalToFreq.Sal_Mali = Nothing
        Me.CalToFreq.ShowButton = True
        Me.CalToFreq.Size = New System.Drawing.Size(110, 23)
        Me.CalToFreq.TabIndex = 4
        Me.CalToFreq.VisualStyle = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(120, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "From"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(272, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 23)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "To"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(40, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Analysis Date"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(40, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Traffic Analysis"
        '
        'PanelDateStore
        '
        Me.PanelDateStore.Controls.Add(Me.CalFromStore)
        Me.PanelDateStore.Controls.Add(Me.CalToStore)
        Me.PanelDateStore.Controls.Add(Me.Label10)
        Me.PanelDateStore.Controls.Add(Me.Label12)
        Me.PanelDateStore.Controls.Add(Me.Label9)
        Me.PanelDateStore.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDateStore.Location = New System.Drawing.Point(0, 48)
        Me.PanelDateStore.Name = "PanelDateStore"
        Me.PanelDateStore.Size = New System.Drawing.Size(478, 96)
        Me.PanelDateStore.TabIndex = 18
        Me.PanelDateStore.TabStop = False
        '
        'CalFromStore
        '
        Me.CalFromStore.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CalFromStore.BorderColor = System.Drawing.Color.Empty
        Me.CalFromStore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CalFromStore.ButtonBackColor = System.Drawing.Color.Empty
        Me.CalFromStore.ButtonForeColor = System.Drawing.Color.Empty
        Me.CalFromStore.EditableSal = True
        Me.CalFromStore.Image = CType(resources.GetObject("CalFromStore.Image"), System.Drawing.Image)
        Me.CalFromStore.Location = New System.Drawing.Point(152, 40)
        Me.CalFromStore.MaxValue = CType(2500, Short)
        Me.CalFromStore.MinValue = CType(1800, Short)
        Me.CalFromStore.Name = "CalFromStore"
        Me.CalFromStore.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CalFromStore.Sal_Mali = Nothing
        Me.CalFromStore.ShowButton = True
        Me.CalFromStore.Size = New System.Drawing.Size(110, 23)
        Me.CalFromStore.TabIndex = 3
        Me.CalFromStore.VisualStyle = False
        '
        'CalToStore
        '
        Me.CalToStore.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CalToStore.BorderColor = System.Drawing.Color.Empty
        Me.CalToStore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CalToStore.ButtonBackColor = System.Drawing.Color.Empty
        Me.CalToStore.ButtonForeColor = System.Drawing.Color.Empty
        Me.CalToStore.EditableSal = True
        Me.CalToStore.Image = CType(resources.GetObject("CalToStore.Image"), System.Drawing.Image)
        Me.CalToStore.Location = New System.Drawing.Point(296, 40)
        Me.CalToStore.MaxValue = CType(2500, Short)
        Me.CalToStore.MinValue = CType(1800, Short)
        Me.CalToStore.Name = "CalToStore"
        Me.CalToStore.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CalToStore.Sal_Mali = Nothing
        Me.CalToStore.ShowButton = True
        Me.CalToStore.Size = New System.Drawing.Size(110, 23)
        Me.CalToStore.TabIndex = 4
        Me.CalToStore.VisualStyle = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(120, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 23)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "From"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(272, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 23)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "To"
        '
        'FrmRepTraffic
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(478, 348)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.PanelTSCT)
        Me.Controls.Add(Me.PanelDateNew)
        Me.Controls.Add(Me.PanelDateInactive)
        Me.Controls.Add(Me.PanelDateFreq)
        Me.Controls.Add(Me.PanelDateStore)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmRepTraffic"
        Me.Text = "New Customer Listing"
        Me.PanelTSCT.ResumeLayout(False)
        Me.PanelDetail.ResumeLayout(False)
        Me.PanelSource.ResumeLayout(False)
        Me.PanelType.ResumeLayout(False)
        Me.PanelDateNew.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DsFrmRepTraffic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDateInactive.ResumeLayout(False)
        Me.PanelDateFreq.ResumeLayout(False)
        Me.PanelDateStore.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim StrType As String
    Dim StrSource As String
    Dim StrDate As String
    Dim ComName As String = SystemInformation.ComputerName
    Dim MKindOfReport As KindReport
    Public Enum KindReport As Integer
        NewCustomer = 1
        InactiveCus = 2
        FrequencyAnalysis = 3
        StoreTrafficAnalysis = 4
       
    End Enum
    Public Property KindOfReport() As String
        Get
            Return MKindOfReport
        End Get
        Set(ByVal Value As String)
            MKindOfReport = Value
        End Set
    End Property
    Private Sub FrmRepTraffic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        
        FillFormText()
    End Sub
    Private Sub FillFormText()

        Select Case MKindOfReport
            Case KindReport.NewCustomer
                Me.Text = " New Customers Listing"
                CalFromNew.Text = "01/01/" & PSalMali
                CalToNew.Text = "12/28/" & PSalMali
                PanelDateFreq.Visible = False
                PanelDateInactive.Visible = False
                PanelDateStore.Visible = False
            Case KindReport.InactiveCus
                Me.Text = " Inactive Customers Listing"
                CalInactive.Text = "01/01/" & PSalMali
                PanelDateFreq.Visible = False
                PanelDateNew.Visible = False
                PanelDateStore.Visible = False
            Case KindReport.FrequencyAnalysis
                Me.Text = " Frequency and Value Analysis"
                CalFromFreq.Text = "01/01/" & PSalMali
                CalToFreq.Text = Format(Now(), "MM/dd/yyyy")
                PanelDateNew.Visible = False
                PanelDateInactive.Visible = False
                PanelDateStore.Visible = False
            Case KindReport.StoreTrafficAnalysis
                Me.Text = " Store Traffic Analysis"

                CalFromStore.Text = "01/01/" & PSalMali
                CalToStore.Text = Format(Now(), "MM/dd/yyyy")
                PanelDateFreq.Visible = False
                PanelDateInactive.Visible = False
                PanelDateNew.Visible = False
                PanelTSCT.Visible = False

                Dim i As New System.Drawing.Point(128, 200)
                BtnOk.Location = i
                Dim j As New System.Drawing.Point(280, 200)
                BtnCancel.Location = j
                Dim z As New System.Drawing.Size(488, 296)
                Me.Size = z



        End Select
    End Sub
    
    Private Sub RdoAllType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllType.CheckedChanged
        If RdoAllType.Checked Then
            BtnType.Enabled = False
        Else
            BtnType.Enabled = True
        End If

    End Sub

    Private Sub RdoAllSource_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoAllSource.CheckedChanged
        If RdoAllSource.Checked Then
            BtnSource.Enabled = False
        Else
            BtnSource.Enabled = True
        End If
    End Sub
    Private Sub BtnType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnType.Click

        BtnType.Enabled = False
        Dim f As New FrmSelectVendor
        If DsFrmRepTraffic1.type.Count = 0 Then
            DsFrmRepTraffic1.type.Clear()
            DAType.Fill(DsFrmRepTraffic1.type)
        End If
        f.Text = "  Select Type"
        f.TypeOfForm = FrmSelectVendor.KindForm.Type
        f.DSMAIN = DsFrmRepTraffic1
        f.ShowDialog()

        BtnType.Enabled = True
    End Sub

    Private Sub BtnSource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSource.Click
        BtnSource.Enabled = False
        Dim f As New FrmSelectVendor
        If DsFrmRepTraffic1.source.Count = 0 Then
            DsFrmRepTraffic1.source.Clear()
            DASource.Fill(DsFrmRepTraffic1.source)
        End If
        f.Text = "  Select Source"
        f.TypeOfForm = FrmSelectVendor.KindForm.source
        f.DSMAIN = DsFrmRepTraffic1
        f.ShowDialog()



        BtnSource.Enabled = True
    End Sub

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        If ControlSelect() Then
            Dim f As New FrmPrintTraffic
            f.StrWhere = ""
            f.StrFilter = ""

            f.StrFilter = f.StrFilter & "Date, "
            f.StrWhere = f.StrWhere & " (" & StrDate & ") and "
            Select Case MKindOfReport
                Case KindReport.NewCustomer
                    f.Date1 = CalFromNew.Text
                    f.Date2 = CalToNew.Text
                Case KindReport.InactiveCus
                    f.Date1 = CalInactive.Text

                Case KindReport.FrequencyAnalysis
                    f.Date1 = CalFromFreq.Text
                    f.Date2 = CalToFreq.Text
                    f.SpendAmount = TxtSpent.Text
                    f.CountInvoice = TxtNumInvoice.Text
                Case KindReport.StoreTrafficAnalysis
                    f.Date1 = CalFromStore.Text
                    f.Date2 = CalToStore.Text

            End Select

          

            If RdoSelectedType.Checked Then
                f.StrFilter = f.StrFilter & "Type, "
                f.StrWhere = f.StrWhere & " (" & StrType & ") and "

            End If
            If RdoSelectedSource.Checked Then
                f.StrFilter = f.StrFilter & "Source, "
                f.StrWhere = f.StrWhere & " (" & StrSource & ") and "

            End If



            If f.StrWhere.Trim.Length > 0 Then f.StrWhere = Mid(f.StrWhere, 1, f.StrWhere.Length - 4)
            If f.StrFilter.Trim.Length > 0 Then f.StrFilter = Mid(f.StrFilter, 1, f.StrFilter.Length - 2)

            Select Case MKindOfReport
                Case KindReport.NewCustomer
                    If RdoList.Checked Then
                        f.KindOfReport = FrmPrintTraffic.KindReport.NewCustomerList
                        f.Text = Me.Text
                        f.ShowDialog()
                    Else
                        NewCusLabel(f.StrWhere)
                    End If
                Case KindReport.InactiveCus
                    If RdoList.Checked Then
                        f.KindOfReport = FrmPrintTraffic.KindReport.InactiveCusList
                        f.Text = Me.Text
                        f.ShowDialog()
                    Else
                        InactiveCusLabel(f.StrWhere)
                    End If
                Case KindReport.FrequencyAnalysis
                    If RdoList.Checked Then
                        f.KindOfReport = FrmPrintTraffic.KindReport.FrequencyAnalysisList
                        f.Text = Me.Text
                        f.ShowDialog()
                    Else
                        FreqCusLabel(f.StrWhere)
                    End If
                Case KindReport.StoreTrafficAnalysis
                    f.KindOfReport = FrmPrintTraffic.KindReport.StoreTrafficAnalysis
                    f.Text = Me.Text
                    f.ShowDialog()
            End Select



            If RdoSelectedType.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Type_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If
            If RdoSelectedSource.Checked Then
                CmdGeneral.CommandText = " DROP TABLE Source_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            End If

        End If

    End Sub
    Private Function ControlSelect() As Boolean
        'Dim flagcontrol As Boolean = False
        ControlSelect = True

        Dim i As Integer



        '''''''type
        StrType = ""
        'flagcontrol = False
        If RdoSelectedType.Checked Then
            If DsFrmRepTraffic1.type.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select Type that you want")
                Exit Function

            Else
                Try
                    CmdGeneral.CommandText = " create table Type_" & ComName & "(cod_type char(1))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Type_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DsFrmRepTraffic1.type.Count - 1
                    If DsFrmRepTraffic1.type(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO Type_" & ComName & " (cod_type ) VALUES (" & Qt(DsFrmRepTraffic1.type(i).cod) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrType = " cust_trtab_main.cod_type in (select cod_type from Type_" & ComName & ") "
            End If
            'If DsFrmRepCusSale2.type.Select(" flag = 1 ").Length = 0 Then
            '    ControlSelect = False
            '    MsgBox("First Select Type that you want")
            '    Exit Function
            'End If


        End If
        '''''''''''Source
        StrSource = ""
        If RdoSelectedSource.Checked Then

            If DsFrmRepTraffic1.source.Select(" flag = 1 ").Length = 0 Then
                ControlSelect = False
                MsgBox("First Select Source that you want")
                Exit Function
            Else
                Try
                    CmdGeneral.CommandText = " create table source_" & ComName & "(cod_source char(1))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM source_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try

                For i = 0 To DsFrmRepTraffic1.source.Count - 1
                    If DsFrmRepTraffic1.source(i).flag Then

                        CmdGeneral.CommandText = " INSERT INTO source_" & ComName & " (cod_source ) VALUES (" & Qt(DsFrmRepTraffic1.source(i).cod) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrSource = " cust_trtab_main.cod_source in (select cod_source from source_" & ComName & ") "
            End If

        End If
        ''''''date
        StrDate = ""
        Select Case MKindOfReport
            Case KindReport.NewCustomer
                If ChangeDateToYYYYMMDD(CalFromNew.Text) > ChangeDateToYYYYMMDD(CalToNew.Text) Then
                    ControlSelect = False
                    MsgBox("First Date Must Be Leaster Than Second Time")
                    Exit Function
                Else
                    StrDate = "dbo.ChangeDate( Since.CustSince)  between " & Qt(ChangeDateToYYYYMMDD(CalFromNew.Text)) & " and " & Qt(ChangeDateToYYYYMMDD(CalToNew.Text))

                End If
            Case KindReport.InactiveCus
                'If ChangeDateToYYYYMMDD(CalFromNew.Text) > ChangeDateToYYYYMMDD(CalToNew.Text) Then
                '    ControlSelect = False
                '    MsgBox("First Date Must Be Leaster Than Second Time")
                '    Exit Function
                'Else
                If ChkInactive.Checked Then
                    StrDate = "dbo.ChangeDate(isnull(last.LastVisit,'0')) < " & Qt(ChangeDateToYYYYMMDD(CalInactive.Text))
                Else
                    StrDate = "dbo.ChangeDate(last.LastVisit) < " & Qt(ChangeDateToYYYYMMDD(CalInactive.Text))
                End If


                'End If

            Case KindReport.FrequencyAnalysis
                If ChangeDateToYYYYMMDD(CalFromFreq.Text) > ChangeDateToYYYYMMDD(CalFromFreq.Text) Then
                    ControlSelect = False
                    MsgBox("First Date Must Be Leaster Than Second Time")
                    Exit Function
                Else
                    StrDate = "dbo.ChangeDate( service_center_head.date_refer)  between " & Qt(ChangeDateToYYYYMMDD(CalFromFreq.Text)) & " and " & Qt(ChangeDateToYYYYMMDD(CalToFreq.Text))
                End If
            Case KindReport.StoreTrafficAnalysis
                If ChangeDateToYYYYMMDD(CalFromStore.Text) > ChangeDateToYYYYMMDD(CalFromStore.Text) Then
                    ControlSelect = False
                    MsgBox("First Date Must Be Leaster Than Second Time")
                    Exit Function
                Else
                    StrDate = "dbo.ChangeDate(View_CustStore_" & ComName & ".date_refer)  between " & Qt(ChangeDateToYYYYMMDD(CalFromStore.Text)) & " and " & Qt(ChangeDateToYYYYMMDD(CalToStore.Text))
                End If

        End Select
       

    End Function
    Private Sub NewCusLabel(ByVal StrWhere As String)
        DsFrmRepTraffic1.List.Clear()
        DAList.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer AS customer_no, cust_trtab_main.f_name, cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
"                       cust_company.complete_name, bas_zipcode.city, cust_trtab_main.zip,  " & _
"                       CASE WHEN phone_main_1 = 1 THEN phone_1 WHEN phone_main_2 = 1 THEN phone_2 WHEN phone_main_3 = 1 THEN phone_3 WHEN phone_main_4 " & _
"                        = 1 THEN phone_4 WHEN phone_main_5 = 1 THEN phone_5 END AS phone_1, Since.CustSince, cust_tab_type.desc_type,  " & _
"                       cust_tab_source.desc_source, 1 AS flag, cust_trtab_main.address , bas_zipcode.state" & _
" FROM         cust_trtab_main LEFT OUTER JOIN " & _
"                       bas_zipcode ON cust_trtab_main.zip = bas_zipcode.zipcode LEFT OUTER JOIN " & _
"                       cust_tab_source ON cust_trtab_main.cod_source = cust_tab_source.cod_source LEFT OUTER JOIN " & _
"                       cust_tab_type ON cust_trtab_main.cod_type = cust_tab_type.cod_type LEFT OUTER JOIN " & _
"                       cust_company ON cust_trtab_main.cod_company = cust_company.cod_company LEFT OUTER JOIN " & _
"                           (SELECT     dbo.changedatetonormal(MIN(dbo.changedate(Date_Refer))) AS CustSince, service_center_head.cod_customer " & _
"                              FROM         service_center_head " & _
"                              WHERE     type_of_form = 'IN' " & _
"                              GROUP BY service_center_head.cod_customer) Since ON cust_trtab_main.cod_customer = Since.cod_customer " & IIf(StrWhere.Trim.Length > 0, " WHERE " & StrWhere, "")



        'If StrWhere.Length > 0 Then
        '    DAList.SelectCommand.CommandText = DAList.SelectCommand.CommandText & " where " & StrWhere
        'End If
        Try
            DAList.Fill(DsFrmRepTraffic1.List)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        Dim rpt As New RepNewCusLabel
        Dim prn As New FrmRepView
       
        rpt.SetDataSource(DsFrmRepTraffic1)
        
        prn.CrViewer.ReportSource = rpt
        prn.ShowDialog()
    End Sub
    Private Sub InactiveCusLabel(ByVal StrWhere As String)
        DsFrmRepTraffic1.List.Clear()
        DAList.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer AS customer_no, cust_trtab_main.f_name, cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
"                       cust_company.complete_name, bas_zipcode.city, cust_trtab_main.zip,  " & _
"                       CASE WHEN phone_main_1 = 1 THEN phone_1 WHEN phone_main_2 = 1 THEN phone_2 WHEN phone_main_3 = 1 THEN phone_3 WHEN phone_main_4 " & _
"                        = 1 THEN phone_4 WHEN phone_main_5 = 1 THEN phone_5 END AS phone_1, last.LastVisit as CustSince, cust_tab_type.desc_type,  " & _
"                       cust_tab_source.desc_source, 1 AS flag, cust_trtab_main.address , bas_zipcode.state" & _
" FROM         cust_trtab_main LEFT OUTER JOIN " & _
"                       bas_zipcode ON cust_trtab_main.zip = bas_zipcode.zipcode LEFT OUTER JOIN " & _
"                       cust_tab_source ON cust_trtab_main.cod_source = cust_tab_source.cod_source LEFT OUTER JOIN " & _
"                       cust_tab_type ON cust_trtab_main.cod_type = cust_tab_type.cod_type LEFT OUTER JOIN " & _
"                       cust_company ON cust_trtab_main.cod_company = cust_company.cod_company LEFT OUTER JOIN " & _
"                           (SELECT     dbo.changedatetonormal(MAX(dbo.changedate(Date_Refer))) AS LastVisit, service_center_head.cod_customer " & _
"                              FROM         service_center_head " & _
"                              WHERE     type_of_form = 'IN' " & _
"                              GROUP BY service_center_head.cod_customer) last ON cust_trtab_main.cod_customer = last.cod_customer " & IIf(StrWhere.Trim.Length > 0, " WHERE " & StrWhere, "")



        'If StrWhere.Length > 0 Then
        '    DAList.SelectCommand.CommandText = DAList.SelectCommand.CommandText & " where " & StrWhere
        'End If
        Try
            DAList.Fill(DsFrmRepTraffic1.List)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        Dim rpt As New RepNewCusLabel
        Dim prn As New FrmRepView



        rpt.SetDataSource(DsFrmRepTraffic1)

        prn.CrViewer.ReportSource = rpt
        prn.ShowDialog()
    End Sub
    Private Sub FreqCusLabel(ByVal StrWhere As String)

        DsFrmRepTraffic1.List.Clear()

        DAList.SelectCommand.CommandText = " SELECT     dbo.cust_trtab_main.cod_customer, dbo.cust_trtab_main.f_name, dbo.cust_trtab_main.m_name + ' ' + dbo.cust_trtab_main.l_name AS name,   " & _
"                       dbo.cust_company.complete_name, dbo.bas_zipcode.city, dbo.cust_trtab_main.zip,  " & _
"                       CASE WHEN phone_main_1 = 1 THEN phone_1 WHEN phone_main_2 = 1 THEN phone_2 WHEN phone_main_3 = 1 THEN phone_3 WHEN phone_main_4 " & _
"                        = 1 THEN phone_4 WHEN phone_main_5 = 1 THEN phone_5 END AS phone_1,'' as desc_type,  " & _
"                       '' as desc_source, 1 AS flag, dbo.cust_trtab_main.address, dbo.bas_zipcode.state " & _
" FROM         dbo.bas_zipcode INNER JOIN " & _
"                       dbo.cust_trtab_main ON dbo.bas_zipcode.zipcode = dbo.cust_trtab_main.zip LEFT OUTER JOIN " & _
"                       dbo.cust_company ON dbo.bas_zipcode.zipcode = dbo.cust_company.zip_code AND  " & _
"                       dbo.cust_trtab_main.cod_company = dbo.cust_company.cod_company RIGHT OUTER JOIN " & _
"                       dbo.service_center_head ON dbo.cust_trtab_main.cod_customer = dbo.service_center_head.cod_customer " & _
" WHERE     (dbo.service_center_head.type_of_form = 'IN') AND (dbo.service_center_head.id_service_center NOT IN " & _
"                           (SELECT     id_service_center " & _
"                              FROM         service_center_dtl " & _
"                              WHERE     (type_select = 'B')))  " & IIf(StrWhere.Trim.Length > 0, " AND " & StrWhere, "") & _
" GROUP BY dbo.cust_trtab_main.cod_customer, dbo.cust_trtab_main.f_name, dbo.cust_trtab_main.m_name, dbo.cust_trtab_main.l_name,  " & _
"                       dbo.cust_company.complete_name, dbo.bas_zipcode.city, dbo.cust_trtab_main.zip, dbo.cust_trtab_main.phone_1, dbo.cust_trtab_main.phone_2,  " & _
"                       dbo.cust_trtab_main.phone_3, dbo.cust_trtab_main.phone_4, dbo.cust_trtab_main.phone_5, dbo.cust_trtab_main.phone_main_1,  " & _
"                       dbo.cust_trtab_main.phone_main_2, dbo.cust_trtab_main.phone_main_3, dbo.cust_trtab_main.phone_main_4, dbo.cust_trtab_main.phone_main_5,  " & _
"                       dbo.cust_trtab_main.address, dbo.bas_zipcode.state " & _
" HAVING      (COUNT(dbo.service_center_head.id_service_center) > " & TxtNumInvoice.Text & ") AND (SUM(ROUND(ISNULL(dbo.service_center_head.Total, 0), 2)) > " & TxtSpent.Text & ") "


        Try
            DAList.Fill(DsFrmRepTraffic1.List)
        Catch ex As Exception
        End Try

        Dim rpt As New RepNewCusLabel
        Dim prn As New FrmRepView

        rpt.SetDataSource(DsFrmRepTraffic1)

        prn.CrViewer.ReportSource = rpt
        prn.ShowDialog()
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class
