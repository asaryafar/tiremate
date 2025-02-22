Imports System.Windows.Forms
Imports CommonClass
Imports UcUserOperation
Public Class ClsVendorCod
    '------------------------------------------
    Private mConnection As System.Data.SqlClient.SqlConnection
    Private MVendorNo As String = ""
    Private DaGeneral As New System.Data.SqlClient.SqlDataAdapter
    Private CmdSelect As New System.Data.SqlClient.SqlCommand
    Private CmdGeneral As New System.Data.SqlClient.SqlCommand
    Private DsGeneral As New DataSet
    Private Mcod_vendor As String = ""
    Private MAp_terms As String = ""
    Private Mdescvendor As String = ""
    Private MvendorAddress As String = ""
    Private MvendorContact As String = ""
    Private DAVendorNoSelectText As String

    '------------------------------------------
    Public Event FindVendorNo()
    Public Event FindVendorNoRow(ByVal ThisRow As DataRow)

    Public Event NotFindVendorNo()

    '------------------------------------------------
    Public WithEvents DAVendorNo As New System.Data.SqlClient.SqlDataAdapter
    Private WithEvents DAVendorNoInsert As New System.Data.SqlClient.SqlCommand
    Private WithEvents DAVendorNoSelect As New System.Data.SqlClient.SqlCommand
    Private WithEvents DAVendorNoUpdate As New System.Data.SqlClient.SqlCommand
    Private WithEvents DAVendorNoDelete As New System.Data.SqlClient.SqlCommand
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
            DAVendorNoInsert.Connection = Value
            DAVendorNoSelect.Connection = Value
            DAVendorNoUpdate.Connection = Value
            DAVendorNoDelete.Connection = Value
        End Set
    End Property
    Public Property VendorNo() As String
        Get
            Return MVendorNo
        End Get
        Set(ByVal Value As String)
            MVendorNo = Value
        End Set
    End Property
    Public Property cod_vendor() As String
        Get
            Return Mcod_vendor.Trim & ""
        End Get
        Set(ByVal value As String)
            Mcod_vendor = value.Trim & ""
        End Set
    End Property
    Public Property Ap_terms() As String
        Get
            Return MAp_terms.Trim & ""
        End Get
        Set(ByVal value As String)
            MAp_terms = value.Trim & ""
        End Set
    End Property
    Public Property desc_vendor() As String
        Get
            Return Mdescvendor.Trim & ""
        End Get
        Set(ByVal value As String)
            Mdescvendor = value.Trim & ""
        End Set
    End Property
    Public Property vendorAddress() As String
        Get
            Return MvendorAddress.Trim & ""
        End Get
        Set(ByVal value As String)
            MvendorAddress = value.Trim & ""
        End Set
    End Property
    Public Property vendorContact() As String
        Get
            Return MvendorContact.Trim & ""
        End Get
        Set(ByVal value As String)
            MvendorContact = value.Trim & ""
        End Set
    End Property
    Function FindDesc(ByVal ThisVendorNo As String) As Boolean
        FindDesc = False
        If mConnection Is Nothing Then
            MsgBox("Connection On VendorNo Not Set")
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
                              & " FROM inv_vendor " _
                              & " Where inv_vendor.cod_vendor = " & Qt(ThisVendorNo)
        Try
            DaGeneral.Fill(DsGeneral, "t1")
            If DsGeneral.Tables("t1").Rows.Count > 0 Then
                Mcod_vendor = DsGeneral.Tables("t1").Rows(0).Item("cod_vendor") & ""
                Mdescvendor = DsGeneral.Tables("t1").Rows(0).Item("desc_vendor") & ""
                MAp_terms = DsGeneral.Tables("t1").Rows(0).Item("ap_terms") & ""
                MvendorAddress = DsGeneral.Tables("t1").Rows(0).Item("address") & ""
                MvendorContact = DsGeneral.Tables("t1").Rows(0).Item("contact1") & ""
                FindDesc = True
                RaiseEvent FindVendorNo()
                RaiseEvent FindVendorNoRow(DsGeneral.Tables("t1").Rows(0))
            Else
                Mcod_vendor = ""
                Mdescvendor = ""
                MAp_terms = ""
                MvendorAddress = ""
                MvendorContact = ""
                RaiseEvent NotFindVendorNo()
            End If
        Catch ex As Exception
        End Try
    End Function

    Public Sub New()
        '
        Call InitDAVendorNo()

    End Sub
    Private Sub InitDAVendorNo()
        'DAVendorNo
        '
        Me.DAVendorNo.DeleteCommand = Me.DAVendorNoDelete
        Me.DAVendorNo.InsertCommand = Me.DAVendorNoInsert
        Me.DAVendorNo.SelectCommand = Me.DAVendorNoSelect
        Me.DAVendorNo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "hes_tab_kol", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_kol", "cod_kol"), New System.Data.Common.DataColumnMapping("desc_kol", "desc_kol"), New System.Data.Common.DataColumnMapping("kind_cod_kol", "kind_cod_kol"), New System.Data.Common.DataColumnMapping("add_op", "add_op"), New System.Data.Common.DataColumnMapping("add_date", "add_date"), New System.Data.Common.DataColumnMapping("chg_op", "chg_op"), New System.Data.Common.DataColumnMapping("chg_date", "chg_date")})})
        Me.DAVendorNo.UpdateCommand = Me.DAVendorNoUpdate
        '
        'DAVendorNoDelete
        '
        Me.DAVendorNoDelete.CommandText = ""
        '
        'DAVendorNoInsert
        '
        Me.DAVendorNoInsert.CommandText = ""
        '
        'Dahes_tab_kolSelect
        '
        Me.DAVendorNoSelect.CommandText = "SELECT * " _
                      & " FROM  inv_vendor"

        DAVendorNoSelectText = Me.DAVendorNoSelect.CommandText
        '
        'DAVendorNoUpdate
        '
        Me.DAVendorNoUpdate.CommandText = ""
        '
    End Sub
    Sub AdDAVendorNo()
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
    Sub EditAVendorNo()
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
    Sub DeleteAVendorNo()
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
