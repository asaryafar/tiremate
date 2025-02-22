Imports System.Windows.Forms
Imports CommonClass
Public Class ClsZipCode
    '------------------------------------------
    Private mConnection As System.Data.SqlClient.SqlConnection
    Private MZipCode As String = ""
    Private DaGeneral As New System.Data.SqlClient.SqlDataAdapter
    Private CmdSelect As New System.Data.SqlClient.SqlCommand
    Private CmdGeneral As New System.Data.SqlClient.SqlCommand
    Private DsGeneral As New DataSet
    Private MCity As String = ""
    Private MState As String = ""
    Private MCodCustomer As String
    Private DAcod_vehicleSelectText As String

    '------------------------------------------
    Public Event Findcod_Vehicle()
    Public Event NotFindcod_Vehicle()
    '------------------------------------------------
    Public WithEvents DAcod_vehicle As New System.Data.SqlClient.SqlDataAdapter
    Private WithEvents DAcod_vehicleSelect As New System.Data.SqlClient.SqlCommand
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
            DAcod_vehicleSelect.Connection = Value
        End Set
    End Property
    Public Property ZipCode() As String
        Get
            Return MZipCode
        End Get
        Set(ByVal Value As String)
            MZipCode = Value
        End Set
    End Property
    Public Property City() As String
        Get
            Return MCity.Trim & ""
        End Get
        Set(ByVal value As String)
            MCity = value.Trim & ""
        End Set
    End Property
    Public Property State() As String
        Get
            Return MState.Trim & ""
        End Get
        Set(ByVal value As String)
            MState = value.Trim & ""
        End Set
    End Property
    Public Property CodCustomer() As String
        Get
            Return MCodCustomer
        End Get
        Set(ByVal Value As String)
            MCodCustomer = Value
            If Value & "" <> "" Then
                DAcod_vehicleSelect.CommandText = DAcod_vehicleSelectText + "  Where  cod_customer= " & Qt(Value)
            Else
                DAcod_vehicleSelect.CommandText = DAcod_vehicleSelectText
            End If
        End Set
    End Property
    Function FindDesc(ByVal ThisZipCode As String) As Boolean
        FindDesc = False
        If mConnection Is Nothing Then
            MsgBox("Connection Not Set")
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
        CmdSelect.CommandText = "SELECT * FROM bas_zipcode Where ZipCode = " & Qt(ThisZipCode)
        Try
            DaGeneral.Fill(DsGeneral, "t1")
            If DsGeneral.Tables("t1").Rows.Count > 0 Then
                MCity = DsGeneral.Tables("t1").Rows(0).Item("City")
                MState = DsGeneral.Tables("t1").Rows(0).Item("State")
                FindDesc = True
                RaiseEvent Findcod_Vehicle()
            Else
                MCity = ""
                MState = ""
                RaiseEvent NotFindcod_Vehicle()
            End If
        Catch ex As Exception
        End Try
    End Function

    Public Sub New()
        '
        'Call InitDAcod_vehicle()
    End Sub
    Private Sub ClearError()
        MHasError = False
        MErrorString = ""
    End Sub
End Class
