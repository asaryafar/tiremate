Imports CommonClass
Imports System
Public Class FrmPunchClock
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
    Friend WithEvents Employee_Cod1 As UCEmployee.Employee_Cod
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cnn As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsFrmPunchClock1 As UCTimeSheet.DSFrmPunchClock
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DApay_tab_punch_note As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents LblEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents CmbPunch_note_code As System.Windows.Forms.ComboBox
    Friend WithEvents BtnIn As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnOut As Janus.Windows.EditControls.UIButton
    Friend WithEvents CmdGeneral As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LblDate As System.Windows.Forms.Label
    Friend WithEvents LblTime As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DApay_punch_employee_in_out As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPunchClock))
        Me.Employee_Cod1 = New UCEmployee.Employee_Cod
        Me.Cnn = New System.Data.SqlClient.SqlConnection
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblEmployeeName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmbPunch_note_code = New System.Windows.Forms.ComboBox
        Me.DsFrmPunchClock1 = New UCTimeSheet.DSFrmPunchClock
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnIn = New Janus.Windows.EditControls.UIButton
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DApay_tab_punch_note = New System.Data.SqlClient.SqlDataAdapter
        Me.BtnOut = New Janus.Windows.EditControls.UIButton
        Me.CmdGeneral = New System.Data.SqlClient.SqlCommand
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblDate = New System.Windows.Forms.Label
        Me.LblTime = New System.Windows.Forms.Label
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DApay_punch_employee_in_out = New System.Data.SqlClient.SqlDataAdapter
        CType(Me.DsFrmPunchClock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Employee_Cod1
        '
        Me.Employee_Cod1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Employee_Cod1.Connection = Me.Cnn
        Me.Employee_Cod1.EmployeeCod = ""
        Me.Employee_Cod1.EmployeeCodLen = 5
        Me.Employee_Cod1.Kind_Employee = "0"
        Me.Employee_Cod1.Location = New System.Drawing.Point(5, 53)
        Me.Employee_Cod1.Name = "Employee_Cod1"
        Me.Employee_Cod1.NotExitIfNotFound = False
        Me.Employee_Cod1.ReleaseIfNotFoundEmployeeCod = False
        Me.Employee_Cod1.Size = New System.Drawing.Size(101, 20)
        Me.Employee_Cod1.TabIndex = 0
        '
        'Cnn
        '
        Me.Cnn.ConnectionString = "workstation id=BAMDADIXP;packet size=4096;user id=sa;initial catalog=TireMate_01;" & _
        "persist security info=True;password=sa"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(5, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 14)
        Me.Label2.TabIndex = 383
        Me.Label2.Text = "Employee"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(105, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 14)
        Me.Label1.TabIndex = 384
        Me.Label1.Text = "Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblEmployeeName
        '
        Me.LblEmployeeName.BackColor = System.Drawing.Color.FromArgb(CType(247, Byte), CType(227, Byte), CType(104, Byte))
        Me.LblEmployeeName.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblEmployeeName.Location = New System.Drawing.Point(110, 54)
        Me.LblEmployeeName.MaxLength = 100
        Me.LblEmployeeName.Name = "LblEmployeeName"
        Me.LblEmployeeName.ReadOnly = True
        Me.LblEmployeeName.Size = New System.Drawing.Size(260, 21)
        Me.LblEmployeeName.TabIndex = 385
        Me.LblEmployeeName.TabStop = False
        Me.LblEmployeeName.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(9, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 14)
        Me.Label3.TabIndex = 386
        Me.Label3.Text = "Punch Note"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbPunch_note_code
        '
        Me.CmbPunch_note_code.DataSource = Me.DsFrmPunchClock1.pay_tab_punch_note
        Me.CmbPunch_note_code.DisplayMember = "punch_note_desc"
        Me.CmbPunch_note_code.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPunch_note_code.Location = New System.Drawing.Point(88, 93)
        Me.CmbPunch_note_code.Name = "CmbPunch_note_code"
        Me.CmbPunch_note_code.Size = New System.Drawing.Size(282, 21)
        Me.CmbPunch_note_code.TabIndex = 1
        Me.CmbPunch_note_code.ValueMember = "punch_note_code"
        '
        'DsFrmPunchClock1
        '
        Me.DsFrmPunchClock1.DataSetName = "DSFrmPunchClock"
        Me.DsFrmPunchClock1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(31, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(219, 93)
        Me.Label4.TabIndex = 388
        Me.Label4.Text = "Punch"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnIn
        '
        Me.BtnIn.Image = CType(resources.GetObject("BtnIn.Image"), System.Drawing.Image)
        Me.BtnIn.ImageSize = New System.Drawing.Size(93, 93)
        Me.BtnIn.Location = New System.Drawing.Point(250, 131)
        Me.BtnIn.Name = "BtnIn"
        Me.BtnIn.Size = New System.Drawing.Size(93, 93)
        Me.BtnIn.TabIndex = 390
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT punch_note_code, punch_note_desc, type_in_out FROM pay_tab_punch_note"
        Me.SqlSelectCommand2.Connection = Me.Cnn
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO pay_tab_punch_note(punch_note_code, punch_note_desc, type_in_out) VAL" & _
        "UES (@punch_note_code, @punch_note_desc, @type_in_out); SELECT punch_note_code, " & _
        "punch_note_desc, type_in_out FROM pay_tab_punch_note WHERE (punch_note_code = @p" & _
        "unch_note_code)"
        Me.SqlInsertCommand2.Connection = Me.Cnn
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@punch_note_code", System.Data.SqlDbType.VarChar, 2, "punch_note_code"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@punch_note_desc", System.Data.SqlDbType.VarChar, 50, "punch_note_desc"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_in_out", System.Data.SqlDbType.Bit, 1, "type_in_out"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE pay_tab_punch_note SET punch_note_code = @punch_note_code, punch_note_desc" & _
        " = @punch_note_desc, type_in_out = @type_in_out WHERE (punch_note_code = @Origin" & _
        "al_punch_note_code) AND (punch_note_desc = @Original_punch_note_desc OR @Origina" & _
        "l_punch_note_desc IS NULL AND punch_note_desc IS NULL) AND (type_in_out = @Origi" & _
        "nal_type_in_out OR @Original_type_in_out IS NULL AND type_in_out IS NULL); SELEC" & _
        "T punch_note_code, punch_note_desc, type_in_out FROM pay_tab_punch_note WHERE (p" & _
        "unch_note_code = @punch_note_code)"
        Me.SqlUpdateCommand2.Connection = Me.Cnn
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@punch_note_code", System.Data.SqlDbType.VarChar, 2, "punch_note_code"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@punch_note_desc", System.Data.SqlDbType.VarChar, 50, "punch_note_desc"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@type_in_out", System.Data.SqlDbType.Bit, 1, "type_in_out"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_punch_note_code", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "punch_note_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_punch_note_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "punch_note_desc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_in_out", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_in_out", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM pay_tab_punch_note WHERE (punch_note_code = @Original_punch_note_code" & _
        ") AND (punch_note_desc = @Original_punch_note_desc OR @Original_punch_note_desc " & _
        "IS NULL AND punch_note_desc IS NULL) AND (type_in_out = @Original_type_in_out OR" & _
        " @Original_type_in_out IS NULL AND type_in_out IS NULL)"
        Me.SqlDeleteCommand2.Connection = Me.Cnn
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_punch_note_code", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "punch_note_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_punch_note_desc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "punch_note_desc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_type_in_out", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "type_in_out", System.Data.DataRowVersion.Original, Nothing))
        '
        'DApay_tab_punch_note
        '
        Me.DApay_tab_punch_note.DeleteCommand = Me.SqlDeleteCommand2
        Me.DApay_tab_punch_note.InsertCommand = Me.SqlInsertCommand2
        Me.DApay_tab_punch_note.SelectCommand = Me.SqlSelectCommand2
        Me.DApay_tab_punch_note.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_tab_punch_note", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("punch_note_code", "punch_note_code"), New System.Data.Common.DataColumnMapping("punch_note_desc", "punch_note_desc"), New System.Data.Common.DataColumnMapping("type_in_out", "type_in_out")})})
        Me.DApay_tab_punch_note.UpdateCommand = Me.SqlUpdateCommand2
        '
        'BtnOut
        '
        Me.BtnOut.Appearance = Janus.Windows.UI.Appearance.Normal
        Me.BtnOut.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Button
        Me.BtnOut.Image = CType(resources.GetObject("BtnOut.Image"), System.Drawing.Image)
        Me.BtnOut.ImageSize = New System.Drawing.Size(93, 93)
        Me.BtnOut.Location = New System.Drawing.Point(250, 131)
        Me.BtnOut.Name = "BtnOut"
        Me.BtnOut.Size = New System.Drawing.Size(93, 93)
        Me.BtnOut.TabIndex = 2
        '
        'CmdGeneral
        '
        Me.CmdGeneral.Connection = Me.Cnn
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(25, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 14)
        Me.Label5.TabIndex = 391
        Me.Label5.Text = "Date"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(196, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 14)
        Me.Label6.TabIndex = 392
        Me.Label6.Text = "Time"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'LblDate
        '
        Me.LblDate.BackColor = System.Drawing.Color.Transparent
        Me.LblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblDate.Location = New System.Drawing.Point(85, 5)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(79, 19)
        Me.LblDate.TabIndex = 393
        Me.LblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTime
        '
        Me.LblTime.BackColor = System.Drawing.Color.Transparent
        Me.LblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblTime.Location = New System.Drawing.Point(244, 4)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(96, 19)
        Me.LblTime.TabIndex = 394
        Me.LblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT id_punch_in_out, employee_code, action_date, action_time_Hour, action_time" & _
        "_Minute, punch_note_code, In_Out_type FROM pay_punch_employee_in_out"
        Me.SqlSelectCommand1.Connection = Me.Cnn
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO pay_punch_employee_in_out(employee_code, action_date, action_time_Hou" & _
        "r, action_time_Minute, punch_note_code, In_Out_type) VALUES (@employee_code, @ac" & _
        "tion_date, @action_time_Hour, @action_time_Minute, @punch_note_code, @In_Out_typ" & _
        "e); SELECT id_punch_in_out, employee_code, action_date, action_time_Hour, action" & _
        "_time_Minute, punch_note_code, In_Out_type FROM pay_punch_employee_in_out WHERE " & _
        "(id_punch_in_out = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.Cnn
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@action_date", System.Data.SqlDbType.VarChar, 10, "action_date"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@action_time_Hour", System.Data.SqlDbType.VarChar, 2, "action_time_Hour"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@action_time_Minute", System.Data.SqlDbType.VarChar, 2, "action_time_Minute"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@punch_note_code", System.Data.SqlDbType.VarChar, 50, "punch_note_code"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@In_Out_type", System.Data.SqlDbType.Int, 4, "In_Out_type"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE pay_punch_employee_in_out SET employee_code = @employee_code, action_date " & _
        "= @action_date, action_time_Hour = @action_time_Hour, action_time_Minute = @acti" & _
        "on_time_Minute, punch_note_code = @punch_note_code, In_Out_type = @In_Out_type W" & _
        "HERE (id_punch_in_out = @Original_id_punch_in_out) AND (In_Out_type = @Original_" & _
        "In_Out_type OR @Original_In_Out_type IS NULL AND In_Out_type IS NULL) AND (actio" & _
        "n_date = @Original_action_date OR @Original_action_date IS NULL AND action_date " & _
        "IS NULL) AND (action_time_Hour = @Original_action_time_Hour OR @Original_action_" & _
        "time_Hour IS NULL AND action_time_Hour IS NULL) AND (action_time_Minute = @Origi" & _
        "nal_action_time_Minute OR @Original_action_time_Minute IS NULL AND action_time_M" & _
        "inute IS NULL) AND (employee_code = @Original_employee_code OR @Original_employe" & _
        "e_code IS NULL AND employee_code IS NULL) AND (punch_note_code = @Original_punch" & _
        "_note_code OR @Original_punch_note_code IS NULL AND punch_note_code IS NULL); SE" & _
        "LECT id_punch_in_out, employee_code, action_date, action_time_Hour, action_time_" & _
        "Minute, punch_note_code, In_Out_type FROM pay_punch_employee_in_out WHERE (id_pu" & _
        "nch_in_out = @id_punch_in_out)"
        Me.SqlUpdateCommand1.Connection = Me.Cnn
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@employee_code", System.Data.SqlDbType.VarChar, 5, "employee_code"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@action_date", System.Data.SqlDbType.VarChar, 10, "action_date"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@action_time_Hour", System.Data.SqlDbType.VarChar, 2, "action_time_Hour"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@action_time_Minute", System.Data.SqlDbType.VarChar, 2, "action_time_Minute"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@punch_note_code", System.Data.SqlDbType.VarChar, 50, "punch_note_code"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@In_Out_type", System.Data.SqlDbType.Int, 4, "In_Out_type"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_punch_in_out", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_punch_in_out", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_In_Out_type", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "In_Out_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_action_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "action_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_action_time_Hour", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "action_time_Hour", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_action_time_Minute", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "action_time_Minute", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_employee_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employee_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_punch_note_code", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "punch_note_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@id_punch_in_out", System.Data.SqlDbType.Int, 4, "id_punch_in_out"))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM pay_punch_employee_in_out WHERE (id_punch_in_out = @Original_id_punch" & _
        "_in_out) AND (In_Out_type = @Original_In_Out_type OR @Original_In_Out_type IS NU" & _
        "LL AND In_Out_type IS NULL) AND (action_date = @Original_action_date OR @Origina" & _
        "l_action_date IS NULL AND action_date IS NULL) AND (action_time_Hour = @Original" & _
        "_action_time_Hour OR @Original_action_time_Hour IS NULL AND action_time_Hour IS " & _
        "NULL) AND (action_time_Minute = @Original_action_time_Minute OR @Original_action" & _
        "_time_Minute IS NULL AND action_time_Minute IS NULL) AND (employee_code = @Origi" & _
        "nal_employee_code OR @Original_employee_code IS NULL AND employee_code IS NULL) " & _
        "AND (punch_note_code = @Original_punch_note_code OR @Original_punch_note_code IS" & _
        " NULL AND punch_note_code IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.Cnn
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id_punch_in_out", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id_punch_in_out", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_In_Out_type", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "In_Out_type", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_action_date", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "action_date", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_action_time_Hour", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "action_time_Hour", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_action_time_Minute", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "action_time_Minute", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_employee_code", System.Data.SqlDbType.VarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "employee_code", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_punch_note_code", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "punch_note_code", System.Data.DataRowVersion.Original, Nothing))
        '
        'DApay_punch_employee_in_out
        '
        Me.DApay_punch_employee_in_out.DeleteCommand = Me.SqlDeleteCommand1
        Me.DApay_punch_employee_in_out.InsertCommand = Me.SqlInsertCommand1
        Me.DApay_punch_employee_in_out.SelectCommand = Me.SqlSelectCommand1
        Me.DApay_punch_employee_in_out.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "pay_punch_employee_in_out", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("id_punch_in_out", "id_punch_in_out"), New System.Data.Common.DataColumnMapping("employee_code", "employee_code"), New System.Data.Common.DataColumnMapping("action_date", "action_date"), New System.Data.Common.DataColumnMapping("action_time_Hour", "action_time_Hour"), New System.Data.Common.DataColumnMapping("action_time_Minute", "action_time_Minute"), New System.Data.Common.DataColumnMapping("punch_note_code", "punch_note_code"), New System.Data.Common.DataColumnMapping("In_Out_type", "In_Out_type")})})
        Me.DApay_punch_employee_in_out.UpdateCommand = Me.SqlUpdateCommand1
        '
        'FrmPunchClock
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(374, 241)
        Me.Controls.Add(Me.CmbPunch_note_code)
        Me.Controls.Add(Me.LblTime)
        Me.Controls.Add(Me.LblDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnOut)
        Me.Controls.Add(Me.BtnIn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblEmployeeName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Employee_Cod1)
        Me.Name = "FrmPunchClock"
        Me.Text = "Punch Clock"
        CType(Me.DsFrmPunchClock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmPunchClock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cnn.ConnectionString = PConnectionString
        DsFrmPunchClock1.Clear()
        DsFrmPunchClock1.pay_tab_punch_note.Addpay_tab_punch_noteRow("", "", 0)
        DApay_tab_punch_note.Fill(DsFrmPunchClock1, "pay_tab_punch_note")
        DsFrmPunchClock1.pay_tab_punch_note.DefaultView.RowFilter = "type_in_out = 0 "
        BtnIn.Cursor = Cursors.Hand
        BtnOut.Cursor = Cursors.Hand
        CmbPunch_note_code.SelectedValue = ""
        Call SetTimeAndDate()
    End Sub
    Private Sub SetTimeAndDate()
        LblDate.Text = Format(Now.Date, PubDateFormat)
        LblTime.Text = Format(TimeOfDay, "HH:mm:ss")
    End Sub
    Private Function IsEmployeeAtWork(ByVal ThisEmployeeCode As String) As Boolean
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        Dim IN_Out_Counter As Integer
        CmdGeneral.CommandText = "SELECT Count(*) from pay_punch_employee_in_out where In_Out_type=0 AND Employee_Code=" & Qt(ThisEmployeeCode) & " AND action_date=" & Qt(LblDate.Text)
        IN_Out_Counter = CmdGeneral.ExecuteScalar
        CmdGeneral.CommandText = "SELECT Count(*) from pay_punch_employee_in_out where In_Out_type=1 AND Employee_Code=" & Qt(ThisEmployeeCode) & " AND action_date=" & Qt(LblDate.Text)
        IN_Out_Counter = IN_Out_Counter - CmdGeneral.ExecuteScalar
        If IN_Out_Counter > 0 Then
            IsEmployeeAtWork = True
        Else
            IsEmployeeAtWork = False
        End If
    End Function
    Private Sub Employee_Cod1_NotFindEmployeeCod() Handles Employee_Cod1.NotFindEmployeeCod
        LblEmployeeName.Text = ""
    End Sub
    Private Sub Employee_Cod1_FindEmployeeCod() Handles Employee_Cod1.FindEmployeeCod
        LblEmployeeName.Text = Employee_Cod1.Desc_Employee
        If IsEmployeeAtWork(Employee_Cod1.EmployeeCod) Then
            DsFrmPunchClock1.pay_tab_punch_note.DefaultView.RowFilter = ""
            DsFrmPunchClock1.pay_tab_punch_note.Rows(0).Item("type_in_out") = 0
            BtnIn.SendToBack()
            BtnIn.Enabled = False
            BtnIn.Visible = False
            BtnOut.BringToFront()
            BtnOut.Enabled = True
            BtnOut.Visible = True
            DsFrmPunchClock1.pay_tab_punch_note.DefaultView.RowFilter = "type_in_out = 0 "
        Else
            DsFrmPunchClock1.pay_tab_punch_note.DefaultView.RowFilter = ""
            DsFrmPunchClock1.pay_tab_punch_note.Rows(0).Item("type_in_out") = 1
            BtnOut.SendToBack()
            BtnOut.Enabled = False
            BtnOut.Visible = False
            BtnIn.BringToFront()
            BtnIn.Enabled = True
            BtnIn.Visible = True
            DsFrmPunchClock1.pay_tab_punch_note.DefaultView.RowFilter = "type_in_out = 1 "
        End If
        CmbPunch_note_code.SelectedValue = ""
    End Sub
    Private Function ClockINConflict() As Boolean
        ClockINConflict = False
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        CmdGeneral.CommandText = "SELECT Top 1 in_out_type from pay_punch_employee_in_out where Employee_Code=" & Qt(Employee_Cod1.cod_Employee) & " AND action_date=" & Qt(LblDate.Text) & _
        " AND action_time_hour+':'+action_time_Minute<=" & Qt(Mid(LblTime.Text, 1, 5)) & " Order by action_time_hour+':'+action_time_Minute Desc"
        If CmdGeneral.ExecuteScalar() & "" = "0" Then
            MsgBox("Conflict in IN Time.", MsgBoxStyle.Exclamation)
            ClockINConflict = True
            Exit Function
        End If
        CmdGeneral.CommandText = "SELECT Top 1 in_out_type from pay_punch_employee_in_out where Employee_Code=" & Qt(Employee_Cod1.cod_Employee) & " AND action_date=" & Qt(LblDate.Text) & _
        " AND action_time_hour+':'+action_time_Minute>=" & Qt(Mid(LblTime.Text, 1, 5)) & " Order by action_time_hour+':'+action_time_Minute ASC"
        If CmdGeneral.ExecuteScalar() & "" = "1" Then
            MsgBox("Conflict in IN Time.", MsgBoxStyle.Exclamation)
            ClockINConflict = True
            Exit Function
        End If

    End Function
    Private Function ClockOUTConflict() As Boolean
        ClockOUTConflict = False
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If

        CmdGeneral.CommandText = "SELECT Top 1 in_out_type from pay_punch_employee_in_out where Employee_Code=" & Qt(Employee_Cod1.cod_Employee) & " AND action_date=" & Qt(LblDate.Text) & _
        " AND action_time_hour+':'+action_time_Minute<=" & Qt(Mid(LblTime.Text, 1, 5)) & " Order by action_time_hour+':'+action_time_Minute Desc"
        If CmdGeneral.ExecuteScalar() & "" = "1" Then
            MsgBox("Conflict in Out Time.", MsgBoxStyle.Exclamation)
            ClockOUTConflict = True
            Exit Function
        End If
        CmdGeneral.CommandText = "SELECT Top 1 in_out_type from pay_punch_employee_in_out where Employee_Code=" & Qt(Employee_Cod1.cod_Employee) & " AND action_date=" & Qt(LblDate.Text) & _
        " AND action_time_hour+':'+action_time_Minute>=" & Qt(Mid(LblTime.Text, 1, 5)) & " Order by action_time_hour+':'+action_time_Minute ASC"
        If CmdGeneral.ExecuteScalar() & "" = "1" Then
            MsgBox("Conflict in Out Time.", MsgBoxStyle.Exclamation)
            ClockOUTConflict = True
            Exit Function
        End If
    End Function
    Private Sub BtnOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOut.Click, BtnIn.Click
        If CmdGeneral.Connection.State <> ConnectionState.Open Then
            CmdGeneral.Connection.Open()
        End If
        If BtnIn.Visible Then
            If ClockINConflict() Then
                Exit Sub
            End If
        Else
            If ClockOUTConflict() Then
                Exit Sub
            End If
        End If
        CmdGeneral.CommandText = "INSERT INTO pay_punch_employee_in_out " & _
                                 "(employee_code, action_date, action_time_hour, action_time_Minute, punch_note_code,In_Out_type) Values " & _
                                 "(" & Qt(Employee_Cod1.EmployeeCod) & "," & Qt(Format(Date.Now, PubDateFormat)) & "," & Qt(Format(TimeOfDay, "HH")) & "," & Qt(Format(TimeOfDay, "mm")) & "," & Qt(CmbPunch_note_code.Text) & "," & IIf(BtnIn.Visible, 0, 1) & ")"
        Try
            CmdGeneral.ExecuteNonQuery()
            Dim SoundInst As New SoundClass
            If BtnIn.Visible Then
                SoundInst.PlaySoundFile(PubMainImagePath & "\In.wav")
            Else
                SoundInst.PlaySoundFile(PubMainImagePath & "\Out.wav")
            End If
            BtnIn.Enabled = False
            BtnOut.Enabled = False
            Employee_Cod1.EmployeeCod = ""
            CmbPunch_note_code.SelectedValue = ""
        Catch ex As Exception
            MsgBox("This Employee has record For the same date and time")
        End Try
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Call SetTimeAndDate()
    End Sub
End Class
