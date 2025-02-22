Public Class ClsLock
    Dim BiginLockStatements As String = ""
    Dim EndLockStatements As String = ""
    Public FirstExecuted As Boolean = False
    Dim MCnn1 As System.Data.SqlClient.SqlConnection
    Public Event ICantLockThis(ByVal ThisId As String)
    Public trans1 As SqlClient.SqlTransaction
    Public Property Cnn1() As System.Data.SqlClient.SqlConnection
        Get
            Return MCnn1
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            MCnn1 = Value
        End Set
    End Property
    Public WithEvents Cmd1 As New System.Data.SqlClient.SqlCommand
    Public WithEvents Cmd2 As New System.Data.SqlClient.SqlCommand
    Public Sub New()
        BiginLockStatements = "  set lock_timeout 5000 ;" + vbCrLf + "  set transaction isolation level REPEATABLE READ ;" + vbCrLf + " begin transaction "  '«Ì‰ ò«—Â« œ—”  ‰Ì”  
        EndLockStatements = "Commit transaction ;" + vbCrLf + " set transaction isolation level read committed "

    End Sub
    Function LockThisItemInLockTable(ByVal ThisId As String, ByVal ThisTable As String)
        Try
            Call FirstExecute()
            checkcnn(Cnn1)
            Cmd2.CommandText = " update " & ThisTable & "  set  DummyValue =  1" & " where locktype = " & CommonClass.Qt(ThisId)
            Cmd2.ExecuteNonQuery()
        Catch ex As Exception
            RaiseEvent ICantLockThis(ThisId)
        End Try
    End Function
    Function UnLockIt()
        checkcnn(Cnn1)
        ' Cmd2.CommandText = EndLockStatements
        Try
            '    Cmd2.ExecuteNonQuery()
            trans1.Commit()
        Catch ex As Exception
        End Try
        Try
            Cnn1.Close()
        Catch ex As Exception
        End Try
    End Function
    Function FirstExecute()
        If Not FirstExecuted Then
            FirstExecuted = True
            checkcnn(Cnn1)
            Try
                ''''Cmd1.CommandText = BiginLockStatements
                ''''Cmd1.ExecuteNonQuery()
                trans1 = Cnn1.BeginTransaction(IsolationLevel.RepeatableRead)
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                'Cnn1.Close()
            End Try
        End If
    End Function
    Function checkcnn(ByVal Thiscnn As System.Data.SqlClient.SqlConnection)

        Cmd1.Connection = Cnn1
        Cmd2.Connection = Cnn1
        Cmd1.Transaction = trans1
        Cmd2.Transaction = trans1
        If Thiscnn.State <> ConnectionState.Open Then
            Thiscnn.Open()
        End If
    End Function
    Sub SelectLock(ByVal ThisDA As System.Data.SqlClient.SqlDataAdapter)
        Dim i As Integer = 0
        Dim value1 As String = ""
        Try
            Call FirstExecute()
            checkcnn(Cnn1)
            Cmd2.CommandText = ThisDA.SelectCommand.CommandText
            For i = 0 To ThisDA.SelectCommand.Parameters.Count - 1
                value1 = ""
                Select Case ThisDA.SelectCommand.Parameters(i).SqlDbType
                    Case SqlDbType.VarChar
                        value1 = "'" & ThisDA.SelectCommand.Parameters(i).Value & "'"
                    Case Else
                        value1 = ThisDA.SelectCommand.Parameters(i).Value
                End Select
                Cmd2.CommandText = Cmd2.CommandText.Replace(ThisDA.SelectCommand.Parameters(i).ParameterName, value1)
            Next
            Cmd2.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
            '            RaiseEvent ICantLockThis(ThisId)
        End Try
    End Sub
End Class


