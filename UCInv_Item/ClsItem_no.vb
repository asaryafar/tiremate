Imports CommonClass
Imports UcUserOperation
Public Class Clsitem_no
    '------------------------------------------
    Private mConnection As System.Data.SqlClient.SqlConnection
    Private MItemNo As String = ""
    Private DaGeneral As New System.Data.SqlClient.SqlDataAdapter
    Private CmdSelect As New System.Data.SqlClient.SqlCommand
    Private CmdGeneral As New System.Data.SqlClient.SqlCommand
    Private DsGeneral As New DataSet
    Private MItem_no As String = ""
    Private MDescItem As String = ""
    Private DAItemNoSelectText As String
    Private MTaxable As Boolean
    '------------------------------------------
    Public Event FindItemNo()
    Public Event FindItemNoRow(ByVal ThisRow As DataRow)
    Public Event NotFindItemNo()
    Public Event FindItemCostRow(ByVal ThisRow As DataRow)
    Public Event NotFindItemCost()

    '------------------------------------------------
    Public WithEvents DAItemNo As New System.Data.SqlClient.SqlDataAdapter
    Private WithEvents DAItemNoInsert As New System.Data.SqlClient.SqlCommand
    Private WithEvents DAItemNoSelect As New System.Data.SqlClient.SqlCommand
    Private WithEvents DAItemNoUpdate As New System.Data.SqlClient.SqlCommand
    Private WithEvents DAItemNoDelete As New System.Data.SqlClient.SqlCommand
    Private ClsUserOperation1 As New ClsUserOperation
    Private MErrorString As String
    Private MHasError As Boolean
    Public Event FindError(ByVal ErrorString As String)
    Public Event AfterFindCalculatePricrCode(ByVal ThisDatatRow As DataRow, ByVal ThisItemPrice As Decimal)
    Public Event AfterCalculateSumReceived(ByVal SumParts As Decimal, ByVal Sumfet1 As Decimal, ByVal SumTax As Decimal, ByVal SumTotal As Decimal, ByVal SumTotalQty As Decimal, ByVal SumW As Decimal)
    Public Event AfterCalculateSumInventoryAdjustment(ByVal SumParts As Decimal, ByVal SumFET As Decimal, ByVal SumTotal As Decimal, ByVal SumTotQty As Int64)
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
    Public ReadOnly Property Taxable() As Boolean
        Get
            Return MTaxable
        End Get
    End Property
    Property Connection() As System.Data.SqlClient.SqlConnection
        Get
            Return mConnection
        End Get
        Set(ByVal Value As System.Data.SqlClient.SqlConnection)
            mConnection = Value
            DAItemNoInsert.Connection = Value
            DAItemNoSelect.Connection = Value
            DAItemNoUpdate.Connection = Value
            DAItemNoDelete.Connection = Value
            CmdGeneral.Connection = Value
        End Set
    End Property
    Public Property ItemNo() As String
        Get
            Return MItemNo
        End Get
        Set(ByVal Value As String)
            MItemNo = Value
        End Set
    End Property
    Public Property Item_no() As String
        Get
            Return MItem_no.Trim & ""
        End Get
        Set(ByVal value As String)
            MItem_no = value.Trim & ""
        End Set
    End Property
    Public Property desc_Item() As String
        Get
            Return MDescItem.Trim & ""
        End Get
        Set(ByVal value As String)
            MDescItem = value.Trim & ""
        End Set
    End Property
    Function FindDesc(ByVal ThisItemNo As String) As Boolean
        FindDesc = False
        If mConnection Is Nothing Then
            MsgBox("Connection On ItemNo Not Set")
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
                              & " FROM inv_item " _
                              & " Where inv_item.Item_no = " & Qt(ThisItemNo)
        CmdSelect.CommandText = "SELECT     inv_item.*, inv_tab_tire_specification.tire_size, inv_tab_tire_specification.service_description, inv_tab_tire_specification.sidwall, " & _
                      "inv_tab_tire_specification.load_range, inv_tab_tire_specification.mspn, inv_tab_tire_specification.article_stock_no, " & _
                      "inv_tab_tire_specification.rim_width_range_inch, inv_tab_tire_specification.section_width_inch, inv_tab_tire_specification.width_mm, " & _
                      "inv_tab_tire_specification.aspect_ratio, inv_tab_tire_specification.rim_diameter_inch, inv_tab_tire_specification.speed_simbol, " & _
                      "inv_tab_tire_specification.load_index, inv_tab_tire_specification.tread_depth, inv_tab_tire_specification.overal_diameter_inch, " & _
                      "inv_tab_tire_specification.tread_width, inv_tab_tire_specification.revs_per_mile, inv_tab_tire_specification.max_load_lbs, " & _
                      "inv_tab_tire_specification.max_air_psl, inv_tab_tire_specification.wieght_lbs, inv_tab_tire_specification.original_equipment, " & _
                      "inv_tab_tire_specification.ply" & _
                      " FROM         inv_item LEFT OUTER JOIN " & _
                      " inv_tab_tire_specification ON inv_item.item_no = inv_tab_tire_specification.item_no  WHERE  inv_item.item_no = " & Qt(ThisItemNo)
        Try
            DaGeneral.Fill(DsGeneral, "t1")
            If DsGeneral.Tables("t1").Rows.Count > 0 Then
                MItem_no = DsGeneral.Tables("t1").Rows(0).Item("Item_no")
                MDescItem = DsGeneral.Tables("t1").Rows(0).Item("Desc_Item")
                MTaxable = DsGeneral.Tables("t1").Rows(0).Item("taxable")
                FindDesc = True
                RaiseEvent FindItemNo()
                RaiseEvent FindItemNoRow(DsGeneral.Tables("t1").Rows(0))
            Else
                MItem_no = ""
                MDescItem = ""
                MTaxable = True
                RaiseEvent NotFindItemNo()
            End If
        Catch ex As Exception
        End Try
    End Function
    'Cost of item
    Function FindItemCost(ByVal ThisItemNo As String) As Boolean
        FindItemCost = False
        If mConnection Is Nothing Then
            MsgBox("Connection On ItemNo Not Set")
            Exit Function
        End If
        DsGeneral.Clear()
        DaGeneral.SelectCommand = CmdSelect
        'If mConnection.ConnectionString <> PConnectionString Then
        '    If mConnection.State <> ConnectionState.Closed Then
        '        mConnection.Close()
        '    End If
        '    mConnection.ConnectionString = PConnectionString
        'End If
        DaGeneral.SelectCommand.Connection = mConnection
        CmdSelect.CommandText = "SELECT * from inv_item_cost_transaction where Item_No=" & Qt(ThisItemNo.Trim) & " And Last_Flag=1"
        Try
            DaGeneral.Fill(DsGeneral, "t1")
            If DsGeneral.Tables("t1").Rows.Count > 0 Then
                RaiseEvent FindItemCostRow(DsGeneral.Tables("t1").Rows(0))
            Else
                RaiseEvent NotFindItemCost()
            End If
        Catch ex As Exception
        End Try
    End Function

    Public Sub New()
        '
        Call InitDAItemNo()

    End Sub
    Private Sub InitDAItemNo()
        'DAItemNo
        '
        Me.DAItemNo.DeleteCommand = Me.DAItemNoDelete
        Me.DAItemNo.InsertCommand = Me.DAItemNoInsert
        Me.DAItemNo.SelectCommand = Me.DAItemNoSelect
        Me.DAItemNo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "hes_tab_kol", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_kol", "cod_kol"), New System.Data.Common.DataColumnMapping("desc_kol", "desc_kol"), New System.Data.Common.DataColumnMapping("kind_cod_kol", "kind_cod_kol"), New System.Data.Common.DataColumnMapping("add_op", "add_op"), New System.Data.Common.DataColumnMapping("add_date", "add_date"), New System.Data.Common.DataColumnMapping("chg_op", "chg_op"), New System.Data.Common.DataColumnMapping("chg_date", "chg_date")})})
        Me.DAItemNo.UpdateCommand = Me.DAItemNoUpdate
        '
        'DAItemNoDelete
        '
        Me.DAItemNoDelete.CommandText = ""
        '
        'DAItemNoInsert
        '
        Me.DAItemNoInsert.CommandText = ""
        '
        'Dahes_tab_kolSelect
        '
        Me.DAItemNoSelect.CommandText = "SELECT * " _
                      & " FROM  inv_item"

        DAItemNoSelectText = Me.DAItemNoSelect.CommandText
        '
        'DAItemNoUpdate
        '
        Me.DAItemNoUpdate.CommandText = ""
        '
    End Sub
    Sub AdDAItemNo()
    End Sub
    Sub EditAItemNo()
    End Sub
    Sub DeleteAItemNo()

    End Sub
    Private Sub ClearError()
        MHasError = False
        MErrorString = ""
    End Sub
    Function CalculatePriceCode(ByVal ThisItemNo As String, ByVal ThisPriceLevel As Integer, Optional ByRef ThisItemFet As Decimal = 0) As Decimal
        CalculatePriceCode = 0
        Dim SqlSelectCommand1 As New System.Data.SqlClient.SqlCommand
        SqlSelectCommand1.CommandText = "SELECT inv_item.item_no, inv_item.cod_item_type, inv_item.desc_item, inv_tab_bran" & _
                "d.cod_brand, inv_item.cod_quick_refrence, inv_item.taxable, inv_tab_style.style," & _
                " inv_item.line, inv_item.note, inv_item.picture, inv_item.upc, inv_item.special_" & _
                "notice, inv_item_cost_transaction.fet, inv_item_cost_transaction.frieght, inv_it" & _
                "em_cost_transaction.amount_price1, inv_item_cost_transaction.price_code, inv_ite" & _
                "m_cost_transaction.amount_price2, inv_item_cost_transaction.amount_price3, inv_i" & _
                "tem_cost_transaction.amount_price4, inv_item_cost_transaction.amount_price5, inv" & _
                "_item_cost_transaction.amount_price6, inv_tab_item_warehouse.on_hand, inv_tab_it" & _
                "em_warehouse.comitted, inv_tab_tire_specification.tire_size, inv_tab_tire_specif" & _
                "ication.service_description, inv_tab_tire_specification.sidwall, inv_tab_tire_sp" & _
                "ecification.load_range, inv_tab_tire_specification.mspn, inv_tab_tire_specificat" & _
                "ion.article_stock_no, inv_tab_tire_specification.rim_width_range_inch, inv_tab_t" & _
                "ire_specification.section_width_inch, inv_tab_tire_specification.width_mm, inv_t" & _
                "ab_tire_specification.aspect_ratio, inv_tab_tire_specification.rim_diameter_inch" & _
                ", inv_tab_tire_specification.speed_simbol, inv_tab_tire_specification.load_index" & _
                ", inv_tab_tire_specification.overal_diameter_inch, inv_tab_tire_specification.tr" & _
                "ead_depth, inv_tab_tire_specification.tread_width, inv_tab_tire_specification.re" & _
                "vs_per_mile, inv_tab_tire_specification.max_load_lbs, inv_tab_tire_specification" & _
                ".max_air_psl, inv_tab_tire_specification.wieght_lbs, inv_tab_tire_specification." & _
                "original_equipment, inv_tab_tire_specification.ply, inv_tab_line.line AS desc_li" & _
                "ne, inv_tab_line.treadwear, inv_tab_line.traction, inv_tab_line.temperature, inv" & _
                "_tab_brand.icon_brand, inv_tab_line.image_remark, inv_tab_line.limit_warranty, i" & _
                "nv_tab_item_warehouse.on_order, inv_tab_item_warehouse.min_stock, inv_tab_item_w" & _
                "arehouse.max_stock, inv_tab_item_warehouse.reorde, inv_discount_item.start_date_" & _
                "onsale, inv_discount_item.end_date_onsale, inv_discount_item.amount_onsale, inv_" & _
                "discount_item.start_date_contract, inv_discount_item.end_date_contract, inv_disc" & _
                "ount_item.amount_contract, inv_discount_item.start_date_spiff, inv_discount_item" & _
                ".end_date_spiff, inv_discount_item.amount_spiff, inv_item_cost_transaction.cost," & _
                " inv_item_cost_transaction.delivery, inv_item_cost_transaction.list_price, inv_i" & _
                "tem.consignment, inv_item.discontinued, inv_item.discontinued_date, inv_discount" & _
                "_item.onsale_check, inv_discount_item.contract_check, inv_discount_item.spiff_ch" & _
                "eck FROM inv_tab_line INNER JOIN inv_tab_style ON inv_tab_line.style = inv_tab_s" & _
                "tyle.style RIGHT OUTER JOIN inv_tab_brand ON inv_tab_line.cod_brand = inv_tab_br" & _
                "and.cod_brand RIGHT OUTER JOIN inv_item LEFT OUTER JOIN inv_discount_item ON inv" & _
                "_item.item_no = inv_discount_item.item_no ON inv_tab_line.line = inv_item.line L" & _
                "EFT OUTER JOIN inv_tab_tire_specification ON inv_item.item_no = inv_tab_tire_spe" & _
                "cification.item_no LEFT OUTER JOIN inv_item_cost_transaction ON inv_item.item_no" & _
                " = inv_item_cost_transaction.item_no LEFT OUTER JOIN inv_tab_item_warehouse ON i" & _
                "nv_item.item_no = inv_tab_item_warehouse.item_no WHERE (inv_item.item_no = @Item" & _
                "_no) AND (inv_item_cost_transaction.last_flag = 1) AND (inv_discount_item.last_f" & _
                "lag = 1)"
        SqlSelectCommand1.Connection = Connection
        Try
            SqlSelectCommand1.Connection.Close()
        Catch ex As Exception
        End Try
        SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        SqlSelectCommand1.Parameters(0).Value = ThisItemNo
        DaGeneral.SelectCommand = SqlSelectCommand1
        Dim Ds As New DataSet
        DaGeneral.Fill(Ds)
        Dim Mlist_price As Decimal
        Dim mprice_code As String
        Dim MpriceVal As Decimal
        Dim Mcost As Decimal
        If Ds.Tables(0).Rows.Count > 0 Then
            Try
                ThisItemFet = Ds.Tables(0).Rows(0).Item("fet")
            Catch ex As Exception
                ThisItemFet = 0
            End Try
            Try
                Mlist_price = Ds.Tables(0).Rows(0).Item("List_Price")
            Catch ex As Exception
                Mlist_price = 0
            End Try
            Try
                mprice_code = Ds.Tables(0).Rows(0).Item("price_code")
            Catch ex As Exception
                mprice_code = 0
            End Try
            Try
                Mcost = Ds.Tables(0).Rows(0).Item("cost")
            Catch ex As Exception
                Mcost = 0
            End Try
            Try
                MpriceVal = CalculatePriceCode(mprice_code, ThisPriceLevel, Mcost, Mlist_price)
            Catch ex As Exception
                MpriceVal = 0
            End Try
            CalculatePriceCode = Math.Round(MpriceVal,2)
            RaiseEvent AfterFindCalculatePricrCode(Ds.Tables(0).Rows(0), MpriceVal)
        Else
            RaiseEvent AfterFindCalculatePricrCode(Nothing, 0)
        End If
    End Function
    Function CalculatePriceCode(ByVal PriceCod As String, ByVal Thislevel As Integer, ByVal ThisCost As Decimal, ByVal ThisListPrice As Decimal) As Decimal
        Dim calculate As Decimal = 0
        Dim Amount1 As Decimal = 0
        Dim price As String = "price" & Trim(Thislevel) & "_c_l_a_p"
        Dim price_amount As String = "price" & Trim(Thislevel) & "_Amount"
        Dim price_persent As String = "price" & Trim(Thislevel) & "_d_persent"
        Dim price_operator As String = "price" & Trim(Thislevel) & "_operator"
        Dim price_odd_price As String = "price" & Trim(Thislevel) & "_odd_price"
        Dim price_price_level As String = "price" & Trim(Thislevel) & "_price_level"
        Dim DaPricecod As New System.Data.SqlClient.SqlDataAdapter
        Dim SqlSelectCommand1 As New System.Data.SqlClient.SqlCommand
        Try
            If PriceCod.Trim & "" = "" Then
                CalculatePriceCode = 0
                Exit Function
            End If
            SqlSelectCommand1.CommandText = "SELECT price_code, desc_price_code, price1_c_l_a_p, price1_operator, price1_d_per" & _
                        "sent, price1_amount, price1_odd_price, price1_price_level, price2_c_l_a_p, price" & _
                        "2_operator, price2_d_persent, price2_amount, price2_odd_price, price2_price_leve" & _
                        "l, price3_c_l_a_p, price3_operator, price3_d_persent, price3_amount, price3_odd_" & _
                        "price, price3_price_level, price4_c_l_a_p, price4_operator, price4_d_persent, pr" & _
                        "ice4_amount, price4_odd_price, price4_price_level, price5_c_l_a_p, price5_operat" & _
                        "or, price5_d_persent, price5_amount, price5_odd_price, price5_price_level, price" & _
                        "6_c_l_a_p, price6_operator, price6_d_persent, price6_amount, price6_odd_price, p" & _
                        "rice6_price_level, special_notice FROM inv_price_code where  price_code = " & Qt(PriceCod)
            SqlSelectCommand1.Connection = Connection

            DaPricecod.SelectCommand = SqlSelectCommand1
            Dim Ds As New DataSet
            '---------------------------------
            DaPricecod.Fill(Ds, "t1")
            Dim drow As DataRow = Ds.Tables("t1").Rows(0)
            Select Case CType(drow.Item(price), String).ToUpper
                Case "L".ToUpper
                    calculate = Val(ThisListPrice)
                Case "C".ToUpper
                    calculate = Val(ThisCost)
                Case "a".ToUpper
                Case "p".ToUpper
                    calculate = CalculatePriceCode(PriceCod, drow.Item(price_price_level), ThisCost, ThisListPrice)
            End Select
            Amount1 = Val(drow.Item(price_amount))
            Select Case drow.Item(price_persent) & ""
                Case "%"
                    If drow.Item(price_operator) = "/" Then
                        Amount1 = (100 - Amount1) / 100
                    Else
                        Amount1 = (calculate * Amount1) / 100
                    End If
                Case "$"
                    Amount1 = Amount1
            End Select
            Select Case drow.Item(price_operator)
                Case "-"
                    calculate = calculate - Amount1
                Case "+"
                    calculate = calculate + Amount1
                Case "/"
                    calculate = calculate / Amount1
                Case "*", "x", "X"
                    calculate = calculate * Amount1
            End Select
            If Val(drow.Item(price_odd_price) & "") > 0 Then
                calculate = Int(calculate) + MyCdec(drow(price_odd_price))
            End If

        Catch ex As Exception
        End Try
        CalculatePriceCode = calculate
    End Function


    Sub ChangeCostThisItemNo(ByVal ThisItemNo As String, ByVal ToCost As Decimal)
        If ThisItemNo = "" Or ToCost = 0 Then
            Exit Sub
        End If
        Dim SqlUpdate1 As String = "Update  inv_item set ItemChangeDatePrice =" & Qt(Format(Now.Date, PubDateFormat)) & " , ItemChangeCostPrice = " & ToCost & " where item_no= " & Qt(ThisItemNo)
        CmdGeneral.Connection = mConnection
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = SqlUpdate1
        CmdGeneral.ExecuteNonQuery()
        '-----------------------------------------------------
        SqlUpdate1 = "Update inv_item_cost_transaction set cost =" & ToCost & " Where Item_no =" & Qt(ThisItemNo)
        CmdGeneral.CommandText = SqlUpdate1
        CmdGeneral.ExecuteNonQuery()
        '-----------------------------------------------------
    End Sub
    Function MyCdec(ByVal ThisValue As String) As Decimal
        Dim Val1 = Val(Trim(ThisValue & ""))
        Dim SignVal As Integer = 0
        Try
            If Val1 < 0 Then
                MyCdec = CDec("0" & ThisValue.Remove(0, 1))
                MyCdec = MyCdec * -1
            Else
                MyCdec = CDec("0" & ThisValue)
            End If
        Catch ex As Exception
            MyCdec = Val(ThisValue)
        End Try
    End Function
    '''''''''''''''''
    Sub CalculateSumReceive(ByVal ThisDataset As DataSet, ByVal thisdiscount As Decimal)
        Dim SQty As Decimal = 0
        Dim SCost As Decimal = 0
        Dim SFet As Decimal = 0
        Dim sales_tax As String
        Dim sales_tax_amount As Decimal = 0

        Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
        Dim SqlReader As System.Data.SqlClient.SqlDataReader
        OleDbReaderForStore = RetrieveStoreSetupTable()
        sales_tax = OleDbReaderForStore.Item("Sales_tax") & ""
        CmdGeneral.CommandText = " Select * from cust_sales_tax where cod_sales_tax=" & Qt(sales_tax)
        CmdGeneral.Connection = Connection
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        SqlReader = CmdGeneral.ExecuteReader
        If SqlReader.HasRows Then
            SqlReader.Read()
            sales_tax_amount = SqlReader.Item("amount")
        Else
            sales_tax_amount = 0
            MsgFar("Error There is No Sales Tax  for this store no " & sales_tax)
        End If
        SqlReader.Close()
        CmdGeneral.Connection.Close()
        OleDbReaderForStore.Close()

        Try
            Try
                SQty = CDec("0" & ThisDataset.Tables("Inv_Receive_product_dtl").Compute("sum(Qty)", " trim(Item_no) <> ''"))
            Catch ex As Exception

            End Try

            Dim Sum1 As Decimal = 0
            Dim SumFet1 As Decimal = 0
            Dim SumTax As Decimal = 0
            Dim rowsBackup As Integer = 0

            Dim SumParts As Decimal = 0

            Dim SumSubtotal As Decimal = 0
            Dim SumTotal As Decimal = 0
            Dim SumTotalQty As Decimal = 0
            Dim SumW As Decimal = 0
            Dim i As Integer
            Try

                With ThisDataset.Tables("Inv_Receive_product_dtl")
                    For i = 0 To ThisDataset.Tables("Inv_Receive_product_dtl").Rows.Count - 1
                        If ThisDataset.Tables("Inv_Receive_product_dtl").Rows(i).RowState <> (DataRowState.Deleted) And ThisDataset.Tables("Inv_Receive_product_dtl").Rows(i).RowState <> (DataRowState.Detached) Then

                            Sum1 = CDec(Val(.Rows(i).Item("Cost") & "")) * CDec(Val(.Rows(i).Item("qty") & "")) + Sum1
                            SumFet1 = CDec(Val(.Rows(i).Item("fet") & "")) * CDec(Val(.Rows(i).Item("qty") & "")) + SumFet1
                            If .Rows(i).Item("taxable") = True Then
                                SumTax = Math.Round(CDec(Val(.Rows(i).Item("Cost") & "")) * CDec(Val(.Rows(i).Item("qty") & "")) * sales_tax_amount / 100, 2) + SumTax
                            End If
                            If Trim(.Rows(i).Item("wieght_lbs") & "") & "" <> "" Then
                                SumW = SumW + CDec(Val(Trim("" & .Rows(i).Item("wieght_lbs")))) * CDec(Val(.Rows(i).Item("qty") & ""))
                            End If
                        End If
                    Next
                End With

                SumParts = Math.Round(Sum1, 2) 'CDec("0" & DsFrmReceiveReturnProduct1.Inv_Receive_product_dtl.Compute("sum(Cost*qty)", " trim(Item_no) <> ''"))  '   SQty * SCost
                'SumFet1
                SumSubtotal = Math.Round(SumParts + SumFet1, 2)
                ' SumTax
                SumTotal = Math.Round(Sum1 + SumFet1 + SumTax - CDec("0" & thisdiscount), 2)
                SumTotalQty = Math.Round(SQty, 2)
                RaiseEvent AfterCalculateSumReceived(SumParts, SumFet1, SumTax, SumTotal, SumTotalQty, SumW)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Catch ex1 As Exception
            MsgBox(ex1.ToString)
        End Try
    End Sub

    Public Function LoadThisReceiveAndReturn(ByVal ThisRefNo As String, ByVal ThisDataset As DataSet) As String 'DSFrmReceiveReturnProduct)
        ThisDataset.Clear()
        DaGeneral.SelectCommand = CmdSelect
        CmdSelect.Connection = Connection

        DaGeneral.SelectCommand = CmdSelect
        CmdSelect.Connection = Connection

        CmdSelect.CommandText = "SELECT id_receive_ref, date_receive, cod_vendor, bill_credit, bill_receive, ap_te" & _
        "rm, receipt_bill_date, vendor_ref_no, due_date, po_no, house_comments, vend_comm" & _
        "ents, Discount FROM Inv_Receive_Products_head WHERE (id_receive_ref = " & Qt(ThisRefNo) & ")"
        ' dage.SelectCommand.Parameters("@id_receive_ref").Value = ThisRefNo
        DaGeneral.Fill(ThisDataset, "Inv_Receive_Products_head")
        LoadThisReceiveAndReturn = ""
        Try
            LoadThisReceiveAndReturn = ThisDataset.Tables("Inv_Receive_Products_head").Rows(0).Item("date_receive") & ""
        Catch ex As Exception
            LoadThisReceiveAndReturn = ""
        End Try

        DaGeneral.SelectCommand = CmdSelect
        CmdSelect.Connection = Connection
        'CmdSelect.CommandText = "SELECT Inv_Receive_product_dtl.id_receive_ref, Inv_Receive_product_dtl.item_no, I" & _
        '"nv_Receive_product_dtl.qty, Inv_Receive_product_dtl.cost, Inv_Receive_product_dt" & _
        '"l.taxable, inv_item.desc_item, inv_item_cost_transaction.cost AS InvItemCost, in" & _
        '"v_item_cost_transaction.fet, (inv_item_cost_transaction.cost + inv_item_cost_tra" & _
        '"nsaction.fet) * Inv_Receive_product_dtl.qty AS ExCost FROM inv_item LEFT OUTER J" & _
        '"OIN inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.it" & _
        '"em_no RIGHT OUTER JOIN Inv_Receive_product_dtl ON inv_item.item_no = Inv_Receive" & _
        '"_product_dtl.item_no WHERE (inv_item_cost_transaction.last_flag = 1) AND (Inv_Re" & _
        '"ceive_product_dtl.id_receive_ref = " & Qt(ThisRefNo) & ")"
        CmdSelect.CommandText = "SELECT   Inv_Receive_product_dtl.id_receive_ref, Inv_Receive_product_dtl.item_no, Inv_Receive_product_dtl.qty, Inv_Receive_product_dtl.cost, " & _
                      "Inv_Receive_product_dtl.taxable, inv_item.desc_item, inv_item_cost_transaction.cost AS InvItemCost, inv_item_cost_transaction.fet, " & _
                      "(inv_item_cost_transaction.cost + inv_item_cost_transaction.fet) * Inv_Receive_product_dtl.qty AS ExCost, inv_tab_tire_specification.wieght_lbs " & _
                      "FROM   inv_item LEFT OUTER JOIN " & _
                      "inv_tab_tire_specification ON inv_item.item_no = inv_tab_tire_specification.item_no LEFT OUTER JOIN " & _
                      "inv_item_cost_transaction ON inv_item.item_no = inv_item_cost_transaction.item_no RIGHT OUTER JOIN " & _
                      "Inv_Receive_product_dtl ON inv_item.item_no = Inv_Receive_product_dtl.item_no " & _
                      " WHERE   (inv_item_cost_transaction.last_flag = 1) AND (Inv_Receive_product_dtl.id_receive_ref = " & Qt(ThisRefNo) & ")"
        Try
            DaGeneral.Fill(ThisDataset, "Inv_Receive_product_dtl")
        Catch ex As Exception

        End Try
    End Function

    Function PLastRecordReceivereturn(ByVal ThisItemNo As String) As String
        Dim TXTRef_NoTmp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT TOP 1 Inv_Receive_Products_head.id_receive_ref FROM Inv_Receive_Products_head INNER JOIN Inv_Receive_product_dtl ON Inv_Receive_Products_head.id_receive_ref = Inv_Receive_product_dtl.id_receive_ref WHERE (Inv_Receive_product_dtl.item_no = " & Qt(ThisItemNo) & " ) ORDER BY Inv_Receive_Products_head.id_receive_ref DESC"
        PLastRecordReceivereturn = CmdGeneral.ExecuteScalar() & ""
        CmdGeneral.Connection.Close()
    End Function
    ''''''''''''''''''
    Public Sub CalculateSumInventoryAdjustment(ByVal ThisDataset As DataSet)
        ' Call CalcExt_Price()
        Dim TaxablePrice As Double = 0
        Dim TaxPercent As Double = 0

        Dim SumParts As Decimal = 0
        Dim SumFET As Decimal = 0
        Dim SumTotal As Decimal = 0
        Dim SumTotQty As Int64 = 0
        Dim SumtotWeight As Decimal = 0
        Dim i As Int64 = 0
        For i = 0 To ThisDataset.Tables("inv_adjustment_dtl").Rows.Count - 1
            If Trim(ThisDataset.Tables("inv_adjustment_dtl").Rows(i).Item(0)) & "" <> "" Then
                With ThisDataset.Tables("inv_adjustment_dtl")
                    Dim FetOdThisItem As Decimal = 0
                    'Call MyItem.CalculatePriceCode(MyItem.Item_no, 1, FetOdThisItem)
                    Call CalculatePriceCode(.Rows(i).Item(1) & "", 1, FetOdThisItem)
                    .Rows(i).Item("Fet") = FetOdThisItem
                    ThisDataset.Tables("inv_adjustment_dtl").Rows(i).Item("Ext_Cost") = .Rows(i).Item("Qty") * (.Rows(i).Item("Cost") + ThisDataset.Tables("inv_adjustment_dtl").Rows(i).Item("Fet"))
                    SumParts = Math.Round(SumParts + ThisDataset.Tables("inv_adjustment_dtl").Rows(i).Item("qty") * .Rows(i).Item("Cost"), 2)
                    SumFET = SumFET + .Rows(i).Item("Fet")
                    SumTotal = Math.Round(SumParts + SumFET, 2) 'DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(i).Item("qty") * DsFrmInventoryAdjustment1.inv_adjustment_dtl.Rows(i).Item("Cost")
                    SumTotQty = SumTotQty + .Rows(i).Item("qty")
                    RaiseEvent AfterCalculateSumInventoryAdjustment(SumParts, SumFET, SumTotal, SumTotQty)
                End With
            Else
                Exit For
            End If
        Next
    End Sub
    Function PLastRecordInventoryAdjustment(ByVal ThisItemNo As String) As String
        Dim TXTRef_NoTmp As String
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT TOP 1 inv_adjustment_head.referID_adjustment FROM inv_adjustment_head INNER JOIN inv_adjustment_dtl ON inv_adjustment_head.referID_adjustment = inv_adjustment_dtl.referID_adjustment WHERE (inv_adjustment_dtl.item_no = " & Qt(ThisItemNo) & ") ORDER BY inv_adjustment_head.referID_adjustment DESC"
        PLastRecordInventoryAdjustment = CmdGeneral.ExecuteScalar() & ""
        CmdGeneral.Connection.Close()
    End Function
    Public Function LoadThisInventoryAdjustment(ByVal ThisRefNo As String, ByVal ThisDataset As DataSet) As String 'DSFrmReceiveReturnProduct)
        ThisDataset.Clear()
        DaGeneral.SelectCommand = CmdSelect
        CmdSelect.Connection = Connection

        DaGeneral.SelectCommand = CmdSelect
        CmdSelect.Connection = Connection

        CmdSelect.CommandText = "SELECT * FROM inv_adjustment_head WHERE ( referID_adjustment =" & Qt(ThisRefNo) & ")"
        DaGeneral.Fill(ThisDataset, "inv_adjustment_head")

        LoadThisInventoryAdjustment = ""
        Try
            LoadThisInventoryAdjustment = ThisDataset.Tables("inv_adjustment_head").Rows(0).Item("date_adjustment") & ""
        Catch ex As Exception
            LoadThisInventoryAdjustment = ""
        End Try

        DaGeneral.SelectCommand = CmdSelect
        CmdSelect.Connection = Connection
        CmdSelect.CommandText = " SELECT inv_adjustment_dtl.referID_adjustment, inv_adjustment_dtl.item_no, inv_adj" & _
        "ustment_dtl.QTY, inv_adjustment_dtl.Cost, inv_adjustment_dtl.Cost AS Fet, inv_ad" & _
        "justment_dtl.Cost AS Ext_Cost, inv_item.desc_item FROM inv_adjustment_dtl INNER " & _
        "JOIN inv_item ON inv_adjustment_dtl.item_no = inv_item.item_no WHERE (inv_adjust" & _
        "ment_dtl.referID_adjustment =" & Qt(ThisRefNo) & ")"
        Try
            DaGeneral.Fill(ThisDataset, "inv_adjustment_dtl")
        Catch ex As Exception
        End Try
    End Function
    ''''''''''''''''''

End Class
