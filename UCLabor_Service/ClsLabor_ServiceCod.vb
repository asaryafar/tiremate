Imports System.Windows.Forms
Imports CommonClass
Imports UcUserOperation
Public Class ClsLabor_ServiceCod
    '------------------------------------------
    Private mConnection As System.Data.SqlClient.SqlConnection
    Private MLabor_ServiceCod As String = ""
    Private DaGeneral As New System.Data.SqlClient.SqlDataAdapter
    Private CmdSelect As New System.Data.SqlClient.SqlCommand
    Private CmdGeneral As New System.Data.SqlClient.SqlCommand
    Private DsGeneral As New DataSet
    Private Mcod_Service As String = ""
    Private MdescService As String = ""
    Private DALabor_ServiceCodSelectText As String

    '------------------------------------------
    Public Event FindLabor_ServiceCod()
    Public Event NotFindLabor_ServiceCod()
    '------------------------------------------------
    Public WithEvents DALabor_ServiceCod As New System.Data.SqlClient.SqlDataAdapter
    Private WithEvents DALabor_ServiceCodInsert As New System.Data.SqlClient.SqlCommand
    Private WithEvents DALabor_ServiceCodSelect As New System.Data.SqlClient.SqlCommand
    Private WithEvents DALabor_ServiceCodUpdate As New System.Data.SqlClient.SqlCommand
    Private WithEvents DALabor_ServiceCodDelete As New System.Data.SqlClient.SqlCommand
    Private ClsUserOperation1 As New ClsUserOperation
    Private MErrorString As String
    Private MHasError As Boolean
    Private MTaxable As Boolean
    Private MRequire_technician As Boolean
    Public Event FindError(ByVal ErrorString As String)
    '------------------------------------------
    Public ReadOnly Property Require_technician() As Boolean
        Get
            Return MRequire_technician
        End Get
    End Property
    Public ReadOnly Property Taxable() As Boolean
        Get
            Return MTaxable
        End Get
    End Property
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
            DALabor_ServiceCodInsert.Connection = Value
            DALabor_ServiceCodSelect.Connection = Value
            DALabor_ServiceCodUpdate.Connection = Value
            DALabor_ServiceCodDelete.Connection = Value
        End Set
    End Property
    Public Property Labor_ServiceCod() As String
        Get
            Return MLabor_ServiceCod
        End Get
        Set(ByVal Value As String)
            MLabor_ServiceCod = Value
        End Set
    End Property
    Public Property cod_Service() As String
        Get
            Return Mcod_Service.Trim & ""
        End Get
        Set(ByVal value As String)
            Mcod_Service = value.Trim & ""
        End Set
    End Property
    Public Property desc_Service() As String
        Get
            Return MdescService.Trim & ""
        End Get
        Set(ByVal value As String)
            MdescService = value.Trim & ""
        End Set
    End Property
    Function FindDesc(ByVal ThisLabor_ServiceCod As String, Optional ByVal ThisLaborType As String = "") As Boolean
        FindDesc = False
        If mConnection Is Nothing Then
            MsgBox("Connection On Labor_ServiceCod Not Set")
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
        CmdSelect.CommandText = "SELECT  * " _
                              & " FROM inv_tab_labor_service " _
                              & " Where cod_Service = " & Qt(ThisLabor_ServiceCod) & " " _
                              & IIf(ThisLaborType.Trim.Length = 0, "", " AND service_type=" & Qt(ThisLaborType))
        Try
            DaGeneral.Fill(DsGeneral, "t1")
            If DsGeneral.Tables("t1").Rows.Count > 0 Then
                Mcod_Service = DsGeneral.Tables("t1").Rows(0).Item("cod_Service")
                MdescService = DsGeneral.Tables("t1").Rows(0).Item("desc_Service")
                MTaxable = DsGeneral.Tables("t1").Rows(0).Item("taxable")
                MRequire_technician = DsGeneral.Tables("t1").Rows(0).Item("Require_technician")
                FindDesc = True
                RaiseEvent FindLabor_ServiceCod()
            Else
                Mcod_Service = ""
                MdescService = ""
                MTaxable = True
                MRequire_technician = False
                RaiseEvent NotFindLabor_ServiceCod()
            End If
        Catch ex As Exception
        End Try
    End Function

    Public Sub New()
        '
        Call InitDALabor_ServiceCod()

    End Sub
    Private Sub InitDALabor_ServiceCod()
        'DALabor_ServiceCod
        '
        Me.DALabor_ServiceCod.DeleteCommand = Me.DALabor_ServiceCodDelete
        Me.DALabor_ServiceCod.InsertCommand = Me.DALabor_ServiceCodInsert
        Me.DALabor_ServiceCod.SelectCommand = Me.DALabor_ServiceCodSelect
        Me.DALabor_ServiceCod.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "hes_tab_kol", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_kol", "cod_kol"), New System.Data.Common.DataColumnMapping("desc_kol", "desc_kol"), New System.Data.Common.DataColumnMapping("kind_cod_kol", "kind_cod_kol"), New System.Data.Common.DataColumnMapping("add_op", "add_op"), New System.Data.Common.DataColumnMapping("add_date", "add_date"), New System.Data.Common.DataColumnMapping("chg_op", "chg_op"), New System.Data.Common.DataColumnMapping("chg_date", "chg_date")})})
        Me.DALabor_ServiceCod.UpdateCommand = Me.DALabor_ServiceCodUpdate
        '
        'DALabor_ServiceCodDelete
        '
        Me.DALabor_ServiceCodDelete.CommandText = ""
        '
        'DALabor_ServiceCodInsert
        '
        Me.DALabor_ServiceCodInsert.CommandText = ""
        '
        'Dahes_tab_kolSelect
        '
        Me.DALabor_ServiceCodSelect.CommandText = "SELECT * " _
                      & " FROM  inv_tab_labor_service"

        DALabor_ServiceCodSelectText = Me.DALabor_ServiceCodSelect.CommandText
        '
        'DALabor_ServiceCodUpdate
        '
        Me.DALabor_ServiceCodUpdate.CommandText = ""
        '
    End Sub
    Sub AdDALabor_ServiceCod()
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
    Sub EditALabor_ServiceCod()
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
    Sub DeleteALabor_ServiceCod()
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
    Function CalculatePriceCode(ByVal ThisServiceCode As String, ByVal ThisPriceLevel As Integer, ByVal ThisStyle As String) As Decimal
        Dim SqlSelectCommand1 As New System.Data.SqlClient.SqlCommand
        SqlSelectCommand1.Connection = Connection
        CalculatePriceCode = 0
        Dim ColName As String
        Select Case ThisPriceLevel
            Case 1
                ColName = "price_level1"
            Case 2
                ColName = "price_level2"
            Case 3
                ColName = "price_level3"
            Case 4
                ColName = "price_level4"
            Case 5
                ColName = "price_level5"
            Case 6
                ColName = "price_level6"
            Case Else
                ColName = "price_level1"
        End Select
        If SqlSelectCommand1.Connection.State <> ConnectionState.Open Then
            SqlSelectCommand1.Connection.Open()
        End If
        If ThisStyle = -1 Then
            SqlSelectCommand1.CommandText = "SELECT TOP 1 " & ColName & " from inv_tab_labor_service_price where Cod_Service=" & Qt(ThisServiceCode)
        Else
            SqlSelectCommand1.CommandText = "SELECT Top 1 " & ColName & " from inv_tab_labor_service_price where Cod_Service=" & Qt(ThisServiceCode) & " AND Style=" & Qt(ThisStyle)
        End If
        Try
            CalculatePriceCode = SqlSelectCommand1.ExecuteScalar
        Catch ex As Exception
            CalculatePriceCode = 0
        End Try
    End Function
End Class
