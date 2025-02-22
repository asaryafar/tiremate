Imports Janus.Windows.GridEX
Imports CommonClass
Public Class FrmShowWorkOrder
    Inherits FrmBase

    Public MTypeOfForm As String
    Public Property TypeOfForm() As String
        Get
            Return MTypeOfForm
        End Get
        Set(ByVal Value As String)
            MTypeOfForm = Value
        End Set
    End Property
    Dim InvoiceNoForReturnVar As String = ""
    Dim WithEvents MyZipCode As UCZipCode.ClsZipCode
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
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAService_Center_Head As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAinv_tab_pakage As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAGL_payment_deposit As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents DAService_Center_Dtl As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAservice_out_purchases As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CnnReader As System.Data.SqlClient.SqlConnection
    Friend WithEvents DAEmployee As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdReader As System.Data.SqlClient.SqlCommand
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAService_tire_adjustment As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DAinv_tab_style As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsFrmWorkOrders1 As WorkOrderUtility.DSFrmWorkOrders
    Friend WithEvents GrdDetail As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents LblTotal As CalcUtils.UcCalcText
    Friend WithEvents NumDiscount As CalcUtils.UcCalcText
    Friend WithEvents NumTax As CalcUtils.UcCalcText
    Friend WithEvents LblSubtotal As CalcUtils.UcCalcText
    Friend WithEvents LblFET As CalcUtils.UcCalcText
    Friend WithEvents LblFees As CalcUtils.UcCalcText
    Friend WithEvents LblLabor As CalcUtils.UcCalcText
    Friend WithEvents LblParts As CalcUtils.UcCalcText
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents LblVehicleYear As System.Windows.Forms.Label
    Friend WithEvents LblVehicleVin As System.Windows.Forms.Label
    Friend WithEvents LblVehicleModel As System.Windows.Forms.Label
    Friend WithEvents LblVehicleMake As System.Windows.Forms.Label
    Friend WithEvents NumCurrent_mileage As CalcUtils.UcCalcText
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents LblCustomerCompanyname As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtCustomerFName As System.Windows.Forms.Label
    Friend WithEvents TxtCustomerMName As System.Windows.Forms.Label
    Friend WithEvents TxtCustomerLName As System.Windows.Forms.Label
    Friend WithEvents TxtLicenceNo As System.Windows.Forms.Label
    Friend WithEvents TxtCustomerCod As System.Windows.Forms.Label
    Friend WithEvents TxtDate As System.Windows.Forms.TextBox
    Friend WithEvents LblType As System.Windows.Forms.TextBox
    Public WithEvents TxtRef As System.Windows.Forms.TextBox
    Friend WithEvents CmbType As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblStoreNo As System.Windows.Forms.Label
    Friend WithEvents LblCompanyName As System.Windows.Forms.Label
    Friend WithEvents CmbChgUser As System.Windows.Forms.ComboBox
    Friend WithEvents CmbAddUser As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DaUsers As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents TxtPo_No As System.Windows.Forms.Label
    Friend WithEvents CnnUserMDB As System.Data.OleDb.OleDbConnection
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents BtnCashier As System.Windows.Forms.Button
    Friend WithEvents CommentButton_Customer As UCCommentButton.CommentButton
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmShowWorkOrder))
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim UiComboBoxItem1 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem
        Dim UiComboBoxItem2 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem
        Dim UiComboBoxItem3 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem
        Dim UiComboBoxItem4 As Janus.Windows.EditControls.UIComboBoxItem = New Janus.Windows.EditControls.UIComboBoxItem
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.DAService_Center_Head = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAinv_tab_pakage = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAGL_payment_deposit = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand8 = New System.Data.SqlClient.SqlCommand
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.DAService_Center_Dtl = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand8 = New System.Data.SqlClient.SqlCommand
        Me.DAservice_out_purchases = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.CnnReader = New System.Data.SqlClient.SqlConnection
        Me.DAEmployee = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.CmdReader = New System.Data.SqlClient.SqlCommand
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.DAService_tire_adjustment = New System.Data.SqlClient.SqlDataAdapter
        Me.DAinv_tab_style = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DsFrmWorkOrders1 = New WorkOrderUtility.DSFrmWorkOrders
        Me.GrdDetail = New Janus.Windows.GridEX.GridEX
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.LblTotal = New CalcUtils.UcCalcText
        Me.NumDiscount = New CalcUtils.UcCalcText
        Me.NumTax = New CalcUtils.UcCalcText
        Me.LblSubtotal = New CalcUtils.UcCalcText
        Me.LblFET = New CalcUtils.UcCalcText
        Me.LblFees = New CalcUtils.UcCalcText
        Me.LblLabor = New CalcUtils.UcCalcText
        Me.LblParts = New CalcUtils.UcCalcText
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.LblVehicleYear = New System.Windows.Forms.Label
        Me.LblVehicleVin = New System.Windows.Forms.Label
        Me.LblVehicleModel = New System.Windows.Forms.Label
        Me.LblVehicleMake = New System.Windows.Forms.Label
        Me.NumCurrent_mileage = New CalcUtils.UcCalcText
        Me.Label35 = New System.Windows.Forms.Label
        Me.LblCustomerCompanyname = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxtDate = New System.Windows.Forms.TextBox
        Me.LblType = New System.Windows.Forms.TextBox
        Me.TxtRef = New System.Windows.Forms.TextBox
        Me.CmbType = New Janus.Windows.EditControls.UIComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LblStoreNo = New System.Windows.Forms.Label
        Me.LblCompanyName = New System.Windows.Forms.Label
        Me.TxtLicenceNo = New System.Windows.Forms.Label
        Me.TxtCustomerCod = New System.Windows.Forms.Label
        Me.TxtCustomerFName = New System.Windows.Forms.Label
        Me.TxtCustomerMName = New System.Windows.Forms.Label
        Me.TxtCustomerLName = New System.Windows.Forms.Label
        Me.CmbChgUser = New System.Windows.Forms.ComboBox
        Me.CmbAddUser = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.DaUsers = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.CnnUserMDB = New System.Data.OleDb.OleDbConnection
        Me.TxtPo_No = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.BtnCashier = New System.Windows.Forms.Button
        Me.CommentButton_Customer = New UCCommentButton.CommentButton
        Me.Label29 = New System.Windows.Forms.Label
        Me.BtnPrint = New System.Windows.Forms.Button
        CType(Me.DsFrmWorkOrders1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=""."";persist secu" & _
        "rity info=True;initial catalog=Tiremate_02"
        '
        'DAService_Center_Head
        '
        Me.DAService_Center_Head.DeleteCommand = Me.SqlDeleteCommand3
        Me.DAService_Center_Head.InsertCommand = Me.SqlInsertCommand3
        Me.DAService_Center_Head.SelectCommand = Me.SqlSelectCommand4
        Me.DAService_Center_Head.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before")})})
        Me.DAService_Center_Head.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM service_center_head WHERE (id_service_center = @Original_id_service_c" & _
        "enter) AND (Total = @Original_Total OR @Original_Total IS NULL AND Total IS NULL" & _
        ") AND (add_user = @Original_add_user OR @Original_add_user IS NULL AND add_user " & _
        "IS NULL) AND (chg_user = @Original_chg_user OR @Original_chg_user IS NULL AND ch" & _
        "g_user IS NULL) AND (cod_customer = @Original_cod_customer OR @Original_cod_cust" & _
        "omer IS NULL AND cod_customer IS NULL) AND (cust_comment = @Original_cust_commen" & _
        "t OR @Original_cust_comment IS NULL AND cust_comment IS NULL) AND (date_refer = " & _
        "@Original_date_refer OR @Original_date_refer IS NULL AND date_refer IS NULL) AND" & _
        " (discount = @Original_discount OR @Original_discount IS NULL AND discount IS NU" & _
        "LL) AND (house_comment = @Original_house_comment OR @Original_house_comment IS N" & _
        "ULL AND house_comment IS NULL) AND (id_GL_journal = @Original_id_GL_journal OR @" & _
        "Original_id_GL_journal IS NULL AND id_GL_journal IS NULL) AND (id_service_center" & _
        "_before = @Original_id_service_center_before OR @Original_id_service_center_befo" & _
        "re IS NULL AND id_service_center_before IS NULL) AND (id_vehicle = @Original_id_" & _
        "vehicle OR @Original_id_vehicle IS NULL AND id_vehicle IS NULL) AND (po_no = @Or" & _
        "iginal_po_no OR @Original_po_no IS NULL AND po_no IS NULL) AND (tax = @Original_" & _
        "tax OR @Original_tax IS NULL AND tax IS NULL) AND (type_of_form = @Original_type" & _
        "_of_form OR @Original_type_of_form IS NULL AND type_of_form IS NULL)"
        Me.SqlDeleteCommand3.Connection = Me.Cnn
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_add_user", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "add_user", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_chg_user", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "chg_user", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_customer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_customer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cust_comment", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_comment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_refer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_refer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_house_comment", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "house_comment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_GL_journal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_GL_journal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center_before", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center_before", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_vehicle", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_vehicle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_po_no", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "po_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tax", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_of_form", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_of_form", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO service_center_head(id_service_center, type_of_form, cod_customer, id" & _
        "_vehicle, date_refer, discount, tax, house_comment, cust_comment, add_user, chg_" & _
        "user, po_no, id_service_center_before, id_GL_journal, Total) VALUES (@id_service" & _
        "_center, @type_of_form, @cod_customer, @id_vehicle, @date_refer, @discount, @tax" & _
        ", @house_comment, @cust_comment, @add_user, @chg_user, @po_no, @id_service_cente" & _
        "r_before, @id_GL_journal, @Total); SELECT id_service_center, type_of_form, cod_c" & _
        "ustomer, id_vehicle, date_refer, discount, tax, house_comment, cust_comment, add" & _
        "_user, chg_user, po_no, id_service_center_before, id_GL_journal, Total FROM serv" & _
        "ice_center_head WHERE (id_service_center = @id_service_center)"
        Me.SqlInsertCommand3.Connection = Me.Cnn
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_of_form", System.Data.SqlDbType.VarChar, 2, "type_of_form"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_vehicle", System.Data.SqlDbType.Int, 4, "id_vehicle"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_refer", System.Data.SqlDbType.VarChar, 10, "date_refer"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discount", System.Data.SqlDbType.Real, 4, "discount"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tax", System.Data.SqlDbType.Real, 4, "tax"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@house_comment", System.Data.SqlDbType.VarChar, 200, "house_comment"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cust_comment", System.Data.SqlDbType.VarChar, 200, "cust_comment"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@add_user", System.Data.SqlDbType.SmallInt, 2, "add_user"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@chg_user", System.Data.SqlDbType.SmallInt, 2, "chg_user"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@po_no", System.Data.SqlDbType.VarChar, 10, "po_no"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center_before", System.Data.SqlDbType.VarChar, 10, "id_service_center_before"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_GL_journal", System.Data.SqlDbType.Int, 4, "id_GL_journal"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Money, 8, "Total"))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT service_center_head.id_service_center, service_center_head.type_of_form, s" & _
        "ervice_center_head.cod_customer, service_center_head.date_refer, service_center_" & _
        "head.discount, service_center_head.tax, service_center_head.house_comment, servi" & _
        "ce_center_head.cust_comment, service_center_head.add_user, service_center_head.p" & _
        "o_no, cust_company.complete_name, cust_company.abbreviation_name, service_center" & _
        "_head.chg_user, service_center_head.id_vehicle, service_center_head.id_service_c" & _
        "enter_before, ser_tr_vehicle.license_no_vehicle, ser_tr_vehicle_dtl.current_mile" & _
        "age, service_center_head.Total, service_center_head.id_GL_journal FROM service_c" & _
        "enter_head LEFT OUTER JOIN ser_tr_vehicle ON service_center_head.id_vehicle = se" & _
        "r_tr_vehicle.id_vehicle LEFT OUTER JOIN cust_company INNER JOIN cust_trtab_main " & _
        "ON cust_company.cod_company = cust_trtab_main.cod_company ON service_center_head" & _
        ".cod_customer = cust_trtab_main.cod_customer LEFT OUTER JOIN ser_tr_vehicle_dtl " & _
        "ON service_center_head.id_service_center = ser_tr_vehicle_dtl.id_service_center " & _
        "WHERE (service_center_head.id_service_center = @id_service_center)"
        Me.SqlSelectCommand4.Connection = Me.Cnn
        Me.SqlSelectCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE service_center_head SET id_service_center = @id_service_center, type_of_fo" & _
        "rm = @type_of_form, cod_customer = @cod_customer, id_vehicle = @id_vehicle, date" & _
        "_refer = @date_refer, discount = @discount, tax = @tax, house_comment = @house_c" & _
        "omment, cust_comment = @cust_comment, add_user = @add_user, chg_user = @chg_user" & _
        ", po_no = @po_no, id_service_center_before = @id_service_center_before, id_GL_jo" & _
        "urnal = @id_GL_journal, Total = @Total WHERE (id_service_center = @Original_id_s" & _
        "ervice_center) AND (Total = @Original_Total OR @Original_Total IS NULL AND Total" & _
        " IS NULL) AND (add_user = @Original_add_user OR @Original_add_user IS NULL AND a" & _
        "dd_user IS NULL) AND (chg_user = @Original_chg_user OR @Original_chg_user IS NUL" & _
        "L AND chg_user IS NULL) AND (cod_customer = @Original_cod_customer OR @Original_" & _
        "cod_customer IS NULL AND cod_customer IS NULL) AND (cust_comment = @Original_cus" & _
        "t_comment OR @Original_cust_comment IS NULL AND cust_comment IS NULL) AND (date_" & _
        "refer = @Original_date_refer OR @Original_date_refer IS NULL AND date_refer IS N" & _
        "ULL) AND (discount = @Original_discount OR @Original_discount IS NULL AND discou" & _
        "nt IS NULL) AND (house_comment = @Original_house_comment OR @Original_house_comm" & _
        "ent IS NULL AND house_comment IS NULL) AND (id_GL_journal = @Original_id_GL_jour" & _
        "nal OR @Original_id_GL_journal IS NULL AND id_GL_journal IS NULL) AND (id_servic" & _
        "e_center_before = @Original_id_service_center_before OR @Original_id_service_cen" & _
        "ter_before IS NULL AND id_service_center_before IS NULL) AND (id_vehicle = @Orig" & _
        "inal_id_vehicle OR @Original_id_vehicle IS NULL AND id_vehicle IS NULL) AND (po_" & _
        "no = @Original_po_no OR @Original_po_no IS NULL AND po_no IS NULL) AND (tax = @O" & _
        "riginal_tax OR @Original_tax IS NULL AND tax IS NULL) AND (type_of_form = @Origi" & _
        "nal_type_of_form OR @Original_type_of_form IS NULL AND type_of_form IS NULL); SE" & _
        "LECT id_service_center, type_of_form, cod_customer, id_vehicle, date_refer, disc" & _
        "ount, tax, house_comment, cust_comment, add_user, chg_user, po_no, id_service_ce" & _
        "nter_before, id_GL_journal, Total FROM service_center_head WHERE (id_service_cen" & _
        "ter = @id_service_center)"
        Me.SqlUpdateCommand3.Connection = Me.Cnn
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_of_form", System.Data.SqlDbType.VarChar, 2, "type_of_form"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_vehicle", System.Data.SqlDbType.Int, 4, "id_vehicle"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_refer", System.Data.SqlDbType.VarChar, 10, "date_refer"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discount", System.Data.SqlDbType.Real, 4, "discount"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tax", System.Data.SqlDbType.Real, 4, "tax"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@house_comment", System.Data.SqlDbType.VarChar, 200, "house_comment"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cust_comment", System.Data.SqlDbType.VarChar, 200, "cust_comment"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@add_user", System.Data.SqlDbType.SmallInt, 2, "add_user"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@chg_user", System.Data.SqlDbType.SmallInt, 2, "chg_user"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@po_no", System.Data.SqlDbType.VarChar, 10, "po_no"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center_before", System.Data.SqlDbType.VarChar, 10, "id_service_center_before"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_GL_journal", System.Data.SqlDbType.Int, 4, "id_GL_journal"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Money, 8, "Total"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_add_user", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "add_user", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_chg_user", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "chg_user", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_customer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_customer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cust_comment", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_comment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_refer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_refer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_house_comment", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "house_comment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_GL_journal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_GL_journal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center_before", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center_before", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_vehicle", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_vehicle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_po_no", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "po_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tax", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_of_form", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_of_form", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO inv_tab_pakage(cod_pakage, radif, type_select, cod_select, desc_radif" & _
        ", qty, price) VALUES (@cod_pakage, @radif, @type_select, @cod_select, @desc_radi" & _
        "f, @qty, @price); SELECT cod_pakage, radif, type_select, cod_select, desc_radif," & _
        " qty, price FROM inv_tab_pakage WHERE (cod_pakage = @cod_pakage) AND (radif = @r" & _
        "adif)"
        Me.SqlInsertCommand4.Connection = Me.Cnn
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_pakage", System.Data.SqlDbType.VarChar, 5, "cod_pakage"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_select", System.Data.SqlDbType.VarChar, 1, "type_select"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_select", System.Data.SqlDbType.VarChar, 20, "cod_select"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_radif", System.Data.SqlDbType.VarChar, 50, "desc_radif"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@qty", System.Data.SqlDbType.Real, 4, "qty"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Real, 4, "price"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cod_pakage, radif, type_select, cod_select, desc_radif, qty, price FROM in" & _
        "v_tab_pakage"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'DAinv_tab_pakage
        '
        Me.DAinv_tab_pakage.DeleteCommand = Me.SqlDeleteCommand4
        Me.DAinv_tab_pakage.InsertCommand = Me.SqlInsertCommand4
        Me.DAinv_tab_pakage.SelectCommand = Me.SqlSelectCommand2
        Me.DAinv_tab_pakage.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_pakage", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_pakage", "cod_pakage"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("type_select", "type_select"), New System.Data.Common.DataColumnMapping("cod_select", "cod_select"), New System.Data.Common.DataColumnMapping("desc_radif", "desc_radif"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price")})})
        Me.DAinv_tab_pakage.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM inv_tab_pakage WHERE (cod_pakage = @Original_cod_pakage) AND (radif =" & _
        " @Original_radif) AND (cod_select = @Original_cod_select OR @Original_cod_select" & _
        " IS NULL AND cod_select IS NULL) AND (desc_radif = @Original_desc_radif OR @Orig" & _
        "inal_desc_radif IS NULL AND desc_radif IS NULL) AND (price = @Original_price OR " & _
        "@Original_price IS NULL AND price IS NULL) AND (qty = @Original_qty OR @Original" & _
        "_qty IS NULL AND qty IS NULL) AND (type_select = @Original_type_select OR @Origi" & _
        "nal_type_select IS NULL AND type_select IS NULL)"
        Me.SqlDeleteCommand4.Connection = Me.Cnn
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_pakage", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_pakage", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_select", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_select", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_radif", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_qty", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "qty", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_select", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_select", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE inv_tab_pakage SET cod_pakage = @cod_pakage, radif = @radif, type_select =" & _
        " @type_select, cod_select = @cod_select, desc_radif = @desc_radif, qty = @qty, p" & _
        "rice = @price WHERE (cod_pakage = @Original_cod_pakage) AND (radif = @Original_r" & _
        "adif) AND (cod_select = @Original_cod_select OR @Original_cod_select IS NULL AND" & _
        " cod_select IS NULL) AND (desc_radif = @Original_desc_radif OR @Original_desc_ra" & _
        "dif IS NULL AND desc_radif IS NULL) AND (price = @Original_price OR @Original_pr" & _
        "ice IS NULL AND price IS NULL) AND (qty = @Original_qty OR @Original_qty IS NULL" & _
        " AND qty IS NULL) AND (type_select = @Original_type_select OR @Original_type_sel" & _
        "ect IS NULL AND type_select IS NULL); SELECT cod_pakage, radif, type_select, cod" & _
        "_select, desc_radif, qty, price FROM inv_tab_pakage WHERE (cod_pakage = @cod_pak" & _
        "age) AND (radif = @radif)"
        Me.SqlUpdateCommand4.Connection = Me.Cnn
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_pakage", System.Data.SqlDbType.VarChar, 5, "cod_pakage"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_select", System.Data.SqlDbType.VarChar, 1, "type_select"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_select", System.Data.SqlDbType.VarChar, 20, "cod_select"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_radif", System.Data.SqlDbType.VarChar, 50, "desc_radif"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@qty", System.Data.SqlDbType.Real, 4, "qty"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Real, 4, "price"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_pakage", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_pakage", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_select", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_select", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_radif", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_qty", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "qty", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_select", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_select", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlCommand9
        '
        Me.SqlCommand9.CommandText = "SELECT GL_payment_deposit.ID_payment, GL_payment_deposit.id_service_center, GL_pa" & _
        "yment_deposit.refrence_no, GL_payment_deposit.refer_type, GL_payment_deposit.pay" & _
        "ment_type, GL_payment_deposit.payment_amount, GL_payment_cash.cash_rendered, GL_" & _
        "payment_cash.change_due, GL_payment_check.check_no, GL_payment_check.check_date," & _
        " GL_payment_AR.AR_terms, GL_payment_AR.AR_due_date, GL_payment_credit.cc_type, G" & _
        "L_payment_credit.cc_card_no, GL_payment_credit.cc_expire_date_year, GL_payment_c" & _
        "redit.cc_expire_date_month, GL_payment_credit.cc_auth_no FROM GL_payment_deposit" & _
        " LEFT OUTER JOIN GL_payment_credit ON GL_payment_deposit.ID_payment = GL_payment" & _
        "_credit.ID_payment LEFT OUTER JOIN GL_payment_AR ON GL_payment_deposit.ID_paymen" & _
        "t = GL_payment_AR.ID_payment LEFT OUTER JOIN GL_payment_check ON GL_payment_depo" & _
        "sit.ID_payment = GL_payment_check.ID_payment LEFT OUTER JOIN GL_payment_cash ON " & _
        "GL_payment_deposit.ID_payment = GL_payment_cash.ID_payment WHERE (GL_payment_dep" & _
        "osit.refer_type = '1') AND (GL_payment_deposit.id_service_center = @id_service_c" & _
        "enter)"
        Me.SqlCommand9.Connection = Me.Cnn
        Me.SqlCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "DELETE FROM GL_payment_deposit WHERE (ID_payment = @Original_ID_payment) AND (id_" & _
        "service_center = @Original_id_service_center OR @Original_id_service_center IS N" & _
        "ULL AND id_service_center IS NULL) AND (payment_amount = @Original_payment_amoun" & _
        "t OR @Original_payment_amount IS NULL AND payment_amount IS NULL) AND (payment_t" & _
        "ype = @Original_payment_type OR @Original_payment_type IS NULL AND payment_type " & _
        "IS NULL) AND (refer_type = @Original_refer_type OR @Original_refer_type IS NULL " & _
        "AND refer_type IS NULL) AND (refrence_no = @Original_refrence_no OR @Original_re" & _
        "frence_no IS NULL AND refrence_no IS NULL)"
        Me.SqlCommand1.Connection = Me.Cnn
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refer_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refer_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refrence_no", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAGL_payment_deposit
        '
        Me.DAGL_payment_deposit.DeleteCommand = Me.SqlCommand1
        Me.DAGL_payment_deposit.InsertCommand = Me.SqlCommand8
        Me.DAGL_payment_deposit.SelectCommand = Me.SqlCommand9
        Me.DAGL_payment_deposit.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GL_payment_deposit", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_payment", "ID_payment"), New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("refrence_no", "refrence_no"), New System.Data.Common.DataColumnMapping("refer_type", "refer_type"), New System.Data.Common.DataColumnMapping("payment_type", "payment_type"), New System.Data.Common.DataColumnMapping("payment_amount", "payment_amount")})})
        Me.DAGL_payment_deposit.UpdateCommand = Me.SqlCommand10
        '
        'SqlCommand8
        '
        Me.SqlCommand8.CommandText = "INSERT INTO GL_payment_deposit(id_service_center, refrence_no, refer_type, paymen" & _
        "t_type, payment_amount) VALUES (@id_service_center, @refrence_no, @refer_type, @" & _
        "payment_type, @payment_amount); SELECT ID_payment, id_service_center, refrence_n" & _
        "o, refer_type, payment_type, payment_amount FROM GL_payment_deposit WHERE (ID_pa" & _
        "yment = @@IDENTITY)"
        Me.SqlCommand8.Connection = Me.Cnn
        Me.SqlCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 6, "refrence_no"))
        Me.SqlCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        '
        'SqlCommand10
        '
        Me.SqlCommand10.CommandText = "UPDATE GL_payment_deposit SET id_service_center = @id_service_center, refrence_no" & _
        " = @refrence_no, refer_type = @refer_type, payment_type = @payment_type, payment" & _
        "_amount = @payment_amount WHERE (ID_payment = @Original_ID_payment) AND (id_serv" & _
        "ice_center = @Original_id_service_center OR @Original_id_service_center IS NULL " & _
        "AND id_service_center IS NULL) AND (payment_amount = @Original_payment_amount OR" & _
        " @Original_payment_amount IS NULL AND payment_amount IS NULL) AND (payment_type " & _
        "= @Original_payment_type OR @Original_payment_type IS NULL AND payment_type IS N" & _
        "ULL) AND (refer_type = @Original_refer_type OR @Original_refer_type IS NULL AND " & _
        "refer_type IS NULL) AND (refrence_no = @Original_refrence_no OR @Original_refren" & _
        "ce_no IS NULL AND refrence_no IS NULL); SELECT ID_payment, id_service_center, re" & _
        "frence_no, refer_type, payment_type, payment_amount FROM GL_payment_deposit WHER" & _
        "E (ID_payment = @ID_payment)"
        Me.SqlCommand10.Connection = Me.Cnn
        Me.SqlCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 6, "refrence_no"))
        Me.SqlCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        Me.SqlCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refer_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refer_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refrence_no", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand10.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_payment", System.Data.SqlDbType.Int, 4, "ID_payment"))
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT style, desc_style FROM inv_tab_style"
        Me.SqlSelectCommand5.Connection = Me.Cnn
        '
        'imageList1
        '
        Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT id_service_center, radif, DOT_safety_code, DOT_serial_no, measured_tread_d" & _
        "epth, condition_code, supplier_percent, costomer_portion FROM service_tire_adjus" & _
        "tment WHERE (id_service_center = @id_service_center)"
        Me.SqlSelectCommand7.Connection = Me.Cnn
        Me.SqlSelectCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT service_center_dtl.id_service_center, service_center_dtl.radif, service_ce" & _
        "nter_dtl.type_select, service_center_dtl.cod_select, service_center_dtl.desc_rad" & _
        "if, service_center_dtl.qty, service_center_dtl.price, service_center_dtl.fet, se" & _
        "rvice_center_dtl.taxable, service_center_dtl.cod_technician, service_center_dtl." & _
        "COMMENT_ARTICLE, inv_item.item_no FROM service_center_dtl LEFT OUTER JOIN inv_it" & _
        "em ON service_center_dtl.cod_select = inv_item.item_no WHERE (service_center_dtl" & _
        ".id_service_center = @id_service_center) ORDER BY service_center_dtl.radif"
        Me.SqlSelectCommand8.Connection = Me.Cnn
        Me.SqlSelectCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        '
        'SqlInsertCommand8
        '
        Me.SqlInsertCommand8.CommandText = "INSERT INTO service_center_dtl(id_service_center, radif, type_select, cod_select," & _
        " desc_radif, qty, price, fet, taxable, cod_technician, COMMENT_ARTICLE, AVERAGE_" & _
        "COST) VALUES (@id_service_center, @radif, @type_select, @cod_select, @desc_radif" & _
        ", @qty, @price, @fet, @taxable, @cod_technician, @COMMENT_ARTICLE, @AVERAGE_COST" & _
        "); SELECT id_service_center, radif, type_select, cod_select, desc_radif, qty, pr" & _
        "ice, fet, taxable, cod_technician, COMMENT_ARTICLE, AVERAGE_COST FROM service_ce" & _
        "nter_dtl WHERE (id_service_center = @id_service_center) AND (radif = @radif)"
        Me.SqlInsertCommand8.Connection = Me.Cnn
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_select", System.Data.SqlDbType.VarChar, 1, "type_select"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_select", System.Data.SqlDbType.VarChar, 20, "cod_select"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_radif", System.Data.SqlDbType.VarChar, 100, "desc_radif"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@qty", System.Data.SqlDbType.Money, 8, "qty"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Money, 8, "price"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fet", System.Data.SqlDbType.Money, 8, "fet"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@taxable", System.Data.SqlDbType.Bit, 1, "taxable"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_technician", System.Data.SqlDbType.VarChar, 5, "cod_technician"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@COMMENT_ARTICLE", System.Data.SqlDbType.VarChar, 300, "COMMENT_ARTICLE"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AVERAGE_COST", System.Data.SqlDbType.Money, 8, "AVERAGE_COST"))
        '
        'DAService_Center_Dtl
        '
        Me.DAService_Center_Dtl.DeleteCommand = Me.SqlDeleteCommand8
        Me.DAService_Center_Dtl.InsertCommand = Me.SqlInsertCommand8
        Me.DAService_Center_Dtl.SelectCommand = Me.SqlSelectCommand8
        Me.DAService_Center_Dtl.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_dtl", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("type_select", "type_select"), New System.Data.Common.DataColumnMapping("cod_select", "cod_select"), New System.Data.Common.DataColumnMapping("desc_radif", "desc_radif"), New System.Data.Common.DataColumnMapping("qty", "qty"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("cod_technician", "cod_technician"), New System.Data.Common.DataColumnMapping("COMMENT_ARTICLE", "COMMENT_ARTICLE"), New System.Data.Common.DataColumnMapping("AVERAGE_COST", "AVERAGE_COST")})})
        Me.DAService_Center_Dtl.UpdateCommand = Me.SqlUpdateCommand8
        '
        'SqlDeleteCommand8
        '
        Me.SqlDeleteCommand8.CommandText = "DELETE FROM service_center_dtl WHERE (id_service_center = @Original_id_service_ce" & _
        "nter) AND (radif = @Original_radif) AND (AVERAGE_COST = @Original_AVERAGE_COST O" & _
        "R @Original_AVERAGE_COST IS NULL AND AVERAGE_COST IS NULL) AND (COMMENT_ARTICLE " & _
        "= @Original_COMMENT_ARTICLE OR @Original_COMMENT_ARTICLE IS NULL AND COMMENT_ART" & _
        "ICLE IS NULL) AND (cod_select = @Original_cod_select OR @Original_cod_select IS " & _
        "NULL AND cod_select IS NULL) AND (cod_technician = @Original_cod_technician OR @" & _
        "Original_cod_technician IS NULL AND cod_technician IS NULL) AND (desc_radif = @O" & _
        "riginal_desc_radif OR @Original_desc_radif IS NULL AND desc_radif IS NULL) AND (" & _
        "fet = @Original_fet) AND (price = @Original_price) AND (qty = @Original_qty) AND" & _
        " (taxable = @Original_taxable OR @Original_taxable IS NULL AND taxable IS NULL) " & _
        "AND (type_select = @Original_type_select OR @Original_type_select IS NULL AND ty" & _
        "pe_select IS NULL)"
        Me.SqlDeleteCommand8.Connection = Me.Cnn
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AVERAGE_COST", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AVERAGE_COST", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_COMMENT_ARTICLE", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMMENT_ARTICLE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_select", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_select", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_technician", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_technician", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_radif", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fet", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_qty", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "qty", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_taxable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "taxable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_select", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_select", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlUpdateCommand8
        '
        Me.SqlUpdateCommand8.CommandText = "UPDATE service_center_dtl SET id_service_center = @id_service_center, radif = @ra" & _
        "dif, type_select = @type_select, cod_select = @cod_select, desc_radif = @desc_ra" & _
        "dif, qty = @qty, price = @price, fet = @fet, taxable = @taxable, cod_technician " & _
        "= @cod_technician, COMMENT_ARTICLE = @COMMENT_ARTICLE, AVERAGE_COST = @AVERAGE_C" & _
        "OST WHERE (id_service_center = @Original_id_service_center) AND (radif = @Origin" & _
        "al_radif) AND (AVERAGE_COST = @Original_AVERAGE_COST OR @Original_AVERAGE_COST I" & _
        "S NULL AND AVERAGE_COST IS NULL) AND (COMMENT_ARTICLE = @Original_COMMENT_ARTICL" & _
        "E OR @Original_COMMENT_ARTICLE IS NULL AND COMMENT_ARTICLE IS NULL) AND (cod_sel" & _
        "ect = @Original_cod_select OR @Original_cod_select IS NULL AND cod_select IS NUL" & _
        "L) AND (cod_technician = @Original_cod_technician OR @Original_cod_technician IS" & _
        " NULL AND cod_technician IS NULL) AND (desc_radif = @Original_desc_radif OR @Ori" & _
        "ginal_desc_radif IS NULL AND desc_radif IS NULL) AND (fet = @Original_fet) AND (" & _
        "price = @Original_price) AND (qty = @Original_qty) AND (taxable = @Original_taxa" & _
        "ble OR @Original_taxable IS NULL AND taxable IS NULL) AND (type_select = @Origin" & _
        "al_type_select OR @Original_type_select IS NULL AND type_select IS NULL); SELECT" & _
        " id_service_center, radif, type_select, cod_select, desc_radif, qty, price, fet," & _
        " taxable, cod_technician, COMMENT_ARTICLE, AVERAGE_COST FROM service_center_dtl " & _
        "WHERE (id_service_center = @id_service_center) AND (radif = @radif)"
        Me.SqlUpdateCommand8.Connection = Me.Cnn
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@radif", System.Data.SqlDbType.SmallInt, 2, "radif"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_select", System.Data.SqlDbType.VarChar, 1, "type_select"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_select", System.Data.SqlDbType.VarChar, 20, "cod_select"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_radif", System.Data.SqlDbType.VarChar, 100, "desc_radif"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@qty", System.Data.SqlDbType.Money, 8, "qty"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@price", System.Data.SqlDbType.Money, 8, "price"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fet", System.Data.SqlDbType.Money, 8, "fet"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@taxable", System.Data.SqlDbType.Bit, 1, "taxable"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_technician", System.Data.SqlDbType.VarChar, 5, "cod_technician"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@COMMENT_ARTICLE", System.Data.SqlDbType.VarChar, 300, "COMMENT_ARTICLE"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AVERAGE_COST", System.Data.SqlDbType.Money, 8, "AVERAGE_COST"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_radif", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AVERAGE_COST", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AVERAGE_COST", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_COMMENT_ARTICLE", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COMMENT_ARTICLE", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_select", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_select", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_technician", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_technician", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_radif", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_radif", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fet", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_price", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_qty", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "qty", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_taxable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "taxable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_select", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_select", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAservice_out_purchases
        '
        Me.DAservice_out_purchases.SelectCommand = Me.SqlSelectCommand6
        Me.DAservice_out_purchases.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_out_purchases", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("part_no", "part_no"), New System.Data.Common.DataColumnMapping("description", "description"), New System.Data.Common.DataColumnMapping("cost", "cost"), New System.Data.Common.DataColumnMapping("fet", "fet"), New System.Data.Common.DataColumnMapping("price", "price"), New System.Data.Common.DataColumnMapping("markup", "markup"), New System.Data.Common.DataColumnMapping("cod_vendor", "cod_vendor"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("line", "line"), New System.Data.Common.DataColumnMapping("invoice_no", "invoice_no"), New System.Data.Common.DataColumnMapping("invoice_date", "invoice_date"), New System.Data.Common.DataColumnMapping("due_date", "due_date"), New System.Data.Common.DataColumnMapping("tracking_warranty", "tracking_warranty"), New System.Data.Common.DataColumnMapping("in_day", "in_day"), New System.Data.Common.DataColumnMapping("in_mile", "in_mile"), New System.Data.Common.DataColumnMapping("tracking_core", "tracking_core"), New System.Data.Common.DataColumnMapping("core_value", "core_value")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT service_out_purchases.id_service_center, service_out_purchases.radif, serv" & _
        "ice_out_purchases.cost, service_out_purchases.fet, service_out_purchases.markup," & _
        " service_out_purchases.cod_vendor, service_out_purchases.po_no, service_out_purc" & _
        "hases.invoice_no, service_out_purchases.invoice_date, service_out_purchases.due_" & _
        "date, service_out_purchases.tracking_warranty, service_out_purchases.in_day, ser" & _
        "vice_out_purchases.in_mile, service_out_purchases.tracking_core, service_out_pur" & _
        "chases.core_value, service_out_purchases.Line, service_center_dtl.price, service" & _
        "_center_dtl.cod_select AS part_no, service_center_dtl.desc_radif AS description," & _
        " service_out_purchases.AR_terms FROM service_out_purchases INNER JOIN service_ce" & _
        "nter_dtl ON service_out_purchases.id_service_center = service_center_dtl.id_serv" & _
        "ice_center AND service_out_purchases.radif = service_center_dtl.radif WHERE (ser" & _
        "vice_out_purchases.id_service_center = @id_service_center)"
        Me.SqlSelectCommand6.Connection = Me.Cnn
        Me.SqlSelectCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        '
        'CnnReader
        '
        Me.CnnReader.ConnectionString = "workstation id=KETABIE;packet size=4096;user id=sa;data source=KETABIE;persist se" & _
        "curity info=True;initial catalog=TireMate_01;password=sa"
        '
        'DAEmployee
        '
        Me.DAEmployee.SelectCommand = Me.SqlSelectCommand3
        Me.DAEmployee.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "employee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("city", "city"), New System.Data.Common.DataColumnMapping("state", "state"), New System.Data.Common.DataColumnMapping("technecian", "technecian"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cod_position", "cod_position"), New System.Data.Common.DataColumnMapping("cod_deparment", "cod_deparment"), New System.Data.Common.DataColumnMapping("phone_main", "phone_main"), New System.Data.Common.DataColumnMapping("phone_work", "phone_work"), New System.Data.Common.DataColumnMapping("phone_cell", "phone_cell"), New System.Data.Common.DataColumnMapping("phome_other", "phome_other"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("pic", "pic"), New System.Data.Common.DataColumnMapping("birthday_date", "birthday_date"), New System.Data.Common.DataColumnMapping("hired_date", "hired_date"), New System.Data.Common.DataColumnMapping("last_reiew_date", "last_reiew_date"), New System.Data.Common.DataColumnMapping("terminate_date", "terminate_date"), New System.Data.Common.DataColumnMapping("temporary_inactive", "temporary_inactive"), New System.Data.Common.DataColumnMapping("last_basis", "last_basis"), New System.Data.Common.DataColumnMapping("last_period", "last_period"), New System.Data.Common.DataColumnMapping("last_status", "last_status"), New System.Data.Common.DataColumnMapping("last_salary", "last_salary"), New System.Data.Common.DataColumnMapping("last_hourly", "last_hourly"), New System.Data.Common.DataColumnMapping("last_overtime", "last_overtime"), New System.Data.Common.DataColumnMapping("deduction_cod1", "deduction_cod1"), New System.Data.Common.DataColumnMapping("deduction_amount1", "deduction_amount1"), New System.Data.Common.DataColumnMapping("deduction_cod2", "deduction_cod2"), New System.Data.Common.DataColumnMapping("deduction_amount2", "deduction_amount2"), New System.Data.Common.DataColumnMapping("deduction_cod3", "deduction_cod3"), New System.Data.Common.DataColumnMapping("deduction_amount3", "deduction_amount3"), New System.Data.Common.DataColumnMapping("deduction_cod4", "deduction_cod4"), New System.Data.Common.DataColumnMapping("deduction_amount4", "deduction_amount4"), New System.Data.Common.DataColumnMapping("deduction_cod5", "deduction_cod5"), New System.Data.Common.DataColumnMapping("deduction_amount5", "deduction_amount5"), New System.Data.Common.DataColumnMapping("deduction_cod6", "deduction_cod6"), New System.Data.Common.DataColumnMapping("deduction_amount6", "deduction_amount6")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT employee_code, f_name + ' ' + m_name + ' ' + l_name AS employee_Name FROM " & _
        "employee WHERE (technecian = 1)"
        Me.SqlSelectCommand3.Connection = Me.Cnn
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT GL_payment_deposit.ID_payment, GL_payment_deposit.id_service_center, GL_pa" & _
        "yment_deposit.refrence_no, GL_payment_deposit.refer_type, GL_payment_deposit.pay" & _
        "ment_type, GL_payment_deposit.payment_amount, GL_payment_cash.cash_rendered, GL_" & _
        "payment_cash.change_due, GL_payment_check.check_no, GL_payment_check.check_date," & _
        " GL_payment_AR.AR_terms, GL_payment_AR.AR_due_date, GL_payment_credit.cc_type, G" & _
        "L_payment_credit.cc_card_no, GL_payment_credit.cc_expire_date_year, GL_payment_c" & _
        "redit.cc_expire_date_month, GL_payment_credit.cc_auth_no, bas_cc_type.cc_type_de" & _
        "sc FROM GL_payment_deposit LEFT OUTER JOIN GL_payment_credit ON GL_payment_depos" & _
        "it.ID_payment = GL_payment_credit.ID_payment LEFT OUTER JOIN bas_cc_type ON GL_p" & _
        "ayment_credit.cc_type = bas_cc_type.cc_type LEFT OUTER JOIN GL_payment_AR ON GL_" & _
        "payment_deposit.ID_payment = GL_payment_AR.ID_payment LEFT OUTER JOIN GL_payment" & _
        "_check ON GL_payment_deposit.ID_payment = GL_payment_check.ID_payment LEFT OUTER" & _
        " JOIN GL_payment_cash ON GL_payment_deposit.ID_payment = GL_payment_cash.ID_paym" & _
        "ent WHERE (GL_payment_deposit.refer_type = '1') AND (GL_payment_deposit.id_servi" & _
        "ce_center = @id_service_center)"
        Me.SqlCommand3.Connection = Me.Cnn
        Me.SqlCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM GL_payment_deposit WHERE (ID_payment = @Original_ID_payment) AND (id_" & _
        "service_center = @Original_id_service_center OR @Original_id_service_center IS N" & _
        "ULL AND id_service_center IS NULL) AND (payment_amount = @Original_payment_amoun" & _
        "t OR @Original_payment_amount IS NULL AND payment_amount IS NULL) AND (payment_t" & _
        "ype = @Original_payment_type OR @Original_payment_type IS NULL AND payment_type " & _
        "IS NULL) AND (refer_type = @Original_refer_type OR @Original_refer_type IS NULL " & _
        "AND refer_type IS NULL) AND (refrence_no = @Original_refrence_no OR @Original_re" & _
        "frence_no IS NULL AND refrence_no IS NULL)"
        Me.SqlDeleteCommand2.Connection = Me.Cnn
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refer_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refer_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refrence_no", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_no", System.Data.DataRowVersion.Original, Nothing))
        '
        'CmdReader
        '
        Me.CmdReader.Connection = Me.CnnReader
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'DAService_tire_adjustment
        '
        Me.DAService_tire_adjustment.SelectCommand = Me.SqlSelectCommand7
        Me.DAService_tire_adjustment.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_tire_adjustment", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("radif", "radif"), New System.Data.Common.DataColumnMapping("DOT_safety_code", "DOT_safety_code"), New System.Data.Common.DataColumnMapping("DOT_serial_no", "DOT_serial_no"), New System.Data.Common.DataColumnMapping("measured_tread_depth", "measured_tread_depth"), New System.Data.Common.DataColumnMapping("condition_code", "condition_code"), New System.Data.Common.DataColumnMapping("supplier_percent", "supplier_percent"), New System.Data.Common.DataColumnMapping("costomer_portion", "costomer_portion")})})
        '
        'DAinv_tab_style
        '
        Me.DAinv_tab_style.SelectCommand = Me.SqlSelectCommand5
        Me.DAinv_tab_style.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_style", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("style", "style"), New System.Data.Common.DataColumnMapping("desc_style", "desc_style"), New System.Data.Common.DataColumnMapping("remark", "remark"), New System.Data.Common.DataColumnMapping("image_remark", "image_remark")})})
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = "INSERT INTO GL_payment_deposit(id_service_center, refrence_no, refer_type, paymen" & _
        "t_type, payment_amount) VALUES (@id_service_center, @refrence_no, @refer_type, @" & _
        "payment_type, @payment_amount); SELECT ID_payment, id_service_center, refrence_n" & _
        "o, refer_type, payment_type, payment_amount FROM GL_payment_deposit WHERE (ID_pa" & _
        "yment = @@IDENTITY)"
        Me.SqlCommand5.Connection = Me.Cnn
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 6, "refrence_no"))
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        '
        'SqlCommand7
        '
        Me.SqlCommand7.CommandText = "UPDATE GL_payment_deposit SET id_service_center = @id_service_center, refrence_no" & _
        " = @refrence_no, refer_type = @refer_type, payment_type = @payment_type, payment" & _
        "_amount = @payment_amount WHERE (ID_payment = @Original_ID_payment) AND (id_serv" & _
        "ice_center = @Original_id_service_center OR @Original_id_service_center IS NULL " & _
        "AND id_service_center IS NULL) AND (payment_amount = @Original_payment_amount OR" & _
        " @Original_payment_amount IS NULL AND payment_amount IS NULL) AND (payment_type " & _
        "= @Original_payment_type OR @Original_payment_type IS NULL AND payment_type IS N" & _
        "ULL) AND (refer_type = @Original_refer_type OR @Original_refer_type IS NULL AND " & _
        "refer_type IS NULL) AND (refrence_no = @Original_refrence_no OR @Original_refren" & _
        "ce_no IS NULL AND refrence_no IS NULL); SELECT ID_payment, id_service_center, re" & _
        "frence_no, refer_type, payment_type, payment_amount FROM GL_payment_deposit WHER" & _
        "E (ID_payment = @ID_payment)"
        Me.SqlCommand7.Connection = Me.Cnn
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 6, "refrence_no"))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refer_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refer_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refrence_no", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_payment", System.Data.SqlDbType.Int, 4, "ID_payment"))
        '
        'SqlCommand6
        '
        Me.SqlCommand6.CommandText = "SELECT GL_payment_deposit.ID_payment, GL_payment_deposit.id_service_center, GL_pa" & _
        "yment_deposit.refrence_no, GL_payment_deposit.refer_type, GL_payment_deposit.pay" & _
        "ment_type, GL_payment_deposit.payment_amount, GL_payment_cash.cash_rendered, GL_" & _
        "payment_cash.change_due, GL_payment_check.check_no, GL_payment_check.check_date," & _
        " GL_payment_AR.AR_terms, GL_payment_AR.AR_due_date, GL_payment_credit.cc_type, G" & _
        "L_payment_credit.cc_card_no, GL_payment_credit.cc_expire_date_year, GL_payment_c" & _
        "redit.cc_expire_date_month, GL_payment_credit.cc_auth_no FROM GL_payment_deposit" & _
        " LEFT OUTER JOIN GL_payment_credit ON GL_payment_deposit.ID_payment = GL_payment" & _
        "_credit.ID_payment LEFT OUTER JOIN GL_payment_AR ON GL_payment_deposit.ID_paymen" & _
        "t = GL_payment_AR.ID_payment LEFT OUTER JOIN GL_payment_check ON GL_payment_depo" & _
        "sit.ID_payment = GL_payment_check.ID_payment LEFT OUTER JOIN GL_payment_cash ON " & _
        "GL_payment_deposit.ID_payment = GL_payment_cash.ID_payment WHERE (GL_payment_dep" & _
        "osit.refer_type = '1') AND (GL_payment_deposit.id_service_center = @id_service_c" & _
        "enter)"
        Me.SqlCommand6.Connection = Me.Cnn
        Me.SqlCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE GL_payment_deposit SET id_service_center = @id_service_center, refrence_no" & _
        " = @refrence_no, refer_type = @refer_type, payment_type = @payment_type, payment" & _
        "_amount = @payment_amount WHERE (ID_payment = @Original_ID_payment) AND (id_serv" & _
        "ice_center = @Original_id_service_center OR @Original_id_service_center IS NULL " & _
        "AND id_service_center IS NULL) AND (payment_amount = @Original_payment_amount OR" & _
        " @Original_payment_amount IS NULL AND payment_amount IS NULL) AND (payment_type " & _
        "= @Original_payment_type OR @Original_payment_type IS NULL AND payment_type IS N" & _
        "ULL) AND (refer_type = @Original_refer_type OR @Original_refer_type IS NULL AND " & _
        "refer_type IS NULL) AND (refrence_no = @Original_refrence_no OR @Original_refren" & _
        "ce_no IS NULL AND refrence_no IS NULL); SELECT ID_payment, id_service_center, re" & _
        "frence_no, refer_type, payment_type, payment_amount FROM GL_payment_deposit WHER" & _
        "E (ID_payment = @ID_payment)"
        Me.SqlCommand4.Connection = Me.Cnn
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 6, "refrence_no"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refer_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refer_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refrence_no", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_payment", System.Data.SqlDbType.Int, 4, "ID_payment"))
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "INSERT INTO GL_payment_deposit(id_service_center, refrence_no, refer_type, paymen" & _
        "t_type, payment_amount) VALUES (@id_service_center, @refrence_no, @refer_type, @" & _
        "payment_type, @payment_amount); SELECT ID_payment, id_service_center, refrence_n" & _
        "o, refer_type, payment_type, payment_amount FROM GL_payment_deposit WHERE (ID_pa" & _
        "yment = @@IDENTITY)"
        Me.SqlCommand2.Connection = Me.Cnn
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 6, "refrence_no"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO GL_payment_deposit(id_service_center, refrence_no, refer_type, paymen" & _
        "t_type, payment_amount) VALUES (@id_service_center, @refrence_no, @refer_type, @" & _
        "payment_type, @payment_amount); SELECT ID_payment, id_service_center, refrence_n" & _
        "o, refer_type, payment_type, payment_amount FROM GL_payment_deposit WHERE (ID_pa" & _
        "yment = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 6, "refrence_no"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE GL_payment_deposit SET id_service_center = @id_service_center, refrence_no" & _
        " = @refrence_no, refer_type = @refer_type, payment_type = @payment_type, payment" & _
        "_amount = @payment_amount WHERE (ID_payment = @Original_ID_payment) AND (id_serv" & _
        "ice_center = @Original_id_service_center OR @Original_id_service_center IS NULL " & _
        "AND id_service_center IS NULL) AND (payment_amount = @Original_payment_amount OR" & _
        " @Original_payment_amount IS NULL AND payment_amount IS NULL) AND (payment_type " & _
        "= @Original_payment_type OR @Original_payment_type IS NULL AND payment_type IS N" & _
        "ULL) AND (refer_type = @Original_refer_type OR @Original_refer_type IS NULL AND " & _
        "refer_type IS NULL) AND (refrence_no = @Original_refrence_no OR @Original_refren" & _
        "ce_no IS NULL AND refrence_no IS NULL); SELECT ID_payment, id_service_center, re" & _
        "frence_no, refer_type, payment_type, payment_amount FROM GL_payment_deposit WHER" & _
        "E (ID_payment = @ID_payment)"
        Me.SqlUpdateCommand2.Connection = Me.Cnn
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refrence_no", System.Data.SqlDbType.VarChar, 6, "refrence_no"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@refer_type", System.Data.SqlDbType.VarChar, 1, "refer_type"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_type", System.Data.SqlDbType.VarChar, 1, "payment_type"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@payment_amount", System.Data.SqlDbType.Money, 8, "payment_amount"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_payment", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_payment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_payment_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "payment_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refer_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refer_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_refrence_no", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "refrence_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_payment", System.Data.SqlDbType.Int, 4, "ID_payment"))
        '
        'DsFrmWorkOrders1
        '
        Me.DsFrmWorkOrders1.DataSetName = "DSFrmWorkOrders"
        Me.DsFrmWorkOrders1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'GrdDetail
        '
        Me.GrdDetail.AllowColumnDrag = False
        Me.GrdDetail.AutomaticSort = False
        Me.GrdDetail.BorderStyle = Janus.Windows.GridEX.BorderStyle.Raised
        Me.GrdDetail.Cursor = System.Windows.Forms.Cursors.Default
        Me.GrdDetail.DataMember = "service_center_dtl"
        Me.GrdDetail.DataSource = Me.DsFrmWorkOrders1
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>service_center_dtl</Caption><Columns Collec" & _
        "tion=""true""><Column0 ID=""type_select""><Caption>Type</Caption><DataMember>type_se" & _
        "lect</DataMember><DefaultGroupInterval>Text</DefaultGroupInterval><EditType>NoEd" & _
        "it</EditType><Key>type_select</Key><Position>0</Position><CompareTarget>Text</Co" & _
        "mpareTarget><Width>34</Width><DropDownIndex>1</DropDownIndex></Column0><Column1 " & _
        "ID=""Hst""><Bound>False</Bound><ButtonStyle>ButtonCell</ButtonStyle><Caption>Hst</" & _
        "Caption><DataMember>Hst</DataMember><EditType>NoEdit</EditType><Key>Hst</Key><Po" & _
        "sition>1</Position><Selectable>False</Selectable><Width>27</Width></Column1><Col" & _
        "umn2 ID=""Cm""><Bound>False</Bound><ButtonStyle>ButtonCell</ButtonStyle><Caption>C" & _
        "m</Caption><EditType>NoEdit</EditType><Key>Cm</Key><Position>2</Position><Select" & _
        "able>False</Selectable><Width>27</Width></Column2><Column3 ID=""Det""><Bound>False" & _
        "</Bound><ButtonStyle>ButtonCell</ButtonStyle><Caption>Det</Caption><EditType>NoE" & _
        "dit</EditType><Key>Det</Key><Position>3</Position><Selectable>False</Selectable>" & _
        "<Width>27</Width></Column3><Column4 ID=""cod_select""><Caption>Item No</Caption><D" & _
        "ataMember>cod_select</DataMember><EditType>NoEdit</EditType><Key>cod_select</Key" & _
        "><Position>4</Position><Width>76</Width><CellStyle><BackColor>Silver</BackColor>" & _
        "</CellStyle></Column4><Column5 ID=""desc_radif""><Caption>Description</Caption><Da" & _
        "taMember>desc_radif</DataMember><EditType>NoEdit</EditType><Key>desc_radif</Key>" & _
        "<Position>5</Position><Width>180</Width></Column5><Column6 ID=""qty""><Caption>Qty" & _
        "</Caption><DataMember>qty</DataMember><EditType>NoEdit</EditType><InputMask>Numb" & _
        "er0</InputMask><Key>qty</Key><Position>6</Position><Width>27</Width><CellStyle><" & _
        "BackColor>Silver</BackColor></CellStyle></Column6><Column7 ID=""price""><Caption>P" & _
        "rice</Caption><DataMember>price</DataMember><EditType>NoEdit</EditType><FormatSt" & _
        "ring>c2</FormatString><InputMask>Currency2</InputMask><Key>price</Key><MaskPromp" & _
        "t>&#x0;</MaskPrompt><Position>7</Position><Width>60</Width></Column7><Column8 ID" & _
        "=""fet""><Caption>FET</Caption><DataMember>fet</DataMember><EditType>NoEdit</EditT" & _
        "ype><FormatString>c2</FormatString><InputMask>Currency2</InputMask><Key>fet</Key" & _
        "><Position>8</Position><Width>40</Width><CellStyle><BackColor>Silver</BackColor>" & _
        "</CellStyle></Column8><Column9 ID=""taxable""><Caption>T</Caption><ColumnType>Chec" & _
        "kBox</ColumnType><DataMember>taxable</DataMember><EditType>NoEdit</EditType><Key" & _
        ">taxable</Key><Position>9</Position><Width>16</Width></Column9><Column10 ID=""Ext" & _
        "_Price""><Caption>Ext_Price</Caption><DataMember>Ext_Price</DataMember><EditType>" & _
        "NoEdit</EditType><FormatString>c</FormatString><InputMask>Currency2</InputMask><" & _
        "Key>Ext_Price</Key><MaskPrompt>&#x0;</MaskPrompt><Position>10</Position><Selecta" & _
        "ble>False</Selectable><Width>66</Width></Column10><Column11 ID=""cod_technician"">" & _
        "<Caption>Tech</Caption><DataMember>cod_technician</DataMember><DefaultGroupInter" & _
        "val>Text</DefaultGroupInterval><EditType>NoEdit</EditType><Key>cod_technician</K" & _
        "ey><Position>11</Position><CompareTarget>Text</CompareTarget><Width>45</Width><D" & _
        "ropDownIndex>0</DropDownIndex></Column11><Column12 ID=""id_service_center""><Capti" & _
        "on>id_service_center</Caption><TypeNameEmptyStringValue>NULL</TypeNameEmptyStrin" & _
        "gValue><EmptyStringValue /><DataMember>id_service_center</DataMember><EditType>N" & _
        "oEdit</EditType><Key>id_service_center</Key><Position>12</Position><Visible>Fals" & _
        "e</Visible></Column12><Column13 ID=""radif""><Caption>radif</Caption><TypeNameEmpt" & _
        "yStringValue>NULL</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>radi" & _
        "f</DataMember><EditType>NoEdit</EditType><Key>radif</Key><Position>13</Position>" & _
        "<Visible>False</Visible></Column13><Column14 ID=""FlagIsPackage""><Caption>FlagIsP" & _
        "ackage</Caption><DataMember>FlagIsPackage</DataMember><EditType>NoEdit</EditType" & _
        "><Key>FlagIsPackage</Key><Position>14</Position><Visible>False</Visible></Column" & _
        "14><Column15 ID=""PricePlusFet""><Caption>PricePlusFet</Caption><DataMember>PriceP" & _
        "lusFet</DataMember><EditType>NoEdit</EditType><Key>PricePlusFet</Key><Position>1" & _
        "5</Position><Visible>False</Visible></Column15></Columns><GroupCondition ID="""" /" & _
        "><Key>service_center_dtl</Key><RowHeight>19</RowHeight><SortKeys Collection=""tru" & _
        "e""><SortKey0 ID=""SortKey0""><ColIndex>13</ColIndex></SortKey0></SortKeys></RootTa" & _
        "ble><DropDowns Collection=""true""><DropDown0><RootTable><Columns Collection=""true" & _
        """><Column0 ID=""employee_code""><Caption>Code</Caption><TypeNameEmptyStringValue>S" & _
        "ystem.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>employee_" & _
        "code</DataMember><Key>employee_code</Key><Position>0</Position><Width>40</Width>" & _
        "</Column0><Column1 ID=""employee_Name""><Caption>Name</Caption><DataMember>employe" & _
        "e_Name</DataMember><EditType>NoEdit</EditType><Key>employee_Name</Key><Position>" & _
        "1</Position><Width>220</Width></Column1></Columns><GroupCondition ID="""" /></Root" & _
        "Table><WatermarkImage /><Font>Microsoft Sans Serif, 8.25pt</Font><ControlStyle /" & _
        "><AllowEdit>False</AllowEdit><ExpandableGroups>False</ExpandableGroups><GroupByB" & _
        "oxVisible>False</GroupByBoxVisible><HideSelection>Highlight</HideSelection><Key>" & _
        "DropDownTechnician</Key><DisplayMember>employee_code</DisplayMember><ValueMember" & _
        ">employee_code</ValueMember></DropDown0><DropDown1><RootTable><Columns Collectio" & _
        "n=""true""><Column0 ID=""Code""><Caption>Type</Caption><DataMember>Code</DataMember>" & _
        "<Key>Code</Key><Position>0</Position><Width>40</Width></Column0><Column1 ID=""Des" & _
        "c""><Caption>Description</Caption><DataMember>Desc</DataMember><Key>Desc</Key><Po" & _
        "sition>1</Position></Column1></Columns><GroupCondition ID="""" /></RootTable><Wate" & _
        "rmarkImage /><Font>Microsoft Sans Serif, 8.25pt</Font><ControlStyle /><AllowEdit" & _
        ">False</AllowEdit><ExpandableGroups>False</ExpandableGroups><GroupByBoxVisible>F" & _
        "alse</GroupByBoxVisible><HideSelection>Highlight</HideSelection><Key>DropDownTyp" & _
        "eSelect</Key><DisplayMember>Code</DisplayMember><ValueMember>Code</ValueMember><" & _
        "/DropDown1></DropDowns></GridEXLayoutData>"
        Me.GrdDetail.DesignTimeLayout = GridEXLayout1
        Me.GrdDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdDetail.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdDetail.ExternalImageList = Me.imageList1
        Me.GrdDetail.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GrdDetail.GroupByBoxVisible = False
        Me.GrdDetail.HeaderFormatStyle.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GrdDetail.HeaderFormatStyle.BackColorGradient = System.Drawing.SystemColors.Control
        Me.GrdDetail.Location = New System.Drawing.Point(0, 155)
        Me.GrdDetail.Name = "GrdDetail"
        Me.GrdDetail.Size = New System.Drawing.Size(647, 294)
        Me.GrdDetail.TabIndex = 3
        Me.GrdDetail.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel11)
        Me.Panel3.Controls.Add(Me.Panel10)
        Me.Panel3.Controls.Add(Me.Panel9)
        Me.Panel3.Controls.Add(Me.Panel8)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.LblTotal)
        Me.Panel3.Controls.Add(Me.NumDiscount)
        Me.Panel3.Controls.Add(Me.NumTax)
        Me.Panel3.Controls.Add(Me.LblSubtotal)
        Me.Panel3.Controls.Add(Me.LblFET)
        Me.Panel3.Controls.Add(Me.LblFees)
        Me.Panel3.Controls.Add(Me.LblLabor)
        Me.Panel3.Controls.Add(Me.LblParts)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Location = New System.Drawing.Point(263, 31)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(120, 122)
        Me.Panel3.TabIndex = 136
        '
        'Panel11
        '
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Location = New System.Drawing.Point(49, 58)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(75, 1)
        Me.Panel11.TabIndex = 176
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Location = New System.Drawing.Point(48, 73)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(75, 1)
        Me.Panel10.TabIndex = 175
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Location = New System.Drawing.Point(51, 88)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(75, 1)
        Me.Panel9.TabIndex = 174
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Location = New System.Drawing.Point(46, 104)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(75, 1)
        Me.Panel8.TabIndex = 173
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Location = New System.Drawing.Point(46, 44)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(75, 1)
        Me.Panel7.TabIndex = 172
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Location = New System.Drawing.Point(44, 29)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(75, 1)
        Me.Panel6.TabIndex = 171
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(44, 14)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(75, 1)
        Me.Panel5.TabIndex = 170
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblTotal.BorderStyle = Janus.Windows.UI.BorderStyle.None
        Me.LblTotal.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblTotal.DecimalDigits = 2
        Me.LblTotal.DefaultSendValue = False
        Me.LblTotal.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblTotal.FireTabAfterEnter = True
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Image = CType(resources.GetObject("LblTotal.Image"), System.Drawing.Image)
        Me.LblTotal.Location = New System.Drawing.Point(58, 104)
        Me.LblTotal.Maxlength = 10
        Me.LblTotal.MinusColor = System.Drawing.Color.Empty
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.ReadOnly = True
        Me.LblTotal.Size = New System.Drawing.Size(63, 21)
        Me.LblTotal.TabIndex = 164
        Me.LblTotal.TabStop = False
        Me.LblTotal.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblTotal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumDiscount
        '
        Me.NumDiscount.BackColor = System.Drawing.SystemColors.Window
        Me.NumDiscount.BorderStyle = Janus.Windows.UI.BorderStyle.None
        Me.NumDiscount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumDiscount.DecimalDigits = 2
        Me.NumDiscount.DefaultSendValue = False
        Me.NumDiscount.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumDiscount.FireTabAfterEnter = True
        Me.NumDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumDiscount.Image = CType(resources.GetObject("NumDiscount.Image"), System.Drawing.Image)
        Me.NumDiscount.Location = New System.Drawing.Point(58, 88)
        Me.NumDiscount.Maxlength = 10
        Me.NumDiscount.MinusColor = System.Drawing.Color.Empty
        Me.NumDiscount.Name = "NumDiscount"
        Me.NumDiscount.ReadOnly = True
        Me.NumDiscount.Size = New System.Drawing.Size(60, 21)
        Me.NumDiscount.TabIndex = 163
        Me.NumDiscount.TabStop = False
        Me.NumDiscount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumDiscount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'NumTax
        '
        Me.NumTax.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.NumTax.BorderStyle = Janus.Windows.UI.BorderStyle.None
        Me.NumTax.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumTax.DecimalDigits = 2
        Me.NumTax.DefaultSendValue = False
        Me.NumTax.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumTax.FireTabAfterEnter = True
        Me.NumTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumTax.Image = CType(resources.GetObject("NumTax.Image"), System.Drawing.Image)
        Me.NumTax.Location = New System.Drawing.Point(58, 73)
        Me.NumTax.Maxlength = 10
        Me.NumTax.MinusColor = System.Drawing.Color.Empty
        Me.NumTax.Name = "NumTax"
        Me.NumTax.ReadOnly = True
        Me.NumTax.Size = New System.Drawing.Size(59, 21)
        Me.NumTax.TabIndex = 162
        Me.NumTax.TabStop = False
        Me.NumTax.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumTax.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblSubtotal
        '
        Me.LblSubtotal.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblSubtotal.BorderStyle = Janus.Windows.UI.BorderStyle.None
        Me.LblSubtotal.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblSubtotal.DecimalDigits = 2
        Me.LblSubtotal.DefaultSendValue = False
        Me.LblSubtotal.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblSubtotal.FireTabAfterEnter = True
        Me.LblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubtotal.Image = CType(resources.GetObject("LblSubtotal.Image"), System.Drawing.Image)
        Me.LblSubtotal.Location = New System.Drawing.Point(58, 58)
        Me.LblSubtotal.Maxlength = 10
        Me.LblSubtotal.MinusColor = System.Drawing.Color.Empty
        Me.LblSubtotal.Name = "LblSubtotal"
        Me.LblSubtotal.ReadOnly = True
        Me.LblSubtotal.Size = New System.Drawing.Size(60, 21)
        Me.LblSubtotal.TabIndex = 167
        Me.LblSubtotal.TabStop = False
        Me.LblSubtotal.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblSubtotal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblFET
        '
        Me.LblFET.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblFET.BorderStyle = Janus.Windows.UI.BorderStyle.None
        Me.LblFET.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblFET.DecimalDigits = 2
        Me.LblFET.DefaultSendValue = False
        Me.LblFET.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblFET.FireTabAfterEnter = True
        Me.LblFET.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFET.Image = CType(resources.GetObject("LblFET.Image"), System.Drawing.Image)
        Me.LblFET.Location = New System.Drawing.Point(58, 43)
        Me.LblFET.Maxlength = 10
        Me.LblFET.MinusColor = System.Drawing.Color.Empty
        Me.LblFET.Name = "LblFET"
        Me.LblFET.ReadOnly = True
        Me.LblFET.Size = New System.Drawing.Size(59, 21)
        Me.LblFET.TabIndex = 166
        Me.LblFET.TabStop = False
        Me.LblFET.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblFET.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblFees
        '
        Me.LblFees.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblFees.BorderStyle = Janus.Windows.UI.BorderStyle.None
        Me.LblFees.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblFees.DecimalDigits = 2
        Me.LblFees.DefaultSendValue = False
        Me.LblFees.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblFees.FireTabAfterEnter = True
        Me.LblFees.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFees.Image = CType(resources.GetObject("LblFees.Image"), System.Drawing.Image)
        Me.LblFees.Location = New System.Drawing.Point(58, 28)
        Me.LblFees.Maxlength = 10
        Me.LblFees.MinusColor = System.Drawing.Color.Empty
        Me.LblFees.Name = "LblFees"
        Me.LblFees.ReadOnly = True
        Me.LblFees.Size = New System.Drawing.Size(59, 21)
        Me.LblFees.TabIndex = 165
        Me.LblFees.TabStop = False
        Me.LblFees.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblFees.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblLabor
        '
        Me.LblLabor.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblLabor.BorderStyle = Janus.Windows.UI.BorderStyle.None
        Me.LblLabor.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblLabor.DecimalDigits = 2
        Me.LblLabor.DefaultSendValue = False
        Me.LblLabor.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblLabor.FireTabAfterEnter = True
        Me.LblLabor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLabor.Image = CType(resources.GetObject("LblLabor.Image"), System.Drawing.Image)
        Me.LblLabor.Location = New System.Drawing.Point(58, 13)
        Me.LblLabor.Maxlength = 10
        Me.LblLabor.MinusColor = System.Drawing.Color.Empty
        Me.LblLabor.Name = "LblLabor"
        Me.LblLabor.ReadOnly = True
        Me.LblLabor.Size = New System.Drawing.Size(59, 21)
        Me.LblLabor.TabIndex = 169
        Me.LblLabor.TabStop = False
        Me.LblLabor.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblLabor.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'LblParts
        '
        Me.LblParts.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblParts.BorderStyle = Janus.Windows.UI.BorderStyle.None
        Me.LblParts.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.LblParts.DecimalDigits = 2
        Me.LblParts.DefaultSendValue = False
        Me.LblParts.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.LblParts.FireTabAfterEnter = True
        Me.LblParts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblParts.Image = CType(resources.GetObject("LblParts.Image"), System.Drawing.Image)
        Me.LblParts.Location = New System.Drawing.Point(58, -2)
        Me.LblParts.Maxlength = 10
        Me.LblParts.MinusColor = System.Drawing.Color.Empty
        Me.LblParts.Name = "LblParts"
        Me.LblParts.ReadOnly = True
        Me.LblParts.Size = New System.Drawing.Size(59, 21)
        Me.LblParts.TabIndex = 168
        Me.LblParts.TabStop = False
        Me.LblParts.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.LblParts.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label23.Location = New System.Drawing.Point(-1, 104)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(59, 17)
        Me.Label23.TabIndex = 144
        Me.Label23.Text = "Total"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Location = New System.Drawing.Point(-1, 73)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 16)
        Me.Label21.TabIndex = 142
        Me.Label21.Text = "Tax"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label20.Location = New System.Drawing.Point(-1, 58)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 16)
        Me.Label20.TabIndex = 141
        Me.Label20.Text = "Subtotal"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Location = New System.Drawing.Point(-1, 44)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 15)
        Me.Label19.TabIndex = 140
        Me.Label19.Text = "FET"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Location = New System.Drawing.Point(-1, 29)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 16)
        Me.Label18.TabIndex = 139
        Me.Label18.Text = "Fees"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Location = New System.Drawing.Point(-1, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 16)
        Me.Label17.TabIndex = 138
        Me.Label17.Text = "Labor"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(-1, -1)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 16)
        Me.Label16.TabIndex = 137
        Me.Label16.Text = "Parts"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Location = New System.Drawing.Point(-8, 88)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 17)
        Me.Label22.TabIndex = 143
        Me.Label22.Text = "Discount%"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblVehicleYear
        '
        Me.LblVehicleYear.BackColor = System.Drawing.SystemColors.Window
        Me.LblVehicleYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblVehicleYear.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVehicleYear.Location = New System.Drawing.Point(584, 83)
        Me.LblVehicleYear.Name = "LblVehicleYear"
        Me.LblVehicleYear.Size = New System.Drawing.Size(57, 22)
        Me.LblVehicleYear.TabIndex = 156
        Me.LblVehicleYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblVehicleVin
        '
        Me.LblVehicleVin.BackColor = System.Drawing.SystemColors.Window
        Me.LblVehicleVin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblVehicleVin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVehicleVin.Location = New System.Drawing.Point(439, 83)
        Me.LblVehicleVin.Name = "LblVehicleVin"
        Me.LblVehicleVin.Size = New System.Drawing.Size(146, 22)
        Me.LblVehicleVin.TabIndex = 155
        Me.LblVehicleVin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblVehicleModel
        '
        Me.LblVehicleModel.BackColor = System.Drawing.SystemColors.Window
        Me.LblVehicleModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblVehicleModel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVehicleModel.Location = New System.Drawing.Point(547, 56)
        Me.LblVehicleModel.Name = "LblVehicleModel"
        Me.LblVehicleModel.Size = New System.Drawing.Size(94, 26)
        Me.LblVehicleModel.TabIndex = 154
        Me.LblVehicleModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblVehicleMake
        '
        Me.LblVehicleMake.BackColor = System.Drawing.SystemColors.Window
        Me.LblVehicleMake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblVehicleMake.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVehicleMake.Location = New System.Drawing.Point(439, 56)
        Me.LblVehicleMake.Name = "LblVehicleMake"
        Me.LblVehicleMake.Size = New System.Drawing.Size(109, 26)
        Me.LblVehicleMake.TabIndex = 153
        Me.LblVehicleMake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumCurrent_mileage
        '
        Me.NumCurrent_mileage.BorderStyle = Janus.Windows.UI.BorderStyle.Sunken
        Me.NumCurrent_mileage.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.NoButton
        Me.NumCurrent_mileage.DecimalDigits = 0
        Me.NumCurrent_mileage.DefaultSendValue = False
        Me.NumCurrent_mileage.EditMode = Janus.Windows.GridEX.NumericEditMode.FormattedText
        Me.NumCurrent_mileage.FireTabAfterEnter = True
        Me.NumCurrent_mileage.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.NumCurrent_mileage.Image = CType(resources.GetObject("NumCurrent_mileage.Image"), System.Drawing.Image)
        Me.NumCurrent_mileage.Location = New System.Drawing.Point(438, 108)
        Me.NumCurrent_mileage.Maxlength = 7
        Me.NumCurrent_mileage.MinusColor = System.Drawing.Color.Empty
        Me.NumCurrent_mileage.Name = "NumCurrent_mileage"
        Me.NumCurrent_mileage.ReadOnly = True
        Me.NumCurrent_mileage.Size = New System.Drawing.Size(49, 21)
        Me.NumCurrent_mileage.TabIndex = 158
        Me.NumCurrent_mileage.TabStop = False
        Me.NumCurrent_mileage.TextAlignment = Janus.Windows.GridEX.TextAlignment.Empty
        Me.NumCurrent_mileage.VisualStyle = Janus.Windows.GridEX.VisualStyle.Default
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Silver
        Me.Label35.Location = New System.Drawing.Point(396, 108)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(44, 21)
        Me.Label35.TabIndex = 157
        Me.Label35.Text = "Mileage"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCustomerCompanyname
        '
        Me.LblCustomerCompanyname.BackColor = System.Drawing.SystemColors.Window
        Me.LblCustomerCompanyname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCustomerCompanyname.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCustomerCompanyname.Location = New System.Drawing.Point(57, 85)
        Me.LblCustomerCompanyname.Name = "LblCustomerCompanyname"
        Me.LblCustomerCompanyname.Size = New System.Drawing.Size(198, 35)
        Me.LblCustomerCompanyname.TabIndex = 176
        Me.LblCustomerCompanyname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Silver
        Me.Label9.Location = New System.Drawing.Point(4, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 22)
        Me.Label9.TabIndex = 175
        Me.Label9.Text = "Company"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(4, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 21)
        Me.Label8.TabIndex = 174
        Me.Label8.Text = "Name"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Silver
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label34.Location = New System.Drawing.Point(393, 33)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(45, 21)
        Me.Label34.TabIndex = 177
        Me.Label34.Text = "Vehicle"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(4, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 21)
        Me.Label7.TabIndex = 178
        Me.Label7.Text = "Customer"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TxtDate)
        Me.Panel1.Controls.Add(Me.LblType)
        Me.Panel1.Controls.Add(Me.TxtRef)
        Me.Panel1.Controls.Add(Me.CmbType)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.LblStoreNo)
        Me.Panel1.Controls.Add(Me.LblCompanyName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(647, 30)
        Me.Panel1.TabIndex = 179
        '
        'TxtDate
        '
        Me.TxtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDate.Enabled = False
        Me.TxtDate.Location = New System.Drawing.Point(349, 4)
        Me.TxtDate.Name = "TxtDate"
        Me.TxtDate.Size = New System.Drawing.Size(77, 20)
        Me.TxtDate.TabIndex = 156
        Me.TxtDate.Text = ""
        Me.TxtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblType
        '
        Me.LblType.BackColor = System.Drawing.Color.MediumTurquoise
        Me.LblType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LblType.Location = New System.Drawing.Point(228, 4)
        Me.LblType.Name = "LblType"
        Me.LblType.ReadOnly = True
        Me.LblType.Size = New System.Drawing.Size(91, 21)
        Me.LblType.TabIndex = 155
        Me.LblType.Text = "Work Order"
        Me.LblType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtRef
        '
        Me.TxtRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRef.Enabled = False
        Me.TxtRef.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtRef.Location = New System.Drawing.Point(449, 4)
        Me.TxtRef.Name = "TxtRef"
        Me.TxtRef.Size = New System.Drawing.Size(92, 21)
        Me.TxtRef.TabIndex = 152
        Me.TxtRef.Text = ""
        Me.TxtRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CmbType
        '
        Me.CmbType.BorderStyle = Janus.Windows.UI.BorderStyle.Flat
        Me.CmbType.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList
        Me.CmbType.Enabled = False
        UiComboBoxItem1.FormatStyle.Alpha = 0
        UiComboBoxItem1.Text = "WO"
        UiComboBoxItem1.Value = "Work Order"
        UiComboBoxItem2.FormatStyle.Alpha = 0
        UiComboBoxItem2.Text = "ES"
        UiComboBoxItem2.Value = "Estimates"
        UiComboBoxItem3.FormatStyle.Alpha = 0
        UiComboBoxItem3.Text = "IN"
        UiComboBoxItem3.Value = "Invoices"
        UiComboBoxItem4.FormatStyle.Alpha = 0
        UiComboBoxItem4.Text = "RT"
        UiComboBoxItem4.Value = "Returns"
        Me.CmbType.Items.AddRange(New Janus.Windows.EditControls.UIComboBoxItem() {UiComboBoxItem1, UiComboBoxItem2, UiComboBoxItem3, UiComboBoxItem4})
        Me.CmbType.Location = New System.Drawing.Point(180, 4)
        Me.CmbType.Name = "CmbType"
        Me.CmbType.Size = New System.Drawing.Size(48, 20)
        Me.CmbType.TabIndex = 154
        Me.CmbType.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(151, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 20)
        Me.Label6.TabIndex = 153
        Me.Label6.Text = "Type"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(425, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 22)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "Ref"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(319, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 20)
        Me.Label4.TabIndex = 150
        Me.Label4.Text = "Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblStoreNo
        '
        Me.LblStoreNo.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblStoreNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblStoreNo.Location = New System.Drawing.Point(544, 2)
        Me.LblStoreNo.Name = "LblStoreNo"
        Me.LblStoreNo.Size = New System.Drawing.Size(101, 25)
        Me.LblStoreNo.TabIndex = 149
        Me.LblStoreNo.Text = "LblStoreNo"
        Me.LblStoreNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCompanyName
        '
        Me.LblCompanyName.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(240, Byte), CType(100, Byte))
        Me.LblCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCompanyName.Location = New System.Drawing.Point(0, 2)
        Me.LblCompanyName.Name = "LblCompanyName"
        Me.LblCompanyName.Size = New System.Drawing.Size(147, 25)
        Me.LblCompanyName.TabIndex = 148
        Me.LblCompanyName.Text = "LblCompanyName"
        Me.LblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtLicenceNo
        '
        Me.TxtLicenceNo.BackColor = System.Drawing.SystemColors.Window
        Me.TxtLicenceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLicenceNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLicenceNo.Location = New System.Drawing.Point(439, 33)
        Me.TxtLicenceNo.Name = "TxtLicenceNo"
        Me.TxtLicenceNo.Size = New System.Drawing.Size(94, 22)
        Me.TxtLicenceNo.TabIndex = 180
        Me.TxtLicenceNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCustomerCod
        '
        Me.TxtCustomerCod.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCustomerCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerCod.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerCod.Location = New System.Drawing.Point(57, 35)
        Me.TxtCustomerCod.Name = "TxtCustomerCod"
        Me.TxtCustomerCod.Size = New System.Drawing.Size(84, 22)
        Me.TxtCustomerCod.TabIndex = 181
        Me.TxtCustomerCod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCustomerFName
        '
        Me.TxtCustomerFName.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCustomerFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerFName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerFName.Location = New System.Drawing.Point(57, 61)
        Me.TxtCustomerFName.Name = "TxtCustomerFName"
        Me.TxtCustomerFName.Size = New System.Drawing.Size(70, 20)
        Me.TxtCustomerFName.TabIndex = 182
        Me.TxtCustomerFName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCustomerMName
        '
        Me.TxtCustomerMName.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCustomerMName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerMName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerMName.Location = New System.Drawing.Point(127, 61)
        Me.TxtCustomerMName.Name = "TxtCustomerMName"
        Me.TxtCustomerMName.Size = New System.Drawing.Size(46, 20)
        Me.TxtCustomerMName.TabIndex = 183
        Me.TxtCustomerMName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCustomerLName
        '
        Me.TxtCustomerLName.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCustomerLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCustomerLName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerLName.Location = New System.Drawing.Point(173, 61)
        Me.TxtCustomerLName.Name = "TxtCustomerLName"
        Me.TxtCustomerLName.Size = New System.Drawing.Size(82, 20)
        Me.TxtCustomerLName.TabIndex = 184
        Me.TxtCustomerLName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbChgUser
        '
        Me.CmbChgUser.DataSource = Me.DsFrmWorkOrders1.ChgUsers
        Me.CmbChgUser.DisplayMember = "UserLogin"
        Me.CmbChgUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbChgUser.Enabled = False
        Me.CmbChgUser.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbChgUser.ItemHeight = 13
        Me.CmbChgUser.Location = New System.Drawing.Point(178, 127)
        Me.CmbChgUser.Name = "CmbChgUser"
        Me.CmbChgUser.Size = New System.Drawing.Size(66, 21)
        Me.CmbChgUser.TabIndex = 187
        Me.CmbChgUser.ValueMember = "UserId"
        '
        'CmbAddUser
        '
        Me.CmbAddUser.DataSource = Me.DsFrmWorkOrders1.AddUsers
        Me.CmbAddUser.DisplayMember = "UserLogin"
        Me.CmbAddUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAddUser.Enabled = False
        Me.CmbAddUser.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbAddUser.ItemHeight = 13
        Me.CmbAddUser.Location = New System.Drawing.Point(71, 126)
        Me.CmbAddUser.Name = "CmbAddUser"
        Me.CmbAddUser.Size = New System.Drawing.Size(66, 21)
        Me.CmbAddUser.TabIndex = 186
        Me.CmbAddUser.ValueMember = "UserId"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Silver
        Me.Label12.Location = New System.Drawing.Point(141, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 22)
        Me.Label12.TabIndex = 190
        Me.Label12.Text = "Cust PO"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Silver
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.Location = New System.Drawing.Point(138, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 22)
        Me.Label11.TabIndex = 189
        Me.Label11.Text = "Changed"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Silver
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 22)
        Me.Label10.TabIndex = 188
        Me.Label10.Text = "Written By"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DaUsers
        '
        Me.DaUsers.SelectCommand = Me.OleDbSelectCommand2
        Me.DaUsers.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Users", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("DefaultStoreNo", "DefaultStoreNo"), New System.Data.Common.DataColumnMapping("DefaultYear", "DefaultYear"), New System.Data.Common.DataColumnMapping("UserActiveFalg", "UserActiveFalg"), New System.Data.Common.DataColumnMapping("UserFamily", "UserFamily"), New System.Data.Common.DataColumnMapping("UserGroupId", "UserGroupId"), New System.Data.Common.DataColumnMapping("UserId", "UserId"), New System.Data.Common.DataColumnMapping("UserLogin", "UserLogin"), New System.Data.Common.DataColumnMapping("UserName", "UserName"), New System.Data.Common.DataColumnMapping("UserPassword", "UserPassword")})})
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT Users.UserId, Users.UserLogin FROM (Users INNER JOIN UserGroup ON Users.Us" & _
        "erGroupId = UserGroup.UserGroupId) WHERE (Users.UserActiveFalg <> 0) AND (UserGr" & _
        "oup.GroupActiveFlag <> 0)"
        Me.OleDbSelectCommand2.Connection = Me.CnnUserMDB
        '
        'CnnUserMDB
        '
        Me.CnnUserMDB.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\TireMate\TireMate.mdb;Persist Sec" & _
        "urity Info=True;Jet OLEDB:Database Password=5332"
        '
        'TxtPo_No
        '
        Me.TxtPo_No.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPo_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPo_No.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPo_No.Location = New System.Drawing.Point(188, 35)
        Me.TxtPo_No.Name = "TxtPo_No"
        Me.TxtPo_No.Size = New System.Drawing.Size(73, 22)
        Me.TxtPo_No.TabIndex = 191
        Me.TxtPo_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(531, 123)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(60, 16)
        Me.Label27.TabIndex = 193
        Me.Label27.Text = "Cashier"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnCashier
        '
        Me.BtnCashier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCashier.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCashier.Image = CType(resources.GetObject("BtnCashier.Image"), System.Drawing.Image)
        Me.BtnCashier.Location = New System.Drawing.Point(592, 117)
        Me.BtnCashier.Name = "BtnCashier"
        Me.BtnCashier.Size = New System.Drawing.Size(33, 27)
        Me.BtnCashier.TabIndex = 192
        '
        'CommentButton_Customer
        '
        Me.CommentButton_Customer.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(207, Byte), CType(104, Byte))
        Me.CommentButton_Customer.Location = New System.Drawing.Point(391, 130)
        Me.CommentButton_Customer.Name = "CommentButton_Customer"
        Me.CommentButton_Customer.Size = New System.Drawing.Size(104, 23)
        Me.CommentButton_Customer.TabIndex = 194
        Me.CommentButton_Customer.TabStop = False
        Me.CommentButton_Customer.ZButtonText = "Cust. Comments"
        Me.CommentButton_Customer.ZCommentFormheight = 0
        Me.CommentButton_Customer.ZCommentFormWidth = 0
        Me.CommentButton_Customer.ZCommentText = ""
        Me.CommentButton_Customer.ZEnabled = True
        Me.CommentButton_Customer.ZMaxCommentLength = 200
        Me.CommentButton_Customer.ZShowInLeft = False
        Me.CommentButton_Customer.ZShowInTop = False
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Location = New System.Drawing.Point(397, 89)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 10)
        Me.Label29.TabIndex = 196
        Me.Label29.Text = "Print"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label29.Visible = False
        '
        'BtnPrint
        '
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.Location = New System.Drawing.Point(397, 60)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(33, 27)
        Me.BtnPrint.TabIndex = 195
        Me.BtnPrint.Visible = False
        '
        'FrmShowWorkOrder
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(647, 449)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.CommentButton_Customer)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.BtnCashier)
        Me.Controls.Add(Me.TxtPo_No)
        Me.Controls.Add(Me.CmbChgUser)
        Me.Controls.Add(Me.CmbAddUser)
        Me.Controls.Add(Me.GrdDetail)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtCustomerLName)
        Me.Controls.Add(Me.TxtCustomerMName)
        Me.Controls.Add(Me.TxtCustomerFName)
        Me.Controls.Add(Me.TxtCustomerCod)
        Me.Controls.Add(Me.TxtLicenceNo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.LblCustomerCompanyname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.NumCurrent_mileage)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.LblVehicleYear)
        Me.Controls.Add(Me.LblVehicleVin)
        Me.Controls.Add(Me.LblVehicleModel)
        Me.Controls.Add(Me.LblVehicleMake)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FrmShowWorkOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Service Record"
        CType(Me.DsFrmWorkOrders1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmWorkOrders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString
        CnnReader.ConnectionString = PConnectionString

        CnnUserMDB.ConnectionString = PConnectionStringForUserMdb

        MyZipCode = New UCZipCode.ClsZipCode
        MyZipCode.Connection = Me.Cnn

        CommentButton_Customer.ZEnabled = False

        DsFrmWorkOrders1.service_center_dtl.Columns("PricePlusFet").Expression = "Price + Fet"
        DsFrmWorkOrders1.service_center_dtl.Columns("Ext_Price").Expression = "PricePlusFet * Qty"

        DsFrmWorkOrders1.employee.Clear()
        DAEmployee.Fill(DsFrmWorkOrders1.employee)

        DsFrmWorkOrders1.AddUsers.Clear()
        DaUsers.Fill(DsFrmWorkOrders1.AddUsers)
        DsFrmWorkOrders1.AddUsers.AddAddUsersRow("", 0)
        DsFrmWorkOrders1.ChgUsers.Clear()
        DaUsers.Fill(DsFrmWorkOrders1.ChgUsers)
        DsFrmWorkOrders1.ChgUsers.AddChgUsersRow("", 0)

        Call FillTechnicianCombo()
        Call FillServiceKindCombo()

        LblCompanyName.Text = PubCompanyName
        LblStoreNo.Text = PubStoreName

        CmbType.SelectedValue = TypeOfForm
        LblType.Text = CmbType.SelectedItem.Value
        TxtDate.Text = Format(Now.Date, PubDateFormat)

        Call LoadAWotkOrder(TxtRef.Text)
        'Call EnableDisableField(False)

        ThisFormStatus = MainModule.WorkStates._ReadOnly

    End Sub
    Private Sub FillServiceKindCombo()
        Dim dr As DataRow
        dr = DsFrmWorkOrders1.Type_select.NewRow
        dr("Code") = " "
        dr("Desc") = " "
        DsFrmWorkOrders1.Type_select.Rows.Add(dr)
        Dim i As Double
        For i = 0 To TypeOfWorkOrderItemCount - 1
            dr = DsFrmWorkOrders1.Type_select.NewRow
            dr("Code") = TypeOfWorkOrderItem(i)
            dr("Desc") = DescOfWorkOrderItem(i)
            DsFrmWorkOrders1.Type_select.Rows.Add(dr)
        Next
        GrdDetail.DropDowns("DropDownTypeSelect").SetDataBinding(DsFrmWorkOrders1, "Type_select")
    End Sub
    Private Sub FillTechnicianCombo()
        GrdDetail.DropDowns("DropDownTechnician").SetDataBinding(DsFrmWorkOrders1, "Employee")
    End Sub
    'Private Sub EnableDisableField(ByVal InStatus As Boolean)
    '    GrdDetail.Enabled = InStatus
    'End Sub
    Private Sub LoadAWotkOrder(ByVal ThisRefNo As String)
        DsFrmWorkOrders1.service_center_head.Clear()
        DsFrmWorkOrders1.service_center_dtl.Clear()
        DAService_Center_Head.SelectCommand.Parameters("@id_service_center").Value = ThisRefNo
        DAService_Center_Head.Fill(DsFrmWorkOrders1.service_center_head)
        Try
            DAService_Center_Dtl.SelectCommand.Parameters("@id_service_center").Value = ThisRefNo
            DAService_Center_Dtl.Fill(DsFrmWorkOrders1.service_center_dtl)
        Catch ex As Exception
            MsgBox("Error in loading Service Information,try again or call to your vendor")
        End Try
        DsFrmWorkOrders1.service_out_purchases.Clear()
        Try
            DAservice_out_purchases.SelectCommand.Parameters("@id_service_center").Value = ThisRefNo
            DAservice_out_purchases.Fill(DsFrmWorkOrders1.service_out_purchases)
        Catch ex As Exception
            MsgBox("Error in loading out purchases Information,try again or call to your vendor")
        End Try
        DsFrmWorkOrders1.service_tire_adjustment.Clear()
        Try
            DAService_tire_adjustment.SelectCommand.Parameters("@id_service_center").Value = ThisRefNo
            DAService_tire_adjustment.Fill(DsFrmWorkOrders1.service_tire_adjustment)
        Catch ex As Exception
            MsgBox("Error in loading out Tire Adjustment Information,try again or call to your vendor")
        End Try
        Call ClearAllField()
        Call FillDataInScreen()
        Call CalcSumOfExt_price(False)
    End Sub
    Private Sub ClearAllField()
        NumCurrent_mileage.Text = 0
        TxtCustomerCod.Text = ""
        TxtLicenceNo.Text = ""
        TxtCustomerFName.Text = ""
        TxtCustomerMName.Text = ""
        TxtCustomerLName.Text = ""
        'TxtPo_No.Clear()
        TxtDate.Text = Format(Now.Date, PubDateFormat)
        NumDiscount.Text = 0
        NumTax.Text = 0
        TxtRef.Clear()
        LblCustomerCompanyname.Text = ""
        'CmbChgUser.SelectedValue = 0
        LblFees.Text = 0
        LblFET.Text = 0
        LblLabor.Text = 0
        LblParts.Text = 0
        LblSubtotal.Text = 0
        LblTotal.Text = 0
        LblVehicleMake.Text = ""
        LblVehicleModel.Text = ""
        LblVehicleVin.Text = ""
        LblVehicleYear.Text = ""
        CmbAddUser.SelectedValue = 0
        CmbChgUser.SelectedValue = 0
        'CommentButton_Customer.ZCommentText = ""
        'CommentButton_House.ZCommentText = ""
        'PhoneNoMain.Text = ""
        'Call PhoneButton1.ClearPhoneScreen()
    End Sub
    Private Sub FillDataInScreen()
        With DsFrmWorkOrders1.service_center_head
            If .Rows.Count > 0 Then
                CmbType.SelectedValue = .Rows(0).Item("type_of_form") & ""
                CommentButton_Customer.ZCommentText = .Rows(0).Item("cust_comment") & ""

                NumCurrent_mileage.Text = IIf(IsDBNull(.Rows(0).Item("Current_mileage")), 0, .Rows(0).Item("Current_mileage"))
                TxtCustomerCod.Text = .Rows(0).Item("cod_customer") & ""

                Dim SQLReader As System.Data.SqlClient.SqlDataReader
                If CmdReader.Connection.State <> ConnectionState.Open Then
                    CmdReader.Connection.Open()
                End If
                CmdReader.CommandText = "SELECT     cust_trtab_main.f_name, cust_trtab_main.m_name, cust_trtab_main.l_name, cust_company.abbreviation_name FROM         cust_trtab_main LEFT OUTER JOIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_company where cust_trtab_main.cod_customer=" & Qt(TxtCustomerCod.Text)
                SQLReader = CmdReader.ExecuteReader
                If SQLReader.HasRows Then
                    SQLReader.Read()
                    TxtCustomerFName.Text = SQLReader.Item("f_name") & ""
                    TxtCustomerMName.Text = SQLReader.Item("m_name") & ""
                    TxtCustomerLName.Text = SQLReader.Item("l_name") & ""
                    LblCustomerCompanyname.Text = SQLReader.Item("abbreviation_name") & ""
                Else
                    TxtCustomerFName.Text = ""
                    TxtCustomerMName.Text = ""
                    TxtCustomerLName.Text = ""
                    LblCustomerCompanyname.Text = ""
                End If
                SQLReader.Close()

                'TxtPo_No.Text = .Rows(0).Item("Po_No") & ""
                CmdReader.CommandText = "SELECT ser_tr_vehicle.license_no_vehicle, ser_tr_vehicle.cod_vehicle, ser_tr_vehicle.cod_kind_engine, ser_tr_vehicle.cod_color, ser_tr_vehicle.unit_no, " _
                                      & " bas_vehicle.Options as cod_vehicle_type, bas_vehicle.cod_make, bas_vehicle.cod_model, ser_tr_vehicle.vin, bas_vehicle.make_year, " _
                                      & " bas_vehicle_model.desc_model, bas_vehicle_company.desc_make, ser_tr_vehicle.cod_customer " _
                                      & " FROM  ser_tr_vehicle LEFT OUTER JOIN " _
                                      & " bas_vehicle_model INNER JOIN " _
                                      & " bas_vehicle ON bas_vehicle_model.cod_make = bas_vehicle.cod_make AND bas_vehicle_model.cod_model = bas_vehicle.cod_model INNER JOIN " _
                                      & " bas_vehicle_company ON bas_vehicle_model.cod_make = bas_vehicle_company.cod_make ON ser_tr_vehicle.cod_vehicle = bas_vehicle.cod_vehicle " _
                                      & " Where ser_tr_vehicle.id_vehicle = " & Qt(.Rows(0).Item("id_vehicle") & "")

                SQLReader = CmdReader.ExecuteReader
                If SQLReader.HasRows Then
                    SQLReader.Read()
                    TxtLicenceNo.Text = SQLReader.Item("license_no_vehicle") & ""
                    LblVehicleMake.Text = SQLReader.Item("desc_make") & ""
                    LblVehicleModel.Text = SQLReader.Item("desc_model") & ""
                    LblVehicleVin.Text = SQLReader.Item("Vin") & ""
                    LblVehicleYear.Text = SQLReader.Item("make_year") & ""
                Else
                    TxtLicenceNo.Text = ""
                    LblVehicleModel.Text = ""
                    LblVehicleVin.Text = ""
                    LblVehicleYear.Text = ""
                    LblVehicleMake.Text = ""
                End If

                TxtDate.Text = .Rows(0).Item("date_refer") & ""
                NumDiscount.Text = .Rows(0).Item("discount")
                LblTotal.Text = .Rows(0).Item("Total")
                NumTax.Text = .Rows(0).Item("Tax")
                TxtPo_No.Text = .Rows(0).Item("Po_No") & ""

                Try
                    CmbAddUser.SelectedValue = .Rows(0).Item("add_user")
                Catch ex As Exception
                    CmbAddUser.SelectedValue = 0
                End Try
                Try
                    CmbChgUser.SelectedValue = .Rows(0).Item("Chg_user")
                Catch ex As Exception
                    CmbChgUser.SelectedValue = 0
                End Try

                TxtRef.Text = .Rows(0).Item("id_service_center") & ""
                LblCustomerCompanyname.Text = .Rows(0).Item("complete_name") & ""

                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                CmdGeneral.CommandText = "Select current_mileage from ser_tr_vehicle_dtl where id_service_center=" & Qt(TxtRef.Text)
                Try
                    NumCurrent_mileage.Text = CmdGeneral.ExecuteScalar()
                Catch ex As Exception
                    NumCurrent_mileage.Text = 0
                End Try

                LblFees.Text = 0
                LblFET.Text = 0
                LblLabor.Text = 0
                LblParts.Text = 0
                LblSubtotal.Text = 0
                CmbType.SelectedValue = .Rows(0).Item("type_of_form") & ""
                'CommentButton_Customer.ZCommentText = .Rows(0).Item("cust_comment") & ""
                'CommentButton_House.ZCommentText = .Rows(0).Item("house_comment") & ""
            End If
            'PhoneButton1.FillDataSet("cust_trtab_main", "cod_customer=" & Qt(CustomerCod1.Text))
            'PhoneButton1.HeaderName = CustomerCod1.CustomerDesc.Trim
            'PhoneNoMain.Text = PhoneButton1.FillPhoneNoMain()
        End With
    End Sub
    Private Sub CalcSumOfExt_price(Optional ByVal FlagForCalcTax As Boolean = True)
        LblParts.Text = 0
        Dim TaxablePrice As Double = 0
        Dim TaxPercent As Double = 0

        LblParts.Text = 0
        LblFET.Text = 0
        LblLabor.Text = 0
        LblFees.Text = 0
        LblSubtotal.Text = 0

        Dim i As Double
        For i = 0 To DsFrmWorkOrders1.service_center_dtl.Rows.Count - 1
            If DsFrmWorkOrders1.service_center_dtl.Rows(i).RowState <> DataRowState.Deleted Then
                Select Case DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("type_select")
                    Case "I", "O", "A", "T"
                        LblParts.Text = LblParts.Numbervalue + (DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("qty") * DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("Price")) + (DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("qty") * DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("Fet"))
                        LblFET.Text = LblFET.Numbervalue + (DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("qty") * DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("Fet"))
                    Case "L"
                        LblLabor.Text = LblLabor.Numbervalue + (DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("qty") * DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("Price"))
                    Case "F", "S"
                        LblFees.Text = LblFees.Numbervalue + (DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("qty") * DsFrmWorkOrders1.service_center_dtl.Rows(i).Item("Price"))
                End Select
                LblSubtotal.Text = LblParts.Numbervalue + LblLabor.Numbervalue + LblFees.Numbervalue
                Try
                    TaxablePrice = DsFrmWorkOrders1.service_center_dtl.Compute("sum(Ext_Price)", "taxable=1")
                Catch ex As Exception
                    TaxablePrice = 0
                End Try
            End If
        Next
    End Sub
    Private Sub CmbType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbType.SelectedIndexChanged
        LblType.Text = CmbType.SelectedItem.Value
    End Sub
    Private Sub BtnCashier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCashier.Click
        If CmbType.Text = "RT" Then
            If TxtRef.Text.Trim.Length = 0 Then
                Exit Sub
            End If
            CmdGeneral.CommandText = "Select id_service_center_before from service_center_head where id_service_center=" & Qt(TxtRef.Text)
            If CmdGeneral.Connection.State <> ConnectionState.Open Then
                CmdGeneral.Connection.Open()
            End If
            Try
                InvoiceNoForReturnVar = CmdGeneral.ExecuteScalar & ""
            Catch ex As Exception
                InvoiceNoForReturnVar = ""
            End Try

            Dim FrmCashierForReturn As New FrmCashierForReturn
            FrmCashierForReturn.TxtRefvar = TxtRef.Text
            FrmCashierForReturn.Datevar = TxtDate.Text
            FrmCashierForReturn.CustomerCodvar = TxtCustomerCod.Text
            FrmCashierForReturn.ThisFormStatus = ThisFormStatus
            FrmCashierForReturn.InvoiceNoForReturnVar = InvoiceNoForReturnVar & ""
            FrmCashierForReturn.TotalAmountOfReturnVar = LblTotal.Text
            FrmCashierForReturn.ShowDialog()
        Else
            If TxtRef.Text.Trim.Length = 0 Then
                Exit Sub
            End If
            Dim MyFrmCashier As New FrmCashier
            MyFrmCashier.TxtRef.Text = TxtRef.Text
            MyFrmCashier.TxtDate.Text = TxtDate.Text
            MyFrmCashier.NumAmount.Text = LblTotal.Text
            MyFrmCashier.CustomerCodeVar = TxtCustomerCod.Text
            MyFrmCashier.ThisFormStatus = ThisFormStatus
            MyFrmCashier.ShowDialog()
        End If
    End Sub
    Private Sub ShowOutsidePurchase()
        Dim CurrentRow As GridEXRow = GrdDetail.GetRow()
        Dim MYFrmOutsidePurchase As New FrmOutsidePurchase
        MYFrmOutsidePurchase.ThisFormStatus = MainModule.WorkStates._ReadOnly

        Dim dr As DataRow
        dr = DsFrmWorkOrders1.service_out_purchases.FindByradif(CurrentRow.Cells("radif").Value)
        MYFrmOutsidePurchase.TypeOfForm = CmbType.Text
        If Not IsNothing(dr) Then
            MYFrmOutsidePurchase.Txtpart_no.Text = dr("part_no") & ""
            MYFrmOutsidePurchase.TxtDescription.Text = dr("Description") & ""
            MYFrmOutsidePurchase.NumCost.Text = dr("Cost")
            MYFrmOutsidePurchase.NumFet.Text = dr("Fet")
            MYFrmOutsidePurchase.NumMarkup.Text = dr("Markup")
            MYFrmOutsidePurchase.NumPrice.Text = dr("Price")
            MYFrmOutsidePurchase.TxtVendorCod.Text = dr("cod_vendor") & ""
            MYFrmOutsidePurchase.Txtpo_no.Text = dr("po_no") & ""
            MYFrmOutsidePurchase.LineVar = dr("Line") & ""
            MYFrmOutsidePurchase.ApTermVar = dr("AR_terms") & ""
            MYFrmOutsidePurchase.Txtinvoice_no.Text = dr("invoice_no") & ""
            MYFrmOutsidePurchase.Dtedue_date.Text = dr("due_date") & ""
            MYFrmOutsidePurchase.Dteinvoice_date.Text = dr("invoice_date") & ""
            MYFrmOutsidePurchase.Chktracking_warranty.Checked = dr("tracking_warranty")
            MYFrmOutsidePurchase.Numin_day.Text = dr("in_day")
            MYFrmOutsidePurchase.Numin_mile.Text = dr("in_mile")
            MYFrmOutsidePurchase.Chktracking_core.Checked = dr("tracking_core")
            MYFrmOutsidePurchase.Numcore_value.Text = dr("core_value")
            Try
                MYFrmOutsidePurchase.ChkPrepaid.Checked = dr("PaidFlag")
            Catch ex As Exception
                MYFrmOutsidePurchase.ChkPrepaid.Checked = False
            End Try
        End If
        MYFrmOutsidePurchase.ShowDialog()
    End Sub
    Private Sub GrdDetail_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GrdDetail.ColumnButtonClick
        Dim ThisRowGrid As GridEXRow = GrdDetail.GetRow
        Select Case e.Column.Key.ToUpper
            'Case "HST"
            '    MsgBox("Item Sales History Screen For Row : " & e.Column.GridEX.Row())
            'Case "CM"
            '    MyFrmItemComments = New CommonClass.FrmItemComments
            '    MyFrmItemComments.TxtComments.Text = DsFrmWorkOrders1.service_center_dtl.Rows(e.Column.GridEX.Row()).Item("COMMENT_ARTICLE") & ""

            '    Dim PntForm As Point
            '    Dim PntLocation As Point
            '    Dim OControl As Control
            '    Dim SizeForm As Size
            '    OControl = GrdDetail

            '    SizeForm.Width = MyFrmItemComments.Width
            '    SizeForm.Height = MyFrmItemComments.Height
            '    PntLocation.X = OControl.Location.X '+ oControl.Size.Width - sizeForm.Width
            '    PntLocation.Y = OControl.Location.Y + OControl.Size.Height + 2 + ((e.Column.GridEX.Row() + 2) * GrdDetail.RootTable.RowHeight) - OControl.Size.Height - 1


            '    PntForm = OControl.Parent.PointToScreen(PntLocation)
            '    If PntForm.Y + SizeForm.Height > Screen.PrimaryScreen.Bounds.Height - 40 Then
            '        PntForm.Y = PntForm.Y - SizeForm.Height - GrdDetail.RootTable.RowHeight
            '    End If
            '    If (PntForm.X < 0) Then PntForm.X = 0
            '    MyFrmItemComments.SetDesktopLocation(PntForm.X, PntForm.Y)
            '    MyFrmItemComments.Left = PntForm.X
            '    MyFrmItemComments.Top = PntForm.Y
            '    MyFrmItemComments.ThisFormStatus = ThisFormStatus
            '    MyFrmItemComments.ShowDialog()
            '    If MyFrmItemComments.ThisFormStatus <> MainModule.WorkStates._ReadOnly Then
            '        DsFrmWorkOrders1.service_center_dtl.Rows(e.Column.GridEX.Row()).Item("COMMENT_ARTICLE") = MyFrmItemComments.TxtCommentvar
            '    End If
        Case "DET"
                Select Case ThisRowGrid.Cells(0).Value
                    'Case "I"
                    '    If Trim(ThisRowGrid.Cells(4).Value).Length > 0 Then
                    '        Dim MyFrmItemProduct As New UCInv_Item.FrmItemProduct
                    '        MyFrmItemProduct.StartPosition = FormStartPosition.CenterScreen
                    '        MyFrmItemProduct.ThisFormStatus = MainModule.WorkStates._ReadOnly
                    '        MyFrmItemProduct.Item_noTempVar = ThisRowGrid.Cells(4).Value
                    '        MyFrmItemProduct.ShowDialog()
                    '    End If
                    'Case "A"
                    '    'If Trim(ThisRowGrid.Cells(4).Value).Length > 0 Then
                    '    Call ShowTireAdjustment()
                    '    'End If
                Case "O"
                        Call ShowOutsidePurchase()
                End Select
        End Select
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        '''Call pprint("print", CmbType.Text, TxtRef.Text, False, True)
    End Sub
    'Private Sub pprint(ByVal PrintType As String, ByVal ServiceCenterType As String, ByVal ThisTxtRef As String, Optional ByVal ForcePrint As Boolean = False, Optional ByVal OnePrintFlag As Boolean = False)

    '    If ThisTxtRef.Trim.Length = 0 Then
    '        ThisTxtRef = TxtRef.Text
    '    End If

    '    Dim SQLReader As System.Data.SqlClient.SqlDataReader
    '    Dim PreviousMileageVar As String = ""
    '    Try
    '        If CmdReader.Connection.State <> ConnectionState.Open Then
    '            CmdReader.Connection.Open()
    '        End If
    '        CmdReader.CommandText = "SELECT ser_tr_vehicle_dtl.current_mileage, service_center_head.date_refer " _
    '                      & " FROM ser_tr_vehicle INNER JOIN " _
    '                      & " bas_vehicle ON ser_tr_vehicle.cod_vehicle = bas_vehicle.cod_vehicle INNER JOIN " _
    '                      & " service_center_head ON ser_tr_vehicle.id_vehicle = service_center_head.id_vehicle INNER JOIN " _
    '                      & " ser_tr_vehicle_dtl ON service_center_head.id_service_center = ser_tr_vehicle_dtl.id_service_center " _
    '                      & " Where license_no_vehicle=" & Qt(TxtLicenceNo.Text) & " Order By service_center_head.date_refer Desc"
    '        SQLReader = CmdReader.ExecuteReader
    '        If SQLReader.HasRows Then
    '            SQLReader.Read()
    '            If SQLReader.Read Then
    '                PreviousMileageVar = SQLReader.Item("current_mileage")
    '            End If
    '        End If
    '    Catch ex As Exception
    '    Finally
    '        SQLReader.Close()
    '        'CmdReader.Connection.Close()
    '    End Try

    '    Dim rpt As New RepWorkOrder
    '    Dim prn As New FrmRepView

    '    Dim OleDbReaderForStore As System.Data.OleDb.OleDbDataReader
    '    OleDbReaderForStore = RetrieveStoreSetupTable(PubStoreNO)

    '    If DsFrmWorkOrders1.TempTable.Rows.Count = 0 Then
    '        DsFrmWorkOrders1.TempTable.Clear()
    '        Select Case ServiceCenterType
    '            Case "ES"
    '                DsFrmWorkOrders1.TempTable.AddTempTableRow(OleDbReaderForStore.Item("WARRANTY_FOR_ES") & "")
    '            Case "WO"
    '                DsFrmWorkOrders1.TempTable.AddTempTableRow(OleDbReaderForStore.Item("DISCLAIMER_FOR_WO") & "")
    '            Case "IN"
    '                DsFrmWorkOrders1.TempTable.AddTempTableRow(OleDbReaderForStore.Item("WARRANTY_FOR_IN") & "")
    '            Case Else
    '                DsFrmWorkOrders1.TempTable.AddTempTableRow("")
    '        End Select
    '    End If

    '    rpt.SetParameterValue("ParStoreShortName", PubStoreName & "")

    '    rpt.SetParameterValue("Parconame", OleDbReaderForStore.Item("STORENAME") & "")
    '    rpt.SetParameterValue("Parcoaddress", OleDbReaderForStore.Item("ADDRESS") & "")

    '    MyZipCode.ZipCode = OleDbReaderForStore.Item("ZipCode")
    '    MyZipCode.FindDesc(OleDbReaderForStore.Item("ZipCode"))
    '    rpt.SetParameterValue("Parcoaddress2", MyZipCode.City & " " & MyZipCode.State & " " & MyZipCode.ZipCode & "")

    '    rpt.SetParameterValue("Parcophone", OleDbReaderForStore.Item("PHONE") & "")
    '    rpt.SetParameterValue("Parcofax", OleDbReaderForStore.Item("FAX") & "")
    '    rpt.SetParameterValue("Parcoemail", OleDbReaderForStore.Item("EMAIL") & "")

    '    DsFrmWorkOrders1.LOGO.Clear()
    '    Dim OleDbReaderForCompany As System.Data.OleDb.OleDbDataReader
    '    OleDbReaderForCompany = RetrieveCompanySetupTable()
    '    Try
    '        DsFrmWorkOrders1.LOGO.AddLOGORow(OleDbReaderForCompany.Item("LOGO"), "l")
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    rpt.SetParameterValue("Parcowebsite", OleDbReaderForCompany.Item("WEBPAGE"))


    '    Dim CustomerCod1ZipCode As String = ""
    '    Dim CustomerCod1CustomerDesc As String = ""
    '    Dim CustomerCod1Address As String = ""
    '    Dim CustomerCod1CustomerPhone As String = ""
    '    Try
    '        If CmdReader.Connection.State <> ConnectionState.Open Then
    '            CmdReader.Connection.Open()
    '        End If
    '        CmdReader.CommandText = "SELECT     cust_trtab_main.*, cust_company.abbreviation_name, cust_company.complete_name, GL_TAB_AR_TERM.KIND_AR,GL_TAB_AR_TERM.ST_NET_DUE_IN, GL_TAB_AR_TERM.ST_DISCOUNT_PERCENTAGE, cust_sales_tax.Amount,GL_TAB_AR_TERM.ST_IF_PAY_WITHIN_DAYS, GL_TAB_AR_TERM.DD_NET_DUE_BEFORE, GL_TAB_AR_TERM.DD_IF_ISSUED_WITHIN_DAYS,GL_TAB_AR_TERM.DD_DISCOUNT_PERCENTAGE, GL_TAB_AR_TERM.DD_IF_PAY_WITHIN_DAYS, GL_TAB_AR_TERM.MP_NO_OF_PAYMENT, GL_TAB_AR_TERM.MP_BEFORE_DAY " _
    '                              & " FROM cust_trtab_main " _
    '                              & " LEFT OUTER JOIN cust_sales_tax ON cust_trtab_main.cod_sales_tax = cust_sales_tax.cod_sales_tax " _
    '                              & " LEFT OUTER JOIN GL_TAB_AR_TERM ON cust_trtab_main.AR_term = GL_TAB_AR_TERM.AR_terms " _
    '                              & " LEFT OUTER JOIN cust_company ON cust_trtab_main.cod_company = cust_company.cod_company " _
    '                              & " Where cust_trtab_main.cod_customer = " & Qt(TxtCustomerCod.Text)
    '        SQLReader = CmdReader.ExecuteReader
    '        If SQLReader.HasRows Then
    '            SQLReader.Read()
    '            If SQLReader.Read Then
    '                CustomerCod1ZipCode = SQLReader.Item("ZIP")
    '                If Trim(SQLReader.Item("complete_name") & "").Length > 0 Then
    '                    CustomerCod1CustomerDesc = SQLReader.Item("complete_name") & ""
    '                Else
    '                    CustomerCod1CustomerDesc = SQLReader.Item("F_name") & " " & SQLReader.Item("M_name") & " " & SQLReader.Item("L_name") & ""
    '                End If
    '                CustomerCod1Address = SQLReader.Item("Address")
    '                CustomerCod1CustomerPhone = SQLReader.Item("phone_1")
    '            End If
    '        End If
    '    Catch ex As Exception
    '    Finally
    '        SQLReader.Close()
    '    End Try


    '    Dim VehicleColorVar As String = ""
    '    Dim UnitNoVar As String = ""
    '    Dim Desc_kind_engineVar As String = ""

    '    Try
    '        If CmdReader.Connection.State <> ConnectionState.Open Then
    '            CmdReader.Connection.Open()
    '        End If
    '        CmdReader.CommandText = "SELECT ser_tr_vehicle.id_vehicle, ser_tr_vehicle.license_no_vehicle, ser_tr_vehicle.cod_customer, ser_tr_vehicle.cod_vehicle, " _
    '                      & " ser_tr_vehicle.cod_kind_engine, ser_tr_vehicle.cod_color, ser_tr_vehicle.unit_no, bas_vehicle.Options as cod_vehicle_type, " _
    '                      & " ser_tr_vehicle.engin_designatoin_code, ser_tr_vehicle.engine_vin, ser_tr_vehicle.aa_id, bas_vehicle.cod_make, bas_vehicle.cod_model, " _
    '                      & " ser_tr_vehicle.creat_date, ser_tr_vehicle.change_date, ser_tr_vehicle.salvage_date, " _
    '                      & " ser_tr_vehicle.vehicle_active, ser_tr_vehicle.vehicle_out_service, ser_tr_vehicle.Cod_quarts, ser_tr_vehicle.cod_oil_type, ser_tr_vehicle.State, ser_tr_vehicle.Notes, " _
    '                      & " ser_tr_vehicle.vin, bas_vehicle.make_year " _
    '                      & " FROM ser_tr_vehicle LEFT OUTER JOIN " _
    '                      & " bas_vehicle ON ser_tr_vehicle.cod_vehicle = bas_vehicle.cod_vehicle where ser_tr_vehicle.id_vehicle = " & License_No1.FieldCodValue 'license_no_vehicle= " & Qt(Thislicense_no_vehicle) & " and
    '        SQLReader = CmdReader.ExecuteReader
    '        If SQLReader.HasRows Then
    '            SQLReader.Read()
    '            If SQLReader.Read Then
    '                VehicleColorVar = SQLReader.Item("desc_color") & ""
    '                UnitNoVar = SQLReader.Item("Unit_No") & ""
    '                Desc_kind_engineVar = SQLReader.Item("desc_kind_engine") & ""
    '            End If
    '        End If
    '    Catch ex As Exception
    '    Finally
    '        SQLReader.Close()
    '    End Try




    '    MyZipCode.ZipCode = CustomerCod1ZipCode
    '    MyZipCode.FindDesc(CustomerCod1ZipCode)

    '    rpt.SetParameterValue("ParCusName", CustomerCod1CustomerDesc)
    '    rpt.SetParameterValue("ParCusAddress", CustomerCod1Address)
    '    rpt.SetParameterValue("Parcusaddress2", MyZipCode.City & " " & MyZipCode.State & " " & MyZipCode.ZipCode & "")
    '    rpt.SetParameterValue("ParCusPhone", CustomerCod1CustomerPhone)
    '    rpt.SetParameterValue("ParVeMake", LblVehicleMake.Text)
    '    rpt.SetParameterValue("ParVeModel", LblVehicleModel.Text)
    '    rpt.SetParameterValue("ParVeYear", LblVehicleYear.Text)
    '    rpt.SetParameterValue("ParVeVIN", LblVehicleVin.Text)
    '    rpt.SetParameterValue("ParVecolor", VehicleColorVar & "")
    '    rpt.SetParameterValue("ParVeengine", Desc_kind_engineVar & "")
    '    rpt.SetParameterValue("ParVepremile", PreviousMileageVar & "")
    '    rpt.SetParameterValue("ParVeunit", UnitNoVar & "")
    '    rpt.SetParameterValue("ParVelicense", TxtLicenceNo.Text)

    '    rpt.SetParameterValue("ParVeCurMile", NumCurrent_mileage.Text)
    '    rpt.SetParameterValue("Parwritten", CmbAddUser.Text)
    '    rpt.SetParameterValue("Parchanged", CmbChgUser.Text)
    '    rpt.SetParameterValue("Parsumparts", LblParts.Text)
    '    rpt.SetParameterValue("Parsumfet", LblFET.Text)
    '    rpt.SetParameterValue("Parsumlabor", LblLabor.Text)
    '    rpt.SetParameterValue("Parsumfees", LblFees.Text)
    '    rpt.SetParameterValue("Parsumsubtotal", LblSubtotal.Text)
    '    rpt.SetParameterValue("Parsumdiscount", NumDiscount.Text)
    '    rpt.SetParameterValue("Parsumtax", NumTax.Text)
    '    rpt.SetParameterValue("Parsumtotal", LblTotal.Text)
    '    rpt.SetParameterValue("Partype", ServiceCenterType & "")

    '    rpt.SetParameterValue("parcusno", TxtCustomerCod.Text)


    '    If CmdGeneral.Connection.State <> ConnectionState.Open Then
    '        CmdGeneral.Connection.Open()
    '    End If
    '    Dim ThisDateTempVar As String
    '    CmdGeneral.CommandText = "Select date_refer from service_center_head where id_service_center=" & Qt(ThisTxtRef)
    '    ThisDateTempVar = CmdGeneral.ExecuteScalar & ""

    '    rpt.SetParameterValue("pardate", ThisDateTempVar)
    '    rpt.SetParameterValue("partime", Format(TimeOfDay, "Short Time"))

    '    rpt.SetParameterValue("parno", ThisTxtRef)

    '    rpt.SetParameterValue("parincash", 0)
    '    rpt.SetParameterValue("parincheck", 0)
    '    rpt.SetParameterValue("parincheckno", "")
    '    rpt.SetParameterValue("parincrcard", 0)
    '    rpt.SetParameterValue("parincctype", "")
    '    rpt.SetParameterValue("parinauthcode", "")
    '    rpt.SetParameterValue("parinonacount", 0)
    '    rpt.SetParameterValue("parinterms", "")
    '    rpt.SetParameterValue("parinduedate", "")

    '    DAGL_payment_deposit.SelectCommand.Parameters("@id_service_center").Value = ThisTxtRef
    '    DsFrmCashier1.GL_payment_deposit.Clear()
    '    DAGL_payment_deposit.Fill(DsFrmCashier1, "GL_payment_deposit")
    '    If DsFrmCashier1.GL_payment_deposit.Rows.Count > 0 Then
    '        Dim i As Integer
    '        For i = 0 To DsFrmCashier1.GL_payment_deposit.Rows.Count - 1
    '            Select Case DsFrmCashier1.GL_payment_deposit.Rows(i).Item("payment_type") & ""
    '                Case "1" 'cash
    '                    rpt.SetParameterValue("parincash", IIf(DsFrmCashier1.GL_payment_deposit.Rows(i).Item("cash_rendered") Is DBNull.Value, 0, DsFrmCashier1.GL_payment_deposit.Rows(i).Item("cash_rendered")))
    '                Case "2" 'check

    '                    rpt.SetParameterValue("parincheck", IIf(DsFrmCashier1.GL_payment_deposit.Rows(i).Item("payment_amount") Is DBNull.Value, 0, DsFrmCashier1.GL_payment_deposit.Rows(i).Item("payment_amount")))
    '                    rpt.SetParameterValue("parincheckno", DsFrmCashier1.GL_payment_deposit.Rows(i).Item("check_no") & "")
    '                Case "3" 'credit
    '                    rpt.SetParameterValue("parincrcard", IIf(DsFrmCashier1.GL_payment_deposit.Rows(i).Item("payment_amount") Is DBNull.Value, 0, DsFrmCashier1.GL_payment_deposit.Rows(i).Item("payment_amount")))
    '                    rpt.SetParameterValue("parincctype", DsFrmCashier1.GL_payment_deposit.Rows(i).Item("cc_type") & "") ''''''''''''
    '                    rpt.SetParameterValue("parinauthcode", DsFrmCashier1.GL_payment_deposit.Rows(i).Item("cc_auth_no") & "")
    '                Case "4" 'AR
    '                    rpt.SetParameterValue("parinonacount", DsFrmCashier1.GL_payment_deposit.Rows(i).Item("payment_amount") & "")

    '                    Try
    '                        rpt.SetParameterValue("parinterms", DsFrmCashier1.GL_payment_deposit.Rows(i).Item("AR_terms") & "")   '''''''''''''
    '                    Catch ex As Exception
    '                        rpt.SetParameterValue("parinterms", "")  '''''''''''''
    '                    End Try


    '                    'rpt.SetParameterValue("parinterms", DsFrmCashier1.GL_payment_deposit.Rows(i).Item("AR_terms") & "")  '''''''''''''
    '                    rpt.SetParameterValue("parinduedate", DsFrmCashier1.GL_payment_deposit.Rows(i).Item("AR_due_date") & "")
    '            End Select
    '        Next
    '    End If

    '    Select Case ServiceCenterType
    '        Case "WO"
    '            rpt.SetParameterValue("parnoh", "WORK ORDER NO")
    '            rpt.SetParameterValue("ParKindRep", "WORK ORDER")
    '            rpt.SetParameterValue("ParwkStnod", FindEstimateNo(ThisTxtRef))
    '            rpt.SetParameterValue("parcomments", CommentButton_House.ZCommentText)
    '        Case "ES"
    '            rpt.SetParameterValue("parnoh", "ESTIMATE NO")
    '            rpt.SetParameterValue("ParwkStnod", "")
    '            rpt.SetParameterValue("parcomments", "")
    '            rpt.SetParameterValue("ParKindRep", "ESTIMATE")
    '        Case "IN"
    '            rpt.SetParameterValue("parnoh", "INVOICE NO")
    '            rpt.SetParameterValue("ParwkStnod", FindEstimateNo(ThisTxtRef))
    '            Try
    '                rpt.SetParameterValue("parcomments", CommentButton_Customer.ZCommentText)
    '            Catch ex As Exception
    '                rpt.SetParameterValue("parcomments", "")
    '            End Try
    '            rpt.SetParameterValue("ParKindRep", "INVOICE")
    '        Case "RT"
    '            rpt.SetParameterValue("parnoh", "RETURN NO")

    '            Try
    '                If CmdGeneral.Connection.State <> ConnectionState.Open Then
    '                    CmdGeneral.Connection.Open()
    '                End If
    '                CmdGeneral.CommandText = "Select amount From GL_Paid_received where tran_type='3' AND id_service_center=" & Qt(TxtRef.Text)
    '                rpt.SetParameterValue("ParwkStnod", Math.Round(CmdGeneral.ExecuteScalar, 2))
    '            Catch ex As Exception
    '                rpt.SetParameterValue("ParwkStnod", 0)
    '            End Try

    '            Try
    '                rpt.SetParameterValue("parcomments", CommentButton_Customer.ZCommentText)
    '            Catch ex As Exception
    '                rpt.SetParameterValue("parcomments", "")
    '            End Try
    '            rpt.SetParameterValue("ParKindRep", "CUSTOMER RETURN")
    '    End Select
    '    'Dim margins As PageMargins

    '    '' Get the PageMargins structure and set the 
    '    '' margins for the report.
    '    'margins = Report.PrintOptions.PageMargins

    '    'margins.bottomMargin = 350
    '    'margins.leftMargin = 350
    '    'margins.rightMargin = 350
    '    'margins.topMargin = 350


    '    rpt.SetDataSource(DsFrmWorkOrders1)

    '    rpt.SetParameterValue("CustomerSigniture", "")
    '    Select Case ServiceCenterType
    '        Case "ES"
    '            rpt.SetParameterValue("ParaLblHead1", "")
    '            rpt.SetParameterValue("ParaLblHead2", "")
    '            rpt.SetParameterValue("ParaLblHead3", "")
    '            rpt.SetParameterValue("Parwkponumberd", "")
    '            rpt.SetParameterValue("Parwkstatusd", "")
    '            '''''rpt.SetParameterValue("CustomerSigniture", OleDbReaderForStore.Item("WARRANTY_FOR_ES") & "")
    '        Case "WO"
    '            rpt.SetParameterValue("ParaLblHead1", "ESTIMATE NO")
    '            rpt.SetParameterValue("ParaLblHead2", "STATUS")
    '            rpt.SetParameterValue("ParaLblHead3", "PO NUMBER")
    '            rpt.SetParameterValue("Parwkponumberd", TxtPo_No.Text)
    '            rpt.SetParameterValue("Parwkstatusd", "")
    '            '''''rpt.SetParameterValue("CustomerSigniture", OleDbReaderForStore.Item("DISCLAIMER_FOR_WO") & "")
    '        Case "IN"
    '            rpt.SetParameterValue("ParaLblHead1", "ESTIMATE NO")
    '            rpt.SetParameterValue("ParaLblHead2", "WORK ORDER NO")
    '            rpt.SetParameterValue("ParaLblHead3", "PO NUMBER")
    '            rpt.SetParameterValue("Parwkponumberd", TxtPo_No.Text)
    '            rpt.SetParameterValue("Parwkstatusd", FindWorkOrderNo(ThisTxtRef))
    '            ''''rpt.SetParameterValue("CustomerSigniture", OleDbReaderForStore.Item("WARRANTY_FOR_IN") & "")
    '        Case "RT"
    '            rpt.SetParameterValue("ParaLblHead1", "CASH REFUND")
    '            rpt.SetParameterValue("ParaLblHead2", "C.C. CREDIT")
    '            rpt.SetParameterValue("ParaLblHead3", "AR CREDIT")
    '            Dim AR_CreditTempVar As Decimal = 0

    '            Try
    '                CmdGeneral.CommandText = "SELECT  payment_amount  FROM   GL_payment_deposit WHERE  (refer_type = '1') AND (payment_type = '4') and id_service_center =" & Qt(InvoiceNoForReturnVar)
    '                If CmdGeneral.Connection.State <> ConnectionState.Open Then
    '                    CmdGeneral.Connection.Open()
    '                End If
    '                AR_CreditTempVar = Math.Round(CmdGeneral.ExecuteScalar, 2)
    '            Catch ex As Exception
    '                AR_CreditTempVar = 0
    '            End Try

    '            rpt.SetParameterValue("Parwkponumberd", AR_CreditTempVar)
    '            rpt.SetParameterValue("Parwkstatusd", "")
    '            rpt.SetParameterValue("CustomerSigniture", "")
    '    End Select

    '    Try
    '        Select Case PrintType.ToUpper
    '            Case "print".ToUpper
    '                Select Case ServiceCenterType
    '                    Case "ES"
    '                        rpt.SetParameterValue("paroriginal", "")
    '                        rpt.SetParameterValue("parcopylabel", "")
    '                        If OnePrintFlag Then
    '                            rpt.PrintToPrinter(1, True, 0, 0)
    '                        Else
    '                            rpt.PrintToPrinter(OleDbReaderForStore.Item("NO_OF_COPY_INPRINT_ES"), True, 0, 0)
    '                        End If
    '                    Case "WO"
    '                        rpt.SetParameterValue("paroriginal", "")
    '                        rpt.SetParameterValue("parcopylabel", "")
    '                        If OnePrintFlag Then
    '                            rpt.PrintToPrinter(1, True, 0, 0)
    '                        Else
    '                            rpt.PrintToPrinter(OleDbReaderForStore.Item("NO_OF_COPY_INPRINT_WO"), True, 0, 0)
    '                        End If
    '                    Case "IN"
    '                        rpt.SetParameterValue("paroriginal", "REPRINT")

    '                        rpt.SetParameterValue("parcopylabel", OleDbReaderForStore.Item("LABEL_INVOICE_COPY1"))
    '                        rpt.PrintToPrinter(1, True, 0, 0)
    '                        If Not OnePrintFlag Then
    '                            If OleDbReaderForStore.Item("NO_OF_COPY_INPRINT_IN") > 1 Then
    '                                rpt.SetParameterValue("parcopylabel", OleDbReaderForStore.Item("LABEL_INVOICE_COPY2"))
    '                                rpt.PrintToPrinter(1, True, 0, 0)
    '                            End If
    '                            If OleDbReaderForStore.Item("NO_OF_COPY_INPRINT_IN") > 2 Then
    '                                rpt.SetParameterValue("parcopylabel", OleDbReaderForStore.Item("LABEL_INVOICE_COPY3"))
    '                                rpt.PrintToPrinter(1, True, 0, 0)
    '                            End If
    '                        End If
    '                    Case "RT"
    '                        rpt.SetParameterValue("paroriginal", "")
    '                        rpt.SetParameterValue("parcopylabel", "")
    '                        rpt.PrintToPrinter(1, True, 0, 0)
    '                End Select
    '            Case "preview".ToUpper
    '                rpt.SetParameterValue("paroriginal", "")
    '                rpt.SetParameterValue("parcopylabel", "")
    '                prn.CrViewer.ReportSource = rpt
    '                prn.Show()
    '            Case "Fax".ToUpper
    '                Try
    '                    rpt.PrintOptions.PrinterName = "Fax"
    '                    rpt.PrintToPrinter(1, True, 0, 0)
    '                Catch ex As Exception
    '                    MsgBox("Add The FAX in (Printers and Faxes)")
    '                End Try
    '            Case "Email".ToUpper
    '                rpt.SetParameterValue("paroriginal", "")
    '                rpt.SetParameterValue("parcopylabel", "")
    '                rpt.ExportToDisk(CrystalDecisions.[Shared].ExportFormatType.WordForWindows, "c:\Inovoice" & TxtRef.Text.Trim & ".Doc")
    '        End Select
    '    Catch ex As Exception
    '    End Try

    'End Sub
    Private Function FindEstimateNo(ByVal ThisId_service_center As String) As String
        FindEstimateNo = ""
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim FindId_service_center As String = ThisId_service_center
        Do While True
            CmdGeneral.CommandText = "Select id_service_center_before from service_center_head where id_service_center=" & Qt(FindId_service_center)
            Try
                FindId_service_center = CmdGeneral.ExecuteScalar & ""
            Catch ex As Exception
                FindId_service_center = ""
            End Try
            If Mid(FindId_service_center, 1, 2) = "ES" Or FindId_service_center = "" Then
                FindEstimateNo = FindId_service_center
                Exit Do
            End If
        Loop
    End Function
    Private Function FindWorkOrderNo(ByVal ThisId_service_center As String) As String
        FindWorkOrderNo = ""
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim FindId_service_center As String = ThisId_service_center
        Do While True
            CmdGeneral.CommandText = "Select id_service_center_before from service_center_head where id_service_center=" & Qt(FindId_service_center)
            Try
                FindId_service_center = CmdGeneral.ExecuteScalar & ""
            Catch ex As Exception
                FindId_service_center = ""
            End Try
            If Mid(FindId_service_center, 1, 2) = "WO" Or FindId_service_center = "" Then
                FindWorkOrderNo = FindId_service_center
                Exit Do
            End If
        Loop
    End Function
    Private Function FindInvoiceNo(ByVal ThisId_service_center As String) As String
        FindInvoiceNo = ""
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim FindId_service_center As String = ThisId_service_center
        Do While True
            CmdGeneral.CommandText = "Select id_service_center_before from service_center_head where id_service_center=" & Qt(FindId_service_center)
            Try
                FindId_service_center = CmdGeneral.ExecuteScalar & ""
            Catch ex As Exception
                FindId_service_center = ""
            End Try
            If Mid(FindId_service_center, 1, 2) = "IN" Or FindId_service_center = "" Then
                FindInvoiceNo = FindId_service_center
                Exit Do
            End If
        Loop
    End Function
End Class
