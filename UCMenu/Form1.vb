Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Public Class Form1
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
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSet11 As WindowsApplication1.DataSet1
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Sqlupdate As System.Data.SqlClient.SqlCommand
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SqlInsert As System.Data.SqlClient.SqlCommand
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.DataSet11 = New WindowsApplication1.DataSet1
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.Sqlupdate = New System.Data.SqlClient.SqlCommand
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.SqlInsert = New System.Data.SqlClient.SqlCommand
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT employee_code, f_name, m_name, l_name, address, zipcode, technecian, socia" & _
        "l_security_no, cod_position, cod_deparment, phone_1, extension_1, phone_type_1, " & _
        "phone_main_1, phone_2, extension_2, phone_type_2, phone_main_2, phone_3, extensi" & _
        "on_3, phone_type_3, phone_main_3, phone_4, extension_4, phone_type_4, phone_main" & _
        "_4, phone_5, extension_5, phone_type_5, phone_main_5, email, notes, pic, birthda" & _
        "y_date, hired_date, last_reiew_date, terminate_date, temporary_inactive, last_ba" & _
        "sis, last_period, last_status, last_salary, last_hourly, last_overtime, deductio" & _
        "n_cod1, deduction_amount1, deduction_cod2, deduction_amount2, deduction_cod3, de" & _
        "duction_amount3, deduction_cod4, deduction_amount4, deduction_cod5, deduction_am" & _
        "ount5, deduction_cod6, deduction_amount6, Last_raise_date, ExemptionFederal, Exe" & _
        "mptionLocal, ExemptionState, Terminated FROM employee"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;" & _
        "persist security info=True;password=sa"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO employee(employee_code, f_name, m_name, l_name, address, zipcode, tec" & _
        "hnecian, social_security_no, cod_position, cod_deparment, phone_1, extension_1, " & _
        "phone_type_1, phone_main_1, phone_2, extension_2, phone_type_2, phone_main_2, ph" & _
        "one_3, extension_3, phone_type_3, phone_main_3, phone_4, extension_4, phone_type" & _
        "_4, phone_main_4, phone_5, extension_5, phone_type_5, phone_main_5, email, notes" & _
        ", pic, birthday_date, hired_date, last_reiew_date, terminate_date, temporary_ina" & _
        "ctive, last_basis, last_period, last_status, last_salary, last_hourly, last_over" & _
        "time, deduction_cod1, deduction_amount1, deduction_cod2, deduction_amount2, dedu" & _
        "ction_cod3, deduction_amount3, deduction_cod4, deduction_amount4, deduction_cod5" & _
        ", deduction_amount5, deduction_cod6, deduction_amount6, Last_raise_date, Exempti" & _
        "onFederal, ExemptionLocal, ExemptionState, Terminated) VALUES (@employee_code, @" & _
        "f_name, @m_name, @l_name, @address, @zipcode, @technecian, @social_security_no, " & _
        "@cod_position, @cod_deparment, @phone_1, @extension_1, @phone_type_1, @phone_mai" & _
        "n_1, @phone_2, @extension_2, @phone_type_2, @phone_main_2, @phone_3, @extension_" & _
        "3, @phone_type_3, @phone_main_3, @phone_4, @extension_4, @phone_type_4, @phone_m" & _
        "ain_4, @phone_5, @extension_5, @phone_type_5, @phone_main_5, @email, @notes, @pi" & _
        "c, @birthday_date, @hired_date, @last_reiew_date, @terminate_date, @temporary_in" & _
        "active, @last_basis, @last_period, @last_status, @last_salary, @last_hourly, @la" & _
        "st_overtime, @deduction_cod1, @deduction_amount1, @deduction_cod2, @deduction_am" & _
        "ount2, @deduction_cod3, @deduction_amount3, @deduction_cod4, @deduction_amount4," & _
        " @deduction_cod5, @deduction_amount5, @deduction_cod6, @deduction_amount6, @Last" & _
        "_raise_date, @ExemptionFederal, @ExemptionLocal, @ExemptionState, @Terminated); " & _
        "SELECT employee_code, f_name, m_name, l_name, address, zipcode, technecian, soci" & _
        "al_security_no, cod_position, cod_deparment, phone_1, extension_1, phone_type_1," & _
        " phone_main_1, phone_2, extension_2, phone_type_2, phone_main_2, phone_3, extens" & _
        "ion_3, phone_type_3, phone_main_3, phone_4, extension_4, phone_type_4, phone_mai" & _
        "n_4, phone_5, extension_5, phone_type_5, phone_main_5, email, notes, pic, birthd" & _
        "ay_date, hired_date, last_reiew_date, terminate_date, temporary_inactive, last_b" & _
        "asis, last_period, last_status, last_salary, last_hourly, last_overtime, deducti" & _
        "on_cod1, deduction_amount1, deduction_cod2, deduction_amount2, deduction_cod3, d" & _
        "eduction_amount3, deduction_cod4, deduction_amount4, deduction_cod5, deduction_a" & _
        "mount5, deduction_cod6, deduction_amount6, Last_raise_date, ExemptionFederal, Ex" & _
        "emptionLocal, ExemptionState, Terminated FROM employee WHERE (employee_code = @e" & _
        "mployee_code)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@f_name", System.Data.SqlDbType.VarChar, 20, "f_name"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@m_name", System.Data.SqlDbType.VarChar, 15, "m_name"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@l_name", System.Data.SqlDbType.VarChar, 30, "l_name"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zipcode", System.Data.SqlDbType.VarChar, 5, "zipcode"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@technecian", System.Data.SqlDbType.Bit, 1, "technecian"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@social_security_no", System.Data.SqlDbType.VarChar, 25, "social_security_no"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_position", System.Data.SqlDbType.VarChar, 2, "cod_position"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_deparment", System.Data.SqlDbType.VarChar, 3, "cod_deparment"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_1", System.Data.SqlDbType.VarChar, 20, "phone_1"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_1", System.Data.SqlDbType.VarChar, 2, "extension_1"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_1", System.Data.SqlDbType.VarChar, 1, "phone_type_1"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_1", System.Data.SqlDbType.Bit, 1, "phone_main_1"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_2", System.Data.SqlDbType.VarChar, 20, "phone_2"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_2", System.Data.SqlDbType.VarChar, 2, "extension_2"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_2", System.Data.SqlDbType.VarChar, 1, "phone_type_2"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_2", System.Data.SqlDbType.Bit, 1, "phone_main_2"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_3", System.Data.SqlDbType.VarChar, 20, "phone_3"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_3", System.Data.SqlDbType.VarChar, 2, "extension_3"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_3", System.Data.SqlDbType.VarChar, 1, "phone_type_3"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_3", System.Data.SqlDbType.Bit, 1, "phone_main_3"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_4", System.Data.SqlDbType.VarChar, 20, "phone_4"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_4", System.Data.SqlDbType.VarChar, 2, "extension_4"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_4", System.Data.SqlDbType.VarChar, 1, "phone_type_4"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_4", System.Data.SqlDbType.Bit, 1, "phone_main_4"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_5", System.Data.SqlDbType.VarChar, 20, "phone_5"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_5", System.Data.SqlDbType.VarChar, 2, "extension_5"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_5", System.Data.SqlDbType.VarChar, 1, "phone_type_5"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_5", System.Data.SqlDbType.Bit, 1, "phone_main_5"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 50, "email"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@notes", System.Data.SqlDbType.VarChar, 300, "notes"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pic", System.Data.SqlDbType.VarBinary, 2147483647, "pic"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@birthday_date", System.Data.SqlDbType.VarChar, 10, "birthday_date"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@hired_date", System.Data.SqlDbType.VarChar, 10, "hired_date"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_reiew_date", System.Data.SqlDbType.VarChar, 10, "last_reiew_date"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@terminate_date", System.Data.SqlDbType.VarChar, 10, "terminate_date"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@temporary_inactive", System.Data.SqlDbType.Bit, 1, "temporary_inactive"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_basis", System.Data.SqlDbType.VarChar, 1, "last_basis"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_period", System.Data.SqlDbType.VarChar, 1, "last_period"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_status", System.Data.SqlDbType.VarChar, 1, "last_status"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_salary", System.Data.SqlDbType.Real, 4, "last_salary"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_hourly", System.Data.SqlDbType.Real, 4, "last_hourly"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_overtime", System.Data.SqlDbType.Real, 4, "last_overtime"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_cod1", System.Data.SqlDbType.VarChar, 2, "deduction_cod1"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_amount1", System.Data.SqlDbType.Real, 4, "deduction_amount1"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_cod2", System.Data.SqlDbType.VarChar, 2, "deduction_cod2"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_amount2", System.Data.SqlDbType.Real, 4, "deduction_amount2"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_cod3", System.Data.SqlDbType.VarChar, 2, "deduction_cod3"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_amount3", System.Data.SqlDbType.Real, 4, "deduction_amount3"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_cod4", System.Data.SqlDbType.VarChar, 2, "deduction_cod4"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_amount4", System.Data.SqlDbType.Real, 4, "deduction_amount4"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_cod5", System.Data.SqlDbType.VarChar, 2, "deduction_cod5"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_amount5", System.Data.SqlDbType.Real, 4, "deduction_amount5"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_cod6", System.Data.SqlDbType.VarChar, 2, "deduction_cod6"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_amount6", System.Data.SqlDbType.Real, 4, "deduction_amount6"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Last_raise_date", System.Data.SqlDbType.VarChar, 10, "Last_raise_date"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ExemptionFederal", System.Data.SqlDbType.Real, 4, "ExemptionFederal"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ExemptionLocal", System.Data.SqlDbType.Real, 4, "ExemptionLocal"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ExemptionState", System.Data.SqlDbType.Real, 4, "ExemptionState"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Terminated", System.Data.SqlDbType.Bit, 1, "Terminated"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE employee SET employee_code = @employee_code, f_name = @f_name, m_name = @m" & _
        "_name, l_name = @l_name, address = @address, zipcode = @zipcode, technecian = @t" & _
        "echnecian, social_security_no = @social_security_no, cod_position = @cod_positio" & _
        "n, cod_deparment = @cod_deparment, phone_1 = @phone_1, extension_1 = @extension_" & _
        "1, phone_type_1 = @phone_type_1, phone_main_1 = @phone_main_1, phone_2 = @phone_" & _
        "2, extension_2 = @extension_2, phone_type_2 = @phone_type_2, phone_main_2 = @pho" & _
        "ne_main_2, phone_3 = @phone_3, extension_3 = @extension_3, phone_type_3 = @phone" & _
        "_type_3, phone_main_3 = @phone_main_3, phone_4 = @phone_4, extension_4 = @extens" & _
        "ion_4, phone_type_4 = @phone_type_4, phone_main_4 = @phone_main_4, phone_5 = @ph" & _
        "one_5, extension_5 = @extension_5, phone_type_5 = @phone_type_5, phone_main_5 = " & _
        "@phone_main_5, email = @email, notes = @notes, pic = @pic, birthday_date = @birt" & _
        "hday_date, hired_date = @hired_date, last_reiew_date = @last_reiew_date, termina" & _
        "te_date = @terminate_date, temporary_inactive = @temporary_inactive, last_basis " & _
        "= @last_basis, last_period = @last_period, last_status = @last_status, last_sala" & _
        "ry = @last_salary, last_hourly = @last_hourly, last_overtime = @last_overtime, d" & _
        "eduction_cod1 = @deduction_cod1, deduction_amount1 = @deduction_amount1, deducti" & _
        "on_cod2 = @deduction_cod2, deduction_amount2 = @deduction_amount2, deduction_cod" & _
        "3 = @deduction_cod3, deduction_amount3 = @deduction_amount3, deduction_cod4 = @d" & _
        "eduction_cod4, deduction_amount4 = @deduction_amount4, deduction_cod5 = @deducti" & _
        "on_cod5, deduction_amount5 = @deduction_amount5, deduction_cod6 = @deduction_cod" & _
        "6, deduction_amount6 = @deduction_amount6, Last_raise_date = @Last_raise_date, E" & _
        "xemptionFederal = @ExemptionFederal, ExemptionLocal = @ExemptionLocal, Exemption" & _
        "State = @ExemptionState, Terminated = @Terminated WHERE (employee_code = @Origin" & _
        "al_employee_code) AND (ExemptionFederal = @Original_ExemptionFederal OR @Origina" & _
        "l_ExemptionFederal IS NULL AND ExemptionFederal IS NULL) AND (ExemptionLocal = @" & _
        "Original_ExemptionLocal OR @Original_ExemptionLocal IS NULL AND ExemptionLocal I" & _
        "S NULL) AND (ExemptionState = @Original_ExemptionState OR @Original_ExemptionSta" & _
        "te IS NULL AND ExemptionState IS NULL) AND (Last_raise_date = @Original_Last_rai" & _
        "se_date OR @Original_Last_raise_date IS NULL AND Last_raise_date IS NULL) AND (T" & _
        "erminated = @Original_Terminated OR @Original_Terminated IS NULL AND Terminated " & _
        "IS NULL) AND (address = @Original_address OR @Original_address IS NULL AND addre" & _
        "ss IS NULL) AND (birthday_date = @Original_birthday_date OR @Original_birthday_d" & _
        "ate IS NULL AND birthday_date IS NULL) AND (cod_deparment = @Original_cod_deparm" & _
        "ent OR @Original_cod_deparment IS NULL AND cod_deparment IS NULL) AND (cod_posit" & _
        "ion = @Original_cod_position OR @Original_cod_position IS NULL AND cod_position " & _
        "IS NULL) AND (deduction_amount1 = @Original_deduction_amount1 OR @Original_deduc" & _
        "tion_amount1 IS NULL AND deduction_amount1 IS NULL) AND (deduction_amount2 = @Or" & _
        "iginal_deduction_amount2 OR @Original_deduction_amount2 IS NULL AND deduction_am" & _
        "ount2 IS NULL) AND (deduction_amount3 = @Original_deduction_amount3 OR @Original" & _
        "_deduction_amount3 IS NULL AND deduction_amount3 IS NULL) AND (deduction_amount4" & _
        " = @Original_deduction_amount4 OR @Original_deduction_amount4 IS NULL AND deduct" & _
        "ion_amount4 IS NULL) AND (deduction_amount5 = @Original_deduction_amount5 OR @Or" & _
        "iginal_deduction_amount5 IS NULL AND deduction_amount5 IS NULL) AND (deduction_a" & _
        "mount6 = @Original_deduction_amount6 OR @Original_deduction_amount6 IS NULL AND " & _
        "deduction_amount6 IS NULL) AND (deduction_cod1 = @Original_deduction_cod1 OR @Or" & _
        "iginal_deduction_cod1 IS NULL AND deduction_cod1 IS NULL) AND (deduction_cod2 = " & _
        "@Original_deduction_cod2 OR @Original_deduction_cod2 IS NULL AND deduction_cod2 " & _
        "IS NULL) AND (deduction_cod3 = @Original_deduction_cod3 OR @Original_deduction_c" & _
        "od3 IS NULL AND deduction_cod3 IS NULL) AND (deduction_cod4 = @Original_deductio" & _
        "n_cod4 OR @Original_deduction_cod4 IS NULL AND deduction_cod4 IS NULL) AND (dedu" & _
        "ction_cod5 = @Original_deduction_cod5 OR @Original_deduction_cod5 IS NULL AND de" & _
        "duction_cod5 IS NULL) AND (deduction_cod6 = @Original_deduction_cod6 OR @Origina" & _
        "l_deduction_cod6 IS NULL AND deduction_cod6 IS NULL) AND (email = @Original_emai" & _
        "l OR @Original_email IS NULL AND email IS NULL) AND (extension_1 = @Original_ext" & _
        "ension_1 OR @Original_extension_1 IS NULL AND extension_1 IS NULL) AND (extensio" & _
        "n_2 = @Original_extension_2 OR @Original_extension_2 IS NULL AND extension_2 IS " & _
        "NULL) AND (extension_3 = @Original_extension_3 OR @Original_extension_3 IS NULL " & _
        "AND extension_3 IS NULL) AND (extension_4 = @Original_extension_4 OR @Original_e" & _
        "xtension_4 IS NULL AND extension_4 IS NULL) AND (extension_5 = @Original_extensi" & _
        "on_5 OR @Original_extension_5 IS NULL AND extension_5 IS NULL) AND (f_name = @Or" & _
        "iginal_f_name OR @Original_f_name IS NULL AND f_name IS NULL) AND (hired_date = " & _
        "@Original_hired_date OR @Original_hired_date IS NULL AND hired_date IS NULL) AND" & _
        " (l_name = @Original_l_name OR @Original_l_name IS NULL AND l_name IS NULL) AND " & _
        "(last_basis = @Original_last_basis OR @Original_last_basis IS NULL AND last_basi" & _
        "s IS NULL) AND (last_hourly = @Original_last_hourly OR @Original_last_hourly IS " & _
        "NULL AND last_hourly IS NULL) AND (last_overtime = @Original_last_overtime OR @O" & _
        "riginal_last_overtime IS NULL AND last_overtime IS NULL) AND (last_period = @Ori" & _
        "ginal_last_period OR @Original_last_period IS NULL AND last_period IS NULL) AND " & _
        "(last_reiew_date = @Original_last_reiew_date OR @Original_last_reiew_date IS NUL" & _
        "L AND last_reiew_date IS NULL) AND (last_salary = @Original_last_salary OR @Orig" & _
        "inal_last_salary IS NULL AND last_salary IS NULL) AND (last_status = @Original_l" & _
        "ast_status OR @Original_last_status IS NULL AND last_status IS NULL) AND (m_name" & _
        " = @Original_m_name OR @Original_m_name IS NULL AND m_name IS NULL) AND (notes =" & _
        " @Original_notes OR @Original_notes IS NULL AND notes IS NULL) AND (phone_1 = @O" & _
        "riginal_phone_1 OR @Original_phone_1 IS NULL AND phone_1 IS NULL) AND (phone_2 =" & _
        " @Original_phone_2 OR @Original_phone_2 IS NULL AND phone_2 IS NULL) AND (phone_" & _
        "3 = @Original_phone_3 OR @Original_phone_3 IS NULL AND phone_3 IS NULL) AND (pho" & _
        "ne_4 = @Original_phone_4 OR @Original_phone_4 IS NULL AND phone_4 IS NULL) AND (" & _
        "phone_5 = @Original_phone_5 OR @Original_phone_5 IS NULL AND phone_5 IS NULL) AN" & _
        "D (phone_main_1 = @Original_phone_main_1 OR @Original_phone_main_1 IS NULL AND p" & _
        "hone_main_1 IS NULL) AND (phone_main_2 = @Original_phone_main_2 OR @Original_pho" & _
        "ne_main_2 IS NULL AND phone_main_2 IS NULL) AND (phone_main_3 = @Original_phone_" & _
        "main_3 OR @Original_phone_main_3 IS NULL AND phone_main_3 IS NULL) AND (phone_ma" & _
        "in_4 = @Original_phone_main_4 OR @Original_phone_main_4 IS NULL AND phone_main_4" & _
        " IS NULL) AND (phone_main_5 = @Original_phone_main_5 OR @Original_phone_main_5 I" & _
        "S NULL AND phone_main_5 IS NULL) AND (phone_type_1 = @Original_phone_type_1 OR @" & _
        "Original_phone_type_1 IS NULL AND phone_type_1 IS NULL) AND (phone_type_2 = @Ori" & _
        "ginal_phone_type_2 OR @Original_phone_type_2 IS NULL AND phone_type_2 IS NULL) A" & _
        "ND (phone_type_3 = @Original_phone_type_3 OR @Original_phone_type_3 IS NULL AND " & _
        "phone_type_3 IS NULL) AND (phone_type_4 = @Original_phone_type_4 OR @Original_ph" & _
        "one_type_4 IS NULL AND phone_type_4 IS NULL) AND (phone_type_5 = @Original_phone" & _
        "_type_5 OR @Original_phone_type_5 IS NULL AND phone_type_5 IS NULL) AND (social_" & _
        "security_no = @Original_social_security_no OR @Original_social_security_no IS NU" & _
        "LL AND social_security_no IS NULL) AND (technecian = @Original_technecian OR @Or" & _
        "iginal_technecian IS NULL AND technecian IS NULL) AND (temporary_inactive = @Ori" & _
        "ginal_temporary_inactive OR @Original_temporary_inactive IS NULL AND temporary_i" & _
        "nactive IS NULL) AND (terminate_date = @Original_terminate_date OR @Original_ter" & _
        "minate_date IS NULL AND terminate_date IS NULL) AND (zipcode = @Original_zipcode" & _
        " OR @Original_zipcode IS NULL AND zipcode IS NULL); SELECT employee_code, f_name" & _
        ", m_name, l_name, address, zipcode, technecian, social_security_no, cod_position" & _
        ", cod_deparment, phone_1, extension_1, phone_type_1, phone_main_1, phone_2, exte" & _
        "nsion_2, phone_type_2, phone_main_2, phone_3, extension_3, phone_type_3, phone_m" & _
        "ain_3, phone_4, extension_4, phone_type_4, phone_main_4, phone_5, extension_5, p" & _
        "hone_type_5, phone_main_5, email, notes, pic, birthday_date, hired_date, last_re" & _
        "iew_date, terminate_date, temporary_inactive, last_basis, last_period, last_stat" & _
        "us, last_salary, last_hourly, last_overtime, deduction_cod1, deduction_amount1, " & _
        "deduction_cod2, deduction_amount2, deduction_cod3, deduction_amount3, deduction_" & _
        "cod4, deduction_amount4, deduction_cod5, deduction_amount5, deduction_cod6, dedu" & _
        "ction_amount6, Last_raise_date, ExemptionFederal, ExemptionLocal, ExemptionState" & _
        ", Terminated FROM employee WHERE (employee_code = @employee_code)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@f_name", System.Data.SqlDbType.VarChar, 20, "f_name"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@m_name", System.Data.SqlDbType.VarChar, 15, "m_name"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@l_name", System.Data.SqlDbType.VarChar, 30, "l_name"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 100, "address"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@zipcode", System.Data.SqlDbType.VarChar, 5, "zipcode"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@technecian", System.Data.SqlDbType.Bit, 1, "technecian"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@social_security_no", System.Data.SqlDbType.VarChar, 25, "social_security_no"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_position", System.Data.SqlDbType.VarChar, 2, "cod_position"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cod_deparment", System.Data.SqlDbType.VarChar, 3, "cod_deparment"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_1", System.Data.SqlDbType.VarChar, 20, "phone_1"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_1", System.Data.SqlDbType.VarChar, 2, "extension_1"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_1", System.Data.SqlDbType.VarChar, 1, "phone_type_1"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_1", System.Data.SqlDbType.Bit, 1, "phone_main_1"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_2", System.Data.SqlDbType.VarChar, 20, "phone_2"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_2", System.Data.SqlDbType.VarChar, 2, "extension_2"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_2", System.Data.SqlDbType.VarChar, 1, "phone_type_2"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_2", System.Data.SqlDbType.Bit, 1, "phone_main_2"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_3", System.Data.SqlDbType.VarChar, 20, "phone_3"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_3", System.Data.SqlDbType.VarChar, 2, "extension_3"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_3", System.Data.SqlDbType.VarChar, 1, "phone_type_3"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_3", System.Data.SqlDbType.Bit, 1, "phone_main_3"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_4", System.Data.SqlDbType.VarChar, 20, "phone_4"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_4", System.Data.SqlDbType.VarChar, 2, "extension_4"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_4", System.Data.SqlDbType.VarChar, 1, "phone_type_4"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_4", System.Data.SqlDbType.Bit, 1, "phone_main_4"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_5", System.Data.SqlDbType.VarChar, 20, "phone_5"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@extension_5", System.Data.SqlDbType.VarChar, 2, "extension_5"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_type_5", System.Data.SqlDbType.VarChar, 1, "phone_type_5"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone_main_5", System.Data.SqlDbType.Bit, 1, "phone_main_5"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@email", System.Data.SqlDbType.VarChar, 50, "email"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@notes", System.Data.SqlDbType.VarChar, 300, "notes"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pic", System.Data.SqlDbType.VarBinary, 2147483647, "pic"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@birthday_date", System.Data.SqlDbType.VarChar, 10, "birthday_date"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@hired_date", System.Data.SqlDbType.VarChar, 10, "hired_date"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_reiew_date", System.Data.SqlDbType.VarChar, 10, "last_reiew_date"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@terminate_date", System.Data.SqlDbType.VarChar, 10, "terminate_date"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@temporary_inactive", System.Data.SqlDbType.Bit, 1, "temporary_inactive"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_basis", System.Data.SqlDbType.VarChar, 1, "last_basis"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_period", System.Data.SqlDbType.VarChar, 1, "last_period"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_status", System.Data.SqlDbType.VarChar, 1, "last_status"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_salary", System.Data.SqlDbType.Real, 4, "last_salary"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_hourly", System.Data.SqlDbType.Real, 4, "last_hourly"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@last_overtime", System.Data.SqlDbType.Real, 4, "last_overtime"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_cod1", System.Data.SqlDbType.VarChar, 2, "deduction_cod1"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_amount1", System.Data.SqlDbType.Real, 4, "deduction_amount1"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_cod2", System.Data.SqlDbType.VarChar, 2, "deduction_cod2"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_amount2", System.Data.SqlDbType.Real, 4, "deduction_amount2"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_cod3", System.Data.SqlDbType.VarChar, 2, "deduction_cod3"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_amount3", System.Data.SqlDbType.Real, 4, "deduction_amount3"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_cod4", System.Data.SqlDbType.VarChar, 2, "deduction_cod4"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_amount4", System.Data.SqlDbType.Real, 4, "deduction_amount4"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_cod5", System.Data.SqlDbType.VarChar, 2, "deduction_cod5"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_amount5", System.Data.SqlDbType.Real, 4, "deduction_amount5"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_cod6", System.Data.SqlDbType.VarChar, 2, "deduction_cod6"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@deduction_amount6", System.Data.SqlDbType.Real, 4, "deduction_amount6"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Last_raise_date", System.Data.SqlDbType.VarChar, 10, "Last_raise_date"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ExemptionFederal", System.Data.SqlDbType.Real, 4, "ExemptionFederal"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ExemptionLocal", System.Data.SqlDbType.Real, 4, "ExemptionLocal"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ExemptionState", System.Data.SqlDbType.Real, 4, "ExemptionState"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Terminated", System.Data.SqlDbType.Bit, 1, "Terminated"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_employee_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employee_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ExemptionFederal", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExemptionFederal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ExemptionLocal", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExemptionLocal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ExemptionState", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExemptionState", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Last_raise_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Last_raise_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Terminated", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Terminated", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_birthday_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "birthday_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_deparment", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_deparment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_position", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_position", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_amount1", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_amount1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_amount2", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_amount2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_amount3", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_amount3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_amount4", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_amount4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_amount5", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_amount5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_amount6", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_amount6", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_cod1", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_cod1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_cod2", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_cod2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_cod3", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_cod3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_cod4", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_cod4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_cod5", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_cod5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_cod6", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_cod6", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_1", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_2", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_3", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_4", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_5", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_f_name", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "f_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_hired_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hired_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_l_name", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "l_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_basis", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_basis", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_hourly", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_hourly", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_overtime", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_overtime", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_period", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_period", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_reiew_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_reiew_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_salary", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_salary", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_status", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_status", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_m_name", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "m_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_notes", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "notes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_1", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_2", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_3", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_4", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_5", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_1", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_2", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_3", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_4", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_5", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_1", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_2", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_3", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_4", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_5", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_social_security_no", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "social_security_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_technecian", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "technecian", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_temporary_inactive", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "temporary_inactive", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_terminate_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "terminate_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_zipcode", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "zipcode", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM employee WHERE (employee_code = @Original_employee_code) AND (Exempti" & _
        "onFederal = @Original_ExemptionFederal OR @Original_ExemptionFederal IS NULL AND" & _
        " ExemptionFederal IS NULL) AND (ExemptionLocal = @Original_ExemptionLocal OR @Or" & _
        "iginal_ExemptionLocal IS NULL AND ExemptionLocal IS NULL) AND (ExemptionState = " & _
        "@Original_ExemptionState OR @Original_ExemptionState IS NULL AND ExemptionState " & _
        "IS NULL) AND (Last_raise_date = @Original_Last_raise_date OR @Original_Last_rais" & _
        "e_date IS NULL AND Last_raise_date IS NULL) AND (Terminated = @Original_Terminat" & _
        "ed OR @Original_Terminated IS NULL AND Terminated IS NULL) AND (address = @Origi" & _
        "nal_address OR @Original_address IS NULL AND address IS NULL) AND (birthday_date" & _
        " = @Original_birthday_date OR @Original_birthday_date IS NULL AND birthday_date " & _
        "IS NULL) AND (cod_deparment = @Original_cod_deparment OR @Original_cod_deparment" & _
        " IS NULL AND cod_deparment IS NULL) AND (cod_position = @Original_cod_position O" & _
        "R @Original_cod_position IS NULL AND cod_position IS NULL) AND (deduction_amount" & _
        "1 = @Original_deduction_amount1 OR @Original_deduction_amount1 IS NULL AND deduc" & _
        "tion_amount1 IS NULL) AND (deduction_amount2 = @Original_deduction_amount2 OR @O" & _
        "riginal_deduction_amount2 IS NULL AND deduction_amount2 IS NULL) AND (deduction_" & _
        "amount3 = @Original_deduction_amount3 OR @Original_deduction_amount3 IS NULL AND" & _
        " deduction_amount3 IS NULL) AND (deduction_amount4 = @Original_deduction_amount4" & _
        " OR @Original_deduction_amount4 IS NULL AND deduction_amount4 IS NULL) AND (dedu" & _
        "ction_amount5 = @Original_deduction_amount5 OR @Original_deduction_amount5 IS NU" & _
        "LL AND deduction_amount5 IS NULL) AND (deduction_amount6 = @Original_deduction_a" & _
        "mount6 OR @Original_deduction_amount6 IS NULL AND deduction_amount6 IS NULL) AND" & _
        " (deduction_cod1 = @Original_deduction_cod1 OR @Original_deduction_cod1 IS NULL " & _
        "AND deduction_cod1 IS NULL) AND (deduction_cod2 = @Original_deduction_cod2 OR @O" & _
        "riginal_deduction_cod2 IS NULL AND deduction_cod2 IS NULL) AND (deduction_cod3 =" & _
        " @Original_deduction_cod3 OR @Original_deduction_cod3 IS NULL AND deduction_cod3" & _
        " IS NULL) AND (deduction_cod4 = @Original_deduction_cod4 OR @Original_deduction_" & _
        "cod4 IS NULL AND deduction_cod4 IS NULL) AND (deduction_cod5 = @Original_deducti" & _
        "on_cod5 OR @Original_deduction_cod5 IS NULL AND deduction_cod5 IS NULL) AND (ded" & _
        "uction_cod6 = @Original_deduction_cod6 OR @Original_deduction_cod6 IS NULL AND d" & _
        "eduction_cod6 IS NULL) AND (email = @Original_email OR @Original_email IS NULL A" & _
        "ND email IS NULL) AND (extension_1 = @Original_extension_1 OR @Original_extensio" & _
        "n_1 IS NULL AND extension_1 IS NULL) AND (extension_2 = @Original_extension_2 OR" & _
        " @Original_extension_2 IS NULL AND extension_2 IS NULL) AND (extension_3 = @Orig" & _
        "inal_extension_3 OR @Original_extension_3 IS NULL AND extension_3 IS NULL) AND (" & _
        "extension_4 = @Original_extension_4 OR @Original_extension_4 IS NULL AND extensi" & _
        "on_4 IS NULL) AND (extension_5 = @Original_extension_5 OR @Original_extension_5 " & _
        "IS NULL AND extension_5 IS NULL) AND (f_name = @Original_f_name OR @Original_f_n" & _
        "ame IS NULL AND f_name IS NULL) AND (hired_date = @Original_hired_date OR @Origi" & _
        "nal_hired_date IS NULL AND hired_date IS NULL) AND (l_name = @Original_l_name OR" & _
        " @Original_l_name IS NULL AND l_name IS NULL) AND (last_basis = @Original_last_b" & _
        "asis OR @Original_last_basis IS NULL AND last_basis IS NULL) AND (last_hourly = " & _
        "@Original_last_hourly OR @Original_last_hourly IS NULL AND last_hourly IS NULL) " & _
        "AND (last_overtime = @Original_last_overtime OR @Original_last_overtime IS NULL " & _
        "AND last_overtime IS NULL) AND (last_period = @Original_last_period OR @Original" & _
        "_last_period IS NULL AND last_period IS NULL) AND (last_reiew_date = @Original_l" & _
        "ast_reiew_date OR @Original_last_reiew_date IS NULL AND last_reiew_date IS NULL)" & _
        " AND (last_salary = @Original_last_salary OR @Original_last_salary IS NULL AND l" & _
        "ast_salary IS NULL) AND (last_status = @Original_last_status OR @Original_last_s" & _
        "tatus IS NULL AND last_status IS NULL) AND (m_name = @Original_m_name OR @Origin" & _
        "al_m_name IS NULL AND m_name IS NULL) AND (notes = @Original_notes OR @Original_" & _
        "notes IS NULL AND notes IS NULL) AND (phone_1 = @Original_phone_1 OR @Original_p" & _
        "hone_1 IS NULL AND phone_1 IS NULL) AND (phone_2 = @Original_phone_2 OR @Origina" & _
        "l_phone_2 IS NULL AND phone_2 IS NULL) AND (phone_3 = @Original_phone_3 OR @Orig" & _
        "inal_phone_3 IS NULL AND phone_3 IS NULL) AND (phone_4 = @Original_phone_4 OR @O" & _
        "riginal_phone_4 IS NULL AND phone_4 IS NULL) AND (phone_5 = @Original_phone_5 OR" & _
        " @Original_phone_5 IS NULL AND phone_5 IS NULL) AND (phone_main_1 = @Original_ph" & _
        "one_main_1 OR @Original_phone_main_1 IS NULL AND phone_main_1 IS NULL) AND (phon" & _
        "e_main_2 = @Original_phone_main_2 OR @Original_phone_main_2 IS NULL AND phone_ma" & _
        "in_2 IS NULL) AND (phone_main_3 = @Original_phone_main_3 OR @Original_phone_main" & _
        "_3 IS NULL AND phone_main_3 IS NULL) AND (phone_main_4 = @Original_phone_main_4 " & _
        "OR @Original_phone_main_4 IS NULL AND phone_main_4 IS NULL) AND (phone_main_5 = " & _
        "@Original_phone_main_5 OR @Original_phone_main_5 IS NULL AND phone_main_5 IS NUL" & _
        "L) AND (phone_type_1 = @Original_phone_type_1 OR @Original_phone_type_1 IS NULL " & _
        "AND phone_type_1 IS NULL) AND (phone_type_2 = @Original_phone_type_2 OR @Origina" & _
        "l_phone_type_2 IS NULL AND phone_type_2 IS NULL) AND (phone_type_3 = @Original_p" & _
        "hone_type_3 OR @Original_phone_type_3 IS NULL AND phone_type_3 IS NULL) AND (pho" & _
        "ne_type_4 = @Original_phone_type_4 OR @Original_phone_type_4 IS NULL AND phone_t" & _
        "ype_4 IS NULL) AND (phone_type_5 = @Original_phone_type_5 OR @Original_phone_typ" & _
        "e_5 IS NULL AND phone_type_5 IS NULL) AND (social_security_no = @Original_social" & _
        "_security_no OR @Original_social_security_no IS NULL AND social_security_no IS N" & _
        "ULL) AND (technecian = @Original_technecian OR @Original_technecian IS NULL AND " & _
        "technecian IS NULL) AND (temporary_inactive = @Original_temporary_inactive OR @O" & _
        "riginal_temporary_inactive IS NULL AND temporary_inactive IS NULL) AND (terminat" & _
        "e_date = @Original_terminate_date OR @Original_terminate_date IS NULL AND termin" & _
        "ate_date IS NULL) AND (zipcode = @Original_zipcode OR @Original_zipcode IS NULL " & _
        "AND zipcode IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_employee_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employee_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ExemptionFederal", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExemptionFederal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ExemptionLocal", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExemptionLocal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ExemptionState", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ExemptionState", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Last_raise_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Last_raise_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Terminated", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Terminated", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_address", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "address", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_birthday_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "birthday_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_deparment", System.Data.SqlDbType.VarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_deparment", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cod_position", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cod_position", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_amount1", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_amount1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_amount2", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_amount2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_amount3", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_amount3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_amount4", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_amount4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_amount5", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_amount5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_amount6", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_amount6", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_cod1", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_cod1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_cod2", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_cod2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_cod3", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_cod3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_cod4", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_cod4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_cod5", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_cod5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_deduction_cod6", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "deduction_cod6", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_email", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "email", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_1", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_2", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_3", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_4", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_extension_5", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "extension_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_f_name", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "f_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_hired_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "hired_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_l_name", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "l_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_basis", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_basis", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_hourly", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_hourly", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_overtime", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_overtime", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_period", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_period", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_reiew_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_reiew_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_salary", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_salary", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_last_status", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "last_status", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_m_name", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "m_name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_notes", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "notes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_1", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_2", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_3", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_4", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_5", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_1", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_2", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_3", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_4", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_main_5", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_main_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_1", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_2", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_3", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_4", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone_type_5", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone_type_5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_social_security_no", System.Data.SqlDbType.VarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "social_security_no", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_technecian", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "technecian", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_temporary_inactive", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "temporary_inactive", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_terminate_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "terminate_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_zipcode", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "zipcode", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "employee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("f_name", "f_name"), New System.Data.Common.DataColumnMapping("m_name", "m_name"), New System.Data.Common.DataColumnMapping("l_name", "l_name"), New System.Data.Common.DataColumnMapping("address", "address"), New System.Data.Common.DataColumnMapping("zipcode", "zipcode"), New System.Data.Common.DataColumnMapping("technecian", "technecian"), New System.Data.Common.DataColumnMapping("social_security_no", "social_security_no"), New System.Data.Common.DataColumnMapping("cod_position", "cod_position"), New System.Data.Common.DataColumnMapping("cod_deparment", "cod_deparment"), New System.Data.Common.DataColumnMapping("phone_1", "phone_1"), New System.Data.Common.DataColumnMapping("extension_1", "extension_1"), New System.Data.Common.DataColumnMapping("phone_type_1", "phone_type_1"), New System.Data.Common.DataColumnMapping("phone_main_1", "phone_main_1"), New System.Data.Common.DataColumnMapping("phone_2", "phone_2"), New System.Data.Common.DataColumnMapping("extension_2", "extension_2"), New System.Data.Common.DataColumnMapping("phone_type_2", "phone_type_2"), New System.Data.Common.DataColumnMapping("phone_main_2", "phone_main_2"), New System.Data.Common.DataColumnMapping("phone_3", "phone_3"), New System.Data.Common.DataColumnMapping("extension_3", "extension_3"), New System.Data.Common.DataColumnMapping("phone_type_3", "phone_type_3"), New System.Data.Common.DataColumnMapping("phone_main_3", "phone_main_3"), New System.Data.Common.DataColumnMapping("phone_4", "phone_4"), New System.Data.Common.DataColumnMapping("extension_4", "extension_4"), New System.Data.Common.DataColumnMapping("phone_type_4", "phone_type_4"), New System.Data.Common.DataColumnMapping("phone_main_4", "phone_main_4"), New System.Data.Common.DataColumnMapping("phone_5", "phone_5"), New System.Data.Common.DataColumnMapping("extension_5", "extension_5"), New System.Data.Common.DataColumnMapping("phone_type_5", "phone_type_5"), New System.Data.Common.DataColumnMapping("phone_main_5", "phone_main_5"), New System.Data.Common.DataColumnMapping("email", "email"), New System.Data.Common.DataColumnMapping("notes", "notes"), New System.Data.Common.DataColumnMapping("pic", "pic"), New System.Data.Common.DataColumnMapping("birthday_date", "birthday_date"), New System.Data.Common.DataColumnMapping("hired_date", "hired_date"), New System.Data.Common.DataColumnMapping("last_reiew_date", "last_reiew_date"), New System.Data.Common.DataColumnMapping("terminate_date", "terminate_date"), New System.Data.Common.DataColumnMapping("temporary_inactive", "temporary_inactive"), New System.Data.Common.DataColumnMapping("last_basis", "last_basis"), New System.Data.Common.DataColumnMapping("last_period", "last_period"), New System.Data.Common.DataColumnMapping("last_status", "last_status"), New System.Data.Common.DataColumnMapping("last_salary", "last_salary"), New System.Data.Common.DataColumnMapping("last_hourly", "last_hourly"), New System.Data.Common.DataColumnMapping("last_overtime", "last_overtime"), New System.Data.Common.DataColumnMapping("deduction_cod1", "deduction_cod1"), New System.Data.Common.DataColumnMapping("deduction_amount1", "deduction_amount1"), New System.Data.Common.DataColumnMapping("deduction_cod2", "deduction_cod2"), New System.Data.Common.DataColumnMapping("deduction_amount2", "deduction_amount2"), New System.Data.Common.DataColumnMapping("deduction_cod3", "deduction_cod3"), New System.Data.Common.DataColumnMapping("deduction_amount3", "deduction_amount3"), New System.Data.Common.DataColumnMapping("deduction_cod4", "deduction_cod4"), New System.Data.Common.DataColumnMapping("deduction_amount4", "deduction_amount4"), New System.Data.Common.DataColumnMapping("deduction_cod5", "deduction_cod5"), New System.Data.Common.DataColumnMapping("deduction_amount5", "deduction_amount5"), New System.Data.Common.DataColumnMapping("deduction_cod6", "deduction_cod6"), New System.Data.Common.DataColumnMapping("deduction_amount6", "deduction_amount6"), New System.Data.Common.DataColumnMapping("Last_raise_date", "Last_raise_date"), New System.Data.Common.DataColumnMapping("ExemptionFederal", "ExemptionFederal"), New System.Data.Common.DataColumnMapping("ExemptionLocal", "ExemptionLocal"), New System.Data.Common.DataColumnMapping("ExemptionState", "ExemptionState"), New System.Data.Common.DataColumnMapping("Terminated", "Terminated")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'GridEX1
        '
        Me.GridEX1.DataMember = "employee"
        Me.GridEX1.DataSource = Me.DataSet11
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Caption>employee</Caption><Columns Collection=""true" & _
        """><Column0 ID=""employee_code""><Caption>employee_code</Caption><TypeNameEmptyStri" & _
        "ngValue>System.String</TypeNameEmptyStringValue><EmptyStringValue /><DataMember>" & _
        "employee_code</DataMember><Key>employee_code</Key><Position>0</Position></Column" & _
        "0><Column1 ID=""f_name""><Caption>f_name</Caption><DataMember>f_name</DataMember><" & _
        "Key>f_name</Key><Position>1</Position></Column1><Column2 ID=""m_name""><Caption>m_" & _
        "name</Caption><DataMember>m_name</DataMember><Key>m_name</Key><Position>2</Posit" & _
        "ion></Column2><Column3 ID=""l_name""><Caption>l_name</Caption><DataMember>l_name</" & _
        "DataMember><Key>l_name</Key><Position>3</Position></Column3><Column4 ID=""address" & _
        """><Caption>address</Caption><DataMember>address</DataMember><Key>address</Key><P" & _
        "osition>4</Position></Column4><Column5 ID=""zipcode""><Caption>zipcode</Caption><D" & _
        "ataMember>zipcode</DataMember><Key>zipcode</Key><Position>5</Position></Column5>" & _
        "<Column6 ID=""technecian""><Caption>technecian</Caption><ColumnType>CheckBox</Colu" & _
        "mnType><DataMember>technecian</DataMember><EditType>CheckBox</EditType><Key>tech" & _
        "necian</Key><Position>6</Position></Column6><Column7 ID=""social_security_no""><Ca" & _
        "ption>social_security_no</Caption><DataMember>social_security_no</DataMember><Ke" & _
        "y>social_security_no</Key><Position>7</Position></Column7><Column8 ID=""cod_posit" & _
        "ion""><Caption>cod_position</Caption><DataMember>cod_position</DataMember><Key>co" & _
        "d_position</Key><Position>8</Position></Column8><Column9 ID=""cod_deparment""><Cap" & _
        "tion>cod_deparment</Caption><DataMember>cod_deparment</DataMember><Key>cod_depar" & _
        "ment</Key><Position>9</Position></Column9><Column10 ID=""phone_1""><Caption>phone_" & _
        "1</Caption><DataMember>phone_1</DataMember><Key>phone_1</Key><Position>10</Posit" & _
        "ion></Column10><Column11 ID=""extension_1""><Caption>extension_1</Caption><DataMem" & _
        "ber>extension_1</DataMember><Key>extension_1</Key><Position>11</Position></Colum" & _
        "n11><Column12 ID=""phone_type_1""><Caption>phone_type_1</Caption><DataMember>phone" & _
        "_type_1</DataMember><Key>phone_type_1</Key><Position>12</Position></Column12><Co" & _
        "lumn13 ID=""phone_main_1""><Caption>phone_main_1</Caption><ColumnType>CheckBox</Co" & _
        "lumnType><DataMember>phone_main_1</DataMember><EditType>CheckBox</EditType><Key>" & _
        "phone_main_1</Key><Position>13</Position></Column13><Column14 ID=""phone_2""><Capt" & _
        "ion>phone_2</Caption><DataMember>phone_2</DataMember><Key>phone_2</Key><Position" & _
        ">14</Position></Column14><Column15 ID=""extension_2""><Caption>extension_2</Captio" & _
        "n><DataMember>extension_2</DataMember><Key>extension_2</Key><Position>15</Positi" & _
        "on></Column15><Column16 ID=""phone_type_2""><Caption>phone_type_2</Caption><DataMe" & _
        "mber>phone_type_2</DataMember><Key>phone_type_2</Key><Position>16</Position></Co" & _
        "lumn16><Column17 ID=""phone_main_2""><Caption>phone_main_2</Caption><ColumnType>Ch" & _
        "eckBox</ColumnType><DataMember>phone_main_2</DataMember><EditType>CheckBox</Edit" & _
        "Type><Key>phone_main_2</Key><Position>17</Position></Column17><Column18 ID=""phon" & _
        "e_3""><Caption>phone_3</Caption><DataMember>phone_3</DataMember><Key>phone_3</Key" & _
        "><Position>18</Position></Column18><Column19 ID=""extension_3""><Caption>extension" & _
        "_3</Caption><DataMember>extension_3</DataMember><Key>extension_3</Key><Position>" & _
        "19</Position></Column19><Column20 ID=""phone_type_3""><Caption>phone_type_3</Capti" & _
        "on><DataMember>phone_type_3</DataMember><Key>phone_type_3</Key><Position>20</Pos" & _
        "ition></Column20><Column21 ID=""phone_main_3""><Caption>phone_main_3</Caption><Col" & _
        "umnType>CheckBox</ColumnType><DataMember>phone_main_3</DataMember><EditType>Chec" & _
        "kBox</EditType><Key>phone_main_3</Key><Position>21</Position></Column21><Column2" & _
        "2 ID=""phone_4""><Caption>phone_4</Caption><DataMember>phone_4</DataMember><Key>ph" & _
        "one_4</Key><Position>22</Position></Column22><Column23 ID=""extension_4""><Caption" & _
        ">extension_4</Caption><DataMember>extension_4</DataMember><Key>extension_4</Key>" & _
        "<Position>23</Position></Column23><Column24 ID=""phone_type_4""><Caption>phone_typ" & _
        "e_4</Caption><DataMember>phone_type_4</DataMember><Key>phone_type_4</Key><Positi" & _
        "on>24</Position></Column24><Column25 ID=""phone_main_4""><Caption>phone_main_4</Ca" & _
        "ption><ColumnType>CheckBox</ColumnType><DataMember>phone_main_4</DataMember><Edi" & _
        "tType>CheckBox</EditType><Key>phone_main_4</Key><Position>25</Position></Column2" & _
        "5><Column26 ID=""phone_5""><Caption>phone_5</Caption><DataMember>phone_5</DataMemb" & _
        "er><Key>phone_5</Key><Position>26</Position></Column26><Column27 ID=""extension_5" & _
        """><Caption>extension_5</Caption><DataMember>extension_5</DataMember><Key>extensi" & _
        "on_5</Key><Position>27</Position></Column27><Column28 ID=""phone_type_5""><Caption" & _
        ">phone_type_5</Caption><DataMember>phone_type_5</DataMember><Key>phone_type_5</K" & _
        "ey><Position>28</Position></Column28><Column29 ID=""phone_main_5""><Caption>phone_" & _
        "main_5</Caption><ColumnType>CheckBox</ColumnType><DataMember>phone_main_5</DataM" & _
        "ember><EditType>CheckBox</EditType><Key>phone_main_5</Key><Position>29</Position" & _
        "></Column29><Column30 ID=""email""><Caption>email</Caption><DataMember>email</Data" & _
        "Member><Key>email</Key><Position>30</Position></Column30><Column31 ID=""notes""><C" & _
        "aption>notes</Caption><DataMember>notes</DataMember><Key>notes</Key><Position>31" & _
        "</Position></Column31><Column32 ID=""pic""><AllowGroup>False</AllowGroup><AllowSor" & _
        "t>False</AllowSort><Caption>pic</Caption><ColumnType>BoundImage</ColumnType><Dat" & _
        "aMember>pic</DataMember><EditType>NoEdit</EditType><Key>pic</Key><Position>32</P" & _
        "osition></Column32><Column33 ID=""birthday_date""><Caption>birthday_date</Caption>" & _
        "<DataMember>birthday_date</DataMember><Key>birthday_date</Key><Position>33</Posi" & _
        "tion></Column33><Column34 ID=""hired_date""><Caption>hired_date</Caption><DataMemb" & _
        "er>hired_date</DataMember><Key>hired_date</Key><Position>34</Position></Column34" & _
        "><Column35 ID=""last_reiew_date""><Caption>last_reiew_date</Caption><DataMember>la" & _
        "st_reiew_date</DataMember><Key>last_reiew_date</Key><Position>35</Position></Col" & _
        "umn35><Column36 ID=""terminate_date""><Caption>terminate_date</Caption><DataMember" & _
        ">terminate_date</DataMember><Key>terminate_date</Key><Position>36</Position></Co" & _
        "lumn36><Column37 ID=""temporary_inactive""><Caption>temporary_inactive</Caption><C" & _
        "olumnType>CheckBox</ColumnType><DataMember>temporary_inactive</DataMember><EditT" & _
        "ype>CheckBox</EditType><Key>temporary_inactive</Key><Position>37</Position></Col" & _
        "umn37><Column38 ID=""last_basis""><Caption>last_basis</Caption><DataMember>last_ba" & _
        "sis</DataMember><Key>last_basis</Key><Position>38</Position></Column38><Column39" & _
        " ID=""last_period""><Caption>last_period</Caption><DataMember>last_period</DataMem" & _
        "ber><Key>last_period</Key><Position>39</Position></Column39><Column40 ID=""last_s" & _
        "tatus""><Caption>last_status</Caption><DataMember>last_status</DataMember><Key>la" & _
        "st_status</Key><Position>40</Position></Column40><Column41 ID=""last_salary""><Cap" & _
        "tion>last_salary</Caption><DataMember>last_salary</DataMember><Key>last_salary</" & _
        "Key><Position>41</Position></Column41><Column42 ID=""last_hourly""><Caption>last_h" & _
        "ourly</Caption><DataMember>last_hourly</DataMember><Key>last_hourly</Key><Positi" & _
        "on>42</Position></Column42><Column43 ID=""last_overtime""><Caption>last_overtime</" & _
        "Caption><DataMember>last_overtime</DataMember><Key>last_overtime</Key><Position>" & _
        "43</Position></Column43><Column44 ID=""deduction_cod1""><Caption>deduction_cod1</C" & _
        "aption><DataMember>deduction_cod1</DataMember><Key>deduction_cod1</Key><Position" & _
        ">44</Position></Column44><Column45 ID=""deduction_amount1""><Caption>deduction_amo" & _
        "unt1</Caption><DataMember>deduction_amount1</DataMember><Key>deduction_amount1</" & _
        "Key><Position>45</Position></Column45><Column46 ID=""deduction_cod2""><Caption>ded" & _
        "uction_cod2</Caption><DataMember>deduction_cod2</DataMember><Key>deduction_cod2<" & _
        "/Key><Position>46</Position></Column46><Column47 ID=""deduction_amount2""><Caption" & _
        ">deduction_amount2</Caption><DataMember>deduction_amount2</DataMember><Key>deduc" & _
        "tion_amount2</Key><Position>47</Position></Column47><Column48 ID=""deduction_cod3" & _
        """><Caption>deduction_cod3</Caption><DataMember>deduction_cod3</DataMember><Key>d" & _
        "eduction_cod3</Key><Position>48</Position></Column48><Column49 ID=""deduction_amo" & _
        "unt3""><Caption>deduction_amount3</Caption><DataMember>deduction_amount3</DataMem" & _
        "ber><Key>deduction_amount3</Key><Position>49</Position></Column49><Column50 ID=""" & _
        "deduction_cod4""><Caption>deduction_cod4</Caption><DataMember>deduction_cod4</Dat" & _
        "aMember><Key>deduction_cod4</Key><Position>50</Position></Column50><Column51 ID=" & _
        """deduction_amount4""><Caption>deduction_amount4</Caption><DataMember>deduction_am" & _
        "ount4</DataMember><Key>deduction_amount4</Key><Position>51</Position></Column51>" & _
        "<Column52 ID=""deduction_cod5""><Caption>deduction_cod5</Caption><DataMember>deduc" & _
        "tion_cod5</DataMember><Key>deduction_cod5</Key><Position>52</Position></Column52" & _
        "><Column53 ID=""deduction_amount5""><Caption>deduction_amount5</Caption><DataMembe" & _
        "r>deduction_amount5</DataMember><Key>deduction_amount5</Key><Position>53</Positi" & _
        "on></Column53><Column54 ID=""deduction_cod6""><Caption>deduction_cod6</Caption><Da" & _
        "taMember>deduction_cod6</DataMember><Key>deduction_cod6</Key><Position>54</Posit" & _
        "ion></Column54><Column55 ID=""deduction_amount6""><Caption>deduction_amount6</Capt" & _
        "ion><DataMember>deduction_amount6</DataMember><Key>deduction_amount6</Key><Posit" & _
        "ion>55</Position></Column55><Column56 ID=""Last_raise_date""><Caption>Last_raise_d" & _
        "ate</Caption><DataMember>Last_raise_date</DataMember><Key>Last_raise_date</Key><" & _
        "Position>56</Position></Column56><Column57 ID=""ExemptionFederal""><Caption>Exempt" & _
        "ionFederal</Caption><DataMember>ExemptionFederal</DataMember><Key>ExemptionFeder" & _
        "al</Key><Position>57</Position></Column57><Column58 ID=""ExemptionLocal""><Caption" & _
        ">ExemptionLocal</Caption><DataMember>ExemptionLocal</DataMember><Key>ExemptionLo" & _
        "cal</Key><Position>58</Position></Column58><Column59 ID=""ExemptionState""><Captio" & _
        "n>ExemptionState</Caption><DataMember>ExemptionState</DataMember><Key>ExemptionS" & _
        "tate</Key><Position>59</Position></Column59><Column60 ID=""Terminated""><Caption>T" & _
        "erminated</Caption><ColumnType>CheckBox</ColumnType><DataMember>Terminated</Data" & _
        "Member><EditType>CheckBox</EditType><Key>Terminated</Key><Position>60</Position>" & _
        "</Column60></Columns><GroupCondition ID="""" /><Key>employee</Key></RootTable></Gr" & _
        "idEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEXLayout1
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridEX1.Location = New System.Drawing.Point(0, 0)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.Size = New System.Drawing.Size(856, 518)
        Me.GridEX1.TabIndex = 0
        '
        'Sqlupdate
        '
        Me.Sqlupdate.CommandText = "UPDATE employee SET f_name = @f_name, pic = @pic WHERE (employee_code = @employee" & _
        "_code)"
        Me.Sqlupdate.Connection = Me.SqlConnection1
        Me.Sqlupdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@f_name", System.Data.SqlDbType.VarChar, 20, "f_name"))
        Me.Sqlupdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pic", System.Data.SqlDbType.VarBinary, 16, "pic"))
        Me.Sqlupdate.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employee_code", System.Data.DataRowVersion.Original, Nothing))
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(728, 376)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 419
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(656, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 21)
        Me.Button1.TabIndex = 418
        Me.Button1.Text = "Insert"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(488, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 23)
        Me.Button2.TabIndex = 420
        Me.Button2.Text = "update"
        '
        'SqlInsert
        '
        Me.SqlInsert.CommandText = "INSERT INTO employee (employee_code, f_name, pic) VALUES (@Employee_Code, @f_name" & _
        ", @pic)"
        Me.SqlInsert.Connection = Me.SqlConnection1
        Me.SqlInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Employee_Code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.SqlInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@f_name", System.Data.SqlDbType.VarChar, 20, "f_name"))
        Me.SqlInsert.Parameters.Add(New System.Data.SqlClient.SqlParameter("@pic", System.Data.SqlDbType.VarBinary, 2147483647, "pic"))
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(736, 224)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(121, 136)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 421
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(856, 518)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GridEX1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.Open()
        SqlDataAdapter1.Fill(DataSet11.employee)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        Dim arrImage() As Byte = ms.GetBuffer
        SqlInsert.Parameters("@Employee_Code").Value = "2345"
        SqlInsert.Parameters("@f_Name").Value = "232312312321312Inserted"
        SqlInsert.Parameters("@Pic").Value = arrImage
        SqlInsert.ExecuteNonQuery()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox2.Image.RawFormat)
        Dim arrImage() As Byte = ms.GetBuffer
        Sqlupdate.Parameters("@Employee_Code").Value = "2345"
        Sqlupdate.Parameters("@f_Name").Value = "updated"
        Sqlupdate.Parameters("@Pic").Value = arrImage
        Sqlupdate.ExecuteNonQuery()
    End Sub
End Class
