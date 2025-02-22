
Imports CommonClass

Public Class CusConvert
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents txtPath As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents daCus As System.Data.Odbc.OdbcDataAdapter
    Friend WithEvents DsCus1 As Convert.dsCus
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Friend WithEvents CnnExcelFile As System.Data.Odbc.OdbcConnection
    Friend WithEvents CnnSql As System.Data.SqlClient.SqlConnection
    Friend WithEvents daCusCompany As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daBasTabPhoneType As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daCusSalesTax As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daCusTabType As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daCusTabSource As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daCusTabClass As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daCusTrTabMain As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand7 As System.Data.SqlClient.SqlCommand
    Public WithEvents ProgressBar As Janus.Windows.EditControls.UIProgressBar
    Friend WithEvents daZipCode As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents lblWait As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand8 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtPath = New Janus.Windows.GridEX.EditControls.EditBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnConvert = New System.Windows.Forms.Button
        Me.CnnExcelFile = New System.Data.Odbc.OdbcConnection
        Me.DsCus1 = New Convert.dsCus
        Me.daCus = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.CnnSql = New System.Data.SqlClient.SqlConnection
        Me.daCusCompany = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.daBasTabPhoneType = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.daCusSalesTax = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.daCusTabType = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.daCusTabSource = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
        Me.daCusTabClass = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand
        Me.daCusTrTabMain = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand7 = New System.Data.SqlClient.SqlCommand
        Me.ProgressBar = New Janus.Windows.EditControls.UIProgressBar
        Me.daZipCode = New System.Data.SqlClient.SqlDataAdapter
        Me.lblWait = New System.Windows.Forms.Label
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand8 = New System.Data.SqlClient.SqlCommand
        CType(Me.DsCus1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPath
        '
        Me.txtPath.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.txtPath.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.txtPath.ButtonFont = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtPath.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis
        Me.txtPath.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtPath.Location = New System.Drawing.Point(72, 15)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPath.Size = New System.Drawing.Size(360, 25)
        Me.txtPath.TabIndex = 215
        Me.txtPath.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 216
        Me.Label1.Text = "Look in :"
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(8, 65)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(56, 24)
        Me.btnConvert.TabIndex = 217
        Me.btnConvert.Text = "Convert"
        '
        'DsCus1
        '
        Me.DsCus1.DataSetName = "dsCus"
        Me.DsCus1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'daCus
        '
        Me.daCus.SelectCommand = Me.OdbcSelectCommand1
        Me.daCus.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "maskan", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Customer", "Customer"), New System.Data.Common.DataColumnMapping("Name", "Name"), New System.Data.Common.DataColumnMapping("Company", "Company"), New System.Data.Common.DataColumnMapping("Address (1)", "Address (1)"), New System.Data.Common.DataColumnMapping("Address (2)", "Address (2)"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("ST", "ST"), New System.Data.Common.DataColumnMapping("Zip Code", "Zip Code"), New System.Data.Common.DataColumnMapping(" Phone", " Phone"), New System.Data.Common.DataColumnMapping("Type of Phone ", "Type of Phone "), New System.Data.Common.DataColumnMapping("Charge", "Charge"), New System.Data.Common.DataColumnMapping("Taxable", "Taxable"), New System.Data.Common.DataColumnMapping("Sales Tax", "Sales Tax"), New System.Data.Common.DataColumnMapping("CLASS", "CLASS"), New System.Data.Common.DataColumnMapping("Type", "Type"), New System.Data.Common.DataColumnMapping("Source", "Source"), New System.Data.Common.DataColumnMapping("Customer Since", "Customer Since"), New System.Data.Common.DataColumnMapping("Statement", "Statement"), New System.Data.Common.DataColumnMapping("Accept Check", "Accept Check"), New System.Data.Common.DataColumnMapping("Finance charge", "Finance charge"), New System.Data.Common.DataColumnMapping("VIP", "VIP"), New System.Data.Common.DataColumnMapping("AR Terms", "AR Terms"), New System.Data.Common.DataColumnMapping("Price Level", "Price Level")})})
        '
        'OdbcSelectCommand1
        '
        Me.OdbcSelectCommand1.Connection = Me.CnnExcelFile
        '
        'CnnSql
        '
        Me.CnnSql.ConnectionString = "workstation id=NET;packet size=4096;integrated security=SSPI;data source=Net;pers" & _
        "ist security info=False;initial catalog=TireMate_01"
        '
        'daCusCompany
        '
        Me.daCusCompany.DeleteCommand = Me.SqlDeleteCommand1
        Me.daCusCompany.InsertCommand = Me.SqlInsertCommand1
        Me.daCusCompany.SelectCommand = Me.SqlSelectCommand1
        Me.daCusCompany.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_company", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_company", "cod_company"), New System.Data.Common.DataColumnMapping("abbreviation_name", "abbreviation_name"), New System.Data.Common.DataColumnMapping("complete_name", "complete_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zip_code", "zip_code"), New System.Data.Common.DataColumnMapping("remark", "remark")})})
        Me.daCusCompany.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM cust_company WHERE (cod_company = @Original_cod_company) AND (abbrevi" & _
        "ation_name = @Original_abbreviation_name OR @Original_abbreviation_name IS NULL " & _
        "AND abbreviation_name IS NULL) AND (address = @Original_address OR @Original_add" & _
        "ress IS NULL AND address IS NULL) AND (complete_name = @Original_complete_name O" & _
        "R @Original_complete_name IS NULL AND complete_name IS NULL) AND (remark = @Orig" & _
        "inal_remark OR @Original_remark IS NULL AND remark IS NULL) AND (zip_code = @Ori" & _
        "ginal_zip_code OR @Original_zip_code IS NULL AND zip_code IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.CnnSql
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_company", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_company", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_abbreviation_name", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "abbreviation_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_complete_name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "complete_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_zip_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "zip_code", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO cust_company(cod_company, abbreviation_name, complete_name, address, " & _
        "zip_code, remark) VALUES (@cod_company, @abbreviation_name, @complete_name, @add" & _
        "ress, @zip_code, @remark); SELECT cod_company, abbreviation_name, complete_name," & _
        " address, zip_code, remark FROM cust_company WHERE (cod_company = @cod_company)"
        Me.SqlInsertCommand1.Connection = Me.CnnSql
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_company", System.Data.SqlDbType.VarChar, 5, "cod_company"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@abbreviation_name", System.Data.SqlDbType.VarChar, 25, "abbreviation_name"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@complete_name", System.Data.SqlDbType.VarChar, 50, "complete_name"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zip_code", System.Data.SqlDbType.VarChar, 5, "zip_code"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cod_company, abbreviation_name, complete_name, address, zip_code, remark F" & _
        "ROM cust_company"
        Me.SqlSelectCommand1.Connection = Me.CnnSql
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE cust_company SET cod_company = @cod_company, abbreviation_name = @abbrevia" & _
        "tion_name, complete_name = @complete_name, address = @address, zip_code = @zip_c" & _
        "ode, remark = @remark WHERE (cod_company = @Original_cod_company) AND (abbreviat" & _
        "ion_name = @Original_abbreviation_name OR @Original_abbreviation_name IS NULL AN" & _
        "D abbreviation_name IS NULL) AND (address = @Original_address OR @Original_addre" & _
        "ss IS NULL AND address IS NULL) AND (complete_name = @Original_complete_name OR " & _
        "@Original_complete_name IS NULL AND complete_name IS NULL) AND (remark = @Origin" & _
        "al_remark OR @Original_remark IS NULL AND remark IS NULL) AND (zip_code = @Origi" & _
        "nal_zip_code OR @Original_zip_code IS NULL AND zip_code IS NULL); SELECT cod_com" & _
        "pany, abbreviation_name, complete_name, address, zip_code, remark FROM cust_comp" & _
        "any WHERE (cod_company = @cod_company)"
        Me.SqlUpdateCommand1.Connection = Me.CnnSql
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_company", System.Data.SqlDbType.VarChar, 5, "cod_company"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@abbreviation_name", System.Data.SqlDbType.VarChar, 25, "abbreviation_name"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@complete_name", System.Data.SqlDbType.VarChar, 50, "complete_name"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zip_code", System.Data.SqlDbType.VarChar, 5, "zip_code"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@remark", System.Data.SqlDbType.VarChar, 300, "remark"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_company", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_company", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_abbreviation_name", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "abbreviation_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_complete_name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "complete_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_remark", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "remark", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_zip_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "zip_code", System.Data.DataRowVersion.Original, Nothing))
        '
        'daBasTabPhoneType
        '
        Me.daBasTabPhoneType.DeleteCommand = Me.SqlDeleteCommand2
        Me.daBasTabPhoneType.InsertCommand = Me.SqlInsertCommand2
        Me.daBasTabPhoneType.SelectCommand = Me.SqlSelectCommand2
        Me.daBasTabPhoneType.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_tab_phone_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_type_phone", "cod_type_phone"), New System.Data.Common.DataColumnMapping("desc_type_phone", "desc_type_phone")})})
        Me.daBasTabPhoneType.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM bas_tab_phone_type WHERE (cod_type_phone = @Original_cod_type_phone) " & _
        "AND (desc_type_phone = @Original_desc_type_phone OR @Original_desc_type_phone IS" & _
        " NULL AND desc_type_phone IS NULL)"
        Me.SqlDeleteCommand2.Connection = Me.CnnSql
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_type_phone", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_type_phone", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_type_phone", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_type_phone", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO bas_tab_phone_type(cod_type_phone, desc_type_phone) VALUES (@cod_type" & _
        "_phone, @desc_type_phone); SELECT cod_type_phone, desc_type_phone FROM bas_tab_p" & _
        "hone_type WHERE (cod_type_phone = @cod_type_phone)"
        Me.SqlInsertCommand2.Connection = Me.CnnSql
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_type_phone", System.Data.SqlDbType.VarChar, 1, "cod_type_phone"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_type_phone", System.Data.SqlDbType.VarChar, 15, "desc_type_phone"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT cod_type_phone, desc_type_phone FROM bas_tab_phone_type"
        Me.SqlSelectCommand2.Connection = Me.CnnSql
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE bas_tab_phone_type SET cod_type_phone = @cod_type_phone, desc_type_phone =" & _
        " @desc_type_phone WHERE (cod_type_phone = @Original_cod_type_phone) AND (desc_ty" & _
        "pe_phone = @Original_desc_type_phone OR @Original_desc_type_phone IS NULL AND de" & _
        "sc_type_phone IS NULL); SELECT cod_type_phone, desc_type_phone FROM bas_tab_phon" & _
        "e_type WHERE (cod_type_phone = @cod_type_phone)"
        Me.SqlUpdateCommand2.Connection = Me.CnnSql
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_type_phone", System.Data.SqlDbType.VarChar, 1, "cod_type_phone"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_type_phone", System.Data.SqlDbType.VarChar, 15, "desc_type_phone"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_type_phone", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_type_phone", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_type_phone", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_type_phone", System.Data.DataRowVersion.Original, Nothing))
        '
        'daCusSalesTax
        '
        Me.daCusSalesTax.DeleteCommand = Me.SqlDeleteCommand3
        Me.daCusSalesTax.InsertCommand = Me.SqlInsertCommand3
        Me.daCusSalesTax.SelectCommand = Me.SqlSelectCommand3
        Me.daCusSalesTax.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_sales_tax", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_sales_tax", "cod_sales_tax"), New System.Data.Common.DataColumnMapping("desc_sales_tax", "desc_sales_tax"), New System.Data.Common.DataColumnMapping("Amount", "Amount")})})
        Me.daCusSalesTax.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM cust_sales_tax WHERE (cod_sales_tax = @Original_cod_sales_tax) AND (A" & _
        "mount = @Original_Amount) AND (desc_sales_tax = @Original_desc_sales_tax OR @Ori" & _
        "ginal_desc_sales_tax IS NULL AND desc_sales_tax IS NULL)"
        Me.SqlDeleteCommand3.Connection = Me.CnnSql
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_sales_tax", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_sales_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_sales_tax", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_sales_tax", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO cust_sales_tax(cod_sales_tax, desc_sales_tax, Amount) VALUES (@cod_sa" & _
        "les_tax, @desc_sales_tax, @Amount); SELECT cod_sales_tax, desc_sales_tax, Amount" & _
        " FROM cust_sales_tax WHERE (cod_sales_tax = @cod_sales_tax)"
        Me.SqlInsertCommand3.Connection = Me.CnnSql
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_sales_tax", System.Data.SqlDbType.VarChar, 2, "cod_sales_tax"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_sales_tax", System.Data.SqlDbType.VarChar, 50, "desc_sales_tax"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Money, 8, "Amount"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT cod_sales_tax, desc_sales_tax, Amount FROM cust_sales_tax"
        Me.SqlSelectCommand3.Connection = Me.CnnSql
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE cust_sales_tax SET cod_sales_tax = @cod_sales_tax, desc_sales_tax = @desc_" & _
        "sales_tax, Amount = @Amount WHERE (cod_sales_tax = @Original_cod_sales_tax) AND " & _
        "(Amount = @Original_Amount) AND (desc_sales_tax = @Original_desc_sales_tax OR @O" & _
        "riginal_desc_sales_tax IS NULL AND desc_sales_tax IS NULL); SELECT cod_sales_tax" & _
        ", desc_sales_tax, Amount FROM cust_sales_tax WHERE (cod_sales_tax = @cod_sales_t" & _
        "ax)"
        Me.SqlUpdateCommand3.Connection = Me.CnnSql
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_sales_tax", System.Data.SqlDbType.VarChar, 2, "cod_sales_tax"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_sales_tax", System.Data.SqlDbType.VarChar, 50, "desc_sales_tax"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Money, 8, "Amount"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_sales_tax", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_sales_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Amount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_sales_tax", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_sales_tax", System.Data.DataRowVersion.Original, Nothing))
        '
        'daCusTabType
        '
        Me.daCusTabType.DeleteCommand = Me.SqlDeleteCommand4
        Me.daCusTabType.InsertCommand = Me.SqlInsertCommand4
        Me.daCusTabType.SelectCommand = Me.SqlSelectCommand4
        Me.daCusTabType.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_tab_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_type", "cod_type"), New System.Data.Common.DataColumnMapping("desc_type", "desc_type")})})
        Me.daCusTabType.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM cust_tab_type WHERE (cod_type = @Original_cod_type) AND (desc_type = " & _
        "@Original_desc_type OR @Original_desc_type IS NULL AND desc_type IS NULL)"
        Me.SqlDeleteCommand4.Connection = Me.CnnSql
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_type", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_type", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO cust_tab_type(cod_type, desc_type) VALUES (@cod_type, @desc_type); SE" & _
        "LECT cod_type, desc_type FROM cust_tab_type WHERE (cod_type = @cod_type)"
        Me.SqlInsertCommand4.Connection = Me.CnnSql
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_type", System.Data.SqlDbType.VarChar, 1, "cod_type"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_type", System.Data.SqlDbType.VarChar, 50, "desc_type"))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT cod_type, desc_type FROM cust_tab_type"
        Me.SqlSelectCommand4.Connection = Me.CnnSql
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE cust_tab_type SET cod_type = @cod_type, desc_type = @desc_type WHERE (cod_" & _
        "type = @Original_cod_type) AND (desc_type = @Original_desc_type OR @Original_des" & _
        "c_type IS NULL AND desc_type IS NULL); SELECT cod_type, desc_type FROM cust_tab_" & _
        "type WHERE (cod_type = @cod_type)"
        Me.SqlUpdateCommand4.Connection = Me.CnnSql
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_type", System.Data.SqlDbType.VarChar, 1, "cod_type"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_type", System.Data.SqlDbType.VarChar, 50, "desc_type"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_type", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_type", System.Data.DataRowVersion.Original, Nothing))
        '
        'daCusTabSource
        '
        Me.daCusTabSource.DeleteCommand = Me.SqlDeleteCommand5
        Me.daCusTabSource.InsertCommand = Me.SqlInsertCommand5
        Me.daCusTabSource.SelectCommand = Me.SqlSelectCommand5
        Me.daCusTabSource.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_tab_source", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_source", "cod_source"), New System.Data.Common.DataColumnMapping("desc_source", "desc_source")})})
        Me.daCusTabSource.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = "DELETE FROM cust_tab_source WHERE (cod_source = @Original_cod_source) AND (desc_s" & _
        "ource = @Original_desc_source OR @Original_desc_source IS NULL AND desc_source I" & _
        "S NULL)"
        Me.SqlDeleteCommand5.Connection = Me.CnnSql
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_source", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_source", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_source", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_source", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO cust_tab_source(cod_source, desc_source) VALUES (@cod_source, @desc_s" & _
        "ource); SELECT cod_source, desc_source FROM cust_tab_source WHERE (cod_source = " & _
        "@cod_source)"
        Me.SqlInsertCommand5.Connection = Me.CnnSql
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_source", System.Data.SqlDbType.VarChar, 1, "cod_source"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_source", System.Data.SqlDbType.VarChar, 10, "desc_source"))
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT cod_source, desc_source FROM cust_tab_source"
        Me.SqlSelectCommand5.Connection = Me.CnnSql
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = "UPDATE cust_tab_source SET cod_source = @cod_source, desc_source = @desc_source W" & _
        "HERE (cod_source = @Original_cod_source) AND (desc_source = @Original_desc_sourc" & _
        "e OR @Original_desc_source IS NULL AND desc_source IS NULL); SELECT cod_source, " & _
        "desc_source FROM cust_tab_source WHERE (cod_source = @cod_source)"
        Me.SqlUpdateCommand5.Connection = Me.CnnSql
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_source", System.Data.SqlDbType.VarChar, 1, "cod_source"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_source", System.Data.SqlDbType.VarChar, 10, "desc_source"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_source", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_source", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_source", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_source", System.Data.DataRowVersion.Original, Nothing))
        '
        'daCusTabClass
        '
        Me.daCusTabClass.DeleteCommand = Me.SqlDeleteCommand6
        Me.daCusTabClass.InsertCommand = Me.SqlInsertCommand6
        Me.daCusTabClass.SelectCommand = Me.SqlSelectCommand6
        Me.daCusTabClass.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_tab_class", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_class", "cod_class"), New System.Data.Common.DataColumnMapping("desc_class", "desc_class")})})
        Me.daCusTabClass.UpdateCommand = Me.SqlUpdateCommand6
        '
        'SqlDeleteCommand6
        '
        Me.SqlDeleteCommand6.CommandText = "DELETE FROM cust_tab_class WHERE (cod_class = @Original_cod_class) AND (desc_clas" & _
        "s = @Original_desc_class OR @Original_desc_class IS NULL AND desc_class IS NULL)" & _
        ""
        Me.SqlDeleteCommand6.Connection = Me.CnnSql
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_class", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_class", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_class", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_class", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = "INSERT INTO cust_tab_class(cod_class, desc_class) VALUES (@cod_class, @desc_class" & _
        "); SELECT cod_class, desc_class FROM cust_tab_class WHERE (cod_class = @cod_clas" & _
        "s)"
        Me.SqlInsertCommand6.Connection = Me.CnnSql
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_class", System.Data.SqlDbType.VarChar, 1, "cod_class"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_class", System.Data.SqlDbType.VarChar, 50, "desc_class"))
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT cod_class, desc_class FROM cust_tab_class"
        Me.SqlSelectCommand6.Connection = Me.CnnSql
        '
        'SqlUpdateCommand6
        '
        Me.SqlUpdateCommand6.CommandText = "UPDATE cust_tab_class SET cod_class = @cod_class, desc_class = @desc_class WHERE " & _
        "(cod_class = @Original_cod_class) AND (desc_class = @Original_desc_class OR @Ori" & _
        "ginal_desc_class IS NULL AND desc_class IS NULL); SELECT cod_class, desc_class F" & _
        "ROM cust_tab_class WHERE (cod_class = @cod_class)"
        Me.SqlUpdateCommand6.Connection = Me.CnnSql
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_class", System.Data.SqlDbType.VarChar, 1, "cod_class"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_class", System.Data.SqlDbType.VarChar, 50, "desc_class"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_class", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_class", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_class", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_class", System.Data.DataRowVersion.Original, Nothing))
        '
        'daCusTrTabMain
        '
        Me.daCusTrTabMain.DeleteCommand = Me.SqlDeleteCommand7
        Me.daCusTrTabMain.InsertCommand = Me.SqlInsertCommand7
        Me.daCusTrTabMain.SelectCommand = Me.SqlSelectCommand7
        Me.daCusTrTabMain.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "cust_trtab_main", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_customer", "cod_customer"), New System.Data.Common.DataColumnMapping("vip_code", "vip_code"), New System.Data.Common.DataColumnMapping("cod_company", "cod_company"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("driver_name1", "driver_name1"), New System.Data.Common.DataColumnMapping("driver_name2", "driver_name2"), New System.Data.Common.DataColumnMapping("driver_name3", "driver_name3"), New System.Data.Common.DataColumnMapping("driver_name4", "driver_name4"), New System.Data.Common.DataColumnMapping("DriverLicense", "DriverLicense"), New System.Data.Common.DataColumnMapping("zip", "zip"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("cod_sales_rep", "cod_sales_rep"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cust_exempt_tax", "cust_exempt_tax"), New System.Data.Common.DataColumnMapping("scrap_check", "scrap_check"), New System.Data.Common.DataColumnMapping("scrap_value", "scrap_value"), New System.Data.Common.DataColumnMapping("credit_card_no", "credit_card_no"), New System.Data.Common.DataColumnMapping("expiration_credit_date", "expiration_credit_date"), New System.Data.Common.DataColumnMapping("credit_limited", "credit_limited"), New System.Data.Common.DataColumnMapping("AR_charge", "AR_charge"), New System.Data.Common.DataColumnMapping("AR_term", "AR_term"), New System.Data.Common.DataColumnMapping("cod_sales_tax", "cod_sales_tax"), New System.Data.Common.DataColumnMapping("cod_price", "cod_price"), New System.Data.Common.DataColumnMapping("discount", "discount"), New System.Data.Common.DataColumnMapping("cod_type", "cod_type"), New System.Data.Common.DataColumnMapping("cod_source", "cod_source"), New System.Data.Common.DataColumnMapping("cod_class", "cod_class"), New System.Data.Common.DataColumnMapping("cod_territory", "cod_territory"), New System.Data.Common.DataColumnMapping("desc_sales_report", "desc_sales_report"), New System.Data.Common.DataColumnMapping("user_id", "user_id"), New System.Data.Common.DataColumnMapping("user_password", "user_password"), New System.Data.Common.DataColumnMapping("AR_statement", "AR_statement"), New System.Data.Common.DataColumnMapping("AR_send_copy", "AR_send_copy"), New System.Data.Common.DataColumnMapping("AR_finance_charge", "AR_finance_charge"), New System.Data.Common.DataColumnMapping("AR_require_PO", "AR_require_PO"), New System.Data.Common.DataColumnMapping("AR_credit_hold", "AR_credit_hold"), New System.Data.Common.DataColumnMapping("AR_accept_check", "AR_accept_check"), New System.Data.Common.DataColumnMapping("cust_notes", "cust_notes"), New System.Data.Common.DataColumnMapping("Taxable", "Taxable"), New System.Data.Common.DataColumnMapping("inactive", "inactive"), New System.Data.Common.DataColumnMapping("customer_no", "customer_no")})})
        Me.daCusTrTabMain.UpdateCommand = Me.SqlUpdateCommand7
        '
        'SqlDeleteCommand7
        '
        Me.SqlDeleteCommand7.CommandText = "DELETE FROM cust_trtab_main WHERE (cod_customer = @Original_cod_customer) AND (AR" & _
        "_accept_check = @Original_AR_accept_check OR @Original_AR_accept_check IS NULL A" & _
        "ND AR_accept_check IS NULL) AND (AR_charge = @Original_AR_charge OR @Original_AR" & _
        "_charge IS NULL AND AR_charge IS NULL) AND (AR_credit_hold = @Original_AR_credit" & _
        "_hold OR @Original_AR_credit_hold IS NULL AND AR_credit_hold IS NULL) AND (AR_fi" & _
        "nance_charge = @Original_AR_finance_charge OR @Original_AR_finance_charge IS NUL" & _
        "L AND AR_finance_charge IS NULL) AND (AR_require_PO = @Original_AR_require_PO OR" & _
        " @Original_AR_require_PO IS NULL AND AR_require_PO IS NULL) AND (AR_send_copy = " & _
        "@Original_AR_send_copy OR @Original_AR_send_copy IS NULL AND AR_send_copy IS NUL" & _
        "L) AND (AR_statement = @Original_AR_statement OR @Original_AR_statement IS NULL " & _
        "AND AR_statement IS NULL) AND (AR_term = @Original_AR_term OR @Original_AR_term " & _
        "IS NULL AND AR_term IS NULL) AND (DriverLicense = @Original_DriverLicense OR @Or" & _
        "iginal_DriverLicense IS NULL AND DriverLicense IS NULL) AND (Taxable = @Original" & _
        "_Taxable OR @Original_Taxable IS NULL AND Taxable IS NULL) AND (address = @Origi" & _
        "nal_address OR @Original_address IS NULL AND address IS NULL) AND (cod_class = @" & _
        "Original_cod_class OR @Original_cod_class IS NULL AND cod_class IS NULL) AND (co" & _
        "d_company = @Original_cod_company OR @Original_cod_company IS NULL AND cod_compa" & _
        "ny IS NULL) AND (cod_price = @Original_cod_price OR @Original_cod_price IS NULL " & _
        "AND cod_price IS NULL) AND (cod_sales_rep = @Original_cod_sales_rep OR @Original" & _
        "_cod_sales_rep IS NULL AND cod_sales_rep IS NULL) AND (cod_sales_tax = @Original" & _
        "_cod_sales_tax OR @Original_cod_sales_tax IS NULL AND cod_sales_tax IS NULL) AND" & _
        " (cod_source = @Original_cod_source OR @Original_cod_source IS NULL AND cod_sour" & _
        "ce IS NULL) AND (cod_territory = @Original_cod_territory OR @Original_cod_territ" & _
        "ory IS NULL AND cod_territory IS NULL) AND (cod_type = @Original_cod_type OR @Or" & _
        "iginal_cod_type IS NULL AND cod_type IS NULL) AND (credit_card_no = @Original_cr" & _
        "edit_card_no OR @Original_credit_card_no IS NULL AND credit_card_no IS NULL) AND" & _
        " (credit_limited = @Original_credit_limited OR @Original_credit_limited IS NULL " & _
        "AND credit_limited IS NULL) AND (cust_exempt_tax = @Original_cust_exempt_tax OR " & _
        "@Original_cust_exempt_tax IS NULL AND cust_exempt_tax IS NULL) AND (cust_notes =" & _
        " @Original_cust_notes OR @Original_cust_notes IS NULL AND cust_notes IS NULL) AN" & _
        "D (customer_no = @Original_customer_no OR @Original_customer_no IS NULL AND cust" & _
        "omer_no IS NULL) AND (desc_sales_report = @Original_desc_sales_report OR @Origin" & _
        "al_desc_sales_report IS NULL AND desc_sales_report IS NULL) AND (discount = @Ori" & _
        "ginal_discount OR @Original_discount IS NULL AND discount IS NULL) AND (driver_n" & _
        "ame1 = @Original_driver_name1 OR @Original_driver_name1 IS NULL AND driver_name1" & _
        " IS NULL) AND (driver_name2 = @Original_driver_name2 OR @Original_driver_name2 I" & _
        "S NULL AND driver_name2 IS NULL) AND (driver_name3 = @Original_driver_name3 OR @" & _
        "Original_driver_name3 IS NULL AND driver_name3 IS NULL) AND (driver_name4 = @Ori" & _
        "ginal_driver_name4 OR @Original_driver_name4 IS NULL AND driver_name4 IS NULL) A" & _
        "ND (email = @Original_email OR @Original_email IS NULL AND email IS NULL) AND (e" & _
        "xpiration_credit_date = @Original_expiration_credit_date OR @Original_expiration" & _
        "_credit_date IS NULL AND expiration_credit_date IS NULL) AND (extension_1 = @Ori" & _
        "ginal_extension_1 OR @Original_extension_1 IS NULL AND extension_1 IS NULL) AND " & _
        "(extension_2 = @Original_extension_2 OR @Original_extension_2 IS NULL AND extens" & _
        "ion_2 IS NULL) AND (extension_3 = @Original_extension_3 OR @Original_extension_3" & _
        " IS NULL AND extension_3 IS NULL) AND (extension_4 = @Original_extension_4 OR @O" & _
        "riginal_extension_4 IS NULL AND extension_4 IS NULL) AND (extension_5 = @Origina" & _
        "l_extension_5 OR @Original_extension_5 IS NULL AND extension_5 IS NULL) AND (f_n" & _
        "ame = @Original_f_name OR @Original_f_name IS NULL AND f_name IS NULL) AND (inac" & _
        "tive = @Original_inactive OR @Original_inactive IS NULL AND inactive IS NULL) AN" & _
        "D (l_name = @Original_l_name OR @Original_l_name IS NULL AND l_name IS NULL) AND" & _
        " (m_name = @Original_m_name OR @Original_m_name IS NULL AND m_name IS NULL) AND " & _
        "(phone_1 = @Original_phone_1 OR @Original_phone_1 IS NULL AND phone_1 IS NULL) A" & _
        "ND (phone_2 = @Original_phone_2 OR @Original_phone_2 IS NULL AND phone_2 IS NULL" & _
        ") AND (phone_3 = @Original_phone_3 OR @Original_phone_3 IS NULL AND phone_3 IS N" & _
        "ULL) AND (phone_4 = @Original_phone_4 OR @Original_phone_4 IS NULL AND phone_4 I" & _
        "S NULL) AND (phone_5 = @Original_phone_5 OR @Original_phone_5 IS NULL AND phone_" & _
        "5 IS NULL) AND (phone_main_1 = @Original_phone_main_1 OR @Original_phone_main_1 " & _
        "IS NULL AND phone_main_1 IS NULL) AND (phone_main_2 = @Original_phone_main_2 OR " & _
        "@Original_phone_main_2 IS NULL AND phone_main_2 IS NULL) AND (phone_main_3 = @Or" & _
        "iginal_phone_main_3 OR @Original_phone_main_3 IS NULL AND phone_main_3 IS NULL) " & _
        "AND (phone_main_4 = @Original_phone_main_4 OR @Original_phone_main_4 IS NULL AND" & _
        " phone_main_4 IS NULL) AND (phone_main_5 = @Original_phone_main_5 OR @Original_p" & _
        "hone_main_5 IS NULL AND phone_main_5 IS NULL) AND (phone_type_1 = @Original_phon" & _
        "e_type_1 OR @Original_phone_type_1 IS NULL AND phone_type_1 IS NULL) AND (phone_" & _
        "type_2 = @Original_phone_type_2 OR @Original_phone_type_2 IS NULL AND phone_type" & _
        "_2 IS NULL) AND (phone_type_3 = @Original_phone_type_3 OR @Original_phone_type_3" & _
        " IS NULL AND phone_type_3 IS NULL) AND (phone_type_4 = @Original_phone_type_4 OR" & _
        " @Original_phone_type_4 IS NULL AND phone_type_4 IS NULL) AND (phone_type_5 = @O" & _
        "riginal_phone_type_5 OR @Original_phone_type_5 IS NULL AND phone_type_5 IS NULL)" & _
        " AND (scrap_check = @Original_scrap_check OR @Original_scrap_check IS NULL AND s" & _
        "crap_check IS NULL) AND (scrap_value = @Original_scrap_value OR @Original_scrap_" & _
        "value IS NULL AND scrap_value IS NULL) AND (social_security_no = @Original_socia" & _
        "l_security_no OR @Original_social_security_no IS NULL AND social_security_no IS " & _
        "NULL) AND (user_id = @Original_user_id OR @Original_user_id IS NULL AND user_id " & _
        "IS NULL) AND (user_password = @Original_user_password OR @Original_user_password" & _
        " IS NULL AND user_password IS NULL) AND (vip_code = @Original_vip_code OR @Origi" & _
        "nal_vip_code IS NULL AND vip_code IS NULL) AND (zip = @Original_zip OR @Original" & _
        "_zip IS NULL AND zip IS NULL)"
        Me.SqlDeleteCommand7.Connection = Me.CnnSql
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_customer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_customer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_accept_check", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_accept_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_charge", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_charge", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_credit_hold", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_credit_hold", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_finance_charge", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_finance_charge", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_require_PO", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_require_PO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_send_copy", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_send_copy", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_statement", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_statement", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_term", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_term", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DriverLicense", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DriverLicense", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Taxable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Taxable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_class", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_class", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_company", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_company", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_price", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_sales_rep", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_sales_rep", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_sales_tax", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_sales_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_source", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_source", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_territory", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_territory", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_credit_card_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "credit_card_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_credit_limited", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "credit_limited", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cust_exempt_tax", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_exempt_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cust_notes", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_notes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_customer_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "customer_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_sales_report", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_sales_report", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_driver_name1", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "driver_name1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_driver_name2", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "driver_name2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_driver_name3", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "driver_name3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_driver_name4", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "driver_name4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_expiration_credit_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "expiration_credit_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_1", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_2", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_3", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_4", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_5", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_f_name", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "f_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_inactive", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inactive", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_l_name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "l_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_m_name", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "m_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_1", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_2", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_3", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_4", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_5", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_1", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_2", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_3", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_4", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_5", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_1", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_2", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_3", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_4", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_5", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_scrap_check", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "scrap_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_scrap_value", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "scrap_value", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_social_security_no", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "social_security_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_user_id", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "user_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_user_password", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "user_password", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vip_code", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vip_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_zip", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "zip", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand7
        '
        Me.SqlInsertCommand7.CommandText = "INSERT INTO cust_trtab_main(cod_customer, vip_code, cod_company, f_name, m_name, " & _
        "l_name, address, phone_1, extension_1, phone_type_1, phone_main_1, phone_2, exte" & _
        "nsion_2, phone_type_2, phone_main_2, phone_3, extension_3, phone_type_3, phone_m" & _
        "ain_3, phone_4, extension_4, phone_type_4, phone_main_4, phone_5, extension_5, p" & _
        "hone_type_5, phone_main_5, driver_name1, driver_name2, driver_name3, driver_name" & _
        "4, DriverLicense, zip, email, cod_sales_rep, social_security_no, cust_exempt_tax" & _
        ", scrap_check, scrap_value, credit_card_no, expiration_credit_date, credit_limit" & _
        "ed, AR_charge, AR_term, cod_sales_tax, cod_price, discount, cod_type, cod_source" & _
        ", cod_class, cod_territory, desc_sales_report, user_id, user_password, AR_statem" & _
        "ent, AR_send_copy, AR_finance_charge, AR_require_PO, AR_credit_hold, AR_accept_c" & _
        "heck, cust_notes, Taxable, inactive, customer_no) VALUES (@cod_customer, @vip_co" & _
        "de, @cod_company, @f_name, @m_name, @l_name, @address, @phone_1, @extension_1, @" & _
        "phone_type_1, @phone_main_1, @phone_2, @extension_2, @phone_type_2, @phone_main_" & _
        "2, @phone_3, @extension_3, @phone_type_3, @phone_main_3, @phone_4, @extension_4," & _
        " @phone_type_4, @phone_main_4, @phone_5, @extension_5, @phone_type_5, @phone_mai" & _
        "n_5, @driver_name1, @driver_name2, @driver_name3, @driver_name4, @DriverLicense," & _
        " @zip, @email, @cod_sales_rep, @social_security_no, @cust_exempt_tax, @scrap_che" & _
        "ck, @scrap_value, @credit_card_no, @expiration_credit_date, @credit_limited, @AR" & _
        "_charge, @AR_term, @cod_sales_tax, @cod_price, @discount, @cod_type, @cod_source" & _
        ", @cod_class, @cod_territory, @desc_sales_report, @user_id, @user_password, @AR_" & _
        "statement, @AR_send_copy, @AR_finance_charge, @AR_require_PO, @AR_credit_hold, @" & _
        "AR_accept_check, @cust_notes, @Taxable, @inactive, @customer_no); SELECT cod_cus" & _
        "tomer, vip_code, cod_company, f_name, m_name, l_name, address, phone_1, extensio" & _
        "n_1, phone_type_1, phone_main_1, phone_2, extension_2, phone_type_2, phone_main_" & _
        "2, phone_3, extension_3, phone_type_3, phone_main_3, phone_4, extension_4, phone" & _
        "_type_4, phone_main_4, phone_5, extension_5, phone_type_5, phone_main_5, driver_" & _
        "name1, driver_name2, driver_name3, driver_name4, DriverLicense, zip, email, cod_" & _
        "sales_rep, social_security_no, cust_exempt_tax, scrap_check, scrap_value, credit" & _
        "_card_no, expiration_credit_date, credit_limited, AR_charge, AR_term, cod_sales_" & _
        "tax, cod_price, discount, cod_type, cod_source, cod_class, cod_territory, desc_s" & _
        "ales_report, user_id, user_password, AR_statement, AR_send_copy, AR_finance_char" & _
        "ge, AR_require_PO, AR_credit_hold, AR_accept_check, cust_notes, Taxable, inactiv" & _
        "e, customer_no FROM cust_trtab_main WHERE (cod_customer = @cod_customer)"
        Me.SqlInsertCommand7.Connection = Me.CnnSql
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vip_code", System.Data.SqlDbType.VarChar, 10, "vip_code"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_company", System.Data.SqlDbType.VarChar, 5, "cod_company"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@f_name", System.Data.SqlDbType.VarChar, 20, "f_name"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@m_name", System.Data.SqlDbType.VarChar, 15, "m_name"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@l_name", System.Data.SqlDbType.VarChar, 50, "l_name"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_1", System.Data.SqlDbType.VarChar, 20, "phone_1"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_1", System.Data.SqlDbType.VarChar, 2, "extension_1"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_1", System.Data.SqlDbType.VarChar, 1, "phone_type_1"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_1", System.Data.SqlDbType.Bit, 1, "phone_main_1"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_2", System.Data.SqlDbType.VarChar, 20, "phone_2"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_2", System.Data.SqlDbType.VarChar, 2, "extension_2"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_2", System.Data.SqlDbType.VarChar, 1, "phone_type_2"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_2", System.Data.SqlDbType.Bit, 1, "phone_main_2"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_3", System.Data.SqlDbType.VarChar, 20, "phone_3"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_3", System.Data.SqlDbType.VarChar, 2, "extension_3"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_3", System.Data.SqlDbType.VarChar, 1, "phone_type_3"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_3", System.Data.SqlDbType.Bit, 1, "phone_main_3"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_4", System.Data.SqlDbType.VarChar, 20, "phone_4"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_4", System.Data.SqlDbType.VarChar, 2, "extension_4"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_4", System.Data.SqlDbType.VarChar, 1, "phone_type_4"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_4", System.Data.SqlDbType.Bit, 1, "phone_main_4"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_5", System.Data.SqlDbType.VarChar, 20, "phone_5"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_5", System.Data.SqlDbType.VarChar, 2, "extension_5"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_5", System.Data.SqlDbType.VarChar, 1, "phone_type_5"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_5", System.Data.SqlDbType.Bit, 1, "phone_main_5"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name1", System.Data.SqlDbType.VarChar, 25, "driver_name1"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name2", System.Data.SqlDbType.VarChar, 25, "driver_name2"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name3", System.Data.SqlDbType.VarChar, 25, "driver_name3"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name4", System.Data.SqlDbType.VarChar, 25, "driver_name4"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DriverLicense", System.Data.SqlDbType.VarChar, 10, "DriverLicense"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zip", System.Data.SqlDbType.VarChar, 5, "zip"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 30, "email"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_sales_rep", System.Data.SqlDbType.VarChar, 5, "cod_sales_rep"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@social_security_no", System.Data.SqlDbType.VarChar, 30, "social_security_no"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cust_exempt_tax", System.Data.SqlDbType.Real, 4, "cust_exempt_tax"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@scrap_check", System.Data.SqlDbType.Bit, 1, "scrap_check"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@scrap_value", System.Data.SqlDbType.Real, 4, "scrap_value"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@credit_card_no", System.Data.SqlDbType.VarChar, 20, "credit_card_no"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@expiration_credit_date", System.Data.SqlDbType.VarChar, 10, "expiration_credit_date"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@credit_limited", System.Data.SqlDbType.Real, 4, "credit_limited"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_charge", System.Data.SqlDbType.Bit, 1, "AR_charge"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_term", System.Data.SqlDbType.VarChar, 10, "AR_term"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_sales_tax", System.Data.SqlDbType.VarChar, 2, "cod_sales_tax"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_price", System.Data.SqlDbType.VarChar, 1, "cod_price"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discount", System.Data.SqlDbType.Real, 4, "discount"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_type", System.Data.SqlDbType.VarChar, 1, "cod_type"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_source", System.Data.SqlDbType.VarChar, 1, "cod_source"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_class", System.Data.SqlDbType.VarChar, 1, "cod_class"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_territory", System.Data.SqlDbType.VarChar, 2, "cod_territory"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_sales_report", System.Data.SqlDbType.VarChar, 300, "desc_sales_report"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@user_id", System.Data.SqlDbType.VarChar, 30, "user_id"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@user_password", System.Data.SqlDbType.VarChar, 15, "user_password"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_statement", System.Data.SqlDbType.Bit, 1, "AR_statement"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_send_copy", System.Data.SqlDbType.Bit, 1, "AR_send_copy"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_finance_charge", System.Data.SqlDbType.Bit, 1, "AR_finance_charge"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_require_PO", System.Data.SqlDbType.Bit, 1, "AR_require_PO"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_credit_hold", System.Data.SqlDbType.Bit, 1, "AR_credit_hold"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_accept_check", System.Data.SqlDbType.Bit, 1, "AR_accept_check"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cust_notes", System.Data.SqlDbType.VarChar, 300, "cust_notes"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Taxable", System.Data.SqlDbType.Bit, 1, "Taxable"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@inactive", System.Data.SqlDbType.Bit, 1, "inactive"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@customer_no", System.Data.SqlDbType.VarChar, 20, "customer_no"))
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT cod_customer, vip_code, cod_company, f_name, m_name, l_name, address, phon" & _
        "e_1, extension_1, phone_type_1, phone_main_1, phone_2, extension_2, phone_type_2" & _
        ", phone_main_2, phone_3, extension_3, phone_type_3, phone_main_3, phone_4, exten" & _
        "sion_4, phone_type_4, phone_main_4, phone_5, extension_5, phone_type_5, phone_ma" & _
        "in_5, driver_name1, driver_name2, driver_name3, driver_name4, DriverLicense, zip" & _
        ", email, cod_sales_rep, social_security_no, cust_exempt_tax, scrap_check, scrap_" & _
        "value, credit_card_no, expiration_credit_date, credit_limited, AR_charge, AR_ter" & _
        "m, cod_sales_tax, cod_price, discount, cod_type, cod_source, cod_class, cod_terr" & _
        "itory, desc_sales_report, user_id, user_password, AR_statement, AR_send_copy, AR" & _
        "_finance_charge, AR_require_PO, AR_credit_hold, AR_accept_check, cust_notes, Tax" & _
        "able, inactive, customer_no FROM cust_trtab_main"
        Me.SqlSelectCommand7.Connection = Me.CnnSql
        '
        'SqlUpdateCommand7
        '
        Me.SqlUpdateCommand7.CommandText = "UPDATE cust_trtab_main SET cod_customer = @cod_customer, vip_code = @vip_code, co" & _
        "d_company = @cod_company, f_name = @f_name, m_name = @m_name, l_name = @l_name, " & _
        "address = @address, phone_1 = @phone_1, extension_1 = @extension_1, phone_type_1" & _
        " = @phone_type_1, phone_main_1 = @phone_main_1, phone_2 = @phone_2, extension_2 " & _
        "= @extension_2, phone_type_2 = @phone_type_2, phone_main_2 = @phone_main_2, phon" & _
        "e_3 = @phone_3, extension_3 = @extension_3, phone_type_3 = @phone_type_3, phone_" & _
        "main_3 = @phone_main_3, phone_4 = @phone_4, extension_4 = @extension_4, phone_ty" & _
        "pe_4 = @phone_type_4, phone_main_4 = @phone_main_4, phone_5 = @phone_5, extensio" & _
        "n_5 = @extension_5, phone_type_5 = @phone_type_5, phone_main_5 = @phone_main_5, " & _
        "driver_name1 = @driver_name1, driver_name2 = @driver_name2, driver_name3 = @driv" & _
        "er_name3, driver_name4 = @driver_name4, DriverLicense = @DriverLicense, zip = @z" & _
        "ip, email = @email, cod_sales_rep = @cod_sales_rep, social_security_no = @social" & _
        "_security_no, cust_exempt_tax = @cust_exempt_tax, scrap_check = @scrap_check, sc" & _
        "rap_value = @scrap_value, credit_card_no = @credit_card_no, expiration_credit_da" & _
        "te = @expiration_credit_date, credit_limited = @credit_limited, AR_charge = @AR_" & _
        "charge, AR_term = @AR_term, cod_sales_tax = @cod_sales_tax, cod_price = @cod_pri" & _
        "ce, discount = @discount, cod_type = @cod_type, cod_source = @cod_source, cod_cl" & _
        "ass = @cod_class, cod_territory = @cod_territory, desc_sales_report = @desc_sale" & _
        "s_report, user_id = @user_id, user_password = @user_password, AR_statement = @AR" & _
        "_statement, AR_send_copy = @AR_send_copy, AR_finance_charge = @AR_finance_charge" & _
        ", AR_require_PO = @AR_require_PO, AR_credit_hold = @AR_credit_hold, AR_accept_ch" & _
        "eck = @AR_accept_check, cust_notes = @cust_notes, Taxable = @Taxable, inactive =" & _
        " @inactive, customer_no = @customer_no WHERE (cod_customer = @Original_cod_custo" & _
        "mer) AND (AR_accept_check = @Original_AR_accept_check OR @Original_AR_accept_che" & _
        "ck IS NULL AND AR_accept_check IS NULL) AND (AR_charge = @Original_AR_charge OR " & _
        "@Original_AR_charge IS NULL AND AR_charge IS NULL) AND (AR_credit_hold = @Origin" & _
        "al_AR_credit_hold OR @Original_AR_credit_hold IS NULL AND AR_credit_hold IS NULL" & _
        ") AND (AR_finance_charge = @Original_AR_finance_charge OR @Original_AR_finance_c" & _
        "harge IS NULL AND AR_finance_charge IS NULL) AND (AR_require_PO = @Original_AR_r" & _
        "equire_PO OR @Original_AR_require_PO IS NULL AND AR_require_PO IS NULL) AND (AR_" & _
        "send_copy = @Original_AR_send_copy OR @Original_AR_send_copy IS NULL AND AR_send" & _
        "_copy IS NULL) AND (AR_statement = @Original_AR_statement OR @Original_AR_statem" & _
        "ent IS NULL AND AR_statement IS NULL) AND (AR_term = @Original_AR_term OR @Origi" & _
        "nal_AR_term IS NULL AND AR_term IS NULL) AND (DriverLicense = @Original_DriverLi" & _
        "cense OR @Original_DriverLicense IS NULL AND DriverLicense IS NULL) AND (Taxable" & _
        " = @Original_Taxable OR @Original_Taxable IS NULL AND Taxable IS NULL) AND (addr" & _
        "ess = @Original_address OR @Original_address IS NULL AND address IS NULL) AND (c" & _
        "od_class = @Original_cod_class OR @Original_cod_class IS NULL AND cod_class IS N" & _
        "ULL) AND (cod_company = @Original_cod_company OR @Original_cod_company IS NULL A" & _
        "ND cod_company IS NULL) AND (cod_price = @Original_cod_price OR @Original_cod_pr" & _
        "ice IS NULL AND cod_price IS NULL) AND (cod_sales_rep = @Original_cod_sales_rep " & _
        "OR @Original_cod_sales_rep IS NULL AND cod_sales_rep IS NULL) AND (cod_sales_tax" & _
        " = @Original_cod_sales_tax OR @Original_cod_sales_tax IS NULL AND cod_sales_tax " & _
        "IS NULL) AND (cod_source = @Original_cod_source OR @Original_cod_source IS NULL " & _
        "AND cod_source IS NULL) AND (cod_territory = @Original_cod_territory OR @Origina" & _
        "l_cod_territory IS NULL AND cod_territory IS NULL) AND (cod_type = @Original_cod" & _
        "_type OR @Original_cod_type IS NULL AND cod_type IS NULL) AND (credit_card_no = " & _
        "@Original_credit_card_no OR @Original_credit_card_no IS NULL AND credit_card_no " & _
        "IS NULL) AND (credit_limited = @Original_credit_limited OR @Original_credit_limi" & _
        "ted IS NULL AND credit_limited IS NULL) AND (cust_exempt_tax = @Original_cust_ex" & _
        "empt_tax OR @Original_cust_exempt_tax IS NULL AND cust_exempt_tax IS NULL) AND (" & _
        "cust_notes = @Original_cust_notes OR @Original_cust_notes IS NULL AND cust_notes" & _
        " IS NULL) AND (customer_no = @Original_customer_no OR @Original_customer_no IS N" & _
        "ULL AND customer_no IS NULL) AND (desc_sales_report = @Original_desc_sales_repor" & _
        "t OR @Original_desc_sales_report IS NULL AND desc_sales_report IS NULL) AND (dis" & _
        "count = @Original_discount OR @Original_discount IS NULL AND discount IS NULL) A" & _
        "ND (driver_name1 = @Original_driver_name1 OR @Original_driver_name1 IS NULL AND " & _
        "driver_name1 IS NULL) AND (driver_name2 = @Original_driver_name2 OR @Original_dr" & _
        "iver_name2 IS NULL AND driver_name2 IS NULL) AND (driver_name3 = @Original_drive" & _
        "r_name3 OR @Original_driver_name3 IS NULL AND driver_name3 IS NULL) AND (driver_" & _
        "name4 = @Original_driver_name4 OR @Original_driver_name4 IS NULL AND driver_name" & _
        "4 IS NULL) AND (email = @Original_email OR @Original_email IS NULL AND email IS " & _
        "NULL) AND (expiration_credit_date = @Original_expiration_credit_date OR @Origina" & _
        "l_expiration_credit_date IS NULL AND expiration_credit_date IS NULL) AND (extens" & _
        "ion_1 = @Original_extension_1 OR @Original_extension_1 IS NULL AND extension_1 I" & _
        "S NULL) AND (extension_2 = @Original_extension_2 OR @Original_extension_2 IS NUL" & _
        "L AND extension_2 IS NULL) AND (extension_3 = @Original_extension_3 OR @Original" & _
        "_extension_3 IS NULL AND extension_3 IS NULL) AND (extension_4 = @Original_exten" & _
        "sion_4 OR @Original_extension_4 IS NULL AND extension_4 IS NULL) AND (extension_" & _
        "5 = @Original_extension_5 OR @Original_extension_5 IS NULL AND extension_5 IS NU" & _
        "LL) AND (f_name = @Original_f_name OR @Original_f_name IS NULL AND f_name IS NUL" & _
        "L) AND (inactive = @Original_inactive OR @Original_inactive IS NULL AND inactive" & _
        " IS NULL) AND (l_name = @Original_l_name OR @Original_l_name IS NULL AND l_name " & _
        "IS NULL) AND (m_name = @Original_m_name OR @Original_m_name IS NULL AND m_name I" & _
        "S NULL) AND (phone_1 = @Original_phone_1 OR @Original_phone_1 IS NULL AND phone_" & _
        "1 IS NULL) AND (phone_2 = @Original_phone_2 OR @Original_phone_2 IS NULL AND pho" & _
        "ne_2 IS NULL) AND (phone_3 = @Original_phone_3 OR @Original_phone_3 IS NULL AND " & _
        "phone_3 IS NULL) AND (phone_4 = @Original_phone_4 OR @Original_phone_4 IS NULL A" & _
        "ND phone_4 IS NULL) AND (phone_5 = @Original_phone_5 OR @Original_phone_5 IS NUL" & _
        "L AND phone_5 IS NULL) AND (phone_main_1 = @Original_phone_main_1 OR @Original_p" & _
        "hone_main_1 IS NULL AND phone_main_1 IS NULL) AND (phone_main_2 = @Original_phon" & _
        "e_main_2 OR @Original_phone_main_2 IS NULL AND phone_main_2 IS NULL) AND (phone_" & _
        "main_3 = @Original_phone_main_3 OR @Original_phone_main_3 IS NULL AND phone_main" & _
        "_3 IS NULL) AND (phone_main_4 = @Original_phone_main_4 OR @Original_phone_main_4" & _
        " IS NULL AND phone_main_4 IS NULL) AND (phone_main_5 = @Original_phone_main_5 OR" & _
        " @Original_phone_main_5 IS NULL AND phone_main_5 IS NULL) AND (phone_type_1 = @O" & _
        "riginal_phone_type_1 OR @Original_phone_type_1 IS NULL AND phone_type_1 IS NULL)" & _
        " AND (phone_type_2 = @Original_phone_type_2 OR @Original_phone_type_2 IS NULL AN" & _
        "D phone_type_2 IS NULL) AND (phone_type_3 = @Original_phone_type_3 OR @Original_" & _
        "phone_type_3 IS NULL AND phone_type_3 IS NULL) AND (phone_type_4 = @Original_pho" & _
        "ne_type_4 OR @Original_phone_type_4 IS NULL AND phone_type_4 IS NULL) AND (phone" & _
        "_type_5 = @Original_phone_type_5 OR @Original_phone_type_5 IS NULL AND phone_typ" & _
        "e_5 IS NULL) AND (scrap_check = @Original_scrap_check OR @Original_scrap_check I" & _
        "S NULL AND scrap_check IS NULL) AND (scrap_value = @Original_scrap_value OR @Ori" & _
        "ginal_scrap_value IS NULL AND scrap_value IS NULL) AND (social_security_no = @Or" & _
        "iginal_social_security_no OR @Original_social_security_no IS NULL AND social_sec" & _
        "urity_no IS NULL) AND (user_id = @Original_user_id OR @Original_user_id IS NULL " & _
        "AND user_id IS NULL) AND (user_password = @Original_user_password OR @Original_u" & _
        "ser_password IS NULL AND user_password IS NULL) AND (vip_code = @Original_vip_co" & _
        "de OR @Original_vip_code IS NULL AND vip_code IS NULL) AND (zip = @Original_zip " & _
        "OR @Original_zip IS NULL AND zip IS NULL); SELECT cod_customer, vip_code, cod_co" & _
        "mpany, f_name, m_name, l_name, address, phone_1, extension_1, phone_type_1, phon" & _
        "e_main_1, phone_2, extension_2, phone_type_2, phone_main_2, phone_3, extension_3" & _
        ", phone_type_3, phone_main_3, phone_4, extension_4, phone_type_4, phone_main_4, " & _
        "phone_5, extension_5, phone_type_5, phone_main_5, driver_name1, driver_name2, dr" & _
        "iver_name3, driver_name4, DriverLicense, zip, email, cod_sales_rep, social_secur" & _
        "ity_no, cust_exempt_tax, scrap_check, scrap_value, credit_card_no, expiration_cr" & _
        "edit_date, credit_limited, AR_charge, AR_term, cod_sales_tax, cod_price, discoun" & _
        "t, cod_type, cod_source, cod_class, cod_territory, desc_sales_report, user_id, u" & _
        "ser_password, AR_statement, AR_send_copy, AR_finance_charge, AR_require_PO, AR_c" & _
        "redit_hold, AR_accept_check, cust_notes, Taxable, inactive, customer_no FROM cus" & _
        "t_trtab_main WHERE (cod_customer = @cod_customer)"
        Me.SqlUpdateCommand7.Connection = Me.CnnSql
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_customer", System.Data.SqlDbType.VarChar, 10, "cod_customer"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@vip_code", System.Data.SqlDbType.VarChar, 10, "vip_code"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_company", System.Data.SqlDbType.VarChar, 5, "cod_company"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@f_name", System.Data.SqlDbType.VarChar, 20, "f_name"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@m_name", System.Data.SqlDbType.VarChar, 15, "m_name"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@l_name", System.Data.SqlDbType.VarChar, 50, "l_name"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_1", System.Data.SqlDbType.VarChar, 20, "phone_1"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_1", System.Data.SqlDbType.VarChar, 2, "extension_1"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_1", System.Data.SqlDbType.VarChar, 1, "phone_type_1"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_1", System.Data.SqlDbType.Bit, 1, "phone_main_1"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_2", System.Data.SqlDbType.VarChar, 20, "phone_2"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_2", System.Data.SqlDbType.VarChar, 2, "extension_2"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_2", System.Data.SqlDbType.VarChar, 1, "phone_type_2"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_2", System.Data.SqlDbType.Bit, 1, "phone_main_2"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_3", System.Data.SqlDbType.VarChar, 20, "phone_3"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_3", System.Data.SqlDbType.VarChar, 2, "extension_3"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_3", System.Data.SqlDbType.VarChar, 1, "phone_type_3"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_3", System.Data.SqlDbType.Bit, 1, "phone_main_3"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_4", System.Data.SqlDbType.VarChar, 20, "phone_4"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_4", System.Data.SqlDbType.VarChar, 2, "extension_4"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_4", System.Data.SqlDbType.VarChar, 1, "phone_type_4"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_4", System.Data.SqlDbType.Bit, 1, "phone_main_4"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_5", System.Data.SqlDbType.VarChar, 20, "phone_5"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_5", System.Data.SqlDbType.VarChar, 2, "extension_5"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_5", System.Data.SqlDbType.VarChar, 1, "phone_type_5"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_5", System.Data.SqlDbType.Bit, 1, "phone_main_5"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name1", System.Data.SqlDbType.VarChar, 25, "driver_name1"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name2", System.Data.SqlDbType.VarChar, 25, "driver_name2"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name3", System.Data.SqlDbType.VarChar, 25, "driver_name3"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@driver_name4", System.Data.SqlDbType.VarChar, 25, "driver_name4"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DriverLicense", System.Data.SqlDbType.VarChar, 10, "DriverLicense"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zip", System.Data.SqlDbType.VarChar, 5, "zip"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 30, "email"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_sales_rep", System.Data.SqlDbType.VarChar, 5, "cod_sales_rep"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@social_security_no", System.Data.SqlDbType.VarChar, 30, "social_security_no"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cust_exempt_tax", System.Data.SqlDbType.Real, 4, "cust_exempt_tax"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@scrap_check", System.Data.SqlDbType.Bit, 1, "scrap_check"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@scrap_value", System.Data.SqlDbType.Real, 4, "scrap_value"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@credit_card_no", System.Data.SqlDbType.VarChar, 20, "credit_card_no"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@expiration_credit_date", System.Data.SqlDbType.VarChar, 10, "expiration_credit_date"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@credit_limited", System.Data.SqlDbType.Real, 4, "credit_limited"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_charge", System.Data.SqlDbType.Bit, 1, "AR_charge"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_term", System.Data.SqlDbType.VarChar, 10, "AR_term"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_sales_tax", System.Data.SqlDbType.VarChar, 2, "cod_sales_tax"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_price", System.Data.SqlDbType.VarChar, 1, "cod_price"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discount", System.Data.SqlDbType.Real, 4, "discount"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_type", System.Data.SqlDbType.VarChar, 1, "cod_type"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_source", System.Data.SqlDbType.VarChar, 1, "cod_source"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_class", System.Data.SqlDbType.VarChar, 1, "cod_class"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_territory", System.Data.SqlDbType.VarChar, 2, "cod_territory"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_sales_report", System.Data.SqlDbType.VarChar, 300, "desc_sales_report"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@user_id", System.Data.SqlDbType.VarChar, 30, "user_id"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@user_password", System.Data.SqlDbType.VarChar, 15, "user_password"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_statement", System.Data.SqlDbType.Bit, 1, "AR_statement"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_send_copy", System.Data.SqlDbType.Bit, 1, "AR_send_copy"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_finance_charge", System.Data.SqlDbType.Bit, 1, "AR_finance_charge"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_require_PO", System.Data.SqlDbType.Bit, 1, "AR_require_PO"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_credit_hold", System.Data.SqlDbType.Bit, 1, "AR_credit_hold"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@AR_accept_check", System.Data.SqlDbType.Bit, 1, "AR_accept_check"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cust_notes", System.Data.SqlDbType.VarChar, 300, "cust_notes"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Taxable", System.Data.SqlDbType.Bit, 1, "Taxable"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@inactive", System.Data.SqlDbType.Bit, 1, "inactive"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@customer_no", System.Data.SqlDbType.VarChar, 20, "customer_no"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_customer", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_customer", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_accept_check", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_accept_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_charge", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_charge", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_credit_hold", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_credit_hold", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_finance_charge", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_finance_charge", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_require_PO", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_require_PO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_send_copy", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_send_copy", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_statement", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_statement", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_AR_term", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "AR_term", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DriverLicense", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DriverLicense", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Taxable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Taxable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_class", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_class", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_company", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_company", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_price", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_price", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_sales_rep", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_sales_rep", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_sales_tax", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_sales_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_source", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_source", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_territory", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_territory", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_type", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_credit_card_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "credit_card_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_credit_limited", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "credit_limited", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cust_exempt_tax", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_exempt_tax", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cust_notes", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cust_notes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_customer_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "customer_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_sales_report", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_sales_report", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discount", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_driver_name1", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "driver_name1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_driver_name2", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "driver_name2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_driver_name3", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "driver_name3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_driver_name4", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "driver_name4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_expiration_credit_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "expiration_credit_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_1", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_2", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_3", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_4", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_5", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_f_name", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "f_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_inactive", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "inactive", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_l_name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "l_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_m_name", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "m_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_1", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_2", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_3", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_4", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_5", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_1", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_2", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_3", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_4", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_5", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_1", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_2", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_3", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_4", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_5", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_scrap_check", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "scrap_check", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_scrap_value", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "scrap_value", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_social_security_no", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "social_security_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_user_id", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "user_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_user_password", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "user_password", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_vip_code", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "vip_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_zip", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "zip", System.Data.DataRowVersion.Original, Nothing))
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(72, 64)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.ShowPercentage = True
        Me.ProgressBar.Size = New System.Drawing.Size(360, 28)
        Me.ProgressBar.TabIndex = 218
        '
        'daZipCode
        '
        Me.daZipCode.DeleteCommand = Me.SqlDeleteCommand8
        Me.daZipCode.InsertCommand = Me.SqlInsertCommand8
        Me.daZipCode.SelectCommand = Me.SqlSelectCommand8
        Me.daZipCode.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_zipcode", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("city", "city"), New System.Data.Common.DataColumnMapping("county", "county"), New System.Data.Common.DataColumnMapping("state", "state")})})
        Me.daZipCode.UpdateCommand = Me.SqlUpdateCommand8
        '
        'lblWait
        '
        Me.lblWait.BackColor = System.Drawing.Color.Transparent
        Me.lblWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblWait.Location = New System.Drawing.Point(72, 48)
        Me.lblWait.Name = "lblWait"
        Me.lblWait.Size = New System.Drawing.Size(104, 16)
        Me.lblWait.TabIndex = 219
        Me.lblWait.Text = "Please wait ....."
        Me.lblWait.Visible = False
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT zipcode, city, county, state FROM bas_zipcode"
        Me.SqlSelectCommand8.Connection = Me.CnnSql
        '
        'SqlInsertCommand8
        '
        Me.SqlInsertCommand8.CommandText = "INSERT INTO bas_zipcode(zipcode, city, county, state) VALUES (@zipcode, @city, @c" & _
        "ounty, @state); SELECT zipcode, city, county, state FROM bas_zipcode WHERE (zipc" & _
        "ode = @zipcode)"
        Me.SqlInsertCommand8.Connection = Me.CnnSql
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zipcode", System.Data.SqlDbType.VarChar, 5, "zipcode"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@city", System.Data.SqlDbType.VarChar, 30, "city"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@county", System.Data.SqlDbType.VarChar, 30, "county"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@state", System.Data.SqlDbType.VarChar, 2, "state"))
        '
        'SqlUpdateCommand8
        '
        Me.SqlUpdateCommand8.CommandText = "UPDATE bas_zipcode SET zipcode = @zipcode, city = @city, county = @county, state " & _
        "= @state WHERE (zipcode = @Original_zipcode) AND (city = @Original_city OR @Orig" & _
        "inal_city IS NULL AND city IS NULL) AND (county = @Original_county OR @Original_" & _
        "county IS NULL AND county IS NULL) AND (state = @Original_state OR @Original_sta" & _
        "te IS NULL AND state IS NULL); SELECT zipcode, city, county, state FROM bas_zipc" & _
        "ode WHERE (zipcode = @zipcode)"
        Me.SqlUpdateCommand8.Connection = Me.CnnSql
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zipcode", System.Data.SqlDbType.VarChar, 5, "zipcode"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@city", System.Data.SqlDbType.VarChar, 30, "city"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@county", System.Data.SqlDbType.VarChar, 30, "county"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@state", System.Data.SqlDbType.VarChar, 2, "state"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_zipcode", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "zipcode", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_city", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "city", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_county", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "county", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_state", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "state", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand8
        '
        Me.SqlDeleteCommand8.CommandText = "DELETE FROM bas_zipcode WHERE (zipcode = @Original_zipcode) AND (city = @Original" & _
        "_city OR @Original_city IS NULL AND city IS NULL) AND (county = @Original_county" & _
        " OR @Original_county IS NULL AND county IS NULL) AND (state = @Original_state OR" & _
        " @Original_state IS NULL AND state IS NULL)"
        Me.SqlDeleteCommand8.Connection = Me.CnnSql
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_zipcode", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "zipcode", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_city", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "city", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_county", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "county", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_state", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "state", System.Data.DataRowVersion.Original, Nothing))
        '
        'CusConvert
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 104)
        Me.Controls.Add(Me.lblWait)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPath)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CusConvert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Convert"
        CType(Me.DsCus1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim FilePath As String
    Dim ODBCSelect As New System.Data.Odbc.OdbcCommand

    Private Sub CusConvert_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CnnSql.ConnectionString = PConnectionString
    End Sub

    Private Sub txtPath_ButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPath.ButtonClick
        OpenFileDialog1.ShowDialog()
        txtPath.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        'Main Connection String Format For ExcelFiles
        'CnnExcelFile.ConnectionString = "DRIVER=Microsoft Excel Driver (*.xls);UID = admin; UserCommitSync = Yes " & _
        '       "Threads = 3; SafeTransactions = 0; ReadOnly=0; PageTimeout = 5; MaxScanRows = 8 " & _
        '       "MaxBufferSize = 2048; FIL=excel 8.0; DriverId = 790; DefaultDir=D:\11; DBQ=D:\11\CUSTOMERS.xls"
        Dim ZipCode As Object
        lblWait.Visible = True
        Me.Refresh()
        FilePath = txtPath.Text.Trim

        'If CnnSql.State = ConnectionState.Closed Then CnnSql.Open()
        'Dim Tr As SqlClient.SqlTransaction
        'Tr = CnnSql.BeginTransaction
        'daCusTrTabMain.UpdateCommand.Transaction = Tr
        'daCusCompany.UpdateCommand.Transaction = Tr
        'daBasTabPhoneType.UpdateCommand.Transaction = Tr
        'daCusSalesTax.UpdateCommand.Transaction = Tr
        'daCusTabType.UpdateCommand.Transaction = Tr
        'daCusTabSource.UpdateCommand.Transaction = Tr
        'daCusTabClass.UpdateCommand.Transaction = Tr

        Try
            CnnExcelFile.ConnectionString = "DRIVER=Microsoft Excel Driver (*.xls); DBQ=" & FilePath & ""
            daCus.SelectCommand = ODBCSelect
            ODBCSelect.Connection = CnnExcelFile

            'For Check Excel Filename and Path
            ODBCSelect.CommandText = "SELECT Customer, Name, Company, Address1, Address2, City, ST, " & _
                      "ZipCode, Phone, TypeofPhone, Charge, Taxable, SalesTax, CLASS, Type, " & _
                      "Source, CustomerSince, Statement, AcceptCheck, FinanceCharge, VIP, " & _
                      "ARTerms, PriceLevel FROM Customer WHERE Customer Is Not NULL"
            daCus.Fill(DsCus1.Customer)
            '
            DsCus1.Customer.Clear() 'From Excel File
            DsCus1.cust_trtab_main.Clear()
            DsCus1.cust_company.Clear()
            DsCus1.bas_zipcode.Clear()
            DsCus1.bas_tab_phone_type.Clear()
            DsCus1.cust_sales_tax.Clear()
            DsCus1.cust_tab_type.Clear()
            DsCus1.cust_tab_source.Clear()
            DsCus1.cust_tab_class.Clear()

            daZipCode.Fill(DsCus1.bas_zipcode)
            daCusCompany.Fill(DsCus1.cust_company)
            daBasTabPhoneType.Fill(DsCus1.bas_tab_phone_type)
            daCusSalesTax.Fill(DsCus1.cust_sales_tax)
            daCusTabType.Fill(DsCus1.cust_tab_type)
            daCusTabSource.Fill(DsCus1.cust_tab_source)
            daCusTabClass.Fill(DsCus1.cust_tab_class)
            daCusTrTabMain.Fill(DsCus1.cust_trtab_main)

            If DsCus1.cust_trtab_main.Count > 0 Or DsCus1.cust_company.Count > 0 _
                Or DsCus1.bas_tab_phone_type.Count > 0 Or DsCus1.cust_sales_tax.Count > 0 _
                Or DsCus1.cust_tab_type.Count > 0 Or DsCus1.cust_tab_source.Count > 0 _
                Or DsCus1.cust_tab_class.Count > 0 Then
                If MsgBox("Your database has many record for Customers Or tables if you continue, " + Chr(13) + "Convert process your data have been deleted. " + Chr(13) + "Do you want to continue? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Message") = MsgBoxResult.Yes Then
                    For i As Integer = 0 To DsCus1.cust_trtab_main.Count - 1
                        DsCus1.cust_trtab_main.Rows(i).Delete()
                    Next
                    For i As Integer = 0 To DsCus1.cust_company.Count - 1
                        DsCus1.cust_company.Rows(i).Delete()
                    Next
                    For i As Integer = 0 To DsCus1.bas_tab_phone_type.Count - 1
                        DsCus1.bas_tab_phone_type.Rows(i).Delete()
                    Next
                    For i As Integer = 0 To DsCus1.cust_sales_tax.Count - 1
                        DsCus1.cust_sales_tax.Rows(i).Delete()
                    Next
                    For i As Integer = 0 To DsCus1.cust_tab_type.Count - 1
                        DsCus1.cust_tab_type.Rows(i).Delete()
                    Next
                    For i As Integer = 0 To DsCus1.cust_tab_source.Count - 1
                        DsCus1.cust_tab_source.Rows(i).Delete()
                    Next
                    For i As Integer = 0 To DsCus1.cust_tab_class.Count - 1
                        DsCus1.cust_tab_class.Rows(i).Delete()
                    Next
                    daCusTrTabMain.Update(DsCus1.cust_trtab_main)
                    daCusCompany.Update(DsCus1.cust_company)
                    daBasTabPhoneType.Update(DsCus1.bas_tab_phone_type)
                    daCusSalesTax.Update(DsCus1.cust_sales_tax)
                    daCusTabType.Update(DsCus1.cust_tab_type)
                    daCusTabSource.Update(DsCus1.cust_tab_source)
                    daCusTabClass.Update(DsCus1.cust_tab_class)
                    'Tr.Commit()
                Else
                    Exit Sub
                End If
            End If

            'Add ZipCode
            ODBCSelect.CommandText = "SELECT Distinct ZipCode, City, ST  FROM Customer WHERE Customer Is Not NULL " & _
                                     "And ZipCode Is Not NULL"
            daCus.Fill(DsCus1.Customer)
            Dim ZZ, ZipCount As Integer
            ZipCount = DsCus1.Customer.Count
            For ZZ = 0 To ZipCount - 1
                ZipCode = DsCus1.Customer.Rows(ZZ).Item("ZipCode")
                Dim ZipRow As dsCus.bas_zipcodeRow
                If ZipCode Is System.DBNull.Value Then
                    ZipCode = System.DBNull.Value
                Else
                    ZipRow = DsCus1.bas_zipcode.FindByzipcode(ZipCode)
                    If ZipRow Is Nothing Then
                        Dim drZip As DataRow
                        drZip = DsCus1.bas_zipcode.NewRow
                        drZip("zipcode") = DsCus1.Customer.Rows(ZZ).Item("ZipCode")
                        drZip("city") = DsCus1.Customer.Rows(ZZ).Item("City")
                        drZip("state") = DsCus1.Customer.Rows(ZZ).Item("ST")
                        DsCus1.bas_zipcode.Rows.Add(drZip)
                    End If
                End If
            Next

            'Add Company
            DsCus1.Customer.Clear() 'From Excel File
            ODBCSelect.CommandText = "SELECT Distinct Company, ZipCode FROM Customer WHERE Customer Is Not NULL " & _
                                     "And Company Is Not NULL"
            daCus.Fill(DsCus1.Customer)
            Dim CC, ComCount As Integer
            Dim drCom As DataRow
            ComCount = DsCus1.Customer.Count
            For CC = 0 To ComCount - 1
                drCom = DsCus1.cust_company.NewRow
                drCom("cod_company") = Getcod(Str(CC + 1).Trim, 5)
                drCom("complete_name") = Mid(DsCus1.Customer.Rows(CC).Item("Company"), 1, 50)
                drCom("zip_code") = DsCus1.Customer.Rows(CC).Item("ZipCode")
                DsCus1.cust_company.Rows.Add(drCom)
            Next

            'Add Bas_Tab_Phone_Type
            DsCus1.Customer.Clear() 'From Excel File
            ODBCSelect.CommandText = "SELECT Distinct TypeofPhone FROM Customer WHERE Customer Is Not NULL " & _
                                     "And TypeofPhone Is Not NULL"
            daCus.Fill(DsCus1.Customer)
            Dim TP, TPCount As Integer
            Dim drTPhone As DataRow
            TPCount = DsCus1.Customer.Count
            drTPhone = DsCus1.bas_tab_phone_type.NewRow
            drTPhone("cod_type_phone") = "0"
            drTPhone("desc_type_phone") = "     "
            DsCus1.bas_tab_phone_type.Rows.Add(drTPhone)
            For TP = 0 To TPCount - 1
                drTPhone = DsCus1.bas_tab_phone_type.NewRow
                drTPhone("cod_type_phone") = Str(TP + 1).Trim
                drTPhone("desc_type_phone") = Mid(DsCus1.Customer.Rows(TP).Item("TypeofPhone"), 1, 15)
                DsCus1.bas_tab_phone_type.Rows.Add(drTPhone)
            Next

            'Add Cust_Sales_Tax
            DsCus1.Customer.Clear() 'From Excel File
            ODBCSelect.CommandText = "SELECT Distinct SalesTax FROM Customer WHERE Customer Is Not NULL " & _
                                     "And SalesTax Is Not NULL"
            daCus.Fill(DsCus1.Customer)
            Dim ST, STCount As Integer
            Dim drST As DataRow
            STCount = DsCus1.Customer.Count
            drST = DsCus1.cust_sales_tax.NewRow
            drST("cod_sales_tax") = "0"
            drST("desc_sales_tax") = "     "
            drST("Amount") = 0
            DsCus1.cust_sales_tax.Rows.Add(drST)
            For ST = 0 To STCount - 1
                drST = DsCus1.cust_sales_tax.NewRow
                drST("cod_sales_tax") = Getcod(Str(ST + 1).Trim, 2)
                drST("desc_sales_tax") = Mid((DsCus1.Customer.Rows(ST).Item("SalesTax") * 100).ToString + "%", 1, 50)
                drST("Amount") = Val(DsCus1.Customer.Rows(ST).Item("SalesTax")) * 100
                DsCus1.cust_sales_tax.Rows.Add(drST)
            Next

            'Add Cust_Tab_Type
            DsCus1.Customer.Clear() 'From Excel File
            ODBCSelect.CommandText = "SELECT Distinct Type FROM Customer WHERE Customer Is Not NULL " & _
                                     "And Type Is Not NULL"
            daCus.Fill(DsCus1.Customer)
            Dim CP, CPCount As Integer
            Dim drCP As DataRow
            CPCount = DsCus1.Customer.Count
            drCP = DsCus1.cust_tab_type.NewRow
            drCP("cod_type") = "0"
            drCP("desc_type") = "     "
            DsCus1.cust_tab_type.Rows.Add(drCP)
            For CP = 0 To CPCount - 1
                drCP = DsCus1.cust_tab_type.NewRow
                drCP("cod_type") = Str(CP + 1).Trim
                drCP("desc_type") = Mid(DsCus1.Customer.Rows(CP).Item("Type"), 1, 50)
                DsCus1.cust_tab_type.Rows.Add(drCP)
            Next

            'Add Cust_Tab_Source
            DsCus1.Customer.Clear() 'From Excel File
            ODBCSelect.CommandText = "SELECT Distinct Source FROM Customer WHERE Customer Is Not NULL " & _
                                     "And Source Is Not NULL"
            daCus.Fill(DsCus1.Customer)
            Dim CTS, CTSCount As Integer
            Dim drCTS As DataRow
            CTSCount = DsCus1.Customer.Count
            drCTS = DsCus1.cust_tab_source.NewRow
            drCTS("cod_source") = "0"
            drCTS("desc_source") = "     "
            DsCus1.cust_tab_source.Rows.Add(drCTS)
            For CTS = 0 To CTSCount - 1
                drCTS = DsCus1.cust_tab_source.NewRow
                drCTS("cod_source") = Str(CTS + 1).Trim
                drCTS("desc_source") = Mid(DsCus1.Customer.Rows(CTS).Item("Source"), 1, 10)
                DsCus1.cust_tab_source.Rows.Add(drCTS)
            Next

            'Add Cust_Tab_ClASS
            DsCus1.Customer.Clear() 'From Excel File
            ODBCSelect.CommandText = "SELECT Distinct ClASS FROM Customer WHERE Customer Is Not NULL " & _
                                     "And ClASS Is Not NULL"
            daCus.Fill(DsCus1.Customer)
            Dim CL, ClCount As Integer
            Dim drCL As DataRow
            ClCount = DsCus1.Customer.Count
            drCL = DsCus1.cust_tab_class.NewRow
            drCL("cod_class") = "0"
            drCL("desc_class") = "     "
            DsCus1.cust_tab_class.Rows.Add(drCL)
            For CL = 0 To ClCount - 1
                drCL = DsCus1.cust_tab_class.NewRow
                drCL("cod_class") = Str(CL + 1).Trim
                drCL("desc_class") = Mid(DsCus1.Customer.Rows(CL).Item("ClASS"), 1, 50)
                DsCus1.cust_tab_class.Rows.Add(drCL)
            Next

            'Add Customer In cust_trtab_main Table
            DsCus1.Customer.Clear() 'From Excel File
            ODBCSelect.CommandText = "SELECT Customer, Name, Company, Address1, Address2, City, ST, " & _
                       "ZipCode, Phone, TypeofPhone, Charge, Taxable, SalesTax, CLASS, Type, " & _
                       "Source, CustomerSince, Statement, AcceptCheck, FinanceCharge, VIP, " & _
                       "ARTerms, PriceLevel FROM Customer WHERE Customer Is Not NULL"
            daCus.Fill(DsCus1.Customer)
            Dim ICus, CusCount As Integer
            Dim IFind As Integer
            Dim CompanyCode As Object
            Dim Name As String
            Dim Fname As String
            Dim Mname As String
            Dim Lname As String
            Dim TypePhoneCode As Object
            Dim SaleTaxCode As Object
            Dim TypeCod As Object
            Dim SourceCode As Object
            Dim ClassCode As Object
            Dim ARcharge As Object
            Dim ARstatement As Object
            Dim ARfinanceCharge As Object
            Dim ARacceptCheck As Object
            Dim TaxAble As Object
            Dim drCus_xls As DataRow
            Dim drCusMain As DataRow
            DsCus1.cust_company.DefaultView.Sort = "complete_name"
            DsCus1.bas_tab_phone_type.DefaultView.Sort = "desc_type_phone"
            DsCus1.cust_sales_tax.DefaultView.Sort = "desc_sales_tax"
            DsCus1.cust_tab_type.DefaultView.Sort = "desc_type"
            DsCus1.cust_tab_source.DefaultView.Sort = "desc_source"
            DsCus1.cust_tab_class.DefaultView.Sort = "desc_class"

            CusCount = DsCus1.Customer.Count

            Dim Counter As Integer
            Counter = Math.Ceiling(CusCount / 100)
            For ICus = 0 To CusCount - 1
                If ICus Mod Counter = 0 Then
                    ProgressBar.Value = ProgressBar.Value + 1
                    ProgressBar.Refresh()
                    Me.Refresh()
                End If

                drCus_xls = DsCus1.Customer.Rows(ICus)
                Try
                    Name = drCus_xls.Item("Name")
                    Fname = Mid(Name, InStr(Name, ",") + 1).Trim
                    If InStr(Name, ",") <> 0 Then
                        Lname = Mid(Name, 1, InStr(Name, ",") - 1).Trim
                    Else
                        Lname = ""
                    End If
                Catch ex As Exception
                    Fname = ""
                    Lname = ""
                End Try
                '
                IFind = DsCus1.cust_company.DefaultView.Find(drCus_xls.Item("Company"))
                If IFind >= 0 Then
                    CompanyCode = DsCus1.cust_company.DefaultView(IFind).Row.Item("cod_company")
                Else
                    CompanyCode = System.DBNull.Value
                End If
                IFind = DsCus1.bas_tab_phone_type.DefaultView.Find(drCus_xls.Item("TypeofPhone"))
                If IFind >= 0 Then
                    TypePhoneCode = DsCus1.bas_tab_phone_type.DefaultView(IFind).Row.Item("cod_type_phone")
                Else
                    TypePhoneCode = System.DBNull.Value
                End If
                IFind = DsCus1.cust_sales_tax.DefaultView.Find(drCus_xls.Item("SalesTax"))
                If IFind >= 0 Then
                    SaleTaxCode = DsCus1.cust_sales_tax.DefaultView(IFind).Row.Item("cod_sales_tax")
                Else
                    SaleTaxCode = System.DBNull.Value
                End If
                IFind = DsCus1.cust_tab_type.DefaultView.Find(drCus_xls.Item("Type"))
                If IFind >= 0 Then
                    TypeCod = DsCus1.cust_tab_type.DefaultView(IFind).Row.Item("cod_type")
                Else
                    TypeCod = System.DBNull.Value
                End If
                IFind = DsCus1.cust_tab_source.DefaultView.Find(drCus_xls.Item("Source"))
                If IFind >= 0 Then
                    SourceCode = DsCus1.cust_tab_source.DefaultView(IFind).Row.Item("cod_source")
                Else
                    SourceCode = System.DBNull.Value
                End If
                IFind = DsCus1.cust_tab_class.DefaultView.Find(drCus_xls.Item("CLASS"))
                If IFind >= 0 Then
                    ClassCode = DsCus1.cust_tab_class.DefaultView(IFind).Row.Item("cod_class")
                Else
                    ClassCode = System.DBNull.Value
                End If
                Try
                    Select Case (drCus_xls.Item("Charge")).ToString.ToUpper
                        Case "YES"
                            ARcharge = 1
                        Case "NO"
                            ARcharge = 0
                        Case Else
                            ARcharge = System.DBNull.Value
                    End Select
                Catch ex As Exception
                    ARcharge = System.DBNull.Value
                End Try
                Try
                    Select Case (drCus_xls.Item("Statement")).ToString.ToUpper
                        Case "YES"
                            ARstatement = 1
                        Case "NO"
                            ARstatement = 0
                        Case Else
                            ARstatement = System.DBNull.Value
                    End Select
                Catch ex As Exception
                    ARstatement = System.DBNull.Value
                End Try
                Try
                    Select Case (drCus_xls.Item("FinanceCharge")).ToString.ToUpper
                        Case "YES"
                            ARfinanceCharge = 1
                        Case "NO"
                            ARfinanceCharge = 0
                        Case Else
                            ARfinanceCharge = System.DBNull.Value
                    End Select
                Catch ex As Exception
                    ARfinanceCharge = System.DBNull.Value
                End Try
                Try
                    Select Case (drCus_xls.Item("AcceptCheck")).ToString.ToUpper
                        Case "YES"
                            ARacceptCheck = 1
                        Case "NO"
                            ARacceptCheck = 0
                        Case Else
                            ARacceptCheck = System.DBNull.Value
                    End Select
                Catch ex As Exception
                    ARacceptCheck = System.DBNull.Value
                End Try
                Try
                    Select Case (drCus_xls.Item("Taxable")).ToString.ToUpper
                        Case "YES"
                            TaxAble = 1
                        Case "NO"
                            TaxAble = 0
                        Case Else
                            TaxAble = System.DBNull.Value
                    End Select
                Catch ex As Exception
                    TaxAble = System.DBNull.Value
                End Try

                'Add Row In DsCus1.cust_trtab_main
                drCusMain = DsCus1.cust_trtab_main.NewRow
                drCusMain("cod_customer") = drCus_xls.Item("Customer")
                drCusMain("vip_code") = drCus_xls.Item("VIP")
                drCusMain("cod_company") = CompanyCode
                drCusMain("f_name") = Fname
                'drCusMain("m_name") = 
                drCusMain("l_name") = Lname
                drCusMain("address") = drCus_xls.Item("Address1") + " " + drCus_xls.Item("Address2")
                drCusMain("phone_1") = drCus_xls.Item("Phone")
                drCusMain("phone_type_1") = TypePhoneCode
                drCusMain("zip") = drCus_xls.Item("ZipCode")
                drCusMain("AR_term") = drCus_xls.Item("ARTerms")
                drCusMain("cod_sales_tax") = SaleTaxCode
                drCusMain("cod_price") = drCus_xls.Item("PriceLevel")
                drCusMain("cod_type") = TypeCod
                drCusMain("cod_source") = SourceCode
                drCusMain("cod_class") = ClassCode
                drCusMain("AR_charge") = ARcharge
                drCusMain("AR_statement") = ARstatement
                drCusMain("AR_finance_charge") = ARfinanceCharge
                drCusMain("AR_accept_check") = ARacceptCheck
                drCusMain("Taxable") = TaxAble
                DsCus1.cust_trtab_main.Rows.Add(drCusMain)
            Next

            'Update Tables, After Insert Record
            daZipCode.Update(DsCus1.bas_zipcode)
            daCusCompany.Update(DsCus1.cust_company)
            daBasTabPhoneType.Update(DsCus1.bas_tab_phone_type)
            daCusSalesTax.Update(DsCus1.cust_sales_tax)
            daCusTabType.Update(DsCus1.cust_tab_type)
            daCusTabSource.Update(DsCus1.cust_tab_source)
            daCusTabClass.Update(DsCus1.cust_tab_class)
            daCusTrTabMain.Update(DsCus1.cust_trtab_main)
            'Tr.Commit()

            ProgressBar.Value = 100
            MsgBox("The convert process has been completed successfully.", MsgBoxStyle.Information, "Convert System")
            ProgressBar.Value = 0
            lblWait.Visible = False
            ProgressBar.Refresh()

        Catch ex As System.Data.Odbc.OdbcException
            MsgBox("Path or file name is wrong, Try again ...", MsgBoxStyle.Exclamation, "Error")
            'Tr.Rollback()
        Catch ex As Exception
            MsgBox(ex.Message() + "    " + ex.GetType.ToString + "   ", , "btn Convert")
            'Tr.Rollback()
        Finally
            ProgressBar.Value = 0
            ProgressBar.Refresh()
            lblWait.Visible = False
            CnnSql.Close()
        End Try

    End Sub

End Class
