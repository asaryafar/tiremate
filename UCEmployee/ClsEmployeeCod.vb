Imports System.Windows.Forms
Imports CommonClass
Imports UcUserOperation
Public Class ClsEmployeeCod
    '------------------------------------------
    Private mConnection As System.Data.SqlClient.SqlConnection
    Private MEmployeeNo As String = ""
    Private DaGeneral As New System.Data.SqlClient.SqlDataAdapter
    Private CmdSelect As New System.Data.SqlClient.SqlCommand
    Private CmdGeneral As New System.Data.SqlClient.SqlCommand
    Private DsGeneral As New DataSet
    Private MCod_Employee As String = ""
    Private MDescEmployee As String = ""
    Private DAEmployeeNoSelectText As String

    '------------------------------------------
    Public Event FindEmployeeNo()
    Public Event NotFindEmployeeNo()
    '------------------------------------------------
    Public WithEvents DAEmployeeNo As New System.Data.SqlClient.SqlDataAdapter
    Private WithEvents DAEmployeeNoInsert As New System.Data.SqlClient.SqlCommand
    Private WithEvents DAEmployeeNoSelect As New System.Data.SqlClient.SqlCommand
    Private WithEvents DAEmployeeNoUpdate As New System.Data.SqlClient.SqlCommand
    Private WithEvents DAEmployeeNoDelete As New System.Data.SqlClient.SqlCommand
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
            DAEmployeeNoInsert.Connection = Value
            DAEmployeeNoSelect.Connection = Value
            DAEmployeeNoUpdate.Connection = Value
            DAEmployeeNoDelete.Connection = Value
        End Set
    End Property
    Public Property EmployeeNo() As String
        Get
            Return MEmployeeNo
        End Get
        Set(ByVal Value As String)
            MEmployeeNo = Value
        End Set
    End Property
    Public Property cod_Employee() As String
        Get
            Return Mcod_Employee.Trim & ""
        End Get
        Set(ByVal value As String)
            Mcod_Employee = value.Trim & ""
        End Set
    End Property
    Public Property desc_Employee() As String
        Get
            Return MdescEmployee.Trim & ""
        End Get
        Set(ByVal value As String)
            MdescEmployee = value.Trim & ""
        End Set
    End Property
    Function FindDesc(ByVal ThisEmployeeNo As String) As Boolean
        If ThisEmployeeNo.Trim.Length = 0 Then
            MCod_Employee = ""
            MDescEmployee = ""
            RaiseEvent NotFindEmployeeNo()
            Exit Function
        End If
        FindDesc = False
        If mConnection Is Nothing Then
            MsgBox("Connection On EmployeeNo Not Set")
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
        Try
            If IsNothing(DaGeneral.SelectCommand.Connection) Then
                DaGeneral.SelectCommand.Connection = mConnection
            End If
            CmdSelect.CommandText = "SELECT  * " _
                                  & " FROM Employee " _
                                  & " Where Employee.employee_code = " & Qt(ThisEmployeeNo)
            DaGeneral.Fill(DsGeneral, "t1")
            If DsGeneral.Tables("t1").Rows.Count > 0 Then
                MCod_Employee = DsGeneral.Tables("t1").Rows(0).Item("employee_code")
                MDescEmployee = DsGeneral.Tables("t1").Rows(0).Item("F_Name") & " " & DsGeneral.Tables("t1").Rows(0).Item("M_Name") & " " & DsGeneral.Tables("t1").Rows(0).Item("L_Name")
                FindDesc = True
                RaiseEvent FindEmployeeNo()
            Else
                MCod_Employee = ""
                MDescEmployee = ""
                RaiseEvent NotFindEmployeeNo()
            End If
        Catch ex As Exception
        End Try
    End Function

    Public Sub New()
        '
        Call InitDAEmployeeNo()

    End Sub
    Private Sub InitDAEmployeeNo()
        'DAEmployeeNo
        '
        Me.DAEmployeeNo.DeleteCommand = Me.DAEmployeeNoDelete
        Me.DAEmployeeNo.InsertCommand = Me.DAEmployeeNoInsert
        Me.DAEmployeeNo.SelectCommand = Me.DAEmployeeNoSelect
        Me.DAEmployeeNo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "hes_tab_kol", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_kol", "cod_kol"), New System.Data.Common.DataColumnMapping("desc_kol", "desc_kol"), New System.Data.Common.DataColumnMapping("kind_cod_kol", "kind_cod_kol"), New System.Data.Common.DataColumnMapping("add_op", "add_op"), New System.Data.Common.DataColumnMapping("add_date", "add_date"), New System.Data.Common.DataColumnMapping("chg_op", "chg_op"), New System.Data.Common.DataColumnMapping("chg_date", "chg_date")})})
        Me.DAEmployeeNo.UpdateCommand = Me.DAEmployeeNoUpdate
        '
        'DAEmployeeNoDelete
        '
        Me.DAEmployeeNoDelete.CommandText = ""
        '
        'DAEmployeeNoInsert
        '
        Me.DAEmployeeNoInsert.CommandText = ""
        '
        'Dahes_tab_kolSelect
        '
        Me.DAEmployeeNoSelect.CommandText = "SELECT employee_code,f_name+' '+m_name+' '+l_name as l_name " _
                      & " FROM  Employee"

        DAEmployeeNoSelectText = Me.DAEmployeeNoSelect.CommandText
        '
        'DAEmployeeNoUpdate
        '
        Me.DAEmployeeNoUpdate.CommandText = ""
        '
    End Sub
    Sub AdDAEmployeeNo()
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
    Sub EditAEmployeeNo()
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
    Sub DeleteAEmployeeNo()
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
