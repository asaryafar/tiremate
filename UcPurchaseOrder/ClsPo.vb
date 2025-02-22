Imports System.Windows.Forms
Imports CommonClass
Imports UcUserOperation
'writen by faraji 
' plese before changing talk to me


Public Class ClsPo
#Region "ClsDefine"
    Private mConnection As System.Data.SqlClient.SqlConnection
    Private DaGeneral As New System.Data.SqlClient.SqlDataAdapter
    Private CmdSelect As New System.Data.SqlClient.SqlCommand
    Private CmdGeneral As New System.Data.SqlClient.SqlCommand
    Private DsGeneral As New DataSet
    Private DAVendorNoSelectText As String

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
    Public Function MakeNewPoCod() As String
        Dim i As Integer
        Dim ValMakeNewcod As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select Max(po_no) as Max_cod from Inv_purchase_order_head"
            MakeNewPoCod = Trim(CmdGeneral.ExecuteScalar)
            ValMakeNewcod = GetVal(MakeNewPoCod, 6)
            If ValMakeNewcod > 0 Then
                i = Len(ValMakeNewcod)
            Else
                i = 0
            End If
            If MakeNewPoCod.Length >= i Then
                MakeNewPoCod = Mid(MakeNewPoCod, 1, Len(MakeNewPoCod) - i) + Getcod(Str((Int(Val(ValMakeNewcod)) + 1)).Trim, Len(ValMakeNewcod))
            End If
            If MakeNewPoCod.Trim.Length > 6 Then
                MakeNewPoCod = "PO0001"
            End If
        Catch ex As Exception
            MakeNewPoCod = "PO0001"
        Finally
            CmdGeneral.Connection.Close()
        End Try
    End Function
    Public Function LastRecord() As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "Select top 1 Po_no as Max from Inv_purchase_order_head  ORDER BY po_no DESC"
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
        Try
            CmdGeneral.CommandText = "Delete From Inv_purchase_order_dtl Where po_no=" & Qt(ThisRef_no)
            CmdGeneral.ExecuteNonQuery()
            CmdGeneral.CommandText = "Delete From Inv_purchase_order_head Where po_no=" & Qt(ThisRef_no)
            Try
                CmdGeneral.ExecuteNonQuery()
                DeleteThis = True
                MsgFar("The selected record was deleted")
            Catch ex1 As Exception
                DeleteThis = False
                MsgFar("Can't Delete This Record")
            Finally
                CmdGeneral.Connection.Close()
            End Try

        Catch ex As Exception

        End Try
    End Function
    Function PFirstRecord() As String
        Dim TXTRef_NoTmp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Top 1 po_no From Inv_purchase_order_head  Order BY po_no ASC"
        PFirstRecord = CmdGeneral.ExecuteScalar() & ""
        CmdGeneral.Connection.Close()
    End Function

    Function PLastRecord() As String
        Dim TXTRef_NoTmp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Top 1 po_no From Inv_purchase_order_head  Order BY po_no Des"
        PLastRecord = CmdGeneral.ExecuteScalar() & ""
        CmdGeneral.Connection.Close()
    End Function

    Function Pprevious(ByVal FromThis As String) As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Top 1 po_no From Inv_purchase_order_head WHERE  po_no < " & Qt(FromThis) & " Order BY po_no Desc"
        Pprevious = CmdGeneral.ExecuteScalar() & ""
        CmdGeneral.Connection.Close()
    End Function

    Function PNext(ByVal FromThis As String) As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Top 1 po_no From Inv_purchase_order_head WHERE  po_no > " & Qt(FromThis) & " Order BY po_no Desc"
        PNext = CmdGeneral.ExecuteScalar() & ""
        CmdGeneral.Connection.Close()
    End Function

End Class
