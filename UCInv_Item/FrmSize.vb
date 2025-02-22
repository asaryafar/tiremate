Imports CommonClass
Public Class FrmSize
    Inherits FrmBase
    Dim PanelGridHeightVar As Integer
    Dim FormHeightVar As Integer
    Public Cod_customerParameter As String
    Dim WithEvents MyFrmSearchSize As New FrmSearchSize
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImgWork As System.Windows.Forms.ImageList
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents AddNew As System.Windows.Forms.ToolBarButton
    Friend WithEvents Edit As System.Windows.Forms.ToolBarButton
    Friend WithEvents Delete As System.Windows.Forms.ToolBarButton
    Friend WithEvents Save As System.Windows.Forms.ToolBarButton
    Friend WithEvents Cancel As System.Windows.Forms.ToolBarButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnSearch As Janus.Windows.EditControls.UIButton
    Friend WithEvents TxtMainSizeCod As UcPublicTable.PublicCod
    Friend WithEvents TxtOptionSizeCod As UcPublicTable.PublicCod
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmSize))
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.ImgWork = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.AddNew = New System.Windows.Forms.ToolBarButton
        Me.Edit = New System.Windows.Forms.ToolBarButton
        Me.Delete = New System.Windows.Forms.ToolBarButton
        Me.Save = New System.Windows.Forms.ToolBarButton
        Me.Cancel = New System.Windows.Forms.ToolBarButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnSearch = New Janus.Windows.EditControls.UIButton
        Me.TxtMainSizeCod = New UcPublicTable.PublicCod
        Me.TxtOptionSizeCod = New UcPublicTable.PublicCod
        Me.Panel1.SuspendLayout()
        CType(Me.DsFrmFindSize1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;" & _
        "persist security info=True;password=sa"
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
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(362, 62)
        Me.Panel1.TabIndex = 366
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(142, 0)
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
        Me.Cmbcod_make.Location = New System.Drawing.Point(81, 93)
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
        Me.Cmbcod_vehicle_type.Location = New System.Drawing.Point(81, 173)
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
        Me.Label13.Location = New System.Drawing.Point(7, 173)
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
        Me.Label5.Location = New System.Drawing.Point(8, 121)
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
        Me.Label3.Location = New System.Drawing.Point(8, 97)
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
        Me.Label2.Location = New System.Drawing.Point(8, 149)
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
        Me.Cmbcod_model.Location = New System.Drawing.Point(81, 119)
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
        Me.SqlSelectCommand1.CommandText = "SELECT cod_model, desc_model FROM bas_vehicle_model WHERE (cod_make = @cod_make)"
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
        Me.CmbMake_Year.Location = New System.Drawing.Point(81, 146)
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(11, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 14)
        Me.Label1.TabIndex = 379
        Me.Label1.Text = "Option Size"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImgWork
        '
        Me.ImgWork.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImgWork.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImgWork.ImageStream = CType(resources.GetObject("ImgWork.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgWork.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.AddNew, Me.Edit, Me.Delete, Me.Save, Me.Cancel})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(60, 20)
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImgWork
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(362, 28)
        Me.ToolBar1.TabIndex = 381
        Me.ToolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
        '
        'AddNew
        '
        Me.AddNew.ImageIndex = 0
        Me.AddNew.Tag = "1"
        Me.AddNew.Text = "New"
        Me.AddNew.ToolTipText = "New (Ctrl+N)"
        '
        'Edit
        '
        Me.Edit.ImageIndex = 1
        Me.Edit.Tag = "2"
        Me.Edit.Text = "Edit"
        Me.Edit.ToolTipText = "Edit (Ctrl+E)"
        '
        'Delete
        '
        Me.Delete.ImageIndex = 2
        Me.Delete.Tag = "3"
        Me.Delete.Text = "Delete"
        Me.Delete.ToolTipText = "Delete (Ctrl+D)"
        '
        'Save
        '
        Me.Save.Enabled = False
        Me.Save.ImageIndex = 3
        Me.Save.Tag = "4"
        Me.Save.Text = "Save"
        Me.Save.ToolTipText = "Save (Ctrl+S)"
        '
        'Cancel
        '
        Me.Cancel.Enabled = False
        Me.Cancel.ImageIndex = 4
        Me.Cancel.Tag = "5"
        Me.Cancel.Text = "Cancel"
        Me.Cancel.ToolTipText = "Cancel (Ctrl+Z)"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(11, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 14)
        Me.Label4.TabIndex = 382
        Me.Label4.Text = "Main Size"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(275, 131)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 79)
        Me.BtnSearch.TabIndex = 6
        Me.BtnSearch.Text = "Search"
        '
        'TxtMainSizeCod
        '
        Me.TxtMainSizeCod.BackColor = System.Drawing.SystemColors.Control
        Me.TxtMainSizeCod.Cnn = Me.Cnn
        Me.TxtMainSizeCod.Cod_main = "01"
        Me.TxtMainSizeCod.FieldCodValue = ""
        Me.TxtMainSizeCod.Location = New System.Drawing.Point(81, 200)
        Me.TxtMainSizeCod.Name = "TxtMainSizeCod"
        Me.TxtMainSizeCod.Size = New System.Drawing.Size(122, 22)
        Me.TxtMainSizeCod.TabIndex = 4
        Me.TxtMainSizeCod.TxtBackColor = System.Drawing.Color.White
        Me.TxtMainSizeCod.TxtForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtMainSizeCod.TxtRightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'TxtOptionSizeCod
        '
        Me.TxtOptionSizeCod.BackColor = System.Drawing.SystemColors.Control
        Me.TxtOptionSizeCod.Cnn = Me.Cnn
        Me.TxtOptionSizeCod.Cod_main = "01"
        Me.TxtOptionSizeCod.FieldCodValue = ""
        Me.TxtOptionSizeCod.Location = New System.Drawing.Point(81, 228)
        Me.TxtOptionSizeCod.Name = "TxtOptionSizeCod"
        Me.TxtOptionSizeCod.Size = New System.Drawing.Size(122, 22)
        Me.TxtOptionSizeCod.TabIndex = 5
        Me.TxtOptionSizeCod.TxtBackColor = System.Drawing.Color.White
        Me.TxtOptionSizeCod.TxtForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtOptionSizeCod.TxtRightToLeft = System.Windows.Forms.RightToLeft.No
        '
        'FrmSize
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(362, 250)
        Me.Controls.Add(Me.TxtOptionSizeCod)
        Me.Controls.Add(Me.TxtMainSizeCod)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbMake_Year)
        Me.Controls.Add(Me.Cmbcod_make)
        Me.Controls.Add(Me.Cmbcod_vehicle_type)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cmbcod_model)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Name = "FrmSize"
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

        Call Enable(False)
        Call EnableDisableToolBar()

    End Sub
    Private Sub Cmbcod_make_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbcod_make.SelectedIndexChanged
        If Cmbcod_make.Text.Trim.Length > 0 Then
            Cmbcod_model.Enabled = Cmbcod_make.Enabled
            Call FillDAbas_vehicle_model()
        Else
            Cmbcod_model.Enabled = False
            CmbMake_Year.Enabled = False
            Cmbcod_vehicle_type.Enabled = False
        End If
        Call EnableDisableSaveAndCancel()
    End Sub
    Private Sub FillDAbas_vehicle_model()
        Try
            DsFrmFindSize1.bas_vehicle_model.Clear()
            DAbas_vehicle_model.SelectCommand.Parameters("@cod_make").Value = Cmbcod_make.SelectedValue
            DAbas_vehicle_model.Fill(DsFrmFindSize1, "bas_vehicle_model")
            DsFrmFindSize1.bas_vehicle_model.Addbas_vehicle_modelRow(" ", " ")
            Cmbcod_model.SelectedValue = " "
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
            If DsFrmFindSize1.inv_tab_vehicle_type.Rows.Count < 1 Then
                MsgFar("Please Fill The Vehicle Type Table")
                Call DisableAllComponet(Me)
                Exit Sub
            End If
            DsFrmFindSize1.inv_tab_vehicle_type.Addinv_tab_vehicle_typeRow(" ", " ")
            Cmbcod_vehicle_type.SelectedValue = " "
        Catch ex As Exception
        End Try
    End Sub
    Friend Sub DisableAllComponet(ByVal MyForm As Form, Optional ByVal MyStat As Boolean = False)
        Dim i As Integer
        For i = 0 To MyForm.Controls.Count - 1
            MyForm.Controls(i).Enabled = MyStat
        Next i
    End Sub
    Private Sub Cmbcod_model_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbcod_model.SelectedIndexChanged
        If Cmbcod_model.Text.Trim.Length > 0 Then
            CmbMake_Year.Enabled = Cmbcod_model.Enabled
            Call FillDAYear()
        Else
            CmbMake_Year.Enabled = False
            Cmbcod_vehicle_type.Enabled = False
        End If
        Call EnableDisableSaveAndCancel()
    End Sub
    Private Sub CmbMake_Year_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbMake_Year.SelectedIndexChanged
        If CmbMake_Year.Text.Trim.Length > 0 Then
            Cmbcod_vehicle_type.Enabled = CmbMake_Year.Enabled
            Call FillDAinv_tab_vehicle_type()
        Else
            Cmbcod_vehicle_type.Enabled = False
        End If
        Call EnableDisableSaveAndCancel()
    End Sub
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0
                Call PAddNew()
            Case 1
                Call PEdit()
            Case 2
                Call PDelete()
            Case 3
                Call Psave()
            Case 4
                Call Pcancel()
        End Select
    End Sub
    Sub PAddNew()
        ThisFormStatus = MainModule.WorkStates.AddNew
        Call Enable(True)
        ClearAllData()
        Cmbcod_make.Focus()
        Cancel.Enabled = True
        AddNew.Enabled = False
        Edit.Enabled = False
        Delete.Enabled = False
        BtnSearch.Enabled = False
    End Sub
    Sub PEdit()
        ThisFormStatus = MainModule.WorkStates.Edit
        Call Enable(True)
        Cancel.Enabled = True
        AddNew.Enabled = False
        Edit.Enabled = False
        Delete.Enabled = False
        BtnSearch.Enabled = False
        TxtMainSizeCod.Focus()
    End Sub
    Sub PDelete()
        If Cmbcod_make.Text.Trim <> "" And Cmbcod_model.Text.Trim <> "" And Cmbcod_vehicle_type.Text.Trim <> "" And CmbMake_Year.Text.Trim <> "" And TxtMainSizeCod.Text.Trim <> "" Then
            Dim c1 As New FrmWhatDoForMenu
            c1.ShowFarMsg("Are you sure?")
            If c1.DialogResult = DialogResult.OK Then
                If CmdGeneral.Connection.State <> ConnectionState.Open Then
                    CmdGeneral.Connection.Open()
                End If
                Dim Thiscod_vehicle As String
                CmdGeneral.CommandText = "Select cod_vehicle From Bas_Vehicle Where cod_make=" & Qt(Cmbcod_make.SelectedValue) & " AND cod_model=" & Qt(Cmbcod_model.SelectedValue) & " AND Options=" & Qt(Cmbcod_vehicle_type.SelectedValue) & " AND make_year=" & Qt(CmbMake_Year.SelectedValue)
                Thiscod_vehicle = CmdGeneral.ExecuteScalar
                CmdGeneral.CommandText = "Delete From Bas_Vehicle_Size Where cod_main='01' AND cod_vehicle=" & Qt(Thiscod_vehicle)
                CmdGeneral.ExecuteNonQuery()
            End If
            Call EnableDisableToolBar()
            ThisFormStatus = MainModule.WorkStates.Delete
        End If
    End Sub
    Sub Psave()
        Call Enable(False)
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim Thiscod_vehicle As String
        CmdGeneral.CommandText = "Select cod_vehicle From Bas_Vehicle Where cod_make=" & Qt(Cmbcod_make.SelectedValue) & " AND cod_model=" & Qt(Cmbcod_model.SelectedValue) & " AND Options=" & Qt(Cmbcod_vehicle_type.SelectedValue) & " AND make_year=" & Qt(CmbMake_Year.SelectedValue)
        Thiscod_vehicle = CmdGeneral.ExecuteScalar
        CmdGeneral.CommandText = "Delete From Bas_Vehicle_Size Where cod_main='01' AND cod_vehicle=" & Qt(Thiscod_vehicle)
        CmdGeneral.ExecuteNonQuery()
        CmdGeneral.CommandText = "Insert Into Bas_Vehicle_Size (Cod_Vehicle,cod_main,cod_size_main,cod_size_option) Values (" & Qt(Thiscod_vehicle) & ",'01'," & Qt(TxtMainSizeCod.FieldCodValue) & "," & Qt(TxtOptionSizeCod.FieldCodValue) & ")"
        CmdGeneral.ExecuteNonQuery()
        ThisFormStatus = MainModule.WorkStates.Save
        EnableDisableToolBar()
        If ThisFormStatus = MainModule.WorkStates.AddNew Then
            Call PAddNew()
        End If
    End Sub
    Sub Pcancel()
        Enable(False)
        EnableDisableToolBar()
        ThisFormStatus = MainModule.WorkStates.Cancel
    End Sub
    Sub Enable(ByVal Stat As Boolean)
        If ThisFormStatus = MainModule.WorkStates.AddNew Then
            Cmbcod_make.Enabled = Stat
            Cmbcod_model.Enabled = Stat
            Cmbcod_vehicle_type.Enabled = Stat
            CmbMake_Year.Enabled = Stat
        Else
            Cmbcod_make.Enabled = False
            Cmbcod_model.Enabled = False
            Cmbcod_vehicle_type.Enabled = False
            CmbMake_Year.Enabled = False
        End If
        TxtOptionSizeCod.Enabled = Stat
        TxtMainSizeCod.Enabled = Stat
    End Sub
    Sub EnableDisableToolBar()
        AddNew.Enabled = True
        Edit.Enabled = True
        Delete.Enabled = True
        BtnSearch.Enabled = True
        Save.Enabled = False
        Cancel.Enabled = False
    End Sub
    Sub EnableDisableSaveAndCancel()
        If ThisFormStatus = MainModule.WorkStates.AddNew Or ThisFormStatus = MainModule.WorkStates.Edit Then
            If Cmbcod_make.Text.Trim <> "" And Cmbcod_model.Text.Trim <> "" And Cmbcod_vehicle_type.Text.Trim <> "" And CmbMake_Year.Text.Trim <> "" And TxtMainSizeCod.Text.Trim <> "" Then
                Save.Enabled = True
            Else
                Save.Enabled = False
            End If
        End If
    End Sub
    Sub ClearAllData()
        Cmbcod_make.SelectedValue = ""
        Cmbcod_model.SelectedValue = ""
        CmbMake_Year.SelectedValue = ""
        Cmbcod_vehicle_type.SelectedValue = ""
        TxtMainSizeCod.FieldCodValue = ""
        TxtOptionSizeCod.FieldCodValue = ""
    End Sub
    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        MyFrmSearchSize.ShowDialog()
    End Sub
    Private Sub MyFrmSearchSize_SizeFind(ByVal ThisMake As String, ByVal ThisModel As String, ByVal ThisYear As String, ByVal ThisOption As String, ByVal ThisMainSize As String, ByVal ThisOptionSize As String) Handles MyFrmSearchSize.SizeFind
        Cmbcod_make.SelectedValue = ThisMake
        Cmbcod_model.SelectedValue = ThisModel
        CmbMake_Year.SelectedValue = ThisYear
        Cmbcod_vehicle_type.SelectedValue = ThisOption
        TxtMainSizeCod.FieldCodValue = ThisMainSize
        TxtOptionSizeCod.FieldCodValue = ThisOptionSize
    End Sub
    Private Sub TxtMainSizeCod_AfterFieldCodValueFind(ByVal ThisRow As System.Data.DataRow) Handles TxtMainSizeCod.AfterFieldCodValueFind
        EnableDisableSaveAndCancel()
    End Sub
    Private Sub TxtOptionSizeCod_AfterFieldCodValueFind(ByVal ThisRow As System.Data.DataRow) Handles TxtOptionSizeCod.AfterFieldCodValueFind
        EnableDisableSaveAndCancel()
    End Sub
End Class
