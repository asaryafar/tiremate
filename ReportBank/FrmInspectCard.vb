Imports CommonClass
Public Class FrmInspectCard
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
    Friend WithEvents TxtDateRem As CalendarCombo.CalendarCombo
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnEmail As System.Windows.Forms.Button
    Friend WithEvents BtnFax As System.Windows.Forms.Button
    Friend WithEvents BtnPriv As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents TxtToDate As CalendarCombo.CalendarCombo
    Friend WithEvents TxtFromDate As CalendarCombo.CalendarCombo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CmbText As System.Windows.Forms.ComboBox
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAPrint As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmThankCard1 As ReportBank.DSFrmThankCard
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DATextReport As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DAinv_tab_labor_service As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmInspectCard))
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.CmbText = New System.Windows.Forms.ComboBox
        Me.TxtDateRem = New CalendarCombo.CalendarCombo
        Me.Label15 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TxtToDate = New CalendarCombo.CalendarCombo
        Me.TxtFromDate = New CalendarCombo.CalendarCombo
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.BtnEmail = New System.Windows.Forms.Button
        Me.BtnFax = New System.Windows.Forms.Button
        Me.BtnPriv = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAPrint = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DsFrmThankCard1 = New ReportBank.DSFrmThankCard
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DATextReport = New System.Data.SqlClient.SqlDataAdapter
        Me.DAinv_tab_labor_service = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DsFrmThankCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.CmbText)
        Me.Panel3.Controls.Add(Me.TxtDateRem)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 144)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(486, 80)
        Me.Panel3.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(264, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Select Note"
        '
        'CmbText
        '
        Me.CmbText.DataSource = Me.DsFrmThankCard1.TextReport
        Me.CmbText.DisplayMember = "Description"
        Me.CmbText.Location = New System.Drawing.Point(336, 16)
        Me.CmbText.Name = "CmbText"
        Me.CmbText.Size = New System.Drawing.Size(120, 21)
        Me.CmbText.TabIndex = 13
        Me.CmbText.ValueMember = "Code"
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
        Me.TxtDateRem.Location = New System.Drawing.Point(96, 16)
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
        Me.Label15.Location = New System.Drawing.Point(8, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 16)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Reminder Date"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TxtToDate)
        Me.Panel2.Controls.Add(Me.TxtFromDate)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(486, 96)
        Me.Panel2.TabIndex = 24
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
        Me.TxtToDate.Location = New System.Drawing.Point(240, 40)
        Me.TxtToDate.MaxValue = CType(2500, Short)
        Me.TxtToDate.MinValue = CType(1800, Short)
        Me.TxtToDate.Name = "TxtToDate"
        Me.TxtToDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtToDate.Sal_Mali = Nothing
        Me.TxtToDate.ShowButton = True
        Me.TxtToDate.Size = New System.Drawing.Size(110, 23)
        Me.TxtToDate.TabIndex = 17
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
        Me.TxtFromDate.Location = New System.Drawing.Point(96, 40)
        Me.TxtFromDate.MaxValue = CType(2500, Short)
        Me.TxtFromDate.MinValue = CType(1800, Short)
        Me.TxtFromDate.Name = "TxtFromDate"
        Me.TxtFromDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtFromDate.Sal_Mali = Nothing
        Me.TxtFromDate.ShowButton = True
        Me.TxtFromDate.Size = New System.Drawing.Size(110, 23)
        Me.TxtFromDate.TabIndex = 16
        Me.TxtFromDate.VisualStyle = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(48, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "From"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(216, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "To"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(32, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(304, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Customers Whose birthday is in the following date range"
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
        Me.Panel4.Size = New System.Drawing.Size(486, 48)
        Me.Panel4.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Location = New System.Drawing.Point(72, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(264, 46)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Select a date range and any desired options followed by OK  to print Inactive Ins" & _
        "pection Cards"
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
        Me.BtnEmail.Location = New System.Drawing.Point(280, 256)
        Me.BtnEmail.Name = "BtnEmail"
        Me.BtnEmail.TabIndex = 39
        Me.BtnEmail.Text = "Email"
        '
        'BtnFax
        '
        Me.BtnFax.Location = New System.Drawing.Point(192, 256)
        Me.BtnFax.Name = "BtnFax"
        Me.BtnFax.TabIndex = 38
        Me.BtnFax.Text = "Fax"
        '
        'BtnPriv
        '
        Me.BtnPriv.Location = New System.Drawing.Point(104, 256)
        Me.BtnPriv.Name = "BtnPriv"
        Me.BtnPriv.TabIndex = 37
        Me.BtnPriv.Text = "Preview"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(368, 256)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.TabIndex = 36
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(16, 256)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.TabIndex = 35
        Me.BtnPrint.Text = "Print"
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cod_service AS cod, desc_service AS name, days, 0 AS flag FROM inv_tab_lab" & _
        "or_service WHERE (reminder = 1) AND (ISNULL(days, 0) > 0)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARYAFAR;packet size=4096;user id=sa;data source=aryafar;persist se" & _
        "curity info=False;initial catalog=TireMate_01"
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
        'DsFrmThankCard1
        '
        Me.DsFrmThankCard1.DataSetName = "DSFrmThankCard"
        Me.DsFrmThankCard1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Code, Description, WritingText FROM TextReport"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'DATextReport
        '
        Me.DATextReport.SelectCommand = Me.SqlSelectCommand3
        Me.DATextReport.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TextReport", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Code", "Code"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("WritingText", "WritingText")})})
        '
        'DAinv_tab_labor_service
        '
        Me.DAinv_tab_labor_service.SelectCommand = Me.SqlSelectCommand2
        Me.DAinv_tab_labor_service.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_labor_service", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_service", "cod_service"), New System.Data.Common.DataColumnMapping("desc_service", "desc_service"), New System.Data.Common.DataColumnMapping("ext_desc", "ext_desc"), New System.Data.Common.DataColumnMapping("service_type", "service_type"), New System.Data.Common.DataColumnMapping("service_category", "service_category"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("use_cost", "use_cost"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("require_technician", "require_technician"), New System.Data.Common.DataColumnMapping("charge_shop_supply", "charge_shop_supply"), New System.Data.Common.DataColumnMapping("schedule", "schedule"), New System.Data.Common.DataColumnMapping("avg_time", "avg_time"), New System.Data.Common.DataColumnMapping("use_avg_time", "use_avg_time"), New System.Data.Common.DataColumnMapping("bay_no", "bay_no"), New System.Data.Common.DataColumnMapping("use_bay_no", "use_bay_no"), New System.Data.Common.DataColumnMapping("reminder", "reminder"), New System.Data.Common.DataColumnMapping("miles", "miles"), New System.Data.Common.DataColumnMapping("days", "days"), New System.Data.Common.DataColumnMapping("type_b_t_d_v_r", "type_b_t_d_v_r")})})
        '
        'FrmInspectCard
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(486, 316)
        Me.Controls.Add(Me.BtnEmail)
        Me.Controls.Add(Me.BtnFax)
        Me.Controls.Add(Me.BtnPriv)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmInspectCard"
        Me.Text = "Inspection Cards"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DsFrmThankCard1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmInspectCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Cnn.ConnectionString = PConnectionString
        TxtDateRem.Text = Format(Now.Date, PubDateFormat)
        DATextReport.Fill(DsFrmThankCard1.TextReport)

    End Sub


    Private Sub FillDataset()


        Dim strSer As String = ""
        Dim i As Integer


        Dim str As String = ""

        str = "   SUBSTRING(dbo.ChangeDate(cust_trtab_main.Customer_Birth_Date),6,5) BETWEEN  " & Qt(Mid(ChangeDateToYYYYMMDD(TxtFromDate.Text), 6, 5)) & " and  " & Qt(Mid(ChangeDateToYYYYMMDD(TxtToDate.Text), 6, 5))

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

        If TxtToDate.Text.Trim.Length = 0 Or TxtFromDate.Text.Trim.Length = 0 Then
            ControlBlank = False
            Exit Function
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
End Class
