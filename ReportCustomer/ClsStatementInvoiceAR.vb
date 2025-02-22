Imports System.Data.SqlClient
Imports CommonClass
Public Class ClsStatementInvoiceAR
    Dim Cnn As New SqlConnection
    Dim DAGeneral As New SqlDataAdapter("", Cnn)
    Dim CmdGeneral As New SqlCommand("", Cnn)
    Dim StrWhere As String = ""
    Dim StrClass As String = ""
    Dim StrCus As String = ""
    Dim strType As String = ""
    Dim strdate As String = ""
    Public FClass, Fcus, Ftype As Boolean
    Public date1, date2 As String
    Dim ComName As String = SystemInformation.ComputerName
    Public DS As DataSet

    Dim DSRep As New DSClsState
    Dim WithEvents MyZipCode As UCZipCode.ClsZipCode
    Private Sub MakeWhereStr()
        Dim i As Integer
        If Fcus Then
           
                Try
                    CmdGeneral.CommandText = " create table Cust_" & ComName & "(cod_customer char(10))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Cust_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DS.Tables("customer").Rows.Count - 1
                    If DS.Tables("customer").Rows(i).Item("flag") Then

                        CmdGeneral.CommandText = " INSERT INTO cust_" & ComName & " (cod_customer ) VALUES (" & Qt(DS.Tables("customer").Rows(i).Item("cod")) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                StrCus = " cust_trtab_main.cod_customer in (select cod_customer from cust_" & ComName & ") "

        End If
        strType = ""
        'flagcontrol = False
        If Ftype Then
           
                Try
                    CmdGeneral.CommandText = " create table Type_" & ComName & "(cod_type char(1))"
                    If CmdGeneral.Connection.State = ConnectionState.Closed Then
                        CmdGeneral.Connection.Open()
                    End If
                    CmdGeneral.ExecuteNonQuery()
                Catch ex As Exception
                    CmdGeneral.CommandText = " DELETE FROM Type_" & ComName
                    CmdGeneral.ExecuteNonQuery()
                End Try


                For i = 0 To DS.Tables("type").Rows.Count - 1
                    If DS.Tables("type").Rows(i).Item("flag") Then

                        CmdGeneral.CommandText = " INSERT INTO Type_" & ComName & " (cod_type ) VALUES (" & Qt(DS.Tables("type").Rows(i).Item("cod")) & ") "
                        CmdGeneral.ExecuteNonQuery()

                    End If
                Next
                strType = " cust_trtab_main.cod_type in (select cod_type from Type_" & ComName & ") "
           
        End If

        StrClass = ""
        If FClass Then

            Try
                CmdGeneral.CommandText = " create table Class_" & ComName & "(cod_class char(1))"
                If CmdGeneral.Connection.State = ConnectionState.Closed Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.ExecuteNonQuery()
            Catch ex As Exception
                CmdGeneral.CommandText = " DELETE FROM Class_" & ComName
                CmdGeneral.ExecuteNonQuery()
            End Try


            For i = 0 To DS.Tables("clas").Rows.Count - 1
                If DS.Tables("clas").Rows(i).Item("flag") Then

                    CmdGeneral.CommandText = " INSERT INTO Class_" & ComName & " (cod_class ) VALUES (" & Qt(DS.Tables("clas").Rows(i).Item("cod")) & ") "
                    CmdGeneral.ExecuteNonQuery()

                End If
            Next
            StrClass = " cust_trtab_main.cod_class in (select cod_class from Class_" & ComName & ") "


        End If

        StrDate = ""
        

        If date1.Trim.Length > 0 Then

            strdate = " dbo.ChangeDate(service_center_head.date_refer)  between " & Qt(ChangeDateToYYYYMMDD(date1)) & " and " & Qt(ChangeDateToYYYYMMDD(date2))

        End If

        StrWhere = ""

        If date1.Trim.Length > 0 Then
            StrWhere = StrWhere & " (" & strdate & ") and "
        End If
        If Fcus Then
            StrWhere = StrWhere & " (" & StrCus & ") and "
        End If

        If Ftype Then
            StrWhere = StrWhere & " (" & strType & ") and "
        End If

        If FClass Then
            StrWhere = StrWhere & "(" & StrClass & ") and "
        End If
        If StrWhere.Trim.Length > 0 Then StrWhere = Mid(StrWhere, 1, StrWhere.Length - 4)
    End Sub
    Private Sub DropTable()
        If Fcus Then
            CmdGeneral.CommandText = " DROP TABLE Cust_" & ComName
            If CmdGeneral.Connection.State = ConnectionState.Closed Then
                CmdGeneral.Connection.Open()
            End If
            Try
                CmdGeneral.ExecuteNonQuery()
            Catch ex As Exception
            End Try
        End If
        If Ftype Then
            CmdGeneral.CommandText = " DROP TABLE Type_" & ComName
            If CmdGeneral.Connection.State = ConnectionState.Closed Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.ExecuteNonQuery()
        End If

        If FClass Then
            CmdGeneral.CommandText = " DROP TABLE Class_" & ComName
            If CmdGeneral.Connection.State = ConnectionState.Closed Then
                CmdGeneral.Connection.Open()
            End If
            CmdGeneral.ExecuteNonQuery()
        End If
    End Sub

    Public Sub FillDAtaset(ByVal type As String)

        Cnn.ConnectionString = PConnectionString
        Call MakeWhereStr()

        MyZipCode = New UCZipCode.ClsZipCode
        MyZipCode.Connection = Me.Cnn
        ''DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.address as cod_customer, cust_trtab_main.f_name + ' ' + cust_trtab_main.m_name + ' ' + cust_trtab_main.l_name AS name,  " & _
        ''      "   cust_company.complete_name + '' AS complete_name, service_center_head.date_refer AS date, service_center_head.id_service_center AS id,  " & _
        ''      "   ROUND(ISNULL(GL_payment_deposit.payment_amount, 0), 2) AS charge, 0 AS credit, 0 AS adj, GL_payment_AR.AR_due_date AS due, 1 AS flag,  " & _
        ''      "  dbo.ChangeDate(service_center_head.date_refer) AS OrderDate, CASE WHEN cust_company.complete_name IS NULL  " & _
        ''      "  THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
        ''      "  + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName, ROUND(ISNULL(GL_payment_deposit.Paid_amount,  " & _
        ''      "  0), 2) AS Paid_amount, 0 AS Down, 0 AS OVERPAID, 0 AS Other ,ROUND(ISNULL(   service_center_head.Total, 0), 2) as Balance" & _
        ''      "  FROM         cust_trtab_main INNER JOIN " & _
        ''      "  service_center_head ON cust_trtab_main.cod_customer = service_center_head.cod_customer INNER JOIN " & _
        ''      "  GL_payment_deposit ON service_center_head.id_service_center = GL_payment_deposit.id_service_center INNER JOIN " & _
        ''      "  GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment LEFT OUTER JOIN " & _
        ''      "  cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " & _
        ''      " WHERE  cust_trtab_main.AR_send_copy='1' and    (service_center_head.type_of_form = 'IN') AND (cust_trtab_main.AR_charge = '1') AND " & _
        ''       " (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.payment_type = '4') " & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "")


        ''DAGeneral.Fill(DS, "CusARLedgerDetail")


        ''Dim rpt As New RepInvForStatement
        ''Dim prn As New FrmRepView
        '''DS.Tables("LOGO").Clear()
        '''Dim OleDbReaderForCompany As System.Data.OleDb.OleDbDataReader
        '''OleDbReaderForCompany = RetrieveCompanySetupTable()
        '''Dim DR As DataRow
        '''DR = DS.Tables("LOGO").NewRow
        '''DR("Cologo") = OleDbReaderForCompany.Item("LOGO")
        '''DR("ID") = 1


        '''Try
        '''    '            DS.Tables("LOGO").Rows.Add(OleDbReaderForCompany.Item("LOGO"), "l")
        '''    DS.Tables("LOGO").Rows.Add(DR)
        '''Catch ex As Exception
        '''    MsgBox(ex.Message)
        '''End Try
        ''Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        ''OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)

        ''rpt.SetParameterValue("Parconame", OleDbReaderForStore.Item("STORENAME") & "")
        ''rpt.SetParameterValue("Parcoaddress", OleDbReaderForStore.Item("ADDRESS") & "")

        ''rpt.SetParameterValue("Parcophone", OleDbReaderForStore.Item("PHONE") & "")
        ''rpt.SetParameterValue("Parcofax", OleDbReaderForStore.Item("FAX") & "")
        ''rpt.SetParameterValue("Parcoemail", OleDbReaderForStore.Item("EMAIL") & "")
        ''rpt.SetDataSource(DS)




      
        DAGeneral.SelectCommand.CommandText = " SELECT     cust_trtab_main.cod_customer, service_center_head.id_service_center, service_center_head.date_refer, case when ltrim(rtrim(isnull(cust_trtab_main.f_name,'')))<>'' then  LTRIM(RTRIM(cust_trtab_main.f_name))  " & _
"                      + '  ' + LTRIM(RTRIM(cust_trtab_main.l_name)) else cust_company.complete_name end AS NameCus  , cust_trtab_main.address,  " & _
"                      ZipCus.city + '  ' + ZipCus.state + '  ' + ZipCus.zipcode AS ZipCus,  " & _
"                      CASE WHEN cust_trtab_main.phone_main_1 = '1' THEN cust_trtab_main.phone_1 WHEN cust_trtab_main.phone_main_2 = '1' THEN cust_trtab_main.phone_2 " & _
"                       WHEN cust_trtab_main.phone_main_3 = '1' THEN cust_trtab_main.phone_3 WHEN cust_trtab_main.phone_main_4 = '1' THEN cust_trtab_main.phone_4 " & _
"                       WHEN cust_trtab_main.phone_main_5 = '1' THEN cust_trtab_main.phone_5 END AS phone, bas_vehicle_company.desc_make,  " & _
"                      bas_vehicle_model.desc_model, bas_vehicle.make_year, inv_tab_kind_engine.desc_kind_engine, bas_color.desc_color,  " & _
"                      service_center_head.add_user, service_center_head.chg_user, service_center_head.id_service_center_before, service_center_head.po_no,  " & _
"                      CASE WHEN GL.payment_type = '4' THEN gl.payment_amount END AS AR, CASE WHEN GL.payment_type = '4' THEN gl.AR_terms END AS AR_terms,  " & _
"                      CASE WHEN GL.payment_type = '4' THEN gl.AR_due_date END AS AR_due_date, service_center_dtl.cod_technician, service_center_dtl.qty,  " & _
"                      service_center_dtl.cod_select, service_center_dtl.desc_radif, service_center_dtl.price, service_center_dtl.type_select, service_center_dtl.fet,  " & _
"                      service_center_head.house_comment, service_center_head.Total, CASE WHEN cust_company.complete_name IS NULL  " & _
"                      THEN 'zzzzzzz' ELSE cust_company.complete_name END + LTRIM(RTRIM(cust_trtab_main.l_name)) + ' ' + LTRIM(RTRIM(cust_trtab_main.m_name))  " & _
"                      + ' ' + LTRIM(RTRIM(cust_trtab_main.f_name)) + cust_trtab_main.cod_customer AS OrderName, ser_tr_vehicle_dtl.current_mileage,  " & _
"                      ser_tr_vehicle.license_no_vehicle, ser_tr_vehicle.unit_no, ser_tr_vehicle.vin , service_center_head.discount, service_center_head.tax " & _
"FROM         bas_zipcode ZipCus RIGHT OUTER JOIN " & _
"                      ser_tr_vehicle_dtl RIGHT OUTER JOIN " & _
"                      service_center_head INNER JOIN " & _
"                      service_center_dtl ON service_center_head.id_service_center = service_center_dtl.id_service_center INNER JOIN " & _
"                      cust_trtab_main ON service_center_head.cod_customer = cust_trtab_main.cod_customer INNER JOIN " & _
"                          (SELECT     GL_payment_deposit.ID_payment, GL_payment_deposit.id_service_center, GL_payment_deposit.refrence_no,  " & _
"                                                   GL_payment_deposit.refer_type, GL_payment_deposit.payment_type, GL_payment_deposit.payment_amount,  " & _
"                                                   GL_payment_AR.AR_terms, GL_payment_AR.AR_due_date " & _
"                             FROM         GL_payment_deposit LEFT OUTER JOIN " & _
"                                                   GL_payment_AR ON GL_payment_deposit.ID_payment = GL_payment_AR.ID_payment) GL ON  " & _
"                      service_center_head.id_service_center = GL.id_service_center ON  " & _
"                      ser_tr_vehicle_dtl.id_service_center = service_center_head.id_service_center LEFT OUTER JOIN " & _
"                      cust_company ON cust_trtab_main.cod_company = cust_company.cod_company ON ZipCus.zipcode = cust_trtab_main.zip LEFT OUTER JOIN " & _
"                      ser_tr_vehicle ON service_center_head.id_vehicle = ser_tr_vehicle.id_vehicle LEFT OUTER JOIN " & _
"                      bas_color ON ser_tr_vehicle.cod_color = bas_color.cod_color LEFT OUTER JOIN " & _
"                      bas_vehicle INNER JOIN " & _
"                      bas_vehicle_model INNER JOIN " & _
"                      bas_vehicle_company ON bas_vehicle_model.cod_make = bas_vehicle_company.cod_make ON  " & _
"                      bas_vehicle.cod_make = bas_vehicle_model.cod_make AND bas_vehicle.cod_model = bas_vehicle_model.cod_model ON  " & _
"                      ser_tr_vehicle.cod_vehicle = bas_vehicle.cod_vehicle LEFT OUTER JOIN " & _
"                      inv_tab_kind_engine ON ser_tr_vehicle.cod_kind_engine = inv_tab_kind_engine.cod_kind_engine " & _
        "WHERE  (GL.refer_type = '1') AND (GL.payment_type = '4')  AND (cust_trtab_main.AR_charge = '1') and  cust_trtab_main.AR_send_copy='1' and   (service_center_head.type_of_form = 'IN')" & IIf(StrWhere.Trim.Length > 0, " and " & StrWhere, "")

        DSRep.Clear()
        DAGeneral.Fill(DSRep.service_center_head)

     
        Dim rpt As New RepInvoiceForState
        Dim prn As New FrmRepView

        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)



        DSRep.TempTable.AddTempTableRow(OleDbReaderForStore.Item("WARRANTY_FOR_IN") & "")
        Try
            If OleDbReaderForStore.Item("InvoicesShading") = 0 Then
                rpt.SetParameterValue("ShadingParam", True)
            Else
                rpt.SetParameterValue("ShadingParam", False)
            End If
        Catch ex As Exception
            rpt.SetParameterValue("ShadingParam", False)
        End Try

        rpt.SetParameterValue("ParStoreShortName", PubStoreName & "")

        rpt.SetParameterValue("Parconame", OleDbReaderForStore.Item("STORENAME") & "")
        rpt.SetParameterValue("Parcoaddress", OleDbReaderForStore.Item("ADDRESS") & "")

        MyZipCode.ZipCode = OleDbReaderForStore.Item("ZipCode")
        MyZipCode.FindDesc(OleDbReaderForStore.Item("ZipCode"))
        rpt.SetParameterValue("Parcoaddress2", MyZipCode.City & " " & MyZipCode.State & " " & MyZipCode.ZipCode & "")

        rpt.SetParameterValue("Parcophone", OleDbReaderForStore.Item("PHONE") & "")
        rpt.SetParameterValue("Parcofax", OleDbReaderForStore.Item("FAX") & "")
        rpt.SetParameterValue("Parcoemail", OleDbReaderForStore.Item("EMAIL") & "")

        DSRep.LOGO.Clear()
        Dim OleDbReaderForCompany As System.Data.OleDb.OleDbDataReader
        OleDbReaderForCompany = RetrieveCompanySetupTable()
        Try
            DSRep.LOGO.AddLOGORow(OleDbReaderForCompany.Item("LOGO"), "l")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        rpt.SetParameterValue("Parcowebsite", OleDbReaderForCompany.Item("WEBPAGE"))



        'rpt.SetParameterValue("ParCusName", CustomerCod1.CustomerDesc)
        'rpt.SetParameterValue("ParCusAddress", CustomerCod1.Address)
        'rpt.SetParameterValue("Parcusaddress2", MyZipCode.City & " " & MyZipCode.State & " " & MyZipCode.ZipCode & "")
        'rpt.SetParameterValue("ParCusPhone", CustomerCod1.CustomerPhone)
        'rpt.SetParameterValue("ParVeMake", LblVehicleMake.Text)
        'rpt.SetParameterValue("ParVeModel", LblVehicleModel.Text)
        'rpt.SetParameterValue("ParVeYear", LblVehicleYear.Text)
        'rpt.SetParameterValue("ParVeVIN", LblVehicleVin.Text)
        'rpt.SetParameterValue("ParVecolor", VehicleColorVar & "")
        'rpt.SetParameterValue("ParVeengine", Desc_kind_engineVar & "")
        'rpt.SetParameterValue("ParVepremile", PreviousMileageVar & "")
        'rpt.SetParameterValue("ParVeunit", UnitNoVar & "")
        'rpt.SetParameterValue("ParVelicense", License_No1.Text)

        'rpt.SetParameterValue("ParVeCurMile", NumCurrent_mileage.Text)
        'rpt.SetParameterValue("Parwritten", CmbAddUser.Text)
        'rpt.SetParameterValue("Parchanged", CmbChgUser.Text)
        'rpt.SetParameterValue("Parsumparts", LblParts.Text)
        'rpt.SetParameterValue("Parsumfet", LblFET.Text)
        'rpt.SetParameterValue("Parsumlabor", LblLabor.Text)
        'rpt.SetParameterValue("Parsumfees", LblFees.Text)
        'rpt.SetParameterValue("Parsumsubtotal", LblSubtotal.Text)
        'rpt.SetParameterValue("Parsumdiscount", NumDiscount.Text)
        'rpt.SetParameterValue("Parsumtax", NumTax.Text)
        'rpt.SetParameterValue("Parsumtotal", LblTotal.Text)
        'rpt.SetParameterValue("Partype", ServiceCenterType & "")

        'rpt.SetParameterValue("parcusno", CustomerCod1.Text)


        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        'Dim ThisDateTempVar As String
        'CmdGeneral.CommandText = "Select date_refer from service_center_head where id_service_center=" & Qt(ThisTxtRef)
        'ThisDateTempVar = CmdGeneral.ExecuteScalar & ""

        'rpt.SetParameterValue("pardate", ThisDateTempVar)
        'rpt.SetParameterValue("partime", Format(TimeOfDay, "Short Time"))

        'rpt.SetParameterValue("parno", ThisTxtRef)

        'rpt.SetParameterValue("parincash", 0)
        'rpt.SetParameterValue("parincheck", 0)
        'rpt.SetParameterValue("parincheckno", "")
        'rpt.SetParameterValue("parincrcard", 0)
        'rpt.SetParameterValue("parincctype", "")
        'rpt.SetParameterValue("parinauthcode", "")
        'rpt.SetParameterValue("parinonacount", 0)
        'rpt.SetParameterValue("parinterms", "")
        'rpt.SetParameterValue("parinduedate", "")

        'DAGL_payment_deposit.SelectCommand.Parameters("@id_service_center").Value = ThisTxtRef
        'DsFrmCashier1.GL_payment_deposit.Clear()
        'DAGL_payment_deposit.Fill(DsFrmCashier1, "GL_payment_deposit")

        'If DsFrmCashier1.GL_payment_deposit.Rows.Count > 0 Then
        '    Dim i As Integer
        '    For i = 0 To DsFrmCashier1.GL_payment_deposit.Rows.Count - 1
        '        Select Case DsFrmCashier1.GL_payment_deposit.Rows(i).Item("payment_type") & ""
        '            Case "1" 'cash
        '                rpt.SetParameterValue("parincash", IIf(DsFrmCashier1.GL_payment_deposit.Rows(i).Item("cash_rendered") Is DBNull.Value, 0, DsFrmCashier1.GL_payment_deposit.Rows(i).Item("cash_rendered")))
        '            Case "2" 'check

        '                rpt.SetParameterValue("parincheck", IIf(DsFrmCashier1.GL_payment_deposit.Rows(i).Item("payment_amount") Is DBNull.Value, 0, DsFrmCashier1.GL_payment_deposit.Rows(i).Item("payment_amount")))
        '                rpt.SetParameterValue("parincheckno", DsFrmCashier1.GL_payment_deposit.Rows(i).Item("check_no") & "")
        '            Case "3" 'credit
        '                rpt.SetParameterValue("parincrcard", IIf(DsFrmCashier1.GL_payment_deposit.Rows(i).Item("payment_amount") Is DBNull.Value, 0, DsFrmCashier1.GL_payment_deposit.Rows(i).Item("payment_amount")))
        '                rpt.SetParameterValue("parincctype", DsFrmCashier1.GL_payment_deposit.Rows(i).Item("cc_type") & "") ''''''''''''
        '                rpt.SetParameterValue("parinauthcode", DsFrmCashier1.GL_payment_deposit.Rows(i).Item("cc_auth_no") & "")
        '            Case "4" 'AR
        '                rpt.SetParameterValue("parinonacount", DsFrmCashier1.GL_payment_deposit.Rows(i).Item("payment_amount") & "")

        '                Try
        '                    rpt.SetParameterValue("parinterms", DsFrmCashier1.GL_payment_deposit.Rows(i).Item("AR_terms") & "")   '''''''''''''
        '                Catch ex As Exception
        '                    rpt.SetParameterValue("parinterms", "")  '''''''''''''
        '                End Try


        '                'rpt.SetParameterValue("parinterms", DsFrmCashier1.GL_payment_deposit.Rows(i).Item("AR_terms") & "")  '''''''''''''
        '                rpt.SetParameterValue("parinduedate", DsFrmCashier1.GL_payment_deposit.Rows(i).Item("AR_due_date") & "")
        '        End Select
        '    Next
        'End If
        rpt.SetParameterValue("ParKindRep", "INVOICE")
        rpt.SetDataSource(DSRep)
        Select Case type
            Case "print"
                Try
                    rpt.PrintToPrinter(1, True, 0, 0)
                Catch ex As Exception
                End Try
            Case "priv"
                prn.CrViewer.ReportSource = rpt
                prn.Show()
                'Case "fax"
                '    Try
                '        rpt.PrintOptions.PrinterName = "Fax"
                '        rpt.PrintToPrinter(1, True, 0, 0)
                '    Catch ex As Exception
                '        MsgBox("Add The FAX in (Printers and Faxes)")
                '    End Try
        End Select



        Call DropTable()

    End Sub
End Class