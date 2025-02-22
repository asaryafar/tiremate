Imports CommonClass
Imports UcUserOperation
Public Class ClsCod_pakage
    '------------------------------------------
    Private MConnection As System.Data.SqlClient.SqlConnection
    Private MCod_pakage As String = ""
    Private DaGeneral As New System.Data.SqlClient.SqlDataAdapter
    Private CmdSelect As New System.Data.SqlClient.SqlCommand
    Private CmdGeneral As New System.Data.SqlClient.SqlCommand
    Private DsGeneral As New DataSet
    Private MDesc As String = ""
    '------------------------------------------
    Public Event FindCod_pakage()
    Public Event NotFindCod_pakage()
    '------------------------------------------------
    Public WithEvents DApakageDetail As New System.Data.SqlClient.SqlDataAdapter
    Private WithEvents DApakageDetailSelect As New System.Data.SqlClient.SqlCommand
    Public WithEvents DApakageHead As New System.Data.SqlClient.SqlDataAdapter
    Private WithEvents DApakageHeadInsert As New System.Data.SqlClient.SqlCommand
    Private WithEvents DApakageHeadSelect As New System.Data.SqlClient.SqlCommand
    Private WithEvents DApakageHeadUpdate As New System.Data.SqlClient.SqlCommand
    Private WithEvents DApakageHeadDelete As New System.Data.SqlClient.SqlCommand
    Private ClsUserOperation1 As New ClsUserOperation
    Private MErrorString As String
    Private MHasError As Boolean
    Public Event FindError(ByVal ErrorString As String)

    Public MYDSInv_tab_pakage As New DSInv_tab_pakage

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
            Return MConnection
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            MConnection = Value
            DApakageDetailSelect.Connection = Value
            DApakageHeadInsert.Connection = Value
            DApakageHeadSelect.Connection = Value
            DApakageHeadUpdate.Connection = Value
            DApakageHeadDelete.Connection = Value
        End Set
    End Property
    Public Property Cod_pakage() As String
        Get
            Return MCod_pakage
        End Get
        Set(ByVal Value As String)
            MCod_pakage = Value
        End Set
    End Property
    Public Property Desc_pakage() As String
        Get
            Return MDesc.Trim & ""
        End Get
        Set(ByVal value As String)
            MDesc = value.Trim & ""
        End Set
    End Property
    Function FindDesc(ByVal ThisCod_pakage As String) As Boolean
        FindDesc = False
        If MConnection Is Nothing Then
            MsgBox("Connection Not Set")
            Exit Function
        End If
        DsGeneral.Clear()
        DaGeneral.SelectCommand = CmdSelect
        DaGeneral.SelectCommand.Connection = MConnection
        CmdSelect.CommandText = " Select * From inv_tab_pakage_Head Where Cod_pakage = '" & ThisCod_pakage & "'"
        DaGeneral.Fill(DsGeneral, "t1")
        If DsGeneral.Tables("t1").Rows.Count > 0 Then
            MDesc = DsGeneral.Tables("t1").Rows(0).Item("Desc_pakage") & ""
            FindDesc = True
            RaiseEvent FindCod_pakage()
        Else
            MDesc = ""
            RaiseEvent NotFindCod_pakage()
        End If
    End Function

    Public Sub New()
        '
        Call InitDApakageHead()

    End Sub
    Private Sub InitDApakageHead()
        'DApakageHead
        '
        Me.DApakageDetail.SelectCommand = Me.DApakageDetailSelect

        Me.DApakageHead.DeleteCommand = Me.DApakageHeadDelete
        Me.DApakageHead.InsertCommand = Me.DApakageHeadInsert
        Me.DApakageHead.SelectCommand = Me.DApakageHeadSelect
        Me.DApakageHead.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "hes_tab_kol", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_kol", "cod_kol"), New System.Data.Common.DataColumnMapping("desc_kol", "desc_kol"), New System.Data.Common.DataColumnMapping("kind_cod_kol", "kind_cod_kol"), New System.Data.Common.DataColumnMapping("add_op", "add_op"), New System.Data.Common.DataColumnMapping("add_date", "add_date"), New System.Data.Common.DataColumnMapping("chg_op", "chg_op"), New System.Data.Common.DataColumnMapping("chg_date", "chg_date")})})
        Me.DApakageHead.UpdateCommand = Me.DApakageHeadUpdate
        '
        'DApakageHeadDelete
        '
        Me.DApakageHeadDelete.CommandText = ""
        '
        'DApakageHeadInsert
        '
        Me.DApakageHeadInsert.CommandText = ""
        '
        'Dahes_tab_kolSelect
        '
        Me.DApakageHeadSelect.CommandText = "SELECT cod_pakage, desc_pakage FROM inv_tab_pakage_head"
        '
        'DApakageHeadUpdate
        '
        Me.DApakageHeadUpdate.CommandText = ""
        '
    End Sub
    Sub AddACod_pakage()
        Call ClearError()
        Try
            CmdGeneral.CommandText = "INSERT INTO inv_tab_pakage_Head(Cod_pakage, Desc_pakage) VALUES (" _
            & Qt(Cod_pakage) & ", " & Qt(Desc_pakage) & ")"
            CmdGeneral.Connection = Connection

            If CmdGeneral.Connection.State <> ConnectionState.Open Then CmdGeneral.Connection.Open()
            CmdGeneral.ExecuteScalar()
        Catch ex As Exception
            MHasError = True
            MErrorString = ex.ToString
            RaiseEvent FindError(MErrorString)
        End Try
    End Sub
    Sub EditACod_pakage()
        Call ClearError()
        Try
            CmdGeneral.CommandText = " Update inv_tab_pakage_Head set Desc_pakage = " & Qt(Desc_pakage) & " Where Cod_pakage =" & Qt(Cod_pakage)
            CmdGeneral.Connection = Connection
            If CmdGeneral.Connection.State <> ConnectionState.Open Then CmdGeneral.Connection.Open()
            CmdGeneral.ExecuteScalar()
        Catch ex As Exception
            MHasError = True
            MErrorString = ex.ToString
            RaiseEvent FindError(MErrorString)
        End Try
    End Sub
    Sub DeleteACod_pakage()
        Call ClearError()
        Try
            CmdGeneral.CommandText = "Delete From inv_tab_pakage_Head Where Cod_pakage =" & Qt(Cod_pakage)
            CmdGeneral.Connection = Connection
            If CmdGeneral.Connection.State <> ConnectionState.Open Then CmdGeneral.Connection.Open()
            CmdGeneral.ExecuteScalar()
        Catch ex As Exception
            MHasError = True
            MErrorString = "Can not delete this cod." 'ex.ToString
            RaiseEvent FindError(MErrorString)
        End Try
    End Sub
    Private Sub ClearError()
        MHasError = False
        MErrorString = ""
    End Sub
    Public Sub FillDs(ByVal Thiscod_pakage As String)
        MYDSInv_tab_pakage.inv_tab_pakage.Clear()
        Me.DApakageDetailSelect.CommandText = "SELECT * FROM inv_tab_pakage where cod_pakage=" & Qt(Thiscod_pakage) & " Order by radif"
        DApakageDetail.Fill(MYDSInv_tab_pakage, "inv_tab_pakage")
    End Sub
End Class
