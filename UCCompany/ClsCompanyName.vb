Imports System.Windows.Forms
Imports CommonClass
Imports UcUserOperation
Public Class ClsCompanyName
    '------------------------------------------
    Private mConnection As System.Data.SqlClient.SqlConnection
    Private Mcod_company As String = ""
    Private DaGeneral As New System.Data.SqlClient.SqlDataAdapter
    Private CmdSelect As New System.Data.SqlClient.SqlCommand
    Private CmdGeneral As New System.Data.SqlClient.SqlCommand
    Private DsGeneral As New DataSet
    Private Mabbreviation_name As String = ""
    Private Mcomplete_name As String = ""
    Private DAcod_companySelectText As String

    '------------------------------------------
    Public Event Findcod_company()
    Public Event NotFindcod_company()
    '------------------------------------------------
    Public WithEvents DAcod_company As New System.Data.SqlClient.SqlDataAdapter
    Private WithEvents DAcod_companyInsert As New System.Data.SqlClient.SqlCommand
    Private WithEvents DAcod_companySelect As New System.Data.SqlClient.SqlCommand
    Private WithEvents DAcod_companyUpdate As New System.Data.SqlClient.SqlCommand
    Private WithEvents DAcod_companyDelete As New System.Data.SqlClient.SqlCommand
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
            DAcod_companyInsert.Connection = Value
            DAcod_companySelect.Connection = Value
            DAcod_companyUpdate.Connection = Value
            DAcod_companyDelete.Connection = Value
        End Set
    End Property
    Public Property cod_company() As String
        Get
            Return Mcod_company
        End Get
        Set(ByVal Value As String)
            Mcod_company = Value
        End Set
    End Property
    Public Property abbreviation_name() As String
        Get
            Return Mabbreviation_name.Trim & ""
        End Get
        Set(ByVal value As String)
            Mabbreviation_name = value.Trim & ""
        End Set
    End Property
    Public Property complete_name() As String
        Get
            Return Mcomplete_name.Trim & ""
        End Get
        Set(ByVal value As String)
            Mcomplete_name = value.Trim & ""
            If value & "" <> "" Then
                DAcod_companySelect.CommandText = DAcod_companySelectText + "  Where  complete_name= " & Qt(value)
            Else
                DAcod_companySelect.CommandText = DAcod_companySelectText
            End If
        End Set
    End Property
    Function FindCode(ByVal ThiscompanyName As String, ByVal kindOfFind As Integer) As Boolean
        'kindOfFind=1 Ì⁄‰Ì Ã” ÃÊÌ ‰«„
        'kindOfFind=2 Ì⁄‰Ì Ã” ÃÊÌ ﬂœ
        FindCode = False
        If mConnection Is Nothing Then
            'MsgBox("Connection On cod_company Not Set")
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
        If kindOfFind = 1 Then
            CmdSelect.CommandText = "SELECT * FROM cust_company Where cust_company.complete_name = " & Qt(ThiscompanyName)
        Else
            CmdSelect.CommandText = "SELECT * FROM cust_company Where cust_company.cod_company = " & Qt(Mcod_company)
        End If
        Try
            DaGeneral.Fill(DsGeneral, "t1")
            If DsGeneral.Tables("t1").Rows.Count > 0 Then
                Mabbreviation_name = DsGeneral.Tables("t1").Rows(0).Item("abbreviation_name")
                Mcomplete_name = DsGeneral.Tables("t1").Rows(0).Item("complete_name")
                Mcod_company = DsGeneral.Tables("t1").Rows(0).Item("cod_company")
                FindCode = True
                RaiseEvent Findcod_company()
            Else
                Mabbreviation_name = ""
                Mcomplete_name = ""
                Mcod_company = ""
                RaiseEvent NotFindcod_company()
            End If
        Catch ex As Exception
        End Try
    End Function

    Public Sub New()
        '
        Call InitDAcod_company()

    End Sub
    Private Sub InitDAcod_company()
        'DAcod_company
        '
        Me.DAcod_company.DeleteCommand = Me.DAcod_companyDelete
        Me.DAcod_company.InsertCommand = Me.DAcod_companyInsert
        Me.DAcod_company.SelectCommand = Me.DAcod_companySelect
        Me.DAcod_company.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "hes_tab_kol", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_kol", "cod_kol"), New System.Data.Common.DataColumnMapping("desc_kol", "desc_kol"), New System.Data.Common.DataColumnMapping("kind_cod_kol", "kind_cod_kol"), New System.Data.Common.DataColumnMapping("add_op", "add_op"), New System.Data.Common.DataColumnMapping("add_date", "add_date"), New System.Data.Common.DataColumnMapping("chg_op", "chg_op"), New System.Data.Common.DataColumnMapping("chg_date", "chg_date")})})
        Me.DAcod_company.UpdateCommand = Me.DAcod_companyUpdate
        '
        'DAcod_companyDelete
        '
        Me.DAcod_companyDelete.CommandText = ""
        '
        'DAcod_companyInsert
        '
        Me.DAcod_companyInsert.CommandText = ""
        '
        'Dahes_tab_kolSelect
        '
        Me.DAcod_companySelect.CommandText = "SELECT *  FROM  cust_company "

        DAcod_companySelectText = Me.DAcod_companySelect.CommandText
        '
        'DAcod_companyUpdate
        '
        Me.DAcod_companyUpdate.CommandText = ""
        '
    End Sub
    Sub AdDAcod_company()
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
    Sub EditAcod_company()
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
    Sub DeleteAcod_company()
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
