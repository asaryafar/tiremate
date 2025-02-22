Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmFindServiceRecords
    Inherits FrmBase
    Public MainSearchTypeVar As String = ""
    Dim SearchTypeVar As String = ""
    Event ServiceRecordFind(ByVal ThisId_service_center As String)
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PhoneNo1 As UCPhone.PhoneNo
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents BtnViewRowdetail As System.Windows.Forms.Button
    Friend WithEvents BtnWorkOrders As System.Windows.Forms.Button
    Friend WithEvents BtnEstimates As System.Windows.Forms.Button
    Friend WithEvents BtnTodaysInvoices As System.Windows.Forms.Button
    Friend WithEvents TxtLicenseNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustomerNo As System.Windows.Forms.TextBox
    Friend WithEvents TxtCompany As System.Windows.Forms.TextBox
    Friend WithEvents TxtLastName As System.Windows.Forms.TextBox
    Friend WithEvents DsFrmFindServiceRecords1 As ServiceCenterScreen.DSFrmFindServiceRecords
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAService_center_Head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Dtedate_refer As CalendarCombo.CalendarCombo
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CmdOk As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdExit As Janus.Windows.EditControls.UIButton
    Friend WithEvents ChkShowOnlyOutstandingWorkOrders As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents MyLabel As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmFindServiceRecords))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.BtnViewRowdetail = New System.Windows.Forms.Button
        Me.BtnWorkOrders = New System.Windows.Forms.Button
        Me.BtnEstimates = New System.Windows.Forms.Button
        Me.BtnTodaysInvoices = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label14 = New System.Windows.Forms.Label
        Me.BtnFind = New System.Windows.Forms.Button
        Me.Dtedate_refer = New CalendarCombo.CalendarCombo
        Me.PhoneNo1 = New UCPhone.PhoneNo
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtLicenseNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtCustomerNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtCompany = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtLastName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DataView1 = New System.Data.DataView
        Me.DsFrmFindServiceRecords1 = New ServiceCenterScreen.DSFrmFindServiceRecords
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAService_center_Head = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.MyLabel = New System.Windows.Forms.Label
        Me.CmdOk = New Janus.Windows.EditControls.UIButton
        Me.CmdExit = New Janus.Windows.EditControls.UIButton
        Me.ChkShowOnlyOutstandingWorkOrders = New Janus.Windows.EditControls.UICheckBox
        Me.Panel1.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmFindServiceRecords1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnViewRowdetail
        '
        Me.BtnViewRowdetail.Image = CType(resources.GetObject("BtnViewRowdetail.Image"), System.Drawing.Image)
        Me.BtnViewRowdetail.Location = New System.Drawing.Point(315, 3)
        Me.BtnViewRowdetail.Name = "BtnViewRowdetail"
        Me.BtnViewRowdetail.Size = New System.Drawing.Size(24, 24)
        Me.BtnViewRowdetail.TabIndex = 0
        '
        'BtnWorkOrders
        '
        Me.BtnWorkOrders.BackColor = System.Drawing.SystemColors.Control
        Me.BtnWorkOrders.Location = New System.Drawing.Point(6, 4)
        Me.BtnWorkOrders.Name = "BtnWorkOrders"
        Me.BtnWorkOrders.Size = New System.Drawing.Size(95, 23)
        Me.BtnWorkOrders.TabIndex = 3
        Me.BtnWorkOrders.Text = "Work Orders"
        '
        'BtnEstimates
        '
        Me.BtnEstimates.BackColor = System.Drawing.SystemColors.Control
        Me.BtnEstimates.Location = New System.Drawing.Point(109, 4)
        Me.BtnEstimates.Name = "BtnEstimates"
        Me.BtnEstimates.Size = New System.Drawing.Size(95, 23)
        Me.BtnEstimates.TabIndex = 4
        Me.BtnEstimates.Text = "Estimates"
        '
        'BtnTodaysInvoices
        '
        Me.BtnTodaysInvoices.BackColor = System.Drawing.SystemColors.Control
        Me.BtnTodaysInvoices.Location = New System.Drawing.Point(212, 4)
        Me.BtnTodaysInvoices.Name = "BtnTodaysInvoices"
        Me.BtnTodaysInvoices.Size = New System.Drawing.Size(95, 23)
        Me.BtnTodaysInvoices.TabIndex = 5
        Me.BtnTodaysInvoices.Text = "Today's Invoices"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.BtnFind)
        Me.Panel1.Controls.Add(Me.Dtedate_refer)
        Me.Panel1.Controls.Add(Me.PhoneNo1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtLicenseNo)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxtCustomerNo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtCompany)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtLastName)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(4, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(623, 62)
        Me.Panel1.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(574, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 10)
        Me.Label14.TabIndex = 345
        Me.Label14.Text = "Find"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnFind
        '
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFind.Image = CType(resources.GetObject("BtnFind.Image"), System.Drawing.Image)
        Me.BtnFind.Location = New System.Drawing.Point(575, 12)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(33, 27)
        Me.BtnFind.TabIndex = 344
        '
        'Dtedate_refer
        '
        Me.Dtedate_refer.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Dtedate_refer.BorderColor = System.Drawing.Color.Empty
        Me.Dtedate_refer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dtedate_refer.ButtonBackColor = System.Drawing.Color.Empty
        Me.Dtedate_refer.ButtonForeColor = System.Drawing.Color.Empty
        Me.Dtedate_refer.EditableSal = True
        Me.Dtedate_refer.Image = CType(resources.GetObject("Dtedate_refer.Image"), System.Drawing.Image)
        Me.Dtedate_refer.Location = New System.Drawing.Point(447, 7)
        Me.Dtedate_refer.MaxValue = CType(2500, Short)
        Me.Dtedate_refer.MinValue = CType(1800, Short)
        Me.Dtedate_refer.Name = "Dtedate_refer"
        Me.Dtedate_refer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Dtedate_refer.Sal_Mali = Nothing
        Me.Dtedate_refer.ShowButton = True
        Me.Dtedate_refer.Size = New System.Drawing.Size(110, 23)
        Me.Dtedate_refer.TabIndex = 2
        Me.Dtedate_refer.VisualStyle = False
        '
        'PhoneNo1
        '
        Me.PhoneNo1.BackColor = System.Drawing.SystemColors.Window
        Me.PhoneNo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PhoneNo1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.PhoneNo1.Location = New System.Drawing.Point(281, 7)
        Me.PhoneNo1.Name = "PhoneNo1"
        Me.PhoneNo1.Size = New System.Drawing.Size(94, 22)
        Me.PhoneNo1.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.YellowGreen
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(384, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 22)
        Me.Label6.TabIndex = 341
        Me.Label6.Text = "Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtLicenseNo
        '
        Me.TxtLicenseNo.Location = New System.Drawing.Point(447, 36)
        Me.TxtLicenseNo.MaxLength = 20
        Me.TxtLicenseNo.Name = "TxtLicenseNo"
        Me.TxtLicenseNo.Size = New System.Drawing.Size(110, 20)
        Me.TxtLicenseNo.TabIndex = 5
        Me.TxtLicenseNo.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.YellowGreen
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(384, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 22)
        Me.Label4.TabIndex = 340
        Me.Label4.Text = "License No"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCustomerNo
        '
        Me.TxtCustomerNo.Location = New System.Drawing.Point(281, 36)
        Me.TxtCustomerNo.MaxLength = 20
        Me.TxtCustomerNo.Name = "TxtCustomerNo"
        Me.TxtCustomerNo.Size = New System.Drawing.Size(94, 20)
        Me.TxtCustomerNo.TabIndex = 4
        Me.TxtCustomerNo.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.YellowGreen
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(207, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 22)
        Me.Label3.TabIndex = 338
        Me.Label3.Text = "Customer No"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.YellowGreen
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(207, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 22)
        Me.Label2.TabIndex = 336
        Me.Label2.Text = "Phone"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCompany
        '
        Me.TxtCompany.Location = New System.Drawing.Point(69, 36)
        Me.TxtCompany.MaxLength = 20
        Me.TxtCompany.Name = "TxtCompany"
        Me.TxtCompany.Size = New System.Drawing.Size(131, 20)
        Me.TxtCompany.TabIndex = 3
        Me.TxtCompany.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.YellowGreen
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(5, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 22)
        Me.Label1.TabIndex = 334
        Me.Label1.Text = "Company"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtLastName
        '
        Me.TxtLastName.Location = New System.Drawing.Point(69, 7)
        Me.TxtLastName.MaxLength = 20
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.Size = New System.Drawing.Size(131, 20)
        Me.TxtLastName.TabIndex = 0
        Me.TxtLastName.Text = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.YellowGreen
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(5, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 22)
        Me.Label5.TabIndex = 332
        Me.Label5.Text = "Last Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.AlternatingColors = True
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = Nothing
        Me.GrdDetail.DataSource = Me.DataView1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>service_center_head</Caption><Columns Colle" & _
        "ction=""true""><Column0 ID=""id_service_center""><Caption>Reference No</Caption><Typ" & _
        "eNameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue " & _
        "/><DataMember>id_service_center</DataMember><Key>id_service_center</Key><Positio" & _
        "n>0</Position><Width>97</Width></Column0><Column1 ID=""date_refer""><Caption>Date<" & _
        "/Caption><DataMember>date_refer</DataMember><FormatString>MM/dd/yyyy</FormatStri" & _
        "ng><Key>date_refer</Key><Position>1</Position><Width>68</Width></Column1><Column" & _
        "2 ID=""l_name""><Caption>Last Name</Caption><DataMember>l_name</DataMember><Key>l_" & _
        "name</Key><Position>2</Position><Width>99</Width></Column2><Column3 ID=""f_name"">" & _
        "<Caption>First Name</Caption><DataMember>f_name</DataMember><Key>f_name</Key><Po" & _
        "sition>3</Position><Width>80</Width></Column3><Column4 ID=""complete_name""><Capti" & _
        "on>Company</Caption><DataMember>complete_name</DataMember><Key>complete_name</Ke" & _
        "y><Position>4</Position><Width>170</Width></Column4><Column5 ID=""license_no_vehi" & _
        "cle""><Caption>license No</Caption><TypeNameEmptyStringValue>System.String</TypeN" & _
        "ameEmptyStringValue><EmptyStringValue /><DataMember>license_no_vehicle</DataMemb" & _
        "er><Key>license_no_vehicle</Key><Position>5</Position><Width>64</Width></Column5" & _
        "><Column6 ID=""desc_model""><Caption>Model</Caption><DataMember>desc_model</DataMe" & _
        "mber><Key>desc_model</Key><Position>6</Position><Width>80</Width></Column6><Colu" & _
        "mn7 ID=""Unit_No""><Caption>Unit No</Caption><DataMember>Unit_No</DataMember><Key>" & _
        "Unit_No</Key><Position>7</Position></Column7><Column8 ID=""Total""><Caption>Amount" & _
        "</Caption><DataMember>Total</DataMember><FormatString>c2</FormatString><Key>Tota" & _
        "l</Key><Position>8</Position><Width>83</Width></Column8><Column9 ID=""Tax""><Capti" & _
        "on>Sales Tax</Caption><DataMember>Tax</DataMember><EditType>NoEdit</EditType><Fi" & _
        "lterEditType>TextBox</FilterEditType><FormatString>c2</FormatString><Key>Tax</Ke" & _
        "y><Position>9</Position><Width>61</Width></Column9><Column10 ID=""add_user""><Capt" & _
        "ion>By</Caption><DataMember>add_user</DataMember><Key>add_user</Key><Position>10" & _
        "</Position><Width>22</Width></Column10><Column11 ID=""phone_1""><Caption>Phone</Ca" & _
        "ption><DataMember>phone_1</DataMember><Key>phone_1</Key><Position>11</Position><" & _
        "Width>79</Width></Column11><Column12 ID=""cod_customer""><Caption>Customer No</Cap" & _
        "tion><DataMember>vip_code</DataMember><Key>cod_customer</Key><Position>12</Posit" & _
        "ion><Width>89</Width></Column12><Column13 ID=""type_of_form""><Caption>type_of_for" & _
        "m</Caption><DataMember>type_of_form</DataMember><Key>type_of_form</Key><Position" & _
        ">13</Position><Visible>False</Visible></Column13><Column14 ID=""id_service_center" & _
        "_before""><Caption>Drived From</Caption><DataMember>id_service_center_before</Dat" & _
        "aMember><Key>id_service_center_before</Key><Position>14</Position></Column14><Co" & _
        "lumn15 ID=""WOHaveInvoice""><Caption>WOHaveInvoice</Caption><DataMember>WOHaveInvo" & _
        "ice</DataMember><Key>WOHaveInvoice</Key><Position>15</Position><Visible>False</V" & _
        "isible></Column15><Column16 ID=""sum_amount_pay""><Caption>sum_amount_pay</Caption" & _
        "><DataMember>sum_amount_pay</DataMember><Key>sum_amount_pay</Key><Position>16</P" & _
        "osition><Visible>False</Visible></Column16></Columns><GroupCondition ID="""" /><Ke" & _
        "y>service_center_head</Key></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GrdDetail.Location = New System.Drawing.Point(0, 95)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.RecordNavigator = True
        Me.GrdDetail.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdDetail.Size = New System.Drawing.Size(629, 260)
        Me.GrdDetail.TabIndex = 2
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'DataView1
        '
        Me.DataView1.Table = Me.DsFrmFindServiceRecords1.service_center_head
        '
        'DsFrmFindServiceRecords1
        '
        Me.DsFrmFindServiceRecords1.DataSetName = "DSFrmFindServiceRecords"
        Me.DsFrmFindServiceRecords1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BEH;packet size=4096;user id=sa;data source=""."";persist security i" & _
        "nfo=True;initial catalog=TireMate_01;password=2191110"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT service_center_head.id_service_center, service_center_head.date_refer, cus" & _
        "t_trtab_main.l_name, cust_trtab_main.f_name, ser_tr_vehicle.license_no_vehicle, " & _
        "bas_vehicle_model.desc_model, cust_company.complete_name, cust_trtab_main.phone_" & _
        "1, service_center_head.add_user, cust_trtab_main.vip_code, service_center_head.T" & _
        "otal, service_center_head.type_of_form, LTRIM(RTRIM(ISNULL(service_center_head.i" & _
        "d_service_center_before, ''))) AS id_service_center_before, ser_tr_vehicle.unit_" & _
        "no FROM service_center_head LEFT OUTER JOIN ser_tr_vehicle ON service_center_hea" & _
        "d.id_vehicle = ser_tr_vehicle.id_vehicle LEFT OUTER JOIN bas_vehicle ON ser_tr_v" & _
        "ehicle.cod_vehicle = bas_vehicle.cod_vehicle LEFT OUTER JOIN bas_vehicle_model O" & _
        "N bas_vehicle.cod_make = bas_vehicle_model.cod_make AND bas_vehicle.cod_model = " & _
        "bas_vehicle_model.cod_model LEFT OUTER JOIN cust_company RIGHT OUTER JOIN cust_t" & _
        "rtab_main ON cust_company.cod_company = cust_trtab_main.cod_company ON service_c" & _
        "enter_head.cod_customer = cust_trtab_main.cod_customer"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'DAService_center_Head
        '
        Me.DAService_center_Head.SelectCommand = Me.SqlSelectCommand1
        Me.DAService_center_Head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before")})})
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.MyLabel)
        Me.Panel2.Controls.Add(Me.CmdOk)
        Me.Panel2.Controls.Add(Me.CmdExit)
        Me.Panel2.Controls.Add(Me.ChkShowOnlyOutstandingWorkOrders)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 355)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(629, 33)
        Me.Panel2.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Yellow
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(281, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 22)
        Me.Label7.TabIndex = 344
        Me.Label7.Text = "No Charge"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MyLabel
        '
        Me.MyLabel.BackColor = System.Drawing.Color.Pink
        Me.MyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MyLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MyLabel.Location = New System.Drawing.Point(98, 7)
        Me.MyLabel.Name = "MyLabel"
        Me.MyLabel.Size = New System.Drawing.Size(144, 22)
        Me.MyLabel.TabIndex = 342
        Me.MyLabel.Text = "Outstanding Work Orders"
        Me.MyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmdOk
        '
        Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmdOk.ForeColor = System.Drawing.Color.Black
        Me.CmdOk.Location = New System.Drawing.Point(447, 5)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(75, 24)
        Me.CmdOk.TabIndex = 22
        Me.CmdOk.Text = "Ok"
        '
        'CmdExit
        '
        Me.CmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmdExit.ForeColor = System.Drawing.Color.Black
        Me.CmdExit.Location = New System.Drawing.Point(543, 5)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 24)
        Me.CmdExit.TabIndex = 21
        Me.CmdExit.Text = "Exit"
        '
        'ChkShowOnlyOutstandingWorkOrders
        '
        Me.ChkShowOnlyOutstandingWorkOrders.Location = New System.Drawing.Point(22, 7)
        Me.ChkShowOnlyOutstandingWorkOrders.Name = "ChkShowOnlyOutstandingWorkOrders"
        Me.ChkShowOnlyOutstandingWorkOrders.Size = New System.Drawing.Size(104, 23)
        Me.ChkShowOnlyOutstandingWorkOrders.TabIndex = 343
        Me.ChkShowOnlyOutstandingWorkOrders.Text = "Show Only"
        '
        'FrmFindServiceRecords
        '
        Me.AcceptButton = Me.BtnFind
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(629, 388)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnTodaysInvoices)
        Me.Controls.Add(Me.BtnEstimates)
        Me.Controls.Add(Me.BtnViewRowdetail)
        Me.Controls.Add(Me.BtnWorkOrders)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmFindServiceRecords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Find Service Records"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmFindServiceRecords1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmFindServiceRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        SearchTypeVar = MainSearchTypeVar
        MakeSelectCommand()
        Call SetGridHeader()
        Call FillDataSet()
        Call AddConditionalFormatting()
    End Sub
    Private Sub MakeSelectCommand()
        Dim WhereClauseVar As String
        WhereClauseVar = " Where service_center_head.type_of_form=" & Qt(SearchTypeVar)

        If TxtLastName.Text.Trim.Length > 0 Then
            WhereClauseVar = WhereClauseVar & " AND cust_trtab_main.l_name like '%" & TxtLastName.Text.Trim & "%' "
        End If
        If PhoneNo1.Text.Trim.Length > 2 Then
            WhereClauseVar = WhereClauseVar & " AND cust_trtab_main.phone_1 like '%" & PhoneNo1.Text.Trim & "%' "
        End If
        If Dtedate_refer.Text.Trim.Length > 2 Then
            WhereClauseVar = WhereClauseVar & " AND service_center_head.date_refer like '%" & Dtedate_refer.Text.Trim & "%' "
        End If
        If TxtCompany.Text.Trim.Length > 0 Then
            WhereClauseVar = WhereClauseVar & " AND cust_company.complete_name like '%" & TxtCompany.Text.Trim & "%' "
        End If
        If TxtCustomerNo.Text.Trim.Length > 0 Then
            WhereClauseVar = WhereClauseVar & " AND cust_trtab_main.vip_code like '%" & TxtCustomerNo.Text.Trim & "%' "
        End If
        If TxtLicenseNo.Text.Trim.Length > 0 Then
            WhereClauseVar = WhereClauseVar & " AND ser_tr_vehicle.license_no_vehicle like '%" & TxtLicenseNo.Text.Trim & "%' "
        End If

        DAService_center_Head.SelectCommand.CommandText = "SELECT service_center_head.id_service_center_before,service_center_head.id_service_center, service_center_head.date_refer, cust_trtab_main.l_name, cust_trtab_main.f_name, " _
              & " ser_tr_vehicle.license_no_vehicle, bas_vehicle_model.desc_model, cust_company.complete_name, cust_trtab_main.phone_1,  " _
              & " service_center_head.add_user, cust_trtab_main.vip_code,service_center_head.Total,service_center_head.type_of_form, " _
              & " " & IIf(SearchTypeVar.ToUpper = "WO", "LTRIM(RTRIM(ISNULL(service_center_head_1.id_service_center, ''))) AS WOHaveInvoice", " '1' AS WOHaveInvoice ") & ",isnull(ser_tr_vehicle.unit_no,'') as unit_no,ISNULL(View_Is_chasier_Enterd.sum_amount_pay, 0) AS sum_amount_pay,service_center_head.Tax " _
              & " FROM         cust_company RIGHT OUTER JOIN " _
              & " service_center_head LEFT OUTER JOIN " _
              & " View_Is_chasier_Enterd ON service_center_head.id_service_center = View_Is_chasier_Enterd.id_service_center LEFT OUTER JOIN " _
              & " service_center_head service_center_head_1 ON " _
              & " service_center_head.id_service_center = service_center_head_1.id_service_center_before LEFT OUTER JOIN " _
              & " cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN " _
              & " ser_tr_vehicle ON service_center_head.id_vehicle = ser_tr_vehicle.id_vehicle LEFT OUTER JOIN " _
              & " bas_vehicle ON ser_tr_vehicle.cod_vehicle = bas_vehicle.cod_vehicle LEFT OUTER JOIN " _
              & " bas_vehicle_model ON bas_vehicle.cod_make = bas_vehicle_model.cod_make AND bas_vehicle.cod_model = bas_vehicle_model.cod_model ON  " _
              & " cust_company.cod_company = cust_trtab_main.cod_company " _
              & " " & WhereClauseVar & " " _
              & " Group by service_center_head.id_service_center_before,service_center_head.id_service_center, service_center_head.date_refer, cust_trtab_main.l_name, cust_trtab_main.f_name, " _
              & " ser_tr_vehicle.license_no_vehicle, bas_vehicle_model.desc_model, cust_company.complete_name, cust_trtab_main.phone_1,  " _
              & " service_center_head.add_user, cust_trtab_main.vip_code,service_center_head.Total,service_center_head.type_of_form " _
              & " " & IIf(SearchTypeVar.ToUpper = "WO", " , LTRIM(RTRIM(ISNULL(service_center_head_1.id_service_center, ''))) ", " ") & ",isnull(ser_tr_vehicle.unit_no,''),ISNULL(View_Is_chasier_Enterd.sum_amount_pay, 0),service_center_head.Tax " _
              & " Order by service_center_head.id_service_center desc"
    End Sub
    Private Sub FillDataSet()
        DsFrmFindServiceRecords1.service_center_head.Clear()
        DAService_center_Head.Fill(DsFrmFindServiceRecords1, "service_center_head")
    End Sub
    Private Sub BtnWorkOrders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnWorkOrders.Click
        SearchTypeVar = "WO"
        MakeSelectCommand()
        Call FillDataSet()
        Call SetGridHeader()
    End Sub
    Private Sub BtnEstimates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEstimates.Click
        SearchTypeVar = "ES"
        MakeSelectCommand()
        Call FillDataSet()
        Call SetGridHeader()
    End Sub
    Private Sub BtnTodaysInvoices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTodaysInvoices.Click
        SearchTypeVar = "IN"
        MakeSelectCommand()
        Call FillDataSet()
        Call SetGridHeader()
    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        MakeSelectCommand()
        Call FillDataSet()
    End Sub
    Private Sub BtnViewRowdetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewRowdetail.Click
        MsgBox("Service Record Detail Screen")
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        Dim ThisRowGrid As GridEXRow = GrdDetail.GetRow
        Try
            If GrdDetail.RowCount > 0 Then
                If ThisRowGrid.Cells("type_of_form").Value <> MainSearchTypeVar Then
                    MsgBox("Please Select " & MainSearchTypeVar & " records.")
                Else
                    RaiseEvent ServiceRecordFind(GrdDetail.GetRow.Cells(0).Value)
                    Me.Close()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Call GrdDetail_DoubleClick(sender, e)
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub
    Private Sub AddConditionalFormatting()
        Dim fc As GridEXFormatCondition
        Select Case SearchTypeVar
            Case "IN"
                fc = New Janus.Windows.GridEX.GridEXFormatCondition(GrdDetail.RootTable.Columns("sum_amount_pay"), ConditionOperator.Equal, 0)
                fc.FormatStyle.BackColor = Color.Pink
                GrdDetail.RootTable.FormatConditions.Add(fc)
                fc = New Janus.Windows.GridEX.GridEXFormatCondition(GrdDetail.RootTable.Columns("Total"), ConditionOperator.Equal, 0)
                fc.FormatStyle.BackColor = Color.Yellow
                GrdDetail.RootTable.FormatConditions.Add(fc)
            Case Else
                fc = New Janus.Windows.GridEX.GridEXFormatCondition(GrdDetail.RootTable.Columns("WOHaveInvoice"), ConditionOperator.Equal, "")
                fc.FormatStyle.BackColor = Color.Pink
                GrdDetail.RootTable.FormatConditions.Add(fc)
                fc = New Janus.Windows.GridEX.GridEXFormatCondition(GrdDetail.RootTable.Columns("Total"), ConditionOperator.Equal, 0)
                fc.FormatStyle.BackColor = Color.Yellow
                GrdDetail.RootTable.FormatConditions.Add(fc)
        End Select
    End Sub
    Private Sub SetGridHeader()
        Select Case SearchTypeVar
            Case "ES"
                GrdDetail.RootTable.Columns("id_service_center_before").Visible = False
            Case "WO"
                GrdDetail.RootTable.Columns("id_service_center_before").Visible = True
                GrdDetail.RootTable.Columns("id_service_center_before").Caption = "ES NO"
            Case "IN"
                GrdDetail.RootTable.Columns("id_service_center_before").Visible = True
                GrdDetail.RootTable.Columns("id_service_center_before").Caption = "WO NO"
                MyLabel.Text = "Payment On Hold"
        End Select
    End Sub
    Private Sub ChkShowOnlyOutstandingWorkOrders_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkShowOnlyOutstandingWorkOrders.CheckedChanged
        If ChkShowOnlyOutstandingWorkOrders.Checked Then
            DataView1.RowFilter = "WOHaveInvoice=''"
        Else
            DataView1.RowFilter = ""
        End If
    End Sub
End Class
