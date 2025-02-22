Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmCustomerVehicles
    Inherits FrmBase
    Public Cod_customerParameter As String
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
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Public WithEvents LblCompany As System.Windows.Forms.TextBox
    Public WithEvents LblName As System.Windows.Forms.TextBox
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DsFrmCustomerVehicles1 As UCCustomer.DSFrmCustomerVehicles
    Public WithEvents LblCustomer As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DASer_tr_vehicle As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LblCustomer = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblCompany = New System.Windows.Forms.TextBox
        Me.LblName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DataView1 = New System.Data.DataView
        Me.DsFrmCustomerVehicles1 = New UCCustomer.DSFrmCustomerVehicles
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DASer_tr_vehicle = New System.Data.SqlClient.SqlDataAdapter
        Me.Panel1.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmCustomerVehicles1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LblCustomer)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.LblCompany)
        Me.Panel1.Controls.Add(Me.LblName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 39)
        Me.Panel1.TabIndex = 1
        '
        'LblCustomer
        '
        Me.LblCustomer.BackColor = System.Drawing.Color.Gold
        Me.LblCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblCustomer.Location = New System.Drawing.Point(57, 8)
        Me.LblCustomer.Name = "LblCustomer"
        Me.LblCustomer.ReadOnly = True
        Me.LblCustomer.Size = New System.Drawing.Size(85, 20)
        Me.LblCustomer.TabIndex = 427
        Me.LblCustomer.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.YellowGreen
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(3, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 22)
        Me.Label2.TabIndex = 426
        Me.Label2.Text = "Customer"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCompany
        '
        Me.LblCompany.BackColor = System.Drawing.Color.Gold
        Me.LblCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblCompany.Location = New System.Drawing.Point(419, 8)
        Me.LblCompany.Name = "LblCompany"
        Me.LblCompany.ReadOnly = True
        Me.LblCompany.Size = New System.Drawing.Size(213, 20)
        Me.LblCompany.TabIndex = 425
        Me.LblCompany.Text = ""
        '
        'LblName
        '
        Me.LblName.BackColor = System.Drawing.Color.Gold
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblName.Location = New System.Drawing.Point(180, 8)
        Me.LblName.Name = "LblName"
        Me.LblName.ReadOnly = True
        Me.LblName.Size = New System.Drawing.Size(182, 20)
        Me.LblName.TabIndex = 424
        Me.LblName.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.YellowGreen
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(365, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 22)
        Me.Label1.TabIndex = 334
        Me.Label1.Text = "Company"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.YellowGreen
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(139, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 22)
        Me.Label5.TabIndex = 332
        Me.Label5.Text = "Name"
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
        "ction=""true""><Column0 ID=""Column1""><ButtonStyle>ButtonCell</ButtonStyle><ColumnT" & _
        "ype>Image</ColumnType><EditType>NoEdit</EditType><Key>Column1</Key><Position>0</" & _
        "Position><Width>19</Width></Column0><Column1 ID=""license_no_vehicle""><Caption>Li" & _
        "cense No</Caption><DataMember>license_no_vehicle</DataMember><Key>license_no_veh" & _
        "icle</Key><Position>1</Position><Width>79</Width></Column1><Column2 ID=""make_yea" & _
        "r""><Caption>Year</Caption><DataMember>make_year</DataMember><Key>make_year</Key>" & _
        "<Position>2</Position><Width>50</Width></Column2><Column3 ID=""desc_make""><Captio" & _
        "n>Make</Caption><DataMember>desc_make</DataMember><Key>desc_make</Key><Position>" & _
        "3</Position><Width>82</Width></Column3><Column4 ID=""desc_model""><Caption>Model</" & _
        "Caption><DataMember>desc_model</DataMember><Key>desc_model</Key><Position>4</Pos" & _
        "ition><Width>85</Width></Column4><Column5 ID=""current_mileage""><Caption>Mileage<" & _
        "/Caption><DataMember>Current_Mileage</DataMember><Key>current_mileage</Key><Posi" & _
        "tion>5</Position><Width>65</Width></Column5><Column6 ID=""date_refer""><Caption>Da" & _
        "te</Caption><DataMember>Current_Mileage_Date</DataMember><Key>date_refer</Key><P" & _
        "osition>6</Position><Width>72</Width></Column6><Column7 ID=""desc_color""><Caption" & _
        ">Color</Caption><DataMember>desc_color</DataMember><Key>desc_color</Key><Positio" & _
        "n>7</Position><Width>56</Width></Column7><Column8 ID=""vin""><Caption>Vin</Caption" & _
        "><DataMember>vin</DataMember><Key>vin</Key><Position>8</Position><Width>92</Widt" & _
        "h></Column8></Columns><GroupCondition ID="""" /><Key>service_center_head</Key></Ro" & _
        "otTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdDetail.GroupByBoxFormatStyle.BackColor = System.Drawing.SystemColors.Control
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GrdDetail.Location = New System.Drawing.Point(0, 40)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.RecordNavigator = True
        Me.GrdDetail.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdDetail.Size = New System.Drawing.Size(640, 348)
        Me.GrdDetail.TabIndex = 2
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'DataView1
        '
        Me.DataView1.Table = Me.DsFrmCustomerVehicles1.ser_tr_vehicle
        '
        'DsFrmCustomerVehicles1
        '
        Me.DsFrmCustomerVehicles1.DataSetName = "DSFrmCustomerVehicles"
        Me.DsFrmCustomerVehicles1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=KETABI;packet size=4096;user id=sa;initial catalog=TireMate_01;per" & _
        "sist security info=True;password=sa"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT ser_tr_vehicle.license_no_vehicle, bas_vehicle_model.desc_model, bas_vehic" & _
        "le_company.desc_make, bas_vehicle.make_year, bas_color.desc_color, ser_tr_vehicl" & _
        "e.vin, View_Ser_tr_vehicle_dtl_Current_Mileage.Current_Mileage, View_Ser_tr_vehi" & _
        "cle_dtl_Current_Mileage_Date.Current_Mileage_Date FROM ser_tr_vehicle LEFT OUTER" & _
        " JOIN View_Ser_tr_vehicle_dtl_Current_Mileage_Date ON ser_tr_vehicle.id_vehicle " & _
        "= View_Ser_tr_vehicle_dtl_Current_Mileage_Date.id_vehicle LEFT OUTER JOIN View_S" & _
        "er_tr_vehicle_dtl_Current_Mileage ON ser_tr_vehicle.id_vehicle = View_Ser_tr_veh" & _
        "icle_dtl_Current_Mileage.id_vehicle LEFT OUTER JOIN bas_vehicle ON ser_tr_vehicl" & _
        "e.cod_vehicle = bas_vehicle.cod_vehicle LEFT OUTER JOIN bas_vehicle_model ON bas" & _
        "_vehicle.cod_make = bas_vehicle_model.cod_make AND bas_vehicle.cod_model = bas_v" & _
        "ehicle_model.cod_model LEFT OUTER JOIN bas_vehicle_company ON bas_vehicle_model." & _
        "cod_make = bas_vehicle_company.cod_make LEFT OUTER JOIN bas_color ON ser_tr_vehi" & _
        "cle.cod_color = bas_color.cod_color WHERE (ser_tr_vehicle.cod_customer = @cod_cu" & _
        "stomer)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        '
        'DASer_tr_vehicle
        '
        Me.DASer_tr_vehicle.SelectCommand = Me.SqlSelectCommand1
        Me.DASer_tr_vehicle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ser_tr_vehicle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("license_no_vehicle", "license_no_vehicle"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("cod_vehicle", "cod_vehicle"), New System.Data.Common.DataColumnMapping("cod_kind_engine", "cod_kind_engine"), New System.Data.Common.DataColumnMapping("cod_color", "cod_color"), New System.Data.Common.DataColumnMapping("unit_no", "unit_no"), New System.Data.Common.DataColumnMapping("engin_designatoin_code", "engin_designatoin_code"), New System.Data.Common.DataColumnMapping("engine_vin", "engine_vin"), New System.Data.Common.DataColumnMapping("aa_id", "aa_id"), New System.Data.Common.DataColumnMapping("cod_quarts", "cod_quarts"), New System.Data.Common.DataColumnMapping("cod_oil_type", "cod_oil_type"), New System.Data.Common.DataColumnMapping("state", "state"), New System.Data.Common.DataColumnMapping("creat_date", "creat_date"), New System.Data.Common.DataColumnMapping("change_date", "change_date"), New System.Data.Common.DataColumnMapping("salvage_date", "salvage_date"), New System.Data.Common.DataColumnMapping("vehicle_active", "vehicle_active"), New System.Data.Common.DataColumnMapping("vehicle_out_service", "vehicle_out_service"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("vin", "vin")})})
        '
        'FrmCustomerVehicles
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(640, 388)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmCustomerVehicles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Customer Vehicles"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmCustomerVehicles1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmFindServiceRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        Call FillDataSet()
        LblCustomer.Text = Cod_customerParameter
    End Sub
    Private Sub FillDataSet()
        DsFrmCustomerVehicles1.ser_tr_vehicle.Clear()

        DASer_tr_vehicle.SelectCommand.Parameters("@cod_customer").Value = Cod_customerParameter
        DASer_tr_vehicle.Fill(DsFrmCustomerVehicles1, "ser_tr_vehicle")
    End Sub
    Private Sub BtnViewRowdetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call ShowDetail()
    End Sub
    Private Sub GrdDetail_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.ColumnButtonClick
        Call ShowDetail()
    End Sub
    Private Sub ShowDetail()
        Dim ThisRowGrid As GridEXRow = GrdDetail.GetRow
        If DsFrmCustomerVehicles1.ser_tr_vehicle.Rows.Count > 0 Then
            Try
                'Dim MyFrmCustomerVehicles As New UCCustomer.FrmCustomerVehicles
                'MyFrmCustomerVehicles.Cod_customerParameter = ThisRowGrid.Cells(0).Value
                'MyFrmCustomerVehicles.ShowDialog()
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class
