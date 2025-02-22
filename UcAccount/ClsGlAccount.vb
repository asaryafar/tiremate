Imports CommonClass
Public Class ClsGlAccount
#Region "ClsDefine"
    Private mConnection As System.Data.SqlClient.SqlConnection
    Private DaGeneral As New System.Data.SqlClient.SqlDataAdapter
    Private CmdSelect As New System.Data.SqlClient.SqlCommand
    Private CmdGeneral As New System.Data.SqlClient.SqlCommand
    Private DsGeneral As New DataSet
    '   Private DAVendorNoSelectText As String
#End Region
    Public Event FindGlAccuntRow(ByVal ThisRow As DataRow)
    Public Event NotFindGlaAccount()
    Public Cod_Gl As String = ""
    Public Desc_Gl As String = ""
    Property Connection() As System.Data.SqlClient.SqlConnection
        Get
            Return mConnection
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            mConnection = Value
            CmdGeneral.Connection = mConnection
        End Set
    End Property


    Function FindDesc(ByVal ThisGl_Account As String) As Boolean
        FindDesc = False
        If mConnection Is Nothing Then
           ' MsgBox("Connection On clsgl account Not Set")
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
                              & " FROM Gl_Account " _
                              & " Where GL_account = " & Qt(ThisGl_Account)
        Try
            DaGeneral.Fill(DsGeneral, "t1")
            If DsGeneral.Tables("t1").Rows.Count > 0 Then
                FindDesc = True
                Cod_Gl = DsGeneral.Tables("t1").Rows(0).Item("GL_account")
                Desc_Gl = DsGeneral.Tables("t1").Rows(0).Item("desc_GL_account")
                RaiseEvent FindGlAccuntRow(DsGeneral.Tables("t1").Rows(0))
            Else
                RaiseEvent NotFindGlaAccount()
                Cod_Gl = ""
                Desc_Gl = ""
            End If
        Catch ex As Exception
        End Try
    End Function



    Function FindDesc1(ByVal ThisGl_Account As String) As String
        FindDesc1 = ""
        If mConnection Is Nothing Then
            ' MsgBox("Connection On clsgl account Not Set")
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
                              & " FROM Gl_Account " _
                              & " Where GL_account = " & Qt(ThisGl_Account)
        Try
            DaGeneral.Fill(DsGeneral, "t1")
            If DsGeneral.Tables("t1").Rows.Count > 0 Then
                FindDesc1 = DsGeneral.Tables("t1").Rows(0).Item("desc_GL_account")
                Cod_Gl = DsGeneral.Tables("t1").Rows(0).Item("GL_account")
                Desc_Gl = DsGeneral.Tables("t1").Rows(0).Item("desc_GL_account")
                RaiseEvent FindGlAccuntRow(DsGeneral.Tables("t1").Rows(0))
            Else
                RaiseEvent NotFindGlaAccount()
                Cod_Gl = ""
                Desc_Gl = ""
                FindDesc1 = ""
            End If
        Catch ex As Exception
        End Try
    End Function



End Class
