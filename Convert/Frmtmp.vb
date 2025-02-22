Imports CommonClass
Public Class Frmtmp
    Inherits FrmBase

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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DStmp1 As Convert.DStmp
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Da1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents Cmd As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.DStmp1 = New Convert.DStmp
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Da1 = New System.Data.SqlClient.SqlDataAdapter
        Me.Cmd = New System.Data.SqlClient.SqlCommand
        CType(Me.DStmp1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=FARAJI1;packet size=4096;user id=sa;data source=""."";persist securi" & _
        "ty info=True;initial catalog=TireMate_01;password=sa"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Ok"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(152, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancel"
        '
        'DStmp1
        '
        Me.DStmp1.DataSetName = "DStmp"
        Me.DStmp1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT id_service_center, type_of_form, cod_customer, id_vehicle, date_refer, dis" & _
        "count, tax, house_comment, cust_comment, add_user, chg_user, po_no, id_service_c" & _
        "enter_before, id_GL_journal, Total FROM service_center_head WHERE (type_of_form " & _
        "= 'IN')"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO service_center_head(id_service_center, type_of_form, cod_customer, id" & _
        "_vehicle, date_refer, discount, tax, house_comment, cust_comment, add_user, chg_" & _
        "user, po_no, id_service_center_before, id_GL_journal, Total) VALUES (@id_service" & _
        "_center, @type_of_form, @cod_customer, @id_vehicle, @date_refer, @discount, @tax" & _
        ", @house_comment, @cust_comment, @add_user, @chg_user, @po_no, @id_service_cente" & _
        "r_before, @id_GL_journal, @Total); SELECT id_service_center, type_of_form, cod_c" & _
        "ustomer, id_vehicle, date_refer, discount, tax, house_comment, cust_comment, add" & _
        "_user, chg_user, po_no, id_service_center_before, id_GL_journal, Total FROM serv" & _
        "ice_center_head WHERE (id_service_center = @id_service_center)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_of_form", System.Data.SqlDbType.VarChar, 2, "type_of_form"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_vehicle", System.Data.SqlDbType.Int, 4, "id_vehicle"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_refer", System.Data.SqlDbType.VarChar, 10, "date_refer"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discount", System.Data.SqlDbType.Real, 4, "discount"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tax", System.Data.SqlDbType.Real, 4, "tax"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@house_comment", System.Data.SqlDbType.VarChar, 200, "house_comment"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cust_comment", System.Data.SqlDbType.VarChar, 200, "cust_comment"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@add_user", System.Data.SqlDbType.SmallInt, 2, "add_user"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@chg_user", System.Data.SqlDbType.SmallInt, 2, "chg_user"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@po_no", System.Data.SqlDbType.VarChar, 10, "po_no"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center_before", System.Data.SqlDbType.VarChar, 10, "id_service_center_before"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_GL_journal", System.Data.SqlDbType.Int, 4, "id_GL_journal"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Money, 8, "Total"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE service_center_head SET id_service_center = @id_service_center, type_of_fo" & _
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
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center", System.Data.SqlDbType.VarChar, 10, "id_service_center"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_of_form", System.Data.SqlDbType.VarChar, 2, "type_of_form"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_vehicle", System.Data.SqlDbType.Int, 4, "id_vehicle"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@date_refer", System.Data.SqlDbType.VarChar, 10, "date_refer"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discount", System.Data.SqlDbType.Real, 4, "discount"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tax", System.Data.SqlDbType.Real, 4, "tax"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@house_comment", System.Data.SqlDbType.VarChar, 200, "house_comment"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cust_comment", System.Data.SqlDbType.VarChar, 200, "cust_comment"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@add_user", System.Data.SqlDbType.SmallInt, 2, "add_user"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@chg_user", System.Data.SqlDbType.SmallInt, 2, "chg_user"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@po_no", System.Data.SqlDbType.VarChar, 10, "po_no"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_service_center_before", System.Data.SqlDbType.VarChar, 10, "id_service_center_before"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_GL_journal", System.Data.SqlDbType.Int, 4, "id_GL_journal"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Money, 8, "Total"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_add_user", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "add_user", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_chg_user", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "chg_user", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_customer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_customer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cust_comment", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_comment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_refer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_refer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_house_comment", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "house_comment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_GL_journal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_GL_journal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center_before", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center_before", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_vehicle", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_vehicle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_po_no", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "po_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tax", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_of_form", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_of_form", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM service_center_head WHERE (id_service_center = @Original_id_service_c" & _
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
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_add_user", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "add_user", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_chg_user", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "chg_user", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_customer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_customer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cust_comment", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_comment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_date_refer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "date_refer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_house_comment", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "house_comment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_GL_journal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_GL_journal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_service_center_before", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_service_center_before", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_vehicle", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_vehicle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_po_no", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "po_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tax", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_of_form", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_of_form", System.Data.DataRowVersion.Original, Nothing))
        '
        'Da1
        '
        Me.Da1.DeleteCommand = Me.SqlDeleteCommand1
        Me.Da1.InsertCommand = Me.SqlInsertCommand1
        Me.Da1.SelectCommand = Me.SqlSelectCommand2
        Me.Da1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "service_center_head", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_service_center", "id_service_center"), New System.Data.Common.DataColumnMapping("type_of_form", "type_of_form"), New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("id_vehicle", "id_vehicle"), New System.Data.Common.DataColumnMapping("date_refer", "date_refer"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("tax", "tax"), New System.Data.Common.DataColumnMapping("house_comment", "house_comment"), New System.Data.Common.DataColumnMapping("cust_comment", "cust_comment"), New System.Data.Common.DataColumnMapping("add_user", "add_user"), New System.Data.Common.DataColumnMapping("chg_user", "chg_user"), New System.Data.Common.DataColumnMapping("po_no", "po_no"), New System.Data.Common.DataColumnMapping("id_service_center_before", "id_service_center_before"), New System.Data.Common.DataColumnMapping("id_GL_journal", "id_GL_journal"), New System.Data.Common.DataColumnMapping("Total", "Total")})})
        Me.Da1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'Cmd
        '
        Me.Cmd.Connection = Me.Cnn
        '
        'Frmtmp
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(254, 68)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Frmtmp"
        Me.Text = "Frmtmp"
        CType(Me.DStmp1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Frmtmp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cnn.ConnectionString = PConnectionString
        If Cmd.Connection.State <> ConnectionState.Open Then
            Cmd.Connection.Open()
        End If
    
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Cmd.CommandText = "ALTER TABLE [dbo].[ser_tr_vehicle] DROP CONSTRAINT FK_ser_tr_vehicle_cust_trtab_main"
            Cmd.ExecuteNonQuery()
            Cmd.CommandText = "ALTER TABLE [dbo].[ser_tr_vehicle] ADD 	CONSTRAINT [FK_ser_tr_vehicle_cust_trtab_main] FOREIGN KEY ([cod_customer]) REFERENCES [dbo].[cust_trtab_main] ([cod_customer])"
            Cmd.ExecuteNonQuery()
            Cmd.CommandText = "ALTER TABLE [dbo].[service_center_head] DROP CONSTRAINT FK_wo_work_order_head_cust_trtab_main"
            Cmd.ExecuteNonQuery()
            Cmd.CommandText = "ALTER TABLE [dbo].[service_center_head] ADD CONSTRAINT [FK_wo_work_order_head_cust_trtab_main] FOREIGN KEY ([cod_customer]) REFERENCES [dbo].[cust_trtab_main] ([cod_customer])"
            Cmd.ExecuteNonQuery()
            Cmd.CommandText = "ALTER TABLE [dbo].[GL_payment_deposit] DROP CONSTRAINT FK_GL_payment_deposit_service_center_head"
            Cmd.ExecuteNonQuery()
            Cmd.CommandText = "ALTER TABLE [dbo].[GL_payment_deposit] ADD CONSTRAINT [FK_GL_payment_deposit_service_center_head] FOREIGN KEY ([id_service_center]) REFERENCES [dbo].[service_center_head] ([id_service_center]) ON UPDATE CASCADE "
            Cmd.ExecuteNonQuery()
            Cmd.CommandText = "ALTER TABLE [dbo].[GL_account_adjustment_dtl] DROP CONSTRAINT FK_GL_account_adjustment_dtl_service_center_head"
            Cmd.ExecuteNonQuery()
            Cmd.CommandText = "ALTER TABLE [dbo].[GL_account_adjustment_dtl] ADD CONSTRAINT [FK_GL_account_adjustment_dtl_service_center_head] FOREIGN KEY ([id_service_center]) REFERENCES [dbo].[service_center_head] ([id_service_center]) ON UPDATE CASCADE "
            Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        '----------------------------------------------
        DStmp1.service_center_head.Clear()
        Da1.Fill(DStmp1.service_center_head)
        Dim i As Long
        Dim invno As String
        Dim befinvoice As String
        For i = 0 To DStmp1.service_center_head.Rows.Count - 1
            invno = "IN" & Getcod(i + 1, 6)
            With DStmp1.service_center_head.Rows(i)
                befinvoice = .Item("id_service_center")

                If Trim(.Item("cust_comment") & "") = "Begin Balance" Then
                    .Item("id_service_center") = invno
                    .Item("cust_comment") = .Item("cust_comment") + befinvoice
                Else
                    If befinvoice.Trim.Length >= 9 Then
                        .Item("id_service_center") = "IN" + "0" + Mid(befinvoice, 5, 5)
                        .Item("cust_comment") = .Item("cust_comment") + befinvoice
                    End If

                End If
            End With
        Next
        Try
            Da1.Update(DStmp1)
            Cmd.CommandText = "ALTER TABLE [dbo].[GL_payment_deposit] DROP CONSTRAINT FK_GL_payment_deposit_service_center_head"
            Cmd.ExecuteNonQuery()
            Cmd.CommandText = "ALTER TABLE [dbo].[GL_payment_deposit] ADD CONSTRAINT [FK_GL_payment_deposit_service_center_head] FOREIGN KEY([id_service_center]) REFERENCES [dbo].[service_center_head] ([id_service_center]) "
            Cmd.ExecuteNonQuery()
            Cmd.CommandText = "ALTER TABLE [dbo].[GL_account_adjustment_dtl] DROP CONSTRAINT FK_GL_account_adjustment_dtl_service_center_head"
            Cmd.ExecuteNonQuery()
            Cmd.CommandText = "ALTER TABLE [dbo].[GL_account_adjustment_dtl] ADD CONSTRAINT [FK_GL_account_adjustment_dtl_service_center_head] FOREIGN KEY ([id_service_center]) REFERENCES [dbo].[service_center_head] ([id_service_center]) "
            Cmd.ExecuteNonQuery()
            Cmd.CommandText = "ALTER TABLE [dbo].[ser_tr_vehicle] DROP CONSTRAINT FK_ser_tr_vehicle_cust_trtab_main"
            Cmd.ExecuteNonQuery()
            Cmd.CommandText = "ALTER TABLE [dbo].[ser_tr_vehicle] ADD 	CONSTRAINT [FK_ser_tr_vehicle_cust_trtab_main] FOREIGN KEY ([cod_customer]) REFERENCES [dbo].[cust_trtab_main] ([cod_customer]) ON UPDATE CASCADE"
            Cmd.ExecuteNonQuery()
            Cmd.CommandText = "ALTER TABLE [dbo].[service_center_head] DROP CONSTRAINT FK_wo_work_order_head_cust_trtab_main"
            Cmd.ExecuteNonQuery()
            Cmd.CommandText = "ALTER TABLE [dbo].[service_center_head] ADD CONSTRAINT [FK_wo_work_order_head_cust_trtab_main] FOREIGN KEY ([cod_customer]) REFERENCES [dbo].[cust_trtab_main] ([cod_customer]) ON UPDATE CASCADE"
            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MsgFar("update complete")
    End Sub
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
End Class
