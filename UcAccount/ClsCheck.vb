Imports System.Windows.Forms
Imports CommonClass
Public Class ClsCheck

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
            CmdGeneral.CommandText = "Select Max(id_check) as Max_cod from Bank_Check"
            MakeNewRefCod = CDec("0" & Trim(CmdGeneral.ExecuteScalar) & "") + 1
        Catch ex As Exception
            MakeNewRefCod = "1"
        Finally
            CmdGeneral.Connection.Close()
        End Try
    End Function
    Public Function LastRecord(ByVal ThisId_Bank As Integer) As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "Select top 1 id_check as Max from Bank_Check where id_bank = " & thisId_Bank & "   ORDER BY id_check DESC"
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
    Function PFirstRecord(ByVal thisId_Bank As Integer) As String
        Dim TXTRef_NoTmp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Top 1 id_check From bank_check  where  id_bank = " & thisId_Bank & "  Order BY id_check ASC"
        PFirstRecord = CmdGeneral.ExecuteScalar() & ""
        CmdGeneral.Connection.Close()
    End Function

    Function PLastRecord(ByVal ThisId_bank As Integer) As String
        Dim TXTRef_NoTmp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Top 1 id_check From bank_check where id_bank = " & ThisId_bank & "   Order  BY id_check Des"
        PLastRecord = CmdGeneral.ExecuteScalar() & ""
        CmdGeneral.Connection.Close()
    End Function

    Function Pprevious(ByVal FromThis As String, ByVal Thisid_bank As Integer) As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Top 1 id_check From bank_check  WHERE  id_check < " & Qt(FromThis) & " and id_bank = " & Thisid_bank & " Order BY id_check Desc"
        Pprevious = CmdGeneral.ExecuteScalar() & ""
        CmdGeneral.Connection.Close()
    End Function

    Function PNext(ByVal FromThis As String, ByVal Thisid_bank As Integer) As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Top 1 id_Check From Bank_check WHERE  id_Check > " & Qt(FromThis) & " and id_bank = " & Thisid_bank & " Order BY id_Check "
        PNext = CmdGeneral.ExecuteScalar() & ""
        CmdGeneral.Connection.Close()
    End Function

    Public Function LastNoCheck(ByVal ThisIdBank As Decimal) As String
        Dim i As Integer
        Dim ValMakeNewcod As String
        Dim FirstCheckNo As String = "1"
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            'CmdGeneral.CommandText = "Select start_check_no as Max_cod from bas_Banks"
            'FirstCheckNo = Trim(CmdGeneral.ExecuteScalar)
            'CmdGeneral.CommandText = "Select Max(no_of_check) as Max_cod from Bank_check Where Id_Bank=" & ThisIdBank
            CmdGeneral.CommandText = "Select  next_check_no as Max_cod from bas_banks Where Id_Bank=" & ThisIdBank
            LastNoCheck = Trim(CmdGeneral.ExecuteScalar)
            '-----------------------------'
            ValMakeNewcod = GetVal(LastNoCheck, 20)
            If ValMakeNewcod > 0 Then
                LastNoCheck = ValMakeNewcod + 1
            Else
                LastNoCheck = "1"
            End If
        Catch ex As Exception
            LastNoCheck = "1"
        Finally
            CmdGeneral.Connection.Close()
        End Try
    End Function
    Public Function FindDefaultBank() As Integer
        CmdGeneral.CommandText = "Select top 1 id_bank From  bas_banks where default_bank = 1 "
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        FindDefaultBank = 0
        Try
            FindDefaultBank = CmdGeneral.ExecuteScalar()
        Catch ex As Exception
            FindDefaultBank = 0
        End Try

    End Function


End Class
