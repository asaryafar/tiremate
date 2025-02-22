Imports System.Windows.Forms
Imports CommonClass
Imports UcUserOperation
Public Class ClsReceivePayment
    '------------------------------------------
    Private mConnection As System.Data.SqlClient.SqlConnection
    Private MReferenceNo As String = ""
    Private DaGeneral As New System.Data.SqlClient.SqlDataAdapter
    Private CmdSelect As New System.Data.SqlClient.SqlCommand
    Private CmdGeneral As New System.Data.SqlClient.SqlCommand
    Private DsGeneral As New DataSet
    Private MRefrence_No As String = ""
    Private Mcod_customer As String = ""
    Private DAReferenceNoSelectText As String

    '------------------------------------------
    Public Event FindReferenceNo()
    Public Event FindReferenceNoRow(ByVal ThisRow As DataRow)

    Public Event NotFindReferenceNo()

    '------------------------------------------------
    Public WithEvents DAReferenceNo As New System.Data.SqlClient.SqlDataAdapter
    Private WithEvents DAReferenceNoInsert As New System.Data.SqlClient.SqlCommand
    Private WithEvents DAReferenceNoSelect As New System.Data.SqlClient.SqlCommand
    Private WithEvents DAReferenceNoUpdate As New System.Data.SqlClient.SqlCommand
    Private WithEvents DAReferenceNoDelete As New System.Data.SqlClient.SqlCommand
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
            DAReferenceNoInsert.Connection = Value
            DAReferenceNoSelect.Connection = Value
            DAReferenceNoUpdate.Connection = Value
            DAReferenceNoDelete.Connection = Value
        End Set
    End Property
    Public Property ReferenceNo() As String
        Get
            Return MReferenceNo
        End Get
        Set(ByVal Value As String)
            MReferenceNo = Value
        End Set
    End Property
    Public Property Refrence_No() As String
        Get
            Return MRefrence_No.Trim & ""
        End Get
        Set(ByVal value As String)
            MRefrence_No = value.Trim & ""
        End Set
    End Property
    Public Property cod_customer() As String
        Get
            Return Mcod_customer.Trim & ""
        End Get
        Set(ByVal value As String)
            Mcod_customer = value.Trim & ""
        End Set
    End Property
    Function FindDesc(ByVal ThisRefrence_No As String) As Boolean
        FindDesc = False
        If mConnection Is Nothing Then
            MsgBox("Connection On Reference No Not Set")
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
                              & " FROM Gl_receive_payment " _
                              & " Where Gl_receive_payment.Refrence_No = " & Qt(ThisRefrence_No)
        Try
            DaGeneral.Fill(DsGeneral, "t1")
            If DsGeneral.Tables("t1").Rows.Count > 0 Then
                MRefrence_No = DsGeneral.Tables("t1").Rows(0).Item("Refrence_No")
                Mcod_customer = DsGeneral.Tables("t1").Rows(0).Item("cod_customer")
                FindDesc = True
                RaiseEvent FindReferenceNo()
                RaiseEvent FindReferenceNoRow(DsGeneral.Tables("t1").Rows(0))
            Else
                MRefrence_No = ""
                Mcod_customer = ""
                RaiseEvent NotFindReferenceNo()
            End If
        Catch ex As Exception
        End Try
    End Function

    Public Sub New()
        '
        Call InitDAReferenceNo()

    End Sub
    Private Sub InitDAReferenceNo()
        'DAReferenceNo
        '
        Me.DAReferenceNo.DeleteCommand = Me.DAReferenceNoDelete
        Me.DAReferenceNo.InsertCommand = Me.DAReferenceNoInsert
        Me.DAReferenceNo.SelectCommand = Me.DAReferenceNoSelect
        Me.DAReferenceNo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "hes_tab_kol", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_kol", "cod_kol"), New System.Data.Common.DataColumnMapping("desc_kol", "desc_kol"), New System.Data.Common.DataColumnMapping("kind_cod_kol", "kind_cod_kol"), New System.Data.Common.DataColumnMapping("add_op", "add_op"), New System.Data.Common.DataColumnMapping("add_date", "add_date"), New System.Data.Common.DataColumnMapping("chg_op", "chg_op"), New System.Data.Common.DataColumnMapping("chg_date", "chg_date")})})
        Me.DAReferenceNo.UpdateCommand = Me.DAReferenceNoUpdate
        '
        'DAReferenceNoDelete
        '
        Me.DAReferenceNoDelete.CommandText = ""
        '
        'DAReferenceNoInsert
        '
        Me.DAReferenceNoInsert.CommandText = ""
        '
        'Dahes_tab_kolSelect
        '
        Me.DAReferenceNoSelect.CommandText = "SELECT * " _
                      & " FROM  Gl_receive_payment"

        DAReferenceNoSelectText = Me.DAReferenceNoSelect.CommandText
        '
        'DAReferenceNoUpdate
        '
        Me.DAReferenceNoUpdate.CommandText = ""
        '
    End Sub
    Sub AdDAReferenceNo()
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
    Sub EditAReferenceNo()
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
    Sub DeleteAReferenceNo()
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
