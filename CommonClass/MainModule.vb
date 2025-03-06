Imports Janus.Windows.GridEX
Imports System.Windows.Forms
Imports CommonClass
Public Module MainModule

    'Private Cnn As New System.Data.SqlClient.SqlConnection
    'Private CmnCmd As New System.Data.SqlClient.SqlCommand

    ''''''''''''''''''''''''''''''' TIRE MATE ''''''''''''''''''''''''''''''''''
    Public LenItem_No As Integer = 20
    Public LenCod_Service As Integer = 6
    Public LenCod_Package As Integer = 5
    Public LenCustomerCod As Integer = 10
    Public LenCompanyCod As Integer = 5
    Public LenVehicleCod As Integer = 4
    Public LenEmployeeCod As Integer = 5
    Public LenVendorCod As Integer = 6
    Public LenStoreCod As Integer = 2
    Public LenLabor_ServiceCod As Integer = 6
    Public LenInv_Price_Code As Integer = 5
    Public LenLine As Integer = 30
    Public LenLicenseNo As Integer = 20
    Public LenReceivePaymentReferenceNo As Integer = 8
    Public LenAccountAdjustmentReferenceNo As Integer = 8
    Public LenZipCode As Integer = 5
    Public PubScreenResolutionX As Integer = 800
    Public PubScreenResolutionY As Integer = 600
    Public PubButtonBarWidth As Integer = 145
    Public PubDateFormat As String = "MM/dd/yyyy"
    Public PubStartCashCod As String = "CASH100001"
    Public PubStartWorkOrderNo As String = "10000001"

    Public planguage As Language = Language.English

    Public PubMainImagePath As String

    Public PubFavoriteMenuRefreshFlag As Boolean = False

    Public PriceLevelsLabels(6) As String
    Public PWareHouse As String = "1"
    Public Sub InitSystemSetupTable()
        Dim OleDbReader As System.Data.OleDb.OleDbDataReader
        OleDbReader = RetrieveSetupTableInformation("INVENTORY_SETUP", " (StoreNo,PRICE_LEVEL_DESC1,PRICE_LEVEL_DESC2,PRICE_LEVEL_DESC3,PRICE_LEVEL_DESC4,PRICE_LEVEL_DESC5,PRICE_LEVEL_DESC6) values(" & Qt(PubStoreNO) & ",'Retail','WholeSale','Car Dealer', 'GovernMent','Army','In Store')", "Where StoreNo=" & Qt(PubStoreNO))
        PriceLevelsLabels(1) = OleDbReader.Item("PRICE_LEVEL_DESC1") & ""
        PriceLevelsLabels(2) = OleDbReader.Item("PRICE_LEVEL_DESC2") & ""
        PriceLevelsLabels(3) = OleDbReader.Item("PRICE_LEVEL_DESC3") & ""
        PriceLevelsLabels(4) = OleDbReader.Item("PRICE_LEVEL_DESC4") & ""
        PriceLevelsLabels(5) = OleDbReader.Item("PRICE_LEVEL_DESC5") & ""
        PriceLevelsLabels(6) = OleDbReader.Item("PRICE_LEVEL_DESC6") & ""
        PWareHouse = "1" ' If there is not record in inv_tab_wharehouse system must create it 
    End Sub
    ''''''''''''''''''''''''''''''' TIRE MATE ''''''''''''''''''''''''''''''''''
    Public PUserCod As Decimal = 0 '˜Ï ˜ÇÑÈÑ 
    Dim MyFrmMsg As New FrmMsg
    Public PubCompanyName As String = "Housing Investment Company"
    Public PubStoreNO As String = "01"
    Public PLogo As String = "D:/TireMate.Net/Message/resources/product.bmp"
    Public PubStoreName As String = " Demo "
    Public PUserName As String
    Public PSalMali As String = "2006"
    Public PConnectionString As String '= ""
    Public PConnectionStringForMenuMdb As String
    Public PConnectionStringForUserMdb As String
    Public PConnectionStringForGenerator As String
    Public PConnectionStringForSetupTables As String
    Public PConnectionStringMessage As String = "User ID=sa;Initial Catalog=message;Data Source=armandehxp;Packet Size=4096;Workstation ID=armandehxp"
    Public TypeOfWorkOrderItemCount As Integer = 10
    Public TypeOfWorkOrderItem() As String
    Public DescOfWorkOrderItem() As String
    Public Enum WorkStates
        AddNew
        Edit
        Delete
        Save
        Cancel
        _ReadOnly
    End Enum
    Public Enum Language
        Persian
        English
    End Enum
    'Public Enum TypeOfServiceCenterScreenTransaction
    '    _WO = 1
    '    _ES = 2
    '    _IN = 3
    'End Enum
    Public Enum TypeOperation
        AddNew = 1
        Edit = 2
        Delete = 3
        Show = 4
        'Print = 5
    End Enum
    Public Sub MakeDbNameAndConnection()
    End Sub
    Public Function MakeConnectionSqlForThisStore(ByVal ThisStore As String) As String
        Dim PassVar As String
        Dim ServerNameVar As String
        Dim UserNameVar As String
        Dim DatabaseNamevar As String
        Dim OldPConnection As String = PConnectionString

        DatabaseNamevar = "TireMate_" & ThisStore.Trim & ""   'PubStoreNO.Trim
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
        'PubMainImagePath = CType(configurationAppSettings.GetValue("MdbPath", GetType(System.String)), String).Trim
        Dim CnnOLE As New System.Data.OleDb.OleDbConnection
        Dim strOLEDB As String
        CnnOLE.ConnectionString = PConnectionStringForSetupTables
        strOLEDB = "select * from STORE_SETUP Where STORENO=" & Qt(ThisStore.Trim)
        Dim CmdOLEDB As New System.Data.OleDb.OleDbCommand(strOLEDB, CnnOLE)
        Dim MYOleDbDataReader As System.Data.OleDb.OleDbDataReader
        Try
            If CnnOLE.State <> ConnectionState.Open Then
                CnnOLE.Open()
            End If
            MYOleDbDataReader = CmdOLEDB.ExecuteReader
            MYOleDbDataReader.Read()
            ServerNameVar = Trim(MYOleDbDataReader.Item("SqlServerName") & "")
            UserNameVar = Trim(MYOleDbDataReader.Item("SqlUserName") & "")
            PassVar = PassDecode(Trim(MYOleDbDataReader.Item("SqlUserPassword") & ""))
            MYOleDbDataReader.Close()
            CnnOLE.Close()
            MakeConnectionSqlForThisStore = "workstation id=BAMDADIXP;packet size=4096;user id=" & UserNameVar & ";password=" & PassVar & ";data source=" & ServerNameVar & ";persist security info=False;initial catalog=" & DatabaseNamevar & " ;Connect Timeout=15"
        Catch ex As Exception
            'MsgBox("Setup File is incorrect.Please Contact to Vendor")
            MakeConnectionSqlForThisStore = ""
            Exit Function
        End Try
        'Check connection
        Dim Cnn As New System.Data.SqlClient.SqlConnection
        Dim strSQL As String
        Cnn.ConnectionString = MakeConnectionSqlForThisStore
        strSQL = "select count(*) from Employee"
        Dim cmd As New System.Data.SqlClient.SqlCommand(strSQL, Cnn)
        Try
            If Cnn.State <> ConnectionState.Open Then
                Cnn.Open()
            End If
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MakeConnectionSqlForThisStore = ""
        End Try
    End Function
    Public Function MakeConnectionStringForSQL(ByVal Inparam As Integer) As Boolean
        Dim PassVar As String
        Dim ServerNameVar As String
        Dim UserNameVar As String
        Dim DatabaseNamevar As String
        Dim OldPConnection As String = PConnectionString

        'DatabaseNamevar = "TireMate_" & PubStoreNO.Trim & "_" & PSalMali.Trim
        DatabaseNamevar = "TireMate_" & PubStoreNO.Trim
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
        PubMainImagePath = CType(configurationAppSettings.GetValue("MdbPath", GetType(System.String)), String).Trim

        Dim CnnOLE As New System.Data.OleDb.OleDbConnection
        Dim strOLEDB As String
        CnnOLE.ConnectionString = PConnectionStringForSetupTables
        strOLEDB = "select * from STORE_SETUP Where STORENO=" & Qt(PubStoreNO.Trim)
        Dim CmdOLEDB As New System.Data.OleDb.OleDbCommand(strOLEDB, CnnOLE)
        Dim MYOleDbDataReader As System.Data.OleDb.OleDbDataReader
        Try
            If CnnOLE.State <> ConnectionState.Open Then
                CnnOLE.Open()
            End If
            MYOleDbDataReader = CmdOLEDB.ExecuteReader
            MYOleDbDataReader.Read()
            ServerNameVar = Trim(MYOleDbDataReader.Item("SqlServerName") & "")
            UserNameVar = Trim(MYOleDbDataReader.Item("SqlUserName") & "")
            PassVar = PassDecode(Trim(MYOleDbDataReader.Item("SqlUserPassword") & ""))
            MYOleDbDataReader.Close()
            CnnOLE.Close()
        Catch ex As Exception
            MsgBox("Setup File is incorrect.Please Contact to Vendor")
            MakeConnectionStringForSQL = False
            Exit Function
        End Try

        'ServerNameVar = CType(configurationAppSettings.GetValue("ServerName", GetType(System.String)), String).Trim
        'UserNameVar = CType(configurationAppSettings.GetValue("UserName", GetType(System.String)), String).Trim
        'PassVar = PassDecode(CType(configurationAppSettings.GetValue("PassWord", GetType(System.String)), String).Trim)
        ''''''PConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=" & UserNameVar & ";initial catalog=" & PDatabaseName & ";persist security info=True;password=" & PassVar
        PConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=" & UserNameVar & ";password=" & PassVar & ";data source=" & ServerNameVar & ";persist security info=False;initial catalog=" & DatabaseNamevar & " ;Connect Timeout=15"

        Dim Cnn As New System.Data.SqlClient.SqlConnection
        Dim strSQL As String
        Cnn.ConnectionString = PConnectionString
        strSQL = "select count(*) from Employee"
        Dim cmd As New System.Data.SqlClient.SqlCommand(strSQL, Cnn)
        Try
            If Cnn.State <> ConnectionState.Open Then
                Cnn.Open()
            End If
            cmd.ExecuteNonQuery()
            MakeConnectionStringForSQL = True
        Catch ex As Exception
            If Inparam = 1 Then
                MsgBox("There is no Data Base For This Store.Please Start Sql Server Service Manager And Try Again OR Contact to Vendor.")
            Else
                MsgBox("There is no Data Base For This Store.")
            End If
            PConnectionString = OldPConnection
            MakeConnectionStringForSQL = False
        End Try
    End Function
    Public Function MakeConnectionSqlForThisStoreMessaging(ByVal ThisStore As String) As String
        Dim PassVar As String
        Dim ServerNameVar As String
        Dim UserNameVar As String
        Dim DatabaseNamevar As String
        Dim OldPConnection As String = PConnectionString

        DatabaseNamevar = "message_" & ThisStore.Trim
        'Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
        'PubMainImagePath = CType(configurationAppSettings.GetValue("MdbPath", GetType(System.String)), String).Trim
        'PubMainImagePath = CType(System.Configuration.ConfigurationSettings.AppSettings("MdbPath"), String).Trim
        Dim CnnOLE As New System.Data.OleDb.OleDbConnection
        Dim strOLEDB As String
        CnnOLE.ConnectionString = PConnectionStringForSetupTables
        strOLEDB = "select * from STORE_SETUP Where STORENO=" & Qt(ThisStore.Trim)
        Dim CmdOLEDB As New System.Data.OleDb.OleDbCommand(strOLEDB, CnnOLE)
        Dim MYOleDbDataReader As System.Data.OleDb.OleDbDataReader
        Try
            If CnnOLE.State <> ConnectionState.Open Then
                CnnOLE.Open()
            End If
            MYOleDbDataReader = CmdOLEDB.ExecuteReader
            MYOleDbDataReader.Read()
            ServerNameVar = Trim(MYOleDbDataReader.Item("SqlServerName") & "")
            UserNameVar = Trim(MYOleDbDataReader.Item("SqlUserName") & "")
            PassVar = PassDecode(Trim(MYOleDbDataReader.Item("SqlUserPassword") & ""))
            MYOleDbDataReader.Close()
            CnnOLE.Close()
            MakeConnectionSqlForThisStoreMessaging = "User ID=sa;Initial Catalog=" & DatabaseNamevar & ";Data Source=" & ServerNameVar & ";Packet Size=4096;Workstation ID=" & ServerNameVar
            'MakeConnectionSqlForThisStoreMessaging = "workstation id=BAMDADIXP;packet size=4096;user id=" & UserNameVar & ";password=" & PassVar & ";data source=" & ServerNameVar & ";persist security info=False;initial catalog=" & DatabaseNamevar
        Catch ex As Exception
            'MsgBox("Setup File is incorrect.Please Contact to Vendor")
            MakeConnectionSqlForThisStoreMessaging = ""
            Exit Function
        End Try

    End Function
    Public Function PassDecode(ByVal InString As String) As String
        Dim i As Integer, PlusCounter As Integer, K As Integer
        PlusCounter = 0
        PassDecode = ""
        Dim ChrVar As String
        If InString.Trim.Length > 0 Then
            For i = 1 To InString.Trim.Length
                K = Asc(Mid(InString, i, 1)) - (((i - PlusCounter) * 2) - (i - PlusCounter))
                If (Mid(InString, i, 1)) = "+" Then
                    i = i + 1
                    PlusCounter = PlusCounter + 1
                    PassDecode = PassDecode & Mid(InString, i, 1)
                Else
                    PassDecode = PassDecode & Chr(K)
                End If
            Next
        Else
            PassDecode = InString
        End If
    End Function
    Public Function EncryptPassword(ByVal InString As String) As String
        EncryptPassword = ""
        Dim i As Integer, k As Integer
        If InString.Trim.Length > 0 Then
            For i = 1 To InString.Trim.Length
                k = Asc(Mid(InString, i, 1)) + ((i * 2) - i)
                If (k >= 48 And k <= 57) Or (k >= 65 And k <= 90) Or (k >= 97 And k <= 122) Then
                    EncryptPassword = EncryptPassword & Chr(k)
                Else
                    EncryptPassword = EncryptPassword & "+" & Mid(InString, i, 1)
                End If
            Next
        Else
            EncryptPassword = InString
        End If
    End Function

    Public Function Getcod(ByVal ThisString As String, ByVal Len As Integer) As String
        Dim i As Integer
        Dim RealLen As Integer
        If ThisString Is Nothing Then Exit Function
        ThisString = ThisString.Trim & ""
        If ThisString.Trim.Length <> 0 Then
            RealLen = ThisString.Length
            For i = 1 To Len - RealLen
                ThisString = "0" & ThisString
            Next
        End If
        Getcod = ThisString
    End Function
    Public Sub MsgFar(ByVal ThisText As String)
        Try
            If ThisText.Trim.Length > 0 Then
                MyFrmMsg.TxtMsg.Text = ThisText
                MyFrmMsg.ShowDialog()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Function Qt(ByVal ThisString) As String
        Try
            Qt = "'" & ThisString & "'"
        Catch ex As Exception
            Qt = ""
        End Try
    End Function
    Public Sub PubErrHandle(ByVal ThisErrnumber As Integer, Optional ByVal ThisErrMessage As String = "")
        Select Case ThisErrnumber
            Case 547
                If ThisErrMessage.Trim.Length = 0 Then
                    'MsgFar("Can not Delete This Record" + vbCrLf + "This Information Is Used in Another form")
                    MsgFar("Because of existence of transactions or " & vbCrLf & " its usage in another form in the database " & vbCrLf & " deletion of this record is not allowded.")
                Else
                    MsgFar(ThisErrMessage)
                End If
            Case 2601
                If ThisErrMessage.Trim.Length = 0 Then
                    MsgFar("Duplicate Key" + vbCrLf + "Information Was not Saved.")
                Else
                    MsgFar(ThisErrMessage)
                End If
            Case 2627
                If ThisErrMessage.Trim.Length = 0 Then
                    MsgFar("Duplicate Key" + vbCrLf + "Information Was not Saved.")
                Else
                    MsgFar(ThisErrMessage)
                End If
            Case Else
                MsgBox(ThisErrMessage)
        End Select
    End Sub
    Public Sub FillTypeOfWorkOrderItem()
        ReDim TypeOfWorkOrderItem(TypeOfWorkOrderItemCount)
        ReDim DescOfWorkOrderItem(TypeOfWorkOrderItemCount)
        'TypeOfWorkOrderItem(0) = "I"
        'TypeOfWorkOrderItem(1) = "L"
        'TypeOfWorkOrderItem(2) = "F"
        'TypeOfWorkOrderItem(3) = "P"
        'TypeOfWorkOrderItem(4) = "C"
        'TypeOfWorkOrderItem(5) = "A"
        'TypeOfWorkOrderItem(6) = "T"
        'TypeOfWorkOrderItem(7) = "S"
        'TypeOfWorkOrderItem(8) = "O"
        TypeOfWorkOrderItem(0) = "P"
        TypeOfWorkOrderItem(1) = "I"
        TypeOfWorkOrderItem(2) = "L"
        TypeOfWorkOrderItem(3) = "F"
        TypeOfWorkOrderItem(4) = "O"
        TypeOfWorkOrderItem(5) = "C"
        TypeOfWorkOrderItem(6) = "A"
        TypeOfWorkOrderItem(7) = "T"
        TypeOfWorkOrderItem(8) = "S"
        TypeOfWorkOrderItem(9) = "B"
        DescOfWorkOrderItem(0) = "PACKAGE"
        DescOfWorkOrderItem(1) = "ITEMS"
        DescOfWorkOrderItem(2) = "LABOR"
        DescOfWorkOrderItem(3) = "FEE"
        DescOfWorkOrderItem(4) = "OUT.PURCHASE"
        DescOfWorkOrderItem(5) = "COMMENTS"
        DescOfWorkOrderItem(6) = "ADJUSTMENT"
        DescOfWorkOrderItem(7) = "TRADE"
        DescOfWorkOrderItem(8) = "SHOP SUPPLY"
        DescOfWorkOrderItem(9) = "ADD TO BALANCE"
    End Sub
    Public Function GetVal(ByVal ThisValue As String, ByVal ThisLen As Integer) As String
        Try
            ThisValue = ThisValue.Trim
            If ThisLen > Len(ThisValue) Then
                ThisLen = Len(ThisValue)
            End If
            GetVal = ""
            Dim i As Integer
            For i = ThisLen To 1 Step -1
                If IsNumeric(Mid(ThisValue, i, 1)) Then
                    GetVal = Mid(ThisValue, i, 1) & GetVal
                Else
                    Exit For
                End If
            Next
        Catch ex As Exception
            GetVal = ""
        End Try
    End Function
    Public Sub FitToScreen(ByRef ParentControl As Control, ByRef MyForm As Form)


        'oControl = Me

        'sizeForm.Width = MyFrmComments.Width
        'sizeForm.Height = MyFrmComments.Height
        'pntLocation.X = oControl.Location.X '+ oControl.Size.Width - sizeForm.Width
        'pntLocation.Y = oControl.Location.Y + oControl.Size.Height + 1
        'pntForm = oControl.Parent.PointToScreen(pntLocation)
        'If pntForm.Y + sizeForm.Height > Screen.PrimaryScreen.Bounds.Height - 40 Then
        '    pntForm.Y = pntForm.Y - sizeForm.Height - oControl.Size.Height - 1
        'End If
        'If (pntForm.X < 0) Then pntForm.X = 0
        'MyFrmComments.SetDesktopLocation(pntForm.X, pntForm.Y)
        'MyFrmComments.MyLeft = pntForm.X
        'MyFrmComments.MyTop = pntForm.Y



        Dim PntForm As System.Drawing.Point
        Dim PntLocation As System.Drawing.Point
        Dim OControl As Control = ParentControl
        Dim SizeForm As System.Drawing.Size

        SizeForm.Width = MyForm.Width
        SizeForm.Height = MyForm.Height
        PntLocation.X = OControl.Location.X
        PntLocation.Y = OControl.Location.Y + OControl.Size.Height + 2
        PntForm = OControl.Parent.PointToScreen(PntLocation)
        If PntForm.Y + SizeForm.Height > Screen.PrimaryScreen.Bounds.Height - 40 Then
            PntForm.Y = PntForm.Y - SizeForm.Height - OControl.Size.Height - 1
        End If
        If PntForm.X + SizeForm.Width > Screen.PrimaryScreen.Bounds.Width - 2 Then
            PntForm.X = PntForm.X - MyForm.Width + OControl.Size.Width - 1
        End If
        If PntForm.X < 0 Then PntForm.X = 0
        If PntForm.Y < 0 Then PntForm.Y = 0
        MyForm.SetDesktopLocation(PntForm.X, PntForm.Y)
        MyForm.Left = PntForm.X
        MyForm.Top = PntForm.Y
    End Sub
    Public Sub ClearThisCombo(ByRef ThisCombo As ComboBox)
        Try
            ThisCombo.SelectedValue = "0"
        Catch ex As Exception
        End Try
    End Sub
    Public Function ChkCombo(ByVal ThisValue As Object) As Object
        If IsNothing(ThisValue) Then
            Return System.DBNull.Value
        Else
            Return ThisValue
        End If
    End Function
    Public Function DecodeCheckBox(ByVal ThisValue As Object) As Object
        Try
            If ThisValue Then
                Return 1
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function ChkImage(ByVal ThisValue As Byte) As Object
        If IsNothing(ThisValue) Then
            Return System.DBNull.Value
        Else
            Return ThisValue
        End If
    End Function
    Public Function DateFormatChange(ByVal ThisValue As String) As String
        Try
            DateFormatChange = DateTime.ParseExact((ThisValue & ""), PubDateFormat, System.Globalization.DateTimeFormatInfo.CurrentInfo).ToShortDateString
        Catch ex As Exception
            DateFormatChange = ""
        End Try
    End Function
    Public Function RetrieveSetupTableInformation(ByVal InTable As String, ByVal InValueForInsert As String, Optional ByVal WhereClause As String = "") As System.Data.OleDb.OleDbDataReader
        Dim CnnMDB As New System.Data.OleDb.OleDbConnection
        CnnMDB.ConnectionString = PConnectionStringForSetupTables
        Dim CmdGeneralForMDB As New System.Data.OleDb.OleDbCommand
        CmdGeneralForMDB.Connection = CnnMDB
        If CmdGeneralForMDB.Connection.State <> ConnectionState.Open Then
            CmdGeneralForMDB.Connection.Open()
        End If
        CmdGeneralForMDB.CommandText = "SELECT Count(*) from " & InTable & " " & WhereClause
        If CmdGeneralForMDB.ExecuteScalar < 1 Then
            CmdGeneralForMDB.CommandText = "Insert Into " & InTable & " " & InValueForInsert
            CmdGeneralForMDB.ExecuteNonQuery()
        End If
        CmdGeneralForMDB.CommandText = "SELECT Top 1 * from " & InTable & " " & WhereClause
        RetrieveSetupTableInformation = CmdGeneralForMDB.ExecuteReader
        RetrieveSetupTableInformation.Read()
    End Function
    Public Function RetrieveAccountsPayableSetupTable() As System.Data.OleDb.OleDbDataReader
        RetrieveAccountsPayableSetupTable = RetrieveSetupTableInformation("Accounts_Payable_Setup", "(Default_AP_TRADE_GL_Account) values('Not Set')")
    End Function
    Public Function RetrieveAccountsReceivableSetupTable() As System.Data.OleDb.OleDbDataReader
        RetrieveAccountsReceivableSetupTable = RetrieveSetupTableInformation("Accounts_Receivable_Setup", "(Default_AR_GL_account) values('Not Set')")
    End Function
    Public Function RetrieveCompanySetupTable() As System.Data.OleDb.OleDbDataReader
        RetrieveCompanySetupTable = RetrieveSetupTableInformation("COMPANY_SETUP", "(NAME) values('Not Set')")
    End Function
    Public Function RetrieveGeneralLedgerSetupTable() As System.Data.OleDb.OleDbDataReader
        RetrieveGeneralLedgerSetupTable = RetrieveSetupTableInformation("General_Ledger_Setup", "(default_cash_over) values('Not Set')")
    End Function
    Public Function RetrieveInventorySetupTable(Optional ByVal ParamStore As String = "") As System.Data.OleDb.OleDbDataReader
        If IsNothing(ParamStore) Then
            ParamStore = "01"
        Else
            If ParamStore.Trim.Length = 0 Then
                ParamStore = PubStoreNO
            End If
        End If
        RetrieveInventorySetupTable = RetrieveSetupTableInformation("INVENTORY_SETUP", "(StoreNo) values(" & Qt(ParamStore) & ")", " Where StoreNo=" & Qt(ParamStore))
    End Function
    Public Function RetrievePayrollSetupTable() As System.Data.OleDb.OleDbDataReader
        RetrievePayrollSetupTable = RetrieveSetupTableInformation("Payroll_Setup", "(DEFAULT_PAYROLL_BANK) values('Not Set')")
    End Function
    Public Function RetrieveServiceSetupTable(Optional ByVal ParamStore As String = "") As System.Data.OleDb.OleDbDataReader
        If IsNothing(ParamStore) Then
            ParamStore = "01"
        Else
            If ParamStore.Trim.Length = 0 Then
                ParamStore = PubStoreNO
            End If
        End If
        RetrieveServiceSetupTable = RetrieveSetupTableInformation("SERVICE_SETUP", "(StoreNo) values(" & Qt(ParamStore) & ")", " Where StoreNo=" & Qt(ParamStore))
    End Function
    Public Function RetrieveStoreSetupTable(Optional ByVal ParamStore As String = "") As System.Data.OleDb.OleDbDataReader
        If IsNothing(ParamStore) Then
            ParamStore = "01"
        Else
            If ParamStore.Trim.Length = 0 Then
                ParamStore = PubStoreNO
            End If
        End If
        RetrieveStoreSetupTable = RetrieveSetupTableInformation("STORE_SETUP", "(StoreNo,StoreName,ShortName) values('01','Store Full Name','Short Name')", " Where StoreNo=" & Qt(ParamStore))
    End Function
    Public Sub SetPubCompanyName()
        Dim OleDbReader As System.Data.OleDb.OleDbDataReader
        OleDbReader = RetrieveCompanySetupTable()
        PubCompanyName = OleDbReader.Item("Name") & ""
    End Sub
    Public Function ChangeDateToYYYYMMDD(ByVal indate As String) As String
        ChangeDateToYYYYMMDD = ""
        indate = indate & ""
        If indate.Length = 10 Then
            ChangeDateToYYYYMMDD = Mid(indate, 7, 4) & "/" & Mid(indate, 1, 2) & "/" & Mid(indate, 4, 2)
        End If
    End Function
    'Public Shared Function GridToExcel(ByVal FileName As String, ByVal FilePath As String, ByVal Grid As GridEX)
    Public Function GridToExcel(ByVal FileName As String, ByVal FilePath As String, ByVal Grid As GridEX)
        Dim ColCount As Int16
        Dim RowCount As Int16
        Dim I, J As Int16
        Dim Table As GridEXTable = Grid.RootTable()
        Dim CurrentRow As GridEXRow
        Dim SW1 As System.IO.StreamWriter = New System.IO.StreamWriter(FilePath & "\" & FileName, False, System.Text.Encoding.Default)

        ColCount = Table.Columns.Count
        For I = 0 To ColCount - 1 Step 1
            SW1.Write(Table.Columns.Item(I).Caption & ";")
        Next I

        RowCount = Grid.RowCount
        For J = 0 To RowCount - 1 Step 1
            Grid.Row = J
            CurrentRow = Grid.GetRow
            SW1.WriteLine("")
            For I = 0 To ColCount - 1 Step 1
                SW1.Write(CurrentRow.Cells(I).Text & ";")
            Next I
        Next J
        SW1.Close()
    End Function
    Public Function GridToExcel2(ByVal FileName As String, ByVal Grid As GridEX)
        Dim ColCount As Int16
        Dim RowCount As Int16
        Dim I, J As Int16
        Dim Table As GridEXTable = Grid.RootTable()
        Dim CurrentRow As GridEXRow
        Dim SW1 As System.IO.StreamWriter = New System.IO.StreamWriter(FileName, False, System.Text.Encoding.Default)

        ColCount = Table.Columns.Count
        For I = 0 To ColCount - 1 Step 1
            SW1.Write(Table.Columns.Item(I).Caption & ";")
        Next I

        RowCount = Grid.RowCount
        For J = 0 To RowCount - 1 Step 1
            Grid.Row = J
            CurrentRow = Grid.GetRow
            SW1.WriteLine("")
            For I = 0 To ColCount - 1 Step 1
                SW1.Write(CurrentRow.Cells(I).Text & ";")
            Next I
        Next J
        SW1.Close()
    End Function
    Public Class SoundClass
        Declare Auto Function PlaySound Lib "winmm.dll" (ByVal name _
           As String, ByVal hmod As Integer, ByVal flags As Integer) As Integer
        ' name specifies the sound file when the SND_FILENAME flag is set.
        ' hmod specifies an executable file handle.
        ' hmod must be Nothing if the SND_RESOURCE flag is not set.
        ' flags specifies which flags are set. 

        ' The PlaySound documentation lists all valid flags.
        Public Const SND_SYNC = &H0          ' play synchronously
        Public Const SND_ASYNC = &H1         ' play asynchronously
        Public Const SND_FILENAME = &H20000  ' name is file name
        Public Const SND_RESOURCE = &H40004  ' name is resource name or atom
        Public Sub PlaySoundFile(ByVal filename As String)
            ' Plays a sound from filename.
            PlaySound(filename, Nothing, SND_FILENAME Or SND_ASYNC)
        End Sub
    End Class
    Public Function InsertSpaceAfter(ByVal ThisString As String, ByVal Len As Integer) As String
        Dim i As Integer
        Dim RealLen As Integer
        If ThisString Is Nothing Then Exit Function
        ThisString = ThisString.Trim & ""
        If ThisString.Trim.Length <> 0 Then
            RealLen = ThisString.Length
            For i = 1 To Len - RealLen
                ThisString = ThisString & " "
            Next
        End If
        InsertSpaceAfter = ThisString
    End Function
    Public Function CalcDueDetail(ByVal ParamAR_terms As String, ByVal ParamAmount As Decimal, ByVal ParamDate As String, ByRef ParamDataTable As DataTable, Optional ByVal CalcOnlyFirstDueDate As Boolean = False, Optional ByRef FirstDueDate As String = "") As Boolean
        Try
            ParamDataTable.Clear()
            Dim CnnForReader As New System.Data.SqlClient.SqlConnection
            Dim SQLReader As System.Data.SqlClient.SqlDataReader
            Dim strSQL As String
            CnnForReader.ConnectionString = PConnectionString
            strSQL = "Select top 1 * From GL_TAB_AR_TERM where AR_terms=" & Qt(ParamAR_terms)
            Dim CmdForReader As New System.Data.SqlClient.SqlCommand(strSQL, CnnForReader)
            If CnnForReader.State <> ConnectionState.Open Then
                CnnForReader.Open()
            End If
            SQLReader = CmdForReader.ExecuteReader
            If SQLReader.HasRows Then
                SQLReader.Read()
                Dim StartDueDateVar As String = ParamDate
                Select Case SQLReader.Item("KIND_AR")
                    Case 1
                        StartDueDateVar = Format(CType(ParamDate, Date).AddDays(SQLReader.Item("ST_NET_DUE_IN")), PubDateFormat)
                    Case 2
                        Dim BeforDatevar As String = ParamDate
                        If Val(Mid(ParamDate, 4, 2)) >= SQLReader.Item("DD_NET_DUE_BEFORE") Then
                            StartDueDateVar = Format(CType(ParamDate, Date).AddMonths(1), PubDateFormat)
                        End If
                        StartDueDateVar = Mid(StartDueDateVar, 1, 3) & Getcod(Str(SQLReader.Item("DD_NET_DUE_BEFORE")), 2) & Mid(StartDueDateVar, 6, 5)
                        If CType(StartDueDateVar, Date).Subtract(CType(BeforDatevar, Date)).TotalDays < SQLReader.Item("DD_IF_ISSUED_WITHIN_DAYS") Then
                            StartDueDateVar = Format(CType(StartDueDateVar, Date).AddMonths(1), PubDateFormat)
                        End If
                    Case 3
                        StartDueDateVar = Mid(ParamDate, 1, 3) & Getcod(Str(SQLReader.Item("MP_BEFORE_DAY")), 2) & Mid(ParamDate, 6, 5)
                End Select
                If SQLReader.Item("KIND_AR") = 3 And SQLReader.Item("MP_NO_OF_PAYMENT") > 0 Then
                    Dim NO_OF_PAYMENTCounter As Integer
                    Dim EachPayvar As Decimal
                    EachPayvar = Math.Round(ParamAmount / SQLReader.Item("MP_NO_OF_PAYMENT"), 2)
                    For NO_OF_PAYMENTCounter = 1 To SQLReader.Item("MP_NO_OF_PAYMENT")
                        If NO_OF_PAYMENTCounter = SQLReader.Item("MP_NO_OF_PAYMENT") Then
                            EachPayvar = ParamAmount - (EachPayvar * (NO_OF_PAYMENTCounter - 1))
                        End If
                        If CalcOnlyFirstDueDate Then
                            FirstDueDate = Format(CType(StartDueDateVar, Date).AddMonths(NO_OF_PAYMENTCounter), PubDateFormat)
                            Exit For
                        End If
                        Dim dr As DataRow
                        dr = ParamDataTable.NewRow
                        dr(0) = Format(CType(StartDueDateVar, Date).AddMonths(NO_OF_PAYMENTCounter), PubDateFormat)
                        dr(1) = EachPayvar
                        ParamDataTable.Rows.Add(dr)
                    Next
                Else
                    If CalcOnlyFirstDueDate Then
                        FirstDueDate = StartDueDateVar
                    Else
                        Dim dr As DataRow
                        dr = ParamDataTable.NewRow
                        dr(0) = StartDueDateVar
                        dr(1) = ParamAmount
                        ParamDataTable.Rows.Add(dr)
                    End If
                End If
                SQLReader.Close()
            End If
            CalcDueDetail = True
        Catch ex As Exception
            ParamDataTable.Clear()
            CalcDueDetail = False
        End Try
    End Function
    Public Function MakeDateCorrect(ByVal ThisDate As String) As String
        Try
            Dim ColumnPosition1 As Integer = 0
            Dim ColumnPosition2 As Integer = 0
            Dim DayTempVar As String
            Dim MonthTempVar As String
            ColumnPosition1 = InStr(ThisDate, "/")
            If ColumnPosition1 < 1 Then
                MakeDateCorrect = ""
            Else
                MonthTempVar = Getcod(Mid(ThisDate, 1, ColumnPosition1 - 1), 2)
                ColumnPosition2 = InStr(ColumnPosition1 + 1, ThisDate, "/")
                If ColumnPosition2 < 1 Then
                    MakeDateCorrect = ""
                Else
                    DayTempVar = Getcod(Mid(ThisDate, ColumnPosition1 + 1, ColumnPosition2 - ColumnPosition1 - 1), 2)
                    MakeDateCorrect = MonthTempVar + "/" + DayTempVar + "/" + Getcod(Mid(ThisDate, ColumnPosition2 + 1), 4)
                End If
            End If
        Catch ex As Exception
            MakeDateCorrect = ""
        End Try
    End Function
End Module
