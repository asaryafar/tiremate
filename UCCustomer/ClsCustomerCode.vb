Imports System.Windows.Forms
Imports CommonClass
Imports UcUserOperation
Public Class ClsCustomerCod
    '------------------------------------------
    Private mConnection As System.Data.SqlClient.SqlConnection
    Private Mcod_customer As String = ""
    Private DaGeneral As New System.Data.SqlClient.SqlDataAdapter
    Private CmdSelect As New System.Data.SqlClient.SqlCommand
    Private CmdGeneral As New System.Data.SqlClient.SqlCommand
    Private DsGeneral As New DataSet
    Private MCustomerName As String = ""
    Private MF_Name As String = ""
    Private MM_Name As String = ""
    Private ML_Name As String = ""
    Private MPrice_Level As String = "1"
    Private MTax_Amount As Double = 0
    Private MAR_Term As String = ""
    Private MZipCode As String = ""
    Private MKIND_AR As Decimal = 0
    Private MST_DISCOUNT_PERCENTAGE As Decimal = 0
    Private MST_NET_DUE_IN As Decimal = 0
    Private MST_IF_PAY_WITHIN_DAYS As Decimal = 0
    Private MDD_NET_DUE_BEFORE As Decimal = 0
    Private MDD_IF_ISSUED_WITHIN_DAYS As Decimal = 0
    Private MDD_DISCOUNT_PERCENTAGE As Decimal = 0
    Private MDD_IF_PAY_WITHIN_DAYS As Decimal = 0
    Private MMP_NO_OF_PAYMENT As Decimal = 0
    Private MMP_BEFORE_DAY As Decimal = 0
    Private MCreditLimit As Decimal = 0
    Private mcod_company As String = ""
    Private MCustomerPhone As String = ""
    Private Mabbreviation_name As String = ""
    Private Maddress As String = ""
    Private MEmailAddress As String = ""
    Private MRequire_PO As Boolean = False
    Private MARCharge As Boolean = False
    Private MCreditHold As Boolean = False
    Private MAcceptCheck As Boolean = False
    Private MARCreditHold As Boolean = False
    '------------------------------------------
    Public Event Findcod_customer()
    Public Event NotFindcod_customer()
    '------------------------------------------------
    Public WithEvents DAcod_customer As New System.Data.SqlClient.SqlDataAdapter
    Private WithEvents DAcod_customerInsert As New System.Data.SqlClient.SqlCommand
    Private WithEvents DAcod_customerSelect As New System.Data.SqlClient.SqlCommand
    Private WithEvents DAcod_customerUpdate As New System.Data.SqlClient.SqlCommand
    Private WithEvents DAcod_customerDelete As New System.Data.SqlClient.SqlCommand
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
            DAcod_customerInsert.Connection = Value
            DAcod_customerSelect.Connection = Value
            DAcod_customerUpdate.Connection = Value
            DAcod_customerDelete.Connection = Value
        End Set
    End Property
    Public Property cod_company() As String
        Get
            Return mcod_company
        End Get
        Set(ByVal Value As String)
            mcod_company = Value
        End Set
    End Property
    Public Property cod_customer() As String
        Get
            Return Mcod_customer
        End Get
        Set(ByVal Value As String)
            Mcod_customer = Value
        End Set
    End Property
    Public Property KIND_AR() As Decimal
        Get
            Return MKIND_AR
        End Get
        Set(ByVal value As Decimal)
            MKIND_AR = value
        End Set
    End Property
    Public Property ST_DISCOUNT_PERCENTAGE() As Decimal
        Get
            Return MST_DISCOUNT_PERCENTAGE
        End Get
        Set(ByVal value As Decimal)
            MST_DISCOUNT_PERCENTAGE = value
        End Set
    End Property
    Public Property ST_NET_DUE_IN() As Decimal
        Get
            Return MST_NET_DUE_IN
        End Get
        Set(ByVal value As Decimal)
            MST_NET_DUE_IN = value
        End Set
    End Property
    Public Property ST_IF_PAY_WITHIN_DAYS() As Decimal
        Get
            Return MST_IF_PAY_WITHIN_DAYS
        End Get
        Set(ByVal value As Decimal)
            MST_IF_PAY_WITHIN_DAYS = value
        End Set
    End Property

    Public Property DD_NET_DUE_BEFORE() As Decimal
        Get
            Return MDD_NET_DUE_BEFORE
        End Get
        Set(ByVal value As Decimal)
            MDD_NET_DUE_BEFORE = value
        End Set
    End Property
    Public Property DD_IF_ISSUED_WITHIN_DAYS() As Decimal
        Get
            Return MDD_IF_ISSUED_WITHIN_DAYS
        End Get
        Set(ByVal value As Decimal)
            MDD_IF_ISSUED_WITHIN_DAYS = value
        End Set
    End Property
    Public Property DD_DISCOUNT_PERCENTAGE() As Decimal
        Get
            Return MDD_DISCOUNT_PERCENTAGE
        End Get
        Set(ByVal value As Decimal)
            MDD_DISCOUNT_PERCENTAGE = value
        End Set
    End Property
    Public Property DD_IF_PAY_WITHIN_DAYS() As Decimal
        Get
            Return MDD_IF_PAY_WITHIN_DAYS
        End Get
        Set(ByVal value As Decimal)
            MDD_IF_PAY_WITHIN_DAYS = value
        End Set
    End Property
    Public Property MP_NO_OF_PAYMENT() As Decimal
        Get
            Return MMP_NO_OF_PAYMENT
        End Get
        Set(ByVal value As Decimal)
            MMP_NO_OF_PAYMENT = value
        End Set
    End Property
    Public Property CreditLimit() As Decimal
        Get
            Return MCreditLimit
        End Get
        Set(ByVal value As Decimal)
            MCreditLimit = value
        End Set
    End Property
    Public Property MP_BEFORE_DAY() As Decimal
        Get
            Return MMP_BEFORE_DAY
        End Get
        Set(ByVal value As Decimal)
            MMP_BEFORE_DAY = value
        End Set
    End Property
    Public Property ZipCode() As String
        Get
            Return MZipCode
        End Get
        Set(ByVal value As String)
            MZipCode = value
        End Set
    End Property
    Public Property AR_Term() As String
        Get
            Return MAR_Term & ""
        End Get
        Set(ByVal value As String)
            MAR_Term = value & ""
        End Set
    End Property
    Public Property Customer_Name() As String
        Get
            Return MCustomerName.Trim & ""
        End Get
        Set(ByVal value As String)
            MCustomerName = value.Trim & ""
        End Set
    End Property
    Public Property F_Name() As String
        Get
            Return MF_Name.Trim & ""
        End Get
        Set(ByVal value As String)
            MF_Name = value.Trim & ""
        End Set
    End Property
    Public Property M_Name() As String
        Get
            Return MM_Name.Trim & ""
        End Get
        Set(ByVal value As String)
            MM_Name = value.Trim & ""
        End Set
    End Property
    Public Property L_Name() As String
        Get
            Return ML_Name.Trim & ""
        End Get
        Set(ByVal value As String)
            ML_Name = value.Trim & ""
        End Set
    End Property
    Public Property Price_Level() As String
        Get
            Return MPrice_Level
        End Get
        Set(ByVal value As String)
            MPrice_Level = value
        End Set
    End Property
    Public Property Tax_Amount() As Double
        Get
            Return MTax_Amount
        End Get
        Set(ByVal value As Double)
            MTax_Amount = value
        End Set
    End Property
    Public Property CustomerPhone() As String
        Get
            Return MCustomerPhone.Trim & ""
        End Get
        Set(ByVal value As String)
            MCustomerPhone = value.Trim & ""
        End Set
    End Property
    Public Property Abbreviation_name() As String
        Get
            Return Mabbreviation_name.Trim & ""
        End Get
        Set(ByVal value As String)
            Mabbreviation_name = value.Trim & ""
        End Set
    End Property
    Public Property Address() As String
        Get
            Return Maddress.Trim & ""
        End Get
        Set(ByVal value As String)
            Maddress = value.Trim & ""
        End Set
    End Property
    Public Property EmailAddress() As String
        Get
            Return MEmailAddress.Trim & ""
        End Get
        Set(ByVal value As String)
            MEmailAddress = value.Trim & ""
        End Set
    End Property
    Public Property require_PO() As Boolean
        Get
            Return MRequire_PO
        End Get
        Set(ByVal value As Boolean)
            MRequire_PO = value
        End Set
    End Property
    Public Property ARCharge() As Boolean
        Get
            Return MARCharge
        End Get
        Set(ByVal value As Boolean)
            MARCharge = value
        End Set
    End Property
    Public Property CreditHold() As Boolean
        Get
            Return MCreditHold
        End Get
        Set(ByVal value As Boolean)
            MCreditHold = value
        End Set
    End Property
    Public Property AcceptCheck() As Boolean
        Get
            Return MAcceptCheck
        End Get
        Set(ByVal value As Boolean)
            MAcceptCheck = value
        End Set
    End Property
    Public Property ARCreditHold() As Boolean
        Get
            Return MARCreditHold
        End Get
        Set(ByVal value As Boolean)
            MARCreditHold = value
        End Set
    End Property
    Function FindDesc(ByVal Thiscod_customer As String) As Boolean
        FindDesc = False
        If mConnection Is Nothing Then
            MsgBox("Connection On cod_customer Not Set")
            Exit Function
        End If
        If mConnection.State = ConnectionState.Closed And mConnection.ConnectionString <> PConnectionString Then
            mConnection.ConnectionString = PConnectionString
        End If

        DsGeneral.Clear()
        DaGeneral.SelectCommand = CmdSelect
        '''''If mConnection.ConnectionString <> PConnectionString Then
        '''''    If mConnection.State <> ConnectionState.Closed Then
        '''''        mConnection.Close()
        '''''    End If
        '''''    mConnection.ConnectionString = PConnectionString
        '''''    'mConnection.Open()
        '''''End If
        DaGeneral.SelectCommand.Connection = mConnection
        CmdSelect.CommandText = "SELECT     cust_trtab_main.*, cust_company.abbreviation_name, cust_company.complete_name, GL_TAB_AR_TERM.KIND_AR,GL_TAB_AR_TERM.ST_NET_DUE_IN, GL_TAB_AR_TERM.ST_DISCOUNT_PERCENTAGE, cust_sales_tax.Amount,GL_TAB_AR_TERM.ST_IF_PAY_WITHIN_DAYS, GL_TAB_AR_TERM.DD_NET_DUE_BEFORE, GL_TAB_AR_TERM.DD_IF_ISSUED_WITHIN_DAYS,GL_TAB_AR_TERM.DD_DISCOUNT_PERCENTAGE, GL_TAB_AR_TERM.DD_IF_PAY_WITHIN_DAYS, GL_TAB_AR_TERM.MP_NO_OF_PAYMENT, GL_TAB_AR_TERM.MP_BEFORE_DAY " _
                              & " FROM cust_trtab_main " _
                              & " LEFT OUTER JOIN cust_sales_tax ON cust_trtab_main.cod_sales_tax = cust_sales_tax.cod_sales_tax " _
                              & " LEFT OUTER JOIN GL_TAB_AR_TERM ON cust_trtab_main.AR_term = GL_TAB_AR_TERM.AR_terms " _
                              & " LEFT OUTER JOIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " _
                              & " Where cust_trtab_main.cod_customer = " & Qt(Thiscod_customer)
        Try
            DaGeneral.Fill(DsGeneral, "t1")
            If DsGeneral.Tables("t1").Rows.Count > 0 Then
                If Trim(DsGeneral.Tables("t1").Rows(0).Item("complete_name") & "").Length > 0 Then
                    MCustomerName = DsGeneral.Tables("t1").Rows(0).Item("complete_name") & ""
                Else
                    MCustomerName = DsGeneral.Tables("t1").Rows(0).Item("F_name") & " " & DsGeneral.Tables("t1").Rows(0).Item("M_name") & " " & DsGeneral.Tables("t1").Rows(0).Item("L_name") & ""
                End If
                MF_Name = DsGeneral.Tables("t1").Rows(0).Item("F_name") & ""
                MM_Name = DsGeneral.Tables("t1").Rows(0).Item("M_name") & ""
                ML_Name = DsGeneral.Tables("t1").Rows(0).Item("L_name") & ""
                MPrice_Level = DsGeneral.Tables("t1").Rows(0).Item("cod_price") & ""
                mcod_company = DsGeneral.Tables("t1").Rows(0).Item("cod_company") & ""

                Try
                    If DsGeneral.Tables("t1").Rows(0).Item("taxable") Then
                        MTax_Amount = DsGeneral.Tables("t1").Rows(0).Item("Amount")
                    Else
                        MTax_Amount = 0
                    End If
                Catch ex As Exception
                    MTax_Amount = 0
                End Try
                Try
                    MRequire_PO = DsGeneral.Tables("t1").Rows(0).Item("AR_Require_PO")
                Catch ex As Exception
                    MRequire_PO = False
                End Try
                Try
                    MARCharge = DsGeneral.Tables("t1").Rows(0).Item("AR_Charge") & ""
                Catch ex As Exception
                    MARCharge = False
                End Try
                Try
                    MCreditHold = DsGeneral.Tables("t1").Rows(0).Item("AR_credit_hold") & ""
                Catch ex As Exception
                    MCreditHold = False
                End Try
                Try
                    MAcceptCheck = DsGeneral.Tables("t1").Rows(0).Item("AR_accept_check") & ""
                Catch ex As Exception
                    MAcceptCheck = False
                End Try
                Try
                    MARCreditHold = DsGeneral.Tables("t1").Rows(0).Item("AR_credit_hold") & ""
                Catch ex As Exception
                    MARCreditHold = False
                End Try
                MAR_Term = DsGeneral.Tables("t1").Rows(0).Item("AR_Term") & ""
                MZipCode = DsGeneral.Tables("t1").Rows(0).Item("ZIP") & ""
                Try
                    MKIND_AR = DsGeneral.Tables("t1").Rows(0).Item("KIND_AR")
                Catch ex As Exception
                    MKIND_AR = 0
                End Try
                Try
                    MST_DISCOUNT_PERCENTAGE = DsGeneral.Tables("t1").Rows(0).Item("ST_DISCOUNT_PERCENTAGE")
                Catch ex As Exception
                    MST_DISCOUNT_PERCENTAGE = 0
                End Try
                Try
                    MST_NET_DUE_IN = DsGeneral.Tables("t1").Rows(0).Item("ST_NET_DUE_IN")
                Catch ex As Exception
                    MST_NET_DUE_IN = 0
                End Try
                Try
                    MST_IF_PAY_WITHIN_DAYS = DsGeneral.Tables("t1").Rows(0).Item("ST_IF_PAY_WITHIN_DAYS")
                Catch ex As Exception
                    MST_IF_PAY_WITHIN_DAYS = 0
                End Try
                Try
                    MDD_NET_DUE_BEFORE = DsGeneral.Tables("t1").Rows(0).Item("DD_NET_DUE_BEFORE")
                Catch ex As Exception
                    MDD_NET_DUE_BEFORE = 0
                End Try
                Try
                    MDD_IF_ISSUED_WITHIN_DAYS = DsGeneral.Tables("t1").Rows(0).Item("DD_IF_ISSUED_WITHIN_DAYS")
                Catch ex As Exception
                    MDD_IF_ISSUED_WITHIN_DAYS = 0
                End Try
                Try
                    MDD_DISCOUNT_PERCENTAGE = DsGeneral.Tables("t1").Rows(0).Item("DD_DISCOUNT_PERCENTAGE")
                Catch ex As Exception
                    MDD_DISCOUNT_PERCENTAGE = 0
                End Try
                Try
                    MDD_IF_PAY_WITHIN_DAYS = DsGeneral.Tables("t1").Rows(0).Item("DD_IF_PAY_WITHIN_DAYS")
                Catch ex As Exception
                    MDD_IF_PAY_WITHIN_DAYS = 0
                End Try
                Try
                    MMP_NO_OF_PAYMENT = DsGeneral.Tables("t1").Rows(0).Item("MP_NO_OF_PAYMENT")
                Catch ex As Exception
                    MMP_NO_OF_PAYMENT = 0
                End Try
                Try
                    MCreditLimit = DsGeneral.Tables("t1").Rows(0).Item("credit_limited")
                Catch ex As Exception
                    MCreditLimit = 0
                End Try
                Try
                    MMP_BEFORE_DAY = DsGeneral.Tables("t1").Rows(0).Item("MP_BEFORE_DAY")
                Catch ex As Exception
                    MMP_BEFORE_DAY = 0
                End Try
                MCustomerPhone = DsGeneral.Tables("t1").Rows(0).Item("phone_1") & ""
                Mabbreviation_name = DsGeneral.Tables("t1").Rows(0).Item("complete_name") & ""
                Maddress = DsGeneral.Tables("t1").Rows(0).Item("Address") & ""
                MEmailAddress = DsGeneral.Tables("t1").Rows(0).Item("email") & ""
                FindDesc = True
                RaiseEvent Findcod_customer()
            Else
                MCustomerName = ""
                MF_Name = ""
                MM_Name = ""
                ML_Name = ""
                MPrice_Level = "1"
                MTax_Amount = 0
                MCustomerPhone = ""
                Mabbreviation_name = ""
                Maddress = ""
                MEmailAddress = ""
                MAR_Term = ""
                MZipCode = ""
                MKIND_AR = 0
                MST_DISCOUNT_PERCENTAGE = 0
                MST_NET_DUE_IN = 0
                MST_IF_PAY_WITHIN_DAYS = 0
                MDD_NET_DUE_BEFORE = 0
                MDD_IF_ISSUED_WITHIN_DAYS = 0
                MDD_DISCOUNT_PERCENTAGE = 0
                MDD_IF_PAY_WITHIN_DAYS = 0
                MMP_NO_OF_PAYMENT = 0
                MMP_BEFORE_DAY = 0
                MCreditLimit = 0
                MRequire_PO = False
                MARCharge = False
                MCreditHold = False
                MAcceptCheck = False
                MARCreditHold = False
                RaiseEvent NotFindcod_customer()
            End If
        Catch ex As Exception
        End Try
    End Function

    Public Sub New()
        '
        Call InitDAcod_customer()

    End Sub
    Private Sub InitDAcod_customer()
        'DAcod_customer
        '
        Me.DAcod_customer.DeleteCommand = Me.DAcod_customerDelete
        Me.DAcod_customer.InsertCommand = Me.DAcod_customerInsert
        Me.DAcod_customer.SelectCommand = Me.DAcod_customerSelect
        Me.DAcod_customer.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "hes_tab_kol", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_kol", "cod_kol"), New System.Data.Common.DataColumnMapping("desc_kol", "desc_kol"), New System.Data.Common.DataColumnMapping("kind_cod_kol", "kind_cod_kol"), New System.Data.Common.DataColumnMapping("add_op", "add_op"), New System.Data.Common.DataColumnMapping("add_date", "add_date"), New System.Data.Common.DataColumnMapping("chg_op", "chg_op"), New System.Data.Common.DataColumnMapping("chg_date", "chg_date")})})
        Me.DAcod_customer.UpdateCommand = Me.DAcod_customerUpdate
        '
        'DAcod_customerDelete
        '
        Me.DAcod_customerDelete.CommandText = ""
        '
        'DAcod_customerInsert
        '
        Me.DAcod_customerInsert.CommandText = ""
        '
        'Dahes_tab_kolSelect
        '
        Me.DAcod_customerSelect.CommandText = "SELECT * FROM cust_trtab_main"
        '
        'DAcod_customerUpdate
        '
        Me.DAcod_customerUpdate.CommandText = ""
        '
    End Sub
    Sub AddAcod_customer()
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
    Sub EditAcod_customer()
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
    Sub DeleteAcod_customer()
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
