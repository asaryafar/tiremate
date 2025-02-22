Imports System.Windows.Forms
Public Class UserAllow
    Friend AllowAddnew As Boolean = True
    Friend AllowEdit As Boolean = True
    Friend AllowDelete As Boolean = True
    Friend AllowPrint As Boolean = True
End Class



Public Class ClassWhatDo
    Private MyFrmWhatDoForMenu As FrmWhatDoForMenu
    Public Result As DialogResult
    Public Property Txt() As String
        Get
            Return Txt
        End Get
        Set(ByVal Value As String)
            Txt = Value
        End Set
    End Property

    Sub New()
        MyFrmWhatDoForMenu = New FrmWhatDoForMenu
    End Sub

    Sub finilize()
        MyFrmWhatDoForMenu = Nothing
    End Sub

    Public Sub ShowMsg()
        If Txt.Trim.Length > 0 Then
            MyFrmWhatDoForMenu.TxtMsg.Text = Txt
            MyFrmWhatDoForMenu.ShowDialog()
            Result = MyFrmWhatDoForMenu.DialogResult
            'Select Case MyFrmWhatDoForMenu.DialogResult
            '    Case DialogResult.Yes
            '        Result = DialogResult.Yes
            '    Case DialogResult.No
            '        Result = DialogResult.No
            '    Case DialogResult.OK
            '        Result = DialogResult.No
            'End Select
        End If
    End Sub

    Public Sub ShowMsg(ByVal ThisText As String)
        If ThisText.Trim.Length > 0 Then
            MyFrmWhatDoForMenu.TxtMsg.Text = ThisText
            MyFrmWhatDoForMenu.ShowDialog()
            Result = MyFrmWhatDoForMenu.DialogResult
        End If
    End Sub


End Class
Public Class AllStore
    Public Event FindErrorInMultiStoreAdd(ByVal errorx As Exception, ByVal ThisCmd As System.Data.SqlClient.SqlCommand, ByVal StoreNumber As String, ByVal StoreName As String)
    Public Sub AllStoreCommand(ByVal ThisCmd As System.Data.SqlClient.SqlCommand, Optional ByVal OneStoreFlag As Boolean = True, Optional ByVal showErrors As Boolean = True)
        Dim CnnMdbSetup As New System.Data.OleDb.OleDbConnection(PConnectionStringForSetupTables)
        Dim MyFrmShowErrorAllStoreInsert As New FrmShowErrorAllStoreInsert
        Dim DASTORE_SETUP As New System.Data.OleDb.OleDbDataAdapter
        Dim OleDbCommand1 As New System.Data.OleDb.OleDbCommand
        Dim ij As Integer = 0
        Dim destconnectionstring As String = ""
        Dim BefAllStoreCommandCnnTmp As System.Data.SqlClient.SqlConnection = ThisCmd.Connection
        If ThisCmd.Connection.State = ConnectionState.Open Then
            ThisCmd.Connection.Close()
        End If

        DASTORE_SETUP.SelectCommand = OleDbCommand1
        OleDbCommand1.CommandText = "SELECT STORENO,storename FROM STORE_SETUP ORDER BY STORENO"
        OleDbCommand1.Connection = CnnMdbSetup
        Dim dstmp As New DataSet
        DASTORE_SETUP.Fill(dstmp, "allstore")
        If Not OneStoreFlag Then
            If dstmp.Tables("allstore").Rows.Count > 0 Then
                For ij = 0 To dstmp.Tables("allstore").Rows.Count - 1
                    destconnectionstring = MakeConnectionSqlForThisStore(dstmp.Tables("allstore").Rows(ij).Item("Storeno"))
                    Dim AllStoreCommandCnnTmp As New System.Data.SqlClient.SqlConnection
                    If destconnectionstring.Trim & "" <> "" Then
                        AllStoreCommandCnnTmp.ConnectionString = destconnectionstring
                        ThisCmd.Connection = AllStoreCommandCnnTmp
                        ThisCmd.Connection.Open()
                        Try
                            ThisCmd.ExecuteNonQuery()
                            MyFrmShowErrorAllStoreInsert.LstNote.Items.Add(" Store no  " & dstmp.Tables("allstore").Rows(ij).Item("Storeno") & "  " & dstmp.Tables("allstore").Rows(ij).Item("StoreName") & "  Insert Complete ")
                        Catch ex As Exception
                            MyFrmShowErrorAllStoreInsert.LstNote.Items.Add(" Store no  " & dstmp.Tables("allstore").Rows(ij).Item("Storeno") & "  " & dstmp.Tables("allstore").Rows(ij).Item("StoreName") & " Not Inserted ")
                            RaiseEvent FindErrorInMultiStoreAdd(ex, ThisCmd, dstmp.Tables("allstore").Rows(ij).Item("Storeno"), dstmp.Tables("allstore").Rows(ij).Item("StoreName"))
                        Finally
                            ThisCmd.Connection.Close()
                        End Try
                    End If
                Next
            End If
            ThisCmd.Connection = BefAllStoreCommandCnnTmp
        Else
            ThisCmd.Connection = BefAllStoreCommandCnnTmp
            ThisCmd.Connection.Open()
            Try
                ThisCmd.ExecuteNonQuery()
            Catch ex As Exception
                RaiseEvent FindErrorInMultiStoreAdd(ex, ThisCmd, PubStoreNO, PubStoreName)
            Finally
                ThisCmd.Connection.Close()
            End Try
        End If
        If showErrors = True And OneStoreFlag = False Then
            If dstmp.Tables("allstore").Rows.Count > 1 Then
                MyFrmShowErrorAllStoreInsert.ShowDialog()
            End If
        End If
    End Sub
End Class

