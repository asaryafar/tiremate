Imports CommonClass
Public Module MainModule
    Public PubMFrmMain As FrmMain
    Dim WithEvents MyLogin As FrmLogin
    Sub main()
        Dim MdbPath As String
        Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
        MdbPath = CType(configurationAppSettings.GetValue("MdbPath", GetType(System.String)), String).Trim
        PConnectionStringForUserMdb = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & MdbPath & "\User.mdb;Persist Security Info=True;Jet OLEDB:Database Password=5332"
        PConnectionStringForMenuMdb = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & MdbPath & "\Menu.mdb;Persist Security Info=True;Jet OLEDB:Database Password=5332"
        PConnectionStringForSetupTables = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & MdbPath & "\TireMatesetup.mdb;Persist Security Info=True;Jet OLEDB:Database Password=5332"
        PConnectionStringForGenerator = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & MdbPath & "\Form.mdb;Persist Security Info=True;Jet OLEDB:Database Password=5332"
        PLogo = MdbPath & "/resources/product.bmp"
        Dim MyFrmSplash As New UCMenu.FrmSplash

        MyLogin = New FrmLogin

        MyFrmSplash.ShowDialog()

        Do While PUserName = ""
            MyLogin.ShowDialog()
        Loop

        If Not MakeConnectionStringForSQL(1) Then '⁄œ„ «„ﬂ«‰ »—ﬁ—«—Ì «— »«ÿ »« Å«Ìê«Â œ«œÂ
            End
        End If


        PConnectionStringMessage = MakeConnectionSqlForThisStoreMessaging(PubStoreNO)

        Call InitSystemSetupTable()

        PubMFrmMain = New FrmMain
        PubMFrmMain.CnnUserMDB.Close()
        PubMFrmMain.CnnUserMDB.ConnectionString = PConnectionStringForUserMdb
        PubMFrmMain.CnnMenuMDB.Close()
        PubMFrmMain.CnnMenuMDB.ConnectionString = PConnectionStringForMenuMdb
        'Try
        'PubMFrmMain.HMCnn.Open()
        'PubMFrmMain.Sb1.Panels.Item(0).Text = " ‰«„ ﬂ«—»—  " & PUserName
        PubMFrmMain.ShowDialog()
        'Catch ex As Exception
        '   MsgBox(ex.ToString)
        '  End Try
    End Sub
    Public Sub MyLogin_ExitOfForm() Handles MyLogin.ExitOfForm
        End
    End Sub
    Public Sub MyLogin_PassWordOk(ByVal Id As Integer, ByVal Name As String, ByVal StoreNo As String, ByVal StoreName As String) Handles MyLogin.PassWordOk
        PUserCod = Id
        PUserName = Name.Trim
        PubStoreNO = StoreNo
        PubStoreName = StoreName
        Call SetPubCompanyName()
    End Sub
End Module
