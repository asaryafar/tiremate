Module Module1
    Friend Function Retrieve_GLAccount(ByVal Thisdeduction_type As Decimal) As String
        Dim OleDbReader As System.Data.OleDb.OleDbDataReader
        OleDbReader = CommonClass.RetrievePayrollSetupTable()
        Select Case Thisdeduction_type
            Case "01"
                Retrieve_GLAccount = OleDbReader.Item("DEFAULT_PAYROLL_BANK") & ""
        End Select
    End Function
End Module
