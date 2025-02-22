Imports UcUserOperation
Public Class ClsBaseHesabdari
    Protected mConnection As System.Data.SqlClient.SqlConnection
    Protected DaGeneral As New System.Data.SqlClient.SqlDataAdapter
    Protected CmdSelect As New System.Data.SqlClient.SqlCommand
    Protected CmdGeneral As New System.Data.SqlClient.SqlCommand
    Protected DsGeneral As New DataSet
    Protected MErrorString As String
    Protected MHasError As Boolean
    Protected FetchIt As Boolean = True
    Private ClsUserOperation1 As New ClsUserOperation
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
    Overridable Property Connection() As System.Data.SqlClient.SqlConnection
        Get
            Return mConnection
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            mConnection = Value
        End Set
    End Property
    Overridable Sub Addit()
        MsgBox("Not impliment")
    End Sub

    Overridable Sub Editit()
        MsgBox("Not impliment")
    End Sub
    Overridable Sub Deleteit()
        MsgBox("Not impliment")
    End Sub
    Public Sub ClearError()
        MHasError = False
        MErrorString = ""
    End Sub

End Class
