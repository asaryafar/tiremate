Imports System.Windows.Forms
Imports CommonClass
Imports UcUserOperation
Public Class ClsInv_line
    '------------------------------------------
    Private mConnection As System.Data.SqlClient.SqlConnection
    Private MlineCode As String = ""
    Private DaGeneral As New System.Data.SqlClient.SqlDataAdapter
    Private CmdSelect As New System.Data.SqlClient.SqlCommand
    Private CmdGeneral As New System.Data.SqlClient.SqlCommand
    Private DsGeneral As New DataSet
    Private MCode_Line As String = ""
    Private MLineRemark As String = ""
    Private MCodBrand As String = ""
    Private MCodStyle As String = ""
    Private DAlineCodeSelectText As String

    '------------------------------------------
    Public Event FindlineCode()
    Public Event FindlineCodeRow(ByVal ThisRow As DataRow)

    Public Event NotFindlineCode()

    '------------------------------------------------
    Public WithEvents DAlineCode As New System.Data.SqlClient.SqlDataAdapter
    Private WithEvents DAlineCodeInsert As New System.Data.SqlClient.SqlCommand
    Private WithEvents DAlineCodeSelect As New System.Data.SqlClient.SqlCommand
    Private WithEvents DAlineCodeUpdate As New System.Data.SqlClient.SqlCommand
    Private WithEvents DAlineCodeDelete As New System.Data.SqlClient.SqlCommand
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
            DAlineCodeInsert.Connection = Value
            DAlineCodeSelect.Connection = Value
            DAlineCodeUpdate.Connection = Value
            DAlineCodeDelete.Connection = Value
        End Set
    End Property
    Public Property lineCode() As String
        Get
            Return MlineCode
        End Get
        Set(ByVal Value As String)
            MlineCode = Value
        End Set
    End Property
    Public Property cod_Line() As String
        Get
            Return MCode_Line.Trim & ""
        End Get
        Set(ByVal value As String)
            MCode_Line = value.Trim & ""
        End Set
    End Property
    Public Property LineRemark() As String
        Get
            Return MLineRemark.Trim & ""
        End Get
        Set(ByVal value As String)
            MLineRemark = value.Trim & ""
        End Set
    End Property
    Public Property CodBrand() As String
        Get
            Return MCodBrand.Trim & ""
        End Get
        Set(ByVal value As String)
            MCodBrand = value.Trim & ""
        End Set
    End Property
    Public Property CodStyle() As String
        Get
            Return MCodStyle.Trim & ""
        End Get
        Set(ByVal value As String)
            MCodStyle = value.Trim & ""
        End Set
    End Property
    Function FindDesc(ByVal ThislineCode As String) As Boolean
        FindDesc = False
        If mConnection Is Nothing Then
            MsgBox("Connection On lineCode Not Set")
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
        CmdSelect.CommandText = "SELECT inv_tab_line.cod_brand, inv_tab_line.style, inv_tab_line.line, inv_tab_brand.complete_desc_brand, inv_tab_style.desc_style,inv_tab_line.remark " _
                              & "FROM inv_tab_line INNER JOIN " _
                              & "inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " _
                              & "inv_tab_style ON inv_tab_line.style = inv_tab_style.style " _
                              & " Where inv_tab_line.Line = " & Qt(ThislineCode)
        Try
            DaGeneral.Fill(DsGeneral, "t1")
            If DsGeneral.Tables("t1").Rows.Count > 0 Then
                MCode_Line = DsGeneral.Tables("t1").Rows(0).Item("Line") & ""
                MLineRemark = DsGeneral.Tables("t1").Rows(0).Item("Remark") & ""
                MCodBrand = DsGeneral.Tables("t1").Rows(0).Item("cod_brand") & ""
                MCodStyle = DsGeneral.Tables("t1").Rows(0).Item("Style") & ""
                FindDesc = True
                RaiseEvent FindlineCode()
                RaiseEvent FindlineCodeRow(DsGeneral.Tables("t1").Rows(0))
            Else
                MCode_Line = ""
                MLineRemark = ""
                MCodBrand = ""
                MCodStyle = ""
                RaiseEvent NotFindlineCode()
            End If
        Catch ex As Exception
        End Try
    End Function

    Public Sub New()
        '
        Call InitDAlineCode()

    End Sub
    Private Sub InitDAlineCode()
        'DAlineCode
        '
        Me.DAlineCode.DeleteCommand = Me.DAlineCodeDelete
        Me.DAlineCode.InsertCommand = Me.DAlineCodeInsert
        Me.DAlineCode.SelectCommand = Me.DAlineCodeSelect
        Me.DAlineCode.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "hes_tab_kol", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_kol", "cod_kol"), New System.Data.Common.DataColumnMapping("desc_kol", "desc_kol"), New System.Data.Common.DataColumnMapping("kind_cod_kol", "kind_cod_kol"), New System.Data.Common.DataColumnMapping("add_op", "add_op"), New System.Data.Common.DataColumnMapping("add_date", "add_date"), New System.Data.Common.DataColumnMapping("chg_op", "chg_op"), New System.Data.Common.DataColumnMapping("chg_date", "chg_date")})})
        Me.DAlineCode.UpdateCommand = Me.DAlineCodeUpdate
        '
        'DAlineCodeDelete
        '
        Me.DAlineCodeDelete.CommandText = ""
        '
        'DAlineCodeInsert
        '
        Me.DAlineCodeInsert.CommandText = ""
        '
        'Dahes_tab_kolSelect
        '
        Me.DAlineCodeSelect.CommandText = "SELECT inv_tab_line.cod_brand, inv_tab_line.style, inv_tab_line.line, inv_tab_brand.complete_desc_brand, inv_tab_style.desc_style,inv_tab_line.remark " _
                              & "FROM inv_tab_line INNER JOIN " _
                              & "inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_brand.cod_brand INNER JOIN " _
                              & "inv_tab_style ON inv_tab_line.style = inv_tab_style.style "
        DAlineCodeSelectText = Me.DAlineCodeSelect.CommandText
        '
        'DAlineCodeUpdate
        '
        Me.DAlineCodeUpdate.CommandText = ""
        '
    End Sub
    Sub AdDAlineCode()
        'Call ClearError()
        'Try
        '    CmdGeneral.CommandText = "INSERT INTO cod_customer(cod_anbar, name_anbar) VALUES (" _
        '    & Qt(cod_customer) & ", " & Qt(Item_Name) & ")"
        '    CmdGeneral.Connection = Connection

        '    If CmdGeneral.Connection.State <> ConnectionState.Open Then CmdGeneral.Connection.Open()
        '    CmdGeneral.ExecuteScalar()
        'Catch ex As Exception
        '    MHasError = True
        '    MErrorString = ex.ToString
        '    RaiseEvent FindError(MErrorString)
        'End Try
    End Sub
    Sub EditAlineCode()
        'Call ClearError()
        'Try
        '    CmdGeneral.CommandText = " Update cod_customer set name_anbar = " & Qt(Item_Name) & " Where cod_anbar =" & Qt(cod_customer)
        '    CmdGeneral.Connection = Connection
        '    If CmdGeneral.Connection.State <> ConnectionState.Open Then CmdGeneral.Connection.Open()
        '    CmdGeneral.ExecuteScalar()
        'Catch ex As Exception
        '    MHasError = True
        '    MErrorString = ex.ToString
        '    RaiseEvent FindError(MErrorString)
        'End Try
    End Sub
    Sub DeleteAlineCode()
        'Call ClearError()
        'Try
        '    CmdGeneral.CommandText = "Delete From cod_customer Where cod_anbar =" & Qt(cod_customer)
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
