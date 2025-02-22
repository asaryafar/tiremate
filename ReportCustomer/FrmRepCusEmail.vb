Imports CommonClass
Public Class FrmRepCusEmail
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCus As System.Windows.Forms.Button
    Friend WithEvents GrdList As Janus.Windows.GridEX.GridEX
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAList As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmprint1 As ReportCustomer.DSFrmprint
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents RdFirst As System.Windows.Forms.RadioButton
    Friend WithEvents RdLast As System.Windows.Forms.RadioButton
    Friend WithEvents CalFirst As CalendarCombo.CalendarCombo
    Friend WithEvents CalLast As CalendarCombo.CalendarCombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmRepCusEmail))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.CalFirst = New CalendarCombo.CalendarCombo
        Me.BtnCus = New System.Windows.Forms.Button
        Me.GrdList = New Janus.Windows.GridEX.GridEX
        Me.DsFrmprint1 = New ReportCustomer.DSFrmprint
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAList = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.RdFirst = New System.Windows.Forms.RadioButton
        Me.CalLast = New CalendarCombo.CalendarCombo
        Me.RdLast = New System.Windows.Forms.RadioButton
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Panel4.SuspendLayout()
        CType(Me.GrdList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmprint1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel4.Size = New System.Drawing.Size(310, 48)
        Me.Panel4.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Location = New System.Drawing.Point(64, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(262, 46)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Select  Customers"
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
        'CalFirst
        '
        Me.CalFirst.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CalFirst.BorderColor = System.Drawing.Color.Empty
        Me.CalFirst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CalFirst.ButtonBackColor = System.Drawing.Color.Empty
        Me.CalFirst.ButtonForeColor = System.Drawing.Color.Empty
        Me.CalFirst.EditableSal = True
        Me.CalFirst.Image = CType(resources.GetObject("CalFirst.Image"), System.Drawing.Image)
        Me.CalFirst.Location = New System.Drawing.Point(144, 112)
        Me.CalFirst.MaxValue = CType(2500, Short)
        Me.CalFirst.MinValue = CType(1800, Short)
        Me.CalFirst.Name = "CalFirst"
        Me.CalFirst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CalFirst.Sal_Mali = Nothing
        Me.CalFirst.ShowButton = True
        Me.CalFirst.Size = New System.Drawing.Size(110, 23)
        Me.CalFirst.TabIndex = 8
        Me.CalFirst.VisualStyle = False
        '
        'BtnCus
        '
        Me.BtnCus.Location = New System.Drawing.Point(120, 216)
        Me.BtnCus.Name = "BtnCus"
        Me.BtnCus.TabIndex = 11
        Me.BtnCus.Text = "Browse"
        '
        'GrdList
        '
        Me.GrdList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GrdList.DataMember = "List"
        Me.GrdList.DataSource = Me.DsFrmprint1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""customer_no""" & _
        "><AggregateFunction>Count</AggregateFunction><Caption>Customer</Caption><DataMem" & _
        "ber>customer_no</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</" & _
        "FilterEditType><Key>customer_no</Key><Position>0</Position><Width>61</Width><Tot" & _
        "alFormatMode>UseStringFormat</TotalFormatMode><TotalFormatString>No Of Customers" & _
        "  : {0}</TotalFormatString></Column0><Column1 ID=""f_name""><Caption>First Name</C" & _
        "aption><DataMember>f_name</DataMember><EditType>NoEdit</EditType><FilterEditType" & _
        ">TextBox</FilterEditType><Key>f_name</Key><Position>1</Position><Width>78</Width" & _
        "></Column1><Column2 ID=""name""><Caption>Last Name</Caption><DataMember>name</Data" & _
        "Member><EditType>NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>n" & _
        "ame</Key><Position>2</Position><Width>85</Width></Column2><Column3 ID=""complete_" & _
        "name""><Caption>Company</Caption><DataMember>complete_name</DataMember><EditType>" & _
        "NoEdit</EditType><FilterEditType>TextBox</FilterEditType><Key>complete_name</Key" & _
        "><Position>3</Position><Width>151</Width></Column3><Column4 ID=""phone_1""><Captio" & _
        "n>Main Phone</Caption><DataMember>phone_1</DataMember><EditType>NoEdit</EditType" & _
        "><FilterEditType>TextBox</FilterEditType><Key>phone_1</Key><Position>4</Position" & _
        "><Width>79</Width></Column4><Column5 ID=""email""><Caption>Email</Caption><DataMem" & _
        "ber>email</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filter" & _
        "EditType><Key>email</Key><Position>5</Position></Column5></Columns><GroupConditi" & _
        "on ID="""" /></RootTable></GridEXLayoutData>"
        Me.GrdList.DesignTimeLayout = GridEXLayout1
        Me.GrdList.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdList.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.GrdList.GroupTotals = Janus.Windows.GridEX.GroupTotals.Always
        Me.GrdList.Location = New System.Drawing.Point(92, 52)
        Me.GrdList.Name = "GrdList"
        Me.GrdList.Size = New System.Drawing.Size(392, 240)
        Me.GrdList.TabIndex = 12
        Me.GrdList.Visible = False
        '
        'DsFrmprint1
        '
        Me.DsFrmprint1.DataSetName = "DSFrmprint"
        Me.DsFrmprint1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=ARMANDEHserver;persis" & _
        "t security info=True;initial catalog=TireMate_05"
        '
        'DAList
        '
        Me.DAList.SelectCommand = Me.SqlSelectCommand3
        Me.DAList.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_trtab_main", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("vip_code", "vip_code"), New System.Data.Common.DataColumnMapping("cod_company", "cod_company"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("driver_name1", "driver_name1"), New System.Data.Common.DataColumnMapping("driver_name2", "driver_name2"), New System.Data.Common.DataColumnMapping("driver_name3", "driver_name3"), New System.Data.Common.DataColumnMapping("driver_name4", "driver_name4"), New System.Data.Common.DataColumnMapping("DriverLicense", "DriverLicense"), New System.Data.Common.DataColumnMapping("zip", "zip"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("cod_sales_rep", "cod_sales_rep"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cust_exempt_tax", "cust_exempt_tax"), New System.Data.Common.DataColumnMapping("scrap_check", "scrap_check"), New System.Data.Common.DataColumnMapping("scrap_value", "scrap_value"), New System.Data.Common.DataColumnMapping("credit_card_no", "credit_card_no"), New System.Data.Common.DataColumnMapping("expiration_credit_date", "expiration_credit_date"), New System.Data.Common.DataColumnMapping("credit_limited", "credit_limited"), New System.Data.Common.DataColumnMapping("AR_charge", "AR_charge"), New System.Data.Common.DataColumnMapping("AR_term", "AR_term"), New System.Data.Common.DataColumnMapping("cod_sales_tax", "cod_sales_tax"), New System.Data.Common.DataColumnMapping("cod_price", "cod_price"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("cod_type", "cod_type"), New System.Data.Common.DataColumnMapping("cod_source", "cod_source"), New System.Data.Common.DataColumnMapping("cod_class", "cod_class"), New System.Data.Common.DataColumnMapping("cod_territory", "cod_territory"), New System.Data.Common.DataColumnMapping("desc_sales_report", "desc_sales_report"), New System.Data.Common.DataColumnMapping("user_id", "user_id"), New System.Data.Common.DataColumnMapping("user_password", "user_password"), New System.Data.Common.DataColumnMapping("AR_statement", "AR_statement"), New System.Data.Common.DataColumnMapping("AR_send_copy", "AR_send_copy"), New System.Data.Common.DataColumnMapping("AR_finance_charge", "AR_finance_charge"), New System.Data.Common.DataColumnMapping("AR_require_PO", "AR_require_PO"), New System.Data.Common.DataColumnMapping("AR_credit_hold", "AR_credit_hold"), New System.Data.Common.DataColumnMapping("AR_accept_check", "AR_accept_check"), New System.Data.Common.DataColumnMapping("cust_notes", "cust_notes"), New System.Data.Common.DataColumnMapping("Taxable", "Taxable"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("customer_no", "customer_no")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT cust_trtab_main.cod_customer AS customer_no, cust_trtab_main.f_name + ' ' " & _
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
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'RdFirst
        '
        Me.RdFirst.Checked = True
        Me.RdFirst.Location = New System.Drawing.Point(48, 112)
        Me.RdFirst.Name = "RdFirst"
        Me.RdFirst.Size = New System.Drawing.Size(120, 24)
        Me.RdFirst.TabIndex = 13
        Me.RdFirst.Text = "First Visit After"
        '
        'CalLast
        '
        Me.CalLast.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CalLast.BorderColor = System.Drawing.Color.Empty
        Me.CalLast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CalLast.ButtonBackColor = System.Drawing.Color.Empty
        Me.CalLast.ButtonForeColor = System.Drawing.Color.Empty
        Me.CalLast.EditableSal = True
        Me.CalLast.Image = CType(resources.GetObject("CalLast.Image"), System.Drawing.Image)
        Me.CalLast.Location = New System.Drawing.Point(144, 152)
        Me.CalLast.MaxValue = CType(2500, Short)
        Me.CalLast.MinValue = CType(1800, Short)
        Me.CalLast.Name = "CalLast"
        Me.CalLast.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CalLast.Sal_Mali = Nothing
        Me.CalLast.ShowButton = True
        Me.CalLast.Size = New System.Drawing.Size(110, 23)
        Me.CalLast.TabIndex = 14
        Me.CalLast.VisualStyle = False
        '
        'RdLast
        '
        Me.RdLast.Location = New System.Drawing.Point(48, 152)
        Me.RdLast.Name = "RdLast"
        Me.RdLast.Size = New System.Drawing.Size(120, 24)
        Me.RdLast.TabIndex = 15
        Me.RdLast.Text = "Last Visit After"
        '
        'CheckBox1
        '
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(48, 72)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(192, 24)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "All Customers Who have Email"
        '
        'FrmRepCusEmail
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(310, 268)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CalLast)
        Me.Controls.Add(Me.RdLast)
        Me.Controls.Add(Me.CalFirst)
        Me.Controls.Add(Me.RdFirst)
        Me.Controls.Add(Me.BtnCus)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GrdList)
        Me.Name = "FrmRepCusEmail"
        Me.Panel4.ResumeLayout(False)
        CType(Me.GrdList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmprint1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub RdoAllCus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCus.Click
        Cnn.ConnectionString = PConnectionString

        Dim ws As String = "where 1=1 "

        If CheckBox1.Checked Then
            ws = ws + " and ltrim(rtrim(isnull(cust_trtab_main.email,'')))<>'' "
        End If

        If RdFirst.Checked Then
            ws = ws + " and dbo.ChangeDate(Since.CustSince) >" + Qt(ChangeDateToYYYYMMDD(CalFirst.Text))
        Else
            ws = ws + " and dbo.ChangeDate(last.LastVisit) >" + Qt(ChangeDateToYYYYMMDD(CalLast.Text))
        End If

        DAList.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer AS customer_no, cust_trtab_main.f_name, cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
                      "cust_company.complete_name, cust_trtab_main.zip, " & _
                      "CASE WHEN phone_main_1 = 1 THEN phone_1 WHEN phone_main_2 = 1 THEN phone_2 WHEN phone_main_3 = 1 THEN phone_3 WHEN phone_main_4 " & _
                       "= 1 THEN phone_4 WHEN phone_main_5 = 1 THEN phone_5 END AS phone_1, Since.CustSince, last.LastVisit, 1 AS flag, cust_trtab_main.address,  " & _
                      " CASE WHEN cust_company.complete_name IS NULL  " & _
                      "THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
                      "+ ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName, cust_trtab_main.cod_price,cust_trtab_main.email " & _
" FROM         cust_trtab_main LEFT OUTER JOIN " & _
                      " cust_company ON cust_trtab_main.cod_company = cust_company.cod_company LEFT OUTER JOIN " & _
                          "(SELECT     dbo.ChangeDateToNormal(MAX(dbo.ChangeDate(date_refer))) AS LastVisit, cod_customer " & _
                             "FROM         service_center_head  " & _
                             "WHERE     (type_of_form = 'IN') " & _
                             "GROUP BY cod_customer) AS last ON cust_trtab_main.cod_customer = last.cod_customer LEFT OUTER JOIN " & _
                          "(SELECT     dbo.ChangeDateToNormal(MIN(dbo.ChangeDate(date_refer))) AS CustSince, cod_customer " & _
                             "FROM         service_center_head AS service_center_head_1 " & _
                             "WHERE     (type_of_form = 'IN') " & _
                             "GROUP BY cod_customer) AS Since ON cust_trtab_main.cod_customer = Since.cod_customer " & ws & _
                        "ORDER BY OrderName "



        'If StrWhere.Length > 0 Then
        '    DAList.SelectCommand.CommandText = DAList.SelectCommand.CommandText & " where " & StrWhere
        'End If
        Try
            DAList.Fill(DsFrmprint1.List)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        Dim FileName As String
        If FolderBrowserDialog1.ShowDialog() = DialogResult.Cancel Then
            Exit Sub
        End If
        FileName = "report.CSV"
        Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GrdList)
    End Sub

    Private Sub FrmRepCusEmail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdFirst.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class
