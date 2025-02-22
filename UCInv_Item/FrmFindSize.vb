Imports CommonClass
Public Class FrmFindSize
    Inherits FrmBase
    Dim PanelGridHeightVar As Integer
    Dim FormHeightVar As Integer
    Public Cod_customerParameter As String
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
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents DAbas_vehicle_company As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Cmbcod_make As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbcod_vehicle_type As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cmbcod_model As System.Windows.Forms.ComboBox
    Friend WithEvents DsFrmFindSize1 As UCInv_Item.DSFrmFindSize
    Friend WithEvents DAinv_tab_vehicle_type As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAbas_vehicle_model As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DAbas_vehicle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents CmbMake_Year As System.Windows.Forms.ComboBox
    Friend WithEvents BtnShowSize As System.Windows.Forms.Button
    Friend WithEvents LblSize As System.Windows.Forms.TextBox
    Friend WithEvents BtnPriceTheSize As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblOption As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmFindSize))
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.DAbas_vehicle_company = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Cmbcod_make = New System.Windows.Forms.ComboBox
        Me.DsFrmFindSize1 = New UCInv_Item.DSFrmFindSize
        Me.Cmbcod_vehicle_type = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Cmbcod_model = New System.Windows.Forms.ComboBox
        Me.DAinv_tab_vehicle_type = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DAbas_vehicle_model = New System.Data.SqlClient.SqlDataAdapter
        Me.CmbMake_Year = New System.Windows.Forms.ComboBox
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DAbas_vehicle = New System.Data.SqlClient.SqlDataAdapter
        Me.BtnShowSize = New System.Windows.Forms.Button
        Me.LblSize = New System.Windows.Forms.TextBox
        Me.BtnPriceTheSize = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblOption = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        CType(Me.DsFrmFindSize1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=ARMANDEH4;packet size=4096;user id=sa;data source=armandehxp;persi" & _
        "st security info=True;initial catalog=TireMate_04"
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(312, 62)
        Me.Panel1.TabIndex = 366
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(92, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(216, 58)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Find Tire Size That Fit Your Vehicle"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 58)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'DAbas_vehicle_company
        '
        Me.DAbas_vehicle_company.SelectCommand = Me.SqlCommand1
        Me.DAbas_vehicle_company.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_vehicle_company", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_make", "cod_make"), New System.Data.Common.DataColumnMapping("desc_make", "desc_make")})})
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = "SELECT desc_make, cod_make, EnterByUser FROM bas_vehicle_company"
        Me.SqlCommand1.Connection = Me.Cnn
        '
        'Cmbcod_make
        '
        Me.Cmbcod_make.BackColor = System.Drawing.SystemColors.Window
        Me.Cmbcod_make.DataSource = Me.DsFrmFindSize1.bas_vehicle_company
        Me.Cmbcod_make.DisplayMember = "desc_make"
        Me.Cmbcod_make.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbcod_make.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Cmbcod_make.ItemHeight = 13
        Me.Cmbcod_make.Location = New System.Drawing.Point(80, 66)
        Me.Cmbcod_make.Name = "Cmbcod_make"
        Me.Cmbcod_make.Size = New System.Drawing.Size(163, 21)
        Me.Cmbcod_make.TabIndex = 0
        Me.Cmbcod_make.ValueMember = "cod_make"
        '
        'DsFrmFindSize1
        '
        Me.DsFrmFindSize1.DataSetName = "DSFrmFindSize"
        Me.DsFrmFindSize1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Cmbcod_vehicle_type
        '
        Me.Cmbcod_vehicle_type.BackColor = System.Drawing.SystemColors.Window
        Me.Cmbcod_vehicle_type.DataSource = Me.DsFrmFindSize1.inv_tab_vehicle_type
        Me.Cmbcod_vehicle_type.DisplayMember = "desc_vehicle_type"
        Me.Cmbcod_vehicle_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbcod_vehicle_type.Enabled = False
        Me.Cmbcod_vehicle_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Cmbcod_vehicle_type.ItemHeight = 13
        Me.Cmbcod_vehicle_type.Location = New System.Drawing.Point(80, 142)
        Me.Cmbcod_vehicle_type.Name = "Cmbcod_vehicle_type"
        Me.Cmbcod_vehicle_type.Size = New System.Drawing.Size(178, 21)
        Me.Cmbcod_vehicle_type.TabIndex = 3
        Me.Cmbcod_vehicle_type.ValueMember = "cod_vehicle_type"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(6, 144)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 14)
        Me.Label13.TabIndex = 374
        Me.Label13.Text = "Option"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(7, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 14)
        Me.Label5.TabIndex = 373
        Me.Label5.Text = "Model"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(7, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 14)
        Me.Label3.TabIndex = 372
        Me.Label3.Text = "Make"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(7, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 14)
        Me.Label2.TabIndex = 371
        Me.Label2.Text = "Year"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cmbcod_model
        '
        Me.Cmbcod_model.BackColor = System.Drawing.SystemColors.Window
        Me.Cmbcod_model.DataSource = Me.DsFrmFindSize1.bas_vehicle_model
        Me.Cmbcod_model.DisplayMember = "desc_model"
        Me.Cmbcod_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbcod_model.Enabled = False
        Me.Cmbcod_model.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Cmbcod_model.ItemHeight = 13
        Me.Cmbcod_model.Location = New System.Drawing.Point(80, 91)
        Me.Cmbcod_model.Name = "Cmbcod_model"
        Me.Cmbcod_model.Size = New System.Drawing.Size(180, 21)
        Me.Cmbcod_model.TabIndex = 1
        Me.Cmbcod_model.ValueMember = "cod_model"
        '
        'DAinv_tab_vehicle_type
        '
        Me.DAinv_tab_vehicle_type.SelectCommand = Me.SqlCommand7
        Me.DAinv_tab_vehicle_type.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "inv_tab_vehicle_type", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_vehicle_type", "cod_vehicle_type"), New System.Data.Common.DataColumnMapping("desc_vehicle_type", "desc_vehicle_type")})})
        '
        'SqlCommand7
        '
        Me.SqlCommand7.CommandText = "SELECT inv_tab_vehicle_type.desc_vehicle_type, inv_tab_vehicle_type.cod_vehicle_t" & _
        "ype FROM bas_vehicle INNER JOIN inv_tab_vehicle_type ON bas_vehicle.options = in" & _
        "v_tab_vehicle_type.cod_vehicle_type WHERE (bas_vehicle.cod_make = @cod_make) AND" & _
        " (bas_vehicle.cod_model = @cod_model) AND (bas_vehicle.make_year = @Make_Year)"
        Me.SqlCommand7.Connection = Me.Cnn
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_make", System.Data.SqlDbType.VarChar, 3, "cod_make"))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_model", System.Data.SqlDbType.VarChar, 3, "cod_model"))
        Me.SqlCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Make_Year", System.Data.SqlDbType.VarChar, 4, "make_year"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT cod_model, desc_model FROM bas_vehicle_model WHERE (cod_make = @cod_make) " & _
        "AND (EnterByUser = 1)"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        Me.SqlSelectCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_make", System.Data.SqlDbType.VarChar, 3, "cod_make"))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO bas_vehicle_model(cod_make, cod_model, desc_model) VALUES (@cod_make," & _
        " @cod_model, @desc_model); SELECT cod_make, cod_model, desc_model FROM bas_vehic" & _
        "le_model WHERE (cod_make = @cod_make) AND (cod_model = @cod_model)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_make", System.Data.SqlDbType.VarChar, 3, "cod_make"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_model", System.Data.SqlDbType.VarChar, 3, "cod_model"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_model", System.Data.SqlDbType.VarChar, 50, "desc_model"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE bas_vehicle_model SET cod_make = @cod_make, cod_model = @cod_model, desc_m" & _
        "odel = @desc_model WHERE (cod_make = @Original_cod_make) AND (cod_model = @Origi" & _
        "nal_cod_model) AND (desc_model = @Original_desc_model OR @Original_desc_model IS" & _
        " NULL AND desc_model IS NULL); SELECT cod_make, cod_model, desc_model FROM bas_v" & _
        "ehicle_model WHERE (cod_make = @cod_make) AND (cod_model = @cod_model)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_make", System.Data.SqlDbType.VarChar, 3, "cod_make"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_model", System.Data.SqlDbType.VarChar, 3, "cod_model"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@desc_model", System.Data.SqlDbType.VarChar, 50, "desc_model"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_make", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_make", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_model", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_model", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_model", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_model", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM bas_vehicle_model WHERE (cod_make = @Original_cod_make) AND (cod_mode" & _
        "l = @Original_cod_model) AND (desc_model = @Original_desc_model OR @Original_des" & _
        "c_model IS NULL AND desc_model IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_make", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_make", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_model", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_model", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_desc_model", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "desc_model", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAbas_vehicle_model
        '
        Me.DAbas_vehicle_model.DeleteCommand = Me.SqlDeleteCommand1
        Me.DAbas_vehicle_model.InsertCommand = Me.SqlInsertCommand1
        Me.DAbas_vehicle_model.SelectCommand = Me.SqlSelectCommand1
        Me.DAbas_vehicle_model.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_vehicle_model", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_make", "cod_make"), New System.Data.Common.DataColumnMapping("cod_model", "cod_model"), New System.Data.Common.DataColumnMapping("desc_model", "desc_model")})})
        Me.DAbas_vehicle_model.UpdateCommand = Me.SqlUpdateCommand1
        '
        'CmbMake_Year
        '
        Me.CmbMake_Year.BackColor = System.Drawing.SystemColors.Window
        Me.CmbMake_Year.DataSource = Me.DsFrmFindSize1.bas_vehicle
        Me.CmbMake_Year.DisplayMember = "make_year"
        Me.CmbMake_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMake_Year.Enabled = False
        Me.CmbMake_Year.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CmbMake_Year.ItemHeight = 13
        Me.CmbMake_Year.Location = New System.Drawing.Point(80, 117)
        Me.CmbMake_Year.Name = "CmbMake_Year"
        Me.CmbMake_Year.Size = New System.Drawing.Size(86, 21)
        Me.CmbMake_Year.TabIndex = 2
        Me.CmbMake_Year.ValueMember = "make_year"
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT DISTINCT make_year FROM bas_vehicle WHERE (cod_make = @cod_make) AND (cod_" & _
        "model = @cod_model)"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_make", System.Data.SqlDbType.VarChar, 3, "cod_make"))
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_model", System.Data.SqlDbType.VarChar, 3, "cod_model"))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO bas_vehicle(cod_vehicle, cod_make, cod_model, make_year, options) VAL" & _
        "UES (@cod_vehicle, @cod_make, @cod_model, @make_year, @options); SELECT cod_vehi" & _
        "cle, cod_make, cod_model, make_year, options FROM bas_vehicle WHERE (cod_vehicle" & _
        " = @cod_vehicle)"
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vehicle", System.Data.SqlDbType.VarChar, 4, "cod_vehicle"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_make", System.Data.SqlDbType.VarChar, 3, "cod_make"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_model", System.Data.SqlDbType.VarChar, 3, "cod_model"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@make_year", System.Data.SqlDbType.VarChar, 4, "make_year"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@options", System.Data.SqlDbType.VarChar, 1, "options"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE bas_vehicle SET cod_vehicle = @cod_vehicle, cod_make = @cod_make, cod_mode" & _
        "l = @cod_model, make_year = @make_year, options = @options WHERE (cod_vehicle = " & _
        "@Original_cod_vehicle) AND (cod_make = @Original_cod_make) AND (cod_model = @Ori" & _
        "ginal_cod_model) AND (make_year = @Original_make_year) AND (options = @Original_" & _
        "options OR @Original_options IS NULL AND options IS NULL); SELECT cod_vehicle, c" & _
        "od_make, cod_model, make_year, options FROM bas_vehicle WHERE (cod_vehicle = @co" & _
        "d_vehicle)"
        Me.SqlUpdateCommand2.Connection = Me.Cnn
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_vehicle", System.Data.SqlDbType.VarChar, 4, "cod_vehicle"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_make", System.Data.SqlDbType.VarChar, 3, "cod_make"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_model", System.Data.SqlDbType.VarChar, 3, "cod_model"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@make_year", System.Data.SqlDbType.VarChar, 4, "make_year"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@options", System.Data.SqlDbType.VarChar, 1, "options"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vehicle", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vehicle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_make", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_make", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_model", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_model", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_make_year", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "make_year", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_options", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "options", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM bas_vehicle WHERE (cod_vehicle = @Original_cod_vehicle) AND (cod_make" & _
        " = @Original_cod_make) AND (cod_model = @Original_cod_model) AND (make_year = @O" & _
        "riginal_make_year) AND (options = @Original_options OR @Original_options IS NULL" & _
        " AND options IS NULL)"
        Me.SqlDeleteCommand2.Connection = Me.Cnn
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_vehicle", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_vehicle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_make", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_make", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_model", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_model", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_make_year", System.Data.SqlDbType.VarChar, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "make_year", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_options", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "options", System.Data.DataRowVersion.Original, Nothing))
        '
        'DAbas_vehicle
        '
        Me.DAbas_vehicle.DeleteCommand = Me.SqlDeleteCommand2
        Me.DAbas_vehicle.InsertCommand = Me.SqlInsertCommand2
        Me.DAbas_vehicle.SelectCommand = Me.SqlSelectCommand2
        Me.DAbas_vehicle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "bas_vehicle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("cod_vehicle", "cod_vehicle"), New System.Data.Common.DataColumnMapping("cod_make", "cod_make"), New System.Data.Common.DataColumnMapping("cod_model", "cod_model"), New System.Data.Common.DataColumnMapping("make_year", "make_year"), New System.Data.Common.DataColumnMapping("options", "options")})})
        Me.DAbas_vehicle.UpdateCommand = Me.SqlUpdateCommand2
        '
        'BtnShowSize
        '
        Me.BtnShowSize.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnShowSize.Enabled = False
        Me.BtnShowSize.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnShowSize.Location = New System.Drawing.Point(2, 169)
        Me.BtnShowSize.Name = "BtnShowSize"
        Me.BtnShowSize.Size = New System.Drawing.Size(91, 21)
        Me.BtnShowSize.TabIndex = 4
        Me.BtnShowSize.TabStop = False
        Me.BtnShowSize.Text = "Show Size"
        '
        'LblSize
        '
        Me.LblSize.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.LblSize.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblSize.Location = New System.Drawing.Point(95, 170)
        Me.LblSize.MaxLength = 50
        Me.LblSize.Name = "LblSize"
        Me.LblSize.ReadOnly = True
        Me.LblSize.Size = New System.Drawing.Size(122, 21)
        Me.LblSize.TabIndex = 6
        Me.LblSize.TabStop = False
        Me.LblSize.Text = ""
        '
        'BtnPriceTheSize
        '
        Me.BtnPriceTheSize.BackColor = System.Drawing.Color.YellowGreen
        Me.BtnPriceTheSize.Enabled = False
        Me.BtnPriceTheSize.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BtnPriceTheSize.Location = New System.Drawing.Point(219, 171)
        Me.BtnPriceTheSize.Name = "BtnPriceTheSize"
        Me.BtnPriceTheSize.Size = New System.Drawing.Size(91, 21)
        Me.BtnPriceTheSize.TabIndex = 5
        Me.BtnPriceTheSize.TabStop = False
        Me.BtnPriceTheSize.Text = "Price The Size"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(20, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 14)
        Me.Label1.TabIndex = 379
        Me.Label1.Text = "Option"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblOption
        '
        Me.LblOption.BackColor = System.Drawing.Color.Gold
        Me.LblOption.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblOption.Location = New System.Drawing.Point(95, 195)
        Me.LblOption.MaxLength = 50
        Me.LblOption.Name = "LblOption"
        Me.LblOption.ReadOnly = True
        Me.LblOption.Size = New System.Drawing.Size(122, 21)
        Me.LblOption.TabIndex = 7
        Me.LblOption.TabStop = False
        Me.LblOption.Text = ""
        '
        'FrmFindSize
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(312, 218)
        Me.Controls.Add(Me.LblOption)
        Me.Controls.Add(Me.LblSize)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnPriceTheSize)
        Me.Controls.Add(Me.BtnShowSize)
        Me.Controls.Add(Me.CmbMake_Year)
        Me.Controls.Add(Me.Cmbcod_make)
        Me.Controls.Add(Me.Cmbcod_vehicle_type)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cmbcod_model)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmFindSize"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Find Size"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DsFrmFindSize1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmFindServiceRecords_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MakeDbNameAndConnection()
        Cnn.ConnectionString = PConnectionString

        DsFrmFindSize1.Clear()

        DAbas_vehicle_company.Fill(DsFrmFindSize1, "bas_vehicle_company")
        If DsFrmFindSize1.bas_vehicle_company.Rows.Count < 1 Then
            MsgFar("Please Fill The Vehicle Company Table")
            Call DisableAllComponet(Me)
            Exit Sub
        End If

    End Sub
    Private Sub Cmbcod_make_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbcod_make.SelectedIndexChanged
        If Cmbcod_make.Text.Trim.Length > 0 Then
            Cmbcod_model.Enabled = True
            Call FillDAbas_vehicle_model()
            LblOption.Clear()
            LblSize.Clear()
        Else
            Cmbcod_model.Enabled = False
            CmbMake_Year.Enabled = False
            Cmbcod_vehicle_type.Enabled = False
        End If
    End Sub
    Private Sub FillDAbas_vehicle_model()
        Try
            DsFrmFindSize1.bas_vehicle_model.Clear()
            DAbas_vehicle_model.SelectCommand.Parameters("@cod_make").Value = Cmbcod_make.SelectedValue
            DAbas_vehicle_model.Fill(DsFrmFindSize1, "bas_vehicle_model")
            DsFrmFindSize1.bas_vehicle_model.Addbas_vehicle_modelRow(" ", " ")
            Cmbcod_model.SelectedValue = " "
            LblOption.Clear()
            LblSize.Clear()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FillDAYear()
        Try
            DsFrmFindSize1.bas_vehicle.Clear()
            DAbas_vehicle.SelectCommand.Parameters("@cod_make").Value = Cmbcod_make.SelectedValue
            DAbas_vehicle.SelectCommand.Parameters("@cod_model").Value = Cmbcod_model.SelectedValue
            DAbas_vehicle.Fill(DsFrmFindSize1, "bas_vehicle")
            DsFrmFindSize1.bas_vehicle.Addbas_vehicleRow(" ")
            CmbMake_Year.SelectedValue = " "
            LblOption.Clear()
            LblSize.Clear()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FillDAinv_tab_vehicle_type()
        Try
            DsFrmFindSize1.inv_tab_vehicle_type.Clear()
            DAinv_tab_vehicle_type.SelectCommand.Parameters("@cod_make").Value = Cmbcod_make.SelectedValue
            DAinv_tab_vehicle_type.SelectCommand.Parameters("@cod_model").Value = Cmbcod_model.SelectedValue
            DAinv_tab_vehicle_type.SelectCommand.Parameters("@Make_Year").Value = CmbMake_Year.SelectedValue
            DAinv_tab_vehicle_type.Fill(DsFrmFindSize1, "inv_tab_vehicle_type")
            LblOption.Clear()
            LblSize.Clear()
            If DsFrmFindSize1.inv_tab_vehicle_type.Rows.Count < 1 Then
                MsgFar("Please Fill The Vehicle Type Table")
                Call DisableAllComponet(Me)
                Exit Sub
            End If
            DsFrmFindSize1.inv_tab_vehicle_type.Addinv_tab_vehicle_typeRow(" ", " ")
            Cmbcod_vehicle_type.SelectedValue = " "
        Catch ex As Exception
        End Try
        If Cmbcod_vehicle_type.Text.Trim.Length > 0 Then
            BtnShowSize.Enabled = True
            BtnPriceTheSize.Enabled = True
        Else
            BtnShowSize.Enabled = False
            BtnPriceTheSize.Enabled = False
        End If
    End Sub
    Friend Sub DisableAllComponet(ByVal MyForm As Form, Optional ByVal MyStat As Boolean = False)
        Dim i As Integer
        For i = 0 To MyForm.Controls.Count - 1
            MyForm.Controls(i).Enabled = MyStat
        Next i
    End Sub
    Private Sub BtnPriceTheSize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPriceTheSize.Click
        Dim MyFrmSearchItemCode As New FrmSearchItemCode
        MyFrmSearchItemCode.Condition = " inv_tab_public.desc_table = " & Qt(LblSize.Text)
        MyFrmSearchItemCode.ShowDialog()
    End Sub
    Private Sub BtnShowSize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowSize.Click
        Dim SQLReader As System.Data.SqlClient.SqlDataReader
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT inv_tab_public.desc_table " _
                               & " FROM bas_vehicle_size INNER JOIN " _
                               & " inv_tab_public ON bas_vehicle_size.cod_main = inv_tab_public.cod_main AND " _
                               & " bas_vehicle_size.cod_size_main = inv_tab_public.cod_table_public INNER JOIN " _
                               & " bas_vehicle ON bas_vehicle_size.cod_vehicle = bas_vehicle.cod_vehicle " _
                               & " Where bas_vehicle_size.cod_main='01' AND bas_vehicle.cod_make=" & Qt(Cmbcod_make.SelectedValue) & " AND bas_vehicle.cod_model=" & Qt(Cmbcod_model.SelectedValue) & " AND bas_vehicle.make_Year=" & Qt(CmbMake_Year.SelectedValue) & " AND bas_vehicle.options=" & Qt(Cmbcod_vehicle_type.SelectedValue)
        Try
            LblSize.Text = CmdGeneral.ExecuteScalar & ""
        Catch ex As Exception
        End Try
        CmdGeneral.CommandText = "SELECT inv_tab_public.desc_table " _
                               & " FROM bas_vehicle_size INNER JOIN " _
                               & " inv_tab_public ON bas_vehicle_size.cod_main = inv_tab_public.cod_main AND " _
                               & " bas_vehicle_size.cod_size_option = inv_tab_public.cod_table_public INNER JOIN " _
                               & " bas_vehicle ON bas_vehicle_size.cod_vehicle = bas_vehicle.cod_vehicle " _
                               & " Where bas_vehicle_size.cod_main='01' AND bas_vehicle.cod_make=" & Qt(Cmbcod_make.SelectedValue) & " AND bas_vehicle.cod_model=" & Qt(Cmbcod_model.SelectedValue) & " AND bas_vehicle.make_Year=" & Qt(CmbMake_Year.SelectedValue) & " AND bas_vehicle.options=" & Qt(Cmbcod_vehicle_type.SelectedValue)
        Try
            LblOption.Text = CmdGeneral.ExecuteScalar & ""
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Cmbcod_model_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbcod_model.SelectedIndexChanged
        If Cmbcod_model.Text.Trim.Length > 0 Then
            CmbMake_Year.Enabled = True
            Call FillDAYear()
        Else
            CmbMake_Year.Enabled = False
            Cmbcod_vehicle_type.Enabled = False
        End If
    End Sub
    Private Sub CmbMake_Year_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbMake_Year.SelectedIndexChanged
        If CmbMake_Year.Text.Trim.Length > 0 Then
            Cmbcod_vehicle_type.Enabled = True
            Call FillDAinv_tab_vehicle_type()
        Else
            Cmbcod_vehicle_type.Enabled = False
        End If
    End Sub
    Private Sub Cmbcod_vehicle_type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbcod_vehicle_type.SelectedIndexChanged
        BtnShowSize.Enabled = True
        BtnPriceTheSize.Enabled = True
    End Sub
End Class
