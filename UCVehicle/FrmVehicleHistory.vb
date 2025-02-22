Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmVehicleHistory
    Inherits FrmBase
    Public Id_VehicleParameter As String
    Dim FilterTypeVar As String = ""
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
    Friend WithEvents BtnViewRowdetail As System.Windows.Forms.Button
    Friend WithEvents BtnAllTransactions As System.Windows.Forms.Button
    Friend WithEvents BtnInvoices As System.Windows.Forms.Button
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents DAservice_center_head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmVehicleHistory1 As UCVehicle.DSFrmVehicleHistory
    Public WithEvents LblMake As System.Windows.Forms.TextBox
    Public WithEvents LblLicenceNo As System.Windows.Forms.TextBox
    Public WithEvents LblModel As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents LblName As System.Windows.Forms.TextBox
    Public WithEvents LblCompany As System.Windows.Forms.TextBox
    Friend WithEvents DaUsers As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents CnnUserMDB As System.Data.OleDb.OleDbConnection
    Friend WithEvents BtnReturns As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmVehicleHistory))
        Me.BtnAllTransactions = New System.Windows.Forms.Button
        Me.BtnInvoices = New System.Windows.Forms.Button
        Me.BtnReturns = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LblCompany = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.LblName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.LblModel = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblMake = New System.Windows.Forms.TextBox
        Me.LblLicenceNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.DataView1 = New System.Data.DataView
        Me.DsFrmVehicleHistory1 = New UCVehicle.DSFrmVehicleHistory
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.BtnViewRowdetail = New System.Windows.Forms.Button
        Me.DAservice_center_head = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.CnnUserMDB = New System.Data.OleDb.OleDbConnection
        Me.DaUsers = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.Panel1.SuspendLayout()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFrmVehicleHistory1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAllTransactions
        '
        Me.BtnAllTransactions.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAllTransactions.Location = New System.Drawing.Point(5, 4)
        Me.BtnAllTransactions.Name = "BtnAllTransactions"
        Me.BtnAllTransactions.Size = New System.Drawing.Size(112, 23)
        Me.BtnAllTransactions.TabIndex = 3
        Me.BtnAllTransactions.Text = "All Transactions"
        '
        'BtnInvoices
        '
        Me.BtnInvoices.BackColor = System.Drawing.SystemColors.Control
        Me.BtnInvoices.Location = New System.Drawing.Point(126, 4)
        Me.BtnInvoices.Name = "BtnInvoices"
        Me.BtnInvoices.Size = New System.Drawing.Size(112, 23)
        Me.BtnInvoices.TabIndex = 4
        Me.BtnInvoices.Text = "Invoices"
        '
        'BtnReturns
        '
        Me.BtnReturns.BackColor = System.Drawing.SystemColors.Control
        Me.BtnReturns.Location = New System.Drawing.Point(247, 4)
        Me.BtnReturns.Name = "BtnReturns"
        Me.BtnReturns.Size = New System.Drawing.Size(112, 23)
        Me.BtnReturns.TabIndex = 5
        Me.BtnReturns.Text = "Returns"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LblCompany)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.LblName)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LblModel)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.LblMake)
        Me.Panel1.Controls.Add(Me.LblLicenceNo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(607, 63)
        Me.Panel1.TabIndex = 1
        '
        'LblCompany
        '
        Me.LblCompany.BackColor = System.Drawing.Color.Gold
        Me.LblCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblCompany.Location = New System.Drawing.Point(367, 34)
        Me.LblCompany.Name = "LblCompany"
        Me.LblCompany.ReadOnly = True
        Me.LblCompany.Size = New System.Drawing.Size(231, 20)
        Me.LblCompany.TabIndex = 431
        Me.LblCompany.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.YellowGreen
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(311, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 22)
        Me.Label4.TabIndex = 430
        Me.Label4.Text = "Company"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblName
        '
        Me.LblName.BackColor = System.Drawing.Color.Gold
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblName.Location = New System.Drawing.Point(76, 34)
        Me.LblName.Name = "LblName"
        Me.LblName.ReadOnly = True
        Me.LblName.Size = New System.Drawing.Size(231, 20)
        Me.LblName.TabIndex = 429
        Me.LblName.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.YellowGreen
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 22)
        Me.Label3.TabIndex = 428
        Me.Label3.Text = "Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblModel
        '
        Me.LblModel.BackColor = System.Drawing.Color.Gold
        Me.LblModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblModel.Location = New System.Drawing.Point(450, 8)
        Me.LblModel.Name = "LblModel"
        Me.LblModel.ReadOnly = True
        Me.LblModel.Size = New System.Drawing.Size(118, 20)
        Me.LblModel.TabIndex = 427
        Me.LblModel.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.YellowGreen
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(411, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 22)
        Me.Label2.TabIndex = 426
        Me.Label2.Text = "Model"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblMake
        '
        Me.LblMake.BackColor = System.Drawing.Color.Gold
        Me.LblMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblMake.Location = New System.Drawing.Point(266, 8)
        Me.LblMake.Name = "LblMake"
        Me.LblMake.ReadOnly = True
        Me.LblMake.Size = New System.Drawing.Size(118, 20)
        Me.LblMake.TabIndex = 425
        Me.LblMake.Text = ""
        '
        'LblLicenceNo
        '
        Me.LblLicenceNo.BackColor = System.Drawing.Color.Gold
        Me.LblLicenceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LblLicenceNo.Location = New System.Drawing.Point(76, 8)
        Me.LblLicenceNo.Name = "LblLicenceNo"
        Me.LblLicenceNo.ReadOnly = True
        Me.LblLicenceNo.Size = New System.Drawing.Size(133, 20)
        Me.LblLicenceNo.TabIndex = 424
        Me.LblLicenceNo.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.YellowGreen
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(227, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 22)
        Me.Label1.TabIndex = 334
        Me.Label1.Text = "Make"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.YellowGreen
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(7, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 22)
        Me.Label5.TabIndex = 332
        Me.Label5.Text = "Licence No"
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
        "icle</Key><Position>1</Position><Visible>False</Visible><Width>79</Width></Colum" & _
        "n1><Column2 ID=""id_service_center""><Caption>Reference No</Caption><TypeNameEmpty" & _
        "StringValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMem" & _
        "ber>id_service_center</DataMember><Key>id_service_center</Key><Position>2</Posit" & _
        "ion><Width>93</Width></Column2><Column3 ID=""date_refer""><Caption>Date</Caption><" & _
        "DataMember>date_refer</DataMember><FormatString>MM/dd/yyyy</FormatString><Key>da" & _
        "te_refer</Key><Position>3</Position><Width>86</Width></Column3><Column4 ID=""Tota" & _
        "l""><Caption>Amount</Caption><DataMember>Total</DataMember><FormatString>C2</Form" & _
        "atString><Key>Total</Key><Position>4</Position><TextAlignment>Far</TextAlignment" & _
        "><Width>98</Width></Column4><Column5 ID=""desc_make""><Caption>Make</Caption><Data" & _
        "Member>desc_make</DataMember><Key>desc_make</Key><Position>5</Position><Visible>" & _
        "False</Visible><Width>82</Width></Column5><Column6 ID=""desc_model""><Caption>Mode" & _
        "l</Caption><DataMember>desc_model</DataMember><Key>desc_model</Key><Position>6</" & _
        "Position><Visible>False</Visible><Width>85</Width></Column6><Column7 ID=""current" & _
        "_mileage""><Caption>Mileage</Caption><DataMember>Current_Mileage</DataMember><Key" & _
        ">current_mileage</Key><Position>7</Position><Width>71</Width></Column7><Column8 " & _
        "ID=""add_user""><Caption>By</Caption><DataMember>add_user_Name</DataMember><Key>ad" & _
        "d_user</Key><Position>8</Position><Width>92</Width></Column8><Column9 ID=""type_o" & _
        "f_form""><Caption>type_of_form</Caption><DataMember>type_of_form</DataMember><Key" & _
        ">type_of_form</Key><Position>9</Position><Visible>False</Visible></Column9><Colu" & _
        "mn10 ID=""cust_comment""><Caption>Cust Comment</Caption><DataMember>cust_comment</" & _
        "DataMember><EditType>NoEdit</EditType><Key>cust_comment</Key><Position>10</Posit" & _
        "ion><Width>422</Width></Column10></Columns><GroupCondition ID="""" /><Key>service_" & _
        "center_head</Key></RootTable></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GrdDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GrdDetail.GroupByBoxFormatStyle.BackColor = System.Drawing.SystemColors.Control
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GrdDetail.Location = New System.Drawing.Point(0, 95)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.RecordNavigator = True
        Me.GrdDetail.RepeatHeaders = Janus.Windows.GridEX.InheritableBoolean.False
        Me.GrdDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True
        Me.GrdDetail.Size = New System.Drawing.Size(607, 293)
        Me.GrdDetail.TabIndex = 2
        Me.GrdDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation
        '
        'DataView1
        '
        Me.DataView1.Table = Me.DsFrmVehicleHistory1.service_center_head
        '
        'DsFrmVehicleHistory1
        '
        Me.DsFrmVehicleHistory1.DataSetName = "DSFrmVehicleHistory"
        Me.DsFrmVehicleHistory1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=Tiremate_02"
        '
        'BtnViewRowdetail
        '
        Me.BtnViewRowdetail.Image = CType(resources.GetObject("BtnViewRowdetail.Image"), System.Drawing.Image)
        Me.BtnViewRowdetail.Location = New System.Drawing.Point(368, 4)
        Me.BtnViewRowdetail.Name = "BtnViewRowdetail"
        Me.BtnViewRowdetail.Size = New System.Drawing.Size(24, 24)
        Me.BtnViewRowdetail.TabIndex = 23
        '
        'DAservice_center_head
        '
        Me.DAservice_center_head.SelectCommand = Me.SqlCommand1
        Me.DAservice_center_head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT service_center_head.id_service_center, service_center_head.date_refer, cus" & _
        "t_trtab_main.l_name, cust_trtab_main.f_name, ser_tr_vehicle.license_no_vehicle, " & _
        "cust_company.complete_name, cust_trtab_main.phone_1, service_center_head.add_use" & _
        "r, cust_trtab_main.vip_code, service_center_head.Total, service_center_head.type" & _
        "_of_form, ser_tr_vehicle_dtl.current_mileage, service_center_head.cust_comment F" & _
        "ROM service_center_head INNER JOIN ser_tr_vehicle_dtl ON service_center_head.id_" & _
        "service_center = ser_tr_vehicle_dtl.id_service_center LEFT OUTER JOIN ser_tr_veh" & _
        "icle ON service_center_head.id_vehicle = ser_tr_vehicle.id_vehicle LEFT OUTER JO" & _
        "IN cust_company RIGHT OUTER JOIN cust_trtab_main ON cust_company.cod_company = c" & _
        "ust_trtab_main.cod_company ON service_center_head.cod_customer = cust_trtab_main" & _
        ".cod_customer WHERE (service_center_head.type_of_form = 'IN' OR service_center_h" & _
        "ead.type_of_form = 'RT') AND (service_center_head.id_vehicle = @id_vehicle) ORDE" & _
        "R BY dbo.ChangeDate(service_center_head.date_refer)"
        Me.SqlCommand1.Connection = Me.Cnn
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_vehicle", System.Data.SqlDbType.Int, 4, "id_vehicle"))
        '
        'CnnUserMDB
        '
        Me.CnnUserMDB.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\TireMate\TireMate.mdb;Persist Sec" & _
        "urity Info=True;Jet OLEDB:Database Password=5332"
        '
        'DaUsers
        '
        Me.DaUsers.SelectCommand = Me.OleDbSelectCommand2
        Me.DaUsers.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Users", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("DefaultStoreNo", "DefaultStoreNo"), New System.Data.Common.DataColumnMapping("DefaultYear", "DefaultYear"), New System.Data.Common.DataColumnMapping("UserActiveFalg", "UserActiveFalg"), New System.Data.Common.DataColumnMapping("UserFamily", "UserFamily"), New System.Data.Common.DataColumnMapping("UserGroupId", "UserGroupId"), New System.Data.Common.DataColumnMapping("UserId", "UserId"), New System.Data.Common.DataColumnMapping("UserLogin", "UserLogin"), New System.Data.Common.DataColumnMapping("UserName", "UserName"), New System.Data.Common.DataColumnMapping("UserPassword", "UserPassword")})})
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT Users.UserId, Users.UserLogin FROM (Users INNER JOIN UserGroup ON Users.Us" & _
        "erGroupId = UserGroup.UserGroupId) WHERE (Users.UserActiveFalg <> 0) AND (UserGr" & _
        "oup.GroupActiveFlag <> 0)"
        Me.OleDbSelectCommand2.Connection = Me.CnnUserMDB
        '
        'FrmVehicleHistory
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(607, 388)
        Me.Controls.Add(Me.BtnViewRowdetail)
        Me.Controls.Add(Me.BtnReturns)
        Me.Controls.Add(Me.BtnInvoices)
        Me.Controls.Add(Me.BtnAllTransactions)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GrdDetail)
        Me.Name = "FrmVehicleHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Vehicle History"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFrmVehicleHistory1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmFindServiceRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        Try
            CnnUserMDB.ConnectionString = PConnectionStringForUserMdb
        Catch ex As Exception
        End Try
        Call FillDataSet()
    End Sub
    Private Sub FillDataSet()

        DsFrmVehicleHistory1.Users.Clear()
        DaUsers.Fill(DsFrmVehicleHistory1.Users)

        DsFrmVehicleHistory1.service_center_head.Clear()

        DAservice_center_head.SelectCommand.Parameters("@Id_Vehicle").Value = Id_VehicleParameter
        DAservice_center_head.Fill(DsFrmVehicleHistory1, "service_center_head")

        If DsFrmVehicleHistory1.service_center_head.Rows.Count > 0 Then
            Dim i As Integer
            For i = 0 To DsFrmVehicleHistory1.service_center_head.Rows.Count - 1
                Try
                    DsFrmVehicleHistory1.service_center_head.Rows(i).Item("add_user_Name") = DsFrmVehicleHistory1.Users.FindByUserId(DsFrmVehicleHistory1.service_center_head.Rows(i).Item("add_user")).Item("UserLogin") & ""
                Catch ex As Exception
                End Try
            Next
        End If
    End Sub
    Private Sub BtnViewRowdetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewRowdetail.Click
        Call ShowDetail()
    End Sub
    Private Sub GrdDetail_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.ColumnButtonClick
        Call ShowDetail()
    End Sub
    Private Sub BtnAllTransactions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAllTransactions.Click
        FilterTypeVar = ""
        MakeFiltering()
    End Sub
    Private Sub BtnInvoices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInvoices.Click
        FilterTypeVar = "type_of_form='IN'"
        MakeFiltering()
    End Sub
    Private Sub BtnReturns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReturns.Click
        FilterTypeVar = "type_of_form='RT'"
        MakeFiltering()
    End Sub
    Private Sub MakeFiltering()
        DataView1.RowFilter = FilterTypeVar
    End Sub
    Private Sub ShowDetail()
        Dim Currentrow As GridEXRow = GrdDetail.GetRow
        Try
            Select Case Currentrow.Cells("type_of_form").Value & ""
                Case "IN", "RT"
                    If GrdDetail.RowCount > 0 Then
                        Dim MyFrmShowWorkOrder As New WorkOrderUtility.FrmShowWorkOrder
                        MyFrmShowWorkOrder.TypeOfForm = Currentrow.Cells("type_of_form").Value ' IN or RT
                        MyFrmShowWorkOrder.TxtRef.Text = Currentrow.Cells("id_service_center").Value & ""
                        MyFrmShowWorkOrder.StartPosition = FormStartPosition.CenterScreen
                        MyFrmShowWorkOrder.Show()
                    End If
            End Select
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GrdDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdDetail.DoubleClick
        Call ShowDetail()
    End Sub
End Class
