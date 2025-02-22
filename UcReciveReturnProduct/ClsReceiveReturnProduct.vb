Imports System.Windows.Forms
Imports CommonClass
Imports UcUserOperation
'writen by faraji 
' plese before changing talk to me


Public Class ClsReceiveReturnProduct
#Region "ClsDefine"
    Private mConnection As System.Data.SqlClient.SqlConnection
    Private DaGeneral As New System.Data.SqlClient.SqlDataAdapter
    Private CmdSelect As New System.Data.SqlClient.SqlCommand
    Private CmdGeneral As New System.Data.SqlClient.SqlCommand
    Private DsGeneral As New DataSet
    Private DAVendorNoSelectText As String
    Private MBillCredit As String = "1"
    Public Property BillCredit() As String
        Get
            Return MBillCredit
        End Get
        Set(ByVal Value As String)
            MBillCredit = Value
        End Set
    End Property


#End Region
    Dim LenInvReceiveCod As Integer = 7
    Public Event FindThisRefNoForThisVendore(ByVal ThisRow As DataRow)
    Public Event NotFindThisRefNoForThisVendore()

    Property Connection() As System.Data.SqlClient.SqlConnection
        Get
            Return mConnection
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            mConnection = Value
            CmdGeneral.Connection = mConnection
        End Set
    End Property
    Public Function MakeNewReceiveCod() As String
        Dim i As Integer
        Dim ValMakeNewcod As String
        Try
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.CommandText = "Select len(id_receive_ref) as Max_cod from Inv_Receive_Products_head WHERE substring(id_receive_ref,1,2)='IR'"
            LenInvReceiveCod = Trim(CmdGeneral.ExecuteScalar)


            CmdGeneral.CommandText = "Select Max(id_receive_ref) as Max_cod from Inv_Receive_Products_head WHERE substring(id_receive_ref,1,2)='IR'"
            MakeNewReceiveCod = Trim(CmdGeneral.ExecuteScalar)
            ValMakeNewcod = GetVal(MakeNewReceiveCod, LenInvReceiveCod)
            If ValMakeNewcod > 0 Then
                i = Len(ValMakeNewcod)
            Else
                i = 0
            End If
            If MakeNewReceiveCod.Length >= i Then
                MakeNewReceiveCod = Mid(MakeNewReceiveCod, 1, Len(MakeNewReceiveCod) - i) + Getcod(Str((Int(Val(ValMakeNewcod)) + 1)).Trim, Len(ValMakeNewcod))
            End If
            If MakeNewReceiveCod.Trim.Length > LenInvReceiveCod Then
                MakeNewReceiveCod = "IR0001"
            End If
        Catch ex As Exception
            MakeNewReceiveCod = "IR0001"
        Finally
            CmdGeneral.Connection.Close()
        End Try
    End Function
    Public Function LastRecord() As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "Select top 1 id_receive_ref as Max from Inv_Receive_Products_head  where bill_credit = " & BillCredit & " ORDER BY id_receive_ref DESC"
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
        '        CmdGeneral.CommandText = "Select top 1 id_vendor_credit_head FROM GL_vendor_credit WHERE id_receive_ref =" & Qt(ThisRef_no)
        If Not IsPassTHisInventoryByPayBill(ThisRef_no) Then
            If DeleteGlVendorReceiveRef(ThisRef_no) Then
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                Try
                    CmdGeneral.CommandText = "Delete From Inv_Receive_Products_head Where id_receive_ref=" & Qt(ThisRef_no)
                    Try
                        CmdGeneral.ExecuteNonQuery()
                        DeleteThis = True
                        MsgFar("The selected record was deleted")
                    Catch ex As Exception
                        DeleteThis = False
                        MsgFar("Can't Delete This Record")
                    End Try

                Catch ex As Exception
                    DeleteThis = False
                    MsgFar("Can't Delete This Record")
                Finally
                    CmdGeneral.Connection.Close()

                End Try
            Else
                MsgFar("Can't Delete This Inventory Return !!")
            End If
        Else
            MsgFar("Can't Delete This Inventory Return !!")
        End If

    End Function
    Function IsPassTHisInventoryByPayBill(ByVal ThisRef_no As String) As Boolean
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "Select top 1 id_vendor_credit_head FROM GL_vendor_credit WHERE id_receive_ref =" & Qt(ThisRef_no)
        Try
            IsPassTHisInventoryByPayBill = Not (CmdGeneral.ExecuteScalar & "" = "")
        Catch ex As Exception
            IsPassTHisInventoryByPayBill = False
        Finally
            CmdGeneral.Connection.Close()

        End Try


    End Function
    Function DeleteGlVendorReceiveRef(ByVal ThisRef_no As String) As Boolean
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "Delete FROM GL_vendor_credit WHERE id_receive_ref =" & Qt(ThisRef_no) & " and    id_vendor_credit_head is null"
        'CmdGeneral.ExecuteNonQuery()
        Try
            CmdGeneral.ExecuteNonQuery()
            DeleteGlVendorReceiveRef = True
        Catch ex As Exception
            DeleteGlVendorReceiveRef = False
        Finally
            CmdGeneral.Connection.Close()

        End Try

    End Function


    Function PFirstRecord() As String
        Dim TXTRef_NoTmp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Top 1 id_receive_ref From Inv_Receive_Products_head   where bill_credit = " & Qt(BillCredit) & " Order BY id_receive_ref ASC"
        PFirstRecord = CmdGeneral.ExecuteScalar() & ""
        CmdGeneral.Connection.Close()
    End Function

    Function PLastRecord() As String
        Dim TXTRef_NoTmp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Top 1 id_receive_ref From Inv_Receive_Products_head  where bill_credit = " & Qt(BillCredit) & "  Order BY id_receive_ref Desc"
        PLastRecord = CmdGeneral.ExecuteScalar() & ""
        CmdGeneral.Connection.Close()
    End Function

    Function Pprevious(ByVal FromThis As String) As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Top 1 id_receive_ref From Inv_Receive_Products_head WHERE  id_receive_ref < " & Qt(FromThis) & " and  bill_credit = " & Qt(BillCredit) & " Order BY id_receive_ref Desc"
        Pprevious = CmdGeneral.ExecuteScalar() & ""
        CmdGeneral.Connection.Close()
    End Function

    Function PNext(ByVal FromThis As String) As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Top 1 id_receive_ref From Inv_Receive_Products_head WHERE  id_receive_ref > " & Qt(FromThis) & " and bill_credit = " & Qt(BillCredit) & " Order BY id_receive_ref asc"
        PNext = CmdGeneral.ExecuteScalar() & ""
        CmdGeneral.Connection.Close()
    End Function
    Public Function ThisRefNoForThisVendore(ByVal ThisCodVendore As String, ByVal ThisRefNo As String) As Boolean
        ThisRefNoForThisVendore = False
        DsGeneral.Clear()
        DaGeneral.SelectCommand = CmdSelect
        CmdSelect.Connection = Connection
        CmdSelect.CommandText = "Select * from  Inv_Receive_Products_head Where Cod_vendor =" & Qt(ThisCodVendore) & " And Vendor_ref_no = " & Qt(ThisRefNo)
        DaGeneral.Fill(DsGeneral)
        If DsGeneral.Tables(0).Rows.Count > 0 Then
            ThisRefNoForThisVendore = True
            RaiseEvent FindThisRefNoForThisVendore(DsGeneral.Tables(0).Rows(0))
        Else
            RaiseEvent NotFindThisRefNoForThisVendore()
        End If
    End Function




End Class
