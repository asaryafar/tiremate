Imports CommonClass
Public Class ClsUserOperation
    Private Madd_op As Decimal
    Private Madd_Date As String
    Private Mchg_op As Decimal
    Private Mchg_date As String
    Public Property add_op(Optional ByVal ThisUser As Boolean = True) As Decimal
        Get
            If ThisUser Then
                Return PUserCod
            Else
                Return Madd_op
            End If
        End Get
        Set(ByVal Value As Decimal)
            Madd_op = Value
        End Set
    End Property
    Public Property add_date(Optional ByVal ThisDate As Boolean = True) As String
        Get
            If ThisDate Then
                Return Now
            Else
                Return Madd_Date
            End If

        End Get
        Set(ByVal Value As String)
            Madd_Date = Value
        End Set
    End Property
    Public Property chg_op(Optional ByVal ThisUser As Boolean = True) As Decimal
        Get
            If ThisUser Then
                Return PUserCod
            Else
                Return Mchg_op
            End If
        End Get
        Set(ByVal Value As Decimal)
            Mchg_op = Value
        End Set
    End Property
    Public Property chg_date(Optional ByVal ThisDate As Boolean = True) As String
        Get
            If ThisDate Then
                Return Now
            Else

                Return Mchg_date
            End If
        End Get
        Set(ByVal Value As String)
            Mchg_date = Value
        End Set
    End Property
End Class
