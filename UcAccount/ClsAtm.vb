Imports CommonClass

Public Class ClsAtm
#Region "ClsDefine"
    Private mConnection As System.Data.SqlClient.SqlConnection
    Private DaGeneral As New System.Data.SqlClient.SqlDataAdapter
    Private CmdSelect As New System.Data.SqlClient.SqlCommand
    Private CmdGeneral As New System.Data.SqlClient.SqlCommand
    Private DsGeneral As New DataSet
    '   Private DAVendorNoSelectText As String
#End Region
    Property Connection() As System.Data.SqlClient.SqlConnection
        Get
            Return mConnection
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            mConnection = Value
            CmdGeneral.Connection = mConnection
        End Set
    End Property
    Public Function MakeNewRefCod() As String
        Dim i As Integer
        Dim ValMakeNewcod As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select Max(id_Atm) as Max_cod from Bank_Atm"
            MakeNewRefCod = CDec("0" & Trim(CmdGeneral.ExecuteScalar) & "") + 1
        Catch ex As Exception
            MakeNewRefCod = "1"
        Finally
            CmdGeneral.Connection.Close()
        End Try
    End Function

    Public Function LastRecord() As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "Select top 1 id_ATM as Max from Bank_ATm  ORDER BY id_ATM DESC"
        Try
            LastRecord = Trim(CmdGeneral.ExecuteScalar & "")
        Catch ex As Exception
            LastRecord = ""
        End Try
        If IsNothing(LastRecord) Then
            LastRecord = ""
        End If
        CmdGeneral.Connection.Close()
    End Function
    ' End Function
    Public Function DeleteThis(ByVal ThisRef_no As String) As Boolean
        'If CmdGeneral.Connection.State <> ConnectionState.Open Then
        '    CmdGeneral.Connection.Open()
        'End If
        'CmdGeneral.CommandText = "Delete From Inv_Receive_Products_head Where id_receive_ref=" & ThisRef_no
        'Try
        '    CmdGeneral.ExecuteNonQuery()
        '    DeleteThis = True
        '    MsgFar("The selected record was deleted")
        'Catch ex As Exception
        '    DeleteThis = False
        '    MsgFar("Can't Delete This Record")
        'Finally
        '    CmdGeneral.Connection.Close()
        'End Try

    End Function
    Function PFirstRecord() As String
        Dim TXTRef_NoTmp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Top 1 id_atm From bank_atm Order BY id_atm ASC"
        PFirstRecord = CmdGeneral.ExecuteScalar() & ""
        CmdGeneral.Connection.Close()
    End Function
    Function PLastRecord() As String
        Dim TXTRef_NoTmp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Top 1 id_atm From bank_atm Order  BY id_atm Des"
        PLastRecord = CmdGeneral.ExecuteScalar() & ""
        CmdGeneral.Connection.Close()
    End Function

    Function Pprevious(ByVal FromThis As String) As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Top 1 id_atm From bank_atm  WHERE  id_atm< " & Qt(FromThis) & " Order BY id_atm Desc"
        Pprevious = CmdGeneral.ExecuteScalar() & ""
        CmdGeneral.Connection.Close()
    End Function

    Function PNext(ByVal FromThis As String) As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Top 1 id_atm From Bank_atm WHERE  id_atm > " & Qt(FromThis) & " Order BY id_atm Desc"
        PNext = CmdGeneral.ExecuteScalar() & ""
        CmdGeneral.Connection.Close()
    End Function
End Class
