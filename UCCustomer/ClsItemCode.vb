Imports CommonClass
Imports UcUserOperation
Public Class Clsitem_no
    '------------------------------------------
    Private mConnection As System.Data.SqlClient.SqlConnection
    Private mitem_no As String = ""
    Private DaGeneral As New System.Data.SqlClient.SqlDataAdapter
    Private CmdSelect As New System.Data.SqlClient.SqlCommand
    Private CmdGeneral As New System.Data.SqlClient.SqlCommand
    Private DsGeneral As New DataSet
    Private Mdesc As String = ""
    '------------------------------------------
    Public Event Finditem_no()
    Public Event NotFinditem_no()
    '------------------------------------------------
    Public WithEvents DAitem_no As New System.Data.SqlClient.SqlDataAdapter
    Private WithEvents DAitem_noInsert As New System.Data.SqlClient.SqlCommand
    Private WithEvents DAitem_noSelect As New System.Data.SqlClient.SqlCommand
    Private WithEvents DAitem_noUpdate As New System.Data.SqlClient.SqlCommand
    Private WithEvents DAitem_noDelete As New System.Data.SqlClient.SqlCommand
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
            DAitem_noInsert.Connection = Value
            DAitem_noSelect.Connection = Value
            DAitem_noUpdate.Connection = Value
            DAitem_noDelete.Connection = Value
        End Set
    End Property
    Public Property item_no() As String
        Get
            Return mitem_no
        End Get
        Set(ByVal Value As String)
            mitem_no = Value
        End Set
    End Property
    Public Property Item_Name() As String
        Get
            Return Mdesc.Trim & ""
        End Get
        Set(ByVal value As String)
            Mdesc = value.Trim & ""
        End Set
    End Property
    Function FindDesc(ByVal Thisitem_no As String) As Boolean
        FindDesc = False
        If mConnection Is Nothing Then
            MsgBox("Connection On item_no Not Set")
            Exit Function
        End If
        DsGeneral.Clear()
        DaGeneral.SelectCommand = CmdSelect
        DaGeneral.SelectCommand.Connection = mConnection
        CmdSelect.CommandText = " Select * From inv_item Where item_no = '" & Thisitem_no & "'"
        DaGeneral.Fill(DsGeneral, "t1")
        If DsGeneral.Tables("t1").Rows.Count > 0 Then
            Mdesc = DsGeneral.Tables("t1").Rows(0).Item("desc_item") & ""
            FindDesc = True
            RaiseEvent Finditem_no()
        Else
            Mdesc = ""
            RaiseEvent NotFinditem_no()
        End If
    End Function

    Public Sub New()
        '
        Call InitDAitem_no()

    End Sub
    Private Sub InitDAitem_no()
        'DAitem_no
        '
        Me.DAitem_no.DeleteCommand = Me.DAitem_noDelete
        Me.DAitem_no.InsertCommand = Me.DAitem_noInsert
        Me.DAitem_no.SelectCommand = Me.DAitem_noSelect
        Me.DAitem_no.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "hes_tab_kol", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_kol", "cod_kol"), New System.Data.Common.DataColumnMapping("desc_kol", "desc_kol"), New System.Data.Common.DataColumnMapping("kind_cod_kol", "kind_cod_kol"), New System.Data.Common.DataColumnMapping("add_op", "add_op"), New System.Data.Common.DataColumnMapping("add_date", "add_date"), New System.Data.Common.DataColumnMapping("chg_op", "chg_op"), New System.Data.Common.DataColumnMapping("chg_date", "chg_date")})})
        Me.DAitem_no.UpdateCommand = Me.DAitem_noUpdate
        '
        'DAitem_noDelete
        '
        Me.DAitem_noDelete.CommandText = ""
        '
        'DAitem_noInsert
        '
        Me.DAitem_noInsert.CommandText = ""
        '
        'Dahes_tab_kolSelect
        '
        Me.DAitem_noSelect.CommandText = "SELECT item_no, desc_item FROM inv_item"
        '
        'DAitem_noUpdate
        '
        Me.DAitem_noUpdate.CommandText = ""
        '
    End Sub
    Sub AddAitem_no()
        'Call ClearError()
        'Try
        '    CmdGeneral.CommandText = "INSERT INTO item_no(cod_anbar, name_anbar) VALUES (" _
        '    & Qt(item_no) & ", " & Qt(Item_Name) & ")"
        '    CmdGeneral.Connection = Connection

        '    If CmdGeneral.Connection.State <> ConnectionState.Open Then CmdGeneral.Connection.Open()
        '    CmdGeneral.ExecuteScalar()
        'Catch ex As Exception
        '    MHasError = True
        '    MErrorString = ex.ToString
        '    RaiseEvent FindError(MErrorString)
        'End Try
    End Sub
    Sub EditAitem_no()
        'Call ClearError()
        'Try
        '    CmdGeneral.CommandText = " Update item_no set name_anbar = " & Qt(Item_Name) & " Where cod_anbar =" & Qt(item_no)
        '    CmdGeneral.Connection = Connection
        '    If CmdGeneral.Connection.State <> ConnectionState.Open Then CmdGeneral.Connection.Open()
        '    CmdGeneral.ExecuteScalar()
        'Catch ex As Exception
        '    MHasError = True
        '    MErrorString = ex.ToString
        '    RaiseEvent FindError(MErrorString)
        'End Try
    End Sub
    Sub DeleteAitem_no()
        'Call ClearError()
        'Try
        '    CmdGeneral.CommandText = "Delete From item_no Where cod_anbar =" & Qt(item_no)
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
