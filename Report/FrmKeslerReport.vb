Imports System.Web.Mail
Imports CommonClass
Public Class FrmKeslerReport
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
    Friend WithEvents PanelTypeItem As System.Windows.Forms.GroupBox
    Friend WithEvents PanelDate As System.Windows.Forms.GroupBox
    Friend WithEvents CalendarCombo2 As CalendarCombo.CalendarCombo
    Friend WithEvents CalendarCombo1 As CalendarCombo.CalendarCombo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents DAinv_tab_labor_service As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents BtnServices As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DsFrmKeslerReport1 As Report.DSFrmKeslerReport
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DARep As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents TXtRepName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmKeslerReport))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.PanelTypeItem = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnServices = New System.Windows.Forms.Button
        Me.PanelDate = New System.Windows.Forms.GroupBox
        Me.CalendarCombo2 = New CalendarCombo.CalendarCombo
        Me.CalendarCombo1 = New CalendarCombo.CalendarCombo
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnOk = New System.Windows.Forms.Button
        Me.DAinv_tab_labor_service = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DsFrmKeslerReport1 = New Report.DSFrmKeslerReport
        Me.Button1 = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DARep = New System.Data.SqlClient.SqlDataAdapter
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.TXtRepName = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.PanelTypeItem.SuspendLayout()
        Me.PanelDate.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DsFrmKeslerReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTypeItem
        '
        Me.PanelTypeItem.Controls.Add(Me.Label4)
        Me.PanelTypeItem.Controls.Add(Me.BtnServices)
        Me.PanelTypeItem.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTypeItem.Location = New System.Drawing.Point(0, 48)
        Me.PanelTypeItem.Name = "PanelTypeItem"
        Me.PanelTypeItem.Size = New System.Drawing.Size(422, 72)
        Me.PanelTypeItem.TabIndex = 3
        Me.PanelTypeItem.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(40, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(224, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Select Services to include in the template "
        '
        'BtnServices
        '
        Me.BtnServices.Location = New System.Drawing.Point(280, 24)
        Me.BtnServices.Name = "BtnServices"
        Me.BtnServices.TabIndex = 2
        Me.BtnServices.Text = "Choose..."
        '
        'PanelDate
        '
        Me.PanelDate.Controls.Add(Me.CalendarCombo2)
        Me.PanelDate.Controls.Add(Me.CalendarCombo1)
        Me.PanelDate.Controls.Add(Me.Label3)
        Me.PanelDate.Controls.Add(Me.Label2)
        Me.PanelDate.Controls.Add(Me.Label1)
        Me.PanelDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDate.Location = New System.Drawing.Point(0, 120)
        Me.PanelDate.Name = "PanelDate"
        Me.PanelDate.Size = New System.Drawing.Size(422, 88)
        Me.PanelDate.TabIndex = 2
        Me.PanelDate.TabStop = False
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
        Me.CalendarCombo2.Location = New System.Drawing.Point(248, 40)
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
        'CalendarCombo1
        '
        Me.CalendarCombo1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CalendarCombo1.BorderColor = System.Drawing.Color.Empty
        Me.CalendarCombo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CalendarCombo1.ButtonBackColor = System.Drawing.Color.Empty
        Me.CalendarCombo1.ButtonForeColor = System.Drawing.Color.Empty
        Me.CalendarCombo1.EditableSal = True
        Me.CalendarCombo1.Image = CType(resources.GetObject("CalendarCombo1.Image"), System.Drawing.Image)
        Me.CalendarCombo1.Location = New System.Drawing.Point(104, 40)
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
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(216, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(56, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "From"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Services Performed during These dates"
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
        Me.Panel4.Size = New System.Drawing.Size(422, 48)
        Me.Panel4.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Location = New System.Drawing.Point(64, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(192, 46)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Select the Item That you want to print"
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
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(320, 296)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.TabIndex = 8
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(232, 296)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.TabIndex = 7
        Me.BtnOk.Text = "Save"
        '
        'DAinv_tab_labor_service
        '
        Me.DAinv_tab_labor_service.SelectCommand = Me.SqlSelectCommand2
        Me.DAinv_tab_labor_service.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_labor_service", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_service", "cod_service"), New System.Data.Common.DataColumnMapping("desc_service", "desc_service"), New System.Data.Common.DataColumnMapping("ext_desc", "ext_desc"), New System.Data.Common.DataColumnMapping("service_type", "service_type"), New System.Data.Common.DataColumnMapping("service_category", "service_category"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("use_cost", "use_cost"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("require_technician", "require_technician"), New System.Data.Common.DataColumnMapping("charge_shop_supply", "charge_shop_supply"), New System.Data.Common.DataColumnMapping("schedule", "schedule"), New System.Data.Common.DataColumnMapping("avg_time", "avg_time"), New System.Data.Common.DataColumnMapping("use_avg_time", "use_avg_time"), New System.Data.Common.DataColumnMapping("bay_no", "bay_no"), New System.Data.Common.DataColumnMapping("use_bay_no", "use_bay_no"), New System.Data.Common.DataColumnMapping("reminder", "reminder"), New System.Data.Common.DataColumnMapping("miles", "miles"), New System.Data.Common.DataColumnMapping("days", "days"), New System.Data.Common.DataColumnMapping("type_b_t_d_v_r", "type_b_t_d_v_r")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cod_service AS Code, desc_service AS Name, 0 AS Flag FROM inv_tab_labor_se" & _
        "rvice WHERE (cod_service NOT IN ('1', '2', '3', '4', '5'))"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARYAFAR;packet size=4096;user id=sa;data source=aryafar;persist se" & _
        "curity info=False;initial catalog=TireMate_04"
        '
        'DsFrmKeslerReport1
        '
        Me.DsFrmKeslerReport1.DataSetName = "DSFrmKeslerReport"
        Me.DsFrmKeslerReport1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(48, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Email"
        Me.Button1.Visible = False
        '
        'GridEX1
        '
        Me.GridEX1.DataSource = Me.DsFrmKeslerReport1.service_center_head
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>service_center_head</Caption><Columns Colle" & _
        "ction=""true""><Column0 ID=""First""><Caption>First</Caption><DataMember>First</Data" & _
        "Member><Key>First</Key><Position>0</Position><Width>83</Width></Column0><Column1" & _
        " ID=""Lname""><Caption>Lname</Caption><DataMember>Lname</DataMember><EditType>NoEd" & _
        "it</EditType><Key>Lname</Key><Position>1</Position><Width>82</Width></Column1><C" & _
        "olumn2 ID=""Address""><Caption>Address</Caption><DataMember>Address</DataMember><K" & _
        "ey>Address</Key><Position>2</Position><Width>141</Width></Column2><Column3 ID=""C" & _
        "ity""><Caption>City</Caption><DataMember>City</DataMember><Key>City</Key><Positio" & _
        "n>3</Position><Width>74</Width></Column3><Column4 ID=""State""><Caption>State</Cap" & _
        "tion><DataMember>State</DataMember><Key>State</Key><Position>4</Position><Width>" & _
        "61</Width></Column4><Column5 ID=""Zip""><Caption>Zip</Caption><TypeNameEmptyString" & _
        "Value>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>Zi" & _
        "p</DataMember><Key>Zip</Key><Position>5</Position><Width>61</Width></Column5><Co" & _
        "lumn6 ID=""Phone""><Caption>Phone</Caption><DataMember>Phone</DataMember><EditType" & _
        ">NoEdit</EditType><Key>Phone</Key><Position>6</Position><Width>79</Width></Colum" & _
        "n6><Column7 ID=""email""><Caption>email</Caption><DataMember>email</DataMember><Ke" & _
        "y>email</Key><Position>7</Position></Column7><Column8 ID=""License""><Caption>Lice" & _
        "nse</Caption><DataMember>License</DataMember><Key>License</Key><Position>8</Posi" & _
        "tion><Width>60</Width></Column8><Column9 ID=""year""><Caption>year</Caption><DataM" & _
        "ember>year</DataMember><Key>year</Key><Position>9</Position><Width>64</Width></C" & _
        "olumn9><Column10 ID=""make""><Caption>make</Caption><DataMember>make</DataMember><" & _
        "Key>make</Key><Position>10</Position><Width>63</Width></Column10><Column11 ID=""M" & _
        "odel""><Caption>Model</Caption><DataMember>Model</DataMember><Key>Model</Key><Pos" & _
        "ition>11</Position></Column11><Column12 ID=""Mileage""><Caption>Mileage</Caption><" & _
        "DataMember>Mileage</DataMember><Key>Mileage</Key><Position>12</Position></Column" & _
        "12><Column13 ID=""Amount""><Caption>Amount</Caption><DataMember>Amount</DataMember" & _
        "><FormatString>c</FormatString><Key>Amount</Key><Position>13</Position><TextAlig" & _
        "nment>Far</TextAlignment></Column13><Column14 ID=""Date""><Caption>Date</Caption><" & _
        "DataMember>Date</DataMember><Key>Date</Key><Position>14</Position></Column14><Co" & _
        "lumn15 ID=""Ignore_Flag""><Caption>Ignore_Flag</Caption><DataMember>Ignore Flag</D" & _
        "ataMember><EditType>NoEdit</EditType><Key>Ignore_Flag</Key><Position>15</Positio" & _
        "n></Column15><Column16 ID=""Service_Type_codes""><Caption>Service Type codes</Capt" & _
        "ion><TypeNameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStri" & _
        "ngValue /><DataMember>Service_Type_codes</DataMember><Key>Service_Type_codes</Ke" & _
        "y><Position>16</Position></Column16><Column17 ID=""Notice Type""><Bound>False</Bou" & _
        "nd><Caption>Notice Type</Caption><Key>Notice Type</Key><Position>17</Position></" & _
        "Column17><Column18 ID=""Notice Order Y/N""><Bound>False</Bound><Caption>Notice Ord" & _
        "er Y/N</Caption><Key>Notice Order Y/N</Key><Position>18</Position></Column18><Co" & _
        "lumn19 ID=""RS Code""><Bound>False</Bound><Caption>RS Code</Caption><Key>RS Code</" & _
        "Key><Position>19</Position></Column19><Column20 ID=""RS Interval""><Bound>False</B" & _
        "ound><Caption>RS Interval</Caption><Key>RS Interval</Key><Position>20</Position>" & _
        "</Column20><Column21 ID=""RS Text""><Bound>False</Bound><Caption>RS Text</Caption>" & _
        "<Key>RS Text</Key><Position>21</Position></Column21></Columns><GroupCondition ID" & _
        "="""" /><Key>service_center_head</Key></RootTable></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Location = New System.Drawing.Point(8, 24)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(408, 168)
        Me.GridEX1.TabIndex = 10
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT DISTINCT cust_trtab_main.f_name AS First, cust_trtab_main.m_name + ' ' + c" & _
        "ust_trtab_main.l_name AS Lname, cust_trtab_main.address AS Address, bas_zipcode." & _
        "city AS City, bas_zipcode.state AS State, bas_zipcode.zipcode AS Zip, CASE WHEN " & _
        "phone_main_1 = 1 THEN phone_1 WHEN phone_main_2 = 1 THEN phone_2 WHEN phone_main" & _
        "_3 = 1 THEN phone_3 WHEN phone_main_4 = 1 THEN phone_4 WHEN phone_main_5 = 1 THE" & _
        "N phone_5 END AS Phone, cust_trtab_main.email, ser_tr_vehicle.license_no_vehicle" & _
        " AS License, bas_vehicle.make_year AS year, bas_vehicle_company.desc_make AS mak" & _
        "e, bas_vehicle_model.desc_model AS Model, ser_tr_vehicle_dtl.current_mileage AS " & _
        "Mileage, service_center_head.Total AS Amount, service_center_head.date_refer AS " & _
        "Date, '' AS Ignore_Flag, inv_tab_labor_service.cod_service AS Service_Type_codes" & _
        " FROM ser_tr_vehicle_dtl INNER JOIN service_center_head INNER JOIN service_cente" & _
        "r_dtl ON service_center_head.id_service_center = service_center_dtl.id_service_c" & _
        "enter INNER JOIN cust_trtab_main ON service_center_head.cod_customer = cust_trta" & _
        "b_main.cod_customer INNER JOIN bas_zipcode ON cust_trtab_main.zip = bas_zipcode." & _
        "zipcode INNER JOIN inv_tab_labor_service ON service_center_dtl.cod_select = inv_" & _
        "tab_labor_service.cod_service ON ser_tr_vehicle_dtl.id_service_center = service_" & _
        "center_head.id_service_center LEFT OUTER JOIN bas_vehicle INNER JOIN ser_tr_vehi" & _
        "cle ON bas_vehicle.cod_vehicle = ser_tr_vehicle.cod_vehicle INNER JOIN bas_vehic" & _
        "le_company ON bas_vehicle.cod_make = bas_vehicle_company.cod_make INNER JOIN bas" & _
        "_vehicle_model ON bas_vehicle.cod_make = bas_vehicle_model.cod_make AND bas_vehi" & _
        "cle.cod_model = bas_vehicle_model.cod_model AND bas_vehicle_company.cod_make = b" & _
        "as_vehicle_model.cod_make ON service_center_head.id_vehicle = ser_tr_vehicle.id_" & _
        "vehicle WHERE (service_center_head.type_of_form = 'IN')"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DARep
        '
        Me.DARep.SelectCommand = Me.SqlSelectCommand1
        Me.DARep.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Total", "Total")})})
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'TXtRepName
        '
        Me.TXtRepName.Location = New System.Drawing.Point(112, 24)
        Me.TXtRepName.MaxLength = 40
        Me.TXtRepName.Name = "TXtRepName"
        Me.TXtRepName.Size = New System.Drawing.Size(208, 20)
        Me.TXtRepName.TabIndex = 11
        Me.TXtRepName.Text = "Kesler Marketing Template "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXtRepName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 208)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 72)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(48, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "File Name :"
        '
        'FrmKeslerReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(422, 348)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.PanelDate)
        Me.Controls.Add(Me.PanelTypeItem)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "FrmKeslerReport"
        Me.Text = "Marketing Template"
        Me.PanelTypeItem.ResumeLayout(False)
        Me.PanelDate.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DsFrmKeslerReport1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ComName As String = SystemInformation.ComputerName
    Dim StrWhere As String = ""
    Dim PathExcel As String = ""
    Private Sub FrmKeslerReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString

        DAinv_tab_labor_service.Fill(DsFrmKeslerReport1.Services)

        CalendarCombo1.Text = "01/01/" & PSalMali
        CalendarCombo2.Text = "12/28/" & PSalMali
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnServices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnServices.Click
        BtnServices.Enabled = False
        Dim f As New FrmSelectServices
      
        f.Text = "  Select Services "
        f.DSITEM = DsFrmKeslerReport1
        f.TypeOfForm = f.KindForm.Services
        f.ShowDialog()
        BtnServices.Enabled = True
    End Sub

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        If MakeStrWhere() Then
            Dim sselect As String = DARep.SelectCommand.CommandText
            DARep.SelectCommand.CommandText = DARep.SelectCommand.CommandText & StrWhere
            DsFrmKeslerReport1.service_center_head.Clear()
            DARep.Fill(DsFrmKeslerReport1.service_center_head)
            Dim FileName As String
            If FolderBrowserDialog1.ShowDialog() = DialogResult.Cancel Then
                Exit Sub
            End If

            FileName = TXtRepName.Text & ".CSV"
            PathExcel = FolderBrowserDialog1.SelectedPath
            Call GridToExcel(FileName, FolderBrowserDialog1.SelectedPath, GridEX1)
            DARep.SelectCommand.CommandText = sselect

            MsgFar("File saved successfully")
            '   Button1.Visible = True
            Try
                CmdGeneral.CommandText = " DROP TABLE Services_" & ComName
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            Catch ex As Exception

            End Try
          
        End If
       
    End Sub
    Private Function MakeStrWhere() As Boolean
        Dim i As Integer
        MakeStrWhere = True

        If DsFrmKeslerReport1.Services.Select(" flag = 1 ").Length > 0 Then
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

            For i = 0 To DsFrmKeslerReport1.Services.Count - 1
                If DsFrmKeslerReport1.Services(i).flag Then
                    CmdGeneral.CommandText = " INSERT INTO Services_" & ComName & " (cod_service) VALUES (" & Qt(DsFrmKeslerReport1.Services(i).code) & ") "
                    CmdGeneral.ExecuteNonQuery()
                End If
            Next
            StrWhere = " and  inv_tab_labor_service.cod_service  in (select cod_service from Services_" & ComName & ") "
        Else
            MakeStrWhere = False
            MsgFar("First Select Services/Fees that you want")
            Exit Function
        End If


        If ChangeDateToYYYYMMDD(CalendarCombo1.Text) > ChangeDateToYYYYMMDD(CalendarCombo2.Text) Then
            MakeStrWhere = False
            MsgBox("First Date Must Be Leaster Than Second Time")
            Exit Function
        End If
        If CalendarCombo1.Text = "" Or CalendarCombo2.Text = "" Then
            MakeStrWhere = False
            MsgBox("First select Date")
            Exit Function
        End If
        StrWhere = StrWhere & "   and dbo.ChangeDate(service_center_head.date_refer) between " & Qt(ChangeDateToYYYYMMDD(CalendarCombo1.Text)) & " and " & Qt(ChangeDateToYYYYMMDD(CalendarCombo2.Text))
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SendMail()
    End Sub
    Private Sub SendMail()
        Dim OleDbReader As System.Data.OleDb.OleDbDataReader
        OleDbReader = RetrieveCompanySetupTable()
        'OleDbReader = RetrieveStoreSetupTable(PubStoreNO)
        Dim StoreEmailAddressVar As String = OleDbReader.Item("EMAIL") & ""
        OleDbReader.Close()
        If StoreEmailAddressVar.Trim.Length = 0 Then
            MsgBox("please fill Company Email Address in setup tables and try again")
            Exit Sub
        End If

        'TODO System.Web.Mail should be replaced by importing System.Web.Mail
        Dim MyFrmSendMailInformation As New CommonClass.FrmSendMailInformation
        MyFrmSendMailInformation.txtTo.Text = "" ' CustomerCod1.EmAilAddress & ""
        MyFrmSendMailInformation.TxtSubject.Text = TXtRepName.Text
        MyFrmSendMailInformation.TxtBody.Text = "Body Test"
        MyFrmSendMailInformation.ShowDialog()
        If MyFrmSendMailInformation.IsOkFlag Then
            If MyFrmSendMailInformation.txtTo.Text.Trim.Length = 0 Then
                MsgBox("please fill Customer Mail Address and try again")
                Exit Sub
            End If
            If MyFrmSendMailInformation.TxtSubject.Text.Trim.Length = 0 Then
                MsgBox("please fill Subject and try again")
                Exit Sub
            End If
            If MyFrmSendMailInformation.TxtBody.Text.Trim.Length = 0 Then
                MsgBox("please fill Body and try again")
                Exit Sub
            End If
            Dim mail As System.Web.Mail.MailMessage = New System.Web.Mail.MailMessage
            mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1")
            mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "invoice@tiremate.net")
            mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "invoice")
            mail.To = MyFrmSendMailInformation.txtTo.Text '"ketabie@yahoo.com;kamran_faraji@yahoo.com;mhz_home@yahoo.com"
            mail.From = StoreEmailAddressVar
            mail.Subject = MyFrmSendMailInformation.TxtSubject.Text
            mail.Body = MyFrmSendMailInformation.TxtBody.Text
            mail.Attachments.Add(New System.Web.Mail.MailAttachment(PathExcel & TXtRepName.Text.Trim & ".CSV"))
            System.Web.Mail.SmtpMail.SmtpServer = "smtp.1and1.com"
            'TODO Try-Catch for exception
            Try
                System.Web.Mail.SmtpMail.Send(mail)
                MsgBox("Job Successfully Performed", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("Please connect to internet and try again", MsgBoxStyle.Exclamation)
            End Try
        End If




        '1-
        'Dim mailMessage As MailMessage = New MailMessage
        'mailMessage.From = "ketabie@yahoo.com"
        'mailMessage.To = "ketabie@yahoo.com"
        'mailMessage.Subject = "Hello World"
        'mailMessage.BodyFormat = System.Web.Mail.MailFormat.Text
        'mailMessage.Attachments.Add(New MailAttachment("c:\Tmp.Jpeg"))
        'mailMessage.Body = "Hello World aaa"
        ''SmtpMail.SmtpServer = "smtpServer" // 's address
        'SmtpMail.Send(mailMessage)



        '2-
        'Dim mailMsg As New MailMessage
        'With mailMsg
        '    .From = "Ketabie@yahoo.com"  ' The from address source 
        '    .To = "Ketabie@yahoo.com" ' The to address source
        '    .Cc = "" ' the CC Address(es) source 
        '    .Bcc = "" ' The BCC Address(es) source 
        '    .Subject = "Test Subject" ' The subject source 
        '    .Body = "Salam.Baba to dige hasti" ' The body source 
        '    '''.Priority = CType(cboPriority.SelectedIndex, MailPriority) ' The message priority 
        '    ' The original code uses an array list to add different attachments, so I'm not 100% certain this would work 
        '    ' But after examining all of it, I see no reason it should not. 
        '    .Attachments.Add("c:\Tmp.Jpeg") ' where "c:\log.txt" is the location of the log(s) that you need to send 
        'End With



        '3-
        '' Create a mailman to send email.
        'Dim mailman As New Chilkat.MailMan
        'mailman.UnlockComponent("UnlockCode")

        '' Set your SMTP server hostname.
        'mailman.SmtpHost = "smtp.earthlink.net"

        '' You may need these depending on your SMTP server.
        ''mailman.SmtpUsername = "username"
        ''mailman.SmtpPassword = "password"

        '' Create the email.
        'Dim email As New Chilkat.Email
        'email.Subject = "This is a test"
        'email.Body = "This is a test"
        'email.AddTo("Chilkat Support", "support@chilkatsoft.com")
        'email.AddCC("Bill Johnson", "bill@mjapanese.com")
        'email.FromAddress = "matt@chilkatsoft.com"
        'email.FromName = "Matt"

        '' Add an attachment
        'If (email.AddFileAttachment("dude.gif") Is Nothing) Then
        '    MsgBox(email.LastErrorText)
        'End If

        '' Send email.
        'If (Not mailman.SendEmail(email)) Then
        '    MsgBox(mailman.LastErrorText)
        'Else
        '    MsgBox("Email Sent!")
        'End If


        '4-
        'Dim sTo As String, sFrom As String, sSubject As String, sBody As String
        'Dim sAttach As String, sCc As String, sBcc As String, sBodyEncoding As String
        'Dim sBodyFormat As String, sMailServer As String, sPriority As String
        'Dim sUrlContentBase As String, sUrlContentLocation As String
        'Dim iLoop1 As Integer

        'sTo = "Ketabie@yahoo.com"
        'sFrom = "Ketabie@yahoo.com"
        'sSubject = "HI"
        'sBody = "This is a test message."
        'sAttach = "c:\Tmp.Jpeg"
        'sCc = "Kamran_faraji@yahoo.com"
        'sBcc = "Majid_armandeh@yahoo.com"
        'sBodyFormat = "HTML"
        ''sBodyEncoding = Encoding.ASCII.EncodingName
        'sPriority = "Normal"
        'sUrlContentBase = "http://www.contoso.com/images"
        'sUrlContentLocation = "http://www.contoso.com/images"
        'sMailServer = "smarthost"

        'Dim MyMail As MailMessage = New MailMessage
        'MyMail.From = sFrom
        'MyMail.To = sTo
        'MyMail.Subject = sSubject
        'MyMail.Body = sBody
        'MyMail.Cc = sCc
        'MyMail.Bcc = sBcc
        'MyMail.UrlContentBase = sUrlContentBase
        'MyMail.UrlContentLocation = sUrlContentLocation

        'Select Case sBodyEncoding
        '    Case Encoding.UTF7.EncodingName : MyMail.BodyEncoding = Encoding.UTF7
        '    Case Encoding.UTF8.EncodingName : MyMail.BodyEncoding = Encoding.UTF8
        '    Case Else : MyMail.BodyEncoding = Encoding.ASCII
        'End Select

        'Select Case UCase(sBodyFormat)
        '    Case "HTML" : MyMail.BodyFormat = MailFormat.Html
        '    Case Else : MyMail.BodyFormat = MailFormat.Text
        'End Select

        'Select Case UCase(sPriority)
        '    Case "HIGH" : MyMail.Priority = MailPriority.High
        '    Case "LOW" : MyMail.Priority = MailPriority.Low
        '    Case Else : MyMail.Priority = MailPriority.Normal
        'End Select

        '' Build an IList of mail attachments.
        'If sAttach <> "" Then
        '    Dim delim As Char = ","
        '    Dim sSubstr As String
        '    For Each sSubstr In sAttach.Split(delim)
        '        Dim myAttachment As MailAttachment = New MailAttachment(sSubstr)
        '        MyMail.Attachments.Add(myAttachment)
        '    Next
        'End If

        'SmtpMail.SmtpServer = sMailServer
        'SmtpMail.Send(MyMail)

        'MsgBox("VB Message sent to " & MyMail.To)


        '5- with outlook
        'Dim oApp As Microsoft.Office.Interop.Outlook.Application
        'oApp = New Microsoft.Office.Interop.Outlook.Application
        '' Create a new MailItem.
        'Dim oMsg As Microsoft.Office.Interop.Outlook.MailItem
        'oMsg = CType(oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem), Microsoft.Office.Interop.Outlook.MailItem)()
        'oMsg.Subject = "Hello!!!"
        'oMsg.Body = "Hello World"
        'oMsg.To = "emailladdress"
        'oMsg.Send()




        ''6-
        '' Variable which will send the mail
        'Dim obj As System.Web.Mail.SmtpMail

        ''Variable to store the attachments 
        'Dim Attachment As System.Web.Mail.MailAttachment

        ''Variable to create the message to send
        'Dim Mailmsg As New System.Web.Mail.MailMessage


        ''Show open dialogue box to select the files to attach
        'Dim Counter As Integer
        ''OFD.CheckFileExists = True
        ''OFD.Title = "Select file(s) to attach"
        ''OFD.ShowDialog()

        ''For Counter = 0 To UBound(OFD.FileNames)
        ''    lstAttachment.Items.Add(OFD.FileNames(Counter))
        ''Next


        ''Remove the attachments
        ''If lstAttachment.SelectedIndex > -1 Then
        ''    lstAttachment.Items.RemoveAt(lstAttachment.SelectedIndex)
        ''End If



        ''Set the properties
        ''Assign the SMTP server
        'obj.SmtpServer = "Smtp(Server)"
        ''Multiple recepients can be specified using ; as the delimeter
        ''Address of the recipient
        'Mailmsg.To = "ketabie@yahoo.com"


        ''Your From Address
        ''You can also use a custom header Reply-To for a different replyto address
        'Mailmsg.From = "\ketabie@yahoo.com\ <ketabie@yahoo.com>"


        ''Specify the body format
        'Mailmsg.BodyFormat = MailFormat.Text

        ''If you want you can add a reply to header 
        ''Mailmsg.Headers.Add("Reply-To", "Manoj@geinetech.net")
        ''custom headersare added like this
        ''Mailmsg.Headers.Add("Manoj", "TestHeader")

        ''Mail Subject
        'Mailmsg.Subject = "Hi"

        ''Attach the files one by one
        ''For Counter = 0 To lstAttachment.Items.Count - 1
        ''    Attachment = New MailAttachment(lstAttachment.Items(Counter))
        ''    'Add it to the mail message
        ''    Mailmsg.Attachments.Add(Attachment)
        ''Next

        ''Mail Body
        'Mailmsg.Body = "this is a test"
        ''Call the send method to send the mail
        'obj.Send(Mailmsg)


        '7-
        '     Quiksoft.FreeSMTP.SMTP.QuickSend( _
        '"mail.yourdomain.com", _
        '"recipient@domain.com", _
        '"sender@domain.com", _
        '"Subject...", _
        '"Message text.", _
        'Quiksoft.FreeSMTP.BodyPartFormat.Plain)
    End Sub
End Class
