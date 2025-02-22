Imports CommonClass
Public Class License_No
    Inherits System.Windows.Forms.UserControl
    Dim WithEvents MyFrmSearchLicenseNo As New FrmSearchLicenseNo 'RulesFnd
    Public Event AfterFieldCodValueFind(ByVal ThisRow As DataRow)
    Private MCnn As System.Data.SqlClient.SqlConnection
    Dim ThisDs As New DataSet
    Dim Flg As Boolean = True
    Dim WithEvents MyFrmVehicle As FrmVehicle
    Dim WithEvents MyFrmVehicleQuickAdd As FrmVehicleQuickAdd
    'Shadows Event TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Private MVehicleMake As String = ""
    Private MCodVehicle As String = ""
    Private MVehicleModel As String = ""
    Private MVehicleVin As String = ""
    Private MVehicleYear As String = ""
    Public CodCustomerForFilter As String = ""
    Private CodCustomer As String = ""
    Public CodCustomerForAdd As String = ""
    Private MLicenseNoLen As Integer = LenLicenseNo
    Public CanAddNewCod As Boolean = True
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl1 overrides dispose to clean up the component list.
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
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents TxtLicenseNo As System.Windows.Forms.TextBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAlicense_no_vehicle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAId_vehicle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(License_No))
        Me.TxtLicenseNo = New System.Windows.Forms.TextBox
        Me.BtnSearch = New System.Windows.Forms.Button
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.DAlicense_no_vehicle = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAId_vehicle = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SuspendLayout()
        '
        'TxtLicenseNo
        '
        Me.TxtLicenseNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtLicenseNo.BackColor = System.Drawing.Color.LightGreen
        Me.TxtLicenseNo.Location = New System.Drawing.Point(0, 0)
        Me.TxtLicenseNo.MaxLength = 20
        Me.TxtLicenseNo.Name = "TxtLicenseNo"
        Me.TxtLicenseNo.Size = New System.Drawing.Size(76, 20)
        Me.TxtLicenseNo.TabIndex = 0
        Me.TxtLicenseNo.Text = ""
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.Location = New System.Drawing.Point(76, 0)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(24, 20)
        Me.BtnSearch.TabIndex = 1
        Me.BtnSearch.TabStop = False
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=""."";persist security " & _
        "info=True;initial catalog=TireMate_01"
        '
        'DAlicense_no_vehicle
        '
        Me.DAlicense_no_vehicle.SelectCommand = Me.SqlSelectCommand2
        Me.DAlicense_no_vehicle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ser_tr_vehicle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("license_no_vehicle", "license_no_vehicle"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("cod_vehicle", "cod_vehicle"), New System.Data.Common.DataColumnMapping("cod_kind_engine", "cod_kind_engine"), New System.Data.Common.DataColumnMapping("cod_color", "cod_color"), New System.Data.Common.DataColumnMapping("unit_no", "unit_no"), New System.Data.Common.DataColumnMapping("cod_vehicle_type", "cod_vehicle_type"), New System.Data.Common.DataColumnMapping("engin_designatoin_code", "engin_designatoin_code"), New System.Data.Common.DataColumnMapping("engine_vin", "engine_vin"), New System.Data.Common.DataColumnMapping("aa_id", "aa_id"), New System.Data.Common.DataColumnMapping("cod_quarts", "cod_quarts"), New System.Data.Common.DataColumnMapping("cod_oil_type", "cod_oil_type"), New System.Data.Common.DataColumnMapping("state", "state"), New System.Data.Common.DataColumnMapping("creat_date", "creat_date"), New System.Data.Common.DataColumnMapping("change_date", "change_date"), New System.Data.Common.DataColumnMapping("salvage_date", "salvage_date"), New System.Data.Common.DataColumnMapping("vehicle_active", "vehicle_active"), New System.Data.Common.DataColumnMapping("vehicle_out_service", "vehicle_out_service"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("vin", "vin")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT ser_tr_vehicle.license_no_vehicle, ser_tr_vehicle.cod_vehicle, ser_tr_vehi" & _
        "cle.cod_kind_engine, ser_tr_vehicle.cod_color, ser_tr_vehicle.unit_no, bas_vehic" & _
        "le.options AS cod_vehicle_type, bas_vehicle.cod_make, bas_vehicle.cod_model, ser" & _
        "_tr_vehicle.vin, bas_vehicle.make_year, bas_vehicle_model.desc_model, bas_vehicl" & _
        "e_company.desc_make, ser_tr_vehicle.cod_customer, ser_tr_vehicle.id_vehicle, bas" & _
        "_color.desc_color, inv_tab_kind_engine.desc_kind_engine FROM ser_tr_vehicle LEFT" & _
        " OUTER JOIN inv_tab_kind_engine ON ser_tr_vehicle.cod_kind_engine = inv_tab_kind" & _
        "_engine.cod_kind_engine LEFT OUTER JOIN bas_color ON ser_tr_vehicle.cod_color = " & _
        "bas_color.cod_color LEFT OUTER JOIN bas_vehicle_model INNER JOIN bas_vehicle ON " & _
        "bas_vehicle_model.cod_make = bas_vehicle.cod_make AND bas_vehicle_model.cod_mode" & _
        "l = bas_vehicle.cod_model INNER JOIN bas_vehicle_company ON bas_vehicle_model.co" & _
        "d_make = bas_vehicle_company.cod_make ON ser_tr_vehicle.cod_vehicle = bas_vehicl" & _
        "e.cod_vehicle WHERE (ser_tr_vehicle.license_no_vehicle = @license_no_vehicle) AN" & _
        "D (ser_tr_vehicle.vehicle_active = 1) ORDER BY ser_tr_vehicle.license_no_vehicle" & _
        ""
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@license_no_vehicle", System.Data.SqlDbType.VarChar, 20, "license_no_vehicle"))
        '
        'DAId_vehicle
        '
        Me.DAId_vehicle.SelectCommand = Me.SqlSelectCommand1
        Me.DAId_vehicle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ser_tr_vehicle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("license_no_vehicle", "license_no_vehicle"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("cod_vehicle", "cod_vehicle"), New System.Data.Common.DataColumnMapping("cod_kind_engine", "cod_kind_engine"), New System.Data.Common.DataColumnMapping("cod_color", "cod_color"), New System.Data.Common.DataColumnMapping("unit_no", "unit_no"), New System.Data.Common.DataColumnMapping("cod_vehicle_type", "cod_vehicle_type"), New System.Data.Common.DataColumnMapping("engin_designatoin_code", "engin_designatoin_code"), New System.Data.Common.DataColumnMapping("engine_vin", "engine_vin"), New System.Data.Common.DataColumnMapping("aa_id", "aa_id"), New System.Data.Common.DataColumnMapping("cod_quarts", "cod_quarts"), New System.Data.Common.DataColumnMapping("cod_oil_type", "cod_oil_type"), New System.Data.Common.DataColumnMapping("state", "state"), New System.Data.Common.DataColumnMapping("creat_date", "creat_date"), New System.Data.Common.DataColumnMapping("change_date", "change_date"), New System.Data.Common.DataColumnMapping("salvage_date", "salvage_date"), New System.Data.Common.DataColumnMapping("vehicle_active", "vehicle_active"), New System.Data.Common.DataColumnMapping("vehicle_out_service", "vehicle_out_service"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("vin", "vin")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT ser_tr_vehicle.license_no_vehicle, ser_tr_vehicle.cod_vehicle, ser_tr_vehi" & _
        "cle.cod_kind_engine, ser_tr_vehicle.cod_color, ser_tr_vehicle.unit_no, bas_vehic" & _
        "le.options AS cod_vehicle_type, bas_vehicle.cod_make, bas_vehicle.cod_model, ser" & _
        "_tr_vehicle.vin, bas_vehicle.make_year, bas_vehicle_model.desc_model, bas_vehicl" & _
        "e_company.desc_make, ser_tr_vehicle.cod_customer, ser_tr_vehicle.id_vehicle, bas" & _
        "_color.desc_color, inv_tab_kind_engine.desc_kind_engine FROM ser_tr_vehicle LEFT" & _
        " OUTER JOIN inv_tab_kind_engine ON ser_tr_vehicle.cod_kind_engine = inv_tab_kind" & _
        "_engine.cod_kind_engine LEFT OUTER JOIN bas_color ON ser_tr_vehicle.cod_color = " & _
        "bas_color.cod_color LEFT OUTER JOIN bas_vehicle_model INNER JOIN bas_vehicle ON " & _
        "bas_vehicle_model.cod_make = bas_vehicle.cod_make AND bas_vehicle_model.cod_mode" & _
        "l = bas_vehicle.cod_model INNER JOIN bas_vehicle_company ON bas_vehicle_model.co" & _
        "d_make = bas_vehicle_company.cod_make ON ser_tr_vehicle.cod_vehicle = bas_vehicl" & _
        "e.cod_vehicle WHERE (ser_tr_vehicle.id_vehicle = @id_vehicle) ORDER BY ser_tr_ve" & _
        "hicle.license_no_vehicle"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_vehicle", System.Data.SqlDbType.Int, 4, "id_vehicle"))
        '
        'License_No
        '
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxtLicenseNo)
        Me.Name = "License_No"
        Me.Size = New System.Drawing.Size(101, 20)
        Me.ResumeLayout(False)

    End Sub

#End Region
    ReadOnly Property VehicleYear() As String
        Get
            Return MVehicleYear
        End Get
    End Property
    ReadOnly Property CodVehicle() As String
        Get
            Return MCodVehicle
        End Get
    End Property
    ReadOnly Property VehicleMake() As String
        Get
            Return MVehicleMake
        End Get
    End Property
    ReadOnly Property VehicleModel() As String
        Get
            Return MVehicleModel
        End Get
    End Property
    ReadOnly Property VehicleVin() As String
        Get
            Return MVehicleVin
        End Get
    End Property
    Public Property LicenseNoLen() As Integer
        Get
            Return MLicenseNoLen
        End Get
        Set(ByVal Value As Integer)
            MLicenseNoLen = LenLicenseNo
            TxtLicenseNo.MaxLength = LenLicenseNo
        End Set
    End Property
    Public Property Cnn() As System.Data.SqlClient.SqlConnection
        Get
            Return MCnn
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            MCnn = Value
            DAlicense_no_vehicle.SelectCommand.Connection = MCnn
            DAId_vehicle.SelectCommand.Connection = MCnn
        End Set
    End Property
    Shadows Event TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Dim MFieldCodValue As Int64 = 0
    Public Property FieldCodValue() As Int64
        Get
            Return MFieldCodValue
        End Get
        Set(ByVal Value As Int64)
            Try
                MFieldCodValue = Value
                If MFieldCodValue = 0 Then
                    TxtLicenseNo.Clear()
                    ''''''''''''' add by ketabi to fire AfterFieldCodValueFind Event
                    If Cnn.ConnectionString = PConnectionString Then
                        Call FindValue()
                    End If
                Else
                    DAId_vehicle.SelectCommand.Parameters("@id_vehicle").Value = Value
                    ThisDs.Clear()
                    DAId_vehicle.Fill(ThisDs, "ser_tr_vehicle")
                    If ThisDs.Tables("ser_tr_vehicle").Rows.Count - 1 >= 0 Then
                        Flg = False
                        TxtLicenseNo.Text = ThisDs.Tables("ser_tr_vehicle").Rows(0).Item("license_no_vehicle") & ""
                        Call FindValue()
                        Flg = True
                    Else
                        MFieldCodValue = 0
                    End If
                End If
            Catch ex As Exception
                ' MsgBox(ex.ToString)
            End Try
        End Set
    End Property
    Public Overrides Property Text() As String
        Get
            Return TxtLicenseNo.Text
        End Get
        Set(ByVal Value As String)
            TxtLicenseNo.Text = Value
        End Set
    End Property
    Public Property TxtBackColor() As System.Drawing.Color
        Get
            Return TxtLicenseNo.BackColor
        End Get
        Set(ByVal Value As System.Drawing.Color)
            TxtLicenseNo.BackColor = Value
        End Set
    End Property
    Public Property TxtForeColor() As System.Drawing.Color
        Get
            Return TxtLicenseNo.ForeColor
        End Get
        Set(ByVal Value As System.Drawing.Color)
            TxtLicenseNo.ForeColor = Value
        End Set
    End Property
    Public Property TxtRightToLeft() As System.Windows.Forms.RightToLeft
        Get
            Return TxtLicenseNo.RightToLeft
        End Get
        Set(ByVal Value As System.Windows.Forms.RightToLeft)
            TxtLicenseNo.RightToLeft = Value
        End Set
    End Property
    Private Sub TxtLicenseNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtLicenseNo.TextChanged
        RaiseEvent TextChanged(sender, e)
    End Sub
    Private Sub CustomerName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        TxtLicenseNo.Focus()
    End Sub
    Private Sub License_No_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        'Call AfterLeave()
        'End Sub
        If Flg Then
            Flg = False
            Dim Thisdr As DataRow
            ThisDs.Clear()
            DAlicense_no_vehicle.SelectCommand.Parameters("@license_no_vehicle").Value = TxtLicenseNo.Text.Trim
            DAlicense_no_vehicle.Fill(ThisDs, "ser_tr_vehicle")
            If ThisDs.Tables("ser_tr_vehicle").Rows.Count > 0 Then
                MFieldCodValue = ThisDs.Tables("ser_tr_vehicle").Rows(0).Item("id_vehicle")
                Call FindValue()
                '' œ— «Ì‰Ã« ﬂ‰ —·  €ÌÌ— ‘„«—Â „«‘Ì‰ Ê ’«Õ» ¬‰ ’Ê—  „ÌêÌ—œ
                'If ClsLicenseNo1.Vehicle_Make.Trim = "AAAAAAAAAAAAAAAA" Then
                '    Dim c1 As New FrmWhatDoForMenu
                '    c1.BtnLeftText = "Cancel"
                '    c1.BtnRightText = "Transfer Owner"
                '    c1.ShowFarMsg("The Lincence number" & TxtLicenseNo.Text & " is already in use for the following customer and vehicle : " & vbCrLf & vbCrLf & Me.LicenseNo & vbCrLf & Me.VehicleYear & Me.VehicleMake & Me.VehicleModel)
                '    Select Case c1.DialogResult
                '        Case DialogResult.Cancel
                '        Case DialogResult.Yes ' Transfer
                '            MsgBox("Transfer")
                '    End Select
                '    TxtLicenseNo.Focus()
                'End If

                If Trim(ThisDs.Tables("ser_tr_vehicle").Rows(0).Item("cod_customer")).ToUpper <> CodCustomerForFilter.Trim.ToUpper And CodCustomerForFilter.Trim.Length > 0 Then
                    MsgBox("The Car Dosn't belong to this Person!!!!!")
                End If

            Else
                If TxtLicenseNo.Text.Length > 0 And CanAddNewCod Then
                    MFieldCodValue = 0
                    Dim c1 As New FrmWhatDoForMenu
                    c1.BtnLeftText = "Re-Enter"
                    c1.BtnCenterText = "Quick Add"
                    c1.BtnRightText = "Detail Add"
                    c1.ShowFarMsg(TxtLicenseNo.Text & "  not found in Vehicle Table")
                    Select Case c1.DialogResult
                        Case DialogResult.Cancel
                            TxtLicenseNo.Clear()
                        Case DialogResult.OK ' add Detail vehicle
                            MyFrmVehicle = New FrmVehicle
                            MyFrmVehicle.LicenceNoForQuickAdd = TxtLicenseNo.Text & ""
                            MyFrmVehicle.QuickAddFlag = True
                            MyFrmVehicle.CustomerNoForQuickAdd = CodCustomerForFilter & ""
                            MyFrmVehicle.StartPosition = FormStartPosition.CenterParent
                            MyFrmVehicle.ShowDialog()
                        Case DialogResult.Yes ' add Quick vehicle
                            MyFrmVehicleQuickAdd = New FrmVehicleQuickAdd
                            MyFrmVehicleQuickAdd.LicenceCod = TxtLicenseNo.Text & ""
                            MyFrmVehicleQuickAdd.CustomerCod = CodCustomerForFilter & ""
                            MyFrmVehicleQuickAdd.StartPosition = FormStartPosition.CenterParent
                            MyFrmVehicleQuickAdd.ShowDialog()
                    End Select
                    Flg = True
                    TxtLicenseNo.Focus()
                End If
            End If
            Flg = True
        End If


        ' «Ì‰ Œÿ ¬Œ—Ì‰  €ÌÌ— œ— «Ì‰ »—‰«„Â «”  œ—  «—ÌŒ 27/08/84

        Call AfterLeave()




    End Sub
    Sub AfterLeave()
        Dim Thisdr As DataRow
        ThisDs.Clear()


        DAlicense_no_vehicle.SelectCommand.Parameters("@license_no_vehicle").Value = TxtLicenseNo.Text.Trim
        DAlicense_no_vehicle.Fill(ThisDs, "ser_tr_vehicle")
        If ThisDs.Tables("ser_tr_vehicle").Rows.Count > 0 Then
            MFieldCodValue = ThisDs.Tables("ser_tr_vehicle").Rows(0).Item("id_vehicle")
            MVehicleMake = ThisDs.Tables("ser_tr_vehicle").Rows(0).Item("desc_make") & ""
            MCodVehicle = ThisDs.Tables("ser_tr_vehicle").Rows(0).Item("cod_vehicle") & ""
            MVehicleModel = ThisDs.Tables("ser_tr_vehicle").Rows(0).Item("desc_model") & ""
            MVehicleVin = ThisDs.Tables("ser_tr_vehicle").Rows(0).Item("vin") & ""
            MVehicleYear = ThisDs.Tables("ser_tr_vehicle").Rows(0).Item("make_year") & ""
            CodCustomer = ThisDs.Tables("ser_tr_vehicle").Rows(0).Item("cod_customer") & ""
            RaiseEvent AfterFieldCodValueFind(ThisDs.Tables("ser_tr_vehicle").Rows(0))
        Else
            MFieldCodValue = 0
            MVehicleMake = ""
            MCodVehicle = ""
            MVehicleModel = ""
            MVehicleVin = ""
            MVehicleYear = ""
            CodCustomer = ""
            RaiseEvent AfterFieldCodValueFind(Nothing)
            'TxtLicenseNo.Focus()
        End If
    End Sub
    '---------------------------------
    Private Sub TxtLicenseNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtLicenseNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call AfterLeave()
        End If
        If e.KeyCode = Keys.F4 And Not (e.Modifiers = Keys.Alt) Then
            ShowSearch()
        End If

    End Sub
    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        ShowSearch()
    End Sub
    Sub ShowSearch()
        MyFrmSearchLicenseNo = New FrmSearchLicenseNo
        MyFrmSearchLicenseNo.CodCustomerForAddNew = CodCustomerForAdd
        If CodCustomerForFilter.Trim.Length > 0 Then
            MyFrmSearchLicenseNo.FilterCustomerCod = CodCustomerForFilter
        End If
        MyFrmSearchLicenseNo.ShowDialog()
        MyFrmSearchLicenseNo = Nothing
    End Sub
    Private Sub MyFrmSearchLicenseNo_VehicleFind(ByVal ThisVehicleId As Double, ByVal ThisCodVehicle As String, ByVal ThisVehicleMake As String, ByVal ThisVehicleModel As String, ByVal ThisVehicleVin As String, ByVal ThisVehicleYear As String) Handles MyFrmSearchLicenseNo.VehicleFind
        FieldCodValue = ThisVehicleId
        RaiseEvent AfterFieldCodValueFind(ThisDs.Tables("ser_tr_vehicle").Rows(0))
    End Sub
    Sub FindValue()
        Dim Thisdr As DataRow
        ThisDs.Clear()
        If MFieldCodValue = 0 Then
            DAlicense_no_vehicle.SelectCommand.Parameters("@license_no_vehicle").Value = TxtLicenseNo.Text.Trim
            DAlicense_no_vehicle.Fill(ThisDs, "ser_tr_vehicle")
            If ThisDs.Tables("ser_tr_vehicle").Rows.Count > 0 Then
               
                RaiseEvent AfterFieldCodValueFind(ThisDs.Tables("ser_tr_vehicle").Rows(0))
            Else
                RaiseEvent AfterFieldCodValueFind(Nothing)
                TxtLicenseNo.Clear()
            End If
        Else
            DAId_vehicle.SelectCommand.Parameters("@id_vehicle").Value = MFieldCodValue
            DAId_vehicle.Fill(ThisDs, "ser_tr_vehicle")
            If ThisDs.Tables("ser_tr_vehicle").Rows.Count > 0 Then
                RaiseEvent AfterFieldCodValueFind(ThisDs.Tables("ser_tr_vehicle").Rows(0))
            Else
                RaiseEvent AfterFieldCodValueFind(Nothing)
                TxtLicenseNo.Clear()
            End If
        End If
    End Sub
    Private Sub MyFrmVehicleQuickAdd_AfterSave(ByVal CodLicence As String) Handles MyFrmVehicleQuickAdd.AfterSave
        TxtLicenseNo.Text = CodLicence
    End Sub

    Private Sub License_No_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
