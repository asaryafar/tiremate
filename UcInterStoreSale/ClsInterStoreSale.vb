Imports CommonClass
Public Class ClsInterStoreSale
#Region "ClsDefine"
    Private mConnection As System.Data.SqlClient.SqlConnection
    Private DaGeneral As New System.Data.SqlClient.SqlDataAdapter
    Private CmdSelect As New System.Data.SqlClient.SqlCommand
    Private CmdGeneral As New System.Data.SqlClient.SqlCommand
    Private DsGeneral As New DataSet
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
    Private MTypeOfForm As String

    Public Property TypeOfForm() As String
        Get
            Return MTypeOfForm
        End Get
        Set(ByVal Value As String)
            MTypeOfForm = Value
        End Set
    End Property
    Public Function MakeNewCod() As String
        Dim i As Integer
        Dim ValMakeNewcod As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select Max(ID_sales_transfer) from inv_salse_Transfer_head WHERE type_sales_transfer = " & TypeOfForm
            MakeNewCod = Trim(CmdGeneral.ExecuteScalar)
            ValMakeNewcod = GetVal(MakeNewCod, 10)
            If ValMakeNewcod > 0 Then
                i = Len(ValMakeNewcod)
            Else
                i = 0
            End If
            If MakeNewCod.Length >= i Then
                MakeNewCod = Mid(MakeNewCod, 1, Len(MakeNewCod) - i) + Getcod(Str((Int(Val(ValMakeNewcod)) + 1)).Trim, Len(ValMakeNewcod))
            End If
            If MakeNewCod.Trim.Length > 10 Then
                If TypeOfForm = "1" Then
                    MakeNewCod = "IS00000001"
                Else
                    MakeNewCod = "IT00000001"
                End If
            End If
        Catch ex As Exception
            If TypeOfForm = "1" Then
                MakeNewCod = "IS00000001"
            Else
                MakeNewCod = "IT00000001"
            End If
        Finally
            CmdGeneral.Connection.Close()
        End Try
    End Function


    Public Function LastRecord() As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "Select top 1 ID_sales_transfer as Max from inv_salse_Transfer_head where type_sales_transfer=  " & TypeOfForm & " ORDER BY ID_sales_transfer DESC"
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
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "Delete From inv_salse_Transfer_head Where ID_sales_transfer=" & Qt(ThisRef_no)
        Try
            CmdGeneral.ExecuteNonQuery()
            DeleteThis = True
            MsgFar("The selected record was deleted")
        Catch ex As Exception
            DeleteThis = False
            MsgFar("Can't Delete This Record")
        Finally
            CmdGeneral.Connection.Close()
        End Try

    End Function
    Function PFirstRecord() As String
        Dim TXTRef_NoTmp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Top 1 ID_sales_transfer From inv_salse_Transfer_head   where type_sales_transfer=  " & TypeOfForm & " Order BY ID_sales_transfer ASC"
        PFirstRecord = CmdGeneral.ExecuteScalar() & ""
        CmdGeneral.Connection.Close()
    End Function

    Function PLastRecord() As String
        Dim TXTRef_NoTmp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Top 1 ID_sales_transfer From inv_salse_Transfer_head  where type_sales_transfer=  " & TypeOfForm & " Order BY ID_sales_transfer Desc"
        PLastRecord = CmdGeneral.ExecuteScalar() & ""
        CmdGeneral.Connection.Close()
    End Function

    Function Pprevious(ByVal FromThis As String) As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Top 1 ID_sales_transfer From inv_salse_Transfer_head WHERE  ID_sales_transfer < " & Qt(FromThis) & " and type_sales_transfer=  " & TypeOfForm & " Order BY ID_sales_transfer Desc"
        Pprevious = CmdGeneral.ExecuteScalar() & ""
        CmdGeneral.Connection.Close()
    End Function

    Function PNext(ByVal FromThis As String) As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Top 1 ID_sales_transfer From inv_salse_Transfer_head WHERE  ID_sales_transfer > " & Qt(FromThis) & " and type_sales_transfer=  " & TypeOfForm & " Order BY ID_sales_transfer asc"
        PNext = CmdGeneral.ExecuteScalar() & ""
        CmdGeneral.Connection.Close()
    End Function

End Class
