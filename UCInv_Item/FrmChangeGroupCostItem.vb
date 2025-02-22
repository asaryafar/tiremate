Public Class FrmChangeGroupCostItem
    Inherits CommonClass.FrmBase
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DaCost As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsFrmChargeGroupCostItem1 As UCInv_Item.DSFrmChargeGroupCostItem
    Friend WithEvents grd1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents BtnReread As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtCost As CalcUtils.UcCalcText
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnUnmarkAll As System.Windows.Forms.Button
    Friend WithEvents BtnMarkAll As System.Windows.Forms.Button
    Friend WithEvents BtnCalculate As System.Windows.Forms.Button
    Friend WithEvents TxtFixt As CalcUtils.UcCalcText
    Friend WithEvents pB1 As System.Windows.Forms.ProgressBar
    Friend WithEvents CmdUpdate As System.Data.SqlClient.SqlCommand
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChkInsertToAllStore As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmChangeGroupCostItem))
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaCost = New System.Data.SqlClient.SqlDataAdapter
        Me.DsFrmChargeGroupCostItem1 = New UCInv_Item.DSFrmChargeGroupCostItem
        Me.grd1 = New Janus.Windows.GridEX.GridEX
        Me.BtnExit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.BtnReread = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxtFixt = New CalcUtils.UcCalcText
        Me.TxtCost = New CalcUtils.UcCalcText
        Me.BtnUnmarkAll = New System.Windows.Forms.Button
        Me.BtnMarkAll = New System.Windows.Forms.Button
        Me.BtnCalculate = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.pB1 = New System.Windows.Forms.ProgressBar
        Me.CmdUpdate = New System.Data.SqlClient.SqlCommand
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.ChkInsertToAllStore = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.DsFrmChargeGroupCostItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT inv_item_cost_transaction.date_cost_change, inv_item_cost_transaction.cost" & _
        ", inv_item_cost_transaction.last_flag, inv_tab_style.style, inv_tab_style.desc_s" & _
        "tyle, inv_tab_line.line, inv_tab_brand.cod_brand, inv_tab_brand.complete_desc_br" & _
        "and, inv_item.desc_item, inv_item_cost_transaction.item_no, inv_item_cost_transa" & _
        "ction.list_price, inv_item_cost_transaction.fet, inv_item_cost_transaction.deliv" & _
        "ery, inv_item_cost_transaction.frieght, inv_item_cost_transaction.price_code, in" & _
        "v_item_cost_transaction.amount_price1, inv_item_cost_transaction.amount_price2, " & _
        "inv_item_cost_transaction.amount_price3, inv_item_cost_transaction.amount_price4" & _
        ", inv_item_cost_transaction.amount_price5, inv_item_cost_transaction.amount_pric" & _
        "e6, inv_item_quick_refrence.desc_quick_refrence FROM inv_item_cost_transaction I" & _
        "NNER JOIN inv_item ON inv_item_cost_transaction.item_no = inv_item.item_no LEFT " & _
        "OUTER JOIN inv_item_quick_refrence ON inv_item.cod_quick_refrence = inv_item_qui" & _
        "ck_refrence.cod_quick_refrence LEFT OUTER JOIN inv_tab_line ON inv_item.line = i" & _
        "nv_tab_line.line LEFT OUTER JOIN inv_tab_brand ON inv_tab_line.cod_brand = inv_t" & _
        "ab_brand.cod_brand LEFT OUTER JOIN inv_tab_style ON inv_tab_line.style = inv_tab" & _
        "_style.style WHERE (inv_item_cost_transaction.last_flag = 1)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BEH1;packet size=4096;user id=sa;data source=BEH1;persist security" & _
        " info=True;initial catalog=TireMate_01;password=2191110"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO inv_item_cost_transaction(item_no, date_cost_change, cost, list_price" & _
        ", fet, delivery, frieght, price_code, amount_price1, amount_price2, amount_price" & _
        "3, amount_price4, amount_price5, amount_price6, last_flag) VALUES (@item_no, @da" & _
        "te_cost_change, @cost, @list_price, @fet, @delivery, @frieght, @price_code, @amo" & _
        "unt_price1, @amount_price2, @amount_price3, @amount_price4, @amount_price5, @amo" & _
        "unt_price6, @last_flag); SELECT item_no, date_cost_change, cost, list_price, fet" & _
        ", delivery, frieght, price_code, amount_price1, amount_price2, amount_price3, am" & _
        "ount_price4, amount_price5, amount_price6, last_flag FROM inv_item_cost_transact" & _
        "ion WHERE (date_cost_change = @date_cost_change) AND (item_no = @item_no)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_cost_change", System.Data.SqlDbType.VarChar, 10, "date_cost_change"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cost", System.Data.SqlDbType.Real, 4, "cost"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@list_price", System.Data.SqlDbType.Real, 4, "list_price"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fet", System.Data.SqlDbType.Real, 4, "fet"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@delivery", System.Data.SqlDbType.Real, 4, "delivery"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@frieght", System.Data.SqlDbType.Real, 4, "frieght"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_code", System.Data.SqlDbType.VarChar, 5, "price_code"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_price1", System.Data.SqlDbType.Real, 4, "amount_price1"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_price2", System.Data.SqlDbType.Real, 4, "amount_price2"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_price3", System.Data.SqlDbType.Real, 4, "amount_price3"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_price4", System.Data.SqlDbType.Real, 4, "amount_price4"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_price5", System.Data.SqlDbType.Real, 4, "amount_price5"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_price6", System.Data.SqlDbType.Real, 4, "amount_price6"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_flag", System.Data.SqlDbType.Bit, 1, "last_flag"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE inv_item_cost_transaction SET item_no = @item_no, date_cost_change = @date" & _
        "_cost_change, cost = @cost, list_price = @list_price, fet = @fet, delivery = @de" & _
        "livery, frieght = @frieght, price_code = @price_code, amount_price1 = @amount_pr" & _
        "ice1, amount_price2 = @amount_price2, amount_price3 = @amount_price3, amount_pri" & _
        "ce4 = @amount_price4, amount_price5 = @amount_price5, amount_price6 = @amount_pr" & _
        "ice6, last_flag = @last_flag WHERE (date_cost_change = @Original_date_cost_chang" & _
        "e) AND (item_no = @Original_item_no) AND (amount_price1 = @Original_amount_price" & _
        "1 OR @Original_amount_price1 IS NULL AND amount_price1 IS NULL) AND (amount_pric" & _
        "e2 = @Original_amount_price2 OR @Original_amount_price2 IS NULL AND amount_price" & _
        "2 IS NULL) AND (amount_price3 = @Original_amount_price3 OR @Original_amount_pric" & _
        "e3 IS NULL AND amount_price3 IS NULL) AND (amount_price4 = @Original_amount_pric" & _
        "e4 OR @Original_amount_price4 IS NULL AND amount_price4 IS NULL) AND (amount_pri" & _
        "ce5 = @Original_amount_price5 OR @Original_amount_price5 IS NULL AND amount_pric" & _
        "e5 IS NULL) AND (amount_price6 = @Original_amount_price6 OR @Original_amount_pri" & _
        "ce6 IS NULL AND amount_price6 IS NULL) AND (cost = @Original_cost) AND (delivery" & _
        " = @Original_delivery OR @Original_delivery IS NULL AND delivery IS NULL) AND (f" & _
        "et = @Original_fet OR @Original_fet IS NULL AND fet IS NULL) AND (frieght = @Ori" & _
        "ginal_frieght OR @Original_frieght IS NULL AND frieght IS NULL) AND (last_flag =" & _
        " @Original_last_flag OR @Original_last_flag IS NULL AND last_flag IS NULL) AND (" & _
        "list_price = @Original_list_price OR @Original_list_price IS NULL AND list_price" & _
        " IS NULL) AND (price_code = @Original_price_code OR @Original_price_code IS NULL" & _
        " AND price_code IS NULL); SELECT item_no, date_cost_change, cost, list_price, fe" & _
        "t, delivery, frieght, price_code, amount_price1, amount_price2, amount_price3, a" & _
        "mount_price4, amount_price5, amount_price6, last_flag FROM inv_item_cost_transac" & _
        "tion WHERE (date_cost_change = @date_cost_change) AND (item_no = @item_no)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_cost_change", System.Data.SqlDbType.VarChar, 10, "date_cost_change"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cost", System.Data.SqlDbType.Real, 4, "cost"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@list_price", System.Data.SqlDbType.Real, 4, "list_price"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fet", System.Data.SqlDbType.Real, 4, "fet"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@delivery", System.Data.SqlDbType.Real, 4, "delivery"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@frieght", System.Data.SqlDbType.Real, 4, "frieght"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price_code", System.Data.SqlDbType.VarChar, 5, "price_code"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_price1", System.Data.SqlDbType.Real, 4, "amount_price1"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_price2", System.Data.SqlDbType.Real, 4, "amount_price2"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_price3", System.Data.SqlDbType.Real, 4, "amount_price3"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_price4", System.Data.SqlDbType.Real, 4, "amount_price4"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_price5", System.Data.SqlDbType.Real, 4, "amount_price5"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@amount_price6", System.Data.SqlDbType.Real, 4, "amount_price6"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_flag", System.Data.SqlDbType.Bit, 1, "last_flag"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_cost_change", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_cost_change", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_price1", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_price1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_price2", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_price2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_price3", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_price3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_price4", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_price4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_price5", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_price5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_price6", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_price6", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cost", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cost", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_delivery", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "delivery", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fet", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_frieght", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "frieght", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_flag", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_flag", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_list_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "list_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_code", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM inv_item_cost_transaction WHERE (date_cost_change = @Original_date_co" & _
        "st_change) AND (item_no = @Original_item_no) AND (amount_price1 = @Original_amou" & _
        "nt_price1 OR @Original_amount_price1 IS NULL AND amount_price1 IS NULL) AND (amo" & _
        "unt_price2 = @Original_amount_price2 OR @Original_amount_price2 IS NULL AND amou" & _
        "nt_price2 IS NULL) AND (amount_price3 = @Original_amount_price3 OR @Original_amo" & _
        "unt_price3 IS NULL AND amount_price3 IS NULL) AND (amount_price4 = @Original_amo" & _
        "unt_price4 OR @Original_amount_price4 IS NULL AND amount_price4 IS NULL) AND (am" & _
        "ount_price5 = @Original_amount_price5 OR @Original_amount_price5 IS NULL AND amo" & _
        "unt_price5 IS NULL) AND (amount_price6 = @Original_amount_price6 OR @Original_am" & _
        "ount_price6 IS NULL AND amount_price6 IS NULL) AND (cost = @Original_cost) AND (" & _
        "delivery = @Original_delivery OR @Original_delivery IS NULL AND delivery IS NULL" & _
        ") AND (fet = @Original_fet OR @Original_fet IS NULL AND fet IS NULL) AND (friegh" & _
        "t = @Original_frieght OR @Original_frieght IS NULL AND frieght IS NULL) AND (las" & _
        "t_flag = @Original_last_flag OR @Original_last_flag IS NULL AND last_flag IS NUL" & _
        "L) AND (list_price = @Original_list_price OR @Original_list_price IS NULL AND li" & _
        "st_price IS NULL) AND (price_code = @Original_price_code OR @Original_price_code" & _
        " IS NULL AND price_code IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_cost_change", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_cost_change", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_price1", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_price1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_price2", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_price2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_price3", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_price3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_price4", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_price4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_price5", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_price5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_amount_price6", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "amount_price6", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cost", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cost", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_delivery", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "delivery", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fet", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_frieght", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "frieght", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_flag", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_flag", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_list_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "list_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price_code", System.Data.DataRowVersion.Original, Nothing))
        '
        'DaCost
        '
        Me.DaCost.DeleteCommand = Me.SqlDeleteCommand1
        Me.DaCost.InsertCommand = Me.SqlInsertCommand1
        Me.DaCost.SelectCommand = Me.SqlSelectCommand1
        Me.DaCost.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item_cost_transaction", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("date_cost_change", "date_cost_change"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("last_flag", "last_flag"), New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("desc_style", "desc_style"), New System.Data.Common.DataColumnMapping("line", "line"), New System.Data.Common.DataColumnMapping("cod_brand", "cod_brand"), New System.Data.Common.DataColumnMapping("complete_desc_brand", "complete_desc_brand"), New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("desc_item", "desc_item"), New System.Data.Common.DataColumnMapping("cod_quick_refrence", "cod_quick_refrence")})})
        Me.DaCost.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DsFrmChargeGroupCostItem1
        '
        Me.DsFrmChargeGroupCostItem1.DataSetName = "DSFrmChargeGroupCostItem"
        Me.DsFrmChargeGroupCostItem1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'grd1
        '
        Me.grd1.AlternatingColors = True
        Me.grd1.DataMember = "inv_item_cost_transaction"
        Me.grd1.DataSource = Me.DsFrmChargeGroupCostItem1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>inv_item_cost_transaction</Caption><Columns" & _
        " Collection=""true""><Column0 ID=""flg1""><ColumnType>CheckBox</ColumnType><DataMemb" & _
        "er>flg1</DataMember><EditType>CheckBox</EditType><Key>flg1</Key><Position>0</Pos" & _
        "ition><Width>30</Width></Column0><Column1 ID=""item_no""><Caption>Item No</Caption" & _
        "><TypeNameEmptyStringValue>System.String</TypeNameEmptyStringValue><EmptyStringV" & _
        "alue /><DataMember>item_no</DataMember><EditType>NoEdit</EditType><FilterEditTyp" & _
        "e>TextBox</FilterEditType><Key>item_no</Key><Position>1</Position><Width>77</Wid" & _
        "th></Column1><Column2 ID=""desc_item""><Caption>Description </Caption><DataMember>" & _
        "desc_item</DataMember><EditType>NoEdit</EditType><FilterEditType>TextBox</Filter" & _
        "EditType><Key>desc_item</Key><Position>2</Position></Column2><Column3 ID=""cost"">" & _
        "<Caption>Cost</Caption><TypeNameEmptyStringValue>NULL</TypeNameEmptyStringValue>" & _
        "<EmptyStringValue /><DataMember>cost</DataMember><FormatString>c2</FormatString>" & _
        "<Key>cost</Key><Position>3</Position><Width>92</Width></Column3><Column4 ID=""com" & _
        "plete_desc_brand""><Caption>Brand</Caption><DataMember>complete_desc_brand</DataM" & _
        "ember><EditType>NoEdit</EditType><FilterEditType>Combo</FilterEditType><Key>comp" & _
        "lete_desc_brand</Key><Position>4</Position><Width>121</Width></Column4><Column5 " & _
        "ID=""line""><Caption>Line</Caption><TypeNameEmptyStringValue>System.String</TypeNa" & _
        "meEmptyStringValue><EmptyStringValue /><DataMember>line</DataMember><EditType>No" & _
        "Edit</EditType><FilterEditType>Combo</FilterEditType><Key>line</Key><Position>5<" & _
        "/Position><Width>114</Width></Column5><Column6 ID=""desc_style""><Caption>Style</C" & _
        "aption><DataMember>desc_style</DataMember><EditType>NoEdit</EditType><FilterEdit" & _
        "Type>Combo</FilterEditType><Key>desc_style</Key><Position>6</Position><Width>136" & _
        "</Width></Column6><Column7 ID=""desc_quick_refrence""><Caption>Quick Refrence</Cap" & _
        "tion><DataMember>desc_quick_refrence</DataMember><EditType>NoEdit</EditType><Fil" & _
        "terEditType>TextBox</FilterEditType><Key>desc_quick_refrence</Key><Position>7</P" & _
        "osition></Column7></Columns><GroupCondition ID="""" /><Key>inv_item_cost_transacti" & _
        "on</Key></RootTable></GridEXLayoutData>"
        Me.grd1.DesignTimeLayout = GridEXLayout1
        Me.grd1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grd1.Location = New System.Drawing.Point(1, 56)
        Me.grd1.Name = "grd1"
        Me.grd1.Size = New System.Drawing.Size(800, 416)
        Me.grd1.TabIndex = 0
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(710, 529)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.TabIndex = 19
        Me.BtnExit.Text = "Exit"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(622, 529)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Save"
        '
        'BtnReread
        '
        Me.BtnReread.Location = New System.Drawing.Point(189, 9)
        Me.BtnReread.Name = "BtnReread"
        Me.BtnReread.Size = New System.Drawing.Size(96, 23)
        Me.BtnReread.TabIndex = 21
        Me.BtnReread.Text = "Undo"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TxtFixt)
        Me.Panel1.Controls.Add(Me.TxtCost)
        Me.Panel1.Controls.Add(Me.BtnUnmarkAll)
        Me.Panel1.Controls.Add(Me.BtnMarkAll)
        Me.Panel1.Controls.Add(Me.BtnCalculate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnReread)
        Me.Panel1.Location = New System.Drawing.Point(5, 477)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(791, 43)
        Me.Panel1.TabIndex = 22
        '
        'TxtFixt
        '
        Me.TxtFixt.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtFixt.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtFixt.DecimalDigits = 2
        Me.TxtFixt.DefaultSendValue = False
        Me.TxtFixt.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtFixt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtFixt.Image = CType(resources.GetObject("TxtFixt.Image"), System.Drawing.Image)
        Me.TxtFixt.Location = New System.Drawing.Point(569, 11)
        Me.TxtFixt.Maxlength = 12
        Me.TxtFixt.MinusColor = System.Drawing.Color.Empty
        Me.TxtFixt.Name = "TxtFixt"
        Me.TxtFixt.Size = New System.Drawing.Size(115, 22)
        Me.TxtFixt.TabIndex = 10
        Me.TxtFixt.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtFixt.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'TxtCost
        '
        Me.TxtCost.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.TxtCost.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image
        Me.TxtCost.DecimalDigits = 2
        Me.TxtCost.DefaultSendValue = False
        Me.TxtCost.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.TxtCost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtCost.Image = CType(resources.GetObject("TxtCost.Image"), System.Drawing.Image)
        Me.TxtCost.Location = New System.Drawing.Point(384, 11)
        Me.TxtCost.Maxlength = 12
        Me.TxtCost.MinusColor = System.Drawing.Color.Empty
        Me.TxtCost.Name = "TxtCost"
        Me.TxtCost.Size = New System.Drawing.Size(76, 22)
        Me.TxtCost.TabIndex = 7
        Me.TxtCost.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.TxtCost.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'BtnUnmarkAll
        '
        Me.BtnUnmarkAll.Location = New System.Drawing.Point(99, 9)
        Me.BtnUnmarkAll.Name = "BtnUnmarkAll"
        Me.BtnUnmarkAll.TabIndex = 23
        Me.BtnUnmarkAll.Text = "UnMark All"
        '
        'BtnMarkAll
        '
        Me.BtnMarkAll.Location = New System.Drawing.Point(9, 9)
        Me.BtnMarkAll.Name = "BtnMarkAll"
        Me.BtnMarkAll.TabIndex = 22
        Me.BtnMarkAll.Text = "Mark All"
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalculate.Location = New System.Drawing.Point(697, 10)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(83, 23)
        Me.BtnCalculate.TabIndex = 21
        Me.BtnCalculate.Text = "Calculate"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(494, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Dollar Change"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(302, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Percent Change"
        '
        'pB1
        '
        Me.pB1.Location = New System.Drawing.Point(8, 528)
        Me.pB1.Name = "pB1"
        Me.pB1.Size = New System.Drawing.Size(606, 24)
        Me.pB1.TabIndex = 23
        Me.pB1.Visible = False
        '
        'CmdUpdate
        '
        Me.CmdUpdate.Connection = Me.Cnn
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.ChkInsertToAllStore)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(801, 56)
        Me.Panel4.TabIndex = 24
        '
        'ChkInsertToAllStore
        '
        Me.ChkInsertToAllStore.Location = New System.Drawing.Point(677, 5)
        Me.ChkInsertToAllStore.Name = "ChkInsertToAllStore"
        Me.ChkInsertToAllStore.Size = New System.Drawing.Size(120, 18)
        Me.ChkInsertToAllStore.TabIndex = 204
        Me.ChkInsertToAllStore.Text = "Update To All Store"
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(674, 54)
        Me.Label3.TabIndex = 203
        Me.Label3.Text = "This screen is used to change replacement cost of inventory items.You may select " & _
        "any of the items individually followed by typing its new cost.You may also selec" & _
        "t the group of the items by entering a value at the box below each columns headi" & _
        "ngs followed by enter key.Multiple line , brand , and/or styles may be selected " & _
        "together.You may enter a PERCENT , a DOLLAR AMOUNT or a combination followed by " & _
        "CALCULATE."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmChangeGroupCostItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(801, 556)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.pB1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.grd1)
        Me.Name = "FrmChangeGroupCostItem"
        Me.Text = "Item Cost Changes"
        CType(Me.DsFrmChargeGroupCostItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim WithEvents myClsCommon As CommonClass.AllStore

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim c1 As New CommonClass.FrmWhatDoForMenu
        Dim I As Int64 = 0
        c1.BtnLeftText = "Cancel"
        c1.BtnRightText = "Ok"
        c1.Text = "Item Cost Change Warning"
        c1.ShowFarMsg("This Operation Will Change All Cost From Item")
        '-------------------------------------- 
        If c1.DialogResult = DialogResult.OK Then
            BtnReread.Enabled = False
            '            DaCost.Update(DsFrmChargeGroupCostItem1)
            pB1.Visible = True
            pB1.Minimum = 0
            pB1.Maximum = DsFrmChargeGroupCostItem1.inv_item_cost_transaction.Rows.Count + 3
            CmdUpdate.Connection.Open()
            Try
                For I = 0 To DsFrmChargeGroupCostItem1.inv_item_cost_transaction.Rows.Count - 1
                    With DsFrmChargeGroupCostItem1.inv_item_cost_transaction.Rows(I)
                        pB1.Value = I
                        Me.Refresh()
                        If .Item("FLG1") = True Then
                            CmdUpdate.CommandText = " Update inv_item_cost_transaction set Cost =" & .Item("Cost") & " Where item_no= " & CommonClass.Qt(.Item("Item_no"))
                            myClsCommon.AllStoreCommand(CmdUpdate, Not ChkInsertToAllStore.Checked, False)
                        End If
                    End With
                Next
            Catch ex As Exception
            Finally
                CmdUpdate.Connection.Close()
            End Try
            pB1.Visible = False
        End If
    End Sub

    Sub FillAll()
        DsFrmChargeGroupCostItem1.Clear()
        DaCost.Fill(DsFrmChargeGroupCostItem1)
    End Sub

    Private Sub BtnReread_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReread.Click
        Call FillAll()
    End Sub

    Private Sub FrmChangeGroupCostItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = CommonClass.PConnectionString
        myClsCommon = New CommonClass.AllStore
        Call FillAll()
    End Sub
    Private Sub BtnMarkAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMarkAll.Click
        Dim i As Integer = 0
        grd1.SuspendLayout()
        For i = 0 To grd1.RowCount - 1 'DsFrmChargeGroupCostItem1.inv_item_cost_transaction.Rows.Count - 1
            grd1.Row = i
            grd1.GetRow.Cells(0).Value = True
            'DsFrmChargeGroupCostItem1.inv_item_cost_transaction.Rows(i).Item("flg1") = True
        Next
        grd1.ResumeLayout()
    End Sub
    Private Sub BtnUnmarkAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUnmarkAll.Click
        Dim i As Integer = 0
        grd1.SuspendLayout()
        For i = 0 To grd1.RowCount - 1 'DsFrmChargeGroupCostItem1.inv_item_cost_transaction.Rows.Count - 1
            grd1.Row = i
            grd1.GetRow.Cells(0).Value = False
        Next
        grd1.ResumeLayout()
    End Sub
    Private Sub BtnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalculate.Click
        Dim i As Integer = 0
        grd1.SuspendLayout()
        For i = 0 To DsFrmChargeGroupCostItem1.inv_item_cost_transaction.Rows.Count - 1
            'grd1.Row = i
            With DsFrmChargeGroupCostItem1.inv_item_cost_transaction.Rows(i)
                If .Item("FLG1") = True Then
                    .Item("cost") = Math.Round(IIf(Val(TxtCost.Text & "") = 0, Val(.Item("cost")), (Val(TxtCost.Text & "") * Val(.Item("cost") & "")) / 100) + Val(TxtFixt.Text & ""), 2) + .Item("cost")
                End If

            End With
        Next
        grd1.ResumeLayout()
    End Sub
    Private Sub grd1_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles grd1.EditingCell
        If e.Column.Index = 3 Then
            grd1.GetRow.Cells(0).Value = True
        End If
        BtnReread.Enabled = True
    End Sub
End Class
