Imports System.Windows.Forms
Imports CommonClass
Imports UcUserOperation
Public Class ClsLicenseNo
    '------------------------------------------
    Private mConnection As System.Data.SqlClient.SqlConnection
    Private MLicenseNo As String = ""
    Private DaGeneral As New System.Data.SqlClient.SqlDataAdapter
    Private CmdSelect As New System.Data.SqlClient.SqlCommand
    Private CmdGeneral As New System.Data.SqlClient.SqlCommand
    Private DsGeneral As New DataSet
    Private MCod_Vehicle As String = ""
    Private MVehicleMake As String = ""
    Private MVehicleModel As String = ""
    Private MVehicleVin As String = ""
    Private MVehicleYear As String = ""
    Private MCodCustomer As String
    Private DALicenseNoSelectText As String

    '------------------------------------------
    Public Event FindLicenseNo()
    Public Event NotFindLicenseNo()
    '------------------------------------------------
    Public WithEvents DALicenseNo As New System.Data.SqlClient.SqlDataAdapter
    Private WithEvents DALicenseNoInsert As New System.Data.SqlClient.SqlCommand
    Private WithEvents DALicenseNoSelect As New System.Data.SqlClient.SqlCommand
    Private WithEvents DALicenseNoUpdate As New System.Data.SqlClient.SqlCommand
    Private WithEvents DALicenseNoDelete As New System.Data.SqlClient.SqlCommand
    Private ClsUserOperation1 As New ClsUserOperation
    Private MErrorString As String
    Private MHasError As Boolean
    Public Event FindError(ByVal ErrorString As String)

    '------------------------------------------
    Public ReadOnly Property HasError() As String
        Get
            Return MHasError
        End Get
    End Property
    Public ReadOnly Property ErrorString() As String
        Get
            Return MErrorString
        End Get
    End Property
    Property Connection() As System.Data.SqlClient.SqlConnection
        Get
            Return mConnection
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            mConnection = Value
            DALicenseNoInsert.Connection = Value
            DALicenseNoSelect.Connection = Value
            DALicenseNoUpdate.Connection = Value
            DALicenseNoDelete.Connection = Value
        End Set
    End Property
    Public Property LicenseNo() As String
        Get
            Return MLicenseNo
        End Get
        Set(ByVal Value As String)
            MLicenseNo = Value
        End Set
    End Property
    Public Property Cod_Vehicle() As String
        Get
            Return MCod_Vehicle.Trim & ""
        End Get
        Set(ByVal value As String)
            MCod_Vehicle = value.Trim & ""
        End Set
    End Property
    Public Property Vehicle_Make() As String
        Get
            Return MVehicleMake.Trim & ""
        End Get
        Set(ByVal value As String)
            MVehicleMake = value.Trim & ""
        End Set
    End Property
    Public Property Vehicle_Model() As String
        Get
            Return MVehicleModel.Trim & ""
        End Get
        Set(ByVal value As String)
            MVehicleModel = value.Trim & ""
        End Set
    End Property
    Public Property Vehicle_Vin() As String
        Get
            Return MVehicleVin.Trim & ""
        End Get
        Set(ByVal value As String)
            MVehicleVin = value.Trim & ""
        End Set
    End Property
    Public Property Vehicle_Year() As String
        Get
            Return MVehicleYear.Trim & ""
        End Get
        Set(ByVal value As String)
            MVehicleYear = value.Trim & ""
        End Set
    End Property
    Public Property CodCustomer() As String
        Get
            Return MCodCustomer
        End Get
        Set(ByVal Value As String)
            MCodCustomer = Value
            If Value & "" <> "" Then
                DALicenseNoSelect.CommandText = DALicenseNoSelectText + "  Where  cod_customer= " & Qt(Value)
            Else
                DALicenseNoSelect.CommandText = DALicenseNoSelectText
            End If
        End Set
    End Property

    Function FindDesc(ByVal ThisLicenseNo As String) As Boolean
        FindDesc = False
        If mConnection Is Nothing Then
            MsgBox("Connection On LicenseNo Not Set")
            Exit Function
        End If
        DsGeneral.Clear()
        DaGeneral.SelectCommand = CmdSelect
        If mConnection.ConnectionString <> PConnectionString Then
            If mConnection.State <> ConnectionState.Closed Then
                mConnection.Close()
            End If
            mConnection.ConnectionString = PConnectionString
        End If
        DaGeneral.SelectCommand.Connection = mConnection
        CmdSelect.CommandText = "SELECT ser_tr_vehicle.license_no_vehicle, ser_tr_vehicle.cod_vehicle, ser_tr_vehicle.cod_kind_engine, ser_tr_vehicle.cod_color, ser_tr_vehicle.unit_no, " _
                              & " bas_vehicle.Options as cod_vehicle_type, bas_vehicle.cod_make, bas_vehicle.cod_model, ser_tr_vehicle.vin, bas_vehicle.make_year, " _
                              & " bas_vehicle_model.desc_model, bas_vehicle_company.desc_make, ser_tr_vehicle.cod_customer " _
                              & " FROM  ser_tr_vehicle LEFT OUTER JOIN " _
                              & " bas_vehicle_model INNER JOIN " _
                              & " bas_vehicle ON bas_vehicle_model.cod_make = bas_vehicle.cod_make AND bas_vehicle_model.cod_model = bas_vehicle.cod_model INNER JOIN " _
                              & " bas_vehicle_company ON bas_vehicle_model.cod_make = bas_vehicle_company.cod_make ON ser_tr_vehicle.cod_vehicle = bas_vehicle.cod_vehicle " _
                              & " Where ser_tr_vehicle.license_no_vehicle = " & Qt(ThisLicenseNo)
        Try
            DaGeneral.Fill(DsGeneral, "t1")
            If DsGeneral.Tables("t1").Rows.Count > 0 Then
                MCod_Vehicle = DsGeneral.Tables("t1").Rows(0).Item("cod_vehicle")
                MVehicleMake = DsGeneral.Tables("t1").Rows(0).Item("desc_make")
                MVehicleModel = DsGeneral.Tables("t1").Rows(0).Item("desc_model")
                MVehicleVin = DsGeneral.Tables("t1").Rows(0).Item("vin")
                MVehicleYear = DsGeneral.Tables("t1").Rows(0).Item("make_year")
                FindDesc = True
                RaiseEvent FindLicenseNo()
            Else
                MCod_Vehicle = ""
                MVehicleMake = ""
                MVehicleModel = ""
                MVehicleVin = ""
                MVehicleYear = ""
                RaiseEvent NotFindLicenseNo()
            End If
        Catch ex As Exception
        End Try
    End Function

    Public Sub New()
        '
        Call InitDALicenseNo()

    End Sub
    Private Sub InitDALicenseNo()
        'DALicenseNo
        '
        Me.DALicenseNo.DeleteCommand = Me.DALicenseNoDelete
        Me.DALicenseNo.InsertCommand = Me.DALicenseNoInsert
        Me.DALicenseNo.SelectCommand = Me.DALicenseNoSelect
        Me.DALicenseNo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "hes_tab_kol", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_kol", "cod_kol"), New System.Data.Common.DataColumnMapping("desc_kol", "desc_kol"), New System.Data.Common.DataColumnMapping("kind_cod_kol", "kind_cod_kol"), New System.Data.Common.DataColumnMapping("add_op", "add_op"), New System.Data.Common.DataColumnMapping("add_date", "add_date"), New System.Data.Common.DataColumnMapping("chg_op", "chg_op"), New System.Data.Common.DataColumnMapping("chg_date", "chg_date")})})
        Me.DALicenseNo.UpdateCommand = Me.DALicenseNoUpdate
        '
        'DALicenseNoDelete
        '
        Me.DALicenseNoDelete.CommandText = ""
        '
        'DALicenseNoInsert
        '
        Me.DALicenseNoInsert.CommandText = ""
        '
        'Dahes_tab_kolSelect
        '
        Me.DALicenseNoSelect.CommandText = "SELECT ser_tr_vehicle.license_no_vehicle, ser_tr_vehicle.cod_vehicle, ser_tr_vehicle.cod_kind_engine, ser_tr_vehicle.cod_color, ser_tr_vehicle.unit_no, " _
                      & " bas_vehicle.Options as cod_vehicle_type, bas_vehicle.cod_make, bas_vehicle.cod_model, ser_tr_vehicle.vin, bas_vehicle.make_year, " _
                      & " bas_vehicle_model.desc_model, bas_vehicle_company.desc_make, ser_tr_vehicle.cod_customer " _
                      & " FROM  ser_tr_vehicle LEFT OUTER JOIN " _
                      & " bas_vehicle_model INNER JOIN " _
                      & " bas_vehicle ON bas_vehicle_model.cod_make = bas_vehicle.cod_make AND bas_vehicle_model.cod_model = bas_vehicle.cod_model INNER JOIN " _
                      & " bas_vehicle_company ON bas_vehicle_model.cod_make = bas_vehicle_company.cod_make ON ser_tr_vehicle.cod_vehicle = bas_vehicle.cod_vehicle "

        DALicenseNoSelectText = Me.DALicenseNoSelect.CommandText
        '
        'DALicenseNoUpdate
        '
        Me.DALicenseNoUpdate.CommandText = ""
        '
    End Sub
    Sub AdDALicenseNo()
        'Call ClearError()
        'Try
        '    CmdGeneral.CommandText = "INSERT INTO cod_customer(cod_anbar, name_anbar) VALUES (" _
        '    & Qt(cod_customer) & ", " & Qt(Item_Name) & ")"
        '    CmdGeneral.Connection = Connection

        '    If CmdGeneral.Connection.State <> ConnectionState.Open Then CmdGeneral.Connection.Open()
        '    CmdGeneral.ExecuteScalar()
        'Catch ex As Exception
        '    MHasError = True
        '    MErrorString = ex.ToString
        '    RaiseEvent FindError(MErrorString)
        'End Try
    End Sub
    Sub EditALicenseNo()
        'Call ClearError()
        'Try
        '    CmdGeneral.CommandText = " Update cod_customer set name_anbar = " & Qt(Item_Name) & " Where cod_anbar =" & Qt(cod_customer)
        '    CmdGeneral.Connection = Connection
        '    If CmdGeneral.Connection.State <> ConnectionState.Open Then CmdGeneral.Connection.Open()
        '    CmdGeneral.ExecuteScalar()
        'Catch ex As Exception
        '    MHasError = True
        '    MErrorString = ex.ToString
        '    RaiseEvent FindError(MErrorString)
        'End Try
    End Sub
    Sub DeleteALicenseNo()
        'Call ClearError()
        'Try
        '    CmdGeneral.CommandText = "Delete From cod_customer Where cod_anbar =" & Qt(cod_customer)
        '    CmdGeneral.Connection = Connection
        '    If CmdGeneral.Connection.State <> ConnectionState.Open Then CmdGeneral.Connection.Open()
        '    CmdGeneral.ExecuteScalar()
        'Catch ex As Exception
        '    MHasError = True
        '    MErrorString = ex.ToString
        '    RaiseEvent FindError(MErrorString)
        'End Try
    End Sub
    Private Sub ClearError()
        MHasError = False
        MErrorString = ""
    End Sub
End Class
