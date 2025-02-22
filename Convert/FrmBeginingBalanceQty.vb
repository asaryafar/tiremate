Imports CommonClass
Public Class FrmBeginingBalanceQty
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
   
    Friend WithEvents CnnExcelFile As System.Data.Odbc.OdbcConnection
    Friend WithEvents OdbcCommand6 As System.Data.Odbc.OdbcCommand

    Friend WithEvents SqlDeleteCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CnnSql As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPath As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Cmdpublic As System.Data.SqlClient.SqlCommand
    Friend WithEvents daInvItem As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents daITQty_xls As System.Data.Odbc.OdbcDataAdapter
    Friend WithEvents OdbcCommand1 As System.Data.Odbc.OdbcCommand
    Friend WithEvents dsItems1 As Convert.dsItems
    Friend WithEvents Pb1 As Janus.Windows.EditControls.UIProgressBar
    Friend WithEvents daInvTabItemWarehouse As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CnnExcelFile = New System.Data.Odbc.OdbcConnection
        Me.OdbcCommand6 = New System.Data.Odbc.OdbcCommand
        Me.SqlDeleteCommand13 = New System.Data.SqlClient.SqlCommand
        Me.CnnSql = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand14 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand15 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand14 = New System.Data.SqlClient.SqlCommand
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPath = New Janus.Windows.GridEX.EditControls.EditBox
        Me.btnConvert = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Cmdpublic = New System.Data.SqlClient.SqlCommand
        Me.daInvItem = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand
        Me.daITQty_xls = New System.Data.Odbc.OdbcDataAdapter
        Me.OdbcCommand1 = New System.Data.Odbc.OdbcCommand
        Me.dsItems1 = New Convert.dsItems
        Me.Pb1 = New Janus.Windows.EditControls.UIProgressBar
        Me.daInvTabItemWarehouse = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        CType(Me.dsItems1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CnnExcelFile
        '
        Me.CnnExcelFile.ConnectionString = "MaxBufferSize=2048;DSN=Excel Files;PageTimeout=5;DefaultDir=D:\convert data;DBQ=D" & _
        ":\convert data\ITQTY01.xls;DriverId=790"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 0
        '
        'txtPath
        '
        Me.txtPath.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.txtPath.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.txtPath.ButtonFont = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtPath.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis
        Me.txtPath.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtPath.Location = New System.Drawing.Point(48, 8)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPath.Size = New System.Drawing.Size(456, 25)
        Me.txtPath.TabIndex = 218
        Me.txtPath.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(9, 47)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(56, 24)
        Me.btnConvert.TabIndex = 220
        Me.btnConvert.Text = "Convert"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 24)
        Me.Label1.TabIndex = 219
        Me.Label1.Text = "Path :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(448, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 24)
        Me.Button1.TabIndex = 221
        Me.Button1.Text = "Close"
        '
        'daInvItem
        '
        Me.daInvItem.DeleteCommand = Me.SqlCommand1
        Me.daInvItem.InsertCommand = Me.SqlCommand2
        Me.daInvItem.SelectCommand = Me.SqlCommand3
        Me.daInvItem.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_item", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("cod_item_type", "cod_item_type"), New System.Data.Common.DataColumnMapping("desc_item", "desc_item"), New System.Data.Common.DataColumnMapping("cod_quick_refrence", "cod_quick_refrence"), New System.Data.Common.DataColumnMapping("taxable", "taxable"), New System.Data.Common.DataColumnMapping("line", "line"), New System.Data.Common.DataColumnMapping("note", "note"), New System.Data.Common.DataColumnMapping("picture", "picture"), New System.Data.Common.DataColumnMapping("upc", "upc"), New System.Data.Common.DataColumnMapping("consignment", "consignment"), New System.Data.Common.DataColumnMapping("discontinued", "discontinued"), New System.Data.Common.DataColumnMapping("discontinued_date", "discontinued_date"), New System.Data.Common.DataColumnMapping("special_notice", "special_notice")})})
        Me.daInvItem.UpdateCommand = Me.SqlCommand4
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "DELETE FROM inv_item WHERE (item_no = @Original_item_no) AND (cod_item_type = @Or" & _
        "iginal_cod_item_type OR @Original_cod_item_type IS NULL AND cod_item_type IS NUL" & _
        "L) AND (cod_quick_refrence = @Original_cod_quick_refrence OR @Original_cod_quick" & _
        "_refrence IS NULL AND cod_quick_refrence IS NULL) AND (consignment = @Original_c" & _
        "onsignment OR @Original_consignment IS NULL AND consignment IS NULL) AND (desc_i" & _
        "tem = @Original_desc_item OR @Original_desc_item IS NULL AND desc_item IS NULL) " & _
        "AND (discontinued = @Original_discontinued OR @Original_discontinued IS NULL AND" & _
        " discontinued IS NULL) AND (discontinued_date = @Original_discontinued_date OR @" & _
        "Original_discontinued_date IS NULL AND discontinued_date IS NULL) AND (line = @O" & _
        "riginal_line OR @Original_line IS NULL AND line IS NULL) AND (note = @Original_n" & _
        "ote OR @Original_note IS NULL AND note IS NULL) AND (special_notice = @Original_" & _
        "special_notice OR @Original_special_notice IS NULL AND special_notice IS NULL) A" & _
        "ND (taxable = @Original_taxable OR @Original_taxable IS NULL AND taxable IS NULL" & _
        ") AND (upc = @Original_upc OR @Original_upc IS NULL AND upc IS NULL)"
        Me.SqlCommand1.Connection = Me.CnnSql
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_item_type", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_item_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_quick_refrence", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_quick_refrence", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_consignment", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "consignment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_item", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_item", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discontinued", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_discontinued_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discontinued_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_line", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "line", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_note", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "note", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_special_notice", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "special_notice", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_taxable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "taxable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_upc", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "upc", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "INSERT INTO inv_item(item_no, cod_item_type, desc_item, cod_quick_refrence, taxab" & _
        "le, line, note, picture, upc, consignment, discontinued, discontinued_date, spec" & _
        "ial_notice) VALUES (@item_no, @cod_item_type, @desc_item, @cod_quick_refrence, @" & _
        "taxable, @line, @note, @picture, @upc, @consignment, @discontinued, @discontinue" & _
        "d_date, @special_notice); SELECT item_no, cod_item_type, desc_item, cod_quick_re" & _
        "frence, taxable, line, note, picture, upc, consignment, discontinued, discontinu" & _
        "ed_date, special_notice FROM inv_item WHERE (item_no = @item_no)"
        Me.SqlCommand2.Connection = Me.CnnSql
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_item_type", System.Data.SqlDbType.VarChar, 2, "cod_item_type"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_item", System.Data.SqlDbType.VarChar, 50, "desc_item"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_quick_refrence", System.Data.SqlDbType.VarChar, 3, "cod_quick_refrence"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@taxable", System.Data.SqlDbType.Bit, 1, "taxable"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@line", System.Data.SqlDbType.VarChar, 30, "line"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@note", System.Data.SqlDbType.VarChar, 300, "note"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@picture", System.Data.SqlDbType.VarBinary, 2147483647, "picture"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@upc", System.Data.SqlDbType.VarChar, 30, "upc"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@consignment", System.Data.SqlDbType.Bit, 1, "consignment"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discontinued", System.Data.SqlDbType.Bit, 1, "discontinued"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discontinued_date", System.Data.SqlDbType.VarChar, 10, "discontinued_date"))
        Me.SqlCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@special_notice", System.Data.SqlDbType.VarChar, 300, "special_notice"))
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = "SELECT item_no, cod_item_type, desc_item, cod_quick_refrence, taxable, line, note" & _
        ", picture, upc, consignment, discontinued, discontinued_date, special_notice FRO" & _
        "M inv_item"
        Me.SqlCommand3.Connection = Me.CnnSql
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = "UPDATE inv_item SET item_no = @item_no, cod_item_type = @cod_item_type, desc_item" & _
        " = @desc_item, cod_quick_refrence = @cod_quick_refrence, taxable = @taxable, lin" & _
        "e = @line, note = @note, picture = @picture, upc = @upc, consignment = @consignm" & _
        "ent, discontinued = @discontinued, discontinued_date = @discontinued_date, speci" & _
        "al_notice = @special_notice WHERE (item_no = @Original_item_no) AND (cod_item_ty" & _
        "pe = @Original_cod_item_type OR @Original_cod_item_type IS NULL AND cod_item_typ" & _
        "e IS NULL) AND (cod_quick_refrence = @Original_cod_quick_refrence OR @Original_c" & _
        "od_quick_refrence IS NULL AND cod_quick_refrence IS NULL) AND (consignment = @Or" & _
        "iginal_consignment OR @Original_consignment IS NULL AND consignment IS NULL) AND" & _
        " (desc_item = @Original_desc_item OR @Original_desc_item IS NULL AND desc_item I" & _
        "S NULL) AND (discontinued = @Original_discontinued OR @Original_discontinued IS " & _
        "NULL AND discontinued IS NULL) AND (discontinued_date = @Original_discontinued_d" & _
        "ate OR @Original_discontinued_date IS NULL AND discontinued_date IS NULL) AND (l" & _
        "ine = @Original_line OR @Original_line IS NULL AND line IS NULL) AND (note = @Or" & _
        "iginal_note OR @Original_note IS NULL AND note IS NULL) AND (special_notice = @O" & _
        "riginal_special_notice OR @Original_special_notice IS NULL AND special_notice IS" & _
        " NULL) AND (taxable = @Original_taxable OR @Original_taxable IS NULL AND taxable" & _
        " IS NULL) AND (upc = @Original_upc OR @Original_upc IS NULL AND upc IS NULL); SE" & _
        "LECT item_no, cod_item_type, desc_item, cod_quick_refrence, taxable, line, note," & _
        " picture, upc, consignment, discontinued, discontinued_date, special_notice FROM" & _
        " inv_item WHERE (item_no = @item_no)"
        Me.SqlCommand4.Connection = Me.CnnSql
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_item_type", System.Data.SqlDbType.VarChar, 2, "cod_item_type"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_item", System.Data.SqlDbType.VarChar, 50, "desc_item"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_quick_refrence", System.Data.SqlDbType.VarChar, 3, "cod_quick_refrence"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@taxable", System.Data.SqlDbType.Bit, 1, "taxable"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@line", System.Data.SqlDbType.VarChar, 30, "line"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@note", System.Data.SqlDbType.VarChar, 300, "note"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@picture", System.Data.SqlDbType.VarBinary, 2147483647, "picture"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@upc", System.Data.SqlDbType.VarChar, 30, "upc"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@consignment", System.Data.SqlDbType.Bit, 1, "consignment"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discontinued", System.Data.SqlDbType.Bit, 1, "discontinued"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@discontinued_date", System.Data.SqlDbType.VarChar, 10, "discontinued_date"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@special_notice", System.Data.SqlDbType.VarChar, 300, "special_notice"))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_item_type", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_item_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_quick_refrence", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_quick_refrence", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_consignment", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "consignment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_item", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_item", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discontinued", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_discontinued_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "discontinued_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_line", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "line", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_note", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "note", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_special_notice", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "special_notice", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_taxable", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "taxable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_upc", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "upc", System.Data.DataRowVersion.Original, Nothing))
        '
        'daITQty_xls
        '
        Me.daITQty_xls.SelectCommand = Me.OdbcCommand1
        Me.daITQty_xls.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Brand", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Brand", "Brand"), New System.Data.Common.DataColumnMapping("Description", "Description")})})
        '
        'OdbcCommand1
        '
        Me.OdbcCommand1.Connection = Me.CnnExcelFile
        '
        'dsItems1
        '
        Me.dsItems1.DataSetName = "dsItems"
        Me.dsItems1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Pb1
        '
        Me.Pb1.Location = New System.Drawing.Point(80, 48)
        Me.Pb1.Name = "Pb1"
        Me.Pb1.Size = New System.Drawing.Size(360, 16)
        Me.Pb1.TabIndex = 222
        Me.Pb1.Text = "UiProgressBar1"
        '
        'daInvTabItemWarehouse
        '
        Me.daInvTabItemWarehouse.DeleteCommand = Me.SqlDeleteCommand2
        Me.daInvTabItemWarehouse.InsertCommand = Me.SqlInsertCommand2
        Me.daInvTabItemWarehouse.SelectCommand = Me.SqlSelectCommand2
        Me.daInvTabItemWarehouse.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_item_warehouse", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("item_no", "item_no"), New System.Data.Common.DataColumnMapping("cod_warehouse", "cod_warehouse"), New System.Data.Common.DataColumnMapping("cod_location", "cod_location"), New System.Data.Common.DataColumnMapping("on_hand", "on_hand"), New System.Data.Common.DataColumnMapping("comitted", "comitted"), New System.Data.Common.DataColumnMapping("on_order", "on_order"), New System.Data.Common.DataColumnMapping("min_stock", "min_stock"), New System.Data.Common.DataColumnMapping("max_stock", "max_stock"), New System.Data.Common.DataColumnMapping("reorde", "reorde"), New System.Data.Common.DataColumnMapping("Begining_Balance_Qty", "Begining_Balance_Qty")})})
        Me.daInvTabItemWarehouse.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM inv_tab_item_warehouse WHERE (cod_warehouse = @Original_cod_warehouse" & _
        ") AND (item_no = @Original_item_no) AND (Begining_Balance_Qty = @Original_Begini" & _
        "ng_Balance_Qty OR @Original_Begining_Balance_Qty IS NULL AND Begining_Balance_Qt" & _
        "y IS NULL) AND (cod_location = @Original_cod_location OR @Original_cod_location " & _
        "IS NULL AND cod_location IS NULL) AND (comitted = @Original_comitted OR @Origina" & _
        "l_comitted IS NULL AND comitted IS NULL) AND (max_stock = @Original_max_stock OR" & _
        " @Original_max_stock IS NULL AND max_stock IS NULL) AND (min_stock = @Original_m" & _
        "in_stock OR @Original_min_stock IS NULL AND min_stock IS NULL) AND (on_hand = @O" & _
        "riginal_on_hand OR @Original_on_hand IS NULL AND on_hand IS NULL) AND (on_order " & _
        "= @Original_on_order OR @Original_on_order IS NULL AND on_order IS NULL) AND (re" & _
        "orde = @Original_reorde OR @Original_reorde IS NULL AND reorde IS NULL)"
        Me.SqlDeleteCommand2.Connection = Me.CnnSql
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_warehouse", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_warehouse", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Begining_Balance_Qty", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Begining_Balance_Qty", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_location", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_location", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_comitted", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "comitted", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_max_stock", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "max_stock", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_min_stock", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "min_stock", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_on_hand", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "on_hand", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_on_order", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "on_order", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_reorde", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "reorde", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO inv_tab_item_warehouse(item_no, cod_warehouse, cod_location, on_hand," & _
        " comitted, on_order, min_stock, max_stock, reorde, Begining_Balance_Qty) VALUES " & _
        "(@item_no, @cod_warehouse, @cod_location, @on_hand, @comitted, @on_order, @min_s" & _
        "tock, @max_stock, @reorde, @Begining_Balance_Qty); SELECT item_no, cod_warehouse" & _
        ", cod_location, on_hand, comitted, on_order, min_stock, max_stock, reorde, Begin" & _
        "ing_Balance_Qty FROM inv_tab_item_warehouse WHERE (cod_warehouse = @cod_warehous" & _
        "e) AND (item_no = @item_no)"
        Me.SqlInsertCommand2.Connection = Me.CnnSql
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_warehouse", System.Data.SqlDbType.VarChar, 1, "cod_warehouse"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_location", System.Data.SqlDbType.VarChar, 6, "cod_location"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@on_hand", System.Data.SqlDbType.Real, 4, "on_hand"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@comitted", System.Data.SqlDbType.Real, 4, "comitted"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@on_order", System.Data.SqlDbType.Real, 4, "on_order"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@min_stock", System.Data.SqlDbType.Real, 4, "min_stock"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@max_stock", System.Data.SqlDbType.Real, 4, "max_stock"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@reorde", System.Data.SqlDbType.Real, 4, "reorde"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Begining_Balance_Qty", System.Data.SqlDbType.Real, 4, "Begining_Balance_Qty"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT item_no, cod_warehouse, cod_location, on_hand, comitted, on_order, min_sto" & _
        "ck, max_stock, reorde, Begining_Balance_Qty FROM inv_tab_item_warehouse"
        Me.SqlSelectCommand2.Connection = Me.CnnSql
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE inv_tab_item_warehouse SET item_no = @item_no, cod_warehouse = @cod_wareho" & _
        "use, cod_location = @cod_location, on_hand = @on_hand, comitted = @comitted, on_" & _
        "order = @on_order, min_stock = @min_stock, max_stock = @max_stock, reorde = @reo" & _
        "rde, Begining_Balance_Qty = @Begining_Balance_Qty WHERE (cod_warehouse = @Origin" & _
        "al_cod_warehouse) AND (item_no = @Original_item_no) AND (Begining_Balance_Qty = " & _
        "@Original_Begining_Balance_Qty OR @Original_Begining_Balance_Qty IS NULL AND Beg" & _
        "ining_Balance_Qty IS NULL) AND (cod_location = @Original_cod_location OR @Origin" & _
        "al_cod_location IS NULL AND cod_location IS NULL) AND (comitted = @Original_comi" & _
        "tted OR @Original_comitted IS NULL AND comitted IS NULL) AND (max_stock = @Origi" & _
        "nal_max_stock OR @Original_max_stock IS NULL AND max_stock IS NULL) AND (min_sto" & _
        "ck = @Original_min_stock OR @Original_min_stock IS NULL AND min_stock IS NULL) A" & _
        "ND (on_hand = @Original_on_hand OR @Original_on_hand IS NULL AND on_hand IS NULL" & _
        ") AND (on_order = @Original_on_order OR @Original_on_order IS NULL AND on_order " & _
        "IS NULL) AND (reorde = @Original_reorde OR @Original_reorde IS NULL AND reorde I" & _
        "S NULL); SELECT item_no, cod_warehouse, cod_location, on_hand, comitted, on_orde" & _
        "r, min_stock, max_stock, reorde, Begining_Balance_Qty FROM inv_tab_item_warehous" & _
        "e WHERE (cod_warehouse = @cod_warehouse) AND (item_no = @item_no)"
        Me.SqlUpdateCommand2.Connection = Me.CnnSql
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@item_no", System.Data.SqlDbType.VarChar, 20, "item_no"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_warehouse", System.Data.SqlDbType.VarChar, 1, "cod_warehouse"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_location", System.Data.SqlDbType.VarChar, 6, "cod_location"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@on_hand", System.Data.SqlDbType.Real, 4, "on_hand"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@comitted", System.Data.SqlDbType.Real, 4, "comitted"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@on_order", System.Data.SqlDbType.Real, 4, "on_order"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@min_stock", System.Data.SqlDbType.Real, 4, "min_stock"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@max_stock", System.Data.SqlDbType.Real, 4, "max_stock"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@reorde", System.Data.SqlDbType.Real, 4, "reorde"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Begining_Balance_Qty", System.Data.SqlDbType.Real, 4, "Begining_Balance_Qty"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_warehouse", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_warehouse", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_item_no", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "item_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Begining_Balance_Qty", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Begining_Balance_Qty", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_location", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_location", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_comitted", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "comitted", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_max_stock", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "max_stock", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_min_stock", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "min_stock", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_on_hand", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "on_hand", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_on_order", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "on_order", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_reorde", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "reorde", System.Data.DataRowVersion.Original, Nothing))
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Please select the path of Excel Files ...."
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'FrmBeginingBalanceQty
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(520, 78)
        Me.Controls.Add(Me.Pb1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmBeginingBalanceQty"
        Me.Text = "Begining Qty Balance"
        CType(Me.dsItems1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ODBCSelect As New System.Data.Odbc.OdbcCommand
    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        End Sub
    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        Try

            Dim ITCount As Decimal, It As Decimal
            Dim UpdatedOnHand As Boolean
            Dim ItemNo As String
            If txtPath.Text.Trim = "" Then
                MsgBox("Please select path of your exel Files")
                Exit Sub
            End If
            '--------------
            dsItems1.Clear()
            daInvTabItemWarehouse.Fill(dsItems1.inv_tab_item_warehouse)
            CnnExcelFile.ConnectionString = "DRIVER=Microsoft Excel Driver (*.xls); DBQ=" & txtPath.Text.Trim & "\ITQTY01.xls"
            ' CnnExcelFile.ConnectionString = "MaxBufferSize=2048;DSN=Excel Files;PageTimeout=5;DefaultDir=D:\convert data;DBQ=D:\convert data\ITQTY01.xls;DriverId=790"
            daITQty_xls.SelectCommand = ODBCSelect
            ODBCSelect.Connection = CnnExcelFile
            dsItems1.ITQty.Clear()
            ODBCSelect.CommandText = "SELECT `Item No`, DESCRIPTION, LOCATION, QTY FROM ITQty WHERE `Item No` Is Not Null"
            daITQty_xls.Fill(dsItems1.ITQty)
            '--------------
            dsItems1.ITQty.DefaultView.Sort = "Item No"
            daInvItem.Fill(dsItems1, "a")
            ITCount = dsItems1.Tables("a").Rows.Count
            Dim DR4 As dsItems.ITQtyRow
            Dim FindITQty As Int16
            Dim OnHand As Decimal = 0
            Pb1.Maximum = ITCount
            Pb1.Minimum = 0
            Pb1.Visible = True
            For It = 0 To ITCount - 1
                Pb1.Value = It
                '------------------------------------------------------------------'
                'Add inv_tab_item_warehouse
                'From Excel File, Items Listing Duncan Tire.xls
                UpdatedOnHand = True
                ItemNo = dsItems1.Tables("a").Rows(It).Item("item_no")
                DR4 = dsItems1.ITQty.FindByItem_No(ItemNo)
                FindITQty = dsItems1.ITQty.DefaultView.Find(ItemNo)

                If DR4 Is Nothing Then
                    OnHand = 0
                    UpdatedOnHand = False
                Else
                    OnHand = DR4.Item("QTY")
                    If OnHand < 0 Then
                        OnHand = 0
                    End If
                End If
                'Dim drIW As DataRow
                Dim drIW As dsItems.inv_tab_item_warehouseRow = dsItems1.inv_tab_item_warehouse.FindByitem_nocod_warehouse(ItemNo, "1")
                Dim flgadditem As Boolean = False
                If drIW Is Nothing Then
                    '                drIW = dsItems1.inv_tab_item_warehouse.NewRow
                    flgadditem = True
                Else
                    flgadditem = False
                    If UpdatedOnHand = True Then
                        drIW("Begining_Balance_Qty") = OnHand
                    End If
                End If
            Next
            '    daInvTabItemWarehouse.Update(dsItems1.inv_tab_item_warehouse)
            MsgFar("convert complete")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Pb1.Visible = False
        daInvTabItemWarehouse.Update(dsItems1.inv_tab_item_warehouse)
    End Sub
    Private Sub FrmBeginingBalanceQty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CnnSql.ConnectionString = PConnectionString
        Cmdpublic.Connection = CnnSql
        Call FixthisDatabase()
        Pb1.Visible = False
    End Sub
    Sub FixthisDatabase()
        Cmdpublic.CommandText = " alter table inv_tab_item_warehouse add Begining_Balance_Qty Real "
        If Cmdpublic.Connection.State <> ConnectionState.Open Then
            Cmdpublic.Connection.Open()
        End If
        Try
            Cmdpublic.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Cmdpublic.CommandText = " update inv_tab_item_warehouse set Begining_Balance_Qty =0 where  Begining_Balance_Qty is null "
        Try
            Cmdpublic.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            Cmdpublic.Connection.Close()
        End Try
    End Sub
    Private Sub txtPath_ButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPath.ButtonClick
        FolderBrowserDialog1.ShowDialog()
        txtPath.Text = FolderBrowserDialog1.SelectedPath
    End Sub
End Class
